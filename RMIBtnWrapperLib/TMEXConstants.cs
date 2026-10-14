using System;

namespace RMIBtnWrapperLib
{
	// Token: 0x02000018 RID: 24
	public class TMEXConstants
	{
		// Token: 0x040000B6 RID: 182
		public const int FEATURE_OVERDRIVE = 0;

		// Token: 0x040000B7 RID: 183
		public const int FEATURE_POWER = 1;

		// Token: 0x040000B8 RID: 184
		public const int FEATURE_PROGRAM = 2;

		// Token: 0x040000B9 RID: 185
		public const int FEATURE_FLEX = 3;

		// Token: 0x040000BA RID: 186
		public const int FEATURE_BREAK = 4;

		// Token: 0x040000BB RID: 187
		public const short TIME_NORMAL = 0;

		// Token: 0x040000BC RID: 188
		public const short TIME_OVERDRV = 1;

		// Token: 0x040000BD RID: 189
		public const short TIME_RELAXED = 2;

		// Token: 0x040000BE RID: 190
		public const int SESSION_INFINITE = 1;

		// Token: 0x040000BF RID: 191
		public const int SESSION_RSRC_RELEASE = 2;

		// Token: 0x040000C0 RID: 192
		public const int INVALID_SESSIONHANDLE = 0;

		// Token: 0x040000C1 RID: 193
		public const int INVALID_FILEHANDLE = -1;

		// Token: 0x040000C2 RID: 194
		public const int SERIAL_NUM_SZ = 8;

		// Token: 0x040000C3 RID: 195
		public const int XNO_DEVICE = -1;

		// Token: 0x040000C4 RID: 196
		public const int XWRONG_TYPE = -2;

		// Token: 0x040000C5 RID: 197
		public const int XFILE_READ_ERR = -3;

		// Token: 0x040000C6 RID: 198
		public const int XBUFFER_TOO_SMALL = -4;

		// Token: 0x040000C7 RID: 199
		public const int XHANDLE_NOT_AVAIL = -5;

		// Token: 0x040000C8 RID: 200
		public const int XFILE_NOT_FOUND = -6;

		// Token: 0x040000C9 RID: 201
		public const int XREPEAT_FILE = -7;

		// Token: 0x040000CA RID: 202
		public const int XHANDLE_NOT_USED = -8;

		// Token: 0x040000CB RID: 203
		public const int XFILE_WRITE_ONLY = -9;

		// Token: 0x040000CC RID: 204
		public const int XOUT_OF_SPACE = -10;

		// Token: 0x040000CD RID: 205
		public const int XFILE_WRITE_ERR = -11;

		// Token: 0x040000CE RID: 206
		public const int XFILE_READ_ONLY = -12;

		// Token: 0x040000CF RID: 207
		public const int XFUNC_NOT_SUP = -13;

		// Token: 0x040000D0 RID: 208
		public const int XBAD_FILENAME = -14;

		// Token: 0x040000D1 RID: 209
		public const int XCANT_DEL_READ_ONLY = -15;

		// Token: 0x040000D2 RID: 210
		public const int XHANDLE_NOT_EXIST = -16;

		// Token: 0x040000D3 RID: 211
		public const int XONE_WIRE_PORT_ERROR = -17;

		// Token: 0x040000D4 RID: 212
		public const int XINVALID_DIRECTORY = -18;

		// Token: 0x040000D5 RID: 213
		public const int XDIRECTORY_NOT_EMPTY = -19;

		// Token: 0x040000D6 RID: 214
		public const int XUNABLE_TO_CREATE_DIR = -20;

		// Token: 0x040000D7 RID: 215
		public const int XNO_PROGRAM_JOB = -21;

		// Token: 0x040000D8 RID: 216
		public const int XPROGRAM_WRITE_PROTECT = -22;

		// Token: 0x040000D9 RID: 217
		public const int XNON_PROGRAM_PARTS = -23;

