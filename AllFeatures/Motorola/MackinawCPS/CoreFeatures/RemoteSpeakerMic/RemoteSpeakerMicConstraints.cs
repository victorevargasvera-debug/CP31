using System;
using System.Collections.Generic;
using AcpBusinessLayer;
using AcpBusinessLayer.UndoRedo;
using AcpCommonLib;
using AcpCommonLib.UndoRedo;
using AllFeatures;
using CommonResources;
using ConstraintHelper;
using Motorola.MackinawCPS.CoreFeatures.Buttons;
using Motorola.MackinawCPS.CoreFeatures.EmergencyWide;
using Motorola.MackinawCPS.CoreFeatures.MenuItems;
using Motorola.MackinawCPS.CoreFeatures.RadioErgonomicsWide;
using Motorola.MackinawCPS.CoreFeatures.RadioInformation;
using Motorola.MackinawCPS.CoreFeatures.RadioWide;
using Motorola.MackinawCPS.CoreFeatures.SmartKeyFob;
using Motorola.MackinawCPS.CoreFeatures.Switches;
using Motorola.MackinawCPS.CoreFeatures.TrunkingEmergencyProfiles;

namespace Motorola.MackinawCPS.CoreFeatures.RemoteSpeakerMic
{
	// Token: 0x020002D1 RID: 721
	public static class RemoteSpeakerMicConstraints
	{
		// Token: 0x060077E1 RID: 30689 RVA: 0x006C5DF8 File Offset: 0x006C3FF8
		public static bool conSetEditabilityRSMCnvFeature(global::AcpCommonLib.IAcpFeatureSection self)
		{
			short num = (short)84148224;
			short num2 = num;
			num = (short)1323630593;
			if (num != 0)
			{
			}
			num = (short)1245678437;
			short num3 = num;
			num = (short)1254591333;
			switch ((num3 == num) ? 1 : 0)
			{
			case 0:
			case 2:
				break;
			default:
			{
				num = (short)426115072;
				if (num != 0)
				{
				}
				global::AcpCommonLib.IAcpFeatureNode parent = (self as global::Motorola.MackinawCPS.CoreFeatures.RemoteSpeakerMic.RSMButtonInnerSection).RadErgoCfgRSMlConventionalFeature_A19640.Parent.Parent;
				if ((parent.Parent as global::AcpBusinessLayer.Recordset).IndexOf(parent) == 0)
				{
					return false;
				}
				break;
			}
			}
			return true;
		}

