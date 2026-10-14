using System;
using AcpUtility;
using Motorola.CommonCPS.ResourceRepository;

namespace ASK.Core
{
	// Token: 0x0200001C RID: 28
	public static class iBtnStatusCode
	{
		// Token: 0x06000135 RID: 309 RVA: 0x000246E0 File Offset: 0x000228E0
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
					return result;
				case 1:
					return result;
				case 2:
					num2 = (short)2110259223;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 3:
					switch (hStatus)
					{
					case 2684387329U:
						result = global::Motorola.CommonCPS.ResourceRepository.Resources.Account_Locked_Out;
						num2 = (short)744030229;
						num = (int)((global::System.IntPtr)num2);
						continue;
					case 2684387330U:
						result = global::Motorola.CommonCPS.ResourceRepository.Resources.Advance_Key_Old + global::System.Environment.NewLine;
						num2 = (short)1695678482;
						num = (int)((global::System.IntPtr)num2);
						continue;
					case 2684387331U:
						result = (global::Motorola.CommonCPS.ResourceRepository.Resources.No_Key_Loaded + global::System.Environment.NewLine).AcpStringFormat(global::System.Array.Empty<object>());
						num2 = (short)1805385743;
						num = (int)((global::System.IntPtr)num2);
						continue;
					case 2684387332U:
						result = global::Motorola.CommonCPS.ResourceRepository.Resources.Incorrect_Password + global::System.Environment.NewLine;
						num2 = (short)2060517393;
						num = (int)((global::System.IntPtr)num2);
						continue;
					case 2684387333U:
						result = (global::Motorola.CommonCPS.ResourceRepository.Resources.Not_Updated_Master_key + global::System.Environment.NewLine).AcpStringFormat(global::System.Array.Empty<object>());
						num2 = (short)1177223178;
						num = (int)((global::System.IntPtr)num2);
						continue;
					case 2684387334U:
						result = (global::Motorola.CommonCPS.ResourceRepository.Resources.Load_Master_Key + global::System.Environment.NewLine).AcpStringFormat(global::System.Array.Empty<object>());
						num2 = (short)136118298;
						num = (int)((global::System.IntPtr)num2);
						continue;
					case 2684387335U:
						result = (global::Motorola.CommonCPS.ResourceRepository.Resources.Access_Password + global::System.Environment.NewLine).AcpStringFormat(global::System.Array.Empty<object>());
						num2 = (short)1345257473;
						num = (int)((global::System.IntPtr)num2);
						continue;
					case 2684387336U:
						result = global::Motorola.CommonCPS.ResourceRepository.Resources.Cannot_Read_Key;
						num2 = (short)243007499;
						num = (int)((global::System.IntPtr)num2);
						continue;
					case 2684387337U:
						goto IL_313;
					case 2684387338U:
						return result;
					case 2684387339U:
						result = global::Motorola.CommonCPS.ResourceRepository.Resources.New_Version_iBtn;
						num2 = (short)1579220996;
						num = (int)((global::System.IntPtr)num2);
						continue;
					default:
						num2 = (short)2072576019;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					break;
				case 4:
					return result;
				case 5:
					return result;
				case 6:
					return result;
				case 7:
					return result;
				case 8:
					goto IL_111;
				case 9:
					return result;
				case 10:
					return result;
				case 11:
					goto IL_5AC;
				case 12:
					return result;
				case 13:
					return result;
				case 14:
					return result;
				case 15:
					return result;
				case 16:
					return result;
				case 17:
					return result;
				case 18:
					return result;
				case 19:
					num2 = (short)722468889;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 20:
					return result;
				case 21:
					return result;
				case 22:
					return result;
				case 23:
					goto IL_313;
				case 24:
					return result;
				case 25:
					switch (hStatus)
					{
					case 3758129153U:
						result = (global::Motorola.CommonCPS.ResourceRepository.Resources.iButton_Absent + global::System.Environment.NewLine).AcpStringFormat(global::System.Array.Empty<object>());
						num2 = (short)1404502036;
						num = (int)((global::System.IntPtr)num2);
						continue;
					case 3758129154U:
						result = (global::Motorola.CommonCPS.ResourceRepository.Resources.Internal_Error_Msg + global::System.Environment.NewLine).AcpStringFormat(global::System.Array.Empty<object>());
						num2 = (short)406323201;
						if (num2 != 0)
						{
						}
						num2 = (short)991625229;
						num = (int)((global::System.IntPtr)num2);
						continue;
					case 3758129155U:
					{
						result = global::Motorola.CommonCPS.ResourceRepository.Resources.SN_No_Not_Match + global::System.Environment.NewLine;
						num2 = (short)2124021760;
						short num3 = num2;
						num2 = (short)1645215758;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					case 3758129156U:
						result = (global::Motorola.CommonCPS.ResourceRepository.Resources.CRC_Not_Match + global::System.Environment.NewLine).AcpStringFormat(global::System.Array.Empty<object>());
						num2 = (short)849477654;
						num = (int)((global::System.IntPtr)num2);
						continue;
					case 3758129157U:
						result = global::Motorola.CommonCPS.ResourceRepository.Resources.Advance_Key_Replaced + global::System.Environment.NewLine;
						num2 = (short)1010827280;
						num = (int)((global::System.IntPtr)num2);
						continue;
					case 3758129158U:
						result = global::Motorola.CommonCPS.ResourceRepository.Resources.Advance_Sys_key.AcpStringFormat(global::System.Array.Empty<object>());
						num2 = (short)1537277958;
						num = (int)((global::System.IntPtr)num2);
						continue;
					case 3758129159U:
						return result;
					case 3758129160U:
						result = global::Motorola.CommonCPS.ResourceRepository.Resources.Advance_Key_Invalid.AcpStringFormat(global::System.Array.Empty<object>());
						num2 = (short)1614151688;
						num = (int)((global::System.IntPtr)num2);
						continue;
					case 3758129161U:
						result = global::Motorola.CommonCPS.ResourceRepository.Resources.iButton_Damaged.AcpStringFormat(global::System.Array.Empty<object>());
						num2 = (short)1836908544;
						num = (int)((global::System.IntPtr)num2);
						continue;
					case 3758129162U:
						result = global::Motorola.CommonCPS.ResourceRepository.Resources.Out_Of_Memory.AcpStringFormat(global::System.Array.Empty<object>());
						num2 = (short)1536884745;
						num = (int)((global::System.IntPtr)num2);
						continue;
					case 3758129163U:
						result = global::Motorola.CommonCPS.ResourceRepository.Resources.Access_Denied.AcpStringFormat(global::System.Array.Empty<object>());
						num2 = (short)225640453;
						num = (int)((global::System.IntPtr)num2);
						continue;
					case 3758129164U:
						result = global::Motorola.CommonCPS.ResourceRepository.Resources.iButton_Expired.AcpStringFormat(global::System.Array.Empty<object>());
						num2 = (short)892207111;
						num = (int)((global::System.IntPtr)num2);
						continue;
					case 3758129165U:
						goto IL_313;
					case 3758129166U:
						result = global::Motorola.CommonCPS.ResourceRepository.Resources.HighWaterMark_Security_Violation.AcpStringFormat(global::System.Array.Empty<object>());
						num2 = (short)1852178444;
						num = (int)((global::System.IntPtr)num2);
						continue;
					default:
						num2 = (short)1066336258;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					break;
				case 26:
					return result;
				}
				goto IL_7C;
				IL_313:
				result = global::Motorola.CommonCPS.ResourceRepository.Resources.Undefined_Error_Status.AcpStringFormat(new object[]
				{
					hStatus.ToString() + global::System.Environment.NewLine
				});
				num2 = (short)1716715544;
				num = (int)((global::System.IntPtr)num2);
			}
			IL_111:
			num2 = (short)310287066;
			short num4 = num2;
			num2 = (short)98867930;
			switch ((num4 == num2) ? 1 : 0)
			{
			case 0:
			case 2:
				IL_5AC:
				break;
			default:
				num2 = (short)745013248;
				if (num2 != 0)
				{
				}
				break;
			}
			return result;
			IL_7C:
			result = null;
			num2 = (short)1252065283;
			num = (int)((global::System.IntPtr)num2);
			goto IL_0A;
		}

