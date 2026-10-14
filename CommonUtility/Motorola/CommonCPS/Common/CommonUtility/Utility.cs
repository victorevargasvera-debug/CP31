using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Text.RegularExpressions;
using CommonUtility;
using MassTransit;
using Motorola.CommonCPS.Server.EntityModel;

namespace Motorola.CommonCPS.Common.CommonUtility
{
	// Token: 0x02000016 RID: 22
	public static class Utility
	{
		// Token: 0x06000068 RID: 104 RVA: 0x000098A8 File Offset: 0x00007AA8
		public static bool IsMobileType(string modelNumber)
		{
			int a_ = 14;
			if (modelNumber.StartsWith(global::CommonUtility.VersionUtility.b("眾", a_), global::System.StringComparison.Ordinal))
			{
				short num = (short)54198272;
				short num2 = num;
				num = (short)509304975;
				short num3 = num;
				num = (short)2066178191;
				switch ((num3 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					break;
				default:
					num = (short)1458896896;
					if (num != 0)
					{
					}
					num = (short)1161428993;
					if (num != 0)
					{
					}
					return false;
				}
			}
			return true;
		}

		// Token: 0x06000069 RID: 105 RVA: 0x00009978 File Offset: 0x00007B78
		public static bool IsCompatibleLanguageForRadio(string firmwareVersion, string modelNumber, string lpId)
		{
			int a_ = 7;
			short num = (short)1637351427;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				switch (num2)
				{
				case 0:
					goto IL_AE;
				case 1:
					if (lpId == null)
					{
						num = (short)2027094016;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_126;
				case 2:
					goto IL_73;
				case 3:
					switch (0)
					{
					case 0:
						goto IL_3E;
					}
					continue;
				}
				IL_3E:
				if (!new global::System.Text.RegularExpressions.Regex(global::CommonUtility.VersionUtility.b("့昹堻ᔽ᰿汁ᡃ≅捇ᙉ手ቍ㑏祑絓", a_)).Match(firmwareVersion).Success)
				{
					num = (short)813957122;
					num2 = (int)((global::System.IntPtr)num);
				}
				else
				{
					num = (short)1518993409;
					num2 = (int)((global::System.IntPtr)num);
				}
			}
			IL_73:
			num = (short)221747897;
			short num3 = num;
			num = (short)639605433;
			switch ((num3 == num) ? 1 : 0)
			{
			case 0:
			case 2:
				IL_AE:
				throw new global::System.ArgumentNullException();
			default:
				num = (short)1514602497;
				if (num != 0)
				{
				}
				num = (short)1914372096;
				if (num != 0)
				{
				}
				return false;
			}
			IL_126:
			num = (short)1704263680;
			short num4 = num;
			string empty = string.Empty;
			return global::Motorola.CommonCPS.Common.CommonUtility.Utility.IsFirmwareLPCompatible(firmwareVersion, ref empty, lpId, !global::Motorola.CommonCPS.Common.CommonUtility.Utility.IsMobileType(modelNumber));
		}

		// Token: 0x0600006A RID: 106 RVA: 0x00009AF0 File Offset: 0x00007CF0
		public static bool IsFirmwareLPCompatible(string hostVersion, ref string stat, string languageName, bool IsPortable)
		{
			int a_ = 9;
			switch (0)
			{
			case 0:
				goto IL_1DD;
			}
			int num;
			short num2;
			short num3;
			for (;;)
			{
				IL_13:
				switch (num)
				{
				case 0:
					if (num2 == 5)
					{
						num3 = (short)1139081242;
						num = (int)((global::System.IntPtr)num3);
						continue;
					}
					goto IL_A3F;
				case 1:
					if (!hostVersion.StartsWith(global::CommonUtility.VersionUtility.b("縹", a_), global::System.StringComparison.Ordinal))
					{
						num3 = (short)1563951157;
						num = (int)((global::System.IntPtr)num3);
						continue;
					}
					goto IL_2B5;
				case 2:
					if (hostVersion.StartsWith(global::CommonUtility.VersionUtility.b("砹", a_), global::System.StringComparison.Ordinal))
					{
						num3 = (short)1551040585;
						num = (int)((global::System.IntPtr)num3);
						continue;
					}
					goto IL_1087;
				case 3:
					languageName == global::CommonUtility.VersionUtility.b("䀹吻ጽ㐿㕁", a_);
					num3 = (short)1364590683;
					num = (int)((global::System.IntPtr)num3);
					continue;
				case 4:
					if (!(languageName == global::CommonUtility.VersionUtility.b("䨹䠻ጽ〿㙁", a_)))
					{
						num3 = (short)1711276077;
						num = (int)((global::System.IntPtr)num3);
						continue;
					}
					goto IL_121B;
				case 5:
					if (num2 >= 7)
					{
						num3 = (short)1235157087;
						num = (int)((global::System.IntPtr)num3);
						continue;
					}
					goto IL_1193;
				case 6:
					num3 = (short)875036756;
					num = (int)((global::System.IntPtr)num3);
					continue;
				case 7:
					if (!(languageName == global::CommonUtility.VersionUtility.b("䠹䤻ጽ㈿㝁", a_)))
					{
						num3 = (short)393936976;
						num = (int)((global::System.IntPtr)num3);
						continue;
					}
					goto IL_B4F;
				case 8:
					goto IL_B14;
				case 9:
					if (!(languageName == global::CommonUtility.VersionUtility.b("䨹䠻ጽ〿㙁", a_)))
					{
						num3 = (short)1954283586;
						num = (int)((global::System.IntPtr)num3);
						continue;
					}
					goto IL_A8D;
				case 10:
					goto IL_60B;
				case 11:
					goto IL_1FD;
				case 12:
					if (languageName == global::CommonUtility.VersionUtility.b("䀹吻ጽ㐿㕁", a_))
					{
						num3 = (short)999686162;
						num = (int)((global::System.IntPtr)num3);
						continue;
					}
					return false;
				case 13:
					num3 = (short)125960249;
					num = (int)((global::System.IntPtr)num3);
					continue;
				case 14:
					goto IL_804;
				case 15:
					if (!string.IsNullOrEmpty(languageName))
					{
						num3 = (short)182845547;
						num = (int)((global::System.IntPtr)num3);
						continue;
					}
					goto IL_A8D;
				case 16:
					num3 = (short)498532460;
					num = (int)((global::System.IntPtr)num3);
					continue;
				case 17:
					num3 = (short)625934396;
					num = (int)((global::System.IntPtr)num3);
					continue;
				case 18:
					goto IL_B4F;
				case 19:
					if (num2 == 4)
					{
						num3 = (short)1095172160;
						num = (int)((global::System.IntPtr)num3);
						continue;
					}
					goto IL_1087;
				case 20:
					goto IL_F25;
				case 21:
					if (languageName == global::CommonUtility.VersionUtility.b("䠹䤻ጽ㈿㝁", a_))
					{
						num3 = (short)191103009;
						num = (int)((global::System.IntPtr)num3);
						continue;
					}
					return false;
				case 22:
					if (!(languageName == global::CommonUtility.VersionUtility.b("刹夻ጽ⤿⹁", a_)))
					{
						num3 = (short)396623883;
						num = (int)((global::System.IntPtr)num3);
						continue;
					}
					return false;
				case 23:
					goto IL_2B5;
				case 24:
					if (hostVersion.StartsWith(global::CommonUtility.VersionUtility.b("根", a_), global::System.StringComparison.Ordinal))
					{
						num3 = (short)1445199914;
						num = (int)((global::System.IntPtr)num3);
						continue;
					}
					goto IL_2EF;
				case 25:
					goto IL_A8D;
				case 26:
					goto IL_236;
				case 27:
					goto IL_741;
				case 28:
					num3 = (short)1168310376;
					num = (int)((global::System.IntPtr)num3);
					continue;
				case 29:
					if (!(languageName == global::CommonUtility.VersionUtility.b("弹伻ጽ┿ㅁ", a_)))
					{
						num3 = (short)1205272674;
						num = (int)((global::System.IntPtr)num3);
						continue;
					}
					goto IL_A8D;
				case 30:
					if (!IsPortable)
					{
						num3 = (short)510197841;
						num = (int)((global::System.IntPtr)num3);
						continue;
					}
					goto IL_1FD;
				case 31:
					num3 = (short)1535442965;
					num = (int)((global::System.IntPtr)num3);
					continue;
				case 32:
					if (!IsPortable)
					{
						num3 = (short)1780088863;
						num = (int)((global::System.IntPtr)num3);
						continue;
					}
					return false;
				case 33:
					num3 = (short)979042338;
					num = (int)((global::System.IntPtr)num3);
					continue;
				case 34:
					goto IL_DD3;
				case 35:
					num3 = (short)2065956964;
					num = (int)((global::System.IntPtr)num3);
					continue;
				case 36:
					num3 = (short)5570599;
					num = (int)((global::System.IntPtr)num3);
					continue;
				case 37:
					num3 = (short)1991180385;
					num = (int)((global::System.IntPtr)num3);
					continue;
				case 38:
					if (languageName == global::CommonUtility.VersionUtility.b("䠹䤻ጽ㈿㝁", a_))
					{
						num3 = (short)1043923003;
						num = (int)((global::System.IntPtr)num3);
						continue;
					}
					return false;
				case 39:
					if (languageName == global::CommonUtility.VersionUtility.b("刹夻ጽ⤿⹁", a_))
					{
						num3 = (short)382664814;
						num = (int)((global::System.IntPtr)num3);
						continue;
					}
					return false;
				case 40:
					num3 = (short)820838486;
					num = (int)((global::System.IntPtr)num3);
					continue;
				case 41:
					goto IL_557;
				case 42:
					num3 = (short)1608843336;
					num = (int)((global::System.IntPtr)num3);
					continue;
				case 43:
					if (!IsPortable)
					{
						num3 = (short)142278659;
						num = (int)((global::System.IntPtr)num3);
						continue;
					}
					return false;
				case 44:
					if (hostVersion.StartsWith(global::CommonUtility.VersionUtility.b("根", a_), global::System.StringComparison.Ordinal))
					{
						num3 = (short)815071249;
						num = (int)((global::System.IntPtr)num3);
						continue;
					}
					goto IL_741;
				case 45:
					num3 = (short)1177616430;
					num = (int)((global::System.IntPtr)num3);
					continue;
				case 46:
					if (!(languageName == global::CommonUtility.VersionUtility.b("刹夻ጽ⤿⹁", a_)))
					{
						num3 = (short)1094713407;
						num = (int)((global::System.IntPtr)num3);
						continue;
					}
					goto IL_121B;
				case 47:
					if (!IsPortable)
					{
						num3 = (short)27721764;
						num = (int)((global::System.IntPtr)num3);
						continue;
					}
					return false;
				case 48:
					goto IL_3DB;
				case 49:
					IL_28D:
					if (!string.IsNullOrEmpty(languageName))
					{
						num3 = (short)339869795;
						num = (int)((global::System.IntPtr)num3);
						continue;
					}
					return false;
				case 50:
					if (languageName == global::CommonUtility.VersionUtility.b("刹夻ጽ⤿⹁", a_))
					{
						num3 = (short)6815769;
						num = (int)((global::System.IntPtr)num3);
						continue;
					}
					return false;
				case 51:
					num3 = (short)377749505;
					if (num3 != 0)
					{
					}
					if (!(languageName == global::CommonUtility.VersionUtility.b("尹主ጽ⌿⍁", a_)))
					{
						num3 = (short)63242346;
						num = (int)((global::System.IntPtr)num3);
						continue;
					}
					goto IL_121B;
				case 52:
				{
					num3 = (short)534642688;
					short num4 = num3;
					num3 = (short)1733951570;
					num = (int)((global::System.IntPtr)num3);
					continue;
				}
				case 53:
					num3 = (short)43647045;
					num = (int)((global::System.IntPtr)num3);
					continue;
				case 54:
					goto IL_275;
				case 55:
					num3 = (short)1127415810;
					num = (int)((global::System.IntPtr)num3);
					continue;
				case 56:
					num3 = (short)1124794397;
					num = (int)((global::System.IntPtr)num3);
					continue;
				case 57:
					if (hostVersion.StartsWith(global::CommonUtility.VersionUtility.b("砹", a_), global::System.StringComparison.Ordinal))
					{
						num3 = (short)1351680085;
						num = (int)((global::System.IntPtr)num3);
						continue;
					}
					goto IL_87F;
				case 58:
					if (!hostVersion.StartsWith(global::CommonUtility.VersionUtility.b("縹", a_), global::System.StringComparison.Ordinal))
					{
						num3 = (short)2071789623;
						num = (int)((global::System.IntPtr)num3);
						continue;
					}
					goto IL_C9B;
				case 59:
					goto IL_121B;
				case 60:
					if (num2 != 5)
					{
						num3 = (short)1998520347;
						num = (int)((global::System.IntPtr)num3);
						continue;
					}
					goto IL_1123;
				case 61:
					num3 = (short)2015428679;
					num = (int)((global::System.IntPtr)num3);
					continue;
				case 62:
					if (!(languageName == global::CommonUtility.VersionUtility.b("尹主ጽ⌿⍁", a_)))
					{
						num3 = (short)809041972;
						num = (int)((global::System.IntPtr)num3);
						continue;
					}
					return false;
				case 63:
					num3 = (short)1091436582;
					num = (int)((global::System.IntPtr)num3);
					continue;
				case 64:
					goto IL_1123;
				case 65:
					if (hostVersion.StartsWith(global::CommonUtility.VersionUtility.b("根", a_), global::System.StringComparison.Ordinal))
					{
						num3 = (short)815464485;
						num = (int)((global::System.IntPtr)num3);
						continue;
					}
					goto IL_557;
				case 66:
					num3 = (short)1669922866;
					num = (int)((global::System.IntPtr)num3);
					continue;
				case 67:
					if (hostVersion.StartsWith(global::CommonUtility.VersionUtility.b("根", a_), global::System.StringComparison.Ordinal))
					{
						num3 = (short)860487741;
						num = (int)((global::System.IntPtr)num3);
						continue;
					}
					goto IL_60B;
				case 68:
					if (num2 < 4)
					{
						num3 = (short)371130422;
						num = (int)((global::System.IntPtr)num3);
						continue;
					}
					goto IL_87F;
				case 69:
					if (hostVersion.StartsWith(global::CommonUtility.VersionUtility.b("砹", a_), global::System.StringComparison.Ordinal))
					{
						num3 = (short)1417609239;
						num = (int)((global::System.IntPtr)num3);
						continue;
					}
					return false;
				case 70:
					if (!(languageName == global::CommonUtility.VersionUtility.b("尹主ጽ⌿⍁", a_)))
					{
						num3 = (short)1564344355;
						num = (int)((global::System.IntPtr)num3);
						continue;
					}
					goto IL_B4F;
				case 71:
					if (num2 != 7)
					{
						num3 = (short)739901450;
						num = (int)((global::System.IntPtr)num3);
						continue;
					}
					goto IL_804;
				case 72:
					if (num2 >= 8)
					{
						num3 = (short)1277493276;
						num = (int)((global::System.IntPtr)num3);
						continue;
					}
					goto IL_2EF;
				case 73:
					goto IL_C9B;
				case 74:
					if (!(languageName == global::CommonUtility.VersionUtility.b("尹主ጽ⌿⍁", a_)))
					{
						num3 = (short)835780664;
						num = (int)((global::System.IntPtr)num3);
						continue;
					}
					goto IL_A8D;
				case 75:
					try
					{
						num2 = global::System.Convert.ToInt16(hostVersion.Substring(1, 2), 10);
						goto IL_96C;
					}
					catch
					{
						return false;
					}
					goto IL_51D;
					IL_96C:
					num3 = (short)162005016;
					num = (int)((global::System.IntPtr)num3);
					continue;
				case 76:
					if (hostVersion.StartsWith(global::CommonUtility.VersionUtility.b("砹", a_), global::System.StringComparison.Ordinal))
					{
						num3 = (short)880214064;
						num = (int)((global::System.IntPtr)num3);
						continue;
					}
					goto IL_A3F;
				case 77:
					if (!string.IsNullOrEmpty(languageName))
					{
						num3 = (short)30081135;
						num = (int)((global::System.IntPtr)num3);
						continue;
					}
					goto IL_B4F;
				case 78:
					num3 = (short)1207697502;
					num = (int)((global::System.IntPtr)num3);
					continue;
				case 79:
					num3 = (short)1366884464;
					num = (int)((global::System.IntPtr)num3);
					continue;
				case 80:
					num3 = (short)1073676300;
					num = (int)((global::System.IntPtr)num3);
					continue;
				case 81:
					num3 = (short)1074135062;
					num = (int)((global::System.IntPtr)num3);
					continue;
				case 82:
					if (!(languageName == global::CommonUtility.VersionUtility.b("弹伻ጽ┿ㅁ", a_)))
					{
						num3 = (short)1903755280;
						num = (int)((global::System.IntPtr)num3);
						continue;
					}
					return false;
				case 83:
					if (!hostVersion.StartsWith(global::CommonUtility.VersionUtility.b("縹", a_), global::System.StringComparison.Ordinal))
					{
						num3 = (short)511180887;
						num = (int)((global::System.IntPtr)num3);
						continue;
					}
					goto IL_3DB;
				case 84:
					if (num2 != 6)
					{
						num3 = (short)243990637;
						num = (int)((global::System.IntPtr)num3);
						continue;
					}
					goto IL_236;
				case 85:
					goto IL_51D;
				case 86:
					if (!(languageName == global::CommonUtility.VersionUtility.b("䨹䠻ጽ〿㙁", a_)))
					{
						num3 = (short)2033123406;
						num = (int)((global::System.IntPtr)num3);
						continue;
					}
					goto IL_B4F;
				case 87:
					num3 = (short)1946419276;
					num = (int)((global::System.IntPtr)num3);
					continue;
				case 88:
					num3 = (short)1442316339;
					num = (int)((global::System.IntPtr)num3);
					continue;
				case 89:
					num3 = (short)1683292164;
					num = (int)((global::System.IntPtr)num3);
					continue;
				case 90:
					num3 = (short)2013921287;
					num = (int)((global::System.IntPtr)num3);
					continue;
				case 91:
					goto IL_118E;
				case 92:
					if (!string.IsNullOrEmpty(languageName))
					{
						num3 = (short)614596696;
						num = (int)((global::System.IntPtr)num3);
						continue;
					}
					goto IL_121B;
				case 93:
					if (hostVersion.StartsWith(global::CommonUtility.VersionUtility.b("根", a_), global::System.StringComparison.Ordinal))
					{
						num3 = (short)1500315654;
						num = (int)((global::System.IntPtr)num3);
						continue;
					}
					goto IL_91C;
				case 94:
					if (!(languageName == global::CommonUtility.VersionUtility.b("刹夻ጽ⤿⹁", a_)))
					{
						num3 = (short)198508634;
						num = (int)((global::System.IntPtr)num3);
						continue;
					}
					goto IL_B4F;
				case 95:
					goto IL_2EF;
				case 96:
					if (!(languageName == global::CommonUtility.VersionUtility.b("弹伻ጽ┿ㅁ", a_)))
					{
						num3 = (short)163971161;
						num = (int)((global::System.IntPtr)num3);
						continue;
					}
					goto IL_121B;
				case 97:
					if (num2 >= 5)
					{
						num3 = (short)1159987241;
						num = (int)((global::System.IntPtr)num3);
						continue;
					}
					goto IL_275;
				case 98:
					num3 = (short)1028325385;
					num = (int)((global::System.IntPtr)num3);
					continue;
				case 99:
					num3 = (short)1750007870;
					num = (int)((global::System.IntPtr)num3);
					continue;
				case 100:
					if (!(languageName == global::CommonUtility.VersionUtility.b("弹伻ጽ┿ㅁ", a_)))
					{
						num3 = (short)57868328;
						num = (int)((global::System.IntPtr)num3);
						continue;
					}
					goto IL_B4F;
				case 101:
					if (hostVersion.StartsWith(global::CommonUtility.VersionUtility.b("砹", a_), global::System.StringComparison.Ordinal))
					{
						num3 = (short)1416232968;
						num = (int)((global::System.IntPtr)num3);
						continue;
					}
					goto IL_1193;
				case 102:
					if (!hostVersion.StartsWith(global::CommonUtility.VersionUtility.b("縹", a_), global::System.StringComparison.Ordinal))
					{
						num3 = (short)1240072205;
						num = (int)((global::System.IntPtr)num3);
						continue;
					}
					goto IL_51D;
				case 103:
					num3 = (short)1615265893;
					num = (int)((global::System.IntPtr)num3);
					continue;
				case 104:
					if (!hostVersion.StartsWith(global::CommonUtility.VersionUtility.b("縹", a_), global::System.StringComparison.Ordinal))
					{
						num3 = (short)1185742951;
						num = (int)((global::System.IntPtr)num3);
						continue;
					}
					goto IL_B14;
				case 105:
					if (num2 == 6)
					{
						num3 = (short)754450446;
						num = (int)((global::System.IntPtr)num3);
						continue;
					}
					return false;
				case 106:
					num3 = (short)1136263264;
					num = (int)((global::System.IntPtr)num3);
					continue;
				case 107:
					num3 = (short)1653866570;
					num = (int)((global::System.IntPtr)num3);
					continue;
				case 108:
					if (!(languageName == global::CommonUtility.VersionUtility.b("䨹䠻ጽ〿㙁", a_)))
					{
						num3 = (short)1041367119;
						num = (int)((global::System.IntPtr)num3);
						continue;
					}
					return false;
				case 109:
					goto IL_91C;
				case 110:
					num3 = (short)1112670228;
					num = (int)((global::System.IntPtr)num3);
					continue;
				case 111:
					num3 = (short)1098252358;
					num = (int)((global::System.IntPtr)num3);
					continue;
				case 112:
					goto IL_5BA;
				}
				goto IL_1DD;
				IL_1FD:
				num3 = (short)1353121824;
				num = (int)((global::System.IntPtr)num3);
				continue;
				IL_236:
				num3 = (short)2081226844;
				num = (int)((global::System.IntPtr)num3);
				continue;
				IL_275:
				num3 = (short)766115889;
				num = (int)((global::System.IntPtr)num3);
				continue;
				IL_1193:
				num3 = (short)811065235;
				short num5 = num3;
				num3 = (short)794550163;
				switch ((num5 == num3) ? 1 : 0)
				{
				case 0:
				case 2:
					goto IL_28D;
				default:
					goto IL_11C8;
				}
				IL_2B5:
				num3 = (short)709034089;
				num = (int)((global::System.IntPtr)num3);
				continue;
				IL_2EF:
				num3 = (short)515702849;
				num = (int)((global::System.IntPtr)num3);
				continue;
				IL_3DB:
				num3 = (short)1105985536;
				num = (int)((global::System.IntPtr)num3);
				continue;
				IL_51D:
				num3 = (short)2027880516;
				num = (int)((global::System.IntPtr)num3);
				continue;
				IL_557:
				num3 = (short)1716846694;
				num = (int)((global::System.IntPtr)num3);
				continue;
				IL_60B:
				num3 = (short)2054750209;
				num = (int)((global::System.IntPtr)num3);
				continue;
				IL_741:
				num3 = (short)151191610;
				num = (int)((global::System.IntPtr)num3);
				continue;
				IL_804:
				num3 = (short)142803021;
				num = (int)((global::System.IntPtr)num3);
				continue;
				IL_87F:
				num3 = (short)1766719532;
				num = (int)((global::System.IntPtr)num3);
				continue;
				IL_91C:
				num3 = (short)1197408339;
				num = (int)((global::System.IntPtr)num3);
				continue;
				IL_A3F:
				num3 = (short)1396834371;
				num = (int)((global::System.IntPtr)num3);
				continue;
				IL_A8D:
				num3 = (short)268763183;
				num = (int)((global::System.IntPtr)num3);
				continue;
				IL_B14:
				num3 = (short)884867077;
				num = (int)((global::System.IntPtr)num3);
				continue;
				IL_B4F:
				num3 = (short)1837891627;
				num = (int)((global::System.IntPtr)num3);
				continue;
				IL_C9B:
				num3 = (short)1530986515;
				num = (int)((global::System.IntPtr)num3);
				continue;
				IL_1087:
				num3 = (short)1289027677;
				num = (int)((global::System.IntPtr)num3);
				continue;
				IL_1123:
				num3 = (short)1914372111;
				num = (int)((global::System.IntPtr)num3);
				continue;
				IL_121B:
				num3 = (short)1802764318;
				num = (int)((global::System.IntPtr)num3);
			}
			return false;
			IL_5BA:
			IL_DD3:
			IL_F25:
			IL_118E:
			return false;
			IL_11C8:
			num3 = (short)508231680;
			if (num3 != 0)
			{
			}
			return true;
			IL_1DD:
			num2 = 0;
			num3 = (short)232718411;
			num = (int)((global::System.IntPtr)num3);
			goto IL_13;
		}

		// Token: 0x0600006B RID: 107 RVA: 0x0000AD68 File Offset: 0x00008F68
		public static global::Motorola.CommonCPS.Server.EntityModel.ASTROLanguagePack GetLatestLanguagePackVer(global::System.Collections.Generic.List<global::Motorola.CommonCPS.Server.EntityModel.ASTROLanguagePack> lps)
		{
			short num = (short)668336136;
			int num2 = (int)((global::System.IntPtr)num);
			global::Motorola.CommonCPS.Server.EntityModel.ASTROLanguagePack result;
			for (;;)
			{
				int num3;
				switch (num2)
				{
				case 0:
				{
					string packageVersion;
					if (string.Compare(packageVersion, lps[num3].PackageVersion, global::System.StringComparison.Ordinal) < 0)
					{
						num = (short)2093023235;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_6F;
				}
				case 1:
					goto IL_6F;
				case 2:
					num = (short)182648842;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 3:
				{
					string packageVersion = lps[num3].PackageVersion;
					result = lps[num3];
					num = (short)520290305;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				case 4:
					return result;
				case 5:
				{
					num = (short)1588854785;
					if (num != 0)
					{
					}
					string packageVersion = lps[0].PackageVersion;
					result = lps[0];
					num3 = 1;
					num = (short)1775501318;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				case 6:
					goto IL_1A0;
				case 7:
					goto IL_1A0;
				case 8:
					switch (0)
					{
					case 0:
						goto IL_50;
					}
					continue;
				case 9:
					if (num3 >= lps.Count)
					{
						goto IL_1EA;
					}
					num = (short)713687040;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 10:
				{
					if (lps.Count <= 0)
					{
						goto IL_254;
					}
					num = (short)898601686;
					short num4 = num;
					num = (short)1851036374;
					switch ((num4 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_1EA;
					default:
						num = (short)926285824;
						if (num != 0)
						{
						}
						num = (short)74711045;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					break;
				}
				}
				IL_50:
				if (lps != null)
				{
					num = (short)1064173570;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				goto IL_254;
				IL_6F:
				num3++;
				num = (short)2068840455;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_1A0:
				num = (short)1956511744;
				short num5 = num;
				num = (short)143654921;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_1EA:
				num = (short)2047148036;
				num2 = (int)((global::System.IntPtr)num);
			}
			return result;
			IL_254:
			return null;
		}

		// Token: 0x0600006C RID: 108 RVA: 0x0000AFCC File Offset: 0x000091CC
		public static bool IsAny<T>(this global::System.Collections.Generic.IEnumerable<T> data)
		{
			while (data == null)
			{
				short num = (short)644528626;
				short num2 = num;
				num = (short)1846065650;
				switch ((num2 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					break;
				default:
				{
					num = (short)1896153089;
					if (num != 0)
					{
					}
					num = (short)1924726784;
					short num3 = num;
					num = (short)801046528;
					if (num != 0)
					{
					}
					return false;
				}
				}
			}
			return data.Any<T>();
		}

		// Token: 0x0600006D RID: 109 RVA: 0x0000B084 File Offset: 0x00009284
		public static global::System.Guid NewSqeuentialGuid()
		{
			short num = (short)528955212;
			short num2 = num;
			num = (short)901789516;
			switch (num2 == num)
			{
			}
			num = (short)1118896129;
			if (num != 0)
			{
			}
			num = (short)1784676352;
			short num3 = num;
			num = (short)1514864640;
			if (num != 0)
			{
			}
			return global::Motorola.CommonCPS.Common.CommonUtility.Utility.a(global::MassTransit.NewId.NextGuid());
		}

		// Token: 0x0600006E RID: 110 RVA: 0x0000B134 File Offset: 0x00009334
		private static global::System.Guid a(global::System.Guid A_0)
		{
			short num = (short)2040984763;
			short num2 = num;
			num = (short)1209660603;
			switch (num2 == num)
			{
			}
			num = (short)301924352;
			if (num != 0)
			{
			}
			num = (short)821493760;
			short num3 = num;
			num = (short)696123393;
			if (num != 0)
			{
			}
			byte[] array = A_0.ToByteArray();
			global::System.Array.Reverse(array, 0, 4);
			global::System.Array.Reverse(array, 4, 2);
			global::System.Array.Reverse(array, 6, 2);
			return new global::System.Guid(array);
		}

		// Token: 0x0600006F RID: 111 RVA: 0x0000B204 File Offset: 0x00009404
		public static global::Motorola.CommonCPS.Server.EntityModel.DBNode BFSNodeByNodeName(global::Motorola.CommonCPS.Server.EntityModel.DBNode node, string inputname)
		{
			short num = (short)1127809024;
			switch (num)
			{
			default:
			{
				num = (short)325189636;
				int num2 = (int)((global::System.IntPtr)num);
				for (;;)
				{
					num = (short)355860480;
					short num3 = num;
					global::System.Collections.Generic.List<global::Motorola.CommonCPS.Server.EntityModel.DBNode>.Enumerator enumerator;
					switch (num2)
					{
					case 0:
					{
						global::Motorola.CommonCPS.Server.EntityModel.DBNode result;
						try
						{
							num = (short)1467088903;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								switch (num2)
								{
								case 0:
									num = (short)1813118980;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 1:
								{
									global::Motorola.CommonCPS.Server.EntityModel.DBNode dbnode;
									if (inputname == dbnode.Name)
									{
										num = (short)713949192;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									break;
								}
								case 2:
									num = (short)356319233;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 3:
									goto IL_3AA;
								case 4:
									goto IL_404;
								case 5:
								{
									if (!enumerator.MoveNext())
									{
										num = (short)490536960;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									global::Motorola.CommonCPS.Server.EntityModel.DBNode dbnode = enumerator.Current;
									num = (short)1473970182;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 6:
								{
									global::Motorola.CommonCPS.Server.EntityModel.DBNode dbnode;
									if (dbnode.Name != null)
									{
										num = (short)1887043586;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									break;
								}
								case 7:
									switch (0)
									{
									case 0:
										goto IL_30C;
									}
									continue;
								case 8:
								{
									global::Motorola.CommonCPS.Server.EntityModel.DBNode dbnode;
									result = dbnode;
									num = (short)1665662979;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								}
								IL_3AC:
								num = (short)1718747141;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								IL_30C:
								goto IL_3AC;
							}
							IL_3AA:
							return result;
							IL_404:
							goto IL_22E;
						}
						finally
						{
							((global::System.IDisposable)enumerator).Dispose();
						}
						return result;
					}
					case 1:
						if (node.ChildNodesList.Count > 0)
						{
							num = (short)1544814594;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_27D;
					case 2:
						enumerator = node.ChildNodesList.GetEnumerator();
						num = (short)1129447424;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 3:
						try
						{
							num = (short)678625285;
							num2 = (int)((global::System.IntPtr)num);
							global::Motorola.CommonCPS.Server.EntityModel.DBNode result;
							for (;;)
							{
								num = (short)1784549108;
								short num4 = num;
								num = (short)1566183156;
								global::Motorola.CommonCPS.Server.EntityModel.DBNode dbnode2;
								switch ((num4 == num) ? 1 : 0)
								{
								case 0:
								case 2:
									break;
								default:
									num = (short)838795264;
									if (num != 0)
									{
									}
									switch (num2)
									{
									case 0:
										goto IL_1D7;
									case 1:
										if (!enumerator.MoveNext())
										{
											num = (short)1829634051;
											num2 = (int)((global::System.IntPtr)num);
											continue;
										}
										dbnode2 = global::Motorola.CommonCPS.Common.CommonUtility.Utility.BFSNodeByNodeName(enumerator.Current, inputname);
										num = (short)203685890;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									case 2:
										goto IL_161;
									case 3:
										num = (short)2133721092;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									case 4:
										goto IL_1F5;
									case 5:
										switch (0)
										{
										case 0:
											goto IL_138;
										}
										continue;
									case 6:
										result = dbnode2;
										num = (short)1147142144;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									IL_138:
									goto IL_17F;
								}
								IL_161:
								if (dbnode2 != null)
								{
									num = (short)726728710;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								IL_17F:
								num = (short)1909850113;
								num2 = (int)((global::System.IntPtr)num);
							}
							IL_1D7:
							return result;
							IL_1F5:
							goto IL_27D;
						}
						finally
						{
							num = (short)1723858945;
							if (num != 0)
							{
							}
							((global::System.IDisposable)enumerator).Dispose();
						}
						goto IL_22E;
					case 4:
						switch (0)
						{
						case 0:
							goto IL_87;
						}
						continue;
					case 5:
						num = (short)1419902977;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					IL_87:
					if (node.ChildNodesList != null)
					{
						num = (short)417792005;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					break;
					IL_22E:
					enumerator = node.ChildNodesList.GetEnumerator();
					num = (short)2059927555;
					num2 = (int)((global::System.IntPtr)num);
				}
				IL_27D:
				return null;
			}
			}
		}

		// Token: 0x06000070 RID: 112 RVA: 0x0000B660 File Offset: 0x00009860
		public static bool IsIGControlBug(object sender, global::System.Exception e)
		{
			int a_ = 11;
			switch (0)
			{
			case 0:
				goto IL_61;
			}
			int num;
			short num2;
			global::System.Exception ex;
			for (;;)
			{
				IL_13:
				switch (num)
				{
				case 0:
					num2 = (short)80085003;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 1:
					return true;
				case 2:
					if (!ex.Source.StartsWith(global::CommonUtility.VersionUtility.b("画倽☿ぁ╃ⅅⅇ㥉㡋❍㍏⅑", a_), global::System.StringComparison.OrdinalIgnoreCase))
					{
						num2 = (short)1082851337;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_1F3;
				case 3:
					return true;
				case 4:
					num2 = (short)1726349326;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 5:
					goto IL_7B;
				case 6:
					num2 = (short)1239285777;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 7:
					if (ex.Source == global::CommonUtility.VersionUtility.b("儻䴽⌿ⵁ㙃⩅ⅇ⡉", a_))
					{
						num2 = (short)1935736845;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_2E9;
				case 8:
				{
					num2 = (short)1675415858;
					short num3 = num2;
					num2 = (short)1426641202;
					switch ((num3 == num2) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_261;
					default:
					{
						num2 = (short)1477705728;
						if (num2 != 0)
						{
						}
						global::System.Runtime.InteropServices.COMException ex2;
						if (ex2 != null)
						{
							num2 = (short)1981218822;
							num = (int)((global::System.IntPtr)num2);
							continue;
						}
						return false;
					}
					}
					break;
				}
				case 9:
					num2 = (short)1385431047;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 10:
					goto IL_7B;
				case 11:
				{
					if (e is global::System.Reflection.TargetInvocationException)
					{
						num2 = (short)1059651587;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					global::System.Runtime.InteropServices.COMException ex2 = e as global::System.Runtime.InteropServices.COMException;
					goto IL_261;
				}
				case 12:
					if (ex is global::System.ArgumentOutOfRangeException)
					{
						num2 = (short)119930884;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_2E9;
				case 13:
					goto IL_355;
				case 14:
					if (ex.Source != null)
					{
						num2 = (short)58785807;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_2E9;
				case 15:
				{
					num2 = (short)1692467200;
					short num4 = num2;
					num2 = (short)2033123330;
					num = (int)((global::System.IntPtr)num2);
					continue;
				}
				case 16:
					if (ex == null)
					{
						num2 = (short)1329856512;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					num2 = (short)2081751052;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 17:
				{
					global::System.Runtime.InteropServices.COMException ex2;
					if (ex2.ErrorCode == -2147221040)
					{
						num2 = (short)1448804353;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					return false;
				}
				}
				goto IL_61;
				IL_7B:
				num2 = (short)1718485008;
				num = (int)((global::System.IntPtr)num2);
				continue;
				IL_261:
				num2 = (short)1274740744;
				num = (int)((global::System.IntPtr)num2);
				continue;
				IL_2E9:
				ex = ex.InnerException;
				num2 = (short)898433034;
				num = (int)((global::System.IntPtr)num2);
			}
			return true;
			IL_1F3:
			num2 = (short)164298753;
			if (num2 != 0)
			{
			}
			return true;
			IL_355:
			goto IL_1F3;
			IL_61:
			ex = e;
			num2 = (short)577568773;
			num = (int)((global::System.IntPtr)num2);
			goto IL_13;
		}

		// Token: 0x04000021 RID: 33
		private const string a = "fr-ca";

		// Token: 0x04000022 RID: 34
		private const string b = "es-es";

		// Token: 0x04000023 RID: 35
		private const string c = "pt-pt";

		// Token: 0x04000024 RID: 36
		private const string d = "id-id";

		// Token: 0x04000025 RID: 37
		private const string e = "he-il";

		// Token: 0x04000026 RID: 38
		private const string f = "ru-ru";

		// Token: 0x04000027 RID: 39
		private const string g = "zh-tw";
	}
}
