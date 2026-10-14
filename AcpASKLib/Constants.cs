using System;

namespace AcpASKLib
{
	// Token: 0x02000020 RID: 32
	public static class Constants
	{
		// Token: 0x17000033 RID: 51
		// (get) Token: 0x060000B2 RID: 178 RVA: 0x00011680 File Offset: 0x0000F880
		internal static global::System.DateTime ReferenceDate
		{
			get
			{
				short num = (short)199500916;
				short num2 = num;
				num = (short)172696692;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1237516288;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)2035941377;
				if (num != 0)
				{
				}
				num = (short)1022754816;
				if (num != 0)
				{
				}
				return new global::System.DateTime(1970, 1, 1);
			}
		}

		// Token: 0x060000B3 RID: 179 RVA: 0x00011734 File Offset: 0x0000F934
		// Note: this type is marked as 'beforefieldinit'.
		static Constants()
		{
			int a_ = 1;
			short num = (short)64627417;
			short num2 = num;
			num = (short)1368924889;
			switch (num2 == num)
			{
			default:
			{
				num = (short)1760165888;
				short num3 = num;
				break;
			}
			case true:
				break;
			}
			num = (short)1722613761;
			if (num != 0)
			{
			}
			num = (short)1846738944;
			if (num != 0)
			{
			}
			global::AcpASKLib.Constants.COMMON_APPLICATION_PATH = global::System.Environment.GetFolderPath(global::System.Environment.SpecialFolder.CommonApplicationData);
			global::AcpASKLib.Constants.ACCESS_LIST_PATH_AND_NAME = global::AcpASKLib.Constants.COMMON_APPLICATION_PATH + global::AcpASKLib.SystemKeyLoadedEventArgs.b("ɝⵟൡၣ॥ᩧթk཭Ɐⅱ൳յ㍷όջ㽽풇쮉\uda95낝\ud89f쾡좣", a_);
			global::AcpASKLib.Constants.MACK_ACCESS_LIST_PATH_AND_NAME = global::AcpASKLib.Constants.COMMON_APPLICATION_PATH + global::AcpASKLib.SystemKeyLoadedEventArgs.b("ɝⵟൡၣ॥ᩧթk཭Ɐⅱ൳յ㍷όջ㽽풇쮉ﲋ톏킛펟횡誣\udea5얧용", a_);
			global::AcpASKLib.Constants.MAX_LENGTH = 64;
		}

		// Token: 0x0400013B RID: 315
		public const int FIELD_CODE_ARRAY_SZ = 24;

		// Token: 0x0400013C RID: 316
		public const int LEGACY_FIELD_CODE_ARRAY_SZ = 12;

		// Token: 0x0400013D RID: 317
		public const int VERSION_R01_00_00 = 1;

		// Token: 0x0400013E RID: 318
		public const int VERSION_R01_01_00 = 1;

		// Token: 0x0400013F RID: 319
		public const int VERSION_R01_01_01 = 2;

		// Token: 0x04000140 RID: 320
		public const int VERSION_R01_01_02 = 3;

		// Token: 0x04000141 RID: 321
		public const int VERSION_SUPPORT_PASSWORD = 3;

		// Token: 0x04000142 RID: 322
		public const int VERSION_R01_01_03 = 4;

		// Token: 0x04000143 RID: 323
		public const int VERSION_R01_01_04 = 5;

		// Token: 0x04000144 RID: 324
		public const int CURRENT_VERSION = 5;

		// Token: 0x04000145 RID: 325
		public const int FILE_ID_POS = 8;

		// Token: 0x04000146 RID: 326
		public const int VERSION_POS = 9;

		// Token: 0x04000147 RID: 327
		public const int COUNTER_1_POS = 10;

		// Token: 0x04000148 RID: 328
		public const int SYSTME_TYPE_POS = 10;

		// Token: 0x04000149 RID: 329
		public const int COUNTER_2_POS = 11;

		// Token: 0x0400014A RID: 330
		public const int MASK_FILE_ID = 0;

		// Token: 0x0400014B RID: 331
		public const int KEYS_FILE_ID = 1;

		// Token: 0x0400014C RID: 332
		public const int DATA_FILE_ID = 2;

		// Token: 0x0400014D RID: 333
		public const int MSTR_FILE_ID = 3;

		// Token: 0x0400014E RID: 334
		public const int OTAP_FILE_ID = 4;

		// Token: 0x0400014F RID: 335
		public const int MISR_FILE_ID = 5;

		// Token: 0x04000150 RID: 336
		public const int SERIAL_NUM_SZ = 8;

		// Token: 0x04000151 RID: 337
		public const int KEYS_FILE_HEADER_SZ = 11;

		// Token: 0x04000152 RID: 338
		public const int DATA_FILE_HEADER_SZ = 11;

		// Token: 0x04000153 RID: 339
		public const int MASK_FILE_HEADER_SZ = 10;

		// Token: 0x04000154 RID: 340
		public const int OTAP_FILE_HEADER_SZ = 12;

		// Token: 0x04000155 RID: 341
		public const int IBTN_PAGE_SIZE = 28;

		// Token: 0x04000156 RID: 342
		public const int BTN_PASSWORD_MAX_LENGTH = 10;

		// Token: 0x04000157 RID: 343
		public const int PASSWORD_RETRY_LIMITATION = 3;

		// Token: 0x04000158 RID: 344
		public const string SSYSKEYFILESSEARCHKEY = "*.key";

		// Token: 0x04000159 RID: 345
		public static readonly string COMMON_APPLICATION_PATH;

		// Token: 0x0400015A RID: 346
		public static readonly string ACCESS_LIST_PATH_AND_NAME;

		// Token: 0x0400015B RID: 347
		public static readonly string MACK_ACCESS_LIST_PATH_AND_NAME;

		// Token: 0x0400015C RID: 348
		public static readonly int MAX_LENGTH;
	}
}
