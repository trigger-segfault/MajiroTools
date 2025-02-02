﻿using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using Majiro.Script;

namespace Majiro {
	public static class Data {
		public const string SyscallGroup = "MAJIRO_INTER";
		public const string SyscallSuffix = "@" + SyscallGroup;

		public static IReadOnlyCollection<uint> SyscallHashes = new HashSet<uint> {
			0x959b0a16, 0x109ca5db, 0xdecb9c75, 0xdca7da63, 0xcb8ab2a3, 0x8c283f7f, 0xe06200c4, 0xa90f0e05,
			0x12877048, 0x4694366a, 0xf3679c34, 0xdcc0d033, 0x67444f84, 0x1576ccec, 0x5f7ffd3b, 0xdf644f85,
			0xb5551fdf, 0x4020c370, 0x65d3b77c, 0x7f01f772, 0x4d2d4277, 0x0d141855, 0xe218ba5f, 0xd0f4b51a,
			0xedfd552c, 0x253982f4, 0x8dc0d2cd, 0x693d9729, 0xe2413ef9, 0x7fcf3c82, 0x5bbae511, 0xa6ac6ccc,
			0x96b07aee, 0x1f57b724, 0xaab68e6d, 0x3a49e325, 0x134d5585, 0x42d7c922, 0x87a631a6, 0xd6333b3c,
			0xe4e3b40d, 0x63b8cb23, 0x2539d212, 0xe8a6a59f, 0x6008bebb, 0x55232561, 0xd1921ed9, 0xc46925cf,
			0xf103c078, 0xc47dbe4b, 0xc32e286f, 0x3e11f2c5, 0xf66cd6ea, 0x6e83677a, 0xf9a3b675, 0x86294bfe,
			0x160176be, 0x4b5ac64b, 0x3d4b9052, 0x619de833, 0x067b44a4, 0x6e6c641a, 0x6f769889, 0x6cfc884a,
			0x3d053317, 0x00d696cc, 0x8eb8f951, 0xb7e3e81c, 0xc6282f19, 0x46b18379, 0x80177286, 0xa2e45c9c,
			0x9a1aceca, 0xedb64309, 0x4fac462c, 0xf4bb403d, 0xbc6402c9, 0xc1d2b85a, 0x2399d761, 0xd2219a75,
			0xcd290aef, 0x4afc6e20, 0xfa34e434, 0xee2b6d92, 0xe90e0a19, 0x5c823701, 0xfed7bfe9, 0x45815f6d,
			0x06906970, 0xb0c8f550, 0xad74d9ac, 0x4f62152a, 0x8aef9167, 0x25401a1f, 0x3fe05b39, 0x69db4512,
			0x0d389c2f, 0x266a3c79, 0xbdaa8e96, 0x6584f13e, 0xee6b328d, 0x978047db, 0xdaca10af, 0x6938ef0c,
			0x140c298e, 0x0692314a, 0x269bda78, 0xcd00d280, 0x9627ddc3, 0xedefb0b0, 0x76ee6c90, 0x29f1ac40,
			0x078a756e, 0x1295bbda, 0xa93c9856, 0x718ef651, 0x1e24e1b6, 0x10db0a43, 0xc21f8b49, 0xa62aa5eb,
			0x4662e95d, 0x3704c919, 0x3eabf498, 0x3c84073c, 0xdd2056f6, 0x42f6fddf, 0x892e9b20, 0x1204d7e8,
			0x008acbc0, 0x32530606, 0x818a4b92, 0xf3d276f1, 0x62374297, 0xfac4f361, 0x9ef1ddc3, 0x86f0f608,
			0x4b306c5c, 0xbc42ca9a, 0x7547c477, 0xc102bcc3, 0xab13be44, 0xf2f9daa8, 0xae497f1a, 0x4ef903f3,
			0x806261ce, 0xff75cd29, 0xcf35f0e3, 0x5131e234, 0xcc3e0342, 0xb5a1e3c9, 0x5fdcccee, 0x0e42730d,
			0x934d927b, 0x8d8d8817, 0x06b3c8ac, 0x82fd765b, 0x2cb1bc41, 0x5b87a41d, 0xba81ef8d, 0xf1f8a206,
			0x728876a3, 0x6e080825, 0x88b4b26c, 0x3f401bbd, 0x979d1f16, 0xa2743878, 0x6621f84d, 0x0c6d0129,
			0x307f28bc, 0x59180bbb, 0x5c9ed743, 0x403960f8, 0x30fa2a29, 0x35a89417, 0x90816c6e, 0xe186d19a,
			0x57f6310d, 0x9a661709, 0xb75c3b5f, 0x8cfc4573, 0x05ea6e4d, 0xe6a97e70, 0xd4066e31, 0x4133d7a9,
			0x877445ce, 0x7d8b2c41, 0x098399f2, 0xdf9f7749, 0xaccf4004, 0x0542e1b7, 0x824d124f, 0x25d92502,
			0xbbf35806, 0xb0ce081a, 0x507f22c6, 0x29098ec0, 0x09c43040, 0x4afc5c07, 0x2159ebe0, 0xf63ed9ae,
			0x70612db5, 0xe5e4e2ff, 0xd01be374, 0x56bbba3a, 0xfddf6c40, 0x30636d6e, 0x171aee22, 0xda675785,
			0xac796720, 0x61bae53c, 0xa361d9f7, 0x89b59d02, 0x4c310b4b, 0x7e277952, 0x053fac99, 0x4697d2dd,
			0xfd128a61, 0x87113971, 0x4fa8483f, 0x3cad3884, 0x9ac11f47, 0xa79731a2, 0x18423eaa, 0xd14a4d9c,
			0xd6c3bbac, 0x221c2cc2, 0x78a31c03, 0x6f5689e4, 0xeadd9484, 0x80f94706, 0xe3605cfa, 0xf63cb36c,
			0x83d81f59, 0xdad96289, 0x57efa275, 0xf94b3586, 0x5e4e3063, 0x8d84b83f, 0xf8fd08f6, 0x65f2e980,
			0xc50dfd06, 0xf9705332, 0xd3c06820, 0x7a7b6ed4, 0x539b07bc, 0xce94e6ca, 0x5eb974f7, 0x924ee3eb,
			0x54ef8174, 0x3670b283, 0x929a367d, 0xb1681699, 0xf9d94e91, 0xd34e9b28, 0xf65aa4c0, 0xd5999d46,
			0x05b1a6e8, 0x125cfbdb, 0xca30043a, 0x9143dc9e, 0x89ce8c53, 0x490d6b50, 0x78a6a112, 0x168efcb7,
			0x3cba6309, 0x8f874e29, 0x3a3ca0f1, 0x89018dd1, 0xc438ba98, 0x4c99b0ea, 0x8cd709f9, 0x65075141,
			0xa549e852, 0x4ffab7c4, 0x99a5de25, 0x3378635d, 0xe91b0504, 0x7c3b36c5, 0x1bb47604, 0x44b5c4ed,
			0x4d849aa6, 0xf8004993, 0x3474d65b, 0xeb5cc468, 0x9af10167, 0x3a3bfb29, 0xd538f7b5, 0x4e1eb9d0,
			0xf8d18340, 0xa7c6e918, 0xefd49bc9, 0x72db7abf, 0x2075c300, 0xad0f8767, 0xaf6571ab, 0xa909a32a,
			0x163c0878, 0xd08a57f8, 0xd215e29a, 0x23d5d11d, 0xaefc64da, 0xfb7fb744, 0xca5c98f2, 0x0d36e2a7,
			0xbef4edfa, 0x5c9761c5, 0xb758ac4e, 0x2c18d5a9, 0x45e32ea6, 0xe316a8f2, 0xbb9d7a7f, 0x6ddeb30e,
			0x1f5a14d4, 0xf5e5be93, 0xe5a2ce14, 0x850eecf4, 0xd481e1a2, 0xebb5886c, 0x50cd2dca, 0xf0fd9886,
			0x2e99e98c, 0xd583668c, 0x1cd5bca8, 0x62442ec6, 0xfaf17b1c, 0xda60f137, 0xf430015b, 0x321717d1,
			0x4ea2d1fc, 0x95ff28f2, 0xee154520, 0x111bd910, 0xc5270429, 0xe5c70196, 0x1f9f3d5a, 0x3513ee87,
			0xf4f00701, 0x22c23fa2, 0x735c88f1, 0x68ba0964, 0xddd25909, 0x97bd691d, 0x02026ac6, 0xe5dcef92,
			0xc692be76, 0x13c305da, 0x6ed38886, 0x0c93fcb4, 0xcd111b0e, 0x1ec3c6bb, 0x6501cc30, 0x0c7a0e97,
			0x6fcb7185, 0xdaa321e8, 0x072e738c, 0x6eaec2a0, 0xbfa74901, 0xb3ffdffa, 0x15d07df8, 0x0dc634c4,
			0x844d2028, 0xb268f04f, 0xde1e2ed0, 0x4311cfa6, 0x26dc6566, 0x4980f82c, 0x4f6367b3, 0x15eedeaa,
			0x379fdb39, 0xeeaa9104, 0x2626fe02, 0xf86fc950, 0xa589dbd1, 0xabb7fcfb, 0xd011ff32, 0xf8d8925b,
			0x91ceacf2, 0x0c070535, 0xe7b90df5, 0xd8279a9b, 0xf62e3ca7, 0x708b0256, 0x170b0b45, 0x2e861c51,
			0xe712fec1, 0xe0aa2f52, 0xb8155ff4, 0xa0b0fead, 0x546f69c3, 0xe799eac8, 0x804ff66d, 0xed84e320,
			0xc0e98b1d, 0x39ae7891, 0xf03a9a01, 0xf7824b92, 0x5747e915, 0x77527ef5, 0x838de99b, 0x08cb5c29,
			0x57ad7635, 0x884949e0, 0x8ad70056, 0x5c7746d1, 0x95e3a441, 0x925b75d2, 0xb669e371, 0x3d6cf5be,
			0xc9b362d0, 0xe9e5564d, 0x1d93fd7e, 0x8424cf12, 0x9cabfdf3, 0x7b657bab, 0xb2f1993b, 0xa65b03ae,
			0x2b10081b, 0xdfcf9f75, 0xf9d7b692, 0x0bef00db, 0xc0c15d7c, 0x926c13e5, 0x5bf8f175, 0x5c4020e6,
			0x7f918815, 0x777aa894, 0x83a53ffa, 0x201d3d29, 0x5785a054, 0x32d0236c, 0x8e8167f2, 0x19fc7cc7,
			0x8f905b3f, 0x4604b9af, 0x94eaeffc, 0xae47892f, 0x5a981e41, 0xcb665ac0, 0x8eb881ef, 0x46b28fef,
			0x173b92d1, 0xdeaf7041, 0xdf91cfc5, 0x90d5298a, 0xf1097a07, 0x05d6ed69, 0x801d7af9, 0xd1f672c7,
			0x2bd1709d, 0x7e0b8320, 0xcf2b1e50, 0x6de6cdfc, 0xdfd5599e, 0xf80bc9b6, 0xa30a7d75, 0xff7c52e6,
			0xd7771b72, 0xdfdba8e4, 0xc29b30e3, 0x52819912, 0x103edac0, 0x7b0e970d, 0xef4581dc, 0xf6a05538,
			0xc2c3c4f4, 0xcd71fe7a, 0x265e07d7, 0x6b4a7873, 0xf6459905, 0xdcc706ef, 0x68ef2987, 0x63f660a2,
			0xfef981d4, 0xe119d5ba, 0x40258a56, 0x4ab0caef, 0x63c341b1, 0x4a02d664, 0x5548ef5e, 0x69073588,
			0x7bffc5b1, 0x721fa5b7, 0x58b31737, 0x661afb43, 0x3f34d519, 0xedca8992, 0x01b4517c, 0xe76f8a65,
			0x3b1d5537, 0x6f384a3d, 0x42e41a6b, 0xba383010, 0x8838fd56, 0x81ce0485, 0x8c7f4c1e, 0x60085fa4,
			0x44bc7555, 0xd4590bd3, 0x0ebc053b, 0x38721a26, 0x45acd4a7, 0x45ad5f4d, 0x461ea516, 0x50846ad3,
			0x649cfc79, 0x6e7f7fb7, 0x86e933d1, 0x8d8fb32e, 0x8fe5d6e7, 0x9fb53fbe, 0xb84c9953, 0xc68c011a,
			0xefd59130, 0xf6416e87
		};

