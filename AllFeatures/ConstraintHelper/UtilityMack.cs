using System;
using System.Collections.Generic;
using System.Device.Location;
using System.Globalization;
using System.IO;
using System.IO.Compression;
using System.Linq;
using System.Net;
using System.Runtime.CompilerServices;
using System.Text.RegularExpressions;
using System.Threading;
using System.Windows.Forms;
using System.Xml.Linq;
using AcpBusinessLayer;
using AcpBusinessLayer.UndoRedo;
using AcpCommonLib;
using AcpCommonLib.UndoRedo;
using AllFeatures;
using CommonResources;
using Features.Common;
using Motorola.MackinawCPS.CoreFeatures.ConventionalPersonality;
using Motorola.MackinawCPS.CoreFeatures.DataProfiles;
using Motorola.MackinawCPS.CoreFeatures.DataWide;
using Motorola.MackinawCPS.CoreFeatures.MissionCriticalGeofence;
using Motorola.MackinawCPS.CoreFeatures.RadioInformation;
using Motorola.MackinawCPS.CoreFeatures.RadioWide;
using Motorola.MackinawCPS.CoreFeatures.TrunkingPersonality;
using Motorola.MackinawCPS.CoreFeatures.ZoneChannelAssignment;

namespace ConstraintHelper
{
	// Token: 0x020005E8 RID: 1512
	public static class UtilityMack
	{
		// Token: 0x170068AD RID: 26797
		// (get) Token: 0x0600D060 RID: 53344 RVA: 0x00C1CB24 File Offset: 0x00C1AD24
		public static bool IsOpenFromRmcOrInCxfEditingMode
		{
			get
			{
				if (!global::ConstraintHelper.UtilityMack.bOpenFromRMC)
				{
					short num = (short)573877983;
					short num2 = num;
					num = (short)1625665247;
					switch ((num2 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						break;
					default:
					{
						num = (short)1524367361;
						if (num != 0)
						{
						}
						num = (short)413597696;
						if (num != 0)
						{
						}
						num = (short)1580466176;
						short num3 = num;
						break;
					}
					}
					return global::ConstraintHelper.UtilityMack.isInCxfEditingMode;
				}
				return true;
			}
		}

		// Token: 0x170068AE RID: 26798
		// (get) Token: 0x0600D061 RID: 53345 RVA: 0x00C1CBE0 File Offset: 0x00C1ADE0
		// (set) Token: 0x0600D062 RID: 53346 RVA: 0x00C1CC90 File Offset: 0x00C1AE90
		public static string DVRSExportPath
		{
			get
			{
				short num = (short)631224258;
				short num2 = num;
				num = (short)1943058370;
				switch (num2 == num)
				{
				}
				num = (short)1286799360;
				short num3 = num;
				num = (short)1284898816;
				if (num != 0)
				{
				}
				num = (short)1951268865;
				if (num != 0)
				{
				}
				return global::ConstraintHelper.UtilityMack.g;
			}
			set
			{
				short num = (short)1110092406;
				short num2 = num;
				num = (short)80718454;
				switch (num2 == num)
				{
				}
				num = (short)1407254528;
				short num3 = num;
				num = (short)1109196801;
				if (num != 0)
				{
				}
				num = (short)875298816;
				if (num != 0)
				{
				}
				global::ConstraintHelper.UtilityMack.g = value;
			}
		}

		// Token: 0x170068AF RID: 26799
		// (get) Token: 0x0600D063 RID: 53347 RVA: 0x00C1CD44 File Offset: 0x00C1AF44
		// (set) Token: 0x0600D064 RID: 53348 RVA: 0x00C1CDF0 File Offset: 0x00C1AFF0
		public static bool IsDVRSHwEnabled
		{
			get
			{
				short num = (short)1163395329;
				short num2 = num;
				num = (short)1248592129;
				switch (num2 == num)
				{
				}
				num = (short)1854996480;
				short num3 = num;
				num = (short)2119434241;
				if (num != 0)
				{
				}
				num = (short)951255040;
				if (num != 0)
				{
				}
				return global::ConstraintHelper.UtilityMack.f;
			}
			set
			{
				int a_ = 10;
				switch (0)
				{
				case 0:
					goto IL_25;
				}
				int num;
				short num2;
				for (;;)
				{
					IL_13:
					switch (num)
					{
					case 0:
						goto IL_D4;
					case 1:
					{
						if (global::ConstraintHelper.UtilityMack.fireDVRSXMLProperty == null)
						{
							return;
						}
						num2 = (short)364059239;
						short num3 = num2;
						num2 = (short)1087642215;
						switch ((num3 == num2) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_D4;
						default:
							num2 = (short)507052032;
							if (num2 != 0)
							{
							}
							num2 = (short)1800339456;
							num = (int)((global::System.IntPtr)num2);
							continue;
						}
						break;
					}
					case 2:
						return;
					}
					goto IL_25;
					IL_D4:
					num2 = (short)252444672;
					short num4 = num2;
					global::ConstraintHelper.UtilityMack.fireDVRSXMLProperty(global::AllFeatures.CodeplugGuid.b("苊뻌诎蟐臒蛔鿖께黚돜뻞菠迢胤菦", a_));
					num2 = (short)1962999810;
					num = (int)((global::System.IntPtr)num2);
				}
				return;
				IL_25:
				global::ConstraintHelper.UtilityMack.f = value;
				num2 = (short)52494337;
				if (num2 != 0)
				{
				}
				num2 = (short)526516225;
				num = (int)((global::System.IntPtr)num2);
				goto IL_13;
			}
		}

		// Token: 0x170068B0 RID: 26800
		// (get) Token: 0x0600D065 RID: 53349 RVA: 0x00C1CF2C File Offset: 0x00C1B12C
		// (set) Token: 0x0600D066 RID: 53350 RVA: 0x00C1CFDC File Offset: 0x00C1B1DC
		public static bool IsDVRSHoptionEnabled
		{
			get
			{
				short num = (short)1664382266;
				short num2 = num;
				num = (short)1068791098;
				switch (num2 == num)
				{
				}
				num = (short)289472512;
				short num3 = num;
				num = (short)1434976257;
				if (num != 0)
				{
				}
				num = (short)578420736;
				if (num != 0)
				{
				}
				return global::ConstraintHelper.UtilityMack.e;
			}
			set
			{
				int a_ = 10;
				switch (0)
				{
				case 0:
					goto IL_25;
				}
				int num;
				short num2;
				for (;;)
				{
					IL_13:
					switch (num)
					{
					case 0:
						goto IL_D0;
					case 1:
					{
						if (global::ConstraintHelper.UtilityMack.fireDVRSXMLProperty == null)
						{
							return;
						}
						num2 = (short)1871202704;
						short num3 = num2;
						num2 = (short)542722448;
						switch ((num3 == num2) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_D0;
						default:
							num2 = (short)1322975232;
							if (num2 != 0)
							{
							}
							num2 = (short)1935671297;
							if (num2 != 0)
							{
							}
							num2 = (short)999817216;
							num = (int)((global::System.IntPtr)num2);
							continue;
						}
						break;
					}
					case 2:
						return;
					}
					goto IL_25;
					IL_D0:
					num2 = (short)1124663296;
					short num4 = num2;
					global::ConstraintHelper.UtilityMack.fireDVRSXMLProperty(global::AllFeatures.CodeplugGuid.b("苊뻌诎蟐臒蛔鿖뛘ꯚ꧜뛞軠跢ꃤ触裨觪臬諮闰", a_));
					num2 = (short)1600126978;
					num = (int)((global::System.IntPtr)num2);
				}
				return;
				IL_25:
				global::ConstraintHelper.UtilityMack.e = value;
				num2 = (short)818806785;
				num = (int)((global::System.IntPtr)num2);
				goto IL_13;
			}
		}

		// Token: 0x0600D067 RID: 53351 RVA: 0x00C1D118 File Offset: 0x00C1B318
		public static bool SystemKey()
		{
			short num = (short)1791197022;
			short num2 = num;
			num = (short)1180467038;
			switch (num2 == num)
			{
			}
			num = (short)1478295552;
			short num3 = num;
			num = (short)1575419905;
			if (num != 0)
			{
			}
			num = (short)260440064;
			if (num != 0)
			{
			}
			return true;
		}

		// Token: 0x0600D068 RID: 53352 RVA: 0x00C1D1C4 File Offset: 0x00C1B3C4
		public static bool IsPortable()
		{
			short num = (short)1075904513;
			if (num != 0)
			{
			}
			num = (short)1787234571;
			short num2 = num;
			num = (short)2076248331;
			switch (num2 == num)
			{
			default:
			{
				num = (short)755105792;
				short num3 = num;
				break;
			}
			case true:
				break;
			}
			num = (short)1762918400;
			if (num != 0)
			{
			}
			return global::ConstraintHelper.UtilityMack.IsPortablePro;
		}

		// Token: 0x0600D069 RID: 53353 RVA: 0x00C1D270 File Offset: 0x00C1B470
		public static bool IsPortableOnly()
		{
			if (global::ConstraintHelper.UtilityMack.IsPortablePro)
			{
				short num = (short)1076946324;
				short num2 = num;
				num = (short)885515668;
				switch ((num2 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					break;
				default:
				{
					num = (short)633274369;
					if (num != 0)
					{
					}
					num = (short)74514432;
					if (num != 0)
					{
					}
					num = (short)995295232;
					short num3 = num;
					break;
				}
				}
				return !global::ConstraintHelper.UtilityMack.IsMobilePro;
			}
			return false;
		}

		// Token: 0x0600D06A RID: 53354 RVA: 0x00C1D334 File Offset: 0x00C1B534
		public static bool IsMobile()
		{
			short num = (short)1102606593;
			short num2 = num;
			num = (short)1673687297;
			switch (num2 == num)
			{
			}
			num = (short)1007878144;
			short num3 = num;
			num = (short)1729888257;
			if (num != 0)
			{
			}
			num = (short)85524480;
			if (num != 0)
			{
			}
			return global::ConstraintHelper.UtilityMack.IsMobilePro;
		}

		// Token: 0x0600D06B RID: 53355 RVA: 0x00C1D3E0 File Offset: 0x00C1B5E0
		public static bool IsMobileOnly()
		{
			if (!global::ConstraintHelper.UtilityMack.IsPortablePro)
			{
				short num = (short)1962338972;
				short num2 = num;
				num = (short)1581050524;
				switch ((num2 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					break;
				default:
				{
					num = (short)1514078208;
					if (num != 0)
					{
					}
					num = (short)1247019009;
					if (num != 0)
					{
					}
					num = (short)596246528;
					short num3 = num;
					break;
				}
				}
				return global::ConstraintHelper.UtilityMack.IsMobilePro;
			}
			return false;
		}

		// Token: 0x170068B1 RID: 26801
		// (get) Token: 0x0600D06C RID: 53356 RVA: 0x00C1D4A0 File Offset: 0x00C1B6A0
		public static bool IsPortablePro
		{
			get
			{
				short num = (short)665809994;
				short num2 = num;
				num = (short)617509962;
				switch (num2 == num)
				{
				}
				num = (short)1106051072;
				short num3 = num;
				num = (short)1259732993;
				if (num != 0)
				{
				}
				num = (short)240648192;
				if (num != 0)
				{
				}
				return global::ConstraintHelper.UtilityMack.a;
			}
		}

		// Token: 0x170068B2 RID: 26802
		// (get) Token: 0x0600D06D RID: 53357 RVA: 0x00C1D550 File Offset: 0x00C1B750
		public static bool IsMobilePro
		{
			get
			{
				short num = (short)762249217;
				if (num != 0)
				{
				}
				num = (short)952892133;
				short num2 = num;
				num = (short)1698233061;
				switch (num2 == num)
				{
				default:
				{
					num = (short)743047168;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)1513947136;
				if (num != 0)
				{
				}
				return global::ConstraintHelper.UtilityMack.b;
			}
		}

		// Token: 0x170068B3 RID: 26803
		// (get) Token: 0x0600D06E RID: 53358 RVA: 0x00C1D600 File Offset: 0x00C1B800
		// (set) Token: 0x0600D06F RID: 53359 RVA: 0x00C1D6AC File Offset: 0x00C1B8AC
		public static string ProductModelId
		{
			get
			{
				short num = (short)287215991;
				short num2 = num;
				num = (short)256807287;
				switch (num2 == num)
				{
				}
				num = (short)1203896320;
				short num3 = num;
				num = (short)1100152832;
				if (num != 0)
				{
				}
				num = (short)631767041;
				if (num != 0)
				{
				}
				return global::ConstraintHelper.UtilityMack.d;
			}
			set
			{
				int a_ = 13;
				switch (0)
				{
				case 0:
					goto IL_405;
				}
				int num;
				uint num2;
				short num3;
				for (;;)
				{
					IL_13:
					switch (num)
					{
					case 0:
						goto IL_F88;
					case 1:
						if (num2 != 518729469U)
						{
							num3 = (short)1915420749;
							num = (int)((global::System.IntPtr)num3);
							continue;
						}
						num3 = (short)1340080218;
						num = (int)((global::System.IntPtr)num3);
						continue;
					case 2:
						if (!(value == global::AllFeatures.CodeplugGuid.b("﷍", a_)))
						{
							num3 = (short)1787691016;
							num = (int)((global::System.IntPtr)num3);
							continue;
						}
						goto IL_20A9;
					case 3:
						goto IL_274D;
					case 4:
						num3 = (short)1113849949;
						num = (int)((global::System.IntPtr)num3);
						continue;
					case 5:
						if (num2 != 401286136U)
						{
							num3 = (short)168165525;
							num = (int)((global::System.IntPtr)num3);
							continue;
						}
						num3 = (short)370999498;
						num = (int)((global::System.IntPtr)num3);
						continue;
					case 6:
						goto IL_DA9;
					case 7:
						goto IL_47F;
					case 8:
						num3 = (short)1841496129;
						num = (int)((global::System.IntPtr)num3);
						continue;
					case 9:
						goto IL_2090;
					case 10:
						num3 = (short)1302986890;
						num = (int)((global::System.IntPtr)num3);
						continue;
					case 11:
						num3 = (short)1518731366;
						num = (int)((global::System.IntPtr)num3);
						continue;
					case 12:
						if (num2 <= 468396612U)
						{
							num3 = (short)1407057987;
							num = (int)((global::System.IntPtr)num3);
							continue;
						}
						num3 = (short)1081147626;
						num = (int)((global::System.IntPtr)num3);
						continue;
					case 13:
						num3 = (short)253296790;
						num = (int)((global::System.IntPtr)num3);
						continue;
					case 14:
						num3 = (short)1654456570;
						num = (int)((global::System.IntPtr)num3);
						continue;
					case 15:
						num3 = (short)1267728430;
						num = (int)((global::System.IntPtr)num3);
						continue;
					case 16:
						if (!(value == global::AllFeatures.CodeplugGuid.b("ﳍ", a_)))
						{
							num3 = (short)142409869;
							num = (int)((global::System.IntPtr)num3);
							continue;
						}
						goto IL_1E91;
					case 17:
						if (!(value == global::AllFeatures.CodeplugGuid.b("ﳍ", a_)))
						{
							num3 = (short)1501888678;
							num = (int)((global::System.IntPtr)num3);
							continue;
						}
						goto IL_705;
					case 18:
						if (num2 <= 2347931225U)
						{
							num3 = (short)2145583180;
							num = (int)((global::System.IntPtr)num3);
							continue;
						}
						num3 = (short)1560019124;
						num = (int)((global::System.IntPtr)num3);
						continue;
					case 19:
						num3 = (short)783548575;
						num = (int)((global::System.IntPtr)num3);
						continue;
					case 20:
					{
						num3 = (short)570041795;
						short num4 = num3;
						num3 = (short)631252419;
						switch ((num4 == num3) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_2298;
						default:
							num3 = (short)693043200;
							if (num3 != 0)
							{
							}
							if (!(value == global::AllFeatures.CodeplugGuid.b("﷍", a_)))
							{
								num3 = (short)1707147390;
								num = (int)((global::System.IntPtr)num3);
								continue;
							}
							goto IL_27B2;
						}
						break;
					}
					case 21:
						if (!(value == global::AllFeatures.CodeplugGuid.b("ﳍ", a_)))
						{
							num3 = (short)1191641192;
							num = (int)((global::System.IntPtr)num3);
							continue;
						}
						goto IL_2095;
					case 22:
						if (num2 != 2247118416U)
						{
							num3 = (short)286982192;
							num = (int)((global::System.IntPtr)num3);
							continue;
						}
						num3 = (short)1204486204;
						num = (int)((global::System.IntPtr)num3);
						continue;
					case 23:
						if (!(value == global::AllFeatures.CodeplugGuid.b("﷍", a_)))
						{
							num3 = (short)879296686;
							num = (int)((global::System.IntPtr)num3);
							continue;
						}
						goto IL_2311;
					case 24:
						num3 = (short)1110114405;
						num = (int)((global::System.IntPtr)num3);
						continue;
					case 25:
						num3 = (short)730136804;
						num = (int)((global::System.IntPtr)num3);
						continue;
					case 26:
						goto IL_11C7;
					case 27:
						num3 = (short)623902838;
						num = (int)((global::System.IntPtr)num3);
						continue;
					case 28:
						if (!(value == global::AllFeatures.CodeplugGuid.b("ￍ", a_)))
						{
							num3 = (short)450691204;
							num = (int)((global::System.IntPtr)num3);
							continue;
						}
						goto IL_2400;
					case 29:
						num3 = (short)175636483;
						num = (int)((global::System.IntPtr)num3);
						continue;
					case 30:
						num3 = (short)1649344709;
						num = (int)((global::System.IntPtr)num3);
						continue;
					case 31:
						if (num2 != 2297598368U)
						{
							num3 = (short)59703512;
							num = (int)((global::System.IntPtr)num3);
							continue;
						}
						num3 = (short)1226309696;
						num = (int)((global::System.IntPtr)num3);
						continue;
					case 32:
						goto IL_1DC5;
					case 33:
						if (num2 <= 2331153606U)
						{
							num3 = (short)842465456;
							num = (int)((global::System.IntPtr)num3);
							continue;
						}
						num3 = (short)518324258;
						num = (int)((global::System.IntPtr)num3);
						continue;
					case 34:
						if (num2 <= 2381486463U)
						{
							num3 = (short)587727008;
							num = (int)((global::System.IntPtr)num3);
							continue;
						}
						num3 = (short)1086586964;
						num = (int)((global::System.IntPtr)num3);
						continue;
					case 35:
						goto IL_1D48;
					case 36:
						num3 = (short)199229657;
						num = (int)((global::System.IntPtr)num3);
						continue;
					case 37:
						goto IL_EB4;
					case 38:
						goto IL_1764;
					case 39:
						goto IL_C37;
					case 40:
						num3 = (short)987627527;
						num = (int)((global::System.IntPtr)num3);
						continue;
					case 41:
						if (num2 != 2297451273U)
						{
							num3 = (short)2084110409;
							num = (int)((global::System.IntPtr)num3);
							continue;
						}
						num3 = (short)2126774494;
						num = (int)((global::System.IntPtr)num3);
						continue;
					case 42:
						if (num2 != 890022063U)
						{
							num3 = (short)987496562;
							num = (int)((global::System.IntPtr)num3);
							continue;
						}
						num3 = (short)372310077;
						num = (int)((global::System.IntPtr)num3);
						continue;
					case 43:
						if (!(value == global::AllFeatures.CodeplugGuid.b("﯍", a_)))
						{
							num3 = (short)1578565700;
							num = (int)((global::System.IntPtr)num3);
							continue;
						}
						goto IL_4C3;
					case 44:
						num3 = (short)858849415;
						num = (int)((global::System.IntPtr)num3);
						continue;
					case 45:
						num3 = (short)130744321;
						if (num3 != 0)
						{
						}
						num3 = (short)1359216794;
						num = (int)((global::System.IntPtr)num3);
						continue;
					case 46:
						goto IL_1BC5;
					case 47:
						goto IL_700;
					case 48:
						num3 = (short)2359466;
						num = (int)((global::System.IntPtr)num3);
						continue;
					case 49:
						if (!(value == global::AllFeatures.CodeplugGuid.b("﷍", a_)))
						{
							num3 = (short)1073086705;
							num = (int)((global::System.IntPtr)num3);
							continue;
						}
						goto IL_61D;
					case 50:
						num3 = (short)1808400628;
						num = (int)((global::System.IntPtr)num3);
						continue;
					case 51:
						num3 = (short)770506847;
						num = (int)((global::System.IntPtr)num3);
						continue;
					case 52:
						num3 = (short)366280793;
						num = (int)((global::System.IntPtr)num3);
						continue;
					case 53:
						if (!(value == global::AllFeatures.CodeplugGuid.b("ￍ", a_)))
						{
							num3 = (short)2089877679;
							num = (int)((global::System.IntPtr)num3);
							continue;
						}
						goto IL_1738;
					case 54:
						num3 = (short)1743454307;
						num = (int)((global::System.IntPtr)num3);
						continue;
					case 55:
						num3 = (short)1709572254;
						num = (int)((global::System.IntPtr)num3);
						continue;
					case 56:
						num3 = (short)224133328;
						num = (int)((global::System.IntPtr)num3);
						continue;
					case 57:
						if (num2 != 1007465396U)
						{
							num3 = (short)1718812735;
							num = (int)((global::System.IntPtr)num3);
							continue;
						}
						num3 = (short)322568277;
						num = (int)((global::System.IntPtr)num3);
						continue;
					case 58:
						num3 = (short)1051132149;
						num = (int)((global::System.IntPtr)num3);
						continue;
					case 59:
						if (num2 != 334175660U)
						{
							num3 = (short)409665566;
							num = (int)((global::System.IntPtr)num3);
							continue;
						}
						num3 = (short)243728412;
						num = (int)((global::System.IntPtr)num3);
						continue;
					case 60:
						if (!(value == global::AllFeatures.CodeplugGuid.b("﷍", a_)))
						{
							num3 = (short)901644511;
							num = (int)((global::System.IntPtr)num3);
							continue;
						}
						goto IL_1D1B;
					case 61:
						if (!(value == global::AllFeatures.CodeplugGuid.b("ﻍ", a_)))
						{
							num3 = (short)741933283;
							num = (int)((global::System.IntPtr)num3);
							continue;
						}
						goto IL_1FFB;
					case 62:
						if (!(value == global::AllFeatures.CodeplugGuid.b("ﳍ", a_)))
						{
							num3 = (short)802488562;
							num = (int)((global::System.IntPtr)num3);
							continue;
						}
						goto IL_565;
					case 63:
						num3 = (short)610205861;
						num = (int)((global::System.IntPtr)num3);
						continue;
					case 64:
						if (!(value == global::AllFeatures.CodeplugGuid.b("ﳍ", a_)))
						{
							num3 = (short)2097676459;
							num = (int)((global::System.IntPtr)num3);
							continue;
						}
						goto IL_2467;
					case 65:
						goto IL_DFF;
					case 66:
						goto IL_1224;
					case 67:
						num3 = (short)1735524563;
						num = (int)((global::System.IntPtr)num3);
						continue;
					case 68:
						num3 = (short)1047593133;
						num = (int)((global::System.IntPtr)num3);
						continue;
					case 69:
						goto IL_FA5;
					case 70:
						if (num2 <= 1024243015U)
						{
							num3 = (short)1010106562;
							num = (int)((global::System.IntPtr)num3);
							continue;
						}
						num3 = (short)1986199585;
						num = (int)((global::System.IntPtr)num3);
						continue;
					case 71:
						num3 = (short)629539014;
						num = (int)((global::System.IntPtr)num3);
						continue;
					case 72:
						num3 = (short)1432879113;
						num = (int)((global::System.IntPtr)num3);
						continue;
					case 73:
						num3 = (short)589037615;
						num = (int)((global::System.IntPtr)num3);
						continue;
					case 74:
						goto IL_EED;
					case 75:
						num3 = (short)513605719;
						num = (int)((global::System.IntPtr)num3);
						continue;
					case 76:
						num3 = (short)1998586020;
						num = (int)((global::System.IntPtr)num3);
						continue;
					case 77:
						num3 = (short)297992411;
						num = (int)((global::System.IntPtr)num3);
						continue;
					case 78:
						goto IL_26E3;
					case 79:
						goto IL_462;
					case 80:
						goto IL_DC5;
					case 81:
						num3 = (short)2022768671;
						num = (int)((global::System.IntPtr)num3);
						continue;
					case 82:
						if (num2 != 2381486463U)
						{
							num3 = (short)1840447605;
							num = (int)((global::System.IntPtr)num3);
							continue;
						}
						num3 = (short)247922705;
						num = (int)((global::System.IntPtr)num3);
						continue;
					case 83:
						if (num2 != 906799682U)
						{
							num3 = (short)1285750855;
							num = (int)((global::System.IntPtr)num3);
							continue;
						}
						num3 = (short)1637941427;
						num = (int)((global::System.IntPtr)num3);
						continue;
					case 84:
						if (num2 <= 2415041701U)
						{
							num3 = (short)1381629988;
							num = (int)((global::System.IntPtr)num3);
							continue;
						}
						num3 = (short)1738211517;
						num = (int)((global::System.IntPtr)num3);
						continue;
					case 85:
						if (!(value == global::AllFeatures.CodeplugGuid.b("", a_)))
						{
							num3 = (short)1263599807;
							num = (int)((global::System.IntPtr)num3);
							continue;
						}
						goto IL_CDD;
					case 86:
						num3 = (short)1370358008;
						num = (int)((global::System.IntPtr)num3);
						continue;
					case 87:
						goto IL_1AAC;
					case 88:
						if (num2 != 501951850U)
						{
							num3 = (short)1801781387;
							num = (int)((global::System.IntPtr)num3);
							continue;
						}
						num3 = (short)394199222;
						num = (int)((global::System.IntPtr)num3);
						continue;
					case 89:
						goto IL_27DE;
					case 90:
						if (!(value == global::AllFeatures.CodeplugGuid.b("ￍ", a_)))
						{
							num3 = (short)933822659;
							num = (int)((global::System.IntPtr)num3);
							continue;
						}
						goto IL_A50;
					case 91:
						if (num2 != 434841374U)
						{
							num3 = (short)264831076;
							num = (int)((global::System.IntPtr)num3);
							continue;
						}
						num3 = (short)562430098;
						num = (int)((global::System.IntPtr)num3);
						continue;
					case 92:
						if (num2 != 873244444U)
						{
							num3 = (short)1484587021;
							num = (int)((global::System.IntPtr)num3);
							continue;
						}
						num3 = (short)179044573;
						num = (int)((global::System.IntPtr)num3);
						continue;
					case 93:
						goto IL_1E8C;
					case 94:
						goto IL_948;
					case 95:
						if (num2 <= 822911587U)
						{
							num3 = (short)634519671;
							num = (int)((global::System.IntPtr)num3);
							continue;
						}
						num3 = (short)2087059601;
						num = (int)((global::System.IntPtr)num3);
						continue;
					case 96:
						if (!(value == global::AllFeatures.CodeplugGuid.b("", a_)))
						{
							num3 = (short)1759248520;
							num = (int)((global::System.IntPtr)num3);
							continue;
						}
						goto IL_C7C;
					case 97:
						goto IL_1321;
					case 98:
						num3 = (short)727318651;
						num = (int)((global::System.IntPtr)num3);
						continue;
					case 99:
						if (num2 != 822911587U)
						{
							num3 = (short)1614151690;
							num = (int)((global::System.IntPtr)num3);
							continue;
						}
						num3 = (short)83230910;
						num = (int)((global::System.IntPtr)num3);
						continue;
					case 100:
						num3 = (short)516882642;
						num = (int)((global::System.IntPtr)num3);
						continue;
					case 101:
						goto IL_1E2F;
					case 102:
						if (num2 <= 2263896035U)
						{
							num3 = (short)838205643;
							num = (int)((global::System.IntPtr)num3);
							continue;
						}
						num3 = (short)32702611;
						num = (int)((global::System.IntPtr)num3);
						continue;
					case 103:
						if (!(value == global::AllFeatures.CodeplugGuid.b("ￍ", a_)))
						{
							num3 = (short)1180631115;
							num = (int)((global::System.IntPtr)num3);
							continue;
						}
						goto IL_226D;
					case 104:
						num3 = (short)764805264;
						num = (int)((global::System.IntPtr)num3);
						continue;
					case 105:
						if (num2 != 2314375987U)
						{
							num3 = (short)2075394247;
							num = (int)((global::System.IntPtr)num3);
							continue;
						}
						num3 = (short)96141489;
						num = (int)((global::System.IntPtr)num3);
						continue;
					case 106:
						goto IL_F1D;
					case 107:
						num3 = (short)2011234310;
						num = (int)((global::System.IntPtr)num3);
						continue;
					case 108:
						if (!(value == global::AllFeatures.CodeplugGuid.b("ﳍ", a_)))
						{
							num3 = (short)1578631183;
							num = (int)((global::System.IntPtr)num3);
							continue;
						}
						goto IL_1BE7;
					case 109:
						num3 = (short)1512177780;
						num = (int)((global::System.IntPtr)num3);
						continue;
					case 110:
						num3 = (short)119013591;
						num = (int)((global::System.IntPtr)num3);
						continue;
					case 111:
						if (num2 != 856466825U)
						{
							num3 = (short)1434910898;
							num = (int)((global::System.IntPtr)num3);
							continue;
						}
						num3 = (short)1162805400;
						num = (int)((global::System.IntPtr)num3);
						continue;
					case 112:
						num3 = (short)416808960;
						num = (int)((global::System.IntPtr)num3);
						continue;
					case 113:
						if (!(value == global::AllFeatures.CodeplugGuid.b("ￍ", a_)))
						{
							num3 = (short)476184616;
							num = (int)((global::System.IntPtr)num3);
							continue;
						}
						goto IL_1C87;
					case 114:
						num3 = (short)826671187;
						num = (int)((global::System.IntPtr)num3);
						continue;
					case 115:
						num3 = (short)1630797906;
						num = (int)((global::System.IntPtr)num3);
						continue;
					case 116:
						goto IL_965;
					case 117:
						num3 = (short)1847066659;
						num = (int)((global::System.IntPtr)num3);
						continue;
					case 118:
						goto IL_133D;
					case 119:
						num3 = (short)1652949228;
						num = (int)((global::System.IntPtr)num3);
						continue;
					case 120:
						num3 = (short)860160074;
						num = (int)((global::System.IntPtr)num3);
						continue;
					case 121:
						if (num2 <= 2297451273U)
						{
							num3 = (short)945815563;
							num = (int)((global::System.IntPtr)num3);
							continue;
						}
						num3 = (short)1378091165;
						num = (int)((global::System.IntPtr)num3);
						continue;
					case 122:
						if (num2 != 923577301U)
						{
							num3 = (short)276758775;
							num = (int)((global::System.IntPtr)num3);
							continue;
						}
						num3 = (short)98828441;
						num = (int)((global::System.IntPtr)num3);
						continue;
					case 123:
						goto IL_21DE;
					case 124:
						num3 = (short)619118661;
						num = (int)((global::System.IntPtr)num3);
						continue;
					case 125:
						goto IL_118D;
					case 126:
						num3 = (short)1077346518;
						num = (int)((global::System.IntPtr)num3);
						continue;
					case 127:
						num3 = (short)378077226;
						num = (int)((global::System.IntPtr)num3);
						continue;
					case 128:
						if (!(value == global::AllFeatures.CodeplugGuid.b("ﳍ", a_)))
						{
							num3 = (short)700317808;
							num = (int)((global::System.IntPtr)num3);
							continue;
						}
						goto IL_184F;
					case 129:
						goto IL_1486;
					case 130:
						num3 = (short)1648951516;
						num = (int)((global::System.IntPtr)num3);
						continue;
					case 131:
						num3 = (short)2089877747;
						num = (int)((global::System.IntPtr)num3);
						continue;
					case 132:
						num3 = (short)1984364706;
						num = (int)((global::System.IntPtr)num3);
						continue;
					case 133:
						if (num2 != 2331006511U)
						{
							num3 = (short)1804795990;
							num = (int)((global::System.IntPtr)num3);
							continue;
						}
						num3 = (short)1805254658;
						num = (int)((global::System.IntPtr)num3);
						continue;
					case 134:
						goto IL_1240;
					case 135:
						if (num2 != 2414894606U)
						{
							num3 = (short)1958150199;
							num = (int)((global::System.IntPtr)num3);
							continue;
						}
						num3 = (short)366674062;
						num = (int)((global::System.IntPtr)num3);
						continue;
					case 136:
						num3 = (short)1822949473;
						num = (int)((global::System.IntPtr)num3);
						continue;
					case 137:
						if (num2 <= 873244444U)
						{
							num3 = (short)1548156979;
							num = (int)((global::System.IntPtr)num3);
							continue;
						}
						num3 = (short)1230504132;
						num = (int)((global::System.IntPtr)num3);
						continue;
					case 138:
						goto IL_1B48;
					case 139:
						num3 = (short)1088815105;
						num = (int)((global::System.IntPtr)num3);
						continue;
					case 140:
						if (!(value == global::AllFeatures.CodeplugGuid.b("ﳍ", a_)))
						{
							num3 = (short)448463074;
							num = (int)((global::System.IntPtr)num3);
							continue;
						}
						goto IL_AE1;
					case 141:
						num3 = (short)524812314;
						num = (int)((global::System.IntPtr)num3);
						continue;
					case 142:
						if (!(value == global::AllFeatures.CodeplugGuid.b("﷍", a_)))
						{
							num3 = (short)281870434;
							num = (int)((global::System.IntPtr)num3);
							continue;
						}
						goto IL_2414;
					case 143:
						goto IL_2074;
					case 144:
						goto IL_11A9;
					case 145:
						if (num2 != 839689206U)
						{
							num3 = (short)1470496997;
							num = (int)((global::System.IntPtr)num3);
							continue;
						}
						num3 = (short)322633912;
						num = (int)((global::System.IntPtr)num3);
						continue;
					case 146:
						if (!(value == global::AllFeatures.CodeplugGuid.b("ￍ", a_)))
						{
							num3 = (short)1725563000;
							num = (int)((global::System.IntPtr)num3);
							continue;
						}
						goto IL_609;
					case 147:
						if (num2 != 2280673654U)
						{
							num3 = (short)1576861826;
							num = (int)((global::System.IntPtr)num3);
							continue;
						}
						num3 = (short)775749815;
						num = (int)((global::System.IntPtr)num3);
						continue;
					case 148:
						num3 = (short)54657061;
						num = (int)((global::System.IntPtr)num3);
						continue;
					case 149:
						num3 = (short)1224671464;
						num = (int)((global::System.IntPtr)num3);
						continue;
					case 150:
						goto IL_DE2;
					case 151:
						num3 = (short)886964367;
						num = (int)((global::System.IntPtr)num3);
						continue;
					case 152:
						if (!(value == global::AllFeatures.CodeplugGuid.b("", a_)))
						{
							num3 = (short)694616256;
							num = (int)((global::System.IntPtr)num3);
							continue;
						}
						goto IL_861;
					case 153:
						if (!(value == global::AllFeatures.CodeplugGuid.b("ﳍ", a_)))
						{
							num3 = (short)1618215093;
							num = (int)((global::System.IntPtr)num3);
							continue;
						}
						goto IL_279E;
					case 154:
						if (num2 <= 350953279U)
						{
							num3 = (short)1190199545;
							num = (int)((global::System.IntPtr)num3);
							continue;
						}
						num3 = (short)264306693;
						num = (int)((global::System.IntPtr)num3);
						continue;
					case 155:
						if (!(value == global::AllFeatures.CodeplugGuid.b("ﳍ", a_)))
						{
							num3 = (short)1050542315;
							num = (int)((global::System.IntPtr)num3);
							continue;
						}
						goto IL_1D9A;
					case 156:
						num3 = (short)1591869531;
						num = (int)((global::System.IntPtr)num3);
						continue;
					case 157:
						if (num2 <= 2314228892U)
						{
							num3 = (short)920780881;
							num = (int)((global::System.IntPtr)num3);
							continue;
						}
						num3 = (short)853344361;
						num = (int)((global::System.IntPtr)num3);
						continue;
					case 158:
						if (num2 != 2415041701U)
						{
							num3 = (short)562561131;
							num = (int)((global::System.IntPtr)num3);
							continue;
						}
						num3 = (short)1594228876;
						num = (int)((global::System.IntPtr)num3);
						continue;
					case 159:
						goto IL_1CE5;
					case 160:
						num3 = (short)345964562;
						num = (int)((global::System.IntPtr)num3);
						continue;
					case 161:
						if (!(value == global::AllFeatures.CodeplugGuid.b("﷍", a_)))
						{
							num3 = (short)823853281;
							num = (int)((global::System.IntPtr)num3);
							continue;
						}
						goto IL_267A;
					case 162:
						goto IL_1304;
					case 163:
						if (!(value == global::AllFeatures.CodeplugGuid.b("ￍ", a_)))
						{
							num3 = (short)192217102;
							num = (int)((global::System.IntPtr)num3);
							continue;
						}
						goto IL_CF1;
					case 164:
						if (num2 != 2347784130U)
						{
							num3 = (short)923074728;
							num = (int)((global::System.IntPtr)num3);
							continue;
						}
						num3 = (short)395837601;
						num = (int)((global::System.IntPtr)num3);
						continue;
					case 165:
						goto IL_2298;
					case 166:
						num3 = (short)480575695;
						num = (int)((global::System.IntPtr)num3);
						continue;
					case 167:
						num3 = (short)1745617083;
						num = (int)((global::System.IntPtr)num3);
						continue;
					case 168:
						num3 = (short)732758234;
						num = (int)((global::System.IntPtr)num3);
						continue;
					case 169:
						num3 = (short)1128464590;
						num = (int)((global::System.IntPtr)num3);
						continue;
					case 170:
						if (num2 != 2263896035U)
						{
							num3 = (short)908066840;
							num = (int)((global::System.IntPtr)num3);
							continue;
						}
						num3 = (short)589234196;
						num = (int)((global::System.IntPtr)num3);
						continue;
					case 171:
						num3 = (short)2073559279;
						num = (int)((global::System.IntPtr)num3);
						continue;
					case 172:
						goto IL_2056;
					case 173:
						goto IL_ED1;
					case 174:
						num3 = (short)1157824544;
						num = (int)((global::System.IntPtr)num3);
						continue;
					case 175:
						num3 = (short)1252720720;
						num = (int)((global::System.IntPtr)num3);
						continue;
					case 176:
						num3 = (short)1724121209;
						num = (int)((global::System.IntPtr)num3);
						continue;
					case 177:
						if (!(value == global::AllFeatures.CodeplugGuid.b("ﳍ", a_)))
						{
							num3 = (short)814546996;
							num = (int)((global::System.IntPtr)num3);
							continue;
						}
						goto IL_EF2;
					case 178:
						num3 = (short)838139996;
						num = (int)((global::System.IntPtr)num3);
						continue;
					case 179:
						if (!(value == global::AllFeatures.CodeplugGuid.b("﷍", a_)))
						{
							num3 = (short)117768221;
							num = (int)((global::System.IntPtr)num3);
							continue;
						}
						goto IL_22BF;
					case 180:
						if (num2 != 2364561749U)
						{
							num3 = (short)243990765;
							num = (int)((global::System.IntPtr)num3);
							continue;
						}
						num3 = (short)1497694257;
						num = (int)((global::System.IntPtr)num3);
						continue;
					case 181:
						num3 = (short)721109;
						num = (int)((global::System.IntPtr)num3);
						continue;
					case 182:
						if (!(value == global::AllFeatures.CodeplugGuid.b("ￍ", a_)))
						{
							num3 = (short)900595716;
							num = (int)((global::System.IntPtr)num3);
							continue;
						}
						goto IL_1B99;
					case 183:
						if (!(value == global::AllFeatures.CodeplugGuid.b("﷍", a_)))
						{
							num3 = (short)156565744;
							num = (int)((global::System.IntPtr)num3);
							continue;
						}
						goto IL_190C;
					case 184:
						if (!(value == global::AllFeatures.CodeplugGuid.b("留", a_)))
						{
							num3 = (short)798687399;
							num = (int)((global::System.IntPtr)num3);
							continue;
						}
						goto IL_14C9;
					case 185:
						goto IL_19D4;
					case 186:
						if (num2 != 2314228892U)
						{
							num3 = (short)872611896;
							num = (int)((global::System.IntPtr)num3);
							continue;
						}
						num3 = (short)588382420;
						num = (int)((global::System.IntPtr)num3);
						continue;
					case 187:
						goto IL_648;
					case 188:
						num3 = (short)1144782914;
						num = (int)((global::System.IntPtr)num3);
						continue;
					case 189:
						if (num2 != 2431672225U)
						{
							num3 = (short)234618938;
							num = (int)((global::System.IntPtr)num3);
							continue;
						}
						num3 = (short)344522775;
						num = (int)((global::System.IntPtr)num3);
						continue;
					case 190:
						if (!(value == global::AllFeatures.CodeplugGuid.b("鬒", a_)))
						{
							num3 = (short)1158479899;
							num = (int)((global::System.IntPtr)num3);
							continue;
						}
						goto IL_140D;
					case 191:
						num3 = (short)1858535530;
						num = (int)((global::System.IntPtr)num3);
						continue;
					case 192:
						num3 = (short)967508046;
						num = (int)((global::System.IntPtr)num3);
						continue;
					case 193:
						if (!(value == global::AllFeatures.CodeplugGuid.b("鬒", a_)))
						{
							num3 = (short)1156776060;
							num = (int)((global::System.IntPtr)num3);
							continue;
						}
						goto IL_1A80;
					case 194:
						num3 = (short)2111897804;
						num = (int)((global::System.IntPtr)num3);
						continue;
					case 195:
						num3 = (short)1476067422;
						num = (int)((global::System.IntPtr)num3);
						continue;
					case 196:
						if (num2 <= 906799682U)
						{
							num3 = (short)1474429055;
							num = (int)((global::System.IntPtr)num3);
							continue;
						}
						num3 = (short)377421946;
						num = (int)((global::System.IntPtr)num3);
						continue;
					case 197:
						if (num2 != 350953279U)
						{
							num3 = (short)88932461;
							num = (int)((global::System.IntPtr)num3);
							continue;
						}
						num3 = (short)180420721;
						num = (int)((global::System.IntPtr)num3);
						continue;
					case 198:
						goto IL_6E4;
					case 199:
						num3 = (short)1398800517;
						num = (int)((global::System.IntPtr)num3);
						continue;
					case 200:
						goto IL_19F1;
					case 201:
						num3 = (short)724172841;
						num = (int)((global::System.IntPtr)num3);
						continue;
					case 202:
						if (!(value == global::AllFeatures.CodeplugGuid.b("ￍ", a_)))
						{
							num3 = (short)1730937020;
							num = (int)((global::System.IntPtr)num3);
							continue;
						}
						goto IL_200F;
					case 203:
						num3 = (short)1730871318;
						num = (int)((global::System.IntPtr)num3);
						continue;
					case 204:
						if (num2 <= 518729469U)
						{
							num3 = (short)1153761449;
							num = (int)((global::System.IntPtr)num3);
							continue;
						}
						num3 = (short)844824713;
						num = (int)((global::System.IntPtr)num3);
						continue;
					case 205:
						num3 = (short)1959198808;
						num = (int)((global::System.IntPtr)num3);
						continue;
					case 206:
						if (num2 <= 434841374U)
						{
							num3 = (short)366870573;
							num = (int)((global::System.IntPtr)num3);
							continue;
						}
						num3 = (short)1500250124;
						num = (int)((global::System.IntPtr)num3);
						continue;
					case 207:
						goto IL_2175;
					case 208:
						goto IL_B0D;
					case 209:
						goto IL_1CC7;
					case 210:
						goto IL_187A;
					case 211:
						if (num2 != 451618993U)
						{
							num3 = (short)1550188768;
							num = (int)((global::System.IntPtr)num3);
							continue;
						}
						num3 = (short)1668808757;
						num = (int)((global::System.IntPtr)num3);
						continue;
					case 212:
						if (!(value == global::AllFeatures.CodeplugGuid.b("﷍", a_)))
						{
							num3 = (short)1362886787;
							num = (int)((global::System.IntPtr)num3);
							continue;
						}
						goto IL_1C9B;
					case 213:
						goto IL_792;
					case 214:
						goto IL_1D02;
					case 215:
						goto IL_203A;
					case 216:
						num3 = (short)1494352058;
						num = (int)((global::System.IntPtr)num3);
						continue;
					case 217:
						if (num2 != 2398264082U)
						{
							num3 = (short)756482092;
							num = (int)((global::System.IntPtr)num3);
							continue;
						}
						num3 = (short)1525743678;
						num = (int)((global::System.IntPtr)num3);
						continue;
					case 218:
						if (num2 != 2347931225U)
						{
							num3 = (short)746979438;
							num = (int)((global::System.IntPtr)num3);
							continue;
						}
						num3 = (short)1458896912;
						num = (int)((global::System.IntPtr)num3);
						continue;
					case 219:
						goto IL_1F79;
					case 220:
						if (num2 != 2296612630U)
						{
							num3 = (short)115605705;
							num = (int)((global::System.IntPtr)num3);
							continue;
						}
						num3 = (short)986579137;
						num = (int)((global::System.IntPtr)num3);
						continue;
					case 221:
						if (!(value == global::AllFeatures.CodeplugGuid.b("ￍ", a_)))
						{
							num3 = (short)50856084;
							num = (int)((global::System.IntPtr)num3);
							continue;
						}
						goto IL_719;
					case 222:
						if (!(value == global::AllFeatures.CodeplugGuid.b("﷍", a_)))
						{
							num3 = (short)1907359975;
							num = (int)((global::System.IntPtr)num3);
							continue;
						}
						goto IL_1D07;
					case 223:
						num3 = (short)1987379279;
						num = (int)((global::System.IntPtr)num3);
						continue;
					case 224:
						num3 = (short)1548615926;
						num = (int)((global::System.IntPtr)num3);
						continue;
					case 225:
						num3 = (short)584384712;
						num = (int)((global::System.IntPtr)num3);
						continue;
					case 226:
						num3 = (short)1454309548;
						num = (int)((global::System.IntPtr)num3);
						continue;
					case 227:
						num3 = (short)762839249;
						num = (int)((global::System.IntPtr)num3);
						continue;
					case 228:
						goto IL_1148;
					case 229:
						num3 = (short)1481506927;
						num = (int)((global::System.IntPtr)num3);
						continue;
					case 230:
						num3 = (short)1487077561;
						num = (int)((global::System.IntPtr)num3);
						continue;
					case 231:
						num3 = (short)1912930342;
						num = (int)((global::System.IntPtr)num3);
						continue;
					case 232:
						if (num2 != 418063755U)
						{
							num3 = (short)1728774300;
							num = (int)((global::System.IntPtr)num3);
							continue;
						}
						num3 = (short)253755555;
						num = (int)((global::System.IntPtr)num3);
						continue;
					case 233:
						if (!(value == global::AllFeatures.CodeplugGuid.b("ￍ", a_)))
						{
							num3 = (short)1263272087;
							num = (int)((global::System.IntPtr)num3);
							continue;
						}
						goto IL_20FD;
					case 234:
						if (num2 != 485174231U)
						{
							num3 = (short)1297088717;
							num = (int)((global::System.IntPtr)num3);
							continue;
						}
						num3 = (short)1943994471;
						num = (int)((global::System.IntPtr)num3);
						continue;
					case 235:
						num3 = (short)1329463425;
						num = (int)((global::System.IntPtr)num3);
						continue;
					case 236:
						if (num2 != 806133968U)
						{
							num3 = (short)1487470646;
							num = (int)((global::System.IntPtr)num3);
							continue;
						}
						num3 = (short)1475018795;
						num = (int)((global::System.IntPtr)num3);
						continue;
					case 237:
						num3 = (short)1832583406;
						num = (int)((global::System.IntPtr)num3);
						continue;
					case 238:
						if (num2 != 2364708844U)
						{
							num3 = (short)1487536243;
							num = (int)((global::System.IntPtr)num3);
							continue;
						}
						num3 = (short)218431616;
						num = (int)((global::System.IntPtr)num3);
						continue;
					case 239:
						goto IL_2520;
					case 240:
						num3 = (short)379453565;
						num = (int)((global::System.IntPtr)num3);
						continue;
					case 241:
						num3 = (short)2128347270;
						num = (int)((global::System.IntPtr)num3);
						continue;
					case 242:
						num3 = (short)1935802407;
						num = (int)((global::System.IntPtr)num3);
						continue;
					case 243:
						goto IL_A0D;
					case 244:
						if (num2 != 2515707415U)
						{
							num3 = (short)2108948505;
							num = (int)((global::System.IntPtr)num3);
							continue;
						}
						num3 = (short)2061369452;
						num = (int)((global::System.IntPtr)num3);
						continue;
					case 245:
						if (num2 != 2498929796U)
						{
							num3 = (short)697237554;
							num = (int)((global::System.IntPtr)num3);
							continue;
						}
						num3 = (short)1647050773;
						num = (int)((global::System.IntPtr)num3);
						continue;
					case 246:
						if (num2 != 468396612U)
						{
							num3 = (short)1115160806;
							num = (int)((global::System.IntPtr)num3);
							continue;
						}
						num3 = (short)1471217897;
						num = (int)((global::System.IntPtr)num3);
						continue;
					case 247:
						num3 = (short)119537721;
						num = (int)((global::System.IntPtr)num3);
						continue;
					case 248:
						if (num2 != 2331153606U)
						{
							num3 = (short)159318035;
							num = (int)((global::System.IntPtr)num3);
							continue;
						}
						num3 = (short)755826843;
						num = (int)((global::System.IntPtr)num3);
						continue;
					case 249:
						num3 = (short)317063227;
						num = (int)((global::System.IntPtr)num3);
						continue;
					case 250:
						goto IL_1BE2;
					}
					goto IL_405;
					IL_2298:
					if (num2 != 1024243015U)
					{
						num3 = (short)1019543624;
						num = (int)((global::System.IntPtr)num3);
					}
					else
					{
						num3 = (short)502595680;
						num = (int)((global::System.IntPtr)num3);
					}
				}
				IL_462:
				IL_47F:
				goto IL_2861;
				IL_4C3:
				global::ConstraintHelper.UtilityMack.d = global::AllFeatures.CodeplugGuid.b("迍胏諑", a_);
				return;
				IL_565:
				global::ConstraintHelper.UtilityMack.d = global::AllFeatures.CodeplugGuid.b("迍胏諑蓛雝", a_);
				return;
				IL_609:
				global::ConstraintHelper.UtilityMack.d = global::AllFeatures.CodeplugGuid.b("迍胏諑郛럝", a_);
				return;
				IL_61D:
				global::ConstraintHelper.UtilityMack.d = global::AllFeatures.CodeplugGuid.b("迍胏諑飕鷗苙裛ﻝ룟꟡", a_);
				return;
				IL_648:
				IL_6E4:
				IL_700:
				goto IL_2861;
				IL_705:
				global::ConstraintHelper.UtilityMack.d = global::AllFeatures.CodeplugGuid.b("迍胏諑ﳛ", a_);
				return;
				IL_719:
				global::ConstraintHelper.UtilityMack.d = global::AllFeatures.CodeplugGuid.b("迍胏諑", a_);
				return;
				IL_792:
				goto IL_2861;
				IL_861:
				global::ConstraintHelper.UtilityMack.d = global::AllFeatures.CodeplugGuid.b("迍胏諑", a_);
				return;
				IL_948:
				IL_965:
				IL_A0D:
				goto IL_2861;
				IL_A50:
				global::ConstraintHelper.UtilityMack.d = global::AllFeatures.CodeplugGuid.b("迍胏諑", a_);
				return;
				IL_AE1:
				global::ConstraintHelper.UtilityMack.d = global::AllFeatures.CodeplugGuid.b("迍胏諑", a_);
				return;
				IL_B0D:
				IL_C37:
				goto IL_2861;
				IL_C7C:
				global::ConstraintHelper.UtilityMack.d = global::AllFeatures.CodeplugGuid.b("鷍苏諑", a_);
				return;
				IL_CDD:
				global::ConstraintHelper.UtilityMack.d = global::AllFeatures.CodeplugGuid.b("迍胏諑", a_);
				return;
				IL_CF1:
				global::ConstraintHelper.UtilityMack.d = global::AllFeatures.CodeplugGuid.b("迍胏諑", a_);
				return;
				IL_DA9:
				IL_DC5:
				IL_DE2:
				IL_DFF:
				IL_EB4:
				IL_ED1:
				IL_EED:
				goto IL_2861;
				IL_EF2:
				global::ConstraintHelper.UtilityMack.d = global::AllFeatures.CodeplugGuid.b("迍胏諑", a_);
				return;
				IL_F1D:
				IL_F88:
				IL_FA5:
				goto IL_2861;
				IL_1148:
				num3 = (short)1213726720;
				short num5 = num3;
				IL_118D:
				IL_11A9:
				IL_11C7:
				IL_1224:
				IL_1240:
				IL_1304:
				IL_1321:
				IL_133D:
				goto IL_2861;
				IL_140D:
				global::ConstraintHelper.UtilityMack.d = global::AllFeatures.CodeplugGuid.b("迍胏諑蓛鯝", a_);
				return;
				IL_1486:
				goto IL_2861;
				IL_14C9:
				global::ConstraintHelper.UtilityMack.d = global::AllFeatures.CodeplugGuid.b("迍胏諑蓛鯝", a_);
				return;
				IL_1738:
				global::ConstraintHelper.UtilityMack.d = global::AllFeatures.CodeplugGuid.b("迍胏諑郛럝", a_);
				return;
				IL_1764:
				goto IL_2861;
				IL_184F:
				global::ConstraintHelper.UtilityMack.d = global::AllFeatures.CodeplugGuid.b("迍胏諑ﳛ", a_);
				return;
				IL_187A:
				goto IL_2861;
				IL_190C:
				global::ConstraintHelper.UtilityMack.d = global::AllFeatures.CodeplugGuid.b("迍胏諑铛蛝ꗟ", a_);
				return;
				IL_19D4:
				IL_19F1:
				goto IL_2861;
				IL_1A80:
				global::ConstraintHelper.UtilityMack.d = global::AllFeatures.CodeplugGuid.b("迍胏諑飕", a_);
				return;
				IL_1AAC:
				IL_1B48:
				goto IL_2861;
				IL_1B99:
				global::ConstraintHelper.UtilityMack.d = global::AllFeatures.CodeplugGuid.b("迍胏諑郛럝", a_);
				return;
				IL_1BC5:
				IL_1BE2:
				goto IL_2861;
				IL_1BE7:
				global::ConstraintHelper.UtilityMack.d = global::AllFeatures.CodeplugGuid.b("飍뗏ꃑꃓ돕ꃗ", a_);
				return;
				IL_1C87:
				global::ConstraintHelper.UtilityMack.d = global::AllFeatures.CodeplugGuid.b("迍胏諑", a_);
				return;
				IL_1C9B:
				global::ConstraintHelper.UtilityMack.d = global::AllFeatures.CodeplugGuid.b("迍胏諑飕鷗苙裛", a_);
				return;
				IL_1CC7:
				IL_1CE5:
				IL_1D02:
				goto IL_2861;
				IL_1D07:
				global::ConstraintHelper.UtilityMack.d = global::AllFeatures.CodeplugGuid.b("迍蓏臑곛", a_);
				return;
				IL_1D1B:
				global::ConstraintHelper.UtilityMack.d = global::AllFeatures.CodeplugGuid.b("迍胏諑뗛", a_);
				return;
				IL_1D48:
				goto IL_2861;
				IL_1D9A:
				global::ConstraintHelper.UtilityMack.d = global::AllFeatures.CodeplugGuid.b("迍胏諑", a_);
				return;
				IL_1DC5:
				IL_1E2F:
				IL_1E8C:
				goto IL_2861;
				IL_1E91:
				global::ConstraintHelper.UtilityMack.d = global::AllFeatures.CodeplugGuid.b("迍胏諑蓛鯝", a_);
				return;
				IL_1F79:
				goto IL_2861;
				IL_1FFB:
				global::ConstraintHelper.UtilityMack.d = global::AllFeatures.CodeplugGuid.b("迍胏諑", a_);
				return;
				IL_200F:
				global::ConstraintHelper.UtilityMack.d = global::AllFeatures.CodeplugGuid.b("迍胏諑", a_);
				return;
				IL_203A:
				IL_2056:
				IL_2074:
				IL_2090:
				goto IL_2861;
				IL_2095:
				global::ConstraintHelper.UtilityMack.d = global::AllFeatures.CodeplugGuid.b("迍胏諑铛", a_);
				return;
				IL_20A9:
				global::ConstraintHelper.UtilityMack.d = global::AllFeatures.CodeplugGuid.b("迍胏諑飕鷗苙裛ﻝ룟곡", a_);
				return;
				IL_20FD:
				global::ConstraintHelper.UtilityMack.d = global::AllFeatures.CodeplugGuid.b("迍胏諑", a_);
				return;
				IL_2175:
				IL_21DE:
				goto IL_2861;
				IL_226D:
				global::ConstraintHelper.UtilityMack.d = global::AllFeatures.CodeplugGuid.b("迍胏諑郛럝", a_);
				return;
				IL_22BF:
				global::ConstraintHelper.UtilityMack.d = global::AllFeatures.CodeplugGuid.b("迍胏諑", a_);
				return;
				IL_2311:
				global::ConstraintHelper.UtilityMack.d = global::AllFeatures.CodeplugGuid.b("迍胏諑飕", a_);
				return;
				IL_2400:
				global::ConstraintHelper.UtilityMack.d = global::AllFeatures.CodeplugGuid.b("髍裏鿑", a_);
				return;
				IL_2414:
				global::ConstraintHelper.UtilityMack.d = global::AllFeatures.CodeplugGuid.b("迍胏諑飕", a_);
				return;
				IL_2467:
				global::ConstraintHelper.UtilityMack.d = global::AllFeatures.CodeplugGuid.b("迍胏諑ﳛ", a_);
				return;
				IL_2520:
				goto IL_2861;
				IL_267A:
				global::ConstraintHelper.UtilityMack.d = global::AllFeatures.CodeplugGuid.b("髍裏鿑", a_);
				return;
				IL_26E3:
				IL_274D:
				goto IL_2861;
				IL_279E:
				global::ConstraintHelper.UtilityMack.d = global::AllFeatures.CodeplugGuid.b("迍胏諑", a_);
				return;
				IL_27B2:
				global::ConstraintHelper.UtilityMack.d = global::AllFeatures.CodeplugGuid.b("迍胏諑飕鷗苙裛", a_);
				return;
				IL_27DE:
				IL_2861:
				global::ConstraintHelper.UtilityMack.d = global::AllFeatures.CodeplugGuid.b("蟍뻏뇑믓ꓕ꫗뿙뿛ꫝ샟꿡诣若跧蛩쳫꟭듯", a_);
				return;
				IL_405:
				num2 = global::<PrivateImplementationDetails>.ComputeStringHash(value);
				num3 = (short)1461190726;
				num = (int)((global::System.IntPtr)num3);
				goto IL_13;
			}
		}

		// Token: 0x170068B4 RID: 26804
		// (get) Token: 0x0600D070 RID: 53360 RVA: 0x00C1FF30 File Offset: 0x00C1E130
		public static bool IsAPXNEXT
		{
			get
			{
				short num = (short)974913538;
				int num2 = (int)((global::System.IntPtr)num);
				for (;;)
				{
					switch (num2)
					{
					case 0:
						goto IL_A7;
					case 1:
						num = (short)1030619141;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 2:
						switch (0)
						{
						case 0:
							goto IL_3D;
						}
						continue;
					case 3:
						if (!(global::ConstraintHelper.UtilityMack.ProductModelId == global::CommonResources.AcgResources.ID_APXNEXTXN))
						{
							num = (short)1433665537;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return true;
					case 4:
						num = (short)707919875;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 5:
					{
						if (global::ConstraintHelper.UtilityMack.ProductModelId == global::CommonResources.AcgResources.ID_APXNEXTXE)
						{
							num = (short)1516568576;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)1575388076;
						short num3 = num;
						num = (short)1910408108;
						switch ((num3 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_3D;
						case 1:
							goto IL_174;
						}
						goto Block_4;
					}
					}
					IL_3D:
					if (global::ConstraintHelper.UtilityMack.ProductModelId == global::CommonResources.AcgResources.ID_APXNEXT)
					{
						break;
					}
					num = (short)58851332;
					num2 = (int)((global::System.IntPtr)num);
				}
				return true;
				IL_A7:
				num = (short)1238827009;
				if (num != 0)
				{
				}
				return true;
				Block_4:
				num = (short)1969750016;
				short num4 = num;
				IL_174:
				num = (short)577961984;
				if (num != 0)
				{
				}
				return false;
			}
		}

		// Token: 0x170068B5 RID: 26805
		// (get) Token: 0x0600D071 RID: 53361 RVA: 0x00C200CC File Offset: 0x00C1E2CC
		public static bool IsAPXNextOrAloha
		{
			get
			{
				short num = (short)1757020164;
				int num2 = (int)((global::System.IntPtr)num);
				for (;;)
				{
					switch (num2)
					{
					case 0:
						num = (short)1617428485;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 1:
					{
						num = (short)846647084;
						short num3 = num;
						num = (short)544984876;
						switch ((num3 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							return true;
						default:
							num = (short)1265303552;
							if (num != 0)
							{
							}
							num = (short)1292697601;
							if (num != 0)
							{
							}
							num = (short)1680605187;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						break;
					}
					case 2:
						num = (short)1989279750;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 3:
						if (!(global::ConstraintHelper.UtilityMack.ProductModelId == global::CommonResources.AcgResources.ID_APXN70))
						{
							num = (short)1647378434;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return true;
					case 4:
						switch (0)
						{
						case 0:
							goto IL_45;
						}
						continue;
					case 5:
						if (!(global::ConstraintHelper.UtilityMack.ProductModelId == global::CommonResources.AcgResources.ID_APXNEXTXN))
						{
							num = (short)1806499841;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return true;
					case 6:
						if (global::ConstraintHelper.UtilityMack.ProductModelId == global::CommonResources.AcgResources.ID_APXNEXTXE)
						{
							num = (short)1137836032;
							short num4 = num;
							num = (short)1593769991;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return false;
					case 7:
						return true;
					}
					IL_45:
					if (global::ConstraintHelper.UtilityMack.ProductModelId == global::CommonResources.AcgResources.ID_APXNEXT)
					{
						break;
					}
					num = (short)169869312;
					num2 = (int)((global::System.IntPtr)num);
				}
				return true;
			}
		}

		// Token: 0x170068B6 RID: 26806
		// (get) Token: 0x0600D072 RID: 53362 RVA: 0x00C202C0 File Offset: 0x00C1E4C0
		public static bool IsFreonRadio
		{
			get
			{
				short num;
				bool result;
				try
				{
					num = (short)499008862;
					short num2 = num;
					num = (short)43533662;
					switch (num2 == num)
					{
					}
					num = (short)1302528000;
					if (num != 0)
					{
					}
					result = global::ConstraintHelper.UtilityMack.IsFreonCodeplug((((global::Motorola.MackinawCPS.CoreFeatures.RadioInformation.RadioInformationRecset)global::AcpCommonLib.FeatureManager.GetFeature(2049))[0] as global::Motorola.MackinawCPS.CoreFeatures.RadioInformation.RadioInformation).General.RadInfoGeneralModelNumber_A8539.Value);
				}
				catch
				{
					result = false;
				}
				num = (short)1190723585;
				if (num != 0)
				{
				}
				num = (short)755105792;
				short num3 = num;
				return result;
			}
		}

		// Token: 0x170068B7 RID: 26807
		// (get) Token: 0x0600D073 RID: 53363 RVA: 0x00C203B0 File Offset: 0x00C1E5B0
		public static bool IsSingleOption8900MHzRadio
		{
			get
			{
				short num = (short)926181041;
				short num2 = num;
				num = (short)1158178481;
				switch (num2 == num)
				{
				}
				num = (short)955121665;
				if (num != 0)
				{
				}
				num = (short)1196228608;
				if (num != 0)
				{
				}
				num = (short)508231680;
				short num3 = num;
				return global::ConstraintHelper.UtilityMack.c;
			}
		}

		// Token: 0x170068B8 RID: 26808
		// (get) Token: 0x0600D074 RID: 53364 RVA: 0x00C20460 File Offset: 0x00C1E660
		// (set) Token: 0x0600D075 RID: 53365 RVA: 0x00C20510 File Offset: 0x00C1E710
		public static bool IsFreonCodeplugLayout
		{
			get
			{
				short num = (short)2008612865;
				if (num != 0)
				{
				}
				num = (short)1938748946;
				short num2 = num;
				num = (short)1323890194;
				switch (num2 == num)
				{
				}
				num = (short)784728064;
				if (num != 0)
				{
				}
				num = (short)1855520768;
				short num3 = num;
				return global::ConstraintHelper.UtilityMack.h;
			}
			set
			{
				short num = (short)1984208818;
				short num2 = num;
				num = (short)2128060338;
				switch (num2 == num)
				{
				}
				num = (short)1883897856;
				if (num != 0)
				{
				}
				num = (short)685637633;
				if (num != 0)
				{
				}
				num = (short)1065222144;
				short num3 = num;
				global::ConstraintHelper.UtilityMack.h = value;
			}
		}

		// Token: 0x0600D076 RID: 53366 RVA: 0x00C205C4 File Offset: 0x00C1E7C4
		public static bool IsFreonCodeplug(string strModelNumber)
		{
			int a_ = 9;
			short num = (short)1001062406;
			int num2 = (int)((global::System.IntPtr)num);
			bool result;
			for (;;)
			{
				string text;
				global::System.Collections.Generic.List<string>.Enumerator enumerator;
				switch (num2)
				{
				case 0:
					text = text.Remove(text.Length - 1);
					num = (short)1695481860;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 1:
					return false;
				case 2:
					num = (short)1273561089;
					if (num != 0)
					{
					}
					goto IL_27C;
				case 3:
					num = (short)1100152839;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 4:
					goto IL_71;
				case 5:
					if (text.EndsWith(global::AllFeatures.CodeplugGuid.b("菉", a_)))
					{
						num = (short)1310785536;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_71;
				case 6:
					switch (0)
					{
					case 0:
						goto IL_55;
					}
					continue;
				case 7:
					if (text.StartsWith(global::AllFeatures.CodeplugGuid.b("蟉ﻋ﯍", a_)))
					{
						num = (short)399114242;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_71;
				case 8:
					try
					{
						num = (short)894763011;
						num2 = (int)((global::System.IntPtr)num);
						for (;;)
						{
							switch (num2)
							{
							case 0:
								goto IL_269;
							case 1:
								goto IL_231;
							case 2:
							{
								if (!enumerator.MoveNext())
								{
									num = (short)586809345;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								num = (short)1423845361;
								short num3 = num;
								num = (short)1390684145;
								switch ((num3 == num) ? 1 : 0)
								{
								case 0:
								case 2:
									goto IL_231;
								default:
									num = (short)1173618688;
									if (num != 0)
									{
									}
									num = (short)749273093;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								break;
							}
							case 3:
								switch (0)
								{
								case 0:
									goto IL_163;
								}
								continue;
							case 4:
								goto IL_24D;
							case 5:
								if (enumerator.Current == text)
								{
									num = (short)447021062;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								break;
							case 6:
								result = true;
								num = (short)915275780;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							IL_1F6:
							num = (short)117178370;
							num2 = (int)((global::System.IntPtr)num);
							continue;
							IL_163:
							goto IL_1F6;
							IL_231:
							num = (short)912261120;
							num2 = (int)((global::System.IntPtr)num);
						}
						IL_24D:
						IL_269:
						goto IL_33B;
					}
					finally
					{
						((global::System.IDisposable)enumerator).Dispose();
					}
					goto IL_27C;
				case 9:
					if (!text.StartsWith(global::AllFeatures.CodeplugGuid.b("苉", a_)))
					{
						num = (short)1433600003;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_27C;
				}
				IL_55:
				if (strModelNumber == null)
				{
					num = (short)1942093825;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				text = strModelNumber.ToUpper().Trim();
				num = (short)1801650185;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_71:
				result = false;
				enumerator = global::Features.Common.MTFAliasList.Instance.GetFreonModelNumber().GetEnumerator();
				num = (short)2083061768;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_27C:
				num = (short)1504182277;
				num2 = (int)((global::System.IntPtr)num);
			}
			return false;
			IL_33B:
			num = (short)285343744;
			short num4 = num;
			return result;
		}

		// Token: 0x0600D077 RID: 53367 RVA: 0x00C20954 File Offset: 0x00C1EB54
		private static bool c(string A_0)
		{
			int a_ = 10;
			short num = (short)853934087;
			int num2 = (int)((global::System.IntPtr)num);
			string text;
			for (;;)
			{
				switch (num2)
				{
				case 0:
					num = (short)305659909;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 1:
					num = (short)1209532417;
					if (num != 0)
					{
					}
					if (!(text == global::AllFeatures.CodeplugGuid.b("菊﷎苐韒鏔觘賚點꿠", a_)))
					{
						num = (short)643170307;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					return true;
				case 2:
					goto IL_24F;
				case 3:
					num = (short)965869578;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 4:
					if (!(text == global::AllFeatures.CodeplugGuid.b("菊﷎蛐郒鏔觘賚點꿠", a_)))
					{
						num = (short)602472466;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					return true;
				case 5:
					if (!(text == global::AllFeatures.CodeplugGuid.b("菊﷎胐韒鷔觘賚點꿠", a_)))
					{
						num = (short)48693260;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					return true;
				case 6:
					if (!(text == global::AllFeatures.CodeplugGuid.b("菊﷎苐韒鷔觘賚點꿠", a_)))
					{
						num = (short)191168526;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					return true;
				case 7:
				{
					num = (short)492601892;
					short num3 = num;
					num = (short)646742564;
					switch ((num3 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_208;
					case 1:
						break;
					default:
					{
						num = (short)189267968;
						short num4 = num;
						break;
					}
					}
					num = (short)2137522176;
					if (num != 0)
					{
					}
					switch (0)
					{
					case 0:
						goto IL_F4;
					}
					continue;
				}
				case 8:
					num = (short)2031222795;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 9:
					num = (short)256573444;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 10:
					if (!(text == global::AllFeatures.CodeplugGuid.b("菊﷎髐韒鏔觘賚點꿠", a_)))
					{
						num = (short)133038089;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					return true;
				case 11:
					if (!(text == global::AllFeatures.CodeplugGuid.b("菊﷎胐韒鏔觘賚點꿠", a_)))
					{
						num = (short)742260749;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					return true;
				case 12:
					num = (short)224329734;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 13:
					num = (short)535560193;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 14:
					goto IL_208;
				case 15:
					if (!(text == global::AllFeatures.CodeplugGuid.b("菊﷎蓐郒鷔觘賚點꿠", a_)))
					{
						num = (short)1460076544;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					return true;
				case 16:
					return false;
				case 17:
					if (!(text == global::AllFeatures.CodeplugGuid.b("菊﷎蓐郒鏔觘賚點꿠", a_)))
					{
						num = (short)1941897224;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					return true;
				case 18:
					num = (short)2070609935;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 19:
					if (!(text == global::AllFeatures.CodeplugGuid.b("菊﷎髐韒鷔觘賚點꿠", a_)))
					{
						num = (short)1240989698;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					return true;
				}
				IL_F4:
				if (A_0 == null)
				{
					num = (short)1885601808;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				text = A_0.ToUpper().Trim();
				num = (short)2036662289;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_208:
				num = (short)1359151123;
				num2 = (int)((global::System.IntPtr)num);
			}
			return false;
			IL_24F:
			return text == global::AllFeatures.CodeplugGuid.b("菊﷎蛐郒鷔觘賚點꿠", a_);
		}

		// Token: 0x170068B9 RID: 26809
		// (get) Token: 0x0600D078 RID: 53368 RVA: 0x00C20D74 File Offset: 0x00C1EF74
		public static bool IsAPX900Radio
		{
			get
			{
				short num;
				bool result;
				try
				{
					num = (short)343579844;
					short num2 = num;
					num = (short)459447492;
					switch (num2 == num)
					{
					}
					num = (short)1655308288;
					if (num != 0)
					{
					}
					result = global::ConstraintHelper.UtilityMack.c((((global::Motorola.MackinawCPS.CoreFeatures.RadioInformation.RadioInformationRecset)global::AcpCommonLib.FeatureManager.GetFeature(2049))[0] as global::Motorola.MackinawCPS.CoreFeatures.RadioInformation.RadioInformation).General.RadInfoGeneralModelNumber_A8539.Value);
				}
				catch
				{
					result = false;
				}
				num = (short)8126465;
				if (num != 0)
				{
				}
				num = (short)1568604160;
				short num3 = num;
				return result;
			}
		}

		// Token: 0x0600D079 RID: 53369 RVA: 0x00C20E68 File Offset: 0x00C1F068
		public static bool IsMahaloCodeplug(string strModelNumber)
		{
			int a_ = 5;
			short num = (short)1435893762;
			int num2 = (int)((global::System.IntPtr)num);
			string text;
			for (;;)
			{
				num = (short)1304166401;
				if (num != 0)
				{
				}
				switch (num2)
				{
				case 0:
				{
					num = (short)1468019799;
					short num3 = num;
					num = (short)1332229207;
					switch ((num3 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						break;
					default:
						goto IL_14A;
					}
					break;
				}
				case 1:
					if (!(global::AllFeatures.CodeplugGuid.b("軅難￉駋跍雏蓓臕鯙鋛", a_) == text))
					{
						num = (short)1784479744;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					return true;
				case 2:
					switch (0)
					{
					case 0:
						goto IL_66;
					}
					continue;
				case 3:
					return false;
				}
				IL_66:
				if (strModelNumber == null)
				{
					num = (short)1348141059;
					num2 = (int)((global::System.IntPtr)num);
				}
				else
				{
					num = (short)1438121984;
					short num4 = num;
					text = strModelNumber.ToUpper().Trim();
					num = (short)1223229441;
					num2 = (int)((global::System.IntPtr)num);
				}
			}
			return false;
			IL_14A:
			num = (short)822673408;
			if (num != 0)
			{
			}
			return global::AllFeatures.CodeplugGuid.b("軅劉￉駋跍雏蓓臕鯙鋛", a_) == text;
		}

		// Token: 0x170068BA RID: 26810
		// (get) Token: 0x0600D07A RID: 53370 RVA: 0x00C20FDC File Offset: 0x00C1F1DC
		public static bool IsMahaloRadio
		{
			get
			{
				short num;
				bool result;
				try
				{
					num = (short)1418071714;
					short num2 = num;
					num = (short)147721890;
					switch (num2 == num)
					{
					}
					num = (short)185597952;
					if (num != 0)
					{
					}
					num = (short)318898177;
					if (num != 0)
					{
					}
					result = global::ConstraintHelper.UtilityMack.IsMahaloCodeplug((((global::Motorola.MackinawCPS.CoreFeatures.RadioInformation.RadioInformationRecset)global::AcpCommonLib.FeatureManager.GetFeature(2049))[0] as global::Motorola.MackinawCPS.CoreFeatures.RadioInformation.RadioInformation).General.RadInfoGeneralModelNumber_A8539.Value);
				}
				catch
				{
					result = false;
				}
				num = (short)965672960;
				short num3 = num;
				return result;
			}
		}

		// Token: 0x0600D07B RID: 53371 RVA: 0x00C210CC File Offset: 0x00C1F2CC
		public static bool IsMahaloVHFCodeplug(string strModelNumber)
		{
			int a_ = 15;
			short num = (short)79101954;
			int num2 = (int)((global::System.IntPtr)num);
			string text;
			for (;;)
			{
				switch (num2)
				{
				case 0:
					goto IL_145;
				case 1:
					goto IL_66;
				case 2:
					switch (0)
					{
					case 0:
						goto IL_46;
					}
					continue;
				case 3:
					if (!(global::AllFeatures.CodeplugGuid.b("飏鷕鳗鳙軝럟퓡ꗣ꣥", a_) == text))
					{
						num = (short)1984233473;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					return true;
				case 4:
					return false;
				case 5:
					if (!(global::AllFeatures.CodeplugGuid.b("飏鷕鳗鳙軝럟퓡ꗣ꣥", a_) == text))
					{
						num = (short)982953498;
						short num3 = num;
						num = (short)258584090;
						switch ((num3 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_66;
						case 1:
							break;
						default:
						{
							num = (short)805568512;
							short num4 = num;
							break;
						}
						}
						num = (short)1957560320;
						if (num != 0)
						{
						}
						num = (short)1322647552;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					return true;
				}
				IL_46:
				if (strModelNumber == null)
				{
					num = (short)1239285764;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				text = strModelNumber.ToUpper().Trim();
				num = (short)460193795;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_66:
				num = (short)317521921;
				if (num != 0)
				{
				}
				num = (short)1236926469;
				num2 = (int)((global::System.IntPtr)num);
			}
			return false;
			IL_145:
			return global::AllFeatures.CodeplugGuid.b("飏鷕鳗鳙軝럟퓡ꗣ꣥", a_) == text;
		}

		// Token: 0x170068BB RID: 26811
		// (get) Token: 0x0600D07C RID: 53372 RVA: 0x00C21290 File Offset: 0x00C1F490
		public static bool IsMahaloVHFRadio
		{
			get
			{
				short num;
				bool result;
				try
				{
					num = (short)710267640;
					short num2 = num;
					num = (short)1876742904;
					switch (num2 == num)
					{
					}
					num = (short)1091567616;
					if (num != 0)
					{
					}
					result = global::ConstraintHelper.UtilityMack.IsMahaloVHFCodeplug((((global::Motorola.MackinawCPS.CoreFeatures.RadioInformation.RadioInformationRecset)global::AcpCommonLib.FeatureManager.GetFeature(2049))[0] as global::Motorola.MackinawCPS.CoreFeatures.RadioInformation.RadioInformation).General.RadInfoGeneralModelNumber_A8539.Value);
				}
				catch
				{
					result = false;
				}
				num = (short)1342242817;
				if (num != 0)
				{
				}
				num = (short)97517568;
				short num3 = num;
				return result;
			}
		}

		// Token: 0x170068BC RID: 26812
		// (get) Token: 0x0600D07D RID: 53373 RVA: 0x00C21380 File Offset: 0x00C1F580
		public static bool IsNFPARadio
		{
			get
			{
				short num;
				bool result;
				try
				{
					num = (short)40285775;
					short num2 = num;
					num = (short)651015759;
					switch (num2 == num)
					{
					}
					num = (short)1432944640;
					if (num != 0)
					{
					}
					result = global::ConstraintHelper.UtilityMack.IsNFPACodeplug((((global::Motorola.MackinawCPS.CoreFeatures.RadioInformation.RadioInformationRecset)global::AcpCommonLib.FeatureManager.GetFeature(2049))[0] as global::Motorola.MackinawCPS.CoreFeatures.RadioInformation.RadioInformation).General.RadInfoGeneralModelNumber_A8539.Value);
				}
				catch
				{
					result = false;
				}
				num = (short)120258561;
				if (num != 0)
				{
				}
				num = (short)243073024;
				short num3 = num;
				return result;
			}
		}

		// Token: 0x0600D07E RID: 53374 RVA: 0x00C21474 File Offset: 0x00C1F674
		public static bool IsNFPACodeplug(string strModelNumber)
		{
			int a_ = 6;
			short num = (short)237174786;
			int num2 = (int)((global::System.IntPtr)num);
			string text;
			for (;;)
			{
				switch (num2)
				{
				case 0:
				{
					num = (short)903754074;
					short num3 = num;
					num = (short)902312282;
					switch ((num3 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						break;
					default:
						goto IL_145;
					}
					break;
				}
				case 1:
					num = (short)606011393;
					if (num != 0)
					{
					}
					if (!text.Equals(global::AllFeatures.CodeplugGuid.b("迆ﳈﻊ駌裎蓐藔胖髚鏜", a_)))
					{
						num = (short)869400576;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					return true;
				case 2:
					switch (0)
					{
					case 0:
						goto IL_3D;
					}
					continue;
				case 3:
					return false;
				}
				IL_3D:
				if (strModelNumber == null)
				{
					num = (short)854261763;
					num2 = (int)((global::System.IntPtr)num);
				}
				else
				{
					text = strModelNumber.ToUpper().Trim();
					num = (short)2057633792;
					short num4 = num;
					num = (short)640483329;
					num2 = (int)((global::System.IntPtr)num);
				}
			}
			return false;
			IL_145:
			num = (short)49872896;
			if (num != 0)
			{
			}
			return text.Equals(global::AllFeatures.CodeplugGuid.b("迆﷈ﻊ駌裎蓐藔胖髚鏜", a_));
		}

		// Token: 0x0600D07F RID: 53375 RVA: 0x00C215E4 File Offset: 0x00C1F7E4
		public static bool IsAlohaCodeplug(string strModelNumber)
		{
			int a_ = 7;
			short num = (short)515964929;
			if (num != 0)
			{
			}
			num = (short)1328873472;
			short num2 = num;
			if (strModelNumber != null)
			{
				num = (short)969494819;
				short num3 = num;
				num = (short)1223905571;
				switch ((num3 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					break;
				default:
					num = (short)2090598400;
					if (num != 0)
					{
					}
					return strModelNumber.ToUpper().Trim().Equals(global::AllFeatures.CodeplugGuid.b("胇柳溜鯍鏏蛑蛕迗鷛郝", a_));
				}
			}
			return false;
		}

		// Token: 0x170068BD RID: 26813
		// (get) Token: 0x0600D080 RID: 53376 RVA: 0x00C216BC File Offset: 0x00C1F8BC
		public static bool IsAlohaRadio
		{
			get
			{
				short num;
				bool result;
				try
				{
					num = (short)1917916094;
					short num2 = num;
					num = (short)1753945022;
					switch (num2 == num)
					{
					}
					num = (short)1311571968;
					if (num != 0)
					{
					}
					result = global::ConstraintHelper.UtilityMack.IsAlohaCodeplug((((global::Motorola.MackinawCPS.CoreFeatures.RadioInformation.RadioInformationRecset)global::AcpCommonLib.FeatureManager.GetFeature(2049))[0] as global::Motorola.MackinawCPS.CoreFeatures.RadioInformation.RadioInformation).General.RadInfoGeneralModelNumber_A8539.Value);
				}
				catch
				{
					result = false;
				}
				num = (short)273743873;
				if (num != 0)
				{
				}
				num = (short)1825964032;
				short num3 = num;
				return result;
			}
		}

		// Token: 0x170068BE RID: 26814
		// (get) Token: 0x0600D081 RID: 53377 RVA: 0x00C217AC File Offset: 0x00C1F9AC
		public static bool IsWorldWidePro
		{
			get
			{
				int a_ = 10;
				short num = (short)148373506;
				int num2 = (int)((global::System.IntPtr)num);
				for (;;)
				{
					switch (num2)
					{
					case 0:
						goto IL_DC;
					case 1:
						num = (short)1535901701;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 2:
						switch (0)
						{
						case 0:
							goto IL_46;
						}
						continue;
					case 3:
						if (!(global::ConstraintHelper.UtilityMack.ProductModelId == global::AllFeatures.CodeplugGuid.b("諊鷌韎", a_)))
						{
							num = (short)99942401;
							if (num != 0)
							{
							}
							num = (short)111280129;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_153;
					case 4:
						num = (short)73072643;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 5:
						if (!(global::ConstraintHelper.UtilityMack.ProductModelId == global::AllFeatures.CodeplugGuid.b("諊鷌韎", a_)))
						{
							num = (short)1293877248;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_153;
					}
					IL_46:
					if (!(global::ConstraintHelper.UtilityMack.ProductModelId == global::AllFeatures.CodeplugGuid.b("諊鷌韎", a_)))
					{
						num = (short)690290692;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					IL_153:
					num = (short)1149072269;
					short num3 = num;
					num = (short)1163096973;
					switch ((num3 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_46;
					case 1:
						goto IL_1B3;
					}
					goto Block_4;
				}
				IL_DC:
				return global::ConstraintHelper.UtilityMack.ProductModelId == global::AllFeatures.CodeplugGuid.b("諊鷌韎闘닚", a_);
				Block_4:
				num = (short)1671954432;
				short num4 = num;
				IL_1B3:
				num = (short)988413952;
				if (num != 0)
				{
				}
				return true;
			}
		}

		// Token: 0x170068BF RID: 26815
		// (get) Token: 0x0600D082 RID: 53378 RVA: 0x00C21984 File Offset: 0x00C1FB84
		public static bool IsAPX2000APX4000With2Knobs
		{
			get
			{
				int a_ = 2;
				if (!(global::ConstraintHelper.UtilityMack.ProductModelId == global::AllFeatures.CodeplugGuid.b("苂闄鿆﯈﯊﷌ￎ", a_)))
				{
					short num = (short)753401856;
					short num2 = num;
					num = (short)146866177;
					if (num != 0)
					{
					}
				}
				else
				{
					short num = (short)1168358777;
					short num3 = num;
					num = (short)1664400761;
					switch ((num3 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						break;
					default:
						num = (short)1487142912;
						if (num != 0)
						{
						}
						return true;
					}
				}
				return global::ConstraintHelper.UtilityMack.ProductModelId == global::AllFeatures.CodeplugGuid.b("苂闄鿆﷈﯊﷌ￎ", a_);
			}
		}

		// Token: 0x170068C0 RID: 26816
		// (get) Token: 0x0600D083 RID: 53379 RVA: 0x00C21A6C File Offset: 0x00C1FC6C
		public static bool IsAPX1000With2Knobs
		{
			get
			{
				int a_ = 2;
				short num = (short)350623297;
				short num2 = num;
				num = (short)128259649;
				switch (num2 == num)
				{
				}
				num = (short)1221591041;
				if (num != 0)
				{
				}
				num = (short)1495597056;
				if (num != 0)
				{
				}
				num = (short)1140654080;
				short num3 = num;
				return global::ConstraintHelper.UtilityMack.ProductModelId == global::AllFeatures.CodeplugGuid.b("苂闄鿆﯊﷌ￎ", a_);
			}
		}

		// Token: 0x170068C1 RID: 26817
		// (get) Token: 0x0600D084 RID: 53380 RVA: 0x00C21B34 File Offset: 0x00C1FD34
		public static bool IsAPX1000i
		{
			get
			{
				int a_ = 12;
				short num = (short)2124009304;
				short num2 = num;
				num = (short)320261976;
				switch (num2 == num)
				{
				}
				num = (short)211353601;
				if (num != 0)
				{
				}
				num = (short)1045889024;
				if (num != 0)
				{
				}
				num = (short)801046528;
				short num3 = num;
				return global::ConstraintHelper.UtilityMack.ProductModelId == global::AllFeatures.CodeplugGuid.b("賌鿎觐닚", a_);
			}
		}

		// Token: 0x170068C2 RID: 26818
		// (get) Token: 0x0600D085 RID: 53381 RVA: 0x00C21BFC File Offset: 0x00C1FDFC
		public static bool IsAPX2000XE4000XE
		{
			get
			{
				int a_ = 18;
				if (!(global::ConstraintHelper.UtilityMack.ProductModelId == global::AllFeatures.CodeplugGuid.b("鋒藔迖맠ꛢ", a_)))
				{
					short num = (short)590413824;
					short num2 = num;
				}
				else
				{
					short num = (short)32890281;
					short num3 = num;
					num = (short)626711977;
					switch ((num3 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						break;
					default:
						num = (short)789053441;
						if (num != 0)
						{
						}
						num = (short)527499264;
						if (num != 0)
						{
						}
						return true;
					}
				}
				return global::ConstraintHelper.UtilityMack.ProductModelId == global::AllFeatures.CodeplugGuid.b("鋒藔迖맠ꛢ", a_);
			}
		}

		// Token: 0x170068C3 RID: 26819
		// (get) Token: 0x0600D086 RID: 53382 RVA: 0x00C21CE4 File Offset: 0x00C1FEE4
		public static bool IsAPX8000CBP
		{
			get
			{
				int a_ = 9;
				int num;
				short num2;
				global::Motorola.MackinawCPS.CoreFeatures.RadioInformation.RadioInformation radioInformation;
				switch (0)
				{
				case 0:
					break;
				default:
					for (;;)
					{
						IL_13:
						switch (num)
						{
						case 0:
						{
							num2 = (short)1710857281;
							short num3 = num2;
							num2 = (short)1187093569;
							switch ((num3 == num2) ? 1 : 0)
							{
							case 0:
							case 2:
								goto IL_44;
							default:
							{
								num2 = (short)1643839488;
								short num4 = num2;
								num2 = (short)23592960;
								if (num2 != 0)
								{
								}
								if (radioInformation != null)
								{
									num2 = (short)476184579;
									num = (int)((global::System.IntPtr)num2);
									continue;
								}
								return false;
							}
							}
							break;
						}
						case 1:
							num2 = (short)72351744;
							num = (int)((global::System.IntPtr)num2);
							continue;
						case 2:
							num2 = (short)1414266881;
							if (num2 != 0)
							{
							}
							if (global::ConstraintHelper.UtilityMack.ProductModelId.Equals(global::AllFeatures.CodeplugGuid.b("诉鳋雍", a_)))
							{
								num2 = (short)564723713;
								num = (int)((global::System.IntPtr)num2);
								continue;
							}
							return false;
						case 3:
							goto IL_16F;
						}
						goto IL_29;
					}
					IL_16F:
					return radioInformation.Labtool.RadInfoLabtoolQA02751APXLiRadioTrigger_A41197.Value;
				}
				IL_29:
				radioInformation = (((global::Motorola.MackinawCPS.CoreFeatures.RadioInformation.RadioInformationRecset)global::AcpCommonLib.FeatureManager.GetFeature(2049))[0] as global::Motorola.MackinawCPS.CoreFeatures.RadioInformation.RadioInformation);
				IL_44:
				num2 = (short)1767178242;
				num = (int)((global::System.IntPtr)num2);
				goto IL_13;
			}
		}

		// Token: 0x170068C4 RID: 26820
		// (get) Token: 0x0600D087 RID: 53383 RVA: 0x00C21E68 File Offset: 0x00C20068
		public static bool IsAllBand
		{
			get
			{
				int a_ = 17;
				short num = (short)484341177;
				short num2 = num;
				num = (short)1422161337;
				switch (num2 == num)
				{
				}
				num = (short)1658519552;
				if (num != 0)
				{
				}
				num = (short)1953234945;
				if (num != 0)
				{
				}
				num = (short)694026240;
				short num3 = num;
				return global::ConstraintHelper.UtilityMack.ProductModelId == global::AllFeatures.CodeplugGuid.b("鏑蓓軕", a_);
			}
		}

		// Token: 0x0600D088 RID: 53384 RVA: 0x00C21F34 File Offset: 0x00C20134
		public static bool Unpacking()
		{
			short num = (short)1986685213;
			short num2 = num;
			num = (short)1847224605;
			switch (num2 == num)
			{
			}
			num = (short)1849163777;
			if (num != 0)
			{
			}
			num = (short)863502336;
			if (num != 0)
			{
			}
			num = (short)423297024;
			short num3 = num;
			return false;
		}

		// Token: 0x0600D089 RID: 53385 RVA: 0x00C21FE0 File Offset: 0x00C201E0
		public static bool IsOnOpenDocumentFlag()
		{
			short num = (short)510745023;
			short num2 = num;
			num = (short)1013602751;
			switch (num2 == num)
			{
			}
			num = (short)355598336;
			if (num != 0)
			{
			}
			num = (short)949354497;
			if (num != 0)
			{
			}
			num = (short)1232601088;
			short num3 = num;
			return false;
		}

		// Token: 0x0600D08A RID: 53386 RVA: 0x00C2208C File Offset: 0x00C2028C
		internal static bool IsFlashInProgress()
		{
			short num = (short)1467325730;
			short num2 = num;
			num = (short)339123490;
			switch (num2 == num)
			{
			}
			num = (short)703332352;
			if (num != 0)
			{
			}
			num = (short)1174929409;
			if (num != 0)
			{
			}
			num = (short)1344602112;
			short num3 = num;
			return false;
		}

		// Token: 0x0600D08B RID: 53387 RVA: 0x00C22134 File Offset: 0x00C20334
		public static void ReinitializeAndSetFlagsBasedOnModel(int nType, string strModelNumber)
		{
			switch (0)
			{
			case 0:
				goto IL_4B;
			}
			short num;
			int num2;
			for (;;)
			{
				IL_0A:
				num = (short)1835925505;
				if (num != 0)
				{
				}
				switch (num2)
				{
				case 0:
					num = (short)172294145;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 1:
					goto IL_B6;
				case 2:
					num = (short)1306787844;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 3:
					goto IL_7B;
				case 4:
				{
					num = (short)180588625;
					short num3 = num;
					num = (short)501321809;
					switch ((num3 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_7B;
					default:
						num = (short)1437270016;
						if (num != 0)
						{
						}
						if (nType != 1)
						{
							num = (short)969998336;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_13D;
					}
					break;
				}
				}
				goto IL_4B;
				IL_7B:
				if (nType == 0)
				{
					break;
				}
				num = (short)1102577666;
				num2 = (int)((global::System.IntPtr)num);
			}
			global::ConstraintHelper.UtilityMack.a = true;
			return;
			IL_B6:
			num = (short)240386048;
			short num4 = num;
			throw new global::System.Exception(global::CommonResources.AcgResources.ID_UNABLETODETERMINERADIOMODELTYPE);
			IL_13D:
			global::ConstraintHelper.UtilityMack.b = true;
			return;
			IL_4B:
			global::ConstraintHelper.UtilityMack.b = false;
			global::ConstraintHelper.UtilityMack.a = false;
			global::ConstraintHelper.UtilityMack.c = (strModelNumber[3] == 'V');
			num = (short)1472724995;
			num2 = (int)((global::System.IntPtr)num);
			goto IL_0A;
		}

		// Token: 0x0600D08C RID: 53388 RVA: 0x00C222B8 File Offset: 0x00C204B8
		public static void ReinitializeAndSetFlagsBasedOnModel(string p, string strModelNumber)
		{
			int a_ = 12;
			switch (0)
			{
			case 0:
				goto IL_2D;
			}
			int num;
			short num2;
			for (;;)
			{
				IL_13:
				switch (num)
				{
				case 0:
					global::ConstraintHelper.UtilityMack.a = true;
					num2 = (short)1737752577;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 1:
					goto IL_A9;
				case 2:
					goto IL_87;
				case 3:
					goto IL_5D;
				case 4:
				{
					num2 = (short)935400190;
					short num3 = num2;
					num2 = (short)355144446;
					switch ((num3 == num2) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_5D;
					default:
						num2 = (short)1206976512;
						if (num2 != 0)
						{
						}
						if (p == global::AllFeatures.CodeplugGuid.b("鷌胎菐蟒铔闖闘黚", a_))
						{
							num2 = (short)937426945;
							if (num2 != 0)
							{
							}
							num2 = (short)2133721088;
							num = (int)((global::System.IntPtr)num2);
							continue;
						}
						goto IL_171;
					}
					break;
				}
				}
				goto IL_2D;
				IL_5D:
				if (p == global::AllFeatures.CodeplugGuid.b("背胎鏐髒駔鋖", a_))
				{
					num2 = (short)1346895874;
					num = (int)((global::System.IntPtr)num2);
				}
				else
				{
					num2 = (short)2113142788;
					num = (int)((global::System.IntPtr)num2);
				}
			}
			IL_87:
			global::ConstraintHelper.UtilityMack.b = true;
			return;
			IL_A9:
			IL_171:
			num2 = (short)1707999232;
			short num4 = num2;
			return;
			IL_2D:
			global::ConstraintHelper.UtilityMack.b = false;
			global::ConstraintHelper.UtilityMack.a = false;
			global::ConstraintHelper.UtilityMack.c = (strModelNumber[3] == 'V');
			num2 = (short)796459011;
			num = (int)((global::System.IntPtr)num2);
			goto IL_13;
		}

		// Token: 0x0600D08D RID: 53389 RVA: 0x00C22460 File Offset: 0x00C20660
		public static bool CheckForTalkAroundStrapped(global::Motorola.MackinawCPS.CoreFeatures.ConventionalPersonality.ConventionalPersonality CnvPer, global::Motorola.MackinawCPS.CoreFeatures.ConventionalPersonality.FrequencyOptionsInnerSection CnvPerFrequencyOptInnerSec)
		{
			short num = (short)1956577280;
			int num2 = (int)num;
			switch (num2)
			{
			default:
			{
				switch (0)
				{
				case 0:
					goto IL_87;
				}
				global::AcpBusinessLayer.AcpListField cnvPerTxOptionsTxVoiceSignalType_A;
				global::AcpBusinessLayer.AcpListField cnvPerConventionalChannelOptionsTxPLFreq_A;
				global::AcpBusinessLayer.AcpListField cnvPerConventionalChannelOptionsRxPLFreq_A;
				global::AcpBusinessLayer.AcpListField cnvPerConventionalChannelOptionsTxSquelchType_A;
				global::AcpBusinessLayer.AcpListField cnvPerConventionalChannelOptionsTxDPLCode_A;
				global::AcpBusinessLayer.AcpListField cnvPerConventionalChannelOptionsRxDPLCode_A;
				global::AcpBusinessLayer.AcpListField cnvPerConventionalChannelOptionsRxSquelchType_A;
				global::AcpBusinessLayer.AcpSimpleRangeField cnvPerConventionalChannelOptionsRxNetworkID_A;
				global::AcpBusinessLayer.AcpSimpleRangeField cnvPerConventionalChannelOptionsTxNetworkID_A;
				global::AcpBusinessLayer.AcpField<bool> cnvPerConventionalChannelOptionsTxDPLInvert_A;
				global::AcpBusinessLayer.AcpField<bool> cnvPerConventionalChannelOptionsRxDPLInvert_A;
				for (;;)
				{
					IL_28:
					switch (num2)
					{
					case 0:
						if (cnvPerTxOptionsTxVoiceSignalType_A.Value == 1)
						{
							num = (short)1500512261;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return true;
					case 1:
						if (cnvPerConventionalChannelOptionsTxPLFreq_A.Value == cnvPerConventionalChannelOptionsRxPLFreq_A.Value)
						{
							num = (short)1687748626;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_451;
					case 2:
						num = (short)1439957007;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 3:
						if (cnvPerConventionalChannelOptionsTxSquelchType_A.Value == 3)
						{
							num = (short)2034302986;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return true;
					case 4:
						if (cnvPerConventionalChannelOptionsTxDPLCode_A.Value == cnvPerConventionalChannelOptionsRxDPLCode_A.Value)
						{
							num = (short)442236940;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return true;
					case 5:
						num = (short)1562116109;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 6:
						num = (short)569376776;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 7:
					{
						num = (short)32360366;
						short num3 = num;
						num = (short)1943062446;
						switch ((num3 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_3EE;
						default:
							num = (short)172687360;
							if (num != 0)
							{
							}
							if (cnvPerConventionalChannelOptionsTxSquelchType_A.Value == 2)
							{
								num = (short)1027997710;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							goto IL_451;
						}
						break;
					}
					case 8:
						if (cnvPerConventionalChannelOptionsRxSquelchType_A.Value == cnvPerConventionalChannelOptionsTxSquelchType_A.Value)
						{
							num = (short)1056768001;
							if (num != 0)
							{
							}
							num = (short)1204355074;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return true;
					case 9:
					{
						num = (short)443940864;
						short num4 = num;
						num = (short)93519893;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 10:
						num = (short)928120836;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 11:
						return false;
					case 12:
						num = (short)11468819;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 13:
						if (cnvPerConventionalChannelOptionsRxNetworkID_A.Value == cnvPerConventionalChannelOptionsTxNetworkID_A.Value)
						{
							num = (short)258015248;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return true;
					case 14:
						num = (short)110428161;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 15:
						if (cnvPerConventionalChannelOptionsRxSquelchType_A.Value == 0)
						{
							num = (short)2049441809;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)1957691399;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 16:
						return false;
					case 17:
						return false;
					case 18:
						return false;
					case 19:
						if (cnvPerConventionalChannelOptionsTxDPLInvert_A.Value == cnvPerConventionalChannelOptionsRxDPLInvert_A.Value)
						{
							num = (short)1301479435;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return true;
					case 20:
					{
						global::AcpBusinessLayer.AcpField<int> cnvPerConventionalChannelOptionsRxFrequency_A = CnvPerFrequencyOptInnerSec.CnvPerConventionalChannelOptionsRxFrequency_A8911;
						global::AcpBusinessLayer.AcpFrequencyField cnvPerConventionalChannelOptionsTxFrequency_A = CnvPerFrequencyOptInnerSec.CnvPerConventionalChannelOptionsTxFrequency_A9414;
						if (cnvPerConventionalChannelOptionsRxFrequency_A.Value == cnvPerConventionalChannelOptionsTxFrequency_A.Value)
						{
							num = (short)1779761161;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return true;
					}
					case 21:
						if (cnvPerTxOptionsTxVoiceSignalType_A.Value == 0)
						{
							goto IL_3EE;
						}
						num = (short)1849294848;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_87;
					IL_3EE:
					num = (short)749600774;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_451:
					num = (short)1105526787;
					num2 = (int)((global::System.IntPtr)num);
				}
				return false;
				IL_87:
				global::AcpBusinessLayer.AcpListField cnvPerRxOptionsRxVoiceSignalType_A = CnvPer.RxOptions.CnvPerRxOptionsRxVoiceSignalType_A9044;
				cnvPerTxOptionsTxVoiceSignalType_A = CnvPer.TxOptions.CnvPerTxOptionsTxVoiceSignalType_A9574;
				cnvPerConventionalChannelOptionsTxPLFreq_A = CnvPerFrequencyOptInnerSec.CnvPerConventionalChannelOptionsTxPLFreq_A9419;
				cnvPerConventionalChannelOptionsRxPLFreq_A = CnvPerFrequencyOptInnerSec.CnvPerConventionalChannelOptionsRxPLFreq_A8918;
				cnvPerConventionalChannelOptionsRxSquelchType_A = CnvPerFrequencyOptInnerSec.CnvPerConventionalChannelOptionsRxSquelchType_A8919;
				cnvPerConventionalChannelOptionsTxSquelchType_A = CnvPerFrequencyOptInnerSec.CnvPerConventionalChannelOptionsTxSquelchType_A9426;
				cnvPerConventionalChannelOptionsRxDPLCode_A = CnvPerFrequencyOptInnerSec.CnvPerConventionalChannelOptionsRxDPLCode_A8908;
				cnvPerConventionalChannelOptionsTxDPLCode_A = CnvPerFrequencyOptInnerSec.CnvPerConventionalChannelOptionsTxDPLCode_A9409;
				cnvPerConventionalChannelOptionsRxDPLInvert_A = CnvPerFrequencyOptInnerSec.CnvPerConventionalChannelOptionsRxDPLInvert_A8909;
				cnvPerConventionalChannelOptionsTxDPLInvert_A = CnvPerFrequencyOptInnerSec.CnvPerConventionalChannelOptionsTxDPLInvert_A9410;
				cnvPerConventionalChannelOptionsRxNetworkID_A = CnvPerFrequencyOptInnerSec.CnvPerConventionalChannelOptionsRxNetworkID_A9023;
				cnvPerConventionalChannelOptionsTxNetworkID_A = CnvPerFrequencyOptInnerSec.CnvPerConventionalChannelOptionsTxNetworkID_A9550;
				num = (short)1952251924;
				num2 = (int)((global::System.IntPtr)num);
				goto IL_28;
			}
			}
		}

		// Token: 0x0600D08E RID: 53390 RVA: 0x00C22904 File Offset: 0x00C20B04
		public static bool IsConRxFrequencyBandOnStep(int inputFrequency, global::AcpCommonLib.IAcpFeatureSection self)
		{
			short num = (short)351600640;
			int num2 = (int)num;
			switch (num2)
			{
			default:
			{
				global::System.Collections.Generic.IEnumerator<global::AcpBusinessLayer.FeatureNode> enumerator = (((global::Motorola.MackinawCPS.CoreFeatures.RadioWide.RadioWideRecset)global::AcpCommonLib.FeatureManager.GetFeature(2045))[0][10096].EmbeddedRecset as global::Motorola.MackinawCPS.CoreFeatures.RadioWide.RxFrequencySplitFPPInnerRecset).GetEnumerator();
				bool result;
				try
				{
					num = (short)939262043;
					num2 = (int)((global::System.IntPtr)num);
					for (;;)
					{
						switch (num2)
						{
						case 0:
						{
							global::Motorola.MackinawCPS.CoreFeatures.RadioWide.RxFrequencySplitFPPInnerSection rxFrequencySplitFPPInnerSection;
							if (inputFrequency > rxFrequencySplitFPPInnerSection.RadWideLabtoolRxStartFrequencySplit_A9032.Value * 5)
							{
								num = (short)2003370037;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							break;
						}
						case 1:
							num = (short)1459617878;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 2:
							num = (short)1120403536;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 3:
						{
							global::Motorola.MackinawCPS.CoreFeatures.RadioWide.RxFrequencySplitFPPInnerSection rxFrequencySplitFPPInnerSection;
							if (inputFrequency <= rxFrequencySplitFPPInnerSection.RadWideLabtoolRxEndFrequencySplit_A9015.Value * 5)
							{
								num = (short)331546716;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							break;
						}
						case 4:
							goto IL_7EC;
						case 5:
							if (inputFrequency % 6250 == 0)
							{
								num = (short)350814242;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							break;
						case 6:
						{
							global::Motorola.MackinawCPS.CoreFeatures.RadioWide.RxFrequencySplitFPPInnerSection rxFrequencySplitFPPInnerSection;
							if (inputFrequency <= rxFrequencySplitFPPInnerSection.RadWideLabtoolRxEndFrequencySplit_A9015.Value * 5)
							{
								num = (short)777912388;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							break;
						}
						case 7:
						{
							global::Motorola.MackinawCPS.CoreFeatures.RadioWide.RxFrequencySplitFPPInnerSection rxFrequencySplitFPPInnerSection;
							if (inputFrequency > rxFrequencySplitFPPInnerSection.RadWideLabtoolRxStartFrequencySplit_A9032.Value * 5)
							{
								num = (short)896925719;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							break;
						}
						case 8:
						{
							global::Motorola.MackinawCPS.CoreFeatures.ConventionalPersonality.FrequencyOptionsInnerSection frequencyOptionsInnerSection;
							if (frequencyOptionsInnerSection.CnvPerConventionalChannelOptionsTxDevChanSpacing_A23192 != null)
							{
								num = (short)1309737007;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							break;
						}
						case 9:
						{
							global::Motorola.MackinawCPS.CoreFeatures.RadioWide.RxFrequencySplitFPPInnerSection rxFrequencySplitFPPInnerSection;
							if (rxFrequencySplitFPPInnerSection.RadWideLabtoolRxBandSplitName_A24797.Value == global::CommonResources.AcgResources.ID_UHF1)
							{
								num = (short)689242199;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							num = (short)804061254;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						case 10:
						{
							global::Motorola.MackinawCPS.CoreFeatures.RadioWide.RxFrequencySplitFPPInnerSection rxFrequencySplitFPPInnerSection;
							if (rxFrequencySplitFPPInnerSection.RadWideLabtoolRxBandSplitName_A24797.Value == global::CommonResources.AcgResources.ID_P_700M_2)
							{
								num = (short)1253965908;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							num = (short)295829526;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						case 11:
							num = (short)451739727;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 12:
							num = (short)2144337970;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 13:
						{
							global::Motorola.MackinawCPS.CoreFeatures.RadioWide.RxFrequencySplitFPPInnerSection rxFrequencySplitFPPInnerSection;
							if (inputFrequency < rxFrequencySplitFPPInnerSection.RadWideLabtoolRxEndFrequencySplit_A9015.Value * 5)
							{
								num = (short)706084902;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							goto IL_CAD;
						}
						case 14:
							if (inputFrequency % 5000 != 0)
							{
								num = (short)1312555020;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							goto IL_BDA;
						case 15:
						{
							global::Motorola.MackinawCPS.CoreFeatures.RadioWide.RxFrequencySplitFPPInnerSection rxFrequencySplitFPPInnerSection;
							if (inputFrequency >= rxFrequencySplitFPPInnerSection.RadWideLabtoolRxStartFrequencySplit_A9032.Value * 5)
							{
								num = (short)382402643;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							break;
						}
						case 16:
							if (inputFrequency % 6250 == 0)
							{
								num = (short)137560096;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							break;
						case 17:
							result = true;
							num = (short)1113718866;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 18:
							if (self is global::Motorola.MackinawCPS.CoreFeatures.ConventionalPersonality.FrequencyOptionsInnerSection)
							{
								num = (short)2072051773;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							result = true;
							num = (short)894828581;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 19:
						{
							global::Motorola.MackinawCPS.CoreFeatures.RadioWide.RxFrequencySplitFPPInnerSection rxFrequencySplitFPPInnerSection;
							if (inputFrequency < rxFrequencySplitFPPInnerSection.RadWideLabtoolRxEndFrequencySplit_A9015.Value * 5)
							{
								num = (short)1650655253;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							break;
						}
						case 20:
						{
							global::Motorola.MackinawCPS.CoreFeatures.RadioWide.RxFrequencySplitFPPInnerSection rxFrequencySplitFPPInnerSection;
							if (rxFrequencySplitFPPInnerSection.RadWideLabtoolRxBandSplitName_A24797.Value == global::CommonResources.AcgResources.ID_P_900M)
							{
								num = (short)486408235;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							break;
						}
						case 21:
							num = (short)656998462;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 22:
						{
							global::Motorola.MackinawCPS.CoreFeatures.RadioWide.RxFrequencySplitFPPInnerSection rxFrequencySplitFPPInnerSection;
							if (rxFrequencySplitFPPInnerSection.RadWideLabtoolRxBandSplitName_A24797.Value == global::CommonResources.AcgResources.ID_P_800M)
							{
								num = (short)206307372;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							num = (short)791805972;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						case 23:
							num = (short)1103691805;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 24:
							num = (short)494600267;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 25:
							if (inputFrequency % 6250 == 0)
							{
								num = (short)1162018881;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							break;
						case 26:
							goto IL_BDA;
						case 27:
							if (inputFrequency % 12500 == 0)
							{
								num = (short)732037155;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							goto IL_CAD;
						case 28:
							num = (short)2034696197;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 29:
						{
							global::Motorola.MackinawCPS.CoreFeatures.RadioWide.RxFrequencySplitFPPInnerSection rxFrequencySplitFPPInnerSection;
							if (inputFrequency < rxFrequencySplitFPPInnerSection.RadWideLabtoolRxEndFrequencySplit_A9015.Value * 5)
							{
								num = (short)980811804;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							break;
						}
						case 30:
							goto IL_7D2;
						case 31:
							goto IL_37E;
						case 32:
							result = true;
							num = (short)1546059840;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 33:
							num = (short)1741094931;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 34:
							result = true;
							num = (short)1227751505;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 35:
							result = true;
							num = (short)373293130;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 36:
							num = (short)1694433296;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 37:
							goto IL_35F;
						case 38:
							num = (short)1042219035;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 39:
						{
							global::Motorola.MackinawCPS.CoreFeatures.RadioWide.RxFrequencySplitFPPInnerSection rxFrequencySplitFPPInnerSection;
							if (rxFrequencySplitFPPInnerSection != null)
							{
								num = (short)1028915240;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							break;
						}
						case 40:
							num = (short)1735655465;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 41:
						{
							global::Motorola.MackinawCPS.CoreFeatures.RadioWide.RxFrequencySplitFPPInnerSection rxFrequencySplitFPPInnerSection;
							if (rxFrequencySplitFPPInnerSection.RadWideLabtoolRxBandSplitName_A24797.Value == global::CommonResources.AcgResources.ID_VHF)
							{
								num = (short)1698627673;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							num = (short)1973878793;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						case 42:
						{
							global::Motorola.MackinawCPS.CoreFeatures.RadioWide.RxFrequencySplitFPPInnerSection rxFrequencySplitFPPInnerSection;
							if (rxFrequencySplitFPPInnerSection.RadWideLabtoolRxBandSplitName_A24797.Value == global::CommonResources.AcgResources.ID_P_700M_1)
							{
								num = (short)382337073;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							num = (short)1195900938;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						case 43:
							num = (short)2110717952;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 44:
							num = (short)2134442056;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 45:
							num = (short)936247314;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 46:
							num = (short)1991442486;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 47:
							num = (short)1349976119;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 48:
							goto IL_BF5;
						case 49:
							goto IL_383;
						case 50:
							if (inputFrequency % 6250 == 0)
							{
								num = (short)734724122;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							break;
						case 51:
						{
							global::Motorola.MackinawCPS.CoreFeatures.RadioWide.RxFrequencySplitFPPInnerSection rxFrequencySplitFPPInnerSection;
							if (inputFrequency >= rxFrequencySplitFPPInnerSection.RadWideLabtoolRxStartFrequencySplit_A9032.Value * 5)
							{
								num = (short)1673068634;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							break;
						}
						case 52:
						{
							global::Motorola.MackinawCPS.CoreFeatures.RadioWide.RxFrequencySplitFPPInnerSection rxFrequencySplitFPPInnerSection;
							if (inputFrequency >= rxFrequencySplitFPPInnerSection.RadWideLabtoolRxStartFrequencySplit_A9032.Value * 5)
							{
								num = (short)1173159969;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							break;
						}
						case 53:
							num = (short)169148473;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 54:
						{
							global::Motorola.MackinawCPS.CoreFeatures.RadioWide.RxFrequencySplitFPPInnerSection rxFrequencySplitFPPInnerSection;
							if (inputFrequency >= rxFrequencySplitFPPInnerSection.RadWideLabtoolRxStartFrequencySplit_A9032.Value * 5)
							{
								num = (short)868876312;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							break;
						}
						case 55:
						{
							global::Motorola.MackinawCPS.CoreFeatures.ConventionalPersonality.FrequencyOptionsInnerSection frequencyOptionsInnerSection;
							if (frequencyOptionsInnerSection.CnvPerConventionalChannelOptionsTxDevChanSpacing_A23192.Value == 12851)
							{
								num = (short)1713700881;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							break;
						}
						case 56:
							num = (short)1977417731;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 57:
						{
							global::Motorola.MackinawCPS.CoreFeatures.RadioWide.RxFrequencySplitFPPInnerSection rxFrequencySplitFPPInnerSection;
							if (inputFrequency < rxFrequencySplitFPPInnerSection.RadWideLabtoolRxEndFrequencySplit_A9015.Value * 5)
							{
								num = (short)1848508492;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							break;
						}
						case 58:
							if (inputFrequency % 12500 == 0)
							{
								num = (short)1197998157;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							break;
						case 59:
						{
							global::Motorola.MackinawCPS.CoreFeatures.RadioWide.RxFrequencySplitFPPInnerSection rxFrequencySplitFPPInnerSection;
							if (inputFrequency >= rxFrequencySplitFPPInnerSection.RadWideLabtoolRxStartFrequencySplit_A9032.Value * 5)
							{
								num = (short)612761656;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							break;
						}
						case 60:
						{
							if (!enumerator.MoveNext())
							{
								num = (short)527630347;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							global::Motorola.MackinawCPS.CoreFeatures.RadioWide.RxFrequencySplitFPPInnerSection rxFrequencySplitFPPInnerSection = ((global::AcpCommonLib.IAcpFeatureNode)enumerator.Current)[10097] as global::Motorola.MackinawCPS.CoreFeatures.RadioWide.RxFrequencySplitFPPInnerSection;
							num = (short)264831015;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						case 61:
						{
							global::Motorola.MackinawCPS.CoreFeatures.ConventionalPersonality.FrequencyOptionsInnerSection frequencyOptionsInnerSection = self as global::Motorola.MackinawCPS.CoreFeatures.ConventionalPersonality.FrequencyOptionsInnerSection;
							num = (short)173408264;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						case 62:
							if (inputFrequency % 6250 == 0)
							{
								num = (short)1398931457;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							break;
						case 63:
							if (inputFrequency % 2500 != 0)
							{
								num = (short)1168638021;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							goto IL_239;
						case 64:
							goto IL_E9A;
						case 65:
							goto IL_239;
						case 66:
							if (inputFrequency % 5000 != 0)
							{
								num = (short)1316093954;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							goto IL_7D2;
						case 67:
							goto IL_253;
						case 68:
							num = (short)364118082;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 69:
							num = (short)2056716313;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 70:
						{
							global::Motorola.MackinawCPS.CoreFeatures.RadioWide.RxFrequencySplitFPPInnerSection rxFrequencySplitFPPInnerSection;
							if (rxFrequencySplitFPPInnerSection.RadWideLabtoolRxBandSplitName_A24797.Value == global::CommonResources.AcgResources.ID_UHF2)
							{
								num = (short)499318830;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							num = (short)1927938136;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						case 71:
							num = (short)1817444366;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 72:
						{
							global::Motorola.MackinawCPS.CoreFeatures.RadioWide.RxFrequencySplitFPPInnerSection rxFrequencySplitFPPInnerSection;
							if (inputFrequency >= rxFrequencySplitFPPInnerSection.RadWideLabtoolRxStartFrequencySplit_A9032.Value * 5)
							{
								num = (short)464977993;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							goto IL_CAD;
						}
						case 73:
							num = (short)1078853645;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 74:
							goto IL_274;
						case 75:
						{
							global::Motorola.MackinawCPS.CoreFeatures.RadioWide.RxFrequencySplitFPPInnerSection rxFrequencySplitFPPInnerSection;
							if (inputFrequency <= rxFrequencySplitFPPInnerSection.RadWideLabtoolRxEndFrequencySplit_A9015.Value * 5)
							{
								num = (short)1854275655;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							break;
						}
						case 76:
							num = (short)1248919610;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 77:
							result = true;
							num = (short)424149023;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 78:
						{
							global::Motorola.MackinawCPS.CoreFeatures.RadioWide.RxFrequencySplitFPPInnerSection rxFrequencySplitFPPInnerSection;
							if (inputFrequency < rxFrequencySplitFPPInnerSection.RadWideLabtoolRxEndFrequencySplit_A9015.Value * 5)
							{
								num = (short)1466957860;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							break;
						}
						case 79:
							goto IL_EB8;
						case 80:
							if (inputFrequency % 6250 == 0)
							{
								num = (short)1271332894;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							break;
						case 81:
							goto IL_E2F;
						case 82:
							goto IL_CA8;
						case 83:
							num = (short)191496198;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 84:
							num = (short)1373831219;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 85:
							num = (short)928448554;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 86:
							if (self != null)
							{
								num = (short)1932853293;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							break;
						case 87:
							num = (short)1815085071;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 88:
						{
							global::Motorola.MackinawCPS.CoreFeatures.RadioWide.RxFrequencySplitFPPInnerSection rxFrequencySplitFPPInnerSection;
							if (!(rxFrequencySplitFPPInnerSection.RadWideLabtoolRxBandSplitName_A24797.Value == global::CommonResources.AcgResources.ID_P_700M))
							{
								num = (short)2071527509;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							goto IL_383;
						}
						case 89:
							num = (short)1547370555;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 90:
							num = (short)1120731214;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 91:
							switch (0)
							{
							case 0:
								goto IL_1EC;
							}
							continue;
						case 92:
							num = (short)194183231;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_1EC;
						IL_239:
						result = true;
						num = (short)583860291;
						num2 = (int)((global::System.IntPtr)num);
						continue;
						IL_383:
						num = (short)711065607;
						num2 = (int)((global::System.IntPtr)num);
						continue;
						IL_7D2:
						result = true;
						num = (short)1040187396;
						num2 = (int)((global::System.IntPtr)num);
						continue;
						IL_BDA:
						result = true;
						num = (short)255066160;
						num2 = (int)((global::System.IntPtr)num);
						continue;
						IL_CAD:
						num = (short)1314258996;
						num2 = (int)((global::System.IntPtr)num);
						continue;
						IL_D3E:
						num = (short)944439356;
						num2 = (int)((global::System.IntPtr)num);
						continue;
						IL_1EC:
						goto IL_D3E;
					}
					IL_253:
					IL_274:
					IL_35F:
					IL_37E:
					IL_7EC:
					IL_BF5:
					IL_CA8:
					IL_E2F:
					IL_E9A:
					goto IL_F73;
					IL_EB8:
					return false;
				}
				finally
				{
					num = (short)1129119338;
					short num3 = num;
					num = (short)915144298;
					switch ((num3 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						break;
					default:
						num = (short)494927872;
						if (num != 0)
						{
						}
						num = (short)1451032578;
						num2 = (int)((global::System.IntPtr)num);
						break;
					}
					for (;;)
					{
						switch (num2)
						{
						case 0:
							goto IL_F70;
						case 1:
							enumerator.Dispose();
							num = (short)31719424;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 2:
							switch (0)
							{
							case 0:
								goto IL_F3A;
							}
							continue;
						}
						IL_F3A:
						if (enumerator == null)
						{
							break;
						}
						num = (short)1015480321;
						num2 = (int)((global::System.IntPtr)num);
					}
					IL_F70:;
				}
				IL_F73:
				num = (short)444006401;
				if (num != 0)
				{
				}
				num = (short)1817575424;
				short num4 = num;
				return result;
			}
			}
		}

		// Token: 0x0600D08F RID: 53391 RVA: 0x00C238F8 File Offset: 0x00C21AF8
		public static bool IsConTxFrequencyBandOnStep(int inputFrequency, global::AcpCommonLib.IAcpFeatureSection self)
		{
			short num = (short)784072705;
			if (num != 0)
			{
			}
			num = (short)1898905600;
			short num2 = num;
			num = (short)760872960;
			switch (num)
			{
			default:
			{
				global::System.Collections.Generic.IEnumerator<global::AcpBusinessLayer.FeatureNode> enumerator = (((global::Motorola.MackinawCPS.CoreFeatures.RadioWide.RadioWideRecset)global::AcpCommonLib.FeatureManager.GetFeature(2045))[0][10094].EmbeddedRecset as global::Motorola.MackinawCPS.CoreFeatures.RadioWide.TxFrequencySplitFPPInnerRecset).GetEnumerator();
				bool result;
				try
				{
					num = (short)1473314881;
					int num3 = (int)((global::System.IntPtr)num);
					for (;;)
					{
						switch (num3)
						{
						case 0:
						{
							global::Motorola.MackinawCPS.CoreFeatures.RadioWide.TxFrequencySplitFPPInnerSection txFrequencySplitFPPInnerSection;
							if (!(txFrequencySplitFPPInnerSection.RadWideLabtoolTxBandSplitName_A24799.Value == global::CommonResources.AcgResources.ID_P_800M_1))
							{
								num = (short)1943142483;
								num3 = (int)((global::System.IntPtr)num);
								continue;
							}
							goto IL_CC6;
						}
						case 1:
						{
							global::Motorola.MackinawCPS.CoreFeatures.RadioWide.TxFrequencySplitFPPInnerSection txFrequencySplitFPPInnerSection;
							if (txFrequencySplitFPPInnerSection.RadWideLabtoolTxBandSplitName_A24799.Value == global::CommonResources.AcgResources.ID_P_700M_2)
							{
								num = (short)2014249040;
								num3 = (int)((global::System.IntPtr)num);
								continue;
							}
							goto IL_892;
						}
						case 2:
							if (inputFrequency % 6250 == 0)
							{
								num = (short)780730434;
								num3 = (int)((global::System.IntPtr)num);
								continue;
							}
							break;
						case 3:
							if (inputFrequency % 6250 == 0)
							{
								num = (short)1977221158;
								num3 = (int)((global::System.IntPtr)num);
								continue;
							}
							goto IL_530;
						case 4:
							if (inputFrequency % 5000 != 0)
							{
								num = (short)1614479367;
								num3 = (int)((global::System.IntPtr)num);
								continue;
							}
							goto IL_62E;
						case 5:
						{
							global::Motorola.MackinawCPS.CoreFeatures.RadioWide.TxFrequencySplitFPPInnerSection txFrequencySplitFPPInnerSection;
							if (inputFrequency <= txFrequencySplitFPPInnerSection.RadWideLabtoolTxEndFrequencySplit_A9532Value * 5)
							{
								num = (short)1947336748;
								num3 = (int)((global::System.IntPtr)num);
								continue;
							}
							goto IL_7FD;
						}
						case 6:
							num = (short)599654478;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						case 7:
							num = (short)872742988;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						case 8:
						{
							global::Motorola.MackinawCPS.CoreFeatures.ConventionalPersonality.FrequencyOptionsInnerSection frequencyOptionsInnerSection;
							if (frequencyOptionsInnerSection.CnvPerConventionalChannelOptionsTxDevChanSpacing_A23192 != null)
							{
								num = (short)349372434;
								num3 = (int)((global::System.IntPtr)num);
								continue;
							}
							break;
						}
						case 9:
							goto IL_DCB;
						case 10:
							num = (short)1567621122;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						case 11:
							num = (short)190840853;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						case 12:
							num = (short)1716912209;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						case 13:
						{
							global::Motorola.MackinawCPS.CoreFeatures.RadioWide.TxFrequencySplitFPPInnerSection txFrequencySplitFPPInnerSection;
							if (txFrequencySplitFPPInnerSection.RadWideLabtoolTxBandSplitName_A24799.Value == global::CommonResources.AcgResources.ID_P_800M_2)
							{
								num = (short)417726509;
								num3 = (int)((global::System.IntPtr)num);
								continue;
							}
							num = (short)334757975;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						}
						case 14:
							num = (short)649658410;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						case 15:
						{
							global::Motorola.MackinawCPS.CoreFeatures.ConventionalPersonality.FrequencyOptionsInnerSection frequencyOptionsInnerSection;
							if (frequencyOptionsInnerSection.CnvPerConventionalChannelOptionsTxDevChanSpacing_A23192.Value == 12851)
							{
								num = (short)649003075;
								num3 = (int)((global::System.IntPtr)num);
								continue;
							}
							break;
						}
						case 16:
							num = (short)98500662;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						case 17:
							if (inputFrequency % 12500 == 0)
							{
								num = (short)1734606878;
								num3 = (int)((global::System.IntPtr)num);
								continue;
							}
							goto IL_26A;
						case 18:
							num = (short)86704143;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						case 19:
						{
							global::Motorola.MackinawCPS.CoreFeatures.RadioWide.TxFrequencySplitFPPInnerSection txFrequencySplitFPPInnerSection;
							if (!(txFrequencySplitFPPInnerSection.RadWideLabtoolTxBandSplitName_A24799.Value == global::CommonResources.AcgResources.ID_P_700M_1))
							{
								num = (short)372441108;
								num3 = (int)((global::System.IntPtr)num);
								continue;
							}
							goto IL_951;
						}
						case 20:
							num = (short)1618542593;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						case 21:
						{
							global::Motorola.MackinawCPS.CoreFeatures.RadioWide.TxFrequencySplitFPPInnerSection txFrequencySplitFPPInnerSection;
							if (txFrequencySplitFPPInnerSection.RadWideLabtoolTxBandSplitName_A24799.Value == global::CommonResources.AcgResources.ID_P_900M_2)
							{
								num = (short)701431840;
								num3 = (int)((global::System.IntPtr)num);
								continue;
							}
							break;
						}
						case 22:
							if (self != null)
							{
								num = (short)1779040285;
								num3 = (int)((global::System.IntPtr)num);
								continue;
							}
							break;
						case 23:
						{
							global::Motorola.MackinawCPS.CoreFeatures.RadioWide.TxFrequencySplitFPPInnerSection txFrequencySplitFPPInnerSection;
							if (inputFrequency >= txFrequencySplitFPPInnerSection.RadWideLabtoolTxStartFrequencySplit_A9571.Value * 5)
							{
								num = (short)45482033;
								num3 = (int)((global::System.IntPtr)num);
								continue;
							}
							goto IL_26A;
						}
						case 24:
							goto IL_265;
						case 25:
						{
							global::Motorola.MackinawCPS.CoreFeatures.RadioWide.TxFrequencySplitFPPInnerSection txFrequencySplitFPPInnerSection;
							if (inputFrequency <= txFrequencySplitFPPInnerSection.RadWideLabtoolTxEndFrequencySplit_A9532Value * 5)
							{
								num = (short)1543045191;
								num3 = (int)((global::System.IntPtr)num);
								continue;
							}
							goto IL_448;
						}
						case 26:
							result = true;
							num = (short)788201523;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						case 27:
							goto IL_443;
						case 28:
							if (inputFrequency % 2500 != 0)
							{
								num = (short)1302790216;
								num3 = (int)((global::System.IntPtr)num);
								continue;
							}
							goto IL_24B;
						case 29:
							num = (short)341704763;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						case 30:
							result = true;
							num = (short)1003159561;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						case 31:
						{
							global::Motorola.MackinawCPS.CoreFeatures.RadioWide.TxFrequencySplitFPPInnerSection txFrequencySplitFPPInnerSection;
							if (inputFrequency <= txFrequencySplitFPPInnerSection.RadWideLabtoolTxEndFrequencySplit_A9532.Value * 5)
							{
								num = (short)1670643791;
								num3 = (int)((global::System.IntPtr)num);
								continue;
							}
							goto IL_530;
						}
						case 32:
							goto IL_2FD;
						case 33:
						{
							global::Motorola.MackinawCPS.CoreFeatures.RadioWide.TxFrequencySplitFPPInnerSection txFrequencySplitFPPInnerSection;
							if (txFrequencySplitFPPInnerSection.RadWideLabtoolTxBandSplitName_A24799.Value == global::CommonResources.AcgResources.ID_UHF2)
							{
								num = (short)1761214476;
								num3 = (int)((global::System.IntPtr)num);
								continue;
							}
							goto IL_448;
						}
						case 34:
							goto IL_599;
						case 35:
							goto IL_246;
						case 36:
							goto IL_649;
						case 37:
							num = (short)1985347624;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						case 38:
							goto IL_24B;
						case 39:
							num = (short)763559967;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						case 40:
							if (inputFrequency % 6250 == 0)
							{
								num = (short)234881050;
								num3 = (int)((global::System.IntPtr)num);
								continue;
							}
							goto IL_892;
						case 41:
							num = (short)792789017;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						case 42:
						{
							global::Motorola.MackinawCPS.CoreFeatures.RadioWide.TxFrequencySplitFPPInnerSection txFrequencySplitFPPInnerSection;
							if (inputFrequency < txFrequencySplitFPPInnerSection.RadWideLabtoolTxEndFrequencySplit_A9532Value * 5)
							{
								num = (short)349569034;
								num3 = (int)((global::System.IntPtr)num);
								continue;
							}
							break;
						}
						case 43:
							num = (short)1135476799;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						case 44:
							num = (short)1099432005;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						case 45:
							goto IL_CC6;
						case 46:
							num = (short)2110390289;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						case 47:
						{
							global::Motorola.MackinawCPS.CoreFeatures.RadioWide.TxFrequencySplitFPPInnerSection txFrequencySplitFPPInnerSection;
							if (inputFrequency > txFrequencySplitFPPInnerSection.RadWideLabtoolTxStartFrequencySplit_A9571.Value * 5)
							{
								num = (short)469106704;
								num3 = (int)((global::System.IntPtr)num);
								continue;
							}
							break;
						}
						case 48:
							goto IL_57F;
						case 49:
							num = (short)618528850;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						case 50:
						{
							global::Motorola.MackinawCPS.CoreFeatures.RadioWide.TxFrequencySplitFPPInnerSection txFrequencySplitFPPInnerSection;
							if (inputFrequency >= txFrequencySplitFPPInnerSection.RadWideLabtoolTxStartFrequencySplit_A9571.Value * 5)
							{
								num = (short)249823847;
								short num4 = num;
								num = (short)890896999;
								switch ((num4 == num) ? 1 : 0)
								{
								case 0:
								case 2:
									goto IL_8DC;
								default:
									num = (short)441778176;
									if (num != 0)
									{
									}
									num = (short)772800526;
									num3 = (int)((global::System.IntPtr)num);
									continue;
								}
							}
							break;
						}
						case 51:
							goto IL_94C;
						case 52:
							num = (short)233046091;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						case 53:
						{
							global::Motorola.MackinawCPS.CoreFeatures.RadioWide.TxFrequencySplitFPPInnerSection txFrequencySplitFPPInnerSection;
							if (inputFrequency >= txFrequencySplitFPPInnerSection.RadWideLabtoolTxStartFrequencySplit_A9571.Value * 5)
							{
								num = (short)1080098855;
								num3 = (int)((global::System.IntPtr)num);
								continue;
							}
							goto IL_530;
						}
						case 54:
						{
							global::Motorola.MackinawCPS.CoreFeatures.RadioWide.TxFrequencySplitFPPInnerSection txFrequencySplitFPPInnerSection;
							if (inputFrequency < txFrequencySplitFPPInnerSection.RadWideLabtoolTxEndFrequencySplit_A9532Value * 5)
							{
								num = (short)1461321805;
								num3 = (int)((global::System.IntPtr)num);
								continue;
							}
							break;
						}
						case 55:
						{
							global::Motorola.MackinawCPS.CoreFeatures.RadioWide.TxFrequencySplitFPPInnerSection txFrequencySplitFPPInnerSection;
							if (txFrequencySplitFPPInnerSection.RadWideLabtoolTxBandSplitName_A24799.Value == global::CommonResources.AcgResources.ID_UHF1)
							{
								num = (short)1006436414;
								num3 = (int)((global::System.IntPtr)num);
								continue;
							}
							goto IL_7FD;
						}
						case 56:
							num = (short)660340789;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						case 57:
						{
							global::Motorola.MackinawCPS.CoreFeatures.RadioWide.TxFrequencySplitFPPInnerSection txFrequencySplitFPPInnerSection;
							if (inputFrequency >= txFrequencySplitFPPInnerSection.RadWideLabtoolTxStartFrequencySplit_A9571.Value * 5)
							{
								num = (short)1137311812;
								num3 = (int)((global::System.IntPtr)num);
								continue;
							}
							goto IL_7FD;
						}
						case 58:
						{
							global::Motorola.MackinawCPS.CoreFeatures.RadioWide.TxFrequencySplitFPPInnerSection txFrequencySplitFPPInnerSection;
							if (txFrequencySplitFPPInnerSection.RadWideLabtoolTxBandSplitName_A24799.Value == global::CommonResources.AcgResources.ID_VHF)
							{
								num = (short)416153656;
								num3 = (int)((global::System.IntPtr)num);
								continue;
							}
							goto IL_530;
						}
						case 59:
							if (self is global::Motorola.MackinawCPS.CoreFeatures.ConventionalPersonality.FrequencyOptionsInnerSection)
							{
								num = (short)649592902;
								num3 = (int)((global::System.IntPtr)num);
								continue;
							}
							result = true;
							num = (short)2146959433;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						case 60:
						{
							global::Motorola.MackinawCPS.CoreFeatures.RadioWide.TxFrequencySplitFPPInnerSection txFrequencySplitFPPInnerSection;
							if (inputFrequency > txFrequencySplitFPPInnerSection.RadWideLabtoolTxStartFrequencySplit_A9571.Value * 5)
							{
								num = (short)1929707563;
								num3 = (int)((global::System.IntPtr)num);
								continue;
							}
							goto IL_892;
						}
						case 61:
							num = (short)1798111290;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						case 62:
							num = (short)1696202809;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						case 63:
						{
							global::Motorola.MackinawCPS.CoreFeatures.RadioWide.TxFrequencySplitFPPInnerSection txFrequencySplitFPPInnerSection;
							if (inputFrequency < txFrequencySplitFPPInnerSection.RadWideLabtoolTxEndFrequencySplit_A9532Value * 5)
							{
								num = (short)1099235365;
								num3 = (int)((global::System.IntPtr)num);
								continue;
							}
							goto IL_892;
						}
						case 64:
							goto IL_62E;
						case 65:
							switch (0)
							{
							case 0:
								goto IL_225;
							}
							continue;
						case 66:
							num = (short)1872560150;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						case 67:
							result = true;
							num = (short)1653342243;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						case 68:
							num = (short)300023813;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						case 69:
							if (inputFrequency % 5000 != 0)
							{
								num = (short)1003421748;
								num3 = (int)((global::System.IntPtr)num);
								continue;
							}
							goto IL_57F;
						case 70:
						{
							global::Motorola.MackinawCPS.CoreFeatures.ConventionalPersonality.FrequencyOptionsInnerSection frequencyOptionsInnerSection = self as global::Motorola.MackinawCPS.CoreFeatures.ConventionalPersonality.FrequencyOptionsInnerSection;
							num = (short)998703112;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						}
						case 71:
							num = (short)1412825092;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						case 72:
							num = (short)1073217539;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						case 73:
							goto IL_D28;
						case 74:
						{
							global::Motorola.MackinawCPS.CoreFeatures.RadioWide.TxFrequencySplitFPPInnerSection txFrequencySplitFPPInnerSection;
							if (txFrequencySplitFPPInnerSection != null)
							{
								num = (short)1033568317;
								num3 = (int)((global::System.IntPtr)num);
								continue;
							}
							break;
						}
						case 75:
							if (inputFrequency % 6250 == 0)
							{
								num = (short)1280639024;
								num3 = (int)((global::System.IntPtr)num);
								continue;
							}
							goto IL_7FD;
						case 76:
							if (inputFrequency % 6250 == 0)
							{
								num = (short)1586102336;
								num3 = (int)((global::System.IntPtr)num);
								continue;
							}
							goto IL_448;
						case 77:
							num = (short)1282539606;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						case 78:
							goto IL_E6C;
						case 79:
							num = (short)503906332;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						case 80:
							goto IL_951;
						case 81:
						{
							global::Motorola.MackinawCPS.CoreFeatures.RadioWide.TxFrequencySplitFPPInnerSection txFrequencySplitFPPInnerSection;
							if (inputFrequency >= txFrequencySplitFPPInnerSection.RadWideLabtoolTxStartFrequencySplit_A9571.Value * 5)
							{
								num = (short)1562574889;
								num3 = (int)((global::System.IntPtr)num);
								continue;
							}
							goto IL_448;
						}
						case 82:
						{
							global::Motorola.MackinawCPS.CoreFeatures.RadioWide.TxFrequencySplitFPPInnerSection txFrequencySplitFPPInnerSection;
							if (inputFrequency < txFrequencySplitFPPInnerSection.RadWideLabtoolTxEndFrequencySplit_A9532Value * 5)
							{
								num = (short)1849622574;
								num3 = (int)((global::System.IntPtr)num);
								continue;
							}
							goto IL_26A;
						}
						case 83:
							goto IL_8DC;
						case 84:
						{
							if (!enumerator.MoveNext())
							{
								num = (short)219086854;
								num3 = (int)((global::System.IntPtr)num);
								continue;
							}
							global::Motorola.MackinawCPS.CoreFeatures.RadioWide.TxFrequencySplitFPPInnerSection txFrequencySplitFPPInnerSection = ((global::AcpCommonLib.IAcpFeatureNode)enumerator.Current)[10095] as global::Motorola.MackinawCPS.CoreFeatures.RadioWide.TxFrequencySplitFPPInnerSection;
							num = (short)1545207882;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						}
						case 85:
							result = true;
							num = (short)2056388635;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						case 86:
							if (inputFrequency % 12500 == 0)
							{
								num = (short)891617365;
								num3 = (int)((global::System.IntPtr)num);
								continue;
							}
							break;
						case 87:
						{
							global::Motorola.MackinawCPS.CoreFeatures.RadioWide.TxFrequencySplitFPPInnerSection txFrequencySplitFPPInnerSection;
							if (!(txFrequencySplitFPPInnerSection.RadWideLabtoolTxBandSplitName_A24799.Value == global::CommonResources.AcgResources.ID_P_900M_1))
							{
								num = (short)1887502347;
								num3 = (int)((global::System.IntPtr)num);
								continue;
							}
							goto IL_2FD;
						}
						}
						goto IL_225;
						IL_24B:
						result = true;
						num = (short)1352138776;
						num3 = (int)((global::System.IntPtr)num);
						continue;
						IL_26A:
						num = (short)169082930;
						num3 = (int)((global::System.IntPtr)num);
						continue;
						IL_2FD:
						num = (short)19136559;
						num3 = (int)((global::System.IntPtr)num);
						continue;
						IL_448:
						num = (short)1604845587;
						num3 = (int)((global::System.IntPtr)num);
						continue;
						IL_530:
						num = (short)1631191095;
						num3 = (int)((global::System.IntPtr)num);
						continue;
						IL_57F:
						result = true;
						num = (short)327090210;
						num3 = (int)((global::System.IntPtr)num);
						continue;
						IL_62E:
						result = true;
						num = (short)1596915748;
						num3 = (int)((global::System.IntPtr)num);
						continue;
						IL_7FD:
						num = (short)543555617;
						num3 = (int)((global::System.IntPtr)num);
						continue;
						IL_892:
						num = (short)2139750400;
						num3 = (int)((global::System.IntPtr)num);
						continue;
						IL_8DC:
						num = (short)546439181;
						num3 = (int)((global::System.IntPtr)num);
						continue;
						IL_951:
						num = (short)663355452;
						num3 = (int)((global::System.IntPtr)num);
						continue;
						IL_CC6:
						num = (short)931266583;
						num3 = (int)((global::System.IntPtr)num);
						continue;
						IL_D70:
						num = (short)2080047188;
						num3 = (int)((global::System.IntPtr)num);
						continue;
						IL_225:
						goto IL_D70;
					}
					IL_246:
					IL_265:
					IL_443:
					IL_599:
					IL_649:
					IL_94C:
					IL_D28:
					IL_DCB:
					return result;
					IL_E6C:
					return false;
				}
				finally
				{
					num = (short)807337985;
					int num3 = (int)((global::System.IntPtr)num);
					for (;;)
					{
						switch (num3)
						{
						case 0:
							enumerator.Dispose();
							num = (short)842203138;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						case 1:
							switch (0)
							{
							case 0:
								goto IL_EA5;
							}
							continue;
						case 2:
							goto IL_EDB;
						}
						IL_EA5:
						if (enumerator == null)
						{
							break;
						}
						num = (short)1664745472;
						num3 = (int)((global::System.IntPtr)num);
					}
					IL_EDB:;
				}
				return result;
			}
			}
		}

		// Token: 0x0600D090 RID: 53392 RVA: 0x00C24800 File Offset: 0x00C22A00
		public static bool IsTxFrquencyBandValidOn7800And900ForAstro25(int inputRxFrequency, int inputTxFrequency)
		{
			global::AcpCommonLib.IAcpRecordset embeddedRecset = ((global::Motorola.MackinawCPS.CoreFeatures.RadioWide.RadioWideRecset)global::AcpCommonLib.FeatureManager.GetFeature(2045))[0][10096].EmbeddedRecset;
			global::System.Collections.Generic.IEnumerator<global::AcpBusinessLayer.FeatureNode> enumerator = (((global::Motorola.MackinawCPS.CoreFeatures.RadioWide.RadioWideRecset)global::AcpCommonLib.FeatureManager.GetFeature(2045))[0][10094].EmbeddedRecset as global::Motorola.MackinawCPS.CoreFeatures.RadioWide.TxFrequencySplitFPPInnerRecset).GetEnumerator();
			short num;
			bool result;
			try
			{
				num = (short)1728118801;
				int num2 = (int)((global::System.IntPtr)num);
				for (;;)
				{
					switch (num2)
					{
					case 0:
						goto IL_5AF;
					case 1:
					{
						global::Motorola.MackinawCPS.CoreFeatures.RadioWide.TxFrequencySplitFPPInnerSection txFrequencySplitFPPInnerSection;
						if (inputTxFrequency < txFrequencySplitFPPInnerSection.RadWideLabtoolTxEndFrequencySplit_A9532.Value * 5)
						{
							num = (short)1986920478;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_1DB;
					}
					case 2:
						goto IL_244;
					case 3:
					{
						global::Motorola.MackinawCPS.CoreFeatures.RadioWide.TxFrequencySplitFPPInnerSection txFrequencySplitFPPInnerSection;
						if (txFrequencySplitFPPInnerSection.RadWideLabtoolTxBandSplitName_A24799.Value == global::CommonResources.AcgResources.ID_P_700M_2)
						{
							num = (short)1958346757;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_347;
					}
					case 4:
						result = true;
						num = (short)1614938114;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 5:
						num = (short)1854078999;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 6:
						num = (short)1463943168;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 7:
					{
						global::Motorola.MackinawCPS.CoreFeatures.RadioWide.TxFrequencySplitFPPInnerSection txFrequencySplitFPPInnerSection;
						if (inputTxFrequency < txFrequencySplitFPPInnerSection.RadWideLabtoolTxEndFrequencySplit_A9532.Value * 5)
						{
							num = (short)1187774479;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						break;
					}
					case 8:
						goto IL_45B;
					case 9:
					{
						num = (short)663473423;
						short num3 = num;
						num = (short)66571535;
						switch ((num3 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_244;
						default:
							num = (short)608043008;
							if (num != 0)
							{
							}
							num = (short)1053622284;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						break;
					}
					case 10:
						if (inputTxFrequency == inputRxFrequency - 39000000)
						{
							num = (short)150274052;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						break;
					case 11:
					{
						global::Motorola.MackinawCPS.CoreFeatures.RadioWide.TxFrequencySplitFPPInnerSection txFrequencySplitFPPInnerSection;
						if (txFrequencySplitFPPInnerSection.RadWideLabtoolTxBandSplitName_A24799.Value == global::CommonResources.AcgResources.ID_P_900M_1)
						{
							num = (short)824049692;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						break;
					}
					case 12:
					{
						global::Motorola.MackinawCPS.CoreFeatures.RadioWide.TxFrequencySplitFPPInnerSection txFrequencySplitFPPInnerSection;
						if (inputTxFrequency >= txFrequencySplitFPPInnerSection.RadWideLabtoolTxStartFrequencySplit_A9571.Value * 5)
						{
							num = (short)356450320;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_1DB;
					}
					case 13:
						result = true;
						num = (short)289079320;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 14:
						result = true;
						num = (short)810745864;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 15:
						num = (short)367001610;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 16:
						num = (short)1473708033;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 17:
						switch (0)
						{
						case 0:
							goto IL_14A;
						}
						continue;
					case 18:
						num = (short)649134087;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 19:
						if (inputTxFrequency == inputRxFrequency + 30000000)
						{
							num = (short)1065025550;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_347;
					case 20:
					{
						global::Motorola.MackinawCPS.CoreFeatures.RadioWide.TxFrequencySplitFPPInnerSection txFrequencySplitFPPInnerSection;
						if (inputTxFrequency > txFrequencySplitFPPInnerSection.RadWideLabtoolTxStartFrequencySplit_A9571.Value * 5)
						{
							num = (short)1585315858;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						break;
					}
					case 21:
					{
						if (!enumerator.MoveNext())
						{
							num = (short)1852637190;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						global::Motorola.MackinawCPS.CoreFeatures.RadioWide.TxFrequencySplitFPPInnerSection txFrequencySplitFPPInnerSection = ((global::AcpCommonLib.IAcpFeatureNode)enumerator.Current)[10095] as global::Motorola.MackinawCPS.CoreFeatures.RadioWide.TxFrequencySplitFPPInnerSection;
						num = (short)1836974083;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 22:
					{
						global::Motorola.MackinawCPS.CoreFeatures.RadioWide.TxFrequencySplitFPPInnerSection txFrequencySplitFPPInnerSection;
						if (txFrequencySplitFPPInnerSection.RadWideLabtoolTxBandSplitName_A24799.Value == global::CommonResources.AcgResources.ID_P_800M_1)
						{
							num = (short)1867907081;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_1DB;
					}
					case 23:
					{
						global::Motorola.MackinawCPS.CoreFeatures.RadioWide.TxFrequencySplitFPPInnerSection txFrequencySplitFPPInnerSection;
						if (inputTxFrequency > txFrequencySplitFPPInnerSection.RadWideLabtoolTxStartFrequencySplit_A9571.Value * 5)
						{
							num = (short)1661796377;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_347;
					}
					case 24:
						goto IL_54B;
					case 25:
						num = (short)665518109;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 26:
						if (inputTxFrequency == inputRxFrequency - 45000000)
						{
							num = (short)1321009165;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_1DB;
					case 27:
						num = (short)1958608915;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 28:
						num = (short)890503188;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 29:
					{
						global::Motorola.MackinawCPS.CoreFeatures.RadioWide.TxFrequencySplitFPPInnerSection txFrequencySplitFPPInnerSection;
						if (inputTxFrequency < txFrequencySplitFPPInnerSection.RadWideLabtoolTxEndFrequencySplit_A9532.Value * 5)
						{
							num = (short)805830683;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_347;
					}
					case 30:
						num = (short)395116570;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_14A;
					IL_1DB:
					num = (short)654180363;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_308:
					num = (short)760545301;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_14A:
					goto IL_308;
					IL_347:
					num = (short)795934742;
					num2 = (int)((global::System.IntPtr)num);
				}
				IL_244:
				IL_45B:
				IL_54B:
				return result;
				IL_5AF:
				goto IL_56;
			}
			finally
			{
				num = (short)703528961;
				int num2 = (int)((global::System.IntPtr)num);
				for (;;)
				{
					switch (num2)
					{
					case 0:
						enumerator.Dispose();
						num = (short)1741422594;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 1:
						switch (0)
						{
						case 0:
							goto IL_5E5;
						}
						continue;
					case 2:
						goto IL_61A;
					}
					IL_5E5:
					if (enumerator == null)
					{
						break;
					}
					num = (short)1499267072;
					num2 = (int)((global::System.IntPtr)num);
				}
				IL_61A:;
			}
			return result;
			IL_56:
			num = (short)1187184640;
			short num4 = num;
			num = (short)60817409;
			if (num != 0)
			{
			}
			return false;
		}

		// Token: 0x0600D091 RID: 53393 RVA: 0x00C24E48 File Offset: 0x00C23048
		public static bool Is7800MHzUsedinCodeplug()
		{
			short num;
			int num3;
			global::Motorola.MackinawCPS.CoreFeatures.RadioInformation.FrequencyRanges frequencyRanges;
			switch (0)
			{
			case 0:
				break;
			default:
			{
				for (;;)
				{
					IL_0A:
					num = (short)771704413;
					short num2 = num;
					num = (short)1798915677;
					switch ((num2 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_8F;
					default:
						num = (short)796852224;
						if (num != 0)
						{
						}
						switch (num3)
						{
						case 0:
							goto IL_110;
						case 1:
							if (!global::ConstraintHelper.UtilityMack.IsFreonRadio)
							{
								num = (short)1813774339;
								num3 = (int)((global::System.IntPtr)num);
								continue;
							}
							num = (short)955318274;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						case 2:
							if (frequencyRanges.RadInfoFrequencyRanges700MHzUsedinCodeplug_A42551.Value)
							{
								num = (short)1577058304;
								num3 = (int)((global::System.IntPtr)num);
								continue;
							}
							return false;
						case 3:
							goto IL_C7;
						}
						goto IL_6A;
					}
				}
				IL_C7:
				num = (short)116195329;
				if (num != 0)
				{
				}
				return frequencyRanges.RadInfoFrequencyRanges7800MHzUsedinCodeplug_A8512.Value;
				IL_110:
				num = (short)2073952256;
				short num4 = num;
				return frequencyRanges.RadInfoFrequencyRanges800MHzUsedinCodeplug_A42552.Value;
			}
			}
			IL_6A:
			frequencyRanges = (((global::Motorola.MackinawCPS.CoreFeatures.RadioInformation.RadioInformationRecset)global::AcpCommonLib.FeatureManager.GetFeature(2049))[0][10110] as global::Motorola.MackinawCPS.CoreFeatures.RadioInformation.FrequencyRanges);
			IL_8F:
			num = (short)679673857;
			num3 = (int)((global::System.IntPtr)num);
			goto IL_0A;
		}

		// Token: 0x0600D092 RID: 53394 RVA: 0x00C24FC8 File Offset: 0x00C231C8
		public static bool IsRxFrequencyBandEnabled(int inputFrequency, bool isTalkaround = false)
		{
			short num = (short)224460800;
			int num2 = (int)num;
			switch (num2)
			{
			default:
			{
				num = (short)1593376769;
				if (num != 0)
				{
				}
				switch (0)
				{
				case 0:
					goto IL_20F;
				}
				global::AcpBusinessLayer.AcpField<bool> radInfoGeneralPrimaryFrequencyBand900_A;
				bool isFreonRadio;
				global::AcpBusinessLayer.AcpListField radInfoLabtoolSecondaryBands_A;
				global::AcpBusinessLayer.AcpListField radInfoLabtoolPrimaryBands_A;
				global::AcpBusinessLayer.AcpField<bool> radInfoFrequencyRanges800MHzUsedinCodeplug_A;
				global::AcpBusinessLayer.AcpField<bool> radInfoFrequencyRanges700MHzUsedinCodeplug_A;
				global::AcpBusinessLayer.AcpField<bool> radInfoFrequencyRangesAllowInvalidFrequencies_A;
				global::AcpBusinessLayer.AcpField<bool> radInfoLabtoolDualBandEnable_A;
				global::AcpBusinessLayer.AcpField<bool> radInfoGeneralPrimaryFrequencyBandVHF_A;
				global::AcpBusinessLayer.AcpField<bool> radInfoFrequencyRangesUHF1UsedinCodeplug_A;
				global::AcpBusinessLayer.AcpField<bool> radInfoGeneralPrimaryFrequencyBandUHF2_A;
				global::AcpBusinessLayer.AcpField<bool> radInfoFrequencyRanges7800MHzUsedinCodeplug_A;
				global::AcpBusinessLayer.AcpField<bool> radInfoFrequencyRanges900MHzUsedinCodeplug_A;
				global::AcpBusinessLayer.AcpField<bool> radInfoGeneralPrimaryFrequencyBand800_A;
				global::AcpBusinessLayer.AcpField<bool> radInfoFrequencyRangesVHFUsedinCodeplug_A;
				global::AcpBusinessLayer.AcpField<bool> radInfoFrequencyRanges8900MHzUsedinCodeplug_A;
				global::AcpBusinessLayer.AcpField<bool> radInfoGeneralPrimaryFrequencyBandUHF1_A;
				global::AcpBusinessLayer.AcpField<bool> radInfoGeneralPrimaryFrequencyBand700_A;
				global::AcpBusinessLayer.AcpField<bool> radInfoFrequencyRangesUHF2UsedinCodeplug_A;
				global::Motorola.MackinawCPS.CoreFeatures.RadioWide.RxFrequencySplitFPPInnerRecset rxFrequencySplitFPPInnerRecset;
				for (;;)
				{
					IL_50:
					global::System.Collections.Generic.IEnumerator<global::AcpBusinessLayer.FeatureNode> enumerator;
					switch (num2)
					{
					case 0:
						if (!radInfoGeneralPrimaryFrequencyBand900_A.Value)
						{
							num = (short)1661206593;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_257B;
					case 1:
						goto IL_23CC;
					case 2:
						try
						{
							num = (short)955908116;
							num2 = (int)((global::System.IntPtr)num);
							bool result;
							for (;;)
							{
								switch (num2)
								{
								case 0:
									goto IL_27E1;
								case 1:
									if (isTalkaround)
									{
										num = (short)354680844;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									break;
								case 2:
									result = true;
									num = (short)1477574672;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 3:
								{
									global::Motorola.MackinawCPS.CoreFeatures.RadioWide.RxFrequencySplitFPPInnerSection rxFrequencySplitFPPInnerSection;
									if (rxFrequencySplitFPPInnerSection != null)
									{
										num = (short)103940114;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									goto IL_286C;
								}
								case 4:
								{
									global::Motorola.MackinawCPS.CoreFeatures.RadioWide.RxFrequencySplitFPPInnerSection rxFrequencySplitFPPInnerSection;
									if (inputFrequency < rxFrequencySplitFPPInnerSection.RadWideLabtoolRxEndFrequencySplit_A9015.Value * 5)
									{
										num = (short)1062600723;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									goto IL_286C;
								}
								case 5:
								{
									global::Motorola.MackinawCPS.CoreFeatures.RadioWide.RxFrequencySplitFPPInnerSection rxFrequencySplitFPPInnerSection;
									if (!(rxFrequencySplitFPPInnerSection.RadWideLabtoolRxBandSplitName_A24797.Value == global::CommonResources.AcgResources.ID_P_700M))
									{
										num = (short)1099563021;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									goto IL_267F;
								}
								case 6:
									num = (short)1751580676;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 7:
								{
									if (!enumerator.MoveNext())
									{
										num = (short)286916618;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									global::Motorola.MackinawCPS.CoreFeatures.RadioWide.RxFrequencySplitFPPInnerSection rxFrequencySplitFPPInnerSection = ((global::AcpCommonLib.IAcpFeatureNode)enumerator.Current)[10097] as global::Motorola.MackinawCPS.CoreFeatures.RadioWide.RxFrequencySplitFPPInnerSection;
									num = (short)1919352835;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 8:
								{
									global::Motorola.MackinawCPS.CoreFeatures.RadioWide.RxFrequencySplitFPPInnerSection rxFrequencySplitFPPInnerSection;
									if (inputFrequency < rxFrequencySplitFPPInnerSection.RadWideLabtoolRxEndFrequencySplit_A9015.Value * 5)
									{
										num = (short)1312817154;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									break;
								}
								case 9:
								{
									global::Motorola.MackinawCPS.CoreFeatures.RadioWide.RxFrequencySplitFPPInnerSection rxFrequencySplitFPPInnerSection;
									if (inputFrequency >= rxFrequencySplitFPPInnerSection.RadWideLabtoolRxStartFrequencySplit_A9032.Value * 5)
									{
										num = (short)566231057;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									break;
								}
								case 10:
									num = (short)1471610902;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 11:
								{
									global::Motorola.MackinawCPS.CoreFeatures.RadioWide.RxFrequencySplitFPPInnerSection rxFrequencySplitFPPInnerSection;
									if (rxFrequencySplitFPPInnerSection.RadWideLabtoolRxBandSplitName_A24797.Value == global::CommonResources.AcgResources.ID_P_700M_1)
									{
										num = (short)645201941;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									goto IL_286C;
								}
								case 12:
									num = (short)1479213070;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 13:
									num = (short)690618379;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 14:
								{
									global::Motorola.MackinawCPS.CoreFeatures.RadioWide.RxFrequencySplitFPPInnerSection rxFrequencySplitFPPInnerSection;
									if (rxFrequencySplitFPPInnerSection.RadWideLabtoolRxBandSplitName_A24797.Value == global::CommonResources.AcgResources.ID_P_700M_2)
									{
										num = (short)245432344;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									break;
								}
								case 15:
								{
									global::Motorola.MackinawCPS.CoreFeatures.RadioWide.RxFrequencySplitFPPInnerSection rxFrequencySplitFPPInnerSection;
									if (inputFrequency > rxFrequencySplitFPPInnerSection.RadWideLabtoolRxStartFrequencySplit_A9032.Value * 5)
									{
										num = (short)679084038;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									goto IL_286C;
								}
								case 16:
									goto IL_272C;
								case 17:
									num = (short)1360592904;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 18:
									num = (short)1041104901;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 19:
									result = true;
									num = (short)1318846464;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 20:
									switch (0)
									{
									case 0:
										goto IL_2630;
									}
									continue;
								case 21:
									goto IL_267F;
								case 22:
									goto IL_29B1;
								case 23:
								{
									global::Motorola.MackinawCPS.CoreFeatures.RadioWide.RxFrequencySplitFPPInnerSection rxFrequencySplitFPPInnerSection;
									if (rxFrequencySplitFPPInnerSection != null)
									{
										num = (short)1786052633;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									break;
								}
								case 24:
									num = (short)981270537;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 25:
									num = (short)1382023169;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								goto IL_2630;
								IL_267F:
								num = (short)1210712079;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								IL_2731:
								num = (short)902889479;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								IL_2630:
								goto IL_2731;
								IL_286C:
								num = (short)653262871;
								num2 = (int)((global::System.IntPtr)num);
							}
							IL_272C:
							IL_27E1:
							return result;
							IL_29B1:
							goto IL_11C7;
						}
						finally
						{
							num = (short)1391853570;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								switch (num2)
								{
								case 0:
									goto IL_2A20;
								case 1:
									enumerator.Dispose();
									num = (short)1629749248;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 2:
									switch (0)
									{
									case 0:
										goto IL_29E9;
									}
									continue;
								}
								IL_29E9:
								if (enumerator == null)
								{
									break;
								}
								num = (short)1606877185;
								num2 = (int)((global::System.IntPtr)num);
							}
							IL_2A20:;
						}
						return false;
					case 3:
						goto IL_23A7;
					case 4:
						if (!isFreonRadio)
						{
							num = (short)1965031450;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_ED8;
					case 5:
						if (radInfoLabtoolSecondaryBands_A.Value != 3)
						{
							num = (short)918421578;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_11A2;
					case 6:
						num = (short)775749704;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 7:
						num = (short)1805320239;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 8:
						try
						{
							num = (short)103612416;
							num2 = (int)((global::System.IntPtr)num);
							bool result;
							for (;;)
							{
								switch (num2)
								{
								case 0:
									switch (0)
									{
									case 0:
										goto IL_193D;
									}
									continue;
								case 1:
									goto IL_1C30;
								case 2:
									num = (short)1109327892;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 3:
									num = (short)459407364;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 4:
								{
									global::Motorola.MackinawCPS.CoreFeatures.RadioWide.RxFrequencySplitFPPInnerSection rxFrequencySplitFPPInnerSection2;
									if (rxFrequencySplitFPPInnerSection2.RadWideLabtoolRxBandSplitName_A24797.Value == global::CommonResources.AcgResources.ID_P_800M)
									{
										num = (short)153681930;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									break;
								}
								case 5:
								{
									global::Motorola.MackinawCPS.CoreFeatures.RadioWide.RxFrequencySplitFPPInnerSection rxFrequencySplitFPPInnerSection2;
									if (inputFrequency < rxFrequencySplitFPPInnerSection2.RadWideLabtoolRxEndFrequencySplit_A9015.Value * 5)
									{
										num = (short)320798731;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									goto IL_1A11;
								}
								case 6:
								{
									global::Motorola.MackinawCPS.CoreFeatures.RadioWide.RxFrequencySplitFPPInnerSection rxFrequencySplitFPPInnerSection2;
									if (inputFrequency >= rxFrequencySplitFPPInnerSection2.RadWideLabtoolRxStartFrequencySplit_A9032.Value * 5)
									{
										num = (short)830734338;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									break;
								}
								case 7:
									num = (short)2111569933;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 8:
									goto IL_1A67;
								case 9:
								{
									global::Motorola.MackinawCPS.CoreFeatures.RadioWide.RxFrequencySplitFPPInnerSection rxFrequencySplitFPPInnerSection2;
									if (rxFrequencySplitFPPInnerSection2 != null)
									{
										num = (short)120717330;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									goto IL_1A11;
								}
								case 10:
									num = (short)584253446;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 11:
									result = true;
									num = (short)392560648;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 12:
									goto IL_1BC2;
								case 13:
								{
									global::Motorola.MackinawCPS.CoreFeatures.RadioWide.RxFrequencySplitFPPInnerSection rxFrequencySplitFPPInnerSection2;
									if (inputFrequency > rxFrequencySplitFPPInnerSection2.RadWideLabtoolRxStartFrequencySplit_A9032.Value * 5)
									{
										num = (short)83296272;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									goto IL_1A11;
								}
								case 14:
								{
									global::Motorola.MackinawCPS.CoreFeatures.RadioWide.RxFrequencySplitFPPInnerSection rxFrequencySplitFPPInnerSection2;
									if (rxFrequencySplitFPPInnerSection2 != null)
									{
										num = (short)555220995;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									break;
								}
								case 15:
									num = (short)1934950401;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 16:
									num = (short)1852964869;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 17:
									result = true;
									num = (short)1750925324;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 18:
									num = (short)1551630357;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 19:
								{
									if (!enumerator.MoveNext())
									{
										num = (short)1426784271;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									global::Motorola.MackinawCPS.CoreFeatures.RadioWide.RxFrequencySplitFPPInnerSection rxFrequencySplitFPPInnerSection2 = ((global::AcpCommonLib.IAcpFeatureNode)enumerator.Current)[10097] as global::Motorola.MackinawCPS.CoreFeatures.RadioWide.RxFrequencySplitFPPInnerSection;
									num = (short)1553661961;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 20:
								{
									global::Motorola.MackinawCPS.CoreFeatures.RadioWide.RxFrequencySplitFPPInnerSection rxFrequencySplitFPPInnerSection2;
									if (inputFrequency < rxFrequencySplitFPPInnerSection2.RadWideLabtoolRxEndFrequencySplit_A9015.Value * 5)
									{
										num = (short)206307345;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									break;
								}
								case 21:
								{
									global::Motorola.MackinawCPS.CoreFeatures.RadioWide.RxFrequencySplitFPPInnerSection rxFrequencySplitFPPInnerSection2;
									if (rxFrequencySplitFPPInnerSection2.RadWideLabtoolRxBandSplitName_A24797.Value == global::CommonResources.AcgResources.ID_P_700M)
									{
										num = (short)1852440583;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									goto IL_1A11;
								}
								}
								IL_19D0:
								num = (short)1794310163;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								IL_193D:
								goto IL_19D0;
								IL_1A11:
								num = (short)273154062;
								num2 = (int)((global::System.IntPtr)num);
							}
							IL_1A67:
							IL_1BC2:
							return result;
							IL_1C30:
							goto IL_DD0;
						}
						finally
						{
							num = (short)1290928128;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								switch (num2)
								{
								case 0:
									switch (0)
									{
									case 0:
										goto IL_1C68;
									}
									continue;
								case 1:
									enumerator.Dispose();
									num = (short)2076770306;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 2:
									goto IL_1CA0;
								}
								IL_1C68:
								if (enumerator == null)
								{
									break;
								}
								num = (short)2007498753;
								num2 = (int)((global::System.IntPtr)num);
							}
							IL_1CA0:;
						}
						goto IL_1CA3;
					case 9:
						if (isFreonRadio)
						{
							num = (short)2037186628;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_3B9;
					case 10:
						if (radInfoLabtoolPrimaryBands_A.Value != 2)
						{
							num = (short)98435118;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_11A2;
					case 11:
						if (radInfoFrequencyRanges800MHzUsedinCodeplug_A.Value)
						{
							num = (short)343015425;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_92D;
					case 12:
						if (radInfoFrequencyRanges700MHzUsedinCodeplug_A.Value)
						{
							num = (short)929693782;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_11C7;
					case 13:
						if (radInfoFrequencyRangesAllowInvalidFrequencies_A.Value)
						{
							num = (short)1813184535;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_92D;
					case 14:
						try
						{
							num = (short)13500418;
							num2 = (int)((global::System.IntPtr)num);
							bool result;
							for (;;)
							{
								switch (num2)
								{
								case 0:
									num = (short)239730697;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 1:
								{
									global::Motorola.MackinawCPS.CoreFeatures.RadioWide.RxFrequencySplitFPPInnerSection rxFrequencySplitFPPInnerSection3;
									if (rxFrequencySplitFPPInnerSection3 != null)
									{
										num = (short)1527185418;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									break;
								}
								case 2:
									switch (0)
									{
									case 0:
										goto IL_1ECF;
									}
									continue;
								case 3:
								{
									global::Motorola.MackinawCPS.CoreFeatures.RadioWide.RxFrequencySplitFPPInnerSection rxFrequencySplitFPPInnerSection3;
									if (rxFrequencySplitFPPInnerSection3.RadWideLabtoolRxBandSplitName_A24797.Value == global::CommonResources.AcgResources.ID_P_900M)
									{
										num = (short)1190264832;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									break;
								}
								case 4:
									num = (short)1330315271;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 5:
								{
									if (!enumerator.MoveNext())
									{
										num = (short)1155727364;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									global::Motorola.MackinawCPS.CoreFeatures.RadioWide.RxFrequencySplitFPPInnerSection rxFrequencySplitFPPInnerSection3 = ((global::AcpCommonLib.IAcpFeatureNode)enumerator.Current)[10097] as global::Motorola.MackinawCPS.CoreFeatures.RadioWide.RxFrequencySplitFPPInnerSection;
									num = (short)2062483457;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 6:
								{
									global::Motorola.MackinawCPS.CoreFeatures.RadioWide.RxFrequencySplitFPPInnerSection rxFrequencySplitFPPInnerSection3;
									if (inputFrequency <= rxFrequencySplitFPPInnerSection3.RadWideLabtoolRxEndFrequencySplit_A9015.Value * 5 - 12500)
									{
										num = (short)1539506188;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									break;
								}
								case 7:
									goto IL_2081;
								case 8:
									num = (short)818741254;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 9:
								{
									global::Motorola.MackinawCPS.CoreFeatures.RadioWide.RxFrequencySplitFPPInnerSection rxFrequencySplitFPPInnerSection3;
									if (inputFrequency >= rxFrequencySplitFPPInnerSection3.RadWideLabtoolRxStartFrequencySplit_A9032.Value * 5 + 12500)
									{
										num = (short)1903493128;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									break;
								}
								case 10:
									num = (short)1287323651;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 11:
									goto IL_1FD7;
								case 12:
									result = true;
									num = (short)713752587;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								IL_1FDC:
								num = (short)54263813;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								IL_1ECF:
								goto IL_1FDC;
							}
							IL_1FD7:
							return result;
							IL_2081:
							return false;
						}
						finally
						{
							num = (short)2026045440;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								switch (num2)
								{
								case 0:
									switch (0)
									{
									case 0:
										goto IL_20B8;
									}
									continue;
								case 1:
									enumerator.Dispose();
									num = (short)56229890;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 2:
									goto IL_20EF;
								}
								IL_20B8:
								if (enumerator == null)
								{
									break;
								}
								num = (short)739180545;
								num2 = (int)((global::System.IntPtr)num);
							}
							IL_20EF:;
						}
						goto Block_50;
					case 15:
						goto IL_20F2;
					case 16:
						num = (short)1788936237;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 17:
						num = (short)1556086821;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 18:
						if (radInfoFrequencyRangesAllowInvalidFrequencies_A.Value)
						{
							num = (short)314966050;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_11C7;
					case 19:
						if (radInfoFrequencyRangesAllowInvalidFrequencies_A.Value)
						{
							num = (short)505938003;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_1E36;
					case 20:
						num = (short)519634955;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 21:
						if (radInfoLabtoolDualBandEnable_A.Value)
						{
							num = (short)1518141446;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_376;
					case 22:
						if (!radInfoGeneralPrimaryFrequencyBandVHF_A.Value)
						{
							num = (short)144113751;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_11A2;
					case 23:
						num = (short)1699151945;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 24:
						if (radInfoFrequencyRangesAllowInvalidFrequencies_A.Value)
						{
							num = (short)1685848084;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_92D;
					case 25:
						goto IL_153C;
					case 26:
						num = (short)1142685799;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 27:
						goto IL_11A2;
					case 28:
						if (radInfoFrequencyRangesAllowInvalidFrequencies_A.Value)
						{
							num = (short)1177419837;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_101C;
					case 29:
						if (radInfoFrequencyRangesUHF1UsedinCodeplug_A.Value)
						{
							num = (short)410845293;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_101C;
					case 30:
						goto IL_2367;
					case 31:
						if (isFreonRadio)
						{
							num = (short)1501626385;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_D55;
					case 32:
						if (radInfoLabtoolDualBandEnable_A.Value)
						{
							num = (short)1261961287;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_2434;
					case 33:
						num = (short)1499922474;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 34:
						goto IL_1801;
					case 35:
						goto IL_F1A;
					case 36:
						goto IL_2434;
					case 37:
						if (!radInfoGeneralPrimaryFrequencyBandUHF2_A.Value)
						{
							num = (short)448790620;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_1DD2;
					case 38:
						num = (short)859242539;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 39:
						if (radInfoFrequencyRangesAllowInvalidFrequencies_A.Value)
						{
							num = (short)446627878;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return false;
					case 40:
						if (radInfoLabtoolPrimaryBands_A.Value != 1)
						{
							num = (short)2140667997;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_1DAD;
					case 41:
						num = (short)1240399877;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 42:
						if (radInfoFrequencyRanges7800MHzUsedinCodeplug_A.Value)
						{
							num = (short)148308018;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_DD0;
					case 43:
						if (radInfoFrequencyRanges900MHzUsedinCodeplug_A.Value)
						{
							num = (short)1671299178;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return false;
					case 44:
						if (radInfoLabtoolSecondaryBands_A.Value != 4)
						{
							num = (short)25165859;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_117C;
					case 45:
						if (radInfoLabtoolSecondaryBands_A.Value != 8)
						{
							num = (short)943915070;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_1DD2;
					case 46:
						num = (short)1456734259;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 47:
						if (radInfoLabtoolPrimaryBands_A.Value != 5)
						{
							num = (short)760873020;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_117C;
					case 48:
						if (isFreonRadio)
						{
							num = (short)463732790;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_1842;
					case 49:
						goto IL_ED8;
					case 50:
						goto IL_1DAD;
					case 51:
						if (radInfoLabtoolPrimaryBands_A.Value != 3)
						{
							num = (short)73334862;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_11A2;
					case 52:
						if (!radInfoGeneralPrimaryFrequencyBand800_A.Value)
						{
							num = (short)114032709;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_23CC;
					case 53:
						num = (short)1957691483;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 54:
						num = (short)513277952;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 55:
						if (radInfoLabtoolPrimaryBands_A.Value != 6)
						{
							num = (short)2049638476;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_257B;
					case 56:
						if (radInfoFrequencyRangesAllowInvalidFrequencies_A.Value)
						{
							num = (short)496500841;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_124F;
					case 57:
						if (radInfoLabtoolPrimaryBands_A.Value != 7)
						{
							num = (short)589955168;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_23A7;
					case 58:
						if (radInfoLabtoolDualBandEnable_A.Value)
						{
							num = (short)1474035753;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_10BD;
					case 59:
						if (radInfoFrequencyRangesVHFUsedinCodeplug_A.Value)
						{
							num = (short)1714094107;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_124F;
					case 60:
						num = (short)478019663;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 61:
						num = (short)1457848349;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 62:
						goto IL_1CA3;
					case 63:
						if (radInfoLabtoolDualBandEnable_A.Value)
						{
							num = (short)1991311376;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_1CA3;
					case 64:
						if (!isFreonRadio)
						{
							num = (short)1984233525;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_1CA3;
					case 65:
						goto IL_1842;
					case 66:
						try
						{
							num = (short)480509962;
							num2 = (int)((global::System.IntPtr)num);
							bool result;
							for (;;)
							{
								switch (num2)
								{
								case 0:
									num = (short)1564213250;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 1:
								{
									global::Motorola.MackinawCPS.CoreFeatures.RadioWide.RxFrequencySplitFPPInnerSection rxFrequencySplitFPPInnerSection4;
									if (inputFrequency >= rxFrequencySplitFPPInnerSection4.RadWideLabtoolRxStartFrequencySplit_A9032.Value * 5)
									{
										num = (short)2007236616;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									break;
								}
								case 2:
									goto IL_C5C;
								case 3:
									num = (short)468189188;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 4:
								{
									global::Motorola.MackinawCPS.CoreFeatures.RadioWide.RxFrequencySplitFPPInnerSection rxFrequencySplitFPPInnerSection4;
									if (rxFrequencySplitFPPInnerSection4.RadWideLabtoolRxBandSplitName_A24797.Value == global::CommonResources.AcgResources.ID_VHF)
									{
										num = (short)827719692;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									break;
								}
								case 5:
									result = true;
									num = (short)2113732614;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 6:
									goto IL_BE7;
								case 7:
								{
									if (!enumerator.MoveNext())
									{
										num = (short)174522368;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									global::Motorola.MackinawCPS.CoreFeatures.RadioWide.RxFrequencySplitFPPInnerSection rxFrequencySplitFPPInnerSection4 = ((global::AcpCommonLib.IAcpFeatureNode)enumerator.Current)[10097] as global::Motorola.MackinawCPS.CoreFeatures.RadioWide.RxFrequencySplitFPPInnerSection;
									num = (short)1029242891;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 8:
									num = (short)801308681;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 9:
								{
									global::Motorola.MackinawCPS.CoreFeatures.RadioWide.RxFrequencySplitFPPInnerSection rxFrequencySplitFPPInnerSection4;
									if (inputFrequency <= rxFrequencySplitFPPInnerSection4.RadWideLabtoolRxEndFrequencySplit_A9015.Value * 5)
									{
										num = (short)1060634629;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									break;
								}
								case 10:
									switch (0)
									{
									case 0:
										goto IL_AB2;
									}
									continue;
								case 11:
								{
									global::Motorola.MackinawCPS.CoreFeatures.RadioWide.RxFrequencySplitFPPInnerSection rxFrequencySplitFPPInnerSection4;
									if (rxFrequencySplitFPPInnerSection4 != null)
									{
										num = (short)690028547;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									break;
								}
								case 12:
									num = (short)1734737921;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								IL_B91:
								num = (short)604504071;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								IL_AB2:
								goto IL_B91;
							}
							IL_BE7:
							return result;
							IL_C5C:
							goto IL_124F;
						}
						finally
						{
							num = (short)1963196416;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								switch (num2)
								{
								case 0:
									switch (0)
									{
									case 0:
										goto IL_C94;
									}
									continue;
								case 1:
									goto IL_CCD;
								case 2:
									enumerator.Dispose();
									num = (short)2019622913;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								IL_C94:
								if (enumerator == null)
								{
									break;
								}
								num = (short)1271529474;
								num2 = (int)((global::System.IntPtr)num);
							}
							IL_CCD:;
						}
						goto IL_CD0;
					case 67:
						try
						{
							num = (short)1005846538;
							num2 = (int)((global::System.IntPtr)num);
							bool result;
							for (;;)
							{
								switch (num2)
								{
								case 0:
								{
									global::Motorola.MackinawCPS.CoreFeatures.RadioWide.RxFrequencySplitFPPInnerSection rxFrequencySplitFPPInnerSection5;
									if (inputFrequency <= rxFrequencySplitFPPInnerSection5.RadWideLabtoolRxEndFrequencySplit_A9015.Value * 5)
									{
										num = (short)523763718;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									break;
								}
								case 1:
									num = (short)1336541192;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 2:
									goto IL_14CB;
								case 3:
									num = (short)1149698053;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 4:
									num = (short)208666624;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 5:
								{
									global::Motorola.MackinawCPS.CoreFeatures.RadioWide.RxFrequencySplitFPPInnerSection rxFrequencySplitFPPInnerSection5;
									if (rxFrequencySplitFPPInnerSection5.RadWideLabtoolRxBandSplitName_A24797.Value == global::CommonResources.AcgResources.ID_UHF1)
									{
										num = (short)753270785;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									break;
								}
								case 6:
									result = true;
									num = (short)1368129545;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 7:
									num = (short)552861698;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 8:
								{
									global::Motorola.MackinawCPS.CoreFeatures.RadioWide.RxFrequencySplitFPPInnerSection rxFrequencySplitFPPInnerSection5;
									if (inputFrequency >= rxFrequencySplitFPPInnerSection5.RadWideLabtoolRxStartFrequencySplit_A9032.Value * 5)
									{
										num = (short)68943876;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									break;
								}
								case 9:
									goto IL_1346;
								case 10:
									switch (0)
									{
									case 0:
										goto IL_1327;
									}
									continue;
								case 11:
								{
									global::Motorola.MackinawCPS.CoreFeatures.RadioWide.RxFrequencySplitFPPInnerSection rxFrequencySplitFPPInnerSection5;
									if (rxFrequencySplitFPPInnerSection5 != null)
									{
										num = (short)233897987;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									break;
								}
								case 12:
								{
									if (!enumerator.MoveNext())
									{
										num = (short)95027207;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									global::Motorola.MackinawCPS.CoreFeatures.RadioWide.RxFrequencySplitFPPInnerSection rxFrequencySplitFPPInnerSection5 = ((global::AcpCommonLib.IAcpFeatureNode)enumerator.Current)[10097] as global::Motorola.MackinawCPS.CoreFeatures.RadioWide.RxFrequencySplitFPPInnerSection;
									num = (short)948109323;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								}
								IL_13D8:
								num = (short)329973772;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								IL_1327:
								goto IL_13D8;
							}
							IL_1346:
							return result;
							IL_14CB:
							goto IL_101C;
						}
						finally
						{
							num = (short)517734400;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								switch (num2)
								{
								case 0:
									switch (0)
									{
									case 0:
										goto IL_1502;
									}
									continue;
								case 1:
									goto IL_1539;
								case 2:
									enumerator.Dispose();
									num = (short)1173618689;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								IL_1502:
								if (enumerator == null)
								{
									break;
								}
								num = (short)557842434;
								num2 = (int)((global::System.IntPtr)num);
							}
							IL_1539:;
						}
						goto Block_38;
					case 68:
						num = (short)595984459;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 69:
						num = (short)1668808728;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 70:
						num = (short)1896349736;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 71:
						num = (short)869007437;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 72:
						if (radInfoLabtoolSecondaryBands_A.Value != 1)
						{
							num = (short)1350172753;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_1DAD;
					case 73:
						if (radInfoFrequencyRanges8900MHzUsedinCodeplug_A.Value)
						{
							num = (short)1107034115;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_92D;
					case 74:
						goto IL_10BD;
					case 75:
						if (!radInfoGeneralPrimaryFrequencyBandUHF1_A.Value)
						{
							num = (short)1367015508;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_117C;
					case 76:
						goto IL_187C;
					case 77:
						if (radInfoLabtoolSecondaryBands_A.Value != 2)
						{
							num = (short)1292238884;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_11A2;
					case 78:
						num = (short)1934032928;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 79:
						if (radInfoLabtoolDualBandEnable_A.Value)
						{
							num = (short)1733623902;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_F1A;
					case 80:
						if (!isFreonRadio)
						{
							num = (short)1936916550;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)556597347;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 81:
						goto IL_376;
					case 82:
						num = (short)1807876118;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 83:
						num = (short)1877934188;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 84:
						goto IL_3B9;
					case 85:
						goto IL_868;
					case 86:
						goto IL_1056;
					case 87:
					{
						num = (short)1857880064;
						short num3 = num;
						goto IL_1100;
					}
					case 88:
						if (isFreonRadio)
						{
							num = (short)1198522450;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_1100;
					case 89:
						num = (short)759103506;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 90:
						if (!isFreonRadio)
						{
							num = (short)1581908068;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_10BD;
					case 91:
						if (radInfoLabtoolPrimaryBands_A.Value != 8)
						{
							num = (short)1401487390;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_1DD2;
					case 92:
						goto IL_D55;
					case 93:
						num = (short)1880948757;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 94:
						goto IL_CD0;
					case 95:
						if (radInfoLabtoolSecondaryBands_A.Value != 5)
						{
							num = (short)68091953;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_117C;
					case 96:
						num = (short)732692493;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 97:
						if (radInfoLabtoolDualBandEnable_A.Value)
						{
							num = (short)1443430507;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_ED8;
					case 98:
						if (radInfoFrequencyRangesAllowInvalidFrequencies_A.Value)
						{
							num = (short)1265434657;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_DD0;
					case 99:
						if (!radInfoGeneralPrimaryFrequencyBand700_A.Value)
						{
							num = (short)74252377;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_1056;
					case 100:
						num = (short)1935409162;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 101:
						if (!isFreonRadio)
						{
							num = (short)1599275093;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_187C;
					case 102:
						try
						{
							num = (short)1002897408;
							num2 = (int)((global::System.IntPtr)num);
							bool result;
							for (;;)
							{
								switch (num2)
								{
								case 0:
									switch (0)
									{
									case 0:
										goto IL_4F7;
									}
									continue;
								case 1:
								{
									global::Motorola.MackinawCPS.CoreFeatures.RadioWide.RxFrequencySplitFPPInnerSection rxFrequencySplitFPPInnerSection6;
									if (rxFrequencySplitFPPInnerSection6.RadWideLabtoolRxBandSplitName_A24797.Value == global::CommonResources.AcgResources.ID_P_900M)
									{
										num = (short)1290731535;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									goto IL_4FC;
								}
								case 2:
								{
									global::Motorola.MackinawCPS.CoreFeatures.RadioWide.RxFrequencySplitFPPInnerSection rxFrequencySplitFPPInnerSection6;
									if (inputFrequency >= rxFrequencySplitFPPInnerSection6.RadWideLabtoolRxStartFrequencySplit_A9032.Value * 5 + 12500)
									{
										num = (short)23527442;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									goto IL_4FC;
								}
								case 3:
								{
									global::Motorola.MackinawCPS.CoreFeatures.RadioWide.RxFrequencySplitFPPInnerSection rxFrequencySplitFPPInnerSection6;
									if (inputFrequency < rxFrequencySplitFPPInnerSection6.RadWideLabtoolRxEndFrequencySplit_A9015.Value * 5)
									{
										num = (short)1474297867;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									break;
								}
								case 4:
									num = (short)434176013;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 5:
									goto IL_7F2;
								case 6:
								{
									global::Motorola.MackinawCPS.CoreFeatures.RadioWide.RxFrequencySplitFPPInnerSection rxFrequencySplitFPPInnerSection6;
									if (rxFrequencySplitFPPInnerSection6 != null)
									{
										num = (short)370737156;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									break;
								}
								case 7:
									num = (short)1604255749;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 8:
								{
									global::Motorola.MackinawCPS.CoreFeatures.RadioWide.RxFrequencySplitFPPInnerSection rxFrequencySplitFPPInnerSection6;
									if (inputFrequency <= rxFrequencySplitFPPInnerSection6.RadWideLabtoolRxEndFrequencySplit_A9015.Value * 5 - 12500)
									{
										num = (short)1399848977;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									goto IL_4FC;
								}
								case 9:
								{
									if (!enumerator.MoveNext())
									{
										num = (short)348389383;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									global::Motorola.MackinawCPS.CoreFeatures.RadioWide.RxFrequencySplitFPPInnerSection rxFrequencySplitFPPInnerSection6 = ((global::AcpCommonLib.IAcpFeatureNode)enumerator.Current)[10097] as global::Motorola.MackinawCPS.CoreFeatures.RadioWide.RxFrequencySplitFPPInnerSection;
									num = (short)1843396618;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 10:
								{
									global::Motorola.MackinawCPS.CoreFeatures.RadioWide.RxFrequencySplitFPPInnerSection rxFrequencySplitFPPInnerSection6;
									if (rxFrequencySplitFPPInnerSection6 != null)
									{
										num = (short)1010499596;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									goto IL_4FC;
								}
								case 11:
									result = true;
									num = (short)1232994318;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 12:
									num = (short)2000355329;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 13:
								{
									global::Motorola.MackinawCPS.CoreFeatures.RadioWide.RxFrequencySplitFPPInnerSection rxFrequencySplitFPPInnerSection6;
									if (rxFrequencySplitFPPInnerSection6.RadWideLabtoolRxBandSplitName_A24797.Value == global::CommonResources.AcgResources.ID_P_800M)
									{
										num = (short)1454243860;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									break;
								}
								case 14:
									goto IL_745;
								case 15:
									num = (short)1520500738;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 16:
								{
									global::Motorola.MackinawCPS.CoreFeatures.RadioWide.RxFrequencySplitFPPInnerSection rxFrequencySplitFPPInnerSection6;
									if (inputFrequency >= rxFrequencySplitFPPInnerSection6.RadWideLabtoolRxStartFrequencySplit_A9032.Value * 5)
									{
										num = (short)990248981;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									break;
								}
								case 17:
									result = true;
									num = (short)154468371;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 18:
									num = (short)938737672;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 19:
									goto IL_68F;
								case 20:
									num = (short)358154256;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 21:
									num = (short)970326019;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								goto IL_4F7;
								IL_4FC:
								num = (short)1114308614;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								IL_79A:
								num = (short)1428357129;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								IL_4F7:
								goto IL_79A;
							}
							IL_68F:
							IL_745:
							return result;
							IL_7F2:
							goto IL_92D;
						}
						finally
						{
							num = (short)1812070400;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								switch (num2)
								{
								case 0:
									switch (0)
									{
									case 0:
										goto IL_82A;
									}
									continue;
								case 1:
									goto IL_865;
								case 2:
									enumerator.Dispose();
									num = (short)18481153;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								IL_82A:
								if (enumerator == null)
								{
									break;
								}
								num = (short)2118385666;
								num2 = (int)((global::System.IntPtr)num);
							}
							IL_865:;
						}
						goto IL_868;
					case 103:
						if (radInfoLabtoolPrimaryBands_A.Value != 4)
						{
							num = (short)1020919815;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_117C;
					case 104:
						goto IL_1DD2;
					case 105:
						num = (short)332136507;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 106:
						goto IL_257B;
					case 107:
						num = (short)1684406367;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 108:
						if (radInfoFrequencyRangesUHF2UsedinCodeplug_A.Value)
						{
							num = (short)1007616104;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_1E36;
					case 109:
						goto IL_117C;
					}
					goto IL_20F;
					IL_376:
					num = (short)2052849762;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_3B9:
					num = (short)605028356;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_868:
					num = (short)297467959;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_92D:
					num = (short)1296695344;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					Block_38:
					try
					{
						IL_153C:
						num = (short)1874198538;
						num2 = (int)((global::System.IntPtr)num);
						bool result;
						for (;;)
						{
							switch (num2)
							{
							case 0:
							{
								global::Motorola.MackinawCPS.CoreFeatures.RadioWide.RxFrequencySplitFPPInnerSection rxFrequencySplitFPPInnerSection7;
								if (rxFrequencySplitFPPInnerSection7.RadWideLabtoolRxBandSplitName_A24797.Value == global::CommonResources.AcgResources.ID_P_800M)
								{
									num = (short)807927814;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								break;
							}
							case 1:
							{
								global::Motorola.MackinawCPS.CoreFeatures.RadioWide.RxFrequencySplitFPPInnerSection rxFrequencySplitFPPInnerSection7;
								if (inputFrequency >= rxFrequencySplitFPPInnerSection7.RadWideLabtoolRxStartFrequencySplit_A9032.Value * 5)
								{
									num = (short)194248712;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								break;
							}
							case 2:
								goto IL_178D;
							case 3:
								num = (short)83886080;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							case 4:
								goto IL_168D;
							case 5:
								result = true;
								num = (short)1467023364;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							case 6:
								num = (short)610729985;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							case 7:
								num = (short)1628569602;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							case 8:
								num = (short)1447690249;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							case 9:
							{
								global::Motorola.MackinawCPS.CoreFeatures.RadioWide.RxFrequencySplitFPPInnerSection rxFrequencySplitFPPInnerSection7;
								if (inputFrequency < rxFrequencySplitFPPInnerSection7.RadWideLabtoolRxEndFrequencySplit_A9015.Value * 5)
								{
									num = (short)2092509986;
									short num4 = num;
									num = (short)147073826;
									switch ((num4 == num) ? 1 : 0)
									{
									case 0:
									case 2:
										goto IL_168D;
									default:
										num = (short)248512512;
										if (num != 0)
										{
										}
										num = (short)1446838277;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
								}
								break;
							}
							case 10:
								switch (0)
								{
								case 0:
									goto IL_1597;
								}
								continue;
							case 11:
							{
								global::Motorola.MackinawCPS.CoreFeatures.RadioWide.RxFrequencySplitFPPInnerSection rxFrequencySplitFPPInnerSection7;
								if (rxFrequencySplitFPPInnerSection7 != null)
								{
									num = (short)1091239939;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								break;
							}
							case 12:
							{
								if (!enumerator.MoveNext())
								{
									num = (short)802422791;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								global::Motorola.MackinawCPS.CoreFeatures.RadioWide.RxFrequencySplitFPPInnerSection rxFrequencySplitFPPInnerSection7 = ((global::AcpCommonLib.IAcpFeatureNode)enumerator.Current)[10097] as global::Motorola.MackinawCPS.CoreFeatures.RadioWide.RxFrequencySplitFPPInnerSection;
								num = (short)1373831179;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							}
							IL_1692:
							num = (short)1061879820;
							num2 = (int)((global::System.IntPtr)num);
							continue;
							IL_1597:
							goto IL_1692;
						}
						IL_168D:
						return result;
						IL_178D:
						goto IL_92D;
					}
					finally
					{
						num = (short)2011103232;
						num2 = (int)((global::System.IntPtr)num);
						for (;;)
						{
							switch (num2)
							{
							case 0:
								switch (0)
								{
								case 0:
									goto IL_17C6;
								}
								continue;
							case 1:
								enumerator.Dispose();
								num = (short)1961558018;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							case 2:
								goto IL_17FE;
							}
							IL_17C6:
							if (enumerator == null)
							{
								break;
							}
							num = (short)791216129;
							num2 = (int)((global::System.IntPtr)num);
						}
						IL_17FE:;
					}
					goto IL_1801;
					IL_CD0:
					num = (short)242286636;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_D55:
					num = (short)2025717824;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_DD0:
					num = (short)2128805945;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_ED8:
					num = (short)89391132;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_F1A:
					num = (short)1505427553;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_101C:
					num = (short)1331101727;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_1056:
					enumerator = rxFrequencySplitFPPInnerRecset.GetEnumerator();
					num = (short)1231028226;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_10BD:
					num = (short)1786118200;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_1100:
					num = (short)1929707610;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_117C:
					enumerator = rxFrequencySplitFPPInnerRecset.GetEnumerator();
					num = (short)474808387;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_11A2:
					enumerator = rxFrequencySplitFPPInnerRecset.GetEnumerator();
					num = (short)1705508930;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_11C7:
					num = (short)36175924;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_124F:
					num = (short)174325769;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_1801:
					num = (short)325779468;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_1842:
					num = (short)7733349;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_187C:
					num = (short)702414887;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_1CA3:
					num = (short)343867411;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_1DAD:
					enumerator = rxFrequencySplitFPPInnerRecset.GetEnumerator();
					num = (short)170000392;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_1DD2:
					enumerator = rxFrequencySplitFPPInnerRecset.GetEnumerator();
					num = (short)520617999;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_1E36:
					num = (short)531300432;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					Block_50:
					try
					{
						IL_20F2:
						num = (short)103153671;
						num2 = (int)((global::System.IntPtr)num);
						bool result;
						for (;;)
						{
							switch (num2)
							{
							case 0:
							{
								if (!enumerator.MoveNext())
								{
									num = (short)1103953928;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								global::Motorola.MackinawCPS.CoreFeatures.RadioWide.RxFrequencySplitFPPInnerSection rxFrequencySplitFPPInnerSection8 = ((global::AcpCommonLib.IAcpFeatureNode)enumerator.Current)[10097] as global::Motorola.MackinawCPS.CoreFeatures.RadioWide.RxFrequencySplitFPPInnerSection;
								num = (short)1897267203;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							case 1:
								result = true;
								num = (short)1746403340;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							case 2:
							{
								global::Motorola.MackinawCPS.CoreFeatures.RadioWide.RxFrequencySplitFPPInnerSection rxFrequencySplitFPPInnerSection8;
								if (rxFrequencySplitFPPInnerSection8.RadWideLabtoolRxBandSplitName_A24797.Value == global::CommonResources.AcgResources.ID_UHF2)
								{
									num = (short)748224517;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								break;
							}
							case 3:
							{
								global::Motorola.MackinawCPS.CoreFeatures.RadioWide.RxFrequencySplitFPPInnerSection rxFrequencySplitFPPInnerSection8;
								if (rxFrequencySplitFPPInnerSection8 != null)
								{
									num = (short)316604427;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								break;
							}
							case 4:
							{
								global::Motorola.MackinawCPS.CoreFeatures.RadioWide.RxFrequencySplitFPPInnerSection rxFrequencySplitFPPInnerSection8;
								if (inputFrequency <= rxFrequencySplitFPPInnerSection8.RadWideLabtoolRxEndFrequencySplit_A9015.Value * 5)
								{
									num = (short)742064129;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								break;
							}
							case 5:
								num = (short)1857290249;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							case 6:
								goto IL_22F4;
							case 7:
								switch (0)
								{
								case 0:
									goto IL_214D;
								}
								continue;
							case 8:
								num = (short)1202716678;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							case 9:
							{
								global::Motorola.MackinawCPS.CoreFeatures.RadioWide.RxFrequencySplitFPPInnerSection rxFrequencySplitFPPInnerSection8;
								if (inputFrequency >= rxFrequencySplitFPPInnerSection8.RadWideLabtoolRxStartFrequencySplit_A9032.Value * 5)
								{
									num = (short)2070020106;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								break;
							}
							case 10:
								num = (short)1141833732;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							case 11:
								num = (short)923205634;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							case 12:
								goto IL_2283;
							}
							IL_218F:
							num = (short)812580864;
							num2 = (int)((global::System.IntPtr)num);
							continue;
							IL_214D:
							goto IL_218F;
						}
						IL_2283:
						return result;
						IL_22F4:
						goto IL_1E36;
					}
					finally
					{
						num = (short)1300955136;
						num2 = (int)((global::System.IntPtr)num);
						for (;;)
						{
							switch (num2)
							{
							case 0:
								switch (0)
								{
								case 0:
									goto IL_232D;
								}
								continue;
							case 1:
								enumerator.Dispose();
								num = (short)1979711490;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							case 2:
								goto IL_2364;
							}
							IL_232D:
							if (enumerator == null)
							{
								break;
							}
							num = (short)1869021185;
							num2 = (int)((global::System.IntPtr)num);
						}
						IL_2364:;
					}
					IL_2367:
					num = (short)642187327;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_23A7:
					enumerator = rxFrequencySplitFPPInnerRecset.GetEnumerator();
					num = (short)439222374;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_23CC:
					enumerator = rxFrequencySplitFPPInnerRecset.GetEnumerator();
					num = (short)314638361;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_2434:
					num = (short)1596981306;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_257B:
					enumerator = rxFrequencySplitFPPInnerRecset.GetEnumerator();
					num = (short)833880078;
					num2 = (int)((global::System.IntPtr)num);
				}
				return false;
				IL_20F:
				global::Motorola.MackinawCPS.CoreFeatures.RadioInformation.FrequencyRanges frequencyRanges = ((global::Motorola.MackinawCPS.CoreFeatures.RadioInformation.RadioInformationRecset)global::AcpCommonLib.FeatureManager.GetFeature(2049))[0][10110] as global::Motorola.MackinawCPS.CoreFeatures.RadioInformation.FrequencyRanges;
				global::Motorola.MackinawCPS.CoreFeatures.RadioInformation.Labtool labtool = ((global::Motorola.MackinawCPS.CoreFeatures.RadioInformation.RadioInformationRecset)global::AcpCommonLib.FeatureManager.GetFeature(2049))[0][10107] as global::Motorola.MackinawCPS.CoreFeatures.RadioInformation.Labtool;
				global::Motorola.MackinawCPS.CoreFeatures.RadioInformation.General general = ((global::Motorola.MackinawCPS.CoreFeatures.RadioInformation.RadioInformationRecset)global::AcpCommonLib.FeatureManager.GetFeature(2049))[0][10108] as global::Motorola.MackinawCPS.CoreFeatures.RadioInformation.General;
				rxFrequencySplitFPPInnerRecset = (((global::Motorola.MackinawCPS.CoreFeatures.RadioWide.RadioWideRecset)global::AcpCommonLib.FeatureManager.GetFeature(2045))[0][10096].EmbeddedRecset as global::Motorola.MackinawCPS.CoreFeatures.RadioWide.RxFrequencySplitFPPInnerRecset);
				radInfoLabtoolDualBandEnable_A = labtool.RadInfoLabtoolDualBandEnable_A23986;
				radInfoLabtoolPrimaryBands_A = labtool.RadInfoLabtoolPrimaryBands_A23987;
				radInfoLabtoolSecondaryBands_A = labtool.RadInfoLabtoolSecondaryBands_A23988;
				radInfoFrequencyRangesAllowInvalidFrequencies_A = frequencyRanges.RadInfoFrequencyRangesAllowInvalidFrequencies_A12493;
				radInfoFrequencyRangesVHFUsedinCodeplug_A = frequencyRanges.RadInfoFrequencyRangesVHFUsedinCodeplug_A8481;
				radInfoFrequencyRangesUHF1UsedinCodeplug_A = frequencyRanges.RadInfoFrequencyRangesUHF1UsedinCodeplug_A8504;
				radInfoFrequencyRangesUHF2UsedinCodeplug_A = frequencyRanges.RadInfoFrequencyRangesUHF2UsedinCodeplug_A8507;
				radInfoFrequencyRanges7800MHzUsedinCodeplug_A = frequencyRanges.RadInfoFrequencyRanges7800MHzUsedinCodeplug_A8512;
				radInfoFrequencyRanges900MHzUsedinCodeplug_A = frequencyRanges.RadInfoFrequencyRanges900MHzUsedinCodeplug_A8516;
				radInfoFrequencyRanges8900MHzUsedinCodeplug_A = frequencyRanges.RadInfoFrequencyRanges8900MHzUsedinCodeplug_A42502;
				radInfoFrequencyRanges700MHzUsedinCodeplug_A = frequencyRanges.RadInfoFrequencyRanges700MHzUsedinCodeplug_A42551;
				radInfoFrequencyRanges800MHzUsedinCodeplug_A = frequencyRanges.RadInfoFrequencyRanges800MHzUsedinCodeplug_A42552;
				isFreonRadio = global::ConstraintHelper.UtilityMack.IsFreonRadio;
				radInfoGeneralPrimaryFrequencyBandVHF_A = general.RadInfoGeneralPrimaryFrequencyBandVHF_A42545;
				radInfoGeneralPrimaryFrequencyBandUHF1_A = general.RadInfoGeneralPrimaryFrequencyBandUHF1_A42546;
				radInfoGeneralPrimaryFrequencyBandUHF2_A = general.RadInfoGeneralPrimaryFrequencyBandUHF2_A42547;
				radInfoGeneralPrimaryFrequencyBand700_A = general.RadInfoGeneralPrimaryFrequencyBand700_A42543;
				radInfoGeneralPrimaryFrequencyBand800_A = general.RadInfoGeneralPrimaryFrequencyBand800_A42544;
				radInfoGeneralPrimaryFrequencyBand900_A = general.RadInfoGeneralPrimaryFrequencyBand900_A42548;
				num = (short)1033240664;
				num2 = (int)((global::System.IntPtr)num);
				goto IL_50;
			}
			}
		}

		// Token: 0x0600D093 RID: 53395 RVA: 0x00C27B00 File Offset: 0x00C25D00
		public static bool IsTxFrequencyBandEnabled(int inputFrequency)
		{
			short num = (short)659161088;
			int num2 = (int)num;
			switch (num2)
			{
			default:
			{
				switch (0)
				{
				case 0:
					goto IL_1E6;
				}
				global::AcpBusinessLayer.AcpListField radInfoLabtoolSecondaryBands_A;
				global::AcpBusinessLayer.AcpField<bool> radInfoFrequencyRangesAllowInvalidFrequencies_A;
				global::AcpBusinessLayer.AcpField<bool> radInfoLabtoolDualBandEnable_A;
				global::AcpBusinessLayer.AcpField<bool> radInfoFrequencyRanges700MHzUsedinCodeplug_A;
				bool isFreonRadio;
				global::AcpBusinessLayer.AcpField<bool> radInfoFrequencyRangesVHFUsedinCodeplug_A;
				global::AcpBusinessLayer.AcpField<bool> radInfoGeneralPrimaryFrequencyBand900_A;
				global::AcpBusinessLayer.AcpListField radInfoLabtoolPrimaryBands_A;
				global::AcpBusinessLayer.AcpField<bool> radInfoGeneralPrimaryFrequencyBandUHF2_A;
				global::AcpBusinessLayer.AcpField<bool> radInfoFrequencyRanges900MHzUsedinCodeplug_A;
				global::AcpBusinessLayer.AcpField<bool> radInfoFrequencyRanges800MHzUsedinCodeplug_A;
				global::AcpBusinessLayer.AcpField<bool> radInfoFrequencyRanges8900MHzUsedinCodeplug_A;
				global::AcpBusinessLayer.AcpField<bool> radInfoFrequencyRangesUHF2UsedinCodeplug_A;
				global::AcpBusinessLayer.AcpField<bool> radInfoFrequencyRangesUHF1UsedinCodeplug_A;
				global::AcpBusinessLayer.AcpField<bool> radInfoGeneralPrimaryFrequencyBandUHF1_A;
				global::AcpBusinessLayer.AcpField<bool> radInfoFrequencyRanges7800MHzUsedinCodeplug_A;
				global::AcpBusinessLayer.AcpField<bool> radInfoGeneralPrimaryFrequencyBand700_A;
				global::AcpBusinessLayer.AcpField<bool> radInfoGeneralPrimaryFrequencyBandVHF_A;
				global::AcpBusinessLayer.AcpField<bool> radInfoGeneralPrimaryFrequencyBand800_A;
				global::Motorola.MackinawCPS.CoreFeatures.RadioWide.TxFrequencySplitFPPInnerRecset txFrequencySplitFPPInnerRecset;
				for (;;)
				{
					IL_27:
					global::System.Collections.Generic.IEnumerator<global::AcpBusinessLayer.FeatureNode> enumerator;
					switch (num2)
					{
					case 0:
						num = (short)805175299;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 1:
						if (radInfoLabtoolSecondaryBands_A.Value != 1)
						{
							num = (short)139788330;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_1F43;
					case 2:
						num = (short)1362165828;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 3:
						if (radInfoFrequencyRangesAllowInvalidFrequencies_A.Value)
						{
							num = (short)110362625;
							if (num != 0)
							{
							}
							num = (short)1672020000;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_9A5;
					case 4:
						if (radInfoLabtoolDualBandEnable_A.Value)
						{
							num = (short)1479540738;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_1E3D;
					case 5:
						goto IL_2589;
					case 6:
						if (radInfoFrequencyRangesAllowInvalidFrequencies_A.Value)
						{
							num = (short)1426063465;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_1FCB;
					case 7:
						if (radInfoFrequencyRangesAllowInvalidFrequencies_A.Value)
						{
							num = (short)1127809054;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_E17;
					case 8:
						goto IL_1134;
					case 9:
						if (radInfoLabtoolDualBandEnable_A.Value)
						{
							num = (short)695795798;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_2618;
					case 10:
						try
						{
							num = (short)773521414;
							num2 = (int)((global::System.IntPtr)num);
							bool result;
							for (;;)
							{
								switch (num2)
								{
								case 0:
									goto IL_2263;
								case 1:
								{
									global::Motorola.MackinawCPS.CoreFeatures.RadioWide.TxFrequencySplitFPPInnerSection txFrequencySplitFPPInnerSection;
									if (!(txFrequencySplitFPPInnerSection.RadWideLabtoolTxBandSplitName_A24799.Value == global::CommonResources.AcgResources.ID_P_900M_1))
									{
										num = (short)1577385997;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									goto IL_20AC;
								}
								case 2:
									num = (short)224657417;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 3:
								{
									global::Motorola.MackinawCPS.CoreFeatures.RadioWide.TxFrequencySplitFPPInnerSection txFrequencySplitFPPInnerSection;
									if (inputFrequency > txFrequencySplitFPPInnerSection.RadWideLabtoolTxStartFrequencySplit_A9571.Value * 5)
									{
										num = (short)1973354498;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									break;
								}
								case 4:
									num = (short)1076363265;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 5:
									num = (short)1932525568;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 6:
									switch (0)
									{
									case 0:
										goto IL_206B;
									}
									continue;
								case 7:
								{
									global::Motorola.MackinawCPS.CoreFeatures.RadioWide.TxFrequencySplitFPPInnerSection txFrequencySplitFPPInnerSection;
									if (txFrequencySplitFPPInnerSection.RadWideLabtoolTxBandSplitName_A24799.Value == global::CommonResources.AcgResources.ID_P_900M_2)
									{
										num = (short)417792011;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									break;
								}
								case 8:
									result = true;
									num = (short)1327955978;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 9:
								{
									global::Motorola.MackinawCPS.CoreFeatures.RadioWide.TxFrequencySplitFPPInnerSection txFrequencySplitFPPInnerSection;
									if (inputFrequency < txFrequencySplitFPPInnerSection.RadWideLabtoolTxEndFrequencySplit_A9532Value * 5)
									{
										num = (short)2115895304;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									break;
								}
								case 10:
									goto IL_21F1;
								case 11:
									goto IL_20AC;
								case 12:
								{
									if (!enumerator.MoveNext())
									{
										num = (short)979763205;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									global::Motorola.MackinawCPS.CoreFeatures.RadioWide.TxFrequencySplitFPPInnerSection txFrequencySplitFPPInnerSection = ((global::AcpCommonLib.IAcpFeatureNode)enumerator.Current)[10095] as global::Motorola.MackinawCPS.CoreFeatures.RadioWide.TxFrequencySplitFPPInnerSection;
									num = (short)145621006;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 13:
									num = (short)395051015;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 14:
								{
									global::Motorola.MackinawCPS.CoreFeatures.RadioWide.TxFrequencySplitFPPInnerSection txFrequencySplitFPPInnerSection;
									if (txFrequencySplitFPPInnerSection != null)
									{
										num = (short)1278279684;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									break;
								}
								}
								goto IL_206B;
								IL_20AC:
								num = (short)646250499;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								IL_20F5:
								num = (short)1262485516;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								IL_206B:
								goto IL_20F5;
							}
							IL_21F1:
							return result;
							IL_2263:
							return false;
						}
						finally
						{
							num = (short)1180237826;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								switch (num2)
								{
								case 0:
									enumerator.Dispose();
									num = (short)143458305;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 1:
									goto IL_22D2;
								case 2:
									switch (0)
									{
									case 0:
										goto IL_229A;
									}
									continue;
								}
								IL_229A:
								if (enumerator == null)
								{
									break;
								}
								num = (short)565903360;
								num2 = (int)((global::System.IntPtr)num);
							}
							IL_22D2:;
						}
						goto Block_50;
					case 11:
						goto IL_38F;
					case 12:
						if (radInfoLabtoolSecondaryBands_A.Value != 3)
						{
							num = (short)1518075912;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_121B;
					case 13:
						num = (short)1197015049;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 14:
						num = (short)1864040491;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 15:
						if (radInfoFrequencyRangesAllowInvalidFrequencies_A.Value)
						{
							num = (short)193593367;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_9A5;
					case 16:
						num = (short)1108738149;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 17:
						if (radInfoFrequencyRanges700MHzUsedinCodeplug_A.Value)
						{
							num = (short)1796669535;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_126B;
					case 18:
						if (!isFreonRadio)
						{
							num = (short)1070530656;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_F46;
					case 19:
						num = (short)1252720652;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 20:
						num = (short)786497573;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 21:
						num = (short)197918771;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 22:
						goto IL_275E;
					case 23:
						num = (short)150405183;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 24:
						num = (short)1512701996;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 25:
						if (radInfoFrequencyRangesAllowInvalidFrequencies_A.Value)
						{
							num = (short)1421148198;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_126B;
					case 26:
						num = (short)775422023;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 27:
						if (radInfoLabtoolSecondaryBands_A.Value != 5)
						{
							num = (short)1236664377;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_11F4;
					case 28:
						if (radInfoLabtoolSecondaryBands_A.Value != 2)
						{
							num = (short)988348504;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_121B;
					case 29:
						if (radInfoLabtoolDualBandEnable_A.Value)
						{
							num = (short)1554055209;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_34D;
					case 30:
						num = (short)1019019362;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 31:
						if (radInfoFrequencyRangesAllowInvalidFrequencies_A.Value)
						{
							num = (short)1397424154;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_108C;
					case 32:
						num = (short)1015611445;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 33:
						if (!isFreonRadio)
						{
							num = (short)1228079191;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_1134;
					case 34:
						try
						{
							num = (short)700776456;
							num2 = (int)((global::System.IntPtr)num);
							bool result;
							for (;;)
							{
								switch (num2)
								{
								case 0:
									num = (short)738721817;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 1:
									num = (short)1494679567;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 2:
								{
									global::Motorola.MackinawCPS.CoreFeatures.RadioWide.TxFrequencySplitFPPInnerSection txFrequencySplitFPPInnerSection2;
									if (inputFrequency >= txFrequencySplitFPPInnerSection2.RadWideLabtoolTxStartFrequencySplit_A9571.Value * 5)
									{
										num = (short)1970077720;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									break;
								}
								case 3:
									num = (short)2129264646;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 4:
									result = true;
									num = (short)2062155783;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 5:
									goto IL_6C2;
								case 6:
								{
									global::Motorola.MackinawCPS.CoreFeatures.RadioWide.TxFrequencySplitFPPInnerSection txFrequencySplitFPPInnerSection2;
									if (txFrequencySplitFPPInnerSection2.RadWideLabtoolTxBandSplitName_A24799.Value == global::CommonResources.AcgResources.ID_P_900M_2)
									{
										num = (short)1079705605;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									goto IL_4E6;
								}
								case 7:
									goto IL_67C;
								case 8:
									switch (0)
									{
									case 0:
										goto IL_4E1;
									}
									continue;
								case 9:
								{
									global::Motorola.MackinawCPS.CoreFeatures.RadioWide.TxFrequencySplitFPPInnerSection txFrequencySplitFPPInnerSection2;
									if (txFrequencySplitFPPInnerSection2.RadWideLabtoolTxBandSplitName_A24799.Value == global::CommonResources.AcgResources.ID_P_800M_2)
									{
										num = (short)698679317;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									break;
								}
								case 10:
									result = true;
									num = (short)2056519703;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 11:
								{
									global::Motorola.MackinawCPS.CoreFeatures.RadioWide.TxFrequencySplitFPPInnerSection txFrequencySplitFPPInnerSection2;
									if (inputFrequency > txFrequencySplitFPPInnerSection2.RadWideLabtoolTxStartFrequencySplit_A9571.Value * 5)
									{
										num = (short)1171718166;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									goto IL_4E6;
								}
								case 12:
								{
									global::Motorola.MackinawCPS.CoreFeatures.RadioWide.TxFrequencySplitFPPInnerSection txFrequencySplitFPPInnerSection2;
									if (inputFrequency < txFrequencySplitFPPInnerSection2.RadWideLabtoolTxEndFrequencySplit_A9532Value * 5)
									{
										num = (short)298385418;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									break;
								}
								case 13:
								{
									global::Motorola.MackinawCPS.CoreFeatures.RadioWide.TxFrequencySplitFPPInnerSection txFrequencySplitFPPInnerSection2;
									if (txFrequencySplitFPPInnerSection2 != null)
									{
										num = (short)1536819201;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									goto IL_4E6;
								}
								case 14:
								{
									if (!enumerator.MoveNext())
									{
										num = (short)25493504;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									global::Motorola.MackinawCPS.CoreFeatures.RadioWide.TxFrequencySplitFPPInnerSection txFrequencySplitFPPInnerSection2 = ((global::AcpCommonLib.IAcpFeatureNode)enumerator.Current)[10095] as global::Motorola.MackinawCPS.CoreFeatures.RadioWide.TxFrequencySplitFPPInnerSection;
									num = (short)1039073293;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 15:
								{
									global::Motorola.MackinawCPS.CoreFeatures.RadioWide.TxFrequencySplitFPPInnerSection txFrequencySplitFPPInnerSection2;
									if (!(txFrequencySplitFPPInnerSection2.RadWideLabtoolTxBandSplitName_A24799.Value == global::CommonResources.AcgResources.ID_P_900M_1))
									{
										num = (short)554958851;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									goto IL_6C2;
								}
								case 16:
								{
									global::Motorola.MackinawCPS.CoreFeatures.RadioWide.TxFrequencySplitFPPInnerSection txFrequencySplitFPPInnerSection2;
									if (!(txFrequencySplitFPPInnerSection2.RadWideLabtoolTxBandSplitName_A24799.Value == global::CommonResources.AcgResources.ID_P_800M_1))
									{
										num = (short)187957267;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									goto IL_523;
								}
								case 17:
									num = (short)1919352848;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 18:
								{
									global::Motorola.MackinawCPS.CoreFeatures.RadioWide.TxFrequencySplitFPPInnerSection txFrequencySplitFPPInnerSection2;
									if (inputFrequency < txFrequencySplitFPPInnerSection2.RadWideLabtoolTxEndFrequencySplit_A9532Value * 5)
									{
										num = (short)1649213444;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									goto IL_4E6;
								}
								case 19:
									num = (short)1935933449;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 20:
								{
									global::Motorola.MackinawCPS.CoreFeatures.RadioWide.TxFrequencySplitFPPInnerSection txFrequencySplitFPPInnerSection2;
									if (txFrequencySplitFPPInnerSection2 != null)
									{
										num = (short)1808007185;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									break;
								}
								case 21:
									goto IL_523;
								case 22:
									num = (short)882180114;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 23:
									goto IL_7FD;
								case 24:
									num = (short)464977932;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 25:
									goto IL_86D;
								}
								goto IL_4E1;
								IL_4E6:
								num = (short)1625030676;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								IL_523:
								num = (short)1415577602;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								IL_6C2:
								num = (short)92405771;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								IL_7A1:
								num = (short)1175584782;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								IL_4E1:
								goto IL_7A1;
							}
							IL_67C:
							IL_7FD:
							return result;
							IL_86D:
							goto IL_9A5;
						}
						finally
						{
							num = (short)1077870593;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								switch (num2)
								{
								case 0:
									enumerator.Dispose();
									num = (short)119930882;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 1:
									switch (0)
									{
									case 0:
										goto IL_8A5;
									}
									continue;
								case 2:
									goto IL_8DD;
								}
								IL_8A5:
								if (enumerator == null)
								{
									break;
								}
								num = (short)852099072;
								num2 = (int)((global::System.IntPtr)num);
							}
							IL_8DD:;
						}
						goto IL_8E0;
					case 35:
						if (radInfoFrequencyRangesVHFUsedinCodeplug_A.Value)
						{
							num = (short)947257400;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_12F0;
					case 36:
						goto IL_1178;
					case 37:
						if (!radInfoGeneralPrimaryFrequencyBand900_A.Value)
						{
							num = (short)2053832779;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_275E;
					case 38:
						goto IL_18E9;
					case 39:
						if (!isFreonRadio)
						{
							num = (short)2104229954;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)1677066340;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 40:
						goto IL_8E0;
					case 41:
						num = (short)785973249;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 42:
						goto IL_34D;
					case 43:
						if (radInfoLabtoolPrimaryBands_A.Value != 5)
						{
							num = (short)1365114901;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_11F4;
					case 44:
						if (!radInfoGeneralPrimaryFrequencyBandUHF2_A.Value)
						{
							num = (short)810221651;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_1F69;
					case 45:
						if (isFreonRadio)
						{
							num = (short)1836449812;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_192C;
					case 46:
						if (radInfoFrequencyRanges900MHzUsedinCodeplug_A.Value)
						{
							num = (short)136970262;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return false;
					case 47:
						if (radInfoLabtoolSecondaryBands_A.Value != 4)
						{
							num = (short)1077215323;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_11F4;
					case 48:
						goto IL_2549;
					case 49:
						goto IL_162A;
					case 50:
						if (!isFreonRadio)
						{
							num = (short)1631846440;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_1967;
					case 51:
						if (radInfoLabtoolDualBandEnable_A.Value)
						{
							num = (short)1164771420;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_F8A;
					case 52:
						if (radInfoLabtoolPrimaryBands_A.Value != 4)
						{
							num = (short)1766391822;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_11F4;
					case 53:
						if (radInfoFrequencyRanges800MHzUsedinCodeplug_A.Value)
						{
							num = (short)207028305;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_9A5;
					case 54:
						if (!isFreonRadio)
						{
							num = (short)1698758765;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_1E3D;
					case 55:
						try
						{
							num = (short)2082734087;
							num2 = (int)((global::System.IntPtr)num);
							bool result;
							for (;;)
							{
								switch (num2)
								{
								case 0:
									result = true;
									num = (short)1220476934;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 1:
								{
									global::Motorola.MackinawCPS.CoreFeatures.RadioWide.TxFrequencySplitFPPInnerSection txFrequencySplitFPPInnerSection3;
									if (inputFrequency <= txFrequencySplitFPPInnerSection3.RadWideLabtoolTxEndFrequencySplit_A9532.Value * 5)
									{
										num = (short)1551892480;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									break;
								}
								case 2:
								{
									if (!enumerator.MoveNext())
									{
										num = (short)938803205;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									global::Motorola.MackinawCPS.CoreFeatures.RadioWide.TxFrequencySplitFPPInnerSection txFrequencySplitFPPInnerSection3 = ((global::AcpCommonLib.IAcpFeatureNode)enumerator.Current)[10095] as global::Motorola.MackinawCPS.CoreFeatures.RadioWide.TxFrequencySplitFPPInnerSection;
									num = (short)1308164106;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 3:
									num = (short)2007433224;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 4:
									num = (short)1864695809;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 5:
									num = (short)776929292;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 6:
									goto IL_B6E;
								case 7:
									switch (0)
									{
									case 0:
										goto IL_B02;
									}
									continue;
								case 8:
								{
									global::Motorola.MackinawCPS.CoreFeatures.RadioWide.TxFrequencySplitFPPInnerSection txFrequencySplitFPPInnerSection3;
									if (txFrequencySplitFPPInnerSection3.RadWideLabtoolTxBandSplitName_A24799.Value == global::CommonResources.AcgResources.ID_VHF)
									{
										num = (short)1478295563;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									break;
								}
								case 9:
								{
									global::Motorola.MackinawCPS.CoreFeatures.RadioWide.TxFrequencySplitFPPInnerSection txFrequencySplitFPPInnerSection3;
									if (inputFrequency >= txFrequencySplitFPPInnerSection3.RadWideLabtoolTxStartFrequencySplit_A9571.Value * 5)
									{
										num = (short)1085734916;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									break;
								}
								case 10:
								{
									global::Motorola.MackinawCPS.CoreFeatures.RadioWide.TxFrequencySplitFPPInnerSection txFrequencySplitFPPInnerSection3;
									if (txFrequencySplitFPPInnerSection3 != null)
									{
										num = (short)1104412675;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									break;
								}
								case 11:
									num = (short)900792329;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 12:
									goto IL_CA2;
								}
								IL_BFD:
								num = (short)1126694914;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								IL_B02:
								goto IL_BFD;
							}
							IL_B6E:
							return result;
							IL_CA2:
							goto IL_12F0;
						}
						finally
						{
							num = (short)1128136705;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								switch (num2)
								{
								case 0:
									enumerator.Dispose();
									num = (short)1689255938;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 1:
									switch (0)
									{
									case 0:
										goto IL_CDB;
									}
									continue;
								case 2:
									goto IL_D14;
								}
								IL_CDB:
								if (enumerator == null)
								{
									break;
								}
								num = (short)1344208896;
								num2 = (int)((global::System.IntPtr)num);
							}
							IL_D14:;
						}
						goto IL_D17;
					case 56:
						goto IL_121B;
					case 57:
						goto IL_F46;
					case 58:
						if (isFreonRadio)
						{
							num = (short)1277558808;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_D9A;
					case 59:
						if (radInfoLabtoolPrimaryBands_A.Value != 2)
						{
							num = (short)1755381830;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_121B;
					case 60:
						goto IL_1967;
					case 61:
						if (radInfoLabtoolPrimaryBands_A.Value != 3)
						{
							num = (short)403701773;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_121B;
					case 62:
						if (isFreonRadio)
						{
							num = (short)109772816;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_1178;
					case 63:
						if (radInfoFrequencyRanges8900MHzUsedinCodeplug_A.Value)
						{
							num = (short)1392246789;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_9A5;
					case 64:
						if (radInfoFrequencyRangesAllowInvalidFrequencies_A.Value)
						{
							num = (short)1345912922;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return false;
					case 65:
						if (radInfoFrequencyRangesUHF2UsedinCodeplug_A.Value)
						{
							num = (short)1753809002;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_1FCB;
					case 66:
						num = (short)1068302418;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 67:
						num = (short)117047390;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 68:
						if (radInfoLabtoolSecondaryBands_A.Value != 8)
						{
							num = (short)446955623;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_1F69;
					case 69:
						if (radInfoLabtoolDualBandEnable_A.Value)
						{
							num = (short)249233488;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_F46;
					case 70:
						num = (short)1071906877;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 71:
						if (radInfoFrequencyRangesUHF1UsedinCodeplug_A.Value)
						{
							num = (short)494927969;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_108C;
					case 72:
						if (radInfoLabtoolDualBandEnable_A.Value)
						{
							num = (short)1193082899;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_1134;
					case 73:
						num = (short)322961433;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 74:
						if (radInfoFrequencyRangesAllowInvalidFrequencies_A.Value)
						{
							num = (short)265551950;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_12F0;
					case 75:
						goto IL_192C;
					case 76:
						if (isFreonRadio)
						{
							num = (short)1384513603;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_38F;
					case 77:
						try
						{
							num = (short)463011845;
							num2 = (int)((global::System.IntPtr)num);
							bool result;
							for (;;)
							{
								switch (num2)
								{
								case 0:
								{
									global::Motorola.MackinawCPS.CoreFeatures.RadioWide.TxFrequencySplitFPPInnerSection txFrequencySplitFPPInnerSection4;
									if (inputFrequency < txFrequencySplitFPPInnerSection4.RadWideLabtoolTxEndFrequencySplit_A9532Value * 5)
									{
										num = (short)983957510;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									break;
								}
								case 1:
									num = (short)791871497;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 2:
									num = (short)1949958152;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 3:
									num = (short)780533770;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 4:
								{
									global::Motorola.MackinawCPS.CoreFeatures.RadioWide.TxFrequencySplitFPPInnerSection txFrequencySplitFPPInnerSection4;
									if (inputFrequency > txFrequencySplitFPPInnerSection4.RadWideLabtoolTxStartFrequencySplit_A9571.Value * 5)
									{
										num = (short)694550540;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									break;
								}
								case 5:
									switch (0)
									{
									case 0:
										goto IL_27E7;
									}
									continue;
								case 6:
									result = true;
									num = (short)1225916427;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 7:
								{
									global::Motorola.MackinawCPS.CoreFeatures.RadioWide.TxFrequencySplitFPPInnerSection txFrequencySplitFPPInnerSection4;
									if (txFrequencySplitFPPInnerSection4 != null)
									{
										num = (short)1110376450;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									break;
								}
								case 8:
								{
									global::Motorola.MackinawCPS.CoreFeatures.RadioWide.TxFrequencySplitFPPInnerSection txFrequencySplitFPPInnerSection4;
									if (!(txFrequencySplitFPPInnerSection4.RadWideLabtoolTxBandSplitName_A24799.Value == global::CommonResources.AcgResources.ID_P_700M_1))
									{
										num = (short)142737409;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									goto IL_28B7;
								}
								case 9:
								{
									global::Motorola.MackinawCPS.CoreFeatures.RadioWide.TxFrequencySplitFPPInnerSection txFrequencySplitFPPInnerSection4;
									if (txFrequencySplitFPPInnerSection4.RadWideLabtoolTxBandSplitName_A24799.Value == global::CommonResources.AcgResources.ID_P_700M_2)
									{
										num = (short)997130254;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									break;
								}
								case 10:
									goto IL_29E0;
								case 11:
									goto IL_29C2;
								case 12:
									num = (short)1444478976;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 13:
								{
									if (!enumerator.MoveNext())
									{
										num = (short)886833155;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									global::Motorola.MackinawCPS.CoreFeatures.RadioWide.TxFrequencySplitFPPInnerSection txFrequencySplitFPPInnerSection4 = ((global::AcpCommonLib.IAcpFeatureNode)enumerator.Current)[10095] as global::Motorola.MackinawCPS.CoreFeatures.RadioWide.TxFrequencySplitFPPInnerSection;
									num = (short)1924268039;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 14:
									goto IL_28B7;
								}
								IL_2834:
								num = (short)1089667085;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								IL_27E7:
								goto IL_2834;
								IL_28B7:
								num = (short)816054276;
								num2 = (int)((global::System.IntPtr)num);
							}
							IL_29C2:
							return result;
							IL_29E0:
							goto IL_126B;
						}
						finally
						{
							num = (short)1426718722;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								switch (num2)
								{
								case 0:
									enumerator.Dispose();
									num = (short)51445761;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 1:
									goto IL_2A4F;
								case 2:
									switch (0)
									{
									case 0:
										goto IL_2A17;
									}
									continue;
								}
								IL_2A17:
								if (enumerator == null)
								{
									break;
								}
								num = (short)939982848;
								num2 = (int)((global::System.IntPtr)num);
							}
							IL_2A4F:;
						}
						return false;
					case 78:
						num = (short)1223032867;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 79:
						num = (short)1653866511;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 80:
						num = (short)469958683;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 81:
						goto IL_25AF;
					case 82:
						if (radInfoLabtoolPrimaryBands_A.Value != 1)
						{
							num = (short)617414741;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_1F43;
					case 83:
						goto IL_D9A;
					case 84:
						if (radInfoLabtoolPrimaryBands_A.Value != 7)
						{
							num = (short)1451491407;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_2589;
					case 85:
						num = (short)1019740189;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 86:
						num = (short)2043609116;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 87:
						num = (short)1970995259;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 88:
						goto IL_2618;
					case 89:
						goto IL_1F43;
					case 90:
						num = (short)765984814;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 91:
						goto IL_F8A;
					case 92:
						goto IL_D17;
					case 93:
						if (radInfoLabtoolPrimaryBands_A.Value != 8)
						{
							num = (short)1457389616;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_1F69;
					case 94:
						if (!radInfoGeneralPrimaryFrequencyBandUHF1_A.Value)
						{
							num = (short)1400766475;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_11F4;
					case 95:
						goto IL_10C9;
					case 96:
						num = (short)1357774900;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 97:
						goto IL_11F4;
					case 98:
						if (radInfoFrequencyRanges7800MHzUsedinCodeplug_A.Value)
						{
							num = (short)1065812057;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_E17;
					case 99:
						goto IL_22D5;
					case 100:
						if (!radInfoGeneralPrimaryFrequencyBand700_A.Value)
						{
							num = (short)437256265;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_10C9;
					case 101:
						if (!radInfoGeneralPrimaryFrequencyBandVHF_A.Value)
						{
							num = (short)869466148;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_121B;
					case 102:
						try
						{
							num = (short)834076679;
							num2 = (int)((global::System.IntPtr)num);
							bool result;
							for (;;)
							{
								switch (num2)
								{
								case 0:
									result = true;
									goto IL_1410;
								case 1:
								{
									global::Motorola.MackinawCPS.CoreFeatures.RadioWide.TxFrequencySplitFPPInnerSection txFrequencySplitFPPInnerSection5;
									if (inputFrequency <= txFrequencySplitFPPInnerSection5.RadWideLabtoolTxEndFrequencySplit_A9532Value * 5)
									{
										num = (short)522977280;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									break;
								}
								case 2:
								{
									global::Motorola.MackinawCPS.CoreFeatures.RadioWide.TxFrequencySplitFPPInnerSection txFrequencySplitFPPInnerSection5;
									if (txFrequencySplitFPPInnerSection5.RadWideLabtoolTxBandSplitName_A24799.Value == global::CommonResources.AcgResources.ID_UHF1)
									{
										num = (short)1270677509;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									break;
								}
								case 3:
									num = (short)986578946;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 4:
									num = (short)1668153356;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 5:
								{
									num = (short)1486582218;
									short num3 = num;
									num = (short)1500279242;
									switch ((num3 == num) ? 1 : 0)
									{
									case 0:
									case 2:
										goto IL_1410;
									default:
										num = (short)1167720448;
										if (num != 0)
										{
										}
										num = (short)1432748040;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									break;
								}
								case 6:
									goto IL_1428;
								case 7:
									switch (0)
									{
									case 0:
										goto IL_13C8;
									}
									continue;
								case 8:
								{
									global::Motorola.MackinawCPS.CoreFeatures.RadioWide.TxFrequencySplitFPPInnerSection txFrequencySplitFPPInnerSection5;
									if (inputFrequency >= txFrequencySplitFPPInnerSection5.RadWideLabtoolTxStartFrequencySplit_A9571.Value * 5)
									{
										num = (short)776011787;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									break;
								}
								case 9:
								{
									if (!enumerator.MoveNext())
									{
										num = (short)621871108;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									global::Motorola.MackinawCPS.CoreFeatures.RadioWide.TxFrequencySplitFPPInnerSection txFrequencySplitFPPInnerSection5 = ((global::AcpCommonLib.IAcpFeatureNode)enumerator.Current)[10095] as global::Motorola.MackinawCPS.CoreFeatures.RadioWide.TxFrequencySplitFPPInnerSection;
									num = (short)376635402;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 10:
								{
									global::Motorola.MackinawCPS.CoreFeatures.RadioWide.TxFrequencySplitFPPInnerSection txFrequencySplitFPPInnerSection5;
									if (txFrequencySplitFPPInnerSection5 != null)
									{
										num = (short)1812135939;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									break;
								}
								case 11:
									num = (short)406454273;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 12:
									goto IL_15B6;
								}
								goto IL_13C8;
								IL_1410:
								num = (short)139395078;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								IL_146C:
								num = (short)559808521;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								IL_13C8:
								goto IL_146C;
							}
							IL_1428:
							return result;
							IL_15B6:
							goto IL_108C;
						}
						finally
						{
							num = (short)1815085057;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								switch (num2)
								{
								case 0:
									enumerator.Dispose();
									num = (short)1045692418;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 1:
									switch (0)
									{
									case 0:
										goto IL_15EF;
									}
									continue;
								case 2:
									goto IL_1627;
								}
								IL_15EF:
								if (enumerator == null)
								{
									break;
								}
								num = (short)1894121472;
								num2 = (int)((global::System.IntPtr)num);
							}
							IL_1627:;
						}
						goto Block_38;
					case 103:
						goto IL_1E3D;
					case 104:
						if (radInfoLabtoolPrimaryBands_A.Value != 6)
						{
							num = (short)759955516;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_275E;
					case 105:
						num = (short)412483649;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 106:
						goto IL_1F69;
					case 107:
						if (!radInfoGeneralPrimaryFrequencyBand800_A.Value)
						{
							num = (short)1645805568;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_25AF;
					case 108:
						try
						{
							num = (short)2086076433;
							num2 = (int)((global::System.IntPtr)num);
							bool result;
							for (;;)
							{
								switch (num2)
								{
								case 0:
									num = (short)1755971602;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 1:
								{
									global::Motorola.MackinawCPS.CoreFeatures.RadioWide.TxFrequencySplitFPPInnerSection txFrequencySplitFPPInnerSection6;
									if (txFrequencySplitFPPInnerSection6.RadWideLabtoolTxBandSplitName_A24799.Value == global::CommonResources.AcgResources.ID_P_700M_2)
									{
										num = (short)949682198;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									goto IL_1A3C;
								}
								case 2:
								{
									global::Motorola.MackinawCPS.CoreFeatures.RadioWide.TxFrequencySplitFPPInnerSection txFrequencySplitFPPInnerSection6;
									if (inputFrequency < txFrequencySplitFPPInnerSection6.RadWideLabtoolTxEndFrequencySplit_A9532Value * 5)
									{
										num = (short)816513034;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									break;
								}
								case 3:
									goto IL_1D68;
								case 4:
								{
									global::Motorola.MackinawCPS.CoreFeatures.RadioWide.TxFrequencySplitFPPInnerSection txFrequencySplitFPPInnerSection6;
									if (!(txFrequencySplitFPPInnerSection6.RadWideLabtoolTxBandSplitName_A24799.Value == global::CommonResources.AcgResources.ID_P_700M_1))
									{
										num = (short)225837065;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									goto IL_1C15;
								}
								case 5:
								{
									global::Motorola.MackinawCPS.CoreFeatures.RadioWide.TxFrequencySplitFPPInnerSection txFrequencySplitFPPInnerSection6;
									if (inputFrequency < txFrequencySplitFPPInnerSection6.RadWideLabtoolTxEndFrequencySplit_A9532Value * 5)
									{
										num = (short)111083533;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									goto IL_1A3C;
								}
								case 6:
									num = (short)192217109;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 7:
								{
									global::Motorola.MackinawCPS.CoreFeatures.RadioWide.TxFrequencySplitFPPInnerSection txFrequencySplitFPPInnerSection6;
									if (txFrequencySplitFPPInnerSection6 != null)
									{
										num = (short)902823955;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									goto IL_1A3C;
								}
								case 8:
									num = (short)1223098391;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 9:
									num = (short)2054750209;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 10:
									result = true;
									num = (short)1553465347;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 11:
									num = (short)744751109;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 12:
								{
									global::Motorola.MackinawCPS.CoreFeatures.RadioWide.TxFrequencySplitFPPInnerSection txFrequencySplitFPPInnerSection6;
									if (inputFrequency >= txFrequencySplitFPPInnerSection6.RadWideLabtoolTxStartFrequencySplit_A9571.Value * 5)
									{
										num = (short)1477050383;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									break;
								}
								case 13:
									result = true;
									num = (short)1985609748;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 14:
								{
									if (!enumerator.MoveNext())
									{
										num = (short)1897463814;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									global::Motorola.MackinawCPS.CoreFeatures.RadioWide.TxFrequencySplitFPPInnerSection txFrequencySplitFPPInnerSection6 = ((global::AcpCommonLib.IAcpFeatureNode)enumerator.Current)[10095] as global::Motorola.MackinawCPS.CoreFeatures.RadioWide.TxFrequencySplitFPPInnerSection;
									num = (short)507314183;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 15:
									num = (short)902561794;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 16:
								{
									global::Motorola.MackinawCPS.CoreFeatures.RadioWide.TxFrequencySplitFPPInnerSection txFrequencySplitFPPInnerSection6;
									if (txFrequencySplitFPPInnerSection6 != null)
									{
										num = (short)453246984;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									break;
								}
								case 17:
									switch (0)
									{
									case 0:
										goto IL_1A37;
									}
									continue;
								case 18:
								{
									global::Motorola.MackinawCPS.CoreFeatures.RadioWide.TxFrequencySplitFPPInnerSection txFrequencySplitFPPInnerSection6;
									if (txFrequencySplitFPPInnerSection6.RadWideLabtoolTxBandSplitName_A24799.Value == global::CommonResources.AcgResources.ID_P_800M_2)
									{
										num = (short)1981677593;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									break;
								}
								case 19:
									num = (short)423821316;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 20:
									goto IL_1A96;
								case 21:
									goto IL_1DCA;
								case 22:
									goto IL_1C15;
								case 23:
								{
									global::Motorola.MackinawCPS.CoreFeatures.RadioWide.TxFrequencySplitFPPInnerSection txFrequencySplitFPPInnerSection6;
									if (!(txFrequencySplitFPPInnerSection6.RadWideLabtoolTxBandSplitName_A24799.Value == global::CommonResources.AcgResources.ID_P_800M_1))
									{
										num = (short)388431872;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									goto IL_1AF1;
								}
								case 24:
								{
									global::Motorola.MackinawCPS.CoreFeatures.RadioWide.TxFrequencySplitFPPInnerSection txFrequencySplitFPPInnerSection6;
									if (inputFrequency > txFrequencySplitFPPInnerSection6.RadWideLabtoolTxStartFrequencySplit_A9571.Value * 5)
									{
										num = (short)1577189387;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									goto IL_1A3C;
								}
								case 25:
									goto IL_1AF1;
								}
								goto IL_1A37;
								IL_1A3C:
								num = (short)1507983376;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								IL_1AF1:
								num = (short)88145932;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								IL_1BD2:
								num = (short)1588002830;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								IL_1A37:
								goto IL_1BD2;
								IL_1C15:
								num = (short)859176984;
								num2 = (int)((global::System.IntPtr)num);
							}
							IL_1A96:
							IL_1D68:
							return result;
							IL_1DCA:
							goto IL_E17;
						}
						finally
						{
							num = (short)1419771904;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								switch (num2)
								{
								case 0:
									switch (0)
									{
									case 0:
										goto IL_1E02;
									}
									continue;
								case 1:
									enumerator.Dispose();
									num = (short)524550146;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 2:
									goto IL_1E3A;
								}
								IL_1E02:
								if (enumerator == null)
								{
									break;
								}
								num = (short)1469710337;
								num2 = (int)((global::System.IntPtr)num);
							}
							IL_1E3A:;
						}
						goto IL_1E3D;
					case 109:
						num = (short)372768861;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_1E6;
					IL_34D:
					num = (short)379977735;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_38F:
					num = (short)142409746;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_8E0:
					num = (short)1916665960;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_9A5:
					num = (short)1652621357;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					Block_38:
					try
					{
						IL_162A:
						num = (short)669581321;
						num2 = (int)((global::System.IntPtr)num);
						bool result;
						for (;;)
						{
							switch (num2)
							{
							case 0:
								num = (short)1708654598;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							case 1:
							{
								global::Motorola.MackinawCPS.CoreFeatures.RadioWide.TxFrequencySplitFPPInnerSection txFrequencySplitFPPInnerSection7;
								if (!(txFrequencySplitFPPInnerSection7.RadWideLabtoolTxBandSplitName_A24799.Value == global::CommonResources.AcgResources.ID_P_800M_1))
								{
									num = (short)1564540931;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								goto IL_17C3;
							}
							case 2:
							{
								global::Motorola.MackinawCPS.CoreFeatures.RadioWide.TxFrequencySplitFPPInnerSection txFrequencySplitFPPInnerSection7;
								if (txFrequencySplitFPPInnerSection7 != null)
								{
									num = (short)1919025163;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								break;
							}
							case 3:
								num = (short)1686044684;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							case 4:
							{
								global::Motorola.MackinawCPS.CoreFeatures.RadioWide.TxFrequencySplitFPPInnerSection txFrequencySplitFPPInnerSection7;
								if (inputFrequency >= txFrequencySplitFPPInnerSection7.RadWideLabtoolTxStartFrequencySplit_A9571.Value * 5)
								{
									num = (short)1475018752;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								break;
							}
							case 5:
								goto IL_16E4;
							case 6:
							{
								global::Motorola.MackinawCPS.CoreFeatures.RadioWide.TxFrequencySplitFPPInnerSection txFrequencySplitFPPInnerSection7;
								if (inputFrequency < txFrequencySplitFPPInnerSection7.RadWideLabtoolTxEndFrequencySplit_A9532Value * 5)
								{
									num = (short)590020621;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								break;
							}
							case 7:
								num = (short)1551040526;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							case 8:
							{
								if (!enumerator.MoveNext())
								{
									num = (short)256114695;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								global::Motorola.MackinawCPS.CoreFeatures.RadioWide.TxFrequencySplitFPPInnerSection txFrequencySplitFPPInnerSection7 = ((global::AcpCommonLib.IAcpFeatureNode)enumerator.Current)[10095] as global::Motorola.MackinawCPS.CoreFeatures.RadioWide.TxFrequencySplitFPPInnerSection;
								num = (short)2092433410;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							case 9:
								switch (0)
								{
								case 0:
									goto IL_168D;
								}
								continue;
							case 10:
								goto IL_17C3;
							case 11:
								num = (short)1727004673;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							case 12:
							{
								global::Motorola.MackinawCPS.CoreFeatures.RadioWide.TxFrequencySplitFPPInnerSection txFrequencySplitFPPInnerSection7;
								if (txFrequencySplitFPPInnerSection7.RadWideLabtoolTxBandSplitName_A24799.Value == global::CommonResources.AcgResources.ID_P_800M_2)
								{
									num = (short)444465162;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								break;
							}
							case 13:
								result = true;
								num = (short)1362427909;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							case 14:
								goto IL_1875;
							}
							IL_16E9:
							num = (short)1575092232;
							num2 = (int)((global::System.IntPtr)num);
							continue;
							IL_168D:
							goto IL_16E9;
							IL_17C3:
							num = (short)883097604;
							num2 = (int)((global::System.IntPtr)num);
						}
						IL_16E4:
						return result;
						IL_1875:
						goto IL_9A5;
					}
					finally
					{
						num = (short)1366360064;
						num2 = (int)((global::System.IntPtr)num);
						for (;;)
						{
							switch (num2)
							{
							case 0:
								switch (0)
								{
								case 0:
									goto IL_18AC;
								}
								continue;
							case 1:
								enumerator.Dispose();
								num = (short)87818242;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							case 2:
								goto IL_18E6;
							}
							IL_18AC:
							if (enumerator == null)
							{
								break;
							}
							num = (short)1174470657;
							num2 = (int)((global::System.IntPtr)num);
						}
						IL_18E6:;
					}
					goto IL_18E9;
					IL_D17:
					num = (short)768016431;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_D9A:
					num = (short)1024786486;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_E17:
					num = (short)1688600660;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_F46:
					num = (short)1997406239;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_F8A:
					num = (short)1158807621;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_108C:
					num = (short)2087780410;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_10C9:
					enumerator = txFrequencySplitFPPInnerRecset.GetEnumerator();
					num = (short)18743373;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_1134:
					num = (short)644546634;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_1178:
					num = (short)1598750753;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_11F4:
					enumerator = txFrequencySplitFPPInnerRecset.GetEnumerator();
					num = (short)813301862;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_121B:
					enumerator = txFrequencySplitFPPInnerRecset.GetEnumerator();
					num = (short)1450049536;
					short num4 = num;
					num = (short)498008119;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_126B:
					num = (short)510591083;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_12F0:
					num = (short)787218508;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_18E9:
					num = (short)1752170513;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_192C:
					num = (short)565313586;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_1967:
					num = (short)2020343872;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_1E3D:
					num = (short)1955790854;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_1F43:
					enumerator = txFrequencySplitFPPInnerRecset.GetEnumerator();
					num = (short)392495212;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_1F69:
					enumerator = txFrequencySplitFPPInnerRecset.GetEnumerator();
					num = (short)487653475;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_1FCB:
					num = (short)600965159;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					Block_50:
					try
					{
						IL_22D5:
						num = (short)1728774147;
						num2 = (int)((global::System.IntPtr)num);
						bool result;
						for (;;)
						{
							switch (num2)
							{
							case 0:
								goto IL_23E1;
							case 1:
							{
								global::Motorola.MackinawCPS.CoreFeatures.RadioWide.TxFrequencySplitFPPInnerSection txFrequencySplitFPPInnerSection8;
								if (txFrequencySplitFPPInnerSection8 != null)
								{
									num = (short)1057095682;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								break;
							}
							case 2:
								num = (short)1567948811;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							case 3:
								switch (0)
								{
								case 0:
									goto IL_2330;
								}
								continue;
							case 4:
								num = (short)1329070088;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							case 5:
								num = (short)113311753;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							case 6:
								result = true;
								num = (short)472055808;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							case 7:
							{
								global::Motorola.MackinawCPS.CoreFeatures.RadioWide.TxFrequencySplitFPPInnerSection txFrequencySplitFPPInnerSection8;
								if (inputFrequency <= txFrequencySplitFPPInnerSection8.RadWideLabtoolTxEndFrequencySplit_A9532Value * 5)
								{
									num = (short)1307049990;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								break;
							}
							case 8:
							{
								global::Motorola.MackinawCPS.CoreFeatures.RadioWide.TxFrequencySplitFPPInnerSection txFrequencySplitFPPInnerSection8;
								if (inputFrequency >= txFrequencySplitFPPInnerSection8.RadWideLabtoolTxStartFrequencySplit_A9571.Value * 5)
								{
									num = (short)999358476;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								break;
							}
							case 9:
								goto IL_24D6;
							case 10:
							{
								if (!enumerator.MoveNext())
								{
									num = (short)1567621125;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								global::Motorola.MackinawCPS.CoreFeatures.RadioWide.TxFrequencySplitFPPInnerSection txFrequencySplitFPPInnerSection8 = ((global::AcpCommonLib.IAcpFeatureNode)enumerator.Current)[10095] as global::Motorola.MackinawCPS.CoreFeatures.RadioWide.TxFrequencySplitFPPInnerSection;
								num = (short)1777598465;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							case 11:
							{
								global::Motorola.MackinawCPS.CoreFeatures.RadioWide.TxFrequencySplitFPPInnerSection txFrequencySplitFPPInnerSection8;
								if (txFrequencySplitFPPInnerSection8.RadWideLabtoolTxBandSplitName_A24799.Value == global::CommonResources.AcgResources.ID_UHF2)
								{
									num = (short)1958477828;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								break;
							}
							case 12:
								num = (short)1752367111;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							IL_23E6:
							num = (short)1893531658;
							num2 = (int)((global::System.IntPtr)num);
							continue;
							IL_2330:
							goto IL_23E6;
						}
						IL_23E1:
						return result;
						IL_24D6:
						goto IL_1FCB;
					}
					finally
					{
						num = (short)1032781826;
						num2 = (int)((global::System.IntPtr)num);
						for (;;)
						{
							switch (num2)
							{
							case 0:
								enumerator.Dispose();
								num = (short)75038721;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							case 1:
								goto IL_2546;
							case 2:
								switch (0)
								{
								case 0:
									goto IL_250D;
								}
								continue;
							}
							IL_250D:
							if (enumerator == null)
							{
								break;
							}
							num = (short)474152960;
							num2 = (int)((global::System.IntPtr)num);
						}
						IL_2546:;
					}
					IL_2549:
					num = (short)641466372;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_2589:
					enumerator = txFrequencySplitFPPInnerRecset.GetEnumerator();
					num = (short)1338769442;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_25AF:
					enumerator = txFrequencySplitFPPInnerRecset.GetEnumerator();
					num = (short)222298161;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_2618:
					num = (short)2143813704;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_275E:
					enumerator = txFrequencySplitFPPInnerRecset.GetEnumerator();
					num = (short)1426849802;
					num2 = (int)((global::System.IntPtr)num);
				}
				return false;
				IL_1E6:
				global::Motorola.MackinawCPS.CoreFeatures.RadioInformation.FrequencyRanges frequencyRanges = ((global::Motorola.MackinawCPS.CoreFeatures.RadioInformation.RadioInformationRecset)global::AcpCommonLib.FeatureManager.GetFeature(2049))[0][10110] as global::Motorola.MackinawCPS.CoreFeatures.RadioInformation.FrequencyRanges;
				global::Motorola.MackinawCPS.CoreFeatures.RadioInformation.Labtool labtool = ((global::Motorola.MackinawCPS.CoreFeatures.RadioInformation.RadioInformationRecset)global::AcpCommonLib.FeatureManager.GetFeature(2049))[0][10107] as global::Motorola.MackinawCPS.CoreFeatures.RadioInformation.Labtool;
				global::Motorola.MackinawCPS.CoreFeatures.RadioInformation.General general = ((global::Motorola.MackinawCPS.CoreFeatures.RadioInformation.RadioInformationRecset)global::AcpCommonLib.FeatureManager.GetFeature(2049))[0][10108] as global::Motorola.MackinawCPS.CoreFeatures.RadioInformation.General;
				radInfoLabtoolDualBandEnable_A = labtool.RadInfoLabtoolDualBandEnable_A23986;
				radInfoLabtoolPrimaryBands_A = labtool.RadInfoLabtoolPrimaryBands_A23987;
				radInfoLabtoolSecondaryBands_A = labtool.RadInfoLabtoolSecondaryBands_A23988;
				radInfoFrequencyRangesAllowInvalidFrequencies_A = frequencyRanges.RadInfoFrequencyRangesAllowInvalidFrequencies_A12493;
				radInfoFrequencyRangesVHFUsedinCodeplug_A = frequencyRanges.RadInfoFrequencyRangesVHFUsedinCodeplug_A8481;
				radInfoFrequencyRangesUHF1UsedinCodeplug_A = frequencyRanges.RadInfoFrequencyRangesUHF1UsedinCodeplug_A8504;
				radInfoFrequencyRangesUHF2UsedinCodeplug_A = frequencyRanges.RadInfoFrequencyRangesUHF2UsedinCodeplug_A8507;
				radInfoFrequencyRanges7800MHzUsedinCodeplug_A = frequencyRanges.RadInfoFrequencyRanges7800MHzUsedinCodeplug_A8512;
				radInfoFrequencyRanges900MHzUsedinCodeplug_A = frequencyRanges.RadInfoFrequencyRanges900MHzUsedinCodeplug_A8516;
				radInfoFrequencyRanges8900MHzUsedinCodeplug_A = frequencyRanges.RadInfoFrequencyRanges8900MHzUsedinCodeplug_A42502;
				radInfoFrequencyRanges700MHzUsedinCodeplug_A = frequencyRanges.RadInfoFrequencyRanges700MHzUsedinCodeplug_A42551;
				radInfoFrequencyRanges800MHzUsedinCodeplug_A = frequencyRanges.RadInfoFrequencyRanges800MHzUsedinCodeplug_A42552;
				isFreonRadio = global::ConstraintHelper.UtilityMack.IsFreonRadio;
				radInfoGeneralPrimaryFrequencyBandVHF_A = general.RadInfoGeneralPrimaryFrequencyBandVHF_A42545;
				radInfoGeneralPrimaryFrequencyBandUHF1_A = general.RadInfoGeneralPrimaryFrequencyBandUHF1_A42546;
				radInfoGeneralPrimaryFrequencyBandUHF2_A = general.RadInfoGeneralPrimaryFrequencyBandUHF2_A42547;
				radInfoGeneralPrimaryFrequencyBand700_A = general.RadInfoGeneralPrimaryFrequencyBand700_A42543;
				radInfoGeneralPrimaryFrequencyBand800_A = general.RadInfoGeneralPrimaryFrequencyBand800_A42544;
				radInfoGeneralPrimaryFrequencyBand900_A = general.RadInfoGeneralPrimaryFrequencyBand900_A42548;
				txFrequencySplitFPPInnerRecset = (((global::Motorola.MackinawCPS.CoreFeatures.RadioWide.RadioWideRecset)global::AcpCommonLib.FeatureManager.GetFeature(2045))[0][10094].EmbeddedRecset as global::Motorola.MackinawCPS.CoreFeatures.RadioWide.TxFrequencySplitFPPInnerRecset);
				num = (short)346488894;
				num2 = (int)((global::System.IntPtr)num);
				goto IL_27;
			}
			}
		}

		// Token: 0x0600D094 RID: 53396 RVA: 0x00C2A668 File Offset: 0x00C28868
		public static bool IsVHFRxFrequency(int inputFrequency)
		{
			global::System.Collections.Generic.IEnumerator<global::AcpBusinessLayer.FeatureNode> enumerator = (((global::Motorola.MackinawCPS.CoreFeatures.RadioWide.RadioWideRecset)global::AcpCommonLib.FeatureManager.GetFeature(2045))[0][10096].EmbeddedRecset as global::Motorola.MackinawCPS.CoreFeatures.RadioWide.RxFrequencySplitFPPInnerRecset).GetEnumerator();
			short num;
			bool result;
			try
			{
				num = (short)2079260674;
				int num2 = (int)((global::System.IntPtr)num);
				for (;;)
				{
					switch (num2)
					{
					case 0:
					{
						if (!enumerator.MoveNext())
						{
							num = (short)1483866115;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						global::Motorola.MackinawCPS.CoreFeatures.RadioWide.RxFrequencySplitFPPInnerSection rxFrequencySplitFPPInnerSection = ((global::AcpCommonLib.IAcpFeatureNode)enumerator.Current)[10097] as global::Motorola.MackinawCPS.CoreFeatures.RadioWide.RxFrequencySplitFPPInnerSection;
						num = (short)372703238;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 1:
					{
						global::Motorola.MackinawCPS.CoreFeatures.RadioWide.RxFrequencySplitFPPInnerSection rxFrequencySplitFPPInnerSection;
						if (rxFrequencySplitFPPInnerSection.RadWideLabtoolRxBandSplitName_A24797.Value == global::CommonResources.AcgResources.ID_VHF)
						{
							num = (short)870973445;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						break;
					}
					case 2:
						switch (0)
						{
						case 0:
							goto IL_8B;
						}
						continue;
					case 3:
						num = (short)1686175755;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 4:
						result = true;
						num = (short)538640392;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 5:
						num = (short)1484849161;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 6:
					{
						global::Motorola.MackinawCPS.CoreFeatures.RadioWide.RxFrequencySplitFPPInnerSection rxFrequencySplitFPPInnerSection;
						if (rxFrequencySplitFPPInnerSection != null)
						{
							num = (short)945422346;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						break;
					}
					case 7:
						num = (short)405471244;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 8:
						goto IL_A7;
					case 9:
					{
						global::Motorola.MackinawCPS.CoreFeatures.RadioWide.RxFrequencySplitFPPInnerSection rxFrequencySplitFPPInnerSection;
						if (inputFrequency >= rxFrequencySplitFPPInnerSection.RadWideLabtoolRxStartFrequencySplit_A9032.Value)
						{
							num = (short)583204871;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						break;
					}
					case 10:
						num = (short)1654063105;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 11:
						goto IL_21F;
					case 12:
					{
						global::Motorola.MackinawCPS.CoreFeatures.RadioWide.RxFrequencySplitFPPInnerSection rxFrequencySplitFPPInnerSection;
						if (inputFrequency <= rxFrequencySplitFPPInnerSection.RadWideLabtoolRxEndFrequencySplit_A9015.Value)
						{
							num = (short)272695300;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						break;
					}
					}
					IL_139:
					num = (short)301072384;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_8B:
					goto IL_139;
				}
				IL_A7:
				goto IL_306;
				IL_21F:
				return false;
			}
			finally
			{
				num = (short)890417730;
				short num3 = num;
				num = (short)513651266;
				switch ((num3 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					break;
				default:
				{
					num = (short)590217216;
					if (num != 0)
					{
					}
					num = (short)1330774017;
					int num2 = (int)((global::System.IntPtr)num);
					for (;;)
					{
						switch (num2)
						{
						case 0:
							goto IL_2D9;
						case 1:
							switch (0)
							{
							case 0:
								goto IL_2A2;
							}
							continue;
						case 2:
							enumerator.Dispose();
							num = (short)977076224;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						IL_2A2:
						if (enumerator == null)
						{
							goto IL_305;
						}
						num = (short)872873986;
						num2 = (int)((global::System.IntPtr)num);
					}
					break;
				}
				}
				IL_2D9:
				num = (short)1072103425;
				if (num != 0)
				{
				}
				IL_305:;
			}
			IL_306:
			num = (short)227147776;
			short num4 = num;
			return result;
		}

		// Token: 0x0600D095 RID: 53397 RVA: 0x00C2A9C4 File Offset: 0x00C28BC4
		public static bool IsVHFTxFrequency(int inputFrequency)
		{
			global::System.Collections.Generic.IEnumerator<global::AcpBusinessLayer.FeatureNode> enumerator = (((global::Motorola.MackinawCPS.CoreFeatures.RadioWide.RadioWideRecset)global::AcpCommonLib.FeatureManager.GetFeature(2045))[0][10094].EmbeddedRecset as global::Motorola.MackinawCPS.CoreFeatures.RadioWide.TxFrequencySplitFPPInnerRecset).GetEnumerator();
			short num;
			bool result;
			try
			{
				num = (short)1184563202;
				int num2 = (int)((global::System.IntPtr)num);
				for (;;)
				{
					switch (num2)
					{
					case 0:
					{
						if (!enumerator.MoveNext())
						{
							num = (short)431357955;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						global::Motorola.MackinawCPS.CoreFeatures.RadioWide.TxFrequencySplitFPPInnerSection txFrequencySplitFPPInnerSection = ((global::AcpCommonLib.IAcpFeatureNode)enumerator.Current)[10095] as global::Motorola.MackinawCPS.CoreFeatures.RadioWide.TxFrequencySplitFPPInnerSection;
						num = (short)1583611910;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 1:
					{
						global::Motorola.MackinawCPS.CoreFeatures.RadioWide.TxFrequencySplitFPPInnerSection txFrequencySplitFPPInnerSection;
						if (txFrequencySplitFPPInnerSection.RadWideLabtoolTxBandSplitName_A24799.Value == global::CommonResources.AcgResources.ID_VHF)
						{
							num = (short)267976709;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						break;
					}
					case 2:
						switch (0)
						{
						case 0:
							goto IL_DA;
						}
						continue;
					case 3:
						num = (short)446955531;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 4:
						result = true;
						num = (short)1495203848;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 5:
						num = (short)394985481;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 6:
					{
						global::Motorola.MackinawCPS.CoreFeatures.RadioWide.TxFrequencySplitFPPInnerSection txFrequencySplitFPPInnerSection;
						if (txFrequencySplitFPPInnerSection != null)
						{
							num = (short)2133590026;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						break;
					}
					case 7:
						num = (short)1152319500;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 8:
						goto IL_F6;
					case 9:
					{
						global::Motorola.MackinawCPS.CoreFeatures.RadioWide.TxFrequencySplitFPPInnerSection txFrequencySplitFPPInnerSection;
						if (inputFrequency >= txFrequencySplitFPPInnerSection.RadWideLabtoolTxStartFrequencySplit_A9571.Value)
						{
							num = (short)280231943;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						break;
					}
					case 10:
						num = (short)841744385;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 11:
						goto IL_270;
					case 12:
					{
						global::Motorola.MackinawCPS.CoreFeatures.RadioWide.TxFrequencySplitFPPInnerSection txFrequencySplitFPPInnerSection;
						if (inputFrequency <= txFrequencySplitFPPInnerSection.RadWideLabtoolTxEndFrequencySplit_A9532.Value)
						{
							num = (short)1214578692;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						break;
					}
					}
					IL_18A:
					num = (short)1634992128;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_DA:
					goto IL_18A;
				}
				IL_F6:
				return result;
				IL_270:
				goto IL_31;
			}
			finally
			{
				num = (short)870499904;
				short num3 = num;
				num = (short)884786752;
				switch ((num3 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					break;
				default:
				{
					num = (short)458227712;
					if (num != 0)
					{
					}
					num = (short)2098659329;
					int num2 = (int)((global::System.IntPtr)num);
					for (;;)
					{
						switch (num2)
						{
						case 0:
							goto IL_326;
						case 1:
							switch (0)
							{
							case 0:
								goto IL_2F2;
							}
							continue;
						case 2:
							enumerator.Dispose();
							num = (short)784859136;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						IL_2F2:
						if (enumerator == null)
						{
							break;
						}
						num = (short)1143537666;
						num2 = (int)((global::System.IntPtr)num);
					}
					break;
				}
				}
				IL_326:;
			}
			return result;
			IL_31:
			num = (short)1551499264;
			short num4 = num;
			num = (short)1429209089;
			if (num != 0)
			{
			}
			return false;
		}

		// Token: 0x0600D096 RID: 53398 RVA: 0x00C2AD18 File Offset: 0x00C28F18
		public static bool IsNextToVHFRxFrequency(int inputFrequency, int spacing)
		{
			short num = (short)1052508160;
			short num2 = num;
			bool result = false;
			global::System.Collections.Generic.IEnumerator<global::AcpBusinessLayer.FeatureNode> enumerator = (((global::Motorola.MackinawCPS.CoreFeatures.RadioWide.RadioWideRecset)global::AcpCommonLib.FeatureManager.GetFeature(2045))[0][10096].EmbeddedRecset as global::Motorola.MackinawCPS.CoreFeatures.RadioWide.RxFrequencySplitFPPInnerRecset).GetEnumerator();
			try
			{
				num = (short)271253513;
				int num3 = (int)((global::System.IntPtr)num);
				for (;;)
				{
					switch (num3)
					{
					case 0:
						goto IL_40E;
					case 1:
						num = (short)1293746181;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					case 2:
					{
						global::Motorola.MackinawCPS.CoreFeatures.RadioWide.RxFrequencySplitFPPInnerSection rxFrequencySplitFPPInnerSection;
						if (rxFrequencySplitFPPInnerSection != null)
						{
							num = (short)649723916;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_240;
					}
					case 3:
						goto IL_27E;
					case 4:
					{
						global::Motorola.MackinawCPS.CoreFeatures.RadioWide.RxFrequencySplitFPPInnerSection rxFrequencySplitFPPInnerSection;
						if (inputFrequency <= rxFrequencySplitFPPInnerSection.RadWideLabtoolRxEndFrequencySplit_A9015.Value)
						{
							num = (short)1630076948;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_240;
					}
					case 5:
					{
						global::Motorola.MackinawCPS.CoreFeatures.RadioWide.RxFrequencySplitFPPInnerSection rxFrequencySplitFPPInnerSection;
						if (rxFrequencySplitFPPInnerSection.RadWideLabtoolRxEndFrequencySplit_A9015.Value > inputFrequency + 4095 * spacing)
						{
							num = (short)53215238;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_193;
					}
					case 6:
						goto IL_1FD;
					case 7:
						num = (short)1701773322;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					case 8:
					{
						if (!enumerator.MoveNext())
						{
							num = (short)13041682;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						}
						global::Motorola.MackinawCPS.CoreFeatures.RadioWide.RxFrequencySplitFPPInnerSection rxFrequencySplitFPPInnerSection = ((global::AcpCommonLib.IAcpFeatureNode)enumerator.Current)[10097] as global::Motorola.MackinawCPS.CoreFeatures.RadioWide.RxFrequencySplitFPPInnerSection;
						num = (short)1524170754;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 9:
						switch (0)
						{
						case 0:
							goto IL_D6;
						}
						continue;
					case 10:
					{
						global::Motorola.MackinawCPS.CoreFeatures.RadioWide.RxFrequencySplitFPPInnerSection rxFrequencySplitFPPInnerSection;
						if (rxFrequencySplitFPPInnerSection.RadWideLabtoolRxStartFrequencySplit_A9032.Value > inputFrequency + 4095 * spacing)
						{
							num = (short)1803747331;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_193;
					}
					case 11:
					{
						global::Motorola.MackinawCPS.CoreFeatures.RadioWide.RxFrequencySplitFPPInnerSection rxFrequencySplitFPPInnerSection;
						if (rxFrequencySplitFPPInnerSection.RadWideLabtoolRxBandSplitName_A24797.Value == global::CommonResources.AcgResources.ID_VHF)
						{
							num = (short)1351876625;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_240;
					}
					case 12:
						num = (short)1510080523;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					case 13:
					{
						global::Motorola.MackinawCPS.CoreFeatures.RadioWide.RxFrequencySplitFPPInnerSection rxFrequencySplitFPPInnerSection;
						if (rxFrequencySplitFPPInnerSection.RadWideLabtoolRxEndFrequencySplit_A9015.Value >= inputFrequency)
						{
							num = (short)2087649281;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_1FD;
					}
					case 14:
						num = (short)1368522756;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					case 15:
						goto IL_240;
					case 16:
					{
						global::Motorola.MackinawCPS.CoreFeatures.RadioWide.RxFrequencySplitFPPInnerSection rxFrequencySplitFPPInnerSection;
						if (inputFrequency >= rxFrequencySplitFPPInnerSection.RadWideLabtoolRxStartFrequencySplit_A9032.Value)
						{
							num = (short)1746403342;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_240;
					}
					case 17:
						num = (short)459014163;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					case 18:
						num = (short)406519808;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					case 19:
					{
						global::Motorola.MackinawCPS.CoreFeatures.RadioWide.RxFrequencySplitFPPInnerSection rxFrequencySplitFPPInnerSection;
						if (rxFrequencySplitFPPInnerSection.RadWideLabtoolRxStartFrequencySplit_A9032.Value >= inputFrequency)
						{
							num = (short)239009799;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_27E;
					}
					case 20:
						goto IL_193;
					}
					goto IL_D6;
					IL_193:
					result = true;
					num = (short)1400242191;
					num3 = (int)((global::System.IntPtr)num);
					continue;
					IL_1FD:
					num = (short)1692729360;
					num3 = (int)((global::System.IntPtr)num);
					continue;
					IL_240:
					num = (short)235601928;
					num3 = (int)((global::System.IntPtr)num);
					continue;
					IL_D6:
					num = (short)1170800641;
					if (num != 0)
					{
					}
					num = (short)925661777;
					short num4 = num;
					num = (short)1095924305;
					switch ((num4 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						IL_27E:
						num = (short)1848770573;
						num3 = (int)((global::System.IntPtr)num);
						break;
					default:
						num = (short)1067778048;
						if (num != 0)
						{
						}
						goto IL_240;
					}
				}
				IL_40E:;
			}
			finally
			{
				num = (short)1537736705;
				int num3 = (int)((global::System.IntPtr)num);
				for (;;)
				{
					switch (num3)
					{
					case 0:
						enumerator.Dispose();
						num = (short)340131842;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					case 1:
						switch (0)
						{
						case 0:
							goto IL_442;
						}
						continue;
					case 2:
						goto IL_475;
					}
					IL_442:
					if (enumerator == null)
					{
						break;
					}
					num = (short)1470431232;
					num3 = (int)((global::System.IntPtr)num);
				}
				IL_475:;
			}
			return result;
		}

		// Token: 0x0600D097 RID: 53399 RVA: 0x00C2B1BC File Offset: 0x00C293BC
		public static bool IsVHFSupported()
		{
			switch (0)
			{
			case 0:
				goto IL_40;
			}
			int num;
			global::Motorola.MackinawCPS.CoreFeatures.RadioInformation.RadioInformation radioInformation;
			short num2;
			for (;;)
			{
				IL_0A:
				switch (num)
				{
				case 0:
					if (radioInformation.Labtool.RadInfoLabtoolDualBandEnable_A23986.Value)
					{
						num2 = (short)1129644037;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_CD;
				case 1:
					num2 = (short)1697579008;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 2:
					if (radioInformation.Labtool.RadInfoLabtoolPrimaryBands_A23987.Value != 2)
					{
						num2 = (short)753336324;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_182;
				case 3:
					goto IL_CD;
				case 4:
					num2 = (short)942800905;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 5:
					num2 = (short)1729298443;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 6:
					num2 = (short)1917648898;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 7:
					goto IL_110;
				case 8:
					if (radioInformation.Labtool.RadInfoLabtoolDualBandEnable_A23986.Value)
					{
						num2 = (short)1353842695;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					return false;
				case 9:
				{
					num2 = (short)1872625664;
					short num3 = num2;
					if (radioInformation.Labtool.RadInfoLabtoolPrimaryBands_A23987.Value != 3)
					{
						num2 = (short)596836353;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_182;
				}
				case 10:
					if (!global::ConstraintHelper.UtilityMack.IsFreonRadio)
					{
						num2 = (short)1963393030;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_2AD;
				case 11:
					if (radioInformation.Labtool.RadInfoLabtoolSecondaryBands_A23988.Value != 2)
					{
						goto IL_245;
					}
					goto IL_182;
				}
				goto IL_40;
				IL_CD:
				num2 = (short)1289224200;
				num = (int)((global::System.IntPtr)num2);
				continue;
				IL_245:
				num2 = (short)257687555;
				num = (int)((global::System.IntPtr)num2);
				continue;
				IL_182:
				num2 = (short)1355026221;
				short num4 = num2;
				num2 = (short)849547053;
				switch ((num4 == num2) ? 1 : 0)
				{
				case 0:
				case 2:
					goto IL_245;
				default:
					goto IL_1B6;
				}
			}
			IL_110:
			return radioInformation.Labtool.RadInfoLabtoolSecondaryBands_A23988.Value == 3;
			IL_1B6:
			num2 = (short)1898315776;
			if (num2 != 0)
			{
			}
			return true;
			IL_2AD:
			return radioInformation.General.RadInfoGeneralPrimaryFrequencyBandVHF_A42545.Value;
			IL_40:
			radioInformation = (global::AcpCommonLib.FeatureManager.GetFeature(2049)[0] as global::Motorola.MackinawCPS.CoreFeatures.RadioInformation.RadioInformation);
			num2 = (short)1903886337;
			if (num2 != 0)
			{
			}
			num2 = (short)1126825994;
			num = (int)((global::System.IntPtr)num2);
			goto IL_0A;
		}

		// Token: 0x0600D098 RID: 53400 RVA: 0x00C2B488 File Offset: 0x00C29688
		public static bool IsUHF1RxFrequency(int inputFrequency)
		{
			global::System.Collections.Generic.IEnumerator<global::AcpBusinessLayer.FeatureNode> enumerator = (((global::Motorola.MackinawCPS.CoreFeatures.RadioWide.RadioWideRecset)global::AcpCommonLib.FeatureManager.GetFeature(2045))[0][10096].EmbeddedRecset as global::Motorola.MackinawCPS.CoreFeatures.RadioWide.RxFrequencySplitFPPInnerRecset).GetEnumerator();
			short num;
			bool result;
			try
			{
				num = (short)492699659;
				int num2 = (int)((global::System.IntPtr)num);
				for (;;)
				{
					switch (num2)
					{
					case 0:
					{
						if (!enumerator.MoveNext())
						{
							num = (short)956628995;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						global::Motorola.MackinawCPS.CoreFeatures.RadioWide.RxFrequencySplitFPPInnerSection rxFrequencySplitFPPInnerSection = ((global::AcpCommonLib.IAcpFeatureNode)enumerator.Current)[10097] as global::Motorola.MackinawCPS.CoreFeatures.RadioWide.RxFrequencySplitFPPInnerSection;
						num = (short)1354301442;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 1:
						num = (short)902889478;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 2:
					{
						global::Motorola.MackinawCPS.CoreFeatures.RadioWide.RxFrequencySplitFPPInnerSection rxFrequencySplitFPPInnerSection;
						if (rxFrequencySplitFPPInnerSection != null)
						{
							num = (short)223084553;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						break;
					}
					case 3:
						num = (short)1275527176;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 4:
					{
						global::Motorola.MackinawCPS.CoreFeatures.RadioWide.RxFrequencySplitFPPInnerSection rxFrequencySplitFPPInnerSection;
						if (rxFrequencySplitFPPInnerSection.RadWideLabtoolRxBandSplitName_A24797.Value == global::CommonResources.AcgResources.ID_UHF1)
						{
							num = (short)1433862145;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						break;
					}
					case 5:
					{
						global::Motorola.MackinawCPS.CoreFeatures.RadioWide.RxFrequencySplitFPPInnerSection rxFrequencySplitFPPInnerSection;
						if (inputFrequency <= rxFrequencySplitFPPInnerSection.RadWideLabtoolRxEndFrequencySplit_A9015.Value)
						{
							num = (short)1380843530;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						break;
					}
					case 6:
					{
						global::Motorola.MackinawCPS.CoreFeatures.RadioWide.RxFrequencySplitFPPInnerSection rxFrequencySplitFPPInnerSection;
						if (inputFrequency >= rxFrequencySplitFPPInnerSection.RadWideLabtoolRxStartFrequencySplit_A9032.Value)
						{
							num = (short)1131413516;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						break;
					}
					case 7:
						goto IL_D4;
					case 8:
						goto IL_299;
					case 9:
					{
						num = (short)448237520;
						short num3 = num;
						num = (short)351178704;
						switch ((num3 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_1E5;
						default:
							num = (short)2071527424;
							if (num != 0)
							{
							}
							num = (short)1648558084;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						break;
					}
					case 10:
						result = true;
						num = (short)1482817543;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 11:
						switch (0)
						{
						case 0:
							goto IL_B7;
						}
						continue;
					case 12:
						goto IL_1E5;
					}
					IL_167:
					num = (short)2057306112;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_B7:
					goto IL_167;
					IL_1E5:
					num = (short)1954938885;
					num2 = (int)((global::System.IntPtr)num);
				}
				IL_D4:
				goto IL_305;
				IL_299:
				goto IL_31;
			}
			finally
			{
				num = (short)1847197697;
				int num2 = (int)((global::System.IntPtr)num);
				for (;;)
				{
					switch (num2)
					{
					case 0:
						enumerator.Dispose();
						num = (short)351928322;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 1:
						switch (0)
						{
						case 0:
							goto IL_2CE;
						}
						continue;
					case 2:
						goto IL_302;
					}
					IL_2CE:
					if (enumerator == null)
					{
						break;
					}
					num = (short)1097596928;
					num2 = (int)((global::System.IntPtr)num);
				}
				IL_302:;
			}
			goto IL_305;
			IL_31:
			num = (short)1536688128;
			short num4 = num;
			return false;
			IL_305:
			num = (short)325844993;
			if (num != 0)
			{
			}
			return result;
		}

		// Token: 0x0600D099 RID: 53401 RVA: 0x00C2B7E0 File Offset: 0x00C299E0
		public static bool IsUHF1TxFrequency(int inputFrequency)
		{
			global::System.Collections.Generic.IEnumerator<global::AcpBusinessLayer.FeatureNode> enumerator = (((global::Motorola.MackinawCPS.CoreFeatures.RadioWide.RadioWideRecset)global::AcpCommonLib.FeatureManager.GetFeature(2045))[0][10094].EmbeddedRecset as global::Motorola.MackinawCPS.CoreFeatures.RadioWide.TxFrequencySplitFPPInnerRecset).GetEnumerator();
			short num;
			bool result;
			try
			{
				num = (short)1521745931;
				int num2 = (int)((global::System.IntPtr)num);
				for (;;)
				{
					switch (num2)
					{
					case 0:
					{
						if (!enumerator.MoveNext())
						{
							num = (short)710672387;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						global::Motorola.MackinawCPS.CoreFeatures.RadioWide.TxFrequencySplitFPPInnerSection txFrequencySplitFPPInnerSection = ((global::AcpCommonLib.IAcpFeatureNode)enumerator.Current)[10095] as global::Motorola.MackinawCPS.CoreFeatures.RadioWide.TxFrequencySplitFPPInnerSection;
						num = (short)44630018;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 1:
						num = (short)164757510;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 2:
					{
						global::Motorola.MackinawCPS.CoreFeatures.RadioWide.TxFrequencySplitFPPInnerSection txFrequencySplitFPPInnerSection;
						if (txFrequencySplitFPPInnerSection != null)
						{
							num = (short)781058057;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						break;
					}
					case 3:
						num = (short)1809252360;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 4:
					{
						global::Motorola.MackinawCPS.CoreFeatures.RadioWide.TxFrequencySplitFPPInnerSection txFrequencySplitFPPInnerSection;
						if (txFrequencySplitFPPInnerSection.RadWideLabtoolTxBandSplitName_A24799.Value == global::CommonResources.AcgResources.ID_UHF1)
						{
							num = (short)1361379329;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						break;
					}
					case 5:
					{
						global::Motorola.MackinawCPS.CoreFeatures.RadioWide.TxFrequencySplitFPPInnerSection txFrequencySplitFPPInnerSection;
						if (inputFrequency <= txFrequencySplitFPPInnerSection.RadWideLabtoolTxEndFrequencySplit_A9532.Value)
						{
							num = (short)1187250186;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						break;
					}
					case 6:
					{
						global::Motorola.MackinawCPS.CoreFeatures.RadioWide.TxFrequencySplitFPPInnerSection txFrequencySplitFPPInnerSection;
						if (inputFrequency >= txFrequencySplitFPPInnerSection.RadWideLabtoolTxStartFrequencySplit_A9571.Value)
						{
							num = (short)565968908;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						break;
					}
					case 7:
						goto IL_FA;
					case 8:
						goto IL_2C1;
					case 9:
					{
						num = (short)1844521041;
						short num3 = num;
						num = (short)82323537;
						switch ((num3 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_209;
						default:
							num = (short)992018432;
							if (num != 0)
							{
							}
							num = (short)584515588;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						break;
					}
					case 10:
						result = true;
						num = (short)136118279;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 11:
						switch (0)
						{
						case 0:
							goto IL_DF;
						}
						continue;
					case 12:
						goto IL_209;
					}
					IL_18E:
					num = (short)1265631232;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_DF:
					goto IL_18E;
					IL_209:
					num = (short)983045;
					num2 = (int)((global::System.IntPtr)num);
				}
				IL_FA:
				return result;
				IL_2C1:
				goto IL_31;
			}
			finally
			{
				num = (short)505413633;
				int num2 = (int)((global::System.IntPtr)num);
				for (;;)
				{
					switch (num2)
					{
					case 0:
						enumerator.Dispose();
						num = (short)1320353794;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 1:
						switch (0)
						{
						case 0:
							goto IL_2F6;
						}
						continue;
					case 2:
						goto IL_32C;
					}
					IL_2F6:
					if (enumerator == null)
					{
						break;
					}
					num = (short)1355218944;
					num2 = (int)((global::System.IntPtr)num);
				}
				IL_32C:;
			}
			return result;
			IL_31:
			num = (short)1707016192;
			short num4 = num;
			num = (short)1460338689;
			if (num != 0)
			{
			}
			return false;
		}

		// Token: 0x0600D09A RID: 53402 RVA: 0x00C2BB3C File Offset: 0x00C29D3C
		public static bool IsNextToUHF1RxFrequency(int inputFrequency, int spacing)
		{
			short num = (short)1442250752;
			short num2 = num;
			bool result = false;
			global::System.Collections.Generic.IEnumerator<global::AcpBusinessLayer.FeatureNode> enumerator = (((global::Motorola.MackinawCPS.CoreFeatures.RadioWide.RadioWideRecset)global::AcpCommonLib.FeatureManager.GetFeature(2045))[0][10096].EmbeddedRecset as global::Motorola.MackinawCPS.CoreFeatures.RadioWide.RxFrequencySplitFPPInnerRecset).GetEnumerator();
			try
			{
				num = (short)1234042889;
				int num3 = (int)((global::System.IntPtr)num);
				for (;;)
				{
					switch (num3)
					{
					case 0:
						goto IL_40B;
					case 1:
						num = (short)1040908293;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					case 2:
					{
						global::Motorola.MackinawCPS.CoreFeatures.RadioWide.RxFrequencySplitFPPInnerSection rxFrequencySplitFPPInnerSection;
						if (rxFrequencySplitFPPInnerSection != null)
						{
							num = (short)1874657292;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_218;
					}
					case 3:
						goto IL_257;
					case 4:
					{
						global::Motorola.MackinawCPS.CoreFeatures.RadioWide.RxFrequencySplitFPPInnerSection rxFrequencySplitFPPInnerSection;
						if (inputFrequency <= rxFrequencySplitFPPInnerSection.RadWideLabtoolRxEndFrequencySplit_A9015.Value)
						{
							num = (short)947912724;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_218;
					}
					case 5:
					{
						global::Motorola.MackinawCPS.CoreFeatures.RadioWide.RxFrequencySplitFPPInnerSection rxFrequencySplitFPPInnerSection;
						if (rxFrequencySplitFPPInnerSection.RadWideLabtoolRxEndFrequencySplit_A9015.Value > inputFrequency + 4095 * spacing)
						{
							num = (short)1216282630;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_16E;
					}
					case 6:
						num = (short)448069633;
						if (num != 0)
						{
						}
						goto IL_1D6;
					case 7:
						num = (short)1121452042;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					case 8:
					{
						if (!enumerator.MoveNext())
						{
							num = (short)96337938;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						}
						global::Motorola.MackinawCPS.CoreFeatures.RadioWide.RxFrequencySplitFPPInnerSection rxFrequencySplitFPPInnerSection = ((global::AcpCommonLib.IAcpFeatureNode)enumerator.Current)[10097] as global::Motorola.MackinawCPS.CoreFeatures.RadioWide.RxFrequencySplitFPPInnerSection;
						num = (short)748027906;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 9:
						switch (0)
						{
						case 0:
							goto IL_D6;
						}
						continue;
					case 10:
					{
						global::Motorola.MackinawCPS.CoreFeatures.RadioWide.RxFrequencySplitFPPInnerSection rxFrequencySplitFPPInnerSection;
						if (rxFrequencySplitFPPInnerSection.RadWideLabtoolRxStartFrequencySplit_A9032.Value > inputFrequency + 4095 * spacing)
						{
							num = (short)1964179459;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_16E;
					}
					case 11:
					{
						global::Motorola.MackinawCPS.CoreFeatures.RadioWide.RxFrequencySplitFPPInnerSection rxFrequencySplitFPPInnerSection;
						if (rxFrequencySplitFPPInnerSection.RadWideLabtoolRxBandSplitName_A24797.Value == global::CommonResources.AcgResources.ID_UHF1)
						{
							num = (short)1259864081;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_218;
					}
					case 12:
						num = (short)200736779;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					case 13:
					{
						global::Motorola.MackinawCPS.CoreFeatures.RadioWide.RxFrequencySplitFPPInnerSection rxFrequencySplitFPPInnerSection;
						if (rxFrequencySplitFPPInnerSection.RadWideLabtoolRxEndFrequencySplit_A9015.Value >= inputFrequency)
						{
							num = (short)1080426497;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_1D6;
					}
					case 14:
						num = (short)730529796;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					case 15:
						goto IL_218;
					case 16:
					{
						global::Motorola.MackinawCPS.CoreFeatures.RadioWide.RxFrequencySplitFPPInnerSection rxFrequencySplitFPPInnerSection;
						if (inputFrequency >= rxFrequencySplitFPPInnerSection.RadWideLabtoolRxStartFrequencySplit_A9032.Value)
						{
							num = (short)1924661262;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_218;
					}
					case 17:
						num = (short)408485907;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					case 18:
						num = (short)1243676672;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					case 19:
					{
						global::Motorola.MackinawCPS.CoreFeatures.RadioWide.RxFrequencySplitFPPInnerSection rxFrequencySplitFPPInnerSection;
						if (rxFrequencySplitFPPInnerSection.RadWideLabtoolRxStartFrequencySplit_A9032.Value >= inputFrequency)
						{
							num = (short)899809287;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_257;
					}
					case 20:
						goto IL_16E;
					}
					goto IL_D6;
					IL_16E:
					result = true;
					num = (short)680132623;
					num3 = (int)((global::System.IntPtr)num);
					continue;
					IL_1D6:
					num = (short)2053046288;
					num3 = (int)((global::System.IntPtr)num);
					continue;
					IL_218:
					num = (short)2033909768;
					num3 = (int)((global::System.IntPtr)num);
					continue;
					IL_D6:
					num = (short)1151427644;
					short num4 = num;
					num = (short)1746756668;
					switch ((num4 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						IL_257:
						num = (short)1609367565;
						num3 = (int)((global::System.IntPtr)num);
						break;
					default:
						num = (short)372703232;
						if (num != 0)
						{
						}
						goto IL_218;
					}
				}
				IL_40B:;
			}
			finally
			{
				num = (short)680853505;
				int num3 = (int)((global::System.IntPtr)num);
				for (;;)
				{
					switch (num3)
					{
					case 0:
						enumerator.Dispose();
						num = (short)1112080386;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					case 1:
						switch (0)
						{
						case 0:
							goto IL_43E;
						}
						continue;
					case 2:
						goto IL_473;
					}
					IL_43E:
					if (enumerator == null)
					{
						break;
					}
					num = (short)610402304;
					num3 = (int)((global::System.IntPtr)num);
				}
				IL_473:;
			}
			return result;
		}

		// Token: 0x0600D09B RID: 53403 RVA: 0x00C2BFDC File Offset: 0x00C2A1DC
		public static bool IsNextToUHF1RxFrequencyWithoutUHF2(int inputFrequency, int spacing)
		{
			short num = (short)494200336;
			short num2 = num;
			num = (short)88729104;
			bool result;
			switch ((num2 == num) ? 1 : 0)
			{
			case 0:
			case 2:
				return result;
			case 1:
				break;
			default:
			{
				num = (short)1683095552;
				short num3 = num;
				break;
			}
			}
			num = (short)22478848;
			if (num != 0)
			{
			}
			num = (short)1966407680;
			switch (num)
			{
			default:
			{
				result = false;
				int num4 = 90000000;
				global::Motorola.MackinawCPS.CoreFeatures.RadioWide.RxFrequencySplitFPPInnerRecset rxFrequencySplitFPPInnerRecset = ((global::Motorola.MackinawCPS.CoreFeatures.RadioWide.RadioWideRecset)global::AcpCommonLib.FeatureManager.GetFeature(2045))[0][10096].EmbeddedRecset as global::Motorola.MackinawCPS.CoreFeatures.RadioWide.RxFrequencySplitFPPInnerRecset;
				global::System.Collections.Generic.IEnumerator<global::AcpBusinessLayer.FeatureNode> enumerator = rxFrequencySplitFPPInnerRecset.GetEnumerator();
				try
				{
					num = (short)835387396;
					int num5 = (int)((global::System.IntPtr)num);
					for (;;)
					{
						switch (num5)
						{
						case 0:
							goto IL_5FB;
						case 1:
							num = (short)1812463622;
							num5 = (int)((global::System.IntPtr)num);
							continue;
						case 2:
							num = (short)767098880;
							num5 = (int)((global::System.IntPtr)num);
							continue;
						case 3:
						{
							num = (short)474415105;
							if (num != 0)
							{
							}
							global::Motorola.MackinawCPS.CoreFeatures.RadioWide.RxFrequencySplitFPPInnerSection rxFrequencySplitFPPInnerSection;
							if (rxFrequencySplitFPPInnerSection != null)
							{
								num = (short)1135017985;
								num5 = (int)((global::System.IntPtr)num);
								continue;
							}
							break;
						}
						case 4:
							switch (0)
							{
							case 0:
								goto IL_4BE;
							}
							continue;
						case 5:
						{
							global::Motorola.MackinawCPS.CoreFeatures.RadioWide.RxFrequencySplitFPPInnerSection rxFrequencySplitFPPInnerSection;
							num4 = rxFrequencySplitFPPInnerSection.RadWideLabtoolRxStartFrequencySplit_A9032.Value;
							num = (short)1749614600;
							num5 = (int)((global::System.IntPtr)num);
							continue;
						}
						case 6:
						{
							global::Motorola.MackinawCPS.CoreFeatures.RadioWide.RxFrequencySplitFPPInnerSection rxFrequencySplitFPPInnerSection;
							if (rxFrequencySplitFPPInnerSection.RadWideLabtoolRxBandSplitName_A24797.Value == global::CommonResources.AcgResources.ID_UHF2)
							{
								num = (short)1667170309;
								num5 = (int)((global::System.IntPtr)num);
								continue;
							}
							break;
						}
						case 7:
						{
							if (!enumerator.MoveNext())
							{
								num = (short)1279000578;
								num5 = (int)((global::System.IntPtr)num);
								continue;
							}
							global::Motorola.MackinawCPS.CoreFeatures.RadioWide.RxFrequencySplitFPPInnerSection rxFrequencySplitFPPInnerSection = ((global::AcpCommonLib.IAcpFeatureNode)enumerator.Current)[10097] as global::Motorola.MackinawCPS.CoreFeatures.RadioWide.RxFrequencySplitFPPInnerSection;
							num = (short)572063747;
							num5 = (int)((global::System.IntPtr)num);
							continue;
						}
						}
						IL_532:
						num = (short)1557463047;
						num5 = (int)((global::System.IntPtr)num);
						continue;
						IL_4BE:
						goto IL_532;
					}
					IL_5FB:
					goto IL_467;
				}
				finally
				{
					num = (short)1341521921;
					int num5 = (int)((global::System.IntPtr)num);
					for (;;)
					{
						switch (num5)
						{
						case 0:
							goto IL_669;
						case 1:
							switch (0)
							{
							case 0:
								goto IL_632;
							}
							continue;
						case 2:
							enumerator.Dispose();
							num = (short)448331776;
							num5 = (int)((global::System.IntPtr)num);
							continue;
						}
						IL_632:
						if (enumerator == null)
						{
							break;
						}
						num = (short)2115305474;
						num5 = (int)((global::System.IntPtr)num);
					}
					IL_669:;
				}
				break;
				for (;;)
				{
					IL_467:
					enumerator = rxFrequencySplitFPPInnerRecset.GetEnumerator();
					try
					{
						num = (short)2042363913;
						int num5 = (int)((global::System.IntPtr)num);
						for (;;)
						{
							switch (num5)
							{
							case 0:
								goto IL_3F8;
							case 1:
								goto IL_259;
							case 2:
							{
								global::Motorola.MackinawCPS.CoreFeatures.RadioWide.RxFrequencySplitFPPInnerSection rxFrequencySplitFPPInnerSection2;
								if (rxFrequencySplitFPPInnerSection2.RadWideLabtoolRxStartFrequencySplit_A9032.Value >= inputFrequency)
								{
									num = (short)1728643084;
									num5 = (int)((global::System.IntPtr)num);
									continue;
								}
								goto IL_1CE;
							}
							case 3:
								goto IL_14C;
							case 4:
							{
								global::Motorola.MackinawCPS.CoreFeatures.RadioWide.RxFrequencySplitFPPInnerSection rxFrequencySplitFPPInnerSection2;
								if (rxFrequencySplitFPPInnerSection2 != null)
								{
									num = (short)106954772;
									num5 = (int)((global::System.IntPtr)num);
									continue;
								}
								break;
							}
							case 5:
							{
								global::Motorola.MackinawCPS.CoreFeatures.RadioWide.RxFrequencySplitFPPInnerSection rxFrequencySplitFPPInnerSection2;
								if (rxFrequencySplitFPPInnerSection2.RadWideLabtoolRxStartFrequencySplit_A9032.Value > inputFrequency + 4095 * spacing)
								{
									num = (short)2053046278;
									num5 = (int)((global::System.IntPtr)num);
									continue;
								}
								goto IL_259;
							}
							case 6:
								goto IL_1CE;
							case 7:
								num = (short)794492941;
								num5 = (int)((global::System.IntPtr)num);
								continue;
							case 8:
								num = (short)98107394;
								num5 = (int)((global::System.IntPtr)num);
								continue;
							case 9:
								switch (0)
								{
								case 0:
									goto IL_14A;
								}
								continue;
							case 10:
								if (num4 >= inputFrequency + 4095 * spacing)
								{
									num = (short)239861763;
									num5 = (int)((global::System.IntPtr)num);
									continue;
								}
								goto IL_259;
							case 11:
								num = (short)502333440;
								num5 = (int)((global::System.IntPtr)num);
								continue;
							case 12:
								num = (short)2120876037;
								num5 = (int)((global::System.IntPtr)num);
								continue;
							case 13:
								if (inputFrequency < num4)
								{
									num = (short)809107457;
									num5 = (int)((global::System.IntPtr)num);
									continue;
								}
								break;
							case 14:
							{
								global::Motorola.MackinawCPS.CoreFeatures.RadioWide.RxFrequencySplitFPPInnerSection rxFrequencySplitFPPInnerSection2;
								if (rxFrequencySplitFPPInnerSection2.RadWideLabtoolRxBandSplitName_A24797.Value == global::CommonResources.AcgResources.ID_UHF1)
								{
									num = (short)1189871624;
									num5 = (int)((global::System.IntPtr)num);
									continue;
								}
								break;
							}
							case 15:
							{
								if (!enumerator.MoveNext())
								{
									num = (short)2076377099;
									num5 = (int)((global::System.IntPtr)num);
									continue;
								}
								global::Motorola.MackinawCPS.CoreFeatures.RadioWide.RxFrequencySplitFPPInnerSection rxFrequencySplitFPPInnerSection2 = ((global::AcpCommonLib.IAcpFeatureNode)enumerator.Current)[10097] as global::Motorola.MackinawCPS.CoreFeatures.RadioWide.RxFrequencySplitFPPInnerSection;
								num = (short)1584332804;
								num5 = (int)((global::System.IntPtr)num);
								continue;
							}
							case 16:
								num = (short)167641098;
								num5 = (int)((global::System.IntPtr)num);
								continue;
							case 17:
								if (num4 > inputFrequency)
								{
									num = (short)1792475152;
									num5 = (int)((global::System.IntPtr)num);
									continue;
								}
								goto IL_14C;
							case 19:
							{
								global::Motorola.MackinawCPS.CoreFeatures.RadioWide.RxFrequencySplitFPPInnerSection rxFrequencySplitFPPInnerSection2;
								if (inputFrequency >= rxFrequencySplitFPPInnerSection2.RadWideLabtoolRxStartFrequencySplit_A9032.Value)
								{
									num = (short)1957625863;
									num5 = (int)((global::System.IntPtr)num);
									continue;
								}
								break;
							}
							case 20:
								num = (short)1977221134;
								num5 = (int)((global::System.IntPtr)num);
								continue;
							}
							goto IL_14A;
							IL_14C:
							num = (short)25952275;
							num5 = (int)((global::System.IntPtr)num);
							continue;
							IL_18E:
							num = (short)93913103;
							num5 = (int)((global::System.IntPtr)num);
							continue;
							IL_14A:
							goto IL_18E;
							IL_1CE:
							num = (short)2015428625;
							num5 = (int)((global::System.IntPtr)num);
							continue;
							IL_259:
							result = true;
							num = (short)1025245202;
							num5 = (int)((global::System.IntPtr)num);
						}
						IL_3F8:
						break;
					}
					finally
					{
						num = (short)1211367425;
						int num5 = (int)((global::System.IntPtr)num);
						for (;;)
						{
							switch (num5)
							{
							case 0:
								goto IL_464;
							case 1:
								switch (0)
								{
								case 0:
									goto IL_42F;
								}
								continue;
							case 2:
								enumerator.Dispose();
								num = (short)70385664;
								num5 = (int)((global::System.IntPtr)num);
								continue;
							}
							IL_42F:
							if (enumerator == null)
							{
								break;
							}
							num = (short)184877058;
							num5 = (int)((global::System.IntPtr)num);
						}
						IL_464:;
					}
				}
				break;
			}
			}
			return result;
		}

		// Token: 0x0600D09C RID: 53404 RVA: 0x00C2C68C File Offset: 0x00C2A88C
		public static bool IsUHF1Supported()
		{
			int num;
			short num2;
			global::Motorola.MackinawCPS.CoreFeatures.RadioInformation.RadioInformation radioInformation;
			switch (0)
			{
			case 0:
				break;
			default:
			{
				for (;;)
				{
					IL_0A:
					switch (num)
					{
					case 0:
						if (!global::ConstraintHelper.UtilityMack.IsFreonRadio)
						{
							num2 = (short)740098055;
							num = (int)((global::System.IntPtr)num2);
							continue;
						}
						goto IL_2AC;
					case 1:
						if (radioInformation.Labtool.RadInfoLabtoolSecondaryBands_A23988.Value != 4)
						{
							num2 = (short)967114761;
							num = (int)((global::System.IntPtr)num2);
							continue;
						}
						return true;
					case 2:
						goto IL_E7;
					case 3:
						num2 = (short)624951297;
						num = (int)((global::System.IntPtr)num2);
						continue;
					case 4:
						if (radioInformation.Labtool.RadInfoLabtoolDualBandEnable_A23986.Value)
						{
							num2 = (short)2079326211;
							num = (int)((global::System.IntPtr)num2);
							continue;
						}
						goto IL_A2;
					case 5:
						num2 = (short)2135949320;
						num = (int)((global::System.IntPtr)num2);
						continue;
					case 6:
						if (radioInformation.Labtool.RadInfoLabtoolDualBandEnable_A23986.Value)
						{
							num2 = (short)1615724546;
							num = (int)((global::System.IntPtr)num2);
							continue;
						}
						return false;
					case 7:
						num2 = (short)505610251;
						num = (int)((global::System.IntPtr)num2);
						continue;
					case 8:
						if (radioInformation.Labtool.RadInfoLabtoolPrimaryBands_A23987.Value != 5)
						{
							num2 = (short)370016266;
							num = (int)((global::System.IntPtr)num2);
							continue;
						}
						return true;
					case 9:
						goto IL_A2;
					case 10:
						num2 = (short)1816723460;
						num = (int)((global::System.IntPtr)num2);
						continue;
					case 11:
						if (radioInformation.Labtool.RadInfoLabtoolPrimaryBands_A23987.Value != 4)
						{
							num2 = (short)1973944325;
							num = (int)((global::System.IntPtr)num2);
							continue;
						}
						return true;
					}
					goto IL_40;
					IL_A2:
					num2 = (short)157614086;
					num = (int)((global::System.IntPtr)num2);
				}
				IL_E7:
				num2 = (short)1362323096;
				short num3 = num2;
				num2 = (short)580413080;
				switch ((num3 == num2) ? 1 : 0)
				{
				case 0:
				case 2:
					goto IL_56;
				default:
				{
					num2 = (short)1550909440;
					short num4 = num2;
					num2 = (short)670236673;
					if (num2 != 0)
					{
					}
					num2 = (short)806748160;
					if (num2 != 0)
					{
					}
					return radioInformation.Labtool.RadInfoLabtoolSecondaryBands_A23988.Value == 5;
				}
				}
				return true;
				IL_2AC:
				return radioInformation.General.RadInfoGeneralPrimaryFrequencyBandUHF1_A42546.Value;
			}
			}
			IL_40:
			radioInformation = (global::AcpCommonLib.FeatureManager.GetFeature(2049)[0] as global::Motorola.MackinawCPS.CoreFeatures.RadioInformation.RadioInformation);
			IL_56:
			num2 = (short)1459552256;
			num = (int)((global::System.IntPtr)num2);
			goto IL_0A;
		}

		// Token: 0x0600D09D RID: 53405 RVA: 0x00C2C958 File Offset: 0x00C2AB58
		public static bool IsUHF2RxFrequency(int inputFrequency)
		{
			global::System.Collections.Generic.IEnumerator<global::AcpBusinessLayer.FeatureNode> enumerator = (((global::Motorola.MackinawCPS.CoreFeatures.RadioWide.RadioWideRecset)global::AcpCommonLib.FeatureManager.GetFeature(2045))[0][10096].EmbeddedRecset as global::Motorola.MackinawCPS.CoreFeatures.RadioWide.RxFrequencySplitFPPInnerRecset).GetEnumerator();
			short num;
			bool result;
			try
			{
				num = (short)465829888;
				int num2 = (int)((global::System.IntPtr)num);
				for (;;)
				{
					switch (num2)
					{
					case 0:
						switch (0)
						{
						case 0:
							goto IL_8C;
						}
						continue;
					case 1:
						num = (short)1319370755;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 2:
						goto IL_24E;
					case 3:
					{
						global::Motorola.MackinawCPS.CoreFeatures.RadioWide.RxFrequencySplitFPPInnerSection rxFrequencySplitFPPInnerSection;
						if (inputFrequency <= rxFrequencySplitFPPInnerSection.RadWideLabtoolRxEndFrequencySplit_A9015.Value)
						{
							num = (short)621412353;
							if (num != 0)
							{
							}
							num = (short)357236747;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						break;
					}
					case 4:
						num = (short)1750532106;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 5:
					{
						if (!enumerator.MoveNext())
						{
							num = (short)688062476;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						global::Motorola.MackinawCPS.CoreFeatures.RadioWide.RxFrequencySplitFPPInnerSection rxFrequencySplitFPPInnerSection = ((global::AcpCommonLib.IAcpFeatureNode)enumerator.Current)[10097] as global::Motorola.MackinawCPS.CoreFeatures.RadioWide.RxFrequencySplitFPPInnerSection;
						num = (short)1137639431;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 6:
					{
						global::Motorola.MackinawCPS.CoreFeatures.RadioWide.RxFrequencySplitFPPInnerSection rxFrequencySplitFPPInnerSection;
						if (inputFrequency >= rxFrequencySplitFPPInnerSection.RadWideLabtoolRxStartFrequencySplit_A9032.Value)
						{
							num = (short)1046806529;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						break;
					}
					case 7:
					{
						global::Motorola.MackinawCPS.CoreFeatures.RadioWide.RxFrequencySplitFPPInnerSection rxFrequencySplitFPPInnerSection;
						if (rxFrequencySplitFPPInnerSection != null)
						{
							num = (short)1807876100;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						break;
					}
					case 8:
						goto IL_A8;
					case 9:
						num = (short)192937990;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 10:
					{
						global::Motorola.MackinawCPS.CoreFeatures.RadioWide.RxFrequencySplitFPPInnerSection rxFrequencySplitFPPInnerSection;
						if (rxFrequencySplitFPPInnerSection.RadWideLabtoolRxBandSplitName_A24797.Value == global::CommonResources.AcgResources.ID_UHF2)
						{
							num = (short)1514340361;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						break;
					}
					case 11:
						result = true;
						num = (short)19398664;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 12:
						num = (short)2017132546;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					IL_166:
					num = (short)376832005;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_8C:
					goto IL_166;
				}
				IL_A8:
				goto IL_30C;
				IL_24E:
				return false;
			}
			finally
			{
				num = (short)185597953;
				int num2 = (int)((global::System.IntPtr)num);
				for (;;)
				{
					num = (short)806263670;
					short num3 = num;
					num = (short)1054907254;
					switch ((num3 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_309;
					default:
						num = (short)940834816;
						if (num != 0)
						{
						}
						switch (num2)
						{
						case 0:
							goto IL_309;
						case 1:
							switch (0)
							{
							case 0:
								goto IL_2CF;
							}
							continue;
						case 2:
							enumerator.Dispose();
							num = (short)106496000;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						IL_2CF:
						if (enumerator == null)
						{
							goto IL_30B;
						}
						num = (short)818806786;
						num2 = (int)((global::System.IntPtr)num);
						break;
					}
				}
				IL_309:
				IL_30B:;
			}
			IL_30C:
			num = (short)372441088;
			short num4 = num;
			return result;
		}

		// Token: 0x0600D09E RID: 53406 RVA: 0x00C2CCB8 File Offset: 0x00C2AEB8
		public static bool IsUHF2TxFrequency(int inputFrequency)
		{
			global::System.Collections.Generic.IEnumerator<global::AcpBusinessLayer.FeatureNode> enumerator = (((global::Motorola.MackinawCPS.CoreFeatures.RadioWide.RadioWideRecset)global::AcpCommonLib.FeatureManager.GetFeature(2045))[0][10094].EmbeddedRecset as global::Motorola.MackinawCPS.CoreFeatures.RadioWide.TxFrequencySplitFPPInnerRecset).GetEnumerator();
			short num;
			bool result;
			try
			{
				num = (short)1324154880;
				int num2 = (int)((global::System.IntPtr)num);
				for (;;)
				{
					switch (num2)
					{
					case 0:
						switch (0)
						{
						case 0:
							goto IL_8C;
						}
						continue;
					case 1:
						num = (short)2143682563;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 2:
						goto IL_222;
					case 3:
					{
						global::Motorola.MackinawCPS.CoreFeatures.RadioWide.TxFrequencySplitFPPInnerSection txFrequencySplitFPPInnerSection;
						if (inputFrequency <= txFrequencySplitFPPInnerSection.RadWideLabtoolTxEndFrequencySplit_A9532.Value)
						{
							num = (short)1611071499;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						break;
					}
					case 4:
						num = (short)739966986;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 5:
					{
						if (!enumerator.MoveNext())
						{
							num = (short)609026060;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						global::Motorola.MackinawCPS.CoreFeatures.RadioWide.TxFrequencySplitFPPInnerSection txFrequencySplitFPPInnerSection = ((global::AcpCommonLib.IAcpFeatureNode)enumerator.Current)[10095] as global::Motorola.MackinawCPS.CoreFeatures.RadioWide.TxFrequencySplitFPPInnerSection;
						num = (short)1604714503;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 6:
					{
						global::Motorola.MackinawCPS.CoreFeatures.RadioWide.TxFrequencySplitFPPInnerSection txFrequencySplitFPPInnerSection;
						if (inputFrequency >= txFrequencySplitFPPInnerSection.RadWideLabtoolTxStartFrequencySplit_A9571.Value)
						{
							num = (short)97386497;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						break;
					}
					case 7:
					{
						global::Motorola.MackinawCPS.CoreFeatures.RadioWide.TxFrequencySplitFPPInnerSection txFrequencySplitFPPInnerSection;
						if (txFrequencySplitFPPInnerSection != null)
						{
							num = (short)626327556;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						break;
					}
					case 8:
						goto IL_A7;
					case 9:
						num = (short)2056454150;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 10:
					{
						global::Motorola.MackinawCPS.CoreFeatures.RadioWide.TxFrequencySplitFPPInnerSection txFrequencySplitFPPInnerSection;
						if (txFrequencySplitFPPInnerSection.RadWideLabtoolTxBandSplitName_A24799.Value == global::CommonResources.AcgResources.ID_UHF2)
						{
							num = (short)1718616073;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						break;
					}
					case 11:
						result = true;
						num = (short)321716232;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 12:
						num = (short)162856962;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					IL_13B:
					num = (short)78118917;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_8C:
					goto IL_13B;
				}
				IL_A7:
				goto IL_30A;
				IL_222:
				return false;
			}
			finally
			{
				num = (short)810745857;
				int num2 = (int)((global::System.IntPtr)num);
				for (;;)
				{
					num = (short)1464511589;
					short num3 = num;
					num = (short)1335209061;
					switch ((num3 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_307;
					default:
						num = (short)1839529985;
						if (num != 0)
						{
						}
						num = (short)1671036928;
						if (num != 0)
						{
						}
						switch (num2)
						{
						case 0:
							goto IL_307;
						case 1:
							switch (0)
							{
							case 0:
								goto IL_2CE;
							}
							continue;
						case 2:
							enumerator.Dispose();
							num = (short)969211904;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						IL_2CE:
						if (enumerator == null)
						{
							goto IL_309;
						}
						num = (short)340656130;
						num2 = (int)((global::System.IntPtr)num);
						break;
					}
				}
				IL_307:
				IL_309:;
			}
			IL_30A:
			num = (short)1150681088;
			short num4 = num;
			return result;
		}

		// Token: 0x0600D09F RID: 53407 RVA: 0x00C2D018 File Offset: 0x00C2B218
		public static bool IsUHF2Supported()
		{
			short num2;
			global::Motorola.MackinawCPS.CoreFeatures.RadioInformation.RadioInformation radioInformation;
			for (;;)
			{
				switch (0)
				{
				case 0:
					goto IL_20;
				}
				int num;
				for (;;)
				{
					IL_0A:
					switch (num)
					{
					case 0:
						if (!global::ConstraintHelper.UtilityMack.IsFreonRadio)
						{
							num2 = (short)1215299586;
							num = (int)((global::System.IntPtr)num2);
							continue;
						}
						goto IL_164;
					case 1:
						goto IL_162;
					case 2:
						num2 = (short)1251803137;
						if (num2 != 0)
						{
						}
						num2 = (short)625278979;
						num = (int)((global::System.IntPtr)num2);
						continue;
					case 3:
						if (radioInformation.Labtool.RadInfoLabtoolPrimaryBands_A23987.Value != 8)
						{
							num2 = (short)31916033;
							num = (int)((global::System.IntPtr)num2);
							continue;
						}
						goto IL_96;
					}
					goto IL_20;
				}
				IL_96:
				num2 = (short)737759932;
				short num3 = num2;
				num2 = (short)1709593276;
				switch ((num3 == num2) ? 1 : 0)
				{
				case 0:
				case 2:
					continue;
				default:
					goto IL_CA;
				}
				IL_20:
				radioInformation = (global::AcpCommonLib.FeatureManager.GetFeature(2049)[0] as global::Motorola.MackinawCPS.CoreFeatures.RadioInformation.RadioInformation);
				num2 = (short)1087635456;
				num = (int)((global::System.IntPtr)num2);
				goto IL_0A;
			}
			IL_CA:
			num2 = (short)338952192;
			if (num2 != 0)
			{
			}
			num2 = (short)807862272;
			short num4 = num2;
			return true;
			IL_162:
			return radioInformation.Labtool.RadInfoLabtoolSecondaryBands_A23988.Value == 8;
			IL_164:
			return radioInformation.General.RadInfoGeneralPrimaryFrequencyBandUHF2_A42547.Value;
		}

		// Token: 0x0600D0A0 RID: 53408 RVA: 0x00C2D19C File Offset: 0x00C2B39C
		public static bool IsNextToUHF2RxFrequency(int inputFrequency, int spacing)
		{
			short num = (short)477757440;
			short num2 = num;
			bool result = false;
			global::System.Collections.Generic.IEnumerator<global::AcpBusinessLayer.FeatureNode> enumerator = (((global::Motorola.MackinawCPS.CoreFeatures.RadioWide.RadioWideRecset)global::AcpCommonLib.FeatureManager.GetFeature(2045))[0][10096].EmbeddedRecset as global::Motorola.MackinawCPS.CoreFeatures.RadioWide.RxFrequencySplitFPPInnerRecset).GetEnumerator();
			try
			{
				num = (short)1808465927;
				int num3 = (int)((global::System.IntPtr)num);
				for (;;)
				{
					switch (num3)
					{
					case 0:
					{
						global::Motorola.MackinawCPS.CoreFeatures.RadioWide.RxFrequencySplitFPPInnerSection rxFrequencySplitFPPInnerSection;
						if (rxFrequencySplitFPPInnerSection.RadWideLabtoolRxEndFrequencySplit_A9015.Value > inputFrequency + 4095 * spacing)
						{
							num = (short)926941185;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_11D;
					}
					case 1:
						goto IL_185;
					case 2:
						goto IL_11D;
					case 3:
						goto IL_393;
					case 4:
						num = (short)203554829;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					case 5:
					{
						global::Motorola.MackinawCPS.CoreFeatures.RadioWide.RxFrequencySplitFPPInnerSection rxFrequencySplitFPPInnerSection;
						if (inputFrequency >= rxFrequencySplitFPPInnerSection.RadWideLabtoolRxStartFrequencySplit_A9032.Value)
						{
							num = (short)2060058633;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						}
						break;
					}
					case 6:
					{
						global::Motorola.MackinawCPS.CoreFeatures.RadioWide.RxFrequencySplitFPPInnerSection rxFrequencySplitFPPInnerSection;
						if (rxFrequencySplitFPPInnerSection.RadWideLabtoolRxStartFrequencySplit_A9032.Value >= inputFrequency)
						{
							num = (short)1421737998;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_205;
					}
					case 7:
						switch (0)
						{
						case 0:
							goto IL_D6;
						}
						continue;
					case 8:
					{
						global::Motorola.MackinawCPS.CoreFeatures.RadioWide.RxFrequencySplitFPPInnerSection rxFrequencySplitFPPInnerSection;
						if (inputFrequency <= rxFrequencySplitFPPInnerSection.RadWideLabtoolRxEndFrequencySplit_A9015.Value)
						{
							num = (short)27328514;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						}
						break;
					}
					case 9:
						num = (short)2075656200;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					case 10:
						num = (short)1192427520;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					case 11:
					{
						global::Motorola.MackinawCPS.CoreFeatures.RadioWide.RxFrequencySplitFPPInnerSection rxFrequencySplitFPPInnerSection;
						if (rxFrequencySplitFPPInnerSection.RadWideLabtoolRxEndFrequencySplit_A9015.Value >= inputFrequency)
						{
							num = (short)136642570;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_185;
					}
					case 12:
					{
						if (!enumerator.MoveNext())
						{
							num = (short)1469644819;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						}
						global::Motorola.MackinawCPS.CoreFeatures.RadioWide.RxFrequencySplitFPPInnerSection rxFrequencySplitFPPInnerSection = ((global::AcpCommonLib.IAcpFeatureNode)enumerator.Current)[10097] as global::Motorola.MackinawCPS.CoreFeatures.RadioWide.RxFrequencySplitFPPInnerSection;
						num = (short)1294008340;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 13:
					{
						global::Motorola.MackinawCPS.CoreFeatures.RadioWide.RxFrequencySplitFPPInnerSection rxFrequencySplitFPPInnerSection;
						if (rxFrequencySplitFPPInnerSection.RadWideLabtoolRxBandSplitName_A24797.Value == global::CommonResources.AcgResources.ID_UHF2)
						{
							num = (short)590741519;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						}
						break;
					}
					case 14:
						num = (short)392036370;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					case 15:
						num = (short)1927741446;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					case 17:
						goto IL_205;
					case 18:
					{
						global::Motorola.MackinawCPS.CoreFeatures.RadioWide.RxFrequencySplitFPPInnerSection rxFrequencySplitFPPInnerSection;
						if (rxFrequencySplitFPPInnerSection.RadWideLabtoolRxStartFrequencySplit_A9032.Value > inputFrequency + 4095 * spacing)
						{
							num = (short)308281361;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_11D;
					}
					case 19:
						num = (short)62980099;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					case 20:
					{
						global::Motorola.MackinawCPS.CoreFeatures.RadioWide.RxFrequencySplitFPPInnerSection rxFrequencySplitFPPInnerSection;
						if (rxFrequencySplitFPPInnerSection != null)
						{
							num = (short)2035810308;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						}
						break;
					}
					}
					goto IL_D6;
					IL_11D:
					result = true;
					num = (short)2143879184;
					num3 = (int)((global::System.IntPtr)num);
					continue;
					IL_185:
					num = (short)1228472325;
					num3 = (int)((global::System.IntPtr)num);
					continue;
					IL_1C7:
					num = (short)1589510156;
					num3 = (int)((global::System.IntPtr)num);
					continue;
					IL_D6:
					goto IL_1C7;
					IL_205:
					num = (short)1482227723;
					num3 = (int)((global::System.IntPtr)num);
				}
				IL_393:;
			}
			finally
			{
				num = (short)1259470849;
				int num3 = (int)((global::System.IntPtr)num);
				for (;;)
				{
					num = (short)1125823545;
					short num4 = num;
					num = (short)1359000633;
					switch ((num4 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_46F;
					default:
						num = (short)1297809408;
						if (num != 0)
						{
						}
						switch (num3)
						{
						case 0:
							goto IL_46F;
						case 1:
							switch (0)
							{
							case 0:
								goto IL_411;
							}
							continue;
						case 2:
							num = (short)1025703937;
							if (num != 0)
							{
							}
							enumerator.Dispose();
							num = (short)772145152;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						}
						IL_411:
						if (enumerator == null)
						{
							goto IL_471;
						}
						num = (short)984023042;
						num3 = (int)((global::System.IntPtr)num);
						break;
					}
				}
				IL_46F:
				IL_471:;
			}
			return result;
		}

		// Token: 0x0600D0A1 RID: 53409 RVA: 0x00C2D638 File Offset: 0x00C2B838
		public static bool IsNextToUHF2RxFrequencyWithoutUHF1(int inputFrequency, int spacing)
		{
			short num = (short)281673728;
			switch (num)
			{
			default:
			{
				num = (short)1714814976;
				short num2 = num;
				bool result = false;
				int num3 = 94000000;
				global::Motorola.MackinawCPS.CoreFeatures.RadioWide.RxFrequencySplitFPPInnerRecset rxFrequencySplitFPPInnerRecset = ((global::Motorola.MackinawCPS.CoreFeatures.RadioWide.RadioWideRecset)global::AcpCommonLib.FeatureManager.GetFeature(2045))[0][10096].EmbeddedRecset as global::Motorola.MackinawCPS.CoreFeatures.RadioWide.RxFrequencySplitFPPInnerRecset;
				global::System.Collections.Generic.IEnumerator<global::AcpBusinessLayer.FeatureNode> enumerator = rxFrequencySplitFPPInnerRecset.GetEnumerator();
				try
				{
					num = (short)2057437185;
					int num4 = (int)((global::System.IntPtr)num);
					for (;;)
					{
						switch (num4)
						{
						case 0:
							num = (short)1057751048;
							num4 = (int)((global::System.IntPtr)num);
							continue;
						case 1:
							switch (0)
							{
							case 0:
								goto IL_4C3;
							}
							continue;
						case 2:
						{
							if (!enumerator.MoveNext())
							{
								num = (short)305070080;
								num4 = (int)((global::System.IntPtr)num);
								continue;
							}
							global::Motorola.MackinawCPS.CoreFeatures.RadioWide.RxFrequencySplitFPPInnerSection rxFrequencySplitFPPInnerSection = ((global::AcpCommonLib.IAcpFeatureNode)enumerator.Current)[10097] as global::Motorola.MackinawCPS.CoreFeatures.RadioWide.RxFrequencySplitFPPInnerSection;
							num = (short)1932066823;
							num4 = (int)((global::System.IntPtr)num);
							continue;
						}
						case 3:
						{
							global::Motorola.MackinawCPS.CoreFeatures.RadioWide.RxFrequencySplitFPPInnerSection rxFrequencySplitFPPInnerSection;
							if (rxFrequencySplitFPPInnerSection.RadWideLabtoolRxBandSplitName_A24797.Value == global::CommonResources.AcgResources.ID_UHF1)
							{
								num = (short)2044461062;
								num4 = (int)((global::System.IntPtr)num);
								continue;
							}
							break;
						}
						case 4:
							num = (short)61865987;
							num4 = (int)((global::System.IntPtr)num);
							continue;
						case 6:
						{
							global::Motorola.MackinawCPS.CoreFeatures.RadioWide.RxFrequencySplitFPPInnerSection rxFrequencySplitFPPInnerSection;
							num3 = rxFrequencySplitFPPInnerSection.RadWideLabtoolRxEndFrequencySplit_A9015.Value;
							num = (short)1511063557;
							num4 = (int)((global::System.IntPtr)num);
							continue;
						}
						case 7:
						{
							global::Motorola.MackinawCPS.CoreFeatures.RadioWide.RxFrequencySplitFPPInnerSection rxFrequencySplitFPPInnerSection;
							if (rxFrequencySplitFPPInnerSection != null)
							{
								num = (short)755826692;
								num4 = (int)((global::System.IntPtr)num);
								continue;
							}
							break;
						}
						case 8:
							goto IL_5DA;
						}
						IL_50D:
						num = (short)606863362;
						num4 = (int)((global::System.IntPtr)num);
						continue;
						IL_4C3:
						goto IL_50D;
					}
					IL_5DA:
					goto IL_46C;
				}
				finally
				{
					num = (short)1130102785;
					int num4 = (int)((global::System.IntPtr)num);
					for (;;)
					{
						switch (num4)
						{
						case 0:
							enumerator.Dispose();
							num = (short)1864433666;
							num4 = (int)((global::System.IntPtr)num);
							continue;
						case 1:
							switch (0)
							{
							case 0:
								goto IL_611;
							}
							continue;
						case 2:
							goto IL_649;
						}
						IL_611:
						if (enumerator == null)
						{
							goto IL_673;
						}
						num = (short)1782448128;
						num4 = (int)((global::System.IntPtr)num);
					}
					IL_649:
					num = (short)546242561;
					if (num != 0)
					{
					}
					IL_673:;
				}
				return result;
				for (;;)
				{
					IL_46C:
					enumerator = rxFrequencySplitFPPInnerRecset.GetEnumerator();
					try
					{
						num = (short)658964482;
						int num4 = (int)((global::System.IntPtr)num);
						for (;;)
						{
							switch (num4)
							{
							case 0:
							{
								global::Motorola.MackinawCPS.CoreFeatures.RadioWide.RxFrequencySplitFPPInnerSection rxFrequencySplitFPPInnerSection2;
								if (rxFrequencySplitFPPInnerSection2 != null)
								{
									num = (short)1762918414;
									num4 = (int)((global::System.IntPtr)num);
									continue;
								}
								break;
							}
							case 1:
								goto IL_179;
							case 2:
								switch (0)
								{
								case 0:
									goto IL_FE;
								}
								continue;
							case 3:
								num = (short)2140012561;
								num4 = (int)((global::System.IntPtr)num);
								continue;
							case 4:
							{
								global::Motorola.MackinawCPS.CoreFeatures.RadioWide.RxFrequencySplitFPPInnerSection rxFrequencySplitFPPInnerSection2;
								if (inputFrequency <= rxFrequencySplitFPPInnerSection2.RadWideLabtoolRxEndFrequencySplit_A9015.Value)
								{
									num = (short)561971208;
									num4 = (int)((global::System.IntPtr)num);
									continue;
								}
								break;
							}
							case 5:
								if (inputFrequency >= num3)
								{
									num = (short)711524370;
									num4 = (int)((global::System.IntPtr)num);
									continue;
								}
								break;
							case 6:
							{
								global::Motorola.MackinawCPS.CoreFeatures.RadioWide.RxFrequencySplitFPPInnerSection rxFrequencySplitFPPInnerSection2;
								if (rxFrequencySplitFPPInnerSection2.RadWideLabtoolRxBandSplitName_A24797.Value == global::CommonResources.AcgResources.ID_UHF2)
								{
									num = (short)894500876;
									num4 = (int)((global::System.IntPtr)num);
									continue;
								}
								break;
							}
							case 7:
								goto IL_3AC;
							case 8:
								goto IL_20D;
							case 9:
							{
								global::Motorola.MackinawCPS.CoreFeatures.RadioWide.RxFrequencySplitFPPInnerSection rxFrequencySplitFPPInnerSection2;
								if (rxFrequencySplitFPPInnerSection2.RadWideLabtoolRxEndFrequencySplit_A9015.Value >= inputFrequency + 4095 * spacing)
								{
									num = (short)1532952596;
									num4 = (int)((global::System.IntPtr)num);
									continue;
								}
								goto IL_20D;
							}
							case 10:
								if (num3 >= inputFrequency)
								{
									num = (short)1476263939;
									num4 = (int)((global::System.IntPtr)num);
									continue;
								}
								goto IL_179;
							case 12:
								num = (short)933888010;
								num4 = (int)((global::System.IntPtr)num);
								continue;
							case 13:
								num = (short)734330887;
								num4 = (int)((global::System.IntPtr)num);
								continue;
							case 14:
								num = (short)281739270;
								num4 = (int)((global::System.IntPtr)num);
								continue;
							case 15:
							{
								global::Motorola.MackinawCPS.CoreFeatures.RadioWide.RxFrequencySplitFPPInnerSection rxFrequencySplitFPPInnerSection2;
								if (rxFrequencySplitFPPInnerSection2.RadWideLabtoolRxEndFrequencySplit_A9015.Value > inputFrequency)
								{
									num = (short)1890385936;
									num4 = (int)((global::System.IntPtr)num);
									continue;
								}
								goto IL_100;
							}
							case 16:
								num = (short)178651145;
								num4 = (int)((global::System.IntPtr)num);
								continue;
							case 17:
								if (num3 >= inputFrequency + 4095 * spacing)
								{
									num = (short)1277165569;
									num4 = (int)((global::System.IntPtr)num);
									continue;
								}
								goto IL_20D;
							case 18:
								num = (short)1731002372;
								num4 = (int)((global::System.IntPtr)num);
								continue;
							case 19:
							{
								if (!enumerator.MoveNext())
								{
									num = (short)1141899277;
									num4 = (int)((global::System.IntPtr)num);
									continue;
								}
								global::Motorola.MackinawCPS.CoreFeatures.RadioWide.RxFrequencySplitFPPInnerSection rxFrequencySplitFPPInnerSection2 = ((global::AcpCommonLib.IAcpFeatureNode)enumerator.Current)[10097] as global::Motorola.MackinawCPS.CoreFeatures.RadioWide.RxFrequencySplitFPPInnerSection;
								num = (short)296288256;
								num4 = (int)((global::System.IntPtr)num);
								continue;
							}
							case 20:
								goto IL_100;
							}
							goto IL_FE;
							IL_100:
							num = (short)630325253;
							num4 = (int)((global::System.IntPtr)num);
							continue;
							IL_138:
							num = (short)268173331;
							num4 = (int)((global::System.IntPtr)num);
							continue;
							IL_FE:
							goto IL_138;
							IL_179:
							num = (short)1647837199;
							num4 = (int)((global::System.IntPtr)num);
							continue;
							IL_20D:
							result = true;
							num = (short)933888011;
							num4 = (int)((global::System.IntPtr)num);
						}
						IL_3AC:
						break;
					}
					finally
					{
						num = (short)1508114433;
						int num4 = (int)((global::System.IntPtr)num);
						for (;;)
						{
							switch (num4)
							{
							case 0:
							{
								num = (short)979181534;
								short num5 = num;
								num = (short)642916318;
								switch ((num5 == num) ? 1 : 0)
								{
								case 0:
								case 2:
									break;
								default:
									num = (short)1366294528;
									if (num != 0)
									{
									}
									enumerator.Dispose();
									num = (short)656670722;
									num4 = (int)((global::System.IntPtr)num);
									continue;
								}
								break;
							}
							case 1:
								switch (0)
								{
								case 0:
									goto IL_3E3;
								}
								continue;
							case 2:
								goto IL_469;
							}
							IL_3E3:
							if (enumerator == null)
							{
								break;
							}
							num = (short)720306176;
							num4 = (int)((global::System.IntPtr)num);
						}
						IL_469:;
					}
				}
				return result;
			}
			}
		}

		// Token: 0x0600D0A2 RID: 53410 RVA: 0x00C2DCF0 File Offset: 0x00C2BEF0
		public static bool Is700MHzRxFrequency(int inputFrequency)
		{
			global::System.Collections.Generic.IEnumerator<global::AcpBusinessLayer.FeatureNode> enumerator = (((global::Motorola.MackinawCPS.CoreFeatures.RadioWide.RadioWideRecset)global::AcpCommonLib.FeatureManager.GetFeature(2045))[0][10096].EmbeddedRecset as global::Motorola.MackinawCPS.CoreFeatures.RadioWide.RxFrequencySplitFPPInnerRecset).GetEnumerator();
			short num;
			bool result;
			try
			{
				num = (short)1553858565;
				int num2 = (int)((global::System.IntPtr)num);
				for (;;)
				{
					global::Motorola.MackinawCPS.CoreFeatures.RadioWide.RxFrequencySplitFPPInnerSection rxFrequencySplitFPPInnerSection;
					switch (num2)
					{
					case 0:
						if (rxFrequencySplitFPPInnerSection != null)
						{
							num = (short)1346306065;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_416;
					case 1:
						num = (short)1943601172;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 2:
						if (inputFrequency < rxFrequencySplitFPPInnerSection.RadWideLabtoolRxEndFrequencySplit_A9015.Value)
						{
							num = (short)664469516;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						break;
					case 3:
						num = (short)1798832130;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 4:
						result = true;
						num = (short)996737031;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 5:
						switch (0)
						{
						case 0:
							goto IL_E0;
						}
						continue;
					case 6:
						if (!enumerator.MoveNext())
						{
							num = (short)253624339;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						rxFrequencySplitFPPInnerSection = (((global::AcpCommonLib.IAcpFeatureNode)enumerator.Current)[10097] as global::Motorola.MackinawCPS.CoreFeatures.RadioWide.RxFrequencySplitFPPInnerSection);
						num = (short)383254528;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 7:
						goto IL_291;
					case 8:
						goto IL_2F9;
					case 9:
						if (inputFrequency >= rxFrequencySplitFPPInnerSection.RadWideLabtoolRxStartFrequencySplit_A9032.Value)
						{
							num = (short)195297283;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						break;
					case 10:
						num = (short)534839311;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 11:
						goto IL_42D;
					case 12:
						result = true;
						num = (short)108920840;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 13:
						if (inputFrequency > rxFrequencySplitFPPInnerSection.RadWideLabtoolRxStartFrequencySplit_A9032.Value)
						{
							num = (short)635109377;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_416;
					case 14:
						goto IL_345;
					case 15:
						if (rxFrequencySplitFPPInnerSection.RadWideLabtoolRxBandSplitName_A24797.Value == global::CommonResources.AcgResources.ID_P_700M_1)
						{
							num = (short)1201537038;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_416;
					case 16:
						if (rxFrequencySplitFPPInnerSection.RadWideLabtoolRxBandSplitName_A24797.Value == global::CommonResources.AcgResources.ID_P_700M_2)
						{
							num = (short)968425490;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						break;
					case 17:
						num = (short)1248067606;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 18:
						num = (short)535429129;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 19:
						num = (short)845217813;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 20:
						if (inputFrequency < rxFrequencySplitFPPInnerSection.RadWideLabtoolRxEndFrequencySplit_A9015.Value)
						{
							num = (short)1796407300;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_416;
					case 21:
						goto IL_469;
					case 22:
						if (!(rxFrequencySplitFPPInnerSection.RadWideLabtoolRxBandSplitName_A24797.Value == global::CommonResources.AcgResources.ID_P_700M))
						{
							num = (short)19267585;
							if (num != 0)
							{
							}
							num = (short)204472330;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_345;
					case 23:
					{
						num = (short)304469726;
						short num3 = num;
						num = (short)2095634142;
						switch ((num3 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_42D;
						default:
							num = (short)1052180480;
							if (num != 0)
							{
							}
							num = (short)85131280;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						break;
					}
					}
					IL_239:
					num = (short)215482374;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_42D:
					if (rxFrequencySplitFPPInnerSection != null)
					{
						num = (short)404160535;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					IL_E0:
					goto IL_239;
					IL_345:
					num = (short)360775693;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_416:
					num = (short)1936392203;
					num2 = (int)((global::System.IntPtr)num);
				}
				IL_291:
				IL_2F9:
				return result;
				IL_469:
				goto IL_31;
			}
			finally
			{
				num = (short)1576140801;
				int num2 = (int)((global::System.IntPtr)num);
				for (;;)
				{
					switch (num2)
					{
					case 0:
						enumerator.Dispose();
						num = (short)63897602;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 1:
						switch (0)
						{
						case 0:
							goto IL_49E;
						}
						continue;
					case 2:
						goto IL_4D1;
					}
					IL_49E:
					if (enumerator == null)
					{
						break;
					}
					num = (short)2068971520;
					num2 = (int)((global::System.IntPtr)num);
				}
				IL_4D1:;
			}
			return result;
			IL_31:
			num = (short)722272256;
			short num4 = num;
			return false;
		}

		// Token: 0x0600D0A3 RID: 53411 RVA: 0x00C2E1F0 File Offset: 0x00C2C3F0
		public static bool Is700MHzTxFrequency(int inputFrequency)
		{
			short num = (short)1223688193;
			if (num != 0)
			{
			}
			num = (short)1811480576;
			short num2 = num;
			global::System.Collections.Generic.IEnumerator<global::AcpBusinessLayer.FeatureNode> enumerator = (((global::Motorola.MackinawCPS.CoreFeatures.RadioWide.RadioWideRecset)global::AcpCommonLib.FeatureManager.GetFeature(2045))[0][10094].EmbeddedRecset as global::Motorola.MackinawCPS.CoreFeatures.RadioWide.TxFrequencySplitFPPInnerRecset).GetEnumerator();
			bool result;
			try
			{
				num = (short)1758330883;
				int num3 = (int)((global::System.IntPtr)num);
				for (;;)
				{
					global::Motorola.MackinawCPS.CoreFeatures.RadioWide.TxFrequencySplitFPPInnerSection txFrequencySplitFPPInnerSection;
					switch (num3)
					{
					case 0:
						if (inputFrequency > txFrequencySplitFPPInnerSection.RadWideLabtoolTxStartFrequencySplit_A9571.Value)
						{
							num = (short)882901006;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						}
						break;
					case 1:
						num = (short)1117650951;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					case 2:
						result = true;
						num = (short)338886668;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					case 3:
						switch (0)
						{
						case 0:
							goto IL_E4;
						}
						continue;
					case 4:
						if (txFrequencySplitFPPInnerSection.RadWideLabtoolTxBandSplitName_A24799.Value == global::CommonResources.AcgResources.ID_P_700M_2)
						{
							num = (short)1966080008;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						}
						break;
					case 5:
						if (!enumerator.MoveNext())
						{
							num = (short)1189740545;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						}
						txFrequencySplitFPPInnerSection = (((global::AcpCommonLib.IAcpFeatureNode)enumerator.Current)[10095] as global::Motorola.MackinawCPS.CoreFeatures.RadioWide.TxFrequencySplitFPPInnerSection);
						num = (short)803471373;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					case 6:
					{
						num = (short)880672956;
						short num4 = num;
						num = (short)2086469820;
						switch ((num4 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_16B;
						default:
							num = (short)1561395200;
							if (num != 0)
							{
							}
							if (!(txFrequencySplitFPPInnerSection.RadWideLabtoolTxBandSplitName_A24799.Value == global::CommonResources.AcgResources.ID_P_700M_1))
							{
								num = (short)1243086859;
								num3 = (int)((global::System.IntPtr)num);
								continue;
							}
							goto IL_2B5;
						}
						break;
					}
					case 7:
						goto IL_312;
					case 8:
						goto IL_2B5;
					case 9:
						num = (short)1360461830;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					case 10:
						goto IL_16B;
					case 11:
						num = (short)1350107140;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					case 12:
						goto IL_100;
					case 13:
						if (txFrequencySplitFPPInnerSection != null)
						{
							num = (short)957808649;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						}
						break;
					case 14:
						num = (short)1751056394;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_E4;
					IL_16B:
					if (inputFrequency < txFrequencySplitFPPInnerSection.RadWideLabtoolTxEndFrequencySplit_A9532.Value)
					{
						num = (short)1380122626;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					}
					IL_196:
					num = (short)916848645;
					num3 = (int)((global::System.IntPtr)num);
					continue;
					IL_E4:
					goto IL_196;
					IL_2B5:
					num = (short)284557312;
					num3 = (int)((global::System.IntPtr)num);
				}
				IL_100:
				return result;
				IL_312:
				return false;
			}
			finally
			{
				num = (short)66912257;
				int num3 = (int)((global::System.IntPtr)num);
				for (;;)
				{
					switch (num3)
					{
					case 0:
						enumerator.Dispose();
						num = (short)1924595714;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					case 1:
						switch (0)
						{
						case 0:
							goto IL_347;
						}
						continue;
					case 2:
						goto IL_37C;
					}
					IL_347:
					if (enumerator == null)
					{
						break;
					}
					num = (short)828768256;
					num3 = (int)((global::System.IntPtr)num);
				}
				IL_37C:;
			}
			return result;
		}

		// Token: 0x0600D0A4 RID: 53412 RVA: 0x00C2E59C File Offset: 0x00C2C79C
		public static bool IsNextTo700MHzRxFrequency(int inputFrequency, int spacing)
		{
			short num = (short)1903755265;
			if (num != 0)
			{
			}
			num = (short)705953792;
			short num2 = num;
			bool result = false;
			global::System.Collections.Generic.IEnumerator<global::AcpBusinessLayer.FeatureNode> enumerator = (((global::Motorola.MackinawCPS.CoreFeatures.RadioWide.RadioWideRecset)global::AcpCommonLib.FeatureManager.GetFeature(2045))[0][10096].EmbeddedRecset as global::Motorola.MackinawCPS.CoreFeatures.RadioWide.RxFrequencySplitFPPInnerRecset).GetEnumerator();
			try
			{
				num = (short)663945220;
				int num3 = (int)((global::System.IntPtr)num);
				for (;;)
				{
					global::Motorola.MackinawCPS.CoreFeatures.RadioWide.RxFrequencySplitFPPInnerSection rxFrequencySplitFPPInnerSection;
					switch (num3)
					{
					case 0:
						goto IL_19F;
					case 1:
						if (rxFrequencySplitFPPInnerSection.RadWideLabtoolRxEndFrequencySplit_A9015.Value >= inputFrequency + 4095 * spacing)
						{
							num = (short)1404043279;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_19F;
					case 2:
						num = (short)1744896009;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					case 3:
					{
						num = (short)416693612;
						short num4 = num;
						num = (short)1722367340;
						switch ((num4 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_3D2;
						default:
							num = (short)2117730304;
							if (num != 0)
							{
							}
							if (rxFrequencySplitFPPInnerSection.RadWideLabtoolRxBandSplitName_A24797.Value == global::CommonResources.AcgResources.ID_P_700M_1)
							{
								num = (short)41877515;
								num3 = (int)((global::System.IntPtr)num);
								continue;
							}
							break;
						}
						break;
					}
					case 4:
						switch (0)
						{
						case 0:
							goto IL_103;
						}
						continue;
					case 5:
						num = (short)1031340042;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					case 6:
						if (!enumerator.MoveNext())
						{
							num = (short)1384579086;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						}
						rxFrequencySplitFPPInnerSection = (((global::AcpCommonLib.IAcpFeatureNode)enumerator.Current)[10097] as global::Motorola.MackinawCPS.CoreFeatures.RadioWide.RxFrequencySplitFPPInnerSection);
						num = (short)37683219;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					case 7:
						num = (short)1571815425;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					case 8:
						if (rxFrequencySplitFPPInnerSection.RadWideLabtoolRxStartFrequencySplit_A9032.Value > inputFrequency)
						{
							num = (short)182779909;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_28C;
					case 9:
						if (!(rxFrequencySplitFPPInnerSection.RadWideLabtoolRxBandSplitName_A24797.Value == global::CommonResources.AcgResources.ID_P_700M))
						{
							num = (short)655753233;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_2D0;
					case 10:
						if (rxFrequencySplitFPPInnerSection.RadWideLabtoolRxStartFrequencySplit_A9032.Value >= inputFrequency + 4095 * spacing)
						{
							num = (short)1095761942;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_19F;
					case 11:
						goto IL_2D0;
					case 12:
						if (inputFrequency < rxFrequencySplitFPPInnerSection.RadWideLabtoolRxEndFrequencySplit_A9015.Value)
						{
							num = (short)388104192;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						}
						break;
					case 13:
						if (rxFrequencySplitFPPInnerSection.RadWideLabtoolRxEndFrequencySplit_A9015.Value > inputFrequency)
						{
							num = (short)287375367;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_20B;
					case 14:
						num = (short)1405485076;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					case 15:
						goto IL_20B;
					case 16:
						if (inputFrequency > rxFrequencySplitFPPInnerSection.RadWideLabtoolRxStartFrequencySplit_A9032.Value)
						{
							num = (short)1110638610;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						}
						break;
					case 17:
						num = (short)1131741187;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					case 18:
						num = (short)985399308;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					case 19:
						goto IL_3D2;
					case 20:
						goto IL_458;
					case 22:
						goto IL_28C;
					}
					goto IL_103;
					IL_19F:
					result = true;
					num = (short)2002976789;
					num3 = (int)((global::System.IntPtr)num);
					continue;
					IL_20B:
					num = (short)781516816;
					num3 = (int)((global::System.IntPtr)num);
					continue;
					IL_24D:
					num = (short)1248526342;
					num3 = (int)((global::System.IntPtr)num);
					continue;
					IL_3D2:
					if (rxFrequencySplitFPPInnerSection != null)
					{
						num = (short)1403322370;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					}
					IL_103:
					goto IL_24D;
					IL_28C:
					num = (short)1217921037;
					num3 = (int)((global::System.IntPtr)num);
					continue;
					IL_2D0:
					num = (short)1139081224;
					num3 = (int)((global::System.IntPtr)num);
				}
				IL_458:;
			}
			finally
			{
				num = (short)775028737;
				int num3 = (int)((global::System.IntPtr)num);
				for (;;)
				{
					switch (num3)
					{
					case 0:
						enumerator.Dispose();
						num = (short)1879113730;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					case 1:
						switch (0)
						{
						case 0:
							goto IL_48A;
						}
						continue;
					case 2:
						goto IL_4BF;
					}
					IL_48A:
					if (enumerator == null)
					{
						break;
					}
					num = (short)562888704;
					num3 = (int)((global::System.IntPtr)num);
				}
				IL_4BF:;
			}
			return result;
		}

		// Token: 0x0600D0A5 RID: 53413 RVA: 0x00C2EA88 File Offset: 0x00C2CC88
		public static bool Is7800MHzSupported()
		{
			switch (0)
			{
			case 0:
				goto IL_30;
			}
			int num;
			global::Motorola.MackinawCPS.CoreFeatures.RadioInformation.RadioInformation radioInformation;
			short num2;
			for (;;)
			{
				IL_0A:
				switch (num)
				{
				case 0:
					goto IL_113;
				case 1:
					if (radioInformation.Labtool.RadInfoLabtoolDualBandEnable_A23986.Value)
					{
						num2 = (short)1956380672;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					return false;
				case 2:
				{
					num2 = (short)1774484278;
					short num3 = num2;
					num2 = (short)111311670;
					switch ((num3 == num2) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_157;
					default:
						num2 = (short)889782272;
						if (num2 != 0)
						{
						}
						num2 = (short)1482358785;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					break;
				}
				case 3:
					if (!radioInformation.General.RadInfoGeneralPrimaryFrequencyBand700_A42543.Value)
					{
						num2 = (short)1119944711;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					return true;
				case 4:
					if (radioInformation.Labtool.RadInfoLabtoolPrimaryBands_A23987.Value != 1)
					{
						goto IL_157;
					}
					return true;
				case 5:
					if (!global::ConstraintHelper.UtilityMack.IsFreonRadio)
					{
						num2 = (short)1872429056;
						short num4 = num2;
						num2 = (short)586940422;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					num2 = (short)627376131;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 6:
					num2 = (short)887160833;
					if (num2 != 0)
					{
					}
					num2 = (short)804519940;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 7:
					goto IL_203;
				}
				goto IL_30;
				IL_157:
				num2 = (short)762707970;
				num = (int)((global::System.IntPtr)num2);
			}
			return true;
			IL_113:
			return radioInformation.Labtool.RadInfoLabtoolSecondaryBands_A23988.Value == 1;
			IL_203:
			return radioInformation.General.RadInfoGeneralPrimaryFrequencyBand800_A42544.Value;
			IL_30:
			radioInformation = (global::AcpCommonLib.FeatureManager.GetFeature(2049)[0] as global::Motorola.MackinawCPS.CoreFeatures.RadioInformation.RadioInformation);
			num2 = (short)1842151429;
			num = (int)((global::System.IntPtr)num2);
			goto IL_0A;
		}

		// Token: 0x0600D0A6 RID: 53414 RVA: 0x00C2ECB4 File Offset: 0x00C2CEB4
		public static bool Is800MHzRxFrequency(int inputFrequency)
		{
			global::System.Collections.Generic.IEnumerator<global::AcpBusinessLayer.FeatureNode> enumerator = (((global::Motorola.MackinawCPS.CoreFeatures.RadioWide.RadioWideRecset)global::AcpCommonLib.FeatureManager.GetFeature(2045))[0][10096].EmbeddedRecset as global::Motorola.MackinawCPS.CoreFeatures.RadioWide.RxFrequencySplitFPPInnerRecset).GetEnumerator();
			short num;
			bool result;
			try
			{
				num = (short)1517551617;
				int num2 = (int)((global::System.IntPtr)num);
				for (;;)
				{
					global::Motorola.MackinawCPS.CoreFeatures.RadioWide.RxFrequencySplitFPPInnerSection rxFrequencySplitFPPInnerSection;
					switch (num2)
					{
					case 0:
						result = true;
						num = (short)1050542091;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 1:
						switch (0)
						{
						case 0:
							goto IL_DC;
						}
						continue;
					case 2:
						if (!enumerator.MoveNext())
						{
							num = (short)1867055110;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						rxFrequencySplitFPPInnerSection = (((global::AcpCommonLib.IAcpFeatureNode)enumerator.Current)[10097] as global::Motorola.MackinawCPS.CoreFeatures.RadioWide.RxFrequencySplitFPPInnerSection);
						num = (short)1918763015;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 3:
						if (inputFrequency < rxFrequencySplitFPPInnerSection.RadWideLabtoolRxEndFrequencySplit_A9015.Value)
						{
							num = (short)1941176320;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						break;
					case 4:
						if (inputFrequency >= rxFrequencySplitFPPInnerSection.RadWideLabtoolRxStartFrequencySplit_A9032.Value)
						{
							num = (short)1510539273;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						break;
					case 5:
						goto IL_273;
					case 6:
						num = (short)592838668;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 7:
						if (rxFrequencySplitFPPInnerSection != null)
						{
							num = (short)322699272;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						break;
					case 8:
						num = (short)1476132869;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 9:
						num = (short)64028675;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 10:
					{
						num = (short)1720538730;
						short num3 = num;
						num = (short)1621382762;
						switch ((num3 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_273;
						default:
							num = (short)1851719680;
							if (num != 0)
							{
							}
							num = (short)1471807492;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						break;
					}
					case 11:
						goto IL_F7;
					case 12:
						goto IL_2C1;
					}
					IL_18E:
					num = (short)1301741570;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_273:
					if (rxFrequencySplitFPPInnerSection.RadWideLabtoolRxBandSplitName_A24797.Value == global::CommonResources.AcgResources.ID_P_800M)
					{
						num = (short)1669791754;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					IL_DC:
					goto IL_18E;
				}
				IL_F7:
				return result;
				IL_2C1:
				goto IL_31;
			}
			finally
			{
				num = (short)1178075137;
				int num2 = (int)((global::System.IntPtr)num);
				for (;;)
				{
					switch (num2)
					{
					case 0:
						enumerator.Dispose();
						num = (short)609812482;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 1:
						switch (0)
						{
						case 0:
							goto IL_2F6;
						}
						continue;
					case 2:
						goto IL_329;
					}
					IL_2F6:
					if (enumerator == null)
					{
						break;
					}
					num = (short)226099200;
					num2 = (int)((global::System.IntPtr)num);
				}
				IL_329:;
			}
			return result;
			IL_31:
			num = (short)2094137344;
			short num4 = num;
			num = (short)1743388673;
			if (num != 0)
			{
			}
			return false;
		}

		// Token: 0x0600D0A7 RID: 53415 RVA: 0x00C2F00C File Offset: 0x00C2D20C
		public static bool Is800MHzTxFrequency(int inputFrequency)
		{
			global::System.Collections.Generic.IEnumerator<global::AcpBusinessLayer.FeatureNode> enumerator = (((global::Motorola.MackinawCPS.CoreFeatures.RadioWide.RadioWideRecset)global::AcpCommonLib.FeatureManager.GetFeature(2045))[0][10094].EmbeddedRecset as global::Motorola.MackinawCPS.CoreFeatures.RadioWide.TxFrequencySplitFPPInnerRecset).GetEnumerator();
			short num;
			bool result;
			try
			{
				num = (short)1012203523;
				int num2 = (int)((global::System.IntPtr)num);
				for (;;)
				{
					global::Motorola.MackinawCPS.CoreFeatures.RadioWide.TxFrequencySplitFPPInnerSection txFrequencySplitFPPInnerSection;
					switch (num2)
					{
					case 0:
						if (inputFrequency >= txFrequencySplitFPPInnerSection.RadWideLabtoolTxStartFrequencySplit_A9571.Value)
						{
							num = (short)422313998;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						break;
					case 1:
						num = (short)1830092807;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 2:
						result = true;
						num = (short)1108672524;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 3:
						switch (0)
						{
						case 0:
							goto IL_BE;
						}
						continue;
					case 4:
						if (txFrequencySplitFPPInnerSection.RadWideLabtoolTxBandSplitName_A24799.Value == global::CommonResources.AcgResources.ID_P_800M_2)
						{
							num = (short)1529151496;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						break;
					case 5:
						if (!enumerator.MoveNext())
						{
							num = (short)141361153;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						txFrequencySplitFPPInnerSection = (((global::AcpCommonLib.IAcpFeatureNode)enumerator.Current)[10095] as global::Motorola.MackinawCPS.CoreFeatures.RadioWide.TxFrequencySplitFPPInnerSection);
						num = (short)618659853;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 6:
					{
						num = (short)383952386;
						short num3 = num;
						num = (short)1758242306;
						switch ((num3 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_146;
						default:
							num = (short)1236664321;
							if (num != 0)
							{
							}
							num = (short)2055864320;
							if (num != 0)
							{
							}
							if (!(txFrequencySplitFPPInnerSection.RadWideLabtoolTxBandSplitName_A24799.Value == global::CommonResources.AcgResources.ID_P_800M_1))
							{
								num = (short)1527906315;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							goto IL_2B4;
						}
						break;
					}
					case 7:
						goto IL_311;
					case 8:
						goto IL_2B4;
					case 9:
						num = (short)736034822;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 10:
						goto IL_146;
					case 11:
						num = (short)622723076;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 12:
						goto IL_DB;
					case 13:
						if (txFrequencySplitFPPInnerSection != null)
						{
							num = (short)786694153;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						break;
					case 14:
						num = (short)1224409098;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_BE;
					IL_146:
					if (inputFrequency < txFrequencySplitFPPInnerSection.RadWideLabtoolTxEndFrequencySplit_A9532.Value)
					{
						num = (short)98435074;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					IL_170:
					num = (short)1660289029;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_BE:
					goto IL_170;
					IL_2B4:
					num = (short)660209664;
					num2 = (int)((global::System.IntPtr)num);
				}
				IL_DB:
				return result;
				IL_311:
				goto IL_31;
			}
			finally
			{
				num = (short)1014431745;
				int num2 = (int)((global::System.IntPtr)num);
				for (;;)
				{
					switch (num2)
					{
					case 0:
						enumerator.Dispose();
						num = (short)1964572674;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 1:
						switch (0)
						{
						case 0:
							goto IL_347;
						}
						continue;
					case 2:
						goto IL_37C;
					}
					IL_347:
					if (enumerator == null)
					{
						break;
					}
					num = (short)1952317440;
					num2 = (int)((global::System.IntPtr)num);
				}
				IL_37C:;
			}
			return result;
			IL_31:
			num = (short)351928320;
			short num4 = num;
			return false;
		}

		// Token: 0x0600D0A8 RID: 53416 RVA: 0x00C2F3B8 File Offset: 0x00C2D5B8
		public static bool IsNextTo800MHzRxFrequency(int inputFrequency, int spacing)
		{
			short num = (short)847380481;
			if (num != 0)
			{
			}
			num = (short)1185611776;
			short num2 = num;
			bool result = false;
			global::System.Collections.Generic.IEnumerator<global::AcpBusinessLayer.FeatureNode> enumerator = (((global::Motorola.MackinawCPS.CoreFeatures.RadioWide.RadioWideRecset)global::AcpCommonLib.FeatureManager.GetFeature(2045))[0][10096].EmbeddedRecset as global::Motorola.MackinawCPS.CoreFeatures.RadioWide.RxFrequencySplitFPPInnerRecset).GetEnumerator();
			try
			{
				num = (short)1757675540;
				int num3 = (int)((global::System.IntPtr)num);
				for (;;)
				{
					switch (num3)
					{
					case 0:
						num = (short)115933188;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					case 1:
					{
						if (!enumerator.MoveNext())
						{
							num = (short)903675914;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						}
						global::Motorola.MackinawCPS.CoreFeatures.RadioWide.RxFrequencySplitFPPInnerSection rxFrequencySplitFPPInnerSection = ((global::AcpCommonLib.IAcpFeatureNode)enumerator.Current)[10097] as global::Motorola.MackinawCPS.CoreFeatures.RadioWide.RxFrequencySplitFPPInnerSection;
						num = (short)185270288;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 2:
						num = (short)939393038;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					case 3:
					{
						global::Motorola.MackinawCPS.CoreFeatures.RadioWide.RxFrequencySplitFPPInnerSection rxFrequencySplitFPPInnerSection;
						if (inputFrequency >= rxFrequencySplitFPPInnerSection.RadWideLabtoolRxStartFrequencySplit_A9032.Value)
						{
							num = (short)361496581;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						}
						break;
					}
					case 4:
					{
						global::Motorola.MackinawCPS.CoreFeatures.RadioWide.RxFrequencySplitFPPInnerSection rxFrequencySplitFPPInnerSection;
						if (rxFrequencySplitFPPInnerSection.RadWideLabtoolRxStartFrequencySplit_A9032.Value > inputFrequency + 4095 * spacing)
						{
							num = (short)101711883;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_140;
					}
					case 5:
						num = (short)417923078;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					case 6:
					{
						global::Motorola.MackinawCPS.CoreFeatures.RadioWide.RxFrequencySplitFPPInnerSection rxFrequencySplitFPPInnerSection;
						if (inputFrequency < rxFrequencySplitFPPInnerSection.RadWideLabtoolRxEndFrequencySplit_A9015.Value)
						{
							goto IL_336;
						}
						break;
					}
					case 7:
					{
						global::Motorola.MackinawCPS.CoreFeatures.RadioWide.RxFrequencySplitFPPInnerSection rxFrequencySplitFPPInnerSection;
						if (rxFrequencySplitFPPInnerSection.RadWideLabtoolRxEndFrequencySplit_A9015.Value >= inputFrequency + 4095 * spacing)
						{
							num = (short)1873477650;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_140;
					}
					case 8:
					{
						num = (short)1311453930;
						short num4 = num;
						num = (short)2114401002;
						switch ((num4 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_336;
						default:
							num = (short)833486848;
							if (num != 0)
							{
							}
							break;
						}
						break;
					}
					case 9:
						goto IL_140;
					case 10:
						num = (short)1176436749;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					case 11:
						goto IL_278;
					case 12:
						num = (short)984940551;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					case 13:
						goto IL_402;
					case 14:
					{
						global::Motorola.MackinawCPS.CoreFeatures.RadioWide.RxFrequencySplitFPPInnerSection rxFrequencySplitFPPInnerSection;
						if (rxFrequencySplitFPPInnerSection.RadWideLabtoolRxBandSplitName_A24797.Value == global::CommonResources.AcgResources.ID_P_800M)
						{
							num = (short)2094989331;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						}
						break;
					}
					case 15:
					{
						global::Motorola.MackinawCPS.CoreFeatures.RadioWide.RxFrequencySplitFPPInnerSection rxFrequencySplitFPPInnerSection;
						if (rxFrequencySplitFPPInnerSection.RadWideLabtoolRxStartFrequencySplit_A9032.Value >= inputFrequency)
						{
							num = (short)1283260416;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_278;
					}
					case 16:
					{
						global::Motorola.MackinawCPS.CoreFeatures.RadioWide.RxFrequencySplitFPPInnerSection rxFrequencySplitFPPInnerSection;
						if (rxFrequencySplitFPPInnerSection != null)
						{
							num = (short)1200553986;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						}
						break;
					}
					case 17:
					{
						global::Motorola.MackinawCPS.CoreFeatures.RadioWide.RxFrequencySplitFPPInnerSection rxFrequencySplitFPPInnerSection;
						if (rxFrequencySplitFPPInnerSection.RadWideLabtoolRxEndFrequencySplit_A9015.Value > inputFrequency)
						{
							num = (short)1862664204;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_1F5;
					}
					case 18:
						goto IL_1F5;
					case 19:
						num = (short)1701314575;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					case 20:
						switch (0)
						{
						case 0:
							goto IL_FA;
						}
						continue;
					}
					goto IL_FA;
					IL_140:
					result = true;
					num = (short)409534472;
					num3 = (int)((global::System.IntPtr)num);
					continue;
					IL_1F5:
					num = (short)2029518851;
					num3 = (int)((global::System.IntPtr)num);
					continue;
					IL_238:
					num = (short)170328065;
					num3 = (int)((global::System.IntPtr)num);
					continue;
					IL_FA:
					goto IL_238;
					IL_278:
					num = (short)1910439953;
					num3 = (int)((global::System.IntPtr)num);
					continue;
					IL_336:
					num = (short)137166857;
					num3 = (int)((global::System.IntPtr)num);
				}
				IL_402:;
			}
			finally
			{
				num = (short)1994063874;
				int num3 = (int)((global::System.IntPtr)num);
				for (;;)
				{
					switch (num3)
					{
					case 0:
						enumerator.Dispose();
						num = (short)1044840449;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					case 1:
						goto IL_468;
					case 2:
						switch (0)
						{
						case 0:
							goto IL_434;
						}
						continue;
					}
					IL_434:
					if (enumerator == null)
					{
						break;
					}
					num = (short)1845755904;
					num3 = (int)((global::System.IntPtr)num);
				}
				IL_468:;
			}
			return result;
		}

		// Token: 0x0600D0A9 RID: 53417 RVA: 0x00C2F850 File Offset: 0x00C2DA50
		public static bool Is900MHzRxFrequency(int inputFrequency)
		{
			global::System.Collections.Generic.IEnumerator<global::AcpBusinessLayer.FeatureNode> enumerator = (((global::Motorola.MackinawCPS.CoreFeatures.RadioWide.RadioWideRecset)global::AcpCommonLib.FeatureManager.GetFeature(2045))[0][10096].EmbeddedRecset as global::Motorola.MackinawCPS.CoreFeatures.RadioWide.RxFrequencySplitFPPInnerRecset).GetEnumerator();
			short num;
			bool result;
			try
			{
				num = (short)356057100;
				int num2 = (int)((global::System.IntPtr)num);
				for (;;)
				{
					num = (short)605015972;
					short num3 = num;
					num = (short)626249636;
					switch ((num3 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						break;
					default:
						num = (short)738787328;
						if (num != 0)
						{
						}
						switch (num2)
						{
						case 0:
							num = (short)391446531;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 1:
							num = (short)581959681;
							if (num != 0)
							{
							}
							num = (short)1681784836;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 2:
						{
							global::Motorola.MackinawCPS.CoreFeatures.RadioWide.RxFrequencySplitFPPInnerSection rxFrequencySplitFPPInnerSection;
							if (rxFrequencySplitFPPInnerSection != null)
							{
								num = (short)1108606987;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							break;
						}
						case 3:
						{
							global::Motorola.MackinawCPS.CoreFeatures.RadioWide.RxFrequencySplitFPPInnerSection rxFrequencySplitFPPInnerSection;
							if (inputFrequency > rxFrequencySplitFPPInnerSection.RadWideLabtoolRxStartFrequencySplit_A9032.Value)
							{
								num = (short)1620180993;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							break;
						}
						case 4:
						{
							global::Motorola.MackinawCPS.CoreFeatures.RadioWide.RxFrequencySplitFPPInnerSection rxFrequencySplitFPPInnerSection;
							if (inputFrequency < rxFrequencySplitFPPInnerSection.RadWideLabtoolRxEndFrequencySplit_A9015.Value)
							{
								num = (short)36044809;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							break;
						}
						case 5:
							num = (short)302579719;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 6:
							goto IL_11D;
						case 7:
							goto IL_2C4;
						case 8:
						{
							if (!enumerator.MoveNext())
							{
								num = (short)739770373;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							global::Motorola.MackinawCPS.CoreFeatures.RadioWide.RxFrequencySplitFPPInnerSection rxFrequencySplitFPPInnerSection = ((global::AcpCommonLib.IAcpFeatureNode)enumerator.Current)[10097] as global::Motorola.MackinawCPS.CoreFeatures.RadioWide.RxFrequencySplitFPPInnerSection;
							num = (short)160825346;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						case 9:
							result = true;
							goto IL_106;
						case 10:
						{
							global::Motorola.MackinawCPS.CoreFeatures.RadioWide.RxFrequencySplitFPPInnerSection rxFrequencySplitFPPInnerSection;
							if (rxFrequencySplitFPPInnerSection.RadWideLabtoolRxBandSplitName_A24797.Value == global::CommonResources.AcgResources.ID_P_900M)
							{
								num = (short)21364736;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							break;
						}
						case 11:
							num = (short)1719664650;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 12:
							switch (0)
							{
							case 0:
								goto IL_FF;
							}
							continue;
						}
						IL_1DA:
						num = (short)838991880;
						num2 = (int)((global::System.IntPtr)num);
						continue;
						IL_FF:
						goto IL_1DA;
					}
					IL_106:
					num = (short)487325702;
					num2 = (int)((global::System.IntPtr)num);
				}
				IL_11D:
				return result;
				IL_2C4:
				goto IL_31;
			}
			finally
			{
				num = (short)2139488258;
				int num2 = (int)((global::System.IntPtr)num);
				for (;;)
				{
					switch (num2)
					{
					case 0:
						enumerator.Dispose();
						num = (short)1871380481;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 1:
						goto IL_32E;
					case 2:
						switch (0)
						{
						case 0:
							goto IL_2F9;
						}
						continue;
					}
					IL_2F9:
					if (enumerator == null)
					{
						break;
					}
					num = (short)1722613760;
					num2 = (int)((global::System.IntPtr)num);
				}
				IL_32E:;
			}
			return result;
			IL_31:
			num = (short)1561460736;
			short num4 = num;
			return false;
		}

		// Token: 0x0600D0AA RID: 53418 RVA: 0x00C2FBAC File Offset: 0x00C2DDAC
		public static bool Is900MHzTxFrequency(int inputFrequency)
		{
			global::System.Collections.Generic.IEnumerator<global::AcpBusinessLayer.FeatureNode> enumerator = (((global::Motorola.MackinawCPS.CoreFeatures.RadioWide.RadioWideRecset)global::AcpCommonLib.FeatureManager.GetFeature(2045))[0][10094].EmbeddedRecset as global::Motorola.MackinawCPS.CoreFeatures.RadioWide.TxFrequencySplitFPPInnerRecset).GetEnumerator();
			short num;
			bool result;
			try
			{
				num = (short)238813198;
				int num2 = (int)((global::System.IntPtr)num);
				for (;;)
				{
					switch (num2)
					{
					case 0:
						num = (short)2125266948;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 1:
						result = true;
						num = (short)1218838537;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 2:
						goto IL_243;
					case 3:
					{
						global::Motorola.MackinawCPS.CoreFeatures.RadioWide.TxFrequencySplitFPPInnerSection txFrequencySplitFPPInnerSection;
						if (!(txFrequencySplitFPPInnerSection.RadWideLabtoolTxBandSplitName_A24799.Value == global::CommonResources.AcgResources.ID_P_900M_1))
						{
							num = (short)1436418054;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_243;
					}
					case 4:
					{
						global::Motorola.MackinawCPS.CoreFeatures.RadioWide.TxFrequencySplitFPPInnerSection txFrequencySplitFPPInnerSection;
						if (inputFrequency < txFrequencySplitFPPInnerSection.RadWideLabtoolTxEndFrequencySplit_A9532.Value)
						{
							num = (short)252248065;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						break;
					}
					case 5:
					{
						global::Motorola.MackinawCPS.CoreFeatures.RadioWide.TxFrequencySplitFPPInnerSection txFrequencySplitFPPInnerSection;
						if (txFrequencySplitFPPInnerSection.RadWideLabtoolTxBandSplitName_A24799.Value == global::CommonResources.AcgResources.ID_P_900M_2)
						{
							num = (short)214827010;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						break;
					}
					case 6:
						num = (short)832045061;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 7:
						goto IL_2EA;
					case 8:
					{
						global::Motorola.MackinawCPS.CoreFeatures.RadioWide.TxFrequencySplitFPPInnerSection txFrequencySplitFPPInnerSection;
						if (txFrequencySplitFPPInnerSection != null)
						{
							num = (short)632619021;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						break;
					}
					case 9:
						goto IL_D9;
					case 10:
						num = (short)1000407047;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 11:
					{
						if (!enumerator.MoveNext())
						{
							num = (short)1169883146;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						global::Motorola.MackinawCPS.CoreFeatures.RadioWide.TxFrequencySplitFPPInnerSection txFrequencySplitFPPInnerSection = ((global::AcpCommonLib.IAcpFeatureNode)enumerator.Current)[10095] as global::Motorola.MackinawCPS.CoreFeatures.RadioWide.TxFrequencySplitFPPInnerSection;
						num = (short)35192840;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 12:
					{
						global::Motorola.MackinawCPS.CoreFeatures.RadioWide.TxFrequencySplitFPPInnerSection txFrequencySplitFPPInnerSection;
						if (inputFrequency > txFrequencySplitFPPInnerSection.RadWideLabtoolTxStartFrequencySplit_A9571.Value)
						{
							num = (short)1300692371;
							short num3 = num;
							num = (short)1662123411;
							switch ((num3 == num) ? 1 : 0)
							{
							case 0:
							case 2:
								goto IL_D9;
							default:
								num = (short)1818755072;
								if (num != 0)
								{
								}
								num = (short)664535040;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
						}
						break;
					}
					case 13:
						num = (short)485031939;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 14:
						switch (0)
						{
						case 0:
							goto IL_BD;
						}
						continue;
					}
					IL_16E:
					num = (short)1814036491;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_BD:
					goto IL_16E;
					IL_243:
					num = (short)1658847244;
					num2 = (int)((global::System.IntPtr)num);
				}
				IL_D9:
				return result;
				IL_2EA:
				goto IL_31;
			}
			finally
			{
				num = (short)741998594;
				int num2 = (int)((global::System.IntPtr)num);
				for (;;)
				{
					switch (num2)
					{
					case 0:
						enumerator.Dispose();
						num = (short)371130369;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 1:
						goto IL_353;
					case 2:
						switch (0)
						{
						case 0:
							goto IL_31F;
						}
						continue;
					}
					IL_31F:
					if (enumerator == null)
					{
						break;
					}
					num = (short)546832384;
					num2 = (int)((global::System.IntPtr)num);
				}
				IL_353:
				num = (short)932446209;
				if (num != 0)
				{
				}
			}
			return result;
			IL_31:
			num = (short)2132541440;
			short num4 = num;
			return false;
		}

		// Token: 0x0600D0AB RID: 53419 RVA: 0x00C2FF54 File Offset: 0x00C2E154
		public static bool IsNextTo900MHzRxFrequency(int inputFrequency, int spacing)
		{
			bool result = false;
			global::System.Collections.Generic.IEnumerator<global::AcpBusinessLayer.FeatureNode> enumerator = (((global::Motorola.MackinawCPS.CoreFeatures.RadioWide.RadioWideRecset)global::AcpCommonLib.FeatureManager.GetFeature(2045))[0][10096].EmbeddedRecset as global::Motorola.MackinawCPS.CoreFeatures.RadioWide.RxFrequencySplitFPPInnerRecset).GetEnumerator();
			short num;
			try
			{
				num = (short)647168020;
				int num2 = (int)((global::System.IntPtr)num);
				for (;;)
				{
					switch (num2)
					{
					case 0:
						num = (short)1517158404;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 1:
					{
						if (!enumerator.MoveNext())
						{
							num = (short)789446666;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						global::Motorola.MackinawCPS.CoreFeatures.RadioWide.RxFrequencySplitFPPInnerSection rxFrequencySplitFPPInnerSection = ((global::AcpCommonLib.IAcpFeatureNode)enumerator.Current)[10097] as global::Motorola.MackinawCPS.CoreFeatures.RadioWide.RxFrequencySplitFPPInnerSection;
						num = (short)2119827472;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 2:
						num = (short)2044264462;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 3:
					{
						global::Motorola.MackinawCPS.CoreFeatures.RadioWide.RxFrequencySplitFPPInnerSection rxFrequencySplitFPPInnerSection;
						if (inputFrequency > rxFrequencySplitFPPInnerSection.RadWideLabtoolRxStartFrequencySplit_A9032.Value)
						{
							num = (short)405602309;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						break;
					}
					case 4:
					{
						global::Motorola.MackinawCPS.CoreFeatures.RadioWide.RxFrequencySplitFPPInnerSection rxFrequencySplitFPPInnerSection;
						if (rxFrequencySplitFPPInnerSection.RadWideLabtoolRxStartFrequencySplit_A9032.Value >= inputFrequency + 4095 * spacing)
						{
							num = (short)2133131275;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_F1;
					}
					case 5:
						num = (short)1109262342;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 6:
					{
						global::Motorola.MackinawCPS.CoreFeatures.RadioWide.RxFrequencySplitFPPInnerSection rxFrequencySplitFPPInnerSection;
						if (inputFrequency < rxFrequencySplitFPPInnerSection.RadWideLabtoolRxEndFrequencySplit_A9015.Value)
						{
							goto IL_2E3;
						}
						break;
					}
					case 7:
					{
						global::Motorola.MackinawCPS.CoreFeatures.RadioWide.RxFrequencySplitFPPInnerSection rxFrequencySplitFPPInnerSection;
						if (rxFrequencySplitFPPInnerSection.RadWideLabtoolRxEndFrequencySplit_A9015.Value >= inputFrequency + 4095 * spacing)
						{
							num = (short)1964048402;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_F1;
					}
					case 8:
					{
						num = (short)1780390994;
						short num3 = num;
						num = (short)897162322;
						switch ((num3 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_2E3;
						default:
							num = (short)472252416;
							if (num != 0)
							{
							}
							break;
						}
						break;
					}
					case 9:
						goto IL_F1;
					case 10:
						num = (short)1514930189;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 11:
						goto IL_224;
					case 12:
						num = (short)2115698695;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 13:
						goto IL_3B5;
					case 14:
					{
						global::Motorola.MackinawCPS.CoreFeatures.RadioWide.RxFrequencySplitFPPInnerSection rxFrequencySplitFPPInnerSection;
						if (rxFrequencySplitFPPInnerSection.RadWideLabtoolRxBandSplitName_A24797.Value == global::CommonResources.AcgResources.ID_P_900M)
						{
							num = (short)2094596115;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						break;
					}
					case 15:
					{
						global::Motorola.MackinawCPS.CoreFeatures.RadioWide.RxFrequencySplitFPPInnerSection rxFrequencySplitFPPInnerSection;
						if (rxFrequencySplitFPPInnerSection.RadWideLabtoolRxStartFrequencySplit_A9032.Value > inputFrequency)
						{
							num = (short)233635840;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_224;
					}
					case 16:
					{
						global::Motorola.MackinawCPS.CoreFeatures.RadioWide.RxFrequencySplitFPPInnerSection rxFrequencySplitFPPInnerSection;
						if (rxFrequencySplitFPPInnerSection != null)
						{
							num = (short)1524695042;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						break;
					}
					case 17:
					{
						global::Motorola.MackinawCPS.CoreFeatures.RadioWide.RxFrequencySplitFPPInnerSection rxFrequencySplitFPPInnerSection;
						if (rxFrequencySplitFPPInnerSection.RadWideLabtoolRxEndFrequencySplit_A9015.Value > inputFrequency)
						{
							num = (short)735576076;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_1A4;
					}
					case 18:
						goto IL_1A4;
					case 19:
						num = (short)1446510607;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 20:
						switch (0)
						{
						case 0:
							goto IL_AB;
						}
						continue;
					}
					goto IL_AB;
					IL_F1:
					result = true;
					num = (short)1816199176;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_1A4:
					num = (short)1733296131;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_1E5:
					num = (short)1964310529;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_AB:
					goto IL_1E5;
					IL_224:
					num = (short)700645393;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_2E3:
					num = (short)1409810441;
					num2 = (int)((global::System.IntPtr)num);
				}
				IL_3B5:;
			}
			finally
			{
				num = (short)243990530;
				int num2 = (int)((global::System.IntPtr)num);
				for (;;)
				{
					switch (num2)
					{
					case 0:
						enumerator.Dispose();
						num = (short)1504116737;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 1:
						goto IL_447;
					case 2:
						switch (0)
						{
						case 0:
							goto IL_3EA;
						}
						continue;
					}
					IL_3EA:
					num = (short)687079425;
					if (num != 0)
					{
					}
					if (enumerator == null)
					{
						break;
					}
					num = (short)714735616;
					num2 = (int)((global::System.IntPtr)num);
				}
				IL_447:;
			}
			num = (short)408092672;
			short num4 = num;
			return result;
		}

		// Token: 0x0600D0AC RID: 53420 RVA: 0x00C303F4 File Offset: 0x00C2E5F4
		public static bool Is900MHzSupported()
		{
			global::Motorola.MackinawCPS.CoreFeatures.RadioInformation.RadioInformation radioInformation = global::AcpCommonLib.FeatureManager.GetFeature(2049)[0] as global::Motorola.MackinawCPS.CoreFeatures.RadioInformation.RadioInformation;
			if (!global::ConstraintHelper.UtilityMack.IsFreonRadio)
			{
				short num;
				for (;;)
				{
					num = (short)1251082895;
					short num2 = num;
					num = (short)547685007;
					switch ((num2 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						break;
					default:
						goto IL_56;
					}
				}
				IL_56:
				num = (short)6225920;
				if (num != 0)
				{
				}
				num = (short)1529479169;
				if (num != 0)
				{
				}
				num = (short)1293942784;
				short num3 = num;
				return radioInformation.Labtool.RadInfoLabtoolPrimaryBands_A23987.Value == 6;
			}
			return radioInformation.General.RadInfoGeneralPrimaryFrequencyBand900_A42548.Value;
		}

		// Token: 0x0600D0AD RID: 53421 RVA: 0x00C304E4 File Offset: 0x00C2E6E4
		public static global::ConstraintHelper.UtilityMack.FrequencyBand GetRxBand(int frequency)
		{
			switch (0)
			{
			case 0:
				goto IL_D0;
			}
			int num;
			global::ConstraintHelper.UtilityMack.FrequencyBand result;
			short num2;
			global::Motorola.MackinawCPS.CoreFeatures.RadioWide.Features features;
			for (;;)
			{
				IL_0A:
				switch (num)
				{
				case 0:
					return result;
				case 1:
					result = global::ConstraintHelper.UtilityMack.FrequencyBand.VHF;
					num2 = (short)265682963;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 2:
					num2 = (short)798425126;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 3:
					if (global::ConstraintHelper.UtilityMack.IsUHF1Supported())
					{
						num2 = (short)1157103662;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_51B;
				case 4:
					num2 = (short)1252786210;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 5:
					num2 = (short)1989410838;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 6:
					if (global::ConstraintHelper.UtilityMack.IsUHF2RxFrequency(frequency))
					{
						num2 = (short)568918059;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_2A9;
				case 7:
					num2 = (short)1504378900;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 8:
					num2 = (short)1799421965;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 9:
					result = global::ConstraintHelper.UtilityMack.FrequencyBand.UHF2;
					num2 = (short)237305874;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 10:
					num2 = (short)1693581323;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 11:
					if (global::ConstraintHelper.UtilityMack.IsUHF1RxFrequency(frequency))
					{
						num2 = (short)1494745092;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_2E9;
				case 12:
					if (features.RadWideTransmitPowerLevelsBandSplitOverride_A41064.Value == 2)
					{
						num2 = (short)293994501;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_131;
				case 13:
					if (global::ConstraintHelper.UtilityMack.Is900MHzSupported())
					{
						num2 = (short)892076077;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					return result;
				case 14:
					if (global::ConstraintHelper.UtilityMack.IsUHF2RxFrequency(frequency))
					{
						goto IL_73B;
					}
					goto IL_131;
				case 15:
					if (global::ConstraintHelper.UtilityMack.IsUHF1Supported())
					{
						num2 = (short)789970983;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_2E9;
				case 16:
					num2 = (short)312082449;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 17:
					if (global::ConstraintHelper.UtilityMack.IsUHF2Supported())
					{
						num2 = (short)100401161;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_131;
				case 18:
					return result;
				case 19:
					return result;
				case 20:
					if (global::ConstraintHelper.UtilityMack.Is7800MHzSupported())
					{
						num2 = (short)1116274729;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_1AE;
				case 21:
					return result;
				case 22:
					if (global::ConstraintHelper.UtilityMack.IsUHF1RxFrequency(frequency))
					{
						num2 = (short)422051882;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_131;
				case 23:
					return result;
				case 24:
					if (global::ConstraintHelper.UtilityMack.Is7800MHzSupported())
					{
						num2 = (short)940769306;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_612;
				case 25:
					num2 = (short)1636564995;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 26:
					result = global::ConstraintHelper.UtilityMack.FrequencyBand.P700;
					num2 = (short)1130102807;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 27:
					num2 = (short)265682959;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 28:
					if (global::ConstraintHelper.UtilityMack.Is800MHzRxFrequency(frequency))
					{
						num2 = (short)2004877312;
						short num3 = num2;
						num2 = (short)421068807;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_1AE;
				case 29:
					if (global::ConstraintHelper.UtilityMack.IsUHF1RxFrequency(frequency))
					{
						num2 = (short)1530200089;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_51B;
				case 30:
					result = global::ConstraintHelper.UtilityMack.FrequencyBand.UHF2;
					num2 = (short)485949461;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 31:
					if (global::ConstraintHelper.UtilityMack.IsUHF2Supported())
					{
						num2 = (short)1393426462;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_2A9;
				case 32:
					if (features.RadWideTransmitPowerLevelsBandSplitOverride_A41064.Value == 1)
					{
						num2 = (short)963641354;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_2E9;
				case 33:
					return result;
				case 34:
					num2 = (short)512688129;
					if (num2 != 0)
					{
					}
					if (global::ConstraintHelper.UtilityMack.IsUHF2RxFrequency(frequency))
					{
						num2 = (short)242548763;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_2E9;
				case 35:
					if (global::ConstraintHelper.UtilityMack.Is900MHzRxFrequency(frequency))
					{
						num2 = (short)1384120328;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					return result;
				case 36:
					if (global::ConstraintHelper.UtilityMack.IsVHFRxFrequency(frequency))
					{
						num2 = (short)922025986;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_4D7;
				case 37:
					return result;
				case 38:
				{
					num2 = (short)245602208;
					short num4 = num2;
					num2 = (short)2092865440;
					switch ((num4 == num2) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_73B;
					default:
						num2 = (short)992608256;
						if (num2 != 0)
						{
						}
						if (global::ConstraintHelper.UtilityMack.IsVHFSupported())
						{
							num2 = (short)1182924801;
							num = (int)((global::System.IntPtr)num2);
							continue;
						}
						goto IL_4D7;
					}
					break;
				}
				case 39:
					result = global::ConstraintHelper.UtilityMack.FrequencyBand.UHF1;
					num2 = (short)290979840;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 40:
					if (global::ConstraintHelper.UtilityMack.Is700MHzRxFrequency(frequency))
					{
						num2 = (short)1063452719;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_612;
				case 41:
					result = global::ConstraintHelper.UtilityMack.FrequencyBand.P800;
					num2 = (short)1114177580;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 42:
					num2 = (short)1818886158;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 43:
					num2 = (short)654442527;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 44:
					return result;
				case 45:
					result = global::ConstraintHelper.UtilityMack.FrequencyBand.P900;
					num2 = (short)1165819937;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 46:
					result = global::ConstraintHelper.UtilityMack.FrequencyBand.UHF1;
					num2 = (short)1582301221;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 47:
					num2 = (short)466550808;
					num = (int)((global::System.IntPtr)num2);
					continue;
				}
				goto IL_D0;
				IL_131:
				num2 = (short)267517981;
				num = (int)((global::System.IntPtr)num2);
				continue;
				IL_1AE:
				num2 = (short)539885604;
				num = (int)((global::System.IntPtr)num2);
				continue;
				IL_2A9:
				num2 = (short)374669347;
				num = (int)((global::System.IntPtr)num2);
				continue;
				IL_2E9:
				num2 = (short)123863052;
				num = (int)((global::System.IntPtr)num2);
				continue;
				IL_4D7:
				num2 = (short)1283260448;
				num = (int)((global::System.IntPtr)num2);
				continue;
				IL_51B:
				num2 = (short)983046;
				num = (int)((global::System.IntPtr)num2);
				continue;
				IL_612:
				num2 = (short)1192558620;
				num = (int)((global::System.IntPtr)num2);
				continue;
				IL_73B:
				num2 = (short)511901712;
				num = (int)((global::System.IntPtr)num2);
			}
			return result;
			IL_D0:
			result = global::ConstraintHelper.UtilityMack.FrequencyBand.Unknown;
			features = (global::AcpCommonLib.FeatureManager.GetFeature(2045)[0][10105] as global::Motorola.MackinawCPS.CoreFeatures.RadioWide.Features);
			num2 = (short)819068968;
			num = (int)((global::System.IntPtr)num2);
			goto IL_0A;
		}

		// Token: 0x0600D0AE RID: 53422 RVA: 0x00C30C64 File Offset: 0x00C2EE64
		public static global::ConstraintHelper.UtilityMack.FrequencyBand GetTxBand(int frequency)
		{
			switch (0)
			{
			case 0:
				goto IL_D0;
			}
			int num;
			short num2;
			global::ConstraintHelper.UtilityMack.FrequencyBand result;
			global::Motorola.MackinawCPS.CoreFeatures.RadioWide.Features features;
			for (;;)
			{
				IL_0A:
				switch (num)
				{
				case 0:
					if (global::ConstraintHelper.UtilityMack.Is7800MHzSupported())
					{
						num2 = (short)646643734;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_1AC;
				case 1:
					num2 = (short)1780613121;
					if (num2 != 0)
					{
					}
					result = global::ConstraintHelper.UtilityMack.FrequencyBand.UHF2;
					num2 = (short)358350857;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 2:
					if (features.RadWideTransmitPowerLevelsBandSplitOverride_A41064.Value == 2)
					{
						num2 = (short)796524567;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_131;
				case 3:
					num2 = (short)1479737372;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 4:
					if (global::ConstraintHelper.UtilityMack.IsUHF2TxFrequency(frequency))
					{
						num2 = (short)646316063;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_2CB;
				case 5:
					if (global::ConstraintHelper.UtilityMack.IsUHF1TxFrequency(frequency))
					{
						num2 = (short)1169621003;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_4CA;
				case 6:
					goto IL_521;
				case 7:
					if (global::ConstraintHelper.UtilityMack.IsVHFTxFrequency(frequency))
					{
						num2 = (short)419168286;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_485;
				case 8:
					result = global::ConstraintHelper.UtilityMack.FrequencyBand.VHF;
					num2 = (short)1152450592;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 9:
					goto IL_3A9;
				case 10:
					if (global::ConstraintHelper.UtilityMack.IsUHF1Supported())
					{
						num2 = (short)733872141;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_4CA;
				case 11:
					num2 = (short)1877671946;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 12:
					result = global::ConstraintHelper.UtilityMack.FrequencyBand.P700;
					num2 = (short)526123052;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 13:
					goto IL_508;
				case 14:
					num2 = (short)338886656;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 15:
					result = global::ConstraintHelper.UtilityMack.FrequencyBand.P900;
					num2 = (short)837287961;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 16:
					if (global::ConstraintHelper.UtilityMack.Is700MHzTxFrequency(frequency))
					{
						num2 = (short)2066939944;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_5BF;
				case 17:
					if (global::ConstraintHelper.UtilityMack.Is900MHzSupported())
					{
						num2 = (short)178716687;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					return result;
				case 18:
					num2 = (short)1667694611;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 19:
					if (global::ConstraintHelper.UtilityMack.IsUHF2TxFrequency(frequency))
					{
						num2 = (short)1320550426;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_30B;
				case 20:
					if (global::ConstraintHelper.UtilityMack.IsUHF2Supported())
					{
						num2 = (short)1198063617;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_2CB;
				case 21:
					num2 = (short)969539627;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 22:
					result = global::ConstraintHelper.UtilityMack.FrequencyBand.P800;
					num2 = (short)1271070747;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 23:
					num2 = (short)1140588586;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 24:
					goto IL_57D;
				case 25:
					goto IL_3C7;
				case 26:
					num2 = (short)1080950818;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 27:
					goto IL_462;
				case 28:
					if (global::ConstraintHelper.UtilityMack.IsUHF2Supported())
					{
						num2 = (short)885981220;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_131;
				case 29:
					num2 = (short)179175441;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 30:
					num2 = (short)784203823;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 31:
					num2 = (short)1002242068;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 32:
					goto IL_480;
				case 33:
					if (features.RadWideTransmitPowerLevelsBandSplitOverride_A41064.Value == 1)
					{
						num2 = (short)100990997;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_30B;
				case 34:
					if (global::ConstraintHelper.UtilityMack.IsUHF1Supported())
					{
						num2 = (short)205127719;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_30B;
				case 35:
					if (global::ConstraintHelper.UtilityMack.Is800MHzTxFrequency(frequency))
					{
						num2 = (short)1567358990;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_1AC;
				case 36:
					result = global::ConstraintHelper.UtilityMack.FrequencyBand.UHF2;
					num2 = (short)1553334313;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 37:
					if (global::ConstraintHelper.UtilityMack.Is7800MHzSupported())
					{
						num2 = (short)472842252;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_5BF;
				case 38:
					if (global::ConstraintHelper.UtilityMack.Is900MHzTxFrequency(frequency))
					{
						num2 = (short)1385496605;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					return result;
				case 39:
					result = global::ConstraintHelper.UtilityMack.FrequencyBand.UHF1;
					num2 = (short)387252248;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 40:
					num2 = (short)1202061349;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 41:
					return result;
				case 42:
					if (global::ConstraintHelper.UtilityMack.IsUHF1TxFrequency(frequency))
					{
						num2 = (short)1248460845;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_131;
				case 43:
				{
					num2 = (short)2023620608;
					short num3 = num2;
					if (global::ConstraintHelper.UtilityMack.IsUHF1TxFrequency(frequency))
					{
						num2 = (short)1956315154;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_30B;
				}
				case 44:
				{
					num2 = (short)226848550;
					short num4 = num2;
					num2 = (short)1283551014;
					switch ((num4 == num2) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_508;
					default:
						goto IL_6F6;
					}
					break;
				}
				case 45:
					num2 = (short)239468590;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 46:
					if (global::ConstraintHelper.UtilityMack.IsUHF2TxFrequency(frequency))
					{
						num2 = (short)1887109123;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_131;
				case 47:
					if (global::ConstraintHelper.UtilityMack.IsVHFSupported())
					{
						num2 = (short)313131016;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_485;
				}
				goto IL_D0;
				IL_131:
				num2 = (short)772014085;
				num = (int)((global::System.IntPtr)num2);
				continue;
				IL_1AC:
				num2 = (short)1544224775;
				num = (int)((global::System.IntPtr)num2);
				continue;
				IL_2CB:
				num2 = (short)324927526;
				num = (int)((global::System.IntPtr)num2);
				continue;
				IL_30B:
				num2 = (short)1633681410;
				num = (int)((global::System.IntPtr)num2);
				continue;
				IL_485:
				num2 = (short)1058406433;
				num = (int)((global::System.IntPtr)num2);
				continue;
				IL_4CA:
				num2 = (short)582942724;
				num = (int)((global::System.IntPtr)num2);
				continue;
				IL_508:
				result = global::ConstraintHelper.UtilityMack.FrequencyBand.UHF1;
				num2 = (short)160694278;
				num = (int)((global::System.IntPtr)num2);
				continue;
				IL_5BF:
				num2 = (short)1511850019;
				num = (int)((global::System.IntPtr)num2);
			}
			IL_3A9:
			IL_3C7:
			IL_462:
			IL_480:
			IL_521:
			IL_57D:
			return result;
			IL_6F6:
			num2 = (short)1841627136;
			if (num2 != 0)
			{
			}
			return result;
			IL_D0:
			result = global::ConstraintHelper.UtilityMack.FrequencyBand.Unknown;
			features = (global::AcpCommonLib.FeatureManager.GetFeature(2045)[0][10105] as global::Motorola.MackinawCPS.CoreFeatures.RadioWide.Features);
			num2 = (short)1440546832;
			num = (int)((global::System.IntPtr)num2);
			goto IL_0A;
		}

		// Token: 0x0600D0AF RID: 53423 RVA: 0x00C313E0 File Offset: 0x00C2F5E0
		public static bool IsIPAddressFormatValid(int nOctet1, int nOctet2, int nOctet3, int nOctet4)
		{
			switch (0)
			{
			case 0:
				goto IL_1CC;
			}
			int num;
			bool result;
			short num2;
			bool flag;
			int num5;
			for (;;)
			{
				IL_0A:
				switch (num)
				{
				case 0:
					return result;
				case 1:
					if (nOctet2 == 255)
					{
						num2 = (short)566755359;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_F09;
				case 2:
					num2 = (short)2038300733;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 3:
					goto IL_24A;
				case 4:
					num2 = (short)1356595252;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 5:
					goto IL_918;
				case 6:
					if (nOctet3 == 255)
					{
						num2 = (short)422576161;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_AFC;
				case 7:
					num2 = (short)992608275;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 8:
					goto IL_AFC;
				case 9:
					num2 = (short)907411467;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 10:
					num2 = (short)1470431289;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 11:
					if (nOctet4 == 0)
					{
						num2 = (short)1827799096;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_802;
				case 12:
					num2 = (short)1247543297;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 13:
					if (nOctet1 >= 192)
					{
						num2 = (short)437583882;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_24A;
				case 14:
					goto IL_F09;
				case 15:
					if (nOctet1 == 192)
					{
						num2 = (short)987955204;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_A09;
				case 16:
					if (flag)
					{
						num2 = (short)479723579;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_D86;
				case 17:
					goto IL_24A;
				case 18:
					num2 = (short)1541865536;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 19:
					if (nOctet2 <= 255)
					{
						num2 = (short)445448255;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_A69;
				case 20:
					goto IL_71A;
				case 21:
					goto IL_A09;
				case 22:
					if (nOctet3 >= 0)
					{
						num2 = (short)919928882;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_A69;
				case 23:
					num2 = (short)769065037;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 24:
					if (nOctet3 == 0)
					{
						num2 = (short)1650327600;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					return result;
				case 25:
					if (nOctet1 != 0)
					{
						num2 = (short)512229388;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_918;
				case 26:
					num2 = (short)1725890601;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 27:
					goto IL_62C;
				case 28:
					num2 = (short)75759710;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 29:
					if (nOctet1 >= 0)
					{
						num2 = (short)1607729240;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_A69;
				case 30:
					if (flag)
					{
						num2 = (short)1751449626;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_62C;
				case 31:
					num2 = (short)58654721;
					if (num2 != 0)
					{
					}
					num2 = (short)636223561;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 32:
					if (nOctet3 != 0)
					{
						num2 = (short)1258160149;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_464;
				case 33:
					num2 = (short)1110114405;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 34:
					goto IL_D86;
				case 35:
					goto IL_BDA;
				case 36:
					if (nOctet4 == 0)
					{
						num2 = (short)703004717;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					return result;
				case 37:
					if (nOctet2 == 255)
					{
						num2 = (short)1094320128;
						short num3 = num2;
						num2 = (short)1137770600;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_AFC;
				case 38:
					goto IL_443;
				case 39:
					if (nOctet1 == 128)
					{
						num2 = (short)1931608147;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_71A;
				case 40:
					if (nOctet2 == 0)
					{
						num2 = (short)1585381394;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_802;
				case 41:
					if (nOctet1 == 127)
					{
						num2 = (short)118227002;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_62C;
				case 42:
					if (flag)
					{
						num2 = (short)881131599;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_537;
				case 43:
					goto IL_802;
				case 44:
					goto IL_537;
				case 45:
					goto IL_464;
				case 46:
					if (nOctet2 >= 0)
					{
						num2 = (short)1305083999;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_A69;
				case 47:
					num2 = (short)1808465949;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 48:
					num2 = (short)54067284;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 49:
					if (nOctet4 != 255)
					{
						num2 = (short)1955856398;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_918;
				case 50:
				{
					num2 = (short)1619121429;
					short num4 = num2;
					num2 = (short)1576129813;
					switch ((num4 == num2) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_F75;
					default:
						num2 = (short)608239616;
						if (num2 != 0)
						{
						}
						num2 = (short)971440203;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					break;
				}
				case 51:
					if (nOctet1 <= 255)
					{
						num2 = (short)1573978119;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_A69;
				case 52:
					if (nOctet2 == 0)
					{
						num2 = (short)232325185;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_A09;
				case 53:
					if (nOctet1 == 255)
					{
						num2 = (short)1254490167;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_AFC;
				case 54:
					if (nOctet4 != 255)
					{
						num2 = (short)1782644771;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_443;
				case 55:
					num2 = (short)1675100197;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 56:
					result = false;
					flag = false;
					num2 = (short)440401963;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 57:
					if (nOctet1 <= 223)
					{
						num2 = (short)537460823;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_24A;
				case 58:
					result = false;
					flag = false;
					num2 = (short)961347611;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 59:
					num2 = (short)1394802750;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 60:
					return result;
				case 61:
					result = false;
					flag = false;
					num2 = (short)1041104956;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 62:
					if (nOctet1 >= 0)
					{
						num2 = (short)977862749;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_E94;
				case 63:
					num2 = (short)69533782;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 64:
					if (nOctet3 == 0)
					{
						num2 = (short)2030829577;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_802;
				case 65:
					num2 = (short)1063256096;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 66:
					if (nOctet2 != 0)
					{
						num2 = (short)520421396;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_443;
				case 67:
					if (nOctet2 == 0)
					{
						num2 = (short)256704621;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					return result;
				case 68:
					num2 = (short)738000986;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 69:
					num5 = 2;
					num2 = (short)1923153937;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 70:
					return result;
				case 71:
					if (flag)
					{
						num2 = (short)655425604;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_802;
				case 72:
					if (nOctet4 != 255)
					{
						num2 = (short)919470179;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_464;
				case 73:
					if (nOctet3 == 255)
					{
						num2 = (short)1820131436;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_F09;
				case 74:
					return result;
				case 75:
					if (nOctet4 < 0)
					{
						num2 = (short)11206761;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_537;
				case 76:
					if (nOctet1 >= 128)
					{
						num2 = (short)1777860631;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_E55;
				case 77:
					if (nOctet1 <= 191)
					{
						num2 = (short)1195900997;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_E55;
				case 78:
					result = false;
					flag = false;
					num2 = (short)84475938;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 79:
					num2 = (short)1047068723;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 80:
					num2 = (short)573243473;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 81:
					switch (num5)
					{
					case 1:
						num2 = (short)22216729;
						num = (int)((global::System.IntPtr)num2);
						continue;
					case 2:
						num2 = (short)51707943;
						num = (int)((global::System.IntPtr)num2);
						continue;
					case 3:
						num2 = (short)1355350031;
						num = (int)((global::System.IntPtr)num2);
						continue;
					default:
						num2 = (short)272171010;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					break;
				case 82:
					num2 = (short)1949171765;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 83:
					num2 = (short)731381826;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 84:
					if (nOctet4 == 0)
					{
						num2 = (short)764674086;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					return result;
				case 85:
					if (nOctet3 == 255)
					{
						num2 = (short)631046254;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_BDA;
				case 86:
					if (nOctet3 <= 255)
					{
						num2 = (short)1962082404;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_A69;
				case 87:
					num5 = 3;
					num2 = (short)519962730;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 88:
					num2 = (short)1593770030;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 89:
					num5 = 1;
					num2 = (short)2019753987;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 90:
					if (nOctet1 == 0)
					{
						num2 = (short)319160422;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_802;
				case 91:
					if (nOctet1 <= 127)
					{
						num2 = (short)814415961;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_E94;
				case 92:
					if (flag)
					{
						num2 = (short)1990197330;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_AFC;
				case 93:
					num2 = (short)99090523;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 94:
					if (nOctet4 == 0)
					{
						num2 = (short)1988820997;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					return result;
				case 95:
					num2 = (short)1736179734;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 96:
					if (nOctet3 == 0)
					{
						num2 = (short)1021509660;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					return result;
				case 97:
					if (flag)
					{
						num2 = (short)1358954576;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					return result;
				case 98:
					result = false;
					flag = false;
					num2 = (short)764477448;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 99:
					num2 = (short)2109997092;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 100:
					num2 = (short)539361387;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 101:
					if (nOctet4 == 255)
					{
						num2 = (short)907804770;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_AFC;
				case 102:
					num2 = (short)783351848;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 103:
					if (num5 == 0)
					{
						num2 = (short)92078158;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_D86;
				case 104:
					num2 = (short)887488518;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 105:
					goto IL_A69;
				case 106:
					goto IL_24A;
				case 107:
					goto IL_F75;
				case 108:
					num2 = (short)1195769905;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 109:
					num2 = (short)76284000;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 110:
					num2 = (short)659161142;
					num = (int)((global::System.IntPtr)num2);
					continue;
				}
				goto IL_1CC;
				IL_24A:
				num2 = (short)1944060007;
				num = (int)((global::System.IntPtr)num2);
				continue;
				IL_443:
				result = false;
				flag = false;
				num2 = (short)659095552;
				num = (int)((global::System.IntPtr)num2);
				continue;
				IL_464:
				result = false;
				flag = false;
				num2 = (short)91357258;
				num = (int)((global::System.IntPtr)num2);
				continue;
				IL_537:
				num2 = (short)1487929415;
				num = (int)((global::System.IntPtr)num2);
				continue;
				IL_62C:
				num2 = (short)385679376;
				num = (int)((global::System.IntPtr)num2);
				continue;
				IL_71A:
				num2 = (short)1225261141;
				num = (int)((global::System.IntPtr)num2);
				continue;
				IL_802:
				num2 = (short)483328092;
				num = (int)((global::System.IntPtr)num2);
				continue;
				IL_918:
				result = false;
				flag = false;
				num2 = (short)658440262;
				num = (int)((global::System.IntPtr)num2);
				continue;
				IL_A09:
				num2 = (short)1669529672;
				num = (int)((global::System.IntPtr)num2);
				continue;
				IL_A69:
				result = false;
				flag = false;
				num2 = (short)1100611628;
				num = (int)((global::System.IntPtr)num2);
				continue;
				IL_F75:
				if (nOctet4 <= 255)
				{
					num2 = (short)1449787439;
					num = (int)((global::System.IntPtr)num2);
					continue;
				}
				goto IL_A69;
				IL_AFC:
				num2 = (short)1449721886;
				num = (int)((global::System.IntPtr)num2);
				continue;
				IL_BDA:
				num2 = (short)556072984;
				num = (int)((global::System.IntPtr)num2);
				continue;
				IL_D86:
				num2 = (short)1726873697;
				num = (int)((global::System.IntPtr)num2);
				continue;
				IL_E55:
				num2 = (short)751566861;
				num = (int)((global::System.IntPtr)num2);
				continue;
				IL_E94:
				num2 = (short)66191436;
				num = (int)((global::System.IntPtr)num2);
				continue;
				IL_F09:
				num2 = (short)1809776707;
				num = (int)((global::System.IntPtr)num2);
			}
			return result;
			IL_1CC:
			result = true;
			flag = true;
			num5 = 0;
			num2 = (short)1165426730;
			num = (int)((global::System.IntPtr)num2);
			goto IL_0A;
		}

		// Token: 0x0600D0B0 RID: 53424 RVA: 0x00C3238C File Offset: 0x00C3058C
		public static int SetPreambles(bool bPreambleDuringPretime, int nPretime)
		{
			short num = (short)1808662528;
			short num2 = num;
			switch (0)
			{
			case 0:
				goto IL_78;
			}
			int num3;
			int num5;
			for (;;)
			{
				IL_32:
				num = (short)1557200897;
				if (num != 0)
				{
				}
				switch (num3)
				{
				case 0:
				{
					num = (short)1547843052;
					short num4 = num;
					num = (short)941831660;
					switch ((num4 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_91;
					default:
						num = (short)713162752;
						if (num != 0)
						{
						}
						if (100 * nPretime % 4667 >= 2334)
						{
							num = (short)1818034177;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						}
						return num5;
					}
					break;
				}
				case 1:
					num5++;
					num = (short)1863122947;
					num3 = (int)((global::System.IntPtr)num);
					continue;
				case 2:
					if (!bPreambleDuringPretime)
					{
						goto IL_91;
					}
					num5 = 100 * nPretime / 4667 + 1;
					num = (short)1093074944;
					num3 = (int)((global::System.IntPtr)num);
					continue;
				case 3:
					return num5;
				case 4:
					return num5;
				case 5:
					num5 = 1;
					num = (short)2093809668;
					num3 = (int)((global::System.IntPtr)num);
					continue;
				}
				goto IL_78;
				IL_91:
				num = (short)878641157;
				num3 = (int)((global::System.IntPtr)num);
			}
			return num5;
			IL_78:
			num5 = 0;
			num = (short)1687158786;
			num3 = (int)((global::System.IntPtr)num);
			goto IL_32;
		}

		// Token: 0x0600D0B1 RID: 53425 RVA: 0x00C32520 File Offset: 0x00C30720
		public static int SetPretime(bool bPreambleDuringPretime, int nSystemPretime, bool bIsSystem)
		{
			short num = (short)904462340;
			int num2 = (int)((global::System.IntPtr)num);
			int num3;
			for (;;)
			{
				switch (num2)
				{
				case 0:
					if (nSystemPretime % 25 > 0)
					{
						num = (short)336527365;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					return num3;
				case 1:
					return num3;
				case 2:
					return num3;
				case 3:
					return num3;
				case 4:
					switch (0)
					{
					case 0:
						goto IL_50;
					}
					continue;
				case 5:
					num3++;
					num = (short)199360514;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 6:
					if (bPreambleDuringPretime)
					{
						num = (short)748945416;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					num3 = nSystemPretime / 25 + 1;
					goto IL_77;
				case 7:
					num3 = nSystemPretime / 25 + 1;
					num = (short)1825767424;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 8:
					num3 = 0;
					num = (short)1771110403;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 9:
				{
					num = (short)668339259;
					short num4 = num;
					num = (short)619973691;
					switch ((num4 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_77;
					default:
						num = (short)1822818305;
						if (num != 0)
						{
						}
						num = (short)312082432;
						if (num != 0)
						{
						}
						num3++;
						num = (short)1368784897;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					break;
				}
				case 10:
				{
					num = (short)413466624;
					short num5 = num;
					if (nSystemPretime % 25 > 0)
					{
						num = (short)58785801;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					return num3;
				}
				}
				IL_50:
				if (bIsSystem)
				{
					num = (short)1095892999;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				num = (short)1127219206;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_77:
				num = (short)433389578;
				num2 = (int)((global::System.IntPtr)num);
			}
			return num3;
		}

		// Token: 0x0600D0B2 RID: 53426 RVA: 0x00C32754 File Offset: 0x00C30954
		public static double getToneBasedOnCodeIndex(int iIndex)
		{
			switch (0)
			{
			case 0:
				goto IL_1C;
			}
			int num;
			short num2;
			double result;
			for (;;)
			{
				IL_0A:
				switch (num)
				{
				case 0:
				{
					num2 = (short)1605951755;
					short num3 = num2;
					num2 = (short)1827594507;
					switch ((num3 == num2) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_8C;
					default:
						goto IL_104;
					}
					break;
				}
				case 1:
					if (iIndex <= 139)
					{
						num2 = (short)1045954562;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					return result;
				case 2:
					num2 = (short)1460731905;
					if (num2 != 0)
					{
					}
					result = global::ConstraintHelper.UtilityMack.i[iIndex - 2];
					goto IL_8C;
				}
				goto IL_1C;
				IL_8C:
				num2 = (short)1477443584;
				short num4 = num2;
				num2 = (short)1621360640;
				num = (int)((global::System.IntPtr)num2);
			}
			IL_104:
			num2 = (short)1409220608;
			if (num2 != 0)
			{
			}
			return result;
			IL_1C:
			result = 1.0;
			num2 = (short)723058689;
			num = (int)((global::System.IntPtr)num2);
			goto IL_0A;
		}

		// Token: 0x0600D0B3 RID: 53427 RVA: 0x00C32880 File Offset: 0x00C30A80
		public static bool FreqRanageIsWithInFCCExceptionRangeList(int freqStart, int FreqEnd)
		{
			short num = (short)788791297;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				global::System.Collections.Generic.List<global::ConstraintHelper.UtilityMack.FCCExceptionRange>.Enumerator enumerator;
				switch (num2)
				{
				case 0:
					IL_1B5:
					try
					{
						num = (short)1568669703;
						num2 = (int)((global::System.IntPtr)num);
						bool result;
						for (;;)
						{
							switch (num2)
							{
							case 0:
							{
								global::ConstraintHelper.UtilityMack.FCCExceptionRange fccexceptionRange;
								if (FreqEnd <= fccexceptionRange.FreqEnd)
								{
									num = (short)1081999363;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								break;
							}
							case 1:
								num = (short)1614151680;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							case 2:
							{
								global::ConstraintHelper.UtilityMack.FCCExceptionRange fccexceptionRange;
								if (freqStart >= fccexceptionRange.FreqStart)
								{
									num = (short)995885057;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								break;
							}
							case 3:
								result = true;
								num = (short)1435303944;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							case 4:
								num = (short)1895890950;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							case 5:
							{
								if (!enumerator.MoveNext())
								{
									num = (short)553123844;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								global::ConstraintHelper.UtilityMack.FCCExceptionRange fccexceptionRange = enumerator.Current;
								num = (short)49938434;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							case 6:
								goto IL_181;
							case 7:
								switch (0)
								{
								case 0:
									goto IL_9C;
								}
								continue;
							case 8:
								goto IL_12B;
							}
							IL_DA:
							num = (short)1962016773;
							num2 = (int)((global::System.IntPtr)num);
							continue;
							IL_9C:
							goto IL_DA;
						}
						IL_12B:
						return result;
						IL_181:
						goto IL_1BA;
					}
					finally
					{
						((global::System.IDisposable)enumerator).Dispose();
					}
					goto IL_191;
				case 1:
					switch (0)
					{
					case 0:
						goto IL_30;
					}
					continue;
				case 2:
					goto IL_191;
				}
				IL_30:
				if (global::ConstraintHelper.UtilityMack.TrunkingExceptionRangeList != null)
				{
					num = (short)114425858;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				goto IL_1BA;
				IL_191:
				enumerator = global::ConstraintHelper.UtilityMack.TrunkingExceptionRangeList.GetEnumerator();
				num = (short)165478400;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_1BA:
				num = (short)1317732352;
				short num3 = num;
				num = (short)966560923;
				short num4 = num;
				num = (short)1573686427;
				switch ((num4 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					goto IL_1B5;
				default:
					goto IL_219;
				}
			}
			IL_219:
			num = (short)545849344;
			if (num != 0)
			{
			}
			num = (short)913375233;
			if (num != 0)
			{
			}
			return false;
		}

		// Token: 0x0600D0B4 RID: 53428 RVA: 0x00C32B04 File Offset: 0x00C30D04
		public static void CalculateNewIPFieldsValidity(global::AcpCommonLib.IAcpField fld = null)
		{
			switch (0)
			{
			case 0:
				goto IL_28;
			}
			int num;
			global::Motorola.MackinawCPS.CoreFeatures.RadioWide.Bluetooth bluetooth;
			global::Motorola.MackinawCPS.CoreFeatures.RadioWide.RadioWide radioWide;
			short num2;
			for (;;)
			{
				IL_0A:
				switch (num)
				{
				case 0:
					bluetooth.RadWideBluetoothBluetoothPANNetworkAddress_41983.CalculateValidity();
					goto IL_7C;
				case 1:
					goto IL_94;
				case 2:
					bluetooth = radioWide.Bluetooth;
					num2 = (short)800718851;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 3:
				{
					num2 = (short)446234624;
					short num3 = num2;
					num2 = (short)1721404204;
					short num4 = num2;
					num2 = (short)216369964;
					switch ((num4 == num2) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_7C;
					default:
						num2 = (short)464846848;
						if (num2 != 0)
						{
						}
						goto IL_99;
					}
					break;
				}
				case 4:
					if (radioWide != null)
					{
						num2 = (short)1042874370;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_99;
				case 5:
					num2 = (short)375390209;
					if (num2 != 0)
					{
					}
					if (bluetooth != null)
					{
						num2 = (short)269287424;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_191;
				}
				goto IL_28;
				IL_7C:
				num2 = (short)473366529;
				num = (int)((global::System.IntPtr)num2);
				continue;
				IL_99:
				num2 = (short)402522117;
				num = (int)((global::System.IntPtr)num2);
			}
			IL_94:
			IL_191:
			(global::AcpCommonLib.FeatureManager.GetFeature(2028)[0] as global::Motorola.MackinawCPS.CoreFeatures.DataWide.DataWide).General.DataWideGeneralInternalRadioSubnet_A42073.CalculateValidity();
			return;
			IL_28:
			bluetooth = null;
			radioWide = (global::AcpCommonLib.FeatureManager.GetFeature(2045)[0] as global::Motorola.MackinawCPS.CoreFeatures.RadioWide.RadioWide);
			num2 = (short)739049476;
			num = (int)((global::System.IntPtr)num2);
			goto IL_0A;
		}

		// Token: 0x0600D0B5 RID: 53429 RVA: 0x00C32CC8 File Offset: 0x00C30EC8
		public static bool CheckIPConflictionWithAllIPs(global::AcpCommonLib.IAcpField fld)
		{
			int a_ = 8;
			short num = (short)1115422720;
			int num2 = (int)num;
			switch (num2)
			{
			default:
			{
				switch (0)
				{
				case 0:
					goto IL_115;
				}
				global::System.Collections.Generic.List<global::System.Net.IPAddress> list;
				global::Motorola.MackinawCPS.CoreFeatures.DataWide.General general;
				global::Motorola.MackinawCPS.CoreFeatures.DataWide.DataWide dataWide;
				for (;;)
				{
					IL_32:
					global::System.Collections.Generic.IEnumerator<global::AcpBusinessLayer.FeatureNode> enumerator2;
					switch (num2)
					{
					case 0:
						list.Add(new global::System.Net.IPAddress(general.DataWideGeneralBTDUNSUIPAddress_A41120));
						num = (short)1929838603;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 1:
						num = (short)1414856740;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 2:
						goto IL_81F;
					case 3:
						list.Add(new global::System.Net.IPAddress(general.DataWideGeneralBTDUNPeerIPAddress_A41123));
						num = (short)1839136790;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 4:
						goto IL_E98;
					case 5:
					{
						global::Motorola.MackinawCPS.CoreFeatures.RadioWide.Bluetooth bluetooth;
						if (bluetooth != null)
						{
							num = (short)233439248;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_10C5;
					}
					case 6:
						goto IL_658;
					case 7:
						goto IL_769;
					case 8:
					{
						byte[] addressBytes = new global::System.Net.IPAddress(dataWide.General.DataWideGeneralInternalRadioSubnet_A42073.Value).GetAddressBytes();
						global::System.Collections.Generic.List<global::System.Net.IPAddress>.Enumerator enumerator = list.GetEnumerator();
						num = (short)1050411038;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 9:
						if (!general.DataWideGeneralMobileSubIPAddress_A41819.HiddenStatic)
						{
							num = (short)1205731357;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_69B;
					case 10:
						goto IL_107E;
					case 11:
						goto IL_217;
					case 12:
						goto IL_E98;
					case 13:
						num = (short)1478033460;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 14:
						if (!general.DataWideGeneralBTDUNSUIPAddress_A41120.HiddenStatic)
						{
							num = (short)2067202048;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_217;
					case 15:
					{
						global::Motorola.MackinawCPS.CoreFeatures.RadioWide.Bluetooth bluetooth;
						if (bluetooth != null)
						{
							num = (short)453705776;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_4CD;
					}
					case 16:
						num = (short)355139625;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 17:
						if (!general.DataWideGeneralBTDUNPeerIPAddress_A41123.HiddenStatic)
						{
							num = (short)980549635;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_517;
					case 18:
					{
						global::Motorola.MackinawCPS.CoreFeatures.RadioWide.Bluetooth bluetooth;
						if (!bluetooth.RadWideBluetoothBluetoothPANNetworkAddress_41983.HiddenStatic)
						{
							num = (short)1942945805;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_4CD;
					}
					case 19:
						if (fld.Name == global::AllFeatures.CodeplugGuid.b("跈꫊만껎蛐뫒뇔닖默뻚돜뫞鏠苢觤껦蟨鿪裬鷮鿰鋲駴ꗶ飸鿺铼郾刀瘂朄椆氈缊刌与┐ℒ└‖⨘", a_))
						{
							num = (short)1243348993;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return true;
					case 20:
						if (!general.DataWideGeneralSubscriberIPAddress1_A9222.HiddenStatic)
						{
							num = (short)769720353;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_107E;
					case 21:
						num = (short)905641989;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 22:
						goto IL_517;
					case 23:
						if (fld.Name == global::AllFeatures.CodeplugGuid.b("鯈꫊꧌风룐럒냔闖뗘껚룜ꯞ軠賢釤迦ꯨ蟪飬諮藰鳲髴菶釸꯺볼뇾伀昂焄瀆昈礊昌与甐眒朔爖樘栚䈜⬞ဠᨢᴤᐦ", a_))
						{
							num = (short)1347551253;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_10C5;
					case 24:
						goto IL_E33;
					case 25:
						num = (short)1386872833;
						if (num != 0)
						{
						}
						if (general != null)
						{
							num = (short)28377119;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_861;
					case 26:
						goto IL_DC9;
					case 27:
						goto IL_69B;
					case 28:
						num = (short)1689190453;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 29:
						list.Add(new global::System.Net.IPAddress(general.DataWideGeneralMobileSubIPAddress_A41819));
						num = (short)497680411;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 30:
						try
						{
							num = (short)1795686409;
							num2 = (int)((global::System.IntPtr)num);
							bool result;
							for (;;)
							{
								switch (num2)
								{
								case 0:
									num = (short)108789765;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 1:
								{
									byte[] addressBytes;
									byte[] addressBytes2;
									if (addressBytes[3] == addressBytes2[0])
									{
										num = (short)1945763840;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									break;
								}
								case 2:
								{
									global::System.Collections.Generic.List<global::System.Net.IPAddress>.Enumerator enumerator;
									if (!enumerator.MoveNext())
									{
										num = (short)1292828679;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									byte[] addressBytes2 = enumerator.Current.GetAddressBytes();
									num = (short)495910913;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 3:
									goto IL_3C1;
								case 4:
									goto IL_3BC;
								case 5:
								{
									byte[] addressBytes;
									byte[] addressBytes2;
									if (addressBytes[2] == addressBytes2[1])
									{
										num = (short)515375107;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									break;
								}
								case 6:
									goto IL_4BA;
								case 7:
									num = (short)1426325510;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 8:
									result = false;
									num = (short)678494212;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 9:
									switch (0)
									{
									case 0:
										goto IL_324;
									}
									continue;
								case 10:
								{
									num = (short)31113103;
									short num3 = num;
									num = (short)1240317839;
									switch ((num3 == num) ? 1 : 0)
									{
									case 0:
									case 2:
										goto IL_3C1;
									default:
									{
										num = (short)1804795904;
										if (num != 0)
										{
										}
										byte[] addressBytes;
										byte[] addressBytes2;
										if (addressBytes[1] == addressBytes2[2])
										{
											num = (short)1405419528;
											num2 = (int)((global::System.IntPtr)num);
											continue;
										}
										break;
									}
									}
									break;
								}
								}
								IL_35E:
								num = (short)840237058;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								IL_324:
								goto IL_35E;
								IL_3C1:
								num = (short)293142538;
								num2 = (int)((global::System.IntPtr)num);
							}
							IL_3BC:
							return result;
							IL_4BA:
							return true;
						}
						finally
						{
							global::System.Collections.Generic.List<global::System.Net.IPAddress>.Enumerator enumerator;
							((global::System.IDisposable)enumerator).Dispose();
						}
						goto IL_4CD;
					case 31:
						num = (short)295370772;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 32:
						general = dataWide.General;
						num = (short)261095448;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 33:
						list.Add(new global::System.Net.IPAddress(general.DataWideGeneralSubscriberIPAddress1_A9222));
						num = (short)2089746442;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 34:
					{
						bool result;
						try
						{
							num = (short)244318211;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								switch (num2)
								{
								case 0:
								{
									global::System.Collections.Generic.List<global::System.Net.IPAddress>.Enumerator enumerator;
									if (!enumerator.MoveNext())
									{
										num = (short)1780482049;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									global::System.Net.IPAddress obj = enumerator.Current;
									num = (short)507641861;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 1:
									num = (short)1681195014;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 2:
									goto IL_122B;
								case 3:
									switch (0)
									{
									case 0:
										goto IL_11DA;
									}
									continue;
								case 4:
									result = false;
									num = (short)926744578;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 5:
								{
									global::System.Net.IPAddress obj;
									global::System.Net.IPAddress ipaddress;
									if (ipaddress.Equals(obj))
									{
										num = (short)131076;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									break;
								}
								case 6:
									goto IL_128F;
								}
								IL_11DC:
								num = (short)1453260800;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								IL_11DA:
								goto IL_11DC;
							}
							IL_122B:
							return result;
							IL_128F:
							goto IL_F37;
						}
						finally
						{
							global::System.Collections.Generic.List<global::System.Net.IPAddress>.Enumerator enumerator;
							((global::System.IDisposable)enumerator).Dispose();
						}
						return result;
						IL_F37:
						int num4;
						num4++;
						num = (short)730791938;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 35:
					{
						num = (short)423690240;
						short num5 = num;
						global::Motorola.MackinawCPS.CoreFeatures.RadioWide.Bluetooth bluetooth;
						byte[] addressBytes3 = new global::System.Net.IPAddress(bluetooth.RadWideBluetoothBluetoothPANNetworkAddress_41983.Value).GetAddressBytes();
						int num6 = 0;
						num = (short)1968308228;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 36:
						if (!dataWide.General.DataWideGeneralInternalRadioSubnet_A42073.HiddenStatic)
						{
							num = (short)1019478024;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return true;
					case 37:
						list.Add(new global::System.Net.IPAddress(general.DataWideGeneralPeerIPAddress1_A8524));
						num = (short)1300561926;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 38:
						if (dataWide != null)
						{
							num = (short)2066743328;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_E33;
					case 39:
						goto IL_81F;
					case 40:
						list.Add(new global::System.Net.IPAddress(general.DataWideGeneralDVRIPAddress_A41818));
						num = (short)1430519855;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 41:
					{
						global::Motorola.MackinawCPS.CoreFeatures.RadioWide.Bluetooth bluetooth;
						if (!bluetooth.RadWideBluetoothBluetoothPANNetworkAddress_41983.HiddenStatic)
						{
							num = (short)717488174;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_10C5;
					}
					case 42:
					{
						int num4;
						if (num4 > 10)
						{
							num = (short)490405939;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						byte[] addressBytes4;
						global::System.Net.IPAddress ipaddress = new global::System.Net.IPAddress(new byte[]
						{
							addressBytes4[0],
							addressBytes4[1],
							addressBytes4[2],
							(byte)((int)addressBytes4[3] + num4)
						});
						global::System.Collections.Generic.List<global::System.Net.IPAddress>.Enumerator enumerator = list.GetEnumerator();
						num = (short)1549074466;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 43:
						goto IL_4CD;
					case 44:
						if (!general.DataWideGeneralDVRIPAddress_A41818.HiddenStatic)
						{
							num = (short)1999372328;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_861;
					case 45:
					{
						int num6;
						if (num6 > 10)
						{
							num = (short)2076835883;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						byte[] addressBytes3;
						byte[] address = new byte[]
						{
							addressBytes3[0],
							addressBytes3[1],
							addressBytes3[2],
							(byte)((int)addressBytes3[3] + num6)
						};
						list.Add(new global::System.Net.IPAddress(address));
						num6++;
						num = (short)516096012;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 46:
					{
						global::Motorola.MackinawCPS.CoreFeatures.RadioWide.Bluetooth bluetooth;
						global::System.Net.IPAddress ipaddress2 = new global::System.Net.IPAddress(bluetooth.RadWideBluetoothBluetoothPANNetworkAddress_41983.Value);
						ipaddress2.GetAddressBytes();
						byte[] addressBytes4 = ipaddress2.GetAddressBytes();
						int num4 = 0;
						num = (short)62914599;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 47:
						goto IL_861;
					case 48:
						num = (short)499646482;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 49:
						if (!dataWide.General.DataWideGeneralInternalRadioSubnet_A42073.HiddenStatic)
						{
							num = (short)2082996252;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_769;
					case 50:
						if (!general.DataWideGeneralPeerIPAddress1_A8524.HiddenStatic)
						{
							num = (short)1624834085;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_658;
					case 51:
						return true;
					case 52:
						if (fld.Name != global::AllFeatures.CodeplugGuid.b("鯈꫊꧌风룐럒냔闖뗘껚룜ꯞ軠賢釤迦ꯨ蟪飬諮藰鳲髴菶釸꯺볼뇾伀昂焄瀆昈礊昌与甐眒朔爖樘栚䈜⬞ဠᨢᴤᐦ", a_))
						{
							num = (short)1084948515;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_4CD;
					case 53:
						if (fld.Name != global::AllFeatures.CodeplugGuid.b("跈꫊만껎蛐뫒뇔닖默뻚돜뫞鏠苢觤껦蟨鿪裬鷮鿰鋲駴ꗶ飸鿺铼郾刀瘂朄椆氈缊刌与┐ℒ└‖⨘", a_))
						{
							num = (short)1758527514;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_769;
					case 54:
					{
						try
						{
							num = (short)644284424;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								switch (num2)
								{
								case 0:
									goto IL_D56;
								case 1:
								{
									global::Motorola.MackinawCPS.CoreFeatures.DataProfiles.DataProfiles dataProfiles;
									list.Add(new global::System.Net.IPAddress(dataProfiles.General.DataProfGeneralSubscriberIPAddress_A21157));
									num = (short)821690382;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 2:
									goto IL_B2B;
								case 3:
									goto IL_A12;
								case 4:
								{
									global::Motorola.MackinawCPS.CoreFeatures.DataProfiles.DataProfiles dataProfiles;
									if (!dataProfiles.Features.DataProfFeaturesLocServerIPAddr_A42333.HiddenStatic)
									{
										num = (short)1960771596;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									break;
								}
								case 5:
									goto IL_A96;
								case 6:
								{
									global::Motorola.MackinawCPS.CoreFeatures.DataProfiles.DataProfiles dataProfiles;
									if (!dataProfiles.General.DataProfGeneralSubscriberIPAddress_A21157.HiddenStatic)
									{
										num = (short)504233985;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									goto IL_955;
								}
								case 7:
									goto IL_B75;
								case 8:
									switch (0)
									{
									case 0:
										goto IL_950;
									}
									continue;
								case 9:
								{
									global::Motorola.MackinawCPS.CoreFeatures.DataProfiles.DataProfiles dataProfiles;
									list.Add(new global::System.Net.IPAddress(dataProfiles.General.DataProfGeneralMobileComputerIPAddress_A8523));
									num = (short)1371537415;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 10:
								{
									global::Motorola.MackinawCPS.CoreFeatures.DataProfiles.DataProfiles dataProfiles;
									if (!dataProfiles.General.DataProfGeneralSubscriberAirInterfaceIPAddress_A9220.HiddenStatic)
									{
										num = (short)2111045650;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									goto IL_AE2;
								}
								case 12:
								{
									global::Motorola.MackinawCPS.CoreFeatures.DataProfiles.DataProfiles dataProfiles;
									list.Add(new global::System.Net.IPAddress(dataProfiles.Features.DataProfFeaturesLocServerIPAddr_A42333));
									num = (short)706609163;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 13:
								{
									global::Motorola.MackinawCPS.CoreFeatures.DataProfiles.DataProfiles dataProfiles;
									list.Add(new global::System.Net.IPAddress(dataProfiles.General.DataProfilesGeneralBTDUNSUIPAddress_A41126));
									num = (short)1697447938;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 14:
									goto IL_955;
								case 15:
								{
									global::Motorola.MackinawCPS.CoreFeatures.DataProfiles.DataProfiles dataProfiles;
									if (!dataProfiles.General.DataProfilesGeneralBTDUNPeerIPAddress_A41127.HiddenStatic)
									{
										num = (short)654311445;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									goto IL_A12;
								}
								case 16:
								{
									global::Motorola.MackinawCPS.CoreFeatures.DataProfiles.DataProfiles dataProfiles;
									list.Add(new global::System.Net.IPAddress(dataProfiles.Features.DataProfFeaturesAutomaticRegistrationServerAddress_A7524));
									num = (short)1367146501;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 17:
								{
									global::Motorola.MackinawCPS.CoreFeatures.DataProfiles.DataProfiles dataProfiles;
									if (!dataProfiles.Features.DataProfFeaturesAutomaticRegistrationServerAddress_A7524.HiddenStatic)
									{
										num = (short)2054881296;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									goto IL_A96;
								}
								case 18:
								{
									global::Motorola.MackinawCPS.CoreFeatures.DataProfiles.DataProfiles dataProfiles;
									list.Add(new global::System.Net.IPAddress(dataProfiles.General.DataProfGeneralSubscriberAirInterfaceIPAddress_A9220));
									num = (short)397672467;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 19:
									goto IL_AE2;
								case 20:
									num = (short)1734868992;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 21:
								{
									global::Motorola.MackinawCPS.CoreFeatures.DataProfiles.DataProfiles dataProfiles;
									list.Add(new global::System.Net.IPAddress(dataProfiles.General.DataProfilesGeneralBTDUNPeerIPAddress_A41127));
									num = (short)199688195;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 22:
								{
									if (!enumerator2.MoveNext())
									{
										num = (short)1501626388;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									global::Motorola.MackinawCPS.CoreFeatures.DataProfiles.DataProfiles dataProfiles = enumerator2.Current as global::Motorola.MackinawCPS.CoreFeatures.DataProfiles.DataProfiles;
									num = (short)416350214;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 23:
								{
									global::Motorola.MackinawCPS.CoreFeatures.DataProfiles.DataProfiles dataProfiles;
									if (!dataProfiles.General.DataProfGeneralMobileComputerIPAddress_A8523.HiddenStatic)
									{
										num = (short)719126537;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									goto IL_B75;
								}
								case 24:
								{
									global::Motorola.MackinawCPS.CoreFeatures.DataProfiles.DataProfiles dataProfiles;
									if (!dataProfiles.General.DataProfilesGeneralBTDUNSUIPAddress_A41126.HiddenStatic)
									{
										num = (short)1149829133;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									goto IL_B2B;
								}
								}
								goto IL_950;
								IL_955:
								num = (short)121307159;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								IL_A12:
								num = (short)1879638026;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								IL_A96:
								num = (short)1119354884;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								IL_AE2:
								num = (short)15138833;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								IL_B2B:
								num = (short)297730063;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								IL_B75:
								num = (short)2019754008;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								IL_C31:
								num = (short)484900886;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								IL_950:
								goto IL_C31;
							}
							IL_D56:
							goto IL_5A8;
						}
						finally
						{
							num = (short)522190848;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								switch (num2)
								{
								case 0:
									switch (0)
									{
									case 0:
										goto IL_D8D;
									}
									continue;
								case 1:
									enumerator2.Dispose();
									num = (short)583991298;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 2:
									goto IL_DC6;
								}
								IL_D8D:
								if (enumerator2 == null)
								{
									break;
								}
								num = (short)563806209;
								num2 = (int)((global::System.IntPtr)num);
							}
							IL_DC6:;
						}
						goto IL_DC9;
						IL_5A8:
						global::Motorola.MackinawCPS.CoreFeatures.RadioWide.Bluetooth bluetooth = (global::AcpCommonLib.FeatureManager.GetFeature(2045)[0] as global::Motorola.MackinawCPS.CoreFeatures.RadioWide.RadioWide).Bluetooth;
						num = (short)1057357839;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					}
					goto IL_115;
					IL_217:
					num = (short)901054481;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_4CD:
					num = (short)1962934321;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_517:
					num = (short)1874984969;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_658:
					num = (short)1407451150;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_69B:
					num = (short)165347372;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_769:
					num = (short)646578199;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_81F:
					num = (short)1416953898;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_861:
					enumerator2 = ((global::AcpBusinessLayer.Recordset)global::AcpCommonLib.FeatureManager.GetFeature(2054)).GetEnumerator();
					num = (short)1401749558;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_DC9:
					byte[] addressBytes5 = new global::System.Net.IPAddress(dataWide.General.DataWideGeneralInternalRadioSubnet_A42073.Value).GetAddressBytes();
					byte[] address2 = new byte[]
					{
						addressBytes5[3],
						addressBytes5[2],
						addressBytes5[1],
						addressBytes5[0]
					};
					list.Add(new global::System.Net.IPAddress(address2));
					num = (short)9633799;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_E33:
					num = (short)1537343513;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_E98:
					num = (short)1979121709;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_107E:
					num = (short)435683378;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_10C5:
					num = (short)125566995;
					num2 = (int)((global::System.IntPtr)num);
				}
				return true;
				IL_115:
				list = new global::System.Collections.Generic.List<global::System.Net.IPAddress>();
				dataWide = (global::AcpCommonLib.FeatureManager.GetFeature(2028)[0] as global::Motorola.MackinawCPS.CoreFeatures.DataWide.DataWide);
				general = null;
				num = (short)864288806;
				num2 = (int)((global::System.IntPtr)num);
				goto IL_32;
			}
			}
		}

		// Token: 0x0600D0B6 RID: 53430 RVA: 0x00C33FC8 File Offset: 0x00C321C8
		public static bool CheckIPConflictionWithZoneCloneFeature(global::System.Net.IPAddress ipAddress)
		{
			switch (0)
			{
			case 0:
				goto IL_38;
			}
			int num;
			short num2;
			global::Motorola.MackinawCPS.CoreFeatures.RadioWide.RadioWide radioWide;
			for (;;)
			{
				IL_0A:
				switch (num)
				{
				case 0:
				{
					byte[] addressBytes;
					if (addressBytes[0] == 169)
					{
						num2 = (short)539885572;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					return true;
				}
				case 1:
					return false;
				case 2:
				{
					num2 = (short)959184896;
					short num3 = num2;
					num2 = (short)1399758560;
					short num4 = num2;
					num2 = (short)1417387744;
					switch ((num4 == num2) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_12F;
					default:
						num2 = (short)951844864;
						if (num2 != 0)
						{
						}
						num2 = (short)1301676040;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					break;
				}
				case 3:
				{
					byte[] addressBytes;
					if (addressBytes[1] == 254)
					{
						num2 = (short)804323329;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					return true;
				}
				case 4:
					goto IL_12F;
				case 5:
					if (radioWide.Features.RadWideFeaturesZoneCloneEnable_43130.Value)
					{
						num2 = (short)1895104521;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					return true;
				case 6:
					if (radioWide != null)
					{
						num2 = (short)1966669826;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					return true;
				case 7:
					num2 = (short)1091895301;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 8:
					if (radioWide.Features.RadWideFeaturesZoneCloneEnable_43130 != null)
					{
						num2 = (short)1394671623;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					return true;
				case 9:
				{
					num2 = (short)1081344001;
					if (num2 != 0)
					{
					}
					byte[] addressBytes = ipAddress.GetAddressBytes();
					num2 = (short)618987520;
					num = (int)((global::System.IntPtr)num2);
					continue;
				}
				}
				goto IL_38;
				IL_12F:
				num2 = (short)1364000771;
				num = (int)((global::System.IntPtr)num2);
			}
			return false;
			IL_38:
			radioWide = (global::AcpCommonLib.FeatureManager.GetFeature(2045)[0] as global::Motorola.MackinawCPS.CoreFeatures.RadioWide.RadioWide);
			num2 = (short)1654259718;
			num = (int)((global::System.IntPtr)num2);
			goto IL_0A;
		}

		// Token: 0x0600D0B7 RID: 53431 RVA: 0x00C34208 File Offset: 0x00C32408
		public static bool FreqValueIsFCCExceptionPoints(int inputFrequency)
		{
			short num = (short)1612447744;
			int num2 = (int)num;
			switch (num2)
			{
			default:
				switch (0)
				{
				case 0:
					goto IL_4A;
				}
				for (;;)
				{
					IL_27:
					global::System.Collections.Generic.List<global::ConstraintHelper.UtilityMack.FCCExceptionRange>.Enumerator enumerator;
					switch (num2)
					{
					case 0:
					{
						num = (short)402522112;
						short num3 = num;
						num = (short)1596325890;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 1:
						try
						{
							num = (short)2136801285;
							num2 = (int)((global::System.IntPtr)num);
							bool result;
							for (;;)
							{
								switch (num2)
								{
								case 0:
									num = (short)87818247;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 1:
								{
									global::ConstraintHelper.UtilityMack.FCCExceptionRange fccexceptionRange;
									if (inputFrequency >= fccexceptionRange.FreqStart)
									{
										num = (short)1117519872;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									break;
								}
								case 2:
									goto IL_F4;
								case 3:
								{
									if (!enumerator.MoveNext())
									{
										num = (short)1335230468;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									global::ConstraintHelper.UtilityMack.FCCExceptionRange fccexceptionRange = enumerator.Current;
									num = (short)2071265281;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 4:
									num = (short)1645608968;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 5:
									switch (0)
									{
									case 0:
										goto IL_DB;
									}
									continue;
								case 6:
									result = true;
									num = (short)1465712642;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 7:
								{
									global::ConstraintHelper.UtilityMack.FCCExceptionRange fccexceptionRange;
									if (inputFrequency <= fccexceptionRange.FreqEnd)
									{
										num = (short)72941574;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									break;
								}
								case 8:
									goto IL_1DA;
								}
								IL_141:
								num = (short)636026883;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								IL_DB:
								goto IL_141;
							}
							IL_F4:
							return result;
							IL_1DA:
							goto IL_215;
						}
						finally
						{
							((global::System.IDisposable)enumerator).Dispose();
						}
						goto IL_1EA;
					case 2:
						if (global::ConstraintHelper.UtilityMack.ConventionalExceptionPointList.Exists(delegate(int x)
						{
							short num5 = (short)1050230496;
							short num6 = num5;
							num5 = (short)294207200;
							switch (num6 == num5)
							{
							}
							num5 = (short)573571072;
							if (num5 != 0)
							{
							}
							num5 = (short)1686044673;
							if (num5 != 0)
							{
							}
							num5 = (short)26148864;
							short num7 = num5;
							return x == inputFrequency;
						}))
						{
							num = (short)992018437;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_2D8;
					case 3:
						if (global::ConstraintHelper.UtilityMack.ConventionalExceptionPointList != null)
						{
							num = (short)404488192;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_2D8;
					case 4:
						if (global::ConstraintHelper.UtilityMack.ConventionalExceptionRangeList != null)
						{
							num = (short)307888134;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_215;
					case 5:
						return true;
					case 6:
						num = (short)894435329;
						if (num != 0)
						{
						}
						goto IL_1EA;
					}
					goto IL_4A;
					IL_1EA:
					enumerator = global::ConstraintHelper.UtilityMack.ConventionalExceptionRangeList.GetEnumerator();
					num = (short)1499463681;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_2D8:
					num = (short)1501298692;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_215:
					num = (short)1671187837;
					short num4 = num;
					num = (short)621038973;
					switch ((num4 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_2D8;
					default:
						goto IL_249;
					}
				}
				IL_249:
				num = (short)769720320;
				if (num != 0)
				{
				}
				return false;
				IL_4A:
				num = (short)1402994691;
				num2 = (int)((global::System.IntPtr)num);
				goto IL_27;
			}
		}

		// Token: 0x0600D0B8 RID: 53432 RVA: 0x00C34574 File Offset: 0x00C32774
		public static global::AcpCommonLib.IAcpFeatureNode GetZoneChannelPersonality(int zoneIndex, int channelIndex, out int? type)
		{
			short num = (short)1297022976;
			int num2 = (int)num;
			switch (num2)
			{
			default:
			{
				switch (0)
				{
				case 0:
					goto IL_5E;
				}
				int index;
				for (;;)
				{
					IL_27:
					switch (num2)
					{
					case 0:
					{
						int? num3;
						int num4;
						if (!(num3.GetValueOrDefault() == num4 & num3 != null))
						{
							num3 = type;
							num4 = 0;
							num = (short)1107886083;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)1253833020;
						short num5 = num;
						num = (short)230816060;
						switch ((num5 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_1BA;
						default:
							num = (short)1272315904;
							if (num != 0)
							{
							}
							num = (short)952369158;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						break;
					}
					case 1:
					{
						global::Motorola.MackinawCPS.CoreFeatures.ZoneChannelAssignment.ZoneChannelAssignment zoneChannelAssignment;
						if (channelIndex >= zoneChannelAssignment.Channels.EmbeddedRecset.Count)
						{
							num = (short)334757899;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						global::Motorola.MackinawCPS.CoreFeatures.ZoneChannelAssignment.ChannelAssignmentListInner channelAssignmentListInner = zoneChannelAssignment.Channels.EmbeddedRecset[channelIndex] as global::Motorola.MackinawCPS.CoreFeatures.ZoneChannelAssignment.ChannelAssignmentListInner;
						type = new int?(channelAssignmentListInner.ChannelAssignmentListInnerSection.ZnChanCfgChannelsChannelType_A22241.Value);
						index = channelAssignmentListInner.ChannelAssignmentListInnerSection.ZnChanCfgChannelsPersonality_A8698.Value - 1;
						int? num3 = type;
						int num4 = 1;
						goto IL_1BA;
					}
					case 2:
					{
						if (channelIndex < 0)
						{
							num = (short)622460932;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						global::AcpCommonLib.IAcpRecordset feature = global::AcpCommonLib.FeatureManager.GetFeature(2051);
						num = (short)2029191178;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 3:
					{
						int? num3;
						int num4;
						if (num3.GetValueOrDefault() == num4 & num3 != null)
						{
							num = (short)1551040517;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_32F;
					}
					case 4:
						goto IL_165;
					case 5:
						goto IL_127;
					case 6:
						goto IL_24E;
					case 7:
						num = (short)2144272386;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 8:
						num = (short)753336321;
						if (num != 0)
						{
						}
						if (zoneIndex >= 0)
						{
							num = (short)1467154439;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_D2;
					case 9:
						goto IL_2D4;
					case 10:
					{
						global::AcpCommonLib.IAcpRecordset feature;
						if (zoneIndex > feature.Count)
						{
							num = (short)720633865;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						global::Motorola.MackinawCPS.CoreFeatures.ZoneChannelAssignment.ZoneChannelAssignment zoneChannelAssignment = feature[zoneIndex] as global::Motorola.MackinawCPS.CoreFeatures.ZoneChannelAssignment.ZoneChannelAssignment;
						num = (short)1445396481;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 11:
						goto IL_32A;
					}
					goto IL_5E;
					IL_1BA:
					num = (short)400621568;
					num2 = (int)((global::System.IntPtr)num);
				}
				IL_D2:
				return null;
				IL_127:
				return global::AcpCommonLib.FeatureManager.GetFeature(2059)[index];
				IL_165:
				goto IL_D2;
				IL_24E:
				num = (short)1591803904;
				short num6 = num;
				return global::AcpCommonLib.FeatureManager.GetFeature(2072)[index];
				IL_2D4:
				return null;
				IL_32A:
				return null;
				IL_32F:
				return null;
				IL_5E:
				type = null;
				num = (short)169148424;
				num2 = (int)((global::System.IntPtr)num);
				goto IL_27;
			}
			}
		}

		// Token: 0x0600D0B9 RID: 53433 RVA: 0x00C348B4 File Offset: 0x00C32AB4
		public static bool ChannelHasHazardZoneMode(int zoneIndex, int channelIndex)
		{
			short num = (short)151257088;
			int num2 = (int)num;
			switch (num2)
			{
			default:
			{
				switch (0)
				{
				case 0:
					goto IL_5F;
				}
				int? num3;
				global::AcpCommonLib.IAcpFeatureNode zoneChannelPersonality;
				bool? flag;
				global::Motorola.MackinawCPS.CoreFeatures.TrunkingPersonality.Features features;
				for (;;)
				{
					IL_28:
					int? num4;
					int num5;
					switch (num2)
					{
					case 0:
						if (num3 == null)
						{
							num = (short)533331971;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num4 = num3;
						num5 = 1;
						num = (short)1883701249;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 1:
						if (num4.GetValueOrDefault() == num5 & num4 != null)
						{
							num = (short)1618739209;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_239;
					case 2:
						goto IL_2ED;
					case 3:
						goto IL_14F;
					case 4:
						if (zoneChannelPersonality != null)
						{
							num = (short)88342538;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return false;
					case 5:
						goto IL_2AE;
					case 6:
						if (num4.GetValueOrDefault() == num5 & num4 != null)
						{
							num = (short)479985675;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return false;
					case 7:
						goto IL_202;
					case 8:
					{
						global::Motorola.MackinawCPS.CoreFeatures.TrunkingPersonality.TrunkingPersonality trunkingPersonality = zoneChannelPersonality as global::Motorola.MackinawCPS.CoreFeatures.TrunkingPersonality.TrunkingPersonality;
						if (trunkingPersonality == null)
						{
							flag = null;
							num = (short)1870200834;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						features = trunkingPersonality.Features;
						if (features == null)
						{
							flag = null;
							num = (short)1965752325;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_161;
					}
					case 9:
						num = (short)1415184392;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 10:
						num = (short)1391132672;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 11:
					{
						num = (short)587771468;
						short num6 = num;
						num = (short)343584332;
						switch ((num6 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_239;
						default:
							num = (short)849018880;
							if (num != 0)
							{
							}
							num = (short)428933121;
							if (num != 0)
							{
							}
							num = (short)1180827655;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						break;
					}
					}
					goto IL_5F;
					IL_239:
					num4 = num3;
					num5 = 0;
					num = (short)429391878;
					num2 = (int)((global::System.IntPtr)num);
				}
				return false;
				IL_14F:
				return false;
				IL_161:
				bool? flag2 = new bool?(features.TrkPerFeaturesHazardZoneModePersonality.Value);
				goto IL_2B2;
				IL_202:
				num = (short)1976238080;
				short num7 = num;
				global::Motorola.MackinawCPS.CoreFeatures.ConventionalPersonality.ConventionalPersonality conventionalPersonality = zoneChannelPersonality as global::Motorola.MackinawCPS.CoreFeatures.ConventionalPersonality.ConventionalPersonality;
				return conventionalPersonality != null && conventionalPersonality.Features.CnvPerFeaturesHazardZoneModePersonality.Value;
				IL_2AE:
				flag2 = flag;
				IL_2B2:
				flag = flag2;
				return flag.GetValueOrDefault();
				IL_2ED:
				flag2 = flag;
				goto IL_2B2;
				IL_5F:
				zoneChannelPersonality = global::ConstraintHelper.UtilityMack.GetZoneChannelPersonality(zoneIndex, channelIndex, out num3);
				num = (short)2141388804;
				num2 = (int)((global::System.IntPtr)num);
				goto IL_28;
			}
			}
		}

		// Token: 0x0600D0BA RID: 53434 RVA: 0x00C34BB4 File Offset: 0x00C32DB4
		public static void ValidateRelatedPersonalities(global::AcpCommonLib.IAcpFeatureNode sourcePersonality, global::AcpCommonLib.IAcpFeatureNode sourceRevertPersonality)
		{
			short num = (short)1986068481;
			if (num != 0)
			{
			}
			num = (short)2031091712;
			int num2 = (int)num;
			switch (num2)
			{
			default:
			{
				switch (0)
				{
				case 0:
					goto IL_AF;
				}
				int num3;
				global::AcpCommonLib.IAcpRecordset feature;
				for (;;)
				{
					IL_50:
					int num4;
					switch (num2)
					{
					case 0:
					{
						if (num3 >= feature.Count)
						{
							num = (short)1288175618;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						global::Motorola.MackinawCPS.CoreFeatures.ConventionalPersonality.ConventionalPersonality conventionalPersonality = feature[num3] as global::Motorola.MackinawCPS.CoreFeatures.ConventionalPersonality.ConventionalPersonality;
						num = (short)110559248;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 1:
						goto IL_294;
					case 2:
					{
						global::AcpCommonLib.IAcpRecordset feature2 = global::AcpCommonLib.FeatureManager.GetFeature(2072);
						num4 = 0;
						num = (short)1542193153;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 3:
					{
						global::Motorola.MackinawCPS.CoreFeatures.ConventionalPersonality.ConventionalPersonality conventionalPersonality;
						if (conventionalPersonality != sourcePersonality)
						{
							num = (short)1876033540;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return;
					}
					case 4:
					{
						global::Motorola.MackinawCPS.CoreFeatures.ConventionalPersonality.ConventionalPersonality conventionalPersonality;
						conventionalPersonality.Features.CnvPerFeaturesHazardZoneModePersonality.CalculateValidity();
						num = (short)158466060;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 5:
						num = (short)525860877;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 6:
					{
						global::AcpCommonLib.IAcpRecordset feature2;
						if (num4 >= feature2.Count)
						{
							num = (short)1560281099;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						global::Motorola.MackinawCPS.CoreFeatures.TrunkingPersonality.TrunkingPersonality trunkingPersonality = feature2[num4] as global::Motorola.MackinawCPS.CoreFeatures.TrunkingPersonality.TrunkingPersonality;
						num = (short)400228372;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 7:
						num = (short)700973059;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 8:
					{
						global::Motorola.MackinawCPS.CoreFeatures.TrunkingPersonality.TrunkingPersonality trunkingPersonality;
						if (trunkingPersonality != sourcePersonality)
						{
							num = (short)1637679118;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return;
					}
					case 9:
					{
						num = (short)1944815217;
						short num5 = num;
						num = (short)1953400433;
						switch ((num5 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_363;
						default:
							num = (short)235274240;
							if (num != 0)
							{
							}
							num = (short)1506934792;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						break;
					}
					case 10:
						goto IL_2D8;
					case 11:
						return;
					case 12:
						goto IL_343;
					case 13:
					{
						global::Motorola.MackinawCPS.CoreFeatures.ConventionalPersonality.ConventionalPersonality conventionalPersonality;
						if (sourceRevertPersonality != conventionalPersonality)
						{
							num = (short)1343619079;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_435;
					}
					case 14:
					{
						global::Motorola.MackinawCPS.CoreFeatures.TrunkingPersonality.TrunkingPersonality trunkingPersonality;
						trunkingPersonality.Features.TrkPerFeaturesHazardZoneModePersonality.CalculateValidity();
						num = (short)2102722581;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 15:
						goto IL_2D8;
					case 16:
					{
						global::Motorola.MackinawCPS.CoreFeatures.ConventionalPersonality.ConventionalPersonality conventionalPersonality;
						int zoneIndex = conventionalPersonality.Signaling.CnvPerSignalingRevertZone_A13269.Value - 1;
						int channelIndex = conventionalPersonality.Signaling.CnvPerSignalingRevertChannel_A13267.Value - 1;
						int? num6;
						if (global::ConstraintHelper.UtilityMack.GetZoneChannelPersonality(zoneIndex, channelIndex, out num6) == sourcePersonality)
						{
							num = (short)1848377349;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_435;
					}
					case 17:
						goto IL_363;
					case 18:
						num = (short)1246953491;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 19:
					{
						global::Motorola.MackinawCPS.CoreFeatures.TrunkingPersonality.TrunkingPersonality trunkingPersonality;
						if (sourceRevertPersonality != trunkingPersonality)
						{
							num = (short)1078001673;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_345;
					}
					case 20:
					{
						global::Motorola.MackinawCPS.CoreFeatures.TrunkingPersonality.TrunkingPersonality trunkingPersonality;
						int zoneIndex2 = trunkingPersonality.General.TrkPerGeneralRevertZone_A41916.Value - 1;
						int channelIndex2 = trunkingPersonality.General.TrkPerGeneralRevertChannel_A41917.Value - 1;
						int? num6;
						if (global::ConstraintHelper.UtilityMack.GetZoneChannelPersonality(zoneIndex2, channelIndex2, out num6) == sourcePersonality)
						{
							num = (short)1012400146;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_345;
					}
					case 21:
						goto IL_3BB;
					}
					goto IL_AF;
					IL_294:
					num = (short)1911488518;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_363:
					num = (short)1642266624;
					short num7 = num;
					goto IL_294;
					IL_2D8:
					num = (short)1237450752;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_345:
					num4++;
					num = (short)845807633;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_435:
					num3++;
					num = (short)699465743;
					num2 = (int)((global::System.IntPtr)num);
				}
				return;
				IL_343:
				return;
				IL_3BB:
				return;
				IL_AF:
				feature = global::AcpCommonLib.FeatureManager.GetFeature(2059);
				num3 = 0;
				num = (short)268632074;
				num2 = (int)((global::System.IntPtr)num);
				goto IL_50;
			}
			}
		}

		// Token: 0x0600D0BB RID: 53435 RVA: 0x00C35044 File Offset: 0x00C33244
		public static void ImportExportMap(string strAliasName, bool bImport = true)
		{
			short num = (short)137232385;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				num = (short)2004854535;
				short num3 = num;
				num = (short)1551083271;
				switch ((num3 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					break;
				default:
				{
					num = (short)417267712;
					short num4 = num;
					num = (short)2041380865;
					if (num != 0)
					{
					}
					num = (short)734461952;
					if (num != 0)
					{
					}
					switch (num2)
					{
					case 0:
						return;
					case 1:
						switch (0)
						{
						case 0:
							goto IL_CD;
						}
						continue;
					case 2:
						try
						{
							num = (short)286982147;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								switch (num2)
								{
								case 0:
									goto IL_17E;
								case 1:
									goto IL_192;
								case 2:
									global::ConstraintHelper.UtilityMack.b();
									num = (short)686358528;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 3:
									switch (0)
									{
									case 0:
										goto IL_12D;
									}
									continue;
								case 4:
									goto IL_17E;
								}
								IL_12D:
								if (bImport)
								{
									num = (short)410779650;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								global::ConstraintHelper.UtilityMack.a();
								num = (short)95682564;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								IL_17E:
								num = (short)2125201409;
								num2 = (int)((global::System.IntPtr)num);
							}
							IL_192:
							return;
						}
						catch (global::System.Exception ex)
						{
							global::AcpCommonLib.AppInfoManager.StatusMsgReport.RegisterMessage(global::AcpCommonLib.StatusMsgType.Error, ex.Message);
							return;
						}
						goto IL_1A8;
					}
					break;
				}
				}
				IL_CD:
				if (!global::ConstraintHelper.UtilityMack.ConfigureViewFlag)
				{
					num = (short)520486912;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				IL_1A8:
				global::ConstraintHelper.UtilityMack.j = strAliasName;
				num = (short)1077215234;
				num2 = (int)((global::System.IntPtr)num);
			}
		}

		// Token: 0x0600D0BC RID: 53436 RVA: 0x00C3522C File Offset: 0x00C3342C
		private static void b()
		{
			short num2;
			try
			{
				switch (0)
				{
				case 0:
					goto IL_34;
				}
				int num;
				global::System.Windows.Forms.OpenFileDialog openFileDialog;
				for (;;)
				{
					IL_0A:
					switch (num)
					{
					case 0:
						global::ConstraintHelper.UtilityMack.a(openFileDialog.FileName);
						num2 = (short)1842413572;
						num = (int)((global::System.IntPtr)num2);
						continue;
					case 1:
						goto IL_9D;
					case 2:
						if (global::System.Windows.Forms.DialogResult.OK == openFileDialog.ShowDialog())
						{
							num2 = (short)2009530375;
							num = (int)((global::System.IntPtr)num2);
							continue;
						}
						goto IL_1C9;
					case 3:
						if (openFileDialog.FilterIndex == 1)
						{
							num2 = (short)1066860544;
							num = (int)((global::System.IntPtr)num2);
							continue;
						}
						num2 = (short)384040961;
						num = (int)((global::System.IntPtr)num2);
						continue;
					case 4:
						num2 = (short)991035393;
						if (num2 != 0)
						{
						}
						goto IL_1C9;
					case 5:
						goto IL_1E0;
					case 6:
						global::ConstraintHelper.UtilityMack.b(openFileDialog.FileName);
						num2 = (short)218628104;
						num = (int)((global::System.IntPtr)num2);
						continue;
					case 7:
					{
						num2 = (short)2012641644;
						short num3 = num2;
						num2 = (short)303987052;
						switch ((num3 == num2) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_9D;
						default:
							num2 = (short)1012269056;
							if (num2 != 0)
							{
							}
							num2 = (short)737935363;
							num = (int)((global::System.IntPtr)num2);
							continue;
						}
						break;
					}
					case 8:
						goto IL_1C9;
					}
					goto IL_34;
					IL_9D:
					if (openFileDialog.FilterIndex == 2)
					{
						num2 = (short)1035403270;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					IL_1C9:
					num2 = (short)2002583557;
					num = (int)((global::System.IntPtr)num2);
				}
				IL_1E0:
				goto IL_1EE;
				IL_34:
				openFileDialog = new global::System.Windows.Forms.OpenFileDialog();
				openFileDialog.Filter = global::CommonResources.AppResources.ID_KMLKMZMAPFILEFORMAT;
				openFileDialog.Multiselect = false;
				num2 = (short)867434498;
				num = (int)((global::System.IntPtr)num2);
				goto IL_0A;
			}
			catch (global::System.Exception)
			{
				throw new global::System.Exception(global::CommonResources.AppResources.ID_UNABLETOIMPORTMAPFILE);
			}
			IL_1EE:
			num2 = (short)654966784;
			short num4 = num2;
		}

		// Token: 0x0600D0BD RID: 53437 RVA: 0x00C3546C File Offset: 0x00C3366C
		private static void b(string A_0)
		{
			int a_ = 8;
			short num = (short)1948057600;
			int num2 = (int)num;
			switch (num2)
			{
			default:
			{
				num = (short)1871642624;
				short num3 = num;
				string text = global::System.IO.Path.Combine(global::System.Environment.GetFolderPath(global::System.Environment.SpecialFolder.CommonApplicationData), global::AllFeatures.CodeplugGuid.b("蓈꓊만ꃎꏐ볒맔뛖藘迚룜닞釠췢軤諦藨", a_));
				try
				{
					switch (0)
					{
					case 0:
						goto IL_91;
					}
					global::System.IO.FileStream fileStream;
					for (;;)
					{
						IL_76:
						switch (num2)
						{
						case 0:
							if (global::System.IO.File.Exists(text))
							{
								num = (short)1480261636;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							goto IL_398;
						case 1:
							goto IL_3B6;
						case 2:
							goto IL_398;
						case 3:
							try
							{
								global::System.IO.Compression.ZipArchive zipArchive = new global::System.IO.Compression.ZipArchive(fileStream, global::System.IO.Compression.ZipArchiveMode.Read);
								try
								{
									global::System.Collections.Generic.IEnumerator<global::System.IO.Compression.ZipArchiveEntry> enumerator = zipArchive.Entries.GetEnumerator();
									try
									{
										num = (short)938737668;
										num2 = (int)((global::System.IntPtr)num);
										for (;;)
										{
											switch (num2)
											{
											case 0:
												if (!enumerator.MoveNext())
												{
													goto IL_156;
												}
												num = (short)352976899;
												num2 = (int)((global::System.IntPtr)num);
												continue;
											case 1:
												num = (short)457310210;
												num2 = (int)((global::System.IntPtr)num);
												continue;
											case 2:
											{
												num = (short)12629553;
												short num4 = num;
												num = (short)137606705;
												switch ((num4 == num) ? 1 : 0)
												{
												case 0:
												case 2:
													goto IL_156;
												default:
													goto IL_1DE;
												}
												break;
											}
											case 3:
											{
												global::System.IO.Compression.ZipArchiveEntry source = enumerator.Current;
												if (global::System.IO.File.Exists(text))
												{
													global::System.IO.File.Delete(text);
												}
												source.ExtractToFile(text);
												num = (short)249495557;
												num2 = (int)((global::System.IntPtr)num);
												continue;
											}
											case 4:
												switch (0)
												{
												case 0:
													goto IL_108;
												}
												continue;
											}
											IL_138:
											num = (short)2085945344;
											num2 = (int)((global::System.IntPtr)num);
											continue;
											IL_108:
											goto IL_138;
											IL_156:
											num = (short)780926977;
											num2 = (int)((global::System.IntPtr)num);
										}
										IL_1DE:
										num = (short)397344768;
										if (num != 0)
										{
										}
									}
									finally
									{
										num = (short)1103036417;
										num2 = (int)((global::System.IntPtr)num);
										for (;;)
										{
											switch (num2)
											{
											case 0:
												enumerator.Dispose();
												num = (short)917176322;
												num2 = (int)((global::System.IntPtr)num);
												continue;
											case 1:
												switch (0)
												{
												case 0:
													goto IL_228;
												}
												continue;
											case 2:
												goto IL_25E;
											}
											IL_228:
											if (enumerator == null)
											{
												break;
											}
											num = (short)448397312;
											num2 = (int)((global::System.IntPtr)num);
										}
										IL_25E:;
									}
								}
								finally
								{
									num = (short)888668161;
									num2 = (int)((global::System.IntPtr)num);
									for (;;)
									{
										switch (num2)
										{
										case 0:
											((global::System.IDisposable)zipArchive).Dispose();
											num = (short)535363586;
											num2 = (int)((global::System.IntPtr)num);
											continue;
										case 1:
											switch (0)
											{
											case 0:
												goto IL_295;
											}
											continue;
										case 2:
											goto IL_2CB;
										}
										IL_295:
										if (zipArchive == null)
										{
											break;
										}
										num = (short)892993536;
										num2 = (int)((global::System.IntPtr)num);
									}
									IL_2CB:;
								}
								goto IL_35E;
							}
							finally
							{
								num = (short)99418113;
								num2 = (int)((global::System.IntPtr)num);
								for (;;)
								{
									switch (num2)
									{
									case 0:
										((global::System.IDisposable)fileStream).Dispose();
										num = (short)541786114;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									case 1:
										switch (0)
										{
										case 0:
											goto IL_305;
										}
										continue;
									case 2:
										goto IL_33A;
									}
									IL_305:
									if (fileStream == null)
									{
										break;
									}
									num = (short)2131689472;
									num2 = (int)((global::System.IntPtr)num);
								}
								IL_33A:;
							}
							goto IL_33D;
							IL_35E:
							num = (short)330956800;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 4:
							goto IL_33D;
						}
						goto IL_91;
						IL_33D:
						global::ConstraintHelper.UtilityMack.a(text);
						num = (short)1179779074;
						num2 = (int)((global::System.IntPtr)num);
						continue;
						IL_398:
						global::System.IO.File.Delete(text);
						num = (short)697106433;
						num2 = (int)((global::System.IntPtr)num);
					}
					IL_3B6:
					goto IL_3B9;
					IL_91:
					fileStream = new global::System.IO.FileStream(A_0, global::System.IO.FileMode.Open);
					num = (short)1474822147;
					num2 = (int)((global::System.IntPtr)num);
					goto IL_76;
				}
				catch (global::System.Exception ex)
				{
					throw ex;
				}
				IL_3B9:
				num = (short)1619460097;
				if (num != 0)
				{
				}
				return;
			}
			}
		}

		// Token: 0x0600D0BE RID: 53438 RVA: 0x00C358BC File Offset: 0x00C33ABC
		private static void a(string A_0)
		{
			int a_ = 0;
			short num = (short)1123287040;
			int num2 = (int)num;
			switch (num2)
			{
			default:
			{
				switch (0)
				{
				case 0:
					goto IL_B3;
				}
				int num3;
				string input;
				string value;
				string[] array;
				global::AcpCommonLib.UndoRedo.ContainerTask containerTask;
				string input2;
				for (;;)
				{
					IL_30:
					bool flag;
					global::Motorola.MackinawCPS.CoreFeatures.MissionCriticalGeofence.MissionCriticalGeofenceRecset missionCriticalGeofenceRecset;
					switch (num2)
					{
					case 0:
						num3--;
						num = (short)1668939803;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 1:
						if (!flag)
						{
							num = (short)812974100;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_8B0;
					case 2:
					{
						global::System.Collections.Generic.IEnumerator<global::AcpBusinessLayer.FeatureNode> enumerator = missionCriticalGeofenceRecset.GetEnumerator();
						num = (short)685178890;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 3:
						num = (short)1048444952;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 4:
						if (input != "")
						{
							num = (short)1336999961;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_100B;
					case 5:
						goto IL_8AB;
					case 6:
						num = (short)918945804;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 7:
						if (value != "")
						{
							num = (short)1979252759;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_ED;
					case 8:
						if (!global::ConstraintHelper.UtilityMack.a(array))
						{
							num = (short)955383836;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_100B;
					case 9:
						value = global::AllFeatures.CodeplugGuid.b("", a_);
						num = (short)518586385;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 10:
						try
						{
							num = (short)979107843;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								switch (num2)
								{
								case 0:
									try
									{
										switch (0)
										{
										case 0:
											goto IL_386;
										}
										int num4;
										for (;;)
										{
											IL_347:
											double value2;
											switch (num2)
											{
											case 0:
												value2 = 0.0;
												num = (short)1498349569;
												num2 = (int)((global::System.IntPtr)num);
												continue;
											case 1:
												if (num3 == 1)
												{
													num = (short)2021523458;
													num2 = (int)((global::System.IntPtr)num);
													continue;
												}
												num = (short)1391591436;
												num2 = (int)((global::System.IntPtr)num);
												continue;
											case 2:
												value2 = global::System.Convert.ToDouble(value, global::ConstraintHelper.UtilityMack.q);
												num = (short)1732968453;
												num2 = (int)((global::System.IntPtr)num);
												continue;
											case 3:
												goto IL_6A1;
											case 4:
												goto IL_3A4;
											case 5:
												goto IL_4C3;
											case 6:
												goto IL_4C3;
											case 7:
												goto IL_3A4;
											case 8:
												goto IL_6B9;
											case 9:
											{
												if (num4 >= num3)
												{
													num = (short)484638733;
													num2 = (int)((global::System.IntPtr)num);
													continue;
												}
												global::Motorola.MackinawCPS.CoreFeatures.MissionCriticalGeofence.CoordinatesInnerRecset coordinatesInnerRecset;
												global::Motorola.MackinawCPS.CoreFeatures.MissionCriticalGeofence.CoordinatesInner coordinatesInner = coordinatesInnerRecset.CreateDefaultRecord() as global::Motorola.MackinawCPS.CoreFeatures.MissionCriticalGeofence.CoordinatesInner;
												string[] array2 = new global::System.Text.RegularExpressions.Regex(global::AllFeatures.CodeplugGuid.b("", a_)).Split(array[num4]);
												double num5 = global::System.Math.Round(double.Parse(array2[0].Trim(), global::ConstraintHelper.UtilityMack.q), 7);
												double num6 = global::System.Math.Round(double.Parse(array2[1].Trim(), global::ConstraintHelper.UtilityMack.q), 7);
												int value3 = global::System.Convert.ToInt32(num5 * (double)global::ConstraintHelper.UtilityMack.l, global::ConstraintHelper.UtilityMack.q);
												int value4 = global::System.Convert.ToInt32(num6 * (double)global::ConstraintHelper.UtilityMack.l, global::ConstraintHelper.UtilityMack.q);
												coordinatesInner.CoordinatesInnerSection.McGeofenceLongitude_42893.SetValue(value3);
												coordinatesInner.CoordinatesInnerSection.McGeofenceLatitude_42894.SetValue(value4);
												containerTask.AddTask(new global::AcpBusinessLayer.UndoRedo.AddRecordTask(coordinatesInner));
												num4++;
												num = (short)827588615;
												num2 = (int)((global::System.IntPtr)num);
												continue;
											}
											case 10:
											{
												global::Motorola.MackinawCPS.CoreFeatures.MissionCriticalGeofence.CoordinatesInnerRecset coordinatesInnerRecset;
												global::Motorola.MackinawCPS.CoreFeatures.MissionCriticalGeofence.CoordinatesInner coordinatesInner2 = coordinatesInnerRecset[0] as global::Motorola.MackinawCPS.CoreFeatures.MissionCriticalGeofence.CoordinatesInner;
												double longitude = (double)coordinatesInner2.CoordinatesInnerSection.McGeofenceLongitude_42893.Value / (double)global::ConstraintHelper.UtilityMack.l;
												global::System.Device.Location.GeoCoordinate geoCoordinate = new global::System.Device.Location.GeoCoordinate((double)coordinatesInner2.CoordinatesInnerSection.McGeofenceLatitude_42894.Value / (double)global::ConstraintHelper.UtilityMack.l, longitude);
												global::Motorola.MackinawCPS.CoreFeatures.MissionCriticalGeofence.CoordinatesInner coordinatesInner3 = coordinatesInnerRecset[1] as global::Motorola.MackinawCPS.CoreFeatures.MissionCriticalGeofence.CoordinatesInner;
												double longitude2 = (double)coordinatesInner3.CoordinatesInnerSection.McGeofenceLongitude_42893.Value / (double)global::ConstraintHelper.UtilityMack.l;
												global::System.Device.Location.GeoCoordinate other = new global::System.Device.Location.GeoCoordinate((double)coordinatesInner3.CoordinatesInnerSection.McGeofenceLatitude_42894.Value / (double)global::ConstraintHelper.UtilityMack.l, longitude2);
												value2 = geoCoordinate.GetDistanceTo(other);
												num = (short)755171334;
												num2 = (int)((global::System.IntPtr)num);
												continue;
											}
											case 11:
												if (flag)
												{
													num = (short)1817313280;
													num2 = (int)((global::System.IntPtr)num);
													continue;
												}
												goto IL_6A1;
											case 12:
												if (num3 == 2)
												{
													num = (short)1130758154;
													num2 = (int)((global::System.IntPtr)num);
													continue;
												}
												goto IL_4C3;
											case 13:
												num = (short)1409220619;
												num2 = (int)((global::System.IntPtr)num);
												continue;
											}
											goto IL_386;
											IL_3A4:
											num = (short)1600978953;
											num2 = (int)((global::System.IntPtr)num);
											continue;
											IL_4C3:
											global::Motorola.MackinawCPS.CoreFeatures.MissionCriticalGeofence.MissionCriticalGeofence missionCriticalGeofence;
											containerTask.AddTask(new global::AcpBusinessLayer.UndoRedo.ModifyDataTask<int>(missionCriticalGeofence.General.McGeofenceRadiusInMeters_42890, global::System.Convert.ToInt32(value2)));
											num = (short)160497667;
											num2 = (int)((global::System.IntPtr)num);
											continue;
											IL_6A1:
											num = (short)729219080;
											num2 = (int)((global::System.IntPtr)num);
										}
										IL_6B9:
										break;
										IL_386:
										num4 = 0;
										num = (short)584777732;
										num2 = (int)((global::System.IntPtr)num);
										goto IL_347;
									}
									catch (global::System.Exception)
									{
										throw new global::System.Exception(global::CommonResources.AppResources.ID_UNABLETOIMPORTMAPFILE);
									}
									goto IL_6C7;
								case 1:
								{
									global::Motorola.MackinawCPS.CoreFeatures.MissionCriticalGeofence.MissionCriticalGeofence missionCriticalGeofence;
									if (missionCriticalGeofence.General.GeofenceAliasName_42867.Value == global::ConstraintHelper.UtilityMack.j)
									{
										num = (short)1447821321;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									break;
								}
								case 2:
								{
									global::Motorola.MackinawCPS.CoreFeatures.MissionCriticalGeofence.CoordinatesInnerRecset coordinatesInnerRecset;
									int num7 = coordinatesInnerRecset.Count - 1;
									num = (short)1458372620;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 3:
									switch (0)
									{
									case 0:
										goto IL_246;
									}
									continue;
								case 4:
								{
									global::System.Collections.Generic.IEnumerator<global::AcpBusinessLayer.FeatureNode> enumerator;
									if (!enumerator.MoveNext())
									{
										num = (short)1282277387;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									global::Motorola.MackinawCPS.CoreFeatures.MissionCriticalGeofence.MissionCriticalGeofence missionCriticalGeofence = (global::Motorola.MackinawCPS.CoreFeatures.MissionCriticalGeofence.MissionCriticalGeofence)enumerator.Current;
									num = (short)276889601;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 5:
									num = (short)1241120768;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 6:
									goto IL_6C7;
								case 7:
								{
									global::Motorola.MackinawCPS.CoreFeatures.MissionCriticalGeofence.CoordinatesInnerRecset coordinatesInnerRecset;
									if (coordinatesInnerRecset != null)
									{
										num = (short)836894722;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									break;
								}
								case 8:
									goto IL_797;
								case 9:
								{
									global::Motorola.MackinawCPS.CoreFeatures.MissionCriticalGeofence.MissionCriticalGeofence missionCriticalGeofence;
									global::Motorola.MackinawCPS.CoreFeatures.MissionCriticalGeofence.CoordinatesInnerRecset coordinatesInnerRecset = missionCriticalGeofence.General.EmbeddedRecset as global::Motorola.MackinawCPS.CoreFeatures.MissionCriticalGeofence.CoordinatesInnerRecset;
									num = (short)1478361095;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 10:
								{
									int num7;
									if (num7 < 0)
									{
										num = (short)1208745989;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									global::Motorola.MackinawCPS.CoreFeatures.MissionCriticalGeofence.CoordinatesInnerRecset coordinatesInnerRecset;
									containerTask.AddTask(new global::AcpBusinessLayer.UndoRedo.DeleteRecordTask(coordinatesInnerRecset[num7] as global::Motorola.MackinawCPS.CoreFeatures.MissionCriticalGeofence.CoordinatesInner));
									num7--;
									num = (short)911540230;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 11:
									num = (short)297402376;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 12:
									goto IL_6C7;
								}
								goto IL_246;
								IL_6C7:
								num = (short)1686700042;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								IL_701:
								num = (short)1261568004;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								IL_246:
								goto IL_701;
							}
							IL_797:
							goto IL_1276;
						}
						finally
						{
							num = (short)652476418;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								global::System.Collections.Generic.IEnumerator<global::AcpBusinessLayer.FeatureNode> enumerator;
								switch (num2)
								{
								case 0:
									goto IL_808;
								case 1:
									enumerator.Dispose();
									num = (short)187629568;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 2:
									switch (0)
									{
									case 0:
										goto IL_7D0;
									}
									continue;
								}
								IL_7D0:
								if (enumerator == null)
								{
									break;
								}
								num = (short)1385889793;
								num2 = (int)((global::System.IntPtr)num);
							}
							IL_808:;
						}
						goto IL_80B;
					case 11:
						goto IL_11FF;
					case 12:
						if (value == "")
						{
							num = (short)714932233;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_1193;
					case 13:
						if (num3 != 0)
						{
							num = (short)979042307;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_1204;
					case 14:
						if (num3 == 1)
						{
							num = (short)747962368;
							short num8 = num;
							num = (short)1189937158;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_80B;
					case 15:
						num = (short)662700033;
						if (num != 0)
						{
						}
						num = (short)1886519322;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 16:
						if (num3 == 101)
						{
							num = (short)557842447;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_ED;
					case 17:
						goto IL_1193;
					case 18:
					{
						try
						{
							switch (0)
							{
							case 0:
								goto IL_984;
							}
							global::System.Xml.Linq.XDocument xdocument;
							string namespaceName;
							for (;;)
							{
								IL_965:
								global::System.Collections.Generic.IEnumerator<global::System.Xml.Linq.XElement> enumerator2;
								global::System.Xml.Linq.XNamespace ns;
								switch (num2)
								{
								case 0:
								{
									num = (short)1162022688;
									short num9 = num;
									num = (short)346885920;
									switch ((num9 == num) ? 1 : 0)
									{
									case 0:
									case 2:
										goto IL_FDD;
									default:
										num = (short)281477120;
										if (num != 0)
										{
										}
										goto IL_E7A;
									}
									break;
								}
								case 1:
									goto IL_FFA;
								case 2:
									goto IL_F9F;
								case 3:
									try
									{
										num = (short)388104196;
										num2 = (int)((global::System.IntPtr)num);
										for (;;)
										{
											switch (num2)
											{
											case 0:
												goto IL_E06;
											case 1:
											{
												if (!enumerator2.MoveNext())
												{
													num = (short)781975555;
													num2 = (int)((global::System.IntPtr)num);
													continue;
												}
												global::System.Collections.Generic.IEnumerator<global::System.Xml.Linq.XElement> enumerator3 = enumerator2.Current.Elements(ns + global::AllFeatures.CodeplugGuid.b("藀ꋂ뇄ꛆ", a_)).GetEnumerator();
												num = (short)1525612546;
												num2 = (int)((global::System.IntPtr)num);
												continue;
											}
											case 2:
												try
												{
													num = (short)1931476997;
													num2 = (int)((global::System.IntPtr)num);
													for (;;)
													{
														switch (num2)
														{
														case 0:
														{
															global::System.Xml.Linq.XElement xelement;
															if (xelement.Attribute(global::AllFeatures.CodeplugGuid.b("꿀ꋂ꣄ꋆ", a_)).Value == global::AllFeatures.CodeplugGuid.b("賀郂賄諈ꋊ뿌곎뷐뛒藖룘뿚드꫞鋠", a_))
															{
																num = (short)887816193;
																num2 = (int)((global::System.IntPtr)num);
																continue;
															}
															break;
														}
														case 1:
														{
															global::System.Xml.Linq.XElement xelement;
															value = xelement.Element(ns + global::AllFeatures.CodeplugGuid.b("韀ꋂ꧄닆곈", a_)).Value;
															num = (short)1741422601;
															num2 = (int)((global::System.IntPtr)num);
															continue;
														}
														case 2:
															num = (short)1153171460;
															num2 = (int)((global::System.IntPtr)num);
															continue;
														case 3:
														{
															global::System.Xml.Linq.XElement xelement;
															input2 = xelement.Element(ns + global::AllFeatures.CodeplugGuid.b("韀ꋂ꧄닆곈", a_)).Value.Trim();
															num = (short)1384906758;
															num2 = (int)((global::System.IntPtr)num);
															continue;
														}
														case 4:
															goto IL_D78;
														case 5:
															switch (0)
															{
															case 0:
																goto IL_BB5;
															}
															continue;
														case 6:
															goto IL_BF7;
														case 7:
														{
															global::System.Xml.Linq.XElement xelement;
															if (xelement.Attribute(global::AllFeatures.CodeplugGuid.b("꿀ꋂ꣄ꋆ", a_)).Value == global::AllFeatures.CodeplugGuid.b("賀郂賄諈ꋊ뿌곎뷐뛒郖볘듚믜뫞迠胢胤", a_))
															{
																num = (short)459341827;
																num2 = (int)((global::System.IntPtr)num);
																continue;
															}
															goto IL_BF7;
														}
														case 8:
														{
															global::System.Collections.Generic.IEnumerator<global::System.Xml.Linq.XElement> enumerator3;
															if (!enumerator3.MoveNext())
															{
																num = (short)1681522690;
																num2 = (int)((global::System.IntPtr)num);
																continue;
															}
															global::System.Xml.Linq.XElement xelement = enumerator3.Current;
															num = (short)2027225095;
															num2 = (int)((global::System.IntPtr)num);
															continue;
														}
														}
														goto IL_BB5;
														IL_BF7:
														num = (short)1318322176;
														num2 = (int)((global::System.IntPtr)num);
														continue;
														IL_D1F:
														num = (short)303628296;
														num2 = (int)((global::System.IntPtr)num);
														continue;
														IL_BB5:
														goto IL_D1F;
													}
													IL_D78:
													break;
												}
												finally
												{
													num = (short)1320550402;
													num2 = (int)((global::System.IntPtr)num);
													for (;;)
													{
														global::System.Collections.Generic.IEnumerator<global::System.Xml.Linq.XElement> enumerator3;
														switch (num2)
														{
														case 0:
															goto IL_DE9;
														case 1:
															enumerator3.Dispose();
															num = (short)1583218688;
															num2 = (int)((global::System.IntPtr)num);
															continue;
														case 2:
															switch (0)
															{
															case 0:
																goto IL_DAF;
															}
															continue;
														}
														IL_DAF:
														if (enumerator3 == null)
														{
															break;
														}
														num = (short)1485832193;
														num2 = (int)((global::System.IntPtr)num);
													}
													IL_DE9:;
												}
												goto IL_DEC;
											case 3:
												goto IL_DEC;
											case 4:
												switch (0)
												{
												case 0:
													goto IL_AE1;
												}
												continue;
											}
											IL_B25:
											num = (short)1316093953;
											num2 = (int)((global::System.IntPtr)num);
											continue;
											IL_AE1:
											goto IL_B25;
											IL_DEC:
											num = (short)922615808;
											num2 = (int)((global::System.IntPtr)num);
										}
										IL_E06:
										goto IL_FE2;
									}
									finally
									{
										num = (short)1224015874;
										num2 = (int)((global::System.IntPtr)num);
										for (;;)
										{
											switch (num2)
											{
											case 0:
												goto IL_E77;
											case 1:
												enumerator2.Dispose();
												num = (short)1967259648;
												num2 = (int)((global::System.IntPtr)num);
												continue;
											case 2:
												switch (0)
												{
												case 0:
													goto IL_E3E;
												}
												continue;
											}
											IL_E3E:
											if (enumerator2 == null)
											{
												break;
											}
											num = (short)542244865;
											num2 = (int)((global::System.IntPtr)num);
										}
										IL_E77:;
									}
									goto Block_30;
									IL_FE2:
									num = (short)2008023041;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 4:
									goto IL_FDD;
								case 5:
									if (xdocument.Root.HasAttributes)
									{
										num = (short)907673602;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									goto IL_A12;
								}
								goto IL_984;
								Block_30:
								try
								{
									IL_E7A:
									num = (short)370999300;
									num2 = (int)((global::System.IntPtr)num);
									for (;;)
									{
										switch (num2)
										{
										case 0:
											goto IL_F2E;
										case 1:
											goto IL_F16;
										case 2:
											if (!enumerator2.MoveNext())
											{
												num = (short)97320961;
												num2 = (int)((global::System.IntPtr)num);
												continue;
											}
											input = enumerator2.Current.Value.Trim();
											num = (short)597688323;
											num2 = (int)((global::System.IntPtr)num);
											continue;
										case 3:
											goto IL_F16;
										case 4:
											switch (0)
											{
											case 0:
												goto IL_EB4;
											}
											continue;
										}
										IL_EB4:
										num = (short)1417347074;
										num2 = (int)((global::System.IntPtr)num);
										continue;
										IL_F16:
										num = (short)1860173824;
										num2 = (int)((global::System.IntPtr)num);
									}
									IL_F2E:
									goto IL_9D2;
								}
								finally
								{
									num = (short)866451458;
									num2 = (int)((global::System.IntPtr)num);
									for (;;)
									{
										switch (num2)
										{
										case 0:
											goto IL_F9C;
										case 1:
											enumerator2.Dispose();
											num = (short)460193792;
											num2 = (int)((global::System.IntPtr)num);
											continue;
										case 2:
											switch (0)
											{
											case 0:
												goto IL_F65;
											}
											continue;
										}
										IL_F65:
										if (enumerator2 == null)
										{
											break;
										}
										num = (short)609681409;
										num2 = (int)((global::System.IntPtr)num);
									}
									IL_F9C:;
								}
								goto IL_F9F;
								IL_9D2:
								enumerator2 = xdocument.Descendants(ns + global::AllFeatures.CodeplugGuid.b("蓀믂뇄ꋆꟈ꿊꣌ꯎ闐닒ꇔ뛖", a_)).GetEnumerator();
								num = (short)857014275;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								IL_A12:
								ns = global::System.Xml.Linq.XNamespace.Get(namespaceName);
								enumerator2 = xdocument.Descendants(ns + global::AllFeatures.CodeplugGuid.b("ꋀ곂꫄뗆귈ꋊꏌ껎ꗐ뛒ꛔ", a_)).GetEnumerator();
								num = (short)2102329344;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								IL_FDD:
								goto IL_A12;
								IL_F9F:
								namespaceName = xdocument.Root.Attribute(global::AllFeatures.CodeplugGuid.b("맀껂꧄꧆뫈", a_)).Value;
								num = (short)1071513604;
								num2 = (int)((global::System.IntPtr)num);
							}
							IL_FFA:
							goto IL_186;
							IL_984:
							xdocument = global::System.Xml.Linq.XDocument.Load(A_0);
							namespaceName = "";
							num = (short)379125765;
							num2 = (int)((global::System.IntPtr)num);
							goto IL_965;
						}
						catch (global::System.Exception)
						{
							throw new global::System.Exception(global::CommonResources.AppResources.ID_UNABLETOIMPORTMAPFILE);
						}
						goto IL_100B;
						IL_186:
						global::System.Text.RegularExpressions.Regex regex = new global::System.Text.RegularExpressions.Regex(global::AllFeatures.CodeplugGuid.b("", a_));
						num = (short)1633157124;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 19:
						if (global::ConstraintHelper.UtilityMack.a(array[0], array[num3 - 1]))
						{
							num = (short)1843265536;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_17B;
					case 20:
						num = (short)1631322131;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 21:
						if (!global::ConstraintHelper.UtilityMack.a(array))
						{
							num = (short)1946681355;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_ED;
					case 22:
						if (missionCriticalGeofenceRecset != null)
						{
							num = (short)2061697026;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_1276;
					case 23:
					{
						flag = true;
						global::System.Text.RegularExpressions.Regex regex;
						array = regex.Split(input2);
						num3 = array.Length;
						num = (short)1160249365;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 24:
						if (num3 > 101)
						{
							num = (short)1668677637;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)381550606;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 25:
					{
						global::System.Text.RegularExpressions.Regex regex;
						array = regex.Split(input);
						num3 = array.Length;
						num = (short)1815478280;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 26:
						if (input2 != "")
						{
							num = (short)652279838;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_ED;
					case 27:
						goto IL_8B0;
					case 28:
						goto IL_1091;
					case 29:
						goto IL_ED;
					case 30:
						num = (short)1070596103;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_B3;
					IL_ED:
					num = (short)2143617025;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_80B:
					num = (short)1936982032;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_8B0:
					containerTask = new global::AcpCommonLib.UndoRedo.ContainerTask(global::AllFeatures.CodeplugGuid.b("裀껂뗄꣆믈뿊賎뻐볒꟔뻖럘뿚볜ꯞ蓠쏢럤苦諨蓪鿬诮苰雲致", a_));
					missionCriticalGeofenceRecset = (global::AcpCommonLib.FeatureManager.GetFeature(4174) as global::Motorola.MackinawCPS.CoreFeatures.MissionCriticalGeofence.MissionCriticalGeofenceRecset);
					num = (short)242221078;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_100B:
					flag = false;
					num = (short)1747517453;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_1193:
					flag = true;
					num = (short)422379549;
					num2 = (int)((global::System.IntPtr)num);
				}
				IL_17B:
				throw new global::System.Exception(global::CommonResources.AppResources.ID_UNABLETOIMPORTMAPFILE);
				IL_8AB:
				goto IL_1204;
				IL_1091:
				throw new global::System.Exception(global::CommonResources.AppResources.ID_UNABLETOIMPORTMAPFILE);
				IL_11FF:
				throw new global::System.Exception(global::CommonResources.AppResources.ID_UNABLETOIMPORTMAPFILE);
				IL_1204:
				throw new global::System.Exception(global::CommonResources.AppResources.ID_UNABLETOIMPORTMAPFILE);
				IL_1276:
				global::AcpCommonLib.UndoRedo.UndoManager.AddTask(containerTask);
				return;
				IL_B3:
				num3 = 0;
				array = new string[101];
				input = "";
				input2 = "";
				value = "";
				num = (short)2048262162;
				num2 = (int)((global::System.IntPtr)num);
				goto IL_30;
			}
			}
		}

		// Token: 0x0600D0BF RID: 53439 RVA: 0x00C36BDC File Offset: 0x00C34DDC
		private static bool a(string A_0, string A_1)
		{
			int a_ = 0;
			short num;
			bool result;
			try
			{
				num = (short)2014904320;
				int num2 = (int)num;
				switch (num2)
				{
				default:
				{
					switch (0)
					{
					case 0:
						goto IL_69;
					}
					string[] array;
					string[] array2;
					bool flag;
					for (;;)
					{
						IL_32:
						switch (num2)
						{
						case 0:
							goto IL_220;
						case 1:
						{
							int num3;
							if (double.Parse(array[num3], global::ConstraintHelper.UtilityMack.q) - double.Parse(array2[num3], global::ConstraintHelper.UtilityMack.q) > 1E-07)
							{
								num = (short)85458955;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							num3++;
							num = (short)1123680259;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						case 2:
							goto IL_278;
						case 3:
						{
							num = (short)1324076455;
							short num4 = num;
							num = (short)751422887;
							switch ((num4 == num) ? 1 : 0)
							{
							case 0:
							case 2:
								goto IL_220;
							default:
								num = (short)1913257984;
								if (num != 0)
								{
								}
								goto IL_D1;
							}
							break;
						}
						case 4:
							goto IL_278;
						case 5:
							num = (short)1037565953;
							if (num != 0)
							{
							}
							num = (short)870711298;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 6:
						{
							int num3 = 0;
							num = (short)1270677513;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						case 7:
						{
							int num3;
							if (num3 >= array.Count<string>())
							{
								num = (short)9306117;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							num = (short)132382721;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						case 8:
							if (array.Count<string>() == array2.Count<string>())
							{
								num = (short)892534790;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							flag = false;
							num = (short)281870336;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 9:
							goto IL_D1;
						case 10:
							goto IL_293;
						case 11:
							flag = false;
							num = (short)136183812;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_69;
						IL_D1:
						num = (short)989331463;
						num2 = (int)((global::System.IntPtr)num);
						continue;
						IL_278:
						result = flag;
						num = (short)13959178;
						num2 = (int)((global::System.IntPtr)num);
						continue;
						IL_220:
						goto IL_278;
					}
					IL_293:
					break;
					IL_69:
					flag = true;
					global::System.Text.RegularExpressions.Regex regex = new global::System.Text.RegularExpressions.Regex(global::AllFeatures.CodeplugGuid.b("", a_));
					array = regex.Split(A_0);
					array2 = regex.Split(A_1);
					num = (short)514654216;
					num2 = (int)((global::System.IntPtr)num);
					goto IL_32;
				}
				}
			}
			catch (global::System.Exception)
			{
				result = false;
			}
			num = (short)211484672;
			short num5 = num;
			return result;
		}

		// Token: 0x0600D0C0 RID: 53440 RVA: 0x00C36ECC File Offset: 0x00C350CC
		private static bool a(string[] A_0)
		{
			int a_ = 2;
			short num = (short)1102163289;
			short num2 = num;
			num = (short)391884121;
			bool result;
			switch ((num2 == num) ? 1 : 0)
			{
			case 0:
			case 2:
				break;
			default:
			{
				num = (short)1936326656;
				short num3 = num;
				num = (short)1602945024;
				if (num != 0)
				{
				}
				num = (short)1327759360;
				int num4 = (int)num;
				switch (num4)
				{
				default:
					result = true;
					try
					{
						switch (0)
						{
						case 0:
							goto IL_E5;
						}
						int num7;
						for (;;)
						{
							IL_A6:
							switch (num4)
							{
							case 0:
								goto IL_2DE;
							case 1:
								num = (short)1585971206;
								num4 = (int)((global::System.IntPtr)num);
								continue;
							case 2:
								num = (short)1226506251;
								num4 = (int)((global::System.IntPtr)num);
								continue;
							case 3:
							{
								double num5;
								if (num5 >= -90.0)
								{
									num = (short)808452098;
									num4 = (int)((global::System.IntPtr)num);
									continue;
								}
								goto IL_1F2;
							}
							case 4:
								goto IL_1F2;
							case 5:
								goto IL_2DE;
							case 6:
							{
								double num6;
								if (num6 <= 180.0)
								{
									num = (short)1557135368;
									num4 = (int)((global::System.IntPtr)num);
									continue;
								}
								goto IL_1F2;
							}
							case 7:
							{
								double num6;
								if (num6 >= -180.0)
								{
									num = (short)67371009;
									num4 = (int)((global::System.IntPtr)num);
									continue;
								}
								goto IL_1F2;
							}
							case 8:
								num = (short)252444675;
								num4 = (int)((global::System.IntPtr)num);
								continue;
							case 9:
								goto IL_213;
							case 10:
								goto IL_213;
							case 11:
							{
								double num5;
								if (num5 > 90.0)
								{
									num = (short)772866052;
									num4 = (int)((global::System.IntPtr)num);
									continue;
								}
								num7++;
								num = (short)485031945;
								num4 = (int)((global::System.IntPtr)num);
								continue;
							}
							case 12:
								goto IL_2F7;
							case 13:
							{
								if (num7 >= A_0.Length)
								{
									num = (short)3538949;
									num4 = (int)((global::System.IntPtr)num);
									continue;
								}
								string[] array = new global::System.Text.RegularExpressions.Regex(global::AllFeatures.CodeplugGuid.b("", a_)).Split(A_0[num7]);
								double num6 = global::System.Math.Round(double.Parse(array[0].Trim(), global::ConstraintHelper.UtilityMack.q), 7);
								double num5 = global::System.Math.Round(double.Parse(array[1].Trim(), global::ConstraintHelper.UtilityMack.q), 7);
								num = (short)847970311;
								num4 = (int)((global::System.IntPtr)num);
								continue;
							}
							}
							goto IL_E5;
							IL_1F2:
							result = false;
							num = (short)1356988416;
							num4 = (int)((global::System.IntPtr)num);
							continue;
							IL_213:
							num = (short)800260109;
							num4 = (int)((global::System.IntPtr)num);
							continue;
							IL_2DE:
							num = (short)1654652940;
							num4 = (int)((global::System.IntPtr)num);
						}
						IL_2F7:
						break;
						IL_E5:
						num7 = 0;
						num = (short)477626378;
						num4 = (int)((global::System.IntPtr)num);
						goto IL_A6;
					}
					catch (global::System.Exception)
					{
						throw new global::System.Exception(global::CommonResources.AppResources.ID_UNABLETOIMPORTMAPFILE);
					}
					break;
				}
				break;
			}
			}
			num = (short)2034368513;
			if (num != 0)
			{
			}
			return result;
		}

		// Token: 0x0600D0C1 RID: 53441 RVA: 0x00C37224 File Offset: 0x00C35424
		private static void a()
		{
			short num = (short)741212160;
			int num2 = (int)num;
			switch (num2)
			{
			default:
			{
				switch (0)
				{
				case 0:
					goto IL_3B;
				}
				string text;
				string a_;
				int num4;
				for (;;)
				{
					IL_28:
					switch (num2)
					{
					case 0:
					{
						num = (short)2133477990;
						short num3 = num;
						num = (short)1667975782;
						switch ((num3 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_1DC;
						default:
							num = (short)349700096;
							if (num != 0)
							{
							}
							if (text.Trim() == "")
							{
								num = (short)83361794;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							goto IL_195;
						}
						break;
					}
					case 1:
						try
						{
							switch (0)
							{
							case 0:
								goto IL_103;
							}
							global::System.Windows.Forms.SaveFileDialog saveFileDialog;
							for (;;)
							{
								IL_EC:
								switch (num2)
								{
								case 0:
									if (global::System.Windows.Forms.DialogResult.OK == saveFileDialog.ShowDialog())
									{
										num = (short)412549122;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									goto IL_179;
								case 1:
									goto IL_192;
								case 2:
									global::ConstraintHelper.UtilityMack.a(saveFileDialog.FileName, text, a_, num4.ToString());
									num = (short)1246232579;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 3:
									goto IL_179;
								}
								goto IL_103;
								IL_179:
								num = (short)1913061377;
								num2 = (int)((global::System.IntPtr)num);
							}
							IL_192:
							return;
							IL_103:
							saveFileDialog = new global::System.Windows.Forms.SaveFileDialog();
							saveFileDialog.Filter = global::CommonResources.AppResources.ID_KMLMAPFILEFORMAT;
							num = (short)703266816;
							num2 = (int)((global::System.IntPtr)num);
							goto IL_EC;
						}
						catch (global::System.Exception ex)
						{
							throw ex;
						}
						goto IL_195;
					case 2:
						goto IL_DD;
					}
					goto IL_3B;
					IL_195:
					num = (short)77463553;
					if (num != 0)
					{
					}
					num = (short)462159873;
					num2 = (int)((global::System.IntPtr)num);
				}
				IL_DD:
				IL_1DC:
				num = (short)431685632;
				short num5 = num;
				throw new global::System.Exception(global::CommonResources.AppResources.ID_UNABLETOEXPORTMAPFILE);
				IL_3B:
				a_ = "";
				num4 = 0;
				text = global::ConstraintHelper.UtilityMack.a(ref a_, ref num4);
				num = (short)814809088;
				num2 = (int)((global::System.IntPtr)num);
				goto IL_28;
			}
			}
		}

		// Token: 0x0600D0C2 RID: 53442 RVA: 0x00C37454 File Offset: 0x00C35654
		private static string a(ref string A_0, ref int A_1)
		{
			int a_ = 11;
			short num = (short)1311038487;
			short num2 = num;
			num = (short)1877335063;
			int num3;
			switch ((num2 == num) ? 1 : 0)
			{
			case 0:
			case 2:
				IL_126:
				num = (short)752353282;
				num3 = (int)((global::System.IntPtr)num);
				break;
			default:
				num = (short)1196359680;
				if (num != 0)
				{
				}
				num = (short)708706304;
				num3 = (int)num;
				switch (num3)
				{
				default:
					switch (0)
					{
					case 0:
						goto IL_91;
					}
					break;
				}
				break;
			}
			string text;
			global::System.Globalization.CultureInfo provider;
			global::Motorola.MackinawCPS.CoreFeatures.MissionCriticalGeofence.MissionCriticalGeofenceRecset missionCriticalGeofenceRecset;
			for (;;)
			{
				IL_7E:
				global::System.Collections.Generic.IEnumerator<global::AcpBusinessLayer.FeatureNode> enumerator;
				switch (num3)
				{
				case 0:
					goto IL_F9;
				case 1:
					try
					{
						num = (short)1598423058;
						num3 = (int)((global::System.IntPtr)num);
						for (;;)
						{
							global::Motorola.MackinawCPS.CoreFeatures.MissionCriticalGeofence.CoordinatesInnerRecset coordinatesInnerRecset;
							int num4;
							global::Motorola.MackinawCPS.CoreFeatures.MissionCriticalGeofence.CoordinatesInner coordinatesInner;
							global::Motorola.MackinawCPS.CoreFeatures.MissionCriticalGeofence.MissionCriticalGeofence missionCriticalGeofence;
							switch (num3)
							{
							case 0:
								if (coordinatesInnerRecset != null)
								{
									num = (short)1487208453;
									num3 = (int)((global::System.IntPtr)num);
									continue;
								}
								break;
							case 1:
							{
								string str = text;
								num = (short)1366163478;
								num3 = (int)((global::System.IntPtr)num);
								continue;
							}
							case 2:
								if (coordinatesInnerRecset.Count > 2)
								{
									num = (short)659947530;
									num3 = (int)((global::System.IntPtr)num);
									continue;
								}
								break;
							case 3:
								goto IL_7EE;
							case 4:
								num = (short)463732739;
								num3 = (int)((global::System.IntPtr)num);
								continue;
							case 5:
								num = (short)575406087;
								num3 = (int)((global::System.IntPtr)num);
								continue;
							case 7:
								if (coordinatesInnerRecset.Count != 1)
								{
									num = (short)831717396;
									num3 = (int)((global::System.IntPtr)num);
									continue;
								}
								goto IL_4E3;
							case 8:
								num = (short)937033730;
								num3 = (int)((global::System.IntPtr)num);
								continue;
							case 9:
							{
								string str = "";
								num4 = 0;
								num = (short)1564016652;
								num3 = (int)((global::System.IntPtr)num);
								continue;
							}
							case 10:
							{
								string str;
								text += str;
								num = (short)150142982;
								num3 = (int)((global::System.IntPtr)num);
								continue;
							}
							case 11:
								goto IL_1E2;
							case 12:
								goto IL_1E2;
							case 13:
								if (num4 == 0)
								{
									num = (short)196935681;
									num3 = (int)((global::System.IntPtr)num);
									continue;
								}
								goto IL_686;
							case 14:
								if (coordinatesInnerRecset.Count > 2)
								{
									num = (short)1442381833;
									num3 = (int)((global::System.IntPtr)num);
									continue;
								}
								break;
							case 15:
								if (coordinatesInnerRecset.Count == 2)
								{
									num = (short)1950023696;
									num3 = (int)((global::System.IntPtr)num);
									continue;
								}
								goto IL_647;
							case 16:
								coordinatesInner = (coordinatesInnerRecset[1] as global::Motorola.MackinawCPS.CoreFeatures.MissionCriticalGeofence.CoordinatesInner);
								A_0 += double.Parse(coordinatesInner.CoordinatesInnerSection.McGeofenceLongitude_42893.UIValue, provider).ToString(global::ConstraintHelper.UtilityMack.q);
								A_0 += global::AllFeatures.CodeplugGuid.b("", a_);
								A_0 += double.Parse(coordinatesInner.CoordinatesInnerSection.McGeofenceLatitude_42894.UIValue, provider).ToString(global::ConstraintHelper.UtilityMack.q);
								A_0 += global::AllFeatures.CodeplugGuid.b("", a_);
								A_0 += global::AllFeatures.CodeplugGuid.b("ﳋ", a_);
								A_0 += global::AllFeatures.CodeplugGuid.b("", a_);
								num = (short)520093723;
								num3 = (int)((global::System.IntPtr)num);
								continue;
							case 17:
								coordinatesInnerRecset = (missionCriticalGeofence.General.EmbeddedRecset as global::Motorola.MackinawCPS.CoreFeatures.MissionCriticalGeofence.CoordinatesInnerRecset);
								num = (short)550895616;
								num3 = (int)((global::System.IntPtr)num);
								continue;
							case 18:
								switch (0)
								{
								case 0:
									goto IL_1DD;
								}
								continue;
							case 19:
								goto IL_4E3;
							case 20:
								num = (short)1613299735;
								num3 = (int)((global::System.IntPtr)num);
								continue;
							case 21:
								if (!enumerator.MoveNext())
								{
									num = (short)1831731204;
									num3 = (int)((global::System.IntPtr)num);
									continue;
								}
								missionCriticalGeofence = (global::Motorola.MackinawCPS.CoreFeatures.MissionCriticalGeofence.MissionCriticalGeofence)enumerator.Current;
								num = (short)1669922842;
								num3 = (int)((global::System.IntPtr)num);
								continue;
							case 22:
								goto IL_686;
							case 23:
								if (coordinatesInnerRecset.Count == 2)
								{
									num = (short)95092755;
									num3 = (int)((global::System.IntPtr)num);
									continue;
								}
								num = (short)1003552782;
								num3 = (int)((global::System.IntPtr)num);
								continue;
							case 24:
							{
								if (num4 >= coordinatesInnerRecset.Count)
								{
									num = (short)1008467976;
									num3 = (int)((global::System.IntPtr)num);
									continue;
								}
								global::Motorola.MackinawCPS.CoreFeatures.MissionCriticalGeofence.CoordinatesInner coordinatesInner2 = coordinatesInnerRecset[num4] as global::Motorola.MackinawCPS.CoreFeatures.MissionCriticalGeofence.CoordinatesInner;
								double num5 = double.Parse(coordinatesInner2.CoordinatesInnerSection.McGeofenceLongitude_42893.UIValue, provider);
								double num6 = double.Parse(coordinatesInner2.CoordinatesInnerSection.McGeofenceLatitude_42894.UIValue, provider);
								string str2 = num5.ToString(global::ConstraintHelper.UtilityMack.q);
								string str3 = num6.ToString(global::ConstraintHelper.UtilityMack.q);
								text += str2;
								text += global::AllFeatures.CodeplugGuid.b("", a_);
								text += str3;
								text += global::AllFeatures.CodeplugGuid.b("", a_);
								text += global::AllFeatures.CodeplugGuid.b("ﳋ", a_);
								num = (short)1226178573;
								num3 = (int)((global::System.IntPtr)num);
								continue;
							}
							case 26:
								if (missionCriticalGeofence.General.GeofenceAliasName_42867.Value == global::ConstraintHelper.UtilityMack.j)
								{
									num = (short)144965649;
									num3 = (int)((global::System.IntPtr)num);
									continue;
								}
								break;
							case 27:
								goto IL_647;
							}
							goto IL_1DD;
							IL_1E2:
							num = (short)959643672;
							num3 = (int)((global::System.IntPtr)num);
							continue;
							IL_35C:
							num = (short)2023686165;
							num3 = (int)((global::System.IntPtr)num);
							continue;
							IL_1DD:
							goto IL_35C;
							IL_4E3:
							coordinatesInner = (coordinatesInnerRecset[0] as global::Motorola.MackinawCPS.CoreFeatures.MissionCriticalGeofence.CoordinatesInner);
							double num7 = double.Parse(coordinatesInner.CoordinatesInnerSection.McGeofenceLongitude_42893.UIValue, provider);
							double num8 = double.Parse(coordinatesInner.CoordinatesInnerSection.McGeofenceLatitude_42894.UIValue, provider);
							string text2 = num7.ToString(global::ConstraintHelper.UtilityMack.q);
							string text3 = num8.ToString(global::ConstraintHelper.UtilityMack.q);
							A_0 += text2;
							A_0 += global::AllFeatures.CodeplugGuid.b("", a_);
							A_0 += text3;
							A_0 += global::AllFeatures.CodeplugGuid.b("", a_);
							A_0 += global::AllFeatures.CodeplugGuid.b("ﳋ", a_);
							A_0 += global::AllFeatures.CodeplugGuid.b("", a_);
							num = (short)1212219407;
							num3 = (int)((global::System.IntPtr)num);
							continue;
							IL_647:
							A_1 = missionCriticalGeofence.General.McGeofenceRadiusInMeters_42890.Value;
							text = global::ConstraintHelper.UtilityMack.a(text2, text3, (long)A_1);
							num = (short)8912921;
							num3 = (int)((global::System.IntPtr)num);
							continue;
							IL_686:
							num4++;
							num = (short)1480065035;
							num3 = (int)((global::System.IntPtr)num);
						}
						IL_7EE:
						return text;
					}
					finally
					{
						num = (short)1281818624;
						num3 = (int)((global::System.IntPtr)num);
						for (;;)
						{
							switch (num3)
							{
							case 0:
								switch (0)
								{
								case 0:
									goto IL_825;
								}
								continue;
							case 1:
								goto IL_85E;
							case 2:
								enumerator.Dispose();
								num = (short)708771841;
								num3 = (int)((global::System.IntPtr)num);
								continue;
							}
							IL_825:
							if (enumerator == null)
							{
								break;
							}
							num = (short)951189506;
							num3 = (int)((global::System.IntPtr)num);
						}
						IL_85E:;
					}
					goto IL_861;
				case 2:
					goto IL_861;
				}
				goto IL_91;
				IL_861:
				enumerator = missionCriticalGeofenceRecset.GetEnumerator();
				num = (short)989462529;
				num3 = (int)((global::System.IntPtr)num);
			}
			IL_F9:
			num = (short)1302659073;
			if (num != 0)
			{
			}
			if (missionCriticalGeofenceRecset != null)
			{
				goto IL_126;
			}
			return text;
			IL_91:
			text = "";
			provider = global::System.Globalization.CultureInfo.CreateSpecificCulture(global::System.Threading.Thread.CurrentThread.CurrentCulture.Name);
			missionCriticalGeofenceRecset = (global::AcpCommonLib.FeatureManager.GetFeature(4174) as global::Motorola.MackinawCPS.CoreFeatures.MissionCriticalGeofence.MissionCriticalGeofenceRecset);
			num = (short)1076822016;
			short num9 = num;
			num = (short)826146816;
			num3 = (int)((global::System.IntPtr)num);
			goto IL_7E;
		}

		// Token: 0x0600D0C3 RID: 53443 RVA: 0x00C37D04 File Offset: 0x00C35F04
		private static string a(string A_0, string A_1, long A_2)
		{
			int a_ = 1;
			short num;
			string text;
			for (;;)
			{
				num = (short)841809920;
				int num2 = (int)num;
				switch (num2)
				{
				default:
				{
					switch (0)
					{
					case 0:
						goto IL_47;
					}
					int num3;
					for (;;)
					{
						IL_30:
						switch (num2)
						{
						case 0:
							goto IL_6A;
						case 1:
							goto IL_6A;
						case 2:
							goto IL_A1;
						case 3:
						{
							if (num3 > global::ConstraintHelper.UtilityMack.k)
							{
								num = (short)1602945026;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							double num4 = double.Parse(A_0, global::ConstraintHelper.UtilityMack.q) * global::ConstraintHelper.UtilityMack.p;
							double num5 = double.Parse(A_1, global::ConstraintHelper.UtilityMack.q) * global::ConstraintHelper.UtilityMack.p;
							double num6 = (double)num3 * 3.141592653589793 / 50.0;
							double num7 = (double)A_2 / global::ConstraintHelper.UtilityMack.n;
							double num8 = global::System.Math.Asin(global::System.Math.Sin(num5) * global::System.Math.Cos(num7) + global::System.Math.Cos(num5) * global::System.Math.Sin(num7) * global::System.Math.Cos(num6));
							double num9 = global::System.Math.Atan2(global::System.Math.Sin(num6) * global::System.Math.Sin(num7) * global::System.Math.Cos(num5), global::System.Math.Cos(num7) - global::System.Math.Sin(num5) * global::System.Math.Sin(num8));
							double num10 = (num4 + num9 + global::ConstraintHelper.UtilityMack.o) % (2.0 * global::ConstraintHelper.UtilityMack.o) - global::ConstraintHelper.UtilityMack.o;
							num8 = global::System.Math.Round(num8 * 180.0 / 3.141592653589793, 7);
							text += global::System.Math.Round(num10 * 180.0 / 3.141592653589793, 7).ToString(global::ConstraintHelper.UtilityMack.q);
							text += global::AllFeatures.CodeplugGuid.b("", a_);
							text += num8.ToString(global::ConstraintHelper.UtilityMack.q);
							text += global::AllFeatures.CodeplugGuid.b("", a_);
							text += global::AllFeatures.CodeplugGuid.b("", a_);
							num3++;
							num = (short)1620967424;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						}
						goto IL_47;
						IL_6A:
						num = (short)968622083;
						num2 = (int)((global::System.IntPtr)num);
					}
					IL_A1:
					num = (short)1382413088;
					short num11 = num;
					num = (short)1742205728;
					switch ((num11 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						continue;
					default:
						goto IL_D5;
					}
					IL_47:
					text = "";
					num3 = 0;
					num = (short)747569153;
					num2 = (int)((global::System.IntPtr)num);
					goto IL_30;
				}
				}
			}
			IL_D5:
			num = (short)1028915200;
			if (num != 0)
			{
			}
			num = (short)1227423744;
			short num12 = num;
			num = (short)1547763713;
			if (num != 0)
			{
			}
			return text;
		}

		// Token: 0x0600D0C4 RID: 53444 RVA: 0x00C37FD4 File Offset: 0x00C361D4
		private static void a(string A_0, string A_1, string A_2, string A_3)
		{
			int a_ = 3;
			short num = (short)2125459664;
			short num2 = num;
			num = (short)475197648;
			switch (num2 == num)
			{
			}
			num = (short)275382273;
			if (num != 0)
			{
			}
			num = (short)433127424;
			if (num != 0)
			{
			}
			num = (short)1313734656;
			short num3 = num;
			global::System.Xml.Linq.XNamespace ns = global::AllFeatures.CodeplugGuid.b("곃닅볇뫉ￏꗑꏓꇕ뗙곛믝軟藡跣闥웧蓩觫髭\udfef駱駳髵ퟷ죹틻쳽", a_);
			new global::System.Xml.Linq.XDocument(new object[]
			{
				new global::System.Xml.Linq.XElement(ns + global::AllFeatures.CodeplugGuid.b("꿃ꯅ꓇", a_), new global::System.Xml.Linq.XElement(ns + global::AllFeatures.CodeplugGuid.b("胃꧅ꯇ뿉ꇋꯍ뻏ꛑ", a_), new global::System.Xml.Linq.XElement(ns + global::AllFeatures.CodeplugGuid.b("铃꫅꧇꧉꧋ꏍ뇏ꃑ뿓", a_), new object[]
				{
					new global::System.Xml.Linq.XElement(ns + global::AllFeatures.CodeplugGuid.b("韃닅뇇ꛉ꧋", a_), new object[]
					{
						new global::System.Xml.Linq.XElement(ns + global::AllFeatures.CodeplugGuid.b("裃꿅ꛇ꿉鿋뫍ꧏ뻑뇓", a_), new object[]
						{
							new global::System.Xml.Linq.XElement(ns + global::AllFeatures.CodeplugGuid.b("ꟃ꧅꓇ꗉ뻋", a_), global::AllFeatures.CodeplugGuid.b("苃胅ￇ賉溜﯍雏铑", a_)),
							new global::System.Xml.Linq.XElement(ns + global::AllFeatures.CodeplugGuid.b("돃꿅곇뻉꓋", a_), global::AllFeatures.CodeplugGuid.b("", a_))
						}),
						new global::System.Xml.Linq.XElement(ns + global::AllFeatures.CodeplugGuid.b("铃꧅꓇돉鿋뫍ꧏ뻑뇓", a_), new global::System.Xml.Linq.XElement(ns + global::AllFeatures.CodeplugGuid.b("ꟃ꧅꓇ꗉ뻋", a_), global::AllFeatures.CodeplugGuid.b("胅難柳請裍韑", a_)))
					}),
					new global::System.Xml.Linq.XElement(ns + global::AllFeatures.CodeplugGuid.b("铃꧅꓇돉ꯋꇍ뻏", a_), new global::System.Xml.Linq.XElement(ns + global::AllFeatures.CodeplugGuid.b("ꯃ독볇꿉뻋賍뿏ꟑ뫓닕맗꣙ꗛ韝鏟", a_), new global::System.Xml.Linq.XElement(ns + global::AllFeatures.CodeplugGuid.b("裃꿅ꛇ꿉귋볍苏믑뫓뇕", a_), new object[]
					{
						new global::System.Xml.Linq.XElement(ns + global::AllFeatures.CodeplugGuid.b("ꟃ꧅Ꟈ룉꣋ꟍ뻏돑ꃓ돕ꯗ", a_), A_1),
						new global::System.Xml.Linq.XElement(ns + global::AllFeatures.CodeplugGuid.b("臃뻅볇꿉ꋋ꫍뗏뛑郓럕곗믙", a_), new object[]
						{
							new global::System.Xml.Linq.XElement(ns + global::AllFeatures.CodeplugGuid.b("胃Ʂ볇ꯉ", a_), new object[]
							{
								new global::System.Xml.Linq.XAttribute(global::AllFeatures.CodeplugGuid.b("꫃Ʂꗇ꿉", a_), global::AllFeatures.CodeplugGuid.b("觃闅臇迋ꟍꋏ뇑룓돕鷙맛뇝蛟蟡諣藥跧", a_)),
								new global::System.Xml.Linq.XElement(ns + global::AllFeatures.CodeplugGuid.b("鋃Ʂ꓇뿉꧋", a_), A_2)
							}),
							new global::System.Xml.Linq.XElement(ns + global::AllFeatures.CodeplugGuid.b("胃Ʂ볇ꯉ", a_), new object[]
							{
								new global::System.Xml.Linq.XAttribute(global::AllFeatures.CodeplugGuid.b("꫃Ʂꗇ꿉", a_), global::AllFeatures.CodeplugGuid.b("觃闅臇迋ꟍꋏ뇑룓돕裙뷛뫝觟韡韣", a_)),
								new global::System.Xml.Linq.XElement(ns + global::AllFeatures.CodeplugGuid.b("鋃Ʂ꓇뿉꧋", a_), A_3)
							})
						})
					})))
				})))
			}).Save(A_0);
		}

		// Token: 0x0600D0C5 RID: 53445 RVA: 0x00C3833C File Offset: 0x00C3653C
		// Note: this type is marked as 'beforefieldinit'.
		static UtilityMack()
		{
			int a_ = 7;
			short num = (short)1540029870;
			short num2 = num;
			num = (short)1601437102;
			switch (num2 == num)
			{
			}
			num = (short)211550209;
			if (num != 0)
			{
			}
			num = (short)1957036032;
			if (num != 0)
			{
			}
			num = (short)606666752;
			short num3 = num;
			global::ConstraintHelper.UtilityMack.d = "";
			global::ConstraintHelper.UtilityMack.PropertyChanging = false;
			global::ConstraintHelper.UtilityMack.bOpenFromRMC = false;
			global::ConstraintHelper.UtilityMack.isInCxfEditingMode = false;
			global::ConstraintHelper.UtilityMack.e = false;
			global::ConstraintHelper.UtilityMack.f = false;
			global::ConstraintHelper.UtilityMack.g = "";
			global::ConstraintHelper.UtilityMack.fireDVRSXMLProperty = null;
			global::ConstraintHelper.UtilityMack.h = false;
			global::ConstraintHelper.UtilityMack.ConfigureViewFlag = true;
			global::ConstraintHelper.UtilityMack.i = new double[]
			{
				288.5,
				296.5,
				304.7,
				313.0,
				321.7,
				330.5,
				339.6,
				346.7,
				349.0,
				358.6,
				358.9,
				368.5,
				371.5,
				378.6,
				384.6,
				389.0,
				398.1,
				399.8,
				410.8,
				412.1,
				422.1,
				426.6,
				433.7,
				441.6,
				445.7,
				457.1,
				457.9,
				470.5,
				473.2,
				483.5,
				489.8,
				496.8,
				507.0,
				510.5,
				517.5,
				524.6,
				524.8,
				532.5,
				539.0,
				543.3,
				547.5,
				553.9,
				562.3,
				562.5,
				569.1,
				577.5,
				582.1,
				584.8,
				592.5,
				600.9,
				602.6,
				607.5,
				617.4,
				622.5,
				623.7,
				634.5,
				637.5,
				645.7,
				651.9,
				652.5,
				667.5,
				668.3,
				669.9,
				682.5,
				688.3,
				691.8,
				697.5,
				707.3,
				712.5,
				716.7,
				726.8,
				727.5,
				741.3,
				746.8,
				757.5,
				767.4,
				772.5,
				787.5,
				788.5,
				794.3,
				802.5,
				810.2,
				817.5,
				822.2,
				832.5,
				847.5,
				851.1,
				855.5,
				862.5,
				877.5,
				879.0,
				881.0,
				892.5,
				903.2,
				907.5,
				912.0,
				922.5,
				928.1,
				937.5,
				944.1,
				952.5,
				953.7,
				967.5,
				979.9,
				1006.9,
				1034.7,
				1063.2,
				1092.4,
				1122.5,
				1153.4,
				1185.2,
				1217.8,
				1251.4,
				1285.8,
				1321.2,
				1357.6,
				1395.0,
				1433.4,
				1472.9,
				1513.5,
				1555.2,
				1598.0,
				1642.0,
				1687.2,
				1733.7,
				1781.5,
				1830.5,
				1881.0,
				1930.2,
				1989.1,
				2043.8,
				2094.5,
				2155.6,
				2212.2,
				2271.7,
				2334.6,
				2401.0,
				2468.2
			};
			global::ConstraintHelper.UtilityMack.k = 100;
			global::ConstraintHelper.UtilityMack.l = 10000000;
			global::ConstraintHelper.UtilityMack.m = uint.MaxValue;
			global::ConstraintHelper.UtilityMack.n = 6371008.7;
			global::ConstraintHelper.UtilityMack.o = 3.141592653589793;
			global::ConstraintHelper.UtilityMack.p = global::ConstraintHelper.UtilityMack.o / 180.0;
			global::ConstraintHelper.UtilityMack.q = new global::System.Globalization.CultureInfo(global::AllFeatures.CodeplugGuid.b("귇꓉", a_));
		}

		// Token: 0x040065B8 RID: 26040
		private static bool a;

		// Token: 0x040065B9 RID: 26041
		private static bool b;

		// Token: 0x040065BA RID: 26042
		private static bool c;

		// Token: 0x040065BB RID: 26043
		private static string d;

		// Token: 0x040065BC RID: 26044
		public static bool PropertyChanging;

		// Token: 0x040065BD RID: 26045
		public static bool bOpenFromRMC;

		// Token: 0x040065BE RID: 26046
		public static bool isInCxfEditingMode;

		// Token: 0x040065BF RID: 26047
		private static bool e;

		// Token: 0x040065C0 RID: 26048
		private static bool f;

		// Token: 0x040065C1 RID: 26049
		private static string g;

		// Token: 0x040065C2 RID: 26050
		public static global::ConstraintHelper.UtilityMack.FireDVRSXMLPropertychanged fireDVRSXMLProperty;

		// Token: 0x040065C3 RID: 26051
		private static bool h;

		// Token: 0x040065C4 RID: 26052
		public static bool ConfigureViewFlag;

		// Token: 0x040065C5 RID: 26053
		public const int NUM_MOT_FREQ_CODES = 138;

		// Token: 0x040065C6 RID: 26054
		private static double[] i;

		// Token: 0x040065C7 RID: 26055
		public static global::System.Collections.Generic.List<global::ConstraintHelper.UtilityMack.FCCExceptionRange> TrunkingExceptionRangeList;

		// Token: 0x040065C8 RID: 26056
		public static global::System.Collections.Generic.List<int> ConventionalExceptionPointList;

		// Token: 0x040065C9 RID: 26057
		public static global::System.Collections.Generic.List<global::ConstraintHelper.UtilityMack.FCCExceptionRange> ConventionalExceptionRangeList;

		// Token: 0x040065CA RID: 26058
		private static string j;

		// Token: 0x040065CB RID: 26059
		private static int k;

		// Token: 0x040065CC RID: 26060
		private static int l;

		// Token: 0x040065CD RID: 26061
		private static uint m;

		// Token: 0x040065CE RID: 26062
		private static double n;

		// Token: 0x040065CF RID: 26063
		private static double o;

		// Token: 0x040065D0 RID: 26064
		private static double p;

		// Token: 0x040065D1 RID: 26065
		private static global::System.Globalization.CultureInfo q;

		// Token: 0x020005E9 RID: 1513
		// (Invoke) Token: 0x0600D0C7 RID: 53447
		public delegate void FireDVRSXMLPropertychanged(string name);

		// Token: 0x020005EA RID: 1514
		public enum FrequencyBand
		{
			// Token: 0x040065D3 RID: 26067
			Unknown,
			// Token: 0x040065D4 RID: 26068
			VHF,
			// Token: 0x040065D5 RID: 26069
			UHF1,
			// Token: 0x040065D6 RID: 26070
			UHF2,
			// Token: 0x040065D7 RID: 26071
			P700,
			// Token: 0x040065D8 RID: 26072
			P800,
			// Token: 0x040065D9 RID: 26073
			P900
		}

		// Token: 0x020005EB RID: 1515
		public class FCCExceptionRange
		{
			// Token: 0x0600D0CA RID: 53450 RVA: 0x00C384AC File Offset: 0x00C366AC
			public FCCExceptionRange(int startFreq, int endFreq)
			{
				this.FreqStart = startFreq;
				this.FreqEnd = endFreq;
			}

			// Token: 0x170068C5 RID: 26821
			// (get) Token: 0x0600D0CB RID: 53451 RVA: 0x00C384D0 File Offset: 0x00C366D0
			// (set) Token: 0x0600D0CC RID: 53452 RVA: 0x00C38584 File Offset: 0x00C36784
			public int FreqStart
			{
				[global::System.Runtime.CompilerServices.CompilerGenerated]
				get
				{
					short num = (short)618382586;
					short num2 = num;
					num = (short)123454714;
					switch (num2 == num)
					{
					}
					num = (short)1183842305;
					if (num != 0)
					{
					}
					num = (short)1453981696;
					if (num != 0)
					{
					}
					num = (short)358023168;
					short num3 = num;
					return this.a;
				}
				[global::System.Runtime.CompilerServices.CompilerGenerated]
				set
				{
					short num = (short)1579176408;
					short num2 = num;
					num = (short)1151226328;
					switch (num2 == num)
					{
					}
					num = (short)1962475520;
					if (num != 0)
					{
					}
					num = (short)119668737;
					if (num != 0)
					{
					}
					num = (short)1074331648;
					short num3 = num;
					this.a = value;
				}
			}

			// Token: 0x170068C6 RID: 26822
			// (get) Token: 0x0600D0CD RID: 53453 RVA: 0x00C38634 File Offset: 0x00C36834
			// (set) Token: 0x0600D0CE RID: 53454 RVA: 0x00C386E4 File Offset: 0x00C368E4
			public int FreqEnd
			{
				[global::System.Runtime.CompilerServices.CompilerGenerated]
				get
				{
					short num = (short)931131378;
					short num2 = num;
					num = (short)446427122;
					switch (num2 == num)
					{
					}
					num = (short)808779776;
					if (num != 0)
					{
					}
					num = (short)1258618881;
					if (num != 0)
					{
					}
					num = (short)116785152;
					short num3 = num;
					return this.b;
				}
				[global::System.Runtime.CompilerServices.CompilerGenerated]
				set
				{
					short num = (short)934184224;
					short num2 = num;
					num = (short)1874887968;
					switch (num2 == num)
					{
					}
					num = (short)173998081;
					if (num != 0)
					{
					}
					num = (short)417136640;
					if (num != 0)
					{
					}
					num = (short)648413184;
					short num3 = num;
					this.b = value;
				}
			}

			// Token: 0x040065DA RID: 26074
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			private int a;

			// Token: 0x040065DB RID: 26075
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			private int b;
		}
	}
}
