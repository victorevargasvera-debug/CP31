using System;
using System.Text;
using System.Text.RegularExpressions;
using AcpBusinessLayer;
using AcpCommonLib;
using AcpCommonLib.UndoRedo;
using AllFeatures;
using ConstraintHelper;
using Motorola.MackinawCPS.CoreFeatures.ConventionalPersonality;
using Motorola.MackinawCPS.CoreFeatures.TrunkingPersonality;
using Motorola.MackinawCPS.CoreFeatures.TrunkingSystem;

namespace Motorola.MackinawCPS.CoreFeatures.RadioInformation
{
	// Token: 0x02000199 RID: 409
	public static class RadioInformationConstraints
	{
		// Token: 0x06004500 RID: 17664 RVA: 0x003FE8F8 File Offset: 0x003FCAF8
		internal static bool conReturnFalse(global::AcpCommonLib.IAcpFeatureSection self)
		{
			short num = (short)947139873;
			short num2 = num;
			num = (short)1556296993;
			switch (num2 == num)
			{
			}
			num = (short)607256576;
			if (num != 0)
			{
			}
			num = (short)1677524993;
			if (num != 0)
			{
			}
			num = (short)474546176;
			short num3 = num;
			return false;
		}

		// Token: 0x06004501 RID: 17665 RVA: 0x003FE9A4 File Offset: 0x003FCBA4
		internal static bool ConAreInvalidFrequenciesAllowed(global::AcpCommonLib.IAcpFeatureSection self)
		{
			short num = (short)629410134;
			short num2 = num;
			num = (short)464718166;
			switch (num2 == num)
			{
			}
			num = (short)1080033281;
			if (num != 0)
			{
			}
			num = (short)523567104;
			if (num != 0)
			{
			}
			num = (short)300220416;
			short num3 = num;
			return (self as global::Motorola.MackinawCPS.CoreFeatures.RadioInformation.FrequencyRanges).RadInfoFrequencyRangesAllowInvalidFrequencies_A12493.Value;
		}

