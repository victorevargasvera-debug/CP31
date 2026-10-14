using System;
using System.Globalization;
using System.Windows.Data;
using AllFeatures;
using CommonResources;

namespace Motorola.MackinawCPS.CoreFeatures.PhoneWide
{
	// Token: 0x02000432 RID: 1074
	public sealed class PackAndunpackPhoneDigitString : global::System.Windows.Data.IValueConverter
	{
		// Token: 0x0600920B RID: 37387 RVA: 0x0089A774 File Offset: 0x00898974
		public object Convert(object value, global::System.Type targetType, object parameter, global::System.Globalization.CultureInfo culture)
		{
			int a_ = 3;
			switch (0)
			{
			case 0:
				goto IL_B5;
			}
			int num;
			short num2;
			string text;
			for (;;)
			{
				IL_13:
				int num4;
				switch (num)
				{
				case 0:
					num2 = (short)1410990095;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 1:
					goto IL_287;
				case 2:
					goto IL_327;
				case 3:
				{
					num2 = (short)277509171;
					short num3 = num2;
					num2 = (short)477197363;
					switch ((num3 == num2) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_483;
					default:
						num2 = (short)1312161792;
						if (num2 != 0)
						{
						}
						if (text.Length > 4)
						{
							num2 = (short)627572754;
							num = (int)((global::System.IntPtr)num2);
							continue;
						}
						goto IL_287;
					}
					break;
				}
				case 4:
					if (text[num4] != '7')
					{
						num2 = (short)956366864;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_228;
				case 5:
					num2 = (short)544604171;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 6:
					num2 = (short)1369374737;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 7:
					goto IL_2E7;
				case 8:
					if (value != null)
					{
						num2 = (short)451084321;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_615;
				case 9:
					goto IL_615;
				case 10:
					if (text[num4] != '8')
					{
						num2 = (short)1011154957;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_228;
				case 11:
					if (text[num4] != '3')
					{
						num2 = (short)1731395606;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_228;
				case 12:
					if (text[num4] != '4')
					{
						num2 = (short)1702232099;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_228;
				case 13:
					num2 = (short)10944550;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 14:
					if (num4 >= text.Length)
					{
						num2 = (short)1683357698;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					num2 = (short)1070268452;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 15:
				{
					num2 = (short)1358430208;
					short num5 = num2;
					if (text[num4] != '#')
					{
						num2 = (short)1590689824;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_228;
				}
				case 16:
					num2 = (short)1498349578;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 17:
					if (text[num4] != '2')
					{
						num2 = (short)1966276613;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_228;
				case 18:
					text = text.Substring(0, 4);
					num2 = (short)1944780801;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 19:
					num2 = (short)1088552990;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 20:
					if (text[num4] != '5')
					{
						num2 = (short)1394016275;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_228;
				case 21:
					goto IL_2EC;
				case 22:
					num2 = (short)1417871372;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 23:
					text = text.Substring(0, num4);
					num2 = (short)1146748935;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 24:
					if (text[num4] != '1')
					{
						goto IL_483;
					}
					goto IL_228;
				case 25:
					if (text[num4] != '*')
					{
						num2 = (short)291635200;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_228;
				case 26:
					num2 = (short)1612972036;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 27:
					if (text.StartsWith(global::AllFeatures.CodeplugGuid.b("苃", a_)))
					{
						num2 = (short)1562640412;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					num2 = (short)956301315;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 28:
					goto IL_65C;
				case 29:
					num2 = (short)107216920;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 30:
					if (text[num4] != '6')
					{
						num2 = (short)837484570;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_228;
				case 31:
					if (text[num4] != 'P')
					{
						num2 = (short)2115633175;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_228;
				case 32:
					num2 = (short)2040987679;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 33:
					text = value.ToString().ToUpper();
					num2 = (short)642777097;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 34:
					goto IL_2EC;
				case 35:
					num2 = (short)1190264852;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 36:
					if (text[num4] != '0')
					{
						num2 = (short)1676214301;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_228;
				case 37:
					num2 = (short)340394009;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 38:
					if (text[num4] != '9')
					{
						num2 = (short)271843365;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_228;
				}
				goto IL_B5;
				IL_228:
				num4++;
				num2 = (short)2057961493;
				num = (int)((global::System.IntPtr)num2);
				continue;
				IL_287:
				text = text.Replace('A', '*');
				text = text.Replace('B', '#');
				text = text.Replace('C', 'P');
				num4 = 0;
				num2 = (short)242483234;
				num = (int)((global::System.IntPtr)num2);
				continue;
				IL_2EC:
				num2 = (short)1798897678;
				num = (int)((global::System.IntPtr)num2);
				continue;
				IL_483:
				num2 = (short)151388166;
				num = (int)((global::System.IntPtr)num2);
				continue;
				IL_615:
				num2 = (short)1249837083;
				num = (int)((global::System.IntPtr)num2);
			}
			IL_2E7:
			IL_327:
			return text;
			IL_65C:
			num2 = (short)1948516353;
			if (num2 != 0)
			{
			}
			text = "";
			return text;
			IL_B5:
			text = "";
			num2 = (short)85393416;
			num = (int)((global::System.IntPtr)num2);
			goto IL_13;
		}

		// Token: 0x0600920C RID: 37388 RVA: 0x0089AE0C File Offset: 0x0089900C
		public object ConvertBack(object value, global::System.Type targetType, object parameter, global::System.Globalization.CultureInfo culture)
		{
			switch (0)
			{
			case 0:
				goto IL_AC;
			}
			int num;
			short num2;
			string text;
			for (;;)
			{
				IL_0A:
				int num3;
				switch (num)
				{
				case 0:
					num2 = (short)102629391;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 1:
					goto IL_2A7;
				case 2:
					goto IL_347;
				case 3:
					if (text.Length > 4)
					{
						num2 = (short)1724514322;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_2A7;
				case 4:
					if (text[num3] != '7')
					{
						num2 = (short)1098317840;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_249;
				case 5:
					num2 = (short)879886347;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 6:
					num2 = (short)1293090833;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 7:
					goto IL_308;
				case 8:
					if (value != null)
					{
						num2 = (short)1104019489;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_5EB;
				case 9:
					goto IL_5EB;
				case 10:
					if (text[num3] != '8')
					{
						num2 = (short)1001979917;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_249;
				case 11:
					if (text[num3] != '3')
					{
						num2 = (short)1181614102;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_249;
				case 12:
					if (text[num3] != '4')
					{
						num2 = (short)10682403;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_249;
				case 13:
					goto IL_ED;
				case 14:
					if (num3 >= text.Length)
					{
						num2 = (short)430899202;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					num2 = (short)196870180;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 15:
					if (text[num3] != 'B')
					{
						num2 = (short)1835139104;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_249;
				case 16:
					num2 = (short)302120970;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 17:
					if (text[num3] != '2')
					{
						num2 = (short)1240399877;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_249;
				case 18:
					text = text.Substring(0, 4);
					num2 = (short)989396993;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 19:
					num2 = (short)204603422;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 20:
					if (text[num3] != '5')
					{
						num2 = (short)56360979;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_249;
				case 21:
					goto IL_30D;
				case 22:
				{
					num2 = (short)379387904;
					short num4 = num2;
					num2 = (short)842465292;
					num = (int)((global::System.IntPtr)num2);
					continue;
				}
				case 23:
					num2 = (short)1870987265;
					if (num2 != 0)
					{
					}
					text = text.Substring(0, num3);
					num2 = (short)2034106375;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 24:
					if (text[num3] != '1')
					{
						num2 = (short)1537998854;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_249;
				case 25:
					if (text[num3] != 'A')
					{
						num2 = (short)1794244608;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_249;
				case 26:
					num2 = (short)1701249028;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 27:
				{
					if (!(text == ""))
					{
						num2 = (short)1403125763;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					num2 = (short)893662725;
					short num5 = num2;
					num2 = (short)729036293;
					switch ((num5 == num2) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_ED;
					default:
						num2 = (short)1472397312;
						if (num2 != 0)
						{
						}
						num2 = (short)485359644;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					break;
				}
				case 28:
					goto IL_675;
				case 29:
					num2 = (short)1291452440;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 30:
					if (text[num3] != '6')
					{
						num2 = (short)1762918426;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_249;
				case 31:
					if (text[num3] != 'C')
					{
						num2 = (short)1368129559;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_249;
				case 32:
					num2 = (short)447348767;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 33:
					text = value.ToString().ToUpper();
					num2 = (short)1269104649;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 34:
					goto IL_30D;
				case 35:
					num2 = (short)1700659220;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 36:
					if (text[num3] != '0')
					{
						num2 = (short)452984861;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_249;
				case 37:
					num2 = (short)2078736409;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 38:
					if (text[num3] != '9')
					{
						num2 = (short)1750728741;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_249;
				}
				goto IL_AC;
				IL_ED:
				num2 = (short)1398603814;
				num = (int)((global::System.IntPtr)num2);
				continue;
				IL_249:
				num3++;
				num2 = (short)499974165;
				num = (int)((global::System.IntPtr)num2);
				continue;
				IL_2A7:
				text = text.Replace('*', 'A');
				text = text.Replace('#', 'B');
				text = text.Replace('P', 'C');
				num3 = 0;
				num2 = (short)301858850;
				num = (int)((global::System.IntPtr)num2);
				continue;
				IL_30D:
				num2 = (short)1694040078;
				num = (int)((global::System.IntPtr)num2);
				continue;
				IL_5EB:
				num2 = (short)2014380059;
				num = (int)((global::System.IntPtr)num2);
			}
			IL_308:
			IL_347:
			return text;
			IL_675:
			text = global::CommonResources.AcgResources.ID_F;
			return text;
			IL_AC:
			text = "";
			num2 = (short)880410632;
			num = (int)((global::System.IntPtr)num2);
			goto IL_0A;
		}
	}
}
