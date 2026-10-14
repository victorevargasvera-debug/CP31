using System;
using System.Collections.Generic;
using AcpBusinessLayer;
using AcpBusinessLayer.UndoRedo;
using AcpCommonLib;
using AcpCommonLib.UndoRedo;
using Motorola.MackinawCPS.CoreFeatures.ControlHeadE5;
using Motorola.MackinawCPS.CoreFeatures.ControlHeadO2;
using Motorola.MackinawCPS.CoreFeatures.ControlHeadO3;
using Motorola.MackinawCPS.CoreFeatures.ControlHeadO7;
using Motorola.MackinawCPS.CoreFeatures.ControlHeadO9;
using Motorola.MackinawCPS.CoreFeatures.KeypadMicAndAccessories;
using Motorola.MackinawCPS.CoreFeatures.RadioWide;

namespace Motorola.MackinawCPS.CoreFeatures.ControlHeadO5
{
	// Token: 0x020003A8 RID: 936
	public static class ControlHeadO5Constraints
	{
		// Token: 0x0600886D RID: 34925 RVA: 0x007EE884 File Offset: 0x007ECA84
		public static void ConSyncUpDownBtnFeature(global::AcpCommonLib.IAcpFeatureSection self, global::AcpCommonLib.UndoRedo.ContainerTask task)
		{
			short num = (short)2042167296;
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
				global::AcpCommonLib.IAcpRecordset parentRecset;
				int num3;
				bool flag;
				int num4;
				for (;;)
				{
					IL_29:
					global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO5.O5NavigationControlsTableInnerSection o5NavigationControlsTableInnerSection;
					switch (num2)
					{
					case 0:
						if (parentRecset.Count < 2)
						{
							num = (short)1401946117;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)121045015;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 1:
						if (num3 == 0)
						{
							num = (short)527171603;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)115474454;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 2:
						if (!flag)
						{
							num = (short)119537685;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num3 = o5NavigationControlsTableInnerSection.RadErgoControlO5NaviControlFeature_A41379.Value;
						num4 = num3 - 1;
						num = (short)2032402448;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 3:
						if (parentRecset != null)
						{
							num = (short)1027538970;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return;
					case 4:
						if (num4 != 0)
						{
							num = (short)873332766;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return;
					case 5:
						goto IL_422;
					case 6:
						num = (short)830079008;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 7:
						if (o5NavigationControlsTableInnerSection != null)
						{
							num = (short)861667340;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return;
					case 8:
						goto IL_5B2;
					case 9:
						if (num4 == 38)
						{
							num = (short)1553924125;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_4AB;
					case 10:
						num = (short)28901394;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 11:
						num = (short)108789787;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 12:
						num = (short)1764098050;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 13:
						goto IL_4AB;
					case 14:
						num = (short)156893201;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 15:
						goto IL_194;
					case 16:
						if (num3 == 38)
						{
							num = (short)1205927964;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_5B2;
					case 17:
						if (num3 != 66)
						{
							num = (short)1296367641;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_36C;
					case 18:
						if (num4 != 65)
						{
							num = (short)461963275;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_36C;
					case 19:
						goto IL_6DD;
					case 20:
						if (num3 == 87)
						{
							num = (short)1079705633;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_6E2;
					case 21:
						num = (short)90177537;
						if (num != 0)
						{
						}
						num4 = o5NavigationControlsTableInnerSection.RadErgoControlO5NaviControlFeature_A41379.Value;
						num3 = num4 + 1;
						num = (short)1601503241;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 22:
						if (num4 != 144)
						{
							num = (short)1772093450;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_36C;
					case 23:
						if (parentRecset[1] == self.Parent)
						{
							num = (short)245891096;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_194;
					case 24:
						flag = true;
						num = (short)1128267791;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 25:
						num = (short)1791295508;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 26:
						num = (short)379256832;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 27:
						if (num4 != 67)
						{
							num = (short)1970667526;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_36C;
					case 28:
						num4 = 38;
						num = (short)919142408;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 29:
						num3 = 38;
						num = (short)1908604941;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 30:
						num = (short)997916673;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 31:
						num = (short)1439825957;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 32:
					{
						if (num4 == 88)
						{
							goto IL_36C;
						}
						num = (short)2142397052;
						short num5 = num;
						num = (short)1180983932;
						switch ((num5 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_5D9;
						default:
							num = (short)1373503488;
							if (num != 0)
							{
							}
							num = (short)723124255;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						break;
					}
					case 33:
						goto IL_36C;
					case 34:
						goto IL_158;
					case 35:
						num = (short)790691878;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 36:
						goto IL_391;
					case 37:
						if (num3 != 143)
						{
							num = (short)150470691;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_36C;
					case 38:
						if (num3 != 64)
						{
							num = (short)1178402830;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_36C;
					case 39:
						goto IL_158;
					}
					goto IL_D0;
					IL_158:
					num = (short)1910636548;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_194:
					o5NavigationControlsTableInnerSection = (self as global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO5.O5NavigationControlsTableInnerSection);
					num = (short)192610311;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_36C:
					num4 = 143;
					num3 = 144;
					num = (short)572784676;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_4AB:
					task.AddTask(new global::AcpBusinessLayer.UndoRedo.ModifyDataTask<int>((self.ParentRecset[1] as global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO5.O5NavigationControlsTableInner).O5NavigationControlsTableInnerSection.RadErgoControlO5NaviControlFeature_A41379, num3));
					num = (short)1925709824;
					short num6 = num;
					num = (short)1581842466;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_5D9:
					num = (short)914882599;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_5B2:
					task.AddTask(new global::AcpBusinessLayer.UndoRedo.ModifyDataTask<int>((self.ParentRecset[0] as global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO5.O5NavigationControlsTableInner).O5NavigationControlsTableInnerSection.RadErgoControlO5NaviControlFeature_A41379, num4));
					goto IL_5D9;
				}
				return;
				IL_391:
				goto IL_6E2;
				IL_422:
				return;
				IL_6DD:
				return;
				IL_6E2:
				global::Motorola.MackinawCPS.CoreFeatures.ControlHeadE5.ControlHeadE5Constraints.SyncNavigationControlsCPField(task, num4, num3);
				global::Motorola.MackinawCPS.CoreFeatures.ControlHeadE5.ControlHeadE5Constraints.SyncE5NavigationControls(task, num4, num3);
				global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO2.ControlHeadO2Constraints.SyncO2NavigationControls(task, num4, num3);
				global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO3.ControlHeadO3Constraints.SyncO3NavigationControls(task, num4, num3);
				global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO7.ControlHeadO7Constraints.SyncO7NavigationControls(task, num4, num3);
				global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO9.ControlHeadO9Constraints.SyncO9NavigationControls(task, num4, num3);
				global::Motorola.MackinawCPS.CoreFeatures.KeypadMicAndAccessories.KeypadMicAndAccessoriesConstraints.SyncKeypadMicAndAccessoriesNavigationControls(task, num4, num3);
				global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO7.ControlHeadO7Constraints.CalculateValidityForO2O7MFK();
				return;
				IL_D0:
				num4 = 0;
				num3 = 0;
				flag = false;
				parentRecset = self.ParentRecset;
				num = (short)884473859;
				num2 = (int)((global::System.IntPtr)num);
				goto IL_29;
			}
			}
		}

		// Token: 0x0600886E RID: 34926 RVA: 0x007EEFB0 File Offset: 0x007ED1B0
		public static void SyncO5NavigationControls(global::AcpCommonLib.UndoRedo.ContainerTask task, int upButtonConfigedFeatureValue, int downButtonConfigedFeatureValue)
		{
			short num = (short)713228288;
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
				global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO5.ControlHeadO5Recset controlHeadO5Recset;
				for (;;)
				{
					IL_28:
					global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO5.O5NavigationControlsTableInnerRecset o5NavigationControlsTableInnerRecset;
					switch (num2)
					{
					case 0:
						return;
					case 1:
						if (o5NavigationControlsTableInnerRecset != null)
						{
							num = (short)330891268;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return;
					case 2:
					{
						num = (short)1276566430;
						short num3 = num;
						num = (short)1879694238;
						switch ((num3 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_FA;
						default:
							num = (short)954335233;
							if (num != 0)
							{
							}
							num = (short)1989148672;
							if (num != 0)
							{
							}
							if (controlHeadO5Recset != null)
							{
								num = (short)150339587;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							return;
						}
						break;
					}
					case 3:
					{
						num = (short)2137718784;
						short num4 = num;
						o5NavigationControlsTableInnerRecset = (controlHeadO5Recset[0][10735].EmbeddedRecset as global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO5.O5NavigationControlsTableInnerRecset);
						num = (short)308215809;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 4:
						goto IL_FA;
					}
					goto IL_43;
					IL_FA:
					global::AcpBusinessLayer.AcpListField radErgoControlO5NaviControlFeature_A = (o5NavigationControlsTableInnerRecset[0][10736] as global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO5.O5NavigationControlsTableInnerSection).RadErgoControlO5NaviControlFeature_A41379;
					task.AddTask(new global::AcpBusinessLayer.UndoRedo.ModifyDataTask<int>(radErgoControlO5NaviControlFeature_A, upButtonConfigedFeatureValue));
					global::AcpBusinessLayer.AcpListField radErgoControlO5NaviControlFeature_A2 = (o5NavigationControlsTableInnerRecset[1][10736] as global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO5.O5NavigationControlsTableInnerSection).RadErgoControlO5NaviControlFeature_A41379;
					task.AddTask(new global::AcpBusinessLayer.UndoRedo.ModifyDataTask<int>(radErgoControlO5NaviControlFeature_A2, downButtonConfigedFeatureValue));
					num = (short)33882112;
					num2 = (int)((global::System.IntPtr)num);
				}
				return;
				IL_43:
				controlHeadO5Recset = (global::AcpCommonLib.FeatureManager.GetFeature(2130) as global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO5.ControlHeadO5Recset);
				num = (short)1454309378;
				num2 = (int)((global::System.IntPtr)num);
				goto IL_28;
			}
			}
		}

		// Token: 0x0600886F RID: 34927 RVA: 0x007EF1A8 File Offset: 0x007ED3A8
		public static void ConSyncOrangeBtn(global::AcpCommonLib.IAcpFeatureSection self, global::AcpCommonLib.UndoRedo.ContainerTask task)
		{
			short num = (short)243007488;
			int num2 = (int)num;
			switch (num2)
			{
			default:
			{
				switch (0)
				{
				case 0:
					goto IL_FA;
				}
				int featureSectionId;
				int num3;
				bool flag;
				for (;;)
				{
					IL_27:
					global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO5.O5InnerRecset o5InnerRecset;
					global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO7.ControlHeadO7Recset controlHeadO7Recset;
					global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO9.ControlHeadO9Recset controlHeadO9Recset;
					global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO5.ControlHeadO5Recset controlHeadO5Recset;
					global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO2.O2InnerRecset o2InnerRecset;
					global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO7.O7InnerRecset o7InnerRecset;
					global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO9.O9InnerRecset o9InnerRecset;
					global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO2.ControlHeadO2Recset controlHeadO2Recset;
					switch (num2)
					{
					case 0:
						if (o5InnerRecset != null)
						{
							num = (short)1429995562;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_1079;
					case 1:
						goto IL_A35;
					case 2:
						if (featureSectionId <= 10627)
						{
							num = (short)605093917;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)2038169633;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 3:
						if (controlHeadO7Recset != null)
						{
							num = (short)1183842351;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_D71;
					case 4:
						num3 = (self as global::Motorola.MackinawCPS.CoreFeatures.ControlHeadE5.E5InnerSection).CHE5EmergencyButtonFeature_43768.Value;
						num = (short)327155748;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 5:
						goto IL_CE6;
					case 6:
						if (controlHeadO9Recset != null)
						{
							num = (short)1474691111;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_738;
					case 7:
						goto IL_A35;
					case 8:
					{
						global::Motorola.MackinawCPS.CoreFeatures.ControlHeadE5.E5InnerRecset e5InnerRecset;
						global::System.Collections.Generic.IEnumerator<global::AcpBusinessLayer.FeatureNode> enumerator = e5InnerRecset.GetEnumerator();
						num = (short)430440496;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 9:
						if (controlHeadO5Recset != null)
						{
							num = (short)665452572;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_111E;
					case 10:
						if (o2InnerRecset != null)
						{
							num = (short)1021116448;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_10CE;
					case 11:
						if (featureSectionId != 10627)
						{
							num = (short)1419706395;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num3 = (self as global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO9.O9InnerSection).CHO9EmergencyButtonFeature_A36682.Value;
						num = (short)48758799;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 12:
						try
						{
							num = (short)1757151236;
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
										num = (short)431489029;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									global::AcpCommonLib.IAcpFeatureNode acpFeatureNode = enumerator.Current;
									num = (short)360382470;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 1:
									goto IL_FC5;
								case 3:
								{
									global::AcpCommonLib.IAcpFeatureNode acpFeatureNode;
									task.AddTask(new global::AcpBusinessLayer.UndoRedo.ModifyDataTask<int>((acpFeatureNode[10627] as global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO9.O9InnerSection).CHO9EmergencyButtonFeature_A36682, num3));
									num = (short)1955332098;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 4:
									switch (0)
									{
									case 0:
										goto IL_ED7;
									}
									continue;
								case 5:
									num = (short)589234177;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 6:
								{
									global::AcpCommonLib.IAcpFeatureNode acpFeatureNode;
									if (num3 != (acpFeatureNode[10627] as global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO9.O9InnerSection).CHO9EmergencyButtonFeature_A36682.Value)
									{
										num = (short)483262467;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									break;
								}
								}
								IL_F6F:
								num = (short)922025984;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								IL_ED7:
								goto IL_F6F;
							}
							IL_FC5:
							return;
						}
						finally
						{
							num = (short)1804271616;
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
										goto IL_FFC;
									}
									continue;
								case 1:
									goto IL_1035;
								case 2:
									enumerator.Dispose();
									num = (short)1465057281;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								IL_FFC:
								if (enumerator == null)
								{
									break;
								}
								num = (short)1924988930;
								num2 = (int)((global::System.IntPtr)num);
							}
							IL_1035:;
						}
						goto IL_1038;
					case 13:
					{
						global::System.Collections.Generic.IEnumerator<global::AcpBusinessLayer.FeatureNode> enumerator = o7InnerRecset.GetEnumerator();
						num = (short)1540423699;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 14:
						goto IL_D71;
					case 15:
						goto IL_A35;
					case 16:
					{
						global::Motorola.MackinawCPS.CoreFeatures.ControlHeadE5.E5InnerRecset e5InnerRecset;
						if (e5InnerRecset != null)
						{
							num = (short)1665531912;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_D23;
					}
					case 17:
						if (o9InnerRecset != null)
						{
							num = (short)2064777265;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return;
					case 18:
						if (controlHeadO2Recset != null)
						{
							num = (short)1736245270;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_CE6;
					case 19:
						try
						{
							num = (short)221118468;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								switch (num2)
								{
								case 0:
									num = (short)585236481;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 1:
									goto IL_5E8;
								case 2:
								{
									global::AcpCommonLib.IAcpFeatureNode acpFeatureNode2;
									if (num3 != (acpFeatureNode2[10715] as global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO7.O7InnerSection).CHO7EmergencyButtonFeature_A41291.Value)
									{
										num = (short)841547782;
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
										num = (short)660144128;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									global::AcpCommonLib.IAcpFeatureNode acpFeatureNode2 = enumerator.Current;
									num = (short)490209282;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 4:
									switch (0)
									{
									case 0:
										goto IL_501;
									}
									continue;
								case 6:
								{
									global::AcpCommonLib.IAcpFeatureNode acpFeatureNode2;
									task.AddTask(new global::AcpBusinessLayer.UndoRedo.ModifyDataTask<int>((acpFeatureNode2[10715] as global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO7.O7InnerSection).CHO7EmergencyButtonFeature_A41291, num3));
									num = (short)1396703237;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								}
								IL_556:
								num = (short)47906819;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								IL_501:
								goto IL_556;
							}
							IL_5E8:
							goto IL_7A3;
						}
						finally
						{
							num = (short)1201733632;
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
										goto IL_61F;
									}
									continue;
								case 1:
									goto IL_6A8;
								case 2:
								{
									num = (short)1923267202;
									short num4 = num;
									num = (short)1763097218;
									switch ((num4 == num) ? 1 : 0)
									{
									case 0:
									case 2:
										goto IL_6AA;
									default:
										num = (short)1622671360;
										if (num != 0)
										{
										}
										enumerator.Dispose();
										num = (short)2032533505;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									break;
								}
								}
								IL_61F:
								if (enumerator == null)
								{
									break;
								}
								num = (short)1154351106;
								num2 = (int)((global::System.IntPtr)num);
							}
							IL_6A8:
							IL_6AA:;
						}
						goto IL_6AB;
					case 20:
						goto IL_2EF;
					case 21:
						goto IL_738;
					case 22:
						o2InnerRecset = (controlHeadO2Recset[0][10723].EmbeddedRecset as global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO2.O2InnerRecset);
						num = (short)1049559045;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 23:
					{
						global::Motorola.MackinawCPS.CoreFeatures.ControlHeadE5.ControlHeadE5Recset controlHeadE5Recset;
						global::Motorola.MackinawCPS.CoreFeatures.ControlHeadE5.E5InnerRecset e5InnerRecset = controlHeadE5Recset[0][10902].EmbeddedRecset as global::Motorola.MackinawCPS.CoreFeatures.ControlHeadE5.E5InnerRecset;
						num = (short)1529937964;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 24:
						goto IL_C25;
					case 25:
						goto IL_1038;
					case 26:
						goto IL_A35;
					case 27:
						num = (short)546177048;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 28:
						o5InnerRecset = (controlHeadO5Recset[0][10227].EmbeddedRecset as global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO5.O5InnerRecset);
						num = (short)475332654;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 29:
						goto IL_99C;
					case 30:
					{
						global::Motorola.MackinawCPS.CoreFeatures.ControlHeadE5.ControlHeadE5Recset controlHeadE5Recset;
						if (controlHeadE5Recset != null)
						{
							num = (short)1707737111;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_B0E;
					}
					case 31:
						if (featureSectionId != 10716)
						{
							num = (short)1369112619;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num3 = (self as global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO2.O2InnerSection).CHO2EmergencyButtonFeature_A41272.Value;
						num = (short)1761673217;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 32:
					{
						global::System.Collections.Generic.IEnumerator<global::AcpBusinessLayer.FeatureNode> enumerator = o2InnerRecset.GetEnumerator();
						num = (short)2021457940;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 33:
						if (featureSectionId != 10715)
						{
							num = (short)53411865;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_48F;
					case 34:
						try
						{
							num = (short)1202454528;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								switch (num2)
								{
								case 0:
									switch (0)
									{
									case 0:
										goto IL_18C;
									}
									continue;
								case 1:
								{
									global::AcpCommonLib.IAcpFeatureNode acpFeatureNode3;
									if (num3 != (acpFeatureNode3[10211] as global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO5.O5InnerSection).CntrlHeadO5SignalIndependentO5M5MXChiefCHButtonButtonFeature_A19754.Value)
									{
										num = (short)834994179;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									break;
								}
								case 2:
								{
									global::System.Collections.Generic.IEnumerator<global::AcpBusinessLayer.FeatureNode> enumerator;
									if (!enumerator.MoveNext())
									{
										num = (short)1331167237;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									global::AcpCommonLib.IAcpFeatureNode acpFeatureNode3 = enumerator.Current;
									num = (short)195756033;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 3:
								{
									global::AcpCommonLib.IAcpFeatureNode acpFeatureNode3;
									task.AddTask(new global::AcpBusinessLayer.UndoRedo.ModifyDataTask<int>((acpFeatureNode3[10211] as global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO5.O5InnerSection).CntrlHeadO5SignalIndependentO5M5MXChiefCHButtonButtonFeature_A19754, num3));
									num = (short)1683357702;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 4:
									goto IL_27D;
								case 5:
									num = (short)1601830916;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								IL_18E:
								num = (short)429064194;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								IL_18C:
								goto IL_18E;
							}
							IL_27D:
							goto IL_1079;
						}
						finally
						{
							num = (short)1613758465;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								global::System.Collections.Generic.IEnumerator<global::AcpBusinessLayer.FeatureNode> enumerator;
								switch (num2)
								{
								case 0:
									goto IL_2EC;
								case 1:
									switch (0)
									{
									case 0:
										goto IL_2B4;
									}
									continue;
								case 2:
									enumerator.Dispose();
									num = (short)1731919872;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								IL_2B4:
								if (enumerator == null)
								{
									break;
								}
								num = (short)41549826;
								num2 = (int)((global::System.IntPtr)num);
							}
							IL_2EC:;
						}
						goto Block_3;
					case 35:
						return;
					case 36:
						goto IL_A35;
					case 37:
						goto IL_A35;
					case 38:
						num = (short)834404363;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 39:
						o9InnerRecset = (controlHeadO9Recset[0][10626].EmbeddedRecset as global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO9.O9InnerRecset);
						num = (short)1964179477;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 40:
					{
						if (!flag)
						{
							num = (short)821428259;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						global::Motorola.MackinawCPS.CoreFeatures.ControlHeadE5.ControlHeadE5Recset controlHeadE5Recset = null;
						global::Motorola.MackinawCPS.CoreFeatures.ControlHeadE5.E5InnerRecset e5InnerRecset = null;
						controlHeadE5Recset = (global::AcpCommonLib.FeatureManager.GetFeature(4236) as global::Motorola.MackinawCPS.CoreFeatures.ControlHeadE5.ControlHeadE5Recset);
						num = (short)1593376798;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 41:
						if (featureSectionId == 10901)
						{
							num = (short)880869377;
							if (num != 0)
							{
							}
							num = (short)1343160324;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_C25;
					case 42:
					{
						global::System.Collections.Generic.IEnumerator<global::AcpBusinessLayer.FeatureNode> enumerator = o5InnerRecset.GetEnumerator();
						num = (short)1174077474;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 43:
						goto IL_6AB;
					case 44:
						goto IL_B0E;
					case 45:
						if (o7InnerRecset != null)
						{
							num = (short)1525743629;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_7A3;
					case 46:
						goto IL_111E;
					case 47:
						o7InnerRecset = (controlHeadO7Recset[0][10719].EmbeddedRecset as global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO7.O7InnerRecset);
						num = (short)617349134;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 48:
						try
						{
							num = (short)212992004;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								switch (num2)
								{
								case 0:
								{
									global::AcpCommonLib.IAcpFeatureNode acpFeatureNode4;
									if (num3 != (acpFeatureNode4[10901] as global::Motorola.MackinawCPS.CoreFeatures.ControlHeadE5.E5InnerSection).CHE5EmergencyButtonFeature_43768.Value)
									{
										num = (short)1959657477;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									break;
								}
								case 1:
									goto IL_92A;
								case 2:
								{
									global::System.Collections.Generic.IEnumerator<global::AcpBusinessLayer.FeatureNode> enumerator;
									if (!enumerator.MoveNext())
									{
										num = (short)433389574;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									global::AcpCommonLib.IAcpFeatureNode acpFeatureNode4 = enumerator.Current;
									num = (short)1692336128;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 4:
									switch (0)
									{
									case 0:
										goto IL_839;
									}
									continue;
								case 5:
								{
									global::AcpCommonLib.IAcpFeatureNode acpFeatureNode4;
									task.AddTask(new global::AcpBusinessLayer.UndoRedo.ModifyDataTask<int>((acpFeatureNode4[10901] as global::Motorola.MackinawCPS.CoreFeatures.ControlHeadE5.E5InnerSection).CHE5EmergencyButtonFeature_43768, num3));
									num = (short)379322371;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 6:
									num = (short)1217003521;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								IL_83B:
								num = (short)1888288770;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								IL_839:
								goto IL_83B;
							}
							IL_92A:
							goto IL_D23;
						}
						finally
						{
							num = (short)1740111872;
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
										goto IL_961;
									}
									continue;
								case 1:
									goto IL_999;
								case 2:
									enumerator.Dispose();
									num = (short)1173880833;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								IL_961:
								if (enumerator == null)
								{
									break;
								}
								num = (short)1425342466;
								num2 = (int)((global::System.IntPtr)num);
							}
							IL_999:;
						}
						goto IL_99C;
					case 49:
					{
						num = (short)2031419392;
						short num5 = num;
						global::System.Collections.Generic.IEnumerator<global::AcpBusinessLayer.FeatureNode> enumerator = o9InnerRecset.GetEnumerator();
						num = (short)1627586572;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 50:
						if (featureSectionId != 10211)
						{
							num = (short)1066991654;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num3 = (self as global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO5.O5InnerSection).CntrlHeadO5SignalIndependentO5M5MXChiefCHButtonButtonFeature_A19754.Value;
						num = (short)761462821;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_FA;
					IL_48F:
					num3 = (self as global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO7.O7InnerSection).CHO7EmergencyButtonFeature_A41291.Value;
					num = (short)1561329690;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					Block_3:
					try
					{
						IL_2EF:
						num = (short)1224671232;
						num2 = (int)((global::System.IntPtr)num);
						for (;;)
						{
							switch (num2)
							{
							case 0:
								switch (0)
								{
								case 0:
									goto IL_332;
								}
								continue;
							case 1:
							{
								global::AcpCommonLib.IAcpFeatureNode acpFeatureNode5;
								task.AddTask(new global::AcpBusinessLayer.UndoRedo.ModifyDataTask<int>((acpFeatureNode5[10716] as global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO2.O2InnerSection).CHO2EmergencyButtonFeature_A41272, num3));
								num = (short)209190915;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							case 2:
							{
								global::System.Collections.Generic.IEnumerator<global::AcpBusinessLayer.FeatureNode> enumerator;
								if (!enumerator.MoveNext())
								{
									num = (short)1864171525;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								global::AcpCommonLib.IAcpFeatureNode acpFeatureNode5 = enumerator.Current;
								num = (short)1027407878;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							case 4:
								goto IL_41C;
							case 5:
								num = (short)2138243076;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							case 6:
							{
								global::AcpCommonLib.IAcpFeatureNode acpFeatureNode5;
								if (num3 != (acpFeatureNode5[10716] as global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO2.O2InnerSection).CHO2EmergencyButtonFeature_A41272.Value)
								{
									num = (short)685047809;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								break;
							}
							}
							IL_334:
							num = (short)626982914;
							num2 = (int)((global::System.IntPtr)num);
							continue;
							IL_332:
							goto IL_334;
						}
						IL_41C:
						goto IL_10CE;
					}
					finally
					{
						num = (short)624427009;
						num2 = (int)((global::System.IntPtr)num);
						for (;;)
						{
							global::System.Collections.Generic.IEnumerator<global::AcpBusinessLayer.FeatureNode> enumerator;
							switch (num2)
							{
							case 0:
								goto IL_48C;
							case 1:
								switch (0)
								{
								case 0:
									goto IL_453;
								}
								continue;
							case 2:
								enumerator.Dispose();
								num = (short)819527680;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							IL_453:
							if (enumerator == null)
							{
								break;
							}
							num = (short)178192386;
							num2 = (int)((global::System.IntPtr)num);
						}
						IL_48C:;
					}
					goto IL_48F;
					IL_6AB:
					num = (short)1512701993;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_738:
					num = (short)1904738321;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_7A3:
					controlHeadO9Recset = null;
					o9InnerRecset = null;
					controlHeadO9Recset = (global::AcpCommonLib.FeatureManager.GetFeature(4003) as global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO9.ControlHeadO9Recset);
					num = (short)1945501702;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_99C:
					num = (short)558563378;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_A35:
					num = (short)591200296;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_B0E:
					num = (short)890044432;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_C25:
					flag = false;
					num = (short)1601830919;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_CE6:
					num = (short)396361738;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_D23:
					controlHeadO2Recset = null;
					o2InnerRecset = null;
					controlHeadO2Recset = (global::AcpCommonLib.FeatureManager.GetFeature(4115) as global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO2.ControlHeadO2Recset);
					num = (short)200998930;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_D71:
					num = (short)849543213;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_1038:
					num = (short)993460255;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_1079:
					controlHeadO7Recset = null;
					o7InnerRecset = null;
					controlHeadO7Recset = (global::AcpCommonLib.FeatureManager.GetFeature(4114) as global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO7.ControlHeadO7Recset);
					num = (short)1902968835;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_10CE:
					controlHeadO5Recset = null;
					o5InnerRecset = null;
					controlHeadO5Recset = (global::AcpCommonLib.FeatureManager.GetFeature(2130) as global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO5.ControlHeadO5Recset);
					num = (short)2096693257;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_111E:
					num = (short)1151533056;
					num2 = (int)((global::System.IntPtr)num);
				}
				return;
				IL_FA:
				num3 = 0;
				flag = true;
				featureSectionId = self.FeatureSectionId;
				num = (short)1475805186;
				num2 = (int)((global::System.IntPtr)num);
				goto IL_27;
			}
			}
		}

		// Token: 0x06008870 RID: 34928 RVA: 0x007F0390 File Offset: 0x007EE590
		public static bool conDownButtonApplicable(global::AcpCommonLib.IAcpFeatureSection self)
		{
			short num;
			for (;;)
			{
				num = (short)269942784;
				short num2 = num;
				if (self.ParentRecset[1] == self.Parent)
				{
					break;
				}
				num = (short)1978931831;
				short num3 = num;
				num = (short)1776556663;
				switch ((num3 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					break;
				default:
					goto IL_78;
				}
			}
			return false;
			IL_78:
			num = (short)556400641;
			if (num != 0)
			{
			}
			num = (short)571539456;
			if (num != 0)
			{
			}
			return true;
		}

		// Token: 0x06008871 RID: 34929 RVA: 0x007F0454 File Offset: 0x007EE654
		internal static bool ConStandaloneRadioSystemEnableApp(global::AcpCommonLib.IAcpFeatureSection self)
		{
			short num = (short)584450049;
			if (num != 0)
			{
			}
			num = (short)1799880704;
			short num2 = num;
			num = (short)467753320;
			short num3 = num;
			num = (short)172185960;
			switch (num3 == num)
			{
			}
			num = (short)160432128;
			if (num != 0)
			{
			}
			global::AcpCommonLib.IAcpFeatureNode parent = self.ParentRecset.ParentSection.Parent;
			return (global::AcpCommonLib.FeatureManager.GetFeature(2045)[0] as global::Motorola.MackinawCPS.CoreFeatures.RadioWide.RadioWide).DualRadio.RadWideDualRadioSelection_A42236.Value == 0;
		}

		// Token: 0x06008872 RID: 34930 RVA: 0x007F0538 File Offset: 0x007EE738
		internal static bool ConControlHeadEmergencyFeaturesSelect(global::AcpCommonLib.IAcpFeatureSection self, int index)
		{
			short num = (short)818741248;
			int num2 = (int)num;
			switch (num2)
			{
			default:
			{
				switch (0)
				{
				case 0:
					goto IL_C7;
				}
				global::AcpBusinessLayer.AcpField<bool> radErgoWideControlHeadMultiControlHead_A;
				bool result;
				global::AcpBusinessLayer.AcpListField radErgoWideControlHeadMultipleControlHeadStyle_A;
				global::AcpBusinessLayer.AcpListField radWideDualRadioSelection_A;
				global::Motorola.MackinawCPS.CoreFeatures.RadioWide.Features features;
				global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO5.O5InnerSection o5InnerSection;
				for (;;)
				{
					IL_28:
					bool flag;
					bool flag2;
					bool flag3;
					switch (num2)
					{
					case 0:
						if (radErgoWideControlHeadMultiControlHead_A.Value)
						{
							num = (short)2145779721;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)220332047;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 1:
						return result;
					case 2:
						flag = (radErgoWideControlHeadMultipleControlHeadStyle_A.Value == 0);
						goto IL_387;
					case 3:
						return result;
					case 4:
						return result;
					case 5:
						flag2 = true;
						goto IL_5D5;
					case 6:
						num = (short)1672019987;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 7:
					{
						num = (short)1746371955;
						short num3 = num;
						num = (short)1527547251;
						switch ((num3 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_4C2;
						default:
							num = (short)799342592;
							if (num != 0)
							{
							}
							num = (short)636354584;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						break;
					}
					case 8:
						if (index != 140)
						{
							num = (short)1824325643;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						result = (radWideDualRadioSelection_A.Value != 0);
						num = (short)474611715;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 9:
						num = (short)770768898;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 10:
						num = (short)1111556129;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 11:
						goto IL_4C2;
					case 12:
						num = (short)2038759454;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 13:
						if (index != 138)
						{
							num = (short)680853532;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)268697600;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 14:
						if (index <= 138)
						{
							num = (short)1814036492;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)1785790472;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 15:
						flag = false;
						goto IL_387;
					case 16:
						goto IL_1C0;
					case 17:
						num = (short)1146028053;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 18:
						return result;
					case 19:
						if (index - 290 > 1)
						{
							num = (short)25100323;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						result = features.RadWideFeaturesChannelFallbackEnableValue;
						num = (short)973668388;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 20:
						if (radErgoWideControlHeadMultipleControlHeadStyle_A.Value == 1)
						{
							num = (short)2010578981;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_1C0;
					case 21:
						flag3 = !o5InnerSection.RefRadioWide.Features.RadWideTPSFiregroundEvacuationTone_A7980.Value;
						goto IL_445;
					case 22:
						if (!radErgoWideControlHeadMultiControlHead_A.Value)
						{
							num = (short)340656144;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)940310533;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 23:
						if (radWideDualRadioSelection_A.Value == 1)
						{
							num = (short)838402055;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_2D9;
					case 24:
						if (o5InnerSection.RefRadioWide.DualRadio.RadWideDualRadioEmergencyRadio_A42239.Value == 2)
						{
							num = (short)597229585;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_2D9;
					case 25:
						if (index != 163)
						{
							num = (short)171769862;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)1047527444;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 26:
						flag2 = !radErgoWideControlHeadMultiControlHead_A.Value;
						goto IL_5D5;
					case 27:
						num = (short)1827536909;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 28:
						num = (short)659488769;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 29:
						return result;
					case 30:
						num = (short)275447809;
						if (num != 0)
						{
						}
						if (index != 31)
						{
							num = (short)1377959946;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)45088791;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 31:
						return result;
					case 32:
						return result;
					case 33:
						if (index - 124 > 2)
						{
							num = (short)1373503515;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						result = (radWideDualRadioSelection_A.Value == 0);
						num = (short)498663456;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 34:
						flag3 = true;
						goto IL_445;
					case 35:
					{
						num = (short)1034682368;
						short num4 = num;
						num = (short)642383876;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 36:
						return result;
					case 37:
						num = (short)1261043734;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_C7;
					IL_1C0:
					num = (short)688455706;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_2D9:
					num = (short)437583906;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_387:
					result = flag;
					num = (short)1956904989;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_445:
					result = flag3;
					num = (short)54329375;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_4C2:
					num = (short)485949465;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_5D5:
					result = flag2;
					num = (short)1986920466;
					num2 = (int)((global::System.IntPtr)num);
				}
				return result;
				IL_C7:
				o5InnerSection = (self as global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO5.O5InnerSection);
				radErgoWideControlHeadMultipleControlHeadStyle_A = o5InnerSection.RefRadioErgonomicsWide.ControlHead.RadErgoWideControlHeadMultipleControlHeadStyle_A8561;
				radWideDualRadioSelection_A = o5InnerSection.RefRadioWide.DualRadio.RadWideDualRadioSelection_A42236;
				radErgoWideControlHeadMultiControlHead_A = o5InnerSection.RefRadioErgonomicsWide.ControlHead.RadErgoWideControlHeadMultiControlHead_A8550;
				features = (global::AcpCommonLib.FeatureManager.GetFeature(2045)[0][10105] as global::Motorola.MackinawCPS.CoreFeatures.RadioWide.Features);
				result = true;
				num = (short)709296142;
				num2 = (int)((global::System.IntPtr)num);
				goto IL_28;
			}
			}
		}
	}
}
