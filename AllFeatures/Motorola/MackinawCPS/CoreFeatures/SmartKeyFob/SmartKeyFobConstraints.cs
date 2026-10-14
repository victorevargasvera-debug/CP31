using System;
using System.Collections.Generic;
using AcpBusinessLayer;
using AcpBusinessLayer.UndoRedo;
using AcpCommonLib;
using AcpCommonLib.UndoRedo;
using CommonResources;
using ConstraintHelper;
using Motorola.MackinawCPS.CoreFeatures.Buttons;
using Motorola.MackinawCPS.CoreFeatures.EmergencyWide;
using Motorola.MackinawCPS.CoreFeatures.MenuItems;
using Motorola.MackinawCPS.CoreFeatures.RadioErgonomicsWide;
using Motorola.MackinawCPS.CoreFeatures.RadioWide;
using Motorola.MackinawCPS.CoreFeatures.RemoteSpeakerMic;

namespace Motorola.MackinawCPS.CoreFeatures.SmartKeyFob
{
	// Token: 0x020002C4 RID: 708
	public static class SmartKeyFobConstraints
	{
		// Token: 0x060076FB RID: 30459 RVA: 0x006B44B4 File Offset: 0x006B26B4
		public static bool ConConventionalFobFeaturesValid(global::AcpCommonLib.IAcpFeatureSection self, int index)
		{
			short num = (short)639893504;
			int num2 = (int)num;
			switch (num2)
			{
			default:
			{
				switch (0)
				{
				case 0:
					goto IL_232;
				}
				bool flag;
				global::Motorola.MackinawCPS.CoreFeatures.Buttons.PortableButtonInnerRecset portableButtonInnerRecset;
				global::AcpCommonLib.IAcpRecordset feature;
				global::AcpBusinessLayer.AcpListField emerWideManDownTrigger_A;
				global::AcpBusinessLayer.AcpListField switchConventionalSwitchesPosition4_A;
				global::AcpBusinessLayer.AcpListField switchConventionalSwitchesPosition1_A;
				global::AcpBusinessLayer.AcpListField switchConventionalSwitchesPosition3_A;
				global::AcpBusinessLayer.AcpListField switchTrunkingSwitchesPosition3_A;
				global::AcpBusinessLayer.AcpListField switchConventionalSwitchesPosition2_A;
				global::Motorola.MackinawCPS.CoreFeatures.RemoteSpeakerMic.RSMButtonInnerRecset rsmbuttonInnerRecset;
				global::AcpBusinessLayer.AcpListField switchTrunkingSwitchesPosition2_A;
				global::Motorola.MackinawCPS.CoreFeatures.RadioWide.Features features;
				global::AcpBusinessLayer.AcpListField switchTrunkingSwitchesPosition4_A;
				global::AcpBusinessLayer.AcpListField switchTrunkingSwitchesPosition5_A;
				global::AcpBusinessLayer.AcpListField switchConventionalSwitchesPosition5_A;
				global::AcpBusinessLayer.AcpListField switchTrunkingSwitchesPosition1_A;
				global::Motorola.MackinawCPS.CoreFeatures.RadioErgonomicsWide.RadioErgonomicsWide radioErgonomicsWide;
				for (;;)
				{
					IL_27:
					bool flag2;
					int num4;
					bool flag3;
					int num5;
					int num6;
					int num7;
					int num8;
					switch (num2)
					{
					case 0:
						num = (short)2019819546;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 1:
						flag = false;
						num = (short)16777226;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 2:
						num = (short)556531713;
						if (num != 0)
						{
						}
						num = (short)1826291757;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 3:
						num = (short)148635738;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 4:
						goto IL_16B5;
					case 5:
						flag2 = false;
						goto IL_135D;
					case 6:
						num = (short)1067122758;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 7:
						try
						{
							num = (short)2055798789;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								switch (num2)
								{
								case 1:
								{
									global::System.Collections.Generic.IEnumerator<global::AcpBusinessLayer.FeatureNode> enumerator;
									if ((((global::AcpCommonLib.IAcpFeatureNode)enumerator.Current)[10092] as global::Motorola.MackinawCPS.CoreFeatures.Buttons.PortableButtonInnerSection).BtnGeneralConventionalFeature_A19544.Value == 214)
									{
										num = (short)1494286338;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									break;
								}
								case 2:
									flag = true;
									num = (short)1223884800;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 3:
									goto IL_79C;
								case 4:
								{
									global::System.Collections.Generic.IEnumerator<global::AcpBusinessLayer.FeatureNode> enumerator;
									if (!enumerator.MoveNext())
									{
										num = (short)977403910;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									num = (short)1975582721;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 5:
									switch (0)
									{
									case 0:
										goto IL_6D4;
									}
									continue;
								case 6:
									num = (short)146735107;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								IL_6D6:
								num = (short)658833412;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								IL_6D4:
								goto IL_6D6;
							}
							IL_79C:
							return flag;
						}
						finally
						{
							num = (short)913506306;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								global::System.Collections.Generic.IEnumerator<global::AcpBusinessLayer.FeatureNode> enumerator;
								switch (num2)
								{
								case 0:
									enumerator.Dispose();
									num = (short)880541697;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 1:
									goto IL_85E;
								case 2:
									goto IL_7B7;
								}
								goto IL_7D4;
								IL_7B7:
								switch (0)
								{
								case 0:
								{
									IL_7D4:
									if (enumerator == null)
									{
										goto IL_860;
									}
									num = (short)510814108;
									short num3 = num;
									num = (short)1496606620;
									switch ((num3 == num) ? 1 : 0)
									{
									case 0:
									case 2:
										goto IL_7B7;
									default:
										num = (short)198574080;
										if (num != 0)
										{
										}
										num = (short)1402208256;
										num2 = (int)((global::System.IntPtr)num);
										break;
									}
									break;
								}
								}
							}
							IL_85E:
							IL_860:;
						}
						goto IL_861;
					case 8:
					{
						if (index != 214)
						{
							num = (short)1679294483;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						flag = false;
						global::System.Collections.Generic.IEnumerator<global::AcpBusinessLayer.FeatureNode> enumerator = portableButtonInnerRecset.GetEnumerator();
						num = (short)2028863495;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 9:
						num = (short)1011220531;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 10:
						goto IL_1231;
					case 11:
						if (feature != null)
						{
							num = (short)554958924;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return flag;
					case 12:
					{
						global::Motorola.MackinawCPS.CoreFeatures.MenuItems.MenuItems menuItems = feature[0] as global::Motorola.MackinawCPS.CoreFeatures.MenuItems.MenuItems;
						num4 = 0;
						num = (short)1602355324;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 13:
						num = (short)970260579;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 14:
						flag = false;
						num = (short)826409072;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 15:
						if (index != 217)
						{
							num = (short)1514012675;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						flag = (emerWideManDownTrigger_A.Value != 0);
						num = (short)1518862432;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 16:
						num = (short)237633617;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 17:
						num = (short)518062126;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 18:
						flag = false;
						num = (short)1196425329;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 19:
						num = (short)881459315;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 20:
						num = (short)484900948;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 21:
						try
						{
							num = (short)653131781;
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
										num = (short)1431961601;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									num = (short)328204292;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 1:
									num = (short)472645635;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 3:
									goto IL_15BE;
								case 4:
								{
									global::System.Collections.Generic.IEnumerator<global::AcpBusinessLayer.FeatureNode> enumerator;
									if ((((global::AcpCommonLib.IAcpFeatureNode)enumerator.Current)[10092] as global::Motorola.MackinawCPS.CoreFeatures.Buttons.PortableButtonInnerSection).BtnGeneralConventionalFeature_A19544.Value == 149)
									{
										num = (short)149487622;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									break;
								}
								case 5:
									switch (0)
									{
									case 0:
										goto IL_14F4;
									}
									continue;
								case 6:
									flag = true;
									num = (short)317456386;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								IL_154C:
								num = (short)848822272;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								IL_14F4:
								goto IL_154C;
							}
							IL_15BE:
							return flag;
						}
						finally
						{
							num = (short)1195704322;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								global::System.Collections.Generic.IEnumerator<global::AcpBusinessLayer.FeatureNode> enumerator;
								switch (num2)
								{
								case 0:
									enumerator.Dispose();
									num = (short)1330577409;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 1:
									goto IL_162C;
								case 2:
									switch (0)
									{
									case 0:
										goto IL_15F5;
									}
									continue;
								}
								IL_15F5:
								if (enumerator == null)
								{
									break;
								}
								num = (short)1868234752;
								num2 = (int)((global::System.IntPtr)num);
							}
							IL_162C:;
						}
						goto IL_162F;
					case 22:
						if (switchConventionalSwitchesPosition4_A.Value != 26)
						{
							num = (short)83623949;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_673;
					case 23:
						goto IL_1149;
					case 24:
						return flag;
					case 25:
						flag3 = false;
						goto IL_17E8;
					case 26:
						if (!global::ConstraintHelper.UtilityMack.IsMobile())
						{
							num = (short)1971585107;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return flag;
					case 27:
						flag = false;
						num = (short)12714045;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 28:
						if (!global::ConstraintHelper.UtilityMack.IsMobile())
						{
							num = (short)702808076;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return flag;
					case 29:
						return flag;
					case 30:
						num = (short)689635370;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 31:
						num = (short)931332182;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 32:
						num5 = 0;
						num = (short)192282730;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 33:
						if (flag)
						{
							num = (short)458096687;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return flag;
					case 34:
						goto IL_118E;
					case 35:
					{
						global::Motorola.MackinawCPS.CoreFeatures.MenuItems.MenuItems menuItems;
						if (menuItems.General.DispMenuConventionalSelectedMenuItems_A21736.Items[num4].ItemName == global::CommonResources.AcgResources.ID_SCAN)
						{
							num = (short)1007222785;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_1231;
					}
					case 36:
						return flag;
					case 37:
						flag = false;
						num = (short)1172766789;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 38:
						goto IL_BD2;
					case 39:
					{
						global::Motorola.MackinawCPS.CoreFeatures.MenuItems.MenuItems menuItems;
						if (menuItems.General.DispMenuTrunkingSelectedMenuItems_A21735.Items[num5].ItemName == global::CommonResources.AcgResources.ID_SCAN)
						{
							num = (short)2146238501;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_18C3;
					}
					case 40:
						if (switchConventionalSwitchesPosition1_A.Value != 26)
						{
							num = (short)2142699570;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_673;
					case 41:
						num = (short)889978989;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 42:
						if (switchConventionalSwitchesPosition4_A.Value != 33)
						{
							num = (short)853606523;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_1405;
					case 43:
						return flag;
					case 44:
						num = (short)1390936112;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 45:
						if (switchConventionalSwitchesPosition3_A.Value != 26)
						{
							num = (short)1150419039;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_673;
					case 46:
						return flag;
					case 47:
						num = (short)942276619;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 48:
						return flag;
					case 49:
						num = (short)856490020;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 50:
						num = (short)843186240;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 51:
						if (switchTrunkingSwitchesPosition3_A.Value != 33)
						{
							num = (short)515571777;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_1405;
					case 52:
						return flag;
					case 53:
					{
						global::Motorola.MackinawCPS.CoreFeatures.MenuItems.MenuItems menuItems2;
						if (menuItems2.General.DispMenuConventionalSelectedMenuItems_A21736.Items[num6].ItemName == global::CommonResources.AcgResources.ID_DIR)
						{
							num = (short)286851099;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_F3E;
					}
					case 54:
						goto IL_146B;
					case 55:
						if (index <= 214)
						{
							num = (short)634454107;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_861;
					case 56:
						num7 = 0;
						num = (short)337772598;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 57:
						goto IL_BD2;
					case 58:
					{
						global::Motorola.MackinawCPS.CoreFeatures.MenuItems.MenuItems menuItems;
						if (num5 >= menuItems.General.DispMenuTrunkingSelectedMenuItems_A21735.Items.Count || !flag)
						{
							num = (short)1668677760;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)1189019687;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 59:
						num = (short)703922295;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 60:
						num = (short)1816395828;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 61:
						goto IL_F3E;
					case 62:
						num = (short)1567752263;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 63:
						num = (short)1051983949;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 64:
						if (switchConventionalSwitchesPosition2_A.Value != 26)
						{
							num = (short)1316683778;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_673;
					case 65:
						num = (short)1976303708;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 66:
						flag = false;
						num = (short)89063458;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 67:
						if (flag)
						{
							num = (short)106496016;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return flag;
					case 68:
						num = (short)496238680;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 69:
						goto IL_18C3;
					case 70:
						if ((portableButtonInnerRecset[num8] as global::Motorola.MackinawCPS.CoreFeatures.Buttons.PortableButtonInner).PortableButtonInnerSection.BtnGeneralConventionalFeature_A19544.Value == 31)
						{
							num = (short)1094844430;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_12FC;
					case 71:
						if (rsmbuttonInnerRecset != null)
						{
							num = (short)1384054840;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_118E;
					case 72:
						if (portableButtonInnerRecset != null)
						{
							num = (short)1887830141;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return flag;
					case 73:
						if (switchConventionalSwitchesPosition3_A.Value != 33)
						{
							num = (short)897843230;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_1405;
					case 74:
						if (switchConventionalSwitchesPosition1_A.Value == 81)
						{
							num = (short)1566900242;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return flag;
					case 75:
						if (switchConventionalSwitchesPosition1_A.Value != 33)
						{
							num = (short)1285881924;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_1405;
					case 76:
						num = (short)39059574;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 77:
						if (index != 33)
						{
							num = (short)1503592497;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)1535246411;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 78:
						num = (short)7536712;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 79:
						goto IL_1149;
					case 80:
						if (switchTrunkingSwitchesPosition2_A.Value != 33)
						{
							num = (short)1326055433;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_1405;
					case 81:
						if (feature != null)
						{
							num = (short)383582239;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return flag;
					case 82:
						if (flag)
						{
							num = (short)463470670;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return flag;
					case 83:
					{
						global::Motorola.MackinawCPS.CoreFeatures.MenuItems.MenuItems menuItems2 = feature[0] as global::Motorola.MackinawCPS.CoreFeatures.MenuItems.MenuItems;
						num6 = 0;
						num = (short)644808742;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 84:
						if (index != 81)
						{
							num = (short)419233836;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)1727594570;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 85:
						goto IL_57B;
					case 86:
						if (feature.Count != 0)
						{
							num = (short)1841692672;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return flag;
					case 87:
						num = (short)1718943838;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 88:
						if (switchConventionalSwitchesPosition2_A.Value != 33)
						{
							num = (short)776863870;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_1405;
					case 89:
						if (num7 >= rsmbuttonInnerRecset.Count)
						{
							num = (short)1679294567;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)935723109;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 90:
						if (index - 290 > 1)
						{
							num = (short)742260840;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						flag = features.RadWideFeaturesChannelFallbackEnableValue;
						num = (short)474873885;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 91:
						num = (short)251527261;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 92:
						if (switchTrunkingSwitchesPosition4_A.Value != 33)
						{
							num = (short)1650982999;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_1405;
					case 93:
					{
						if (index != 149)
						{
							num = (short)2037514348;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						flag = false;
						global::System.Collections.Generic.IEnumerator<global::AcpBusinessLayer.FeatureNode> enumerator = portableButtonInnerRecset.GetEnumerator();
						num = (short)628621333;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 94:
						flag3 = (switchTrunkingSwitchesPosition5_A.Value != 33);
						goto IL_17E8;
					case 95:
						goto IL_162F;
					case 96:
						return flag;
					case 97:
						goto IL_146B;
					case 98:
						if (switchConventionalSwitchesPosition5_A.Value != 33)
						{
							num = (short)350027817;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_1405;
					case 99:
						flag2 = (switchConventionalSwitchesPosition5_A.Value != 26);
						goto IL_135D;
					case 100:
						if (index != 26)
						{
							num = (short)808058943;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)1937637416;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 101:
						if ((rsmbuttonInnerRecset[num7] as global::Motorola.MackinawCPS.CoreFeatures.RemoteSpeakerMic.RSMButtonInner).RSMButtonInnerSection.RadErgoCfgRSMConventionalBCO_A19639.Value != 151)
						{
							num = (short)962199611;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_D11;
					case 102:
						if (num8 >= portableButtonInnerRecset.Count)
						{
							num = (short)1770651665;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)633012351;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 103:
						goto IL_118E;
					case 104:
						num = (short)147587096;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 105:
						num = (short)1684340836;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 106:
						goto IL_57B;
					case 107:
					{
						global::Motorola.MackinawCPS.CoreFeatures.MenuItems.MenuItems menuItems2;
						if (num6 >= menuItems2.General.DispMenuConventionalSelectedMenuItems_A21736.Items.Count)
						{
							num = (short)20381756;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)379125813;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 108:
						num = (short)1394212872;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 109:
						if (switchTrunkingSwitchesPosition1_A.Value != 33)
						{
							num = (short)1003028600;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_1405;
					case 110:
						if (index != 61)
						{
							num = (short)496042004;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)885981298;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 111:
						num = (short)1735852060;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 112:
						return flag;
					case 113:
						return flag;
					case 114:
						if (radioErgonomicsWide.Advanced.RadErgoWideAdvancedSideButtonsLockEnable_A38725.Value)
						{
							num = (short)161153086;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return flag;
					case 115:
						return flag;
					case 116:
						if (index <= 81)
						{
							num = (short)905052282;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)80216119;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 117:
					{
						global::Motorola.MackinawCPS.CoreFeatures.MenuItems.MenuItems menuItems;
						if (num4 >= menuItems.General.DispMenuConventionalSelectedMenuItems_A21736.Items.Count || !flag)
						{
							num = (short)1793327136;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)877527075;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 118:
						if (feature.Count != 0)
						{
							num = (short)1923809391;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return flag;
					case 119:
						if ((rsmbuttonInnerRecset[num7] as global::Motorola.MackinawCPS.CoreFeatures.RemoteSpeakerMic.RSMButtonInner).RSMButtonInnerSection.RadErgoCfgRSMlConventionalFeature_A19640.Value == 31)
						{
							num = (short)712245314;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_D11;
					case 120:
					{
						num = (short)2010906624;
						short num9 = num;
						num = (short)1421279312;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 121:
						if (index <= 33)
						{
							num = (short)1171062889;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)1707409518;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 122:
						num = (short)1885667449;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 123:
						num = (short)887488610;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 124:
						goto IL_16B5;
					case 125:
						num8 = 0;
						num = (short)1468399639;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 126:
						num = (short)1003094089;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 127:
						if ((portableButtonInnerRecset[num8] as global::Motorola.MackinawCPS.CoreFeatures.Buttons.PortableButtonInner).PortableButtonInnerSection.BtnGeneralConventionalBCO_A19543.Value != 148)
						{
							num = (short)1020002310;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_12FC;
					case 128:
						num = (short)1900281899;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_232;
					IL_57B:
					num = (short)1998979130;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_673:
					num = (short)977600517;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_861:
					num = (short)1521942543;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_BD2:
					num = (short)1281622123;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_D11:
					num7++;
					num = (short)525795425;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_F3E:
					num6++;
					num = (short)1208942649;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_1149:
					num = (short)2095448166;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_118E:
					num = (short)2031698;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_1231:
					num4++;
					num = (short)1014497284;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_12FC:
					num8++;
					num = (short)1779630159;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_135D:
					flag = flag2;
					num = (short)637206595;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_1405:
					num = (short)2000224281;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_146B:
					num = (short)654901337;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_162F:
					num = (short)16842774;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_16B5:
					num = (short)607780981;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_17E8:
					flag = flag3;
					num = (short)669319201;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_18C3:
					num5++;
					num = (short)738721877;
					num2 = (int)((global::System.IntPtr)num);
				}
				return flag;
				IL_232:
				global::Motorola.MackinawCPS.CoreFeatures.SmartKeyFob.SmartKeyFobButtonTableInnerSection smartKeyFobButtonTableInnerSection = self as global::Motorola.MackinawCPS.CoreFeatures.SmartKeyFob.SmartKeyFobButtonTableInnerSection;
				switchConventionalSwitchesPosition1_A = smartKeyFobButtonTableInnerSection.RefSwitches.ConventionalSwitches.SwitchConventionalSwitchesPosition1_A7734;
				switchConventionalSwitchesPosition2_A = smartKeyFobButtonTableInnerSection.RefSwitches.ConventionalSwitches.SwitchConventionalSwitchesPosition2_A7735;
				switchConventionalSwitchesPosition3_A = smartKeyFobButtonTableInnerSection.RefSwitches.ConventionalSwitches.SwitchConventionalSwitchesPosition3_A7737;
				switchConventionalSwitchesPosition4_A = smartKeyFobButtonTableInnerSection.RefSwitches.ConventionalSwitches.SwitchConventionalSwitchesPosition4_A21530;
				switchConventionalSwitchesPosition5_A = smartKeyFobButtonTableInnerSection.RefSwitches.ConventionalSwitches.SwitchConventionalSwitchesPosition5_A21531;
				switchTrunkingSwitchesPosition1_A = smartKeyFobButtonTableInnerSection.RefSwitches.TrunkingSwitches.SwitchTrunkingSwitchesPosition1_A9466;
				switchTrunkingSwitchesPosition2_A = smartKeyFobButtonTableInnerSection.RefSwitches.TrunkingSwitches.SwitchTrunkingSwitchesPosition2_A9467;
				switchTrunkingSwitchesPosition3_A = smartKeyFobButtonTableInnerSection.RefSwitches.TrunkingSwitches.SwitchTrunkingSwitchesPosition3_A9468;
				switchTrunkingSwitchesPosition4_A = smartKeyFobButtonTableInnerSection.RefSwitches.TrunkingSwitches.SwitchTrunkingSwitchesPosition4_A21534;
				switchTrunkingSwitchesPosition5_A = smartKeyFobButtonTableInnerSection.RefSwitches.TrunkingSwitches.SwitchTrunkingSwitchesPosition5_A21535;
				portableButtonInnerRecset = ((global::AcpCommonLib.FeatureManager.GetFeature(2042) as global::Motorola.MackinawCPS.CoreFeatures.Buttons.ButtonsRecset)[0][10091].EmbeddedRecset as global::Motorola.MackinawCPS.CoreFeatures.Buttons.PortableButtonInnerRecset);
				rsmbuttonInnerRecset = ((global::AcpCommonLib.FeatureManager.GetFeature(2036) as global::Motorola.MackinawCPS.CoreFeatures.RemoteSpeakerMic.RemoteSpeakerMicRecset)[0][10079].EmbeddedRecset as global::Motorola.MackinawCPS.CoreFeatures.RemoteSpeakerMic.RSMButtonInnerRecset);
				feature = global::AcpCommonLib.FeatureManager.GetFeature(2088);
				flag = true;
				radioErgonomicsWide = (global::AcpCommonLib.FeatureManager.GetFeature(2033)[0] as global::Motorola.MackinawCPS.CoreFeatures.RadioErgonomicsWide.RadioErgonomicsWide);
				global::AcpCommonLib.IAcpFeatureNode acpFeatureNode = global::AcpCommonLib.FeatureManager.GetFeature(2038)[0];
				features = (global::AcpCommonLib.FeatureManager.GetFeature(2045)[0][10105] as global::Motorola.MackinawCPS.CoreFeatures.RadioWide.Features);
				emerWideManDownTrigger_A = ((global::AcpCommonLib.FeatureManager.GetFeature(2032) as global::Motorola.MackinawCPS.CoreFeatures.EmergencyWide.EmergencyWideRecset)[0][10639] as global::Motorola.MackinawCPS.CoreFeatures.EmergencyWide.ManDown).EmerWideManDownTrigger_A40001;
				num = (short)560726132;
				num2 = (int)((global::System.IntPtr)num);
				goto IL_27;
			}
			}
		}

		// Token: 0x060076FC RID: 30460 RVA: 0x006B5E28 File Offset: 0x006B4028
		internal static void conUpdateFieldsDepOnFobCnvButton(global::AcpCommonLib.IAcpFeatureSection self, global::AcpCommonLib.UndoRedo.ContainerTask task)
		{
			switch (0)
			{
			case 0:
				goto IL_104;
			}
			int num;
			global::AcpBusinessLayer.AcpListField radErgoCfgFobTrunkingFeature_A;
			short num2;
			global::AcpBusinessLayer.AcpListField radErgoCfgFobConventionalFeature_A;
			for (;;)
			{
				IL_0A:
				switch (num)
				{
				case 0:
					if (radErgoCfgFobTrunkingFeature_A.Value != 210)
					{
						num2 = (short)166264867;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_3B8;
				case 1:
					if (radErgoCfgFobConventionalFeature_A.Value == 149)
					{
						num2 = (short)294780943;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					num2 = (short)1837105168;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 2:
					num2 = (short)1903689732;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 3:
					if (radErgoCfgFobConventionalFeature_A.Value == 27)
					{
						num2 = (short)63111186;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					num2 = (short)1849622578;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 4:
					if (radErgoCfgFobTrunkingFeature_A.Value != 209)
					{
						num2 = (short)1343029255;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_3B8;
				case 5:
					if (radErgoCfgFobTrunkingFeature_A.Value != 87)
					{
						num2 = (short)865075256;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_3B8;
				case 6:
					goto IL_669;
				case 7:
					num2 = (short)857866240;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 8:
					if (radErgoCfgFobConventionalFeature_A.Value == 235)
					{
						num2 = (short)1628373009;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					num2 = (short)1083375619;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 9:
					goto IL_701;
				case 10:
				{
					num2 = (short)243663827;
					short num3 = num2;
					num2 = (short)2020475859;
					switch ((num3 == num2) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_652;
					default:
					{
						num2 = (short)1970339840;
						if (num2 != 0)
						{
						}
						num2 = (short)1203961856;
						short num4 = num2;
						num2 = (short)266731545;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					}
					break;
				}
				case 11:
					if (radErgoCfgFobTrunkingFeature_A.Value != 65)
					{
						num2 = (short)1715142703;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_3B8;
				case 12:
					goto IL_854;
				case 13:
					if (radErgoCfgFobTrunkingFeature_A.Value == 27)
					{
						num2 = (short)1442971671;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					return;
				case 14:
					if (radErgoCfgFobTrunkingFeature_A.Value != 236)
					{
						num2 = (short)1951531049;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_3B8;
				case 15:
					goto IL_155;
				case 16:
					if (radErgoCfgFobConventionalFeature_A.Value == 214)
					{
						num2 = (short)1596653577;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					num2 = (short)1473773588;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 17:
					goto IL_4FA;
				case 18:
					goto IL_53C;
				case 19:
					if (radErgoCfgFobConventionalFeature_A.Value == 212)
					{
						num2 = (short)2119565346;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					num2 = (short)1035141149;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 20:
					if (radErgoCfgFobConventionalFeature_A.Value == 66)
					{
						num2 = (short)1965096972;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					num2 = (short)656605237;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 21:
					goto IL_2CC;
				case 22:
					if (radErgoCfgFobTrunkingFeature_A.Value != 66)
					{
						num2 = (short)1061355574;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_3B8;
				case 23:
					goto IL_3B8;
				case 24:
					if (radErgoCfgFobConventionalFeature_A.Value == 87)
					{
						num2 = (short)1462042661;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					num2 = (short)416415775;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 25:
					if (radErgoCfgFobTrunkingFeature_A.Value != 64)
					{
						num2 = (short)1716977707;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_3B8;
				case 26:
					num2 = (short)647102497;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 27:
					if (radErgoCfgFobConventionalFeature_A.Value == 65)
					{
						num2 = (short)1643905084;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					num2 = (short)1534263320;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 28:
					goto IL_3DE;
				case 29:
					if (radErgoCfgFobConventionalFeature_A.Value == 209)
					{
						num2 = (short)540803130;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					num2 = (short)168099880;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 30:
					if (radErgoCfgFobConventionalFeature_A.Value == 211)
					{
						num2 = (short)1865809965;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					num2 = (short)1339818003;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 31:
					if (radErgoCfgFobConventionalFeature_A.Value == 88)
					{
						num2 = (short)1629093924;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					num2 = (short)1010761776;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 32:
					num2 = (short)958857229;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 33:
					if (radErgoCfgFobTrunkingFeature_A.Value != 214)
					{
						num2 = (short)1413152812;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_3B8;
				case 34:
					goto IL_21C;
				case 35:
					num2 = (short)1062076430;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 36:
					goto IL_958;
				case 37:
					goto IL_1D8;
				case 38:
					if (radErgoCfgFobTrunkingFeature_A.Value != 211)
					{
						num2 = (short)1708785703;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_3B8;
				case 39:
					num2 = (short)1988100147;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 40:
					if (radErgoCfgFobConventionalFeature_A.Value == 210)
					{
						num2 = (short)1908015159;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					num2 = (short)1847984170;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 41:
					num2 = (short)1157496833;
					if (num2 != 0)
					{
					}
					num2 = (short)935264308;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 42:
					if (radErgoCfgFobConventionalFeature_A.Value == 236)
					{
						goto IL_652;
					}
					num2 = (short)2003828744;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 43:
					num2 = (short)1546977291;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 44:
					num2 = (short)190971926;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 45:
					goto IL_6AE;
				case 46:
					goto IL_7D6;
				case 47:
					num2 = (short)1099235333;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 48:
					if (radErgoCfgFobTrunkingFeature_A.Value != 149)
					{
						num2 = (short)1047003162;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_3B8;
				case 49:
					if (radErgoCfgFobTrunkingFeature_A.Value != 67)
					{
						num2 = (short)1842020409;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_3B8;
				case 50:
					if (radErgoCfgFobConventionalFeature_A.Value == 64)
					{
						num2 = (short)1125777454;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					num2 = (short)1386151963;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 51:
					if (radErgoCfgFobTrunkingFeature_A.Value != 212)
					{
						num2 = (short)680001538;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_3B8;
				case 52:
					if (radErgoCfgFobTrunkingFeature_A.Value != 235)
					{
						num2 = (short)1654325258;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_3B8;
				case 53:
					if (radErgoCfgFobConventionalFeature_A.Value == 67)
					{
						num2 = (short)2117074965;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					num2 = (short)1963589662;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 54:
					num2 = (short)584581169;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 55:
					goto IL_625;
				case 56:
					num2 = (short)1708458043;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 57:
					num2 = (short)1042219046;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 58:
					goto IL_59E;
				case 59:
					if (radErgoCfgFobTrunkingFeature_A.Value != 88)
					{
						num2 = (short)1609170976;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_3B8;
				case 60:
					goto IL_742;
				}
				goto IL_104;
				IL_3B8:
				task.AddTask(new global::AcpBusinessLayer.UndoRedo.ModifyDataTask<int>(radErgoCfgFobTrunkingFeature_A, 35));
				num2 = (short)1013317660;
				num = (int)((global::System.IntPtr)num2);
				continue;
				IL_652:
				num2 = (short)2017918982;
				num = (int)((global::System.IntPtr)num2);
			}
			IL_155:
			task.AddTask(new global::AcpBusinessLayer.UndoRedo.ModifyDataTask<int>(radErgoCfgFobTrunkingFeature_A, 149));
			return;
			IL_1D8:
			task.AddTask(new global::AcpBusinessLayer.UndoRedo.ModifyDataTask<int>(radErgoCfgFobTrunkingFeature_A, 87));
			return;
			IL_21C:
			task.AddTask(new global::AcpBusinessLayer.UndoRedo.ModifyDataTask<int>(radErgoCfgFobTrunkingFeature_A, 212));
			return;
			IL_2CC:
			task.AddTask(new global::AcpBusinessLayer.UndoRedo.ModifyDataTask<int>(radErgoCfgFobTrunkingFeature_A, 67));
			return;
			IL_3DE:
			return;
			IL_4FA:
			task.AddTask(new global::AcpBusinessLayer.UndoRedo.ModifyDataTask<int>(radErgoCfgFobTrunkingFeature_A, 235));
			return;
			IL_53C:
			task.AddTask(new global::AcpBusinessLayer.UndoRedo.ModifyDataTask<int>(radErgoCfgFobTrunkingFeature_A, 27));
			return;
			IL_59E:
			task.AddTask(new global::AcpBusinessLayer.UndoRedo.ModifyDataTask<int>(radErgoCfgFobTrunkingFeature_A, 209));
			return;
			IL_625:
			task.AddTask(new global::AcpBusinessLayer.UndoRedo.ModifyDataTask<int>(radErgoCfgFobTrunkingFeature_A, 210));
			return;
			IL_669:
			task.AddTask(new global::AcpBusinessLayer.UndoRedo.ModifyDataTask<int>(radErgoCfgFobTrunkingFeature_A, 236));
			return;
			IL_6AE:
			task.AddTask(new global::AcpBusinessLayer.UndoRedo.ModifyDataTask<int>(radErgoCfgFobTrunkingFeature_A, 211));
			return;
			IL_701:
			task.AddTask(new global::AcpBusinessLayer.UndoRedo.ModifyDataTask<int>(radErgoCfgFobTrunkingFeature_A, 214));
			return;
			IL_742:
			task.AddTask(new global::AcpBusinessLayer.UndoRedo.ModifyDataTask<int>(radErgoCfgFobTrunkingFeature_A, 65));
			return;
			IL_7D6:
			task.AddTask(new global::AcpBusinessLayer.UndoRedo.ModifyDataTask<int>(radErgoCfgFobTrunkingFeature_A, 64));
			return;
			IL_854:
			task.AddTask(new global::AcpBusinessLayer.UndoRedo.ModifyDataTask<int>(radErgoCfgFobTrunkingFeature_A, 66));
			return;
			IL_958:
			task.AddTask(new global::AcpBusinessLayer.UndoRedo.ModifyDataTask<int>(radErgoCfgFobTrunkingFeature_A, 88));
			return;
			IL_104:
			global::Motorola.MackinawCPS.CoreFeatures.SmartKeyFob.SmartKeyFobButtonTableInnerSection smartKeyFobButtonTableInnerSection = self as global::Motorola.MackinawCPS.CoreFeatures.SmartKeyFob.SmartKeyFobButtonTableInnerSection;
			radErgoCfgFobConventionalFeature_A = smartKeyFobButtonTableInnerSection.RadErgoCfgFobConventionalFeature_A41574;
			radErgoCfgFobTrunkingFeature_A = smartKeyFobButtonTableInnerSection.RadErgoCfgFobTrunkingFeature_A41575;
			num2 = (short)1386414081;
			num = (int)((global::System.IntPtr)num2);
			goto IL_0A;
		}

		// Token: 0x060076FD RID: 30461 RVA: 0x006B68D0 File Offset: 0x006B4AD0
		internal static bool conFobConventionalTriggerProRSMButTableFeature(global::AcpCommonLib.IAcpFeatureSection self)
		{
			short num = (short)686817280;
			short num2 = num;
			num = (short)673550946;
			short num3 = num;
			num = (short)177705570;
			switch (num3 == num)
			{
			}
			num = (short)1832452097;
			if (num != 0)
			{
			}
			num = (short)90374144;
			if (num != 0)
			{
			}
			global::AcpCommonLib.FeatureManager.GetFeature(2042)[0][10091].EmbeddedRecset.CalculateValidity();
			global::AcpCommonLib.FeatureManager.GetFeature(2036)[0][10079].EmbeddedRecset.CalculateValidity();
			return true;
		}

		// Token: 0x060076FE RID: 30462 RVA: 0x006B69C4 File Offset: 0x006B4BC4
		public static bool conSetEditabilityFobTrkFeature(global::AcpCommonLib.IAcpFeatureSection self)
		{
			short num = (short)472882175;
			short num2 = num;
			num = (short)1191025663;
			global::Motorola.MackinawCPS.CoreFeatures.SmartKeyFob.SmartKeyFobButtonTableInnerSection smartKeyFobButtonTableInnerSection;
			int num4;
			switch ((num2 == num) ? 1 : 0)
			{
			case 0:
			case 2:
			{
				IL_2C3:
				if (smartKeyFobButtonTableInnerSection.RadErgoCfgFobConventionalFeature_A41574.Value == 64)
				{
					return false;
				}
				num = (short)1312489472;
				short num3 = num;
				num = (short)231407643;
				num4 = (int)((global::System.IntPtr)num);
				break;
			}
			default:
				num = (short)783941632;
				if (num != 0)
				{
				}
				switch (0)
				{
				case 0:
					goto IL_D3;
				}
				break;
			}
			for (;;)
			{
				IL_55:
				switch (num4)
				{
				case 0:
					if (smartKeyFobButtonTableInnerSection.RadErgoCfgFobConventionalFeature_A41574.Value != 66)
					{
						num = (short)1946288142;
						num4 = (int)((global::System.IntPtr)num);
						continue;
					}
					return false;
				case 1:
					num = (short)1925316609;
					if (num != 0)
					{
					}
					num = (short)1546911752;
					num4 = (int)((global::System.IntPtr)num);
					continue;
				case 2:
					num = (short)695205914;
					num4 = (int)((global::System.IntPtr)num);
					continue;
				case 3:
					num = (short)815071252;
					num4 = (int)((global::System.IntPtr)num);
					continue;
				case 4:
					if (smartKeyFobButtonTableInnerSection.RadErgoCfgFobConventionalFeature_A41574.Value != 214)
					{
						num = (short)1723727877;
						num4 = (int)((global::System.IntPtr)num);
						continue;
					}
					return false;
				case 5:
					num = (short)211025920;
					num4 = (int)((global::System.IntPtr)num);
					continue;
				case 6:
					if (smartKeyFobButtonTableInnerSection.RadErgoCfgFobConventionalFeature_A41574.Value != 149)
					{
						num = (short)171311127;
						num4 = (int)((global::System.IntPtr)num);
						continue;
					}
					return false;
				case 7:
					num = (short)1959133208;
					num4 = (int)((global::System.IntPtr)num);
					continue;
				case 8:
					if (smartKeyFobButtonTableInnerSection.RadErgoCfgFobConventionalFeature_A41574.Value != 210)
					{
						num = (short)1714814979;
						num4 = (int)((global::System.IntPtr)num);
						continue;
					}
					return false;
				case 9:
					if (smartKeyFobButtonTableInnerSection.RadErgoCfgFobConventionalFeature_A41574.Value != 211)
					{
						num = (short)844824595;
						num4 = (int)((global::System.IntPtr)num);
						continue;
					}
					return false;
				case 10:
					if (smartKeyFobButtonTableInnerSection.RadErgoCfgFobConventionalFeature_A41574.Value != 65)
					{
						num = (short)866058241;
						num4 = (int)((global::System.IntPtr)num);
						continue;
					}
					return false;
				case 11:
					num = (short)2070151189;
					num4 = (int)((global::System.IntPtr)num);
					continue;
				case 12:
					num = (short)202965014;
					num4 = (int)((global::System.IntPtr)num);
					continue;
				case 13:
					if (smartKeyFobButtonTableInnerSection.RadErgoCfgFobConventionalFeature_A41574.Value != 87)
					{
						num = (short)1770389516;
						num4 = (int)((global::System.IntPtr)num);
						continue;
					}
					return false;
				case 14:
					num = (short)634912793;
					num4 = (int)((global::System.IntPtr)num);
					continue;
				case 15:
					num = (short)1657077773;
					num4 = (int)((global::System.IntPtr)num);
					continue;
				case 16:
					num = (short)1845297161;
					num4 = (int)((global::System.IntPtr)num);
					continue;
				case 17:
					num = (short)139919378;
					num4 = (int)((global::System.IntPtr)num);
					continue;
				case 18:
					goto IL_2C3;
				case 19:
					num = (short)220004380;
					num4 = (int)((global::System.IntPtr)num);
					continue;
				case 20:
					if (smartKeyFobButtonTableInnerSection.RadErgoCfgFobConventionalFeature_A41574.Value != 236)
					{
						num = (short)1027801099;
						num4 = (int)((global::System.IntPtr)num);
						continue;
					}
					return false;
				case 21:
					if (smartKeyFobButtonTableInnerSection.RadErgoCfgFobConventionalFeature_A41574.Value == 235)
					{
						num = (short)1340604445;
						num4 = (int)((global::System.IntPtr)num);
						continue;
					}
					return true;
				case 22:
					if (smartKeyFobButtonTableInnerSection.RadErgoCfgFobConventionalFeature_A41574.Value != 88)
					{
						num = (short)30277649;
						num4 = (int)((global::System.IntPtr)num);
						continue;
					}
					return false;
				case 23:
					num = (short)1136328708;
					num4 = (int)((global::System.IntPtr)num);
					continue;
				case 24:
					if (smartKeyFobButtonTableInnerSection.RadErgoCfgFobConventionalFeature_A41574.Value != 27)
					{
						num = (short)707395599;
						num4 = (int)((global::System.IntPtr)num);
						continue;
					}
					return false;
				case 25:
					if (smartKeyFobButtonTableInnerSection.RadErgoCfgFobConventionalFeature_A41574.Value != 67)
					{
						num = (short)2118058000;
						num4 = (int)((global::System.IntPtr)num);
						continue;
					}
					return false;
				case 26:
					if (smartKeyFobButtonTableInnerSection.RadErgoCfgFobConventionalFeature_A41574.Value != 209)
					{
						num = (short)551878663;
						num4 = (int)((global::System.IntPtr)num);
						continue;
					}
					return false;
				case 27:
					num = (short)1131675658;
					num4 = (int)((global::System.IntPtr)num);
					continue;
				case 28:
					if (smartKeyFobButtonTableInnerSection.RadErgoCfgFobConventionalFeature_A41574.Value != 212)
					{
						num = (short)397934594;
						num4 = (int)((global::System.IntPtr)num);
						continue;
					}
					return false;
				case 29:
					goto IL_3EB;
				}
				goto IL_D3;
			}
			IL_3EB:
			return false;
			IL_D3:
			smartKeyFobButtonTableInnerSection = (self as global::Motorola.MackinawCPS.CoreFeatures.SmartKeyFob.SmartKeyFobButtonTableInnerSection);
			num = (short)625868806;
			num4 = (int)((global::System.IntPtr)num);
			goto IL_55;
		}

		// Token: 0x060076FF RID: 30463 RVA: 0x006B6F28 File Offset: 0x006B5128
		internal static bool conFobTrunkingTriggerProRSMButTableFeature(global::AcpCommonLib.IAcpFeatureSection self)
		{
			short num = (short)1455095808;
			short num2 = num;
			num = (short)440451311;
			short num3 = num;
			num = (short)1952891119;
			switch (num3 == num)
			{
			}
			num = (short)1110179841;
			if (num != 0)
			{
			}
			num = (short)2120941568;
			if (num != 0)
			{
			}
			global::AcpCommonLib.FeatureManager.GetFeature(2042)[0][10091].EmbeddedRecset.CalculateValidity();
			global::AcpCommonLib.FeatureManager.GetFeature(2036)[0][10079].EmbeddedRecset.CalculateValidity();
			return true;
		}

		// Token: 0x06007700 RID: 30464 RVA: 0x006B701C File Offset: 0x006B521C
		public static bool ConTrunkingFobFeaturesValid(global::AcpCommonLib.IAcpFeatureSection self, int index)
		{
			short num = (short)322961408;
			int num2 = (int)num;
			switch (num2)
			{
			default:
			{
				switch (0)
				{
				case 0:
					goto IL_27A;
				}
				bool flag;
				global::AcpCommonLib.IAcpRecordset embeddedRecset;
				global::Motorola.MackinawCPS.CoreFeatures.SmartKeyFob.SmartKeyFobButtonTableInnerSection smartKeyFobButtonTableInnerSection;
				global::AcpBusinessLayer.AcpListField switchTrunkingSwitchesPosition2_A;
				global::Motorola.MackinawCPS.CoreFeatures.RemoteSpeakerMic.RSMButtonInnerRecset rsmbuttonInnerRecset;
				global::Motorola.MackinawCPS.CoreFeatures.RadioWide.Features features;
				global::Motorola.MackinawCPS.CoreFeatures.RadioErgonomicsWide.RadioErgonomicsWide radioErgonomicsWide;
				global::AcpBusinessLayer.AcpListField switchConventionalSwitchesPosition2_A;
				global::AcpBusinessLayer.AcpListField switchTrunkingSwitchesPosition5_A;
				global::AcpBusinessLayer.AcpListField switchConventionalSwitchesPosition5_A;
				global::AcpBusinessLayer.AcpListField switchTrunkingSwitchesPosition4_A;
				global::AcpBusinessLayer.AcpListField switchTrunkingSwitchesPosition1_A;
				global::AcpBusinessLayer.AcpListField switchConventionalSwitchesPosition1_A;
				global::AcpBusinessLayer.AcpListField switchConventionalSwitchesPosition3_A;
				global::AcpBusinessLayer.AcpListField switchConventionalSwitchesPosition4_A;
				global::AcpBusinessLayer.AcpListField switchTrunkingSwitchesPosition3_A;
				global::AcpBusinessLayer.AcpListField emerWideManDownTrigger_A;
				for (;;)
				{
					IL_27:
					int num3;
					int num4;
					int num5;
					bool flag2;
					global::AcpCommonLib.IAcpRecordset feature;
					int num6;
					switch (num2)
					{
					case 0:
						flag = false;
						num = (short)332857445;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 1:
						num = (short)1694105723;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 2:
						num = (short)830603317;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 3:
						num3 = 0;
						num = (short)578224220;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 4:
						num = (short)1920991281;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 5:
						if (index <= 87)
						{
							num = (short)392167498;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)1799553106;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 6:
						if (embeddedRecset != null)
						{
							num = (short)869859419;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return flag;
					case 7:
						if (num4 >= embeddedRecset.Count)
						{
							num = (short)674168934;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)36569165;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 8:
						if (smartKeyFobButtonTableInnerSection.RadErgoCfgFobConventionalFeature_A41574.Value != 212)
						{
							num = (short)743112704;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return flag;
					case 9:
						if (index != 33)
						{
							num = (short)2081161360;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)161808451;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 10:
						return flag;
					case 11:
						num = (short)524351;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 12:
						if (switchTrunkingSwitchesPosition2_A.Value != 33)
						{
							num = (short)865796206;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_1822;
					case 13:
						return flag;
					case 14:
						num = (short)1717174358;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 15:
						return flag;
					case 16:
						if (index != 27)
						{
							num = (short)1692205102;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)1668350006;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 17:
						return flag;
					case 18:
						if (index != 87)
						{
							num = (short)511246404;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)966918208;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 19:
					{
						global::Motorola.MackinawCPS.CoreFeatures.MenuItems.MenuItems menuItems;
						if (menuItems.General.DispMenuConventionalSelectedMenuItems_A21736.Items[num5].ItemName == global::CommonResources.AcgResources.ID_SCAN)
						{
							num = (short)665976972;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_B90;
					}
					case 20:
						if (num3 >= rsmbuttonInnerRecset.Count)
						{
							num = (short)37683325;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)707395628;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 21:
						return flag;
					case 22:
						num = (short)59834494;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 23:
						if (index - 290 > 1)
						{
							num = (short)403505281;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						flag = features.RadWideFeaturesChannelFallbackEnableValue;
						num = (short)157220934;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 24:
						if (radioErgonomicsWide.Advanced.RadErgoWideAdvancedSideButtonsLockEnable_A38725.Value)
						{
							num = (short)1206386819;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return flag;
					case 25:
						num = (short)1729888286;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 26:
						goto IL_10BD;
					case 27:
					{
						global::Motorola.MackinawCPS.CoreFeatures.MenuItems.MenuItems menuItems;
						if (num5 >= menuItems.General.DispMenuConventionalSelectedMenuItems_A21736.Items.Count)
						{
							goto IL_10F2;
						}
						num = (short)27328531;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 28:
						if (switchConventionalSwitchesPosition2_A.Value != 33)
						{
							num = (short)18546766;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_1822;
					case 29:
						if (smartKeyFobButtonTableInnerSection.RadErgoCfgFobConventionalFeature_A41574.Value != 235)
						{
							num = (short)993919048;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return flag;
					case 30:
						flag2 = (switchTrunkingSwitchesPosition5_A.Value != 33);
						goto IL_A5D;
					case 31:
						num = (short)1644560396;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 32:
						if (smartKeyFobButtonTableInnerSection.RadErgoCfgFobConventionalFeature_A41574.Value != 66)
						{
							num = (short)487719046;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return flag;
					case 33:
						return flag;
					case 34:
						return flag;
					case 35:
						return flag;
					case 36:
						if (smartKeyFobButtonTableInnerSection.RadErgoCfgFobConventionalFeature_A41574.Value != 88)
						{
							num = (short)567935021;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return flag;
					case 37:
						return flag;
					case 38:
					{
						global::Motorola.MackinawCPS.CoreFeatures.MenuItems.MenuItems menuItems = feature[0] as global::Motorola.MackinawCPS.CoreFeatures.MenuItems.MenuItems;
						num5 = 0;
						num = (short)1418330154;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 39:
						return flag;
					case 40:
						if (flag)
						{
							num = (short)116981836;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return flag;
					case 41:
						return flag;
					case 42:
						goto IL_10BD;
					case 43:
						num = (short)479920134;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 44:
						if ((rsmbuttonInnerRecset[num3] as global::Motorola.MackinawCPS.CoreFeatures.RemoteSpeakerMic.RSMButtonInner).RSMButtonInnerSection.RadErgoCfgRSMTrunkingBCO_A19741.Value != 151)
						{
							num = (short)963444750;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_FC7;
					case 45:
						flag = false;
						num = (short)1944715297;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 46:
						num = (short)189988873;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 47:
						return flag;
					case 48:
						if (smartKeyFobButtonTableInnerSection.RadErgoCfgFobConventionalFeature_A41574.Value != 214)
						{
							num = (short)1061027929;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return flag;
					case 49:
						if (switchConventionalSwitchesPosition5_A.Value != 33)
						{
							num = (short)814809099;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_1822;
					case 50:
						flag = false;
						num = (short)1069809703;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 51:
						goto IL_14E8;
					case 52:
						goto IL_4DD;
					case 53:
						if (index != 88)
						{
							num = (short)56098838;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)1638400036;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 54:
						if (smartKeyFobButtonTableInnerSection.RadErgoCfgFobConventionalFeature_A41574.Value != 27)
						{
							num = (short)642187335;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return flag;
					case 55:
						return flag;
					case 56:
						flag = false;
						num = (short)1073872980;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 57:
						flag = false;
						num = (short)992935977;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 58:
						if (switchTrunkingSwitchesPosition4_A.Value != 33)
						{
							num = (short)727056409;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_1822;
					case 59:
						num = (short)899153948;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 60:
						if (smartKeyFobButtonTableInnerSection.RadErgoCfgFobConventionalFeature_A41574.Value != 236)
						{
							num = (short)1861222530;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return flag;
					case 61:
					{
						global::Motorola.MackinawCPS.CoreFeatures.MenuItems.MenuItems menuItems;
						if (num6 >= menuItems.General.DispMenuTrunkingSelectedMenuItems_A21735.Items.Count)
						{
							num = (short)476250202;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)5832779;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 62:
						return flag;
					case 63:
						if (switchTrunkingSwitchesPosition1_A.Value != 33)
						{
							num = (short)1838022687;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_1822;
					case 64:
						if (smartKeyFobButtonTableInnerSection.RadErgoCfgFobConventionalFeature_A41574.Value != 87)
						{
							num = (short)1711145039;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return flag;
					case 65:
						return flag;
					case 66:
						return flag;
					case 67:
						if (switchConventionalSwitchesPosition1_A.Value != 33)
						{
							num = (short)1238106171;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_1822;
					case 68:
						num = (short)904265775;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 69:
						if (switchConventionalSwitchesPosition3_A.Value != 33)
						{
							num = (short)549912681;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_1822;
					case 70:
						return flag;
					case 71:
						flag = false;
						num = (short)193003530;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 72:
						flag = false;
						num = (short)902561847;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 73:
						if (smartKeyFobButtonTableInnerSection.RadErgoCfgFobConventionalFeature_A41574.Value != 209)
						{
							num = (short)2100822119;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return flag;
					case 74:
						num = (short)1876033651;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 75:
					{
						global::Motorola.MackinawCPS.CoreFeatures.MenuItems.MenuItems menuItems;
						if (menuItems.General.DispMenuTrunkingSelectedMenuItems_A21735.Items[num6].ItemName == global::CommonResources.AcgResources.ID_SCAN)
						{
							num = (short)1762984053;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_1714;
					}
					case 76:
						num = (short)824508509;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 77:
						if ((embeddedRecset[num4] as global::Motorola.MackinawCPS.CoreFeatures.Buttons.PortableButtonInner).PortableButtonInnerSection.BtnTrunkingPortableTrunkingBCO_A19545.Value != 148)
						{
							num = (short)301138007;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_C1E;
					case 78:
						num = (short)1555693637;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 79:
						flag = false;
						num = (short)650510442;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 80:
						num6 = 0;
						num = (short)844365965;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 81:
						flag = false;
						num = (short)608632845;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 82:
						if (index <= 217)
						{
							num = (short)373424130;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)2134114404;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 83:
						return flag;
					case 84:
						return flag;
					case 85:
						goto IL_B90;
					case 86:
						if ((rsmbuttonInnerRecset[num3] as global::Motorola.MackinawCPS.CoreFeatures.RemoteSpeakerMic.RSMButtonInner).RSMButtonInnerSection.RadErgoCfgRSMlTrunkingFeature_A19742.Value == 31)
						{
							num = (short)820904043;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_FC7;
					case 87:
						num = (short)2024210541;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 88:
						if (switchConventionalSwitchesPosition4_A.Value != 33)
						{
							num = (short)469958660;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_1822;
					case 89:
						flag = false;
						num = (short)1488388113;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 90:
						num = (short)191103088;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 91:
						num4 = 0;
						num = (short)349831276;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 92:
						goto IL_F15;
					case 93:
						if (feature != null)
						{
							num = (short)1001914513;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return flag;
					case 94:
						return flag;
					case 95:
						goto IL_1714;
					case 96:
						flag2 = false;
						goto IL_A5D;
					case 97:
						if (flag)
						{
							num = (short)887685163;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return flag;
					case 98:
						goto IL_187F;
					case 99:
						if (switchConventionalSwitchesPosition1_A.Value == 81)
						{
							num = (short)1759576114;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return flag;
					case 100:
						if (index != 235)
						{
							num = (short)1886650369;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)1693450269;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 101:
						return flag;
					case 102:
						num = (short)874184787;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 103:
						flag = false;
						num = (short)1195507747;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 104:
						return flag;
					case 105:
						num = (short)1753940056;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 106:
						return flag;
					case 107:
						flag = false;
						num = (short)151388211;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 108:
						goto IL_187F;
					case 109:
						if ((embeddedRecset[num4] as global::Motorola.MackinawCPS.CoreFeatures.Buttons.PortableButtonInner).PortableButtonInnerSection.BtnTrunkingPortableButtonFeature_A19546.Value == 31)
						{
							num = (short)1449001041;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_C1E;
					case 110:
						num = (short)1543438469;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 111:
						num = (short)642842682;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 112:
						return flag;
					case 113:
						if (smartKeyFobButtonTableInnerSection.RadErgoCfgFobConventionalFeature_A41574.Value != 64)
						{
							num = (short)1662910596;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return flag;
					case 114:
						num = (short)1960247317;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 115:
						if (index <= 33)
						{
							num = (short)1019936907;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)796196980;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 116:
						switch (index)
						{
						case 61:
							num = (short)1794834456;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 62:
						case 63:
							return flag;
						case 64:
							num = (short)1400242289;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 65:
							num = (short)712245385;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 66:
							num = (short)1422852128;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 67:
							num = (short)983695478;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						default:
							num = (short)1955463289;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						break;
					case 117:
						flag = false;
						num = (short)1367539807;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 118:
						if (smartKeyFobButtonTableInnerSection.RadErgoCfgFobConventionalFeature_A41574.Value != 67)
						{
							num = (short)1228537978;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return flag;
					case 119:
						goto IL_F15;
					case 120:
					{
						num = (short)1899683865;
						short num7 = num;
						num = (short)1663426585;
						switch ((num7 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_10F2;
						default:
							num = (short)1365311488;
							if (num != 0)
							{
							}
							if (rsmbuttonInnerRecset != null)
							{
								num = (short)676265987;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							goto IL_14E8;
						}
						break;
					}
					case 121:
						num = (short)568983679;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 122:
						flag = false;
						num = (short)609222722;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 123:
						if (index != 236)
						{
							num = (short)1147601031;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)1346240572;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 124:
						if (smartKeyFobButtonTableInnerSection.RadErgoCfgFobConventionalFeature_A41574.Value != 149)
						{
							num = (short)885456952;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return flag;
					case 125:
						goto IL_14E8;
					case 126:
						if (index != 149)
						{
							num = (short)1767440522;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)196732;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 127:
						if (index != 81)
						{
							num = (short)1719271566;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)246939747;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 128:
						flag = false;
						num = (short)1605238785;
						if (num != 0)
						{
						}
						num = (short)2017525822;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 129:
						num = (short)456720421;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 130:
						flag = false;
						num = (short)320864360;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 131:
						num = (short)98828408;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 132:
						flag = false;
						num = (short)443023375;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 133:
						if (switchTrunkingSwitchesPosition3_A.Value != 33)
						{
							num = (short)1718026351;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_1822;
					case 134:
						flag = false;
						num = (short)1909981249;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 135:
						num = (short)335347735;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 136:
						switch (index)
						{
						case 209:
							num = (short)198705225;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 210:
						case 213:
						case 215:
						case 216:
							return flag;
						case 211:
							num = (short)169803922;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 212:
							num = (short)1454571528;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 214:
							num = (short)869597232;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 217:
							flag = (emerWideManDownTrigger_A.Value != 0);
							num = (short)1150812194;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						default:
							num = (short)573177970;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						break;
					case 137:
						if (smartKeyFobButtonTableInnerSection.RadErgoCfgFobConventionalFeature_A41574.Value != 65)
						{
							num = (short)1949171840;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return flag;
					case 138:
						num = (short)41418888;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 139:
						num = (short)396951568;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 140:
						flag = false;
						num = (short)1359151189;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 141:
						goto IL_4DD;
					case 142:
						num = (short)1324351506;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 143:
					{
						num = (short)1932460032;
						short num8 = num;
						if (feature.Count != 0)
						{
							num = (short)40828966;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return flag;
					}
					case 144:
						num = (short)1519976542;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 145:
						num = (short)860553359;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 146:
						if (smartKeyFobButtonTableInnerSection.RadErgoCfgFobConventionalFeature_A41574.Value != 211)
						{
							num = (short)89849913;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return flag;
					}
					goto IL_27A;
					IL_4DD:
					num = (short)1958215741;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_A5D:
					flag = flag2;
					feature = global::AcpCommonLib.FeatureManager.GetFeature(2088);
					num = (short)1798963240;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_B90:
					num5++;
					num = (short)543883290;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_C1E:
					num4++;
					num = (short)1190658146;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_F15:
					num = (short)1844838420;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_FC7:
					num3++;
					num = (short)1754136695;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_10BD:
					num = (short)1323106331;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_10F2:
					num = (short)500957264;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_14E8:
					num = (short)1028849761;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_1714:
					num6++;
					num = (short)488505396;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_1822:
					num = (short)1307443296;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_187F:
					num = (short)1809055751;
					num2 = (int)((global::System.IntPtr)num);
				}
				return flag;
				IL_27A:
				smartKeyFobButtonTableInnerSection = (self as global::Motorola.MackinawCPS.CoreFeatures.SmartKeyFob.SmartKeyFobButtonTableInnerSection);
				switchConventionalSwitchesPosition1_A = smartKeyFobButtonTableInnerSection.RefSwitches.ConventionalSwitches.SwitchConventionalSwitchesPosition1_A7734;
				switchConventionalSwitchesPosition2_A = smartKeyFobButtonTableInnerSection.RefSwitches.ConventionalSwitches.SwitchConventionalSwitchesPosition2_A7735;
				switchConventionalSwitchesPosition3_A = smartKeyFobButtonTableInnerSection.RefSwitches.ConventionalSwitches.SwitchConventionalSwitchesPosition3_A7737;
				switchConventionalSwitchesPosition4_A = smartKeyFobButtonTableInnerSection.RefSwitches.ConventionalSwitches.SwitchConventionalSwitchesPosition4_A21530;
				switchConventionalSwitchesPosition5_A = smartKeyFobButtonTableInnerSection.RefSwitches.ConventionalSwitches.SwitchConventionalSwitchesPosition5_A21531;
				switchTrunkingSwitchesPosition1_A = smartKeyFobButtonTableInnerSection.RefSwitches.TrunkingSwitches.SwitchTrunkingSwitchesPosition1_A9466;
				switchTrunkingSwitchesPosition2_A = smartKeyFobButtonTableInnerSection.RefSwitches.TrunkingSwitches.SwitchTrunkingSwitchesPosition2_A9467;
				switchTrunkingSwitchesPosition3_A = smartKeyFobButtonTableInnerSection.RefSwitches.TrunkingSwitches.SwitchTrunkingSwitchesPosition3_A9468;
				switchTrunkingSwitchesPosition4_A = smartKeyFobButtonTableInnerSection.RefSwitches.TrunkingSwitches.SwitchTrunkingSwitchesPosition4_A21534;
				switchTrunkingSwitchesPosition5_A = smartKeyFobButtonTableInnerSection.RefSwitches.TrunkingSwitches.SwitchTrunkingSwitchesPosition5_A21535;
				rsmbuttonInnerRecset = ((global::AcpCommonLib.FeatureManager.GetFeature(2036) as global::Motorola.MackinawCPS.CoreFeatures.RemoteSpeakerMic.RemoteSpeakerMicRecset)[0][10079].EmbeddedRecset as global::Motorola.MackinawCPS.CoreFeatures.RemoteSpeakerMic.RSMButtonInnerRecset);
				flag = true;
				radioErgonomicsWide = (global::AcpCommonLib.FeatureManager.GetFeature(2033)[0] as global::Motorola.MackinawCPS.CoreFeatures.RadioErgonomicsWide.RadioErgonomicsWide);
				embeddedRecset = global::AcpCommonLib.FeatureManager.GetFeature(2042)[0][10091].EmbeddedRecset;
				global::AcpCommonLib.IAcpFeatureNode acpFeatureNode = global::AcpCommonLib.FeatureManager.GetFeature(2038)[0];
				features = (global::AcpCommonLib.FeatureManager.GetFeature(2045)[0][10105] as global::Motorola.MackinawCPS.CoreFeatures.RadioWide.Features);
				emerWideManDownTrigger_A = ((global::AcpCommonLib.FeatureManager.GetFeature(2032) as global::Motorola.MackinawCPS.CoreFeatures.EmergencyWide.EmergencyWideRecset)[0][10639] as global::Motorola.MackinawCPS.CoreFeatures.EmergencyWide.ManDown).EmerWideManDownTrigger_A40001;
				global::AcpCommonLib.IAcpRecordset embeddedRecset2 = global::AcpCommonLib.FeatureManager.GetFeature(4130)[0][10747].EmbeddedRecset;
				num = (short)851968005;
				num2 = (int)((global::System.IntPtr)num);
				goto IL_27;
			}
			}
		}
	}
}
