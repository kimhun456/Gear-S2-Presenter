S/W Version Information
Model: Wearable-Emulator
Tizen-Version: 2.3.1
Build-Number: Tizen-2.3.1_Wearable-Emulator_20160504.1922
Build-Date: 2016.05.04 19:22:44

Crash Information
Process Name: basicui
PID: 4354
Date: 2016-05-24 17:36:06+0900
Executable File Path: /opt/usr/apps/org.example.basicui/bin/basicui
Signal: 11
      (SIGSEGV)
      si_code: 2
      invalid permissions for mapped object
      si_addr = 0xb7255dde

Register Information
gs  = 0x00000033, fs  = 0x00000000
es  = 0x0000007b, ds  = 0x0000007b
edi = 0x00000009, esi = 0x00000005
ebp = 0xbfa6d148, esp = 0xbfa6d120
eax = 0xb451970c, ebx = 0xb6ff53bc
ecx = 0x0000003c, edx = 0xb7255dde
eip = 0xb6fc654d

Memory Information
MemTotal:      124 KB
MemFree:        61 KB
Buffers:         4 KB
Cached:     143184 KB
VmPeak:      72188 KB
VmSize:      72188 KB
VmLck:           0 KB
VmPin:           0 KB
VmHWM:       13368 KB
VmRSS:       13368 KB
VmData:      11544 KB
VmStk:         136 KB
VmExe:          28 KB
VmLib:       31832 KB
VmPTE:          60 KB
VmSwap:          0 KB

Threads Information
Threads: 2
PID = 4354 TID = 4354
4354 4358 

Maps Information
b3424000 b3448000 r-xp /usr/lib/edje/modules/elm/linux-gnu-i686-1.0.0/module.so
b35ea000 b35ed000 r-xp /usr/lib/libdrm_vigs.so.9.0.0
b35ee000 b35fc000 r-xp /usr/lib/evas/modules/engines/software_generic/linux-gnu-i686-1.7.99/module.so
b35fd000 b360c000 r-xp /usr/lib/evas/modules/engines/software_x11/linux-gnu-i686-1.7.99/module.so
b3e11000 b3e14000 r-xp /usr/lib/bufmgr/libtbm_emulator.so.0.0.0
b3e15000 b3e18000 r-xp /usr/lib/libdri2.so.0.0.0
b3e19000 b3e24000 r-xp /usr/lib/libdrm.so.2.4.0
b3e25000 b3e2e000 r-xp /usr/lib/libtbm.so.1.0.0
b3e2f000 b3e36000 r-xp /usr/lib/libcapi-media-tool.so.0.1.1
b3e37000 b3e40000 r-xp /usr/lib/libmmutil_imgp.so.0.0.0
b3e41000 b3e48000 r-xp /usr/lib/libmmutil_jpeg.so.0.0.0
b3e49000 b3e4f000 r-xp /usr/lib/libcapi-system-info.so.0.2.0
b3e50000 b3e58000 r-xp /usr/lib/libxcb-render.so.0.0.0
b3e59000 b3e76000 r-xp /usr/lib/libtts.so
b3e77000 b3fbb000 r-xp /usr/lib/libcairo.so.2.11200.14
b3fbf000 b3fd7000 r-xp /usr/lib/libefl-assist.so.0.1.0
b3fd8000 b3ff9000 r-xp /usr/lib/libefl-extension.so.0.1.0
b3ffa000 b400a000 r-xp /usr/lib/libcapi-system-system-settings.so.0.0.2
b400b000 b4016000 r-xp /lib/libnss_files-2.13.so
b4337000 b435e000 r-xp /usr/lib/libsecurity-server-commons.so.1.0.0
b435f000 b4384000 r-xp /usr/lib/libsecurity-server-client.so.1.0.1
b4385000 b44a6000 r-xp /usr/lib/libscim-1.0.so.8.2.3
b44b6000 b44ec000 r-xp /usr/lib/ecore/immodules/libisf-imf-module.so
b44ee000 b44f1000 r-xp /usr/lib/libiniparser.so.0
b44f3000 b44fe000 r-xp /usr/lib/libcapi-security-privilege-manager.so.0.0.3
b44ff000 b4508000 r-xp /usr/lib/libappsvc.so.0.1.0
b4509000 b450c000 r-xp /usr/lib/libcapi-appfw-app-common.so.0.3.1.0
b4510000 b4512000 r-xp /usr/lib/libxcb-shm.so.0.0.0
b4513000 b4517000 r-xp /usr/lib/libcapi-media-image-util.so.0.1.3
b4518000 b451a000 r-xp /opt/usr/apps/org.example.basicui/bin/basicui
b451b000 b4521000 r-xp /usr/lib/libogg.so.0.7.1
b4522000 b454d000 r-xp /usr/lib/libvorbis.so.0.4.3
b454e000 b4639000 r-xp /usr/lib/libvorbisenc.so.2.0.6
b4647000 b4649000 r-xp /usr/lib/libXau.so.6.0.0
b464a000 b46aa000 r-xp /usr/lib/libssl.so.1.0.0
b46af000 b46e0000 r-xp /usr/lib/libidn.so.11.5.44
b46e1000 b46f1000 r-xp /usr/lib/libcares.so.2.1.0
b46f2000 b475b000 r-xp /usr/lib/libsndfile.so.1.0.25
b4761000 b476b000 r-xp /usr/lib/libsensord-share.so
b476c000 b4792000 r-xp /lib/libexpat.so.1.5.2
b4794000 b47bb000 r-xp /usr/lib/libpng12.so.0.50.0
b47bc000 b47dc000 r-xp /usr/lib/libxcb.so.1.1.0
b47dd000 b484c000 r-xp /usr/lib/libcurl.so.4.3.0
b484e000 b4859000 r-xp /usr/lib/libethumb.so.1.7.99
b5db9000 b5e91000 r-xp /usr/lib/libstdc++.so.6.0.16
b5e9d000 b5ea0000 r-xp /usr/lib/libctxdata.so.0.0.0
b5ea1000 b5eb7000 r-xp /usr/lib/libremix.so.0.0.0
b5eb8000 b5eba000 r-xp /usr/lib/libecore_imf_evas.so.1.7.99
b5ebb000 b5ee7000 r-xp /usr/lib/liblua-5.1.so
b5ee8000 b5ef2000 r-xp /usr/lib/libembryo.so.1.7.99
b5ef3000 b5f39000 r-xp /usr/lib/libjpeg.so.8.0.2
b5f4a000 b5f68000 r-xp /usr/lib/libsensor.so.1.1.0
b5f6a000 b5fec000 r-xp /usr/lib/libpixman-1.so.0.28.2
b5ff1000 b6025000 r-xp /usr/lib/libfontconfig.so.1.5.0
b6027000 b6082000 r-xp /usr/lib/libharfbuzz.so.0.940.0
b6084000 b609a000 r-xp /usr/lib/libfribidi.so.0.3.1
b609b000 b6127000 r-xp /usr/lib/libfreetype.so.6.11.3
b612b000 b612e000 r-xp /usr/lib/libecore_input_evas.so.1.7.99
b612f000 b6135000 r-xp /usr/lib/libecore_ipc.so.1.7.99
b6136000 b613c000 r-xp /usr/lib/libecore_fb.so.1.7.99
b613e000 b614f000 r-xp /usr/lib/libXext.so.6.4.0
b6150000 b6284000 r-xp /usr/lib/libX11.so.6.3.0
b6288000 b628d000 r-xp /usr/lib/libXtst.so.6.1.0
b628e000 b6296000 r-xp /usr/lib/libXrender.so.1.3.0
b6297000 b62a0000 r-xp /usr/lib/libXrandr.so.2.2.0
b62a1000 b62a3000 r-xp /usr/lib/libXinerama.so.1.0.0
b62a4000 b62b2000 r-xp /usr/lib/libXi.so.6.1.0
b62b3000 b62b7000 r-xp /usr/lib/libXfixes.so.3.1.0
b62b8000 b62ba000 r-xp /usr/lib/libXgesture.so.7.0.0
b62bb000 b62bd000 r-xp /usr/lib/libXcomposite.so.1.0.0
b62be000 b62c0000 r-xp /usr/lib/libXdamage.so.1.1.0
b62c1000 b62ca000 r-xp /usr/lib/libXcursor.so.1.0.2
b62cb000 b62f6000 r-xp /usr/lib/libecore_con.so.1.7.99
b62f8000 b6300000 r-xp /usr/lib/libecore_imf.so.1.7.99
b6301000 b630c000 r-xp /usr/lib/libethumb_client.so.1.7.99
b630d000 b6313000 r-xp /usr/lib/libefreet_mime.so.1.7.99
b6314000 b6335000 r-xp /usr/lib/libefreet.so.1.7.99
b6337000 b6343000 r-xp /usr/lib/libedbus.so.1.7.99
b6344000 b64a3000 r-xp /usr/lib/libicuuc.so.51.1
b64b1000 b66ba000 r-xp /usr/lib/libicui18n.so.51.1
b66c3000 b6760000 r-xp /usr/lib/libedje.so.1.7.99
b6762000 b6773000 r-xp /usr/lib/libecore_input.so.1.7.99
b6774000 b677b000 r-xp /usr/lib/libecore_file.so.1.7.99
b677c000 b67a2000 r-xp /usr/lib/libeet.so.1.7.99
b67ab000 b68d3000 r-xp /usr/lib/libevas.so.1.7.99
b68f0000 b6924000 r-xp /usr/lib/libecore_evas.so.1.7.99
b6926000 b696a000 r-xp /usr/lib/libecore_x.so.1.7.99
b696c000 b6b66000 r-xp /usr/lib/libelementary.so.1.7.99
b6b77000 b6b7d000 r-xp /usr/lib/libcapi-appfw-app-control.so.0.3.1.0
b6b7e000 b6b82000 r-xp /usr/lib/libcapi-appfw-application.so.0.3.1.0
b6b87000 b6b88000 r-xp /usr/lib/libjournal.so.0.1.0
b6b89000 b6cd1000 r-xp /usr/lib/libxml2.so.2.7.8
b6cd7000 b6cea000 r-xp /lib/libresolv-2.13.so
b6cee000 b6d0b000 r-xp /lib/libz.so.1.2.5
b6d0c000 b6d0f000 r-xp /usr/lib/libgmodule-2.0.so.0.3200.3
b6d11000 b6d16000 r-xp /usr/lib/libffi.so.5.0.10
b6d17000 b6d18000 r-xp /usr/lib/libgthread-2.0.so.0.3200.3
b6d19000 b6d1d000 r-xp /lib/libattr.so.1.1.0
b6d1e000 b6f31000 r-xp /usr/lib/libcrypto.so.1.0.0
b6f4c000 b6f6d000 r-xp /usr/lib/libpkgmgr_parser.so.0.1.0
b6f6f000 b6f97000 r-xp /lib/libm-2.13.so
b6f99000 b6ff4000 r-xp /usr/lib/libeina.so.1.7.99
b6ff6000 b7001000 r-xp /usr/lib/libvconf.so.0.2.45
b7002000 b7005000 r-xp /usr/lib/libSLP-db-util.so.0.1.0
b7006000 b7054000 r-xp /usr/lib/libgobject-2.0.so.0.3200.3
b7056000 b71b7000 r-xp /usr/lib/libgio-2.0.so.0.3200.3
b71bb000 b71c2000 r-xp /lib/librt-2.13.so
b71c4000 b71cb000 r-xp /usr/lib/libcapi-base-common.so.0.1.9
b71cd000 b71e7000 r-xp /lib/libgcc_s-4.6.4.so.1
b71e8000 b71f0000 r-xp /lib/libcrypt-2.13.so
b721a000 b721e000 r-xp /lib/libcap.so.2.21
b721f000 b7221000 r-xp /usr/lib/libiri.so
b7222000 b724e000 r-xp /usr/lib/libpkgmgr-info.so.0.0.17
b724f000 b726f000 r-xp /usr/lib/libecore.so.1.7.99
b727e000 b7287000 r-xp /usr/lib/libxdgmime.so.1.1.0
b7289000 b73ac000 r-xp /usr/lib/libglib-2.0.so.0.3200.3
b73ad000 b73c0000 r-xp /usr/lib/libail.so.0.1.0
b73c1000 b73e6000 r-xp /usr/lib/libdbus-glib-1.so.2.2.2
b73e7000 b73f1000 r-xp /lib/libunwind.so.8.0.1
b73fb000 b757b000 r-xp /lib/libc-2.13.so
b7583000 b75cd000 r-xp /usr/lib/libdbus-1.so.3.7.2
b75ce000 b75d3000 r-xp /usr/lib/libbundle.so.0.1.22
b75d4000 b75d7000 r-xp /lib/libdl-2.13.so
b75d9000 b75de000 r-xp /usr/lib/libsmack.so.1.0.0
b75df000 b7687000 r-xp /usr/lib/libsqlite3.so.0.8.6
b768a000 b76a4000 r-xp /usr/lib/libprivilege-control.so.0.0.2
b76a5000 b76bc000 r-xp /lib/libpthread-2.13.so
b76c0000 b76c3000 r-xp /usr/lib/libdlog.so.0.0.0
b76c4000 b76d4000 r-xp /usr/lib/libaul.so.0.1.0
b76d6000 b76dc000 r-xp /usr/lib/libappcore-common.so.1.1
b76dd000 b76e2000 r-xp /usr/lib/libappcore-efl.so.1.1
b76e4000 b76e9000 r-xp /usr/lib/libsys-assert.so
b76ec000 b76ed000 r-xp [vdso]
b76ed000 b770b000 r-xp /lib/ld-2.13.so
b770d000 b7714000 r-xp /usr/bin/launchpad_preloading_preinitializing_daemon
End of Maps Information

