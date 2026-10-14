using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using AcpBusinessLayer;
using AcpBusinessLayer.UndoRedo;
using AcpCommonLib;
using AcpCommonLib.UndoRedo;
using AllFeatures;
using CommonResources;
using ConstraintHelper;
using Motorola.MackinawCPS.CoreFeatures.Buttons;
using Motorola.MackinawCPS.CoreFeatures.ControlHeadO2;
using Motorola.MackinawCPS.CoreFeatures.ControlHeadO7;
using Motorola.MackinawCPS.CoreFeatures.MenuItems;
using Motorola.MackinawCPS.CoreFeatures.RemoteSpeakerMic;
using Motorola.MackinawCPS.CoreFeatures.SmartKeyFob;

namespace Motorola.MackinawCPS.CoreFeatures.Switches
{
	// Token: 0x02000293 RID: 659
	public static class SwitchesConstraints
	{
		// Token: 0x060073A5 RID: 29605 RVA: 0x0066AA60 File Offset: 0x00668C60
		internal static bool ConSwitchesCnvPos1(global::AcpCommonLib.IAcpFeatureSection self, int index)
		{
			short num = (short)67698688;
			int num2 = (int)num;
			switch (num2)
			{
			default:
			{
				switch (0)
				{
				case 0:
					goto IL_26E;
				}
				bool flag2;
				int num4;
				global::AcpBusinessLayer.AcpListField switchConventionalSwitchesPosition4_A;
				global::AcpBusinessLayer.AcpListField switchConventionalSwitchesPosition3_A;
				global::Motorola.MackinawCPS.CoreFeatures.SmartKeyFob.SmartKeyFobButtonTableInnerRecset smartKeyFobButtonTableInnerRecset;
				global::AcpBusinessLayer.AcpListField switchConventionalSwitchesPosition2_A;
				global::AcpBusinessLayer.AcpListField switchConventionalSwitchesPosition5_A;
				global::Motorola.MackinawCPS.CoreFeatures.Buttons.PortableButtonInnerRecset portableButtonInnerRecset;
				global::Motorola.MackinawCPS.CoreFeatures.RemoteSpeakerMic.RSMButtonInnerRecset rsmbuttonInnerRecset;
				global::Motorola.MackinawCPS.CoreFeatures.Switches.ConventionalSwitches conventionalSwitches;
				global::Motorola.MackinawCPS.CoreFeatures.Switches.RotaryControlInnerRecset rotaryControlInnerRecset;
				global::AcpBusinessLayer.AcpField<bool> radWideFeaturesNFPACompliant;
				for (;;)
				{
					IL_27:
					bool flag;
					int num3;
					global::System.Collections.Generic.IEnumerator<global::AcpBusinessLayer.FeatureNode> enumerator;
					int num5;
					bool flag3;
					int num6;
					int num7;
					int num8;
					bool flag4;
					bool flag5;
					int num10;
					switch (num2)
					{
					case 0:
						flag = false;
						goto IL_25CE;
					case 1:
						num = (short)1637941262;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 2:
						if (!global::ConstraintHelper.UtilityMack.IsMobile())
						{
							num = (short)1650851982;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_1EDC;
					case 3:
					{
						global::Motorola.MackinawCPS.CoreFeatures.MenuItems.MenuItems menuItems;
						if (num3 >= menuItems.General.DispMenuConventionalSelectedMenuItems_A21736.Items.Count)
						{
							num = (short)623444085;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)448004163;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 4:
					{
						global::AcpCommonLib.IAcpRecordset feature;
						if (feature != null)
						{
							num = (short)739246188;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return flag2;
					}
					case 5:
						goto IL_1BE2;
					case 6:
						num = (short)1823801392;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 7:
						num = (short)1698365512;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 8:
					{
						global::AcpCommonLib.IAcpRecordset feature2;
						global::Motorola.MackinawCPS.CoreFeatures.MenuItems.MenuItems menuItems = feature2[0] as global::Motorola.MackinawCPS.CoreFeatures.MenuItems.MenuItems;
						num3 = 0;
						num = (short)1156907020;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 9:
						if (num4 != 29)
						{
							num = (short)692715585;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)1392967680;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 10:
					{
						global::AcpCommonLib.IAcpRecordset feature2;
						if (feature2.Count != 0)
						{
							num = (short)1248133248;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return flag2;
					}
					case 11:
						goto IL_280B;
					case 12:
						goto IL_1138;
					case 13:
						num = (short)1017249922;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 14:
						if (switchConventionalSwitchesPosition4_A.Value != 26)
						{
							num = (short)1416888442;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_248B;
					case 15:
						num = (short)1213923404;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 16:
						if (switchConventionalSwitchesPosition3_A.Value != 26)
						{
							num = (short)866779137;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_248B;
					case 17:
						goto IL_203C;
					case 18:
						flag = (switchConventionalSwitchesPosition3_A.Value != 29);
						goto IL_25CE;
					case 19:
						if (flag2)
						{
							num = (short)1773469781;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_2508;
					case 20:
						enumerator = smartKeyFobButtonTableInnerRecset.GetEnumerator();
						num = (short)1588658288;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 21:
						if (!global::ConstraintHelper.UtilityMack.IsMobile())
						{
							num = (short)1896415260;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return flag2;
					case 22:
						if (flag2)
						{
							num = (short)1332674599;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return flag2;
					case 23:
						goto IL_49E;
					case 24:
						if (index != 274)
						{
							num = (short)843579456;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_BCF;
					case 25:
						goto IL_11EC;
					case 26:
						goto IL_14C9;
					case 27:
						if (index != 61)
						{
							num = (short)815333494;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)730923137;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 28:
						num5 = 0;
						num = (short)1317142545;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 29:
						return flag2;
					case 30:
						return flag2;
					case 31:
						try
						{
							num = (short)1602158596;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								switch (num2)
								{
								case 0:
								{
									if (!enumerator.MoveNext())
									{
										num = (short)731512835;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									global::AcpCommonLib.IAcpFeatureNode acpFeatureNode = enumerator.Current;
									num = (short)1173225480;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 1:
									num = (short)1707081734;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 2:
									goto IL_2147;
								case 3:
									num = (short)131268615;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 4:
									switch (0)
									{
									case 0:
										goto IL_212A;
									}
									continue;
								case 5:
									flag2 = false;
									num = (short)1953497090;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 6:
								{
									global::AcpCommonLib.IAcpFeatureNode acpFeatureNode;
									if ((acpFeatureNode[10080] as global::Motorola.MackinawCPS.CoreFeatures.RemoteSpeakerMic.RSMButtonInnerSection).RadErgoCfgRSMlConventionalFeature_A19640.Value == 31)
									{
										num = (short)987889669;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									break;
								}
								case 7:
									goto IL_2255;
								case 8:
								{
									global::AcpCommonLib.IAcpFeatureNode acpFeatureNode;
									if ((acpFeatureNode[10080] as global::Motorola.MackinawCPS.CoreFeatures.RemoteSpeakerMic.RSMButtonInnerSection).RadErgoCfgRSMConventionalBCO_A19639.Value != 151)
									{
										num = (short)228261889;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									break;
								}
								}
								IL_21FE:
								num = (short)2144927744;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								IL_212A:
								goto IL_21FE;
							}
							IL_2147:
							IL_2255:
							goto IL_27CB;
						}
						finally
						{
							num = (short)1620836352;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								switch (num2)
								{
								case 0:
									switch (0)
									{
									case 0:
										goto IL_228D;
									}
									continue;
								case 1:
									goto IL_22C4;
								case 2:
									enumerator.Dispose();
									num = (short)1081409537;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								IL_228D:
								if (enumerator == null)
								{
									break;
								}
								num = (short)1567752194;
								num2 = (int)((global::System.IntPtr)num);
							}
							IL_22C4:;
						}
						goto IL_22C7;
					case 32:
						return flag2;
					case 33:
						if (flag2)
						{
							num = (short)700121203;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_118D;
					case 34:
						flag3 = false;
						goto IL_1896;
					case 35:
						flag2 = false;
						num = (short)1958543412;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 36:
						if (num4 != 30)
						{
							num = (short)152961149;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)1006043229;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 37:
						try
						{
							num = (short)9895938;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								switch (num2)
								{
								case 0:
									flag2 = false;
									num = (short)1017053189;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 1:
									num = (short)442761222;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 2:
									switch (0)
									{
									case 0:
										goto IL_2327;
									}
									continue;
								case 3:
									if (!enumerator.MoveNext())
									{
										num = (short)86507521;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									num = (short)865730564;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 4:
								{
									global::AcpBusinessLayer.FeatureNode featureNode = enumerator.Current;
									if ((((global::AcpCommonLib.IAcpFeatureNode)featureNode)[10080] as global::Motorola.MackinawCPS.CoreFeatures.RemoteSpeakerMic.RSMButtonInnerSection).RadErgoCfgRSMlConventionalFeature_A19640.Value == 33)
									{
										flag2 = false;
									}
									if ((((global::AcpCommonLib.IAcpFeatureNode)featureNode)[10080] as global::Motorola.MackinawCPS.CoreFeatures.RemoteSpeakerMic.RSMButtonInnerSection).RadErgoCfgRSMlTrunkingFeature_A19742.Value == 33)
									{
										num = (short)844693504;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									break;
								}
								case 6:
									goto IL_2415;
								}
								IL_2380:
								num = (short)386727939;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								IL_2327:
								goto IL_2380;
							}
							IL_2415:
							return flag2;
						}
						finally
						{
							num = (short)802684929;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								switch (num2)
								{
								case 0:
									enumerator.Dispose();
									num = (short)1235681282;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 1:
									switch (0)
									{
									case 0:
										goto IL_244E;
									}
									continue;
								case 2:
									goto IL_2488;
								}
								IL_244E:
								if (enumerator == null)
								{
									break;
								}
								num = (short)1202913280;
								num2 = (int)((global::System.IntPtr)num);
							}
							IL_2488:;
						}
						goto IL_248B;
					case 38:
						flag2 = false;
						num = (short)1674903687;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 39:
					{
						global::AcpCommonLib.IAcpRecordset feature = global::AcpCommonLib.FeatureManager.GetFeature(2088);
						num = (short)1822097412;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 40:
						goto IL_1934;
					case 41:
						if (flag2)
						{
							num = (short)1970339903;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_1EDC;
					case 42:
						try
						{
							num = (short)668008450;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								switch (num2)
								{
								case 0:
									num = (short)1900871684;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 1:
								{
									if (!enumerator.MoveNext())
									{
										num = (short)324272128;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									global::AcpCommonLib.IAcpFeatureNode acpFeatureNode2 = enumerator.Current;
									num = (short)1860763654;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 2:
									switch (0)
									{
									case 0:
										goto IL_1374;
									}
									continue;
								case 3:
								{
									global::AcpCommonLib.IAcpFeatureNode acpFeatureNode2;
									num4 = (acpFeatureNode2[10082] as global::Motorola.MackinawCPS.CoreFeatures.Switches.RotaryControlInnerSection).SwitchGeneralRotaryControl_A8984.Value;
									num = (short)274137093;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 4:
									goto IL_1456;
								case 5:
									goto IL_13A8;
								case 6:
								{
									global::AcpCommonLib.IAcpFeatureNode acpFeatureNode2;
									if ((acpFeatureNode2.Parent as global::AcpBusinessLayer.Recordset).IndexOf(acpFeatureNode2) == 0)
									{
										num = (short)52559875;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									break;
								}
								}
								IL_13AD:
								num = (short)1391788033;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								IL_1374:
								goto IL_13AD;
							}
							IL_13A8:
							IL_1456:
							goto IL_1BA4;
						}
						finally
						{
							num = (short)258539521;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								switch (num2)
								{
								case 0:
									enumerator.Dispose();
									num = (short)681836546;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 1:
									switch (0)
									{
									case 0:
										goto IL_148E;
									}
									continue;
								case 2:
									goto IL_14C6;
								}
								IL_148E:
								if (enumerator == null)
								{
									break;
								}
								num = (short)443482112;
								num2 = (int)((global::System.IntPtr)num);
							}
							IL_14C6:;
						}
						goto Block_26;
						IL_1BA4:
						num = (short)1251999780;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 43:
						if (switchConventionalSwitchesPosition2_A.Value != 33)
						{
							num = (short)1868759087;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_1265;
					case 44:
					{
						global::AcpCommonLib.IAcpRecordset feature;
						global::Motorola.MackinawCPS.CoreFeatures.MenuItems.MenuItems menuItems2 = feature[0] as global::Motorola.MackinawCPS.CoreFeatures.MenuItems.MenuItems;
						num = (short)1285357589;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 45:
						return flag2;
					case 46:
					{
						global::AcpCommonLib.IAcpRecordset feature3;
						global::Motorola.MackinawCPS.CoreFeatures.MenuItems.MenuItems menuItems3 = feature3[0] as global::Motorola.MackinawCPS.CoreFeatures.MenuItems.MenuItems;
						num6 = 0;
						num = (short)915144794;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 47:
						num = (short)1262354505;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 48:
						return flag2;
					case 49:
						flag3 = (switchConventionalSwitchesPosition5_A.Value != 26);
						goto IL_1896;
					case 50:
					{
						global::Motorola.MackinawCPS.CoreFeatures.MenuItems.MenuItems menuItems;
						if (menuItems.General.DispMenuTrunkingSelectedMenuItems_A21735.Items[num7].ItemName == global::CommonResources.AcgResources.ID_TXIN)
						{
							num = (short)1299316845;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_1BE2;
					}
					case 51:
						goto IL_8F6;
					case 52:
						goto IL_16E5;
					case 53:
						if (flag2)
						{
							num = (short)2020474961;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return flag2;
					case 54:
					{
						global::AcpCommonLib.IAcpRecordset feature2;
						if (feature2 != null)
						{
							num = (short)516816982;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return flag2;
					}
					case 55:
						num = (short)1656488073;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 56:
					{
						global::Motorola.MackinawCPS.CoreFeatures.MenuItems.MenuItems menuItems;
						if (num7 >= menuItems.General.DispMenuTrunkingSelectedMenuItems_A21735.Items.Count)
						{
							num = (short)1036845126;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)1147076658;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 57:
					{
						global::Motorola.MackinawCPS.CoreFeatures.MenuItems.MenuItems menuItems4;
						if (num8 >= menuItems4.General.DispMenuConventionalSelectedMenuItems_A21736.Items.Count)
						{
							num = (short)975700089;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)1257111675;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 58:
					{
						global::AcpCommonLib.IAcpRecordset feature;
						if (feature.Count != 0)
						{
							num = (short)1291386924;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return flag2;
					}
					case 59:
					{
						if (index != 46)
						{
							num = (short)11599966;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						global::AcpCommonLib.IAcpRecordset feature3 = global::AcpCommonLib.FeatureManager.GetFeature(2088);
						num = (short)2133131367;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 60:
						return flag2;
					case 61:
						num = (short)480575588;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 62:
					{
						global::AcpCommonLib.IAcpRecordset feature4;
						if (feature4 != null)
						{
							num = (short)1709375543;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_1EDC;
					}
					case 63:
					{
						global::AcpCommonLib.IAcpRecordset feature4 = global::AcpCommonLib.FeatureManager.GetFeature(2088);
						num = (short)79167550;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 64:
						num = (short)1469055005;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 65:
						num = (short)993132562;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 66:
						try
						{
							num = (short)1038876674;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								switch (num2)
								{
								case 0:
									if ((((global::AcpCommonLib.IAcpFeatureNode)enumerator.Current)[10092] as global::Motorola.MackinawCPS.CoreFeatures.Buttons.PortableButtonInnerSection).BtnGeneralConventionalFeature_A19544.Value == 26)
									{
										num = (short)1738080257;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									break;
								case 1:
									flag2 = false;
									num = (short)2143158278;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 2:
									switch (0)
									{
									case 0:
										goto IL_1A41;
									}
									continue;
								case 3:
									num = (short)366542853;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 4:
									if (!enumerator.MoveNext())
									{
										num = (short)1503395843;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									num = (short)336134144;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 5:
									goto IL_1B09;
								}
								IL_1A43:
								num = (short)1539768324;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								IL_1A41:
								goto IL_1A43;
							}
							IL_1B09:
							goto IL_2508;
						}
						finally
						{
							num = (short)748879872;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								switch (num2)
								{
								case 0:
									switch (0)
									{
									case 0:
										goto IL_1B40;
									}
									continue;
								case 1:
									goto IL_1B7A;
								case 2:
									enumerator.Dispose();
									num = (short)1166213121;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								IL_1B40:
								if (enumerator == null)
								{
									break;
								}
								num = (short)1339097090;
								num2 = (int)((global::System.IntPtr)num);
							}
							IL_1B7A:;
						}
						goto IL_1B7D;
					case 67:
					{
						global::Motorola.MackinawCPS.CoreFeatures.MenuItems.MenuItems menuItems;
						if (menuItems.General.DispMenuConventionalSelectedMenuItems_A21736.Items[num3].ItemName == global::CommonResources.AcgResources.ID_TXIN)
						{
							num = (short)1114898572;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_10B4;
					}
					case 68:
					{
						global::AcpCommonLib.IAcpRecordset feature4;
						global::Motorola.MackinawCPS.CoreFeatures.MenuItems.MenuItems menuItems4 = feature4[0] as global::Motorola.MackinawCPS.CoreFeatures.MenuItems.MenuItems;
						num = (short)1467547650;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 69:
						goto IL_8F6;
					case 70:
						num = (short)1658847262;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 71:
						enumerator = smartKeyFobButtonTableInnerRecset.GetEnumerator();
						num = (short)1799159915;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 72:
					{
						global::AcpCommonLib.IAcpRecordset feature3;
						if (feature3.Count != 0)
						{
							num = (short)440074331;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return flag2;
					}
					case 73:
						if (switchConventionalSwitchesPosition3_A.Value != 33)
						{
							num = (short)747241487;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_1265;
					case 74:
						if (!global::ConstraintHelper.UtilityMack.IsMobile())
						{
							num = (short)1971650568;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return flag2;
					case 75:
						num = (short)350421051;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 76:
						if (switchConventionalSwitchesPosition4_A.Value != 33)
						{
							num = (short)1344208974;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_1265;
					case 77:
					{
						global::Motorola.MackinawCPS.CoreFeatures.MenuItems.MenuItems menuItems3;
						if (num6 >= menuItems3.General.DispMenuConventionalSelectedMenuItems_A21736.Items.Count)
						{
							num = (short)1216086022;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)70320255;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 78:
						num = (short)77660284;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 79:
						flag4 = (switchConventionalSwitchesPosition3_A.Value != 30);
						goto IL_28E6;
					case 80:
						num = (short)1179320365;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 81:
						enumerator = portableButtonInnerRecset.GetEnumerator();
						num = (short)621150349;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 82:
						num = (short)545259536;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 83:
						return flag2;
					case 84:
						flag5 = false;
						goto IL_1C28;
					case 85:
						enumerator = portableButtonInnerRecset.GetEnumerator();
						num = (short)1320878146;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 86:
						num = (short)1383792650;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 87:
						goto IL_11EC;
					case 88:
						try
						{
							num = (short)1248264194;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								switch (num2)
								{
								case 0:
									flag2 = false;
									num = (short)1150222337;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 2:
									switch (0)
									{
									case 0:
										goto IL_266D;
									}
									continue;
								case 3:
									num = (short)1787494406;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 4:
									if (!enumerator.MoveNext())
									{
										num = (short)1573060611;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									num = (short)817299461;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 5:
								{
									global::AcpBusinessLayer.FeatureNode featureNode2 = enumerator.Current;
									if ((((global::AcpCommonLib.IAcpFeatureNode)featureNode2)[10092] as global::Motorola.MackinawCPS.CoreFeatures.Buttons.PortableButtonInnerSection).BtnGeneralConventionalFeature_A19544.Value == 33)
									{
										flag2 = false;
									}
									if ((((global::AcpCommonLib.IAcpFeatureNode)featureNode2)[10092] as global::Motorola.MackinawCPS.CoreFeatures.Buttons.PortableButtonInnerSection).BtnTrunkingPortableButtonFeature_A19546.Value == 33)
									{
										num = (short)1689911296;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									break;
								}
								case 6:
									goto IL_2758;
								}
								IL_26AB:
								num = (short)102563844;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								IL_266D:
								goto IL_26AB;
							}
							IL_2758:
							goto IL_118D;
						}
						finally
						{
							num = (short)734396417;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								switch (num2)
								{
								case 0:
									enumerator.Dispose();
									num = (short)1812922370;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 1:
									switch (0)
									{
									case 0:
										goto IL_2790;
									}
									continue;
								case 2:
									goto IL_27C8;
								}
								IL_2790:
								if (enumerator == null)
								{
									break;
								}
								num = (short)1504837632;
								num2 = (int)((global::System.IntPtr)num);
							}
							IL_27C8:;
						}
						goto IL_27CB;
					case 89:
						return flag2;
					case 90:
						goto IL_49E;
					case 91:
						num = (short)1766326383;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 92:
						if (flag2)
						{
							num = (short)290127892;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_3F7;
					case 93:
						flag4 = false;
						goto IL_28E6;
					case 94:
					{
						num = (short)1183711232;
						short num9 = num;
						num = (short)1676410907;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 95:
						enumerator = rsmbuttonInnerRecset.GetEnumerator();
						num = (short)609746975;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 96:
						goto IL_1138;
					case 97:
						if (index != 194)
						{
							num = (short)963313725;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						flag2 = false;
						num = (short)1634467872;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 98:
						if (index <= 61)
						{
							num = (short)1975713805;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)235012193;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 99:
					{
						global::Motorola.MackinawCPS.CoreFeatures.MenuItems.MenuItems menuItems4;
						if (num10 >= menuItems4.General.DispMenuTrunkingSelectedMenuItems_A21735.Items.Count)
						{
							num = (short)914423939;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)1807417480;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 100:
						if (index != 195)
						{
							num = (short)834535544;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_8D6;
					case 101:
						return flag2;
					case 102:
						goto IL_1B7D;
					case 103:
					{
						global::AcpCommonLib.IAcpRecordset feature3;
						if (feature3 != null)
						{
							num = (short)1525874695;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return flag2;
					}
					case 104:
						flag2 = false;
						num = (short)170852495;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 105:
						goto IL_203C;
					case 106:
					{
						global::Motorola.MackinawCPS.CoreFeatures.MenuItems.MenuItems menuItems2;
						if (num5 >= menuItems2.General.DispMenuConventionalSelectedMenuItems_A21736.Items.Count)
						{
							num = (short)883425360;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)1002307698;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 107:
						try
						{
							num = (short)91619337;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								switch (num2)
								{
								case 0:
								{
									global::AcpCommonLib.IAcpFeatureNode acpFeatureNode3;
									if ((acpFeatureNode3[10748] as global::Motorola.MackinawCPS.CoreFeatures.SmartKeyFob.SmartKeyFobButtonTableInnerSection).RadErgoCfgFobTrunkingFeature_A41575.Value == 33)
									{
										num = (short)742653953;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									break;
								}
								case 1:
									flag2 = false;
									num = (short)89063431;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 2:
									goto IL_6E9;
								case 3:
									flag2 = false;
									num = (short)1424818182;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 4:
									num = (short)183828482;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 5:
								{
									if (!enumerator.MoveNext())
									{
										num = (short)1920270340;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									global::AcpCommonLib.IAcpFeatureNode acpFeatureNode3 = enumerator.Current;
									num = (short)1375928328;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 6:
									goto IL_5BB;
								case 7:
									goto IL_5D8;
								case 8:
								{
									global::AcpCommonLib.IAcpFeatureNode acpFeatureNode3;
									if ((acpFeatureNode3[10748] as global::Motorola.MackinawCPS.CoreFeatures.SmartKeyFob.SmartKeyFobButtonTableInnerSection).RadErgoCfgFobConventionalFeature_A41574.Value == 33)
									{
										num = (short)357367811;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									num = (short)316145664;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 9:
									switch (0)
									{
									case 0:
										goto IL_5A1;
									}
									continue;
								}
								IL_5DD:
								num = (short)1261371397;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								IL_5A1:
								goto IL_5DD;
							}
							IL_5BB:
							IL_5D8:
							IL_6E9:
							goto IL_17D4;
						}
						finally
						{
							num = (short)1007616002;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								switch (num2)
								{
								case 0:
									goto IL_759;
								case 1:
									enumerator.Dispose();
									num = (short)369491968;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 2:
									switch (0)
									{
									case 0:
										goto IL_720;
									}
									continue;
								}
								IL_720:
								if (enumerator == null)
								{
									break;
								}
								num = (short)1546649601;
								num2 = (int)((global::System.IntPtr)num);
							}
							IL_759:;
						}
						goto Block_8;
					case 108:
						num = (short)1227948090;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 109:
						flag2 = false;
						num = (short)816971781;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 110:
						return flag2;
					case 111:
						if (!global::ConstraintHelper.UtilityMack.IsMobile())
						{
							num = (short)865665070;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return flag2;
					case 112:
						goto IL_75C;
					case 113:
						enumerator = rsmbuttonInnerRecset.GetEnumerator();
						num = (short)1600585765;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 114:
					{
						global::Motorola.MackinawCPS.CoreFeatures.MenuItems.MenuItems menuItems2;
						if (menuItems2.General.DispMenuConventionalSelectedMenuItems_A21736.Items[num5].ItemName == global::CommonResources.AcgResources.ID_DIR)
						{
							num = (short)176816166;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_1C88;
					}
					case 115:
						enumerator = portableButtonInnerRecset.GetEnumerator();
						num = (short)384434264;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 116:
						try
						{
							num = (short)585891841;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								switch (num2)
								{
								case 0:
									if ((((global::AcpCommonLib.IAcpFeatureNode)enumerator.Current)[10080] as global::Motorola.MackinawCPS.CoreFeatures.RemoteSpeakerMic.RSMButtonInnerSection).RadErgoCfgRSMlConventionalFeature_A19640.Value == 26)
									{
										num = (short)138543106;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									break;
								case 1:
									switch (0)
									{
									case 0:
										goto IL_A96;
									}
									continue;
								case 2:
									flag2 = false;
									num = (short)1845166083;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 4:
									goto IL_B5C;
								case 5:
									if (!enumerator.MoveNext())
									{
										num = (short)27525126;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									num = (short)1905721344;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 6:
									num = (short)783941636;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								IL_B06:
								num = (short)122748933;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								IL_A96:
								goto IL_B06;
							}
							IL_B5C:
							goto IL_25ED;
						}
						finally
						{
							num = (short)28311553;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								switch (num2)
								{
								case 0:
									enumerator.Dispose();
									num = (short)1371013122;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 1:
									switch (0)
									{
									case 0:
										goto IL_B95;
									}
									continue;
								case 2:
									goto IL_BCC;
								}
								IL_B95:
								if (enumerator == null)
								{
									break;
								}
								num = (short)1096613888;
								num2 = (int)((global::System.IntPtr)num);
							}
							IL_BCC:;
						}
						goto IL_BCF;
					case 117:
						num7 = 0;
						num = (short)826605593;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 118:
						goto IL_22C7;
					case 119:
						goto IL_10B4;
					case 120:
						goto IL_165A;
					case 121:
						num10 = 0;
						num = (short)471859339;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 122:
						num = (short)433324081;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 123:
					{
						global::Motorola.MackinawCPS.CoreFeatures.MenuItems.MenuItems menuItems4;
						if (menuItems4.General.DispMenuConventionalSelectedMenuItems_A21736.Items[num8].ItemName == global::CommonResources.AcgResources.ID_SCAN)
						{
							num = (short)71630883;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_16E5;
					}
					case 124:
						flag5 = (switchConventionalSwitchesPosition5_A.Value != 33);
						goto IL_1C28;
					case 125:
						num = (short)679673935;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 126:
						if (flag2)
						{
							num = (short)327155825;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return flag2;
					case 127:
					{
						global::Motorola.MackinawCPS.CoreFeatures.MenuItems.MenuItems menuItems3;
						if (menuItems3.General.DispMenuConventionalSelectedMenuItems_A21736.Items[num6].ItemName == global::CommonResources.AcgResources.ID_SCNL)
						{
							num = (short)1911554152;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_10D4;
					}
					case 128:
						goto IL_EF4;
					case 129:
						num = (short)1485373441;
						if (num != 0)
						{
						}
						if (conventionalSwitches.RefRadioErgonomicsWide.Advanced.RadErgoWideAdvancedSideButtonsLockEnable_A38725.Value)
						{
							num = (short)1054081119;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return flag2;
					case 130:
						switch (index)
						{
						case 26:
							num = (short)1629225092;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 27:
						{
							global::AcpCommonLib.IAcpRecordset feature2 = global::AcpCommonLib.FeatureManager.GetFeature(2088);
							num = (short)1298726966;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						case 28:
						case 31:
						case 32:
							return flag2;
						case 29:
							enumerator = rotaryControlInnerRecset.GetEnumerator();
							num = (short)477233178;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 30:
							enumerator = rotaryControlInnerRecset.GetEnumerator();
							num = (short)2144272426;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 33:
							num = (short)204013611;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						default:
							num = (short)2086142027;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						break;
					case 131:
						goto IL_1EDC;
					case 132:
						if (switchConventionalSwitchesPosition2_A.Value != 26)
						{
							num = (short)2070151250;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_248B;
					case 133:
						flag2 = false;
						num = (short)730660904;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 134:
						if (flag2)
						{
							num = (short)1255538759;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_17D4;
					case 135:
						goto IL_1C88;
					case 136:
					{
						global::Motorola.MackinawCPS.CoreFeatures.MenuItems.MenuItems menuItems4;
						if (menuItems4.General.DispMenuTrunkingSelectedMenuItems_A21735.Items[num10].ItemName == global::CommonResources.AcgResources.ID_SCAN)
						{
							num = (short)1022034053;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_1934;
					}
					case 137:
					{
						global::AcpCommonLib.IAcpRecordset feature4;
						if (feature4.Count != 0)
						{
							num = (short)55771204;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_1EDC;
					}
					case 138:
						if (flag2)
						{
							num = (short)76284006;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_25ED;
					case 139:
						goto IL_280B;
					case 140:
						flag2 = false;
						num = (short)1966473335;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 141:
						try
						{
							num = (short)1040973827;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								switch (num2)
								{
								case 0:
									num = (short)1349255176;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 1:
								{
									if (!enumerator.MoveNext())
									{
										num = (short)337379332;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									global::AcpCommonLib.IAcpFeatureNode acpFeatureNode4 = enumerator.Current;
									num = (short)1805058050;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 2:
								{
									num = (short)1950087793;
									short num11 = num;
									num = (short)200997489;
									switch ((num11 == num) ? 1 : 0)
									{
									case 0:
									case 2:
										goto IL_E10;
									default:
									{
										num = (short)371326976;
										if (num != 0)
										{
										}
										global::AcpCommonLib.IAcpFeatureNode acpFeatureNode4;
										if ((acpFeatureNode4[10092] as global::Motorola.MackinawCPS.CoreFeatures.Buttons.PortableButtonInnerSection).BtnGeneralConventionalBCO_A19543.Value != 148)
										{
											num = (short)403570688;
											num2 = (int)((global::System.IntPtr)num);
											continue;
										}
										break;
									}
									}
									break;
								}
								case 3:
									switch (0)
									{
									case 0:
										goto IL_D09;
									}
									continue;
								case 4:
									goto IL_E10;
								case 5:
									flag2 = false;
									num = (short)1878851591;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 6:
									goto IL_E7F;
								case 7:
									goto IL_D27;
								case 8:
								{
									global::AcpCommonLib.IAcpFeatureNode acpFeatureNode4;
									if ((acpFeatureNode4[10092] as global::Motorola.MackinawCPS.CoreFeatures.Buttons.PortableButtonInnerSection).BtnGeneralConventionalFeature_A19544.Value == 31)
									{
										num = (short)704774149;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									break;
								}
								}
								IL_DD2:
								num = (short)322174977;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								IL_D09:
								goto IL_DD2;
								IL_E10:
								num = (short)33554438;
								num2 = (int)((global::System.IntPtr)num);
							}
							IL_D27:
							IL_E7F:
							return flag2;
						}
						finally
						{
							num = (short)576782337;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								switch (num2)
								{
								case 0:
									enumerator.Dispose();
									num = (short)1011417090;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 1:
									switch (0)
									{
									case 0:
										goto IL_EB7;
									}
									continue;
								case 2:
									goto IL_EF1;
								}
								IL_EB7:
								if (enumerator == null)
								{
									break;
								}
								num = (short)558563328;
								num2 = (int)((global::System.IntPtr)num);
							}
							IL_EF1:;
						}
						goto IL_EF4;
					case 142:
						num8 = 0;
						num = (short)411041843;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 143:
						goto IL_10D4;
					}
					goto IL_26E;
					IL_3F7:
					num = (short)1590427670;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					Block_8:
					try
					{
						IL_75C:
						num = (short)1924923393;
						num2 = (int)((global::System.IntPtr)num);
						for (;;)
						{
							switch (num2)
							{
							case 0:
								goto IL_7B8;
							case 1:
								switch (0)
								{
								case 0:
									goto IL_79E;
								}
								continue;
							case 2:
								if ((((global::AcpCommonLib.IAcpFeatureNode)enumerator.Current)[10748] as global::Motorola.MackinawCPS.CoreFeatures.SmartKeyFob.SmartKeyFobButtonTableInnerSection).RadErgoCfgFobConventionalFeature_A41574.Value == 26)
								{
									num = (short)1894842371;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								break;
							case 3:
								flag2 = false;
								num = (short)1440808960;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							case 4:
								goto IL_864;
							case 5:
								if (!enumerator.MoveNext())
								{
									num = (short)94568454;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								num = (short)31784962;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							case 6:
								num = (short)1918631940;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							IL_811:
							num = (short)503054341;
							num2 = (int)((global::System.IntPtr)num);
							continue;
							IL_79E:
							goto IL_811;
						}
						IL_7B8:
						IL_864:
						goto IL_3F7;
					}
					finally
					{
						num = (short)298909696;
						num2 = (int)((global::System.IntPtr)num);
						for (;;)
						{
							switch (num2)
							{
							case 0:
								switch (0)
								{
								case 0:
									goto IL_89B;
								}
								continue;
							case 1:
								enumerator.Dispose();
								num = (short)738131970;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							case 2:
								goto IL_8D3;
							}
							IL_89B:
							if (enumerator == null)
							{
								break;
							}
							num = (short)571408385;
							num2 = (int)((global::System.IntPtr)num);
						}
						IL_8D3:;
					}
					goto IL_8D6;
					IL_49E:
					num = (short)1430388813;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_8D6:
					flag2 = false;
					num = (short)569180270;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_8F6:
					num = (short)1385758777;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_BCF:
					flag2 = radWideFeaturesNFPACompliant;
					num = (short)524222565;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_EF4:
					num = (short)484573258;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_10B4:
					num3++;
					num = (short)1676607584;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_10D4:
					num6++;
					num = (short)696516631;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_1138:
					num = (short)121569283;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_118D:
					num = (short)1991901318;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_11EC:
					num = (short)781058104;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_1265:
					num = (short)365035604;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_165A:
					num = (short)369426456;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					Block_26:
					try
					{
						IL_14C9:
						num = (short)1897529346;
						num2 = (int)((global::System.IntPtr)num);
						for (;;)
						{
							switch (num2)
							{
							case 0:
								num = (short)373489669;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							case 1:
								goto IL_15CA;
							case 2:
								switch (0)
								{
								case 0:
									goto IL_150C;
								}
								continue;
							case 3:
							{
								global::AcpCommonLib.IAcpFeatureNode acpFeatureNode5;
								num4 = (acpFeatureNode5[10082] as global::Motorola.MackinawCPS.CoreFeatures.Switches.RotaryControlInnerSection).SwitchGeneralRotaryControl_A8984.Value;
								num = (short)1023213569;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							case 4:
							{
								global::AcpCommonLib.IAcpFeatureNode acpFeatureNode5;
								if ((acpFeatureNode5.Parent as global::AcpBusinessLayer.Recordset).IndexOf(acpFeatureNode5) == 0)
								{
									num = (short)1664745475;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								break;
							}
							case 5:
								goto IL_15E8;
							case 6:
							{
								if (!enumerator.MoveNext())
								{
									num = (short)775815168;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								global::AcpCommonLib.IAcpFeatureNode acpFeatureNode5 = enumerator.Current;
								num = (short)1717960708;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							}
							IL_1558:
							num = (short)2109472774;
							num2 = (int)((global::System.IntPtr)num);
							continue;
							IL_150C:
							goto IL_1558;
						}
						IL_15CA:
						IL_15E8:
						goto IL_1E1F;
					}
					finally
					{
						num = (short)1823866880;
						num2 = (int)((global::System.IntPtr)num);
						for (;;)
						{
							switch (num2)
							{
							case 0:
								switch (0)
								{
								case 0:
									goto IL_161F;
								}
								continue;
							case 1:
								goto IL_1657;
							case 2:
								enumerator.Dispose();
								num = (short)996081665;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							IL_161F:
							if (enumerator == null)
							{
								break;
							}
							num = (short)1987313666;
							num2 = (int)((global::System.IntPtr)num);
						}
						IL_1657:;
					}
					goto IL_165A;
					IL_1E1F:
					num = (short)2055798793;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_16E5:
					num8++;
					num = (short)1079640133;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_17D4:
					num = (short)920125566;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_1896:
					flag2 = flag3;
					num = (short)1298530323;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_1934:
					num10++;
					num = (short)134676491;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_1B7D:
					enumerator = rsmbuttonInnerRecset.GetEnumerator();
					num = (short)1958936692;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_1BE2:
					num7++;
					num = (short)1369112663;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_1C28:
					flag2 = flag5;
					num = (short)1771438121;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_1C88:
					num5++;
					num = (short)636616809;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_1EDC:
					num = (short)564068385;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_203C:
					num = (short)1968636010;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_22C7:
					num = (short)1554251865;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_248B:
					num = (short)498860066;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_2508:
					num = (short)659161226;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_25CE:
					flag2 = flag;
					num = (short)1417412668;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_25ED:
					num = (short)1420623964;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_27CB:
					num = (short)694812725;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_280B:
					num = (short)1152450659;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_28E6:
					flag2 = flag4;
					num = (short)924581971;
					num2 = (int)((global::System.IntPtr)num);
				}
				return flag2;
				IL_26E:
				conventionalSwitches = (self as global::Motorola.MackinawCPS.CoreFeatures.Switches.ConventionalSwitches);
				global::AcpCommonLib.IAcpFeatureNode parent = self.Parent;
				switchConventionalSwitchesPosition2_A = conventionalSwitches.SwitchConventionalSwitchesPosition2_A7735;
				switchConventionalSwitchesPosition3_A = conventionalSwitches.SwitchConventionalSwitchesPosition3_A7737;
				switchConventionalSwitchesPosition4_A = conventionalSwitches.SwitchConventionalSwitchesPosition4_A21530;
				switchConventionalSwitchesPosition5_A = conventionalSwitches.SwitchConventionalSwitchesPosition5_A21531;
				radWideFeaturesNFPACompliant = conventionalSwitches.RefRadioWide.Features.RadWideFeaturesNFPACompliant;
				rotaryControlInnerRecset = ((global::AcpCommonLib.FeatureManager.GetFeature(2038) as global::Motorola.MackinawCPS.CoreFeatures.Switches.SwitchesRecset)[0][10081].EmbeddedRecset as global::Motorola.MackinawCPS.CoreFeatures.Switches.RotaryControlInnerRecset);
				portableButtonInnerRecset = ((global::AcpCommonLib.FeatureManager.GetFeature(2042) as global::Motorola.MackinawCPS.CoreFeatures.Buttons.ButtonsRecset)[0][10091].EmbeddedRecset as global::Motorola.MackinawCPS.CoreFeatures.Buttons.PortableButtonInnerRecset);
				smartKeyFobButtonTableInnerRecset = ((global::AcpCommonLib.FeatureManager.GetFeature(4130) as global::Motorola.MackinawCPS.CoreFeatures.SmartKeyFob.SmartKeyFobRecset)[0][10747].EmbeddedRecset as global::Motorola.MackinawCPS.CoreFeatures.SmartKeyFob.SmartKeyFobButtonTableInnerRecset);
				rsmbuttonInnerRecset = ((global::AcpCommonLib.FeatureManager.GetFeature(2036) as global::Motorola.MackinawCPS.CoreFeatures.RemoteSpeakerMic.RemoteSpeakerMicRecset)[0][10079].EmbeddedRecset as global::Motorola.MackinawCPS.CoreFeatures.RemoteSpeakerMic.RSMButtonInnerRecset);
				flag2 = true;
				num4 = 0;
				num = (short)937230434;
				num2 = (int)((global::System.IntPtr)num);
				goto IL_27;
			}
			}
		}

		// Token: 0x060073A6 RID: 29606 RVA: 0x0066D468 File Offset: 0x0066B668
		internal static bool ConSwitchesCnvPos2(global::AcpCommonLib.IAcpFeatureSection self, int index)
		{
			short num = (short)553517056;
			int num2 = (int)num;
			switch (num2)
			{
			default:
			{
				switch (0)
				{
				case 0:
					goto IL_28E;
				}
				global::AcpBusinessLayer.AcpListField switchConventionalSwitchesPosition5_A;
				global::AcpBusinessLayer.AcpListField switchConventionalSwitchesPosition4_A;
				global::Motorola.MackinawCPS.CoreFeatures.Buttons.PortableButtonInnerRecset portableButtonInnerRecset;
				bool flag2;
				global::AcpBusinessLayer.AcpListField switchConventionalSwitchesPosition1_A;
				global::AcpBusinessLayer.AcpListField switchTrunkingSwitchesPosition2_A;
				global::AcpBusinessLayer.AcpListField switchConventionalSwitchesPosition3_A;
				global::AcpBusinessLayer.AcpField<bool> radWideFeaturesNFPACompliant;
				global::Motorola.MackinawCPS.CoreFeatures.RemoteSpeakerMic.RSMButtonInnerRecset rsmbuttonInnerRecset;
				global::AcpBusinessLayer.AcpListField switchTrunkingSwitchesPosition1_A;
				global::Motorola.MackinawCPS.CoreFeatures.Switches.ConventionalSwitches conventionalSwitches;
				global::Motorola.MackinawCPS.CoreFeatures.SmartKeyFob.SmartKeyFobButtonTableInnerRecset smartKeyFobButtonTableInnerRecset;
				for (;;)
				{
					IL_27:
					bool flag;
					int num3;
					int num4;
					bool flag3;
					bool flag4;
					bool flag5;
					int num5;
					int num7;
					bool flag6;
					bool flag7;
					bool flag8;
					switch (num2)
					{
					case 0:
						goto IL_18BE;
					case 1:
						flag = (switchConventionalSwitchesPosition5_A.Value != 26);
						goto IL_247F;
					case 2:
						if (index != 195)
						{
							num = (short)852951101;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)1629290564;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 3:
						if (switchConventionalSwitchesPosition4_A.Value != 26)
						{
							num = (short)194510931;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_D17;
					case 4:
						num = (short)1579745392;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 5:
					{
						global::AcpCommonLib.IAcpRecordset feature;
						global::Motorola.MackinawCPS.CoreFeatures.MenuItems.MenuItems menuItems = feature[0] as global::Motorola.MackinawCPS.CoreFeatures.MenuItems.MenuItems;
						num = (short)568983567;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 6:
					{
						global::System.Collections.Generic.IEnumerator<global::AcpBusinessLayer.FeatureNode> enumerator = portableButtonInnerRecset.GetEnumerator();
						num = (short)1679818877;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 7:
						goto IL_6B0;
					case 8:
						num = (short)201326706;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 9:
						if (flag2)
						{
							num = (short)2041708573;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_E51;
					case 10:
						num3 = 0;
						num = (short)444858375;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 11:
						flag = false;
						goto IL_247F;
					case 12:
						if (flag2)
						{
							num = (short)1229914221;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return flag2;
					case 13:
						num = (short)1432485925;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 14:
						goto IL_169A;
					case 15:
						if (!global::ConstraintHelper.UtilityMack.IsMobile())
						{
							num = (short)1213792266;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_E51;
					case 16:
						num = (short)1096810645;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 17:
						num4 = 0;
						num = (short)334299150;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 18:
						if (switchConventionalSwitchesPosition1_A.Value == 81)
						{
							num = (short)1777401932;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_1123;
					case 19:
						switch (index)
						{
						case 26:
							num = (short)1174405161;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 27:
							flag2 = false;
							num = (short)1926889595;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 28:
						case 31:
						case 32:
							return flag2;
						case 29:
							num = (short)164102234;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 30:
							num = (short)2044723326;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 33:
							num = (short)920780858;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						default:
							num = (short)1948450911;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						break;
					case 20:
						flag3 = (switchTrunkingSwitchesPosition2_A.Value == 29);
						goto IL_2335;
					case 21:
						num = (short)2107113515;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 22:
						try
						{
							num = (short)540934151;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								switch (num2)
								{
								case 0:
								{
									global::AcpCommonLib.IAcpFeatureNode acpFeatureNode;
									if ((acpFeatureNode[10748] as global::Motorola.MackinawCPS.CoreFeatures.SmartKeyFob.SmartKeyFobButtonTableInnerSection).RadErgoCfgFobTrunkingFeature_A41575.Value == 33)
									{
										num = (short)548732932;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									break;
								}
								case 1:
									goto IL_1A19;
								case 2:
									goto IL_1B09;
								case 3:
									flag2 = false;
									num = (short)569704457;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 4:
									flag2 = false;
									num = (short)1685651457;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 5:
									num = (short)1518534658;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 6:
								{
									global::AcpCommonLib.IAcpFeatureNode acpFeatureNode;
									if ((acpFeatureNode[10748] as global::Motorola.MackinawCPS.CoreFeatures.SmartKeyFob.SmartKeyFobButtonTableInnerSection).RadErgoCfgFobConventionalFeature_A41574.Value == 33)
									{
										num = (short)2046033923;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									num = (short)82968576;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 7:
									switch (0)
									{
									case 0:
										goto IL_19C4;
									}
									continue;
								case 8:
								{
									global::System.Collections.Generic.IEnumerator<global::AcpBusinessLayer.FeatureNode> enumerator;
									if (!enumerator.MoveNext())
									{
										num = (short)350420997;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									global::AcpCommonLib.IAcpFeatureNode acpFeatureNode = enumerator.Current;
									num = (short)1672937478;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 9:
									goto IL_1A93;
								}
								IL_19C6:
								num = (short)310771720;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								IL_19C4:
								goto IL_19C6;
							}
							IL_1A19:
							IL_1A93:
							IL_1B09:
							goto IL_2443;
						}
						finally
						{
							num = (short)890765312;
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
										goto IL_1B40;
									}
									continue;
								case 1:
									enumerator.Dispose();
									num = (short)1292435458;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 2:
									goto IL_1B78;
								}
								IL_1B40:
								if (enumerator == null)
								{
									break;
								}
								num = (short)1526202369;
								num2 = (int)((global::System.IntPtr)num);
							}
							IL_1B78:;
						}
						goto IL_1B7B;
					case 23:
						return flag2;
					case 24:
					{
						global::AcpCommonLib.IAcpRecordset feature2;
						if (feature2 != null)
						{
							num = (short)1029439509;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return flag2;
					}
					case 25:
						num = (short)1560871056;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 26:
						return flag2;
					case 27:
						num = (short)1573060750;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 28:
						if (switchConventionalSwitchesPosition3_A.Value != 26)
						{
							num = (short)1964900405;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_D17;
					case 29:
					{
						global::AcpCommonLib.IAcpRecordset feature = global::AcpCommonLib.FeatureManager.GetFeature(2088);
						num = (short)713752625;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 30:
						flag2 = false;
						num = (short)333185145;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 31:
						num = (short)2014052386;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 32:
						num = (short)1068695682;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 33:
						if (flag2)
						{
							num = (short)1336279190;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_2443;
					case 34:
						flag4 = radWideFeaturesNFPACompliant;
						goto IL_D36;
					case 35:
						goto IL_169A;
					case 36:
						return flag2;
					case 37:
						return flag2;
					case 38:
						try
						{
							num = (short)1412759558;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								switch (num2)
								{
								case 0:
								{
									global::AcpCommonLib.IAcpFeatureNode acpFeatureNode2;
									if ((acpFeatureNode2[10080] as global::Motorola.MackinawCPS.CoreFeatures.RemoteSpeakerMic.RSMButtonInnerSection).RadErgoCfgRSMlConventionalFeature_A19640.Value == 31)
									{
										num = (short)745996291;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									break;
								}
								case 1:
									goto IL_14D9;
								case 2:
								{
									global::System.Collections.Generic.IEnumerator<global::AcpBusinessLayer.FeatureNode> enumerator;
									if (!enumerator.MoveNext())
									{
										num = (short)1956839432;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									global::AcpCommonLib.IAcpFeatureNode acpFeatureNode2 = enumerator.Current;
									num = (short)1159856132;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 3:
									flag2 = false;
									num = (short)116391943;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 4:
								{
									global::AcpCommonLib.IAcpFeatureNode acpFeatureNode2;
									if ((acpFeatureNode2[10080] as global::Motorola.MackinawCPS.CoreFeatures.RemoteSpeakerMic.RSMButtonInnerSection).RadErgoCfgRSMConventionalBCO_A19639.Value != 151)
									{
										num = (short)1691811845;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									break;
								}
								case 5:
									num = (short)1657274368;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 6:
									switch (0)
									{
									case 0:
										goto IL_13B3;
									}
									continue;
								case 7:
									goto IL_13CD;
								case 8:
									num = (short)1462304769;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								IL_142E:
								num = (short)1229062146;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								IL_13B3:
								goto IL_142E;
							}
							IL_13CD:
							IL_14D9:
							goto IL_10E6;
						}
						finally
						{
							num = (short)769196033;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								global::System.Collections.Generic.IEnumerator<global::AcpBusinessLayer.FeatureNode> enumerator;
								switch (num2)
								{
								case 0:
									goto IL_1549;
								case 1:
									switch (0)
									{
									case 0:
										goto IL_1511;
									}
									continue;
								case 2:
									enumerator.Dispose();
									num = (short)1265631232;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								IL_1511:
								if (enumerator == null)
								{
									break;
								}
								num = (short)502792194;
								num2 = (int)((global::System.IntPtr)num);
							}
							IL_1549:;
						}
						goto IL_154C;
						IL_10E6:
						num = (short)1880621068;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 39:
						return flag2;
					case 40:
						goto IL_E51;
					case 41:
						if (switchConventionalSwitchesPosition1_A.Value != 26)
						{
							num = (short)179503159;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_D17;
					case 42:
						try
						{
							num = (short)1014300675;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								switch (num2)
								{
								case 0:
									flag2 = false;
									num = (short)1047396357;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 1:
								{
									global::System.Collections.Generic.IEnumerator<global::AcpBusinessLayer.FeatureNode> enumerator;
									if ((((global::AcpCommonLib.IAcpFeatureNode)enumerator.Current)[10080] as global::Motorola.MackinawCPS.CoreFeatures.RemoteSpeakerMic.RSMButtonInnerSection).RadErgoCfgRSMlConventionalFeature_A19640.Value == 26)
									{
										num = (short)727318528;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									break;
								}
								case 2:
									num = (short)2076311558;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 3:
									switch (0)
									{
									case 0:
										goto IL_1DCB;
									}
									continue;
								case 4:
								{
									global::System.Collections.Generic.IEnumerator<global::AcpBusinessLayer.FeatureNode> enumerator;
									if (!enumerator.MoveNext())
									{
										num = (short)1183907842;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									num = (short)1829306369;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 6:
									goto IL_1E8F;
								}
								IL_1DCD:
								num = (short)401866756;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								IL_1DCB:
								goto IL_1DCD;
							}
							IL_1E8F:
							goto IL_C94;
						}
						finally
						{
							num = (short)1418657792;
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
										goto IL_1EC7;
									}
									continue;
								case 1:
									enumerator.Dispose();
									num = (short)1142423554;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 2:
									goto IL_1EFF;
								}
								IL_1EC7:
								if (enumerator == null)
								{
									break;
								}
								num = (short)1431699457;
								num2 = (int)((global::System.IntPtr)num);
							}
							IL_1EFF:;
						}
						goto IL_1F02;
					case 43:
					{
						global::AcpCommonLib.IAcpRecordset feature2;
						if (feature2.Count != 0)
						{
							num = (short)1645805679;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return flag2;
					}
					case 44:
					{
						global::System.Collections.Generic.IEnumerator<global::AcpBusinessLayer.FeatureNode> enumerator = rsmbuttonInnerRecset.GetEnumerator();
						num = (short)308543526;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 45:
						flag5 = false;
						goto IL_C54;
					case 46:
						goto IL_18BE;
					case 47:
						num = (short)226099278;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 48:
						num = (short)446955546;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 49:
					{
						global::AcpCommonLib.IAcpRecordset feature;
						if (feature != null)
						{
							num = (short)1989869584;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_E51;
					}
					case 50:
						num = (short)722534471;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 51:
						num = (short)445120532;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 52:
					{
						global::Motorola.MackinawCPS.CoreFeatures.MenuItems.MenuItems menuItems2;
						if (menuItems2.General.DispMenuConventionalSelectedMenuItems_A21736.Items[num5].ItemName == global::CommonResources.AcgResources.ID_SCNL)
						{
							num = (short)1513619538;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_1CDF;
					}
					case 53:
						num = (short)1202782211;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 54:
						goto IL_154C;
					case 55:
						num = (short)1724448796;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 56:
						num = (short)1351549008;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 57:
						if (switchConventionalSwitchesPosition1_A.Value == 274)
						{
							num = (short)608763958;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_79A;
					case 58:
						if (switchConventionalSwitchesPosition1_A.Value != 33)
						{
							num = (short)512753691;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_1CC1;
					case 59:
						if (!global::ConstraintHelper.UtilityMack.IsMobile())
						{
							num = (short)973799518;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return flag2;
					case 60:
						num = (short)463601752;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 61:
						num = (short)1106051174;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 62:
						goto IL_1F02;
					case 63:
					{
						global::System.Collections.Generic.IEnumerator<global::AcpBusinessLayer.FeatureNode> enumerator = rsmbuttonInnerRecset.GetEnumerator();
						num = (short)774373479;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 64:
						goto IL_1CDF;
					case 65:
						try
						{
							num = (short)439353348;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								switch (num2)
								{
								case 0:
									flag2 = false;
									num = (short)1605500933;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 1:
									goto IL_17F9;
								case 2:
									num = (short)828243969;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 3:
								{
									global::System.Collections.Generic.IEnumerator<global::AcpBusinessLayer.FeatureNode> enumerator;
									if ((((global::AcpCommonLib.IAcpFeatureNode)enumerator.Current)[10748] as global::Motorola.MackinawCPS.CoreFeatures.SmartKeyFob.SmartKeyFobButtonTableInnerSection).RadErgoCfgFobConventionalFeature_A41574.Value == 26)
									{
										num = (short)845086720;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									break;
								}
								case 4:
									switch (0)
									{
									case 0:
										goto IL_1730;
									}
									continue;
								case 5:
									goto IL_174B;
								case 6:
								{
									global::System.Collections.Generic.IEnumerator<global::AcpBusinessLayer.FeatureNode> enumerator;
									if (!enumerator.MoveNext())
									{
										num = (short)1923547138;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									num = (short)532545539;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								}
								IL_17A3:
								num = (short)225443846;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								IL_1730:
								goto IL_17A3;
							}
							IL_174B:
							IL_17F9:
							goto IL_B84;
						}
						finally
						{
							num = (short)378535937;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								global::System.Collections.Generic.IEnumerator<global::AcpBusinessLayer.FeatureNode> enumerator;
								switch (num2)
								{
								case 0:
									goto IL_18BB;
								case 1:
									switch (0)
									{
									case 0:
										goto IL_1831;
									}
									continue;
								case 2:
								{
									enumerator.Dispose();
									num = (short)871236654;
									short num6 = num;
									num = (short)1896743982;
									switch ((num6 == num) ? 1 : 0)
									{
									case 0:
									case 2:
										break;
									default:
										num = (short)1731657728;
										if (num != 0)
										{
										}
										num = (short)408354816;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									break;
								}
								}
								IL_1831:
								if (enumerator == null)
								{
									break;
								}
								num = (short)2091057154;
								num2 = (int)((global::System.IntPtr)num);
							}
							IL_18BB:;
						}
						goto IL_18BE;
					case 66:
					{
						global::AcpCommonLib.IAcpRecordset feature3;
						global::Motorola.MackinawCPS.CoreFeatures.MenuItems.MenuItems menuItems2 = feature3[0] as global::Motorola.MackinawCPS.CoreFeatures.MenuItems.MenuItems;
						num = (short)914751547;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 67:
					{
						global::Motorola.MackinawCPS.CoreFeatures.MenuItems.MenuItems menuItems;
						if (num7 >= menuItems.General.DispMenuTrunkingSelectedMenuItems_A21735.Items.Count)
						{
							num = (short)1713504296;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)2095513728;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 68:
						if (switchConventionalSwitchesPosition1_A.Value == 27)
						{
							num = (short)1105657975;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_C35;
					case 69:
					{
						global::AcpCommonLib.IAcpRecordset feature2 = global::AcpCommonLib.FeatureManager.GetFeature(2088);
						num = (short)1068171288;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 70:
						if (switchTrunkingSwitchesPosition1_A.Value == 27)
						{
							num = (short)1540620338;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_C35;
					case 71:
						flag6 = (switchTrunkingSwitchesPosition2_A.Value == 195);
						goto IL_D9D;
					case 72:
						num = (short)1070202969;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 73:
						goto IL_1343;
					case 74:
					{
						global::AcpCommonLib.IAcpRecordset feature3;
						if (feature3 != null)
						{
							num = (short)1493631008;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return flag2;
					}
					case 75:
						num = (short)580518031;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 76:
						num = (short)1480851589;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 77:
					{
						global::Motorola.MackinawCPS.CoreFeatures.MenuItems.MenuItems menuItems;
						if (menuItems.General.DispMenuConventionalSelectedMenuItems_A21736.Items[num3].ItemName == global::CommonResources.AcgResources.ID_SCAN)
						{
							num = (short)123666462;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_1D66;
					}
					case 78:
						if (switchTrunkingSwitchesPosition1_A.Value == 30)
						{
							num = (short)1796669500;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_2424;
					case 79:
						if (conventionalSwitches.RefRadioErgonomicsWide.Advanced.RadErgoWideAdvancedSideButtonsLockEnable_A38725.Value)
						{
							num = (short)796721196;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return flag2;
					case 80:
						if (index != 81)
						{
							num = (short)1024917529;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						flag2 = false;
						num = (short)2140078197;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 81:
						if (index <= 194)
						{
							num = (short)1068302392;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)1263271938;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 82:
						flag2 = false;
						num = (short)1265041472;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 83:
						num = (short)523042817;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 84:
					{
						global::System.Collections.Generic.IEnumerator<global::AcpBusinessLayer.FeatureNode> enumerator = smartKeyFobButtonTableInnerRecset.GetEnumerator();
						num = (short)1574371393;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 85:
						num = (short)636354660;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 86:
						num = (short)962592876;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 87:
					{
						global::System.Collections.Generic.IEnumerator<global::AcpBusinessLayer.FeatureNode> enumerator = portableButtonInnerRecset.GetEnumerator();
						num = (short)1980235917;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 88:
						flag5 = (switchTrunkingSwitchesPosition2_A.Value == 30);
						goto IL_C54;
					case 89:
						if (switchTrunkingSwitchesPosition2_A.Value == 275)
						{
							num = (short)338100255;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_79A;
					case 90:
						if (switchConventionalSwitchesPosition1_A.Value == 29)
						{
							num = (short)2142240772;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_23A2;
					case 91:
						flag7 = (switchConventionalSwitchesPosition5_A.Value != 33);
						goto IL_1208;
					case 92:
						if (flag2)
						{
							num = (short)33620055;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_4D2;
					case 93:
						flag7 = false;
						goto IL_1208;
					case 94:
						num5 = 0;
						num = (short)1307770926;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 95:
						num = (short)906035351;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 96:
						num = (short)526712923;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 97:
						return flag2;
					case 98:
						if (!global::ConstraintHelper.UtilityMack.IsMobile())
						{
							num = (short)8716305;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return flag2;
					case 99:
						if (flag2)
						{
							num = (short)1747058817;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_C94;
					case 100:
						flag8 = (switchTrunkingSwitchesPosition2_A.Value == 194);
						goto IL_1D02;
					case 101:
						if (index <= 61)
						{
							num = (short)428015752;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)1868300369;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 102:
						if (index != 275)
						{
							num = (short)1919352918;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)723779641;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 103:
						try
						{
							num = (short)617021444;
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
										num = (short)1628176390;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									num = (short)1580990469;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 1:
									goto IL_63C;
								case 2:
									flag2 = false;
									num = (short)761004035;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 4:
									switch (0)
									{
									case 0:
										goto IL_550;
									}
									continue;
								case 5:
								{
									global::System.Collections.Generic.IEnumerator<global::AcpBusinessLayer.FeatureNode> enumerator;
									global::AcpBusinessLayer.FeatureNode featureNode = enumerator.Current;
									if ((((global::AcpCommonLib.IAcpFeatureNode)featureNode)[10080] as global::Motorola.MackinawCPS.CoreFeatures.RemoteSpeakerMic.RSMButtonInnerSection).RadErgoCfgRSMlConventionalFeature_A19640.Value == 33)
									{
										flag2 = false;
									}
									if ((((global::AcpCommonLib.IAcpFeatureNode)featureNode)[10080] as global::Motorola.MackinawCPS.CoreFeatures.RemoteSpeakerMic.RSMButtonInnerSection).RadErgoCfgRSMlTrunkingFeature_A19742.Value == 33)
									{
										num = (short)579796994;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									break;
								}
								case 6:
									num = (short)281280513;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								IL_5AD:
								num = (short)1724121088;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								IL_550:
								goto IL_5AD;
							}
							IL_63C:
							return flag2;
						}
						finally
						{
							num = (short)2065432577;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								global::System.Collections.Generic.IEnumerator<global::AcpBusinessLayer.FeatureNode> enumerator;
								switch (num2)
								{
								case 0:
									goto IL_6AD;
								case 1:
									switch (0)
									{
									case 0:
										goto IL_675;
									}
									continue;
								case 2:
									enumerator.Dispose();
									num = (short)639631360;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								IL_675:
								if (enumerator == null)
								{
									break;
								}
								num = (short)448397314;
								num2 = (int)((global::System.IntPtr)num);
							}
							IL_6AD:;
						}
						goto IL_6B0;
					case 104:
					{
						global::Motorola.MackinawCPS.CoreFeatures.MenuItems.MenuItems menuItems;
						if (num3 >= menuItems.General.DispMenuConventionalSelectedMenuItems_A21736.Items.Count)
						{
							num = (short)203686001;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)1474035789;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 105:
					{
						global::Motorola.MackinawCPS.CoreFeatures.MenuItems.MenuItems menuItems2;
						if (num5 >= menuItems2.General.DispMenuConventionalSelectedMenuItems_A21736.Items.Count)
						{
							num = (short)1013186573;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)655228980;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 106:
					{
						global::Motorola.MackinawCPS.CoreFeatures.MenuItems.MenuItems menuItems3;
						if (num4 >= menuItems3.General.DispMenuConventionalSelectedMenuItems_A21736.Items.Count)
						{
							num = (short)1211629616;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)1953693806;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 107:
						num = (short)1845100641;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 108:
						return flag2;
					case 109:
					{
						global::System.Collections.Generic.IEnumerator<global::AcpBusinessLayer.FeatureNode> enumerator = portableButtonInnerRecset.GetEnumerator();
						num = (short)835518601;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 110:
					{
						global::Motorola.MackinawCPS.CoreFeatures.MenuItems.MenuItems menuItems3;
						if (menuItems3.General.DispMenuConventionalSelectedMenuItems_A21736.Items[num4].ItemName == global::CommonResources.AcgResources.ID_DIR)
						{
							num = (short)633340036;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_1343;
					}
					case 111:
					{
						num = (short)661192705;
						if (num != 0)
						{
						}
						global::AcpCommonLib.IAcpRecordset feature2;
						global::Motorola.MackinawCPS.CoreFeatures.MenuItems.MenuItems menuItems3 = feature2[0] as global::Motorola.MackinawCPS.CoreFeatures.MenuItems.MenuItems;
						num = (short)501743714;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 112:
						if (switchTrunkingSwitchesPosition1_A.Value == 29)
						{
							num = (short)1081212979;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_23A2;
					case 113:
						num7 = 0;
						num = (short)258474102;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 114:
						if (switchConventionalSwitchesPosition4_A.Value != 33)
						{
							num = (short)1859649632;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_1CC1;
					case 115:
						flag3 = false;
						goto IL_2335;
					case 116:
						return flag2;
					case 117:
						return flag2;
					case 118:
						goto IL_DBE;
					case 119:
						num = (short)267518022;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 120:
						flag4 = false;
						goto IL_D36;
					case 121:
						goto IL_1D66;
					case 122:
						if (switchTrunkingSwitchesPosition1_A.Value == 274)
						{
							num = (short)326565960;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_79A;
					case 123:
						return flag2;
					case 124:
						if (flag2)
						{
							num = (short)1724776454;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_1B7B;
					case 125:
						try
						{
							num = (short)79691779;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								switch (num2)
								{
								case 0:
									flag2 = false;
									num = (short)295763973;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 1:
								{
									global::System.Collections.Generic.IEnumerator<global::AcpBusinessLayer.FeatureNode> enumerator;
									if ((((global::AcpCommonLib.IAcpFeatureNode)enumerator.Current)[10092] as global::Motorola.MackinawCPS.CoreFeatures.Buttons.PortableButtonInnerSection).BtnGeneralConventionalFeature_A19544.Value == 26)
									{
										num = (short)1863516160;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									break;
								}
								case 2:
									num = (short)1922826246;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 3:
									switch (0)
									{
									case 0:
										goto IL_2547;
									}
									continue;
								case 4:
								{
									global::System.Collections.Generic.IEnumerator<global::AcpBusinessLayer.FeatureNode> enumerator;
									if (!enumerator.MoveNext())
									{
										num = (short)1650589698;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									num = (short)900595713;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 6:
									goto IL_260E;
								}
								IL_2549:
								num = (short)1605238788;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								IL_2547:
								goto IL_2549;
							}
							IL_260E:
							goto IL_1B7B;
						}
						finally
						{
							num = (short)1807482880;
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
										goto IL_2645;
									}
									continue;
								case 1:
									enumerator.Dispose();
									num = (short)692649986;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 2:
									goto IL_267D;
								}
								IL_2645:
								if (enumerator == null)
								{
									break;
								}
								num = (short)1354498049;
								num2 = (int)((global::System.IntPtr)num);
							}
							IL_267D:;
						}
						return flag2;
					case 126:
						if (switchConventionalSwitchesPosition1_A.Value == 30)
						{
							num = (short)1524695087;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_2424;
					case 127:
						goto IL_6B0;
					case 128:
					{
						global::Motorola.MackinawCPS.CoreFeatures.MenuItems.MenuItems menuItems;
						if (menuItems.General.DispMenuTrunkingSelectedMenuItems_A21735.Items[num7].ItemName == global::CommonResources.AcgResources.ID_SCAN)
						{
							num = (short)1130758275;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_1F02;
					}
					case 129:
					{
						global::System.Collections.Generic.IEnumerator<global::AcpBusinessLayer.FeatureNode> enumerator = rsmbuttonInnerRecset.GetEnumerator();
						num = (short)669777962;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 130:
					{
						global::AcpCommonLib.IAcpRecordset feature3;
						if (feature3.Count != 0)
						{
							num = (short)1567621186;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return flag2;
					}
					case 131:
						flag2 = false;
						num = (short)2092892222;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 132:
						goto IL_A27;
					case 133:
						if (switchTrunkingSwitchesPosition1_A.Value == 81)
						{
							num = (short)1593245781;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_1123;
					case 134:
						if (flag2)
						{
							num = (short)978387013;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return flag2;
					case 135:
						flag8 = false;
						goto IL_1D02;
					case 136:
						num = (short)102105107;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 137:
						try
						{
							num = (short)1756758021;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								switch (num2)
								{
								case 0:
								{
									global::AcpCommonLib.IAcpFeatureNode acpFeatureNode3;
									if ((acpFeatureNode3[10092] as global::Motorola.MackinawCPS.CoreFeatures.Buttons.PortableButtonInnerSection).BtnGeneralConventionalFeature_A19544.Value == 31)
									{
										num = (short)1255211015;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									break;
								}
								case 1:
									num = (short)877985800;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 2:
									num = (short)950009856;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 3:
									goto IL_22A4;
								case 4:
								{
									global::System.Collections.Generic.IEnumerator<global::AcpBusinessLayer.FeatureNode> enumerator;
									if (!enumerator.MoveNext())
									{
										num = (short)954400769;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									global::AcpCommonLib.IAcpFeatureNode acpFeatureNode3 = enumerator.Current;
									num = (short)301924358;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 5:
									switch (0)
									{
									case 0:
										goto IL_2199;
									}
									continue;
								case 6:
								{
									global::AcpCommonLib.IAcpFeatureNode acpFeatureNode3;
									if ((acpFeatureNode3[10092] as global::Motorola.MackinawCPS.CoreFeatures.Buttons.PortableButtonInnerSection).BtnGeneralConventionalBCO_A19543.Value != 148)
									{
										num = (short)551026690;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									break;
								}
								case 7:
									flag2 = false;
									num = (short)585760771;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 8:
									goto IL_22C2;
								}
								IL_21F7:
								num = (short)1161953284;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								IL_2199:
								goto IL_21F7;
							}
							IL_22A4:
							IL_22C2:
							return flag2;
						}
						finally
						{
							num = (short)1083768832;
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
										goto IL_22FB;
									}
									continue;
								case 1:
									enumerator.Dispose();
									num = (short)668860418;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 2:
									goto IL_2332;
								}
								IL_22FB:
								if (enumerator == null)
								{
									break;
								}
								num = (short)2108817409;
								num2 = (int)((global::System.IntPtr)num);
							}
							IL_2332:;
						}
						goto IL_2335;
					case 138:
						flag6 = false;
						goto IL_D9D;
					case 139:
						if (index != 61)
						{
							num = (short)685637739;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)687603791;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 140:
						return flag2;
					case 141:
						try
						{
							num = (short)1078525956;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								switch (num2)
								{
								case 0:
									flag2 = false;
									num = (short)455409667;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 1:
									goto IL_9B5;
								case 2:
									num = (short)1647050753;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 4:
									switch (0)
									{
									case 0:
										goto IL_8C2;
									}
									continue;
								case 5:
								{
									global::System.Collections.Generic.IEnumerator<global::AcpBusinessLayer.FeatureNode> enumerator;
									global::AcpBusinessLayer.FeatureNode featureNode2 = enumerator.Current;
									if ((((global::AcpCommonLib.IAcpFeatureNode)featureNode2)[10092] as global::Motorola.MackinawCPS.CoreFeatures.Buttons.PortableButtonInnerSection).BtnGeneralConventionalFeature_A19544.Value == 33)
									{
										flag2 = false;
									}
									if ((((global::AcpCommonLib.IAcpFeatureNode)featureNode2)[10092] as global::Motorola.MackinawCPS.CoreFeatures.Buttons.PortableButtonInnerSection).BtnTrunkingPortableButtonFeature_A19546.Value == 33)
									{
										num = (short)1022230528;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									break;
								}
								case 6:
								{
									global::System.Collections.Generic.IEnumerator<global::AcpBusinessLayer.FeatureNode> enumerator;
									if (!enumerator.MoveNext())
									{
										num = (short)621477890;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									num = (short)395706373;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								}
								IL_95C:
								num = (short)1452736518;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								IL_8C2:
								goto IL_95C;
							}
							IL_9B5:
							goto IL_4D2;
						}
						finally
						{
							num = (short)1902379009;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								global::System.Collections.Generic.IEnumerator<global::AcpBusinessLayer.FeatureNode> enumerator;
								switch (num2)
								{
								case 0:
									goto IL_A24;
								case 1:
									switch (0)
									{
									case 0:
										goto IL_9ED;
									}
									continue;
								case 2:
									enumerator.Dispose();
									num = (short)1783693312;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								IL_9ED:
								if (enumerator == null)
								{
									break;
								}
								num = (short)2143748098;
								num2 = (int)((global::System.IntPtr)num);
							}
							IL_A24:;
						}
						goto IL_A27;
					case 142:
						if (switchConventionalSwitchesPosition3_A.Value != 33)
						{
							num = (short)1740505096;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_1CC1;
					case 143:
						return flag2;
					case 144:
						if (index != 194)
						{
							num = (short)2121400395;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)211812370;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 145:
						goto IL_DBE;
					case 146:
						if (flag2)
						{
							num = (short)524288084;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_B84;
					case 147:
						num = (short)982843531;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 148:
						if (flag2)
						{
							num = (short)263258175;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return flag2;
					case 149:
					{
						global::AcpCommonLib.IAcpRecordset feature;
						if (feature.Count != 0)
						{
							num = (short)154927109;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_E51;
					}
					case 150:
					{
						global::System.Collections.Generic.IEnumerator<global::AcpBusinessLayer.FeatureNode> enumerator = smartKeyFobButtonTableInnerRecset.GetEnumerator();
						num = (short)390594582;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 151:
					{
						if (index != 46)
						{
							num = (short)126353555;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						global::AcpCommonLib.IAcpRecordset feature3 = global::AcpCommonLib.FeatureManager.GetFeature(2088);
						num = (short)749273162;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					}
					goto IL_28E;
					IL_4D2:
					num = (short)100794401;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_6B0:
					num = (short)438632552;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_79A:
					num = (short)1253900408;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_A27:
					flag2 = false;
					num = (short)1702297673;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_B84:
					num = (short)177078406;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_C35:
					num = (short)292814986;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_C54:
					flag2 = flag5;
					num = (short)1996095511;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_C94:
					num = (short)1068368018;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_D17:
					num = (short)2128543755;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_D36:
					flag2 = flag4;
					num = (short)1358299175;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_D9D:
					flag2 = flag6;
					num = (short)621019252;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_DBE:
					num = (short)1361248323;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_E51:
					num = (short)481099868;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_1123:
					num = (short)237174919;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_1208:
					flag2 = flag7;
					num = (short)942276617;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_1343:
					num4++;
					num = (short)263061539;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_154C:
					num = (short)1767571578;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_169A:
					num = (short)1824981098;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_18BE:
					num = (short)2126315625;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_1B7B:
					num = (short)1196621923;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_1CC1:
					num = (short)53280861;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_1CDF:
					num5++;
					num = (short)1000341504;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_1D02:
					flag2 = flag8;
					num = (short)469958692;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_1D66:
					num3++;
					num = (short)2073690239;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_1F02:
					num = (short)1178009600;
					short num8 = num;
					num7++;
					num = (short)2084438161;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_2335:
					flag2 = flag3;
					num = (short)1867251852;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_23A2:
					num = (short)328728691;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_2424:
					num = (short)432865325;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_2443:
					num = (short)89260180;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_247F:
					flag2 = flag;
					num = (short)331153532;
					num2 = (int)((global::System.IntPtr)num);
				}
				return flag2;
				IL_28E:
				conventionalSwitches = (self as global::Motorola.MackinawCPS.CoreFeatures.Switches.ConventionalSwitches);
				global::Motorola.MackinawCPS.CoreFeatures.Switches.Switches switches = self.Parent as global::Motorola.MackinawCPS.CoreFeatures.Switches.Switches;
				switchConventionalSwitchesPosition1_A = conventionalSwitches.SwitchConventionalSwitchesPosition1_A7734;
				switchConventionalSwitchesPosition3_A = conventionalSwitches.SwitchConventionalSwitchesPosition3_A7737;
				switchConventionalSwitchesPosition4_A = conventionalSwitches.SwitchConventionalSwitchesPosition4_A21530;
				switchConventionalSwitchesPosition5_A = conventionalSwitches.SwitchConventionalSwitchesPosition5_A21531;
				switchTrunkingSwitchesPosition1_A = switches.TrunkingSwitches.SwitchTrunkingSwitchesPosition1_A9466;
				switchTrunkingSwitchesPosition2_A = switches.TrunkingSwitches.SwitchTrunkingSwitchesPosition2_A9467;
				radWideFeaturesNFPACompliant = conventionalSwitches.RefRadioWide.Features.RadWideFeaturesNFPACompliant;
				portableButtonInnerRecset = ((global::AcpCommonLib.FeatureManager.GetFeature(2042) as global::Motorola.MackinawCPS.CoreFeatures.Buttons.ButtonsRecset)[0][10091].EmbeddedRecset as global::Motorola.MackinawCPS.CoreFeatures.Buttons.PortableButtonInnerRecset);
				rsmbuttonInnerRecset = ((global::AcpCommonLib.FeatureManager.GetFeature(2036) as global::Motorola.MackinawCPS.CoreFeatures.RemoteSpeakerMic.RemoteSpeakerMicRecset)[0][10079].EmbeddedRecset as global::Motorola.MackinawCPS.CoreFeatures.RemoteSpeakerMic.RSMButtonInnerRecset);
				smartKeyFobButtonTableInnerRecset = ((global::AcpCommonLib.FeatureManager.GetFeature(4130) as global::Motorola.MackinawCPS.CoreFeatures.SmartKeyFob.SmartKeyFobRecset)[0][10747].EmbeddedRecset as global::Motorola.MackinawCPS.CoreFeatures.SmartKeyFob.SmartKeyFobButtonTableInnerRecset);
				flag2 = true;
				num = (short)1139671141;
				num2 = (int)((global::System.IntPtr)num);
				goto IL_27;
			}
			}
		}

		// Token: 0x060073A7 RID: 29607 RVA: 0x0066FBBC File Offset: 0x0066DDBC
		internal static bool ConSwitchesCnvPos3(global::AcpCommonLib.IAcpFeatureSection self, int index)
		{
			short num = (short)145031168;
			int num2 = (int)num;
			switch (num2)
			{
			default:
			{
				switch (0)
				{
				case 0:
					goto IL_22F;
				}
				bool flag;
				global::AcpBusinessLayer.AcpListField switchConventionalSwitchesPosition2_A;
				global::AcpBusinessLayer.AcpListField switchConventionalSwitchesPosition5_A;
				global::Motorola.MackinawCPS.CoreFeatures.Switches.RotaryControlInnerRecset rotaryControlInnerRecset;
				global::Motorola.MackinawCPS.CoreFeatures.Buttons.PortableButtonInnerRecset portableButtonInnerRecset;
				global::Motorola.MackinawCPS.CoreFeatures.Switches.ConventionalSwitches conventionalSwitches;
				int num6;
				global::AcpBusinessLayer.AcpListField switchConventionalSwitchesPosition4_A;
				global::Motorola.MackinawCPS.CoreFeatures.RemoteSpeakerMic.RSMButtonInnerRecset rsmbuttonInnerRecset;
				global::AcpBusinessLayer.AcpListField switchConventionalSwitchesPosition1_A;
				global::Motorola.MackinawCPS.CoreFeatures.SmartKeyFob.SmartKeyFobButtonTableInnerRecset smartKeyFobButtonTableInnerRecset;
				for (;;)
				{
					IL_28:
					global::System.Collections.Generic.IEnumerator<global::AcpBusinessLayer.FeatureNode> enumerator;
					bool flag2;
					bool flag3;
					int num3;
					int num4;
					bool flag4;
					bool flag5;
					int num7;
					int num8;
					global::AcpCommonLib.IAcpRecordset feature3;
					switch (num2)
					{
					case 0:
						if (index <= 61)
						{
							num = (short)1014956111;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)670105674;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 1:
						num = (short)226557955;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 2:
						flag = false;
						num = (short)943587373;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 3:
						return flag;
					case 4:
						try
						{
							num = (short)1173684229;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								switch (num2)
								{
								case 0:
									if (!enumerator.MoveNext())
									{
										num = (short)801177602;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									num = (short)18677761;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 1:
									if ((((global::AcpCommonLib.IAcpFeatureNode)enumerator.Current)[10080] as global::Motorola.MackinawCPS.CoreFeatures.RemoteSpeakerMic.RSMButtonInnerSection).RadErgoCfgRSMlConventionalFeature_A19640.Value == 26)
									{
										num = (short)1418657798;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									break;
								case 2:
									num = (short)1226768388;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 4:
									goto IL_1086;
								case 5:
									switch (0)
									{
									case 0:
										goto IL_FBF;
									}
									continue;
								case 6:
									flag = false;
									num = (short)1753808899;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								IL_1012:
								num = (short)1328742400;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								IL_FBF:
								goto IL_1012;
							}
							IL_1086:
							goto IL_1918;
						}
						finally
						{
							num = (short)885194753;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								switch (num2)
								{
								case 0:
									goto IL_10F4;
								case 1:
									switch (0)
									{
									case 0:
										goto IL_10BD;
									}
									continue;
								case 2:
									enumerator.Dispose();
									num = (short)1007550464;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								IL_10BD:
								if (enumerator == null)
								{
									break;
								}
								num = (short)786956290;
								num2 = (int)((global::System.IntPtr)num);
							}
							IL_10F4:;
						}
						goto IL_10F7;
					case 5:
						if (switchConventionalSwitchesPosition2_A.Value != 33)
						{
							num = (short)1782054952;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_184B;
					case 6:
						if (!global::ConstraintHelper.UtilityMack.IsMobile())
						{
							num = (short)1041563665;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_2128;
					case 7:
					{
						if (index != 46)
						{
							num = (short)1657602099;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						global::AcpCommonLib.IAcpRecordset feature = global::AcpCommonLib.FeatureManager.GetFeature(2088);
						num = (short)917766165;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 8:
						try
						{
							num = (short)14352389;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								switch (num2)
								{
								case 1:
									if (!enumerator.MoveNext())
									{
										num = (short)1763180550;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									num = (short)93585410;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 2:
								{
									global::AcpBusinessLayer.FeatureNode featureNode = enumerator.Current;
									if ((((global::AcpCommonLib.IAcpFeatureNode)featureNode)[10080] as global::Motorola.MackinawCPS.CoreFeatures.RemoteSpeakerMic.RSMButtonInnerSection).RadErgoCfgRSMlConventionalFeature_A19640.Value == 33)
									{
										flag = false;
									}
									if ((((global::AcpCommonLib.IAcpFeatureNode)featureNode)[10080] as global::Motorola.MackinawCPS.CoreFeatures.RemoteSpeakerMic.RSMButtonInnerSection).RadErgoCfgRSMlTrunkingFeature_A19742.Value == 33)
									{
										num = (short)1448542211;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									break;
								}
								case 3:
									flag = false;
									num = (short)867827712;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 4:
									goto IL_1D97;
								case 5:
									switch (0)
									{
									case 0:
										goto IL_1CA8;
									}
									continue;
								case 6:
									num = (short)59113476;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								IL_1CAA:
								num = (short)233701377;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								IL_1CA8:
								goto IL_1CAA;
							}
							IL_1D97:
							return flag;
						}
						finally
						{
							num = (short)1950482434;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								switch (num2)
								{
								case 0:
									goto IL_1E07;
								case 1:
									enumerator.Dispose();
									num = (short)282329088;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 2:
									switch (0)
									{
									case 0:
										goto IL_1DCF;
									}
									continue;
								}
								IL_1DCF:
								if (enumerator == null)
								{
									break;
								}
								num = (short)1673003009;
								num2 = (int)((global::System.IntPtr)num);
							}
							IL_1E07:;
						}
						goto IL_1E0A;
					case 9:
						flag2 = (switchConventionalSwitchesPosition5_A.Value != 33);
						goto IL_2186;
					case 10:
						num = (short)771031041;
						if (num != 0)
						{
						}
						try
						{
							num = (short)1095303169;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								switch (num2)
								{
								case 0:
									num = (short)1686896646;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 1:
									switch (0)
									{
									case 0:
										goto IL_DB6;
									}
									continue;
								case 2:
									if ((((global::AcpCommonLib.IAcpFeatureNode)enumerator.Current)[10092] as global::Motorola.MackinawCPS.CoreFeatures.Buttons.PortableButtonInnerSection).BtnGeneralConventionalFeature_A19544.Value == 26)
									{
										num = (short)1828847619;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									break;
								case 3:
									flag = false;
									num = (short)162136068;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 5:
									if (!enumerator.MoveNext())
									{
										num = (short)1428291584;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									num = (short)1131151362;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 6:
									goto IL_E79;
								}
								IL_DD3:
								num = (short)171376645;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								IL_DB6:
								goto IL_DD3;
							}
							IL_E79:
							goto IL_6AA;
						}
						finally
						{
							num = (short)1707540481;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								switch (num2)
								{
								case 0:
									enumerator.Dispose();
									num = (short)516227074;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 1:
									switch (0)
									{
									case 0:
										goto IL_EB1;
									}
									continue;
								case 2:
									goto IL_EE8;
								}
								IL_EB1:
								if (enumerator == null)
								{
									break;
								}
								num = (short)2883584;
								num2 = (int)((global::System.IntPtr)num);
							}
							IL_EE8:;
						}
						goto IL_EEB;
					case 11:
						switch (index)
						{
						case 26:
							num = (short)2133131378;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 27:
							flag = false;
							num = (short)66846738;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 28:
						case 31:
						case 32:
							return flag;
						case 29:
							enumerator = rotaryControlInnerRecset.GetEnumerator();
							num = (short)414711918;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 30:
							goto IL_17E5;
						case 33:
							num = (short)969408617;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						default:
							num = (short)1038680077;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						break;
					case 12:
						return flag;
					case 13:
						num = (short)803340295;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 14:
						flag3 = false;
						goto IL_D35;
					case 15:
						if (index != 194)
						{
							num = (short)1810038859;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						flag = false;
						num = (short)624033840;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 16:
					{
						global::AcpCommonLib.IAcpRecordset feature2;
						if (feature2 != null)
						{
							num = (short)382337091;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_2128;
					}
					case 17:
					{
						global::AcpCommonLib.IAcpRecordset feature2;
						global::Motorola.MackinawCPS.CoreFeatures.MenuItems.MenuItems menuItems = feature2[0] as global::Motorola.MackinawCPS.CoreFeatures.MenuItems.MenuItems;
						num3 = 0;
						num = (short)237895726;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 18:
						return flag;
					case 19:
						if (flag)
						{
							num = (short)482213917;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_6AA;
					case 20:
					{
						global::Motorola.MackinawCPS.CoreFeatures.MenuItems.MenuItems menuItems;
						if (num4 >= menuItems.General.DispMenuTrunkingSelectedMenuItems_A21735.Items.Count)
						{
							num = (short)1641742413;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)205848632;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 21:
					{
						global::AcpCommonLib.IAcpRecordset feature;
						if (feature != null)
						{
							num = (short)298778697;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return flag;
					}
					case 22:
						goto IL_5A9;
					case 23:
						if (flag)
						{
							num = (short)863371327;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return flag;
					case 24:
						if (flag)
						{
							num = (short)806289494;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_18C8;
					case 25:
						num4 = 0;
						num = (short)1282080858;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 26:
						goto IL_1BB6;
					case 27:
						flag4 = false;
						goto IL_1E0A;
					case 28:
						flag = false;
						num = (short)557908038;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 29:
						enumerator = portableButtonInnerRecset.GetEnumerator();
						num = (short)1398210570;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 30:
						if (!global::ConstraintHelper.UtilityMack.IsMobile())
						{
							num = (short)18546813;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return flag;
					case 31:
						try
						{
							num = (short)96665605;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								switch (num2)
								{
								case 0:
									if (!enumerator.MoveNext())
									{
										num = (short)1238630402;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									num = (short)1227423745;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 1:
								{
									num = (short)434165560;
									short num5 = num;
									num = (short)975623992;
									switch ((num5 == num) ? 1 : 0)
									{
									case 0:
									case 2:
										goto IL_1738;
									default:
										num = (short)1431109632;
										if (num != 0)
										{
										}
										if ((((global::AcpCommonLib.IAcpFeatureNode)enumerator.Current)[10748] as global::Motorola.MackinawCPS.CoreFeatures.SmartKeyFob.SmartKeyFobButtonTableInnerSection).RadErgoCfgFobConventionalFeature_A41574.Value == 26)
										{
											num = (short)862453766;
											num2 = (int)((global::System.IntPtr)num);
											continue;
										}
										break;
									}
									break;
								}
								case 2:
									goto IL_1738;
								case 3:
									goto IL_1756;
								case 4:
									goto IL_1774;
								case 5:
									switch (0)
									{
									case 0:
										goto IL_1657;
									}
									continue;
								case 6:
									flag = false;
									num = (short)959643651;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								IL_16FC:
								num = (short)94896128;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								IL_1657:
								goto IL_16FC;
								IL_1738:
								num = (short)1411317764;
								num2 = (int)((global::System.IntPtr)num);
							}
							IL_1756:
							IL_1774:
							goto IL_149E;
						}
						finally
						{
							num = (short)621871105;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								switch (num2)
								{
								case 0:
									goto IL_17E2;
								case 1:
									switch (0)
									{
									case 0:
										goto IL_17AB;
									}
									continue;
								case 2:
									enumerator.Dispose();
									num = (short)228392960;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								IL_17AB:
								if (enumerator == null)
								{
									break;
								}
								num = (short)691208194;
								num2 = (int)((global::System.IntPtr)num);
							}
							IL_17E2:;
						}
						goto IL_17E5;
					case 32:
						flag5 = (switchConventionalSwitchesPosition5_A.Value != 26);
						goto IL_22B3;
					case 33:
						goto IL_15BF;
					case 34:
						goto IL_1366;
					case 35:
						if (conventionalSwitches.RefRadioErgonomicsWide.Advanced.RadErgoWideAdvancedSideButtonsLockEnable_A38725.Value)
						{
							num = (short)1208614954;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_18C8;
					case 36:
						return flag;
					case 37:
						return flag;
					case 38:
						try
						{
							num = (short)1577910277;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								switch (num2)
								{
								case 0:
									goto IL_1A85;
								case 1:
								{
									if (!enumerator.MoveNext())
									{
										num = (short)747569158;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									global::AcpCommonLib.IAcpFeatureNode acpFeatureNode = enumerator.Current;
									num = (short)1805451266;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 2:
								{
									global::AcpCommonLib.IAcpFeatureNode acpFeatureNode;
									if ((acpFeatureNode.Parent as global::AcpBusinessLayer.Recordset).IndexOf(acpFeatureNode) == 0)
									{
										num = (short)1008992259;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									break;
								}
								case 3:
								{
									global::AcpCommonLib.IAcpFeatureNode acpFeatureNode;
									num6 = (acpFeatureNode[10082] as global::Motorola.MackinawCPS.CoreFeatures.Switches.RotaryControlInnerSection).SwitchGeneralRotaryControl_A8984.Value;
									num = (short)1581973504;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 4:
									goto IL_1AFA;
								case 5:
									switch (0)
									{
									case 0:
										goto IL_1A15;
									}
									continue;
								case 6:
									num = (short)936247300;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								IL_1A17:
								num = (short)1768161281;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								IL_1A15:
								goto IL_1A17;
							}
							IL_1A85:
							IL_1AFA:
							goto IL_1956;
						}
						finally
						{
							num = (short)1595932673;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								switch (num2)
								{
								case 0:
									goto IL_1B6A;
								case 1:
									switch (0)
									{
									case 0:
										goto IL_1B33;
									}
									continue;
								case 2:
									enumerator.Dispose();
									num = (short)1500119040;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								IL_1B33:
								if (enumerator == null)
								{
									break;
								}
								num = (short)1662386178;
								num2 = (int)((global::System.IntPtr)num);
							}
							IL_1B6A:;
						}
						goto IL_1B6D;
						IL_1956:
						num = (short)1750532172;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 39:
						if (switchConventionalSwitchesPosition4_A.Value == 33)
						{
							num = (short)262078524;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)289996859;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 40:
						num = (short)881262631;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 41:
					{
						global::Motorola.MackinawCPS.CoreFeatures.MenuItems.MenuItems menuItems2;
						if (num7 >= menuItems2.General.DispMenuConventionalSelectedMenuItems_A21736.Items.Count)
						{
							num = (short)592642148;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)83230802;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 42:
						enumerator = rsmbuttonInnerRecset.GetEnumerator();
						num = (short)463601722;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 43:
						num = (short)1857224797;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 44:
						flag = false;
						num = (short)816250906;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 45:
						goto IL_F59;
					case 46:
						goto IL_5A9;
					case 47:
					{
						global::AcpCommonLib.IAcpRecordset feature2;
						if (feature2.Count != 0)
						{
							num = (short)1736704103;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_2128;
					}
					case 48:
						return flag;
					case 49:
						flag2 = false;
						goto IL_2186;
					case 50:
						try
						{
							num = (short)1182334984;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								switch (num2)
								{
								case 0:
									goto IL_1180;
								case 1:
								{
									global::AcpCommonLib.IAcpFeatureNode acpFeatureNode2;
									if ((acpFeatureNode2[10748] as global::Motorola.MackinawCPS.CoreFeatures.SmartKeyFob.SmartKeyFobButtonTableInnerSection).RadErgoCfgFobTrunkingFeature_A41575.Value == 33)
									{
										num = (short)1988493321;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									break;
								}
								case 2:
									flag = false;
									num = (short)71761920;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 3:
									goto IL_12AF;
								case 4:
								{
									global::AcpCommonLib.IAcpFeatureNode acpFeatureNode2;
									if ((acpFeatureNode2[10748] as global::Motorola.MackinawCPS.CoreFeatures.SmartKeyFob.SmartKeyFobButtonTableInnerSection).RadErgoCfgFobConventionalFeature_A41574.Value == 33)
									{
										num = (short)1084555266;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									num = (short)527368193;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 5:
								{
									if (!enumerator.MoveNext())
									{
										num = (short)1730740230;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									global::AcpCommonLib.IAcpFeatureNode acpFeatureNode2 = enumerator.Current;
									num = (short)867368964;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 6:
									num = (short)1566638083;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 7:
									goto IL_11F2;
								case 8:
									switch (0)
									{
									case 0:
										goto IL_1163;
									}
									continue;
								case 9:
									flag = false;
									num = (short)1575157767;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								IL_1257:
								num = (short)2104295429;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								IL_1163:
								goto IL_1257;
							}
							IL_1180:
							IL_11F2:
							IL_12AF:
							goto IL_CF9;
						}
						finally
						{
							num = (short)83165185;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								switch (num2)
								{
								case 0:
									goto IL_1321;
								case 1:
									switch (0)
									{
									case 0:
										goto IL_12E8;
									}
									continue;
								case 2:
									enumerator.Dispose();
									num = (short)953942016;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								IL_12E8:
								if (enumerator == null)
								{
									break;
								}
								num = (short)1262616578;
								num2 = (int)((global::System.IntPtr)num);
							}
							IL_1321:;
						}
						goto IL_1324;
					case 51:
						num = (short)736100458;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 52:
						enumerator = rsmbuttonInnerRecset.GetEnumerator();
						num = (short)1875443716;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 53:
						flag = false;
						num = (short)51576894;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 54:
						num = (short)1939865697;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 55:
						num = (short)2028077086;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 56:
					{
						global::Motorola.MackinawCPS.CoreFeatures.MenuItems.MenuItems menuItems;
						if (menuItems.General.DispMenuTrunkingSelectedMenuItems_A21735.Items[num4].ItemName == global::CommonResources.AcgResources.ID_SCAN)
						{
							num = (short)1051918380;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_1BB6;
					}
					case 57:
					{
						global::AcpCommonLib.IAcpRecordset feature;
						if (feature.Count != 0)
						{
							num = (short)1131216951;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return flag;
					}
					case 58:
						try
						{
							num = (short)785842182;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								switch (num2)
								{
								case 0:
									num = (short)1334902791;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 1:
									num = (short)815005701;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 2:
									flag = false;
									num = (short)1962409992;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 3:
								{
									if (!enumerator.MoveNext())
									{
										num = (short)1000144897;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									global::AcpCommonLib.IAcpFeatureNode acpFeatureNode3 = enumerator.Current;
									num = (short)1226440708;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 4:
								{
									global::AcpCommonLib.IAcpFeatureNode acpFeatureNode3;
									if ((acpFeatureNode3[10080] as global::Motorola.MackinawCPS.CoreFeatures.RemoteSpeakerMic.RSMButtonInnerSection).RadErgoCfgRSMConventionalBCO_A19639.Value != 151)
									{
										num = (short)1878458368;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									break;
								}
								case 5:
									goto IL_2073;
								case 6:
									switch (0)
									{
									case 0:
										goto IL_1F48;
									}
									continue;
								case 7:
								{
									global::AcpCommonLib.IAcpFeatureNode acpFeatureNode3;
									if ((acpFeatureNode3[10080] as global::Motorola.MackinawCPS.CoreFeatures.RemoteSpeakerMic.RSMButtonInnerSection).RadErgoCfgRSMlConventionalFeature_A19640.Value == 31)
									{
										num = (short)742326274;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									break;
								}
								case 8:
									goto IL_1F65;
								}
								IL_201B:
								num = (short)730136579;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								IL_1F48:
								goto IL_201B;
							}
							IL_1F65:
							IL_2073:
							goto IL_AE4;
						}
						finally
						{
							num = (short)290062338;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								switch (num2)
								{
								case 0:
									goto IL_20E3;
								case 1:
									enumerator.Dispose();
									num = (short)1554382848;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 2:
									switch (0)
									{
									case 0:
										goto IL_20AB;
									}
									continue;
								}
								IL_20AB:
								if (enumerator == null)
								{
									break;
								}
								num = (short)1569456129;
								num2 = (int)((global::System.IntPtr)num);
							}
							IL_20E3:;
						}
						goto IL_20E6;
						IL_AE4:
						num = (short)145358872;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 59:
						flag2 = true;
						goto IL_2186;
					case 60:
						num = (short)1843068937;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 61:
					{
						global::Motorola.MackinawCPS.CoreFeatures.MenuItems.MenuItems menuItems3;
						if (num8 >= menuItems3.General.DispMenuConventionalSelectedMenuItems_A21736.Items.Count)
						{
							num = (short)1931214849;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)737149035;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 62:
						goto IL_726;
					case 63:
						enumerator = rsmbuttonInnerRecset.GetEnumerator();
						num = (short)1839464456;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 64:
						if (flag)
						{
							num = (short)2134376557;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return flag;
					case 65:
						flag3 = (switchConventionalSwitchesPosition1_A.Value != 29);
						goto IL_D35;
					case 66:
						if (switchConventionalSwitchesPosition2_A.Value != 26)
						{
							num = (short)1014104165;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_14DD;
					case 67:
						num = (short)2067857455;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 68:
						goto IL_2486;
					case 69:
						if (flag)
						{
							num = (short)1707737214;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_149E;
					case 70:
						goto IL_687;
					case 71:
						return flag;
					case 72:
						flag4 = (switchConventionalSwitchesPosition1_A.Value != 30);
						goto IL_1E0A;
					case 73:
						goto IL_20E6;
					case 74:
						if (index != 81)
						{
							num = (short)1002569813;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_EEB;
					case 75:
						goto IL_1324;
					case 76:
						if (num6 != 30)
						{
							num = (short)1481179204;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)1852964891;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 77:
						goto IL_2128;
					case 78:
						num = (short)136708162;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 79:
						num = (short)375783435;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 80:
						enumerator = portableButtonInnerRecset.GetEnumerator();
						num = (short)1862271087;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 81:
						num = (short)2050359361;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 82:
					{
						global::Motorola.MackinawCPS.CoreFeatures.MenuItems.MenuItems menuItems2;
						if (menuItems2.General.DispMenuConventionalSelectedMenuItems_A21736.Items[num7].ItemName == global::CommonResources.AcgResources.ID_DIR)
						{
							num = (short)1242431490;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_F59;
					}
					case 83:
						if (flag)
						{
							num = (short)428015729;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_CF9;
					case 84:
						if (num6 != 29)
						{
							num = (short)1442971729;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)1391722510;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 85:
						num = (short)1458896911;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 86:
						enumerator = portableButtonInnerRecset.GetEnumerator();
						num = (short)1383661683;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 87:
						num = (short)367591429;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 88:
						if (flag)
						{
							num = (short)1072234591;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_2128;
					case 89:
						return flag;
					case 90:
						goto IL_15BF;
					case 91:
						if (flag)
						{
							num = (short)192151604;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_1918;
					case 92:
						if (flag)
						{
							num = (short)429850704;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_BB2;
					case 93:
						return flag;
					case 94:
					{
						num = (short)544407552;
						short num9 = num;
						num = (short)246939771;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 95:
					{
						global::AcpCommonLib.IAcpRecordset feature2 = global::AcpCommonLib.FeatureManager.GetFeature(2088);
						num = (short)328794128;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 96:
						if (feature3 != null)
						{
							num = (short)1956380776;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return flag;
					case 97:
						return flag;
					case 98:
						num = (short)807665696;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 99:
					{
						global::Motorola.MackinawCPS.CoreFeatures.MenuItems.MenuItems menuItems2 = feature3[0] as global::Motorola.MackinawCPS.CoreFeatures.MenuItems.MenuItems;
						num7 = 0;
						num = (short)1789394978;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 100:
						goto IL_10F7;
					case 101:
						num = (short)716243060;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 102:
						if (feature3.Count != 0)
						{
							num = (short)2048065630;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return flag;
					case 103:
						num = (short)1959919622;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 104:
						num = (short)2044788838;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 105:
						if (switchConventionalSwitchesPosition1_A.Value != 33)
						{
							num = (short)975568983;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_184B;
					case 106:
						if (index != 61)
						{
							num = (short)824574006;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_A94;
					case 107:
					{
						global::Motorola.MackinawCPS.CoreFeatures.MenuItems.MenuItems menuItems3;
						if (menuItems3.General.DispMenuConventionalSelectedMenuItems_A21736.Items[num8].ItemName == global::CommonResources.AcgResources.ID_SCNL)
						{
							num = (short)759758901;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_726;
					}
					case 108:
						flag5 = false;
						goto IL_22B3;
					case 109:
						goto IL_1B6D;
					case 110:
						try
						{
							num = (short)929824772;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								switch (num2)
								{
								case 0:
								{
									global::AcpCommonLib.IAcpFeatureNode acpFeatureNode4;
									num6 = (acpFeatureNode4[10082] as global::Motorola.MackinawCPS.CoreFeatures.Switches.RotaryControlInnerSection).SwitchGeneralRotaryControl_A8984.Value;
									num = (short)301400065;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 1:
									goto IL_23F6;
								case 2:
									goto IL_2413;
								case 3:
									num = (short)1874591746;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 4:
									switch (0)
									{
									case 0:
										goto IL_2335;
									}
									continue;
								case 5:
								{
									if (!enumerator.MoveNext())
									{
										num = (short)379650051;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									global::AcpCommonLib.IAcpFeatureNode acpFeatureNode4 = enumerator.Current;
									num = (short)2015166470;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 6:
								{
									global::AcpCommonLib.IAcpFeatureNode acpFeatureNode4;
									if ((acpFeatureNode4.Parent as global::AcpBusinessLayer.Recordset).IndexOf(acpFeatureNode4) == 0)
									{
										num = (short)323485696;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									break;
								}
								}
								IL_2382:
								num = (short)2074279941;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								IL_2335:
								goto IL_2382;
							}
							IL_23F6:
							IL_2413:
							goto IL_1995;
						}
						finally
						{
							num = (short)924254210;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								switch (num2)
								{
								case 0:
									goto IL_2483;
								case 1:
									enumerator.Dispose();
									num = (short)1740767232;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 2:
									switch (0)
									{
									case 0:
										goto IL_244A;
									}
									continue;
								}
								IL_244A:
								if (enumerator == null)
								{
									break;
								}
								num = (short)297336833;
								num2 = (int)((global::System.IntPtr)num);
							}
							IL_2483:;
						}
						goto IL_2486;
						IL_1995:
						num = (short)1458962516;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 111:
						try
						{
							num = (short)1000931329;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								switch (num2)
								{
								case 0:
									if (!enumerator.MoveNext())
									{
										num = (short)856883202;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									num = (short)2116419588;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 1:
									switch (0)
									{
									case 0:
										goto IL_92D;
									}
									continue;
								case 2:
									num = (short)548667398;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 3:
									flag = false;
									num = (short)1193803781;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 4:
								{
									global::AcpBusinessLayer.FeatureNode featureNode2 = enumerator.Current;
									if ((((global::AcpCommonLib.IAcpFeatureNode)featureNode2)[10092] as global::Motorola.MackinawCPS.CoreFeatures.Buttons.PortableButtonInnerSection).BtnGeneralConventionalFeature_A19544.Value == 33)
									{
										flag = false;
									}
									if ((((global::AcpCommonLib.IAcpFeatureNode)featureNode2)[10092] as global::Motorola.MackinawCPS.CoreFeatures.Buttons.PortableButtonInnerSection).BtnTrunkingPortableButtonFeature_A19546.Value == 33)
									{
										num = (short)1548288003;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									break;
								}
								case 6:
									goto IL_A21;
								}
								IL_990:
								num = (short)1524498432;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								IL_92D:
								goto IL_990;
							}
							IL_A21:
							goto IL_BB2;
						}
						finally
						{
							num = (short)1618542593;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								switch (num2)
								{
								case 0:
									enumerator.Dispose();
									num = (short)1023737858;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 1:
									switch (0)
									{
									case 0:
										goto IL_A59;
									}
									continue;
								case 2:
									goto IL_A91;
								}
								IL_A59:
								if (enumerator == null)
								{
									break;
								}
								num = (short)1450180608;
								num2 = (int)((global::System.IntPtr)num);
							}
							IL_A91:;
						}
						goto IL_A94;
					case 112:
						flag = false;
						num = (short)174981242;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 113:
						enumerator = smartKeyFobButtonTableInnerRecset.GetEnumerator();
						num = (short)1586561074;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 114:
						if (switchConventionalSwitchesPosition1_A.Value != 26)
						{
							num = (short)1475412046;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_14DD;
					case 115:
						try
						{
							num = (short)1935147011;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								switch (num2)
								{
								case 0:
								{
									global::AcpCommonLib.IAcpFeatureNode acpFeatureNode5;
									if ((acpFeatureNode5[10092] as global::Motorola.MackinawCPS.CoreFeatures.Buttons.PortableButtonInnerSection).BtnGeneralConventionalBCO_A19543.Value != 148)
									{
										num = (short)1885274118;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									break;
								}
								case 1:
									num = (short)1723072520;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 2:
								{
									if (!enumerator.MoveNext())
									{
										num = (short)672595969;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									global::AcpCommonLib.IAcpFeatureNode acpFeatureNode5 = enumerator.Current;
									num = (short)1934753792;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 3:
									switch (0)
									{
									case 0:
										goto IL_40B;
									}
									continue;
								case 4:
								{
									global::AcpCommonLib.IAcpFeatureNode acpFeatureNode5;
									if ((acpFeatureNode5[10092] as global::Motorola.MackinawCPS.CoreFeatures.Buttons.PortableButtonInnerSection).BtnGeneralConventionalFeature_A19544.Value == 31)
									{
										num = (short)1581252613;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									break;
								}
								case 5:
									flag = false;
									num = (short)1578041351;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 6:
									num = (short)1035730948;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 7:
									goto IL_483;
								case 8:
									goto IL_534;
								}
								IL_488:
								num = (short)363855874;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								IL_40B:
								goto IL_488;
							}
							IL_483:
							IL_534:
							goto IL_18C8;
						}
						finally
						{
							num = (short)795672577;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								switch (num2)
								{
								case 0:
									enumerator.Dispose();
									num = (short)334757890;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 1:
									switch (0)
									{
									case 0:
										goto IL_56B;
									}
									continue;
								case 2:
									goto IL_5A6;
								}
								IL_56B:
								if (enumerator == null)
								{
									break;
								}
								num = (short)643039232;
								num2 = (int)((global::System.IntPtr)num);
							}
							IL_5A6:;
						}
						goto IL_5A9;
					case 116:
						if (switchConventionalSwitchesPosition4_A.Value != 26)
						{
							num = (short)1164836962;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_14DD;
					case 117:
						if (index != 195)
						{
							num = (short)646185003;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						flag = false;
						num = (short)951386201;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 118:
						if (conventionalSwitches.RefRadioErgonomicsWide.Advanced.RadErgoWideAdvancedToggleSwitchLockEnable_43773.Value)
						{
							num = (short)1030815856;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return flag;
					case 119:
						goto IL_1366;
					case 120:
						goto IL_C49;
					case 121:
						goto IL_C49;
					case 122:
						return flag;
					case 123:
						if (!global::ConstraintHelper.UtilityMack.IsMobile())
						{
							num = (short)9240675;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return flag;
					case 124:
					{
						global::Motorola.MackinawCPS.CoreFeatures.MenuItems.MenuItems menuItems;
						if (num3 >= menuItems.General.DispMenuConventionalSelectedMenuItems_A21736.Items.Count)
						{
							num = (short)1001259033;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)581107839;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 125:
					{
						global::AcpCommonLib.IAcpRecordset feature;
						global::Motorola.MackinawCPS.CoreFeatures.MenuItems.MenuItems menuItems3 = feature[0] as global::Motorola.MackinawCPS.CoreFeatures.MenuItems.MenuItems;
						num8 = 0;
						num = (short)1210974329;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 126:
						enumerator = smartKeyFobButtonTableInnerRecset.GetEnumerator();
						num = (short)814350367;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 127:
					{
						global::Motorola.MackinawCPS.CoreFeatures.MenuItems.MenuItems menuItems;
						if (menuItems.General.DispMenuConventionalSelectedMenuItems_A21736.Items[num3].ItemName == global::CommonResources.AcgResources.ID_SCAN)
						{
							num = (short)1521156124;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_687;
					}
					}
					goto IL_22F;
					IL_5A9:
					num = (short)1331036284;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_687:
					num3++;
					num = (short)252248086;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_6AA:
					num = (short)1893269595;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_726:
					num8++;
					num = (short)1029111928;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_A94:
					num = (short)2041380899;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_BB2:
					num = (short)213516311;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_C49:
					num = (short)353108029;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_CF9:
					num = (short)10092636;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_D35:
					flag = flag3;
					num = (short)1972043813;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_EEB:
					flag = false;
					num = (short)121045004;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_F59:
					num7++;
					num = (short)1274085495;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_10F7:
					num = (short)1705115684;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_1324:
					num = (short)1987575925;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_1366:
					num = (short)1769537577;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_149E:
					num = (short)13369408;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_14DD:
					num = (short)1506148460;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_15BF:
					num = (short)1882587156;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_17E5:
					enumerator = rotaryControlInnerRecset.GetEnumerator();
					num = (short)185794598;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_184B:
					num = (short)45678641;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_18C8:
					num = (short)1099694198;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_1918:
					num = (short)1117782085;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_1B6D:
					feature3 = global::AcpCommonLib.FeatureManager.GetFeature(2088);
					num = (short)552075360;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_1BB6:
					num4++;
					num = (short)1801650209;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_1E0A:
					flag = flag4;
					num = (short)430047303;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_20E6:
					num = (short)921763897;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_2128:
					num = (short)2067071059;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_2186:
					flag = flag2;
					num = (short)1068433496;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_22B3:
					flag = flag5;
					num = (short)1352007699;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_2486:
					num = (short)592511048;
					num2 = (int)((global::System.IntPtr)num);
				}
				return flag;
				IL_22F:
				conventionalSwitches = (self as global::Motorola.MackinawCPS.CoreFeatures.Switches.ConventionalSwitches);
				global::AcpCommonLib.IAcpFeatureNode parent = self.Parent;
				switchConventionalSwitchesPosition1_A = conventionalSwitches.SwitchConventionalSwitchesPosition1_A7734;
				switchConventionalSwitchesPosition2_A = conventionalSwitches.SwitchConventionalSwitchesPosition2_A7735;
				switchConventionalSwitchesPosition4_A = conventionalSwitches.SwitchConventionalSwitchesPosition4_A21530;
				switchConventionalSwitchesPosition5_A = conventionalSwitches.SwitchConventionalSwitchesPosition5_A21531;
				rotaryControlInnerRecset = ((global::AcpCommonLib.FeatureManager.GetFeature(2038) as global::Motorola.MackinawCPS.CoreFeatures.Switches.SwitchesRecset)[0][10081].EmbeddedRecset as global::Motorola.MackinawCPS.CoreFeatures.Switches.RotaryControlInnerRecset);
				portableButtonInnerRecset = ((global::AcpCommonLib.FeatureManager.GetFeature(2042) as global::Motorola.MackinawCPS.CoreFeatures.Buttons.ButtonsRecset)[0][10091].EmbeddedRecset as global::Motorola.MackinawCPS.CoreFeatures.Buttons.PortableButtonInnerRecset);
				rsmbuttonInnerRecset = ((global::AcpCommonLib.FeatureManager.GetFeature(2036) as global::Motorola.MackinawCPS.CoreFeatures.RemoteSpeakerMic.RemoteSpeakerMicRecset)[0][10079].EmbeddedRecset as global::Motorola.MackinawCPS.CoreFeatures.RemoteSpeakerMic.RSMButtonInnerRecset);
				smartKeyFobButtonTableInnerRecset = ((global::AcpCommonLib.FeatureManager.GetFeature(4130) as global::Motorola.MackinawCPS.CoreFeatures.SmartKeyFob.SmartKeyFobRecset)[0][10747].EmbeddedRecset as global::Motorola.MackinawCPS.CoreFeatures.SmartKeyFob.SmartKeyFobButtonTableInnerRecset);
				flag = true;
				num6 = 0;
				num = (short)643170304;
				num2 = (int)((global::System.IntPtr)num);
				goto IL_28;
			}
			}
		}

		// Token: 0x060073A8 RID: 29608 RVA: 0x006722F4 File Offset: 0x006704F4
		internal static bool ConSwitchesCnvPos4(global::AcpCommonLib.IAcpFeatureSection self, int index)
		{
			short num = (short)1561395200;
			int num2 = (int)num;
			switch (num2)
			{
			default:
			{
				switch (0)
				{
				case 0:
					goto IL_257;
				}
				bool flag;
				global::AcpBusinessLayer.AcpListField switchConventionalSwitchesPosition3_A;
				global::Motorola.MackinawCPS.CoreFeatures.SmartKeyFob.SmartKeyFobButtonTableInnerRecset smartKeyFobButtonTableInnerRecset;
				global::AcpBusinessLayer.AcpListField switchConventionalSwitchesPosition2_A;
				global::Motorola.MackinawCPS.CoreFeatures.Switches.ConventionalSwitches conventionalSwitches;
				global::AcpBusinessLayer.AcpListField switchTrunkingSwitchesPosition5_A;
				global::Motorola.MackinawCPS.CoreFeatures.RemoteSpeakerMic.RSMButtonInnerRecset rsmbuttonInnerRecset;
				global::AcpBusinessLayer.AcpListField switchConventionalSwitchesPosition5_A;
				global::AcpBusinessLayer.AcpListField switchTrunkingSwitchesPosition3_A;
				global::Motorola.MackinawCPS.CoreFeatures.Buttons.PortableButtonInnerRecset portableButtonInnerRecset;
				global::AcpBusinessLayer.AcpListField switchTrunkingSwitchesPosition4_A;
				global::AcpBusinessLayer.AcpListField switchConventionalSwitchesPosition1_A;
				for (;;)
				{
					IL_28:
					global::System.Collections.Generic.IEnumerator<global::AcpBusinessLayer.FeatureNode> enumerator;
					int num3;
					int num4;
					bool flag2;
					bool flag3;
					bool flag4;
					int num6;
					global::AcpCommonLib.IAcpRecordset feature3;
					global::Motorola.MackinawCPS.CoreFeatures.MenuItems.MenuItems menuItems3;
					int num7;
					bool flag5;
					switch (num2)
					{
					case 0:
						num = (short)468516922;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 1:
						try
						{
							num = (short)134152195;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								switch (num2)
								{
								case 0:
									flag = false;
									num = (short)1972830214;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 1:
									num = (short)1293287426;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 2:
									goto IL_1317;
								case 3:
									switch (0)
									{
									case 0:
										goto IL_124F;
									}
									continue;
								case 4:
									if (!enumerator.MoveNext())
									{
										num = (short)1911029761;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									num = (short)1062666245;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 5:
									if ((((global::AcpCommonLib.IAcpFeatureNode)enumerator.Current)[10748] as global::Motorola.MackinawCPS.CoreFeatures.SmartKeyFob.SmartKeyFobButtonTableInnerSection).RadErgoCfgFobConventionalFeature_A41574.Value == 26)
									{
										num = (short)155648000;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									break;
								case 6:
									goto IL_129F;
								}
								IL_1251:
								num = (short)407568388;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								IL_124F:
								goto IL_1251;
							}
							IL_129F:
							IL_1317:
							goto IL_E62;
						}
						finally
						{
							num = (short)722141184;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								switch (num2)
								{
								case 0:
									switch (0)
									{
									case 0:
										goto IL_1350;
									}
									continue;
								case 1:
									goto IL_1387;
								case 2:
									enumerator.Dispose();
									num = (short)1051197441;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								IL_1350:
								if (enumerator == null)
								{
									break;
								}
								num = (short)303300610;
								num2 = (int)((global::System.IntPtr)num);
							}
							IL_1387:;
						}
						goto IL_138A;
					case 2:
						num = (short)1023475824;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 3:
					{
						global::Motorola.MackinawCPS.CoreFeatures.MenuItems.MenuItems menuItems;
						if (num3 >= menuItems.General.DispMenuConventionalSelectedMenuItems_A21736.Items.Count)
						{
							num = (short)851509250;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)1824391196;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 4:
						if (switchConventionalSwitchesPosition3_A.Value != 26)
						{
							num = (short)313589879;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_5F5;
					case 5:
						num4 = 0;
						num = (short)381157394;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 6:
						if (flag)
						{
							num = (short)131989558;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return flag;
					case 7:
						goto IL_956;
					case 8:
						num = (short)1771176002;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 9:
						return flag;
					case 10:
						flag = false;
						num = (short)295567473;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 11:
						switch (index)
						{
						case 26:
							num = (short)2037317743;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 27:
							flag = false;
							num = (short)1178927176;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 28:
						case 31:
						case 32:
							return flag;
						case 29:
							goto IL_138A;
						case 30:
							num = (short)742195330;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 33:
							num = (short)1402470516;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						default:
							num = (short)1886126190;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						break;
					case 12:
					{
						global::AcpCommonLib.IAcpRecordset feature = global::AcpCommonLib.FeatureManager.GetFeature(2088);
						num = (short)987431020;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 13:
						if (!global::ConstraintHelper.UtilityMack.IsMobile())
						{
							num = (short)505938018;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return flag;
					case 14:
						enumerator = smartKeyFobButtonTableInnerRecset.GetEnumerator();
						num = (short)2124349441;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 15:
					{
						global::AcpCommonLib.IAcpRecordset feature2;
						if (feature2 != null)
						{
							num = (short)1516896340;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return flag;
					}
					case 16:
						goto IL_1FCA;
					case 17:
						num = (short)1447231589;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 18:
						goto IL_C7E;
					case 19:
						num = (short)1583677514;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 20:
						try
						{
							num = (short)41811976;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								switch (num2)
								{
								case 0:
								{
									if (!enumerator.MoveNext())
									{
										num = (short)872742914;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									global::AcpCommonLib.IAcpFeatureNode acpFeatureNode = enumerator.Current;
									num = (short)1400569857;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 1:
								{
									global::AcpCommonLib.IAcpFeatureNode acpFeatureNode;
									if ((acpFeatureNode[10080] as global::Motorola.MackinawCPS.CoreFeatures.RemoteSpeakerMic.RSMButtonInnerSection).RadErgoCfgRSMConventionalBCO_A19639.Value != 151)
									{
										num = (short)133627909;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									break;
								}
								case 2:
									num = (short)1186201606;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 3:
								{
									global::AcpCommonLib.IAcpFeatureNode acpFeatureNode;
									if ((acpFeatureNode[10080] as global::Motorola.MackinawCPS.CoreFeatures.RemoteSpeakerMic.RSMButtonInnerSection).RadErgoCfgRSMlConventionalFeature_A19640.Value == 31)
									{
										num = (short)31326215;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									break;
								}
								case 4:
									goto IL_4BF;
								case 5:
									num = (short)591921155;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 6:
									goto IL_530;
								case 7:
									flag = false;
									num = (short)1873543172;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 8:
									switch (0)
									{
									case 0:
										goto IL_409;
									}
									continue;
								}
								IL_40B:
								num = (short)463601664;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								IL_409:
								goto IL_40B;
							}
							IL_4BF:
							IL_530:
							goto IL_1C2E;
						}
						finally
						{
							num = (short)274792450;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								switch (num2)
								{
								case 0:
									goto IL_5A0;
								case 1:
									enumerator.Dispose();
									num = (short)1769013248;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 2:
									switch (0)
									{
									case 0:
										goto IL_569;
									}
									continue;
								}
								IL_569:
								if (enumerator == null)
								{
									break;
								}
								num = (short)2038562817;
								num2 = (int)((global::System.IntPtr)num);
							}
							IL_5A0:;
						}
						goto IL_5A3;
						IL_1C2E:
						num = (short)325124137;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 21:
						try
						{
							num = (short)735117315;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								switch (num2)
								{
								case 0:
									num = (short)627834882;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 1:
									if ((((global::AcpCommonLib.IAcpFeatureNode)enumerator.Current)[10092] as global::Motorola.MackinawCPS.CoreFeatures.Buttons.PortableButtonInnerSection).BtnGeneralConventionalFeature_A19544.Value == 26)
									{
										num = (short)87818246;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									break;
								case 2:
									goto IL_1103;
								case 3:
									switch (0)
									{
									case 0:
										goto IL_1040;
									}
									continue;
								case 5:
									if (!enumerator.MoveNext())
									{
										num = (short)834600960;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									num = (short)451149825;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 6:
									flag = false;
									num = (short)63569924;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								IL_10AF:
								num = (short)85786629;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								IL_1040:
								goto IL_10AF;
							}
							IL_1103:
							goto IL_6D0;
						}
						finally
						{
							num = (short)1320747008;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								switch (num2)
								{
								case 0:
									switch (0)
									{
									case 0:
										goto IL_113A;
									}
									continue;
								case 1:
									goto IL_1171;
								case 2:
									enumerator.Dispose();
									num = (short)1261764609;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								IL_113A:
								if (enumerator == null)
								{
									break;
								}
								num = (short)1350041602;
								num2 = (int)((global::System.IntPtr)num);
							}
							IL_1171:;
						}
						goto IL_1174;
					case 22:
						if (switchConventionalSwitchesPosition3_A.Value == 30)
						{
							num = (short)215220266;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_FE3;
					case 23:
						if (flag)
						{
							num = (short)1358889023;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_D77;
					case 24:
						goto IL_1F68;
					case 25:
						if (flag)
						{
							num = (short)1692205181;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_6D0;
					case 26:
						if (switchConventionalSwitchesPosition2_A.Value != 26)
						{
							num = (short)1712652402;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_5F5;
					case 27:
					{
						num = (short)1192886272;
						short num5 = num;
						num = (short)1754988672;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 28:
					{
						global::Motorola.MackinawCPS.CoreFeatures.MenuItems.MenuItems menuItems;
						if (menuItems.General.DispMenuConventionalSelectedMenuItems_A21736.Items[num3].ItemName == global::CommonResources.AcgResources.ID_DIR)
						{
							num = (short)1416953937;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_CD2;
					}
					case 29:
						return flag;
					case 30:
						try
						{
							num = (short)2052325379;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								switch (num2)
								{
								case 0:
									num = (short)1825439746;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 2:
									goto IL_1619;
								case 3:
									switch (0)
									{
									case 0:
										goto IL_1525;
									}
									continue;
								case 4:
								{
									global::AcpBusinessLayer.FeatureNode featureNode = enumerator.Current;
									if ((((global::AcpCommonLib.IAcpFeatureNode)featureNode)[10080] as global::Motorola.MackinawCPS.CoreFeatures.RemoteSpeakerMic.RSMButtonInnerSection).RadErgoCfgRSMlConventionalFeature_A19640.Value == 33)
									{
										flag = false;
									}
									if ((((global::AcpCommonLib.IAcpFeatureNode)featureNode)[10080] as global::Motorola.MackinawCPS.CoreFeatures.RemoteSpeakerMic.RSMButtonInnerSection).RadErgoCfgRSMlTrunkingFeature_A19742.Value == 33)
									{
										num = (short)1942552582;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									break;
								}
								case 5:
									if (!enumerator.MoveNext())
									{
										num = (short)169213952;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									num = (short)1760952324;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 6:
									flag = false;
									num = (short)1763835905;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								IL_15BF:
								num = (short)924188677;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								IL_1525:
								goto IL_15BF;
							}
							IL_1619:
							return flag;
						}
						finally
						{
							num = (short)1058340864;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								switch (num2)
								{
								case 0:
									switch (0)
									{
									case 0:
										goto IL_1652;
									}
									continue;
								case 1:
									goto IL_168C;
								case 2:
									enumerator.Dispose();
									num = (short)192806913;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								IL_1652:
								if (enumerator == null)
								{
									break;
								}
								num = (short)1679753218;
								num2 = (int)((global::System.IntPtr)num);
							}
							IL_168C:;
						}
						goto IL_168F;
					case 31:
						num3 = 0;
						num = (short)546504777;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 32:
						flag2 = true;
						goto IL_1B2F;
					case 33:
						goto IL_C7E;
					case 34:
						if (!global::ConstraintHelper.UtilityMack.IsMobile())
						{
							num = (short)561840159;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return flag;
					case 35:
						if (conventionalSwitches.RefRadioErgonomicsWide.Advanced.RadErgoWideAdvancedSideButtonsLockEnable_A38725.Value)
						{
							num = (short)2043609191;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_176B;
					case 36:
						flag = false;
						num = (short)1815871512;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 37:
						return flag;
					case 38:
						try
						{
							num = (short)1410203657;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								switch (num2)
								{
								case 0:
									num = (short)15007751;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 1:
								{
									if (!enumerator.MoveNext())
									{
										num = (short)463273984;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									global::AcpCommonLib.IAcpFeatureNode acpFeatureNode2 = enumerator.Current;
									num = (short)1389494274;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 2:
								{
									global::AcpCommonLib.IAcpFeatureNode acpFeatureNode2;
									if ((acpFeatureNode2[10748] as global::Motorola.MackinawCPS.CoreFeatures.SmartKeyFob.SmartKeyFobButtonTableInnerSection).RadErgoCfgFobConventionalFeature_A41574.Value == 33)
									{
										num = (short)1071972356;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									num = (short)720371718;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 3:
									goto IL_B13;
								case 4:
									flag = false;
									num = (short)1364262915;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 5:
									flag = false;
									num = (short)909836296;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 6:
								{
									global::AcpCommonLib.IAcpFeatureNode acpFeatureNode2;
									if ((acpFeatureNode2[10748] as global::Motorola.MackinawCPS.CoreFeatures.SmartKeyFob.SmartKeyFobButtonTableInnerSection).RadErgoCfgFobTrunkingFeature_A41575.Value == 33)
									{
										num = (short)252248069;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									break;
								}
								case 7:
									goto IL_C0A;
								case 8:
									goto IL_BEC;
								case 9:
									switch (0)
									{
									case 0:
										goto IL_ABA;
									}
									continue;
								}
								IL_ABC:
								num = (short)136577025;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								IL_ABA:
								goto IL_ABC;
							}
							IL_B13:
							IL_BEC:
							IL_C0A:
							goto IL_201D;
						}
						finally
						{
							num = (short)1549664258;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								switch (num2)
								{
								case 0:
									goto IL_C7B;
								case 1:
									enumerator.Dispose();
									num = (short)1363148800;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 2:
									switch (0)
									{
									case 0:
										goto IL_C42;
									}
									continue;
								}
								IL_C42:
								if (enumerator == null)
								{
									break;
								}
								num = (short)1743192065;
								num2 = (int)((global::System.IntPtr)num);
							}
							IL_C7B:;
						}
						goto IL_C7E;
					case 39:
						num = (short)1052377110;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 40:
						flag3 = (switchTrunkingSwitchesPosition5_A.Value == 30);
						goto IL_F99;
					case 41:
						if (flag)
						{
							num = (short)737149065;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_176B;
					case 42:
						num = (short)1584070726;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 43:
						goto IL_956;
					case 44:
						flag4 = false;
						goto IL_1E1C;
					case 45:
						return flag;
					case 46:
						try
						{
							num = (short)974323717;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								switch (num2)
								{
								case 1:
									flag = false;
									num = (short)772014080;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 2:
									goto IL_2423;
								case 3:
									if (!enumerator.MoveNext())
									{
										num = (short)232456198;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									num = (short)588316676;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 4:
								{
									global::AcpBusinessLayer.FeatureNode featureNode2 = enumerator.Current;
									if ((((global::AcpCommonLib.IAcpFeatureNode)featureNode2)[10092] as global::Motorola.MackinawCPS.CoreFeatures.Buttons.PortableButtonInnerSection).BtnGeneralConventionalFeature_A19544.Value == 33)
									{
										flag = false;
									}
									if ((((global::AcpCommonLib.IAcpFeatureNode)featureNode2)[10092] as global::Motorola.MackinawCPS.CoreFeatures.Buttons.PortableButtonInnerSection).BtnTrunkingPortableButtonFeature_A19546.Value == 33)
									{
										num = (short)646512641;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									break;
								}
								case 5:
									switch (0)
									{
									case 0:
										goto IL_2334;
									}
									continue;
								case 6:
									num = (short)1425211394;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								IL_2336:
								num = (short)1993605123;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								IL_2334:
								goto IL_2336;
							}
							IL_2423:
							goto IL_1E99;
						}
						finally
						{
							num = (short)528941058;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								switch (num2)
								{
								case 0:
									enumerator.Dispose();
									num = (short)908132353;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 1:
									goto IL_2491;
								case 2:
									switch (0)
									{
									case 0:
										goto IL_245A;
									}
									continue;
								}
								IL_245A:
								if (enumerator == null)
								{
									break;
								}
								num = (short)916783104;
								num2 = (int)((global::System.IntPtr)num);
							}
							IL_2491:;
						}
						return flag;
					case 47:
						return flag;
					case 48:
						num6 = 0;
						num = (short)1163329552;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 49:
						if (index != 81)
						{
							num = (short)1133314135;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						flag = false;
						num = (short)1785528329;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 50:
					{
						global::Motorola.MackinawCPS.CoreFeatures.MenuItems.MenuItems menuItems2;
						if (menuItems2.General.DispMenuConventionalSelectedMenuItems_A21736.Items[num4].ItemName == global::CommonResources.AcgResources.ID_SCAN)
						{
							num = (short)139853916;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_191B;
					}
					case 51:
						return flag;
					case 52:
					{
						global::AcpCommonLib.IAcpRecordset feature2;
						if (feature2.Count != 0)
						{
							num = (short)1351090272;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return flag;
					}
					case 53:
						goto IL_1FCA;
					case 54:
					{
						global::AcpCommonLib.IAcpRecordset feature2 = global::AcpCommonLib.FeatureManager.GetFeature(2088);
						num = (short)867106831;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 55:
						if (flag)
						{
							num = (short)1403715596;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_CF5;
					case 56:
						try
						{
							num = (short)2028273669;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								switch (num2)
								{
								case 0:
									goto IL_1ABB;
								case 1:
								{
									global::AcpCommonLib.IAcpFeatureNode acpFeatureNode3;
									if ((acpFeatureNode3[10092] as global::Motorola.MackinawCPS.CoreFeatures.Buttons.PortableButtonInnerSection).BtnGeneralConventionalBCO_A19543.Value != 148)
									{
										num = (short)994377736;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									break;
								}
								case 2:
									flag = false;
									num = (short)2124742663;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 3:
									num = (short)1409089536;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 4:
								{
									if (!enumerator.MoveNext())
									{
										num = (short)1830027267;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									global::AcpCommonLib.IAcpFeatureNode acpFeatureNode3 = enumerator.Current;
									num = (short)1508048897;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 5:
									switch (0)
									{
									case 0:
										goto IL_198B;
									}
									continue;
								case 6:
								{
									global::AcpCommonLib.IAcpFeatureNode acpFeatureNode3;
									if ((acpFeatureNode3[10092] as global::Motorola.MackinawCPS.CoreFeatures.Buttons.PortableButtonInnerSection).BtnGeneralConventionalFeature_A19544.Value == 31)
									{
										num = (short)2056192002;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									break;
								}
								case 7:
									goto IL_1A5E;
								case 8:
									num = (short)2121334790;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								IL_1A63:
								num = (short)1952645124;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								IL_198B:
								goto IL_1A63;
							}
							IL_1A5E:
							IL_1ABB:
							goto IL_176B;
						}
						finally
						{
							num = (short)246087680;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								switch (num2)
								{
								case 0:
									switch (0)
									{
									case 0:
										goto IL_1AF2;
									}
									continue;
								case 1:
									goto IL_1B2C;
								case 2:
									enumerator.Dispose();
									num = (short)1506017281;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								IL_1AF2:
								if (enumerator == null)
								{
									break;
								}
								num = (short)2132672514;
								num2 = (int)((global::System.IntPtr)num);
							}
							IL_1B2C:;
						}
						goto IL_1B2F;
					case 57:
						num = (short)677904491;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 58:
						return flag;
					case 59:
						if (conventionalSwitches.RefRadioErgonomicsWide.Advanced.RadErgoWideAdvancedToggleSwitchLockEnable_43773.Value)
						{
							num = (short)762577011;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return flag;
					case 60:
						num = (short)1119354917;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 61:
						if (index != 61)
						{
							num = (short)847183872;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_1174;
					case 62:
						num = (short)343539811;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 63:
						enumerator = rsmbuttonInnerRecset.GetEnumerator();
						num = (short)1961951355;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 64:
					{
						global::Motorola.MackinawCPS.CoreFeatures.MenuItems.MenuItems menuItems2;
						if (menuItems2.General.DispMenuTrunkingSelectedMenuItems_A21735.Items[num6].ItemName == global::CommonResources.AcgResources.ID_SCAN)
						{
							num = (short)698089508;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_1F68;
					}
					case 65:
						if (switchConventionalSwitchesPosition5_A.Value == 30)
						{
							num = (short)159318110;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_FE3;
					case 66:
						if (switchConventionalSwitchesPosition5_A.Value == 29)
						{
							num = (short)857407515;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_22D4;
					case 67:
						if (!global::ConstraintHelper.UtilityMack.IsMobile())
						{
							num = (short)1104871429;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_CF5;
					case 68:
						if (flag)
						{
							num = (short)526123022;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_E62;
					case 69:
						num = (short)251330571;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 70:
						if (switchTrunkingSwitchesPosition3_A.Value == 30)
						{
							num = (short)1664548993;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_FE3;
					case 71:
					{
						global::Motorola.MackinawCPS.CoreFeatures.MenuItems.MenuItems menuItems2;
						if (num4 >= menuItems2.General.DispMenuConventionalSelectedMenuItems_A21736.Items.Count)
						{
							num = (short)1858994224;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)437059634;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 72:
						return flag;
					case 73:
						goto IL_18A9;
					case 74:
					{
						global::AcpCommonLib.IAcpRecordset feature;
						if (feature.Count != 0)
						{
							num = (short)300810320;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_CF5;
					}
					case 75:
						goto IL_CD2;
					case 76:
						enumerator = smartKeyFobButtonTableInnerRecset.GetEnumerator();
						num = (short)1369374758;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 77:
						enumerator = portableButtonInnerRecset.GetEnumerator();
						num = (short)1348993070;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 78:
						if (feature3 != null)
						{
							num = (short)1440284729;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return flag;
					case 79:
						if (index != 46)
						{
							num = (short)207945830;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						feature3 = global::AcpCommonLib.FeatureManager.GetFeature(2088);
						num = (short)1075970126;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 80:
					{
						global::AcpCommonLib.IAcpRecordset feature;
						global::Motorola.MackinawCPS.CoreFeatures.MenuItems.MenuItems menuItems2 = feature[0] as global::Motorola.MackinawCPS.CoreFeatures.MenuItems.MenuItems;
						num = (short)2114715715;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 81:
						flag = false;
						num = (short)2139619403;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 82:
						num = (short)1286930520;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 83:
						num = (short)824508547;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 84:
						num = (short)1608319028;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 85:
						if (index != 194)
						{
							num = (short)656998534;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						flag = false;
						num = (short)865927197;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 86:
						if (index <= 61)
						{
							num = (short)1165426757;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)5767217;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 87:
						num = (short)944046165;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 88:
						if (switchConventionalSwitchesPosition3_A.Value == 29)
						{
							num = (short)326238225;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_22D4;
					case 89:
						flag4 = (switchConventionalSwitchesPosition5_A.Value != 26);
						goto IL_1E1C;
					case 90:
						num = (short)1030160516;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 91:
						flag2 = (switchConventionalSwitchesPosition5_A.Value != 33);
						goto IL_1B2F;
					case 92:
						flag = false;
						num = (short)1901396061;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 93:
						goto IL_191B;
					case 94:
						num = (short)290914344;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 95:
						if (menuItems3.General.DispMenuConventionalSelectedMenuItems_A21736.Items[num7].ItemName == global::CommonResources.AcgResources.ID_SCNL)
						{
							num = (short)1049493514;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_1FA7;
					case 96:
					{
						global::AcpCommonLib.IAcpRecordset feature2;
						global::Motorola.MackinawCPS.CoreFeatures.MenuItems.MenuItems menuItems = feature2[0] as global::Motorola.MackinawCPS.CoreFeatures.MenuItems.MenuItems;
						num = (short)1230110754;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 97:
					{
						global::Motorola.MackinawCPS.CoreFeatures.MenuItems.MenuItems menuItems2;
						if (num6 >= menuItems2.General.DispMenuTrunkingSelectedMenuItems_A21735.Items.Count)
						{
							num = (short)182648954;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)525664320;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 98:
						goto IL_5A3;
					case 99:
						return flag;
					case 100:
						if (flag)
						{
							num = (short)1310195788;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_201D;
					case 101:
						if (switchTrunkingSwitchesPosition3_A.Value == 29)
						{
							num = (short)809173000;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_22D4;
					case 102:
						num = (short)1299906621;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 103:
						goto IL_168F;
					case 104:
						if (index != 195)
						{
							num = (short)1772552254;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_2228;
					case 105:
						if (switchTrunkingSwitchesPosition4_A.Value == 29)
						{
							num = (short)1528561746;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_22D4;
					case 106:
						if (flag)
						{
							num = (short)1120600141;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_1E99;
					case 107:
						if (feature3.Count != 0)
						{
							num = (short)1586823292;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return flag;
					case 108:
					{
						num = (short)1421737985;
						if (num != 0)
						{
						}
						global::AcpCommonLib.IAcpRecordset feature;
						if (feature != null)
						{
							num = (short)176750611;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_CF5;
					}
					case 109:
						flag3 = false;
						goto IL_F99;
					case 110:
						num = (short)540147791;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 111:
						if (switchConventionalSwitchesPosition1_A.Value != 26)
						{
							num = (short)2043215998;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_5F5;
					case 112:
						return flag;
					case 113:
						goto IL_1FA7;
					case 114:
						num = (short)563871748;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 115:
						flag = false;
						num = (short)1583874099;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 116:
						if (switchConventionalSwitchesPosition1_A.Value != 33)
						{
							num = (short)994705491;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_E42;
					case 117:
						enumerator = rsmbuttonInnerRecset.GetEnumerator();
						num = (short)1513750558;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 118:
						flag2 = false;
						goto IL_1B2F;
					case 119:
						num = (short)220201049;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 120:
						num = (short)985858139;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 121:
						if (num7 >= menuItems3.General.DispMenuConventionalSelectedMenuItems_A21736.Items.Count)
						{
							num = (short)1180958780;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)802619487;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 122:
						goto IL_CF5;
					case 123:
						try
						{
							num = (short)880738307;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								switch (num2)
								{
								case 0:
									flag = false;
									goto IL_20DB;
								case 1:
									num = (short)450756610;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 2:
									goto IL_21B7;
								case 3:
									switch (0)
									{
									case 0:
										goto IL_209D;
									}
									continue;
								case 4:
									if (!enumerator.MoveNext())
									{
										num = (short)1683292161;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									num = (short)1734344709;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 5:
									if ((((global::AcpCommonLib.IAcpFeatureNode)enumerator.Current)[10080] as global::Motorola.MackinawCPS.CoreFeatures.RemoteSpeakerMic.RSMButtonInnerSection).RadErgoCfgRSMlConventionalFeature_A19640.Value == 26)
									{
										num = (short)379498425;
										short num8 = num;
										num = (short)490975161;
										switch ((num8 == num) ? 1 : 0)
										{
										case 0:
										case 2:
											goto IL_20DB;
										default:
											num = (short)1124270080;
											if (num != 0)
											{
											}
											num = (short)698482688;
											num2 = (int)((global::System.IntPtr)num);
											continue;
										}
									}
									break;
								}
								IL_209F:
								num = (short)368115716;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								IL_209D:
								goto IL_209F;
								IL_20DB:
								num = (short)303104006;
								num2 = (int)((global::System.IntPtr)num);
							}
							IL_21B7:
							goto IL_D77;
						}
						finally
						{
							num = (short)380502016;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								switch (num2)
								{
								case 0:
									switch (0)
									{
									case 0:
										goto IL_21EE;
									}
									continue;
								case 1:
									goto IL_2225;
								case 2:
									enumerator.Dispose();
									num = (short)966721537;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								IL_21EE:
								if (enumerator == null)
								{
									break;
								}
								num = (short)342491138;
								num2 = (int)((global::System.IntPtr)num);
							}
							IL_2225:;
						}
						goto IL_2228;
					case 124:
						num = (short)538771469;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 125:
						enumerator = portableButtonInnerRecset.GetEnumerator();
						num = (short)1445330965;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 126:
						num = (short)1089273882;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 127:
						return flag;
					case 128:
						flag5 = (switchTrunkingSwitchesPosition5_A.Value == 29);
						goto IL_D32;
					case 129:
						num = (short)742064193;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 130:
						if (switchTrunkingSwitchesPosition4_A.Value == 30)
						{
							num = (short)973340711;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_FE3;
					case 131:
						if (switchConventionalSwitchesPosition2_A.Value != 33)
						{
							num = (short)81330266;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_E42;
					case 132:
						if (switchConventionalSwitchesPosition3_A.Value == 33)
						{
							num = (short)1373175928;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)1026228256;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 133:
						flag5 = false;
						goto IL_D32;
					case 134:
						num = (short)761004136;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 135:
						if (flag)
						{
							num = (short)1625489525;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return flag;
					case 136:
						goto IL_18A9;
					case 137:
						enumerator = portableButtonInnerRecset.GetEnumerator();
						num = (short)660668472;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_257;
					IL_5A3:
					menuItems3 = (feature3[0] as global::Motorola.MackinawCPS.CoreFeatures.MenuItems.MenuItems);
					num7 = 0;
					num = (short)1964244999;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_5F5:
					num = (short)1316749356;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_6D0:
					num = (short)653852695;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_956:
					num = (short)530972793;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_C7E:
					num = (short)1747189831;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_CD2:
					num3++;
					num = (short)1689583752;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_CF5:
					num = (short)1110311012;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_D32:
					flag = flag5;
					num = (short)847511597;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_D77:
					num = (short)518651972;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_E42:
					num = (short)916848758;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_E62:
					num = (short)1288241158;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_F99:
					flag = flag3;
					num = (short)1628373039;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_FE3:
					num = (short)380633197;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_1174:
					num = (short)177012771;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_138A:
					num = (short)896794729;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_168F:
					enumerator = rsmbuttonInnerRecset.GetEnumerator();
					num = (short)1126367252;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_176B:
					num = (short)621936699;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_18A9:
					num = (short)1548943363;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_191B:
					num4++;
					num = (short)63176737;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_1B2F:
					flag = flag2;
					num = (short)1433468983;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_1E1C:
					flag = flag4;
					num = (short)2051670041;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_1E99:
					num = (short)1460535431;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_1F68:
					num6++;
					num = (short)1020395573;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_1FA7:
					num7++;
					num = (short)993329195;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_1FCA:
					num = (short)700383329;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_201D:
					num = (short)951058538;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_2228:
					flag = false;
					num = (short)1253507199;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_22D4:
					num = (short)735772805;
					num2 = (int)((global::System.IntPtr)num);
				}
				return flag;
				IL_257:
				conventionalSwitches = (self as global::Motorola.MackinawCPS.CoreFeatures.Switches.ConventionalSwitches);
				global::Motorola.MackinawCPS.CoreFeatures.Switches.Switches switches = self.Parent as global::Motorola.MackinawCPS.CoreFeatures.Switches.Switches;
				switchConventionalSwitchesPosition1_A = conventionalSwitches.SwitchConventionalSwitchesPosition1_A7734;
				switchConventionalSwitchesPosition2_A = conventionalSwitches.SwitchConventionalSwitchesPosition2_A7735;
				switchConventionalSwitchesPosition3_A = conventionalSwitches.SwitchConventionalSwitchesPosition3_A7737;
				switchConventionalSwitchesPosition5_A = conventionalSwitches.SwitchConventionalSwitchesPosition5_A21531;
				switchTrunkingSwitchesPosition3_A = switches.TrunkingSwitches.SwitchTrunkingSwitchesPosition3_A9468;
				switchTrunkingSwitchesPosition4_A = switches.TrunkingSwitches.SwitchTrunkingSwitchesPosition4_A21534;
				switchTrunkingSwitchesPosition5_A = switches.TrunkingSwitches.SwitchTrunkingSwitchesPosition5_A21535;
				portableButtonInnerRecset = ((global::AcpCommonLib.FeatureManager.GetFeature(2042) as global::Motorola.MackinawCPS.CoreFeatures.Buttons.ButtonsRecset)[0][10091].EmbeddedRecset as global::Motorola.MackinawCPS.CoreFeatures.Buttons.PortableButtonInnerRecset);
				rsmbuttonInnerRecset = ((global::AcpCommonLib.FeatureManager.GetFeature(2036) as global::Motorola.MackinawCPS.CoreFeatures.RemoteSpeakerMic.RemoteSpeakerMicRecset)[0][10079].EmbeddedRecset as global::Motorola.MackinawCPS.CoreFeatures.RemoteSpeakerMic.RSMButtonInnerRecset);
				smartKeyFobButtonTableInnerRecset = ((global::AcpCommonLib.FeatureManager.GetFeature(4130) as global::Motorola.MackinawCPS.CoreFeatures.SmartKeyFob.SmartKeyFobRecset)[0][10747].EmbeddedRecset as global::Motorola.MackinawCPS.CoreFeatures.SmartKeyFob.SmartKeyFobButtonTableInnerRecset);
				flag = true;
				num = (short)1683357782;
				num2 = (int)((global::System.IntPtr)num);
				goto IL_28;
			}
			}
		}

		// Token: 0x060073A9 RID: 29609 RVA: 0x0067485C File Offset: 0x00672A5C
		internal static bool ConSwitchesCnvPos5(global::AcpCommonLib.IAcpFeatureSection self, int index)
		{
			short num = (short)1690828800;
			int num2 = (int)num;
			switch (num2)
			{
			default:
			{
				switch (0)
				{
				case 0:
					goto IL_256;
				}
				bool flag;
				global::Motorola.MackinawCPS.CoreFeatures.Buttons.PortableButtonInnerRecset portableButtonInnerRecset;
				global::Motorola.MackinawCPS.CoreFeatures.RemoteSpeakerMic.RSMButtonInnerRecset rsmbuttonInnerRecset;
				global::Motorola.MackinawCPS.CoreFeatures.SmartKeyFob.SmartKeyFobButtonTableInnerRecset smartKeyFobButtonTableInnerRecset;
				global::AcpBusinessLayer.AcpListField switchConventionalSwitchesPosition3_A;
				global::AcpBusinessLayer.AcpListField switchTrunkingSwitchesPosition3_A;
				global::Motorola.MackinawCPS.CoreFeatures.Switches.ConventionalSwitches conventionalSwitches;
				global::AcpBusinessLayer.AcpListField switchTrunkingSwitchesPosition4_A;
				global::AcpBusinessLayer.AcpListField switchTrunkingSwitchesPosition5_A;
				global::AcpBusinessLayer.AcpListField switchConventionalSwitchesPosition4_A;
				global::AcpBusinessLayer.AcpListField switchConventionalSwitchesPosition1_A;
				global::AcpBusinessLayer.AcpListField switchConventionalSwitchesPosition2_A;
				for (;;)
				{
					IL_27:
					global::System.Collections.Generic.IEnumerator<global::AcpBusinessLayer.FeatureNode> enumerator;
					global::AcpCommonLib.IAcpRecordset feature;
					bool flag2;
					int num3;
					int num4;
					int num6;
					bool flag3;
					bool flag4;
					int num7;
					global::Motorola.MackinawCPS.CoreFeatures.MenuItems.MenuItems menuItems3;
					bool flag5;
					switch (num2)
					{
					case 0:
						flag = false;
						num = (short)81985663;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 1:
						if (index != 81)
						{
							num = (short)1482883168;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						flag = false;
						num = (short)791674977;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 2:
						num = (short)1714946153;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 3:
						if (flag)
						{
							num = (short)1904279619;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return flag;
					case 4:
						return flag;
					case 5:
						enumerator = portableButtonInnerRecset.GetEnumerator();
						num = (short)200278127;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 6:
						try
						{
							num = (short)1062273025;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								switch (num2)
								{
								case 0:
									if (!enumerator.MoveNext())
									{
										num = (short)1140129796;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									num = (short)977010694;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 1:
									switch (0)
									{
									case 0:
										goto IL_14AF;
									}
									continue;
								case 2:
									goto IL_15A5;
								case 3:
									flag = false;
									num = (short)866320389;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 4:
									num = (short)367067138;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 6:
								{
									global::AcpBusinessLayer.FeatureNode featureNode = enumerator.Current;
									if ((((global::AcpCommonLib.IAcpFeatureNode)featureNode)[10080] as global::Motorola.MackinawCPS.CoreFeatures.RemoteSpeakerMic.RSMButtonInnerSection).RadErgoCfgRSMlConventionalFeature_A19640.Value == 33)
									{
										flag = false;
									}
									if ((((global::AcpCommonLib.IAcpFeatureNode)featureNode)[10080] as global::Motorola.MackinawCPS.CoreFeatures.RemoteSpeakerMic.RSMButtonInnerSection).RadErgoCfgRSMlTrunkingFeature_A19742.Value == 33)
									{
										num = (short)561774595;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									break;
								}
								}
								IL_154D:
								num = (short)387448832;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								IL_14AF:
								goto IL_154D;
							}
							IL_15A5:
							return flag;
						}
						finally
						{
							num = (short)1286668290;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								switch (num2)
								{
								case 0:
									goto IL_1614;
								case 1:
									enumerator.Dispose();
									num = (short)242221056;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 2:
									switch (0)
									{
									case 0:
										goto IL_15DD;
									}
									continue;
								}
								IL_15DD:
								if (enumerator == null)
								{
									break;
								}
								num = (short)718077953;
								num2 = (int)((global::System.IntPtr)num);
							}
							IL_1614:;
						}
						goto IL_1617;
					case 7:
						goto IL_C35;
					case 8:
						goto IL_1617;
					case 9:
						if (index != 194)
						{
							num = (short)353370194;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						flag = false;
						num = (short)1129775137;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 10:
						if (feature.Count != 0)
						{
							num = (short)586809401;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return flag;
					case 11:
					{
						global::AcpCommonLib.IAcpRecordset feature2;
						if (feature2 != null)
						{
							num = (short)716570643;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return flag;
					}
					case 12:
						flag2 = false;
						goto IL_F1F;
					case 13:
						return flag;
					case 14:
						goto IL_180A;
					case 15:
						try
						{
							num = (short)932380673;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								switch (num2)
								{
								case 0:
									if ((((global::AcpCommonLib.IAcpFeatureNode)enumerator.Current)[10748] as global::Motorola.MackinawCPS.CoreFeatures.SmartKeyFob.SmartKeyFobButtonTableInnerSection).RadErgoCfgFobConventionalFeature_A41574.Value == 26)
									{
										num = (short)66453508;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									break;
								case 1:
									switch (0)
									{
									case 0:
										goto IL_11DA;
									}
									continue;
								case 2:
									goto IL_12A2;
								case 3:
									if (!enumerator.MoveNext())
									{
										num = (short)1402929157;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									num = (short)1764818944;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 4:
									flag = false;
									num = (short)623378438;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 5:
									num = (short)321191938;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 6:
									goto IL_11F4;
								}
								IL_11F9:
								num = (short)1695416323;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								IL_11DA:
								goto IL_11F9;
							}
							IL_11F4:
							IL_12A2:
							goto IL_E14;
						}
						finally
						{
							num = (short)62652418;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								switch (num2)
								{
								case 0:
									goto IL_1312;
								case 1:
									enumerator.Dispose();
									num = (short)1440350208;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 2:
									switch (0)
									{
									case 0:
										goto IL_12DA;
									}
									continue;
								}
								IL_12DA:
								if (enumerator == null)
								{
									break;
								}
								num = (short)1876951041;
								num2 = (int)((global::System.IntPtr)num);
							}
							IL_1312:;
						}
						goto IL_1315;
					case 16:
					{
						global::Motorola.MackinawCPS.CoreFeatures.MenuItems.MenuItems menuItems;
						if (menuItems.General.DispMenuConventionalSelectedMenuItems_A21736.Items[num3].ItemName == global::CommonResources.AcgResources.ID_DIR)
						{
							num = (short)1013383168;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_C88;
					}
					case 17:
						enumerator = rsmbuttonInnerRecset.GetEnumerator();
						num = (short)1169620998;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 18:
						if (flag)
						{
							num = (short)209453171;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_16CB;
					case 19:
						num = (short)52035624;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 20:
						enumerator = portableButtonInnerRecset.GetEnumerator();
						num = (short)1830420612;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 21:
						goto IL_1F99;
					case 22:
						goto IL_5A3;
					case 23:
						if (!global::ConstraintHelper.UtilityMack.IsMobile())
						{
							num = (short)1015414806;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return flag;
					case 24:
						return flag;
					case 25:
						return flag;
					case 26:
						num = (short)728236138;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 27:
						enumerator = smartKeyFobButtonTableInnerRecset.GetEnumerator();
						num = (short)154599439;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 28:
						if (flag)
						{
							num = (short)2030698516;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_1FED;
					case 29:
						if (switchConventionalSwitchesPosition3_A.Value == 33)
						{
							num = (short)1944911911;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)262340658;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 30:
						num = (short)869269562;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 31:
						if (switchTrunkingSwitchesPosition3_A.Value == 30)
						{
							num = (short)1547436108;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_F6A;
					case 32:
						if (feature != null)
						{
							num = (short)2046492727;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return flag;
					case 33:
						return flag;
					case 34:
						return flag;
					case 35:
						goto IL_C35;
					case 36:
						if (!global::ConstraintHelper.UtilityMack.IsMobile())
						{
							num = (short)1166016557;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_CAB;
					case 37:
					{
						global::AcpCommonLib.IAcpRecordset feature3;
						global::Motorola.MackinawCPS.CoreFeatures.MenuItems.MenuItems menuItems2 = feature3[0] as global::Motorola.MackinawCPS.CoreFeatures.MenuItems.MenuItems;
						num = (short)344981540;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 38:
						if (conventionalSwitches.RefRadioErgonomicsWide.Advanced.RadErgoWideAdvancedSideButtonsLockEnable_A38725.Value)
						{
							num = (short)2012676104;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_16CB;
					case 39:
						num = (short)1958936648;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 40:
					{
						global::AcpCommonLib.IAcpRecordset feature2;
						if (feature2.Count != 0)
						{
							num = (short)1896611909;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return flag;
					}
					case 41:
						try
						{
							num = (short)1849425924;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								switch (num2)
								{
								case 0:
									flag = false;
									num = (short)1310261253;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 1:
								{
									if (!enumerator.MoveNext())
									{
										num = (short)535625731;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									global::AcpCommonLib.IAcpFeatureNode acpFeatureNode = enumerator.Current;
									num = (short)906035207;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 2:
									goto IL_240E;
								case 3:
									num = (short)963969026;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 4:
									switch (0)
									{
									case 0:
										goto IL_22BC;
									}
									continue;
								case 5:
									goto IL_2339;
								case 6:
									flag = false;
									num = (short)350617609;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 7:
								{
									global::AcpCommonLib.IAcpFeatureNode acpFeatureNode;
									if ((acpFeatureNode[10748] as global::Motorola.MackinawCPS.CoreFeatures.SmartKeyFob.SmartKeyFobButtonTableInnerSection).RadErgoCfgFobConventionalFeature_A41574.Value == 33)
									{
										num = (short)852951046;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									num = (short)338690056;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 8:
								{
									global::AcpCommonLib.IAcpFeatureNode acpFeatureNode;
									if ((acpFeatureNode[10748] as global::Motorola.MackinawCPS.CoreFeatures.SmartKeyFob.SmartKeyFobButtonTableInnerSection).RadErgoCfgFobTrunkingFeature_A41575.Value == 33)
									{
										num = (short)105775104;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									break;
								}
								case 9:
									goto IL_22D8;
								}
								IL_22DD:
								num = (short)2090401793;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								IL_22BC:
								goto IL_22DD;
							}
							IL_22D8:
							IL_2339:
							IL_240E:
							goto IL_1E66;
						}
						finally
						{
							num = (short)2136014849;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								switch (num2)
								{
								case 0:
									enumerator.Dispose();
									num = (short)1746731010;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 1:
									switch (0)
									{
									case 0:
										goto IL_2445;
									}
									continue;
								case 2:
									goto IL_247E;
								}
								IL_2445:
								if (enumerator == null)
								{
									break;
								}
								num = (short)1290076160;
								num2 = (int)((global::System.IntPtr)num);
							}
							IL_247E:;
						}
						return flag;
					case 42:
						num4 = 0;
						num = (short)496762965;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 43:
						num = (short)870842397;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 44:
						try
						{
							num = (short)1608318977;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								switch (num2)
								{
								case 0:
								{
									global::AcpCommonLib.IAcpFeatureNode acpFeatureNode2;
									if ((acpFeatureNode2[10092] as global::Motorola.MackinawCPS.CoreFeatures.Buttons.PortableButtonInnerSection).BtnGeneralConventionalFeature_A19544.Value == 31)
									{
										num = (short)1809514503;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									break;
								}
								case 1:
									switch (0)
									{
									case 0:
										goto IL_1914;
									}
									continue;
								case 2:
									num = (short)740294659;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 3:
									goto IL_1A8C;
								case 4:
									num = (short)2086993920;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 5:
									goto IL_1A6F;
								case 6:
								{
									if (!enumerator.MoveNext())
									{
										num = (short)1889337346;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									global::AcpCommonLib.IAcpFeatureNode acpFeatureNode2 = enumerator.Current;
									num = (short)834273288;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 7:
									flag = false;
									num = (short)1129381893;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 8:
								{
									global::AcpCommonLib.IAcpFeatureNode acpFeatureNode2;
									if ((acpFeatureNode2[10092] as global::Motorola.MackinawCPS.CoreFeatures.Buttons.PortableButtonInnerSection).BtnGeneralConventionalBCO_A19543.Value != 148)
									{
										num = (short)985071620;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									break;
								}
								}
								IL_19CA:
								num = (short)69749313;
								short num5 = num;
								num = (short)95439425;
								switch ((num5 == num) ? 1 : 0)
								{
								case 0:
								case 2:
									IL_1914:
									goto IL_19CA;
								default:
									num = (short)1877278720;
									if (num != 0)
									{
									}
									num = (short)819658758;
									num2 = (int)((global::System.IntPtr)num);
									break;
								}
							}
							IL_1A6F:
							IL_1A8C:
							goto IL_16CB;
						}
						finally
						{
							num = (short)1550647298;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								switch (num2)
								{
								case 0:
									goto IL_1AFD;
								case 1:
									enumerator.Dispose();
									num = (short)41222144;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 2:
									switch (0)
									{
									case 0:
										goto IL_1AC5;
									}
									continue;
								}
								IL_1AC5:
								if (enumerator == null)
								{
									break;
								}
								num = (short)360841217;
								num2 = (int)((global::System.IntPtr)num);
							}
							IL_1AFD:;
						}
						goto IL_1B00;
					case 45:
						num6 = 0;
						num = (short)353108003;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 46:
						num = (short)1582497894;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 47:
						flag3 = (switchTrunkingSwitchesPosition4_A.Value == 29);
						goto IL_CE4;
					case 48:
						flag2 = (switchTrunkingSwitchesPosition4_A.Value == 30);
						goto IL_F1F;
					case 49:
						if (switchTrunkingSwitchesPosition5_A.Value == 30)
						{
							num = (short)1172701267;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_F6A;
					case 50:
						flag4 = true;
						goto IL_1B00;
					case 51:
						flag = false;
						num = (short)434700351;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 52:
					{
						global::AcpCommonLib.IAcpRecordset feature3;
						if (feature3 != null)
						{
							num = (short)988086395;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_CAB;
					}
					case 53:
						if (index != 46)
						{
							num = (short)1512702031;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						feature = global::AcpCommonLib.FeatureManager.GetFeature(2088);
						num = (short)1419968544;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 54:
						switch (index)
						{
						case 26:
							num = (short)1862795357;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 27:
							flag = false;
							num = (short)1063190532;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 28:
						case 31:
						case 32:
							return flag;
						case 29:
							goto IL_1315;
						case 30:
							num = (short)975962161;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 33:
							num = (short)832110699;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						default:
							num = (short)737149037;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						break;
					case 55:
						num = (short)1659502602;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 56:
						try
						{
							num = (short)1195769857;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								switch (num2)
								{
								case 0:
									num = (short)1491927042;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 1:
									switch (0)
									{
									case 0:
										goto IL_206F;
									}
									continue;
								case 2:
									goto IL_2135;
								case 3:
									flag = false;
									num = (short)1472004100;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 5:
									if (!enumerator.MoveNext())
									{
										num = (short)1322188800;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									num = (short)1193082886;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 6:
									if ((((global::AcpCommonLib.IAcpFeatureNode)enumerator.Current)[10080] as global::Motorola.MackinawCPS.CoreFeatures.RemoteSpeakerMic.RSMButtonInnerSection).RadErgoCfgRSMlConventionalFeature_A19640.Value == 26)
									{
										num = (short)809435139;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									break;
								}
								IL_20C2:
								num = (short)293470213;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								IL_206F:
								goto IL_20C2;
							}
							IL_2135:
							goto IL_D2A;
						}
						finally
						{
							num = (short)67371010;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								switch (num2)
								{
								case 0:
									goto IL_21A4;
								case 1:
									enumerator.Dispose();
									num = (short)392560640;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 2:
									switch (0)
									{
									case 0:
										goto IL_216C;
									}
									continue;
								}
								IL_216C:
								if (enumerator == null)
								{
									break;
								}
								num = (short)1326579713;
								num2 = (int)((global::System.IntPtr)num);
							}
							IL_21A4:;
						}
						goto IL_21A7;
					case 57:
						num = (short)666763287;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 58:
						if (switchConventionalSwitchesPosition4_A.Value == 29)
						{
							num = (short)1824718948;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_2250;
					case 59:
						return flag;
					case 60:
						goto IL_1F37;
					case 61:
						if (index != 195)
						{
							num = (short)1491140706;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_21A7;
					case 62:
					{
						global::AcpCommonLib.IAcpRecordset feature3;
						if (feature3.Count != 0)
						{
							num = (short)798359589;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_CAB;
					}
					case 63:
						return flag;
					case 64:
						if (flag)
						{
							num = (short)1811939333;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_6CD;
					case 65:
						goto IL_1F76;
					case 66:
						num = (short)1196884078;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 67:
					{
						global::AcpCommonLib.IAcpRecordset feature2 = global::AcpCommonLib.FeatureManager.GetFeature(2088);
						num = (short)1962016779;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 68:
					{
						global::Motorola.MackinawCPS.CoreFeatures.MenuItems.MenuItems menuItems2;
						if (menuItems2.General.DispMenuConventionalSelectedMenuItems_A21736.Items[num6].ItemName == global::CommonResources.AcgResources.ID_SCAN)
						{
							num = (short)416809047;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_18A4;
					}
					case 69:
					{
						global::AcpCommonLib.IAcpRecordset feature2;
						global::Motorola.MackinawCPS.CoreFeatures.MenuItems.MenuItems menuItems = feature2[0] as global::Motorola.MackinawCPS.CoreFeatures.MenuItems.MenuItems;
						num = (short)1440677959;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 70:
						if (flag)
						{
							num = (short)1928331339;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_CAB;
					case 71:
						if (!global::ConstraintHelper.UtilityMack.IsMobile())
						{
							num = (short)837681286;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return flag;
					case 72:
						flag4 = (switchConventionalSwitchesPosition4_A.Value != 33);
						goto IL_1B00;
					case 73:
						if (num7 >= menuItems3.General.DispMenuConventionalSelectedMenuItems_A21736.Items.Count)
						{
							num = (short)1148649571;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)160956545;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 74:
						num = (short)1124728886;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 75:
					{
						global::AcpCommonLib.IAcpRecordset feature3 = global::AcpCommonLib.FeatureManager.GetFeature(2088);
						num = (short)1827405876;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 76:
						num = (short)1721565274;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 77:
						num = (short)13172749;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 78:
						goto IL_CAB;
					case 79:
					{
						num = (short)546045952;
						short num8 = num;
						num = (short)299696232;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 80:
					{
						global::Motorola.MackinawCPS.CoreFeatures.MenuItems.MenuItems menuItems2;
						if (num6 >= menuItems2.General.DispMenuConventionalSelectedMenuItems_A21736.Items.Count)
						{
							num = (short)1248591914;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)792854596;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 81:
						if (switchConventionalSwitchesPosition3_A.Value == 30)
						{
							num = (short)1741291609;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_F6A;
					case 82:
						num = (short)2134310973;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 83:
						num = (short)226426961;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 84:
					{
						global::Motorola.MackinawCPS.CoreFeatures.MenuItems.MenuItems menuItems2;
						if (menuItems2.General.DispMenuTrunkingSelectedMenuItems_A21735.Items[num4].ItemName == global::CommonResources.AcgResources.ID_SCAN)
						{
							num = (short)191430792;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_1F37;
					}
					case 85:
						goto IL_1F99;
					case 86:
						enumerator = rsmbuttonInnerRecset.GetEnumerator();
						num = (short)73793592;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 87:
						flag = false;
						num = (short)2079981684;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 88:
						goto IL_956;
					case 89:
						num = (short)292356127;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 90:
						if (switchConventionalSwitchesPosition4_A.Value == 30)
						{
							num = (short)601948251;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_F6A;
					case 91:
						num = (short)314310704;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 92:
						return flag;
					case 93:
						if (switchConventionalSwitchesPosition1_A.Value != 26)
						{
							num = (short)543424558;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_5F2;
					case 94:
						if (index <= 61)
						{
							num = (short)1293746250;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)1027538945;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 95:
						goto IL_180A;
					case 96:
						num = (short)1564606473;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 97:
						return flag;
					case 98:
						num = (short)295370776;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 99:
						num = (short)132120610;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 100:
						num = (short)1626931247;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 101:
						num = (short)482082817;
						if (num != 0)
						{
						}
						num = (short)965738610;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 102:
						if (switchConventionalSwitchesPosition2_A.Value != 26)
						{
							num = (short)1671823362;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_5F2;
					case 103:
					{
						global::Motorola.MackinawCPS.CoreFeatures.MenuItems.MenuItems menuItems;
						if (num3 >= menuItems.General.DispMenuConventionalSelectedMenuItems_A21736.Items.Count)
						{
							num = (short)172032101;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)1402142736;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 104:
						if (index != 61)
						{
							num = (short)244711501;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_1100;
					case 105:
						if (switchConventionalSwitchesPosition3_A.Value != 26)
						{
							num = (short)1671823426;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_5F2;
					case 106:
						if (switchConventionalSwitchesPosition2_A.Value != 33)
						{
							num = (short)1470955563;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_DF6;
					case 107:
						if (switchConventionalSwitchesPosition1_A.Value != 33)
						{
							num = (short)67829786;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_DF6;
					case 108:
						num = (short)206176380;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 109:
						num = (short)1676083253;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 110:
						flag5 = (switchConventionalSwitchesPosition4_A.Value != 26);
						goto IL_1DE7;
					case 111:
						try
						{
							num = (short)1536425985;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								switch (num2)
								{
								case 0:
									flag = false;
									num = (short)1375141892;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 1:
									switch (0)
									{
									case 0:
										goto IL_FC8;
									}
									continue;
								case 2:
									goto IL_108C;
								case 3:
									num = (short)1104674818;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 5:
									if ((((global::AcpCommonLib.IAcpFeatureNode)enumerator.Current)[10092] as global::Motorola.MackinawCPS.CoreFeatures.Buttons.PortableButtonInnerSection).BtnGeneralConventionalFeature_A19544.Value == 26)
									{
										num = (short)179896320;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									break;
								case 6:
									if (!enumerator.MoveNext())
									{
										num = (short)360120323;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									num = (short)1337458693;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								IL_FCA:
								num = (short)1074462726;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								IL_FC8:
								goto IL_FCA;
							}
							IL_108C:
							goto IL_6CD;
						}
						finally
						{
							num = (short)1824391170;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								switch (num2)
								{
								case 0:
									goto IL_10FD;
								case 1:
									enumerator.Dispose();
									num = (short)2686976;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 2:
									switch (0)
									{
									case 0:
										goto IL_10C4;
									}
									continue;
								}
								IL_10C4:
								if (enumerator == null)
								{
									break;
								}
								num = (short)1447493633;
								num2 = (int)((global::System.IntPtr)num);
							}
							IL_10FD:;
						}
						goto IL_1100;
					case 112:
						if (flag)
						{
							num = (short)1208680534;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_D2A;
					case 113:
						flag4 = false;
						goto IL_1B00;
					case 114:
						return flag;
					case 115:
						enumerator = portableButtonInnerRecset.GetEnumerator();
						num = (short)693043244;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 116:
						goto IL_18A4;
					case 117:
						if (switchTrunkingSwitchesPosition5_A.Value == 29)
						{
							num = (short)187498633;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_2250;
					case 118:
						try
						{
							num = (short)1098448900;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								switch (num2)
								{
								case 0:
								{
									global::AcpCommonLib.IAcpFeatureNode acpFeatureNode3;
									if ((acpFeatureNode3[10080] as global::Motorola.MackinawCPS.CoreFeatures.RemoteSpeakerMic.RSMButtonInnerSection).RadErgoCfgRSMConventionalBCO_A19639.Value != 151)
									{
										num = (short)2085093382;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									break;
								}
								case 1:
								{
									global::AcpCommonLib.IAcpFeatureNode acpFeatureNode3;
									if ((acpFeatureNode3[10080] as global::Motorola.MackinawCPS.CoreFeatures.RemoteSpeakerMic.RSMButtonInnerSection).RadErgoCfgRSMlConventionalFeature_A19640.Value == 31)
									{
										num = (short)328204296;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									break;
								}
								case 2:
									num = (short)1517617159;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 3:
									goto IL_4BD;
								case 4:
									switch (0)
									{
									case 0:
										goto IL_406;
									}
									continue;
								case 5:
								{
									if (!enumerator.MoveNext())
									{
										num = (short)545783810;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									global::AcpCommonLib.IAcpFeatureNode acpFeatureNode3 = enumerator.Current;
									num = (short)719323136;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 6:
									num = (short)1911619585;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 7:
									goto IL_530;
								case 8:
									flag = false;
									num = (short)371458051;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								IL_408:
								num = (short)208797701;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								IL_406:
								goto IL_408;
							}
							IL_4BD:
							IL_530:
							goto IL_1BFC;
						}
						finally
						{
							num = (short)2120220674;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								switch (num2)
								{
								case 0:
									goto IL_5A0;
								case 1:
									enumerator.Dispose();
									num = (short)1040121856;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 2:
									switch (0)
									{
									case 0:
										goto IL_568;
									}
									continue;
								}
								IL_568:
								if (enumerator == null)
								{
									break;
								}
								num = (short)1076822017;
								num2 = (int)((global::System.IntPtr)num);
							}
							IL_5A0:;
						}
						goto IL_5A3;
						IL_1BFC:
						num = (short)1519058962;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 119:
					{
						global::Motorola.MackinawCPS.CoreFeatures.MenuItems.MenuItems menuItems2;
						if (num4 >= menuItems2.General.DispMenuTrunkingSelectedMenuItems_A21735.Items.Count)
						{
							num = (short)1395327054;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)1012138068;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 120:
						flag3 = false;
						goto IL_CE4;
					case 121:
						goto IL_956;
					case 122:
						enumerator = smartKeyFobButtonTableInnerRecset.GetEnumerator();
						num = (short)503447593;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 123:
						num = (short)912457790;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 124:
						if (switchTrunkingSwitchesPosition3_A.Value == 29)
						{
							num = (short)1816068126;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_2250;
					case 125:
						flag = false;
						num = (short)659685441;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 126:
						flag5 = false;
						goto IL_1DE7;
					case 127:
						goto IL_C88;
					case 128:
						if (flag)
						{
							num = (short)2066415633;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return flag;
					case 129:
						if (menuItems3.General.DispMenuConventionalSelectedMenuItems_A21736.Items[num7].ItemName == global::CommonResources.AcgResources.ID_SCNL)
						{
							num = (short)1893662845;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_1F76;
					case 130:
						if (flag)
						{
							num = (short)1522204699;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_E14;
					case 131:
						if (conventionalSwitches.RefRadioErgonomicsWide.Advanced.RadErgoWideAdvancedToggleSwitchLockEnable_43773.Value)
						{
							num = (short)1148387379;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return flag;
					case 132:
						try
						{
							num = (short)1984364545;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								switch (num2)
								{
								case 0:
									if (!enumerator.MoveNext())
									{
										num = (short)503644164;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									num = (short)854523910;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 1:
									switch (0)
									{
									case 0:
										goto IL_AD2;
									}
									continue;
								case 2:
									goto IL_BC3;
								case 3:
									flag = false;
									num = (short)735182853;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 4:
									num = (short)1544421378;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 6:
								{
									global::AcpBusinessLayer.FeatureNode featureNode2 = enumerator.Current;
									if ((((global::AcpCommonLib.IAcpFeatureNode)featureNode2)[10092] as global::Motorola.MackinawCPS.CoreFeatures.Buttons.PortableButtonInnerSection).BtnGeneralConventionalFeature_A19544.Value == 33)
									{
										flag = false;
									}
									if ((((global::AcpCommonLib.IAcpFeatureNode)featureNode2)[10092] as global::Motorola.MackinawCPS.CoreFeatures.Buttons.PortableButtonInnerSection).BtnTrunkingPortableButtonFeature_A19546.Value == 33)
									{
										num = (short)1475084291;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									break;
								}
								}
								IL_B6C:
								num = (short)1160970240;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								IL_AD2:
								goto IL_B6C;
							}
							IL_BC3:
							goto IL_1FED;
						}
						finally
						{
							num = (short)945291266;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								switch (num2)
								{
								case 0:
									goto IL_C32;
								case 1:
									enumerator.Dispose();
									num = (short)70057984;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 2:
									switch (0)
									{
									case 0:
										goto IL_BFA;
									}
									continue;
								}
								IL_BFA:
								if (enumerator == null)
								{
									break;
								}
								num = (short)1980563457;
								num2 = (int)((global::System.IntPtr)num);
							}
							IL_C32:;
						}
						goto IL_C35;
					case 133:
						if (flag)
						{
							num = (short)627769466;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_1E66;
					case 134:
						num3 = 0;
						num = (short)329449567;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 135:
						if (switchConventionalSwitchesPosition3_A.Value == 29)
						{
							num = (short)192675948;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_2250;
					case 136:
						flag = false;
						num = (short)1357054012;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 137:
						num = (short)1565524103;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_256;
					IL_5A3:
					menuItems3 = (feature[0] as global::Motorola.MackinawCPS.CoreFeatures.MenuItems.MenuItems);
					num7 = 0;
					num = (short)2014511225;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_5F2:
					num = (short)1127809150;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_6CD:
					num = (short)102760560;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_956:
					num = (short)823132233;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_C35:
					num = (short)1036386384;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_C88:
					num3++;
					num = (short)966656014;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_CAB:
					num = (short)1018101788;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_CE4:
					flag = flag3;
					num = (short)1705246779;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_D2A:
					num = (short)1994522754;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_DF6:
					num = (short)1343357041;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_E14:
					num = (short)2072182787;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_F1F:
					flag = flag2;
					num = (short)1335361561;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_F6A:
					num = (short)1531314188;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_1100:
					num = (short)672923686;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_1315:
					num = (short)336003189;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_1617:
					enumerator = rsmbuttonInnerRecset.GetEnumerator();
					num = (short)500564086;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_16CB:
					num = (short)1369243779;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_180A:
					num = (short)1807679591;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_18A4:
					num6++;
					num = (short)2017394695;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_1B00:
					flag = flag4;
					num = (short)485883974;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_1DE7:
					flag = flag5;
					num = (short)1077411904;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_1E66:
					num = (short)398786688;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_1F37:
					num4++;
					num = (short)1741094933;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_1F76:
					num7++;
					num = (short)2018836568;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_1F99:
					num = (short)1202126967;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_1FED:
					num = (short)1239810181;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_21A7:
					flag = false;
					num = (short)1343029340;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_2250:
					num = (short)1165099128;
					num2 = (int)((global::System.IntPtr)num);
				}
				return flag;
				IL_256:
				conventionalSwitches = (self as global::Motorola.MackinawCPS.CoreFeatures.Switches.ConventionalSwitches);
				global::Motorola.MackinawCPS.CoreFeatures.Switches.Switches switches = self.Parent as global::Motorola.MackinawCPS.CoreFeatures.Switches.Switches;
				switchConventionalSwitchesPosition1_A = conventionalSwitches.SwitchConventionalSwitchesPosition1_A7734;
				switchConventionalSwitchesPosition2_A = conventionalSwitches.SwitchConventionalSwitchesPosition2_A7735;
				switchConventionalSwitchesPosition3_A = conventionalSwitches.SwitchConventionalSwitchesPosition3_A7737;
				switchConventionalSwitchesPosition4_A = conventionalSwitches.SwitchConventionalSwitchesPosition4_A21530;
				switchTrunkingSwitchesPosition3_A = switches.TrunkingSwitches.SwitchTrunkingSwitchesPosition3_A9468;
				switchTrunkingSwitchesPosition4_A = switches.TrunkingSwitches.SwitchTrunkingSwitchesPosition4_A21534;
				switchTrunkingSwitchesPosition5_A = switches.TrunkingSwitches.SwitchTrunkingSwitchesPosition5_A21535;
				portableButtonInnerRecset = ((global::AcpCommonLib.FeatureManager.GetFeature(2042) as global::Motorola.MackinawCPS.CoreFeatures.Buttons.ButtonsRecset)[0][10091].EmbeddedRecset as global::Motorola.MackinawCPS.CoreFeatures.Buttons.PortableButtonInnerRecset);
				rsmbuttonInnerRecset = ((global::AcpCommonLib.FeatureManager.GetFeature(2036) as global::Motorola.MackinawCPS.CoreFeatures.RemoteSpeakerMic.RemoteSpeakerMicRecset)[0][10079].EmbeddedRecset as global::Motorola.MackinawCPS.CoreFeatures.RemoteSpeakerMic.RSMButtonInnerRecset);
				smartKeyFobButtonTableInnerRecset = ((global::AcpCommonLib.FeatureManager.GetFeature(4130) as global::Motorola.MackinawCPS.CoreFeatures.SmartKeyFob.SmartKeyFobRecset)[0][10747].EmbeddedRecset as global::Motorola.MackinawCPS.CoreFeatures.SmartKeyFob.SmartKeyFobButtonTableInnerRecset);
				flag = true;
				num = (short)1894973534;
				num2 = (int)((global::System.IntPtr)num);
				goto IL_27;
			}
			}
		}

		// Token: 0x060073AA RID: 29610 RVA: 0x00676DB0 File Offset: 0x00674FB0
		internal static bool ConSwitchesTrkPos5(global::AcpCommonLib.IAcpFeatureSection self, int index)
		{
			short num = (short)914292736;
			int num2 = (int)num;
			switch (num2)
			{
			default:
			{
				switch (0)
				{
				case 0:
					goto IL_1D3;
				}
				global::AcpBusinessLayer.AcpListField switchConventionalSwitchesPosition3_A;
				bool flag;
				global::Motorola.MackinawCPS.CoreFeatures.Switches.TrunkingSwitches trunkingSwitches;
				global::AcpBusinessLayer.AcpListField switchTrunkingSwitchesPosition4_A;
				global::AcpBusinessLayer.AcpListField switchConventionalSwitchesPosition5_A;
				global::AcpBusinessLayer.AcpListField switchTrunkingSwitchesPosition3_A;
				global::AcpBusinessLayer.AcpListField switchConventionalSwitchesPosition4_A;
				global::Motorola.MackinawCPS.CoreFeatures.RemoteSpeakerMic.RSMButtonInnerRecset rsmbuttonInnerRecset;
				global::Motorola.MackinawCPS.CoreFeatures.SmartKeyFob.SmartKeyFobButtonTableInnerRecset smartKeyFobButtonTableInnerRecset;
				global::Motorola.MackinawCPS.CoreFeatures.Buttons.PortableButtonInnerRecset portableButtonInnerRecset;
				for (;;)
				{
					IL_28:
					int num3;
					int num4;
					global::System.Collections.Generic.IEnumerator<global::AcpBusinessLayer.FeatureNode> enumerator;
					bool flag2;
					bool flag3;
					int num7;
					bool flag4;
					switch (num2)
					{
					case 0:
						if (switchConventionalSwitchesPosition3_A.Value == 30)
						{
							num = (short)298385479;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_151E;
					case 1:
						if (flag)
						{
							num = (short)390004825;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_D80;
					case 2:
						if (index != 61)
						{
							num = (short)954466392;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)606339089;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 3:
						if (trunkingSwitches.SwitchTrunkingSwitchesPosition1_A9466.Value != 33)
						{
							num = (short)756547603;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_1029;
					case 4:
						flag = false;
						num = (short)1194590284;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 5:
						goto IL_15B9;
					case 6:
						return flag;
					case 7:
						if (!global::ConstraintHelper.UtilityMack.IsMobile())
						{
							num = (short)1782513726;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return flag;
					case 8:
					{
						global::Motorola.MackinawCPS.CoreFeatures.MenuItems.MenuItems menuItems;
						if (menuItems.General.DispMenuTrunkingSelectedMenuItems_A21735.Items[num3].ItemName == global::CommonResources.AcgResources.ID_SCNL)
						{
							num = (short)88276996;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_1006;
					}
					case 9:
						num = (short)924581915;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 10:
						return flag;
					case 11:
						switch (index)
						{
						case 27:
							flag = false;
							num = (short)1370226730;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 28:
						case 31:
						case 32:
							return flag;
						case 29:
							num = (short)1283915816;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 30:
							num = (short)2007302243;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 33:
							num = (short)108658691;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						default:
							num = (short)1774321702;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						break;
					case 12:
						num = (short)1579941935;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 13:
						goto IL_15B9;
					case 14:
						num = (short)1993474055;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 15:
						num = (short)133103669;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 16:
						if (index <= 61)
						{
							num = (short)925040692;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)1847459914;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 17:
						if (trunkingSwitches.RefRadioErgonomicsWide.Advanced.RadErgoWideAdvancedSideButtonsLockEnable_A38725.Value)
						{
							num = (short)417464400;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_E89;
					case 18:
						goto IL_12BC;
					case 19:
						num = (short)2138636366;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 20:
						num = (short)1374289970;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 21:
					{
						global::Motorola.MackinawCPS.CoreFeatures.MenuItems.MenuItems menuItems2;
						if (menuItems2.General.DispMenuConventionalSelectedMenuItems_A21736.Items[num4].ItemName == global::CommonResources.AcgResources.ID_SCAN)
						{
							num = (short)202047539;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_D5D;
					}
					case 22:
						goto IL_7AC;
					case 23:
					{
						global::AcpCommonLib.IAcpRecordset feature = global::AcpCommonLib.FeatureManager.GetFeature(2088);
						num = (short)1770651672;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 24:
					{
						global::AcpCommonLib.IAcpRecordset feature;
						if (feature != null)
						{
							num = (short)1859584000;
							short num5 = num;
							num = (short)391315471;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_47D;
					}
					case 25:
						goto IL_A08;
					case 26:
						goto IL_165C;
					case 27:
						if (index != 195)
						{
							num = (short)1778974738;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						flag = false;
						num = (short)275120134;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 28:
					{
						num = (short)1116669478;
						short num6 = num;
						num = (short)1494943270;
						switch ((num6 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_FC7;
						default:
							num = (short)1661992960;
							if (num != 0)
							{
							}
							flag = false;
							num = (short)1438515210;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						break;
					}
					case 29:
					{
						global::Motorola.MackinawCPS.CoreFeatures.MenuItems.MenuItems menuItems2;
						if (num4 >= menuItems2.General.DispMenuConventionalSelectedMenuItems_A21736.Items.Count)
						{
							num = (short)1752498277;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)762052629;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 30:
						try
						{
							num = (short)215023621;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								switch (num2)
								{
								case 0:
									goto IL_62D;
								case 1:
									flag = false;
									num = (short)279117828;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 2:
									num = (short)848887815;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 3:
									num = (short)746455040;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 4:
									goto IL_57C;
								case 5:
									switch (0)
									{
									case 0:
										goto IL_503;
									}
									continue;
								case 6:
								{
									global::AcpCommonLib.IAcpFeatureNode acpFeatureNode;
									if ((acpFeatureNode[10092] as global::Motorola.MackinawCPS.CoreFeatures.Buttons.PortableButtonInnerSection).BtnTrunkingPortableTrunkingBCO_A19545.Value != 148)
									{
										num = (short)914358274;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									break;
								}
								case 7:
								{
									global::AcpCommonLib.IAcpFeatureNode acpFeatureNode;
									if ((acpFeatureNode[10092] as global::Motorola.MackinawCPS.CoreFeatures.Buttons.PortableButtonInnerSection).BtnTrunkingPortableButtonFeature_A19546.Value == 31)
									{
										num = (short)1807024129;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									break;
								}
								case 8:
								{
									if (!enumerator.MoveNext())
									{
										num = (short)1300365315;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									global::AcpCommonLib.IAcpFeatureNode acpFeatureNode = enumerator.Current;
									num = (short)1245184006;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								}
								IL_581:
								num = (short)555941896;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								IL_503:
								goto IL_581;
							}
							IL_57C:
							IL_62D:
							goto IL_E89;
						}
						finally
						{
							num = (short)415760384;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								switch (num2)
								{
								case 0:
									switch (0)
									{
									case 0:
										goto IL_664;
									}
									continue;
								case 1:
									goto IL_69B;
								case 2:
									enumerator.Dispose();
									num = (short)56950785;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								IL_664:
								if (enumerator == null)
								{
									break;
								}
								num = (short)334626818;
								num2 = (int)((global::System.IntPtr)num);
							}
							IL_69B:;
						}
						goto IL_69E;
					case 31:
						goto IL_F45;
					case 32:
						if (!global::ConstraintHelper.UtilityMack.IsMobile())
						{
							num = (short)945750050;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_47D;
					case 33:
						return flag;
					case 34:
						num4 = 0;
						num = (short)924516357;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 35:
						goto IL_F45;
					case 36:
						goto IL_47D;
					case 37:
						flag2 = (switchTrunkingSwitchesPosition4_A.Value != 33);
						goto IL_BA8;
					case 38:
						num = (short)1024262187;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 39:
						goto IL_7AC;
					case 40:
						if (switchConventionalSwitchesPosition5_A.Value == 29)
						{
							num = (short)2293814;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_6C5;
					case 41:
						goto IL_69E;
					case 42:
						return flag;
					case 43:
					{
						if (index != 46)
						{
							num = (short)2108948545;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						global::AcpCommonLib.IAcpRecordset feature2 = global::AcpCommonLib.FeatureManager.GetFeature(2088);
						num = (short)477233250;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 44:
						return flag;
					case 45:
						if (trunkingSwitches.RefRadioErgonomicsWide.Advanced.RadErgoWideAdvancedToggleSwitchLockEnable_43773.Value)
						{
							num = (short)401997852;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return flag;
					case 46:
						flag2 = true;
						goto IL_BA8;
					case 47:
						if (switchTrunkingSwitchesPosition3_A.Value == 33)
						{
							num = (short)243662932;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)583073838;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 48:
						return flag;
					case 49:
						num = (short)119406660;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 50:
						flag3 = (switchTrunkingSwitchesPosition4_A.Value == 30);
						goto IL_BE8;
					case 51:
						flag = false;
						num = (short)1633288261;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 52:
						num = (short)1820590091;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 53:
					{
						global::AcpCommonLib.IAcpRecordset feature;
						if (feature.Count != 0)
						{
							num = (short)718864465;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_47D;
					}
					case 54:
						num = (short)1809252442;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 55:
					{
						global::Motorola.MackinawCPS.CoreFeatures.MenuItems.MenuItems menuItems2;
						if (num7 >= menuItems2.General.DispMenuTrunkingSelectedMenuItems_A21735.Items.Count)
						{
							num = (short)324272164;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)664666208;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 56:
						return flag;
					case 57:
						if (switchTrunkingSwitchesPosition3_A.Value == 29)
						{
							num = (short)265683036;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_6C5;
					case 58:
						return flag;
					case 59:
						flag4 = false;
						goto IL_1048;
					case 60:
						if (switchTrunkingSwitchesPosition3_A.Value == 30)
						{
							num = (short)386990165;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_151E;
					case 61:
					{
						global::Motorola.MackinawCPS.CoreFeatures.MenuItems.MenuItems menuItems;
						if (num3 >= menuItems.General.DispMenuTrunkingSelectedMenuItems_A21735.Items.Count)
						{
							num = (short)1994129494;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)939196424;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 62:
					{
						global::AcpCommonLib.IAcpRecordset feature2;
						global::Motorola.MackinawCPS.CoreFeatures.MenuItems.MenuItems menuItems = feature2[0] as global::Motorola.MackinawCPS.CoreFeatures.MenuItems.MenuItems;
						num3 = 0;
						num = (short)382533654;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 63:
						if (flag)
						{
							num = (short)1293811816;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_E89;
					case 64:
						try
						{
							num = (short)356188166;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								switch (num2)
								{
								case 0:
									goto IL_1248;
								case 1:
									flag = false;
									num = (short)205586434;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 2:
									goto IL_122A;
								case 3:
								{
									global::AcpCommonLib.IAcpFeatureNode acpFeatureNode2;
									if ((acpFeatureNode2[10748] as global::Motorola.MackinawCPS.CoreFeatures.SmartKeyFob.SmartKeyFobButtonTableInnerSection).RadErgoCfgFobConventionalFeature_A41574.Value == 33)
									{
										num = (short)1105133569;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									num = (short)1829961733;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 4:
								{
									if (!enumerator.MoveNext())
									{
										num = (short)915865608;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									global::AcpCommonLib.IAcpFeatureNode acpFeatureNode2 = enumerator.Current;
									num = (short)865730563;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 5:
								{
									global::AcpCommonLib.IAcpFeatureNode acpFeatureNode2;
									if ((acpFeatureNode2[10748] as global::Motorola.MackinawCPS.CoreFeatures.SmartKeyFob.SmartKeyFobButtonTableInnerSection).RadErgoCfgFobTrunkingFeature_A41575.Value == 33)
									{
										num = (short)458358793;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									break;
								}
								case 6:
									switch (0)
									{
									case 0:
										goto IL_10FE;
									}
									continue;
								case 7:
									goto IL_111B;
								case 8:
									num = (short)474218496;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 9:
									flag = false;
									num = (short)794624007;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								IL_11CF:
								num = (short)904921092;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								IL_10FE:
								goto IL_11CF;
							}
							IL_111B:
							IL_122A:
							IL_1248:
							goto IL_D80;
						}
						finally
						{
							num = (short)1632698368;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								switch (num2)
								{
								case 0:
									switch (0)
									{
									case 0:
										goto IL_1280;
									}
									continue;
								case 1:
									goto IL_12B9;
								case 2:
									enumerator.Dispose();
									num = (short)2139029505;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								IL_1280:
								if (enumerator == null)
								{
									break;
								}
								num = (short)453443586;
								num2 = (int)((global::System.IntPtr)num);
							}
							IL_12B9:;
						}
						goto IL_12BC;
					case 65:
						num = (short)377683970;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 66:
						if (flag)
						{
							num = (short)902955049;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return flag;
					case 67:
						flag = false;
						num = (short)1521418266;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 68:
						if (index != 194)
						{
							num = (short)837353481;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						flag = false;
						num = (short)1842675794;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 69:
						goto IL_D5D;
					case 70:
						if (flag)
						{
							num = (short)1603338263;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_47D;
					case 71:
						num = (short)811401276;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 72:
						if (flag)
						{
							num = (short)1141047399;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_184D;
					case 73:
						if (switchConventionalSwitchesPosition4_A.Value == 30)
						{
							num = (short)1346830356;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_151E;
					case 74:
						if (index != 81)
						{
							num = (short)1796079665;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						flag = false;
						num = (short)1912864801;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 75:
						return flag;
					case 76:
						goto IL_1006;
					case 77:
						flag2 = false;
						goto IL_BA8;
					case 78:
						if (trunkingSwitches.SwitchTrunkingSwitchesPosition2_A9467.Value != 33)
						{
							num = (short)2056388620;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_1029;
					case 79:
						num = (short)443744256;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 80:
						enumerator = rsmbuttonInnerRecset.GetEnumerator();
						num = (short)625803364;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 81:
					{
						global::AcpCommonLib.IAcpRecordset feature;
						global::Motorola.MackinawCPS.CoreFeatures.MenuItems.MenuItems menuItems2 = feature[0] as global::Motorola.MackinawCPS.CoreFeatures.MenuItems.MenuItems;
						goto IL_FC7;
					}
					case 82:
						return flag;
					case 83:
						try
						{
							num = (short)496238595;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								switch (num2)
								{
								case 0:
									flag = false;
									num = (short)2055798789;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 1:
									goto IL_17DC;
								case 2:
									num = (short)1819148289;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 3:
									switch (0)
									{
									case 0:
										goto IL_16E9;
									}
									continue;
								case 4:
									if (!enumerator.MoveNext())
									{
										num = (short)1845035010;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									num = (short)1224540166;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 6:
								{
									global::AcpBusinessLayer.FeatureNode featureNode = enumerator.Current;
									if ((((global::AcpCommonLib.IAcpFeatureNode)featureNode)[10092] as global::Motorola.MackinawCPS.CoreFeatures.Buttons.PortableButtonInnerSection).BtnGeneralConventionalFeature_A19544.Value == 33)
									{
										flag = false;
									}
									if ((((global::AcpCommonLib.IAcpFeatureNode)featureNode)[10092] as global::Motorola.MackinawCPS.CoreFeatures.Buttons.PortableButtonInnerSection).BtnTrunkingPortableButtonFeature_A19546.Value == 33)
									{
										num = (short)1446182912;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									break;
								}
								}
								IL_16EB:
								num = (short)683671556;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								IL_16E9:
								goto IL_16EB;
							}
							IL_17DC:;
						}
						finally
						{
							num = (short)1385365504;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								switch (num2)
								{
								case 0:
									switch (0)
									{
									case 0:
										goto IL_1812;
									}
									continue;
								case 1:
									goto IL_184A;
								case 2:
									enumerator.Dispose();
									num = (short)683999233;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								IL_1812:
								if (enumerator == null)
								{
									break;
								}
								num = (short)176160770;
								num2 = (int)((global::System.IntPtr)num);
							}
							IL_184A:;
						}
						goto IL_184D;
					case 84:
						num = (short)738394149;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 85:
						num = (short)288096329;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 86:
						num = (short)761200698;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 87:
						num = (short)2949213;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 88:
						num = (short)1249443915;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 89:
						enumerator = smartKeyFobButtonTableInnerRecset.GetEnumerator();
						num = (short)2084503553;
						if (num != 0)
						{
						}
						num = (short)1296891968;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 90:
						if (switchConventionalSwitchesPosition3_A.Value == 29)
						{
							num = (short)614400091;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_6C5;
					case 91:
						num = (short)441253945;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 92:
						num = (short)187629662;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 93:
					{
						global::AcpCommonLib.IAcpRecordset feature2;
						if (feature2.Count != 0)
						{
							num = (short)1176633358;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return flag;
					}
					case 94:
						if (switchConventionalSwitchesPosition4_A.Value == 29)
						{
							num = (short)275054689;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_6C5;
					case 95:
						flag4 = (switchTrunkingSwitchesPosition4_A.Value == 29);
						goto IL_1048;
					case 96:
					{
						global::Motorola.MackinawCPS.CoreFeatures.MenuItems.MenuItems menuItems2;
						if (menuItems2.General.DispMenuTrunkingSelectedMenuItems_A21735.Items[num7].ItemName == global::CommonResources.AcgResources.ID_SCAN)
						{
							num = (short)1619066947;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_165C;
					}
					case 97:
						num = (short)441253983;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 98:
					{
						global::AcpCommonLib.IAcpRecordset feature2;
						if (feature2 != null)
						{
							num = (short)410124375;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return flag;
					}
					case 99:
						if (switchConventionalSwitchesPosition5_A.Value == 30)
						{
							num = (short)1321205839;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_151E;
					case 100:
						try
						{
							num = (short)623181829;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								switch (num2)
								{
								case 0:
									goto IL_995;
								case 1:
									goto IL_978;
								case 2:
									flag = false;
									num = (short)637272065;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 3:
								{
									if (!enumerator.MoveNext())
									{
										num = (short)2129592327;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									global::AcpCommonLib.IAcpFeatureNode acpFeatureNode3 = enumerator.Current;
									num = (short)2011037700;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 4:
								{
									global::AcpCommonLib.IAcpFeatureNode acpFeatureNode3;
									if ((acpFeatureNode3[10080] as global::Motorola.MackinawCPS.CoreFeatures.RemoteSpeakerMic.RSMButtonInnerSection).RadErgoCfgRSMTrunkingBCO_A19741.Value != 151)
									{
										num = (short)1270874120;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									break;
								}
								case 5:
									switch (0)
									{
									case 0:
										goto IL_86A;
									}
									continue;
								case 6:
								{
									global::AcpCommonLib.IAcpFeatureNode acpFeatureNode3;
									if ((acpFeatureNode3[10080] as global::Motorola.MackinawCPS.CoreFeatures.RemoteSpeakerMic.RSMButtonInnerSection).RadErgoCfgRSMlTrunkingFeature_A19742.Value == 31)
									{
										num = (short)1244332034;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									break;
								}
								case 7:
									num = (short)814612480;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 8:
									num = (short)1702756358;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								IL_91F:
								num = (short)1422196739;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								IL_86A:
								goto IL_91F;
							}
							IL_978:
							IL_995:
							goto IL_140E;
						}
						finally
						{
							num = (short)1943470080;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								switch (num2)
								{
								case 0:
									switch (0)
									{
									case 0:
										goto IL_9CD;
									}
									continue;
								case 1:
									goto IL_A05;
								case 2:
									enumerator.Dispose();
									num = (short)207028225;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								IL_9CD:
								if (enumerator == null)
								{
									break;
								}
								num = (short)1527971842;
								num2 = (int)((global::System.IntPtr)num);
							}
							IL_A05:;
						}
						goto Block_13;
						IL_140E:
						num = (short)451936319;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 101:
						num7 = 0;
						num = (short)855113759;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 102:
						flag3 = false;
						goto IL_BE8;
					case 103:
						enumerator = portableButtonInnerRecset.GetEnumerator();
						num = (short)1491468371;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 104:
						enumerator = portableButtonInnerRecset.GetEnumerator();
						num = (short)1092354078;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_1D3;
					IL_47D:
					num = (short)1132396545;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_69E:
					enumerator = rsmbuttonInnerRecset.GetEnumerator();
					num = (short)461963289;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_6C5:
					num = (short)248053819;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_7AC:
					num = (short)1980104765;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_BA8:
					flag = flag2;
					num = (short)844890182;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					Block_13:
					try
					{
						IL_A08:
						num = (short)789184515;
						num2 = (int)((global::System.IntPtr)num);
						for (;;)
						{
							switch (num2)
							{
							case 0:
								flag = false;
								num = (short)415629317;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							case 1:
								goto IL_B34;
							case 2:
								if (!enumerator.MoveNext())
								{
									num = (short)499777542;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								num = (short)1847721988;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							case 3:
								switch (0)
								{
								case 0:
									goto IL_A4A;
								}
								continue;
							case 4:
							{
								global::AcpBusinessLayer.FeatureNode featureNode2 = enumerator.Current;
								if ((((global::AcpCommonLib.IAcpFeatureNode)featureNode2)[10080] as global::Motorola.MackinawCPS.CoreFeatures.RemoteSpeakerMic.RSMButtonInnerSection).RadErgoCfgRSMlConventionalFeature_A19640.Value == 33)
								{
									flag = false;
								}
								if ((((global::AcpCommonLib.IAcpFeatureNode)featureNode2)[10080] as global::Motorola.MackinawCPS.CoreFeatures.RemoteSpeakerMic.RSMButtonInnerSection).RadErgoCfgRSMlTrunkingFeature_A19742.Value == 33)
								{
									num = (short)944635904;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								break;
							}
							case 6:
								num = (short)946012161;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							IL_A88:
							num = (short)2133393410;
							num2 = (int)((global::System.IntPtr)num);
							continue;
							IL_A4A:
							goto IL_A88;
						}
						IL_B34:
						break;
					}
					finally
					{
						num = (short)1848705024;
						num2 = (int)((global::System.IntPtr)num);
						for (;;)
						{
							switch (num2)
							{
							case 0:
								switch (0)
								{
								case 0:
									goto IL_B6C;
								}
								continue;
							case 1:
								goto IL_BA5;
							case 2:
								enumerator.Dispose();
								num = (short)830799873;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							IL_B6C:
							if (enumerator == null)
							{
								break;
							}
							num = (short)208273410;
							num2 = (int)((global::System.IntPtr)num);
						}
						IL_BA5:;
					}
					goto IL_BA8;
					IL_BE8:
					flag = flag3;
					num = (short)1089404984;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_D5D:
					num4++;
					num = (short)1455226893;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_D80:
					num = (short)90374216;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_E89:
					num = (short)2064646189;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_F45:
					num = (short)204013623;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_FC7:
					num = (short)1809055776;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_1006:
					num3++;
					num = (short)716046375;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_1029:
					num = (short)1663893581;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_1048:
					flag = flag4;
					num = (short)967442480;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_12BC:
					num = (short)91291692;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_151E:
					num = (short)1002831974;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_15B9:
					num = (short)102301725;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_165C:
					num7++;
					num = (short)184287267;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_184D:
					num = (short)1381630018;
					num2 = (int)((global::System.IntPtr)num);
				}
				return flag;
				IL_1D3:
				trunkingSwitches = (self as global::Motorola.MackinawCPS.CoreFeatures.Switches.TrunkingSwitches);
				global::Motorola.MackinawCPS.CoreFeatures.Switches.Switches switches = self.Parent as global::Motorola.MackinawCPS.CoreFeatures.Switches.Switches;
				switchConventionalSwitchesPosition3_A = switches.ConventionalSwitches.SwitchConventionalSwitchesPosition3_A7737;
				switchConventionalSwitchesPosition4_A = switches.ConventionalSwitches.SwitchConventionalSwitchesPosition4_A21530;
				switchConventionalSwitchesPosition5_A = switches.ConventionalSwitches.SwitchConventionalSwitchesPosition5_A21531;
				switchTrunkingSwitchesPosition3_A = trunkingSwitches.SwitchTrunkingSwitchesPosition3_A9468;
				switchTrunkingSwitchesPosition4_A = trunkingSwitches.SwitchTrunkingSwitchesPosition4_A21534;
				portableButtonInnerRecset = ((global::AcpCommonLib.FeatureManager.GetFeature(2042) as global::Motorola.MackinawCPS.CoreFeatures.Buttons.ButtonsRecset)[0][10091].EmbeddedRecset as global::Motorola.MackinawCPS.CoreFeatures.Buttons.PortableButtonInnerRecset);
				rsmbuttonInnerRecset = ((global::AcpCommonLib.FeatureManager.GetFeature(2036) as global::Motorola.MackinawCPS.CoreFeatures.RemoteSpeakerMic.RemoteSpeakerMicRecset)[0][10079].EmbeddedRecset as global::Motorola.MackinawCPS.CoreFeatures.RemoteSpeakerMic.RSMButtonInnerRecset);
				smartKeyFobButtonTableInnerRecset = ((global::AcpCommonLib.FeatureManager.GetFeature(4130) as global::Motorola.MackinawCPS.CoreFeatures.SmartKeyFob.SmartKeyFobRecset)[0][10747].EmbeddedRecset as global::Motorola.MackinawCPS.CoreFeatures.SmartKeyFob.SmartKeyFobButtonTableInnerRecset);
				flag = true;
				num = (short)1769472016;
				num2 = (int)((global::System.IntPtr)num);
				goto IL_28;
			}
			}
		}

		// Token: 0x060073AB RID: 29611 RVA: 0x00678924 File Offset: 0x00676B24
		internal static bool ConSwitchesTrkPos4(global::AcpCommonLib.IAcpFeatureSection self, int index)
		{
			short num = (short)860291072;
			int num2 = (int)num;
			switch (num2)
			{
			default:
			{
				switch (0)
				{
				case 0:
					goto IL_1D3;
				}
				bool flag;
				global::AcpBusinessLayer.AcpListField switchTrunkingSwitchesPosition5_A;
				global::AcpBusinessLayer.AcpListField switchConventionalSwitchesPosition5_A;
				global::Motorola.MackinawCPS.CoreFeatures.Switches.TrunkingSwitches trunkingSwitches;
				global::AcpBusinessLayer.AcpListField switchTrunkingSwitchesPosition3_A;
				global::AcpBusinessLayer.AcpListField switchConventionalSwitchesPosition3_A;
				global::Motorola.MackinawCPS.CoreFeatures.Buttons.PortableButtonInnerRecset portableButtonInnerRecset;
				global::Motorola.MackinawCPS.CoreFeatures.SmartKeyFob.SmartKeyFobButtonTableInnerRecset smartKeyFobButtonTableInnerRecset;
				global::AcpBusinessLayer.AcpListField switchConventionalSwitchesPosition4_A;
				global::Motorola.MackinawCPS.CoreFeatures.RemoteSpeakerMic.RSMButtonInnerRecset rsmbuttonInnerRecset;
				for (;;)
				{
					IL_28:
					global::System.Collections.Generic.IEnumerator<global::AcpBusinessLayer.FeatureNode> enumerator;
					bool flag2;
					bool flag3;
					int num5;
					int num6;
					int num7;
					bool flag4;
					switch (num2)
					{
					case 0:
						return flag;
					case 1:
						flag = false;
						num = (short)1734410260;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 2:
						try
						{
							num = (short)834469896;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								switch (num2)
								{
								case 0:
									goto IL_57E;
								case 1:
									num = (short)1593507846;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 2:
									num = (short)611909637;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 3:
								{
									global::AcpCommonLib.IAcpFeatureNode acpFeatureNode;
									if ((acpFeatureNode[10092] as global::Motorola.MackinawCPS.CoreFeatures.Buttons.PortableButtonInnerSection).BtnTrunkingPortableTrunkingBCO_A19545.Value != 148)
									{
										num = (short)1105854466;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									break;
								}
								case 4:
									flag = false;
									num = (short)628359168;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 5:
								{
									global::AcpCommonLib.IAcpFeatureNode acpFeatureNode;
									if ((acpFeatureNode[10092] as global::Motorola.MackinawCPS.CoreFeatures.Buttons.PortableButtonInnerSection).BtnTrunkingPortableButtonFeature_A19546.Value == 31)
									{
										num = (short)17104900;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									break;
								}
								case 6:
									goto IL_633;
								case 7:
								{
									if (!enumerator.MoveNext())
									{
										num = (short)1221525505;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									global::AcpCommonLib.IAcpFeatureNode acpFeatureNode = enumerator.Current;
									num = (short)873857027;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 8:
									switch (0)
									{
									case 0:
										goto IL_506;
									}
									continue;
								}
								IL_583:
								num = (short)781320199;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								IL_506:
								goto IL_583;
							}
							IL_57E:
							IL_633:
							goto IL_EDF;
						}
						finally
						{
							num = (short)1797914626;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								switch (num2)
								{
								case 0:
									goto IL_6F5;
								case 1:
									enumerator.Dispose();
									num = (short)53739520;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 2:
									switch (0)
									{
									case 0:
										goto IL_66B;
									}
									continue;
								}
								IL_66B:
								if (enumerator == null)
								{
									break;
								}
								num = (short)1723058034;
								short num3 = num;
								num = (short)756270962;
								switch ((num3 == num) ? 1 : 0)
								{
								case 0:
								case 2:
									break;
								default:
									num = (short)1182203904;
									if (num != 0)
									{
									}
									num = (short)1868300289;
									num2 = (int)((global::System.IntPtr)num);
									break;
								}
							}
							IL_6F5:;
						}
						goto IL_6F8;
					case 3:
						num = (short)783876169;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 4:
						num = (short)1363542057;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 5:
					{
						if (index != 46)
						{
							num = (short)579534881;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						global::AcpCommonLib.IAcpRecordset feature = global::AcpCommonLib.FeatureManager.GetFeature(2088);
						num = (short)327745559;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 6:
						if (flag)
						{
							num = (short)870711336;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_1882;
					case 7:
						flag2 = (switchTrunkingSwitchesPosition5_A.Value == 30);
						goto IL_C3E;
					case 8:
						return flag;
					case 9:
						num = (short)2099052591;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 10:
						return flag;
					case 11:
						goto IL_15ED;
					case 12:
						if (index != 61)
						{
							num = (short)1111687214;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)938016796;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 13:
						if (switchConventionalSwitchesPosition5_A.Value == 29)
						{
							num = (short)377159699;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_71F;
					case 14:
						flag3 = true;
						goto IL_BFD;
					case 15:
						if (trunkingSwitches.SwitchTrunkingSwitchesPosition2_A9467.Value != 33)
						{
							num = (short)763166806;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_105E;
					case 16:
					{
						global::AcpCommonLib.IAcpRecordset feature2;
						global::Motorola.MackinawCPS.CoreFeatures.MenuItems.MenuItems menuItems = feature2[0] as global::Motorola.MackinawCPS.CoreFeatures.MenuItems.MenuItems;
						num = (short)431554650;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 17:
						flag = false;
						num = (short)1992556648;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 18:
						num = (short)1434255420;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 19:
						num = (short)545849415;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 20:
					{
						num = (short)1123024896;
						short num4 = num;
						goto IL_1693;
					}
					case 21:
						if (!global::ConstraintHelper.UtilityMack.IsMobile())
						{
							num = (short)408748054;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return flag;
					case 22:
					{
						global::AcpCommonLib.IAcpRecordset feature;
						global::Motorola.MackinawCPS.CoreFeatures.MenuItems.MenuItems menuItems2 = feature[0] as global::Motorola.MackinawCPS.CoreFeatures.MenuItems.MenuItems;
						num5 = 0;
						num = (short)2002976866;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 23:
					{
						global::AcpCommonLib.IAcpRecordset feature;
						if (feature != null)
						{
							num = (short)1593573448;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return flag;
					}
					case 24:
						if (flag)
						{
							num = (short)1928986661;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_EDF;
					case 25:
						flag2 = false;
						goto IL_C3E;
					case 26:
					{
						global::Motorola.MackinawCPS.CoreFeatures.MenuItems.MenuItems menuItems;
						if (menuItems.General.DispMenuTrunkingSelectedMenuItems_A21735.Items[num6].ItemName == global::CommonResources.AcgResources.ID_SCAN)
						{
							num = (short)1194721281;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_1693;
					}
					case 27:
						if (switchTrunkingSwitchesPosition3_A.Value == 30)
						{
							num = (short)222756944;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_1552;
					case 28:
						if (trunkingSwitches.RefRadioErgonomicsWide.Advanced.RadErgoWideAdvancedSideButtonsLockEnable_A38725.Value)
						{
							num = (short)1594622036;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_EDF;
					case 29:
						goto IL_F4F;
					case 30:
						num = (short)2089091104;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 31:
						if (flag)
						{
							num = (short)627834933;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_480;
					case 32:
						if (switchConventionalSwitchesPosition3_A.Value == 30)
						{
							num = (short)319160387;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_1552;
					case 33:
						num = (short)2041446412;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 34:
						if (switchConventionalSwitchesPosition5_A.Value == 30)
						{
							num = (short)1039990875;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_1552;
					case 35:
						if (index != 195)
						{
							num = (short)1901920330;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						flag = false;
						num = (short)1831993354;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 36:
						goto IL_15ED;
					case 37:
						enumerator = portableButtonInnerRecset.GetEnumerator();
						num = (short)646053890;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 38:
						num = (short)348127253;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 39:
						goto IL_F4F;
					case 40:
						enumerator = portableButtonInnerRecset.GetEnumerator();
						num = (short)1497301094;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 41:
						if (index != 194)
						{
							num = (short)533069872;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						flag = false;
						num = (short)1056964616;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 42:
					{
						global::AcpCommonLib.IAcpRecordset feature2;
						if (feature2.Count != 0)
						{
							num = (short)144965648;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_480;
					}
					case 43:
						return flag;
					case 44:
						num = (short)1768685573;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 45:
						num7 = 0;
						num = (short)1973485604;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 46:
						num = (short)667156537;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 47:
						flag3 = (switchTrunkingSwitchesPosition5_A.Value != 33);
						goto IL_BFD;
					case 48:
						num = (short)1752301603;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 49:
						if (switchTrunkingSwitchesPosition3_A.Value == 29)
						{
							num = (short)892207168;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_71F;
					case 50:
						goto IL_480;
					case 51:
						if (switchTrunkingSwitchesPosition3_A.Value == 33)
						{
							num = (short)2129592329;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)1495203854;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 52:
					{
						global::Motorola.MackinawCPS.CoreFeatures.MenuItems.MenuItems menuItems2;
						if (num5 >= menuItems2.General.DispMenuTrunkingSelectedMenuItems_A21735.Items.Count)
						{
							num = (short)354484227;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)654573665;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 53:
					{
						global::AcpCommonLib.IAcpRecordset feature2 = global::AcpCommonLib.FeatureManager.GetFeature(2088);
						num = (short)301596749;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 54:
					{
						global::Motorola.MackinawCPS.CoreFeatures.MenuItems.MenuItems menuItems;
						if (num6 >= menuItems.General.DispMenuTrunkingSelectedMenuItems_A21735.Items.Count)
						{
							num = (short)990117938;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)814415898;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 55:
						flag3 = false;
						goto IL_BFD;
					case 56:
						if (index != 81)
						{
							num = (short)1270087684;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						flag = false;
						num = (short)470024274;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 57:
						return flag;
					case 58:
						flag4 = false;
						goto IL_107C;
					case 59:
						if (flag)
						{
							num = (short)1221197909;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return flag;
					case 60:
						switch (index)
						{
						case 27:
							flag = false;
							num = (short)183894016;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 28:
						case 31:
						case 32:
							return flag;
						case 29:
							num = (short)1606090847;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 30:
							num = (short)418971726;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 33:
							num = (short)439812158;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						default:
							num = (short)741867564;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						break;
					case 61:
						if (switchConventionalSwitchesPosition3_A.Value == 29)
						{
							num = (short)1094516832;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_71F;
					case 62:
						if (trunkingSwitches.SwitchTrunkingSwitchesPosition1_A9466.Value != 33)
						{
							num = (short)1232404583;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_105E;
					case 63:
						enumerator = smartKeyFobButtonTableInnerRecset.GetEnumerator();
						num = (short)844365924;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 64:
						num = (short)400883725;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 65:
					{
						global::AcpCommonLib.IAcpRecordset feature;
						if (feature.Count != 0)
						{
							num = (short)808386598;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return flag;
					}
					case 66:
						num = (short)166592554;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 67:
						num = (short)560857115;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 68:
						num = (short)1823539261;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 69:
						try
						{
							num = (short)1016004616;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								switch (num2)
								{
								case 0:
								{
									global::AcpCommonLib.IAcpFeatureNode acpFeatureNode2;
									if ((acpFeatureNode2[10080] as global::Motorola.MackinawCPS.CoreFeatures.RemoteSpeakerMic.RSMButtonInnerSection).RadErgoCfgRSMTrunkingBCO_A19741.Value != 151)
									{
										num = (short)265224199;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									break;
								}
								case 1:
								{
									if (!enumerator.MoveNext())
									{
										num = (short)1478098949;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									global::AcpCommonLib.IAcpFeatureNode acpFeatureNode2 = enumerator.Current;
									num = (short)1305411584;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 2:
									flag = false;
									num = (short)535166980;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 3:
								{
									global::AcpCommonLib.IAcpFeatureNode acpFeatureNode2;
									if ((acpFeatureNode2[10080] as global::Motorola.MackinawCPS.CoreFeatures.RemoteSpeakerMic.RSMButtonInnerSection).RadErgoCfgRSMlTrunkingFeature_A19742.Value == 31)
									{
										num = (short)606208002;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									break;
								}
								case 4:
									goto IL_9CE;
								case 5:
									num = (short)109772806;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 6:
									goto IL_9EC;
								case 7:
									num = (short)988741635;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 8:
									switch (0)
									{
									case 0:
										goto IL_8BE;
									}
									continue;
								}
								IL_973:
								num = (short)1216806913;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								IL_8BE:
								goto IL_973;
							}
							IL_9CE:
							IL_9EC:
							goto IL_1466;
						}
						finally
						{
							num = (short)1277493250;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								switch (num2)
								{
								case 0:
									goto IL_A5D;
								case 1:
									enumerator.Dispose();
									num = (short)941096960;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 2:
									switch (0)
									{
									case 0:
										goto IL_A23;
									}
									continue;
								}
								IL_A23:
								if (enumerator == null)
								{
									break;
								}
								num = (short)895221761;
								num2 = (int)((global::System.IntPtr)num);
							}
							IL_A5D:;
						}
						goto Block_13;
						IL_1466:
						num = (short)1861746712;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 70:
						num6 = 0;
						num = (short)1931345949;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 71:
						flag4 = (switchTrunkingSwitchesPosition5_A.Value == 29);
						goto IL_107C;
					case 72:
						num = (short)1370882113;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 73:
						return flag;
					case 74:
						goto IL_12ED;
					case 75:
						if (flag)
						{
							num = (short)1252982847;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_DD6;
					case 76:
						goto IL_A60;
					case 77:
					{
						global::AcpCommonLib.IAcpRecordset feature2;
						if (feature2 != null)
						{
							num = (short)949682242;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_480;
					}
					case 78:
						if (switchConventionalSwitchesPosition4_A.Value == 30)
						{
							num = (short)1683292190;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_1552;
					case 79:
						goto IL_801;
					case 80:
						num = (short)639500322;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 81:
						flag = false;
						num = (short)60096604;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 82:
						return flag;
					case 83:
						return flag;
					case 84:
						enumerator = rsmbuttonInnerRecset.GetEnumerator();
						num = (short)1697644613;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 85:
						goto IL_6F8;
					case 86:
						num = (short)1772814387;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 87:
						if (trunkingSwitches.RefRadioErgonomicsWide.Advanced.RadErgoWideAdvancedToggleSwitchLockEnable_43773.Value)
						{
							num = (short)345505873;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return flag;
					case 88:
						flag = false;
						num = (short)2056912989;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 89:
					{
						global::Motorola.MackinawCPS.CoreFeatures.MenuItems.MenuItems menuItems;
						if (num7 >= menuItems.General.DispMenuConventionalSelectedMenuItems_A21736.Items.Count)
						{
							num = (short)1498742854;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)645660773;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 90:
						if (!global::ConstraintHelper.UtilityMack.IsMobile())
						{
							num = (short)38600749;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_480;
					case 91:
						num = (short)263716871;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 92:
						return flag;
					case 93:
						goto IL_103B;
					case 94:
						if (index <= 61)
						{
							num = (short)902103058;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)1389494328;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 95:
						if (switchConventionalSwitchesPosition4_A.Value == 29)
						{
							num = (short)1392574532;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_71F;
					case 96:
						num = (short)1442316337;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 97:
					{
						global::Motorola.MackinawCPS.CoreFeatures.MenuItems.MenuItems menuItems2;
						if (menuItems2.General.DispMenuTrunkingSelectedMenuItems_A21735.Items[num5].ItemName == global::CommonResources.AcgResources.ID_SCNL)
						{
							num = (short)1339949144;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_103B;
					}
					case 98:
						num = (short)134086657;
						if (num != 0)
						{
						}
						goto IL_801;
					case 99:
						return flag;
					case 100:
						try
						{
							num = (short)232521737;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								switch (num2)
								{
								case 0:
								{
									global::AcpCommonLib.IAcpFeatureNode acpFeatureNode3;
									if ((acpFeatureNode3[10748] as global::Motorola.MackinawCPS.CoreFeatures.SmartKeyFob.SmartKeyFobButtonTableInnerSection).RadErgoCfgFobTrunkingFeature_A41575.Value == 33)
									{
										num = (short)1271726088;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									break;
								}
								case 1:
								{
									global::AcpCommonLib.IAcpFeatureNode acpFeatureNode3;
									if ((acpFeatureNode3[10748] as global::Motorola.MackinawCPS.CoreFeatures.SmartKeyFob.SmartKeyFobButtonTableInnerSection).RadErgoCfgFobConventionalFeature_A41574.Value == 33)
									{
										num = (short)81723395;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									num = (short)1140129792;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 2:
								{
									if (!enumerator.MoveNext())
									{
										num = (short)1324548102;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									global::AcpCommonLib.IAcpFeatureNode acpFeatureNode3 = enumerator.Current;
									num = (short)838467585;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 3:
									flag = false;
									num = (short)1201799173;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 4:
									goto IL_114B;
								case 5:
									goto IL_125B;
								case 6:
									num = (short)104005639;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 7:
									goto IL_1279;
								case 8:
									flag = false;
									num = (short)928972804;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 9:
									switch (0)
									{
									case 0:
										goto IL_112E;
									}
									continue;
								}
								IL_1200:
								num = (short)1969029122;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								IL_112E:
								goto IL_1200;
							}
							IL_114B:
							IL_125B:
							IL_1279:
							goto IL_DD6;
						}
						finally
						{
							num = (short)764674050;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								switch (num2)
								{
								case 0:
									goto IL_12EA;
								case 1:
									enumerator.Dispose();
									num = (short)1150681088;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 2:
									switch (0)
									{
									case 0:
										goto IL_12B2;
									}
									continue;
								}
								IL_12B2:
								if (enumerator == null)
								{
									break;
								}
								num = (short)1050607617;
								num2 = (int)((global::System.IntPtr)num);
							}
							IL_12EA:;
						}
						goto IL_12ED;
					case 101:
					{
						global::Motorola.MackinawCPS.CoreFeatures.MenuItems.MenuItems menuItems;
						if (menuItems.General.DispMenuConventionalSelectedMenuItems_A21736.Items[num7].ItemName == global::CommonResources.AcgResources.ID_SCAN)
						{
							num = (short)1818624017;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_DB2;
					}
					case 102:
						try
						{
							num = (short)1140260870;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								switch (num2)
								{
								case 0:
									if (!enumerator.MoveNext())
									{
										num = (short)1739915266;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									num = (short)923598853;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 1:
									flag = false;
									num = (short)122880003;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 2:
									num = (short)1787428868;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 4:
									goto IL_1813;
								case 5:
								{
									global::AcpBusinessLayer.FeatureNode featureNode = enumerator.Current;
									if ((((global::AcpCommonLib.IAcpFeatureNode)featureNode)[10092] as global::Motorola.MackinawCPS.CoreFeatures.Buttons.PortableButtonInnerSection).BtnGeneralConventionalFeature_A19544.Value == 33)
									{
										flag = false;
									}
									if ((((global::AcpCommonLib.IAcpFeatureNode)featureNode)[10092] as global::Motorola.MackinawCPS.CoreFeatures.Buttons.PortableButtonInnerSection).BtnTrunkingPortableButtonFeature_A19546.Value == 33)
									{
										num = (short)278003713;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									break;
								}
								case 6:
									switch (0)
									{
									case 0:
										goto IL_1722;
									}
									continue;
								}
								IL_1724:
								num = (short)1662058496;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								IL_1722:
								goto IL_1724;
							}
							IL_1813:;
						}
						finally
						{
							num = (short)813170690;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								switch (num2)
								{
								case 0:
									goto IL_187F;
								case 1:
									enumerator.Dispose();
									num = (short)700710912;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 2:
									switch (0)
									{
									case 0:
										goto IL_1848;
									}
									continue;
								}
								IL_1848:
								if (enumerator == null)
								{
									break;
								}
								num = (short)484048897;
								num2 = (int)((global::System.IntPtr)num);
							}
							IL_187F:;
						}
						goto IL_1882;
					case 103:
						num = (short)479854607;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 104:
						goto IL_DB2;
					}
					goto IL_1D3;
					IL_480:
					num = (short)1636892747;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_6F8:
					enumerator = rsmbuttonInnerRecset.GetEnumerator();
					num = (short)132907084;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_71F:
					num = (short)1732182074;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_801:
					num = (short)1062862900;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_BFD:
					flag = flag3;
					num = (short)243859487;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					Block_13:
					try
					{
						IL_A60:
						num = (short)1486946310;
						num2 = (int)((global::System.IntPtr)num);
						for (;;)
						{
							switch (num2)
							{
							case 0:
							{
								global::AcpBusinessLayer.FeatureNode featureNode2 = enumerator.Current;
								if ((((global::AcpCommonLib.IAcpFeatureNode)featureNode2)[10080] as global::Motorola.MackinawCPS.CoreFeatures.RemoteSpeakerMic.RSMButtonInnerSection).RadErgoCfgRSMlConventionalFeature_A19640.Value == 33)
								{
									flag = false;
								}
								if ((((global::AcpCommonLib.IAcpFeatureNode)featureNode2)[10080] as global::Motorola.MackinawCPS.CoreFeatures.RemoteSpeakerMic.RSMButtonInnerSection).RadErgoCfgRSMlTrunkingFeature_A19742.Value == 33)
								{
									num = (short)989003777;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								break;
							}
							case 1:
								flag = false;
								num = (short)1951989763;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							case 2:
								if (!enumerator.MoveNext())
								{
									num = (short)2077097989;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								num = (short)72744960;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							case 4:
								goto IL_B8B;
							case 5:
								num = (short)1802502148;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							case 6:
								switch (0)
								{
								case 0:
									goto IL_AA2;
								}
								continue;
							}
							IL_AE0:
							num = (short)1750990850;
							num2 = (int)((global::System.IntPtr)num);
							continue;
							IL_AA2:
							goto IL_AE0;
						}
						IL_B8B:
						break;
					}
					finally
					{
						num = (short)1119289346;
						num2 = (int)((global::System.IntPtr)num);
						for (;;)
						{
							switch (num2)
							{
							case 0:
								goto IL_BFA;
							case 1:
								enumerator.Dispose();
								num = (short)977797120;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							case 2:
								switch (0)
								{
								case 0:
									goto IL_BC3;
								}
								continue;
							}
							IL_BC3:
							if (enumerator == null)
							{
								break;
							}
							num = (short)779812865;
							num2 = (int)((global::System.IntPtr)num);
						}
						IL_BFA:;
					}
					goto IL_BFD;
					IL_C3E:
					flag = flag2;
					num = (short)1741488227;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_DB2:
					num7++;
					num = (short)445251595;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_DD6:
					num = (short)1642921990;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_EDF:
					num = (short)1662320727;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_F4F:
					num = (short)374734902;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_103B:
					num5++;
					num = (short)1880293455;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_105E:
					num = (short)2091253815;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_107C:
					flag = flag4;
					num = (short)1816199211;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_12ED:
					num = (short)1588527187;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_1552:
					num = (short)1796079641;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_15ED:
					num = (short)1371275353;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_1693:
					num6++;
					num = (short)1623261223;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_1882:
					num = (short)643432507;
					num2 = (int)((global::System.IntPtr)num);
				}
				return flag;
				IL_1D3:
				trunkingSwitches = (self as global::Motorola.MackinawCPS.CoreFeatures.Switches.TrunkingSwitches);
				global::Motorola.MackinawCPS.CoreFeatures.Switches.Switches switches = self.Parent as global::Motorola.MackinawCPS.CoreFeatures.Switches.Switches;
				switchConventionalSwitchesPosition3_A = switches.ConventionalSwitches.SwitchConventionalSwitchesPosition3_A7737;
				switchConventionalSwitchesPosition4_A = switches.ConventionalSwitches.SwitchConventionalSwitchesPosition4_A21530;
				switchConventionalSwitchesPosition5_A = switches.ConventionalSwitches.SwitchConventionalSwitchesPosition5_A21531;
				switchTrunkingSwitchesPosition3_A = trunkingSwitches.SwitchTrunkingSwitchesPosition3_A9468;
				switchTrunkingSwitchesPosition5_A = trunkingSwitches.SwitchTrunkingSwitchesPosition5_A21535;
				portableButtonInnerRecset = ((global::AcpCommonLib.FeatureManager.GetFeature(2042) as global::Motorola.MackinawCPS.CoreFeatures.Buttons.ButtonsRecset)[0][10091].EmbeddedRecset as global::Motorola.MackinawCPS.CoreFeatures.Buttons.PortableButtonInnerRecset);
				rsmbuttonInnerRecset = ((global::AcpCommonLib.FeatureManager.GetFeature(2036) as global::Motorola.MackinawCPS.CoreFeatures.RemoteSpeakerMic.RemoteSpeakerMicRecset)[0][10079].EmbeddedRecset as global::Motorola.MackinawCPS.CoreFeatures.RemoteSpeakerMic.RSMButtonInnerRecset);
				smartKeyFobButtonTableInnerRecset = ((global::AcpCommonLib.FeatureManager.GetFeature(4130) as global::Motorola.MackinawCPS.CoreFeatures.SmartKeyFob.SmartKeyFobRecset)[0][10747].EmbeddedRecset as global::Motorola.MackinawCPS.CoreFeatures.SmartKeyFob.SmartKeyFobButtonTableInnerRecset);
				flag = true;
				num = (short)305594462;
				num2 = (int)((global::System.IntPtr)num);
				goto IL_28;
			}
			}
		}

		// Token: 0x060073AC RID: 29612 RVA: 0x0067A4A4 File Offset: 0x006786A4
		internal static bool ConSwitchesTrkPos3(global::AcpCommonLib.IAcpFeatureSection self, int index)
		{
			short num = (short)1845821440;
			int num2 = (int)num;
			switch (num2)
			{
			default:
			{
				switch (0)
				{
				case 0:
					goto IL_1D3;
				}
				global::Motorola.MackinawCPS.CoreFeatures.RemoteSpeakerMic.RSMButtonInnerRecset rsmbuttonInnerRecset;
				global::AcpBusinessLayer.AcpListField switchTrunkingSwitchesPosition5_A;
				bool flag2;
				global::AcpBusinessLayer.AcpListField switchConventionalSwitchesPosition3_A;
				global::AcpBusinessLayer.AcpListField switchConventionalSwitchesPosition4_A;
				global::AcpBusinessLayer.AcpListField switchConventionalSwitchesPosition5_A;
				global::Motorola.MackinawCPS.CoreFeatures.Buttons.PortableButtonInnerRecset portableButtonInnerRecset;
				global::Motorola.MackinawCPS.CoreFeatures.Switches.TrunkingSwitches trunkingSwitches;
				global::AcpBusinessLayer.AcpListField switchTrunkingSwitchesPosition4_A;
				global::Motorola.MackinawCPS.CoreFeatures.SmartKeyFob.SmartKeyFobButtonTableInnerRecset smartKeyFobButtonTableInnerRecset;
				for (;;)
				{
					IL_28:
					global::System.Collections.Generic.IEnumerator<global::AcpBusinessLayer.FeatureNode> enumerator;
					bool flag;
					int num3;
					int num4;
					bool flag3;
					int num6;
					bool flag4;
					switch (num2)
					{
					case 0:
						enumerator = rsmbuttonInnerRecset.GetEnumerator();
						num = (short)815464450;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 1:
						flag = (switchTrunkingSwitchesPosition5_A.Value == 29);
						goto IL_107C;
					case 2:
						try
						{
							num = (short)1657274373;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								switch (num2)
								{
								case 0:
									num = (short)1413873665;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 1:
								{
									global::AcpCommonLib.IAcpFeatureNode acpFeatureNode;
									if ((acpFeatureNode[10080] as global::Motorola.MackinawCPS.CoreFeatures.RemoteSpeakerMic.RSMButtonInnerSection).RadErgoCfgRSMlTrunkingFeature_A19742.Value == 31)
									{
										num = (short)2093481990;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									break;
								}
								case 2:
									goto IL_9AA;
								case 3:
									goto IL_9C7;
								case 4:
								{
									if (!enumerator.MoveNext())
									{
										num = (short)1734148103;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									global::AcpCommonLib.IAcpFeatureNode acpFeatureNode = enumerator.Current;
									num = (short)671350792;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 5:
									switch (0)
									{
									case 0:
										goto IL_899;
									}
									continue;
								case 6:
									flag2 = false;
									num = (short)88932354;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 7:
									num = (short)1422131203;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 8:
								{
									global::AcpCommonLib.IAcpFeatureNode acpFeatureNode;
									if ((acpFeatureNode[10080] as global::Motorola.MackinawCPS.CoreFeatures.RemoteSpeakerMic.RSMButtonInnerSection).RadErgoCfgRSMTrunkingBCO_A19741.Value != 151)
									{
										num = (short)1948712960;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									break;
								}
								}
								IL_94F:
								num = (short)1835597828;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								IL_899:
								goto IL_94F;
							}
							IL_9AA:
							IL_9C7:
							goto IL_143F;
						}
						finally
						{
							num = (short)1531576320;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								switch (num2)
								{
								case 0:
									switch (0)
									{
									case 0:
										goto IL_9FE;
									}
									continue;
								case 1:
									goto IL_A37;
								case 2:
									enumerator.Dispose();
									num = (short)1720582145;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								IL_9FE:
								if (enumerator == null)
								{
									break;
								}
								num = (short)285671426;
								num2 = (int)((global::System.IntPtr)num);
							}
							IL_A37:;
						}
						goto Block_13;
						IL_143F:
						num = (short)511508515;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 3:
						if (switchConventionalSwitchesPosition3_A.Value == 29)
						{
							num = (short)1005584456;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_6CC;
					case 4:
						num = (short)632094797;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 5:
						if (switchConventionalSwitchesPosition4_A.Value == 30)
						{
							num = (short)1999044656;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_1524;
					case 6:
						if (switchConventionalSwitchesPosition5_A.Value == 29)
						{
							num = (short)946864203;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_6CC;
					case 7:
					{
						global::Motorola.MackinawCPS.CoreFeatures.MenuItems.MenuItems menuItems;
						if (num3 >= menuItems.General.DispMenuTrunkingSelectedMenuItems_A21735.Items.Count)
						{
							num = (short)1702690847;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)1652949018;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 8:
						goto IL_DD5;
					case 9:
					{
						global::AcpCommonLib.IAcpRecordset feature;
						global::Motorola.MackinawCPS.CoreFeatures.MenuItems.MenuItems menuItems2 = feature[0] as global::Motorola.MackinawCPS.CoreFeatures.MenuItems.MenuItems;
						num4 = 0;
						num = (short)496500765;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 10:
						goto IL_103B;
					case 11:
						enumerator = portableButtonInnerRecset.GetEnumerator();
						num = (short)973275237;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 12:
						try
						{
							num = (short)1337851904;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								switch (num2)
								{
								case 0:
									switch (0)
									{
									case 0:
										goto IL_112D;
									}
									continue;
								case 1:
									flag2 = false;
									num = (short)1238237189;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 2:
								{
									global::AcpCommonLib.IAcpFeatureNode acpFeatureNode2;
									if ((acpFeatureNode2[10748] as global::Motorola.MackinawCPS.CoreFeatures.SmartKeyFob.SmartKeyFobButtonTableInnerSection).RadErgoCfgFobConventionalFeature_A41574.Value == 33)
									{
										num = (short)1351483398;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									num = (short)1012989960;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 3:
								{
									if (!enumerator.MoveNext())
									{
										num = (short)1035403273;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									global::AcpCommonLib.IAcpFeatureNode acpFeatureNode2 = enumerator.Current;
									num = (short)1890320386;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 4:
									goto IL_1278;
								case 5:
									goto IL_114B;
								case 6:
									flag2 = false;
									num = (short)1850867719;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 7:
									goto IL_1259;
								case 8:
								{
									global::AcpCommonLib.IAcpFeatureNode acpFeatureNode2;
									if ((acpFeatureNode2[10748] as global::Motorola.MackinawCPS.CoreFeatures.SmartKeyFob.SmartKeyFobButtonTableInnerSection).RadErgoCfgFobTrunkingFeature_A41575.Value == 33)
									{
										num = (short)1316880385;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									break;
								}
								case 9:
									num = (short)918552580;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								IL_11FE:
								num = (short)1474166787;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								IL_112D:
								goto IL_11FE;
							}
							IL_114B:
							IL_1259:
							IL_1278:
							goto IL_DFA;
						}
						finally
						{
							num = (short)2043346944;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								switch (num2)
								{
								case 0:
									switch (0)
									{
									case 0:
										goto IL_12AF;
									}
									continue;
								case 1:
									enumerator.Dispose();
									num = (short)157351938;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 2:
									goto IL_12E6;
								}
								IL_12AF:
								if (enumerator == null)
								{
									break;
								}
								num = (short)441319425;
								num2 = (int)((global::System.IntPtr)num);
							}
							IL_12E6:;
						}
						goto IL_12E9;
					case 13:
						if (flag2)
						{
							num = (short)1728053295;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_DFA;
					case 14:
						flag3 = true;
						goto IL_C24;
					case 15:
						return flag2;
					case 16:
						if (flag2)
						{
							num = (short)1023148087;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_47F;
					case 17:
						num = (short)778240073;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 18:
						num = (short)1918566458;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 19:
						if (flag2)
						{
							num = (short)1874067558;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return flag2;
					case 20:
						if (index <= 61)
						{
							num = (short)556072984;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)522387457;
						if (num != 0)
						{
						}
						num = (short)624754787;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 21:
						return flag2;
					case 22:
						if (trunkingSwitches.RefRadioErgonomicsWide.Advanced.RadErgoWideAdvancedToggleSwitchLockEnable_43773.Value)
						{
							num = (short)1985806378;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return flag2;
					case 23:
						flag2 = false;
						num = (short)1698168842;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 24:
						num = (short)2007564353;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 25:
						if (switchTrunkingSwitchesPosition4_A.Value == 30)
						{
							num = (short)439091238;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_1524;
					case 26:
					{
						global::Motorola.MackinawCPS.CoreFeatures.MenuItems.MenuItems menuItems;
						if (menuItems.General.DispMenuTrunkingSelectedMenuItems_A21735.Items[num3].ItemName == global::CommonResources.AcgResources.ID_SCAN)
						{
							num = (short)825688105;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_1688;
					}
					case 27:
						num = (short)1333985354;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 28:
					{
						num = (short)654049280;
						short num5 = num;
						global::Motorola.MackinawCPS.CoreFeatures.MenuItems.MenuItems menuItems2;
						if (num4 >= menuItems2.General.DispMenuTrunkingSelectedMenuItems_A21735.Items.Count)
						{
							num = (short)1840644193;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)1123483714;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 29:
						goto IL_7B4;
					case 30:
						num = (short)284033115;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 31:
						goto IL_47F;
					case 32:
						if (trunkingSwitches.SwitchTrunkingSwitchesPosition1_A9466.Value != 33)
						{
							num = (short)1929248847;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_105E;
					case 33:
						flag2 = false;
						num = (short)207224840;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 34:
						num = (short)1793982528;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 35:
						if (flag2)
						{
							num = (short)178323467;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_F02;
					case 36:
						num = (short)1311113269;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 37:
						return flag2;
					case 38:
						num = (short)1316683828;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 39:
						if (!global::ConstraintHelper.UtilityMack.IsMobile())
						{
							num = (short)1238433872;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_47F;
					case 40:
					{
						global::AcpCommonLib.IAcpRecordset feature;
						if (feature != null)
						{
							num = (short)1665663006;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return flag2;
					}
					case 41:
						flag2 = false;
						num = (short)543752277;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 42:
						flag2 = false;
						num = (short)1928724580;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 43:
						goto IL_F74;
					case 44:
						if (trunkingSwitches.RefRadioErgonomicsWide.Advanced.RadErgoWideAdvancedSideButtonsLockEnable_A38725.Value)
						{
							num = (short)1727856640;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_F02;
					case 45:
						num3 = 0;
						num = (short)935329862;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 46:
						goto IL_7B4;
					case 47:
						enumerator = smartKeyFobButtonTableInnerRecset.GetEnumerator();
						num = (short)463470604;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 48:
						num = (short)1931608089;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 49:
						num = (short)1667039299;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 50:
						flag = false;
						goto IL_107C;
					case 51:
						flag3 = false;
						goto IL_C24;
					case 52:
						if (switchConventionalSwitchesPosition5_A.Value == 30)
						{
							num = (short)2070872081;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_1524;
					case 53:
						if (switchTrunkingSwitchesPosition4_A.Value == 33)
						{
							num = (short)1251672082;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)1275396110;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 54:
						return flag2;
					case 55:
					{
						global::AcpCommonLib.IAcpRecordset feature2 = global::AcpCommonLib.FeatureManager.GetFeature(2088);
						num = (short)1116471389;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 56:
						goto IL_12E9;
					case 57:
						num = (short)1034551301;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 58:
						flag3 = (switchTrunkingSwitchesPosition5_A.Value != 33);
						goto IL_C24;
					case 59:
						return flag2;
					case 60:
						goto IL_A3A;
					case 61:
						return flag2;
					case 62:
					{
						global::Motorola.MackinawCPS.CoreFeatures.MenuItems.MenuItems menuItems;
						if (menuItems.General.DispMenuConventionalSelectedMenuItems_A21736.Items[num6].ItemName == global::CommonResources.AcgResources.ID_SCAN)
						{
							num = (short)1892089889;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_DD5;
					}
					case 63:
						if (flag2)
						{
							num = (short)1494155356;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_1871;
					case 64:
						if (index != 194)
						{
							num = (short)1432682500;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						flag2 = false;
						num = (short)652279867;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 65:
						switch (index)
						{
						case 27:
							flag2 = false;
							num = (short)1955266621;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 28:
						case 31:
						case 32:
							return flag2;
						case 29:
							num = (short)532348931;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 30:
							num = (short)465764448;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 33:
							num = (short)1625423904;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						default:
							num = (short)844628050;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						break;
					case 66:
					{
						global::Motorola.MackinawCPS.CoreFeatures.MenuItems.MenuItems menuItems2;
						if (menuItems2.General.DispMenuTrunkingSelectedMenuItems_A21735.Items[num4].ItemName == global::CommonResources.AcgResources.ID_SCNL)
						{
							num = (short)168230935;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_103B;
					}
					case 67:
						return flag2;
					case 68:
						goto IL_15E5;
					case 69:
						num = (short)1804730444;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 70:
						goto IL_F74;
					case 71:
						return flag2;
					case 72:
						num = (short)2001076318;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 73:
						flag4 = (switchTrunkingSwitchesPosition5_A.Value == 30);
						goto IL_C62;
					case 74:
					{
						global::AcpCommonLib.IAcpRecordset feature2;
						if (feature2.Count != 0)
						{
							num = (short)334495825;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_47F;
					}
					case 75:
						num = (short)697565185;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 76:
						if (index != 61)
						{
							num = (short)1395589169;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)1620508716;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 77:
						if (index != 195)
						{
							num = (short)2012676152;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						flag2 = false;
						num = (short)544407636;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 78:
						flag4 = false;
						goto IL_C62;
					case 79:
						num = (short)1943339111;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 80:
						num6 = 0;
						num = (short)1477443673;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 81:
					{
						global::AcpCommonLib.IAcpRecordset feature2;
						global::Motorola.MackinawCPS.CoreFeatures.MenuItems.MenuItems menuItems = feature2[0] as global::Motorola.MackinawCPS.CoreFeatures.MenuItems.MenuItems;
						num = (short)577830951;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 82:
						num = (short)1764163667;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 83:
					{
						if (index != 46)
						{
							num = (short)123666501;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						global::AcpCommonLib.IAcpRecordset feature = global::AcpCommonLib.FeatureManager.GetFeature(2088);
						num = (short)522321960;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 84:
						return flag2;
					case 85:
						goto IL_1688;
					case 86:
						num = (short)19726431;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 87:
						num = (short)1269039202;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 88:
						try
						{
							num = (short)2136473602;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								switch (num2)
								{
								case 1:
									goto IL_1803;
								case 2:
									switch (0)
									{
									case 0:
										goto IL_1714;
									}
									continue;
								case 3:
									if (!enumerator.MoveNext())
									{
										num = (short)597819396;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									num = (short)1513947141;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 4:
									num = (short)1000734721;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 5:
								{
									global::AcpBusinessLayer.FeatureNode featureNode = enumerator.Current;
									if ((((global::AcpCommonLib.IAcpFeatureNode)featureNode)[10092] as global::Motorola.MackinawCPS.CoreFeatures.Buttons.PortableButtonInnerSection).BtnGeneralConventionalFeature_A19544.Value == 33)
									{
										flag2 = false;
									}
									if ((((global::AcpCommonLib.IAcpFeatureNode)featureNode)[10092] as global::Motorola.MackinawCPS.CoreFeatures.Buttons.PortableButtonInnerSection).BtnTrunkingPortableButtonFeature_A19546.Value == 33)
									{
										num = (short)1655570438;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									break;
								}
								case 6:
									flag2 = false;
									num = (short)1251672064;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								IL_1716:
								num = (short)114491395;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								IL_1714:
								goto IL_1716;
							}
							IL_1803:;
						}
						finally
						{
							num = (short)243138560;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								switch (num2)
								{
								case 0:
									switch (0)
									{
									case 0:
										goto IL_1837;
									}
									continue;
								case 1:
									enumerator.Dispose();
									num = (short)1891893250;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 2:
									goto IL_186E;
								}
								IL_1837:
								if (enumerator == null)
								{
									break;
								}
								num = (short)1001127937;
								num2 = (int)((global::System.IntPtr)num);
							}
							IL_186E:;
						}
						goto IL_1871;
					case 89:
						goto IL_15E5;
					case 90:
					{
						global::Motorola.MackinawCPS.CoreFeatures.MenuItems.MenuItems menuItems;
						if (num6 >= menuItems.General.DispMenuConventionalSelectedMenuItems_A21736.Items.Count)
						{
							num = (short)257753133;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)1193476158;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 91:
					{
						global::AcpCommonLib.IAcpRecordset feature;
						if (feature.Count != 0)
						{
							num = (short)1203634263;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return flag2;
					}
					case 92:
						enumerator = portableButtonInnerRecset.GetEnumerator();
						num = (short)1801453656;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 93:
					{
						global::AcpCommonLib.IAcpRecordset feature2;
						if (feature2 != null)
						{
							num = (short)649789467;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_47F;
					}
					case 94:
						if (switchConventionalSwitchesPosition4_A.Value == 29)
						{
							num = (short)146997334;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_6CC;
					case 95:
						if (switchTrunkingSwitchesPosition4_A.Value == 29)
						{
							num = (short)2045444200;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_6CC;
					case 96:
						if (switchConventionalSwitchesPosition3_A.Value == 30)
						{
							num = (short)569901113;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_1524;
					case 97:
						num = (short)2124742710;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 98:
						if (!global::ConstraintHelper.UtilityMack.IsMobile())
						{
							num = (short)1240268809;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return flag2;
					case 99:
						if (index != 81)
						{
							num = (short)1438973986;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						flag2 = false;
						num = (short)1503068231;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 100:
						return flag2;
					case 101:
						try
						{
							num = (short)410124293;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								switch (num2)
								{
								case 0:
								{
									if (!enumerator.MoveNext())
									{
										num = (short)1053163524;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									global::AcpCommonLib.IAcpFeatureNode acpFeatureNode3 = enumerator.Current;
									num = (short)1674182657;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 1:
								{
									global::AcpCommonLib.IAcpFeatureNode acpFeatureNode3;
									if ((acpFeatureNode3[10092] as global::Motorola.MackinawCPS.CoreFeatures.Buttons.PortableButtonInnerSection).BtnTrunkingPortableTrunkingBCO_A19545.Value != 148)
									{
										num = (short)1595211782;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									break;
								}
								case 2:
									flag2 = false;
									num = (short)539885576;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 3:
									goto IL_632;
								case 4:
									num = (short)817561603;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 5:
									switch (0)
									{
									case 0:
										goto IL_508;
									}
									continue;
								case 6:
									num = (short)1022820359;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 7:
								{
									global::AcpCommonLib.IAcpFeatureNode acpFeatureNode3;
									if ((acpFeatureNode3[10092] as global::Motorola.MackinawCPS.CoreFeatures.Buttons.PortableButtonInnerSection).BtnTrunkingPortableButtonFeature_A19546.Value == 31)
									{
										num = (short)1260060674;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									break;
								}
								case 8:
									goto IL_581;
								}
								IL_586:
								num = (short)1189871616;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								IL_508:
								goto IL_586;
							}
							IL_581:
							IL_632:
							goto IL_F02;
						}
						finally
						{
							num = (short)1413414912;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								switch (num2)
								{
								case 0:
									switch (0)
									{
									case 0:
										goto IL_66A;
									}
									continue;
								case 1:
									goto IL_6A2;
								case 2:
									enumerator.Dispose();
									num = (short)1684996097;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								IL_66A:
								if (enumerator == null)
								{
									break;
								}
								num = (short)1701249026;
								num2 = (int)((global::System.IntPtr)num);
							}
							IL_6A2:;
						}
						goto IL_6A5;
					case 102:
						goto IL_6A5;
					case 103:
						if (trunkingSwitches.SwitchTrunkingSwitchesPosition2_A9467.Value != 33)
						{
							num = (short)131203108;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_105E;
					case 104:
						num = (short)648413190;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_1D3;
					IL_47F:
					num = (short)1750204429;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_6A5:
					enumerator = rsmbuttonInnerRecset.GetEnumerator();
					num = (short)756219964;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_6CC:
					num = (short)1732116530;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_7B4:
					num = (short)1382809628;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_C24:
					flag2 = flag3;
					num = (short)280035344;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					Block_13:
					try
					{
						IL_A3A:
						num = (short)869728259;
						num2 = (int)((global::System.IntPtr)num);
						for (;;)
						{
							switch (num2)
							{
							case 0:
								goto IL_B67;
							case 1:
								flag2 = false;
								num = (short)969015301;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							case 2:
								num = (short)1041432576;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							case 3:
								switch (0)
								{
								case 0:
									goto IL_A7C;
								}
								continue;
							case 4:
							{
								global::AcpBusinessLayer.FeatureNode featureNode2 = enumerator.Current;
								if ((((global::AcpCommonLib.IAcpFeatureNode)featureNode2)[10080] as global::Motorola.MackinawCPS.CoreFeatures.RemoteSpeakerMic.RSMButtonInnerSection).RadErgoCfgRSMlConventionalFeature_A19640.Value == 33)
								{
									flag2 = false;
								}
								if ((((global::AcpCommonLib.IAcpFeatureNode)featureNode2)[10080] as global::Motorola.MackinawCPS.CoreFeatures.RemoteSpeakerMic.RSMButtonInnerSection).RadErgoCfgRSMlTrunkingFeature_A19742.Value == 33)
								{
									num = (short)2146107393;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								break;
							}
							case 6:
								if (!enumerator.MoveNext())
								{
									num = (short)564527106;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								num = (short)667222020;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							IL_ABB:
							num = (short)593821702;
							num2 = (int)((global::System.IntPtr)num);
							continue;
							IL_A7C:
							goto IL_ABB;
						}
						IL_B67:
						break;
					}
					finally
					{
						num = (short)890304015;
						short num7 = num;
						num = (short)1937765903;
						switch ((num7 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							IL_C03:
							enumerator.Dispose();
							num = (short)2147352577;
							num2 = (int)((global::System.IntPtr)num);
							break;
						default:
							num = (short)2045378560;
							if (num != 0)
							{
							}
							num = (short)1660354560;
							num2 = (int)((global::System.IntPtr)num);
							break;
						}
						for (;;)
						{
							switch (num2)
							{
							case 0:
								switch (0)
								{
								case 0:
									goto IL_BE9;
								}
								continue;
							case 1:
								goto IL_C21;
							case 2:
								goto IL_C03;
							}
							IL_BE9:
							if (enumerator == null)
							{
								break;
							}
							num = (short)188612610;
							num2 = (int)((global::System.IntPtr)num);
						}
						IL_C21:;
					}
					goto IL_C24;
					IL_C62:
					flag2 = flag4;
					num = (short)980221989;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_DD5:
					num6++;
					num = (short)742326340;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_DFA:
					num = (short)1243086911;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_F02:
					num = (short)1000931350;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_F74:
					num = (short)83165191;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_103B:
					num4++;
					num = (short)992149550;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_105E:
					num = (short)1319043123;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_107C:
					flag2 = flag;
					num = (short)280494101;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_12E9:
					num = (short)2052915215;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_1524:
					num = (short)957284430;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_15E5:
					num = (short)145883226;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_1688:
					num3++;
					num = (short)725876779;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_1871:
					num = (short)325582867;
					num2 = (int)((global::System.IntPtr)num);
				}
				return flag2;
				IL_1D3:
				trunkingSwitches = (self as global::Motorola.MackinawCPS.CoreFeatures.Switches.TrunkingSwitches);
				global::Motorola.MackinawCPS.CoreFeatures.Switches.Switches switches = self.Parent as global::Motorola.MackinawCPS.CoreFeatures.Switches.Switches;
				switchConventionalSwitchesPosition3_A = switches.ConventionalSwitches.SwitchConventionalSwitchesPosition3_A7737;
				switchConventionalSwitchesPosition4_A = switches.ConventionalSwitches.SwitchConventionalSwitchesPosition4_A21530;
				switchConventionalSwitchesPosition5_A = switches.ConventionalSwitches.SwitchConventionalSwitchesPosition5_A21531;
				switchTrunkingSwitchesPosition4_A = trunkingSwitches.SwitchTrunkingSwitchesPosition4_A21534;
				switchTrunkingSwitchesPosition5_A = trunkingSwitches.SwitchTrunkingSwitchesPosition5_A21535;
				portableButtonInnerRecset = ((global::AcpCommonLib.FeatureManager.GetFeature(2042) as global::Motorola.MackinawCPS.CoreFeatures.Buttons.ButtonsRecset)[0][10091].EmbeddedRecset as global::Motorola.MackinawCPS.CoreFeatures.Buttons.PortableButtonInnerRecset);
				rsmbuttonInnerRecset = ((global::AcpCommonLib.FeatureManager.GetFeature(2036) as global::Motorola.MackinawCPS.CoreFeatures.RemoteSpeakerMic.RemoteSpeakerMicRecset)[0][10079].EmbeddedRecset as global::Motorola.MackinawCPS.CoreFeatures.RemoteSpeakerMic.RSMButtonInnerRecset);
				smartKeyFobButtonTableInnerRecset = ((global::AcpCommonLib.FeatureManager.GetFeature(4130) as global::Motorola.MackinawCPS.CoreFeatures.SmartKeyFob.SmartKeyFobRecset)[0][10747].EmbeddedRecset as global::Motorola.MackinawCPS.CoreFeatures.SmartKeyFob.SmartKeyFobButtonTableInnerRecset);
				flag2 = true;
				num = (short)246743060;
				num2 = (int)((global::System.IntPtr)num);
				goto IL_28;
			}
			}
		}

		// Token: 0x060073AD RID: 29613 RVA: 0x0067C014 File Offset: 0x0067A214
		internal static bool ConSwitchesTrkPos2(global::AcpCommonLib.IAcpFeatureSection self, int index)
		{
			short num = (short)393412608;
			int num2 = (int)num;
			switch (num2)
			{
			default:
			{
				switch (0)
				{
				case 0:
					goto IL_20B;
				}
				global::AcpBusinessLayer.AcpListField switchConventionalSwitchesPosition1_A;
				global::Motorola.MackinawCPS.CoreFeatures.SmartKeyFob.SmartKeyFobButtonTableInnerRecset smartKeyFobButtonTableInnerRecset;
				bool flag;
				global::AcpBusinessLayer.AcpListField switchConventionalSwitchesPosition2_A;
				global::Motorola.MackinawCPS.CoreFeatures.RemoteSpeakerMic.RSMButtonInnerRecset rsmbuttonInnerRecset;
				global::Motorola.MackinawCPS.CoreFeatures.Switches.TrunkingSwitches trunkingSwitches;
				global::AcpBusinessLayer.AcpListField switchTrunkingSwitchesPosition1_A;
				global::AcpBusinessLayer.AcpField<bool> radWideFeaturesNFPACompliant;
				global::Motorola.MackinawCPS.CoreFeatures.Buttons.PortableButtonInnerRecset portableButtonInnerRecset;
				for (;;)
				{
					IL_28:
					bool flag2;
					bool flag3;
					bool flag4;
					int num5;
					int num6;
					bool flag5;
					bool flag6;
					int num7;
					bool flag7;
					switch (num2)
					{
					case 0:
						if (switchConventionalSwitchesPosition1_A.Value == 29)
						{
							num = (short)1673134102;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_1C4C;
					case 1:
						if (index != 194)
						{
							num = (short)1677197325;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)1515520059;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 2:
						num = (short)1406664819;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 3:
					{
						global::System.Collections.Generic.IEnumerator<global::AcpBusinessLayer.FeatureNode> enumerator = smartKeyFobButtonTableInnerRecset.GetEnumerator();
						num = (short)450428988;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 4:
						if (flag)
						{
							num = (short)1067253830;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return flag;
					case 5:
					{
						global::AcpCommonLib.IAcpRecordset feature;
						if (feature.Count != 0)
						{
							num = (short)1733230691;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_7A1;
					}
					case 6:
						num = (short)967770113;
						if (num != 0)
						{
						}
						goto IL_190D;
					case 7:
						if (index != 81)
						{
							num = (short)77987948;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						flag = false;
						num = (short)81723415;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 8:
						if (switchConventionalSwitchesPosition2_A.Value == 275)
						{
							num = (short)2000617523;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_16BA;
					case 9:
						num = (short)1786380293;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 10:
						goto IL_1280;
					case 11:
						num = (short)1688141913;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 12:
						return flag;
					case 13:
						num = (short)1667170316;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 14:
						flag2 = false;
						goto IL_4D5;
					case 15:
						flag = false;
						num = (short)1872625708;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 16:
						try
						{
							num = (short)1520435205;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								switch (num2)
								{
								case 0:
									goto IL_990;
								case 1:
								{
									global::AcpCommonLib.IAcpFeatureNode acpFeatureNode;
									if ((acpFeatureNode[10092] as global::Motorola.MackinawCPS.CoreFeatures.Buttons.PortableButtonInnerSection).BtnTrunkingPortableButtonFeature_A19546.Value == 31)
									{
										num = (short)1455357956;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									break;
								}
								case 2:
									num = (short)1123680257;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 3:
								{
									global::System.Collections.Generic.IEnumerator<global::AcpBusinessLayer.FeatureNode> enumerator;
									if (!enumerator.MoveNext())
									{
										num = (short)1752039431;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									global::AcpCommonLib.IAcpFeatureNode acpFeatureNode = enumerator.Current;
									num = (short)590020614;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 4:
									flag = false;
									num = (short)1815412736;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 5:
									switch (0)
									{
									case 0:
										goto IL_88B;
									}
									continue;
								case 6:
								{
									global::AcpCommonLib.IAcpFeatureNode acpFeatureNode;
									if ((acpFeatureNode[10092] as global::Motorola.MackinawCPS.CoreFeatures.Buttons.PortableButtonInnerSection).BtnTrunkingPortableTrunkingBCO_A19545.Value != 148)
									{
										num = (short)750714882;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									break;
								}
								case 7:
									num = (short)571670536;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 8:
									goto IL_9AE;
								}
								IL_8E7:
								num = (short)1050476547;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								IL_88B:
								goto IL_8E7;
							}
							IL_990:
							IL_9AE:
							return flag;
						}
						finally
						{
							num = (short)1529479170;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								global::System.Collections.Generic.IEnumerator<global::AcpBusinessLayer.FeatureNode> enumerator;
								switch (num2)
								{
								case 0:
									enumerator.Dispose();
									num = (short)2026766337;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 1:
									goto IL_A1F;
								case 2:
									switch (0)
									{
									case 0:
										goto IL_9E6;
									}
									continue;
								}
								IL_9E6:
								if (enumerator == null)
								{
									break;
								}
								num = (short)1564147712;
								num2 = (int)((global::System.IntPtr)num);
							}
							IL_A1F:;
						}
						goto IL_A22;
					case 17:
						if (switchConventionalSwitchesPosition1_A.Value == 30)
						{
							num = (short)735903842;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_4B6;
					case 18:
						flag3 = false;
						goto IL_1BC9;
					case 19:
						if (!global::ConstraintHelper.UtilityMack.IsMobile())
						{
							num = (short)1783693421;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_7A1;
					case 20:
						if (flag)
						{
							num = (short)1271922691;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_AE5;
					case 21:
						return flag;
					case 22:
						num = (short)1134231578;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 23:
						return flag;
					case 24:
						flag = false;
						num = (short)1331494955;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 25:
						switch (index)
						{
						case 27:
							goto IL_A22;
						case 28:
						case 31:
						case 32:
							return flag;
						case 29:
							num = (short)297336832;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 30:
							num = (short)1981546513;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 33:
							num = (short)1780285533;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						default:
							num = (short)545259612;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						break;
					case 26:
						if (switchConventionalSwitchesPosition2_A.Value == 29)
						{
							num = (short)1280770128;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_1C4C;
					case 27:
						num = (short)442892391;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 28:
						if (flag)
						{
							num = (short)1113194525;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_7A1;
					case 29:
					{
						global::AcpCommonLib.IAcpRecordset feature = global::AcpCommonLib.FeatureManager.GetFeature(2088);
						num = (short)237502519;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 30:
						return flag;
					case 31:
						num = (short)558760003;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 32:
					{
						num = (short)839319552;
						short num3 = num;
						num = (short)2065104953;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 33:
						try
						{
							num = (short)51576833;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								switch (num2)
								{
								case 0:
								{
									global::AcpCommonLib.IAcpFeatureNode acpFeatureNode2;
									if ((acpFeatureNode2[10080] as global::Motorola.MackinawCPS.CoreFeatures.RemoteSpeakerMic.RSMButtonInnerSection).RadErgoCfgRSMlTrunkingFeature_A19742.Value == 31)
									{
										num = (short)1720778760;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									break;
								}
								case 1:
									switch (0)
									{
									case 0:
										goto IL_E63;
									}
									continue;
								case 2:
									num = (short)715915264;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 3:
								{
									global::AcpCommonLib.IAcpFeatureNode acpFeatureNode2;
									if ((acpFeatureNode2[10080] as global::Motorola.MackinawCPS.CoreFeatures.RemoteSpeakerMic.RSMButtonInnerSection).RadErgoCfgRSMTrunkingBCO_A19741.Value != 151)
									{
										num = (short)326959106;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									break;
								}
								case 4:
								{
									global::System.Collections.Generic.IEnumerator<global::AcpBusinessLayer.FeatureNode> enumerator;
									if (!enumerator.MoveNext())
									{
										num = (short)260505605;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									global::AcpCommonLib.IAcpFeatureNode acpFeatureNode2 = enumerator.Current;
									num = (short)575209475;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 5:
									num = (short)1214513159;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 6:
									goto IL_F74;
								case 7:
									goto IL_F92;
								case 8:
									flag = false;
									num = (short)55705606;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								IL_F1A:
								num = (short)256376836;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								IL_E63:
								goto IL_F1A;
							}
							IL_F74:
							IL_F92:
							goto IL_C53;
						}
						finally
						{
							num = (short)1518565325;
							short num4 = num;
							num = (short)1407350733;
							global::System.Collections.Generic.IEnumerator<global::AcpBusinessLayer.FeatureNode> enumerator;
							switch ((num4 == num) ? 1 : 0)
							{
							case 0:
							case 2:
								IL_102C:
								enumerator.Dispose();
								num = (short)842792961;
								num2 = (int)((global::System.IntPtr)num);
								break;
							default:
								num = (short)2086862848;
								if (num != 0)
								{
								}
								num = (short)510066690;
								num2 = (int)((global::System.IntPtr)num);
								break;
							}
							for (;;)
							{
								switch (num2)
								{
								case 0:
									goto IL_102C;
								case 1:
									goto IL_104C;
								case 2:
									switch (0)
									{
									case 0:
										goto IL_1013;
									}
									continue;
								}
								IL_1013:
								if (enumerator == null)
								{
									break;
								}
								num = (short)1604583424;
								num2 = (int)((global::System.IntPtr)num);
							}
							IL_104C:;
						}
						goto IL_104F;
						IL_C53:
						num = (short)1045495812;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 34:
						num = (short)1693777976;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 35:
						num = (short)889651208;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 36:
						num = (short)778633257;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 37:
						goto IL_DC6;
					case 38:
						if (index <= 61)
						{
							num = (short)525926516;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)129499217;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 39:
					{
						global::System.Collections.Generic.IEnumerator<global::AcpBusinessLayer.FeatureNode> enumerator = rsmbuttonInnerRecset.GetEnumerator();
						num = (short)1056047176;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 40:
						flag4 = (switchConventionalSwitchesPosition2_A.Value == 194);
						goto IL_724;
					case 41:
						if (trunkingSwitches.SwitchTrunkingSwitchesPosition4_A21534.Value != 33)
						{
							num = (short)1314521151;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_1B07;
					case 42:
						if (flag)
						{
							num = (short)898695236;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_3A8;
					case 43:
						goto IL_743;
					case 44:
						goto IL_516;
					case 45:
						goto IL_DC6;
					case 46:
					{
						global::Motorola.MackinawCPS.CoreFeatures.MenuItems.MenuItems menuItems;
						if (menuItems.General.DispMenuTrunkingSelectedMenuItems_A21735.Items[num5].ItemName == global::CommonResources.AcgResources.ID_SCNL)
						{
							num = (short)1660420111;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_516;
					}
					case 47:
						goto IL_190D;
					case 48:
					{
						if (index != 46)
						{
							num = (short)948895793;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						global::AcpCommonLib.IAcpRecordset feature2 = global::AcpCommonLib.FeatureManager.GetFeature(2088);
						num = (short)1693515849;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 49:
						num = (short)807665751;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 50:
					{
						global::Motorola.MackinawCPS.CoreFeatures.MenuItems.MenuItems menuItems;
						if (num5 >= menuItems.General.DispMenuTrunkingSelectedMenuItems_A21735.Items.Count)
						{
							num = (short)2098200664;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)531759150;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 51:
						num = (short)991756350;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 52:
						if (trunkingSwitches.SwitchTrunkingSwitchesPosition3_A9468.Value != 33)
						{
							num = (short)187957284;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_1B07;
					case 53:
					{
						global::Motorola.MackinawCPS.CoreFeatures.MenuItems.MenuItems menuItems2;
						if (num6 >= menuItems2.General.DispMenuConventionalSelectedMenuItems_A21736.Items.Count)
						{
							num = (short)74514523;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)325517408;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 54:
						num = (short)616431668;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 55:
					{
						global::AcpCommonLib.IAcpRecordset feature;
						if (feature != null)
						{
							num = (short)399835145;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_7A1;
					}
					case 56:
						if (index != 275)
						{
							num = (short)1191706741;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)51773546;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 57:
						if (switchTrunkingSwitchesPosition1_A.Value == 27)
						{
							num = (short)1789919234;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_187F;
					case 58:
						return flag;
					case 59:
						if (switchConventionalSwitchesPosition1_A.Value == 81)
						{
							num = (short)1995636830;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_42C;
					case 60:
						try
						{
							num = (short)677445632;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								switch (num2)
								{
								case 0:
									switch (0)
									{
									case 0:
										goto IL_1321;
									}
									continue;
								case 1:
									flag = false;
									num = (short)372310018;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 2:
									goto IL_133E;
								case 3:
								{
									global::System.Collections.Generic.IEnumerator<global::AcpBusinessLayer.FeatureNode> enumerator;
									if (!enumerator.MoveNext())
									{
										num = (short)2097020934;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									global::AcpCommonLib.IAcpFeatureNode acpFeatureNode3 = enumerator.Current;
									num = (short)1404108804;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 4:
								{
									global::AcpCommonLib.IAcpFeatureNode acpFeatureNode3;
									if ((acpFeatureNode3[10748] as global::Motorola.MackinawCPS.CoreFeatures.SmartKeyFob.SmartKeyFobButtonTableInnerSection).RadErgoCfgFobConventionalFeature_A41574.Value == 33)
									{
										num = (short)787742721;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									num = (short)905510920;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 5:
									goto IL_1454;
								case 6:
									num = (short)291307527;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 7:
									goto IL_1471;
								case 8:
								{
									global::AcpCommonLib.IAcpFeatureNode acpFeatureNode3;
									if ((acpFeatureNode3[10748] as global::Motorola.MackinawCPS.CoreFeatures.SmartKeyFob.SmartKeyFobButtonTableInnerSection).RadErgoCfgFobTrunkingFeature_A41575.Value == 33)
									{
										num = (short)117506057;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									break;
								}
								case 9:
									flag = false;
									num = (short)1278410757;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								IL_13FB:
								num = (short)1379074051;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								IL_1321:
								goto IL_13FB;
							}
							IL_133E:
							IL_1454:
							IL_1471:
							goto IL_AE5;
						}
						finally
						{
							num = (short)1989279746;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								global::System.Collections.Generic.IEnumerator<global::AcpBusinessLayer.FeatureNode> enumerator;
								switch (num2)
								{
								case 0:
									enumerator.Dispose();
									num = (short)346816513;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 1:
									goto IL_14DF;
								case 2:
									switch (0)
									{
									case 0:
										goto IL_14A8;
									}
									continue;
								}
								IL_14A8:
								if (enumerator == null)
								{
									break;
								}
								num = (short)271777792;
								num2 = (int)((global::System.IntPtr)num);
							}
							IL_14DF:;
						}
						goto IL_14E2;
					case 61:
						flag5 = false;
						goto IL_19BB;
					case 62:
						if (switchTrunkingSwitchesPosition1_A.Value == 274)
						{
							num = (short)705560607;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_16BA;
					case 63:
						num = (short)2079981682;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 64:
						num = (short)515768360;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 65:
						return flag;
					case 66:
						if (switchTrunkingSwitchesPosition1_A.Value == 81)
						{
							num = (short)1182269504;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_42C;
					case 67:
						flag6 = radWideFeaturesNFPACompliant;
						goto IL_11BB;
					case 68:
					{
						global::System.Collections.Generic.IEnumerator<global::AcpBusinessLayer.FeatureNode> enumerator = portableButtonInnerRecset.GetEnumerator();
						num = (short)1756954726;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 69:
						goto IL_104F;
					case 70:
					{
						global::System.Collections.Generic.IEnumerator<global::AcpBusinessLayer.FeatureNode> enumerator = portableButtonInnerRecset.GetEnumerator();
						num = (short)1003094032;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 71:
						num = (short)1621884935;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 72:
						try
						{
							num = (short)1875312640;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								switch (num2)
								{
								case 0:
									switch (0)
									{
									case 0:
										goto IL_171B;
									}
									continue;
								case 1:
									goto IL_180C;
								case 2:
								{
									global::System.Collections.Generic.IEnumerator<global::AcpBusinessLayer.FeatureNode> enumerator;
									if (!enumerator.MoveNext())
									{
										num = (short)983367683;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									num = (short)1953693702;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 3:
									num = (short)1968766977;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 4:
									flag = false;
									num = (short)1316880389;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 6:
								{
									global::System.Collections.Generic.IEnumerator<global::AcpBusinessLayer.FeatureNode> enumerator;
									global::AcpBusinessLayer.FeatureNode featureNode = enumerator.Current;
									if ((((global::AcpCommonLib.IAcpFeatureNode)featureNode)[10080] as global::Motorola.MackinawCPS.CoreFeatures.RemoteSpeakerMic.RSMButtonInnerSection).RadErgoCfgRSMlConventionalFeature_A19640.Value == 33)
									{
										flag = false;
									}
									if ((((global::AcpCommonLib.IAcpFeatureNode)featureNode)[10080] as global::Motorola.MackinawCPS.CoreFeatures.RemoteSpeakerMic.RSMButtonInnerSection).RadErgoCfgRSMlTrunkingFeature_A19742.Value == 33)
									{
										num = (short)1370030084;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									break;
								}
								}
								IL_1776:
								num = (short)2110849026;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								IL_171B:
								goto IL_1776;
							}
							IL_180C:
							return flag;
						}
						finally
						{
							num = (short)845479938;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								global::System.Collections.Generic.IEnumerator<global::AcpBusinessLayer.FeatureNode> enumerator;
								switch (num2)
								{
								case 0:
									enumerator.Dispose();
									num = (short)259719169;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 1:
									goto IL_187C;
								case 2:
									switch (0)
									{
									case 0:
										goto IL_1844;
									}
									continue;
								}
								IL_1844:
								if (enumerator == null)
								{
									break;
								}
								num = (short)1483669504;
								num2 = (int)((global::System.IntPtr)num);
							}
							IL_187C:;
						}
						goto IL_187F;
					case 73:
					{
						global::AcpCommonLib.IAcpRecordset feature2;
						if (feature2 != null)
						{
							num = (short)2031026245;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return flag;
					}
					case 74:
					{
						global::Motorola.MackinawCPS.CoreFeatures.MenuItems.MenuItems menuItems2;
						if (menuItems2.General.DispMenuTrunkingSelectedMenuItems_A21735.Items[num7].ItemName == global::CommonResources.AcgResources.ID_SCAN)
						{
							num = (short)1252982808;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_743;
					}
					case 75:
						flag7 = false;
						goto IL_1BAA;
					case 76:
					{
						global::System.Collections.Generic.IEnumerator<global::AcpBusinessLayer.FeatureNode> enumerator = rsmbuttonInnerRecset.GetEnumerator();
						num = (short)24641569;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 77:
						return flag;
					case 78:
						if (!global::ConstraintHelper.UtilityMack.IsMobile())
						{
							num = (short)177995873;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return flag;
					case 79:
						if (switchConventionalSwitchesPosition1_A.Value == 27)
						{
							num = (short)1542783008;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_187F;
					case 80:
						num = (short)2033254505;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 81:
						if (index <= 194)
						{
							num = (short)276824135;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)1831534703;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 82:
						num = (short)701366350;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 83:
					{
						global::AcpCommonLib.IAcpRecordset feature2;
						if (feature2.Count != 0)
						{
							num = (short)1165885522;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return flag;
					}
					case 84:
						goto IL_1280;
					case 85:
						return flag;
					case 86:
						return flag;
					case 87:
						if (index != 61)
						{
							num = (short)1135411211;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_14E2;
					case 88:
						num = (short)275251277;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 89:
						return flag;
					case 90:
					{
						global::Motorola.MackinawCPS.CoreFeatures.MenuItems.MenuItems menuItems2;
						if (num7 >= menuItems2.General.DispMenuTrunkingSelectedMenuItems_A21735.Items.Count)
						{
							num = (short)891617398;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)1450836042;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 91:
						num7 = 0;
						num = (short)1873084500;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 92:
						num = (short)1214185520;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 93:
						if (switchTrunkingSwitchesPosition1_A.Value != 33)
						{
							num = (short)309067830;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_1B07;
					case 94:
						num = (short)728629314;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 95:
						if (switchConventionalSwitchesPosition2_A.Value == 30)
						{
							num = (short)1491927067;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_4B6;
					case 96:
					{
						global::Motorola.MackinawCPS.CoreFeatures.MenuItems.MenuItems menuItems2;
						if (menuItems2.General.DispMenuConventionalSelectedMenuItems_A21736.Items[num6].ItemName == global::CommonResources.AcgResources.ID_SCAN)
						{
							num = (short)1852833905;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_7DE;
					}
					case 97:
					{
						global::AcpCommonLib.IAcpRecordset feature2;
						global::Motorola.MackinawCPS.CoreFeatures.MenuItems.MenuItems menuItems = feature2[0] as global::Motorola.MackinawCPS.CoreFeatures.MenuItems.MenuItems;
						num5 = 0;
						num = (short)1376256047;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 98:
						num = (short)1097531487;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 99:
					{
						global::AcpCommonLib.IAcpRecordset feature;
						global::Motorola.MackinawCPS.CoreFeatures.MenuItems.MenuItems menuItems2 = feature[0] as global::Motorola.MackinawCPS.CoreFeatures.MenuItems.MenuItems;
						num = (short)431357971;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 100:
						goto IL_7DE;
					case 101:
						if (flag)
						{
							num = (short)756154407;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return flag;
					case 102:
						try
						{
							num = (short)378011652;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								switch (num2)
								{
								case 0:
									flag = false;
									num = (short)1268776965;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 1:
								{
									global::System.Collections.Generic.IEnumerator<global::AcpBusinessLayer.FeatureNode> enumerator;
									global::AcpBusinessLayer.FeatureNode featureNode2 = enumerator.Current;
									if ((((global::AcpCommonLib.IAcpFeatureNode)featureNode2)[10092] as global::Motorola.MackinawCPS.CoreFeatures.Buttons.PortableButtonInnerSection).BtnGeneralConventionalFeature_A19544.Value == 33)
									{
										flag = false;
									}
									if ((((global::AcpCommonLib.IAcpFeatureNode)featureNode2)[10092] as global::Motorola.MackinawCPS.CoreFeatures.Buttons.PortableButtonInnerSection).BtnTrunkingPortableButtonFeature_A19546.Value == 33)
									{
										num = (short)942866432;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									break;
								}
								case 2:
									num = (short)838270982;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 3:
								{
									global::System.Collections.Generic.IEnumerator<global::AcpBusinessLayer.FeatureNode> enumerator;
									if (!enumerator.MoveNext())
									{
										num = (short)221577218;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									num = (short)669581313;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 4:
									switch (0)
									{
									case 0:
										goto IL_5C0;
									}
									continue;
								case 6:
									goto IL_6B2;
								}
								IL_65B:
								num = (short)1979252739;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								IL_5C0:
								goto IL_65B;
							}
							IL_6B2:
							goto IL_3A8;
						}
						finally
						{
							num = (short)1615527936;
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
										goto IL_6E9;
									}
									continue;
								case 1:
									enumerator.Dispose();
									num = (short)1179844610;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 2:
									goto IL_721;
								}
								IL_6E9:
								if (enumerator == null)
								{
									break;
								}
								num = (short)1238499329;
								num2 = (int)((global::System.IntPtr)num);
							}
							IL_721:;
						}
						goto IL_724;
					case 103:
						flag3 = (switchTrunkingSwitchesPosition1_A.Value == 30);
						goto IL_1BC9;
					case 104:
						flag4 = false;
						goto IL_724;
					case 105:
						flag7 = (switchTrunkingSwitchesPosition1_A.Value == 29);
						goto IL_1BAA;
					case 106:
						if (switchConventionalSwitchesPosition1_A.Value == 274)
						{
							num = (short)2111373347;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_16BA;
					case 107:
						return flag;
					case 108:
						num = (short)1451360257;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 109:
						num6 = 0;
						num = (short)1035141165;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 110:
						flag6 = false;
						goto IL_11BB;
					case 111:
						if (index != 195)
						{
							num = (short)755892258;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)1170210895;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 112:
						if (trunkingSwitches.RefRadioErgonomicsWide.Advanced.RadErgoWideAdvancedSideButtonsLockEnable_A38725.Value)
						{
							num = (short)1158938700;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return flag;
					case 113:
						flag = false;
						num = (short)1237057636;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 114:
						flag2 = (trunkingSwitches.SwitchTrunkingSwitchesPosition5_A21535.Value != 33);
						goto IL_4D5;
					case 115:
						flag5 = (switchConventionalSwitchesPosition2_A.Value == 195);
						goto IL_19BB;
					case 116:
						num = (short)231735321;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 117:
						num = (short)727253022;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 118:
						goto IL_7A1;
					}
					goto IL_20B;
					IL_3A8:
					num = (short)1983184997;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_42C:
					num = (short)49479784;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_4B6:
					num = (short)721485842;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_4D5:
					flag = flag2;
					num = (short)310640668;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_516:
					num5++;
					num = (short)2022309894;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_724:
					flag = flag4;
					num = (short)804651115;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_743:
					num7++;
					num = (short)2090401802;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_7A1:
					num = (short)436011028;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_7DE:
					num6++;
					num = (short)1488519205;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_A22:
					flag = false;
					num = (short)1325727802;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_AE5:
					num = (short)1588002858;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_DC6:
					num = (short)1309278261;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_104F:
					num = (short)1756233811;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_11BB:
					flag = flag6;
					num = (short)1779236885;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_1280:
					num = (short)420806746;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_14E2:
					num = (short)1070465136;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_16BA:
					num = (short)1130430574;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_187F:
					num = (short)1201078333;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_190D:
					num = (short)1943076914;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_19BB:
					flag = flag5;
					num = (short)673775702;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_1B07:
					num = (short)860815374;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_1BAA:
					flag = flag7;
					num = (short)1023279189;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_1BC9:
					flag = flag3;
					num = (short)1507655745;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_1C4C:
					num = (short)1431371851;
					num2 = (int)((global::System.IntPtr)num);
				}
				return flag;
				IL_20B:
				trunkingSwitches = (self as global::Motorola.MackinawCPS.CoreFeatures.Switches.TrunkingSwitches);
				global::Motorola.MackinawCPS.CoreFeatures.Switches.Switches switches = self.Parent as global::Motorola.MackinawCPS.CoreFeatures.Switches.Switches;
				switchConventionalSwitchesPosition1_A = switches.ConventionalSwitches.SwitchConventionalSwitchesPosition1_A7734;
				switchConventionalSwitchesPosition2_A = switches.ConventionalSwitches.SwitchConventionalSwitchesPosition2_A7735;
				switchTrunkingSwitchesPosition1_A = trunkingSwitches.SwitchTrunkingSwitchesPosition1_A9466;
				radWideFeaturesNFPACompliant = trunkingSwitches.RefRadioWide.Features.RadWideFeaturesNFPACompliant;
				portableButtonInnerRecset = ((global::AcpCommonLib.FeatureManager.GetFeature(2042) as global::Motorola.MackinawCPS.CoreFeatures.Buttons.ButtonsRecset)[0][10091].EmbeddedRecset as global::Motorola.MackinawCPS.CoreFeatures.Buttons.PortableButtonInnerRecset);
				rsmbuttonInnerRecset = ((global::AcpCommonLib.FeatureManager.GetFeature(2036) as global::Motorola.MackinawCPS.CoreFeatures.RemoteSpeakerMic.RemoteSpeakerMicRecset)[0][10079].EmbeddedRecset as global::Motorola.MackinawCPS.CoreFeatures.RemoteSpeakerMic.RSMButtonInnerRecset);
				smartKeyFobButtonTableInnerRecset = ((global::AcpCommonLib.FeatureManager.GetFeature(4130) as global::Motorola.MackinawCPS.CoreFeatures.SmartKeyFob.SmartKeyFobRecset)[0][10747].EmbeddedRecset as global::Motorola.MackinawCPS.CoreFeatures.SmartKeyFob.SmartKeyFobButtonTableInnerRecset);
				flag = true;
				num = (short)648675366;
				num2 = (int)((global::System.IntPtr)num);
				goto IL_28;
			}
			}
		}

		// Token: 0x060073AE RID: 29614 RVA: 0x0067DD94 File Offset: 0x0067BF94
		internal static bool ConSwitchesTrkPos1(global::AcpCommonLib.IAcpFeatureSection self, int index)
		{
			short num = (short)1198129152;
			int num2 = (int)num;
			switch (num2)
			{
			default:
			{
				switch (0)
				{
				case 0:
					goto IL_263;
				}
				bool flag;
				global::AcpBusinessLayer.AcpListField switchConventionalSwitchesPosition2_A;
				global::AcpBusinessLayer.AcpListField switchConventionalSwitchesPosition1_A;
				global::AcpBusinessLayer.AcpListField switchTrunkingSwitchesPosition2_A;
				global::Motorola.MackinawCPS.CoreFeatures.Buttons.PortableButtonInnerRecset portableButtonInnerRecset;
				global::Motorola.MackinawCPS.CoreFeatures.Switches.TrunkingSwitches trunkingSwitches;
				global::AcpBusinessLayer.AcpField<bool> radWideFeaturesNFPACompliant;
				global::Motorola.MackinawCPS.CoreFeatures.RemoteSpeakerMic.RSMButtonInnerRecset rsmbuttonInnerRecset;
				global::Motorola.MackinawCPS.CoreFeatures.SmartKeyFob.SmartKeyFobButtonTableInnerRecset smartKeyFobButtonTableInnerRecset;
				for (;;)
				{
					IL_28:
					int num3;
					bool flag2;
					int num4;
					bool flag3;
					int num6;
					bool flag4;
					bool flag5;
					bool flag6;
					bool flag7;
					int num7;
					int num8;
					switch (num2)
					{
					case 0:
						num = (short)88080474;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 1:
						num = (short)1917714497;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 2:
						if (flag)
						{
							num = (short)858456177;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_1898;
					case 3:
					{
						global::Motorola.MackinawCPS.CoreFeatures.MenuItems.MenuItems menuItems;
						if (num3 >= menuItems.General.DispMenuConventionalSelectedMenuItems_A21736.Items.Count)
						{
							num = (short)889192569;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)714080274;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 4:
						num = (short)536870999;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 5:
						if (index <= 194)
						{
							num = (short)412155981;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)1778253955;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 6:
						if (switchConventionalSwitchesPosition2_A.Value == 195)
						{
							num = (short)1894252607;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_1159;
					case 7:
						goto IL_9C1;
					case 8:
						if (switchConventionalSwitchesPosition1_A.Value == 274)
						{
							num = (short)786235511;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_11DA;
					case 9:
						flag2 = (switchTrunkingSwitchesPosition2_A.Value == 195);
						goto IL_1F97;
					case 10:
						num = (short)1387200614;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 11:
					{
						global::Motorola.MackinawCPS.CoreFeatures.MenuItems.MenuItems menuItems2;
						if (menuItems2.General.DispMenuTrunkingSelectedMenuItems_A21735.Items[num4].ItemName == global::CommonResources.AcgResources.ID_SCNL)
						{
							num = (short)819855376;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_9C1;
					}
					case 12:
						if (flag)
						{
							num = (short)770441323;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_939;
					case 13:
						if (switchConventionalSwitchesPosition2_A.Value == 30)
						{
							num = (short)1011155016;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_16E2;
					case 14:
						try
						{
							num = (short)1770127360;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								switch (num2)
								{
								case 0:
									switch (0)
									{
									case 0:
										goto IL_E69;
									}
									continue;
								case 1:
									goto IL_F57;
								case 2:
								{
									global::System.Collections.Generic.IEnumerator<global::AcpBusinessLayer.FeatureNode> enumerator;
									global::AcpBusinessLayer.FeatureNode featureNode = enumerator.Current;
									if ((((global::AcpCommonLib.IAcpFeatureNode)featureNode)[10092] as global::Motorola.MackinawCPS.CoreFeatures.Buttons.PortableButtonInnerSection).BtnGeneralConventionalFeature_A19544.Value == 33)
									{
										flag = false;
									}
									if ((((global::AcpCommonLib.IAcpFeatureNode)featureNode)[10092] as global::Motorola.MackinawCPS.CoreFeatures.Buttons.PortableButtonInnerSection).BtnTrunkingPortableButtonFeature_A19546.Value == 33)
									{
										num = (short)968949766;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									break;
								}
								case 3:
								{
									global::System.Collections.Generic.IEnumerator<global::AcpBusinessLayer.FeatureNode> enumerator;
									if (!enumerator.MoveNext())
									{
										num = (short)2134441989;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									num = (short)412680194;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 5:
									num = (short)42795009;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 6:
									flag = false;
									num = (short)752484356;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								IL_EAD:
								num = (short)116326403;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								IL_E69:
								goto IL_EAD;
							}
							IL_F57:
							goto IL_1A50;
						}
						finally
						{
							for (;;)
							{
								IL_F5C:
								num = (short)1196949504;
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
											goto IL_F8F;
										}
										continue;
									case 1:
									{
										num = (short)287290495;
										short num5 = num;
										num = (short)1312339071;
										switch ((num5 == num) ? 1 : 0)
										{
										case 0:
										case 2:
											goto IL_F5C;
										default:
											num = (short)1942421504;
											if (num != 0)
											{
											}
											enumerator.Dispose();
											num = (short)1613365250;
											num2 = (int)((global::System.IntPtr)num);
											continue;
										}
										break;
									}
									case 2:
										goto IL_1018;
									}
									IL_F8F:
									if (enumerator == null)
									{
										goto IL_101A;
									}
									num = (short)1849556993;
									num2 = (int)((global::System.IntPtr)num);
								}
							}
							IL_1018:
							IL_101A:;
						}
						goto IL_101B;
					case 15:
						flag = false;
						num = (short)149356679;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 16:
						flag = false;
						num = (short)1525415943;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 17:
						flag3 = (switchTrunkingSwitchesPosition2_A.Value == 194);
						goto IL_1C7D;
					case 18:
					{
						global::Motorola.MackinawCPS.CoreFeatures.MenuItems.MenuItems menuItems;
						if (menuItems.General.DispMenuConventionalSelectedMenuItems_A21736.Items[num3].ItemName == global::CommonResources.AcgResources.ID_TXIN)
						{
							num = (short)1535639626;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_CBD;
					}
					case 19:
						goto IL_1494;
					case 20:
					{
						global::Motorola.MackinawCPS.CoreFeatures.MenuItems.MenuItems menuItems3;
						if (menuItems3.General.DispMenuTrunkingSelectedMenuItems_A21735.Items[num6].ItemName == global::CommonResources.AcgResources.ID_SCAN)
						{
							num = (short)1817968704;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_770;
					}
					case 21:
					{
						global::AcpCommonLib.IAcpRecordset feature;
						if (feature != null)
						{
							num = (short)651624509;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return flag;
					}
					case 22:
						num = (short)1096810537;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 23:
						goto IL_8C8;
					case 24:
					{
						global::AcpCommonLib.IAcpRecordset feature;
						if (feature.Count != 0)
						{
							num = (short)792920147;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return flag;
					}
					case 25:
						if (!global::ConstraintHelper.UtilityMack.IsMobile())
						{
							num = (short)171966596;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return flag;
					case 26:
						flag4 = false;
						goto IL_1300;
					case 27:
					{
						global::Motorola.MackinawCPS.CoreFeatures.MenuItems.MenuItems menuItems2;
						if (num4 >= menuItems2.General.DispMenuTrunkingSelectedMenuItems_A21735.Items.Count)
						{
							num = (short)1667498111;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)1492647947;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 28:
					{
						global::AcpCommonLib.IAcpRecordset feature2;
						if (feature2.Count != 0)
						{
							num = (short)987889726;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return flag;
					}
					case 29:
					{
						global::System.Collections.Generic.IEnumerator<global::AcpBusinessLayer.FeatureNode> enumerator = portableButtonInnerRecset.GetEnumerator();
						num = (short)69009533;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 30:
						num = (short)1070399591;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 31:
						if (!global::ConstraintHelper.UtilityMack.IsMobile())
						{
							num = (short)978255924;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return flag;
					case 32:
						num = (short)1292238887;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 33:
						num = (short)1799618577;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 34:
						num = (short)1174732806;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 35:
					{
						if (index != 46)
						{
							num = (short)1616838724;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						global::AcpCommonLib.IAcpRecordset feature2 = global::AcpCommonLib.FeatureManager.GetFeature(2088);
						num = (short)1030750259;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 36:
						if (trunkingSwitches.RefRadioErgonomicsWide.Advanced.RadErgoWideAdvancedSideButtonsLockEnable_A38725.Value)
						{
							num = (short)1278410849;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return flag;
					case 37:
						if (switchTrunkingSwitchesPosition2_A.Value == 275)
						{
							num = (short)1914175489;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_11DA;
					case 38:
						num = (short)48824448;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 39:
						return flag;
					case 40:
						goto IL_1F4F;
					case 41:
						flag5 = (switchTrunkingSwitchesPosition2_A.Value == 29);
						goto IL_12E1;
					case 42:
						flag6 = false;
						goto IL_7B6;
					case 43:
						goto IL_D03;
					case 44:
						if (index != 61)
						{
							num = (short)1437728768;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)528613412;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 45:
						if (trunkingSwitches.SwitchTrunkingSwitchesPosition4_A21534.Value != 33)
						{
							num = (short)1806237706;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_91B;
					case 46:
						flag7 = false;
						goto IL_1475;
					case 47:
						goto IL_8C8;
					case 48:
						num = (short)1408368668;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 49:
						if (switchConventionalSwitchesPosition1_A.Value == 81)
						{
							num = (short)1260912644;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_163F;
					case 50:
						num = (short)230097014;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 51:
					{
						global::AcpCommonLib.IAcpRecordset feature2;
						if (feature2 != null)
						{
							num = (short)189333552;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return flag;
					}
					case 52:
					{
						global::AcpCommonLib.IAcpRecordset feature2;
						global::Motorola.MackinawCPS.CoreFeatures.MenuItems.MenuItems menuItems2 = feature2[0] as global::Motorola.MackinawCPS.CoreFeatures.MenuItems.MenuItems;
						num4 = 0;
						num = (short)1176633391;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 53:
						flag = false;
						num = (short)2054619224;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 54:
						if (switchConventionalSwitchesPosition1_A.Value == 29)
						{
							num = (short)417857675;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_161F;
					case 55:
						goto IL_1494;
					case 56:
						return flag;
					case 57:
						num = (short)798228515;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 58:
						goto IL_770;
					case 59:
					{
						global::Motorola.MackinawCPS.CoreFeatures.MenuItems.MenuItems menuItems;
						if (menuItems.General.DispMenuTrunkingSelectedMenuItems_A21735.Items[num7].ItemName == global::CommonResources.AcgResources.ID_TXIN)
						{
							num = (short)655413;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_977;
					}
					case 60:
						goto IL_D03;
					case 61:
						goto IL_C10;
					case 62:
						num = (short)1089798175;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 63:
						num = (short)1079640073;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 64:
						flag = false;
						num = (short)997392442;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 65:
						flag6 = radWideFeaturesNFPACompliant;
						goto IL_7B6;
					case 66:
						if (flag)
						{
							num = (short)1422000243;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return flag;
					case 67:
						goto IL_15CC;
					case 68:
						num = (short)807993388;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 69:
						goto IL_5E1;
					case 70:
					{
						global::System.Collections.Generic.IEnumerator<global::AcpBusinessLayer.FeatureNode> enumerator = portableButtonInnerRecset.GetEnumerator();
						num = (short)1965817870;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 71:
						if (switchConventionalSwitchesPosition2_A.Value == 29)
						{
							num = (short)247332886;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_161F;
					case 72:
						goto IL_101B;
					case 73:
						return flag;
					case 74:
						flag = false;
						num = (short)172687464;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 75:
						num = (short)178716673;
						if (num != 0)
						{
						}
						if (flag)
						{
							num = (short)1873870918;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_1A50;
					case 76:
						if (trunkingSwitches.SwitchTrunkingSwitchesPosition3_A9468.Value != 33)
						{
							num = (short)2013397032;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_91B;
					case 77:
						num = (short)553779296;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 78:
						flag2 = false;
						goto IL_1F97;
					case 79:
						num = (short)753795195;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 80:
					{
						global::System.Collections.Generic.IEnumerator<global::AcpBusinessLayer.FeatureNode> enumerator = rsmbuttonInnerRecset.GetEnumerator();
						num = (short)717750382;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 81:
						try
						{
							num = (short)1821704192;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								switch (num2)
								{
								case 0:
									switch (0)
									{
									case 0:
										goto IL_A76;
									}
									continue;
								case 1:
								{
									global::System.Collections.Generic.IEnumerator<global::AcpBusinessLayer.FeatureNode> enumerator;
									if (!enumerator.MoveNext())
									{
										num = (short)1541144580;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									global::AcpCommonLib.IAcpFeatureNode acpFeatureNode = enumerator.Current;
									num = (short)1135411202;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 2:
								{
									global::AcpCommonLib.IAcpFeatureNode acpFeatureNode;
									if ((acpFeatureNode[10080] as global::Motorola.MackinawCPS.CoreFeatures.RemoteSpeakerMic.RSMButtonInnerSection).RadErgoCfgRSMTrunkingBCO_A19741.Value != 151)
									{
										num = (short)278265864;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									break;
								}
								case 3:
									goto IL_B9D;
								case 4:
									num = (short)440401923;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 5:
								{
									global::AcpCommonLib.IAcpFeatureNode acpFeatureNode;
									if ((acpFeatureNode[10080] as global::Motorola.MackinawCPS.CoreFeatures.RemoteSpeakerMic.RSMButtonInnerSection).RadErgoCfgRSMlTrunkingFeature_A19742.Value == 31)
									{
										num = (short)1496449031;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									break;
								}
								case 6:
									goto IL_B80;
								case 7:
									flag = false;
									num = (short)1483407366;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 8:
									num = (short)1839333381;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								IL_A78:
								num = (short)1247346689;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								IL_A76:
								goto IL_A78;
							}
							IL_B80:
							IL_B9D:
							goto IL_81F;
						}
						finally
						{
							num = (short)927989760;
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
										goto IL_BD6;
									}
									continue;
								case 1:
									enumerator.Dispose();
									num = (short)884277250;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 2:
									goto IL_C0D;
								}
								IL_BD6:
								if (enumerator == null)
								{
									break;
								}
								num = (short)1106182145;
								num2 = (int)((global::System.IntPtr)num);
							}
							IL_C0D:;
						}
						goto IL_C10;
						IL_81F:
						num = (short)820379760;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 82:
						return flag;
					case 83:
						num = (short)2122579993;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 84:
						if (index <= 61)
						{
							num = (short)869072994;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)198115333;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 85:
						if (flag)
						{
							num = (short)1265893456;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return flag;
					case 86:
						return flag;
					case 87:
						if (switchConventionalSwitchesPosition2_A.Value == 194)
						{
							num = (short)301072417;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_163F;
					case 88:
						goto IL_977;
					case 89:
						flag3 = false;
						goto IL_1C7D;
					case 90:
						return flag;
					case 91:
						return flag;
					case 92:
						if (switchConventionalSwitchesPosition1_A.Value == 30)
						{
							num = (short)376373357;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_16E2;
					case 93:
					{
						global::Motorola.MackinawCPS.CoreFeatures.MenuItems.MenuItems menuItems3;
						if (num8 >= menuItems3.General.DispMenuConventionalSelectedMenuItems_A21736.Items.Count)
						{
							num = (short)1919746117;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)374734981;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 94:
						goto IL_15CC;
					case 95:
						flag7 = (switchTrunkingSwitchesPosition2_A.Value == 30);
						goto IL_1475;
					case 96:
						if (index != 81)
						{
							num = (short)1175126150;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)997982257;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 97:
					{
						global::System.Collections.Generic.IEnumerator<global::AcpBusinessLayer.FeatureNode> enumerator = rsmbuttonInnerRecset.GetEnumerator();
						num = (short)1612972113;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 98:
						num = (short)564265096;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 99:
						flag5 = false;
						goto IL_12E1;
					case 100:
						return flag;
					case 101:
						num = (short)2058420300;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 102:
						flag4 = (trunkingSwitches.SwitchTrunkingSwitchesPosition5_A21535.Value != 33);
						goto IL_1300;
					case 103:
						return flag;
					case 104:
						goto IL_CBD;
					case 105:
						return flag;
					case 106:
						goto IL_1700;
					case 107:
					{
						global::System.Collections.Generic.IEnumerator<global::AcpBusinessLayer.FeatureNode> enumerator = smartKeyFobButtonTableInnerRecset.GetEnumerator();
						num = (short)2142240882;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 108:
					{
						global::AcpCommonLib.IAcpRecordset feature3;
						if (feature3 != null)
						{
							num = (short)1745092687;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_1898;
					}
					case 109:
						num = (short)240713741;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 110:
						try
						{
							num = (short)1429405696;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								switch (num2)
								{
								case 0:
									switch (0)
									{
									case 0:
										goto IL_1DE6;
									}
									continue;
								case 1:
									goto IL_1ED9;
								case 2:
								{
									global::System.Collections.Generic.IEnumerator<global::AcpBusinessLayer.FeatureNode> enumerator;
									global::AcpBusinessLayer.FeatureNode featureNode2 = enumerator.Current;
									if ((((global::AcpCommonLib.IAcpFeatureNode)featureNode2)[10080] as global::Motorola.MackinawCPS.CoreFeatures.RemoteSpeakerMic.RSMButtonInnerSection).RadErgoCfgRSMlConventionalFeature_A19640.Value == 33)
									{
										flag = false;
									}
									if ((((global::AcpCommonLib.IAcpFeatureNode)featureNode2)[10080] as global::Motorola.MackinawCPS.CoreFeatures.RemoteSpeakerMic.RSMButtonInnerSection).RadErgoCfgRSMlTrunkingFeature_A19742.Value == 33)
									{
										num = (short)980942851;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									break;
								}
								case 3:
									flag = false;
									num = (short)1357250565;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 4:
									num = (short)1264582657;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 6:
								{
									global::System.Collections.Generic.IEnumerator<global::AcpBusinessLayer.FeatureNode> enumerator;
									if (!enumerator.MoveNext())
									{
										num = (short)586612740;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									num = (short)563347458;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								}
								IL_1E80:
								num = (short)922681350;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								IL_1DE6:
								goto IL_1E80;
							}
							IL_1ED9:
							return flag;
						}
						finally
						{
							num = (short)1267924992;
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
										goto IL_1F12;
									}
									continue;
								case 1:
									enumerator.Dispose();
									num = (short)1947664386;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 2:
									goto IL_1F4C;
								}
								IL_1F12:
								if (enumerator == null)
								{
									break;
								}
								num = (short)617742337;
								num2 = (int)((global::System.IntPtr)num);
							}
							IL_1F4C:;
						}
						goto IL_1F4F;
					case 111:
						if (switchTrunkingSwitchesPosition2_A.Value != 33)
						{
							num = (short)110690405;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_91B;
					case 112:
					{
						num = (short)393084928;
						short num9 = num;
						if (flag)
						{
							num = (short)331153437;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return flag;
					}
					case 113:
					{
						global::AcpCommonLib.IAcpRecordset feature3 = global::AcpCommonLib.FeatureManager.GetFeature(2088);
						num = (short)295829612;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 114:
						try
						{
							num = (short)2020081670;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								switch (num2)
								{
								case 0:
									goto IL_443;
								case 1:
									flag = false;
									num = (short)1540358149;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 2:
								{
									global::AcpCommonLib.IAcpFeatureNode acpFeatureNode2;
									if ((acpFeatureNode2[10748] as global::Motorola.MackinawCPS.CoreFeatures.SmartKeyFob.SmartKeyFobButtonTableInnerSection).RadErgoCfgFobTrunkingFeature_A41575.Value == 33)
									{
										num = (short)1301807105;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									break;
								}
								case 3:
									flag = false;
									num = (short)12058624;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 4:
									num = (short)45285383;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 5:
									goto IL_460;
								case 6:
									switch (0)
									{
									case 0:
										goto IL_425;
									}
									continue;
								case 7:
									goto IL_570;
								case 8:
								{
									global::System.Collections.Generic.IEnumerator<global::AcpBusinessLayer.FeatureNode> enumerator;
									if (!enumerator.MoveNext())
									{
										num = (short)50266116;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									global::AcpCommonLib.IAcpFeatureNode acpFeatureNode2 = enumerator.Current;
									num = (short)134021129;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 9:
								{
									global::AcpCommonLib.IAcpFeatureNode acpFeatureNode2;
									if ((acpFeatureNode2[10748] as global::Motorola.MackinawCPS.CoreFeatures.SmartKeyFob.SmartKeyFobButtonTableInnerSection).RadErgoCfgFobConventionalFeature_A41574.Value == 33)
									{
										num = (short)1835466755;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									num = (short)1015545858;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								}
								IL_518:
								num = (short)369819656;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								IL_425:
								goto IL_518;
							}
							IL_443:
							IL_460:
							IL_570:
							goto IL_939;
						}
						finally
						{
							num = (short)1782382592;
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
										goto IL_5A7;
									}
									continue;
								case 1:
									enumerator.Dispose();
									num = (short)150208514;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 2:
									goto IL_5DE;
								}
								IL_5A7:
								if (enumerator == null)
								{
									break;
								}
								num = (short)1958674433;
								num2 = (int)((global::System.IntPtr)num);
							}
							IL_5DE:;
						}
						goto IL_5E1;
					case 115:
					{
						global::AcpCommonLib.IAcpRecordset feature = global::AcpCommonLib.FeatureManager.GetFeature(2088);
						num = (short)1023410197;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 116:
						goto IL_1898;
					case 117:
						if (switchConventionalSwitchesPosition2_A.Value == 275)
						{
							num = (short)1681916044;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_11DA;
					case 118:
						if (index != 274)
						{
							num = (short)271646758;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)1910177800;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 119:
						num = (short)1875837045;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 120:
						if (switchConventionalSwitchesPosition1_A.Value == 27)
						{
							num = (short)1328283682;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_1159;
					case 121:
						num7 = 0;
						num = (short)1989804099;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 122:
						num8 = 0;
						num = (short)1113391123;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 123:
					{
						global::AcpCommonLib.IAcpRecordset feature3;
						if (feature3.Count != 0)
						{
							num = (short)1295188105;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_1898;
					}
					case 124:
					{
						global::Motorola.MackinawCPS.CoreFeatures.MenuItems.MenuItems menuItems3;
						if (num6 >= menuItems3.General.DispMenuTrunkingSelectedMenuItems_A21735.Items.Count)
						{
							num = (short)383910004;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)2128150548;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 125:
						try
						{
							num = (short)833159168;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								switch (num2)
								{
								case 0:
									switch (0)
									{
									case 0:
										goto IL_1AD9;
									}
									continue;
								case 1:
								{
									global::AcpCommonLib.IAcpFeatureNode acpFeatureNode3;
									if ((acpFeatureNode3[10092] as global::Motorola.MackinawCPS.CoreFeatures.Buttons.PortableButtonInnerSection).BtnTrunkingPortableButtonFeature_A19546.Value == 31)
									{
										num = (short)1632501764;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									break;
								}
								case 2:
									goto IL_1BAD;
								case 3:
									goto IL_1C0B;
								case 4:
									flag = false;
									num = (short)998834178;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 5:
								{
									global::AcpCommonLib.IAcpFeatureNode acpFeatureNode3;
									if ((acpFeatureNode3[10092] as global::Motorola.MackinawCPS.CoreFeatures.Buttons.PortableButtonInnerSection).BtnTrunkingPortableTrunkingBCO_A19545.Value != 148)
									{
										num = (short)1581187079;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									break;
								}
								case 6:
									num = (short)187760643;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 7:
									num = (short)855310337;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 8:
								{
									global::System.Collections.Generic.IEnumerator<global::AcpBusinessLayer.FeatureNode> enumerator;
									if (!enumerator.MoveNext())
									{
										num = (short)1524170758;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									global::AcpCommonLib.IAcpFeatureNode acpFeatureNode3 = enumerator.Current;
									num = (short)1200947205;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								}
								IL_1BB2:
								num = (short)1991114760;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								IL_1AD9:
								goto IL_1BB2;
							}
							IL_1BAD:
							IL_1C0B:
							return flag;
						}
						finally
						{
							num = (short)678494208;
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
										goto IL_1C42;
									}
									continue;
								case 1:
									enumerator.Dispose();
									num = (short)839385090;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 2:
									goto IL_1C7A;
								}
								IL_1C42:
								if (enumerator == null)
								{
									break;
								}
								num = (short)1663434753;
								num2 = (int)((global::System.IntPtr)num);
							}
							IL_1C7A:;
						}
						goto IL_1C7D;
					case 126:
						if (index != 194)
						{
							num = (short)912982048;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						flag = false;
						num = (short)231866450;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 127:
						num = (short)33357880;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 128:
						return flag;
					case 129:
						if (!global::ConstraintHelper.UtilityMack.IsMobile())
						{
							num = (short)1099759738;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_1898;
					case 130:
					{
						global::Motorola.MackinawCPS.CoreFeatures.MenuItems.MenuItems menuItems;
						if (num7 >= menuItems.General.DispMenuTrunkingSelectedMenuItems_A21735.Items.Count)
						{
							num = (short)276168734;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)1873346619;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 131:
						if (index != 195)
						{
							num = (short)448004146;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						flag = false;
						num = (short)605487209;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 132:
					{
						global::AcpCommonLib.IAcpRecordset feature;
						global::Motorola.MackinawCPS.CoreFeatures.MenuItems.MenuItems menuItems = feature[0] as global::Motorola.MackinawCPS.CoreFeatures.MenuItems.MenuItems;
						num3 = 0;
						num = (short)1144389770;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 133:
					{
						global::Motorola.MackinawCPS.CoreFeatures.MenuItems.MenuItems menuItems3;
						if (menuItems3.General.DispMenuConventionalSelectedMenuItems_A21736.Items[num8].ItemName == global::CommonResources.AcgResources.ID_SCAN)
						{
							num = (short)1272184847;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_1402;
					}
					case 134:
						num = (short)1209663614;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 135:
						goto IL_1402;
					case 136:
						switch (index)
						{
						case 27:
							num = (short)214630520;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 28:
						case 31:
						case 32:
							return flag;
						case 29:
							num = (short)1910505526;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 30:
							num = (short)1905655900;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 33:
							num = (short)777322607;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						default:
							num = (short)1761214521;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						break;
					case 137:
					{
						global::AcpCommonLib.IAcpRecordset feature3;
						global::Motorola.MackinawCPS.CoreFeatures.MenuItems.MenuItems menuItems3 = feature3[0] as global::Motorola.MackinawCPS.CoreFeatures.MenuItems.MenuItems;
						num = (short)73269377;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 138:
						goto IL_1700;
					case 139:
						num = (short)567410759;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 140:
						num = (short)880476197;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_263;
					IL_5E1:
					num6 = 0;
					num = (short)1835008060;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_770:
					num6++;
					num = (short)1265369131;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_7B6:
					flag = flag6;
					num = (short)845348964;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_8C8:
					num = (short)90832923;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_91B:
					num = (short)1099169818;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_939:
					num = (short)634388565;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_977:
					num7++;
					num = (short)586874974;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_9C1:
					num4++;
					num = (short)403177495;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_C10:
					num = (short)2096103448;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_CBD:
					num3++;
					num = (short)1916731498;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_D03:
					num = (short)1596457084;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_101B:
					num = (short)1895235679;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_1159:
					num = (short)792330318;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_11DA:
					num = (short)1100218410;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_12E1:
					flag = flag5;
					num = (short)261488713;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_1300:
					flag = flag4;
					num = (short)83886082;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_1402:
					num8++;
					num = (short)798883895;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_1475:
					flag = flag7;
					num = (short)790364251;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_1494:
					num = (short)1912471645;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_15CC:
					num = (short)967377026;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_161F:
					num = (short)366477411;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_163F:
					num = (short)401473625;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_16E2:
					num = (short)1413087278;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_1700:
					num = (short)1889337347;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_1898:
					num = (short)4390987;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_1A50:
					num = (short)1459421196;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_1C7D:
					flag = flag3;
					num = (short)11599958;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_1F4F:
					num = (short)1560084525;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_1F97:
					flag = flag2;
					num = (short)1470890050;
					num2 = (int)((global::System.IntPtr)num);
				}
				return flag;
				IL_263:
				trunkingSwitches = (self as global::Motorola.MackinawCPS.CoreFeatures.Switches.TrunkingSwitches);
				global::Motorola.MackinawCPS.CoreFeatures.Switches.Switches switches = self.Parent as global::Motorola.MackinawCPS.CoreFeatures.Switches.Switches;
				switchConventionalSwitchesPosition1_A = switches.ConventionalSwitches.SwitchConventionalSwitchesPosition1_A7734;
				switchConventionalSwitchesPosition2_A = switches.ConventionalSwitches.SwitchConventionalSwitchesPosition2_A7735;
				switchTrunkingSwitchesPosition2_A = trunkingSwitches.SwitchTrunkingSwitchesPosition2_A9467;
				radWideFeaturesNFPACompliant = trunkingSwitches.RefRadioWide.Features.RadWideFeaturesNFPACompliant;
				portableButtonInnerRecset = ((global::AcpCommonLib.FeatureManager.GetFeature(2042) as global::Motorola.MackinawCPS.CoreFeatures.Buttons.ButtonsRecset)[0][10091].EmbeddedRecset as global::Motorola.MackinawCPS.CoreFeatures.Buttons.PortableButtonInnerRecset);
				rsmbuttonInnerRecset = ((global::AcpCommonLib.FeatureManager.GetFeature(2036) as global::Motorola.MackinawCPS.CoreFeatures.RemoteSpeakerMic.RemoteSpeakerMicRecset)[0][10079].EmbeddedRecset as global::Motorola.MackinawCPS.CoreFeatures.RemoteSpeakerMic.RSMButtonInnerRecset);
				smartKeyFobButtonTableInnerRecset = ((global::AcpCommonLib.FeatureManager.GetFeature(4130) as global::Motorola.MackinawCPS.CoreFeatures.SmartKeyFob.SmartKeyFobRecset)[0][10747].EmbeddedRecset as global::Motorola.MackinawCPS.CoreFeatures.SmartKeyFob.SmartKeyFobButtonTableInnerRecset);
				flag = true;
				num = (short)958070868;
				num2 = (int)((global::System.IntPtr)num);
				goto IL_28;
			}
			}
		}

		// Token: 0x060073AF RID: 29615 RVA: 0x0067FEC8 File Offset: 0x0067E0C8
		internal static void ConSyncPosAToSwitchTblAndDriveCnvPosBAndTrkPosAPosB(global::AcpCommonLib.IAcpFeatureSection self, global::AcpCommonLib.UndoRedo.ContainerTask task)
		{
			int a_ = 18;
			short num = (short)130678784;
			int num2 = (int)num;
			switch (num2)
			{
			default:
			{
				switch (0)
				{
				case 0:
					goto IL_124;
				}
				global::AcpBusinessLayer.AcpListField switchTrunkingSwitchesPosition1_A;
				int num4;
				global::AcpBusinessLayer.AcpField<bool> radWideLabtoolChannelSelectorOnSwitch_A;
				global::AcpBusinessLayer.AcpListField switchConventionalSwitchesPosition1_A;
				global::AcpBusinessLayer.AcpListField switchConventionalSwitchesPosition2_A;
				global::System.Collections.Generic.IEnumerator<global::AcpBusinessLayer.FeatureNode> enumerator;
				global::Motorola.MackinawCPS.CoreFeatures.Switches.TrunkingSwitchTableInnerRecset trunkingSwitchTableInnerRecset;
				global::AcpBusinessLayer.AcpListField switchTrunkingSwitchesPosition2_A;
				global::AcpBusinessLayer.AcpField<bool> radWideLabtoolZoneSelectorOnSwitch_A;
				global::AcpBusinessLayer.AcpListField switchConventionalSwitchesPosition3_A;
				global::Motorola.MackinawCPS.CoreFeatures.Switches.ConventionalSwitchTableInnerRecset conventionalSwitchTableInnerRecset;
				for (;;)
				{
					IL_31:
					switch (num2)
					{
					case 0:
						num = (short)2082144280;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 1:
					{
						num = (short)1239089152;
						short num3 = num;
						goto IL_409;
					}
					case 2:
						goto IL_FDA;
					case 3:
						if (switchTrunkingSwitchesPosition1_A.Value == 274)
						{
							num = (short)459210762;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_409;
					case 4:
						num = (short)530448416;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 5:
						if (num4 == 29)
						{
							num = (short)1117257762;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						task.AddTask(new global::AcpBusinessLayer.UndoRedo.ModifyDataTask<bool>(radWideLabtoolChannelSelectorOnSwitch_A, false));
						num = (short)8388630;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 6:
						if (switchConventionalSwitchesPosition1_A.Value != 29)
						{
							num = (short)580386845;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_94C;
					case 7:
						try
						{
							num = (short)131072003;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								switch (num2)
								{
								case 0:
								{
									global::AcpCommonLib.IAcpFeatureNode acpFeatureNode;
									task.AddTask(new global::AcpBusinessLayer.UndoRedo.ModifyDataTask<int>((acpFeatureNode[10086] as global::Motorola.MackinawCPS.CoreFeatures.Switches.ConventionalSwitchTableInnerSection).SwitchConventionalSwitchTablePosition1Feature_A19655, switchConventionalSwitchesPosition1_A.Value));
									task.AddTask(new global::AcpBusinessLayer.UndoRedo.ModifyDataTask<int>((acpFeatureNode[10086] as global::Motorola.MackinawCPS.CoreFeatures.Switches.ConventionalSwitchTableInnerSection).SwitchConventionalSwitchTablePosition2Feature_A19656, switchConventionalSwitchesPosition2_A.Value));
									num = (short)810418181;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 1:
									num = (short)1759903750;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 2:
								{
									global::AcpCommonLib.IAcpFeatureNode acpFeatureNode;
									if ((acpFeatureNode.Parent as global::AcpBusinessLayer.Recordset).IndexOf(acpFeatureNode) == 0)
									{
										num = (short)1914044416;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									break;
								}
								case 3:
									switch (0)
									{
									case 0:
										goto IL_7C3;
									}
									continue;
								case 4:
								{
									if (!enumerator.MoveNext())
									{
										num = (short)1474756609;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									global::AcpCommonLib.IAcpFeatureNode acpFeatureNode = enumerator.Current;
									num = (short)774438914;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 5:
									goto IL_866;
								case 6:
									goto IL_8D9;
								}
								IL_7C5:
								num = (short)203489284;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								IL_7C3:
								goto IL_7C5;
							}
							IL_866:
							IL_8D9:
							goto IL_D57;
						}
						finally
						{
							num = (short)817496064;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								switch (num2)
								{
								case 0:
									switch (0)
									{
									case 0:
										goto IL_910;
									}
									continue;
								case 1:
									enumerator.Dispose();
									num = (short)753991682;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 2:
									goto IL_949;
								}
								IL_910:
								if (enumerator == null)
								{
									break;
								}
								num = (short)1621295105;
								num2 = (int)((global::System.IntPtr)num);
							}
							IL_949:;
						}
						goto IL_94C;
						IL_D57:
						enumerator = trunkingSwitchTableInnerRecset.GetEnumerator();
						num = (short)1019871244;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 8:
						task.AddTask(new global::AcpBusinessLayer.UndoRedo.ModifyDataTask<int>(switchConventionalSwitchesPosition2_A, 30));
						task.AddTask(new global::AcpBusinessLayer.UndoRedo.ModifyDataTask<int>(switchTrunkingSwitchesPosition1_A, switchConventionalSwitchesPosition1_A.Value));
						task.AddTask(new global::AcpBusinessLayer.UndoRedo.ModifyDataTask<int>(switchTrunkingSwitchesPosition2_A, 30));
						num = (short)1254948913;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 9:
						num = (short)888471555;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 10:
						goto IL_26E;
					case 11:
						if (switchTrunkingSwitchesPosition1_A.Value != 81)
						{
							num = (short)1041367066;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_26E;
					case 12:
						try
						{
							num = (short)142475264;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								switch (num2)
								{
								case 0:
									switch (0)
									{
									case 0:
										goto IL_E57;
									}
									continue;
								case 1:
									goto IL_F64;
								case 2:
								{
									global::AcpCommonLib.IAcpFeatureNode acpFeatureNode2;
									if ((acpFeatureNode2.Parent as global::AcpBusinessLayer.Recordset).IndexOf(acpFeatureNode2) == 0)
									{
										num = (short)550240259;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									break;
								}
								case 3:
								{
									global::AcpCommonLib.IAcpFeatureNode acpFeatureNode2;
									task.AddTask(new global::AcpBusinessLayer.UndoRedo.ModifyDataTask<int>((acpFeatureNode2[10084] as global::Motorola.MackinawCPS.CoreFeatures.Switches.TrunkingSwitchTableInnerSection).SwitchTrunkingSwitchTablePosition1Feature_A21004, switchTrunkingSwitchesPosition1_A.Value));
									task.AddTask(new global::AcpBusinessLayer.UndoRedo.ModifyDataTask<int>((acpFeatureNode2[10084] as global::Motorola.MackinawCPS.CoreFeatures.Switches.TrunkingSwitchTableInnerSection).SwitchTrunkingSwitchTablePosition2Feature_A21005, switchTrunkingSwitchesPosition2_A.Value));
									num = (short)1221984260;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 4:
									goto IL_F46;
								case 5:
									num = (short)689504257;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 6:
								{
									if (!enumerator.MoveNext())
									{
										num = (short)1233387525;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									global::AcpCommonLib.IAcpFeatureNode acpFeatureNode2 = enumerator.Current;
									num = (short)733609986;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								}
								IL_E59:
								num = (short)1310457862;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								IL_E57:
								goto IL_E59;
							}
							IL_F46:
							IL_F64:
							return;
						}
						finally
						{
							num = (short)1313341442;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								switch (num2)
								{
								case 0:
									enumerator.Dispose();
									num = (short)187170817;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 1:
									goto IL_FD7;
								case 2:
									switch (0)
									{
									case 0:
										goto IL_F9D;
									}
									continue;
								}
								IL_F9D:
								if (enumerator == null)
								{
									break;
								}
								num = (short)1616707584;
								num2 = (int)((global::System.IntPtr)num);
							}
							IL_FD7:;
						}
						goto IL_FDA;
					case 13:
						task.AddTask(new global::AcpBusinessLayer.UndoRedo.ModifyDataTask<int>(switchConventionalSwitchesPosition2_A, 29));
						task.AddTask(new global::AcpBusinessLayer.UndoRedo.ModifyDataTask<int>(switchTrunkingSwitchesPosition1_A, switchConventionalSwitchesPosition1_A.Value));
						task.AddTask(new global::AcpBusinessLayer.UndoRedo.ModifyDataTask<int>(switchTrunkingSwitchesPosition2_A, 29));
						num = (short)112590891;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 14:
						if (switchConventionalSwitchesPosition1_A.Value != 274)
						{
							goto IL_D3A;
						}
						goto IL_409;
					case 15:
					{
						num = (short)419640262;
						short num5 = num;
						num = (short)593376198;
						switch ((num5 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_D3A;
						default:
							num = (short)1846542336;
							if (num != 0)
							{
							}
							if (switchConventionalSwitchesPosition1_A.Value == 29)
							{
								num = (short)902692877;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							goto IL_ABB;
						}
						break;
					}
					case 16:
						num = (short)690290733;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 17:
						try
						{
							num = (short)674234371;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								switch (num2)
								{
								case 0:
									goto IL_607;
								case 1:
								{
									global::AcpCommonLib.IAcpFeatureNode acpFeatureNode3;
									num4 = (acpFeatureNode3[10082] as global::Motorola.MackinawCPS.CoreFeatures.Switches.RotaryControlInnerSection).SwitchGeneralRotaryControl_A8984.Value;
									num = (short)2059075584;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 2:
									num = (short)1655111686;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 3:
									switch (0)
									{
									case 0:
										goto IL_547;
									}
									continue;
								case 4:
								{
									global::AcpCommonLib.IAcpFeatureNode acpFeatureNode3;
									if ((acpFeatureNode3.Parent as global::AcpBusinessLayer.Recordset).IndexOf(acpFeatureNode3) == 0)
									{
										num = (short)1558904833;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									break;
								}
								case 5:
								{
									if (!enumerator.MoveNext())
									{
										num = (short)521797634;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									global::AcpCommonLib.IAcpFeatureNode acpFeatureNode3 = enumerator.Current;
									num = (short)1051066372;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 6:
									goto IL_625;
								}
								IL_594:
								num = (short)1621688325;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								IL_547:
								goto IL_594;
							}
							IL_607:
							IL_625:
							goto IL_DD0;
						}
						finally
						{
							num = (short)1742995456;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								switch (num2)
								{
								case 0:
									switch (0)
									{
									case 0:
										goto IL_65C;
									}
									continue;
								case 1:
									enumerator.Dispose();
									num = (short)1603141634;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 2:
									goto IL_694;
								}
								IL_65C:
								if (enumerator == null)
								{
									break;
								}
								num = (short)706281473;
								num2 = (int)((global::System.IntPtr)num);
							}
							IL_694:;
						}
						goto IL_697;
						IL_DD0:
						num = (short)24510499;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 18:
						if (switchConventionalSwitchesPosition1_A.Value != 81)
						{
							num = (short)944439340;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_B8F;
					case 19:
						goto IL_398;
					case 20:
						num = (short)45875201;
						if (num != 0)
						{
						}
						if (num4 == 30)
						{
							num = (short)552665119;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						task.AddTask(new global::AcpBusinessLayer.UndoRedo.ModifyDataTask<bool>(radWideLabtoolZoneSelectorOnSwitch_A, false));
						num = (short)1167917098;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 21:
						if (switchConventionalSwitchesPosition1_A.Value != 30)
						{
							num = (short)1674641465;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_4BF;
					case 22:
						goto IL_498;
					case 23:
						if (switchConventionalSwitchesPosition1_A.Value != 29)
						{
							num = (short)25100292;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_FDA;
					case 24:
						if (global::ConstraintHelper.UtilityMack.ProductModelId != global::AllFeatures.CodeplugGuid.b("鋒藔迖", a_))
						{
							num = (short)1354235943;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_498;
					case 25:
						if (switchConventionalSwitchesPosition1_A.Value == 274)
						{
							num = (short)355336248;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_2DF;
					case 26:
						goto IL_B8F;
					case 27:
						if (switchConventionalSwitchesPosition1_A.Value != 27)
						{
							num = (short)3211292;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_D12;
					case 28:
						num = (short)520355873;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 29:
						num = (short)1855848501;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 30:
						if (switchTrunkingSwitchesPosition1_A.Value != 30)
						{
							num = (short)896073779;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_26E;
					case 31:
						goto IL_101D;
					case 32:
						if (switchTrunkingSwitchesPosition1_A.Value != 29)
						{
							num = (short)681574402;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_26E;
					case 33:
						if (switchTrunkingSwitchesPosition1_A.Value != 27)
						{
							num = (short)76218420;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_26E;
					case 34:
						goto IL_94C;
					case 35:
						if (switchConventionalSwitchesPosition1_A.Value == 81)
						{
							num = (short)1616314426;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_398;
					case 36:
						task.AddTask(new global::AcpBusinessLayer.UndoRedo.ModifyDataTask<int>(switchConventionalSwitchesPosition2_A, 195));
						task.AddTask(new global::AcpBusinessLayer.UndoRedo.ModifyDataTask<int>(switchTrunkingSwitchesPosition1_A, switchConventionalSwitchesPosition1_A.Value));
						task.AddTask(new global::AcpBusinessLayer.UndoRedo.ModifyDataTask<int>(switchTrunkingSwitchesPosition2_A, 195));
						num = (short)1421738025;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 37:
						num = (short)2114060293;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 38:
						goto IL_22B;
					case 39:
						task.AddTask(new global::AcpBusinessLayer.UndoRedo.ModifyDataTask<bool>(radWideLabtoolChannelSelectorOnSwitch_A, true));
						num = (short)267583543;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 40:
						if (switchConventionalSwitchesPosition1_A.Value != 30)
						{
							num = (short)1335361552;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_101D;
					case 41:
						goto IL_B4F;
					case 42:
						goto IL_22B;
					case 43:
						goto IL_ABB;
					case 44:
						num = (short)812777483;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 45:
						if (switchConventionalSwitchesPosition3_A.Value != 30)
						{
							num = (short)251592750;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_101D;
					case 46:
						num = (short)1071251476;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 47:
						if (!global::ConstraintHelper.UtilityMack.IsWorldWidePro)
						{
							num = (short)332529664;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_498;
					case 48:
						goto IL_2DF;
					case 49:
						goto IL_6E9;
					case 50:
						if (switchConventionalSwitchesPosition1_A.Value == 30)
						{
							num = (short)106758152;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_6E9;
					case 51:
						goto IL_4BF;
					case 52:
						goto IL_D12;
					case 53:
						if (switchConventionalSwitchesPosition3_A.Value != 29)
						{
							num = (short)1364590629;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_94C;
					case 54:
						if (switchConventionalSwitchesPosition1_A.Value == 27)
						{
							num = (short)1717501988;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_B4F;
					case 55:
						goto IL_498;
					case 56:
						goto IL_697;
					case 57:
						num = (short)1872822302;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 58:
						task.AddTask(new global::AcpBusinessLayer.UndoRedo.ModifyDataTask<int>(switchConventionalSwitchesPosition2_A, 194));
						task.AddTask(new global::AcpBusinessLayer.UndoRedo.ModifyDataTask<int>(switchTrunkingSwitchesPosition1_A, switchConventionalSwitchesPosition1_A.Value));
						task.AddTask(new global::AcpBusinessLayer.UndoRedo.ModifyDataTask<int>(switchTrunkingSwitchesPosition2_A, 194));
						num = (short)371195923;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_124;
					IL_22B:
					num = (short)792199174;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_26E:
					task.AddTask(new global::AcpBusinessLayer.UndoRedo.ModifyDataTask<int>(switchConventionalSwitchesPosition2_A, 38));
					task.AddTask(new global::AcpBusinessLayer.UndoRedo.ModifyDataTask<int>(switchTrunkingSwitchesPosition1_A, 38));
					task.AddTask(new global::AcpBusinessLayer.UndoRedo.ModifyDataTask<int>(switchTrunkingSwitchesPosition2_A, 38));
					num = (short)1940258817;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_2DF:
					num = (short)1802305551;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_398:
					num = (short)1208811570;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_409:
					num = (short)4522024;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_498:
					enumerator = conventionalSwitchTableInnerRecset.GetEnumerator();
					num = (short)1314979847;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_4BF:
					num = (short)1031798807;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_697:
					task.AddTask(new global::AcpBusinessLayer.UndoRedo.ModifyDataTask<int>(switchConventionalSwitchesPosition2_A, 275));
					task.AddTask(new global::AcpBusinessLayer.UndoRedo.ModifyDataTask<int>(switchTrunkingSwitchesPosition1_A, switchConventionalSwitchesPosition1_A.Value));
					task.AddTask(new global::AcpBusinessLayer.UndoRedo.ModifyDataTask<int>(switchTrunkingSwitchesPosition2_A, 275));
					num = (short)2035089456;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_6E9:
					num = (short)469434393;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_94C:
					num = (short)789905455;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_ABB:
					num = (short)450953270;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_B4F:
					num = (short)2010513426;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_B8F:
					num = (short)32899093;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_D12:
					num = (short)1720254478;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_D3A:
					num = (short)1927675913;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_FDA:
					num = (short)281477147;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_101D:
					task.AddTask(new global::AcpBusinessLayer.UndoRedo.ModifyDataTask<bool>(radWideLabtoolZoneSelectorOnSwitch_A, true));
					num = (short)726335526;
					num2 = (int)((global::System.IntPtr)num);
				}
				return;
				IL_124:
				global::Motorola.MackinawCPS.CoreFeatures.Switches.ConventionalSwitches conventionalSwitches = self as global::Motorola.MackinawCPS.CoreFeatures.Switches.ConventionalSwitches;
				global::Motorola.MackinawCPS.CoreFeatures.Switches.Switches switches = self.Parent as global::Motorola.MackinawCPS.CoreFeatures.Switches.Switches;
				switchTrunkingSwitchesPosition1_A = switches.TrunkingSwitches.SwitchTrunkingSwitchesPosition1_A9466;
				switchTrunkingSwitchesPosition2_A = switches.TrunkingSwitches.SwitchTrunkingSwitchesPosition2_A9467;
				switchConventionalSwitchesPosition1_A = conventionalSwitches.SwitchConventionalSwitchesPosition1_A7734;
				switchConventionalSwitchesPosition2_A = conventionalSwitches.SwitchConventionalSwitchesPosition2_A7735;
				switchConventionalSwitchesPosition3_A = conventionalSwitches.SwitchConventionalSwitchesPosition3_A7737;
				radWideLabtoolZoneSelectorOnSwitch_A = conventionalSwitches.RefRadioWide.Labtool.RadWideLabtoolZoneSelectorOnSwitch_A19550;
				radWideLabtoolChannelSelectorOnSwitch_A = conventionalSwitches.RefRadioWide.Labtool.RadWideLabtoolChannelSelectorOnSwitch_A19551;
				global::System.Collections.ObjectModel.Collection<global::AcpBusinessLayer.FeatureNode> collection = (global::AcpCommonLib.FeatureManager.GetFeature(2038) as global::Motorola.MackinawCPS.CoreFeatures.Switches.SwitchesRecset)[0][10081].EmbeddedRecset as global::Motorola.MackinawCPS.CoreFeatures.Switches.RotaryControlInnerRecset;
				conventionalSwitchTableInnerRecset = ((global::AcpCommonLib.FeatureManager.GetFeature(2038) as global::Motorola.MackinawCPS.CoreFeatures.Switches.SwitchesRecset)[0][10085].EmbeddedRecset as global::Motorola.MackinawCPS.CoreFeatures.Switches.ConventionalSwitchTableInnerRecset);
				trunkingSwitchTableInnerRecset = ((global::AcpCommonLib.FeatureManager.GetFeature(2038) as global::Motorola.MackinawCPS.CoreFeatures.Switches.SwitchesRecset)[0][10083].EmbeddedRecset as global::Motorola.MackinawCPS.CoreFeatures.Switches.TrunkingSwitchTableInnerRecset);
				num4 = 0;
				enumerator = collection.GetEnumerator();
				num = (short)750190609;
				num2 = (int)((global::System.IntPtr)num);
				goto IL_31;
			}
			}
		}

		// Token: 0x060073B0 RID: 29616 RVA: 0x00680FE8 File Offset: 0x0067F1E8
		internal static void ConSyncPosAToSwitchTblAndCnvPosBCAndTrkPosABC(global::AcpCommonLib.IAcpFeatureSection self, global::AcpCommonLib.UndoRedo.ContainerTask task)
		{
			int a_ = 6;
			short num = (short)695402496;
			int num2 = (int)num;
			switch (num2)
			{
			default:
			{
				switch (0)
				{
				case 0:
					goto IL_D0;
				}
				global::AcpBusinessLayer.AcpListField switchConventionalSwitchesPosition3_A;
				int num3;
				global::AcpBusinessLayer.AcpField<bool> radWideLabtoolZoneSelectorOnSwitch_A;
				global::AcpBusinessLayer.AcpField<bool> radWideLabtoolChannelSelectorOnSwitch_A;
				global::AcpBusinessLayer.AcpListField switchConventionalSwitchesPosition4_A;
				global::AcpBusinessLayer.AcpListField switchConventionalSwitchesPosition5_A;
				global::System.Collections.Generic.IEnumerator<global::AcpBusinessLayer.FeatureNode> enumerator;
				global::Motorola.MackinawCPS.CoreFeatures.Switches.TrunkingSwitchTableInnerRecset trunkingSwitchTableInnerRecset;
				global::AcpBusinessLayer.AcpListField switchTrunkingSwitchesPosition3_A;
				global::AcpBusinessLayer.AcpListField switchTrunkingSwitchesPosition4_A;
				global::AcpBusinessLayer.AcpListField switchTrunkingSwitchesPosition5_A;
				global::AcpBusinessLayer.AcpListField switchConventionalSwitchesPosition1_A;
				global::Motorola.MackinawCPS.CoreFeatures.Switches.ConventionalSwitchTableInnerRecset conventionalSwitchTableInnerRecset;
				for (;;)
				{
					IL_31:
					switch (num2)
					{
					case 0:
						if (switchConventionalSwitchesPosition3_A.Value == 29)
						{
							num = (short)1843331107;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_84D;
					case 1:
						num = (short)458424343;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 2:
						goto IL_B30;
					case 3:
						if (switchConventionalSwitchesPosition3_A.Value != 29)
						{
							num = (short)977010712;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_675;
					case 4:
						goto IL_B6B;
					case 5:
						if (!global::ConstraintHelper.UtilityMack.IsWorldWidePro)
						{
							num = (short)1730019365;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_917;
					case 6:
						goto IL_D89;
					case 7:
						if (num3 == 30)
						{
							num = (short)1833697284;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						task.AddTask(new global::AcpBusinessLayer.UndoRedo.ModifyDataTask<bool>(radWideLabtoolZoneSelectorOnSwitch_A, false));
						num = (short)1847001096;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 8:
						goto IL_23F;
					case 9:
						task.AddTask(new global::AcpBusinessLayer.UndoRedo.ModifyDataTask<bool>(radWideLabtoolChannelSelectorOnSwitch_A, true));
						num = (short)2106851360;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 10:
						if (num3 == 29)
						{
							num = (short)1358037012;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						task.AddTask(new global::AcpBusinessLayer.UndoRedo.ModifyDataTask<bool>(radWideLabtoolChannelSelectorOnSwitch_A, false));
						num = (short)914751513;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 11:
						goto IL_84D;
					case 12:
						if (switchConventionalSwitchesPosition3_A.Value == 30)
						{
							num = (short)1219821586;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_890;
					case 13:
						if (global::ConstraintHelper.UtilityMack.ProductModelId != global::AllFeatures.CodeplugGuid.b("蛆駈鏊ﻌￎ", a_))
						{
							num = (short)1569456137;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_917;
					case 14:
						if (switchConventionalSwitchesPosition4_A.Value != 30)
						{
							num = (short)1134821412;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_9AA;
					case 15:
					{
						try
						{
							num = (short)1650196480;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								switch (num2)
								{
								case 0:
									switch (0)
									{
									case 0:
										goto IL_32F;
									}
									continue;
								case 1:
									goto IL_479;
								case 2:
								{
									global::AcpCommonLib.IAcpFeatureNode acpFeatureNode;
									task.AddTask(new global::AcpBusinessLayer.UndoRedo.ModifyDataTask<int>((acpFeatureNode[10086] as global::Motorola.MackinawCPS.CoreFeatures.Switches.ConventionalSwitchTableInnerSection).SwitchConventionalSwitchTablePosition1Feature_A19655, switchConventionalSwitchesPosition3_A.Value));
									task.AddTask(new global::AcpBusinessLayer.UndoRedo.ModifyDataTask<int>((acpFeatureNode[10086] as global::Motorola.MackinawCPS.CoreFeatures.Switches.ConventionalSwitchTableInnerSection).SwitchConventionalSwitchTablePosition2Feature_A19656, switchConventionalSwitchesPosition4_A.Value));
									task.AddTask(new global::AcpBusinessLayer.UndoRedo.ModifyDataTask<int>((acpFeatureNode[10086] as global::Motorola.MackinawCPS.CoreFeatures.Switches.ConventionalSwitchTableInnerSection).SwitchConventionalSwitchTablePosition3Feature_A19657, switchConventionalSwitchesPosition5_A.Value));
									num = (short)1027211270;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 3:
								{
									if (!enumerator.MoveNext())
									{
										num = (short)1245708292;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									global::AcpCommonLib.IAcpFeatureNode acpFeatureNode = enumerator.Current;
									num = (short)287375365;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 4:
									num = (short)764542977;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 5:
								{
									global::AcpCommonLib.IAcpFeatureNode acpFeatureNode;
									if ((acpFeatureNode.Parent as global::AcpBusinessLayer.Recordset).IndexOf(acpFeatureNode) == 3)
									{
										num = (short)45154306;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									break;
								}
								case 6:
									goto IL_3C5;
								}
								IL_421:
								num = (short)27918339;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								IL_32F:
								goto IL_421;
							}
							IL_3C5:
							IL_479:
							goto IL_595;
						}
						finally
						{
							num = (short)1244266498;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								switch (num2)
								{
								case 0:
									enumerator.Dispose();
									num = (short)1475805185;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 1:
									goto IL_4E7;
								case 2:
									switch (0)
									{
									case 0:
										goto IL_4B0;
									}
									continue;
								}
								IL_4B0:
								if (enumerator == null)
								{
									break;
								}
								num = (short)1897070592;
								num2 = (int)((global::System.IntPtr)num);
							}
							IL_4E7:;
						}
						goto IL_4EA;
						IL_595:
						enumerator = trunkingSwitchTableInnerRecset.GetEnumerator();
						num = (short)1194205934;
						short num4 = num;
						num = (short)350561006;
						switch ((num4 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_B30;
						default:
							num = (short)318504960;
							if (num != 0)
							{
							}
							num = (short)1761476624;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						break;
					}
					case 16:
						try
						{
							num = (short)2067595264;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								switch (num2)
								{
								case 0:
									switch (0)
									{
									case 0:
										goto IL_BD9;
									}
									continue;
								case 1:
									goto IL_D17;
								case 2:
								{
									if (!enumerator.MoveNext())
									{
										num = (short)1013252099;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									global::AcpCommonLib.IAcpFeatureNode acpFeatureNode2 = enumerator.Current;
									num = (short)797114374;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 3:
									num = (short)1576468481;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 4:
									goto IL_CFA;
								case 5:
								{
									global::AcpCommonLib.IAcpFeatureNode acpFeatureNode2;
									task.AddTask(new global::AcpBusinessLayer.UndoRedo.ModifyDataTask<int>((acpFeatureNode2[10084] as global::Motorola.MackinawCPS.CoreFeatures.Switches.TrunkingSwitchTableInnerSection).SwitchTrunkingSwitchTablePosition1Feature_A21004, switchTrunkingSwitchesPosition3_A.Value));
									task.AddTask(new global::AcpBusinessLayer.UndoRedo.ModifyDataTask<int>((acpFeatureNode2[10084] as global::Motorola.MackinawCPS.CoreFeatures.Switches.TrunkingSwitchTableInnerSection).SwitchTrunkingSwitchTablePosition2Feature_A21005, switchTrunkingSwitchesPosition4_A.Value));
									task.AddTask(new global::AcpBusinessLayer.UndoRedo.ModifyDataTask<int>((acpFeatureNode2[10084] as global::Motorola.MackinawCPS.CoreFeatures.Switches.TrunkingSwitchTableInnerSection).SwitchTrunkingSwitchTablePosition3Feature_A21006, switchTrunkingSwitchesPosition5_A.Value));
									num = (short)1932656644;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 6:
								{
									global::AcpCommonLib.IAcpFeatureNode acpFeatureNode2;
									if ((acpFeatureNode2.Parent as global::AcpBusinessLayer.Recordset).IndexOf(acpFeatureNode2) == 3)
									{
										num = (short)2026045445;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									break;
								}
								}
								IL_C2A:
								num = (short)524025858;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								IL_BD9:
								goto IL_C2A;
							}
							IL_CFA:
							IL_D17:
							return;
						}
						finally
						{
							num = (short)1210777602;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								switch (num2)
								{
								case 0:
									enumerator.Dispose();
									num = (short)1732313089;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 1:
									goto IL_D86;
								case 2:
									switch (0)
									{
									case 0:
										goto IL_D4E;
									}
									continue;
								}
								IL_D4E:
								if (enumerator == null)
								{
									break;
								}
								num = (short)471531520;
								num2 = (int)((global::System.IntPtr)num);
							}
							IL_D86:;
						}
						goto IL_D89;
					case 17:
						num = (short)2018967566;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 18:
						goto IL_4EA;
					case 19:
						if (switchConventionalSwitchesPosition1_A.Value != 30)
						{
							num = (short)1556021249;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_B6B;
					case 20:
						num = (short)1995636737;
						if (num != 0)
						{
						}
						goto IL_555;
					case 21:
						goto IL_9AA;
					case 22:
						goto IL_890;
					case 23:
						if (switchConventionalSwitchesPosition3_A.Value != 30)
						{
							num = (short)480313346;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_B6B;
					case 24:
						num = (short)1626734620;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 25:
						goto IL_917;
					case 26:
						goto IL_675;
					case 27:
						if (switchConventionalSwitchesPosition1_A.Value != 29)
						{
							num = (short)389414941;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_555;
					case 28:
						if (switchConventionalSwitchesPosition4_A.Value == 29)
						{
							num = (short)1284112405;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_675;
					case 29:
						num = (short)573833249;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 30:
						if (switchConventionalSwitchesPosition3_A.Value != 30)
						{
							num = (short)1465647121;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_A7D;
					case 31:
						try
						{
							num = (short)1275199488;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								switch (num2)
								{
								case 0:
									switch (0)
									{
									case 0:
										goto IL_6F9;
									}
									continue;
								case 1:
									goto IL_7D9;
								case 2:
									num = (short)2089353217;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 3:
								{
									global::AcpCommonLib.IAcpFeatureNode acpFeatureNode3;
									if ((acpFeatureNode3.Parent as global::AcpBusinessLayer.Recordset).IndexOf(acpFeatureNode3) == 0)
									{
										num = (short)583270404;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									break;
								}
								case 4:
								{
									global::AcpCommonLib.IAcpFeatureNode acpFeatureNode3;
									num3 = (acpFeatureNode3[10082] as global::Motorola.MackinawCPS.CoreFeatures.Switches.RotaryControlInnerSection).SwitchGeneralRotaryControl_A8984.Value;
									num = (short)609157126;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 5:
								{
									if (!enumerator.MoveNext())
									{
										num = (short)1746337794;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									global::AcpCommonLib.IAcpFeatureNode acpFeatureNode3 = enumerator.Current;
									num = (short)1598947331;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 6:
									goto IL_72E;
								}
								IL_733:
								num = (short)1724186629;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								IL_6F9:
								goto IL_733;
							}
							IL_72E:
							IL_7D9:
							goto IL_AC0;
						}
						finally
						{
							num = (short)1417871362;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								switch (num2)
								{
								case 0:
									enumerator.Dispose();
									num = (short)1821442049;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 1:
									goto IL_84A;
								case 2:
									switch (0)
									{
									case 0:
										goto IL_811;
									}
									continue;
								}
								IL_811:
								if (enumerator == null)
								{
									break;
								}
								num = (short)138674176;
								num2 = (int)((global::System.IntPtr)num);
							}
							IL_84A:;
						}
						goto IL_84D;
						IL_AC0:
						num = (short)1570111500;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 32:
						goto IL_917;
					case 33:
						if (switchConventionalSwitchesPosition3_A.Value != 29)
						{
							num = (short)259653632;
							short num5 = num;
							num = (short)529334278;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_555;
					case 34:
						goto IL_23F;
					case 35:
						task.AddTask(new global::AcpBusinessLayer.UndoRedo.ModifyDataTask<int>(switchConventionalSwitchesPosition4_A, 29));
						task.AddTask(new global::AcpBusinessLayer.UndoRedo.ModifyDataTask<int>(switchConventionalSwitchesPosition5_A, 29));
						task.AddTask(new global::AcpBusinessLayer.UndoRedo.ModifyDataTask<int>(switchTrunkingSwitchesPosition3_A, switchConventionalSwitchesPosition3_A.Value));
						task.AddTask(new global::AcpBusinessLayer.UndoRedo.ModifyDataTask<int>(switchTrunkingSwitchesPosition4_A, 29));
						task.AddTask(new global::AcpBusinessLayer.UndoRedo.ModifyDataTask<int>(switchTrunkingSwitchesPosition5_A, 29));
						num = (short)1707802635;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 36:
						goto IL_A7D;
					case 37:
						num = (short)594804749;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_D0;
					IL_23F:
					num = (short)58916891;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_4EA:
					task.AddTask(new global::AcpBusinessLayer.UndoRedo.ModifyDataTask<int>(switchConventionalSwitchesPosition4_A, 30));
					task.AddTask(new global::AcpBusinessLayer.UndoRedo.ModifyDataTask<int>(switchConventionalSwitchesPosition5_A, 30));
					task.AddTask(new global::AcpBusinessLayer.UndoRedo.ModifyDataTask<int>(switchTrunkingSwitchesPosition3_A, switchConventionalSwitchesPosition3_A.Value));
					task.AddTask(new global::AcpBusinessLayer.UndoRedo.ModifyDataTask<int>(switchTrunkingSwitchesPosition4_A, 30));
					task.AddTask(new global::AcpBusinessLayer.UndoRedo.ModifyDataTask<int>(switchTrunkingSwitchesPosition5_A, 30));
					num = (short)126287894;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_555:
					num = (short)1277820933;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_675:
					num = (short)321519635;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_84D:
					num = (short)1048707102;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_890:
					num = (short)1556021248;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_917:
					enumerator = conventionalSwitchTableInnerRecset.GetEnumerator();
					num = (short)338231311;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_9AA:
					task.AddTask(new global::AcpBusinessLayer.UndoRedo.ModifyDataTask<int>(switchConventionalSwitchesPosition4_A, 38));
					task.AddTask(new global::AcpBusinessLayer.UndoRedo.ModifyDataTask<int>(switchConventionalSwitchesPosition5_A, 38));
					task.AddTask(new global::AcpBusinessLayer.UndoRedo.ModifyDataTask<int>(switchTrunkingSwitchesPosition3_A, 38));
					task.AddTask(new global::AcpBusinessLayer.UndoRedo.ModifyDataTask<int>(switchTrunkingSwitchesPosition4_A, 38));
					task.AddTask(new global::AcpBusinessLayer.UndoRedo.ModifyDataTask<int>(switchTrunkingSwitchesPosition5_A, 38));
					num = (short)1715273754;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_A7D:
					num = (short)1346502659;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_B30:
					num = (short)184156167;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_B6B:
					task.AddTask(new global::AcpBusinessLayer.UndoRedo.ModifyDataTask<bool>(radWideLabtoolZoneSelectorOnSwitch_A, true));
					num = (short)1112145954;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_D89:
					num = (short)1908998154;
					num2 = (int)((global::System.IntPtr)num);
				}
				return;
				IL_D0:
				global::Motorola.MackinawCPS.CoreFeatures.Switches.ConventionalSwitches conventionalSwitches = self as global::Motorola.MackinawCPS.CoreFeatures.Switches.ConventionalSwitches;
				global::Motorola.MackinawCPS.CoreFeatures.Switches.Switches switches = self.Parent as global::Motorola.MackinawCPS.CoreFeatures.Switches.Switches;
				switchTrunkingSwitchesPosition3_A = switches.TrunkingSwitches.SwitchTrunkingSwitchesPosition3_A9468;
				switchTrunkingSwitchesPosition4_A = switches.TrunkingSwitches.SwitchTrunkingSwitchesPosition4_A21534;
				switchTrunkingSwitchesPosition5_A = switches.TrunkingSwitches.SwitchTrunkingSwitchesPosition5_A21535;
				switchConventionalSwitchesPosition1_A = conventionalSwitches.SwitchConventionalSwitchesPosition1_A7734;
				switchConventionalSwitchesPosition3_A = conventionalSwitches.SwitchConventionalSwitchesPosition3_A7737;
				switchConventionalSwitchesPosition4_A = conventionalSwitches.SwitchConventionalSwitchesPosition4_A21530;
				switchConventionalSwitchesPosition5_A = conventionalSwitches.SwitchConventionalSwitchesPosition5_A21531;
				radWideLabtoolZoneSelectorOnSwitch_A = conventionalSwitches.RefRadioWide.Labtool.RadWideLabtoolZoneSelectorOnSwitch_A19550;
				radWideLabtoolChannelSelectorOnSwitch_A = conventionalSwitches.RefRadioWide.Labtool.RadWideLabtoolChannelSelectorOnSwitch_A19551;
				global::System.Collections.ObjectModel.Collection<global::AcpBusinessLayer.FeatureNode> collection = (global::AcpCommonLib.FeatureManager.GetFeature(2038) as global::Motorola.MackinawCPS.CoreFeatures.Switches.SwitchesRecset)[0][10081].EmbeddedRecset as global::Motorola.MackinawCPS.CoreFeatures.Switches.RotaryControlInnerRecset;
				conventionalSwitchTableInnerRecset = ((global::AcpCommonLib.FeatureManager.GetFeature(2038) as global::Motorola.MackinawCPS.CoreFeatures.Switches.SwitchesRecset)[0][10085].EmbeddedRecset as global::Motorola.MackinawCPS.CoreFeatures.Switches.ConventionalSwitchTableInnerRecset);
				trunkingSwitchTableInnerRecset = ((global::AcpCommonLib.FeatureManager.GetFeature(2038) as global::Motorola.MackinawCPS.CoreFeatures.Switches.SwitchesRecset)[0][10083].EmbeddedRecset as global::Motorola.MackinawCPS.CoreFeatures.Switches.TrunkingSwitchTableInnerRecset);
				num3 = 0;
				enumerator = collection.GetEnumerator();
				num = (short)282656799;
				num2 = (int)((global::System.IntPtr)num);
				goto IL_31;
			}
			}
		}

		// Token: 0x060073B1 RID: 29617 RVA: 0x00681E30 File Offset: 0x00680030
		internal static void ConSyncPositionBInFirstRecCnvSwitches(global::AcpCommonLib.IAcpFeatureSection self, global::AcpCommonLib.UndoRedo.ContainerTask task)
		{
			short num = (short)1485635584;
			short num2 = num;
			num = (short)215285761;
			if (num != 0)
			{
			}
			num = (short)1544637908;
			short num3 = num;
			num = (short)1130188244;
			switch ((num3 == num) ? 1 : 0)
			{
			case 0:
			case 2:
				break;
			default:
			{
				num = (short)416088064;
				if (num != 0)
				{
				}
				global::Motorola.MackinawCPS.CoreFeatures.Switches.ConventionalSwitches conventionalSwitches = self as global::Motorola.MackinawCPS.CoreFeatures.Switches.ConventionalSwitches;
				global::System.Collections.Generic.IEnumerator<global::AcpBusinessLayer.FeatureNode> enumerator = ((global::AcpCommonLib.FeatureManager.GetFeature(2038) as global::Motorola.MackinawCPS.CoreFeatures.Switches.SwitchesRecset)[0][10085].EmbeddedRecset as global::Motorola.MackinawCPS.CoreFeatures.Switches.ConventionalSwitchTableInnerRecset).GetEnumerator();
				try
				{
					num = (short)774963201;
					int num4 = (int)((global::System.IntPtr)num);
					for (;;)
					{
						switch (num4)
						{
						case 0:
						{
							global::AcpCommonLib.IAcpFeatureNode acpFeatureNode;
							if ((acpFeatureNode.Parent as global::AcpBusinessLayer.Recordset).IndexOf(acpFeatureNode) == 0)
							{
								num = (short)1795620867;
								num4 = (int)((global::System.IntPtr)num);
								continue;
							}
							break;
						}
						case 1:
							switch (0)
							{
							case 0:
								goto IL_112;
							}
							continue;
						case 2:
							goto IL_1EE;
						case 3:
						{
							global::AcpCommonLib.IAcpFeatureNode acpFeatureNode;
							task.AddTask(new global::AcpBusinessLayer.UndoRedo.ModifyDataTask<int>((acpFeatureNode[10086] as global::Motorola.MackinawCPS.CoreFeatures.Switches.ConventionalSwitchTableInnerSection).SwitchConventionalSwitchTablePosition2Feature_A19656, conventionalSwitches.SwitchConventionalSwitchesPosition2_A7735.Value));
							num = (short)1529610244;
							num4 = (int)((global::System.IntPtr)num);
							continue;
						}
						case 4:
							goto IL_1D2;
						case 5:
						{
							if (!enumerator.MoveNext())
							{
								num = (short)265748486;
								num4 = (int)((global::System.IntPtr)num);
								continue;
							}
							global::AcpCommonLib.IAcpFeatureNode acpFeatureNode = enumerator.Current;
							num = (short)863174656;
							num4 = (int)((global::System.IntPtr)num);
							continue;
						}
						case 6:
							num = (short)769720322;
							num4 = (int)((global::System.IntPtr)num);
							continue;
						}
						IL_158:
						num = (short)919142405;
						num4 = (int)((global::System.IntPtr)num);
						continue;
						IL_112:
						goto IL_158;
					}
					IL_1D2:
					IL_1EE:;
				}
				finally
				{
					num = (short)172294144;
					int num4 = (int)((global::System.IntPtr)num);
					for (;;)
					{
						switch (num4)
						{
						case 0:
							switch (0)
							{
							case 0:
								goto IL_221;
							}
							continue;
						case 1:
							goto IL_255;
						case 2:
							enumerator.Dispose();
							num = (short)258539521;
							num4 = (int)((global::System.IntPtr)num);
							continue;
						}
						IL_221:
						if (enumerator == null)
						{
							break;
						}
						num = (short)1072562178;
						num4 = (int)((global::System.IntPtr)num);
					}
					IL_255:;
				}
				break;
			}
			}
		}

		// Token: 0x060073B2 RID: 29618 RVA: 0x006820B4 File Offset: 0x006802B4
		internal static void ConSyncPositionBInFourthRecCnvSwitches(global::AcpCommonLib.IAcpFeatureSection self, global::AcpCommonLib.UndoRedo.ContainerTask task)
		{
			short num = (short)1724383232;
			short num2 = num;
			num = (short)779026433;
			if (num != 0)
			{
			}
			num = (short)474476929;
			short num3 = num;
			num = (short)1217524097;
			switch ((num3 == num) ? 1 : 0)
			{
			case 0:
			case 2:
				break;
			default:
			{
				num = (short)1777795072;
				if (num != 0)
				{
				}
				global::Motorola.MackinawCPS.CoreFeatures.Switches.ConventionalSwitches conventionalSwitches = self as global::Motorola.MackinawCPS.CoreFeatures.Switches.ConventionalSwitches;
				global::System.Collections.Generic.IEnumerator<global::AcpBusinessLayer.FeatureNode> enumerator = ((global::AcpCommonLib.FeatureManager.GetFeature(2038) as global::Motorola.MackinawCPS.CoreFeatures.Switches.SwitchesRecset)[0][10085].EmbeddedRecset as global::Motorola.MackinawCPS.CoreFeatures.Switches.ConventionalSwitchTableInnerRecset).GetEnumerator();
				try
				{
					num = (short)2109734913;
					int num4 = (int)((global::System.IntPtr)num);
					for (;;)
					{
						switch (num4)
						{
						case 0:
						{
							global::AcpCommonLib.IAcpFeatureNode acpFeatureNode;
							if ((acpFeatureNode.Parent as global::AcpBusinessLayer.Recordset).IndexOf(acpFeatureNode) == 3)
							{
								num = (short)1737818115;
								num4 = (int)((global::System.IntPtr)num);
								continue;
							}
							break;
						}
						case 1:
							switch (0)
							{
							case 0:
								goto IL_112;
							}
							continue;
						case 2:
							goto IL_1EF;
						case 3:
						{
							global::AcpCommonLib.IAcpFeatureNode acpFeatureNode;
							task.AddTask(new global::AcpBusinessLayer.UndoRedo.ModifyDataTask<int>((acpFeatureNode[10086] as global::Motorola.MackinawCPS.CoreFeatures.Switches.ConventionalSwitchTableInnerSection).SwitchConventionalSwitchTablePosition2Feature_A19656, conventionalSwitches.SwitchConventionalSwitchesPosition4_A21530.Value));
							num = (short)373227524;
							num4 = (int)((global::System.IntPtr)num);
							continue;
						}
						case 4:
							goto IL_1D3;
						case 5:
						{
							if (!enumerator.MoveNext())
							{
								num = (short)1572536326;
								num4 = (int)((global::System.IntPtr)num);
								continue;
							}
							global::AcpCommonLib.IAcpFeatureNode acpFeatureNode = enumerator.Current;
							num = (short)423362560;
							num4 = (int)((global::System.IntPtr)num);
							continue;
						}
						case 6:
							num = (short)707723266;
							num4 = (int)((global::System.IntPtr)num);
							continue;
						}
						IL_15B:
						num = (short)40108037;
						num4 = (int)((global::System.IntPtr)num);
						continue;
						IL_112:
						goto IL_15B;
					}
					IL_1D3:
					IL_1EF:;
				}
				finally
				{
					num = (short)1615593472;
					int num4 = (int)((global::System.IntPtr)num);
					for (;;)
					{
						switch (num4)
						{
						case 0:
							switch (0)
							{
							case 0:
								goto IL_221;
							}
							continue;
						case 1:
							goto IL_255;
						case 2:
							enumerator.Dispose();
							num = (short)1043333121;
							num4 = (int)((global::System.IntPtr)num);
							continue;
						}
						IL_221:
						if (enumerator == null)
						{
							break;
						}
						num = (short)59375618;
						num4 = (int)((global::System.IntPtr)num);
					}
					IL_255:;
				}
				break;
			}
			}
		}

		// Token: 0x060073B3 RID: 29619 RVA: 0x00682338 File Offset: 0x00680538
		internal static void ConSyncPositionCInFourthRecCnvSwitches(global::AcpCommonLib.IAcpFeatureSection self, global::AcpCommonLib.UndoRedo.ContainerTask task)
		{
			short num;
			for (;;)
			{
				num = (short)158400512;
				short num2 = num;
				global::Motorola.MackinawCPS.CoreFeatures.Switches.ConventionalSwitches conventionalSwitches = self as global::Motorola.MackinawCPS.CoreFeatures.Switches.ConventionalSwitches;
				global::System.Collections.Generic.IEnumerator<global::AcpBusinessLayer.FeatureNode> enumerator = ((global::AcpCommonLib.FeatureManager.GetFeature(2038) as global::Motorola.MackinawCPS.CoreFeatures.Switches.SwitchesRecset)[0][10085].EmbeddedRecset as global::Motorola.MackinawCPS.CoreFeatures.Switches.ConventionalSwitchTableInnerRecset).GetEnumerator();
				try
				{
					num = (short)2079653889;
					int num3 = (int)((global::System.IntPtr)num);
					for (;;)
					{
						switch (num3)
						{
						case 0:
						{
							if (!enumerator.MoveNext())
							{
								num = (short)758185986;
								num3 = (int)((global::System.IntPtr)num);
								continue;
							}
							global::AcpCommonLib.IAcpFeatureNode acpFeatureNode = enumerator.Current;
							num = (short)2009202692;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						}
						case 1:
							switch (0)
							{
							case 0:
								goto IL_A2;
							}
							continue;
						case 2:
							num = (short)647626755;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						case 3:
							goto IL_17F;
						case 4:
						{
							global::AcpCommonLib.IAcpFeatureNode acpFeatureNode;
							if ((acpFeatureNode.Parent as global::AcpBusinessLayer.Recordset).IndexOf(acpFeatureNode) == 3)
							{
								num = (short)2068774918;
								num3 = (int)((global::System.IntPtr)num);
								continue;
							}
							break;
						}
						case 5:
							goto IL_162;
						case 6:
						{
							global::AcpCommonLib.IAcpFeatureNode acpFeatureNode;
							task.AddTask(new global::AcpBusinessLayer.UndoRedo.ModifyDataTask<int>((acpFeatureNode[10086] as global::Motorola.MackinawCPS.CoreFeatures.Switches.ConventionalSwitchTableInnerSection).SwitchConventionalSwitchTablePosition3Feature_A19657, conventionalSwitches.SwitchConventionalSwitchesPosition5_A21531.Value));
							num = (short)1092288517;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						}
						}
						IL_E9:
						num = (short)1192558592;
						num3 = (int)((global::System.IntPtr)num);
						continue;
						IL_A2:
						goto IL_E9;
					}
					IL_162:
					IL_17F:;
				}
				finally
				{
					num = (short)1314783232;
					int num3 = (int)((global::System.IntPtr)num);
					for (;;)
					{
						switch (num3)
						{
						case 0:
							switch (0)
							{
							case 0:
								goto IL_1B1;
							}
							continue;
						case 1:
							goto IL_1E4;
						case 2:
							enumerator.Dispose();
							num = (short)643694593;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						}
						IL_1B1:
						if (enumerator == null)
						{
							break;
						}
						num = (short)1301479426;
						num3 = (int)((global::System.IntPtr)num);
					}
					IL_1E4:;
				}
				num = (short)1812332545;
				if (num != 0)
				{
				}
				num = (short)989155530;
				short num4 = num;
				num = (short)894456010;
				switch ((num4 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					break;
				default:
					goto IL_244;
				}
			}
			IL_244:
			num = (short)319029248;
			if (num != 0)
			{
			}
		}

		// Token: 0x060073B4 RID: 29620 RVA: 0x006825BC File Offset: 0x006807BC
		internal static void ConSyncPositionAInFirstRecTrkSwitches(global::AcpCommonLib.IAcpFeatureSection self, global::AcpCommonLib.UndoRedo.ContainerTask task)
		{
			short num;
			for (;;)
			{
				num = (short)1269760000;
				short num2 = num;
				global::Motorola.MackinawCPS.CoreFeatures.Switches.TrunkingSwitches trunkingSwitches = self as global::Motorola.MackinawCPS.CoreFeatures.Switches.TrunkingSwitches;
				global::System.Collections.Generic.IEnumerator<global::AcpBusinessLayer.FeatureNode> enumerator = ((global::AcpCommonLib.FeatureManager.GetFeature(2038) as global::Motorola.MackinawCPS.CoreFeatures.Switches.SwitchesRecset)[0][10083].EmbeddedRecset as global::Motorola.MackinawCPS.CoreFeatures.Switches.TrunkingSwitchTableInnerRecset).GetEnumerator();
				try
				{
					num = (short)1874526209;
					int num3 = (int)((global::System.IntPtr)num);
					for (;;)
					{
						switch (num3)
						{
						case 0:
						{
							if (!enumerator.MoveNext())
							{
								num = (short)2068578306;
								num3 = (int)((global::System.IntPtr)num);
								continue;
							}
							global::AcpCommonLib.IAcpFeatureNode acpFeatureNode = enumerator.Current;
							num = (short)1677262852;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						}
						case 1:
							switch (0)
							{
							case 0:
								goto IL_A4;
							}
							continue;
						case 2:
							num = (short)2115174403;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						case 3:
							goto IL_182;
						case 4:
						{
							global::AcpCommonLib.IAcpFeatureNode acpFeatureNode;
							if ((acpFeatureNode.Parent as global::AcpBusinessLayer.Recordset).IndexOf(acpFeatureNode) == 0)
							{
								num = (short)1841627142;
								num3 = (int)((global::System.IntPtr)num);
								continue;
							}
							break;
						}
						case 5:
							goto IL_165;
						case 6:
						{
							global::AcpCommonLib.IAcpFeatureNode acpFeatureNode;
							task.AddTask(new global::AcpBusinessLayer.UndoRedo.ModifyDataTask<int>((acpFeatureNode[10084] as global::Motorola.MackinawCPS.CoreFeatures.Switches.TrunkingSwitchTableInnerSection).SwitchTrunkingSwitchTablePosition1Feature_A21004, trunkingSwitches.SwitchTrunkingSwitchesPosition1_A9466.Value));
							num = (short)262930437;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						}
						}
						IL_EC:
						num = (short)859832320;
						num3 = (int)((global::System.IntPtr)num);
						continue;
						IL_A4:
						goto IL_EC;
					}
					IL_165:
					IL_182:;
				}
				finally
				{
					num = (short)501612544;
					int num3 = (int)((global::System.IntPtr)num);
					for (;;)
					{
						switch (num3)
						{
						case 0:
							switch (0)
							{
							case 0:
								goto IL_1B4;
							}
							continue;
						case 1:
							goto IL_1E8;
						case 2:
							enumerator.Dispose();
							num = (short)1925775361;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						}
						IL_1B4:
						if (enumerator == null)
						{
							break;
						}
						num = (short)1295056898;
						num3 = (int)((global::System.IntPtr)num);
					}
					IL_1E8:;
				}
				num = (short)1890957790;
				short num4 = num;
				num = (short)505985502;
				switch ((num4 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					break;
				default:
					goto IL_222;
				}
			}
			IL_222:
			num = (short)1195180033;
			if (num != 0)
			{
			}
			num = (short)1515651072;
			if (num != 0)
			{
			}
		}

		// Token: 0x060073B5 RID: 29621 RVA: 0x00682844 File Offset: 0x00680A44
		internal static void ConSyncPositionAInFourthRecTrkSwitches(global::AcpCommonLib.IAcpFeatureSection self, global::AcpCommonLib.UndoRedo.ContainerTask task)
		{
			short num;
			for (;;)
			{
				num = (short)1948057600;
				short num2 = num;
				global::Motorola.MackinawCPS.CoreFeatures.Switches.TrunkingSwitches trunkingSwitches = self as global::Motorola.MackinawCPS.CoreFeatures.Switches.TrunkingSwitches;
				global::System.Collections.Generic.IEnumerator<global::AcpBusinessLayer.FeatureNode> enumerator = ((global::AcpCommonLib.FeatureManager.GetFeature(2038) as global::Motorola.MackinawCPS.CoreFeatures.Switches.SwitchesRecset)[0][10083].EmbeddedRecset as global::Motorola.MackinawCPS.CoreFeatures.Switches.TrunkingSwitchTableInnerRecset).GetEnumerator();
				try
				{
					num = (short)1744961537;
					int num3 = (int)((global::System.IntPtr)num);
					for (;;)
					{
						switch (num3)
						{
						case 0:
						{
							if (!enumerator.MoveNext())
							{
								num = (short)1530527746;
								num3 = (int)((global::System.IntPtr)num);
								continue;
							}
							global::AcpCommonLib.IAcpFeatureNode acpFeatureNode = enumerator.Current;
							num = (short)883163140;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						}
						case 1:
							switch (0)
							{
							case 0:
								goto IL_A3;
							}
							continue;
						case 2:
							num = (short)1044578307;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						case 3:
							goto IL_181;
						case 4:
						{
							global::AcpCommonLib.IAcpFeatureNode acpFeatureNode;
							if ((acpFeatureNode.Parent as global::AcpBusinessLayer.Recordset).IndexOf(acpFeatureNode) == 3)
							{
								num = (short)727646214;
								num3 = (int)((global::System.IntPtr)num);
								continue;
							}
							break;
						}
						case 5:
							goto IL_164;
						case 6:
						{
							global::AcpCommonLib.IAcpFeatureNode acpFeatureNode;
							task.AddTask(new global::AcpBusinessLayer.UndoRedo.ModifyDataTask<int>((acpFeatureNode[10084] as global::Motorola.MackinawCPS.CoreFeatures.Switches.TrunkingSwitchTableInnerSection).SwitchTrunkingSwitchTablePosition1Feature_A21004, trunkingSwitches.SwitchTrunkingSwitchesPosition3_A9468.Value));
							num = (short)1100218373;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						}
						}
						IL_EB:
						num = (short)1331691520;
						num3 = (int)((global::System.IntPtr)num);
						continue;
						IL_A3:
						goto IL_EB;
					}
					IL_164:
					IL_181:;
				}
				finally
				{
					num = (short)1351745536;
					int num3 = (int)((global::System.IntPtr)num);
					for (;;)
					{
						switch (num3)
						{
						case 0:
							switch (0)
							{
							case 0:
								goto IL_1B3;
							}
							continue;
						case 1:
							goto IL_1E6;
						case 2:
							enumerator.Dispose();
							num = (short)1748238337;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						}
						IL_1B3:
						if (enumerator == null)
						{
							break;
						}
						num = (short)364314626;
						num3 = (int)((global::System.IntPtr)num);
					}
					IL_1E6:;
				}
				num = (short)1790404497;
				short num4 = num;
				num = (short)822044561;
				switch ((num4 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					break;
				default:
					goto IL_220;
				}
			}
			IL_220:
			num = (short)1354432513;
			if (num != 0)
			{
			}
			num = (short)1946484736;
			if (num != 0)
			{
			}
		}

		// Token: 0x060073B6 RID: 29622 RVA: 0x00682ACC File Offset: 0x00680CCC
		internal static void ConSyncPositionBInFirstRecTrkSwitches(global::AcpCommonLib.IAcpFeatureSection self, global::AcpCommonLib.UndoRedo.ContainerTask task)
		{
			short num;
			for (;;)
			{
				num = (short)1349320704;
				short num2 = num;
				global::Motorola.MackinawCPS.CoreFeatures.Switches.TrunkingSwitches trunkingSwitches = self as global::Motorola.MackinawCPS.CoreFeatures.Switches.TrunkingSwitches;
				global::System.Collections.Generic.IEnumerator<global::AcpBusinessLayer.FeatureNode> enumerator = ((global::AcpCommonLib.FeatureManager.GetFeature(2038) as global::Motorola.MackinawCPS.CoreFeatures.Switches.SwitchesRecset)[0][10083].EmbeddedRecset as global::Motorola.MackinawCPS.CoreFeatures.Switches.TrunkingSwitchTableInnerRecset).GetEnumerator();
				try
				{
					num = (short)2026962945;
					int num3 = (int)((global::System.IntPtr)num);
					for (;;)
					{
						switch (num3)
						{
						case 0:
						{
							if (!enumerator.MoveNext())
							{
								num = (short)626851842;
								num3 = (int)((global::System.IntPtr)num);
								continue;
							}
							global::AcpCommonLib.IAcpFeatureNode acpFeatureNode = enumerator.Current;
							num = (short)1596784644;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						}
						case 1:
							switch (0)
							{
							case 0:
								goto IL_A2;
							}
							continue;
						case 2:
							num = (short)642318339;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						case 3:
							goto IL_17D;
						case 4:
						{
							global::AcpCommonLib.IAcpFeatureNode acpFeatureNode;
							if ((acpFeatureNode.Parent as global::AcpBusinessLayer.Recordset).IndexOf(acpFeatureNode) == 0)
							{
								num = (short)105119750;
								num3 = (int)((global::System.IntPtr)num);
								continue;
							}
							break;
						}
						case 5:
							goto IL_161;
						case 6:
						{
							global::AcpCommonLib.IAcpFeatureNode acpFeatureNode;
							task.AddTask(new global::AcpBusinessLayer.UndoRedo.ModifyDataTask<int>((acpFeatureNode[10084] as global::Motorola.MackinawCPS.CoreFeatures.Switches.TrunkingSwitchTableInnerSection).SwitchTrunkingSwitchTablePosition2Feature_A21005, trunkingSwitches.SwitchTrunkingSwitchesPosition2_A9467.Value));
							num = (short)1998520325;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						}
						}
						IL_E8:
						num = (short)311885824;
						num3 = (int)((global::System.IntPtr)num);
						continue;
						IL_A2:
						goto IL_E8;
					}
					IL_161:
					IL_17D:;
				}
				finally
				{
					num = (short)1797652480;
					int num3 = (int)((global::System.IntPtr)num);
					for (;;)
					{
						switch (num3)
						{
						case 0:
							switch (0)
							{
							case 0:
								goto IL_1B0;
							}
							continue;
						case 1:
							goto IL_1E4;
						case 2:
							enumerator.Dispose();
							num = (short)508166145;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						}
						IL_1B0:
						if (enumerator == null)
						{
							break;
						}
						num = (short)666828802;
						num3 = (int)((global::System.IntPtr)num);
					}
					IL_1E4:;
				}
				num = (short)350085761;
				short num4 = num;
				num = (short)1567285889;
				switch ((num4 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					break;
				default:
					goto IL_21D;
				}
			}
			IL_21D:
			num = (short)1899364352;
			if (num != 0)
			{
			}
			num = (short)791085057;
			if (num != 0)
			{
			}
		}

		// Token: 0x060073B7 RID: 29623 RVA: 0x00682D50 File Offset: 0x00680F50
		internal static void ConSyncPositionBInFourthRecTrkSwitches(global::AcpCommonLib.IAcpFeatureSection self, global::AcpCommonLib.UndoRedo.ContainerTask task)
		{
			short num;
			for (;;)
			{
				num = (short)197132288;
				short num2 = num;
				num = (short)382074881;
				if (num != 0)
				{
				}
				global::Motorola.MackinawCPS.CoreFeatures.Switches.TrunkingSwitches trunkingSwitches = self as global::Motorola.MackinawCPS.CoreFeatures.Switches.TrunkingSwitches;
				global::System.Collections.Generic.IEnumerator<global::AcpBusinessLayer.FeatureNode> enumerator = ((global::AcpCommonLib.FeatureManager.GetFeature(2038) as global::Motorola.MackinawCPS.CoreFeatures.Switches.SwitchesRecset)[0][10083].EmbeddedRecset as global::Motorola.MackinawCPS.CoreFeatures.Switches.TrunkingSwitchTableInnerRecset).GetEnumerator();
				try
				{
					num = (short)466747393;
					int num3 = (int)((global::System.IntPtr)num);
					for (;;)
					{
						switch (num3)
						{
						case 0:
						{
							if (!enumerator.MoveNext())
							{
								num = (short)1406337026;
								num3 = (int)((global::System.IntPtr)num);
								continue;
							}
							global::AcpCommonLib.IAcpFeatureNode acpFeatureNode = enumerator.Current;
							num = (short)1342832644;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						}
						case 1:
							switch (0)
							{
							case 0:
								goto IL_C8;
							}
							continue;
						case 2:
							num = (short)2008350723;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						case 3:
							goto IL_1A6;
						case 4:
						{
							global::AcpCommonLib.IAcpFeatureNode acpFeatureNode;
							if ((acpFeatureNode.Parent as global::AcpBusinessLayer.Recordset).IndexOf(acpFeatureNode) == 3)
							{
								num = (short)165937158;
								num3 = (int)((global::System.IntPtr)num);
								continue;
							}
							break;
						}
						case 5:
							goto IL_18A;
						case 6:
						{
							global::AcpCommonLib.IAcpFeatureNode acpFeatureNode;
							task.AddTask(new global::AcpBusinessLayer.UndoRedo.ModifyDataTask<int>((acpFeatureNode[10084] as global::Motorola.MackinawCPS.CoreFeatures.Switches.TrunkingSwitchTableInnerSection).SwitchTrunkingSwitchTablePosition2Feature_A21005, trunkingSwitches.SwitchTrunkingSwitchesPosition4_A21534.Value));
							num = (short)593100805;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						}
						}
						IL_10F:
						num = (short)1770717184;
						num3 = (int)((global::System.IntPtr)num);
						continue;
						IL_C8:
						goto IL_10F;
					}
					IL_18A:
					IL_1A6:;
				}
				finally
				{
					num = (short)2105278464;
					int num3 = (int)((global::System.IntPtr)num);
					for (;;)
					{
						switch (num3)
						{
						case 0:
							switch (0)
							{
							case 0:
								goto IL_1D9;
							}
							continue;
						case 1:
							goto IL_20C;
						case 2:
							enumerator.Dispose();
							num = (short)181927937;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						}
						IL_1D9:
						if (enumerator == null)
						{
							break;
						}
						num = (short)119996418;
						num3 = (int)((global::System.IntPtr)num);
					}
					IL_20C:;
				}
				num = (short)200626954;
				short num4 = num;
				num = (short)1356747530;
				switch ((num4 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					break;
				default:
					goto IL_245;
				}
			}
			IL_245:
			num = (short)911278080;
			if (num != 0)
			{
			}
		}

		// Token: 0x060073B8 RID: 29624 RVA: 0x00682FD4 File Offset: 0x006811D4
		internal static void ConSyncPositionCInFourthRecTrkSwitches(global::AcpCommonLib.IAcpFeatureSection self, global::AcpCommonLib.UndoRedo.ContainerTask task)
		{
			short num;
			for (;;)
			{
				num = (short)1564540928;
				short num2 = num;
				global::Motorola.MackinawCPS.CoreFeatures.Switches.TrunkingSwitches trunkingSwitches = self as global::Motorola.MackinawCPS.CoreFeatures.Switches.TrunkingSwitches;
				global::System.Collections.Generic.IEnumerator<global::AcpBusinessLayer.FeatureNode> enumerator = ((global::AcpCommonLib.FeatureManager.GetFeature(2038) as global::Motorola.MackinawCPS.CoreFeatures.Switches.SwitchesRecset)[0][10083].EmbeddedRecset as global::Motorola.MackinawCPS.CoreFeatures.Switches.TrunkingSwitchTableInnerRecset).GetEnumerator();
				try
				{
					num = (short)1713438721;
					int num3 = (int)((global::System.IntPtr)num);
					for (;;)
					{
						switch (num3)
						{
						case 0:
						{
							if (!enumerator.MoveNext())
							{
								num = (short)1308491778;
								num3 = (int)((global::System.IntPtr)num);
								continue;
							}
							global::AcpCommonLib.IAcpFeatureNode acpFeatureNode = enumerator.Current;
							num = (short)2060451844;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						}
						case 1:
							switch (0)
							{
							case 0:
								goto IL_A0;
							}
							continue;
						case 2:
							num = (short)831062019;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						case 3:
							goto IL_17D;
						case 4:
						{
							global::AcpCommonLib.IAcpFeatureNode acpFeatureNode;
							if ((acpFeatureNode.Parent as global::AcpBusinessLayer.Recordset).IndexOf(acpFeatureNode) == 3)
							{
								num = (short)1812332550;
								num3 = (int)((global::System.IntPtr)num);
								continue;
							}
							break;
						}
						case 5:
							goto IL_160;
						case 6:
						{
							global::AcpCommonLib.IAcpFeatureNode acpFeatureNode;
							task.AddTask(new global::AcpBusinessLayer.UndoRedo.ModifyDataTask<int>((acpFeatureNode[10084] as global::Motorola.MackinawCPS.CoreFeatures.Switches.TrunkingSwitchTableInnerSection).SwitchTrunkingSwitchTablePosition3Feature_A21006, trunkingSwitches.SwitchTrunkingSwitchesPosition5_A21535.Value));
							num = (short)510525445;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						}
						}
						IL_E9:
						num = (short)2091319296;
						num3 = (int)((global::System.IntPtr)num);
						continue;
						IL_A0:
						goto IL_E9;
					}
					IL_160:
					IL_17D:;
				}
				finally
				{
					num = (short)1905459200;
					int num3 = (int)((global::System.IntPtr)num);
					for (;;)
					{
						switch (num3)
						{
						case 0:
							switch (0)
							{
							case 0:
								goto IL_1B0;
							}
							continue;
						case 1:
							goto IL_1E5;
						case 2:
							enumerator.Dispose();
							num = (short)318242817;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						}
						IL_1B0:
						if (enumerator == null)
						{
							break;
						}
						num = (short)2072313858;
						num3 = (int)((global::System.IntPtr)num);
					}
					IL_1E5:;
				}
				num = (short)893416972;
				short num4 = num;
				num = (short)1978037772;
				switch ((num4 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					break;
				default:
					goto IL_21D;
				}
			}
			IL_21D:
			num = (short)510459905;
			if (num != 0)
			{
			}
			num = (short)270991360;
			if (num != 0)
			{
			}
		}

		// Token: 0x060073B9 RID: 29625 RVA: 0x00683258 File Offset: 0x00681458
		internal static void SyncPositionAInCnvSwitchTable(global::AcpCommonLib.IAcpFeatureSection self, global::AcpCommonLib.UndoRedo.ContainerTask task)
		{
			short num = (short)142475264;
			int num2 = (int)num;
			switch (num2)
			{
			default:
			{
				switch (0)
				{
				case 0:
					goto IL_A5;
				}
				int num4;
				global::Motorola.MackinawCPS.CoreFeatures.Switches.Switches switches;
				int value;
				global::Motorola.MackinawCPS.CoreFeatures.Switches.TrunkingSwitchTableInnerRecset trunkingSwitchTableInnerRecset;
				global::Motorola.MackinawCPS.CoreFeatures.Switches.ConventionalSwitchTableInnerSection conventionalSwitchTableInnerSection;
				for (;;)
				{
					IL_28:
					num = (short)506731542;
					short num3 = num;
					num = (short)1664818198;
					switch ((num3 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						break;
					default:
						num = (short)158859264;
						if (num != 0)
						{
						}
						switch (num2)
						{
						case 0:
							goto IL_247;
						case 1:
							if (num4 == 0)
							{
								num = (short)1153302530;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							goto IL_15B;
						case 2:
							num = (short)1882062851;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 3:
							if (global::ConstraintHelper.UtilityMack.IsMobile())
							{
								num = (short)863698949;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							task.AddTask(new global::AcpBusinessLayer.UndoRedo.ModifyDataTask<int>(switches.ConventionalSwitches.SwitchConventionalSwitchesPosition1_A7734, value));
							num = (short)963444746;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 4:
							num = (short)1896742921;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 5:
						{
							global::System.Collections.Generic.IEnumerator<global::AcpBusinessLayer.FeatureNode> enumerator = trunkingSwitchTableInnerRecset.GetEnumerator();
							num = (short)845217793;
							if (num != 0)
							{
							}
							num = (short)2122842119;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						case 6:
							task.AddTask(new global::AcpBusinessLayer.UndoRedo.ModifyDataTask<int>(switches.ConventionalSwitches.SwitchConventionalSwitchesPosition3_A7737, value));
							num = (short)1094647808;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 7:
							try
							{
								num = (short)1483800577;
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
											num = (short)173670402;
											num2 = (int)((global::System.IntPtr)num);
											continue;
										}
										global::AcpCommonLib.IAcpFeatureNode acpFeatureNode = enumerator.Current;
										num = (short)867041284;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									case 1:
										switch (0)
										{
										case 0:
											goto IL_337;
										}
										continue;
									case 2:
										num = (short)1249968131;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									case 3:
										goto IL_437;
									case 4:
									{
										global::AcpCommonLib.IAcpFeatureNode acpFeatureNode;
										if ((acpFeatureNode.Parent as global::AcpBusinessLayer.Recordset).IndexOf(acpFeatureNode) == 0)
										{
											num = (short)346882054;
											num2 = (int)((global::System.IntPtr)num);
											continue;
										}
										break;
									}
									case 6:
									{
										task.AddTask(new global::AcpBusinessLayer.UndoRedo.ModifyDataTask<int>(conventionalSwitchTableInnerSection.RefRadioWide.Features.SwitchConventionalSwitchesPosition1_A12643, value));
										global::AcpCommonLib.IAcpFeatureNode acpFeatureNode;
										task.AddTask(new global::AcpBusinessLayer.UndoRedo.ModifyDataTask<int>((acpFeatureNode[10084] as global::Motorola.MackinawCPS.CoreFeatures.Switches.TrunkingSwitchTableInnerSection).SwitchTrunkingSwitchTablePosition1Feature_A21004, value));
										num = (short)1562574853;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									}
									IL_383:
									num = (short)1769472000;
									num2 = (int)((global::System.IntPtr)num);
									continue;
									IL_337:
									goto IL_383;
								}
								IL_437:
								goto IL_15B;
							}
							finally
							{
								num = (short)493944832;
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
											goto IL_46F;
										}
										continue;
									case 1:
										goto IL_4A7;
									case 2:
										enumerator.Dispose();
										num = (short)279773185;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									IL_46F:
									if (enumerator == null)
									{
										break;
									}
									num = (short)1723400194;
									num2 = (int)((global::System.IntPtr)num);
								}
								IL_4A7:;
							}
							return;
						case 8:
							if (num4 == 3)
							{
								num = (short)1759379460;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							return;
						case 9:
							goto IL_2CE;
						case 10:
							goto IL_15B;
						}
						goto IL_A5;
						IL_15B:
						num = (short)1387528200;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					IL_2CE:
					if (!global::ConstraintHelper.UtilityMack.IsPortable())
					{
						return;
					}
					num = (short)861536262;
					num2 = (int)((global::System.IntPtr)num);
				}
				IL_247:
				num = (short)1819213824;
				short num5 = num;
				return;
				IL_A5:
				conventionalSwitchTableInnerSection = (self as global::Motorola.MackinawCPS.CoreFeatures.Switches.ConventionalSwitchTableInnerSection);
				switches = (self.ParentRecset.ParentSection.Parent as global::Motorola.MackinawCPS.CoreFeatures.Switches.Switches);
				global::AcpBusinessLayer.AcpListField switchConventionalSwitchTablePosition1Feature_A = conventionalSwitchTableInnerSection.SwitchConventionalSwitchTablePosition1Feature_A19655;
				trunkingSwitchTableInnerRecset = ((global::AcpCommonLib.FeatureManager.GetFeature(2038) as global::Motorola.MackinawCPS.CoreFeatures.Switches.SwitchesRecset)[0][10083].EmbeddedRecset as global::Motorola.MackinawCPS.CoreFeatures.Switches.TrunkingSwitchTableInnerRecset);
				global::AcpCommonLib.IAcpFeatureNode parent = switchConventionalSwitchTablePosition1Feature_A.Parent.Parent;
				num4 = (parent.Parent as global::AcpBusinessLayer.Recordset).IndexOf(parent);
				value = switchConventionalSwitchTablePosition1Feature_A.Value;
				num = (short)1838022657;
				num2 = (int)((global::System.IntPtr)num);
				goto IL_28;
			}
			}
		}

		// Token: 0x060073BA RID: 29626 RVA: 0x0068372C File Offset: 0x0068192C
		internal static void SyncPositionBInCnvSwitchTable(global::AcpCommonLib.IAcpFeatureSection self, global::AcpCommonLib.UndoRedo.ContainerTask task)
		{
			short num = (short)1716453376;
			int num2 = (int)num;
			switch (num2)
			{
			default:
			{
				switch (0)
				{
				case 0:
					goto IL_6B;
				}
				global::Motorola.MackinawCPS.CoreFeatures.Switches.TrunkingSwitchTableInnerRecset trunkingSwitchTableInnerRecset;
				int num3;
				int value;
				global::Motorola.MackinawCPS.CoreFeatures.Switches.Switches switches;
				for (;;)
				{
					IL_28:
					switch (num2)
					{
					case 0:
						num = (short)1575288833;
						if (num != 0)
						{
						}
						if (global::ConstraintHelper.UtilityMack.IsPortable())
						{
							num = (short)981139470;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return;
					case 1:
					{
						global::System.Collections.Generic.IEnumerator<global::AcpBusinessLayer.FeatureNode> enumerator = trunkingSwitchTableInnerRecset.GetEnumerator();
						num = (short)851902472;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 2:
						num = (short)776994826;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 3:
						if (num3 == 3)
						{
							num = (short)2013265932;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return;
					case 4:
						if (global::ConstraintHelper.UtilityMack.IsMobile())
						{
							num = (short)634454017;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_167;
					case 5:
					{
						if (num3 != 0)
						{
							goto IL_4B7;
						}
						num = (short)429880533;
						short num4 = num;
						num = (short)286422229;
						switch ((num4 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_4D0;
						default:
							num = (short)985923584;
							if (num != 0)
							{
							}
							num = (short)1888026626;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						break;
					}
					case 6:
						goto IL_4D0;
					case 7:
						return;
					case 8:
						try
						{
							num = (short)482213889;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								switch (num2)
								{
								case 0:
								{
									global::AcpCommonLib.IAcpFeatureNode acpFeatureNode;
									if ((acpFeatureNode.Parent as global::AcpBusinessLayer.Recordset).IndexOf(acpFeatureNode) == 1)
									{
										num = (short)32505858;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									break;
								}
								case 1:
									switch (0)
									{
									case 0:
										goto IL_1E9;
									}
									continue;
								case 2:
								{
									global::AcpCommonLib.IAcpFeatureNode acpFeatureNode;
									task.AddTask(new global::AcpBusinessLayer.UndoRedo.ModifyDataTask<int>((acpFeatureNode[10084] as global::Motorola.MackinawCPS.CoreFeatures.Switches.TrunkingSwitchTableInnerSection).SwitchTrunkingSwitchTablePosition2Feature_A21005, value));
									num = (short)476315653;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 3:
									goto IL_2CE;
								case 4:
								{
									global::System.Collections.Generic.IEnumerator<global::AcpBusinessLayer.FeatureNode> enumerator;
									if (!enumerator.MoveNext())
									{
										num = (short)824049670;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									global::AcpCommonLib.IAcpFeatureNode acpFeatureNode = enumerator.Current;
									num = (short)1593769984;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 6:
									num = (short)384368643;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								IL_1EB:
								num = (short)1778909188;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								IL_1E9:
								goto IL_1EB;
							}
							IL_2CE:
							goto IL_167;
						}
						finally
						{
							num = (short)1392771072;
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
										goto IL_305;
									}
									continue;
								case 1:
									goto IL_33D;
								case 2:
									enumerator.Dispose();
									num = (short)802357249;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								IL_305:
								if (enumerator == null)
								{
									break;
								}
								num = (short)414580738;
								num2 = (int)((global::System.IntPtr)num);
							}
							IL_33D:;
						}
						goto IL_340;
					case 9:
						goto IL_4B7;
					case 10:
						if (global::ConstraintHelper.UtilityMack.IsPortable())
						{
							num = (short)1033699339;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_4B7;
					case 11:
						goto IL_340;
					case 12:
						num = (short)1452277760;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 13:
					{
						num = (short)741801984;
						short num5 = num;
						num = (short)1410400260;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 14:
						task.AddTask(new global::AcpBusinessLayer.UndoRedo.ModifyDataTask<int>(switches.ConventionalSwitches.SwitchConventionalSwitchesPosition4_A21530, value));
						num = (short)531628039;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_6B;
					IL_167:
					num = (short)30015491;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_4D0:
					if (num3 == 1)
					{
						num = (short)1064501261;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_167;
					IL_340:
					task.AddTask(new global::AcpBusinessLayer.UndoRedo.ModifyDataTask<int>(switches.ConventionalSwitches.SwitchConventionalSwitchesPosition2_A7735, value));
					num = (short)298385417;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_4B7:
					num = (short)687931398;
					num2 = (int)((global::System.IntPtr)num);
				}
				return;
				IL_6B:
				global::Motorola.MackinawCPS.CoreFeatures.Switches.ConventionalSwitchTableInnerSection conventionalSwitchTableInnerSection = self as global::Motorola.MackinawCPS.CoreFeatures.Switches.ConventionalSwitchTableInnerSection;
				switches = (self.ParentRecset.ParentSection.Parent as global::Motorola.MackinawCPS.CoreFeatures.Switches.Switches);
				global::AcpBusinessLayer.AcpListField switchConventionalSwitchTablePosition2Feature_A = conventionalSwitchTableInnerSection.SwitchConventionalSwitchTablePosition2Feature_A19656;
				trunkingSwitchTableInnerRecset = ((global::AcpCommonLib.FeatureManager.GetFeature(2038) as global::Motorola.MackinawCPS.CoreFeatures.Switches.SwitchesRecset)[0][10083].EmbeddedRecset as global::Motorola.MackinawCPS.CoreFeatures.Switches.TrunkingSwitchTableInnerRecset);
				global::AcpCommonLib.IAcpFeatureNode parent = switchConventionalSwitchTablePosition2Feature_A.Parent.Parent;
				num3 = (parent.Parent as global::AcpBusinessLayer.Recordset).IndexOf(parent);
				value = switchConventionalSwitchTablePosition2Feature_A.Value;
				num = (short)201261061;
				num2 = (int)((global::System.IntPtr)num);
				goto IL_28;
			}
			}
		}

		// Token: 0x060073BB RID: 29627 RVA: 0x00683C70 File Offset: 0x00681E70
		internal static void SyncPositionCInCnvSwitchTable(global::AcpCommonLib.IAcpFeatureSection self, global::AcpCommonLib.UndoRedo.ContainerTask task)
		{
			short num = (short)1118765056;
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
				global::AcpCommonLib.IAcpFeatureNode parent;
				global::AcpBusinessLayer.AcpListField switchConventionalSwitchTablePosition3Feature_A;
				global::Motorola.MackinawCPS.CoreFeatures.Switches.Switches switches;
				for (;;)
				{
					IL_28:
					int value;
					switch (num2)
					{
					case 0:
					{
						int num3 = (parent.Parent as global::AcpBusinessLayer.Recordset).IndexOf(parent);
						value = switchConventionalSwitchTablePosition3Feature_A.Value;
						if (num3 == 3)
						{
							num = (short)928841728;
							short num4 = num;
							num = (short)294322177;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_134;
					}
					case 1:
						goto IL_103;
					case 2:
						goto IL_134;
					}
					goto IL_3B;
					IL_103:
					task.AddTask(new global::AcpBusinessLayer.UndoRedo.ModifyDataTask<int>(switches.ConventionalSwitches.SwitchConventionalSwitchesPosition5_A21531, value));
					num = (short)1196425218;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_134:
					num = (short)154230776;
					short num5 = num;
					num = (short)611606520;
					switch ((num5 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_103;
					default:
						goto IL_169;
					}
				}
				IL_169:
				num = (short)490340352;
				if (num != 0)
				{
				}
				return;
				IL_3B:
				num = (short)819920897;
				if (num != 0)
				{
				}
				global::Motorola.MackinawCPS.CoreFeatures.Switches.ConventionalSwitchTableInnerSection conventionalSwitchTableInnerSection = self as global::Motorola.MackinawCPS.CoreFeatures.Switches.ConventionalSwitchTableInnerSection;
				switches = (self.ParentRecset.ParentSection.Parent as global::Motorola.MackinawCPS.CoreFeatures.Switches.Switches);
				switchConventionalSwitchTablePosition3Feature_A = conventionalSwitchTableInnerSection.SwitchConventionalSwitchTablePosition3Feature_A19657;
				parent = switchConventionalSwitchTablePosition3Feature_A.Parent.Parent;
				num = (short)1024393216;
				num2 = (int)((global::System.IntPtr)num);
				goto IL_28;
			}
			}
		}

		// Token: 0x060073BC RID: 29628 RVA: 0x00683DFC File Offset: 0x00681FFC
		internal static void SyncPositionAInTrkSwitchTable(global::AcpCommonLib.IAcpFeatureSection self, global::AcpCommonLib.UndoRedo.ContainerTask task)
		{
			short num = (short)2061893632;
			int num2 = (int)num;
			switch (num2)
			{
			default:
			{
				switch (0)
				{
				case 0:
					goto IL_5A;
				}
				global::Motorola.MackinawCPS.CoreFeatures.Switches.Switches switches;
				int value;
				int num3;
				global::Motorola.MackinawCPS.CoreFeatures.Switches.TrunkingSwitchTableInnerSection trunkingSwitchTableInnerSection;
				global::Motorola.MackinawCPS.CoreFeatures.Switches.ConventionalSwitchTableInnerRecset conventionalSwitchTableInnerRecset;
				for (;;)
				{
					IL_27:
					switch (num2)
					{
					case 0:
						task.AddTask(new global::AcpBusinessLayer.UndoRedo.ModifyDataTask<int>(switches.TrunkingSwitches.SwitchTrunkingSwitchesPosition3_A9468, value));
						num = (short)254869513;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 1:
						if (num3 == 0)
						{
							num = (short)1468399623;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_10E;
					case 2:
						if (global::ConstraintHelper.UtilityMack.IsMobile())
						{
							num = (short)113639434;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						task.AddTask(new global::AcpBusinessLayer.UndoRedo.ModifyDataTask<int>(switches.TrunkingSwitches.SwitchTrunkingSwitchesPosition1_A9466, value));
						goto IL_1D6;
					case 3:
						try
						{
							num = (short)1205075971;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								switch (num2)
								{
								case 0:
								{
									global::AcpCommonLib.IAcpFeatureNode acpFeatureNode;
									if ((acpFeatureNode.Parent as global::AcpBusinessLayer.Recordset).IndexOf(acpFeatureNode) == 0)
									{
										num = (short)1415249924;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									break;
								}
								case 1:
								{
									global::System.Collections.Generic.IEnumerator<global::AcpBusinessLayer.FeatureNode> enumerator;
									if (!enumerator.MoveNext())
									{
										num = (short)2118123525;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									global::AcpCommonLib.IAcpFeatureNode acpFeatureNode = enumerator.Current;
									num = (short)1178075136;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 2:
									goto IL_437;
								case 3:
									switch (0)
									{
									case 0:
										goto IL_337;
									}
									continue;
								case 4:
								{
									task.AddTask(new global::AcpBusinessLayer.UndoRedo.ModifyDataTask<int>(trunkingSwitchTableInnerSection.RefRadioWide.Features.SwitchConventionalSwitchesPosition1_A12643, value));
									global::AcpCommonLib.IAcpFeatureNode acpFeatureNode;
									task.AddTask(new global::AcpBusinessLayer.UndoRedo.ModifyDataTask<int>((acpFeatureNode[10086] as global::Motorola.MackinawCPS.CoreFeatures.Switches.ConventionalSwitchTableInnerSection).SwitchConventionalSwitchTablePosition1Feature_A19655, value));
									num = (short)184352774;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 5:
									num = (short)1576599554;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								IL_384:
								num = (short)464388097;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								IL_337:
								goto IL_384;
							}
							IL_437:
							goto IL_10E;
						}
						finally
						{
							num = (short)21954560;
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
										goto IL_46F;
									}
									continue;
								case 1:
									enumerator.Dispose();
									num = (short)1161428994;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 2:
									goto IL_4A6;
								}
								IL_46F:
								if (enumerator == null)
								{
									break;
								}
								num = (short)1931018241;
								num2 = (int)((global::System.IntPtr)num);
							}
							IL_4A6:;
						}
						return;
					case 4:
						goto IL_10E;
					case 5:
					{
						num = (short)1596850176;
						short num4 = num;
						if (num3 == 3)
						{
							num = (short)1214185480;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return;
					}
					case 6:
						if (global::ConstraintHelper.UtilityMack.IsPortable())
						{
							num = (short)1176895488;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return;
					case 7:
						num = (short)1900019714;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 8:
						num = (short)2095841286;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 9:
						goto IL_24A;
					case 10:
					{
						global::System.Collections.Generic.IEnumerator<global::AcpBusinessLayer.FeatureNode> enumerator = conventionalSwitchTableInnerRecset.GetEnumerator();
						num = (short)595263491;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					}
					goto IL_5A;
					IL_10E:
					num = (short)759503509;
					short num5 = num;
					num = (short)957684373;
					switch ((num5 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						IL_1D6:
						num = (short)26083332;
						num2 = (int)((global::System.IntPtr)num);
						break;
					default:
						num = (short)739704832;
						if (num != 0)
						{
						}
						num = (short)1591279621;
						num2 = (int)((global::System.IntPtr)num);
						break;
					}
				}
				IL_24A:
				num = (short)262733825;
				if (num != 0)
				{
				}
				return;
				IL_5A:
				trunkingSwitchTableInnerSection = (self as global::Motorola.MackinawCPS.CoreFeatures.Switches.TrunkingSwitchTableInnerSection);
				switches = (self.ParentRecset.ParentSection.Parent as global::Motorola.MackinawCPS.CoreFeatures.Switches.Switches);
				global::AcpBusinessLayer.AcpListField switchTrunkingSwitchTablePosition1Feature_A = trunkingSwitchTableInnerSection.SwitchTrunkingSwitchTablePosition1Feature_A21004;
				conventionalSwitchTableInnerRecset = ((global::AcpCommonLib.FeatureManager.GetFeature(2038) as global::Motorola.MackinawCPS.CoreFeatures.Switches.SwitchesRecset)[0][10085].EmbeddedRecset as global::Motorola.MackinawCPS.CoreFeatures.Switches.ConventionalSwitchTableInnerRecset);
				global::AcpCommonLib.IAcpFeatureNode parent = switchTrunkingSwitchTablePosition1Feature_A.Parent.Parent;
				num3 = (parent.Parent as global::AcpBusinessLayer.Recordset).IndexOf(parent);
				value = switchTrunkingSwitchTablePosition1Feature_A.Value;
				num = (short)24117249;
				num2 = (int)((global::System.IntPtr)num);
				goto IL_27;
			}
			}
		}

		// Token: 0x060073BD RID: 29629 RVA: 0x006842D0 File Offset: 0x006824D0
		internal static void SyncPositionBInTrkSwitchTable(global::AcpCommonLib.IAcpFeatureSection self, global::AcpCommonLib.UndoRedo.ContainerTask task)
		{
			short num = (short)1653538816;
			int num2 = (int)num;
			switch (num2)
			{
			default:
			{
				int num3;
				int value;
				global::Motorola.MackinawCPS.CoreFeatures.Switches.Switches switches;
				global::Motorola.MackinawCPS.CoreFeatures.Switches.ConventionalSwitchTableInnerRecset conventionalSwitchTableInnerRecset;
				switch (0)
				{
				case 0:
					break;
				default:
					for (;;)
					{
						IL_28:
						switch (num2)
						{
						case 0:
							goto IL_317;
						case 1:
							if (num3 == 3)
							{
								num = (short)498794497;
								if (num != 0)
								{
								}
								num = (short)1013710854;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							return;
						case 2:
							try
							{
								num = (short)308477955;
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
											num = (short)370212868;
											num2 = (int)((global::System.IntPtr)num);
											continue;
										}
										global::AcpCommonLib.IAcpFeatureNode acpFeatureNode = enumerator.Current;
										num = (short)1290272769;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									case 1:
									{
										global::AcpCommonLib.IAcpFeatureNode acpFeatureNode;
										if ((acpFeatureNode.Parent as global::AcpBusinessLayer.Recordset).IndexOf(acpFeatureNode) == 1)
										{
											num = (short)1592983557;
											num2 = (int)((global::System.IntPtr)num);
											continue;
										}
										break;
									}
									case 2:
										goto IL_2A5;
									case 3:
										switch (0)
										{
										case 0:
											goto IL_1C1;
										}
										continue;
									case 4:
										num = (short)688914434;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									case 5:
									{
										global::AcpCommonLib.IAcpFeatureNode acpFeatureNode;
										task.AddTask(new global::AcpBusinessLayer.UndoRedo.ModifyDataTask<int>((acpFeatureNode[10086] as global::Motorola.MackinawCPS.CoreFeatures.Switches.ConventionalSwitchTableInnerSection).SwitchConventionalSwitchTablePosition2Feature_A19656, value));
										num = (short)77463558;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									}
									IL_1C3:
									num = (short)477036544;
									num2 = (int)((global::System.IntPtr)num);
									continue;
									IL_1C1:
									goto IL_1C3;
								}
								IL_2A5:
								goto IL_11A;
							}
							finally
							{
								num = (short)1008467968;
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
											goto IL_2DD;
										}
										continue;
									case 1:
										enumerator.Dispose();
										num = (short)959512578;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									case 2:
										goto IL_314;
									}
									IL_2DD:
									if (enumerator == null)
									{
										break;
									}
									num = (short)334430209;
									num2 = (int)((global::System.IntPtr)num);
								}
								IL_314:;
							}
							goto IL_317;
						case 3:
							if (num3 == 1)
							{
								num = (short)679804938;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							goto IL_11A;
						case 4:
							task.AddTask(new global::AcpBusinessLayer.UndoRedo.ModifyDataTask<int>(switches.TrunkingSwitches.SwitchTrunkingSwitchesPosition4_A21534, value));
							num = (short)573112333;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 5:
							if (num3 == 0)
							{
								num = (short)1290403851;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							goto IL_46C;
						case 6:
						{
							num = (short)1934819328;
							short num4 = num;
							num = (short)766967820;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						case 7:
							if (global::ConstraintHelper.UtilityMack.IsMobile())
							{
								num = (short)670302222;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							goto IL_11A;
						case 8:
							if (global::ConstraintHelper.UtilityMack.IsPortable())
							{
								num = (short)205717504;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							goto IL_46C;
						case 9:
							goto IL_46C;
						case 10:
						{
							num = (short)2138050006;
							short num5 = num;
							num = (short)273354198;
							switch ((num5 == num) ? 1 : 0)
							{
							case 0:
							case 2:
								goto IL_DE;
							default:
								num = (short)1717633024;
								if (num != 0)
								{
								}
								num = (short)1118240775;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							break;
						}
						case 11:
							num = (short)2060779528;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 12:
							if (global::ConstraintHelper.UtilityMack.IsPortable())
							{
								num = (short)1115357188;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							return;
						case 13:
							return;
						case 14:
						{
							global::System.Collections.Generic.IEnumerator<global::AcpBusinessLayer.FeatureNode> enumerator = conventionalSwitchTableInnerRecset.GetEnumerator();
							num = (short)565575682;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						}
						goto IL_6B;
						IL_11A:
						num = (short)1665728513;
						num2 = (int)((global::System.IntPtr)num);
						continue;
						IL_317:
						task.AddTask(new global::AcpBusinessLayer.UndoRedo.ModifyDataTask<int>(switches.TrunkingSwitches.SwitchTrunkingSwitchesPosition2_A9467, value));
						num = (short)1078788105;
						num2 = (int)((global::System.IntPtr)num);
						continue;
						IL_46C:
						num = (short)1130496003;
						num2 = (int)((global::System.IntPtr)num);
					}
					return;
				}
				IL_6B:
				global::Motorola.MackinawCPS.CoreFeatures.Switches.TrunkingSwitchTableInnerSection trunkingSwitchTableInnerSection = self as global::Motorola.MackinawCPS.CoreFeatures.Switches.TrunkingSwitchTableInnerSection;
				switches = (self.ParentRecset.ParentSection.Parent as global::Motorola.MackinawCPS.CoreFeatures.Switches.Switches);
				global::AcpBusinessLayer.AcpListField switchTrunkingSwitchTablePosition2Feature_A = trunkingSwitchTableInnerSection.SwitchTrunkingSwitchTablePosition2Feature_A21005;
				conventionalSwitchTableInnerRecset = ((global::AcpCommonLib.FeatureManager.GetFeature(2038) as global::Motorola.MackinawCPS.CoreFeatures.Switches.SwitchesRecset)[0][10085].EmbeddedRecset as global::Motorola.MackinawCPS.CoreFeatures.Switches.ConventionalSwitchTableInnerRecset);
				global::AcpCommonLib.IAcpFeatureNode parent = switchTrunkingSwitchTablePosition2Feature_A.Parent.Parent;
				num3 = (parent.Parent as global::AcpBusinessLayer.Recordset).IndexOf(parent);
				value = switchTrunkingSwitchTablePosition2Feature_A.Value;
				IL_DE:
				num = (short)869531653;
				num2 = (int)((global::System.IntPtr)num);
				goto IL_28;
			}
			}
		}

		// Token: 0x060073BE RID: 29630 RVA: 0x00684814 File Offset: 0x00682A14
		internal static void SyncPositionCInTrkSwitchTable(global::AcpCommonLib.IAcpFeatureSection self, global::AcpCommonLib.UndoRedo.ContainerTask task)
		{
			short num = (short)1612840960;
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
				global::AcpCommonLib.IAcpFeatureNode parent;
				global::AcpBusinessLayer.AcpListField switchTrunkingSwitchTablePosition3Feature_A;
				global::Motorola.MackinawCPS.CoreFeatures.Switches.Switches switches;
				for (;;)
				{
					IL_28:
					int value;
					switch (num2)
					{
					case 0:
					{
						int num3 = (parent.Parent as global::AcpBusinessLayer.Recordset).IndexOf(parent);
						value = switchTrunkingSwitchTablePosition3Feature_A.Value;
						if (num3 == 3)
						{
							num = (short)1056112640;
							short num4 = num;
							num = (short)2129461249;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_136;
					}
					case 1:
						goto IL_105;
					case 2:
						goto IL_136;
					}
					goto IL_3B;
					IL_105:
					task.AddTask(new global::AcpBusinessLayer.UndoRedo.ModifyDataTask<int>(switches.TrunkingSwitches.SwitchTrunkingSwitchesPosition5_A21535, value));
					num = (short)1408434178;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_136:
					num = (short)865548861;
					short num5 = num;
					num = (short)1536375357;
					switch ((num5 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_105;
					default:
						goto IL_16A;
					}
				}
				IL_16A:
				num = (short)349372416;
				if (num != 0)
				{
				}
				return;
				IL_3B:
				num = (short)693567489;
				if (num != 0)
				{
				}
				global::Motorola.MackinawCPS.CoreFeatures.Switches.TrunkingSwitchTableInnerSection trunkingSwitchTableInnerSection = self as global::Motorola.MackinawCPS.CoreFeatures.Switches.TrunkingSwitchTableInnerSection;
				switches = (self.ParentRecset.ParentSection.Parent as global::Motorola.MackinawCPS.CoreFeatures.Switches.Switches);
				switchTrunkingSwitchTablePosition3Feature_A = trunkingSwitchTableInnerSection.SwitchTrunkingSwitchTablePosition3Feature_A21006;
				parent = switchTrunkingSwitchTablePosition3Feature_A.Parent.Parent;
				num = (short)1075052544;
				num2 = (int)((global::System.IntPtr)num);
				goto IL_28;
			}
			}
		}

		// Token: 0x060073BF RID: 29631 RVA: 0x006849A0 File Offset: 0x00682BA0
		internal static void ConSyncRotaryControlFeature(global::AcpCommonLib.IAcpFeatureSection self, global::AcpCommonLib.UndoRedo.ContainerTask task)
		{
			int a_ = 2;
			short num = (short)442564608;
			int num2 = (int)num;
			switch (num2)
			{
			default:
			{
				switch (0)
				{
				case 0:
					goto IL_88;
				}
				global::AcpBusinessLayer.AcpListField switchConventionalSwitchesPosition1_A;
				int num3;
				global::AcpBusinessLayer.AcpField<bool> radWideLabtoolChannelSelectorOnSwitch_A;
				global::System.Collections.Generic.IEnumerator<global::AcpBusinessLayer.FeatureNode> enumerator;
				global::AcpBusinessLayer.AcpField<bool> radWideLabtoolZoneSelectorOnSwitch_A;
				global::AcpBusinessLayer.AcpListField switchConventionalSwitchesPosition3_A;
				for (;;)
				{
					IL_31:
					switch (num2)
					{
					case 0:
						goto IL_16A;
					case 1:
						num = (short)1039269905;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 2:
						num = (short)2108424211;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 3:
						goto IL_1A9;
					case 4:
						num = (short)1449328648;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 5:
						goto IL_266;
					case 6:
						if (!global::ConstraintHelper.UtilityMack.IsWorldWidePro)
						{
							num = (short)1908080641;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return;
					case 7:
						if (switchConventionalSwitchesPosition1_A.Value != 30)
						{
							num = (short)54788110;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_5E0;
					case 8:
						if (num3 == 29)
						{
							num = (short)1300496400;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						task.AddTask(new global::AcpBusinessLayer.UndoRedo.ModifyDataTask<bool>(radWideLabtoolChannelSelectorOnSwitch_A, false));
						num = (short)163774473;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 9:
						return;
					case 10:
						try
						{
							num = (short)1161494531;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								switch (num2)
								{
								case 0:
								{
									global::AcpCommonLib.IAcpFeatureNode acpFeatureNode;
									if ((acpFeatureNode.Parent as global::AcpBusinessLayer.Recordset).IndexOf(acpFeatureNode) == 0)
									{
										num = (short)995295236;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									break;
								}
								case 1:
									goto IL_512;
								case 2:
									goto IL_56E;
								case 3:
									switch (0)
									{
									case 0:
										goto IL_48D;
									}
									continue;
								case 4:
								{
									global::AcpCommonLib.IAcpFeatureNode acpFeatureNode;
									num3 = (acpFeatureNode[10082] as global::Motorola.MackinawCPS.CoreFeatures.Switches.RotaryControlInnerSection).SwitchGeneralRotaryControl_A8984.Value;
									num = (short)1813118977;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 5:
								{
									if (!enumerator.MoveNext())
									{
										num = (short)1410859014;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									global::AcpCommonLib.IAcpFeatureNode acpFeatureNode = enumerator.Current;
									num = (short)1720582144;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 6:
									num = (short)123469826;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								IL_517:
								num = (short)7602181;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								IL_48D:
								goto IL_517;
							}
							IL_512:
							IL_56E:
							goto IL_1D3;
						}
						finally
						{
							num = (short)87425024;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								switch (num2)
								{
								case 0:
									switch (0)
									{
									case 0:
										goto IL_5A5;
									}
									continue;
								case 1:
									enumerator.Dispose();
									num = (short)1496514562;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 2:
									goto IL_5DD;
								}
								IL_5A5:
								if (enumerator == null)
								{
									break;
								}
								num = (short)436142081;
								num2 = (int)((global::System.IntPtr)num);
							}
							IL_5DD:;
						}
						goto IL_5E0;
						IL_1D3:
						num = (short)1924399111;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 11:
						num = (short)1426063372;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 12:
					{
						if (num3 == 30)
						{
							num = (short)1037631503;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)1567338573;
						short num4 = num;
						num = (short)68857933;
						switch ((num4 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_1A9;
						default:
						{
							num = (short)1160183808;
							if (num != 0)
							{
							}
							num = (short)1019609088;
							short num5 = num;
							task.AddTask(new global::AcpBusinessLayer.UndoRedo.ModifyDataTask<bool>(radWideLabtoolZoneSelectorOnSwitch_A, false));
							num = (short)1308295181;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						}
						break;
					}
					case 13:
						goto IL_16A;
					case 14:
						num = (short)1106706450;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 15:
						goto IL_5E0;
					case 16:
						goto IL_26B;
					case 17:
						if (global::ConstraintHelper.UtilityMack.ProductModelId != global::AllFeatures.CodeplugGuid.b("苂闄鿆靖﯊﷌ￎ", a_))
						{
							num = (short)2057633797;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return;
					case 18:
						if (switchConventionalSwitchesPosition3_A.Value != 30)
						{
							num = (short)1720057867;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_5E0;
					case 19:
						if (switchConventionalSwitchesPosition3_A.Value != 29)
						{
							num = (short)1646985220;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_26B;
					}
					goto IL_88;
					IL_16A:
					num = (short)644743169;
					if (num != 0)
					{
					}
					num = (short)1221984259;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_1A9:
					if (switchConventionalSwitchesPosition1_A.Value != 29)
					{
						num = (short)820051970;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					IL_26B:
					num = (short)1065746438;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_5E0:
					task.AddTask(new global::AcpBusinessLayer.UndoRedo.ModifyDataTask<bool>(radWideLabtoolZoneSelectorOnSwitch_A, true));
					num = (short)235470848;
					num2 = (int)((global::System.IntPtr)num);
				}
				IL_266:
				task.AddTask(new global::AcpBusinessLayer.UndoRedo.ModifyDataTask<bool>(radWideLabtoolChannelSelectorOnSwitch_A, true));
				return;
				IL_88:
				global::Motorola.MackinawCPS.CoreFeatures.Switches.RotaryControlInnerSection rotaryControlInnerSection = self as global::Motorola.MackinawCPS.CoreFeatures.Switches.RotaryControlInnerSection;
				global::Motorola.MackinawCPS.CoreFeatures.Switches.Switches switches = self.ParentRecset.ParentSection.Parent as global::Motorola.MackinawCPS.CoreFeatures.Switches.Switches;
				switchConventionalSwitchesPosition1_A = switches.ConventionalSwitches.SwitchConventionalSwitchesPosition1_A7734;
				switchConventionalSwitchesPosition3_A = switches.ConventionalSwitches.SwitchConventionalSwitchesPosition3_A7737;
				radWideLabtoolZoneSelectorOnSwitch_A = rotaryControlInnerSection.RefRadioWide.Labtool.RadWideLabtoolZoneSelectorOnSwitch_A19550;
				radWideLabtoolChannelSelectorOnSwitch_A = rotaryControlInnerSection.RefRadioWide.Labtool.RadWideLabtoolChannelSelectorOnSwitch_A19551;
				global::System.Collections.ObjectModel.Collection<global::AcpBusinessLayer.FeatureNode> collection = (global::AcpCommonLib.FeatureManager.GetFeature(2038) as global::Motorola.MackinawCPS.CoreFeatures.Switches.SwitchesRecset)[0][10081].EmbeddedRecset as global::Motorola.MackinawCPS.CoreFeatures.Switches.RotaryControlInnerRecset;
				num3 = 0;
				enumerator = collection.GetEnumerator();
				num = (short)500826122;
				num2 = (int)((global::System.IntPtr)num);
				goto IL_31;
			}
			}
		}

		// Token: 0x060073C0 RID: 29632 RVA: 0x00684FD4 File Offset: 0x006831D4
		internal static bool conSetEditabilityConcentricSwitches(global::AcpCommonLib.IAcpFeatureSection self)
		{
			switch (0)
			{
			case 0:
				goto IL_83;
			}
			short num;
			int num3;
			global::AcpBusinessLayer.AcpListField switchConventionalSwitchesPosition1_A;
			for (;;)
			{
				IL_0A:
				num = (short)388456631;
				short num2 = num;
				num = (short)1845518519;
				switch ((num2 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					break;
				default:
					num = (short)1149960192;
					if (num != 0)
					{
					}
					switch (num3)
					{
					case 0:
						num = (short)1088094209;
						if (num != 0)
						{
						}
						if (switchConventionalSwitchesPosition1_A.Value != 30)
						{
							num = (short)1393885190;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						}
						return false;
					case 1:
						if (switchConventionalSwitchesPosition1_A.Value != 27)
						{
							num = (short)1190068229;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						}
						return false;
					case 2:
						if (switchConventionalSwitchesPosition1_A.Value != 81)
						{
							num = (short)1798897667;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						}
						return false;
					case 3:
						num = (short)1461256193;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					case 4:
						if (switchConventionalSwitchesPosition1_A.Value == 274)
						{
							num = (short)626524167;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						}
						return true;
					case 5:
						goto IL_1A8;
					case 6:
					{
						num = (short)1242628096;
						short num4 = num;
						num = (short)971964424;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 7:
						return false;
					case 8:
						if (switchConventionalSwitchesPosition1_A.Value != 29)
						{
							num = (short)751632393;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						}
						return false;
					case 9:
						num = (short)1610219522;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_83;
				}
				IL_1A8:
				num = (short)910491652;
				num3 = (int)((global::System.IntPtr)num);
			}
			return false;
			IL_83:
			switchConventionalSwitchesPosition1_A = (self.Parent as global::Motorola.MackinawCPS.CoreFeatures.Switches.Switches).ConventionalSwitches.SwitchConventionalSwitchesPosition1_A7734;
			num = (short)1119748096;
			num3 = (int)((global::System.IntPtr)num);
			goto IL_0A;
		}

		// Token: 0x060073C1 RID: 29633 RVA: 0x00685208 File Offset: 0x00683408
		internal static bool conSetEditabilityToggleSwitches(global::AcpCommonLib.IAcpFeatureSection self)
		{
			switch (0)
			{
			case 0:
				goto IL_20;
			}
			int num;
			short num2;
			global::AcpBusinessLayer.AcpListField switchConventionalSwitchesPosition3_A;
			for (;;)
			{
				IL_0A:
				switch (num)
				{
				case 0:
					num2 = (short)2068774914;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 1:
					if (switchConventionalSwitchesPosition3_A.Value != 30)
					{
						goto IL_54;
					}
					return false;
				case 2:
				{
					if (switchConventionalSwitchesPosition3_A.Value == 29)
					{
						num2 = (short)1392640001;
						if (num2 != 0)
						{
						}
						num2 = (short)1183186947;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					num2 = (short)961547345;
					short num3 = num2;
					num2 = (short)1193020497;
					switch ((num3 == num2) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_54;
					default:
						goto IL_131;
					}
					break;
				}
				case 3:
					goto IL_F9;
				}
				goto IL_20;
				IL_54:
				num2 = (short)166526976;
				short num4 = num2;
				num2 = (short)817758208;
				num = (int)((global::System.IntPtr)num2);
			}
			return false;
			IL_F9:
			return false;
			IL_131:
			num2 = (short)1588068352;
			if (num2 != 0)
			{
			}
			return true;
			IL_20:
			switchConventionalSwitchesPosition3_A = (self.Parent as global::Motorola.MackinawCPS.CoreFeatures.Switches.Switches).ConventionalSwitches.SwitchConventionalSwitchesPosition3_A7737;
			num2 = (short)2119565313;
			num = (int)((global::System.IntPtr)num2);
			goto IL_0A;
		}

		// Token: 0x060073C2 RID: 29634 RVA: 0x00685360 File Offset: 0x00683560
		internal static bool conValidityRotaryControl(global::AcpCommonLib.IAcpFeatureSection self, int index)
		{
			switch (0)
			{
			case 0:
				goto IL_48;
			}
			int num;
			short num2;
			bool result;
			global::AcpBusinessLayer.AcpListField switchConventionalSwitchesPosition1_A;
			global::AcpBusinessLayer.AcpListField switchConventionalSwitchesPosition3_A;
			for (;;)
			{
				IL_0A:
				bool flag;
				switch (num)
				{
				case 0:
					num2 = (short)541196301;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 1:
					return result;
				case 2:
				{
					num2 = (short)486080512;
					short num3 = num2;
					if (switchConventionalSwitchesPosition1_A.Value != 30)
					{
						num2 = (short)1449263116;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					num2 = (short)153157638;
					num = (int)((global::System.IntPtr)num2);
					continue;
				}
				case 3:
					goto IL_137;
				case 4:
					if (index != 29)
					{
						num2 = (short)679608330;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					num2 = (short)737804297;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 5:
					flag = (switchConventionalSwitchesPosition3_A.Value != 30);
					goto IL_23B;
				case 6:
					flag = false;
					goto IL_23B;
				case 7:
					num2 = (short)416612354;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 8:
					return result;
				case 9:
					if (switchConventionalSwitchesPosition1_A.Value != 29)
					{
						num2 = (short)1424424960;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					num2 = (short)1456209923;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 10:
					num2 = (short)565968907;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 11:
					if (index == 30)
					{
						num2 = (short)1953628167;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					return result;
				case 12:
					num2 = (short)1720582149;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 13:
					goto IL_26D;
				}
				goto IL_48;
				IL_23B:
				result = flag;
				num2 = (short)591134721;
				num = (int)((global::System.IntPtr)num2);
			}
			IL_137:
			bool flag2 = false;
			goto IL_13A;
			IL_48:
			global::Motorola.MackinawCPS.CoreFeatures.Switches.Switches switches = self.ParentRecset.ParentSection.Parent as global::Motorola.MackinawCPS.CoreFeatures.Switches.Switches;
			switchConventionalSwitchesPosition1_A = switches.ConventionalSwitches.SwitchConventionalSwitchesPosition1_A7734;
			switchConventionalSwitchesPosition3_A = switches.ConventionalSwitches.SwitchConventionalSwitchesPosition3_A7737;
			result = true;
			num2 = (short)848697438;
			short num4 = num2;
			num2 = (short)1407522910;
			switch ((num4 == num2) ? 1 : 0)
			{
			case 0:
			case 2:
				IL_26D:
				flag2 = (switchConventionalSwitchesPosition3_A.Value != 29);
				break;
			default:
				num2 = (short)580321281;
				if (num2 != 0)
				{
				}
				num2 = (short)438960128;
				if (num2 != 0)
				{
				}
				num2 = (short)1166540804;
				num = (int)((global::System.IntPtr)num2);
				goto IL_0A;
			}
			IL_13A:
			result = flag2;
			num2 = (short)156631048;
			num = (int)((global::System.IntPtr)num2);
			goto IL_0A;
		}

		// Token: 0x060073C3 RID: 29635 RVA: 0x0068562C File Offset: 0x0068382C
		internal static bool conSetEditabilityCnvTogglePosA(global::AcpCommonLib.IAcpFeatureSection self)
		{
			short num = (short)212343569;
			short num2 = num;
			num = (short)295836433;
			switch ((num2 == num) ? 1 : 0)
			{
			case 0:
			case 2:
				return true;
			case 1:
				break;
			default:
			{
				num = (short)876085248;
				short num3 = num;
				break;
			}
			}
			num = (short)1812004864;
			if (num != 0)
			{
			}
			num = (short)1722875905;
			if (num != 0)
			{
			}
			global::System.Collections.Generic.IEnumerator<global::AcpBusinessLayer.FeatureNode> enumerator = ((global::AcpCommonLib.FeatureManager.GetFeature(2042) as global::Motorola.MackinawCPS.CoreFeatures.Buttons.ButtonsRecset)[0][10091].EmbeddedRecset as global::Motorola.MackinawCPS.CoreFeatures.Buttons.PortableButtonInnerRecset).GetEnumerator();
			bool result;
			try
			{
				num = (short)1423310853;
				int num4 = (int)((global::System.IntPtr)num);
				for (;;)
				{
					switch (num4)
					{
					case 0:
						goto IL_22F;
					case 1:
					{
						global::AcpCommonLib.IAcpFeatureNode acpFeatureNode;
						if ((acpFeatureNode[10092] as global::Motorola.MackinawCPS.CoreFeatures.Buttons.PortableButtonInnerSection).BtnGeneralConventionalFeature_A19544.Value == 214)
						{
							num = (short)1221722120;
							num4 = (int)((global::System.IntPtr)num);
							continue;
						}
						break;
					}
					case 2:
						num = (short)1083637760;
						num4 = (int)((global::System.IntPtr)num);
						continue;
					case 3:
					{
						if (!enumerator.MoveNext())
						{
							num = (short)1532166146;
							num4 = (int)((global::System.IntPtr)num);
							continue;
						}
						global::AcpCommonLib.IAcpFeatureNode acpFeatureNode = enumerator.Current;
						num = (short)1831862278;
						num4 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 4:
						num = (short)1488453633;
						num4 = (int)((global::System.IntPtr)num);
						continue;
					case 5:
						switch (0)
						{
						case 0:
							goto IL_118;
						}
						continue;
					case 6:
					{
						global::AcpCommonLib.IAcpFeatureNode acpFeatureNode;
						if ((acpFeatureNode[10092] as global::Motorola.MackinawCPS.CoreFeatures.Buttons.PortableButtonInnerSection).BtnGeneralConventionalFeature_A19544.Value != 149)
						{
							num = (short)1229258756;
							num4 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_1A5;
					}
					case 7:
						goto IL_1BE;
					case 8:
						goto IL_1A5;
					}
					IL_11A:
					num = (short)299630595;
					num4 = (int)((global::System.IntPtr)num);
					continue;
					IL_118:
					goto IL_11A;
					IL_1A5:
					result = false;
					num = (short)962199559;
					num4 = (int)((global::System.IntPtr)num);
				}
				IL_1BE:
				return result;
				IL_22F:
				return true;
			}
			finally
			{
				num = (short)1011417088;
				int num4 = (int)((global::System.IntPtr)num);
				for (;;)
				{
					switch (num4)
					{
					case 0:
						switch (0)
						{
						case 0:
							goto IL_264;
						}
						continue;
					case 1:
						enumerator.Dispose();
						num = (short)1101922306;
						num4 = (int)((global::System.IntPtr)num);
						continue;
					case 2:
						goto IL_29B;
					}
					IL_264:
					if (enumerator == null)
					{
						break;
					}
					num = (short)1150746625;
					num4 = (int)((global::System.IntPtr)num);
				}
				IL_29B:;
			}
			return result;
		}

		// Token: 0x060073C4 RID: 29636 RVA: 0x006858F4 File Offset: 0x00683AF4
		public static bool conValidityMFKAssignControl(global::AcpCommonLib.IAcpFeatureSection self, int index)
		{
			short num = (short)1138163712;
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
				bool result;
				for (;;)
				{
					IL_28:
					switch (num2)
					{
					case 0:
					{
						int value;
						if (value == 23)
						{
							num = (short)1971847177;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_3D6;
					}
					case 1:
					{
						num = (short)760872960;
						short num3 = num;
						global::AcpCommonLib.IAcpRecordset parentRecset;
						int value = (parentRecset[1] as global::Motorola.MackinawCPS.CoreFeatures.Switches.MFKAssignmentControlInner).MFKAssignmentControlInnerSection.RadErgoControlSwitchsMFKFeatureAssignment_A38514.Value;
						num = (short)912064520;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 2:
						return false;
					case 3:
					{
						global::AcpCommonLib.IAcpRecordset parentRecset;
						if (parentRecset[0] == self.Parent)
						{
							num = (short)1894055937;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)1413349391;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 4:
						goto IL_18F;
					case 5:
					{
						global::AcpCommonLib.IAcpRecordset parentRecset;
						int value2 = (parentRecset[0] as global::Motorola.MackinawCPS.CoreFeatures.Switches.MFKAssignmentControlInner).MFKAssignmentControlInnerSection.RadErgoControlSwitchsMFKFeatureAssignment_A38514.Value;
						num = (short)1805451281;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 6:
					{
						global::AcpCommonLib.IAcpRecordset parentRecset;
						int num4;
						if (num4 >= parentRecset.Count)
						{
							num = (short)1292632076;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						(parentRecset[num4] as global::Motorola.MackinawCPS.CoreFeatures.Switches.MFKAssignmentControlInner).MFKAssignmentControlInnerSection.RadErgoControlSwitchsMFKFeatureAssignment_A38514.CalculateApplicability();
						num4++;
						num = (short)1027670020;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 7:
						return false;
					case 8:
						goto IL_368;
					case 9:
						goto IL_2BD;
					case 10:
						goto IL_20B;
					case 11:
					{
						if (global::ConstraintHelper.UtilityMack.IsMobile())
						{
							num = (short)1356267533;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						global::AcpCommonLib.IAcpRecordset parentRecset = self.ParentRecset;
						int num4 = 0;
						num = (short)1302069262;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 12:
						num = (short)1978925059;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 13:
						return true;
					case 14:
						goto IL_18F;
					case 15:
					{
						global::AcpCommonLib.IAcpRecordset parentRecset;
						if (parentRecset[1] == self.Parent)
						{
							num = (short)526712837;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return result;
					}
					case 16:
					{
						int value2;
						if (value2 == 23)
						{
							num = (short)326369290;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_27F;
					}
					case 17:
					{
						int value2;
						if (value2 != 38)
						{
							num = (short)1057882128;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)1855983004;
						short num5 = num;
						num = (short)909184412;
						switch ((num5 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_368;
						default:
							num = (short)1901789184;
							if (num != 0)
							{
							}
							num = (short)400883719;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						break;
					}
					}
					goto IL_77;
					IL_18F:
					num = (short)344457222;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_368:
					if (index == 38)
					{
						num = (short)802619394;
						num2 = (int)((global::System.IntPtr)num);
					}
					else
					{
						num = (short)1480392704;
						num2 = (int)((global::System.IntPtr)num);
					}
				}
				return true;
				IL_20B:
				return index != 23;
				IL_27F:
				return index == 23;
				IL_2BD:
				return index != 23;
				IL_3D6:
				return index == 23;
				IL_77:
				num = (short)646381569;
				if (num != 0)
				{
				}
				result = true;
				num = (short)68747275;
				num2 = (int)((global::System.IntPtr)num);
				goto IL_28;
			}
			}
		}

		// Token: 0x060073C5 RID: 29637 RVA: 0x00685CE0 File Offset: 0x00683EE0
		public static bool conPrimaryFunctionIsNonBlank(global::AcpCommonLib.IAcpFeatureSection self)
		{
			bool result = true;
			global::Motorola.MackinawCPS.CoreFeatures.Switches.MFKAssignmentControlInnerSection mfkassignmentControlInnerSection = self as global::Motorola.MackinawCPS.CoreFeatures.Switches.MFKAssignmentControlInnerSection;
			global::AcpCommonLib.IAcpRecordset parentRecset = self.ParentRecset;
			global::AcpCommonLib.IAcpFeatureNode parent = mfkassignmentControlInnerSection.RadErgoControlSwitchsMFKFeatureAssignment_A38514.Parent.Parent;
			if ((parent.Parent as global::AcpBusinessLayer.Recordset).IndexOf(parent) != 1)
			{
				short num = (short)1509342492;
				short num2 = num;
				num = (short)1581366556;
				switch ((num2 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					goto IL_35;
				case 1:
					break;
				default:
				{
					num = (short)1778057216;
					short num3 = num;
					break;
				}
				}
				num = (short)772538369;
				if (num != 0)
				{
				}
				num = (short)269877248;
				if (num != 0)
				{
				}
				return result;
			}
			IL_35:
			return (parentRecset[0] as global::Motorola.MackinawCPS.CoreFeatures.Switches.MFKAssignmentControlInner).MFKAssignmentControlInnerSection.RadErgoControlSwitchsMFKFeatureAssignment_A38514.Value != 38;
		}

		// Token: 0x060073C6 RID: 29638 RVA: 0x00685DE4 File Offset: 0x00683FE4
		public static void ConSynO2AndO7MFKWithSwitchMFK(global::AcpCommonLib.IAcpFeatureSection self, global::AcpCommonLib.UndoRedo.ContainerTask task)
		{
			short num = (short)138608640;
			switch (num)
			{
			default:
			{
				global::Motorola.MackinawCPS.CoreFeatures.Switches.MFKAssignmentControlInnerSection mfkassignmentControlInnerSection = self as global::Motorola.MackinawCPS.CoreFeatures.Switches.MFKAssignmentControlInnerSection;
				int value = mfkassignmentControlInnerSection.RadErgoControlSwitchsMFKFeatureAssignment_A38514.Value;
				global::System.Collections.Generic.IEnumerator<global::AcpBusinessLayer.FeatureNode> enumerator = (((global::AcpCommonLib.FeatureManager.GetFeature(4114) as global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO7.ControlHeadO7Recset)[0] as global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO7.ControlHeadO7).O7MultiFunctionKnob.EmbeddedRecset as global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO7.O7MFKAssignmentControlInnerRecset).GetEnumerator();
				try
				{
					num = (short)1308360708;
					int num2 = (int)((global::System.IntPtr)num);
					for (;;)
					{
						switch (num2)
						{
						case 0:
							num = (short)987561987;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 1:
							num = (short)1897725954;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 2:
						{
							global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO7.O7MFKAssignmentControlInner o7MFKAssignmentControlInner;
							if (o7MFKAssignmentControlInner.O7MFKAssignmentControlInnerSection.RadErgoControlO7MFKFeatureAssignment_A41295Value != value)
							{
								num = (short)478216197;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							break;
						}
						case 3:
							goto IL_421;
						case 4:
							switch (0)
							{
							case 0:
								goto IL_2F5;
							}
							continue;
						case 5:
						{
							global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO7.O7MFKAssignmentControlInner o7MFKAssignmentControlInner;
							task.AddTask(new global::AcpBusinessLayer.UndoRedo.ModifyDataTask<int>(o7MFKAssignmentControlInner.O7MFKAssignmentControlInnerSection.RadErgoControlO7MFKFeatureAssignment_A41295, value));
							num = (short)1929707527;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						case 6:
						{
							global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO7.O7MFKAssignmentControlInner o7MFKAssignmentControlInner;
							if (o7MFKAssignmentControlInner.O7MFKAssignmentControlInnerSection.O7MFKAssignmentControlName_A41294Value == mfkassignmentControlInnerSection.SwitchMFKAssignmentControlName_A38529Value)
							{
								num = (short)97779713;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							break;
						}
						case 7:
							goto IL_35F;
						case 8:
						{
							if (!enumerator.MoveNext())
							{
								num = (short)37093376;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO7.O7MFKAssignmentControlInner o7MFKAssignmentControlInner = (global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO7.O7MFKAssignmentControlInner)enumerator.Current;
							num = (short)467992582;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						}
						IL_2F7:
						num = (short)1128529928;
						num2 = (int)((global::System.IntPtr)num);
						continue;
						IL_2F5:
						goto IL_2F7;
					}
					IL_35F:
					IL_421:
					goto IL_24F;
				}
				finally
				{
					num = (short)1089929218;
					int num2 = (int)((global::System.IntPtr)num);
					for (;;)
					{
						switch (num2)
						{
						case 0:
							enumerator.Dispose();
							num = (short)792002561;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 1:
						{
							num = (short)146453736;
							short num3 = num;
							num = (short)996586728;
							switch ((num3 == num) ? 1 : 0)
							{
							case 0:
							case 2:
								continue;
							default:
								goto IL_4C5;
							}
							break;
						}
						case 2:
							switch (0)
							{
							case 0:
								goto IL_458;
							}
							continue;
						}
						IL_458:
						if (enumerator == null)
						{
							goto IL_4DC;
						}
						num = (short)96862208;
						num2 = (int)((global::System.IntPtr)num);
					}
					IL_4C5:
					num = (short)226885632;
					if (num != 0)
					{
					}
					IL_4DC:;
				}
				goto IL_4DD;
				for (;;)
				{
					IL_24F:
					num = (short)833617921;
					if (num != 0)
					{
					}
					enumerator = (((global::AcpCommonLib.FeatureManager.GetFeature(4115) as global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO2.ControlHeadO2Recset)[0] as global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO2.ControlHeadO2).O2MultiFunctionKnob.EmbeddedRecset as global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO2.O2MFKAssignmentControlInnerRecset).GetEnumerator();
					try
					{
						num = (short)193921028;
						int num2 = (int)((global::System.IntPtr)num);
						for (;;)
						{
							switch (num2)
							{
							case 0:
							{
								if (!enumerator.MoveNext())
								{
									num = (short)693633031;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO2.O2MFKAssignmentControlInner o2MFKAssignmentControlInner = (global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO2.O2MFKAssignmentControlInner)enumerator.Current;
								num = (short)1658847234;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							case 1:
							{
								global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO2.O2MFKAssignmentControlInner o2MFKAssignmentControlInner;
								task.AddTask(new global::AcpBusinessLayer.UndoRedo.ModifyDataTask<int>(o2MFKAssignmentControlInner.O2MFKAssignmentControlInnerSection.RadErgoControlO2MFKFeatureAssignment_A41275, value));
								num = (short)863633416;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							case 2:
							{
								global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO2.O2MFKAssignmentControlInner o2MFKAssignmentControlInner;
								if (o2MFKAssignmentControlInner.O2MFKAssignmentControlInnerSection.O2MFKAssignmentControlName_A41274Value == mfkassignmentControlInnerSection.SwitchMFKAssignmentControlName_A38529Value)
								{
									num = (short)1097531397;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								break;
							}
							case 3:
								goto IL_1DE;
							case 4:
								switch (0)
								{
								case 0:
									goto IL_AF;
								}
								continue;
							case 5:
								num = (short)1739587590;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							case 6:
							{
								global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO2.O2MFKAssignmentControlInner o2MFKAssignmentControlInner;
								if (o2MFKAssignmentControlInner.O2MFKAssignmentControlInnerSection.RadErgoControlO2MFKFeatureAssignment_A41275Value != value)
								{
									num = (short)954597377;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								break;
							}
							case 7:
								num = (short)218562563;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							case 8:
								goto IL_DF;
							}
							IL_E4:
							num = (short)318898176;
							num2 = (int)((global::System.IntPtr)num);
							continue;
							IL_AF:
							goto IL_E4;
						}
						IL_DF:
						IL_1DE:
						break;
					}
					finally
					{
						num = (short)409665538;
						int num2 = (int)((global::System.IntPtr)num);
						for (;;)
						{
							switch (num2)
							{
							case 0:
								enumerator.Dispose();
								num = (short)405471233;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							case 1:
								goto IL_24C;
							case 2:
								switch (0)
								{
								case 0:
									goto IL_215;
								}
								continue;
							}
							IL_215:
							if (enumerator == null)
							{
								break;
							}
							num = (short)1063518208;
							num2 = (int)((global::System.IntPtr)num);
						}
						IL_24C:;
					}
				}
				IL_4DD:
				num = (short)1326841856;
				short num4 = num;
				return;
			}
			}
		}
	}
}