		// Token: 0x040000DA RID: 218
		public const int XADDFILE_TERMINATED = -24;

		// Token: 0x040000DB RID: 219
		public const int XTIMEOUT = -25;

		// Token: 0x040000DC RID: 220
		public const int XINVALID_ARGUMENT = -26;

		// Token: 0x040000DD RID: 221
		public const int XBAD_ACK = -27;

		// Token: 0x040000DE RID: 222
		public const int XINVALID_SESSION = -200;

		// Token: 0x040000DF RID: 223
		public const int XNO_BASDRV_FOUND = -201;

		// Token: 0x040000E0 RID: 224
		public const int BPORT_NOT_INITIALIZED = -1;

		// Token: 0x040000E1 RID: 225
		public const int BPORT_NOT_EXIST = -2;

		// Token: 0x040000E2 RID: 226
		public const int BNO_SUCH_FUNCTION = -3;

		// Token: 0x040000E3 RID: 227
		public const int TERROR_READ_WRITE = -4;

		// Token: 0x040000E4 RID: 228
		public const int TBUFFER_TOO_SMALL = -5;

		// Token: 0x040000E5 RID: 229
		public const int TDEVICE_TOO_SMALL = -6;

		// Token: 0x040000E6 RID: 230
		public const int TNO_DEVICE = -7;

		// Token: 0x040000E7 RID: 231
		public const int TBLOCK_TOO_BIG = -8;

		// Token: 0x040000E8 RID: 232
		public const int TWRONG_TYPE = -9;

		// Token: 0x040000E9 RID: 233
		public const int TPAGE_REDIRECTED = -10;

		// Token: 0x040000EA RID: 234
		public const int TPROGRAM_NOT_POSSIBLE = -11;

		// Token: 0x040000EB RID: 235
		public const int BCOM_FAILURE = -12;

		// Token: 0x040000EC RID: 236
		public const int BCOM_EVENT = -13;

		// Token: 0x040000ED RID: 237
		public const int GENERAL_FAIL = -2;

		// Token: 0x040000EE RID: 238
		public const int BAD_ARGUMENT = 50;

		// Token: 0x040000EF RID: 239
		public const int NO_DRIVERS = 51;

		// Token: 0x040000F0 RID: 240
		public const int KEY_ABORT = 52;

		// Token: 0x040000F1 RID: 241
		public const int OUT_MEMORY = 53;

		// Token: 0x040000F2 RID: 242
		public const int NORMAL_EXIT = 0;

		// Token: 0x040000F3 RID: 243
		public const int TRUE = 1;

		// Token: 0x040000F4 RID: 244
		public const int FALSE = 0;

		// Token: 0x040000F5 RID: 245
		public const int DIR_READ = 1;

		// Token: 0x040000F6 RID: 246
		public const int DIR_SET = 0;

		// Token: 0x040000F7 RID: 247
		public const int DIR_REMOVE = 1;

		// Token: 0x040000F8 RID: 248
		public const int DIR_MAKE = 0;

		// Token: 0x040000F9 RID: 249
		public const int LEVEL_NORMAL = 0;

		// Token: 0x040000FA RID: 250
		public const int LEVEL_STRONG_PULLUP = 1;

		// Token: 0x040000FB RID: 251
		public const int LEVEL_BREAK = 2;

		// Token: 0x040000FC RID: 252
		public const int LEVEL_PROGRAM = 3;

		// Token: 0x040000FD RID: 253
		public const int PRIMED_NONE = 0;

		// Token: 0x040000FE RID: 254
		public const int PRIMED_BIT = 1;

		// Token: 0x040000FF RID: 255
		public const int PRIMED_BYTE = 2;

		// Token: 0x04000100 RID: 256
		public const int LEVEL_READ = 1;

		// Token: 0x04000101 RID: 257
		public const int LEVEL_SET = 0;
	}
}