Callstack Information (PID:4354)
Call Stack Count: 12
 0: eina_strlcat + 0x5d (0xb6fc654d) [/usr/lib/libeina.so.1] + 0x2d54d
 1: ticktock + 0x5a (0xb4518d1a) [/opt/usr/apps/org.example.basicui/bin/basicui] + 0xd1a
 2: (0xb7261387) [/usr/lib/libecore.so.1] + 0x12387
 3: (0xb726155f) [/usr/lib/libecore.so.1] + 0x1255f
 4: (0xb725d2d2) [/usr/lib/libecore.so.1] + 0xe2d2
 5: ecore_main_loop_begin + 0x3f (0xb725d9cf) [/usr/lib/libecore.so.1] + 0xe9cf
 6: elm_run + 0x17 (0xb6a738a7) [/usr/lib/libelementary.so.1] + 0x1078a7
 7: appcore_efl_main + 0x3d1 (0xb76dfe91) [/usr/lib/libappcore-efl.so.1] + 0x2e91
 8: ui_app_main + 0x130 (0xb6b80570) [/usr/lib/libcapi-appfw-application.so.0] + 0x2570
 9: main + 0x292 (0xb45190b2) [/opt/usr/apps/org.example.basicui/bin/basicui] + 0x10b2
10: (0xb77105d1) [/opt/usr/apps/org.example.basicui/bin/basicui] + 0xb77105d1
11: __libc_start_main + 0xf3 (0xb74141a3) [/lib/libc.so.6] + 0x191a3
End of Call Stack

Package Information
Package Name: org.example.basicui
Package ID : org.example.basicui
Version: 1.0.0
Package Type: rpm
App Name: basicui
App ID: org.example.basicui
Type: capp
Categories: 