		public static IReadOnlyCollection<uint> SyscallHashesWithoutNamespace = new HashSet<uint>(SyscallHashes.Select(hash => Crc.HashInverse32(SyscallSuffix, hash)));

		public static IReadOnlyCollection<string> KnownSyscallNames = new List<string> {
			"abs", "atoi", "change_cursor", "chr$", "client_height", "client_width", "clipbord_is_change", "cos%",
			"crc32str", "debugout", "debugout_dialog", "dialog_ask_ok", "dialog_ask_okcancel", "dialog_ask_yesno",
			"dialog_error_ok", "dialog_error_okcancel", "dialog_error_retrycancel", "dialog_error_yesno",
			"dialog_input$", "dialog_ok", "dialog_okcancel", "dialog_retrycancel", "dialog_warning_ok",
			"dialog_warning_okcancel", "dialog_warning_retrycancel", "dialog_warning_yesno", "dialog_yesno",
			"dim_copy%#", "dim_copy#", "dim_copy$#", "dim_create%#", "dim_create#", "dim_create$#", "dim_release%#",
			"dim_release#", "dim_release$#", "file_close", "file_open", "file_puts", "file_read", "file_read_line_raw$",
			"file_read_line$", "file_read$", "file_write_open", "force_key_paste", "get_clipbord$", "get_frontbuffer",
			"get_variable", "get_variable_nowarn", "get_variable_nowarn$", "get_variable$", "is_log_no_pic",
			"is_log_no_voice", "is_report_no_pic", "is_report_no_voice", "is_testplay", "itoa$", "max", "min",
			"num_strsplit", "open_help", "rand", "rand!", "reg_read", "reg_read$", "reg_write", "reg_write_string",
			"set_clipbord", "set_fast_mode_flg", "set_frontbuffer", "set_syukusyou", "set_variable", "set_wallpaper",
			"set_watchlist", "sin%", "speed_setup_dialog", "strcmp", "strdate$", "stricmp", "strleft$", "strlen",
			"strlwr$", "strmatch", "strmid$", "strright$", "strsplit$", "strstr", "strtime$", "strupr$", "tan%",
			"timer", "timer_progress", "volume_setup_dialog", "web_access", "write_pic_cache", "get_game_speed",
			"get_nanido", "call", "call_sub", "call_sub_str", "do_event", "do_event_single", "event_hook",
			"event_hook_after", "event_release", "exec", "exec_func", "load_library", "is_auto_mode", "is_fast_mode",
			"draw_wait", "exit", "fast_mode_config", "get_fast_stat", "is_read", "mk_read", "mk_unwait", "mk_wait",
			"reset_exec", "reset_fast_mode", "reset_ultra_fast_mode", "screen_mode", "set_auto_mode", "set_fast_mode",
			"set_fast_mode_ar", "set_fast_mode_force", "set_fast_stat", "set_ultra_fast_mode", "show_mouse_cursor",
			"thread_begin", "thread_begin_child", "thread_end", "time_accera", "timer_sync", "wait", "console_cls",
			"console_color", "console_curpos_x", "console_curpos_y", "console_dispose", "console_font",
			"console_font_height_get", "console_hist_pos", "console_is_on", "console_locate", "console_locate_force",
			"console_next", "console_next_wipe", "console_num_hist", "console_num_hist_wipe", "console_off",
			"console_on", "console_prev", "console_prev_wipe", "console_redraw", "console_replay",
			"console_resetzerotime", "console_set", "console_setzerotime", "fontout", "fontout_color", "fontout_font",
			"fontout_locate", "fontout_pop", "fontout_push", "get_last_msg$", "histbuff_clear", "histbuff_disable",
			"histbuff_enable", "load_font", "set_font_cache", "set_voice_male", "set_voice_skip", "voicerect_height",
			"voicerect_name$", "voicerect_name_alt$", "voicerect_num", "voicerect_top", "fuchidori_copy",
			"full_screen_height", "full_screen_width", "get_alfapage", "grp_alfa_tabled_copy", "grp_boxfill",
			"grp_copy", "grp_extboxfill", "grp_extcopy", "grp_home", "grp_modcopy", "grp_modify_copy", "grp_mulboxfill",
			"grp_mulcopy", "grp_overlayboxfill", "grp_point_get", "grp_point_set", "grp_reverse", "grp_revmulcopy",
			"grp_sepia", "grp_swap", "grp_zoom", "make_alfa_table", "make_mosaic", "movie_play", "movie_play_fromto",
			"movie_play_repeat", "movie_stat", "movie_stop", "movie_texture", "movie_texture_play",
			"movie_texture_stop", "movie_texture_volume", "movie_volume", "movie_wait", "page_create",
			"page_create_file", "page_create_file_withalfa", "page_create_withalfa", "page_drawmode", "page_is_exist",
			"page_len_x", "page_len_y", "page_release", "page_set_antidata", "pic_is_exist", "pic_key_set", "pic_len_x",
			"pic_len_y", "pic_unpack", "rgb", "rgba", "get_caps_stat", "joy_is_enable", "joy_set_enable", "kb_read",
			"keybd_disable", "keybd_enable", "set_caps_stat", "set_joy", "copy_save", "copy_thumbnail", "delete_save",
			"do_extload", "do_extsave", "do_load", "do_save", "get_current_info$", "get_current_time$",
			"get_save_info$", "get_save_time$", "is_save_menu_disable", "make_thumbnail", "save_disable", "save_enable",
			"save_menu_disable", "save_menu_enable", "save_point", "set_save_info", "areaevent_check", "areaevent_offs",
			"areaevent_reset", "areaevent_set", "areaevent_setdefault", "curpos_x", "curpos_y", "all_setup_dialog",
			"font_dialog$", "get_autospeed", "get_effectspeed", "get_font_name$", "get_mojispeed", "get_voice_setup",
			"is_font_setup_anti", "is_font_setup_bold", "is_font_setup_fuchidori", "is_font_setup_shadow",
			"is_quickload_failsafe", "is_quicksave_failsafe", "is_talk_female", "is_talk_male", "is_voice_continue",
			"is_voice_musicdown", "is_voice_panning", "set_autospeed", "set_effectspeed", "set_font_name",
			"set_mojispeed", "set_musicvolume", "set_quickload_failsafe", "set_quicksave_failsafe", "set_soundvolume",
			"set_voicevolume", "voice_musicdown_vol", "voice_setup", "voice_text_setup", "extmusic", "extmusic_replace",
			"extsound", "extsound2", "extsound3", "extsound4", "music", "music_fade", "music_fadeout",
			"music_fadeout_wait", "music_pause", "music_pop", "music_push", "music_replace", "music_resume",
			"music_stat", "music_stat_reset", "music_stop", "music_vol", "music_wait", "sound", "sound2", "sound2_fade",
			"sound2_fadeout", "sound2_get_fn$", "sound2_is_loop", "sound2_pan", "sound2_stat", "sound2_stop",
			"sound2_vol", "sound2_wait", "sound3", "sound3_fade", "sound3_fadeout", "sound3_get_fn$", "sound3_is_loop",
			"sound3_pan", "sound3_stat", "sound3_stop", "sound3_vol", "sound3_wait", "sound4", "sound4_fade",
			"sound4_fadeout", "sound4_get_fn$", "sound4_is_loop", "sound4_pan", "sound4_stat", "sound4_stop",
			"sound4_vol", "sound4_wait", "sound_ch", "sound_ch_fade", "sound_ch_fadeout", "sound_ch_get_fn$",
			"sound_ch_pan", "sound_ch_stat", "sound_ch_stop", "sound_ch_vol", "sound_ch_wait", "sound_fade",
			"sound_fadeout", "sound_get_fn$", "sound_is_loop", "sound_pan", "sound_stat", "sound_stop", "sound_vol",
			"sound_wait", "voice", "voice_ch", "voice_ch_fade", "voice_ch_fadeout", "voice_ch_get_fn$", "voice_ch_pan",
			"voice_ch_stat", "voice_ch_stop", "voice_ch_vol", "voice_ch_wait", "voice_fade", "voice_fadeout",
			"voice_get_fn$", "voice_pan", "voice_raw", "voice_stat", "voice_stop", "voice_vol", "voice_wait",
			"invalidate_disable", "invalidate_enable", "invalidate_rect", "sprite_alfa_define",
			"sprite_alfa_define_abs", "sprite_alfa_set", "sprite_alfa_wait", "sprite_animate_add",
			"sprite_animate_define", "sprite_animate_define_abs", "sprite_animate_wait", "sprite_clip", "sprite_create",
			"sprite_create_ext", "sprite_create_file", "sprite_create_file_ext", "sprite_get_page", "sprite_get_pos_x",
			"sprite_get_pos_y", "sprite_is_exist", "sprite_is_move", "sprite_len_x", "sprite_len_y", "sprite_move",
			"sprite_move_wait", "sprite_paste", "sprite_pop", "sprite_priority_high", "sprite_priority_high_single",
			"sprite_priority_low", "sprite_priority_low_single", "sprite_push", "sprite_release", "sprite_rotate",
			"sprite_set_smooth_animation", "sprite_tl_set", "sprite_xmodify_define", "sprite_xmodify_get%",
			"sprite_xmodify_set", "sprite_ymodify_define", "sprite_ymodify_get%", "sprite_ymodify_set",
			"sprite_page_auto_release", "auto_mode_config", "is_ultra_fast_mode", "mouse_enable", "ultra_fast_disable",
			"sound_is_exist", "thread_atend", "mouse_disable", "voice_is_exist", "fast_mode_disable", "prevsel_disable",
			"fast_mode_enable", "system_end", "ultra_fast_enable", "thread_is_exist", "prevsel_enable", "mouse_move"
		};