		// Token: 0x04000081 RID: 129
		public const uint S_OK = 0U;

		// Token: 0x04000082 RID: 130
		public const uint E_INFO_BASE = 1610645504U;

		// Token: 0x04000083 RID: 131
		public const uint E_SILENT_MODE = 1610645505U;

		// Token: 0x04000084 RID: 132
		public const uint E_READ_ASK_SUCCESSFUL = 1610645506U;

		// Token: 0x04000085 RID: 133
		public const uint E_READ_ASK_FAILED = 1610645507U;

		// Token: 0x04000086 RID: 134
		public const uint E_WRITE_ASK_SUCCESSFUL = 1610645508U;

		// Token: 0x04000087 RID: 135
		public const uint E_WRITE_ASK_FAILED = 1610645509U;

		// Token: 0x04000088 RID: 136
		public const uint E_SET_PASSWORD_CANCELLED = 1610645510U;

		// Token: 0x04000089 RID: 137
		public const uint E_WARNING_BASE = 2684387328U;

		// Token: 0x0400008A RID: 138
		public const uint E_ACCESS_LOCKEDOUT = 2684387329U;

		// Token: 0x0400008B RID: 139
		public const uint E_NOT_SUPPORT_PASSWORD = 2684387330U;

		// Token: 0x0400008C RID: 140
		public const uint E_NO_KEY_LOADED = 2684387331U;

