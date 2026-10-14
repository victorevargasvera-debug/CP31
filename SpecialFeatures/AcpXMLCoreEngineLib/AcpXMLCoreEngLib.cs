using System;
using System.Text.RegularExpressions;
using SpecialFeatures.AcpReportManagerLib;

namespace SpecialFeatures.AcpXMLCoreEngineLib
{
	// Token: 0x02000228 RID: 552
	public class AcpXMLCoreEngLib
	{
		// Token: 0x06001C28 RID: 7208 RVA: 0x0024919C File Offset: 0x0024739C
		public static bool isValidArabicDateTime(string dt)
		{
			int a_ = 6;
			switch (0)
			{
			case 0:
				goto IL_29;
			}
			int num;
			short num2;
			char c;
			for (;;)
			{
				IL_13:
				switch (num)
				{
				case 0:
					num2 = (short)1202585601;
					if (num2 != 0)
					{
					}
					if (c != 'ص')
					{
						num2 = (short)1813512194;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_146;
				case 1:
					if (c != 'م')
					{
						num2 = (short)470548483;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_146;
				case 2:
					goto IL_141;
				case 3:
					num2 = (short)1143406592;
					num = (int)((global::System.IntPtr)num2);
					continue;
				}
				goto IL_29;
			}
			for (;;)
			{
				IL_141:
				num2 = (short)1331718431;
				short num3 = num2;
				num2 = (short)1272277279;
				switch ((num3 == num2) ? 1 : 0)
				{
				case 0:
				case 2:
					break;
				default:
					goto IL_A2;
				}
			}
			IL_A2:
			num2 = (short)92405760;
			if (num2 != 0)
			{
			}
			num2 = (short)918814720;
			short num4 = num2;
			return false;
			IL_146:
			dt = dt.Remove(dt.Length - 1, 1);
			string pattern = global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("했붎좒뢔뢖쒘잚列鎠\udea2ﺤ誦蚨쮮쪰螲좴鞶\udfba욼趾변蓼駄ꏆ니流냌跐럒껔ꓘﯚ", a_);
			return global::System.Text.RegularExpressions.Regex.IsMatch(dt, pattern);
			IL_29:
			c = dt[dt.Length - 1];
			num2 = (short)1245184001;
			num = (int)((global::System.IntPtr)num2);
			goto IL_13;
		}

		// Token: 0x06001C29 RID: 7209 RVA: 0x00249318 File Offset: 0x00247518
		public static string convertToArabicFormat(string inValue)
		{
			short num = (short)1691287553;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				switch (num2)
				{
				case 0:
					if (global::SpecialFeatures.AcpXMLCoreEngineLib.AcpXMLCoreEngLib.isValidArabicDateTime(inValue))
					{
						num = (short)729481218;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					return inValue;
				case 1:
					switch (0)
					{
					case 0:
						goto IL_35;
					}
					continue;
				case 2:
					goto IL_130;
				case 3:
					goto IL_51;
				}
				IL_35:
				if (string.IsNullOrEmpty(inValue))
				{
					num = (short)1436811267;
					num2 = (int)((global::System.IntPtr)num);
				}
				else
				{
					num = (short)794851973;
					short num3 = num;
					num = (short)1093892741;
					switch ((num3 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						return inValue;
					default:
					{
						num = (short)702087168;
						if (num != 0)
						{
						}
						num = (short)1646264320;
						short num4 = num;
						num = (short)1244987393;
						if (num != 0)
						{
						}
						num = (short)1497956352;
						num2 = (int)((global::System.IntPtr)num);
						break;
					}
					}
				}
			}
			IL_51:
			return inValue;
			IL_130:
			return global::SpecialFeatures.AcpReportManagerLib.ReportViewer.convertToArabicDateTime(inValue);
		}
	}
}