		// Token: 0x06004502 RID: 17666 RVA: 0x003FEA60 File Offset: 0x003FCC60
		public static void ConReadPerformanceValidity(global::AcpCommonLib.IAcpFeatureSection self, global::AcpCommonLib.UndoRedo.ContainerTask task)
		{
			short num = (short)1499725824;
			switch (num)
			{
			default:
			{
				num = (short)1677197314;
				int num2 = (int)((global::System.IntPtr)num);
				for (;;)
				{
					global::AcpCommonLib.IAcpRecordset embeddedRecset;
					global::AcpCommonLib.IAcpRecordset feature;
					int value;
					global::Motorola.MackinawCPS.CoreFeatures.TrunkingPersonality.General general;
					int num4;
					int num5;
					int num6;
					global::AcpCommonLib.IAcpRecordset feature2;
					int num7;
					global::AcpCommonLib.IAcpRecordset feature3;
					int num9;
					global::AcpCommonLib.IAcpRecordset feature4;
					switch (num2)
					{
					case 0:
						goto IL_9B9;
					case 1:
						num = (short)2087780375;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 2:
						switch (0)
						{
						case 0:
							goto IL_134;
						}
						continue;
					case 3:
					{
						int num3;
						if (num3 >= embeddedRecset.Count)
						{
							num = (short)148963345;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						global::Motorola.MackinawCPS.CoreFeatures.ConventionalPersonality.FrequencyOptionsInnerSection frequencyOptionsInnerSection = embeddedRecset[num3][10149] as global::Motorola.MackinawCPS.CoreFeatures.ConventionalPersonality.FrequencyOptionsInnerSection;
						frequencyOptionsInnerSection.CnvPerConventionalChannelOptionsRxFrequency_A8911.CalculateValidity();
						frequencyOptionsInnerSection.CnvPerConventionalChannelOptionsTAFrequency_A9260.CalculateApplicability();
						frequencyOptionsInnerSection.CnvPerConventionalChannelOptionsTAFrequency_A9260.CalculateValidity();
						frequencyOptionsInnerSection.CnvPerConventionalChannelOptionsTxFrequency_A9414.CalculateApplicability();
						frequencyOptionsInnerSection.CnvPerConventionalChannelOptionsTxFrequency_A9414.CalculateValidity();
						num3++;
						num = (short)1432223766;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 4:
						goto IL_72C;
					case 5:
					{
						global::Motorola.MackinawCPS.CoreFeatures.TrunkingPersonality.AnnouncementGroup announcementGroup;
						announcementGroup.TrkPerAnnouncementGroupAGFailsoftRxFrequencyMHz_A9582.CalculateValidity();
						announcementGroup.TrkPerAnnouncementGroupAGFailsoftTxFrequencyMHz_A9583.CalculateValidity();
						num = (short)1986330630;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 6:
					{
						global::Motorola.MackinawCPS.CoreFeatures.TrunkingPersonality.AnnouncementGroup announcementGroup;
						if (announcementGroup.TrkPerAnnouncementGroupAGSecondaryFailsoft_A19990.Value)
						{
							num = (short)800456735;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_6BE;
					}
					case 7:
						goto IL_AB4;
					case 8:
					{
						global::Motorola.MackinawCPS.CoreFeatures.TrunkingPersonality.TalkgroupInnerSection talkgroupInnerSection;
						talkgroupInnerSection.TrkPerTalkgroupSecondaryFailsoftRxFrequencyMHz_A8900.CalculateValidity();
						talkgroupInnerSection.TrkPerTalkgroupSecondaryFailsoftTxFrequencyMHz_A8902.CalculateValidity();
						num = (short)1065484343;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 9:
						goto IL_973;
					case 10:
						if (feature != null)
						{
							num = (short)1475870721;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_15E;
					case 11:
						goto IL_74F;
					case 12:
						goto IL_9B9;
					case 13:
						switch (value)
						{
						case 0:
							goto IL_69B;
						case 1:
							general.TrkPerGeneralRxFrequencyMHz_A8910.CalculateApplicability();
							general.TrkPerGeneralRxFrequencyMHz_A8910.CalculateValidity();
							general.TrkPerGeneralTxFrequencyMHz_A9413.CalculateApplicability();
							general.TrkPerGeneralTxFrequencyMHz_A9413.CalculateValidity();
							num = (short)1038483495;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 2:
						{
							global::AcpCommonLib.IAcpRecordset embeddedRecset2 = feature[num4][10179].EmbeddedRecset;
							num5 = 0;
							num = (short)1061617691;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						default:
							num = (short)926023701;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						break;
					case 14:
					{
						global::AcpCommonLib.IAcpRecordset embeddedRecset2;
						if (num5 >= embeddedRecset2.Count)
						{
							num = (short)303431710;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						global::Motorola.MackinawCPS.CoreFeatures.TrunkingPersonality.TalkgroupInnerSection talkgroupInnerSection = embeddedRecset2[num5][10180] as global::Motorola.MackinawCPS.CoreFeatures.TrunkingPersonality.TalkgroupInnerSection;
						num = (short)1703542832;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 15:
						goto IL_15E;
					case 16:
						num = (short)1336148009;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 17:
						goto IL_A90;
					case 18:
						goto IL_AB4;
					case 19:
						return;
					case 20:
						goto IL_2F2;
					case 21:
						num = (short)434503712;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 22:
						goto IL_377;
					case 23:
					{
						if (num4 >= feature.Count)
						{
							num = (short)1248133135;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						global::Motorola.MackinawCPS.CoreFeatures.TrunkingPersonality.AnnouncementGroup announcementGroup = feature[num4][10176] as global::Motorola.MackinawCPS.CoreFeatures.TrunkingPersonality.AnnouncementGroup;
						num = (short)32178202;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 24:
						num = (short)606797859;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 25:
						num = (short)176029697;
						if (num != 0)
						{
						}
						goto IL_377;
					case 26:
					{
						global::Motorola.MackinawCPS.CoreFeatures.TrunkingPersonality.AnnouncementGroup announcementGroup;
						if (announcementGroup != null)
						{
							num = (short)1317339160;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_6BE;
					}
					case 27:
						goto IL_2F2;
					case 28:
						goto IL_4C4;
					case 29:
						return;
					case 30:
						goto IL_69B;
					case 31:
					{
						global::Motorola.MackinawCPS.CoreFeatures.TrunkingPersonality.AnnouncementGroup announcementGroup;
						announcementGroup.TrkPerAnnouncementGroupAGSecondaryFSRxFrequencyMHz_A8895.CalculateValidity();
						announcementGroup.TrkPerAnnouncementGroupAGSecondaryFSTxFrequencyMHz_A12903.CalculateValidity();
						num = (short)603127853;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 32:
						goto IL_69B;
					case 33:
						num = (short)56492068;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 34:
					{
						if (num6 >= feature2.Count)
						{
							num = (short)1760755741;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						embeddedRecset = global::AcpCommonLib.FeatureManager.GetFeature(2059)[num6][10148].EmbeddedRecset;
						int num3 = 0;
						num = (short)979435545;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 35:
					{
						global::Motorola.MackinawCPS.CoreFeatures.TrunkingPersonality.AnnouncementGroup announcementGroup;
						if (announcementGroup.TrkPerAnnouncementGroupAnnouncementGroupFailsoft_A8597.Value)
						{
							num = (short)97714181;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_6BE;
					}
					case 36:
					{
						if (num7 >= feature3.Count)
						{
							num = (short)666370059;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)686386773;
						short num8 = num;
						num = (short)1092251221;
						switch ((num8 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_391;
						default:
							num = (short)561315840;
							if (num != 0)
							{
							}
							feature3[num7][10006].CalculateApplicability();
							feature3[num7][10006].CalculateValidity();
							feature3[num7][10010].CalculateApplicability();
							feature3[num7][10010].CalculateValidity();
							feature3[num7][10905].CalculateApplicability();
							feature3[num7][10905].CalculateValidity();
							feature3[num7][10008].CalculateApplicability();
							feature3[num7][10008].CalculateValidity();
							feature3[num7][10612].CalculateApplicability();
							feature3[num7][10612].CalculateValidity();
							feature3[num7][10791].CalculateApplicability();
							feature3[num7][10791].CalculateValidity();
							feature3[num7][10801].CalculateApplicability();
							feature3[num7][10801].CalculateValidity();
							num7++;
							num = (short)167641126;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						break;
					}
					case 37:
						goto IL_4C4;
					case 38:
						goto IL_5AD;
					case 39:
						if (general.TrkPerGeneralSecondaryFailsoft_A19991.Value)
						{
							num = (short)1214119982;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_69B;
					case 40:
					{
						if (num9 >= feature4.Count)
						{
							num = (short)1324351544;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						global::Motorola.MackinawCPS.CoreFeatures.TrunkingSystem.General general2 = feature4[num9][10157] as global::Motorola.MackinawCPS.CoreFeatures.TrunkingSystem.General;
						num = (short)443088955;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 41:
					{
						global::Motorola.MackinawCPS.CoreFeatures.TrunkingSystem.General general2;
						if (general2.TrkSysGeneralSystemType_A9252.Value == 2)
						{
							num = (short)1509883955;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_72C;
					}
					case 42:
					{
						global::AcpCommonLib.IAcpRecordset embeddedRecset2;
						if (embeddedRecset2 != null)
						{
							num = (short)92274742;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_69B;
					}
					case 43:
						goto IL_69B;
					case 44:
						if (feature3 != null)
						{
							num = (short)498466849;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_74F;
					case 45:
						goto IL_6BE;
					case 46:
					{
						general.TrkPerGeneralSecondaryRxFrequencyMHz_A8904.CalculateApplicability();
						general.TrkPerGeneralSecondaryRxFrequencyMHz_A8904.CalculateValidity();
						general.TrkPerGeneralSecondaryTxFrequencyMHz_A12902.CalculateApplicability();
						general.TrkPerGeneralSecondaryTxFrequencyMHz_A12902.CalculateValidity();
						num = (short)1657667584;
						short num10 = num;
						num = (short)130744363;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 47:
						goto IL_391;
					case 48:
					{
						global::Motorola.MackinawCPS.CoreFeatures.TrunkingPersonality.TalkgroupInnerSection talkgroupInnerSection;
						if (talkgroupInnerSection.TrkPerTalkgroupTalkgroupFailsoft_A8005.Value)
						{
							num = (short)1498939441;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_973;
					}
					case 49:
					{
						global::Motorola.MackinawCPS.CoreFeatures.TrunkingPersonality.TalkgroupInnerSection talkgroupInnerSection;
						talkgroupInnerSection.TrkPerTalkgroupFailsoftRxFrequencyMHz_A8001.CalculateValidity();
						talkgroupInnerSection.TrkPerTalkgroupFailsoftTxFrequencyMHz_A8003.CalculateValidity();
						num = (short)1711276041;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 50:
						num = (short)984219651;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 51:
					{
						global::Motorola.MackinawCPS.CoreFeatures.TrunkingSystem.General general2;
						general2.TrkSysGeneralTypeIIFrequencyBand_A12491.CalculateValidity();
						num = (short)1146028036;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 52:
						num = (short)638386210;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 53:
						goto IL_5AD;
					case 54:
						num = (short)693043214;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 55:
						goto IL_18A;
					case 56:
						feature = global::AcpCommonLib.FeatureManager.GetFeature(2072);
						num4 = 0;
						num = (short)1954480146;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 57:
					{
						global::Motorola.MackinawCPS.CoreFeatures.TrunkingPersonality.TalkgroupInnerSection talkgroupInnerSection;
						if (talkgroupInnerSection.TrkPerTalkgroupTGSecondaryFailsoft_A19989.Value)
						{
							num = (short)1992949768;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_18A;
					}
					case 58:
						if (feature2 != null)
						{
							num = (short)281542708;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return;
					case 59:
					{
						global::Motorola.MackinawCPS.CoreFeatures.TrunkingSystem.General general2;
						if (general2 != null)
						{
							num = (short)1685258256;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_72C;
					}
					}
					IL_134:
					if (global::AcpCommonLib.AppInfoManager.AppMode == global::AcpCommonLib.ApplicationMode.CustomViewConfigurationMode)
					{
						num = (short)1887043603;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					feature4 = global::AcpCommonLib.FeatureManager.GetFeature(2064);
					num9 = 0;
					num = (short)683409445;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_15E:
					feature3 = global::AcpCommonLib.FeatureManager.GetFeature(2003);
					num7 = 0;
					num = (short)887095349;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_18A:
					num5++;
					num = (short)199032852;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_2F2:
					num = (short)19005482;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_377:
					num = (short)1990262831;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_391:
					if (embeddedRecset != null)
					{
						num = (short)1357709362;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_A90;
					IL_4C4:
					num = (short)588447784;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_5AD:
					num = (short)1839726636;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_69B:
					num4++;
					num = (short)1854799879;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_6BE:
					general = (feature[num4][10178] as global::Motorola.MackinawCPS.CoreFeatures.TrunkingPersonality.General);
					value = general.TrkPerGeneralFailsoftType_A8599.Value;
					num = (short)720306189;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_72C:
					num9++;
					num = (short)1839923228;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_74F:
					feature2 = global::AcpCommonLib.FeatureManager.GetFeature(2059);
					num6 = 0;
					num = (short)495255564;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_973:
					num = (short)1356922937;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_9B9:
					num = (short)905117754;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_A90:
					num6++;
					num = (short)614924288;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_AB4:
					num = (short)431423498;
					num2 = (int)((global::System.IntPtr)num);
				}
				return;
			}
			}
		}

		// Token: 0x06004503 RID: 17667 RVA: 0x003FF710 File Offset: 0x003FD910
		internal static bool conDepotEditable(global::AcpCommonLib.IAcpFeatureSection self)
		{
			short num = (short)1363836161;
			short num2 = num;
			num = (short)802913537;
			switch (num2 == num)
			{
			default:
			{
				num = (short)1194459136;
				short num3 = num;
				break;
			}
			case true:
				break;
			}
			num = (short)906493953;
			if (num != 0)
			{
			}
			num = (short)412286976;
			if (num != 0)
			{
			}
			return false;
		}

		// Token: 0x06004504 RID: 17668 RVA: 0x003FF7BC File Offset: 0x003FD9BC
		internal static bool conRegionalGovernanceValid(global::AcpCommonLib.IAcpFeatureSection self, int index)
		{
			short num = (short)813874474;
			short num2 = num;
			num = (short)1586806058;
			switch (num2 == num)
			{
			default:
			{
				num = (short)276299776;
				short num3 = num;
				break;
			}
			case true:
				break;
			}
			num = (short)1103495168;
			if (num != 0)
			{
			}
			num = (short)1544617985;
			if (num != 0)
			{
			}
			return true;
		}

		// Token: 0x06004505 RID: 17669 RVA: 0x003FF864 File Offset: 0x003FDA64
		internal static bool RadInfoGeneralSerialNumber_A9122_Check(global::AcpCommonLib.IAcpFeatureSection self)
		{
			int a_ = 18;
			short num = (short)1143289456;
			short num2 = num;
			num = (short)949302896;
			int num4;
			switch ((num2 == num) ? 1 : 0)
			{
			case 0:
			case 2:
				break;
			default:
			{
				num = (short)792264704;
				short num3 = num;
				num = (short)433192960;
				if (num != 0)
				{
				}
				num = (short)1218772992;
				num4 = (int)num;
				switch (num4)
				{
				default:
					switch (0)
					{
					case 0:
						goto IL_E0;
					}
					break;
				}
				break;
			}
			}
			bool result;
			string s;
			for (;;)
			{
				IL_A5:
				switch (num4)
				{
				case 0:
				{
					string text;
					if (new global::System.Text.RegularExpressions.Regex(global::AllFeatures.CodeplugGuid.b("裒𥳐蛚蛜쳠\udae2룤볦\ud9e8웪퓬닮꫰쏲\ud8f4컶룸훺ꟼ틾娀䰂堄娆刈䨊‌唎㰐䠒尔堖䐘䘚䘜帞ఠ礢ࠤ簦怨搪瀬爮樰̲ᠴึ砸ᘺ朼ሾᩀɂDๆوṊᑌ቎౐ࡒ敔穖恘ᩚ灜՞䱠㡢⑤≦⁨⑪㡬㙮Ɒ⹲⹴䝶呸䉺㱼剾\udb80꺂\ude84욆첈슊슌\uda8e좐캒좔첖ꦘ뚚꒜\ude9e負廉袤ﲦ", a_)).IsMatch(text))
					{
						num = (short)574881800;
						num4 = (int)((global::System.IntPtr)num);
						continue;
					}
					return result;
				}
				case 1:
					goto IL_1FC;
				case 2:
				{
					string text;
					if (char.IsUpper(text[9]))
					{
						num = (short)706740225;
						num4 = (int)((global::System.IntPtr)num);
						continue;
					}
					num = (short)1121320969;
					num4 = (int)((global::System.IntPtr)num);
					continue;
				}
				case 3:
					return result;
				case 4:
					num = (short)403439626;
					num4 = (int)((global::System.IntPtr)num);
					continue;
				case 5:
					result = true;
					num = (short)203685889;
					if (num != 0)
					{
					}
					num = (short)1967587331;
					num4 = (int)((global::System.IntPtr)num);
					continue;
				case 6:
					try
					{
						byte[] bytes = global::System.Convert.FromBase64String(s);
						string text = global::System.Text.Encoding.ASCII.GetString(bytes);
						goto IL_2DE;
					}
					catch (global::System.Exception)
					{
						string text = string.Empty;
						goto IL_2DE;
					}
					goto IL_1FC;
					IL_2DE:
					num = (short)272564236;
					num4 = (int)((global::System.IntPtr)num);
					continue;
				case 7:
					return result;
				case 8:
					result = true;
					num = (short)1944256519;
					num4 = (int)((global::System.IntPtr)num);
					continue;
				case 9:
				{
					string text;
					if (new global::System.Text.RegularExpressions.Regex(global::AllFeatures.CodeplugGuid.b("裒𥳐蛚蛜쳠\udae2룤볦\ud9e8웪퓬닮꫰쏲\ud8f4컶룸훺ꟼ틾娀䰂堄娆刈䨊‌唎㰐䠒尔堖䐘䘚䘜帞ఠ礢ࠤ簦怨搪瀬爮樰̲ᠴึ砸ᘺ朼ሾᩀੂ੄ᩆᑈ၊経扎桐ቒ硔ൖ瑘Zᑜၞ㱠㹢㹤坦䑨剪ⱬ䉮⭰干⹴㙶㱸㉺㉼⩾\ud880\ude82\ud884\udc86릈Ꚋ뒌캎벐즒뢔첖\ud898\ude9a풜킞甆益", a_)).IsMatch(text))
					{
						num = (short)774504453;
						num4 = (int)((global::System.IntPtr)num);
						continue;
					}
					return result;
				}
				case 10:
				{
					string text;
					if (!char.IsUpper(text[8]))
					{
						num = (short)1765212171;
						num4 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_1FC;
				}
				case 11:
					num = (short)1198915586;
					num4 = (int)((global::System.IntPtr)num);
					continue;
				case 12:
				{
					string text;
					if (text.Length == 10)
					{
						num = (short)988610564;
						num4 = (int)((global::System.IntPtr)num);
						continue;
					}
					return result;
				}
				}
				goto IL_E0;
				IL_1FC:
				num = (short)1523253248;
				num4 = (int)((global::System.IntPtr)num);
			}
			return result;
			IL_E0:
			string s2 = (self as global::Motorola.MackinawCPS.CoreFeatures.RadioInformation.General).RadInfoGeneralSerialNumber_A9122Value.ToString().Trim();
			s = global::System.Convert.ToBase64String(global::System.Text.Encoding.ASCII.GetBytes(s2));
			result = false;
			num = (short)1092812806;
			num4 = (int)((global::System.IntPtr)num);
			goto IL_A5;
		}

		// Token: 0x06004506 RID: 17670 RVA: 0x003FFBA0 File Offset: 0x003FDDA0
		internal static bool con700MHzUsedInCodeplugValidity(global::AcpCommonLib.IAcpFeatureSection self)
		{
			int num;
			global::Motorola.MackinawCPS.CoreFeatures.RadioInformation.FrequencyRanges frequencyRanges;
			short num2;
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
						if (frequencyRanges.RadInfoFrequencyRangesAllowInvalidFrequencies_A12493.Value)
						{
							num2 = (short)1475280897;
							num = (int)((global::System.IntPtr)num2);
							continue;
						}
						goto IL_11F;
					case 1:
					{
						num2 = (short)1269258266;
						short num3 = num2;
						num2 = (short)832788506;
						switch ((num3 == num2) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_27;
						default:
							num2 = (short)1056571392;
							if (num2 != 0)
							{
							}
							num2 = (short)378601473;
							if (num2 != 0)
							{
							}
							num2 = (short)1572536322;
							num = (int)((global::System.IntPtr)num2);
							continue;
						}
						break;
					}
					case 2:
						if (frequencyRanges.RadInfoFrequencyRanges800MHzUsedinCodeplug_A42552.Value)
						{
							num2 = (short)1862991875;
							num = (int)((global::System.IntPtr)num2);
							continue;
						}
						goto IL_11F;
					case 3:
						goto IL_11D;
					}
					goto IL_20;
				}
				IL_11D:
				return frequencyRanges.RadInfoFrequencyRanges700MHzUsedinCodeplug_A42551.Value;
				IL_11F:
				num2 = (short)696975360;
				short num4 = num2;
				return true;
			}
			}
			IL_20:
			frequencyRanges = (self as global::Motorola.MackinawCPS.CoreFeatures.RadioInformation.FrequencyRanges);
			IL_27:
			num2 = (short)541786112;
			num = (int)((global::System.IntPtr)num2);
			goto IL_0A;
		}

		// Token: 0x06004507 RID: 17671 RVA: 0x003FFCF8 File Offset: 0x003FDEF8
		internal static bool con800MHzUsedInCodeplugValidity(global::AcpCommonLib.IAcpFeatureSection self)
		{
			int num;
			global::Motorola.MackinawCPS.CoreFeatures.RadioInformation.FrequencyRanges frequencyRanges;
			short num2;
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
						if (frequencyRanges.RadInfoFrequencyRangesAllowInvalidFrequencies_A12493.Value)
						{
							num2 = (short)1177485313;
							num = (int)((global::System.IntPtr)num2);
							continue;
						}
						goto IL_120;
					case 1:
					{
						num2 = (short)1301466576;
						short num3 = num2;
						num2 = (short)1260703184;
						switch ((num3 == num2) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_27;
						default:
							num2 = (short)2031419392;
							if (num2 != 0)
							{
							}
							num2 = (short)1833107458;
							num = (int)((global::System.IntPtr)num2);
							continue;
						}
						break;
					}
					case 2:
						if (frequencyRanges.RadInfoFrequencyRanges700MHzUsedinCodeplug_A42551.Value)
						{
							num2 = (short)20185091;
							num = (int)((global::System.IntPtr)num2);
							continue;
						}
						goto IL_120;
					case 3:
						goto IL_F5;
					}
					goto IL_20;
				}
				IL_F5:
				num2 = (short)616562689;
				if (num2 != 0)
				{
				}
				return frequencyRanges.RadInfoFrequencyRanges800MHzUsedinCodeplug_A42552.Value;
				IL_120:
				num2 = (short)542572544;
				short num4 = num2;
				return true;
			}
			}
			IL_20:
			frequencyRanges = (self as global::Motorola.MackinawCPS.CoreFeatures.RadioInformation.FrequencyRanges);
			IL_27:
			num2 = (short)486866944;
			num = (int)((global::System.IntPtr)num2);
			goto IL_0A;
		}

		// Token: 0x06004508 RID: 17672 RVA: 0x003FFE50 File Offset: 0x003FE050
		internal static bool ConFrequencyRanageVHFUsedIsEditable(global::AcpCommonLib.IAcpFeatureSection self)
		{
			short num = (short)956563456;
			int num2 = (int)num;
			switch (num2)
			{
			default:
			{
				switch (0)
				{
				case 0:
					goto IL_B9;
				}
				global::AcpBusinessLayer.AcpField<bool> radInfoLabtoolDualBandEnable_A;
				global::AcpBusinessLayer.AcpListField radInfoLabtoolSecondaryBands_A;
				global::Motorola.MackinawCPS.CoreFeatures.RadioInformation.General general;
				global::AcpBusinessLayer.AcpListField radInfoLabtoolPrimaryBands_A;
				for (;;)
				{
					IL_28:
					num = (short)322814685;
					short num3 = num;
					num = (short)2034418397;
					switch ((num3 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_B9;
					default:
						num = (short)1756954624;
						if (num != 0)
						{
						}
						switch (num2)
						{
						case 0:
						{
							num = (short)403374080;
							short num4 = num;
							num = (short)740491279;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						case 1:
							goto IL_220;
						case 2:
							num = (short)599523335;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 3:
							num = (short)1209729032;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 4:
							num = (short)2121662469;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 5:
							if (radInfoLabtoolDualBandEnable_A.Value)
							{
								num = (short)1864499212;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							goto IL_131;
						case 6:
							if (radInfoLabtoolSecondaryBands_A.Value != 2)
							{
								num = (short)1590362125;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							goto IL_2AB;
						case 7:
							if (radInfoLabtoolSecondaryBands_A.Value == 3)
							{
								num = (short)316473345;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							return true;
						case 8:
							if (general.RadInfoGeneralPrimaryFrequencyBandVHF_A42545.Value)
							{
								num = (short)525533195;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							return true;
						case 9:
							if (global::ConstraintHelper.UtilityMack.IsFreonRadio)
							{
								num = (short)407306243;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							num = (short)1264910350;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 10:
							if (radInfoLabtoolDualBandEnable_A.Value)
							{
								num = (short)687472642;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							return true;
						case 11:
							goto IL_267;
						case 12:
							num = (short)1030946822;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 13:
							goto IL_131;
						case 14:
							if (radInfoLabtoolPrimaryBands_A.Value != 2)
							{
								num = (short)1769078784;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							goto IL_2AB;
						case 15:
							if (radInfoLabtoolPrimaryBands_A.Value != 3)
							{
								num = (short)1899102212;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							goto IL_2AB;
						}
						goto IL_B9;
						IL_131:
						num = (short)964362250;
						num2 = (int)((global::System.IntPtr)num);
						break;
					}
				}
				IL_220:
				goto IL_2AB;
				IL_267:
				num = (short)1800339457;
				if (num != 0)
				{
				}
				global::Motorola.MackinawCPS.CoreFeatures.RadioInformation.FrequencyRanges frequencyRanges;
				return !frequencyRanges.RadInfoFrequencyRangesVHFUsedinCodeplug_A8481.Value;
				IL_2AB:
				return !frequencyRanges.RadInfoFrequencyRangesVHFUsedinCodeplug_A8481.Value;
				IL_B9:
				global::Motorola.MackinawCPS.CoreFeatures.RadioInformation.RadioInformation radioInformation = self.Parent as global::Motorola.MackinawCPS.CoreFeatures.RadioInformation.RadioInformation;
				global::Motorola.MackinawCPS.CoreFeatures.RadioInformation.Labtool labtool = radioInformation.Labtool;
				general = radioInformation.General;
				frequencyRanges = (self as global::Motorola.MackinawCPS.CoreFeatures.RadioInformation.FrequencyRanges);
				radInfoLabtoolDualBandEnable_A = labtool.RadInfoLabtoolDualBandEnable_A23986;
				radInfoLabtoolPrimaryBands_A = labtool.RadInfoLabtoolPrimaryBands_A23987;
				radInfoLabtoolSecondaryBands_A = labtool.RadInfoLabtoolSecondaryBands_A23988;
				num = (short)1386741769;
				num2 = (int)((global::System.IntPtr)num);
				goto IL_28;
			}
			}
		}

		// Token: 0x06004509 RID: 17673 RVA: 0x004001C4 File Offset: 0x003FE3C4
		internal static bool ConFrequencyRanageUHF1UsedIsEditable(global::AcpCommonLib.IAcpFeatureSection self)
		{
			short num = (short)1147535360;
			int num2 = (int)num;
			switch (num2)
			{
			default:
			{
				switch (0)
				{
				case 0:
					goto IL_6F;
				}
				global::AcpBusinessLayer.AcpListField radInfoLabtoolSecondaryBands_A;
				for (;;)
				{
					IL_28:
					switch (num2)
					{
					case 0:
						goto IL_286;
					case 1:
						if (global::ConstraintHelper.UtilityMack.IsFreonRadio)
						{
							num = (short)1333919746;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)686358531;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 2:
						num = (short)1907752972;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 3:
					{
						global::AcpBusinessLayer.AcpListField radInfoLabtoolPrimaryBands_A;
						if (radInfoLabtoolPrimaryBands_A.Value != 4)
						{
							num = (short)1907032072;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_2AD;
					}
					case 4:
					{
						global::AcpBusinessLayer.AcpField<bool> radInfoLabtoolDualBandEnable_A;
						if (radInfoLabtoolDualBandEnable_A.Value)
						{
							num = (short)451543054;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return true;
					}
					case 5:
						num = (short)1049165837;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 6:
						goto IL_268;
					case 7:
						num = (short)1800994816;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 8:
					{
						num = (short)699334656;
						short num3 = num;
						num = (short)162070538;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 9:
						goto IL_1FA;
					case 10:
					{
						global::AcpBusinessLayer.AcpListField radInfoLabtoolPrimaryBands_A;
						if (radInfoLabtoolPrimaryBands_A.Value != 5)
						{
							num = (short)990248965;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_2AD;
					}
					case 11:
						if (radInfoLabtoolSecondaryBands_A.Value == 5)
						{
							num = (short)742785033;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return true;
					case 12:
					{
						num = (short)350945281;
						if (num != 0)
						{
						}
						global::Motorola.MackinawCPS.CoreFeatures.RadioInformation.General general;
						if (general.RadInfoGeneralPrimaryFrequencyBandUHF1_A42546.Value)
						{
							num = (short)1112211462;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return true;
					}
					case 13:
					{
						global::AcpBusinessLayer.AcpField<bool> radInfoLabtoolDualBandEnable_A;
						if (radInfoLabtoolDualBandEnable_A.Value)
						{
							num = (short)1885732871;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_133;
					}
					case 14:
						num = (short)1006960651;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 15:
						goto IL_133;
					}
					goto IL_6F;
					IL_133:
					num = (short)142737412;
					num2 = (int)((global::System.IntPtr)num);
				}
				IL_1FA:
				goto IL_2AD;
				IL_268:
				global::Motorola.MackinawCPS.CoreFeatures.RadioInformation.FrequencyRanges frequencyRanges;
				return !frequencyRanges.RadInfoFrequencyRangesUHF1UsedinCodeplug_A8504.Value;
				IL_286:
				if (radInfoLabtoolSecondaryBands_A.Value != 4)
				{
					goto IL_290;
				}
				IL_2AD:
				return !frequencyRanges.RadInfoFrequencyRangesUHF1UsedinCodeplug_A8504.Value;
				IL_6F:
				num = (short)615653696;
				short num4 = num;
				num = (short)1021256000;
				switch ((num4 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					IL_290:
					num = (short)1501626383;
					num2 = (int)((global::System.IntPtr)num);
					goto IL_28;
				default:
				{
					num = (short)1727332352;
					if (num != 0)
					{
					}
					global::Motorola.MackinawCPS.CoreFeatures.RadioInformation.RadioInformation radioInformation = self.Parent as global::Motorola.MackinawCPS.CoreFeatures.RadioInformation.RadioInformation;
					global::Motorola.MackinawCPS.CoreFeatures.RadioInformation.Labtool labtool = radioInformation.Labtool;
					global::Motorola.MackinawCPS.CoreFeatures.RadioInformation.General general = radioInformation.General;
					frequencyRanges = (self as global::Motorola.MackinawCPS.CoreFeatures.RadioInformation.FrequencyRanges);
					global::AcpBusinessLayer.AcpField<bool> radInfoLabtoolDualBandEnable_A = labtool.RadInfoLabtoolDualBandEnable_A23986;
					global::AcpBusinessLayer.AcpListField radInfoLabtoolPrimaryBands_A = labtool.RadInfoLabtoolPrimaryBands_A23987;
					radInfoLabtoolSecondaryBands_A = labtool.RadInfoLabtoolSecondaryBands_A23988;
					num = (short)2005073921;
					num2 = (int)((global::System.IntPtr)num);
					goto IL_28;
				}
				}
				break;
			}
			}
		}

		// Token: 0x0600450A RID: 17674 RVA: 0x0040053C File Offset: 0x003FE73C
		internal static bool ConFrequencyRanageUHF2UsedIsEditable(global::AcpCommonLib.IAcpFeatureSection self)
		{
			short num = (short)35323904;
			int num2 = (int)num;
			switch (num2)
			{
			default:
			{
				global::Motorola.MackinawCPS.CoreFeatures.RadioInformation.FrequencyRanges frequencyRanges;
				for (;;)
				{
					switch (0)
					{
					case 0:
						goto IL_7F;
					}
					global::Motorola.MackinawCPS.CoreFeatures.RadioInformation.General general;
					global::AcpBusinessLayer.AcpListField radInfoLabtoolPrimaryBands_A;
					global::AcpBusinessLayer.AcpListField radInfoLabtoolSecondaryBands_A;
					global::AcpBusinessLayer.AcpField<bool> radInfoLabtoolDualBandEnable_A;
					for (;;)
					{
						IL_27:
						num = (short)701759488;
						short num3 = num;
						switch (num2)
						{
						case 0:
							if (global::ConstraintHelper.UtilityMack.IsFreonRadio)
							{
								num = (short)203358212;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							num = (short)933363713;
							if (num != 0)
							{
							}
							num = (short)1292500998;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 1:
							goto IL_282;
						case 2:
							if (general.RadInfoGeneralPrimaryFrequencyBandUHF2_A42547.Value)
							{
								num = (short)485425161;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							return true;
						case 3:
							num = (short)1536098312;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 4:
							num = (short)1795424258;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 5:
							num = (short)1026162695;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 6:
							if (radInfoLabtoolPrimaryBands_A.Value != 8)
							{
								num = (short)1950613507;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							goto IL_1AB;
						case 7:
							if (radInfoLabtoolSecondaryBands_A.Value == 8)
							{
								num = (short)120193025;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							return true;
						case 8:
							if (radInfoLabtoolDualBandEnable_A.Value)
							{
								num = (short)814678021;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							return true;
						case 9:
							goto IL_242;
						}
						goto IL_7F;
					}
					IL_1AB:
					num = (short)322984194;
					short num4 = num;
					num = (short)1333287170;
					switch ((num4 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						continue;
					default:
						goto IL_1E0;
					}
					IL_282:
					goto IL_1AB;
					IL_7F:
					global::Motorola.MackinawCPS.CoreFeatures.RadioInformation.RadioInformation radioInformation = self.Parent as global::Motorola.MackinawCPS.CoreFeatures.RadioInformation.RadioInformation;
					global::Motorola.MackinawCPS.CoreFeatures.RadioInformation.Labtool labtool = radioInformation.Labtool;
					general = radioInformation.General;
					frequencyRanges = (self as global::Motorola.MackinawCPS.CoreFeatures.RadioInformation.FrequencyRanges);
					radInfoLabtoolDualBandEnable_A = labtool.RadInfoLabtoolDualBandEnable_A23986;
					radInfoLabtoolPrimaryBands_A = labtool.RadInfoLabtoolPrimaryBands_A23987;
					radInfoLabtoolSecondaryBands_A = labtool.RadInfoLabtoolSecondaryBands_A23988;
					num = (short)644612096;
					num2 = (int)((global::System.IntPtr)num);
					goto IL_27;
				}
				IL_1E0:
				num = (short)1615855616;
				if (num != 0)
				{
				}
				return !frequencyRanges.RadInfoFrequencyRangesUHF2UsedinCodeplug_A8507.Value;
				IL_242:
				return !frequencyRanges.RadInfoFrequencyRangesUHF2UsedinCodeplug_A8507.Value;
			}
			}
		}

		// Token: 0x0600450B RID: 17675 RVA: 0x004007D4 File Offset: 0x003FE9D4
		internal static bool ConFrequencyRanage700MIsEditable(global::AcpCommonLib.IAcpFeatureSection self)
		{
			short num = (short)734658560;
			short num2 = num;
			global::Motorola.MackinawCPS.CoreFeatures.RadioInformation.General general = (self.Parent as global::Motorola.MackinawCPS.CoreFeatures.RadioInformation.RadioInformation).General;
			global::Motorola.MackinawCPS.CoreFeatures.RadioInformation.FrequencyRanges frequencyRanges = self as global::Motorola.MackinawCPS.CoreFeatures.RadioInformation.FrequencyRanges;
			if (general.RadInfoGeneralPrimaryFrequencyBand700_A42543.Value)
			{
				num = (short)852203185;
				short num3 = num;
				num = (short)1464374961;
				switch ((num3 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					break;
				default:
					num = (short)1996161024;
					if (num != 0)
					{
					}
					num = (short)1988165633;
					if (num != 0)
					{
					}
					return !frequencyRanges.RadInfoFrequencyRanges700MHzUsedinCodeplug_A42551.Value;
				}
			}
			return true;
		}

		// Token: 0x0600450C RID: 17676 RVA: 0x004008B8 File Offset: 0x003FEAB8
		internal static bool ConFrequencyRanage800MIsEditable(global::AcpCommonLib.IAcpFeatureSection self)
		{
			short num = (short)1368064000;
			short num2 = num;
			global::Motorola.MackinawCPS.CoreFeatures.RadioInformation.General general = (self.Parent as global::Motorola.MackinawCPS.CoreFeatures.RadioInformation.RadioInformation).General;
			global::Motorola.MackinawCPS.CoreFeatures.RadioInformation.FrequencyRanges frequencyRanges = self as global::Motorola.MackinawCPS.CoreFeatures.RadioInformation.FrequencyRanges;
			if (general.RadInfoGeneralPrimaryFrequencyBand800_A42544.Value)
			{
				num = (short)389545985;
				if (num != 0)
				{
				}
				num = (short)1555610066;
				short num3 = num;
				num = (short)1921432018;
				switch ((num3 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					break;
				default:
					num = (short)1691090944;
					if (num != 0)
					{
					}
					return !frequencyRanges.RadInfoFrequencyRanges800MHzUsedinCodeplug_A42552.Value;
				}
			}
			return true;
		}

		// Token: 0x0600450D RID: 17677 RVA: 0x00400998 File Offset: 0x003FEB98
		internal static bool ConFrequencyRanage7800MIsEditable(global::AcpCommonLib.IAcpFeatureSection self)
		{
			short num = (short)624230400;
			int num2 = (int)num;
			switch (num2)
			{
			default:
			{
				global::Motorola.MackinawCPS.CoreFeatures.RadioInformation.FrequencyRanges frequencyRanges;
				for (;;)
				{
					IL_1D:
					switch (0)
					{
					case 0:
						goto IL_46;
					}
					global::AcpBusinessLayer.AcpListField radInfoLabtoolPrimaryBands_A;
					global::AcpBusinessLayer.AcpListField radInfoLabtoolSecondaryBands_A;
					global::AcpBusinessLayer.AcpField<bool> radInfoLabtoolDualBandEnable_A;
					for (;;)
					{
						IL_27:
						switch (num2)
						{
						case 0:
							if (radInfoLabtoolPrimaryBands_A.Value != 1)
							{
								num = (short)1692401668;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							goto IL_A9;
						case 1:
						{
							num = (short)1506457190;
							short num3 = num;
							num = (short)2008135270;
							switch ((num3 == num) ? 1 : 0)
							{
							case 0:
							case 2:
								goto IL_1D;
							default:
								num = (short)1641283584;
								if (num != 0)
								{
								}
								if (radInfoLabtoolSecondaryBands_A.Value == 1)
								{
									num = (short)1113260032;
									short num4 = num;
									num = (short)489619458;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								return true;
							}
							break;
						}
						case 2:
							goto IL_16C;
						case 3:
							num = (short)1950875649;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 4:
							num = (short)525598725;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 5:
							num = (short)1706819585;
							if (num != 0)
							{
							}
							if (radInfoLabtoolDualBandEnable_A.Value)
							{
								num = (short)1077149699;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							return true;
						}
						break;
					}
					IL_46:
					global::Motorola.MackinawCPS.CoreFeatures.RadioInformation.Labtool labtool = (self.Parent as global::Motorola.MackinawCPS.CoreFeatures.RadioInformation.RadioInformation).Labtool;
					frequencyRanges = (self as global::Motorola.MackinawCPS.CoreFeatures.RadioInformation.FrequencyRanges);
					radInfoLabtoolDualBandEnable_A = labtool.RadInfoLabtoolDualBandEnable_A23986;
					radInfoLabtoolPrimaryBands_A = labtool.RadInfoLabtoolPrimaryBands_A23987;
					radInfoLabtoolSecondaryBands_A = labtool.RadInfoLabtoolSecondaryBands_A23988;
					num = (short)560594944;
					num2 = (int)((global::System.IntPtr)num);
					goto IL_27;
				}
				IL_A9:
				return !frequencyRanges.RadInfoFrequencyRanges7800MHzUsedinCodeplug_A8512.Value;
				IL_16C:
				goto IL_A9;
			}
			}
		}

		// Token: 0x0600450E RID: 17678 RVA: 0x00400B80 File Offset: 0x003FED80
		internal static bool ConFrequencyRanage8900MIsEditable(global::AcpCommonLib.IAcpFeatureSection self)
		{
			short num = (short)873594880;
			short num2 = num;
			global::Motorola.MackinawCPS.CoreFeatures.RadioInformation.Labtool labtool = (self.Parent as global::Motorola.MackinawCPS.CoreFeatures.RadioInformation.RadioInformation).Labtool;
			global::Motorola.MackinawCPS.CoreFeatures.RadioInformation.FrequencyRanges frequencyRanges = self as global::Motorola.MackinawCPS.CoreFeatures.RadioInformation.FrequencyRanges;
			global::AcpBusinessLayer.AcpListField radInfoLabtoolPrimaryBands_A = labtool.RadInfoLabtoolPrimaryBands_A23987;
			global::AcpBusinessLayer.AcpListField radInfoLabtoolSecondaryBands_A = labtool.RadInfoLabtoolSecondaryBands_A23988;
			if (radInfoLabtoolPrimaryBands_A.Value == 7)
			{
				num = (short)1176020442;
				short num3 = num;
				num = (short)932750810;
				switch ((num3 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					break;
				default:
					num = (short)2021851137;
					if (num != 0)
					{
					}
					num = (short)1379991552;
					if (num != 0)
					{
					}
					return !frequencyRanges.RadInfoFrequencyRanges8900MHzUsedinCodeplug_A42502.Value;
				}
			}
			return true;
		}

		// Token: 0x0600450F RID: 17679 RVA: 0x00400C6C File Offset: 0x003FEE6C
		internal static bool ConFrequencyRanage900MIsEditable(global::AcpCommonLib.IAcpFeatureSection self)
		{
			short num = (short)1760821248;
			int num2 = (int)num;
			switch (num2)
			{
			default:
			{
				switch (0)
				{
				case 0:
					goto IL_46;
				}
				global::AcpBusinessLayer.AcpListField radInfoLabtoolPrimaryBands_A;
				global::Motorola.MackinawCPS.CoreFeatures.RadioInformation.General general;
				for (;;)
				{
					IL_27:
					switch (num2)
					{
					case 0:
						if (global::ConstraintHelper.UtilityMack.IsFreonRadio)
						{
							num = (short)1541931012;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)640090113;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 1:
						if (radInfoLabtoolPrimaryBands_A.Value == 6)
						{
							num = (short)489422850;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_1BB;
					case 2:
						goto IL_12F;
					case 3:
						goto IL_19B;
					case 4:
					{
						num = (short)422982438;
						short num3 = num;
						num = (short)618935078;
						switch ((num3 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							return true;
						default:
							num = (short)1619394560;
							if (num != 0)
							{
							}
							num = (short)949354501;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						break;
					}
					case 5:
						num = (short)1917648897;
						if (num != 0)
						{
						}
						if (general.RadInfoGeneralPrimaryFrequencyBand900_A42548.Value)
						{
							num = (short)1777074179;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return true;
					}
					goto IL_46;
				}
				IL_12F:
				global::Motorola.MackinawCPS.CoreFeatures.RadioInformation.FrequencyRanges frequencyRanges;
				return !frequencyRanges.RadInfoFrequencyRanges900MHzUsedinCodeplug_A8516.Value;
				IL_19B:
				return !frequencyRanges.RadInfoFrequencyRanges900MHzUsedinCodeplug_A8516.Value;
				IL_1BB:
				num = (short)567083008;
				short num4 = num;
				return true;
				IL_46:
				global::Motorola.MackinawCPS.CoreFeatures.RadioInformation.RadioInformation radioInformation = self.Parent as global::Motorola.MackinawCPS.CoreFeatures.RadioInformation.RadioInformation;
				global::Motorola.MackinawCPS.CoreFeatures.RadioInformation.Labtool labtool = radioInformation.Labtool;
				general = radioInformation.General;
				frequencyRanges = (self as global::Motorola.MackinawCPS.CoreFeatures.RadioInformation.FrequencyRanges);
				radInfoLabtoolPrimaryBands_A = labtool.RadInfoLabtoolPrimaryBands_A23987;
				global::AcpBusinessLayer.AcpListField radInfoLabtoolSecondaryBands_A = labtool.RadInfoLabtoolSecondaryBands_A23988;
				num = (short)1499463680;
				num2 = (int)((global::System.IntPtr)num);
				goto IL_27;
			}
			}
		}
	}
}
