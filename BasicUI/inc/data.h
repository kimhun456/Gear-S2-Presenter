/*
 * data.h
 *
 *  Created on: May 24, 2016
 *      Author: HyunJae
 */

#ifndef DATA_H_
#define DATA_H_

#include <app.h>
#include <Elementary.h>
#include <system_settings.h>
#include <efl_extension.h>
#include <dlog.h>
#include <stdlib.h>
#include <string>

typedef struct appdata {
	Evas_Object *win;
	Evas_Object *conform;
	Evas_Object *box;
	Evas_Object *buttonBox;
	Evas_Object *title;
	Evas_Object *content;
	Evas_Object* gesture;
	Evas_Object* nextButton;
	Evas_Object* prevButton;
	int milliseconds;
	bool start;
	Ecore_Timer* timer;

} appdata_s;


#endif /* DATA_H_ */


#define ICON_DIR "/opt/usr/apps/org.example.basicui/res/images"