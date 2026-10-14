using System;
using System.Windows;
using CommonResources;

namespace SpecialFeatures.AcpReportManagerLib
{
	// Token: 0x0200024D RID: 589
	public class RptMgrErrorHandler
	{
		// Token: 0x06001D4F RID: 7503 RVA: 0x002B0E48 File Offset: 0x002AF048
		internal global::System.Windows.MessageBoxResult DisplayError(uint errorCode, string text, string caption)
		{
			int a_ = 0;
			short num = (short)2066087939;
			int num2 = (int)((global::System.IntPtr)num);
			string messageBoxText;
			for (;;)
			{
				num = (short)296830128;
				short num3 = num;
				num = (short)223364272;
				switch ((num3 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					break;
				default:
					num = (short)878575616;
					if (num != 0)
					{
					}
					switch (num2)
					{
					case 0:
						goto IL_26F;
					case 1:
						goto IL_172;
					case 2:
						goto IL_1EA;
					case 3:
						switch (0)
						{
						case 0:
							goto IL_92;
						}
						continue;
					case 4:
						goto IL_118;
					case 5:
						messageBoxText = string.Concat(new string[]
						{
							text,
							global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("ꎂ", a_),
							global::CommonResources.AppResources.Unkown_Error,
							global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("ꎂ", a_),
							caption
						});
						num = (short)1292173314;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 6:
						num = (short)1864368133;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					break;
				}
				IL_92:
				switch (errorCode)
				{
				case 1U:
				{
					messageBoxText = string.Concat(new string[]
					{
						text,
						global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("ꎂ", a_),
						global::CommonResources.AppResources.Template_File_Does_Not_Exist,
						global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("ꎂ", a_),
						caption
					});
					num = (short)566624256;
					short num4 = num;
					num = (short)384892928;
					num2 = (int)((global::System.IntPtr)num);
					break;
				}
				case 2U:
					messageBoxText = string.Concat(new string[]
					{
						text,
						global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("ꎂ", a_),
						global::CommonResources.AppResources.File_Corrupted,
						global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("ꎂ", a_),
						caption
					});
					num = (short)661585921;
					num2 = (int)((global::System.IntPtr)num);
					break;
				case 3U:
					messageBoxText = string.Concat(new string[]
					{
						text,
						global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("ꎂ", a_),
						global::CommonResources.AppResources.No_Codeplug_Data,
						global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("ꎂ", a_),
						caption
					});
					num = (short)1756364804;
					num2 = (int)((global::System.IntPtr)num);
					break;
				default:
					num = (short)1460600838;
					num2 = (int)((global::System.IntPtr)num);
					break;
				}
			}
			IL_118:
			IL_172:
			IL_1EA:
			goto IL_29B;
			IL_26F:
			num = (short)1219887105;
			if (num != 0)
			{
			}
			IL_29B:
			return global::System.Windows.MessageBox.Show(messageBoxText);
		}

		// Token: 0x06001D51 RID: 7505 RVA: 0x002B10F8 File Offset: 0x002AF2F8
		internal static string b(string A_0, int A_1)
		{
			char[] array = A_0.ToCharArray();
			int num = (int)((global::System.IntPtr)(1616820461 + A_1) + (global::System.IntPtr)76 + (global::System.IntPtr)19 + (global::System.IntPtr)4 + (global::System.IntPtr)50);
			int num3;
			int num2;
			if ((num2 = (num3 = 0)) < 1)
			{
				goto IL_63;
			}
			IL_30:
			int num5;
			int num4 = num5 = num2;
			char[] array2 = array;
			int num6 = num5;
			char c = array[num5];
			byte b = (byte)((int)(c & 'ÿ') ^ num++);
			byte b2 = (byte)((int)(c >> 8) ^ num++);
			byte b3 = b2;
			b2 = b;
			b = b3;
			array2[num6] = (ushort)((int)b2 << 8 | (int)b);
			num3 = num4 + 1;
			IL_63:
			if ((num2 = num3) >= array.Length)
			{
				return string.Intern(new string(array));
			}
			goto IL_30;
		}

		// Token: 0x0200024E RID: 590
		public enum ErrorCode : uint
		{
			// Token: 0x04000EBD RID: 3773
			FileDoesNotExist = 1U,
			// Token: 0x04000EBE RID: 3774
			FileCorrupted,
			// Token: 0x04000EBF RID: 3775
			emptyRptDataObject,
			// Token: 0x04000EC0 RID: 3776
			genericError
		}
	}
}
