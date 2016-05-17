#include "basicui.h"



/*
 *
 * 앱정보를 저장하는 구조체이다.
 *
 */
typedef struct appdata {
	Evas_Object *win;
	Evas_Object *conform;
	Evas_Object *label;
} appdata_s;
/*
static void
win_delete_request_cb(void *data, Evas_Object *obj, void *event_info)
{
	ui_app_exit();
}*/


/**
 *
 * 뒤로가기 키가 눌렸을 때 호출 되는 함수.
 *	이 함수를 직접 호출 할 수는 없다.
 */
static void
win_back_cb(void *data, Evas_Object *obj, void *event_info)
{
	appdata_s *ad = data;
	/* Let window go to hide state. */
//	elm_win_lower(ad->win);
	elm_win_iconified_set(ad->win, EINA_TRUE);
}
static void
my_box_pack(Evas_Object *box, Evas_Object *child,
		double h_weight, double v_weight, double h_align, double v_align)
{
	/* create a frame we shall use as padding around the child widget */
	Evas_Object *frame = elm_frame_add(box);

	// elm Object스타일을 정해준다.
	elm_object_style_set(frame, "pad_medium");
	/* set the input weight/align on the frame instead of the child */
	// weight setting
	evas_object_size_hint_weight_set(frame, h_weight, v_weight);
	// align setting
	evas_object_size_hint_align_set(frame, h_align, v_align);
	{
		/* tell the child that is packed into the frame to be able to expand */
		evas_object_size_hint_weight_set(child, EVAS_HINT_EXPAND,EVAS_HINT_EXPAND);
		/* fill the expanded area (above) as opposaed to center in it */
		evas_object_size_hint_align_set(child, EVAS_HINT_FILL, EVAS_HINT_FILL);
		/* actually put the child in the frame and show it */
		evas_object_show(child);
		elm_object_content_set(frame, child);
	}
	/* put the frame into the box instead of the child directly */
	elm_box_pack_end(box, frame);
	/* show the frame */
	evas_object_show(frame);

}


/**
 * 화면을 구성하는 윈도우와 각종 컨테이너 및 위젯을 생성하는 함수.
 *
 */
static void
create_base_gui(appdata_s *ad)
{

	// 마지막 윈도우가 사라질때 앱이 종료되도록 지정
	elm_policy_set(ELM_POLICY_QUIT,ELM_POLICY_QUIT_LAST_WINDOW_CLOSED);


	/* Window */
	//윈도우 객체 생성 함수 윈도우는 화면 레이아웃 최상위 오브젝트이다. 하나의 앱은 하나의 윈도우를 갖게 된다.
	// 주로 컨테이너를 추가하고 그 위에 위젯을 추가하게 된다.

	ad->win = elm_win_util_standard_add(PACKAGE, PACKAGE);

	elm_win_autodel_set(ad->win, EINA_TRUE);

	// 화면 회전방향을 지정하는 API이다.4개를 인자로 주면 모든 화면 방향을 지원하게 된다.

	if (elm_win_wm_rotation_supported_get(ad->win)) {
		int rots[4] = { 0, 90, 180, 270 };
		elm_win_wm_rotation_available_rotations_set(ad->win, (const int *)(&rots), 4);
	}

	//오브젝트에 이벤트 콜백함수를 지정하는 함수이다.
	// 1 = 오브젝트  2 = 이벤트종류 3 = 콜백함수명 4 = 사용자 데이터
	eext_object_event_callback_add(ad->win, EEXT_CALLBACK_BACK, win_back_cb, ad);

	/* Conformant
	 *
	 * Conformant 는 화면에 새로운 영역이 추가되었을 때 윈도우 크기를 변경해주는 기능을 담당하게 된다.
	 * 하나의 앱은 하나의 Conformant만을 가져야한다.
	 * 즉, 있는게 더 나은거 같다?
	*/

	ad->conform = elm_conformant_add(ad->win);
	/*
	 *  indicator 는 상태바
	 */

	// 인디케이터를 표시 여부를 지정하는 API
	elm_win_indicator_mode_set(ad->win, ELM_WIN_INDICATOR_SHOW);
	// 인디케이터의 투명도를 셋팅하는 API
	elm_win_indicator_opacity_set(ad->win, ELM_WIN_INDICATOR_OPAQUE);

	// 오브젝트의 크기를 대략적으로 지정하는 API
	evas_object_size_hint_weight_set(ad->conform, EVAS_HINT_EXPAND, EVAS_HINT_EXPAND);

	//Window오브젝트에 다른 오브젝트를 추가하며 크기를 변경하는 API
	elm_win_resize_object_add(ad->win, ad->conform);


	evas_object_show(ad->conform);



	/* BOX  */

	Evas_Object *box = elm_box_add(ad->win);

	evas_object_size_hint_weight_set(box,EVAS_HINT_EXPAND,EVAS_HINT_EXPAND);

	elm_object_content_set(ad->conform, box);

	evas_object_show(box);

	{

		//라벨 위젯 생성 함수.
		ad->label = elm_label_add(ad->conform);
		// 텍스트를 표시 할수 있으며 html태그를 이용하여 텍스트 속성을 변경할수 있다.
		// 위젯의 캡션 텍스트를 변경하는 함수 .
		//버튼 엔트리등에도 사용할 수 있다.
		elm_object_text_set(ad->label,"<align=center>Hello World</align>");

		my_box_pack(box,ad->label,1.0,0.0,-1.0,0.5);
	}

	// 오브젝트를 화면에 표시하는 함수.
	// 모든 오브젝트에 공통적으로 사용할 수 있다.
	evas_object_show(ad->win);
}

