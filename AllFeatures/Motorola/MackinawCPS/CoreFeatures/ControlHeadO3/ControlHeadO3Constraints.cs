using System;
using System.Collections.Generic;
using AcpBusinessLayer;
using AcpBusinessLayer.UndoRedo;
using AcpCommonLib;
using AcpCommonLib.UndoRedo;
using Motorola.MackinawCPS.CoreFeatures.ActionConsolidation;
using Motorola.MackinawCPS.CoreFeatures.Buttons;
using Motorola.MackinawCPS.CoreFeatures.ControlHeadE5;
using Motorola.MackinawCPS.CoreFeatures.ControlHeadO2;
using Motorola.MackinawCPS.CoreFeatures.ControlHeadO5;
using Motorola.MackinawCPS.CoreFeatures.ControlHeadO7;
using Motorola.MackinawCPS.CoreFeatures.ControlHeadO9;
using Motorola.MackinawCPS.CoreFeatures.EmergencyWide;
using Motorola.MackinawCPS.CoreFeatures.KeypadMicAndAccessories;
using Motorola.MackinawCPS.CoreFeatures.RadioWide;
using Motorola.MackinawCPS.CoreFeatures.TrunkingEmergencyProfiles;

namespace Motorola.MackinawCPS.CoreFeatures.ControlHeadO3
{
	// Token: 0x020003B8 RID: 952
	public static class ControlHeadO3Constraints
	{
		// Token: 0x0600896F RID: 35183 RVA: 0x007FE94C File Offset: 0x007FCB4C
		public static bool ConControlHeadFeaturesSelect(global::AcpCommonLib.IAcpFeatureSection self, int index)
		{
			short num = (short)1371013120;
			int num2 = (int)num;
			switch (num2)
			{
			default:
			{
				switch (0)
				{
				case 0:
					goto IL_EB;
				}
				bool result;
				global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO3.O3HHCHButtonInnerSection o3HHCHButtonInnerSection;
				global::Motorola.MackinawCPS.CoreFeatures.RadioWide.Features features;
				global::Motorola.MackinawCPS.CoreFeatures.EmergencyWide.EmergencyWide emergencyWide;
				global::Motorola.MackinawCPS.CoreFeatures.TrunkingEmergencyProfiles.TrunkingEmergencyProfilesRecset trunkingEmergencyProfilesRecset;
				global::AcpBusinessLayer.AcpListField radErgoWideControlHeadMultipleControlHeadStyle_A;
				global::AcpBusinessLayer.AcpField<bool> radErgoWideControlHeadMultiControlHead_A;
				for (;;)
				{
					IL_28:
					bool flag;
					bool flag2;
					bool flag3;
					switch (num2)
					{
					case 0:
						num = (short)1956249645;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 1:
						num = (short)771031044;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 2:
						return result;
					case 3:
						num = (short)320471082;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 4:
						if (index != 140)
						{
							num = (short)1505624067;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						result = (o3HHCHButtonInnerSection.RefRadioWide.DualRadio.RadWideDualRadioSelection_A42236.Value != 0);
						num = (short)468844583;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 5:
						if (index - 290 > 1)
						{
							num = (short)59637771;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						result = features.RadWideFeaturesChannelFallbackEnableValue;
						num = (short)1599668226;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 6:
						return result;
					case 7:
						num = (short)1815871493;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 8:
						if (o3HHCHButtonInnerSection.CntrlHeadO3TrunkingO3HHCHButtonBCO_A19749.Value != 156)
						{
							num = (short)1435172864;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_40D;
					case 9:
						return result;
					case 10:
						num = (short)117702686;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 11:
						num = (short)1600389154;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 12:
						if (index != 217)
						{
							num = (short)1625817132;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						result = (emergencyWide.EmergencyWideImpactDetection.EmerWideImpactDetectionConfigLevel_A43384.Value != 0);
						num = (short)1456472070;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 13:
						flag = true;
						goto IL_74D;
					case 14:
						num = (short)73596936;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 15:
					{
						num = (short)955802512;
						short num3 = num;
						num = (short)1738761104;
						switch ((num3 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_8BB;
						default:
							num = (short)1782054912;
							if (num != 0)
							{
							}
							result = false;
							num = (short)585236501;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						break;
					}
					case 16:
						num = (short)418578456;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 17:
						flag2 = false;
						goto IL_837;
					case 18:
						flag3 = true;
						goto IL_98A;
					case 19:
						return result;
					case 20:
						if (index != 267)
						{
							num = (short)1019543559;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)1679032356;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 21:
						return result;
					case 22:
						if (index <= 163)
						{
							num = (short)1367146512;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)748159022;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 23:
						if (o3HHCHButtonInnerSection.CntrlHeadO3TrunkingO3HHCHButtonBCO_A19749.Value != 156)
						{
							num = (short)474415119;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return result;
					case 24:
						if (index != 138)
						{
							num = (short)1454440449;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)1205665835;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 25:
					{
						num = (short)231538689;
						if (num != 0)
						{
						}
						if (index != 266)
						{
							num = (short)1084424202;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						result = false;
						global::System.Collections.Generic.IEnumerator<global::AcpBusinessLayer.FeatureNode> enumerator = trunkingEmergencyProfilesRecset.GetEnumerator();
						num = (short)960495644;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 26:
						num = (short)1960443916;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 27:
						goto IL_8BB;
					case 28:
						try
						{
							num = (short)830537729;
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
										num = (short)916520964;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									num = (short)843513861;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 1:
									switch (0)
									{
									case 0:
										goto IL_2D9;
									}
									continue;
								case 3:
									goto IL_39A;
								case 4:
									num = (short)785711107;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 5:
								{
									global::System.Collections.Generic.IEnumerator<global::AcpBusinessLayer.FeatureNode> enumerator;
									if (((global::Motorola.MackinawCPS.CoreFeatures.TrunkingEmergencyProfiles.TrunkingEmergencyProfiles)enumerator.Current).EmergencyCompatibilityOptionsTrunking.EmergencyExitControl_43341.Value == 3)
									{
										num = (short)1816723462;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									break;
								}
								case 6:
									result = true;
									num = (short)1659961346;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								IL_2DB:
								num = (short)1822687232;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								IL_2D9:
								goto IL_2DB;
							}
							IL_39A:
							goto IL_657;
						}
						finally
						{
							num = (short)1398865920;
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
										goto IL_3D2;
									}
									continue;
								case 1:
									enumerator.Dispose();
									num = (short)1474035714;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 2:
									goto IL_40A;
								}
								IL_3D2:
								if (enumerator == null)
								{
									break;
								}
								num = (short)980221953;
								num2 = (int)((global::System.IntPtr)num);
							}
							IL_40A:;
						}
						goto IL_40D;
						IL_657:
						num = (short)730660887;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 29:
						flag2 = (radErgoWideControlHeadMultipleControlHeadStyle_A.Value == 0);
						goto IL_837;
					case 30:
						return result;
					case 31:
						if (radErgoWideControlHeadMultipleControlHeadStyle_A.Value == 1)
						{
							num = (short)347799592;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_1A0;
					case 32:
						return result;
					case 33:
						return result;
					case 34:
						return result;
					case 35:
						goto IL_1A0;
					case 36:
						if (o3HHCHButtonInnerSection.CntrlHeadO3TrunkingO3HHCHButtonBCO_A19749.Value != 157)
						{
							num = (short)1654390798;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_40D;
					case 37:
						num = (short)509935645;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 38:
						flag = !radErgoWideControlHeadMultiControlHead_A.Value;
						goto IL_74D;
					case 39:
						return result;
					case 40:
						num = (short)413597737;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 41:
						if (!radErgoWideControlHeadMultiControlHead_A.Value)
						{
							num = (short)587005987;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)1271136269;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 42:
						if (index != 163)
						{
							num = (short)295436315;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)827195423;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 43:
						if (radErgoWideControlHeadMultiControlHead_A.Value)
						{
							num = (short)388825125;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)1879244817;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 44:
						num = (short)1045233689;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 45:
						flag3 = (o3HHCHButtonInnerSection.CntrlHeadO3TrunkingO3HHCHButtonBCO_A19749.Value == 155);
						goto IL_98A;
					case 46:
						if (index <= 266)
						{
							num = (short)770834458;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)169607188;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_EB;
					IL_1A0:
					num = (short)1310130214;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_40D:
					num = (short)241696786;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_74D:
					result = flag;
					num = (short)1159331859;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_837:
					result = flag2;
					num = (short)2043609088;
					short num4 = num;
					num = (short)882638880;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_8BB:
					num = (short)1456406561;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_98A:
					result = flag3;
					num = (short)210698249;
					num2 = (int)((global::System.IntPtr)num);
				}
				return result;
				IL_EB:
				o3HHCHButtonInnerSection = (self as global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO3.O3HHCHButtonInnerSection);
				trunkingEmergencyProfilesRecset = (global::AcpCommonLib.FeatureManager.GetFeature(2076) as global::Motorola.MackinawCPS.CoreFeatures.TrunkingEmergencyProfiles.TrunkingEmergencyProfilesRecset);
				radErgoWideControlHeadMultipleControlHeadStyle_A = o3HHCHButtonInnerSection.RefRadioErgonomicsWide.ControlHead.RadErgoWideControlHeadMultipleControlHeadStyle_A8561;
				radErgoWideControlHeadMultiControlHead_A = o3HHCHButtonInnerSection.RefRadioErgonomicsWide.ControlHead.RadErgoWideControlHeadMultiControlHead_A8550;
				emergencyWide = (global::AcpCommonLib.FeatureManager.GetFeature(2032)[0] as global::Motorola.MackinawCPS.CoreFeatures.EmergencyWide.EmergencyWide);
				features = (global::AcpCommonLib.FeatureManager.GetFeature(2045)[0][10105] as global::Motorola.MackinawCPS.CoreFeatures.RadioWide.Features);
				result = true;
				num = (short)239599638;
				num2 = (int)((global::System.IntPtr)num);
				goto IL_28;
			}
			}
		}

		// Token: 0x06008970 RID: 35184 RVA: 0x007FF33C File Offset: 0x007FD53C
		public static void ConSyncUpDownBtnFeature(global::AcpCommonLib.IAcpFeatureSection self, global::AcpCommonLib.UndoRedo.ContainerTask task)
		{
			short num = (short)2131951616;
			int num2 = (int)num;
			switch (num2)
			{
			default:
			{
				num = (short)1691622182;
				short num3 = num;
				num = (short)695409446;
				global::AcpCommonLib.IAcpRecordset parentRecset;
				switch ((num3 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					IL_140:
					if (parentRecset == null)
					{
						return;
					}
					num = (short)1223426052;
					num2 = (int)((global::System.IntPtr)num);
					break;
				default:
					num = (short)1981546496;
					if (num != 0)
					{
					}
					switch (0)
					{
					case 0:
						goto IL_11A;
					}
					break;
				}
				int num4;
				int num5;
				bool flag;
				for (;;)
				{
					IL_73:
					global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO3.O3NavigationControlsTableInnerSection o3NavigationControlsTableInnerSection;
					switch (num2)
					{
					case 0:
						num4 = o3NavigationControlsTableInnerSection.RadErgoControlO3NaviControlFeature_A41375.Value;
						num5 = num4 + 1;
						num = (short)1061945377;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 1:
						num = (short)408027167;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 2:
						num = (short)1652621328;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 3:
						num = (short)470155294;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 4:
						num = (short)1075118116;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 5:
						num = (short)943652876;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 6:
						flag = true;
						num = (short)1532362791;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 7:
						num = (short)936509468;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 8:
						goto IL_6DB;
					case 9:
						goto IL_3E4;
					case 10:
						if (parentRecset[1] == self.Parent)
						{
							num = (short)1427832838;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_1DD;
					case 11:
						num = (short)143327257;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 12:
						if (num5 == 87)
						{
							num = (short)460193801;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_6E0;
					case 13:
						goto IL_4C0;
					case 14:
						num = (short)1058734115;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 15:
						goto IL_140;
					case 16:
						if (num5 != 64)
						{
							num = (short)203423755;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_3E4;
					case 17:
					{
						num = (short)1063976960;
						short num6 = num;
						num4 = 38;
						num = (short)1686568983;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 18:
						if (num5 == 0)
						{
							num = (short)1165557768;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)338296854;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 19:
						num = (short)356712466;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 20:
						goto IL_51F;
					case 21:
						goto IL_1A1;
					case 22:
						if (num4 != 144)
						{
							num = (short)2026045441;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_3E4;
					case 23:
						goto IL_5FD;
					case 24:
						if (num5 == 38)
						{
							num = (short)523894801;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_5FD;
					case 25:
						if (num5 != 66)
						{
							num = (short)321847301;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_3E4;
					case 26:
						if (o3NavigationControlsTableInnerSection != null)
						{
							num = (short)1135149090;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return;
					case 27:
						if (!flag)
						{
							num = (short)2025914368;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num5 = o3NavigationControlsTableInnerSection.RadErgoControlO3NaviControlFeature_A41375.Value;
						num4 = num5 - 1;
						num = (short)11665432;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 28:
						if (num5 != 143)
						{
							num = (short)914030594;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_3E4;
					case 29:
						if (num4 != 0)
						{
							num = (short)377487379;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return;
					case 30:
						if (num4 != 88)
						{
							num = (short)108068871;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_3E4;
					case 31:
						if (num4 != 65)
						{
							num = (short)1858076686;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_3E4;
					case 32:
						goto IL_1A1;
					case 33:
						if (num4 == 38)
						{
							num = (short)676921381;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_51F;
					case 34:
						num = (short)1710751771;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 35:
						if (num4 != 67)
						{
							num = (short)120586243;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_3E4;
					case 36:
						if (parentRecset.Count < 2)
						{
							num = (short)433389581;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)365887489;
						if (num != 0)
						{
						}
						num = (short)1939603466;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 37:
						num5 = 38;
						num = (short)1392115732;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 38:
						goto IL_408;
					case 39:
						goto IL_1DD;
					}
					goto IL_11A;
					IL_1A1:
					num = (short)1045692445;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_1DD:
					o3NavigationControlsTableInnerSection = (self as global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO3.O3NavigationControlsTableInnerSection);
					num = (short)1602420762;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_3E4:
					num4 = 143;
					num5 = 144;
					num = (short)968425510;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_51F:
					task.AddTask(new global::AcpBusinessLayer.UndoRedo.ModifyDataTask<int>((self.ParentRecset[1] as global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO3.O3NavigationControlsTableInner).O3NavigationControlsTableInnerSection.RadErgoControlO3NaviControlFeature_A41375, num5));
					num = (short)1647902752;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_5FD:
					task.AddTask(new global::AcpBusinessLayer.UndoRedo.ModifyDataTask<int>((self.ParentRecset[0] as global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO3.O3NavigationControlsTableInner).O3NavigationControlsTableInnerSection.RadErgoControlO3NaviControlFeature_A41375, num4));
					num = (short)1435107349;
					num2 = (int)((global::System.IntPtr)num);
				}
				return;
				IL_408:
				goto IL_6E0;
				IL_4C0:
				return;
				IL_6DB:
				return;
				IL_6E0:
				global::Motorola.MackinawCPS.CoreFeatures.ControlHeadE5.ControlHeadE5Constraints.SyncNavigationControlsCPField(task, num4, num5);
				global::Motorola.MackinawCPS.CoreFeatures.ControlHeadE5.ControlHeadE5Constraints.SyncE5NavigationControls(task, num4, num5);
				global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO2.ControlHeadO2Constraints.SyncO2NavigationControls(task, num4, num5);
				global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO7.ControlHeadO7Constraints.SyncO7NavigationControls(task, num4, num5);
				global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO5.ControlHeadO5Constraints.SyncO5NavigationControls(task, num4, num5);
				global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO9.ControlHeadO9Constraints.SyncO9NavigationControls(task, num4, num5);
				global::Motorola.MackinawCPS.CoreFeatures.KeypadMicAndAccessories.KeypadMicAndAccessoriesConstraints.SyncKeypadMicAndAccessoriesNavigationControls(task, num4, num5);
				global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO7.ControlHeadO7Constraints.CalculateValidityForO2O7MFK();
				return;
				IL_11A:
				num4 = 0;
				num5 = 0;
				flag = false;
				parentRecset = self.ParentRecset;
				num = (short)2139619343;
				num2 = (int)((global::System.IntPtr)num);
				goto IL_73;
			}
			}
		}

		// Token: 0x06008971 RID: 35185 RVA: 0x007FFA68 File Offset: 0x007FDC68
		public static void SyncO3NavigationControls(global::AcpCommonLib.UndoRedo.ContainerTask task, int upButtonConfigedFeatureValue, int downButtonConfigedFeatureValue)
		{
			short num = (short)1702690816;
			int num2 = (int)num;
			switch (num2)
			{
			default:
			{
				switch (0)
				{
				case 0:
					goto IL_43;
				}
				global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO3.ControlHeadO3Recset controlHeadO3Recset;
				for (;;)
				{
					IL_28:
					switch (num2)
					{
					case 0:
						return;
					case 1:
					{
						global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO3.O3NavigationControlsTableInnerRecset o3NavigationControlsTableInnerRecset;
						if (o3NavigationControlsTableInnerRecset != null)
						{
							num = (short)2008940547;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return;
					}
					case 2:
					{
						num = (short)488439808;
						short num3 = num;
						global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO3.O3NavigationControlsTableInnerRecset o3NavigationControlsTableInnerRecset = controlHeadO3Recset[0][10732].EmbeddedRecset as global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO3.O3NavigationControlsTableInnerRecset;
						num = (short)1161297921;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 3:
					{
						for (;;)
						{
							num = (short)578457996;
							short num4 = num;
							num = (short)1017614732;
							switch ((num4 == num) ? 1 : 0)
							{
							case 0:
							case 2:
								break;
							default:
								goto IL_BD;
							}
						}
						IL_BD:
						num = (short)1331232768;
						if (num != 0)
						{
						}
						num = (short)2045837313;
						if (num != 0)
						{
						}
						global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO3.O3NavigationControlsTableInnerRecset o3NavigationControlsTableInnerRecset;
						global::AcpBusinessLayer.AcpListField radErgoControlO3NaviControlFeature_A = (o3NavigationControlsTableInnerRecset[0][10733] as global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO3.O3NavigationControlsTableInnerSection).RadErgoControlO3NaviControlFeature_A41375;
						task.AddTask(new global::AcpBusinessLayer.UndoRedo.ModifyDataTask<int>(radErgoControlO3NaviControlFeature_A, upButtonConfigedFeatureValue));
						global::AcpBusinessLayer.AcpListField radErgoControlO3NaviControlFeature_A2 = (o3NavigationControlsTableInnerRecset[1][10733] as global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO3.O3NavigationControlsTableInnerSection).RadErgoControlO3NaviControlFeature_A41375;
						task.AddTask(new global::AcpBusinessLayer.UndoRedo.ModifyDataTask<int>(radErgoControlO3NaviControlFeature_A2, downButtonConfigedFeatureValue));
						num = (short)433913856;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 4:
						if (controlHeadO3Recset != null)
						{
							num = (short)1263206402;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return;
					}
					goto IL_43;
				}
				return;
				IL_43:
				controlHeadO3Recset = (global::AcpCommonLib.FeatureManager.GetFeature(2127) as global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO3.ControlHeadO3Recset);
				num = (short)333119492;
				num2 = (int)((global::System.IntPtr)num);
				goto IL_28;
			}
			}
		}

		// Token: 0x06008972 RID: 35186 RVA: 0x007FFC64 File Offset: 0x007FDE64
		public static void ConSyncCnvDataBtnFeature(global::AcpCommonLib.IAcpFeatureSection self, global::AcpCommonLib.UndoRedo.ContainerTask task)
		{
			short num = (short)744751104;
			int num2 = (int)num;
			switch (num2)
			{
			default:
			{
				switch (0)
				{
				case 0:
					goto IL_19A;
				}
				int num3;
				int featureSectionId;
				global::AcpBusinessLayer.AcpListField acpListField;
				global::AcpBusinessLayer.AcpRecRefField acpRecRefField;
				bool flag2;
				for (;;)
				{
					IL_27:
					global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO9.ConsolidatedActionBCOListInnerRecset consolidatedActionBCOListInnerRecset;
					global::System.Collections.Generic.IEnumerator<global::AcpBusinessLayer.FeatureNode> enumerator;
					global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO7.O7DataButtonInnerRecset o7DataButtonInnerRecset;
					global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO3.ControlHeadO3Recset controlHeadO3Recset;
					global::Motorola.MackinawCPS.CoreFeatures.Buttons.ButtonsRecset buttonsRecset;
					global::Motorola.MackinawCPS.CoreFeatures.Buttons.DataButtonInnerRecset dataButtonInnerRecset;
					global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO9.O9DataButtonInnerRecset o9DataButtonInnerRecset;
					global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO3.DataButtonInnerRecset dataButtonInnerRecset3;
					bool flag;
					global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO9.ControlHeadO9Recset controlHeadO9Recset;
					global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO7.ControlHeadO7Recset controlHeadO7Recset;
					global::Motorola.MackinawCPS.CoreFeatures.RadioWide.RadioWide radioWide;
					switch (num2)
					{
					case 0:
						if (consolidatedActionBCOListInnerRecset != null)
						{
							num = (short)2020540468;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_2257;
					case 1:
						if (num3 != 227)
						{
							num = (short)2096365621;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_1B16;
					case 2:
						goto IL_711;
					case 3:
						goto IL_2257;
					case 4:
					{
						if (featureSectionId != 10090)
						{
							num = (short)1323237465;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						global::Motorola.MackinawCPS.CoreFeatures.Buttons.DataButtonInnerSection dataButtonInnerSection = self as global::Motorola.MackinawCPS.CoreFeatures.Buttons.DataButtonInnerSection;
						num3 = dataButtonInnerSection.BtnConventionalButtonDatatButtonFeature_A22610.Value;
						acpListField = dataButtonInnerSection.BtnTrunkingButtonDatatButtonFeature_A22608;
						num = (short)17367083;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 5:
						goto IL_15FA;
					case 6:
						if (num3 == 228)
						{
							num = (short)1481572442;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_216A;
					case 7:
						try
						{
							num = (short)1416298497;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								switch (num2)
								{
								case 0:
								{
									global::AcpCommonLib.IAcpFeatureNode acpFeatureNode;
									task.AddTask(new global::AcpBusinessLayer.UndoRedo.ModifyDataTask<int>((acpFeatureNode[10608] as global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO9.O9DataButtonInnerSection).RadErgCtrlHeadO9DataButtonCnvFeature_A36528, num3));
									num = (short)1347289092;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 1:
									switch (0)
									{
									case 0:
										goto IL_2004;
									}
									continue;
								case 2:
									num = (short)486277126;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 3:
								{
									global::AcpCommonLib.IAcpFeatureNode acpFeatureNode;
									if (num3 != (acpFeatureNode[10608] as global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO9.O9DataButtonInnerSection).RadErgCtrlHeadO9DataButtonCnvFeature_A36528.Value)
									{
										num = (short)713883648;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									break;
								}
								case 4:
									goto IL_209B;
								case 5:
								{
									if (!enumerator.MoveNext())
									{
										num = (short)1149566978;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									global::AcpCommonLib.IAcpFeatureNode acpFeatureNode = enumerator.Current;
									num = (short)2053046275;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 6:
									goto IL_20F6;
								}
								IL_20A0:
								num = (short)1609433093;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								IL_2004:
								goto IL_20A0;
							}
							IL_209B:
							IL_20F6:
							goto IL_22B;
						}
						finally
						{
							num = (short)22872064;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								switch (num2)
								{
								case 0:
									switch (0)
									{
									case 0:
										goto IL_212D;
									}
									continue;
								case 1:
									enumerator.Dispose();
									num = (short)388562946;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 2:
									goto IL_2167;
								}
								IL_212D:
								if (enumerator == null)
								{
									break;
								}
								num = (short)1485635585;
								num2 = (int)((global::System.IntPtr)num);
							}
							IL_2167:;
						}
						goto IL_216A;
					case 8:
						return;
					case 9:
						goto IL_15FA;
					case 10:
					{
						if (featureSectionId != 10713)
						{
							num = (short)1240924242;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO7.O7DataButtonInnerSection o7DataButtonInnerSection = self as global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO7.O7DataButtonInnerSection;
						num3 = o7DataButtonInnerSection.RadErgCtrlHeadO7DataButtonCnvFeature_A41299.Value;
						acpRecRefField = o7DataButtonInnerSection.CHO7DataButtonConvIndex_A41417;
						acpListField = o7DataButtonInnerSection.RadErgCtrlHeadO7DataButtonTrkFeature_A41297;
						num = (short)102694957;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 11:
						if (o7DataButtonInnerRecset != null)
						{
							num = (short)2104033302;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_1B9E;
					case 12:
						num = (short)363986948;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 13:
						if (controlHeadO3Recset != null)
						{
							num = (short)501547050;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_C3B;
					case 14:
						num = (short)943194173;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 15:
						goto IL_90C;
					case 16:
						goto IL_711;
					case 17:
						dataButtonInnerRecset = (buttonsRecset[0][10089].EmbeddedRecset as global::Motorola.MackinawCPS.CoreFeatures.Buttons.DataButtonInnerRecset);
						num = (short)1199702099;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 18:
						enumerator = o9DataButtonInnerRecset.GetEnumerator();
						num = (short)1019215879;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 19:
						if (num3 == 227)
						{
							num = (short)2143420430;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_2257;
					case 20:
						goto IL_1556;
					case 21:
						if (featureSectionId != 10212)
						{
							num = (short)417792040;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_1E9E;
					case 22:
						enumerator = o7DataButtonInnerRecset.GetEnumerator();
						num = (short)1176961108;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 23:
						try
						{
							num = (short)1959395330;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								switch (num2)
								{
								case 0:
								{
									if (!enumerator.MoveNext())
									{
										num = (short)289931268;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									global::AcpCommonLib.IAcpFeatureNode acpFeatureNode2 = enumerator.Current;
									num = (short)610795526;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 1:
									goto IL_FB6;
								case 2:
									switch (0)
									{
									case 0:
										goto IL_F20;
									}
									continue;
								case 3:
								{
									global::AcpCommonLib.IAcpFeatureNode acpFeatureNode2;
									task.AddTask(new global::AcpBusinessLayer.UndoRedo.ModifyDataTask<int>((acpFeatureNode2[10212] as global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO3.DataButtonInnerSection).CntrlHeadO3TrunkingO3DatatButtonFeature_A22597, num3));
									num = (short)1477574657;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 4:
									num = (short)1786445829;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 5:
									goto IL_1013;
								case 6:
								{
									global::AcpCommonLib.IAcpFeatureNode acpFeatureNode2;
									if (num3 != (acpFeatureNode2[10212] as global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO3.DataButtonInnerSection).CntrlHeadO3TrunkingO3DatatButtonFeature_A22597.Value)
									{
										num = (short)947650563;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									break;
								}
								}
								IL_FBB:
								num = (short)140967936;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								IL_F20:
								goto IL_FBB;
							}
							IL_FB6:
							IL_1013:
							goto IL_399;
						}
						finally
						{
							num = (short)2032402434;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								switch (num2)
								{
								case 0:
									enumerator.Dispose();
									num = (short)1973420033;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 1:
									goto IL_1083;
								case 2:
									switch (0)
									{
									case 0:
										goto IL_104A;
									}
									continue;
								}
								IL_104A:
								if (enumerator == null)
								{
									break;
								}
								num = (short)144834560;
								num2 = (int)((global::System.IntPtr)num);
							}
							IL_1083:;
						}
						goto IL_1086;
					case 24:
					{
						global::Motorola.MackinawCPS.CoreFeatures.KeypadMicAndAccessories.KeypadMicAndAccessoriesRecset keypadMicAndAccessoriesRecset;
						global::Motorola.MackinawCPS.CoreFeatures.KeypadMicAndAccessories.DataButtonInnerRecset dataButtonInnerRecset2 = keypadMicAndAccessoriesRecset[0][10228].EmbeddedRecset as global::Motorola.MackinawCPS.CoreFeatures.KeypadMicAndAccessories.DataButtonInnerRecset;
						num = (short)783613988;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 25:
						if (dataButtonInnerRecset != null)
						{
							num = (short)168362060;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_E7A;
					case 26:
						goto IL_AF9;
					case 27:
						enumerator = o9DataButtonInnerRecset.GetEnumerator();
						num = (short)84279368;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 28:
						if (dataButtonInnerRecset != null)
						{
							num = (short)170197071;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_B88;
					case 29:
					{
						num = (short)1423468682;
						short num4 = num;
						num = (short)787114122;
						switch ((num4 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_767;
						default:
						{
							num = (short)784138240;
							if (num != 0)
							{
							}
							global::Motorola.MackinawCPS.CoreFeatures.KeypadMicAndAccessories.DataButtonInnerRecset dataButtonInnerRecset2;
							enumerator = dataButtonInnerRecset2.GetEnumerator();
							num = (short)2144403503;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						}
						break;
					}
					case 30:
						if (dataButtonInnerRecset3 != null)
						{
							num = (short)1170407486;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_399;
					case 31:
						try
						{
							num = (short)2126053388;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								switch (num2)
								{
								case 0:
								{
									global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO9.ConsolidatedActionBCOListInner consolidatedActionBCOListInner;
									task.AddTask(new global::AcpBusinessLayer.UndoRedo.ModifyRecRefDataTask(consolidatedActionBCOListInner.ConsolidatedActionBCOListInnerSection.RadErgoControlO9ACBCOListIndex_A36668, acpRecRefField.UIValue));
									num = (short)12582914;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 1:
									num = (short)1515520011;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 2:
									goto IL_16CC;
								case 3:
									goto IL_1884;
								case 4:
									goto IL_1758;
								case 5:
								{
									if (!enumerator.MoveNext())
									{
										num = (short)1894187021;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO9.ConsolidatedActionBCOListInner consolidatedActionBCOListInner = (global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO9.ConsolidatedActionBCOListInner)enumerator.Current;
									num = (short)417595400;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 6:
									if (acpRecRefField != null)
									{
										num = (short)1047134209;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									goto IL_186B;
								case 7:
									if (num3 != 227)
									{
										num = (short)939130890;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									flag = true;
									num = (short)87883782;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 8:
								{
									global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO9.ConsolidatedActionBCOListInner consolidatedActionBCOListInner;
									if (consolidatedActionBCOListInner.ConsolidatedActionBCOListInnerSection.RadErgoControlO9ACBCOListBco_A36666.Value == 134)
									{
										num = (short)247201801;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									break;
								}
								case 9:
									num = (short)1083375623;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 10:
								{
									global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO9.ConsolidatedActionBCOListInner consolidatedActionBCOListInner;
									task.AddTask(new global::AcpBusinessLayer.UndoRedo.DeleteRecordTask(consolidatedActionBCOListInner));
									num = (short)779223044;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 11:
								{
									global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO9.ConsolidatedActionBCOListInner consolidatedActionBCOListInner;
									if (acpRecRefField.Value != consolidatedActionBCOListInner.ConsolidatedActionBCOListInnerSection.RadErgoControlO9ACBCOListIndex_A36668.Value)
									{
										num = (short)347340800;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									goto IL_186B;
								}
								case 12:
									switch (0)
									{
									case 0:
										goto IL_1695;
									}
									continue;
								case 13:
									goto IL_186B;
								}
								IL_17AF:
								num = (short)372178949;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								IL_1695:
								goto IL_17AF;
								IL_186B:
								num = (short)886702083;
								num2 = (int)((global::System.IntPtr)num);
							}
							IL_16CC:
							IL_1758:
							IL_1884:
							goto IL_AB8;
						}
						finally
						{
							num = (short)855441409;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								switch (num2)
								{
								case 0:
									goto IL_18F4;
								case 1:
									switch (0)
									{
									case 0:
										goto IL_18BB;
									}
									continue;
								case 2:
									enumerator.Dispose();
									num = (short)1472724992;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								IL_18BB:
								if (enumerator == null)
								{
									break;
								}
								num = (short)1925447682;
								num2 = (int)((global::System.IntPtr)num);
							}
							IL_18F4:;
						}
						goto Block_30;
					case 32:
						if (!acpListField.HiddenStatic)
						{
							num = (short)1261830225;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_1B16;
					case 33:
						if (featureSectionId != 10608)
						{
							num = (short)1513685072;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_1086;
					case 34:
						o9DataButtonInnerRecset = (controlHeadO9Recset[0][10611].EmbeddedRecset as global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO9.O9DataButtonInnerRecset);
						num = (short)357433370;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 35:
						try
						{
							num = (short)333185026;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								switch (num2)
								{
								case 0:
								{
									global::AcpCommonLib.IAcpFeatureNode acpFeatureNode3;
									if (num3 != (acpFeatureNode3[10713] as global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO7.O7DataButtonInnerSection).RadErgCtrlHeadO7DataButtonCnvFeature_A41299.Value)
									{
										num = (short)978780164;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									break;
								}
								case 1:
									num = (short)1716453381;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 2:
									switch (0)
									{
									case 0:
										goto IL_D17;
									}
									continue;
								case 3:
								{
									if (!enumerator.MoveNext())
									{
										num = (short)154468353;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									global::AcpCommonLib.IAcpFeatureNode acpFeatureNode3 = enumerator.Current;
									num = (short)25624576;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 4:
								{
									global::AcpCommonLib.IAcpFeatureNode acpFeatureNode3;
									task.AddTask(new global::AcpBusinessLayer.UndoRedo.ModifyDataTask<int>((acpFeatureNode3[10713] as global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO7.O7DataButtonInnerSection).RadErgCtrlHeadO7DataButtonCnvFeature_A41299, num3));
									num = (short)2024472582;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 5:
									goto IL_E04;
								case 6:
									goto IL_D50;
								}
								IL_D55:
								num = (short)894566403;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								IL_D17:
								goto IL_D55;
							}
							IL_D50:
							IL_E04:
							goto IL_1BDB;
						}
						finally
						{
							num = (short)829620226;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								switch (num2)
								{
								case 0:
									enumerator.Dispose();
									num = (short)68878337;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 1:
									goto IL_E77;
								case 2:
									switch (0)
									{
									case 0:
										goto IL_E3D;
									}
									continue;
								}
								IL_E3D:
								if (enumerator == null)
								{
									break;
								}
								num = (short)1685454848;
								num2 = (int)((global::System.IntPtr)num);
							}
							IL_E77:;
						}
						goto IL_E7A;
					case 36:
						goto IL_B35;
					case 37:
						if (num3 != 140)
						{
							num = (short)798687295;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_1B16;
					case 38:
						num = (short)182648834;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 39:
						o7DataButtonInnerRecset = (controlHeadO7Recset[0][10717].EmbeddedRecset as global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO7.O7DataButtonInnerRecset);
						num = (short)1658781769;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 40:
						num = (short)1244659745;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 41:
						if (controlHeadO9Recset != null)
						{
							num = (short)906690594;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_AF9;
					case 42:
						dataButtonInnerRecset3 = (controlHeadO3Recset[0][10234].EmbeddedRecset as global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO3.DataButtonInnerRecset);
						num = (short)1657602097;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 43:
						goto IL_15FA;
					case 44:
						goto IL_1A97;
					case 45:
						goto IL_15FA;
					case 46:
						if (o9DataButtonInnerRecset != null)
						{
							num = (short)1509883922;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_22B;
					case 47:
						try
						{
							num = (short)1633157125;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								switch (num2)
								{
								case 0:
									goto IL_1D77;
								case 1:
									goto IL_1E2C;
								case 2:
									num = (short)1819213825;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 3:
								{
									global::AcpCommonLib.IAcpFeatureNode acpFeatureNode4;
									task.AddTask(new global::AcpBusinessLayer.UndoRedo.ModifyDataTask<int>((acpFeatureNode4[10209] as global::Motorola.MackinawCPS.CoreFeatures.KeypadMicAndAccessories.DataButtonInnerSection).RadErgoCfgKMTrunkingKMDatatButtonFeature_A22605, num3));
									num = (short)1006239744;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 4:
								{
									if (!enumerator.MoveNext())
									{
										num = (short)1945763842;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									global::AcpCommonLib.IAcpFeatureNode acpFeatureNode4 = enumerator.Current;
									num = (short)363724806;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 5:
									switch (0)
									{
									case 0:
										goto IL_1D3D;
									}
									continue;
								case 6:
								{
									global::AcpCommonLib.IAcpFeatureNode acpFeatureNode4;
									if (num3 != (acpFeatureNode4[10209] as global::Motorola.MackinawCPS.CoreFeatures.KeypadMicAndAccessories.DataButtonInnerSection).RadErgoCfgKMTrunkingKMDatatButtonFeature_A22605.Value)
									{
										num = (short)1603665923;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									break;
								}
								}
								IL_1D7C:
								num = (short)454492164;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								IL_1D3D:
								goto IL_1D7C;
							}
							IL_1D77:
							IL_1E2C:
							goto IL_1598;
						}
						finally
						{
							num = (short)13500416;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								switch (num2)
								{
								case 0:
									switch (0)
									{
									case 0:
										goto IL_1E63;
									}
									continue;
								case 1:
									enumerator.Dispose();
									num = (short)1240727554;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 2:
									goto IL_1E9B;
								}
								IL_1E63:
								if (enumerator == null)
								{
									break;
								}
								num = (short)1320222721;
								num2 = (int)((global::System.IntPtr)num);
							}
							IL_1E9B:;
						}
						goto IL_1E9E;
					case 48:
					{
						global::Motorola.MackinawCPS.CoreFeatures.KeypadMicAndAccessories.DataButtonInnerRecset dataButtonInnerRecset2;
						if (dataButtonInnerRecset2 != null)
						{
							num = (short)2110586946;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_221B;
					}
					case 49:
						goto IL_767;
					case 50:
						if (buttonsRecset != null)
						{
							num = (short)437714961;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_434;
					case 51:
						consolidatedActionBCOListInnerRecset = (controlHeadO9Recset[0][10622].EmbeddedRecset as global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO9.ConsolidatedActionBCOListInnerRecset);
						num = (short)2023030784;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 52:
						enumerator = consolidatedActionBCOListInnerRecset.GetEnumerator();
						num = (short)1794965535;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 53:
						num = (short)1300299813;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 54:
						goto IL_15FA;
					case 55:
						if (featureSectionId <= 10209)
						{
							num = (short)926351372;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)1077542933;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 56:
						if (dataButtonInnerRecset3 != null)
						{
							num = (short)656080960;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_1C17;
					case 57:
						if (acpListField != null)
						{
							num = (short)488964116;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return;
					case 58:
					{
						task.AddTask(new global::AcpBusinessLayer.UndoRedo.AddRecordTask(consolidatedActionBCOListInnerRecset.CreateDefaultRecord()));
						int index = consolidatedActionBCOListInnerRecset.Count - 1;
						global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO9.ConsolidatedActionBCOListInner consolidatedActionBCOListInner2 = consolidatedActionBCOListInnerRecset[index] as global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO9.ConsolidatedActionBCOListInner;
						task.AddTask(new global::AcpBusinessLayer.UndoRedo.ModifyDataTask<int>(consolidatedActionBCOListInner2.ConsolidatedActionBCOListInnerSection.RadErgoControlO9ACBCOListBco_A36666, 134));
						task.AddTask(new global::AcpBusinessLayer.UndoRedo.ModifyRecRefDataTask(consolidatedActionBCOListInner2.ConsolidatedActionBCOListInnerSection.RadErgoControlO9ACBCOListIndex_A36668, acpRecRefField.UIValue));
						num = (short)519307267;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 59:
						if (o9DataButtonInnerRecset != null)
						{
							num = (short)1388642331;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return;
					case 60:
						if (controlHeadO9Recset.Count > 0)
						{
							num = (short)60620851;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_2257;
					case 61:
						if (!flag)
						{
							num = (short)659030074;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_2257;
					case 62:
						enumerator = dataButtonInnerRecset3.GetEnumerator();
						num = (short)1745813527;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 63:
						num = (short)775815174;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 64:
						goto IL_656;
					case 65:
						if (controlHeadO7Recset != null)
						{
							num = (short)1794768935;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_12A8;
					case 66:
					{
						global::Motorola.MackinawCPS.CoreFeatures.KeypadMicAndAccessories.DataButtonInnerRecset dataButtonInnerRecset2;
						enumerator = dataButtonInnerRecset2.GetEnumerator();
						num = (short)840171535;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 67:
						try
						{
							num = (short)2125332482;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								switch (num2)
								{
								case 0:
								{
									if (!enumerator.MoveNext())
									{
										num = (short)1748238340;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									global::AcpCommonLib.IAcpFeatureNode acpFeatureNode5 = enumerator.Current;
									num = (short)502267907;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 1:
									goto IL_899;
								case 2:
									switch (0)
									{
									case 0:
										goto IL_7AF;
									}
									continue;
								case 3:
								{
									global::AcpCommonLib.IAcpFeatureNode acpFeatureNode5;
									if (num3 != (acpFeatureNode5[10090] as global::Motorola.MackinawCPS.CoreFeatures.Buttons.DataButtonInnerSection).BtnTrunkingButtonDatatButtonFeature_A22608.Value)
									{
										num = (short)114753542;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									break;
								}
								case 4:
									num = (short)150929409;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 5:
									goto IL_87B;
								case 6:
								{
									global::AcpCommonLib.IAcpFeatureNode acpFeatureNode5;
									task.AddTask(new global::AcpBusinessLayer.UndoRedo.ModifyDataTask<int>((acpFeatureNode5[10090] as global::Motorola.MackinawCPS.CoreFeatures.Buttons.DataButtonInnerSection).BtnTrunkingButtonDatatButtonFeature_A22608, num3));
									num = (short)133038085;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								}
								IL_805:
								num = (short)216924160;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								IL_7AF:
								goto IL_805;
							}
							IL_87B:
							IL_899:
							goto IL_B88;
						}
						finally
						{
							num = (short)1321533440;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								switch (num2)
								{
								case 0:
									switch (0)
									{
									case 0:
										goto IL_8D0;
									}
									continue;
								case 1:
									goto IL_909;
								case 2:
									enumerator.Dispose();
									num = (short)24182785;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								IL_8D0:
								if (enumerator == null)
								{
									break;
								}
								num = (short)230162434;
								num2 = (int)((global::System.IntPtr)num);
							}
							IL_909:;
						}
						goto Block_12;
					case 68:
						num = (short)952893441;
						if (num != 0)
						{
						}
						if (o7DataButtonInnerRecset != null)
						{
							num = (short)1532887118;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_1BDB;
					case 69:
						if (radioWide.DualRadio.RadWideDualRadioSelection_A42236 == 0)
						{
							num = (short)622395462;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_1B16;
					case 70:
					{
						num = (short)312672256;
						short num5 = num;
						goto IL_216A;
					}
					case 71:
					{
						global::Motorola.MackinawCPS.CoreFeatures.KeypadMicAndAccessories.KeypadMicAndAccessoriesRecset keypadMicAndAccessoriesRecset;
						if (keypadMicAndAccessoriesRecset != null)
						{
							num = (short)149094424;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_B35;
					}
					case 72:
						try
						{
							num = (short)1955659778;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								switch (num2)
								{
								case 0:
								{
									global::AcpCommonLib.IAcpFeatureNode acpFeatureNode6;
									task.AddTask(new global::AcpBusinessLayer.UndoRedo.ModifyDataTask<int>((acpFeatureNode6[10608] as global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO9.O9DataButtonInnerSection).RadErgCtrlHeadO9DataButtonTrkFeature_A36526, num3));
									num = (short)1399062531;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 1:
									goto IL_5E5;
								case 2:
									switch (0)
									{
									case 0:
										goto IL_4F2;
									}
									continue;
								case 3:
									goto IL_52E;
								case 4:
								{
									if (!enumerator.MoveNext())
									{
										num = (short)472317957;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									global::AcpCommonLib.IAcpFeatureNode acpFeatureNode6 = enumerator.Current;
									num = (short)1104805894;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 5:
									num = (short)1260978177;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 6:
								{
									global::AcpCommonLib.IAcpFeatureNode acpFeatureNode6;
									if (num3 != (acpFeatureNode6[10608] as global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO9.O9DataButtonInnerSection).RadErgCtrlHeadO9DataButtonTrkFeature_A36526.Value)
									{
										num = (short)1288503296;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									break;
								}
								}
								IL_58F:
								num = (short)12910596;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								IL_4F2:
								goto IL_58F;
							}
							IL_52E:
							IL_5E5:
							return;
						}
						finally
						{
							num = (short)1498021888;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								switch (num2)
								{
								case 0:
									switch (0)
									{
									case 0:
										goto IL_61C;
									}
									continue;
								case 1:
									goto IL_653;
								case 2:
									enumerator.Dispose();
									num = (short)1555562497;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								IL_61C:
								if (enumerator == null)
								{
									break;
								}
								num = (short)2061959170;
								num2 = (int)((global::System.IntPtr)num);
							}
							IL_653:;
						}
						goto IL_656;
					case 73:
						goto IL_12A8;
					case 74:
					{
						global::Motorola.MackinawCPS.CoreFeatures.KeypadMicAndAccessories.DataButtonInnerRecset dataButtonInnerRecset2;
						if (dataButtonInnerRecset2 != null)
						{
							num = (short)1413611549;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_1598;
					}
					case 75:
						try
						{
							num = (short)1198981122;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								switch (num2)
								{
								case 0:
								{
									global::AcpCommonLib.IAcpFeatureNode acpFeatureNode7;
									if (num3 != (acpFeatureNode7[10090] as global::Motorola.MackinawCPS.CoreFeatures.Buttons.DataButtonInnerSection).BtnConventionalButtonDatatButtonFeature_A22610.Value)
									{
										num = (short)1658322948;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									break;
								}
								case 1:
									num = (short)1430781957;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 2:
									switch (0)
									{
									case 0:
										goto IL_13F3;
									}
									continue;
								case 3:
								{
									if (!enumerator.MoveNext())
									{
										num = (short)232325121;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									global::AcpCommonLib.IAcpFeatureNode acpFeatureNode7 = enumerator.Current;
									num = (short)351731712;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 4:
								{
									global::AcpCommonLib.IAcpFeatureNode acpFeatureNode7;
									task.AddTask(new global::AcpBusinessLayer.UndoRedo.ModifyDataTask<int>((acpFeatureNode7[10090] as global::Motorola.MackinawCPS.CoreFeatures.Buttons.DataButtonInnerSection).BtnConventionalButtonDatatButtonFeature_A22610, num3));
									num = (short)1632698374;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 5:
									goto IL_14E2;
								case 6:
									goto IL_142C;
								}
								IL_1431:
								num = (short)1901920259;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								IL_13F3:
								goto IL_1431;
							}
							IL_142C:
							IL_14E2:
							goto IL_E7A;
						}
						finally
						{
							num = (short)134021121;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								switch (num2)
								{
								case 0:
									goto IL_1553;
								case 1:
									switch (0)
									{
									case 0:
										goto IL_151B;
									}
									continue;
								case 2:
									enumerator.Dispose();
									num = (short)1673461760;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								IL_151B:
								if (enumerator == null)
								{
									break;
								}
								num = (short)914096130;
								num2 = (int)((global::System.IntPtr)num);
							}
							IL_1553:;
						}
						goto IL_1556;
					case 76:
						enumerator = dataButtonInnerRecset.GetEnumerator();
						num = (short)1012465739;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 77:
					{
						if (featureSectionId != 10209)
						{
							num = (short)1426325542;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						global::Motorola.MackinawCPS.CoreFeatures.KeypadMicAndAccessories.DataButtonInnerSection dataButtonInnerSection2 = self as global::Motorola.MackinawCPS.CoreFeatures.KeypadMicAndAccessories.DataButtonInnerSection;
						num3 = dataButtonInnerSection2.RadErgoCfgKMConventionalKMDatatButtonFeature_A22603.Value;
						acpRecRefField = dataButtonInnerSection2.RadErgoCfgKMConventionalKMDatatButtonIndex_A41423;
						acpListField = dataButtonInnerSection2.RadErgoCfgKMTrunkingKMDatatButtonFeature_A22605;
						num = (short)480444502;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 78:
						enumerator = o7DataButtonInnerRecset.GetEnumerator();
						num = (short)1935802403;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 79:
						enumerator = dataButtonInnerRecset.GetEnumerator();
						num = (short)8126531;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 80:
						num = (short)45088778;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 81:
						goto IL_1593;
					case 82:
						num = (short)1156841488;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 83:
						goto IL_434;
					case 84:
						try
						{
							num = (short)82968578;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								switch (num2)
								{
								case 0:
								{
									global::AcpCommonLib.IAcpFeatureNode acpFeatureNode8;
									if (num3 != (acpFeatureNode8[10713] as global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO7.O7DataButtonInnerSection).RadErgCtrlHeadO7DataButtonTrkFeature_A41297.Value)
									{
										num = (short)1520762884;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									break;
								}
								case 1:
									num = (short)1281556485;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 2:
									switch (0)
									{
									case 0:
										goto IL_1146;
									}
									continue;
								case 3:
								{
									if (!enumerator.MoveNext())
									{
										num = (short)2045444097;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									global::AcpCommonLib.IAcpFeatureNode acpFeatureNode8 = enumerator.Current;
									num = (short)1604124672;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 4:
								{
									global::AcpCommonLib.IAcpFeatureNode acpFeatureNode8;
									task.AddTask(new global::AcpBusinessLayer.UndoRedo.ModifyDataTask<int>((acpFeatureNode8[10713] as global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO7.O7DataButtonInnerSection).RadErgCtrlHeadO7DataButtonTrkFeature_A41297, num3));
									num = (short)2069692422;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 5:
									goto IL_1235;
								case 6:
									goto IL_117F;
								}
								IL_1184:
								num = (short)2003304451;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								IL_1146:
								goto IL_1184;
							}
							IL_117F:
							IL_1235:
							goto IL_1B9E;
						}
						finally
						{
							num = (short)620036098;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								switch (num2)
								{
								case 0:
									enumerator.Dispose();
									num = (short)2040463361;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 1:
									goto IL_12A5;
								case 2:
									switch (0)
									{
									case 0:
										goto IL_126D;
									}
									continue;
								}
								IL_126D:
								if (enumerator == null)
								{
									break;
								}
								num = (short)1556480000;
								num2 = (int)((global::System.IntPtr)num);
							}
							IL_12A5:;
						}
						goto IL_12A8;
					case 85:
						goto IL_18F7;
					case 86:
						goto IL_15FA;
					case 87:
						if (controlHeadO9Recset != null)
						{
							num = (short)92930092;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_2257;
					case 88:
					{
						if (!flag2)
						{
							num = (short)1512439816;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						global::Motorola.MackinawCPS.CoreFeatures.KeypadMicAndAccessories.KeypadMicAndAccessoriesRecset keypadMicAndAccessoriesRecset = null;
						global::Motorola.MackinawCPS.CoreFeatures.KeypadMicAndAccessories.DataButtonInnerRecset dataButtonInnerRecset2 = null;
						keypadMicAndAccessoriesRecset = (global::AcpCommonLib.FeatureManager.GetFeature(2128) as global::Motorola.MackinawCPS.CoreFeatures.KeypadMicAndAccessories.KeypadMicAndAccessoriesRecset);
						num = (short)265683015;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 89:
						num = (short)159449165;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 90:
						num = (short)1417347141;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_19A;
					IL_22B:
					consolidatedActionBCOListInnerRecset = null;
					flag = false;
					num = (short)1941569623;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_399:
					num = (short)1585053707;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_434:
					controlHeadO3Recset = null;
					dataButtonInnerRecset3 = null;
					controlHeadO3Recset = (global::AcpCommonLib.FeatureManager.GetFeature(2127) as global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO3.ControlHeadO3Recset);
					num = (short)610926605;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_656:
					enumerator = dataButtonInnerRecset3.GetEnumerator();
					num = (short)1360658517;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_711:
					flag2 = false;
					num = (short)1144979461;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_AB8:
					num = (short)2034171923;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					Block_12:
					try
					{
						IL_90C:
						num = (short)795541506;
						num2 = (int)((global::System.IntPtr)num);
						for (;;)
						{
							switch (num2)
							{
							case 0:
							{
								if (!enumerator.MoveNext())
								{
									num = (short)1279000580;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								global::AcpCommonLib.IAcpFeatureNode acpFeatureNode9 = enumerator.Current;
								num = (short)1638334467;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							case 1:
							{
								global::AcpCommonLib.IAcpFeatureNode acpFeatureNode9;
								task.AddTask(new global::AcpBusinessLayer.UndoRedo.ModifyDataTask<int>((acpFeatureNode9[10209] as global::Motorola.MackinawCPS.CoreFeatures.KeypadMicAndAccessories.DataButtonInnerSection).RadErgoCfgKMConventionalKMDatatButtonFeature_A22603, num3));
								num = (short)1194655750;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							case 2:
								switch (0)
								{
								case 0:
									goto IL_94E;
								}
								continue;
							case 3:
							{
								global::AcpCommonLib.IAcpFeatureNode acpFeatureNode9;
								if (num3 != (acpFeatureNode9[10209] as global::Motorola.MackinawCPS.CoreFeatures.KeypadMicAndAccessories.DataButtonInnerSection).RadErgoCfgKMConventionalKMDatatButtonFeature_A22603.Value)
								{
									num = (short)1371209729;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								break;
							}
							case 4:
								num = (short)1053229061;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							case 5:
								goto IL_A43;
							case 6:
								goto IL_98C;
							}
							IL_9ED:
							num = (short)1087438848;
							num2 = (int)((global::System.IntPtr)num);
							continue;
							IL_94E:
							goto IL_9ED;
						}
						IL_98C:
						IL_A43:
						goto IL_221B;
					}
					finally
					{
						num = (short)1181483010;
						num2 = (int)((global::System.IntPtr)num);
						for (;;)
						{
							switch (num2)
							{
							case 0:
								enumerator.Dispose();
								num = (short)1240596481;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							case 1:
								goto IL_AB5;
							case 2:
								switch (0)
								{
								case 0:
									goto IL_A7C;
								}
								continue;
							}
							IL_A7C:
							if (enumerator == null)
							{
								break;
							}
							num = (short)1534001152;
							num2 = (int)((global::System.IntPtr)num);
						}
						IL_AB5:;
					}
					goto IL_AB8;
					IL_AF9:
					num = (short)194314265;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_B35:
					buttonsRecset = null;
					dataButtonInnerRecset = null;
					buttonsRecset = (global::AcpCommonLib.FeatureManager.GetFeature(2042) as global::Motorola.MackinawCPS.CoreFeatures.Buttons.ButtonsRecset);
					num = (short)532152370;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_B88:
					num = (short)867237962;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_C3B:
					controlHeadO7Recset = null;
					o7DataButtonInnerRecset = null;
					controlHeadO7Recset = (global::AcpCommonLib.FeatureManager.GetFeature(4114) as global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO7.ControlHeadO7Recset);
					num = (short)2119303233;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_767:
					goto IL_C3B;
					IL_E7A:
					num = (short)467009584;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_1086:
					global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO9.O9DataButtonInnerSection o9DataButtonInnerSection = self as global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO9.O9DataButtonInnerSection;
					num3 = o9DataButtonInnerSection.RadErgCtrlHeadO9DataButtonCnvFeature_A36528.Value;
					acpRecRefField = o9DataButtonInnerSection.CHO9DataButtonConvIndex_A41414;
					acpListField = o9DataButtonInnerSection.RadErgCtrlHeadO9DataButtonTrkFeature_A36526;
					num = (short)2076639241;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_12A8:
					controlHeadO9Recset = null;
					o9DataButtonInnerRecset = null;
					controlHeadO9Recset = (global::AcpCommonLib.FeatureManager.GetFeature(4003) as global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO9.ControlHeadO9Recset);
					num = (short)57802793;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_1556:
					num = (short)888274976;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_1598:
					num = (short)475332638;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_15FA:
					num = (short)1428226136;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_1A97:
					num = (short)225706044;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					Block_30:
					try
					{
						IL_18F7:
						num = (short)700252165;
						num2 = (int)((global::System.IntPtr)num);
						for (;;)
						{
							switch (num2)
							{
							case 0:
							{
								global::AcpCommonLib.IAcpFeatureNode acpFeatureNode10;
								if (num3 != (acpFeatureNode10[10212] as global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO3.DataButtonInnerSection).CntrlHeadO3ConventionalO3DatatButtonFeature_A22595.Value)
								{
									num = (short)1194983428;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								break;
							}
							case 1:
								goto IL_1A23;
							case 2:
							{
								if (!enumerator.MoveNext())
								{
									num = (short)1988231174;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								global::AcpCommonLib.IAcpFeatureNode acpFeatureNode10 = enumerator.Current;
								num = (short)1579745280;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							case 3:
								goto IL_1A05;
							case 4:
							{
								global::AcpCommonLib.IAcpFeatureNode acpFeatureNode10;
								task.AddTask(new global::AcpBusinessLayer.UndoRedo.ModifyDataTask<int>((acpFeatureNode10[10212] as global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO3.DataButtonInnerSection).CntrlHeadO3ConventionalO3DatatButtonFeature_A22595, num3));
								num = (short)1779367939;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							case 5:
								switch (0)
								{
								case 0:
									goto IL_1939;
								}
								continue;
							case 6:
								num = (short)1136132097;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							IL_198E:
							num = (short)298647554;
							num2 = (int)((global::System.IntPtr)num);
							continue;
							IL_1939:
							goto IL_198E;
						}
						IL_1A05:
						IL_1A23:
						goto IL_1C17;
					}
					finally
					{
						num = (short)411107329;
						num2 = (int)((global::System.IntPtr)num);
						for (;;)
						{
							switch (num2)
							{
							case 0:
								goto IL_1A94;
							case 1:
								switch (0)
								{
								case 0:
									goto IL_1A5C;
								}
								continue;
							case 2:
								enumerator.Dispose();
								num = (short)924909568;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							IL_1A5C:
							if (enumerator == null)
							{
								break;
							}
							num = (short)1513291778;
							num2 = (int)((global::System.IntPtr)num);
						}
						IL_1A94:;
					}
					goto IL_1A97;
					IL_1B16:
					num = (short)771620892;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_1B9E:
					num = (short)631832635;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_1BDB:
					num = (short)2053505070;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_1C17:
					num = (short)567148612;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_1E9E:
					global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO3.DataButtonInnerSection dataButtonInnerSection3 = self as global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO3.DataButtonInnerSection;
					num3 = dataButtonInnerSection3.CntrlHeadO3ConventionalO3DatatButtonFeature_A22595.Value;
					acpRecRefField = dataButtonInnerSection3.CHO3DataButtonConvIndex_A41419;
					acpListField = dataButtonInnerSection3.CntrlHeadO3TrunkingO3DatatButtonFeature_A22597;
					num = (short)855113782;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_216A:
					num = (short)1404436537;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_221B:
					num = (short)351273016;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_2257:
					radioWide = ((global::AcpCommonLib.FeatureManager.GetFeature(2045) as global::Motorola.MackinawCPS.CoreFeatures.RadioWide.RadioWideRecset)[0] as global::Motorola.MackinawCPS.CoreFeatures.RadioWide.RadioWide);
					num = (short)821821441;
					num2 = (int)((global::System.IntPtr)num);
				}
				return;
				IL_1593:
				return;
				IL_19A:
				num3 = 0;
				flag2 = true;
				acpRecRefField = null;
				acpListField = null;
				featureSectionId = self.FeatureSectionId;
				num = (short)2103705655;
				num2 = (int)((global::System.IntPtr)num);
				goto IL_27;
			}
			}
		}

		// Token: 0x06008973 RID: 35187 RVA: 0x008020A0 File Offset: 0x008002A0
		public static void ConSyncTrkDataBtnFeature(global::AcpCommonLib.IAcpFeatureSection self, global::AcpCommonLib.UndoRedo.ContainerTask task)
		{
			short num = (short)1962934272;
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
				global::AcpBusinessLayer.AcpRecRefField acpRecRefField;
				int featureSectionId;
				bool flag2;
				for (;;)
				{
					IL_27:
					global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO9.ControlHeadO9Recset controlHeadO9Recset;
					bool flag;
					global::System.Collections.Generic.IEnumerator<global::AcpBusinessLayer.FeatureNode> enumerator;
					global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO9.O9DataButtonInnerRecset o9DataButtonInnerRecset;
					global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO3.ControlHeadO3Recset controlHeadO3Recset;
					global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO3.DataButtonInnerRecset dataButtonInnerRecset;
					global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO7.O7DataButtonInnerRecset o7DataButtonInnerRecset;
					global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO9.ConsolidatedActionBCOListInnerRecset consolidatedActionBCOListInnerRecset;
					global::Motorola.MackinawCPS.CoreFeatures.KeypadMicAndAccessories.DataButtonInnerRecset dataButtonInnerRecset2;
					global::Motorola.MackinawCPS.CoreFeatures.Buttons.DataButtonInnerRecset dataButtonInnerRecset3;
					global::Motorola.MackinawCPS.CoreFeatures.Buttons.ButtonsRecset buttonsRecset;
					global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO7.ControlHeadO7Recset controlHeadO7Recset;
					global::Motorola.MackinawCPS.CoreFeatures.RadioWide.RadioWide radioWide;
					switch (num2)
					{
					case 0:
						if (controlHeadO9Recset != null)
						{
							num = (short)820903990;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_21BB;
					case 1:
						try
						{
							num = (short)1575026700;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								switch (num2)
								{
								case 0:
									if (num3 != 227)
									{
										num = (short)821755909;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									flag = true;
									num = (short)1494024193;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 1:
									if (acpRecRefField != null)
									{
										num = (short)475856899;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									goto IL_14F4;
								case 2:
									num = (short)1665925120;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 3:
									num = (short)227082247;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 4:
								{
									global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO9.ConsolidatedActionBCOListInner consolidatedActionBCOListInner;
									if (consolidatedActionBCOListInner.ConsolidatedActionBCOListInnerSection.RadErgoControlO9ACBCOListBco_A36666.Value == 134)
									{
										num = (short)1497169922;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									break;
								}
								case 5:
								{
									global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO9.ConsolidatedActionBCOListInner consolidatedActionBCOListInner;
									task.AddTask(new global::AcpBusinessLayer.UndoRedo.DeleteRecordTask(consolidatedActionBCOListInner));
									num = (short)874381318;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 6:
									goto IL_13BA;
								case 7:
								{
									global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO9.ConsolidatedActionBCOListInner consolidatedActionBCOListInner;
									if (acpRecRefField.Value != consolidatedActionBCOListInner.ConsolidatedActionBCOListInnerSection.RadErgoControlO9ACBCOListIndex_A36668.Value)
									{
										num = (short)48300041;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									goto IL_14F4;
								}
								case 8:
									goto IL_14F4;
								case 9:
								{
									global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO9.ConsolidatedActionBCOListInner consolidatedActionBCOListInner;
									task.AddTask(new global::AcpBusinessLayer.UndoRedo.ModifyRecRefDataTask(consolidatedActionBCOListInner.ConsolidatedActionBCOListInnerSection.RadErgoControlO9ACBCOListIndex_A36668, acpRecRefField.UIValue));
									num = (short)1426784266;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 10:
									goto IL_1353;
								case 11:
									goto IL_150E;
								case 12:
									switch (0)
									{
									case 0:
										goto IL_131C;
									}
									continue;
								case 13:
								{
									if (!enumerator.MoveNext())
									{
										num = (short)84606984;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO9.ConsolidatedActionBCOListInner consolidatedActionBCOListInner = (global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO9.ConsolidatedActionBCOListInner)enumerator.Current;
									num = (short)2106720260;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								}
								IL_1412:
								num = (short)1764818957;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								IL_131C:
								goto IL_1412;
								IL_14F4:
								num = (short)1595473931;
								num2 = (int)((global::System.IntPtr)num);
							}
							IL_1353:
							IL_13BA:
							IL_150E:
							goto IL_1B58;
						}
						finally
						{
							num = (short)2091384833;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								switch (num2)
								{
								case 0:
									goto IL_157D;
								case 1:
									switch (0)
									{
									case 0:
										goto IL_1545;
									}
									continue;
								case 2:
									enumerator.Dispose();
									num = (short)1561198592;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								IL_1545:
								if (enumerator == null)
								{
									break;
								}
								num = (short)344850434;
								num2 = (int)((global::System.IntPtr)num);
							}
							IL_157D:;
						}
						goto IL_1580;
					case 2:
						num = (short)730398777;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 3:
						try
						{
							num = (short)2031943681;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								switch (num2)
								{
								case 0:
								{
									if (!enumerator.MoveNext())
									{
										num = (short)1478623235;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									global::AcpCommonLib.IAcpFeatureNode acpFeatureNode = enumerator.Current;
									num = (short)19267590;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 1:
									switch (0)
									{
									case 0:
										goto IL_ADC;
									}
									continue;
								case 2:
									goto IL_BC7;
								case 3:
									num = (short)132644866;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 4:
									goto IL_BA9;
								case 5:
								{
									global::AcpCommonLib.IAcpFeatureNode acpFeatureNode;
									task.AddTask(new global::AcpBusinessLayer.UndoRedo.ModifyDataTask<int>((acpFeatureNode[10209] as global::Motorola.MackinawCPS.CoreFeatures.KeypadMicAndAccessories.DataButtonInnerSection).RadErgoCfgKMConventionalKMDatatButtonFeature_A22603, num3));
									num = (short)1535246340;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 6:
								{
									global::AcpCommonLib.IAcpFeatureNode acpFeatureNode;
									if (num3 != (acpFeatureNode[10209] as global::Motorola.MackinawCPS.CoreFeatures.KeypadMicAndAccessories.DataButtonInnerSection).RadErgoCfgKMConventionalKMDatatButtonFeature_A22603.Value)
									{
										num = (short)1219690501;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									break;
								}
								}
								IL_B33:
								num = (short)1018101760;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								IL_ADC:
								goto IL_B33;
							}
							IL_BA9:
							IL_BC7:
							goto IL_15A7;
						}
						finally
						{
							num = (short)1988689922;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								switch (num2)
								{
								case 0:
									enumerator.Dispose();
									num = (short)1107689473;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 1:
									goto IL_C36;
								case 2:
									switch (0)
									{
									case 0:
										goto IL_BFE;
									}
									continue;
								}
								IL_BFE:
								if (enumerator == null)
								{
									break;
								}
								num = (short)907214848;
								num2 = (int)((global::System.IntPtr)num);
							}
							IL_C36:;
						}
						goto IL_C39;
					case 4:
						goto IL_190E;
					case 5:
						num = (short)1072037906;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 6:
						goto IL_1648;
					case 7:
						if (o9DataButtonInnerRecset != null)
						{
							num = (short)1247608871;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return;
					case 8:
						goto IL_A45;
					case 9:
						if (controlHeadO9Recset != null)
						{
							num = (short)1233977430;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_A09;
					case 10:
						dataButtonInnerRecset = (controlHeadO3Recset[0][10234].EmbeddedRecset as global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO3.DataButtonInnerRecset);
						num = (short)1484062731;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 11:
						goto IL_C8C;
					case 12:
						enumerator = o7DataButtonInnerRecset.GetEnumerator();
						num = (short)873267268;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 13:
						goto IL_1648;
					case 14:
						goto IL_635;
					case 15:
						num = (short)1578500146;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 16:
					{
						task.AddTask(new global::AcpBusinessLayer.UndoRedo.AddRecordTask(consolidatedActionBCOListInnerRecset.CreateDefaultRecord()));
						int index = consolidatedActionBCOListInnerRecset.Count - 1;
						global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO9.ConsolidatedActionBCOListInner consolidatedActionBCOListInner2 = consolidatedActionBCOListInnerRecset[index] as global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO9.ConsolidatedActionBCOListInner;
						task.AddTask(new global::AcpBusinessLayer.UndoRedo.ModifyDataTask<int>(consolidatedActionBCOListInner2.ConsolidatedActionBCOListInnerSection.RadErgoControlO9ACBCOListBco_A36666, 134));
						task.AddTask(new global::AcpBusinessLayer.UndoRedo.ModifyRecRefDataTask(consolidatedActionBCOListInner2.ConsolidatedActionBCOListInnerSection.RadErgoControlO9ACBCOListIndex_A36668, acpRecRefField.UIValue));
						num = (short)1848246323;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 17:
						try
						{
							num = (short)895483904;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								switch (num2)
								{
								case 0:
									switch (0)
									{
									case 0:
										goto IL_1CCD;
									}
									continue;
								case 1:
								{
									if (!enumerator.MoveNext())
									{
										num = (short)1415774211;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									global::AcpCommonLib.IAcpFeatureNode acpFeatureNode2 = enumerator.Current;
									num = (short)736755716;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 2:
									goto IL_1D9C;
								case 3:
									num = (short)953548806;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 4:
								{
									global::AcpCommonLib.IAcpFeatureNode acpFeatureNode2;
									if (num3 != (acpFeatureNode2[10608] as global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO9.O9DataButtonInnerSection).RadErgCtrlHeadO9DataButtonTrkFeature_A36526.Value)
									{
										num = (short)1750401029;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									break;
								}
								case 5:
								{
									global::AcpCommonLib.IAcpFeatureNode acpFeatureNode2;
									task.AddTask(new global::AcpBusinessLayer.UndoRedo.ModifyDataTask<int>((acpFeatureNode2[10608] as global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO9.O9DataButtonInnerSection).RadErgCtrlHeadO9DataButtonTrkFeature_A36526, num3));
									num = (short)1403387906;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 6:
									goto IL_1DBA;
								}
								IL_1CCF:
								num = (short)411893761;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								IL_1CCD:
								goto IL_1CCF;
							}
							IL_1D9C:
							IL_1DBA:
							goto IL_184D;
						}
						finally
						{
							num = (short)1478557696;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								switch (num2)
								{
								case 0:
									switch (0)
									{
									case 0:
										goto IL_1DF1;
									}
									continue;
								case 1:
									enumerator.Dispose();
									num = (short)242024450;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 2:
									goto IL_1E29;
								}
								IL_1DF1:
								if (enumerator == null)
								{
									break;
								}
								num = (short)1902182401;
								num2 = (int)((global::System.IntPtr)num);
							}
							IL_1E29:;
						}
						goto IL_1E2C;
					case 18:
						if (featureSectionId != 10608)
						{
							num = (short)534577229;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_F80;
					case 19:
						try
						{
							num = (short)1766850565;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								switch (num2)
								{
								case 0:
									num = (short)1544355844;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 1:
								{
									global::AcpCommonLib.IAcpFeatureNode acpFeatureNode3;
									task.AddTask(new global::AcpBusinessLayer.UndoRedo.ModifyDataTask<int>((acpFeatureNode3[10212] as global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO3.DataButtonInnerSection).CntrlHeadO3TrunkingO3DatatButtonFeature_A22597, num3));
									num = (short)1019478019;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 2:
								{
									global::AcpCommonLib.IAcpFeatureNode acpFeatureNode3;
									if (num3 != (acpFeatureNode3[10212] as global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO3.DataButtonInnerSection).CntrlHeadO3TrunkingO3DatatButtonFeature_A22597.Value)
									{
										num = (short)1002897409;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									break;
								}
								case 3:
									goto IL_17BD;
								case 4:
									goto IL_17DA;
								case 5:
									switch (0)
									{
									case 0:
										goto IL_16EE;
									}
									continue;
								case 6:
								{
									if (!enumerator.MoveNext())
									{
										num = (short)659423232;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									global::AcpCommonLib.IAcpFeatureNode acpFeatureNode3 = enumerator.Current;
									num = (short)605618178;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								}
								IL_1745:
								num = (short)483131398;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								IL_16EE:
								goto IL_1745;
							}
							IL_17BD:
							IL_17DA:
							goto IL_196E;
						}
						finally
						{
							num = (short)1319501825;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								switch (num2)
								{
								case 0:
									goto IL_184A;
								case 1:
									switch (0)
									{
									case 0:
										goto IL_1812;
									}
									continue;
								case 2:
									enumerator.Dispose();
									num = (short)1560150016;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								IL_1812:
								if (enumerator == null)
								{
									break;
								}
								num = (short)972750850;
								num2 = (int)((global::System.IntPtr)num);
							}
							IL_184A:;
						}
						goto IL_184D;
					case 20:
						enumerator = dataButtonInnerRecset.GetEnumerator();
						num = (short)242941987;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 21:
						goto IL_5CB;
					case 22:
					{
						if (featureSectionId != 10713)
						{
							num = (short)1453523024;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO7.O7DataButtonInnerSection o7DataButtonInnerSection = self as global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO7.O7DataButtonInnerSection;
						num3 = o7DataButtonInnerSection.RadErgCtrlHeadO7DataButtonTrkFeature_A41297.Value;
						acpRecRefField = o7DataButtonInnerSection.CHO7DataButtonTrkIndex_A41418;
						num = (short)1777729542;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 23:
						goto IL_1648;
					case 24:
					{
						global::Motorola.MackinawCPS.CoreFeatures.KeypadMicAndAccessories.KeypadMicAndAccessoriesRecset keypadMicAndAccessoriesRecset;
						dataButtonInnerRecset2 = (keypadMicAndAccessoriesRecset[0][10228].EmbeddedRecset as global::Motorola.MackinawCPS.CoreFeatures.KeypadMicAndAccessories.DataButtonInnerRecset);
						num = (short)1666252808;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 25:
						if (dataButtonInnerRecset2 != null)
						{
							num = (short)276496455;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_15A7;
					case 26:
						enumerator = dataButtonInnerRecset3.GetEnumerator();
						num = (short)2033451086;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 27:
						goto IL_837;
					case 28:
						goto IL_1648;
					case 29:
						if (buttonsRecset != null)
						{
							num = (short)1916534863;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_39E;
					case 30:
						enumerator = o7DataButtonInnerRecset.GetEnumerator();
						num = (short)768606274;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 31:
						goto IL_A09;
					case 32:
						if (featureSectionId <= 10209)
						{
							num = (short)1645215746;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)1490616405;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 33:
						if (o7DataButtonInnerRecset != null)
						{
							num = (short)533856256;
							short num4 = num;
							num = (short)1512636428;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_1B95;
					case 34:
						goto IL_1648;
					case 35:
						try
						{
							num = (short)1631191041;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								switch (num2)
								{
								case 0:
									num = (short)1013645314;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 1:
									switch (0)
									{
									case 0:
										goto IL_E1C;
									}
									continue;
								case 2:
									goto IL_F0C;
								case 3:
								{
									global::AcpCommonLib.IAcpFeatureNode acpFeatureNode4;
									if (num3 != (acpFeatureNode4[10212] as global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO3.DataButtonInnerSection).CntrlHeadO3ConventionalO3DatatButtonFeature_A22595.Value)
									{
										num = (short)594935812;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									break;
								}
								case 4:
								{
									global::AcpCommonLib.IAcpFeatureNode acpFeatureNode4;
									task.AddTask(new global::AcpBusinessLayer.UndoRedo.ModifyDataTask<int>((acpFeatureNode4[10212] as global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO3.DataButtonInnerSection).CntrlHeadO3ConventionalO3DatatButtonFeature_A22595, num3));
									num = (short)1130758150;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 5:
								{
									if (!enumerator.MoveNext())
									{
										num = (short)203751424;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									global::AcpCommonLib.IAcpFeatureNode acpFeatureNode4 = enumerator.Current;
									num = (short)1123876867;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 6:
									goto IL_E56;
								}
								IL_E5B:
								num = (short)1161166853;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								IL_E1C:
								goto IL_E5B;
							}
							IL_E56:
							IL_F0C:
							goto IL_15E3;
						}
						finally
						{
							num = (short)2112290817;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								switch (num2)
								{
								case 0:
									goto IL_F7D;
								case 1:
									switch (0)
									{
									case 0:
										goto IL_F43;
									}
									continue;
								case 2:
									enumerator.Dispose();
									num = (short)546177024;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								IL_F43:
								if (enumerator == null)
								{
									break;
								}
								num = (short)2069364738;
								num2 = (int)((global::System.IntPtr)num);
							}
							IL_F7D:;
						}
						goto IL_F80;
					case 36:
						if (controlHeadO7Recset != null)
						{
							num = (short)825491505;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_C39;
					case 37:
						if (dataButtonInnerRecset != null)
						{
							num = (short)1986527252;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_15E3;
					case 38:
						if (o7DataButtonInnerRecset != null)
						{
							num = (short)599523358;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_D1A;
					case 39:
						enumerator = o9DataButtonInnerRecset.GetEnumerator();
						num = (short)1516896332;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 40:
					{
						num = (short)1187119105;
						if (num != 0)
						{
						}
						global::Motorola.MackinawCPS.CoreFeatures.KeypadMicAndAccessories.KeypadMicAndAccessoriesRecset keypadMicAndAccessoriesRecset;
						if (keypadMicAndAccessoriesRecset != null)
						{
							num = (short)595394584;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_A45;
					}
					case 41:
						try
						{
							num = (short)1848967168;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								switch (num2)
								{
								case 0:
									switch (0)
									{
									case 0:
										goto IL_1F46;
									}
									continue;
								case 1:
								{
									if (!enumerator.MoveNext())
									{
										num = (short)307167235;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									global::AcpCommonLib.IAcpFeatureNode acpFeatureNode5 = enumerator.Current;
									num = (short)181403652;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 2:
									goto IL_2013;
								case 3:
									num = (short)484507654;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 4:
								{
									global::AcpCommonLib.IAcpFeatureNode acpFeatureNode5;
									if (num3 != (acpFeatureNode5[10090] as global::Motorola.MackinawCPS.CoreFeatures.Buttons.DataButtonInnerSection).BtnTrunkingButtonDatatButtonFeature_A22608.Value)
									{
										num = (short)1516109829;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									break;
								}
								case 5:
								{
									global::AcpCommonLib.IAcpFeatureNode acpFeatureNode5;
									task.AddTask(new global::AcpBusinessLayer.UndoRedo.ModifyDataTask<int>((acpFeatureNode5[10090] as global::Motorola.MackinawCPS.CoreFeatures.Buttons.DataButtonInnerSection).BtnTrunkingButtonDatatButtonFeature_A22608, num3));
									num = (short)1523187714;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 6:
									goto IL_2031;
								}
								IL_1F48:
								num = (short)2042298369;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								IL_1F46:
								goto IL_1F48;
							}
							IL_2013:
							IL_2031:
							goto IL_217D;
						}
						finally
						{
							num = (short)1530134528;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								switch (num2)
								{
								case 0:
									switch (0)
									{
									case 0:
										goto IL_2069;
									}
									continue;
								case 1:
									goto IL_2088;
								case 2:
								{
									num = (short)1911310201;
									short num5 = num;
									num = (short)207964025;
									switch ((num5 == num) ? 1 : 0)
									{
									case 0:
									case 2:
										goto IL_2088;
									default:
										goto IL_20D8;
									}
									break;
								}
								}
								IL_2069:
								if (enumerator != null)
								{
									num = (short)670236673;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								goto IL_20F0;
								IL_2088:
								enumerator.Dispose();
								num = (short)603324418;
								num2 = (int)((global::System.IntPtr)num);
							}
							IL_20D8:
							num = (short)1957691392;
							if (num != 0)
							{
							}
							IL_20F0:;
						}
						goto IL_20F1;
					case 42:
						num = (short)600899654;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 43:
					{
						if (!flag2)
						{
							num = (short)555352109;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						global::Motorola.MackinawCPS.CoreFeatures.KeypadMicAndAccessories.KeypadMicAndAccessoriesRecset keypadMicAndAccessoriesRecset = null;
						dataButtonInnerRecset2 = null;
						keypadMicAndAccessoriesRecset = (global::AcpCommonLib.FeatureManager.GetFeature(2128) as global::Motorola.MackinawCPS.CoreFeatures.KeypadMicAndAccessories.KeypadMicAndAccessoriesRecset);
						num = (short)872874024;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 44:
						enumerator = consolidatedActionBCOListInnerRecset.GetEnumerator();
						num = (short)1970601985;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 45:
						return;
					case 46:
						consolidatedActionBCOListInnerRecset = (controlHeadO9Recset[0][10622].EmbeddedRecset as global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO9.ConsolidatedActionBCOListInnerRecset);
						num = (short)311361617;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 47:
						goto IL_635;
					case 48:
						num = (short)1090322507;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 49:
						o7DataButtonInnerRecset = (controlHeadO7Recset[0][10717].EmbeddedRecset as global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO7.O7DataButtonInnerRecset);
						num = (short)494796860;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 50:
						if (num3 == 228)
						{
							num = (short)1506738218;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return;
					case 51:
						goto IL_21BB;
					case 52:
						num = (short)901054511;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 53:
						if (!flag)
						{
							num = (short)850657296;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_21BB;
					case 54:
						num = (short)1199767611;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 55:
						num = (short)1108279357;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 56:
						if (dataButtonInnerRecset3 != null)
						{
							num = (short)826277961;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_217D;
					case 57:
						if (featureSectionId != 10090)
						{
							num = (short)215875632;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num3 = (self as global::Motorola.MackinawCPS.CoreFeatures.Buttons.DataButtonInnerSection).BtnTrunkingButtonDatatButtonFeature_A22608.Value;
						num = (short)1548550157;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 58:
						goto IL_20F1;
					case 59:
						if (controlHeadO9Recset.Count > 0)
						{
							num = (short)783941678;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_21BB;
					case 60:
						goto IL_C39;
					case 61:
						if (num3 != 140)
						{
							num = (short)145948687;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_D9D;
					case 62:
						if (dataButtonInnerRecset3 != null)
						{
							num = (short)2012545050;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_1C4D;
					case 63:
						if (dataButtonInnerRecset != null)
						{
							num = (short)1968111637;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_196E;
					case 64:
						num = (short)91750453;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 65:
						if (o9DataButtonInnerRecset != null)
						{
							num = (short)77004858;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_184D;
					case 66:
						try
						{
							num = (short)1661009920;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								switch (num2)
								{
								case 0:
									switch (0)
									{
									case 0:
										goto IL_19ED;
									}
									continue;
								case 1:
									goto IL_1A29;
								case 2:
									num = (short)2004942854;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 3:
								{
									global::AcpCommonLib.IAcpFeatureNode acpFeatureNode6;
									if (num3 != (acpFeatureNode6[10713] as global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO7.O7DataButtonInnerSection).RadErgCtrlHeadO7DataButtonTrkFeature_A41297.Value)
									{
										num = (short)354353156;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									break;
								}
								case 4:
								{
									global::AcpCommonLib.IAcpFeatureNode acpFeatureNode6;
									task.AddTask(new global::AcpBusinessLayer.UndoRedo.ModifyDataTask<int>((acpFeatureNode6[10713] as global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO7.O7DataButtonInnerSection).RadErgCtrlHeadO7DataButtonTrkFeature_A41297, num3));
									num = (short)1478688769;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 5:
								{
									if (!enumerator.MoveNext())
									{
										num = (short)1524760578;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									global::AcpCommonLib.IAcpFeatureNode acpFeatureNode6 = enumerator.Current;
									num = (short)1592328195;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 6:
									goto IL_1AE5;
								}
								IL_1A8D:
								num = (short)1257832453;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								IL_19ED:
								goto IL_1A8D;
							}
							IL_1A29:
							IL_1AE5:
							goto IL_D1A;
						}
						finally
						{
							num = (short)14417920;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								switch (num2)
								{
								case 0:
									switch (0)
									{
									case 0:
										goto IL_1B1D;
									}
									continue;
								case 1:
									enumerator.Dispose();
									num = (short)1123745794;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 2:
									goto IL_1B55;
								}
								IL_1B1D:
								if (enumerator == null)
								{
									break;
								}
								num = (short)960954369;
								num2 = (int)((global::System.IntPtr)num);
							}
							IL_1B55:;
						}
						goto IL_1B58;
					case 67:
						goto IL_9E3;
					case 68:
						try
						{
							num = (short)739508229;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								switch (num2)
								{
								case 0:
								{
									global::AcpCommonLib.IAcpFeatureNode acpFeatureNode7;
									if (num3 != (acpFeatureNode7[10713] as global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO7.O7DataButtonInnerSection).RadErgCtrlHeadO7DataButtonCnvFeature_A41299.Value)
									{
										num = (short)605224963;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									break;
								}
								case 1:
								{
									if (!enumerator.MoveNext())
									{
										num = (short)587857926;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									global::AcpCommonLib.IAcpFeatureNode acpFeatureNode7 = enumerator.Current;
									num = (short)733609984;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 2:
									goto IL_1072;
								case 3:
								{
									global::AcpCommonLib.IAcpFeatureNode acpFeatureNode7;
									task.AddTask(new global::AcpBusinessLayer.UndoRedo.ModifyDataTask<int>((acpFeatureNode7[10713] as global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO7.O7DataButtonInnerSection).RadErgCtrlHeadO7DataButtonCnvFeature_A41299, num3));
									num = (short)368705538;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 4:
									goto IL_1125;
								case 5:
									switch (0)
									{
									case 0:
										goto IL_1039;
									}
									continue;
								case 6:
									num = (short)1715929092;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								IL_1077:
								num = (short)179961857;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								IL_1039:
								goto IL_1077;
							}
							IL_1072:
							IL_1125:
							goto IL_1B95;
						}
						finally
						{
							num = (short)1480523777;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								switch (num2)
								{
								case 0:
									goto IL_1197;
								case 1:
									switch (0)
									{
									case 0:
										goto IL_115D;
									}
									continue;
								case 2:
									enumerator.Dispose();
									num = (short)1976631296;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								IL_115D:
								if (enumerator == null)
								{
									break;
								}
								num = (short)475463682;
								num2 = (int)((global::System.IntPtr)num);
							}
							IL_1197:;
						}
						goto IL_119A;
					case 69:
						goto IL_39E;
					case 70:
						if (radioWide.DualRadio.RadWideDualRadioSelection_A42236 == 0)
						{
							num = (short)2076311556;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_D9D;
					case 71:
						enumerator = dataButtonInnerRecset2.GetEnumerator();
						num = (short)2002649091;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 72:
						if (controlHeadO3Recset != null)
						{
							num = (short)1990656010;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_C8C;
					case 73:
						goto IL_1580;
					case 74:
						if (dataButtonInnerRecset2 != null)
						{
							num = (short)131006531;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_1BD1;
					case 75:
					{
						if (featureSectionId != 10209)
						{
							num = (short)76808244;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						global::Motorola.MackinawCPS.CoreFeatures.KeypadMicAndAccessories.DataButtonInnerSection dataButtonInnerSection = self as global::Motorola.MackinawCPS.CoreFeatures.KeypadMicAndAccessories.DataButtonInnerSection;
						num3 = dataButtonInnerSection.RadErgoCfgKMTrunkingKMDatatButtonFeature_A22605.Value;
						acpRecRefField = dataButtonInnerSection.RadErgoCfgKMTrunkingKMDatatButtonIndex_A41424;
						num = (short)203882530;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 76:
						try
						{
							num = (short)127401984;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								switch (num2)
								{
								case 0:
									switch (0)
									{
									case 0:
										goto IL_45D;
									}
									continue;
								case 1:
								{
									global::AcpCommonLib.IAcpFeatureNode acpFeatureNode8;
									task.AddTask(new global::AcpBusinessLayer.UndoRedo.ModifyDataTask<int>((acpFeatureNode8[10608] as global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO9.O9DataButtonInnerSection).RadErgCtrlHeadO9DataButtonCnvFeature_A36528, num3));
									num = (short)534708226;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 2:
									goto IL_49A;
								case 3:
									goto IL_557;
								case 4:
								{
									if (!enumerator.MoveNext())
									{
										num = (short)2128084997;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									global::AcpCommonLib.IAcpFeatureNode acpFeatureNode8 = enumerator.Current;
									num = (short)2049703942;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 5:
									num = (short)2064908291;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 6:
								{
									global::AcpCommonLib.IAcpFeatureNode acpFeatureNode8;
									if (num3 != (acpFeatureNode8[10608] as global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO9.O9DataButtonInnerSection).RadErgCtrlHeadO9DataButtonCnvFeature_A36528.Value)
									{
										num = (short)2094006273;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									break;
								}
								}
								IL_4FD:
								num = (short)1947205636;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								IL_45D:
								goto IL_4FD;
							}
							IL_49A:
							IL_557:
							return;
						}
						finally
						{
							num = (short)1102381058;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								switch (num2)
								{
								case 0:
									enumerator.Dispose();
									num = (short)1179713537;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 1:
									goto IL_5C8;
								case 2:
									switch (0)
									{
									case 0:
										goto IL_590;
									}
									continue;
								}
								IL_590:
								if (enumerator == null)
								{
									break;
								}
								num = (short)1513750528;
								num2 = (int)((global::System.IntPtr)num);
							}
							IL_5C8:;
						}
						goto IL_5CB;
					case 77:
						num = (short)2120286230;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 78:
						try
						{
							num = (short)940834817;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								switch (num2)
								{
								case 0:
									goto IL_767;
								case 1:
									switch (0)
									{
									case 0:
										goto IL_6D2;
									}
									continue;
								case 2:
									goto IL_7C4;
								case 3:
								{
									if (!enumerator.MoveNext())
									{
										num = (short)3014660;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									global::AcpCommonLib.IAcpFeatureNode acpFeatureNode9 = enumerator.Current;
									num = (short)1802174470;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 4:
									num = (short)1924202498;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 5:
								{
									global::AcpCommonLib.IAcpFeatureNode acpFeatureNode9;
									task.AddTask(new global::AcpBusinessLayer.UndoRedo.ModifyDataTask<int>((acpFeatureNode9[10090] as global::Motorola.MackinawCPS.CoreFeatures.Buttons.DataButtonInnerSection).BtnConventionalButtonDatatButtonFeature_A22610, num3));
									num = (short)1131020288;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 6:
								{
									global::AcpCommonLib.IAcpFeatureNode acpFeatureNode9;
									if (num3 != (acpFeatureNode9[10090] as global::Motorola.MackinawCPS.CoreFeatures.Buttons.DataButtonInnerSection).BtnConventionalButtonDatatButtonFeature_A22610.Value)
									{
										num = (short)2081947653;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									break;
								}
								}
								IL_76C:
								num = (short)1790574595;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								IL_6D2:
								goto IL_76C;
							}
							IL_767:
							IL_7C4:
							goto IL_1C4D;
						}
						finally
						{
							num = (short)95092738;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								switch (num2)
								{
								case 0:
									enumerator.Dispose();
									num = (short)1912012801;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 1:
									goto IL_834;
								case 2:
									switch (0)
									{
									case 0:
										goto IL_7FC;
									}
									continue;
								}
								IL_7FC:
								if (enumerator == null)
								{
									break;
								}
								num = (short)1280901120;
								num2 = (int)((global::System.IntPtr)num);
							}
							IL_834:;
						}
						goto Block_8;
					case 79:
						goto IL_119A;
					case 80:
						num = (short)386400270;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 81:
						if (consolidatedActionBCOListInnerRecset != null)
						{
							num = (short)1828716588;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_21BB;
					case 82:
						if (num3 == 227)
						{
							num = (short)710737984;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_21BB;
					case 83:
						if (num3 != 227)
						{
							num = (short)139722807;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_D9D;
					case 84:
						goto IL_1648;
					case 85:
						if (featureSectionId != 10212)
						{
							num = (short)426639365;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_1E2C;
					case 86:
						o9DataButtonInnerRecset = (controlHeadO9Recset[0][10611].EmbeddedRecset as global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO9.O9DataButtonInnerRecset);
						num = (short)467337247;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_18A;
					IL_39E:
					controlHeadO3Recset = null;
					dataButtonInnerRecset = null;
					controlHeadO3Recset = (global::AcpCommonLib.FeatureManager.GetFeature(2127) as global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO3.ControlHeadO3Recset);
					num = (short)418775112;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_5CB:
					enumerator = dataButtonInnerRecset.GetEnumerator();
					num = (short)165609491;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_635:
					flag2 = false;
					num = (short)607977556;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_9E3:
					enumerator = dataButtonInnerRecset2.GetEnumerator();
					num = (short)2009727003;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					Block_8:
					try
					{
						IL_837:
						num = (short)1222705153;
						num2 = (int)((global::System.IntPtr)num);
						for (;;)
						{
							switch (num2)
							{
							case 0:
								goto IL_8F0;
							case 1:
								switch (0)
								{
								case 0:
									goto IL_87A;
								}
								continue;
							case 2:
								goto IL_970;
							case 3:
							{
								global::AcpCommonLib.IAcpFeatureNode acpFeatureNode10;
								if (num3 != (acpFeatureNode10[10209] as global::Motorola.MackinawCPS.CoreFeatures.KeypadMicAndAccessories.DataButtonInnerSection).RadErgoCfgKMTrunkingKMDatatButtonFeature_A22605.Value)
								{
									num = (short)1120731140;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								break;
							}
							case 4:
							{
								global::AcpCommonLib.IAcpFeatureNode acpFeatureNode10;
								task.AddTask(new global::AcpBusinessLayer.UndoRedo.ModifyDataTask<int>((acpFeatureNode10[10209] as global::Motorola.MackinawCPS.CoreFeatures.KeypadMicAndAccessories.DataButtonInnerSection).RadErgoCfgKMTrunkingKMDatatButtonFeature_A22605, num3));
								num = (short)126746624;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							case 5:
								num = (short)681508866;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							case 6:
							{
								if (!enumerator.MoveNext())
								{
									num = (short)1430913029;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								global::AcpCommonLib.IAcpFeatureNode acpFeatureNode10 = enumerator.Current;
								num = (short)516947971;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							}
							IL_87C:
							num = (short)374407174;
							num2 = (int)((global::System.IntPtr)num);
							continue;
							IL_87A:
							goto IL_87C;
						}
						IL_8F0:
						IL_970:
						goto IL_1BD1;
					}
					finally
					{
						num = (short)1699151874;
						num2 = (int)((global::System.IntPtr)num);
						for (;;)
						{
							switch (num2)
							{
							case 0:
								enumerator.Dispose();
								num = (short)841154561;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							case 1:
								goto IL_9E0;
							case 2:
								switch (0)
								{
								case 0:
									goto IL_9A7;
								}
								continue;
							}
							IL_9A7:
							if (enumerator == null)
							{
								break;
							}
							num = (short)316538880;
							num2 = (int)((global::System.IntPtr)num);
						}
						IL_9E0:;
					}
					goto IL_9E3;
					IL_A09:
					num = (short)841744440;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_A45:
					buttonsRecset = null;
					dataButtonInnerRecset3 = null;
					buttonsRecset = (global::AcpCommonLib.FeatureManager.GetFeature(2042) as global::Motorola.MackinawCPS.CoreFeatures.Buttons.ButtonsRecset);
					num = (short)640548893;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_C39:
					controlHeadO9Recset = null;
					o9DataButtonInnerRecset = null;
					controlHeadO9Recset = (global::AcpCommonLib.FeatureManager.GetFeature(4003) as global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO9.ControlHeadO9Recset);
					num = (short)1445855241;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_C8C:
					controlHeadO7Recset = null;
					o7DataButtonInnerRecset = null;
					controlHeadO7Recset = (global::AcpCommonLib.FeatureManager.GetFeature(4114) as global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO7.ControlHeadO7Recset);
					num = (short)1060306980;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_D1A:
					num = (short)1540161601;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_D9D:
					num = (short)1105854526;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_F80:
					global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO9.O9DataButtonInnerSection o9DataButtonInnerSection = self as global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO9.O9DataButtonInnerSection;
					num3 = o9DataButtonInnerSection.RadErgCtrlHeadO9DataButtonTrkFeature_A36526.Value;
					acpRecRefField = o9DataButtonInnerSection.CHO9DataButtonTrkIndex_A41416;
					num = (short)1021247516;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_119A:
					dataButtonInnerRecset3 = (buttonsRecset[0][10089].EmbeddedRecset as global::Motorola.MackinawCPS.CoreFeatures.Buttons.DataButtonInnerRecset);
					num = (short)357630021;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_1580:
					enumerator = dataButtonInnerRecset3.GetEnumerator();
					num = (short)354418729;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_15A7:
					num = (short)1244069925;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_15E3:
					num = (short)521666593;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_1648:
					num = (short)1157496875;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_184D:
					consolidatedActionBCOListInnerRecset = null;
					flag = false;
					num = (short)790298624;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_196E:
					num = (short)990052390;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_1B58:
					num = (short)1738145874;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_1B95:
					num = (short)476971015;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_1BD1:
					num = (short)996999231;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_1C4D:
					num = (short)1116078105;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_1E2C:
					global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO3.DataButtonInnerSection dataButtonInnerSection2 = self as global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO3.DataButtonInnerSection;
					num3 = dataButtonInnerSection2.CntrlHeadO3TrunkingO3DatatButtonFeature_A22597.Value;
					acpRecRefField = dataButtonInnerSection2.CHO3DataButtonTrkIndex_A41420;
					num = (short)1230307351;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_20F1:
					enumerator = o9DataButtonInnerRecset.GetEnumerator();
					num = (short)1075838993;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_217D:
					num = (short)1088159818;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_21BB:
					radioWide = ((global::AcpCommonLib.FeatureManager.GetFeature(2045) as global::Motorola.MackinawCPS.CoreFeatures.RadioWide.RadioWideRecset)[0] as global::Motorola.MackinawCPS.CoreFeatures.RadioWide.RadioWide);
					num = (short)275972179;
					num2 = (int)((global::System.IntPtr)num);
				}
				return;
				IL_190E:
				return;
				IL_18A:
				num3 = 0;
				flag2 = true;
				acpRecRefField = null;
				featureSectionId = self.FeatureSectionId;
				num = (short)2115633184;
				num2 = (int)((global::System.IntPtr)num);
				goto IL_27;
			}
			}
		}

		// Token: 0x06008974 RID: 35188 RVA: 0x00804434 File Offset: 0x00802634
		public static bool conDownButtonApplicable(global::AcpCommonLib.IAcpFeatureSection self)
		{
			if (self.ParentRecset[1] == self.Parent)
			{
				short num = (short)1205329977;
				short num2 = num;
				num = (short)1309270073;
				switch ((num2 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					break;
				default:
				{
					num = (short)914292736;
					if (num != 0)
					{
					}
					num = (short)1376649217;
					if (num != 0)
					{
					}
					num = (short)813236224;
					short num3 = num;
					return false;
				}
				}
			}
			return true;
		}

		// Token: 0x06008975 RID: 35189 RVA: 0x008044FC File Offset: 0x008026FC
		internal static bool ConO3DataButtonConvIndexApplicable(global::AcpCommonLib.IAcpFeatureSection self)
		{
			int num;
			short num2;
			global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO3.DataButtonInnerSection dataButtonInnerSection;
			switch (0)
			{
			case 0:
				break;
			default:
				for (;;)
				{
					IL_0A:
					switch (num)
					{
					case 0:
					{
						num2 = (short)1060962304;
						short num3 = num2;
						num2 = (short)1468071938;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					case 1:
						return true;
					case 2:
						if (dataButtonInnerSection.CntrlHeadO3ConventionalO3DatatButtonFeature_A22595.Value == 227)
						{
							num2 = (short)1519058945;
							num = (int)((global::System.IntPtr)num2);
							continue;
						}
						return false;
					case 3:
					{
						num2 = (short)988896165;
						short num4 = num2;
						num2 = (short)1781685157;
						switch ((num4 == num2) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_4E;
						default:
							num2 = (short)819331072;
							if (num2 != 0)
							{
							}
							if (dataButtonInnerSection.RefRadioWide.DualRadio.RadWideDualRadioSelection_A42236.Value == 0)
							{
								num2 = (short)1387855872;
								num = (int)((global::System.IntPtr)num2);
								continue;
							}
							return false;
						}
						break;
					}
					}
					goto IL_20;
				}
				return true;
			}
			IL_20:
			num2 = (short)1756692481;
			if (num2 != 0)
			{
			}
			dataButtonInnerSection = (self as global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO3.DataButtonInnerSection);
			IL_4E:
			num2 = (short)638976003;
			num = (int)((global::System.IntPtr)num2);
			goto IL_0A;
		}

		// Token: 0x06008976 RID: 35190 RVA: 0x00804658 File Offset: 0x00802858
		internal static bool ConO3DataButtonTrkIndexApplicable(global::AcpCommonLib.IAcpFeatureSection self)
		{
			int num;
			short num2;
			global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO3.DataButtonInnerSection dataButtonInnerSection;
			switch (0)
			{
			case 0:
				break;
			default:
				for (;;)
				{
					IL_0A:
					switch (num)
					{
					case 0:
						num2 = (short)218824706;
						num = (int)((global::System.IntPtr)num2);
						continue;
					case 1:
						return true;
					case 2:
					{
						num2 = (short)772014080;
						short num3 = num2;
						if (dataButtonInnerSection.CntrlHeadO3TrunkingO3DatatButtonFeature_A22597.Value == 227)
						{
							num2 = (short)1319043073;
							num = (int)((global::System.IntPtr)num2);
							continue;
						}
						goto IL_129;
					}
					case 3:
					{
						num2 = (short)1658153421;
						short num4 = num2;
						num2 = (short)331639245;
						switch ((num4 == num2) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_27;
						default:
							num2 = (short)181731328;
							if (num2 != 0)
							{
							}
							if (dataButtonInnerSection.RefRadioWide.DualRadio.RadWideDualRadioSelection_A42236.Value == 0)
							{
								num2 = (short)1620443136;
								num = (int)((global::System.IntPtr)num2);
								continue;
							}
							goto IL_129;
						}
						break;
					}
					}
					goto IL_20;
				}
				return true;
				IL_129:
				num2 = (short)1570045953;
				if (num2 != 0)
				{
				}
				return false;
			}
			IL_20:
			dataButtonInnerSection = (self as global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO3.DataButtonInnerSection);
			IL_27:
			num2 = (short)1718943747;
			num = (int)((global::System.IntPtr)num2);
			goto IL_0A;
		}

		// Token: 0x06008977 RID: 35191 RVA: 0x008047B8 File Offset: 0x008029B8
		public static void ConValueSetIfDataCnvIndexChanged(global::AcpCommonLib.IAcpFeatureSection self, global::AcpCommonLib.UndoRedo.ContainerTask task)
		{
			short num = (short)1805385728;
			int num2 = (int)num;
			switch (num2)
			{
			default:
			{
				switch (0)
				{
				case 0:
					goto IL_117;
				}
				global::AcpBusinessLayer.AcpListField acpListField;
				global::AcpBusinessLayer.AcpListField acpListField2;
				int featureSectionId;
				for (;;)
				{
					IL_28:
					bool flag;
					global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO3.DataButtonInnerRecset dataButtonInnerRecset;
					global::Motorola.MackinawCPS.CoreFeatures.KeypadMicAndAccessories.DataButtonInnerRecset dataButtonInnerRecset2;
					global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO9.ControlHeadO9Recset controlHeadO9Recset;
					global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO9.O9DataButtonInnerRecset o9DataButtonInnerRecset;
					global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO7.ControlHeadO7Recset controlHeadO7Recset;
					global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO3.ControlHeadO3Recset controlHeadO3Recset;
					global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO7.O7DataButtonInnerRecset o7DataButtonInnerRecset;
					global::Motorola.MackinawCPS.CoreFeatures.KeypadMicAndAccessories.KeypadMicAndAccessoriesRecset keypadMicAndAccessoriesRecset;
					global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO9.ConsolidatedActionBCOListInnerSection consolidatedActionBCOListInnerSection;
					switch (num2)
					{
					case 0:
						goto IL_BE3;
					case 1:
						num = (short)659226660;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 2:
						if (acpListField != null)
						{
							num = (short)1073676318;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return;
					case 3:
						num = (short)1427374099;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 4:
						return;
					case 5:
						goto IL_16B3;
					case 6:
						try
						{
							num = (short)1225523203;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								switch (num2)
								{
								case 0:
									num = (short)1827536898;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 1:
									goto IL_7A0;
								case 2:
									goto IL_6DD;
								case 3:
									switch (0)
									{
									case 0:
										goto IL_5A3;
									}
									continue;
								case 4:
								{
									global::System.Collections.Generic.IEnumerator<global::AcpBusinessLayer.FeatureNode> enumerator;
									if (!enumerator.MoveNext())
									{
										num = (short)145948678;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									global::AcpCommonLib.IAcpFeatureNode acpFeatureNode = enumerator.Current;
									num = (short)29622282;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 5:
									goto IL_5EC;
								case 6:
									num = (short)1833304065;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 7:
									goto IL_68D;
								case 8:
									if (flag)
									{
										num = (short)24379392;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									break;
								case 9:
								{
									global::AcpCommonLib.IAcpFeatureNode acpFeatureNode;
									task.AddTask(new global::AcpBusinessLayer.UndoRedo.ModifyRecRefDataTask((acpFeatureNode[10209] as global::Motorola.MackinawCPS.CoreFeatures.KeypadMicAndAccessories.DataButtonInnerSection).RadErgoCfgKMTrunkingKMDatatButtonIndex_A41424, acpListField2.UIValue));
									flag = true;
									num = (short)663486471;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 10:
								{
									global::AcpCommonLib.IAcpFeatureNode acpFeatureNode;
									if (acpListField2.Value != (acpFeatureNode[10209] as global::Motorola.MackinawCPS.CoreFeatures.KeypadMicAndAccessories.DataButtonInnerSection).RadErgoCfgKMConventionalKMDatatButtonIndex_A41423.Value)
									{
										num = (short)1720647692;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									goto IL_5EC;
								}
								case 11:
								{
									global::AcpCommonLib.IAcpFeatureNode acpFeatureNode;
									if (acpListField2.Value != (acpFeatureNode[10209] as global::Motorola.MackinawCPS.CoreFeatures.KeypadMicAndAccessories.DataButtonInnerSection).RadErgoCfgKMTrunkingKMDatatButtonIndex_A41424.Value)
									{
										num = (short)883032073;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									goto IL_68D;
								}
								case 12:
								{
									global::AcpCommonLib.IAcpFeatureNode acpFeatureNode;
									task.AddTask(new global::AcpBusinessLayer.UndoRedo.ModifyRecRefDataTask((acpFeatureNode[10209] as global::Motorola.MackinawCPS.CoreFeatures.KeypadMicAndAccessories.DataButtonInnerSection).RadErgoCfgKMConventionalKMDatatButtonIndex_A41423, acpListField2.UIValue));
									flag = true;
									num = (short)222035973;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								}
								goto IL_5A3;
								IL_5EC:
								num = (short)1619066891;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								IL_68D:
								num = (short)305856520;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								IL_6E2:
								num = (short)1459945476;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								IL_5A3:
								goto IL_6E2;
							}
							IL_6DD:
							IL_7A0:
							goto IL_136F;
						}
						finally
						{
							num = (short)456720386;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								global::System.Collections.Generic.IEnumerator<global::AcpBusinessLayer.FeatureNode> enumerator;
								switch (num2)
								{
								case 0:
									goto IL_80F;
								case 1:
									enumerator.Dispose();
									num = (short)1474625536;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 2:
									switch (0)
									{
									case 0:
										goto IL_7D8;
									}
									continue;
								}
								IL_7D8:
								if (enumerator == null)
								{
									break;
								}
								num = (short)792264705;
								num2 = (int)((global::System.IntPtr)num);
							}
							IL_80F:;
						}
						goto IL_812;
					case 7:
						if (featureSectionId <= 10212)
						{
							num = (short)1406599186;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)58196017;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 8:
					{
						flag = false;
						global::System.Collections.Generic.IEnumerator<global::AcpBusinessLayer.FeatureNode> enumerator = dataButtonInnerRecset.GetEnumerator();
						num = (short)1880490036;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 9:
						if (featureSectionId != 10623)
						{
							num = (short)219611182;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_812;
					case 10:
					{
						global::System.Collections.Generic.IEnumerator<global::AcpBusinessLayer.FeatureNode> enumerator = dataButtonInnerRecset2.GetEnumerator();
						num = (short)1698168838;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 11:
						num = (short)1988362262;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 12:
						if (dataButtonInnerRecset2 != null)
						{
							num = (short)1748697098;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_136F;
					case 13:
						goto IL_1418;
					case 14:
						o9DataButtonInnerRecset = (controlHeadO9Recset[0][10611].EmbeddedRecset as global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO9.O9DataButtonInnerRecset);
						num = (short)584318981;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 15:
						try
						{
							num = (short)1237843971;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								switch (num2)
								{
								case 0:
								{
									global::AcpCommonLib.IAcpFeatureNode acpFeatureNode2;
									if (acpListField2.Value != (acpFeatureNode2[10713] as global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO7.O7DataButtonInnerSection).CHO7DataButtonTrkIndex_A41418.Value)
									{
										num = (short)1148583938;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									goto IL_244;
								}
								case 1:
									goto IL_3BA;
								case 2:
								{
									global::AcpCommonLib.IAcpFeatureNode acpFeatureNode2;
									task.AddTask(new global::AcpBusinessLayer.UndoRedo.ModifyRecRefDataTask((acpFeatureNode2[10713] as global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO7.O7DataButtonInnerSection).CHO7DataButtonTrkIndex_A41418, acpListField2.UIValue));
									flag = true;
									num = (short)1290862596;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 3:
									switch (0)
									{
									case 0:
										goto IL_1BE;
									}
									continue;
								case 4:
									goto IL_244;
								case 5:
									if (flag)
									{
										num = (short)1461911560;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									break;
								case 6:
								{
									global::AcpCommonLib.IAcpFeatureNode acpFeatureNode2;
									if (acpListField2.Value != (acpFeatureNode2[10713] as global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO7.O7DataButtonInnerSection).CHO7DataButtonConvIndex_A41417.Value)
									{
										num = (short)1442906122;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									goto IL_281;
								}
								case 7:
								{
									global::System.Collections.Generic.IEnumerator<global::AcpBusinessLayer.FeatureNode> enumerator;
									if (!enumerator.MoveNext())
									{
										num = (short)1940389899;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									global::AcpCommonLib.IAcpFeatureNode acpFeatureNode2 = enumerator.Current;
									num = (short)1911291910;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 8:
									num = (short)1254227980;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 9:
									goto IL_281;
								case 10:
								{
									global::AcpCommonLib.IAcpFeatureNode acpFeatureNode2;
									task.AddTask(new global::AcpBusinessLayer.UndoRedo.ModifyRecRefDataTask((acpFeatureNode2[10713] as global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO7.O7DataButtonInnerSection).CHO7DataButtonConvIndex_A41417, acpListField2.UIValue));
									flag = true;
									num = (short)1946812425;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 11:
									num = (short)1695088641;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 12:
									goto IL_39C;
								}
								IL_1C3:
								num = (short)1815281671;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								IL_1BE:
								goto IL_1C3;
								IL_244:
								num = (short)584777733;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								IL_281:
								num = (short)496173056;
								num2 = (int)((global::System.IntPtr)num);
							}
							IL_39C:
							IL_3BA:
							goto IL_146A;
						}
						finally
						{
							num = (short)803405825;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								global::System.Collections.Generic.IEnumerator<global::AcpBusinessLayer.FeatureNode> enumerator;
								switch (num2)
								{
								case 0:
									enumerator.Dispose();
									num = (short)1809645570;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 1:
									switch (0)
									{
									case 0:
										goto IL_3F1;
									}
									continue;
								case 2:
									goto IL_429;
								}
								IL_3F1:
								if (enumerator == null)
								{
									break;
								}
								num = (short)1350369280;
								num2 = (int)((global::System.IntPtr)num);
							}
							IL_429:;
						}
						goto IL_42C;
					case 16:
						if (controlHeadO7Recset != null)
						{
							num = (short)1979908141;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_1418;
					case 17:
					{
						if (featureSectionId != 10212)
						{
							num = (short)1146617894;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO3.DataButtonInnerSection dataButtonInnerSection = self as global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO3.DataButtonInnerSection;
						acpListField2 = dataButtonInnerSection.CHO3DataButtonConvIndex_A41419;
						acpListField = dataButtonInnerSection.CntrlHeadO3ConventionalO3DatatButtonFeature_A22595;
						num = (short)43057175;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 18:
						num = (short)1204748316;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 19:
						if (acpListField.Value == 227)
						{
							num = (short)1465778205;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return;
					case 20:
						num = (short)1915748361;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 21:
						goto IL_BE3;
					case 22:
						if (controlHeadO9Recset.Count > 0)
						{
							num = (short)929103926;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return;
					case 23:
						goto IL_BE3;
					case 24:
						goto IL_15C3;
					case 25:
						dataButtonInnerRecset = (controlHeadO3Recset[0][10234].EmbeddedRecset as global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO3.DataButtonInnerRecset);
						num = (short)253558828;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 26:
					{
						num = (short)1938817024;
						short num3 = num;
						if (o7DataButtonInnerRecset != null)
						{
							num = (short)1329791008;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_146A;
					}
					case 27:
						if (controlHeadO9Recset != null)
						{
							num = (short)886439950;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_16B3;
					case 28:
					{
						if (featureSectionId != 10209)
						{
							num = (short)1361510431;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						global::Motorola.MackinawCPS.CoreFeatures.KeypadMicAndAccessories.DataButtonInnerSection dataButtonInnerSection2 = self as global::Motorola.MackinawCPS.CoreFeatures.KeypadMicAndAccessories.DataButtonInnerSection;
						acpListField2 = dataButtonInnerSection2.RadErgoCfgKMConventionalKMDatatButtonIndex_A41423;
						acpListField = dataButtonInnerSection2.RadErgoCfgKMConventionalKMDatatButtonFeature_A22603;
						num = (short)208076843;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 29:
						goto IL_14E4;
					case 30:
						num = (short)1870528559;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 31:
						num = (short)2025324561;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 32:
					{
						flag = false;
						global::System.Collections.Generic.IEnumerator<global::AcpBusinessLayer.FeatureNode> enumerator = o7DataButtonInnerRecset.GetEnumerator();
						num = (short)1248985103;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 33:
						if (o9DataButtonInnerRecset != null)
						{
							num = (short)1632043042;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_1636;
					case 34:
					{
						flag = false;
						global::System.Collections.Generic.IEnumerator<global::AcpBusinessLayer.FeatureNode> enumerator = o9DataButtonInnerRecset.GetEnumerator();
						num = (short)712966185;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 35:
						try
						{
							num = (short)1714028550;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								switch (num2)
								{
								case 0:
									goto IL_97B;
								case 1:
								{
									global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO9.ConsolidatedActionBCOListInner consolidatedActionBCOListInner;
									if (acpListField2.Value != consolidatedActionBCOListInner.ConsolidatedActionBCOListInnerSection.RadErgoControlO9ACBCOListIndex_A36668.Value)
									{
										num = (short)902430728;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									goto IL_A6A;
								}
								case 2:
									goto IL_A82;
								case 3:
								{
									global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO9.ConsolidatedActionBCOListInner consolidatedActionBCOListInner;
									if (consolidatedActionBCOListInner.ConsolidatedActionBCOListInnerSection.RadErgoControlO9ACBCOListBco_A36666.Value == 134)
									{
										num = (short)325451783;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									break;
								}
								case 4:
									goto IL_A6A;
								case 5:
								{
									global::System.Collections.Generic.IEnumerator<global::AcpBusinessLayer.FeatureNode> enumerator;
									if (!enumerator.MoveNext())
									{
										num = (short)1540554756;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO9.ConsolidatedActionBCOListInner consolidatedActionBCOListInner = (global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO9.ConsolidatedActionBCOListInner)enumerator.Current;
									num = (short)210122557;
									short num4 = num;
									num = (short)492189501;
									switch ((num4 == num) ? 1 : 0)
									{
									case 0:
									case 2:
										goto IL_97B;
									default:
										num = (short)1209860096;
										if (num != 0)
										{
										}
										num = (short)1262157827;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									break;
								}
								case 6:
									switch (0)
									{
									case 0:
										goto IL_8F8;
									}
									continue;
								case 7:
									num = (short)1565655041;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 8:
								{
									global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO9.ConsolidatedActionBCOListInner consolidatedActionBCOListInner;
									task.AddTask(new global::AcpBusinessLayer.UndoRedo.ModifyRecRefDataTask(consolidatedActionBCOListInner.ConsolidatedActionBCOListInnerSection.RadErgoControlO9ACBCOListIndex_A36668, acpListField2.UIValue));
									num = (short)1844707328;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								}
								IL_980:
								num = (short)1229783045;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								IL_8F8:
								goto IL_980;
								IL_A6A:
								num = (short)1242955778;
								num2 = (int)((global::System.IntPtr)num);
							}
							IL_97B:
							IL_A82:
							return;
						}
						finally
						{
							num = (short)1807941634;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								global::System.Collections.Generic.IEnumerator<global::AcpBusinessLayer.FeatureNode> enumerator;
								switch (num2)
								{
								case 0:
									goto IL_AF0;
								case 1:
									enumerator.Dispose();
									num = (short)1005649920;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 2:
									switch (0)
									{
									case 0:
										goto IL_AB9;
									}
									continue;
								}
								IL_AB9:
								if (enumerator == null)
								{
									break;
								}
								num = (short)1081147393;
								num2 = (int)((global::System.IntPtr)num);
							}
							IL_AF0:;
						}
						goto IL_AF3;
					case 36:
						goto IL_BE3;
					case 37:
						dataButtonInnerRecset2 = (keypadMicAndAccessoriesRecset[0][10228].EmbeddedRecset as global::Motorola.MackinawCPS.CoreFeatures.KeypadMicAndAccessories.DataButtonInnerRecset);
						num = (short)452526104;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 38:
						num = (short)375259189;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 39:
						if (acpListField2 == null)
						{
							num = (short)1675231236;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_FC4;
					case 40:
						acpListField2 = consolidatedActionBCOListInnerSection.RadErgoControlO9ACBCOListIndex_A36668;
						num = (short)424542256;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 41:
						try
						{
							num = (short)505937923;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								switch (num2)
								{
								case 0:
									num = (short)1137049602;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 1:
									num = (short)1373831179;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 2:
									goto IL_129F;
								case 3:
									switch (0)
									{
									case 0:
										goto IL_10A2;
									}
									continue;
								case 4:
								{
									global::AcpCommonLib.IAcpFeatureNode acpFeatureNode3;
									if (acpListField2.Value != (acpFeatureNode3[10608] as global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO9.O9DataButtonInnerSection).CHO9DataButtonTrkIndex_A41416.Value)
									{
										num = (short)226230277;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									goto IL_10A7;
								}
								case 5:
								{
									global::AcpCommonLib.IAcpFeatureNode acpFeatureNode3;
									task.AddTask(new global::AcpBusinessLayer.UndoRedo.ModifyRecRefDataTask((acpFeatureNode3[10608] as global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO9.O9DataButtonInnerSection).CHO9DataButtonTrkIndex_A41416, acpListField2.UIValue));
									flag = true;
									num = (short)146931724;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 6:
									goto IL_1167;
								case 7:
								{
									global::AcpCommonLib.IAcpFeatureNode acpFeatureNode3;
									task.AddTask(new global::AcpBusinessLayer.UndoRedo.ModifyRecRefDataTask((acpFeatureNode3[10608] as global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO9.O9DataButtonInnerSection).CHO9DataButtonConvIndex_A41414, acpListField2.UIValue));
									flag = true;
									num = (short)85983238;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 8:
								{
									global::AcpCommonLib.IAcpFeatureNode acpFeatureNode3;
									if (acpListField2.Value != (acpFeatureNode3[10608] as global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO9.O9DataButtonInnerSection).CHO9DataButtonConvIndex_A41414.Value)
									{
										num = (short)546242567;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									goto IL_1167;
								}
								case 9:
								{
									global::System.Collections.Generic.IEnumerator<global::AcpBusinessLayer.FeatureNode> enumerator;
									if (!enumerator.MoveNext())
									{
										num = (short)800063488;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									global::AcpCommonLib.IAcpFeatureNode acpFeatureNode3 = enumerator.Current;
									num = (short)741146632;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 10:
									if (flag)
									{
										num = (short)985726977;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									break;
								case 11:
									goto IL_1282;
								case 12:
									goto IL_10A7;
								}
								goto IL_10A2;
								IL_10A7:
								num = (short)99811338;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								IL_1167:
								num = (short)1511587844;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								IL_11C3:
								num = (short)1333329929;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								IL_10A2:
								goto IL_11C3;
							}
							IL_1282:
							IL_129F:
							goto IL_1636;
						}
						finally
						{
							num = (short)1723990018;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								global::System.Collections.Generic.IEnumerator<global::AcpBusinessLayer.FeatureNode> enumerator;
								switch (num2)
								{
								case 0:
									goto IL_130D;
								case 1:
									enumerator.Dispose();
									num = (short)40304640;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 2:
									switch (0)
									{
									case 0:
										goto IL_12D6;
									}
									continue;
								}
								IL_12D6:
								if (enumerator == null)
								{
									break;
								}
								num = (short)565248001;
								num2 = (int)((global::System.IntPtr)num);
							}
							IL_130D:;
						}
						return;
					case 42:
						if (dataButtonInnerRecset != null)
						{
							num = (short)2114846728;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_49E;
					case 43:
						goto IL_BE3;
					case 44:
						goto IL_AF3;
					case 45:
						o7DataButtonInnerRecset = (controlHeadO7Recset[0][10717].EmbeddedRecset as global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO7.O7DataButtonInnerRecset);
						num = (short)2031550477;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 46:
						num = (short)461111353;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 47:
						if (acpListField.Value != 134)
						{
							num = (short)1034027011;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_14E4;
					case 48:
						goto IL_BE3;
					case 49:
						if (featureSectionId != 10608)
						{
							num = (short)1856176148;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_42C;
					case 50:
						if (134 == consolidatedActionBCOListInnerSection.RadErgoControlO9ACBCOListBco_A36666.Value)
						{
							num = (short)2033385512;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_BE3;
					case 51:
						if (controlHeadO9Recset != null)
						{
							num = (short)527892491;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return;
					case 52:
						num = (short)1756758017;
						if (num != 0)
						{
						}
						try
						{
							num = (short)398786563;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								switch (num2)
								{
								case 0:
									num = (short)1879965704;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 1:
								{
									global::AcpCommonLib.IAcpFeatureNode acpFeatureNode4;
									if (acpListField2.Value != (acpFeatureNode4[10212] as global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO3.DataButtonInnerSection).CHO3DataButtonConvIndex_A41419.Value)
									{
										num = (short)655032332;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									goto IL_E0D;
								}
								case 2:
									goto IL_F51;
								case 3:
									switch (0)
									{
									case 0:
										goto IL_D64;
									}
									continue;
								case 4:
								{
									global::AcpCommonLib.IAcpFeatureNode acpFeatureNode4;
									task.AddTask(new global::AcpBusinessLayer.UndoRedo.ModifyRecRefDataTask((acpFeatureNode4[10212] as global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO3.DataButtonInnerSection).CHO3DataButtonTrkIndex_A41420, acpListField2.UIValue));
									flag = true;
									num = (short)506068997;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 5:
									goto IL_EA7;
								case 6:
								{
									global::AcpCommonLib.IAcpFeatureNode acpFeatureNode4;
									if (acpListField2.Value != (acpFeatureNode4[10212] as global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO3.DataButtonInnerSection).CHO3DataButtonTrkIndex_A41420.Value)
									{
										num = (short)1495597060;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									goto IL_EA7;
								}
								case 7:
								{
									global::System.Collections.Generic.IEnumerator<global::AcpBusinessLayer.FeatureNode> enumerator;
									if (!enumerator.MoveNext())
									{
										num = (short)947585035;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									global::AcpCommonLib.IAcpFeatureNode acpFeatureNode4 = enumerator.Current;
									num = (short)580517889;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 8:
									goto IL_EF5;
								case 9:
									if (flag)
									{
										num = (short)2112880640;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									break;
								case 10:
									goto IL_E0D;
								case 11:
									num = (short)276365314;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 12:
								{
									global::AcpCommonLib.IAcpFeatureNode acpFeatureNode4;
									task.AddTask(new global::AcpBusinessLayer.UndoRedo.ModifyRecRefDataTask((acpFeatureNode4[10212] as global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO3.DataButtonInnerSection).CHO3DataButtonConvIndex_A41419, acpListField2.UIValue));
									flag = true;
									num = (short)592838666;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								}
								goto IL_D64;
								IL_E0D:
								num = (short)268632070;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								IL_EA7:
								num = (short)1327562761;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								IL_EFA:
								num = (short)785252359;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								IL_D64:
								goto IL_EFA;
							}
							IL_EF5:
							IL_F51:
							goto IL_49E;
						}
						finally
						{
							num = (short)2063466498;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								global::System.Collections.Generic.IEnumerator<global::AcpBusinessLayer.FeatureNode> enumerator;
								switch (num2)
								{
								case 0:
									goto IL_FC1;
								case 1:
									enumerator.Dispose();
									num = (short)1401815040;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 2:
									switch (0)
									{
									case 0:
										goto IL_F89;
									}
									continue;
								}
								IL_F89:
								if (enumerator == null)
								{
									break;
								}
								num = (short)212074497;
								num2 = (int)((global::System.IntPtr)num);
							}
							IL_FC1:;
						}
						goto IL_FC4;
					case 53:
						goto IL_BE3;
					case 54:
					{
						global::System.Collections.Generic.IEnumerator<global::AcpBusinessLayer.FeatureNode> enumerator = (controlHeadO9Recset[0][10622].EmbeddedRecset as global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO9.ConsolidatedActionBCOListInnerRecset).GetEnumerator();
						num = (short)157614115;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 55:
						if (keypadMicAndAccessoriesRecset != null)
						{
							num = (short)1672413221;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_15C3;
					case 56:
						if (controlHeadO3Recset != null)
						{
							num = (short)210370585;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_AF3;
					case 57:
					{
						if (featureSectionId != 10713)
						{
							num = (short)1035534337;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO7.O7DataButtonInnerSection o7DataButtonInnerSection = self as global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO7.O7DataButtonInnerSection;
						acpListField2 = o7DataButtonInnerSection.CHO7DataButtonConvIndex_A41417;
						acpListField = o7DataButtonInnerSection.RadErgCtrlHeadO7DataButtonCnvFeature_A41299;
						num = (short)1806106624;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					}
					goto IL_117;
					IL_42C:
					global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO9.O9DataButtonInnerSection o9DataButtonInnerSection = self as global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO9.O9DataButtonInnerSection;
					acpListField2 = o9DataButtonInnerSection.CHO9DataButtonConvIndex_A41414;
					acpListField = o9DataButtonInnerSection.RadErgCtrlHeadO9DataButtonCnvFeature_A36528;
					num = (short)1403715605;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_49E:
					num = (short)189005850;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_812:
					consolidatedActionBCOListInnerSection = (self as global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO9.ConsolidatedActionBCOListInnerSection);
					num = (short)1483931698;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_AF3:
					controlHeadO7Recset = null;
					o7DataButtonInnerRecset = null;
					controlHeadO7Recset = (global::AcpCommonLib.FeatureManager.GetFeature(4114) as global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO7.ControlHeadO7Recset);
					num = (short)1795227664;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_BE3:
					num = (short)75563047;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_FC4:
					keypadMicAndAccessoriesRecset = null;
					dataButtonInnerRecset2 = null;
					keypadMicAndAccessoriesRecset = (global::AcpCommonLib.FeatureManager.GetFeature(2128) as global::Motorola.MackinawCPS.CoreFeatures.KeypadMicAndAccessories.KeypadMicAndAccessoriesRecset);
					num = (short)1280835639;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_136F:
					num = (short)1275002922;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_1418:
					controlHeadO9Recset = null;
					o9DataButtonInnerRecset = null;
					controlHeadO9Recset = (global::AcpCommonLib.FeatureManager.GetFeature(4003) as global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO9.ControlHeadO9Recset);
					num = (short)125829147;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_146A:
					num = (short)100466721;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_14E4:
					num = (short)2107637811;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_15C3:
					controlHeadO3Recset = null;
					dataButtonInnerRecset = null;
					controlHeadO3Recset = (global::AcpCommonLib.FeatureManager.GetFeature(2127) as global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO3.ControlHeadO3Recset);
					num = (short)363135032;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_1636:
					num = (short)2052325378;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_16B3:
					flag = false;
					num = (short)230686732;
					num2 = (int)((global::System.IntPtr)num);
				}
				return;
				IL_117:
				acpListField2 = null;
				acpListField = null;
				featureSectionId = self.FeatureSectionId;
				num = (short)1439367175;
				num2 = (int)((global::System.IntPtr)num);
				goto IL_28;
			}
			}
		}

		// Token: 0x06008978 RID: 35192 RVA: 0x00805FB4 File Offset: 0x008041B4
		public static void ConValueSetIfDataTrkIndexChanged(global::AcpCommonLib.IAcpFeatureSection self, global::AcpCommonLib.UndoRedo.ContainerTask task)
		{
			short num = (short)734134272;
			int num2 = (int)num;
			switch (num2)
			{
			default:
			{
				switch (0)
				{
				case 0:
					goto IL_103;
				}
				global::AcpBusinessLayer.AcpListField acpListField;
				global::AcpBusinessLayer.AcpListField acpListField2;
				int featureSectionId;
				for (;;)
				{
					IL_28:
					global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO3.ControlHeadO3Recset controlHeadO3Recset;
					bool flag;
					global::System.Collections.Generic.IEnumerator<global::AcpBusinessLayer.FeatureNode> enumerator;
					global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO7.ControlHeadO7Recset controlHeadO7Recset;
					global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO7.O7DataButtonInnerRecset o7DataButtonInnerRecset;
					global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO9.O9DataButtonInnerRecset o9DataButtonInnerRecset;
					global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO3.DataButtonInnerRecset dataButtonInnerRecset;
					global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO9.ControlHeadO9Recset controlHeadO9Recset;
					global::Motorola.MackinawCPS.CoreFeatures.KeypadMicAndAccessories.DataButtonInnerRecset dataButtonInnerRecset2;
					switch (num2)
					{
					case 0:
						if (controlHeadO3Recset != null)
						{
							num = (short)685178912;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_80F;
					case 1:
						if (acpListField.Value != 134)
						{
							num = (short)2118778931;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_76B;
					case 2:
						try
						{
							num = (short)176357387;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								switch (num2)
								{
								case 0:
									goto IL_1CC;
								case 1:
									if (flag)
									{
										num = (short)272171017;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									break;
								case 2:
									goto IL_2EB;
								case 3:
									goto IL_3A8;
								case 4:
								{
									global::AcpCommonLib.IAcpFeatureNode acpFeatureNode;
									if (acpListField2.Value != (acpFeatureNode[10713] as global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO7.O7DataButtonInnerSection).CHO7DataButtonTrkIndex_A41418.Value)
									{
										num = (short)521535493;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									goto IL_1CC;
								}
								case 5:
								{
									global::AcpCommonLib.IAcpFeatureNode acpFeatureNode;
									task.AddTask(new global::AcpBusinessLayer.UndoRedo.ModifyRecRefDataTask((acpFeatureNode[10713] as global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO7.O7DataButtonInnerSection).CHO7DataButtonTrkIndex_A41418, acpListField2.UIValue));
									flag = true;
									num = (short)192086016;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 6:
								{
									if (!enumerator.MoveNext())
									{
										num = (short)438173708;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									global::AcpCommonLib.IAcpFeatureNode acpFeatureNode = enumerator.Current;
									num = (short)466878472;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 7:
									goto IL_1C7;
								case 8:
								{
									global::AcpCommonLib.IAcpFeatureNode acpFeatureNode;
									if (acpListField2.Value != (acpFeatureNode[10713] as global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO7.O7DataButtonInnerSection).CHO7DataButtonConvIndex_A41417.Value)
									{
										num = (short)2017984522;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									goto IL_2EB;
								}
								case 9:
									num = (short)1438646279;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 10:
								{
									global::AcpCommonLib.IAcpFeatureNode acpFeatureNode;
									task.AddTask(new global::AcpBusinessLayer.UndoRedo.ModifyRecRefDataTask((acpFeatureNode[10713] as global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO7.O7DataButtonInnerSection).CHO7DataButtonConvIndex_A41417, acpListField2.UIValue));
									flag = true;
									num = (short)499908610;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 11:
									switch (0)
									{
									case 0:
										goto IL_1AC;
									}
									continue;
								case 12:
									num = (short)1737621507;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								goto IL_1AC;
								IL_1CC:
								num = (short)339083265;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								IL_200:
								num = (short)1064960006;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								IL_1AC:
								goto IL_200;
								IL_2EB:
								num = (short)814088196;
								num2 = (int)((global::System.IntPtr)num);
							}
							IL_1C7:
							IL_3A8:
							goto IL_1304;
						}
						finally
						{
							num = (short)1047134209;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								switch (num2)
								{
								case 0:
									goto IL_418;
								case 1:
									switch (0)
									{
									case 0:
										goto IL_3DF;
									}
									continue;
								case 2:
									enumerator.Dispose();
									num = (short)247463936;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								IL_3DF:
								if (enumerator == null)
								{
									break;
								}
								num = (short)1683488770;
								num2 = (int)((global::System.IntPtr)num);
							}
							IL_418:;
						}
						goto IL_41B;
					case 3:
						goto IL_1287;
					case 4:
					{
						if (featureSectionId != 10209)
						{
							num = (short)776929310;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						global::Motorola.MackinawCPS.CoreFeatures.KeypadMicAndAccessories.DataButtonInnerSection dataButtonInnerSection = self as global::Motorola.MackinawCPS.CoreFeatures.KeypadMicAndAccessories.DataButtonInnerSection;
						acpListField2 = dataButtonInnerSection.RadErgoCfgKMTrunkingKMDatatButtonIndex_A41424;
						acpListField = dataButtonInnerSection.RadErgoCfgKMTrunkingKMDatatButtonFeature_A22605;
						num = (short)455999516;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 5:
						num = (short)495321092;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 6:
						if (controlHeadO7Recset != null)
						{
							num = (short)632356893;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_624;
					case 7:
						goto IL_76B;
					case 8:
						num = (short)706412558;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 9:
						num = (short)1724907521;
						if (num != 0)
						{
						}
						if (acpListField != null)
						{
							num = (short)414318639;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return;
					case 10:
						flag = false;
						enumerator = o7DataButtonInnerRecset.GetEnumerator();
						num = (short)168624130;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 11:
						goto IL_FC9;
					case 12:
						if (acpListField.Value == 227)
						{
							num = (short)1773797383;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return;
					case 13:
					{
						global::Motorola.MackinawCPS.CoreFeatures.KeypadMicAndAccessories.KeypadMicAndAccessoriesRecset keypadMicAndAccessoriesRecset;
						if (keypadMicAndAccessoriesRecset != null)
						{
							num = (short)250871833;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_866;
					}
					case 14:
						goto IL_5A2;
					case 15:
					{
						if (featureSectionId != 10608)
						{
							num = (short)573308965;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO9.O9DataButtonInnerSection o9DataButtonInnerSection = self as global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO9.O9DataButtonInnerSection;
						acpListField2 = o9DataButtonInnerSection.CHO9DataButtonTrkIndex_A41416;
						acpListField = o9DataButtonInnerSection.RadErgCtrlHeadO9DataButtonTrkFeature_A36526;
						num = (short)1336410143;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 16:
						goto IL_CB3;
					case 17:
					{
						num = (short)641138688;
						short num3 = num;
						if (o9DataButtonInnerRecset != null)
						{
							num = (short)322306090;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_488;
					}
					case 18:
						goto IL_866;
					case 19:
						if (dataButtonInnerRecset != null)
						{
							num = (short)1529741360;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_162A;
					case 20:
						goto IL_5A2;
					case 21:
					{
						if (featureSectionId != 10713)
						{
							num = (short)1249968171;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO7.O7DataButtonInnerSection o7DataButtonInnerSection = self as global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO7.O7DataButtonInnerSection;
						acpListField2 = o7DataButtonInnerSection.CHO7DataButtonTrkIndex_A41418;
						acpListField = o7DataButtonInnerSection.RadErgCtrlHeadO7DataButtonTrkFeature_A41297;
						num = (short)1079115828;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 22:
						goto IL_80F;
					case 23:
						if (o7DataButtonInnerRecset != null)
						{
							num = (short)1244725258;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_1304;
					case 24:
						enumerator = (controlHeadO9Recset[0][10622].EmbeddedRecset as global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO9.ConsolidatedActionBCOListInnerRecset).GetEnumerator();
						num = (short)1069088814;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 25:
					{
						global::Motorola.MackinawCPS.CoreFeatures.KeypadMicAndAccessories.KeypadMicAndAccessoriesRecset keypadMicAndAccessoriesRecset;
						dataButtonInnerRecset2 = (keypadMicAndAccessoriesRecset[0][10228].EmbeddedRecset as global::Motorola.MackinawCPS.CoreFeatures.KeypadMicAndAccessories.DataButtonInnerRecset);
						num = (short)390922258;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 26:
						if (controlHeadO9Recset != null)
						{
							num = (short)2021195816;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return;
					case 27:
						try
						{
							num = (short)401211400;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								switch (num2)
								{
								case 0:
									num = (short)80019466;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 1:
								{
									global::AcpCommonLib.IAcpFeatureNode acpFeatureNode2;
									task.AddTask(new global::AcpBusinessLayer.UndoRedo.ModifyRecRefDataTask((acpFeatureNode2[10212] as global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO3.DataButtonInnerSection).CHO3DataButtonTrkIndex_A41420, acpListField2.UIValue));
									flag = true;
									num = (short)729546763;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 2:
								{
									global::AcpCommonLib.IAcpFeatureNode acpFeatureNode2;
									task.AddTask(new global::AcpBusinessLayer.UndoRedo.ModifyRecRefDataTask((acpFeatureNode2[10212] as global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO3.DataButtonInnerSection).CHO3DataButtonConvIndex_A41419, acpListField2.UIValue));
									flag = true;
									num = (short)803143685;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 3:
									if (flag)
									{
										num = (short)2114322441;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									break;
								case 4:
								{
									global::AcpCommonLib.IAcpFeatureNode acpFeatureNode2;
									if (acpListField2.Value != (acpFeatureNode2[10212] as global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO3.DataButtonInnerSection).CHO3DataButtonTrkIndex_A41420.Value)
									{
										num = (short)1976893441;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									goto IL_149E;
								}
								case 5:
									goto IL_142A;
								case 6:
									goto IL_1499;
								case 7:
								{
									global::AcpCommonLib.IAcpFeatureNode acpFeatureNode2;
									if (acpListField2.Value != (acpFeatureNode2[10212] as global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO3.DataButtonInnerSection).CHO3DataButtonConvIndex_A41419.Value)
									{
										num = (short)362741762;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									goto IL_142A;
								}
								case 8:
									switch (0)
									{
									case 0:
										goto IL_13C6;
									}
									continue;
								case 9:
									num = (short)1933312006;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 10:
									goto IL_15BB;
								case 11:
									goto IL_149E;
								case 12:
								{
									if (!enumerator.MoveNext())
									{
										num = (short)1996619776;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									global::AcpCommonLib.IAcpFeatureNode acpFeatureNode2 = enumerator.Current;
									num = (short)709623815;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								}
								goto IL_13C6;
								IL_142A:
								num = (short)281542660;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								IL_149E:
								num = (short)1057488899;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								IL_1564:
								num = (short)1657470988;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								IL_13C6:
								goto IL_1564;
							}
							IL_1499:
							IL_15BB:;
						}
						finally
						{
							num = (short)1221459968;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								switch (num2)
								{
								case 0:
									switch (0)
									{
									case 0:
										goto IL_15EF;
									}
									continue;
								case 1:
									enumerator.Dispose();
									num = (short)1668022274;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 2:
									goto IL_1627;
								}
								IL_15EF:
								if (enumerator == null)
								{
									break;
								}
								num = (short)457637889;
								num2 = (int)((global::System.IntPtr)num);
							}
							IL_1627:;
						}
						goto IL_162A;
					case 28:
						goto IL_5A2;
					case 29:
						o7DataButtonInnerRecset = (controlHeadO7Recset[0][10717].EmbeddedRecset as global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO7.O7DataButtonInnerRecset);
						num = (short)1032978473;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 30:
						num = (short)1034747949;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 31:
						goto IL_5A2;
					case 32:
						dataButtonInnerRecset = (controlHeadO3Recset[0][10234].EmbeddedRecset as global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO3.DataButtonInnerRecset);
						num = (short)1533804566;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 33:
						if (dataButtonInnerRecset2 != null)
						{
							num = (short)1236664331;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_41B;
					case 34:
						try
						{
							num = (short)59244555;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								switch (num2)
								{
								case 0:
									goto IL_DDE;
								case 1:
								{
									if (!enumerator.MoveNext())
									{
										num = (short)2023161865;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									global::AcpCommonLib.IAcpFeatureNode acpFeatureNode3 = enumerator.Current;
									num = (short)1619001349;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 2:
								{
									global::AcpCommonLib.IAcpFeatureNode acpFeatureNode3;
									task.AddTask(new global::AcpBusinessLayer.UndoRedo.ModifyRecRefDataTask((acpFeatureNode3[10608] as global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO9.O9DataButtonInnerSection).CHO9DataButtonConvIndex_A41414, acpListField2.UIValue));
									flag = true;
									num = (short)712048640;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 3:
									goto IL_F54;
								case 4:
									goto IL_ED1;
								case 5:
								{
									global::AcpCommonLib.IAcpFeatureNode acpFeatureNode3;
									if (acpListField2.Value != (acpFeatureNode3[10608] as global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO9.O9DataButtonInnerSection).CHO9DataButtonConvIndex_A41414.Value)
									{
										num = (short)87031810;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									goto IL_DDE;
								}
								case 6:
								{
									global::AcpCommonLib.IAcpFeatureNode acpFeatureNode3;
									if (acpListField2.Value != (acpFeatureNode3[10608] as global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO9.O9DataButtonInnerSection).CHO9DataButtonTrkIndex_A41416.Value)
									{
										num = (short)1806761996;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									goto IL_E7E;
								}
								case 7:
									goto IL_E7E;
								case 8:
									if (flag)
									{
										num = (short)523698186;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									break;
								case 9:
									num = (short)374210563;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 10:
									num = (short)1162084356;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 11:
									switch (0)
									{
									case 0:
										goto IL_D4D;
									}
									continue;
								case 12:
								{
									global::AcpCommonLib.IAcpFeatureNode acpFeatureNode3;
									task.AddTask(new global::AcpBusinessLayer.UndoRedo.ModifyRecRefDataTask((acpFeatureNode3[10608] as global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO9.O9DataButtonInnerSection).CHO9DataButtonTrkIndex_A41416, acpListField2.UIValue));
									flag = true;
									num = (short)2138308615;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								}
								IL_D9B:
								num = (short)175964161;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								IL_D4D:
								goto IL_D9B;
								IL_DDE:
								num = (short)2118647814;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								IL_E7E:
								num = (short)1510342664;
								num2 = (int)((global::System.IntPtr)num);
							}
							IL_ED1:
							IL_F54:
							goto IL_488;
						}
						finally
						{
							num = (short)1730674688;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								switch (num2)
								{
								case 0:
									switch (0)
									{
									case 0:
										goto IL_F8C;
									}
									continue;
								case 1:
									enumerator.Dispose();
									num = (short)159580162;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 2:
									goto IL_FC6;
								}
								IL_F8C:
								if (enumerator == null)
								{
									break;
								}
								num = (short)146079745;
								num2 = (int)((global::System.IntPtr)num);
							}
							IL_FC6:;
						}
						goto IL_FC9;
					case 35:
						return;
					case 36:
					{
						if (acpListField2 == null)
						{
							num = (short)1515257891;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						global::Motorola.MackinawCPS.CoreFeatures.KeypadMicAndAccessories.KeypadMicAndAccessoriesRecset keypadMicAndAccessoriesRecset = null;
						dataButtonInnerRecset2 = null;
						keypadMicAndAccessoriesRecset = (global::AcpCommonLib.FeatureManager.GetFeature(2128) as global::Motorola.MackinawCPS.CoreFeatures.KeypadMicAndAccessories.KeypadMicAndAccessoriesRecset);
						num = (short)145752077;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 37:
						num = (short)994377749;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 38:
						goto IL_5A2;
					case 39:
						if (featureSectionId <= 10212)
						{
							num = (short)1721106437;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)951058447;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 40:
						num = (short)328269873;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 41:
						goto IL_624;
					case 42:
						flag = false;
						enumerator = o9DataButtonInnerRecset.GetEnumerator();
						num = (short)2106589218;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 43:
						num = (short)1182728212;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 44:
						try
						{
							num = (short)537657355;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								switch (num2)
								{
								case 0:
									num = (short)1297481734;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 1:
								{
									global::AcpCommonLib.IAcpFeatureNode acpFeatureNode4;
									if (acpListField2.Value != (acpFeatureNode4[10209] as global::Motorola.MackinawCPS.CoreFeatures.KeypadMicAndAccessories.DataButtonInnerSection).RadErgoCfgKMConventionalKMDatatButtonIndex_A41423.Value)
									{
										num = (short)540999689;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									goto IL_AFC;
								}
								case 2:
									num = (short)1235615747;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 3:
									goto IL_BF6;
								case 4:
									goto IL_AFC;
								case 5:
								{
									if (!enumerator.MoveNext())
									{
										num = (short)958988290;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									global::AcpCommonLib.IAcpFeatureNode acpFeatureNode4 = enumerator.Current;
									num = (short)813432833;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 6:
									goto IL_ABE;
								case 7:
									goto IL_AC3;
								case 8:
								{
									global::AcpCommonLib.IAcpFeatureNode acpFeatureNode4;
									if (acpListField2.Value != (acpFeatureNode4[10209] as global::Motorola.MackinawCPS.CoreFeatures.KeypadMicAndAccessories.DataButtonInnerSection).RadErgoCfgKMTrunkingKMDatatButtonIndex_A41424.Value)
									{
										num = (short)379191306;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									goto IL_AC3;
								}
								case 9:
								{
									global::AcpCommonLib.IAcpFeatureNode acpFeatureNode4;
									task.AddTask(new global::AcpBusinessLayer.UndoRedo.ModifyRecRefDataTask((acpFeatureNode4[10209] as global::Motorola.MackinawCPS.CoreFeatures.KeypadMicAndAccessories.DataButtonInnerSection).RadErgoCfgKMConventionalKMDatatButtonIndex_A41423, acpListField2.UIValue));
									flag = true;
									num = (short)525205508;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 10:
								{
									global::AcpCommonLib.IAcpFeatureNode acpFeatureNode4;
									task.AddTask(new global::AcpBusinessLayer.UndoRedo.ModifyRecRefDataTask((acpFeatureNode4[10209] as global::Motorola.MackinawCPS.CoreFeatures.KeypadMicAndAccessories.DataButtonInnerSection).RadErgoCfgKMTrunkingKMDatatButtonIndex_A41424, acpListField2.UIValue));
									flag = true;
									num = (short)1159528455;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 11:
									switch (0)
									{
									case 0:
										goto IL_9FB;
									}
									continue;
								case 12:
									if (flag)
									{
										num = (short)1786511360;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									break;
								}
								goto IL_9FB;
								IL_AC3:
								num = (short)873005068;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								IL_AFC:
								num = (short)1176567816;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								IL_B9C:
								num = (short)1049886725;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								IL_9FB:
								goto IL_B9C;
							}
							IL_ABE:
							IL_BF6:
							goto IL_41B;
						}
						finally
						{
							num = (short)1112670209;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								num = (short)1433561008;
								short num4 = num;
								num = (short)1211656112;
								switch ((num4 == num) ? 1 : 0)
								{
								case 0:
								case 2:
									break;
								default:
									num = (short)2081751040;
									if (num != 0)
									{
									}
									switch (num2)
									{
									case 0:
										goto IL_CB0;
									case 1:
										switch (0)
										{
										case 0:
											goto IL_C76;
										}
										continue;
									case 2:
										enumerator.Dispose();
										num = (short)1845690368;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									IL_C76:
									if (enumerator == null)
									{
										goto IL_CB2;
									}
									break;
								}
								num = (short)1062535170;
								num2 = (int)((global::System.IntPtr)num);
							}
							IL_CB0:
							IL_CB2:;
						}
						goto IL_CB3;
					case 45:
					{
						if (featureSectionId != 10212)
						{
							num = (short)1845428232;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO3.DataButtonInnerSection dataButtonInnerSection2 = self as global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO3.DataButtonInnerSection;
						acpListField2 = dataButtonInnerSection2.CHO3DataButtonTrkIndex_A41420;
						acpListField = dataButtonInnerSection2.CntrlHeadO3TrunkingO3DatatButtonFeature_A22597;
						num = (short)1365245990;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 46:
						try
						{
							num = (short)1072758788;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								switch (num2)
								{
								case 0:
								{
									global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO9.ConsolidatedActionBCOListInner consolidatedActionBCOListInner;
									if (consolidatedActionBCOListInner.ConsolidatedActionBCOListInnerSection.RadErgoControlO9ACBCOListBco_A36666.Value == 134)
									{
										num = (short)201392130;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									break;
								}
								case 1:
								{
									global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO9.ConsolidatedActionBCOListInner consolidatedActionBCOListInner;
									if (acpListField2.Value != consolidatedActionBCOListInner.ConsolidatedActionBCOListInnerSection.RadErgoControlO9ACBCOListIndex_A36668.Value)
									{
										num = (short)2100822021;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									goto IL_11FD;
								}
								case 2:
									num = (short)1312489473;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 3:
									goto IL_1215;
								case 4:
									switch (0)
									{
									case 0:
										goto IL_10D6;
									}
									continue;
								case 5:
								{
									global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO9.ConsolidatedActionBCOListInner consolidatedActionBCOListInner;
									task.AddTask(new global::AcpBusinessLayer.UndoRedo.ModifyRecRefDataTask(consolidatedActionBCOListInner.ConsolidatedActionBCOListInnerSection.RadErgoControlO9ACBCOListIndex_A36668, acpListField2.UIValue));
									num = (short)584384519;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 6:
								{
									if (!enumerator.MoveNext())
									{
										num = (short)1217331208;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO9.ConsolidatedActionBCOListInner consolidatedActionBCOListInner = (global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO9.ConsolidatedActionBCOListInner)enumerator.Current;
									num = (short)394199040;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 7:
									goto IL_11B9;
								case 8:
									goto IL_11FD;
								}
								IL_11BE:
								num = (short)2103181318;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								IL_10D6:
								goto IL_11BE;
								IL_11FD:
								num = (short)1544552451;
								num2 = (int)((global::System.IntPtr)num);
							}
							IL_11B9:
							IL_1215:
							return;
						}
						finally
						{
							num = (short)308674560;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								switch (num2)
								{
								case 0:
									switch (0)
									{
									case 0:
										goto IL_124C;
									}
									continue;
								case 1:
									enumerator.Dispose();
									num = (short)977207298;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 2:
									goto IL_1284;
								}
								IL_124C:
								if (enumerator == null)
								{
									break;
								}
								num = (short)1564803073;
								num2 = (int)((global::System.IntPtr)num);
							}
							IL_1284:;
						}
						goto IL_1287;
					case 47:
						num = (short)1612447745;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 48:
						flag = false;
						enumerator = dataButtonInnerRecset.GetEnumerator();
						num = (short)333316123;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 49:
						if (controlHeadO9Recset.Count > 0)
						{
							num = (short)1574567960;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return;
					case 50:
						if (controlHeadO9Recset != null)
						{
							num = (short)1870528515;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_CB3;
					case 51:
						num = (short)1235419148;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 52:
						goto IL_5A2;
					}
					goto IL_103;
					IL_41B:
					num = (short)461701139;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_488:
					num = (short)1948909577;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_5A2:
					num = (short)685113380;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_624:
					controlHeadO9Recset = null;
					o9DataButtonInnerRecset = null;
					controlHeadO9Recset = (global::AcpCommonLib.FeatureManager.GetFeature(4003) as global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO9.ControlHeadO9Recset);
					num = (short)1987248178;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_76B:
					num = (short)778698778;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_80F:
					controlHeadO7Recset = null;
					o7DataButtonInnerRecset = null;
					controlHeadO7Recset = (global::AcpCommonLib.FeatureManager.GetFeature(4114) as global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO7.ControlHeadO7Recset);
					num = (short)463798278;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_866:
					controlHeadO3Recset = null;
					dataButtonInnerRecset = null;
					controlHeadO3Recset = (global::AcpCommonLib.FeatureManager.GetFeature(2127) as global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO3.ControlHeadO3Recset);
					num = (short)610795520;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_CB3:
					flag = false;
					num = (short)964427809;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_FC9:
					enumerator = dataButtonInnerRecset2.GetEnumerator();
					num = (short)670040108;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_1287:
					o9DataButtonInnerRecset = (controlHeadO9Recset[0][10611].EmbeddedRecset as global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO9.O9DataButtonInnerRecset);
					num = (short)473038864;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_1304:
					num = (short)46661649;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_162A:
					num = (short)1566572567;
					num2 = (int)((global::System.IntPtr)num);
				}
				return;
				IL_103:
				acpListField2 = null;
				acpListField = null;
				featureSectionId = self.FeatureSectionId;
				num = (short)1047527463;
				num2 = (int)((global::System.IntPtr)num);
				goto IL_28;
			}
			}
		}

		// Token: 0x06008979 RID: 35193 RVA: 0x008076E8 File Offset: 0x008058E8
		internal static bool ConDataButtonIndexValid(global::AcpCommonLib.IAcpFeatureSection self, int index)
		{
			short num = (short)1926561792;
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
				bool result;
				global::Motorola.MackinawCPS.CoreFeatures.ActionConsolidation.ActionConsolidationRecset actionConsolidationRecset;
				for (;;)
				{
					IL_28:
					global::System.Collections.Generic.IEnumerator<global::AcpBusinessLayer.FeatureNode> enumerator;
					switch (num2)
					{
					case 0:
						num = (short)1856176129;
						if (num != 0)
						{
						}
						try
						{
							num = (short)1344667662;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								bool flag;
								bool flag2;
								bool flag3;
								bool flag4;
								bool flag5;
								bool flag6;
								bool flag7;
								bool flag8;
								bool flag9;
								bool flag10;
								switch (num2)
								{
								case 0:
								{
									global::Motorola.MackinawCPS.CoreFeatures.RadioWide.GeneralLightbarPatternInnerRecset generalLightbarPatternInnerRecset;
									int num3;
									global::Motorola.MackinawCPS.CoreFeatures.RadioWide.GeneralLightbarPatternInner generalLightbarPatternInner = generalLightbarPatternInnerRecset[num3] as global::Motorola.MackinawCPS.CoreFeatures.RadioWide.GeneralLightbarPatternInner;
									num = (short)1414266943;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 1:
									num = (short)1487470624;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 2:
								{
									global::Motorola.MackinawCPS.CoreFeatures.RadioWide.GeneralLightbarPatternInnerSection generalLightbarPatternInnerSection;
									flag = (generalLightbarPatternInnerSection.RadWideGenLightBarPatternRelay9_A36515.Value == 3);
									goto IL_A25;
								}
								case 3:
								{
									global::Motorola.MackinawCPS.CoreFeatures.RadioWide.RadioWideRecset radioWideRecset;
									global::Motorola.MackinawCPS.CoreFeatures.RadioWide.GeneralLightbarPatternInnerRecset generalLightbarPatternInnerRecset = radioWideRecset[0][10604].EmbeddedRecset as global::Motorola.MackinawCPS.CoreFeatures.RadioWide.GeneralLightbarPatternInnerRecset;
									num = (short)822738962;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 4:
									if (flag2)
									{
										num = (short)1948778557;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									num = (short)2146172980;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 5:
								{
									global::Motorola.MackinawCPS.CoreFeatures.RadioWide.GeneralLightbarPatternInnerSection generalLightbarPatternInnerSection;
									flag3 = (generalLightbarPatternInnerSection.RadWideGenLightBarPatternRelay10_A36516.Value == 3);
									goto IL_3DB;
								}
								case 6:
									if (flag2)
									{
										num = (short)1078394891;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									num = (short)505020466;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 7:
								{
									global::Motorola.MackinawCPS.CoreFeatures.RadioWide.GeneralLightbarPatternInnerSection generalLightbarPatternInnerSection;
									flag4 = (generalLightbarPatternInnerSection.RadWideGenLightBarPatternRelay8_A36513.Value == 3);
									goto IL_7A9;
								}
								case 8:
									flag5 = false;
									goto IL_97A;
								case 9:
									num = (short)1949040680;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 10:
								{
									global::AcpCommonLib.IAcpFeatureNode acpFeatureNode;
									if ((acpFeatureNode[10615] as global::Motorola.MackinawCPS.CoreFeatures.ActionConsolidation.General).RadioErgoConfigACRelayPattern_A36582.Value <= 0)
									{
										num = (short)1668874276;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									int num3 = (acpFeatureNode[10615] as global::Motorola.MackinawCPS.CoreFeatures.ActionConsolidation.General).RadioErgoConfigACRelayPattern_A36582.Value - 1;
									flag2 = false;
									global::Motorola.MackinawCPS.CoreFeatures.RadioWide.RadioWideRecset radioWideRecset = global::AcpCommonLib.FeatureManager.GetFeature(2045) as global::Motorola.MackinawCPS.CoreFeatures.RadioWide.RadioWideRecset;
									num = (short)317718549;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 11:
									num = (short)1044250631;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 12:
									if (flag2)
									{
										num = (short)53346349;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									num = (short)187957312;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 13:
									goto IL_595;
								case 14:
									switch (0)
									{
									case 0:
										goto IL_1D7;
									}
									continue;
								case 15:
									goto IL_B22;
								case 16:
									num = (short)486277140;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 17:
									num = (short)632291362;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 18:
								{
									global::Motorola.MackinawCPS.CoreFeatures.RadioWide.GeneralLightbarPatternInnerRecset generalLightbarPatternInnerRecset;
									int num3;
									if (generalLightbarPatternInnerRecset.Count > num3)
									{
										num = (short)1705508908;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									goto IL_595;
								}
								case 19:
								{
									if (!enumerator.MoveNext())
									{
										num = (short)1642266648;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									global::AcpCommonLib.IAcpFeatureNode acpFeatureNode = enumerator.Current;
									num = (short)567214110;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 20:
								{
									global::Motorola.MackinawCPS.CoreFeatures.RadioWide.GeneralLightbarPatternInnerSection generalLightbarPatternInnerSection;
									flag5 = (generalLightbarPatternInnerSection.RadWideGenLightBarPatternRelay2_A36507.Value == 3);
									goto IL_97A;
								}
								case 21:
								{
									global::Motorola.MackinawCPS.CoreFeatures.RadioWide.RadioWideRecset radioWideRecset;
									if (radioWideRecset != null)
									{
										num = (short)1776615427;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									goto IL_595;
								}
								case 22:
								{
									global::AcpCommonLib.IAcpFeatureNode acpFeatureNode;
									if ((acpFeatureNode[10615] as global::Motorola.MackinawCPS.CoreFeatures.ActionConsolidation.General).RadioErgoConfigACSirenType_A36584.Value != 1)
									{
										num = (short)1020264485;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									goto IL_468;
								}
								case 24:
									num = (short)1593049103;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 25:
									goto IL_468;
								case 26:
								{
									global::AcpCommonLib.IAcpFeatureNode acpFeatureNode;
									if ((acpFeatureNode[10615] as global::Motorola.MackinawCPS.CoreFeatures.ActionConsolidation.General).RadioErgoConfigACSirenType_A36584.Value == 7)
									{
										num = (short)845742105;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									result = false;
									num = (short)2072707128;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 27:
									flag6 = false;
									goto IL_856;
								case 28:
									if (flag2)
									{
										num = (short)1285161018;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									num = (short)2130313267;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 29:
									if (flag2)
									{
										num = (short)1893203999;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									num = (short)1757675559;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 30:
								{
									global::AcpCommonLib.IAcpFeatureNode acpFeatureNode;
									if (index - 1 == (acpFeatureNode.Parent as global::AcpBusinessLayer.Recordset).IndexOf(acpFeatureNode))
									{
										num = (short)1683030017;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									break;
								}
								case 31:
									num = (short)1675886646;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 32:
								{
									global::AcpCommonLib.IAcpFeatureNode acpFeatureNode;
									if ((acpFeatureNode[10615] as global::Motorola.MackinawCPS.CoreFeatures.ActionConsolidation.General).RadioErgoConfigACActionType_A42871.Value == 0)
									{
										num = (short)566820921;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									goto IL_575;
								}
								case 33:
									flag7 = false;
									goto IL_ACB;
								case 34:
								{
									global::Motorola.MackinawCPS.CoreFeatures.RadioWide.GeneralLightbarPatternInnerSection generalLightbarPatternInnerSection;
									flag7 = (generalLightbarPatternInnerSection.RadWideGenLightBarPatternRelay6_A36511.Value == 3);
									goto IL_ACB;
								}
								case 35:
								{
									global::Motorola.MackinawCPS.CoreFeatures.RadioWide.GeneralLightbarPatternInnerRecset generalLightbarPatternInnerRecset;
									int num3;
									if (generalLightbarPatternInnerRecset[num3] != null)
									{
										num = (short)1182662656;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									goto IL_595;
								}
								case 36:
									result = false;
									num = (short)769261591;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 37:
									num = (short)160694298;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 38:
									num = (short)1306918960;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 39:
									flag8 = false;
									goto IL_9B7;
								case 40:
								{
									global::Motorola.MackinawCPS.CoreFeatures.RadioWide.GeneralLightbarPatternInnerSection generalLightbarPatternInnerSection;
									flag6 = (generalLightbarPatternInnerSection.RadWideGenLightBarPatternRelay3_A36508.Value == 3);
									goto IL_856;
								}
								case 41:
									if (flag2)
									{
										num = (short)5701670;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									num = (short)51183671;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 42:
									if (flag2)
									{
										num = (short)119144464;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									num = (short)195231752;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 43:
								{
									global::AcpCommonLib.IAcpFeatureNode acpFeatureNode;
									if ((acpFeatureNode[10615] as global::Motorola.MackinawCPS.CoreFeatures.ActionConsolidation.General).RadioErgoConfigACGeneralActionAllowed_A36579.Value)
									{
										num = (short)2091450421;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									goto IL_575;
								}
								case 44:
									num = (short)2053177379;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 45:
									num = (short)856489986;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 48:
								{
									global::Motorola.MackinawCPS.CoreFeatures.RadioWide.GeneralLightbarPatternInnerSection generalLightbarPatternInnerSection;
									flag9 = (generalLightbarPatternInnerSection.RadWideGenLightBarPatternRelay7_A36512.Value == 3);
									goto IL_4DA;
								}
								case 49:
									if (flag2)
									{
										num = (short)2132279305;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									num = (short)1601437723;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 50:
									flag4 = false;
									goto IL_7A9;
								case 51:
									flag10 = false;
									goto IL_7EA;
								case 52:
									flag3 = false;
									goto IL_3DB;
								case 53:
									num = (short)1180368918;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 54:
								{
									global::Motorola.MackinawCPS.CoreFeatures.RadioWide.GeneralLightbarPatternInnerSection generalLightbarPatternInnerSection;
									flag8 = (generalLightbarPatternInnerSection.RadWideGenLightBarPatternRelay4_A36509.Value == 3);
									goto IL_9B7;
								}
								case 55:
									flag9 = false;
									goto IL_4DA;
								case 57:
									num = (short)2122383403;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 58:
									num = (short)330498108;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 59:
								{
									global::Motorola.MackinawCPS.CoreFeatures.RadioWide.GeneralLightbarPatternInner generalLightbarPatternInner;
									global::Motorola.MackinawCPS.CoreFeatures.RadioWide.GeneralLightbarPatternInnerSection generalLightbarPatternInnerSection = generalLightbarPatternInner.GeneralLightbarPatternInnerSection;
									flag2 = (generalLightbarPatternInnerSection.RadWideGenLightBarPatternRelay1_A36506.Value == 3);
									num = (short)749207594;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 60:
								{
									global::Motorola.MackinawCPS.CoreFeatures.RadioWide.GeneralLightbarPatternInnerSection generalLightbarPatternInnerSection;
									flag10 = (generalLightbarPatternInnerSection.RadWideGenLightBarPatternRelay5_A36510.Value == 3);
									goto IL_7EA;
								}
								case 61:
									num = (short)668205061;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 62:
									if (flag2)
									{
										num = (short)1992818705;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									num = (short)271319073;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 63:
								{
									global::Motorola.MackinawCPS.CoreFeatures.RadioWide.GeneralLightbarPatternInner generalLightbarPatternInner;
									if (generalLightbarPatternInner != null)
									{
										num = (short)1301413947;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									goto IL_595;
								}
								case 64:
									flag = false;
									goto IL_A25;
								}
								goto IL_1D7;
								IL_3DB:
								flag2 = flag3;
								num = (short)2100887565;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								IL_426:
								num = (short)1279983635;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								IL_1D7:
								goto IL_426;
								IL_468:
								num = (short)1450508298;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								IL_4DA:
								flag2 = flag9;
								num = (short)1374879750;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								IL_575:
								result = false;
								num = (short)1096548399;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								IL_595:
								result = flag2;
								num = (short)2020081710;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								IL_7A9:
								flag2 = flag4;
								num = (short)1251737612;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								IL_7EA:
								flag2 = flag10;
								num = (short)689176638;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								IL_856:
								flag2 = flag6;
								num = (short)710082589;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								IL_97A:
								flag2 = flag5;
								num = (short)1870069809;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								IL_9B7:
								flag2 = flag8;
								num = (short)1966276636;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								IL_A25:
								flag2 = flag;
								num = (short)1578565636;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								IL_ACB:
								flag2 = flag7;
								num = (short)788791337;
								num2 = (int)((global::System.IntPtr)num);
							}
							IL_B22:
							return result;
						}
						finally
						{
							num = (short)1062141953;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								num = (short)351080463;
								short num4 = num;
								num = (short)1577717775;
								switch ((num4 == num) ? 1 : 0)
								{
								case 0:
								case 2:
									goto IL_BDE;
								default:
									num = (short)680132608;
									if (num != 0)
									{
									}
									switch (num2)
									{
									case 0:
										goto IL_BDE;
									case 1:
										switch (0)
										{
										case 0:
											goto IL_BA4;
										}
										continue;
									case 2:
										enumerator.Dispose();
										num = (short)1478164480;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									IL_BA4:
									if (enumerator == null)
									{
										goto IL_BE0;
									}
									num = (short)859832322;
									num2 = (int)((global::System.IntPtr)num);
									break;
								}
							}
							IL_BDE:
							IL_BE0:;
						}
						goto IL_BE1;
					case 1:
						if (index == 0)
						{
							num = (short)1265303554;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_BE1;
					case 2:
						return false;
					}
					goto IL_3B;
					IL_BE1:
					enumerator = actionConsolidationRecset.GetEnumerator();
					num = (short)1486749696;
					num2 = (int)((global::System.IntPtr)num);
				}
				return false;
				IL_3B:
				actionConsolidationRecset = (global::AcpCommonLib.FeatureManager.GetFeature(4008) as global::Motorola.MackinawCPS.CoreFeatures.ActionConsolidation.ActionConsolidationRecset);
				result = true;
				num = (short)1679163392;
				short num5 = num;
				num = (short)1562836993;
				num2 = (int)((global::System.IntPtr)num);
				goto IL_28;
			}
			}
		}

		// Token: 0x0600897A RID: 35194 RVA: 0x00808340 File Offset: 0x00806540
		internal static bool conDataBtnTrkFeatureValid(global::AcpCommonLib.IAcpFeatureSection self, int index)
		{
			switch (0)
			{
			case 0:
				goto IL_A0;
			}
			int num;
			global::AcpBusinessLayer.AcpListField acpListField;
			short num2;
			int featureSectionId;
			for (;;)
			{
				IL_0A:
				global::Motorola.MackinawCPS.CoreFeatures.RadioWide.RadioWide radioWide;
				switch (num)
				{
				case 0:
					if (acpListField.Value == 227)
					{
						num2 = (short)2111766530;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					num2 = (short)1925513238;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 1:
					goto IL_420;
				case 2:
					goto IL_292;
				case 3:
					if (index != 227)
					{
						num2 = (short)124977166;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					return false;
				case 4:
				{
					num2 = (short)1810926821;
					short num3 = num2;
					num2 = (short)314019045;
					switch ((num3 == num2) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_322;
					default:
						goto IL_5A2;
					}
					break;
				}
				case 5:
					if (featureSectionId != 10209)
					{
						num2 = (short)150798354;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					acpListField = (self as global::Motorola.MackinawCPS.CoreFeatures.KeypadMicAndAccessories.DataButtonInnerSection).RadErgoCfgKMConventionalKMDatatButtonFeature_A22603;
					num2 = (short)1244856336;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 6:
					num2 = (short)219021329;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 7:
					num2 = (short)1165361171;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 8:
					if (featureSectionId <= 10212)
					{
						num2 = (short)617676820;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					num2 = (short)1674706977;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 9:
					goto IL_3C7;
				case 10:
					if (acpListField.Value == 228)
					{
						num2 = (short)349634584;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					num2 = (short)222560269;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 11:
					if (radioWide.DualRadio.RadWideDualRadioSelection_A42236.Value != 0)
					{
						num2 = (short)1526267929;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					num2 = (short)919994371;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 12:
				{
					num2 = (short)1319305216;
					short num4 = num2;
					goto IL_420;
				}
				case 13:
					if (radioWide.DualRadio.RadWideDualRadioSelection_A42236.Value != 0)
					{
						num2 = (short)2090074135;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					num2 = (short)1241251875;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 14:
					goto IL_645;
				case 15:
					if (acpListField != null)
					{
						num2 = (short)546439199;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					return true;
				case 16:
					goto IL_420;
				case 17:
					if (featureSectionId != 10713)
					{
						goto IL_322;
					}
					acpListField = (self as global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO7.O7DataButtonInnerSection).RadErgCtrlHeadO7DataButtonCnvFeature_A41299;
					num2 = (short)816644123;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 18:
					num2 = (short)1719795738;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 19:
					goto IL_420;
				case 20:
					num2 = (short)1373962245;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 21:
					if (index != 228)
					{
						num2 = (short)2120679452;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					return false;
				case 22:
					if (acpListField.Value == 140)
					{
						num2 = (short)1274281988;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					num2 = (short)576454666;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 23:
					num2 = (short)530645013;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 24:
					num2 = (short)472383499;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 25:
					goto IL_12D;
				case 26:
					if (featureSectionId != 10212)
					{
						num2 = (short)2128805895;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					acpListField = (self as global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO3.DataButtonInnerSection).CntrlHeadO3ConventionalO3DatatButtonFeature_A22595;
					num2 = (short)858456065;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 27:
					goto IL_420;
				case 28:
					num2 = (short)1274806273;
					if (num2 != 0)
					{
					}
					num2 = (short)489029661;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 29:
					if (index != 227)
					{
						num2 = (short)1251737609;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					return false;
				case 30:
					goto IL_1DF;
				case 31:
					num2 = (short)817430528;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 32:
					goto IL_420;
				case 33:
					if (featureSectionId != 10608)
					{
						num2 = (short)1612578822;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					acpListField = (self as global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO9.O9DataButtonInnerSection).RadErgCtrlHeadO9DataButtonCnvFeature_A36528;
					num2 = (short)2107965452;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 34:
					num2 = (short)2080899104;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 35:
					if (index != 227)
					{
						num2 = (short)850591774;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					return false;
				}
				goto IL_A0;
				IL_322:
				num2 = (short)52232226;
				num = (int)((global::System.IntPtr)num2);
				continue;
				IL_420:
				radioWide = (global::AcpCommonLib.FeatureManager.GetFeature(2045)[0] as global::Motorola.MackinawCPS.CoreFeatures.RadioWide.RadioWide);
				num2 = (short)1780613135;
				num = (int)((global::System.IntPtr)num2);
			}
			return false;
			IL_12D:
			return index == 228;
			IL_1DF:
			return index != 140;
			IL_292:
			return index == 227;
			IL_3C7:
			return index != 140;
			IL_5A2:
			num2 = (short)1230962688;
			if (num2 != 0)
			{
			}
			return index == 140;
			IL_645:
			return index != 140;
			IL_A0:
			acpListField = null;
			featureSectionId = self.FeatureSectionId;
			num2 = (short)991952904;
			num = (int)((global::System.IntPtr)num2);
			goto IL_0A;
		}

		// Token: 0x0600897B RID: 35195 RVA: 0x00808998 File Offset: 0x00806B98
		internal static bool conDataBtnConvFeatureValid(global::AcpCommonLib.IAcpFeatureSection self, int index)
		{
			switch (0)
			{
			case 0:
				goto IL_28;
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
					if (radioWide.DualRadio.RadWideDualRadioSelection_A42236.Value == 0)
					{
						num2 = (short)776142849;
						if (num2 != 0)
						{
						}
						num2 = (short)714539009;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					return true;
				case 1:
				{
					num2 = (short)921136896;
					short num3 = num2;
					num2 = (short)137326336;
					switch ((num3 == num2) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_6D;
					default:
						num2 = (short)1061158912;
						if (num2 != 0)
						{
						}
						num2 = (short)1515454468;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					break;
				}
				case 2:
					return false;
				case 3:
					if (radioWide != null)
					{
						num2 = (short)1476722693;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					return true;
				case 4:
					if (index == 140)
					{
						num2 = (short)1971322882;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					return true;
				case 5:
					goto IL_6D;
				}
				goto IL_28;
				IL_6D:
				num2 = (short)234422272;
				short num4 = num2;
				num2 = (short)302645248;
				num = (int)((global::System.IntPtr)num2);
			}
			return false;
			IL_28:
			radioWide = (global::AcpCommonLib.FeatureManager.GetFeature(2045)[0] as global::Motorola.MackinawCPS.CoreFeatures.RadioWide.RadioWide);
			num2 = (short)1718878211;
			num = (int)((global::System.IntPtr)num2);
			goto IL_0A;
		}

		// Token: 0x0600897C RID: 35196 RVA: 0x00808B38 File Offset: 0x00806D38
		internal static bool ConStandaloneRadioSystemEnableApp(global::AcpCommonLib.IAcpFeatureSection self)
		{
			short num = (short)1159205802;
			short num2 = num;
			num = (short)1032000426;
			switch (num2 == num)
			{
			}
			num = (short)468516865;
			if (num != 0)
			{
			}
			num = (short)1869676544;
			if (num != 0)
			{
			}
			num = (short)1366360064;
			short num3 = num;
			global::AcpCommonLib.IAcpFeatureNode parent = self.ParentRecset.ParentSection.Parent;
			return (global::AcpCommonLib.FeatureManager.GetFeature(2045)[0] as global::Motorola.MackinawCPS.CoreFeatures.RadioWide.RadioWide).DualRadio.RadWideDualRadioSelection_A42236.Value == 0;
		}
	}
}
