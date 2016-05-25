#include "basicui.h"


static void
win_delete_request_cb(void *data, Evas_Object *obj, void *event_info)
{
	ui_app_exit();
}

static void
win_back_cb(void *data, Evas_Object *obj, void *event_info)
{

	appdata_s *ad =  static_cast<appdata_s*>(data);
	/* Let window go to hide state. */
	elm_win_lower(ad->win);
}

static void
create_base_gui(appdata_s *ad)
{
	/* Window */
	ad->win = elm_win_util_standard_add(PACKAGE, PACKAGE);
	elm_win_autodel_set(ad->win, EINA_TRUE);

	if (elm_win_wm_rotation_supported_get(ad->win)) {
		int rots[4] = { 0, 90, 180, 270 };
		elm_win_wm_rotation_available_rotations_set(ad->win, (const int *)(&rots), 4);
	}

	evas_object_smart_callback_add(ad->win, "delete,request", win_delete_request_cb, NULL);
	eext_object_event_callback_add(ad->win, EEXT_CALLBACK_BACK, win_back_cb, ad);

	/* BOX */
	ad->box = elm_box_add(ad->win);
	evas_object_size_hint_weight_set(ad->box, EVAS_HINT_EXPAND, EVAS_HINT_EXPAND);
	elm_box_align_set(ad->box, 0.5, 0.5);
	evas_object_show(ad->box);


	elm_win_resize_object_add(ad->win, ad->box);

	/* Label */
	ad->title = elm_label_add(ad->box);
	elm_object_text_set(ad->title, "<align=center>Presentor</align>");
	evas_object_size_hint_weight_set(ad->title, EVAS_HINT_EXPAND, EVAS_HINT_EXPAND);
	evas_object_show(ad->title);
	elm_box_pack_end(ad->box, ad->title);


	/* Label */
	ad->content = elm_label_add(ad->box);
	elm_object_text_set(ad->content, "<align=center>00:00:00</align>");
	evas_object_size_hint_weight_set(ad->content, EVAS_HINT_EXPAND, EVAS_HINT_EXPAND);
	evas_object_show(ad->content);
	elm_box_pack_end(ad->box, ad->content);

	/* Gesture Layout add */
	ad->gesture = elm_gesture_layer_add(ad->content);
	elm_gesture_layer_attach(ad->gesture, ad->content);

	/* Button Box */

	ad->buttonBox =elm_box_add(ad->box);
	evas_object_size_hint_weight_set(ad->buttonBox, EVAS_HINT_EXPAND, 0.5);
	evas_object_size_hint_align_set(ad->buttonBox, EVAS_HINT_FILL, EVAS_HINT_FILL);
	elm_box_align_set(ad->buttonBox, 0.5, 0.5);
	elm_box_horizontal_set(ad->buttonBox, EINA_TRUE);
	elm_box_padding_set(ad->buttonBox, 3, 20);
	elm_box_pack_end(ad->box, ad->buttonBox);
	evas_object_show(ad->buttonBox);

	ad->prevButton = elm_button_add(ad->buttonBox);
	evas_object_size_hint_weight_set(ad->prevButton, EVAS_HINT_EXPAND, 0.5);
	//할당받은 공간에 맞게 버튼의 가로 세로 크기를 키운다.
	evas_object_size_hint_align_set(ad->prevButton, EVAS_HINT_FILL, EVAS_HINT_FILL);
	elm_object_text_set(ad->prevButton, "<align=center>    PREV</align>");
	evas_object_show(ad->prevButton);
	elm_box_pack_end(ad->buttonBox, ad->prevButton);

	ad->nextButton = elm_button_add(ad->buttonBox);
	evas_object_size_hint_weight_set(ad->nextButton, EVAS_HINT_EXPAND, 0.5);
	//할당받은 공간에 맞게 버튼의 가로 세로 크기를 키운다.
	evas_object_size_hint_align_set(ad->nextButton, EVAS_HINT_FILL, EVAS_HINT_FILL);
	elm_object_text_set(ad->nextButton, "<align=center>NEXT    </align>");
	evas_object_show(ad->nextButton);
	elm_box_pack_end(ad->buttonBox, ad->nextButton);

	/* Show window after base gui is set up */
	evas_object_show(ad->win);
	make_clock(ad);
}



static bool
app_create(void *data)
{
	/* Hook to take necessary actions before main event loop starts
		Initialize UI resources and application's data
		If this function returns true, the main loop of application starts
		If this function returns false, the application is terminated */


	appdata_s *ad =  static_cast<appdata_s*>(data);

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

static void
ui_app_orient_changed(app_event_info_h event_info, void *user_data)
{
	/*APP_EVENT_DEVICE_ORIENTATION_CHANGED*/
	return;
}

static void
ui_app_region_changed(app_event_info_h event_info, void *user_data)
{
	/*APP_EVENT_REGION_FORMAT_CHANGED*/
}

static void
ui_app_low_battery(app_event_info_h event_info, void *user_data)
{
	/*APP_EVENT_LOW_BATTERY*/
}

static void
ui_app_low_memory(app_event_info_h event_info, void *user_data)
{
	/*APP_EVENT_LOW_MEMORY*/
}

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

	ui_app_add_event_handler(&handlers[APP_EVENT_LOW_BATTERY], APP_EVENT_LOW_BATTERY, ui_app_low_battery, &ad);
	ui_app_add_event_handler(&handlers[APP_EVENT_LOW_MEMORY], APP_EVENT_LOW_MEMORY, ui_app_low_memory, &ad);
	ui_app_add_event_handler(&handlers[APP_EVENT_DEVICE_ORIENTATION_CHANGED], APP_EVENT_DEVICE_ORIENTATION_CHANGED, ui_app_orient_changed, &ad);
	ui_app_add_event_handler(&handlers[APP_EVENT_LANGUAGE_CHANGED], APP_EVENT_LANGUAGE_CHANGED, ui_app_lang_changed, &ad);
	ui_app_add_event_handler(&handlers[APP_EVENT_REGION_FORMAT_CHANGED], APP_EVENT_REGION_FORMAT_CHANGED, ui_app_region_changed, &ad);
	ui_app_remove_event_handler(handlers[APP_EVENT_LOW_MEMORY]);

	ret = ui_app_main(argc, argv, &event_callback, &ad);
	if (ret != APP_ERROR_NONE) {
		dlog_print(DLOG_ERROR, LOG_TAG, "app_main() is failed. err = %d", ret);
	}

	return ret;
}