static bool
app_create(void *data)
{
	/* Hook to take necessary actions before main event loop starts
		Initialize UI resources and application's data
		If this function returns true, the main loop of application starts
		If this function returns false, the application is terminated */
	appdata_s *ad = data;

	create_base_gui(ad);

	return true;
}

static void
app_control(app_control_h app_control, void *data)
{
	/* Handle the launch request. */
}

static void
app_pause(void *data)
{
	/* Take necessary actions when application becomes invisible. */
}

static void
app_resume(void *data)
{
	/* Take necessary actions when application becomes visible. */
}

static void
app_terminate(void *data)
{
	/* Release all resources. */
}

static void
ui_app_lang_changed(app_event_info_h event_info, void *user_data)
{
	/*APP_EVENT_LANGUAGE_CHANGED*/
	char *locale = NULL;
	system_settings_get_value_string(SYSTEM_SETTINGS_KEY_LOCALE_LANGUAGE, &locale);
	elm_language_set(locale);
	free(locale);
	return;
}
//
//static void
//ui_app_orient_changed(app_event_info_h event_info, void *user_data)
//{
//	/*APP_EVENT_DEVICE_ORIENTATION_CHANGED*/
//	return;
//}
//
//static void
//ui_app_region_changed(app_event_info_h event_info, void *user_data)
//{
//	/*APP_EVENT_REGION_FORMAT_CHANGED*/
//}
//
//static void
//ui_app_low_battery(app_event_info_h event_info, void *user_data)
//{
//	/*APP_EVENT_LOW_BATTERY*/
//}
//
//static void
//ui_app_low_memory(app_event_info_h event_info, void *user_data)
//{
//	/*APP_EVENT_LOW_MEMORY*/
//}

int
main(int argc, char *argv[])
{
	appdata_s ad = {0,};
	int ret = 0;

	ui_app_lifecycle_callback_s event_callback = {0,};
	app_event_handler_h handlers[5] = {NULL, };

	event_callback.create = app_create;
	event_callback.terminate = app_terminate;
	event_callback.pause = app_pause;
	event_callback.resume = app_resume;
	event_callback.app_control = app_control;

//	ui_app_add_event_handler(&handlers[APP_EVENT_LOW_BATTERY], APP_EVENT_LOW_BATTERY, ui_app_low_battery, &ad);
//	ui_app_add_event_handler(&handlers[APP_EVENT_LOW_MEMORY], APP_EVENT_LOW_MEMORY, ui_app_low_memory, &ad);
//	ui_app_add_event_handler(&handlers[APP_EVENT_DEVICE_ORIENTATION_CHANGED], APP_EVENT_DEVICE_ORIENTATION_CHANGED, ui_app_orient_changed, &ad);
	ui_app_add_event_handler(&handlers[APP_EVENT_LANGUAGE_CHANGED], APP_EVENT_LANGUAGE_CHANGED, ui_app_lang_changed, &ad);
//	ui_app_add_event_handler(&handlers[APP_EVENT_REGION_FORMAT_CHANGED], APP_EVENT_REGION_FORMAT_CHANGED, ui_app_region_changed, &ad);
//	ui_app_remove_event_handler(handlers[APP_EVENT_LOW_MEMORY]);

	ret = ui_app_main(argc, argv, &event_callback, &ad);
	if (ret != APP_ERROR_NONE) {
		dlog_print(DLOG_ERROR, LOG_TAG, "app_main() is failed. err = %d", ret);
	}

	return ret;
}