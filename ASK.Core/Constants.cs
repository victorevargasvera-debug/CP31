using System;

namespace ASK.Core
{
	// Token: 0x02000015 RID: 21
	public static class Constants
	{
		// Token: 0x17000032 RID: 50
		// (get) Token: 0x060000B4 RID: 180 RVA: 0x000124E8 File Offset: 0x000106E8
		public static global::System.DateTime ReferenceDate
		{
			get
			{
				short num = (short)871251446;
				short num2 = num;
				num = (short)1916681718;
				switch (num2 == num)
				{
				}
				num = (short)820838400;
				short num3 = num;
				num = (short)2143158272;
				if (num != 0)
				{
				}
				num = (short)1843986433;
				if (num != 0)
				{
				}
				return new global::System.DateTime(1970, 1, 1);
			}
		}

		// Token: 0x060000B5 RID: 181 RVA: 0x000125A0 File Offset: 0x000107A0
		// Note: this type is marked as 'beforefieldinit'.
		static Constants()
		{
			int a_ = 17;
			short num = (short)157786971;
			short num2 = num;
			num = (short)343515995;
			switch (num2 == num)
			{
			}
			num = (short)1169817600;
			short num3 = num;
			num = (short)1554448385;
			if (num != 0)
			{
			}
			num = (short)1653866496;
			if (num != 0)
			{
			}
			global::ASK.Core.Constants.COMMON_APPLICATION_PATH = global::System.Environment.GetFolderPath(global::System.Environment.SpecialFolder.CommonApplicationData);
			global::ASK.Core.Constants.ACCESS_LIST_PATH_AND_NAME = global::ASK.Core.Constants.COMMON_APPLICATION_PATH + global::ASK.Core.StatusMsg.b("ᅌɎ㹐❒㩔╖㙘㝚㱜͞㉠ᩢᙤⱦ౨ቪⱬ୮ᱰᩲ᭴⭶㡸᡺Ṽ᩾즄愈ﾊꎌﲐﾒ", a_);
			global::ASK.Core.Constants.MACK_ACCESS_LIST_PATH_AND_NAME = global::ASK.Core.Constants.COMMON_APPLICATION_PATH + global::ASK.Core.StatusMsg.b("ᅌɎ㹐❒㩔╖㙘㝚㱜͞㉠ᩢᙤⱦ౨ቪⱬ୮ᱰᩲ᭴⭶㡸୺ռ㹾愈잊ﲎ붒殺", a_);
			global::ASK.Core.Constants.MAX_LENGTH = 64;
		}

		// Token: 0x04000039 RID: 57
		public const int FIELD_CODE_ARRAY_SZ = 24;

		// Token: 0x0400003A RID: 58
		public const int LEGACY_FIELD_CODE_ARRAY_SZ = 12;

		// Token: 0x0400003B RID: 59
		public const int VERSION_R01_00_00 = 1;

		// Token: 0x0400003C RID: 60
		public const int VERSION_R01_01_00 = 1;

		// Token: 0x0400003D RID: 61
		public const int VERSION_R01_01_01 = 2;

		// Token: 0x0400003E RID: 62
		public const int VERSION_R01_01_02 = 3;

		// Token: 0x0400003F RID: 63
		public const int VERSION_SUPPORT_PASSWORD = 3;

		// Token: 0x04000040 RID: 64
		public const int VERSION_R01_01_03 = 4;

		// Token: 0x04000041 RID: 65
		public const int VERSION_R01_01_04 = 5;

		// Token: 0x04000042 RID: 66
		public const int CURRENT_VERSION = 5;

		// Token: 0x04000043 RID: 67
		public const int FILE_ID_POS = 8;

		// Token: 0x04000044 RID: 68
		public const int VERSION_POS = 9;

		// Token: 0x04000045 RID: 69
		public const int COUNTER_1_POS = 10;

		// Token: 0x04000046 RID: 70
		public const int SYSTME_TYPE_POS = 10;

		// Token: 0x04000047 RID: 71
		public const int COUNTER_2_POS = 11;

		// Token: 0x04000048 RID: 72
		public const int MASK_FILE_ID = 0;

		// Token: 0x04000049 RID: 73
		public const int KEYS_FILE_ID = 1;

		// Token: 0x0400004A RID: 74
		public const int DATA_FILE_ID = 2;

		// Token: 0x0400004B RID: 75
		public const int MSTR_FILE_ID = 3;

		// Token: 0x0400004C RID: 76
		public const int OTAP_FILE_ID = 4;

		// Token: 0x0400004D RID: 77
		public const int MISR_FILE_ID = 5;

		// Token: 0x0400004E RID: 78
		public const int SERIAL_NUM_SZ = 8;

		// Token: 0x0400004F RID: 79
		public const int KEYS_FILE_HEADER_SZ = 11;

		// Token: 0x04000050 RID: 80
		public const int DATA_FILE_HEADER_SZ = 11;

		// Token: 0x04000051 RID: 81
		public const int MASK_FILE_HEADER_SZ = 10;

		// Token: 0x04000052 RID: 82
		public const int OTAP_FILE_HEADER_SZ = 12;

		// Token: 0x04000053 RID: 83
		public const int IBTN_PAGE_SIZE = 28;

		// Token: 0x04000054 RID: 84
		public const int BTN_PASSWORD_MAX_LENGTH = 10;

		// Token: 0x04000055 RID: 85
		public const int PASSWORD_RETRY_LIMITATION = 3;

		// Token: 0x04000056 RID: 86
		public const string SSYSKEYFILESSEARCHKEY = "*.key";

		// Token: 0x04000057 RID: 87
		public static readonly string COMMON_APPLICATION_PATH;

		// Token: 0x04000058 RID: 88
		public static readonly string ACCESS_LIST_PATH_AND_NAME;

		// Token: 0x04000059 RID: 89
		public static readonly string MACK_ACCESS_LIST_PATH_AND_NAME;

		// Token: 0x0400005A RID: 90
		public static readonly int MAX_LENGTH;
	}
}
