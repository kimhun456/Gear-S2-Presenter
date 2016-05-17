var async = require('async')
	, pb = require('pb')
	, debug = require('debug')('pbci:tests:1click')

module.exports = function(minitest, assets, options){
	options || (options = {});

  var testDuration = 25000 * (options.timeout || 1)
    , suite  = minitest.describe('1click login', assets.map(function(asset){ return asset.get('name') }))

	function getTest(key, val){
		var test;

		suite.tests.some(function(t){
			if ((t[key] || t.get(key)) === val){
				test = t;
				return true;
			}
		});

		return test;
	}

	function listener(message, sender){
		if (message.type !== 'test') return;

		var test = getTest('tabId', sender.tab.id);
		if (!test) return;
		if (test.state !== 'pending') return; // already done

		if (message.name === 'background data received'){
			var events = message.data && message.data.events && message.data.events.slice();
			test.set('events', events);

			test.dom || (test.dom = {});
			test.dom[message.data.uuid] || (test.dom[message.data.uuid] = {});
			test.dom[message.data.uuid].loaded = true;
			if(message.data.iFrame === false) test.set('toploaded', true);
			var domLoading = Object.keys(test.dom).some(function(id){ return test.dom[id].loaded = false })
			test.set('domloaded', !domLoading);
		}

		if (message.name === 'contentscript injected'){
			test.dom || (test.dom = {});
			test.dom[message.data.uuid] || (test.dom[message.data.uuid] = {});
			test.dom[message.data.uuid].iFrame = message.data.iFrame;
			test.dom[message.data.uuid].uuid = message.data.uuid;
			test.dom[message.data.uuid].loaded = false;
			if(message.data.iFrame === false) test.set('toploaded', false);
		}

		if (message.name === 'domready'){
		}

		if (message.name !== 'logged in') return;
		if (!message.status) return; // not the result we're expecting

		clearTimeout(test.get('timeout'));
		suite.pass(test);
		chrome.tabs.remove(sender.tab.id);
	}

	function testAsset(asset, done){
		var title = asset.get('name')
			, url = pb.oneClickUrl(asset.get('url'), asset.id)
			, test = getTest('title', title)

		clearTimeout(test.get('timeout'));

		test.inc('runs');
		test.emit('run');

		var duration = Math.min(testDuration * test.get('runs'), 45000);

		debug('start', title, test.state, test.get('runs'), duration);

		test.set('domloaded', false);

		chrome.tabs.create({url: url, active: false}, function(tab){
			test
			.set('asset', asset)
			.set('tabId', tab.id)
			.done(done)
			.set('timeout', setTimeout(function(){

				chrome.tabs.remove(tab.id);

				// determine if test failed legitimally.

				var domloaded  = test.get('domloaded');
				var toploaded  = test.get('toploaded');
				var runs       = test.get('runs');
				var events     = test.get('events');
				var maxRuns    = 2;

				var bgReceived = events && events.some(function(e){ return e.name === 'background data received' && e.data.iFrame === false });
				var nothingAfterSubmit = events && events.length && events[events.length - 1].name === 'submit form';

				if(!events || !toploaded || !bgReceived || nothingAfterSubmit){

					if (runs < maxRuns){ // give it a chance.
						  debug(test.title, 'runs < maxRuns');
							debug(test.title, tab.id, 'run again', {runs: runs, toploaded: toploaded, domloaded: domloaded, bgReceived: bgReceived, nothingAfterSubmit: nothingAfterSubmit, duration: duration});
							testAsset(asset, done);

					} else if (runs === maxRuns) { // run one last time individually.
						  debug(test.title, 'runs === maxRuns');
						  debug(test.title, tab.id, 'keep till the end', {runs: runs, toploaded: toploaded, domloaded: domloaded, bgReceived: bgReceived, nothingAfterSubmit: nothingAfterSubmit, duration: duration});
							done();

					} else if (runs > maxRuns) { // we tried everything.
						  debug(test.title, 'runs > maxRuns');
							debug(test.title, tab.id, 'fail', {runs: runs, toploaded: toploaded, domloaded: domloaded, bgReceived: bgReceived, nothingAfterSubmit: nothingAfterSubmit, duration: duration}, test.get('events'));
							suite.fail(test);
					}

				} else { // looks like a legit fail.

					debug(test.title, tab.id, 'fail', {runs: runs, toploaded: toploaded, domloaded: domloaded, bgReceived: bgReceived, nothingAfterSubmit: nothingAfterSubmit, duration: duration}, test.get('events'));
					suite.fail(test);

				}

			}, duration));
		});
	}

	suite.on('start', function(){
		pb.cookies.clear(function(){
			pb.setEnv();
			pb.isTabIgnored.stub();
			chrome.runtime.onMessage.addListener(listener);
			var allDone = false;

			async.forEachLimit(assets, 3, function(asset, done){
				testAsset(asset, function(){
					if(!allDone) done();
				});
			}, function(){

				allDone = true;

				// check for tests still remaining.

				var tests = suite.tests.filter(function(t){ return t.state === 'pending' });
				var assets = tests.map(function(t){ return t.get('asset') });

				debug(JSON.stringify(tests.map(function(t){ return {title: t.title, runs: t && t.get('runs')} })));
				debug(JSON.stringify(assets.map(function(t){ return t && t.get('name')})));

				async.forEachSeries(assets, function(asset, next){
					pb.cookies.clear(function(){
						testAsset(asset, next);
					});
				}, function(){
					debug('done with individual tests');
				});

			});
		});
	});

	suite.on('end', function(){
		pb.cookies.clear(function(){
			pb.isTabIgnored.restore();
			chrome.runtime.onMessage.removeListener(listener);
		});
	});
}