		// Token: 0x060077E2 RID: 30690 RVA: 0x006C5ED0 File Offset: 0x006C40D0
		public static bool ConTrunkingRSMFeaturesSelect(global::AcpCommonLib.IAcpFeatureSection self, int index)
		{
			int a_ = 16;
			short num = (short)512491520;
			int num2 = (int)num;
			switch (num2)
			{
			default:
			{
				switch (0)
				{
				case 0:
					goto IL_3CF;
				}
				global::Motorola.MackinawCPS.CoreFeatures.RemoteSpeakerMic.RSMButtonInnerSection rsmbuttonInnerSection;
				bool flag;
				global::AcpCommonLib.IAcpRecordset embeddedRecset;
				global::Motorola.MackinawCPS.CoreFeatures.RemoteSpeakerMic.RSMButtonInnerRecset rsmbuttonInnerRecset;
				global::AcpCommonLib.IAcpRecordset embeddedRecset2;
				global::AcpBusinessLayer.AcpListField emerWideManDownTrigger_A;
				global::Motorola.MackinawCPS.CoreFeatures.Switches.Switches switches;
				global::Motorola.MackinawCPS.CoreFeatures.RadioInformation.Labtool labtool;
				global::Motorola.MackinawCPS.CoreFeatures.RadioErgonomicsWide.RadioErgonomicsWide radioErgonomicsWide;
				global::AcpBusinessLayer.AcpListField switchTrunkingSwitchesPosition1_A;
				global::AcpBusinessLayer.AcpListField switchTrunkingSwitchesPosition2_A;
				global::AcpBusinessLayer.AcpListField switchConventionalSwitchesPosition3_A;
				global::Motorola.MackinawCPS.CoreFeatures.TrunkingEmergencyProfiles.TrunkingEmergencyProfilesRecset trunkingEmergencyProfilesRecset;
				global::AcpBusinessLayer.AcpListField switchTrunkingSwitchesPosition3_A;
				global::AcpBusinessLayer.AcpListField switchConventionalSwitchesPosition4_A;
				bool flag4;
				global::AcpBusinessLayer.AcpListField switchConventionalSwitchesPosition2_A;
				global::AcpBusinessLayer.AcpListField switchConventionalSwitchesPosition1_A;
				global::AcpBusinessLayer.AcpListField switchTrunkingSwitchesPosition4_A;
				global::AcpBusinessLayer.AcpListField switchTrunkingSwitchesPosition5_A;
				global::Motorola.MackinawCPS.CoreFeatures.RadioWide.Features features;
				global::AcpBusinessLayer.AcpListField switchConventionalSwitchesPosition5_A;
				for (;;)
				{
					IL_30:
					int num4;
					int num5;
					int num6;
					int num8;
					bool flag2;
					int num9;
					bool flag3;
					global::AcpCommonLib.IAcpRecordset feature;
					switch (num2)
					{
					case 0:
						if (rsmbuttonInnerSection.RadErgoCfgRSMlConventionalFeature_A19640.Value != 66)
						{
							num = (short)1582432291;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return flag;
					case 1:
						return flag;
					case 2:
						goto IL_169B;
					case 3:
						if (index != 33)
						{
							num = (short)983105761;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)523108532;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 4:
						num = (short)351273051;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 5:
						num = (short)1812267220;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 6:
						flag = false;
						num = (short)1849360550;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 7:
					{
						global::Motorola.MackinawCPS.CoreFeatures.RadioWide.RadioWide radioWide;
						if (radioWide != null)
						{
							num = (short)1678246021;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return flag;
					}
					case 8:
					{
						int num3;
						if (num3 >= embeddedRecset.Count)
						{
							num = (short)349700226;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)1451032600;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 9:
						if (rsmbuttonInnerSection.RadErgoCfgRSMlConventionalFeature_A19640.Value != 149)
						{
							num = (short)81395739;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return flag;
					case 10:
					{
						global::Motorola.MackinawCPS.CoreFeatures.MenuItems.MenuItems menuItems;
						if (menuItems.General.DispMenuTrunkingSelectedMenuItems_A21735.Items[num4].ItemName == global::CommonResources.AcgResources.ID_SCAN)
						{
							num = (short)253952176;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_1657;
					}
					case 11:
						flag = false;
						num = (short)327024641;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 12:
						return flag;
					case 13:
						num = (short)504692775;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 14:
						if (rsmbuttonInnerSection.RadErgoCfgRSMTrunkingBCO_A19741.Value != 151)
						{
							num = (short)475791524;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return flag;
					case 15:
						num = (short)1151991884;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 16:
						if ((rsmbuttonInnerSection.ParentRecset[num5] as global::Motorola.MackinawCPS.CoreFeatures.RemoteSpeakerMic.RSMButtonInner).RSMButtonInnerSection.RadErgoCfgRSMlTrunkingFeature_A19742.Value == 61)
						{
							num = (short)807337999;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_119C;
					case 17:
						num = (short)197722154;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 18:
						if ((rsmbuttonInnerRecset[num6] as global::Motorola.MackinawCPS.CoreFeatures.RemoteSpeakerMic.RSMButtonInner).RSMButtonInnerSection.RadErgoCfgRSMTrunkingBCO_A19741.Value != 151)
						{
							num = (short)923926551;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_2458;
					case 19:
						num = (short)168820737;
						if (num != 0)
						{
						}
						num6 = 0;
						num = (short)943849502;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 20:
						return flag;
					case 21:
						flag = false;
						num = (short)853672150;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 22:
						goto IL_1028;
					case 23:
						num = (short)403439675;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 24:
					{
						int num3;
						if ((embeddedRecset[num3] as global::Motorola.MackinawCPS.CoreFeatures.Buttons.PortableButtonInner).PortableButtonInnerSection.BtnTrunkingPortableButtonFeature_A19546.Value == 61)
						{
							num = (short)891027477;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num3++;
						num = (short)2094923987;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 25:
					{
						int num7;
						if ((embeddedRecset2[num7] as global::Motorola.MackinawCPS.CoreFeatures.SmartKeyFob.SmartKeyFobButtonTableInner).SmartKeyFobButtonTableInnerSection.RadErgoCfgFobTrunkingFeature_A41575.Value == 61)
						{
							num = (short)1610481749;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num7++;
						num = (short)1956380732;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 26:
						goto IL_1B83;
					case 27:
						flag = false;
						num = (short)854065172;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 28:
						goto IL_2233;
					case 29:
						num = (short)961413349;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 30:
						goto IL_1B3E;
					case 31:
						if (rsmbuttonInnerSection.RadErgoCfgRSMlConventionalFeature_A19640.Value != 214)
						{
							num = (short)1315635280;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return flag;
					case 32:
						if (rsmbuttonInnerSection.RadErgoCfgRSMlConventionalFeature_A19640.Value != 236)
						{
							num = (short)48562384;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return flag;
					case 33:
						goto IL_A63;
					case 34:
						num = (short)630784123;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 35:
						flag = false;
						num = (short)1652162721;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 36:
						if (index != 149)
						{
							num = (short)1954545822;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)600637449;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 37:
						switch (index)
						{
						case 209:
							num = (short)968556651;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 210:
							num = (short)1987444786;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 211:
							num = (short)770048155;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 212:
							num = (short)714145948;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 213:
						case 215:
						case 216:
							return flag;
						case 214:
							num = (short)1656356895;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 217:
							flag = (emerWideManDownTrigger_A.Value != 0);
							num = (short)344129689;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						default:
							num = (short)1239351391;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						break;
					case 38:
						if (embeddedRecset != null)
						{
							num = (short)454951094;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return flag;
					case 39:
						if ((embeddedRecset[num8] as global::Motorola.MackinawCPS.CoreFeatures.Buttons.PortableButtonInner).PortableButtonInnerSection.BtnTrunkingPortableButtonFeature_A19546.Value == 31)
						{
							num = (short)1431240853;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_70B;
					case 40:
						num = (short)1259601989;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 41:
						return flag;
					case 42:
						if (switches.TrunkingSwitches.SwitchTrunkingSwitchesPosition1_A9466.Value != 61)
						{
							num = (short)1377108066;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_1B83;
					case 43:
						goto IL_1700;
					case 44:
						if (labtool.RadInfoLabtoolBluetooth_A37042.Value)
						{
							num = (short)2029715587;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_1700;
					case 45:
						num = (short)1472331949;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 46:
						if (radioErgonomicsWide.Advanced.RadErgoWideAdvancedSideButtonsLockEnable_A38725.Value)
						{
							num = (short)1353515185;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return flag;
					case 47:
						num = (short)1790705848;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 48:
						num = (short)383647971;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 49:
						flag2 = (embeddedRecset2 != null);
						goto IL_27CA;
					case 50:
						if (rsmbuttonInnerSection.RadErgoCfgRSMlConventionalFeature_A19640.Value != 210)
						{
							num = (short)761856011;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return flag;
					case 51:
						return flag;
					case 52:
						if (switchTrunkingSwitchesPosition1_A.Value != 33)
						{
							num = (short)623902760;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_B5B;
					case 53:
						num = (short)1973354614;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 54:
						num = (short)1641414846;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 55:
					{
						global::Motorola.MackinawCPS.CoreFeatures.RadioWide.RadioWide radioWide;
						if (radioWide.Features.RadWideFeaturesVoiceControlPriority.Value == 0)
						{
							num = (short)1689518200;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return flag;
					}
					case 56:
						flag = false;
						num = (short)158400611;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 57:
						if (flag)
						{
							num = (short)1204289553;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return flag;
					case 58:
						goto IL_169B;
					case 59:
						if ((rsmbuttonInnerRecset[num6] as global::Motorola.MackinawCPS.CoreFeatures.RemoteSpeakerMic.RSMButtonInner).RSMButtonInnerSection.RadErgoCfgRSMlTrunkingFeature_A19742.Value == 31)
						{
							num = (short)818806837;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_2458;
					case 60:
						goto IL_816;
					case 61:
						if (radioErgonomicsWide.Advanced.RadErgoWideAdvancedSideButtonsLockEnable_A38725.Value)
						{
							num = (short)188743795;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return flag;
					case 62:
						flag = false;
						num = (short)1402863814;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 63:
						if (rsmbuttonInnerSection.RadErgoCfgRSMlConventionalFeature_A19640.Value != 87)
						{
							num = (short)1423245504;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return flag;
					case 64:
						flag = false;
						num = (short)1917124836;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 65:
					{
						global::Motorola.MackinawCPS.CoreFeatures.MenuItems.MenuItems menuItems;
						if (num9 >= menuItems.General.DispMenuConventionalSelectedMenuItems_A21736.Items.Count)
						{
							num = (short)1004077200;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)2041380992;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 66:
						num = (short)659685412;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 67:
						num = (short)206110772;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 68:
						flag = false;
						num = (short)1582039073;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 69:
						if (switchTrunkingSwitchesPosition2_A.Value != 33)
						{
							num = (short)1918566404;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_B5B;
					case 70:
						if (switchConventionalSwitchesPosition3_A.Value != 33)
						{
							num = (short)475791442;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_B5B;
					case 71:
						if (flag)
						{
							num = (short)1596325984;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return flag;
					case 72:
						goto IL_195A;
					case 73:
						if (switches.TrunkingSwitches.SwitchTrunkingSwitchesPosition2_A9467.Value != 61)
						{
							num = (short)725942346;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_1B83;
					case 74:
						num = (short)564789356;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 75:
						num = (short)7143576;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 76:
						if (rsmbuttonInnerSection.ParentRecset[num5] != self.Parent)
						{
							num = (short)1490026502;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_119C;
					case 77:
						if (switches.TrunkingSwitches.SwitchTrunkingSwitchesPosition5_A21535.Value == 61)
						{
							num = (short)709492762;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return flag;
					case 78:
						if (flag)
						{
							num = (short)479985692;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return flag;
					case 79:
						if (flag)
						{
							num = (short)591593687;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)1572339905;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 80:
						flag = false;
						num = (short)1858011148;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 81:
						num = (short)960037001;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 82:
						num = (short)1300234345;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 83:
					{
						if (index != 266)
						{
							num = (short)538574959;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						flag = false;
						global::System.Collections.Generic.IEnumerator<global::AcpBusinessLayer.FeatureNode> enumerator = trunkingEmergencyProfilesRecset.GetEnumerator();
						num = (short)1869349002;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 84:
					{
						int num3 = 0;
						num = (short)877723749;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 85:
						flag = false;
						num = (short)1259077654;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 86:
						flag3 = false;
						goto IL_2516;
					case 87:
						if (num6 >= rsmbuttonInnerRecset.Count)
						{
							num = (short)834076851;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)760086546;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 88:
						goto IL_10DF;
					case 89:
						if ((embeddedRecset[num8] as global::Motorola.MackinawCPS.CoreFeatures.Buttons.PortableButtonInner).PortableButtonInnerSection.BtnTrunkingPortableTrunkingBCO_A19545.Value != 148)
						{
							num = (short)1647050765;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_70B;
					case 90:
					{
						global::Motorola.MackinawCPS.CoreFeatures.MenuItems.MenuItems menuItems;
						if (num4 >= menuItems.General.DispMenuTrunkingSelectedMenuItems_A21735.Items.Count)
						{
							num = (short)596770979;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)318963722;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 91:
						if (switchTrunkingSwitchesPosition3_A.Value != 33)
						{
							num = (short)1668415535;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_B5B;
					case 92:
					{
						global::Motorola.MackinawCPS.CoreFeatures.MenuItems.MenuItems menuItems = feature[0] as global::Motorola.MackinawCPS.CoreFeatures.MenuItems.MenuItems;
						num9 = 0;
						num = (short)1828520125;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 93:
						flag = false;
						num = (short)1372323881;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 94:
						if (num8 >= embeddedRecset.Count)
						{
							num = (short)242942099;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)1439694937;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 95:
						num = (short)893845678;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 96:
						num = (short)1759903963;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 97:
						flag = false;
						num = (short)2040266892;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 98:
						num = (short)1371340873;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 99:
						return flag;
					case 100:
						if (index != 87)
						{
							num = (short)1161035895;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)551813183;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 101:
						goto IL_202C;
					case 102:
						flag = false;
						num = (short)1629945907;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 103:
						return flag;
					case 104:
						flag = false;
						num = (short)2062876781;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 105:
						if (switchConventionalSwitchesPosition4_A.Value != 33)
						{
							num = (short)1589116957;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_B5B;
					case 106:
						if (index <= 33)
						{
							num = (short)882442294;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)143589575;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 107:
						if (rsmbuttonInnerSection.RadErgoCfgRSMlConventionalFeature_A19640.Value != 209)
						{
							num = (short)474415206;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return flag;
					case 108:
						if (switches.TrunkingSwitches.SwitchTrunkingSwitchesPosition3_A9468.Value != 61)
						{
							num = (short)559480837;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_1B83;
					case 109:
						return flag;
					case 110:
						return flag;
					case 111:
						num = (short)802816150;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 112:
						if (rsmbuttonInnerSection.RadErgoCfgRSMTrunkingBCO_A19741.Value != 145)
						{
							num = (short)177275004;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return flag;
					case 113:
						return flag;
					case 114:
						if (rsmbuttonInnerSection.RadErgoCfgRSMTrunkingBCO_A19741.Value != 151)
						{
							num = (short)1700790450;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return flag;
					case 115:
						num = (short)2053308530;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 116:
						num = (short)886374483;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 117:
						return flag;
					case 118:
						if (rsmbuttonInnerRecset[num6] as global::Motorola.MackinawCPS.CoreFeatures.RemoteSpeakerMic.RSMButtonInner != self.Parent)
						{
							num = (short)1070006340;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_2458;
					case 119:
						num = (short)1539768446;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 120:
						flag = false;
						num = (short)916652145;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 121:
						num = (short)1368260768;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 122:
						num = (short)2145452035;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 123:
						if (index != 81)
						{
							num = (short)199360706;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)236519563;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 124:
						flag = false;
						num = (short)1531183207;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 125:
					{
						int num7;
						if (num7 >= embeddedRecset2.Count)
						{
							num = (short)509673692;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)362020889;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 126:
						if (index != 88)
						{
							num = (short)1368457261;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)482672791;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 127:
						num = (short)1237516511;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 128:
					{
						global::Motorola.MackinawCPS.CoreFeatures.MenuItems.MenuItems menuItems;
						if (menuItems.General.DispMenuConventionalSelectedMenuItems_A21736.Items[num9].ItemName == global::CommonResources.AcgResources.ID_SCAN)
						{
							num = (short)1073545280;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_AA3;
					}
					case 129:
					{
						int num7 = 0;
						num = (short)1085014170;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 130:
						goto IL_68D;
					case 131:
						flag4 = true;
						num = (short)734199851;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 132:
						return flag;
					case 133:
						num = (short)2065104951;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 134:
						return flag;
					case 135:
					{
						if (index != 269)
						{
							num = (short)1252786224;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						global::Motorola.MackinawCPS.CoreFeatures.RadioWide.RadioWide radioWide = global::AcpCommonLib.FeatureManager.GetFeature(2045)[0] as global::Motorola.MackinawCPS.CoreFeatures.RadioWide.RadioWide;
						num = (short)156434439;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 136:
						flag = false;
						num = (short)1630470303;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 137:
						if (switchConventionalSwitchesPosition2_A.Value != 33)
						{
							num = (short)1345126586;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_B5B;
					case 138:
						try
						{
							num = (short)905248774;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								switch (num2)
								{
								case 0:
									num = (short)548405250;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 1:
								{
									global::System.Collections.Generic.IEnumerator<global::AcpBusinessLayer.FeatureNode> enumerator;
									if (((global::Motorola.MackinawCPS.CoreFeatures.TrunkingEmergencyProfiles.TrunkingEmergencyProfiles)enumerator.Current).EmergencyCompatibilityOptionsTrunking.EmergencyExitControl_43341.Value == 3)
									{
										num = (short)125960195;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									break;
								}
								case 2:
									goto IL_2176;
								case 3:
									flag = true;
									num = (short)2134573061;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 4:
								{
									global::System.Collections.Generic.IEnumerator<global::AcpBusinessLayer.FeatureNode> enumerator;
									if (!enumerator.MoveNext())
									{
										num = (short)133496832;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									num = (short)2099904513;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 6:
									switch (0)
									{
									case 0:
										goto IL_20B3;
									}
									continue;
								}
								IL_211F:
								num = (short)490143748;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								IL_20B3:
								goto IL_211F;
							}
							IL_2176:
							goto IL_2366;
						}
						finally
						{
							num = (short)776011778;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								switch (num2)
								{
								case 0:
									goto IL_2230;
								case 1:
									goto IL_2211;
								case 2:
								{
									num = (short)1799386495;
									short num10 = num;
									num = (short)1996060031;
									switch ((num10 == num) ? 1 : 0)
									{
									case 0:
									case 2:
										goto IL_2211;
									default:
										num = (short)1879703552;
										if (num != 0)
										{
										}
										switch (0)
										{
										case 0:
											goto IL_21F7;
										}
										continue;
									}
									break;
								}
								}
								IL_21F7:
								global::System.Collections.Generic.IEnumerator<global::AcpBusinessLayer.FeatureNode> enumerator;
								if (enumerator != null)
								{
									num = (short)749666305;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								break;
								IL_2211:
								enumerator.Dispose();
								num = (short)379846656;
								num2 = (int)((global::System.IntPtr)num);
							}
							IL_2230:;
						}
						goto IL_2233;
						IL_2366:
						num = (short)492109936;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 139:
						if (switchConventionalSwitchesPosition1_A.Value == 81)
						{
							num = (short)475332701;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return flag;
					case 140:
						return flag;
					case 141:
						if (rsmbuttonInnerSection.RadErgoCfgRSMlConventionalFeature_A19640.Value != 65)
						{
							num = (short)220266681;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return flag;
					case 142:
						if (global::ConstraintHelper.UtilityMack.ProductModelId.Equals(global::AllFeatures.CodeplugGuid.b("郐菒跔", a_)))
						{
							num = (short)1280376851;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						flag = false;
						num = (short)211353762;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 143:
						return flag;
					case 144:
						num4 = 0;
						num = (short)586744025;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 145:
						num = (short)84738191;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 146:
						if (rsmbuttonInnerSection.RadErgoCfgRSMlConventionalFeature_A19640.Value != 64)
						{
							num = (short)58327261;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return flag;
					case 147:
						num = (short)245956789;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 148:
						goto IL_1C33;
					case 149:
						flag = false;
						num = (short)773390545;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 150:
						return flag;
					case 151:
						if (rsmbuttonInnerSection.RadErgoCfgRSMlConventionalFeature_A19640.Value != 88)
						{
							num = (short)1223688328;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return flag;
					case 152:
						if (embeddedRecset != null)
						{
							num = (short)578027604;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_68D;
					case 153:
						return flag;
					case 154:
						goto IL_816;
					case 155:
						if (rsmbuttonInnerSection.RadErgoCfgRSMlConventionalFeature_A19640.Value != 211)
						{
							num = (short)955908152;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return flag;
					case 156:
						if (rsmbuttonInnerSection.RadErgoCfgRSMlConventionalFeature_A19640.Value != 212)
						{
							num = (short)1722810430;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return flag;
					case 157:
						num = (short)916062412;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 158:
						num = (short)1272643621;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 159:
						return flag;
					case 160:
						if (index != 31)
						{
							num = (short)320602234;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)1001455677;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 161:
						return flag;
					case 162:
						return flag;
					case 163:
						num = (short)1107361902;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 164:
						num = (short)1918107790;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 165:
						if (rsmbuttonInnerSection.RadErgoCfgRSMlConventionalFeature_A19640.Value != 235)
						{
							num = (short)526647400;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return flag;
					case 166:
						goto IL_1C33;
					case 167:
						return flag;
					case 168:
						if (rsmbuttonInnerSection.RadErgoCfgRSMlConventionalFeature_A19640.Value != 67)
						{
							num = (short)53674181;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return flag;
					case 169:
						return flag;
					case 170:
						num = (short)890241191;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 171:
						if (feature.Count != 0)
						{
							num = (short)467009628;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return flag;
					case 172:
						goto IL_15D1;
					case 173:
						return flag;
					case 174:
						if (index != 235)
						{
							num = (short)1574305937;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)1530527909;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 175:
						num = (short)520552492;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 176:
						flag = false;
						num = (short)594673851;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 177:
						num = (short)168427534;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 178:
						num5 = 0;
						num = (short)550109242;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 179:
						goto IL_A63;
					case 180:
						if (switchConventionalSwitchesPosition1_A.Value != 33)
						{
							num = (short)9044049;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_B5B;
					case 181:
						return flag;
					case 182:
						num8 = 0;
						num = (short)187498668;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 183:
						num = (short)200736973;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 184:
						if (switchTrunkingSwitchesPosition4_A.Value != 33)
						{
							num = (short)1189478583;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_B5B;
					case 185:
						flag = false;
						num = (short)1030160602;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 186:
						num = (short)894763078;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 187:
						goto IL_1657;
					case 188:
						num = (short)1095499853;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 189:
						goto IL_195A;
					case 190:
						if (index != 27)
						{
							num = (short)629997689;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)1460535520;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 191:
						num = (short)872480874;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 192:
						flag = false;
						num = (short)2021982409;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 193:
						flag2 = false;
						goto IL_27CA;
					case 194:
						num = (short)1116668021;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 195:
						return flag;
					case 196:
						if (labtool != null)
						{
							num = (short)1563492527;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_1700;
					case 197:
						flag = false;
						num = (short)193200297;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 198:
						return flag;
					case 199:
						if (index <= 81)
						{
							num = (short)391839871;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)158269540;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 200:
						if (index <= 235)
						{
							num = (short)836173890;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)665911502;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 201:
						return flag;
					case 202:
						num = (short)1112146091;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 203:
						goto IL_15D1;
					case 204:
						if (index != 236)
						{
							num = (short)2021916788;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)366673952;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 205:
						flag3 = (switchTrunkingSwitchesPosition5_A.Value != 33);
						goto IL_2516;
					case 206:
						if (index <= 266)
						{
							num = (short)1404174493;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)1603600519;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 207:
						if (flag)
						{
							num = (short)710410315;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_68D;
					case 208:
						flag = false;
						num = (short)1562443971;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 209:
						return flag;
					case 210:
						return flag;
					case 211:
						goto IL_202C;
					case 212:
						if (switches.TrunkingSwitches.SwitchTrunkingSwitchesPosition4_A21534.Value != 61)
						{
							num = (short)641532092;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_1B83;
					case 213:
						if (num5 >= rsmbuttonInnerSection.ParentRecset.Count)
						{
							num = (short)512819348;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)928972816;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 214:
						goto IL_68D;
					case 215:
						num = (short)1034551345;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 216:
						goto IL_1B3E;
					case 217:
						goto IL_10DF;
					case 218:
						return flag;
					case 219:
						if (feature != null)
						{
							num = (short)2057502922;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return flag;
					case 220:
						goto IL_1028;
					case 221:
						flag = false;
						num = (short)152764548;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 222:
						return flag;
					case 223:
						switch (index)
						{
						case 61:
							num = (short)215154734;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 62:
						case 63:
							return flag;
						case 64:
							num = (short)1158086802;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 65:
							num = (short)941555853;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 66:
							num = (short)654573568;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 67:
							num = (short)1965490344;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						default:
							num = (short)222625826;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						break;
					case 224:
						if (rsmbuttonInnerSection.RadErgoCfgRSMlConventionalFeature_A19640.Value != 27)
						{
							num = (short)418775137;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return flag;
					case 225:
						num = (short)1452671110;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 226:
						if (index <= 88)
						{
							num = (short)674234559;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)200736968;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 227:
					{
						if (index - 290 > 1)
						{
							num = (short)284688554;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						flag = features.RadWideFeaturesChannelFallbackEnableValue;
						num = (short)1606418432;
						short num11 = num;
						num = (short)85262546;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 228:
						goto IL_AA3;
					case 229:
						if (switchConventionalSwitchesPosition5_A.Value != 33)
						{
							num = (short)1920073795;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_B5B;
					}
					goto IL_3CF;
					IL_68D:
					num = (short)591331407;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_70B:
					num8++;
					num = (short)1596195019;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_816:
					num = (short)209125501;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_A63:
					num = (short)1615396942;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_AA3:
					num9++;
					num = (short)57671752;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_B5B:
					num = (short)314376278;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_1028:
					num = (short)2089484345;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_27CA:
					if (flag2 && flag4)
					{
						num = (short)716898433;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_1028;
					IL_10DF:
					num = (short)1986855002;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_119C:
					num5++;
					num = (short)1035010050;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_15D1:
					num = (short)686227550;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_1657:
					num4++;
					num = (short)795017304;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_169B:
					num = (short)293798101;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_1700:
					num = (short)1112211682;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_195A:
					num = (short)1253900353;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_1B3E:
					num = (short)1259798615;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_1B83:
					flag = false;
					num = (short)1711800542;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_1C33:
					num = (short)1663762639;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_202C:
					num = (short)2036334600;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_2233:
					num = (short)490471462;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_2458:
					num6++;
					num = (short)1539178712;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_2516:
					flag = flag3;
					feature = global::AcpCommonLib.FeatureManager.GetFeature(2088);
					num = (short)1533673543;
					num2 = (int)((global::System.IntPtr)num);
				}
				return flag;
				IL_3CF:
				rsmbuttonInnerSection = (self as global::Motorola.MackinawCPS.CoreFeatures.RemoteSpeakerMic.RSMButtonInnerSection);
				switchConventionalSwitchesPosition1_A = rsmbuttonInnerSection.RefSwitches.ConventionalSwitches.SwitchConventionalSwitchesPosition1_A7734;
				switchConventionalSwitchesPosition2_A = rsmbuttonInnerSection.RefSwitches.ConventionalSwitches.SwitchConventionalSwitchesPosition2_A7735;
				switchConventionalSwitchesPosition3_A = rsmbuttonInnerSection.RefSwitches.ConventionalSwitches.SwitchConventionalSwitchesPosition3_A7737;
				switchConventionalSwitchesPosition4_A = rsmbuttonInnerSection.RefSwitches.ConventionalSwitches.SwitchConventionalSwitchesPosition4_A21530;
				switchConventionalSwitchesPosition5_A = rsmbuttonInnerSection.RefSwitches.ConventionalSwitches.SwitchConventionalSwitchesPosition5_A21531;
				switchTrunkingSwitchesPosition1_A = rsmbuttonInnerSection.RefSwitches.TrunkingSwitches.SwitchTrunkingSwitchesPosition1_A9466;
				switchTrunkingSwitchesPosition2_A = rsmbuttonInnerSection.RefSwitches.TrunkingSwitches.SwitchTrunkingSwitchesPosition2_A9467;
				switchTrunkingSwitchesPosition3_A = rsmbuttonInnerSection.RefSwitches.TrunkingSwitches.SwitchTrunkingSwitchesPosition3_A9468;
				switchTrunkingSwitchesPosition4_A = rsmbuttonInnerSection.RefSwitches.TrunkingSwitches.SwitchTrunkingSwitchesPosition4_A21534;
				switchTrunkingSwitchesPosition5_A = rsmbuttonInnerSection.RefSwitches.TrunkingSwitches.SwitchTrunkingSwitchesPosition5_A21535;
				rsmbuttonInnerRecset = ((global::AcpCommonLib.FeatureManager.GetFeature(2036) as global::Motorola.MackinawCPS.CoreFeatures.RemoteSpeakerMic.RemoteSpeakerMicRecset)[0][10079].EmbeddedRecset as global::Motorola.MackinawCPS.CoreFeatures.RemoteSpeakerMic.RSMButtonInnerRecset);
				global::AcpCommonLib.IAcpFeatureNode parent = rsmbuttonInnerSection.RadErgoCfgRSMlTrunkingFeature_A19742.Parent.Parent;
				(parent.Parent as global::AcpBusinessLayer.Recordset).IndexOf(parent);
				flag = true;
				radioErgonomicsWide = (global::AcpCommonLib.FeatureManager.GetFeature(2033)[0] as global::Motorola.MackinawCPS.CoreFeatures.RadioErgonomicsWide.RadioErgonomicsWide);
				embeddedRecset = global::AcpCommonLib.FeatureManager.GetFeature(2042)[0][10091].EmbeddedRecset;
				switches = (global::AcpCommonLib.FeatureManager.GetFeature(2038)[0] as global::Motorola.MackinawCPS.CoreFeatures.Switches.Switches);
				trunkingEmergencyProfilesRecset = (global::AcpCommonLib.FeatureManager.GetFeature(2076) as global::Motorola.MackinawCPS.CoreFeatures.TrunkingEmergencyProfiles.TrunkingEmergencyProfilesRecset);
				emerWideManDownTrigger_A = ((global::AcpCommonLib.FeatureManager.GetFeature(2032) as global::Motorola.MackinawCPS.CoreFeatures.EmergencyWide.EmergencyWideRecset)[0][10639] as global::Motorola.MackinawCPS.CoreFeatures.EmergencyWide.ManDown).EmerWideManDownTrigger_A40001;
				embeddedRecset2 = global::AcpCommonLib.FeatureManager.GetFeature(4130)[0][10747].EmbeddedRecset;
				labtool = (global::AcpCommonLib.FeatureManager.GetFeature(2049)[0][10107] as global::Motorola.MackinawCPS.CoreFeatures.RadioInformation.Labtool);
				features = (global::AcpCommonLib.FeatureManager.GetFeature(2045)[0][10105] as global::Motorola.MackinawCPS.CoreFeatures.RadioWide.Features);
				flag4 = false;
				num = (short)1220083908;
				num2 = (int)((global::System.IntPtr)num);
				goto IL_30;
			}
			}
		}

		// Token: 0x060077E3 RID: 30691 RVA: 0x006C86EC File Offset: 0x006C68EC
		public static bool ConConventionalRSMFeaturesSelect(global::AcpCommonLib.IAcpFeatureSection self, int index)
		{
			int a_ = 18;
			short num = (short)1165885440;
			int num2 = (int)num;
			switch (num2)
			{
			default:
			{
				switch (0)
				{
				case 0:
					goto IL_395;
				}
				bool flag;
				global::AcpCommonLib.IAcpRecordset embeddedRecset;
				global::Motorola.MackinawCPS.CoreFeatures.Switches.Switches switches;
				global::AcpBusinessLayer.AcpListField switchConventionalSwitchesPosition5_A;
				global::Motorola.MackinawCPS.CoreFeatures.Buttons.PortableButtonInnerRecset portableButtonInnerRecset;
				bool flag2;
				global::Motorola.MackinawCPS.CoreFeatures.RemoteSpeakerMic.RSMButtonInnerSection rsmbuttonInnerSection;
				global::AcpCommonLib.IAcpRecordset feature;
				global::AcpBusinessLayer.AcpListField switchConventionalSwitchesPosition4_A;
				global::AcpCommonLib.IAcpRecordset embeddedRecset2;
				global::Motorola.MackinawCPS.CoreFeatures.RemoteSpeakerMic.RSMButtonInnerRecset rsmbuttonInnerRecset;
				global::AcpBusinessLayer.AcpListField switchTrunkingSwitchesPosition3_A;
				global::AcpBusinessLayer.AcpListField switchConventionalSwitchesPosition1_A;
				global::AcpBusinessLayer.AcpListField switchConventionalSwitchesPosition3_A;
				global::Motorola.MackinawCPS.CoreFeatures.RadioInformation.Labtool labtool;
				global::AcpBusinessLayer.AcpListField switchTrunkingSwitchesPosition1_A;
				global::Motorola.MackinawCPS.CoreFeatures.RadioErgonomicsWide.RadioErgonomicsWide radioErgonomicsWide;
				global::AcpBusinessLayer.AcpListField switchTrunkingSwitchesPosition2_A;
				global::Motorola.MackinawCPS.CoreFeatures.RadioWide.Features features;
				int num12;
				global::AcpBusinessLayer.AcpListField switchConventionalSwitchesPosition2_A;
				global::AcpBusinessLayer.AcpListField emerWideManDownTrigger_A;
				global::AcpBusinessLayer.AcpListField switchTrunkingSwitchesPosition5_A;
				global::AcpBusinessLayer.AcpListField switchTrunkingSwitchesPosition4_A;
				for (;;)
				{
					IL_31:
					num = (short)1429143552;
					short num3 = num;
					int num5;
					bool flag3;
					int num6;
					int num7;
					bool flag4;
					int num9;
					int num10;
					bool flag5;
					int num13;
					switch (num2)
					{
					case 0:
						return flag;
					case 1:
						num = (short)452067400;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 2:
						if (index <= 110)
						{
							num = (short)272171082;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)1512767602;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 3:
						num = (short)157941819;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 4:
					{
						int num4;
						if ((embeddedRecset[num4] as global::Motorola.MackinawCPS.CoreFeatures.SmartKeyFob.SmartKeyFobButtonTableInner).SmartKeyFobButtonTableInnerSection.RadErgoCfgFobConventionalFeature_A41574.Value == 61)
						{
							num = (short)341508256;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num4++;
						num = (short)1062863047;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 5:
						if (switches.ConventionalSwitches.SwitchConventionalSwitchesPosition2_A7735.Value != 61)
						{
							num = (short)940638380;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_2495;
					case 6:
					{
						int num4 = 0;
						num = (short)785449146;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 7:
						flag = false;
						num = (short)982253581;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 8:
						goto IL_1FEF;
					case 9:
						num = (short)1253834757;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 10:
						num = (short)745275547;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 11:
						if (switchConventionalSwitchesPosition5_A.Value != 33)
						{
							num = (short)1487798420;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_147C;
					case 12:
						num = (short)430112799;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 13:
						return flag;
					case 14:
						if (!global::ConstraintHelper.UtilityMack.IsMobile())
						{
							num = (short)1475608778;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return flag;
					case 15:
						if ((portableButtonInnerRecset[num5] as global::Motorola.MackinawCPS.CoreFeatures.Buttons.PortableButtonInner).PortableButtonInnerSection.BtnGeneralConventionalFeature_A19544.Value == 31)
						{
							num = (short)1044250631;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_15C2;
					case 16:
						goto IL_2495;
					case 17:
						if (!global::ConstraintHelper.UtilityMack.IsMobile())
						{
							num = (short)347734054;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return flag;
					case 18:
						num = (short)1038090272;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 19:
						num = (short)1877213325;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 20:
						if (switches.ConventionalSwitches.SwitchConventionalSwitchesPosition5_A21531.Value == 61)
						{
							num = (short)478871568;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return flag;
					case 21:
						if (global::ConstraintHelper.UtilityMack.ProductModelId.Equals(global::AllFeatures.CodeplugGuid.b("鋒藔迖", a_)))
						{
							num = (short)228524170;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						flag = false;
						num = (short)1866006684;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 22:
						if (index - 109 > 1)
						{
							num = (short)17170603;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)214237327;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 23:
						flag2 = true;
						num = (short)1479082094;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 24:
						if (flag)
						{
							num = (short)398983203;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)1650524361;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 25:
						flag = false;
						num = (short)149356601;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 26:
						num5 = 0;
						num = (short)995229760;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 27:
					{
						if (index != 149)
						{
							num = (short)327614662;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						flag = false;
						global::System.Collections.Generic.IEnumerator<global::AcpBusinessLayer.FeatureNode> enumerator = portableButtonInnerRecset.GetEnumerator();
						num = (short)1654653011;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 28:
						flag3 = (switchConventionalSwitchesPosition5_A.Value != 26);
						goto IL_2530;
					case 29:
						return flag;
					case 30:
						num = (short)761921597;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 31:
						return flag;
					case 32:
						return flag;
					case 33:
						if (num6 >= rsmbuttonInnerSection.ParentRecset.Count)
						{
							num = (short)1054867545;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)743637116;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 34:
						if (rsmbuttonInnerSection.RadErgoCfgRSMConventionalBCO_A19639.Value != 151)
						{
							num = (short)761528428;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return flag;
					case 35:
						num = (short)566886499;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 36:
						num = (short)322961471;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 37:
					{
						int num4;
						if (num4 >= embeddedRecset.Count)
						{
							num = (short)537591890;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_13D8;
					}
					case 38:
					{
						global::Motorola.MackinawCPS.CoreFeatures.MenuItems.MenuItems menuItems = feature[0] as global::Motorola.MackinawCPS.CoreFeatures.MenuItems.MenuItems;
						num7 = 0;
						num = (short)653197458;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 39:
						flag4 = false;
						goto IL_1CDD;
					case 40:
						if (switchConventionalSwitchesPosition4_A.Value != 33)
						{
							num = (short)1102774347;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_147C;
					case 41:
						flag = !rsmbuttonInnerSection.RefRadioWide.UserInformationAndPasswords.RadWideUserInformationandPasswordsRadioLock_A8836.Value;
						num = (short)1259208846;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 42:
						goto IL_104E;
					case 43:
						goto IL_E83;
					case 44:
					{
						global::Motorola.MackinawCPS.CoreFeatures.MenuItems.MenuItems menuItems;
						if (menuItems.General.DispMenuConventionalSelectedMenuItems_A21736.Items[num7].ItemName == global::CommonResources.AcgResources.ID_DIR)
						{
							num = (short)1220542647;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_15E5;
					}
					case 45:
						num = (short)1495138454;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 46:
						return flag;
					case 47:
						if (rsmbuttonInnerSection.RadErgoCfgRSMConventionalBCO_A19639.Value != 151)
						{
							num = (short)837681317;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return flag;
					case 48:
						num = (short)1678114845;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 49:
						num = (short)1240662121;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 50:
						goto IL_2369;
					case 51:
						num = (short)989593686;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 52:
					{
						int num8;
						if ((embeddedRecset2[num8] as global::Motorola.MackinawCPS.CoreFeatures.Buttons.PortableButtonInner).PortableButtonInnerSection.BtnGeneralConventionalFeature_A19544.Value == 61)
						{
							num = (short)604045515;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)683802625;
						if (num != 0)
						{
						}
						num8++;
						num = (short)445448295;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 53:
					{
						global::Motorola.MackinawCPS.CoreFeatures.MenuItems.MenuItems menuItems2;
						if (menuItems2.General.DispMenuTrunkingSelectedMenuItems_A21735.Items[num9].ItemName == global::CommonResources.AcgResources.ID_SCAN)
						{
							num = (short)1482489934;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_1DFF;
					}
					case 54:
						if ((rsmbuttonInnerRecset[num10] as global::Motorola.MackinawCPS.CoreFeatures.RemoteSpeakerMic.RSMButtonInner).RSMButtonInnerSection.RadErgoCfgRSMlConventionalFeature_A19640.Value == 31)
						{
							num = (short)1703673905;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_1AC2;
					case 55:
						num = (short)1511391417;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 56:
						if (flag)
						{
							num = (short)694550599;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return flag;
					case 57:
						goto IL_1F71;
					case 58:
						return flag;
					case 59:
					{
						global::Motorola.MackinawCPS.CoreFeatures.RadioWide.RadioWide radioWide;
						if (radioWide.Features.RadWideFeaturesVoiceControlPriority.Value == 0)
						{
							num = (short)448069745;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return flag;
					}
					case 60:
						return flag;
					case 61:
						if (switchTrunkingSwitchesPosition3_A.Value != 33)
						{
							num = (short)2014183479;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_147C;
					case 62:
						goto IL_1FEF;
					case 63:
						if (feature != null)
						{
							num = (short)50790570;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return flag;
					case 64:
						goto IL_E83;
					case 65:
						goto IL_1D1D;
					case 66:
						num = (short)403963932;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 67:
						if (switchConventionalSwitchesPosition1_A.Value == 81)
						{
							num = (short)1603403906;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return flag;
					case 68:
						if (embeddedRecset2 != null)
						{
							num = (short)1796800716;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_A7F;
					case 69:
						if (switchConventionalSwitchesPosition3_A.Value != 33)
						{
							num = (short)1975451829;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_147C;
					case 70:
						num = (short)166723598;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 71:
						goto IL_1867;
					case 72:
						return flag;
					case 73:
						num = (short)1103167667;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 74:
						num = (short)1068433571;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 75:
						num = (short)1122107403;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 76:
						if (feature.Count != 0)
						{
							num = (short)192479421;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return flag;
					case 77:
						if (index != 26)
						{
							num = (short)899285149;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)850788546;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 78:
						flag = false;
						num = (short)956366935;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 79:
						flag3 = false;
						goto IL_2530;
					case 80:
						num = (short)399245332;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 81:
						try
						{
							num = (short)1208221699;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								switch (num2)
								{
								case 0:
									goto IL_1362;
								case 1:
								{
									global::System.Collections.Generic.IEnumerator<global::AcpBusinessLayer.FeatureNode> enumerator;
									if (!enumerator.MoveNext())
									{
										num = (short)1717633026;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									num = (short)1977090052;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 2:
									num = (short)67436544;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 3:
									switch (0)
									{
									case 0:
										goto IL_1297;
									}
									continue;
								case 4:
								{
									global::System.Collections.Generic.IEnumerator<global::AcpBusinessLayer.FeatureNode> enumerator;
									if ((((global::AcpCommonLib.IAcpFeatureNode)enumerator.Current)[10092] as global::Motorola.MackinawCPS.CoreFeatures.Buttons.PortableButtonInnerSection).BtnGeneralConventionalFeature_A19544.Value == 214)
									{
										num = (short)920846341;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									break;
								}
								case 5:
									flag = true;
									num = (short)1075642374;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								IL_12EE:
								num = (short)341770241;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								IL_1297:
								goto IL_12EE;
							}
							IL_1362:
							return flag;
						}
						finally
						{
							num = (short)508821505;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								global::System.Collections.Generic.IEnumerator<global::AcpBusinessLayer.FeatureNode> enumerator;
								switch (num2)
								{
								case 0:
									enumerator.Dispose();
									num = (short)305070082;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 1:
									switch (0)
									{
									case 0:
										goto IL_139B;
									}
									continue;
								case 2:
									goto IL_13D5;
								}
								IL_139B:
								if (enumerator == null)
								{
									break;
								}
								num = (short)866058240;
								num2 = (int)((global::System.IntPtr)num);
							}
							IL_13D5:;
						}
						goto IL_13D8;
					case 82:
						goto IL_1D1D;
					case 83:
						try
						{
							num = (short)1863974915;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								switch (num2)
								{
								case 0:
									goto IL_17F6;
								case 1:
								{
									global::System.Collections.Generic.IEnumerator<global::AcpBusinessLayer.FeatureNode> enumerator;
									if ((((global::AcpCommonLib.IAcpFeatureNode)enumerator.Current)[10092] as global::Motorola.MackinawCPS.CoreFeatures.Buttons.PortableButtonInnerSection).BtnGeneralConventionalFeature_A19544.Value == 149)
									{
										num = (short)1724973058;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									goto IL_1728;
								}
								case 2:
									flag = true;
									num = (short)1370882054;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 3:
									switch (0)
									{
									case 0:
										goto IL_16DC;
									}
									continue;
								case 4:
								{
									global::System.Collections.Generic.IEnumerator<global::AcpBusinessLayer.FeatureNode> enumerator;
									if (!enumerator.MoveNext())
									{
										num = (short)1827012613;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									num = (short)1457782785;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 5:
									goto IL_1761;
								case 6:
									goto IL_1728;
								}
								goto IL_16DC;
								IL_1728:
								num = (short)1273430020;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								IL_16DC:
								num = (short)608268899;
								short num11 = num;
								num = (short)228553315;
								switch ((num11 == num) ? 1 : 0)
								{
								case 0:
								case 2:
									IL_1761:
									num = (short)1050935296;
									num2 = (int)((global::System.IntPtr)num);
									break;
								default:
									num = (short)407896064;
									if (num != 0)
									{
									}
									goto IL_1728;
								}
							}
							IL_17F6:
							return flag;
						}
						finally
						{
							num = (short)1766981633;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								global::System.Collections.Generic.IEnumerator<global::AcpBusinessLayer.FeatureNode> enumerator;
								switch (num2)
								{
								case 0:
									enumerator.Dispose();
									num = (short)227672066;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 1:
									switch (0)
									{
									case 0:
										goto IL_182D;
									}
									continue;
								case 2:
									goto IL_1864;
								}
								IL_182D:
								if (enumerator == null)
								{
									break;
								}
								num = (short)1568931840;
								num2 = (int)((global::System.IntPtr)num);
							}
							IL_1864:;
						}
						goto IL_1867;
					case 84:
						if (rsmbuttonInnerSection.ParentRecset[num6] != self.Parent)
						{
							num = (short)428605633;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_22E0;
					case 85:
						if (switches.ConventionalSwitches.SwitchConventionalSwitchesPosition4_A21530.Value != 61)
						{
							num = (short)363987024;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_2495;
					case 86:
						if (labtool.RadInfoLabtoolBluetooth_A37042.Value)
						{
							num = (short)198377495;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_96E;
					case 87:
						goto IL_1DFF;
					case 88:
						if (index != 81)
						{
							num = (short)603324513;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)1140392003;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 89:
						goto IL_24F4;
					case 90:
						if (switchTrunkingSwitchesPosition1_A.Value != 33)
						{
							num = (short)2039283808;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_147C;
					case 91:
						goto IL_A7F;
					case 92:
						if (radioErgonomicsWide.Advanced.RadErgoWideAdvancedSideButtonsLockEnable_A38725.Value)
						{
							num = (short)98828383;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return flag;
					case 93:
						goto IL_24F4;
					case 94:
						num = (short)1198588086;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 95:
						num = (short)1370947618;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 96:
						num = (short)73465958;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 97:
						num = (short)233242646;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 98:
						num = (short)1616052278;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 99:
						flag5 = (embeddedRecset != null);
						goto IL_1A9D;
					case 100:
						return flag;
					case 101:
					{
						int num8;
						if (num8 >= embeddedRecset2.Count)
						{
							num = (short)1251934299;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)1245839412;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 102:
						if (switchTrunkingSwitchesPosition2_A.Value != 33)
						{
							num = (short)1491337246;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_147C;
					case 103:
						goto IL_10E0;
					case 104:
						if (labtool != null)
						{
							num = (short)347930675;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_96E;
					case 105:
						if (rsmbuttonInnerRecset[num10] as global::Motorola.MackinawCPS.CoreFeatures.RemoteSpeakerMic.RSMButtonInner != self.Parent)
						{
							num = (short)528810009;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_1AC2;
					case 106:
						if (flag)
						{
							num = (short)531300543;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return flag;
					case 107:
						num = (short)704315461;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 108:
						num6 = 0;
						num = (short)1870135407;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 109:
						num = (short)452591789;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 110:
						goto IL_96E;
					case 111:
						goto IL_1C95;
					case 112:
						if (index != 61)
						{
							num = (short)1476395135;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)665714865;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 113:
						flag = false;
						num = (short)500433022;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 114:
						if (index <= 217)
						{
							num = (short)1941307512;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)1951924377;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 115:
					{
						global::Motorola.MackinawCPS.CoreFeatures.RadioWide.RadioWide radioWide;
						if (radioWide != null)
						{
							num = (short)1394606083;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return flag;
					}
					case 116:
						return flag;
					case 117:
						num = (short)449511492;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 118:
						goto IL_878;
					case 119:
						if (index != 33)
						{
							num = (short)1676673025;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)421986438;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 120:
						num = (short)117768219;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 121:
						if (index - 290 > 1)
						{
							num = (short)1300693004;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						flag = features.RadWideFeaturesChannelFallbackEnableValue;
						num = (short)2049441908;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 122:
						if (flag)
						{
							num = (short)1672151235;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return flag;
					case 123:
						goto IL_2369;
					case 124:
						if ((rsmbuttonInnerSection.ParentRecset[num6] as global::Motorola.MackinawCPS.CoreFeatures.RemoteSpeakerMic.RSMButtonInner).RSMButtonInnerSection.RadErgoCfgRSMlConventionalFeature_A19640.Value == 61)
						{
							num = (short)1559298226;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_22E0;
					case 125:
						num = (short)190972078;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 126:
						return flag;
					case 127:
						num = (short)546898008;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 128:
						if ((portableButtonInnerRecset[num5] as global::Motorola.MackinawCPS.CoreFeatures.Buttons.PortableButtonInner).PortableButtonInnerSection.BtnGeneralConventionalBCO_A19543.Value != 148)
						{
							num = (short)1105920135;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_15C2;
					case 129:
						num = (short)1886322837;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 130:
						flag = false;
						num = (short)456654985;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 131:
					{
						global::Motorola.MackinawCPS.CoreFeatures.MenuItems.MenuItems menuItems2;
						if (num9 >= menuItems2.General.DispMenuTrunkingSelectedMenuItems_A21735.Items.Count)
						{
							num = (short)1863254212;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)338362421;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 132:
						goto IL_1F71;
					case 133:
						if (index != 31)
						{
							num = (short)2136604812;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)2122711132;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 134:
						if (switchConventionalSwitchesPosition1_A.Value != 33)
						{
							num = (short)1695613075;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_147C;
					case 135:
						num = (short)586874895;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 136:
					{
						if (index != 214)
						{
							num = (short)96927869;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						flag = false;
						global::System.Collections.Generic.IEnumerator<global::AcpBusinessLayer.FeatureNode> enumerator = portableButtonInnerRecset.GetEnumerator();
						num = (short)1563557969;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 137:
						return flag;
					case 138:
						num10 = 0;
						num = (short)854130850;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 139:
						num = (short)1669857365;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 140:
						num = (short)1443168375;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 141:
						if (switchConventionalSwitchesPosition4_A.Value != 26)
						{
							num = (short)1820852290;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_1B31;
					case 142:
						return flag;
					case 143:
						if (num12 == 1)
						{
							num = (short)1776681001;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return flag;
					case 144:
						goto IL_1C95;
					case 145:
						goto IL_C98;
					case 146:
						goto IL_C98;
					case 147:
						num = (short)1775501512;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 148:
						num = (short)1931477082;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 149:
						if (switchConventionalSwitchesPosition2_A.Value != 26)
						{
							num = (short)1182072842;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_1B31;
					case 150:
						if (index != 289)
						{
							num = (short)1620377766;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						flag = global::Motorola.MackinawCPS.CoreFeatures.Buttons.ButtonsConstraints.ValidityBasedOnTacticalServiceOperation();
						num = (short)1964048384;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 151:
						goto IL_A7F;
					case 152:
						if (flag)
						{
							num = (short)324010020;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return flag;
					case 153:
					{
						if (index != 269)
						{
							num = (short)431685677;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						global::Motorola.MackinawCPS.CoreFeatures.RadioWide.RadioWide radioWide = global::AcpCommonLib.FeatureManager.GetFeature(2045)[0] as global::Motorola.MackinawCPS.CoreFeatures.RadioWide.RadioWide;
						num = (short)1864761459;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 154:
						if (portableButtonInnerRecset != null)
						{
							num = (short)1471741978;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return flag;
					case 155:
						if (switchConventionalSwitchesPosition3_A.Value != 26)
						{
							num = (short)2039676947;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_1B31;
					case 156:
						return flag;
					case 157:
						num = (short)453640325;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 158:
					{
						global::Motorola.MackinawCPS.CoreFeatures.MenuItems.MenuItems menuItems;
						if (num7 >= menuItems.General.DispMenuConventionalSelectedMenuItems_A21736.Items.Count)
						{
							num = (short)1584857136;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)139984940;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 159:
					{
						global::Motorola.MackinawCPS.CoreFeatures.MenuItems.MenuItems menuItems2;
						if (num13 >= menuItems2.General.DispMenuConventionalSelectedMenuItems_A21736.Items.Count)
						{
							num = (short)103874721;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)1810628775;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 160:
						flag = false;
						num = (short)1503854657;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 161:
						num9 = 0;
						num = (short)2058944574;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 162:
						goto IL_104E;
					case 163:
						if (index <= 33)
						{
							num = (short)2065105072;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)2049376368;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 164:
						if (flag)
						{
							num = (short)765657205;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_A7F;
					case 165:
						num = (short)1076297749;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 166:
						num = (short)467861625;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 167:
					{
						global::Motorola.MackinawCPS.CoreFeatures.MenuItems.MenuItems menuItems2;
						if (menuItems2.General.DispMenuConventionalSelectedMenuItems_A21736.Items[num13].ItemName == global::CommonResources.AcgResources.ID_SCAN)
						{
							num = (short)890896574;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_878;
					}
					case 168:
						goto IL_15E5;
					case 169:
						if (switches.ConventionalSwitches.SwitchConventionalSwitchesPosition1_A7734.Value != 61)
						{
							num = (short)1611464713;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_2495;
					case 170:
						num = (short)1888026700;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 171:
						num = (short)536739900;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 172:
						num = (short)1529544892;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 173:
						if (feature.Count != 0)
						{
							num = (short)1897922630;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return flag;
					case 174:
						if (index != 217)
						{
							num = (short)71041042;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						flag = (emerWideManDownTrigger_A.Value != 0);
						num = (short)250740782;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 175:
						if (feature != null)
						{
							num = (short)1606156397;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return flag;
					case 176:
						num = (short)434503757;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 177:
						if (radioErgonomicsWide.Advanced.RadErgoWideAdvancedSideButtonsLockEnable_A38725.Value)
						{
							num = (short)2005729464;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return flag;
					case 178:
						num = (short)402784340;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 179:
						flag4 = (switchTrunkingSwitchesPosition5_A.Value != 33);
						goto IL_1CDD;
					case 180:
						if (num10 >= rsmbuttonInnerRecset.Count)
						{
							num = (short)1903427716;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)635502789;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 181:
						num = (short)675086376;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 182:
						return flag;
					case 183:
						flag = false;
						num = (short)1055850664;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 184:
						num = (short)171769903;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 185:
						if (switchTrunkingSwitchesPosition4_A.Value != 33)
						{
							num = (short)251265097;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_147C;
					case 186:
						goto IL_DE1;
					case 187:
						if (num5 >= portableButtonInnerRecset.Count)
						{
							num = (short)1736441950;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)206372992;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 188:
						if (switches.ConventionalSwitches.SwitchConventionalSwitchesPosition3_A7737.Value != 61)
						{
							num = (short)2055143563;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_2495;
					case 189:
						num = (short)215220241;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 190:
						flag = false;
						num = (short)602341494;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 191:
						num = (short)1424097434;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 192:
						goto IL_10E0;
					case 193:
						flag = false;
						num = (short)1220870237;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 194:
						if (switchConventionalSwitchesPosition1_A.Value != 26)
						{
							num = (short)1536032897;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_1B31;
					case 195:
						num = (short)1654194345;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 196:
						num = (short)86638692;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 197:
						if ((rsmbuttonInnerRecset[num10] as global::Motorola.MackinawCPS.CoreFeatures.RemoteSpeakerMic.RSMButtonInner).RSMButtonInnerSection.RadErgoCfgRSMConventionalBCO_A19639.Value != 151)
						{
							num = (short)545718370;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_1AC2;
					case 198:
						num = (short)1882259592;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 199:
						goto IL_DE1;
					case 200:
						if (switchConventionalSwitchesPosition2_A.Value != 33)
						{
							num = (short)2079195243;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_147C;
					case 201:
						flag5 = false;
						goto IL_1A9D;
					case 202:
					{
						global::Motorola.MackinawCPS.CoreFeatures.MenuItems.MenuItems menuItems2 = feature[0] as global::Motorola.MackinawCPS.CoreFeatures.MenuItems.MenuItems;
						num13 = 0;
						num = (short)1575944315;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 203:
						flag = false;
						num = (short)1100742807;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 204:
					{
						int num8 = 0;
						num = (short)1946812608;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					}
					goto IL_395;
					IL_878:
					num13++;
					num = (short)1511391282;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_96E:
					num = (short)1155334146;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_A7F:
					num = (short)451936280;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_C98:
					num = (short)548536478;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_DE1:
					num = (short)1420230693;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_E83:
					num = (short)2092368059;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_104E:
					num = (short)1503854772;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_10E0:
					num = (short)342687845;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_13D8:
					num = (short)1430585348;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_147C:
					num = (short)624623655;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_15C2:
					num5++;
					num = (short)207552555;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_15E5:
					num7++;
					num = (short)491520145;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_1867:
					num = (short)1530265775;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_1A9D:
					if (flag5 && flag2)
					{
						num = (short)567541766;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_1D1D;
					IL_1AC2:
					num10++;
					num = (short)1098580010;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_1B31:
					num = (short)1160511567;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_1C95:
					num = (short)1462435873;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_1CDD:
					flag = flag4;
					num = (short)1095499832;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_1D1D:
					num = (short)1263796346;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_1DFF:
					num9++;
					num = (short)1970733064;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_1F71:
					num = (short)856031338;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_1FEF:
					num = (short)1767506051;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_22E0:
					num6++;
					num = (short)1629749392;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_2369:
					num = (short)332923039;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_2495:
					flag = false;
					num = (short)1415643194;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_24F4:
					num = (short)421003428;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_2530:
					flag = flag3;
					num = (short)457310360;
					num2 = (int)((global::System.IntPtr)num);
				}
				return flag;
				IL_395:
				rsmbuttonInnerSection = (self as global::Motorola.MackinawCPS.CoreFeatures.RemoteSpeakerMic.RSMButtonInnerSection);
				switchConventionalSwitchesPosition1_A = rsmbuttonInnerSection.RefSwitches.ConventionalSwitches.SwitchConventionalSwitchesPosition1_A7734;
				switchConventionalSwitchesPosition2_A = rsmbuttonInnerSection.RefSwitches.ConventionalSwitches.SwitchConventionalSwitchesPosition2_A7735;
				switchConventionalSwitchesPosition3_A = rsmbuttonInnerSection.RefSwitches.ConventionalSwitches.SwitchConventionalSwitchesPosition3_A7737;
				switchConventionalSwitchesPosition4_A = rsmbuttonInnerSection.RefSwitches.ConventionalSwitches.SwitchConventionalSwitchesPosition4_A21530;
				switchConventionalSwitchesPosition5_A = rsmbuttonInnerSection.RefSwitches.ConventionalSwitches.SwitchConventionalSwitchesPosition5_A21531;
				switchTrunkingSwitchesPosition1_A = rsmbuttonInnerSection.RefSwitches.TrunkingSwitches.SwitchTrunkingSwitchesPosition1_A9466;
				switchTrunkingSwitchesPosition2_A = rsmbuttonInnerSection.RefSwitches.TrunkingSwitches.SwitchTrunkingSwitchesPosition2_A9467;
				switchTrunkingSwitchesPosition3_A = rsmbuttonInnerSection.RefSwitches.TrunkingSwitches.SwitchTrunkingSwitchesPosition3_A9468;
				switchTrunkingSwitchesPosition4_A = rsmbuttonInnerSection.RefSwitches.TrunkingSwitches.SwitchTrunkingSwitchesPosition4_A21534;
				switchTrunkingSwitchesPosition5_A = rsmbuttonInnerSection.RefSwitches.TrunkingSwitches.SwitchTrunkingSwitchesPosition5_A21535;
				portableButtonInnerRecset = ((global::AcpCommonLib.FeatureManager.GetFeature(2042) as global::Motorola.MackinawCPS.CoreFeatures.Buttons.ButtonsRecset)[0][10091].EmbeddedRecset as global::Motorola.MackinawCPS.CoreFeatures.Buttons.PortableButtonInnerRecset);
				rsmbuttonInnerRecset = ((global::AcpCommonLib.FeatureManager.GetFeature(2036) as global::Motorola.MackinawCPS.CoreFeatures.RemoteSpeakerMic.RemoteSpeakerMicRecset)[0][10079].EmbeddedRecset as global::Motorola.MackinawCPS.CoreFeatures.RemoteSpeakerMic.RSMButtonInnerRecset);
				feature = global::AcpCommonLib.FeatureManager.GetFeature(2088);
				global::AcpCommonLib.IAcpFeatureNode parent = rsmbuttonInnerSection.RadErgoCfgRSMlConventionalFeature_A19640.Parent.Parent;
				num12 = (parent.Parent as global::AcpBusinessLayer.Recordset).IndexOf(parent);
				flag = true;
				radioErgonomicsWide = (global::AcpCommonLib.FeatureManager.GetFeature(2033)[0] as global::Motorola.MackinawCPS.CoreFeatures.RadioErgonomicsWide.RadioErgonomicsWide);
				embeddedRecset2 = global::AcpCommonLib.FeatureManager.GetFeature(2042)[0][10091].EmbeddedRecset;
				switches = (global::AcpCommonLib.FeatureManager.GetFeature(2038)[0] as global::Motorola.MackinawCPS.CoreFeatures.Switches.Switches);
				emerWideManDownTrigger_A = ((global::AcpCommonLib.FeatureManager.GetFeature(2032) as global::Motorola.MackinawCPS.CoreFeatures.EmergencyWide.EmergencyWideRecset)[0][10639] as global::Motorola.MackinawCPS.CoreFeatures.EmergencyWide.ManDown).EmerWideManDownTrigger_A40001;
				embeddedRecset = global::AcpCommonLib.FeatureManager.GetFeature(4130)[0][10747].EmbeddedRecset;
				labtool = (global::AcpCommonLib.FeatureManager.GetFeature(2049)[0][10107] as global::Motorola.MackinawCPS.CoreFeatures.RadioInformation.Labtool);
				features = (global::AcpCommonLib.FeatureManager.GetFeature(2045)[0][10105] as global::Motorola.MackinawCPS.CoreFeatures.RadioWide.Features);
				flag2 = false;
				num = (short)2067791976;
				num2 = (int)((global::System.IntPtr)num);
				goto IL_31;
			}
			}
		}

		// Token: 0x060077E4 RID: 30692 RVA: 0x006CACEC File Offset: 0x006C8EEC
		public static bool conSetEditabilityRsmTrkFeature(global::AcpCommonLib.IAcpFeatureSection self)
		{
			switch (0)
			{
			case 0:
				goto IL_90;
			}
			int num;
			short num2;
			global::Motorola.MackinawCPS.CoreFeatures.RemoteSpeakerMic.RSMButtonInnerSection rsmbuttonInnerSection;
			global::AcpCommonLib.IAcpFeatureNode parent;
			for (;;)
			{
				IL_0A:
				switch (num)
				{
				case 0:
					num2 = (short)1941176324;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 1:
					num2 = (short)1554972698;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 2:
					if (rsmbuttonInnerSection.RadErgoCfgRSMlConventionalFeature_A19640.Value != 66)
					{
						num2 = (short)869859328;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					return false;
				case 3:
					if (rsmbuttonInnerSection.RadErgoCfgRSMlConventionalFeature_A19640.Value != 88)
					{
						num2 = (short)240320535;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					return false;
				case 4:
					if (rsmbuttonInnerSection.RadErgoCfgRSMlConventionalFeature_A19640.Value != 67)
					{
						num2 = (short)1848705033;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					return false;
				case 5:
					num2 = (short)622854160;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 6:
					num2 = (short)1798963201;
					if (num2 != 0)
					{
					}
					if (rsmbuttonInnerSection.RadErgoCfgRSMlConventionalFeature_A19640.Value != 65)
					{
						num2 = (short)557711365;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					return false;
				case 7:
					if (rsmbuttonInnerSection.RadErgoCfgRSMlConventionalFeature_A19640.Value != 87)
					{
						num2 = (short)287637518;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					return false;
				case 8:
					if (rsmbuttonInnerSection.RadErgoCfgRSMlConventionalFeature_A19640.Value != 27)
					{
						num2 = (short)1312423948;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					return false;
				case 9:
					num2 = (short)721223702;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 10:
					if (rsmbuttonInnerSection.RadErgoCfgRSMlConventionalFeature_A19640.Value != 149)
					{
						num2 = (short)2142437400;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					return false;
				case 11:
					if (rsmbuttonInnerSection.RadErgoCfgRSMlConventionalFeature_A19640.Value == 235)
					{
						num2 = (short)1491861535;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					return true;
				case 12:
					num2 = (short)1811283975;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 13:
				{
					if ((parent.Parent as global::AcpBusinessLayer.Recordset).IndexOf(parent) == 0)
					{
						num2 = (short)273154076;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					num2 = (short)1178957384;
					short num3 = num2;
					num2 = (short)1029928520;
					switch ((num3 == num2) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_49C;
					default:
						num2 = (short)731774976;
						if (num2 != 0)
						{
						}
						num2 = (short)340656138;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					break;
				}
				case 14:
					num2 = (short)239271939;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 15:
					num2 = (short)1338048523;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 16:
					if (rsmbuttonInnerSection.RadErgoCfgRSMlConventionalFeature_A19640.Value != 210)
					{
						num2 = (short)1501495325;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					return false;
				case 17:
				{
					num2 = (short)2112028672;
					short num4 = num2;
					if (rsmbuttonInnerSection.RadErgoCfgRSMlConventionalFeature_A19640.Value != 209)
					{
						num2 = (short)189267987;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					return false;
				}
				case 18:
					num2 = (short)733544465;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 19:
					num2 = (short)1400700936;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 20:
					num2 = (short)512294918;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 21:
					if (rsmbuttonInnerSection.RadErgoCfgRSMlConventionalFeature_A19640.Value != 236)
					{
						num2 = (short)246022159;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					return false;
				case 22:
					if (rsmbuttonInnerSection.RadErgoCfgRSMlConventionalFeature_A19640.Value != 211)
					{
						num2 = (short)1466957825;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					return false;
				case 23:
					num2 = (short)1196818457;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 24:
					goto IL_49C;
				case 25:
					if (rsmbuttonInnerSection.RadErgoCfgRSMlConventionalFeature_A19640.Value != 64)
					{
						num2 = (short)1222377492;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					return false;
				case 26:
					if (rsmbuttonInnerSection.RadErgoCfgRSMlConventionalFeature_A19640.Value != 212)
					{
						num2 = (short)1015742482;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					return false;
				case 27:
					if (rsmbuttonInnerSection.RadErgoCfgRSMlConventionalFeature_A19640.Value != 214)
					{
						num2 = (short)751435806;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					return false;
				case 28:
					return false;
				case 29:
					num2 = (short)2104492053;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 30:
					num2 = (short)1477050370;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 31:
					return false;
				}
				goto IL_90;
				IL_49C:
				num2 = (short)1377173531;
				num = (int)((global::System.IntPtr)num2);
			}
			return false;
			IL_90:
			rsmbuttonInnerSection = (self as global::Motorola.MackinawCPS.CoreFeatures.RemoteSpeakerMic.RSMButtonInnerSection);
			parent = rsmbuttonInnerSection.RadErgoCfgRSMlTrunkingFeature_A19742.Parent.Parent;
			num2 = (short)1644298253;
			num = (int)((global::System.IntPtr)num2);
			goto IL_0A;
		}

		// Token: 0x060077E5 RID: 30693 RVA: 0x006CB2B8 File Offset: 0x006C94B8
		internal static void conSetRSMTrkFeature(global::AcpCommonLib.IAcpFeatureSection self, global::AcpCommonLib.UndoRedo.ContainerTask task)
		{
			switch (0)
			{
			case 0:
				goto IL_104;
			}
			int num;
			global::AcpBusinessLayer.AcpListField radErgoCfgRSMlConventionalFeature_A;
			short num2;
			global::AcpBusinessLayer.AcpListField radErgoCfgRSMlTrunkingFeature_A;
			for (;;)
			{
				IL_0A:
				switch (num)
				{
				case 0:
					if (radErgoCfgRSMlConventionalFeature_A.Value == 149)
					{
						num2 = (short)1689255970;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					num2 = (short)318963751;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 1:
					goto IL_715;
				case 2:
					if (radErgoCfgRSMlConventionalFeature_A.Value == 88)
					{
						num2 = (short)2145910812;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					num2 = (short)1373962282;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 3:
					num2 = (short)1997537310;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 4:
					goto IL_7AC;
				case 5:
					if (radErgoCfgRSMlTrunkingFeature_A.Value != 27)
					{
						num2 = (short)479526955;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_3FA;
				case 6:
					goto IL_8C2;
				case 7:
					if (radErgoCfgRSMlTrunkingFeature_A.Value != 65)
					{
						num2 = (short)1836711962;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_3FA;
				case 8:
					if (radErgoCfgRSMlConventionalFeature_A.Value == 65)
					{
						num2 = (short)1829240836;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					num2 = (short)429588492;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 9:
					goto IL_5DF;
				case 10:
					goto IL_41F;
				case 11:
					goto IL_244;
				case 12:
					if (radErgoCfgRSMlConventionalFeature_A.Value == 87)
					{
						num2 = (short)1943470117;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					num2 = (short)1516044290;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 13:
					if (radErgoCfgRSMlConventionalFeature_A.Value == 235)
					{
						num2 = (short)995491893;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					num2 = (short)1327759404;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 14:
					if (radErgoCfgRSMlConventionalFeature_A.Value == 210)
					{
						num2 = (short)84934672;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					num2 = (short)165281844;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 15:
					num2 = (short)2142961709;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 16:
					goto IL_663;
				case 17:
					num2 = (short)321519652;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 18:
					goto IL_6A7;
				case 19:
					if (radErgoCfgRSMlConventionalFeature_A.Value == 66)
					{
						num2 = (short)22740998;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					num2 = (short)1943339032;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 20:
					if (radErgoCfgRSMlConventionalFeature_A.Value == 209)
					{
						num2 = (short)202113033;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					num2 = (short)860880910;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 21:
					num2 = (short)295436289;
					if (num2 != 0)
					{
					}
					if (radErgoCfgRSMlConventionalFeature_A.Value == 211)
					{
						num2 = (short)509739009;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					num2 = (short)1405354038;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 22:
					if (radErgoCfgRSMlTrunkingFeature_A.Value != 214)
					{
						num2 = (short)1350762525;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_3FA;
				case 23:
					if (radErgoCfgRSMlTrunkingFeature_A.Value != 211)
					{
						num2 = (short)1308557329;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_3FA;
				case 24:
					if (radErgoCfgRSMlConventionalFeature_A.Value == 67)
					{
						num2 = (short)337182758;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					num2 = (short)533594133;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 25:
					num2 = (short)465764412;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 26:
					num2 = (short)381812771;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 27:
				{
					num2 = (short)1359658820;
					short num3 = num2;
					num2 = (short)1790820164;
					switch ((num3 == num2) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_886;
					default:
						num2 = (short)89784320;
						if (num2 != 0)
						{
						}
						num2 = (short)1966129;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					break;
				}
				case 28:
					goto IL_9C6;
				case 29:
					num2 = (short)851312673;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 30:
					if (radErgoCfgRSMlTrunkingFeature_A.Value != 209)
					{
						num2 = (short)2086010905;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_3FA;
				case 31:
					goto IL_76B;
				case 32:
					if (radErgoCfgRSMlTrunkingFeature_A.Value != 64)
					{
						num2 = (short)1053229106;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_3FA;
				case 33:
					if (radErgoCfgRSMlTrunkingFeature_A.Value != 66)
					{
						num2 = (short)846528569;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_3FA;
				case 34:
					goto IL_157;
				case 35:
					if (radErgoCfgRSMlTrunkingFeature_A.Value != 87)
					{
						num2 = (short)561774632;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_3FA;
				case 36:
					if (radErgoCfgRSMlTrunkingFeature_A.Value != 212)
					{
						num2 = (short)770703363;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_3FA;
				case 37:
					goto IL_1D9;
				case 38:
					goto IL_313;
				case 39:
					if (radErgoCfgRSMlConventionalFeature_A.Value == 214)
					{
						num2 = (short)1166082079;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_886;
				case 40:
					num2 = (short)1709899835;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 41:
					goto IL_57D;
				case 42:
					if (radErgoCfgRSMlTrunkingFeature_A.Value != 149)
					{
						num2 = (short)643891246;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_3FA;
				case 43:
					num2 = (short)1501364256;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 44:
					if (radErgoCfgRSMlConventionalFeature_A.Value == 27)
					{
						num2 = (short)271646761;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					num2 = (short)582484026;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 45:
					if (radErgoCfgRSMlTrunkingFeature_A.Value != 235)
					{
						num2 = (short)1042415663;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_3FA;
				case 46:
					num2 = (short)1844445206;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 47:
					num2 = (short)527237125;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 48:
					goto IL_840;
				case 49:
					if (radErgoCfgRSMlTrunkingFeature_A.Value != 236)
					{
						num2 = (short)1657798671;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_3FA;
				case 50:
					num2 = (short)555352071;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 51:
					num2 = (short)1805844503;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 52:
					if (radErgoCfgRSMlConventionalFeature_A.Value == 236)
					{
						num2 = (short)280428562;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					num2 = (short)1666908173;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 53:
					goto IL_53C;
				case 54:
				{
					num2 = (short)1315045376;
					short num4 = num2;
					if (radErgoCfgRSMlConventionalFeature_A.Value == 212)
					{
						num2 = (short)694353931;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					num2 = (short)1324417044;
					num = (int)((global::System.IntPtr)num2);
					continue;
				}
				case 55:
					if (radErgoCfgRSMlTrunkingFeature_A.Value != 67)
					{
						num2 = (short)1532559411;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_3FA;
				case 56:
					goto IL_3FA;
				case 57:
					num2 = (short)227409975;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 58:
					if (radErgoCfgRSMlConventionalFeature_A.Value == 64)
					{
						num2 = (short)931659824;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					num2 = (short)2114453512;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 59:
					if (radErgoCfgRSMlTrunkingFeature_A.Value == 88)
					{
						num2 = (short)447807544;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					return;
				case 60:
					if (radErgoCfgRSMlTrunkingFeature_A.Value != 210)
					{
						num2 = (short)1564147739;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_3FA;
				}
				goto IL_104;
				IL_3FA:
				task.AddTask(new global::AcpBusinessLayer.UndoRedo.ModifyDataTask<int>(radErgoCfgRSMlTrunkingFeature_A, 35));
				num2 = (short)57933834;
				num = (int)((global::System.IntPtr)num2);
				continue;
				IL_886:
				num2 = (short)391446547;
				num = (int)((global::System.IntPtr)num2);
			}
			IL_157:
			task.AddTask(new global::AcpBusinessLayer.UndoRedo.ModifyDataTask<int>(radErgoCfgRSMlTrunkingFeature_A, 149));
			return;
			IL_1D9:
			task.AddTask(new global::AcpBusinessLayer.UndoRedo.ModifyDataTask<int>(radErgoCfgRSMlTrunkingFeature_A, 87));
			return;
			IL_244:
			task.AddTask(new global::AcpBusinessLayer.UndoRedo.ModifyDataTask<int>(radErgoCfgRSMlTrunkingFeature_A, 212));
			return;
			IL_313:
			task.AddTask(new global::AcpBusinessLayer.UndoRedo.ModifyDataTask<int>(radErgoCfgRSMlTrunkingFeature_A, 67));
			return;
			IL_41F:
			return;
			IL_53C:
			task.AddTask(new global::AcpBusinessLayer.UndoRedo.ModifyDataTask<int>(radErgoCfgRSMlTrunkingFeature_A, 235));
			return;
			IL_57D:
			task.AddTask(new global::AcpBusinessLayer.UndoRedo.ModifyDataTask<int>(radErgoCfgRSMlTrunkingFeature_A, 27));
			return;
			IL_5DF:
			task.AddTask(new global::AcpBusinessLayer.UndoRedo.ModifyDataTask<int>(radErgoCfgRSMlTrunkingFeature_A, 209));
			return;
			IL_663:
			task.AddTask(new global::AcpBusinessLayer.UndoRedo.ModifyDataTask<int>(radErgoCfgRSMlTrunkingFeature_A, 210));
			return;
			IL_6A7:
			task.AddTask(new global::AcpBusinessLayer.UndoRedo.ModifyDataTask<int>(radErgoCfgRSMlTrunkingFeature_A, 236));
			return;
			IL_715:
			task.AddTask(new global::AcpBusinessLayer.UndoRedo.ModifyDataTask<int>(radErgoCfgRSMlTrunkingFeature_A, 211));
			return;
			IL_76B:
			task.AddTask(new global::AcpBusinessLayer.UndoRedo.ModifyDataTask<int>(radErgoCfgRSMlTrunkingFeature_A, 214));
			return;
			IL_7AC:
			task.AddTask(new global::AcpBusinessLayer.UndoRedo.ModifyDataTask<int>(radErgoCfgRSMlTrunkingFeature_A, 65));
			return;
			IL_840:
			task.AddTask(new global::AcpBusinessLayer.UndoRedo.ModifyDataTask<int>(radErgoCfgRSMlTrunkingFeature_A, 64));
			return;
			IL_8C2:
			task.AddTask(new global::AcpBusinessLayer.UndoRedo.ModifyDataTask<int>(radErgoCfgRSMlTrunkingFeature_A, 66));
			return;
			IL_9C6:
			task.AddTask(new global::AcpBusinessLayer.UndoRedo.ModifyDataTask<int>(radErgoCfgRSMlTrunkingFeature_A, 88));
			return;
			IL_104:
			global::Motorola.MackinawCPS.CoreFeatures.RemoteSpeakerMic.RSMButtonInnerSection rsmbuttonInnerSection = self as global::Motorola.MackinawCPS.CoreFeatures.RemoteSpeakerMic.RSMButtonInnerSection;
			radErgoCfgRSMlConventionalFeature_A = rsmbuttonInnerSection.RadErgoCfgRSMlConventionalFeature_A19640;
			radErgoCfgRSMlTrunkingFeature_A = rsmbuttonInnerSection.RadErgoCfgRSMlTrunkingFeature_A19742;
			num2 = (short)1652424704;
			num = (int)((global::System.IntPtr)num2);
			goto IL_0A;
		}

		// Token: 0x060077E6 RID: 30694 RVA: 0x006CBD58 File Offset: 0x006C9F58
		internal static bool conRSMTrunkingTriggerProButTableFeature(global::AcpCommonLib.IAcpFeatureSection self)
		{
			short num = (short)1332180063;
			short num2 = num;
			num = (short)1699116127;
			switch (num2 == num)
			{
			}
			num = (short)864944128;
			if (num != 0)
			{
			}
			num = (short)1572077569;
			if (num != 0)
			{
			}
			num = (short)173801472;
			short num3 = num;
			global::AcpCommonLib.FeatureManager.GetFeature(2042)[0][10091].EmbeddedRecset.CalculateValidity();
			global::AcpCommonLib.FeatureManager.GetFeature(4130)[0][10747].EmbeddedRecset.CalculateValidity();
			return true;
		}

		// Token: 0x060077E7 RID: 30695 RVA: 0x006CBE4C File Offset: 0x006CA04C
		internal static bool conRSMConventionalTriggerProButTableFeature(global::AcpCommonLib.IAcpFeatureSection self)
		{
			short num = (short)941712209;
			short num2 = num;
			num = (short)332292945;
			switch (num2 == num)
			{
			}
			num = (short)1996357633;
			if (num != 0)
			{
			}
			num = (short)1209794560;
			if (num != 0)
			{
			}
			num = (short)1402732544;
			short num3 = num;
			global::AcpCommonLib.FeatureManager.GetFeature(2042)[0][10091].EmbeddedRecset.CalculateValidity();
			global::AcpCommonLib.FeatureManager.GetFeature(4130)[0][10747].EmbeddedRecset.CalculateValidity();
			return true;
		}

		// Token: 0x060077E8 RID: 30696 RVA: 0x006CBF40 File Offset: 0x006CA140
		internal static bool conRadErgoCfgRSMlTopButtonLongPressTimeIsValid(global::AcpCommonLib.IAcpFeatureSection self)
		{
			switch (0)
			{
			case 0:
				goto IL_78;
			}
			int num;
			short num2;
			string uivalue;
			global::Motorola.MackinawCPS.CoreFeatures.RemoteSpeakerMic.RSMButtonInnerSection rsmbuttonInnerSection;
			string uivalue2;
			for (;;)
			{
				IL_0A:
				switch (num)
				{
				case 0:
					num2 = (short)973930499;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 1:
					if (uivalue == global::CommonResources.AcgResources.ID_RADIOWIDE)
					{
						num2 = (short)1348272130;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_1F7;
				case 2:
					goto IL_D5;
				case 3:
					if (rsmbuttonInnerSection.RadErgoCfgRSMlTrunkingFeature_A19742.Value != 31)
					{
						num2 = (short)2041708568;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_23F;
				case 4:
					num2 = (short)324927508;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 5:
					num2 = (short)1289682963;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 6:
					return false;
				case 7:
					num2 = (short)837550103;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 8:
					if (rsmbuttonInnerSection.RadErgoCfgRSMlConventionalFeature_A19640.Value != 31)
					{
						num2 = (short)1645674496;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_23F;
				case 9:
					return true;
				case 10:
					if (rsmbuttonInnerSection.RadErgoCfgRSMlConventionalFeature_A19640.Value != 268)
					{
						num2 = (short)2090205196;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_23F;
				case 11:
					if (uivalue != global::CommonResources.AcgResources.ID_RADIOWIDE)
					{
						num2 = (short)1692860430;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					return true;
				case 12:
					num2 = (short)404684825;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 13:
					if (rsmbuttonInnerSection.RadErgoCfgRSMlConventionalFeature_A19640.Value != 269)
					{
						num2 = (short)400228357;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_23F;
				case 14:
					return false;
				case 15:
					return false;
				case 16:
					num2 = (short)1452998666;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 17:
					num2 = (short)1051131926;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 18:
					if (uivalue2 == global::CommonResources.AcgResources.ID_RADIOWIDE)
					{
						num2 = (short)1060241417;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_1F7;
				case 19:
					if (rsmbuttonInnerSection.RadErgoCfgRSMlTrunkingFeature_A19742.Value != 269)
					{
						num2 = (short)121045008;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_23F;
				case 20:
					if (uivalue != global::CommonResources.AcgResources.ID_RADIOWIDE)
					{
						num2 = (short)2054488071;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_283;
				case 21:
				{
					num2 = (short)115605504;
					short num3 = num2;
					if (uivalue == global::CommonResources.AcgResources.ID_RADIOWIDE)
					{
						num2 = (short)1928986630;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					return true;
				}
				case 22:
					if (global::System.Convert.ToInt32(uivalue) <= global::System.Convert.ToInt32(uivalue2))
					{
						num2 = (short)1350893583;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					return true;
				case 23:
					if (uivalue2 != global::CommonResources.AcgResources.ID_RADIOWIDE)
					{
						num2 = (short)318111761;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_283;
				case 24:
				{
					num2 = (short)234943188;
					short num4 = num2;
					num2 = (short)973271764;
					switch ((num4 == num2) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_D5;
					default:
						num2 = (short)1748434944;
						if (num2 != 0)
						{
						}
						num2 = (short)650051597;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					break;
				}
				case 25:
					if (rsmbuttonInnerSection.RadErgoCfgRSMlTrunkingFeature_A19742.Value != 268)
					{
						num2 = (short)185991172;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_23F;
				}
				goto IL_78;
				IL_D5:
				num2 = (short)593559570;
				num = (int)((global::System.IntPtr)num2);
				continue;
				IL_1F7:
				num2 = (short)1952907272;
				num = (int)((global::System.IntPtr)num2);
				continue;
				IL_23F:
				num2 = (short)200605707;
				num = (int)((global::System.IntPtr)num2);
				continue;
				IL_283:
				num2 = (short)1798897665;
				if (num2 != 0)
				{
				}
				num2 = (short)786366485;
				num = (int)((global::System.IntPtr)num2);
			}
			return false;
			IL_78:
			rsmbuttonInnerSection = (self as global::Motorola.MackinawCPS.CoreFeatures.RemoteSpeakerMic.RSMButtonInnerSection);
			uivalue = rsmbuttonInnerSection.RadErgoCfgRSMlTopButtonLongPressTime.UIValue;
			uivalue2 = rsmbuttonInnerSection.RadErgoCfgRSMlTopButtonShortPressTime.UIValue;
			num2 = (short)1861812225;
			num = (int)((global::System.IntPtr)num2);
			goto IL_0A;
		}

		// Token: 0x060077E9 RID: 30697 RVA: 0x006CC414 File Offset: 0x006CA614
		public static bool conRadErgoCfgRSMlTopButtonShortPressTimeIsValid(global::AcpCommonLib.IAcpFeatureSection self)
		{
			short num = (short)1436549120;
			short num2 = num;
			switch (0)
			{
			case 0:
				goto IL_89;
			}
			int num3;
			global::Motorola.MackinawCPS.CoreFeatures.RemoteSpeakerMic.RSMButtonInnerSection rsmbuttonInnerSection;
			for (;;)
			{
				IL_33:
				switch (num3)
				{
				case 0:
				{
					string uivalue;
					if (uivalue != global::CommonResources.AcgResources.ID_RADIOWIDE)
					{
						num = (short)1947336706;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					}
					return true;
				}
				case 1:
				{
					string uivalue2 = rsmbuttonInnerSection.RadErgoCfgRSMlTopButtonLongPressTime.UIValue;
					string uivalue = rsmbuttonInnerSection.RadErgoCfgRSMlTopButtonShortPressTime.UIValue;
					if (uivalue2 == global::CommonResources.AcgResources.ID_RADIOWIDE)
					{
						num = (short)658112526;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_171;
				}
				case 2:
					goto IL_1F2;
				case 3:
					num = (short)721420306;
					num3 = (int)((global::System.IntPtr)num);
					continue;
				case 4:
					return true;
				case 5:
					num = (short)1342570508;
					num3 = (int)((global::System.IntPtr)num);
					continue;
				case 6:
				{
					string uivalue;
					if (uivalue == global::CommonResources.AcgResources.ID_RADIOWIDE)
					{
						num = (short)542900241;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					}
					return true;
				}
				case 7:
				{
					string uivalue;
					if (uivalue == global::CommonResources.AcgResources.ID_RADIOWIDE)
					{
						num = (short)1113718788;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_171;
				}
				case 8:
					num = (short)907018256;
					num3 = (int)((global::System.IntPtr)num);
					continue;
				case 9:
					if (rsmbuttonInnerSection.RadErgoCfgRSMlTrunkingFeature_A19742.Value != 269)
					{
						num = (short)1180303363;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_1B3;
				case 10:
					num = (short)1429012489;
					num3 = (int)((global::System.IntPtr)num);
					continue;
				case 11:
					num = (short)1250230287;
					num3 = (int)((global::System.IntPtr)num);
					continue;
				case 12:
				{
					num = (short)403798693;
					short num4 = num;
					num = (short)930839205;
					switch ((num4 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_234;
					default:
						num = (short)2013855744;
						if (num != 0)
						{
						}
						if (rsmbuttonInnerSection.RadErgoCfgRSMlConventionalFeature_A19640.Value != 269)
						{
							num = (short)646250506;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_1B3;
					}
					break;
				}
				case 13:
					num = (short)1897594886;
					num3 = (int)((global::System.IntPtr)num);
					continue;
				case 14:
					num = (short)317128711;
					num3 = (int)((global::System.IntPtr)num);
					continue;
				case 15:
					goto IL_234;
				case 16:
					if (rsmbuttonInnerSection.RadErgoCfgRSMlTrunkingFeature_A19742.Value != 31)
					{
						num = (short)2082996229;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_1B3;
				case 17:
					return false;
				case 18:
					if (rsmbuttonInnerSection.RadErgoCfgRSMlConventionalFeature_A19640.Value != 268)
					{
						num = (short)696123403;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_1B3;
				case 19:
					if (rsmbuttonInnerSection.RadErgoCfgRSMlConventionalFeature_A19640.Value != 31)
					{
						num = (short)1760100360;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_1B3;
				}
				goto IL_89;
				IL_171:
				num = (short)2133327891;
				num3 = (int)((global::System.IntPtr)num);
				continue;
				IL_1B3:
				num = (short)2039152640;
				num3 = (int)((global::System.IntPtr)num);
				continue;
				IL_234:
				if (rsmbuttonInnerSection.RadErgoCfgRSMlTrunkingFeature_A19742.Value == 268)
				{
					goto IL_1B3;
				}
				num = (short)1663107085;
				num3 = (int)((global::System.IntPtr)num);
			}
			return false;
			IL_1F2:
			num = (short)1158610945;
			if (num != 0)
			{
			}
			return false;
			IL_89:
			rsmbuttonInnerSection = (self as global::Motorola.MackinawCPS.CoreFeatures.RemoteSpeakerMic.RSMButtonInnerSection);
			num = (short)76087297;
			num3 = (int)((global::System.IntPtr)num);
			goto IL_33;
		}

		// Token: 0x060077EA RID: 30698 RVA: 0x006CC7F4 File Offset: 0x006CA9F4
		internal static bool conRadErgoCfgRSMlTopButtonShortPressandLongPressTimeApplicable(global::AcpCommonLib.IAcpFeatureSection self)
		{
			short num = (short)856555520;
			int num2 = (int)num;
			switch (num2)
			{
			default:
			{
				switch (0)
				{
				case 0:
					goto IL_3E;
				}
				global::AcpBusinessLayer.AcpListField radErgoCfgRSMlConventionalFeature_A;
				for (;;)
				{
					IL_27:
					switch (num2)
					{
					case 0:
						goto IL_13D;
					case 1:
						goto IL_118;
					case 2:
						num = (short)1554448385;
						if (num != 0)
						{
						}
						if (radErgoCfgRSMlConventionalFeature_A.Value == 31)
						{
							goto IL_99;
						}
						num = (short)1880424448;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 3:
					{
						num = (short)1240122801;
						short num3 = num;
						num = (short)172606897;
						switch ((num3 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_99;
						default:
							num = (short)1886584832;
							if (num != 0)
							{
							}
							num = (short)729284609;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						break;
					}
					}
					goto IL_3E;
					IL_99:
					num = (short)1734541315;
					num2 = (int)((global::System.IntPtr)num);
				}
				IL_118:
				global::AcpBusinessLayer.AcpListField radErgoCfgRSMlTrunkingFeature_A;
				bool flag = radErgoCfgRSMlTrunkingFeature_A.Value == 31;
				goto IL_16B;
				IL_13D:
				num = (short)1669136384;
				short num4 = num;
				flag = false;
				IL_16B:
				bool flag2 = radErgoCfgRSMlConventionalFeature_A.Value == 269 && radErgoCfgRSMlTrunkingFeature_A.Value == 269;
				bool flag3 = radErgoCfgRSMlConventionalFeature_A.Value == 268 && radErgoCfgRSMlTrunkingFeature_A.Value == 268;
				return !flag && !flag2 && !flag3;
				IL_3E:
				global::Motorola.MackinawCPS.CoreFeatures.RemoteSpeakerMic.RSMButtonInnerSection rsmbuttonInnerSection = self as global::Motorola.MackinawCPS.CoreFeatures.RemoteSpeakerMic.RSMButtonInnerSection;
				radErgoCfgRSMlConventionalFeature_A = rsmbuttonInnerSection.RadErgoCfgRSMlConventionalFeature_A19640;
				radErgoCfgRSMlTrunkingFeature_A = rsmbuttonInnerSection.RadErgoCfgRSMlTrunkingFeature_A19742;
				num = (short)2051342338;
				num2 = (int)((global::System.IntPtr)num);
				goto IL_27;
			}
			}
		}
	}
}
