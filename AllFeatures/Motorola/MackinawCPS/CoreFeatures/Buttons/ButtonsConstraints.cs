using System;
using System.Collections.Generic;
using AcpBusinessLayer;
using AcpBusinessLayer.UndoRedo;
using AcpCommonLib;
using AcpCommonLib.UndoRedo;
using AllFeatures;
using CommonResources;
using ConstraintHelper;
using Motorola.MackinawCPS.CoreFeatures.ControlHeadO3;
using Motorola.MackinawCPS.CoreFeatures.ControlHeadO7;
using Motorola.MackinawCPS.CoreFeatures.ControlHeadO9;
using Motorola.MackinawCPS.CoreFeatures.ConventionalPersonality;
using Motorola.MackinawCPS.CoreFeatures.EmergencyWide;
using Motorola.MackinawCPS.CoreFeatures.KeypadMicAndAccessories;
using Motorola.MackinawCPS.CoreFeatures.MenuItems;
using Motorola.MackinawCPS.CoreFeatures.RadioErgonomicsWide;
using Motorola.MackinawCPS.CoreFeatures.RadioInformation;
using Motorola.MackinawCPS.CoreFeatures.RadioWide;
using Motorola.MackinawCPS.CoreFeatures.RemoteSpeakerMic;
using Motorola.MackinawCPS.CoreFeatures.SmartKeyFob;
using Motorola.MackinawCPS.CoreFeatures.Switches;
using Motorola.MackinawCPS.CoreFeatures.TrunkingEmergencyProfiles;

