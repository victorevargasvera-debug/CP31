using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using AcpBusinessLayer;
using AcpBusinessLayer.UndoRedo;
using AcpCommonLib;
using AcpCommonLib.UndoRedo;
using AcpSecurityLib;
using CommonResources;
using ConstraintHelper;
using Motorola.MackinawCPS.CoreFeatures.DataProfiles;
using Motorola.MackinawCPS.CoreFeatures.DVRSWide;
using Motorola.MackinawCPS.CoreFeatures.RadioInformation;
using Motorola.MackinawCPS.CoreFeatures.RadioWide;
using Motorola.MackinawCPS.CoreFeatures.ScanList;
using Motorola.MackinawCPS.CoreFeatures.SecureKMFProfile;
using Motorola.MackinawCPS.CoreFeatures.SecureWide;
using Motorola.MackinawCPS.CoreFeatures.TrunkingPersonality;
using Motorola.MackinawCPS.CoreFeatures.ZoneChannelAssignment;

namespace Motorola.MackinawCPS.CoreFeatures.TrunkingSystem
{
	// Token: 0x0200006C RID: 108
	public static class TrunkingSystemConstraints
	{
		// Token: 0x06000B92 RID: 2962 RVA: 0x000A8B68 File Offset: 0x000A6D68
		internal static bool ConEmerAlrmRxIndicTypeNotNoIndic(global::AcpCommonLib.IAcpFeatureSection self)
		{
			short num = (short)993198080;
			short num2 = num;
			num = (short)645791745;
			if (num != 0)
			{
			}
			num = (short)1628772762;
			short num3 = num;
			num = (short)650647962;
			switch (num3 == num)
			{
			}
			num = (short)1831665664;
			if (num != 0)
			{
			}
			return (self as global::Motorola.MackinawCPS.CoreFeatures.TrunkingSystem.Features).RefEmergencyWide.General.EmerWideGeneralEmergencyAlarmRxIndicatorType_A7933.Value != 0;
		}

		// Token: 0x06000B93 RID: 2963 RVA: 0x000A8C30 File Offset: 0x000A6E30
		internal static bool ConTrkSysTxPwrSelIsHigh(global::AcpCommonLib.IAcpFeatureSection self)
		{
			short num = (short)1788280832;
			short num2 = num;
			num = (short)135019301;
			short num3 = num;
			num = (short)1374567205;
			switch (num3 == num)
			{
			}
			num = (short)812187648;
			if (num != 0)
			{
			}
			num = (short)1658716161;
			if (num != 0)
			{
			}
			return (self.Parent as global::Motorola.MackinawCPS.CoreFeatures.TrunkingSystem.TrunkingSystem).Features.TrkSysFeaturesTxPowerLevel_A9557.Value == 0;
		}

		// Token: 0x06000B94 RID: 2964 RVA: 0x000A8CF4 File Offset: 0x000A6EF4
		internal static bool ConTrkSysTypeIsAstro25(global::AcpCommonLib.IAcpFeatureSection self)
		{
			short num = (short)585105408;
			short num2 = num;
			num = (short)177442330;
			short num3 = num;
			num = (short)2138279450;
			switch (num3 == num)
			{
			}
			num = (short)65667072;
			if (num != 0)
			{
			}
			num = (short)1496252417;
			if (num != 0)
			{
			}
			return (self.Parent as global::Motorola.MackinawCPS.CoreFeatures.TrunkingSystem.TrunkingSystem).General.TrkSysGeneralSystemType_A9252.Value == 3;
		}

		// Token: 0x06000B95 RID: 2965 RVA: 0x000A8DBC File Offset: 0x000A6FBC
		internal static bool ConTrkSysCvgTypeIsSmartZoneAndOmniLink(global::AcpCommonLib.IAcpFeatureSection self)
		{
			switch (0)
			{
			case 0:
				goto IL_20;
			}
			int num;
			global::AcpBusinessLayer.AcpListField trkSysGeneralCoverageType_A;
			short num2;
			for (;;)
			{
				IL_0A:
				switch (num)
				{
				case 0:
					if (trkSysGeneralCoverageType_A.Value != 7)
					{
						num2 = (short)1273233411;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					return true;
				case 1:
					goto IL_148;
				case 2:
					if (trkSysGeneralCoverageType_A.Value != 5)
					{
						num2 = (short)1593704449;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					return true;
				case 3:
					num2 = (short)938278913;
					if (num2 != 0)
					{
					}
					num2 = (short)657719298;
					num = (int)((global::System.IntPtr)num2);
					continue;
				}
				goto IL_20;
			}
			IL_148:
			return trkSysGeneralCoverageType_A.Value == 6;
			IL_20:
			num2 = (short)1392383348;
			short num3 = num2;
			num2 = (short)177280372;
			switch ((num3 == num2) ? 1 : 0)
			{
			case 0:
			case 2:
				goto IL_0A;
			case 1:
				break;
			default:
			{
				num2 = (short)80216064;
				short num4 = num2;
				break;
			}
			}
			num2 = (short)2030108672;
			if (num2 != 0)
			{
			}
			trkSysGeneralCoverageType_A = (self as global::Motorola.MackinawCPS.CoreFeatures.TrunkingSystem.General).TrkSysGeneralCoverageType_A7782;
			num2 = (short)1375141888;
			num = (int)((global::System.IntPtr)num2);
			goto IL_0A;
		}

		// Token: 0x06000B96 RID: 2966 RVA: 0x000A8F14 File Offset: 0x000A7114
		internal static bool ConTrkSysCvgTypeNotSmartZoneOmniLink(global::AcpCommonLib.IAcpFeatureSection self)
		{
			switch (0)
			{
			case 0:
				goto IL_20;
			}
			int num;
			short num2;
			global::AcpBusinessLayer.AcpListField trkSysGeneralCoverageType_A;
			for (;;)
			{
				IL_0A:
				switch (num)
				{
				case 0:
					num2 = (short)441122817;
					if (num2 != 0)
					{
					}
					if (trkSysGeneralCoverageType_A.Value != 7)
					{
						num2 = (short)1793523715;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					return false;
				case 1:
					goto IL_146;
				case 2:
					if (trkSysGeneralCoverageType_A.Value != 5)
					{
						num2 = (short)938606593;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					return false;
				case 3:
					num2 = (short)1546911746;
					num = (int)((global::System.IntPtr)num2);
					continue;
				}
				goto IL_20;
			}
			IL_146:
			return trkSysGeneralCoverageType_A.Value != 6;
			IL_20:
			num2 = (short)303210901;
			short num3 = num2;
			num2 = (short)55812501;
			switch ((num3 == num2) ? 1 : 0)
			{
			case 0:
			case 2:
				goto IL_0A;
			case 1:
				break;
			default:
			{
				num2 = (short)2029387776;
				short num4 = num2;
				break;
			}
			}
			num2 = (short)738394112;
			if (num2 != 0)
			{
			}
			trkSysGeneralCoverageType_A = (self as global::Motorola.MackinawCPS.CoreFeatures.TrunkingSystem.General).TrkSysGeneralCoverageType_A7782;
			num2 = (short)1607925760;
			num = (int)((global::System.IntPtr)num2);
			goto IL_0A;
		}

		// Token: 0x06000B97 RID: 2967 RVA: 0x000A906C File Offset: 0x000A726C
		internal static bool ConTrkSysApcoAndApcoOmnilinkAndAmssSelIsSmartZoneAndAliasIndicatorIsEnabled(global::AcpCommonLib.IAcpFeatureSection self)
		{
			switch (0)
			{
			case 0:
				goto IL_38;
			}
			int num;
			short num2;
			global::Motorola.MackinawCPS.CoreFeatures.TrunkingSystem.TrunkingSystem trunkingSystem;
			global::AcpBusinessLayer.AcpListField trkSysGeneralCoverageType_A;
			for (;;)
			{
				IL_0A:
				switch (num)
				{
				case 0:
				{
					num2 = (short)537985024;
					short num3 = num2;
					if (trunkingSystem.SiteAlias.TrkSysSiteAliasSiteAliasEnable_A9148.Value)
					{
						num2 = (short)110624771;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					return false;
				}
				case 1:
					num2 = (short)27983876;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 2:
				{
					num2 = (short)1605814002;
					short num4 = num2;
					num2 = (short)297649906;
					switch ((num4 == num2) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_EA;
					default:
						num2 = (short)172294144;
						if (num2 != 0)
						{
						}
						if (trkSysGeneralCoverageType_A.Value != 7)
						{
							num2 = (short)1558249473;
							num = (int)((global::System.IntPtr)num2);
							continue;
						}
						goto IL_15D;
					}
					break;
				}
				case 3:
					goto IL_158;
				case 4:
					if (trkSysGeneralCoverageType_A.Value != 5)
					{
						num2 = (short)1782513672;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_15D;
				case 5:
					if (trkSysGeneralCoverageType_A.Value == 6)
					{
						num2 = (short)655360007;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					return false;
				case 6:
					goto IL_EA;
				case 7:
					num2 = (short)1893597185;
					if (num2 != 0)
					{
					}
					goto IL_15D;
				case 8:
					num2 = (short)193134597;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 9:
					if (trunkingSystem.General.TrkSysGeneralSystemType_A9252.Value == 3)
					{
						num2 = (short)693174278;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					return false;
				}
				goto IL_38;
				IL_EA:
				num2 = (short)1709768704;
				num = (int)((global::System.IntPtr)num2);
				continue;
				IL_15D:
				num2 = (short)830537737;
				num = (int)((global::System.IntPtr)num2);
			}
			IL_158:
			global::Motorola.MackinawCPS.CoreFeatures.TrunkingSystem.SiteAliasInnerSection siteAliasInnerSection;
			return siteAliasInnerSection.TrkSysSiteAliasSiteAliasType_A41343.Value == 0;
			IL_38:
			siteAliasInnerSection = (self as global::Motorola.MackinawCPS.CoreFeatures.TrunkingSystem.SiteAliasInnerSection);
			trunkingSystem = (self.ParentRecset.ParentSection.Parent as global::Motorola.MackinawCPS.CoreFeatures.TrunkingSystem.TrunkingSystem);
			trkSysGeneralCoverageType_A = trunkingSystem.General.TrkSysGeneralCoverageType_A7782;
			num2 = (short)1510473730;
			num = (int)((global::System.IntPtr)num2);
			goto IL_0A;
		}

		// Token: 0x06000B98 RID: 2968 RVA: 0x000A92D0 File Offset: 0x000A74D0
		internal static bool ConTrkSysAmssSelIsSmartZone(global::AcpCommonLib.IAcpFeatureSection self)
		{
			switch (0)
			{
			case 0:
				goto IL_28;
			}
			int num;
			global::AcpBusinessLayer.AcpListField trkSysGeneralCoverageType_A;
			short num2;
			for (;;)
			{
				IL_0A:
				switch (num)
				{
				case 0:
					if (trkSysGeneralCoverageType_A.Value != 7)
					{
						num2 = (short)804651009;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					return true;
				case 1:
					num2 = (short)684720132;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 2:
					goto IL_156;
				case 3:
					num2 = (short)598474757;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 4:
					if (trkSysGeneralCoverageType_A.Value != 3)
					{
						num2 = (short)112721923;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					return true;
				case 5:
					if (trkSysGeneralCoverageType_A.Value != 5)
					{
						num2 = (short)1508507650;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					return true;
				}
				goto IL_28;
			}
			IL_156:
			return trkSysGeneralCoverageType_A.Value == 6;
			for (;;)
			{
				IL_28:
				trkSysGeneralCoverageType_A = (self.Parent as global::Motorola.MackinawCPS.CoreFeatures.TrunkingSystem.TrunkingSystem).General.TrkSysGeneralCoverageType_A7782;
				num2 = (short)191294336;
				short num3 = num2;
				num2 = (short)543812480;
				switch ((num3 == num2) ? 1 : 0)
				{
				case 0:
				case 2:
					break;
				default:
					goto IL_73;
				}
			}
			IL_73:
			num2 = (short)2036662272;
			short num4 = num2;
			num2 = (short)585367553;
			if (num2 != 0)
			{
			}
			num2 = (short)1669398528;
			if (num2 != 0)
			{
			}
			num2 = (short)383844352;
			num = (int)((global::System.IntPtr)num2);
			goto IL_0A;
		}

		// Token: 0x06000B99 RID: 2969 RVA: 0x000A9474 File Offset: 0x000A7674
		internal static bool ConTrkSysTypeIsNotAstro25(global::AcpCommonLib.IAcpFeatureSection self)
		{
			short num = (short)235339776;
			short num2 = num;
			num = (short)2102198273;
			if (num != 0)
			{
			}
			num = (short)1633904611;
			short num3 = num;
			num = (short)2017093603;
			switch (num3 == num)
			{
			}
			num = (short)1979908096;
			if (num != 0)
			{
			}
			return (self as global::Motorola.MackinawCPS.CoreFeatures.TrunkingSystem.General).TrkSysGeneralSystemType_A9252.Value != 3;
		}

		// Token: 0x06000B9A RID: 2970 RVA: 0x000A9534 File Offset: 0x000A7734
		internal static bool ConAmssSelIsDisabled(global::AcpCommonLib.IAcpFeatureSection self)
		{
			short num = (short)2093678592;
			short num2 = num;
			num = (short)1716548077;
			short num3 = num;
			num = (short)1918988781;
			switch (num3 == num)
			{
			}
			num = (short)443940864;
			if (num != 0)
			{
			}
			num = (short)515833857;
			if (num != 0)
			{
			}
			return (self as global::Motorola.MackinawCPS.CoreFeatures.TrunkingSystem.General).TrkSysGeneralCoverageType_A7782.Value == 0;
		}

		// Token: 0x06000B9B RID: 2971 RVA: 0x000A95F0 File Offset: 0x000A77F0
		internal static bool conOneTchBtnIsStsAndStsAlsIsEnOrMsgAndMsgAlsEnAndTrkSysTypeNotAstro25OrNotStsOrMsg(global::AcpCommonLib.IAcpFeatureSection self, int index)
		{
			switch (0)
			{
			case 0:
				goto IL_64;
			}
			int num;
			global::AcpBusinessLayer.AcpField<bool> radErgoWideHomeModeHomeModeSelection_A;
			short num2;
			global::Motorola.MackinawCPS.CoreFeatures.TrunkingSystem.TrunkingSystem trunkingSystem;
			global::Motorola.MackinawCPS.CoreFeatures.TrunkingSystem.OneTouchInnerSection oneTouchInnerSection;
			for (;;)
			{
				IL_0A:
				switch (num)
				{
				case 0:
					goto IL_19D;
				case 1:
					goto IL_2E7;
				case 2:
					if (radErgoWideHomeModeHomeModeSelection_A.HiddenStatic)
					{
						num2 = (short)58392584;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_2B8;
				case 3:
					num2 = (short)904724495;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 4:
					if (trunkingSystem.MessageAlias.TrkSysMessageAliasMessageAliasEnable_A8505.Value)
					{
						num2 = (short)1326841856;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					return false;
				case 5:
					if (index != 44)
					{
						num2 = (short)2098135041;
						if (num2 != 0)
						{
						}
						num2 = (short)1160904722;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					num2 = (short)225443844;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 6:
					num2 = (short)1396637708;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 7:
					if (global::ConstraintHelper.UtilityMack.IsPortable())
					{
						num2 = (short)1451032582;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_2B8;
				case 8:
					num2 = (short)819068935;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 9:
					num2 = (short)2022047749;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 10:
				{
					if (index - 36 > 1)
					{
						num2 = (short)1976893443;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					num2 = (short)482641357;
					short num3 = num2;
					num2 = (short)121013709;
					switch ((num3 == num2) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_2E7;
					default:
						num2 = (short)1493434368;
						if (num2 != 0)
						{
						}
						num2 = (short)1759182861;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					break;
				}
				case 11:
					return false;
				case 12:
					if (oneTouchInnerSection.RefDisplayAndMenu.Advanced.RadioErgDispAdvanceStatusAutoExit_42158 != 1)
					{
						num2 = (short)211615763;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_2B8;
				case 13:
					if (radErgoWideHomeModeHomeModeSelection_A.HiddenStatic)
					{
						num2 = (short)1360199681;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					return true;
				case 14:
					return true;
				case 15:
					if (index != 43)
					{
						num2 = (short)284753929;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					num2 = (short)1171914754;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 16:
					if (global::ConstraintHelper.UtilityMack.IsPortable())
					{
						num2 = (short)2105212945;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					return true;
				case 17:
				{
					num2 = (short)507838464;
					short num4 = num2;
					num2 = (short)1509621780;
					num = (int)((global::System.IntPtr)num2);
					continue;
				}
				case 18:
					num2 = (short)396296206;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 19:
					return false;
				case 20:
					if (oneTouchInnerSection.RefDisplayAndMenu.Advanced.RadErgoWideDispMenu_A21430 == 0)
					{
						num2 = (short)976289803;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					return true;
				}
				goto IL_64;
				IL_2E7:
				num2 = (short)1619722256;
				num = (int)((global::System.IntPtr)num2);
			}
			IL_19D:
			return trunkingSystem.General.TrkSysGeneralSystemType_A9252.Value != 3;
			IL_2B8:
			return trunkingSystem.StatusAlias.TrkSysStatusAliasStatusAliasEnable_A9195.Value;
			IL_64:
			oneTouchInnerSection = (self as global::Motorola.MackinawCPS.CoreFeatures.TrunkingSystem.OneTouchInnerSection);
			trunkingSystem = (self.ParentRecset.ParentSection.Parent as global::Motorola.MackinawCPS.CoreFeatures.TrunkingSystem.TrunkingSystem);
			radErgoWideHomeModeHomeModeSelection_A = oneTouchInnerSection.RefRadioErgonomicsWide.HomeMode.RadErgoWideHomeModeHomeModeSelection_A8202;
			num2 = (short)2131034122;
			num = (int)((global::System.IntPtr)num2);
			goto IL_0A;
		}

		// Token: 0x06000B9C RID: 2972 RVA: 0x000A9A00 File Offset: 0x000A7C00
		internal static bool ConOneTouchBtnIsNotSetToDisabled(global::AcpCommonLib.IAcpFeatureSection self)
		{
			short num = (short)746455040;
			short num2 = num;
			num = (short)1812529153;
			if (num != 0)
			{
			}
			num = (short)1623439709;
			short num3 = num;
			num = (short)582596957;
			switch (num3 == num)
			{
			}
			num = (short)1129971712;
			if (num != 0)
			{
			}
			return (self as global::Motorola.MackinawCPS.CoreFeatures.TrunkingSystem.OneTouchInnerSection).TrkSysOneTouchFeature_A8614.Value != 38;
		}

		// Token: 0x06000B9D RID: 2973 RVA: 0x000A9AC0 File Offset: 0x000A7CC0
		public static bool ConIsTrkSysOneTouchAbbreviatedOneTouchAlias(global::AcpCommonLib.IAcpFeatureSection self)
		{
			short num = (short)1217658880;
			short num2 = num;
			num = (short)1353449473;
			if (num != 0)
			{
			}
			num = (short)1720302729;
			short num3 = num;
			num = (short)2055453833;
			switch (num3 == num)
			{
			}
			num = (short)481624064;
			if (num != 0)
			{
			}
			global::Motorola.MackinawCPS.CoreFeatures.TrunkingSystem.OneTouchInnerSection oneTouchInnerSection = self as global::Motorola.MackinawCPS.CoreFeatures.TrunkingSystem.OneTouchInnerSection;
			int num4 = oneTouchInnerSection.ParentRecset.IndexOf(self.Parent) + 1;
			global::AcpBusinessLayer.AcpField<string> trkSysOneTouchAbbreviatedOneTouchAlias_A = oneTouchInnerSection.TrkSysOneTouchAbbreviatedOneTouchAlias_A8622;
			if (trkSysOneTouchAbbreviatedOneTouchAlias_A.Value != null && trkSysOneTouchAbbreviatedOneTouchAlias_A.Value.Length <= 0)
			{
				trkSysOneTouchAbbreviatedOneTouchAlias_A.SetValue(num4.ToString());
			}
			return oneTouchInnerSection.TrkSysOneTouchAbbreviatedOneTouchAlias_A8622 == trkSysOneTouchAbbreviatedOneTouchAlias_A;
		}

		// Token: 0x06000B9E RID: 2974 RVA: 0x000A9BBC File Offset: 0x000A7DBC
		public static bool ConIsTrkOneTouchIndexValid(global::AcpCommonLib.IAcpFeatureSection self)
		{
			short num = (short)1702166528;
			int num2 = (int)num;
			switch (num2)
			{
			default:
			{
				switch (0)
				{
				case 0:
					goto IL_123;
				}
				global::AcpBusinessLayer.AcpListField trkSysGeneralSystemType_A;
				global::AcpBusinessLayer.AcpSimpleRangeField trkSysOneTouchIndex_A;
				global::AcpCommonLib.IAcpRecordset acpRecordset;
				global::AcpCommonLib.IAcpRecordset embeddedRecset;
				global::AcpBusinessLayer.AcpListField trkSysOneTouchFeature_A;
				global::AcpCommonLib.IAcpRecordset embeddedRecset2;
				for (;;)
				{
					IL_28:
					switch (num2)
					{
					case 0:
						if (trkSysGeneralSystemType_A.Value == 3)
						{
							num = (short)749731879;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_5D0;
					case 1:
						num = (short)184025108;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 2:
					{
						num = (short)763887616;
						short num3 = num;
						if (trkSysOneTouchIndex_A.Value <= acpRecordset.Count)
						{
							num = (short)853409834;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_698;
					}
					case 3:
						if (trkSysOneTouchIndex_A.Value <= 8)
						{
							num = (short)2051145774;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_89B;
					case 4:
						if (trkSysOneTouchIndex_A.Value <= 100)
						{
							num = (short)628293658;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_7D5;
					case 5:
						num = (short)1087766575;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 6:
						if (embeddedRecset.Count > 0)
						{
							num = (short)259522593;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_5D0;
					case 7:
						if (trkSysOneTouchIndex_A.Value <= embeddedRecset.Count)
						{
							num = (short)207159347;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_5D0;
					case 8:
						num = (short)1867186224;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 9:
						goto IL_655;
					case 10:
						if (trkSysOneTouchFeature_A.Value == 32)
						{
							num = (short)452067360;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_698;
					case 11:
						if (trkSysOneTouchIndex_A.Value <= 16)
						{
							num = (short)941293583;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_5D0;
					case 12:
						return true;
					case 13:
						if (trkSysOneTouchIndex_A.Value <= 100)
						{
							num = (short)993787935;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_698;
					case 14:
						num = (short)1014759428;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 15:
						num = (short)1506017286;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 16:
						if (trkSysOneTouchIndex_A.Value > 0)
						{
							num = (short)1159593985;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return false;
					case 17:
						if (global::AcpCommonLib.FeatureManager.GetFeature(2220) != null)
						{
							num = (short)881197075;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_9EA;
					case 18:
						if (trkSysOneTouchFeature_A.Value == 38)
						{
							num = (short)948633629;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)884736053;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 19:
						num = (short)653066241;
						if (num != 0)
						{
						}
						num = (short)1863909412;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 20:
						if (trkSysOneTouchIndex_A.Value <= 16)
						{
							num = (short)1125646341;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return false;
					case 21:
					{
						num = (short)1005742082;
						short num4 = num;
						num = (short)1867737090;
						switch ((num4 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_401;
						default:
							num = (short)1340866560;
							if (num != 0)
							{
							}
							if (trkSysOneTouchIndex_A.Value > 0)
							{
								num = (short)999817239;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							goto IL_5D0;
						}
						break;
					}
					case 22:
						num = (short)1829699600;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 23:
						num = (short)1429012491;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 24:
						if (trkSysOneTouchIndex_A.Value <= embeddedRecset.Count)
						{
							num = (short)37027897;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_89B;
					case 25:
						if (trkSysOneTouchFeature_A.Value == 43)
						{
							num = (short)382337068;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_89B;
					case 26:
						return true;
					case 27:
						num = (short)1707343882;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 28:
						acpRecordset = global::AcpCommonLib.FeatureManager.GetFeature(2220)[0][10427].EmbeddedRecset;
						num = (short)568524856;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 29:
						return true;
					case 30:
						if (trkSysOneTouchIndex_A.Value > 0)
						{
							num = (short)1341259790;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_7D5;
					case 31:
						num = (short)1338048555;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 32:
						num = (short)1424490537;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 33:
						num = (short)117309447;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 34:
						num = (short)2025848884;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 35:
						if (trkSysOneTouchIndex_A.Value > 0)
						{
							num = (short)1937506353;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_89B;
					case 36:
						if (global::AcpCommonLib.FeatureManager.GetFeature(2220).Count > 0)
						{
							num = (short)868810780;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_9EA;
					case 37:
						num = (short)753139714;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 38:
						num = (short)63111192;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 39:
						num = (short)1621295125;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 40:
						if (trkSysOneTouchFeature_A.Value == 44)
						{
							num = (short)1354301462;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return false;
					case 41:
						if (trkSysOneTouchIndex_A.Value > 0)
						{
							num = (short)773390396;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_698;
					case 42:
						return true;
					case 43:
						if (acpRecordset.Count > 0)
						{
							num = (short)1034682405;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_698;
					case 44:
						num = (short)1743978551;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 45:
						num = (short)426311715;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 46:
						goto IL_401;
					case 47:
						if (embeddedRecset2.Count > 0)
						{
							num = (short)546439202;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return false;
					case 48:
						if (trkSysOneTouchFeature_A.Value == 37)
						{
							num = (short)579207177;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_7D5;
					case 49:
						num = (short)1087766531;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 50:
						if (embeddedRecset.Count > 0)
						{
							num = (short)1754726438;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_89B;
					case 51:
						return true;
					case 52:
						if (trkSysOneTouchIndex_A.Value <= embeddedRecset2.Count)
						{
							num = (short)1198522380;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return false;
					case 53:
						if (acpRecordset != null)
						{
							num = (short)1574699035;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_698;
					case 54:
						if (trkSysOneTouchFeature_A.Value == 43)
						{
							num = (short)584319035;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_5D0;
					case 55:
						if (trkSysGeneralSystemType_A.Value == 2)
						{
							num = (short)1061552173;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_89B;
					case 56:
						goto IL_9EA;
					case 57:
						return true;
					case 58:
						if (trkSysOneTouchFeature_A.Value != 36)
						{
							num = (short)718012424;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_655;
					case 59:
						num = (short)1233387520;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 60:
						num = (short)556990477;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_123;
					IL_401:
					num = (short)247988274;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_5D0:
					num = (short)1237123112;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_655:
					num = (short)86114334;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_698:
					num = (short)603652154;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_7D5:
					num = (short)285278233;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_89B:
					num = (short)1168703542;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_9EA:
					num = (short)1020461074;
					num2 = (int)((global::System.IntPtr)num);
				}
				return true;
				IL_123:
				global::Motorola.MackinawCPS.CoreFeatures.TrunkingSystem.OneTouchInnerSection oneTouchInnerSection = self as global::Motorola.MackinawCPS.CoreFeatures.TrunkingSystem.OneTouchInnerSection;
				global::Motorola.MackinawCPS.CoreFeatures.TrunkingSystem.TrunkingSystem trunkingSystem = self.ParentRecset.ParentSection.Parent as global::Motorola.MackinawCPS.CoreFeatures.TrunkingSystem.TrunkingSystem;
				trkSysOneTouchFeature_A = oneTouchInnerSection.TrkSysOneTouchFeature_A8614;
				trkSysOneTouchIndex_A = oneTouchInnerSection.TrkSysOneTouchIndex_A8618;
				trkSysGeneralSystemType_A = trunkingSystem.General.TrkSysGeneralSystemType_A9252;
				embeddedRecset2 = self.Parent.Parent.ParentSection.Parent[10163].EmbeddedRecset;
				embeddedRecset = self.Parent.Parent.ParentSection.Parent[10173].EmbeddedRecset;
				acpRecordset = null;
				num = (short)621215761;
				num2 = (int)((global::System.IntPtr)num);
				goto IL_28;
			}
			}
		}

		// Token: 0x06000B9F RID: 2975 RVA: 0x000AA640 File Offset: 0x000A8840
		internal static bool ConTrkInCallRstTypeIsNotManual(global::AcpCommonLib.IAcpFeatureSection self)
		{
			short num = (short)1781122117;
			short num2 = num;
			num = (short)808436805;
			switch (num2 == num)
			{
			}
			num = (short)1340932097;
			if (num != 0)
			{
			}
			num = (short)1426980864;
			if (num != 0)
			{
			}
			num = (short)1262616576;
			short num3 = num;
			return (self as global::Motorola.MackinawCPS.CoreFeatures.TrunkingSystem.Features).TrkSysFeaturesICUAReset_A8249.Value != 0;
		}

		// Token: 0x06000BA0 RID: 2976 RVA: 0x000AA6FC File Offset: 0x000A88FC
		internal static bool ConBandSelIsNot900MHz(global::AcpCommonLib.IAcpFeatureSection self)
		{
			short num = (short)1282779620;
			short num2 = num;
			num = (short)159820260;
			switch (num2 == num)
			{
			}
			num = (short)2103050241;
			if (num != 0)
			{
			}
			num = (short)607911936;
			if (num != 0)
			{
			}
			num = (short)1398603776;
			short num3 = num;
			return (self.Parent as global::Motorola.MackinawCPS.CoreFeatures.TrunkingSystem.TrunkingSystem).General.TrkSysGeneralTypeIIFrequencyBand_A12491.Value != 4;
		}

		// Token: 0x06000BA1 RID: 2977 RVA: 0x000AA7C4 File Offset: 0x000A89C4
		internal static bool ConTrkSysIfAmssIsSmartZone(global::AcpCommonLib.IAcpFeatureSection self)
		{
			switch (0)
			{
			case 0:
				goto IL_28;
			}
			short num2;
			global::AcpBusinessLayer.AcpListField trkSysGeneralCoverageType_A;
			for (;;)
			{
				IL_0A:
				int num;
				switch (num)
				{
				case 0:
					num2 = (short)283443205;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 1:
					num2 = (short)355598340;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 2:
					if (trkSysGeneralCoverageType_A.Value != 7)
					{
						num2 = (short)1447690240;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					return true;
				case 3:
					goto IL_12A;
				case 4:
					if (trkSysGeneralCoverageType_A.Value != 5)
					{
						num2 = (short)1538064387;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					return true;
				case 5:
					goto IL_16D;
				}
				goto IL_28;
			}
			IL_12A:
			num2 = (short)560791552;
			short num3 = num2;
			return trkSysGeneralCoverageType_A.Value == 6;
			IL_16D:
			if (trkSysGeneralCoverageType_A.Value != 3)
			{
				goto IL_176;
			}
			return true;
			IL_28:
			trkSysGeneralCoverageType_A = (self as global::Motorola.MackinawCPS.CoreFeatures.TrunkingSystem.General).TrkSysGeneralCoverageType_A7782;
			num2 = (short)92685996;
			short num4 = num2;
			num2 = (short)457721516;
			switch ((num4 == num2) ? 1 : 0)
			{
			case 0:
			case 2:
			{
				IL_176:
				num2 = (short)1036058625;
				int num = (int)((global::System.IntPtr)num2);
				goto IL_0A;
			}
			default:
			{
				num2 = (short)682033153;
				if (num2 != 0)
				{
				}
				num2 = (short)1723400192;
				if (num2 != 0)
				{
				}
				num2 = (short)98697218;
				int num = (int)((global::System.IntPtr)num2);
				goto IL_0A;
			}
			}
		}

		// Token: 0x06000BA2 RID: 2978 RVA: 0x000AA964 File Offset: 0x000A8B64
		internal static bool ConSetTrkRadInhValid(global::AcpCommonLib.IAcpFeatureSection self)
		{
			short num = (short)1899560960;
			int num2 = (int)num;
			switch (num2)
			{
			default:
			{
				switch (0)
				{
				case 0:
					goto IL_C8;
				}
				bool flag;
				bool flag2;
				global::Motorola.MackinawCPS.CoreFeatures.RadioInformation.RadioInformation radioInformation;
				global::Motorola.MackinawCPS.CoreFeatures.TrunkingSystem.TrunkingSystem trunkingSystem;
				global::Motorola.MackinawCPS.CoreFeatures.TrunkingSystem.Features features;
				global::Motorola.MackinawCPS.CoreFeatures.RadioWide.RadioWide radioWide;
				for (;;)
				{
					IL_29:
					switch (num2)
					{
					case 0:
						if (!flag && !flag2)
						{
							num = (short)112394250;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return true;
					case 1:
						if (!radioInformation.Labtool.RadInfoLabtoolQA01749LegacySWEnable_A37151.Value)
						{
							num = (short)1319370778;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_4F5;
					case 2:
						flag2 = global::AcpSecurityLib.SecurityManager.IsSystemKeyLoaded(trunkingSystem.General.TrkSysGeneralSystemID_A9239.Value, 0, false);
						num = (short)528154628;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 3:
						if (!radioInformation.Labtool.RadInfoLabtoolQA01648ASKEnable_A37150.Value)
						{
							num = (short)1973682188;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_27E;
					case 4:
						goto IL_3D4;
					case 5:
						num = (short)1531314176;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 6:
						if (features.RefSecureWide.General.SecWideGeneralOTAREnable_A7966.Value)
						{
							num = (short)1829175326;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_59E;
					case 7:
						goto IL_3D4;
					case 8:
						if (!features.TrkSysFeaturesRadioInhibit_A8833.Value)
						{
							num = (short)1531641892;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return true;
					case 9:
						if (trunkingSystem.General.TrkSysGeneralSystemType_A9252.Value == 2)
						{
							num = (short)1903558661;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_3AB;
					case 10:
						goto IL_279;
					case 11:
						if (features.RefSecureWide.General.SecWideGeneralSecureOperation_A9067.Value == 3)
						{
							num = (short)923729937;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_59E;
					case 12:
						flag = global::AcpSecurityLib.SecurityManager.IsSystemKeyLoaded(trunkingSystem.General.TrkSysGeneralSystemID_A9239.Value, 0, false);
						goto IL_73E;
					case 13:
						num = (short)1463222306;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 14:
						if (radioInformation.Labtool.RadInfoLabtoolQA01749LegacySWEnable_A37151.Value)
						{
							num = (short)837419041;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_27E;
					case 15:
						num = (short)1191837718;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 16:
						num = (short)118685724;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 17:
						num = (short)142344216;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 18:
						goto IL_59E;
					case 19:
						num = (short)2111963147;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 20:
						num = (short)1552351267;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 21:
						goto IL_1A3;
					case 22:
						if (trunkingSystem.SecureMultikey.TrkSysSecureMultikeyASTROOTAR_A7494.Value)
						{
							num = (short)1861746704;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_59E;
					case 23:
						if (trunkingSystem.General.TrkSysGeneralSystemType_A9252.Value == 3)
						{
							num = (short)1858142223;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_59E;
					case 24:
						if (features.RefSecureWide.General.SecureWideAESAlgorithmEnable_43201.Value)
						{
							num = (short)120520725;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_59E;
					case 25:
						if (radioInformation.Labtool.RadInfoLabtoolQA01648ASKEnable_A37150.Value)
						{
							num = (short)1457651725;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_4F5;
					case 26:
						num = (short)1326120985;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 27:
					{
						num = (short)546635776;
						short num3 = num;
						goto IL_3D4;
					}
					case 28:
						if (trunkingSystem.General.TrkSysGeneralDataProfileSelection_A19449.Value == 0)
						{
							num = (short)1005977618;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return true;
					case 29:
						goto IL_3D4;
					case 30:
						num = (short)116916255;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 31:
						if (features.RefSecureWide.ASTROOTAR.SecWideASTROOTARASTROOTAREnable_A7496.Value)
						{
							num = (short)1539112980;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_59E;
					case 32:
						num = (short)1234567191;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 33:
						num = (short)1497759747;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 34:
						if (!radioWide.General.RadWideGeneralASKRequired_A37152.Value)
						{
							num = (short)515964930;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						flag2 = global::AcpSecurityLib.SecurityManager.IsSystemKeyLoaded(trunkingSystem.General.TrkSysGeneralSystemID_A9239.Value, 0, true);
						num = (short)438370311;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 35:
						if (features.RefSecureWide.ASTROOTAR.SecWideASTROOTARRadioInhibitviaASTROOTAR_A8834.Value)
						{
							num = (short)375390240;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_59E;
					case 36:
						num = (short)2043805733;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 37:
						if (features.RefSecureWide.General.SecWideGeneralSecureOperation_A9067.Value != 1)
						{
							num = (short)1859125267;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_1A3;
					}
					goto IL_C8;
					IL_1A3:
					num = (short)1817903110;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_27E:
					num = (short)1646657537;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_3D4:
					trunkingSystem.General.TrkSysGeneralSystemID_A9239.CalculateValidity();
					num = (short)931987464;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_4F5:
					flag2 = global::AcpSecurityLib.SecurityManager.IsSystemKeyLoaded(trunkingSystem.General.TrkSysGeneralSystemID_A9239.Value, 0, true);
					num = (short)1371273096;
					short num4 = num;
					num = (short)809367432;
					switch ((num4 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						IL_73E:
						num = (short)514195485;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					default:
						num = (short)72744960;
						if (num != 0)
						{
						}
						num = (short)1620901915;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					IL_59E:
					num = (short)852885513;
					num2 = (int)((global::System.IntPtr)num);
				}
				IL_279:
				return trunkingSystem.General.TrkSysGeneralSystemID_A9239.Valid;
				IL_3AB:
				num = (short)190906369;
				if (num != 0)
				{
				}
				return false;
				IL_C8:
				features = (self as global::Motorola.MackinawCPS.CoreFeatures.TrunkingSystem.Features);
				trunkingSystem = (self.Parent as global::Motorola.MackinawCPS.CoreFeatures.TrunkingSystem.TrunkingSystem);
				radioInformation = (global::AcpCommonLib.FeatureManager.GetFeature(2049)[0] as global::Motorola.MackinawCPS.CoreFeatures.RadioInformation.RadioInformation);
				radioWide = (global::AcpCommonLib.FeatureManager.GetFeature(2045)[0] as global::Motorola.MackinawCPS.CoreFeatures.RadioWide.RadioWide);
				flag = false;
				flag2 = false;
				num = (short)333905934;
				num2 = (int)((global::System.IntPtr)num);
				goto IL_29;
			}
			}
		}

		// Token: 0x06000BA3 RID: 2979 RVA: 0x000AB118 File Offset: 0x000A9318
		internal static bool ConTrkSysTypeIIAndTrkRemoteMonTraceEn(global::AcpCommonLib.IAcpFeatureSection self)
		{
			short num = (short)1108190704;
			short num2 = num;
			num = (short)478455280;
			switch ((num2 == num) ? 1 : 0)
			{
			case 0:
			case 2:
				goto IL_C4;
			case 1:
				break;
			default:
			{
				num = (short)386793472;
				short num3 = num;
				break;
			}
			}
			num = (short)2109472769;
			if (num != 0)
			{
			}
			num = (short)687472640;
			if (num != 0)
			{
			}
			global::Motorola.MackinawCPS.CoreFeatures.TrunkingSystem.Features features = self as global::Motorola.MackinawCPS.CoreFeatures.TrunkingSystem.Features;
			if ((self.Parent as global::Motorola.MackinawCPS.CoreFeatures.TrunkingSystem.TrunkingSystem).General.TrkSysGeneralSystemType_A9252.Value != 2)
			{
				return false;
			}
			IL_C4:
			return features.TrkSysFeaturesEnable_A7968.Value;
		}

		// Token: 0x06000BA4 RID: 2980 RVA: 0x000AB1F8 File Offset: 0x000A93F8
		internal static bool ConTrkSysDynRegrIsEnabled(global::AcpCommonLib.IAcpFeatureSection self)
		{
			short num = (short)1832919900;
			short num2 = num;
			num = (short)1232610140;
			switch (num2 == num)
			{
			}
			num = (short)2068250624;
			if (num != 0)
			{
			}
			num = (short)1335754753;
			if (num != 0)
			{
			}
			num = (short)1087700992;
			short num3 = num;
			return (self as global::Motorola.MackinawCPS.CoreFeatures.TrunkingSystem.Features).TrkSysFeaturesDynamicRegroupingEnable_A7969.Value;
		}

		// Token: 0x06000BA5 RID: 2981 RVA: 0x000AB2B4 File Offset: 0x000A94B4
		public static void ConSetValueKMFProfileIndex(global::AcpCommonLib.IAcpFeatureSection self, global::AcpCommonLib.UndoRedo.ContainerTask task)
		{
			switch (0)
			{
			case 0:
				goto IL_34;
			}
			int num;
			global::AcpBusinessLayer.AcpField<bool> trkSysSecureMultikeyASTROOTAR_A;
			short num2;
			global::AcpBusinessLayer.AcpRecRefField trkSysSecureMultikeyKMFProfileIndex_A;
			for (;;)
			{
				IL_0A:
				switch (num)
				{
				case 0:
					if (!trkSysSecureMultikeyASTROOTAR_A.Value)
					{
						num2 = (short)1881473032;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_156;
				case 1:
				{
					num2 = (short)184877056;
					short num3 = num2;
					if (trkSysSecureMultikeyKMFProfileIndex_A.Value < 1)
					{
						num2 = (short)1070071815;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					return;
				}
				case 2:
					if (trkSysSecureMultikeyKMFProfileIndex_A != null)
					{
						num2 = (short)786104326;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					return;
				case 3:
					return;
				case 4:
					num2 = (short)1328873473;
					if (num2 != 0)
					{
					}
					if (trkSysSecureMultikeyASTROOTAR_A != null)
					{
						num2 = (short)1460928517;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_156;
				case 5:
					num2 = (short)3670016;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 6:
					goto IL_A5;
				case 7:
				{
					num2 = (short)500249254;
					short num4 = num2;
					num2 = (short)286732966;
					switch ((num4 == num2) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_A5;
					default:
					{
						num2 = (short)368574464;
						if (num2 != 0)
						{
						}
						global::Motorola.MackinawCPS.CoreFeatures.SecureKMFProfile.SecureKMFProfile secureKMFProfile = global::AcpCommonLib.FeatureManager.GetFeature(2055)[0] as global::Motorola.MackinawCPS.CoreFeatures.SecureKMFProfile.SecureKMFProfile;
						trkSysSecureMultikeyKMFProfileIndex_A.UIValue = secureKMFProfile.ReferenceKey;
						num2 = (short)445186051;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					}
					break;
				}
				case 8:
					goto IL_1C6;
				}
				goto IL_34;
				IL_A5:
				num2 = (short)334954497;
				num = (int)((global::System.IntPtr)num2);
				continue;
				IL_156:
				num2 = (short)430374914;
				num = (int)((global::System.IntPtr)num2);
			}
			IL_1C6:
			trkSysSecureMultikeyKMFProfileIndex_A.Value = 0;
			return;
			IL_34:
			global::Motorola.MackinawCPS.CoreFeatures.TrunkingSystem.SecureMultikey secureMultikey = self as global::Motorola.MackinawCPS.CoreFeatures.TrunkingSystem.SecureMultikey;
			trkSysSecureMultikeyKMFProfileIndex_A = secureMultikey.TrkSysSecureMultikeyKMFProfileIndex_A8382;
			trkSysSecureMultikeyASTROOTAR_A = secureMultikey.TrkSysSecureMultikeyASTROOTAR_A7494;
			num2 = (short)1653276676;
			num = (int)((global::System.IntPtr)num2);
			goto IL_0A;
		}

		// Token: 0x06000BA6 RID: 2982 RVA: 0x000AB4D0 File Offset: 0x000A96D0
		internal static bool ConTrkAstroOtarAvailable(global::AcpCommonLib.IAcpFeatureSection self)
		{
			switch (0)
			{
			case 0:
				goto IL_83;
			}
			short num;
			int num3;
			global::Motorola.MackinawCPS.CoreFeatures.TrunkingSystem.SecureMultikey secureMultikey;
			global::AcpBusinessLayer.AcpListField secWideGeneralSecureOperation_A;
			global::Motorola.MackinawCPS.CoreFeatures.TrunkingSystem.TrunkingSystem trunkingSystem;
			for (;;)
			{
				IL_0A:
				num = (short)2074563953;
				short num2 = num;
				num = (short)927880561;
				switch ((num2 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					return false;
				default:
					num = (short)942014464;
					if (num != 0)
					{
					}
					switch (num3)
					{
					case 0:
						if (secureMultikey.RefSecureWide.ASTROOTAR.SecWideASTROOTARASTROOTAREnable_A7496.Value)
						{
							num = (short)1640824834;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						}
						return false;
					case 1:
						goto IL_15E;
					case 2:
						goto IL_159;
					case 3:
					{
						num = (short)336986112;
						short num4 = num;
						num = (short)1014824960;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 4:
						if (secureMultikey.RefSecureWide.General.SecureWideAESAlgorithmEnable_43201.Value)
						{
							num = (short)1987313665;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						}
						return false;
					case 5:
						if (secWideGeneralSecureOperation_A.Value != 1)
						{
							num = (short)1569849350;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_15E;
					case 6:
						num = (short)1163329537;
						if (num != 0)
						{
						}
						num = (short)1962278919;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					case 7:
						if (secWideGeneralSecureOperation_A.Value == 3)
						{
							num = (short)1902051337;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						}
						return false;
					case 8:
						if (trunkingSystem.General.TrkSysGeneralSystemType_A9252.Value == 3)
						{
							num = (short)478478339;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						}
						return false;
					case 9:
						num = (short)960430084;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_83;
					IL_15E:
					num = (short)1850998792;
					num3 = (int)((global::System.IntPtr)num);
					break;
				}
			}
			IL_159:
			return secureMultikey.RefSecureWide.General.SecWideGeneralOTAREnable_A7966.Value;
			IL_83:
			secureMultikey = (self as global::Motorola.MackinawCPS.CoreFeatures.TrunkingSystem.SecureMultikey);
			trunkingSystem = (self.Parent as global::Motorola.MackinawCPS.CoreFeatures.TrunkingSystem.TrunkingSystem);
			secWideGeneralSecureOperation_A = secureMultikey.RefSecureWide.General.SecWideGeneralSecureOperation_A9067;
			num = (short)1960706053;
			num3 = (int)((global::System.IntPtr)num);
			goto IL_0A;
		}

		// Token: 0x06000BA7 RID: 2983 RVA: 0x000AB748 File Offset: 0x000A9948
		internal static bool ConSecOperationIsHardware(global::AcpCommonLib.IAcpFeatureSection self)
		{
			short num = (short)584515585;
			if (num != 0)
			{
			}
			num = (short)1169956512;
			short num2 = num;
			num = (short)1229463200;
			switch (num2 == num)
			{
			}
			num = (short)1552613376;
			if (num != 0)
			{
			}
			num = (short)1545338880;
			short num3 = num;
			return (self as global::Motorola.MackinawCPS.CoreFeatures.TrunkingSystem.SecureMultikey).RefSecureWide.General.SecWideGeneralSecureOperation_A9067.Value == 1;
		}

		// Token: 0x06000BA8 RID: 2984 RVA: 0x000AB80C File Offset: 0x000A9A0C
		internal static bool ConDependOnTrkSysTypeAndAmssSelect(global::AcpCommonLib.IAcpFeatureSection self)
		{
			switch (0)
			{
			case 0:
				goto IL_28;
			}
			short num2;
			global::AcpBusinessLayer.AcpListField trkSysGeneralCoverageType_A;
			for (;;)
			{
				IL_0A:
				int num;
				switch (num)
				{
				case 0:
				{
					num2 = (short)2117664768;
					short num3 = num2;
					num2 = (short)1862664197;
					num = (int)((global::System.IntPtr)num2);
					continue;
				}
				case 1:
					num2 = (short)1575616513;
					if (num2 != 0)
					{
					}
					num2 = (short)447152132;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 2:
					if (trkSysGeneralCoverageType_A.Value != 3)
					{
						num2 = (short)1366753280;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					return true;
				case 3:
					goto IL_10C;
				case 4:
					if (trkSysGeneralCoverageType_A.Value != 5)
					{
						num2 = (short)55836675;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					return true;
				case 5:
					goto IL_150;
				}
				goto IL_28;
			}
			IL_10C:
			return trkSysGeneralCoverageType_A.Value == 6;
			IL_150:
			if (trkSysGeneralCoverageType_A.Value != 7)
			{
				goto IL_159;
			}
			return true;
			IL_28:
			trkSysGeneralCoverageType_A = (self.Parent as global::Motorola.MackinawCPS.CoreFeatures.TrunkingSystem.TrunkingSystem).General.TrkSysGeneralCoverageType_A7782;
			num2 = (short)1545268839;
			short num4 = num2;
			num2 = (short)1941958247;
			switch ((num4 == num2) ? 1 : 0)
			{
			case 0:
			case 2:
			{
				IL_159:
				num2 = (short)43712513;
				int num = (int)((global::System.IntPtr)num2);
				goto IL_0A;
			}
			default:
			{
				num2 = (short)1565589504;
				if (num2 != 0)
				{
				}
				num2 = (short)1404108802;
				int num = (int)((global::System.IntPtr)num2);
				goto IL_0A;
			}
			}
		}

		// Token: 0x06000BA9 RID: 2985 RVA: 0x000AB9B8 File Offset: 0x000A9BB8
		internal static bool ConDynTlkGrpAndMultiKeyAndHWOrADPAndTrkSysTypeIsApco(global::AcpCommonLib.IAcpFeatureSection self)
		{
			short num = (short)211561359;
			short num2 = num;
			num = (short)659434383;
			switch ((num2 == num) ? 1 : 0)
			{
			case 0:
			case 2:
				goto IL_91;
			case 1:
				break;
			default:
			{
				num = (short)1152581632;
				short num3 = num;
				break;
			}
			}
			num = (short)1505951744;
			if (num != 0)
			{
			}
			if (!(self.Parent as global::Motorola.MackinawCPS.CoreFeatures.TrunkingSystem.TrunkingSystem).Features.TrkSysFeaturesDynamicRegroupingEnable_A7969.Value)
			{
				num = (short)161284097;
				if (num != 0)
				{
				}
				return false;
			}
			IL_91:
			return global::Motorola.MackinawCPS.CoreFeatures.TrunkingSystem.TrunkingSystemConstraints.IsKeySelectApplicable(self);
		}

		// Token: 0x06000BAA RID: 2986 RVA: 0x000ABA88 File Offset: 0x000A9C88
		internal static bool ConBoolTrkSysTrkMsgAlsIndicatorIsEnableAndTrkSysTypeNotAstro25(global::AcpCommonLib.IAcpFeatureSection self)
		{
			short num = (short)97189889;
			if (num != 0)
			{
			}
			num = (short)272039936;
			short num2 = num;
			num = (short)683713981;
			short num3 = num;
			num = (short)1733928381;
			global::Motorola.MackinawCPS.CoreFeatures.TrunkingSystem.TrunkingSystem trunkingSystem;
			switch ((num3 == num) ? 1 : 0)
			{
			case 0:
			case 2:
				break;
			default:
				num = (short)1997471744;
				if (num != 0)
				{
				}
				trunkingSystem = (self.ParentRecset.ParentSection.Parent as global::Motorola.MackinawCPS.CoreFeatures.TrunkingSystem.TrunkingSystem);
				if (!trunkingSystem.MessageAlias.TrkSysMessageAliasMessageAliasEnable_A8505.Value)
				{
					return false;
				}
				break;
			}
			return trunkingSystem.General.TrkSysGeneralSystemType_A9252.Value != 3;
		}

		// Token: 0x06000BAB RID: 2987 RVA: 0x000ABB74 File Offset: 0x000A9D74
		internal static bool ConTrkSysTypeIsII(global::AcpCommonLib.IAcpFeatureSection self)
		{
			short num = (short)292931782;
			short num2 = num;
			num = (short)131123398;
			switch (num2 == num)
			{
			}
			num = (short)879493120;
			if (num != 0)
			{
			}
			num = (short)1547894785;
			if (num != 0)
			{
			}
			num = (short)1258946560;
			short num3 = num;
			return (self.Parent as global::Motorola.MackinawCPS.CoreFeatures.TrunkingSystem.TrunkingSystem).General.TrkSysGeneralSystemType_A9252.Value == 2;
		}

		// Token: 0x06000BAC RID: 2988 RVA: 0x000ABC3C File Offset: 0x000A9E3C
		internal static bool ConListinfoTrkSysTrkSysTypeIsNotAST25(global::AcpCommonLib.IAcpFeatureSection self)
		{
			short num = (short)559087617;
			if (num != 0)
			{
			}
			num = (short)843981182;
			short num2 = num;
			num = (short)1013981566;
			switch (num2 == num)
			{
			}
			num = (short)1689518080;
			if (num != 0)
			{
			}
			num = (short)909836288;
			short num3 = num;
			return (self.Parent as global::Motorola.MackinawCPS.CoreFeatures.TrunkingSystem.TrunkingSystem).General.TrkSysGeneralSystemType_A9252.Value != 3;
		}

		// Token: 0x06000BAD RID: 2989 RVA: 0x000ABD08 File Offset: 0x000A9F08
		internal static bool ConHWOrADPAndTrkSysTypeApco(global::AcpCommonLib.IAcpFeatureSection self)
		{
			switch (0)
			{
			case 0:
				goto IL_20;
			}
			int num;
			global::AcpBusinessLayer.AcpListField secWideGeneralSecureOperation_A;
			short num2;
			for (;;)
			{
				IL_0A:
				switch (num)
				{
				case 0:
					if (secWideGeneralSecureOperation_A.Value != 1)
					{
						num2 = (short)732168194;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					return true;
				case 1:
					num2 = (short)812187649;
					if (num2 != 0)
					{
					}
					if (secWideGeneralSecureOperation_A.Value == 3)
					{
						num2 = (short)1452998659;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					return false;
				case 2:
				{
					num2 = (short)742653952;
					short num3 = num2;
					num2 = (short)2111766529;
					num = (int)((global::System.IntPtr)num2);
					continue;
				}
				case 3:
					goto IL_164;
				}
				goto IL_20;
			}
			return false;
			IL_164:
			num2 = (short)62151903;
			short num4 = num2;
			num2 = (short)625368287;
			global::Motorola.MackinawCPS.CoreFeatures.TrunkingSystem.TrunkingSystem trunkingSystem;
			switch ((num4 == num2) ? 1 : 0)
			{
			case 0:
			case 2:
				return true;
			default:
				num2 = (short)1097924608;
				if (num2 != 0)
				{
				}
				return trunkingSystem.General.TrkSysGeneralSystemType_A9252.Value == 3;
			}
			IL_20:
			global::Motorola.MackinawCPS.CoreFeatures.TrunkingSystem.SecureMultikey secureMultikey = self as global::Motorola.MackinawCPS.CoreFeatures.TrunkingSystem.SecureMultikey;
			trunkingSystem = (self.Parent as global::Motorola.MackinawCPS.CoreFeatures.TrunkingSystem.TrunkingSystem);
			secWideGeneralSecureOperation_A = secureMultikey.RefSecureWide.General.SecWideGeneralSecureOperation_A9067;
			num2 = (short)1048182784;
			num = (int)((global::System.IntPtr)num2);
			goto IL_0A;
		}

		// Token: 0x06000BAE RID: 2990 RVA: 0x000ABE80 File Offset: 0x000AA080
		internal static bool ConSecOperNotDisabledAndTrkSysTypeApco(global::AcpCommonLib.IAcpFeatureSection self)
		{
			short num;
			global::Motorola.MackinawCPS.CoreFeatures.TrunkingSystem.TrunkingSystem trunkingSystem;
			for (;;)
			{
				num = (short)716242944;
				short num2 = num;
				global::Motorola.MackinawCPS.CoreFeatures.TrunkingSystem.SecureMultikey secureMultikey = self as global::Motorola.MackinawCPS.CoreFeatures.TrunkingSystem.SecureMultikey;
				trunkingSystem = (self.Parent as global::Motorola.MackinawCPS.CoreFeatures.TrunkingSystem.TrunkingSystem);
				if (secureMultikey.RefSecureWide.General.SecWideGeneralSecureOperation_A9067.Value == 0)
				{
					return false;
				}
				num = (short)717243070;
				short num3 = num;
				num = (short)342901438;
				switch ((num3 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					break;
				default:
					goto IL_88;
				}
			}
			IL_88:
			num = (short)159449088;
			if (num != 0)
			{
			}
			num = (short)197525505;
			if (num != 0)
			{
			}
			return trunkingSystem.General.TrkSysGeneralSystemType_A9252.Value == 3;
		}

		// Token: 0x06000BAF RID: 2991 RVA: 0x000ABF6C File Offset: 0x000AA16C
		internal static bool ConSecEqpIsEnabledAndTrkSysTypeIIAndDynRgrpIsEnAndSecTypeIsHW(global::AcpCommonLib.IAcpFeatureSection self)
		{
			switch (0)
			{
			case 0:
				goto IL_28;
			}
			int num;
			global::Motorola.MackinawCPS.CoreFeatures.TrunkingSystem.TrunkingSystem trunkingSystem;
			short num2;
			global::Motorola.MackinawCPS.CoreFeatures.TrunkingSystem.SecureMultikey secureMultikey;
			for (;;)
			{
				IL_0A:
				switch (num)
				{
				case 0:
					if (trunkingSystem.Features.TrkSysFeaturesDynamicRegroupingEnable_A7969.Value)
					{
						num2 = (short)846856195;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					return false;
				case 1:
					if (trunkingSystem.General.TrkSysGeneralSystemType_A9252.Value == 2)
					{
						num2 = (short)1698758661;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					return false;
				case 2:
				{
					num2 = (short)638623823;
					short num3 = num2;
					num2 = (short)64069711;
					switch ((num3 == num2) ? 1 : 0)
					{
					case 0:
					case 2:
						break;
					default:
						num2 = (short)962527233;
						if (num2 != 0)
						{
						}
						num2 = (short)888143872;
						if (num2 != 0)
						{
						}
						num2 = (short)1353973761;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					break;
				}
				case 3:
				{
					num2 = (short)160038912;
					short num4 = num2;
					num2 = (short)764870660;
					num = (int)((global::System.IntPtr)num2);
					continue;
				}
				case 4:
					if (secureMultikey.RefSecureWide.General.SecWideGeneralSecureOperation_A9067.Value == 1)
					{
						num2 = (short)1329004546;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					return false;
				case 5:
					goto IL_F8;
				}
				goto IL_28;
			}
			IL_F8:
			return secureMultikey.TrkSysSecureMultikeyDynamicSecureClearStrapping_43489.Value != 0;
			IL_28:
			secureMultikey = (self as global::Motorola.MackinawCPS.CoreFeatures.TrunkingSystem.SecureMultikey);
			trunkingSystem = (self.Parent as global::Motorola.MackinawCPS.CoreFeatures.TrunkingSystem.TrunkingSystem);
			num2 = (short)1963851776;
			num = (int)((global::System.IntPtr)num2);
			goto IL_0A;
		}

		// Token: 0x06000BB0 RID: 2992 RVA: 0x000AC138 File Offset: 0x000AA338
		internal static bool ConDependOnTrkAstroOtar(global::AcpCommonLib.IAcpFeatureSection self)
		{
			switch (0)
			{
			case 0:
				goto IL_40;
			}
			int num;
			short num2;
			global::Motorola.MackinawCPS.CoreFeatures.TrunkingSystem.SecureMultikey secureMultikey;
			global::AcpBusinessLayer.AcpListField secWideGeneralSecureOperation_A;
			global::Motorola.MackinawCPS.CoreFeatures.TrunkingSystem.TrunkingSystem trunkingSystem;
			for (;;)
			{
				IL_0A:
				switch (num)
				{
				case 0:
				{
					num2 = (short)1006305280;
					short num3 = num2;
					if (secureMultikey.RefSecureWide.ASTROOTAR.SecWideASTROOTARASTROOTAREnable_A7496.Value)
					{
						num2 = (short)1444806662;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					return false;
				}
				case 1:
					num2 = (short)738590727;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 2:
					if (secWideGeneralSecureOperation_A.Value != 1)
					{
						num2 = (short)656605185;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_165;
				case 3:
					num2 = (short)513605632;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 4:
					if (secureMultikey.RefSecureWide.General.SecureWideAESAlgorithmEnable_43201.Value)
					{
						num2 = (short)403963914;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					return false;
				case 5:
					if (trunkingSystem.General.TrkSysGeneralSystemType_A9252.Value == 3)
					{
						goto IL_192;
					}
					return false;
				case 6:
					num2 = (short)175702025;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 7:
					if (secWideGeneralSecureOperation_A.Value == 3)
					{
						num2 = (short)1340080139;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					return false;
				case 8:
					goto IL_160;
				case 9:
				{
					if (!secureMultikey.RefSecureWide.General.SecWideGeneralOTAREnable_A7966.Value)
					{
						return false;
					}
					num2 = (short)282907962;
					short num4 = num2;
					num2 = (short)998692154;
					switch ((num4 == num2) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_192;
					default:
						num2 = (short)1409220608;
						if (num2 != 0)
						{
						}
						num2 = (short)574750721;
						if (num2 != 0)
						{
						}
						num2 = (short)1705050120;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					break;
				}
				case 10:
					goto IL_165;
				case 11:
					num2 = (short)2057830404;
					num = (int)((global::System.IntPtr)num2);
					continue;
				}
				goto IL_40;
				IL_165:
				num2 = (short)1927741445;
				num = (int)((global::System.IntPtr)num2);
				continue;
				IL_192:
				num2 = (short)1061355523;
				num = (int)((global::System.IntPtr)num2);
			}
			IL_160:
			return secureMultikey.TrkSysSecureMultikeyASTROOTAR_A7494.Value;
			IL_40:
			secureMultikey = (self as global::Motorola.MackinawCPS.CoreFeatures.TrunkingSystem.SecureMultikey);
			trunkingSystem = (self.Parent as global::Motorola.MackinawCPS.CoreFeatures.TrunkingSystem.TrunkingSystem);
			secWideGeneralSecureOperation_A = secureMultikey.RefSecureWide.General.SecWideGeneralSecureOperation_A9067;
			num2 = (short)1600651266;
			num = (int)((global::System.IntPtr)num2);
			goto IL_0A;
		}

		// Token: 0x06000BB1 RID: 2993 RVA: 0x000AC400 File Offset: 0x000AA600
		private static void a(global::Motorola.MackinawCPS.CoreFeatures.TrunkingSystem.TrunkingSystem A_0, global::Motorola.MackinawCPS.CoreFeatures.TrunkingSystem.SecureMultikey A_1, global::Motorola.MackinawCPS.CoreFeatures.SecureKMFProfile.SecureKMFProfile A_2, bool A_3)
		{
			short num = (short)1770258432;
			short num2 = num;
			num = (short)1876332656;
			short num3 = num;
			num = (short)1886490736;
			switch ((num3 == num) ? 1 : 0)
			{
			case 0:
			case 2:
				break;
			default:
				num = (short)1142751232;
				if (num != 0)
				{
				}
				num = (short)2043215872;
				switch (num)
				{
				default:
				{
					global::AcpBusinessLayer.AcpRecRefField trkSysSecureMultikeyPatchKeySelect_A = A_1.TrkSysSecureMultikeyPatchKeySelect_A8694;
					global::AcpBusinessLayer.AcpRecRefField trkSysSecureMultikeySystemWideKeySelect_A = A_1.TrkSysSecureMultikeySystemWideKeySelect_A9253;
					global::AcpBusinessLayer.AcpRecRefField trkSysSecureMultikeyDynamicTalkgroupKeySelect_A = A_1.TrkSysSecureMultikeyDynamicTalkgroupKeySelect_A7918;
					global::AcpBusinessLayer.AcpRecRefField trkSysSecureMultikeyFailsoftKeySelect_A = A_1.TrkSysSecureMultikeyFailsoftKeySelect_A8012;
					global::AcpBusinessLayer.AcpRecRefField trkSysSecureMultikeyPrivateCallKeySelect_A = A_1.TrkSysSecureMultikeyPrivateCallKeySelect_A8757;
					global::AcpBusinessLayer.AcpRecRefField trkSysSecureMultikeyInterconnectKeySelect_A = A_1.TrkSysSecureMultikeyInterconnectKeySelect_A8298;
					global::AcpBusinessLayer.AcpRecRefField trkSysSecureMultikeyVirtualPartnerKeySelect_A = A_1.TrkSysSecureMultikeyVirtualPartnerKeySelect_A43669;
					global::AcpCommonLib.IAcpRecordset recset = global::AcpCommonLib.FeatureManager.GetFeature(2021)[0][10040].EmbeddedRecset;
					if (A_2 != null)
					{
						global::Motorola.MackinawCPS.CoreFeatures.SecureKMFProfile.General general = A_2.General;
						global::Motorola.MackinawCPS.CoreFeatures.SecureWide.SecureWide refSecureWide = A_2.General.RefSecureWide;
						recset = ((general.SecKmfProfGenIndependentKeyList_43597.Applicable && general.SecKmfProfGenIndependentKeyList_43597.Value && A_3) ? A_2.SecureHardwareEncryptionIndependentKeyList.EmbeddedRecset : refSecureWide.EncryptionKeyList.EmbeddedRecset);
					}
					trkSysSecureMultikeyPatchKeySelect_A.SetRecset(recset);
					trkSysSecureMultikeySystemWideKeySelect_A.SetRecset(recset);
					trkSysSecureMultikeyDynamicTalkgroupKeySelect_A.SetRecset(recset);
					trkSysSecureMultikeyFailsoftKeySelect_A.SetRecset(recset);
					trkSysSecureMultikeyPrivateCallKeySelect_A.SetRecset(recset);
					trkSysSecureMultikeyInterconnectKeySelect_A.SetRecset(recset);
					trkSysSecureMultikeyVirtualPartnerKeySelect_A.SetRecset(recset);
					global::System.Collections.Generic.IEnumerator<global::AcpBusinessLayer.FeatureNode> enumerator = (global::AcpCommonLib.FeatureManager.GetFeature(2072) as global::Motorola.MackinawCPS.CoreFeatures.TrunkingPersonality.TrunkingPersonalityRecset).GetEnumerator();
					try
					{
						num = (short)1467613184;
						int num4 = (int)((global::System.IntPtr)num);
						for (;;)
						{
							num = (short)1150877697;
							if (num != 0)
							{
							}
							switch (num4)
							{
							case 0:
								switch (0)
								{
								case 0:
									goto IL_202;
								}
								continue;
							case 1:
							{
								global::Motorola.MackinawCPS.CoreFeatures.TrunkingPersonality.General general2;
								if (general2.TrkPerGeneralSystem_A9237.UIValue == A_0.ReferenceKey)
								{
									num = (short)1588396038;
									num4 = (int)((global::System.IntPtr)num);
									continue;
								}
								break;
							}
							case 2:
								num = (short)1248722947;
								num4 = (int)((global::System.IntPtr)num);
								continue;
							case 3:
								goto IL_2E0;
							case 4:
							{
								if (!enumerator.MoveNext())
								{
									num = (short)1723400194;
									num4 = (int)((global::System.IntPtr)num);
									continue;
								}
								global::Motorola.MackinawCPS.CoreFeatures.TrunkingPersonality.General general2 = ((global::Motorola.MackinawCPS.CoreFeatures.TrunkingPersonality.TrunkingPersonality)enumerator.Current).General;
								num = (short)1380909057;
								num4 = (int)((global::System.IntPtr)num);
								continue;
							}
							case 6:
							{
								global::Motorola.MackinawCPS.CoreFeatures.TrunkingPersonality.General general2;
								general2.TrkEmerProfGeneralKeySelect_A8970.SetRecset(recset);
								num = (short)557252613;
								num4 = (int)((global::System.IntPtr)num);
								continue;
							}
							}
							IL_204:
							num = (short)1057226756;
							num4 = (int)((global::System.IntPtr)num);
							continue;
							IL_202:
							goto IL_204;
						}
						IL_2E0:;
					}
					finally
					{
						num = (short)292028416;
						int num4 = (int)((global::System.IntPtr)num);
						for (;;)
						{
							switch (num4)
							{
							case 0:
								switch (0)
								{
								case 0:
									goto IL_314;
								}
								continue;
							case 1:
								goto IL_34D;
							case 2:
								enumerator.Dispose();
								num = (short)710148097;
								num4 = (int)((global::System.IntPtr)num);
								continue;
							}
							IL_314:
							if (enumerator == null)
							{
								break;
							}
							num = (short)177864706;
							num4 = (int)((global::System.IntPtr)num);
						}
						IL_34D:;
					}
					break;
				}
				}
				break;
			}
		}

		// Token: 0x06000BB2 RID: 2994 RVA: 0x000AC77C File Offset: 0x000AA97C
		internal static bool ConBandSelIs700800Mhz(global::AcpCommonLib.IAcpFeatureSection self)
		{
			short num = (short)1380848716;
			short num2 = num;
			num = (short)1626084428;
			switch (num2 == num)
			{
			default:
			{
				num = (short)955318272;
				short num3 = num;
				break;
			}
			case true:
				break;
			}
			num = (short)1513422849;
			if (num != 0)
			{
			}
			num = (short)1302134784;
			if (num != 0)
			{
			}
			return (self.Parent as global::Motorola.MackinawCPS.CoreFeatures.TrunkingSystem.TrunkingSystem).General.TrkSysGeneralTypeIIFrequencyBand_A12491.Value == 3;
		}

		// Token: 0x06000BB3 RID: 2995 RVA: 0x000AC840 File Offset: 0x000AAA40
		internal static bool ConTrkSysIsDataEnabledAndTrkSysTypeIsASTRO25(global::AcpCommonLib.IAcpFeatureSection self)
		{
			short num;
			bool flag;
			for (;;)
			{
				num = (short)1149763584;
				short num2 = num;
				global::Motorola.MackinawCPS.CoreFeatures.TrunkingSystem.TrunkingSystem trunkingSystem = self.Parent as global::Motorola.MackinawCPS.CoreFeatures.TrunkingSystem.TrunkingSystem;
				global::AcpBusinessLayer.AcpRecRefField trkSysGeneralDataProfileSelection_A = trunkingSystem.General.TrkSysGeneralDataProfileSelection_A19449;
				flag = false;
				if (trkSysGeneralDataProfileSelection_A.Value != 0)
				{
					global::Motorola.MackinawCPS.CoreFeatures.DataProfiles.DataProfiles dataProfiles = trkSysGeneralDataProfileSelection_A.ReferencedNode as global::Motorola.MackinawCPS.CoreFeatures.DataProfiles.DataProfiles;
					if (dataProfiles != null && dataProfiles.Features.DataProfFeaturesAtakField)
					{
						flag = true;
					}
				}
				if (trunkingSystem.General.TrkSysGeneralSystemType_A9252.Value != 3)
				{
					return false;
				}
				num = (short)1967215551;
				short num3 = num;
				num = (short)1307136959;
				switch ((num3 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					break;
				default:
					goto IL_BD;
				}
			}
			IL_BD:
			num = (short)1239613441;
			if (num != 0)
			{
			}
			num = (short)804978688;
			if (num != 0)
			{
			}
			return !flag;
		}

		// Token: 0x06000BB4 RID: 2996 RVA: 0x000AC950 File Offset: 0x000AAB50
		internal static bool ConTrkSysTypeIIAndSecTypeIsHW(global::AcpCommonLib.IAcpFeatureSection self)
		{
			switch (0)
			{
			case 0:
				goto IL_6C;
			}
			short num;
			int num3;
			global::Motorola.MackinawCPS.CoreFeatures.TrunkingSystem.SecureMultikey secureMultikey;
			for (;;)
			{
				IL_0A:
				num = (short)466709153;
				short num2 = num;
				num = (short)783248033;
				switch ((num2 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					break;
				default:
					num = (short)971571200;
					if (num != 0)
					{
					}
					switch (num3)
					{
					case 0:
						goto IL_B8;
					case 1:
						if (!secureMultikey.RefRadioInformation.Labtool.RadInfoLabtoolH38G51Smartzone_A8185.Value)
						{
							num = (short)1544028160;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_15B;
					case 2:
						goto IL_12D;
					case 3:
						if (!secureMultikey.RefRadioInformation.Labtool.RadInfoLabtoolH37G50Smartnet_A8184.Value)
						{
							num = (short)138084354;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_15B;
					}
					goto IL_6C;
				}
				IL_B8:
				num = (short)1810432003;
				num3 = (int)((global::System.IntPtr)num);
			}
			IL_12D:
			num = (short)462618624;
			short num4 = num;
			num = (short)1597833217;
			if (num != 0)
			{
			}
			return false;
			IL_15B:
			return secureMultikey.RefSecureWide.General.SecWideGeneralSecureOperation_A9067.Value == 1;
			IL_6C:
			secureMultikey = (self as global::Motorola.MackinawCPS.CoreFeatures.TrunkingSystem.SecureMultikey);
			num = (short)1554448385;
			num3 = (int)((global::System.IntPtr)num);
			goto IL_0A;
		}

		// Token: 0x06000BB5 RID: 2997 RVA: 0x000ACAD0 File Offset: 0x000AACD0
		internal static void conSetRfssAlsNum(global::AcpCommonLib.IAcpFeatureSection self, global::AcpCommonLib.UndoRedo.ContainerTask task)
		{
			short num = (short)1487405056;
			int num2 = (int)num;
			switch (num2)
			{
			default:
			{
				switch (0)
				{
				case 0:
					goto IL_4A;
				}
				global::AcpBusinessLayer.AcpListField trkSysGeneralCoverageType_A;
				global::Motorola.MackinawCPS.CoreFeatures.TrunkingSystem.General general;
				global::Motorola.MackinawCPS.CoreFeatures.TrunkingSystem.SiteAliasInnerRecset siteAliasInnerRecset;
				for (;;)
				{
					IL_27:
					global::System.Collections.Generic.IEnumerator<global::AcpBusinessLayer.FeatureNode> enumerator;
					switch (num2)
					{
					case 0:
					{
						num = (short)800292467;
						short num3 = num;
						num = (short)1589804659;
						switch ((num3 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_332;
						default:
							num = (short)513736704;
							if (num != 0)
							{
							}
							if (trkSysGeneralCoverageType_A.Value != 7)
							{
								num = (short)1136394244;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							goto IL_337;
						}
						break;
					}
					case 1:
						num = (short)400162817;
						if (num != 0)
						{
						}
						if (trkSysGeneralCoverageType_A.Value != 5)
						{
							num = (short)71827462;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_337;
					case 2:
						try
						{
							num = (short)1500774402;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								switch (num2)
								{
								case 0:
								{
									if (!enumerator.MoveNext())
									{
										num = (short)1304952833;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									global::AcpCommonLib.IAcpFeatureNode acpFeatureNode = enumerator.Current;
									task.AddTask(new global::AcpBusinessLayer.UndoRedo.ModifyDataTask<int>((acpFeatureNode[10172] as global::Motorola.MackinawCPS.CoreFeatures.TrunkingSystem.SiteAliasInnerSection).TrkSysSiteAliasRFSSAliasNumber_A8978, general.TrkSysGeneralRFSSID_A8980.Value));
									num = (short)42074116;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 1:
									num = (short)1117782019;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 2:
									switch (0)
									{
									case 0:
										goto IL_135;
									}
									continue;
								case 3:
									goto IL_1D6;
								}
								IL_137:
								num = (short)628948992;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								IL_135:
								goto IL_137;
							}
							IL_1D6:
							goto IL_337;
						}
						finally
						{
							num = (short)1835270144;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								switch (num2)
								{
								case 0:
									switch (0)
									{
									case 0:
										goto IL_20D;
									}
									continue;
								case 1:
									goto IL_242;
								case 2:
									enumerator.Dispose();
									num = (short)1692139521;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								IL_20D:
								if (enumerator == null)
								{
									break;
								}
								num = (short)445972482;
								num2 = (int)((global::System.IntPtr)num);
							}
							IL_242:;
						}
						goto IL_245;
					case 3:
						goto IL_332;
					case 4:
						num = (short)578420737;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 5:
						if (trkSysGeneralCoverageType_A.Value != 6)
						{
							num = (short)528220163;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_337;
					case 6:
						num = (short)327680005;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_4A;
					IL_245:
					num = (short)507904000;
					short num4 = num;
					enumerator = siteAliasInnerRecset.GetEnumerator();
					num = (short)67043330;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_332:
					goto IL_245;
				}
				IL_337:
				global::Motorola.MackinawCPS.CoreFeatures.TrunkingSystem.TrunkingSystemConstraints.ConSetTrkLTEInterferenceFreqAllow(self.Parent[10160].EmbeddedRecset[0][10161], task);
				return;
				IL_4A:
				general = (self as global::Motorola.MackinawCPS.CoreFeatures.TrunkingSystem.General);
				trkSysGeneralCoverageType_A = general.TrkSysGeneralCoverageType_A7782;
				siteAliasInnerRecset = (self.Parent[10171].EmbeddedRecset as global::Motorola.MackinawCPS.CoreFeatures.TrunkingSystem.SiteAliasInnerRecset);
				num = (short)2006777856;
				num2 = (int)((global::System.IntPtr)num);
				goto IL_27;
			}
			}
		}

		// Token: 0x06000BB6 RID: 2998 RVA: 0x000ACE50 File Offset: 0x000AB050
		internal static bool conTrkSysChanAssignRxEnApp(global::AcpCommonLib.IAcpFeatureSection self)
		{
			short num = (short)103612416;
			int num2 = (int)num;
			switch (num2)
			{
			default:
			{
				switch (0)
				{
				case 0:
					goto IL_63;
				}
				global::AcpCommonLib.IAcpFeatureNode parent;
				global::AcpCommonLib.IAcpFeatureNode acpFeatureNode2;
				global::Motorola.MackinawCPS.CoreFeatures.TrunkingSystem.ChannelRangesMHzInnerSection channelRangesMHzInnerSection;
				for (;;)
				{
					IL_28:
					int num4;
					switch (num2)
					{
					case 0:
						num = (short)455016454;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 1:
						num = (short)863043593;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 2:
					{
						global::AcpBusinessLayer.AcpListField trkSysGeneralTypeIIFrequencyBand_A;
						if (trkSysGeneralTypeIIFrequencyBand_A.Value != 2)
						{
							num = (short)636354568;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_2C4;
					}
					case 3:
					{
						global::Motorola.MackinawCPS.CoreFeatures.TrunkingSystem.TrunkingSystem trunkingSystem = self.ParentRecset.ParentSection.Parent as global::Motorola.MackinawCPS.CoreFeatures.TrunkingSystem.TrunkingSystem;
						global::AcpBusinessLayer.AcpListField trkSysGeneralTypeIIFrequencyBand_A = trunkingSystem.General.TrkSysGeneralTypeIIFrequencyBand_A12491;
						if (trunkingSystem.General.TrkSysGeneralSystemType_A9252.Value != 2)
						{
							return false;
						}
						num = (short)1066720328;
						short num3 = num;
						num = (short)1474026568;
						switch ((num3 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_1B9;
						default:
							num = (short)1527447552;
							if (num != 0)
							{
							}
							num = (short)766377984;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						break;
					}
					case 4:
						num = (short)302383105;
						if (num != 0)
						{
						}
						switch (num4)
						{
						case 0:
							return true;
						case 1:
							goto IL_11C;
						case 2:
							num = (short)549584908;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						default:
							num = (short)21626891;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						break;
					case 5:
						num = (short)1733296130;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 6:
					{
						global::AcpBusinessLayer.AcpListField trkSysGeneralTypeIIFrequencyBand_A;
						if (trkSysGeneralTypeIIFrequencyBand_A.Value != 0)
						{
							num = (short)118685696;
							short num5 = num;
							num = (short)1285554177;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_2C4;
					}
					case 7:
						goto IL_2BD;
					case 8:
						goto IL_394;
					case 9:
					{
						global::AcpBusinessLayer.AcpListField trkSysGeneralTypeIIFrequencyBand_A;
						if (trkSysGeneralTypeIIFrequencyBand_A.Value != 1)
						{
							num = (short)2081685509;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_2C4;
					}
					case 10:
						return false;
					case 11:
						num = (short)2080374794;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 12:
					{
						global::AcpCommonLib.IAcpFeatureNode acpFeatureNode = parent.Parent[0];
						acpFeatureNode2 = parent.Parent[1];
						channelRangesMHzInnerSection.TrkSysOBTChannelAssignmentListRxStartFrequencyMHz_A9029.CalculateValidity();
						channelRangesMHzInnerSection.TrkSysOBTChannelAssignmentListRxEndFrequencyMHz_A9012.CalculateValidity();
						if ((acpFeatureNode[10168] as global::Motorola.MackinawCPS.CoreFeatures.TrunkingSystem.ChannelRangesMHzInnerSection).TrkSysOBTChannelAssignmentListRxEnable_A9001.Value)
						{
							num = (short)34209799;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return false;
					}
					}
					goto IL_63;
					IL_2C4:
					parent = channelRangesMHzInnerSection.TrkSysOBTChannelAssignmentListRxEnable_A9001.Parent.Parent;
					num4 = (parent.Parent as global::AcpBusinessLayer.Recordset).IndexOf(parent);
					num = (short)660406276;
					num2 = (int)((global::System.IntPtr)num);
				}
				IL_11C:
				global::AcpCommonLib.IAcpFeatureNode acpFeatureNode3 = parent.Parent[0];
				channelRangesMHzInnerSection.TrkSysOBTChannelAssignmentListRxStartFrequencyMHz_A9029.CalculateValidity();
				channelRangesMHzInnerSection.TrkSysOBTChannelAssignmentListRxEndFrequencyMHz_A9012.CalculateValidity();
				return (acpFeatureNode3[10168] as global::Motorola.MackinawCPS.CoreFeatures.TrunkingSystem.ChannelRangesMHzInnerSection).TrkSysOBTChannelAssignmentListRxEnable_A9001.Value;
				IL_1B9:
				return (acpFeatureNode2[10168] as global::Motorola.MackinawCPS.CoreFeatures.TrunkingSystem.ChannelRangesMHzInnerSection).TrkSysOBTChannelAssignmentListRxEnable_A9001.Value;
				IL_2BD:
				goto IL_1B9;
				IL_394:
				return false;
				IL_63:
				channelRangesMHzInnerSection = (self as global::Motorola.MackinawCPS.CoreFeatures.TrunkingSystem.ChannelRangesMHzInnerSection);
				num = (short)419102723;
				num2 = (int)((global::System.IntPtr)num);
				goto IL_28;
			}
			}
		}

		// Token: 0x06000BB7 RID: 2999 RVA: 0x000AD1F8 File Offset: 0x000AB3F8
		internal static bool ConTrkSysChanAssignRxSpacingApp(global::AcpCommonLib.IAcpFeatureSection self)
		{
			short num = (short)564264960;
			int num2 = (int)num;
			switch (num2)
			{
			default:
			{
				switch (0)
				{
				case 0:
					goto IL_73;
				}
				global::AcpBusinessLayer.AcpListField trkSysGeneralTypeIIFrequencyBand_A;
				global::AcpCommonLib.IAcpFeatureNode parent;
				global::AcpCommonLib.IAcpFeatureNode acpFeatureNode2;
				global::AcpCommonLib.IAcpFeatureNode acpFeatureNode3;
				global::Motorola.MackinawCPS.CoreFeatures.TrunkingSystem.TrunkingSystem trunkingSystem;
				for (;;)
				{
					IL_28:
					int num5;
					switch (num2)
					{
					case 0:
						if (trkSysGeneralTypeIIFrequencyBand_A.Value != 0)
						{
							num = (short)1389625356;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_391;
					case 1:
					{
						global::AcpCommonLib.IAcpFeatureNode acpFeatureNode = parent.Parent[0];
						acpFeatureNode2 = parent.Parent[1];
						acpFeatureNode3 = parent.Parent[2];
						if (!(acpFeatureNode[10168] as global::Motorola.MackinawCPS.CoreFeatures.TrunkingSystem.ChannelRangesMHzInnerSection).TrkSysOBTChannelAssignmentListRxEnable_A9001.Value)
						{
							return false;
						}
						num = (short)510448599;
						short num3 = num;
						num = (short)575787991;
						switch ((num3 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							return false;
						default:
						{
							num = (short)1766260736;
							if (num != 0)
							{
							}
							num = (short)1453654016;
							short num4 = num;
							num = (short)67829774;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						}
						break;
					}
					case 2:
						if (trkSysGeneralTypeIIFrequencyBand_A.Value == 2)
						{
							num = (short)1057095693;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return false;
					case 3:
						goto IL_2F9;
					case 4:
						num = (short)2088108047;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 5:
						if (trunkingSystem.General.TrkSysGeneralSystemType_A9252.Value == 2)
						{
							num = (short)543948807;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return false;
					case 6:
						switch (num5)
						{
						case 0:
							goto IL_44F;
						case 1:
							num = (short)1445724176;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 2:
							num = (short)1819803649;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						default:
							num = (short)394526724;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						break;
					case 7:
						num = (short)821886976;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 8:
						if (trkSysGeneralTypeIIFrequencyBand_A.Value != 1)
						{
							num = (short)1207500809;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_391;
					case 9:
						num = (short)1183842306;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 10:
						if ((acpFeatureNode2[10168] as global::Motorola.MackinawCPS.CoreFeatures.TrunkingSystem.ChannelRangesMHzInnerSection).TrkSysOBTChannelAssignmentListRxEnable_A9001.Value)
						{
							num = (short)18415619;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return false;
					case 11:
						goto IL_38C;
					case 12:
						num = (short)1821835272;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 13:
						goto IL_391;
					case 14:
						num = (short)1717633034;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 15:
						goto IL_407;
					case 16:
					{
						global::AcpCommonLib.IAcpFeatureNode acpFeatureNode4 = parent.Parent[0];
						acpFeatureNode2 = parent.Parent[1];
						if ((acpFeatureNode4[10168] as global::Motorola.MackinawCPS.CoreFeatures.TrunkingSystem.ChannelRangesMHzInnerSection).TrkSysOBTChannelAssignmentListRxEnable_A9001.Value)
						{
							num = (short)1494614027;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return false;
					}
					}
					goto IL_73;
					IL_391:
					num5 = (parent.Parent as global::AcpBusinessLayer.Recordset).IndexOf(parent);
					num = (short)400490502;
					num2 = (int)((global::System.IntPtr)num);
				}
				IL_2F9:
				num = (short)1597636609;
				if (num != 0)
				{
				}
				return (acpFeatureNode3[10168] as global::Motorola.MackinawCPS.CoreFeatures.TrunkingSystem.ChannelRangesMHzInnerSection).TrkSysOBTChannelAssignmentListRxEnable_A9001.Value;
				IL_38C:
				return (acpFeatureNode2[10168] as global::Motorola.MackinawCPS.CoreFeatures.TrunkingSystem.ChannelRangesMHzInnerSection).TrkSysOBTChannelAssignmentListRxEnable_A9001.Value;
				IL_407:
				return false;
				IL_44F:
				return (parent.Parent[0][10168] as global::Motorola.MackinawCPS.CoreFeatures.TrunkingSystem.ChannelRangesMHzInnerSection).TrkSysOBTChannelAssignmentListRxEnable_A9001.Value;
				IL_73:
				global::Motorola.MackinawCPS.CoreFeatures.TrunkingSystem.ChannelRangesMHzInnerSection channelRangesMHzInnerSection = self as global::Motorola.MackinawCPS.CoreFeatures.TrunkingSystem.ChannelRangesMHzInnerSection;
				trunkingSystem = (self.ParentRecset.ParentSection.Parent as global::Motorola.MackinawCPS.CoreFeatures.TrunkingSystem.TrunkingSystem);
				trkSysGeneralTypeIIFrequencyBand_A = trunkingSystem.General.TrkSysGeneralTypeIIFrequencyBand_A12491;
				parent = channelRangesMHzInnerSection.TrkSysOBTChannelAssignmentListRxEnable_A9001.Parent.Parent;
				acpFeatureNode2 = null;
				acpFeatureNode3 = null;
				num = (short)695468037;
				num2 = (int)((global::System.IntPtr)num);
				goto IL_28;
			}
			}
		}

		// Token: 0x06000BB8 RID: 3000 RVA: 0x000AD67C File Offset: 0x000AB87C
		internal static bool conTrkSysChanAssignTxEnApp(global::AcpCommonLib.IAcpFeatureSection self)
		{
			short num = (short)939261952;
			int num2 = (int)num;
			switch (num2)
			{
			default:
			{
				switch (0)
				{
				case 0:
					goto IL_6A;
				}
				global::AcpCommonLib.IAcpFeatureNode acpFeatureNode;
				global::Motorola.MackinawCPS.CoreFeatures.TrunkingSystem.ChannelRangesMHzInnerSection channelRangesMHzInnerSection;
				global::AcpCommonLib.IAcpFeatureNode acpFeatureNode2;
				for (;;)
				{
					IL_27:
					int num3;
					switch (num2)
					{
					case 0:
						if (num3 != 0)
						{
							num = (short)1793523716;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return true;
					case 1:
						if (num3 != 1)
						{
							num = (short)731578368;
							short num4 = num;
							num = (short)948633612;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_2A0;
					case 2:
						return false;
					case 3:
					{
						num = (short)1458176001;
						if (num != 0)
						{
						}
						global::Motorola.MackinawCPS.CoreFeatures.TrunkingSystem.TrunkingSystem trunkingSystem = self.ParentRecset.ParentSection.Parent as global::Motorola.MackinawCPS.CoreFeatures.TrunkingSystem.TrunkingSystem;
						global::AcpBusinessLayer.AcpListField trkSysGeneralTypeIIFrequencyBand_A = trunkingSystem.General.TrkSysGeneralTypeIIFrequencyBand_A12491;
						if (trunkingSystem.General.TrkSysGeneralSystemType_A9252.Value == 2)
						{
							num = (short)610729989;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return false;
					}
					case 4:
						num = (short)1564803073;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 5:
						num = (short)11862026;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 6:
						goto IL_214;
					case 7:
						num = (short)873070605;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 8:
						if ((acpFeatureNode[10168] as global::Motorola.MackinawCPS.CoreFeatures.TrunkingSystem.ChannelRangesMHzInnerSection).TrkSysOBTChannelAssignmentListTxEnable_A9517.Value)
						{
							num = (short)1084096518;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return false;
					case 9:
						channelRangesMHzInnerSection.TrkSysOBTChannelAssignmentListTxStartFrequencyMHz_A9568.CalculateValidity();
						channelRangesMHzInnerSection.TrkSysOBTChannelAssignmentListTxEndFrequencyMHz_A9529.CalculateValidity();
						num = (short)1861615624;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 10:
					{
						global::AcpBusinessLayer.AcpListField trkSysGeneralTypeIIFrequencyBand_A;
						if (trkSysGeneralTypeIIFrequencyBand_A.Value != 0)
						{
							num = (short)31195150;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_2ED;
					}
					case 11:
					{
						global::AcpBusinessLayer.AcpListField trkSysGeneralTypeIIFrequencyBand_A;
						if (trkSysGeneralTypeIIFrequencyBand_A.Value != 1)
						{
							num = (short)877264903;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_2ED;
					}
					case 12:
						num = (short)308871177;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 13:
					{
						global::AcpBusinessLayer.AcpListField trkSysGeneralTypeIIFrequencyBand_A;
						if (trkSysGeneralTypeIIFrequencyBand_A.Value != 2)
						{
							num = (short)970391554;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_2ED;
					}
					case 14:
						num = (short)560660491;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_6A;
					IL_2ED:
					global::AcpCommonLib.IAcpFeatureNode parent = channelRangesMHzInnerSection.TrkSysOBTChannelAssignmentListTxEnable_A9517.Parent.Parent;
					acpFeatureNode = parent.Parent[0];
					acpFeatureNode2 = parent.Parent[1];
					num3 = (parent.Parent as global::AcpBusinessLayer.Recordset).IndexOf(parent);
					num = (short)1660878848;
					num2 = (int)((global::System.IntPtr)num);
				}
				return true;
				IL_214:
				num = (short)1763021517;
				short num5 = num;
				num = (short)534155981;
				switch ((num5 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					break;
				default:
					num = (short)609222656;
					if (num != 0)
					{
					}
					break;
				}
				return (acpFeatureNode2[10168] as global::Motorola.MackinawCPS.CoreFeatures.TrunkingSystem.ChannelRangesMHzInnerSection).TrkSysOBTChannelAssignmentListTxEnable_A9517.Value;
				IL_2A0:
				channelRangesMHzInnerSection.TrkSysOBTChannelAssignmentListTxStartFrequencyMHz_A9568.CalculateValidity();
				channelRangesMHzInnerSection.TrkSysOBTChannelAssignmentListTxEndFrequencyMHz_A9529.CalculateValidity();
				return (acpFeatureNode[10168] as global::Motorola.MackinawCPS.CoreFeatures.TrunkingSystem.ChannelRangesMHzInnerSection).TrkSysOBTChannelAssignmentListTxEnable_A9517.Value;
				IL_6A:
				channelRangesMHzInnerSection = (self as global::Motorola.MackinawCPS.CoreFeatures.TrunkingSystem.ChannelRangesMHzInnerSection);
				num = (short)542965763;
				num2 = (int)((global::System.IntPtr)num);
				goto IL_27;
			}
			}
		}

		// Token: 0x06000BB9 RID: 3001 RVA: 0x000ADA54 File Offset: 0x000ABC54
		internal static bool conTrkSysChanAssignTxSpacingApp(global::AcpCommonLib.IAcpFeatureSection self)
		{
			short num = (short)1560739840;
			int num2 = (int)num;
			switch (num2)
			{
			default:
			{
				switch (0)
				{
				case 0:
					goto IL_73;
				}
				global::AcpCommonLib.IAcpFeatureNode acpFeatureNode;
				global::AcpBusinessLayer.AcpListField trkSysGeneralTypeIIFrequencyBand_A;
				global::AcpCommonLib.IAcpFeatureNode parent;
				global::AcpCommonLib.IAcpFeatureNode acpFeatureNode3;
				global::Motorola.MackinawCPS.CoreFeatures.TrunkingSystem.TrunkingSystem trunkingSystem;
				for (;;)
				{
					IL_28:
					int num3;
					switch (num2)
					{
					case 0:
						num = (short)527302660;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 1:
						if ((acpFeatureNode[10168] as global::Motorola.MackinawCPS.CoreFeatures.TrunkingSystem.ChannelRangesMHzInnerSection).TrkSysOBTChannelAssignmentListTxEnable_A9517.Value)
						{
							num = (short)784072719;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return false;
					case 2:
						if (trkSysGeneralTypeIIFrequencyBand_A.Value == 2)
						{
							num = (short)355270662;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return false;
					case 3:
					{
						global::AcpCommonLib.IAcpFeatureNode acpFeatureNode2 = parent.Parent[0];
						acpFeatureNode = parent.Parent[1];
						acpFeatureNode3 = parent.Parent[2];
						if ((acpFeatureNode2[10168] as global::Motorola.MackinawCPS.CoreFeatures.TrunkingSystem.ChannelRangesMHzInnerSection).TrkSysOBTChannelAssignmentListTxEnable_A9517.Value)
						{
							num = (short)89849861;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return false;
					}
					case 4:
						if (trkSysGeneralTypeIIFrequencyBand_A.Value != 0)
						{
							num = (short)2035220496;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_38C;
					case 5:
						goto IL_1E2;
					case 6:
						goto IL_38C;
					case 7:
						switch (num3)
						{
						case 0:
							goto IL_448;
						case 1:
							num = (short)358547466;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 2:
						{
							num = (short)106233857;
							if (num != 0)
							{
							}
							num = (short)587645792;
							short num4 = num;
							num = (short)111068000;
							switch ((num4 == num) ? 1 : 0)
							{
							case 0:
							case 2:
								goto IL_1E2;
							default:
								num = (short)572325888;
								if (num != 0)
								{
								}
								num = (short)592838659;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							break;
						}
						default:
							num = (short)1318191115;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						break;
					case 8:
						return false;
					case 9:
						num = (short)1386086402;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 10:
					{
						global::AcpCommonLib.IAcpFeatureNode acpFeatureNode4 = parent.Parent[0];
						acpFeatureNode = parent.Parent[1];
						if ((acpFeatureNode4[10168] as global::Motorola.MackinawCPS.CoreFeatures.TrunkingSystem.ChannelRangesMHzInnerSection).TrkSysOBTChannelAssignmentListTxEnable_A9517.Value)
						{
							num = (short)2145189901;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return false;
					}
					case 11:
						num = (short)826277896;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 12:
						if (trunkingSystem.General.TrkSysGeneralSystemType_A9252.Value == 2)
						{
							num = (short)1903230976;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return false;
					case 13:
						goto IL_387;
					case 14:
						if (trkSysGeneralTypeIIFrequencyBand_A.Value != 1)
						{
							num = (short)808845321;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_38C;
					case 15:
						goto IL_31A;
					case 16:
						num = (short)486735886;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_73;
					IL_1E2:
					num = (short)1206583297;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_38C:
					num3 = (parent.Parent as global::AcpBusinessLayer.Recordset).IndexOf(parent);
					num = (short)814546951;
					num2 = (int)((global::System.IntPtr)num);
				}
				IL_31A:
				num = (short)1224867840;
				short num5 = num;
				return (acpFeatureNode3[10168] as global::Motorola.MackinawCPS.CoreFeatures.TrunkingSystem.ChannelRangesMHzInnerSection).TrkSysOBTChannelAssignmentListTxEnable_A9517.Value;
				IL_387:
				return (acpFeatureNode[10168] as global::Motorola.MackinawCPS.CoreFeatures.TrunkingSystem.ChannelRangesMHzInnerSection).TrkSysOBTChannelAssignmentListTxEnable_A9517.Value;
				IL_448:
				return (parent.Parent[0][10168] as global::Motorola.MackinawCPS.CoreFeatures.TrunkingSystem.ChannelRangesMHzInnerSection).TrkSysOBTChannelAssignmentListTxEnable_A9517.Value;
				IL_73:
				global::Motorola.MackinawCPS.CoreFeatures.TrunkingSystem.ChannelRangesMHzInnerSection channelRangesMHzInnerSection = self as global::Motorola.MackinawCPS.CoreFeatures.TrunkingSystem.ChannelRangesMHzInnerSection;
				trunkingSystem = (self.ParentRecset.ParentSection.Parent as global::Motorola.MackinawCPS.CoreFeatures.TrunkingSystem.TrunkingSystem);
				trkSysGeneralTypeIIFrequencyBand_A = trunkingSystem.General.TrkSysGeneralTypeIIFrequencyBand_A12491;
				parent = channelRangesMHzInnerSection.TrkSysOBTChannelAssignmentListTxEnable_A9517.Parent.Parent;
				acpFeatureNode = null;
				acpFeatureNode3 = null;
				num = (short)976617484;
				num2 = (int)((global::System.IntPtr)num);
				goto IL_28;
			}
			}
		}

		// Token: 0x06000BBA RID: 3002 RVA: 0x000ADED0 File Offset: 0x000AC0D0
		internal static bool ConTrkSysOBTRxStartFreq1IsValid(global::AcpCommonLib.IAcpFeatureSection self)
		{
			short num = (short)1336803328;
			int num2 = (int)num;
			switch (num2)
			{
			default:
			{
				switch (0)
				{
				case 0:
					goto IL_B8;
				}
				global::System.Collections.Generic.IEnumerator<global::AcpBusinessLayer.FeatureNode> enumerator;
				global::AcpBusinessLayer.AcpListField trkSysGeneralTypeIIFrequencyBand_A;
				global::Motorola.MackinawCPS.CoreFeatures.TrunkingSystem.TrunkingSystem trunkingSystem;
				global::Motorola.MackinawCPS.CoreFeatures.TrunkingSystem.ChannelRangesMHzInnerSection channelRangesMHzInnerSection;
				for (;;)
				{
					IL_29:
					global::Motorola.MackinawCPS.CoreFeatures.RadioWide.RxFrequencySplitFPPInnerRecset rxFrequencySplitFPPInnerRecset;
					switch (num2)
					{
					case 0:
						try
						{
							num = (short)174522376;
							num2 = (int)((global::System.IntPtr)num);
							bool result;
							for (;;)
							{
								switch (num2)
								{
								case 0:
								{
									int value;
									global::Motorola.MackinawCPS.CoreFeatures.RadioWide.RxFrequencySplitFPPInnerSection rxFrequencySplitFPPInnerSection;
									if (value > rxFrequencySplitFPPInnerSection.RadWideLabtoolRxEndFrequencySplit_A9015.Value)
									{
										num = (short)507576326;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									goto IL_FA7;
								}
								case 1:
								{
									if (!enumerator.MoveNext())
									{
										num = (short)1309278210;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									global::Motorola.MackinawCPS.CoreFeatures.RadioWide.RxFrequencySplitFPPInnerSection rxFrequencySplitFPPInnerSection = ((global::AcpCommonLib.IAcpFeatureNode)enumerator.Current)[10097] as global::Motorola.MackinawCPS.CoreFeatures.RadioWide.RxFrequencySplitFPPInnerSection;
									num = (short)1430323204;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 2:
									goto IL_FA7;
								case 3:
									goto IL_F5A;
								case 4:
								{
									global::Motorola.MackinawCPS.CoreFeatures.RadioWide.RxFrequencySplitFPPInnerSection rxFrequencySplitFPPInnerSection;
									if (rxFrequencySplitFPPInnerSection != null)
									{
										num = (short)1648951306;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									break;
								}
								case 5:
								{
									int value;
									global::Motorola.MackinawCPS.CoreFeatures.RadioWide.RxFrequencySplitFPPInnerSection rxFrequencySplitFPPInnerSection;
									if (value >= rxFrequencySplitFPPInnerSection.RadWideLabtoolRxStartFrequencySplit_A9032.Value)
									{
										num = (short)1769930759;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									goto IL_F3F;
								}
								case 6:
									goto IL_F3F;
								case 7:
									num = (short)1685258240;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 8:
								{
									num = (short)1979837817;
									short num3 = num;
									num = (short)161410425;
									switch ((num3 == num) ? 1 : 0)
									{
									case 0:
									case 2:
										goto IL_FBF;
									default:
										num = (short)1051328512;
										if (num != 0)
										{
										}
										switch (0)
										{
										case 0:
											goto IL_E21;
										}
										continue;
									}
									break;
								}
								case 9:
									num = (short)1644560389;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 10:
									num = (short)1201405963;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 11:
								{
									global::Motorola.MackinawCPS.CoreFeatures.RadioWide.RxFrequencySplitFPPInnerSection rxFrequencySplitFPPInnerSection;
									if (rxFrequencySplitFPPInnerSection.RadWideLabtoolRxBandSplitName_A24797.Value == global::CommonResources.AcgResources.ID_UHF2)
									{
										num = (short)186843145;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									break;
								}
								case 12:
									goto IL_FBF;
								}
								IL_E23:
								num = (short)918093825;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								IL_E21:
								goto IL_E23;
								IL_F3F:
								result = false;
								num = (short)1044840451;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								IL_FA7:
								num = (short)1583874060;
								num2 = (int)((global::System.IntPtr)num);
							}
							IL_F5A:
							return result;
							IL_FBF:
							goto IL_D37;
						}
						finally
						{
							num = (short)543227906;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								switch (num2)
								{
								case 0:
									enumerator.Dispose();
									num = (short)1647509505;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 1:
									goto IL_102E;
								case 2:
									switch (0)
									{
									case 0:
										goto IL_FF7;
									}
									continue;
								}
								IL_FF7:
								if (enumerator == null)
								{
									break;
								}
								num = (short)34144256;
								num2 = (int)((global::System.IntPtr)num);
							}
							IL_102E:;
						}
						return true;
					case 1:
						num = (short)1519714311;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 2:
						if (trkSysGeneralTypeIIFrequencyBand_A.Value == 2)
						{
							num = (short)1458307103;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_D37;
					case 3:
						goto IL_1F5;
					case 4:
						return true;
					case 5:
						if (trkSysGeneralTypeIIFrequencyBand_A.Value == 1)
						{
							num = (short)1341980695;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_30F;
					case 6:
						if (trunkingSystem.General.TrkSysGeneralSystemType_A9252.Value != 3)
						{
							num = (short)1716846607;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_351;
					case 7:
					{
						int value;
						if (value % 1000 == 0)
						{
							num = (short)1167130628;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_37C;
					}
					case 8:
						if (channelRangesMHzInnerSection.TrkSysOBTChannelAssignmentListRxSpacingKHz_A9004.Value % 1000 == 0)
						{
							num = (short)2056585217;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_37C;
					case 9:
						num = (short)630849548;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 10:
						num = (short)1217658909;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 11:
					{
						try
						{
							num = (short)1216217090;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								switch (num2)
								{
								case 0:
								{
									global::AcpBusinessLayer.FeatureNode featureNode;
									if (featureNode is global::Motorola.MackinawCPS.CoreFeatures.TrunkingPersonality.TrunkingPersonality)
									{
										num = (short)87031811;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									break;
								}
								case 2:
									switch (0)
									{
									case 0:
										goto IL_459;
									}
									continue;
								case 3:
								{
									global::AcpBusinessLayer.FeatureNode featureNode;
									global::Motorola.MackinawCPS.CoreFeatures.TrunkingPersonality.TrunkingPersonality trunkingPersonality = featureNode as global::Motorola.MackinawCPS.CoreFeatures.TrunkingPersonality.TrunkingPersonality;
									trunkingPersonality.Talkgroup.CalculateApplicability();
									trunkingPersonality.Talkgroup.CalculateValidity();
									trunkingPersonality.AnnouncementGroup.TrkPerAnnouncementGroupAGFailsoftRxFrequencyMHz_A9582.CalculateValidity();
									trunkingPersonality.AnnouncementGroup.TrkPerAnnouncementGroupAGSecondaryFSRxFrequencyMHz_A8895.CalculateValidity();
									trunkingPersonality.General.TrkPerGeneralSecondaryRxFrequencyMHz_A8904.CalculateApplicability();
									trunkingPersonality.General.TrkPerGeneralSecondaryRxFrequencyMHz_A8904.CalculateValidity();
									trunkingPersonality.General.TrkPerGeneralRxFrequencyMHz_A8910.CalculateApplicability();
									trunkingPersonality.General.TrkPerGeneralRxFrequencyMHz_A8910.CalculateValidity();
									num = (short)789643265;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 4:
								{
									if (!enumerator.MoveNext())
									{
										num = (short)1376780293;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									global::AcpBusinessLayer.FeatureNode featureNode = enumerator.Current;
									num = (short)1459421184;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 5:
									num = (short)1756102662;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 6:
									goto IL_595;
								}
								IL_4F5:
								num = (short)1480982532;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								IL_459:
								goto IL_4F5;
							}
							IL_595:
							goto IL_CBE;
						}
						finally
						{
							num = (short)1982201856;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								switch (num2)
								{
								case 0:
									switch (0)
									{
									case 0:
										goto IL_5CD;
									}
									continue;
								case 1:
									enumerator.Dispose();
									num = (short)541917186;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 2:
									goto IL_605;
								}
								IL_5CD:
								if (enumerator == null)
								{
									break;
								}
								num = (short)1326841857;
								num2 = (int)((global::System.IntPtr)num);
							}
							IL_605:;
						}
						goto IL_608;
						IL_CBE:
						global::AcpCommonLib.IAcpFeatureNode parent = self.Parent;
						bool value2 = (parent[10168] as global::Motorola.MackinawCPS.CoreFeatures.TrunkingSystem.ChannelRangesMHzInnerSection).TrkSysOBTChannelAssignmentListRxEnable_A9001.Value;
						int value = (parent[10168] as global::Motorola.MackinawCPS.CoreFeatures.TrunkingSystem.ChannelRangesMHzInnerSection).TrkSysOBTChannelAssignmentListRxStartFrequencyMHz_A9029.Value;
						num = (short)551747611;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 12:
					{
						int value;
						if ((double)value % 1250.0 == 0.0)
						{
							num = (short)1506279438;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return false;
					}
					case 13:
						if (trkSysGeneralTypeIIFrequencyBand_A.Value != 0)
						{
							num = (short)2102001685;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_37C;
					case 14:
						goto IL_2E4;
					case 15:
						goto IL_608;
					case 16:
						if (trkSysGeneralTypeIIFrequencyBand_A.Value != 3)
						{
							num = (short)1087504416;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_351;
					case 17:
						return true;
					case 18:
						if ((double)channelRangesMHzInnerSection.TrkSysOBTChannelAssignmentListRxSpacingKHz_A9004.Value % 500.0 == 0.0)
						{
							num = (short)1880227850;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_6C2;
					case 19:
						if (trkSysGeneralTypeIIFrequencyBand_A.Value == 4)
						{
							num = (short)2090139651;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_C02;
					case 20:
						goto IL_98E;
					case 21:
						num = (short)3145736;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 22:
						if ((double)channelRangesMHzInnerSection.TrkSysOBTChannelAssignmentListRxSpacingKHz_A9004.Value % 1250.0 == 0.0)
						{
							num = (short)1503723529;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return false;
					case 23:
						enumerator = rxFrequencySplitFPPInnerRecset.GetEnumerator();
						num = (short)391970846;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 24:
						return true;
					case 25:
						if (trkSysGeneralTypeIIFrequencyBand_A.Value == 0)
						{
							num = (short)1324417052;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_3D4;
					case 26:
						if (trkSysGeneralTypeIIFrequencyBand_A.Value == 0)
						{
							num = (short)650903585;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_6C2;
					case 27:
					{
						bool value2;
						if (!value2)
						{
							num = (short)880738321;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)912457734;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 28:
						enumerator = rxFrequencySplitFPPInnerRecset.GetEnumerator();
						num = (short)499712020;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 29:
					{
						int value;
						if ((double)value % 500.0 == 0.0)
						{
							num = (short)650903576;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_6C2;
					}
					case 30:
						try
						{
							num = (short)1547960328;
							num2 = (int)((global::System.IntPtr)num);
							bool result;
							for (;;)
							{
								switch (num2)
								{
								case 0:
								{
									global::Motorola.MackinawCPS.CoreFeatures.RadioWide.RxFrequencySplitFPPInnerSection rxFrequencySplitFPPInnerSection2;
									if (rxFrequencySplitFPPInnerSection2.RadWideLabtoolRxBandSplitName_A24797.Value == global::CommonResources.AcgResources.ID_UHF1)
									{
										num = (short)706609158;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									break;
								}
								case 1:
								{
									global::Motorola.MackinawCPS.CoreFeatures.RadioWide.RxFrequencySplitFPPInnerSection rxFrequencySplitFPPInnerSection2;
									if (rxFrequencySplitFPPInnerSection2 != null)
									{
										num = (short)613613570;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									break;
								}
								case 2:
									num = (short)1844903936;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 3:
									goto IL_8B8;
								case 4:
								{
									if (!enumerator.MoveNext())
									{
										num = (short)619184138;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									global::Motorola.MackinawCPS.CoreFeatures.RadioWide.RxFrequencySplitFPPInnerSection rxFrequencySplitFPPInnerSection2 = ((global::AcpCommonLib.IAcpFeatureNode)enumerator.Current)[10097] as global::Motorola.MackinawCPS.CoreFeatures.RadioWide.RxFrequencySplitFPPInnerSection;
									num = (short)106561537;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 5:
								{
									int value;
									global::Motorola.MackinawCPS.CoreFeatures.RadioWide.RxFrequencySplitFPPInnerSection rxFrequencySplitFPPInnerSection2;
									if (value > rxFrequencySplitFPPInnerSection2.RadWideLabtoolRxEndFrequencySplit_A9015.Value)
									{
										num = (short)1718943751;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									goto IL_901;
								}
								case 6:
									num = (short)997785611;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 7:
									goto IL_89C;
								case 8:
									switch (0)
									{
									case 0:
										goto IL_780;
									}
									continue;
								case 9:
									num = (short)342949893;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 10:
									goto IL_901;
								case 11:
								{
									int value;
									global::Motorola.MackinawCPS.CoreFeatures.RadioWide.RxFrequencySplitFPPInnerSection rxFrequencySplitFPPInnerSection2;
									if (value >= rxFrequencySplitFPPInnerSection2.RadWideLabtoolRxStartFrequencySplit_A9032.Value)
									{
										num = (short)1593114633;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									goto IL_89C;
								}
								case 12:
									goto IL_919;
								}
								IL_7CE:
								num = (short)1621950468;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								IL_780:
								goto IL_7CE;
								IL_89C:
								result = false;
								num = (short)694878211;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								IL_901:
								num = (short)1141309452;
								num2 = (int)((global::System.IntPtr)num);
							}
							IL_8B8:
							return result;
							IL_919:
							goto IL_30F;
						}
						finally
						{
							num = (short)799801344;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								switch (num2)
								{
								case 0:
									switch (0)
									{
									case 0:
										goto IL_952;
									}
									continue;
								case 1:
									enumerator.Dispose();
									num = (short)1819803650;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 2:
									goto IL_98B;
								}
								IL_952:
								if (enumerator == null)
								{
									break;
								}
								num = (short)871694337;
								num2 = (int)((global::System.IntPtr)num);
							}
							IL_98B:;
						}
						goto Block_14;
					case 31:
						enumerator = rxFrequencySplitFPPInnerRecset.GetEnumerator();
						num = (short)484442112;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 32:
						num = (short)623443987;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 33:
						num = (short)606863378;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_B8;
					IL_30F:
					num = (short)595525634;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_37C:
					num = (short)1669791766;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_3D4:
					num = (short)853213189;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					Block_14:
					try
					{
						IL_98E:
						num = (short)1442840584;
						num2 = (int)((global::System.IntPtr)num);
						bool result;
						for (;;)
						{
							switch (num2)
							{
							case 0:
							{
								global::Motorola.MackinawCPS.CoreFeatures.RadioWide.RxFrequencySplitFPPInnerSection rxFrequencySplitFPPInnerSection3;
								if (rxFrequencySplitFPPInnerSection3.RadWideLabtoolRxBandSplitName_A24797.Value == global::CommonResources.AcgResources.ID_VHF)
								{
									num = (short)1784020998;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								break;
							}
							case 1:
							{
								global::Motorola.MackinawCPS.CoreFeatures.RadioWide.RxFrequencySplitFPPInnerSection rxFrequencySplitFPPInnerSection3;
								if (rxFrequencySplitFPPInnerSection3 != null)
								{
									num = (short)1334116354;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								break;
							}
							case 2:
								num = (short)1712062464;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							case 3:
								goto IL_B2B;
							case 4:
							{
								int value;
								global::Motorola.MackinawCPS.CoreFeatures.RadioWide.RxFrequencySplitFPPInnerSection rxFrequencySplitFPPInnerSection3;
								if (value > rxFrequencySplitFPPInnerSection3.RadWideLabtoolRxEndFrequencySplit_A9015.Value)
								{
									num = (short)2144010250;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								goto IL_B76;
							}
							case 5:
							{
								int value;
								global::Motorola.MackinawCPS.CoreFeatures.RadioWide.RxFrequencySplitFPPInnerSection rxFrequencySplitFPPInnerSection3;
								if (value >= rxFrequencySplitFPPInnerSection3.RadWideLabtoolRxStartFrequencySplit_A9032.Value)
								{
									num = (short)2001993735;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								goto IL_B10;
							}
							case 6:
								num = (short)942473221;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							case 7:
								num = (short)1498611716;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							case 8:
								switch (0)
								{
								case 0:
									goto IL_9E8;
								}
								continue;
							case 9:
								goto IL_B76;
							case 10:
								goto IL_B10;
							case 11:
							{
								if (!enumerator.MoveNext())
								{
									num = (short)1208811529;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								global::Motorola.MackinawCPS.CoreFeatures.RadioWide.RxFrequencySplitFPPInnerSection rxFrequencySplitFPPInnerSection3 = ((global::AcpCommonLib.IAcpFeatureNode)enumerator.Current)[10097] as global::Motorola.MackinawCPS.CoreFeatures.RadioWide.RxFrequencySplitFPPInnerSection;
								num = (short)338690049;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							case 12:
								goto IL_B8F;
							}
							IL_AD0:
							num = (short)1724645387;
							num2 = (int)((global::System.IntPtr)num);
							continue;
							IL_9E8:
							goto IL_AD0;
							IL_B10:
							result = false;
							num = (short)2100428803;
							num2 = (int)((global::System.IntPtr)num);
							continue;
							IL_B76:
							num = (short)825163788;
							num2 = (int)((global::System.IntPtr)num);
						}
						IL_B2B:
						return result;
						IL_B8F:
						goto IL_3D4;
					}
					finally
					{
						num = (short)1164312576;
						num2 = (int)((global::System.IntPtr)num);
						for (;;)
						{
							switch (num2)
							{
							case 0:
								switch (0)
								{
								case 0:
									goto IL_BC6;
								}
								continue;
							case 1:
								enumerator.Dispose();
								num = (short)1195966466;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							case 2:
								goto IL_BFF;
							}
							IL_BC6:
							if (enumerator == null)
							{
								break;
							}
							num = (short)985268225;
							num2 = (int)((global::System.IntPtr)num);
						}
						IL_BFF:;
					}
					goto IL_C02;
					IL_608:
					num = (short)1584529424;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_6C2:
					num = (short)1667104781;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_C02:
					rxFrequencySplitFPPInnerRecset = (((global::Motorola.MackinawCPS.CoreFeatures.RadioWide.RadioWideRecset)global::AcpCommonLib.FeatureManager.GetFeature(2045))[0][10096].EmbeddedRecset as global::Motorola.MackinawCPS.CoreFeatures.RadioWide.RxFrequencySplitFPPInnerRecset);
					num = (short)927924249;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_D37:
					num = (short)1916010522;
					num2 = (int)((global::System.IntPtr)num);
				}
				return true;
				IL_1F5:
				goto IL_351;
				IL_2E4:
				num = (short)184156161;
				if (num != 0)
				{
				}
				return true;
				IL_351:
				num = (short)2105475072;
				short num4 = num;
				return true;
				IL_B8:
				channelRangesMHzInnerSection = (self as global::Motorola.MackinawCPS.CoreFeatures.TrunkingSystem.ChannelRangesMHzInnerSection);
				trunkingSystem = (self.ParentRecset.ParentSection.Parent as global::Motorola.MackinawCPS.CoreFeatures.TrunkingSystem.TrunkingSystem);
				trkSysGeneralTypeIIFrequencyBand_A = trunkingSystem.General.TrkSysGeneralTypeIIFrequencyBand_A12491;
				global::AcpBusinessLayer.FeatureNode featureNode2 = self.Parent.Parent.ParentSection.Parent as global::AcpBusinessLayer.FeatureNode;
				global::Motorola.MackinawCPS.CoreFeatures.TrunkingSystem.TrunkingSystem trunkingSystem2 = featureNode2 as global::Motorola.MackinawCPS.CoreFeatures.TrunkingSystem.TrunkingSystem;
				trunkingSystem2.ControlChannels.CalculateApplicability();
				trunkingSystem2.ControlChannels.CalculateValidity();
				enumerator = featureNode2.ReferencingNodes.GetEnumerator();
				num = (short)1606221835;
				num2 = (int)((global::System.IntPtr)num);
				goto IL_29;
			}
			}
		}

		// Token: 0x06000BBB RID: 3003 RVA: 0x000AEF78 File Offset: 0x000AD178
		internal static bool ConTrkSysOBTTxStartFreq1IsValid(global::AcpCommonLib.IAcpFeatureSection self)
		{
			short num = (short)272957440;
			short num2 = num;
			num = (short)200867840;
			int num3 = (int)num;
			switch (num3)
			{
			default:
			{
				switch (0)
				{
				case 0:
					goto IL_E0;
				}
				global::AcpBusinessLayer.AcpFrequencyField trkSysOBTChannelAssignmentListTxStartFrequencyMHz_A;
				global::System.Collections.Generic.IEnumerator<global::AcpBusinessLayer.FeatureNode> enumerator;
				global::AcpBusinessLayer.AcpListField trkSysGeneralTypeIIFrequencyBand_A;
				global::Motorola.MackinawCPS.CoreFeatures.TrunkingSystem.ChannelRangesMHzInnerSection channelRangesMHzInnerSection;
				global::Motorola.MackinawCPS.CoreFeatures.TrunkingSystem.TrunkingSystem trunkingSystem;
				for (;;)
				{
					IL_51:
					switch (num3)
					{
					case 0:
						if ((double)trkSysOBTChannelAssignmentListTxStartFrequencyMHz_A.Value % 1250.0 == 0.0)
						{
							num = (short)1505493025;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						}
						return false;
					case 1:
						num = (short)162791424;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					case 2:
						goto IL_A14;
					case 3:
					{
						global::Motorola.MackinawCPS.CoreFeatures.RadioWide.TxFrequencySplitFPPInnerRecset txFrequencySplitFPPInnerRecset;
						enumerator = txFrequencySplitFPPInnerRecset.GetEnumerator();
						num = (short)1335427094;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 4:
						num = (short)817561613;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					case 5:
						if ((double)trkSysOBTChannelAssignmentListTxStartFrequencyMHz_A.Value % 500.0 == 0.0)
						{
							num = (short)2082996225;
							if (num != 0)
							{
							}
							num = (short)1776680987;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_FF0;
					case 6:
						goto IL_5EB;
					case 7:
						if (trkSysGeneralTypeIIFrequencyBand_A.Value != 3)
						{
							num = (short)1478426634;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						}
						return true;
					case 8:
						if (trkSysOBTChannelAssignmentListTxStartFrequencyMHz_A.Value % 1000 == 0)
						{
							num = (short)2001272862;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_65D;
					case 9:
					{
						if (trkSysGeneralTypeIIFrequencyBand_A.Value == 4)
						{
							num = (short)975568902;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						}
						global::Motorola.MackinawCPS.CoreFeatures.RadioWide.TxFrequencySplitFPPInnerRecset txFrequencySplitFPPInnerRecset = ((global::Motorola.MackinawCPS.CoreFeatures.RadioWide.RadioWideRecset)global::AcpCommonLib.FeatureManager.GetFeature(2045))[0][10094].EmbeddedRecset as global::Motorola.MackinawCPS.CoreFeatures.RadioWide.TxFrequencySplitFPPInnerRecset;
						num = (short)398524441;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 10:
						num = (short)1734213641;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					case 11:
						try
						{
							num = (short)1831469064;
							num3 = (int)((global::System.IntPtr)num);
							bool result;
							for (;;)
							{
								switch (num3)
								{
								case 0:
									goto IL_8F0;
								case 1:
								{
									global::Motorola.MackinawCPS.CoreFeatures.RadioWide.TxFrequencySplitFPPInnerSection txFrequencySplitFPPInnerSection;
									if (txFrequencySplitFPPInnerSection.RadWideLabtoolTxBandSplitName_A24799.Value == global::CommonResources.AcgResources.ID_VHF)
									{
										num = (short)2012807177;
										num3 = (int)((global::System.IntPtr)num);
										continue;
									}
									break;
								}
								case 2:
									num = (short)1224540161;
									num3 = (int)((global::System.IntPtr)num);
									continue;
								case 3:
									num = (short)817889285;
									num3 = (int)((global::System.IntPtr)num);
									continue;
								case 4:
									goto IL_9A0;
								case 5:
								{
									global::Motorola.MackinawCPS.CoreFeatures.RadioWide.TxFrequencySplitFPPInnerSection txFrequencySplitFPPInnerSection;
									if (trkSysOBTChannelAssignmentListTxStartFrequencyMHz_A.Value > txFrequencySplitFPPInnerSection.RadWideLabtoolTxEndFrequencySplit_A9532.Value)
									{
										num = (short)1298726919;
										num3 = (int)((global::System.IntPtr)num);
										continue;
									}
									goto IL_986;
								}
								case 6:
								{
									global::Motorola.MackinawCPS.CoreFeatures.RadioWide.TxFrequencySplitFPPInnerSection txFrequencySplitFPPInnerSection;
									if (txFrequencySplitFPPInnerSection != null)
									{
										num = (short)1868365826;
										num3 = (int)((global::System.IntPtr)num);
										continue;
									}
									break;
								}
								case 7:
									goto IL_8D3;
								case 8:
									switch (0)
									{
									case 0:
										goto IL_7F6;
									}
									continue;
								case 9:
									num = (short)1217200139;
									num3 = (int)((global::System.IntPtr)num);
									continue;
								case 10:
								{
									if (!enumerator.MoveNext())
									{
										num = (short)1979514892;
										num3 = (int)((global::System.IntPtr)num);
										continue;
									}
									global::Motorola.MackinawCPS.CoreFeatures.RadioWide.TxFrequencySplitFPPInnerSection txFrequencySplitFPPInnerSection = ((global::AcpCommonLib.IAcpFeatureNode)enumerator.Current)[10095] as global::Motorola.MackinawCPS.CoreFeatures.RadioWide.TxFrequencySplitFPPInnerSection;
									num = (short)2094596102;
									num3 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 11:
								{
									global::Motorola.MackinawCPS.CoreFeatures.RadioWide.TxFrequencySplitFPPInnerSection txFrequencySplitFPPInnerSection;
									if (trkSysOBTChannelAssignmentListTxStartFrequencyMHz_A.Value >= txFrequencySplitFPPInnerSection.RadWideLabtoolTxStartFrequencySplit_A9571.Value)
									{
										num = (short)2146762755;
										num3 = (int)((global::System.IntPtr)num);
										continue;
									}
									goto IL_8D3;
								}
								case 12:
									goto IL_986;
								}
								IL_7F8:
								num = (short)1107099658;
								num3 = (int)((global::System.IntPtr)num);
								continue;
								IL_7F6:
								goto IL_7F8;
								IL_8D3:
								result = false;
								num = (short)2092630016;
								num3 = (int)((global::System.IntPtr)num);
								continue;
								IL_986:
								num = (short)1622343684;
								num3 = (int)((global::System.IntPtr)num);
							}
							IL_8F0:
							return result;
							IL_9A0:
							goto IL_391;
						}
						finally
						{
							num = (short)1768357890;
							num3 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								switch (num3)
								{
								case 0:
									goto IL_A11;
								case 1:
									enumerator.Dispose();
									num = (short)1231355904;
									num3 = (int)((global::System.IntPtr)num);
									continue;
								case 2:
									switch (0)
									{
									case 0:
										goto IL_9D8;
									}
									continue;
								}
								IL_9D8:
								if (enumerator == null)
								{
									break;
								}
								num = (short)1267859457;
								num3 = (int)((global::System.IntPtr)num);
							}
							IL_A11:;
						}
						goto Block_15;
					case 12:
					{
						global::Motorola.MackinawCPS.CoreFeatures.RadioWide.TxFrequencySplitFPPInnerRecset txFrequencySplitFPPInnerRecset;
						enumerator = txFrequencySplitFPPInnerRecset.GetEnumerator();
						num = (short)1079312386;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 13:
						if (channelRangesMHzInnerSection.TrkSysOBTChannelAssignmentListTxSpacingKHz_A9520.Value % 1000 == 0)
						{
							num = (short)64225308;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_65D;
					case 14:
						if (trkSysGeneralTypeIIFrequencyBand_A.Value == 1)
						{
							num = (short)1294336012;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_348;
					case 15:
						if (trkSysGeneralTypeIIFrequencyBand_A.Value != 0)
						{
							num = (short)1272578052;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_65D;
					case 16:
						return true;
					case 17:
						goto IL_74C;
					case 18:
						num = (short)685309971;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					case 19:
						if ((double)channelRangesMHzInnerSection.TrkSysOBTChannelAssignmentListTxSpacingKHz_A9520.Value % 500.0 == 0.0)
						{
							num = (short)124518432;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_FF0;
					case 20:
						try
						{
							num = (short)940572676;
							num3 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								switch (num3)
								{
								case 0:
								{
									global::AcpBusinessLayer.FeatureNode featureNode;
									if (featureNode is global::Motorola.MackinawCPS.CoreFeatures.TrunkingPersonality.TrunkingPersonality)
									{
										num = (short)1244594181;
										num3 = (int)((global::System.IntPtr)num);
										continue;
									}
									break;
								}
								case 1:
									num = (short)1897660419;
									num3 = (int)((global::System.IntPtr)num);
									continue;
								case 3:
									goto IL_53A;
								case 4:
									switch (0)
									{
									case 0:
										goto IL_415;
									}
									continue;
								case 5:
								{
									global::AcpBusinessLayer.FeatureNode featureNode;
									global::Motorola.MackinawCPS.CoreFeatures.TrunkingPersonality.TrunkingPersonality trunkingPersonality = featureNode as global::Motorola.MackinawCPS.CoreFeatures.TrunkingPersonality.TrunkingPersonality;
									trunkingPersonality.Talkgroup.CalculateApplicability();
									trunkingPersonality.Talkgroup.CalculateValidity();
									trunkingPersonality.AnnouncementGroup.TrkPerAnnouncementGroupAGSecondaryFSTxFrequencyMHz_A12903.CalculateValidity();
									trunkingPersonality.AnnouncementGroup.TrkPerAnnouncementGroupAGFailsoftTxFrequencyMHz_A9583.CalculateValidity();
									trunkingPersonality.General.TrkPerGeneralTxFrequencyMHz_A9413.CalculateValidity();
									trunkingPersonality.General.TrkPerGeneralSecondaryTxFrequencyMHz_A12902.CalculateApplicability();
									trunkingPersonality.General.TrkPerGeneralSecondaryTxFrequencyMHz_A12902.CalculateValidity();
									num = (short)1284636674;
									num3 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 6:
								{
									if (!enumerator.MoveNext())
									{
										num = (short)1992556545;
										num3 = (int)((global::System.IntPtr)num);
										continue;
									}
									global::AcpBusinessLayer.FeatureNode featureNode = enumerator.Current;
									num = (short)1668218880;
									num3 = (int)((global::System.IntPtr)num);
									continue;
								}
								}
								IL_417:
								num = (short)1966080006;
								num3 = (int)((global::System.IntPtr)num);
								continue;
								IL_415:
								goto IL_417;
							}
							IL_53A:
							goto IL_C9A;
						}
						finally
						{
							num = (short)819724290;
							num3 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								switch (num3)
								{
								case 0:
									goto IL_5AB;
								case 1:
									enumerator.Dispose();
									num = (short)2067202048;
									num3 = (int)((global::System.IntPtr)num);
									continue;
								case 2:
									switch (0)
									{
									case 0:
										goto IL_571;
									}
									continue;
								}
								IL_571:
								if (enumerator == null)
								{
									break;
								}
								num = (short)1850081281;
								num3 = (int)((global::System.IntPtr)num);
							}
							IL_5AB:;
						}
						return true;
					case 21:
						if (!channelRangesMHzInnerSection.TrkSysOBTChannelAssignmentListTxEnable_A9517.Value)
						{
							num = (short)467992592;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)1817509912;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					case 22:
						try
						{
							num = (short)1111621640;
							num3 = (int)((global::System.IntPtr)num);
							bool result;
							for (;;)
							{
								switch (num3)
								{
								case 0:
									goto IL_DD0;
								case 1:
									goto IL_DEC;
								case 2:
								{
									global::Motorola.MackinawCPS.CoreFeatures.RadioWide.TxFrequencySplitFPPInnerSection txFrequencySplitFPPInnerSection2;
									if (trkSysOBTChannelAssignmentListTxStartFrequencyMHz_A.Value > txFrequencySplitFPPInnerSection2.RadWideLabtoolTxEndFrequencySplit_A9532.Value)
									{
										num = (short)497287168;
										num3 = (int)((global::System.IntPtr)num);
										continue;
									}
									goto IL_F13;
								}
								case 3:
									num = (short)808124426;
									num3 = (int)((global::System.IntPtr)num);
									continue;
								case 4:
									goto IL_F2C;
								case 5:
								{
									if (!enumerator.MoveNext())
									{
										num = (short)1406992391;
										num3 = (int)((global::System.IntPtr)num);
										continue;
									}
									global::Motorola.MackinawCPS.CoreFeatures.RadioWide.TxFrequencySplitFPPInnerSection txFrequencySplitFPPInnerSection2 = ((global::AcpCommonLib.IAcpFeatureNode)enumerator.Current)[10095] as global::Motorola.MackinawCPS.CoreFeatures.RadioWide.TxFrequencySplitFPPInnerSection;
									num = (short)1319174155;
									num3 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 6:
									num = (short)1230176258;
									num3 = (int)((global::System.IntPtr)num);
									continue;
								case 7:
									goto IL_F13;
								case 8:
									switch (0)
									{
									case 0:
										goto IL_D80;
									}
									continue;
								case 9:
								{
									global::Motorola.MackinawCPS.CoreFeatures.RadioWide.TxFrequencySplitFPPInnerSection txFrequencySplitFPPInnerSection2;
									if (trkSysOBTChannelAssignmentListTxStartFrequencyMHz_A.Value >= txFrequencySplitFPPInnerSection2.RadWideLabtoolTxStartFrequencySplit_A9571.Value)
									{
										num = (short)915210246;
										num3 = (int)((global::System.IntPtr)num);
										continue;
									}
									goto IL_DD0;
								}
								case 10:
								{
									global::Motorola.MackinawCPS.CoreFeatures.RadioWide.TxFrequencySplitFPPInnerSection txFrequencySplitFPPInnerSection2;
									if (txFrequencySplitFPPInnerSection2.RadWideLabtoolTxBandSplitName_A24799.Value == global::CommonResources.AcgResources.ID_UHF2)
									{
										num = (short)174784524;
										num3 = (int)((global::System.IntPtr)num);
										continue;
									}
									break;
								}
								case 11:
								{
									global::Motorola.MackinawCPS.CoreFeatures.RadioWide.TxFrequencySplitFPPInnerSection txFrequencySplitFPPInnerSection2;
									if (txFrequencySplitFPPInnerSection2 != null)
									{
										num = (short)335020035;
										num3 = (int)((global::System.IntPtr)num);
										continue;
									}
									break;
								}
								case 12:
									num = (short)2075262985;
									num3 = (int)((global::System.IntPtr)num);
									continue;
								}
								goto IL_D80;
								IL_DD0:
								result = false;
								num = (short)408354817;
								num3 = (int)((global::System.IntPtr)num);
								continue;
								IL_ED6:
								num = (short)2054815749;
								num3 = (int)((global::System.IntPtr)num);
								continue;
								IL_D80:
								goto IL_ED6;
								IL_F13:
								num = (short)1736835076;
								num3 = (int)((global::System.IntPtr)num);
							}
							IL_DEC:
							return result;
							IL_F2C:
							goto IL_CE2;
						}
						finally
						{
							num = (short)760610818;
							num3 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								num = (short)1683563371;
								short num4 = num;
								num = (short)425010027;
								switch ((num4 == num) ? 1 : 0)
								{
								case 0:
								case 2:
									goto IL_FED;
								default:
									num = (short)2005270528;
									if (num != 0)
									{
									}
									switch (num3)
									{
									case 0:
										goto IL_FEB;
									case 1:
										enumerator.Dispose();
										num = (short)1796472832;
										num3 = (int)((global::System.IntPtr)num);
										continue;
									case 2:
										switch (0)
										{
										case 0:
											goto IL_FB0;
										}
										continue;
									}
									IL_FB0:
									if (enumerator == null)
									{
										goto IL_FED;
									}
									num = (short)744095745;
									num3 = (int)((global::System.IntPtr)num);
									break;
								}
							}
							IL_FEB:
							IL_FED:;
						}
						return true;
					case 23:
						if (trkSysGeneralTypeIIFrequencyBand_A.Value == 2)
						{
							num = (short)2145255427;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_CE2;
					case 24:
						if (trunkingSystem.General.TrkSysGeneralSystemType_A9252.Value == 3)
						{
							num = (short)1901002769;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)1074790407;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					case 25:
						if (trkSysGeneralTypeIIFrequencyBand_A.Value == 0)
						{
							num = (short)718471199;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_391;
					case 26:
						if ((double)channelRangesMHzInnerSection.TrkSysOBTChannelAssignmentListTxSpacingKHz_A9520.Value % 1250.0 == 0.0)
						{
							num = (short)1632829441;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						}
						return false;
					case 27:
						return true;
					case 28:
						num = (short)540934152;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					case 29:
						if (trkSysGeneralTypeIIFrequencyBand_A.Value == 0)
						{
							num = (short)1013776402;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_FF0;
					case 30:
						return true;
					case 31:
					{
						global::Motorola.MackinawCPS.CoreFeatures.RadioWide.TxFrequencySplitFPPInnerRecset txFrequencySplitFPPInnerRecset;
						enumerator = txFrequencySplitFPPInnerRecset.GetEnumerator();
						num = (short)56885259;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 32:
						num = (short)1609170949;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					case 33:
						goto IL_343;
					}
					goto IL_E0;
					IL_348:
					num = (short)701431831;
					num3 = (int)((global::System.IntPtr)num);
					continue;
					Block_15:
					try
					{
						IL_A14:
						num = (short)1248526344;
						num3 = (int)((global::System.IntPtr)num);
						bool result;
						for (;;)
						{
							switch (num3)
							{
							case 0:
								goto IL_B67;
							case 1:
							{
								global::Motorola.MackinawCPS.CoreFeatures.RadioWide.TxFrequencySplitFPPInnerSection txFrequencySplitFPPInnerSection3;
								if (txFrequencySplitFPPInnerSection3.RadWideLabtoolTxBandSplitName_A24799.Value == global::CommonResources.AcgResources.ID_UHF1)
								{
									num = (short)854982665;
									num3 = (int)((global::System.IntPtr)num);
									continue;
								}
								break;
							}
							case 2:
								goto IL_C0D;
							case 3:
								num = (short)980025354;
								num3 = (int)((global::System.IntPtr)num);
								continue;
							case 4:
								goto IL_C25;
							case 5:
							{
								global::Motorola.MackinawCPS.CoreFeatures.RadioWide.TxFrequencySplitFPPInnerSection txFrequencySplitFPPInnerSection3;
								if (txFrequencySplitFPPInnerSection3 != null)
								{
									num = (short)1104019463;
									num3 = (int)((global::System.IntPtr)num);
									continue;
								}
								break;
							}
							case 6:
							{
								if (!enumerator.MoveNext())
								{
									num = (short)1510473730;
									num3 = (int)((global::System.IntPtr)num);
									continue;
								}
								global::Motorola.MackinawCPS.CoreFeatures.RadioWide.TxFrequencySplitFPPInnerSection txFrequencySplitFPPInnerSection3 = ((global::AcpCommonLib.IAcpFeatureNode)enumerator.Current)[10095] as global::Motorola.MackinawCPS.CoreFeatures.RadioWide.TxFrequencySplitFPPInnerSection;
								num = (short)1969815557;
								num3 = (int)((global::System.IntPtr)num);
								continue;
							}
							case 7:
								num = (short)1789788161;
								num3 = (int)((global::System.IntPtr)num);
								continue;
							case 8:
								switch (0)
								{
								case 0:
									goto IL_A6F;
								}
								continue;
							case 9:
								num = (short)1403846667;
								num3 = (int)((global::System.IntPtr)num);
								continue;
							case 10:
							{
								global::Motorola.MackinawCPS.CoreFeatures.RadioWide.TxFrequencySplitFPPInnerSection txFrequencySplitFPPInnerSection3;
								if (trkSysOBTChannelAssignmentListTxStartFrequencyMHz_A.Value > txFrequencySplitFPPInnerSection3.RadWideLabtoolTxEndFrequencySplit_A9532.Value)
								{
									num = (short)403636236;
									num3 = (int)((global::System.IntPtr)num);
									continue;
								}
								goto IL_C0D;
							}
							case 11:
							{
								global::Motorola.MackinawCPS.CoreFeatures.RadioWide.TxFrequencySplitFPPInnerSection txFrequencySplitFPPInnerSection3;
								if (trkSysOBTChannelAssignmentListTxStartFrequencyMHz_A.Value >= txFrequencySplitFPPInnerSection3.RadWideLabtoolTxStartFrequencySplit_A9571.Value)
								{
									num = (short)420085763;
									num3 = (int)((global::System.IntPtr)num);
									continue;
								}
								goto IL_B4A;
							}
							case 12:
								goto IL_B4A;
							}
							IL_B09:
							num = (short)5308422;
							num3 = (int)((global::System.IntPtr)num);
							continue;
							IL_A6F:
							goto IL_B09;
							IL_B4A:
							result = false;
							num = (short)859635712;
							num3 = (int)((global::System.IntPtr)num);
							continue;
							IL_C0D:
							num = (short)1621950468;
							num3 = (int)((global::System.IntPtr)num);
						}
						IL_B67:
						return result;
						IL_C25:
						goto IL_348;
					}
					finally
					{
						num = (short)523501570;
						num3 = (int)((global::System.IntPtr)num);
						for (;;)
						{
							switch (num3)
							{
							case 0:
								goto IL_C97;
							case 1:
								enumerator.Dispose();
								num = (short)432340992;
								num3 = (int)((global::System.IntPtr)num);
								continue;
							case 2:
								switch (0)
								{
								case 0:
									goto IL_C5E;
								}
								continue;
							}
							IL_C5E:
							if (enumerator == null)
							{
								break;
							}
							num = (short)1714421761;
							num3 = (int)((global::System.IntPtr)num);
						}
						IL_C97:;
					}
					goto IL_C9A;
					IL_391:
					num = (short)911736846;
					num3 = (int)((global::System.IntPtr)num);
					continue;
					IL_65D:
					num = (short)1560936474;
					num3 = (int)((global::System.IntPtr)num);
					continue;
					IL_C9A:
					num = (short)232783893;
					num3 = (int)((global::System.IntPtr)num);
					continue;
					IL_CE2:
					num = (short)1045561373;
					num3 = (int)((global::System.IntPtr)num);
					continue;
					IL_FF0:
					num = (short)617021455;
					num3 = (int)((global::System.IntPtr)num);
				}
				return true;
				IL_343:
				return true;
				IL_5EB:
				return true;
				IL_74C:
				return true;
				IL_E0:
				channelRangesMHzInnerSection = (self as global::Motorola.MackinawCPS.CoreFeatures.TrunkingSystem.ChannelRangesMHzInnerSection);
				trunkingSystem = (self.ParentRecset.ParentSection.Parent as global::Motorola.MackinawCPS.CoreFeatures.TrunkingSystem.TrunkingSystem);
				trkSysGeneralTypeIIFrequencyBand_A = trunkingSystem.General.TrkSysGeneralTypeIIFrequencyBand_A12491;
				trkSysOBTChannelAssignmentListTxStartFrequencyMHz_A = channelRangesMHzInnerSection.TrkSysOBTChannelAssignmentListTxStartFrequencyMHz_A9568;
				global::AcpBusinessLayer.FeatureNode featureNode2 = self.Parent.Parent.ParentSection.Parent as global::AcpBusinessLayer.FeatureNode;
				global::Motorola.MackinawCPS.CoreFeatures.TrunkingSystem.TrunkingSystem trunkingSystem2 = featureNode2 as global::Motorola.MackinawCPS.CoreFeatures.TrunkingSystem.TrunkingSystem;
				trunkingSystem2.ControlChannels.CalculateApplicability();
				trunkingSystem2.ControlChannels.CalculateValidity();
				enumerator = featureNode2.ReferencingNodes.GetEnumerator();
				num = (short)738590740;
				num3 = (int)((global::System.IntPtr)num);
				goto IL_51;
			}
			}
		}

		// Token: 0x06000BBC RID: 3004 RVA: 0x000B001C File Offset: 0x000AE21C
		internal static bool ConTrkSysOBTRxEndFreqIsValid(global::AcpCommonLib.IAcpFeatureSection self)
		{
			short num = (short)972357632;
			int num2 = (int)num;
			switch (num2)
			{
			default:
			{
				switch (0)
				{
				case 0:
					goto IL_7A;
				}
				global::AcpBusinessLayer.AcpListField trkSysGeneralTypeIIFrequencyBand_A;
				global::System.Collections.Generic.IEnumerator<global::AcpBusinessLayer.FeatureNode> enumerator;
				global::AcpCommonLib.IAcpFeatureNode acpFeatureNode2;
				global::AcpCommonLib.IAcpFeatureNode acpFeatureNode3;
				global::AcpCommonLib.IAcpFeatureNode acpFeatureNode4;
				global::Motorola.MackinawCPS.CoreFeatures.TrunkingSystem.TrunkingSystem trunkingSystem;
				global::Motorola.MackinawCPS.CoreFeatures.RadioWide.RxFrequencySplitFPPInnerRecset rxFrequencySplitFPPInnerRecset;
				for (;;)
				{
					IL_27:
					switch (num2)
					{
					case 0:
						goto IL_908;
					case 1:
						num = (short)2022440972;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 2:
						if (trkSysGeneralTypeIIFrequencyBand_A.Value != 3)
						{
							num = (short)1566769159;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return true;
					case 3:
						num = (short)327090187;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 4:
						goto IL_1D5;
					case 5:
						goto IL_DBE;
					case 6:
						if (trkSysGeneralTypeIIFrequencyBand_A.Value == 4)
						{
							num = (short)1839988736;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)896139282;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 7:
						goto IL_8CC;
					case 8:
						return true;
					case 9:
						try
						{
							num = (short)1198063641;
							num2 = (int)((global::System.IntPtr)num);
							bool result;
							for (;;)
							{
								switch (num2)
								{
								case 0:
									num = (short)1012989976;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 1:
									goto IL_68D;
								case 2:
									if (trkSysGeneralTypeIIFrequencyBand_A.Value == 0)
									{
										num = (short)1825898496;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									goto IL_47F;
								case 3:
									goto IL_5FD;
								case 4:
									goto IL_3D1;
								case 5:
								{
									int value;
									global::AcpCommonLib.IAcpFeatureNode acpFeatureNode;
									if (value > (acpFeatureNode[10097] as global::Motorola.MackinawCPS.CoreFeatures.RadioWide.RxFrequencySplitFPPInnerSection).RadWideLabtoolRxEndFrequencySplit_A9015.Value)
									{
										num = (short)1699741708;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									break;
								}
								case 6:
								{
									if (!enumerator.MoveNext())
									{
										num = (short)1713307675;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									global::AcpCommonLib.IAcpFeatureNode acpFeatureNode = enumerator.Current;
									num = (short)380895234;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 7:
								{
									int value;
									global::AcpCommonLib.IAcpFeatureNode acpFeatureNode;
									if (value >= (acpFeatureNode[10097] as global::Motorola.MackinawCPS.CoreFeatures.RadioWide.RxFrequencySplitFPPInnerSection).RadWideLabtoolRxStartFrequencySplit_A9032.Value)
									{
										num = (short)2098855965;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									goto IL_3B6;
								}
								case 8:
									num = (short)1033240583;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 9:
									goto IL_3B6;
								case 10:
									goto IL_859;
								case 11:
									num = (short)397803525;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 12:
									goto IL_672;
								case 13:
									num = (short)886636560;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 14:
								{
									int value;
									global::AcpCommonLib.IAcpFeatureNode acpFeatureNode;
									if (value >= (acpFeatureNode[10097] as global::Motorola.MackinawCPS.CoreFeatures.RadioWide.RxFrequencySplitFPPInnerSection).RadWideLabtoolRxStartFrequencySplit_A9032.Value)
									{
										num = (short)275841037;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									goto IL_5FD;
								}
								case 15:
									num = (short)1756692499;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 16:
								{
									int value;
									global::AcpCommonLib.IAcpFeatureNode acpFeatureNode;
									if (value > (acpFeatureNode[10097] as global::Motorola.MackinawCPS.CoreFeatures.RadioWide.RxFrequencySplitFPPInnerSection).RadWideLabtoolRxEndFrequencySplit_A9015.Value)
									{
										num = (short)1526857731;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									goto IL_571;
								}
								case 17:
								{
									int value;
									global::AcpCommonLib.IAcpFeatureNode acpFeatureNode;
									if (value > (acpFeatureNode[10097] as global::Motorola.MackinawCPS.CoreFeatures.RadioWide.RxFrequencySplitFPPInnerSection).RadWideLabtoolRxEndFrequencySplit_A9015.Value)
									{
										num = (short)2005270537;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									goto IL_47F;
								}
								case 18:
								{
									int value;
									global::AcpCommonLib.IAcpFeatureNode acpFeatureNode;
									if (value >= (acpFeatureNode[10097] as global::Motorola.MackinawCPS.CoreFeatures.RadioWide.RxFrequencySplitFPPInnerSection).RadWideLabtoolRxStartFrequencySplit_A9032.Value)
									{
										num = (short)1523777547;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									goto IL_672;
								}
								case 19:
								{
									global::AcpCommonLib.IAcpFeatureNode acpFeatureNode;
									if ((acpFeatureNode[10097] as global::Motorola.MackinawCPS.CoreFeatures.RadioWide.RxFrequencySplitFPPInnerSection).RadWideLabtoolRxBandSplitName_A24797.Value == global::CommonResources.AcgResources.ID_UHF2)
									{
										num = (short)1790312468;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									break;
								}
								case 20:
									num = (short)1371865106;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 21:
									num = (short)1073348622;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 22:
									if (trkSysGeneralTypeIIFrequencyBand_A.Value == 2)
									{
										num = (short)561250319;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									break;
								case 23:
									num = (short)621871132;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 24:
								{
									global::AcpCommonLib.IAcpFeatureNode acpFeatureNode;
									if ((acpFeatureNode[10097] as global::Motorola.MackinawCPS.CoreFeatures.RadioWide.RxFrequencySplitFPPInnerSection).RadWideLabtoolRxBandSplitName_A24797.Value == global::CommonResources.AcgResources.ID_VHF)
									{
										num = (short)873005064;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									goto IL_47F;
								}
								case 25:
									switch (0)
									{
									case 0:
										goto IL_3B1;
									}
									continue;
								case 26:
									if (trkSysGeneralTypeIIFrequencyBand_A.Value == 1)
									{
										num = (short)761856023;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									goto IL_571;
								case 27:
									num = (short)1314586634;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 28:
								{
									global::AcpCommonLib.IAcpFeatureNode acpFeatureNode;
									if ((acpFeatureNode[10097] as global::Motorola.MackinawCPS.CoreFeatures.RadioWide.RxFrequencySplitFPPInnerSection).RadWideLabtoolRxBandSplitName_A24797.Value == global::CommonResources.AcgResources.ID_UHF1)
									{
										num = (short)53674005;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									goto IL_571;
								}
								case 29:
									num = (short)1908998161;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 30:
									goto IL_618;
								}
								goto IL_3B1;
								IL_3B6:
								result = false;
								num = (short)1753088004;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								IL_47F:
								num = (short)961347610;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								IL_571:
								num = (short)966066198;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								IL_5FD:
								result = false;
								num = (short)1561853982;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								IL_672:
								result = false;
								num = (short)1239744513;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								IL_6EA:
								num = (short)2033188870;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								IL_3B1:
								goto IL_6EA;
							}
							IL_3D1:
							IL_618:
							IL_68D:
							return result;
							IL_859:
							goto IL_E3C;
						}
						finally
						{
							num = (short)1006305281;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								switch (num2)
								{
								case 0:
									goto IL_8C9;
								case 1:
									switch (0)
									{
									case 0:
										goto IL_892;
									}
									continue;
								case 2:
									enumerator.Dispose();
									num = (short)37617664;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								IL_892:
								if (enumerator == null)
								{
									break;
								}
								num = (short)1402208258;
								num2 = (int)((global::System.IntPtr)num);
							}
							IL_8C9:;
						}
						goto IL_8CC;
						IL_E3C:
						num = (short)1524039690;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 10:
					{
						num = (short)667680769;
						if (num != 0)
						{
						}
						int value;
						int value2;
						if (value >= value2)
						{
							num = (short)114950147;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return false;
					}
					case 11:
					{
						int value;
						int value2;
						int value3;
						if ((value - value2) % value3 != 0)
						{
							num = (short)1915092997;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						global::AcpCommonLib.IAcpFeatureNode parent;
						acpFeatureNode2 = parent.Parent[0];
						acpFeatureNode3 = parent.Parent[1];
						acpFeatureNode4 = parent.Parent[2];
						int num3 = (parent.Parent as global::AcpBusinessLayer.Recordset).IndexOf(parent);
						num = (short)2006253585;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 12:
					{
						int num3;
						if (num3 != 1)
						{
							num = (short)585039887;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_254;
					}
					case 13:
					{
						try
						{
							num = (short)1963524098;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								switch (num2)
								{
								case 0:
								{
									if (!enumerator.MoveNext())
									{
										num = (short)339607553;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									global::AcpBusinessLayer.FeatureNode featureNode = enumerator.Current;
									num = (short)1857945604;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 1:
									num = (short)792920067;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 2:
									switch (0)
									{
									case 0:
										goto IL_B41;
									}
									continue;
								case 3:
									goto IL_C76;
								case 4:
								{
									global::AcpBusinessLayer.FeatureNode featureNode;
									if (featureNode is global::Motorola.MackinawCPS.CoreFeatures.TrunkingPersonality.TrunkingPersonality)
									{
										num = (short)1984102405;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									break;
								}
								case 5:
								{
									global::AcpBusinessLayer.FeatureNode featureNode;
									global::Motorola.MackinawCPS.CoreFeatures.TrunkingPersonality.TrunkingPersonality trunkingPersonality = featureNode as global::Motorola.MackinawCPS.CoreFeatures.TrunkingPersonality.TrunkingPersonality;
									trunkingPersonality.Talkgroup.CalculateApplicability();
									trunkingPersonality.Talkgroup.CalculateValidity();
									trunkingPersonality.AnnouncementGroup.TrkPerAnnouncementGroupAGFailsoftRxFrequencyMHz_A9582.CalculateValidity();
									trunkingPersonality.AnnouncementGroup.TrkPerAnnouncementGroupAGSecondaryFSRxFrequencyMHz_A8895.CalculateValidity();
									trunkingPersonality.General.TrkPerGeneralSecondaryRxFrequencyMHz_A8904.CalculateApplicability();
									trunkingPersonality.General.TrkPerGeneralSecondaryRxFrequencyMHz_A8904.CalculateValidity();
									trunkingPersonality.General.TrkPerGeneralRxFrequencyMHz_A8910.CalculateApplicability();
									trunkingPersonality.General.TrkPerGeneralRxFrequencyMHz_A8910.CalculateValidity();
									num = (short)697040902;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								}
								IL_C1F:
								num = (short)1969487872;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								IL_B41:
								goto IL_C1F;
							}
							IL_C76:
							goto IL_186;
						}
						finally
						{
							num = (short)400228353;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								switch (num2)
								{
								case 0:
									goto IL_D37;
								case 1:
									switch (0)
									{
									case 0:
										goto IL_CAF;
									}
									continue;
								case 2:
									for (;;)
									{
										enumerator.Dispose();
										num = (short)1691792906;
										short num4 = num;
										num = (short)910865930;
										switch ((num4 == num) ? 1 : 0)
										{
										case 0:
										case 2:
											break;
										default:
											goto IL_D0A;
										}
									}
									IL_D0A:
									num = (short)1374748672;
									if (num != 0)
									{
									}
									num = (short)1316487168;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								IL_CAF:
								if (enumerator == null)
								{
									break;
								}
								num = (short)1646002178;
								num2 = (int)((global::System.IntPtr)num);
							}
							IL_D37:;
						}
						return true;
						IL_186:
						global::AcpCommonLib.IAcpFeatureNode parent = self.Parent;
						num = (short)915341328;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 14:
						goto IL_181;
					case 15:
						num = (short)1336541198;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 16:
						if (trunkingSystem.General.TrkSysGeneralSystemType_A9252.Value == 3)
						{
							num = (short)1776812036;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)732495874;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 17:
					{
						int num3;
						if (num3 != 0)
						{
							num = (short)1550647297;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_936;
					}
					case 18:
					{
						global::AcpCommonLib.IAcpFeatureNode parent;
						if (!(parent[10168] as global::Motorola.MackinawCPS.CoreFeatures.TrunkingSystem.ChannelRangesMHzInnerSection).TrkSysOBTChannelAssignmentListRxEnable_A9001.Value)
						{
							num = (short)205062152;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						int value2 = (parent[10168] as global::Motorola.MackinawCPS.CoreFeatures.TrunkingSystem.ChannelRangesMHzInnerSection).TrkSysOBTChannelAssignmentListRxStartFrequencyMHz_A9029.Value;
						int value = (parent[10168] as global::Motorola.MackinawCPS.CoreFeatures.TrunkingSystem.ChannelRangesMHzInnerSection).TrkSysOBTChannelAssignmentListRxEndFrequencyMHz_A9012.Value;
						int value3 = (parent[10168] as global::Motorola.MackinawCPS.CoreFeatures.TrunkingSystem.ChannelRangesMHzInnerSection).TrkSysOBTChannelAssignmentListRxSpacingKHz_A9004.Value;
						enumerator = rxFrequencySplitFPPInnerRecset.GetEnumerator();
						num = (short)1403387913;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					}
					goto IL_7A;
					IL_8CC:
					num = (short)567803910;
					num2 = (int)((global::System.IntPtr)num);
				}
				return false;
				IL_181:
				int num5 = ((acpFeatureNode2[10168] as global::Motorola.MackinawCPS.CoreFeatures.TrunkingSystem.ChannelRangesMHzInnerSection).TrkSysOBTChannelAssignmentListRxEndFrequencyMHz_A9012.Value - (acpFeatureNode2[10168] as global::Motorola.MackinawCPS.CoreFeatures.TrunkingSystem.ChannelRangesMHzInnerSection).TrkSysOBTChannelAssignmentListRxStartFrequencyMHz_A9029.Value) / (acpFeatureNode2[10168] as global::Motorola.MackinawCPS.CoreFeatures.TrunkingSystem.ChannelRangesMHzInnerSection).TrkSysOBTChannelAssignmentListRxSpacingKHz_A9004.Value + 1;
				int num6 = ((acpFeatureNode3[10168] as global::Motorola.MackinawCPS.CoreFeatures.TrunkingSystem.ChannelRangesMHzInnerSection).TrkSysOBTChannelAssignmentListRxEndFrequencyMHz_A9012.Value - (acpFeatureNode3[10168] as global::Motorola.MackinawCPS.CoreFeatures.TrunkingSystem.ChannelRangesMHzInnerSection).TrkSysOBTChannelAssignmentListRxStartFrequencyMHz_A9029.Value) / (acpFeatureNode3[10168] as global::Motorola.MackinawCPS.CoreFeatures.TrunkingSystem.ChannelRangesMHzInnerSection).TrkSysOBTChannelAssignmentListRxSpacingKHz_A9004.Value + 1;
				int num7 = ((acpFeatureNode4[10168] as global::Motorola.MackinawCPS.CoreFeatures.TrunkingSystem.ChannelRangesMHzInnerSection).TrkSysOBTChannelAssignmentListRxEndFrequencyMHz_A9012.Value - (acpFeatureNode4[10168] as global::Motorola.MackinawCPS.CoreFeatures.TrunkingSystem.ChannelRangesMHzInnerSection).TrkSysOBTChannelAssignmentListRxStartFrequencyMHz_A9029.Value) / (acpFeatureNode4[10168] as global::Motorola.MackinawCPS.CoreFeatures.TrunkingSystem.ChannelRangesMHzInnerSection).TrkSysOBTChannelAssignmentListRxSpacingKHz_A9004.Value + 1;
				return num5 + num6 + num7 <= 380;
				IL_1D5:
				return true;
				IL_254:
				int num8 = ((acpFeatureNode2[10168] as global::Motorola.MackinawCPS.CoreFeatures.TrunkingSystem.ChannelRangesMHzInnerSection).TrkSysOBTChannelAssignmentListRxEndFrequencyMHz_A9012.Value - (acpFeatureNode2[10168] as global::Motorola.MackinawCPS.CoreFeatures.TrunkingSystem.ChannelRangesMHzInnerSection).TrkSysOBTChannelAssignmentListRxStartFrequencyMHz_A9029.Value) / (acpFeatureNode2[10168] as global::Motorola.MackinawCPS.CoreFeatures.TrunkingSystem.ChannelRangesMHzInnerSection).TrkSysOBTChannelAssignmentListRxSpacingKHz_A9004.Value + 1;
				int num9 = ((acpFeatureNode3[10168] as global::Motorola.MackinawCPS.CoreFeatures.TrunkingSystem.ChannelRangesMHzInnerSection).TrkSysOBTChannelAssignmentListRxEndFrequencyMHz_A9012.Value - (acpFeatureNode3[10168] as global::Motorola.MackinawCPS.CoreFeatures.TrunkingSystem.ChannelRangesMHzInnerSection).TrkSysOBTChannelAssignmentListRxStartFrequencyMHz_A9029.Value) / (acpFeatureNode3[10168] as global::Motorola.MackinawCPS.CoreFeatures.TrunkingSystem.ChannelRangesMHzInnerSection).TrkSysOBTChannelAssignmentListRxSpacingKHz_A9004.Value + 1;
				return num8 + num9 <= 380;
				IL_908:
				num = (short)369819648;
				short num10 = num;
				return true;
				IL_936:
				return ((acpFeatureNode2[10168] as global::Motorola.MackinawCPS.CoreFeatures.TrunkingSystem.ChannelRangesMHzInnerSection).TrkSysOBTChannelAssignmentListRxEndFrequencyMHz_A9012.Value - (acpFeatureNode2[10168] as global::Motorola.MackinawCPS.CoreFeatures.TrunkingSystem.ChannelRangesMHzInnerSection).TrkSysOBTChannelAssignmentListRxStartFrequencyMHz_A9029.Value) / (acpFeatureNode2[10168] as global::Motorola.MackinawCPS.CoreFeatures.TrunkingSystem.ChannelRangesMHzInnerSection).TrkSysOBTChannelAssignmentListRxSpacingKHz_A9004.Value + 1 <= 380;
				IL_DBE:
				return false;
				IL_7A:
				trunkingSystem = (self.ParentRecset.ParentSection.Parent as global::Motorola.MackinawCPS.CoreFeatures.TrunkingSystem.TrunkingSystem);
				trkSysGeneralTypeIIFrequencyBand_A = trunkingSystem.General.TrkSysGeneralTypeIIFrequencyBand_A12491;
				rxFrequencySplitFPPInnerRecset = ((global::AcpCommonLib.FeatureManager.GetFeature(2045) as global::Motorola.MackinawCPS.CoreFeatures.RadioWide.RadioWideRecset)[0][10096].EmbeddedRecset as global::Motorola.MackinawCPS.CoreFeatures.RadioWide.RxFrequencySplitFPPInnerRecset);
				global::AcpBusinessLayer.FeatureNode featureNode2 = self.Parent.Parent.ParentSection.Parent as global::AcpBusinessLayer.FeatureNode;
				global::Motorola.MackinawCPS.CoreFeatures.TrunkingSystem.TrunkingSystem trunkingSystem2 = featureNode2 as global::Motorola.MackinawCPS.CoreFeatures.TrunkingSystem.TrunkingSystem;
				trunkingSystem2.ControlChannels.CalculateApplicability();
				trunkingSystem2.ControlChannels.CalculateValidity();
				enumerator = featureNode2.ReferencingNodes.GetEnumerator();
				num = (short)1317994509;
				num2 = (int)((global::System.IntPtr)num);
				goto IL_27;
			}
			}
		}

		// Token: 0x06000BBD RID: 3005 RVA: 0x000B0F04 File Offset: 0x000AF104
		internal static bool ConTrkSysOBTTxEndFreqIsValid(global::AcpCommonLib.IAcpFeatureSection self)
		{
			short num = (short)223674368;
			int num2 = (int)num;
			switch (num2)
			{
			default:
			{
				num = (short)1602224129;
				if (num != 0)
				{
				}
				switch (0)
				{
				case 0:
					goto IL_A2;
				}
				global::AcpBusinessLayer.AcpListField trkSysGeneralTypeIIFrequencyBand_A;
				global::System.Collections.Generic.IEnumerator<global::AcpBusinessLayer.FeatureNode> enumerator;
				global::AcpCommonLib.IAcpFeatureNode parent;
				global::Motorola.MackinawCPS.CoreFeatures.TrunkingSystem.TrunkingSystem trunkingSystem;
				global::Motorola.MackinawCPS.CoreFeatures.RadioWide.TxFrequencySplitFPPInnerRecset txFrequencySplitFPPInnerRecset;
				for (;;)
				{
					IL_4F:
					switch (num2)
					{
					case 0:
						goto IL_92F;
					case 1:
						num = (short)705232908;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 2:
						if (trkSysGeneralTypeIIFrequencyBand_A.Value != 3)
						{
							num = (short)455475207;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return true;
					case 3:
						num = (short)184811531;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 4:
						goto IL_1FE;
					case 5:
						goto IL_E17;
					case 6:
						if (trkSysGeneralTypeIIFrequencyBand_A.Value == 4)
						{
							num = (short)970784768;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)980090898;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 7:
						goto IL_8F2;
					case 8:
						return true;
					case 9:
						try
						{
							num = (short)522125337;
							num2 = (int)((global::System.IntPtr)num);
							bool result;
							for (;;)
							{
								switch (num2)
								{
								case 0:
									num = (short)552796184;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 1:
									goto IL_6B0;
								case 2:
									if (trkSysGeneralTypeIIFrequencyBand_A.Value == 0)
									{
										num = (short)2028011520;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									goto IL_49B;
								case 3:
									goto IL_61E;
								case 4:
									goto IL_3ED;
								case 5:
								{
									int value;
									global::AcpCommonLib.IAcpFeatureNode acpFeatureNode;
									if (value > (acpFeatureNode[10095] as global::Motorola.MackinawCPS.CoreFeatures.RadioWide.TxFrequencySplitFPPInnerSection).RadWideLabtoolTxEndFrequencySplit_A9532.Value)
									{
										num = (short)1544945676;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									break;
								}
								case 6:
								{
									if (!enumerator.MoveNext())
									{
										num = (short)339345435;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									global::AcpCommonLib.IAcpFeatureNode acpFeatureNode = enumerator.Current;
									num = (short)1113915394;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 7:
								{
									int value;
									global::AcpCommonLib.IAcpFeatureNode acpFeatureNode;
									if (value >= (acpFeatureNode[10095] as global::Motorola.MackinawCPS.CoreFeatures.RadioWide.TxFrequencySplitFPPInnerSection).RadWideLabtoolTxStartFrequencySplit_A9571.Value)
									{
										num = (short)64028701;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									goto IL_3D1;
								}
								case 8:
									num = (short)1722286087;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 9:
									goto IL_3D1;
								case 10:
									goto IL_880;
								case 11:
									num = (short)2070806533;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 12:
									goto IL_694;
								case 13:
									num = (short)651624464;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 14:
								{
									int value;
									global::AcpCommonLib.IAcpFeatureNode acpFeatureNode;
									if (value >= (acpFeatureNode[10095] as global::Motorola.MackinawCPS.CoreFeatures.RadioWide.TxFrequencySplitFPPInnerSection).RadWideLabtoolTxStartFrequencySplit_A9571.Value)
									{
										num = (short)899350541;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									goto IL_61E;
								}
								case 15:
									num = (short)1048903699;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 16:
								{
									int value;
									global::AcpCommonLib.IAcpFeatureNode acpFeatureNode;
									if (value > (acpFeatureNode[10095] as global::Motorola.MackinawCPS.CoreFeatures.RadioWide.TxFrequencySplitFPPInnerSection).RadWideLabtoolTxEndFrequencySplit_A9532.Value)
									{
										num = (short)1666711555;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									goto IL_591;
								}
								case 17:
								{
									int value;
									global::AcpCommonLib.IAcpFeatureNode acpFeatureNode;
									if (value > (acpFeatureNode[10095] as global::Motorola.MackinawCPS.CoreFeatures.RadioWide.TxFrequencySplitFPPInnerSection).RadWideLabtoolTxEndFrequencySplit_A9532.Value)
									{
										num = (short)1062207497;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									goto IL_49B;
								}
								case 18:
								{
									int value;
									global::AcpCommonLib.IAcpFeatureNode acpFeatureNode;
									if (value >= (acpFeatureNode[10095] as global::Motorola.MackinawCPS.CoreFeatures.RadioWide.TxFrequencySplitFPPInnerSection).RadWideLabtoolTxStartFrequencySplit_A9571.Value)
									{
										num = (short)867762187;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									goto IL_694;
								}
								case 19:
								{
									global::AcpCommonLib.IAcpFeatureNode acpFeatureNode;
									if ((acpFeatureNode[10095] as global::Motorola.MackinawCPS.CoreFeatures.RadioWide.TxFrequencySplitFPPInnerSection).RadWideLabtoolTxBandSplitName_A24799.Value == global::CommonResources.AcgResources.ID_UHF2)
									{
										num = (short)2064187412;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									break;
								}
								case 20:
									num = (short)2026635282;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 21:
									num = (short)1749024782;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 22:
									if (trkSysGeneralTypeIIFrequencyBand_A.Value == 2)
									{
										num = (short)1650982927;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									break;
								case 23:
									num = (short)1309409308;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 24:
								{
									global::AcpCommonLib.IAcpFeatureNode acpFeatureNode;
									if ((acpFeatureNode[10095] as global::Motorola.MackinawCPS.CoreFeatures.RadioWide.TxFrequencySplitFPPInnerSection).RadWideLabtoolTxBandSplitName_A24799.Value == global::CommonResources.AcgResources.ID_VHF)
									{
										num = (short)1225457672;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									goto IL_49B;
								}
								case 25:
									switch (0)
									{
									case 0:
										goto IL_3CC;
									}
									continue;
								case 26:
									if (trkSysGeneralTypeIIFrequencyBand_A.Value == 1)
									{
										num = (short)1876426775;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									goto IL_591;
								case 27:
									num = (short)671940618;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 28:
								{
									global::AcpCommonLib.IAcpFeatureNode acpFeatureNode;
									if ((acpFeatureNode[10095] as global::Motorola.MackinawCPS.CoreFeatures.RadioWide.TxFrequencySplitFPPInnerSection).RadWideLabtoolTxBandSplitName_A24799.Value == global::CommonResources.AcgResources.ID_UHF1)
									{
										num = (short)1835728917;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									goto IL_591;
								}
								case 29:
									num = (short)2075983889;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 30:
									goto IL_639;
								}
								goto IL_3CC;
								IL_3D1:
								result = false;
								num = (short)1839398916;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								IL_49B:
								num = (short)1714290714;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								IL_591:
								num = (short)203227158;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								IL_61E:
								result = false;
								num = (short)2004156446;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								IL_694:
								result = false;
								num = (short)2003632129;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								IL_70C:
								num = (short)2144141318;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								IL_3CC:
								goto IL_70C;
							}
							IL_3ED:
							IL_639:
							IL_6B0:
							return result;
							IL_880:
							goto IL_E96;
						}
						finally
						{
							num = (short)1744044033;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								switch (num2)
								{
								case 0:
									enumerator.Dispose();
									num = (short)431947778;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 1:
									switch (0)
									{
									case 0:
										goto IL_8B7;
									}
									continue;
								case 2:
									goto IL_8EF;
								}
								IL_8B7:
								if (enumerator == null)
								{
									break;
								}
								num = (short)118030336;
								num2 = (int)((global::System.IntPtr)num);
							}
							IL_8EF:;
						}
						goto IL_8F2;
						IL_E96:
						num = (short)2096824330;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 10:
					{
						int value;
						int value2;
						if (value >= value2)
						{
							num = (short)608567299;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return false;
					}
					case 11:
					{
						int value;
						int value2;
						int value3;
						if ((value - value2) % value3 != 0)
						{
							num = (short)2141913088;
							short num3 = num;
							num = (short)798359557;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						int num4 = (parent.Parent as global::AcpBusinessLayer.Recordset).IndexOf(parent);
						num = (short)1361313809;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 12:
					{
						int num4;
						if (num4 != 1)
						{
							num = (short)216072207;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_253;
					}
					case 13:
						try
						{
							num = (short)284753922;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								switch (num2)
								{
								case 0:
								{
									global::AcpBusinessLayer.FeatureNode featureNode;
									global::Motorola.MackinawCPS.CoreFeatures.TrunkingPersonality.TrunkingPersonality trunkingPersonality = featureNode as global::Motorola.MackinawCPS.CoreFeatures.TrunkingPersonality.TrunkingPersonality;
									trunkingPersonality.Talkgroup.CalculateApplicability();
									trunkingPersonality.Talkgroup.CalculateValidity();
									trunkingPersonality.AnnouncementGroup.TrkPerAnnouncementGroupAGSecondaryFSTxFrequencyMHz_A12903.CalculateValidity();
									trunkingPersonality.AnnouncementGroup.TrkPerAnnouncementGroupAGFailsoftTxFrequencyMHz_A9583.CalculateValidity();
									trunkingPersonality.General.TrkPerGeneralTxFrequencyMHz_A9413.CalculateApplicability();
									trunkingPersonality.General.TrkPerGeneralTxFrequencyMHz_A9413.CalculateValidity();
									trunkingPersonality.General.TrkPerGeneralSecondaryTxFrequencyMHz_A12902.CalculateApplicability();
									trunkingPersonality.General.TrkPerGeneralSecondaryTxFrequencyMHz_A12902.CalculateValidity();
									num = (short)1724710915;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 1:
								{
									if (!enumerator.MoveNext())
									{
										num = (short)1170014212;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									global::AcpBusinessLayer.FeatureNode featureNode = enumerator.Current;
									goto IL_B84;
								}
								case 2:
									switch (0)
									{
									case 0:
										goto IL_B76;
									}
									continue;
								case 4:
									num = (short)2068578310;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 5:
								{
									global::AcpBusinessLayer.FeatureNode featureNode;
									if (featureNode is global::Motorola.MackinawCPS.CoreFeatures.TrunkingPersonality.TrunkingPersonality)
									{
										num = (short)2081816576;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									break;
								}
								case 6:
									goto IL_CF6;
								}
								goto IL_B76;
								IL_B84:
								num = (short)867041285;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								IL_C53:
								num = (short)1416465420;
								short num5 = num;
								num = (short)139561996;
								switch ((num5 == num) ? 1 : 0)
								{
								case 0:
								case 2:
									goto IL_B84;
								default:
									num = (short)1970143232;
									if (num != 0)
									{
									}
									num = (short)646578177;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								IL_B76:
								goto IL_C53;
							}
							IL_CF6:
							goto IL_1B0;
						}
						finally
						{
							num = (short)1261502465;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								switch (num2)
								{
								case 0:
									enumerator.Dispose();
									num = (short)227475458;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 1:
									switch (0)
									{
									case 0:
										goto IL_D2E;
									}
									continue;
								case 2:
									goto IL_D67;
								}
								IL_D2E:
								if (enumerator == null)
								{
									break;
								}
								num = (short)488046592;
								num2 = (int)((global::System.IntPtr)num);
							}
							IL_D67:;
						}
						return true;
						IL_1B0:
						parent = self.Parent;
						num = (short)1462960144;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 14:
						goto IL_1AB;
					case 15:
						num = (short)1896611854;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 16:
						if (trunkingSystem.General.TrkSysGeneralSystemType_A9252.Value == 3)
						{
							num = (short)1375207428;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)1646395394;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 17:
					{
						int num4;
						if (num4 != 0)
						{
							num = (short)835321857;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_934;
					}
					case 18:
					{
						if (!(parent[10168] as global::Motorola.MackinawCPS.CoreFeatures.TrunkingSystem.ChannelRangesMHzInnerSection).TrkSysOBTChannelAssignmentListTxEnable_A9517.Value)
						{
							num = (short)823918600;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						int value2 = (parent[10168] as global::Motorola.MackinawCPS.CoreFeatures.TrunkingSystem.ChannelRangesMHzInnerSection).TrkSysOBTChannelAssignmentListTxStartFrequencyMHz_A9568.Value;
						int value = (parent[10168] as global::Motorola.MackinawCPS.CoreFeatures.TrunkingSystem.ChannelRangesMHzInnerSection).TrkSysOBTChannelAssignmentListTxEndFrequencyMHz_A9529.Value;
						int value3 = (parent[10168] as global::Motorola.MackinawCPS.CoreFeatures.TrunkingSystem.ChannelRangesMHzInnerSection).TrkSysOBTChannelAssignmentListTxSpacingKHz_A9520.Value;
						enumerator = txFrequencySplitFPPInnerRecset.GetEnumerator();
						num = (short)1766916105;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					}
					goto IL_A2;
					IL_8F2:
					num = (short)1429798918;
					num2 = (int)((global::System.IntPtr)num);
				}
				return false;
				IL_1AB:
				global::AcpCommonLib.IAcpFeatureNode acpFeatureNode2 = parent.Parent[0];
				global::AcpCommonLib.IAcpFeatureNode acpFeatureNode3 = parent.Parent[1];
				global::AcpCommonLib.IAcpFeatureNode acpFeatureNode4 = parent.Parent[2];
				int num6 = ((acpFeatureNode2[10168] as global::Motorola.MackinawCPS.CoreFeatures.TrunkingSystem.ChannelRangesMHzInnerSection).TrkSysOBTChannelAssignmentListTxEndFrequencyMHz_A9529.Value - (acpFeatureNode2[10168] as global::Motorola.MackinawCPS.CoreFeatures.TrunkingSystem.ChannelRangesMHzInnerSection).TrkSysOBTChannelAssignmentListTxStartFrequencyMHz_A9568.Value) / (acpFeatureNode2[10168] as global::Motorola.MackinawCPS.CoreFeatures.TrunkingSystem.ChannelRangesMHzInnerSection).TrkSysOBTChannelAssignmentListTxSpacingKHz_A9520.Value + 1;
				int num7 = ((acpFeatureNode3[10168] as global::Motorola.MackinawCPS.CoreFeatures.TrunkingSystem.ChannelRangesMHzInnerSection).TrkSysOBTChannelAssignmentListTxEndFrequencyMHz_A9529.Value - (acpFeatureNode3[10168] as global::Motorola.MackinawCPS.CoreFeatures.TrunkingSystem.ChannelRangesMHzInnerSection).TrkSysOBTChannelAssignmentListTxStartFrequencyMHz_A9568.Value) / (acpFeatureNode3[10168] as global::Motorola.MackinawCPS.CoreFeatures.TrunkingSystem.ChannelRangesMHzInnerSection).TrkSysOBTChannelAssignmentListTxSpacingKHz_A9520.Value + 1;
				int num8 = ((acpFeatureNode4[10168] as global::Motorola.MackinawCPS.CoreFeatures.TrunkingSystem.ChannelRangesMHzInnerSection).TrkSysOBTChannelAssignmentListTxEndFrequencyMHz_A9529.Value - (acpFeatureNode4[10168] as global::Motorola.MackinawCPS.CoreFeatures.TrunkingSystem.ChannelRangesMHzInnerSection).TrkSysOBTChannelAssignmentListTxStartFrequencyMHz_A9568.Value) / (acpFeatureNode4[10168] as global::Motorola.MackinawCPS.CoreFeatures.TrunkingSystem.ChannelRangesMHzInnerSection).TrkSysOBTChannelAssignmentListTxSpacingKHz_A9520.Value + 1;
				return num6 + num7 + num8 <= 380;
				IL_1FE:
				return true;
				IL_253:
				global::AcpCommonLib.IAcpFeatureNode acpFeatureNode5 = parent.Parent[0];
				global::AcpCommonLib.IAcpFeatureNode acpFeatureNode6 = parent.Parent[1];
				int num9 = ((acpFeatureNode5[10168] as global::Motorola.MackinawCPS.CoreFeatures.TrunkingSystem.ChannelRangesMHzInnerSection).TrkSysOBTChannelAssignmentListTxEndFrequencyMHz_A9529.Value - (acpFeatureNode5[10168] as global::Motorola.MackinawCPS.CoreFeatures.TrunkingSystem.ChannelRangesMHzInnerSection).TrkSysOBTChannelAssignmentListTxStartFrequencyMHz_A9568.Value) / (acpFeatureNode5[10168] as global::Motorola.MackinawCPS.CoreFeatures.TrunkingSystem.ChannelRangesMHzInnerSection).TrkSysOBTChannelAssignmentListTxSpacingKHz_A9520.Value + 1;
				int num10 = ((acpFeatureNode6[10168] as global::Motorola.MackinawCPS.CoreFeatures.TrunkingSystem.ChannelRangesMHzInnerSection).TrkSysOBTChannelAssignmentListTxEndFrequencyMHz_A9529.Value - (acpFeatureNode6[10168] as global::Motorola.MackinawCPS.CoreFeatures.TrunkingSystem.ChannelRangesMHzInnerSection).TrkSysOBTChannelAssignmentListTxStartFrequencyMHz_A9568.Value) / (acpFeatureNode6[10168] as global::Motorola.MackinawCPS.CoreFeatures.TrunkingSystem.ChannelRangesMHzInnerSection).TrkSysOBTChannelAssignmentListTxSpacingKHz_A9520.Value + 1;
				return num9 + num10 <= 380;
				IL_92F:
				return true;
				IL_934:
				global::AcpCommonLib.IAcpFeatureNode acpFeatureNode7 = parent.Parent[0];
				return ((acpFeatureNode7[10168] as global::Motorola.MackinawCPS.CoreFeatures.TrunkingSystem.ChannelRangesMHzInnerSection).TrkSysOBTChannelAssignmentListTxEndFrequencyMHz_A9529.Value - (acpFeatureNode7[10168] as global::Motorola.MackinawCPS.CoreFeatures.TrunkingSystem.ChannelRangesMHzInnerSection).TrkSysOBTChannelAssignmentListTxStartFrequencyMHz_A9568.Value) / (acpFeatureNode7[10168] as global::Motorola.MackinawCPS.CoreFeatures.TrunkingSystem.ChannelRangesMHzInnerSection).TrkSysOBTChannelAssignmentListTxSpacingKHz_A9520.Value + 1 <= 380;
				IL_E17:
				return false;
				IL_A2:
				trunkingSystem = (self.ParentRecset.ParentSection.Parent as global::Motorola.MackinawCPS.CoreFeatures.TrunkingSystem.TrunkingSystem);
				trkSysGeneralTypeIIFrequencyBand_A = trunkingSystem.General.TrkSysGeneralTypeIIFrequencyBand_A12491;
				txFrequencySplitFPPInnerRecset = ((global::AcpCommonLib.FeatureManager.GetFeature(2045) as global::Motorola.MackinawCPS.CoreFeatures.RadioWide.RadioWideRecset)[0][10094].EmbeddedRecset as global::Motorola.MackinawCPS.CoreFeatures.RadioWide.TxFrequencySplitFPPInnerRecset);
				global::AcpBusinessLayer.FeatureNode featureNode2 = self.Parent.Parent.ParentSection.Parent as global::AcpBusinessLayer.FeatureNode;
				global::Motorola.MackinawCPS.CoreFeatures.TrunkingSystem.TrunkingSystem trunkingSystem2 = featureNode2 as global::Motorola.MackinawCPS.CoreFeatures.TrunkingSystem.TrunkingSystem;
				trunkingSystem2.ControlChannels.CalculateApplicability();
				trunkingSystem2.ControlChannels.CalculateValidity();
				enumerator = featureNode2.ReferencingNodes.GetEnumerator();
				num = (short)659161101;
				num2 = (int)((global::System.IntPtr)num);
				goto IL_4F;
			}
			}
		}

		// Token: 0x06000BBE RID: 3006 RVA: 0x000B1E20 File Offset: 0x000B0020
		internal static bool ConBoolTrkSysTrkStsAlsIndicatorIsEnable(global::AcpCommonLib.IAcpFeatureSection self)
		{
			short num = (short)483983361;
			if (num != 0)
			{
			}
			num = (short)1276903424;
			short num2 = num;
			num = (short)270185328;
			short num3 = num;
			num = (short)1167569776;
			switch (num3 == num)
			{
			}
			num = (short)700841984;
			if (num != 0)
			{
			}
			return (self.ParentRecset.ParentSection.Parent as global::Motorola.MackinawCPS.CoreFeatures.TrunkingSystem.TrunkingSystem).StatusAlias.TrkSysStatusAliasStatusAliasEnable_A9195.Value;
		}

		// Token: 0x06000BBF RID: 3007 RVA: 0x000B1EF0 File Offset: 0x000B00F0
		internal static bool conSetMaxForSystemIDBasedOnSystemType(global::AcpCommonLib.IAcpFeatureSection self)
		{
			short num = (short)683409411;
			int num2 = (int)((global::System.IntPtr)num);
			bool result;
			for (;;)
			{
				global::AcpBusinessLayer.AcpSimpleRangeField trkSysGeneralSystemID_A;
				switch (num2)
				{
				case 0:
					if (trkSysGeneralSystemID_A.Value >= 1)
					{
						num = (short)1789132807;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					return result;
				case 1:
				{
					result = true;
					num = (short)1665662976;
					short num3 = num;
					num = (short)1354694662;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				case 2:
					if (trkSysGeneralSystemID_A.Value <= 4094)
					{
						goto IL_B3;
					}
					return result;
				case 3:
					switch (0)
					{
					case 0:
						goto IL_54;
					}
					continue;
				case 4:
					result = true;
					num = (short)2062417930;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 5:
					if (trkSysGeneralSystemID_A.Value >= 1)
					{
						num = (short)419954697;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					return result;
				case 6:
					goto IL_111;
				case 7:
					num = (short)1816395787;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 8:
					num = (short)629276672;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 9:
					num = (short)163643394;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 10:
					return result;
				case 11:
					if (trkSysGeneralSystemID_A.Value <= 65535)
					{
						num = (short)747438081;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					return result;
				}
				IL_54:
				global::Motorola.MackinawCPS.CoreFeatures.TrunkingSystem.General general = self as global::Motorola.MackinawCPS.CoreFeatures.TrunkingSystem.General;
				trkSysGeneralSystemID_A = general.TrkSysGeneralSystemID_A9239;
				result = false;
				if (general.TrkSysGeneralSystemType_A9252.Value == 2)
				{
					num = (short)1603338248;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				num = (short)2037133224;
				short num4 = num;
				num = (short)734736296;
				switch ((num4 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					break;
				default:
					num = (short)1995374592;
					if (num != 0)
					{
					}
					num = (short)2055340037;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				IL_B3:
				num = (short)83034116;
				num2 = (int)((global::System.IntPtr)num);
			}
			IL_111:
			num = (short)1395589121;
			if (num != 0)
			{
			}
			return result;
		}

		// Token: 0x06000BC0 RID: 3008 RVA: 0x000B2164 File Offset: 0x000B0364
		internal static bool conValidateSiteIDBasedOnSystemType(global::AcpCommonLib.IAcpFeatureSection self)
		{
			switch (0)
			{
			case 0:
				goto IL_40;
			}
			short num2;
			global::AcpBusinessLayer.AcpSimpleRangeField trkSysSiteAliasSiteAliasNumber_A;
			global::AcpBusinessLayer.AcpListField trkSysGeneralSystemType_A;
			for (;;)
			{
				IL_0A:
				int num;
				switch (num)
				{
				case 0:
					num2 = (short)1801191426;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 1:
					num2 = (short)811859975;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 2:
				{
					num2 = (short)296222720;
					short num3 = num2;
					if (trkSysSiteAliasSiteAliasNumber_A.Value >= 1)
					{
						num2 = (short)888078340;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					return false;
				}
				case 3:
					if (trkSysGeneralSystemType_A.Value == 2)
					{
						num2 = (short)2047082504;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					num2 = (short)1749024774;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 4:
					num2 = (short)255524869;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 5:
					goto IL_261;
				case 6:
					if (trkSysGeneralSystemType_A.Value == 3)
					{
						num2 = (short)1228734464;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					return false;
				case 7:
					num2 = (short)1382612993;
					if (num2 != 0)
					{
					}
					if (trkSysSiteAliasSiteAliasNumber_A.Value <= 64)
					{
						num2 = (short)576847882;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					return false;
				case 8:
					num2 = (short)544145419;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 9:
					return true;
				case 10:
					return true;
				case 11:
					if (trkSysSiteAliasSiteAliasNumber_A.Value >= 1)
					{
						num2 = (short)1740701697;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					return false;
				}
				goto IL_40;
			}
			return true;
			IL_40:
			global::Motorola.MackinawCPS.CoreFeatures.TrunkingSystem.SiteAliasInnerSection siteAliasInnerSection = self as global::Motorola.MackinawCPS.CoreFeatures.TrunkingSystem.SiteAliasInnerSection;
			trkSysGeneralSystemType_A = (self.ParentRecset.ParentSection.Parent as global::Motorola.MackinawCPS.CoreFeatures.TrunkingSystem.TrunkingSystem).General.TrkSysGeneralSystemType_A9252;
			trkSysSiteAliasSiteAliasNumber_A = siteAliasInnerSection.TrkSysSiteAliasSiteAliasNumber_A9145;
			num2 = (short)114037819;
			short num4 = num2;
			num2 = (short)813306939;
			switch ((num4 == num2) ? 1 : 0)
			{
			case 0:
			case 2:
				IL_261:
				if (trkSysSiteAliasSiteAliasNumber_A.Value <= 254)
				{
					num2 = (short)2083848201;
					int num = (int)((global::System.IntPtr)num2);
					goto IL_0A;
				}
				break;
			default:
			{
				num2 = (short)1333657600;
				if (num2 != 0)
				{
				}
				num2 = (short)336134147;
				int num = (int)((global::System.IntPtr)num2);
				goto IL_0A;
			}
			}
			return false;
		}

		// Token: 0x06000BC1 RID: 3009 RVA: 0x000B23FC File Offset: 0x000B05FC
		internal static bool conSetMinAndMaxForStatusNumBasedOnSystemType(global::AcpCommonLib.IAcpFeatureSection self)
		{
			switch (0)
			{
			case 0:
				goto IL_40;
			}
			short num2;
			bool result;
			global::Motorola.MackinawCPS.CoreFeatures.TrunkingSystem.StatusAliasInnerSection statusAliasInnerSection;
			for (;;)
			{
				IL_0A:
				int num;
				switch (num)
				{
				case 0:
				{
					global::AcpBusinessLayer.AcpSimpleRangeField trkSysStatusAliasStatusAliasNumber_A;
					if (trkSysStatusAliasStatusAliasNumber_A.Value >= 1)
					{
						num2 = (short)1717698567;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					return result;
				}
				case 1:
					result = true;
					num2 = (short)1515257862;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 2:
				{
					num2 = (short)701431808;
					short num3 = num2;
					global::AcpBusinessLayer.AcpSimpleRangeField trkSysStatusAliasStatusAliasNumber_A;
					if (trkSysStatusAliasStatusAliasNumber_A.Value <= 16)
					{
						num2 = (short)910295044;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					return result;
				}
				case 3:
				{
					global::Motorola.MackinawCPS.CoreFeatures.TrunkingSystem.TrunkingSystem trunkingSystem = self.ParentRecset.ParentSection.Parent as global::Motorola.MackinawCPS.CoreFeatures.TrunkingSystem.TrunkingSystem;
					global::AcpBusinessLayer.AcpSimpleRangeField trkSysStatusAliasStatusAliasNumber_A = statusAliasInnerSection.TrkSysStatusAliasStatusAliasNumber_A9190;
					result = false;
					if (trunkingSystem.General.TrkSysGeneralSystemType_A9252.Value == 2)
					{
						num2 = (short)1011613704;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_242;
				}
				case 4:
					result = true;
					num2 = (short)1091633162;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 5:
				{
					global::AcpBusinessLayer.AcpSimpleRangeField trkSysStatusAliasStatusAliasNumber_A;
					if (trkSysStatusAliasStatusAliasNumber_A.Value >= 1)
					{
						num2 = (short)1671888905;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					return result;
				}
				case 6:
					return result;
				case 7:
					num2 = (short)639172609;
					if (num2 != 0)
					{
					}
					num2 = (short)606994443;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 8:
					num2 = (short)1978728448;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 9:
					num2 = (short)312803330;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 10:
					return result;
				case 11:
				{
					global::AcpBusinessLayer.AcpSimpleRangeField trkSysStatusAliasStatusAliasNumber_A;
					if (trkSysStatusAliasStatusAliasNumber_A.Value <= 8)
					{
						num2 = (short)405340161;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					return result;
				}
				}
				goto IL_40;
			}
			return result;
			IL_40:
			statusAliasInnerSection = (self as global::Motorola.MackinawCPS.CoreFeatures.TrunkingSystem.StatusAliasInnerSection);
			num2 = (short)1167121672;
			short num4 = num2;
			num2 = (short)1961024776;
			switch ((num4 == num2) ? 1 : 0)
			{
			case 0:
			case 2:
			{
				IL_242:
				num2 = (short)312213509;
				int num = (int)((global::System.IntPtr)num2);
				goto IL_0A;
			}
			default:
			{
				num2 = (short)536018944;
				if (num2 != 0)
				{
				}
				num2 = (short)506593283;
				int num = (int)((global::System.IntPtr)num2);
				goto IL_0A;
			}
			}
		}

		// Token: 0x06000BC2 RID: 3010 RVA: 0x000B2688 File Offset: 0x000B0888
		internal static bool ConSiteAlsIsEnabledAndApplicable(global::AcpCommonLib.IAcpFeatureSection self)
		{
			short num = (short)2040463365;
			int num2 = (int)((global::System.IntPtr)num);
			global::AcpBusinessLayer.AcpListField trkSysGeneralCoverageType_A;
			for (;;)
			{
				global::AcpBusinessLayer.AcpListField trkSysGeneralSystemType_A;
				switch (num2)
				{
				case 0:
					goto IL_1F7;
				case 1:
					num = (short)845742083;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 2:
					goto IL_25C;
				case 3:
					if (trkSysGeneralCoverageType_A.Value != 6)
					{
						num = (short)1286012928;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					return true;
				case 4:
				{
					num = (short)1836187648;
					short num3 = num;
					num = (short)366967912;
					short num4 = num;
					num = (short)1413577832;
					switch ((num4 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						return false;
					default:
						num = (short)1478295552;
						if (num != 0)
						{
						}
						num = (short)1303511046;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					break;
				}
				case 5:
					switch (0)
					{
					case 0:
						goto IL_5C;
					}
					continue;
				case 6:
					if (trkSysGeneralCoverageType_A.Value != 3)
					{
						num = (short)1824063496;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					return true;
				case 7:
					if (trkSysGeneralSystemType_A.Value == 3)
					{
						num = (short)1784086532;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_1F7;
				case 8:
					num = (short)40435721;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 9:
					if (trkSysGeneralCoverageType_A.Value != 7)
					{
						num = (short)20905995;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					return true;
				case 10:
					num = (short)1326252039;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 11:
					num = (short)1740505101;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 12:
					num = (short)2015232001;
					if (num != 0)
					{
					}
					if (trkSysGeneralSystemType_A.Value == 2)
					{
						num = (short)897056770;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					return false;
				case 13:
					if (trkSysGeneralCoverageType_A.Value != 5)
					{
						num = (short)96534529;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					return true;
				}
				IL_5C:
				global::Motorola.MackinawCPS.CoreFeatures.TrunkingSystem.TrunkingSystem trunkingSystem = self.ParentRecset.ParentSection.Parent as global::Motorola.MackinawCPS.CoreFeatures.TrunkingSystem.TrunkingSystem;
				trkSysGeneralSystemType_A = trunkingSystem.General.TrkSysGeneralSystemType_A9252;
				trkSysGeneralCoverageType_A = trunkingSystem.General.TrkSysGeneralCoverageType_A7782;
				if (trunkingSystem.SiteAlias.TrkSysSiteAliasSiteAliasEnable_A9148.Value)
				{
					num = (short)433848330;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				return false;
				IL_1F7:
				num = (short)1536884748;
				num2 = (int)((global::System.IntPtr)num);
			}
			return false;
			IL_25C:
			return trkSysGeneralCoverageType_A.Value == 3;
		}

		// Token: 0x06000BC3 RID: 3011 RVA: 0x000B2974 File Offset: 0x000B0B74
		internal static bool conReturnFalse(global::AcpCommonLib.IAcpFeatureSection self)
		{
			short num = (short)1447002283;
			short num2 = num;
			num = (short)1369669803;
			switch (num2 == num)
			{
			default:
			{
				num = (short)205783040;
				short num3 = num;
				break;
			}
			case true:
				break;
			}
			num = (short)1364000769;
			if (num != 0)
			{
			}
			num = (short)1578041344;
			if (num != 0)
			{
			}
			return false;
		}

		// Token: 0x06000BC4 RID: 3012 RVA: 0x000B2A1C File Offset: 0x000B0C1C
		internal static bool conAstro25andChannelIDEnableIsEnabled(global::AcpCommonLib.IAcpFeatureSection self)
		{
			short num = (short)491675638;
			short num2 = num;
			num = (short)130768886;
			switch ((num2 == num) ? 1 : 0)
			{
			case 0:
			case 2:
				break;
			default:
			{
				num = (short)15073281;
				if (num != 0)
				{
				}
				num = (short)105578496;
				if (num != 0)
				{
				}
				global::Motorola.MackinawCPS.CoreFeatures.TrunkingSystem.ASTRO25ChannelIDInnerSection astro25ChannelIDInnerSection = self as global::Motorola.MackinawCPS.CoreFeatures.TrunkingSystem.ASTRO25ChannelIDInnerSection;
				global::Motorola.MackinawCPS.CoreFeatures.TrunkingSystem.TrunkingSystem trunkingSystem = self.ParentRecset.ParentSection.Parent as global::Motorola.MackinawCPS.CoreFeatures.TrunkingSystem.TrunkingSystem;
				if (!astro25ChannelIDInnerSection.TrkSysASTRO25ChannelIDIdentifierEnable_A8222.Value)
				{
					num = (short)223019008;
					short num3 = num;
					return trunkingSystem.General.TrkSysGeneralSystemType_A9252.Value == 3;
				}
				break;
			}
			}
			return false;
		}

		// Token: 0x06000BC5 RID: 3013 RVA: 0x000B2B04 File Offset: 0x000B0D04
		internal static bool ConX2VoiceCapableIsEnabled(global::AcpCommonLib.IAcpFeatureSection self)
		{
			short num = (short)1300054920;
			short num2 = num;
			num = (short)952255368;
			switch ((num2 == num) ? 1 : 0)
			{
			case 0:
			case 2:
				break;
			default:
			{
				num = (short)2129264641;
				if (num != 0)
				{
				}
				num = (short)698220544;
				if (num != 0)
				{
				}
				global::Motorola.MackinawCPS.CoreFeatures.TrunkingSystem.ASTRO26 astro = self as global::Motorola.MackinawCPS.CoreFeatures.TrunkingSystem.ASTRO26;
				global::Motorola.MackinawCPS.CoreFeatures.TrunkingSystem.TrunkingSystem trunkingSystem = self.Parent as global::Motorola.MackinawCPS.CoreFeatures.TrunkingSystem.TrunkingSystem;
				if (astro.TrkSysASTRO25F2VoiceCapable_A1395.Value)
				{
					num = (short)2141847552;
					short num3 = num;
					return trunkingSystem.General.TrkSysGeneralSystemType_A9252.Value == 3;
				}
				break;
			}
			}
			return false;
		}

		// Token: 0x06000BC6 RID: 3014 RVA: 0x000B2BE4 File Offset: 0x000B0DE4
		internal static bool conControlChannelRxFreqValidity(global::AcpCommonLib.IAcpFeatureSection self)
		{
			short num = (short)1999306752;
			switch (num)
			{
			default:
			{
				num = (short)1963065359;
				int num2 = (int)((global::System.IntPtr)num);
				bool result;
				for (;;)
				{
					global::Motorola.MackinawCPS.CoreFeatures.RadioWide.RxFrequencySplitFPPInnerRecset rxFrequencySplitFPPInnerRecset;
					global::System.Collections.Generic.IEnumerator<global::AcpBusinessLayer.FeatureNode> enumerator;
					int num3;
					global::AcpBusinessLayer.AcpListField trkSysGeneralTypeIIFrequencyBand_A;
					global::AcpBusinessLayer.AcpListField trkSysGeneralSystemType_A;
					global::Motorola.MackinawCPS.CoreFeatures.TrunkingSystem.ASTRO25ChannelIDInnerRecset astro25ChannelIDInnerRecset;
					switch (num2)
					{
					case 0:
						num = (short)1141440517;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 1:
						enumerator = rxFrequencySplitFPPInnerRecset.GetEnumerator();
						num = (short)251133974;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 2:
						if (!global::ConstraintHelper.UtilityMack.IsRxFrequencyBandEnabled(num3, false))
						{
							num = (short)2005270537;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_586;
					case 3:
						if (trkSysGeneralTypeIIFrequencyBand_A.Value == 4)
						{
							num = (short)123535360;
							short num4 = num;
							num = (short)2145648663;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_109D;
					case 4:
						goto IL_18C;
					case 5:
						if (trkSysGeneralTypeIIFrequencyBand_A.Value == 2)
						{
							num = (short)530251796;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return false;
					case 6:
						goto IL_102D;
					case 7:
						try
						{
							num = (short)1603928068;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								switch (num2)
								{
								case 0:
									num = (short)1668939779;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 1:
								{
									global::AcpCommonLib.IAcpFeatureNode acpFeatureNode;
									if ((acpFeatureNode[10097] as global::Motorola.MackinawCPS.CoreFeatures.RadioWide.RxFrequencySplitFPPInnerSection).RadWideLabtoolRxBandSplitName_A24797.Value == global::CommonResources.AcgResources.ID_P_900M)
									{
										num = (short)1810366475;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									break;
								}
								case 2:
								{
									if (!enumerator.MoveNext())
									{
										num = (short)1216020488;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									global::AcpCommonLib.IAcpFeatureNode acpFeatureNode = enumerator.Current;
									num = (short)1699741697;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 3:
								{
									global::AcpCommonLib.IAcpFeatureNode acpFeatureNode;
									if (num3 < (acpFeatureNode[10097] as global::Motorola.MackinawCPS.CoreFeatures.RadioWide.RxFrequencySplitFPPInnerSection).RadWideLabtoolRxEndFrequencySplit_A9015.Value * 5)
									{
										num = (short)1952120837;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									break;
								}
								case 4:
									switch (0)
									{
									case 0:
										goto IL_22D;
									}
									continue;
								case 5:
									num = (short)1392181254;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 6:
									if (num3 % 12500 == 0)
									{
										num = (short)178782220;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									break;
								case 7:
									goto IL_2FF;
								case 8:
									num = (short)1986396170;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 9:
								{
									global::AcpCommonLib.IAcpFeatureNode acpFeatureNode;
									if (num3 > (acpFeatureNode[10097] as global::Motorola.MackinawCPS.CoreFeatures.RadioWide.RxFrequencySplitFPPInnerSection).RadWideLabtoolRxStartFrequencySplit_A9032.Value * 5)
									{
										num = (short)264044544;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									break;
								}
								case 10:
									goto IL_3FF;
								case 11:
									num = (short)682229769;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 12:
									result = true;
									num = (short)1161101319;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								IL_3A9:
								num = (short)1135411202;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								IL_22D:
								goto IL_3A9;
							}
							IL_2FF:
							return result;
							IL_3FF:
							goto IL_109D;
						}
						finally
						{
							num = (short)1817706496;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								switch (num2)
								{
								case 0:
									switch (0)
									{
									case 0:
										goto IL_437;
									}
									continue;
								case 1:
									enumerator.Dispose();
									num = (short)1520041986;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 2:
									goto IL_46E;
								}
								IL_437:
								if (enumerator == null)
								{
									break;
								}
								num = (short)292814849;
								num2 = (int)((global::System.IntPtr)num);
							}
							IL_46E:;
						}
						goto IL_471;
					case 8:
						if (trkSysGeneralTypeIIFrequencyBand_A.Value != 1)
						{
							num = (short)2033451008;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_100D;
					case 9:
						goto IL_4AF;
					case 10:
						if (!global::ConstraintHelper.UtilityMack.IsRxFrequencyBandEnabled(num3, true))
						{
							num = (short)510197773;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_586;
					case 11:
						try
						{
							num = (short)534773779;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								switch (num2)
								{
								case 0:
									goto IL_F98;
								case 1:
									result = true;
									num = (short)2099642376;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 2:
								{
									if (!enumerator.MoveNext())
									{
										num = (short)1878851600;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									global::AcpCommonLib.IAcpFeatureNode acpFeatureNode2 = enumerator.Current;
									num = (short)1099366415;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 3:
									num = (short)1013841938;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 4:
								{
									global::AcpCommonLib.IAcpFeatureNode acpFeatureNode2;
									if (num3 <= (acpFeatureNode2[10161] as global::Motorola.MackinawCPS.CoreFeatures.TrunkingSystem.ASTRO25ChannelIDInnerSection).TrkSysASTRO25ChannelIDBaseFrequencyMHz_A7546.Value * 5 + (acpFeatureNode2[10161] as global::Motorola.MackinawCPS.CoreFeatures.TrunkingSystem.ASTRO25ChannelIDInnerSection).TrkSysASTRO25ChannelIDChannelSpacingkHz_A7660.Value * 5 * 4095)
									{
										num = (short)995622915;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									break;
								}
								case 5:
									num = (short)1726283787;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 6:
								{
									global::AcpCommonLib.IAcpFeatureNode acpFeatureNode2;
									if (num3 >= (acpFeatureNode2[10161] as global::Motorola.MackinawCPS.CoreFeatures.TrunkingSystem.ASTRO25ChannelIDInnerSection).TrkSysASTRO25ChannelIDBaseFrequencyMHz_A7546.Value * 5)
									{
										num = (short)1621360653;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									break;
								}
								case 7:
									result = true;
									num = (short)1159069713;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 8:
									goto IL_E57;
								case 9:
								{
									global::AcpCommonLib.IAcpFeatureNode acpFeatureNode2;
									if (!(acpFeatureNode2[10161] as global::Motorola.MackinawCPS.CoreFeatures.TrunkingSystem.ASTRO25ChannelIDInnerSection).TrkSysASTRO25ChannelIDIdentifierEnable_A8222.Value)
									{
										num = (short)2020016148;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									break;
								}
								case 10:
								{
									global::AcpCommonLib.IAcpFeatureNode acpFeatureNode2;
									if (!(acpFeatureNode2[10161] as global::Motorola.MackinawCPS.CoreFeatures.TrunkingSystem.ASTRO25ChannelIDInnerSection).TrkSysASTRO25ChannelIDIdentifierEnable_A8222.Value)
									{
										num = (short)1595998220;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									break;
								}
								case 11:
								{
									global::AcpCommonLib.IAcpFeatureNode acpFeatureNode2;
									if (num3 <= (acpFeatureNode2[10161] as global::Motorola.MackinawCPS.CoreFeatures.TrunkingSystem.ASTRO25ChannelIDInnerSection).TrkSysASTRO25ChannelIDBaseFrequencyMHz_A7546.Value * 5 + (acpFeatureNode2[10161] as global::Motorola.MackinawCPS.CoreFeatures.TrunkingSystem.ASTRO25ChannelIDInnerSection).TrkSysASTRO25ChannelIDChannelSpacingkHz_A7660.Value * 5 * 4095)
									{
										num = (short)2119106567;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									break;
								}
								case 12:
									num = (short)2094530566;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 13:
									num = (short)982777860;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 14:
									num = (short)1048313866;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 15:
								{
									global::AcpCommonLib.IAcpFeatureNode acpFeatureNode2;
									if ((acpFeatureNode2[10161] as global::Motorola.MackinawCPS.CoreFeatures.TrunkingSystem.ASTRO25ChannelIDInnerSection).TrkSysASTRO25ChannelIDChannelSpacingkHz_A7660.Value != 0)
									{
										num = (short)940769294;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									num = (short)1978728457;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 16:
									num = (short)1814495232;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 17:
									goto IL_BE8;
								case 18:
								{
									global::AcpCommonLib.IAcpFeatureNode acpFeatureNode2;
									if ((num3 - (acpFeatureNode2[10161] as global::Motorola.MackinawCPS.CoreFeatures.TrunkingSystem.ASTRO25ChannelIDInnerSection).TrkSysASTRO25ChannelIDBaseFrequencyMHz_A7546.Value * 5) % ((acpFeatureNode2[10161] as global::Motorola.MackinawCPS.CoreFeatures.TrunkingSystem.ASTRO25ChannelIDInnerSection).TrkSysASTRO25ChannelIDChannelSpacingkHz_A7660.Value * 5) == 0)
									{
										num = (short)2114584577;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									break;
								}
								case 19:
									switch (0)
									{
									case 0:
										goto IL_BCA;
									}
									continue;
								case 20:
									num = (short)2065563669;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 21:
								{
									global::AcpCommonLib.IAcpFeatureNode acpFeatureNode2;
									if (num3 >= (acpFeatureNode2[10161] as global::Motorola.MackinawCPS.CoreFeatures.TrunkingSystem.ASTRO25ChannelIDInnerSection).TrkSysASTRO25ChannelIDBaseFrequencyMHz_A7546.Value * 5)
									{
										num = (short)1454112773;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									break;
								}
								}
								IL_EBD:
								num = (short)2060779522;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								IL_BCA:
								goto IL_EBD;
							}
							IL_BE8:
							IL_E57:
							return result;
							IL_F98:
							return false;
						}
						finally
						{
							num = (short)1527840770;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								switch (num2)
								{
								case 0:
									enumerator.Dispose();
									num = (short)505675777;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 1:
									goto IL_100A;
								case 2:
									switch (0)
									{
									case 0:
										goto IL_FD0;
									}
									continue;
								}
								IL_FD0:
								if (enumerator == null)
								{
									break;
								}
								num = (short)1586495488;
								num2 = (int)((global::System.IntPtr)num);
							}
							IL_100A:;
						}
						goto IL_100D;
					case 12:
						if (trkSysGeneralTypeIIFrequencyBand_A.Value == 3)
						{
							num = (short)1144127489;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_1032;
					case 13:
						return false;
					case 14:
						if (trkSysGeneralTypeIIFrequencyBand_A.Value != 0)
						{
							num = (short)1326252053;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_100D;
					case 15:
						switch (0)
						{
						case 0:
							goto IL_A4;
						}
						continue;
					case 16:
						if (trkSysGeneralSystemType_A.Value == 2)
						{
							num = (short)1854930962;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						enumerator = astro25ChannelIDInnerRecset.GetEnumerator();
						num = (short)1017315339;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 17:
						if (global::ConstraintHelper.UtilityMack.IsMahaloRadio)
						{
							num = (short)1287585811;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_471;
					case 18:
						num = (short)1038811148;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 19:
						num = (short)1084293130;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 20:
						goto IL_100D;
					case 21:
						num = (short)1667956744;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 22:
						try
						{
							num = (short)1702690824;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								switch (num2)
								{
								case 0:
								{
									string value;
									if (value == global::CommonResources.AcgResources.ID_P_700M_1)
									{
										num = (short)1527644169;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									goto IL_9E0;
								}
								case 1:
									num = (short)312410112;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 2:
									if (num3 % 6250 == 0)
									{
										num = (short)1849884691;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									goto IL_9E0;
								case 3:
								{
									global::AcpCommonLib.IAcpFeatureNode acpFeatureNode3;
									if (num3 < (acpFeatureNode3[10097] as global::Motorola.MackinawCPS.CoreFeatures.RadioWide.RxFrequencySplitFPPInnerSection).RadWideLabtoolRxEndFrequencySplit_A9015.Value * 5)
									{
										num = (short)1641021446;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									goto IL_9E0;
								}
								case 4:
									goto IL_A5A;
								case 5:
									if (num3 % 12500 == 0)
									{
										num = (short)400359442;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									break;
								case 6:
									num = (short)1657274370;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 7:
								{
									string value;
									if (!(value == global::CommonResources.AcgResources.ID_P_700M))
									{
										num = (short)1745616897;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									goto IL_846;
								}
								case 8:
									switch (0)
									{
									case 0:
										goto IL_67F;
									}
									continue;
								case 9:
									goto IL_846;
								case 10:
								{
									if (!enumerator.MoveNext())
									{
										num = (short)2121990158;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									global::AcpCommonLib.IAcpFeatureNode acpFeatureNode3 = enumerator.Current;
									num = (short)1789919256;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 11:
									num = (short)2147287052;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 12:
								{
									global::AcpCommonLib.IAcpFeatureNode acpFeatureNode3;
									if (num3 >= (acpFeatureNode3[10097] as global::Motorola.MackinawCPS.CoreFeatures.RadioWide.RxFrequencySplitFPPInnerSection).RadWideLabtoolRxStartFrequencySplit_A9032.Value * 5)
									{
										num = (short)1898905617;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									break;
								}
								case 13:
								{
									global::AcpCommonLib.IAcpFeatureNode acpFeatureNode3;
									string value = (acpFeatureNode3[10097] as global::Motorola.MackinawCPS.CoreFeatures.RadioWide.RxFrequencySplitFPPInnerSection).RadWideLabtoolRxBandSplitName_A24797.Value;
									num = (short)575143943;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 14:
									num = (short)2038890500;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 15:
									goto IL_752;
								case 16:
									goto IL_999;
								case 17:
									num = (short)616824855;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 18:
									result = true;
									num = (short)437256207;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 19:
									result = true;
									num = (short)1812070416;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 20:
								{
									global::AcpCommonLib.IAcpFeatureNode acpFeatureNode3;
									if (num3 > (acpFeatureNode3[10097] as global::Motorola.MackinawCPS.CoreFeatures.RadioWide.RxFrequencySplitFPPInnerSection).RadWideLabtoolRxStartFrequencySplit_A9032.Value * 5)
									{
										num = (short)1645084694;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									goto IL_9E0;
								}
								case 21:
								{
									global::AcpCommonLib.IAcpFeatureNode acpFeatureNode3;
									if ((acpFeatureNode3[10097] as global::Motorola.MackinawCPS.CoreFeatures.RadioWide.RxFrequencySplitFPPInnerSection).RadWideLabtoolRxBandSplitName_A24797.Value == global::CommonResources.AcgResources.ID_P_800M)
									{
										num = (short)1415446539;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									break;
								}
								case 22:
									num = (short)64815107;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 23:
								{
									global::AcpCommonLib.IAcpFeatureNode acpFeatureNode3;
									if (num3 < (acpFeatureNode3[10097] as global::Motorola.MackinawCPS.CoreFeatures.RadioWide.RxFrequencySplitFPPInnerSection).RadWideLabtoolRxEndFrequencySplit_A9015.Value * 5)
									{
										num = (short)1962213401;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									break;
								}
								case 24:
									if (global::ConstraintHelper.UtilityMack.Is7800MHzUsedinCodeplug())
									{
										num = (short)916914189;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									goto IL_9E0;
								case 25:
									num = (short)99155973;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								IL_803:
								num = (short)1981480970;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								IL_67F:
								goto IL_803;
								IL_846:
								num = (short)1226899476;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								IL_9E0:
								num = (short)1029505045;
								num2 = (int)((global::System.IntPtr)num);
							}
							IL_752:
							IL_999:
							return result;
							IL_A5A:
							goto IL_1032;
						}
						finally
						{
							num = (short)785317890;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								switch (num2)
								{
								case 0:
								{
									num = (short)1411068753;
									short num5 = num;
									num = (short)304165713;
									switch ((num5 == num) ? 1 : 0)
									{
									case 0:
									case 2:
										goto IL_A74;
									default:
										num = (short)564264960;
										if (num != 0)
										{
										}
										enumerator.Dispose();
										num = (short)1822425089;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									break;
								}
								case 1:
									goto IL_B1B;
								case 2:
									goto IL_A74;
								}
								goto IL_A91;
								IL_A74:
								switch (0)
								{
								case 0:
									IL_A91:
									if (enumerator == null)
									{
										goto IL_B1D;
									}
									num = (short)1582628864;
									num2 = (int)((global::System.IntPtr)num);
									break;
								}
							}
							IL_B1B:
							IL_B1D:;
						}
						return true;
					case 23:
						enumerator = rxFrequencySplitFPPInnerRecset.GetEnumerator();
						num = (short)1150287879;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					IL_A4:
					global::Motorola.MackinawCPS.CoreFeatures.TrunkingSystem.ControlChannelsInnerSection controlChannelsInnerSection = self as global::Motorola.MackinawCPS.CoreFeatures.TrunkingSystem.ControlChannelsInnerSection;
					global::Motorola.MackinawCPS.CoreFeatures.TrunkingSystem.TrunkingSystem trunkingSystem = self.ParentRecset.ParentSection.Parent as global::Motorola.MackinawCPS.CoreFeatures.TrunkingSystem.TrunkingSystem;
					trkSysGeneralSystemType_A = trunkingSystem.General.TrkSysGeneralSystemType_A9252;
					trkSysGeneralTypeIIFrequencyBand_A = trunkingSystem.General.TrkSysGeneralTypeIIFrequencyBand_A12491;
					global::Motorola.MackinawCPS.CoreFeatures.TrunkingSystem.ChannelRangesMHzInnerRecset channelRangesMHzInnerRecset = self.ParentRecset.ParentSection.Parent[10167].EmbeddedRecset as global::Motorola.MackinawCPS.CoreFeatures.TrunkingSystem.ChannelRangesMHzInnerRecset;
					astro25ChannelIDInnerRecset = (self.ParentRecset.ParentSection.Parent[10160].EmbeddedRecset as global::Motorola.MackinawCPS.CoreFeatures.TrunkingSystem.ASTRO25ChannelIDInnerRecset);
					rxFrequencySplitFPPInnerRecset = ((global::AcpCommonLib.FeatureManager.GetFeature(2045) as global::Motorola.MackinawCPS.CoreFeatures.RadioWide.RadioWideRecset)[0][10096].EmbeddedRecset as global::Motorola.MackinawCPS.CoreFeatures.RadioWide.RxFrequencySplitFPPInnerRecset);
					num3 = controlChannelsInnerSection.TrkSysControlChannelsRxFrequencyMHz_A9018.Value * 5;
					if (controlChannelsInnerSection.RefRadioInformation.FrequencyRanges.RadInfoFrequencyRangesOpenFrequency_A22699.Value)
					{
						num = (short)228065284;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					num = (short)1129119761;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_471:
					num = (short)135266306;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_586:
					num = (short)433913872;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_100D:
					enumerator = channelRangesMHzInnerRecset.GetEnumerator();
					num = (short)1124925446;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_1032:
					num = (short)325058563;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_109D:
					num = (short)2059206670;
					num2 = (int)((global::System.IntPtr)num);
				}
				IL_18C:
				return true;
				IL_4AF:
				num = (short)1547829249;
				if (num != 0)
				{
				}
				return false;
				IL_102D:
				try
				{
					num = (short)446824458;
					num2 = (int)((global::System.IntPtr)num);
					for (;;)
					{
						switch (num2)
						{
						case 0:
						{
							global::System.Collections.Generic.IEnumerator<global::AcpBusinessLayer.FeatureNode> enumerator;
							if (!enumerator.MoveNext())
							{
								num = (short)1328742404;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							global::AcpCommonLib.IAcpFeatureNode acpFeatureNode4 = enumerator.Current;
							num = (short)1511849992;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						case 1:
						{
							int num3;
							global::AcpCommonLib.IAcpFeatureNode acpFeatureNode4;
							if (num3 >= (acpFeatureNode4[10168] as global::Motorola.MackinawCPS.CoreFeatures.TrunkingSystem.ChannelRangesMHzInnerSection).TrkSysOBTChannelAssignmentListRxStartFrequencyMHz_A9029.Value * 5)
							{
								num = (short)174325771;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							break;
						}
						case 2:
							goto IL_13B8;
						case 3:
							num = (short)1358954505;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 4:
							num = (short)1584398338;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 5:
							goto IL_12F9;
						case 6:
							result = true;
							num = (short)852099077;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 7:
							num = (short)135462913;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 8:
						{
							global::AcpCommonLib.IAcpFeatureNode acpFeatureNode4;
							if ((acpFeatureNode4[10168] as global::Motorola.MackinawCPS.CoreFeatures.TrunkingSystem.ChannelRangesMHzInnerSection).TrkSysOBTChannelAssignmentListRxEnable_A9001.Value)
							{
								num = (short)610598919;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							break;
						}
						case 9:
						{
							int num3;
							global::AcpCommonLib.IAcpFeatureNode acpFeatureNode4;
							if ((num3 - (acpFeatureNode4[10168] as global::Motorola.MackinawCPS.CoreFeatures.TrunkingSystem.ChannelRangesMHzInnerSection).TrkSysOBTChannelAssignmentListRxStartFrequencyMHz_A9029.Value * 5) % ((acpFeatureNode4[10168] as global::Motorola.MackinawCPS.CoreFeatures.TrunkingSystem.ChannelRangesMHzInnerSection).TrkSysOBTChannelAssignmentListRxSpacingKHz_A9004.Value * 5) == 0)
							{
								num = (short)1827995654;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							break;
						}
						case 10:
							switch (0)
							{
							case 0:
								goto IL_11BA;
							}
							continue;
						case 11:
							num = (short)296288268;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 12:
						{
							int num3;
							global::AcpCommonLib.IAcpFeatureNode acpFeatureNode4;
							if (num3 <= (acpFeatureNode4[10168] as global::Motorola.MackinawCPS.CoreFeatures.TrunkingSystem.ChannelRangesMHzInnerSection).TrkSysOBTChannelAssignmentListRxEndFrequencyMHz_A9012.Value * 5)
							{
								num = (short)374800387;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							break;
						}
						}
						IL_12FE:
						num = (short)743636992;
						num2 = (int)((global::System.IntPtr)num);
						continue;
						IL_11BA:
						goto IL_12FE;
					}
					IL_12F9:
					return result;
					IL_13B8:
					return false;
				}
				finally
				{
					num = (short)1402404866;
					num2 = (int)((global::System.IntPtr)num);
					for (;;)
					{
						global::System.Collections.Generic.IEnumerator<global::AcpBusinessLayer.FeatureNode> enumerator;
						switch (num2)
						{
						case 0:
							enumerator.Dispose();
							num = (short)800718849;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 1:
							goto IL_1427;
						case 2:
							switch (0)
							{
							case 0:
								goto IL_13EF;
							}
							continue;
						}
						IL_13EF:
						if (enumerator == null)
						{
							break;
						}
						num = (short)1347158016;
						num2 = (int)((global::System.IntPtr)num);
					}
					IL_1427:;
				}
				return result;
			}
			}
		}

		// Token: 0x06000BC7 RID: 3015 RVA: 0x000B4084 File Offset: 0x000B2284
		internal static bool conCCTxFreqApplicability(global::AcpCommonLib.IAcpFeatureSection self)
		{
			short num = (short)505675776;
			int num2 = (int)num;
			switch (num2)
			{
			default:
			{
				switch (0)
				{
				case 0:
					goto IL_62;
				}
				global::Motorola.MackinawCPS.CoreFeatures.TrunkingSystem.ControlChannelsInnerSection controlChannelsInnerSection;
				global::AcpBusinessLayer.AcpListField trkSysGeneralSystemType_A;
				global::AcpBusinessLayer.AcpListField trkSysGeneralTypeIIFrequencyBand_A;
				global::Motorola.MackinawCPS.CoreFeatures.RadioWide.RxFrequencySplitFPPInnerRecset rxFrequencySplitFPPInnerRecset;
				global::System.Collections.Generic.IEnumerator<global::AcpBusinessLayer.FeatureNode> enumerator;
				int num3;
				for (;;)
				{
					IL_27:
					switch (num2)
					{
					case 0:
						num = (short)1241382913;
						if (num != 0)
						{
						}
						num = (short)1319043073;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 1:
						if (!controlChannelsInnerSection.RefRadioInformation.Labtool.RadInfoLabtoolH37G50Smartnet_A8184.Value)
						{
							num = (short)491585543;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_7C8;
					case 2:
						goto IL_7C3;
					case 3:
						num = (short)304021510;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 4:
						num = (short)811335692;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 5:
						if (trkSysGeneralSystemType_A.Value == 2)
						{
							num = (short)389152771;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)1415184393;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 6:
						if (trkSysGeneralTypeIIFrequencyBand_A.Value != 3)
						{
							num = (short)1294598148;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_132;
					case 7:
						return false;
					case 8:
						enumerator = rxFrequencySplitFPPInnerRecset.GetEnumerator();
						num = (short)1038483466;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 9:
						if (trkSysGeneralSystemType_A.Value == 3)
						{
							num = (short)392429576;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return true;
					case 10:
						goto IL_12D;
					case 11:
						if (!controlChannelsInnerSection.RefRadioInformation.Labtool.RadInfoLabtoolH38G51Smartzone_A8185.Value)
						{
							num = (short)695336960;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_7C8;
					case 12:
						if (trkSysGeneralTypeIIFrequencyBand_A.Value == 4)
						{
							num = (short)1270874114;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return true;
					}
					goto IL_62;
					IL_7C8:
					num3 = controlChannelsInnerSection.TrkSysControlChannelsRxFrequencyMHz_A9018.Value * 5;
					num = (short)1744633861;
					num2 = (int)((global::System.IntPtr)num);
				}
				IL_12D:
				try
				{
					num = (short)1125974041;
					num2 = (int)((global::System.IntPtr)num);
					bool result;
					for (;;)
					{
						switch (num2)
						{
						case 0:
						{
							global::AcpCommonLib.IAcpFeatureNode acpFeatureNode;
							if (num3 < (acpFeatureNode[10097] as global::Motorola.MackinawCPS.CoreFeatures.RadioWide.RxFrequencySplitFPPInnerSection).RadWideLabtoolRxEndFrequencySplit_A9015.Value * 5)
							{
								num = (short)1870004234;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							goto IL_648;
						}
						case 1:
						{
							global::AcpCommonLib.IAcpFeatureNode acpFeatureNode;
							if ((acpFeatureNode[10097] as global::Motorola.MackinawCPS.CoreFeatures.RadioWide.RxFrequencySplitFPPInnerSection).RadWideLabtoolRxBandSplitName_A24797.Value == global::CommonResources.AcgResources.ID_P_900M)
							{
								num = (short)594673667;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							break;
						}
						case 2:
						{
							global::AcpCommonLib.IAcpFeatureNode acpFeatureNode;
							if (num3 >= (acpFeatureNode[10097] as global::Motorola.MackinawCPS.CoreFeatures.RadioWide.RxFrequencySplitFPPInnerSection).RadWideLabtoolRxStartFrequencySplit_A9032.Value * 5)
							{
								num = (short)1680670740;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							goto IL_648;
						}
						case 3:
							num = (short)964755474;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 4:
						{
							global::AcpCommonLib.IAcpFeatureNode acpFeatureNode;
							if ((acpFeatureNode[10097] as global::Motorola.MackinawCPS.CoreFeatures.RadioWide.RxFrequencySplitFPPInnerSection).RadWideLabtoolRxBandSplitName_A24797.Value == global::CommonResources.AcgResources.ID_P_700M_1)
							{
								num = (short)1852309509;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							goto IL_3DF;
						}
						case 5:
							goto IL_386;
						case 6:
							num = (short)1643773976;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 7:
							result = false;
							num = (short)214695952;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 8:
							goto IL_6C2;
						case 9:
							num = (short)1720188949;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 10:
							result = false;
							num = (short)970653708;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 11:
							num = (short)925958146;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 12:
							goto IL_549;
						case 13:
						{
							global::AcpCommonLib.IAcpFeatureNode acpFeatureNode;
							if (!((acpFeatureNode[10097] as global::Motorola.MackinawCPS.CoreFeatures.RadioWide.RxFrequencySplitFPPInnerSection).RadWideLabtoolRxBandSplitName_A24797.Value == global::CommonResources.AcgResources.ID_P_700M))
							{
								num = (short)2095448079;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							goto IL_386;
						}
						case 14:
						{
							global::AcpCommonLib.IAcpFeatureNode acpFeatureNode;
							if ((acpFeatureNode[10097] as global::Motorola.MackinawCPS.CoreFeatures.RadioWide.RxFrequencySplitFPPInnerSection).RadWideLabtoolRxBandSplitName_A24797.Value == global::CommonResources.AcgResources.ID_P_800M)
							{
								num = (short)11010059;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							goto IL_648;
						}
						case 15:
							num = (short)1245315076;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 16:
							goto IL_5C3;
						case 17:
						{
							if (!enumerator.MoveNext())
							{
								num = (short)484442138;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							global::AcpCommonLib.IAcpFeatureNode acpFeatureNode = enumerator.Current;
							num = (short)1795424269;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						case 18:
						{
							global::AcpCommonLib.IAcpFeatureNode acpFeatureNode;
							if (num3 > (acpFeatureNode[10097] as global::Motorola.MackinawCPS.CoreFeatures.RadioWide.RxFrequencySplitFPPInnerSection).RadWideLabtoolRxStartFrequencySplit_A9032.Value * 5)
							{
								num = (short)1136984073;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							break;
						}
						case 19:
							result = false;
							num = (short)1818034199;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 20:
							num = (short)3211264;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 21:
						{
							global::AcpCommonLib.IAcpFeatureNode acpFeatureNode;
							if (num3 < (acpFeatureNode[10097] as global::Motorola.MackinawCPS.CoreFeatures.RadioWide.RxFrequencySplitFPPInnerSection).RadWideLabtoolRxEndFrequencySplit_A9015.Value * 5)
							{
								num = (short)1588789267;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							break;
						}
						case 22:
						{
							global::AcpCommonLib.IAcpFeatureNode acpFeatureNode;
							if (num3 > (acpFeatureNode[10097] as global::Motorola.MackinawCPS.CoreFeatures.RadioWide.RxFrequencySplitFPPInnerSection).RadWideLabtoolRxStartFrequencySplit_A9032.Value * 5)
							{
								num = (short)361693190;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							goto IL_3DF;
						}
						case 23:
							goto IL_643;
						case 24:
						{
							global::AcpCommonLib.IAcpFeatureNode acpFeatureNode;
							if (num3 < (acpFeatureNode[10097] as global::Motorola.MackinawCPS.CoreFeatures.RadioWide.RxFrequencySplitFPPInnerSection).RadWideLabtoolRxEndFrequencySplit_A9015.Value * 5)
							{
								num = (short)1666842631;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							goto IL_3DF;
						}
						case 25:
							switch (0)
							{
							case 0:
								goto IL_267;
							}
							continue;
						case 26:
							num = (short)225705992;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_267;
						IL_386:
						num = (short)1072627734;
						num2 = (int)((global::System.IntPtr)num);
						continue;
						IL_3DF:
						num = (short)1416626190;
						num2 = (int)((global::System.IntPtr)num);
						continue;
						IL_43F:
						num = (short)917241873;
						num2 = (int)((global::System.IntPtr)num);
						continue;
						IL_267:
						goto IL_43F;
						IL_648:
						num = (short)1360265217;
						num2 = (int)((global::System.IntPtr)num);
					}
					IL_549:
					IL_5C3:
					IL_643:
					return result;
					IL_6C2:;
				}
				finally
				{
					num = (short)1588264961;
					num2 = (int)((global::System.IntPtr)num);
					for (;;)
					{
						switch (num2)
						{
						case 0:
							goto IL_780;
						case 1:
							switch (0)
							{
							case 0:
								goto IL_6F9;
							}
							continue;
						case 2:
							goto IL_75E;
						}
						IL_6F9:
						num = (short)1572221448;
						short num4 = num;
						num = (short)1367814664;
						switch ((num4 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							IL_75E:
							enumerator.Dispose();
							num = (short)1763901440;
							num2 = (int)((global::System.IntPtr)num);
							break;
						default:
							num = (short)1161297920;
							if (num != 0)
							{
							}
							if (enumerator == null)
							{
								goto IL_782;
							}
							num = (short)507117570;
							num2 = (int)((global::System.IntPtr)num);
							break;
						}
					}
					IL_780:
					IL_782:;
				}
				return true;
				IL_132:
				num = (short)37093376;
				short num5 = num;
				return false;
				IL_7C3:
				goto IL_132;
				IL_62:
				controlChannelsInnerSection = (self as global::Motorola.MackinawCPS.CoreFeatures.TrunkingSystem.ControlChannelsInnerSection);
				global::Motorola.MackinawCPS.CoreFeatures.TrunkingSystem.TrunkingSystem trunkingSystem = self.ParentRecset.ParentSection.Parent as global::Motorola.MackinawCPS.CoreFeatures.TrunkingSystem.TrunkingSystem;
				trkSysGeneralSystemType_A = trunkingSystem.General.TrkSysGeneralSystemType_A9252;
				trkSysGeneralTypeIIFrequencyBand_A = trunkingSystem.General.TrkSysGeneralTypeIIFrequencyBand_A12491;
				rxFrequencySplitFPPInnerRecset = ((global::AcpCommonLib.FeatureManager.GetFeature(2045) as global::Motorola.MackinawCPS.CoreFeatures.RadioWide.RadioWideRecset)[0][10096].EmbeddedRecset as global::Motorola.MackinawCPS.CoreFeatures.RadioWide.RxFrequencySplitFPPInnerRecset);
				num = (short)110428171;
				num2 = (int)((global::System.IntPtr)num);
				goto IL_27;
			}
			}
		}

		// Token: 0x06000BC8 RID: 3016 RVA: 0x000B494C File Offset: 0x000B2B4C
		internal static bool conControlChannelTxFreqValidity(global::AcpCommonLib.IAcpFeatureSection self)
		{
			short num = (short)1636958208;
			switch (num)
			{
			default:
			{
				num = (short)292618263;
				int num2 = (int)((global::System.IntPtr)num);
				for (;;)
				{
					global::AcpBusinessLayer.AcpListField trkSysGeneralTypeIIFrequencyBand_A;
					int inputRxFrequency;
					int num3;
					global::Motorola.MackinawCPS.CoreFeatures.RadioWide.TxFrequencySplitFPPInnerRecset txFrequencySplitFPPInnerRecset;
					global::System.Collections.Generic.IEnumerator<global::AcpBusinessLayer.FeatureNode> enumerator;
					global::AcpBusinessLayer.AcpListField trkSysGeneralSystemType_A;
					global::AcpBusinessLayer.AcpFrequencyField trkSysControlChannelsRxFrequencyMHz_A;
					switch (num2)
					{
					case 0:
						if (trkSysGeneralTypeIIFrequencyBand_A.Value == 4)
						{
							num = (short)595263505;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_171E;
					case 1:
						if (global::ConstraintHelper.UtilityMack.IsTxFrquencyBandValidOn7800And900ForAstro25(inputRxFrequency, num3))
						{
							num = (short)848494611;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						enumerator = txFrequencySplitFPPInnerRecset.GetEnumerator();
						num = (short)509476884;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 2:
						if (!global::ConstraintHelper.UtilityMack.IsTxFrequencyBandEnabled(num3))
						{
							num = (short)1274675204;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_135F;
					case 3:
						num = (short)296419338;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 4:
						return false;
					case 5:
						if (trkSysGeneralTypeIIFrequencyBand_A.Value == 3)
						{
							num = (short)938868758;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_E84;
					case 6:
						return true;
					case 7:
						if (trkSysGeneralSystemType_A.Value == 3)
						{
							num = (short)1128529932;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return false;
					case 8:
						if (trkSysGeneralSystemType_A.Value == 2)
						{
							num = (short)916520969;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)1154154503;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 9:
						num = (short)925761541;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 10:
						if (trkSysGeneralTypeIIFrequencyBand_A.Value != 1)
						{
							num = (short)1749614592;
							short num4 = num;
							num = (short)2085421071;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_16B7;
					case 11:
						goto IL_16B5;
					case 12:
						num = (short)303955969;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 13:
						goto IL_16B7;
					case 14:
						goto IL_16D7;
					case 15:
						num = (short)615186450;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 16:
						if (num3 == trkSysControlChannelsRxFrequencyMHz_A.Value * 5 - 39000000)
						{
							num = (short)392232971;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_171E;
					case 17:
						num = (short)1788018704;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 18:
						if (trkSysGeneralTypeIIFrequencyBand_A.Value == 2)
						{
							num = (short)1041170445;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return false;
					case 19:
						goto IL_179E;
					case 20:
						goto IL_24C;
					case 21:
						if (trkSysGeneralTypeIIFrequencyBand_A.Value != 0)
						{
							num = (short)777191427;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_16B7;
					case 22:
						enumerator = txFrequencySplitFPPInnerRecset.GetEnumerator();
						num = (short)448921624;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 23:
						switch (0)
						{
						case 0:
							goto IL_A7;
						}
						continue;
					case 24:
						try
						{
							num = (short)713359370;
							num2 = (int)((global::System.IntPtr)num);
							bool result;
							for (;;)
							{
								switch (num2)
								{
								case 0:
								{
									global::AcpCommonLib.IAcpFeatureNode acpFeatureNode;
									if (num3 < (acpFeatureNode[10095] as global::Motorola.MackinawCPS.CoreFeatures.RadioWide.TxFrequencySplitFPPInnerSection).RadWideLabtoolTxEndFrequencySplit_A9532.Value * 5)
									{
										num = (short)1601241111;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									goto IL_F53;
								}
								case 1:
									goto IL_1071;
								case 2:
								{
									if (!enumerator.MoveNext())
									{
										num = (short)552075275;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									global::AcpCommonLib.IAcpFeatureNode acpFeatureNode = enumerator.Current;
									num = (short)485031953;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 3:
									goto IL_12ED;
								case 4:
								{
									global::AcpCommonLib.IAcpFeatureNode acpFeatureNode;
									if (num3 < (acpFeatureNode[10095] as global::Motorola.MackinawCPS.CoreFeatures.RadioWide.TxFrequencySplitFPPInnerSection).RadWideLabtoolTxEndFrequencySplit_A9532.Value * 5)
									{
										num = (short)1707868182;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									break;
								}
								case 5:
									if (num3 == trkSysControlChannelsRxFrequencyMHz_A.Value * 5 + 30000000)
									{
										num = (short)1850277908;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									goto IL_F53;
								case 6:
								{
									global::AcpCommonLib.IAcpFeatureNode acpFeatureNode;
									if ((acpFeatureNode[10095] as global::Motorola.MackinawCPS.CoreFeatures.RadioWide.TxFrequencySplitFPPInnerSection).RadWideLabtoolTxBandSplitName_A24799.Value == global::CommonResources.AcgResources.ID_P_700M_2)
									{
										num = (short)48627728;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									goto IL_F53;
								}
								case 7:
									num = (short)1784152070;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 8:
									result = true;
									num = (short)385810447;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 9:
									if (num3 == trkSysControlChannelsRxFrequencyMHz_A.Value * 5 - 45000000)
									{
										num = (short)1630142472;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									break;
								case 10:
									switch (0)
									{
									case 0:
										goto IL_F4E;
									}
									continue;
								case 11:
									num = (short)1946943491;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 12:
								{
									global::AcpCommonLib.IAcpFeatureNode acpFeatureNode;
									if (num3 > (acpFeatureNode[10095] as global::Motorola.MackinawCPS.CoreFeatures.RadioWide.TxFrequencySplitFPPInnerSection).RadWideLabtoolTxStartFrequencySplit_A9571.Value * 5)
									{
										num = (short)1401094162;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									goto IL_F53;
								}
								case 13:
								{
									global::AcpCommonLib.IAcpFeatureNode acpFeatureNode;
									if (num3 >= (acpFeatureNode[10095] as global::Motorola.MackinawCPS.CoreFeatures.RadioWide.TxFrequencySplitFPPInnerSection).RadWideLabtoolTxStartFrequencySplit_A9571.Value * 5)
									{
										num = (short)1438646293;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									break;
								}
								case 14:
									num = (short)1150943245;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 15:
									goto IL_1225;
								case 16:
									num = (short)2109669388;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 17:
									if (global::ConstraintHelper.UtilityMack.Is7800MHzUsedinCodeplug())
									{
										num = (short)462684167;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									goto IL_F53;
								case 18:
									num = (short)1065943040;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 19:
								{
									global::AcpCommonLib.IAcpFeatureNode acpFeatureNode;
									if ((acpFeatureNode[10095] as global::Motorola.MackinawCPS.CoreFeatures.RadioWide.TxFrequencySplitFPPInnerSection).RadWideLabtoolTxBandSplitName_A24799.Value == global::CommonResources.AcgResources.ID_P_800M_1)
									{
										num = (short)1684996110;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									break;
								}
								case 20:
									result = true;
									num = (short)332267521;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 21:
									num = (short)1779040260;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 22:
									num = (short)1934426121;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 23:
									num = (short)352780293;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								goto IL_F4E;
								IL_F53:
								num = (short)638582803;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								IL_10CD:
								num = (short)702414850;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								IL_F4E:
								goto IL_10CD;
							}
							IL_1071:
							IL_1225:
							return result;
							IL_12ED:
							goto IL_E84;
						}
						finally
						{
							num = (short)246153217;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								switch (num2)
								{
								case 0:
									goto IL_135C;
								case 1:
									switch (0)
									{
									case 0:
										goto IL_1324;
									}
									continue;
								case 2:
									enumerator.Dispose();
									num = (short)1374617600;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								IL_1324:
								if (enumerator == null)
								{
									break;
								}
								num = (short)1304428546;
								num2 = (int)((global::System.IntPtr)num);
							}
							IL_135C:;
						}
						goto IL_135F;
					}
					IL_A7:
					global::Motorola.MackinawCPS.CoreFeatures.TrunkingSystem.ControlChannelsInnerSection controlChannelsInnerSection = self as global::Motorola.MackinawCPS.CoreFeatures.TrunkingSystem.ControlChannelsInnerSection;
					global::Motorola.MackinawCPS.CoreFeatures.TrunkingSystem.TrunkingSystem trunkingSystem = self.ParentRecset.ParentSection.Parent as global::Motorola.MackinawCPS.CoreFeatures.TrunkingSystem.TrunkingSystem;
					trkSysGeneralSystemType_A = trunkingSystem.General.TrkSysGeneralSystemType_A9252;
					trkSysGeneralTypeIIFrequencyBand_A = trunkingSystem.General.TrkSysGeneralTypeIIFrequencyBand_A12491;
					trkSysControlChannelsRxFrequencyMHz_A = controlChannelsInnerSection.TrkSysControlChannelsRxFrequencyMHz_A9018;
					global::Motorola.MackinawCPS.CoreFeatures.TrunkingSystem.ChannelRangesMHzInnerRecset channelRangesMHzInnerRecset = self.ParentRecset.ParentSection.Parent[10167].EmbeddedRecset as global::Motorola.MackinawCPS.CoreFeatures.TrunkingSystem.ChannelRangesMHzInnerRecset;
					global::Motorola.MackinawCPS.CoreFeatures.TrunkingSystem.ASTRO25ChannelIDInnerRecset astro25ChannelIDInnerRecset = self.ParentRecset.ParentSection.Parent[10160].EmbeddedRecset as global::Motorola.MackinawCPS.CoreFeatures.TrunkingSystem.ASTRO25ChannelIDInnerRecset;
					txFrequencySplitFPPInnerRecset = ((global::AcpCommonLib.FeatureManager.GetFeature(2045) as global::Motorola.MackinawCPS.CoreFeatures.RadioWide.RadioWideRecset)[0][10094].EmbeddedRecset as global::Motorola.MackinawCPS.CoreFeatures.RadioWide.TxFrequencySplitFPPInnerRecset);
					num3 = controlChannelsInnerSection.TrkSysControlChannelsTxFrequencyMHz_A9535.Value * 5;
					inputRxFrequency = trkSysControlChannelsRxFrequencyMHz_A.Value * 5;
					if (controlChannelsInnerSection.RefRadioInformation.FrequencyRanges.RadInfoFrequencyRangesOpenFrequency_A22699.Value)
					{
						num = (short)2025717766;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					num = (short)1089667074;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_E84:
					num = (short)38928384;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_135F:
					num = (short)300351496;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_16B7:
					enumerator = channelRangesMHzInnerRecset.GetEnumerator();
					num = (short)979238926;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_171E:
					num = (short)1838678037;
					num2 = (int)((global::System.IntPtr)num);
				}
				return true;
				IL_24C:
				try
				{
					num = (short)1742667786;
					num2 = (int)((global::System.IntPtr)num);
					for (;;)
					{
						global::System.Collections.Generic.IEnumerator<global::AcpBusinessLayer.FeatureNode> enumerator;
						global::AcpCommonLib.IAcpFeatureNode acpFeatureNode2;
						switch (num2)
						{
						case 0:
							num = (short)406061057;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 1:
							goto IL_DC2;
						case 2:
							num = (short)2142502918;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 3:
						{
							int num3;
							if (num3 >= (acpFeatureNode2[10095] as global::Motorola.MackinawCPS.CoreFeatures.RadioWide.TxFrequencySplitFPPInnerSection).RadWideLabtoolTxStartFrequencySplit_A9571.Value * 5)
							{
								num = (short)1063190542;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							break;
						}
						case 4:
						{
							int num3;
							if (num3 <= (acpFeatureNode2[10095] as global::Motorola.MackinawCPS.CoreFeatures.RadioWide.TxFrequencySplitFPPInnerSection).RadWideLabtoolTxEndFrequencySplit_A9532.Value * 5)
							{
								num = (short)905379847;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							break;
						}
						case 5:
							if ((acpFeatureNode2[10095] as global::Motorola.MackinawCPS.CoreFeatures.RadioWide.TxFrequencySplitFPPInnerSection).RadWideLabtoolTxBandSplitName_A24799.Value == global::CommonResources.AcgResources.ID_UHF2)
							{
								num = (short)2040266763;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							break;
						case 6:
							if (!((acpFeatureNode2[10095] as global::Motorola.MackinawCPS.CoreFeatures.RadioWide.TxFrequencySplitFPPInnerSection).RadWideLabtoolTxBandSplitName_A24799.Value == global::CommonResources.AcgResources.ID_UHF1))
							{
								num = (short)1911685133;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							goto IL_3EA;
						case 7:
						{
							global::Motorola.MackinawCPS.CoreFeatures.TrunkingSystem.ASTRO25ChannelIDInnerRecset astro25ChannelIDInnerRecset;
							global::System.Collections.Generic.IEnumerator<global::AcpBusinessLayer.FeatureNode> enumerator2 = astro25ChannelIDInnerRecset.GetEnumerator();
							num = (short)706412556;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						case 8:
							if (!enumerator.MoveNext())
							{
								num = (short)1853292544;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							goto IL_C82;
						case 9:
							if (!((acpFeatureNode2[10095] as global::Motorola.MackinawCPS.CoreFeatures.RadioWide.TxFrequencySplitFPPInnerSection).RadWideLabtoolTxBandSplitName_A24799.Value == global::CommonResources.AcgResources.ID_VHF))
							{
								num = (short)1009385474;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							goto IL_3EA;
						case 10:
							switch (0)
							{
							case 0:
								goto IL_38B;
							}
							continue;
						case 11:
							goto IL_3EA;
						case 12:
							try
							{
								num = (short)1246101517;
								num2 = (int)((global::System.IntPtr)num);
								bool result;
								for (;;)
								{
									global::AcpCommonLib.IAcpFeatureNode acpFeatureNode3;
									int num5;
									switch (num2)
									{
									case 0:
									{
										int num3;
										if ((num3 - (acpFeatureNode3[10161] as global::Motorola.MackinawCPS.CoreFeatures.TrunkingSystem.ASTRO25ChannelIDInnerSection).TrkSysASTRO25ChannelIDBaseFrequencyMHz_A7546.Value * 5) % ((acpFeatureNode3[10161] as global::Motorola.MackinawCPS.CoreFeatures.TrunkingSystem.ASTRO25ChannelIDInnerSection).TrkSysASTRO25ChannelIDChannelSpacingkHz_A7660.Value * 5) == 0)
										{
											num = (short)1381236773;
											num2 = (int)((global::System.IntPtr)num);
											continue;
										}
										goto IL_A97;
									}
									case 1:
										goto IL_6A1;
									case 2:
									{
										int num3;
										if (num3 >= num5)
										{
											num = (short)1223294985;
											num2 = (int)((global::System.IntPtr)num);
											continue;
										}
										break;
									}
									case 3:
									{
										int num3;
										if (num3 <= num5 + (acpFeatureNode3[10161] as global::Motorola.MackinawCPS.CoreFeatures.TrunkingSystem.ASTRO25ChannelIDInnerSection).TrkSysASTRO25ChannelIDChannelSpacingkHz_A7660.Value * 5 * 4095)
										{
											num = (short)363593736;
											num2 = (int)((global::System.IntPtr)num);
											continue;
										}
										break;
									}
									case 4:
									{
										int num3;
										if (num3 <= (acpFeatureNode3[10161] as global::Motorola.MackinawCPS.CoreFeatures.TrunkingSystem.ASTRO25ChannelIDInnerSection).TrkSysASTRO25ChannelIDBaseFrequencyMHz_A7546.Value * 5 + (acpFeatureNode3[10161] as global::Motorola.MackinawCPS.CoreFeatures.TrunkingSystem.ASTRO25ChannelIDInnerSection).TrkSysASTRO25ChannelIDChannelSpacingkHz_A7660.Value * 5 * 4095)
										{
											num = (short)627048462;
											num2 = (int)((global::System.IntPtr)num);
											continue;
										}
										goto IL_A97;
									}
									case 5:
										goto IL_B9D;
									case 6:
										num = (short)723976194;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									case 7:
									{
										int num3;
										if (num3 >= (acpFeatureNode3[10161] as global::Motorola.MackinawCPS.CoreFeatures.TrunkingSystem.ASTRO25ChannelIDInnerSection).TrkSysASTRO25ChannelIDBaseFrequencyMHz_A7546.Value * 5)
										{
											num = (short)70975524;
											num2 = (int)((global::System.IntPtr)num);
											continue;
										}
										goto IL_A97;
									}
									case 8:
										result = true;
										num = (short)1979252737;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									case 9:
										num = (short)665845792;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									case 10:
										goto IL_906;
									case 11:
										if ((acpFeatureNode3[10161] as global::Motorola.MackinawCPS.CoreFeatures.TrunkingSystem.ASTRO25ChannelIDInnerSection).TrkSysASTRO25ChannelIDTransmitOffsetSign_A9417.Value == 1)
										{
											num = (short)1178796049;
											num2 = (int)((global::System.IntPtr)num);
											continue;
										}
										num5 -= (acpFeatureNode3[10161] as global::Motorola.MackinawCPS.CoreFeatures.TrunkingSystem.ASTRO25ChannelIDInnerSection).TrkSysASTRO25ChannelIDTransmitOffsetMHz_A9416.Value * 5;
										num = (short)1600913424;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									case 12:
										if ((acpFeatureNode3[10161] as global::Motorola.MackinawCPS.CoreFeatures.TrunkingSystem.ASTRO25ChannelIDInnerSection).TrkSysASTRO25ChannelIDChannelSpacingkHz_A7660.Value != 0)
										{
											num = (short)1835991062;
											num2 = (int)((global::System.IntPtr)num);
											continue;
										}
										num = (short)587005982;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									case 13:
										switch (0)
										{
										case 0:
											goto IL_562;
										}
										continue;
									case 14:
										result = true;
										num = (short)200278026;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									case 15:
									{
										int num3;
										if (num3 <= (acpFeatureNode3[10161] as global::Motorola.MackinawCPS.CoreFeatures.TrunkingSystem.ASTRO25ChannelIDInnerSection).TrkSysASTRO25ChannelIDBaseFrequencyMHz_A7546.Value * 5 + (acpFeatureNode3[10161] as global::Motorola.MackinawCPS.CoreFeatures.TrunkingSystem.ASTRO25ChannelIDInnerSection).TrkSysASTRO25ChannelIDChannelSpacingkHz_A7660.Value * 5 * 4095)
										{
											num = (short)669909020;
											num2 = (int)((global::System.IntPtr)num);
											continue;
										}
										goto IL_A97;
									}
									case 16:
										goto IL_B9D;
									case 17:
										num5 += (acpFeatureNode3[10161] as global::Motorola.MackinawCPS.CoreFeatures.TrunkingSystem.ASTRO25ChannelIDInnerSection).TrkSysASTRO25ChannelIDTransmitOffsetMHz_A9416.Value * 5;
										num = (short)929234949;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									case 18:
										goto IL_C0F;
									case 19:
										result = true;
										num = (short)1781858339;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									case 20:
										goto IL_A53;
									case 21:
									{
										int num3;
										if ((num3 - num5) % ((acpFeatureNode3[10161] as global::Motorola.MackinawCPS.CoreFeatures.TrunkingSystem.ASTRO25ChannelIDInnerSection).TrkSysASTRO25ChannelIDChannelSpacingkHz_A7660.Value * 5) == 0)
										{
											num = (short)1846214675;
											num2 = (int)((global::System.IntPtr)num);
											continue;
										}
										break;
									}
									case 22:
										num = (short)815071239;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									case 23:
										num = (short)137363460;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									case 24:
									{
										int num3;
										if (num3 >= num5)
										{
											num = (short)2075394081;
											num2 = (int)((global::System.IntPtr)num);
											continue;
										}
										break;
									}
									case 25:
										if ((acpFeatureNode3[10161] as global::Motorola.MackinawCPS.CoreFeatures.TrunkingSystem.ASTRO25ChannelIDInnerSection).TrkSysASTRO25ChannelIDChannelSpacingkHz_A7660.Value != 0)
										{
											num = (short)485097478;
											num2 = (int)((global::System.IntPtr)num);
											continue;
										}
										num = (short)730398744;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									case 26:
									{
										global::System.Collections.Generic.IEnumerator<global::AcpBusinessLayer.FeatureNode> enumerator2;
										if (!enumerator2.MoveNext())
										{
											num = (short)1807220767;
											num2 = (int)((global::System.IntPtr)num);
											continue;
										}
										acpFeatureNode3 = enumerator2.Current;
										num = (short)1324089371;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									case 27:
										if (!(acpFeatureNode3[10161] as global::Motorola.MackinawCPS.CoreFeatures.TrunkingSystem.ASTRO25ChannelIDInnerSection).TrkSysASTRO25ChannelIDIdentifierEnable_A8222.Value)
										{
											num = (short)280690722;
											num2 = (int)((global::System.IntPtr)num);
											continue;
										}
										break;
									case 28:
										num = (short)1720909824;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									case 29:
										num = (short)320208917;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									case 30:
									{
										int num3;
										if (num3 >= (acpFeatureNode3[10161] as global::Motorola.MackinawCPS.CoreFeatures.TrunkingSystem.ASTRO25ChannelIDInnerSection).TrkSysASTRO25ChannelIDBaseFrequencyMHz_A7546.Value * 5)
										{
											num = (short)1455226903;
											num2 = (int)((global::System.IntPtr)num);
											continue;
										}
										goto IL_A97;
									}
									case 31:
										num = (short)531103762;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									case 32:
									{
										int num3;
										if (num3 <= num5 + (acpFeatureNode3[10161] as global::Motorola.MackinawCPS.CoreFeatures.TrunkingSystem.ASTRO25ChannelIDInnerSection).TrkSysASTRO25ChannelIDChannelSpacingkHz_A7660.Value * 5 * 4095)
										{
											num = (short)128122909;
											num2 = (int)((global::System.IntPtr)num);
											continue;
										}
										break;
									}
									case 33:
										num = (short)58261507;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									case 34:
										num = (short)895090700;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									case 35:
										goto IL_9ED;
									case 36:
										num = (short)776863759;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									case 37:
										result = true;
										num = (short)987693076;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									IL_9F2:
									num = (short)389021722;
									num2 = (int)((global::System.IntPtr)num);
									continue;
									IL_562:
									goto IL_9F2;
									IL_A97:
									num5 = (acpFeatureNode3[10161] as global::Motorola.MackinawCPS.CoreFeatures.TrunkingSystem.ASTRO25ChannelIDInnerSection).TrkSysASTRO25ChannelIDBaseFrequencyMHz_A7546.Value * 5;
									num = (short)1869021195;
									num2 = (int)((global::System.IntPtr)num);
									continue;
									IL_B9D:
									num = (short)738787353;
									num2 = (int)((global::System.IntPtr)num);
								}
								IL_6A1:
								IL_906:
								IL_9ED:
								IL_A53:
								return result;
								IL_C0F:
								break;
							}
							finally
							{
								num = (short)1581514754;
								num2 = (int)((global::System.IntPtr)num);
								for (;;)
								{
									global::System.Collections.Generic.IEnumerator<global::AcpBusinessLayer.FeatureNode> enumerator2;
									switch (num2)
									{
									case 0:
										enumerator2.Dispose();
										num = (short)811270145;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									case 1:
										goto IL_C7F;
									case 2:
										switch (0)
										{
										case 0:
											goto IL_C46;
										}
										continue;
									}
									IL_C46:
									if (enumerator2 == null)
									{
										break;
									}
									num = (short)47054848;
									num2 = (int)((global::System.IntPtr)num);
								}
								IL_C7F:;
							}
							goto IL_C82;
						case 13:
							num = (short)1459748869;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 14:
							num = (short)72417284;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_38B;
						IL_3EA:
						num = (short)1699676163;
						num2 = (int)((global::System.IntPtr)num);
						continue;
						IL_C82:
						acpFeatureNode2 = enumerator.Current;
						num = (short)487587849;
						num2 = (int)((global::System.IntPtr)num);
						continue;
						IL_D69:
						num = (short)224657416;
						num2 = (int)((global::System.IntPtr)num);
						continue;
						IL_38B:
						goto IL_D69;
					}
					IL_DC2:;
				}
				finally
				{
					num = (short)141295618;
					num2 = (int)((global::System.IntPtr)num);
					for (;;)
					{
						num = (short)1058685195;
						short num6 = num;
						num = (short)189219083;
						global::System.Collections.Generic.IEnumerator<global::AcpBusinessLayer.FeatureNode> enumerator;
						switch ((num6 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							break;
						default:
							num = (short)89194496;
							if (num != 0)
							{
							}
							switch (num2)
							{
							case 0:
								goto IL_E5E;
							case 1:
								goto IL_E7F;
							case 2:
								switch (0)
								{
								case 0:
									goto IL_E44;
								}
								continue;
							}
							IL_E44:
							if (enumerator != null)
							{
								num = (short)1629487104;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							goto IL_E81;
						}
						IL_E5E:
						enumerator.Dispose();
						num = (short)182910977;
						num2 = (int)((global::System.IntPtr)num);
					}
					IL_E7F:
					IL_E81:;
				}
				return false;
				IL_16B5:
				return true;
				IL_16D7:
				try
				{
					num = (short)1716125702;
					num2 = (int)((global::System.IntPtr)num);
					bool result;
					for (;;)
					{
						switch (num2)
						{
						case 0:
						{
							int num3;
							global::AcpCommonLib.IAcpFeatureNode acpFeatureNode4;
							if ((num3 - (acpFeatureNode4[10168] as global::Motorola.MackinawCPS.CoreFeatures.TrunkingSystem.ChannelRangesMHzInnerSection).TrkSysOBTChannelAssignmentListTxStartFrequencyMHz_A9568.Value * 5) % ((acpFeatureNode4[10168] as global::Motorola.MackinawCPS.CoreFeatures.TrunkingSystem.ChannelRangesMHzInnerSection).TrkSysOBTChannelAssignmentListTxSpacingKHz_A9520.Value * 5) == 0)
							{
								num = (short)239861772;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							break;
						}
						case 1:
						{
							int num3;
							global::AcpCommonLib.IAcpFeatureNode acpFeatureNode4;
							if (num3 >= (acpFeatureNode4[10168] as global::Motorola.MackinawCPS.CoreFeatures.TrunkingSystem.ChannelRangesMHzInnerSection).TrkSysOBTChannelAssignmentListTxStartFrequencyMHz_A9568.Value * 5)
							{
								num = (short)1630535684;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							break;
						}
						case 2:
							goto IL_15F9;
						case 3:
						{
							global::System.Collections.Generic.IEnumerator<global::AcpBusinessLayer.FeatureNode> enumerator;
							if (!enumerator.MoveNext())
							{
								num = (short)1024983045;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							global::AcpCommonLib.IAcpFeatureNode acpFeatureNode4 = enumerator.Current;
							num = (short)1760100363;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						case 4:
							num = (short)627507207;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 5:
							num = (short)561643522;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 6:
							switch (0)
							{
							case 0:
								goto IL_13FE;
							}
							continue;
						case 7:
						{
							int num3;
							global::AcpCommonLib.IAcpFeatureNode acpFeatureNode4;
							if (num3 <= (acpFeatureNode4[10168] as global::Motorola.MackinawCPS.CoreFeatures.TrunkingSystem.ChannelRangesMHzInnerSection).TrkSysOBTChannelAssignmentListTxEndFrequencyMHz_A9529.Value * 5)
							{
								num = (short)1344602121;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							break;
						}
						case 8:
							num = (short)1951727617;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 9:
							num = (short)961282048;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 10:
							goto IL_159C;
						case 11:
						{
							global::AcpCommonLib.IAcpFeatureNode acpFeatureNode4;
							if ((acpFeatureNode4[10168] as global::Motorola.MackinawCPS.CoreFeatures.TrunkingSystem.ChannelRangesMHzInnerSection).TrkSysOBTChannelAssignmentListTxEnable_A9517.Value)
							{
								num = (short)487522312;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							break;
						}
						case 12:
							result = true;
							num = (short)813367306;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						IL_15A1:
						num = (short)230752259;
						num2 = (int)((global::System.IntPtr)num);
						continue;
						IL_13FE:
						goto IL_15A1;
					}
					IL_159C:
					return result;
					IL_15F9:
					return false;
				}
				finally
				{
					num = (short)1462501377;
					num2 = (int)((global::System.IntPtr)num);
					for (;;)
					{
						global::System.Collections.Generic.IEnumerator<global::AcpBusinessLayer.FeatureNode> enumerator;
						switch (num2)
						{
						case 0:
							goto IL_1668;
						case 1:
							switch (0)
							{
							case 0:
								goto IL_1630;
							}
							continue;
						case 2:
							enumerator.Dispose();
							num = (short)872480768;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						IL_1630:
						if (enumerator == null)
						{
							break;
						}
						num = (short)2122252290;
						num2 = (int)((global::System.IntPtr)num);
					}
					IL_1668:;
				}
				return true;
				IL_179E:
				num = (short)1468137473;
				if (num != 0)
				{
				}
				return true;
			}
			}
		}

		// Token: 0x06000BC9 RID: 3017 RVA: 0x000B618C File Offset: 0x000B438C
		internal static bool conTrkSysTypeIsIIAndOBTEnabled(global::AcpCommonLib.IAcpFeatureSection self)
		{
			short num = (short)593035268;
			int num2 = (int)((global::System.IntPtr)num);
			global::AcpBusinessLayer.AcpListField trkSysGeneralTypeIIFrequencyBand_A;
			for (;;)
			{
				switch (num2)
				{
				case 0:
					if (trkSysGeneralTypeIIFrequencyBand_A.Value != 1)
					{
						num = (short)292552709;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_189;
				case 1:
					if (trkSysGeneralTypeIIFrequencyBand_A.Value != 0)
					{
						num = (short)755499011;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_189;
				case 2:
					num = (short)1008795649;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 3:
				{
					num = (short)1533737721;
					short num3 = num;
					num = (short)960690937;
					switch ((num3 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_189;
					default:
						num = (short)1519648768;
						if (num != 0)
						{
						}
						num = (short)808124416;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					break;
				}
				case 4:
					switch (0)
					{
					case 0:
						goto IL_3E;
					}
					continue;
				case 5:
					goto IL_FE;
				}
				IL_3E:
				num = (short)1696530432;
				short num4 = num;
				global::Motorola.MackinawCPS.CoreFeatures.TrunkingSystem.TrunkingSystem trunkingSystem = self.ParentRecset.ParentSection.Parent as global::Motorola.MackinawCPS.CoreFeatures.TrunkingSystem.TrunkingSystem;
				trkSysGeneralTypeIIFrequencyBand_A = trunkingSystem.General.TrkSysGeneralTypeIIFrequencyBand_A12491;
				if (trunkingSystem.General.TrkSysGeneralSystemType_A9252.Value != 2)
				{
					return false;
				}
				num = (short)293339138;
				num2 = (int)((global::System.IntPtr)num);
			}
			IL_FE:
			return trkSysGeneralTypeIIFrequencyBand_A.Value == 2;
			IL_189:
			num = (short)1118437377;
			if (num != 0)
			{
			}
			return true;
		}

		// Token: 0x06000BCA RID: 3018 RVA: 0x000B6350 File Offset: 0x000B4550
		internal static bool ConChannelSpacingValidity(global::AcpCommonLib.IAcpFeatureSection self)
		{
			short num = (short)324468736;
			int num2 = (int)num;
			switch (num2)
			{
			default:
			{
				switch (0)
				{
				case 0:
					goto IL_62;
				}
				global::AcpBusinessLayer.AcpFrequencyField trkSysASTRO25ChannelIDChannelSpacingkHz_A;
				bool result;
				global::AcpBusinessLayer.AcpFrequencyField trkSysASTRO25ChannelIDBaseFrequencyMHz_A;
				for (;;)
				{
					IL_27:
					global::System.Collections.Generic.IEnumerator<global::AcpBusinessLayer.FeatureNode> enumerator;
					switch (num2)
					{
					case 0:
					{
						num = (short)1078132736;
						short num3 = num;
						num = (short)187170820;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 1:
						if (trkSysASTRO25ChannelIDChannelSpacingkHz_A.Value % 1000 != 0)
						{
							num = (short)1665335299;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_4C2;
					case 2:
						try
						{
							num = (short)1788346374;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								switch (num2)
								{
								case 1:
									num = (short)1334837252;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 2:
								{
									if (!enumerator.MoveNext())
									{
										num = (short)259325953;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									global::AcpBusinessLayer.FeatureNode featureNode = enumerator.Current;
									num = (short)1454047237;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 3:
								{
									global::AcpBusinessLayer.FeatureNode featureNode;
									global::Motorola.MackinawCPS.CoreFeatures.TrunkingPersonality.TrunkingPersonality trunkingPersonality = featureNode as global::Motorola.MackinawCPS.CoreFeatures.TrunkingPersonality.TrunkingPersonality;
									trunkingPersonality.Talkgroup.CalculateApplicability();
									trunkingPersonality.Talkgroup.CalculateValidity();
									trunkingPersonality.AnnouncementGroup.TrkPerAnnouncementGroupAGFailsoftRxFrequencyMHz_A9582.CalculateValidity();
									trunkingPersonality.AnnouncementGroup.TrkPerAnnouncementGroupAGSecondaryFSRxFrequencyMHz_A8895.CalculateValidity();
									trunkingPersonality.AnnouncementGroup.TrkPerAnnouncementGroupAGSecondaryFSTxFrequencyMHz_A12903.CalculateValidity();
									trunkingPersonality.AnnouncementGroup.TrkPerAnnouncementGroupAGFailsoftTxFrequencyMHz_A9583.CalculateValidity();
									num = (short)752418816;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 4:
									goto IL_320;
								case 5:
								{
									global::AcpBusinessLayer.FeatureNode featureNode;
									if (featureNode is global::Motorola.MackinawCPS.CoreFeatures.TrunkingPersonality.TrunkingPersonality)
									{
										num = (short)1462697987;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									break;
								}
								case 6:
									switch (0)
									{
									case 0:
										goto IL_208;
									}
									continue;
								}
								IL_20A:
								num = (short)1307181058;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								IL_208:
								goto IL_20A;
							}
							IL_320:
							return result;
						}
						finally
						{
							num = (short)1355743234;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								num = (short)959728830;
								short num4 = num;
								num = (short)810568894;
								switch ((num4 == num) ? 1 : 0)
								{
								case 0:
								case 2:
									break;
								default:
									num = (short)600440832;
									if (num != 0)
									{
									}
									switch (num2)
									{
									case 0:
										goto IL_3DD;
									case 1:
										enumerator.Dispose();
										num = (short)446758912;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									case 2:
										goto IL_33B;
									}
									goto IL_3A4;
								}
								IL_33B:
								switch (0)
								{
								case 0:
									IL_3A4:
									if (enumerator == null)
									{
										goto IL_3DF;
									}
									num = (short)630325249;
									num2 = (int)((global::System.IntPtr)num);
									break;
								}
							}
							IL_3DD:
							IL_3DF:;
						}
						goto IL_3E0;
					case 3:
						num = (short)943456263;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 4:
						if ((double)trkSysASTRO25ChannelIDChannelSpacingkHz_A.Value % 1250.0 == 0.0)
						{
							num = (short)974782472;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_BC;
					case 5:
						goto IL_4C2;
					case 6:
						goto IL_3E0;
					case 7:
						if ((double)trkSysASTRO25ChannelIDChannelSpacingkHz_A.Value % 1250.0 == 0.0)
						{
							num = (short)645136389;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_BC;
					case 8:
						goto IL_427;
					case 9:
						if ((double)trkSysASTRO25ChannelIDChannelSpacingkHz_A.Value % 500.0 != 0.0)
						{
							num = (short)1127743488;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_427;
					case 10:
						num = (short)1909587969;
						if (num != 0)
						{
						}
						goto IL_BC;
					case 11:
						goto IL_BC;
					case 12:
						if (trkSysASTRO25ChannelIDBaseFrequencyMHz_A.Value > 34800000)
						{
							num = (short)1412759558;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)640090121;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_62;
					IL_BC:
					global::AcpBusinessLayer.FeatureNode featureNode2 = self.Parent.Parent.ParentSection.Parent as global::AcpBusinessLayer.FeatureNode;
					global::Motorola.MackinawCPS.CoreFeatures.TrunkingSystem.TrunkingSystem trunkingSystem = featureNode2 as global::Motorola.MackinawCPS.CoreFeatures.TrunkingSystem.TrunkingSystem;
					trunkingSystem.ControlChannels.CalculateApplicability();
					trunkingSystem.ControlChannels.CalculateValidity();
					enumerator = featureNode2.ReferencingNodes.GetEnumerator();
					num = (short)1408303106;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_3E0:
					num = (short)905183233;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_427:
					result = true;
					num = (short)1349779467;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_4C2:
					result = true;
					num = (short)88014858;
					num2 = (int)((global::System.IntPtr)num);
				}
				return result;
				IL_62:
				global::Motorola.MackinawCPS.CoreFeatures.TrunkingSystem.ASTRO25ChannelIDInnerSection astro25ChannelIDInnerSection = self as global::Motorola.MackinawCPS.CoreFeatures.TrunkingSystem.ASTRO25ChannelIDInnerSection;
				trkSysASTRO25ChannelIDBaseFrequencyMHz_A = astro25ChannelIDInnerSection.TrkSysASTRO25ChannelIDBaseFrequencyMHz_A7546;
				trkSysASTRO25ChannelIDChannelSpacingkHz_A = astro25ChannelIDInnerSection.TrkSysASTRO25ChannelIDChannelSpacingkHz_A7660;
				result = false;
				num = (short)1013121036;
				num2 = (int)((global::System.IntPtr)num);
				goto IL_27;
			}
			}
		}

		// Token: 0x06000BCB RID: 3019 RVA: 0x000B6884 File Offset: 0x000B4A84
		internal static bool conBaseFrequencyValidity(global::AcpCommonLib.IAcpFeatureSection self)
		{
			short num = (short)673054720;
			int num2 = (int)num;
			switch (num2)
			{
			default:
			{
				switch (0)
				{
				case 0:
					goto IL_83;
				}
				global::AcpBusinessLayer.AcpFrequencyField trkSysASTRO25ChannelIDChannelSpacingkHz_A;
				global::AcpBusinessLayer.AcpFrequencyField trkSysASTRO25ChannelIDBaseFrequencyMHz_A;
				bool result;
				for (;;)
				{
					IL_28:
					global::System.Collections.Generic.IEnumerator<global::AcpBusinessLayer.FeatureNode> enumerator;
					switch (num2)
					{
					case 0:
						if ((double)trkSysASTRO25ChannelIDChannelSpacingkHz_A.Value % 500.0 != 0.0)
						{
							num = (short)125239309;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_DF;
					case 1:
						goto IL_621;
					case 2:
						num = (short)576323587;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 3:
						if ((double)trkSysASTRO25ChannelIDChannelSpacingkHz_A.Value % 1250.0 == 0.0)
						{
							num = (short)1636630529;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_52A;
					case 4:
						num = (short)592117776;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 5:
						if (trkSysASTRO25ChannelIDBaseFrequencyMHz_A.Value % 1000 == 0)
						{
							num = (short)2037055497;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_152;
					case 6:
						if (trkSysASTRO25ChannelIDChannelSpacingkHz_A.Value % 1000 != 0)
						{
							num = (short)144965642;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_621;
					case 7:
						if ((double)trkSysASTRO25ChannelIDBaseFrequencyMHz_A.Value % 1250.0 == 0.0)
						{
							num = (short)1971191810;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_52A;
					case 8:
						num = (short)1946484736;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 9:
						goto IL_3BC;
					case 10:
						goto IL_152;
					case 11:
						if ((double)trkSysASTRO25ChannelIDBaseFrequencyMHz_A.Value % 500.0 == 0.0)
						{
							num = (short)660733960;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_587;
					case 12:
						try
						{
							num = (short)2014642182;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								switch (num2)
								{
								case 1:
								{
									global::AcpBusinessLayer.FeatureNode featureNode;
									global::Motorola.MackinawCPS.CoreFeatures.TrunkingPersonality.TrunkingPersonality trunkingPersonality = featureNode as global::Motorola.MackinawCPS.CoreFeatures.TrunkingPersonality.TrunkingPersonality;
									trunkingPersonality.Talkgroup.CalculateApplicability();
									trunkingPersonality.Talkgroup.CalculateValidity();
									trunkingPersonality.AnnouncementGroup.TrkPerAnnouncementGroupAGFailsoftRxFrequencyMHz_A9582.CalculateValidity();
									trunkingPersonality.AnnouncementGroup.TrkPerAnnouncementGroupAGSecondaryFSRxFrequencyMHz_A8895.CalculateValidity();
									trunkingPersonality.AnnouncementGroup.TrkPerAnnouncementGroupAGSecondaryFSTxFrequencyMHz_A12903.CalculateValidity();
									trunkingPersonality.AnnouncementGroup.TrkPerAnnouncementGroupAGFailsoftTxFrequencyMHz_A9583.CalculateValidity();
									num = (short)85852160;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 2:
								{
									global::AcpBusinessLayer.FeatureNode featureNode;
									if (featureNode is global::Motorola.MackinawCPS.CoreFeatures.TrunkingPersonality.TrunkingPersonality)
									{
										num = (short)1563557889;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									break;
								}
								case 3:
									num = (short)1231028228;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 4:
									goto IL_2FD;
								case 5:
								{
									if (!enumerator.MoveNext())
									{
										num = (short)45023235;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									global::AcpBusinessLayer.FeatureNode featureNode = enumerator.Current;
									num = (short)1858535426;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 6:
									switch (0)
									{
									case 0:
										goto IL_1EA;
									}
									continue;
								}
								IL_2A6:
								num = (short)489160709;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								IL_1EA:
								goto IL_2A6;
							}
							IL_2FD:
							return result;
						}
						finally
						{
							num = (short)806289410;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								num = (short)1660576395;
								short num3 = num;
								num = (short)1660445323;
								switch ((num3 == num) ? 1 : 0)
								{
								case 0:
								case 2:
									break;
								default:
									num = (short)812974080;
									if (num != 0)
									{
									}
									switch (num2)
									{
									case 0:
										goto IL_3B9;
									case 1:
										enumerator.Dispose();
										num = (short)422445056;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									case 2:
										goto IL_318;
									}
									goto IL_37F;
								}
								IL_318:
								switch (0)
								{
								case 0:
									IL_37F:
									if (enumerator == null)
									{
										goto IL_3BB;
									}
									num = (short)386924545;
									num2 = (int)((global::System.IntPtr)num);
									break;
								}
							}
							IL_3B9:
							IL_3BB:;
						}
						goto IL_3BC;
					case 13:
						goto IL_587;
					case 14:
						goto IL_52A;
					case 15:
						num = (short)1676476417;
						if (num != 0)
						{
						}
						goto IL_DF;
					case 16:
						if ((double)trkSysASTRO25ChannelIDChannelSpacingkHz_A.Value % 1250.0 == 0.0)
						{
							num = (short)80478223;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_52A;
					case 17:
						goto IL_52A;
					case 18:
						num = (short)2141323269;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 19:
						if ((double)trkSysASTRO25ChannelIDBaseFrequencyMHz_A.Value % 1250.0 == 0.0)
						{
							num = (short)570163204;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_52A;
					case 20:
						if (trkSysASTRO25ChannelIDBaseFrequencyMHz_A.Value > 34800000)
						{
							num = (short)2064318482;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)98172939;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_83;
					IL_DF:
					result = true;
					num = (short)1756692494;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_152:
					num = (short)1203109895;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_3BC:
					num = (short)2138767366;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_52A:
					global::AcpBusinessLayer.FeatureNode featureNode2 = self.Parent.Parent.ParentSection.Parent as global::AcpBusinessLayer.FeatureNode;
					global::Motorola.MackinawCPS.CoreFeatures.TrunkingSystem.TrunkingSystem trunkingSystem = featureNode2 as global::Motorola.MackinawCPS.CoreFeatures.TrunkingSystem.TrunkingSystem;
					trunkingSystem.ControlChannels.CalculateApplicability();
					trunkingSystem.ControlChannels.CalculateValidity();
					enumerator = featureNode2.ReferencingNodes.GetEnumerator();
					num = (short)2090598412;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_587:
					num = (short)814678035;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_621:
					num = (short)565575680;
					short num4 = num;
					result = true;
					num = (short)1114832913;
					num2 = (int)((global::System.IntPtr)num);
				}
				return result;
				IL_83:
				global::Motorola.MackinawCPS.CoreFeatures.TrunkingSystem.ASTRO25ChannelIDInnerSection astro25ChannelIDInnerSection = self as global::Motorola.MackinawCPS.CoreFeatures.TrunkingSystem.ASTRO25ChannelIDInnerSection;
				trkSysASTRO25ChannelIDBaseFrequencyMHz_A = astro25ChannelIDInnerSection.TrkSysASTRO25ChannelIDBaseFrequencyMHz_A7546;
				trkSysASTRO25ChannelIDChannelSpacingkHz_A = astro25ChannelIDInnerSection.TrkSysASTRO25ChannelIDChannelSpacingkHz_A7660;
				result = false;
				num = (short)2293780;
				num2 = (int)((global::System.IntPtr)num);
				goto IL_28;
			}
			}
		}

		// Token: 0x06000BCC RID: 3020 RVA: 0x000B6F18 File Offset: 0x000B5118
		internal static bool conTransmitOffsetValidity(global::AcpCommonLib.IAcpFeatureSection self)
		{
			short num = (short)2012020736;
			int num2 = (int)num;
			switch (num2)
			{
			default:
			{
				switch (0)
				{
				case 0:
					goto IL_A0;
				}
				int num3;
				bool result;
				global::AcpBusinessLayer.AcpFrequencyField trkSysASTRO25ChannelIDBaseFrequencyMHz_A;
				global::AcpBusinessLayer.AcpFrequencyField trkSysASTRO25ChannelIDTransmitOffsetMHz_A;
				global::AcpBusinessLayer.AcpFrequencyField trkSysASTRO25ChannelIDChannelSpacingkHz_A;
				for (;;)
				{
					IL_29:
					global::System.Collections.Generic.IEnumerator<global::AcpBusinessLayer.FeatureNode> enumerator;
					switch (num2)
					{
					case 0:
						num = (short)1560608783;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 1:
						if (global::ConstraintHelper.UtilityMack.IsVHFSupported())
						{
							num = (short)249626638;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_19C;
					case 2:
						num = (short)1142489091;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 3:
						if (num3 > 146000000)
						{
							num = (short)723451926;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_56B;
					case 4:
						result = true;
						num = (short)1880424464;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 5:
						goto IL_4C4;
					case 6:
						goto IL_25F;
					case 7:
						goto IL_56B;
					case 8:
						try
						{
							num = (short)1849294854;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								switch (num2)
								{
								case 0:
								{
									global::AcpBusinessLayer.FeatureNode featureNode;
									global::Motorola.MackinawCPS.CoreFeatures.TrunkingPersonality.TrunkingPersonality trunkingPersonality = featureNode as global::Motorola.MackinawCPS.CoreFeatures.TrunkingPersonality.TrunkingPersonality;
									trunkingPersonality.Talkgroup.CalculateApplicability();
									trunkingPersonality.Talkgroup.CalculateValidity();
									trunkingPersonality.AnnouncementGroup.TrkPerAnnouncementGroupAGSecondaryFSTxFrequencyMHz_A12903.CalculateValidity();
									trunkingPersonality.AnnouncementGroup.TrkPerAnnouncementGroupAGFailsoftTxFrequencyMHz_A9583.CalculateValidity();
									num = (short)484573186;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 1:
								{
									global::AcpBusinessLayer.FeatureNode featureNode;
									if (featureNode is global::Motorola.MackinawCPS.CoreFeatures.TrunkingPersonality.TrunkingPersonality)
									{
										num = (short)1079246848;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									break;
								}
								case 3:
									num = (short)1225916420;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 4:
									goto IL_405;
								case 5:
								{
									if (!enumerator.MoveNext())
									{
										num = (short)147587075;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									global::AcpBusinessLayer.FeatureNode featureNode = enumerator.Current;
									num = (short)1162346497;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 6:
									switch (0)
									{
									case 0:
										goto IL_311;
									}
									continue;
								}
								IL_3B0:
								num = (short)557580293;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								IL_311:
								goto IL_3B0;
							}
							IL_405:
							return result;
						}
						finally
						{
							num = (short)1461846018;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								num = (short)1342205879;
								short num4 = num;
								num = (short)152989623;
								switch ((num4 == num) ? 1 : 0)
								{
								case 0:
								case 2:
									break;
								default:
									num = (short)907542528;
									if (num != 0)
									{
									}
									switch (num2)
									{
									case 0:
										goto IL_4C1;
									case 1:
										enumerator.Dispose();
										num = (short)370868224;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									case 2:
										goto IL_421;
									}
									goto IL_487;
								}
								IL_421:
								switch (0)
								{
								case 0:
									IL_487:
									if (enumerator == null)
									{
										goto IL_4C3;
									}
									num = (short)81199105;
									num2 = (int)((global::System.IntPtr)num);
									break;
								}
							}
							IL_4C1:
							IL_4C3:;
						}
						goto IL_4C4;
					case 9:
						num = (short)1211170835;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 10:
						if (trkSysASTRO25ChannelIDBaseFrequencyMHz_A.Value < 148000000)
						{
							num = (short)1289420818;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)231342105;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 11:
						if ((double)trkSysASTRO25ChannelIDTransmitOffsetMHz_A.Value % 50000.0 == 0.0)
						{
							num = (short)211943428;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_204;
					case 12:
						num = (short)597032971;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 13:
						goto IL_204;
					case 14:
						goto IL_2AB;
					case 15:
						if ((double)num3 == 4990000.0)
						{
							num = (short)1818427398;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_19C;
					case 16:
						goto IL_204;
					case 17:
						num = (short)1895956501;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 18:
						num = (short)1624375322;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 19:
						if (trkSysASTRO25ChannelIDTransmitOffsetMHz_A.Value <= 8191 * trkSysASTRO25ChannelIDChannelSpacingkHz_A.Value)
						{
							num = (short)1870331928;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_204;
					case 20:
						if (num3 >= 0)
						{
							num = (short)245956610;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_622;
					case 21:
						if (trkSysASTRO25ChannelIDTransmitOffsetMHz_A.Value <= 28000000)
						{
							num = (short)776405001;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_204;
					case 22:
						goto IL_622;
					case 23:
						if (trkSysASTRO25ChannelIDTransmitOffsetMHz_A.Value % trkSysASTRO25ChannelIDChannelSpacingkHz_A.Value == 0)
						{
							num = (short)38797329;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_204;
					case 24:
						result = true;
						num = (short)301924365;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 25:
						if ((double)trkSysASTRO25ChannelIDTransmitOffsetMHz_A.Value <= 12750000.0)
						{
							num = (short)2098790412;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_204;
					case 26:
						if (trkSysASTRO25ChannelIDChannelSpacingkHz_A.Value != 0)
						{
							num = (short)1688141829;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_204;
					case 27:
						if ((double)num3 != 3990000.0)
						{
							num = (short)2134900736;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_25F;
					}
					goto IL_A0;
					IL_19C:
					num = (short)990117888;
					short num5 = num;
					num = (short)632160276;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_204:
					global::AcpBusinessLayer.FeatureNode featureNode2 = self.Parent.Parent.ParentSection.Parent as global::AcpBusinessLayer.FeatureNode;
					global::Motorola.MackinawCPS.CoreFeatures.TrunkingSystem.TrunkingSystem trunkingSystem = featureNode2 as global::Motorola.MackinawCPS.CoreFeatures.TrunkingSystem.TrunkingSystem;
					trunkingSystem.ControlChannels.CalculateApplicability();
					trunkingSystem.ControlChannels.CalculateValidity();
					enumerator = featureNode2.ReferencingNodes.GetEnumerator();
					num = (short)1418919944;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_25F:
					global::AcpCommonLib.IAcpFeatureNode acpFeatureNode = global::AcpCommonLib.FeatureManager.GetFeature(2049)[0];
					num = (short)760152065;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_4C4:
					num = (short)313524247;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_56B:
					num = (short)1402601482;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_622:
					result = false;
					num = (short)1606483975;
					num2 = (int)((global::System.IntPtr)num);
				}
				IL_2AB:
				num = (short)848691201;
				if (num != 0)
				{
				}
				return true;
				IL_A0:
				global::Motorola.MackinawCPS.CoreFeatures.TrunkingSystem.ASTRO25ChannelIDInnerSection astro25ChannelIDInnerSection = self as global::Motorola.MackinawCPS.CoreFeatures.TrunkingSystem.ASTRO25ChannelIDInnerSection;
				trkSysASTRO25ChannelIDBaseFrequencyMHz_A = astro25ChannelIDInnerSection.TrkSysASTRO25ChannelIDBaseFrequencyMHz_A7546;
				trkSysASTRO25ChannelIDChannelSpacingkHz_A = astro25ChannelIDInnerSection.TrkSysASTRO25ChannelIDChannelSpacingkHz_A7660;
				trkSysASTRO25ChannelIDTransmitOffsetMHz_A = astro25ChannelIDInnerSection.TrkSysASTRO25ChannelIDTransmitOffsetMHz_A9416;
				result = false;
				num3 = trkSysASTRO25ChannelIDTransmitOffsetMHz_A.Value * 5;
				num = (short)165085211;
				num2 = (int)((global::System.IntPtr)num);
				goto IL_29;
			}
			}
		}

		// Token: 0x06000BCD RID: 3021 RVA: 0x000B766C File Offset: 0x000B586C
		internal static bool ConSiteAliasInvalidWhenEnabledAndInapplicable(global::AcpCommonLib.IAcpFeatureSection self)
		{
			short num = (short)1565589513;
			int num2 = (int)((global::System.IntPtr)num);
			global::AcpBusinessLayer.AcpListField trkSysGeneralCoverageType_A;
			for (;;)
			{
				switch (num2)
				{
				case 0:
				{
					global::Motorola.MackinawCPS.CoreFeatures.TrunkingSystem.TrunkingSystem trunkingSystem;
					if (trunkingSystem.General.TrkSysGeneralSystemType_A9252.Value == 3)
					{
						num = (short)1241120773;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					return false;
				}
				case 1:
					num = (short)1900609538;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 2:
					if (trkSysGeneralCoverageType_A.Value != 3)
					{
						num = (short)1196425220;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					return true;
				case 3:
				{
					num = (short)192403663;
					short num3 = num;
					num = (short)1244256463;
					switch ((num3 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_14;
					default:
						num = (short)340721664;
						if (num != 0)
						{
						}
						if (trkSysGeneralCoverageType_A.Value != 5)
						{
							num = (short)1994063880;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return true;
					}
					break;
				}
				case 4:
					num = (short)1863909376;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 5:
					num = (short)423886849;
					if (num != 0)
					{
					}
					num = (short)1995177990;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 6:
					if (trkSysGeneralCoverageType_A.Value != 7)
					{
						num = (short)1019543559;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					return true;
				case 7:
					num = (short)1343750147;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 8:
					goto IL_1D5;
				case 9:
					goto IL_14;
				}
				goto IL_4C;
				IL_14:
				switch (0)
				{
				case 0:
				{
					IL_4C:
					num = (short)304807936;
					short num4 = num;
					global::Motorola.MackinawCPS.CoreFeatures.TrunkingSystem.SiteAlias siteAlias = self as global::Motorola.MackinawCPS.CoreFeatures.TrunkingSystem.SiteAlias;
					global::Motorola.MackinawCPS.CoreFeatures.TrunkingSystem.TrunkingSystem trunkingSystem = self.Parent as global::Motorola.MackinawCPS.CoreFeatures.TrunkingSystem.TrunkingSystem;
					trkSysGeneralCoverageType_A = trunkingSystem.General.TrkSysGeneralCoverageType_A7782;
					if (!siteAlias.TrkSysSiteAliasSiteAliasEnable_A9148.Value)
					{
						return true;
					}
					num = (short)1099497473;
					num2 = (int)((global::System.IntPtr)num);
					break;
				}
				}
			}
			return true;
			IL_1D5:
			return trkSysGeneralCoverageType_A.Value == 6;
		}

		// Token: 0x06000BCE RID: 3022 RVA: 0x000B78BC File Offset: 0x000B5ABC
		public static bool ConTrkSysDynRegroupZoneIsValid(global::AcpCommonLib.IAcpFeatureSection self, int index)
		{
			switch (0)
			{
			case 0:
				goto IL_54;
			}
			int num;
			global::Motorola.MackinawCPS.CoreFeatures.TrunkingSystem.Features features;
			short num2;
			for (;;)
			{
				IL_0A:
				switch (num)
				{
				case 0:
				{
					global::Motorola.MackinawCPS.CoreFeatures.ZoneChannelAssignment.ZoneChannelAssignment zoneChannelAssignment = features.TrkSysFeaturesZone_A9717.RefRecset[index - 1] as global::Motorola.MackinawCPS.CoreFeatures.ZoneChannelAssignment.ZoneChannelAssignment;
					num2 = (short)416088071;
					num = (int)((global::System.IntPtr)num2);
					continue;
				}
				case 1:
				{
					global::Motorola.MackinawCPS.CoreFeatures.ZoneChannelAssignment.ZoneChannelAssignment zoneChannelAssignment;
					if (!zoneChannelAssignment.Zone.ZnChanCfgZoneDynamicZoneEnable_A41257.Value)
					{
						num2 = (short)1283063821;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					return false;
				}
				case 2:
				{
					global::Motorola.MackinawCPS.CoreFeatures.ZoneChannelAssignment.ZoneChannelAssignment zoneChannelAssignment;
					if (zoneChannelAssignment.RSI.ZoneChannelAssignmentRSIMode_A41831.Value != 0)
					{
						num2 = (short)120193027;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_10B;
				}
				case 3:
					goto IL_256;
				case 4:
					if (index > 0)
					{
						num2 = (short)1638793222;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_10B;
				case 5:
					num2 = (short)321126401;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 6:
					goto IL_106;
				case 7:
				{
					global::Motorola.MackinawCPS.CoreFeatures.ZoneChannelAssignment.ZoneChannelAssignment zoneChannelAssignment;
					if (zoneChannelAssignment != null)
					{
						num2 = (short)325910533;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_10B;
				}
				case 8:
					goto IL_1BD;
				case 9:
					num2 = (short)406716418;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 10:
				{
					global::Motorola.MackinawCPS.CoreFeatures.ZoneChannelAssignment.ZoneChannelAssignment zoneChannelAssignment;
					if (zoneChannelAssignment.RSI != null)
					{
						num2 = (short)833159177;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_10B;
				}
				case 11:
					goto IL_D3;
				case 12:
				{
					if (!features.TrkSysFeaturesDynamicRegroupingEnable_A7969.Value)
					{
						return true;
					}
					num2 = (short)2020081665;
					if (num2 != 0)
					{
					}
					num2 = (short)253797747;
					short num3 = num2;
					num2 = (short)1501472115;
					switch ((num3 == num2) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_106;
					default:
						num2 = (short)211877888;
						if (num2 != 0)
						{
						}
						num2 = (short)775684104;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					break;
				}
				case 13:
					num2 = (short)926941194;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 14:
				{
					num2 = (short)938868736;
					short num4 = num2;
					features.ChannelAssignmentListInnerSectionForTrkSysFeaturesChannel_A7647.CalculateValidity();
					num2 = (short)1940783115;
					num = (int)((global::System.IntPtr)num2);
					continue;
				}
				case 15:
					if (index <= features.TrkSysFeaturesZone_A9717.RefRecset.Count)
					{
						num2 = (short)1176371200;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_10B;
				case 16:
					if (features.ChannelAssignmentListInnerSectionForTrkSysFeaturesChannel_A7647 != null)
					{
						num2 = (short)62062606;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_D3;
				}
				goto IL_54;
				IL_D3:
				num2 = (short)1196163076;
				num = (int)((global::System.IntPtr)num2);
				continue;
				IL_106:
				num2 = (short)871563279;
				num = (int)((global::System.IntPtr)num2);
				continue;
				IL_10B:
				num2 = (short)1479409676;
				num = (int)((global::System.IntPtr)num2);
			}
			return false;
			IL_1BD:
			return index != 0;
			IL_256:
			return false;
			IL_54:
			features = (self as global::Motorola.MackinawCPS.CoreFeatures.TrunkingSystem.Features);
			num2 = (short)656211984;
			num = (int)((global::System.IntPtr)num2);
			goto IL_0A;
		}

		// Token: 0x06000BCF RID: 3023 RVA: 0x000B7C0C File Offset: 0x000B5E0C
		internal static bool conTrkSysChanAssignRxStartFreqApp(global::AcpCommonLib.IAcpFeatureSection self)
		{
			short num = (short)361365504;
			int num2 = (int)num;
			switch (num2)
			{
			default:
			{
				switch (0)
				{
				case 0:
					goto IL_72;
				}
				global::AcpBusinessLayer.AcpListField trkSysGeneralTypeIIFrequencyBand_A;
				global::Motorola.MackinawCPS.CoreFeatures.TrunkingSystem.TrunkingSystem trunkingSystem;
				global::AcpCommonLib.IAcpFeatureNode parent;
				global::AcpCommonLib.IAcpFeatureNode acpFeatureNode2;
				global::AcpCommonLib.IAcpFeatureNode acpFeatureNode3;
				for (;;)
				{
					IL_27:
					int num3;
					switch (num2)
					{
					case 0:
						if (trkSysGeneralTypeIIFrequencyBand_A.Value != 1)
						{
							num = (short)1542586369;
							if (num != 0)
							{
							}
							num = (short)723648513;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_38F;
					case 1:
						num = (short)662110215;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 2:
						if (trunkingSystem.General.TrkSysGeneralSystemType_A9252.Value == 2)
						{
							num = (short)750845956;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return false;
					case 3:
					{
						global::AcpCommonLib.IAcpFeatureNode acpFeatureNode = parent.Parent[0];
						acpFeatureNode2 = parent.Parent[1];
						acpFeatureNode3 = parent.Parent[2];
						if ((acpFeatureNode[10168] as global::Motorola.MackinawCPS.CoreFeatures.TrunkingSystem.ChannelRangesMHzInnerSection).TrkSysOBTChannelAssignmentListRxEnable_A9001.Value)
						{
							num = (short)70385679;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return false;
					}
					case 4:
						num = (short)1477967885;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 5:
						switch (num3)
						{
						case 0:
							goto IL_44A;
						case 1:
							num = (short)630587402;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 2:
							num = (short)498139139;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						default:
							num = (short)1870331916;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						break;
					case 6:
					{
						num = (short)1755156128;
						short num4 = num;
						num = (short)929336992;
						switch ((num4 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							continue;
						default:
							goto IL_375;
						}
						break;
					}
					case 7:
						if (trkSysGeneralTypeIIFrequencyBand_A.Value == 2)
						{
							num = (short)1386807304;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return false;
					case 8:
						goto IL_38F;
					case 9:
						num = (short)368771072;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 10:
					{
						global::AcpCommonLib.IAcpFeatureNode acpFeatureNode4 = parent.Parent[0];
						acpFeatureNode2 = parent.Parent[1];
						if ((acpFeatureNode4[10168] as global::Motorola.MackinawCPS.CoreFeatures.TrunkingSystem.ChannelRangesMHzInnerSection).TrkSysOBTChannelAssignmentListRxEnable_A9001.Value)
						{
							num = (short)1324482566;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return false;
					}
					case 11:
						goto IL_2D0;
					case 12:
						num = (short)1649475600;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 13:
						if (trkSysGeneralTypeIIFrequencyBand_A.Value != 0)
						{
							num = (short)2002583561;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_38F;
					case 14:
						if ((acpFeatureNode2[10168] as global::Motorola.MackinawCPS.CoreFeatures.TrunkingSystem.ChannelRangesMHzInnerSection).TrkSysOBTChannelAssignmentListRxEnable_A9001.Value)
						{
							num = (short)1670971403;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return false;
					case 15:
						num = (short)1437073422;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 16:
						return false;
					}
					goto IL_72;
					IL_38F:
					num3 = (parent.Parent as global::AcpBusinessLayer.Recordset).IndexOf(parent);
					num = (short)1162870789;
					num2 = (int)((global::System.IntPtr)num);
				}
				IL_2D0:
				return (acpFeatureNode3[10168] as global::Motorola.MackinawCPS.CoreFeatures.TrunkingSystem.ChannelRangesMHzInnerSection).TrkSysOBTChannelAssignmentListRxEnable_A9001.Value;
				IL_375:
				num = (short)1109065728;
				if (num != 0)
				{
				}
				return (acpFeatureNode2[10168] as global::Motorola.MackinawCPS.CoreFeatures.TrunkingSystem.ChannelRangesMHzInnerSection).TrkSysOBTChannelAssignmentListRxEnable_A9001.Value;
				IL_44A:
				return (parent.Parent[0][10168] as global::Motorola.MackinawCPS.CoreFeatures.TrunkingSystem.ChannelRangesMHzInnerSection).TrkSysOBTChannelAssignmentListRxEnable_A9001.Value;
				IL_72:
				global::Motorola.MackinawCPS.CoreFeatures.TrunkingSystem.ChannelRangesMHzInnerSection channelRangesMHzInnerSection = self as global::Motorola.MackinawCPS.CoreFeatures.TrunkingSystem.ChannelRangesMHzInnerSection;
				trunkingSystem = (self.ParentRecset.ParentSection.Parent as global::Motorola.MackinawCPS.CoreFeatures.TrunkingSystem.TrunkingSystem);
				trkSysGeneralTypeIIFrequencyBand_A = trunkingSystem.General.TrkSysGeneralTypeIIFrequencyBand_A12491;
				parent = channelRangesMHzInnerSection.TrkSysOBTChannelAssignmentListRxEnable_A9001.Parent.Parent;
				acpFeatureNode2 = null;
				acpFeatureNode3 = null;
				num = (short)1979056128;
				short num5 = num;
				num = (short)19136514;
				num2 = (int)((global::System.IntPtr)num);
				goto IL_27;
			}
			}
		}

		// Token: 0x06000BD0 RID: 3024 RVA: 0x000B808C File Offset: 0x000B628C
		internal static bool conTrkSysChanAssignRxEndFreqApp(global::AcpCommonLib.IAcpFeatureSection self)
		{
			short num = (short)2021130240;
			int num2 = (int)num;
			switch (num2)
			{
			default:
			{
				switch (0)
				{
				case 0:
					goto IL_72;
				}
				global::AcpBusinessLayer.AcpListField trkSysGeneralTypeIIFrequencyBand_A;
				global::Motorola.MackinawCPS.CoreFeatures.TrunkingSystem.TrunkingSystem trunkingSystem;
				global::AcpCommonLib.IAcpFeatureNode parent;
				global::AcpCommonLib.IAcpFeatureNode acpFeatureNode2;
				global::AcpCommonLib.IAcpFeatureNode acpFeatureNode3;
				for (;;)
				{
					IL_27:
					int num3;
					switch (num2)
					{
					case 0:
						if (trkSysGeneralTypeIIFrequencyBand_A.Value != 1)
						{
							num = (short)1293811713;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_36C;
					case 1:
						num = (short)8716295;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 2:
						if (trunkingSystem.General.TrkSysGeneralSystemType_A9252.Value == 2)
						{
							num = (short)1327038468;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return false;
					case 3:
					{
						global::AcpCommonLib.IAcpFeatureNode acpFeatureNode = parent.Parent[0];
						acpFeatureNode2 = parent.Parent[1];
						acpFeatureNode3 = parent.Parent[2];
						if ((acpFeatureNode[10168] as global::Motorola.MackinawCPS.CoreFeatures.TrunkingSystem.ChannelRangesMHzInnerSection).TrkSysOBTChannelAssignmentListRxEnable_A9001.Value)
						{
							num = (short)1873739791;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return false;
					}
					case 4:
						num = (short)526319629;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 5:
						switch (num3)
						{
						case 0:
							goto IL_451;
						case 1:
							num = (short)227409930;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 2:
							num = (short)804388867;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						default:
							num = (short)463994892;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						break;
					case 6:
					{
						num = (short)1563239716;
						short num4 = num;
						num = (short)1731732772;
						switch ((num4 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							continue;
						default:
							goto IL_352;
						}
						break;
					}
					case 7:
						if (trkSysGeneralTypeIIFrequencyBand_A.Value == 2)
						{
							num = (short)121765896;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return false;
					case 8:
						goto IL_36C;
					case 9:
						num = (short)161480704;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 10:
					{
						global::AcpCommonLib.IAcpFeatureNode acpFeatureNode4 = parent.Parent[0];
						acpFeatureNode2 = parent.Parent[1];
						if ((acpFeatureNode4[10168] as global::Motorola.MackinawCPS.CoreFeatures.TrunkingSystem.ChannelRangesMHzInnerSection).TrkSysOBTChannelAssignmentListRxEnable_A9001.Value)
						{
							num = (short)2004680710;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return false;
					}
					case 11:
						goto IL_2AD;
					case 12:
						num = (short)1718878224;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 13:
						num = (short)1280311297;
						if (num != 0)
						{
						}
						if (trkSysGeneralTypeIIFrequencyBand_A.Value != 0)
						{
							num = (short)918749193;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_36C;
					case 14:
						if ((acpFeatureNode2[10168] as global::Motorola.MackinawCPS.CoreFeatures.TrunkingSystem.ChannelRangesMHzInnerSection).TrkSysOBTChannelAssignmentListRxEnable_A9001.Value)
						{
							num = (short)690356235;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return false;
					case 15:
						num = (short)180289550;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 16:
						return false;
					}
					goto IL_72;
					IL_36C:
					num3 = (parent.Parent as global::AcpBusinessLayer.Recordset).IndexOf(parent);
					num = (short)1676935173;
					num2 = (int)((global::System.IntPtr)num);
				}
				IL_2AD:
				return (acpFeatureNode3[10168] as global::Motorola.MackinawCPS.CoreFeatures.TrunkingSystem.ChannelRangesMHzInnerSection).TrkSysOBTChannelAssignmentListRxEnable_A9001.Value;
				IL_352:
				num = (short)579141632;
				if (num != 0)
				{
				}
				return (acpFeatureNode2[10168] as global::Motorola.MackinawCPS.CoreFeatures.TrunkingSystem.ChannelRangesMHzInnerSection).TrkSysOBTChannelAssignmentListRxEnable_A9001.Value;
				IL_451:
				return (parent.Parent[0][10168] as global::Motorola.MackinawCPS.CoreFeatures.TrunkingSystem.ChannelRangesMHzInnerSection).TrkSysOBTChannelAssignmentListRxEnable_A9001.Value;
				IL_72:
				global::Motorola.MackinawCPS.CoreFeatures.TrunkingSystem.ChannelRangesMHzInnerSection channelRangesMHzInnerSection = self as global::Motorola.MackinawCPS.CoreFeatures.TrunkingSystem.ChannelRangesMHzInnerSection;
				trunkingSystem = (self.ParentRecset.ParentSection.Parent as global::Motorola.MackinawCPS.CoreFeatures.TrunkingSystem.TrunkingSystem);
				trkSysGeneralTypeIIFrequencyBand_A = trunkingSystem.General.TrkSysGeneralTypeIIFrequencyBand_A12491;
				parent = channelRangesMHzInnerSection.TrkSysOBTChannelAssignmentListRxEnable_A9001.Parent.Parent;
				acpFeatureNode2 = null;
				acpFeatureNode3 = null;
				num = (short)1978662912;
				short num5 = num;
				num = (short)92209154;
				num2 = (int)((global::System.IntPtr)num);
				goto IL_27;
			}
			}
		}

		// Token: 0x06000BD1 RID: 3025 RVA: 0x000B8514 File Offset: 0x000B6714
		internal static bool conTrkSysChanAssignTxStartFreqApp(global::AcpCommonLib.IAcpFeatureSection self)
		{
			short num = (short)1319174144;
			int num2 = (int)num;
			switch (num2)
			{
			default:
			{
				switch (0)
				{
				case 0:
					goto IL_72;
				}
				global::AcpBusinessLayer.AcpListField trkSysGeneralTypeIIFrequencyBand_A;
				global::Motorola.MackinawCPS.CoreFeatures.TrunkingSystem.TrunkingSystem trunkingSystem;
				global::AcpCommonLib.IAcpFeatureNode parent;
				global::AcpCommonLib.IAcpFeatureNode acpFeatureNode2;
				global::AcpCommonLib.IAcpFeatureNode acpFeatureNode3;
				for (;;)
				{
					IL_27:
					int num3;
					switch (num2)
					{
					case 0:
						if (trkSysGeneralTypeIIFrequencyBand_A.Value != 1)
						{
							num = (short)1067122689;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_390;
					case 1:
						num = (short)280428551;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 2:
						if (trunkingSystem.General.TrkSysGeneralSystemType_A9252.Value == 2)
						{
							num = (short)634060801;
							if (num != 0)
							{
							}
							num = (short)179109892;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return false;
					case 3:
					{
						global::AcpCommonLib.IAcpFeatureNode acpFeatureNode = parent.Parent[0];
						acpFeatureNode2 = parent.Parent[1];
						acpFeatureNode3 = parent.Parent[2];
						if ((acpFeatureNode[10168] as global::Motorola.MackinawCPS.CoreFeatures.TrunkingSystem.ChannelRangesMHzInnerSection).TrkSysOBTChannelAssignmentListTxEnable_A9517.Value)
						{
							num = (short)1186398223;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return false;
					}
					case 4:
						num = (short)104136717;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 5:
						switch (num3)
						{
						case 0:
							goto IL_44C;
						case 1:
							num = (short)1521287178;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 2:
							num = (short)2115764227;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						default:
							num = (short)135593996;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						break;
					case 6:
					{
						num = (short)511103390;
						short num4 = num;
						num = (short)206098846;
						switch ((num4 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							continue;
						default:
							goto IL_376;
						}
						break;
					}
					case 7:
						if (trkSysGeneralTypeIIFrequencyBand_A.Value == 2)
						{
							num = (short)1131282440;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return false;
					case 8:
						goto IL_390;
					case 9:
						num = (short)1647312896;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 10:
					{
						global::AcpCommonLib.IAcpFeatureNode acpFeatureNode4 = parent.Parent[0];
						acpFeatureNode2 = parent.Parent[1];
						if ((acpFeatureNode4[10168] as global::Motorola.MackinawCPS.CoreFeatures.TrunkingSystem.ChannelRangesMHzInnerSection).TrkSysOBTChannelAssignmentListTxEnable_A9517.Value)
						{
							num = (short)1810038790;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return false;
					}
					case 11:
						goto IL_2D4;
					case 12:
						num = (short)1059061776;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 13:
						if (trkSysGeneralTypeIIFrequencyBand_A.Value != 0)
						{
							num = (short)336658441;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_390;
					case 14:
						if ((acpFeatureNode2[10168] as global::Motorola.MackinawCPS.CoreFeatures.TrunkingSystem.ChannelRangesMHzInnerSection).TrkSysOBTChannelAssignmentListTxEnable_A9517.Value)
						{
							num = (short)1902247947;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return false;
					case 15:
						num = (short)1688600590;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 16:
						return false;
					}
					goto IL_72;
					IL_390:
					num3 = (parent.Parent as global::AcpBusinessLayer.Recordset).IndexOf(parent);
					num = (short)456130565;
					num2 = (int)((global::System.IntPtr)num);
				}
				IL_2D4:
				return (acpFeatureNode3[10168] as global::Motorola.MackinawCPS.CoreFeatures.TrunkingSystem.ChannelRangesMHzInnerSection).TrkSysOBTChannelAssignmentListTxEnable_A9517.Value;
				IL_376:
				num = (short)2083848192;
				if (num != 0)
				{
				}
				return (acpFeatureNode2[10168] as global::Motorola.MackinawCPS.CoreFeatures.TrunkingSystem.ChannelRangesMHzInnerSection).TrkSysOBTChannelAssignmentListTxEnable_A9517.Value;
				IL_44C:
				return (parent.Parent[0][10168] as global::Motorola.MackinawCPS.CoreFeatures.TrunkingSystem.ChannelRangesMHzInnerSection).TrkSysOBTChannelAssignmentListTxEnable_A9517.Value;
				IL_72:
				global::Motorola.MackinawCPS.CoreFeatures.TrunkingSystem.ChannelRangesMHzInnerSection channelRangesMHzInnerSection = self as global::Motorola.MackinawCPS.CoreFeatures.TrunkingSystem.ChannelRangesMHzInnerSection;
				trunkingSystem = (self.ParentRecset.ParentSection.Parent as global::Motorola.MackinawCPS.CoreFeatures.TrunkingSystem.TrunkingSystem);
				trkSysGeneralTypeIIFrequencyBand_A = trunkingSystem.General.TrkSysGeneralTypeIIFrequencyBand_A12491;
				parent = channelRangesMHzInnerSection.TrkSysOBTChannelAssignmentListTxEnable_A9517.Parent.Parent;
				acpFeatureNode2 = null;
				acpFeatureNode3 = null;
				num = (short)1805975552;
				short num5 = num;
				num = (short)1889271810;
				num2 = (int)((global::System.IntPtr)num);
				goto IL_27;
			}
			}
		}

		// Token: 0x06000BD2 RID: 3026 RVA: 0x000B8994 File Offset: 0x000B6B94
		internal static bool conTrkSysChanAssignTxEndFreqApp(global::AcpCommonLib.IAcpFeatureSection self)
		{
			short num = (short)397672448;
			int num2 = (int)num;
			switch (num2)
			{
			default:
			{
				switch (0)
				{
				case 0:
					goto IL_73;
				}
				global::AcpBusinessLayer.AcpListField trkSysGeneralTypeIIFrequencyBand_A;
				global::Motorola.MackinawCPS.CoreFeatures.TrunkingSystem.TrunkingSystem trunkingSystem;
				global::AcpCommonLib.IAcpFeatureNode parent;
				global::AcpCommonLib.IAcpFeatureNode acpFeatureNode2;
				global::AcpCommonLib.IAcpFeatureNode acpFeatureNode3;
				for (;;)
				{
					IL_28:
					int num3;
					switch (num2)
					{
					case 0:
						if (trkSysGeneralTypeIIFrequencyBand_A.Value != 1)
						{
							num = (short)1289420801;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_397;
					case 1:
						num = (short)1998913543;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 2:
						if (trunkingSystem.General.TrkSysGeneralSystemType_A9252.Value == 2)
						{
							num = (short)1860567044;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return false;
					case 3:
					{
						global::AcpCommonLib.IAcpFeatureNode acpFeatureNode = parent.Parent[0];
						acpFeatureNode2 = parent.Parent[1];
						acpFeatureNode3 = parent.Parent[2];
						if ((acpFeatureNode[10168] as global::Motorola.MackinawCPS.CoreFeatures.TrunkingSystem.ChannelRangesMHzInnerSection).TrkSysOBTChannelAssignmentListTxEnable_A9517.Value)
						{
							num = (short)83361807;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return false;
					}
					case 4:
						num = (short)95813645;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 5:
						switch (num3)
						{
						case 0:
							goto IL_453;
						case 1:
							num = (short)159645706;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 2:
							num = (short)2041053187;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						default:
							num = (short)2086928396;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						break;
					case 6:
					{
						num = (short)1366491137;
						if (num != 0)
						{
						}
						num = (short)1646506130;
						short num4 = num;
						num = (short)933474450;
						switch ((num4 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							continue;
						default:
							goto IL_37C;
						}
						break;
					}
					case 7:
						if (trkSysGeneralTypeIIFrequencyBand_A.Value == 2)
						{
							num = (short)372310024;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return false;
					case 8:
						goto IL_397;
					case 9:
						num = (short)931463168;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 10:
					{
						global::AcpCommonLib.IAcpFeatureNode acpFeatureNode4 = parent.Parent[0];
						acpFeatureNode2 = parent.Parent[1];
						if ((acpFeatureNode4[10168] as global::Motorola.MackinawCPS.CoreFeatures.TrunkingSystem.ChannelRangesMHzInnerSection).TrkSysOBTChannelAssignmentListTxEnable_A9517.Value)
						{
							num = (short)64159750;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return false;
					}
					case 11:
						goto IL_2AE;
					case 12:
						num = (short)49938448;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 13:
						if (trkSysGeneralTypeIIFrequencyBand_A.Value != 0)
						{
							num = (short)1612382217;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_397;
					case 14:
						if ((acpFeatureNode2[10168] as global::Motorola.MackinawCPS.CoreFeatures.TrunkingSystem.ChannelRangesMHzInnerSection).TrkSysOBTChannelAssignmentListTxEnable_A9517.Value)
						{
							num = (short)380567563;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return false;
					case 15:
						num = (short)855703566;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 16:
						return false;
					}
					goto IL_73;
					IL_397:
					num3 = (parent.Parent as global::AcpBusinessLayer.Recordset).IndexOf(parent);
					num = (short)752222213;
					num2 = (int)((global::System.IntPtr)num);
				}
				IL_2AE:
				return (acpFeatureNode3[10168] as global::Motorola.MackinawCPS.CoreFeatures.TrunkingSystem.ChannelRangesMHzInnerSection).TrkSysOBTChannelAssignmentListTxEnable_A9517.Value;
				IL_37C:
				num = (short)559415296;
				if (num != 0)
				{
				}
				return (acpFeatureNode2[10168] as global::Motorola.MackinawCPS.CoreFeatures.TrunkingSystem.ChannelRangesMHzInnerSection).TrkSysOBTChannelAssignmentListTxEnable_A9517.Value;
				IL_453:
				return (parent.Parent[0][10168] as global::Motorola.MackinawCPS.CoreFeatures.TrunkingSystem.ChannelRangesMHzInnerSection).TrkSysOBTChannelAssignmentListTxEnable_A9517.Value;
				IL_73:
				global::Motorola.MackinawCPS.CoreFeatures.TrunkingSystem.ChannelRangesMHzInnerSection channelRangesMHzInnerSection = self as global::Motorola.MackinawCPS.CoreFeatures.TrunkingSystem.ChannelRangesMHzInnerSection;
				trunkingSystem = (self.ParentRecset.ParentSection.Parent as global::Motorola.MackinawCPS.CoreFeatures.TrunkingSystem.TrunkingSystem);
				trkSysGeneralTypeIIFrequencyBand_A = trunkingSystem.General.TrkSysGeneralTypeIIFrequencyBand_A12491;
				parent = channelRangesMHzInnerSection.TrkSysOBTChannelAssignmentListTxEnable_A9517.Parent.Parent;
				acpFeatureNode2 = null;
				acpFeatureNode3 = null;
				num = (short)1978990592;
				short num5 = num;
				num = (short)178716674;
				num2 = (int)((global::System.IntPtr)num);
				goto IL_28;
			}
			}
		}

		// Token: 0x06000BD3 RID: 3027 RVA: 0x000B8E1C File Offset: 0x000B701C
		internal static void conSetValueOfRxStartChannelNumber(global::AcpCommonLib.IAcpFeatureSection self, global::AcpCommonLib.UndoRedo.ContainerTask task)
		{
			short num = (short)234160128;
			switch (num)
			{
			default:
			{
				num = (short)359137280;
				short num2 = num;
				global::Motorola.MackinawCPS.CoreFeatures.TrunkingSystem.ChannelRangesMHzInnerSection channelRangesMHzInnerSection = self as global::Motorola.MackinawCPS.CoreFeatures.TrunkingSystem.ChannelRangesMHzInnerSection;
				int newValue = 380;
				int num3 = 380;
				int newValue2 = 380;
				global::System.Collections.ObjectModel.Collection<global::AcpBusinessLayer.FeatureNode> collection = channelRangesMHzInnerSection.TrkSysOBTChannelAssignmentListRxStartChannelNumber_A20478.Parent.Parent.Parent as global::AcpBusinessLayer.Recordset;
				global::AcpCommonLib.IAcpFeatureNode acpFeatureNode = null;
				global::AcpCommonLib.IAcpFeatureNode acpFeatureNode2 = null;
				global::System.Collections.Generic.IEnumerator<global::AcpBusinessLayer.FeatureNode> enumerator = collection.GetEnumerator();
				try
				{
					num = (short)587530241;
					int num4 = (int)((global::System.IntPtr)num);
					for (;;)
					{
						global::AcpCommonLib.IAcpFeatureNode acpFeatureNode3;
						switch (num4)
						{
						case 1:
							switch (0)
							{
							case 0:
								goto IL_F4;
							}
							continue;
						case 2:
						{
							int num5;
							switch (num5)
							{
							case 0:
								acpFeatureNode = acpFeatureNode3;
								task.AddTask(new global::AcpBusinessLayer.UndoRedo.ModifyDataTask<int>((acpFeatureNode3[10168] as global::Motorola.MackinawCPS.CoreFeatures.TrunkingSystem.ChannelRangesMHzInnerSection).TrkSysOBTChannelAssignmentListRxStartChannelNumber_A20478, newValue));
								num = (short)380305413;
								num4 = (int)((global::System.IntPtr)num);
								continue;
							case 1:
								acpFeatureNode2 = acpFeatureNode3;
								num = (short)752025606;
								num4 = (int)((global::System.IntPtr)num);
								continue;
							case 2:
								num = (short)1919811595;
								num4 = (int)((global::System.IntPtr)num);
								continue;
							default:
								num = (short)1558642705;
								num4 = (int)((global::System.IntPtr)num);
								continue;
							}
							break;
						}
						case 3:
						{
							if (!enumerator.MoveNext())
							{
								num = (short)1719926793;
								num4 = (int)((global::System.IntPtr)num);
								continue;
							}
							acpFeatureNode3 = enumerator.Current;
							int num5 = (acpFeatureNode3.Parent as global::AcpBusinessLayer.Recordset).IndexOf(acpFeatureNode3);
							num = (short)511508481;
							if (num != 0)
							{
							}
							num = (short)9502722;
							num4 = (int)((global::System.IntPtr)num);
							continue;
						}
						case 4:
							goto IL_2CB;
						case 6:
							if ((acpFeatureNode3[10168] as global::Motorola.MackinawCPS.CoreFeatures.TrunkingSystem.ChannelRangesMHzInnerSection).TrkSysOBTChannelAssignmentListRxEnable_A9001.Value)
							{
								num = (short)1525153807;
								num4 = (int)((global::System.IntPtr)num);
								continue;
							}
							num3 = 380;
							num = (short)224002062;
							num4 = (int)((global::System.IntPtr)num);
							continue;
						case 7:
							newValue2 = num3 + (((acpFeatureNode2[10168] as global::Motorola.MackinawCPS.CoreFeatures.TrunkingSystem.ChannelRangesMHzInnerSection).TrkSysOBTChannelAssignmentListRxEndFrequencyMHz_A9012.Value - (acpFeatureNode2[10168] as global::Motorola.MackinawCPS.CoreFeatures.TrunkingSystem.ChannelRangesMHzInnerSection).TrkSysOBTChannelAssignmentListRxStartFrequencyMHz_A9029.Value) / (acpFeatureNode2[10168] as global::Motorola.MackinawCPS.CoreFeatures.TrunkingSystem.ChannelRangesMHzInnerSection).TrkSysOBTChannelAssignmentListRxSpacingKHz_A9004.Value + 1);
							num = (short)1288699917;
							num4 = (int)((global::System.IntPtr)num);
							continue;
						case 8:
							goto IL_232;
						case 9:
							num = (short)1678049290;
							num4 = (int)((global::System.IntPtr)num);
							continue;
						case 10:
							goto IL_4EC;
						case 11:
						{
							num = (short)461777133;
							short num6 = num;
							num = (short)1401235693;
							switch ((num6 == num) ? 1 : 0)
							{
							case 0:
							case 2:
								continue;
							default:
								num = (short)691142656;
								if (num != 0)
								{
								}
								if ((acpFeatureNode3[10168] as global::Motorola.MackinawCPS.CoreFeatures.TrunkingSystem.ChannelRangesMHzInnerSection).TrkSysOBTChannelAssignmentListRxEnable_A9001.Value)
								{
									num = (short)475922439;
									num4 = (int)((global::System.IntPtr)num);
									continue;
								}
								newValue2 = 380;
								num = (short)2024079364;
								num4 = (int)((global::System.IntPtr)num);
								continue;
							}
							break;
						}
						case 13:
							goto IL_2CB;
						case 14:
							goto IL_232;
						case 15:
							num3 = ((acpFeatureNode[10168] as global::Motorola.MackinawCPS.CoreFeatures.TrunkingSystem.ChannelRangesMHzInnerSection).TrkSysOBTChannelAssignmentListRxEndFrequencyMHz_A9012.Value - (acpFeatureNode[10168] as global::Motorola.MackinawCPS.CoreFeatures.TrunkingSystem.ChannelRangesMHzInnerSection).TrkSysOBTChannelAssignmentListRxStartFrequencyMHz_A9029.Value) / (acpFeatureNode[10168] as global::Motorola.MackinawCPS.CoreFeatures.TrunkingSystem.ChannelRangesMHzInnerSection).TrkSysOBTChannelAssignmentListRxSpacingKHz_A9004.Value + 381;
							num = (short)2024013832;
							num4 = (int)((global::System.IntPtr)num);
							continue;
						case 17:
							num = (short)852164624;
							num4 = (int)((global::System.IntPtr)num);
							continue;
						}
						IL_1F0:
						num = (short)1359937539;
						num4 = (int)((global::System.IntPtr)num);
						continue;
						IL_F4:
						goto IL_1F0;
						IL_232:
						task.AddTask(new global::AcpBusinessLayer.UndoRedo.ModifyDataTask<int>((acpFeatureNode3[10168] as global::Motorola.MackinawCPS.CoreFeatures.TrunkingSystem.ChannelRangesMHzInnerSection).TrkSysOBTChannelAssignmentListRxStartChannelNumber_A20478, num3));
						num = (short)2099707904;
						num4 = (int)((global::System.IntPtr)num);
						continue;
						IL_2CB:
						task.AddTask(new global::AcpBusinessLayer.UndoRedo.ModifyDataTask<int>((acpFeatureNode3[10168] as global::Motorola.MackinawCPS.CoreFeatures.TrunkingSystem.ChannelRangesMHzInnerSection).TrkSysOBTChannelAssignmentListRxStartChannelNumber_A20478, newValue2));
						num = (short)642711564;
						num4 = (int)((global::System.IntPtr)num);
					}
					IL_4EC:;
				}
				finally
				{
					num = (short)58654721;
					int num4 = (int)((global::System.IntPtr)num);
					for (;;)
					{
						switch (num4)
						{
						case 0:
							enumerator.Dispose();
							num = (short)1370947586;
							num4 = (int)((global::System.IntPtr)num);
							continue;
						case 1:
							switch (0)
							{
							case 0:
								goto IL_520;
							}
							continue;
						case 2:
							goto IL_558;
						}
						IL_520:
						if (enumerator == null)
						{
							break;
						}
						num = (short)260767744;
						num4 = (int)((global::System.IntPtr)num);
					}
					IL_558:;
				}
				return;
			}
			}
		}

		// Token: 0x06000BD4 RID: 3028 RVA: 0x000B93A0 File Offset: 0x000B75A0
		public static void conSetValueOfTxStartChannelNumber(global::AcpCommonLib.IAcpFeatureSection self, global::AcpCommonLib.UndoRedo.ContainerTask task)
		{
			short num = (short)957874176;
			switch (num)
			{
			default:
			{
				global::Motorola.MackinawCPS.CoreFeatures.TrunkingSystem.ChannelRangesMHzInnerSection channelRangesMHzInnerSection = self as global::Motorola.MackinawCPS.CoreFeatures.TrunkingSystem.ChannelRangesMHzInnerSection;
				global::Motorola.MackinawCPS.CoreFeatures.TrunkingSystem.ChannelRangesMHzInnerRecset channelRangesMHzInnerRecset = self.ParentRecset as global::Motorola.MackinawCPS.CoreFeatures.TrunkingSystem.ChannelRangesMHzInnerRecset;
				global::AcpBusinessLayer.AcpField<int> trkSysOBTChannelAssignmentListTxStartChannelNumber_A = channelRangesMHzInnerSection.TrkSysOBTChannelAssignmentListTxStartChannelNumber_A20479;
				int num2 = 0;
				int num3 = 0;
				int num4 = 0;
				int num5 = 0;
				global::System.Collections.Generic.IEnumerator<global::AcpBusinessLayer.FeatureNode> enumerator = channelRangesMHzInnerRecset.GetEnumerator();
				try
				{
					num = (short)555745281;
					int num6 = (int)((global::System.IntPtr)num);
					for (;;)
					{
						global::AcpCommonLib.IAcpFeatureNode acpFeatureNode;
						switch (num6)
						{
						case 0:
							goto IL_51E;
						case 1:
							switch (0)
							{
							case 0:
								goto IL_CF;
							}
							continue;
						case 2:
							if ((acpFeatureNode[10168] as global::Motorola.MackinawCPS.CoreFeatures.TrunkingSystem.ChannelRangesMHzInnerSection).TrkSysOBTChannelAssignmentListTxEnable_A9517.Value)
							{
								num = (short)362741767;
								num6 = (int)((global::System.IntPtr)num);
								continue;
							}
							goto IL_48D;
						case 3:
							num5 = (num3 - num2) / num4 + 1;
							task.AddTask(new global::AcpBusinessLayer.UndoRedo.ModifyDataTask<int>(trkSysOBTChannelAssignmentListTxStartChannelNumber_A, num5));
							num = (short)1030750216;
							num6 = (int)((global::System.IntPtr)num);
							continue;
						case 4:
							goto IL_4B8;
						case 5:
							if ((acpFeatureNode.Parent as global::AcpBusinessLayer.Recordset).IndexOf(acpFeatureNode) == 2)
							{
								num = (short)1010630666;
								num6 = (int)((global::System.IntPtr)num);
								continue;
							}
							break;
						case 6:
							task.AddTask(new global::AcpBusinessLayer.UndoRedo.ModifyDataTask<int>(trkSysOBTChannelAssignmentListTxStartChannelNumber_A, 0));
							num2 = (acpFeatureNode[10168] as global::Motorola.MackinawCPS.CoreFeatures.TrunkingSystem.ChannelRangesMHzInnerSection).TrkSysOBTChannelAssignmentListTxStartFrequencyMHz_A9568.Value;
							num3 = (acpFeatureNode[10168] as global::Motorola.MackinawCPS.CoreFeatures.TrunkingSystem.ChannelRangesMHzInnerSection).TrkSysOBTChannelAssignmentListTxEndFrequencyMHz_A9529.Value;
							num4 = (acpFeatureNode[10168] as global::Motorola.MackinawCPS.CoreFeatures.TrunkingSystem.ChannelRangesMHzInnerSection).TrkSysOBTChannelAssignmentListTxSpacingKHz_A9520.Value;
							num = (short)1596063764;
							num6 = (int)((global::System.IntPtr)num);
							continue;
						case 7:
							num = (short)591790096;
							num6 = (int)((global::System.IntPtr)num);
							continue;
						case 8:
							goto IL_2A0;
						case 9:
							if (num3 >= num2)
							{
								num = (short)1130889234;
								num6 = (int)((global::System.IntPtr)num);
								continue;
							}
							goto IL_361;
						case 10:
							trkSysOBTChannelAssignmentListTxStartChannelNumber_A = (acpFeatureNode[10168] as global::Motorola.MackinawCPS.CoreFeatures.TrunkingSystem.ChannelRangesMHzInnerSection).TrkSysOBTChannelAssignmentListTxStartChannelNumber_A20479;
							num = (short)1633419286;
							num6 = (int)((global::System.IntPtr)num);
							continue;
						case 12:
							num = (short)240582656;
							num6 = (int)((global::System.IntPtr)num);
							continue;
						case 13:
							trkSysOBTChannelAssignmentListTxStartChannelNumber_A = (acpFeatureNode[10168] as global::Motorola.MackinawCPS.CoreFeatures.TrunkingSystem.ChannelRangesMHzInnerSection).TrkSysOBTChannelAssignmentListTxStartChannelNumber_A20479;
							num = (short)1539964930;
							num6 = (int)((global::System.IntPtr)num);
							continue;
						case 14:
							if (!enumerator.MoveNext())
							{
								num = (short)1912995852;
								num6 = (int)((global::System.IntPtr)num);
								continue;
							}
							acpFeatureNode = enumerator.Current;
							num = (short)1765867537;
							num6 = (int)((global::System.IntPtr)num);
							continue;
						case 15:
							if ((acpFeatureNode.Parent as global::AcpBusinessLayer.Recordset).IndexOf(acpFeatureNode) == 1)
							{
								num = (short)225247245;
								num6 = (int)((global::System.IntPtr)num);
								continue;
							}
							goto IL_4B8;
						case 16:
							if (num3 >= num2)
							{
								num = (short)450166787;
								num6 = (int)((global::System.IntPtr)num);
								continue;
							}
							goto IL_48D;
						case 17:
							if ((acpFeatureNode.Parent as global::AcpBusinessLayer.Recordset).IndexOf(acpFeatureNode) == 0)
							{
								num = (short)1359937542;
								num6 = (int)((global::System.IntPtr)num);
								continue;
							}
							goto IL_312;
						case 18:
							task.AddTask(new global::AcpBusinessLayer.UndoRedo.ModifyDataTask<int>(trkSysOBTChannelAssignmentListTxStartChannelNumber_A, num5 + (num3 - num2) / num4 + 1));
							num = (short)555876363;
							num6 = (int)((global::System.IntPtr)num);
							continue;
						case 19:
							num = (short)926023689;
							num6 = (int)((global::System.IntPtr)num);
							continue;
						case 20:
							goto IL_312;
						case 22:
							if ((acpFeatureNode[10168] as global::Motorola.MackinawCPS.CoreFeatures.TrunkingSystem.ChannelRangesMHzInnerSection).TrkSysOBTChannelAssignmentListTxEnable_A9517.Value)
							{
								num = (short)1931542547;
								num6 = (int)((global::System.IntPtr)num);
								continue;
							}
							goto IL_361;
						case 23:
							goto IL_2A0;
						}
						IL_25F:
						num = (short)1009909774;
						num6 = (int)((global::System.IntPtr)num);
						continue;
						IL_CF:
						goto IL_25F;
						IL_2A0:
						num2 = (acpFeatureNode[10168] as global::Motorola.MackinawCPS.CoreFeatures.TrunkingSystem.ChannelRangesMHzInnerSection).TrkSysOBTChannelAssignmentListTxStartFrequencyMHz_A9568.Value;
						num3 = (acpFeatureNode[10168] as global::Motorola.MackinawCPS.CoreFeatures.TrunkingSystem.ChannelRangesMHzInnerSection).TrkSysOBTChannelAssignmentListTxEndFrequencyMHz_A9529.Value;
						num4 = (acpFeatureNode[10168] as global::Motorola.MackinawCPS.CoreFeatures.TrunkingSystem.ChannelRangesMHzInnerSection).TrkSysOBTChannelAssignmentListTxSpacingKHz_A9520.Value;
						num = (short)1337786372;
						num6 = (int)((global::System.IntPtr)num);
						continue;
						IL_312:
						num = (short)809762831;
						num6 = (int)((global::System.IntPtr)num);
						continue;
						IL_361:
						task.AddTask(new global::AcpBusinessLayer.UndoRedo.ModifyDataTask<int>(trkSysOBTChannelAssignmentListTxStartChannelNumber_A, 0));
						num = (short)1486815253;
						num6 = (int)((global::System.IntPtr)num);
						continue;
						IL_48D:
						task.AddTask(new global::AcpBusinessLayer.UndoRedo.ModifyDataTask<int>(trkSysOBTChannelAssignmentListTxStartChannelNumber_A, 0));
						num = (short)1304756247;
						num6 = (int)((global::System.IntPtr)num);
						continue;
						IL_4B8:
						num = (short)741998597;
						num6 = (int)((global::System.IntPtr)num);
					}
					IL_51E:;
				}
				finally
				{
					num = (short)1335296002;
					int num6 = (int)((global::System.IntPtr)num);
					for (;;)
					{
						switch (num6)
						{
						case 0:
							goto IL_5DF;
						case 1:
						{
							enumerator.Dispose();
							num = (short)930654269;
							short num7 = num;
							num = (short)500148285;
							switch ((num7 == num) ? 1 : 0)
							{
							case 0:
							case 2:
								goto IL_539;
							default:
								num = (short)652935168;
								if (num != 0)
								{
								}
								num = (short)334626816;
								num6 = (int)((global::System.IntPtr)num);
								continue;
							}
							break;
						}
						case 2:
							goto IL_539;
						}
						goto IL_556;
						IL_539:
						switch (0)
						{
						case 0:
							IL_556:
							if (enumerator == null)
							{
								goto IL_60A;
							}
							num = (short)1626406913;
							num6 = (int)((global::System.IntPtr)num);
							break;
						}
					}
					IL_5DF:
					num = (short)587726849;
					if (num != 0)
					{
					}
					IL_60A:;
				}
				num = (short)890634240;
				short num8 = num;
				return;
			}
			}
		}

		// Token: 0x06000BD5 RID: 3029 RVA: 0x000B9A00 File Offset: 0x000B7C00
		internal static bool conValidateSiteIDRangeBasedOnSystemType(global::AcpCommonLib.IAcpFeatureSection self)
		{
			short num = (short)1989279744;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				global::AcpBusinessLayer.AcpSimpleRangeField trkSysGeneralSiteID_A;
				switch (num2)
				{
				case 0:
					switch (0)
					{
					case 0:
						goto IL_3C;
					}
					continue;
				case 1:
					if (trkSysGeneralSiteID_A.Value <= 254)
					{
						num = (short)1337720833;
						if (num != 0)
						{
						}
						num = (short)413532163;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_115;
				case 2:
					num = (short)891420673;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 3:
					return true;
				case 4:
					if (trkSysGeneralSiteID_A.Value >= 1)
					{
						num = (short)291241986;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_115;
				case 5:
					num = (short)2012807172;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				IL_3C:
				global::Motorola.MackinawCPS.CoreFeatures.TrunkingSystem.General general = self as global::Motorola.MackinawCPS.CoreFeatures.TrunkingSystem.General;
				trkSysGeneralSiteID_A = general.TrkSysGeneralSiteID_A9150;
				if (general.TrkSysGeneralSystemType_A9252.Value == 3)
				{
					num = (short)417071109;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				return true;
				IL_115:
				num = (short)1010963523;
				short num3 = num;
				num = (short)1929319491;
				switch ((num3 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					continue;
				case 1:
					goto IL_172;
				}
				goto Block_4;
			}
			return true;
			Block_4:
			num = (short)1238499328;
			short num4 = num;
			IL_172:
			num = (short)1852178432;
			if (num != 0)
			{
			}
			return false;
		}

		// Token: 0x06000BD6 RID: 3030 RVA: 0x000B9B98 File Offset: 0x000B7D98
		public static bool conRxEnableOnFirstRowMustBeEnabled(global::AcpCommonLib.IAcpFeatureSection self)
		{
			short num = (short)920256512;
			int num2 = (int)num;
			switch (num2)
			{
			default:
			{
				switch (0)
				{
				case 0:
					goto IL_73;
				}
				global::AcpCommonLib.IAcpFeatureNode parent;
				global::System.Collections.Generic.IEnumerator<global::AcpBusinessLayer.FeatureNode> enumerator;
				for (;;)
				{
					IL_28:
					int num4;
					switch (num2)
					{
					case 0:
						num = (short)1582563331;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 1:
					{
						global::AcpCommonLib.IAcpFeatureNode acpFeatureNode = self.Parent.Parent[2];
						num = (short)872939525;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 2:
						goto IL_598;
					case 3:
					{
						int num3;
						if (num3 != 0)
						{
							num = (short)866713613;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_199;
					}
					case 4:
						if (self.Parent.Parent.Count == 3)
						{
							num = (short)1350041601;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return true;
					case 5:
					{
						int value = (parent[10168] as global::Motorola.MackinawCPS.CoreFeatures.TrunkingSystem.ChannelRangesMHzInnerSection).TrkSysOBTChannelAssignmentListRxEnable_A9001.Value ? 1 : 0;
						global::AcpCommonLib.IAcpFeatureNode acpFeatureNode;
						bool value2 = (acpFeatureNode[10168] as global::Motorola.MackinawCPS.CoreFeatures.TrunkingSystem.ChannelRangesMHzInnerSection).TrkSysOBTChannelAssignmentListRxEnable_A9001.Value;
						if (value == 0 && value2)
						{
							num = (short)147849230;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return true;
					}
					case 6:
						num = (short)444203015;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 7:
						return true;
					case 8:
					{
						int num3;
						if (num4 != num3)
						{
							num = (short)1772355596;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_2DD;
					}
					case 9:
						goto IL_2DD;
					case 10:
					{
						try
						{
							num = (short)1552023552;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								switch (num2)
								{
								case 0:
									switch (0)
									{
									case 0:
										goto IL_343;
									}
									continue;
								case 1:
								{
									global::AcpBusinessLayer.FeatureNode featureNode;
									if (featureNode is global::Motorola.MackinawCPS.CoreFeatures.TrunkingPersonality.TrunkingPersonality)
									{
										num = (short)249102341;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									break;
								}
								case 2:
									goto IL_47D;
								case 3:
									num = (short)567607298;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 5:
								{
									global::AcpBusinessLayer.FeatureNode featureNode;
									global::Motorola.MackinawCPS.CoreFeatures.TrunkingPersonality.TrunkingPersonality trunkingPersonality = featureNode as global::Motorola.MackinawCPS.CoreFeatures.TrunkingPersonality.TrunkingPersonality;
									trunkingPersonality.Talkgroup.CalculateApplicability();
									trunkingPersonality.Talkgroup.CalculateValidity();
									trunkingPersonality.AnnouncementGroup.TrkPerAnnouncementGroupAGFailsoftRxFrequencyMHz_A9582.CalculateValidity();
									trunkingPersonality.AnnouncementGroup.TrkPerAnnouncementGroupAGSecondaryFSRxFrequencyMHz_A8895.CalculateValidity();
									trunkingPersonality.General.TrkPerGeneralSecondaryRxFrequencyMHz_A8904.CalculateApplicability();
									trunkingPersonality.General.TrkPerGeneralSecondaryRxFrequencyMHz_A8904.CalculateValidity();
									trunkingPersonality.General.TrkPerGeneralRxFrequencyMHz_A8910.CalculateApplicability();
									trunkingPersonality.General.TrkPerGeneralRxFrequencyMHz_A8910.CalculateValidity();
									num = (short)1260650500;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 6:
								{
									if (!enumerator.MoveNext())
									{
										num = (short)1327759363;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									global::AcpBusinessLayer.FeatureNode featureNode = enumerator.Current;
									num = (short)1961754625;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								}
								IL_348:
								num = (short)1313996806;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								IL_343:
								goto IL_348;
							}
							IL_47D:
							goto IL_1F1;
						}
						finally
						{
							num = (short)841023490;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								switch (num2)
								{
								case 0:
									goto IL_53D;
								case 1:
								{
									enumerator.Dispose();
									num = (short)1033329060;
									short num5 = num;
									num = (short)1429559716;
									switch ((num5 == num) ? 1 : 0)
									{
									case 0:
									case 2:
										goto IL_497;
									default:
										num = (short)425263104;
										if (num != 0)
										{
										}
										num = (short)822476800;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									break;
								}
								case 2:
									goto IL_497;
								}
								goto IL_4B4;
								IL_497:
								switch (0)
								{
								case 0:
									IL_4B4:
									if (enumerator == null)
									{
										goto IL_53F;
									}
									num = (short)1817378817;
									num2 = (int)((global::System.IntPtr)num);
									break;
								}
							}
							IL_53D:
							IL_53F:;
						}
						goto IL_540;
						IL_1F1:
						parent = self.Parent;
						int num3 = (parent.Parent as global::AcpBusinessLayer.Recordset).IndexOf(parent);
						num4 = 0;
						num = (short)498401291;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 11:
						goto IL_598;
					case 12:
						goto IL_540;
					case 13:
						num = (short)1174601744;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 14:
						goto IL_2B1;
					case 15:
						if (num4 >= parent.Parent.Count)
						{
							num = (short)1564999680;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)858390536;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 16:
					{
						int num3;
						if (num3 != 1)
						{
							num = (short)1264123910;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)1675558916;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					}
					goto IL_73;
					IL_2DD:
					num4++;
					num = (short)1983774722;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_540:
					parent.Parent[num4].CalculateApplicability();
					num = (short)1801388032;
					short num6 = num;
					num = (short)1564082185;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_598:
					num = (short)267845647;
					num2 = (int)((global::System.IntPtr)num);
				}
				IL_199:
				return (parent[10168] as global::Motorola.MackinawCPS.CoreFeatures.TrunkingSystem.ChannelRangesMHzInnerSection).TrkSysOBTChannelAssignmentListRxEnable_A9001.Value;
				IL_2B1:
				num = (short)2003763201;
				if (num != 0)
				{
				}
				return false;
				IL_73:
				global::AcpBusinessLayer.FeatureNode featureNode2 = self.Parent.Parent.ParentSection.Parent as global::AcpBusinessLayer.FeatureNode;
				global::Motorola.MackinawCPS.CoreFeatures.TrunkingSystem.TrunkingSystem trunkingSystem = featureNode2 as global::Motorola.MackinawCPS.CoreFeatures.TrunkingSystem.TrunkingSystem;
				trunkingSystem.ControlChannels.CalculateApplicability();
				trunkingSystem.ControlChannels.CalculateValidity();
				enumerator = featureNode2.ReferencingNodes.GetEnumerator();
				num = (short)2045771786;
				num2 = (int)((global::System.IntPtr)num);
				goto IL_28;
			}
			}
		}

		// Token: 0x06000BD7 RID: 3031 RVA: 0x000BA1C4 File Offset: 0x000B83C4
		public static bool conTxEnableOnFirstRowMustBeEnabled(global::AcpCommonLib.IAcpFeatureSection self)
		{
			short num = (short)381747200;
			int num2 = (int)num;
			switch (num2)
			{
			default:
			{
				switch (0)
				{
				case 0:
					goto IL_72;
				}
				global::AcpCommonLib.IAcpFeatureNode parent;
				global::System.Collections.Generic.IEnumerator<global::AcpBusinessLayer.FeatureNode> enumerator;
				for (;;)
				{
					IL_27:
					int num4;
					switch (num2)
					{
					case 0:
						num = (short)2088042499;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 1:
					{
						num = (short)667222017;
						if (num != 0)
						{
						}
						global::AcpCommonLib.IAcpFeatureNode acpFeatureNode = self.Parent.Parent[2];
						num = (short)1918500869;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 2:
						goto IL_58D;
					case 3:
					{
						int num3;
						if (num3 != 0)
						{
							num = (short)2075983885;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_195;
					}
					case 4:
						if (self.Parent.Parent.Count == 3)
						{
							num = (short)1981218817;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return true;
					case 5:
					{
						int value = (parent[10168] as global::Motorola.MackinawCPS.CoreFeatures.TrunkingSystem.ChannelRangesMHzInnerSection).TrkSysOBTChannelAssignmentListTxEnable_A9517.Value ? 1 : 0;
						global::AcpCommonLib.IAcpFeatureNode acpFeatureNode;
						bool value2 = (acpFeatureNode[10168] as global::Motorola.MackinawCPS.CoreFeatures.TrunkingSystem.ChannelRangesMHzInnerSection).TrkSysOBTChannelAssignmentListTxEnable_A9517.Value;
						if (value == 0 && value2)
						{
							num = (short)1132593166;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return true;
					}
					case 6:
						num = (short)1856372743;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 7:
						return true;
					case 8:
					{
						int num3;
						if (num4 != num3)
						{
							num = (short)554631180;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_2D8;
					}
					case 9:
						goto IL_2D8;
					case 10:
					{
						try
						{
							num = (short)984088576;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								switch (num2)
								{
								case 0:
									switch (0)
									{
									case 0:
										goto IL_33D;
									}
									continue;
								case 1:
								{
									global::AcpBusinessLayer.FeatureNode featureNode;
									if (featureNode is global::Motorola.MackinawCPS.CoreFeatures.TrunkingPersonality.TrunkingPersonality)
									{
										num = (short)1611399173;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									break;
								}
								case 2:
									goto IL_475;
								case 3:
									num = (short)1894187010;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 5:
								{
									global::AcpBusinessLayer.FeatureNode featureNode;
									global::Motorola.MackinawCPS.CoreFeatures.TrunkingPersonality.TrunkingPersonality trunkingPersonality = featureNode as global::Motorola.MackinawCPS.CoreFeatures.TrunkingPersonality.TrunkingPersonality;
									trunkingPersonality.Talkgroup.CalculateApplicability();
									trunkingPersonality.Talkgroup.CalculateValidity();
									trunkingPersonality.AnnouncementGroup.TrkPerAnnouncementGroupAGSecondaryFSTxFrequencyMHz_A12903.CalculateValidity();
									trunkingPersonality.AnnouncementGroup.TrkPerAnnouncementGroupAGFailsoftTxFrequencyMHz_A9583.CalculateValidity();
									trunkingPersonality.General.TrkPerGeneralTxFrequencyMHz_A9413.CalculateApplicability();
									trunkingPersonality.General.TrkPerGeneralTxFrequencyMHz_A9413.CalculateValidity();
									trunkingPersonality.General.TrkPerGeneralSecondaryTxFrequencyMHz_A12902.CalculateApplicability();
									trunkingPersonality.General.TrkPerGeneralSecondaryTxFrequencyMHz_A12902.CalculateValidity();
									num = (short)1218576388;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 6:
								{
									if (!enumerator.MoveNext())
									{
										num = (short)62586883;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									global::AcpBusinessLayer.FeatureNode featureNode = enumerator.Current;
									num = (short)44826625;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								}
								IL_342:
								num = (short)1257111558;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								IL_33D:
								goto IL_342;
							}
							IL_475:
							goto IL_1EA;
						}
						finally
						{
							num = (short)1410465794;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								switch (num2)
								{
								case 0:
									goto IL_532;
								case 1:
								{
									enumerator.Dispose();
									num = (short)612313968;
									short num5 = num;
									num = (short)262286192;
									switch ((num5 == num) ? 1 : 0)
									{
									case 0:
									case 2:
										goto IL_48F;
									default:
										num = (short)623050752;
										if (num != 0)
										{
										}
										num = (short)462159872;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									break;
								}
								case 2:
									goto IL_48F;
								}
								goto IL_4AC;
								IL_48F:
								switch (0)
								{
								case 0:
									IL_4AC:
									if (enumerator == null)
									{
										goto IL_534;
									}
									num = (short)1649213441;
									num2 = (int)((global::System.IntPtr)num);
									break;
								}
							}
							IL_532:
							IL_534:;
						}
						goto IL_535;
						IL_1EA:
						parent = self.Parent;
						int num3 = (parent.Parent as global::AcpBusinessLayer.Recordset).IndexOf(parent);
						num4 = 0;
						num = (short)1358561291;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 11:
						goto IL_58D;
					case 12:
						goto IL_535;
					case 13:
						num = (short)169476112;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 14:
						return false;
					case 15:
						if (num4 >= parent.Parent.Count)
						{
							num = (short)697368576;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)1379860488;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 16:
					{
						int num3;
						if (num3 != 1)
						{
							num = (short)746782726;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)566951940;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					}
					goto IL_72;
					IL_2D8:
					num4++;
					num = (short)620363778;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_535:
					parent.Parent[num4].CalculateApplicability();
					num = (short)1438253056;
					short num6 = num;
					num = (short)946995209;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_58D:
					num = (short)76283919;
					num2 = (int)((global::System.IntPtr)num);
				}
				IL_195:
				return (parent[10168] as global::Motorola.MackinawCPS.CoreFeatures.TrunkingSystem.ChannelRangesMHzInnerSection).TrkSysOBTChannelAssignmentListTxEnable_A9517.Value;
				IL_72:
				global::AcpBusinessLayer.FeatureNode featureNode2 = self.Parent.Parent.ParentSection.Parent as global::AcpBusinessLayer.FeatureNode;
				global::Motorola.MackinawCPS.CoreFeatures.TrunkingSystem.TrunkingSystem trunkingSystem = featureNode2 as global::Motorola.MackinawCPS.CoreFeatures.TrunkingSystem.TrunkingSystem;
				trunkingSystem.ControlChannels.CalculateApplicability();
				trunkingSystem.ControlChannels.CalculateValidity();
				enumerator = featureNode2.ReferencingNodes.GetEnumerator();
				num = (short)20119562;
				num2 = (int)((global::System.IntPtr)num);
				goto IL_27;
			}
			}
		}

		// Token: 0x06000BD8 RID: 3032 RVA: 0x000BA7E4 File Offset: 0x000B89E4
		public static bool ConIdentifierEnableOnFirstRowMustBeEnabled(global::AcpCommonLib.IAcpFeatureSection self)
		{
			short num = (short)1952841728;
			int num2 = (int)num;
			switch (num2)
			{
			default:
			{
				switch (0)
				{
				case 0:
					goto IL_4E;
				}
				bool result;
				global::AcpBusinessLayer.AcpFieldX<bool, bool> trkSysASTRO25ChannelIDIdentifierEnable_A;
				for (;;)
				{
					IL_27:
					global::System.Collections.Generic.IEnumerator<global::AcpBusinessLayer.FeatureNode> enumerator;
					switch (num2)
					{
					case 0:
						goto IL_B8;
					case 1:
						goto IL_B8;
					case 2:
						result = true;
						num = (short)407502849;
						if (num != 0)
						{
						}
						num = (short)2109407236;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 3:
						if (!trkSysASTRO25ChannelIDIdentifierEnable_A.Value)
						{
							num = (short)253820930;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_72D;
					case 4:
						goto IL_B8;
					case 5:
						num = (short)1350303747;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 6:
						try
						{
							num = (short)2067202059;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								global::Motorola.MackinawCPS.CoreFeatures.TrunkingPersonality.TrunkingPersonality trunkingPersonality;
								int num4;
								global::AcpCommonLib.IAcpRecordset embeddedRecset;
								switch (num2)
								{
								case 0:
									goto IL_27A;
								case 1:
									num = (short)631439382;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 2:
								{
									global::AcpBusinessLayer.FeatureNode featureNode;
									if (featureNode is global::Motorola.MackinawCPS.CoreFeatures.TrunkingPersonality.TrunkingPersonality)
									{
										num = (short)1963327503;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									break;
								}
								case 3:
									goto IL_600;
								case 4:
									goto IL_6BB;
								case 5:
								{
									global::Motorola.MackinawCPS.CoreFeatures.TrunkingPersonality.TalkgroupInnerSection talkgroupInnerSection;
									talkgroupInnerSection.TrkPerTalkgroupFailsoftRxFrequencyMHz_A8001.CalculateValidity();
									talkgroupInnerSection.TrkPerTalkgroupFailsoftTxFrequencyMHz_A8003.CalculateValidity();
									num = (short)438501390;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 6:
								{
									global::Motorola.MackinawCPS.CoreFeatures.TrunkingPersonality.TalkgroupInnerSection talkgroupInnerSection;
									talkgroupInnerSection.TrkPerTalkgroupSecondaryFailsoftRxFrequencyMHz_A8900.CalculateValidity();
									talkgroupInnerSection.TrkPerTalkgroupSecondaryFailsoftTxFrequencyMHz_A8902.CalculateValidity();
									num = (short)921305105;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 7:
									if (trunkingPersonality.AnnouncementGroup.TrkPerAnnouncementGroupAnnouncementGroupFailsoft_A8597.Value)
									{
										num = (short)491847690;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									goto IL_4C1;
								case 8:
									if (trunkingPersonality.General.TrkPerGeneralFailsoftType_A8599.Value == 2)
									{
										num = (short)892534802;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									break;
								case 9:
								{
									global::Motorola.MackinawCPS.CoreFeatures.TrunkingPersonality.TalkgroupInnerSection talkgroupInnerSection;
									if (talkgroupInnerSection.TrkPerTalkgroupTalkgroupFailsoft_A8005.Value)
									{
										num = (short)1163788293;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									goto IL_477;
								}
								case 10:
								{
									trunkingPersonality.AnnouncementGroup.TrkPerAnnouncementGroupAGFailsoftRxFrequencyMHz_A9582.CalculateValidity();
									trunkingPersonality.AnnouncementGroup.TrkPerAnnouncementGroupAGSecondaryFSRxFrequencyMHz_A8895.CalculateValidity();
									num = (short)1301506659;
									short num3 = num;
									num = (short)837249635;
									switch ((num3 == num) ? 1 : 0)
									{
									case 0:
									case 2:
										goto IL_69D;
									default:
										num = (short)749666304;
										if (num != 0)
										{
										}
										num = (short)43319309;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									break;
								}
								case 11:
									switch (0)
									{
									case 0:
										goto IL_275;
									}
									continue;
								case 12:
								{
									global::Motorola.MackinawCPS.CoreFeatures.TrunkingPersonality.TalkgroupInnerSection talkgroupInnerSection;
									if (talkgroupInnerSection.TrkPerTalkgroupTGSecondaryFailsoft_A19989.Value)
									{
										num = (short)205520902;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									goto IL_59B;
								}
								case 13:
									goto IL_4C1;
								case 14:
									goto IL_477;
								case 15:
								{
									global::AcpBusinessLayer.FeatureNode featureNode;
									trunkingPersonality = (featureNode as global::Motorola.MackinawCPS.CoreFeatures.TrunkingPersonality.TrunkingPersonality);
									num = (short)1443627016;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 16:
									if (trunkingPersonality.AnnouncementGroup.TrkPerAnnouncementGroupAGSecondaryFailsoft_A19990.Value)
									{
										num = (short)2129920019;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									break;
								case 17:
									goto IL_59B;
								case 18:
									goto IL_69D;
								case 19:
									trunkingPersonality.AnnouncementGroup.TrkPerAnnouncementGroupAGSecondaryFSTxFrequencyMHz_A12903.CalculateValidity();
									trunkingPersonality.AnnouncementGroup.TrkPerAnnouncementGroupAGFailsoftTxFrequencyMHz_A9583.CalculateValidity();
									num = (short)2141454359;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 20:
									goto IL_27A;
								case 21:
								{
									if (!enumerator.MoveNext())
									{
										num = (short)2132475928;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									global::AcpBusinessLayer.FeatureNode featureNode = enumerator.Current;
									num = (short)42795010;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 22:
								{
									if (num4 >= embeddedRecset.Count)
									{
										num = (short)730333187;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									global::Motorola.MackinawCPS.CoreFeatures.TrunkingPersonality.TalkgroupInnerSection talkgroupInnerSection = embeddedRecset[num4][10180] as global::Motorola.MackinawCPS.CoreFeatures.TrunkingPersonality.TalkgroupInnerSection;
									num = (short)1340669961;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 24:
									num = (short)1098252292;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 25:
									if (embeddedRecset != null)
									{
										num = (short)341049345;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									goto IL_600;
								}
								goto IL_275;
								IL_27A:
								num = (short)2096955417;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								IL_354:
								num = (short)71106581;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								IL_275:
								goto IL_354;
								IL_477:
								num = (short)1044774924;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								IL_4C1:
								num = (short)839516176;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								IL_59B:
								num4++;
								num = (short)1051328532;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								IL_600:
								num = (short)2108620807;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								IL_69D:
								embeddedRecset = trunkingPersonality[10179].EmbeddedRecset;
								num4 = 0;
								num = (short)57278464;
								num2 = (int)((global::System.IntPtr)num);
							}
							IL_6BB:
							return result;
						}
						finally
						{
							num = (short)713621506;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								switch (num2)
								{
								case 0:
									enumerator.Dispose();
									num = (short)195952641;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 1:
									goto IL_72A;
								case 2:
									switch (0)
									{
									case 0:
										goto IL_6F3;
									}
									continue;
								}
								IL_6F3:
								if (enumerator == null)
								{
									break;
								}
								num = (short)2023948288;
								num2 = (int)((global::System.IntPtr)num);
							}
							IL_72A:;
						}
						goto IL_72D;
					case 7:
					{
						if ((trkSysASTRO25ChannelIDIdentifierEnable_A.Parent.Parent.Parent as global::AcpBusinessLayer.Recordset).IndexOf(trkSysASTRO25ChannelIDIdentifierEnable_A.Parent.Parent) == 0)
						{
							num = (short)827392005;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)155189248;
						short num5 = num;
						result = true;
						num = (short)1553137665;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					}
					goto IL_4E;
					IL_B8:
					global::AcpBusinessLayer.FeatureNode featureNode2 = self.Parent.Parent.ParentSection.Parent as global::AcpBusinessLayer.FeatureNode;
					global::Motorola.MackinawCPS.CoreFeatures.TrunkingSystem.TrunkingSystem trunkingSystem = featureNode2 as global::Motorola.MackinawCPS.CoreFeatures.TrunkingSystem.TrunkingSystem;
					trunkingSystem.ControlChannels.CalculateApplicability();
					trunkingSystem.ControlChannels.CalculateValidity();
					enumerator = featureNode2.ReferencingNodes.GetEnumerator();
					num = (short)1244200966;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_72D:
					result = false;
					num = (short)1907818496;
					num2 = (int)((global::System.IntPtr)num);
				}
				return result;
				IL_4E:
				trkSysASTRO25ChannelIDIdentifierEnable_A = (self as global::Motorola.MackinawCPS.CoreFeatures.TrunkingSystem.ASTRO25ChannelIDInnerSection).TrkSysASTRO25ChannelIDIdentifierEnable_A8222;
				result = false;
				num = (short)1327824903;
				num2 = (int)((global::System.IntPtr)num);
				goto IL_27;
			}
			}
		}

		// Token: 0x06000BD9 RID: 3033 RVA: 0x000BAF5C File Offset: 0x000B915C
		public static bool conReferedHWKeyValid(global::AcpCommonLib.IAcpFeatureSection self, int index)
		{
			short num = (short)1409024000;
			int num2 = (int)num;
			switch (num2)
			{
			default:
			{
				switch (0)
				{
				case 0:
					goto IL_DB;
				}
				global::AcpBusinessLayer.AcpRecRefField trkSysGeneralDataProfileSelection_A;
				global::Motorola.MackinawCPS.CoreFeatures.TrunkingSystem.TrunkingSystem trunkingSystem;
				global::AcpBusinessLayer.AcpListField secWideGeneralSecureOperation_A;
				global::AcpBusinessLayer.AcpField<bool> secWideASTROOTARASTROOTAREnable_A;
				global::AcpBusinessLayer.AcpField<bool> trkSysSecureMultikeyASTROOTAR_A;
				global::AcpBusinessLayer.AcpField<bool> secureWideAESAlgorithmEnable_;
				global::AcpBusinessLayer.AcpListField trkSysGeneralSystemType_A;
				global::AcpBusinessLayer.AcpRecRefField trkSysSecureMultikeyKMFProfileIndex_A;
				global::AcpBusinessLayer.AcpField<bool> secureWideDESAlgorithmEnable_;
				global::AcpBusinessLayer.AcpField<bool> secWideGeneralOTAREnable_A;
				for (;;)
				{
					IL_28:
					bool flag;
					global::AcpBusinessLayer.Recordset recordset;
					bool flag2;
					switch (num2)
					{
					case 0:
						if (trkSysGeneralDataProfileSelection_A.Value == 0)
						{
							num = (short)1310523424;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)1964179479;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 1:
						num = (short)20840465;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 2:
						if (trunkingSystem.General.TrkSysGeneralSystemType_A9252.Value == 3)
						{
							num = (short)293208103;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_6CB;
					case 3:
					{
						global::Motorola.MackinawCPS.CoreFeatures.SecureKMFProfile.SecureKMFProfile secureKMFProfile;
						if (secureKMFProfile.General != null)
						{
							num = (short)2060714008;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_6CB;
					}
					case 4:
					{
						global::AcpBusinessLayer.AcpField<bool> secKmfProfGenIndependentKeyList_;
						if (secKmfProfGenIndependentKeyList_.Value)
						{
							num = (short)403701765;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_6CB;
					}
					case 5:
						num = (short)493289482;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 6:
						if (secWideGeneralSecureOperation_A.Value == 3)
						{
							num = (short)542572582;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)1387266088;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 7:
						if (secWideASTROOTARASTROOTAREnable_A)
						{
							num = (short)283049985;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return true;
					case 8:
						flag = true;
						goto IL_726;
					case 9:
						num = (short)561446937;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 10:
					{
						global::AcpBusinessLayer.AcpField<bool> secKmfProfGenIndependentKeyList_;
						if (secKmfProfGenIndependentKeyList_.Applicable)
						{
							num = (short)188219413;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_6CB;
					}
					case 11:
					{
						global::Motorola.MackinawCPS.CoreFeatures.TrunkingSystem.SecureMultikey secureMultikey;
						if (secureMultikey.TrkSysSecureMultikeyKMFProfileIndex_A8382.RefRecset != null)
						{
							num = (short)1571422244;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_6CB;
					}
					case 12:
						num = (short)1998454791;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 13:
						num = (short)1657274368;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 14:
						if (trkSysSecureMultikeyASTROOTAR_A.Value)
						{
							num = (short)447610911;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return true;
					case 15:
						num = (short)726335518;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 16:
						num = (short)1156382721;
						if (num != 0)
						{
						}
						if (!secureWideAESAlgorithmEnable_.Value)
						{
							num = (short)184156169;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)410124296;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 17:
						if (trkSysGeneralSystemType_A.Value == 3)
						{
							num = (short)1719074829;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return true;
					case 18:
					{
						if (recordset == null)
						{
							num = (short)1979777046;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						global::System.Collections.Generic.IEnumerator<global::AcpBusinessLayer.FeatureNode> enumerator = recordset.GetEnumerator();
						num = (short)357433364;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 19:
						if (flag2)
						{
							num = (short)502136873;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return true;
					case 20:
						try
						{
							num = (short)605093896;
							num2 = (int)((global::System.IntPtr)num);
							bool result;
							for (;;)
							{
								switch (num2)
								{
								case 0:
								{
									global::System.Collections.Generic.IEnumerator<global::AcpBusinessLayer.FeatureNode> enumerator;
									if (!enumerator.MoveNext())
									{
										num = (short)672202757;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									global::AcpBusinessLayer.AcpRecRefField secKmfProfSecureHardwareEncryptionKeyReferencesListHardwareKeyReference_A = (((global::AcpCommonLib.IAcpFeatureNode)enumerator.Current)[10127] as global::Motorola.MackinawCPS.CoreFeatures.SecureKMFProfile.SecureHardwareEncryptionKeyReferencesListInnerSection).SecKmfProfSecureHardwareEncryptionKeyReferencesListHardwareKeyReference_A8194;
									num = (short)804519940;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 1:
									goto IL_4BD;
								case 2:
									num = (short)930742278;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 3:
									goto IL_3BA;
								case 4:
									if (trkSysSecureMultikeyASTROOTAR_A.Value)
									{
										num = (short)449314818;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									break;
								case 5:
									num = (short)527433729;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 6:
								{
									global::AcpBusinessLayer.AcpRecRefField secKmfProfSecureHardwareEncryptionKeyReferencesListHardwareKeyReference_A;
									if (secKmfProfSecureHardwareEncryptionKeyReferencesListHardwareKeyReference_A.Value == index)
									{
										num = (short)579665927;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									break;
								}
								case 7:
									result = true;
									num = (short)549847043;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 8:
									IL_335:
									switch (0)
									{
									case 0:
										goto IL_36A;
									}
									continue;
								}
								IL_3BF:
								num = (short)1754801072;
								short num3 = num;
								num = (short)1911694256;
								switch ((num3 == num) ? 1 : 0)
								{
								case 0:
								case 2:
									goto IL_335;
								default:
									num = (short)2057895936;
									if (num != 0)
									{
									}
									num = (short)658898944;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								IL_36A:
								goto IL_3BF;
							}
							IL_3BA:
							return result;
							IL_4BD:
							return false;
						}
						finally
						{
							num = (short)140115970;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								global::System.Collections.Generic.IEnumerator<global::AcpBusinessLayer.FeatureNode> enumerator;
								switch (num2)
								{
								case 0:
									enumerator.Dispose();
									num = (short)1236598785;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 1:
									goto IL_52B;
								case 2:
									switch (0)
									{
									case 0:
										goto IL_4F4;
									}
									continue;
								}
								IL_4F4:
								if (enumerator == null)
								{
									break;
								}
								num = (short)183959552;
								num2 = (int)((global::System.IntPtr)num);
							}
							IL_52B:;
						}
						goto IL_52E;
					case 21:
						return true;
					case 22:
						return false;
					case 23:
					{
						if (trkSysSecureMultikeyKMFProfileIndex_A.ReferencedNode == null)
						{
							num = (short)1755054113;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						global::Motorola.MackinawCPS.CoreFeatures.TrunkingSystem.SecureMultikey secureMultikey = trunkingSystem.SecureMultikey;
						num = (short)1854144514;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 24:
					{
						global::Motorola.MackinawCPS.CoreFeatures.SecureKMFProfile.SecureKMFProfile secureKMFProfile;
						global::AcpBusinessLayer.AcpField<bool> secKmfProfGenIndependentKeyList_ = secureKMFProfile.General.SecKmfProfGenIndependentKeyList_43597;
						num = (short)2058092548;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 25:
						flag = secureWideDESAlgorithmEnable_.Value;
						goto IL_726;
					case 26:
						num = (short)296550403;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 27:
					{
						global::Motorola.MackinawCPS.CoreFeatures.TrunkingSystem.SecureMultikey secureMultikey;
						if (secureMultikey.TrkSysSecureMultikeyKMFProfileIndex_A8382.ReferencedNode != null)
						{
							num = (short)2093416463;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_6CB;
					}
					case 28:
						if (secWideGeneralSecureOperation_A.Value != 1)
						{
							num = (short)1610874922;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)1261830179;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 29:
					{
						global::Motorola.MackinawCPS.CoreFeatures.TrunkingSystem.SecureMultikey secureMultikey;
						global::Motorola.MackinawCPS.CoreFeatures.SecureKMFProfile.SecureKMFProfile secureKMFProfile = secureMultikey.TrkSysSecureMultikeyKMFProfileIndex_A8382.RefRecset[secureMultikey.TrkSysSecureMultikeyKMFProfileIndex_A8382.Value - 1] as global::Motorola.MackinawCPS.CoreFeatures.SecureKMFProfile.SecureKMFProfile;
						num = (short)1415774245;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 30:
					{
						global::Motorola.MackinawCPS.CoreFeatures.TrunkingSystem.SecureMultikey secureMultikey;
						if (secureMultikey.TrkSysSecureMultikeyKMFProfileIndex_A8382.Value > 0)
						{
							num = (short)1786642461;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_6CB;
					}
					case 31:
						goto IL_52E;
					case 32:
						goto IL_675;
					case 33:
						return false;
					case 34:
						if (secWideGeneralOTAREnable_A)
						{
							num = (short)1763835916;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return true;
					case 35:
						flag = true;
						goto IL_726;
					case 36:
						num = (short)318636059;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 37:
					{
						global::Motorola.MackinawCPS.CoreFeatures.SecureKMFProfile.SecureKMFProfile secureKMFProfile;
						if (secureKMFProfile != null)
						{
							num = (short)1222574106;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_6CB;
					}
					case 38:
						num = (short)34275344;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 39:
						num = (short)757334027;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 40:
						flag = false;
						goto IL_726;
					case 41:
						num = (short)1074987042;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 42:
					{
						num = (short)354156544;
						short num4 = num;
						num = (short)1382285318;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					}
					goto IL_DB;
					IL_52E:
					num = (short)1360003091;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_6CB:
					recordset = (trkSysSecureMultikeyKMFProfileIndex_A.ReferencedNode[10126].EmbeddedRecset as global::AcpBusinessLayer.Recordset);
					num = (short)622264338;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_726:
					flag2 = flag;
					num = (short)911474702;
					num2 = (int)((global::System.IntPtr)num);
				}
				return true;
				IL_675:
				return true;
				IL_DB:
				trunkingSystem = (self.Parent as global::Motorola.MackinawCPS.CoreFeatures.TrunkingSystem.TrunkingSystem);
				trkSysSecureMultikeyASTROOTAR_A = trunkingSystem.SecureMultikey.TrkSysSecureMultikeyASTROOTAR_A7494;
				trkSysSecureMultikeyKMFProfileIndex_A = trunkingSystem.SecureMultikey.TrkSysSecureMultikeyKMFProfileIndex_A8382;
				global::Motorola.MackinawCPS.CoreFeatures.SecureWide.SecureWide secureWide = global::AcpCommonLib.FeatureManager.GetFeature(2021)[0] as global::Motorola.MackinawCPS.CoreFeatures.SecureWide.SecureWide;
				secWideGeneralSecureOperation_A = secureWide.General.SecWideGeneralSecureOperation_A9067;
				secWideGeneralOTAREnable_A = secureWide.General.SecWideGeneralOTAREnable_A7966;
				secWideASTROOTARASTROOTAREnable_A = secureWide.ASTROOTAR.SecWideASTROOTARASTROOTAREnable_A7496;
				secureWideAESAlgorithmEnable_ = secureWide.General.SecureWideAESAlgorithmEnable_43201;
				secureWideDESAlgorithmEnable_ = secureWide.General.SecureWideDESAlgorithmEnable_43744;
				trkSysGeneralSystemType_A = trunkingSystem.General.TrkSysGeneralSystemType_A9252;
				trkSysGeneralDataProfileSelection_A = trunkingSystem.General.TrkSysGeneralDataProfileSelection_A19449;
				num = (short)1947402268;
				num2 = (int)((global::System.IntPtr)num);
				goto IL_28;
			}
			}
		}

		// Token: 0x06000BDA RID: 3034 RVA: 0x000BB948 File Offset: 0x000B9B48
		internal static void conSetValueTxFrequency(global::AcpCommonLib.IAcpFeatureSection self, global::AcpCommonLib.UndoRedo.ContainerTask task)
		{
			short num = (short)1651834880;
			int num2 = (int)num;
			switch (num2)
			{
			default:
			{
				switch (0)
				{
				case 0:
					goto IL_5C;
				}
				global::AcpBusinessLayer.AcpFrequencyField trkSysControlChannelsTxFrequencyMHz_A;
				int num3;
				global::AcpBusinessLayer.AcpListField trkSysGeneralTypeIIFrequencyBand_A;
				global::Motorola.MackinawCPS.CoreFeatures.RadioWide.RxFrequencySplitFPPInnerRecset rxFrequencySplitFPPInnerRecset;
				global::AcpBusinessLayer.AcpListField trkSysGeneralSystemType_A;
				for (;;)
				{
					IL_29:
					global::System.Collections.Generic.IEnumerator<global::AcpBusinessLayer.FeatureNode> enumerator;
					switch (num2)
					{
					case 0:
						try
						{
							num = (short)1046478857;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								switch (num2)
								{
								case 0:
									num = (short)1180631044;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 2:
									task.AddTask(new global::AcpBusinessLayer.UndoRedo.ModifyDataTask<int>(trkSysControlChannelsTxFrequencyMHz_A, (num3 - 39000000) / 5));
									num = (short)650838017;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 3:
								{
									global::AcpCommonLib.IAcpFeatureNode acpFeatureNode;
									if ((acpFeatureNode[10097] as global::Motorola.MackinawCPS.CoreFeatures.RadioWide.RxFrequencySplitFPPInnerSection).RadWideLabtoolRxBandSplitName_A24797.Value == global::CommonResources.AcgResources.ID_P_900M)
									{
										num = (short)206700551;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									break;
								}
								case 4:
									goto IL_38E;
								case 5:
								{
									global::AcpCommonLib.IAcpFeatureNode acpFeatureNode;
									if (num3 < (acpFeatureNode[10097] as global::Motorola.MackinawCPS.CoreFeatures.RadioWide.RxFrequencySplitFPPInnerSection).RadWideLabtoolRxEndFrequencySplit_A9015.Value * 5)
									{
										num = (short)1783169026;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									break;
								}
								case 6:
								{
									if (!enumerator.MoveNext())
									{
										num = (short)1625620480;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									global::AcpCommonLib.IAcpFeatureNode acpFeatureNode = enumerator.Current;
									num = (short)1003618307;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 7:
									num = (short)965738504;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 8:
								{
									global::AcpCommonLib.IAcpFeatureNode acpFeatureNode;
									if (num3 > (acpFeatureNode[10097] as global::Motorola.MackinawCPS.CoreFeatures.RadioWide.RxFrequencySplitFPPInnerSection).RadWideLabtoolRxStartFrequencySplit_A9032.Value * 5)
									{
										num = (short)1567948810;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									break;
								}
								case 9:
									switch (0)
									{
									case 0:
										goto IL_1F2;
									}
									continue;
								case 10:
									num = (short)1831534597;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								IL_336:
								num = (short)1240924166;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								IL_1F2:
								goto IL_336;
							}
							IL_38E:
							return;
						}
						finally
						{
							num = (short)1118371841;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								switch (num2)
								{
								case 0:
									goto IL_3FF;
								case 1:
									switch (0)
									{
									case 0:
										goto IL_3C6;
									}
									continue;
								case 2:
									enumerator.Dispose();
									num = (short)359661568;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								IL_3C6:
								if (enumerator == null)
								{
									break;
								}
								num = (short)1485963266;
								num2 = (int)((global::System.IntPtr)num);
							}
							IL_3FF:;
						}
						goto Block_4;
					case 1:
						if (trkSysGeneralTypeIIFrequencyBand_A.Value == 3)
						{
							num = (short)1586692102;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_E5E;
					case 2:
						goto IL_845;
					case 3:
						num = (short)1866661889;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 4:
						goto IL_402;
					case 5:
						if (trkSysGeneralTypeIIFrequencyBand_A.Value == 4)
						{
							num = (short)842596359;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return;
					case 6:
						goto IL_E38;
					case 7:
						enumerator = rxFrequencySplitFPPInnerRecset.GetEnumerator();
						num = (short)595853312;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 8:
						if (trkSysGeneralSystemType_A.Value == 3)
						{
							num = (short)305266697;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return;
					case 9:
						num = (short)1377959937;
						if (num != 0)
						{
						}
						enumerator = rxFrequencySplitFPPInnerRecset.GetEnumerator();
						num = (short)685637634;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 10:
						if (trkSysGeneralSystemType_A.Value == 2)
						{
							num = (short)1571880960;
							short num4 = num;
							num = (short)550240259;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)293535752;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_5C;
					IL_E38:
					enumerator = rxFrequencySplitFPPInnerRecset.GetEnumerator();
					num = (short)1524891652;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					Block_5:
					try
					{
						IL_845:
						num = (short)1258487833;
						num2 = (int)((global::System.IntPtr)num);
						for (;;)
						{
							switch (num2)
							{
							case 0:
							{
								num = (short)1430131491;
								short num5 = num;
								num = (short)160240419;
								switch ((num5 == num) ? 1 : 0)
								{
								case 0:
								case 2:
									continue;
								default:
								{
									num = (short)135331840;
									if (num != 0)
									{
									}
									global::AcpCommonLib.IAcpFeatureNode acpFeatureNode2;
									if (num3 > (acpFeatureNode2[10097] as global::Motorola.MackinawCPS.CoreFeatures.RadioWide.RxFrequencySplitFPPInnerSection).RadWideLabtoolRxStartFrequencySplit_A9032.Value * 5)
									{
										num = (short)1775239172;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									break;
								}
								}
								break;
							}
							case 1:
							{
								if (!enumerator.MoveNext())
								{
									num = (short)756678677;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								global::AcpCommonLib.IAcpFeatureNode acpFeatureNode2 = enumerator.Current;
								num = (short)1363476482;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							case 2:
							{
								global::AcpCommonLib.IAcpFeatureNode acpFeatureNode2;
								if (!((acpFeatureNode2[10097] as global::Motorola.MackinawCPS.CoreFeatures.RadioWide.RxFrequencySplitFPPInnerSection).RadWideLabtoolRxBandSplitName_A24797.Value == global::CommonResources.AcgResources.ID_P_700M))
								{
									num = (short)1058275331;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								goto IL_B18;
							}
							case 3:
								num = (short)919994377;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							case 4:
								num = (short)2141126675;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							case 5:
							{
								global::AcpCommonLib.IAcpFeatureNode acpFeatureNode2;
								if ((acpFeatureNode2[10097] as global::Motorola.MackinawCPS.CoreFeatures.RadioWide.RxFrequencySplitFPPInnerSection).RadWideLabtoolRxBandSplitName_A24797.Value == global::CommonResources.AcgResources.ID_P_900M)
								{
									num = (short)784072714;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								break;
							}
							case 6:
								task.AddTask(new global::AcpBusinessLayer.UndoRedo.ModifyDataTask<int>(trkSysControlChannelsTxFrequencyMHz_A, (num3 - 39000000) / 5));
								num = (short)1274609686;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							case 7:
								goto IL_B18;
							case 8:
							{
								global::AcpCommonLib.IAcpFeatureNode acpFeatureNode2;
								if (num3 < (acpFeatureNode2[10097] as global::Motorola.MackinawCPS.CoreFeatures.RadioWide.RxFrequencySplitFPPInnerSection).RadWideLabtoolRxEndFrequencySplit_A9015.Value * 5)
								{
									num = (short)580780044;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								goto IL_D4A;
							}
							case 9:
							{
								global::AcpCommonLib.IAcpFeatureNode acpFeatureNode2;
								if ((acpFeatureNode2[10097] as global::Motorola.MackinawCPS.CoreFeatures.RadioWide.RxFrequencySplitFPPInnerSection).RadWideLabtoolRxBandSplitName_A24797.Value == global::CommonResources.AcgResources.ID_P_700M_1)
								{
									num = (short)443547655;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								goto IL_A85;
							}
							case 10:
								num = (short)1772879872;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							case 11:
								num = (short)713687055;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							case 12:
								task.AddTask(new global::AcpBusinessLayer.UndoRedo.ModifyDataTask<int>(trkSysControlChannelsTxFrequencyMHz_A, (num3 - 45000000) / 5));
								num = (short)1684275214;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							case 13:
							{
								global::AcpCommonLib.IAcpFeatureNode acpFeatureNode2;
								if (num3 > (acpFeatureNode2[10097] as global::Motorola.MackinawCPS.CoreFeatures.RadioWide.RxFrequencySplitFPPInnerSection).RadWideLabtoolRxStartFrequencySplit_A9032.Value * 5)
								{
									num = (short)1725562897;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								goto IL_A85;
							}
							case 15:
							{
								global::AcpCommonLib.IAcpFeatureNode acpFeatureNode2;
								if (num3 >= (acpFeatureNode2[10097] as global::Motorola.MackinawCPS.CoreFeatures.RadioWide.RxFrequencySplitFPPInnerSection).RadWideLabtoolRxStartFrequencySplit_A9032.Value * 5)
								{
									num = (short)1949630487;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								goto IL_D4A;
							}
							case 17:
								num = (short)1055129618;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							case 18:
							{
								global::AcpCommonLib.IAcpFeatureNode acpFeatureNode2;
								if (num3 < (acpFeatureNode2[10097] as global::Motorola.MackinawCPS.CoreFeatures.RadioWide.RxFrequencySplitFPPInnerSection).RadWideLabtoolRxEndFrequencySplit_A9015.Value * 5)
								{
									num = (short)744554516;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								goto IL_A85;
							}
							case 19:
							{
								global::AcpCommonLib.IAcpFeatureNode acpFeatureNode2;
								if (num3 < (acpFeatureNode2[10097] as global::Motorola.MackinawCPS.CoreFeatures.RadioWide.RxFrequencySplitFPPInnerSection).RadWideLabtoolRxEndFrequencySplit_A9015.Value * 5)
								{
									num = (short)415629318;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								break;
							}
							case 20:
								task.AddTask(new global::AcpBusinessLayer.UndoRedo.ModifyDataTask<int>(trkSysControlChannelsTxFrequencyMHz_A, (num3 + 30000000) / 5));
								num = (short)549453840;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							case 21:
								num = (short)855375896;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							case 23:
								num = (short)595066888;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							case 24:
								goto IL_DC5;
							case 25:
								switch (0)
								{
								case 0:
									goto IL_8D8;
								}
								continue;
							case 26:
							{
								global::AcpCommonLib.IAcpFeatureNode acpFeatureNode2;
								if ((acpFeatureNode2[10097] as global::Motorola.MackinawCPS.CoreFeatures.RadioWide.RxFrequencySplitFPPInnerSection).RadWideLabtoolRxBandSplitName_A24797.Value == global::CommonResources.AcgResources.ID_P_800M)
								{
									num = (short)65470475;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								goto IL_D4A;
							}
							}
							goto IL_8D8;
							IL_A85:
							num = (short)1320550426;
							num2 = (int)((global::System.IntPtr)num);
							continue;
							IL_B18:
							num = (short)461897741;
							num2 = (int)((global::System.IntPtr)num);
							continue;
							IL_BD3:
							num = (short)688586753;
							num2 = (int)((global::System.IntPtr)num);
							continue;
							IL_8D8:
							goto IL_BD3;
							IL_D4A:
							num = (short)1312555013;
							num2 = (int)((global::System.IntPtr)num);
						}
						IL_DC5:
						break;
					}
					finally
					{
						num = (short)315097089;
						num2 = (int)((global::System.IntPtr)num);
						for (;;)
						{
							switch (num2)
							{
							case 0:
								goto IL_E35;
							case 1:
								switch (0)
								{
								case 0:
									goto IL_DFE;
								}
								continue;
							case 2:
								enumerator.Dispose();
								num = (short)929562624;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							IL_DFE:
							if (enumerator == null)
							{
								break;
							}
							num = (short)1172570114;
							num2 = (int)((global::System.IntPtr)num);
						}
						IL_E35:;
					}
					goto IL_E38;
					Block_4:
					try
					{
						IL_402:
						num = (short)473825298;
						num2 = (int)((global::System.IntPtr)num);
						for (;;)
						{
							switch (num2)
							{
							case 0:
							{
								global::AcpCommonLib.IAcpFeatureNode acpFeatureNode3;
								if (num3 < (acpFeatureNode3[10097] as global::Motorola.MackinawCPS.CoreFeatures.RadioWide.RxFrequencySplitFPPInnerSection).RadWideLabtoolRxEndFrequencySplit_A9015.Value * 5)
								{
									num = (short)428343304;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								goto IL_6FD;
							}
							case 1:
							{
								global::AcpCommonLib.IAcpFeatureNode acpFeatureNode3;
								if ((acpFeatureNode3[10097] as global::Motorola.MackinawCPS.CoreFeatures.RadioWide.RxFrequencySplitFPPInnerSection).RadWideLabtoolRxBandSplitName_A24797.Value == global::CommonResources.AcgResources.ID_P_800M)
								{
									num = (short)1858994185;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								break;
							}
							case 2:
							{
								if (!enumerator.MoveNext())
								{
									num = (short)563281934;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								global::AcpCommonLib.IAcpFeatureNode acpFeatureNode3 = enumerator.Current;
								num = (short)1565655053;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							case 3:
								task.AddTask(new global::AcpBusinessLayer.UndoRedo.ModifyDataTask<int>(trkSysControlChannelsTxFrequencyMHz_A, (num3 - 45000000) / 5));
								num = (short)1747976197;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							case 4:
							{
								global::AcpCommonLib.IAcpFeatureNode acpFeatureNode3;
								if (num3 < (acpFeatureNode3[10097] as global::Motorola.MackinawCPS.CoreFeatures.RadioWide.RxFrequencySplitFPPInnerSection).RadWideLabtoolRxEndFrequencySplit_A9015.Value * 5)
								{
									num = (short)1569652739;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								break;
							}
							case 6:
								num = (short)82640900;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							case 7:
								num = (short)1466236928;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							case 8:
								task.AddTask(new global::AcpBusinessLayer.UndoRedo.ModifyDataTask<int>(trkSysControlChannelsTxFrequencyMHz_A, (num3 + 30000000) / 5));
								num = (short)1579221008;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							case 9:
								num = (short)967442444;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							case 10:
							{
								global::AcpCommonLib.IAcpFeatureNode acpFeatureNode3;
								if (num3 > (acpFeatureNode3[10097] as global::Motorola.MackinawCPS.CoreFeatures.RadioWide.RxFrequencySplitFPPInnerSection).RadWideLabtoolRxStartFrequencySplit_A9032.Value * 5)
								{
									num = (short)1397686279;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								goto IL_6FD;
							}
							case 11:
								num = (short)18939923;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							case 12:
							{
								global::AcpCommonLib.IAcpFeatureNode acpFeatureNode3;
								if (num3 >= (acpFeatureNode3[10097] as global::Motorola.MackinawCPS.CoreFeatures.RadioWide.RxFrequencySplitFPPInnerSection).RadWideLabtoolRxStartFrequencySplit_A9032.Value * 5)
								{
									num = (short)1812594694;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								break;
							}
							case 13:
							{
								global::AcpCommonLib.IAcpFeatureNode acpFeatureNode3;
								if (!((acpFeatureNode3[10097] as global::Motorola.MackinawCPS.CoreFeatures.RadioWide.RxFrequencySplitFPPInnerSection).RadWideLabtoolRxBandSplitName_A24797.Value == global::CommonResources.AcgResources.ID_P_700M))
								{
									num = (short)1537277963;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								goto IL_5F7;
							}
							case 14:
								num = (short)1166540817;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							case 15:
								goto IL_5F7;
							case 17:
								goto IL_7D1;
							case 18:
								switch (0)
								{
								case 0:
									goto IL_479;
								}
								continue;
							case 19:
							{
								global::AcpCommonLib.IAcpFeatureNode acpFeatureNode3;
								if ((acpFeatureNode3[10097] as global::Motorola.MackinawCPS.CoreFeatures.RadioWide.RxFrequencySplitFPPInnerSection).RadWideLabtoolRxBandSplitName_A24797.Value == global::CommonResources.AcgResources.ID_P_700M_1)
								{
									num = (short)1664876559;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								goto IL_6FD;
							}
							}
							goto IL_479;
							IL_5F7:
							num = (short)2083848202;
							num2 = (int)((global::System.IntPtr)num);
							continue;
							IL_651:
							num = (short)1739849730;
							num2 = (int)((global::System.IntPtr)num);
							continue;
							IL_479:
							goto IL_651;
							IL_6FD:
							num = (short)1772224513;
							num2 = (int)((global::System.IntPtr)num);
						}
						IL_7D1:
						goto IL_E5E;
					}
					finally
					{
						num = (short)510001153;
						num2 = (int)((global::System.IntPtr)num);
						for (;;)
						{
							switch (num2)
							{
							case 0:
								goto IL_842;
							case 1:
								switch (0)
								{
								case 0:
									goto IL_80A;
								}
								continue;
							case 2:
								enumerator.Dispose();
								num = (short)1529085952;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							IL_80A:
							if (enumerator == null)
							{
								break;
							}
							num = (short)914227202;
							num2 = (int)((global::System.IntPtr)num);
						}
						IL_842:;
					}
					goto Block_5;
					IL_E5E:
					num = (short)907018245;
					num2 = (int)((global::System.IntPtr)num);
				}
				return;
				IL_5C:
				global::Motorola.MackinawCPS.CoreFeatures.TrunkingSystem.ControlChannelsInnerSection controlChannelsInnerSection = self as global::Motorola.MackinawCPS.CoreFeatures.TrunkingSystem.ControlChannelsInnerSection;
				global::Motorola.MackinawCPS.CoreFeatures.TrunkingSystem.TrunkingSystem trunkingSystem = self.ParentRecset.ParentSection.Parent as global::Motorola.MackinawCPS.CoreFeatures.TrunkingSystem.TrunkingSystem;
				trkSysGeneralSystemType_A = trunkingSystem.General.TrkSysGeneralSystemType_A9252;
				trkSysGeneralTypeIIFrequencyBand_A = trunkingSystem.General.TrkSysGeneralTypeIIFrequencyBand_A12491;
				trkSysControlChannelsTxFrequencyMHz_A = controlChannelsInnerSection.TrkSysControlChannelsTxFrequencyMHz_A9535;
				rxFrequencySplitFPPInnerRecset = ((global::AcpCommonLib.FeatureManager.GetFeature(2045) as global::Motorola.MackinawCPS.CoreFeatures.RadioWide.RadioWideRecset)[0][10096].EmbeddedRecset as global::Motorola.MackinawCPS.CoreFeatures.RadioWide.RxFrequencySplitFPPInnerRecset);
				num3 = controlChannelsInnerSection.TrkSysControlChannelsRxFrequencyMHz_A9018.Value * 5;
				num = (short)322961418;
				num2 = (int)((global::System.IntPtr)num);
				goto IL_29;
			}
			}
		}

		// Token: 0x06000BDB RID: 3035 RVA: 0x000BC8CC File Offset: 0x000BAACC
		public static bool conTrkSysDynamicRegroupEnIsValid(global::AcpCommonLib.IAcpFeatureSection self)
		{
			short num = (short)967311360;
			short num2 = num;
			num = (short)54525953;
			if (num != 0)
			{
			}
			num = (short)218324987;
			short num3 = num;
			num = (short)336420859;
			switch ((num3 == num) ? 1 : 0)
			{
			case 0:
			case 2:
				break;
			default:
				num = (short)529006592;
				if (num != 0)
				{
				}
				num = (short)1685979136;
				switch (num)
				{
				}
				break;
			}
			global::System.Collections.Generic.IEnumerator<global::AcpBusinessLayer.FeatureNode> enumerator = (self.Parent as global::AcpBusinessLayer.FeatureNode).ReferencingNodes.GetEnumerator();
			try
			{
				num = (short)1484128261;
				int num4 = (int)((global::System.IntPtr)num);
				for (;;)
				{
					switch (num4)
					{
					case 0:
					{
						global::AcpBusinessLayer.FeatureNode featureNode;
						global::System.Collections.Generic.IEnumerator<global::AcpBusinessLayer.FeatureNode> enumerator2 = (featureNode as global::Motorola.MackinawCPS.CoreFeatures.TrunkingPersonality.TrunkingPersonality).ReferencingNodes.GetEnumerator();
						num = (short)23461891;
						num4 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 1:
					{
						global::AcpBusinessLayer.FeatureNode featureNode;
						if (featureNode is global::Motorola.MackinawCPS.CoreFeatures.TrunkingPersonality.TrunkingPersonality)
						{
							num = (short)391512064;
							num4 = (int)((global::System.IntPtr)num);
							continue;
						}
						break;
					}
					case 2:
						goto IL_3B4;
					case 3:
						try
						{
							num = (short)1239482375;
							num4 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								switch (num4)
								{
								case 0:
									num = (short)431882243;
									num4 = (int)((global::System.IntPtr)num);
									continue;
								case 1:
								{
									global::AcpBusinessLayer.FeatureNode featureNode2;
									(featureNode2 as global::Motorola.MackinawCPS.CoreFeatures.ZoneChannelAssignment.ChannelAssignmentListInner).ChannelAssignmentListInnerSection.ZnChanCfgChannelsTalkgroup_A9276.CalculateApplicability();
									(featureNode2 as global::Motorola.MackinawCPS.CoreFeatures.ZoneChannelAssignment.ChannelAssignmentListInner).ChannelAssignmentListInnerSection.ZnChanCfgChannelsTalkgroup_A9276.CalculateValidity();
									num = (short)2047475717;
									num4 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 2:
								{
									global::System.Collections.Generic.IEnumerator<global::AcpBusinessLayer.FeatureNode> enumerator2;
									if (!enumerator2.MoveNext())
									{
										num = (short)597688320;
										num4 = (int)((global::System.IntPtr)num);
										continue;
									}
									global::AcpBusinessLayer.FeatureNode featureNode2 = enumerator2.Current;
									num = (short)341966854;
									num4 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 3:
									goto IL_343;
								case 4:
								{
									global::AcpBusinessLayer.FeatureNode featureNode2;
									if ((featureNode2 as global::Motorola.MackinawCPS.CoreFeatures.ZoneChannelAssignment.ChannelAssignmentListInner).ChannelAssignmentListInnerSection.ZnChanCfgChannelsTalkgroup_A9276.Value == 65535)
									{
										num = (short)1338703873;
										num4 = (int)((global::System.IntPtr)num);
										continue;
									}
									break;
								}
								case 6:
								{
									global::AcpBusinessLayer.FeatureNode featureNode2;
									if (featureNode2 is global::Motorola.MackinawCPS.CoreFeatures.ZoneChannelAssignment.ChannelAssignmentListInner)
									{
										num = (short)465240072;
										num4 = (int)((global::System.IntPtr)num);
										continue;
									}
									break;
								}
								case 7:
									switch (0)
									{
									case 0:
										goto IL_213;
									}
									continue;
								case 8:
									num = (short)1073086468;
									num4 = (int)((global::System.IntPtr)num);
									continue;
								}
								IL_29C:
								num = (short)2097152002;
								num4 = (int)((global::System.IntPtr)num);
								continue;
								IL_213:
								goto IL_29C;
							}
							IL_343:
							break;
						}
						finally
						{
							num = (short)1824391169;
							num4 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								global::System.Collections.Generic.IEnumerator<global::AcpBusinessLayer.FeatureNode> enumerator2;
								switch (num4)
								{
								case 0:
									goto IL_3B1;
								case 1:
									switch (0)
									{
									case 0:
										goto IL_37A;
									}
									continue;
								case 2:
									enumerator2.Dispose();
									num = (short)1240203264;
									num4 = (int)((global::System.IntPtr)num);
									continue;
								}
								IL_37A:
								if (enumerator2 == null)
								{
									break;
								}
								num = (short)1827864578;
								num4 = (int)((global::System.IntPtr)num);
							}
							IL_3B1:;
						}
						goto IL_3B4;
					case 4:
						goto IL_3CC;
					case 5:
						switch (0)
						{
						case 0:
							goto IL_115;
						}
						continue;
					case 6:
					{
						if (!enumerator.MoveNext())
						{
							num = (short)1105854466;
							num4 = (int)((global::System.IntPtr)num);
							continue;
						}
						global::AcpBusinessLayer.FeatureNode featureNode = enumerator.Current;
						num = (short)548667393;
						num4 = (int)((global::System.IntPtr)num);
						continue;
					}
					}
					IL_145:
					num = (short)1809514502;
					num4 = (int)((global::System.IntPtr)num);
					continue;
					IL_115:
					goto IL_145;
					IL_3B4:
					num = (short)195690500;
					num4 = (int)((global::System.IntPtr)num);
				}
				IL_3CC:;
			}
			finally
			{
				num = (short)1593573377;
				int num4 = (int)((global::System.IntPtr)num);
				for (;;)
				{
					switch (num4)
					{
					case 0:
						goto IL_437;
					case 1:
						switch (0)
						{
						case 0:
							goto IL_401;
						}
						continue;
					case 2:
						enumerator.Dispose();
						num = (short)746258432;
						num4 = (int)((global::System.IntPtr)num);
						continue;
					}
					IL_401:
					if (enumerator == null)
					{
						break;
					}
					num = (short)1699086338;
					num4 = (int)((global::System.IntPtr)num);
				}
				IL_437:;
			}
			return true;
		}

		// Token: 0x06000BDC RID: 3036 RVA: 0x000BCD48 File Offset: 0x000BAF48
		public static bool conSetMaxRecNumForTrunkingStatusAliasTable(global::AcpCommonLib.IAcpFeatureSection self)
		{
			short num = (short)961675264;
			short num2 = num;
			num = (short)1973288961;
			if (num != 0)
			{
			}
			num = (short)1274103085;
			short num3 = num;
			num = (short)2140161325;
			switch (num3 == num)
			{
			}
			num = (short)222494720;
			if (num != 0)
			{
			}
			int result = 1;
			global::AcpBusinessLayer.FeatureSection featureSection = self as global::Motorola.MackinawCPS.CoreFeatures.TrunkingSystem.StatusAlias;
			global::Motorola.MackinawCPS.CoreFeatures.TrunkingSystem.TrunkingSystem trunkingSystem = self.Parent as global::Motorola.MackinawCPS.CoreFeatures.TrunkingSystem.TrunkingSystem;
			global::Motorola.MackinawCPS.CoreFeatures.TrunkingSystem.StatusAliasInnerRecset statusAliasInnerRecset = featureSection.EmbeddedRecset as global::Motorola.MackinawCPS.CoreFeatures.TrunkingSystem.StatusAliasInnerRecset;
			if (statusAliasInnerRecset != null)
			{
				if (trunkingSystem.General.TrkSysGeneralSystemType_A9252.Value == 3 && statusAliasInnerRecset.Max != 16)
				{
					statusAliasInnerRecset.SetMax(16);
					return result != 0;
				}
				if (trunkingSystem.General.TrkSysGeneralSystemType_A9252.Value == 2 && statusAliasInnerRecset.Max != 8)
				{
					statusAliasInnerRecset.SetMax(8);
				}
			}
			return result != 0;
		}

		// Token: 0x06000BDD RID: 3037 RVA: 0x000BCE68 File Offset: 0x000BB068
		public static bool conExecuteValidityOfDependentFieldsOf9004(global::AcpCommonLib.IAcpFeatureSection self, int index)
		{
			short num = (short)526188544;
			short num2 = num;
			num = (short)1713123845;
			short num3 = num;
			num = (short)575812101;
			switch ((num3 == num) ? 1 : 0)
			{
			case 0:
			case 2:
				break;
			default:
			{
				num = (short)919470080;
				if (num != 0)
				{
				}
				global::AcpBusinessLayer.FeatureNode featureNode = self.Parent.Parent.ParentSection.Parent as global::AcpBusinessLayer.FeatureNode;
				global::Motorola.MackinawCPS.CoreFeatures.TrunkingSystem.TrunkingSystem trunkingSystem = featureNode as global::Motorola.MackinawCPS.CoreFeatures.TrunkingSystem.TrunkingSystem;
				trunkingSystem.ControlChannels.CalculateApplicability();
				trunkingSystem.ControlChannels.CalculateValidity();
				global::System.Collections.Generic.IEnumerator<global::AcpBusinessLayer.FeatureNode> enumerator = featureNode.ReferencingNodes.GetEnumerator();
				try
				{
					num = (short)1713635328;
					int num4 = (int)((global::System.IntPtr)num);
					for (;;)
					{
						switch (num4)
						{
						case 0:
							switch (0)
							{
							case 0:
								goto IL_F8;
							}
							continue;
						case 1:
						{
							global::AcpBusinessLayer.FeatureNode featureNode2;
							if (featureNode2 is global::Motorola.MackinawCPS.CoreFeatures.TrunkingPersonality.TrunkingPersonality)
							{
								num = (short)1941438467;
								num4 = (int)((global::System.IntPtr)num);
								continue;
							}
							break;
						}
						case 2:
							goto IL_221;
						case 3:
						{
							global::AcpBusinessLayer.FeatureNode featureNode2;
							global::Motorola.MackinawCPS.CoreFeatures.TrunkingPersonality.TrunkingPersonality trunkingPersonality = featureNode2 as global::Motorola.MackinawCPS.CoreFeatures.TrunkingPersonality.TrunkingPersonality;
							trunkingPersonality.Talkgroup.CalculateApplicability();
							trunkingPersonality.Talkgroup.CalculateValidity();
							trunkingPersonality.AnnouncementGroup.TrkPerAnnouncementGroupAGFailsoftRxFrequencyMHz_A9582.CalculateValidity();
							trunkingPersonality.AnnouncementGroup.TrkPerAnnouncementGroupAGSecondaryFSRxFrequencyMHz_A8895.CalculateValidity();
							trunkingPersonality.General.TrkPerGeneralSecondaryRxFrequencyMHz_A8904.CalculateApplicability();
							trunkingPersonality.General.TrkPerGeneralSecondaryRxFrequencyMHz_A8904.CalculateValidity();
							trunkingPersonality.General.TrkPerGeneralRxFrequencyMHz_A8910.CalculateApplicability();
							trunkingPersonality.General.TrkPerGeneralRxFrequencyMHz_A8910.CalculateValidity();
							num = (short)1236533254;
							num4 = (int)((global::System.IntPtr)num);
							continue;
						}
						case 4:
						{
							if (!enumerator.MoveNext())
							{
								num = (short)181927941;
								num4 = (int)((global::System.IntPtr)num);
								continue;
							}
							global::AcpBusinessLayer.FeatureNode featureNode2 = enumerator.Current;
							num = (short)1683030017;
							num4 = (int)((global::System.IntPtr)num);
							continue;
						}
						case 5:
							num = (short)921174018;
							num4 = (int)((global::System.IntPtr)num);
							continue;
						}
						IL_136:
						num = (short)1436286980;
						num4 = (int)((global::System.IntPtr)num);
						continue;
						IL_F8:
						goto IL_136;
					}
					IL_221:;
				}
				finally
				{
					num = (short)1229455360;
					int num4 = (int)((global::System.IntPtr)num);
					for (;;)
					{
						switch (num4)
						{
						case 0:
							switch (0)
							{
							case 0:
								goto IL_253;
							}
							continue;
						case 1:
							enumerator.Dispose();
							num = (short)1479475202;
							num4 = (int)((global::System.IntPtr)num);
							continue;
						case 2:
							goto IL_289;
						}
						IL_253:
						if (enumerator == null)
						{
							break;
						}
						num = (short)1067778049;
						num4 = (int)((global::System.IntPtr)num);
					}
					IL_289:;
				}
				break;
			}
			}
			num = (short)31129601;
			if (num != 0)
			{
			}
			return true;
		}

		// Token: 0x06000BDE RID: 3038 RVA: 0x000BD148 File Offset: 0x000BB348
		public static bool conExecuteValidityOfDependentFieldsOf9520(global::AcpCommonLib.IAcpFeatureSection self, int index)
		{
			short num = (short)1076625408;
			short num2 = num;
			num = (short)165478401;
			if (num != 0)
			{
			}
			num = (short)999581846;
			short num3 = num;
			num = (short)2016307350;
			switch ((num3 == num) ? 1 : 0)
			{
			case 0:
			case 2:
				break;
			default:
			{
				num = (short)1887961088;
				if (num != 0)
				{
				}
				global::AcpBusinessLayer.FeatureNode featureNode = self.Parent.Parent.ParentSection.Parent as global::AcpBusinessLayer.FeatureNode;
				global::Motorola.MackinawCPS.CoreFeatures.TrunkingSystem.TrunkingSystem trunkingSystem = featureNode as global::Motorola.MackinawCPS.CoreFeatures.TrunkingSystem.TrunkingSystem;
				trunkingSystem.ControlChannels.CalculateApplicability();
				trunkingSystem.ControlChannels.CalculateValidity();
				global::System.Collections.Generic.IEnumerator<global::AcpBusinessLayer.FeatureNode> enumerator = featureNode.ReferencingNodes.GetEnumerator();
				try
				{
					num = (short)388890624;
					int num4 = (int)((global::System.IntPtr)num);
					for (;;)
					{
						switch (num4)
						{
						case 0:
							switch (0)
							{
							case 0:
								goto IL_11F;
							}
							continue;
						case 1:
						{
							global::AcpBusinessLayer.FeatureNode featureNode2;
							if (featureNode2 is global::Motorola.MackinawCPS.CoreFeatures.TrunkingPersonality.TrunkingPersonality)
							{
								num = (short)121503747;
								num4 = (int)((global::System.IntPtr)num);
								continue;
							}
							break;
						}
						case 2:
							goto IL_249;
						case 3:
						{
							global::AcpBusinessLayer.FeatureNode featureNode2;
							global::Motorola.MackinawCPS.CoreFeatures.TrunkingPersonality.TrunkingPersonality trunkingPersonality = featureNode2 as global::Motorola.MackinawCPS.CoreFeatures.TrunkingPersonality.TrunkingPersonality;
							trunkingPersonality.Talkgroup.CalculateApplicability();
							trunkingPersonality.Talkgroup.CalculateValidity();
							trunkingPersonality.AnnouncementGroup.TrkPerAnnouncementGroupAGSecondaryFSTxFrequencyMHz_A12903.CalculateValidity();
							trunkingPersonality.AnnouncementGroup.TrkPerAnnouncementGroupAGFailsoftTxFrequencyMHz_A9583.CalculateValidity();
							trunkingPersonality.General.TrkPerGeneralTxFrequencyMHz_A9413.CalculateApplicability();
							trunkingPersonality.General.TrkPerGeneralTxFrequencyMHz_A9413.CalculateValidity();
							trunkingPersonality.General.TrkPerGeneralSecondaryTxFrequencyMHz_A12902.CalculateApplicability();
							trunkingPersonality.General.TrkPerGeneralSecondaryTxFrequencyMHz_A12902.CalculateValidity();
							num = (short)409403398;
							num4 = (int)((global::System.IntPtr)num);
							continue;
						}
						case 4:
						{
							if (!enumerator.MoveNext())
							{
								num = (short)1304559621;
								num4 = (int)((global::System.IntPtr)num);
								continue;
							}
							global::AcpBusinessLayer.FeatureNode featureNode2 = enumerator.Current;
							num = (short)1220870145;
							num4 = (int)((global::System.IntPtr)num);
							continue;
						}
						case 5:
							num = (short)772734978;
							num4 = (int)((global::System.IntPtr)num);
							continue;
						}
						IL_15F:
						num = (short)110297092;
						num4 = (int)((global::System.IntPtr)num);
						continue;
						IL_11F:
						goto IL_15F;
					}
					IL_249:;
				}
				finally
				{
					num = (short)182779904;
					int num4 = (int)((global::System.IntPtr)num);
					for (;;)
					{
						switch (num4)
						{
						case 0:
							switch (0)
							{
							case 0:
								goto IL_27B;
							}
							continue;
						case 1:
							enumerator.Dispose();
							num = (short)1893990402;
							num4 = (int)((global::System.IntPtr)num);
							continue;
						case 2:
							goto IL_2B0;
						}
						IL_27B:
						if (enumerator == null)
						{
							break;
						}
						num = (short)628817921;
						num4 = (int)((global::System.IntPtr)num);
					}
					IL_2B0:;
				}
				break;
			}
			}
			return true;
		}

		// Token: 0x06000BDF RID: 3039 RVA: 0x000BD428 File Offset: 0x000BB628
		public static bool ConTrkPer8382CallValidityConstraint(global::AcpCommonLib.IAcpFeatureSection self, int index)
		{
			short num = (short)1066860544;
			int num2 = (int)num;
			switch (num2)
			{
			default:
			{
				num = (short)1985700442;
				short num3 = num;
				num = (short)597254746;
				switch ((num3 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					IL_E7:
					num = (short)905183235;
					num2 = (int)((global::System.IntPtr)num);
					break;
				default:
					num = (short)1391263744;
					if (num != 0)
					{
					}
					switch (0)
					{
					case 0:
						goto IL_DC;
					}
					break;
				}
				global::AcpCommonLib.IAcpRecordset feature;
				bool flag;
				for (;;)
				{
					global::AcpCommonLib.IAcpRecordset feature2;
					int num5;
					global::AcpBusinessLayer.AcpField<bool> radInfoLabtoolQA02811TrkSingleSysTrigger_A;
					global::AcpBusinessLayer.AcpField<bool> radInfoLabtoolP25CommonAirInterface_A;
					switch (num2)
					{
					case 0:
						goto IL_36F;
					case 1:
						goto IL_587;
					case 2:
						goto IL_34E;
					case 3:
						if (feature != null)
						{
							num = (short)655228933;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_27F;
					case 4:
					{
						int num4;
						if (num4 >= (feature2[num5][10179] as global::Motorola.MackinawCPS.CoreFeatures.TrunkingPersonality.Talkgroup).EmbeddedRecset.Count)
						{
							num = (short)1383989264;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						((feature2[num5][10179] as global::Motorola.MackinawCPS.CoreFeatures.TrunkingPersonality.Talkgroup).EmbeddedRecset[num4][10180] as global::Motorola.MackinawCPS.CoreFeatures.TrunkingPersonality.TalkgroupInnerSection).TrkPerTalkgroupKeySelect_A8365.CalculateApplicability();
						((feature2[num5][10179] as global::Motorola.MackinawCPS.CoreFeatures.TrunkingPersonality.Talkgroup).EmbeddedRecset[num4][10180] as global::Motorola.MackinawCPS.CoreFeatures.TrunkingPersonality.TalkgroupInnerSection).TrkPerTalkgroupKeySelect_A8365.CalculateValidity();
						num4++;
						num = (short)235733016;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 5:
						feature.CalculateValidity();
						num = (short)1111359501;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 6:
						goto IL_36F;
					case 7:
						if (flag)
						{
							num = (short)1773142035;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_34E;
					case 8:
						return flag;
					case 9:
					{
						num = (short)1519058944;
						short num6 = num;
						global::Motorola.MackinawCPS.CoreFeatures.TrunkingSystem.TrunkingSystem trunkingSystem = global::AcpCommonLib.FeatureManager.GetFeature(2064)[0] as global::Motorola.MackinawCPS.CoreFeatures.TrunkingSystem.TrunkingSystem;
						global::AcpBusinessLayer.AcpSparseLOVField acpSparseLOVField = trunkingSystem.General.TrkSysGeneralSystemType_A9252 as global::AcpBusinessLayer.AcpSparseLOVField;
						num = (short)2061893652;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 10:
						flag = false;
						num = (short)2039742466;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 11:
						goto IL_587;
					case 12:
						goto IL_587;
					case 13:
						goto IL_27F;
					case 14:
						if (3 != index)
						{
							num = (short)364118026;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_34E;
					case 15:
					{
						if (num5 >= feature2.Count)
						{
							num = (short)2022309896;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						(feature2[num5][10178] as global::Motorola.MackinawCPS.CoreFeatures.TrunkingPersonality.General).TrkEmerProfGeneralKeySelect_A8970.CalculateApplicability();
						(feature2[num5][10178] as global::Motorola.MackinawCPS.CoreFeatures.TrunkingPersonality.General).TrkEmerProfGeneralKeySelect_A8970.CalculateValidity();
						(feature2[num5][10176] as global::Motorola.MackinawCPS.CoreFeatures.TrunkingPersonality.AnnouncementGroup).TrkPerAnnouncementGroupAGKeySelect_A7414.CalculateApplicability();
						(feature2[num5][10176] as global::Motorola.MackinawCPS.CoreFeatures.TrunkingPersonality.AnnouncementGroup).TrkPerAnnouncementGroupAGKeySelect_A7414.CalculateValidity();
						int num4 = 0;
						num = (short)459145234;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 16:
						num5++;
						num = (short)216072192;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 17:
						if (radInfoLabtoolQA02811TrkSingleSysTrigger_A.Value)
						{
							num = (short)67043337;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						flag = true;
						num = (short)37421068;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 18:
						goto IL_222;
					case 19:
						num = (short)1202978838;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 20:
					{
						global::Motorola.MackinawCPS.CoreFeatures.TrunkingSystem.TrunkingSystem trunkingSystem;
						if (self.Parent == trunkingSystem)
						{
							num = (short)1853816855;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						global::AcpBusinessLayer.AcpSparseLOVField acpSparseLOVField;
						flag = (index == acpSparseLOVField.Value);
						num = (short)1655963659;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 21:
						num = (short)1940848654;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 22:
						if (radInfoLabtoolP25CommonAirInterface_A.Value)
						{
							num = (short)488243221;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_34E;
					case 23:
						flag = true;
						num = (short)883752961;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 24:
						goto IL_222;
					}
					goto IL_DC;
					IL_222:
					num = (short)987955204;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_27F:
					global::Motorola.MackinawCPS.CoreFeatures.RadioInformation.RadioInformation radioInformation = global::AcpCommonLib.FeatureManager.GetFeature(2049)[0] as global::Motorola.MackinawCPS.CoreFeatures.RadioInformation.RadioInformation;
					radInfoLabtoolQA02811TrkSingleSysTrigger_A = radioInformation.Labtool.RadInfoLabtoolQA02811TrkSingleSysTrigger_A41198;
					feature2 = global::AcpCommonLib.FeatureManager.GetFeature(2072);
					radInfoLabtoolP25CommonAirInterface_A = radioInformation.Labtool.RadInfoLabtoolP25CommonAirInterface_A42122;
					flag = false;
					num = (short)1698693121;
					if (num != 0)
					{
					}
					num = (short)1593835537;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_34E:
					num5 = 0;
					num = (short)1965359110;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_36F:
					num = (short)791609359;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_587:
					num = (short)773980167;
					num2 = (int)((global::System.IntPtr)num);
				}
				return flag;
				IL_DC:
				feature = global::AcpCommonLib.FeatureManager.GetFeature(2076);
				goto IL_E7;
			}
			}
		}

		// Token: 0x06000BE0 RID: 3040 RVA: 0x000BDA1C File Offset: 0x000BBC1C
		public static bool ConTrkPer7494CallValidityConstraint(global::AcpCommonLib.IAcpFeatureSection self)
		{
			switch (0)
			{
			case 0:
				goto IL_7D;
			}
			short num;
			int num3;
			global::AcpCommonLib.IAcpRecordset feature;
			int num6;
			for (;;)
			{
				IL_0A:
				num = (short)1492875294;
				short num2 = num;
				num = (short)949975070;
				switch ((num2 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					break;
				default:
					num = (short)2112880640;
					if (num != 0)
					{
					}
					switch (num3)
					{
					case 0:
					{
						num = (short)133365760;
						short num4 = num;
						goto IL_211;
					}
					case 1:
						goto IL_A1;
					case 2:
						goto IL_F0;
					case 3:
					{
						num = (short)1740242945;
						if (num != 0)
						{
						}
						int num5;
						if (num5 >= (feature[num6][10179] as global::Motorola.MackinawCPS.CoreFeatures.TrunkingPersonality.Talkgroup).EmbeddedRecset.Count)
						{
							num = (short)807927813;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						}
						((feature[num6][10179] as global::Motorola.MackinawCPS.CoreFeatures.TrunkingPersonality.Talkgroup).EmbeddedRecset[num5][10180] as global::Motorola.MackinawCPS.CoreFeatures.TrunkingPersonality.TalkgroupInnerSection).TrkPerTalkgroupKeySelect_A8365.CalculateApplicability();
						((feature[num6][10179] as global::Motorola.MackinawCPS.CoreFeatures.TrunkingPersonality.Talkgroup).EmbeddedRecset[num5][10180] as global::Motorola.MackinawCPS.CoreFeatures.TrunkingPersonality.TalkgroupInnerSection).TrkPerTalkgroupKeySelect_A8365.CalculateValidity();
						num5++;
						num = (short)1749745666;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 4:
					{
						if (num6 >= feature.Count)
						{
							num = (short)710541319;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						}
						(feature[num6][10178] as global::Motorola.MackinawCPS.CoreFeatures.TrunkingPersonality.General).TrkEmerProfGeneralKeySelect_A8970.CalculateApplicability();
						(feature[num6][10178] as global::Motorola.MackinawCPS.CoreFeatures.TrunkingPersonality.General).TrkEmerProfGeneralKeySelect_A8970.CalculateValidity();
						(feature[num6][10176] as global::Motorola.MackinawCPS.CoreFeatures.TrunkingPersonality.AnnouncementGroup).TrkPerAnnouncementGroupAGKeySelect_A7414.CalculateApplicability();
						(feature[num6][10176] as global::Motorola.MackinawCPS.CoreFeatures.TrunkingPersonality.AnnouncementGroup).TrkPerAnnouncementGroupAGKeySelect_A7414.CalculateValidity();
						int num5 = 0;
						num = (short)1498021894;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 5:
						num6++;
						num = (short)1204158464;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					case 6:
						goto IL_F0;
					case 7:
						return true;
					}
					goto IL_7D;
					IL_F0:
					num = (short)1821442051;
					num3 = (int)((global::System.IntPtr)num);
					continue;
				}
				IL_211:
				num = (short)209649668;
				num3 = (int)((global::System.IntPtr)num);
				continue;
				IL_A1:
				goto IL_211;
			}
			return true;
			IL_7D:
			feature = global::AcpCommonLib.FeatureManager.GetFeature(2072);
			num6 = 0;
			num = (short)944242689;
			num3 = (int)((global::System.IntPtr)num);
			goto IL_0A;
		}

		// Token: 0x06000BE1 RID: 3041 RVA: 0x000BDD10 File Offset: 0x000BBF10
		internal static bool ConGrayIfTrkSysTypeIsTypeII(global::AcpCommonLib.IAcpFeatureSection self)
		{
			short num = (short)1892220928;
			short num2 = num;
			num = (short)1807185429;
			short num3 = num;
			num = (short)1964733973;
			switch (num3 == num)
			{
			}
			num = (short)1588592641;
			if (num != 0)
			{
			}
			num = (short)1591017472;
			if (num != 0)
			{
			}
			return (self.ParentRecset.ParentSection.Parent as global::Motorola.MackinawCPS.CoreFeatures.TrunkingSystem.TrunkingSystem).General.TrkSysGeneralSystemType_A9252.Value == 3;
		}

		// Token: 0x06000BE2 RID: 3042 RVA: 0x000BDDE4 File Offset: 0x000BBFE4
		public static bool conUnitIDNotEqualASTRO25GroupIDAndRangeCheckBasedOnSystemType(global::AcpCommonLib.IAcpFeatureSection self)
		{
			bool result;
			for (;;)
			{
				IL_00:
				short num = (short)347930624;
				short num2 = num;
				num = (short)1317863424;
				int num3 = (int)num;
				switch (num3)
				{
				default:
				{
					switch (0)
					{
					case 0:
						goto IL_AF;
					}
					global::Motorola.MackinawCPS.CoreFeatures.TrunkingSystem.General general;
					global::AcpBusinessLayer.AcpSimpleRangeField trkSysGeneralUnitID_A;
					for (;;)
					{
						IL_50:
						int num4;
						switch (num3)
						{
						case 0:
							goto IL_25E;
						case 1:
							num = (short)706478091;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						case 2:
							if (general.TrkSysGeneralSystemType_A9252.Value == 2)
							{
								num = (short)871366657;
								num3 = (int)((global::System.IntPtr)num);
								continue;
							}
							num = (short)107020304;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						case 3:
							goto IL_25E;
						case 4:
							if (trkSysGeneralUnitID_A.Value <= 65534)
							{
								num = (short)513343500;
								num3 = (int)((global::System.IntPtr)num);
								continue;
							}
							return result;
						case 5:
							if (general.DataProfilesForTrkSysGeneralDataProfileSelection_A19449.TrunkingGroupID.EmbeddedRecset != null)
							{
								num = (short)1444544521;
								num3 = (int)((global::System.IntPtr)num);
								continue;
							}
							return result;
						case 6:
							goto IL_1DD;
						case 7:
							result = false;
							num = (short)580976646;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						case 8:
						{
							if (num4 >= general.DataProfilesForTrkSysGeneralDataProfileSelection_A19449.TrunkingGroupID.EmbeddedRecset.Count)
							{
								num = (short)1433600019;
								num3 = (int)((global::System.IntPtr)num);
								continue;
							}
							global::Motorola.MackinawCPS.CoreFeatures.DataProfiles.TrunkingGroupIDListInner trunkingGroupIDListInner = general.DataProfilesForTrkSysGeneralDataProfileSelection_A19449.TrunkingGroupID.EmbeddedRecset[num4] as global::Motorola.MackinawCPS.CoreFeatures.DataProfiles.TrunkingGroupIDListInner;
							num = (short)1168769039;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						}
						case 9:
							num4 = 0;
							num = (short)990576643;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						case 10:
							if (general.DataProfilesForTrkSysGeneralDataProfileSelection_A19449 != null)
							{
								num = (short)2012610578;
								num3 = (int)((global::System.IntPtr)num);
								continue;
							}
							return result;
						case 11:
							if (trkSysGeneralUnitID_A.Value >= 1)
							{
								num = (short)539230229;
								num3 = (int)((global::System.IntPtr)num);
								continue;
							}
							return result;
						case 12:
							result = true;
							num = (short)749797390;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						case 13:
							num = (short)576389121;
							if (num != 0)
							{
							}
							num = (short)1329004561;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						case 14:
							return result;
						case 15:
						{
							global::Motorola.MackinawCPS.CoreFeatures.DataProfiles.TrunkingGroupIDListInner trunkingGroupIDListInner;
							if (trkSysGeneralUnitID_A.Value == trunkingGroupIDListInner.TrunkingGroupIDListInnerSection.DataProfilesTrunkingGroupID_ASTRO25DataGroupID_A36204.Value)
							{
								num = (short)2111897607;
								num3 = (int)((global::System.IntPtr)num);
								continue;
							}
							goto IL_1DD;
						}
						case 16:
							if (trkSysGeneralUnitID_A.Value >= 1)
							{
								num = (short)1562771469;
								num3 = (int)((global::System.IntPtr)num);
								continue;
							}
							return result;
						case 17:
						{
							num = (short)1770501259;
							short num5 = num;
							num = (short)1409004683;
							switch ((num5 == num) ? 1 : 0)
							{
							case 0:
							case 2:
								goto IL_00;
							default:
								num = (short)1866334208;
								if (num != 0)
								{
								}
								if (trkSysGeneralUnitID_A.Value <= 16777211)
								{
									num = (short)852885524;
									num3 = (int)((global::System.IntPtr)num);
									continue;
								}
								return result;
							}
							break;
						}
						case 18:
							num = (short)1952120837;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						case 19:
							return result;
						case 20:
							result = true;
							num = (short)29229066;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						case 21:
							num = (short)847839236;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						}
						break;
						IL_1DD:
						num4++;
						num = (short)693305344;
						num3 = (int)((global::System.IntPtr)num);
						continue;
						IL_25E:
						num = (short)851574792;
						num3 = (int)((global::System.IntPtr)num);
					}
					IL_AF:
					general = (self as global::Motorola.MackinawCPS.CoreFeatures.TrunkingSystem.General);
					trkSysGeneralUnitID_A = general.TrkSysGeneralUnitID_A12651;
					result = false;
					num = (short)1801388034;
					num3 = (int)((global::System.IntPtr)num);
					goto IL_50;
				}
				}
			}
			return result;
		}

		// Token: 0x06000BE3 RID: 3043 RVA: 0x000BE240 File Offset: 0x000BC440
		internal static bool ConIsSmartZoneOrSmartNet(global::AcpCommonLib.IAcpFeatureSection self)
		{
			short num = (short)2033992821;
			short num2 = num;
			num = (short)339166325;
			switch ((num2 == num) ? 1 : 0)
			{
			case 0:
			case 2:
				goto IL_BC;
			case 1:
				break;
			default:
			{
				num = (short)113901568;
				short num3 = num;
				break;
			}
			}
			num = (short)1659502593;
			if (num != 0)
			{
			}
			num = (short)2030370816;
			if (num != 0)
			{
			}
			global::Motorola.MackinawCPS.CoreFeatures.TrunkingSystem.ControlChannelsInnerSection controlChannelsInnerSection = self as global::Motorola.MackinawCPS.CoreFeatures.TrunkingSystem.ControlChannelsInnerSection;
			if (controlChannelsInnerSection.RefRadioInformation.Labtool.RadInfoLabtoolH38G51Smartzone_A8185.Value)
			{
				return true;
			}
			IL_BC:
			return controlChannelsInnerSection.RefRadioInformation.Labtool.RadInfoLabtoolH37G50Smartnet_A8184.Value;
		}

		// Token: 0x06000BE4 RID: 3044 RVA: 0x000BE324 File Offset: 0x000BC524
		public static bool conValidateTypeIIFreqBand(global::AcpCommonLib.IAcpFeatureSection self, int index)
		{
			short num = (short)863240192;
			int num2 = (int)num;
			switch (num2)
			{
			default:
			{
				switch (0)
				{
				case 0:
					goto IL_1D8;
				}
				global::Motorola.MackinawCPS.CoreFeatures.TrunkingSystem.General general;
				global::AcpBusinessLayer.AcpField<bool> radInfoLabtoolDualBandEnable_A;
				global::AcpBusinessLayer.AcpListField radInfoLabtoolPrimaryBands_A;
				bool flag3;
				bool flag4;
				bool flag5;
				bool flag6;
				global::AcpBusinessLayer.AcpField<bool> radInfoFrequencyRangesAllowInvalidFrequencies_A;
				global::AcpBusinessLayer.AcpListField radInfoLabtoolSecondaryBands_A;
				bool flag8;
				for (;;)
				{
					IL_29:
					bool flag;
					bool flag2;
					bool flag7;
					bool flag9;
					bool flag10;
					bool flag11;
					switch (num2)
					{
					case 0:
						if (general.RefRadioInformation.Labtool.RadInfoLabtoolGA04892_8900MHZ_A44827.Value != 3)
						{
							num = (short)250675288;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_D48;
					case 1:
						goto IL_D48;
					case 2:
						flag = false;
						goto IL_9B1;
					case 3:
						flag2 = radInfoLabtoolDualBandEnable_A.Value;
						goto IL_6DF;
					case 4:
						if (general.RefRadioInformation.Labtool.RadInfoLabtoolGA04892_8900MHZ_A44827.Value != 3)
						{
							num = (short)1094058054;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_39B;
					case 5:
						num = (short)1641742368;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 6:
						if (!global::ConstraintHelper.UtilityMack.IsFreonRadio)
						{
							num = (short)1905524820;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)680198188;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 7:
						if (radInfoLabtoolPrimaryBands_A.Value != 1)
						{
							num = (short)161153099;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_D29;
					case 8:
						num = (short)1043333121;
						if (num != 0)
						{
						}
						if (!flag3)
						{
							num = (short)2106261531;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return true;
					case 9:
						num = (short)1466695757;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 10:
						if (global::ConstraintHelper.UtilityMack.IsFreonRadio)
						{
							num = (short)1829568523;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)1066532925;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 11:
						flag4 = general.RefRadioInformation.Labtool.RadInfoLabtoolQA00570VHF_A37151.Value;
						flag5 = general.RefRadioInformation.Labtool.RadInfoLabtoolQA00571UHFRange1_A42594.Value;
						flag6 = general.RefRadioInformation.Labtool.RadInfoLabtoolQA00572UHFRange2_A42595.Value;
						num = (short)1292894293;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 12:
						flag7 = true;
						goto IL_C6F;
					case 13:
						flag2 = false;
						goto IL_6DF;
					case 14:
						if (!general.RefRadioInformation.Labtool.RadInfoLabtool900MHzEnable_A42570.Value)
						{
							num = (short)1431240730;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_39B;
					case 15:
						if (!flag4)
						{
							num = (short)1843069023;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return true;
					case 16:
						if (radInfoFrequencyRangesAllowInvalidFrequencies_A.Value)
						{
							num = (short)1573978158;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return false;
					case 17:
						num = (short)1834614800;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 18:
						num = (short)1032585287;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 19:
						if (radInfoLabtoolPrimaryBands_A.Value != 4)
						{
							num = (short)1784873064;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_57A;
					case 20:
						if (radInfoLabtoolSecondaryBands_A.Value == 3)
						{
							num = (short)1491861553;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)1084751965;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 21:
						if (radInfoLabtoolPrimaryBands_A.Value != 6)
						{
							num = (short)1274740771;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)1285357626;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 22:
						flag7 = radInfoLabtoolDualBandEnable_A.Value;
						goto IL_C6F;
					case 23:
						num = (short)279117827;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 24:
						if (radInfoLabtoolSecondaryBands_A.Value == 8)
						{
							num = (short)1684602922;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)607715382;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 25:
						goto IL_656;
					case 26:
						num = (short)832503812;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 27:
						num = (short)2140471359;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 28:
						num = (short)622329956;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 29:
						goto IL_DF4;
					case 30:
						num = (short)1898315838;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 31:
					{
						num = (short)478273655;
						short num3 = num;
						num = (short)1887559799;
						switch ((num3 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							return true;
						default:
							num = (short)2228224;
							if (num != 0)
							{
							}
							num = (short)1962999814;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						break;
					}
					case 32:
						if (!radInfoLabtoolDualBandEnable_A.Value)
						{
							num = (short)1922826327;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_AA3;
					case 33:
						num = (short)1886715949;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 34:
						num = (short)1734148096;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 35:
						num = (short)1069875257;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 36:
						goto IL_E76;
					case 37:
						if (!general.RefRadioInformation.FrequencyRanges.RadInfoFrequencyRanges900MHzUsedinCodeplug_A8516.Value)
						{
							num = (short)1194393669;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return true;
					case 38:
						num = (short)1120534542;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 39:
						if (general.RefRadioInformation.Labtool.RadInfoLabtoolQA00569_7800MHZ_A42596.Value != 3)
						{
							num = (short)1947598882;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_D48;
					case 40:
						num = (short)1213202469;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 41:
						if (!general.RefRadioInformation.FrequencyRanges.RadInfoFrequencyRanges7800MHzUsedinCodeplug_A8512.Value)
						{
							num = (short)231669833;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_7B6;
					case 42:
						num = (short)389546086;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 43:
						if (!radInfoLabtoolDualBandEnable_A.Value)
						{
							num = (short)635633693;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_57A;
					case 44:
						if (!flag8)
						{
							num = (short)450494473;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return true;
					case 45:
						if (radInfoLabtoolSecondaryBands_A.Value == 4)
						{
							num = (short)1477967939;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_DF4;
					case 46:
						num = (short)482279465;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 47:
						goto IL_870;
					case 48:
						if (radInfoLabtoolSecondaryBands_A.Value == 5)
						{
							num = (short)1812987927;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)1803550733;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 49:
						num = (short)1355481110;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 50:
						num = (short)978583576;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 51:
						flag2 = true;
						goto IL_6DF;
					case 52:
						if (!flag5)
						{
							num = (short)1517289571;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return true;
					case 53:
						if (radInfoFrequencyRangesAllowInvalidFrequencies_A.Value)
						{
							num = (short)574488601;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return false;
					case 54:
						flag9 = false;
						goto IL_10C8;
					case 55:
						flag = radInfoLabtoolDualBandEnable_A.Value;
						goto IL_9B1;
					case 56:
						flag9 = true;
						goto IL_10C8;
					case 57:
						flag10 = (radInfoLabtoolPrimaryBands_A.Value == 7);
						goto IL_C50;
					case 58:
						flag10 = true;
						goto IL_C50;
					case 59:
						flag11 = true;
						goto IL_A51;
					case 60:
						if (!flag8)
						{
							num = (short)751829009;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return true;
					case 61:
						if (radInfoLabtoolPrimaryBands_A.Value != 2)
						{
							num = (short)807665746;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_AA3;
					case 62:
						if (radInfoLabtoolSecondaryBands_A.Value == 2)
						{
							num = (short)1506934789;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_E7B;
					case 63:
						if (radInfoFrequencyRangesAllowInvalidFrequencies_A.Value)
						{
							num = (short)1798045736;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return false;
					case 64:
						goto IL_ED4;
					case 65:
						if (general.RefRadioInformation.FrequencyRanges.RadInfoFrequencyRanges700MHzUsedinCodeplug_A42551.Value)
						{
							num = (short)2024341551;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return false;
					case 66:
						flag = true;
						goto IL_9B1;
					case 67:
						num = (short)376111147;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 68:
						if (general.RefRadioInformation.Labtool.RadInfoLabtoolGA04892_8900MHZ_A44827.Value == 1)
						{
							num = (short)275054593;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_ED4;
					case 69:
						goto IL_403;
					case 70:
						num = (short)1505230942;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 71:
						if (radInfoLabtoolSecondaryBands_A.Value == 1)
						{
							num = (short)813760608;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)366608386;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 72:
						num = (short)1358692367;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 73:
						goto IL_4E3;
					case 74:
						if (radInfoLabtoolPrimaryBands_A.Value != 8)
						{
							num = (short)196018226;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)2228280;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 75:
						num = (short)443220071;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 76:
						if (index == 1)
						{
							num = (short)1383989327;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)693698657;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 77:
						if (radInfoFrequencyRangesAllowInvalidFrequencies_A.Value)
						{
							num = (short)592511067;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return false;
					case 78:
						if (!flag6)
						{
							num = (short)1957298204;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return true;
					case 79:
						num = (short)1935671348;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 80:
						if (index == 4)
						{
							num = (short)682950757;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return false;
					case 81:
						if (radInfoFrequencyRangesAllowInvalidFrequencies_A.Value)
						{
							num = (short)613220435;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return false;
					case 82:
						num = (short)99024982;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 83:
						goto IL_BA1;
					case 84:
						num = (short)1208221756;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 85:
						if (radInfoLabtoolPrimaryBands_A.Value != 7)
						{
							num = (short)1241251878;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_39B;
					case 86:
						if (radInfoLabtoolPrimaryBands_A.Value != 3)
						{
							num = (short)1104347166;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_AA3;
					case 87:
						goto IL_E7B;
					case 88:
						num = (short)614596676;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 89:
						goto IL_ED4;
					case 90:
						if (index == 0)
						{
							num = (short)1259536456;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)1322844236;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 91:
						num = (short)806027329;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 92:
						if (radInfoLabtoolPrimaryBands_A.Value != 5)
						{
							num = (short)93847585;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_57A;
					case 93:
						flag7 = false;
						goto IL_C6F;
					case 94:
						flag11 = (general.RefRadioInformation.Labtool.RadInfoLabtoolGA04892_8900MHZ_A44827.Value == 2);
						goto IL_A51;
					case 95:
						num = (short)170524753;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 96:
						num = (short)1414725687;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 97:
						if (index == 2)
						{
							num = (short)1852964962;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)1329266793;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 98:
						num = (short)822214734;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 99:
						num = (short)139984949;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 100:
						if (radInfoFrequencyRangesAllowInvalidFrequencies_A.Value)
						{
							num = (short)1343815716;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return false;
					case 101:
						num = (short)1610874888;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 102:
						flag9 = radInfoLabtoolDualBandEnable_A.Value;
						goto IL_10C8;
					case 103:
						if (radInfoLabtoolPrimaryBands_A.Value != 7)
						{
							num = (short)1411973138;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_D29;
					case 104:
						num = (short)241303644;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 105:
						if (index == 3)
						{
							num = (short)430112799;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)560529488;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_1D8;
					IL_39B:
					num = (short)670040123;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_57A:
					num = (short)1515454515;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_6DF:
					flag5 = flag2;
					num = (short)841351242;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_9B1:
					flag8 = flag;
					num = (short)269942805;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_A51:
					flag3 = flag11;
					num = (short)626655271;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_AA3:
					num = (short)752943116;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_C50:
					flag3 = flag10;
					num = (short)344457305;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_C6F:
					flag4 = flag7;
					num = (short)1169817619;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_D29:
					num = (short)901447746;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_D48:
					flag8 = true;
					num = (short)2007892032;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_DF4:
					num = (short)909312048;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_E7B:
					num = (short)579534868;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_ED4:
					num = (short)1452408922;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_10C8:
					flag6 = flag9;
					num = (short)1512374279;
					num2 = (int)((global::System.IntPtr)num);
				}
				return false;
				IL_403:
				return general.RefRadioInformation.FrequencyRanges.RadInfoFrequencyRanges8900MHzUsedinCodeplug_A42502.Value;
				IL_4E3:
				return general.RefRadioInformation.FrequencyRanges.RadInfoFrequencyRanges8900MHzUsedinCodeplug_A42502.Value;
				IL_656:
				return general.RefRadioInformation.FrequencyRanges.RadInfoFrequencyRangesUHF1UsedinCodeplug_A8504.Value;
				IL_7B6:
				num = (short)2104295424;
				short num4 = num;
				return true;
				IL_870:
				return general.RefRadioInformation.FrequencyRanges.RadInfoFrequencyRanges800MHzUsedinCodeplug_A42552.Value;
				IL_BA1:
				return general.RefRadioInformation.FrequencyRanges.RadInfoFrequencyRangesVHFUsedinCodeplug_A8481.Value;
				IL_E76:
				return general.RefRadioInformation.FrequencyRanges.RadInfoFrequencyRangesUHF2UsedinCodeplug_A8507.Value;
				IL_1D8:
				general = (self as global::Motorola.MackinawCPS.CoreFeatures.TrunkingSystem.General);
				radInfoLabtoolPrimaryBands_A = general.RefRadioInformation.Labtool.RadInfoLabtoolPrimaryBands_A23987;
				radInfoLabtoolSecondaryBands_A = general.RefRadioInformation.Labtool.RadInfoLabtoolSecondaryBands_A23988;
				radInfoLabtoolDualBandEnable_A = general.RefRadioInformation.Labtool.RadInfoLabtoolDualBandEnable_A23986;
				radInfoFrequencyRangesAllowInvalidFrequencies_A = general.RefRadioInformation.FrequencyRanges.RadInfoFrequencyRangesAllowInvalidFrequencies_A12493;
				flag4 = false;
				flag5 = false;
				flag6 = false;
				flag8 = false;
				flag3 = false;
				num = (short)1959985162;
				num2 = (int)((global::System.IntPtr)num);
				goto IL_29;
			}
			}
		}

		// Token: 0x06000BE5 RID: 3045 RVA: 0x000BF4CC File Offset: 0x000BD6CC
		internal static bool ConTrkSysTypeIsIIOrAstro25(global::AcpCommonLib.IAcpFeatureSection self)
		{
			global::AcpBusinessLayer.AcpListField trkSysGeneralSystemType_A;
			short num;
			for (;;)
			{
				trkSysGeneralSystemType_A = (self.Parent as global::Motorola.MackinawCPS.CoreFeatures.TrunkingSystem.TrunkingSystem).General.TrkSysGeneralSystemType_A9252;
				if (trkSysGeneralSystemType_A.Value == 2)
				{
					return true;
				}
				num = (short)355385875;
				short num2 = num;
				num = (short)1355072019;
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
			num = (short)1847656449;
			if (num != 0)
			{
			}
			num = (short)413466624;
			short num3 = num;
			num = (short)1051394048;
			if (num != 0)
			{
			}
			return trkSysGeneralSystemType_A.Value == 3;
		}

		// Token: 0x06000BE6 RID: 3046 RVA: 0x000BF5A0 File Offset: 0x000BD7A0
		public static bool ConTrkSysDynRegroupChannelIsValid(global::AcpCommonLib.IAcpFeatureSection self, int index)
		{
			short num = (short)107610112;
			int num2 = (int)num;
			switch (num2)
			{
			default:
			{
				switch (0)
				{
				case 0:
					goto IL_C2;
				}
				global::AcpBusinessLayer.FeatureNode featureNode;
				global::AcpBusinessLayer.AcpRecRefField trkSysFeaturesChannel_A;
				global::Motorola.MackinawCPS.CoreFeatures.TrunkingSystem.Features features;
				for (;;)
				{
					IL_27:
					global::Motorola.MackinawCPS.CoreFeatures.ZoneChannelAssignment.ChannelAssignmentListInner channelAssignmentListInner;
					global::AcpCommonLib.IAcpFeatureNode acpFeatureNode;
					global::Motorola.MackinawCPS.CoreFeatures.ZoneChannelAssignment.ChannelAssignmentListInner channelAssignmentListInner2;
					global::Motorola.MackinawCPS.CoreFeatures.ZoneChannelAssignment.ChannelAssignmentListInner channelAssignmentListInner3;
					switch (num2)
					{
					case 0:
						num = (short)1339817997;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 1:
					{
						num = (short)1226899456;
						short num3 = num;
						num = (short)780206092;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 2:
						num = (short)930480157;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 3:
						goto IL_11A;
					case 4:
						if (channelAssignmentListInner.ChannelAssignmentListInnerSection.ZnChanCfgChannelsChannelType_A22241.Value == 1)
						{
							num = (short)232128533;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return false;
					case 5:
						num = (short)1285554190;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 6:
						num = (short)662175779;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 7:
					{
						global::System.Collections.Generic.IEnumerator<global::AcpBusinessLayer.FeatureNode> enumerator = featureNode.ReferencingNodes.GetEnumerator();
						num = (short)339804186;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 8:
						acpFeatureNode = trkSysFeaturesChannel_A.RefRecset[index - 1];
						goto IL_808;
					case 9:
					{
						num = (short)807485529;
						short num4 = num;
						num = (short)1929592921;
						switch ((num4 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_285;
						default:
							num = (short)1370095616;
							if (num != 0)
							{
							}
							channelAssignmentListInner2 = (trkSysFeaturesChannel_A.RefRecset[index - 1] as global::Motorola.MackinawCPS.CoreFeatures.ZoneChannelAssignment.ChannelAssignmentListInner);
							goto IL_8C6;
						}
						break;
					}
					case 10:
						acpFeatureNode = trkSysFeaturesChannel_A.RefRecset[0];
						goto IL_808;
					case 11:
						if (channelAssignmentListInner != null)
						{
							num = (short)1428226053;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return false;
					case 12:
						if (channelAssignmentListInner3.Position > 48)
						{
							num = (short)1816199183;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_1E6;
					case 13:
						channelAssignmentListInner2 = null;
						goto IL_8C6;
					case 14:
						if (features.TrkSysFeaturesZone_A9717.ParentNode != null)
						{
							num = (short)137363476;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return false;
					case 15:
						return false;
					case 16:
						if (trkSysFeaturesChannel_A.RefRecset == null)
						{
							num = (short)519962654;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)537133083;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 17:
						num = (short)409731082;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 18:
						num = (short)123469847;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 19:
						goto IL_285;
					case 20:
						num = (short)751239172;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 21:
						num = (short)1227161619;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 22:
						if (index <= 0)
						{
							num = (short)613285905;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_750;
					case 23:
					{
						global::Motorola.MackinawCPS.CoreFeatures.RadioInformation.RadioInformation radioInformation;
						if (radioInformation != null)
						{
							num = (short)247398433;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_1E6;
					}
					case 24:
						if (channelAssignmentListInner3 != null)
						{
							num = (short)1487601682;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_1E6;
					case 25:
						if (index != 0)
						{
							num = (short)1843200003;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return false;
					case 26:
						try
						{
							num = (short)417398804;
							num2 = (int)((global::System.IntPtr)num);
							bool result;
							for (;;)
							{
								switch (num2)
								{
								case 0:
								{
									global::Motorola.MackinawCPS.CoreFeatures.TrunkingPersonality.TrunkingPersonality trunkingPersonality;
									if (1 != trunkingPersonality.General.TrkPerGeneralDisableTransmitMode_A41742.Value)
									{
										num = (short)597557254;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									goto IL_3D0;
								}
								case 1:
								{
									global::Motorola.MackinawCPS.CoreFeatures.TrunkingPersonality.TrunkingPersonality trunkingPersonality;
									if (trunkingPersonality == channelAssignmentListInner.ChannelAssignmentListInnerSection.ZnChanCfgChannelsPersonality_A8698.ReferencedNode)
									{
										num = (short)1622999045;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									break;
								}
								case 2:
								{
									global::Motorola.MackinawCPS.CoreFeatures.TrunkingPersonality.TrunkingPersonality trunkingPersonality;
									if (trunkingPersonality != null)
									{
										num = (short)1622016011;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									goto IL_3D0;
								}
								case 3:
								{
									global::AcpBusinessLayer.FeatureNode featureNode2;
									if (featureNode2 is global::Motorola.MackinawCPS.CoreFeatures.TrunkingPersonality.TrunkingPersonality)
									{
										num = (short)231407625;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									break;
								}
								case 4:
									num = (short)2095710208;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 5:
									num = (short)364576790;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 6:
									features.ChannelAssignmentListInnerSectionForTrkSysFeaturesChannel_A7647.ChannelAssignmentListInnerSection.ZnChanCfgChannelsTalkgroup_A9276_Valid = true;
									num = (short)160628755;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 7:
									num = (short)1234173962;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 8:
								{
									global::Motorola.MackinawCPS.CoreFeatures.TrunkingPersonality.TrunkingPersonality trunkingPersonality;
									if (trunkingPersonality.General != null)
									{
										num = (short)1720909831;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									goto IL_3D0;
								}
								case 9:
								{
									global::AcpBusinessLayer.FeatureNode featureNode2;
									global::Motorola.MackinawCPS.CoreFeatures.TrunkingPersonality.TrunkingPersonality trunkingPersonality = featureNode2 as global::Motorola.MackinawCPS.CoreFeatures.TrunkingPersonality.TrunkingPersonality;
									num = (short)655294465;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 10:
								{
									global::Motorola.MackinawCPS.CoreFeatures.TrunkingPersonality.TrunkingPersonality trunkingPersonality;
									if (trunkingPersonality.General.TrkPerGeneralDisableTransmitMode_A41742 != null)
									{
										num = (short)982908932;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									goto IL_3D0;
								}
								case 11:
									num = (short)21823496;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 12:
									goto IL_57C;
								case 13:
									num = (short)1458307095;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 14:
									goto IL_560;
								case 15:
									goto IL_4F4;
								case 16:
								{
									global::System.Collections.Generic.IEnumerator<global::AcpBusinessLayer.FeatureNode> enumerator;
									if (!enumerator.MoveNext())
									{
										num = (short)664338449;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									global::AcpBusinessLayer.FeatureNode featureNode2 = enumerator.Current;
									num = (short)361037827;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 17:
									num = (short)1520435221;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 18:
									if (features.TrkSysFeaturesDynamicRegroupingEnable_A7969.Value)
									{
										num = (short)978452504;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									goto IL_4F4;
								case 19:
									goto IL_3D0;
								case 20:
									switch (0)
									{
									case 0:
										goto IL_350;
									}
									continue;
								case 21:
									goto IL_6DD;
								case 22:
									if (features.TrkSysFeaturesChannel_A7647.Value != 0)
									{
										num = (short)91947021;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									goto IL_3D0;
								case 23:
									if (features.ChannelAssignmentListInnerSectionForTrkSysFeaturesChannel_A7647 != null)
									{
										num = (short)64684058;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									goto IL_3D0;
								case 24:
									num = (short)1935212569;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 25:
									if (features.TrkSysFeaturesZone_A9717.Value != 0)
									{
										num = (short)74252303;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									goto IL_560;
								case 26:
									num = (short)1353580546;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								IL_355:
								num = (short)1212219408;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								IL_350:
								goto IL_355;
								IL_3D0:
								num = (short)2136277010;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								IL_4F4:
								features.TrkSysFeaturesZone_A9717_Valid = true;
								num = (short)1994588174;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								IL_560:
								result = true;
								num = (short)876216332;
								num2 = (int)((global::System.IntPtr)num);
							}
							IL_57C:
							return result;
							IL_6DD:
							return false;
						}
						finally
						{
							num = (short)1348534272;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								global::System.Collections.Generic.IEnumerator<global::AcpBusinessLayer.FeatureNode> enumerator;
								switch (num2)
								{
								case 0:
									switch (0)
									{
									case 0:
										goto IL_715;
									}
									continue;
								case 1:
									enumerator.Dispose();
									num = (short)1835139074;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 2:
									goto IL_74D;
								}
								IL_715:
								if (enumerator == null)
								{
									break;
								}
								num = (short)1390149633;
								num2 = (int)((global::System.IntPtr)num);
							}
							IL_74D:;
						}
						goto IL_750;
					case 27:
						if (index >= 0)
						{
							num = (short)2038890502;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return false;
					case 28:
						if (features.TrkSysFeaturesDynamicRegroupingEnable_A7969.Value)
						{
							num = (short)1865154594;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_11A;
					case 29:
						num = (short)1485766657;
						if (num != 0)
						{
						}
						if (channelAssignmentListInner.ChannelAssignmentListInnerSection.ParentRecset.ParentSection.Parent == features.TrkSysFeaturesZone_A9717.ReferencedNode)
						{
							num = (short)1710948359;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return false;
					case 30:
						return false;
					case 31:
						goto IL_9DB;
					case 32:
						if (index <= 0)
						{
							num = (short)1671626752;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)1830027273;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 33:
						num = (short)1852047396;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 34:
						num = (short)991232025;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 35:
					{
						if (index > trkSysFeaturesChannel_A.RefRecset.Count)
						{
							num = (short)689111071;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						global::Motorola.MackinawCPS.CoreFeatures.RadioInformation.RadioInformation radioInformation = global::AcpCommonLib.FeatureManager.GetFeature(2049)[0] as global::Motorola.MackinawCPS.CoreFeatures.RadioInformation.RadioInformation;
						num = (short)1200881696;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 36:
					{
						global::Motorola.MackinawCPS.CoreFeatures.RadioInformation.RadioInformation radioInformation;
						if (radioInformation.Labtool.RadInfoLabtoolProductModelIdentifier_A37178Value == 13)
						{
							num = (short)1342177281;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_1E6;
					}
					}
					goto IL_C2;
					IL_11A:
					num = (short)1191575574;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_1E6:
					num = (short)607453212;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_285:
					if (channelAssignmentListInner.ChannelAssignmentListInnerSection.ZnChanCfgChannelsTalkgroup_A9276.Value == 65535)
					{
						num = (short)747438082;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					return false;
					IL_750:
					num = (short)533594120;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_808:
					channelAssignmentListInner = (acpFeatureNode as global::Motorola.MackinawCPS.CoreFeatures.ZoneChannelAssignment.ChannelAssignmentListInner);
					num = (short)1216282635;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_8C6:
					channelAssignmentListInner3 = channelAssignmentListInner2;
					num = (short)1816854552;
					num2 = (int)((global::System.IntPtr)num);
				}
				return false;
				IL_9DB:
				return false;
				IL_C2:
				features = (self as global::Motorola.MackinawCPS.CoreFeatures.TrunkingSystem.Features);
				featureNode = (self.Parent as global::AcpBusinessLayer.FeatureNode);
				trkSysFeaturesChannel_A = features.TrkSysFeaturesChannel_A7647;
				num = (short)606797840;
				num2 = (int)((global::System.IntPtr)num);
				goto IL_27;
			}
			}
		}

		// Token: 0x06000BE7 RID: 3047 RVA: 0x000C010C File Offset: 0x000BE30C
		internal static bool conValidateTypeIIFreqBandForBlockReport(global::AcpCommonLib.IAcpFeatureSection self)
		{
			short num = (short)1075810737;
			short num2 = num;
			num = (short)41456049;
			switch (num2 == num)
			{
			default:
			{
				num = (short)1715273728;
				short num3 = num;
				break;
			}
			case true:
				break;
			}
			num = (short)309592065;
			if (num != 0)
			{
			}
			num = (short)1726480384;
			if (num != 0)
			{
			}
			return (self as global::Motorola.MackinawCPS.CoreFeatures.TrunkingSystem.General).TrkSysGeneralSystemType_A9252.Value == 2;
		}

		// Token: 0x06000BE8 RID: 3048 RVA: 0x000C01C8 File Offset: 0x000BE3C8
		internal static bool ConTrkSysPhase2VoiceCapableIsEnable(global::AcpCommonLib.IAcpFeatureSection self)
		{
			global::Motorola.MackinawCPS.CoreFeatures.TrunkingSystem.ASTRO26 astro = self as global::Motorola.MackinawCPS.CoreFeatures.TrunkingSystem.ASTRO26;
			global::Motorola.MackinawCPS.CoreFeatures.TrunkingSystem.TrunkingSystem trunkingSystem = self.Parent as global::Motorola.MackinawCPS.CoreFeatures.TrunkingSystem.TrunkingSystem;
			if (astro.TrkSysASTRO25Phase2VoiceCapable_A37972.Value)
			{
				short num = (short)110034944;
				short num2 = num;
			}
			else
			{
				short num = (short)769809694;
				short num3 = num;
				num = (short)611999006;
				switch ((num3 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					break;
				default:
					num = (short)930349057;
					if (num != 0)
					{
					}
					num = (short)1007747072;
					if (num != 0)
					{
					}
					return false;
				}
			}
			return trunkingSystem.General.TrkSysGeneralSystemType_A9252.Value == 3;
		}

		// Token: 0x06000BE9 RID: 3049 RVA: 0x000C02A8 File Offset: 0x000BE4A8
		internal static bool ConIsTDMAFrameSyncBERThresholdApplicable(global::AcpCommonLib.IAcpFeatureSection self)
		{
			switch (0)
			{
			case 0:
				goto IL_20;
			}
			int num;
			global::Motorola.MackinawCPS.CoreFeatures.TrunkingSystem.TrunkingSystem trunkingSystem;
			short num2;
			for (;;)
			{
				IL_0A:
				switch (num)
				{
				case 0:
					goto IL_15D;
				case 1:
					if (trunkingSystem.ASTRO26.TrkSysASTRO25F2VoiceCapable_A1395.Value)
					{
						num2 = (short)1408892928;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					return false;
				case 2:
				{
					num2 = (short)851436099;
					short num3 = num2;
					num2 = (short)1561059907;
					switch ((num3 == num2) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_DE;
					default:
						num2 = (short)690814976;
						if (num2 != 0)
						{
						}
						if (!trunkingSystem.ASTRO26.TrkSysASTRO25Phase2VoiceCapable_A37972.Value)
						{
							num2 = (short)2084372483;
							num = (int)((global::System.IntPtr)num2);
							continue;
						}
						goto IL_E0;
					}
					break;
				}
				case 3:
					goto IL_DE;
				}
				goto IL_20;
				IL_DE:
				num2 = (short)1911619585;
				if (num2 != 0)
				{
				}
				num2 = (short)1315635201;
				num = (int)((global::System.IntPtr)num2);
			}
			IL_E0:
			return trunkingSystem.General.TrkSysGeneralSystemType_A9252.Value == 3;
			IL_15D:
			goto IL_E0;
			IL_20:
			trunkingSystem = (self.Parent as global::Motorola.MackinawCPS.CoreFeatures.TrunkingSystem.TrunkingSystem);
			num2 = (short)1611530240;
			short num4 = num2;
			num2 = (short)1785462786;
			num = (int)((global::System.IntPtr)num2);
			goto IL_0A;
		}

		// Token: 0x06000BEA RID: 3050 RVA: 0x000C0418 File Offset: 0x000BE618
		internal static bool conTrkTxtMsgValueValid(global::AcpCommonLib.IAcpFeatureSection self, int index)
		{
			short num = (short)1759117312;
			int num2 = (int)num;
			switch (num2)
			{
			default:
			{
				switch (0)
				{
				case 0:
					goto IL_7E;
				}
				int radWideFeaturesSmartMessagingSmartMessageModeValue;
				bool result;
				global::AcpBusinessLayer.AcpListField radWideLabtoolKeypadType_A;
				global::AcpBusinessLayer.AcpRecRefField trkSysGeneralDataProfileSelection_A;
				for (;;)
				{
					IL_27:
					switch (num2)
					{
					case 0:
						num = (short)1640366096;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 1:
						if (radWideFeaturesSmartMessagingSmartMessageModeValue != 1)
						{
							num = (short)748355603;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return result;
					case 2:
						num = (short)1235157000;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 3:
						if (radWideLabtoolKeypadType_A.Value != 3)
						{
							num = (short)1389101058;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_240;
					case 4:
						num = (short)1605042189;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 5:
					{
						num = (short)1640562688;
						short num3 = num;
						result = true;
						num = (short)1037303818;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 6:
						num = (short)1032060931;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 7:
						goto IL_343;
					case 8:
						if (radWideLabtoolKeypadType_A.Value == 2)
						{
							num = (short)1821573137;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return result;
					case 9:
						return result;
					case 10:
						return result;
					case 11:
						return result;
					case 12:
						return result;
					case 13:
						if (radWideLabtoolKeypadType_A.Value != 4)
						{
							num = (short)362348550;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_240;
					case 14:
						switch (index)
						{
						case 0:
							result = true;
							num = (short)1109000201;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 1:
						{
							num = (short)685970099;
							short num4 = num;
							num = (short)146805427;
							switch ((num4 == num) ? 1 : 0)
							{
							case 0:
							case 2:
								goto IL_343;
							default:
								num = (short)1794768896;
								if (num != 0)
								{
								}
								num = (short)964296705;
								if (num != 0)
								{
								}
								num = (short)142147599;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							break;
						}
						case 2:
							num = (short)873332737;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						default:
							num = (short)2019164178;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						break;
					case 15:
						if (radWideFeaturesSmartMessagingSmartMessageModeValue != 1)
						{
							num = (short)458686464;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return result;
					case 16:
						if (trkSysGeneralDataProfileSelection_A.Value != 0)
						{
							num = (short)1844772869;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return result;
					case 17:
						goto IL_240;
					case 18:
						num = (short)1547632651;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 19:
						num = (short)395247623;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_7E;
					IL_240:
					result = true;
					num = (short)1323499532;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_343:
					if (trkSysGeneralDataProfileSelection_A.Value == 0)
					{
						break;
					}
					num = (short)808779780;
					num2 = (int)((global::System.IntPtr)num);
				}
				return result;
				IL_7E:
				global::Motorola.MackinawCPS.CoreFeatures.TrunkingSystem.Features features = self as global::Motorola.MackinawCPS.CoreFeatures.TrunkingSystem.Features;
				trkSysGeneralDataProfileSelection_A = (self.Parent as global::Motorola.MackinawCPS.CoreFeatures.TrunkingSystem.TrunkingSystem).General.TrkSysGeneralDataProfileSelection_A19449;
				radWideLabtoolKeypadType_A = features.RefRadioWide.Labtool.RadWideLabtoolKeypadType_A8372;
				radWideFeaturesSmartMessagingSmartMessageModeValue = features.RefRadioWide.Features.RadWideFeaturesSmartMessagingSmartMessageModeValue;
				result = false;
				num = (short)53149710;
				num2 = (int)((global::System.IntPtr)num);
				goto IL_27;
			}
			}
		}

		// Token: 0x06000BEB RID: 3051 RVA: 0x000C07F8 File Offset: 0x000BE9F8
		public static bool conReturnTrueIfViewSetToLabtoolOrDepot(global::AcpCommonLib.IAcpFeatureSection self)
		{
			short num = (short)991887363;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				switch (num2)
				{
				case 0:
					goto IL_128;
				case 1:
					if (global::AcpCommonLib.AppInfoManager.AppView == global::AcpCommonLib.DifferentiatedUserViewType.Depot)
					{
						num = (short)300875776;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					return false;
				case 2:
					num = (short)1924595713;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 3:
					switch (0)
					{
					case 0:
						goto IL_36;
					}
					continue;
				}
				IL_36:
				num = (short)1461518337;
				if (num != 0)
				{
				}
				if (global::AcpCommonLib.AppInfoManager.AppView == global::AcpCommonLib.DifferentiatedUserViewType.Labtool)
				{
					break;
				}
				num = (short)424804354;
				num2 = (int)((global::System.IntPtr)num);
			}
			IL_7B:
			num = (short)1572958119;
			short num3 = num;
			num = (short)1376481191;
			switch ((num3 == num) ? 1 : 0)
			{
			case 0:
			case 2:
				return false;
			default:
			{
				num = (short)935460864;
				if (num != 0)
				{
				}
				num = (short)2060976128;
				short num4 = num;
				return true;
			}
			}
			IL_128:
			goto IL_7B;
		}

		// Token: 0x06000BEC RID: 3052 RVA: 0x000C0934 File Offset: 0x000BEB34
		internal static bool ConTrkSysApcoAndApcoOmnilinkAndAmssSelIsSmartZoneAndAliasIndicatorIsEnabledEdit(global::AcpCommonLib.IAcpFeatureSection self)
		{
			switch (0)
			{
			case 0:
				goto IL_30;
			}
			int num;
			short num2;
			global::AcpBusinessLayer.AcpListField trkSysGeneralCoverageType_A;
			global::Motorola.MackinawCPS.CoreFeatures.TrunkingSystem.TrunkingSystem trunkingSystem;
			for (;;)
			{
				IL_0A:
				switch (num)
				{
				case 0:
					num2 = (short)1590558721;
					if (num2 != 0)
					{
					}
					if (trkSysGeneralCoverageType_A.Value != 5)
					{
						num2 = (short)407764994;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_104;
				case 1:
					if (trkSysGeneralCoverageType_A.Value == 6)
					{
						num2 = (short)859373573;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					return false;
				case 2:
					num2 = (short)922222593;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 3:
					if (trunkingSystem.General.TrkSysGeneralSystemType_A9252.Value == 3)
					{
						num2 = (short)228458502;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					return false;
				case 4:
					num2 = (short)1770586112;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 5:
					goto IL_18A;
				case 6:
					goto IL_14B;
				case 7:
					if (trkSysGeneralCoverageType_A.Value != 7)
					{
						num2 = (short)1911947264;
						short num3 = num2;
						num2 = (short)870776836;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_104;
				}
				goto IL_30;
			}
			IL_14B:
			return trunkingSystem.SiteAlias.TrkSysSiteAliasSiteAliasEnable_A9148.Value;
			IL_30:
			trunkingSystem = (self.ParentRecset.ParentSection.Parent as global::Motorola.MackinawCPS.CoreFeatures.TrunkingSystem.TrunkingSystem);
			trkSysGeneralCoverageType_A = trunkingSystem.General.TrkSysGeneralCoverageType_A7782;
			num2 = (short)1580609973;
			short num4 = num2;
			num2 = (short)1782919605;
			switch ((num4 == num2) ? 1 : 0)
			{
			case 0:
			case 2:
				IL_18A:
				break;
			default:
				num2 = (short)291831808;
				if (num2 != 0)
				{
				}
				num2 = (short)161808391;
				num = (int)((global::System.IntPtr)num2);
				goto IL_0A;
			}
			IL_104:
			num2 = (short)2083520515;
			num = (int)((global::System.IntPtr)num2);
			goto IL_0A;
		}

		// Token: 0x06000BED RID: 3053 RVA: 0x000C0B4C File Offset: 0x000BED4C
		internal static bool conTrkSysTypeIsIIAndOBTEnabledEdtbl(global::AcpCommonLib.IAcpFeatureSection self)
		{
			short num = (short)1377566725;
			int num2 = (int)((global::System.IntPtr)num);
			global::AcpBusinessLayer.AcpListField trkSysGeneralTypeIIFrequencyBand_A;
			for (;;)
			{
				switch (num2)
				{
				case 0:
					if (trkSysGeneralTypeIIFrequencyBand_A.Value != 0)
					{
						num = (short)1525940226;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					return true;
				case 1:
					num = (short)1661403137;
					if (num != 0)
					{
					}
					num = (short)2037710848;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 2:
					num = (short)295895044;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 3:
				{
					num = (short)1224833469;
					short num3 = num;
					num = (short)1879013821;
					switch ((num3 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_9E;
					default:
						goto IL_117;
					}
					break;
				}
				case 4:
					if (trkSysGeneralTypeIIFrequencyBand_A.Value != 1)
					{
						num = (short)842137603;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					return true;
				case 5:
					switch (0)
					{
					case 0:
						goto IL_3C;
					}
					continue;
				}
				goto IL_3C;
				IL_9E:
				num = (short)901185537;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_3C:
				num = (short)1006632960;
				short num4 = num;
				global::Motorola.MackinawCPS.CoreFeatures.TrunkingSystem.TrunkingSystem trunkingSystem = self.ParentRecset.ParentSection.Parent as global::Motorola.MackinawCPS.CoreFeatures.TrunkingSystem.TrunkingSystem;
				trkSysGeneralTypeIIFrequencyBand_A = trunkingSystem.General.TrkSysGeneralTypeIIFrequencyBand_A12491;
				if (trunkingSystem.General.TrkSysGeneralSystemType_A9252.Value == 2)
				{
					goto IL_9E;
				}
				return false;
			}
			IL_117:
			num = (short)91750400;
			if (num != 0)
			{
			}
			return trkSysGeneralTypeIIFrequencyBand_A.Value == 2;
		}

		// Token: 0x06000BEE RID: 3054 RVA: 0x000C0D0C File Offset: 0x000BEF0C
		internal static bool conCCTxFreqApplicabilityEditbl(global::AcpCommonLib.IAcpFeatureSection self)
		{
			short num = (short)439287808;
			int num2 = (int)num;
			switch (num2)
			{
			default:
			{
				switch (0)
				{
				case 0:
					goto IL_62;
				}
				global::Motorola.MackinawCPS.CoreFeatures.TrunkingSystem.ControlChannelsInnerSection controlChannelsInnerSection;
				global::AcpBusinessLayer.AcpListField trkSysGeneralSystemType_A;
				global::AcpBusinessLayer.AcpListField trkSysGeneralTypeIIFrequencyBand_A;
				global::Motorola.MackinawCPS.CoreFeatures.RadioWide.RxFrequencySplitFPPInnerRecset rxFrequencySplitFPPInnerRecset;
				global::System.Collections.Generic.IEnumerator<global::AcpBusinessLayer.FeatureNode> enumerator;
				int num4;
				for (;;)
				{
					IL_27:
					switch (num2)
					{
					case 0:
						if (!controlChannelsInnerSection.RefRadioInformation.Labtool.RadInfoLabtoolH38G51Smartzone_A8185.Value)
						{
							num = (short)1730871308;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_76D;
					case 1:
						if (trkSysGeneralSystemType_A.Value == 2)
						{
							num = (short)2103050246;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)236060675;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 2:
						return false;
					case 3:
						num = (short)918159361;
						if (num != 0)
						{
						}
						if (trkSysGeneralSystemType_A.Value == 3)
						{
							num = (short)94502922;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return true;
					case 4:
						if (trkSysGeneralTypeIIFrequencyBand_A.Value != 3)
						{
							num = (short)1856045063;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return false;
					case 5:
						if (!controlChannelsInnerSection.RefRadioInformation.Labtool.RadInfoLabtoolH37G50Smartnet_A8184.Value)
						{
							num = (short)324272130;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_76D;
					case 6:
						num = (short)107216900;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 7:
						num = (short)653983755;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 8:
						goto IL_768;
					case 9:
						goto IL_12D;
					case 10:
						enumerator = rxFrequencySplitFPPInnerRecset.GetEnumerator();
						num = (short)1963393033;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 11:
						if (trkSysGeneralTypeIIFrequencyBand_A.Value == 4)
						{
							num = (short)1302986760;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return true;
					case 12:
						num = (short)1610547205;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_62;
					IL_76D:
					num = (short)127205376;
					short num3 = num;
					num4 = controlChannelsInnerSection.TrkSysControlChannelsRxFrequencyMHz_A9018.Value * 5;
					num = (short)1456996353;
					num2 = (int)((global::System.IntPtr)num);
				}
				IL_12D:
				try
				{
					num = (short)779026437;
					num2 = (int)((global::System.IntPtr)num);
					bool result;
					for (;;)
					{
						switch (num2)
						{
						case 0:
						{
							global::AcpCommonLib.IAcpFeatureNode acpFeatureNode;
							if (num4 < (acpFeatureNode[10097] as global::Motorola.MackinawCPS.CoreFeatures.RadioWide.RxFrequencySplitFPPInnerSection).RadWideLabtoolRxEndFrequencySplit_A9015.Value * 5)
							{
								num = (short)1019346967;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							goto IL_388;
						}
						case 1:
							num = (short)223412241;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 2:
							goto IL_4F2;
						case 3:
						{
							global::AcpCommonLib.IAcpFeatureNode acpFeatureNode;
							if (num4 >= (acpFeatureNode[10097] as global::Motorola.MackinawCPS.CoreFeatures.RadioWide.RxFrequencySplitFPPInnerSection).RadWideLabtoolRxStartFrequencySplit_A9032.Value * 5)
							{
								num = (short)789315610;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							goto IL_5F5;
						}
						case 4:
							goto IL_330;
						case 5:
							switch (0)
							{
							case 0:
								goto IL_213;
							}
							continue;
						case 6:
						{
							global::AcpCommonLib.IAcpFeatureNode acpFeatureNode;
							if ((acpFeatureNode[10097] as global::Motorola.MackinawCPS.CoreFeatures.RadioWide.RxFrequencySplitFPPInnerSection).RadWideLabtoolRxBandSplitName_A24797.Value == global::CommonResources.AcgResources.ID_P_900M)
							{
								num = (short)1025966096;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							break;
						}
						case 7:
						{
							global::AcpCommonLib.IAcpFeatureNode acpFeatureNode;
							if (num4 > (acpFeatureNode[10097] as global::Motorola.MackinawCPS.CoreFeatures.RadioWide.RxFrequencySplitFPPInnerSection).RadWideLabtoolRxStartFrequencySplit_A9032.Value * 5)
							{
								num = (short)1283194895;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							goto IL_388;
						}
						case 8:
							goto IL_570;
						case 9:
						{
							global::AcpCommonLib.IAcpFeatureNode acpFeatureNode;
							if ((acpFeatureNode[10097] as global::Motorola.MackinawCPS.CoreFeatures.RadioWide.RxFrequencySplitFPPInnerSection).RadWideLabtoolRxBandSplitName_A24797.Value == global::CommonResources.AcgResources.ID_P_700M_1)
							{
								num = (short)112918532;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							goto IL_388;
						}
						case 10:
						{
							global::AcpCommonLib.IAcpFeatureNode acpFeatureNode;
							if ((acpFeatureNode[10097] as global::Motorola.MackinawCPS.CoreFeatures.RadioWide.RxFrequencySplitFPPInnerSection).RadWideLabtoolRxBandSplitName_A24797.Value == global::CommonResources.AcgResources.ID_P_800M)
							{
								num = (short)1846870035;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							goto IL_5F5;
						}
						case 11:
							result = false;
							num = (short)535625752;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 12:
							num = (short)2049769481;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 13:
						{
							global::AcpCommonLib.IAcpFeatureNode acpFeatureNode;
							if (!((acpFeatureNode[10097] as global::Motorola.MackinawCPS.CoreFeatures.RadioWide.RxFrequencySplitFPPInnerSection).RadWideLabtoolRxBandSplitName_A24797.Value == global::CommonResources.AcgResources.ID_P_700M))
							{
								num = (short)263454732;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							goto IL_330;
						}
						case 14:
						{
							global::AcpCommonLib.IAcpFeatureNode acpFeatureNode;
							if (num4 < (acpFeatureNode[10097] as global::Motorola.MackinawCPS.CoreFeatures.RadioWide.RxFrequencySplitFPPInnerSection).RadWideLabtoolRxEndFrequencySplit_A9015.Value * 5)
							{
								num = (short)1950023702;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							goto IL_5F5;
						}
						case 15:
							num = (short)437518336;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 16:
							num = (short)1528234004;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 17:
						{
							global::AcpCommonLib.IAcpFeatureNode acpFeatureNode;
							if (num4 < (acpFeatureNode[10097] as global::Motorola.MackinawCPS.CoreFeatures.RadioWide.RxFrequencySplitFPPInnerSection).RadWideLabtoolRxEndFrequencySplit_A9015.Value * 5)
							{
								num = (short)1400635403;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							break;
						}
						case 18:
						{
							if (!enumerator.MoveNext())
							{
								num = (short)401932313;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							global::AcpCommonLib.IAcpFeatureNode acpFeatureNode = enumerator.Current;
							num = (short)1241710605;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						case 19:
							num = (short)2142044163;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 20:
						{
							global::AcpCommonLib.IAcpFeatureNode acpFeatureNode;
							if (num4 > (acpFeatureNode[10097] as global::Motorola.MackinawCPS.CoreFeatures.RadioWide.RxFrequencySplitFPPInnerSection).RadWideLabtoolRxStartFrequencySplit_A9032.Value * 5)
							{
								num = (short)1293418497;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							break;
						}
						case 21:
						{
							num = (short)1763664928;
							short num5 = num;
							num = (short)1342989344;
							switch ((num5 == num) ? 1 : 0)
							{
							case 0:
							case 2:
								goto IL_553;
							default:
								goto IL_6A2;
							}
							break;
						}
						case 22:
							result = false;
							num = (short)1772945410;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 23:
							goto IL_553;
						case 24:
							goto IL_5F0;
						case 25:
							num = (short)397082645;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 26:
							num = (short)1698430990;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_213;
						IL_330:
						num = (short)1006501895;
						num2 = (int)((global::System.IntPtr)num);
						continue;
						IL_388:
						num = (short)285605898;
						num2 = (int)((global::System.IntPtr)num);
						continue;
						IL_3E9:
						num = (short)448725010;
						num2 = (int)((global::System.IntPtr)num);
						continue;
						IL_213:
						goto IL_3E9;
						IL_553:
						result = false;
						num = (short)107937800;
						num2 = (int)((global::System.IntPtr)num);
						continue;
						IL_5F5:
						num = (short)248643590;
						num2 = (int)((global::System.IntPtr)num);
					}
					IL_4F2:
					IL_570:
					IL_5F0:
					return result;
					IL_6A2:
					num = (short)238878720;
					if (num != 0)
					{
					}
				}
				finally
				{
					num = (short)1438973954;
					num2 = (int)((global::System.IntPtr)num);
					for (;;)
					{
						switch (num2)
						{
						case 0:
							enumerator.Dispose();
							num = (short)709689345;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 1:
							goto IL_725;
						case 2:
							switch (0)
							{
							case 0:
								goto IL_6EC;
							}
							continue;
						}
						IL_6EC:
						if (enumerator == null)
						{
							break;
						}
						num = (short)1658454016;
						num2 = (int)((global::System.IntPtr)num);
					}
					IL_725:;
				}
				return true;
				IL_768:
				return false;
				IL_62:
				controlChannelsInnerSection = (self as global::Motorola.MackinawCPS.CoreFeatures.TrunkingSystem.ControlChannelsInnerSection);
				global::Motorola.MackinawCPS.CoreFeatures.TrunkingSystem.TrunkingSystem trunkingSystem = self.ParentRecset.ParentSection.Parent as global::Motorola.MackinawCPS.CoreFeatures.TrunkingSystem.TrunkingSystem;
				trkSysGeneralSystemType_A = trunkingSystem.General.TrkSysGeneralSystemType_A9252;
				trkSysGeneralTypeIIFrequencyBand_A = trunkingSystem.General.TrkSysGeneralTypeIIFrequencyBand_A12491;
				rxFrequencySplitFPPInnerRecset = ((global::AcpCommonLib.FeatureManager.GetFeature(2045) as global::Motorola.MackinawCPS.CoreFeatures.RadioWide.RadioWideRecset)[0][10096].EmbeddedRecset as global::Motorola.MackinawCPS.CoreFeatures.RadioWide.RxFrequencySplitFPPInnerRecset);
				num = (short)1307836416;
				num2 = (int)((global::System.IntPtr)num);
				goto IL_27;
			}
			}
		}

		// Token: 0x06000BEF RID: 3055 RVA: 0x000C15C8 File Offset: 0x000BF7C8
		internal static bool ConChannelBandwidthValid(global::AcpCommonLib.IAcpFeatureSection self, int index)
		{
			short num = (short)1144324096;
			int num2 = (int)num;
			switch (num2)
			{
			default:
			{
				num = (short)495714304;
				short num3 = num;
				switch (0)
				{
				case 0:
					goto IL_AF;
				}
				global::Motorola.MackinawCPS.CoreFeatures.TrunkingSystem.TypeIIChannelSetup typeIIChannelSetup;
				global::Motorola.MackinawCPS.CoreFeatures.RadioWide.FCCNarrowBandingFrequencySplitInnerRecset fccnarrowBandingFrequencySplitInnerRecset;
				global::AcpBusinessLayer.AcpListField trkSysGeneralTypeIIFrequencyBand_A;
				bool flag2;
				global::Motorola.MackinawCPS.CoreFeatures.TrunkingSystem.TrunkingSystem trunkingSystem;
				global::Motorola.MackinawCPS.CoreFeatures.TrunkingSystem.ChannelRangesMHzInnerRecset channelRangesMHzInnerRecset;
				for (;;)
				{
					IL_50:
					bool flag;
					switch (num2)
					{
					case 0:
						if (global::ConstraintHelper.UtilityMack.IsFreonRadio)
						{
							num = (short)1008992260;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_782;
					case 1:
						flag = typeIIChannelSetup.RefRadioInformation.Labtool.RadInfoLabtoolDualBandEnable_A23986.Value;
						goto IL_947;
					case 2:
						if (typeIIChannelSetup.RefRadioInformation.Labtool.RadInfoLabtoolQ507G507FCCMANDATE_A38198.Value)
						{
							num = (short)333774865;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return true;
					case 3:
						try
						{
							num = (short)428081160;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								int num4;
								int num5;
								global::System.Collections.Generic.IEnumerator<global::AcpBusinessLayer.FeatureNode> enumerator2;
								bool value;
								switch (num2)
								{
								case 0:
								{
									global::System.Collections.Generic.IEnumerator<global::AcpBusinessLayer.FeatureNode> enumerator = fccnarrowBandingFrequencySplitInnerRecset.GetEnumerator();
									num = (short)682164225;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 1:
									try
									{
										num = (short)1736638467;
										num2 = (int)((global::System.IntPtr)num);
										bool result;
										for (;;)
										{
											switch (num2)
											{
											case 0:
												if (trkSysGeneralTypeIIFrequencyBand_A.Value == 2)
												{
													num = (short)697958415;
													num2 = (int)((global::System.IntPtr)num);
													continue;
												}
												goto IL_3C7;
											case 1:
												if (flag2)
												{
													num = (short)1866399753;
													num2 = (int)((global::System.IntPtr)num);
													continue;
												}
												goto IL_3C7;
											case 2:
												goto IL_3C7;
											case 3:
												switch (0)
												{
												case 0:
													goto IL_36E;
												}
												continue;
											case 4:
												num = (short)1733623809;
												num2 = (int)((global::System.IntPtr)num);
												continue;
											case 5:
												num = (short)998375432;
												num2 = (int)((global::System.IntPtr)num);
												continue;
											case 6:
												num = (short)1136590859;
												num2 = (int)((global::System.IntPtr)num);
												continue;
											case 7:
											{
												global::AcpCommonLib.IAcpFeatureNode acpFeatureNode;
												if (num4 <= (acpFeatureNode[10635] as global::Motorola.MackinawCPS.CoreFeatures.RadioWide.FCCNarrowBandingFrequencySplitInnerSection).RadWideLabtoolFCCNarrowBandEndFrequency_A38271.Value * 5)
												{
													num = (short)2012545036;
													num2 = (int)((global::System.IntPtr)num);
													continue;
												}
												break;
											}
											case 8:
												if (num5 < 470000000)
												{
													num = (short)1128202242;
													num2 = (int)((global::System.IntPtr)num);
													continue;
												}
												break;
											case 9:
												num = (short)1458438144;
												num2 = (int)((global::System.IntPtr)num);
												continue;
											case 10:
												if (num4 >= 470000000)
												{
													num = (short)189530117;
													num2 = (int)((global::System.IntPtr)num);
													continue;
												}
												goto IL_3C7;
											case 11:
												goto IL_59B;
											case 12:
												num = (short)1095106576;
												num2 = (int)((global::System.IntPtr)num);
												continue;
											case 13:
												goto IL_3E2;
											case 14:
											{
												global::System.Collections.Generic.IEnumerator<global::AcpBusinessLayer.FeatureNode> enumerator;
												if (!enumerator.MoveNext())
												{
													num = (short)669646854;
													num2 = (int)((global::System.IntPtr)num);
													continue;
												}
												global::AcpCommonLib.IAcpFeatureNode acpFeatureNode = enumerator.Current;
												num = (short)1393229831;
												num2 = (int)((global::System.IntPtr)num);
												continue;
											}
											case 15:
												num = (short)322109450;
												num2 = (int)((global::System.IntPtr)num);
												continue;
											case 16:
											{
												global::AcpCommonLib.IAcpFeatureNode acpFeatureNode;
												if (num5 >= (acpFeatureNode[10635] as global::Motorola.MackinawCPS.CoreFeatures.RadioWide.FCCNarrowBandingFrequencySplitInnerSection).RadWideLabtoolFCCNarrowBandStartFrequency_A38270.Value * 5)
												{
													num = (short)1605763076;
													num2 = (int)((global::System.IntPtr)num);
													continue;
												}
												break;
											}
											}
											goto IL_36E;
											IL_3C7:
											result = false;
											num = (short)244580365;
											num2 = (int)((global::System.IntPtr)num);
											continue;
											IL_542:
											num = (short)1016987662;
											num2 = (int)((global::System.IntPtr)num);
											continue;
											IL_36E:
											goto IL_542;
										}
										IL_3E2:
										return result;
										IL_59B:
										break;
									}
									finally
									{
										num = (short)1707081730;
										num2 = (int)((global::System.IntPtr)num);
										for (;;)
										{
											global::System.Collections.Generic.IEnumerator<global::AcpBusinessLayer.FeatureNode> enumerator;
											switch (num2)
											{
											case 0:
												enumerator.Dispose();
												num = (short)434110465;
												num2 = (int)((global::System.IntPtr)num);
												continue;
											case 1:
												goto IL_60C;
											case 2:
												switch (0)
												{
												case 0:
													goto IL_5D3;
												}
												continue;
											}
											IL_5D3:
											if (enumerator == null)
											{
												break;
											}
											num = (short)388628480;
											num2 = (int)((global::System.IntPtr)num);
										}
										IL_60C:;
									}
									goto IL_60F;
								case 2:
									num = (short)1635647491;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 3:
									goto IL_6C2;
								case 4:
									num = (short)218497031;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 5:
									if (!enumerator2.MoveNext())
									{
										num = (short)577503234;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									goto IL_60F;
								case 6:
									if (value)
									{
										num = (short)798294020;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									break;
								case 7:
									if (!global::ConstraintHelper.UtilityMack.FreqRanageIsWithInFCCExceptionRangeList(num4, num5))
									{
										num = (short)356253696;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									break;
								case 8:
									switch (0)
									{
									case 0:
										goto IL_263;
									}
									continue;
								}
								IL_268:
								num = (short)669253637;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								IL_263:
								goto IL_268;
								IL_60F:
								global::AcpBusinessLayer.FeatureNode featureNode = enumerator2.Current;
								value = (((global::AcpCommonLib.IAcpFeatureNode)featureNode)[10168] as global::Motorola.MackinawCPS.CoreFeatures.TrunkingSystem.ChannelRangesMHzInnerSection).TrkSysOBTChannelAssignmentListTxEnable_A9517.Value;
								num4 = (((global::AcpCommonLib.IAcpFeatureNode)featureNode)[10168] as global::Motorola.MackinawCPS.CoreFeatures.TrunkingSystem.ChannelRangesMHzInnerSection).TrkSysOBTChannelAssignmentListTxStartFrequencyMHz_A9568.Value * 5;
								num5 = (((global::AcpCommonLib.IAcpFeatureNode)featureNode)[10168] as global::Motorola.MackinawCPS.CoreFeatures.TrunkingSystem.ChannelRangesMHzInnerSection).TrkSysOBTChannelAssignmentListTxEndFrequencyMHz_A9529.Value * 5;
								num = (short)1326186502;
								num2 = (int)((global::System.IntPtr)num);
							}
							IL_6C2:
							return true;
						}
						finally
						{
							num = (short)984350722;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								global::System.Collections.Generic.IEnumerator<global::AcpBusinessLayer.FeatureNode> enumerator2;
								switch (num2)
								{
								case 0:
									enumerator2.Dispose();
									num = (short)1963982849;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 1:
									goto IL_77F;
								case 2:
									switch (0)
									{
									case 0:
										goto IL_6FB;
									}
									continue;
								}
								IL_6FB:
								num = (short)2096609790;
								short num6 = num;
								num = (short)1316534782;
								switch ((num6 == num) ? 1 : 0)
								{
								case 0:
								case 2:
									break;
								default:
									num = (short)1105395712;
									if (num != 0)
									{
									}
									if (enumerator2 == null)
									{
										goto IL_781;
									}
									num = (short)301924352;
									num2 = (int)((global::System.IntPtr)num);
									break;
								}
							}
							IL_77F:
							IL_781:;
						}
						goto IL_782;
					case 4:
						flag2 = typeIIChannelSetup.RefRadioInformation.General.RadInfoGeneralPrimaryFrequencyBandUHF2_A42547.Value;
						num = (short)1254490117;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 5:
						goto IL_818;
					case 6:
						if (trunkingSystem.General.TrkSysGeneralSystemType_A9252.Value == 2)
						{
							num = (short)504037394;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return true;
					case 7:
					{
						global::System.Collections.Generic.IEnumerator<global::AcpBusinessLayer.FeatureNode> enumerator2 = channelRangesMHzInnerRecset.GetEnumerator();
						num = (short)102367235;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 8:
						flag = true;
						goto IL_947;
					case 9:
						if (index != 50)
						{
							num = (short)809566224;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return true;
					case 10:
						flag = false;
						goto IL_947;
					case 11:
						if (typeIIChannelSetup.RefRadioInformation.Labtool.RadInfoLabtoolSecondaryBands_A23988.Value == 8)
						{
							num = (short)2012610575;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)730529802;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 12:
						if (trkSysGeneralTypeIIFrequencyBand_A.Value != 3)
						{
							num = (short)453312532;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return true;
					case 13:
						num = (short)439222283;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 14:
						if (typeIIChannelSetup.RefRadioInformation.Labtool.RadInfoLabtoolPrimaryBands_A23987.Value != 8)
						{
							num = (short)590872589;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)1579155464;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 15:
						num = (short)1489371137;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 16:
						num = (short)403243020;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 17:
						num = (short)776208390;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 18:
						num = (short)891486209;
						if (num != 0)
						{
						}
						num = (short)2086993929;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 19:
						goto IL_818;
					case 20:
						num = (short)1946419221;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 21:
						if (trkSysGeneralTypeIIFrequencyBand_A.Value != 4)
						{
							num = (short)645267463;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return true;
					}
					goto IL_AF;
					IL_782:
					num = (short)531496974;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_818:
					num = (short)1545601026;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_947:
					flag2 = flag;
					num = (short)109051923;
					num2 = (int)((global::System.IntPtr)num);
				}
				return true;
				IL_AF:
				typeIIChannelSetup = (self as global::Motorola.MackinawCPS.CoreFeatures.TrunkingSystem.TypeIIChannelSetup);
				trunkingSystem = (self.Parent as global::Motorola.MackinawCPS.CoreFeatures.TrunkingSystem.TrunkingSystem);
				trkSysGeneralTypeIIFrequencyBand_A = trunkingSystem.General.TrkSysGeneralTypeIIFrequencyBand_A12491;
				channelRangesMHzInnerRecset = (self.Parent[10167].EmbeddedRecset as global::Motorola.MackinawCPS.CoreFeatures.TrunkingSystem.ChannelRangesMHzInnerRecset);
				fccnarrowBandingFrequencySplitInnerRecset = ((global::AcpCommonLib.FeatureManager.GetFeature(2045) as global::Motorola.MackinawCPS.CoreFeatures.RadioWide.RadioWideRecset)[0][10636].EmbeddedRecset as global::Motorola.MackinawCPS.CoreFeatures.RadioWide.FCCNarrowBandingFrequencySplitInnerRecset);
				flag2 = false;
				num = (short)1692991488;
				num2 = (int)((global::System.IntPtr)num);
				goto IL_50;
			}
			}
		}

		// Token: 0x06000BF0 RID: 3056 RVA: 0x000C1FD8 File Offset: 0x000C01D8
		public static void conSetNetworkIDSiteIDTxFrequencyBasedOnSystemType(global::AcpCommonLib.IAcpFeatureSection self, global::AcpCommonLib.UndoRedo.ContainerTask task)
		{
			short num = (short)1419182080;
			switch (num)
			{
			default:
			{
				num = (short)784662528;
				short num2 = num;
				num = (short)1066532865;
				if (num != 0)
				{
				}
				global::Motorola.MackinawCPS.CoreFeatures.TrunkingSystem.General general = self as global::Motorola.MackinawCPS.CoreFeatures.TrunkingSystem.General;
				global::Motorola.MackinawCPS.CoreFeatures.TrunkingSystem.TrunkingSystem trunkingSystem = self.Parent as global::Motorola.MackinawCPS.CoreFeatures.TrunkingSystem.TrunkingSystem;
				global::AcpBusinessLayer.AcpField<int> trkSysLabtoolNetworkID_A = general.TrkSysLabtoolNetworkID_A8565;
				int newValue;
				if (general.TrkSysGeneralSystemType_A9252.Value == 3)
				{
					newValue = 0;
					goto IL_FE6;
				}
				IL_FC2:
				newValue = ((general.TrkSysGeneralSystemID_A9239.Value & 255) << 4) + general.TrkSysGeneralConnectToneHz_A7710.Value;
				IL_FE6:
				task.AddTask(new global::AcpBusinessLayer.UndoRedo.ModifyDataTask<int>(trkSysLabtoolNetworkID_A, newValue));
				global::AcpBusinessLayer.AcpListField trkSysGeneralSystemType_A = general.TrkSysGeneralSystemType_A9252;
				global::AcpBusinessLayer.AcpListField trkSysGeneralTypeIIFrequencyBand_A = general.TrkSysGeneralTypeIIFrequencyBand_A12491;
				global::Motorola.MackinawCPS.CoreFeatures.RadioWide.RxFrequencySplitFPPInnerRecset rxFrequencySplitFPPInnerRecset = (global::AcpCommonLib.FeatureManager.GetFeature(2045) as global::Motorola.MackinawCPS.CoreFeatures.RadioWide.RadioWideRecset)[0][10096].EmbeddedRecset as global::Motorola.MackinawCPS.CoreFeatures.RadioWide.RxFrequencySplitFPPInnerRecset;
				global::System.Collections.Generic.IEnumerator<global::AcpBusinessLayer.FeatureNode> enumerator = (trunkingSystem.ControlChannels.EmbeddedRecset as global::Motorola.MackinawCPS.CoreFeatures.TrunkingSystem.ControlChannelsInnerRecset).GetEnumerator();
				try
				{
					num = (short)1139998728;
					int num3 = (int)((global::System.IntPtr)num);
					for (;;)
					{
						global::System.Collections.Generic.IEnumerator<global::AcpBusinessLayer.FeatureNode> enumerator2;
						switch (num3)
						{
						case 0:
							enumerator2 = rxFrequencySplitFPPInnerRecset.GetEnumerator();
							num = (short)1607598091;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						case 1:
							num = (short)300220425;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						case 2:
							try
							{
								num = (short)2090336261;
								num3 = (int)((global::System.IntPtr)num);
								for (;;)
								{
									switch (num3)
									{
									case 0:
										num = (short)631898116;
										num3 = (int)((global::System.IntPtr)num);
										continue;
									case 1:
									{
										int num4;
										global::AcpCommonLib.IAcpFeatureNode acpFeatureNode;
										if (num4 > (acpFeatureNode[10097] as global::Motorola.MackinawCPS.CoreFeatures.RadioWide.RxFrequencySplitFPPInnerSection).RadWideLabtoolRxStartFrequencySplit_A9032.Value * 5)
										{
											num = (short)2037317632;
											num3 = (int)((global::System.IntPtr)num);
											continue;
										}
										break;
									}
									case 2:
									{
										int num4;
										global::AcpBusinessLayer.AcpFrequencyField trkSysControlChannelsTxFrequencyMHz_A;
										task.AddTask(new global::AcpBusinessLayer.UndoRedo.ModifyDataTask<int>(trkSysControlChannelsTxFrequencyMHz_A, (num4 - 39000000) / 5));
										num = (short)465895432;
										num3 = (int)((global::System.IntPtr)num);
										continue;
									}
									case 3:
										num = (short)1361117185;
										num3 = (int)((global::System.IntPtr)num);
										continue;
									case 4:
									{
										int num4;
										global::AcpCommonLib.IAcpFeatureNode acpFeatureNode;
										if (num4 < (acpFeatureNode[10097] as global::Motorola.MackinawCPS.CoreFeatures.RadioWide.RxFrequencySplitFPPInnerSection).RadWideLabtoolRxEndFrequencySplit_A9015.Value * 5)
										{
											num = (short)1178337282;
											num3 = (int)((global::System.IntPtr)num);
											continue;
										}
										break;
									}
									case 5:
										switch (0)
										{
										case 0:
											goto IL_6A4;
										}
										continue;
									case 6:
										num = (short)1304428551;
										num3 = (int)((global::System.IntPtr)num);
										continue;
									case 7:
										goto IL_843;
									case 9:
									{
										global::AcpCommonLib.IAcpFeatureNode acpFeatureNode;
										if ((acpFeatureNode[10097] as global::Motorola.MackinawCPS.CoreFeatures.RadioWide.RxFrequencySplitFPPInnerSection).RadWideLabtoolRxBandSplitName_A24797.Value == global::CommonResources.AcgResources.ID_P_900M)
										{
											num = (short)1911029763;
											num3 = (int)((global::System.IntPtr)num);
											continue;
										}
										break;
									}
									case 10:
									{
										if (!enumerator2.MoveNext())
										{
											num = (short)716308486;
											num3 = (int)((global::System.IntPtr)num);
											continue;
										}
										global::AcpCommonLib.IAcpFeatureNode acpFeatureNode = enumerator2.Current;
										num = (short)1120600073;
										num3 = (int)((global::System.IntPtr)num);
										continue;
									}
									}
									IL_75E:
									num = (short)810352650;
									num3 = (int)((global::System.IntPtr)num);
									continue;
									IL_6A4:
									goto IL_75E;
								}
								IL_843:
								break;
							}
							finally
							{
								num = (short)1929773057;
								num3 = (int)((global::System.IntPtr)num);
								for (;;)
								{
									switch (num3)
									{
									case 0:
										goto IL_8B3;
									case 1:
										switch (0)
										{
										case 0:
											goto IL_87B;
										}
										continue;
									case 2:
										enumerator2.Dispose();
										num = (short)54067200;
										num3 = (int)((global::System.IntPtr)num);
										continue;
									}
									IL_87B:
									if (enumerator2 == null)
									{
										break;
									}
									num = (short)1578237954;
									num3 = (int)((global::System.IntPtr)num);
								}
								IL_8B3:;
							}
							goto IL_8B6;
						case 3:
							if (trkSysGeneralSystemType_A.Value == 2)
							{
								num = (short)79364097;
								num3 = (int)((global::System.IntPtr)num);
								continue;
							}
							num = (short)228327434;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						case 4:
							goto IL_605;
						case 5:
							if (trkSysGeneralTypeIIFrequencyBand_A.Value == 4)
							{
								num = (short)488112135;
								num3 = (int)((global::System.IntPtr)num);
								continue;
							}
							break;
						case 6:
							goto IL_F4D;
						case 7:
							goto IL_8B6;
						case 8:
							switch (0)
							{
							case 0:
								goto IL_100;
							}
							continue;
						case 9:
							if (trkSysGeneralTypeIIFrequencyBand_A.Value == 3)
							{
								num = (short)8781828;
								num3 = (int)((global::System.IntPtr)num);
								continue;
							}
							goto IL_140;
						case 10:
							if (trkSysGeneralSystemType_A.Value == 3)
							{
								num = (short)307167232;
								num3 = (int)((global::System.IntPtr)num);
								continue;
							}
							break;
						case 11:
							try
							{
								num = (short)1589379078;
								num3 = (int)((global::System.IntPtr)num);
								for (;;)
								{
									switch (num3)
									{
									case 0:
									{
										int num4;
										global::AcpCommonLib.IAcpFeatureNode acpFeatureNode2;
										if (num4 < (acpFeatureNode2[10097] as global::Motorola.MackinawCPS.CoreFeatures.RadioWide.RxFrequencySplitFPPInnerSection).RadWideLabtoolRxEndFrequencySplit_A9015.Value * 5)
										{
											num = (short)1282277383;
											num3 = (int)((global::System.IntPtr)num);
											continue;
										}
										goto IL_BB6;
									}
									case 1:
									{
										num = (short)1114840557;
										short num5 = num;
										num = (short)1515265517;
										switch ((num5 == num) ? 1 : 0)
										{
										case 0:
										case 2:
											goto IL_B99;
										default:
											num = (short)1590231040;
											if (num != 0)
											{
											}
											goto IL_ABE;
										}
										break;
									}
									case 2:
									{
										int num4;
										global::AcpCommonLib.IAcpFeatureNode acpFeatureNode2;
										if (num4 > (acpFeatureNode2[10097] as global::Motorola.MackinawCPS.CoreFeatures.RadioWide.RxFrequencySplitFPPInnerSection).RadWideLabtoolRxStartFrequencySplit_A9032.Value * 5)
										{
											num = (short)1045364746;
											num3 = (int)((global::System.IntPtr)num);
											continue;
										}
										goto IL_E4A;
									}
									case 3:
										num = (short)902365201;
										num3 = (int)((global::System.IntPtr)num);
										continue;
									case 4:
									{
										int num4;
										global::AcpBusinessLayer.AcpFrequencyField trkSysControlChannelsTxFrequencyMHz_A;
										task.AddTask(new global::AcpBusinessLayer.UndoRedo.ModifyDataTask<int>(trkSysControlChannelsTxFrequencyMHz_A, (num4 - 39000000) / 5));
										goto IL_B99;
									}
									case 5:
									{
										global::AcpCommonLib.IAcpFeatureNode acpFeatureNode2;
										if ((acpFeatureNode2[10097] as global::Motorola.MackinawCPS.CoreFeatures.RadioWide.RxFrequencySplitFPPInnerSection).RadWideLabtoolRxBandSplitName_A24797.Value == global::CommonResources.AcgResources.ID_P_900M)
										{
											num = (short)331677715;
											num3 = (int)((global::System.IntPtr)num);
											continue;
										}
										break;
									}
									case 6:
										switch (0)
										{
										case 0:
											goto IL_9F4;
										}
										continue;
									case 7:
									{
										int num4;
										global::AcpBusinessLayer.AcpFrequencyField trkSysControlChannelsTxFrequencyMHz_A;
										task.AddTask(new global::AcpBusinessLayer.UndoRedo.ModifyDataTask<int>(trkSysControlChannelsTxFrequencyMHz_A, (num4 - 45000000) / 5));
										num = (short)1448149004;
										num3 = (int)((global::System.IntPtr)num);
										continue;
									}
									case 8:
									{
										global::AcpCommonLib.IAcpFeatureNode acpFeatureNode2;
										if ((acpFeatureNode2[10097] as global::Motorola.MackinawCPS.CoreFeatures.RadioWide.RxFrequencySplitFPPInnerSection).RadWideLabtoolRxBandSplitName_A24797.Value == global::CommonResources.AcgResources.ID_P_800M)
										{
											num = (short)452853763;
											num3 = (int)((global::System.IntPtr)num);
											continue;
										}
										goto IL_BB6;
									}
									case 9:
									{
										int num4;
										global::AcpCommonLib.IAcpFeatureNode acpFeatureNode2;
										if (num4 < (acpFeatureNode2[10097] as global::Motorola.MackinawCPS.CoreFeatures.RadioWide.RxFrequencySplitFPPInnerSection).RadWideLabtoolRxEndFrequencySplit_A9015.Value * 5)
										{
											num = (short)994312214;
											num3 = (int)((global::System.IntPtr)num);
											continue;
										}
										goto IL_E4A;
									}
									case 10:
										num = (short)1247936521;
										num3 = (int)((global::System.IntPtr)num);
										continue;
									case 11:
										goto IL_EC2;
									case 13:
									{
										if (!enumerator2.MoveNext())
										{
											num = (short)316932111;
											num3 = (int)((global::System.IntPtr)num);
											continue;
										}
										global::AcpCommonLib.IAcpFeatureNode acpFeatureNode2 = enumerator2.Current;
										string value = (acpFeatureNode2[10097] as global::Motorola.MackinawCPS.CoreFeatures.RadioWide.RxFrequencySplitFPPInnerSection).RadWideLabtoolRxBandSplitName_A24797.Value;
										num = (short)190644248;
										num3 = (int)((global::System.IntPtr)num);
										continue;
									}
									case 15:
										num = (short)470614027;
										num3 = (int)((global::System.IntPtr)num);
										continue;
									case 17:
									{
										int num4;
										global::AcpCommonLib.IAcpFeatureNode acpFeatureNode2;
										if (num4 >= (acpFeatureNode2[10097] as global::Motorola.MackinawCPS.CoreFeatures.RadioWide.RxFrequencySplitFPPInnerSection).RadWideLabtoolRxStartFrequencySplit_A9032.Value * 5)
										{
											num = (short)162856978;
											num3 = (int)((global::System.IntPtr)num);
											continue;
										}
										goto IL_BB6;
									}
									case 18:
										num = (short)1299841024;
										num3 = (int)((global::System.IntPtr)num);
										continue;
									case 19:
										num = (short)1593376788;
										num3 = (int)((global::System.IntPtr)num);
										continue;
									case 20:
									{
										int num4;
										global::AcpCommonLib.IAcpFeatureNode acpFeatureNode2;
										if (num4 > (acpFeatureNode2[10097] as global::Motorola.MackinawCPS.CoreFeatures.RadioWide.RxFrequencySplitFPPInnerSection).RadWideLabtoolRxStartFrequencySplit_A9032.Value * 5)
										{
											num = (short)695533589;
											num3 = (int)((global::System.IntPtr)num);
											continue;
										}
										break;
									}
									case 21:
										num = (short)2015232026;
										num3 = (int)((global::System.IntPtr)num);
										continue;
									case 22:
									{
										int num4;
										global::AcpBusinessLayer.AcpFrequencyField trkSysControlChannelsTxFrequencyMHz_A;
										task.AddTask(new global::AcpBusinessLayer.UndoRedo.ModifyDataTask<int>(trkSysControlChannelsTxFrequencyMHz_A, (num4 + 30000000) / 5));
										num = (short)1446838286;
										num3 = (int)((global::System.IntPtr)num);
										continue;
									}
									case 23:
									{
										string value;
										if (value == global::CommonResources.AcgResources.ID_P_700M_1)
										{
											num = (short)1290731521;
											num3 = (int)((global::System.IntPtr)num);
											continue;
										}
										goto IL_E4A;
									}
									case 24:
									{
										string value;
										if (!(value == global::CommonResources.AcgResources.ID_P_700M))
										{
											num = (short)1167130649;
											num3 = (int)((global::System.IntPtr)num);
											continue;
										}
										goto IL_ABE;
									}
									case 25:
										num = (short)252117015;
										num3 = (int)((global::System.IntPtr)num);
										continue;
									case 26:
									{
										int num4;
										global::AcpCommonLib.IAcpFeatureNode acpFeatureNode2;
										if (num4 < (acpFeatureNode2[10097] as global::Motorola.MackinawCPS.CoreFeatures.RadioWide.RxFrequencySplitFPPInnerSection).RadWideLabtoolRxEndFrequencySplit_A9015.Value * 5)
										{
											num = (short)861143044;
											num3 = (int)((global::System.IntPtr)num);
											continue;
										}
										break;
									}
									}
									goto IL_9F4;
									IL_ABE:
									num = (short)1928658946;
									num3 = (int)((global::System.IntPtr)num);
									continue;
									IL_B99:
									num = (short)1061879824;
									num3 = (int)((global::System.IntPtr)num);
									continue;
									IL_BB6:
									num = (short)1283391493;
									num3 = (int)((global::System.IntPtr)num);
									continue;
									IL_C6D:
									num = (short)821755917;
									num3 = (int)((global::System.IntPtr)num);
									continue;
									IL_9F4:
									goto IL_C6D;
									IL_E4A:
									num = (short)1527382024;
									num3 = (int)((global::System.IntPtr)num);
								}
								IL_EC2:
								break;
							}
							finally
							{
								num = (short)1099038720;
								num3 = (int)((global::System.IntPtr)num);
								for (;;)
								{
									switch (num3)
									{
									case 0:
										switch (0)
										{
										case 0:
											goto IL_EFA;
										}
										continue;
									case 1:
										enumerator2.Dispose();
										num = (short)23199746;
										num3 = (int)((global::System.IntPtr)num);
										continue;
									case 2:
										goto IL_F32;
									}
									IL_EFA:
									if (enumerator2 == null)
									{
										break;
									}
									num = (short)1578958849;
									num3 = (int)((global::System.IntPtr)num);
								}
								IL_F32:;
							}
							goto IL_F35;
						case 12:
						{
							if (!enumerator.MoveNext())
							{
								num = (short)68026381;
								num3 = (int)((global::System.IntPtr)num);
								continue;
							}
							global::Motorola.MackinawCPS.CoreFeatures.TrunkingSystem.ControlChannelsInnerSection controlChannelsInnerSection = (enumerator.Current as global::Motorola.MackinawCPS.CoreFeatures.TrunkingSystem.ControlChannelsInner).ControlChannelsInnerSection;
							global::AcpBusinessLayer.AcpFrequencyField trkSysControlChannelsTxFrequencyMHz_A = controlChannelsInnerSection.TrkSysControlChannelsTxFrequencyMHz_A9535;
							int num4 = controlChannelsInnerSection.TrkSysControlChannelsRxFrequencyMHz_A9018.Value * 5;
							num = (short)1322647555;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						}
						case 13:
							goto IL_F35;
						case 14:
							try
							{
								num = (short)714145794;
								num3 = (int)((global::System.IntPtr)num);
								for (;;)
								{
									switch (num3)
									{
									case 0:
									{
										global::AcpCommonLib.IAcpFeatureNode acpFeatureNode3;
										if ((acpFeatureNode3[10097] as global::Motorola.MackinawCPS.CoreFeatures.RadioWide.RxFrequencySplitFPPInnerSection).RadWideLabtoolRxBandSplitName_A24797.Value == global::CommonResources.AcgResources.ID_P_800M)
										{
											num = (short)1089994767;
											num3 = (int)((global::System.IntPtr)num);
											continue;
										}
										break;
									}
									case 1:
										num = (short)84475913;
										num3 = (int)((global::System.IntPtr)num);
										continue;
									case 2:
										switch (0)
										{
										case 0:
											goto IL_262;
										}
										continue;
									case 4:
										goto IL_591;
									case 6:
										num = (short)1313079300;
										num3 = (int)((global::System.IntPtr)num);
										continue;
									case 7:
									{
										int num4;
										global::AcpBusinessLayer.AcpFrequencyField trkSysControlChannelsTxFrequencyMHz_A;
										task.AddTask(new global::AcpBusinessLayer.UndoRedo.ModifyDataTask<int>(trkSysControlChannelsTxFrequencyMHz_A, (num4 + 30000000) / 5));
										num = (short)118095875;
										num3 = (int)((global::System.IntPtr)num);
										continue;
									}
									case 8:
										num = (short)1886846992;
										num3 = (int)((global::System.IntPtr)num);
										continue;
									case 9:
									{
										string value2;
										if (value2 == global::CommonResources.AcgResources.ID_P_700M_1)
										{
											num = (short)1821507594;
											num3 = (int)((global::System.IntPtr)num);
											continue;
										}
										goto IL_475;
									}
									case 10:
										goto IL_267;
									case 11:
									{
										int num4;
										global::AcpBusinessLayer.AcpFrequencyField trkSysControlChannelsTxFrequencyMHz_A;
										task.AddTask(new global::AcpBusinessLayer.UndoRedo.ModifyDataTask<int>(trkSysControlChannelsTxFrequencyMHz_A, (num4 - 45000000) / 5));
										num = (short)133955589;
										num3 = (int)((global::System.IntPtr)num);
										continue;
									}
									case 12:
									{
										int num4;
										global::AcpCommonLib.IAcpFeatureNode acpFeatureNode3;
										if (num4 >= (acpFeatureNode3[10097] as global::Motorola.MackinawCPS.CoreFeatures.RadioWide.RxFrequencySplitFPPInnerSection).RadWideLabtoolRxStartFrequencySplit_A9032.Value * 5)
										{
											num = (short)615907336;
											num3 = (int)((global::System.IntPtr)num);
											continue;
										}
										break;
									}
									case 13:
									{
										if (!enumerator2.MoveNext())
										{
											num = (short)824115206;
											num3 = (int)((global::System.IntPtr)num);
											continue;
										}
										global::AcpCommonLib.IAcpFeatureNode acpFeatureNode3 = enumerator2.Current;
										string value2 = (acpFeatureNode3[10097] as global::Motorola.MackinawCPS.CoreFeatures.RadioWide.RxFrequencySplitFPPInnerSection).RadWideLabtoolRxBandSplitName_A24797.Value;
										num = (short)1348141075;
										num3 = (int)((global::System.IntPtr)num);
										continue;
									}
									case 14:
									{
										int num4;
										global::AcpCommonLib.IAcpFeatureNode acpFeatureNode3;
										if (num4 > (acpFeatureNode3[10097] as global::Motorola.MackinawCPS.CoreFeatures.RadioWide.RxFrequencySplitFPPInnerSection).RadWideLabtoolRxStartFrequencySplit_A9032.Value * 5)
										{
											num = (short)203554833;
											num3 = (int)((global::System.IntPtr)num);
											continue;
										}
										goto IL_475;
									}
									case 15:
										num = (short)453967884;
										num3 = (int)((global::System.IntPtr)num);
										continue;
									case 16:
									{
										int num4;
										global::AcpCommonLib.IAcpFeatureNode acpFeatureNode3;
										if (num4 < (acpFeatureNode3[10097] as global::Motorola.MackinawCPS.CoreFeatures.RadioWide.RxFrequencySplitFPPInnerSection).RadWideLabtoolRxEndFrequencySplit_A9015.Value * 5)
										{
											num = (short)1317994507;
											num3 = (int)((global::System.IntPtr)num);
											continue;
										}
										break;
									}
									case 17:
										num = (short)1612709906;
										num3 = (int)((global::System.IntPtr)num);
										continue;
									case 18:
									{
										int num4;
										global::AcpCommonLib.IAcpFeatureNode acpFeatureNode3;
										if (num4 < (acpFeatureNode3[10097] as global::Motorola.MackinawCPS.CoreFeatures.RadioWide.RxFrequencySplitFPPInnerSection).RadWideLabtoolRxEndFrequencySplit_A9015.Value * 5)
										{
											num = (short)1404502023;
											num3 = (int)((global::System.IntPtr)num);
											continue;
										}
										goto IL_475;
									}
									case 19:
									{
										string value2;
										if (!(value2 == global::CommonResources.AcgResources.ID_P_700M))
										{
											num = (short)1177485313;
											num3 = (int)((global::System.IntPtr)num);
											continue;
										}
										goto IL_267;
									}
									}
									goto IL_262;
									IL_267:
									num = (short)1932525582;
									num3 = (int)((global::System.IntPtr)num);
									continue;
									IL_475:
									num = (short)1397555200;
									num3 = (int)((global::System.IntPtr)num);
									continue;
									IL_4D2:
									num = (short)1074462733;
									num3 = (int)((global::System.IntPtr)num);
									continue;
									IL_262:
									goto IL_4D2;
								}
								IL_591:
								goto IL_140;
							}
							finally
							{
								num = (short)570949633;
								num3 = (int)((global::System.IntPtr)num);
								for (;;)
								{
									switch (num3)
									{
									case 0:
										goto IL_602;
									case 1:
										switch (0)
										{
										case 0:
											goto IL_5CA;
										}
										continue;
									case 2:
										enumerator2.Dispose();
										num = (short)1457717248;
										num3 = (int)((global::System.IntPtr)num);
										continue;
									}
									IL_5CA:
									if (enumerator2 == null)
									{
										break;
									}
									num = (short)1019609090;
									num3 = (int)((global::System.IntPtr)num);
								}
								IL_602:;
							}
							goto IL_605;
						}
						IL_105:
						num = (short)1322713100;
						num3 = (int)((global::System.IntPtr)num);
						continue;
						IL_100:
						goto IL_105;
						IL_140:
						num = (short)1150156805;
						num3 = (int)((global::System.IntPtr)num);
						continue;
						IL_605:
						enumerator2 = rxFrequencySplitFPPInnerRecset.GetEnumerator();
						num = (short)1916403726;
						num3 = (int)((global::System.IntPtr)num);
						continue;
						IL_8B6:
						enumerator2 = rxFrequencySplitFPPInnerRecset.GetEnumerator();
						num = (short)691601410;
						num3 = (int)((global::System.IntPtr)num);
						continue;
						IL_F35:
						num = (short)1113128966;
						num3 = (int)((global::System.IntPtr)num);
					}
					IL_F4D:
					return;
				}
				finally
				{
					num = (short)1570897920;
					int num3 = (int)((global::System.IntPtr)num);
					for (;;)
					{
						switch (num3)
						{
						case 0:
							switch (0)
							{
							case 0:
								goto IL_F86;
							}
							continue;
						case 1:
							enumerator.Dispose();
							num = (short)1689845762;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						case 2:
							goto IL_FBF;
						}
						IL_F86:
						if (enumerator == null)
						{
							break;
						}
						num = (short)1579024385;
						num3 = (int)((global::System.IntPtr)num);
					}
					IL_FBF:;
				}
				goto IL_FC2;
			}
			}
		}

		// Token: 0x06000BF1 RID: 3057 RVA: 0x000C308C File Offset: 0x000C128C
		internal static bool conDataDisabledForTypeII(global::AcpCommonLib.IAcpFeatureSection self, int index)
		{
			short num = (short)1863712768;
			int num2 = (int)num;
			switch (num2)
			{
			default:
			{
				switch (0)
				{
				case 0:
					goto IL_138;
				}
				global::AcpCommonLib.DocumentType docType;
				bool flag3;
				bool flag4;
				for (;;)
				{
					IL_29:
					bool flag;
					bool flag2;
					int num4;
					global::AcpCommonLib.IAcpRecordset feature;
					switch (num2)
					{
					case 0:
					{
						global::Motorola.MackinawCPS.CoreFeatures.RadioWide.RadioWide radioWide;
						if (radioWide != null)
						{
							num = (short)184746044;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_CB2;
					}
					case 1:
						num = (short)261554200;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 2:
						flag = false;
						goto IL_AB1;
					case 3:
					{
						global::AcpBusinessLayer.AcpRecRefField trkSysGeneralDataProfileSelection_A;
						if (index > trkSysGeneralDataProfileSelection_A.RefRecset.Count)
						{
							num = (short)463601680;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						global::Motorola.MackinawCPS.CoreFeatures.DataProfiles.DataProfiles dataProfiles = trkSysGeneralDataProfileSelection_A.RefRecset[index - 1] as global::Motorola.MackinawCPS.CoreFeatures.DataProfiles.DataProfiles;
						num = (short)2111832114;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 4:
						return true;
					case 5:
					{
						global::AcpBusinessLayer.AcpRecRefField trkSysSecureMultikeyKMFProfileIndex_A;
						flag2 = (trkSysSecureMultikeyKMFProfileIndex_A.ReferencedNode != null);
						goto IL_A69;
					}
					case 6:
						num = (short)1466368013;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 7:
					{
						global::Motorola.MackinawCPS.CoreFeatures.RadioWide.RadioWide radioWide;
						if (!radioWide.DualRadio.RadWideDualRadioSecRadioTransmissionCapability_A42238.Value)
						{
							num = (short)1402273843;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_CB2;
					}
					case 8:
						return false;
					case 9:
						goto IL_B75;
					case 10:
						if (index >= 1)
						{
							num = (short)1188167732;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return false;
					case 11:
					{
						global::Motorola.MackinawCPS.CoreFeatures.RadioWide.RadioWideRecset radioWideRecset;
						if (radioWideRecset != null)
						{
							num = (short)1043202066;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_CB2;
					}
					case 12:
						goto IL_A64;
					case 13:
					{
						global::AcpBusinessLayer.AcpRecRefField trkSysSecureMultikeyKMFProfileIndex_A;
						int value;
						if (value == trkSysSecureMultikeyKMFProfileIndex_A.Value)
						{
							num = (short)250609717;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_3E3;
					}
					case 14:
					{
						int value;
						if (value == 0)
						{
							num = (short)1748172864;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_4FC;
					}
					case 15:
						goto IL_35B;
					case 16:
						goto IL_941;
					case 17:
						goto IL_317;
					case 18:
					{
						global::Motorola.MackinawCPS.CoreFeatures.RadioWide.RadioWideRecset radioWideRecset;
						global::Motorola.MackinawCPS.CoreFeatures.RadioWide.RadioWide radioWide = radioWideRecset[0] as global::Motorola.MackinawCPS.CoreFeatures.RadioWide.RadioWide;
						num = (short)297402368;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 19:
					{
						global::Motorola.MackinawCPS.CoreFeatures.DataProfiles.DataProfiles dataProfiles;
						if (dataProfiles.General.DataProfGeneralDataProfileType_A21320.Value != 4)
						{
							num = (short)1137770543;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_647;
					}
					case 20:
						num = (short)1908211745;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 21:
					{
						if (docType.Equals(global::AcpCommonLib.DocumentType.Comparator))
						{
							num = (short)474742788;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						global::Motorola.MackinawCPS.CoreFeatures.TrunkingSystem.TrunkingSystem trunkingSystem = self.Parent as global::Motorola.MackinawCPS.CoreFeatures.TrunkingSystem.TrunkingSystem;
						global::AcpBusinessLayer.AcpField<bool> trkSysSecureMultikeyASTROOTAR_A = trunkingSystem.SecureMultikey.TrkSysSecureMultikeyASTROOTAR_A7494;
						global::AcpBusinessLayer.AcpRecRefField trkSysSecureMultikeyKMFProfileIndex_A = trunkingSystem.SecureMultikey.TrkSysSecureMultikeyKMFProfileIndex_A8382;
						global::Motorola.MackinawCPS.CoreFeatures.RadioWide.RadioWideRecset radioWideRecset = global::AcpCommonLib.FeatureManager.GetFeature(2045) as global::Motorola.MackinawCPS.CoreFeatures.RadioWide.RadioWideRecset;
						flag3 = true;
						num = (short)1900085284;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 22:
						goto IL_5A4;
					case 23:
					{
						global::AcpBusinessLayer.AcpField<bool> trkSysSecureMultikeyASTROOTAR_A;
						if (trkSysSecureMultikeyASTROOTAR_A.Value)
						{
							num = (short)1153695750;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_3E3;
					}
					case 24:
					{
						global::Motorola.MackinawCPS.CoreFeatures.RadioWide.RadioWide radioWide;
						if (radioWide.DualRadio.RadWideDualRadioSelection_A42236.Value == 2)
						{
							num = (short)1684013087;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_CB2;
					}
					case 25:
					{
						global::Motorola.MackinawCPS.CoreFeatures.DataProfiles.DataProfiles dataProfiles;
						if (dataProfiles.General.DataProfGeneralDataProfileType_A21320.Value == 2)
						{
							num = (short)923140155;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_35B;
					}
					case 26:
					{
						global::Motorola.MackinawCPS.CoreFeatures.TrunkingSystem.General general;
						if (general.TrkSysGeneralSystemType_A9252.Value != 3)
						{
							goto IL_A4A;
						}
						num = (short)2081030202;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 27:
					{
						num = (short)1887043584;
						short num3 = num;
						goto IL_317;
					}
					case 28:
					{
						global::Motorola.MackinawCPS.CoreFeatures.TrunkingSystem.TrunkingSystem trunkingSystem;
						flag = !trunkingSystem.ASTRO25ChannelID.TrkSysLTEInterferingFreqPresent_A42198.Value;
						goto IL_AB1;
					}
					case 29:
					{
						global::AcpBusinessLayer.AcpField<bool> trkSysSecureMultikeyASTROOTAR_A;
						if (!trkSysSecureMultikeyASTROOTAR_A.Value)
						{
							num = (short)2009792554;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_4FC;
					}
					case 30:
						num = (short)1663238181;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 31:
						num = (short)1517813767;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 32:
					{
						global::Motorola.MackinawCPS.CoreFeatures.DataProfiles.DataProfiles dataProfiles2;
						if (dataProfiles2.NetworkLayerSecurity.DataProfNLSSecClrStrp_A36415.Value != 0)
						{
							num = (short)1993211948;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_799;
					}
					case 33:
					{
						global::Motorola.MackinawCPS.CoreFeatures.TrunkingSystem.TrunkingSystem trunkingSystem;
						if (trunkingSystem.General.TrkSysGeneralCoverageType_A7782.Value != 6)
						{
							num = (short)1428815921;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)979042306;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 34:
					{
						global::Motorola.MackinawCPS.CoreFeatures.DataProfiles.DataProfiles dataProfiles2;
						if (!(dataProfiles2.NetworkLayerSecurity.DataProfNLSKMFProfSele_A36419.UIValue != dataProfiles2.NetworkLayerSecurity.DataProfNLSKMFProfSele_A36419.InvalidText))
						{
							num = (short)29425719;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_799;
					}
					case 35:
						num = (short)816644122;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 36:
						if (index > 0)
						{
							num = (short)1097138239;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_B7A;
					case 37:
					{
						global::Motorola.MackinawCPS.CoreFeatures.DataProfiles.DataProfiles dataProfiles;
						if (dataProfiles.General.DataProfGeneralDataProfileType_A21320.Value == 1)
						{
							num = (short)1247150128;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)463536147;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 38:
						flag2 = true;
						goto IL_A69;
					case 39:
						if (index != 0)
						{
							num = (short)1685389347;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return true;
					case 40:
						goto IL_35B;
					case 41:
						num4++;
						num = (short)1129185307;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 42:
						num = (short)707788814;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 43:
						flag2 = false;
						goto IL_A69;
					case 44:
						num = (short)899743773;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 45:
					{
						global::Motorola.MackinawCPS.CoreFeatures.TrunkingSystem.General general = self as global::Motorola.MackinawCPS.CoreFeatures.TrunkingSystem.General;
						global::AcpBusinessLayer.AcpRecRefField trkSysGeneralDataProfileSelection_A = general.TrkSysGeneralDataProfileSelection_A19449;
						global::Motorola.MackinawCPS.CoreFeatures.DataProfiles.DataProfiles dataProfiles = null;
						flag4 = false;
						num = (short)1383006247;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 46:
						goto IL_35B;
					case 47:
						num = (short)1569980441;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 48:
						flag4 = true;
						num = (short)1036779560;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 49:
						num = (short)192479260;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 50:
					{
						num = (short)1042964184;
						short num5 = num;
						num = (short)1222205144;
						switch ((num5 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_A4A;
						default:
						{
							num = (short)207945728;
							if (num != 0)
							{
							}
							global::Motorola.MackinawCPS.CoreFeatures.DataProfiles.DataProfiles dataProfiles;
							if (dataProfiles != null)
							{
								num = (short)1161822238;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							goto IL_35B;
						}
						}
						break;
					}
					case 51:
						flag4 = false;
						num = (short)1404502025;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 52:
						num = (short)1248854019;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 53:
						num = (short)801898501;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 54:
					{
						int num6;
						if (num6 >= (feature[num4][10179] as global::Motorola.MackinawCPS.CoreFeatures.TrunkingPersonality.Talkgroup).EmbeddedRecset.Count)
						{
							num = (short)1191510057;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						((feature[num4][10179] as global::Motorola.MackinawCPS.CoreFeatures.TrunkingPersonality.Talkgroup).EmbeddedRecset[num6][10180] as global::Motorola.MackinawCPS.CoreFeatures.TrunkingPersonality.TalkgroupInnerSection).TrkPerTalkgroupKeySelect_A8365.CalculateApplicability();
						((feature[num4][10179] as global::Motorola.MackinawCPS.CoreFeatures.TrunkingPersonality.Talkgroup).EmbeddedRecset[num6][10180] as global::Motorola.MackinawCPS.CoreFeatures.TrunkingPersonality.TalkgroupInnerSection).TrkPerTalkgroupKeySelect_A8365.CalculateValidity();
						num6++;
						num = (short)510328889;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 55:
						goto IL_4FC;
					case 56:
					{
						global::Motorola.MackinawCPS.CoreFeatures.DataProfiles.DataProfiles dataProfiles;
						if (dataProfiles.LTE.DataProfBroadbandSource_A42858.Value == 1)
						{
							num = (short)466681876;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						flag4 = true;
						num = (short)1441792015;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 57:
						goto IL_5A4;
					case 58:
					{
						global::AcpBusinessLayer.AcpRecRefField trkSysGeneralDataProfileSelection_A;
						if (trkSysGeneralDataProfileSelection_A.RefRecset == null)
						{
							num = (short)241565704;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)869793802;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 59:
						goto IL_647;
					case 60:
						num = (short)1991835710;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 61:
					{
						if (num4 >= feature.Count)
						{
							num = (short)1966604333;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						(feature[num4][10178] as global::Motorola.MackinawCPS.CoreFeatures.TrunkingPersonality.General).TrkEmerProfGeneralKeySelect_A8970.CalculateApplicability();
						(feature[num4][10178] as global::Motorola.MackinawCPS.CoreFeatures.TrunkingPersonality.General).TrkEmerProfGeneralKeySelect_A8970.CalculateValidity();
						(feature[num4][10176] as global::Motorola.MackinawCPS.CoreFeatures.TrunkingPersonality.AnnouncementGroup).TrkPerAnnouncementGroupAGKeySelect_A7414.CalculateApplicability();
						(feature[num4][10176] as global::Motorola.MackinawCPS.CoreFeatures.TrunkingPersonality.AnnouncementGroup).TrkPerAnnouncementGroupAGKeySelect_A7414.CalculateValidity();
						int num6 = 0;
						num = (short)859176982;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 62:
						if (flag4)
						{
							num = (short)105185281;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_CB2;
					case 63:
					{
						global::Motorola.MackinawCPS.CoreFeatures.DataProfiles.DataProfiles dataProfiles2 = (global::AcpCommonLib.FeatureManager.GetFeature(2054) as global::Motorola.MackinawCPS.CoreFeatures.DataProfiles.DataProfilesRecset)[index - 1] as global::Motorola.MackinawCPS.CoreFeatures.DataProfiles.DataProfiles;
						int value = dataProfiles2.NetworkLayerSecurity.DataProfNLSKMFProfSele_A36419.Value;
						num = (short)1463025696;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 64:
						num = (short)1491337250;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 65:
						goto IL_B7A;
					}
					goto IL_138;
					IL_317:
					num = (short)2025783357;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_35B:
					num = (short)821493771;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_3E3:
					num = (short)622985259;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_4FC:
					num = (short)2110849047;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_5A4:
					num = (short)1618935862;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_647:
					num = (short)145096760;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_799:
					num = (short)310181926;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_A4A:
					num = (short)1168834572;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_A69:
					flag3 = flag2;
					num = (short)519766017;
					if (num != 0)
					{
					}
					num = (short)228327489;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_AB1:
					flag4 = flag;
					num = (short)988676142;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_B7A:
					feature = global::AcpCommonLib.FeatureManager.GetFeature(2072);
					num4 = 0;
					num = (short)1174536209;
					num2 = (int)((global::System.IntPtr)num);
				}
				return true;
				IL_941:
				return false;
				IL_A64:
				return true;
				IL_B75:
				IL_CB2:
				return flag4 && flag3;
				IL_138:
				docType = self.Parent.Parent.ContainerDoc.DocType;
				num = (short)1181548565;
				num2 = (int)((global::System.IntPtr)num);
				goto IL_29;
			}
			}
		}

		// Token: 0x06000BF2 RID: 3058 RVA: 0x000C3D50 File Offset: 0x000C1F50
		internal static bool ConTrkSysApcoAndCvgTypIsIntraWACNRoamingAndSiteAlsEn(global::AcpCommonLib.IAcpFeatureSection self)
		{
			switch (0)
			{
			case 0:
				goto IL_40;
			}
			int num;
			global::AcpBusinessLayer.AcpListField trkSysSiteAliasSiteAliasType_A;
			short num2;
			global::AcpBusinessLayer.AcpListField trkSysGeneralCoverageType_A;
			global::Motorola.MackinawCPS.CoreFeatures.TrunkingSystem.TrunkingSystem trunkingSystem;
			for (;;)
			{
				IL_0A:
				switch (num)
				{
				case 0:
					if (trkSysSiteAliasSiteAliasType_A.Value == 0)
					{
						num2 = (short)1750925319;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_259;
				case 1:
					num2 = (short)134348803;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 2:
					if (trkSysGeneralCoverageType_A.Value != 5)
					{
						num2 = (short)1934032901;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					return true;
				case 3:
					if (trkSysGeneralCoverageType_A.Value != 0)
					{
						num2 = (short)783286283;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					return false;
				case 4:
					if (trunkingSystem.SiteAlias.TrkSysSiteAliasSiteAliasEnable_A9148.Value)
					{
						num2 = (short)1244856326;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					return false;
				case 5:
					num2 = (short)2136539137;
					if (num2 != 0)
					{
					}
					num2 = (short)678690824;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 6:
				{
					num2 = (short)1254359040;
					short num3 = num2;
					num2 = (short)1053883974;
					short num4 = num2;
					num2 = (short)937623110;
					switch ((num4 == num2) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_229;
					default:
						num2 = (short)1161560064;
						if (num2 != 0)
						{
						}
						num2 = (short)87162889;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					break;
				}
				case 7:
					num2 = (short)1165754370;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 8:
					if (trkSysGeneralCoverageType_A.Value != 6)
					{
						num2 = (short)180027402;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					return true;
				case 9:
					goto IL_229;
				case 10:
					goto IL_ED;
				case 11:
					num2 = (short)1353908224;
					num = (int)((global::System.IntPtr)num2);
					continue;
				}
				goto IL_40;
				IL_229:
				if (trunkingSystem.General.TrkSysGeneralSystemType_A9252.Value != 3)
				{
					return false;
				}
				num2 = (short)52559873;
				num = (int)((global::System.IntPtr)num2);
			}
			IL_ED:
			IL_259:
			return trkSysSiteAliasSiteAliasType_A.Value == 2;
			IL_40:
			global::Motorola.MackinawCPS.CoreFeatures.TrunkingSystem.SiteAliasInnerSection siteAliasInnerSection = self as global::Motorola.MackinawCPS.CoreFeatures.TrunkingSystem.SiteAliasInnerSection;
			trunkingSystem = (self.ParentRecset.ParentSection.Parent as global::Motorola.MackinawCPS.CoreFeatures.TrunkingSystem.TrunkingSystem);
			trkSysGeneralCoverageType_A = trunkingSystem.General.TrkSysGeneralCoverageType_A7782;
			trkSysSiteAliasSiteAliasType_A = siteAliasInnerSection.TrkSysSiteAliasSiteAliasType_A41343;
			num2 = (short)424738820;
			num = (int)((global::System.IntPtr)num2);
			goto IL_0A;
		}

		// Token: 0x06000BF3 RID: 3059 RVA: 0x000C4000 File Offset: 0x000C2200
		internal static bool conValidateRangeForSiteAliasSystemIDBasedOnSystemType(global::AcpCommonLib.IAcpFeatureSection self)
		{
			switch (0)
			{
			case 0:
				goto IL_40;
			}
			int num;
			short num2;
			bool result;
			global::Motorola.MackinawCPS.CoreFeatures.TrunkingSystem.SiteAliasInnerSection siteAliasInnerSection;
			for (;;)
			{
				IL_0A:
				switch (num)
				{
				case 0:
				{
					global::AcpBusinessLayer.AcpSimpleRangeField trkSysSiteAliasSystemNumber_A;
					if (trkSysSiteAliasSystemNumber_A.Value >= 0)
					{
						num2 = (short)1874132999;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					return result;
				}
				case 1:
					result = true;
					num2 = (short)462487554;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 2:
					goto IL_109;
				case 3:
					goto IL_206;
				case 4:
				{
					global::Motorola.MackinawCPS.CoreFeatures.TrunkingSystem.TrunkingSystem trunkingSystem = self.ParentRecset.ParentSection.Parent as global::Motorola.MackinawCPS.CoreFeatures.TrunkingSystem.TrunkingSystem;
					global::AcpBusinessLayer.AcpSimpleRangeField trkSysSiteAliasSystemNumber_A = siteAliasInnerSection.TrkSysSiteAliasSystemNumber_A19669;
					result = false;
					if (trunkingSystem.General.TrkSysGeneralSystemType_A9252.Value == 2)
					{
						num2 = (short)881131526;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					num2 = (short)1824653312;
					num = (int)((global::System.IntPtr)num2);
					continue;
				}
				case 5:
				{
					global::AcpBusinessLayer.AcpSimpleRangeField trkSysSiteAliasSystemNumber_A;
					if (trkSysSiteAliasSystemNumber_A.Value >= 0)
					{
						num2 = (short)181207043;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					return result;
				}
				case 6:
					num2 = (short)851509253;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 7:
					num2 = (short)1539833864;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 8:
				{
					global::AcpBusinessLayer.AcpSimpleRangeField trkSysSiteAliasSystemNumber_A;
					if (trkSysSiteAliasSystemNumber_A.Value <= 4094)
					{
						num2 = (short)1122500618;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					return result;
				}
				case 9:
				{
					global::AcpBusinessLayer.AcpSimpleRangeField trkSysSiteAliasSystemNumber_A;
					if (trkSysSiteAliasSystemNumber_A.Value <= 65535)
					{
						num2 = (short)1732378625;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					return result;
				}
				case 10:
					result = true;
					num2 = (short)42795019;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 11:
				{
					num2 = (short)1117716480;
					short num3 = num2;
					num2 = (short)1864164460;
					short num4 = num2;
					num2 = (short)1683940460;
					switch ((num4 == num2) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_206;
					default:
						goto IL_1EC;
					}
					break;
				}
				}
				goto IL_40;
				IL_206:
				num2 = (short)469565449;
				num = (int)((global::System.IntPtr)num2);
			}
			IL_109:
			num2 = (short)1354498049;
			if (num2 != 0)
			{
			}
			return result;
			IL_1EC:
			num2 = (short)760020992;
			if (num2 != 0)
			{
			}
			return result;
			IL_40:
			siteAliasInnerSection = (self as global::Motorola.MackinawCPS.CoreFeatures.TrunkingSystem.SiteAliasInnerSection);
			num2 = (short)1741422596;
			num = (int)((global::System.IntPtr)num2);
			goto IL_0A;
		}

		// Token: 0x06000BF4 RID: 3060 RVA: 0x000C4294 File Offset: 0x000C2494
		internal static bool ConTrkSysApcoAndCvgTypIsSZOmnilinkOrIntraWACNAndSiteAlsEn(global::AcpCommonLib.IAcpFeatureSection self)
		{
			switch (0)
			{
			case 0:
				goto IL_38;
			}
			int num;
			short num2;
			global::Motorola.MackinawCPS.CoreFeatures.TrunkingSystem.TrunkingSystem trunkingSystem;
			global::AcpBusinessLayer.AcpListField trkSysGeneralCoverageType_A;
			global::AcpBusinessLayer.AcpListField trkSysSiteAliasSiteAliasType_A;
			for (;;)
			{
				IL_0A:
				switch (num)
				{
				case 0:
				{
					num2 = (short)1541462906;
					short num3 = num2;
					num2 = (short)850451322;
					switch ((num3 == num2) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_D4;
					default:
						num2 = (short)1439694849;
						if (num2 != 0)
						{
						}
						num2 = (short)390529024;
						if (num2 != 0)
						{
						}
						if (trunkingSystem.General.TrkSysGeneralSystemType_A9252.Value == 3)
						{
							num2 = (short)796590085;
							num = (int)((global::System.IntPtr)num2);
							continue;
						}
						return false;
					}
					break;
				}
				case 1:
					num2 = (short)699072520;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 2:
					if (trunkingSystem.SiteAlias.TrkSysSiteAliasSiteAliasEnable_A9148.Value)
					{
						num2 = (short)277282820;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					return false;
				case 3:
					num2 = (short)1281949702;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 4:
					num2 = (short)642187264;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 5:
					num2 = (short)25821193;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 6:
					if (trkSysGeneralCoverageType_A.Value != 6)
					{
						num2 = (short)1555169287;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_1AB;
				case 7:
					goto IL_251;
				case 8:
					if (trkSysSiteAliasSiteAliasType_A.Value == 0)
					{
						goto IL_D4;
					}
					goto IL_AA;
				case 9:
					if (trkSysGeneralCoverageType_A.Value != 0)
					{
						num2 = (short)2119303169;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					return false;
				}
				goto IL_38;
				IL_D4:
				num2 = (short)990248963;
				num = (int)((global::System.IntPtr)num2);
			}
			IL_AA:
			return trkSysSiteAliasSiteAliasType_A.Value == 2;
			IL_1AB:
			num2 = (short)1667366912;
			short num4 = num2;
			return true;
			IL_251:
			goto IL_AA;
			IL_38:
			global::Motorola.MackinawCPS.CoreFeatures.TrunkingSystem.SiteAliasInnerSection siteAliasInnerSection = self as global::Motorola.MackinawCPS.CoreFeatures.TrunkingSystem.SiteAliasInnerSection;
			trunkingSystem = (self.ParentRecset.ParentSection.Parent as global::Motorola.MackinawCPS.CoreFeatures.TrunkingSystem.TrunkingSystem);
			trkSysGeneralCoverageType_A = trunkingSystem.General.TrkSysGeneralCoverageType_A7782;
			trkSysSiteAliasSiteAliasType_A = siteAliasInnerSection.TrkSysSiteAliasSiteAliasType_A41343;
			num2 = (short)1462173698;
			num = (int)((global::System.IntPtr)num2);
			goto IL_0A;
		}

		// Token: 0x06000BF5 RID: 3061 RVA: 0x000C44F8 File Offset: 0x000C26F8
		internal static bool ConSystemKeyTypeNotEditable(global::AcpCommonLib.IAcpFeatureSection self)
		{
			short num = (short)1319275139;
			short num2 = num;
			num = (short)1475185283;
			switch (num2 == num)
			{
			}
			num = (short)498597888;
			if (num != 0)
			{
			}
			num = (short)538443777;
			if (num != 0)
			{
			}
			num = (short)891813888;
			short num3 = num;
			return false;
		}

		// Token: 0x06000BF6 RID: 3062 RVA: 0x000C45A4 File Offset: 0x000C27A4
		internal static bool ConSetTrkRadInhApp(global::AcpCommonLib.IAcpFeatureSection self)
		{
			short num = (short)1189840746;
			short num2 = num;
			num = (short)1237026666;
			switch (num2 == num)
			{
			}
			num = (short)365101056;
			if (num != 0)
			{
			}
			num = (short)1203568641;
			if (num != 0)
			{
			}
			num = (short)21495808;
			short num3 = num;
			return true;
		}

		// Token: 0x06000BF7 RID: 3063 RVA: 0x000C464C File Offset: 0x000C284C
		internal static bool ConValidateIntraWACNCoverageTypeForSysType(global::AcpCommonLib.IAcpFeatureSection self, int index)
		{
			short num = (short)790626304;
			int num2 = (int)num;
			switch (num2)
			{
			default:
			{
				switch (0)
				{
				case 0:
					goto IL_A7;
				}
				bool result;
				global::Motorola.MackinawCPS.CoreFeatures.RadioWide.RadioWideRecset radioWideRecset;
				global::Motorola.MackinawCPS.CoreFeatures.TrunkingSystem.General general;
				global::Motorola.MackinawCPS.CoreFeatures.DVRSWide.DVRSWide dvrswide;
				bool flag4;
				for (;;)
				{
					IL_28:
					bool flag2;
					bool flag3;
					bool flag5;
					switch (num2)
					{
					case 0:
						if (index == 6)
						{
							num = (short)1441923073;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return result;
					case 1:
					{
						bool flag = false;
						global::Motorola.MackinawCPS.CoreFeatures.RadioWide.Labtool labtool = radioWideRecset[0][10093] as global::Motorola.MackinawCPS.CoreFeatures.RadioWide.Labtool;
						num = (short)408158211;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 2:
						flag2 = false;
						goto IL_24E;
					case 3:
					{
						global::Motorola.MackinawCPS.CoreFeatures.RadioWide.Labtool labtool;
						if (labtool != null)
						{
							num = (short)1931280390;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_386;
					}
					case 4:
						return result;
					case 5:
					{
						global::Motorola.MackinawCPS.CoreFeatures.RadioWide.RadioWide radioWide;
						if (radioWide != null)
						{
							num = (short)190316561;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_161;
					}
					case 6:
					{
						global::Motorola.MackinawCPS.CoreFeatures.RadioWide.Labtool labtool;
						bool flag = labtool.RadWideLabtoolLimitedISSIDVRSOperationCapable_43045.Value;
						num = (short)1119748114;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 7:
						num = (short)1756626957;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 8:
						num = (short)1686241296;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 9:
						num = (short)1787363350;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 10:
						if (general.TrkSysGeneralSystemType_A9252.Value == 3)
						{
							num = (short)652607500;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_3E9;
					case 11:
						goto IL_22A;
					case 12:
						goto IL_3C5;
					case 13:
					{
						bool flag;
						if (dvrswide.General.RadErgoWideDigitalVehicularRepeaterSystemDVRSHardwareEnable_A7911.Value && flag)
						{
							num = (short)1823014923;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_3E9;
					}
					case 14:
						if (radioWideRecset != null)
						{
							num = (short)1504968724;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_161;
					case 15:
					{
						num = (short)1013383160;
						short num3 = num;
						num = (short)229507064;
						switch ((num3 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_3C5;
						default:
							num = (short)1570832385;
							if (num != 0)
							{
							}
							num = (short)860422144;
							if (num != 0)
							{
							}
							if (index == 5)
							{
								num = (short)1077018648;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							num = (short)109838336;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						break;
					}
					case 16:
					{
						global::Motorola.MackinawCPS.CoreFeatures.RadioWide.RadioWide radioWide;
						flag2 = !radioWide.DualRadio.RadWideDualRadioSecRadioTransmissionCapability_A42238.Value;
						goto IL_24E;
					}
					case 17:
						num = (short)585629721;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 18:
						goto IL_386;
					case 19:
						flag3 = !flag4;
						goto IL_440;
					case 20:
					{
						global::Motorola.MackinawCPS.CoreFeatures.RadioWide.RadioWide radioWide = radioWideRecset[0] as global::Motorola.MackinawCPS.CoreFeatures.RadioWide.RadioWide;
						num = (short)938213381;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 21:
						if (general.TrkSysGeneralSystemType_A9252.Value == 3)
						{
							num = (short)1133772809;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)688324631;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 22:
						flag5 = !flag4;
						goto IL_3CA;
					case 23:
						flag5 = false;
						goto IL_3CA;
					case 24:
						num = (short)790691861;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 25:
					{
						global::Motorola.MackinawCPS.CoreFeatures.RadioWide.RadioWide radioWide;
						if (radioWide.DualRadio.RadWideDualRadioSelection_A42236.Value == 2)
						{
							num = (short)507314184;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)2063204354;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 26:
						if (dvrswide.General.RadErgoWideDigitalVehicularRepeaterSystemDVRSHardwareEnable_A7911.Value)
						{
							num = (short)2075656199;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_22A;
					case 27:
						return result;
					case 28:
						goto IL_161;
					case 29:
						flag3 = false;
						goto IL_440;
					}
					goto IL_A7;
					IL_161:
					num = (short)1128923151;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_22A:
					num = (short)1893531667;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_24E:
					flag4 = flag2;
					num = (short)1266417692;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_386:
					num = (short)637141002;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_3C5:
					num = (short)243990554;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_3CA:
					result = flag5;
					num = (short)1909391364;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_3E9:
					num = (short)1271922717;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_440:
					result = flag3;
					num = (short)421068800;
					short num4 = num;
					num = (short)1644232731;
					num2 = (int)((global::System.IntPtr)num);
				}
				return result;
				IL_A7:
				general = (self as global::Motorola.MackinawCPS.CoreFeatures.TrunkingSystem.General);
				result = true;
				dvrswide = (global::AcpCommonLib.FeatureManager.GetFeature(4142)[0] as global::Motorola.MackinawCPS.CoreFeatures.DVRSWide.DVRSWide);
				radioWideRecset = (global::AcpCommonLib.FeatureManager.GetFeature(2045) as global::Motorola.MackinawCPS.CoreFeatures.RadioWide.RadioWideRecset);
				flag4 = false;
				num = (short)773849102;
				num2 = (int)((global::System.IntPtr)num);
				goto IL_28;
			}
			}
		}

		// Token: 0x06000BF8 RID: 3064 RVA: 0x000C4BE8 File Offset: 0x000C2DE8
		public static bool ConTrkPer8382CallApplicabilityConstraint(global::AcpCommonLib.IAcpFeatureSection self)
		{
			switch (0)
			{
			case 0:
				goto IL_2C;
			}
			int num;
			short num2;
			int num3;
			for (;;)
			{
				IL_0A:
				switch (num)
				{
				case 0:
				{
					global::Motorola.MackinawCPS.CoreFeatures.TrunkingSystem.TrunkingSystem trunkingSystem;
					if (trunkingSystem != null)
					{
						num2 = (short)1160445958;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_48;
				}
				case 1:
					goto IL_112;
				case 2:
					IL_C0:
					goto IL_48;
				case 3:
				{
					if (num3 >= global::AcpCommonLib.FeatureManager.GetFeature(2064).Count)
					{
						num2 = (short)856096772;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					global::Motorola.MackinawCPS.CoreFeatures.TrunkingSystem.TrunkingSystem trunkingSystem = global::AcpCommonLib.FeatureManager.GetFeature(2064)[num3] as global::Motorola.MackinawCPS.CoreFeatures.TrunkingSystem.TrunkingSystem;
					num2 = (short)340000768;
					num = (int)((global::System.IntPtr)num2);
					continue;
				}
				case 4:
					goto IL_1A2;
				case 5:
					goto IL_112;
				case 6:
				{
					global::Motorola.MackinawCPS.CoreFeatures.TrunkingSystem.TrunkingSystem trunkingSystem;
					(trunkingSystem[10157] as global::Motorola.MackinawCPS.CoreFeatures.TrunkingSystem.General).TrkSysGeneralSystemType_A9252.CalculateValidity();
					num2 = (short)1786576896;
					short num4 = num2;
					num2 = (short)2064711682;
					num = (int)((global::System.IntPtr)num2);
					continue;
				}
				}
				goto IL_2C;
				IL_48:
				num3++;
				num2 = (short)139657221;
				num = (int)((global::System.IntPtr)num2);
				continue;
				IL_112:
				num2 = (short)44270436;
				short num5 = num2;
				num2 = (short)1884324708;
				switch ((num5 == num2) ? 1 : 0)
				{
				case 0:
				case 2:
					goto IL_C0;
				default:
					num2 = (short)2013921280;
					if (num2 != 0)
					{
					}
					num2 = (short)1939537923;
					num = (int)((global::System.IntPtr)num2);
					break;
				}
			}
			IL_1A2:
			num2 = (short)1979711489;
			if (num2 != 0)
			{
			}
			return true;
			IL_2C:
			num3 = 0;
			num2 = (short)840302593;
			num = (int)((global::System.IntPtr)num2);
			goto IL_0A;
		}

		// Token: 0x06000BF9 RID: 3065 RVA: 0x000C4DC4 File Offset: 0x000C2FC4
		public static bool ConTrkSysDynRegrIsEnabledAndNonDynamicZone(global::AcpCommonLib.IAcpFeatureSection self)
		{
			switch (0)
			{
			case 0:
				goto IL_20;
			}
			int num;
			short num2;
			global::Motorola.MackinawCPS.CoreFeatures.ZoneChannelAssignment.ZoneChannelAssignment zoneChannelAssignment;
			for (;;)
			{
				IL_0A:
				switch (num)
				{
				case 0:
					return false;
				case 1:
					num2 = (short)282591233;
					if (num2 != 0)
					{
					}
					num2 = (short)1014693891;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 2:
				{
					num2 = (short)1757499639;
					short num3 = num2;
					num2 = (short)194203895;
					switch ((num3 == num2) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_126;
					case 1:
						break;
					default:
					{
						num2 = (short)2069168128;
						short num4 = num2;
						break;
					}
					}
					num2 = (short)355729408;
					if (num2 != 0)
					{
					}
					if (zoneChannelAssignment != null)
					{
						num2 = (short)755171329;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_151;
				}
				case 3:
					goto IL_126;
				}
				goto IL_20;
				IL_126:
				if (!zoneChannelAssignment.Zone.ZnChanCfgZoneDynamicZoneEnable_A41257.Value)
				{
					goto IL_151;
				}
				num2 = (short)183304192;
				num = (int)((global::System.IntPtr)num2);
			}
			return false;
			IL_151:
			global::Motorola.MackinawCPS.CoreFeatures.TrunkingSystem.Features features;
			return features.TrkSysFeaturesDynamicRegroupingEnable_A7969.Value;
			IL_20:
			features = (self as global::Motorola.MackinawCPS.CoreFeatures.TrunkingSystem.Features);
			zoneChannelAssignment = (features.TrkSysFeaturesZone_A9717.ReferencedNode as global::Motorola.MackinawCPS.CoreFeatures.ZoneChannelAssignment.ZoneChannelAssignment);
			num2 = (short)1321795586;
			num = (int)((global::System.IntPtr)num2);
			goto IL_0A;
		}

		// Token: 0x06000BFA RID: 3066 RVA: 0x000C4F30 File Offset: 0x000C3130
		public static void conSetValueTxFrequencyBasedOnTypeIIFrequencyBand(global::AcpCommonLib.IAcpFeatureSection self, global::AcpCommonLib.UndoRedo.ContainerTask task)
		{
			short num = (short)1772158976;
			switch (num)
			{
			default:
			{
				num = (short)662110208;
				short num2 = num;
				global::Motorola.MackinawCPS.CoreFeatures.TrunkingSystem.General general = self as global::Motorola.MackinawCPS.CoreFeatures.TrunkingSystem.General;
				global::Motorola.MackinawCPS.CoreFeatures.TrunkingSystem.TrunkingSystem trunkingSystem = self.Parent as global::Motorola.MackinawCPS.CoreFeatures.TrunkingSystem.TrunkingSystem;
				global::AcpBusinessLayer.AcpListField trkSysGeneralSystemType_A = general.TrkSysGeneralSystemType_A9252;
				global::AcpBusinessLayer.AcpListField trkSysGeneralTypeIIFrequencyBand_A = general.TrkSysGeneralTypeIIFrequencyBand_A12491;
				global::Motorola.MackinawCPS.CoreFeatures.RadioWide.RxFrequencySplitFPPInnerRecset rxFrequencySplitFPPInnerRecset = (global::AcpCommonLib.FeatureManager.GetFeature(2045) as global::Motorola.MackinawCPS.CoreFeatures.RadioWide.RadioWideRecset)[0][10096].EmbeddedRecset as global::Motorola.MackinawCPS.CoreFeatures.RadioWide.RxFrequencySplitFPPInnerRecset;
				global::System.Collections.Generic.IEnumerator<global::AcpBusinessLayer.FeatureNode> enumerator = (trunkingSystem.ControlChannels.EmbeddedRecset as global::Motorola.MackinawCPS.CoreFeatures.TrunkingSystem.ControlChannelsInnerRecset).GetEnumerator();
				try
				{
					num = (short)1945174033;
					int num3 = (int)((global::System.IntPtr)num);
					for (;;)
					{
						switch (num3)
						{
						case 0:
							num = (short)172883969;
							if (num != 0)
							{
							}
							break;
						case 1:
						{
							global::System.Collections.Generic.IEnumerator<global::AcpBusinessLayer.FeatureNode> enumerator2 = rxFrequencySplitFPPInnerRecset.GetEnumerator();
							num = (short)544079875;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						}
						case 2:
							num = (short)1083899908;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						case 3:
							try
							{
								num = (short)1179844617;
								num3 = (int)((global::System.IntPtr)num);
								for (;;)
								{
									switch (num3)
									{
									case 0:
									{
										int num4;
										global::AcpCommonLib.IAcpFeatureNode acpFeatureNode;
										if (num4 > (acpFeatureNode[10097] as global::Motorola.MackinawCPS.CoreFeatures.RadioWide.RxFrequencySplitFPPInnerSection).RadWideLabtoolRxStartFrequencySplit_A9032.Value * 5)
										{
											num = (short)2104229894;
											num3 = (int)((global::System.IntPtr)num);
											continue;
										}
										break;
									}
									case 1:
									{
										global::AcpCommonLib.IAcpFeatureNode acpFeatureNode;
										if ((acpFeatureNode[10097] as global::Motorola.MackinawCPS.CoreFeatures.RadioWide.RxFrequencySplitFPPInnerSection).RadWideLabtoolRxBandSplitName_A24797.Value == global::CommonResources.AcgResources.ID_P_900M)
										{
											num = (short)1209073666;
											num3 = (int)((global::System.IntPtr)num);
											continue;
										}
										break;
									}
									case 2:
										num = (short)851312640;
										num3 = (int)((global::System.IntPtr)num);
										continue;
									case 4:
										num = (short)1900806151;
										num3 = (int)((global::System.IntPtr)num);
										continue;
									case 5:
									{
										int num4;
										global::AcpCommonLib.IAcpFeatureNode acpFeatureNode;
										if (num4 < (acpFeatureNode[10097] as global::Motorola.MackinawCPS.CoreFeatures.RadioWide.RxFrequencySplitFPPInnerSection).RadWideLabtoolRxEndFrequencySplit_A9015.Value * 5)
										{
											num = (short)151781386;
											num3 = (int)((global::System.IntPtr)num);
											continue;
										}
										break;
									}
									case 6:
										num = (short)1213530117;
										num3 = (int)((global::System.IntPtr)num);
										continue;
									case 7:
										goto IL_F1A;
									case 8:
									{
										global::System.Collections.Generic.IEnumerator<global::AcpBusinessLayer.FeatureNode> enumerator2;
										if (!enumerator2.MoveNext())
										{
											num = (short)987299844;
											num3 = (int)((global::System.IntPtr)num);
											continue;
										}
										global::AcpCommonLib.IAcpFeatureNode acpFeatureNode = enumerator2.Current;
										num = (short)594673665;
										num3 = (int)((global::System.IntPtr)num);
										continue;
									}
									case 9:
										switch (0)
										{
										case 0:
											goto IL_D74;
										}
										continue;
									case 10:
									{
										int num4;
										global::AcpBusinessLayer.AcpFrequencyField trkSysControlChannelsTxFrequencyMHz_A;
										task.AddTask(new global::AcpBusinessLayer.UndoRedo.ModifyDataTask<int>(trkSysControlChannelsTxFrequencyMHz_A, (num4 - 39000000) / 5));
										num = (short)991166467;
										num3 = (int)((global::System.IntPtr)num);
										continue;
									}
									}
									IL_E32:
									num = (short)627048456;
									num3 = (int)((global::System.IntPtr)num);
									continue;
									IL_D74:
									goto IL_E32;
								}
								IL_F1A:
								goto IL_FCF;
							}
							finally
							{
								num = (short)293011458;
								num3 = (int)((global::System.IntPtr)num);
								for (;;)
								{
									global::System.Collections.Generic.IEnumerator<global::AcpBusinessLayer.FeatureNode> enumerator2;
									switch (num3)
									{
									case 0:
										enumerator2.Dispose();
										num = (short)1790640129;
										num3 = (int)((global::System.IntPtr)num);
										continue;
									case 1:
										goto IL_F8B;
									case 2:
										switch (0)
										{
										case 0:
											goto IL_F53;
										}
										continue;
									}
									IL_F53:
									if (enumerator2 == null)
									{
										break;
									}
									num = (short)1738211328;
									num3 = (int)((global::System.IntPtr)num);
								}
								IL_F8B:;
							}
							goto IL_F8E;
							IL_FCF:
							num = (short)928907279;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						case 4:
							goto IL_1036;
						case 5:
						{
							if (!enumerator.MoveNext())
							{
								num = (short)642842626;
								num3 = (int)((global::System.IntPtr)num);
								continue;
							}
							global::Motorola.MackinawCPS.CoreFeatures.TrunkingSystem.ControlChannelsInnerSection controlChannelsInnerSection = (enumerator.Current as global::Motorola.MackinawCPS.CoreFeatures.TrunkingSystem.ControlChannelsInner).ControlChannelsInnerSection;
							global::AcpBusinessLayer.AcpFrequencyField trkSysControlChannelsTxFrequencyMHz_A = controlChannelsInnerSection.TrkSysControlChannelsTxFrequencyMHz_A9535;
							int num4 = controlChannelsInnerSection.TrkSysControlChannelsRxFrequencyMHz_A9018.Value * 5;
							num = (short)1955135496;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						}
						case 6:
							goto IL_B25;
						case 7:
						{
							global::System.Collections.Generic.IEnumerator<global::AcpBusinessLayer.FeatureNode> enumerator2 = rxFrequencySplitFPPInnerRecset.GetEnumerator();
							num = (short)1622605833;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						}
						case 8:
							if (trkSysGeneralSystemType_A.Value == 2)
							{
								num = (short)431357958;
								num3 = (int)((global::System.IntPtr)num);
								continue;
							}
							goto IL_F8E;
						case 9:
							goto IL_542;
						case 10:
							if (trkSysGeneralTypeIIFrequencyBand_A.Value == 4)
							{
								num = (short)1452539905;
								num3 = (int)((global::System.IntPtr)num);
								continue;
							}
							break;
						case 11:
							if (trkSysGeneralTypeIIFrequencyBand_A.Value == 3)
							{
								num = (short)830472205;
								num3 = (int)((global::System.IntPtr)num);
								continue;
							}
							goto IL_CE0;
						case 12:
							if (trkSysGeneralSystemType_A.Value == 3)
							{
								num = (short)1123287047;
								num3 = (int)((global::System.IntPtr)num);
								continue;
							}
							break;
						case 13:
						{
							global::System.Collections.Generic.IEnumerator<global::AcpBusinessLayer.FeatureNode> enumerator2 = rxFrequencySplitFPPInnerRecset.GetEnumerator();
							num = (short)104857614;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						}
						case 14:
							try
							{
								num = (short)1648492563;
								num3 = (int)((global::System.IntPtr)num);
								for (;;)
								{
									switch (num3)
									{
									case 0:
									{
										int num4;
										global::AcpBusinessLayer.AcpFrequencyField trkSysControlChannelsTxFrequencyMHz_A;
										task.AddTask(new global::AcpBusinessLayer.UndoRedo.ModifyDataTask<int>(trkSysControlChannelsTxFrequencyMHz_A, (num4 - 45000000) / 5));
										num = (short)1635057682;
										num3 = (int)((global::System.IntPtr)num);
										continue;
									}
									case 2:
										num = (short)1016791046;
										num3 = (int)((global::System.IntPtr)num);
										continue;
									case 3:
										goto IL_27A;
									case 4:
										num = (short)814219277;
										num3 = (int)((global::System.IntPtr)num);
										continue;
									case 5:
									{
										string value;
										if (!(value == global::CommonResources.AcgResources.ID_P_700M))
										{
											num = (short)379256846;
											num3 = (int)((global::System.IntPtr)num);
											continue;
										}
										goto IL_27A;
									}
									case 6:
										goto IL_4CE;
									case 7:
									{
										string value;
										if (value == global::CommonResources.AcgResources.ID_P_700M_1)
										{
											num = (short)364118019;
											num3 = (int)((global::System.IntPtr)num);
											continue;
										}
										goto IL_35E;
									}
									case 8:
									{
										int num4;
										global::AcpCommonLib.IAcpFeatureNode acpFeatureNode2;
										if (num4 > (acpFeatureNode2[10097] as global::Motorola.MackinawCPS.CoreFeatures.RadioWide.RxFrequencySplitFPPInnerSection).RadWideLabtoolRxStartFrequencySplit_A9032.Value * 5)
										{
											num = (short)459014148;
											num3 = (int)((global::System.IntPtr)num);
											continue;
										}
										goto IL_35E;
									}
									case 9:
									{
										int num4;
										global::AcpCommonLib.IAcpFeatureNode acpFeatureNode2;
										if (num4 >= (acpFeatureNode2[10097] as global::Motorola.MackinawCPS.CoreFeatures.RadioWide.RxFrequencySplitFPPInnerSection).RadWideLabtoolRxStartFrequencySplit_A9032.Value * 5)
										{
											num = (short)916062225;
											num3 = (int)((global::System.IntPtr)num);
											continue;
										}
										break;
									}
									case 10:
									{
										global::System.Collections.Generic.IEnumerator<global::AcpBusinessLayer.FeatureNode> enumerator2;
										if (!enumerator2.MoveNext())
										{
											num = (short)758185986;
											num3 = (int)((global::System.IntPtr)num);
											continue;
										}
										global::AcpCommonLib.IAcpFeatureNode acpFeatureNode2 = enumerator2.Current;
										string value = (acpFeatureNode2[10097] as global::Motorola.MackinawCPS.CoreFeatures.RadioWide.RxFrequencySplitFPPInnerSection).RadWideLabtoolRxBandSplitName_A24797.Value;
										num = (short)1738932229;
										num3 = (int)((global::System.IntPtr)num);
										continue;
									}
									case 11:
									{
										int num4;
										global::AcpCommonLib.IAcpFeatureNode acpFeatureNode2;
										if (num4 < (acpFeatureNode2[10097] as global::Motorola.MackinawCPS.CoreFeatures.RadioWide.RxFrequencySplitFPPInnerSection).RadWideLabtoolRxEndFrequencySplit_A9015.Value * 5)
										{
											num = (short)958005248;
											num3 = (int)((global::System.IntPtr)num);
											continue;
										}
										break;
									}
									case 12:
										num = (short)884867081;
										num3 = (int)((global::System.IntPtr)num);
										continue;
									case 13:
									{
										int num4;
										global::AcpCommonLib.IAcpFeatureNode acpFeatureNode2;
										if (num4 < (acpFeatureNode2[10097] as global::Motorola.MackinawCPS.CoreFeatures.RadioWide.RxFrequencySplitFPPInnerSection).RadWideLabtoolRxEndFrequencySplit_A9015.Value * 5)
										{
											num = (short)958332943;
											num3 = (int)((global::System.IntPtr)num);
											continue;
										}
										goto IL_35E;
									}
									case 14:
										num = (short)568328199;
										num3 = (int)((global::System.IntPtr)num);
										continue;
									case 15:
									{
										int num4;
										global::AcpBusinessLayer.AcpFrequencyField trkSysControlChannelsTxFrequencyMHz_A;
										task.AddTask(new global::AcpBusinessLayer.UndoRedo.ModifyDataTask<int>(trkSysControlChannelsTxFrequencyMHz_A, (num4 + 30000000) / 5));
										num = (short)2002386945;
										num3 = (int)((global::System.IntPtr)num);
										continue;
									}
									case 16:
									{
										global::AcpCommonLib.IAcpFeatureNode acpFeatureNode2;
										if ((acpFeatureNode2[10097] as global::Motorola.MackinawCPS.CoreFeatures.RadioWide.RxFrequencySplitFPPInnerSection).RadWideLabtoolRxBandSplitName_A24797.Value == global::CommonResources.AcgResources.ID_P_800M)
										{
											num = (short)941621260;
											num3 = (int)((global::System.IntPtr)num);
											continue;
										}
										break;
									}
									case 17:
										num = (short)1898250251;
										num3 = (int)((global::System.IntPtr)num);
										continue;
									case 19:
										switch (0)
										{
										case 0:
											goto IL_192;
										}
										continue;
									}
									goto IL_192;
									IL_27A:
									num = (short)780533768;
									num3 = (int)((global::System.IntPtr)num);
									continue;
									IL_319:
									num = (short)1577844746;
									num3 = (int)((global::System.IntPtr)num);
									continue;
									IL_192:
									goto IL_319;
									IL_35E:
									num = (short)815661072;
									num3 = (int)((global::System.IntPtr)num);
								}
								IL_4CE:
								goto IL_CE0;
							}
							finally
							{
								num = (short)690421762;
								num3 = (int)((global::System.IntPtr)num);
								for (;;)
								{
									global::System.Collections.Generic.IEnumerator<global::AcpBusinessLayer.FeatureNode> enumerator2;
									switch (num3)
									{
									case 0:
										goto IL_53F;
									case 1:
										enumerator2.Dispose();
										num = (short)1104740352;
										num3 = (int)((global::System.IntPtr)num);
										continue;
									case 2:
										switch (0)
										{
										case 0:
											goto IL_506;
										}
										continue;
									}
									IL_506:
									if (enumerator2 == null)
									{
										break;
									}
									num = (short)62193665;
									num3 = (int)((global::System.IntPtr)num);
								}
								IL_53F:;
							}
							goto Block_3;
						case 15:
							if (trunkingSystem.TypeIIChannelSetup.TrkSysTypeIIChannelSetupChannelBandwidthkHz_A7654 != 50)
							{
								num = (short)317325328;
								num3 = (int)((global::System.IntPtr)num);
								continue;
							}
							break;
						case 16:
							task.AddTask(new global::AcpBusinessLayer.UndoRedo.ModifyDataTask<int>(trunkingSystem.TypeIIChannelSetup.TrkSysTypeIIChannelSetupChannelBandwidthkHz_A7654, 50));
							num = (short)721813504;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						case 17:
							switch (0)
							{
							case 0:
								goto IL_116;
							}
							continue;
						}
						goto IL_116;
						IL_B25:
						num = (short)1004404747;
						num3 = (int)((global::System.IntPtr)num);
						continue;
						Block_3:
						try
						{
							IL_542:
							num = (short)65863706;
							num3 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								switch (num3)
								{
								case 0:
								{
									int num4;
									global::AcpCommonLib.IAcpFeatureNode acpFeatureNode3;
									if (num4 >= (acpFeatureNode3[10097] as global::Motorola.MackinawCPS.CoreFeatures.RadioWide.RxFrequencySplitFPPInnerSection).RadWideLabtoolRxStartFrequencySplit_A9032.Value * 5)
									{
										num = (short)547815434;
										num3 = (int)((global::System.IntPtr)num);
										continue;
									}
									break;
								}
								case 1:
								{
									global::System.Collections.Generic.IEnumerator<global::AcpBusinessLayer.FeatureNode> enumerator2;
									if (!enumerator2.MoveNext())
									{
										num = (short)1535442953;
										num3 = (int)((global::System.IntPtr)num);
										continue;
									}
									global::AcpCommonLib.IAcpFeatureNode acpFeatureNode3 = enumerator2.Current;
									string value2 = (acpFeatureNode3[10097] as global::Motorola.MackinawCPS.CoreFeatures.RadioWide.RxFrequencySplitFPPInnerSection).RadWideLabtoolRxBandSplitName_A24797.Value;
									num = (short)612040707;
									num3 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 2:
								{
									global::AcpCommonLib.IAcpFeatureNode acpFeatureNode3;
									if ((acpFeatureNode3[10097] as global::Motorola.MackinawCPS.CoreFeatures.RadioWide.RxFrequencySplitFPPInnerSection).RadWideLabtoolRxBandSplitName_A24797.Value == global::CommonResources.AcgResources.ID_P_800M)
									{
										num = (short)197263366;
										num3 = (int)((global::System.IntPtr)num);
										continue;
									}
									goto IL_9EC;
								}
								case 3:
								{
									string value2;
									if (!(value2 == global::CommonResources.AcgResources.ID_P_700M))
									{
										num = (short)644546580;
										num3 = (int)((global::System.IntPtr)num);
										continue;
									}
									goto IL_7C4;
								}
								case 5:
								{
									int num4;
									global::AcpBusinessLayer.AcpFrequencyField trkSysControlChannelsTxFrequencyMHz_A;
									task.AddTask(new global::AcpBusinessLayer.UndoRedo.ModifyDataTask<int>(trkSysControlChannelsTxFrequencyMHz_A, (num4 - 45000000) / 5));
									num = (short)372506641;
									num3 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 6:
									num = (short)337510422;
									num3 = (int)((global::System.IntPtr)num);
									continue;
								case 8:
									goto IL_7C4;
								case 9:
									num = (short)775946253;
									num3 = (int)((global::System.IntPtr)num);
									continue;
								case 10:
									num = (short)194641932;
									num3 = (int)((global::System.IntPtr)num);
									continue;
								case 11:
								{
									string value2;
									if (value2 == global::CommonResources.AcgResources.ID_P_700M_1)
									{
										num = (short)996605960;
										num3 = (int)((global::System.IntPtr)num);
										continue;
									}
									goto IL_730;
								}
								case 12:
								{
									int num4;
									global::AcpCommonLib.IAcpFeatureNode acpFeatureNode3;
									if (num4 < (acpFeatureNode3[10097] as global::Motorola.MackinawCPS.CoreFeatures.RadioWide.RxFrequencySplitFPPInnerSection).RadWideLabtoolRxEndFrequencySplit_A9015.Value * 5)
									{
										num = (short)259457042;
										num3 = (int)((global::System.IntPtr)num);
										continue;
									}
									break;
								}
								case 13:
									goto IL_A63;
								case 14:
									num = (short)975503376;
									num3 = (int)((global::System.IntPtr)num);
									continue;
								case 15:
								{
									int num4;
									global::AcpCommonLib.IAcpFeatureNode acpFeatureNode3;
									if (num4 > (acpFeatureNode3[10097] as global::Motorola.MackinawCPS.CoreFeatures.RadioWide.RxFrequencySplitFPPInnerSection).RadWideLabtoolRxStartFrequencySplit_A9032.Value * 5)
									{
										num = (short)999882766;
										num3 = (int)((global::System.IntPtr)num);
										continue;
									}
									goto IL_730;
								}
								case 16:
								{
									int num4;
									global::AcpCommonLib.IAcpFeatureNode acpFeatureNode3;
									if (num4 < (acpFeatureNode3[10097] as global::Motorola.MackinawCPS.CoreFeatures.RadioWide.RxFrequencySplitFPPInnerSection).RadWideLabtoolRxEndFrequencySplit_A9015.Value * 5)
									{
										num = (short)1046216723;
										num3 = (int)((global::System.IntPtr)num);
										continue;
									}
									goto IL_730;
								}
								case 18:
								{
									int num4;
									global::AcpBusinessLayer.AcpFrequencyField trkSysControlChannelsTxFrequencyMHz_A;
									task.AddTask(new global::AcpBusinessLayer.UndoRedo.ModifyDataTask<int>(trkSysControlChannelsTxFrequencyMHz_A, (num4 - 39000000) / 5));
									num = (short)587202567;
									num3 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 19:
								{
									int num4;
									global::AcpBusinessLayer.AcpFrequencyField trkSysControlChannelsTxFrequencyMHz_A;
									task.AddTask(new global::AcpBusinessLayer.UndoRedo.ModifyDataTask<int>(trkSysControlChannelsTxFrequencyMHz_A, (num4 + 30000000) / 5));
									num = (short)710934532;
									num3 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 20:
									num = (short)565051403;
									num3 = (int)((global::System.IntPtr)num);
									continue;
								case 21:
									num = (short)1206190103;
									num3 = (int)((global::System.IntPtr)num);
									continue;
								case 22:
								{
									int num4;
									global::AcpCommonLib.IAcpFeatureNode acpFeatureNode3;
									if (num4 >= (acpFeatureNode3[10097] as global::Motorola.MackinawCPS.CoreFeatures.RadioWide.RxFrequencySplitFPPInnerSection).RadWideLabtoolRxStartFrequencySplit_A9032.Value * 5)
									{
										num = (short)2140012565;
										num3 = (int)((global::System.IntPtr)num);
										continue;
									}
									goto IL_9EC;
								}
								case 23:
								{
									int num4;
									global::AcpCommonLib.IAcpFeatureNode acpFeatureNode3;
									if (num4 < (acpFeatureNode3[10097] as global::Motorola.MackinawCPS.CoreFeatures.RadioWide.RxFrequencySplitFPPInnerSection).RadWideLabtoolRxEndFrequencySplit_A9015.Value * 5)
									{
										num = (short)1910112261;
										num3 = (int)((global::System.IntPtr)num);
										continue;
									}
									goto IL_9EC;
								}
								case 24:
								{
									global::AcpCommonLib.IAcpFeatureNode acpFeatureNode3;
									if ((acpFeatureNode3[10097] as global::Motorola.MackinawCPS.CoreFeatures.RadioWide.RxFrequencySplitFPPInnerSection).RadWideLabtoolRxBandSplitName_A24797.Value == global::CommonResources.AcgResources.ID_P_900M)
									{
										num = (short)999292953;
										num3 = (int)((global::System.IntPtr)num);
										continue;
									}
									break;
								}
								case 25:
									num = (short)266993664;
									num3 = (int)((global::System.IntPtr)num);
									continue;
								case 26:
									switch (0)
									{
									case 0:
										goto IL_5D4;
									}
									continue;
								}
								goto IL_5D4;
								IL_730:
								num = (short)1526530050;
								num3 = (int)((global::System.IntPtr)num);
								continue;
								IL_7C4:
								num = (short)232587279;
								num3 = (int)((global::System.IntPtr)num);
								continue;
								IL_865:
								num = (short)1202454529;
								num3 = (int)((global::System.IntPtr)num);
								continue;
								IL_5D4:
								goto IL_865;
								IL_9EC:
								num = (short)1319436312;
								num3 = (int)((global::System.IntPtr)num);
							}
							IL_A63:
							goto IL_BEA;
						}
						finally
						{
							num = (short)780271617;
							num3 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								IL_A87:
								global::System.Collections.Generic.IEnumerator<global::AcpBusinessLayer.FeatureNode> enumerator2;
								switch (num3)
								{
								case 0:
									enumerator2.Dispose();
									num = (short)715259906;
									num3 = (int)((global::System.IntPtr)num);
									continue;
								case 1:
									switch (0)
									{
									case 0:
										goto IL_A9A;
									}
									continue;
								case 2:
									goto IL_B22;
								}
								IL_A9A:
								while (enumerator2 != null)
								{
									num = (short)226498120;
									short num5 = num;
									num = (short)2144998984;
									switch ((num5 == num) ? 1 : 0)
									{
									case 0:
									case 2:
										break;
									default:
										num = (short)789774336;
										if (num != 0)
										{
										}
										num = (short)1740767232;
										num3 = (int)((global::System.IntPtr)num);
										goto IL_A87;
									}
								}
								break;
							}
							IL_B22:;
						}
						goto IL_B25;
						IL_BEA:
						num = (short)693370885;
						num3 = (int)((global::System.IntPtr)num);
						continue;
						IL_116:
						goto IL_BEA;
						IL_CE0:
						num = (short)2109997066;
						num3 = (int)((global::System.IntPtr)num);
						continue;
						IL_F8E:
						num = (short)1210253324;
						num3 = (int)((global::System.IntPtr)num);
					}
					IL_1036:;
				}
				finally
				{
					num = (short)1571094530;
					int num3 = (int)((global::System.IntPtr)num);
					for (;;)
					{
						switch (num3)
						{
						case 0:
							enumerator.Dispose();
							num = (short)2110062593;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						case 1:
							goto IL_10A4;
						case 2:
							switch (0)
							{
							case 0:
								goto IL_106C;
							}
							continue;
						}
						IL_106C:
						if (enumerator == null)
						{
							break;
						}
						num = (short)2036137984;
						num3 = (int)((global::System.IntPtr)num);
					}
					IL_10A4:;
				}
				return;
			}
			}
		}

		// Token: 0x06000BFB RID: 3067 RVA: 0x000C6048 File Offset: 0x000C4248
		internal static bool ConTrkSysTypeIsAstro25AndTriggerValidity(global::AcpCommonLib.IAcpFeatureSection self)
		{
			short num = (short)379584513;
			if (num != 0)
			{
			}
			num = (short)122814464;
			int num2 = (int)num;
			switch (num2)
			{
			default:
			{
				switch (0)
				{
				case 0:
					goto IL_6C;
				}
				global::AcpCommonLib.IAcpRecordset feature;
				for (;;)
				{
					IL_51:
					global::System.Collections.Generic.IEnumerator<global::AcpBusinessLayer.FeatureNode> enumerator2;
					switch (num2)
					{
					case 0:
						if (feature != null)
						{
							num = (short)646381569;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_519;
					case 1:
						num = (short)1418723331;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 2:
						goto IL_4B0;
					case 3:
						if (feature.Count != 0)
						{
							num = (short)653524994;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_519;
					case 4:
						try
						{
							num = (short)1107361796;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								global::Motorola.MackinawCPS.CoreFeatures.ScanList.ScanList scanList;
								global::Motorola.MackinawCPS.CoreFeatures.ScanList.ScanListInnerRecset scanListInnerRecset;
								switch (num2)
								{
								case 0:
									try
									{
										num = (short)1047592961;
										num2 = (int)((global::System.IntPtr)num);
										for (;;)
										{
											switch (num2)
											{
											case 0:
											{
												global::Motorola.MackinawCPS.CoreFeatures.ScanList.ScanListInner scanListInner;
												if (scanListInner.ScanListInnerSection.ScanLstScanListChannel_A7620.ReferencedNode != null)
												{
													num = (short)1840709635;
													num2 = (int)((global::System.IntPtr)num);
													continue;
												}
												break;
											}
											case 1:
												switch (0)
												{
												case 0:
													goto IL_24D;
												}
												continue;
											case 3:
											{
												global::Motorola.MackinawCPS.CoreFeatures.ScanList.ScanListInner scanListInner;
												scanListInner.ScanListInnerSection.ScanLstScanListChannel_A7620.CalculateValidity();
												num = (short)1358757890;
												num2 = (int)((global::System.IntPtr)num);
												continue;
											}
											case 4:
												num = (short)973144069;
												num2 = (int)((global::System.IntPtr)num);
												continue;
											case 5:
												goto IL_31C;
											case 6:
											{
												global::System.Collections.Generic.IEnumerator<global::AcpBusinessLayer.FeatureNode> enumerator;
												if (!enumerator.MoveNext())
												{
													num = (short)1319239684;
													num2 = (int)((global::System.IntPtr)num);
													continue;
												}
												global::Motorola.MackinawCPS.CoreFeatures.ScanList.ScanListInner scanListInner = (global::Motorola.MackinawCPS.CoreFeatures.ScanList.ScanListInner)enumerator.Current;
												num = (short)1986920448;
												num2 = (int)((global::System.IntPtr)num);
												continue;
											}
											}
											IL_2C7:
											num = (short)281018374;
											num2 = (int)((global::System.IntPtr)num);
											continue;
											IL_24D:
											goto IL_2C7;
										}
										IL_31C:
										break;
									}
									finally
									{
										num = (short)1955004416;
										num2 = (int)((global::System.IntPtr)num);
										for (;;)
										{
											global::System.Collections.Generic.IEnumerator<global::AcpBusinessLayer.FeatureNode> enumerator;
											switch (num2)
											{
											case 0:
												switch (0)
												{
												case 0:
													goto IL_353;
												}
												continue;
											case 1:
												goto IL_38B;
											case 2:
												enumerator.Dispose();
												num = (short)1269170177;
												num2 = (int)((global::System.IntPtr)num);
												continue;
											}
											IL_353:
											if (enumerator == null)
											{
												break;
											}
											num = (short)1383596034;
											num2 = (int)((global::System.IntPtr)num);
										}
										IL_38B:;
									}
									goto IL_38E;
								case 1:
									if (!enumerator2.MoveNext())
									{
										num = (short)1615986690;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									scanList = (global::Motorola.MackinawCPS.CoreFeatures.ScanList.ScanList)enumerator2.Current;
									num = (short)1839923205;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 2:
									num = (short)551682055;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 3:
									if (scanListInnerRecset != null)
									{
										num = (short)1740374024;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									break;
								case 4:
									switch (0)
									{
									case 0:
										goto IL_106;
									}
									continue;
								case 5:
									if (scanList.General.ScanLstGeneralScanType_A9058.Value != 0)
									{
										num = (short)240648198;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									break;
								case 6:
									num = (short)1942290442;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 7:
									goto IL_3F6;
								case 8:
								{
									global::System.Collections.Generic.IEnumerator<global::AcpBusinessLayer.FeatureNode> enumerator = scanListInnerRecset.GetEnumerator();
									num = (short)1447231488;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 9:
									goto IL_38E;
								case 10:
									if (scanList.General.ScanLstGeneralScanType_A9058.Value != 4)
									{
										num = (short)1004273673;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									break;
								}
								IL_15A:
								num = (short)678952961;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								IL_106:
								goto IL_15A;
								IL_38E:
								scanListInnerRecset = (scanList.ScanListMembers.EmbeddedRecset as global::Motorola.MackinawCPS.CoreFeatures.ScanList.ScanListInnerRecset);
								num = (short)755236867;
								num2 = (int)((global::System.IntPtr)num);
							}
							IL_3F6:
							goto IL_519;
						}
						finally
						{
							num = (short)657784832;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								switch (num2)
								{
								case 0:
									switch (0)
									{
									case 0:
										goto IL_42E;
									}
									continue;
								case 1:
									goto IL_465;
								case 2:
									enumerator2.Dispose();
									goto IL_44E;
								}
								IL_42E:
								if (enumerator2 != null)
								{
									num = (short)617414658;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								goto IL_465;
								IL_44E:
								num = (short)1057030145;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								IL_465:
								num = (short)2021276741;
								short num3 = num;
								num = (short)73808965;
								switch ((num3 == num) ? 1 : 0)
								{
								case 0:
								case 2:
									goto IL_44E;
								default:
									goto IL_499;
								}
							}
							IL_499:
							num = (short)520421376;
							if (num != 0)
							{
							}
						}
						goto IL_4B0;
					}
					goto IL_6C;
					IL_4B0:
					enumerator2 = ((global::Motorola.MackinawCPS.CoreFeatures.ScanList.ScanListRecset)feature).GetEnumerator();
					num = (short)615514116;
					num2 = (int)((global::System.IntPtr)num);
				}
				IL_519:
				num = (short)725680128;
				short num4 = num;
				global::Motorola.MackinawCPS.CoreFeatures.TrunkingSystem.General general;
				return general.TrkSysGeneralSystemType_A9252.Value == 3;
				IL_6C:
				general = (self as global::Motorola.MackinawCPS.CoreFeatures.TrunkingSystem.General);
				feature = global::AcpCommonLib.FeatureManager.GetFeature(2057);
				num = (short)1638400000;
				num2 = (int)((global::System.IntPtr)num);
				goto IL_51;
			}
			}
		}

		// Token: 0x06000BFC RID: 3068 RVA: 0x000C65DC File Offset: 0x000C47DC
		internal static bool ConCoverTypeIsNotInterWACNAndNotNAC(global::AcpCommonLib.IAcpFeatureSection self)
		{
			int num;
			global::AcpBusinessLayer.AcpListField trkSysGeneralCoverageType_A;
			short num2;
			global::Motorola.MackinawCPS.CoreFeatures.TrunkingSystem.ASTRO26 astro;
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
						goto IL_CF;
					case 1:
						if (trkSysGeneralCoverageType_A.Value == 5)
						{
							num2 = (short)724303872;
							short num3 = num2;
							num2 = (short)1061748738;
							num = (int)((global::System.IntPtr)num2);
							continue;
						}
						goto IL_137;
					case 2:
						num2 = (short)1086717957;
						num = (int)((global::System.IntPtr)num2);
						continue;
					case 3:
						num2 = (short)1490944001;
						num = (int)((global::System.IntPtr)num2);
						continue;
					case 4:
						if (trkSysGeneralCoverageType_A.Value != 6)
						{
							num2 = (short)920649731;
							num = (int)((global::System.IntPtr)num2);
							continue;
						}
						goto IL_78;
					case 5:
						if (astro.RefDVRSWide.General.RadErgoWideDigitalVehicularRepeaterSystemDVRSHardwareEnable_A7911.Value)
						{
							num2 = (short)535035904;
							num = (int)((global::System.IntPtr)num2);
							continue;
						}
						goto IL_137;
					}
					goto IL_28;
				}
				IL_78:
				return !astro.TrkSysASTRO25ValidateNACAgainstSystemID_A20608.Value;
				IL_CF:
				goto IL_78;
				IL_137:
				num2 = (short)479408229;
				short num4 = num2;
				num2 = (short)1436692581;
				switch ((num4 == num2) ? 1 : 0)
				{
				case 0:
				case 2:
					goto IL_45;
				default:
					num2 = (short)822149120;
					if (num2 != 0)
					{
					}
					num2 = (short)347537409;
					if (num2 != 0)
					{
					}
					return true;
				}
				break;
			}
			}
			IL_28:
			astro = (self as global::Motorola.MackinawCPS.CoreFeatures.TrunkingSystem.ASTRO26);
			trkSysGeneralCoverageType_A = (self.Parent as global::Motorola.MackinawCPS.CoreFeatures.TrunkingSystem.TrunkingSystem).General.TrkSysGeneralCoverageType_A7782;
			IL_45:
			num2 = (short)1166278660;
			num = (int)((global::System.IntPtr)num2);
			goto IL_0A;
		}

		// Token: 0x06000BFD RID: 3069 RVA: 0x000C6794 File Offset: 0x000C4994
		internal static bool ConTriggerScanChannelOnSystemIDChanged(global::AcpCommonLib.IAcpFeatureSection self)
		{
			short num = (short)700121088;
			int num2 = (int)num;
			switch (num2)
			{
			default:
			{
				switch (0)
				{
				case 0:
					goto IL_42;
				}
				global::AcpCommonLib.IAcpRecordset feature;
				for (;;)
				{
					IL_27:
					global::System.Collections.Generic.IEnumerator<global::AcpBusinessLayer.FeatureNode> enumerator2;
					switch (num2)
					{
					case 0:
					{
						num = (short)338100224;
						short num3 = num;
						num = (short)1530265601;
						if (num != 0)
						{
						}
						goto IL_484;
					}
					case 1:
						num = (short)2073034754;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 2:
						if (feature.Count != 0)
						{
							num = (short)1987182592;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return true;
					case 3:
						if (feature != null)
						{
							num = (short)1844117505;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return true;
					case 4:
						try
						{
							num = (short)1255604230;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								global::Motorola.MackinawCPS.CoreFeatures.ScanList.ScanListInnerRecset scanListInnerRecset;
								global::Motorola.MackinawCPS.CoreFeatures.ScanList.ScanList scanList;
								switch (num2)
								{
								case 0:
									try
									{
										num = (short)250085378;
										num2 = (int)((global::System.IntPtr)num);
										for (;;)
										{
											switch (num2)
											{
											case 0:
											{
												global::System.Collections.Generic.IEnumerator<global::AcpBusinessLayer.FeatureNode> enumerator;
												if (!enumerator.MoveNext())
												{
													num = (short)317784068;
													num2 = (int)((global::System.IntPtr)num);
													continue;
												}
												global::Motorola.MackinawCPS.CoreFeatures.ScanList.ScanListInner scanListInner = (global::Motorola.MackinawCPS.CoreFeatures.ScanList.ScanListInner)enumerator.Current;
												num = (short)2107047942;
												num2 = (int)((global::System.IntPtr)num);
												continue;
											}
											case 1:
												goto IL_338;
											case 2:
											{
												num = (short)224908117;
												short num4 = num;
												num = (short)2083836757;
												switch ((num4 == num) ? 1 : 0)
												{
												case 0:
												case 2:
													goto IL_31D;
												default:
													num = (short)147587072;
													if (num != 0)
													{
													}
													switch (0)
													{
													case 0:
														goto IL_265;
													}
													continue;
												}
												break;
											}
											case 3:
											{
												global::Motorola.MackinawCPS.CoreFeatures.ScanList.ScanListInner scanListInner;
												scanListInner.ScanListInnerSection.ScanLstScanListChannel_A7620.CalculateValidity();
												num = (short)1747451909;
												num2 = (int)((global::System.IntPtr)num);
												continue;
											}
											case 4:
												goto IL_31D;
											case 6:
											{
												global::Motorola.MackinawCPS.CoreFeatures.ScanList.ScanListInner scanListInner;
												if (scanListInner.ScanListInnerSection.ScanLstScanListChannel_A7620.ReferencedNode != null)
												{
													num = (short)848232451;
													num2 = (int)((global::System.IntPtr)num);
													continue;
												}
												break;
											}
											}
											IL_2E2:
											num = (short)1673330688;
											num2 = (int)((global::System.IntPtr)num);
											continue;
											IL_265:
											goto IL_2E2;
											IL_31D:
											num = (short)1703673857;
											num2 = (int)((global::System.IntPtr)num);
										}
										IL_338:
										break;
									}
									finally
									{
										num = (short)1170014208;
										num2 = (int)((global::System.IntPtr)num);
										for (;;)
										{
											global::System.Collections.Generic.IEnumerator<global::AcpBusinessLayer.FeatureNode> enumerator;
											switch (num2)
											{
											case 0:
												switch (0)
												{
												case 0:
													goto IL_36F;
												}
												continue;
											case 1:
												enumerator.Dispose();
												num = (short)769196034;
												num2 = (int)((global::System.IntPtr)num);
												continue;
											case 2:
												goto IL_3A7;
											}
											IL_36F:
											if (enumerator == null)
											{
												break;
											}
											num = (short)1135149057;
											num2 = (int)((global::System.IntPtr)num);
										}
										IL_3A7:;
									}
									goto IL_3AA;
								case 1:
								{
									global::System.Collections.Generic.IEnumerator<global::AcpBusinessLayer.FeatureNode> enumerator = scanListInnerRecset.GetEnumerator();
									num = (short)579141632;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 2:
									if (!enumerator2.MoveNext())
									{
										num = (short)2043150346;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									scanList = (global::Motorola.MackinawCPS.CoreFeatures.ScanList.ScanList)enumerator2.Current;
									num = (short)692125705;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 3:
									if (scanList.General.ScanLstGeneralScanType_A9058.Value != 4)
									{
										num = (short)11730951;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									break;
								case 4:
									goto IL_412;
								case 5:
									if (scanListInnerRecset != null)
									{
										num = (short)1506607105;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									break;
								case 6:
									switch (0)
									{
									case 0:
										goto IL_D6;
									}
									continue;
								case 7:
									goto IL_3AA;
								case 8:
									num = (short)1357971459;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 9:
									if (scanList.General.ScanLstGeneralScanType_A9058.Value != 0)
									{
										num = (short)1394147336;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									break;
								case 10:
									num = (short)27459588;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								IL_129:
								num = (short)942080002;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								IL_D6:
								goto IL_129;
								IL_3AA:
								scanListInnerRecset = (scanList.ScanListMembers.EmbeddedRecset as global::Motorola.MackinawCPS.CoreFeatures.ScanList.ScanListInnerRecset);
								num = (short)966393861;
								num2 = (int)((global::System.IntPtr)num);
							}
							IL_412:
							return true;
						}
						finally
						{
							num = (short)553517056;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								switch (num2)
								{
								case 0:
									switch (0)
									{
									case 0:
										goto IL_449;
									}
									continue;
								case 1:
									enumerator2.Dispose();
									num = (short)830013442;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 2:
									goto IL_481;
								}
								IL_449:
								if (enumerator2 == null)
								{
									break;
								}
								num = (short)1363935233;
								num2 = (int)((global::System.IntPtr)num);
							}
							IL_481:;
						}
						goto IL_484;
					}
					goto IL_42;
					IL_484:
					enumerator2 = ((global::Motorola.MackinawCPS.CoreFeatures.ScanList.ScanListRecset)feature).GetEnumerator();
					num = (short)1420099588;
					num2 = (int)((global::System.IntPtr)num);
				}
				return true;
				IL_42:
				feature = global::AcpCommonLib.FeatureManager.GetFeature(2057);
				num = (short)1449197571;
				num2 = (int)((global::System.IntPtr)num);
				goto IL_27;
			}
			}
		}

		// Token: 0x06000BFE RID: 3070 RVA: 0x000C6D18 File Offset: 0x000C4F18
		internal static bool ConSiteAlsIsEnabledAndCovTypeIsInterWACNAndSysTypeIsA25(global::AcpCommonLib.IAcpFeatureSection self)
		{
			switch (0)
			{
			case 0:
				goto IL_47;
			}
			short num;
			int num2;
			global::Motorola.MackinawCPS.CoreFeatures.TrunkingSystem.TrunkingSystem trunkingSystem;
			for (;;)
			{
				IL_0A:
				num = (short)1686241281;
				if (num != 0)
				{
				}
				switch (num2)
				{
				case 0:
				{
					num = (short)1884613851;
					short num3 = num;
					num = (short)1131211995;
					switch ((num3 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_103;
					default:
						num = (short)949551104;
						if (num != 0)
						{
						}
						if (trunkingSystem.SiteAlias.TrkSysSiteAliasSiteAliasEnable_A9148.Value)
						{
							num = (short)604504065;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return false;
					}
					break;
				}
				case 1:
					goto IL_103;
				case 2:
					if (trunkingSystem.General.TrkSysGeneralSystemType_A9252.Value == 3)
					{
						num = (short)1562247168;
						short num4 = num;
						num = (short)83951619;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					return false;
				case 3:
					goto IL_16D;
				}
				goto IL_47;
				IL_103:
				num = (short)934805506;
				num2 = (int)((global::System.IntPtr)num);
			}
			IL_16D:
			return trunkingSystem.General.TrkSysGeneralCoverageType_A7782.Value != 0;
			IL_47:
			trunkingSystem = (self.ParentRecset.ParentSection.Parent as global::Motorola.MackinawCPS.CoreFeatures.TrunkingSystem.TrunkingSystem);
			num = (short)919928832;
			num2 = (int)((global::System.IntPtr)num);
			goto IL_0A;
		}

		// Token: 0x06000BFF RID: 3071 RVA: 0x000C6E98 File Offset: 0x000C5098
		internal static bool ConTrkSysTypeIsAstro25OrWUIDValidityIsUncheckedIfTypeII(global::AcpCommonLib.IAcpFeatureSection self)
		{
			global::AcpBusinessLayer.AcpField<bool> trkSysASTRO25WUIDValiditySupport_A;
			for (;;)
			{
				IL_00:
				short num = (short)2097217536;
				int num2 = (int)num;
				switch (num2)
				{
				default:
				{
					switch (0)
					{
					case 0:
						goto IL_57;
					}
					global::AcpBusinessLayer.AcpListField trkSysGeneralSystemType_A;
					global::AcpBusinessLayer.AcpListField trkSysGeneralCoverageType_A;
					for (;;)
					{
						IL_28:
						switch (num2)
						{
						case 0:
							if (trkSysGeneralSystemType_A.Value == 2)
							{
								num = (short)335478792;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							return false;
						case 1:
							num = (short)328204289;
							if (num != 0)
							{
							}
							num = (short)913375237;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 2:
							goto IL_22E;
						case 3:
							if (trkSysGeneralSystemType_A.Value == 3)
							{
								num = (short)317980676;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							goto IL_22E;
						case 4:
							num = (short)203096071;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 5:
						{
							num = (short)380768005;
							short num3 = num;
							num = (short)1678774021;
							switch ((num3 == num) ? 1 : 0)
							{
							case 0:
							case 2:
								goto IL_00;
							default:
								num = (short)438304768;
								if (num != 0)
								{
								}
								if (trkSysGeneralCoverageType_A.Value == 6)
								{
									num = (short)523239433;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								goto IL_22E;
							}
							break;
						}
						case 6:
							if (trkSysASTRO25WUIDValiditySupport_A.Value)
							{
								num = (short)1588133890;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							return true;
						case 7:
							if (trkSysGeneralCoverageType_A.Value == 6)
							{
								num = (short)554172417;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							return true;
						case 8:
							goto IL_26D;
						case 9:
							num = (short)1245708294;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						break;
						IL_22E:
						num = (short)1760428032;
						num2 = (int)((global::System.IntPtr)num);
					}
					IL_57:
					global::Motorola.MackinawCPS.CoreFeatures.TrunkingSystem.ASTRO26 astro = self as global::Motorola.MackinawCPS.CoreFeatures.TrunkingSystem.ASTRO26;
					global::Motorola.MackinawCPS.CoreFeatures.TrunkingSystem.TrunkingSystem trunkingSystem = self.Parent as global::Motorola.MackinawCPS.CoreFeatures.TrunkingSystem.TrunkingSystem;
					trkSysASTRO25WUIDValiditySupport_A = astro.TrkSysASTRO25WUIDValiditySupport_A41483;
					trkSysGeneralSystemType_A = trunkingSystem.General.TrkSysGeneralSystemType_A9252;
					trkSysGeneralCoverageType_A = trunkingSystem.General.TrkSysGeneralCoverageType_A7782;
					num = (short)1750138880;
					short num4 = num;
					num = (short)1220345859;
					num2 = (int)((global::System.IntPtr)num);
					goto IL_28;
				}
				}
			}
			return false;
			IL_26D:
			return !trkSysASTRO25WUIDValiditySupport_A.Value;
		}

		// Token: 0x06000C00 RID: 3072 RVA: 0x000C7118 File Offset: 0x000C5318
		internal static bool ConWUIDValidityIsUncheckedAndSysTypeIsTypeII(global::AcpCommonLib.IAcpFeatureSection self)
		{
			short num = (short)1316459106;
			short num2 = num;
			num = (short)1912050274;
			switch ((num2 == num) ? 1 : 0)
			{
			case 0:
			case 2:
				break;
			default:
			{
				num = (short)152764416;
				short num3 = num;
				num = (short)1721565185;
				if (num != 0)
				{
				}
				num = (short)1091043328;
				if (num != 0)
				{
				}
				global::Motorola.MackinawCPS.CoreFeatures.TrunkingSystem.ASTRO26 astro = self as global::Motorola.MackinawCPS.CoreFeatures.TrunkingSystem.ASTRO26;
				if ((self.Parent as global::Motorola.MackinawCPS.CoreFeatures.TrunkingSystem.TrunkingSystem).General.TrkSysGeneralSystemType_A9252.Value != 3)
				{
					return astro.TrkSysASTRO25WUIDValiditySupport_A41483.Value;
				}
				break;
			}
			}
			return true;
		}

		// Token: 0x06000C01 RID: 3073 RVA: 0x000C71F8 File Offset: 0x000C53F8
		public static bool conNonEditableWhenOpenFromRMC(global::AcpCommonLib.IAcpFeatureSection self)
		{
			short num = (short)601352803;
			short num2 = num;
			num = (short)1540024931;
			switch (num2 == num)
			{
			}
			num = (short)1073086464;
			short num3 = num;
			num = (short)1041760257;
			if (num != 0)
			{
			}
			num = (short)1035665408;
			if (num != 0)
			{
			}
			return !global::ConstraintHelper.UtilityMack.IsOpenFromRmcOrInCxfEditingMode;
		}

		// Token: 0x06000C02 RID: 3074 RVA: 0x000C72AC File Offset: 0x000C54AC
		internal static bool ConSiteAlsIsEnabledAndApplicableAndSiteAliseTypeIsSite(global::AcpCommonLib.IAcpFeatureSection self)
		{
			switch (0)
			{
			case 0:
				goto IL_50;
			}
			int num;
			short num2;
			global::AcpBusinessLayer.AcpListField trkSysGeneralCoverageType_A;
			global::Motorola.MackinawCPS.CoreFeatures.TrunkingSystem.SiteAliasInnerSection siteAliasInnerSection;
			for (;;)
			{
				IL_0A:
				switch (num)
				{
				case 0:
					num2 = (short)1934360577;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 1:
					if (trkSysGeneralCoverageType_A.Value != 5)
					{
						num2 = (short)2082537483;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					return true;
				case 2:
				{
					global::AcpBusinessLayer.AcpListField trkSysGeneralSystemType_A;
					if (trkSysGeneralSystemType_A.Value == 3)
					{
						num2 = (short)214237197;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_22B;
				}
				case 3:
					num2 = (short)1904410626;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 4:
				{
					global::AcpBusinessLayer.AcpListField trkSysGeneralSystemType_A;
					if (trkSysGeneralSystemType_A.Value == 2)
					{
						num2 = (short)1368391687;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					return false;
				}
				case 5:
					if (trkSysGeneralCoverageType_A.Value != 7)
					{
						num2 = (short)1969881088;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					return true;
				case 6:
					num2 = (short)530382863;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 7:
					goto IL_262;
				case 8:
					if (trkSysGeneralCoverageType_A.Value != 6)
					{
						num2 = (short)106627082;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					return true;
				case 9:
				{
					num2 = (short)1282206316;
					short num3 = num2;
					num2 = (short)191084;
					switch ((num3 == num2) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_169;
					default:
					{
						num2 = (short)1751056384;
						if (num2 != 0)
						{
						}
						num2 = (short)1211957249;
						if (num2 != 0)
						{
						}
						global::Motorola.MackinawCPS.CoreFeatures.TrunkingSystem.TrunkingSystem trunkingSystem = self.ParentRecset.ParentSection.Parent as global::Motorola.MackinawCPS.CoreFeatures.TrunkingSystem.TrunkingSystem;
						global::AcpBusinessLayer.AcpListField trkSysGeneralSystemType_A = trunkingSystem.General.TrkSysGeneralSystemType_A9252;
						trkSysGeneralCoverageType_A = trunkingSystem.General.TrkSysGeneralCoverageType_A7782;
						if (trunkingSystem.SiteAlias.TrkSysSiteAliasSiteAliasEnable_A9148.Value)
						{
							num2 = (short)954597379;
							num = (int)((global::System.IntPtr)num2);
							continue;
						}
						return false;
					}
					}
					break;
				}
				case 10:
					goto IL_22B;
				case 11:
					num2 = (short)1787101192;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 12:
					if (siteAliasInnerSection.TrkSysSiteAliasSiteAliasType_A41343.Value == 0)
					{
						num2 = (short)1003749382;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_22B;
				case 13:
					num2 = (short)1699414028;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 14:
					num2 = (short)1117323269;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 15:
					if (trkSysGeneralCoverageType_A.Value != 3)
					{
						num2 = (short)1999175694;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					return true;
				}
				goto IL_50;
				IL_22B:
				num2 = (short)189267972;
				num = (int)((global::System.IntPtr)num2);
			}
			IL_169:
			return trkSysGeneralCoverageType_A.Value == 3;
			IL_262:
			goto IL_169;
			IL_50:
			siteAliasInnerSection = (self as global::Motorola.MackinawCPS.CoreFeatures.TrunkingSystem.SiteAliasInnerSection);
			num2 = (short)1734606848;
			short num4 = num2;
			num2 = (short)749666313;
			num = (int)((global::System.IntPtr)num2);
			goto IL_0A;
		}

		// Token: 0x06000C03 RID: 3075 RVA: 0x000C75D8 File Offset: 0x000C57D8
		internal static bool ConIsMutualExclusiveWithInterWACNRoaming(global::AcpCommonLib.IAcpFeatureSection self)
		{
			global::Motorola.MackinawCPS.CoreFeatures.TrunkingSystem.ASTRO26 astro = self as global::Motorola.MackinawCPS.CoreFeatures.TrunkingSystem.ASTRO26;
			global::Motorola.MackinawCPS.CoreFeatures.TrunkingSystem.TrunkingSystem trunkingSystem = self.Parent as global::Motorola.MackinawCPS.CoreFeatures.TrunkingSystem.TrunkingSystem;
			if (!astro.TrkSysASTRO25F2VoiceCapable_A1395.Value)
			{
				short num = (short)840104354;
				short num2 = num;
				num = (short)1861220770;
				switch ((num2 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					break;
				default:
				{
					num = (short)1420099585;
					if (num != 0)
					{
					}
					num = (short)1183514624;
					if (num != 0)
					{
					}
					num = (short)1203372032;
					short num3 = num;
					return true;
				}
				}
			}
			return trunkingSystem.General.TrkSysGeneralCoverageType_A7782.Value != 6;
		}

		// Token: 0x06000C04 RID: 3076 RVA: 0x000C76BC File Offset: 0x000C58BC
		internal static bool ConDVRSIsEnAndTrkHearClearValid(global::AcpCommonLib.IAcpFeatureSection self, int index)
		{
			if (!(self as global::Motorola.MackinawCPS.CoreFeatures.TrunkingSystem.Features).RefDVRSWide.General.RadErgoWideDigitalVehicularRepeaterSystemDVRSHardwareEnable_A7911.Value)
			{
				short num = (short)2019173443;
				short num2 = num;
				num = (short)1067328579;
				switch ((num2 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					break;
				default:
				{
					num = (short)650969089;
					if (num != 0)
					{
					}
					num = (short)1581514752;
					if (num != 0)
					{
					}
					num = (short)1667825664;
					short num3 = num;
					return true;
				}
				}
			}
			return index == 0;
		}

		// Token: 0x06000C05 RID: 3077 RVA: 0x000C7788 File Offset: 0x000C5988
		internal static bool ConDVRSIsEnAndTrkHearClearApp(global::AcpCommonLib.IAcpFeatureSection self)
		{
			switch (0)
			{
			case 0:
				goto IL_20;
			}
			int num;
			global::Motorola.MackinawCPS.CoreFeatures.TrunkingSystem.Features features;
			short num2;
			for (;;)
			{
				IL_0A:
				switch (num)
				{
				case 0:
					goto IL_167;
				case 1:
					if (features.RefDVRSWide.General.RadErgoWideDigitalVehicularRepeaterSystemDVRSHardwareEnable_A7911.Value)
					{
						num2 = (short)543686656;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					return true;
				case 2:
					goto IL_10F;
				case 3:
				{
					num2 = (short)1348624637;
					short num3 = num2;
					num2 = (short)624386301;
					switch ((num3 == num2) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_10F;
					case 1:
						break;
					default:
					{
						num2 = (short)2088763392;
						short num4 = num2;
						break;
					}
					}
					num2 = (short)2002714624;
					if (num2 != 0)
					{
					}
					if ((self.Parent as global::Motorola.MackinawCPS.CoreFeatures.TrunkingSystem.TrunkingSystem).General.TrkSysGeneralSystemType_A9252.Value != 3)
					{
						num2 = (short)287703042;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					return false;
				}
				}
				goto IL_20;
				IL_10F:
				num2 = (short)1589772289;
				num = (int)((global::System.IntPtr)num2);
			}
			return true;
			IL_167:
			return features.TrkSysFeaturesHearClear_A36422.Value != 0;
			IL_20:
			num2 = (short)406978561;
			if (num2 != 0)
			{
			}
			features = (self as global::Motorola.MackinawCPS.CoreFeatures.TrunkingSystem.Features);
			num2 = (short)1669464067;
			num = (int)((global::System.IntPtr)num2);
			goto IL_0A;
		}

		// Token: 0x06000C06 RID: 3078 RVA: 0x000C7900 File Offset: 0x000C5B00
		public static bool ConInvisibleWhenOpenfromRMC(global::AcpCommonLib.IAcpFeatureSection self)
		{
			short num = (short)381201961;
			short num2 = num;
			num = (short)1168223785;
			switch (num2 == num)
			{
			}
			num = (short)1142882305;
			if (num != 0)
			{
			}
			num = (short)1648230400;
			if (num != 0)
			{
			}
			num = (short)365756416;
			short num3 = num;
			return !global::ConstraintHelper.UtilityMack.IsOpenFromRmcOrInCxfEditingMode;
		}

		// Token: 0x06000C07 RID: 3079 RVA: 0x000C79B4 File Offset: 0x000C5BB4
		internal static bool ConDVRSIsEnAndWUIDValSupApp(global::AcpCommonLib.IAcpFeatureSection self)
		{
			short num = (short)1556636433;
			short num2 = num;
			num = (short)139289361;
			switch (num2 == num)
			{
			}
			num = (short)834142208;
			if (num != 0)
			{
			}
			num = (short)1294270465;
			if (num != 0)
			{
			}
			num = (short)555483136;
			short num3 = num;
			return (self as global::Motorola.MackinawCPS.CoreFeatures.TrunkingSystem.ASTRO26).RefDVRSWide.General.RadErgoWideDigitalVehicularRepeaterSystemDVRSHardwareEnable_A7911.Applicable;
		}

		// Token: 0x06000C08 RID: 3080 RVA: 0x000C7A78 File Offset: 0x000C5C78
		internal static bool ConTrkSysTypeIsAstro25_2(global::AcpCommonLib.IAcpFeatureSection self)
		{
			short num = (short)1323012420;
			short num2 = num;
			num = (short)628068676;
			switch (num2 == num)
			{
			}
			num = (short)1430519809;
			if (num != 0)
			{
			}
			num = (short)1935867904;
			if (num != 0)
			{
			}
			num = (short)430964736;
			short num3 = num;
			return (self.Parent as global::Motorola.MackinawCPS.CoreFeatures.TrunkingSystem.TrunkingSystem).General.TrkSysGeneralSystemType_A9252.Value == 3;
		}

		// Token: 0x06000C09 RID: 3081 RVA: 0x000C7B3C File Offset: 0x000C5D3C
		internal static bool ConNOTTrkSysCoverageTypeNotDisableAndSiteAliasDisable(global::AcpCommonLib.IAcpFeatureSection self, int index)
		{
			short num = (short)1193869313;
			if (num != 0)
			{
			}
			switch (0)
			{
			case 0:
				goto IL_4E;
			}
			int num2;
			global::Motorola.MackinawCPS.CoreFeatures.TrunkingSystem.TrunkingSystem trunkingSystem;
			for (;;)
			{
				IL_30:
				switch (num2)
				{
				case 0:
					goto IL_D7;
				case 1:
				{
					num = (short)1321672416;
					short num3 = num;
					num = (short)262282976;
					switch ((num3 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_D7;
					default:
						goto IL_BD;
					}
					break;
				}
				case 2:
					return false;
				case 3:
					if (trunkingSystem.General.TrkSysGeneralCoverageType_A7782.Value != 0)
					{
						num = (short)71892992;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					return true;
				case 4:
					if (!trunkingSystem.SiteAlias.TrkSysSiteAliasSiteAliasEnable_A9148.Value)
					{
						num = (short)1358692354;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					return true;
				case 5:
				{
					if (index == 0)
					{
						num = (short)1070071809;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					num = (short)1110114304;
					short num4 = num;
					num = (short)1294532611;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				}
				goto IL_4E;
				IL_D7:
				num = (short)1714487300;
				num2 = (int)((global::System.IntPtr)num);
			}
			IL_BD:
			num = (short)1884815360;
			if (num != 0)
			{
			}
			return true;
			IL_4E:
			trunkingSystem = (self.Parent as global::Motorola.MackinawCPS.CoreFeatures.TrunkingSystem.TrunkingSystem);
			num = (short)1293811717;
			num2 = (int)((global::System.IntPtr)num);
			goto IL_30;
		}

		// Token: 0x06000C0A RID: 3082 RVA: 0x000C7CDC File Offset: 0x000C5EDC
		internal static void conSetTgrpAliasTxtRecRef(global::AcpCommonLib.IAcpFeatureSection self, global::AcpCommonLib.UndoRedo.ContainerTask task)
		{
			short num = (short)1360134145;
			if (num != 0)
			{
			}
			num = (short)925354958;
			short num2 = num;
			num = (short)104713166;
			switch (num2 == num)
			{
			}
			num = (short)328794112;
			if (num != 0)
			{
			}
			num = (short)1593442304;
			short num3 = num;
			global::Motorola.MackinawCPS.CoreFeatures.TrunkingSystem.Features features = self as global::Motorola.MackinawCPS.CoreFeatures.TrunkingSystem.Features;
			task.AddTask(new global::AcpBusinessLayer.UndoRedo.ModifyRecRefDataTask(features.SiteSelectableAlertAliasList_A42100, features.SiteSelectableAlertList_A42060.UIValue));
		}

		// Token: 0x06000C0B RID: 3083 RVA: 0x000C7DAC File Offset: 0x000C5FAC
		public static bool ConValidConstraintForKMFProfileIndex(global::AcpCommonLib.IAcpFeatureSection self, int indexOfOtarProfile)
		{
			short num = (short)381353984;
			int num2 = (int)num;
			switch (num2)
			{
			default:
			{
				switch (0)
				{
				case 0:
					goto IL_AE;
				}
				int num3;
				global::AcpCommonLib.IAcpRecordset feature;
				for (;;)
				{
					IL_27:
					global::Motorola.MackinawCPS.CoreFeatures.DataProfiles.DataProfiles dataProfiles;
					switch (num2)
					{
					case 0:
					{
						if (num3 >= feature.Count)
						{
							num = (short)129564697;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)951648257;
						if (num != 0)
						{
						}
						(feature[num3][10178] as global::Motorola.MackinawCPS.CoreFeatures.TrunkingPersonality.General).TrkEmerProfGeneralKeySelect_A8970.CalculateApplicability();
						(feature[num3][10178] as global::Motorola.MackinawCPS.CoreFeatures.TrunkingPersonality.General).TrkEmerProfGeneralKeySelect_A8970.CalculateValidity();
						(feature[num3][10176] as global::Motorola.MackinawCPS.CoreFeatures.TrunkingPersonality.AnnouncementGroup).TrkPerAnnouncementGroupAGKeySelect_A7414.CalculateApplicability();
						(feature[num3][10176] as global::Motorola.MackinawCPS.CoreFeatures.TrunkingPersonality.AnnouncementGroup).TrkPerAnnouncementGroupAGKeySelect_A7414.CalculateValidity();
						int num4 = 0;
						num = (short)1299709972;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 1:
					{
						global::Motorola.MackinawCPS.CoreFeatures.SecureKMFProfile.SecureKMFProfile secureKMFProfile;
						if (secureKMFProfile != null)
						{
							num = (short)1883766788;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return true;
					}
					case 2:
						goto IL_198;
					case 3:
						num = (short)894173190;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 4:
						num = (short)757989391;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 5:
					{
						global::Motorola.MackinawCPS.CoreFeatures.SecureKMFProfile.SecureKMFProfile secureKMFProfile;
						if (secureKMFProfile.DataTransport.SecKmfProfDataTransportOTARTransport.Value != 1)
						{
							num = (short)1041367056;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_1DB;
					}
					case 6:
						if (dataProfiles.General.DataProfGeneralDataProfileType_A21320.Value != 1)
						{
							num = (short)1832321051;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_563;
					case 7:
						goto IL_198;
					case 8:
						num = (short)475070469;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 9:
						return true;
					case 10:
					{
						global::Motorola.MackinawCPS.CoreFeatures.SecureKMFProfile.SecureKMFProfile secureKMFProfile;
						if (secureKMFProfile != null)
						{
							num = (short)2033909781;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_1DB;
					}
					case 11:
						goto IL_5F1;
					case 12:
					{
						num = (short)2027800057;
						short num5 = num;
						num = (short)1626785273;
						switch ((num5 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_5F1;
						default:
							num = (short)698548224;
							if (num != 0)
							{
							}
							num3++;
							num = (short)1571880967;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						break;
					}
					case 13:
						if (dataProfiles.General.DataProfGeneralDataProfileType_A21320.Value != 4)
						{
							num = (short)642121759;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_563;
					case 14:
						goto IL_225;
					case 15:
					{
						global::Motorola.MackinawCPS.CoreFeatures.SecureKMFProfile.SecureKMFProfile secureKMFProfile;
						if (secureKMFProfile.DataTransport.SecKmfProfDataTransportOTARTransport.Value != 1)
						{
							num = (short)360120342;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return true;
					}
					case 16:
						return false;
					case 17:
						goto IL_563;
					case 18:
						if (dataProfiles.General.DataProfGeneralDataProfileType_A21320.Value == 2)
						{
							num = (short)1158283281;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_1DB;
					case 19:
					{
						int num4;
						if (num4 >= (feature[num3][10179] as global::Motorola.MackinawCPS.CoreFeatures.TrunkingPersonality.Talkgroup).EmbeddedRecset.Count)
						{
							num = (short)822542348;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						((feature[num3][10179] as global::Motorola.MackinawCPS.CoreFeatures.TrunkingPersonality.Talkgroup).EmbeddedRecset[num4][10180] as global::Motorola.MackinawCPS.CoreFeatures.TrunkingPersonality.TalkgroupInnerSection).TrkPerTalkgroupKeySelect_A8365.CalculateApplicability();
						((feature[num3][10179] as global::Motorola.MackinawCPS.CoreFeatures.TrunkingPersonality.Talkgroup).EmbeddedRecset[num4][10180] as global::Motorola.MackinawCPS.CoreFeatures.TrunkingPersonality.TalkgroupInnerSection).TrkPerTalkgroupKeySelect_A8365.CalculateValidity();
						num4++;
						num = (short)348979214;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 20:
						goto IL_225;
					case 21:
						num = (short)379387927;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 22:
						return false;
					case 23:
					{
						global::Motorola.MackinawCPS.CoreFeatures.SecureKMFProfile.SecureKMFProfile secureKMFProfile;
						if (secureKMFProfile.DataTransport.SecKmfProfDataTransportKMFIPAddress_A8375.Value == 0L)
						{
							num = (short)356384776;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_1DB;
					}
					case 24:
					{
						global::Motorola.MackinawCPS.CoreFeatures.TrunkingSystem.TrunkingSystem trunkingSystem;
						if (trunkingSystem.General.TrkSysGeneralDataProfileSelection_A19449.Value == 0)
						{
							num = (short)950599706;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return true;
					}
					case 25:
						num = (short)1435631646;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 26:
						num = (short)780599297;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 27:
						num = (short)1713176589;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 28:
						return false;
					case 29:
					{
						if (indexOfOtarProfile < 0)
						{
							num = (short)750518300;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						global::Motorola.MackinawCPS.CoreFeatures.TrunkingSystem.TrunkingSystem trunkingSystem = self.Parent as global::Motorola.MackinawCPS.CoreFeatures.TrunkingSystem.TrunkingSystem;
						global::Motorola.MackinawCPS.CoreFeatures.SecureKMFProfile.SecureKMFProfile secureKMFProfile = global::AcpCommonLib.FeatureManager.GetFeature(2055)[indexOfOtarProfile - 1] as global::Motorola.MackinawCPS.CoreFeatures.SecureKMFProfile.SecureKMFProfile;
						dataProfiles = (trunkingSystem.General.TrkSysGeneralDataProfileSelection_A19449.ReferencedNode as global::Motorola.MackinawCPS.CoreFeatures.DataProfiles.DataProfiles);
						num = (short)1986396171;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 30:
						if (indexOfOtarProfile == 0)
						{
							num = (short)1289814025;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)390201373;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 31:
					{
						num = (short)911736832;
						short num6 = num;
						num = (short)1743126546;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					}
					goto IL_AE;
					IL_198:
					num = (short)647823360;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_1DB:
					num = (short)388890648;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_5F1:
					if (dataProfiles != null)
					{
						num = (short)1335689219;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_1DB;
					IL_225:
					num = (short)907477011;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_563:
					num = (short)462094346;
					num2 = (int)((global::System.IntPtr)num);
				}
				return false;
				IL_AE:
				feature = global::AcpCommonLib.FeatureManager.GetFeature(2072);
				num3 = 0;
				num = (short)1489633282;
				num2 = (int)((global::System.IntPtr)num);
				goto IL_27;
			}
			}
		}

		// Token: 0x06000C0C RID: 3084 RVA: 0x000C84B8 File Offset: 0x000C66B8
		public static bool ConTrkKMFProfileIndexAvailable(global::AcpCommonLib.IAcpFeatureSection self)
		{
			short num = (short)223412224;
			int num2 = (int)num;
			switch (num2)
			{
			default:
			{
				switch (0)
				{
				case 0:
					goto IL_86;
				}
				global::Motorola.MackinawCPS.CoreFeatures.TrunkingSystem.TrunkingSystem trunkingSystem;
				global::Motorola.MackinawCPS.CoreFeatures.TrunkingSystem.SecureMultikey secureMultikey;
				bool flag;
				global::AcpBusinessLayer.AcpListField secWideGeneralSecureOperation_A;
				for (;;)
				{
					IL_27:
					global::AcpBusinessLayer.AcpRecRefField trkSysSecureMultikeyKMFProfileIndex_A;
					bool flag2;
					switch (num2)
					{
					case 0:
						num = (short)1123090452;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 1:
					{
						global::Motorola.MackinawCPS.CoreFeatures.SecureKMFProfile.SecureKMFProfile a_ = trkSysSecureMultikeyKMFProfileIndex_A.ReferencedNode as global::Motorola.MackinawCPS.CoreFeatures.SecureKMFProfile.SecureKMFProfile;
						global::Motorola.MackinawCPS.CoreFeatures.TrunkingSystem.TrunkingSystemConstraints.a(trunkingSystem, secureMultikey, a_, flag);
						num = (short)760676367;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 2:
						num = (short)2101739532;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 3:
						num = (short)1055260690;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 4:
						if (secureMultikey.RefSecureWide.ASTROOTAR.SecWideASTROOTARASTROOTAREnable_A7496.Value)
						{
							num = (short)423297035;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_336;
					case 5:
						return flag;
					case 6:
						if (secWideGeneralSecureOperation_A.Value != 1)
						{
							num = (short)883163138;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_1A4;
					case 7:
						if (trkSysSecureMultikeyKMFProfileIndex_A != null)
						{
							num = (short)65536000;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return flag;
					case 8:
						goto IL_1A4;
					case 9:
						if (secureMultikey.RefSecureWide.General.SecureWideAESAlgorithmEnable_43201.Value)
						{
							num = (short)717684744;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_336;
					case 10:
						flag2 = secureMultikey.RefSecureWide.General.SecWideGeneralOTAREnable_A7966.Value;
						goto IL_2F4;
					case 11:
						num = (short)1947074570;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 12:
						if (secWideGeneralSecureOperation_A.Value == 3)
						{
							num = (short)2002780179;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_336;
					case 13:
						goto IL_34F;
					case 14:
						if (trkSysSecureMultikeyKMFProfileIndex_A != null)
						{
							num = (short)503382019;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_2B7;
					case 15:
						return flag;
					case 16:
						num = (short)823394308;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 17:
					{
						num = (short)27066767;
						short num3 = num;
						num = (short)528875919;
						switch ((num3 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_34F;
						default:
							num = (short)1841889280;
							if (num != 0)
							{
							}
							if (trunkingSystem.General.TrkSysGeneralSystemType_A9252.Value == 3)
							{
								num = (short)1339752464;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							goto IL_336;
						}
						break;
					}
					case 18:
						if (trkSysSecureMultikeyKMFProfileIndex_A.ReferencedNode != null)
						{
							num = (short)774504449;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_2B7;
					case 19:
						num = (short)1846280201;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 20:
						if (trkSysSecureMultikeyKMFProfileIndex_A.Value == 0)
						{
							num = (short)190251029;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return flag;
					case 21:
						num = (short)1702428673;
						if (num != 0)
						{
						}
						global::Motorola.MackinawCPS.CoreFeatures.TrunkingSystem.TrunkingSystemConstraints.a(trunkingSystem, secureMultikey, null, flag);
						num = (short)1602355205;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_86;
					IL_1A4:
					num = (short)1695285265;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_2B7:
					num = (short)764674055;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_2F4:
					flag = flag2;
					trkSysSecureMultikeyKMFProfileIndex_A = secureMultikey.TrkSysSecureMultikeyKMFProfileIndex_A8382;
					num = (short)911147022;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_34F:
					flag2 = false;
					goto IL_2F4;
					IL_336:
					num = (short)1849229325;
					num2 = (int)((global::System.IntPtr)num);
				}
				return flag;
				IL_86:
				secureMultikey = (self as global::Motorola.MackinawCPS.CoreFeatures.TrunkingSystem.SecureMultikey);
				trunkingSystem = (self.Parent as global::Motorola.MackinawCPS.CoreFeatures.TrunkingSystem.TrunkingSystem);
				secWideGeneralSecureOperation_A = secureMultikey.RefSecureWide.General.SecWideGeneralSecureOperation_A9067;
				num = (short)37421056;
				short num4 = num;
				num = (short)1547698182;
				num2 = (int)((global::System.IntPtr)num);
				goto IL_27;
			}
			}
		}

		// Token: 0x06000C0D RID: 3085 RVA: 0x000C8920 File Offset: 0x000C6B20
		public static void ConSetValueAstroOTAR(global::AcpCommonLib.IAcpFeatureSection self, global::AcpCommonLib.UndoRedo.ContainerTask task)
		{
			switch (0)
			{
			case 0:
				goto IL_24;
			}
			int num;
			short num2;
			global::AcpBusinessLayer.AcpRecRefField trkSysSecureMultikeyKMFProfileIndex_A;
			global::AcpBusinessLayer.AcpField<bool> trkSysSecureMultikeyASTROOTAR_A;
			for (;;)
			{
				IL_0A:
				switch (num)
				{
				case 0:
					return;
				case 1:
					num2 = (short)698613761;
					if (num2 != 0)
					{
					}
					num2 = (short)1215234051;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 2:
				{
					if (trkSysSecureMultikeyKMFProfileIndex_A == null)
					{
						return;
					}
					num2 = (short)1136060924;
					short num3 = num2;
					num2 = (short)599190012;
					switch ((num3 == num2) ? 1 : 0)
					{
					case 0:
					case 2:
						continue;
					default:
						num2 = (short)1152122880;
						if (num2 != 0)
						{
						}
						num2 = (short)569180161;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					break;
				}
				case 3:
					if (trkSysSecureMultikeyASTROOTAR_A != null)
					{
						num2 = (short)1268252676;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					return;
				case 4:
					trkSysSecureMultikeyASTROOTAR_A.Value = (trkSysSecureMultikeyKMFProfileIndex_A.Value > 0);
					num2 = (short)1292435456;
					num = (int)((global::System.IntPtr)num2);
					continue;
				}
				goto IL_24;
			}
			return;
			IL_24:
			num2 = (short)1276510208;
			short num4 = num2;
			global::Motorola.MackinawCPS.CoreFeatures.TrunkingSystem.SecureMultikey secureMultikey = self as global::Motorola.MackinawCPS.CoreFeatures.TrunkingSystem.SecureMultikey;
			trkSysSecureMultikeyKMFProfileIndex_A = secureMultikey.TrkSysSecureMultikeyKMFProfileIndex_A8382;
			trkSysSecureMultikeyASTROOTAR_A = secureMultikey.TrkSysSecureMultikeyASTROOTAR_A7494;
			num2 = (short)1353252866;
			num = (int)((global::System.IntPtr)num2);
			goto IL_0A;
		}

		// Token: 0x06000C0E RID: 3086 RVA: 0x000C8A94 File Offset: 0x000C6C94
		internal static void ConSetTrkLTEInterferenceFreqAllow(global::AcpCommonLib.IAcpFeatureSection self, global::AcpCommonLib.UndoRedo.ContainerTask task)
		{
			short num = (short)1964113920;
			int num2 = (int)num;
			switch (num2)
			{
			default:
			{
				switch (0)
				{
				case 0:
					goto IL_4B;
				}
				global::Motorola.MackinawCPS.CoreFeatures.TrunkingSystem.TrunkingSystem trunkingSystem;
				bool flag;
				for (;;)
				{
					IL_28:
					global::System.Collections.Generic.IEnumerator<global::AcpBusinessLayer.FeatureNode> enumerator;
					switch (num2)
					{
					case 0:
						goto IL_113;
					case 1:
						if (!(global::AcpCommonLib.FeatureManager.GetFeature(2049)[0] as global::Motorola.MackinawCPS.CoreFeatures.RadioInformation.RadioInformation).Labtool.RadInfoLabtoolLTEOperation_A41923.Value)
						{
							num = (short)1564016644;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						enumerator = (trunkingSystem[10160].EmbeddedRecset as global::Motorola.MackinawCPS.CoreFeatures.TrunkingSystem.ASTRO25ChannelIDInnerRecset).GetEnumerator();
						num = (short)107675650;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 2:
						try
						{
							num = (short)1571946501;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								switch (num2)
								{
								case 0:
									goto IL_97A;
								case 1:
								{
									global::Motorola.MackinawCPS.CoreFeatures.TrunkingSystem.ASTRO25ChannelIDInnerSection astro25ChannelIDInnerSection;
									if (!astro25ChannelIDInnerSection.TrkSysASTRO25ChannelIDIdentifierEnable_A8222.Value)
									{
										num = (short)1181483012;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									goto IL_8E0;
								}
								case 2:
								{
									global::Motorola.MackinawCPS.CoreFeatures.TrunkingSystem.ASTRO25ChannelIDInnerSection astro25ChannelIDInnerSection;
									if (!global::ConstraintHelper.UtilityMack.IsNextTo700MHzRxFrequency(astro25ChannelIDInnerSection.TrkSysASTRO25ChannelIDBaseFrequencyMHz_A7546.Value, astro25ChannelIDInnerSection.TrkSysASTRO25ChannelIDChannelSpacingkHz_A7660.Value))
									{
										num = (short)1071054851;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									goto IL_97A;
								}
								case 3:
									goto IL_8E0;
								case 4:
									num = (short)1335623682;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 5:
									switch (0)
									{
									case 0:
										goto IL_8DB;
									}
									continue;
								case 6:
									if (trunkingSystem.General.TrkSysGeneralCoverageType_A7782.Value == 6)
									{
										num = (short)691339264;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									break;
								case 7:
									goto IL_A47;
								case 8:
								{
									if (!enumerator.MoveNext())
									{
										num = (short)227082249;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									global::Motorola.MackinawCPS.CoreFeatures.TrunkingSystem.ASTRO25ChannelIDInnerSection astro25ChannelIDInnerSection = ((global::AcpCommonLib.IAcpFeatureNode)enumerator.Current)[10161] as global::Motorola.MackinawCPS.CoreFeatures.TrunkingSystem.ASTRO25ChannelIDInnerSection;
									num = (short)390266881;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 9:
									num = (short)1336606727;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 10:
									goto IL_995;
								}
								goto IL_8DB;
								IL_8E0:
								num = (short)1848180742;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								IL_97A:
								flag = true;
								num = (short)1117913098;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								IL_9F0:
								num = (short)500760584;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								IL_8DB:
								goto IL_9F0;
							}
							IL_995:
							IL_A47:
							goto IL_146;
						}
						finally
						{
							num = (short)1534459904;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								switch (num2)
								{
								case 0:
									switch (0)
									{
									case 0:
										goto IL_A7E;
									}
									continue;
								case 1:
									goto IL_AB4;
								case 2:
									enumerator.Dispose();
									num = (short)847642625;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								IL_A7E:
								if (enumerator == null)
								{
									break;
								}
								num = (short)284295170;
								num2 = (int)((global::System.IntPtr)num);
							}
							IL_AB4:;
						}
						return;
						IL_146:
						num = (short)1571028997;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 3:
						task.AddTask(new global::AcpBusinessLayer.UndoRedo.ModifyDataTask<bool>(trunkingSystem.ASTRO25ChannelID.TrkSysLTEInterferingFreqPresent_A42198, flag));
						num = (short)754843648;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 4:
						goto IL_E7;
					case 5:
						if (flag != trunkingSystem.ASTRO25ChannelID.TrkSysLTEInterferingFreqPresent_A42198.Value)
						{
							num = (short)1031929859;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_113;
					case 6:
						goto IL_141;
					}
					goto IL_4B;
					IL_113:
					enumerator = (global::AcpCommonLib.FeatureManager.GetFeature(2057) as global::Motorola.MackinawCPS.CoreFeatures.ScanList.ScanListRecset).GetEnumerator();
					num = (short)290258950;
					num2 = (int)((global::System.IntPtr)num);
				}
				IL_E7:
				num = (short)595197953;
				if (num != 0)
				{
				}
				return;
				IL_141:
				try
				{
					num = (short)897384450;
					num2 = (int)((global::System.IntPtr)num);
					for (;;)
					{
						IL_1E8:
						switch (num2)
						{
						case 0:
							goto IL_604;
						case 1:
							num = (short)1851129862;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 2:
							switch (0)
							{
							case 0:
								goto IL_213;
							}
							continue;
						case 4:
						{
							global::Motorola.MackinawCPS.CoreFeatures.ScanList.ScanList scanList;
							bool flag2;
							task.AddTask(new global::AcpBusinessLayer.UndoRedo.ModifyDataTask<bool>(scanList.Labtool.ScanLstLabtoolLTEInterferingFreqPresent_A42197, flag2));
							num = (short)1800273923;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						case 5:
						{
							global::Motorola.MackinawCPS.CoreFeatures.ScanList.ScanList scanList;
							bool flag2;
							if (flag2 != scanList.Labtool.ScanLstLabtoolLTEInterferingFreqPresent_A42197.Value)
							{
								num = (short)671350788;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							break;
						}
						case 6:
							goto IL_7E1;
						case 7:
						{
							global::System.Collections.Generic.IEnumerator<global::AcpBusinessLayer.FeatureNode> enumerator2;
							try
							{
								num = (short)1770782726;
								num2 = (int)((global::System.IntPtr)num);
								for (;;)
								{
									switch (num2)
									{
									case 0:
									{
										global::Motorola.MackinawCPS.CoreFeatures.TrunkingPersonality.TrunkingPersonality trunkingPersonality;
										if (trunkingPersonality != null)
										{
											num = (short)382664705;
											num2 = (int)((global::System.IntPtr)num);
											continue;
										}
										break;
									}
									case 1:
										num = (short)1179516933;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									case 2:
										num = (short)1257570314;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									case 3:
									{
										global::Motorola.MackinawCPS.CoreFeatures.ZoneChannelAssignment.ChannelAssignmentListInner channelAssignmentListInner;
										if (channelAssignmentListInner != null)
										{
											num = (short)661979147;
											num2 = (int)((global::System.IntPtr)num);
											continue;
										}
										break;
									}
									case 4:
									{
										global::Motorola.MackinawCPS.CoreFeatures.ScanList.ScanListInner scanListInner;
										task.AddTask(new global::AcpBusinessLayer.UndoRedo.ModifyDataTask<bool>(scanListInner.ScanListInnerSection.ScanLstScanListLTEInterferingFreqPresent_A42196, flag));
										num = (short)1283457032;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									case 5:
									{
										global::Motorola.MackinawCPS.CoreFeatures.TrunkingPersonality.TrunkingPersonality trunkingPersonality;
										if (trunkingPersonality.General.TrkPerGeneralSystem_A9237.ReferencedNode as global::Motorola.MackinawCPS.CoreFeatures.TrunkingSystem.TrunkingSystem == self.Parent.Parent.ParentSection.Parent)
										{
											num = (short)906166276;
											num2 = (int)((global::System.IntPtr)num);
											continue;
										}
										break;
									}
									case 6:
										switch (0)
										{
										case 0:
											goto IL_39B;
										}
										continue;
									case 7:
									{
										global::Motorola.MackinawCPS.CoreFeatures.ZoneChannelAssignment.ChannelAssignmentListInner channelAssignmentListInner;
										if (channelAssignmentListInner.ChannelAssignmentListInnerSection.ZnChanCfgChannelsChannelType_A22241.Value == 1)
										{
											num = (short)725876748;
											num2 = (int)((global::System.IntPtr)num);
											continue;
										}
										break;
									}
									case 9:
									{
										if (!enumerator2.MoveNext())
										{
											num = (short)579469314;
											num2 = (int)((global::System.IntPtr)num);
											continue;
										}
										global::Motorola.MackinawCPS.CoreFeatures.ScanList.ScanListInner scanListInner = (global::Motorola.MackinawCPS.CoreFeatures.ScanList.ScanListInner)enumerator2.Current;
										global::Motorola.MackinawCPS.CoreFeatures.ZoneChannelAssignment.ChannelAssignmentListInner channelAssignmentListInner = scanListInner.ScanListInnerSection.ScanLstScanListChannel_A7620.ReferencedNode as global::Motorola.MackinawCPS.CoreFeatures.ZoneChannelAssignment.ChannelAssignmentListInner;
										num = (short)717357059;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									case 10:
										goto IL_591;
									case 11:
										num = (short)1808465927;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									case 12:
									{
										global::Motorola.MackinawCPS.CoreFeatures.ZoneChannelAssignment.ChannelAssignmentListInner channelAssignmentListInner;
										global::Motorola.MackinawCPS.CoreFeatures.TrunkingPersonality.TrunkingPersonality trunkingPersonality = channelAssignmentListInner.ChannelAssignmentListInnerSection.ZnChanCfgChannelsPersonality_A8698.ReferencedNode as global::Motorola.MackinawCPS.CoreFeatures.TrunkingPersonality.TrunkingPersonality;
										num = (short)1633681408;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									}
									IL_53A:
									num = (short)1341063177;
									num2 = (int)((global::System.IntPtr)num);
									continue;
									IL_39B:
									goto IL_53A;
								}
								IL_591:
								goto IL_2D2;
							}
							finally
							{
								num = (short)1697447938;
								num2 = (int)((global::System.IntPtr)num);
								for (;;)
								{
									switch (num2)
									{
									case 0:
										goto IL_601;
									case 1:
										enumerator2.Dispose();
										num = (short)2124021760;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									case 2:
										switch (0)
										{
										case 0:
											goto IL_5C9;
										}
										continue;
									}
									IL_5C9:
									if (enumerator2 == null)
									{
										break;
									}
									num = (short)154599425;
									num2 = (int)((global::System.IntPtr)num);
								}
								IL_601:;
							}
							goto Block_7;
							IL_2D2:
							global::Motorola.MackinawCPS.CoreFeatures.ScanList.ScanListInnerRecset scanListInnerRecset;
							enumerator2 = scanListInnerRecset.GetEnumerator();
							num = (short)470417408;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						case 8:
						{
							global::System.Collections.Generic.IEnumerator<global::AcpBusinessLayer.FeatureNode> enumerator;
							while (!enumerator.MoveNext())
							{
								num = (short)1530984891;
								short num3 = num;
								num = (short)703199675;
								switch ((num3 == num) ? 1 : 0)
								{
								case 0:
								case 2:
									break;
								default:
									num = (short)391708672;
									if (num != 0)
									{
									}
									num = (short)292028417;
									num2 = (int)((global::System.IntPtr)num);
									goto IL_1E8;
								}
							}
							global::Motorola.MackinawCPS.CoreFeatures.ScanList.ScanList scanList = (global::Motorola.MackinawCPS.CoreFeatures.ScanList.ScanList)enumerator.Current;
							global::Motorola.MackinawCPS.CoreFeatures.ScanList.ScanListInnerRecset scanListInnerRecset = scanList.ScanListMembers.EmbeddedRecset as global::Motorola.MackinawCPS.CoreFeatures.ScanList.ScanListInnerRecset;
							bool flag2 = false;
							global::System.Collections.Generic.IEnumerator<global::AcpBusinessLayer.FeatureNode> enumerator2 = scanListInnerRecset.GetEnumerator();
							num = (short)1235353607;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						}
						IL_249:
						num = (short)1516699656;
						num2 = (int)((global::System.IntPtr)num);
						continue;
						IL_213:
						goto IL_249;
						Block_7:
						try
						{
							IL_604:
							num = (short)456916992;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								switch (num2)
								{
								case 0:
									switch (0)
									{
									case 0:
										goto IL_647;
									}
									continue;
								case 1:
									num = (short)1320747011;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 2:
								{
									global::System.Collections.Generic.IEnumerator<global::AcpBusinessLayer.FeatureNode> enumerator2;
									if (((global::Motorola.MackinawCPS.CoreFeatures.ScanList.ScanListInner)enumerator2.Current).ScanListInnerSection.ScanLstScanListLTEInterferingFreqPresent_A42196.Value)
									{
										num = (short)482213892;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									break;
								}
								case 3:
									goto IL_70C;
								case 4:
								{
									bool flag2 = true;
									num = (short)13631493;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 5:
									goto IL_6AE;
								case 6:
								{
									global::System.Collections.Generic.IEnumerator<global::AcpBusinessLayer.FeatureNode> enumerator2;
									if (!enumerator2.MoveNext())
									{
										num = (short)1350107137;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									num = (short)1652097026;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								}
								IL_6B3:
								num = (short)58654726;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								IL_647:
								goto IL_6B3;
							}
							IL_6AE:
							IL_70C:;
						}
						finally
						{
							num = (short)1692467200;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								global::System.Collections.Generic.IEnumerator<global::AcpBusinessLayer.FeatureNode> enumerator2;
								switch (num2)
								{
								case 0:
									switch (0)
									{
									case 0:
										goto IL_740;
									}
									continue;
								case 1:
									enumerator2.Dispose();
									num = (short)1662058498;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 2:
									goto IL_777;
								}
								IL_740:
								if (enumerator2 == null)
								{
									break;
								}
								num = (short)1485832193;
								num2 = (int)((global::System.IntPtr)num);
							}
							IL_777:;
						}
						num = (short)19267589;
						num2 = (int)((global::System.IntPtr)num);
					}
					IL_7E1:
					return;
				}
				finally
				{
					num = (short)1266483200;
					num2 = (int)((global::System.IntPtr)num);
					for (;;)
					{
						global::System.Collections.Generic.IEnumerator<global::AcpBusinessLayer.FeatureNode> enumerator;
						switch (num2)
						{
						case 0:
							switch (0)
							{
							case 0:
								goto IL_819;
							}
							continue;
						case 1:
							goto IL_850;
						case 2:
							enumerator.Dispose();
							num = (short)1028325377;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						IL_819:
						if (enumerator == null)
						{
							break;
						}
						num = (short)1072168962;
						num2 = (int)((global::System.IntPtr)num);
					}
					IL_850:;
				}
				return;
				IL_4B:
				trunkingSystem = (self.Parent.Parent.ParentSection.Parent as global::Motorola.MackinawCPS.CoreFeatures.TrunkingSystem.TrunkingSystem);
				flag = false;
				num = (short)1958805504;
				short num4 = num;
				num = (short)1397555201;
				num2 = (int)((global::System.IntPtr)num);
				goto IL_28;
			}
			}
		}

		// Token: 0x06000C0F RID: 3087 RVA: 0x000C95BC File Offset: 0x000C77BC
		internal static bool ConTrkSysGroupTMSIsEnabled(global::AcpCommonLib.IAcpFeatureSection self)
		{
			short num = (short)1465315493;
			short num2 = num;
			num = (short)2067591333;
			switch (num2 == num)
			{
			default:
			{
				num = (short)1901330432;
				short num3 = num;
				break;
			}
			case true:
				break;
			}
			num = (short)1869676545;
			if (num != 0)
			{
			}
			num = (short)1482096640;
			if (num != 0)
			{
			}
			return (self.Parent as global::Motorola.MackinawCPS.CoreFeatures.TrunkingSystem.TrunkingSystem).General.TrkSysGeneralSystemType_A9252.Value == 3;
		}

		// Token: 0x06000C10 RID: 3088 RVA: 0x000C9684 File Offset: 0x000C7884
		internal static bool ConTrkPerAccSelectionIsValid(global::AcpCommonLib.IAcpFeatureSection self, int index)
		{
			global::Motorola.MackinawCPS.CoreFeatures.TrunkingSystem.TrunkingSystem trunkingSystem;
			short num;
			for (;;)
			{
				trunkingSystem = (self.Parent as global::Motorola.MackinawCPS.CoreFeatures.TrunkingSystem.TrunkingSystem);
				if (index != 0)
				{
					num = (short)692174735;
					short num2 = num;
					num = (short)1632354191;
					switch ((num2 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						continue;
					case 1:
						goto IL_70;
					}
					break;
				}
				return true;
			}
			num = (short)2147221504;
			short num3 = num;
			IL_70:
			num = (short)1450835969;
			if (num != 0)
			{
			}
			num = (short)45350912;
			if (num != 0)
			{
			}
			return trunkingSystem.General.TrkSysGeneralSystemType_A9252.Value == 3;
		}

		// Token: 0x06000C11 RID: 3089 RVA: 0x000C9754 File Offset: 0x000C7954
		internal static bool ConTrkPerAccSelectionIsVisible(global::AcpCommonLib.IAcpFeatureSection self)
		{
			global::Motorola.MackinawCPS.CoreFeatures.TrunkingSystem.Features features;
			short num;
			for (;;)
			{
				features = (self as global::Motorola.MackinawCPS.CoreFeatures.TrunkingSystem.Features);
				if ((self.Parent as global::Motorola.MackinawCPS.CoreFeatures.TrunkingSystem.TrunkingSystem).General.TrkSysGeneralSystemType_A9252.Value != 3)
				{
					num = (short)324622629;
					short num2 = num;
					num = (short)559438117;
					switch ((num2 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						continue;
					case 1:
						goto IL_85;
					}
					break;
				}
				return true;
			}
			num = (short)597491712;
			short num3 = num;
			IL_85:
			num = (short)266862592;
			if (num != 0)
			{
			}
			num = (short)1345650689;
			if (num != 0)
			{
			}
			return features.TrkSysFeaturesPASelection_A42882.Value != 0;
		}

		// Token: 0x06000C12 RID: 3090 RVA: 0x000C9834 File Offset: 0x000C7A34
		internal static bool ConLocationEnableIsEnabledAndSystemTypeIsASTRO25(global::AcpCommonLib.IAcpFeatureSection self)
		{
			short num = (short)826081280;
			int num2 = (int)num;
			switch (num2)
			{
			default:
			{
				switch (0)
				{
				case 0:
					goto IL_6E;
				}
				global::Motorola.MackinawCPS.CoreFeatures.TrunkingSystem.Features features;
				global::Motorola.MackinawCPS.CoreFeatures.TrunkingSystem.TrunkingSystem trunkingSystem;
				bool flag;
				for (;;)
				{
					IL_27:
					switch (num2)
					{
					case 0:
						num = (short)533069826;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 1:
						num = (short)5505033;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 2:
					{
						if (features.TrkSysFeatureLocationOnPTT_43026.Value)
						{
							num = (short)1925971974;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						global::AcpBusinessLayer.AcpRecRefField trkSysGeneralDataProfileSelection_A = trunkingSystem.General.TrkSysGeneralDataProfileSelection_A19449;
						num = (short)686293007;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 3:
						if (trunkingSystem.General.TrkSysGeneralSystemType_A9252.Value == 3)
						{
							num = (short)95879168;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return false;
					case 4:
						num = (short)2111176711;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 5:
						num = (short)1766457355;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 6:
						goto IL_1E2;
					case 7:
					{
						global::Motorola.MackinawCPS.CoreFeatures.DataProfiles.DataProfiles dataProfiles;
						if (dataProfiles.Features.DataProfFeaturesARSMode_A7465.Value == 5)
						{
							num = (short)1895825422;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return false;
					}
					case 8:
					{
						num = (short)1116340225;
						if (num != 0)
						{
						}
						global::Motorola.MackinawCPS.CoreFeatures.DataProfiles.DataProfiles dataProfiles;
						if (dataProfiles != null)
						{
							num = (short)1151008772;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return false;
					}
					case 9:
					{
						global::AcpBusinessLayer.AcpRecRefField trkSysGeneralDataProfileSelection_A;
						if (trkSysGeneralDataProfileSelection_A.Value != 0)
						{
							num = (short)1519452172;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return false;
					}
					case 10:
						if (features.RefRadioWide.Location.RadWideLocationLocationEnable_A8448.Value && flag)
						{
							num = (short)851771405;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return false;
					case 11:
					{
						global::AcpBusinessLayer.AcpRecRefField trkSysGeneralDataProfileSelection_A;
						if (trkSysGeneralDataProfileSelection_A.RefRecset != null)
						{
							num = (short)1940455425;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return false;
					}
					case 12:
					{
						global::AcpBusinessLayer.AcpRecRefField trkSysGeneralDataProfileSelection_A;
						global::Motorola.MackinawCPS.CoreFeatures.DataProfiles.DataProfiles dataProfiles = trkSysGeneralDataProfileSelection_A.ReferencedNode as global::Motorola.MackinawCPS.CoreFeatures.DataProfiles.DataProfiles;
						goto IL_FC;
					}
					case 13:
						num = (short)842137603;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 14:
						return true;
					case 15:
					{
						global::AcpBusinessLayer.AcpRecRefField trkSysGeneralDataProfileSelection_A;
						if (trkSysGeneralDataProfileSelection_A == null)
						{
							return false;
						}
						num = (short)1191526926;
						short num3 = num;
						num = (short)1914126862;
						switch ((num3 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_FC;
						default:
							num = (short)452198400;
							if (num != 0)
							{
							}
							num = (short)1236860933;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						break;
					}
					}
					goto IL_6E;
					IL_FC:
					num = (short)407765000;
					num2 = (int)((global::System.IntPtr)num);
				}
				IL_1E2:
				num = (short)1700921344;
				short num4 = num;
				return true;
				IL_6E:
				features = (self as global::Motorola.MackinawCPS.CoreFeatures.TrunkingSystem.Features);
				trunkingSystem = (self.Parent as global::Motorola.MackinawCPS.CoreFeatures.TrunkingSystem.TrunkingSystem);
				flag = (features.RefRadioWide.Location.RadCfgLocationReporting.Value != 1);
				num = (short)1747714058;
				num2 = (int)((global::System.IntPtr)num);
				goto IL_27;
			}
			}
		}

		// Token: 0x06000C13 RID: 3091 RVA: 0x000C9BC4 File Offset: 0x000C7DC4
		internal static bool ConTrkSysOTARadioAliasUpdateEnableIsApp(global::AcpCommonLib.IAcpFeatureSection self)
		{
			switch (0)
			{
			case 0:
				goto IL_20;
			}
			int num;
			short num2;
			global::Motorola.MackinawCPS.CoreFeatures.TrunkingSystem.TrunkingSystem trunkingSystem;
			global::Motorola.MackinawCPS.CoreFeatures.TrunkingSystem.Features features;
			for (;;)
			{
				IL_0A:
				switch (num)
				{
				case 0:
					goto IL_16B;
				case 1:
				{
					num2 = (short)1224081409;
					if (num2 != 0)
					{
					}
					if (trunkingSystem.General.TrkSysGeneralSystemType_A9252.Value != 3)
					{
						return false;
					}
					num2 = (short)1529865812;
					short num3 = num2;
					num2 = (short)1865147988;
					switch ((num3 == num2) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_A5;
					default:
						num2 = (short)862715904;
						if (num2 != 0)
						{
						}
						num2 = (short)1369636864;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					break;
				}
				case 2:
					if (features.RefRadioWide.UserInformationAndPasswords.RadWideUserInformationandPasswordsRadioAliasEnable_A8830.Value)
					{
						num2 = (short)572260352;
						short num4 = num2;
						num2 = (short)621215747;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					return false;
				case 3:
					goto IL_A5;
				}
				goto IL_20;
				IL_A5:
				num2 = (short)181731329;
				num = (int)((global::System.IntPtr)num2);
			}
			IL_16B:
			return features.TrkPerFeaturesOTARadioAliasType_42854.Value != 0;
			IL_20:
			features = (self as global::Motorola.MackinawCPS.CoreFeatures.TrunkingSystem.Features);
			trunkingSystem = (self.Parent as global::Motorola.MackinawCPS.CoreFeatures.TrunkingSystem.TrunkingSystem);
			num2 = (short)784138242;
			num = (int)((global::System.IntPtr)num2);
			goto IL_0A;
		}

		// Token: 0x06000C14 RID: 3092 RVA: 0x000C9D44 File Offset: 0x000C7F44
		internal static bool conLocationOnPTTValid(global::AcpCommonLib.IAcpFeatureSection self)
		{
			switch (0)
			{
			case 0:
				goto IL_48;
			}
			int num;
			short num2;
			global::Motorola.MackinawCPS.CoreFeatures.TrunkingSystem.TrunkingSystem trunkingSystem;
			for (;;)
			{
				IL_0A:
				switch (num)
				{
				case 0:
				{
					global::AcpBusinessLayer.AcpRecRefField trkSysGeneralDataProfileSelection_A;
					if (trkSysGeneralDataProfileSelection_A.Value != 0)
					{
						num2 = (short)1875116036;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					return false;
				}
				case 1:
				{
					global::AcpBusinessLayer.AcpRecRefField trkSysGeneralDataProfileSelection_A = trunkingSystem.General.TrkSysGeneralDataProfileSelection_A19449;
					num2 = (short)1071579147;
					num = (int)((global::System.IntPtr)num2);
					continue;
				}
				case 2:
					num2 = (short)1565130752;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 3:
					if (!trunkingSystem.Features.TrkSysFeatureLocationOnPTT_43026.Value)
					{
						num2 = (short)667549702;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					num2 = (short)495321098;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 4:
				{
					global::AcpBusinessLayer.AcpRecRefField trkSysGeneralDataProfileSelection_A;
					global::Motorola.MackinawCPS.CoreFeatures.DataProfiles.DataProfiles dataProfiles = trkSysGeneralDataProfileSelection_A.ReferencedNode as global::Motorola.MackinawCPS.CoreFeatures.DataProfiles.DataProfiles;
					num2 = (short)1752825864;
					num = (int)((global::System.IntPtr)num2);
					continue;
				}
				case 5:
					num2 = (short)326303751;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 6:
					return true;
				case 7:
				{
					global::Motorola.MackinawCPS.CoreFeatures.DataProfiles.DataProfiles dataProfiles;
					if (dataProfiles.Features.DataProfFeaturesARSMode_A7465.Value == 5)
					{
						num2 = (short)1241317389;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					return false;
				}
				case 8:
				{
					num2 = (short)2069757953;
					if (num2 != 0)
					{
					}
					global::Motorola.MackinawCPS.CoreFeatures.DataProfiles.DataProfiles dataProfiles;
					if (dataProfiles != null)
					{
						goto IL_238;
					}
					return false;
				}
				case 9:
				{
					global::AcpBusinessLayer.AcpRecRefField trkSysGeneralDataProfileSelection_A;
					if (trkSysGeneralDataProfileSelection_A.RefRecset != null)
					{
						num2 = (short)1940717570;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					return false;
				}
				case 10:
				{
					num2 = (short)1195848639;
					short num3 = num2;
					num2 = (short)1127297983;
					switch ((num3 == num2) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_238;
					case 1:
						break;
					default:
					{
						num2 = (short)1682767872;
						short num4 = num2;
						break;
					}
					}
					num2 = (short)700776448;
					if (num2 != 0)
					{
					}
					if (trunkingSystem.General.TrkSysGeneralSystemType_A9252.Value == 3)
					{
						num2 = (short)1469841409;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					return true;
				}
				case 11:
				{
					global::AcpBusinessLayer.AcpRecRefField trkSysGeneralDataProfileSelection_A;
					if (trkSysGeneralDataProfileSelection_A != null)
					{
						num2 = (short)249757708;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					return false;
				}
				case 12:
					num2 = (short)1461780489;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 13:
					return true;
				}
				goto IL_48;
				IL_238:
				num2 = (short)920518661;
				num = (int)((global::System.IntPtr)num2);
			}
			return true;
			IL_48:
			trunkingSystem = (self.Parent as global::Motorola.MackinawCPS.CoreFeatures.TrunkingSystem.TrunkingSystem);
			num2 = (short)1564606467;
			num = (int)((global::System.IntPtr)num2);
			goto IL_0A;
		}

		// Token: 0x06000C15 RID: 3093 RVA: 0x000CA028 File Offset: 0x000C8228
		internal static bool conTrkSysSecureMultikeyAutoKeyIDRx(global::AcpCommonLib.IAcpFeatureSection self)
		{
			short num = (short)1992818690;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				global::Motorola.MackinawCPS.CoreFeatures.TrunkingSystem.TrunkingSystem trunkingSystem;
				switch (num2)
				{
				case 0:
					goto IL_12B;
				case 1:
				{
					if (trunkingSystem.General.TrkSysGeneralSystemType_A9252.Value != 2)
					{
						return true;
					}
					num = (short)627213353;
					short num3 = num;
					num = (short)1353876521;
					switch ((num3 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						continue;
					default:
					{
						num = (short)1563361280;
						short num4 = num;
						num = (short)582877184;
						if (num != 0)
						{
						}
						num = (short)447676416;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					}
					break;
				}
				case 2:
					switch (0)
					{
					case 0:
						goto IL_34;
					}
					continue;
				case 3:
					num = (short)1738866689;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				IL_34:
				global::Motorola.MackinawCPS.CoreFeatures.TrunkingSystem.SecureMultikey secureMultikey = self as global::Motorola.MackinawCPS.CoreFeatures.TrunkingSystem.SecureMultikey;
				trunkingSystem = (self.Parent as global::Motorola.MackinawCPS.CoreFeatures.TrunkingSystem.TrunkingSystem);
				if (secureMultikey.RefSecureWide.General.SecWideGeneralSecureOperation_A9067.Value == 0)
				{
					break;
				}
				num = (short)1260388355;
				num2 = (int)((global::System.IntPtr)num);
			}
			return false;
			IL_12B:
			num = (short)348192769;
			if (num != 0)
			{
			}
			return false;
		}

		// Token: 0x06000C16 RID: 3094 RVA: 0x000CA190 File Offset: 0x000C8390
		internal static bool IsKeySelectApplicable(global::AcpCommonLib.IAcpFeatureSection self)
		{
			switch (0)
			{
			case 0:
				goto IL_48;
			}
			int num;
			bool flag;
			short num2;
			global::Motorola.MackinawCPS.CoreFeatures.TrunkingSystem.SecureMultikey secureMultikey;
			for (;;)
			{
				IL_0A:
				switch (num)
				{
				case 0:
					if (!flag)
					{
						num2 = (short)630228704;
						short num3 = num2;
						num2 = (short)1216775904;
						switch ((num3 == num2) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_244;
						case 1:
							break;
						default:
						{
							num2 = (short)239337472;
							short num4 = num2;
							break;
						}
						}
						num2 = (short)314114048;
						if (num2 != 0)
						{
						}
						num2 = (short)1216151556;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					num2 = (short)393281545;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 1:
					num2 = (short)1437138945;
					if (num2 != 0)
					{
					}
					num2 = (short)1045561351;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 2:
					goto IL_2D0;
				case 3:
					if (secureMultikey != null)
					{
						num2 = (short)1761214470;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					return false;
				case 4:
					goto IL_19F;
				case 5:
					goto IL_279;
				case 6:
					num2 = (short)1758724096;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 7:
					if (self.CurrentField.Name == secureMultikey.TrkSysSecureMultikeyDynamicTalkgroupKeySelect_A7918.Name)
					{
						num2 = (short)401604621;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					return false;
				case 8:
					goto IL_244;
				case 9:
					if (self.CurrentField.Name == secureMultikey.TrkSysSecureMultikeyFailsoftKeySelect_A8012.Name)
					{
						num2 = (short)962396162;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					num2 = (short)1228800008;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 10:
					if (!(self.CurrentField.Name == secureMultikey.TrkSysSecureMultikeyDynamicAGKeySelect_A7914.Name))
					{
						num2 = (short)810876929;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_21C;
				case 11:
					if (self.CurrentField.Name == secureMultikey.TrkSysSecureMultikeyPrivateCallKeySelect_A8757.Name)
					{
						num2 = (short)1470824460;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					num2 = (short)1903427594;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 12:
					goto IL_323;
				case 13:
					goto IL_F3;
				}
				goto IL_48;
				IL_244:
				if (self.CurrentField.Name == secureMultikey.TrkSysSecureMultikeyInterconnectKeySelect_A8298.Name)
				{
					num2 = (short)1407713285;
					num = (int)((global::System.IntPtr)num2);
				}
				else
				{
					num2 = (short)1641611275;
					num = (int)((global::System.IntPtr)num2);
				}
			}
			return false;
			IL_F3:
			goto IL_21C;
			IL_19F:
			return false;
			IL_21C:
			return secureMultikey.TrkSysSecureMultikeyDynamicSecureClearStrapping_43489 != 0;
			IL_279:
			return secureMultikey.TrkSysSecureMultikeyInterconnectSecureClearStrapping_43478.Value != 0;
			IL_2D0:
			return secureMultikey.TrkSysSecureMultikeyFailsoftSecureClearStrapping_43479.Value != 0;
			IL_323:
			return secureMultikey.TrkSysSecureMultikeyPrivateCallSecureClearStrapping_43477.Value != 0;
			IL_48:
			secureMultikey = (self as global::Motorola.MackinawCPS.CoreFeatures.TrunkingSystem.SecureMultikey);
			flag = global::Motorola.MackinawCPS.CoreFeatures.TrunkingSystem.TrunkingSystemConstraints.ConHWOrADPAndTrkSysTypeApco(self);
			num2 = (short)1476001795;
			num = (int)((global::System.IntPtr)num2);
			goto IL_0A;
		}

		// Token: 0x06000C17 RID: 3095 RVA: 0x000CA4D8 File Offset: 0x000C86D8
		internal static bool IsVPKeySelectApplicable(global::AcpCommonLib.IAcpFeatureSection self)
		{
			switch (0)
			{
			case 0:
				goto IL_20;
			}
			int num;
			bool flag;
			short num2;
			global::Motorola.MackinawCPS.CoreFeatures.TrunkingSystem.SecureMultikey secureMultikey;
			for (;;)
			{
				IL_0A:
				switch (num)
				{
				case 0:
					goto IL_12A;
				case 1:
				{
					if (flag)
					{
						goto IL_12F;
					}
					num2 = (short)614657435;
					short num3 = num2;
					num2 = (short)577629595;
					switch ((num3 == num2) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_82;
					default:
						num2 = (short)1378156544;
						if (num2 != 0)
						{
						}
						num2 = (short)2008154112;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					break;
				}
				case 2:
					if (secureMultikey != null)
					{
						num2 = (short)716832768;
						short num4 = num2;
						num2 = (short)1533149187;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_84;
				case 3:
					goto IL_82;
				}
				goto IL_20;
				IL_82:
				num2 = (short)1197080577;
				num = (int)((global::System.IntPtr)num2);
			}
			IL_84:
			num2 = (short)2103181313;
			if (num2 != 0)
			{
			}
			return false;
			IL_12A:
			goto IL_84;
			IL_12F:
			return secureMultikey.TrkSysSecureMultikeyVirtualPartnerSecureClearStrapping_A43670.Value != 0;
			IL_20:
			secureMultikey = (self as global::Motorola.MackinawCPS.CoreFeatures.TrunkingSystem.SecureMultikey);
			flag = global::Motorola.MackinawCPS.CoreFeatures.TrunkingSystem.TrunkingSystemConstraints.ConSecOperNotDisabledAndTrkSysTypeApco(self);
			num2 = (short)341245954;
			num = (int)((global::System.IntPtr)num2);
			goto IL_0A;
		}

		// Token: 0x06000C18 RID: 3096 RVA: 0x000CA624 File Offset: 0x000C8824
		internal static bool ConChangeApplicabilityOnCoverageTypeChanged(global::AcpCommonLib.IAcpFeatureSection self)
		{
			global::Motorola.MackinawCPS.CoreFeatures.TrunkingSystem.General general = self as global::Motorola.MackinawCPS.CoreFeatures.TrunkingSystem.General;
			if (general != null)
			{
				short num = (short)514453162;
				short num2 = num;
				num = (short)1847586474;
				switch ((num2 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					break;
				default:
				{
					num = (short)77856768;
					short num3 = num;
					num = (short)70451201;
					if (num != 0)
					{
					}
					num = (short)677380096;
					if (num != 0)
					{
					}
					return general.TrkSysGeneralCoverageType_A7782Value != 5;
				}
				}
			}
			return true;
		}

		// Token: 0x06000C19 RID: 3097 RVA: 0x000CA6E8 File Offset: 0x000C88E8
		internal static bool ConFieldNotEditableWhenAskRequiredInSameTrkSysIsOn(global::AcpCommonLib.IAcpFeatureSection self)
		{
			global::Motorola.MackinawCPS.CoreFeatures.TrunkingSystem.General general = self as global::Motorola.MackinawCPS.CoreFeatures.TrunkingSystem.General;
			short num;
			if (general != null)
			{
				num = (short)77968531;
				short num2 = num;
				num = (short)421246099;
				switch ((num2 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					goto IL_0C;
				case 1:
					break;
				default:
				{
					num = (short)582877184;
					short num3 = num;
					break;
				}
				}
				num = (short)1885339648;
				if (num != 0)
				{
				}
				return !general.TrkSysGeneralAskRequired_A44909Value;
			}
			IL_0C:
			num = (short)1546256385;
			if (num != 0)
			{
			}
			return true;
		}
	}
}
