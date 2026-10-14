using System;
using AcpCommonResources;
using AcpUtility;

namespace AcpASKLib
{
	// Token: 0x0200001F RID: 31
	public static class iBtnStatusCode
	{
		// Token: 0x060000B1 RID: 177 RVA: 0x00011040 File Offset: 0x0000F240
		public static string GetErrorMsg(uint hStatus)
		{
			switch (0)
			{
			case 0:
				goto IL_7C;
			}
			int num;
			string result;
			short num2;
			for (;;)
			{
				IL_0A:
				switch (num)
				{
				case 0:
					goto IL_181;
				case 1:
					return result;
				case 2:
					goto IL_14B;
				case 3:
					num2 = (short)735379476;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 4:
					return result;
				case 5:
					goto IL_1D0;
				case 6:
					return result;
				case 7:
					return result;
				case 8:
					goto IL_113;
				case 9:
					return result;
				case 10:
					switch (hStatus)
					{
					case 2684387329U:
						result = global::AcpCommonResources.AcpResources.Account_Locked_Out;
						num2 = (short)134021125;
						num = (int)((global::System.IntPtr)num2);
						continue;
					case 2684387330U:
						result = global::AcpCommonResources.AcpResources.Advance_Key_Old + global::System.Environment.NewLine;
						num2 = (short)1827078166;
						num = (int)((global::System.IntPtr)num2);
						continue;
					case 2684387331U:
						result = (global::AcpCommonResources.AcpResources.No_Key_Loaded + global::System.Environment.NewLine).AcpStringFormat(global::System.Array.Empty<object>());
						num2 = (short)194183168;
						num = (int)((global::System.IntPtr)num2);
						continue;
					case 2684387332U:
						result = global::AcpCommonResources.AcpResources.Incorrect_Password + global::System.Environment.NewLine;
						num2 = (short)1850015755;
						num = (int)((global::System.IntPtr)num2);
						continue;
					case 2684387333U:
						result = (global::AcpCommonResources.AcpResources.Not_Updated_Master_key + global::System.Environment.NewLine).AcpStringFormat(global::System.Array.Empty<object>());
						num2 = (short)1659764752;
						num = (int)((global::System.IntPtr)num2);
						continue;
					case 2684387334U:
						result = (global::AcpCommonResources.AcpResources.Load_Master_Key + global::System.Environment.NewLine).AcpStringFormat(global::System.Array.Empty<object>());
						num2 = (short)352649239;
						num = (int)((global::System.IntPtr)num2);
						continue;
					case 2684387335U:
						result = (global::AcpCommonResources.AcpResources.Access_Password + global::System.Environment.NewLine).AcpStringFormat(global::System.Array.Empty<object>());
						num2 = (short)455933954;
						num = (int)((global::System.IntPtr)num2);
						continue;
					case 2684387336U:
						result = global::AcpCommonResources.AcpResources.Cannot_Read_Key;
						num2 = (short)1472856089;
						num = (int)((global::System.IntPtr)num2);
						continue;
					case 2684387337U:
						goto IL_2F2;
					case 2684387338U:
						return result;
					case 2684387339U:
						result = global::AcpCommonResources.AcpResources.New_Version_iBtn;
						num2 = (short)1061814284;
						num = (int)((global::System.IntPtr)num2);
						continue;
					default:
						num2 = (short)685309978;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					break;
				case 11:
					return result;
				case 12:
					return result;
				case 13:
					return result;
				case 14:
					switch (hStatus)
					{
					case 3758129153U:
						result = (global::AcpCommonResources.AcpResources.iButton_Absent + global::System.Environment.NewLine).AcpStringFormat(global::System.Array.Empty<object>());
						num2 = (short)3080199;
						num = (int)((global::System.IntPtr)num2);
						continue;
					case 3758129154U:
						result = (global::AcpCommonResources.AcpResources.Internal_Error_Msg + global::System.Environment.NewLine).AcpStringFormat(global::System.Array.Empty<object>());
						num2 = (short)2127429636;
						num = (int)((global::System.IntPtr)num2);
						continue;
					case 3758129155U:
						result = global::AcpCommonResources.AcpResources.SN_No_Not_Match + global::System.Environment.NewLine;
						num2 = (short)946667544;
						num = (int)((global::System.IntPtr)num2);
						continue;
					case 3758129156U:
					{
						result = (global::AcpCommonResources.AcpResources.CRC_Not_Match + global::System.Environment.NewLine).AcpStringFormat(global::System.Array.Empty<object>());
						num2 = (short)293470208;
						short num3 = num2;
						num2 = (short)1084096531;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					case 3758129157U:
						result = global::AcpCommonResources.AcpResources.Advance_Key_Replaced + global::System.Environment.NewLine;
						num2 = (short)1656881165;
						num = (int)((global::System.IntPtr)num2);
						continue;
					case 3758129158U:
						result = global::AcpCommonResources.AcpResources.Advance_Sys_key.AcpStringFormat(global::System.Array.Empty<object>());
						num2 = (short)1282277397;
						num = (int)((global::System.IntPtr)num2);
						continue;
					case 3758129159U:
						return result;
					case 3758129160U:
						result = global::AcpCommonResources.AcpResources.Advance_Key_Invalid.AcpStringFormat(global::System.Array.Empty<object>());
						num2 = (short)1039532040;
						num = (int)((global::System.IntPtr)num2);
						continue;
					case 3758129161U:
						result = global::AcpCommonResources.AcpResources.iButton_Damaged.AcpStringFormat(global::System.Array.Empty<object>());
						num2 = (short)1974796289;
						num = (int)((global::System.IntPtr)num2);
						continue;
					case 3758129162U:
						result = global::AcpCommonResources.AcpResources.Out_Of_Memory.AcpStringFormat(global::System.Array.Empty<object>());
						num2 = (short)1252720655;
						num = (int)((global::System.IntPtr)num2);
						continue;
					case 3758129163U:
						result = global::AcpCommonResources.AcpResources.Access_Denied.AcpStringFormat(global::System.Array.Empty<object>());
						num2 = (short)1711865874;
						num = (int)((global::System.IntPtr)num2);
						continue;
					case 3758129164U:
						result = global::AcpCommonResources.AcpResources.iButton_Expired.AcpStringFormat(global::System.Array.Empty<object>());
						num2 = (short)70123529;
						num = (int)((global::System.IntPtr)num2);
						continue;
					case 3758129165U:
						goto IL_2F2;
					case 3758129166U:
						result = global::AcpCommonResources.AcpResources.HighWaterMark_Security_Violation.AcpStringFormat(global::System.Array.Empty<object>());
						num2 = (short)1246756881;
						num = (int)((global::System.IntPtr)num2);
						continue;
					default:
						num2 = (short)904986627;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					break;
				case 15:
					return result;
				case 16:
					return result;
				case 17:
					goto IL_22B;
				case 18:
					goto IL_1AE;
				case 19:
					return result;
				case 20:
					goto IL_2F2;
				case 21:
					goto IL_1FE;
				case 22:
					return result;
				case 23:
					goto IL_262;
				case 24:
					return result;
				case 25:
					return result;
				case 26:
					num2 = (short)119013390;
					num = (int)((global::System.IntPtr)num2);
					continue;
				}
				goto IL_7C;
				IL_2F2:
				result = global::AcpCommonResources.AcpResources.Undefined_Error_Status.AcpStringFormat(new object[]
				{
					hStatus.ToString() + global::System.Environment.NewLine
				});
				num2 = (short)76477024;
				short num4 = num2;
				num2 = (short)1934357088;
				switch ((num4 == num2) ? 1 : 0)
				{
				case 0:
				case 2:
					break;
				default:
					num2 = (short)909443072;
					if (num2 != 0)
					{
					}
					num2 = (short)1513553926;
					num = (int)((global::System.IntPtr)num2);
					break;
				}
			}
			IL_113:
			IL_14B:
			IL_181:
			IL_1AE:
			IL_1D0:
			IL_1FE:
			IL_22B:
			return result;
			IL_262:
			num2 = (short)1134166017;
			if (num2 != 0)
			{
			}
			return result;
			IL_7C:
			result = null;
			num2 = (short)1966276618;
			num = (int)((global::System.IntPtr)num2);
			goto IL_0A;
		}

		// Token: 0x04000115 RID: 277
		public const uint S_OK = 0U;

		// Token: 0x04000116 RID: 278
		public const uint E_INFO_BASE = 1610645504U;

		// Token: 0x04000117 RID: 279
		public const uint E_SILENT_MODE = 1610645505U;

		// Token: 0x04000118 RID: 280
		public const uint E_READ_ASK_SUCCESSFUL = 1610645506U;

		// Token: 0x04000119 RID: 281
		public const uint E_READ_ASK_FAILED = 1610645507U;

		// Token: 0x0400011A RID: 282
		public const uint E_WRITE_ASK_SUCCESSFUL = 1610645508U;

		// Token: 0x0400011B RID: 283
		public const uint E_WRITE_ASK_FAILED = 1610645509U;

		// Token: 0x0400011C RID: 284
		public const uint E_SET_PASSWORD_CANCELLED = 1610645510U;

		// Token: 0x0400011D RID: 285
		public const uint E_WARNING_BASE = 2684387328U;

		// Token: 0x0400011E RID: 286
		public const uint E_ACCESS_LOCKEDOUT = 2684387329U;

		// Token: 0x0400011F RID: 287
		public const uint E_NOT_SUPPORT_PASSWORD = 2684387330U;

		// Token: 0x04000120 RID: 288
		public const uint E_NO_KEY_LOADED = 2684387331U;

		// Token: 0x04000121 RID: 289
		public const uint E_UP_PSWD_RETRY_LIMITATION = 2684387332U;

		// Token: 0x04000122 RID: 290
		public const uint E_UPGRADE_WITHOUT_MASTER_KEY = 2684387333U;

		// Token: 0x04000123 RID: 291
		public const uint E_NO_MASTER_KEY_LOADED = 2684387334U;

		// Token: 0x04000124 RID: 292
		public const uint E_ABORT_ACCESS_PASSWORD = 2684387335U;

		// Token: 0x04000125 RID: 293
		public const uint E_READ_IMCOMPATIBLE_VERSION_IBTN = 2684387336U;

		// Token: 0x04000126 RID: 294
		public const uint E_FILE_NOT_EXIST = 2684387337U;

		// Token: 0x04000127 RID: 295
		public const uint E_WRITE_OLD_VERSION_IBTN = 2684387338U;

		// Token: 0x04000128 RID: 296
		public const uint E_WRITE_NEW_VERSION_IBTN = 2684387339U;

		// Token: 0x04000129 RID: 297
		public const uint E_WRITE_IBTN_CANCELLED = 2684387340U;

		// Token: 0x0400012A RID: 298
		public const uint E_MESSAGE_BOX_SHOWN = 2684387341U;

		// Token: 0x0400012B RID: 299
		public const uint E_NOT_SUPPORT_SW_EXPIRATION = 2684387342U;

		// Token: 0x0400012C RID: 300
		public const uint E_ERROR_BASE = 3758129152U;

		// Token: 0x0400012D RID: 301
		public const uint E_IBTN_ABSENT = 3758129153U;

		// Token: 0x0400012E RID: 302
		public const uint E_INTERNAL_PROGRAM_ERROR = 3758129154U;

		// Token: 0x0400012F RID: 303
		public const uint E_SN_NOT_MATCH = 3758129155U;

		// Token: 0x04000130 RID: 304
		public const uint E_CRC_NOT_MATCH = 3758129156U;

		// Token: 0x04000131 RID: 305
		public const uint E_IBTN_BE_REPLACED = 3758129157U;

		// Token: 0x04000132 RID: 306
		public const uint E_NO_KEY_IN_ASK = 3758129158U;

		// Token: 0x04000133 RID: 307
		public const uint E_ERROR_MESSAGE_DUMMY = 3758129159U;

		// Token: 0x04000134 RID: 308
		public const uint E_NOT_VALID_IBTN_KEY = 3758129160U;

		// Token: 0x04000135 RID: 309
		public const uint E_FILE_IS_DAMAGED = 3758129161U;

		// Token: 0x04000136 RID: 310
		public const uint E_OUTOFMEMORY = 3758129162U;

		// Token: 0x04000137 RID: 311
		public const uint E_ACCESSDENIED = 3758129163U;

		// Token: 0x04000138 RID: 312
		public const uint E_KEY_EXPIRED = 3758129164U;

		// Token: 0x04000139 RID: 313
		public const uint E_READ_SOFTWARE_KEY_FAILED = 3758129165U;

		// Token: 0x0400013A RID: 314
		public const uint E_HIGH_WATER_MARK_VIOLATION = 3758129166U;
	}
}