namespace Motorola.MackinawCPS.CoreFeatures.Buttons
{
	// Token: 0x02000400 RID: 1024
	public static class ButtonsConstraints
	{
		// Token: 0x06008DD3 RID: 36307 RVA: 0x00850380 File Offset: 0x0084E580
		public static void conSetValueRSMOrangeTrk(global::AcpCommonLib.IAcpFeatureSection self, global::AcpCommonLib.UndoRedo.ContainerTask task)
		{
			short num;
			for (;;)
			{
				IL_00:
				num = (short)177143808;
				short num2 = num;
				switch (0)
				{
				case 0:
					goto IL_45;
				}
				int num3;
				global::AcpCommonLib.IAcpFeatureNode parent;
				global::Motorola.MackinawCPS.CoreFeatures.Buttons.PortableButtonInnerSection portableButtonInnerSection;
				for (;;)
				{
					IL_33:
					switch (num3)
					{
					case 0:
						if ((parent.Parent as global::AcpBusinessLayer.Recordset).IndexOf(parent) == 0)
						{
							num = (short)106102786;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_174;
					case 1:
						goto IL_149;
					case 2:
					{
						global::Motorola.MackinawCPS.CoreFeatures.RemoteSpeakerMic.RSMButtonInner rsmbuttonInner = (global::AcpCommonLib.FeatureManager.GetFeature(2036)[0] as global::Motorola.MackinawCPS.CoreFeatures.RemoteSpeakerMic.RemoteSpeakerMic).General.EmbeddedRecset[0] as global::Motorola.MackinawCPS.CoreFeatures.RemoteSpeakerMic.RSMButtonInner;
						task.AddTask(new global::AcpBusinessLayer.UndoRedo.ModifyDataTask<int>(rsmbuttonInner.RSMButtonInnerSection.RadErgoCfgRSMlTrunkingFeature_A19742, portableButtonInnerSection.BtnTrunkingPortableButtonFeature_A19546.Value));
						num = (short)1291189031;
						short num4 = num;
						num = (short)76282663;
						switch ((num4 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_00;
						default:
							num = (short)1253638144;
							if (num != 0)
							{
							}
							num = (short)667353089;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						}
						break;
					}
					}
					break;
				}
				IL_45:
				portableButtonInnerSection = (self as global::Motorola.MackinawCPS.CoreFeatures.Buttons.PortableButtonInnerSection);
				parent = portableButtonInnerSection.BtnTrunkingPortableButtonFeature_A19546.Parent.Parent;
				num = (short)67829760;
				num3 = (int)((global::System.IntPtr)num);
				goto IL_33;
			}
			IL_149:
			num = (short)169672705;
			if (num != 0)
			{
			}
			IL_174:
			(global::AcpCommonLib.FeatureManager.GetFeature(2045)[0] as global::Motorola.MackinawCPS.CoreFeatures.RadioWide.RadioWide).Location.RadWideLocationUserSelectableLocationEnable_A9605.CalculateApplicability();
			(global::AcpCommonLib.FeatureManager.GetFeature(2045)[0] as global::Motorola.MackinawCPS.CoreFeatures.RadioWide.RadioWide).Location.RadWideLocationUserSelectableLocationEnable_A9605.CalculateValidity();
		}

		// Token: 0x06008DD4 RID: 36308 RVA: 0x0085054C File Offset: 0x0084E74C
		public static bool ConTrunkingPortableFeaturesSelect(global::AcpCommonLib.IAcpFeatureSection self, int index)
		{
			int a_ = 16;
			short num = (short)71434240;
			int num2 = (int)num;
			switch (num2)
			{
			default:
			{
				switch (0)
				{
				case 0:
					goto IL_4A9;
				}
				global::Motorola.MackinawCPS.CoreFeatures.Buttons.PortableButtonInnerSection portableButtonInnerSection;
				global::AcpBusinessLayer.AcpListField switchConventionalSwitchesPosition2_A;
				global::Motorola.MackinawCPS.CoreFeatures.RadioInformation.Labtool labtool;
				bool flag;
				global::AcpCommonLib.IAcpRecordset embeddedRecset2;
				global::AcpBusinessLayer.AcpListField switchTrunkingSwitchesPosition5_A;
				global::AcpBusinessLayer.AcpListField switchConventionalSwitchesPosition1_A;
				global::AcpBusinessLayer.AcpListField switchTrunkingSwitchesPosition2_A;
				bool flag7;
				global::AcpBusinessLayer.AcpListField switchConventionalSwitchesPosition5_A;
				global::AcpBusinessLayer.AcpListField switchTrunkingSwitchesPosition3_A;
				global::AcpBusinessLayer.AcpListField switchTrunkingSwitchesPosition1_A;
				global::AcpBusinessLayer.AcpListField switchTrunkingSwitchesPosition4_A;
				global::AcpBusinessLayer.AcpListField switchConventionalSwitchesPosition4_A;
				global::AcpBusinessLayer.AcpListField switchConventionalSwitchesPosition3_A;
				for (;;)
				{
					IL_32:
					global::Motorola.MackinawCPS.CoreFeatures.Switches.Switches switches;
					global::AcpCommonLib.IAcpRecordset feature;
					int num3;
					int num4;
					global::AcpCommonLib.IAcpRecordset embeddedRecset;
					bool flag2;
					global::Motorola.MackinawCPS.CoreFeatures.RadioErgonomicsWide.RadioErgonomicsWide radioErgonomicsWide;
					int num5;
					int num6;
					int num8;
					bool flag5;
					bool flag6;
					global::AcpBusinessLayer.AcpListField emerWideManDownTrigger_A;
					int num10;
					global::Motorola.MackinawCPS.CoreFeatures.RadioWide.Features features;
					global::Motorola.MackinawCPS.CoreFeatures.TrunkingEmergencyProfiles.TrunkingEmergencyProfilesRecset trunkingEmergencyProfilesRecset;
					switch (num2)
					{
					case 0:
						num = (short)1903100044;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 1:
						num = (short)557645927;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 2:
						if (index <= 33)
						{
							num = (short)545587376;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)346554582;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 3:
						goto IL_17E4;
					case 4:
						goto IL_2161;
					case 5:
						num = (short)1090650265;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 6:
						if (portableButtonInnerSection.BtnTrunkingPortableTrunkingBCO_A19545.Value != 168)
						{
							num = (short)959643853;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_25B4;
					case 7:
						goto IL_3087;
					case 8:
						goto IL_2CBE;
					case 9:
						if (switches.TrunkingSwitches.SwitchTrunkingSwitchesPosition3_A9468.Value != 61)
						{
							num = (short)1048510561;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_1C23;
					case 10:
						num = (short)1752498437;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 11:
						if (portableButtonInnerSection.BtnTrunkingPortableTrunkingBCO_A19545.Value != 165)
						{
							num = (short)639041701;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_A25;
					case 12:
						num = (short)20971633;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 13:
						if (switchConventionalSwitchesPosition2_A.Value != 33)
						{
							num = (short)2124742715;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_2BC7;
					case 14:
						if (portableButtonInnerSection.BtnGeneralConventionalFeature_A19544.Value != 214)
						{
							num = (short)1341390878;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_311D;
					case 15:
					{
						global::Motorola.MackinawCPS.CoreFeatures.MenuItems.MenuItems menuItems = feature[0] as global::Motorola.MackinawCPS.CoreFeatures.MenuItems.MenuItems;
						num3 = 0;
						num = (short)997851288;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 16:
						if (labtool != null)
						{
							num = (short)138412134;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_19B0;
					case 17:
						goto IL_1B8C;
					case 18:
						flag = false;
						num = (short)1252589729;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 19:
						num = (short)1234108643;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 20:
						if (index != 236)
						{
							num = (short)990576652;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)1262092485;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 21:
						goto IL_2B35;
					case 22:
						num = (short)666370176;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 23:
						if (portableButtonInnerSection.BtnTrunkingPortableTrunkingBCO_A19545.Value != 148)
						{
							num = (short)1747124457;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_22F3;
					case 24:
						goto IL_142B;
					case 25:
						if (portableButtonInnerSection.BtnTrunkingPortableTrunkingBCO_A19545.Value != 165)
						{
							num = (short)780337251;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_25B4;
					case 26:
						num = (short)1959526428;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 27:
						num = (short)810352747;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 28:
						if (index != 88)
						{
							num = (short)508756074;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)1601110069;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 29:
						goto IL_11C9;
					case 30:
						flag = false;
						num = (short)1693319416;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 31:
						if (feature.Count != 0)
						{
							num = (short)1235222632;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_311D;
					case 32:
						if (portableButtonInnerSection.BtnTrunkingPortableTrunkingBCO_A19545.Value == 170)
						{
							num = (short)107151421;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_311D;
					case 33:
						goto IL_1486;
					case 34:
						if (portableButtonInnerSection.BtnGeneralConventionalFeature_A19544.Value != 27)
						{
							num = (short)1425539284;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_311D;
					case 35:
					{
						global::Motorola.MackinawCPS.CoreFeatures.RemoteSpeakerMic.RSMButtonInner rsmbuttonInner;
						if (rsmbuttonInner.RSMButtonInnerSection.RadErgoCfgRSMTrunkingBCO_A19741.Value != 151)
						{
							num = (short)29032721;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_1FD3;
					}
					case 36:
						num = (short)1972502607;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 37:
						goto IL_2820;
					case 38:
						num = (short)2058682603;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 39:
						flag = false;
						num = (short)998637625;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 40:
						goto IL_2166;
					case 41:
					{
						if (num4 >= embeddedRecset.Count)
						{
							num = (short)341966849;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						global::Motorola.MackinawCPS.CoreFeatures.RemoteSpeakerMic.RSMButtonInner rsmbuttonInner2 = embeddedRecset[num4] as global::Motorola.MackinawCPS.CoreFeatures.RemoteSpeakerMic.RSMButtonInner;
						num = (short)1481703536;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 42:
						num = (short)761593865;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 43:
						num = (short)2048852101;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 44:
						flag = false;
						num = (short)548274193;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 45:
						if (portableButtonInnerSection.BtnGeneralConventionalFeature_A19544.Value != 210)
						{
							num = (short)1680933007;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_311D;
					case 46:
						num = (short)1990394005;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 47:
						num = (short)939655424;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 48:
						goto IL_2FED;
					case 49:
						if (index <= 87)
						{
							num = (short)59703443;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)663224521;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 50:
						num = (short)600244437;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 51:
						if (portableButtonInnerSection.BtnTrunkingPortableTrunkingBCO_A19545.Value != 148)
						{
							num = (short)1641218183;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_11C9;
					case 52:
						num = (short)2113732818;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 53:
						if (portableButtonInnerSection.BtnGeneralConventionalFeature_A19544.Value != 88)
						{
							num = (short)1214316645;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_311D;
					case 54:
						num = (short)1134690335;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 55:
						goto IL_CAD;
					case 56:
						if (portableButtonInnerSection.BtnTrunkingPortableTrunkingBCO_A19545.Value == 166)
						{
							num = (short)644677714;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)942473325;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 57:
						goto IL_20BE;
					case 58:
						goto IL_1600;
					case 59:
						num = (short)1311375637;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 60:
						flag2 = false;
						goto IL_2239;
					case 61:
						goto IL_A25;
					case 62:
						if (index != 27)
						{
							num = (short)1737818207;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)2089418786;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 63:
						num = (short)439156850;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 64:
					{
						if ((global::AcpCommonLib.FeatureManager.GetFeature(2049)[0] as global::Motorola.MackinawCPS.CoreFeatures.RadioInformation.RadioInformation).Labtool.RadInfoLabtoolQA08715VoiceControlBasic)
						{
							num = (short)200540406;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						bool flag3;
						bool flag4;
						flag = (flag3 && flag4);
						num = (short)1352401028;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 65:
						goto IL_252A;
					case 66:
						if (flag)
						{
							num = (short)293863532;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_13EE;
					case 67:
						num = (short)1002963185;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 68:
						num = (short)1016463496;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 69:
						if (portableButtonInnerSection.BtnGeneralConventionalFeature_A19544.Value != 67)
						{
							num = (short)1071710292;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_311D;
					case 70:
						goto IL_18E8;
					case 71:
						goto IL_13EE;
					case 72:
						num = (short)75694190;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 73:
						if (switches.TrunkingSwitches.SwitchTrunkingSwitchesPosition1_A9466.Value != 61)
						{
							num = (short)1318322223;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_1C23;
					case 74:
						flag = false;
						num = (short)583139365;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 75:
						goto IL_1A9C;
					case 76:
						goto IL_2B56;
					case 77:
						num4 = 0;
						num = (short)1513357387;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 78:
						num = (short)1842741271;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 79:
						goto IL_2C6E;
					case 80:
						if (radioErgonomicsWide.Advanced.RadErgoWideAdvancedSideButtonsLockEnable_A38725.Value)
						{
							num = (short)1588396110;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_142B;
					case 81:
						goto IL_15FB;
					case 82:
						goto IL_2B19;
					case 83:
						flag2 = (embeddedRecset2 != null);
						goto IL_2239;
					case 84:
						flag = false;
						num = (short)93192247;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 85:
						if (index != 235)
						{
							num = (short)1119289627;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)303956232;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 86:
						goto IL_1927;
					case 87:
						if (portableButtonInnerSection.ParentRecset[num5] != portableButtonInnerSection.Parent)
						{
							num = (short)1244856490;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_BDB;
					case 88:
						if (index != 87)
						{
							num = (short)24051748;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)16515253;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 89:
						flag = false;
						num = (short)1007026306;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 90:
						flag = false;
						num = (short)1031143656;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 91:
						if (flag)
						{
							num = (short)1921056818;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_142B;
					case 92:
					{
						global::Motorola.MackinawCPS.CoreFeatures.MenuItems.MenuItems menuItems;
						if (menuItems.General.DispMenuTrunkingSelectedMenuItems_A21735.Items[num6].ItemName == global::CommonResources.AcgResources.ID_SCAN)
						{
							num = (short)2040135899;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_209B;
					}
					case 93:
						goto IL_1C23;
					case 94:
						goto IL_17BE;
					case 95:
						num = (short)424149222;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 96:
						if (portableButtonInnerSection.BtnTrunkingPortableTrunkingBCO_A19545.Value != 97)
						{
							num = (short)2039152686;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_825;
					case 97:
						num = (short)1546191023;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 98:
						if (global::ConstraintHelper.UtilityMack.ProductModelId.Equals(global::AllFeatures.CodeplugGuid.b("郐菒跔", a_)))
						{
							num = (short)1684078756;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						flag = false;
						num = (short)2073821332;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 99:
						goto IL_7DA;
					case 100:
						goto IL_2820;
					case 101:
						flag = false;
						num = (short)583663697;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 102:
						num = (short)208470147;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 103:
						goto IL_142B;
					case 104:
						num = (short)1770520800;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 105:
						goto IL_2CDA;
					case 106:
						num = (short)1791099123;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 107:
						if (portableButtonInnerSection.BtnTrunkingPortableTrunkingBCO_A19545.Value != 169)
						{
							num = (short)1422262389;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_A25;
					case 108:
						num = (short)2119172317;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 109:
						if (global::ConstraintHelper.UtilityMack.IsAlohaRadio)
						{
							num = (short)820117710;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_7DA;
					case 110:
						if (portableButtonInnerSection.BtnTrunkingPortableTrunkingBCO_A19545.Value == 166)
						{
							num = (short)2015690760;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)649658607;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 111:
						flag = false;
						num = (short)680525848;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 112:
					{
						global::Motorola.MackinawCPS.CoreFeatures.RemoteSpeakerMic.RSMButtonInner rsmbuttonInner2;
						if (rsmbuttonInner2.RSMButtonInnerSection.RadErgoCfgRSMTrunkingBCO_A19741.Value != 151)
						{
							num = (short)1106968598;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_30D9;
					}
					case 113:
						goto IL_23CF;
					case 114:
						if (switches.TrunkingSwitches.SwitchTrunkingSwitchesPosition5_A21535.Value == 61)
						{
							num = (short)1580728413;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_11C9;
					case 115:
						if (flag)
						{
							num = (short)1703674108;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)1592197180;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 116:
						num = (short)1722875939;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 117:
						num = (short)1934819360;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 118:
						if (portableButtonInnerSection.BtnGeneralConventionalFeature_A19544.Value != 149)
						{
							num = (short)1875771608;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_311D;
					case 119:
						try
						{
							num = (short)1917976579;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								switch (num2)
								{
								case 0:
									num = (short)265420806;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 1:
									flag = true;
									num = (short)1510670338;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 3:
									switch (0)
									{
									case 0:
										goto IL_E26;
									}
									continue;
								case 4:
								{
									global::System.Collections.Generic.IEnumerator<global::AcpBusinessLayer.FeatureNode> enumerator;
									if (!enumerator.MoveNext())
									{
										num = (short)2050097152;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									num = (short)1621950469;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 5:
								{
									global::System.Collections.Generic.IEnumerator<global::AcpBusinessLayer.FeatureNode> enumerator;
									if (((global::Motorola.MackinawCPS.CoreFeatures.TrunkingEmergencyProfiles.TrunkingEmergencyProfiles)enumerator.Current).EmergencyCompatibilityOptionsTrunking.EmergencyExitControl_43341.Value == 3)
									{
										num = (short)1185742849;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									break;
								}
								case 6:
									goto IL_EE7;
								}
								IL_E42:
								num = (short)1927479300;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								IL_E26:
								goto IL_E42;
							}
							IL_EE7:
							goto IL_1FF8;
						}
						finally
						{
							num = (short)590675970;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								global::System.Collections.Generic.IEnumerator<global::AcpBusinessLayer.FeatureNode> enumerator;
								switch (num2)
								{
								case 0:
									goto IL_FD0;
								case 1:
								{
									num = (short)121532133;
									short num7 = num;
									num = (short)639659749;
									switch ((num7 == num) ? 1 : 0)
									{
									case 0:
									case 2:
										goto IL_F02;
									default:
										num = (short)1625358336;
										if (num != 0)
										{
										}
										enumerator.Dispose();
										num = (short)2036727808;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									break;
								}
								case 2:
									goto IL_F02;
								}
								goto IL_F48;
								IL_F02:
								num = (short)310050817;
								if (num != 0)
								{
								}
								switch (0)
								{
								case 0:
									IL_F48:
									if (enumerator == null)
									{
										goto IL_FD2;
									}
									num = (short)94109697;
									num2 = (int)((global::System.IntPtr)num);
									break;
								}
							}
							IL_FD0:
							IL_FD2:;
						}
						goto IL_FD3;
						IL_1FF8:
						num = (short)1264976095;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 120:
						num = (short)607125627;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 121:
						goto IL_17DF;
					case 122:
						if (portableButtonInnerSection.BtnGeneralConventionalFeature_A19544.Value != 211)
						{
							num = (short)1911685369;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_311D;
					case 123:
						if (feature != null)
						{
							num = (short)622919734;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_311D;
					case 124:
						num = (short)1361379478;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 125:
						if (portableButtonInnerSection.BtnTrunkingPortableTrunkingBCO_A19545.Value != 167)
						{
							num = (short)2053636220;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_A25;
					case 126:
						goto IL_25F1;
					case 127:
						if (portableButtonInnerSection.BtnTrunkingPortableTrunkingBCO_A19545.Value != 169)
						{
							num = (short)121176132;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_25B4;
					case 128:
					{
						global::Motorola.MackinawCPS.CoreFeatures.RemoteSpeakerMic.RSMButtonInner rsmbuttonInner2;
						if (rsmbuttonInner2.RSMButtonInnerSection.RadErgoCfgRSMlTrunkingFeature_A19742.Value == 31)
						{
							num = (short)605814895;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_30D9;
					}
					case 129:
						if (num5 >= portableButtonInnerSection.ParentRecset.Count)
						{
							num = (short)1466958081;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)119930967;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 130:
						goto IL_297B;
					case 131:
						if (labtool.RadInfoLabtoolBluetooth_A37042.Value)
						{
							num = (short)1488126144;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_19B0;
					case 132:
						goto IL_26EA;
					case 133:
						if (portableButtonInnerSection.BtnTrunkingPortableTrunkingBCO_A19545.Value != 230)
						{
							num = (short)1876492547;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_2B19;
					case 134:
						num = (short)1763180600;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 135:
						num8 = 0;
						num = (short)1136328893;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 136:
						if (portableButtonInnerSection.BtnTrunkingPortableTrunkingBCO_A19545.Value == 170)
						{
							num = (short)41222404;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_311D;
					case 137:
						goto IL_85F;
					case 138:
						if (radioErgonomicsWide.Advanced.RadErgoWideAdvancedSideButtonsLockEnable_A38725.Value)
						{
							num = (short)1682702614;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_11C9;
					case 139:
						goto IL_3118;
					case 140:
						goto IL_2999;
					case 141:
						if ((portableButtonInnerSection.ParentRecset[num5] as global::Motorola.MackinawCPS.CoreFeatures.Buttons.PortableButtonInner).PortableButtonInnerSection.BtnTrunkingPortableTrunkingBCO_A19545.Value != 148)
						{
							num = (short)1523646483;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_BDB;
					case 142:
						flag5 = (switchTrunkingSwitchesPosition5_A.Value != 33);
						goto IL_2DB3;
					case 143:
						flag = false;
						num = (short)274202763;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 144:
						if (portableButtonInnerSection.BtnTrunkingPortableTrunkingBCO_A19545.Value != 167)
						{
							num = (short)1515258054;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_25B4;
					case 145:
						num = (short)1549402357;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 146:
					{
						num = (short)1942880256;
						short num9 = num;
						flag = false;
						num = (short)595198110;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 147:
						num = (short)763494402;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 148:
						goto IL_142B;
					case 149:
						flag6 = (portableButtonInnerSection.BtnTrunkingPortableTrunkingBCO_A19545.Value == 96);
						goto IL_25D5;
					case 150:
						if (portableButtonInnerSection.BtnTrunkingPortableTrunkingBCO_A19545.Value != 168)
						{
							num = (short)36765723;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_A25;
					case 151:
						flag = false;
						num = (short)489750781;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 152:
						goto IL_B8A;
					case 153:
						if (portableButtonInnerSection.ParentRecset[num8] != self.Parent)
						{
							num = (short)1074069543;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_721;
					case 154:
					{
						global::Motorola.MackinawCPS.CoreFeatures.MenuItems.MenuItems menuItems;
						if (num6 >= menuItems.General.DispMenuTrunkingSelectedMenuItems_A21735.Items.Count)
						{
							num = (short)1514209425;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_FD3;
					}
					case 155:
						if (switchConventionalSwitchesPosition1_A.Value != 33)
						{
							num = (short)266993914;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_2BC7;
					case 156:
						num = (short)1843855445;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 157:
						goto IL_A20;
					case 158:
						goto IL_22C6;
					case 159:
						if (portableButtonInnerSection.BtnGeneralConventionalFeature_A19544.Value != 64)
						{
							num = (short)1346175160;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_311D;
					case 160:
						if (portableButtonInnerSection.BtnGeneralConventionalFeature_A19544.Value != 65)
						{
							num = (short)203882514;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_311D;
					case 161:
						goto IL_2DAE;
					case 162:
						num = (short)243204238;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 163:
						goto IL_22EE;
					case 164:
						goto IL_22F3;
					case 165:
						goto IL_2B5B;
					case 166:
						goto IL_164B;
					case 167:
						goto IL_2F34;
					case 168:
						num = (short)606535946;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 169:
						if (flag)
						{
							num = (short)1662582963;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_11C9;
					case 170:
						num = (short)948371597;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 171:
						goto IL_1A9C;
					case 172:
						if ((portableButtonInnerSection.ParentRecset[num8] as global::Motorola.MackinawCPS.CoreFeatures.Buttons.PortableButtonInner).PortableButtonInnerSection.BtnTrunkingPortableButtonFeature_A19546.Value == 61)
						{
							num = (short)518717445;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_721;
					case 173:
						num = (short)335151192;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 174:
					{
						global::Motorola.MackinawCPS.CoreFeatures.RemoteSpeakerMic.RSMButtonInner rsmbuttonInner;
						if (rsmbuttonInner.RSMButtonInnerSection.RadErgoCfgRSMlTrunkingFeature_A19742.Value == 61)
						{
							num = (short)570032244;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_1FD3;
					}
					case 175:
						if (switches.TrunkingSwitches.SwitchTrunkingSwitchesPosition4_A21534.Value != 61)
						{
							num = (short)127467583;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_1C23;
					case 176:
						num = (short)367853630;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 177:
						switch (index)
						{
						case 209:
							num = (short)108855534;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 210:
							num = (short)2067595309;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 211:
							num = (short)2098790522;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 212:
							num = (short)533004560;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 213:
						case 215:
						case 216:
							goto IL_311D;
						case 214:
							num = (short)1274544142;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 217:
							flag = (emerWideManDownTrigger_A.Value != 0);
							num = (short)1056440414;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						default:
							num = (short)1658388691;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						break;
					case 178:
						num6 = 0;
						num = (short)1383071751;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 179:
						num = (short)323551305;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 180:
						num = (short)1544683767;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 181:
						if (portableButtonInnerSection.BtnGeneralConventionalFeature_A19544.Value != 87)
						{
							num = (short)1049493738;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_311D;
					case 182:
						if (switchTrunkingSwitchesPosition2_A.Value != 33)
						{
							num = (short)1676214339;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_2BC7;
					case 183:
						num10 = 0;
						num = (short)202834114;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 184:
						flag = false;
						num = (short)31654025;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 185:
						if (portableButtonInnerSection.BtnTrunkingPortableTrunkingBCO_A19545.Value != 165)
						{
							num = (short)938541190;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_2B19;
					case 186:
					{
						global::Motorola.MackinawCPS.CoreFeatures.MenuItems.MenuItems menuItems;
						if (menuItems.General.DispMenuConventionalSelectedMenuItems_A21736.Items[num3].ItemName == global::CommonResources.AcgResources.ID_SCAN)
						{
							num = (short)766640279;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_252F;
					}
					case 187:
						goto IL_3087;
					case 188:
						goto IL_164B;
					case 189:
						goto IL_17E4;
					case 190:
						flag = false;
						num = (short)1511981213;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 191:
						num = (short)617414752;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 192:
						flag7 = true;
						num = (short)864157963;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 193:
						if (num8 >= portableButtonInnerSection.ParentRecset.Count)
						{
							num = (short)658833679;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)1534460076;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 194:
						goto IL_1927;
					case 195:
						goto IL_209B;
					case 196:
					{
						int num11 = 0;
						num = (short)908591292;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 197:
						if (portableButtonInnerSection.BtnGeneralConventionalFeature_A19544.Value != 236)
						{
							num = (short)1848508562;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_311D;
					case 198:
						num = (short)1532559366;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 199:
						flag = false;
						num = (short)1321533607;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 200:
						num = (short)267911430;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 201:
						if (index <= 217)
						{
							num = (short)260833306;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)2092761332;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 202:
						num = (short)934936758;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 203:
						if (flag)
						{
							num = (short)253558904;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_311D;
					case 204:
						num = (short)2018050192;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 205:
						num = (short)535232639;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 206:
						num = (short)509149209;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 207:
						goto IL_1704;
					case 208:
						num = (short)953811181;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 209:
						goto IL_A41;
					case 210:
						if (index != 81)
						{
							num = (short)98435245;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)681967871;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 211:
						num = (short)1282343119;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 212:
						flag = false;
						num = (short)471007280;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 213:
						if (embeddedRecset != null)
						{
							num = (short)1511391309;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_142B;
					case 214:
						switch (index)
						{
						case 61:
							num = (short)1723793488;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 62:
						case 63:
							goto IL_311D;
						case 64:
							num = (short)1288175775;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 65:
							num = (short)1588723872;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 66:
							num = (short)589693150;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 67:
							num = (short)2036072517;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						default:
							num = (short)1698431028;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						break;
					case 215:
						if (global::ConstraintHelper.UtilityMack.IsMahaloRadio)
						{
							num = (short)2028273707;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_1CFA;
					case 216:
						flag = false;
						num = (short)887881804;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 217:
					{
						global::Motorola.MackinawCPS.CoreFeatures.MenuItems.MenuItems menuItems;
						if (num3 >= menuItems.General.DispMenuConventionalSelectedMenuItems_A21736.Items.Count)
						{
							num = (short)121241778;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)435617978;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 218:
						num = (short)1020198923;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 219:
						flag = false;
						num = (short)34865347;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 220:
						if (portableButtonInnerSection.BtnTrunkingPortableTrunkingBCO_A19545.Value != 98)
						{
							num = (short)1799159999;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_825;
					case 221:
						if (embeddedRecset != null)
						{
							num = (short)1143931063;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_13EE;
					case 222:
						if (portableButtonInnerSection.BtnGeneralConventionalFeature_A19544.Value != 66)
						{
							num = (short)262471770;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_311D;
					case 223:
						if (portableButtonInnerSection.BtnTrunkingPortableTrunkingBCO_A19545.Value != 97)
						{
							num = (short)51576921;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_311D;
					case 224:
						if (!global::ConstraintHelper.UtilityMack.IsMobile())
						{
							num = (short)453705743;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_311D;
					case 225:
						goto IL_B8A;
					case 226:
						num = (short)1557332219;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 227:
						if ((portableButtonInnerSection.ParentRecset[num5] as global::Motorola.MackinawCPS.CoreFeatures.Buttons.PortableButtonInner).PortableButtonInnerSection.BtnTrunkingPortableButtonFeature_A19546.Value == 31)
						{
							num = (short)1554579684;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_BDB;
					case 228:
						flag = false;
						num = (short)1716453446;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 229:
						goto IL_18E3;
					case 230:
						if (index != 31)
						{
							num = (short)833355956;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)1428684938;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 231:
						goto IL_25D0;
					case 232:
						goto IL_2A83;
					case 233:
						num = (short)1063125090;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 234:
						flag = false;
						num = (short)764936225;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 235:
						goto IL_71C;
					case 236:
						flag6 = true;
						goto IL_25D5;
					case 237:
						if (switchConventionalSwitchesPosition5_A.Value != 33)
						{
							num = (short)1713373410;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_2BC7;
					case 238:
						if (portableButtonInnerSection.BtnGeneralConventionalFeature_A19544.Value != 209)
						{
							num = (short)585236760;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_311D;
					case 239:
						if (global::ConstraintHelper.UtilityMack.IsAlohaRadio)
						{
							num = (short)467468506;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_2B5B;
					case 240:
						if (portableButtonInnerSection.BtnTrunkingPortableTrunkingBCO_A19545.Value != 166)
						{
							num = (short)2112356556;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_25B4;
					case 241:
						if (switchTrunkingSwitchesPosition3_A.Value != 33)
						{
							num = (short)7078088;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_2BC7;
					case 242:
						num = (short)152371325;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 243:
						if (index != 149)
						{
							num = (short)688128268;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)1052901494;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 244:
						if (index <= 236)
						{
							num = (short)796983452;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)1021051161;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 245:
						goto IL_1E3F;
					case 246:
					{
						bool flag3;
						flag = flag3;
						num = (short)1396703297;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 247:
						if (index != 33)
						{
							num = (short)624427008;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)656015515;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 248:
						goto IL_1CF5;
					case 249:
						flag = false;
						num = (short)919797989;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 250:
						num = (short)1684471821;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 251:
						if (switchTrunkingSwitchesPosition1_A.Value != 33)
						{
							num = (short)1327104202;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_2BC7;
					case 252:
						num = (short)157483091;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 253:
						goto IL_252F;
					case 254:
						flag5 = false;
						goto IL_2DB3;
					case 255:
						if (switchConventionalSwitchesPosition1_A.Value == 81)
						{
							num = (short)1372127431;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_311D;
					case 256:
						if (switches.TrunkingSwitches.SwitchTrunkingSwitchesPosition2_A9467.Value != 61)
						{
							num = (short)304611370;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_1C23;
					case 257:
						goto IL_18E8;
					case 258:
					{
						int num11;
						if (num11 >= embeddedRecset2.Count)
						{
							num = (short)1773273188;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)891945236;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 259:
						goto IL_1CFA;
					case 260:
						goto IL_25B4;
					case 261:
						if (index - 290 > 1)
						{
							num = (short)1629487142;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						flag = features.RadWideFeaturesChannelFallbackEnableValue;
						num = (short)2079719587;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 262:
						if (switchTrunkingSwitchesPosition4_A.Value != 33)
						{
							num = (short)702349474;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_2BC7;
					case 263:
						goto IL_13EE;
					case 264:
						if (portableButtonInnerSection.BtnGeneralConventionalFeature_A19544.Value != 235)
						{
							num = (short)494993598;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_311D;
					case 265:
					{
						if (num10 >= embeddedRecset.Count)
						{
							num = (short)272302151;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						global::Motorola.MackinawCPS.CoreFeatures.RemoteSpeakerMic.RSMButtonInner rsmbuttonInner = embeddedRecset[num10] as global::Motorola.MackinawCPS.CoreFeatures.RemoteSpeakerMic.RSMButtonInner;
						num = (short)312017070;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 266:
						if (switchConventionalSwitchesPosition4_A.Value != 33)
						{
							num = (short)386334928;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_2BC7;
					case 267:
						goto IL_19B0;
					case 268:
						num = (short)1949171889;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 269:
						if (portableButtonInnerSection.BtnTrunkingPortableTrunkingBCO_A19545.Value != 165)
						{
							num = (short)1156251720;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_2CBE;
					case 270:
						goto IL_2166;
					case 271:
						goto IL_20BE;
					case 272:
						if (portableButtonInnerSection.BtnGeneralConventionalFeature_A19544.Value != 212)
						{
							num = (short)1397686316;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_311D;
					case 273:
						flag = false;
						num = (short)1373372679;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 274:
						if (global::ConstraintHelper.UtilityMack.IsMahaloRadio)
						{
							num = (short)558956826;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_1600;
					case 275:
						if (portableButtonInnerSection.BtnTrunkingPortableTrunkingBCO_A19545.Value != 230)
						{
							num = (short)362020922;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_2CBE;
					case 276:
					{
						int num11;
						if ((embeddedRecset2[num11] as global::Motorola.MackinawCPS.CoreFeatures.SmartKeyFob.SmartKeyFobButtonTableInner).SmartKeyFobButtonTableInnerSection.RadErgoCfgFobTrunkingFeature_A41575.Value == 61)
						{
							num = (short)572719178;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num11++;
						num = (short)1353384102;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 277:
						if (switchConventionalSwitchesPosition3_A.Value != 33)
						{
							num = (short)1648099496;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_2BC7;
					case 278:
						num = (short)1985347635;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 279:
						if (portableButtonInnerSection.BtnTrunkingPortableTrunkingBCO_A19545.Value != 166)
						{
							num = (short)248578290;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_A25;
					case 280:
						flag = false;
						num = (short)1530069113;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 281:
						switch (index)
						{
						case 266:
						{
							flag = false;
							global::System.Collections.Generic.IEnumerator<global::AcpBusinessLayer.FeatureNode> enumerator = trunkingEmergencyProfilesRecset.GetEnumerator();
							num = (short)611123319;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						case 267:
							num = (short)645136604;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 268:
						{
							int isAPXNextOrAloha = global::ConstraintHelper.UtilityMack.IsAPXNextOrAloha ? 1 : 0;
							int radCfgVirtualPartnerModeValue = portableButtonInnerSection.RefRadioWide.Features.RadCfgVirtualPartnerModeValue;
							bool flag8 = !(global::Motorola.MackinawCPS.CoreFeatures.RadioWide.LOVs.RadCfgVirtualPartnerModeLovStrs[radCfgVirtualPartnerModeValue] == global::CommonResources.AcgResources.ID_DISABLED);
							bool flag9 = portableButtonInnerSection.BtnTrunkingPortableTrunkingBCO_A19545.Value != 96;
							flag = ((isAPXNextOrAloha == 0 || flag8) && flag9);
							num = (short)805961732;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						case 269:
						{
							int radWideFeaturesVoiceControlPriorityValue = portableButtonInnerSection.RefRadioWide.Features.RadWideFeaturesVoiceControlPriorityValue;
							bool flag3 = !(global::Motorola.MackinawCPS.CoreFeatures.RadioWide.LOVs.RadWideFeaturesVoiceControlPriorityLovStrs[radWideFeaturesVoiceControlPriorityValue] == global::CommonResources.AcgResources.ID_DISABLED);
							bool flag4 = portableButtonInnerSection.BtnTrunkingPortableTrunkingBCO_A19545.Value != 96;
							num = (short)660930624;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						default:
							num = (short)1245380618;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						break;
					case 282:
						num = (short)770703635;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 283:
						num = (short)2052390932;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_4A9;
					IL_721:
					num8++;
					num = (short)799932419;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_7DA:
					num = (short)1719730416;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_825:
					num = (short)593953004;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_A25:
					flag = false;
					num = (short)1709637841;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_B8A:
					num = (short)1653866713;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_BDB:
					num5++;
					num = (short)581894414;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_FD3:
					num = (short)489947228;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_11C9:
					num = (short)99680471;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_13EE:
					num = (short)1686962291;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_142B:
					num = (short)671351058;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_1600:
					num = (short)1148911885;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_164B:
					num = (short)789905666;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_17E4:
					num = (short)1625817281;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_18E8:
					num = (short)1945370715;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_1927:
					num = (short)1983971593;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_19B0:
					flag = true;
					radioErgonomicsWide = (global::AcpCommonLib.FeatureManager.GetFeature(2033)[0] as global::Motorola.MackinawCPS.CoreFeatures.RadioErgonomicsWide.RadioErgonomicsWide);
					trunkingEmergencyProfilesRecset = (global::AcpCommonLib.FeatureManager.GetFeature(2076) as global::Motorola.MackinawCPS.CoreFeatures.TrunkingEmergencyProfiles.TrunkingEmergencyProfilesRecset);
					embeddedRecset = global::AcpCommonLib.FeatureManager.GetFeature(2036)[0][10079].EmbeddedRecset;
					switches = (global::AcpCommonLib.FeatureManager.GetFeature(2038)[0] as global::Motorola.MackinawCPS.CoreFeatures.Switches.Switches);
					features = (global::AcpCommonLib.FeatureManager.GetFeature(2045)[0][10105] as global::Motorola.MackinawCPS.CoreFeatures.RadioWide.Features);
					emerWideManDownTrigger_A = ((global::AcpCommonLib.FeatureManager.GetFeature(2032) as global::Motorola.MackinawCPS.CoreFeatures.EmergencyWide.EmergencyWideRecset)[0][10639] as global::Motorola.MackinawCPS.CoreFeatures.EmergencyWide.ManDown).EmerWideManDownTrigger_A40001;
					num = (short)1049165873;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_1A9C:
					num = (short)1261568041;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_1C23:
					flag = false;
					num = (short)1524563997;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_1CFA:
					num = (short)2017198265;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_1FD3:
					num10++;
					num = (short)119013462;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_209B:
					num6++;
					num = (short)1832321211;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_20BE:
					num = (short)112918594;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_2166:
					num = (short)1917649025;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_2239:
					if (flag2 && flag7)
					{
						num = (short)1511063748;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_2820;
					IL_22F3:
					num5 = 0;
					num = (short)724959272;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_252F:
					num3++;
					num = (short)2115305697;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_25B4:
					flag = false;
					num = (short)1984430311;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_25D5:
					flag = flag6;
					num = (short)617480318;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_2820:
					num = (short)1187840169;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_2B19:
					flag = false;
					num = (short)1990393877;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_2B5B:
					num = (short)34734359;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_2BC7:
					num = (short)764739838;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_2CBE:
					flag = false;
					num = (short)616890473;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_2DB3:
					flag = flag5;
					feature = global::AcpCommonLib.FeatureManager.GetFeature(2088);
					num = (short)765853899;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_3087:
					num = (short)673382554;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_30D9:
					num4++;
					num = (short)1762263211;
					num2 = (int)((global::System.IntPtr)num);
				}
				IL_71C:
				IL_85F:
				IL_A20:
				IL_A41:
				IL_CAD:
				IL_1486:
				IL_15FB:
				IL_1704:
				IL_17BE:
				IL_17DF:
				IL_18E3:
				IL_1B8C:
				IL_1CF5:
				IL_1E3F:
				IL_2161:
				IL_22C6:
				IL_22EE:
				IL_23CF:
				IL_252A:
				IL_25D0:
				IL_25F1:
				IL_26EA:
				IL_297B:
				IL_2999:
				IL_2A83:
				IL_2B35:
				IL_2B56:
				IL_2C6E:
				IL_2CDA:
				IL_2DAE:
				IL_2F34:
				IL_2FED:
				IL_3118:
				IL_311D:
				global::AcpCommonLib.FeatureManager.GetFeature(2036)[0][10079].EmbeddedRecset.CalculateValidity();
				global::AcpCommonLib.FeatureManager.GetFeature(4130)[0][10747].EmbeddedRecset.CalculateValidity();
				return flag;
				IL_4A9:
				portableButtonInnerSection = (self as global::Motorola.MackinawCPS.CoreFeatures.Buttons.PortableButtonInnerSection);
				switchConventionalSwitchesPosition1_A = portableButtonInnerSection.RefSwitches.ConventionalSwitches.SwitchConventionalSwitchesPosition1_A7734;
				switchConventionalSwitchesPosition2_A = portableButtonInnerSection.RefSwitches.ConventionalSwitches.SwitchConventionalSwitchesPosition2_A7735;
				switchConventionalSwitchesPosition3_A = portableButtonInnerSection.RefSwitches.ConventionalSwitches.SwitchConventionalSwitchesPosition3_A7737;
				switchConventionalSwitchesPosition4_A = portableButtonInnerSection.RefSwitches.ConventionalSwitches.SwitchConventionalSwitchesPosition4_A21530;
				switchConventionalSwitchesPosition5_A = portableButtonInnerSection.RefSwitches.ConventionalSwitches.SwitchConventionalSwitchesPosition5_A21531;
				switchTrunkingSwitchesPosition1_A = portableButtonInnerSection.RefSwitches.TrunkingSwitches.SwitchTrunkingSwitchesPosition1_A9466;
				switchTrunkingSwitchesPosition2_A = portableButtonInnerSection.RefSwitches.TrunkingSwitches.SwitchTrunkingSwitchesPosition2_A9467;
				switchTrunkingSwitchesPosition3_A = portableButtonInnerSection.RefSwitches.TrunkingSwitches.SwitchTrunkingSwitchesPosition3_A9468;
				switchTrunkingSwitchesPosition4_A = portableButtonInnerSection.RefSwitches.TrunkingSwitches.SwitchTrunkingSwitchesPosition4_A21534;
				switchTrunkingSwitchesPosition5_A = portableButtonInnerSection.RefSwitches.TrunkingSwitches.SwitchTrunkingSwitchesPosition5_A21535;
				global::AcpCommonLib.IAcpRecordset embeddedRecset3 = (global::AcpCommonLib.FeatureManager.GetFeature(2042) as global::Motorola.MackinawCPS.CoreFeatures.Buttons.ButtonsRecset)[0][10091].EmbeddedRecset;
				global::AcpCommonLib.IAcpFeatureNode parent = portableButtonInnerSection.BtnTrunkingPortableButtonFeature_A19546.Parent.Parent;
				embeddedRecset2 = global::AcpCommonLib.FeatureManager.GetFeature(4130)[0][10747].EmbeddedRecset;
				labtool = (global::AcpCommonLib.FeatureManager.GetFeature(2049)[0][10107] as global::Motorola.MackinawCPS.CoreFeatures.RadioInformation.Labtool);
				flag7 = false;
				num = (short)58916880;
				num2 = (int)((global::System.IntPtr)num);
				goto IL_32;
			}
			}
		}

		// Token: 0x06008DD5 RID: 36309 RVA: 0x008536DC File Offset: 0x008518DC
		public static void conUpdateFieldsDepOnCnvButton(global::AcpCommonLib.IAcpFeatureSection self, global::AcpCommonLib.UndoRedo.ContainerTask task)
		{
			short num = (short)725614592;
			int num2 = (int)num;
			switch (num2)
			{
			default:
			{
				switch (0)
				{
				case 0:
					goto IL_280;
				}
				global::Motorola.MackinawCPS.CoreFeatures.Buttons.PortableButtonInnerSection portableButtonInnerSection;
				global::Motorola.MackinawCPS.CoreFeatures.RemoteSpeakerMic.RSMButtonInner rsmbuttonInner;
				int num3;
				global::AcpBusinessLayer.AcpListField switchTrunkingSwitchesPosition3_A;
				global::AcpBusinessLayer.AcpListField switchTrunkingSwitchesPosition4_A;
				global::AcpBusinessLayer.AcpListField switchTrunkingSwitchesPosition5_A;
				global::AcpBusinessLayer.AcpListField switchConventionalSwitchesPosition3_A;
				global::AcpBusinessLayer.AcpListField switchConventionalSwitchesPosition4_A;
				global::AcpBusinessLayer.AcpListField switchConventionalSwitchesPosition5_A;
				global::Motorola.MackinawCPS.CoreFeatures.Switches.TrunkingSwitchTableInnerRecset trunkingSwitchTableInnerRecset;
				global::AcpBusinessLayer.AcpField<bool> radWideLabtoolZoneSelectorOnSwitch_A;
				global::Motorola.MackinawCPS.CoreFeatures.Switches.ConventionalSwitchTableInnerRecset conventionalSwitchTableInnerRecset;
				global::Motorola.MackinawCPS.CoreFeatures.Switches.RotaryControlInnerRecset rotaryControlInnerRecset;
				for (;;)
				{
					IL_29:
					global::System.Collections.Generic.IEnumerator<global::AcpBusinessLayer.FeatureNode> enumerator;
					switch (num2)
					{
					case 0:
						goto IL_730;
					case 1:
						task.AddTask(new global::AcpBusinessLayer.UndoRedo.ModifyDataTask<int>(portableButtonInnerSection.BtnTrunkingPortableButtonFeature_A19546, 88));
						num = (short)144113773;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 2:
						goto IL_730;
					case 3:
						goto IL_730;
					case 4:
						num = (short)727777281;
						if (num != 0)
						{
						}
						if (portableButtonInnerSection.BtnGeneralConventionalFeature_A19544.Value != 64)
						{
							num = (short)428998796;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_7CE;
					case 5:
						task.AddTask(new global::AcpBusinessLayer.UndoRedo.ModifyDataTask<int>(rsmbuttonInner.RSMButtonInnerSection.RadErgoCfgRSMlTrunkingFeature_A19742, 214));
						num = (short)1365377044;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 6:
						if (portableButtonInnerSection.BtnGeneralConventionalFeature_A19544.Value == 27)
						{
							num = (short)1933508722;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)963182721;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 7:
						if (portableButtonInnerSection.BtnGeneralConventionalFeature_A19544.Value == 235)
						{
							num = (short)407240776;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)386007136;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 8:
						task.AddTask(new global::AcpBusinessLayer.UndoRedo.ModifyDataTask<int>(rsmbuttonInner.RSMButtonInnerSection.RadErgoCfgRSMlTrunkingFeature_A19742, 211));
						num = (short)935723101;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 9:
						if (num3 == 0)
						{
							num = (short)1223164030;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_730;
					case 10:
						task.AddTask(new global::AcpBusinessLayer.UndoRedo.ModifyDataTask<int>(rsmbuttonInner.RSMButtonInnerSection.RadErgoCfgRSMlTrunkingFeature_A19742, 65));
						num = (short)801767424;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 11:
						if (num3 == 0)
						{
							num = (short)1452212270;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_730;
					case 12:
						if (num3 == 0)
						{
							num = (short)754253834;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_730;
					case 13:
						if (portableButtonInnerSection.BtnTrunkingPortableButtonFeature_A19546.Value != 236)
						{
							num = (short)1158152274;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_1870;
					case 14:
						num = (short)1281818659;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 15:
						if (portableButtonInnerSection.BtnGeneralConventionalFeature_A19544.Value == 67)
						{
							num = (short)1735196784;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)791937135;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 16:
						if (portableButtonInnerSection.BtnTrunkingPortableButtonFeature_A19546.Value != 87)
						{
							num = (short)1632567332;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_1870;
					case 17:
						num = (short)809107518;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 18:
						task.AddTask(new global::AcpBusinessLayer.UndoRedo.ModifyDataTask<int>(rsmbuttonInner.RSMButtonInnerSection.RadErgoCfgRSMlTrunkingFeature_A19742, 67));
						num = (short)5505094;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 19:
						if (portableButtonInnerSection.BtnTrunkingPortableButtonFeature_A19546.Value != 65)
						{
							num = (short)1653407861;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_1870;
					case 20:
						goto IL_730;
					case 21:
						if (portableButtonInnerSection.BtnTrunkingPortableButtonFeature_A19546.Value != 66)
						{
							num = (short)902955030;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_1870;
					case 22:
						num = (short)1843134491;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 23:
						if (num3 == 0)
						{
							num = (short)1910571084;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_730;
					case 24:
						if (portableButtonInnerSection.BtnGeneralConventionalFeature_A19544.Value != 67)
						{
							num = (short)261685323;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_7CE;
					case 25:
						task.AddTask(new global::AcpBusinessLayer.UndoRedo.ModifyDataTask<int>(portableButtonInnerSection.BtnTrunkingPortableButtonFeature_A19546, 209));
						num = (short)1182335013;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 26:
						if (portableButtonInnerSection.BtnGeneralConventionalFeature_A19544.Value != 214)
						{
							num = (short)2033057881;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_7CE;
					case 27:
						if (portableButtonInnerSection.BtnTrunkingPortableButtonFeature_A19546.Value != 67)
						{
							num = (short)1758462046;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_1870;
					case 28:
						num = (short)741867626;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 29:
						if (portableButtonInnerSection.BtnTrunkingPortableButtonFeature_A19546.Value != 212)
						{
							num = (short)539492369;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_1870;
					case 30:
						task.AddTask(new global::AcpBusinessLayer.UndoRedo.ModifyDataTask<int>(rsmbuttonInner.RSMButtonInnerSection.RadErgoCfgRSMlTrunkingFeature_A19742, 88));
						num = (short)1273102459;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 31:
						task.AddTask(new global::AcpBusinessLayer.UndoRedo.ModifyDataTask<int>(portableButtonInnerSection.BtnTrunkingPortableButtonFeature_A19546, 212));
						num = (short)1563689070;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 32:
						goto IL_730;
					case 33:
						goto IL_730;
					case 34:
						if (portableButtonInnerSection.BtnGeneralConventionalFeature_A19544.Value == 64)
						{
							num = (short)785907767;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)966459482;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 35:
						if (portableButtonInnerSection.BtnTrunkingPortableButtonFeature_A19546.Value != 88)
						{
							num = (short)1835270183;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_1870;
					case 36:
						goto IL_AA9;
					case 37:
						if (num3 == 0)
						{
							num = (short)1406140557;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_730;
					case 38:
						if (portableButtonInnerSection.BtnGeneralConventionalFeature_A19544.Value != 212)
						{
							num = (short)1284243569;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_7CE;
					case 39:
						num = (short)973340688;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 40:
						if (portableButtonInnerSection.BtnGeneralConventionalFeature_A19544.Value != 27)
						{
							num = (short)491716679;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_7CE;
					case 41:
						if (portableButtonInnerSection.BtnGeneralConventionalFeature_A19544.Value != 65)
						{
							num = (short)221380728;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_7CE;
					case 42:
						num = (short)1717305365;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 43:
						task.AddTask(new global::AcpBusinessLayer.UndoRedo.ModifyDataTask<int>(portableButtonInnerSection.BtnTrunkingPortableButtonFeature_A19546, 149));
						num = (short)1995505769;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 44:
						if (portableButtonInnerSection.BtnGeneralConventionalFeature_A19544.Value == 209)
						{
							num = (short)1251344409;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)890765378;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 45:
						goto IL_730;
					case 46:
						task.AddTask(new global::AcpBusinessLayer.UndoRedo.ModifyDataTask<int>(rsmbuttonInner.RSMButtonInnerSection.RadErgoCfgRSMlTrunkingFeature_A19742, 35));
						num = (short)1250951213;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 47:
						if (portableButtonInnerSection.BtnGeneralConventionalFeature_A19544.Value == 212)
						{
							num = (short)1559494687;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)1088618540;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 48:
						goto IL_730;
					case 49:
						goto IL_730;
					case 50:
						if (portableButtonInnerSection.BtnGeneralConventionalFeature_A19544.Value != 149)
						{
							num = (short)941752447;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_495;
					case 51:
						task.AddTask(new global::AcpBusinessLayer.UndoRedo.ModifyDataTask<int>(portableButtonInnerSection.BtnTrunkingPortableButtonFeature_A19546, 236));
						num = (short)2050883662;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 52:
						task.AddTask(new global::AcpBusinessLayer.UndoRedo.ModifyDataTask<int>(rsmbuttonInner.RSMButtonInnerSection.RadErgoCfgRSMlTrunkingFeature_A19742, 236));
						num = (short)82968649;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 53:
						goto IL_730;
					case 54:
						if (portableButtonInnerSection.BtnTrunkingPortableButtonFeature_A19546.Value != 211)
						{
							num = (short)477364349;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_1870;
					case 55:
						task.AddTask(new global::AcpBusinessLayer.UndoRedo.ModifyDataTask<int>(portableButtonInnerSection.BtnTrunkingPortableButtonFeature_A19546, 64));
						num = (short)1688993861;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 56:
						if (portableButtonInnerSection.BtnGeneralConventionalFeature_A19544.Value == 235)
						{
							num = (short)178323595;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_730;
					case 57:
						task.AddTask(new global::AcpBusinessLayer.UndoRedo.ModifyDataTask<int>(rsmbuttonInner.RSMButtonInnerSection.RadErgoCfgRSMlTrunkingFeature_A19742, 87));
						num = (short)1014693891;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 58:
						if (num3 == 0)
						{
							num = (short)1544355944;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_730;
					case 59:
						if (portableButtonInnerSection.BtnGeneralConventionalFeature_A19544.Value == 149)
						{
							num = (short)2112159787;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)1359937600;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 60:
					{
						num = (short)1788149760;
						short num4 = num;
						task.AddTask(new global::AcpBusinessLayer.UndoRedo.ModifyDataTask<int>(rsmbuttonInner.RSMButtonInnerSection.RadErgoCfgRSMlTrunkingFeature_A19742, 64));
						num = (short)2133000284;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 61:
						goto IL_1870;
					case 62:
						if (portableButtonInnerSection.BtnTrunkingPortableButtonFeature_A19546.Value != 209)
						{
							num = (short)1240596557;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_1870;
					case 63:
						num = (short)1938554982;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 64:
						if (portableButtonInnerSection.BtnGeneralConventionalFeature_A19544.Value == 214)
						{
							num = (short)1556545644;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_20D3;
					case 65:
						goto IL_495;
					case 66:
						if (portableButtonInnerSection.BtnGeneralConventionalFeature_A19544.Value == 210)
						{
							num = (short)917307475;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)994902148;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 67:
						goto IL_730;
					case 68:
						if (portableButtonInnerSection.BtnGeneralConventionalFeature_A19544.Value != 87)
						{
							num = (short)905576546;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_7CE;
					case 69:
						if (num3 == 0)
						{
							num = (short)1559494716;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_730;
					case 70:
						goto IL_730;
					case 71:
						num = (short)1670971460;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 72:
						goto IL_7CE;
					case 73:
						goto IL_730;
					case 74:
						task.AddTask(new global::AcpBusinessLayer.UndoRedo.ModifyDataTask<int>(portableButtonInnerSection.BtnTrunkingPortableButtonFeature_A19546, 65));
						num = (short)2105933836;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 75:
						num = (short)606208086;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 76:
						task.AddTask(new global::AcpBusinessLayer.UndoRedo.ModifyDataTask<int>(rsmbuttonInner.RSMButtonInnerSection.RadErgoCfgRSMlTrunkingFeature_A19742, 66));
						num = (short)203227184;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 77:
						num = (short)2109538391;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 78:
						if (num3 == 0)
						{
							num = (short)1912143924;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_730;
					case 79:
						if (num3 == 0)
						{
							num = (short)825753722;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_1B04;
					case 80:
						num = (short)1547042842;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 81:
						if (num3 == 0)
						{
							num = (short)1051394191;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_730;
					case 82:
						num = (short)785973366;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 83:
						task.AddTask(new global::AcpBusinessLayer.UndoRedo.ModifyDataTask<int>(portableButtonInnerSection.BtnTrunkingPortableButtonFeature_A19546, 210));
						num = (short)983040009;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 84:
						num = (short)1648754701;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 85:
						if (portableButtonInnerSection.BtnGeneralConventionalFeature_A19544.Value == 66)
						{
							num = (short)1101922419;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)1142620175;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 86:
						if (portableButtonInnerSection.BtnGeneralConventionalFeature_A19544.Value != 211)
						{
							num = (short)2067464316;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_7CE;
					case 87:
						if (portableButtonInnerSection.BtnTrunkingPortableButtonFeature_A19546.Value != 27)
						{
							num = (short)1055719438;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_1870;
					case 88:
						num = (short)1940520964;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 89:
						num = (short)421527696;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 90:
						if (portableButtonInnerSection.BtnGeneralConventionalFeature_A19544.Value == 65)
						{
							num = (short)869466186;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)1862926383;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 91:
						task.AddTask(new global::AcpBusinessLayer.UndoRedo.ModifyDataTask<int>(rsmbuttonInner.RSMButtonInnerSection.RadErgoCfgRSMlTrunkingFeature_A19742, 149));
						num = (short)1867382833;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 92:
						goto IL_730;
					case 93:
						goto IL_730;
					case 94:
						goto IL_E42;
					case 95:
						try
						{
							num = (short)470548483;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								switch (num2)
								{
								case 0:
								{
									if (!enumerator.MoveNext())
									{
										num = (short)1472004101;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									global::AcpCommonLib.IAcpFeatureNode acpFeatureNode = enumerator.Current;
									num = (short)1804075009;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 1:
								{
									global::AcpCommonLib.IAcpFeatureNode acpFeatureNode;
									if ((acpFeatureNode.Parent as global::AcpBusinessLayer.Recordset).IndexOf(acpFeatureNode) == 3)
									{
										num = (short)1067319302;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									break;
								}
								case 2:
									goto IL_976;
								case 3:
									switch (0)
									{
									case 0:
										goto IL_8A4;
									}
									continue;
								case 4:
								{
									num = (short)539410025;
									short num5 = num;
									num = (short)2010562153;
									switch ((num5 == num) ? 1 : 0)
									{
									case 0:
									case 2:
										break;
									default:
										goto IL_A22;
									}
									break;
								}
								case 5:
									num = (short)1429667844;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 6:
								{
									global::AcpCommonLib.IAcpFeatureNode acpFeatureNode;
									task.AddTask(new global::AcpBusinessLayer.UndoRedo.ModifyDataTask<int>((acpFeatureNode[10084] as global::Motorola.MackinawCPS.CoreFeatures.Switches.TrunkingSwitchTableInnerSection).SwitchTrunkingSwitchTablePosition1Feature_A21004, switchTrunkingSwitchesPosition3_A.Value));
									task.AddTask(new global::AcpBusinessLayer.UndoRedo.ModifyDataTask<int>((acpFeatureNode[10084] as global::Motorola.MackinawCPS.CoreFeatures.Switches.TrunkingSwitchTableInnerSection).SwitchTrunkingSwitchTablePosition2Feature_A21005, switchTrunkingSwitchesPosition4_A.Value));
									task.AddTask(new global::AcpBusinessLayer.UndoRedo.ModifyDataTask<int>((acpFeatureNode[10084] as global::Motorola.MackinawCPS.CoreFeatures.Switches.TrunkingSwitchTableInnerSection).SwitchTrunkingSwitchTablePosition3Feature_A21006, switchTrunkingSwitchesPosition5_A.Value));
									num = (short)1604059138;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								}
								IL_8A9:
								num = (short)941031424;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								IL_8A4:
								goto IL_8A9;
							}
							IL_976:
							goto IL_EC9;
							IL_A22:
							num = (short)1061093376;
							if (num != 0)
							{
							}
							goto IL_EC9;
						}
						finally
						{
							num = (short)1718747137;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								switch (num2)
								{
								case 0:
									enumerator.Dispose();
									num = (short)15663106;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 1:
									switch (0)
									{
									case 0:
										goto IL_A6E;
									}
									continue;
								case 2:
									goto IL_AA6;
								}
								IL_A6E:
								if (enumerator == null)
								{
									break;
								}
								num = (short)1040711680;
								num2 = (int)((global::System.IntPtr)num);
							}
							IL_AA6:;
						}
						goto IL_AA9;
					case 96:
						if (portableButtonInnerSection.BtnTrunkingPortableButtonFeature_A19546.Value != 149)
						{
							num = (short)1562312767;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_1870;
					case 97:
						num = (short)919535635;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 98:
						num = (short)1244921989;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 99:
						if (portableButtonInnerSection.BtnGeneralConventionalFeature_A19544.Value == 88)
						{
							num = (short)109051905;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)2026242082;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 100:
						if (num3 == 0)
						{
							num = (short)1423900729;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_730;
					case 101:
						task.AddTask(new global::AcpBusinessLayer.UndoRedo.ModifyDataTask<int>(portableButtonInnerSection.BtnTrunkingPortableButtonFeature_A19546, 87));
						num = (short)1049690212;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 102:
						if (portableButtonInnerSection.BtnTrunkingPortableButtonFeature_A19546.Value != 214)
						{
							num = (short)948043818;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_1870;
					case 103:
						try
						{
							num = (short)41091073;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								switch (num2)
								{
								case 0:
									num = (short)518586370;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 1:
									switch (0)
									{
									case 0:
										goto IL_1FD4;
									}
									continue;
								case 2:
									goto IL_205E;
								case 3:
									if (!enumerator.MoveNext())
									{
										num = (short)1615003648;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									(((global::AcpCommonLib.IAcpFeatureNode)enumerator.Current)[10082] as global::Motorola.MackinawCPS.CoreFeatures.Switches.RotaryControlInnerSection).SwitchGeneralRotaryControl_A8984.CalculateValidity();
									num = (short)250281988;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								IL_1FD6:
								num = (short)524746755;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								IL_1FD4:
								goto IL_1FD6;
							}
							IL_205E:
							goto IL_211B;
						}
						finally
						{
							num = (short)1108410369;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								switch (num2)
								{
								case 0:
									enumerator.Dispose();
									num = (short)311427074;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 1:
									switch (0)
									{
									case 0:
										goto IL_2096;
									}
									continue;
								case 2:
									goto IL_20D0;
								}
								IL_2096:
								if (enumerator == null)
								{
									break;
								}
								num = (short)1343356928;
								num2 = (int)((global::System.IntPtr)num);
							}
							IL_20D0:;
						}
						goto IL_20D3;
					case 104:
						task.AddTask(new global::AcpBusinessLayer.UndoRedo.ModifyDataTask<int>(rsmbuttonInner.RSMButtonInnerSection.RadErgoCfgRSMlTrunkingFeature_A19742, 235));
						num = (short)5374005;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 105:
						if (num3 == 0)
						{
							num = (short)951124059;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_730;
					case 106:
						if (portableButtonInnerSection.BtnGeneralConventionalFeature_A19544.Value != 236)
						{
							num = (short)1852440706;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_7CE;
					case 107:
						num = (short)728105000;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 108:
						task.AddTask(new global::AcpBusinessLayer.UndoRedo.ModifyDataTask<int>(portableButtonInnerSection.BtnTrunkingPortableButtonFeature_A19546, 214));
						num = (short)1218707587;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 109:
						if (num3 == 0)
						{
							num = (short)1740242974;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_730;
					case 110:
						if (num3 == 0)
						{
							num = (short)1987510393;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_730;
					case 111:
						if (portableButtonInnerSection.BtnGeneralConventionalFeature_A19544.Value == 211)
						{
							num = (short)1329791122;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)1759576070;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 112:
						task.AddTask(new global::AcpBusinessLayer.UndoRedo.ModifyDataTask<int>(portableButtonInnerSection.BtnTrunkingPortableButtonFeature_A19546, 67));
						num = (short)1919484039;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 113:
						num = (short)1374945396;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 114:
						task.AddTask(new global::AcpBusinessLayer.UndoRedo.ModifyDataTask<int>(portableButtonInnerSection.BtnTrunkingPortableButtonFeature_A19546, 27));
						num = (short)1695023185;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 115:
						task.AddTask(new global::AcpBusinessLayer.UndoRedo.ModifyDataTask<int>(portableButtonInnerSection.BtnTrunkingPortableButtonFeature_A19546, 66));
						num = (short)2018574359;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 116:
						if (portableButtonInnerSection.BtnGeneralConventionalFeature_A19544.Value != 209)
						{
							num = (short)1795162219;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_7CE;
					case 117:
						num = (short)1972699272;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 118:
						if (portableButtonInnerSection.BtnTrunkingPortableButtonFeature_A19546.Value == 235)
						{
							num = (short)1382940733;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_730;
					case 119:
						if (num3 == 0)
						{
							num = (short)433127432;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_730;
					case 120:
						num = (short)2035941514;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 121:
						task.AddTask(new global::AcpBusinessLayer.UndoRedo.ModifyDataTask<int>(rsmbuttonInner.RSMButtonInnerSection.RadErgoCfgRSMlTrunkingFeature_A19742, 212));
						num = (short)265879554;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 122:
						task.AddTask(new global::AcpBusinessLayer.UndoRedo.ModifyDataTask<int>(rsmbuttonInner.RSMButtonInnerSection.RadErgoCfgRSMlConventionalFeature_A19640, portableButtonInnerSection.BtnGeneralConventionalFeature_A19544.Value));
						num = (short)1677131921;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 123:
						goto IL_730;
					case 124:
						num = (short)1616117798;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 125:
						num = (short)844955677;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 126:
						task.AddTask(new global::AcpBusinessLayer.UndoRedo.ModifyDataTask<int>(rsmbuttonInner.RSMButtonInnerSection.RadErgoCfgRSMlTrunkingFeature_A19742, 210));
						num = (short)894828611;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 127:
						num = (short)925499526;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 128:
						if (portableButtonInnerSection.BtnGeneralConventionalFeature_A19544.Value != 149)
						{
							num = (short)716505168;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_7CE;
					case 129:
						if (portableButtonInnerSection.BtnGeneralConventionalFeature_A19544.Value == 87)
						{
							num = (short)926154853;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)934412387;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 130:
						num = (short)66060295;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 131:
						if (num3 == 0)
						{
							num = (short)1717370885;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_730;
					case 132:
						if (portableButtonInnerSection.BtnGeneralConventionalFeature_A19544.Value == 236)
						{
							num = (short)1399980083;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)1709703224;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 133:
						if (portableButtonInnerSection.BtnGeneralConventionalFeature_A19544.Value != 88)
						{
							num = (short)1635057752;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_7CE;
					case 134:
						if (portableButtonInnerSection.BtnGeneralConventionalFeature_A19544.Value == 214)
						{
							num = (short)516227137;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_EC9;
					case 135:
						if (num3 == 0)
						{
							num = (short)1080754194;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_730;
					case 136:
						if (portableButtonInnerSection.BtnTrunkingPortableButtonFeature_A19546.Value != 210)
						{
							num = (short)143130708;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_1870;
					case 137:
						num = (short)1782448152;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 138:
						if (portableButtonInnerSection.BtnGeneralConventionalFeature_A19544.Value != 210)
						{
							num = (short)2012741660;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_7CE;
					case 139:
						task.AddTask(new global::AcpBusinessLayer.UndoRedo.ModifyDataTask<int>(portableButtonInnerSection.BtnTrunkingPortableButtonFeature_A19546, 235));
						num = (short)1323302970;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 140:
						num = (short)704118825;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 141:
						task.AddTask(new global::AcpBusinessLayer.UndoRedo.ModifyDataTask<int>(rsmbuttonInner.RSMButtonInnerSection.RadErgoCfgRSMlTrunkingFeature_A19742, 209));
						num = (short)477298721;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 142:
						if (portableButtonInnerSection.BtnTrunkingPortableButtonFeature_A19546.Value != 64)
						{
							num = (short)1729036385;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_1870;
					case 143:
						task.AddTask(new global::AcpBusinessLayer.UndoRedo.ModifyDataTask<int>(rsmbuttonInner.RSMButtonInnerSection.RadErgoCfgRSMlTrunkingFeature_A19742, 27));
						num = (short)1261568032;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 144:
						if (portableButtonInnerSection.BtnGeneralConventionalFeature_A19544.Value != 66)
						{
							num = (short)1749155977;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_7CE;
					case 145:
						goto IL_1B04;
					case 146:
						task.AddTask(new global::AcpBusinessLayer.UndoRedo.ModifyDataTask<int>(portableButtonInnerSection.BtnTrunkingPortableButtonFeature_A19546, 211));
						num = (short)1060175991;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 147:
						try
						{
							num = (short)881065987;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								switch (num2)
								{
								case 0:
								{
									if (!enumerator.MoveNext())
									{
										num = (short)1633222661;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									global::AcpCommonLib.IAcpFeatureNode acpFeatureNode2 = enumerator.Current;
									num = (short)1047396354;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 1:
								{
									global::AcpCommonLib.IAcpFeatureNode acpFeatureNode2;
									task.AddTask(new global::AcpBusinessLayer.UndoRedo.ModifyDataTask<int>((acpFeatureNode2[10086] as global::Motorola.MackinawCPS.CoreFeatures.Switches.ConventionalSwitchTableInnerSection).SwitchConventionalSwitchTablePosition1Feature_A19655, switchConventionalSwitchesPosition3_A.Value));
									task.AddTask(new global::AcpBusinessLayer.UndoRedo.ModifyDataTask<int>((acpFeatureNode2[10086] as global::Motorola.MackinawCPS.CoreFeatures.Switches.ConventionalSwitchTableInnerSection).SwitchConventionalSwitchTablePosition2Feature_A19656, switchConventionalSwitchesPosition4_A.Value));
									task.AddTask(new global::AcpBusinessLayer.UndoRedo.ModifyDataTask<int>((acpFeatureNode2[10086] as global::Motorola.MackinawCPS.CoreFeatures.Switches.ConventionalSwitchTableInnerSection).SwitchConventionalSwitchTablePosition3Feature_A19657, switchConventionalSwitchesPosition5_A.Value));
									num = (short)1200029702;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 2:
								{
									global::AcpCommonLib.IAcpFeatureNode acpFeatureNode2;
									if ((acpFeatureNode2.Parent as global::AcpBusinessLayer.Recordset).IndexOf(acpFeatureNode2) == 3)
									{
										num = (short)1644625921;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									break;
								}
								case 3:
									switch (0)
									{
									case 0:
										goto IL_C8F;
									}
									continue;
								case 4:
									goto IL_DD0;
								case 5:
									num = (short)290783236;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 6:
									goto IL_DB3;
								}
								IL_C94:
								num = (short)31064064;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								IL_C8F:
								goto IL_C94;
							}
							IL_DB3:
							IL_DD0:
							goto IL_6C3;
						}
						finally
						{
							num = (short)290193409;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								switch (num2)
								{
								case 0:
									enumerator.Dispose();
									num = (short)970915842;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 1:
									switch (0)
									{
									case 0:
										goto IL_E07;
									}
									continue;
								case 2:
									goto IL_E3F;
								}
								IL_E07:
								if (enumerator == null)
								{
									break;
								}
								num = (short)521535488;
								num2 = (int)((global::System.IntPtr)num);
							}
							IL_E3F:;
						}
						goto IL_E42;
						IL_6C3:
						enumerator = trunkingSwitchTableInnerRecset.GetEnumerator();
						num = (short)1781137503;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_280;
					IL_495:
					task.AddTask(new global::AcpBusinessLayer.UndoRedo.ModifyDataTask<bool>(radWideLabtoolZoneSelectorOnSwitch_A, true));
					task.AddTask(new global::AcpBusinessLayer.UndoRedo.ModifyDataTask<int>(switchConventionalSwitchesPosition3_A, 30));
					task.AddTask(new global::AcpBusinessLayer.UndoRedo.ModifyDataTask<int>(switchConventionalSwitchesPosition4_A, 30));
					task.AddTask(new global::AcpBusinessLayer.UndoRedo.ModifyDataTask<int>(switchConventionalSwitchesPosition5_A, 30));
					task.AddTask(new global::AcpBusinessLayer.UndoRedo.ModifyDataTask<int>(switchTrunkingSwitchesPosition3_A, 30));
					task.AddTask(new global::AcpBusinessLayer.UndoRedo.ModifyDataTask<int>(switchTrunkingSwitchesPosition4_A, 30));
					task.AddTask(new global::AcpBusinessLayer.UndoRedo.ModifyDataTask<int>(switchTrunkingSwitchesPosition5_A, 30));
					enumerator = conventionalSwitchTableInnerRecset.GetEnumerator();
					num = (short)1385889939;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_730:
					enumerator = rotaryControlInnerRecset.GetEnumerator();
					num = (short)442040423;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_7CE:
					num = (short)1678442546;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_AA9:
					num = (short)687603854;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_E42:
					num = (short)766574646;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_EC9:
					num = (short)953286715;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_1870:
					task.AddTask(new global::AcpBusinessLayer.UndoRedo.ModifyDataTask<int>(portableButtonInnerSection.BtnTrunkingPortableButtonFeature_A19546, 35));
					num = (short)1083703307;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_1B04:
					num = (short)2113273984;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_20D3:
					num = (short)507445333;
					num2 = (int)((global::System.IntPtr)num);
				}
				IL_211B:
				(global::AcpCommonLib.FeatureManager.GetFeature(2045)[0] as global::Motorola.MackinawCPS.CoreFeatures.RadioWide.RadioWide).Location.RadWideLocationUserSelectableLocationEnable_A9605.CalculateApplicability();
				(global::AcpCommonLib.FeatureManager.GetFeature(2045)[0] as global::Motorola.MackinawCPS.CoreFeatures.RadioWide.RadioWide).Location.RadWideLocationUserSelectableLocationEnable_A9605.CalculateValidity();
				return;
				IL_280:
				portableButtonInnerSection = (self as global::Motorola.MackinawCPS.CoreFeatures.Buttons.PortableButtonInnerSection);
				global::AcpCommonLib.IAcpFeatureNode parent = portableButtonInnerSection.BtnGeneralConventionalFeature_A19544.Parent.Parent;
				num3 = (parent.Parent as global::AcpBusinessLayer.Recordset).IndexOf(parent);
				global::Motorola.MackinawCPS.CoreFeatures.Switches.SwitchesRecset switchesRecset = global::AcpCommonLib.FeatureManager.GetFeature(2038) as global::Motorola.MackinawCPS.CoreFeatures.Switches.SwitchesRecset;
				rotaryControlInnerRecset = (switchesRecset[0][10081].EmbeddedRecset as global::Motorola.MackinawCPS.CoreFeatures.Switches.RotaryControlInnerRecset);
				conventionalSwitchTableInnerRecset = ((global::AcpCommonLib.FeatureManager.GetFeature(2038) as global::Motorola.MackinawCPS.CoreFeatures.Switches.SwitchesRecset)[0][10085].EmbeddedRecset as global::Motorola.MackinawCPS.CoreFeatures.Switches.ConventionalSwitchTableInnerRecset);
				trunkingSwitchTableInnerRecset = ((global::AcpCommonLib.FeatureManager.GetFeature(2038) as global::Motorola.MackinawCPS.CoreFeatures.Switches.SwitchesRecset)[0][10083].EmbeddedRecset as global::Motorola.MackinawCPS.CoreFeatures.Switches.TrunkingSwitchTableInnerRecset);
				radWideLabtoolZoneSelectorOnSwitch_A = (switchesRecset[0][10087] as global::Motorola.MackinawCPS.CoreFeatures.Switches.ConventionalSwitches).RefRadioWide.Labtool.RadWideLabtoolZoneSelectorOnSwitch_A19550;
				switchConventionalSwitchesPosition3_A = portableButtonInnerSection.RefSwitches.ConventionalSwitches.SwitchConventionalSwitchesPosition3_A7737;
				switchConventionalSwitchesPosition4_A = portableButtonInnerSection.RefSwitches.ConventionalSwitches.SwitchConventionalSwitchesPosition4_A21530;
				switchConventionalSwitchesPosition5_A = portableButtonInnerSection.RefSwitches.ConventionalSwitches.SwitchConventionalSwitchesPosition5_A21531;
				switchTrunkingSwitchesPosition3_A = portableButtonInnerSection.RefSwitches.TrunkingSwitches.SwitchTrunkingSwitchesPosition3_A9468;
				switchTrunkingSwitchesPosition4_A = portableButtonInnerSection.RefSwitches.TrunkingSwitches.SwitchTrunkingSwitchesPosition4_A21534;
				switchTrunkingSwitchesPosition5_A = portableButtonInnerSection.RefSwitches.TrunkingSwitches.SwitchTrunkingSwitchesPosition5_A21535;
				rsmbuttonInner = ((global::AcpCommonLib.FeatureManager.GetFeature(2036)[0] as global::Motorola.MackinawCPS.CoreFeatures.RemoteSpeakerMic.RemoteSpeakerMic).General.EmbeddedRecset[0] as global::Motorola.MackinawCPS.CoreFeatures.RemoteSpeakerMic.RSMButtonInner);
				num = (short)143392847;
				num2 = (int)((global::System.IntPtr)num);
				goto IL_29;
			}
			}
		}

		// Token: 0x06008DD6 RID: 36310 RVA: 0x00855898 File Offset: 0x00853A98
		internal static bool conSetEditabilityPortTrkFeature(global::AcpCommonLib.IAcpFeatureSection self)
		{
			switch (0)
			{
			case 0:
				goto IL_88;
			}
			int num;
			global::Motorola.MackinawCPS.CoreFeatures.Buttons.PortableButtonInnerSection portableButtonInnerSection;
			short num2;
			for (;;)
			{
				IL_0A:
				switch (num)
				{
				case 0:
					if (portableButtonInnerSection.BtnGeneralConventionalFeature_A19544.Value != 209)
					{
						num2 = (short)104464411;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					return false;
				case 1:
					if (portableButtonInnerSection.BtnGeneralConventionalFeature_A19544.Value == 210)
					{
						num2 = (short)1665597463;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					return true;
				case 2:
					if (portableButtonInnerSection.BtnGeneralConventionalFeature_A19544.Value != 88)
					{
						num2 = (short)1935802385;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					return false;
				case 3:
					num2 = (short)939589637;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 4:
					num2 = (short)85458954;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 5:
					if (portableButtonInnerSection.BtnGeneralConventionalFeature_A19544.Value != 235)
					{
						num2 = (short)1908080648;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					return false;
				case 6:
					if (portableButtonInnerSection.BtnGeneralConventionalFeature_A19544.Value != 87)
					{
						num2 = (short)1968046108;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					return false;
				case 7:
					if (portableButtonInnerSection.BtnGeneralConventionalFeature_A19544.Value != 66)
					{
						num2 = (short)1588068378;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					return false;
				case 8:
					num2 = (short)1195180044;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 9:
					if (portableButtonInnerSection.BtnGeneralConventionalFeature_A19544.Value != 64)
					{
						num2 = (short)1285292043;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					return false;
				case 10:
					num2 = (short)1681588225;
					if (num2 != 0)
					{
					}
					if (portableButtonInnerSection.BtnGeneralConventionalFeature_A19544.Value != 211)
					{
						num2 = (short)1349910557;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					return false;
				case 11:
					num2 = (short)770834452;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 12:
					if (portableButtonInnerSection.BtnGeneralConventionalFeature_A19544.Value != 27)
					{
						num2 = (short)1995636751;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					return false;
				case 13:
					num2 = (short)1831600128;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 14:
					num2 = (short)10813447;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 15:
					num2 = (short)1779630089;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 16:
					num2 = (short)1345978393;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 17:
					num2 = (short)1690435585;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 18:
					if (portableButtonInnerSection.BtnGeneralConventionalFeature_A19544.Value != 212)
					{
						num2 = (short)1280507917;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					return false;
				case 19:
				{
					num2 = (short)1950744576;
					short num3 = num2;
					if (portableButtonInnerSection.BtnGeneralConventionalFeature_A19544.Value != 149)
					{
						num2 = (short)162922512;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					return false;
				}
				case 20:
					if (portableButtonInnerSection.BtnGeneralConventionalFeature_A19544.Value != 65)
					{
						num2 = (short)521076757;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					return false;
				case 21:
					num2 = (short)765460486;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 22:
					if (portableButtonInnerSection.BtnGeneralConventionalFeature_A19544.Value != 236)
					{
						num2 = (short)825360387;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					return false;
				case 23:
					goto IL_3ED;
				case 24:
					if (portableButtonInnerSection.BtnGeneralConventionalFeature_A19544.Value != 67)
					{
						goto IL_1BC;
					}
					return false;
				case 25:
					if (portableButtonInnerSection.BtnGeneralConventionalFeature_A19544.Value != 214)
					{
						num2 = (short)482541582;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					return false;
				case 26:
					num2 = (short)1531248664;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 27:
					num2 = (short)24772630;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 28:
				{
					num2 = (short)1877748542;
					short num4 = num2;
					num2 = (short)91892542;
					switch ((num4 == num2) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_1BC;
					default:
						num2 = (short)1941569536;
						if (num2 != 0)
						{
						}
						num2 = (short)2044592130;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					break;
				}
				case 29:
					num2 = (short)1990787090;
					num = (int)((global::System.IntPtr)num2);
					continue;
				}
				goto IL_88;
				IL_1BC:
				num2 = (short)1950547972;
				num = (int)((global::System.IntPtr)num2);
			}
			return false;
			IL_3ED:
			return false;
			IL_88:
			portableButtonInnerSection = (self as global::Motorola.MackinawCPS.CoreFeatures.Buttons.PortableButtonInnerSection);
			num2 = (short)1105330195;
			num = (int)((global::System.IntPtr)num2);
			goto IL_0A;
		}

		// Token: 0x06008DD7 RID: 36311 RVA: 0x00855E00 File Offset: 0x00854000
		public static bool ConConventionalPortableFeaturesSelect(global::AcpCommonLib.IAcpFeatureSection self, int index)
		{
			int a_ = 3;
			short num = (short)130875392;
			int num2 = (int)num;
			switch (num2)
			{
			default:
			{
				switch (0)
				{
				case 0:
					goto IL_423;
				}
				global::Motorola.MackinawCPS.CoreFeatures.Buttons.PortableButtonInnerSection portableButtonInnerSection;
				bool flag;
				int num4;
				global::AcpCommonLib.IAcpRecordset feature;
				global::AcpBusinessLayer.AcpListField switchConventionalSwitchesPosition1_A;
				global::AcpBusinessLayer.AcpListField switchConventionalSwitchesPosition5_A;
				global::AcpBusinessLayer.AcpListField switchTrunkingSwitchesPosition4_A;
				global::AcpCommonLib.IAcpRecordset embeddedRecset;
				global::AcpBusinessLayer.AcpListField switchTrunkingSwitchesPosition5_A;
				global::AcpBusinessLayer.AcpListField switchConventionalSwitchesPosition2_A;
				global::AcpBusinessLayer.AcpListField switchConventionalSwitchesPosition3_A;
				bool flag7;
				global::AcpBusinessLayer.AcpListField emerWideManDownTrigger_A;
				global::AcpBusinessLayer.AcpListField switchTrunkingSwitchesPosition2_A;
				global::AcpBusinessLayer.AcpListField switchConventionalSwitchesPosition4_A;
				global::AcpBusinessLayer.AcpListField switchTrunkingSwitchesPosition3_A;
				global::AcpCommonLib.IAcpRecordset embeddedRecset2;
				global::Motorola.MackinawCPS.CoreFeatures.RadioInformation.Labtool labtool;
				global::AcpBusinessLayer.AcpListField switchTrunkingSwitchesPosition1_A;
				global::Motorola.MackinawCPS.CoreFeatures.RadioWide.Features features;
				global::Motorola.MackinawCPS.CoreFeatures.RadioErgonomicsWide.RadioErgonomicsWide radioErgonomicsWide;
				for (;;)
				{
					IL_30:
					int num3;
					bool flag2;
					int num5;
					global::Motorola.MackinawCPS.CoreFeatures.Switches.Switches switches;
					bool flag5;
					int num7;
					int num8;
					int num9;
					bool flag6;
					int num10;
					int num11;
					switch (num2)
					{
					case 0:
						num = (short)1027670200;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 1:
						num = (short)1986789476;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 2:
						if (portableButtonInnerSection.ParentRecset[num3] != portableButtonInnerSection.Parent)
						{
							num = (short)34799838;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_1518;
					case 3:
						goto IL_26CD;
					case 4:
					{
						global::Motorola.MackinawCPS.CoreFeatures.RemoteSpeakerMic.RSMButtonInner rsmbuttonInner;
						if (rsmbuttonInner.RSMButtonInnerSection.RadErgoCfgRSMConventionalBCO_A19639.Value != 151)
						{
							num = (short)916586615;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_1270;
					}
					case 5:
						goto IL_25BC;
					case 6:
						num = (short)1667498220;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 7:
						num = (short)2068185227;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 8:
						if (index != 81)
						{
							num = (short)831258658;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)941293594;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 9:
						if (global::ConstraintHelper.UtilityMack.IsAlohaRadio)
						{
							num = (short)1660878878;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_1AB8;
					case 10:
						goto IL_A93;
					case 11:
						flag = false;
						num = (short)461242414;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 12:
						if (num4 == 1)
						{
							num = (short)2140143791;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_2A3F;
					case 13:
						goto IL_A2E;
					case 14:
						if (feature.Count != 0)
						{
							num = (short)232390810;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_2A3F;
					case 15:
						num = (short)1512243335;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 16:
						flag2 = false;
						goto IL_1FE8;
					case 17:
						flag = false;
						num = (short)2129133659;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 18:
						num = (short)990773376;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 19:
					{
						global::Motorola.MackinawCPS.CoreFeatures.MenuItems.MenuItems menuItems;
						if (num5 >= menuItems.General.DispMenuConventionalSelectedMenuItems_A21736.Items.Count)
						{
							num = (short)1346437316;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)94502963;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 20:
						if (switches.ConventionalSwitches.SwitchConventionalSwitchesPosition5_A21531.Value == 61)
						{
							num = (short)602079327;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_190D;
					case 21:
						if (portableButtonInnerSection.BtnGeneralConventionalBCO_A19543.Value == 170)
						{
							num = (short)2097741998;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_2A3F;
					case 22:
						num = (short)630128680;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 23:
						if (!global::ConstraintHelper.UtilityMack.IsMobile())
						{
							num = (short)1805779107;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_2A3F;
					case 24:
						if (index <= 81)
						{
							num = (short)1905066188;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)645529837;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 25:
						goto IL_1DA1;
					case 26:
						if (switchConventionalSwitchesPosition1_A.Value == 81)
						{
							num = (short)1902182411;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_2A3F;
					case 27:
					{
						bool flag3;
						flag = flag3;
						num = (short)785711206;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 28:
						goto IL_26B2;
					case 29:
						if ((portableButtonInnerSection.ParentRecset[num3] as global::Motorola.MackinawCPS.CoreFeatures.Buttons.PortableButtonInner).PortableButtonInnerSection.BtnGeneralConventionalBCO_A19543.Value != 148)
						{
							num = (short)16908522;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_1518;
					case 30:
						num = (short)575995982;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 31:
						num = (short)912851065;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 32:
					{
						if (index != 269)
						{
							num = (short)1661599946;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						int radWideFeaturesVoiceControlPriorityValue = portableButtonInnerSection.RefRadioWide.Features.RadWideFeaturesVoiceControlPriorityValue;
						bool flag3 = !(global::Motorola.MackinawCPS.CoreFeatures.RadioWide.LOVs.RadWideFeaturesVoiceControlPriorityLovStrs[radWideFeaturesVoiceControlPriorityValue] == global::CommonResources.AcgResources.ID_DISABLED);
						bool flag4 = portableButtonInnerSection.BtnGeneralConventionalBCO_A19543.Value != 96;
						num = (short)1575878888;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 33:
						goto IL_182B;
					case 34:
						num = (short)69533872;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 35:
						goto IL_2049;
					case 36:
						goto IL_1DA1;
					case 37:
						num = (short)1488322626;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 38:
					{
						int num6 = 0;
						num = (short)183762957;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 39:
						goto IL_155D;
					case 40:
						flag5 = (switchConventionalSwitchesPosition5_A.Value != 26);
						goto IL_17D0;
					case 41:
						goto IL_B8D;
					case 42:
						if (portableButtonInnerSection.BtnGeneralConventionalBCO_A19543.Value != 165)
						{
							num = (short)709427296;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_26B2;
					case 43:
						goto IL_6F4;
					case 44:
						goto IL_190D;
					case 45:
						num = (short)1613103217;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 46:
						goto IL_1769;
					case 47:
						if (index != 33)
						{
							num = (short)588382348;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)1602420809;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 48:
						if (switchTrunkingSwitchesPosition4_A.Value != 33)
						{
							num = (short)1328939124;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_D06;
					case 49:
					{
						global::Motorola.MackinawCPS.CoreFeatures.MenuItems.MenuItems menuItems2;
						if (menuItems2.General.DispMenuConventionalSelectedMenuItems_A21736.Items[num7].ItemName == global::CommonResources.AcgResources.ID_DIR)
						{
							num = (short)1814036574;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_2094;
					}
					case 50:
						goto IL_A29;
					case 51:
					{
						global::Motorola.MackinawCPS.CoreFeatures.MenuItems.MenuItems menuItems;
						if (menuItems.General.DispMenuConventionalSelectedMenuItems_A21736.Items[num5].ItemName == global::CommonResources.AcgResources.ID_SCAN)
						{
							num = (short)394461424;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_219C;
					}
					case 52:
						if (embeddedRecset != null)
						{
							num = (short)1200226378;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_C3A;
					case 53:
						goto IL_1883;
					case 54:
						goto IL_1B43;
					case 55:
						num = (short)2021720233;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 56:
						goto IL_2452;
					case 57:
						num8 = 0;
						num = (short)1205403820;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 58:
						flag2 = (switchTrunkingSwitchesPosition5_A.Value != 33);
						goto IL_1FE8;
					case 59:
						num = (short)1476395247;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 60:
						num = (short)817823812;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 61:
						if (portableButtonInnerSection.BtnGeneralConventionalBCO_A19543.Value != 165)
						{
							num = (short)69074979;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_F3A;
					case 62:
						if (portableButtonInnerSection.BtnGeneralConventionalBCO_A19543.Value != 148)
						{
							num = (short)532348985;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_190D;
					case 63:
						if (index != 31)
						{
							num = (short)779878570;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)1115947249;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 64:
						if (flag)
						{
							num = (short)248971324;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_2A3F;
					case 65:
					{
						if (num9 >= embeddedRecset.Count)
						{
							num = (short)416677972;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						global::Motorola.MackinawCPS.CoreFeatures.RemoteSpeakerMic.RSMButtonInner rsmbuttonInner2 = embeddedRecset[num9] as global::Motorola.MackinawCPS.CoreFeatures.RemoteSpeakerMic.RSMButtonInner;
						num = (short)1313341621;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 66:
						if (portableButtonInnerSection.BtnGeneralConventionalBCO_A19543.Value != 167)
						{
							num = (short)686948352;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_180F;
					case 67:
						if (flag)
						{
							num = (short)851771590;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_1883;
					case 68:
						if (feature != null)
						{
							num = (short)95289432;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_2A3F;
					case 69:
						goto IL_2408;
					case 70:
						goto IL_242D;
					case 71:
						if (global::ConstraintHelper.UtilityMack.IsMahaloRadio)
						{
							num = (short)763625702;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_278A;
					case 72:
						if (portableButtonInnerSection.BtnGeneralConventionalBCO_A19543.Value != 168)
						{
							num = (short)382664930;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_F3A;
					case 73:
						if (switchConventionalSwitchesPosition1_A.Value != 33)
						{
							num = (short)1487667297;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_D06;
					case 74:
						num9 = 0;
						num = (short)1779171367;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 75:
						num = (short)1028194416;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 76:
						goto IL_1218;
					case 77:
						flag6 = false;
						goto IL_213B;
					case 78:
						if (portableButtonInnerSection.BtnGeneralConventionalBCO_A19543.Value != 165)
						{
							num = (short)287506626;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_180F;
					case 79:
						if (portableButtonInnerSection.BtnGeneralConventionalBCO_A19543.Value != 230)
						{
							num = (short)307232822;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_2769;
					case 80:
						goto IL_2A3A;
					case 81:
						if (switchConventionalSwitchesPosition2_A.Value != 26)
						{
							num = (short)473694209;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_16E5;
					case 82:
						if (switches.ConventionalSwitches.SwitchConventionalSwitchesPosition1_A7734.Value != 61)
						{
							num = (short)1128726648;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_1EFF;
					case 83:
						num = (short)403963957;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 84:
						goto IL_C3A;
					case 85:
						goto IL_2785;
					case 86:
						goto IL_2452;
					case 87:
						num = (short)1958150391;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 88:
						num = (short)147718158;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 89:
						if (switchConventionalSwitchesPosition1_A.Value != 26)
						{
							num = (short)1751318770;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_16E5;
					case 90:
						num = (short)62521385;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 91:
						goto IL_2160;
					case 92:
						goto IL_1E60;
					case 93:
						num = (short)1983250543;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 94:
						flag = false;
						num = (short)1405288640;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 95:
						goto IL_1EFF;
					case 96:
						num = (short)776536206;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 97:
						num = (short)1982529747;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 98:
						num = (short)328532040;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 99:
						goto IL_219C;
					case 100:
						if (switchConventionalSwitchesPosition3_A.Value != 26)
						{
							num = (short)1655767196;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_16E5;
					case 101:
						num = (short)2111635517;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 102:
						goto IL_2A1C;
					case 103:
						if ((portableButtonInnerSection.ParentRecset[num3] as global::Motorola.MackinawCPS.CoreFeatures.Buttons.PortableButtonInner).PortableButtonInnerSection.BtnGeneralConventionalFeature_A19544.Value == 31)
						{
							num = (short)870383633;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_1518;
					case 104:
						flag7 = true;
						num = (short)569901132;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 105:
						num = (short)2084962366;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 106:
						num = (short)1741619368;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 107:
						if (index - 109 > 1)
						{
							num = (short)621740182;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)923402252;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 108:
						goto IL_1883;
					case 109:
						if (index != 217)
						{
							num = (short)516227273;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						flag = (emerWideManDownTrigger_A.Value != 0);
						num = (short)1812988142;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 110:
						num = (short)788398100;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 111:
						if (switchTrunkingSwitchesPosition2_A.Value != 33)
						{
							num = (short)1080819962;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_D06;
					case 112:
						if (switchConventionalSwitchesPosition4_A.Value != 33)
						{
							num = (short)276561927;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_D06;
					case 113:
						goto IL_DBF;
					case 114:
						if (index <= 31)
						{
							num = (short)1476984978;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)1173946415;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 115:
						if (num8 >= portableButtonInnerSection.ParentRecset.Count)
						{
							num = (short)394067973;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)323813521;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 116:
						num = (short)851902522;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 117:
					{
						if (num10 >= embeddedRecset.Count)
						{
							num = (short)702742611;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						global::Motorola.MackinawCPS.CoreFeatures.RemoteSpeakerMic.RSMButtonInner rsmbuttonInner = embeddedRecset[num10] as global::Motorola.MackinawCPS.CoreFeatures.RemoteSpeakerMic.RSMButtonInner;
						num = (short)1959329796;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 118:
						goto IL_1D9C;
					case 119:
						num = (short)1216479380;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 120:
						num = (short)745078931;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 121:
						goto IL_F35;
					case 122:
					{
						global::Motorola.MackinawCPS.CoreFeatures.MenuItems.MenuItems menuItems;
						if (num11 >= menuItems.General.DispMenuTrunkingSelectedMenuItems_A21735.Items.Count)
						{
							num = (short)1985937453;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)1198457010;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 123:
						if (num3 >= portableButtonInnerSection.ParentRecset.Count)
						{
							num = (short)955646183;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)1718222850;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 124:
						num = (short)1130758332;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 125:
						if (switchConventionalSwitchesPosition3_A.Value != 33)
						{
							num = (short)1755185227;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_D06;
					case 126:
						if (switchTrunkingSwitchesPosition3_A.Value != 33)
						{
							num = (short)10158213;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_D06;
					case 127:
						if (embeddedRecset != null)
						{
							num = (short)204538059;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_1883;
					case 128:
						if (feature.Count != 0)
						{
							num = (short)1603600390;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_2A3F;
					case 129:
						goto IL_257F;
					case 130:
						goto IL_6F4;
					case 131:
					{
						int num6;
						if (num6 >= embeddedRecset2.Count)
						{
							num = (short)247070899;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)903348381;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 132:
						flag5 = false;
						goto IL_17D0;
					case 133:
						num = (short)2086273072;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 134:
						num = (short)380436665;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 135:
						if (portableButtonInnerSection.BtnGeneralConventionalBCO_A19543.Value != 148)
						{
							num = (short)1720778907;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_8BA;
					case 136:
						num = (short)18940077;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 137:
						num = (short)935526408;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 138:
						goto IL_278A;
					case 139:
						if (switchConventionalSwitchesPosition5_A.Value != 33)
						{
							num = (short)770572439;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_D06;
					case 140:
						num = (short)62521510;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 141:
						if (labtool != null)
						{
							num = (short)320667855;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_1218;
					case 142:
						if (portableButtonInnerSection.BtnGeneralConventionalBCO_A19543.Value == 166)
						{
							num = (short)545521692;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)1474232329;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 143:
						num = (short)1149305019;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 144:
						if (portableButtonInnerSection.BtnGeneralConventionalBCO_A19543.Value != 166)
						{
							num = (short)1687748645;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_180F;
					case 145:
						if ((portableButtonInnerSection.ParentRecset[num8] as global::Motorola.MackinawCPS.CoreFeatures.Buttons.PortableButtonInner).PortableButtonInnerSection.BtnGeneralConventionalFeature_A19544.Value == 61)
						{
							num = (short)950010061;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_1EDB;
					case 146:
						num = (short)2136801503;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 147:
						if (switches.ConventionalSwitches.SwitchConventionalSwitchesPosition2_A7735.Value != 61)
						{
							num = (short)1557856257;
							if (num != 0)
							{
							}
							num = (short)910229666;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_1EFF;
					case 148:
					{
						global::Motorola.MackinawCPS.CoreFeatures.RemoteSpeakerMic.RSMButtonInner rsmbuttonInner;
						if (rsmbuttonInner.RSMButtonInnerSection.RadErgoCfgRSMlConventionalFeature_A19640.Value == 31)
						{
							num = (short)1633419459;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_1270;
					}
					case 149:
						flag = false;
						num = (short)1145045152;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 150:
						num = (short)1040187501;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 151:
						num = (short)760152257;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 152:
						goto IL_A93;
					case 153:
						goto IL_C3A;
					case 154:
						num = (short)728432663;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 155:
						num = (short)1633747157;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 156:
						num = (short)1560346868;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 157:
					{
						int num6;
						if ((embeddedRecset2[num6] as global::Motorola.MackinawCPS.CoreFeatures.SmartKeyFob.SmartKeyFobButtonTableInner).SmartKeyFobButtonTableInnerSection.RadErgoCfgFobConventionalFeature_A41574.Value == 61)
						{
							num = (short)1727004890;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num6++;
						num = (short)69664927;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 158:
						num = (short)836304978;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 159:
						goto IL_A2E;
					case 160:
						goto IL_25BC;
					case 161:
						flag = false;
						num = (short)810483782;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 162:
						num = (short)1043464359;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 163:
					{
						global::Motorola.MackinawCPS.CoreFeatures.MenuItems.MenuItems menuItems = feature[0] as global::Motorola.MackinawCPS.CoreFeatures.MenuItems.MenuItems;
						num5 = 0;
						num = (short)1561853988;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 164:
						if (index != 289)
						{
							num = (short)303956027;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						flag = global::Motorola.MackinawCPS.CoreFeatures.Buttons.ButtonsConstraints.ValidityBasedOnTacticalServiceOperation();
						num = (short)131006678;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 165:
						goto IL_155D;
					case 166:
						if (index != 61)
						{
							num = (short)1898446985;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)356122872;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 167:
						if (switches.ConventionalSwitches.SwitchConventionalSwitchesPosition3_A7737.Value != 61)
						{
							num = (short)971571334;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_1EFF;
					case 168:
						if (portableButtonInnerSection.BtnGeneralConventionalBCO_A19543.Value != 169)
						{
							num = (short)1270218895;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_180F;
					case 169:
						if (portableButtonInnerSection.BtnGeneralConventionalBCO_A19543.Value != 167)
						{
							num = (short)1661534306;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_F3A;
					case 170:
						num = (short)1227817052;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 171:
						if (portableButtonInnerSection.BtnGeneralConventionalBCO_A19543.Value != 230)
						{
							num = (short)9240714;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_26B2;
					case 172:
						goto IL_22BC;
					case 173:
					{
						global::Motorola.MackinawCPS.CoreFeatures.RemoteSpeakerMic.RSMButtonInner rsmbuttonInner2;
						if (rsmbuttonInner2.RSMButtonInnerSection.RadErgoCfgRSMConventionalBCO_A19639.Value != 151)
						{
							num = (short)1933836531;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_1FC5;
					}
					case 174:
						goto IL_F3A;
					case 175:
						flag = !portableButtonInnerSection.RefRadioWide.UserInformationAndPasswords.RadWideUserInformationandPasswordsRadioLock_A8836.Value;
						num = (short)2074607734;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 176:
						goto IL_17CB;
					case 177:
						goto IL_65A;
					case 178:
					{
						global::Motorola.MackinawCPS.CoreFeatures.MenuItems.MenuItems menuItems;
						if (menuItems.General.DispMenuTrunkingSelectedMenuItems_A21735.Items[num11].ItemName == global::CommonResources.AcgResources.ID_SCAN)
						{
							num = (short)1073152161;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_242D;
					}
					case 179:
						goto IL_257F;
					case 180:
					{
						global::Motorola.MackinawCPS.CoreFeatures.MenuItems.MenuItems menuItems2;
						if (num7 >= menuItems2.General.DispMenuConventionalSelectedMenuItems_A21736.Items.Count)
						{
							num = (short)546046164;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)271056945;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 181:
					{
						global::Motorola.MackinawCPS.CoreFeatures.RemoteSpeakerMic.RSMButtonInner rsmbuttonInner2;
						if (rsmbuttonInner2.RSMButtonInnerSection.RadErgoCfgRSMlConventionalFeature_A19640.Value == 61)
						{
							num = (short)2061172872;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_1FC5;
					}
					case 182:
						if (portableButtonInnerSection.BtnGeneralConventionalBCO_A19543.Value != 165)
						{
							num = (short)1593507927;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_2769;
					case 183:
						goto IL_103D;
					case 184:
						if (portableButtonInnerSection.BtnGeneralConventionalBCO_A19543.Value != 168)
						{
							num = (short)987168874;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_180F;
					case 185:
						if (switches.ConventionalSwitches.SwitchConventionalSwitchesPosition4_A21530.Value != 61)
						{
							num = (short)2120155246;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_1EFF;
					case 186:
						if (labtool.RadInfoLabtoolBluetooth_A37042.Value)
						{
							num = (short)1523581032;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_1218;
					case 187:
						if (portableButtonInnerSection.BtnGeneralConventionalBCO_A19543.Value == 170)
						{
							num = (short)546898135;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_2A3F;
					case 188:
						flag6 = (embeddedRecset2 != null);
						goto IL_213B;
					case 189:
						num = (short)492372093;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 190:
						if (flag)
						{
							num = (short)934150350;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_C3A;
					case 191:
						goto IL_8BA;
					case 192:
						goto IL_2094;
					case 193:
						if (switchTrunkingSwitchesPosition1_A.Value != 33)
						{
							num = (short)1167065181;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_D06;
					case 194:
						goto IL_1AB8;
					case 195:
						flag = false;
						num = (short)262252;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 196:
						num11 = 0;
						num = (short)648085547;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 197:
						if (portableButtonInnerSection.BtnGeneralConventionalBCO_A19543.Value != 166)
						{
							num = (short)862060599;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_F3A;
					case 198:
						num = (short)1327431807;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 199:
						if (feature != null)
						{
							num = (short)2131361810;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_2A3F;
					case 200:
						if (flag)
						{
							num = (short)1535967457;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_2A3F;
					case 201:
						num = (short)420282595;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 202:
						num = (short)1551630500;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 203:
						num10 = 0;
						num = (short)1826226262;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 204:
						num = (short)741605490;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 205:
						num = (short)1715601628;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 206:
						num = (short)1986396212;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 207:
						num = (short)444465338;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 208:
						if (global::ConstraintHelper.UtilityMack.IsMahaloRadio)
						{
							num = (short)1884356824;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_1B43;
					case 209:
						if (global::ConstraintHelper.UtilityMack.IsAlohaRadio)
						{
							num = (short)894042213;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_2049;
					case 210:
					{
						global::Motorola.MackinawCPS.CoreFeatures.MenuItems.MenuItems menuItems2 = feature[0] as global::Motorola.MackinawCPS.CoreFeatures.MenuItems.MenuItems;
						num7 = 0;
						num = (short)1416495256;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 211:
						if (switchConventionalSwitchesPosition2_A.Value != 33)
						{
							num = (short)1170604221;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_D06;
					case 212:
						num = (short)233635920;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 213:
						if (global::ConstraintHelper.UtilityMack.ProductModelId.Equals(global::AllFeatures.CodeplugGuid.b("藃雅郇柳ﳋﻍ", a_)))
						{
							num = (short)617545919;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						flag = false;
						num = (short)1256587499;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 214:
						goto IL_E2F;
					case 215:
						goto IL_180F;
					case 216:
						num = (short)1863909455;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 217:
						num = (short)108331115;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 218:
						flag = false;
						num = (short)133562497;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 219:
						goto IL_F57;
					case 220:
						if (portableButtonInnerSection.ParentRecset[num8] != self.Parent)
						{
							num = (short)910688405;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_1EDB;
					case 221:
						goto IL_2769;
					case 222:
						num = (short)121634845;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 223:
						if (index != 26)
						{
							num = (short)652017913;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)1157890137;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 224:
						goto IL_22BC;
					case 225:
						num = (short)459210951;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 226:
						num = (short)927989993;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 227:
					{
						if (index != 268)
						{
							num = (short)191627354;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						int radCfgVirtualPartnerModeValue = portableButtonInnerSection.RefRadioWide.Features.RadCfgVirtualPartnerModeValue;
						bool flag8 = global::Motorola.MackinawCPS.CoreFeatures.RadioWide.LOVs.RadCfgVirtualPartnerModeLovStrs[radCfgVirtualPartnerModeValue] == global::CommonResources.AcgResources.ID_BROADBAND;
						bool flag9 = portableButtonInnerSection.BtnGeneralConventionalBCO_A19543.Value != 96;
						flag = (flag8 && flag9);
						num = (short)841547826;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 228:
						if (flag)
						{
							num = (short)297599134;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_190D;
					case 229:
						goto IL_103D;
					case 230:
						num = (short)288424107;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 231:
					{
						num = (short)974585856;
						short num12 = num;
						goto IL_2160;
					}
					case 232:
					{
						if ((global::AcpCommonLib.FeatureManager.GetFeature(2049)[0] as global::Motorola.MackinawCPS.CoreFeatures.RadioInformation.RadioInformation).Labtool.RadInfoLabtoolQA08715VoiceControlBasic)
						{
							num = (short)1032519707;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						bool flag3;
						bool flag4;
						flag = (flag3 && flag4);
						num = (short)277348529;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 233:
						if (portableButtonInnerSection.BtnGeneralConventionalBCO_A19543.Value != 169)
						{
							num = (short)562626805;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_F3A;
					case 234:
						num = (short)1913978983;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 235:
						goto IL_1883;
					case 236:
						if (!global::ConstraintHelper.UtilityMack.IsMobile())
						{
							num = (short)1222705362;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_2A3F;
					case 237:
						if (index <= 268)
						{
							num = (short)1209073881;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)754581536;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 238:
						goto IL_1908;
					case 239:
						if (index - 290 > 1)
						{
							num = (short)951255071;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						flag = features.RadWideFeaturesChannelFallbackEnableValue;
						num = (short)2040201285;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 240:
						flag = false;
						num = (short)1567817827;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 241:
						if (radioErgonomicsWide.Advanced.RadErgoWideAdvancedSideButtonsLockEnable_A38725.Value)
						{
							num = (short)1296302185;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_190D;
					case 242:
						num = (short)371327057;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 243:
						flag = false;
						num = (short)122683545;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 244:
						if (switchConventionalSwitchesPosition4_A.Value != 26)
						{
							num = (short)1172439062;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_16E5;
					case 245:
						num = (short)966262805;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 246:
						if (flag)
						{
							num = (short)1683947644;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)772079693;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 247:
						if (portableButtonInnerSection.BtnGeneralConventionalBCO_A19543.Value == 166)
						{
							num = (short)1201340637;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)826802385;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 248:
						if (radioErgonomicsWide.Advanced.RadErgoWideAdvancedSideButtonsLockEnable_A38725.Value)
						{
							num = (short)594804751;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_1883;
					case 249:
						num = (short)1901133887;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 250:
						num = (short)250609790;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_423;
					IL_6F4:
					num = (short)1007026298;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_8BA:
					num3 = 0;
					num = (short)1519452343;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_A2E:
					num = (short)304480387;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_A93:
					num = (short)155779252;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_C3A:
					num = (short)801571062;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_D06:
					num = (short)1514536976;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_F3A:
					flag = false;
					num = (short)563806427;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_103D:
					num = (short)1702363259;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_1218:
					switches = (global::AcpCommonLib.FeatureManager.GetFeature(2038)[0] as global::Motorola.MackinawCPS.CoreFeatures.Switches.Switches);
					flag = true;
					num = (short)124977176;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_1270:
					num10++;
					num = (short)1853292600;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_1518:
					num3++;
					num = (short)663093477;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_155D:
					num = (short)793903169;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_16E5:
					num = (short)1122676009;
					short num13 = num;
					num = (short)933866793;
					switch ((num13 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						IL_2769:
						flag = false;
						num = (short)2117795925;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					default:
						num = (short)1716191232;
						if (num != 0)
						{
						}
						num = (short)647102596;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					IL_17D0:
					flag = flag5;
					num = (short)1388511432;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_180F:
					flag = false;
					num = (short)1576468513;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_1883:
					num = (short)164692039;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_190D:
					num = (short)880738512;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_1AB8:
					num = (short)1691484304;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_1B43:
					num = (short)1631453366;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_1DA1:
					num = (short)2018705427;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_1EDB:
					num8++;
					num = (short)1322516704;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_1EFF:
					flag = false;
					num = (short)1851457580;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_1FC5:
					num9++;
					num = (short)1566834853;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_1FE8:
					flag = flag2;
					num = (short)2126446656;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_2049:
					num = (short)1431830725;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_2094:
					num7++;
					num = (short)206700554;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_213B:
					if (flag6 && flag7)
					{
						num = (short)313196582;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_257F;
					IL_2160:
					num = (short)1519845443;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_219C:
					num5++;
					num = (short)3735577;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_22BC:
					num = (short)39714931;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_242D:
					num11++;
					num = (short)1310589058;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_2452:
					num = (short)1722941557;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_257F:
					num = (short)222757092;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_25BC:
					num = (short)1112211646;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_26B2:
					flag = false;
					num = (short)1246887939;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_278A:
					num = (short)631046186;
					num2 = (int)((global::System.IntPtr)num);
				}
				IL_65A:
				IL_A29:
				IL_B8D:
				IL_DBF:
				IL_E2F:
				IL_F35:
				IL_F57:
				IL_1769:
				IL_17CB:
				IL_182B:
				IL_1908:
				IL_1D9C:
				IL_1E60:
				IL_2408:
				IL_26CD:
				IL_2785:
				IL_2A1C:
				IL_2A3A:
				IL_2A3F:
				((global::AcpCommonLib.FeatureManager.GetFeature(2036)[0] as global::Motorola.MackinawCPS.CoreFeatures.RemoteSpeakerMic.RemoteSpeakerMic).General.EmbeddedRecset[0] as global::Motorola.MackinawCPS.CoreFeatures.RemoteSpeakerMic.RSMButtonInner).RSMButtonInnerSection.RadErgoCfgRSMlConventionalFeature_A19640.CalculateValidityAcrossRecset();
				(embeddedRecset2[0] as global::Motorola.MackinawCPS.CoreFeatures.SmartKeyFob.SmartKeyFobButtonTableInner).SmartKeyFobButtonTableInnerSection.RadErgoCfgFobConventionalFeature_A41574.CalculateValidityAcrossRecset();
				switchConventionalSwitchesPosition3_A.CalculateEditability();
				return flag;
				IL_423:
				portableButtonInnerSection = (self as global::Motorola.MackinawCPS.CoreFeatures.Buttons.PortableButtonInnerSection);
				switchConventionalSwitchesPosition1_A = portableButtonInnerSection.RefSwitches.ConventionalSwitches.SwitchConventionalSwitchesPosition1_A7734;
				switchConventionalSwitchesPosition2_A = portableButtonInnerSection.RefSwitches.ConventionalSwitches.SwitchConventionalSwitchesPosition2_A7735;
				switchConventionalSwitchesPosition3_A = portableButtonInnerSection.RefSwitches.ConventionalSwitches.SwitchConventionalSwitchesPosition3_A7737;
				switchConventionalSwitchesPosition4_A = portableButtonInnerSection.RefSwitches.ConventionalSwitches.SwitchConventionalSwitchesPosition4_A21530;
				switchConventionalSwitchesPosition5_A = portableButtonInnerSection.RefSwitches.ConventionalSwitches.SwitchConventionalSwitchesPosition5_A21531;
				switchTrunkingSwitchesPosition1_A = portableButtonInnerSection.RefSwitches.TrunkingSwitches.SwitchTrunkingSwitchesPosition1_A9466;
				switchTrunkingSwitchesPosition2_A = portableButtonInnerSection.RefSwitches.TrunkingSwitches.SwitchTrunkingSwitchesPosition2_A9467;
				switchTrunkingSwitchesPosition3_A = portableButtonInnerSection.RefSwitches.TrunkingSwitches.SwitchTrunkingSwitchesPosition3_A9468;
				switchTrunkingSwitchesPosition4_A = portableButtonInnerSection.RefSwitches.TrunkingSwitches.SwitchTrunkingSwitchesPosition4_A21534;
				switchTrunkingSwitchesPosition5_A = portableButtonInnerSection.RefSwitches.TrunkingSwitches.SwitchTrunkingSwitchesPosition5_A21535;
				global::AcpCommonLib.IAcpRecordset embeddedRecset3 = (global::AcpCommonLib.FeatureManager.GetFeature(2042) as global::Motorola.MackinawCPS.CoreFeatures.Buttons.ButtonsRecset)[0][10091].EmbeddedRecset;
				global::AcpCommonLib.IAcpFeatureNode parent = portableButtonInnerSection.BtnGeneralConventionalFeature_A19544.Parent.Parent;
				feature = global::AcpCommonLib.FeatureManager.GetFeature(2088);
				num4 = (parent.Parent as global::AcpBusinessLayer.Recordset).IndexOf(parent);
				emerWideManDownTrigger_A = ((global::AcpCommonLib.FeatureManager.GetFeature(2032) as global::Motorola.MackinawCPS.CoreFeatures.EmergencyWide.EmergencyWideRecset)[0][10639] as global::Motorola.MackinawCPS.CoreFeatures.EmergencyWide.ManDown).EmerWideManDownTrigger_A40001;
				radioErgonomicsWide = (global::AcpCommonLib.FeatureManager.GetFeature(2033)[0] as global::Motorola.MackinawCPS.CoreFeatures.RadioErgonomicsWide.RadioErgonomicsWide);
				embeddedRecset = global::AcpCommonLib.FeatureManager.GetFeature(2036)[0][10079].EmbeddedRecset;
				embeddedRecset2 = global::AcpCommonLib.FeatureManager.GetFeature(4130)[0][10747].EmbeddedRecset;
				labtool = (global::AcpCommonLib.FeatureManager.GetFeature(2049)[0][10107] as global::Motorola.MackinawCPS.CoreFeatures.RadioInformation.Labtool);
				features = (global::AcpCommonLib.FeatureManager.GetFeature(2045)[0][10105] as global::Motorola.MackinawCPS.CoreFeatures.RadioWide.Features);
				flag7 = false;
				num = (short)2047934605;
				num2 = (int)((global::System.IntPtr)num);
				goto IL_30;
			}
			}
		}

		// Token: 0x06008DD8 RID: 36312 RVA: 0x008588AC File Offset: 0x00856AAC
		public static bool ValidityBasedOnTacticalServiceOperation()
		{
			short num = (short)516423680;
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
				global::Motorola.MackinawCPS.CoreFeatures.ConventionalPersonality.ConventionalPersonalityRecset conventionalPersonalityRecset;
				for (;;)
				{
					IL_28:
					switch (num2)
					{
					case 0:
						goto IL_C8;
					case 1:
					{
						global::System.Collections.Generic.IEnumerator<global::AcpBusinessLayer.FeatureNode> enumerator = conventionalPersonalityRecset.GetEnumerator();
						num = (short)1766785024;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 2:
						if (conventionalPersonalityRecset != null)
						{
							num = (short)1292304385;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_7E;
					}
					goto IL_3B;
				}
				IL_7E:
				num = (short)514064384;
				short num3 = num;
				return false;
				IL_C8:
				bool flag;
				bool result;
				try
				{
					num = (short)104464389;
					num2 = (int)((global::System.IntPtr)num);
					for (;;)
					{
						switch (num2)
						{
						case 1:
						{
							int value;
							if (value == 3)
							{
								num = (short)679411720;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							flag = false;
							num = (short)1839923200;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						case 2:
							num = (short)139591681;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 3:
						{
							global::Motorola.MackinawCPS.CoreFeatures.ConventionalPersonality.ASTROCall astrocall;
							if (astrocall != null)
							{
								num = (short)2017263622;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							break;
						}
						case 4:
						{
							int value;
							if (value != 2)
							{
								num = (short)940965890;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							goto IL_202;
						}
						case 5:
							switch (0)
							{
							case 0:
								goto IL_122;
							}
							continue;
						case 6:
						{
							global::Motorola.MackinawCPS.CoreFeatures.ConventionalPersonality.ASTROCall astrocall;
							int value = astrocall.CnvPerASTROCallTacticalServicesOperation.Value;
							num = (short)803602436;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						case 7:
						{
							global::System.Collections.Generic.IEnumerator<global::AcpBusinessLayer.FeatureNode> enumerator;
							if (!enumerator.MoveNext())
							{
								num = (short)1549205515;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							global::Motorola.MackinawCPS.CoreFeatures.ConventionalPersonality.ASTROCall astrocall = ((global::AcpCommonLib.IAcpFeatureNode)enumerator.Current)[10141] as global::Motorola.MackinawCPS.CoreFeatures.ConventionalPersonality.ASTROCall;
							num = (short)474349571;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						case 8:
							goto IL_202;
						case 9:
							goto IL_284;
						case 10:
							goto IL_21F;
						case 11:
							num = (short)1792278537;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						IL_13E:
						num = (short)1702690823;
						num2 = (int)((global::System.IntPtr)num);
						continue;
						IL_122:
						goto IL_13E;
						IL_202:
						flag = true;
						result = flag;
						num = (short)136577034;
						num2 = (int)((global::System.IntPtr)num);
					}
					IL_21F:
					goto IL_344;
					IL_284:
					return flag;
				}
				finally
				{
					num = (short)1405616130;
					num2 = (int)((global::System.IntPtr)num);
					for (;;)
					{
						global::System.Collections.Generic.IEnumerator<global::AcpBusinessLayer.FeatureNode> enumerator;
						switch (num2)
						{
						case 0:
							goto IL_341;
						case 1:
						{
							enumerator.Dispose();
							num = (short)1436777002;
							short num4 = num;
							num = (short)999193130;
							switch ((num4 == num) ? 1 : 0)
							{
							case 0:
							case 2:
								goto IL_341;
							default:
								num = (short)1214185472;
								if (num != 0)
								{
								}
								num = (short)1113194496;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							break;
						}
						case 2:
							switch (0)
							{
							case 0:
								goto IL_2BB;
							}
							continue;
						}
						IL_2BB:
						if (enumerator == null)
						{
							break;
						}
						num = (short)938082305;
						num2 = (int)((global::System.IntPtr)num);
					}
					IL_341:;
				}
				IL_344:
				num = (short)203227137;
				if (num != 0)
				{
				}
				return result;
				IL_3B:
				flag = true;
				conventionalPersonalityRecset = (global::AcpCommonLib.FeatureManager.GetFeature(2059) as global::Motorola.MackinawCPS.CoreFeatures.ConventionalPersonality.ConventionalPersonalityRecset);
				num = (short)1785462786;
				num2 = (int)((global::System.IntPtr)num);
				goto IL_28;
			}
			}
		}

		// Token: 0x06008DD9 RID: 36313 RVA: 0x00858C44 File Offset: 0x00856E44
		public static void ConSyncCnvDataBtnFeature(global::AcpCommonLib.IAcpFeatureSection self, global::AcpCommonLib.UndoRedo.ContainerTask task)
		{
			short num = (short)427229184;
			int num2 = (int)num;
			switch (num2)
			{
			default:
			{
				switch (0)
				{
				case 0:
					goto IL_19B;
				}
				bool flag;
				global::AcpBusinessLayer.AcpListField acpListField;
				int featureSectionId;
				int num3;
				global::AcpBusinessLayer.AcpRecRefField acpRecRefField;
				for (;;)
				{
					IL_28:
					global::Motorola.MackinawCPS.CoreFeatures.Buttons.DataButtonInnerRecset dataButtonInnerRecset2;
					global::System.Collections.Generic.IEnumerator<global::AcpBusinessLayer.FeatureNode> enumerator;
					global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO9.ControlHeadO9Recset controlHeadO9Recset;
					global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO3.DataButtonInnerRecset dataButtonInnerRecset3;
					global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO7.ControlHeadO7Recset controlHeadO7Recset;
					global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO9.O9DataButtonInnerRecset o9DataButtonInnerRecset;
					global::Motorola.MackinawCPS.CoreFeatures.Buttons.ButtonsRecset buttonsRecset;
					global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO7.O7DataButtonInnerRecset o7DataButtonInnerRecset;
					bool flag2;
					global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO9.ConsolidatedActionBCOListInnerRecset consolidatedActionBCOListInnerRecset;
					global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO3.ControlHeadO3Recset controlHeadO3Recset;
					global::Motorola.MackinawCPS.CoreFeatures.RadioWide.RadioWide radioWide;
					switch (num2)
					{
					case 0:
						goto IL_12E0;
					case 1:
						goto IL_192D;
					case 2:
					{
						if (!flag)
						{
							num = (short)773193807;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						global::Motorola.MackinawCPS.CoreFeatures.KeypadMicAndAccessories.KeypadMicAndAccessoriesRecset keypadMicAndAccessoriesRecset = null;
						global::Motorola.MackinawCPS.CoreFeatures.KeypadMicAndAccessories.DataButtonInnerRecset dataButtonInnerRecset = null;
						keypadMicAndAccessoriesRecset = (global::AcpCommonLib.FeatureManager.GetFeature(2128) as global::Motorola.MackinawCPS.CoreFeatures.KeypadMicAndAccessories.KeypadMicAndAccessoriesRecset);
						num = (short)338690087;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 3:
						if (!acpListField.HiddenStatic)
						{
							num = (short)211091519;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_1B4C;
					case 4:
						num = (short)509476912;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 5:
						enumerator = dataButtonInnerRecset2.GetEnumerator();
						num = (short)94109741;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 6:
					{
						global::Motorola.MackinawCPS.CoreFeatures.KeypadMicAndAccessories.DataButtonInnerRecset dataButtonInnerRecset;
						if (dataButtonInnerRecset != null)
						{
							num = (short)1971650630;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_15CE;
					}
					case 7:
						if (controlHeadO9Recset != null)
						{
							num = (short)1497759752;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_226C;
					case 8:
						goto IL_1ACE;
					case 9:
						num = (short)63176784;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 10:
						if (dataButtonInnerRecset3 != null)
						{
							num = (short)717488202;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_37B;
					case 11:
						num = (short)593690675;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 12:
					{
						if (featureSectionId != 10090)
						{
							num = (short)261750846;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						global::Motorola.MackinawCPS.CoreFeatures.Buttons.DataButtonInnerSection dataButtonInnerSection = self as global::Motorola.MackinawCPS.CoreFeatures.Buttons.DataButtonInnerSection;
						num3 = dataButtonInnerSection.BtnConventionalButtonDatatButtonFeature_A22610.Value;
						acpListField = dataButtonInnerSection.BtnTrunkingButtonDatatButtonFeature_A22608;
						num = (short)1113325628;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 13:
						try
						{
							num = (short)395902978;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								switch (num2)
								{
								case 0:
								{
									global::AcpCommonLib.IAcpFeatureNode acpFeatureNode;
									if (num3 != (acpFeatureNode[10713] as global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO7.O7DataButtonInnerSection).RadErgCtrlHeadO7DataButtonTrkFeature_A41297.Value)
									{
										num = (short)131006467;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									break;
								}
								case 1:
									num = (short)403963908;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 2:
									switch (0)
									{
									case 0:
										goto IL_117D;
									}
									continue;
								case 3:
								{
									global::AcpCommonLib.IAcpFeatureNode acpFeatureNode;
									task.AddTask(new global::AcpBusinessLayer.UndoRedo.ModifyDataTask<int>((acpFeatureNode[10713] as global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO7.O7DataButtonInnerSection).RadErgCtrlHeadO7DataButtonTrkFeature_A41297, num3));
									num = (short)607256581;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 4:
									goto IL_126C;
								case 5:
									goto IL_11B6;
								case 6:
								{
									if (!enumerator.MoveNext())
									{
										num = (short)1000210433;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									global::AcpCommonLib.IAcpFeatureNode acpFeatureNode = enumerator.Current;
									num = (short)1936392192;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								}
								IL_11BB:
								num = (short)456130566;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								IL_117D:
								goto IL_11BB;
							}
							IL_11B6:
							IL_126C:
							goto IL_1BD6;
						}
						finally
						{
							num = (short)479068162;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								switch (num2)
								{
								case 0:
									enumerator.Dispose();
									num = (short)1976303617;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 1:
									goto IL_12DD;
								case 2:
									switch (0)
									{
									case 0:
										goto IL_12A4;
									}
									continue;
								}
								IL_12A4:
								if (enumerator == null)
								{
									break;
								}
								num = (short)1176764416;
								num2 = (int)((global::System.IntPtr)num);
							}
							IL_12DD:;
						}
						goto IL_12E0;
					case 14:
						if (featureSectionId != 10212)
						{
							num = (short)2082471976;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_1EB1;
					case 15:
						if (controlHeadO7Recset != null)
						{
							num = (short)1495466021;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_12E0;
					case 16:
						goto IL_217E;
					case 17:
						if (o9DataButtonInnerRecset != null)
						{
							num = (short)1971716122;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return;
					case 18:
						try
						{
							num = (short)1606483968;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								switch (num2)
								{
								case 0:
									switch (0)
									{
									case 0:
										goto IL_1D52;
									}
									continue;
								case 1:
								{
									if (!enumerator.MoveNext())
									{
										num = (short)318046212;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									global::AcpCommonLib.IAcpFeatureNode acpFeatureNode2 = enumerator.Current;
									num = (short)1645150214;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 2:
									goto IL_1D8C;
								case 3:
									goto IL_1E40;
								case 4:
									num = (short)80805891;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 5:
								{
									global::AcpCommonLib.IAcpFeatureNode acpFeatureNode2;
									task.AddTask(new global::AcpBusinessLayer.UndoRedo.ModifyDataTask<int>((acpFeatureNode2[10209] as global::Motorola.MackinawCPS.CoreFeatures.KeypadMicAndAccessories.DataButtonInnerSection).RadErgoCfgKMTrunkingKMDatatButtonFeature_A22605, num3));
									num = (short)828571650;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 6:
								{
									global::AcpCommonLib.IAcpFeatureNode acpFeatureNode2;
									if (num3 != (acpFeatureNode2[10209] as global::Motorola.MackinawCPS.CoreFeatures.KeypadMicAndAccessories.DataButtonInnerSection).RadErgoCfgKMTrunkingKMDatatButtonFeature_A22605.Value)
									{
										num = (short)267124741;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									break;
								}
								}
								IL_1D91:
								num = (short)78708737;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								IL_1D52:
								goto IL_1D91;
							}
							IL_1D8C:
							IL_1E40:
							goto IL_15CE;
						}
						finally
						{
							num = (short)891224064;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								switch (num2)
								{
								case 0:
									switch (0)
									{
									case 0:
										goto IL_1E77;
									}
									continue;
								case 1:
									goto IL_1EAE;
								case 2:
									enumerator.Dispose();
									num = (short)753598465;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								IL_1E77:
								if (enumerator == null)
								{
									break;
								}
								num = (short)94109698;
								num2 = (int)((global::System.IntPtr)num);
							}
							IL_1EAE:;
						}
						goto IL_1EB1;
					case 19:
						enumerator = o9DataButtonInnerRecset.GetEnumerator();
						num = (short)654442581;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 20:
						if (buttonsRecset != null)
						{
							num = (short)850001961;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_413;
					case 21:
						goto IL_B2A;
					case 22:
						num = (short)296615978;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 23:
						goto IL_C72;
					case 24:
						if (num3 != 227)
						{
							num = (short)834076756;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_1B4C;
					case 25:
						goto IL_6F2;
					case 26:
						enumerator = o9DataButtonInnerRecset.GetEnumerator();
						num = (short)89456698;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 27:
						goto IL_8F1;
					case 28:
						goto IL_1632;
					case 29:
						if (featureSectionId <= 10209)
						{
							num = (short)1918959616;
							short num4 = num;
							num = (short)969277472;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)435421198;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 30:
						goto IL_158D;
					case 31:
						goto IL_635;
					case 32:
						num = (short)1193148428;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 33:
						goto IL_B68;
					case 34:
						num = (short)523370577;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 35:
					{
						if (featureSectionId != 10209)
						{
							num = (short)988545071;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						global::Motorola.MackinawCPS.CoreFeatures.KeypadMicAndAccessories.DataButtonInnerSection dataButtonInnerSection2 = self as global::Motorola.MackinawCPS.CoreFeatures.KeypadMicAndAccessories.DataButtonInnerSection;
						num3 = dataButtonInnerSection2.RadErgoCfgKMConventionalKMDatatButtonFeature_A22603.Value;
						acpRecRefField = dataButtonInnerSection2.RadErgoCfgKMConventionalKMDatatButtonIndex_A41423;
						acpListField = dataButtonInnerSection2.RadErgoCfgKMTrunkingKMDatatButtonFeature_A22605;
						num = (short)1915682887;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 36:
						enumerator = dataButtonInnerRecset2.GetEnumerator();
						num = (short)2094465099;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 37:
						o7DataButtonInnerRecset = (controlHeadO7Recset[0][10717].EmbeddedRecset as global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO7.O7DataButtonInnerRecset);
						num = (short)2059206656;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 38:
						if (dataButtonInnerRecset2 != null)
						{
							num = (short)918159365;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_BBD;
					case 39:
					{
						global::Motorola.MackinawCPS.CoreFeatures.KeypadMicAndAccessories.KeypadMicAndAccessoriesRecset keypadMicAndAccessoriesRecset;
						if (keypadMicAndAccessoriesRecset != null)
						{
							num = (short)2105868352;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_B68;
					}
					case 40:
						num = (short)1814167605;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 41:
						dataButtonInnerRecset2 = (buttonsRecset[0][10089].EmbeddedRecset as global::Motorola.MackinawCPS.CoreFeatures.Buttons.DataButtonInnerRecset);
						num = (short)290455640;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 42:
						if (!flag2)
						{
							num = (short)907935810;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_226C;
					case 43:
						if (dataButtonInnerRecset3 != null)
						{
							num = (short)2140405791;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_1C51;
					case 44:
						if (dataButtonInnerRecset2 != null)
						{
							num = (short)131727396;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_EB2;
					case 45:
						try
						{
							num = (short)1337917444;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								switch (num2)
								{
								case 0:
								{
									global::AcpCommonLib.IAcpFeatureNode acpFeatureNode3;
									task.AddTask(new global::AcpBusinessLayer.UndoRedo.ModifyDataTask<int>((acpFeatureNode3[10090] as global::Motorola.MackinawCPS.CoreFeatures.Buttons.DataButtonInnerSection).BtnTrunkingButtonDatatButtonFeature_A22608, num3));
									num = (short)1679556613;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 1:
									goto IL_87E;
								case 2:
								{
									global::AcpCommonLib.IAcpFeatureNode acpFeatureNode3;
									if (num3 != (acpFeatureNode3[10090] as global::Motorola.MackinawCPS.CoreFeatures.Buttons.DataButtonInnerSection).BtnTrunkingButtonDatatButtonFeature_A22608.Value)
									{
										num = (short)1586823168;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									break;
								}
								case 3:
									num = (short)147128321;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 4:
									switch (0)
									{
									case 0:
										goto IL_790;
									}
									continue;
								case 5:
									goto IL_861;
								case 6:
								{
									if (!enumerator.MoveNext())
									{
										num = (short)104923139;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									global::AcpCommonLib.IAcpFeatureNode acpFeatureNode3 = enumerator.Current;
									num = (short)457834498;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								}
								IL_7E7:
								num = (short)1246167046;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								IL_790:
								goto IL_7E7;
							}
							IL_861:
							IL_87E:
							goto IL_BBD;
						}
						finally
						{
							num = (short)140115968;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								switch (num2)
								{
								case 0:
									switch (0)
									{
									case 0:
										goto IL_8B6;
									}
									continue;
								case 1:
									goto IL_8EE;
								case 2:
									enumerator.Dispose();
									num = (short)666894337;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								IL_8B6:
								if (enumerator == null)
								{
									break;
								}
								num = (short)183500802;
								num2 = (int)((global::System.IntPtr)num);
							}
							IL_8EE:;
						}
						goto Block_12;
					case 46:
						try
						{
							num = (short)1762459652;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								switch (num2)
								{
								case 0:
									goto IL_18A1;
								case 1:
								{
									global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO9.ConsolidatedActionBCOListInner consolidatedActionBCOListInner;
									task.AddTask(new global::AcpBusinessLayer.UndoRedo.DeleteRecordTask(consolidatedActionBCOListInner));
									num = (short)973471757;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 2:
								{
									global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO9.ConsolidatedActionBCOListInner consolidatedActionBCOListInner;
									if (consolidatedActionBCOListInner.ConsolidatedActionBCOListInnerSection.RadErgoControlO9ACBCOListBco_A36666.Value == 134)
									{
										num = (short)2038824972;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									break;
								}
								case 3:
									if (num3 != 227)
									{
										num = (short)605224961;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									flag2 = true;
									num = (short)812646405;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 4:
									switch (0)
									{
									case 0:
										goto IL_16CD;
									}
									continue;
								case 5:
									if (acpRecRefField != null)
									{
										num = (short)682098696;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									goto IL_18A1;
								case 6:
								{
									if (!enumerator.MoveNext())
									{
										num = (short)784859136;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO9.ConsolidatedActionBCOListInner consolidatedActionBCOListInner = (global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO9.ConsolidatedActionBCOListInner)enumerator.Current;
									num = (short)1983578114;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 7:
								{
									global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO9.ConsolidatedActionBCOListInner consolidatedActionBCOListInner;
									if (acpRecRefField.Value != consolidatedActionBCOListInner.ConsolidatedActionBCOListInnerSection.RadErgoControlO9ACBCOListIndex_A36668.Value)
									{
										num = (short)1102053387;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									goto IL_18A1;
								}
								case 8:
									num = (short)2027945991;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 9:
									goto IL_1705;
								case 10:
									goto IL_18B9;
								case 11:
								{
									global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO9.ConsolidatedActionBCOListInner consolidatedActionBCOListInner;
									task.AddTask(new global::AcpBusinessLayer.UndoRedo.ModifyRecRefDataTask(consolidatedActionBCOListInner.ConsolidatedActionBCOListInnerSection.RadErgoControlO9ACBCOListIndex_A36668, acpRecRefField.UIValue));
									num = (short)676921353;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 12:
									num = (short)1087438851;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 13:
									goto IL_1790;
								}
								IL_17E7:
								num = (short)1991966726;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								IL_16CD:
								goto IL_17E7;
								IL_18A1:
								num = (short)133431306;
								num2 = (int)((global::System.IntPtr)num);
							}
							IL_1705:
							IL_1790:
							IL_18B9:
							goto IL_AEA;
						}
						finally
						{
							num = (short)1442709504;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								switch (num2)
								{
								case 0:
									switch (0)
									{
									case 0:
										goto IL_18F1;
									}
									continue;
								case 1:
									goto IL_192A;
								case 2:
									enumerator.Dispose();
									num = (short)720699393;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								IL_18F1:
								if (enumerator == null)
								{
									break;
								}
								num = (short)464060418;
								num2 = (int)((global::System.IntPtr)num);
							}
							IL_192A:;
						}
						goto Block_30;
					case 47:
						num = (short)842334233;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 48:
						if (num3 == 228)
						{
							num = (short)1613234185;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_217E;
					case 49:
						if (controlHeadO9Recset != null)
						{
							num = (short)1054277699;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_B2A;
					case 50:
						enumerator = o7DataButtonInnerRecset.GetEnumerator();
						num = (short)1752629324;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 51:
					{
						if (featureSectionId != 10713)
						{
							num = (short)1421148194;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO7.O7DataButtonInnerSection o7DataButtonInnerSection = self as global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO7.O7DataButtonInnerSection;
						num3 = o7DataButtonInnerSection.RadErgCtrlHeadO7DataButtonCnvFeature_A41299.Value;
						acpRecRefField = o7DataButtonInnerSection.CHO7DataButtonConvIndex_A41417;
						acpListField = o7DataButtonInnerSection.RadErgCtrlHeadO7DataButtonTrkFeature_A41297;
						num = (short)857079836;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 52:
						goto IL_1632;
					case 53:
						if (featureSectionId != 10608)
						{
							num = (short)400031755;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_10BB;
					case 54:
					{
						global::Motorola.MackinawCPS.CoreFeatures.KeypadMicAndAccessories.DataButtonInnerRecset dataButtonInnerRecset;
						if (dataButtonInnerRecset != null)
						{
							num = (short)1836712018;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_222E;
					}
					case 55:
						if (o7DataButtonInnerRecset != null)
						{
							num = (short)723058738;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_1C14;
					case 56:
						if (consolidatedActionBCOListInnerRecset != null)
						{
							num = (short)1394999374;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_226C;
					case 57:
						if (acpListField != null)
						{
							num = (short)203358238;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return;
					case 58:
						try
						{
							num = (short)847249412;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								switch (num2)
								{
								case 0:
								{
									global::AcpCommonLib.IAcpFeatureNode acpFeatureNode4;
									if (num3 != (acpFeatureNode4[10608] as global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO9.O9DataButtonInnerSection).RadErgCtrlHeadO9DataButtonTrkFeature_A36526.Value)
									{
										num = (short)1490288646;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									break;
								}
								case 1:
									goto IL_5C1;
								case 2:
									goto IL_50A;
								case 3:
								{
									if (!enumerator.MoveNext())
									{
										num = (short)1976107013;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									global::AcpCommonLib.IAcpFeatureNode acpFeatureNode4 = enumerator.Current;
									num = (short)1941307392;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 4:
									switch (0)
									{
									case 0:
										goto IL_4CE;
									}
									continue;
								case 5:
									num = (short)725680129;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 6:
								{
									global::AcpCommonLib.IAcpFeatureNode acpFeatureNode4;
									task.AddTask(new global::AcpBusinessLayer.UndoRedo.ModifyDataTask<int>((acpFeatureNode4[10608] as global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO9.O9DataButtonInnerSection).RadErgCtrlHeadO9DataButtonTrkFeature_A36526, num3));
									num = (short)1556545538;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								}
								IL_56E:
								num = (short)540147715;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								IL_4CE:
								goto IL_56E;
							}
							IL_50A:
							IL_5C1:
							return;
						}
						finally
						{
							num = (short)861929472;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								switch (num2)
								{
								case 0:
									switch (0)
									{
									case 0:
										goto IL_5F9;
									}
									continue;
								case 1:
									goto IL_632;
								case 2:
									enumerator.Dispose();
									num = (short)810811393;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								IL_5F9:
								if (enumerator == null)
								{
									break;
								}
								num = (short)941228034;
								num2 = (int)((global::System.IntPtr)num);
							}
							IL_632:;
						}
						goto IL_635;
					case 59:
						goto IL_1632;
					case 60:
						goto IL_1632;
					case 61:
						if (num3 == 227)
						{
							num = (short)682885142;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_226C;
					case 62:
						num = (short)223346723;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 63:
						goto IL_15C9;
					case 64:
					{
						global::Motorola.MackinawCPS.CoreFeatures.KeypadMicAndAccessories.KeypadMicAndAccessoriesRecset keypadMicAndAccessoriesRecset;
						global::Motorola.MackinawCPS.CoreFeatures.KeypadMicAndAccessories.DataButtonInnerRecset dataButtonInnerRecset = keypadMicAndAccessoriesRecset[0][10228].EmbeddedRecset as global::Motorola.MackinawCPS.CoreFeatures.KeypadMicAndAccessories.DataButtonInnerRecset;
						num = (short)1613037601;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 65:
						if (controlHeadO3Recset != null)
						{
							num = (short)1868169299;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_C72;
					case 66:
					{
						task.AddTask(new global::AcpBusinessLayer.UndoRedo.AddRecordTask(consolidatedActionBCOListInnerRecset.CreateDefaultRecord()));
						int index = consolidatedActionBCOListInnerRecset.Count - 1;
						global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO9.ConsolidatedActionBCOListInner consolidatedActionBCOListInner2 = consolidatedActionBCOListInnerRecset[index] as global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO9.ConsolidatedActionBCOListInner;
						task.AddTask(new global::AcpBusinessLayer.UndoRedo.ModifyDataTask<int>(consolidatedActionBCOListInner2.ConsolidatedActionBCOListInnerSection.RadErgoControlO9ACBCOListBco_A36666, 134));
						task.AddTask(new global::AcpBusinessLayer.UndoRedo.ModifyRecRefDataTask(consolidatedActionBCOListInner2.ConsolidatedActionBCOListInnerSection.RadErgoControlO9ACBCOListIndex_A36668, acpRecRefField.UIValue));
						num = (short)723451991;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 67:
						o9DataButtonInnerRecset = (controlHeadO9Recset[0][10611].EmbeddedRecset as global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO9.O9DataButtonInnerRecset);
						num = (short)154140693;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 68:
						if (controlHeadO9Recset.Count > 0)
						{
							num = (short)1842610249;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_226C;
					case 69:
						goto IL_1632;
					case 70:
					{
						global::Motorola.MackinawCPS.CoreFeatures.KeypadMicAndAccessories.DataButtonInnerRecset dataButtonInnerRecset;
						enumerator = dataButtonInnerRecset.GetEnumerator();
						num = (short)360185874;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 71:
						goto IL_1632;
					case 72:
						if (o9DataButtonInnerRecset != null)
						{
							num = (short)1299972115;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_259;
					case 73:
						consolidatedActionBCOListInnerRecset = (controlHeadO9Recset[0][10622].EmbeddedRecset as global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO9.ConsolidatedActionBCOListInnerRecset);
						num = (short)1754136632;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 74:
						enumerator = dataButtonInnerRecset3.GetEnumerator();
						num = (short)836304973;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 75:
						try
						{
							num = (short)1352466434;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								switch (num2)
								{
								case 0:
								{
									global::AcpCommonLib.IAcpFeatureNode acpFeatureNode5;
									if (num3 != (acpFeatureNode5[10090] as global::Motorola.MackinawCPS.CoreFeatures.Buttons.DataButtonInnerSection).BtnConventionalButtonDatatButtonFeature_A22610.Value)
									{
										num = (short)124387331;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									break;
								}
								case 1:
									num = (short)201392132;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 2:
									switch (0)
									{
									case 0:
										goto IL_142D;
									}
									continue;
								case 3:
								{
									global::AcpCommonLib.IAcpFeatureNode acpFeatureNode5;
									task.AddTask(new global::AcpBusinessLayer.UndoRedo.ModifyDataTask<int>((acpFeatureNode5[10090] as global::Motorola.MackinawCPS.CoreFeatures.Buttons.DataButtonInnerSection).BtnConventionalButtonDatatButtonFeature_A22610, num3));
									num = (short)1276116997;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 4:
									goto IL_151B;
								case 5:
									goto IL_1467;
								case 6:
								{
									if (!enumerator.MoveNext())
									{
										num = (short)43384833;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									global::AcpCommonLib.IAcpFeatureNode acpFeatureNode5 = enumerator.Current;
									num = (short)997916672;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								}
								IL_146C:
								num = (short)1249312774;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								IL_142D:
								goto IL_146C;
							}
							IL_1467:
							IL_151B:
							goto IL_EB2;
						}
						finally
						{
							num = (short)1966473218;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								switch (num2)
								{
								case 0:
									enumerator.Dispose();
									num = (short)1494286337;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 1:
									goto IL_158A;
								case 2:
									switch (0)
									{
									case 0:
										goto IL_1552;
									}
									continue;
								}
								IL_1552:
								if (enumerator == null)
								{
									break;
								}
								num = (short)1618542592;
								num2 = (int)((global::System.IntPtr)num);
							}
							IL_158A:;
						}
						goto IL_158D;
					case 76:
						try
						{
							num = (short)1945174018;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								switch (num2)
								{
								case 0:
								{
									global::AcpCommonLib.IAcpFeatureNode acpFeatureNode6;
									if (num3 != (acpFeatureNode6[10713] as global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO7.O7DataButtonInnerSection).RadErgCtrlHeadO7DataButtonCnvFeature_A41299.Value)
									{
										num = (short)1200160771;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									break;
								}
								case 1:
									num = (short)1420099588;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 2:
									switch (0)
									{
									case 0:
										goto IL_D4F;
									}
									continue;
								case 3:
								{
									global::AcpCommonLib.IAcpFeatureNode acpFeatureNode6;
									task.AddTask(new global::AcpBusinessLayer.UndoRedo.ModifyDataTask<int>((acpFeatureNode6[10713] as global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO7.O7DataButtonInnerSection).RadErgCtrlHeadO7DataButtonCnvFeature_A41299, num3));
									num = (short)1804795909;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 4:
									goto IL_E3E;
								case 5:
									goto IL_D88;
								case 6:
								{
									if (!enumerator.MoveNext())
									{
										num = (short)377946113;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									global::AcpCommonLib.IAcpFeatureNode acpFeatureNode6 = enumerator.Current;
									num = (short)2071330816;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								}
								IL_D8D:
								num = (short)1918369798;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								IL_D4F:
								goto IL_D8D;
							}
							IL_D88:
							IL_E3E:
							goto IL_1C14;
						}
						finally
						{
							num = (short)2098987010;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								switch (num2)
								{
								case 0:
									enumerator.Dispose();
									num = (short)287178753;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 1:
									goto IL_EAF;
								case 2:
									switch (0)
									{
									case 0:
										goto IL_E76;
									}
									continue;
								}
								IL_E76:
								if (enumerator == null)
								{
									break;
								}
								num = (short)671875072;
								num2 = (int)((global::System.IntPtr)num);
							}
							IL_EAF:;
						}
						goto IL_EB2;
					case 77:
						try
						{
							num = (short)1637744642;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								switch (num2)
								{
								case 0:
								{
									if (!enumerator.MoveNext())
									{
										num = (short)1338703875;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									global::AcpCommonLib.IAcpFeatureNode acpFeatureNode7 = enumerator.Current;
									num = (short)188874757;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 1:
									goto IL_FE8;
								case 2:
									switch (0)
									{
									case 0:
										goto IL_F54;
									}
									continue;
								case 3:
									num = (short)672006148;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 4:
									goto IL_1048;
								case 5:
								{
									global::AcpCommonLib.IAcpFeatureNode acpFeatureNode7;
									if (num3 != (acpFeatureNode7[10212] as global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO3.DataButtonInnerSection).CntrlHeadO3TrunkingO3DatatButtonFeature_A22597.Value)
									{
										num = (short)2008285190;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									break;
								}
								case 6:
								{
									global::AcpCommonLib.IAcpFeatureNode acpFeatureNode7;
									task.AddTask(new global::AcpBusinessLayer.UndoRedo.ModifyDataTask<int>((acpFeatureNode7[10212] as global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO3.DataButtonInnerSection).CntrlHeadO3TrunkingO3DatatButtonFeature_A22597, num3));
									num = (short)1248657409;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								}
								IL_FED:
								num = (short)1773076480;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								IL_F54:
								goto IL_FED;
							}
							IL_FE8:
							IL_1048:
							goto IL_37B;
						}
						finally
						{
							num = (short)297861122;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								switch (num2)
								{
								case 0:
									enumerator.Dispose();
									num = (short)568131585;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 1:
									goto IL_10B8;
								case 2:
									switch (0)
									{
									case 0:
										goto IL_107F;
									}
									continue;
								}
								IL_107F:
								if (enumerator == null)
								{
									break;
								}
								num = (short)1022427136;
								num2 = (int)((global::System.IntPtr)num);
							}
							IL_10B8:;
						}
						goto IL_10BB;
					case 78:
						enumerator = consolidatedActionBCOListInnerRecset.GetEnumerator();
						num = (short)1902313518;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 79:
						return;
					case 80:
						if (radioWide.DualRadio.RadWideDualRadioSelection_A42236 == 0)
						{
							num = (short)766115841;
							if (num != 0)
							{
							}
							num = (short)1975255056;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_1B4C;
					case 81:
						goto IL_6F2;
					case 82:
					{
						global::Motorola.MackinawCPS.CoreFeatures.KeypadMicAndAccessories.DataButtonInnerRecset dataButtonInnerRecset;
						enumerator = dataButtonInnerRecset.GetEnumerator();
						num = (short)901185563;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 83:
						dataButtonInnerRecset3 = (controlHeadO3Recset[0][10234].EmbeddedRecset as global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO3.DataButtonInnerRecset);
						num = (short)1435107351;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 84:
						num = (short)1790312538;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 85:
						try
						{
							num = (short)702414848;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								switch (num2)
								{
								case 0:
									switch (0)
									{
									case 0:
										goto IL_2018;
									}
									continue;
								case 1:
								{
									global::AcpCommonLib.IAcpFeatureNode acpFeatureNode8;
									task.AddTask(new global::AcpBusinessLayer.UndoRedo.ModifyDataTask<int>((acpFeatureNode8[10608] as global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO9.O9DataButtonInnerSection).RadErgCtrlHeadO9DataButtonCnvFeature_A36528, num3));
									num = (short)417595396;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 2:
								{
									global::AcpCommonLib.IAcpFeatureNode acpFeatureNode8;
									if (num3 != (acpFeatureNode8[10608] as global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO9.O9DataButtonInnerSection).RadErgCtrlHeadO9DataButtonCnvFeature_A36528.Value)
									{
										num = (short)550895617;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									break;
								}
								case 3:
									goto IL_2109;
								case 4:
									goto IL_20AD;
								case 5:
									num = (short)472383491;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 6:
								{
									if (!enumerator.MoveNext())
									{
										num = (short)1323958277;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									global::AcpCommonLib.IAcpFeatureNode acpFeatureNode8 = enumerator.Current;
									num = (short)823590914;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								}
								IL_20B2:
								num = (short)588513286;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								IL_2018:
								goto IL_20B2;
							}
							IL_20AD:
							IL_2109:
							goto IL_259;
						}
						finally
						{
							num = (short)830210048;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								switch (num2)
								{
								case 0:
									switch (0)
									{
									case 0:
										goto IL_2141;
									}
									continue;
								case 1:
									goto IL_217B;
								case 2:
									enumerator.Dispose();
									num = (short)1640431617;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								IL_2141:
								if (enumerator == null)
								{
									break;
								}
								num = (short)1275396098;
								num2 = (int)((global::System.IntPtr)num);
							}
							IL_217B:;
						}
						goto IL_217E;
					case 86:
						if (o7DataButtonInnerRecset != null)
						{
							num = (short)1333133401;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_1BD6;
					case 87:
						goto IL_226C;
					case 88:
						goto IL_413;
					case 89:
						enumerator = o7DataButtonInnerRecset.GetEnumerator();
						num = (short)481820685;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 90:
						if (num3 != 140)
						{
							num = (short)1438777348;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_1B4C;
					}
					goto IL_19B;
					IL_259:
					consolidatedActionBCOListInnerRecset = null;
					flag2 = false;
					num = (short)227803143;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_37B:
					num = (short)1839136854;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_413:
					controlHeadO3Recset = null;
					dataButtonInnerRecset3 = null;
					controlHeadO3Recset = (global::AcpCommonLib.FeatureManager.GetFeature(2127) as global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO3.ControlHeadO3Recset);
					num = (short)232325185;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_635:
					enumerator = dataButtonInnerRecset3.GetEnumerator();
					num = (short)1062404097;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_6F2:
					flag = false;
					num = (short)728891444;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_AEA:
					num = (short)754057277;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					Block_12:
					try
					{
						IL_8F1:
						num = (short)1368260612;
						num2 = (int)((global::System.IntPtr)num);
						for (;;)
						{
							switch (num2)
							{
							case 0:
							{
								global::AcpCommonLib.IAcpFeatureNode acpFeatureNode9;
								if (num3 != (acpFeatureNode9[10209] as global::Motorola.MackinawCPS.CoreFeatures.KeypadMicAndAccessories.DataButtonInnerSection).RadErgoCfgKMConventionalKMDatatButtonFeature_A22603.Value)
								{
									num = (short)329842694;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								break;
							}
							case 1:
								goto IL_A27;
							case 2:
								goto IL_96F;
							case 3:
							{
								if (!enumerator.MoveNext())
								{
									num = (short)286261253;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								global::AcpCommonLib.IAcpFeatureNode acpFeatureNode9 = enumerator.Current;
								num = (short)62324736;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							case 4:
								switch (0)
								{
								case 0:
									goto IL_933;
								}
								continue;
							case 5:
								num = (short)1174274049;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							case 6:
							{
								global::AcpCommonLib.IAcpFeatureNode acpFeatureNode9;
								task.AddTask(new global::AcpBusinessLayer.UndoRedo.ModifyDataTask<int>((acpFeatureNode9[10209] as global::Motorola.MackinawCPS.CoreFeatures.KeypadMicAndAccessories.DataButtonInnerSection).RadErgoCfgKMConventionalKMDatatButtonFeature_A22603, num3));
								num = (short)2070609922;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							}
							IL_9D2:
							num = (short)1376190467;
							num2 = (int)((global::System.IntPtr)num);
							continue;
							IL_933:
							goto IL_9D2;
						}
						IL_96F:
						IL_A27:
						goto IL_222E;
					}
					finally
					{
						num = (short)1645805568;
						num2 = (int)((global::System.IntPtr)num);
						for (;;)
						{
							switch (num2)
							{
							case 0:
								switch (0)
								{
								case 0:
									goto IL_A5F;
								}
								continue;
							case 1:
								goto IL_AE7;
							case 2:
							{
								num = (short)1899269286;
								short num5 = num;
								num = (short)415730854;
								switch ((num5 == num) ? 1 : 0)
								{
								case 0:
								case 2:
									goto IL_AE7;
								default:
									num = (short)478740480;
									if (num != 0)
									{
									}
									enumerator.Dispose();
									num = (short)715128833;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								break;
							}
							}
							IL_A5F:
							if (enumerator == null)
							{
								break;
							}
							num = (short)267190274;
							num2 = (int)((global::System.IntPtr)num);
						}
						IL_AE7:;
					}
					goto IL_AEA;
					IL_B2A:
					num = (short)361627692;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_B68:
					buttonsRecset = null;
					dataButtonInnerRecset2 = null;
					buttonsRecset = (global::AcpCommonLib.FeatureManager.GetFeature(2042) as global::Motorola.MackinawCPS.CoreFeatures.Buttons.ButtonsRecset);
					num = (short)1973092372;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_BBD:
					num = (short)6684678;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_C72:
					controlHeadO7Recset = null;
					o7DataButtonInnerRecset = null;
					controlHeadO7Recset = (global::AcpCommonLib.FeatureManager.GetFeature(4114) as global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO7.ControlHeadO7Recset);
					num = (short)2012348431;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_EB2:
					num = (short)91029558;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_10BB:
					global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO9.O9DataButtonInnerSection o9DataButtonInnerSection = self as global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO9.O9DataButtonInnerSection;
					num3 = o9DataButtonInnerSection.RadErgCtrlHeadO9DataButtonCnvFeature_A36528.Value;
					acpRecRefField = o9DataButtonInnerSection.CHO9DataButtonConvIndex_A41414;
					acpListField = o9DataButtonInnerSection.RadErgCtrlHeadO9DataButtonTrkFeature_A36526;
					num = (short)1891434555;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_12E0:
					controlHeadO9Recset = null;
					o9DataButtonInnerRecset = null;
					controlHeadO9Recset = (global::AcpCommonLib.FeatureManager.GetFeature(4003) as global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO9.ControlHeadO9Recset);
					num = (short)1145372721;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_158D:
					num = (short)452853763;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_15CE:
					num = (short)857604106;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_1632:
					num = (short)1477181442;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_1ACE:
					num = (short)665780292;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					Block_30:
					try
					{
						IL_192D:
						num = (short)1530265600;
						num2 = (int)((global::System.IntPtr)num);
						for (;;)
						{
							switch (num2)
							{
							case 0:
								switch (0)
								{
								case 0:
									goto IL_1970;
								}
								continue;
							case 1:
							{
								global::AcpCommonLib.IAcpFeatureNode acpFeatureNode10;
								task.AddTask(new global::AcpBusinessLayer.UndoRedo.ModifyDataTask<int>((acpFeatureNode10[10212] as global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO3.DataButtonInnerSection).CntrlHeadO3ConventionalO3DatatButtonFeature_A22595, num3));
								num = (short)643629061;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							case 2:
							{
								global::AcpCommonLib.IAcpFeatureNode acpFeatureNode10;
								if (num3 != (acpFeatureNode10[10212] as global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO3.DataButtonInnerSection).CntrlHeadO3ConventionalO3DatatButtonFeature_A22595.Value)
								{
									num = (short)423034881;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								break;
							}
							case 3:
								goto IL_1A5A;
							case 4:
							{
								if (!enumerator.MoveNext())
								{
									num = (short)1232404486;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								global::AcpCommonLib.IAcpFeatureNode acpFeatureNode10 = enumerator.Current;
								num = (short)2108489730;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							case 5:
								goto IL_1A3C;
							case 6:
								num = (short)1907556355;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							IL_19C6:
							num = (short)1837301764;
							num2 = (int)((global::System.IntPtr)num);
							continue;
							IL_1970:
							goto IL_19C6;
						}
						IL_1A3C:
						IL_1A5A:
						goto IL_1C51;
					}
					finally
					{
						num = (short)1546321920;
						num2 = (int)((global::System.IntPtr)num);
						for (;;)
						{
							switch (num2)
							{
							case 0:
								switch (0)
								{
								case 0:
									goto IL_1A93;
								}
								continue;
							case 1:
								goto IL_1ACB;
							case 2:
								enumerator.Dispose();
								num = (short)1177485313;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							IL_1A93:
							if (enumerator == null)
							{
								break;
							}
							num = (short)1553006594;
							num2 = (int)((global::System.IntPtr)num);
						}
						IL_1ACB:;
					}
					goto IL_1ACE;
					IL_1B4C:
					num = (short)1420230694;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_1BD6:
					num = (short)844759057;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_1C14:
					num = (short)136052808;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_1C51:
					num = (short)1692991543;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_1EB1:
					global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO3.DataButtonInnerSection dataButtonInnerSection3 = self as global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO3.DataButtonInnerSection;
					num3 = dataButtonInnerSection3.CntrlHeadO3ConventionalO3DatatButtonFeature_A22595.Value;
					acpRecRefField = dataButtonInnerSection3.CHO3DataButtonConvIndex_A41419;
					acpListField = dataButtonInnerSection3.CntrlHeadO3TrunkingO3DatatButtonFeature_A22597;
					num = (short)1659961413;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_217E:
					num = (short)1443037241;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_222E:
					num = (short)820641835;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_226C:
					radioWide = ((global::AcpCommonLib.FeatureManager.GetFeature(2045) as global::Motorola.MackinawCPS.CoreFeatures.RadioWide.RadioWideRecset)[0] as global::Motorola.MackinawCPS.CoreFeatures.RadioWide.RadioWide);
					num = (short)1479147544;
					num2 = (int)((global::System.IntPtr)num);
				}
				return;
				IL_15C9:
				return;
				IL_19B:
				num3 = 0;
				flag = true;
				acpRecRefField = null;
				acpListField = null;
				featureSectionId = self.FeatureSectionId;
				num = (short)1486487581;
				num2 = (int)((global::System.IntPtr)num);
				goto IL_28;
			}
			}
		}

		// Token: 0x06008DDA RID: 36314 RVA: 0x0085B090 File Offset: 0x00859290
		public static void ConSyncTrkDataBtnFeature(global::AcpCommonLib.IAcpFeatureSection self, global::AcpCommonLib.UndoRedo.ContainerTask task)
		{
			short num = (short)1464336384;
			int num2 = (int)num;
			switch (num2)
			{
			default:
			{
				switch (0)
				{
				case 0:
					goto IL_18A;
				}
				int num3;
				bool flag;
				int featureSectionId;
				global::AcpBusinessLayer.AcpRecRefField acpRecRefField;
				for (;;)
				{
					IL_27:
					global::System.Collections.Generic.IEnumerator<global::AcpBusinessLayer.FeatureNode> enumerator;
					global::Motorola.MackinawCPS.CoreFeatures.KeypadMicAndAccessories.DataButtonInnerRecset dataButtonInnerRecset;
					global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO9.ControlHeadO9Recset controlHeadO9Recset;
					global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO3.DataButtonInnerRecset dataButtonInnerRecset2;
					global::Motorola.MackinawCPS.CoreFeatures.Buttons.ButtonsRecset buttonsRecset;
					global::Motorola.MackinawCPS.CoreFeatures.Buttons.DataButtonInnerRecset dataButtonInnerRecset3;
					global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO3.ControlHeadO3Recset controlHeadO3Recset;
					global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO9.O9DataButtonInnerRecset o9DataButtonInnerRecset;
					global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO9.ConsolidatedActionBCOListInnerRecset consolidatedActionBCOListInnerRecset;
					global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO7.O7DataButtonInnerRecset o7DataButtonInnerRecset;
					bool flag2;
					global::Motorola.MackinawCPS.CoreFeatures.RadioWide.RadioWide radioWide;
					global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO7.ControlHeadO7Recset controlHeadO7Recset;
					switch (num2)
					{
					case 0:
						try
						{
							num = (short)2005139456;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								switch (num2)
								{
								case 0:
									switch (0)
									{
									case 0:
										goto IL_1F3F;
									}
									continue;
								case 1:
								{
									if (!enumerator.MoveNext())
									{
										num = (short)519569412;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									global::AcpCommonLib.IAcpFeatureNode acpFeatureNode = enumerator.Current;
									num = (short)913047557;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 2:
								{
									global::AcpCommonLib.IAcpFeatureNode acpFeatureNode;
									task.AddTask(new global::AcpBusinessLayer.UndoRedo.ModifyDataTask<int>((acpFeatureNode[10090] as global::Motorola.MackinawCPS.CoreFeatures.Buttons.DataButtonInnerSection).BtnTrunkingButtonDatatButtonFeature_A22608, num3));
									num = (short)2061369350;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 3:
									goto IL_2028;
								case 4:
									num = (short)801374211;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 5:
								{
									global::AcpCommonLib.IAcpFeatureNode acpFeatureNode;
									if (num3 != (acpFeatureNode[10090] as global::Motorola.MackinawCPS.CoreFeatures.Buttons.DataButtonInnerSection).BtnTrunkingButtonDatatButtonFeature_A22608.Value)
									{
										num = (short)827588610;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									break;
								}
								case 6:
									goto IL_200B;
								}
								IL_1F41:
								num = (short)397541377;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								IL_1F3F:
								goto IL_1F41;
							}
							IL_200B:
							IL_2028:
							goto IL_2179;
						}
						finally
						{
							num = (short)740687872;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								switch (num2)
								{
								case 0:
									goto IL_2042;
								case 1:
								{
									num = (short)737833343;
									short num4 = num;
									num = (short)2033021311;
									switch ((num4 == num) ? 1 : 0)
									{
									case 0:
									case 2:
										goto IL_2042;
									default:
										num = (short)2089156608;
										if (num != 0)
										{
										}
										enumerator.Dispose();
										num = (short)1053229058;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									break;
								}
								case 2:
									goto IL_20E9;
								}
								goto IL_205F;
								IL_2042:
								switch (0)
								{
								case 0:
									IL_205F:
									if (enumerator == null)
									{
										goto IL_20EB;
									}
									num = (short)115015681;
									num2 = (int)((global::System.IntPtr)num);
									break;
								}
							}
							IL_20E9:
							IL_20EB:;
						}
						goto IL_20EC;
					case 1:
						if (dataButtonInnerRecset != null)
						{
							num = (short)2055929914;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_15CA;
					case 2:
						try
						{
							num = (short)523829248;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								switch (num2)
								{
								case 0:
									switch (0)
									{
									case 0:
										goto IL_E6D;
									}
									continue;
								case 1:
								{
									global::AcpCommonLib.IAcpFeatureNode acpFeatureNode2;
									if (num3 != (acpFeatureNode2[10212] as global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO3.DataButtonInnerSection).CntrlHeadO3ConventionalO3DatatButtonFeature_A22595.Value)
									{
										num = (short)916652034;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									break;
								}
								case 2:
								{
									global::AcpCommonLib.IAcpFeatureNode acpFeatureNode2;
									task.AddTask(new global::AcpBusinessLayer.UndoRedo.ModifyDataTask<int>((acpFeatureNode2[10212] as global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO3.DataButtonInnerSection).CntrlHeadO3ConventionalO3DatatButtonFeature_A22595, num3));
									num = (short)875626499;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 3:
									goto IL_EA7;
								case 4:
									goto IL_F59;
								case 5:
								{
									if (!enumerator.MoveNext())
									{
										num = (short)1472724998;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									global::AcpCommonLib.IAcpFeatureNode acpFeatureNode2 = enumerator.Current;
									num = (short)1856700417;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 6:
									num = (short)1190002692;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								IL_EAC:
								num = (short)1491533829;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								IL_E6D:
								goto IL_EAC;
							}
							IL_EA7:
							IL_F59:
							goto IL_1605;
						}
						finally
						{
							num = (short)950337537;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								switch (num2)
								{
								case 0:
									goto IL_FC8;
								case 1:
									switch (0)
									{
									case 0:
										goto IL_F90;
									}
									continue;
								case 2:
									enumerator.Dispose();
									num = (short)1840316416;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								IL_F90:
								if (enumerator == null)
								{
									break;
								}
								num = (short)1545797634;
								num2 = (int)((global::System.IntPtr)num);
							}
							IL_FC8:;
						}
						goto IL_FCB;
					case 3:
						try
						{
							num = (short)786497536;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								switch (num2)
								{
								case 0:
									switch (0)
									{
									case 0:
										goto IL_1CC5;
									}
									continue;
								case 1:
								{
									global::AcpCommonLib.IAcpFeatureNode acpFeatureNode3;
									if (num3 != (acpFeatureNode3[10608] as global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO9.O9DataButtonInnerSection).RadErgCtrlHeadO9DataButtonTrkFeature_A36526.Value)
									{
										num = (short)2136735749;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									break;
								}
								case 2:
									goto IL_1D91;
								case 3:
									goto IL_1DAF;
								case 4:
								{
									if (!enumerator.MoveNext())
									{
										num = (short)458817542;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									global::AcpCommonLib.IAcpFeatureNode acpFeatureNode3 = enumerator.Current;
									num = (short)402915329;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 5:
								{
									global::AcpCommonLib.IAcpFeatureNode acpFeatureNode3;
									task.AddTask(new global::AcpBusinessLayer.UndoRedo.ModifyDataTask<int>((acpFeatureNode3[10608] as global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO9.O9DataButtonInnerSection).RadErgCtrlHeadO9DataButtonTrkFeature_A36526, num3));
									num = (short)2082799618;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 6:
									num = (short)439943171;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								IL_1CC7:
								num = (short)1374617604;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								IL_1CC5:
								goto IL_1CC7;
							}
							IL_1D91:
							IL_1DAF:
							goto IL_1848;
						}
						finally
						{
							num = (short)515112960;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								switch (num2)
								{
								case 0:
									switch (0)
									{
									case 0:
										goto IL_1DE7;
									}
									continue;
								case 1:
									enumerator.Dispose();
									num = (short)1992425474;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 2:
									goto IL_1E1E;
								}
								IL_1DE7:
								if (enumerator == null)
								{
									break;
								}
								num = (short)1212350465;
								num2 = (int)((global::System.IntPtr)num);
							}
							IL_1E1E:;
						}
						goto IL_1E21;
					case 4:
						if (controlHeadO9Recset != null)
						{
							num = (short)78970892;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_21B6;
					case 5:
						num = (short)2043150367;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 6:
						if (dataButtonInnerRecset2 != null)
						{
							num = (short)1429602355;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_1965;
					case 7:
						num = (short)698482771;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 8:
					{
						if (!flag)
						{
							num = (short)890568734;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						global::Motorola.MackinawCPS.CoreFeatures.KeypadMicAndAccessories.KeypadMicAndAccessoriesRecset keypadMicAndAccessoriesRecset = null;
						dataButtonInnerRecset = null;
						keypadMicAndAccessoriesRecset = (global::AcpCommonLib.FeatureManager.GetFeature(2128) as global::Motorola.MackinawCPS.CoreFeatures.KeypadMicAndAccessories.KeypadMicAndAccessoriesRecset);
						num = (short)1906901053;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 9:
						if (buttonsRecset != null)
						{
							num = (short)215482408;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_3CB;
					case 10:
						if (dataButtonInnerRecset3 != null)
						{
							num = (short)1722548301;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_2179;
					case 11:
						if (num3 == 228)
						{
							num = (short)570753097;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return;
					case 12:
						num = (short)1366949966;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 13:
						dataButtonInnerRecset2 = (controlHeadO3Recset[0][10234].EmbeddedRecset as global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO3.DataButtonInnerRecset);
						num = (short)472973398;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 14:
						if (featureSectionId != 10212)
						{
							num = (short)2024079399;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_1E21;
					case 15:
						goto IL_65C;
					case 16:
						goto IL_3CB;
					case 17:
						goto IL_1642;
					case 18:
						goto IL_1905;
					case 19:
						enumerator = dataButtonInnerRecset2.GetEnumerator();
						num = (short)788922370;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 20:
						o9DataButtonInnerRecset = (controlHeadO9Recset[0][10611].EmbeddedRecset as global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO9.O9DataButtonInnerRecset);
						num = (short)813563966;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 21:
						if (consolidatedActionBCOListInnerRecset != null)
						{
							num = (short)1901199436;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_21B6;
					case 22:
						try
						{
							num = (short)605093888;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								switch (num2)
								{
								case 0:
									switch (0)
									{
									case 0:
										goto IL_489;
									}
									continue;
								case 1:
									num = (short)195952642;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 2:
									goto IL_57F;
								case 3:
								{
									global::AcpCommonLib.IAcpFeatureNode acpFeatureNode4;
									task.AddTask(new global::AcpBusinessLayer.UndoRedo.ModifyDataTask<int>((acpFeatureNode4[10608] as global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO9.O9DataButtonInnerSection).RadErgCtrlHeadO9DataButtonCnvFeature_A36528, num3));
									num = (short)1958543366;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 4:
								{
									global::AcpCommonLib.IAcpFeatureNode acpFeatureNode4;
									if (num3 != (acpFeatureNode4[10608] as global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO9.O9DataButtonInnerSection).RadErgCtrlHeadO9DataButtonCnvFeature_A36528.Value)
									{
										num = (short)135069699;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									break;
								}
								case 5:
								{
									if (!enumerator.MoveNext())
									{
										num = (short)1098317825;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									global::AcpCommonLib.IAcpFeatureNode acpFeatureNode4 = enumerator.Current;
									num = (short)1545732100;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 6:
									goto IL_4C5;
								}
								IL_528:
								num = (short)1916731397;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								IL_489:
								goto IL_528;
							}
							IL_4C5:
							IL_57F:
							return;
						}
						finally
						{
							num = (short)1967849473;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								switch (num2)
								{
								case 0:
									goto IL_5F0;
								case 1:
									switch (0)
									{
									case 0:
										goto IL_5B7;
									}
									continue;
								case 2:
									enumerator.Dispose();
									num = (short)963248128;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								IL_5B7:
								if (enumerator == null)
								{
									break;
								}
								num = (short)2041774082;
								num2 = (int)((global::System.IntPtr)num);
							}
							IL_5F0:;
						}
						goto IL_5F3;
					case 23:
						if (featureSectionId <= 10209)
						{
							num = (short)1329987629;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)95879182;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 24:
						enumerator = dataButtonInnerRecset3.GetEnumerator();
						num = (short)1033896016;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 25:
					{
						if (featureSectionId != 10713)
						{
							num = (short)1165426695;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO7.O7DataButtonInnerSection o7DataButtonInnerSection = self as global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO7.O7DataButtonInnerSection;
						num3 = o7DataButtonInnerSection.RadErgCtrlHeadO7DataButtonTrkFeature_A41297.Value;
						acpRecRefField = o7DataButtonInnerSection.CHO7DataButtonTrkIndex_A41418;
						num = (short)335413300;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 26:
						if (controlHeadO3Recset != null)
						{
							num = (short)545783821;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_CE1;
					case 27:
					{
						global::Motorola.MackinawCPS.CoreFeatures.KeypadMicAndAccessories.KeypadMicAndAccessoriesRecset keypadMicAndAccessoriesRecset;
						dataButtonInnerRecset = (keypadMicAndAccessoriesRecset[0][10228].EmbeddedRecset as global::Motorola.MackinawCPS.CoreFeatures.KeypadMicAndAccessories.DataButtonInnerRecset);
						num = (short)305528891;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 28:
						enumerator = o9DataButtonInnerRecset.GetEnumerator();
						num = (short)1919090710;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 29:
						num = (short)538050601;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 30:
						return;
					case 31:
					{
						if (featureSectionId != 10209)
						{
							num = (short)584974380;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						global::Motorola.MackinawCPS.CoreFeatures.KeypadMicAndAccessories.DataButtonInnerSection dataButtonInnerSection = self as global::Motorola.MackinawCPS.CoreFeatures.KeypadMicAndAccessories.DataButtonInnerSection;
						num3 = dataButtonInnerSection.RadErgoCfgKMTrunkingKMDatatButtonFeature_A22605.Value;
						acpRecRefField = dataButtonInnerSection.RadErgoCfgKMTrunkingKMDatatButtonIndex_A41424;
						num = (short)456982585;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 32:
						goto IL_85D;
					case 33:
						if (o7DataButtonInnerRecset != null)
						{
							num = (short)550633546;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_D6D;
					case 34:
						if (featureSectionId != 10608)
						{
							num = (short)506462244;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_FCB;
					case 35:
						try
						{
							num = (short)1901658112;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								switch (num2)
								{
								case 0:
									switch (0)
									{
									case 0:
										goto IL_19E6;
									}
									continue;
								case 1:
								{
									global::AcpCommonLib.IAcpFeatureNode acpFeatureNode5;
									task.AddTask(new global::AcpBusinessLayer.UndoRedo.ModifyDataTask<int>((acpFeatureNode5[10713] as global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO7.O7DataButtonInnerSection).RadErgCtrlHeadO7DataButtonTrkFeature_A41297, num3));
									num = (short)2113667076;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 2:
									num = (short)1613299715;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 3:
									goto IL_1ADB;
								case 4:
									goto IL_1A22;
								case 5:
								{
									if (!enumerator.MoveNext())
									{
										num = (short)1487339522;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									global::AcpCommonLib.IAcpFeatureNode acpFeatureNode5 = enumerator.Current;
									num = (short)995360774;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 6:
								{
									global::AcpCommonLib.IAcpFeatureNode acpFeatureNode5;
									if (num3 != (acpFeatureNode5[10713] as global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO7.O7DataButtonInnerSection).RadErgCtrlHeadO7DataButtonTrkFeature_A41297.Value)
									{
										num = (short)797638657;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									break;
								}
								}
								IL_1A85:
								num = (short)419430405;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								IL_19E6:
								goto IL_1A85;
							}
							IL_1A22:
							IL_1ADB:
							goto IL_D6D;
						}
						finally
						{
							num = (short)1641676800;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								switch (num2)
								{
								case 0:
									switch (0)
									{
									case 0:
										goto IL_1B12;
									}
									continue;
								case 1:
									goto IL_1B4C;
								case 2:
									enumerator.Dispose();
									num = (short)213385217;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								IL_1B12:
								if (enumerator == null)
								{
									break;
								}
								num = (short)1558904834;
								num2 = (int)((global::System.IntPtr)num);
							}
							IL_1B4C:;
						}
						goto IL_1B4F;
					case 36:
						num = (short)1422196761;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 37:
						try
						{
							num = (short)1338703872;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								switch (num2)
								{
								case 0:
									switch (0)
									{
									case 0:
										goto IL_B2E;
									}
									continue;
								case 1:
									num = (short)598999044;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 2:
									goto IL_BFC;
								case 3:
								{
									global::AcpCommonLib.IAcpFeatureNode acpFeatureNode6;
									if (num3 != (acpFeatureNode6[10209] as global::Motorola.MackinawCPS.CoreFeatures.KeypadMicAndAccessories.DataButtonInnerSection).RadErgoCfgKMConventionalKMDatatButtonFeature_A22603.Value)
									{
										num = (short)1781923845;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									break;
								}
								case 4:
									goto IL_C19;
								case 5:
								{
									global::AcpCommonLib.IAcpFeatureNode acpFeatureNode6;
									task.AddTask(new global::AcpBusinessLayer.UndoRedo.ModifyDataTask<int>((acpFeatureNode6[10209] as global::Motorola.MackinawCPS.CoreFeatures.KeypadMicAndAccessories.DataButtonInnerSection).RadErgoCfgKMConventionalKMDatatButtonFeature_A22603, num3));
									num = (short)1366949890;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 6:
								{
									if (!enumerator.MoveNext())
									{
										num = (short)8126465;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									global::AcpCommonLib.IAcpFeatureNode acpFeatureNode6 = enumerator.Current;
									num = (short)2138701827;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								}
								IL_B85:
								num = (short)2059272198;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								IL_B2E:
								goto IL_B85;
							}
							IL_BFC:
							IL_C19:
							goto IL_15CA;
						}
						finally
						{
							num = (short)1294073857;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								switch (num2)
								{
								case 0:
									goto IL_C8A;
								case 1:
									switch (0)
									{
									case 0:
										goto IL_C51;
									}
									continue;
								case 2:
									enumerator.Dispose();
									num = (short)550633472;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								IL_C51:
								if (enumerator == null)
								{
									break;
								}
								num = (short)806682626;
								num2 = (int)((global::System.IntPtr)num);
							}
							IL_C8A:;
						}
						goto IL_C8D;
					case 38:
						try
						{
							num = (short)910557184;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								switch (num2)
								{
								case 0:
									switch (0)
									{
									case 0:
										goto IL_16E8;
									}
									continue;
								case 1:
								{
									if (!enumerator.MoveNext())
									{
										num = (short)1496514565;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									global::AcpCommonLib.IAcpFeatureNode acpFeatureNode7 = enumerator.Current;
									num = (short)1025245188;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 2:
									goto IL_17B7;
								case 3:
									goto IL_17D4;
								case 4:
								{
									global::AcpCommonLib.IAcpFeatureNode acpFeatureNode7;
									if (num3 != (acpFeatureNode7[10212] as global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO3.DataButtonInnerSection).CntrlHeadO3TrunkingO3DatatButtonFeature_A22597.Value)
									{
										num = (short)2108555270;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									break;
								}
								case 5:
									num = (short)600178691;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 6:
								{
									global::AcpCommonLib.IAcpFeatureNode acpFeatureNode7;
									task.AddTask(new global::AcpBusinessLayer.UndoRedo.ModifyDataTask<int>((acpFeatureNode7[10212] as global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO3.DataButtonInnerSection).CntrlHeadO3TrunkingO3DatatButtonFeature_A22597, num3));
									num = (short)1741225986;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								}
								IL_1740:
								num = (short)185729025;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								IL_16E8:
								goto IL_1740;
							}
							IL_17B7:
							IL_17D4:
							goto IL_1965;
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
										goto IL_180B;
									}
									continue;
								case 1:
									goto IL_1845;
								case 2:
									enumerator.Dispose();
									num = (short)1364328449;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								IL_180B:
								if (enumerator == null)
								{
									break;
								}
								num = (short)1241645058;
								num2 = (int)((global::System.IntPtr)num);
							}
							IL_1845:;
						}
						goto IL_1848;
					case 39:
						num = (short)983564322;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 40:
						goto IL_11E4;
					case 41:
						if (!flag2)
						{
							num = (short)327286847;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_21B6;
					case 42:
						if (dataButtonInnerRecset2 != null)
						{
							num = (short)1010434067;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_1605;
					case 43:
						if (controlHeadO9Recset != null)
						{
							num = (short)241041428;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_A33;
					case 44:
						num = (short)1146486799;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 45:
						num = (short)850198574;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 46:
						if (featureSectionId != 10090)
						{
							num = (short)693567493;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num3 = (self as global::Motorola.MackinawCPS.CoreFeatures.Buttons.DataButtonInnerSection).BtnTrunkingButtonDatatButtonFeature_A22608.Value;
						num = (short)1012531217;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 47:
						if (o9DataButtonInnerRecset != null)
						{
							num = (short)973799474;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_1848;
					case 48:
						if (radioWide.DualRadio.RadWideDualRadioSelection_A42236 == 0)
						{
							num = (short)1926168594;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_DEE;
					case 49:
						try
						{
							num = (short)351731714;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								switch (num2)
								{
								case 0:
									goto IL_137A;
								case 1:
									goto IL_13E1;
								case 2:
									switch (0)
									{
									case 0:
										goto IL_1343;
									}
									continue;
								case 3:
								{
									global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO9.ConsolidatedActionBCOListInner consolidatedActionBCOListInner;
									if (consolidatedActionBCOListInner.ConsolidatedActionBCOListInnerSection.RadErgoControlO9ACBCOListBco_A36666.Value == 134)
									{
										num = (short)722468873;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									break;
								}
								case 4:
									num = (short)1331036173;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 5:
									if (num3 != 227)
									{
										num = (short)2089418764;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									flag2 = true;
									num = (short)1443430411;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 6:
								{
									if (!enumerator.MoveNext())
									{
										num = (short)563085319;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO9.ConsolidatedActionBCOListInner consolidatedActionBCOListInner = (global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO9.ConsolidatedActionBCOListInner)enumerator.Current;
									num = (short)337641475;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 7:
									goto IL_1518;
								case 8:
								{
									global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO9.ConsolidatedActionBCOListInner consolidatedActionBCOListInner;
									task.AddTask(new global::AcpBusinessLayer.UndoRedo.ModifyRecRefDataTask(consolidatedActionBCOListInner.ConsolidatedActionBCOListInnerSection.RadErgoControlO9ACBCOListIndex_A36668, acpRecRefField.UIValue));
									num = (short)857079808;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 9:
									num = (short)749469701;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 10:
									goto IL_1531;
								case 11:
									if (acpRecRefField != null)
									{
										num = (short)1116012548;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									goto IL_1518;
								case 12:
								{
									global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO9.ConsolidatedActionBCOListInner consolidatedActionBCOListInner;
									task.AddTask(new global::AcpBusinessLayer.UndoRedo.DeleteRecordTask(consolidatedActionBCOListInner));
									num = (short)785055745;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 13:
								{
									global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO9.ConsolidatedActionBCOListInner consolidatedActionBCOListInner;
									if (acpRecRefField.Value != consolidatedActionBCOListInner.ConsolidatedActionBCOListInnerSection.RadErgoControlO9ACBCOListIndex_A36668.Value)
									{
										num = (short)1361379336;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									goto IL_1518;
								}
								}
								IL_1438:
								num = (short)804585478;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								IL_1343:
								goto IL_1438;
								IL_1518:
								num = (short)1535901706;
								num2 = (int)((global::System.IntPtr)num);
							}
							IL_137A:
							IL_13E1:
							IL_1531:
							goto IL_1B4F;
						}
						finally
						{
							num = (short)1217069056;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								switch (num2)
								{
								case 0:
									switch (0)
									{
									case 0:
										goto IL_1568;
									}
									continue;
								case 1:
									goto IL_15A0;
								case 2:
									enumerator.Dispose();
									num = (short)1150091265;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								IL_1568:
								if (enumerator == null)
								{
									break;
								}
								num = (short)252968962;
								num2 = (int)((global::System.IntPtr)num);
							}
							IL_15A0:;
						}
						goto IL_15A3;
					case 50:
						goto IL_20EC;
					case 51:
						goto IL_5F3;
					case 52:
						goto IL_1642;
					case 53:
						if (num3 != 140)
						{
							num = (short)1666711606;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_DEE;
					case 54:
						num = (short)1342963723;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 55:
						if (controlHeadO7Recset != null)
						{
							num = (short)1585643576;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_C8D;
					case 56:
						o7DataButtonInnerRecset = (controlHeadO7Recset[0][10717].EmbeddedRecset as global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO7.O7DataButtonInnerRecset);
						num = (short)1239023695;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 57:
						goto IL_1642;
					case 58:
						enumerator = dataButtonInnerRecset.GetEnumerator();
						num = (short)1699348517;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 59:
						goto IL_A98;
					case 60:
						consolidatedActionBCOListInnerRecset = (controlHeadO9Recset[0][10622].EmbeddedRecset as global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO9.ConsolidatedActionBCOListInnerRecset);
						num = (short)1672609813;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 61:
					{
						global::Motorola.MackinawCPS.CoreFeatures.KeypadMicAndAccessories.KeypadMicAndAccessoriesRecset keypadMicAndAccessoriesRecset;
						if (keypadMicAndAccessoriesRecset != null)
						{
							num = (short)1647116315;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_A98;
					}
					case 62:
						goto IL_A33;
					case 63:
					{
						task.AddTask(new global::AcpBusinessLayer.UndoRedo.AddRecordTask(consolidatedActionBCOListInnerRecset.CreateDefaultRecord()));
						int index = consolidatedActionBCOListInnerRecset.Count - 1;
						global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO9.ConsolidatedActionBCOListInner consolidatedActionBCOListInner2 = consolidatedActionBCOListInnerRecset[index] as global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO9.ConsolidatedActionBCOListInner;
						task.AddTask(new global::AcpBusinessLayer.UndoRedo.ModifyDataTask<int>(consolidatedActionBCOListInner2.ConsolidatedActionBCOListInnerSection.RadErgoControlO9ACBCOListBco_A36666, 134));
						task.AddTask(new global::AcpBusinessLayer.UndoRedo.ModifyRecRefDataTask(consolidatedActionBCOListInner2.ConsolidatedActionBCOListInnerSection.RadErgoControlO9ACBCOListIndex_A36668, acpRecRefField.UIValue));
						num = (short)1330249797;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 64:
						if (dataButtonInnerRecset != null)
						{
							num = (short)1720582216;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_1BCB;
					case 65:
						if (num3 != 227)
						{
							num = (short)1525940305;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_DEE;
					case 66:
						if (o9DataButtonInnerRecset != null)
						{
							num = (short)639959068;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return;
					case 67:
						goto IL_1642;
					case 68:
						goto IL_1642;
					case 69:
						goto IL_21B6;
					case 70:
						goto IL_1642;
					case 71:
						if (dataButtonInnerRecset3 != null)
						{
							num = (short)2030043160;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_1C44;
					case 72:
						goto IL_A0C;
					case 73:
						num = (short)1279131696;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 74:
						enumerator = o7DataButtonInnerRecset.GetEnumerator();
						num = (short)803930147;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 75:
						try
						{
							num = (short)1803091968;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								switch (num2)
								{
								case 0:
									switch (0)
									{
									case 0:
										goto IL_1083;
									}
									continue;
								case 1:
								{
									global::AcpCommonLib.IAcpFeatureNode acpFeatureNode8;
									if (num3 != (acpFeatureNode8[10713] as global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO7.O7DataButtonInnerSection).RadErgCtrlHeadO7DataButtonCnvFeature_A41299.Value)
									{
										num = (short)1588592642;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									break;
								}
								case 2:
								{
									global::AcpCommonLib.IAcpFeatureNode acpFeatureNode8;
									task.AddTask(new global::AcpBusinessLayer.UndoRedo.ModifyDataTask<int>((acpFeatureNode8[10713] as global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO7.O7DataButtonInnerSection).RadErgCtrlHeadO7DataButtonCnvFeature_A41299, num3));
									num = (short)1450180611;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 3:
									goto IL_10BD;
								case 4:
									goto IL_1173;
								case 5:
								{
									if (!enumerator.MoveNext())
									{
										num = (short)599719942;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									global::AcpCommonLib.IAcpFeatureNode acpFeatureNode8 = enumerator.Current;
									num = (short)808583169;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 6:
									num = (short)20905988;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								IL_10C2:
								num = (short)1784479749;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								IL_1083:
								goto IL_10C2;
							}
							IL_10BD:
							IL_1173:
							goto IL_1B8C;
						}
						finally
						{
							num = (short)32243713;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								switch (num2)
								{
								case 0:
									goto IL_11E1;
								case 1:
									switch (0)
									{
									case 0:
										goto IL_11AA;
									}
									continue;
								case 2:
									enumerator.Dispose();
									num = (short)1683947520;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								IL_11AA:
								if (enumerator == null)
								{
									break;
								}
								num = (short)511049730;
								num2 = (int)((global::System.IntPtr)num);
							}
							IL_11E1:;
						}
						goto IL_11E4;
					case 76:
						enumerator = consolidatedActionBCOListInnerRecset.GetEnumerator();
						num = (short)582025265;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 77:
					{
						num = (short)2076246016;
						short num5 = num;
						goto IL_15A3;
					}
					case 78:
						if (controlHeadO9Recset.Count > 0)
						{
							num = (short)577044540;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_21B6;
					case 79:
						goto IL_C8D;
					case 80:
						try
						{
							num = (short)75366400;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								switch (num2)
								{
								case 0:
									switch (0)
									{
									case 0:
										goto IL_6F8;
									}
									continue;
								case 1:
								{
									if (!enumerator.MoveNext())
									{
										num = (short)1275527170;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									global::AcpCommonLib.IAcpFeatureNode acpFeatureNode9 = enumerator.Current;
									num = (short)1516371971;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 2:
									num = (short)1439825924;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 3:
								{
									global::AcpCommonLib.IAcpFeatureNode acpFeatureNode9;
									if (num3 != (acpFeatureNode9[10090] as global::Motorola.MackinawCPS.CoreFeatures.Buttons.DataButtonInnerSection).BtnConventionalButtonDatatButtonFeature_A22610.Value)
									{
										num = (short)943325189;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									break;
								}
								case 4:
									goto IL_7E9;
								case 5:
								{
									global::AcpCommonLib.IAcpFeatureNode acpFeatureNode9;
									task.AddTask(new global::AcpBusinessLayer.UndoRedo.ModifyDataTask<int>((acpFeatureNode9[10090] as global::Motorola.MackinawCPS.CoreFeatures.Buttons.DataButtonInnerSection).BtnConventionalButtonDatatButtonFeature_A22610, num3));
									num = (short)490536966;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 6:
									goto IL_78A;
								}
								IL_78F:
								num = (short)139919361;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								IL_6F8:
								goto IL_78F;
							}
							IL_78A:
							IL_7E9:
							goto IL_1C44;
						}
						finally
						{
							num = (short)993394689;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								switch (num2)
								{
								case 0:
									goto IL_85A;
								case 1:
									switch (0)
									{
									case 0:
										goto IL_821;
									}
									continue;
								case 2:
									enumerator.Dispose();
									num = (short)1609367552;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								IL_821:
								if (enumerator == null)
								{
									break;
								}
								num = (short)1402011650;
								num2 = (int)((global::System.IntPtr)num);
							}
							IL_85A:;
						}
						goto Block_8;
					case 81:
						num = (short)142344245;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 82:
						if (o7DataButtonInnerRecset != null)
						{
							num = (short)980287572;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_1B8C;
					case 83:
						goto IL_65C;
					case 84:
						enumerator = o7DataButtonInnerRecset.GetEnumerator();
						num = (short)13107275;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 85:
						if (num3 == 227)
						{
							num = (short)1499987997;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_21B6;
					case 86:
						goto IL_CE1;
					}
					goto IL_18A;
					IL_3CB:
					controlHeadO3Recset = null;
					dataButtonInnerRecset2 = null;
					controlHeadO3Recset = (global::AcpCommonLib.FeatureManager.GetFeature(2127) as global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO3.ControlHeadO3Recset);
					num = (short)1129840666;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_5F3:
					enumerator = dataButtonInnerRecset2.GetEnumerator();
					num = (short)289538086;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_65C:
					flag = false;
					num = (short)1285292102;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_A0C:
					enumerator = dataButtonInnerRecset.GetEnumerator();
					num = (short)1747910688;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					Block_8:
					try
					{
						IL_85D:
						num = (short)1874395136;
						num2 = (int)((global::System.IntPtr)num);
						for (;;)
						{
							switch (num2)
							{
							case 0:
								switch (0)
								{
								case 0:
									goto IL_8A0;
								}
								continue;
							case 1:
							{
								global::AcpCommonLib.IAcpFeatureNode acpFeatureNode10;
								if (num3 != (acpFeatureNode10[10209] as global::Motorola.MackinawCPS.CoreFeatures.KeypadMicAndAccessories.DataButtonInnerSection).RadErgoCfgKMTrunkingKMDatatButtonFeature_A22605.Value)
								{
									num = (short)1056636930;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								break;
							}
							case 2:
							{
								global::AcpCommonLib.IAcpFeatureNode acpFeatureNode10;
								task.AddTask(new global::AcpBusinessLayer.UndoRedo.ModifyDataTask<int>((acpFeatureNode10[10209] as global::Motorola.MackinawCPS.CoreFeatures.KeypadMicAndAccessories.DataButtonInnerSection).RadErgoCfgKMTrunkingKMDatatButtonFeature_A22605, num3));
								num = (short)157548550;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							case 3:
							{
								if (!enumerator.MoveNext())
								{
									num = (short)1862926341;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								global::AcpCommonLib.IAcpFeatureNode acpFeatureNode10 = enumerator.Current;
								num = (short)95485953;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							case 4:
								goto IL_998;
							case 5:
								num = (short)1737031684;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							case 6:
								goto IL_917;
							}
							IL_8A2:
							num = (short)1324941315;
							num2 = (int)((global::System.IntPtr)num);
							continue;
							IL_8A0:
							goto IL_8A2;
						}
						IL_917:
						IL_998:
						goto IL_1BCB;
					}
					finally
					{
						num = (short)816906241;
						num2 = (int)((global::System.IntPtr)num);
						for (;;)
						{
							switch (num2)
							{
							case 0:
								goto IL_A09;
							case 1:
								switch (0)
								{
								case 0:
									goto IL_9D0;
								}
								continue;
							case 2:
								enumerator.Dispose();
								num = (short)396689408;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							IL_9D0:
							if (enumerator == null)
							{
								break;
							}
							num = (short)841482242;
							num2 = (int)((global::System.IntPtr)num);
						}
						IL_A09:;
					}
					goto IL_A0C;
					IL_A33:
					num = (short)299696138;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_A98:
					buttonsRecset = null;
					dataButtonInnerRecset3 = null;
					buttonsRecset = (global::AcpCommonLib.FeatureManager.GetFeature(2042) as global::Motorola.MackinawCPS.CoreFeatures.Buttons.ButtonsRecset);
					num = (short)1135542281;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_C8D:
					controlHeadO9Recset = null;
					o9DataButtonInnerRecset = null;
					controlHeadO9Recset = (global::AcpCommonLib.FeatureManager.GetFeature(4003) as global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO9.ControlHeadO9Recset);
					num = (short)1345716267;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_CE1:
					controlHeadO7Recset = null;
					o7DataButtonInnerRecset = null;
					controlHeadO7Recset = (global::AcpCommonLib.FeatureManager.GetFeature(4114) as global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO7.ControlHeadO7Recset);
					num = (short)1511850039;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_D6D:
					num = (short)585498671;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_DEE:
					num = (short)1150681159;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_FCB:
					global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO9.O9DataButtonInnerSection o9DataButtonInnerSection = self as global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO9.O9DataButtonInnerSection;
					num3 = o9DataButtonInnerSection.RadErgCtrlHeadO9DataButtonTrkFeature_A36526.Value;
					acpRecRefField = o9DataButtonInnerSection.CHO9DataButtonTrkIndex_A41416;
					num = (short)637861955;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_11E4:
					dataButtonInnerRecset3 = (buttonsRecset[0][10089].EmbeddedRecset as global::Motorola.MackinawCPS.CoreFeatures.Buttons.DataButtonInnerRecset);
					num = (short)584974352;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_15A3:
					enumerator = dataButtonInnerRecset3.GetEnumerator();
					num = (short)204865536;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_15CA:
					num = (short)1667825706;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_1605:
					num = (short)1628307538;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_1642:
					num = (short)273088520;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_1848:
					consolidatedActionBCOListInnerRecset = null;
					flag2 = false;
					num = (short)450756612;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_1965:
					num = (short)1805516833;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_1B4F:
					num = (short)876478549;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_1B8C:
					num = (short)1491402818;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_1BCB:
					num = (short)1630535686;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_1C44:
					num = (short)420872193;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_1E21:
					global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO3.DataButtonInnerSection dataButtonInnerSection2 = self as global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO3.DataButtonInnerSection;
					num3 = dataButtonInnerSection2.CntrlHeadO3TrunkingO3DatatButtonFeature_A22597.Value;
					acpRecRefField = dataButtonInnerSection2.CHO3DataButtonTrkIndex_A41420;
					num = (short)1871773764;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_20EC:
					enumerator = o9DataButtonInnerRecset.GetEnumerator();
					num = (short)2096562179;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_2179:
					num = (short)1003487296;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_21B6:
					radioWide = ((global::AcpCommonLib.FeatureManager.GetFeature(2045) as global::Motorola.MackinawCPS.CoreFeatures.RadioWide.RadioWideRecset)[0] as global::Motorola.MackinawCPS.CoreFeatures.RadioWide.RadioWide);
					num = (short)1256915009;
					num2 = (int)((global::System.IntPtr)num);
				}
				return;
				IL_1905:
				return;
				IL_18A:
				num3 = 0;
				flag = true;
				acpRecRefField = null;
				featureSectionId = self.FeatureSectionId;
				num = (short)917766145;
				if (num != 0)
				{
				}
				num = (short)514654231;
				num2 = (int)((global::System.IntPtr)num);
				goto IL_27;
			}
			}
		}

		// Token: 0x06008DDB RID: 36315 RVA: 0x0085D420 File Offset: 0x0085B620
		internal static bool conDataBtnTrkFeatureValid(global::AcpCommonLib.IAcpFeatureSection self, int index)
		{
			switch (0)
			{
			case 0:
				goto IL_A0;
			}
			int num;
			short num2;
			int featureSectionId;
			global::AcpBusinessLayer.AcpListField acpListField;
			for (;;)
			{
				IL_0A:
				global::Motorola.MackinawCPS.CoreFeatures.RadioWide.RadioWide radioWide;
				switch (num)
				{
				case 0:
					num2 = (short)1171783712;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 1:
					if (featureSectionId != 10608)
					{
						num2 = (short)463929363;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					acpListField = (self as global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO9.O9DataButtonInnerSection).RadErgCtrlHeadO9DataButtonCnvFeature_A36528;
					num2 = (short)1510014977;
					if (num2 != 0)
					{
					}
					num2 = (short)1396965393;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 2:
					goto IL_E2;
				case 3:
					goto IL_46A;
				case 4:
					if (index != 227)
					{
						num2 = (short)1311047702;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					return false;
				case 5:
					if (acpListField != null)
					{
						num2 = (short)94109702;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					return true;
				case 6:
					num2 = (short)1611333656;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 7:
					if (index != 228)
					{
						num2 = (short)2049900571;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					return false;
				case 8:
					if (acpListField.Value == 228)
					{
						num2 = (short)1085341719;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					num2 = (short)772079645;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 9:
					if (index != 227)
					{
						num2 = (short)1989738531;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					return false;
				case 10:
					goto IL_46A;
				case 11:
					goto IL_63E;
				case 12:
					if (featureSectionId != 10209)
					{
						num2 = (short)1324351501;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					acpListField = (self as global::Motorola.MackinawCPS.CoreFeatures.KeypadMicAndAccessories.DataButtonInnerSection).RadErgoCfgKMConventionalKMDatatButtonFeature_A22603;
					num2 = (short)959709194;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 13:
					num2 = (short)179437588;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 14:
					if (radioWide.DualRadio.RadWideDualRadioSelection_A42236.Value != 0)
					{
						num2 = (short)575602714;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					num2 = (short)552992783;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 15:
					if (index != 227)
					{
						num2 = (short)1194590219;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					return false;
				case 16:
					goto IL_46A;
				case 17:
					goto IL_46A;
				case 18:
					num2 = (short)687013904;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 19:
					num2 = (short)1382154271;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 20:
					if (featureSectionId != 10212)
					{
						num2 = (short)1580531730;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					acpListField = (self as global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO3.DataButtonInnerSection).CntrlHeadO3ConventionalO3DatatButtonFeature_A22595;
					num2 = (short)1198129155;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 21:
					if (featureSectionId <= 10212)
					{
						num2 = (short)684195842;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					num2 = (short)520749057;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 22:
					goto IL_1E0;
				case 23:
					num2 = (short)646447118;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 24:
					if (acpListField.Value == 227)
					{
						num2 = (short)1344012316;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					num2 = (short)125960225;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 25:
					goto IL_46A;
				case 26:
					goto IL_12D;
				case 27:
					num2 = (short)470614025;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 28:
				{
					num2 = (short)1542647740;
					short num3 = num2;
					num2 = (short)1230172092;
					switch ((num3 == num2) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_E2;
					default:
						goto IL_2C8;
					}
					break;
				}
				case 29:
					if (radioWide.DualRadio.RadWideDualRadioSelection_A42236.Value != 0)
					{
						num2 = (short)481165342;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					num2 = (short)995557380;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 30:
					num2 = (short)944046087;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 31:
					if (featureSectionId != 10713)
					{
						num2 = (short)710213632;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					acpListField = (self as global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO7.O7DataButtonInnerSection).RadErgCtrlHeadO7DataButtonCnvFeature_A41299;
					num2 = (short)1061158937;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 32:
					goto IL_46A;
				case 33:
					if (acpListField.Value == 140)
					{
						num2 = (short)410714146;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					num2 = (short)1358233608;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 34:
					goto IL_5AD;
				case 35:
					goto IL_414;
				}
				goto IL_A0;
				IL_E2:
				num2 = (short)1300627456;
				short num4 = num2;
				num2 = (short)1864892428;
				num = (int)((global::System.IntPtr)num2);
				continue;
				IL_46A:
				radioWide = (global::AcpCommonLib.FeatureManager.GetFeature(2045)[0] as global::Motorola.MackinawCPS.CoreFeatures.RadioWide.RadioWide);
				num2 = (short)1441988613;
				num = (int)((global::System.IntPtr)num2);
			}
			return false;
			IL_12D:
			return index == 228;
			IL_1E0:
			return index != 140;
			IL_2C8:
			num2 = (short)932249600;
			if (num2 != 0)
			{
			}
			return index == 227;
			IL_414:
			return index != 140;
			IL_5AD:
			return index == 140;
			IL_63E:
			return index != 140;
			IL_A0:
			acpListField = null;
			featureSectionId = self.FeatureSectionId;
			num2 = (short)2133524501;
			num = (int)((global::System.IntPtr)num2);
			goto IL_0A;
		}

		// Token: 0x06008DDC RID: 36316 RVA: 0x0085DA74 File Offset: 0x0085BC74
		public static bool ConSideArrowButtonPrimaryIsValid(global::AcpCommonLib.IAcpFeatureSection self, int index)
		{
			switch (0)
			{
			case 0:
				goto IL_30;
			}
			int num;
			global::Motorola.MackinawCPS.CoreFeatures.Buttons.PortableSideUpDownArrowButtonInnerSection portableSideUpDownArrowButtonInnerSection;
			short num2;
			global::Motorola.MackinawCPS.CoreFeatures.Buttons.PortableSideUpDownArrowButtonInnerRecset portableSideUpDownArrowButtonInnerRecset;
			bool result;
			for (;;)
			{
				IL_0A:
				switch (num)
				{
				case 0:
					if (index == portableSideUpDownArrowButtonInnerSection.BtnSideUpDownArrowButtonSecondaryFunction_A41592.Value)
					{
						num2 = (short)1873477634;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_1BB;
				case 1:
					num2 = (short)1113063424;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 2:
					num2 = (short)1188364291;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 3:
					if (portableSideUpDownArrowButtonInnerRecset[0] == self.Parent)
					{
						num2 = (short)673382406;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_1BB;
				case 4:
					return result;
				case 5:
					if (portableSideUpDownArrowButtonInnerRecset != null)
					{
						goto IL_65;
					}
					return result;
				case 6:
				{
					num2 = (short)1740701696;
					short num3 = num2;
					result = false;
					num2 = (short)277746345;
					short num4 = num2;
					num2 = (short)1168970409;
					switch ((num4 == num2) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_65;
					default:
						num2 = (short)182386689;
						if (num2 != 0)
						{
						}
						num2 = (short)1875116032;
						if (num2 != 0)
						{
						}
						num2 = (short)618725380;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					break;
				}
				case 7:
					return result;
				}
				goto IL_30;
				IL_65:
				num2 = (short)595263489;
				num = (int)((global::System.IntPtr)num2);
				continue;
				IL_1BB:
				result = true;
				num2 = (short)1215692807;
				num = (int)((global::System.IntPtr)num2);
			}
			return result;
			IL_30:
			portableSideUpDownArrowButtonInnerSection = (self as global::Motorola.MackinawCPS.CoreFeatures.Buttons.PortableSideUpDownArrowButtonInnerSection);
			portableSideUpDownArrowButtonInnerRecset = (self.Parent.Parent as global::Motorola.MackinawCPS.CoreFeatures.Buttons.PortableSideUpDownArrowButtonInnerRecset);
			result = false;
			num2 = (short)1838219269;
			num = (int)((global::System.IntPtr)num2);
			goto IL_0A;
		}

		// Token: 0x06008DDD RID: 36317 RVA: 0x0085DC58 File Offset: 0x0085BE58
		public static void conSetSideArrowButtonPrimaryFunctionDownButton(global::AcpCommonLib.IAcpFeatureSection self, global::AcpCommonLib.UndoRedo.ContainerTask task)
		{
			short num = (short)1830551552;
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
				global::Motorola.MackinawCPS.CoreFeatures.Buttons.PortableSideUpDownArrowButtonInner portableSideUpDownArrowButtonInner;
				global::Motorola.MackinawCPS.CoreFeatures.Buttons.PortableSideUpDownArrowButtonInnerSection portableSideUpDownArrowButtonInnerSection;
				for (;;)
				{
					IL_27:
					switch (num2)
					{
					case 0:
					{
						global::AcpCommonLib.IAcpFeatureNode parent;
						if ((parent.Parent as global::AcpBusinessLayer.Recordset).IndexOf(parent) == 0)
						{
							num = (short)1076690954;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return;
					}
					case 1:
						goto IL_EB;
					case 2:
					{
						global::AcpCommonLib.IAcpFeatureNode parent;
						portableSideUpDownArrowButtonInner = (parent.Parent[1] as global::Motorola.MackinawCPS.CoreFeatures.Buttons.PortableSideUpDownArrowButtonInner);
						int value = portableSideUpDownArrowButtonInnerSection.BtnSideUpDownArrowButtonPrimaryFunction_A41568.Value;
						int value2 = portableSideUpDownArrowButtonInnerSection.BtnSideUpDownArrowButtonSecondaryFunction_A41592.Value;
						num = (short)1432354819;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 3:
					{
						num = (short)1638028601;
						short num3 = num;
						num = (short)1076778297;
						switch ((num3 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_F0;
						default:
						{
							num = (short)299630592;
							if (num != 0)
							{
							}
							int value;
							if (value == 64)
							{
								num = (short)1320419344;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							num = (short)1044381700;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						}
						break;
					}
					case 4:
					{
						int value;
						if (value == 66)
						{
							num = (short)341508097;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)1592131592;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 5:
					{
						global::AcpCommonLib.IAcpFeatureNode parent;
						if (parent.Parent == null)
						{
							num = (short)145489926;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)1286995968;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 6:
						return;
					case 7:
					{
						if (portableSideUpDownArrowButtonInnerSection == null)
						{
							num = (short)54657038;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						global::AcpCommonLib.IAcpFeatureNode parent = portableSideUpDownArrowButtonInnerSection.Parent;
						num = (short)490602507;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 8:
					{
						int value;
						if (value == 87)
						{
							num = (short)452263949;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return;
					}
					case 9:
					{
						global::AcpCommonLib.IAcpFeatureNode parent;
						if (parent.Parent.Count > 1)
						{
							num = (short)941817858;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return;
					}
					case 10:
						goto IL_F0;
					case 11:
					{
						global::AcpCommonLib.IAcpFeatureNode parent;
						if (parent == null)
						{
							num = (short)321126415;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)84082688;
						short num4 = num;
						num = (short)1205403653;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 12:
						goto IL_225;
					case 13:
						task.AddTask(new global::AcpBusinessLayer.UndoRedo.ModifyDataTask<int>(portableSideUpDownArrowButtonInner.PortableSideUpDownArrowButtonInnerSection.BtnSideUpDownArrowButtonPrimaryFunction_A41568, 88));
						num = (short)1117585420;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 14:
						return;
					case 15:
						return;
					case 16:
						goto IL_3A7;
					}
					goto IL_72;
					IL_F0:
					num = (short)1669136385;
					if (num != 0)
					{
					}
					num = (short)788987913;
					num2 = (int)((global::System.IntPtr)num);
				}
				return;
				IL_EB:
				task.AddTask(new global::AcpBusinessLayer.UndoRedo.ModifyDataTask<int>(portableSideUpDownArrowButtonInner.PortableSideUpDownArrowButtonInnerSection.BtnSideUpDownArrowButtonPrimaryFunction_A41568, 67));
				return;
				IL_225:
				return;
				IL_3A7:
				task.AddTask(new global::AcpBusinessLayer.UndoRedo.ModifyDataTask<int>(portableSideUpDownArrowButtonInner.PortableSideUpDownArrowButtonInnerSection.BtnSideUpDownArrowButtonPrimaryFunction_A41568, 65));
				return;
				IL_72:
				portableSideUpDownArrowButtonInnerSection = (self as global::Motorola.MackinawCPS.CoreFeatures.Buttons.PortableSideUpDownArrowButtonInnerSection);
				num = (short)165609479;
				num2 = (int)((global::System.IntPtr)num);
				goto IL_27;
			}
			}
		}

		// Token: 0x06008DDE RID: 36318 RVA: 0x0085E014 File Offset: 0x0085C214
		public static bool ConSideArrowButtonSecondaryIsValid(global::AcpCommonLib.IAcpFeatureSection self, int index)
		{
			switch (0)
			{
			case 0:
				goto IL_57;
			}
			short num;
			int num2;
			global::Motorola.MackinawCPS.CoreFeatures.Buttons.PortableSideUpDownArrowButtonInnerSection portableSideUpDownArrowButtonInnerSection;
			global::Motorola.MackinawCPS.CoreFeatures.Buttons.PortableSideUpDownArrowButtonInnerRecset portableSideUpDownArrowButtonInnerRecset;
			bool result;
			for (;;)
			{
				IL_0A:
				num = (short)1868562433;
				if (num != 0)
				{
				}
				switch (num2)
				{
				case 0:
					if (index == portableSideUpDownArrowButtonInnerSection.BtnSideUpDownArrowButtonPrimaryFunction_A41568.Value)
					{
						num = (short)1810694146;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_1C0;
				case 1:
				{
					num = (short)612564992;
					short num3 = num;
					num = (short)1379860480;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				case 2:
					num = (short)626393091;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 3:
					if (portableSideUpDownArrowButtonInnerRecset[0] == self.Parent)
					{
						num = (short)876216326;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_1C0;
				case 4:
					return result;
				case 5:
					if (portableSideUpDownArrowButtonInnerRecset != null)
					{
						goto IL_8B;
					}
					return result;
				case 6:
				{
					result = false;
					num = (short)1658596407;
					short num4 = num;
					num = (short)1851075639;
					switch ((num4 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_8B;
					default:
						num = (short)1198850048;
						if (num != 0)
						{
						}
						num = (short)420806660;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					break;
				}
				case 7:
					return result;
				}
				goto IL_57;
				IL_8B:
				num = (short)223739905;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_1C0:
				result = true;
				num = (short)390332423;
				num2 = (int)((global::System.IntPtr)num);
			}
			return result;
			IL_57:
			portableSideUpDownArrowButtonInnerSection = (self as global::Motorola.MackinawCPS.CoreFeatures.Buttons.PortableSideUpDownArrowButtonInnerSection);
			portableSideUpDownArrowButtonInnerRecset = (self.Parent.Parent as global::Motorola.MackinawCPS.CoreFeatures.Buttons.PortableSideUpDownArrowButtonInnerRecset);
			result = false;
			num = (short)466944005;
			num2 = (int)((global::System.IntPtr)num);
			goto IL_0A;
		}

		// Token: 0x06008DDF RID: 36319 RVA: 0x0085E200 File Offset: 0x0085C400
		public static bool ConSideArrowDownButtonIsEdit(global::AcpCommonLib.IAcpFeatureSection self)
		{
			switch (0)
			{
			case 0:
				goto IL_30;
			}
			int num;
			short num2;
			global::Motorola.MackinawCPS.CoreFeatures.Buttons.PortableSideUpDownArrowButtonInnerSection portableSideUpDownArrowButtonInnerSection;
			for (;;)
			{
				IL_0A:
				switch (num)
				{
				case 0:
					num2 = (short)1089601540;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 1:
				{
					num2 = (short)1166344192;
					short num3 = num2;
					global::AcpCommonLib.IAcpFeatureNode parent = portableSideUpDownArrowButtonInnerSection.Parent;
					num2 = (short)311558146;
					num = (int)((global::System.IntPtr)num2);
					continue;
				}
				case 2:
				{
					global::AcpCommonLib.IAcpFeatureNode parent;
					if (parent != null)
					{
						num2 = (short)1882390535;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					return true;
				}
				case 3:
					return false;
				case 4:
				{
					num2 = (short)1799876619;
					short num4 = num2;
					num2 = (short)1966796811;
					switch ((num4 == num2) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_7B;
					default:
					{
						num2 = (short)1505755136;
						if (num2 != 0)
						{
						}
						global::AcpCommonLib.IAcpFeatureNode parent;
						if ((parent.Parent as global::AcpBusinessLayer.Recordset).IndexOf(parent) == 1)
						{
							num2 = (short)184418307;
							num = (int)((global::System.IntPtr)num2);
							continue;
						}
						return true;
					}
					}
					break;
				}
				case 5:
					if (portableSideUpDownArrowButtonInnerSection != null)
					{
						goto IL_7B;
					}
					return true;
				case 6:
				{
					global::AcpCommonLib.IAcpFeatureNode parent;
					if (parent.Parent != null)
					{
						num2 = (short)1624440832;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					return true;
				}
				case 7:
					num2 = (short)385286150;
					num = (int)((global::System.IntPtr)num2);
					continue;
				}
				goto IL_30;
				IL_7B:
				num2 = (short)70975489;
				num = (int)((global::System.IntPtr)num2);
			}
			return false;
			IL_30:
			num2 = (short)769327105;
			if (num2 != 0)
			{
			}
			portableSideUpDownArrowButtonInnerSection = (self as global::Motorola.MackinawCPS.CoreFeatures.Buttons.PortableSideUpDownArrowButtonInnerSection);
			num2 = (short)1591738373;
			num = (int)((global::System.IntPtr)num2);
			goto IL_0A;
		}

		// Token: 0x06008DE0 RID: 36320 RVA: 0x0085E3E0 File Offset: 0x0085C5E0
		public static void conSetSideArrowButtonSecondaryFunction(global::AcpCommonLib.IAcpFeatureSection self, global::AcpCommonLib.UndoRedo.ContainerTask task)
		{
			short num = (short)977207296;
			int num2 = (int)num;
			switch (num2)
			{
			default:
			{
				num = (short)1881473025;
				if (num != 0)
				{
				}
				switch (0)
				{
				case 0:
					goto IL_A2;
				}
				global::Motorola.MackinawCPS.CoreFeatures.Buttons.PortableSideUpDownArrowButtonInner portableSideUpDownArrowButtonInner;
				global::Motorola.MackinawCPS.CoreFeatures.Buttons.PortableSideUpDownArrowButtonInnerSection portableSideUpDownArrowButtonInnerSection;
				for (;;)
				{
					IL_4F:
					switch (num2)
					{
					case 0:
						task.AddTask(new global::AcpBusinessLayer.UndoRedo.ModifyDataTask<int>(portableSideUpDownArrowButtonInner.PortableSideUpDownArrowButtonInnerSection.BtnSideUpDownArrowButtonSecondaryFunction_A41592, 38));
						num = (short)465305602;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 1:
					{
						global::AcpCommonLib.IAcpFeatureNode parent;
						if (parent == null)
						{
							num = (short)1436876806;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)1827602439;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 2:
						goto IL_252;
					case 3:
					{
						global::AcpCommonLib.IAcpFeatureNode parent;
						if (parent.Parent.Count > 1)
						{
							num = (short)1927675919;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return;
					}
					case 4:
					{
						int value;
						if (value == 87)
						{
							num = (short)1112997900;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)1822228494;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 5:
					{
						int value;
						if (value == 66)
						{
							num = (short)18546699;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)1355612164;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 6:
						return;
					case 7:
					{
						global::AcpCommonLib.IAcpFeatureNode parent;
						if (parent.Parent == null)
						{
							num = (short)1711013905;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)2116878346;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 8:
						num = (short)1880752131;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 9:
					{
						if (portableSideUpDownArrowButtonInnerSection == null)
						{
							num = (short)13762576;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						global::AcpCommonLib.IAcpFeatureNode parent = portableSideUpDownArrowButtonInnerSection.Parent;
						num = (short)1578827776;
						short num3 = num;
						num = (short)1539892018;
						short num4 = num;
						num = (short)1865868082;
						switch ((num4 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_3C0;
						default:
							num = (short)1461780480;
							if (num != 0)
							{
							}
							num = (short)465567745;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						break;
					}
					case 10:
					{
						global::AcpCommonLib.IAcpFeatureNode parent;
						if ((parent.Parent as global::AcpBusinessLayer.Recordset).IndexOf(parent) == 0)
						{
							num = (short)1141374984;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return;
					}
					case 11:
						goto IL_21C;
					case 12:
						goto IL_350;
					case 13:
					{
						int value;
						if (value == 64)
						{
							num = (short)138412050;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)1013907461;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 14:
					{
						int value;
						if (value == 38)
						{
							num = (short)1455751168;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return;
					}
					case 15:
					{
						global::AcpCommonLib.IAcpFeatureNode parent;
						portableSideUpDownArrowButtonInner = (parent.Parent[1] as global::Motorola.MackinawCPS.CoreFeatures.Buttons.PortableSideUpDownArrowButtonInner);
						int value = portableSideUpDownArrowButtonInnerSection.BtnSideUpDownArrowButtonSecondaryFunction_A41592.Value;
						goto IL_3C0;
					}
					case 16:
						return;
					case 17:
						return;
					case 18:
						goto IL_3F9;
					}
					goto IL_A2;
					IL_3C0:
					num = (short)725942285;
					num2 = (int)((global::System.IntPtr)num);
				}
				return;
				IL_21C:
				task.AddTask(new global::AcpBusinessLayer.UndoRedo.ModifyDataTask<int>(portableSideUpDownArrowButtonInner.PortableSideUpDownArrowButtonInnerSection.BtnSideUpDownArrowButtonSecondaryFunction_A41592, 67));
				return;
				IL_252:
				return;
				IL_350:
				task.AddTask(new global::AcpBusinessLayer.UndoRedo.ModifyDataTask<int>(portableSideUpDownArrowButtonInner.PortableSideUpDownArrowButtonInnerSection.BtnSideUpDownArrowButtonSecondaryFunction_A41592, 88));
				return;
				IL_3F9:
				task.AddTask(new global::AcpBusinessLayer.UndoRedo.ModifyDataTask<int>(portableSideUpDownArrowButtonInner.PortableSideUpDownArrowButtonInnerSection.BtnSideUpDownArrowButtonSecondaryFunction_A41592, 65));
				return;
				IL_A2:
				portableSideUpDownArrowButtonInnerSection = (self as global::Motorola.MackinawCPS.CoreFeatures.Buttons.PortableSideUpDownArrowButtonInnerSection);
				num = (short)1581121545;
				num2 = (int)((global::System.IntPtr)num);
				goto IL_4F;
			}
			}
		}

		// Token: 0x06008DE1 RID: 36321 RVA: 0x0085E7EC File Offset: 0x0085C9EC
		public static bool BtnShortPressAndLongPressIsApplicable(global::AcpCommonLib.IAcpFeatureSection self)
		{
			switch (0)
			{
			case 0:
				goto IL_20;
			}
			global::Motorola.MackinawCPS.CoreFeatures.Buttons.PortableButtonInnerSection portableButtonInnerSection;
			short num2;
			for (;;)
			{
				IL_0A:
				int num;
				switch (num)
				{
				case 0:
					goto IL_11A;
				case 1:
					if (portableButtonInnerSection.BtnGeneralConventionalFeature_A19544.Value == 31)
					{
						num2 = (short)383844354;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					num2 = (short)1871904771;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 2:
				{
					num2 = (short)328204288;
					short num3 = num2;
					num2 = (short)1385037825;
					if (num2 != 0)
					{
					}
					num2 = (short)555810816;
					num = (int)((global::System.IntPtr)num2);
					continue;
				}
				case 3:
					goto IL_143;
				}
				goto IL_20;
			}
			IL_143:
			bool flag = false;
			goto IL_146;
			IL_20:
			portableButtonInnerSection = (self as global::Motorola.MackinawCPS.CoreFeatures.Buttons.PortableButtonInnerSection);
			num2 = (short)139241130;
			short num4 = num2;
			num2 = (short)23242410;
			switch ((num4 == num2) ? 1 : 0)
			{
			case 0:
			case 2:
				IL_11A:
				flag = (portableButtonInnerSection.BtnTrunkingPortableButtonFeature_A19546.Value == 31);
				break;
			default:
			{
				num2 = (short)644612096;
				if (num2 != 0)
				{
				}
				num2 = (short)1904214017;
				int num = (int)((global::System.IntPtr)num2);
				goto IL_0A;
			}
			}
			IL_146:
			bool flag2 = portableButtonInnerSection.BtnGeneralConventionalFeature_A19544.Value == 269 && portableButtonInnerSection.BtnTrunkingPortableButtonFeature_A19546.Value == 269;
			bool flag3 = portableButtonInnerSection.BtnGeneralConventionalFeature_A19544.Value == 268 && portableButtonInnerSection.BtnTrunkingPortableButtonFeature_A19546.Value == 268;
			return !flag && !flag2 && !flag3;
		}

		// Token: 0x06008DE2 RID: 36322 RVA: 0x0085E9A0 File Offset: 0x0085CBA0
		public static bool RadConfigPortableButtonLongPressDurIsValid(global::AcpCommonLib.IAcpFeatureSection self)
		{
			switch (0)
			{
			case 0:
				goto IL_78;
			}
			int num;
			short num2;
			global::Motorola.MackinawCPS.CoreFeatures.Buttons.PortableButtonInnerSection portableButtonInnerSection;
			string uivalue;
			string uivalue2;
			for (;;)
			{
				IL_0A:
				switch (num)
				{
				case 0:
					return false;
				case 1:
					num2 = (short)1591017486;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 2:
					if (portableButtonInnerSection.BtnGeneralConventionalFeature_A19544.Value != 31)
					{
						num2 = (short)98828298;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_2DA;
				case 3:
					if (portableButtonInnerSection.BtnGeneralConventionalFeature_A19544.Value != 269)
					{
						num2 = (short)1441267713;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_2DA;
				case 4:
					if (portableButtonInnerSection.BtnGeneralConventionalFeature_A19544.Value != 268)
					{
						goto IL_468;
					}
					goto IL_2DA;
				case 5:
					num2 = (short)1633091585;
					if (num2 != 0)
					{
					}
					num2 = (short)1060306963;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 6:
					num2 = (short)1302396931;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 7:
					if (portableButtonInnerSection.BtnTrunkingPortableButtonFeature_A19546.Value != 268)
					{
						num2 = (short)21364754;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_2DA;
				case 8:
					if (portableButtonInnerSection.BtnTrunkingPortableButtonFeature_A19546.Value != 31)
					{
						num2 = (short)1407320064;
						short num3 = num2;
						num2 = (short)1961099270;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_2DA;
				case 9:
					if (uivalue == global::CommonResources.AcgResources.ID_RADIOWIDE)
					{
						num2 = (short)311623704;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					return true;
				case 10:
					num2 = (short)162005000;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 11:
					num2 = (short)1204420615;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 12:
					return true;
				case 13:
					if (global::System.Convert.ToInt32(uivalue) <= global::System.Convert.ToInt32(uivalue2))
					{
						num2 = (short)366215168;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					return true;
				case 14:
					if (portableButtonInnerSection.BtnTrunkingPortableButtonFeature_A19546.Value != 269)
					{
						num2 = (short)1052377109;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_2DA;
				case 15:
					num2 = (short)1005649945;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 16:
					if (uivalue == global::CommonResources.AcgResources.ID_RADIOWIDE)
					{
						num2 = (short)892665861;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_293;
				case 17:
					return false;
				case 18:
					num2 = (short)538837015;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 19:
					if (uivalue2 == global::CommonResources.AcgResources.ID_RADIOWIDE)
					{
						num2 = (short)1934622732;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_293;
				case 20:
					num2 = (short)559742989;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 21:
					num2 = (short)1996947460;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 22:
					if (uivalue != global::CommonResources.AcgResources.ID_RADIOWIDE)
					{
						num2 = (short)708182033;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					return true;
				case 23:
				{
					num2 = (short)1743917903;
					short num4 = num2;
					num2 = (short)639898447;
					switch ((num4 == num2) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_468;
					default:
						num2 = (short)1903165440;
						if (num2 != 0)
						{
						}
						if (uivalue != global::CommonResources.AcgResources.ID_RADIOWIDE)
						{
							num2 = (short)1277231119;
							num = (int)((global::System.IntPtr)num2);
							continue;
						}
						goto IL_31E;
					}
					break;
				}
				case 24:
					return false;
				case 25:
					if (uivalue2 != global::CommonResources.AcgResources.ID_RADIOWIDE)
					{
						num2 = (short)1523253268;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_31E;
				}
				goto IL_78;
				IL_293:
				num2 = (short)675282946;
				num = (int)((global::System.IntPtr)num2);
				continue;
				IL_2DA:
				num2 = (short)2022768662;
				num = (int)((global::System.IntPtr)num2);
				continue;
				IL_31E:
				num2 = (short)530972681;
				num = (int)((global::System.IntPtr)num2);
				continue;
				IL_468:
				num2 = (short)1476591627;
				num = (int)((global::System.IntPtr)num2);
			}
			return false;
			IL_78:
			portableButtonInnerSection = (self as global::Motorola.MackinawCPS.CoreFeatures.Buttons.PortableButtonInnerSection);
			uivalue = portableButtonInnerSection.BtnPortableTopButtonLongPressTime.UIValue;
			uivalue2 = portableButtonInnerSection.BtnTopButtonShortPressTime.UIValue;
			num2 = (short)1876492304;
			num = (int)((global::System.IntPtr)num2);
			goto IL_0A;
		}

		// Token: 0x06008DE3 RID: 36323 RVA: 0x0085EE78 File Offset: 0x0085D078
		public static bool RadConfigPortableButtonShortPressDurIsValid(global::AcpCommonLib.IAcpFeatureSection self)
		{
			switch (0)
			{
			case 0:
				goto IL_60;
			}
			int num;
			short num2;
			global::Motorola.MackinawCPS.CoreFeatures.Buttons.PortableButtonInnerSection portableButtonInnerSection;
			for (;;)
			{
				IL_0A:
				switch (num)
				{
				case 0:
					num2 = (short)434765838;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 1:
				{
					num2 = (short)1862205440;
					short num3 = num2;
					string uivalue;
					if (uivalue == global::CommonResources.AcgResources.ID_RADIOWIDE)
					{
						num2 = (short)1319960589;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_16F;
				}
				case 2:
					num2 = (short)1552941064;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 3:
					num2 = (short)1088684043;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 4:
				{
					string uivalue;
					if (uivalue != global::CommonResources.AcgResources.ID_RADIOWIDE)
					{
						num2 = (short)1468989456;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					return true;
				}
				case 5:
				{
					num2 = (short)1999291868;
					short num4 = num2;
					num2 = (short)199017948;
					switch ((num4 == num2) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_141;
					default:
						num2 = (short)59965440;
						if (num2 != 0)
						{
						}
						num2 = (short)1552416774;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					break;
				}
				case 6:
					goto IL_141;
				case 7:
					return false;
				case 8:
					if (portableButtonInnerSection.BtnTrunkingPortableButtonFeature_A19546.Value != 268)
					{
						num2 = (short)1486684178;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_1B1;
				case 9:
				{
					string uivalue;
					if (uivalue == global::CommonResources.AcgResources.ID_RADIOWIDE)
					{
						num2 = (short)1599864839;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					return true;
				}
				case 10:
				{
					num2 = (short)725286913;
					if (num2 != 0)
					{
					}
					string uivalue2 = portableButtonInnerSection.BtnPortableTopButtonLongPressTime.UIValue;
					string uivalue = portableButtonInnerSection.BtnTopButtonShortPressTime.UIValue;
					if (uivalue2 == global::CommonResources.AcgResources.ID_RADIOWIDE)
					{
						num2 = (short)607518737;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_16F;
				}
				case 11:
					if (portableButtonInnerSection.BtnTrunkingPortableButtonFeature_A19546.Value != 269)
					{
						num2 = (short)1420099589;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_1B1;
				case 12:
					if (portableButtonInnerSection.BtnGeneralConventionalFeature_A19544.Value != 31)
					{
						num2 = (short)880672768;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_1B1;
				case 13:
					return true;
				case 14:
					if (portableButtonInnerSection.BtnTrunkingPortableButtonFeature_A19546.Value != 31)
					{
						num2 = (short)850264083;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_1B1;
				case 15:
					if (portableButtonInnerSection.BtnGeneralConventionalFeature_A19544.Value != 269)
					{
						num2 = (short)957743107;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_1B1;
				case 16:
					return false;
				case 17:
					num2 = (short)1885667329;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 18:
					num2 = (short)1513160713;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 19:
					num2 = (short)824508431;
					num = (int)((global::System.IntPtr)num2);
					continue;
				}
				goto IL_60;
				IL_141:
				if (portableButtonInnerSection.BtnGeneralConventionalFeature_A19544.Value != 268)
				{
					num2 = (short)1721761794;
					num = (int)((global::System.IntPtr)num2);
					continue;
				}
				goto IL_1B1;
				IL_16F:
				num2 = (short)2109865996;
				num = (int)((global::System.IntPtr)num2);
				continue;
				IL_1B1:
				num2 = (short)1813577732;
				num = (int)((global::System.IntPtr)num2);
			}
			return false;
			IL_60:
			portableButtonInnerSection = (self as global::Motorola.MackinawCPS.CoreFeatures.Buttons.PortableButtonInnerSection);
			num2 = (short)1865285642;
			num = (int)((global::System.IntPtr)num2);
			goto IL_0A;
		}

		// Token: 0x06008DE4 RID: 36324 RVA: 0x0085F254 File Offset: 0x0085D454
		public static bool RadConfigDataButtonLongPressDurIsValid(global::AcpCommonLib.IAcpFeatureSection self)
		{
			switch (0)
			{
			case 0:
				goto IL_40;
			}
			int num;
			short num2;
			string uivalue;
			string id_RADIOWIDE;
			string uivalue2;
			for (;;)
			{
				IL_0A:
				switch (num)
				{
				case 0:
					num2 = (short)312803336;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 1:
					if (uivalue != id_RADIOWIDE)
					{
						num2 = (short)839974914;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_1C5;
				case 2:
					num2 = (short)2010185732;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 3:
					return false;
				case 4:
				{
					num2 = (short)2019078939;
					short num3 = num2;
					num2 = (short)1254863643;
					switch ((num3 == num2) ? 1 : 0)
					{
					case 0:
					case 2:
						break;
					default:
					{
						num2 = (short)622460928;
						if (num2 != 0)
						{
						}
						num2 = (short)938934272;
						short num4 = num2;
						if (global::System.Convert.ToInt32(uivalue2) > global::System.Convert.ToInt32(uivalue))
						{
							return true;
						}
						break;
					}
					}
					num2 = (short)756678659;
					num = (int)((global::System.IntPtr)num2);
					continue;
				}
				case 5:
					return false;
				case 6:
					return true;
				case 7:
					if (uivalue2 != id_RADIOWIDE)
					{
						num2 = (short)16121867;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_1C5;
				case 8:
					if (uivalue == id_RADIOWIDE)
					{
						num2 = (short)1538326534;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_23E;
				case 9:
					if (uivalue2 == id_RADIOWIDE)
					{
						num2 = (short)1632501760;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_23E;
				case 10:
					if (uivalue2 == id_RADIOWIDE)
					{
						num2 = (short)2018770949;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					return true;
				case 11:
					num2 = (short)1623392257;
					num = (int)((global::System.IntPtr)num2);
					continue;
				}
				goto IL_40;
				IL_1C5:
				num2 = (short)1070202890;
				num = (int)((global::System.IntPtr)num2);
				continue;
				IL_23E:
				num2 = (short)1566048263;
				num = (int)((global::System.IntPtr)num2);
			}
			return false;
			IL_40:
			global::Motorola.MackinawCPS.CoreFeatures.Buttons.DataButtonInnerSection dataButtonInnerSection = self as global::Motorola.MackinawCPS.CoreFeatures.Buttons.DataButtonInnerSection;
			uivalue2 = dataButtonInnerSection.BtnButtonDataButtonLongPressTime.UIValue;
			uivalue = dataButtonInnerSection.BtnPortableDataButtonShortPressTime.UIValue;
			id_RADIOWIDE = global::CommonResources.AcgResources.ID_RADIOWIDE;
			num2 = (short)803471361;
			if (num2 != 0)
			{
			}
			num2 = (short)194314249;
			num = (int)((global::System.IntPtr)num2);
			goto IL_0A;
		}

		// Token: 0x06008DE5 RID: 36325 RVA: 0x0085F4DC File Offset: 0x0085D6DC
		public static bool RadConfigDataButtonShortPressDurIsValid(global::AcpCommonLib.IAcpFeatureSection self)
		{
			switch (0)
			{
			case 0:
				goto IL_28;
			}
			string uivalue;
			string id_RADIOWIDE;
			short num2;
			string uivalue2;
			for (;;)
			{
				IL_0A:
				int num;
				switch (num)
				{
				case 0:
					if (uivalue == id_RADIOWIDE)
					{
						num2 = (short)1139146753;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					return true;
				case 1:
					return false;
				case 2:
					return true;
				case 3:
					goto IL_D0;
				case 4:
					if (uivalue2 == id_RADIOWIDE)
					{
						num2 = (short)720240643;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_D2;
				case 5:
					if (uivalue == id_RADIOWIDE)
					{
						num2 = (short)1607663617;
						if (num2 != 0)
						{
						}
						num2 = (short)1184890882;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_D2;
				}
				goto IL_28;
				IL_D2:
				num2 = (short)688979968;
				short num3 = num2;
				num2 = (short)1010237440;
				num = (int)((global::System.IntPtr)num2);
			}
			IL_D0:
			goto IL_139;
			IL_28:
			global::Motorola.MackinawCPS.CoreFeatures.Buttons.DataButtonInnerSection dataButtonInnerSection = self as global::Motorola.MackinawCPS.CoreFeatures.Buttons.DataButtonInnerSection;
			uivalue2 = dataButtonInnerSection.BtnButtonDataButtonLongPressTime.UIValue;
			uivalue = dataButtonInnerSection.BtnPortableDataButtonShortPressTime.UIValue;
			id_RADIOWIDE = global::CommonResources.AcgResources.ID_RADIOWIDE;
			num2 = (short)72359625;
			short num4 = num2;
			num2 = (short)1041833673;
			switch ((num4 == num2) ? 1 : 0)
			{
			case 0:
			case 2:
			{
				IL_139:
				num2 = (short)859635717;
				int num = (int)((global::System.IntPtr)num2);
				goto IL_0A;
			}
			default:
			{
				num2 = (short)2043936768;
				if (num2 != 0)
				{
				}
				num2 = (short)1771634692;
				int num = (int)((global::System.IntPtr)num2);
				goto IL_0A;
			}
			}
		}
	}
}