		public static IReadOnlyDictionary<uint, string> KnownSyscallNamesByHash = new Dictionary<uint, string> { };

		public static IReadOnlyCollection<string> KnownGroupNames = new List<string> {
			"GLOBAL", "MAJIRO_INTER", "BOSSMODE", "BUTONMENU", "CARD", "CGMODE", "CHRONICLE", "CONFIG", "CONSOLE",
			"FREESEL", "GAIZI", "RES", "HELP", "HISTORY", "LOADSAVE", "SYSTEM", "MAPMAIN", "MAP", "MENU", "MSG_BOX",
			"MUSICMODE", "PIC", "RANKING", "SIGHT", "ENDING", "STAFFROOM", "TRANSIT", "USERTRANS", "KOEKOE", "ZUKAN",
			"TUMOMENU", "NAKIMENU", "ASK_KIRIPI", "RCLICK_MENU", "KOTITLE", "SAIKORO", "GAMECONTROL", "MINIGAME"
		};

		public static IReadOnlyDictionary<uint, string> KnownFunctionNamesByHash = new Dictionary<uint, string> { };

		public static IReadOnlyCollection<string> KnownVariableNames = new List<string> {
			"#save_info$@BOSSMODE", "@dc@KOEKOE", "@fc@KOEKOE", "@pausecancel@KOEKOE", "@filter_color@PIC",
			"@page_back@PIC", "@pic_top_bak$#@PIC", "@sepia_high@PIC", "@sepia_low@PIC", "@sepia_mode@PIC", "@spr2@PIC",
			"@altwink@CONSOLE", "@catch_skip@CONSOLE", "@catch_x$@CONSOLE", "@ckc@CONSOLE", "@con_mode@CONSOLE",
			"@con_ofs_x@CONSOLE", "@con_ofs_y@CONSOLE", "@do_skip_lastmoji@CONSOLE", "@face_erase_time@CONSOLE",
			"@face_fn$@CONSOLE", "@fast_disp_last_console@CONSOLE", "@fast_mode_sprite@CONSOLE",
			"@fn_console_off$@CONSOLE", "@fn_console_on$@CONSOLE", "@fn_console_push$@CONSOLE", "@force_play@CONSOLE",
			"@game_mode@CONSOLE", "@in_rubi@CONSOLE", "@is_select@CONSOLE", "@kmk@CONSOLE", "@last_auto@CONSOLE",
			"@last_effect@CONSOLE", "@last_face_fn$@CONSOLE", "@last_fastdisp_mode@CONSOLE", "@last_font_name$@CONSOLE",
			"@last_font_skip@CONSOLE", "@last_moji@CONSOLE", "@last_sysdata$@CONSOLE", "@lx@CONSOLE", "@lxl@CONSOLE",
			"@ly@CONSOLE", "@lyl@CONSOLE", "@menuspr@CONSOLE", "@mh_pos_x@CONSOLE", "@mh_pos_y@CONSOLE",
			"@name$@CONSOLE", "@name_disp$@CONSOLE", "@name_mode@CONSOLE", "@nameofs_y@CONSOLE", "@next_beep$@CONSOLE",
			"@no@CONSOLE", "@novel_alfa@CONSOLE", "@re_enter_in_face_disp@CONSOLE", "@ret@CONSOLE",
			"@save_title$@CONSOLE", "@selsel_cur_dic@CONSOLE", "@thread_base@CONSOLE", "@timemax_fixed@CONSOLE",
			"@ucon_x@CONSOLE", "@ucon_xl@CONSOLE", "@ucon_y@CONSOLE", "@ucon_yl@CONSOLE", "#but_on@CONSOLE",
			"#but_on_@CONSOLE", "#but_push@CONSOLE", "#but_push_@CONSOLE", "#con_disp@CONSOLE", "#con_disp_@CONSOLE",
			"#con_draw@CONSOLE", "#con_draw_@CONSOLE", "#console@CONSOLE", "#console_@CONSOLE",
			"#face_alfaseed_page@CONSOLE", "#face_org_page@CONSOLE", "#face_spr@CONSOLE", "#name_org@CONSOLE",
			"#name_org_@CONSOLE", "#name_page@CONSOLE", "#name_page_@CONSOLE", "#name_spr@CONSOLE", "#optmsg@CONSOLE",
			"#optmsg_@CONSOLE", "#optmsg_spr@CONSOLE", "#spr@CONSOLE", "#spr_low@CONSOLE", "#wink_spr@CONSOLE",
			"#wink_spr2@CONSOLE", "#wink_spr3@CONSOLE", "#wink_spr4@CONSOLE", "#wink_spr5@CONSOLE",
			"#wink_spr6@CONSOLE", "@mojispd@CONFIG", "@autospd@CONFIG", "@effectspd@CONFIG", "@conhalf@CONFIG",
			"#conhalf@CONFIG", "#is_dash_ar@CONFIG", "#musicvol@CONFIG", "#rightmode@CONFIG", "#soundvol@CONFIG",
			"#voicevol@CONFIG", "#voice_continue@CONFIG", "#voice_p1@CONFIG", "#voice_p2@CONFIG", "#voice_p3@CONFIG",
			"#voice_p4@CONFIG", "#voice_p5@CONFIG", "#voice_p6@CONFIG", "#voice_p7@CONFIG", "#voice_p8@CONFIG",
			"#voice_p9@CONFIG", "#voice_p10@CONFIG", "#voice_p11@CONFIG", "#voice_p12@CONFIG", "#voice_p13@CONFIG",
			"#voice_p14@CONFIG", "#voice_p15@CONFIG", "#voice_p16@CONFIG", "#voice_p17@CONFIG", "#voice_p18@CONFIG",
			"#voice_p19@CONFIG", "#voice_p20@CONFIG", "@com_hosei@GLOBAL", "@com_id@GLOBAL", "@com_name$@GLOBAL",
			"@com_score@GLOBAL", "@in_yabo@GLOBAL", "@player_score@GLOBAL", "#kaisou_modori@GLOBAL", "#auto_spr@SYSTEM",
			"#autoskip_pos_x@SYSTEM", "#autoskip_pos_y@SYSTEM", "#butall_x@SYSTEM", "#butall_xl@SYSTEM",
			"#butall_y@SYSTEM", "#butall_yl@SYSTEM", "#butauto_x@SYSTEM", "#butauto_xl@SYSTEM", "#butauto_y@SYSTEM",
			"#butauto_yl@SYSTEM", "#butback_x@SYSTEM", "#butback_xl@SYSTEM", "#butback_y@SYSTEM", "#butback_yl@SYSTEM",
			"#butconfig_x@SYSTEM", "#butconfig_xl@SYSTEM", "#butconfig_y@SYSTEM", "#butconfig_yl@SYSTEM",
			"#buterase_x@SYSTEM", "#buterase_xl@SYSTEM", "#buterase_y@SYSTEM", "#buterase_yl@SYSTEM",
			"#butload_x@SYSTEM", "#butload_xl@SYSTEM", "#butload_y@SYSTEM", "#butload_yl@SYSTEM", "#butqload_x@SYSTEM",
			"#butqload_xl@SYSTEM", "#butqload_y@SYSTEM", "#butqload_yl@SYSTEM", "#butqsave_x@SYSTEM",
			"#butqsave_xl@SYSTEM", "#butqsave_y@SYSTEM", "#butqsave_yl@SYSTEM", "#butsave_x@SYSTEM",
			"#butsave_xl@SYSTEM", "#butsave_y@SYSTEM", "#butsave_yl@SYSTEM", "#butskip_x@SYSTEM", "#butskip_xl@SYSTEM",
			"#butskip_y@SYSTEM", "#butskip_yl@SYSTEM", "#butsystem_x@SYSTEM", "#butsystem_xl@SYSTEM",
			"#butsystem_y@SYSTEM", "#butsystem_yl@SYSTEM", "#conall_x@SYSTEM", "#conall_xl@SYSTEM", "#conall_y@SYSTEM",
			"#conall_yl@SYSTEM", "#conarea_all_x@SYSTEM", "#conarea_all_xl@SYSTEM", "#conarea_all_y@SYSTEM",
			"#conarea_all_yl@SYSTEM", "#conarea_x@SYSTEM", "#conarea_xl@SYSTEM", "#conarea_y@SYSTEM",
			"#conarea_yl@SYSTEM", "#confont_isproportional@SYSTEM", "#confont_name$@SYSTEM", "#confont_xl@SYSTEM",
			"#confont_yl@SYSTEM", "#confont_ystep@SYSTEM", "#console_file_off$@SYSTEM", "#console_file_on$@SYSTEM",
			"#console_file_push$@SYSTEM", "#fullmode_alfa@SYSTEM", "#nameall_x@SYSTEM", "#nameall_xl@SYSTEM",
			"#nameall_y@SYSTEM", "#nameall_yl@SYSTEM", "#namearea_x@SYSTEM", "#namearea_xl@SYSTEM",
			"#namearea_y@SYSTEM", "#namearea_yl@SYSTEM", "#namefont_isproportional@SYSTEM", "#namefont_name$@SYSTEM",
			"#namefont_xl@SYSTEM", "#namefont_yl@SYSTEM", "#num_auto_parts@SYSTEM", "#num_skip_parts@SYSTEM",
			"#setumei_file$@SYSTEM", "#setumei_x@SYSTEM", "#setumei_y@SYSTEM", "#skip_spr@SYSTEM", "#skipmode@SYSTEM",
			"#time_auto_parts@SYSTEM", "#time_skip_parts@SYSTEM", "#wink_file$@SYSTEM", "#wink_file2$@SYSTEM",
			"#wink_file3$@SYSTEM", "#wink_koma@SYSTEM", "#wink_koma2@SYSTEM", "#wink_koma3@SYSTEM",
			"#wink_speed@SYSTEM", "#wink_speed2@SYSTEM", "#wink_speed3@SYSTEM", "#wink_usehalf@SYSTEM",
			"#wink_usehalf2@SYSTEM", "#wink_usehalf3@SYSTEM", "#winkpos_off_x@SYSTEM", "#winkpos_off_y@SYSTEM",
			"#winkpos_x@SYSTEM", "#winkpos_y@SYSTEM", "#winkpos2_x@SYSTEM", "#winkpos2_y@SYSTEM", "#winkpos3_x@SYSTEM",
			"#winkpos3_y@SYSTEM", "@M_my_score@GLOBAL", "@M_my_pre_te#@GLOBAL", "@M_my_naki_flag#@GLOBAL",
			"@M_my_naki_flag2#@GLOBAL", "@M_my_sute#@GLOBAL", "@M_my_is_reach@GLOBAL", "@M_my_reach_cyokugo@GLOBAL",
			"@M_my_kaze@GLOBAL", "@M_my_luck@GLOBAL", "@M_my_unluck@GLOBAL", "@M_tatioya@GLOBAL", "@M_ba_kaze@GLOBAL",
			"@M_ba_mawari@GLOBAL", "@M_kan_kazu@GLOBAL", "@M_ba_100ten@GLOBAL", "@M_ba_1000ten@GLOBAL",
			"@M_dora#@GLOBAL", "@M_dora_ura#@GLOBAL", "@M_maj_mode@GLOBAL", "@M_pi_tumo_nokori@GLOBAL",
			"@M_reach_sel_stat#@GLOBAL", "@M_com_end#@GLOBAL", "@M_com_end2#@GLOBAL", "@M_com_endnaki#@GLOBAL",
			"@M_com_endnaki2#@GLOBAL", "@M_com_do_reach#@GLOBAL", "@M_com_do_naki#@GLOBAL", "@M_com_te_susunda#@GLOBAL",
			"@M_com_is_tenpai#@GLOBAL", "@M_com_yuusen@GLOBAL", "@M_com_sute#@GLOBAL", "@M_com_score#@GLOBAL",
			"@M_com_kaze#@GLOBAL", "@M_com_pre_te#@GLOBAL", "@M_com_naki_flag#@GLOBAL", "@M_com_naki_flag2#@GLOBAL",
			"@M_com_is_reach#@GLOBAL", "@M_com_reach_cyokugo#@GLOBAL", "@com_id#@GLOBAL", "@com_lvl#@GLOBAL",
			"@com_tuyosa#@GLOBAL", "@com_luck#@GLOBAL", "@com_unluck#@GLOBAL", "@ply_luck_seed#@GLOBAL",
			"@ply_unluck_seed#@GLOBAL", "@O_is_tumo_not_wait@GLOBAL", "@O_is_quit@GLOBAL", "@O_winner@GLOBAL",
			"@O_is_tenho@GLOBAL", "@O_is_haitei@GLOBAL", "@O_is_tumo@GLOBAL", "@O_is_kan_cyokugo@GLOBAL",
			"@O_is_kandora_akero@GLOBAL", "@M_last_sute@GLOBAL", "@M_last_sute_pl@GLOBAL", "@M_yaku_no#@GLOBAL",
			"@M_yaku_han#@GLOBAL", "@M_yaku_fu_total@GLOBAL", "@M_yaku_han_total@GLOBAL", "@M_yaku_man_total@GLOBAL",
			"@M_yaku_score@GLOBAL", "@M_yaku_score_ko@GLOBAL", "@M_yaku_score_oya@GLOBAL", "@M_yaku_is_tumo@GLOBAL",
			"@M_yaku_is_reach@GLOBAL", "@M_yaku_my_kaze@GLOBAL", "#kuitan@CONFIG", "#tumopin@CONFIG", "#uradora@CONFIG",
			"#kandora@CONFIG", "#akau@CONFIG", "#dobon@CONFIG", "#tonnan@CONFIG", "#syairi@CONFIG", "#oyanagare@CONFIG",
			"@ConEn@GLOBAL", "@InSuv@GLOBAL"

		};

		public static IReadOnlyDictionary<uint, string> KnownVariableNamesByHash = new Dictionary<uint, string> { };

		static Data() {
			{
				var dict = (Dictionary<uint, string>)KnownSyscallNamesByHash;
				foreach(string name in KnownSyscallNames) {
					string syscall = '$' + name + SyscallSuffix;
					uint hash = Crc.Hash32(syscall);
					dict[hash] = name;
					Debug.Assert(SyscallHashes.Contains(hash));
				}
			}
			{
				var dict = (Dictionary<uint, string>)KnownFunctionNamesByHash;
				foreach(string group in KnownGroupNames) {
					string name = "$main@" + group;
					uint hash = Crc.Hash32(name);
					dict[hash] = name;
				}
			}
			{
				var dict = (Dictionary<uint, string>)KnownVariableNamesByHash;
				foreach(string name in KnownVariableNames) {
					uint hash = Crc.Hash32(name);
					dict[hash] = name;
				}
			}
		}
	}
}