Latest Debug Message Information
--------- beginning of /dev/log_main
4.326+0900 I/AUL_PAD ( 2209): sigchild.h: __sigchild_action(123) > dead_pid(4212)
05-24 17:35:44.326+0900 D/AUL_PAD ( 2209): sigchild.h: __send_app_dead_signal(81) > send dead signal done
05-24 17:35:44.326+0900 I/AUL_PAD ( 2209): sigchild.h: __sigchild_action(129) > __send_app_dead_signal(0)
05-24 17:35:44.326+0900 I/AUL_PAD ( 2209): sigchild.h: __launchpad_sig_child(150) > after __sigchild_action
05-24 17:35:44.326+0900 I/AUL_AMD ( 2192): amd_main.c: __app_dead_handler(262) > __app_dead_handler, pid: 4212
05-24 17:35:44.326+0900 D/AUL_AMD ( 2192): amd_key.c: _unregister_key_event(161) > ===key stack===
05-24 17:35:44.326+0900 D/AUL     ( 2192): simple_util.c: __trm_app_info_send_socket(261) > __trm_app_info_send_socket
05-24 17:35:44.326+0900 E/AUL     ( 2192): simple_util.c: __trm_app_info_send_socket(264) > access
05-24 17:35:44.326+0900 D/STARTER ( 2271): starter_w.c: _w_app_dead_cb(183) > [STARTER/home/abuild/rpmbuild/BUILD/starter-0.5.52/src/starter_w.c:183:D] app dead cb call! (pid : 4212)
05-24 17:35:44.336+0900 W/CRASH_MANAGER( 4217): worker.c: worker_job(1189) > 11042126261731464078944
05-24 17:35:44.386+0900 D/W_HOME  ( 2278): main.c: _window_focus_in_cb(848) > focus in
05-24 17:35:44.386+0900 D/W_HOME  ( 2278): main.c: _resume_cb(564) > Resumed
05-24 17:35:44.386+0900 D/APPS    ( 2278): apps_main.c: apps_main_is_visible(757) >  bShow:[0]
05-24 17:35:44.386+0900 D/W_HOME  ( 2278): scroller.c: _resume_result_cb(623) > Activate the rotary events for Home
05-24 17:35:44.386+0900 E/efl-extension( 2278): efl_extension_rotary.c: eext_rotary_object_event_activated_set(301) > eext_rotary_object_event_activated_set : 0xb82a64b8, elm_scroller, _activated_obj : 0xb82a64b8, activated : 1
05-24 17:35:44.386+0900 E/APPS    ( 2278): apps_main.c: _window_focus_in_cb(293) >  win[23068679], ev->win[23068675]
05-24 17:35:44.386+0900 W/W_HOME  ( 2278): main.c: _window_visibility_cb(796) > Window [0x1600003] is now visible(0)
05-24 17:35:44.386+0900 D/APP_CORE( 2278): appcore-efl.c: __update_win(718) > [EVENT_TEST][EVENT] __update_win WIN:1600003 fully_obscured 0
05-24 17:35:44.386+0900 D/APP_CORE( 2278): appcore-efl.c: __visibility_cb(884) > bvisibility 1, b_active 0
05-24 17:35:44.386+0900 D/APP_CORE( 2278): appcore-efl.c: __visibility_cb(887) >  Go to Resume state
05-24 17:35:44.386+0900 D/W_HOME  ( 2278): main.c: _dead_cb(542) > PID(4212) is dead
05-24 17:35:44.386+0900 E/W_HOME  ( 2278): clock_shortcut.c: _shortcut_icon_owner_get(190) > (icon == NULL) -> _shortcut_icon_owner_get() return
05-24 17:35:45.256+0900 D/PKGMGR_INFO( 4217): pkgmgrinfo_appinfo.c: pkgmgrinfo_appinfo_filter_count(3078) > [SECURE_LOG] where = package_app_info.app_exec='/opt/usr/apps/org.example.basicui/bin/basicui' and package_app_info.app_disable IN ('false','False')
05-24 17:35:45.256+0900 D/PKGMGR_INFO( 4217): pkgmgrinfo_appinfo.c: pkgmgrinfo_appinfo_filter_count(3084) > [SECURE_LOG] query = select DISTINCT package_app_info.app_id, package_app_info.app_component, package_app_info.app_installed_storage from package_app_info LEFT OUTER JOIN package_app_localized_info ON package_app_info.app_id=package_app_localized_info.app_id and package_app_localized_info.app_locale='en-gb' LEFT OUTER JOIN package_app_app_svc ON package_app_info.app_id=package_app_app_svc.app_id LEFT OUTER JOIN package_app_app_category ON package_app_info.app_id=package_app_app_category.app_id where package_app_info.app_exec='/opt/usr/apps/org.example.basicui/bin/basicui' and package_app_info.app_disable IN ('false','False')
05-24 17:35:45.256+0900 D/PKGMGR_INFO( 4217): pkgmgrinfo_appinfo.c: pkgmgrinfo_appinfo_filter_foreach_appinfo(3193) > [SECURE_LOG] where = package_app_info.app_exec='/opt/usr/apps/org.example.basicui/bin/basicui' and package_app_info.app_disable IN ('false','False')
05-24 17:35:45.256+0900 D/PKGMGR_INFO( 4217): pkgmgrinfo_appinfo.c: pkgmgrinfo_appinfo_filter_foreach_appinfo(3199) > [SECURE_LOG] query = select DISTINCT package_app_info.*, package_app_localized_info.app_locale, package_app_localized_info.app_label, package_app_localized_info.app_icon from package_app_info LEFT OUTER JOIN package_app_localized_info ON package_app_info.app_id=package_app_localized_info.app_id and package_app_localized_info.app_locale IN ('No Locale', 'en-gb') LEFT OUTER JOIN package_app_app_svc ON package_app_info.app_id=package_app_app_svc.app_id LEFT OUTER JOIN package_app_app_category ON package_app_info.app_id=package_app_app_category.app_id where package_app_info.app_exec='/opt/usr/apps/org.example.basicui/bin/basicui' and package_app_info.app_disable IN ('false','False')
05-24 17:35:45.266+0900 D/PKGMGR_INFO( 4217): pkgmgrinfo_appinfo.c: pkgmgrinfo_appinfo_filter_foreach_appinfo(3193) > [SECURE_LOG] where = package_app_info.app_exec='/opt/usr/apps/org.example.basicui/bin/basicui' and package_app_info.app_disable IN ('false','False')
05-24 17:35:45.266+0900 D/PKGMGR_INFO( 4217): pkgmgrinfo_appinfo.c: pkgmgrinfo_appinfo_filter_foreach_appinfo(3199) > [SECURE_LOG] query = select DISTINCT package_app_info.*, package_app_localized_info.app_locale, package_app_localized_info.app_label, package_app_localized_info.app_icon from package_app_info LEFT OUTER JOIN package_app_localized_info ON package_app_info.app_id=package_app_localized_info.app_id and package_app_localized_info.app_locale IN ('No Locale', 'en-gb') LEFT OUTER JOIN package_app_app_svc ON package_app_info.app_id=package_app_app_svc.app_id LEFT OUTER JOIN package_app_app_category ON package_app_info.app_id=package_app_app_category.app_id where package_app_info.app_exec='/opt/usr/apps/org.example.basicui/bin/basicui' and package_app_info.app_disable IN ('false','False')
05-24 17:35:45.386+0900 D/AUL     ( 4238): launch.c: app_request_to_launchpad(281) > [SECURE_LOG] launch request : org.tizen.crash-popup
05-24 17:35:45.386+0900 D/AUL     ( 4238): app_sock.c: __app_send_raw(270) > pid(-2) : cmd(0)
05-24 17:35:45.396+0900 D/AUL_AMD ( 2192): amd_request.c: __request_handler(502) > __request_handler: 0
05-24 17:35:45.396+0900 D/AUL_AMD ( 2192): amd_request.c: __request_handler(547) > launch a single-instance appid: org.tizen.crash-popup
05-24 17:35:45.396+0900 D/AUL     ( 2192): pkginfo.c: aul_app_get_appid_bypid(205) > second change pgid = 2147, pid = 4238
05-24 17:35:45.396+0900 D/AUL_AMD ( 2192): amd_launch.c: _start_app(1486) > [SECURE_LOG] caller : (null)
05-24 17:35:45.396+0900 D/AUL_AMD ( 2192): amd_launch.c: _start_app(1792) > process_pool: false
05-24 17:35:45.396+0900 D/AUL_AMD ( 2192): amd_launch.c: _start_app(1795) > h/w acceleration: SYS
05-24 17:35:45.396+0900 D/AUL_AMD ( 2192): amd_launch.c: _start_app(1797) > [SECURE_LOG] appid: org.tizen.crash-popup
05-24 17:35:45.396+0900 D/AUL_AMD ( 2192): amd_launch.c: __set_appinfo_for_launchpad(1959) > Add hwacc, taskmanage, app_path and pkg_type into bundle for sending those to launchpad.
05-24 17:35:45.396+0900 D/AUL     ( 2192): app_sock.c: __app_send_raw(270) > pid(-1) : cmd(0)
05-24 17:35:45.396+0900 D/AUL_PAD ( 2209): launchpad.c: __launchpad_main_loop(641) > [SECURE_LOG] pkg name : org.tizen.crash-popup
05-24 17:35:45.396+0900 D/AUL_PAD ( 2209): launchpad.c: __modify_bundle(380) > parsing app_path: No arguments
05-24 17:35:45.396+0900 D/AUL_PAD ( 2209): launchpad.c: __launchpad_main_loop(699) > [SECURE_LOG] ==> real launch pid : 4239 /usr/apps/org.tizen.crash-popup/bin/crash-popup
05-24 17:35:45.396+0900 D/AUL_PAD ( 2209): launchpad.c: __send_result_to_caller(555) > -- now wait to change cmdline --
05-24 17:35:45.396+0900 D/AUL_PAD ( 4239): launchpad.c: __launchpad_main_loop(668) > lock up test log(no error) : fork done
05-24 17:35:45.396+0900 D/AUL_PAD ( 4239): launchpad.c: __launchpad_main_loop(679) > lock up test log(no error) : prepare exec - first done
05-24 17:35:45.396+0900 D/AUL_PAD ( 4239): launchpad.c: __prepare_exec(136) > [SECURE_LOG] pkg_name : org.tizen.crash-popup / pkg_type : rpm / app_path : /usr/apps/org.tizen.crash-popup/bin/crash-popup 
05-24 17:35:45.396+0900 D/AUL_PAD ( 4239): launchpad.c: __launchpad_main_loop(693) > lock up test log(no error) : prepare exec - second done
05-24 17:35:45.396+0900 D/AUL_PAD ( 4239): launchpad.c: __real_launch(223) > [SECURE_LOG] input argument 0 : /usr/apps/org.tizen.crash-popup/bin/crash-popup##
05-24 17:35:45.396+0900 D/AUL_PAD ( 4239): launchpad.c: __real_launch(223) > [SECURE_LOG] input argument 2 : _PROCESS_NAME_##
05-24 17:35:45.396+0900 D/AUL_PAD ( 4239): launchpad.c: __real_launch(223) > [SECURE_LOG] input argument 4 : _EXEPATH_##
05-24 17:35:45.396+0900 D/AUL_PAD ( 4239): launchpad.c: __real_launch(223) > [SECURE_LOG] input argument 6 : _INTERNAL_SYSPOPUP_NAME_##
05-24 17:35:45.396+0900 D/AUL_PAD ( 4239): launchpad.c: __real_launch(223) > [SECURE_LOG] input argument 8 : __AUL_STARTTIME__##
05-24 17:35:45.396+0900 D/AUL_PAD ( 4239): launchpad.c: __real_launch(223) > [SECURE_LOG] input argument 10 : __AUL_CALLER_PID__##
05-24 17:35:45.396+0900 D/LAUNCH  ( 4239): launchpad.c: __real_launch(229) > [SECURE_LOG] [/usr/apps/org.tizen.crash-popup/bin/crash-popup:Platform:launchpad:done]
05-24 17:35:45.416+0900 D/LAUNCH  ( 4239): appcore-efl.c: appcore_efl_main(1571) > [crash-popup:Application:main:done]
05-24 17:35:45.416+0900 D/APP_CORE( 4239): appcore-efl.c: __before_loop(1017) > elm_config_preferred_engine_set is not called
05-24 17:35:45.416+0900 D/AUL     ( 4239): pkginfo.c: aul_app_get_pkgid_bypid(257) > [SECURE_LOG] appid for 4239 is org.tizen.crash-popup
05-24 17:35:45.416+0900 D/APP_CORE( 4239): appcore.c: appcore_init(532) > [SECURE_LOG] dir : /usr/apps/org.tizen.crash-popup/res/locale
05-24 17:35:45.416+0900 D/APP_CORE( 4239): appcore-i18n.c: update_region(71) > *****appcore setlocale=en_GB.UTF-8
05-24 17:35:45.416+0900 D/AUL     ( 4239): app_sock.c: __create_server_sock(141) > pg path - already exists
05-24 17:35:45.416+0900 D/LAUNCH  ( 4239): appcore-efl.c: __before_loop(1035) > [crash-popup:Platform:appcore_init:done]
05-24 17:35:45.436+0900 D/EFL-ASSIST( 4239): efl_assist_theme.c: ea_theme_changeable_ui_enabled_set(267) > changeable state is set to 1
05-24 17:35:45.436+0900 D/EFL-ASSIST( 4239): efl_assist_theme.c: _theme_color_monitor_add(239) > color config file (/opt/home/app/.elementary/config/wearable/color.cfg) monitor is added!!
05-24 17:35:45.436+0900 I/EFL-ASSIST( 4239): efl_assist_theme.c: _theme_changeable_ui_data_set(220) > changeable state [1] is set to ecore_evas [b81b0368]
05-24 17:35:45.436+0900 D/EFL-ASSIST( 4239): efl_assist_theme_color.c: ea_theme_style_set(951) > changeable state: 1,  winset style (0)
05-24 17:35:45.436+0900 I/EFL-ASSIST( 4239): efl_assist_theme_color.c: _color_config_get(215) > read color config file from (/opt/home/app/.elementary/config/wearable/color.cfg)
05-24 17:35:45.436+0900 I/EFL-ASSIST( 4239): efl_assist_theme_color.c: ea_theme_color_table_new(751) > color table (b81abee8) from (/usr/share/themes/ChangeableColorTable1.xml) is created
05-24 17:35:45.436+0900 I/EFL-ASSIST( 4239): efl_assist_theme_color.c: ea_theme_color_table_free(766) > color table (b81abee8) is freed
05-24 17:35:45.436+0900 I/EFL-ASSIST( 4239): efl_assist_theme_color.c: ea_theme_color_table_new(751) > color table (0) from (system-color.xml) is created
05-24 17:35:45.436+0900 I/EFL-ASSIST( 4239): efl_assist_theme_font.c: ea_theme_font_table_new(381) > font table (0) from (system-font.xml) is created
05-24 17:35:45.436+0900 D/APP_CORE( 4239): appcore-i18n.c: update_region(71) > *****appcore setlocale=en_GB.UTF-8
05-24 17:35:45.436+0900 D/LAUNCH  ( 4239): appcore-efl.c: __before_loop(1047) > [crash-popup:Application:create:done]
05-24 17:35:45.436+0900 D/APP_CORE( 4239): appcore-efl.c: __check_wm_rotation_support(752) > Disable window manager rotation
05-24 17:35:45.436+0900 D/APP_CORE( 4239): appcore.c: __aul_handler(423) > [APP 4239]     AUL event: AUL_START
05-24 17:35:45.436+0900 D/APP_CORE( 4239): appcore-efl.c: __do_app(470) > [APP 4239] Event: RESET State: CREATED
05-24 17:35:45.436+0900 D/APP_CORE( 4239): appcore-efl.c: __do_app(496) > [APP 4239] RESET
05-24 17:35:45.436+0900 D/LAUNCH  ( 4239): appcore-efl.c: __do_app(498) > [crash-popup:Application:reset:start]
05-24 17:35:45.436+0900 D/CRASH_POPUP( 4239): crash.c: app_reset(226) > bundle_get_val - process_name:basicui
05-24 17:35:45.436+0900 D/CRASH_POPUP( 4239): crash.c: app_reset(234) > bundle_get_val - exepath:/opt/usr/apps/org.example.basicui/bin/basicui
05-24 17:35:45.436+0900 D/PKGMGR_INFO( 4239): pkgmgrinfo_appinfo.c: pkgmgrinfo_appinfo_filter_count(3078) > [SECURE_LOG] where = package_app_info.app_exec='/opt/usr/apps/org.example.basicui/bin/basicui' and package_app_info.app_disable IN ('false','False')
05-24 17:35:45.436+0900 D/PKGMGR_INFO( 4239): pkgmgrinfo_appinfo.c: pkgmgrinfo_appinfo_filter_count(3084) > [SECURE_LOG] query = select DISTINCT package_app_info.app_id, package_app_info.app_component, package_app_info.app_installed_storage from package_app_info LEFT OUTER JOIN package_app_localized_info ON package_app_info.app_id=package_app_localized_info.app_id and package_app_localized_info.app_locale='en-gb' LEFT OUTER JOIN package_app_app_svc ON package_app_info.app_id=package_app_app_svc.app_id LEFT OUTER JOIN package_app_app_category ON package_app_info.app_id=package_app_app_category.app_id where package_app_info.app_exec='/opt/usr/apps/org.example.basicui/bin/basicui' and package_app_info.app_disable IN ('false','False')
05-24 17:35:45.436+0900 D/PKGMGR_INFO( 4239): pkgmgrinfo_appinfo.c: pkgmgrinfo_appinfo_filter_foreach_appinfo(3193) > [SECURE_LOG] where = package_app_info.app_exec='/opt/usr/apps/org.example.basicui/bin/basicui' and package_app_info.app_disable IN ('false','False')
05-24 17:35:45.436+0900 D/PKGMGR_INFO( 4239): pkgmgrinfo_appinfo.c: pkgmgrinfo_appinfo_filter_foreach_appinfo(3199) > [SECURE_LOG] query = select DISTINCT package_app_info.*, package_app_localized_info.app_locale, package_app_localized_info.app_label, package_app_localized_info.app_icon from package_app_info LEFT OUTER JOIN package_app_localized_info ON package_app_info.app_id=package_app_localized_info.app_id and package_app_localized_info.app_locale IN ('No Locale', 'en-gb') LEFT OUTER JOIN package_app_app_svc ON package_app_info.app_id=package_app_app_svc.app_id LEFT OUTER JOIN package_app_app_category ON package_app_info.app_id=package_app_app_category.app_id where package_app_info.app_exec='/opt/usr/apps/org.example.basicui/bin/basicui' and package_app_info.app_disable IN ('false','False')
05-24 17:35:45.436+0900 I/CRASH_POPUP( 4239): crash.c: load_crash_process_popup(117) > Popup content: basicui has closed unexpectedly.
05-24 17:35:45.446+0900 E/EFL     ( 4239): eina_module<4239> eina_module.c:339 eina_module_load() could not dlopen("/opt/home/app/.edje/modules/elm/linux-gnu-i686-1.0.0/module.so", RTLD_NOW): /opt/home/app/.edje/modules/elm/linux-gnu-i686-1.0.0/module.so: cannot open shared object file: No such file or directory
05-24 17:35:45.456+0900 D/W_HOME  ( 2278): main.c: _window_focus_out_cb(869) > focus out
05-24 17:35:45.456+0900 D/W_HOME  ( 2278): main.c: _pause_cb(600) > Paused
05-24 17:35:45.456+0900 D/W_HOME  ( 2278): page.c: page_focus(701) > focus set to 0xb82e5890
05-24 17:35:45.456+0900 W/W_HOME  ( 2278): main.c: _pause_cb(613) > clock/widget paused
05-24 17:35:45.456+0900 D/W_HOME  ( 2278): clock_view.c: clock_view_event_handler(843) > event:10002 received
05-24 17:35:45.456+0900 E/APPS    ( 2278): apps_main.c: _window_focus_out_cb(313) >  win[23068679], ev->win[23068675]
05-24 17:35:45.466+0900 D/DATA_PROVIDER_MASTER( 2315): xmonitor.c: xmonitor_pause(331) > [SECURE_LOG] 2278 is paused
05-24 17:35:45.466+0900 D/DATA_PROVIDER_MASTER( 2315): client_life.c: client_is_all_paused(479) > [SECURE_LOG] 1, 1
05-24 17:35:45.476+0900 W/W_HOME  ( 2278): dbus.c: _dbus_message_recv_cb(178) > LCD on
05-24 17:35:45.476+0900 W/W_HOME  ( 2278): main.c: _lcd_on_cb(951) > LCD: off->on
05-24 17:35:45.476+0900 D/STARTER ( 2271): dbus-util_w.c: _on_lcd_changed_receive(599) > [_on_lcd_changed_receive:599] LCD signal is received
05-24 17:35:45.476+0900 W/STARTER ( 2271): dbus-util_w.c: _on_lcd_changed_receive(628) > [_on_lcd_changed_receive:628] LCD on
05-24 17:35:45.476+0900 D/IDLE-CLOCK-DIGITAL( 2284): clock_view.c: on_changed_receive(1246) > org.tizen.system.deviced.display - LCDOn
05-24 17:35:45.476+0900 E/CAPI_APPFW_APPLICATION_PREFERENCE( 2284): preference.c: _preference_check_retry_err(459) > key(clock_font_color), check retry err: -21/(2/No such file or directory).
05-24 17:35:45.476+0900 E/CAPI_APPFW_APPLICATION_PREFERENCE( 2284): preference.c: _preference_get_key(1028) > _preference_get_key(clock_font_color) step(-17825744) failed(2 / No such file or directory)
05-24 17:35:45.476+0900 E/CAPI_APPFW_APPLICATION_PREFERENCE( 2284): preference.c: preference_get_int(1063) > preference_get_int(2284) : key(clock_font_color) error
05-24 17:35:45.476+0900 E/CAPI_APPFW_APPLICATION_PREFERENCE( 2284): preference.c: _preference_check_retry_err(459) > key(showdate), check retry err: -21/(2/No such file or directory).
05-24 17:35:45.476+0900 E/CAPI_APPFW_APPLICATION_PREFERENCE( 2284): preference.c: _preference_get_key(1028) > _preference_get_key(showdate) step(-17825744) failed(2 / No such file or directory)
05-24 17:35:45.476+0900 E/CAPI_APPFW_APPLICATION_PREFERENCE( 2284): preference.c: preference_get_int(1063) > preference_get_int(2284) : key(showdate) error
05-24 17:35:45.476+0900 D/IDLE-CLOCK-DIGITAL( 2284): clock_view.c: clock_view_set_info_time(849) > show_date:1
05-24 17:35:45.476+0900 D/IDLE-CLOCK-DIGITAL( 2284): clock_view.c: _get_formatted_date_from_utc_time(678) > [SECURE_LOG] date:(10)[Tue 24 May][1464078945]
05-24 17:35:45.476+0900 D/IDLE-CLOCK-DIGITAL( 2284): clock_view.c: clock_view_set_info_time(857) > 
05-24 17:35:45.476+0900 D/IDLE-CLOCK-DIGITAL( 2284): clock_view.c: _get_formatted_ampm_from_utc_time(715) > [SECURE_LOG] ampm:(2)[PM][1464078945]
05-24 17:35:45.476+0900 D/IDLE-CLOCK-DIGITAL( 2284): clock_view.c: _get_formatted_time_from_utc_time(756) > [SECURE_LOG] time:(4)[5:35][1464078945]
05-24 17:35:45.476+0900 D/IDLE-CLOCK-DIGITAL( 2284): clock_view.c: clock_view_set_info_time(871) > utc_time=5:35, utc_ampm=[2]PM
05-24 17:35:45.476+0900 D/IDLE-CLOCK-DIGITAL( 2284): clock_view.c: clock_view_set_info_time(891) > time_str=<color=#FFFFFFFF>5:35<font_size=24><font=Tizen:style=Bold> PM</font></font_size></color>
05-24 17:35:45.476+0900 D/LAUNCH  ( 4239): appcore-efl.c: __do_app(501) > [crash-popup:Application:reset:done]
05-24 17:35:45.476+0900 I/APP_CORE( 4239): appcore-efl.c: __do_app(507) > Legacy lifecycle: 0
05-24 17:35:45.486+0900 I/APP_CORE( 4239): appcore-efl.c: __do_app(509) > [APP 4239] Initial Launching, call the resume_cb
05-24 17:35:45.486+0900 D/APP_CORE( 4239): appcore.c: __aul_handler(426) > [SECURE_LOG] caller_appid : (null)
05-24 17:35:45.486+0900 D/APP_CORE( 4239): appcore-efl.c: __show_cb(826) > [EVENT_TEST][EVENT] GET SHOW EVENT!!!. WIN:1c00006
05-24 17:35:45.486+0900 D/APP_CORE( 4239): appcore-efl.c: __add_win(672) > [EVENT_TEST][EVENT] __add_win WIN:1c00006
05-24 17:35:45.486+0900 D/W_HOME  ( 2278): clock_event.c: _display_state_cb(194) > LCD: off->on
05-24 17:35:45.486+0900 D/W_HOME  ( 2278): clock_view.c: clock_view_event_handler(843) > event:40000 received
05-24 17:35:45.486+0900 D/W_HOME  ( 2278): clock_view_cue.c: clock_view_cue_display_set(73) > Cue for Apps, is_display:1, is_need_vi:0
05-24 17:35:45.486+0900 D/DATA_PROVIDER_MASTER( 2315): client_life.c: client_is_all_paused(479) > [SECURE_LOG] 1, 1
05-24 17:35:45.486+0900 D/IDLE-CLOCK-DIGITAL( 2284): clock_view.c: _device_state_changed_cb(1084) > DISPLAY STATE [0]
05-24 17:35:45.496+0900 D/AUL_PAD ( 2209): sigchild.h: __signal_block_sigchld(230) > SIGCHLD blocked
05-24 17:35:45.496+0900 D/AUL_PAD ( 2209): sigchild.h: __send_app_launch_signal(112) > send launch signal done
05-24 17:35:45.496+0900 D/AUL_PAD ( 2209): sigchild.h: __signal_unblock_sigchld(242) > SIGCHLD unblocked
05-24 17:35:45.496+0900 D/AUL     ( 2192): simple_util.c: __trm_app_info_send_socket(261) > __trm_app_info_send_socket
05-24 17:35:45.496+0900 E/AUL     ( 2192): simple_util.c: __trm_app_info_send_socket(264) > access
05-24 17:35:45.496+0900 E/AUL_AMD ( 2192): amd_status.c: __lcd_status_cb(680) > Failed to get VCONFKEY_WMS_WAKEUP_BY_GESTURE_SETTING
05-24 17:35:45.496+0900 D/RESOURCED( 2371): proc-noti.c: recv_str(87) > [recv_str,87] str is null
05-24 17:35:45.496+0900 D/RESOURCED( 2371): proc-noti.c: process_message(169) > [process_message,169] process message caller pid 2192
05-24 17:35:45.496+0900 D/RESOURCED( 2371): proc-main.c: resourced_proc_action(669) > [SECURE_LOG] [resourced_proc_action,669] appid org.tizen.crash-popup, pid 4239, type 4 
05-24 17:35:45.496+0900 D/RESOURCED( 2371): proc-main.c: resourced_proc_status_change(570) > [SECURE_LOG] [resourced_proc_status_change,570] launch request org.tizen.crash-popup, 4239
05-24 17:35:45.496+0900 D/RESOURCED( 2371): proc-main.c: resourced_proc_status_change(572) > [SECURE_LOG] [resourced_proc_status_change,572] launch request org.tizen.crash-popup with pkgname
05-24 17:35:45.496+0900 E/RESOURCED( 2371): proc-main.c: resourced_proc_status_change(577) > [resourced_proc_status_change,577] available memory = 384
05-24 17:35:45.496+0900 D/RESOURCED( 2371): proc-noti.c: safe_write_int(178) > [safe_write_int,178] Response is not needed
05-24 17:35:45.496+0900 D/AUL     ( 4238): launch.c: app_request_to_launchpad(295) > launch request result : 4239
05-24 17:35:45.556+0900 D/AUL_AMD ( 2192): amd_launch.c: __e17_status_handler(1920) > pid(4239) status(3)
05-24 17:35:45.556+0900 D/RESOURCED( 2371): proc-monitor.c: proc_dbus_proc_signal_handler(198) > [proc_dbus_proc_signal_handler,198] call proc_dbus_proc_signal_handler : pid = 4239, type = 0
05-24 17:35:45.556+0900 D/RESOURCED( 2371): proc-main.c: resourced_proc_status_change(555) > [SECURE_LOG] [resourced_proc_status_change,555] set foreground : 4239
05-24 17:35:45.556+0900 I/RESOURCED( 2371): lowmem-handler.c: lowmem_move_memcgroup(1190) > [lowmem_move_memcgroup,1190] buf : /sys/fs/cgroup/memory/foreground/cgroup.procs, pid : 4239, oom : 200
05-24 17:35:45.556+0900 E/RESOURCED( 2371): lowmem-handler.c: lowmem_move_memcgroup(1193) > [lowmem_move_memcgroup,1193] /sys/fs/cgroup/memory/foreground/cgroup.procs open failed
05-24 17:35:45.556+0900 E/RESOURCED( 2371): proc-main.c: proc_update_process_state(233) > [proc_update_process_state,233] Current pid (4239) didn't have any process list
05-24 17:35:45.556+0900 D/RESOURCED( 2371): cpu.c: cpu_foreground_state(92) > [cpu_foreground_state,92] cpu_foreground_state : pid = 4239, appname = (null)
05-24 17:35:45.556+0900 D/RESOURCED( 2371): cgroup.c: cgroup_write_node(91) > [SECURE_LOG] [cgroup_write_node,91] cgroup_buf /sys/fs/cgroup/cpu/cgroup.procs, value 4239
05-24 17:35:45.616+0900 D/APP_CORE( 4239): appcore-efl.c: __update_win(718) > [EVENT_TEST][EVENT] __update_win WIN:1c00006 fully_obscured 0
05-24 17:35:45.616+0900 D/APP_CORE( 4239): appcore-efl.c: __visibility_cb(884) > bvisibility 1, b_active -1
05-24 17:35:45.616+0900 D/APP_CORE( 4239): appcore-efl.c: __visibility_cb(887) >  Go to Resume state
05-24 17:35:45.616+0900 D/APP_CORE( 4239): appcore-efl.c: __do_app(470) > [APP 4239] Event: RESUME State: RUNNING
05-24 17:35:45.616+0900 D/LAUNCH  ( 4239): appcore-efl.c: __do_app(557) > [crash-popup:Application:resume:start]
05-24 17:35:45.616+0900 D/LAUNCH  ( 4239): appcore-efl.c: __do_app(567) > [crash-popup:Application:resume:done]
05-24 17:35:45.616+0900 D/LAUNCH  ( 4239): appcore-efl.c: __do_app(569) > [crash-popup:Application:Launching:done]
05-24 17:35:45.616+0900 D/APP_CORE( 4239): appcore-efl.c: __trm_app_info_send_socket(230) > __trm_app_info_send_socket
05-24 17:35:45.616+0900 E/APP_CORE( 4239): appcore-efl.c: __trm_app_info_send_socket(233) > access
05-24 17:35:45.716+0900 D/APP_CORE( 4239): appcore.c: __prt_ltime(183) > [APP 4239] first idle after reset: 323 msec
05-24 17:35:45.716+0900 D/W_HOME  ( 2278): main.c: _window_focus_in_cb(848) > focus in
05-24 17:35:45.716+0900 D/W_HOME  ( 2278): main.c: _resume_cb(564) > Resumed
05-24 17:35:45.716+0900 D/APPS    ( 2278): apps_main.c: apps_main_is_visible(757) >  bShow:[0]
05-24 17:35:45.716+0900 D/W_HOME  ( 2278): scroller.c: _resume_result_cb(623) > Activate the rotary events for Home
05-24 17:35:45.716+0900 E/efl-extension( 2278): efl_extension_rotary.c: eext_rotary_object_event_activated_set(301) > eext_rotary_object_event_activated_set : 0xb82a64b8, elm_scroller, _activated_obj : 0xb82a64b8, activated : 1
05-24 17:35:45.716+0900 W/W_HOME  ( 2278): main.c: _resume_cb(589) > clock/widget resumed
05-24 17:35:45.716+0900 D/W_HOME  ( 2278): clock_view.c: clock_view_event_handler(843) > event:10004 received
05-24 17:35:45.716+0900 D/W_HOME  ( 2278): clock_view_cue.c: clock_view_cue_display_set(73) > Cue for Apps, is_display:1, is_need_vi:0
05-24 17:35:45.716+0900 D/W_HOME  ( 2278): clock_inf_minictrl.c: _resume_cb(103) > minictrl 0xb83228c0 is resumed
05-24 17:35:45.716+0900 E/APPS    ( 2278): apps_main.c: _window_focus_in_cb(293) >  win[23068679], ev->win[23068675]
05-24 17:35:45.716+0900 D/IDLE-CLOCK-DIGITAL( 2284): clock_view.c: _ecore_evas_msg_parent_handle(1287) > Receive msg from clien msg_domain=0 msg_id=0 size=10
05-24 17:35:45.716+0900 D/IDLE-CLOCK-DIGITAL( 2284): clock_view.c: _ecore_evas_msg_parent_handle(1288) >  ########## data : mc_resume
05-24 17:35:45.716+0900 D/IDLE-CLOCK-DIGITAL( 2284): clock_view.c: _ecore_evas_msg_parent_handle(1291) > ##### mc_resume
05-24 17:35:45.726+0900 I/AUL_PAD ( 2209): sigchild.h: __launchpad_sig_child(142) > dead_pid = 4239 pgid = 4239
05-24 17:35:45.726+0900 I/AUL_PAD ( 2209): sigchild.h: __sigchild_action(123) > dead_pid(4239)
05-24 17:35:45.726+0900 D/AUL_PAD ( 2209): sigchild.h: __send_app_dead_signal(81) > send dead signal done
05-24 17:35:45.726+0900 I/AUL_PAD ( 2209): sigchild.h: __sigchild_action(129) > __send_app_dead_signal(0)
05-24 17:35:45.726+0900 I/AUL_PAD ( 2209): sigchild.h: __launchpad_sig_child(150) > after __sigchild_action
05-24 17:35:45.726+0900 I/AUL_AMD ( 2192): amd_main.c: __app_dead_handler(262) > __app_dead_handler, pid: 4239
05-24 17:35:45.726+0900 D/AUL_AMD ( 2192): amd_key.c: _unregister_key_event(161) > ===key stack===
05-24 17:35:45.726+0900 D/AUL     ( 2192): simple_util.c: __trm_app_info_send_socket(261) > __trm_app_info_send_socket
05-24 17:35:45.726+0900 E/AUL     ( 2192): simple_util.c: __trm_app_info_send_socket(264) > access
05-24 17:35:45.726+0900 D/STARTER ( 2271): starter_w.c: _w_app_dead_cb(183) > [STARTER/home/abuild/rpmbuild/BUILD/starter-0.5.52/src/starter_w.c:183:D] app dead cb call! (pid : 4239)
05-24 17:35:45.726+0900 D/W_HOME  ( 2278): main.c: _dead_cb(542) > PID(4239) is dead
05-24 17:35:45.726+0900 E/W_HOME  ( 2278): clock_shortcut.c: _shortcut_icon_owner_get(190) > (icon == NULL) -> _shortcut_icon_owner_get() return
05-24 17:35:45.736+0900 D/DATA_PROVIDER_MASTER( 2315): xmonitor.c: xmonitor_resume(339) > [SECURE_LOG] 2278 is resumed
05-24 17:35:45.736+0900 D/DATA_PROVIDER_MASTER( 2315): client_life.c: client_is_all_paused(479) > [SECURE_LOG] 1, 0
05-24 17:35:45.916+0900 D/W_HOME  ( 2278): key.c: _key_press_cb(162) > Key pressed 1
05-24 17:35:46.096+0900 D/W_HOME  ( 2278): key.c: _key_release_cb(135) > Key(XF86Stop) released 1
05-24 17:35:46.096+0900 W/W_HOME  ( 2278): clock_event.c: _back_key_cb(171) > 
05-24 17:35:46.096+0900 D/W_HOME  ( 2278): clock_view.c: clock_view_event_handler(843) > event:20000 received
05-24 17:35:46.096+0900 D/AUL     ( 2278): launch.c: app_request_to_launchpad(281) > [SECURE_LOG] launch request : org.tizen.windicator
05-24 17:35:46.096+0900 D/AUL     ( 2278): app_sock.c: __app_send_raw(270) > pid(-2) : cmd(0)
05-24 17:35:46.096+0900 D/AUL_AMD ( 2192): amd_request.c: __request_handler(502) > __request_handler: 0
05-24 17:35:46.096+0900 E/AUL_AMD ( 2192): amd_request.c: __request_handler(522) > no appinfo
05-24 17:35:46.106+0900 D/AUL     ( 2278): launch.c: app_request_to_launchpad(295) > launch request result : -1
05-24 17:35:46.106+0900 D/W_HOME  ( 2278): clock_view.c: clock_view_indicator_show(106) > aul_launch_app: org.tizen.windicator(-1)
05-24 17:35:46.496+0900 D/AUL_AMD ( 2192): amd_request.c: __add_history_handler(254) > [SECURE_LOG] add rua history org.tizen.crash-popup /usr/apps/org.tizen.crash-popup/bin/crash-popup
05-24 17:35:46.496+0900 D/RUA     ( 2192): rua.c: rua_add_history(179) > rua_add_history start
05-24 17:35:46.506+0900 D/RUA     ( 2192): rua.c: rua_add_history(247) > rua_add_history ok
05-24 17:35:46.736+0900 I/GESTURE ( 2026): gesture.c: GestureRecognize(2377) > [BackKey][F] Press touch outside 40 pixel area from upper vezel. 
05-24 17:35:46.786+0900 D/EFL     ( 2278): ecore_x<2278> ecore_x_events.c:531 _ecore_x_event_handle_button_press() ButtonEvent:press time=1521794 button=1
05-24 17:35:46.786+0900 D/W_HOME  ( 2278): dbus_util.c: _dbus_method_async_call(141) > dbus_connection_send, ret=1
05-24 17:35:46.786+0900 D/W_HOME  ( 2278): dbus_util.c: home_dbus_scroll_booster_signal_send(296) > Sending scroll booster for 200 sec result:0
05-24 17:35:46.786+0900 D/W_HOME  ( 2278): layout.c: _gesture_down_cb(611) > Mouse is down on the gesture layer:203
05-24 17:35:46.786+0900 D/W_HOME  ( 2278): layout.c: _down_cb(250) > Mouse is down on the layout
05-24 17:35:46.786+0900 D/W_HOME  ( 2278): page.c: _down_cb(84) > Down (0xb832cea8)(193, 203)
05-24 17:35:46.906+0900 D/EFL     ( 2278): ecore_x<2278> ecore_x_events.c:683 _ecore_x_event_handle_button_release() ButtonEvent:release time=1521910 button=1
05-24 17:35:46.916+0900 D/W_HOME  ( 2278): layout.c: _up_cb(324) > Mouse is up on the layout
05-24 17:35:46.916+0900 D/W_HOME  ( 2278): page.c: _up_cb(115) > Up (0xb832cea8)(193, 203)
05-24 17:35:49.246+0900 I/GESTURE ( 2026): gesture.c: GestureRecognize(2377) > [BackKey][F] Press touch outside 40 pixel area from upper vezel. 
05-24 17:35:49.306+0900 D/EFL     ( 2278): ecore_x<2278> ecore_x_events.c:531 _ecore_x_event_handle_button_press() ButtonEvent:press time=1524259 button=1
05-24 17:35:49.306+0900 D/W_HOME  ( 2278): dbus_util.c: _dbus_method_async_call(141) > dbus_connection_send, ret=1
05-24 17:35:49.306+0900 D/W_HOME  ( 2278): dbus_util.c: home_dbus_scroll_booster_signal_send(296) > Sending scroll booster for 200 sec result:0
05-24 17:35:49.306+0900 D/W_HOME  ( 2278): layout.c: _gesture_down_cb(611) > Mouse is down on the gesture layer:152
05-24 17:35:49.306+0900 D/W_HOME  ( 2278): layout.c: _down_cb(250) > Mouse is down on the layout
05-24 17:35:49.306+0900 D/W_HOME  ( 2278): page.c: _down_cb(84) > Down (0xb832cea8)(146, 152)
05-24 17:35:49.366+0900 D/EFL     ( 2278): ecore_x<2278> ecore_x_events.c:683 _ecore_x_event_handle_button_release() ButtonEvent:release time=1524371 button=1
05-24 17:35:49.366+0900 D/W_HOME  ( 2278): layout.c: _up_cb(324) > Mouse is up on the layout
05-24 17:35:49.366+0900 D/W_HOME  ( 2278): page.c: _up_cb(115) > Up (0xb832cea8)(146, 152)
05-24 17:35:54.906+0900 D/PKGMGR_SERVER( 4301): pkgmgr-server.c: main(1436) > server start
05-24 17:35:54.906+0900 D/PKGMGR_SERVER( 4301): pkgmgr-server.c: main(1505) > Main loop is created.
05-24 17:35:54.906+0900 D/PKGMGR  ( 4301): comm_pkg_mgr_server.c: pkg_mgr_object_class_init(144) > called
05-24 17:35:54.906+0900 D/PKGMGR  ( 4301): comm_pkg_mgr_server.c: pkg_mgr_object_class_init(155) > done
05-24 17:35:54.906+0900 D/PKGMGR  ( 4301): comm_pkg_mgr_server.c: pkg_mgr_object_init(93) > called
05-24 17:35:54.916+0900 D/PKGMGR  ( 4301): comm_pkg_mgr_server.c: pkg_mgr_object_init(130) > RequestName returns: 1
05-24 17:35:54.916+0900 D/PKGMGR  ( 4301): comm_pkg_mgr_server.c: pkg_mgr_object_init(135) > Ready to serve requests
05-24 17:35:54.916+0900 D/PKGMGR  ( 4301): comm_pkg_mgr_server.c: pkg_mgr_object_init(139) > done
05-24 17:35:54.916+0900 D/PKGMGR_SERVER( 4301): pkgmgr-server.c: main(1510) > pkg_mgr object is created, and request callback is registered.
05-24 17:35:54.926+0900 D/PKGMGR  ( 4301): comm_pkg_mgr_server.c: pkgmgr_request(194) > Called
05-24 17:35:54.926+0900 D/PKGMGR  ( 4301): comm_pkg_mgr_server.c: pkgmgr_request(203) > [SECURE_LOG] Call request callback(obj, org.example.basicui_1913107939, 11, rpm, org.example.basicui, , *ret)
05-24 17:35:54.926+0900 D/PKGMGR_SERVER( 4301): pkgmgr-server.c: req_cb(431) > [SECURE_LOG] >> in callback >> Got request: [org.example.basicui_1913107939] [11] [rpm] [org.example.basicui] [] []
05-24 17:35:54.926+0900 D/PKGMGR_SERVER( 4301): pkgmgr-server.c: __register_signal_handler(382) > signal: SIGCHLD succeed
05-24 17:35:54.926+0900 D/PKGMGR_SERVER( 4301): pkgmgr-server.c: __register_signal_handler(384) > g_timeout_add_seconds() Added to Main Loop
05-24 17:35:54.926+0900 D/PKGMGR_SERVER( 4301): pkgmgr-server.c: req_cb(450) > req_type=(11)  backend_flag=(0)
05-24 17:35:54.926+0900 D/PKGMGR_SERVER( 4301): pkgmgr-server.c: queue_job(1168) > saved queue status. Now try fork()
05-24 17:35:54.926+0900 D/PKGMGR_SERVER( 4301): pkgmgr-server.c: queue_job(1175) > child forked [4302] for request type [11]
05-24 17:35:54.926+0900 D/PKGMGR_SERVER( 4301): pkgmgr-server.c: queue_job(1347) > parent exit
05-24 17:35:54.926+0900 D/PKGMGR_SERVER( 4302): pkgmgr-server.c: queue_job(1175) > child forked [0] for request type [11]
05-24 17:35:54.926+0900 D/PKGMGR_SERVER( 4302): pkgmgr-server.c: __make_pid_info_file(825) > File path = /tmp/org.example.basicui
05-24 17:35:54.946+0900 D/PKGMGR_SERVER( 4301): pkgmgr-server.c: sighandler(326) > child exit [4302]
05-24 17:35:54.946+0900 D/PKGMGR_SERVER( 4301): pkgmgr-server.c: sighandler(341) > child NORMAL exit [4302]
05-24 17:35:56.996+0900 D/PKGMGR_SERVER( 4301): pkgmgr-server.c: exit_server(724) > exit_server Start
05-24 17:35:56.996+0900 D/PKGMGR_SERVER( 4301): pkgmgr-server.c: main(1516) > Quit main loop.
05-24 17:35:56.996+0900 D/PKGMGR_SERVER( 4301): pkgmgr-server.c: main(1524) > package manager server terminated.
05-24 17:35:58.056+0900 D/AUL_AMD ( 2192): amd_request.c: __request_handler(502) > __request_handler: 0
05-24 17:35:58.056+0900 D/AUL_AMD ( 2192): amd_request.c: __request_handler(547) > launch a single-instance appid: org.example.basicui
05-24 17:35:58.056+0900 D/AUL     ( 2192): pkginfo.c: aul_app_get_appid_bypid(205) > second change pgid = 4351, pid = 4353
05-24 17:35:58.056+0900 D/AUL_AMD ( 2192): amd_launch.c: _start_app(1486) > [SECURE_LOG] caller : (null)
05-24 17:35:58.056+0900 D/AUL_AMD ( 2192): amd_launch.c: _start_app(1792) > process_pool: false
05-24 17:35:58.056+0900 D/AUL_AMD ( 2192): amd_launch.c: _start_app(1795) > h/w acceleration: SYS
05-24 17:35:58.056+0900 D/AUL_AMD ( 2192): amd_launch.c: _start_app(1797) > [SECURE_LOG] appid: org.example.basicui
05-24 17:35:58.056+0900 D/AUL_AMD ( 2192): amd_launch.c: __set_appinfo_for_launchpad(1959) > Add hwacc, taskmanage, app_path and pkg_type into bundle for sending those to launchpad.
05-24 17:35:58.056+0900 D/AUL     ( 2192): app_sock.c: __app_send_raw(270) > pid(-1) : cmd(0)
05-24 17:35:58.056+0900 D/AUL_PAD ( 2209): launchpad.c: __launchpad_main_loop(641) > [SECURE_LOG] pkg name : org.example.basicui
05-24 17:35:58.056+0900 D/AUL_PAD ( 2209): launchpad.c: __modify_bundle(380) > parsing app_path: No arguments
05-24 17:35:58.056+0900 D/AUL_PAD ( 2209): launchpad.c: __launchpad_main_loop(699) > [SECURE_LOG] ==> real launch pid : 4354 /opt/usr/apps/org.example.basicui/bin/basicui
05-24 17:35:58.056+0900 D/AUL_PAD ( 2209): launchpad.c: __send_result_to_caller(555) > -- now wait to change cmdline --
05-24 17:35:58.056+0900 D/AUL_PAD ( 4354): launchpad.c: __launchpad_main_loop(668) > lock up test log(no error) : fork done
05-24 17:35:58.056+0900 D/AUL_PAD ( 4354): launchpad.c: __launchpad_main_loop(679) > lock up test log(no error) : prepare exec - first done
05-24 17:35:58.056+0900 D/AUL_PAD ( 4354): launchpad.c: __prepare_exec(136) > [SECURE_LOG] pkg_name : org.example.basicui / pkg_type : rpm / app_path : /opt/usr/apps/org.example.basicui/bin/basicui 
05-24 17:35:58.066+0900 D/AUL_PAD ( 4354): launchpad.c: __launchpad_main_loop(693) > lock up test log(no error) : prepare exec - second done
05-24 17:35:58.066+0900 D/AUL_PAD ( 4354): launchpad.c: __real_launch(223) > [SECURE_LOG] input argument 0 : /opt/usr/apps/org.example.basicui/bin/basicui##
05-24 17:35:58.066+0900 D/AUL_PAD ( 4354): launchpad.c: __real_launch(223) > [SECURE_LOG] input argument 2 : __AUL_STARTTIME__##
05-24 17:35:58.066+0900 D/AUL_PAD ( 4354): launchpad.c: __real_launch(223) > [SECURE_LOG] input argument 4 : __AUL_CALLER_PID__##
05-24 17:35:58.066+0900 D/LAUNCH  ( 4354): launchpad.c: __real_launch(229) > [SECURE_LOG] [/opt/usr/apps/org.example.basicui/bin/basicui:Platform:launchpad:done]
05-24 17:35:58.066+0900 I/efl-extension( 4354): efl_extension.c: eext_mod_init(39) > Init
05-24 17:35:58.066+0900 I/CAPI_APPFW_APPLICATION( 4354): app_main.c: ui_app_main(701) > app_efl_main
05-24 17:35:58.066+0900 D/LAUNCH  ( 4354): appcore-efl.c: appcore_efl_main(1571) > [basicui:Application:main:done]
05-24 17:35:58.076+0900 D/APP_CORE( 4354): appcore-efl.c: __before_loop(1017) > elm_config_preferred_engine_set is not called
05-24 17:35:58.086+0900 D/AUL     ( 4354): pkginfo.c: aul_app_get_pkgid_bypid(257) > [SECURE_LOG] appid for 4354 is org.example.basicui
05-24 17:35:58.086+0900 D/APP_CORE( 4354): appcore.c: appcore_init(532) > [SECURE_LOG] dir : /usr/apps/org.example.basicui/res/locale
05-24 17:35:58.086+0900 D/APP_CORE( 4354): appcore-i18n.c: update_region(71) > *****appcore setlocale=en_GB.UTF-8
05-24 17:35:58.086+0900 D/AUL     ( 4354): app_sock.c: __create_server_sock(141) > pg path - already exists
05-24 17:35:58.086+0900 D/LAUNCH  ( 4354): appcore-efl.c: __before_loop(1035) > [basicui:Platform:appcore_init:done]
05-24 17:35:58.086+0900 I/CAPI_APPFW_APPLICATION( 4354): app_main.c: _ui_app_appcore_create(559) > app_appcore_create
05-24 17:35:58.106+0900 E/EFL     ( 4354): eina_module<4354> eina_module.c:339 eina_module_load() could not dlopen("/opt/home/app/.edje/modules/elm/linux-gnu-i686-1.0.0/module.so", RTLD_NOW): /opt/home/app/.edje/modules/elm/linux-gnu-i686-1.0.0/module.so: cannot open shared object file: No such file or directory
05-24 17:35:58.106+0900 E/EFL     ( 4354): ecore_evas<4354> ecore_evas_extn.c:2169 ecore_evas_extn_plug_connect() Extn plug failed to connect:ipctype=0, svcname=elm_indicator_portrait, svcnum=0, svcsys=0
05-24 17:35:58.116+0900 D/LAUNCH  ( 4354): appcore-efl.c: __before_loop(1047) > [basicui:Application:create:done]
05-24 17:35:58.116+0900 D/APP_CORE( 4354): appcore-efl.c: __check_wm_rotation_support(752) > Disable window manager rotation
05-24 17:35:58.116+0900 D/APP_CORE( 4354): appcore.c: __aul_handler(423) > [APP 4354]     AUL event: AUL_START
05-24 17:35:58.116+0900 D/APP_CORE( 4354): appcore-efl.c: __do_app(470) > [APP 4354] Event: RESET State: CREATED
05-24 17:35:58.116+0900 D/APP_CORE( 4354): appcore-efl.c: __do_app(496) > [APP 4354] RESET
05-24 17:35:58.116+0900 D/LAUNCH  ( 4354): appcore-efl.c: __do_app(498) > [basicui:Application:reset:start]
05-24 17:35:58.116+0900 I/CAPI_APPFW_APPLICATION( 4354): app_main.c: _ui_app_appcore_reset(642) > app_appcore_reset
05-24 17:35:58.116+0900 D/APP_SVC ( 4354): appsvc.c: __set_bundle(161) > __set_bundle
05-24 17:35:58.116+0900 D/LAUNCH  ( 4354): appcore-efl.c: __do_app(501) > [basicui:Application:reset:done]
05-24 17:35:58.116+0900 I/APP_CORE( 4354): appcore-efl.c: __do_app(507) > Legacy lifecycle: 0
05-24 17:35:58.126+0900 D/W_HOME  ( 2278): main.c: _window_focus_out_cb(869) > focus out
05-24 17:35:58.126+0900 D/W_HOME  ( 2278): main.c: _pause_cb(600) > Paused
05-24 17:35:58.126+0900 D/W_HOME  ( 2278): page.c: page_focus(701) > focus set to 0xb82e5890
05-24 17:35:58.126+0900 W/W_HOME  ( 2278): main.c: _pause_cb(613) > clock/widget paused
05-24 17:35:58.126+0900 D/W_HOME  ( 2278): clock_view.c: clock_view_event_handler(843) > event:10002 received
05-24 17:35:58.126+0900 D/W_HOME  ( 2278): clock_inf_minictrl.c: _pause_cb(85) > minictrl 0xb83228c0 is paused
05-24 17:35:58.126+0900 E/APPS    ( 2278): apps_main.c: _window_focus_out_cb(313) >  win[23068679], ev->win[23068675]
05-24 17:35:58.126+0900 D/IDLE-CLOCK-DIGITAL( 2284): clock_view.c: _ecore_evas_msg_parent_handle(1287) > Receive msg from clien msg_domain=0 msg_id=0 size=9
05-24 17:35:58.126+0900 D/IDLE-CLOCK-DIGITAL( 2284): clock_view.c: _ecore_evas_msg_parent_handle(1288) >  ########## data : mc_pause
05-24 17:35:58.126+0900 D/IDLE-CLOCK-DIGITAL( 2284): clock_view.c: _ecore_evas_msg_parent_handle(1293) > ##### mc_pause
05-24 17:35:58.126+0900 I/APP_CORE( 4354): appcore-efl.c: __do_app(509) > [APP 4354] Initial Launching, call the resume_cb
05-24 17:35:58.126+0900 I/CAPI_APPFW_APPLICATION( 4354): app_main.c: _ui_app_appcore_resume(624) > app_appcore_resume
05-24 17:35:58.126+0900 D/APP_CORE( 4354): appcore.c: __aul_handler(426) > [SECURE_LOG] caller_appid : (null)
05-24 17:35:58.126+0900 D/APP_CORE( 4354): appcore-efl.c: __show_cb(826) > [EVENT_TEST][EVENT] GET SHOW EVENT!!!. WIN:1c00002
05-24 17:35:58.126+0900 D/APP_CORE( 4354): appcore-efl.c: __add_win(672) > [EVENT_TEST][EVENT] __add_win WIN:1c00002
05-24 17:35:58.136+0900 D/DATA_PROVIDER_MASTER( 2315): xmonitor.c: xmonitor_pause(331) > [SECURE_LOG] 2278 is paused
05-24 17:35:58.136+0900 D/DATA_PROVIDER_MASTER( 2315): client_life.c: client_is_all_paused(479) > [SECURE_LOG] 1, 1
05-24 17:35:58.166+0900 D/AUL_PAD ( 2209): sigchild.h: __signal_block_sigchld(230) > SIGCHLD blocked
05-24 17:35:58.166+0900 D/AUL_PAD ( 2209): sigchild.h: __send_app_launch_signal(112) > send launch signal done
05-24 17:35:58.166+0900 D/AUL_PAD ( 2209): sigchild.h: __signal_unblock_sigchld(242) > SIGCHLD unblocked
05-24 17:35:58.166+0900 D/AUL     ( 2192): simple_util.c: __trm_app_info_send_socket(261) > __trm_app_info_send_socket
05-24 17:35:58.166+0900 E/AUL     ( 2192): simple_util.c: __trm_app_info_send_socket(264) > access
05-24 17:35:58.166+0900 D/RESOURCED( 2371): proc-noti.c: recv_str(87) > [recv_str,87] str is null
05-24 17:35:58.166+0900 D/RESOURCED( 2371): proc-noti.c: process_message(169) > [process_message,169] process message caller pid 2192
05-24 17:35:58.166+0900 D/RESOURCED( 2371): proc-main.c: resourced_proc_action(669) > [SECURE_LOG] [resourced_proc_action,669] appid org.example.basicui, pid 4354, type 4 
05-24 17:35:58.166+0900 D/RESOURCED( 2371): proc-main.c: resourced_proc_status_change(570) > [SECURE_LOG] [resourced_proc_status_change,570] launch request org.example.basicui, 4354
05-24 17:35:58.166+0900 D/RESOURCED( 2371): proc-main.c: resourced_proc_status_change(572) > [SECURE_LOG] [resourced_proc_status_change,572] launch request org.example.basicui with pkgname
05-24 17:35:58.166+0900 E/RESOURCED( 2371): proc-main.c: resourced_proc_status_change(577) > [resourced_proc_status_change,577] available memory = 384
05-24 17:35:58.166+0900 D/RESOURCED( 2371): proc-noti.c: safe_write_int(178) > [safe_write_int,178] Response is not needed
05-24 17:35:58.166+0900 D/APP_CORE( 4354): appcore.c: __prt_ltime(183) > [APP 4354] first idle after reset: 109 msec
05-24 17:35:58.186+0900 W/W_HOME  ( 2278): main.c: _window_visibility_cb(796) > Window [0x1600003] is now visible(1)
05-24 17:35:58.186+0900 D/APP_CORE( 2278): appcore-efl.c: __update_win(718) > [EVENT_TEST][EVENT] __update_win WIN:1600003 fully_obscured 1
05-24 17:35:58.186+0900 D/APP_CORE( 2278): appcore-efl.c: __visibility_cb(884) > bvisibility 0, b_active 1
05-24 17:35:58.186+0900 D/APP_CORE( 2278): appcore-efl.c: __visibility_cb(898) >  Go to Pasue state 
05-24 17:35:58.186+0900 D/APP_CORE( 2278): appcore-efl.c: __do_app(470) > [APP 2278] Event: PAUSE State: PAUSED
05-24 17:35:58.186+0900 D/APP_CORE( 2278): appcore-efl.c: __trm_app_info_send_socket(230) > __trm_app_info_send_socket
05-24 17:35:58.186+0900 E/APP_CORE( 2278): appcore-efl.c: __trm_app_info_send_socket(233) > access
05-24 17:35:58.186+0900 D/RESOURCED( 2371): proc-monitor.c: proc_dbus_proc_signal_handler(198) > [proc_dbus_proc_signal_handler,198] call proc_dbus_proc_signal_handler : pid = 2278, type = 2
05-24 17:35:58.186+0900 D/AUL_AMD ( 2192): amd_launch.c: __e17_status_handler(1920) > pid(4354) status(3)
05-24 17:35:58.186+0900 D/RESOURCED( 2371): proc-monitor.c: proc_dbus_proc_signal_handler(198) > [proc_dbus_proc_signal_handler,198] call proc_dbus_proc_signal_handler : pid = 4354, type = 0
05-24 17:35:58.186+0900 D/RESOURCED( 2371): proc-main.c: resourced_proc_status_change(555) > [SECURE_LOG] [resourced_proc_status_change,555] set foreground : 4354
05-24 17:35:58.186+0900 I/RESOURCED( 2371): lowmem-handler.c: lowmem_move_memcgroup(1190) > [lowmem_move_memcgroup,1190] buf : /sys/fs/cgroup/memory/foreground/cgroup.procs, pid : 4354, oom : 200
05-24 17:35:58.186+0900 E/RESOURCED( 2371): lowmem-handler.c: lowmem_move_memcgroup(1193) > [lowmem_move_memcgroup,1193] /sys/fs/cgroup/memory/foreground/cgroup.procs open failed
05-24 17:35:58.196+0900 D/APP_CORE( 4354): appcore-efl.c: __update_win(718) > [EVENT_TEST][EVENT] __update_win WIN:1c00002 fully_obscured 0
05-24 17:35:58.196+0900 D/APP_CORE( 4354): appcore-efl.c: __visibility_cb(884) > bvisibility 1, b_active -1
05-24 17:35:58.196+0900 D/APP_CORE( 4354): appcore-efl.c: __visibility_cb(887) >  Go to Resume state
05-24 17:35:58.196+0900 D/APP_CORE( 4354): appcore-efl.c: __do_app(470) > [APP 4354] Event: RESUME State: RUNNING
05-24 17:35:58.196+0900 D/LAUNCH  ( 4354): appcore-efl.c: __do_app(557) > [basicui:Application:resume:start]
05-24 17:35:58.196+0900 D/LAUNCH  ( 4354): appcore-efl.c: __do_app(567) > [basicui:Application:resume:done]
05-24 17:35:58.196+0900 D/LAUNCH  ( 4354): appcore-efl.c: __do_app(569) > [basicui:Application:Launching:done]
05-24 17:35:58.196+0900 D/APP_CORE( 4354): appcore-efl.c: __trm_app_info_send_socket(230) > __trm_app_info_send_socket
05-24 17:35:58.196+0900 E/APP_CORE( 4354): appcore-efl.c: __trm_app_info_send_socket(233) > access
05-24 17:35:59.086+0900 D/APP_CORE( 4354): appcore-rotation.c: __changed_cb(123) > [APP 4354] Rotation: 0 -> 1
05-24 17:35:59.086+0900 D/APP_CORE( 4354): appcore-rotation.c: __changed_cb(126) > [APP 4354] Rotation: 0 -> 1
05-24 17:35:59.086+0900 I/CAPI_APPFW_APPLICATION( 4354): app_main.c: _ui_app_appcore_rotation_event(483) > _ui_app_appcore_rotation_event
05-24 17:35:59.116+0900 I/basicui ( 4354): <align=center
05-24 17:35:59.166+0900 D/AUL_AMD ( 2192): amd_request.c: __add_history_handler(254) > [SECURE_LOG] add rua history org.example.basicui /opt/usr/apps/org.example.basicui/bin/basicui
05-24 17:35:59.166+0900 D/RUA     ( 2192): rua.c: rua_add_history(179) > rua_add_history start
05-24 17:35:59.176+0900 D/RUA     ( 2192): rua.c: rua_add_history(247) > rua_add_history ok
05-24 17:36:00.126+0900 I/basicui ( 4354): <align=center
05-24 17:36:00.496+0900 E/CAPI_APPFW_APPLICATION_PREFERENCE( 2284): preference.c: _preference_check_retry_err(459) > key(clock_font_color), check retry err: -21/(2/No such file or directory).
05-24 17:36:00.496+0900 E/CAPI_APPFW_APPLICATION_PREFERENCE( 2284): preference.c: _preference_get_key(1028) > _preference_get_key(clock_font_color) step(-17825744) failed(2 / No such file or directory)
05-24 17:36:00.496+0900 E/CAPI_APPFW_APPLICATION_PREFERENCE( 2284): preference.c: preference_get_int(1063) > preference_get_int(2284) : key(clock_font_color) error
05-24 17:36:00.496+0900 E/CAPI_APPFW_APPLICATION_PREFERENCE( 2284): preference.c: _preference_check_retry_err(459) > key(showdate), check retry err: -21/(2/No such file or directory).
05-24 17:36:00.496+0900 E/CAPI_APPFW_APPLICATION_PREFERENCE( 2284): preference.c: _preference_get_key(1028) > _preference_get_key(showdate) step(-17825744) failed(2 / No such file or directory)
05-24 17:36:00.496+0900 E/CAPI_APPFW_APPLICATION_PREFERENCE( 2284): preference.c: preference_get_int(1063) > preference_get_int(2284) : key(showdate) error
05-24 17:36:00.496+0900 D/IDLE-CLOCK-DIGITAL( 2284): clock_view.c: clock_view_set_info_time(849) > show_date:1
05-24 17:36:00.496+0900 D/IDLE-CLOCK-DIGITAL( 2284): clock_view.c: _get_formatted_date_from_utc_time(678) > [SECURE_LOG] date:(10)[Tue 24 May][1464078960]
05-24 17:36:00.496+0900 D/IDLE-CLOCK-DIGITAL( 2284): clock_view.c: clock_view_set_info_time(857) > 
05-24 17:36:00.496+0900 D/IDLE-CLOCK-DIGITAL( 2284): clock_view.c: _get_formatted_ampm_from_utc_time(715) > [SECURE_LOG] ampm:(2)[PM][1464078960]
05-24 17:36:00.496+0900 D/IDLE-CLOCK-DIGITAL( 2284): clock_view.c: _get_formatted_time_from_utc_time(756) > [SECURE_LOG] time:(4)[5:36][1464078960]
05-24 17:36:00.496+0900 D/IDLE-CLOCK-DIGITAL( 2284): clock_view.c: clock_view_set_info_time(871) > utc_time=5:36, utc_ampm=[2]PM
05-24 17:36:00.496+0900 D/IDLE-CLOCK-DIGITAL( 2284): clock_view.c: clock_view_set_info_time(891) > time_str=<color=#FFFFFFFF>5:36<font_size=24><font=Tizen:style=Bold> PM</font></font_size></color>
05-24 17:36:01.116+0900 I/basicui ( 4354): <align=center
05-24 17:36:02.126+0900 I/basicui ( 4354): <align=center
05-24 17:36:03.116+0900 I/basicui ( 4354): <align=center
05-24 17:36:04.116+0900 I/basicui ( 4354): <align=center
05-24 17:36:05.116+0900 I/basicui ( 4354): <align=center
05-24 17:36:06.126+0900 W/CRASH_MANAGER( 4217): worker.c: worker_job(1189) > 1104354626173146407896