		// Token: 0x0400008D RID: 141
		public const uint E_UP_PSWD_RETRY_LIMITATION = 2684387332U;

		// Token: 0x0400008E RID: 142
		public const uint E_UPGRADE_WITHOUT_MASTER_KEY = 2684387333U;

		// Token: 0x0400008F RID: 143
		public const uint E_NO_MASTER_KEY_LOADED = 2684387334U;

		// Token: 0x04000090 RID: 144
		public const uint E_ABORT_ACCESS_PASSWORD = 2684387335U;

		// Token: 0x04000091 RID: 145
		public const uint E_READ_IMCOMPATIBLE_VERSION_IBTN = 2684387336U;

		// Token: 0x04000092 RID: 146
		public const uint E_FILE_NOT_EXIST = 2684387337U;

		// Token: 0x04000093 RID: 147
		public const uint E_WRITE_OLD_VERSION_IBTN = 2684387338U;

		// Token: 0x04000094 RID: 148
		public const uint E_WRITE_NEW_VERSION_IBTN = 2684387339U;

		// Token: 0x04000095 RID: 149
		public const uint E_WRITE_IBTN_CANCELLED = 2684387340U;

		// Token: 0x04000096 RID: 150
		public const uint E_MESSAGE_BOX_SHOWN = 2684387341U;

		// Token: 0x04000097 RID: 151
		public const uint E_NOT_SUPPORT_SW_EXPIRATION = 2684387342U;

		// Token: 0x04000098 RID: 152
		public const uint E_ERROR_BASE = 3758129152U;

		// Token: 0x04000099 RID: 153
		public const uint E_IBTN_ABSENT = 3758129153U;

		// Token: 0x0400009A RID: 154
		public const uint E_INTERNAL_PROGRAM_ERROR = 3758129154U;

		// Token: 0x0400009B RID: 155
		public const uint E_SN_NOT_MATCH = 3758129155U;

		// Token: 0x0400009C RID: 156
		public const uint E_CRC_NOT_MATCH = 3758129156U;

		// Token: 0x0400009D RID: 157
		public const uint E_IBTN_BE_REPLACED = 3758129157U;

		// Token: 0x0400009E RID: 158
		public const uint E_NO_KEY_IN_ASK = 3758129158U;

		// Token: 0x0400009F RID: 159
		public const uint E_ERROR_MESSAGE_DUMMY = 3758129159U;

		// Token: 0x040000A0 RID: 160
		public const uint E_NOT_VALID_IBTN_KEY = 3758129160U;

		// Token: 0x040000A1 RID: 161
		public const uint E_FILE_IS_DAMAGED = 3758129161U;

		// Token: 0x040000A2 RID: 162
		public const uint E_OUTOFMEMORY = 3758129162U;

		// Token: 0x040000A3 RID: 163
		public const uint E_ACCESSDENIED = 3758129163U;

		// Token: 0x040000A4 RID: 164
		public const uint E_KEY_EXPIRED = 3758129164U;

		// Token: 0x040000A5 RID: 165
		public const uint E_READ_SOFTWARE_KEY_FAILED = 3758129165U;

		// Token: 0x040000A6 RID: 166
		public const uint E_HIGH_WATER_MARK_VIOLATION = 3758129166U;
	}
}
