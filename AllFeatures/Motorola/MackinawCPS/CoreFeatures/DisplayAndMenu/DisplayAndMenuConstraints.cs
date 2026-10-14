using System;
using System.Collections.Generic;
using System.Linq;
using AcpBusinessLayer;
using AcpCommonLib;
using AllFeatures;
using Common;
using CommonResources;
using Features.Zone_Channel_Assignment;
using Motorola.MackinawCPS.CoreFeatures.RadioWide;
using Motorola.MackinawCPS.CoreFeatures.Tts;

namespace Motorola.MackinawCPS.CoreFeatures.DisplayAndMenu
{
	// Token: 0x02000275 RID: 629
	public static class DisplayAndMenuConstraints
	{
		// Token: 0x060070B5 RID: 28853 RVA: 0x006438D0 File Offset: 0x00641AD0
		internal static bool ConIdDispIsEnabled(global::AcpCommonLib.IAcpFeatureSection self)
		{
			switch (0)
			{
			case 0:
				goto IL_20;
			}
			short num2;
			global::Motorola.MackinawCPS.CoreFeatures.DisplayAndMenu.DisplayAndMenu displayAndMenu;
			for (;;)
			{
				IL_0A:
				int num;
				switch (num)
				{
				case 0:
					if (self.ParentRecset.IsEmbeddedRecset)
					{
						num2 = (short)1705902083;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					displayAndMenu = (self.Parent as global::Motorola.MackinawCPS.CoreFeatures.DisplayAndMenu.DisplayAndMenu);
					num2 = (short)276561922;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 1:
					goto IL_152;
				case 2:
					goto IL_F9;
				case 3:
					displayAndMenu = (self.ParentRecset.ParentSection.Parent as global::Motorola.MackinawCPS.CoreFeatures.DisplayAndMenu.DisplayAndMenu);
					num2 = (short)556400641;
					if (num2 != 0)
					{
					}
					num2 = (short)475660289;
					num = (int)((global::System.IntPtr)num2);
					continue;
				}
				goto IL_20;
			}
			IL_F9:
			IL_152:
			goto IL_154;
			IL_20:
			num2 = (short)1091468751;
			short num3 = num2;
			num2 = (short)889683407;
			switch ((num3 == num2) ? 1 : 0)
			{
			case 0:
			case 2:
				IL_154:
				return displayAndMenu.IDDisplay.DispMenuIDDisplayPTTIDDisplay_A8221.Value != 0;
			default:
			{
				num2 = (short)21430272;
				if (num2 != 0)
				{
				}
				num2 = (short)1519517696;
				short num4 = num2;
				displayAndMenu = null;
				num2 = (short)2124480512;
				int num = (int)((global::System.IntPtr)num2);
				goto IL_0A;
			}
			}
		}

		// Token: 0x060070B6 RID: 28854 RVA: 0x00643A44 File Offset: 0x00641C44
		internal static bool ConTstModPasswdEnable(global::AcpCommonLib.IAcpFeatureSection self)
		{
			short num = (short)959445287;
			short num2 = num;
			num = (short)1723660583;
			switch (num2 == num)
			{
			}
			num = (short)1878261761;
			if (num != 0)
			{
			}
			num = (short)348389376;
			if (num != 0)
			{
			}
			num = (short)2093875200;
			short num3 = num;
			return (self as global::Motorola.MackinawCPS.CoreFeatures.DisplayAndMenu.TestMode).DispMenuTestModeTestModePasswordEnabled_A4971.Value;
		}

		// Token: 0x060070B7 RID: 28855 RVA: 0x00643B00 File Offset: 0x00641D00
		internal static bool ConSetUpperLimitAsSlowScrollRate(global::AcpCommonLib.IAcpFeatureSection self)
		{
			short num = (short)834760219;
			short num2 = num;
			num = (short)1533832731;
			switch (num2 == num)
			{
			}
			num = (short)279248897;
			if (num != 0)
			{
			}
			num = (short)1082458112;
			if (num != 0)
			{
			}
			num = (short)2058420224;
			short num3 = num;
			global::Motorola.MackinawCPS.CoreFeatures.DisplayAndMenu.General general = self as global::Motorola.MackinawCPS.CoreFeatures.DisplayAndMenu.General;
			return general.DispMenuGeneralSlowScrollRatems_A9161.Value >= general.DispMenuGeneralFastScrollRatems_A8014.Value;
		}

		// Token: 0x060070B8 RID: 28856 RVA: 0x00643BCC File Offset: 0x00641DCC
		internal static bool conIsValueInRange3to120(global::AcpCommonLib.IAcpFeatureSection self)
		{
			short num;
			int num4;
			global::AcpBusinessLayer.AcpSimpleRangeField dispMenuAdvancedFeatureInactivityTimeoutSec_A;
			switch (0)
			{
			case 0:
				break;
			default:
				for (;;)
				{
					IL_0A:
					num = (short)363194456;
					short num2 = num;
					num = (short)1509222488;
					switch ((num2 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_A0;
					case 1:
						break;
					default:
					{
						num = (short)613810176;
						short num3 = num;
						break;
					}
					}
					num = (short)1912406016;
					if (num != 0)
					{
					}
					switch (num4)
					{
					case 0:
						num = (short)513409025;
						if (num != 0)
						{
						}
						if (dispMenuAdvancedFeatureInactivityTimeoutSec_A.Value >= 3)
						{
							num = (short)1182400515;
							num4 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_101;
					case 1:
						goto IL_146;
					case 2:
						if (dispMenuAdvancedFeatureInactivityTimeoutSec_A.Value > 120)
						{
							num = (short)420216833;
							num4 = (int)((global::System.IntPtr)num);
							continue;
						}
						return true;
					case 3:
						num = (short)1103626242;
						num4 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_94;
				}
				IL_101:
				return dispMenuAdvancedFeatureInactivityTimeoutSec_A.Value == 0;
				IL_146:
				goto IL_101;
			}
			IL_94:
			dispMenuAdvancedFeatureInactivityTimeoutSec_A = (self as global::Motorola.MackinawCPS.CoreFeatures.DisplayAndMenu.Advanced).DispMenuAdvancedFeatureInactivityTimeoutSec_A20011;
			IL_A0:
			num = (short)1331363840;
			num4 = (int)((global::System.IntPtr)num);
			goto IL_0A;
		}

		// Token: 0x060070B9 RID: 28857 RVA: 0x00643D24 File Offset: 0x00641F24
		internal static bool ConPrefixIDTxtLengthValid(global::AcpCommonLib.IAcpFeatureSection self)
		{
			short num = (short)799473664;
			short num2 = num;
			num = (short)1222707565;
			short num3 = num;
			num = (short)2103314797;
			global::Motorola.MackinawCPS.CoreFeatures.DisplayAndMenu.DisplayAndMenu displayAndMenu;
			global::AcpBusinessLayer.AcpFieldX<string, string> dispMenuIDDisplayID_A;
			switch ((num3 == num) ? 1 : 0)
			{
			case 0:
			case 2:
				break;
			default:
			{
				num = (short)1246429184;
				if (num != 0)
				{
				}
				global::Motorola.MackinawCPS.CoreFeatures.DisplayAndMenu.IDDisplayTableInnerSection iddisplayTableInnerSection = self as global::Motorola.MackinawCPS.CoreFeatures.DisplayAndMenu.IDDisplayTableInnerSection;
				displayAndMenu = (self.ParentRecset.ParentSection.Parent as global::Motorola.MackinawCPS.CoreFeatures.DisplayAndMenu.DisplayAndMenu);
				dispMenuIDDisplayID_A = iddisplayTableInnerSection.DispMenuIDDisplayID_A8738;
				if (dispMenuIDDisplayID_A.Value == null)
				{
					num = (short)1978728449;
					if (num != 0)
					{
					}
					return false;
				}
				break;
			}
			}
			return dispMenuIDDisplayID_A.Value.Length <= displayAndMenu.IDDisplay.PrefixIDTextSize_A22465.Value;
		}

		// Token: 0x060070BA RID: 28858 RVA: 0x00643E1C File Offset: 0x0064201C
		internal static bool ConFeatureInactivityAlertToneSelection(global::AcpCommonLib.IAcpFeatureSection self, int index)
		{
			switch (0)
			{
			case 0:
				goto IL_2C;
			}
			short num2;
			global::Motorola.MackinawCPS.CoreFeatures.DisplayAndMenu.Advanced advanced;
			bool result;
			for (;;)
			{
				IL_0A:
				int num;
				switch (num)
				{
				case 0:
				{
					num2 = (short)2011758592;
					short num3 = num2;
					if (index > 1)
					{
						num2 = (short)453378051;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_11D;
				}
				case 1:
					if (advanced.DispMenuAdvancedFeatureInactivityTimeoutSec_A20011 == 0)
					{
						num2 = (short)428867586;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					return result;
				case 2:
					result = false;
					num2 = (short)174587910;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 3:
					goto IL_D8;
				case 4:
					goto IL_11D;
				case 5:
					if (index == 3)
					{
						num2 = (short)1689780228;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					return result;
				case 6:
					return result;
				}
				goto IL_2C;
				IL_11D:
				num2 = (short)351207425;
				num = (int)((global::System.IntPtr)num2);
			}
			return result;
			IL_2C:
			advanced = (self as global::Motorola.MackinawCPS.CoreFeatures.DisplayAndMenu.Advanced);
			result = true;
			num2 = (short)1590078960;
			short num4 = num2;
			num2 = (short)1929096688;
			switch ((num4 == num2) ? 1 : 0)
			{
			case 0:
			case 2:
			{
				IL_D8:
				num2 = (short)846659585;
				if (num2 != 0)
				{
				}
				num2 = (short)1016332293;
				int num = (int)((global::System.IntPtr)num2);
				goto IL_0A;
			}
			default:
			{
				num2 = (short)456654848;
				if (num2 != 0)
				{
				}
				num2 = (short)1909784576;
				int num = (int)((global::System.IntPtr)num2);
				goto IL_0A;
			}
			}
		}

		// Token: 0x060070BB RID: 28859 RVA: 0x00643FBC File Offset: 0x006421BC
		internal static bool ConPretendColorIsEditable(global::AcpCommonLib.IAcpFeatureSection self)
		{
			short num = (short)427294720;
			short num2 = num;
			num = (short)1778740728;
			short num3 = num;
			num = (short)1928696;
			switch ((num3 == num) ? 1 : 0)
			{
			case 0:
			case 2:
				break;
			default:
			{
				num = (short)350093313;
				if (num != 0)
				{
				}
				num = (short)184483840;
				if (num != 0)
				{
				}
				global::AcpCommonLib.IAcpFeatureNode parent = (self as global::Motorola.MackinawCPS.CoreFeatures.DisplayAndMenu.BacklightColorsInnerSection).DispMenuLabtoolColorText1_A7689.Parent.Parent;
				int num4 = (parent.Parent as global::AcpBusinessLayer.Recordset).IndexOf(parent);
				if (num4 >= 4)
				{
					return num4 <= 9;
				}
				break;
			}
			}
			return false;
		}

		// Token: 0x060070BC RID: 28860 RVA: 0x006440A0 File Offset: 0x006422A0
		internal static bool ConCheckDefaultColorisValidity(global::AcpCommonLib.IAcpFeatureSection self, int index)
		{
			short num = (short)943849472;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				switch (num2)
				{
				case 0:
					goto IL_16;
				case 1:
					return true;
				case 2:
				{
					num = (short)359308677;
					short num3 = num;
					num = (short)1891868037;
					switch ((num3 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_16;
					default:
						num = (short)138477568;
						if (num != 0)
						{
						}
						if (index < 5)
						{
							num = (short)186843137;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return false;
					}
					break;
				}
				case 3:
					num = (short)1656094721;
					if (num != 0)
					{
					}
					num = (short)1200291842;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				goto IL_36;
				IL_16:
				switch (0)
				{
				case 0:
				{
					IL_36:
					if (index < 0)
					{
						return false;
					}
					num = (short)2138570752;
					short num4 = num;
					num = (short)2014380035;
					num2 = (int)((global::System.IntPtr)num);
					break;
				}
				}
			}
			return true;
		}

		// Token: 0x060070BD RID: 28861 RVA: 0x006441D8 File Offset: 0x006423D8
		internal static bool ConDisplayMenuTimerIsnotInfinite(global::AcpCommonLib.IAcpFeatureSection self)
		{
			short num = (short)32660364;
			short num2 = num;
			num = (short)1539005324;
			switch (num2 == num)
			{
			}
			num = (short)705232896;
			if (num != 0)
			{
			}
			num = (short)1976107009;
			if (num != 0)
			{
			}
			num = (short)1050017792;
			short num3 = num;
			return (self as global::Motorola.MackinawCPS.CoreFeatures.DisplayAndMenu.Advanced).AdvancedDisplayLightTimeSec_A7875.Value != 0;
		}

		// Token: 0x060070BE RID: 28862 RVA: 0x00644298 File Offset: 0x00642498
		public static bool conSetOutputMesgForChinese(global::AcpCommonLib.IAcpFeatureSection self)
		{
			switch (0)
			{
			case 0:
				goto IL_59;
			}
			short num;
			int num3;
			string id_RADIOFRONTDISPLAYONLYSUPPORTS8CHARACTERSWHENINARABICDIACRITICCHARACTERSARENOTSUPPORTED;
			string id_CPSALLOWSENTRYOFMORECHARACTERSTHANCANBEDISPLAYEDINTHERADIOFORTHESELECTEDLANGUAGEREFERTOTHEHELPFORMOREINFO;
			for (;;)
			{
				IL_0A:
				num = (short)1139539968;
				short num2 = num;
				switch (num3)
				{
				case 0:
					goto IL_7A;
				case 1:
					goto IL_17E;
				case 2:
					if (!global::AcpCommonLib.AppInfoManager.StatusMsgReport.ContainsField(id_RADIOFRONTDISPLAYONLYSUPPORTS8CHARACTERSWHENINARABICDIACRITICCHARACTERSARENOTSUPPORTED))
					{
						num = (short)1319763969;
						if (num != 0)
						{
						}
						num = (short)2107113479;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_237;
				case 3:
					if (global::AcpCommonLib.AppInfoManager.StatusMsgReport.ContainsField(id_RADIOFRONTDISPLAYONLYSUPPORTS8CHARACTERSWHENINARABICDIACRITICCHARACTERSARENOTSUPPORTED))
					{
						num = (short)957480966;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_237;
				case 4:
					num = (short)883752962;
					num3 = (int)((global::System.IntPtr)num);
					continue;
				case 5:
					goto IL_235;
				case 6:
				{
					num = (short)168265091;
					short num4 = num;
					num = (short)173180291;
					switch ((num4 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_7A;
					default:
						num = (short)561840128;
						if (num != 0)
						{
						}
						global::AcpCommonLib.AppInfoManager.StatusMsgReport.UnregisterMessage(id_RADIOFRONTDISPLAYONLYSUPPORTS8CHARACTERSWHENINARABICDIACRITICCHARACTERSARENOTSUPPORTED);
						num = (short)816709637;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					}
					break;
				}
				case 7:
					global::AcpCommonLib.AppInfoManager.StatusMsgReport.RegisterMessage(global::AcpCommonLib.StatusMsgType.Info, id_RADIOFRONTDISPLAYONLYSUPPORTS8CHARACTERSWHENINARABICDIACRITICCHARACTERSARENOTSUPPORTED);
					num = (short)943980545;
					num3 = (int)((global::System.IntPtr)num);
					continue;
				}
				goto IL_59;
				IL_7A:
				global::Motorola.MackinawCPS.CoreFeatures.DisplayAndMenu.Advanced advanced = self as global::Motorola.MackinawCPS.CoreFeatures.DisplayAndMenu.Advanced;
				if (advanced.DispMenuAdvancedLanguageSelection_A8386.Value == 7)
				{
					if (!global::AcpCommonLib.AppInfoManager.StatusMsgReport.ContainsField(id_CPSALLOWSENTRYOFMORECHARACTERSTHANCANBEDISPLAYEDINTHERADIOFORTHESELECTEDLANGUAGEREFERTOTHEHELPFORMOREINFO))
					{
						global::AcpCommonLib.AppInfoManager.StatusMsgReport.RegisterMessage(global::AcpCommonLib.StatusMsgType.Info, id_CPSALLOWSENTRYOFMORECHARACTERSTHANCANBEDISPLAYEDINTHERADIOFORTHESELECTEDLANGUAGEREFERTOTHEHELPFORMOREINFO);
					}
				}
				else if (global::AcpCommonLib.AppInfoManager.StatusMsgReport.ContainsField(id_CPSALLOWSENTRYOFMORECHARACTERSTHANCANBEDISPLAYEDINTHERADIOFORTHESELECTEDLANGUAGEREFERTOTHEHELPFORMOREINFO))
				{
					global::AcpCommonLib.AppInfoManager.StatusMsgReport.UnregisterMessage(id_CPSALLOWSENTRYOFMORECHARACTERSTHANCANBEDISPLAYEDINTHERADIOFORTHESELECTEDLANGUAGEREFERTOTHEHELPFORMOREINFO);
				}
				if (advanced.DispMenuAdvancedLanguageSelection_A8386.Value == 8)
				{
					num = (short)1026359300;
					num3 = (int)((global::System.IntPtr)num);
				}
				else
				{
					num = (short)1747845123;
					num3 = (int)((global::System.IntPtr)num);
				}
			}
			IL_17E:
			IL_235:
			IL_237:
			global::Motorola.MackinawCPS.CoreFeatures.DisplayAndMenu.DisplayAndMenuConstraints.a();
			global::Motorola.MackinawCPS.CoreFeatures.Tts.TTSUtils.RunTTSAudioLenCheck();
			return true;
			IL_59:
			id_CPSALLOWSENTRYOFMORECHARACTERSTHANCANBEDISPLAYEDINTHERADIOFORTHESELECTEDLANGUAGEREFERTOTHEHELPFORMOREINFO = global::CommonResources.AcgResources.ID_CPSALLOWSENTRYOFMORECHARACTERSTHANCANBEDISPLAYEDINTHERADIOFORTHESELECTEDLANGUAGEREFERTOTHEHELPFORMOREINFO;
			id_RADIOFRONTDISPLAYONLYSUPPORTS8CHARACTERSWHENINARABICDIACRITICCHARACTERSARENOTSUPPORTED = global::CommonResources.AcgResources.ID_RADIOFRONTDISPLAYONLYSUPPORTS8CHARACTERSWHENINARABICDIACRITICCHARACTERSARENOTSUPPORTED;
			num = (short)794755072;
			num3 = (int)((global::System.IntPtr)num);
			goto IL_0A;
		}

		// Token: 0x060070BF RID: 28863 RVA: 0x006444E8 File Offset: 0x006426E8
		private static void a()
		{
			short num = (short)867434496;
			int num2 = (int)num;
			switch (num2)
			{
			default:
			{
				switch (0)
				{
				case 0:
					goto IL_54;
				}
				int num3;
				global::AcpCommonLib.IAcpRecordset feature;
				global::System.Collections.Generic.List<global::AcpCommonLib.IAcpFeatureSection> list;
				global::System.Collections.Generic.Dictionary<string, global::System.Collections.Generic.List<string>>.Enumerator enumerator;
				for (;;)
				{
					IL_29:
					global::AcpCommonLib.IAcpRecordset a_;
					switch (num2)
					{
					case 0:
						if (num3 >= feature.Count)
						{
							num = (short)1635713027;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)1190920193;
						if (num != 0)
						{
						}
						num = (short)24838149;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 1:
						goto IL_1C8;
					case 2:
						a_ = null;
						goto IL_122;
					case 3:
						num = (short)232062983;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 4:
						goto IL_1C8;
					case 5:
					{
						global::AcpCommonLib.IAcpFeatureSection acpFeatureSection = feature[num3].FeatureSectionsCollection.ToList<global::AcpCommonLib.IAcpFeatureSection>().FirstOrDefault(delegate(global::AcpCommonLib.IAcpFeatureSection j)
						{
							int a_2 = 6;
							short num6 = (short)1905364160;
							short num7 = num6;
							num6 = (short)1427672256;
							switch (num7 == num6)
							{
							}
							num6 = (short)454885377;
							if (num6 != 0)
							{
							}
							num6 = (short)537985024;
							short num8 = num6;
							num6 = (short)2130051072;
							if (num6 != 0)
							{
							}
							return j.FeatureSectionName.Contains(global::AllFeatures.CodeplugGuid.b("蓆ꇈ꫊ꏌꇎ듐뿒ꛔ", a_2));
						});
						if (acpFeatureSection == null)
						{
							num = (short)44498946;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						a_ = acpFeatureSection.EmbeddedRecset;
						goto IL_122;
					}
					case 6:
						goto IL_275;
					case 7:
						enumerator = global::Features.Zone_Channel_Assignment.VoiceAnnouncementCollisionChecker.GlobalConfusabilityMap(list.Select(delegate(global::AcpCommonLib.IAcpFeatureSection jk)
						{
							short num6 = (short)293797889;
							if (num6 != 0)
							{
							}
							num6 = (short)1156459096;
							short num7 = num6;
							num6 = (short)1448946264;
							switch (num7 == num6)
							{
							}
							num6 = (short)93126656;
							short num8 = num6;
							num6 = (short)878903296;
							if (num6 != 0)
							{
							}
							global::AcpCommonLib.IAcpField acpField = jk.FieldsCollection.FirstOrDefault(delegate(global::AcpCommonLib.IAcpField k)
							{
								short num9 = (short)817552622;
								short num10 = num9;
								num9 = (short)572644590;
								switch (num10 == num9)
								{
								}
								num9 = (short)571998208;
								if (num9 != 0)
								{
								}
								num9 = (short)547553280;
								short num11 = num9;
								num9 = (short)655884289;
								if (num9 != 0)
								{
								}
								return k.Name.Contains(global::Motorola.MackinawCPS.CoreFeatures.DisplayAndMenu.DisplayAndMenuConstraints.a);
							});
							if (acpField == null)
							{
								return null;
							}
							return acpField.ToString();
						}), global::Features.Zone_Channel_Assignment.VoiceAnnouncementCollisionChecker.GetLanguageCode()).GetEnumerator();
						num = (short)1709113350;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 8:
					{
						global::AcpCommonLib.IAcpFeatureSection item = feature[num3].FeatureSectionsCollection.ToList<global::AcpCommonLib.IAcpFeatureSection>().FirstOrDefault(delegate(global::AcpCommonLib.IAcpFeatureSection j)
						{
							int a_2 = 2;
							short num6 = (short)2121031910;
							short num7 = num6;
							num6 = (short)2123129062;
							switch (num7 == num6)
							{
							}
							num6 = (short)971636737;
							if (num6 != 0)
							{
							}
							num6 = (short)1659437056;
							short num8 = num6;
							num6 = (short)2109931520;
							if (num6 != 0)
							{
							}
							return j.FeatureSectionName.Contains(global::AllFeatures.CodeplugGuid.b("駂꫄꧆곈", a_2));
						});
						list.Add(item);
						num3++;
						num = (short)2113601536;
						short num4 = num;
						num = (short)1606483972;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					}
					goto IL_54;
					IL_122:
					global::Motorola.MackinawCPS.CoreFeatures.DisplayAndMenu.DisplayAndMenuConstraints.a(a_);
					num = (short)723451912;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_1C8:
					num = (short)227409920;
					num2 = (int)((global::System.IntPtr)num);
				}
				IL_275:
				try
				{
					num = (short)1690566658;
					num2 = (int)((global::System.IntPtr)num);
					for (;;)
					{
						switch (num2)
						{
						case 0:
						{
							if (!enumerator.MoveNext())
							{
								num = (short)1815150595;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							global::System.Collections.Generic.KeyValuePair<string, global::System.Collections.Generic.List<string>> keyValuePair = enumerator.Current;
							num = (short)972739488;
							short num5 = num;
							num = (short)1724699552;
							switch ((num5 == num) ? 1 : 0)
							{
							case 0:
							case 2:
								goto IL_492;
							default:
								num = (short)1912012800;
								if (num != 0)
								{
								}
								num = (short)1850146817;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							break;
						}
						case 1:
							if (CS$<>8__locals1.keyValuePair.Value.Count > 0)
							{
								num = (short)1486028804;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							num = (short)977076230;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 2:
							switch (0)
							{
							case 0:
								goto IL_2C6;
							}
							continue;
						case 3:
							num = (short)1926103047;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 4:
							num = (short)1122304009;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 6:
							list.FirstOrDefault(delegate(global::AcpCommonLib.IAcpFeatureSection k)
							{
								short num6 = (short)1387054929;
								short num7 = num6;
								num6 = (short)893634385;
								switch (num7 == num6)
								{
								}
								num6 = (short)1799684097;
								if (num6 != 0)
								{
								}
								num6 = (short)1038221312;
								short num8 = num6;
								num6 = (short)862126080;
								if (num6 != 0)
								{
								}
								return k.FieldsCollection.FirstOrDefault(delegate(global::AcpCommonLib.IAcpField kk)
								{
									short num9 = (short)798527414;
									short num10 = num9;
									num9 = (short)264474550;
									switch (num10 == num9)
									{
									}
									num9 = (short)2053767169;
									if (num9 != 0)
									{
									}
									num9 = (short)1219493888;
									short num11 = num9;
									num9 = (short)2020409344;
									if (num9 != 0)
									{
									}
									return kk.Name.Contains(global::Motorola.MackinawCPS.CoreFeatures.DisplayAndMenu.DisplayAndMenuConstraints.a);
								}).ToString().Equals(CS$<>8__locals1.keyValuePair.Key);
							}).FieldsCollection.FirstOrDefault(delegate(global::AcpCommonLib.IAcpField kkk)
							{
								short num6 = (short)1238199744;
								short num7 = num6;
								num6 = (short)1002728896;
								switch (num7 == num6)
								{
								}
								num6 = (short)1107755008;
								if (num6 != 0)
								{
								}
								num6 = (short)444137472;
								short num8 = num6;
								num6 = (short)262602753;
								if (num6 != 0)
								{
								}
								return kkk.Name.Contains(global::Motorola.MackinawCPS.CoreFeatures.DisplayAndMenu.DisplayAndMenuConstraints.a);
							}).Valid = true;
							num = (short)796524549;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 7:
							goto IL_4C5;
						case 9:
							list.FirstOrDefault(delegate(global::AcpCommonLib.IAcpFeatureSection k)
							{
								short num6 = (short)754515969;
								if (num6 != 0)
								{
								}
								num6 = (short)1441976443;
								short num7 = num6;
								num6 = (short)1643761787;
								switch (num7 == num6)
								{
								}
								num6 = (short)420741120;
								short num8 = num6;
								num6 = (short)1328021504;
								if (num6 != 0)
								{
								}
								return k.FieldsCollection.FirstOrDefault(delegate(global::AcpCommonLib.IAcpField kk)
								{
									short num9 = (short)543411608;
									short num10 = num9;
									num9 = (short)654626200;
									switch (num10 == num9)
									{
									}
									num9 = (short)214499329;
									if (num9 != 0)
									{
									}
									num9 = (short)1335623680;
									short num11 = num9;
									num9 = (short)962002944;
									if (num9 != 0)
									{
									}
									return kk.Name.Contains(global::Motorola.MackinawCPS.CoreFeatures.DisplayAndMenu.DisplayAndMenuConstraints.a);
								}).ToString().Equals(CS$<>8__locals1.keyValuePair.Key);
							}).FieldsCollection.FirstOrDefault(delegate(global::AcpCommonLib.IAcpField kkk)
							{
								short num6 = (short)1399507302;
								short num7 = num6;
								num6 = (short)510839142;
								switch (num7 == num6)
								{
								}
								num6 = (short)23003137;
								if (num6 != 0)
								{
								}
								num6 = (short)1812987904;
								short num8 = num6;
								num6 = (short)1217265664;
								if (num6 != 0)
								{
								}
								return kkk.Name.Contains(global::Motorola.MackinawCPS.CoreFeatures.DisplayAndMenu.DisplayAndMenuConstraints.a);
							}).Valid = false;
							goto IL_492;
						}
						IL_448:
						num = (short)343015424;
						num2 = (int)((global::System.IntPtr)num);
						continue;
						IL_2C6:
						goto IL_448;
						IL_492:
						num = (short)996737032;
						num2 = (int)((global::System.IntPtr)num);
					}
					IL_4C5:;
				}
				finally
				{
					((global::System.IDisposable)enumerator).Dispose();
				}
				return;
				IL_54:
				feature = global::AcpCommonLib.FeatureManager.GetFeature(2051);
				list = new global::System.Collections.Generic.List<global::AcpCommonLib.IAcpFeatureSection>();
				num3 = 0;
				num = (short)273547265;
				num2 = (int)((global::System.IntPtr)num);
				goto IL_29;
			}
			}
		}

		// Token: 0x060070C0 RID: 28864 RVA: 0x006449E8 File Offset: 0x00642BE8
		private static void a(global::AcpCommonLib.IAcpRecordset A_0)
		{
			short num = (short)408748032;
			int num2 = (int)num;
			switch (num2)
			{
			default:
			{
				switch (0)
				{
				case 0:
					goto IL_77;
				}
				int num4;
				global::System.Collections.Generic.List<global::AcpCommonLib.IAcpField> list;
				global::System.Collections.Generic.Dictionary<string, global::System.Collections.Generic.List<string>>.Enumerator enumerator;
				for (;;)
				{
					IL_27:
					num = (short)310050816;
					short num3 = num;
					global::AcpCommonLib.IAcpField acpField;
					switch (num2)
					{
					case 0:
						goto IL_13E;
					case 1:
						if (num4 >= A_0.Count)
						{
							num = (short)1910964227;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)1517158404;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 2:
						acpField = null;
						goto IL_118;
					case 3:
						num = (short)1356464134;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 4:
					{
						global::AcpCommonLib.IAcpFeatureSection acpFeatureSection = A_0[num4].FeatureSectionsCollection.ToList<global::AcpCommonLib.IAcpFeatureSection>().FirstOrDefault<global::AcpCommonLib.IAcpFeatureSection>();
						if (acpFeatureSection == null)
						{
							num = (short)1903755266;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						acpField = acpFeatureSection.FieldsCollection.FirstOrDefault(delegate(global::AcpCommonLib.IAcpField ii)
						{
							int a_ = 11;
							short num6 = (short)231452001;
							short num7 = num6;
							num6 = (short)394440033;
							switch (num7 == num6)
							{
							}
							num6 = (short)701956097;
							if (num6 != 0)
							{
							}
							num6 = (short)724369408;
							short num8 = num6;
							num6 = (short)1134297088;
							if (num6 != 0)
							{
							}
							return ii.Name.Contains(global::AllFeatures.CodeplugGuid.b("髋跍鏏뫑뗓룕뛗뿙냛鿝軟賡诣鏥蛧觩觫菭闯鳱胳꧵맷죹쳻쿽㟿㐁", a_));
						});
						goto IL_118;
					}
					case 5:
						goto IL_211;
					case 6:
						enumerator = global::Features.Zone_Channel_Assignment.VoiceAnnouncementCollisionChecker.GlobalConfusabilityMap(list.Select(delegate(global::AcpCommonLib.IAcpField field)
						{
							short num6 = (short)1563928978;
							short num7 = num6;
							num6 = (short)1254795666;
							switch (num7 == num6)
							{
							}
							num6 = (short)350027777;
							if (num6 != 0)
							{
							}
							num6 = (short)2136408064;
							short num8 = num6;
							num6 = (short)577568768;
							if (num6 != 0)
							{
							}
							return field.ToString();
						}), global::Features.Zone_Channel_Assignment.VoiceAnnouncementCollisionChecker.GetLanguageCode()).GetEnumerator();
						num = (short)1975648257;
						if (num != 0)
						{
						}
						num = (short)516816901;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 7:
						goto IL_13E;
					}
					goto IL_77;
					IL_118:
					global::AcpCommonLib.IAcpField item = acpField;
					list.Add(item);
					num4++;
					num = (short)1528496135;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_13E:
					num = (short)1360003073;
					num2 = (int)((global::System.IntPtr)num);
				}
				IL_211:
				try
				{
					num = (short)265420800;
					num2 = (int)((global::System.IntPtr)num);
					for (;;)
					{
						switch (num2)
						{
						case 0:
							switch (0)
							{
							case 0:
								goto IL_25A;
							}
							continue;
						case 1:
						{
							if (!enumerator.MoveNext())
							{
								num = (short)857473031;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							global::System.Collections.Generic.KeyValuePair<string, global::System.Collections.Generic.List<string>> keyValuePair = enumerator.Current;
							num = (short)1483800581;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						case 4:
							list.FirstOrDefault(delegate(global::AcpCommonLib.IAcpField ii)
							{
								short num6 = (short)779917297;
								short num7 = num6;
								num6 = (short)897554417;
								switch (num7 == num6)
								{
								}
								num6 = (short)2076508161;
								if (num6 != 0)
								{
								}
								num6 = (short)1504116736;
								short num8 = num6;
								num6 = (short)1263009792;
								if (num6 != 0)
								{
								}
								return ii.ToString() == CS$<>8__locals1.keyValuePair.Key;
							}).Valid = false;
							num = (short)1044054018;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 5:
							if (CS$<>8__locals1.keyValuePair.Value.Count > 0)
							{
								num = (short)453705732;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							list.FirstOrDefault(delegate(global::AcpCommonLib.IAcpField iii)
							{
								short num6 = (short)1361707009;
								if (num6 != 0)
								{
								}
								num6 = (short)800782212;
								short num7 = num6;
								num6 = (short)1731393412;
								switch (num7 == num6)
								{
								}
								num6 = (short)1886257152;
								short num8 = num6;
								num6 = (short)1140326400;
								if (num6 != 0)
								{
								}
								return iii.ToString() == CS$<>8__locals1.keyValuePair.Key;
							}).Valid = true;
							num = (short)1992622083;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 6:
							goto IL_3CC;
						case 7:
							num = (short)1209532422;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						IL_25C:
						num = (short)1617699197;
						short num5 = num;
						num = (short)474030461;
						switch ((num5 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_3CC;
						default:
							num = (short)1991245824;
							if (num != 0)
							{
							}
							num = (short)609157121;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						IL_25A:
						goto IL_25C;
					}
					IL_3CC:;
				}
				finally
				{
					((global::System.IDisposable)enumerator).Dispose();
				}
				return;
				IL_77:
				list = new global::System.Collections.Generic.List<global::AcpCommonLib.IAcpField>();
				num4 = 0;
				num = (short)1594032128;
				num2 = (int)((global::System.IntPtr)num);
				goto IL_27;
			}
			}
		}

		// Token: 0x060070C1 RID: 28865 RVA: 0x00644DF0 File Offset: 0x00642FF0
		internal static bool conFeatureInactivityTimeoutIsInfinite(global::AcpCommonLib.IAcpFeatureSection self)
		{
			short num = (short)1619111607;
			short num2 = num;
			num = (short)1177792183;
			switch (num2 == num)
			{
			}
			num = (short)1102839808;
			if (num != 0)
			{
			}
			num = (short)1364459520;
			short num3 = num;
			num = (short)2060517377;
			if (num != 0)
			{
			}
			return (self as global::Motorola.MackinawCPS.CoreFeatures.DisplayAndMenu.Advanced).DispMenuAdvancedFeatureInactivityTimeoutSec_A20011.Value == 0;
		}

		// Token: 0x060070C2 RID: 28866 RVA: 0x00644EAC File Offset: 0x006430AC
		internal static bool ConSaveDayNightModeApp(global::AcpCommonLib.IAcpFeatureSection self)
		{
			short num = (short)402909084;
			short num2 = num;
			num = (short)159180700;
			switch (num2 == num)
			{
			}
			num = (short)1167196161;
			if (num != 0)
			{
			}
			num = (short)1237975040;
			short num3 = num;
			num = (short)1829306368;
			if (num != 0)
			{
			}
			return (self as global::Motorola.MackinawCPS.CoreFeatures.DisplayAndMenu.General).RefRadioWide.DualRadio.RadWideDualRadioSelection_A42236.Value != 2;
		}

		// Token: 0x060070C3 RID: 28867 RVA: 0x00644F74 File Offset: 0x00643174
		internal static bool ConPTTIdOrDisplayPeerLocationIsEnabled(global::AcpCommonLib.IAcpFeatureSection self)
		{
			short num = (short)1793982464;
			short num2 = num;
			num = (short)1128464385;
			if (num != 0)
			{
			}
			global::Motorola.MackinawCPS.CoreFeatures.DisplayAndMenu.IDDisplay iddisplay = self as global::Motorola.MackinawCPS.CoreFeatures.DisplayAndMenu.IDDisplay;
			if (iddisplay.DispMenuIDDisplayPTTIDDisplay_A8221.Value == 0)
			{
				num = (short)188207090;
				short num3 = num;
				num = (short)1427492850;
				switch ((num3 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					break;
				default:
					num = (short)1452277760;
					if (num != 0)
					{
					}
					return iddisplay.RefRadioWide.Location.RadWideLocationDisplayPeerLocation_42433;
				}
			}
			return true;
		}

		// Token: 0x060070C4 RID: 28868 RVA: 0x00645048 File Offset: 0x00643248
		internal static bool ConRadioDisplyLanguageLovVisibleForVertex(global::AcpCommonLib.IAcpFeatureSection self)
		{
			int a_ = 13;
			switch (0)
			{
			case 0:
				goto IL_3D;
			}
			int num;
			short num2;
			global::Motorola.MackinawCPS.CoreFeatures.DisplayAndMenu.Advanced advanced;
			for (;;)
			{
				IL_13:
				int num3;
				switch (num)
				{
				case 0:
					if (!global::Common.Product.IsVertex())
					{
						num2 = (short)584122370;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					num3 = 0;
					goto IL_1B6;
				case 1:
				{
					if (num3 < advanced.DispMenuAdvancedLanguageSelection_A8386.Items.Count)
					{
						num2 = (short)1692598276;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					num2 = (short)717837445;
					short num4 = num2;
					num2 = (short)1007441029;
					switch ((num4 == num2) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_1B6;
					default:
						num2 = (short)294715393;
						if (num2 != 0)
						{
						}
						num2 = (short)2026897408;
						if (num2 != 0)
						{
						}
						num2 = (short)625082374;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					break;
				}
				case 2:
					return true;
				case 3:
					advanced.DispMenuAdvancedLanguageSelection_A8386.Items[num3].ItemVisibility = false;
					num2 = (short)247463943;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 4:
					if (!advanced.DispMenuAdvancedLanguageSelection_A8386.Items[num3].ItemName.Contains(global::AllFeatures.CodeplugGuid.b("词뻏뗑룓뿕ꯗ닙", a_)))
					{
						num2 = (short)901447683;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_7A;
				case 5:
					goto IL_F5;
				case 6:
					return true;
				case 7:
					goto IL_7A;
				case 8:
					goto IL_F5;
				}
				goto IL_3D;
				IL_7A:
				num3++;
				num2 = (short)2114912264;
				num = (int)((global::System.IntPtr)num2);
				continue;
				IL_F5:
				num2 = (short)132841473;
				num = (int)((global::System.IntPtr)num2);
				continue;
				IL_1B6:
				num2 = (short)887947264;
				short num5 = num2;
				num2 = (short)323616773;
				num = (int)((global::System.IntPtr)num2);
			}
			return true;
			IL_3D:
			advanced = (self as global::Motorola.MackinawCPS.CoreFeatures.DisplayAndMenu.Advanced);
			num2 = (short)1045889024;
			num = (int)((global::System.IntPtr)num2);
			goto IL_13;
		}

		// Token: 0x060070C5 RID: 28869 RVA: 0x0064528C File Offset: 0x0064348C
		internal static bool ConChannelColorBacklightApplicable(global::AcpCommonLib.IAcpFeatureSection self)
		{
			switch (0)
			{
			case 0:
				goto IL_20;
			}
			int num;
			global::Motorola.MackinawCPS.CoreFeatures.RadioWide.RadioWide radioWide;
			short num2;
			for (;;)
			{
				IL_0A:
				switch (num)
				{
				case 0:
					if (radioWide.DualRadio.RadWideDualRadioSelection_A42236.Value != 0)
					{
						num2 = (short)190644225;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					return false;
				case 1:
				{
					num2 = (short)785186816;
					short num3 = num2;
					num2 = (short)1605194203;
					short num4 = num2;
					num2 = (short)1908232667;
					switch ((num4 == num2) ? 1 : 0)
					{
					case 0:
					case 2:
						continue;
					default:
						goto IL_10B;
					}
					break;
				}
				case 2:
					if (radioWide.DualRadio.RadWideDualRadioSelection_A42236.Value != 0)
					{
						num2 = (short)45285379;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					return true;
				case 3:
					num2 = (short)320012288;
					num = (int)((global::System.IntPtr)num2);
					continue;
				}
				goto IL_20;
			}
			return false;
			IL_10B:
			num2 = (short)1954742272;
			if (num2 != 0)
			{
			}
			global::Motorola.MackinawCPS.CoreFeatures.DisplayAndMenu.Advanced advanced;
			return advanced.RadioErgDispAdvanceChannelColorBacklight_43747.Value != 0;
			IL_20:
			num2 = (short)929824769;
			if (num2 != 0)
			{
			}
			advanced = (self as global::Motorola.MackinawCPS.CoreFeatures.DisplayAndMenu.Advanced);
			radioWide = (global::AcpCommonLib.FeatureManager.GetFeature(2045)[0] as global::Motorola.MackinawCPS.CoreFeatures.RadioWide.RadioWide);
			num2 = (short)1205862402;
			num = (int)((global::System.IntPtr)num2);
			goto IL_0A;
		}

		// Token: 0x060070C6 RID: 28870 RVA: 0x00645414 File Offset: 0x00643614
		internal static bool ConChannelColorBacklightIndexValid(global::AcpCommonLib.IAcpFeatureSection self, int index)
		{
			switch (0)
			{
			case 0:
				goto IL_24;
			}
			int num;
			global::Motorola.MackinawCPS.CoreFeatures.RadioWide.RadioWide radioWide;
			short num2;
			bool result;
			for (;;)
			{
				IL_0A:
				switch (num)
				{
				case 0:
					if (radioWide.DualRadio.RadWideDualRadioSelection_A42236 != 0)
					{
						num2 = (short)854458371;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					return result;
				case 1:
					if (index - 1 <= 1)
					{
						num2 = (short)1390804996;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					return result;
				case 2:
					return result;
				case 3:
					result = false;
					num2 = (short)375390210;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 4:
				{
					num2 = (short)1530170501;
					short num3 = num2;
					num2 = (short)723356805;
					switch ((num3 == num2) ? 1 : 0)
					{
					case 0:
					case 2:
						continue;
					default:
						num2 = (short)84869120;
						if (num2 != 0)
						{
						}
						num2 = (short)561184768;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					break;
				}
				}
				goto IL_24;
			}
			return result;
			IL_24:
			num2 = (short)575602689;
			if (num2 != 0)
			{
			}
			num2 = (short)952827904;
			short num4 = num2;
			radioWide = (global::AcpCommonLib.FeatureManager.GetFeature(2045)[0] as global::Motorola.MackinawCPS.CoreFeatures.RadioWide.RadioWide);
			result = true;
			num2 = (short)295698433;
			num = (int)((global::System.IntPtr)num2);
			goto IL_0A;
		}

		// Token: 0x060070C7 RID: 28871 RVA: 0x0064559C File Offset: 0x0064379C
		// Note: this type is marked as 'beforefieldinit'.
		static DisplayAndMenuConstraints()
		{
			int a_ = 0;
			short num = (short)1381302273;
			if (num != 0)
			{
			}
			num = (short)1800054237;
			short num2 = num;
			num = (short)123315677;
			switch (num2 == num)
			{
			}
			num = (short)2090729472;
			short num3 = num;
			num = (short)609157120;
			if (num != 0)
			{
			}
			global::Motorola.MackinawCPS.CoreFeatures.DisplayAndMenu.DisplayAndMenuConstraints.a = global::AllFeatures.CodeplugGuid.b("韀胂鿄꣆ꟈ껊賌ꇎ뿐볒ꃔ맖뫘뻚냜뫞迠韢뫤ꛦ\udbe8\udaea\ud8ec\udeee쓰", a_);
		}

		// Token: 0x04002B4F RID: 11087
		private static string a;
	}
}
