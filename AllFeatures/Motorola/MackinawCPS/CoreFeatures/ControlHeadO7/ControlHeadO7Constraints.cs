using System;
using System.Collections.Generic;
using AcpBusinessLayer;
using AcpBusinessLayer.UndoRedo;
using AcpCommonLib;
using AcpCommonLib.UndoRedo;
using ConstraintHelper;
using Motorola.MackinawCPS.CoreFeatures.ActionConsolidation;
using Motorola.MackinawCPS.CoreFeatures.Buttons;
using Motorola.MackinawCPS.CoreFeatures.ControlHeadE5;
using Motorola.MackinawCPS.CoreFeatures.ControlHeadO2;
using Motorola.MackinawCPS.CoreFeatures.ControlHeadO3;
using Motorola.MackinawCPS.CoreFeatures.ControlHeadO5;
using Motorola.MackinawCPS.CoreFeatures.ControlHeadO9;
using Motorola.MackinawCPS.CoreFeatures.KeypadMicAndAccessories;
using Motorola.MackinawCPS.CoreFeatures.RadioWide;
using Motorola.MackinawCPS.CoreFeatures.Shepherds;
using Motorola.MackinawCPS.CoreFeatures.Switches;

namespace Motorola.MackinawCPS.CoreFeatures.ControlHeadO7
{
	// Token: 0x0200038A RID: 906
	public static class ControlHeadO7Constraints
	{
		// Token: 0x0600868B RID: 34443 RVA: 0x007C9604 File Offset: 0x007C7804
		public static void ConSyncUpDownBtnFeature(global::AcpCommonLib.IAcpFeatureSection self, global::AcpCommonLib.UndoRedo.ContainerTask task)
		{
			short num = (short)536543232;
			int num2 = (int)num;
			switch (num2)
			{
			default:
			{
				switch (0)
				{
				case 0:
					goto IL_CE;
				}
				int num3;
				int num4;
				global::AcpCommonLib.IAcpRecordset parentRecset;
				bool flag;
				for (;;)
				{
					IL_27:
					global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO7.O7NavigationControlsTableInnerSection o7NavigationControlsTableInnerSection;
					switch (num2)
					{
					case 0:
						goto IL_6D6;
					case 1:
						if (o7NavigationControlsTableInnerSection != null)
						{
							num = (short)711655429;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return;
					case 2:
						if (num3 == 0)
						{
							num = (short)1979121664;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)217514014;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 3:
						num = (short)999555080;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 4:
						if (num4 != 88)
						{
							num = (short)1294008339;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_369;
					case 5:
						num = (short)1486159895;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 6:
						num = (short)1367015425;
						if (num != 0)
						{
						}
						if (num3 != 66)
						{
							num = (short)1961820191;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_369;
					case 7:
						if (num4 == 38)
						{
							num = (short)901644327;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_4F5;
					case 8:
						if (parentRecset.Count < 2)
						{
							num = (short)229179414;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)2128674843;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 9:
						num4 = o7NavigationControlsTableInnerSection.RadErgoControlO7UpDownButton_A41293.Value;
						num3 = num4 + 1;
						num = (short)669974535;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 10:
						num4 = 38;
						num = (short)1274544142;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 11:
						goto IL_192;
					case 12:
						goto IL_156;
					case 13:
						num = (short)1948319780;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 14:
						goto IL_5F9;
					case 15:
						goto IL_369;
					case 16:
						goto IL_156;
					case 17:
						num = (short)1946877978;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 18:
						if (num4 != 0)
						{
							num = (short)830996517;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return;
					case 19:
						num = (short)1943273506;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 20:
						if (num3 == 87)
						{
							num = (short)1913454607;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_6DB;
					case 21:
					{
						flag = true;
						num = (short)1630339072;
						short num5 = num;
						num = (short)1845624843;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 22:
						goto IL_422;
					case 23:
					{
						if (flag)
						{
							num3 = o7NavigationControlsTableInnerSection.RadErgoControlO7UpDownButton_A41293.Value;
							num4 = num3 - 1;
							num = (short)846266393;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)1337748354;
						short num6 = num;
						num = (short)616459138;
						switch ((num6 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_156;
						default:
							num = (short)719585280;
							if (num != 0)
							{
							}
							num = (short)175702025;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						break;
					}
					case 24:
						if (num4 != 65)
						{
							num = (short)719978513;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_369;
					case 25:
						if (num3 == 38)
						{
							num = (short)177340426;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_5F9;
					case 26:
						if (num4 != 67)
						{
							num = (short)1280311331;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_369;
					case 27:
						if (parentRecset[1] == self.Parent)
						{
							num = (short)1250295829;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_192;
					case 28:
						goto IL_4F5;
					case 29:
						if (parentRecset != null)
						{
							num = (short)826998787;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return;
					case 30:
						if (num4 != 144)
						{
							num = (short)1978531872;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_369;
					case 31:
						num = (short)1281622036;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 32:
						num = (short)1063256088;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 33:
						goto IL_38E;
					case 34:
						if (num3 != 143)
						{
							num = (short)1550057485;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_369;
					case 35:
						num = (short)1998651396;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 36:
						if (num3 != 64)
						{
							num = (short)1317797926;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_369;
					case 37:
						num = (short)375652354;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 38:
						num = (short)2119303174;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 39:
						num3 = 38;
						num = (short)312475676;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_CE;
					IL_156:
					num = (short)931987474;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_192:
					o7NavigationControlsTableInnerSection = (self as global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO7.O7NavigationControlsTableInnerSection);
					num = (short)1612120065;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_369:
					num4 = 143;
					num3 = 144;
					num = (short)235077665;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_4F5:
					task.AddTask(new global::AcpBusinessLayer.UndoRedo.ModifyDataTask<int>((self.ParentRecset[1] as global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO7.O7NavigationControlsTableInner).O7NavigationControlsTableInnerSection.RadErgoControlO7UpDownButton_A41293, num3));
					num = (short)1414463504;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_5F9:
					task.AddTask(new global::AcpBusinessLayer.UndoRedo.ModifyDataTask<int>((self.ParentRecset[0] as global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO7.O7NavigationControlsTableInner).O7NavigationControlsTableInnerSection.RadErgoControlO7UpDownButton_A41293, num4));
					num = (short)463405068;
					num2 = (int)((global::System.IntPtr)num);
				}
				return;
				IL_38E:
				goto IL_6DB;
				IL_422:
				return;
				IL_6D6:
				return;
				IL_6DB:
				global::Motorola.MackinawCPS.CoreFeatures.ControlHeadE5.ControlHeadE5Constraints.SyncNavigationControlsCPField(task, num4, num3);
				global::Motorola.MackinawCPS.CoreFeatures.ControlHeadE5.ControlHeadE5Constraints.SyncE5NavigationControls(task, num4, num3);
				global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO2.ControlHeadO2Constraints.SyncO2NavigationControls(task, num4, num3);
				global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO3.ControlHeadO3Constraints.SyncO3NavigationControls(task, num4, num3);
				global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO5.ControlHeadO5Constraints.SyncO5NavigationControls(task, num4, num3);
				global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO9.ControlHeadO9Constraints.SyncO9NavigationControls(task, num4, num3);
				global::Motorola.MackinawCPS.CoreFeatures.KeypadMicAndAccessories.KeypadMicAndAccessoriesConstraints.SyncKeypadMicAndAccessoriesNavigationControls(task, num4, num3);
				global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO7.ControlHeadO7Constraints.CalculateValidityForO2O7MFK();
				return;
				IL_CE:
				num4 = 0;
				num3 = 0;
				flag = false;
				parentRecset = self.ParentRecset;
				num = (short)1701249053;
				num2 = (int)((global::System.IntPtr)num);
				goto IL_27;
			}
			}
		}

		// Token: 0x0600868C RID: 34444 RVA: 0x007C9D2C File Offset: 0x007C7F2C
		public static void CalculateValidityForO2O7MFK()
		{
			short num = (short)1522466816;
			int num2 = (int)num;
			switch (num2)
			{
			default:
			{
				switch (0)
				{
				case 0:
					goto IL_56;
				}
				global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO2.ControlHeadO2Recset controlHeadO2Recset;
				for (;;)
				{
					IL_27:
					global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO7.ControlHeadO7Recset controlHeadO7Recset;
					switch (num2)
					{
					case 0:
						if (controlHeadO2Recset != null)
						{
							num = (short)367001600;
							short num3 = num;
							num = (short)335806471;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_123;
					case 1:
					{
						global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO2.O2MFKAssignmentControlInnerRecset o2MFKAssignmentControlInnerRecset;
						if (o2MFKAssignmentControlInnerRecset != null)
						{
							num = (short)2079653892;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_123;
					}
					case 2:
						return;
					case 3:
					{
						global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO7.O7MFKAssignmentControlInnerRecset o7MFKAssignmentControlInnerRecset;
						if (o7MFKAssignmentControlInnerRecset != null)
						{
							num = (short)1649803270;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return;
					}
					case 4:
					{
						num = (short)1959591937;
						if (num != 0)
						{
						}
						global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO2.O2MFKAssignmentControlInnerRecset o2MFKAssignmentControlInnerRecset;
						o2MFKAssignmentControlInnerRecset.CalculateValidity();
						num = (short)207028232;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 5:
					{
						global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO7.O7MFKAssignmentControlInnerRecset o7MFKAssignmentControlInnerRecset = controlHeadO7Recset[0][10718].EmbeddedRecset as global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO7.O7MFKAssignmentControlInnerRecset;
						num = (short)1565458435;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 6:
					{
						global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO7.O7MFKAssignmentControlInnerRecset o7MFKAssignmentControlInnerRecset;
						o7MFKAssignmentControlInnerRecset.CalculateValidity();
						num = (short)275513346;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 7:
					{
						global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO2.O2MFKAssignmentControlInnerRecset o2MFKAssignmentControlInnerRecset = controlHeadO2Recset[0][10721].EmbeddedRecset as global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO2.O2MFKAssignmentControlInnerRecset;
						num = (short)735385949;
						short num4 = num;
						num = (short)245635421;
						switch ((num4 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							break;
						default:
							num = (short)1486815232;
							if (num != 0)
							{
							}
							num = (short)1258029057;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						break;
					}
					case 8:
						goto IL_123;
					case 9:
						if (controlHeadO7Recset != null)
						{
							num = (short)85393413;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return;
					}
					goto IL_56;
					IL_123:
					controlHeadO7Recset = (global::AcpCommonLib.FeatureManager.GetFeature(4114) as global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO7.ControlHeadO7Recset);
					num = (short)1403650057;
					num2 = (int)((global::System.IntPtr)num);
				}
				return;
				IL_56:
				controlHeadO2Recset = (global::AcpCommonLib.FeatureManager.GetFeature(4115) as global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO2.ControlHeadO2Recset);
				num = (short)1257111552;
				num2 = (int)((global::System.IntPtr)num);
				goto IL_27;
			}
			}
		}

		// Token: 0x0600868D RID: 34445 RVA: 0x007C9FB8 File Offset: 0x007C81B8
		public static void SyncO7NavigationControls(global::AcpCommonLib.UndoRedo.ContainerTask task, int upButtonConfigedFeatureValue, int downButtonConfigedFeatureValue)
		{
			short num = (short)909246464;
			int num2 = (int)num;
			switch (num2)
			{
			default:
			{
				num = (short)1529479169;
				if (num != 0)
				{
				}
				switch (0)
				{
				case 0:
					goto IL_69;
				}
				global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO7.ControlHeadO7Recset controlHeadO7Recset;
				for (;;)
				{
					IL_4E:
					switch (num2)
					{
					case 0:
					{
						global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO7.O7NavigationControlsTableInnerRecset o7NavigationControlsTableInnerRecset;
						global::AcpBusinessLayer.AcpListField radErgoControlO7UpDownButton_A = (o7NavigationControlsTableInnerRecset[0][10728] as global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO7.O7NavigationControlsTableInnerSection).RadErgoControlO7UpDownButton_A41293;
						task.AddTask(new global::AcpBusinessLayer.UndoRedo.ModifyDataTask<int>(radErgoControlO7UpDownButton_A, upButtonConfigedFeatureValue));
						global::AcpBusinessLayer.AcpListField radErgoControlO7UpDownButton_A2 = (o7NavigationControlsTableInnerRecset[1][10728] as global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO7.O7NavigationControlsTableInnerSection).RadErgoControlO7UpDownButton_A41293;
						task.AddTask(new global::AcpBusinessLayer.UndoRedo.ModifyDataTask<int>(radErgoControlO7UpDownButton_A2, downButtonConfigedFeatureValue));
						num = (short)952500228;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 1:
					{
						num = (short)869939380;
						short num3 = num;
						num = (short)1415198900;
						switch ((num3 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							return;
						default:
						{
							num = (short)440795136;
							if (num != 0)
							{
							}
							global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO7.O7NavigationControlsTableInnerRecset o7NavigationControlsTableInnerRecset;
							if (o7NavigationControlsTableInnerRecset != null)
							{
								num = (short)1513029632;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							return;
						}
						}
						break;
					}
					case 2:
						if (controlHeadO7Recset != null)
						{
							num = (short)627048448;
							short num4 = num;
							num = (short)1065811971;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return;
					case 3:
					{
						global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO7.O7NavigationControlsTableInnerRecset o7NavigationControlsTableInnerRecset = controlHeadO7Recset[0][10727].EmbeddedRecset as global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO7.O7NavigationControlsTableInnerRecset;
						num = (short)1521680385;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 4:
						return;
					}
					goto IL_69;
				}
				return;
				IL_69:
				controlHeadO7Recset = (global::AcpCommonLib.FeatureManager.GetFeature(4114) as global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO7.ControlHeadO7Recset);
				num = (short)1265696770;
				num2 = (int)((global::System.IntPtr)num);
				goto IL_4E;
			}
			}
		}

		// Token: 0x0600868E RID: 34446 RVA: 0x007CA1AC File Offset: 0x007C83AC
		public static void ConSynSwitchMFKWithO7(global::AcpCommonLib.IAcpFeatureSection self, global::AcpCommonLib.UndoRedo.ContainerTask task)
		{
			short num = (short)83034112;
			switch (num)
			{
			default:
			{
				global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO7.O7MFKAssignmentControlInnerSection o7MFKAssignmentControlInnerSection = self as global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO7.O7MFKAssignmentControlInnerSection;
				int radErgoControlO7MFKFeatureAssignment_A41295Value = o7MFKAssignmentControlInnerSection.RadErgoControlO7MFKFeatureAssignment_A41295Value;
				global::System.Collections.Generic.IEnumerator<global::AcpBusinessLayer.FeatureNode> enumerator = (((global::AcpCommonLib.FeatureManager.GetFeature(2038) as global::Motorola.MackinawCPS.CoreFeatures.Switches.SwitchesRecset)[0] as global::Motorola.MackinawCPS.CoreFeatures.Switches.Switches).MultiFunctionKnob.EmbeddedRecset as global::Motorola.MackinawCPS.CoreFeatures.Switches.MFKAssignmentControlInnerRecset).GetEnumerator();
				try
				{
					num = (short)907542531;
					int num2 = (int)((global::System.IntPtr)num);
					for (;;)
					{
						switch (num2)
						{
						case 0:
							num = (short)16187393;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 1:
						{
							global::Motorola.MackinawCPS.CoreFeatures.Switches.MFKAssignmentControlInner mfkassignmentControlInner;
							if (mfkassignmentControlInner.MFKAssignmentControlInnerSection.RadErgoControlSwitchsMFKFeatureAssignment_A38514Value != radErgoControlO7MFKFeatureAssignment_A41295Value)
							{
								num = (short)506855426;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							break;
						}
						case 2:
						{
							global::Motorola.MackinawCPS.CoreFeatures.Switches.MFKAssignmentControlInner mfkassignmentControlInner;
							task.AddTask(mfkassignmentControlInner.MFKAssignmentControlInnerSection.RadErgoControlSwitchsMFKFeatureAssignment_A38514.GetModifyDataTask(radErgoControlO7MFKFeatureAssignment_A41295Value));
							num = (short)1588002821;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						case 3:
							switch (0)
							{
							case 0:
								goto IL_A6;
							}
							continue;
						case 4:
							num = (short)911671303;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 5:
							goto IL_1A4;
						case 6:
						{
							global::Motorola.MackinawCPS.CoreFeatures.Switches.MFKAssignmentControlInner mfkassignmentControlInner;
							if (mfkassignmentControlInner.MFKAssignmentControlInnerSection.SwitchMFKAssignmentControlName_A38529Value == o7MFKAssignmentControlInnerSection.O7MFKAssignmentControlName_A41294Value)
							{
								num = (short)630259712;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							break;
						}
						case 7:
							goto IL_1C3;
						case 8:
						{
							if (!enumerator.MoveNext())
							{
								num = (short)2001272836;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							global::Motorola.MackinawCPS.CoreFeatures.Switches.MFKAssignmentControlInner mfkassignmentControlInner = (global::Motorola.MackinawCPS.CoreFeatures.Switches.MFKAssignmentControlInner)enumerator.Current;
							num = (short)446103558;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						}
						IL_F8:
						num = (short)1830944776;
						num2 = (int)((global::System.IntPtr)num);
						continue;
						IL_A6:
						goto IL_F8;
					}
					IL_1A4:
					IL_1C3:;
				}
				finally
				{
					num = (short)1539161647;
					short num3 = num;
					num = (short)1326956079;
					int num2;
					switch ((num3 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						IL_260:
						enumerator.Dispose();
						num = (short)674824192;
						num2 = (int)((global::System.IntPtr)num);
						break;
					default:
						num = (short)1045102592;
						if (num != 0)
						{
						}
						num = (short)858193921;
						num2 = (int)((global::System.IntPtr)num);
						break;
					}
					for (;;)
					{
						switch (num2)
						{
						case 0:
							goto IL_27B;
						case 1:
							switch (0)
							{
							case 0:
								goto IL_245;
							}
							continue;
						case 2:
							goto IL_25E;
						}
						IL_245:
						if (enumerator == null)
						{
							goto IL_27D;
						}
						num = (short)1599143938;
						num2 = (int)((global::System.IntPtr)num);
					}
					IL_25E:
					goto IL_260;
					IL_27B:
					IL_27D:;
				}
				num = (short)515506176;
				short num4 = num;
				num = (short)1657077761;
				if (num != 0)
				{
				}
				return;
			}
			}
		}

		// Token: 0x0600868F RID: 34447 RVA: 0x007CA4A8 File Offset: 0x007C86A8
		public static bool ConPrimaryFunctionIsNonBlankO7(global::AcpCommonLib.IAcpFeatureSection self)
		{
			short num = (short)225705984;
			int num2 = (int)num;
			switch (num2)
			{
			default:
			{
				switch (0)
				{
				case 0:
					goto IL_4F;
				}
				global::AcpCommonLib.IAcpRecordset parentRecset;
				global::AcpCommonLib.IAcpFeatureNode parent;
				bool result;
				for (;;)
				{
					IL_28:
					switch (num2)
					{
					case 0:
					{
						global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO7.O7MultiFunctionKnob o7MultiFunctionKnob;
						if (o7MultiFunctionKnob != null)
						{
							num = (short)1054146560;
							short num3 = num;
							num = (short)1434517506;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_191;
					}
					case 1:
					{
						global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO7.O7MultiFunctionKnob o7MultiFunctionKnob = parentRecset.ParentSection as global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO7.O7MultiFunctionKnob;
						num = (short)1529544705;
						if (num != 0)
						{
						}
						num = (short)1779499008;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 2:
						num = (short)1646788611;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 3:
					{
						global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO7.O7MultiFunctionKnob o7MultiFunctionKnob;
						if (o7MultiFunctionKnob.RadErgoControlO7MFKButtonPress_A42218 != null)
						{
							num = (short)747372550;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_191;
					}
					case 4:
					{
						global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO7.O7MultiFunctionKnob o7MultiFunctionKnob;
						if (o7MultiFunctionKnob.RadErgoControlO7MFKButtonPress_A42218.Value == 31)
						{
							num = (short)749338631;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_191;
					}
					case 5:
						if ((parent.Parent as global::AcpBusinessLayer.Recordset).IndexOf(parent) == 1)
						{
							num = (short)382074881;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return result;
					case 6:
					{
						num = (short)625888939;
						short num4 = num;
						num = (short)1832734379;
						switch ((num4 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							continue;
						default:
							num = (short)1268121600;
							if (num != 0)
							{
							}
							num = (short)222625796;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						break;
					}
					case 7:
						return false;
					}
					goto IL_4F;
				}
				return false;
				IL_191:
				return (parentRecset[0] as global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO7.O7MFKAssignmentControlInner).O7MFKAssignmentControlInnerSection.RadErgoControlO7MFKFeatureAssignment_A41295.Value != 38;
				IL_4F:
				result = true;
				global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO7.O7MFKAssignmentControlInnerSection o7MFKAssignmentControlInnerSection = self as global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO7.O7MFKAssignmentControlInnerSection;
				parentRecset = self.ParentRecset;
				parent = o7MFKAssignmentControlInnerSection.RadErgoControlO7MFKFeatureAssignment_A41295.Parent.Parent;
				num = (short)1051787269;
				num2 = (int)((global::System.IntPtr)num);
				goto IL_28;
			}
			}
		}

		// Token: 0x06008690 RID: 34448 RVA: 0x007CA6F4 File Offset: 0x007C88F4
		public static bool ConValidityMFKAssignControlO7(global::AcpCommonLib.IAcpFeatureSection self, int index)
		{
			short num = (short)1701642240;
			int num2 = (int)num;
			switch (num2)
			{
			default:
			{
				switch (0)
				{
				case 0:
					goto IL_BB;
				}
				global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO7.O7MultiFunctionKnob o7MultiFunctionKnob;
				bool result;
				bool flag;
				for (;;)
				{
					IL_28:
					global::AcpCommonLib.IAcpRecordset parentRecset;
					int num3;
					global::Motorola.MackinawCPS.CoreFeatures.Shepherds.ShepherdsRecset shepherdsRecset;
					switch (num2)
					{
					case 0:
						if (o7MultiFunctionKnob.RadErgoControlO7MFKButtonPress_A42218 != null)
						{
							num = (short)842268679;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_56B;
					case 1:
						goto IL_668;
					case 2:
						num = (short)1691090965;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 3:
						return false;
					case 4:
						if (o7MultiFunctionKnob.RadErgoControlO7MFKButtonPress_A42218.Value == 31)
						{
							num = (short)1240989716;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_56B;
					case 5:
						goto IL_668;
					case 6:
					{
						int value = (parentRecset[0] as global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO7.O7MFKAssignmentControlInner).O7MFKAssignmentControlInnerSection.RadErgoControlO7MFKFeatureAssignment_A41295.Value;
						num = (short)933560331;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 7:
						num = (short)1105985540;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 8:
						if (index != 23)
						{
							num = (short)579993629;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return result;
					case 9:
						if (num3 >= parentRecset.Count)
						{
							num = (short)842334210;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						(parentRecset[num3] as global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO7.O7MFKAssignmentControlInner).O7MFKAssignmentControlInnerSection.RadErgoControlO7MFKFeatureAssignment_A41295.CalculateApplicability();
						num3++;
						num = (short)1925971969;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 10:
						num = (short)807141399;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 11:
					{
						int value;
						if (value == 38)
						{
							num = (short)1989607438;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_46E;
					}
					case 12:
						if (shepherdsRecset.Count > 0)
						{
							num = (short)1567096845;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_5B8;
					case 13:
					{
						global::System.Collections.Generic.IEnumerator<global::AcpBusinessLayer.FeatureNode> enumerator = (shepherdsRecset[0][10031].EmbeddedRecset as global::Motorola.MackinawCPS.CoreFeatures.Shepherds.SignalIndependentProductIndependentNonProgrammableButtonListInnerRecset).GetEnumerator();
						num = (short)1320484898;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 14:
						return false;
					case 15:
						if (parentRecset[1] == self.Parent)
						{
							num = (short)1310726;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return result;
					case 16:
						return false;
					case 17:
					{
						int value;
						if (value != 23)
						{
							num = (short)1307836434;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return result;
					}
					case 18:
						num = (short)1024655368;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 19:
						num = (short)396034048;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 20:
						return true;
					case 21:
						if (parentRecset[0] == self.Parent)
						{
							num = (short)723517466;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_61F;
					case 22:
						if (index == 38)
						{
							num = (short)458948624;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)1174929439;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 23:
					{
						int value2;
						if (value2 != 23)
						{
							num = (short)167575582;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_61F;
					}
					case 24:
						if (o7MultiFunctionKnob != null)
						{
							num = (short)2018115603;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_56B;
					case 25:
						if (!flag)
						{
							num = (short)2026766363;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return result;
					case 26:
					{
						int value2 = (parentRecset[1] as global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO7.O7MFKAssignmentControlInner).O7MFKAssignmentControlInnerSection.RadErgoControlO7MFKFeatureAssignment_A41295.Value;
						num = (short)1370226710;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 27:
						num = (short)597032977;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 28:
						num = (short)1746796556;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 29:
						return false;
					case 30:
						num = (short)1935605792;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 31:
					{
						num = (short)825360384;
						short num4 = num;
						num = (short)1019805697;
						if (num != 0)
						{
						}
						if (!flag)
						{
							num = (short)835780618;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_61F;
					}
					case 32:
						if (index != 23)
						{
							num = (short)1667563523;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_61F;
					case 33:
						if (shepherdsRecset != null)
						{
							num = (short)1953693724;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_5B8;
					case 34:
						try
						{
							num = (short)6488068;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								switch (num2)
								{
								case 0:
									goto IL_3FD;
								case 1:
								{
									global::AcpCommonLib.IAcpFeatureNode acpFeatureNode;
									if ((acpFeatureNode[10032] as global::Motorola.MackinawCPS.CoreFeatures.Shepherds.SignalIndependentProductIndependentNonProgrammableButtonListInnerSection).RadErgoCfgSignalIndependentProductIndependentNonProgrammableButtonBCO_A19777.Value == 135)
									{
										num = (short)1569587203;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									break;
								}
								case 2:
									goto IL_3E4;
								case 3:
									num = (short)2136408071;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 4:
								{
									num = (short)441168353;
									short num5 = num;
									num = (short)1481355745;
									switch ((num5 == num) ? 1 : 0)
									{
									case 0:
									case 2:
										goto IL_3E4;
									default:
										num = (short)1977352192;
										if (num != 0)
										{
										}
										switch (0)
										{
										case 0:
											goto IL_2C7;
										}
										continue;
									}
									break;
								}
								case 5:
								{
									global::System.Collections.Generic.IEnumerator<global::AcpBusinessLayer.FeatureNode> enumerator;
									if (!enumerator.MoveNext())
									{
										num = (short)974389250;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									global::AcpCommonLib.IAcpFeatureNode acpFeatureNode = enumerator.Current;
									num = (short)1265500161;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 6:
									flag = true;
									num = (short)1081671688;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 7:
								{
									global::AcpCommonLib.IAcpFeatureNode acpFeatureNode;
									if ((acpFeatureNode[10032] as global::Motorola.MackinawCPS.CoreFeatures.Shepherds.SignalIndependentProductIndependentNonProgrammableButtonListInnerSection).RadErgoCfgSignalIndependentProductIndependentNonProgrammableButtonFeature_A19778.Value == 87)
									{
										num = (short)1751580678;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									break;
								}
								case 8:
									goto IL_3DF;
								}
								IL_382:
								num = (short)1865744389;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								IL_2C7:
								goto IL_382;
								IL_3E4:
								num = (short)277479424;
								num2 = (int)((global::System.IntPtr)num);
							}
							IL_3DF:
							IL_3FD:
							goto IL_5B8;
						}
						finally
						{
							num = (short)1961492481;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								global::System.Collections.Generic.IEnumerator<global::AcpBusinessLayer.FeatureNode> enumerator;
								switch (num2)
								{
								case 0:
									enumerator.Dispose();
									num = (short)1114046466;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 1:
									switch (0)
									{
									case 0:
										goto IL_434;
									}
									continue;
								case 2:
									goto IL_46B;
								}
								IL_434:
								if (enumerator == null)
								{
									break;
								}
								num = (short)170721280;
								num2 = (int)((global::System.IntPtr)num);
							}
							IL_46B:;
						}
						goto IL_46E;
					}
					goto IL_BB;
					IL_46E:
					num = (short)1833566233;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_56B:
					shepherdsRecset = (global::AcpCommonLib.FeatureManager.GetFeature(2013) as global::Motorola.MackinawCPS.CoreFeatures.Shepherds.ShepherdsRecset);
					num = (short)1342177313;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_5B8:
					parentRecset = self.ParentRecset;
					num3 = 0;
					num = (short)2138046469;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_61F:
					num = (short)101515279;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_668:
					num = (short)1513619465;
					num2 = (int)((global::System.IntPtr)num);
				}
				return false;
				IL_BB:
				result = true;
				flag = false;
				o7MultiFunctionKnob = (self.ParentRecset.ParentSection as global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO7.O7MultiFunctionKnob);
				num = (short)1634598936;
				num2 = (int)((global::System.IntPtr)num);
				goto IL_28;
			}
			}
		}

		// Token: 0x06008691 RID: 34449 RVA: 0x007CAF88 File Offset: 0x007C9188
		public static void ConSyncCnvDataBtnFeature(global::AcpCommonLib.IAcpFeatureSection self, global::AcpCommonLib.UndoRedo.ContainerTask task)
		{
			short num = (short)1859190784;
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
				int featureSectionId;
				global::AcpBusinessLayer.AcpRecRefField acpRecRefField;
				global::AcpBusinessLayer.AcpListField acpListField;
				int num3;
				for (;;)
				{
					IL_28:
					global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO9.ConsolidatedActionBCOListInnerRecset consolidatedActionBCOListInnerRecset;
					global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO9.ControlHeadO9Recset controlHeadO9Recset;
					global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO9.O9DataButtonInnerRecset o9DataButtonInnerRecset;
					global::System.Collections.Generic.IEnumerator<global::AcpBusinessLayer.FeatureNode> enumerator;
					global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO7.O7DataButtonInnerRecset o7DataButtonInnerRecset;
					global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO3.DataButtonInnerRecset dataButtonInnerRecset2;
					global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO3.ControlHeadO3Recset controlHeadO3Recset;
					global::Motorola.MackinawCPS.CoreFeatures.Buttons.DataButtonInnerRecset dataButtonInnerRecset3;
					global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO7.ControlHeadO7Recset controlHeadO7Recset;
					global::Motorola.MackinawCPS.CoreFeatures.Buttons.ButtonsRecset buttonsRecset;
					bool flag2;
					global::Motorola.MackinawCPS.CoreFeatures.RadioWide.RadioWide radioWide;
					switch (num2)
					{
					case 0:
						goto IL_15C1;
					case 1:
					{
						if (!flag)
						{
							num = (short)910426149;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						global::Motorola.MackinawCPS.CoreFeatures.KeypadMicAndAccessories.KeypadMicAndAccessoriesRecset keypadMicAndAccessoriesRecset = null;
						global::Motorola.MackinawCPS.CoreFeatures.KeypadMicAndAccessories.DataButtonInnerRecset dataButtonInnerRecset = null;
						keypadMicAndAccessoriesRecset = (global::AcpCommonLib.FeatureManager.GetFeature(2128) as global::Motorola.MackinawCPS.CoreFeatures.KeypadMicAndAccessories.KeypadMicAndAccessoriesRecset);
						num = (short)839712806;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 2:
						if (featureSectionId <= 10209)
						{
							num = (short)1215561776;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)1166802978;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 3:
						num = (short)1970733079;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 4:
						goto IL_162A;
					case 5:
					{
						task.AddTask(new global::AcpBusinessLayer.UndoRedo.AddRecordTask(consolidatedActionBCOListInnerRecset.CreateDefaultRecord()));
						int index = consolidatedActionBCOListInnerRecset.Count - 1;
						global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO9.ConsolidatedActionBCOListInner consolidatedActionBCOListInner = consolidatedActionBCOListInnerRecset[index] as global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO9.ConsolidatedActionBCOListInner;
						task.AddTask(new global::AcpBusinessLayer.UndoRedo.ModifyDataTask<int>(consolidatedActionBCOListInner.ConsolidatedActionBCOListInnerSection.RadErgoControlO9ACBCOListBco_A36666, 134));
						task.AddTask(new global::AcpBusinessLayer.UndoRedo.ModifyRecRefDataTask(consolidatedActionBCOListInner.ConsolidatedActionBCOListInnerSection.RadErgoControlO9ACBCOListIndex_A36668, acpRecRefField.UIValue));
						num = (short)1524826176;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 6:
						o9DataButtonInnerRecset = (controlHeadO9Recset[0][10611].EmbeddedRecset as global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO9.O9DataButtonInnerRecset);
						num = (short)2064842759;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 7:
						goto IL_B07;
					case 8:
						if (o9DataButtonInnerRecset != null)
						{
							num = (short)1806827532;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_22D;
					case 9:
						num = (short)835452945;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 10:
						if (acpListField != null)
						{
							num = (short)559808599;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return;
					case 11:
						if (controlHeadO9Recset != null)
						{
							num = (short)1718812678;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_B07;
					case 12:
						enumerator = o9DataButtonInnerRecset.GetEnumerator();
						num = (short)2052325401;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 13:
						enumerator = consolidatedActionBCOListInnerRecset.GetEnumerator();
						num = (short)961282128;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 14:
						if (featureSectionId != 10608)
						{
							num = (short)1229455369;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_10B6;
					case 15:
						enumerator = o7DataButtonInnerRecset.GetEnumerator();
						num = (short)1183187000;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 16:
						if (controlHeadO9Recset != null)
						{
							num = (short)882507851;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_223F;
					case 17:
					{
						if (featureSectionId != 10713)
						{
							num = (short)202375171;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO7.O7DataButtonInnerSection o7DataButtonInnerSection = self as global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO7.O7DataButtonInnerSection;
						num3 = o7DataButtonInnerSection.RadErgCtrlHeadO7DataButtonCnvFeature_A41299.Value;
						acpRecRefField = o7DataButtonInnerSection.CHO7DataButtonConvIndex_A41417;
						acpListField = o7DataButtonInnerSection.RadErgCtrlHeadO7DataButtonTrkFeature_A41297;
						num = (short)394002509;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 18:
						if (dataButtonInnerRecset2 != null)
						{
							num = (short)1449197633;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_1C4E;
					case 19:
						dataButtonInnerRecset2 = (controlHeadO3Recset[0][10234].EmbeddedRecset as global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO3.DataButtonInnerRecset);
						num = (short)366805059;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 20:
						enumerator = dataButtonInnerRecset2.GetEnumerator();
						num = (short)470155353;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 21:
						goto IL_162A;
					case 22:
						goto IL_1928;
					case 23:
						goto IL_6D0;
					case 24:
						if (num3 == 227)
						{
							num = (short)98697260;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_223F;
					case 25:
						try
						{
							num = (short)1587740673;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								switch (num2)
								{
								case 0:
								{
									global::AcpCommonLib.IAcpFeatureNode acpFeatureNode;
									if (num3 != (acpFeatureNode[10608] as global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO9.O9DataButtonInnerSection).RadErgCtrlHeadO9DataButtonCnvFeature_A36528.Value)
									{
										num = (short)1130627076;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									break;
								}
								case 1:
									switch (0)
									{
									case 0:
										goto IL_2015;
									}
									continue;
								case 2:
									goto IL_20AA;
								case 3:
									goto IL_2107;
								case 4:
								{
									global::AcpCommonLib.IAcpFeatureNode acpFeatureNode;
									task.AddTask(new global::AcpBusinessLayer.UndoRedo.ModifyDataTask<int>((acpFeatureNode[10608] as global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO9.O9DataButtonInnerSection).RadErgCtrlHeadO9DataButtonCnvFeature_A36528, num3));
									num = (short)1761804290;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 5:
								{
									if (!enumerator.MoveNext())
									{
										num = (short)415170566;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									global::AcpCommonLib.IAcpFeatureNode acpFeatureNode = enumerator.Current;
									num = (short)189726720;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 6:
									num = (short)214892547;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								IL_20AF:
								num = (short)2089222149;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								IL_2015:
								goto IL_20AF;
							}
							IL_20AA:
							IL_2107:
							goto IL_22D;
						}
						finally
						{
							num = (short)1777532930;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								switch (num2)
								{
								case 0:
									enumerator.Dispose();
									num = (short)893452289;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 1:
									goto IL_2177;
								case 2:
									switch (0)
									{
									case 0:
										goto IL_213F;
									}
									continue;
								}
								IL_213F:
								if (enumerator == null)
								{
									break;
								}
								num = (short)692846592;
								num2 = (int)((global::System.IntPtr)num);
							}
							IL_2177:;
						}
						goto IL_217A;
					case 26:
						if (controlHeadO3Recset != null)
						{
							num = (short)763232275;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_C75;
					case 27:
					{
						if (featureSectionId != 10209)
						{
							num = (short)1878327356;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						global::Motorola.MackinawCPS.CoreFeatures.KeypadMicAndAccessories.DataButtonInnerSection dataButtonInnerSection = self as global::Motorola.MackinawCPS.CoreFeatures.KeypadMicAndAccessories.DataButtonInnerSection;
						num3 = dataButtonInnerSection.RadErgoCfgKMConventionalKMDatatButtonFeature_A22603.Value;
						acpRecRefField = dataButtonInnerSection.RadErgoCfgKMConventionalKMDatatButtonIndex_A41423;
						acpListField = dataButtonInnerSection.RadErgoCfgKMTrunkingKMDatatButtonFeature_A22605;
						num = (short)1314062357;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 28:
						num = (short)1383333958;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 29:
						if (!acpListField.HiddenStatic)
						{
							num = (short)213909504;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_1B4A;
					case 30:
						enumerator = o9DataButtonInnerRecset.GetEnumerator();
						num = (short)114229326;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 31:
						if (dataButtonInnerRecset3 != null)
						{
							num = (short)1862402105;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_EB0;
					case 32:
						if (consolidatedActionBCOListInnerRecset != null)
						{
							num = (short)986054669;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_223F;
					case 33:
						if (controlHeadO9Recset.Count > 0)
						{
							num = (short)1870266421;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_223F;
					case 34:
						if (featureSectionId != 10212)
						{
							num = (short)343933010;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_1EB0;
					case 35:
						num = (short)131465277;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 36:
						num = (short)218366028;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 37:
						return;
					case 38:
					{
						global::Motorola.MackinawCPS.CoreFeatures.KeypadMicAndAccessories.KeypadMicAndAccessoriesRecset keypadMicAndAccessoriesRecset;
						if (keypadMicAndAccessoriesRecset != null)
						{
							num = (short)500760615;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_B6B;
					}
					case 39:
					{
						global::Motorola.MackinawCPS.CoreFeatures.KeypadMicAndAccessories.KeypadMicAndAccessoriesRecset keypadMicAndAccessoriesRecset;
						global::Motorola.MackinawCPS.CoreFeatures.KeypadMicAndAccessories.DataButtonInnerRecset dataButtonInnerRecset = keypadMicAndAccessoriesRecset[0][10228].EmbeddedRecset as global::Motorola.MackinawCPS.CoreFeatures.KeypadMicAndAccessories.DataButtonInnerRecset;
						num = (short)1891631145;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 40:
					{
						global::Motorola.MackinawCPS.CoreFeatures.KeypadMicAndAccessories.DataButtonInnerRecset dataButtonInnerRecset;
						if (dataButtonInnerRecset != null)
						{
							num = (short)505151530;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_2202;
					}
					case 41:
						goto IL_B6B;
					case 42:
					{
						global::Motorola.MackinawCPS.CoreFeatures.KeypadMicAndAccessories.DataButtonInnerRecset dataButtonInnerRecset;
						enumerator = dataButtonInnerRecset.GetEnumerator();
						num = (short)1380974650;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 43:
						goto IL_162A;
					case 44:
						num = (short)1458896947;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 45:
						if (controlHeadO7Recset != null)
						{
							num = (short)480837715;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_12D8;
					case 46:
						if (dataButtonInnerRecset3 != null)
						{
							num = (short)996999239;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_BC0;
					case 47:
						goto IL_6D0;
					case 48:
						num = (short)1589379157;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 49:
						if (dataButtonInnerRecset2 != null)
						{
							num = (short)2015494164;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_353;
					case 50:
						dataButtonInnerRecset3 = (buttonsRecset[0][10089].EmbeddedRecset as global::Motorola.MackinawCPS.CoreFeatures.Buttons.DataButtonInnerRecset);
						num = (short)1807876175;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 51:
						if (!flag2)
						{
							num = (short)1334116357;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_223F;
					case 52:
						try
						{
							num = (short)144900097;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								switch (num2)
								{
								case 0:
									goto IL_1D88;
								case 1:
									switch (0)
									{
									case 0:
										goto IL_1D4F;
									}
									continue;
								case 2:
									num = (short)971898883;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 3:
									goto IL_1E3D;
								case 4:
								{
									if (!enumerator.MoveNext())
									{
										num = (short)1963524098;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									global::AcpCommonLib.IAcpFeatureNode acpFeatureNode2 = enumerator.Current;
									num = (short)1062797317;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 5:
								{
									global::AcpCommonLib.IAcpFeatureNode acpFeatureNode2;
									if (num3 != (acpFeatureNode2[10209] as global::Motorola.MackinawCPS.CoreFeatures.KeypadMicAndAccessories.DataButtonInnerSection).RadErgoCfgKMTrunkingKMDatatButtonFeature_A22605.Value)
									{
										num = (short)1041956870;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									break;
								}
								case 6:
								{
									global::AcpCommonLib.IAcpFeatureNode acpFeatureNode2;
									task.AddTask(new global::AcpBusinessLayer.UndoRedo.ModifyDataTask<int>((acpFeatureNode2[10209] as global::Motorola.MackinawCPS.CoreFeatures.KeypadMicAndAccessories.DataButtonInnerSection).RadErgoCfgKMTrunkingKMDatatButtonFeature_A22605, num3));
									num = (short)1391525888;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								}
								IL_1D8D:
								num = (short)1112211460;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								IL_1D4F:
								goto IL_1D8D;
							}
							IL_1D88:
							IL_1E3D:
							goto IL_15C6;
						}
						finally
						{
							num = (short)1942683648;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								switch (num2)
								{
								case 0:
									switch (0)
									{
									case 0:
										goto IL_1E75;
									}
									continue;
								case 1:
									enumerator.Dispose();
									num = (short)1442840578;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 2:
									goto IL_1EAD;
								}
								IL_1E75:
								if (enumerator == null)
								{
									break;
								}
								num = (short)1999306753;
								num2 = (int)((global::System.IntPtr)num);
							}
							IL_1EAD:;
						}
						goto IL_1EB0;
					case 53:
						consolidatedActionBCOListInnerRecset = (controlHeadO9Recset[0][10622].EmbeddedRecset as global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO9.ConsolidatedActionBCOListInnerRecset);
						num = (short)1204224032;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 54:
					{
						global::Motorola.MackinawCPS.CoreFeatures.KeypadMicAndAccessories.DataButtonInnerRecset dataButtonInnerRecset;
						if (dataButtonInnerRecset != null)
						{
							num = (short)2128543803;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_15C6;
					}
					case 55:
						goto IL_217A;
					case 56:
						try
						{
							num = (short)1714880514;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								switch (num2)
								{
								case 0:
								{
									global::AcpCommonLib.IAcpFeatureNode acpFeatureNode3;
									task.AddTask(new global::AcpBusinessLayer.UndoRedo.ModifyDataTask<int>((acpFeatureNode3[10713] as global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO7.O7DataButtonInnerSection).RadErgCtrlHeadO7DataButtonTrkFeature_A41297, num3));
									num = (short)2015690757;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 1:
									num = (short)1855979526;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 2:
									switch (0)
									{
									case 0:
										goto IL_1179;
									}
									continue;
								case 3:
								{
									if (!enumerator.MoveNext())
									{
										num = (short)920649729;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									global::AcpCommonLib.IAcpFeatureNode acpFeatureNode3 = enumerator.Current;
									num = (short)1917779972;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 4:
								{
									global::AcpCommonLib.IAcpFeatureNode acpFeatureNode3;
									if (num3 != (acpFeatureNode3[10713] as global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO7.O7DataButtonInnerSection).RadErgCtrlHeadO7DataButtonTrkFeature_A41297.Value)
									{
										num = (short)1448869888;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									break;
								}
								case 5:
									goto IL_11B3;
								case 6:
									goto IL_1267;
								}
								IL_11B8:
								num = (short)1085997059;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								IL_1179:
								goto IL_11B8;
							}
							IL_11B3:
							IL_1267:
							goto IL_1BD3;
						}
						finally
						{
							num = (short)2118582273;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								switch (num2)
								{
								case 0:
									enumerator.Dispose();
									num = (short)226361346;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 1:
									switch (0)
									{
									case 0:
										goto IL_129E;
									}
									continue;
								case 2:
									goto IL_12D5;
								}
								IL_129E:
								if (enumerator == null)
								{
									break;
								}
								num = (short)1633419264;
								num2 = (int)((global::System.IntPtr)num);
							}
							IL_12D5:;
						}
						goto IL_12D8;
					case 57:
						num = (short)755040257;
						if (num != 0)
						{
						}
						enumerator = dataButtonInnerRecset3.GetEnumerator();
						num = (short)1868496969;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 58:
						goto IL_8CB;
					case 59:
					{
						global::Motorola.MackinawCPS.CoreFeatures.KeypadMicAndAccessories.DataButtonInnerRecset dataButtonInnerRecset;
						enumerator = dataButtonInnerRecset.GetEnumerator();
						num = (short)212009012;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 60:
						num = (short)974585903;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 61:
						if (num3 != 140)
						{
							num = (short)638976036;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_1B4A;
					case 62:
						num = (short)17694747;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 63:
						if (o9DataButtonInnerRecset != null)
						{
							num = (short)1636565022;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_2304;
					case 64:
						goto IL_223F;
					case 65:
						goto IL_610;
					case 66:
						goto IL_12D8;
					case 67:
						goto IL_C75;
					case 68:
						enumerator = o7DataButtonInnerRecset.GetEnumerator();
						num = (short)1003683924;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 69:
						if (num3 != 227)
						{
							num = (short)71237667;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_1B4A;
					case 70:
						if (radioWide.DualRadio.RadWideDualRadioSelection_A42236 == 0)
						{
							num = (short)1820983351;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_1B4A;
					case 71:
						enumerator = dataButtonInnerRecset3.GetEnumerator();
						num = (short)454099018;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 72:
						if (o7DataButtonInnerRecset != null)
						{
							num = (short)67436612;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_1C10;
					case 73:
						try
						{
							num = (short)15597570;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								switch (num2)
								{
								case 0:
								{
									global::AcpCommonLib.IAcpFeatureNode acpFeatureNode4;
									task.AddTask(new global::AcpBusinessLayer.UndoRedo.ModifyDataTask<int>((acpFeatureNode4[10090] as global::Motorola.MackinawCPS.CoreFeatures.Buttons.DataButtonInnerSection).BtnConventionalButtonDatatButtonFeature_A22610, num3));
									num = (short)1361117189;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 1:
									num = (short)1124073478;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 2:
									switch (0)
									{
									case 0:
										goto IL_1423;
									}
									continue;
								case 3:
								{
									if (!enumerator.MoveNext())
									{
										num = (short)1303183361;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									global::AcpCommonLib.IAcpFeatureNode acpFeatureNode4 = enumerator.Current;
									num = (short)890241028;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 4:
								{
									global::AcpCommonLib.IAcpFeatureNode acpFeatureNode4;
									if (num3 != (acpFeatureNode4[10090] as global::Motorola.MackinawCPS.CoreFeatures.Buttons.DataButtonInnerSection).BtnConventionalButtonDatatButtonFeature_A22610.Value)
									{
										num = (short)1455947776;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									break;
								}
								case 5:
									goto IL_145C;
								case 6:
									goto IL_1511;
								}
								IL_1461:
								num = (short)1848311811;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								IL_1423:
								goto IL_1461;
							}
							IL_145C:
							IL_1511:
							goto IL_EB0;
						}
						finally
						{
							num = (short)850132993;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								switch (num2)
								{
								case 0:
									enumerator.Dispose();
									num = (short)1539375106;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 1:
									switch (0)
									{
									case 0:
										goto IL_1548;
									}
									continue;
								case 2:
									goto IL_1581;
								}
								IL_1548:
								if (enumerator == null)
								{
									break;
								}
								num = (short)1600585728;
								num2 = (int)((global::System.IntPtr)num);
							}
							IL_1581:;
						}
						goto IL_1584;
					case 74:
						try
						{
							num = (short)757792771;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								switch (num2)
								{
								case 0:
								{
									global::AcpCommonLib.IAcpFeatureNode acpFeatureNode5;
									if (num3 != (acpFeatureNode5[10090] as global::Motorola.MackinawCPS.CoreFeatures.Buttons.DataButtonInnerSection).BtnTrunkingButtonDatatButtonFeature_A22608.Value)
									{
										num = (short)1848180738;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									break;
								}
								case 1:
									goto IL_83B;
								case 2:
								{
									global::AcpCommonLib.IAcpFeatureNode acpFeatureNode5;
									task.AddTask(new global::AcpBusinessLayer.UndoRedo.ModifyDataTask<int>((acpFeatureNode5[10090] as global::Motorola.MackinawCPS.CoreFeatures.Buttons.DataButtonInnerSection).BtnTrunkingButtonDatatButtonFeature_A22608, num3));
									num = (short)269287425;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 3:
									switch (0)
									{
									case 0:
										goto IL_76D;
									}
									continue;
								case 4:
									goto IL_858;
								case 5:
								{
									if (!enumerator.MoveNext())
									{
										num = (short)1674051590;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									global::AcpCommonLib.IAcpFeatureNode acpFeatureNode5 = enumerator.Current;
									num = (short)1014562816;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 6:
									num = (short)388235268;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								IL_7C5:
								num = (short)79101957;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								IL_76D:
								goto IL_7C5;
							}
							IL_83B:
							IL_858:
							goto IL_BC0;
						}
						finally
						{
							num = (short)1217724416;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								switch (num2)
								{
								case 0:
									switch (0)
									{
									case 0:
										goto IL_88F;
									}
									continue;
								case 1:
									goto IL_8C8;
								case 2:
									enumerator.Dispose();
									num = (short)882311169;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								IL_88F:
								if (enumerator == null)
								{
									break;
								}
								num = (short)361758722;
								num2 = (int)((global::System.IntPtr)num);
							}
							IL_8C8:;
						}
						goto Block_12;
					case 75:
						goto IL_1ACA;
					case 76:
						if (num3 == 228)
						{
							num = (short)541130780;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_217A;
					case 77:
						goto IL_162A;
					case 78:
						try
						{
							num = (short)328859651;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								switch (num2)
								{
								case 0:
									goto IL_4E5;
								case 1:
									num = (short)847446020;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 2:
								{
									global::AcpCommonLib.IAcpFeatureNode acpFeatureNode6;
									if (num3 != (acpFeatureNode6[10608] as global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO9.O9DataButtonInnerSection).RadErgCtrlHeadO9DataButtonTrkFeature_A36526.Value)
									{
										num = (short)959053829;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									break;
								}
								case 3:
									switch (0)
									{
									case 0:
										goto IL_4A9;
									}
									continue;
								case 4:
									goto IL_59C;
								case 5:
								{
									global::AcpCommonLib.IAcpFeatureNode acpFeatureNode6;
									task.AddTask(new global::AcpBusinessLayer.UndoRedo.ModifyDataTask<int>((acpFeatureNode6[10608] as global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO9.O9DataButtonInnerSection).RadErgCtrlHeadO9DataButtonTrkFeature_A36526, num3));
									num = (short)990380032;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 6:
								{
									if (!enumerator.MoveNext())
									{
										num = (short)856555521;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									global::AcpCommonLib.IAcpFeatureNode acpFeatureNode6 = enumerator.Current;
									num = (short)287768578;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								}
								IL_548:
								num = (short)1811808262;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								IL_4A9:
								goto IL_548;
							}
							IL_4E5:
							IL_59C:
							goto IL_2304;
						}
						finally
						{
							num = (short)1636958208;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								switch (num2)
								{
								case 0:
									switch (0)
									{
									case 0:
										goto IL_5D4;
									}
									continue;
								case 1:
									goto IL_60D;
								case 2:
									enumerator.Dispose();
									num = (short)1124925441;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								IL_5D4:
								if (enumerator == null)
								{
									break;
								}
								num = (short)2017656834;
								num2 = (int)((global::System.IntPtr)num);
							}
							IL_60D:;
						}
						goto IL_610;
					case 79:
						goto IL_3EC;
					case 80:
						try
						{
							num = (short)217251841;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								switch (num2)
								{
								case 0:
									goto IL_1787;
								case 1:
									switch (0)
									{
									case 0:
										goto IL_16C5;
									}
									continue;
								case 2:
									goto IL_18B4;
								case 3:
								{
									global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO9.ConsolidatedActionBCOListInner consolidatedActionBCOListInner2;
									if (consolidatedActionBCOListInner2.ConsolidatedActionBCOListInnerSection.RadErgoControlO9ACBCOListBco_A36666.Value == 134)
									{
										num = (short)1527906312;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									break;
								}
								case 4:
									goto IL_16FC;
								case 5:
								{
									global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO9.ConsolidatedActionBCOListInner consolidatedActionBCOListInner2;
									task.AddTask(new global::AcpBusinessLayer.UndoRedo.ModifyRecRefDataTask(consolidatedActionBCOListInner2.ConsolidatedActionBCOListInnerSection.RadErgoControlO9ACBCOListIndex_A36668, acpRecRefField.UIValue));
									num = (short)597360644;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 6:
								{
									if (!enumerator.MoveNext())
									{
										num = (short)1453719564;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO9.ConsolidatedActionBCOListInner consolidatedActionBCOListInner2 = (global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO9.ConsolidatedActionBCOListInner)enumerator.Current;
									num = (short)304939011;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 7:
									num = (short)301072395;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 8:
									num = (short)1043202061;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 9:
									if (acpRecRefField != null)
									{
										num = (short)997326855;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									goto IL_189A;
								case 10:
								{
									global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO9.ConsolidatedActionBCOListInner consolidatedActionBCOListInner2;
									task.AddTask(new global::AcpBusinessLayer.UndoRedo.DeleteRecordTask(consolidatedActionBCOListInner2));
									num = (short)905248768;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 11:
								{
									global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO9.ConsolidatedActionBCOListInner consolidatedActionBCOListInner2;
									if (acpRecRefField.Value != consolidatedActionBCOListInner2.ConsolidatedActionBCOListInnerSection.RadErgoControlO9ACBCOListIndex_A36668.Value)
									{
										num = (short)14811141;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									goto IL_189A;
								}
								case 12:
									goto IL_189A;
								case 13:
									if (num3 != 227)
									{
										num = (short)499712010;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									flag2 = true;
									num = (short)1211498505;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								IL_17DE:
								num = (short)159121414;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								IL_16C5:
								goto IL_17DE;
								IL_189A:
								num = (short)694484994;
								num2 = (int)((global::System.IntPtr)num);
							}
							IL_16FC:
							IL_1787:
							IL_18B4:
							goto IL_AC5;
						}
						finally
						{
							num = (short)1826095104;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								switch (num2)
								{
								case 0:
									switch (0)
									{
									case 0:
										goto IL_18EC;
									}
									continue;
								case 1:
									enumerator.Dispose();
									num = (short)1187643394;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 2:
									goto IL_1925;
								}
								IL_18EC:
								if (enumerator == null)
								{
									break;
								}
								num = (short)276627457;
								num2 = (int)((global::System.IntPtr)num);
							}
							IL_1925:;
						}
						goto Block_30;
					case 81:
						goto IL_162A;
					case 82:
						num = (short)1826816014;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 83:
						o7DataButtonInnerRecset = (controlHeadO7Recset[0][10717].EmbeddedRecset as global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO7.O7DataButtonInnerRecset);
						num = (short)417267778;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 84:
						try
						{
							num = (short)1810890754;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								switch (num2)
								{
								case 0:
								{
									global::AcpCommonLib.IAcpFeatureNode acpFeatureNode7;
									task.AddTask(new global::AcpBusinessLayer.UndoRedo.ModifyDataTask<int>((acpFeatureNode7[10713] as global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO7.O7DataButtonInnerSection).RadErgCtrlHeadO7DataButtonCnvFeature_A41299, num3));
									num = (short)152109061;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 1:
									num = (short)1850540038;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 2:
									switch (0)
									{
									case 0:
										goto IL_D53;
									}
									continue;
								case 3:
								{
									if (!enumerator.MoveNext())
									{
										num = (short)1324482561;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									global::AcpCommonLib.IAcpFeatureNode acpFeatureNode7 = enumerator.Current;
									num = (short)947519492;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 4:
								{
									global::AcpCommonLib.IAcpFeatureNode acpFeatureNode7;
									if (num3 != (acpFeatureNode7[10713] as global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO7.O7DataButtonInnerSection).RadErgCtrlHeadO7DataButtonCnvFeature_A41299.Value)
									{
										num = (short)1457651712;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									break;
								}
								case 5:
									goto IL_D8C;
								case 6:
									goto IL_E3E;
								}
								IL_D91:
								num = (short)2142175235;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								IL_D53:
								goto IL_D91;
							}
							IL_D8C:
							IL_E3E:
							goto IL_1C10;
						}
						finally
						{
							num = (short)1447297025;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								switch (num2)
								{
								case 0:
									enumerator.Dispose();
									num = (short)585564162;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 1:
									switch (0)
									{
									case 0:
										goto IL_E75;
									}
									continue;
								case 2:
									goto IL_EAD;
								}
								IL_E75:
								if (enumerator == null)
								{
									break;
								}
								num = (short)389021696;
								num2 = (int)((global::System.IntPtr)num);
							}
							IL_EAD:;
						}
						goto IL_EB0;
					case 85:
					{
						if (featureSectionId != 10090)
						{
							num = (short)1329725502;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						global::Motorola.MackinawCPS.CoreFeatures.Buttons.DataButtonInnerSection dataButtonInnerSection2 = self as global::Motorola.MackinawCPS.CoreFeatures.Buttons.DataButtonInnerSection;
						num3 = dataButtonInnerSection2.BtnConventionalButtonDatatButtonFeature_A22610.Value;
						acpListField = dataButtonInnerSection2.BtnTrunkingButtonDatatButtonFeature_A22608;
						num = (short)336134187;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 86:
						if (o7DataButtonInnerRecset != null)
						{
							num = (short)801570831;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_1BD3;
					case 87:
						goto IL_1584;
					case 88:
						if (buttonsRecset != null)
						{
							num = (short)1761411122;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_3EC;
					case 89:
						try
						{
							num = (short)1010958338;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								switch (num2)
								{
								case 0:
									num = (short)210370566;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 1:
									goto IL_FE7;
								case 2:
									switch (0)
									{
									case 0:
										goto IL_F53;
									}
									continue;
								case 3:
								{
									global::AcpCommonLib.IAcpFeatureNode acpFeatureNode8;
									task.AddTask(new global::AcpBusinessLayer.UndoRedo.ModifyDataTask<int>((acpFeatureNode8[10212] as global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO3.DataButtonInnerSection).CntrlHeadO3TrunkingO3DatatButtonFeature_A22597, num3));
									num = (short)1944059905;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 4:
								{
									if (!enumerator.MoveNext())
									{
										num = (short)1536753664;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									global::AcpCommonLib.IAcpFeatureNode acpFeatureNode8 = enumerator.Current;
									num = (short)1423048709;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 5:
								{
									global::AcpCommonLib.IAcpFeatureNode acpFeatureNode8;
									if (num3 != (acpFeatureNode8[10212] as global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO3.DataButtonInnerSection).CntrlHeadO3TrunkingO3DatatButtonFeature_A22597.Value)
									{
										num = (short)495517699;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									break;
								}
								case 6:
									goto IL_1045;
								}
								IL_FEC:
								num = (short)1368391684;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								IL_F53:
								goto IL_FEC;
							}
							IL_FE7:
							IL_1045:
							goto IL_353;
						}
						finally
						{
							num = (short)166330369;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								switch (num2)
								{
								case 0:
									enumerator.Dispose();
									num = (short)2100690946;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 1:
									switch (0)
									{
									case 0:
										goto IL_107C;
									}
									continue;
								case 2:
									goto IL_10B3;
								}
								IL_107C:
								if (enumerator == null)
								{
									break;
								}
								num = (short)1561067520;
								num2 = (int)((global::System.IntPtr)num);
							}
							IL_10B3:;
						}
						goto IL_10B6;
					case 90:
						goto IL_162A;
					}
					goto IL_19B;
					IL_22D:
					consolidatedActionBCOListInnerRecset = null;
					flag2 = false;
					num = (short)25296912;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_353:
					num = (short)391643222;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_3EC:
					controlHeadO3Recset = null;
					dataButtonInnerRecset2 = null;
					controlHeadO3Recset = (global::AcpCommonLib.FeatureManager.GetFeature(2127) as global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO3.ControlHeadO3Recset);
					num = (short)76808218;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_610:
					enumerator = dataButtonInnerRecset2.GetEnumerator();
					num = (short)245301270;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_6D0:
					flag = false;
					num = (short)1924989009;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_AC5:
					num = (short)1623326744;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					Block_12:
					try
					{
						IL_8CB:
						num = (short)2062483458;
						num2 = (int)((global::System.IntPtr)num);
						for (;;)
						{
							global::AcpCommonLib.IAcpFeatureNode acpFeatureNode9;
							switch (num2)
							{
							case 0:
								num = (short)1479213062;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							case 1:
							{
								num = (short)726554002;
								short num4 = num;
								num = (short)713577874;
								switch ((num4 == num) ? 1 : 0)
								{
								case 0:
								case 2:
									goto IL_99F;
								default:
									num = (short)1395261440;
									if (num != 0)
									{
									}
									task.AddTask(new global::AcpBusinessLayer.UndoRedo.ModifyDataTask<int>((acpFeatureNode9[10209] as global::Motorola.MackinawCPS.CoreFeatures.KeypadMicAndAccessories.DataButtonInnerSection).RadErgoCfgKMConventionalKMDatatButtonFeature_A22603, num3));
									num = (short)339607557;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								break;
							}
							case 2:
								switch (0)
								{
								case 0:
									goto IL_90D;
								}
								continue;
							case 3:
								if (num3 != (acpFeatureNode9[10209] as global::Motorola.MackinawCPS.CoreFeatures.KeypadMicAndAccessories.DataButtonInnerSection).RadErgoCfgKMConventionalKMDatatButtonFeature_A22603.Value)
								{
									num = (short)422248449;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								break;
							case 4:
								if (!enumerator.MoveNext())
								{
									num = (short)64159744;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								goto IL_99F;
							case 5:
								goto IL_99A;
							case 6:
								goto IL_A52;
							}
							goto IL_90D;
							IL_99F:
							acpFeatureNode9 = enumerator.Current;
							num = (short)38928387;
							num2 = (int)((global::System.IntPtr)num);
							continue;
							IL_9FB:
							num = (short)290586628;
							num2 = (int)((global::System.IntPtr)num);
							continue;
							IL_90D:
							goto IL_9FB;
						}
						IL_99A:
						IL_A52:
						goto IL_2202;
					}
					finally
					{
						num = (short)697958401;
						num2 = (int)((global::System.IntPtr)num);
						for (;;)
						{
							switch (num2)
							{
							case 0:
								enumerator.Dispose();
								num = (short)739049474;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							case 1:
								switch (0)
								{
								case 0:
									goto IL_A8A;
								}
								continue;
							case 2:
								goto IL_AC2;
							}
							IL_A8A:
							if (enumerator == null)
							{
								break;
							}
							num = (short)1886978048;
							num2 = (int)((global::System.IntPtr)num);
						}
						IL_AC2:;
					}
					goto IL_AC5;
					IL_B07:
					num = (short)1693253663;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_B6B:
					buttonsRecset = null;
					dataButtonInnerRecset3 = null;
					buttonsRecset = (global::AcpCommonLib.FeatureManager.GetFeature(2042) as global::Motorola.MackinawCPS.CoreFeatures.Buttons.ButtonsRecset);
					num = (short)399573080;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_BC0:
					num = (short)1083506742;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_C75:
					controlHeadO7Recset = null;
					o7DataButtonInnerRecset = null;
					controlHeadO7Recset = (global::AcpCommonLib.FeatureManager.GetFeature(4114) as global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO7.ControlHeadO7Recset);
					num = (short)1130430509;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_EB0:
					num = (short)675020840;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_10B6:
					global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO9.O9DataButtonInnerSection o9DataButtonInnerSection = self as global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO9.O9DataButtonInnerSection;
					num3 = o9DataButtonInnerSection.RadErgCtrlHeadO9DataButtonCnvFeature_A36528.Value;
					acpRecRefField = o9DataButtonInnerSection.CHO9DataButtonConvIndex_A41414;
					acpListField = o9DataButtonInnerSection.RadErgCtrlHeadO9DataButtonTrkFeature_A36526;
					num = (short)316473348;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_12D8:
					controlHeadO9Recset = null;
					o9DataButtonInnerRecset = null;
					controlHeadO9Recset = (global::AcpCommonLib.FeatureManager.GetFeature(4003) as global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO9.ControlHeadO9Recset);
					num = (short)1290403851;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_1584:
					num = (short)451608605;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_15C6:
					num = (short)1291321393;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_162A:
					num = (short)2046820353;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_1ACA:
					num = (short)337182753;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					Block_30:
					try
					{
						IL_1928:
						num = (short)241565697;
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
									num = (short)1938554884;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								break;
							}
							case 1:
								switch (0)
								{
								case 0:
									goto IL_196B;
								}
								continue;
							case 2:
							{
								if (!enumerator.MoveNext())
								{
									num = (short)1613168645;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								global::AcpCommonLib.IAcpFeatureNode acpFeatureNode10 = enumerator.Current;
								num = (short)1000275968;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							case 3:
								goto IL_1A58;
							case 4:
							{
								global::AcpCommonLib.IAcpFeatureNode acpFeatureNode10;
								task.AddTask(new global::AcpBusinessLayer.UndoRedo.ModifyDataTask<int>((acpFeatureNode10[10212] as global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO3.DataButtonInnerSection).CntrlHeadO3ConventionalO3DatatButtonFeature_A22595, num3));
								num = (short)1447624710;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							case 5:
								num = (short)1971847171;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							case 6:
								goto IL_1A39;
							}
							IL_19C2:
							num = (short)271515650;
							num2 = (int)((global::System.IntPtr)num);
							continue;
							IL_196B:
							goto IL_19C2;
						}
						IL_1A39:
						IL_1A58:
						goto IL_1C4E;
					}
					finally
					{
						num = (short)1239416832;
						num2 = (int)((global::System.IntPtr)num);
						for (;;)
						{
							switch (num2)
							{
							case 0:
								switch (0)
								{
								case 0:
									goto IL_1A8F;
								}
								continue;
							case 1:
								enumerator.Dispose();
								num = (short)674955266;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							case 2:
								goto IL_1AC7;
							}
							IL_1A8F:
							if (enumerator == null)
							{
								break;
							}
							num = (short)236388353;
							num2 = (int)((global::System.IntPtr)num);
						}
						IL_1AC7:;
					}
					goto IL_1ACA;
					IL_1B4A:
					num = (short)875954222;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_1BD3:
					num = (short)89980991;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_1C10:
					num = (short)1007943688;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_1C4E:
					num = (short)1081606216;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_1EB0:
					global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO3.DataButtonInnerSection dataButtonInnerSection3 = self as global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO3.DataButtonInnerSection;
					num3 = dataButtonInnerSection3.CntrlHeadO3ConventionalO3DatatButtonFeature_A22595.Value;
					acpRecRefField = dataButtonInnerSection3.CHO3DataButtonConvIndex_A41419;
					acpListField = dataButtonInnerSection3.CntrlHeadO3TrunkingO3DatatButtonFeature_A22597;
					num = (short)438173786;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_217A:
					num = (short)370475018;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_2202:
					num = (short)1497301010;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_223F:
					radioWide = ((global::AcpCommonLib.FeatureManager.GetFeature(2045) as global::Motorola.MackinawCPS.CoreFeatures.RadioWide.RadioWideRecset)[0] as global::Motorola.MackinawCPS.CoreFeatures.RadioWide.RadioWide);
					num = (short)830668869;
					num2 = (int)((global::System.IntPtr)num);
				}
				return;
				IL_15C1:
				return;
				IL_2304:
				num = (short)1128005632;
				short num5 = num;
				return;
				IL_19B:
				num3 = 0;
				flag = true;
				acpRecRefField = null;
				acpListField = null;
				featureSectionId = self.FeatureSectionId;
				num = (short)1297219586;
				num2 = (int)((global::System.IntPtr)num);
				goto IL_28;
			}
			}
		}

		// Token: 0x06008692 RID: 34450 RVA: 0x007CD3D0 File Offset: 0x007CB5D0
		public static void ConSyncTrkDataBtnFeature(global::AcpCommonLib.IAcpFeatureSection self, global::AcpCommonLib.UndoRedo.ContainerTask task)
		{
			short num = (short)572719104;
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
				bool flag;
				int featureSectionId;
				int num3;
				global::AcpBusinessLayer.AcpRecRefField acpRecRefField;
				for (;;)
				{
					IL_27:
					global::Motorola.MackinawCPS.CoreFeatures.KeypadMicAndAccessories.DataButtonInnerRecset dataButtonInnerRecset;
					global::System.Collections.Generic.IEnumerator<global::AcpBusinessLayer.FeatureNode> enumerator;
					global::Motorola.MackinawCPS.CoreFeatures.Buttons.DataButtonInnerRecset dataButtonInnerRecset2;
					global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO7.ControlHeadO7Recset controlHeadO7Recset;
					global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO7.O7DataButtonInnerRecset o7DataButtonInnerRecset;
					global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO9.ControlHeadO9Recset controlHeadO9Recset;
					global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO9.O9DataButtonInnerRecset o9DataButtonInnerRecset;
					global::Motorola.MackinawCPS.CoreFeatures.Buttons.ButtonsRecset buttonsRecset;
					global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO9.ConsolidatedActionBCOListInnerRecset consolidatedActionBCOListInnerRecset;
					global::Motorola.MackinawCPS.CoreFeatures.RadioWide.RadioWide radioWide;
					global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO3.DataButtonInnerRecset dataButtonInnerRecset3;
					bool flag2;
					global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO3.ControlHeadO3Recset controlHeadO3Recset;
					switch (num2)
					{
					case 0:
					{
						if (!flag)
						{
							num = (short)1233125394;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						global::Motorola.MackinawCPS.CoreFeatures.KeypadMicAndAccessories.KeypadMicAndAccessoriesRecset keypadMicAndAccessoriesRecset = null;
						dataButtonInnerRecset = null;
						keypadMicAndAccessoriesRecset = (global::AcpCommonLib.FeatureManager.GetFeature(2128) as global::Motorola.MackinawCPS.CoreFeatures.KeypadMicAndAccessories.KeypadMicAndAccessoriesRecset);
						num = (short)1171456019;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 1:
						enumerator = dataButtonInnerRecset.GetEnumerator();
						num = (short)1383989302;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 2:
					{
						if (featureSectionId != 10209)
						{
							num = (short)699662383;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						global::Motorola.MackinawCPS.CoreFeatures.KeypadMicAndAccessories.DataButtonInnerSection dataButtonInnerSection = self as global::Motorola.MackinawCPS.CoreFeatures.KeypadMicAndAccessories.DataButtonInnerSection;
						num3 = dataButtonInnerSection.RadErgoCfgKMTrunkingKMDatatButtonFeature_A22605.Value;
						acpRecRefField = dataButtonInnerSection.RadErgoCfgKMTrunkingKMDatatButtonIndex_A41424;
						num = (short)1010565181;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 3:
						try
						{
							num = (short)1977745413;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								switch (num2)
								{
								case 0:
									goto IL_1B2A;
								case 1:
								{
									if (!enumerator.MoveNext())
									{
										num = (short)1551761411;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									global::AcpCommonLib.IAcpFeatureNode acpFeatureNode = enumerator.Current;
									num = (short)79429634;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 2:
								{
									global::AcpCommonLib.IAcpFeatureNode acpFeatureNode;
									if (num3 != (acpFeatureNode[10713] as global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO7.O7DataButtonInnerSection).RadErgCtrlHeadO7DataButtonTrkFeature_A41297.Value)
									{
										num = (short)1421803526;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									break;
								}
								case 3:
									num = (short)1015218176;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 4:
									goto IL_1A72;
								case 5:
									switch (0)
									{
									case 0:
										goto IL_1A36;
									}
									continue;
								case 6:
								{
									global::AcpCommonLib.IAcpFeatureNode acpFeatureNode;
									task.AddTask(new global::AcpBusinessLayer.UndoRedo.ModifyDataTask<int>((acpFeatureNode[10713] as global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO7.O7DataButtonInnerSection).RadErgCtrlHeadO7DataButtonTrkFeature_A41297, num3));
									num = (short)736755716;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								}
								IL_1AD4:
								num = (short)1895432193;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								IL_1A36:
								goto IL_1AD4;
							}
							IL_1A72:
							IL_1B2A:
							goto IL_D86;
						}
						finally
						{
							num = (short)1705836544;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								switch (num2)
								{
								case 0:
									switch (0)
									{
									case 0:
										goto IL_1B62;
									}
									continue;
								case 1:
									enumerator.Dispose();
									num = (short)1736245250;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 2:
									goto IL_1B9B;
								}
								IL_1B62:
								if (enumerator == null)
								{
									break;
								}
								num = (short)1927741441;
								num2 = (int)((global::System.IntPtr)num);
							}
							IL_1B9B:;
						}
						goto IL_1B9E;
					case 4:
						enumerator = dataButtonInnerRecset2.GetEnumerator();
						num = (short)1916076083;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 5:
						o7DataButtonInnerRecset = (controlHeadO7Recset[0][10717].EmbeddedRecset as global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO7.O7DataButtonInnerRecset);
						goto IL_D67;
					case 6:
						try
						{
							num = (short)92602368;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								switch (num2)
								{
								case 0:
									switch (0)
									{
									case 0:
										goto IL_1D15;
									}
									continue;
								case 1:
								{
									if (!enumerator.MoveNext())
									{
										num = (short)1683357700;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									global::AcpCommonLib.IAcpFeatureNode acpFeatureNode2 = enumerator.Current;
									num = (short)676528130;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 2:
								{
									global::AcpCommonLib.IAcpFeatureNode acpFeatureNode2;
									if (num3 != (acpFeatureNode2[10608] as global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO9.O9DataButtonInnerSection).RadErgCtrlHeadO9DataButtonTrkFeature_A36526.Value)
									{
										num = (short)263782405;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									break;
								}
								case 3:
									goto IL_1DFE;
								case 4:
									num = (short)243073027;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 5:
								{
									global::AcpCommonLib.IAcpFeatureNode acpFeatureNode2;
									task.AddTask(new global::AcpBusinessLayer.UndoRedo.ModifyDataTask<int>((acpFeatureNode2[10608] as global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO9.O9DataButtonInnerSection).RadErgCtrlHeadO9DataButtonTrkFeature_A36526, num3));
									num = (short)1699545094;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 6:
									goto IL_1DE0;
								}
								IL_1D17:
								num = (short)1989476353;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								IL_1D15:
								goto IL_1D17;
							}
							IL_1DE0:
							IL_1DFE:
							goto IL_186E;
						}
						finally
						{
							num = (short)645136384;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								switch (num2)
								{
								case 0:
									switch (0)
									{
									case 0:
										goto IL_1E37;
									}
									continue;
								case 1:
									enumerator.Dispose();
									num = (short)1004797954;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 2:
									goto IL_1E70;
								}
								IL_1E37:
								if (enumerator == null)
								{
									break;
								}
								num = (short)1351221249;
								num2 = (int)((global::System.IntPtr)num);
							}
							IL_1E70:;
						}
						goto IL_1E73;
					case 7:
						o9DataButtonInnerRecset = (controlHeadO9Recset[0][10611].EmbeddedRecset as global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO9.O9DataButtonInnerRecset);
						num = (short)988348497;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 8:
						goto IL_CF8;
					case 9:
						if (buttonsRecset != null)
						{
							num = (short)146997324;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_410;
					case 10:
						if (featureSectionId != 10090)
						{
							num = (short)1167654926;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num3 = (self as global::Motorola.MackinawCPS.CoreFeatures.Buttons.DataButtonInnerSection).BtnTrunkingButtonDatatButtonFeature_A22608.Value;
						num = (short)667353150;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 11:
					{
						task.AddTask(new global::AcpBusinessLayer.UndoRedo.AddRecordTask(consolidatedActionBCOListInnerRecset.CreateDefaultRecord()));
						int index = consolidatedActionBCOListInnerRecset.Count - 1;
						global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO9.ConsolidatedActionBCOListInner consolidatedActionBCOListInner = consolidatedActionBCOListInnerRecset[index] as global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO9.ConsolidatedActionBCOListInner;
						task.AddTask(new global::AcpBusinessLayer.UndoRedo.ModifyDataTask<int>(consolidatedActionBCOListInner.ConsolidatedActionBCOListInnerSection.RadErgoControlO9ACBCOListBco_A36666, 134));
						task.AddTask(new global::AcpBusinessLayer.UndoRedo.ModifyRecRefDataTask(consolidatedActionBCOListInner.ConsolidatedActionBCOListInnerSection.RadErgoControlO9ACBCOListIndex_A36668, acpRecRefField.UIValue));
						num = (short)880738383;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 12:
						num = (short)2092826696;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 13:
						if (o9DataButtonInnerRecset != null)
						{
							num = (short)31588384;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_186E;
					case 14:
						num = (short)511836162;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 15:
						goto IL_636;
					case 16:
						goto IL_89F;
					case 17:
						try
						{
							num = (short)1718222850;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								switch (num2)
								{
								case 0:
								{
									if (!enumerator.MoveNext())
									{
										num = (short)45416453;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									global::AcpCommonLib.IAcpFeatureNode acpFeatureNode3 = enumerator.Current;
									num = (short)1636302854;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 1:
									goto IL_10DB;
								case 2:
									switch (0)
									{
									case 0:
										goto IL_10A1;
									}
									continue;
								case 3:
									goto IL_1191;
								case 4:
								{
									global::AcpCommonLib.IAcpFeatureNode acpFeatureNode3;
									task.AddTask(new global::AcpBusinessLayer.UndoRedo.ModifyDataTask<int>((acpFeatureNode3[10713] as global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO7.O7DataButtonInnerSection).RadErgCtrlHeadO7DataButtonCnvFeature_A41299, num3));
									num = (short)771620865;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 5:
									num = (short)1730019331;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 6:
								{
									global::AcpCommonLib.IAcpFeatureNode acpFeatureNode3;
									if (num3 != (acpFeatureNode3[10713] as global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO7.O7DataButtonInnerSection).RadErgCtrlHeadO7DataButtonCnvFeature_A41299.Value)
									{
										num = (short)917508;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									break;
								}
								}
								IL_10E0:
								num = (short)1912668160;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								IL_10A1:
								goto IL_10E0;
							}
							IL_10DB:
							IL_1191:
							goto IL_1BDC;
						}
						finally
						{
							num = (short)1171259393;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								switch (num2)
								{
								case 0:
									goto IL_1202;
								case 1:
									switch (0)
									{
									case 0:
										goto IL_11C9;
									}
									continue;
								case 2:
									enumerator.Dispose();
									num = (short)1178140672;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								IL_11C9:
								if (enumerator == null)
								{
									break;
								}
								num = (short)2144993282;
								num2 = (int)((global::System.IntPtr)num);
							}
							IL_1202:;
						}
						goto IL_1205;
					case 18:
						return;
					case 19:
					{
						global::Motorola.MackinawCPS.CoreFeatures.KeypadMicAndAccessories.KeypadMicAndAccessoriesRecset keypadMicAndAccessoriesRecset;
						if (keypadMicAndAccessoriesRecset != null)
						{
							num = (short)62062667;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_AB0;
					}
					case 20:
						goto IL_69F;
					case 21:
						if (num3 == 227)
						{
							num = (short)2132017174;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_21B5;
					case 22:
						num = (short)1857355828;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 23:
					{
						if (featureSectionId != 10713)
						{
							num = (short)890437717;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO7.O7DataButtonInnerSection o7DataButtonInnerSection = self as global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO7.O7DataButtonInnerSection;
						num3 = o7DataButtonInnerSection.RadErgCtrlHeadO7DataButtonTrkFeature_A41297.Value;
						acpRecRefField = o7DataButtonInnerSection.CHO7DataButtonTrkIndex_A41418;
						num = (short)410714175;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 24:
						if (radioWide.DualRadio.RadWideDualRadioSelection_A42236 == 0)
						{
							num = (short)1211498544;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_E07;
					case 25:
						if (num3 == 228)
						{
							num = (short)1131544654;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return;
					case 26:
						if (num3 != 140)
						{
							num = (short)1172045881;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_E07;
					case 27:
						goto IL_410;
					case 28:
						goto IL_AB0;
					case 29:
						if (featureSectionId != 10212)
						{
							num = (short)11206730;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_1E73;
					case 30:
						if (controlHeadO7Recset != null)
						{
							num = (short)1654652933;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_CA4;
					case 31:
						try
						{
							num = (short)11796482;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								switch (num2)
								{
								case 0:
								{
									if (!enumerator.MoveNext())
									{
										num = (short)1455489029;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									global::AcpCommonLib.IAcpFeatureNode acpFeatureNode4 = enumerator.Current;
									num = (short)1006239750;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 1:
									goto IL_EBF;
								case 2:
									switch (0)
									{
									case 0:
										goto IL_E86;
									}
									continue;
								case 3:
									goto IL_F73;
								case 4:
								{
									global::AcpCommonLib.IAcpFeatureNode acpFeatureNode4;
									task.AddTask(new global::AcpBusinessLayer.UndoRedo.ModifyDataTask<int>((acpFeatureNode4[10212] as global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO3.DataButtonInnerSection).CntrlHeadO3ConventionalO3DatatButtonFeature_A22595, num3));
									num = (short)1124270081;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 5:
									num = (short)867827715;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 6:
								{
									global::AcpCommonLib.IAcpFeatureNode acpFeatureNode4;
									if (num3 != (acpFeatureNode4[10212] as global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO3.DataButtonInnerSection).CntrlHeadO3ConventionalO3DatatButtonFeature_A22595.Value)
									{
										num = (short)1754267652;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									break;
								}
								}
								IL_EC4:
								num = (short)1798504448;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								IL_E86:
								goto IL_EC4;
							}
							IL_EBF:
							IL_F73:
							goto IL_1630;
						}
						finally
						{
							num = (short)390004736;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								switch (num2)
								{
								case 0:
									switch (0)
									{
									case 0:
										goto IL_FAA;
									}
									continue;
								case 1:
									goto IL_FE3;
								case 2:
									enumerator.Dispose();
									num = (short)1672740865;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								IL_FAA:
								if (enumerator == null)
								{
									break;
								}
								num = (short)12976130;
								num2 = (int)((global::System.IntPtr)num);
							}
							IL_FE3:;
						}
						goto IL_FE6;
					case 32:
						goto IL_20ED;
					case 33:
						if (dataButtonInnerRecset != null)
						{
							num = (short)682426369;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_15F5;
					case 34:
						if (o9DataButtonInnerRecset != null)
						{
							num = (short)295305281;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return;
					case 35:
						if (o7DataButtonInnerRecset != null)
						{
							num = (short)2076966981;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_1BDC;
					case 36:
						if (num3 != 227)
						{
							num = (short)290193449;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_E07;
					case 37:
						goto IL_166D;
					case 38:
						num = (short)402456577;
						if (num != 0)
						{
						}
						enumerator = consolidatedActionBCOListInnerRecset.GetEnumerator();
						num = (short)1222967362;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 39:
						num = (short)1549991959;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 40:
						if (o7DataButtonInnerRecset != null)
						{
							num = (short)270729283;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_D86;
					case 41:
						num = (short)1998192666;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 42:
						if (dataButtonInnerRecset2 != null)
						{
							num = (short)356450349;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_2179;
					case 43:
						try
						{
							num = (short)586874885;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								switch (num2)
								{
								case 0:
									goto IL_17FD;
								case 1:
									num = (short)1261633536;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 2:
								{
									global::AcpCommonLib.IAcpFeatureNode acpFeatureNode5;
									task.AddTask(new global::AcpBusinessLayer.UndoRedo.ModifyDataTask<int>((acpFeatureNode5[10212] as global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO3.DataButtonInnerSection).CntrlHeadO3TrunkingO3DatatButtonFeature_A22597, num3));
									num = (short)962723843;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 3:
									goto IL_17DE;
								case 4:
								{
									global::AcpCommonLib.IAcpFeatureNode acpFeatureNode5;
									if (num3 != (acpFeatureNode5[10212] as global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO3.DataButtonInnerSection).CntrlHeadO3TrunkingO3DatatButtonFeature_A22597.Value)
									{
										num = (short)149094402;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									break;
								}
								case 5:
									switch (0)
									{
									case 0:
										goto IL_1712;
									}
									continue;
								case 6:
								{
									if (!enumerator.MoveNext())
									{
										num = (short)350552065;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									global::AcpCommonLib.IAcpFeatureNode acpFeatureNode5 = enumerator.Current;
									num = (short)613351428;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								}
								IL_1769:
								num = (short)1136132102;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								IL_1712:
								goto IL_1769;
							}
							IL_17DE:
							IL_17FD:
							goto IL_19B5;
						}
						finally
						{
							num = (short)944046081;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								switch (num2)
								{
								case 0:
									goto IL_186B;
								case 1:
									switch (0)
									{
									case 0:
										goto IL_1834;
									}
									continue;
								case 2:
									enumerator.Dispose();
									num = (short)529137664;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								IL_1834:
								if (enumerator == null)
								{
									break;
								}
								num = (short)882311170;
								num2 = (int)((global::System.IntPtr)num);
							}
							IL_186B:;
						}
						goto IL_186E;
					case 44:
						goto IL_166D;
					case 45:
						goto IL_15CC;
					case 46:
						enumerator = dataButtonInnerRecset3.GetEnumerator();
						num = (short)1554186271;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 47:
						num = (short)1087766578;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 48:
						goto IL_192E;
					case 49:
						goto IL_A4B;
					case 50:
						goto IL_69F;
					case 51:
						try
						{
							num = (short)1600585730;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								switch (num2)
								{
								case 0:
								{
									global::AcpCommonLib.IAcpFeatureNode acpFeatureNode6;
									task.AddTask(new global::AcpBusinessLayer.UndoRedo.ModifyDataTask<int>((acpFeatureNode6[10090] as global::Motorola.MackinawCPS.CoreFeatures.Buttons.DataButtonInnerSection).BtnConventionalButtonDatatButtonFeature_A22610, num3));
									num = (short)653852677;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 1:
								{
									global::AcpCommonLib.IAcpFeatureNode acpFeatureNode6;
									if (num3 != (acpFeatureNode6[10090] as global::Motorola.MackinawCPS.CoreFeatures.Buttons.DataButtonInnerSection).BtnConventionalButtonDatatButtonFeature_A22610.Value)
									{
										num = (short)1188757504;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									break;
								}
								case 2:
									switch (0)
									{
									case 0:
										goto IL_73C;
									}
									continue;
								case 3:
									goto IL_82D;
								case 4:
									num = (short)345505795;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 5:
									goto IL_7D1;
								case 6:
								{
									if (!enumerator.MoveNext())
									{
										num = (short)1664942084;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									global::AcpCommonLib.IAcpFeatureNode acpFeatureNode6 = enumerator.Current;
									num = (short)1098973185;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								}
								IL_7D6:
								num = (short)1345650694;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								IL_73C:
								goto IL_7D6;
							}
							IL_7D1:
							IL_82D:
							goto IL_1C95;
						}
						finally
						{
							num = (short)374931456;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								switch (num2)
								{
								case 0:
									switch (0)
									{
									case 0:
										goto IL_865;
									}
									continue;
								case 1:
									goto IL_89C;
								case 2:
									enumerator.Dispose();
									num = (short)2013986817;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								IL_865:
								if (enumerator == null)
								{
									break;
								}
								num = (short)2088566786;
								num2 = (int)((global::System.IntPtr)num);
							}
							IL_89C:;
						}
						goto Block_8;
					case 52:
						if (!flag2)
						{
							num = (short)1072431115;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_21B5;
					case 53:
						try
						{
							num = (short)902561792;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								switch (num2)
								{
								case 0:
									switch (0)
									{
									case 0:
										goto IL_1F8F;
									}
									continue;
								case 1:
								{
									if (!enumerator.MoveNext())
									{
										num = (short)1183383556;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									global::AcpCommonLib.IAcpFeatureNode acpFeatureNode7 = enumerator.Current;
									num = (short)1765212162;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 2:
								{
									global::AcpCommonLib.IAcpFeatureNode acpFeatureNode7;
									if (num3 != (acpFeatureNode7[10090] as global::Motorola.MackinawCPS.CoreFeatures.Buttons.DataButtonInnerSection).BtnTrunkingButtonDatatButtonFeature_A22608.Value)
									{
										num = (short)1287454725;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									break;
								}
								case 3:
									goto IL_207A;
								case 4:
									num = (short)1201143811;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 5:
								{
									global::AcpCommonLib.IAcpFeatureNode acpFeatureNode7;
									task.AddTask(new global::AcpBusinessLayer.UndoRedo.ModifyDataTask<int>((acpFeatureNode7[10090] as global::Motorola.MackinawCPS.CoreFeatures.Buttons.DataButtonInnerSection).BtnTrunkingButtonDatatButtonFeature_A22608, num3));
									num = (short)1595277318;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 6:
									goto IL_205C;
								}
								IL_1F91:
								num = (short)875626497;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								IL_1F8F:
								goto IL_1F91;
							}
							IL_205C:
							IL_207A:
							goto IL_2179;
						}
						finally
						{
							num = (short)2112618496;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								switch (num2)
								{
								case 0:
									switch (0)
									{
									case 0:
										goto IL_20B2;
									}
									continue;
								case 1:
									enumerator.Dispose();
									num = (short)1791295490;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 2:
									goto IL_20EA;
								}
								IL_20B2:
								if (enumerator == null)
								{
									break;
								}
								num = (short)698089473;
								num2 = (int)((global::System.IntPtr)num);
							}
							IL_20EA:;
						}
						goto IL_20ED;
					case 54:
						try
						{
							num = (short)1603993602;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								switch (num2)
								{
								case 0:
								{
									global::AcpCommonLib.IAcpFeatureNode acpFeatureNode8;
									task.AddTask(new global::AcpBusinessLayer.UndoRedo.ModifyDataTask<int>((acpFeatureNode8[10209] as global::Motorola.MackinawCPS.CoreFeatures.KeypadMicAndAccessories.DataButtonInnerSection).RadErgoCfgKMConventionalKMDatatButtonFeature_A22603, num3));
									num = (short)483328004;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 1:
								{
									global::AcpCommonLib.IAcpFeatureNode acpFeatureNode8;
									if (num3 != (acpFeatureNode8[10209] as global::Motorola.MackinawCPS.CoreFeatures.KeypadMicAndAccessories.DataButtonInnerSection).RadErgoCfgKMConventionalKMDatatButtonFeature_A22603.Value)
									{
										num = (short)1051721728;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									break;
								}
								case 2:
									switch (0)
									{
									case 0:
										goto IL_B47;
									}
									continue;
								case 3:
									goto IL_C32;
								case 4:
									goto IL_C14;
								case 5:
								{
									if (!enumerator.MoveNext())
									{
										num = (short)66650118;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									global::AcpCommonLib.IAcpFeatureNode acpFeatureNode8 = enumerator.Current;
									num = (short)783024129;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 6:
									num = (short)1432485891;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								IL_B9D:
								num = (short)1079508997;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								IL_B47:
								goto IL_B9D;
							}
							IL_C14:
							IL_C32:
							goto IL_15F5;
						}
						finally
						{
							num = (short)876937216;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								switch (num2)
								{
								case 0:
									switch (0)
									{
									case 0:
										goto IL_C69;
									}
									continue;
								case 1:
									goto IL_CA1;
								case 2:
									enumerator.Dispose();
									num = (short)139395073;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								IL_C69:
								if (enumerator == null)
								{
									break;
								}
								num = (short)1796276226;
								num2 = (int)((global::System.IntPtr)num);
							}
							IL_CA1:;
						}
						goto IL_CA4;
					case 55:
					{
						num = (short)9099871;
						short num4 = num;
						num = (short)1913182815;
						switch ((num4 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_D67;
						default:
							num = (short)280100864;
							if (num != 0)
							{
							}
							num = (short)1575944202;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						break;
					}
					case 56:
						if (consolidatedActionBCOListInnerRecset != null)
						{
							num = (short)208601126;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_21B5;
					case 57:
						num = (short)1531052057;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 58:
					{
						num = (short)1700659200;
						short num5 = num;
						if (featureSectionId <= 10209)
						{
							num = (short)299958327;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)1611071517;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 59:
						if (featureSectionId != 10608)
						{
							num = (short)1252655143;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_FE6;
					case 60:
						if (controlHeadO9Recset != null)
						{
							num = (short)2086731783;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_A72;
					case 61:
						goto IL_166D;
					case 62:
						goto IL_166D;
					case 63:
						goto IL_166D;
					case 64:
						if (dataButtonInnerRecset != null)
						{
							num = (short)1728380977;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_1C1A;
					case 65:
						enumerator = o9DataButtonInnerRecset.GetEnumerator();
						num = (short)1229586500;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 66:
						try
						{
							num = (short)59768844;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								switch (num2)
								{
								case 0:
									goto IL_1405;
								case 1:
								{
									global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO9.ConsolidatedActionBCOListInner consolidatedActionBCOListInner2;
									task.AddTask(new global::AcpBusinessLayer.UndoRedo.DeleteRecordTask(consolidatedActionBCOListInner2));
									num = (short)76218368;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 2:
									num = (short)2027290629;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 3:
								{
									global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO9.ConsolidatedActionBCOListInner consolidatedActionBCOListInner2;
									if (acpRecRefField.Value != consolidatedActionBCOListInner2.ConsolidatedActionBCOListInnerSection.RadErgoControlO9ACBCOListIndex_A36668.Value)
									{
										num = (short)2129920013;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									goto IL_1540;
								}
								case 4:
								{
									global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO9.ConsolidatedActionBCOListInner consolidatedActionBCOListInner2;
									if (consolidatedActionBCOListInner2.ConsolidatedActionBCOListInnerSection.RadErgoControlO9ACBCOListBco_A36666.Value == 134)
									{
										num = (short)1528758274;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									break;
								}
								case 5:
									if (num3 != 227)
									{
										num = (short)581369857;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									flag2 = true;
									num = (short)447283211;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 6:
									goto IL_1558;
								case 7:
									num = (short)1666580483;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 8:
									goto IL_1540;
								case 9:
								{
									if (!enumerator.MoveNext())
									{
										num = (short)1431633928;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO9.ConsolidatedActionBCOListInner consolidatedActionBCOListInner2 = (global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO9.ConsolidatedActionBCOListInner)enumerator.Current;
									num = (short)432078852;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 10:
									goto IL_139E;
								case 11:
									if (acpRecRefField != null)
									{
										num = (short)861470727;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									goto IL_1540;
								case 12:
									switch (0)
									{
									case 0:
										goto IL_1365;
									}
									continue;
								case 13:
								{
									global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO9.ConsolidatedActionBCOListInner consolidatedActionBCOListInner2;
									task.AddTask(new global::AcpBusinessLayer.UndoRedo.ModifyRecRefDataTask(consolidatedActionBCOListInner2.ConsolidatedActionBCOListInnerSection.RadErgoControlO9ACBCOListIndex_A36668, acpRecRefField.UIValue));
									num = (short)2113863690;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								}
								IL_145C:
								num = (short)439353353;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								IL_1365:
								goto IL_145C;
								IL_1540:
								num = (short)1756233734;
								num2 = (int)((global::System.IntPtr)num);
							}
							IL_139E:
							IL_1405:
							IL_1558:
							goto IL_1B9E;
						}
						finally
						{
							num = (short)113836033;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								switch (num2)
								{
								case 0:
									goto IL_15C9;
								case 1:
									switch (0)
									{
									case 0:
										goto IL_1590;
									}
									continue;
								case 2:
									enumerator.Dispose();
									num = (short)2088697856;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								IL_1590:
								if (enumerator == null)
								{
									break;
								}
								num = (short)1922629634;
								num2 = (int)((global::System.IntPtr)num);
							}
							IL_15C9:;
						}
						goto IL_15CC;
					case 67:
						enumerator = o7DataButtonInnerRecset.GetEnumerator();
						num = (short)1316487171;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 68:
						try
						{
							num = (short)745013250;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								switch (num2)
								{
								case 0:
									num = (short)1638268933;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 1:
								{
									if (!enumerator.MoveNext())
									{
										num = (short)75038720;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									global::AcpCommonLib.IAcpFeatureNode acpFeatureNode9 = enumerator.Current;
									num = (short)440664070;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 2:
									switch (0)
									{
									case 0:
										goto IL_4CC;
									}
									continue;
								case 3:
								{
									global::AcpCommonLib.IAcpFeatureNode acpFeatureNode9;
									task.AddTask(new global::AcpBusinessLayer.UndoRedo.ModifyDataTask<int>((acpFeatureNode9[10608] as global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO9.O9DataButtonInnerSection).RadErgCtrlHeadO9DataButtonCnvFeature_A36528, num3));
									num = (short)994967556;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 4:
									goto IL_509;
								case 5:
									goto IL_5C0;
								case 6:
								{
									global::AcpCommonLib.IAcpFeatureNode acpFeatureNode9;
									if (num3 != (acpFeatureNode9[10608] as global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO9.O9DataButtonInnerSection).RadErgCtrlHeadO9DataButtonCnvFeature_A36528.Value)
									{
										num = (short)1069613059;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									break;
								}
								}
								IL_56B:
								num = (short)925630465;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								IL_4CC:
								goto IL_56B;
							}
							IL_509:
							IL_5C0:
							return;
						}
						finally
						{
							num = (short)952893441;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								switch (num2)
								{
								case 0:
									goto IL_633;
								case 1:
									switch (0)
									{
									case 0:
										goto IL_5F8;
									}
									continue;
								case 2:
									enumerator.Dispose();
									num = (short)185204736;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								IL_5F8:
								if (enumerator == null)
								{
									break;
								}
								num = (short)1786052610;
								num2 = (int)((global::System.IntPtr)num);
							}
							IL_633:;
						}
						goto IL_636;
					case 69:
						enumerator = o7DataButtonInnerRecset.GetEnumerator();
						num = (short)47972369;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 70:
						if (controlHeadO9Recset != null)
						{
							num = (short)900726796;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_21B5;
					case 71:
						if (controlHeadO3Recset != null)
						{
							num = (short)1678442569;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_CF8;
					case 72:
						if (controlHeadO9Recset.Count > 0)
						{
							num = (short)610992210;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_21B5;
					case 73:
						dataButtonInnerRecset3 = (controlHeadO3Recset[0][10234].EmbeddedRecset as global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO3.DataButtonInnerRecset);
						num = (short)1848115208;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 74:
						num = (short)1816002619;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 75:
					{
						global::Motorola.MackinawCPS.CoreFeatures.KeypadMicAndAccessories.KeypadMicAndAccessoriesRecset keypadMicAndAccessoriesRecset;
						dataButtonInnerRecset = (keypadMicAndAccessoriesRecset[0][10228].EmbeddedRecset as global::Motorola.MackinawCPS.CoreFeatures.KeypadMicAndAccessories.DataButtonInnerRecset);
						num = (short)581828636;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 76:
						goto IL_1205;
					case 77:
						if (dataButtonInnerRecset3 != null)
						{
							num = (short)2089812014;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_1630;
					case 78:
						num = (short)711393304;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 79:
						goto IL_21B5;
					case 80:
						goto IL_166D;
					case 81:
						goto IL_A72;
					case 82:
						consolidatedActionBCOListInnerRecset = (controlHeadO9Recset[0][10622].EmbeddedRecset as global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO9.ConsolidatedActionBCOListInnerRecset);
						num = (short)316866616;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 83:
						if (dataButtonInnerRecset3 != null)
						{
							num = (short)726073359;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_19B5;
					case 84:
						goto IL_CA4;
					case 85:
						num = (short)721551380;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 86:
						if (dataButtonInnerRecset2 != null)
						{
							num = (short)896270340;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_1C95;
					}
					goto IL_18A;
					IL_410:
					controlHeadO3Recset = null;
					dataButtonInnerRecset3 = null;
					controlHeadO3Recset = (global::AcpCommonLib.FeatureManager.GetFeature(2127) as global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO3.ControlHeadO3Recset);
					num = (short)1206714439;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_636:
					enumerator = dataButtonInnerRecset3.GetEnumerator();
					num = (short)1275920427;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_69F:
					flag = false;
					num = (short)1881341989;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_A4B:
					enumerator = dataButtonInnerRecset.GetEnumerator();
					num = (short)1698889744;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					Block_8:
					try
					{
						IL_89F:
						num = (short)32112642;
						num2 = (int)((global::System.IntPtr)num);
						for (;;)
						{
							switch (num2)
							{
							case 0:
								num = (short)989396995;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							case 1:
							{
								if (!enumerator.MoveNext())
								{
									num = (short)1786118144;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								global::AcpCommonLib.IAcpFeatureNode acpFeatureNode10 = enumerator.Current;
								num = (short)1666318342;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							case 2:
								switch (0)
								{
								case 0:
									goto IL_8E3;
								}
								continue;
							case 3:
								goto IL_9D8;
							case 4:
							{
								global::AcpCommonLib.IAcpFeatureNode acpFeatureNode10;
								task.AddTask(new global::AcpBusinessLayer.UndoRedo.ModifyDataTask<int>((acpFeatureNode10[10209] as global::Motorola.MackinawCPS.CoreFeatures.KeypadMicAndAccessories.DataButtonInnerSection).RadErgoCfgKMTrunkingKMDatatButtonFeature_A22605, num3));
								num = (short)1358102533;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							case 5:
								goto IL_95A;
							case 6:
							{
								global::AcpCommonLib.IAcpFeatureNode acpFeatureNode10;
								if (num3 != (acpFeatureNode10[10209] as global::Motorola.MackinawCPS.CoreFeatures.KeypadMicAndAccessories.DataButtonInnerSection).RadErgoCfgKMTrunkingKMDatatButtonFeature_A22605.Value)
								{
									num = (short)2018377732;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								break;
							}
							}
							IL_8E5:
							num = (short)543621121;
							num2 = (int)((global::System.IntPtr)num);
							continue;
							IL_8E3:
							goto IL_8E5;
						}
						IL_95A:
						IL_9D8:
						goto IL_1C1A;
					}
					finally
					{
						num = (short)82706432;
						num2 = (int)((global::System.IntPtr)num);
						for (;;)
						{
							switch (num2)
							{
							case 0:
								switch (0)
								{
								case 0:
									goto IL_A10;
								}
								continue;
							case 1:
								goto IL_A48;
							case 2:
								enumerator.Dispose();
								num = (short)1344274433;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							IL_A10:
							if (enumerator == null)
							{
								break;
							}
							num = (short)967835650;
							num2 = (int)((global::System.IntPtr)num);
						}
						IL_A48:;
					}
					goto IL_A4B;
					IL_A72:
					num = (short)30670890;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_AB0:
					buttonsRecset = null;
					dataButtonInnerRecset2 = null;
					buttonsRecset = (global::AcpCommonLib.FeatureManager.GetFeature(2042) as global::Motorola.MackinawCPS.CoreFeatures.Buttons.ButtonsRecset);
					num = (short)1230700553;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_CA4:
					controlHeadO9Recset = null;
					o9DataButtonInnerRecset = null;
					controlHeadO9Recset = (global::AcpCommonLib.FeatureManager.GetFeature(4003) as global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO9.ControlHeadO9Recset);
					num = (short)1510080572;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_CF8:
					controlHeadO7Recset = null;
					o7DataButtonInnerRecset = null;
					controlHeadO7Recset = (global::AcpCommonLib.FeatureManager.GetFeature(4114) as global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO7.ControlHeadO7Recset);
					num = (short)818610206;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_D67:
					num = (short)513605716;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_D86:
					num = (short)654245901;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_E07:
					num = (short)1647050838;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_FE6:
					global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO9.O9DataButtonInnerSection o9DataButtonInnerSection = self as global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO9.O9DataButtonInnerSection;
					num3 = o9DataButtonInnerSection.RadErgCtrlHeadO9DataButtonTrkFeature_A36526.Value;
					acpRecRefField = o9DataButtonInnerSection.CHO9DataButtonTrkIndex_A41416;
					num = (short)1731919952;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_1205:
					dataButtonInnerRecset2 = (buttonsRecset[0][10089].EmbeddedRecset as global::Motorola.MackinawCPS.CoreFeatures.Buttons.DataButtonInnerRecset);
					num = (short)1001455643;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_15CC:
					enumerator = dataButtonInnerRecset2.GetEnumerator();
					num = (short)494010421;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_15F5:
					num = (short)568000589;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_1630:
					num = (short)1418395683;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_166D:
					num = (short)1055981568;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_186E:
					consolidatedActionBCOListInnerRecset = null;
					flag2 = false;
					num = (short)879886406;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_19B5:
					num = (short)522321960;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_1B9E:
					num = (short)782303253;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_1BDC:
					num = (short)982974498;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_1C1A:
					num = (short)648020051;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_1C95:
					num = (short)883621921;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_1E73:
					global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO3.DataButtonInnerSection dataButtonInnerSection2 = self as global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO3.DataButtonInnerSection;
					num3 = dataButtonInnerSection2.CntrlHeadO3TrunkingO3DatatButtonFeature_A22597.Value;
					acpRecRefField = dataButtonInnerSection2.CHO3DataButtonTrkIndex_A41420;
					num = (short)169541676;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_20ED:
					enumerator = o9DataButtonInnerRecset.GetEnumerator();
					num = (short)1354956806;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_2179:
					num = (short)1631584320;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_21B5:
					radioWide = ((global::AcpCommonLib.FeatureManager.GetFeature(2045) as global::Motorola.MackinawCPS.CoreFeatures.RadioWide.RadioWideRecset)[0] as global::Motorola.MackinawCPS.CoreFeatures.RadioWide.RadioWide);
					num = (short)1197146148;
					num2 = (int)((global::System.IntPtr)num);
				}
				return;
				IL_192E:
				return;
				IL_18A:
				num3 = 0;
				flag = true;
				acpRecRefField = null;
				featureSectionId = self.FeatureSectionId;
				num = (short)1247019066;
				num2 = (int)((global::System.IntPtr)num);
				goto IL_27;
			}
			}
		}

		// Token: 0x06008693 RID: 34451 RVA: 0x007CF760 File Offset: 0x007CD960
		public static void ConSyncOrangeBtn(global::AcpCommonLib.IAcpFeatureSection self, global::AcpCommonLib.UndoRedo.ContainerTask task)
		{
			short num = (short)1605304320;
			int num2 = (int)num;
			switch (num2)
			{
			default:
			{
				switch (0)
				{
				case 0:
					goto IL_FC;
				}
				int num3;
				int featureSectionId;
				bool flag;
				for (;;)
				{
					IL_29:
					global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO7.O7InnerRecset o7InnerRecset;
					global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO2.ControlHeadO2Recset controlHeadO2Recset;
					global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO2.O2InnerRecset o2InnerRecset;
					global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO9.O9InnerRecset o9InnerRecset;
					global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO5.O5InnerRecset o5InnerRecset;
					global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO9.ControlHeadO9Recset controlHeadO9Recset;
					global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO5.ControlHeadO5Recset controlHeadO5Recset;
					global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO7.ControlHeadO7Recset controlHeadO7Recset;
					switch (num2)
					{
					case 0:
						goto IL_C4C;
					case 1:
						try
						{
							num = (short)526057476;
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
										num = (short)598212611;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									global::AcpCommonLib.IAcpFeatureNode acpFeatureNode = enumerator.Current;
									num = (short)1817772033;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 1:
								{
									global::AcpCommonLib.IAcpFeatureNode acpFeatureNode;
									if (num3 != (acpFeatureNode[10715] as global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO7.O7InnerSection).CHO7EmergencyButtonFeature_A41291.Value)
									{
										num = (short)1886453762;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									break;
								}
								case 2:
								{
									global::AcpCommonLib.IAcpFeatureNode acpFeatureNode;
									task.AddTask(new global::AcpBusinessLayer.UndoRedo.ModifyDataTask<int>((acpFeatureNode[10715] as global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO7.O7InnerSection).CHO7EmergencyButtonFeature_A41291, num3));
									num = (short)374210565;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 3:
									num = (short)1913257990;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 4:
									switch (0)
									{
									case 0:
										goto IL_527;
									}
									continue;
								case 6:
									goto IL_610;
								}
								IL_57D:
								num = (short)2076901376;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								IL_527:
								goto IL_57D;
							}
							IL_610:
							goto IL_757;
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
										goto IL_647;
									}
									continue;
								case 1:
									enumerator.Dispose();
									num = (short)1158348802;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 2:
									goto IL_681;
								}
								IL_647:
								if (enumerator == null)
								{
									break;
								}
								num = (short)357236737;
								num2 = (int)((global::System.IntPtr)num);
							}
							IL_681:;
						}
						goto IL_684;
					case 2:
						goto IL_A60;
					case 3:
						if (featureSectionId <= 10627)
						{
							num = (short)1584594967;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)1187119109;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 4:
						goto IL_D0D;
					case 5:
						if (featureSectionId != 10715)
						{
							num = (short)422641713;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_4B6;
					case 6:
						try
						{
							num = (short)1927348228;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								switch (num2)
								{
								case 1:
								{
									global::System.Collections.Generic.IEnumerator<global::AcpBusinessLayer.FeatureNode> enumerator;
									if (!enumerator.MoveNext())
									{
										num = (short)1133117442;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									global::AcpCommonLib.IAcpFeatureNode acpFeatureNode2 = enumerator.Current;
									num = (short)89456643;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 2:
									num = (short)95944710;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 3:
								{
									global::AcpCommonLib.IAcpFeatureNode acpFeatureNode2;
									if (num3 != (acpFeatureNode2[10901] as global::Motorola.MackinawCPS.CoreFeatures.ControlHeadE5.E5InnerSection).CHE5EmergencyButtonFeature_43768.Value)
									{
										num = (short)1305739269;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									break;
								}
								case 4:
									switch (0)
									{
									case 0:
										goto IL_818;
									}
									continue;
								case 5:
								{
									global::AcpCommonLib.IAcpFeatureNode acpFeatureNode2;
									task.AddTask(new global::AcpBusinessLayer.UndoRedo.ModifyDataTask<int>((acpFeatureNode2[10901] as global::Motorola.MackinawCPS.CoreFeatures.ControlHeadE5.E5InnerSection).CHE5EmergencyButtonFeature_43768, num3));
									num = (short)535035904;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 6:
									goto IL_908;
								}
								IL_81A:
								num = (short)1661861889;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								IL_818:
								goto IL_81A;
							}
							IL_908:
							goto IL_D4B;
						}
						finally
						{
							num = (short)925630464;
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
										goto IL_940;
									}
									continue;
								case 1:
									enumerator.Dispose();
									num = (short)783941634;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 2:
									goto IL_979;
								}
								IL_940:
								if (enumerator == null)
								{
									break;
								}
								num = (short)231145473;
								num2 = (int)((global::System.IntPtr)num);
							}
							IL_979:;
						}
						goto IL_97C;
					case 7:
						if (o7InnerRecset != null)
						{
							num = (short)2010972192;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_757;
					case 8:
						goto IL_A60;
					case 9:
						try
						{
							num = (short)1250623490;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								switch (num2)
								{
								case 0:
									num = (short)2055798787;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 1:
								{
									global::System.Collections.Generic.IEnumerator<global::AcpBusinessLayer.FeatureNode> enumerator;
									if (!enumerator.MoveNext())
									{
										num = (short)5373952;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									global::AcpCommonLib.IAcpFeatureNode acpFeatureNode3 = enumerator.Current;
									num = (short)1663762438;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 2:
									switch (0)
									{
									case 0:
										goto IL_ED9;
									}
									continue;
								case 3:
									goto IL_FC6;
								case 5:
								{
									global::AcpCommonLib.IAcpFeatureNode acpFeatureNode3;
									task.AddTask(new global::AcpBusinessLayer.UndoRedo.ModifyDataTask<int>((acpFeatureNode3[10627] as global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO9.O9InnerSection).CHO9EmergencyButtonFeature_A36682, num3));
									num = (short)205783044;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 6:
								{
									global::AcpCommonLib.IAcpFeatureNode acpFeatureNode3;
									if (num3 != (acpFeatureNode3[10627] as global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO9.O9InnerSection).CHO9EmergencyButtonFeature_A36682.Value)
									{
										num = (short)239140869;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									break;
								}
								}
								IL_F71:
								num = (short)1821573121;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								IL_ED9:
								goto IL_F71;
							}
							IL_FC6:
							return;
						}
						finally
						{
							num = (short)596180992;
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
										goto IL_FFE;
									}
									continue;
								case 1:
									goto IL_1038;
								case 2:
									enumerator.Dispose();
									num = (short)802422785;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								IL_FFE:
								if (enumerator == null)
								{
									break;
								}
								num = (short)1349713922;
								num2 = (int)((global::System.IntPtr)num);
							}
							IL_1038:;
						}
						goto IL_103B;
					case 10:
						goto IL_A60;
					case 11:
						goto IL_A60;
					case 12:
						goto IL_D99;
					case 13:
					{
						if (!flag)
						{
							num = (short)2088632362;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						global::Motorola.MackinawCPS.CoreFeatures.ControlHeadE5.ControlHeadE5Recset controlHeadE5Recset = null;
						global::Motorola.MackinawCPS.CoreFeatures.ControlHeadE5.E5InnerRecset e5InnerRecset = null;
						controlHeadE5Recset = (global::AcpCommonLib.FeatureManager.GetFeature(4236) as global::Motorola.MackinawCPS.CoreFeatures.ControlHeadE5.ControlHeadE5Recset);
						num = (short)1247084577;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 14:
						o2InnerRecset = (controlHeadO2Recset[0][10723].EmbeddedRecset as global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO2.O2InnerRecset);
						num = (short)1343356932;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 15:
					{
						global::Motorola.MackinawCPS.CoreFeatures.ControlHeadE5.E5InnerRecset e5InnerRecset;
						global::System.Collections.Generic.IEnumerator<global::AcpBusinessLayer.FeatureNode> enumerator = e5InnerRecset.GetEnumerator();
						num = (short)491520006;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 16:
						num = (short)1258553374;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 17:
						num = (short)663093248;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 18:
					{
						if (featureSectionId != 10211)
						{
							num = (short)123600912;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)1761111254;
						short num4 = num;
						num = (short)2036296918;
						switch ((num4 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_97C;
						default:
							num = (short)1421803520;
							if (num != 0)
							{
							}
							num3 = (self as global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO5.O5InnerSection).CntrlHeadO5SignalIndependentO5M5MXChiefCHButtonButtonFeature_A19754.Value;
							num = (short)1056243723;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						break;
					}
					case 19:
						goto IL_6EC;
					case 20:
					{
						global::System.Collections.Generic.IEnumerator<global::AcpBusinessLayer.FeatureNode> enumerator = o9InnerRecset.GetEnumerator();
						num = (short)1682964489;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 21:
					{
						global::Motorola.MackinawCPS.CoreFeatures.ControlHeadE5.ControlHeadE5Recset controlHeadE5Recset;
						global::Motorola.MackinawCPS.CoreFeatures.ControlHeadE5.E5InnerRecset e5InnerRecset = controlHeadE5Recset[0][10902].EmbeddedRecset as global::Motorola.MackinawCPS.CoreFeatures.ControlHeadE5.E5InnerRecset;
						num = (short)1966604322;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 22:
						if (controlHeadO2Recset != null)
						{
							num = (short)1542455310;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_D0D;
					case 23:
						goto IL_97C;
					case 24:
						if (o5InnerRecset != null)
						{
							num = (short)775487538;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_107E;
					case 25:
					{
						global::System.Collections.Generic.IEnumerator<global::AcpBusinessLayer.FeatureNode> enumerator = o2InnerRecset.GetEnumerator();
						num = (short)2073100327;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 26:
						if (featureSectionId == 10901)
						{
							num = (short)2122383408;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_C4C;
					case 27:
						try
						{
							num = (short)2074148868;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								switch (num2)
								{
								case 1:
								{
									global::System.Collections.Generic.IEnumerator<global::AcpBusinessLayer.FeatureNode> enumerator;
									if (!enumerator.MoveNext())
									{
										num = (short)1897922562;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									global::AcpCommonLib.IAcpFeatureNode acpFeatureNode4 = enumerator.Current;
									num = (short)1235288067;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 2:
									num = (short)2046427142;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 3:
								{
									global::AcpCommonLib.IAcpFeatureNode acpFeatureNode4;
									if (num3 != (acpFeatureNode4[10211] as global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO5.O5InnerSection).CntrlHeadO5SignalIndependentO5M5MXChiefCHButtonButtonFeature_A19754.Value)
									{
										num = (short)930545669;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									break;
								}
								case 4:
									switch (0)
									{
									case 0:
										goto IL_1B6;
									}
									continue;
								case 5:
								{
									global::AcpCommonLib.IAcpFeatureNode acpFeatureNode4;
									task.AddTask(new global::AcpBusinessLayer.UndoRedo.ModifyDataTask<int>((acpFeatureNode4[10211] as global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO5.O5InnerSection).CntrlHeadO5SignalIndependentO5M5MXChiefCHButtonButtonFeature_A19754, num3));
									num = (short)1573322752;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 6:
									goto IL_2A6;
								}
								IL_1B8:
								num = (short)273088513;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								IL_1B6:
								goto IL_1B8;
							}
							IL_2A6:
							goto IL_107E;
						}
						finally
						{
							num = (short)1673330688;
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
									num = (short)1445265410;
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
								num = (short)1723924481;
								num2 = (int)((global::System.IntPtr)num);
							}
							IL_314:;
						}
						goto Block_3;
					case 28:
						goto IL_A60;
					case 29:
						if (controlHeadO9Recset != null)
						{
							num = (short)735445027;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_6EC;
					case 30:
						if (featureSectionId != 10627)
						{
							num = (short)1741422609;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num3 = (self as global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO9.O9InnerSection).CHO9EmergencyButtonFeature_A36682.Value;
						num = (short)1870266405;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 31:
						if (featureSectionId != 10716)
						{
							num = (short)652738600;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num3 = (self as global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO2.O2InnerSection).CHO2EmergencyButtonFeature_A41272.Value;
						num = (short)2045313052;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 32:
					{
						global::System.Collections.Generic.IEnumerator<global::AcpBusinessLayer.FeatureNode> enumerator = o7InnerRecset.GetEnumerator();
						num = (short)87556097;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 33:
					{
						global::Motorola.MackinawCPS.CoreFeatures.ControlHeadE5.ControlHeadE5Recset controlHeadE5Recset;
						if (controlHeadE5Recset != null)
						{
							num = (short)1626144789;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_B37;
					}
					case 34:
						goto IL_B37;
					case 35:
						o9InnerRecset = (controlHeadO9Recset[0][10626].EmbeddedRecset as global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO9.O9InnerRecset);
						num = (short)151715859;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 36:
						o5InnerRecset = (controlHeadO5Recset[0][10227].EmbeddedRecset as global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO5.O5InnerRecset);
						num = (short)576389163;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 37:
						goto IL_A60;
					case 38:
						if (controlHeadO5Recset != null)
						{
							num = (short)562429988;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_1125;
					case 39:
						goto IL_317;
					case 40:
						goto IL_684;
					case 41:
						if (o2InnerRecset != null)
						{
							num = (short)1753022489;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_10D3;
					case 42:
						return;
					case 43:
						goto IL_1125;
					case 44:
					{
						global::Motorola.MackinawCPS.CoreFeatures.ControlHeadE5.E5InnerRecset e5InnerRecset;
						if (e5InnerRecset != null)
						{
							num = (short)255197199;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_D4B;
					}
					case 45:
						if (controlHeadO7Recset != null)
						{
							num = (short)729808942;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_D99;
					case 46:
						o7InnerRecset = (controlHeadO7Recset[0][10719].EmbeddedRecset as global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO7.O7InnerRecset);
						num = (short)1303576588;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 47:
						if (o9InnerRecset != null)
						{
							num = (short)246349844;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return;
					case 48:
						num3 = (self as global::Motorola.MackinawCPS.CoreFeatures.ControlHeadE5.E5InnerSection).CHE5EmergencyButtonFeature_43768.Value;
						num = (short)886177802;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 49:
						goto IL_103B;
					case 50:
					{
						global::System.Collections.Generic.IEnumerator<global::AcpBusinessLayer.FeatureNode> enumerator = o5InnerRecset.GetEnumerator();
						num = (short)1132855323;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					}
					goto IL_FC;
					IL_4B6:
					num3 = (self as global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO7.O7InnerSection).CHO7EmergencyButtonFeature_A41291.Value;
					num = (short)738721800;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					Block_3:
					try
					{
						IL_317:
						num = (short)637992964;
						num2 = (int)((global::System.IntPtr)num);
						for (;;)
						{
							switch (num2)
							{
							case 0:
							{
								global::AcpCommonLib.IAcpFeatureNode acpFeatureNode5;
								if (num3 != (acpFeatureNode5[10716] as global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO2.O2InnerSection).CHO2EmergencyButtonFeature_A41272.Value)
								{
									num = (short)228392963;
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
									num = (short)1141964802;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								global::AcpCommonLib.IAcpFeatureNode acpFeatureNode5 = enumerator.Current;
								num = (short)2010447872;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							case 2:
								num = (short)1046282246;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							case 3:
							{
								global::AcpCommonLib.IAcpFeatureNode acpFeatureNode5;
								task.AddTask(new global::AcpBusinessLayer.UndoRedo.ModifyDataTask<int>((acpFeatureNode5[10716] as global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO2.O2InnerSection).CHO2EmergencyButtonFeature_A41272, num3));
								num = (short)1298399237;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							case 4:
								switch (0)
								{
								case 0:
									goto IL_35B;
								}
								continue;
							case 6:
								goto IL_443;
							}
							IL_35D:
							num = (short)205455361;
							num2 = (int)((global::System.IntPtr)num);
							continue;
							IL_35B:
							goto IL_35D;
						}
						IL_443:
						goto IL_10D3;
					}
					finally
					{
						num = (short)1966342144;
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
									goto IL_47B;
								}
								continue;
							case 1:
								enumerator.Dispose();
								num = (short)2064384002;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							case 2:
								goto IL_4B3;
							}
							IL_47B:
							if (enumerator == null)
							{
								break;
							}
							num = (short)659685377;
							num2 = (int)((global::System.IntPtr)num);
						}
						IL_4B3:;
					}
					goto IL_4B6;
					IL_684:
					num = (short)1736966170;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_6EC:
					num = (short)771555375;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_757:
					controlHeadO9Recset = null;
					o9InnerRecset = null;
					controlHeadO9Recset = (global::AcpCommonLib.FeatureManager.GetFeature(4003) as global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO9.ControlHeadO9Recset);
					num = (short)481427456;
					short num5 = num;
					num = (short)819724317;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_97C:
					num = (short)989855762;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_A60:
					num = (short)240582669;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_B37:
					num = (short)537198636;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_C4C:
					flag = false;
					num = (short)240582658;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_D0D:
					num = (short)1216544809;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_D4B:
					controlHeadO2Recset = null;
					o2InnerRecset = null;
					controlHeadO2Recset = (global::AcpCommonLib.FeatureManager.GetFeature(4115) as global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO2.ControlHeadO2Recset);
					num = (short)170393622;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_D99:
					num = (short)165609479;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_103B:
					num = (short)1213988895;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_107E:
					controlHeadO7Recset = null;
					o7InnerRecset = null;
					controlHeadO7Recset = (global::AcpCommonLib.FeatureManager.GetFeature(4114) as global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO7.ControlHeadO7Recset);
					num = (short)1295450157;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_10D3:
					controlHeadO5Recset = null;
					o5InnerRecset = null;
					controlHeadO5Recset = (global::AcpCommonLib.FeatureManager.GetFeature(2130) as global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO5.ControlHeadO5Recset);
					num = (short)1822097446;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_1125:
					num = (short)1399914520;
					num2 = (int)((global::System.IntPtr)num);
				}
				return;
				IL_FC:
				num = (short)58392577;
				if (num != 0)
				{
				}
				num3 = 0;
				flag = true;
				featureSectionId = self.FeatureSectionId;
				num = (short)1321992195;
				num2 = (int)((global::System.IntPtr)num);
				goto IL_29;
			}
			}
		}

		// Token: 0x06008694 RID: 34452 RVA: 0x007D0950 File Offset: 0x007CEB50
		public static bool conDownButtonApplicable(global::AcpCommonLib.IAcpFeatureSection self)
		{
			while (self.ParentRecset[1] == self.Parent)
			{
				short num = (short)1101312406;
				short num2 = num;
				num = (short)1808183702;
				switch ((num2 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					break;
				default:
				{
					num = (short)2099970049;
					if (num != 0)
					{
					}
					num = (short)1024458752;
					if (num != 0)
					{
					}
					num = (short)673644544;
					short num3 = num;
					return false;
				}
				}
			}
			return true;
		}

		// Token: 0x06008695 RID: 34453 RVA: 0x007D0A14 File Offset: 0x007CEC14
		internal static bool ConO7DataButtonConvIndexApplicable(global::AcpCommonLib.IAcpFeatureSection self)
		{
			short num;
			for (;;)
			{
				num = (short)1585315841;
				if (num != 0)
				{
				}
				if ((self as global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO7.O7DataButtonInnerSection).RadErgCtrlHeadO7DataButtonCnvFeature_A41299.Value != 227)
				{
					return false;
				}
				num = (short)1614887683;
				short num2 = num;
				num = (short)1778924291;
				switch ((num2 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					break;
				default:
					goto IL_76;
				}
			}
			IL_76:
			num = (short)1910308864;
			if (num != 0)
			{
			}
			num = (short)1456668672;
			short num3 = num;
			return true;
		}

		// Token: 0x06008696 RID: 34454 RVA: 0x007D0ADC File Offset: 0x007CECDC
		internal static bool ConO7DataButtonTrkIndexApplicable(global::AcpCommonLib.IAcpFeatureSection self)
		{
			while ((self as global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO7.O7DataButtonInnerSection).RadErgCtrlHeadO7DataButtonTrkFeature_A41297.Value == 227)
			{
				short num = (short)303580966;
				short num2 = num;
				num = (short)940787494;
				switch ((num2 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					break;
				default:
				{
					num = (short)1469644801;
					if (num != 0)
					{
					}
					num = (short)2097152000;
					if (num != 0)
					{
					}
					num = (short)1737293824;
					short num3 = num;
					return true;
				}
				}
			}
			return false;
		}

		// Token: 0x06008697 RID: 34455 RVA: 0x007D0BA4 File Offset: 0x007CEDA4
		public static void ConValueSetIfDataCnvIndexChanged(global::AcpCommonLib.IAcpFeatureSection self, global::AcpCommonLib.UndoRedo.ContainerTask task)
		{
			short num = (short)428670976;
			int num2 = (int)num;
			switch (num2)
			{
			default:
			{
				switch (0)
				{
				case 0:
					goto IL_116;
				}
				global::AcpBusinessLayer.AcpListField acpListField;
				int featureSectionId;
				global::AcpBusinessLayer.AcpListField acpListField2;
				for (;;)
				{
					IL_27:
					bool flag;
					global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO3.DataButtonInnerRecset dataButtonInnerRecset;
					global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO7.ControlHeadO7Recset controlHeadO7Recset;
					global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO7.O7DataButtonInnerRecset o7DataButtonInnerRecset;
					global::Motorola.MackinawCPS.CoreFeatures.KeypadMicAndAccessories.DataButtonInnerRecset dataButtonInnerRecset2;
					global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO9.ControlHeadO9Recset controlHeadO9Recset;
					global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO9.O9DataButtonInnerRecset o9DataButtonInnerRecset;
					global::Motorola.MackinawCPS.CoreFeatures.KeypadMicAndAccessories.KeypadMicAndAccessoriesRecset keypadMicAndAccessoriesRecset;
					global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO3.ControlHeadO3Recset controlHeadO3Recset;
					global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO9.ConsolidatedActionBCOListInnerSection consolidatedActionBCOListInnerSection;
					switch (num2)
					{
					case 0:
					{
						flag = false;
						global::System.Collections.Generic.IEnumerator<global::AcpBusinessLayer.FeatureNode> enumerator = dataButtonInnerRecset.GetEnumerator();
						num = (short)96272435;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 1:
						try
						{
							num = (short)139198466;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								switch (num2)
								{
								case 0:
									num = (short)1180893191;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 1:
								{
									global::AcpCommonLib.IAcpFeatureNode acpFeatureNode;
									if (acpListField.Value != (acpFeatureNode[10209] as global::Motorola.MackinawCPS.CoreFeatures.KeypadMicAndAccessories.DataButtonInnerSection).RadErgoCfgKMConventionalKMDatatButtonIndex_A41423.Value)
									{
										num = (short)553189379;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									goto IL_5BE;
								}
								case 2:
									switch (0)
									{
									case 0:
										goto IL_574;
									}
									continue;
								case 3:
								{
									global::AcpCommonLib.IAcpFeatureNode acpFeatureNode;
									task.AddTask(new global::AcpBusinessLayer.UndoRedo.ModifyRecRefDataTask((acpFeatureNode[10209] as global::Motorola.MackinawCPS.CoreFeatures.KeypadMicAndAccessories.DataButtonInnerSection).RadErgoCfgKMConventionalKMDatatButtonIndex_A41423, acpListField.UIValue));
									flag = true;
									num = (short)240517130;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 4:
									goto IL_661;
								case 5:
								{
									global::System.Collections.Generic.IEnumerator<global::AcpBusinessLayer.FeatureNode> enumerator;
									if (!enumerator.MoveNext())
									{
										num = (short)104398860;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									global::AcpCommonLib.IAcpFeatureNode acpFeatureNode = enumerator.Current;
									num = (short)18677761;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 6:
									if (flag)
									{
										num = (short)774373376;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									break;
								case 7:
									goto IL_6B0;
								case 8:
								{
									global::AcpCommonLib.IAcpFeatureNode acpFeatureNode;
									task.AddTask(new global::AcpBusinessLayer.UndoRedo.ModifyRecRefDataTask((acpFeatureNode[10209] as global::Motorola.MackinawCPS.CoreFeatures.KeypadMicAndAccessories.DataButtonInnerSection).RadErgoCfgKMTrunkingKMDatatButtonIndex_A41424, acpListField.UIValue));
									flag = true;
									num = (short)672137220;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 9:
									goto IL_771;
								case 10:
									goto IL_5BE;
								case 11:
								{
									global::AcpCommonLib.IAcpFeatureNode acpFeatureNode;
									if (acpListField.Value != (acpFeatureNode[10209] as global::Motorola.MackinawCPS.CoreFeatures.KeypadMicAndAccessories.DataButtonInnerSection).RadErgoCfgKMTrunkingKMDatatButtonIndex_A41424.Value)
									{
										num = (short)518979592;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									goto IL_661;
								}
								case 12:
									num = (short)2074083337;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								goto IL_574;
								IL_5BE:
								num = (short)647364619;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								IL_661:
								num = (short)1989410822;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								IL_6B5:
								num = (short)1396441093;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								IL_574:
								goto IL_6B5;
							}
							IL_6B0:
							IL_771:
							goto IL_138C;
						}
						finally
						{
							num = (short)1789591553;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								global::System.Collections.Generic.IEnumerator<global::AcpBusinessLayer.FeatureNode> enumerator;
								switch (num2)
								{
								case 0:
									enumerator.Dispose();
									num = (short)248250370;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 1:
									switch (0)
									{
									case 0:
										goto IL_7A8;
									}
									continue;
								case 2:
									goto IL_7E0;
								}
								IL_7A8:
								if (enumerator == null)
								{
									break;
								}
								num = (short)384565248;
								num2 = (int)((global::System.IntPtr)num);
							}
							IL_7E0:;
						}
						goto IL_7E3;
					case 2:
						o7DataButtonInnerRecset = (controlHeadO7Recset[0][10717].EmbeddedRecset as global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO7.O7DataButtonInnerRecset);
						num = (short)1854013495;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 3:
						num = (short)1056964640;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 4:
						num = (short)1294991400;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 5:
					{
						global::System.Collections.Generic.IEnumerator<global::AcpBusinessLayer.FeatureNode> enumerator = dataButtonInnerRecset2.GetEnumerator();
						num = (short)1900281857;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 6:
						if (acpListField == null)
						{
							num = (short)63635478;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_F6C;
					case 7:
						goto IL_16CA;
					case 8:
					{
						flag = false;
						global::System.Collections.Generic.IEnumerator<global::AcpBusinessLayer.FeatureNode> enumerator = o7DataButtonInnerRecset.GetEnumerator();
						num = (short)996343842;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 9:
						if (controlHeadO9Recset != null)
						{
							num = (short)1719861263;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_16CA;
					case 10:
						goto IL_B61;
					case 11:
						goto IL_B61;
					case 12:
						if (featureSectionId <= 10212)
						{
							num = (short)1075511299;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)116457499;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 13:
						goto IL_B61;
					case 14:
						if (o9DataButtonInnerRecset != null)
						{
							num = (short)1886060588;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_164D;
					case 15:
						o9DataButtonInnerRecset = (controlHeadO9Recset[0][10611].EmbeddedRecset as global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO9.O9DataButtonInnerRecset);
						num = (short)1445593095;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 16:
						if (controlHeadO7Recset != null)
						{
							num = (short)1707540482;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_1431;
					case 17:
						if (dataButtonInnerRecset2 != null)
						{
							num = (short)163774469;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_138C;
					case 18:
						goto IL_B61;
					case 19:
						goto IL_B61;
					case 20:
						if (keypadMicAndAccessoriesRecset != null)
						{
							num = (short)1507000368;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_15DC;
					case 21:
						goto IL_B61;
					case 22:
						goto IL_B99;
					case 23:
						goto IL_A6F;
					case 24:
						if (featureSectionId != 10623)
						{
							num = (short)702808092;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_7E3;
					case 25:
						try
						{
							num = (short)1112670208;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								switch (num2)
								{
								case 0:
									switch (0)
									{
									case 0:
										goto IL_8C4;
									}
									continue;
								case 1:
									num = (short)2090991623;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 2:
								{
									global::System.Collections.Generic.IEnumerator<global::AcpBusinessLayer.FeatureNode> enumerator;
									if (!enumerator.MoveNext())
									{
										num = (short)847052805;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO9.ConsolidatedActionBCOListInner consolidatedActionBCOListInner = (global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO9.ConsolidatedActionBCOListInner)enumerator.Current;
									num = (short)1299513352;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 3:
									goto IL_9FD;
								case 4:
								{
									global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO9.ConsolidatedActionBCOListInner consolidatedActionBCOListInner;
									task.AddTask(new global::AcpBusinessLayer.UndoRedo.ModifyRecRefDataTask(consolidatedActionBCOListInner.ConsolidatedActionBCOListInnerSection.RadErgoControlO9ACBCOListIndex_A36668, acpListField.UIValue));
									num = (short)976027654;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 5:
									goto IL_9E5;
								case 6:
									goto IL_947;
								case 7:
								{
									global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO9.ConsolidatedActionBCOListInner consolidatedActionBCOListInner;
									if (acpListField.Value != consolidatedActionBCOListInner.ConsolidatedActionBCOListInnerSection.RadErgoControlO9ACBCOListIndex_A36668.Value)
									{
										num = (short)1728249860;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									goto IL_9E5;
								}
								case 8:
								{
									global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO9.ConsolidatedActionBCOListInner consolidatedActionBCOListInner;
									if (consolidatedActionBCOListInner.ConsolidatedActionBCOListInnerSection.RadErgoControlO9ACBCOListBco_A36666.Value == 134)
									{
										num = (short)1383661569;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									break;
								}
								}
								IL_94C:
								num = (short)10092546;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								IL_8C4:
								goto IL_94C;
								IL_9E5:
								num = (short)613548035;
								num2 = (int)((global::System.IntPtr)num);
							}
							IL_947:
							IL_9FD:
							return;
						}
						finally
						{
							num = (short)1449328641;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								global::System.Collections.Generic.IEnumerator<global::AcpBusinessLayer.FeatureNode> enumerator;
								switch (num2)
								{
								case 0:
									enumerator.Dispose();
									num = (short)1007419394;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 1:
									switch (0)
									{
									case 0:
										goto IL_A34;
									}
									continue;
								case 2:
									goto IL_A6C;
								}
								IL_A34:
								if (enumerator == null)
								{
									break;
								}
								num = (short)595525632;
								num2 = (int)((global::System.IntPtr)num);
							}
							IL_A6C:;
						}
						goto IL_A6F;
					case 26:
					{
						if (featureSectionId != 10212)
						{
							num = (short)1458176046;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO3.DataButtonInnerSection dataButtonInnerSection = self as global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO3.DataButtonInnerSection;
						acpListField = dataButtonInnerSection.CHO3DataButtonConvIndex_A41419;
						acpListField2 = dataButtonInnerSection.CntrlHeadO3ConventionalO3DatatButtonFeature_A22595;
						num = (short)592183306;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 27:
						if (featureSectionId != 10608)
						{
							num = (short)1036451894;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_42B;
					case 28:
						num = (short)724172847;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 29:
						goto IL_15DC;
					case 30:
						if (dataButtonInnerRecset != null)
						{
							num = (short)1820655616;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_49C;
					case 31:
						dataButtonInnerRecset = (controlHeadO3Recset[0][10234].EmbeddedRecset as global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO3.DataButtonInnerRecset);
						num = (short)18219031;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 32:
					{
						if (featureSectionId != 10209)
						{
							num = (short)506462257;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						global::Motorola.MackinawCPS.CoreFeatures.KeypadMicAndAccessories.DataButtonInnerSection dataButtonInnerSection2 = self as global::Motorola.MackinawCPS.CoreFeatures.KeypadMicAndAccessories.DataButtonInnerSection;
						acpListField = dataButtonInnerSection2.RadErgoCfgKMConventionalKMDatatButtonIndex_A41423;
						acpListField2 = dataButtonInnerSection2.RadErgoCfgKMConventionalKMDatatButtonFeature_A22603;
						num = (short)313131058;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 33:
					{
						global::System.Collections.Generic.IEnumerator<global::AcpBusinessLayer.FeatureNode> enumerator = (controlHeadO9Recset[0][10622].EmbeddedRecset as global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO9.ConsolidatedActionBCOListInnerRecset).GetEnumerator();
						num = (short)1563033625;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 34:
						try
						{
							num = (short)2129788930;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								switch (num2)
								{
								case 0:
								{
									global::AcpCommonLib.IAcpFeatureNode acpFeatureNode2;
									if (acpListField.Value != (acpFeatureNode2[10713] as global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO7.O7DataButtonInnerSection).CHO7DataButtonTrkIndex_A41418.Value)
									{
										num = (short)649986055;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									goto IL_245;
								}
								case 1:
								{
									global::AcpCommonLib.IAcpFeatureNode acpFeatureNode2;
									task.AddTask(new global::AcpBusinessLayer.UndoRedo.ModifyRecRefDataTask((acpFeatureNode2[10713] as global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO7.O7DataButtonInnerSection).CHO7DataButtonConvIndex_A41417, acpListField.UIValue));
									flag = true;
									num = (short)239927304;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 2:
									switch (0)
									{
									case 0:
										goto IL_1BF;
									}
									continue;
								case 3:
									goto IL_399;
								case 4:
								{
									global::System.Collections.Generic.IEnumerator<global::AcpBusinessLayer.FeatureNode> enumerator;
									if (!enumerator.MoveNext())
									{
										num = (short)570163211;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									global::AcpCommonLib.IAcpFeatureNode acpFeatureNode2 = enumerator.Current;
									num = (short)981925900;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 5:
									goto IL_245;
								case 6:
									num = (short)391380995;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 7:
								{
									global::AcpCommonLib.IAcpFeatureNode acpFeatureNode2;
									task.AddTask(new global::AcpBusinessLayer.UndoRedo.ModifyRecRefDataTask((acpFeatureNode2[10713] as global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO7.O7DataButtonInnerSection).CHO7DataButtonTrkIndex_A41418, acpListField.UIValue));
									flag = true;
									num = (short)1493303301;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 8:
									goto IL_281;
								case 9:
									goto IL_3B6;
								case 10:
									if (flag)
									{
										num = (short)1417674758;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									break;
								case 11:
									num = (short)479133705;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 12:
								{
									global::AcpCommonLib.IAcpFeatureNode acpFeatureNode2;
									if (acpListField.Value != (acpFeatureNode2[10713] as global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO7.O7DataButtonInnerSection).CHO7DataButtonConvIndex_A41417.Value)
									{
										num = (short)887029761;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									goto IL_281;
								}
								}
								IL_1C4:
								num = (short)296747012;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								IL_1BF:
								goto IL_1C4;
								IL_245:
								num = (short)1080623114;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								IL_281:
								num = (short)339607552;
								num2 = (int)((global::System.IntPtr)num);
							}
							IL_399:
							IL_3B6:
							goto IL_1484;
						}
						finally
						{
							num = (short)760348673;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								global::System.Collections.Generic.IEnumerator<global::AcpBusinessLayer.FeatureNode> enumerator;
								switch (num2)
								{
								case 0:
									enumerator.Dispose();
									num = (short)1038614530;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 1:
									switch (0)
									{
									case 0:
										goto IL_3EF;
									}
									continue;
								case 2:
									goto IL_428;
								}
								IL_3EF:
								if (enumerator == null)
								{
									break;
								}
								num = (short)329252864;
								num2 = (int)((global::System.IntPtr)num);
							}
							IL_428:;
						}
						goto IL_42B;
					case 35:
						acpListField = consolidatedActionBCOListInnerSection.RadErgoControlO9ACBCOListIndex_A36668;
						num = (short)421462037;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 36:
						if (o7DataButtonInnerRecset != null)
						{
							num = (short)371851272;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_1484;
					case 37:
						if (134 == consolidatedActionBCOListInnerSection.RadErgoControlO9ACBCOListBco_A36666.Value)
						{
							num = (short)1574764579;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_B61;
					case 38:
						if (controlHeadO3Recset != null)
						{
							num = (short)1935933471;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_A6F;
					case 39:
						num = (short)569638923;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 40:
						if (acpListField2.Value != 134)
						{
							num = (short)1542455339;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_14FD;
					case 41:
						num = (short)1064566829;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 42:
						if (acpListField2.Value == 227)
						{
							num = (short)540934200;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return;
					case 43:
						num = (short)1171259434;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 44:
					{
						flag = false;
						global::System.Collections.Generic.IEnumerator<global::AcpBusinessLayer.FeatureNode> enumerator = o9DataButtonInnerRecset.GetEnumerator();
						num = (short)103678005;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 45:
						if (controlHeadO9Recset.Count > 0)
						{
							num = (short)454885409;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return;
					case 46:
						num = (short)315293715;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 47:
					{
						if (featureSectionId != 10713)
						{
							num = (short)1962803239;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO7.O7DataButtonInnerSection o7DataButtonInnerSection = self as global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO7.O7DataButtonInnerSection;
						acpListField = o7DataButtonInnerSection.CHO7DataButtonConvIndex_A41417;
						acpListField2 = o7DataButtonInnerSection.RadErgCtrlHeadO7DataButtonCnvFeature_A41299;
						num = (short)1086914578;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 48:
						dataButtonInnerRecset2 = (keypadMicAndAccessoriesRecset[0][10228].EmbeddedRecset as global::Motorola.MackinawCPS.CoreFeatures.KeypadMicAndAccessories.DataButtonInnerRecset);
						num = (short)1328742429;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 49:
						num = (short)1180631066;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 50:
						num = (short)1784086529;
						if (num != 0)
						{
						}
						goto IL_B61;
					case 51:
						try
						{
							num = (short)265814018;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								switch (num2)
								{
								case 0:
									goto IL_E4F;
								case 1:
								{
									global::System.Collections.Generic.IEnumerator<global::AcpBusinessLayer.FeatureNode> enumerator;
									if (!enumerator.MoveNext())
									{
										num = (short)1282211843;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									global::AcpCommonLib.IAcpFeatureNode acpFeatureNode3 = enumerator.Current;
									num = (short)829816843;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 2:
									switch (0)
									{
									case 0:
										goto IL_D08;
									}
									continue;
								case 3:
									num = (short)1221918729;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 4:
									goto IL_DB4;
								case 5:
									num = (short)390987788;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 6:
								{
									global::AcpCommonLib.IAcpFeatureNode acpFeatureNode3;
									task.AddTask(new global::AcpBusinessLayer.UndoRedo.ModifyRecRefDataTask((acpFeatureNode3[10212] as global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO3.DataButtonInnerSection).CHO3DataButtonTrkIndex_A41420, acpListField.UIValue));
									flag = true;
									num = (short)2125922304;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 7:
									if (flag)
									{
										num = (short)1588854789;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									break;
								case 8:
								{
									global::AcpCommonLib.IAcpFeatureNode acpFeatureNode3;
									task.AddTask(new global::AcpBusinessLayer.UndoRedo.ModifyRecRefDataTask((acpFeatureNode3[10212] as global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO3.DataButtonInnerSection).CHO3DataButtonConvIndex_A41419, acpListField.UIValue));
									flag = true;
									num = (short)199491588;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 9:
									goto IL_EFB;
								case 10:
								{
									global::AcpCommonLib.IAcpFeatureNode acpFeatureNode3;
									if (acpListField.Value != (acpFeatureNode3[10212] as global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO3.DataButtonInnerSection).CHO3DataButtonTrkIndex_A41420.Value)
									{
										num = (short)1202716678;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									goto IL_E4F;
								}
								case 11:
								{
									global::AcpCommonLib.IAcpFeatureNode acpFeatureNode3;
									if (acpListField.Value != (acpFeatureNode3[10212] as global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO3.DataButtonInnerSection).CHO3DataButtonConvIndex_A41419.Value)
									{
										num = (short)1991770120;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									goto IL_DB4;
								}
								case 12:
									goto IL_E9F;
								}
								goto IL_D08;
								IL_DB4:
								num = (short)911015946;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								IL_E4F:
								num = (short)1178271751;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								IL_EA4:
								num = (short)1376452609;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								IL_D08:
								goto IL_EA4;
							}
							IL_E9F:
							IL_EFB:
							goto IL_49C;
						}
						finally
						{
							num = (short)109314048;
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
										goto IL_F32;
									}
									continue;
								case 1:
									goto IL_F69;
								case 2:
									enumerator.Dispose();
									num = (short)1695481857;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								IL_F32:
								if (enumerator == null)
								{
									break;
								}
								num = (short)692387842;
								num2 = (int)((global::System.IntPtr)num);
							}
							IL_F69:;
						}
						goto IL_F6C;
					case 52:
						if (acpListField2 != null)
						{
							num = (short)180486148;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return;
					case 53:
						try
						{
							num = (short)1010565127;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								switch (num2)
								{
								case 0:
									num = (short)1442447371;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 1:
									num = (short)1840578565;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 2:
								{
									global::AcpCommonLib.IAcpFeatureNode acpFeatureNode4;
									task.AddTask(new global::AcpBusinessLayer.UndoRedo.ModifyRecRefDataTask((acpFeatureNode4[10608] as global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO9.O9DataButtonInnerSection).CHO9DataButtonTrkIndex_A41416, acpListField.UIValue));
									flag = true;
									num = (short)1919025158;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 3:
									goto IL_1132;
								case 4:
								{
									global::AcpCommonLib.IAcpFeatureNode acpFeatureNode4;
									if (acpListField.Value != (acpFeatureNode4[10608] as global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO9.O9DataButtonInnerSection).CHO9DataButtonTrkIndex_A41416.Value)
									{
										num = (short)188809218;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									goto IL_1074;
								}
								case 5:
									goto IL_129C;
								case 6:
									goto IL_1074;
								case 7:
									switch (0)
									{
									case 0:
										goto IL_106F;
									}
									continue;
								case 8:
								{
									global::AcpCommonLib.IAcpFeatureNode acpFeatureNode4;
									if (acpListField.Value == (acpFeatureNode4[10608] as global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO9.O9DataButtonInnerSection).CHO9DataButtonConvIndex_A41414.Value)
									{
										goto IL_1134;
									}
									num = (short)982963229;
									short num3 = num;
									num = (short)1741083677;
									switch ((num3 == num) ? 1 : 0)
									{
									case 0:
									case 2:
										goto IL_1132;
									default:
										num = (short)1932591104;
										if (num != 0)
										{
										}
										num = (short)1713700874;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									break;
								}
								case 9:
									if (flag)
									{
										num = (short)1020592129;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									break;
								case 10:
								{
									global::AcpCommonLib.IAcpFeatureNode acpFeatureNode4;
									task.AddTask(new global::AcpBusinessLayer.UndoRedo.ModifyRecRefDataTask((acpFeatureNode4[10608] as global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO9.O9DataButtonInnerSection).CHO9DataButtonConvIndex_A41414, acpListField.UIValue));
									flag = true;
									num = (short)2092433411;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 11:
									goto IL_12B9;
								case 12:
								{
									global::System.Collections.Generic.IEnumerator<global::AcpBusinessLayer.FeatureNode> enumerator;
									if (!enumerator.MoveNext())
									{
										num = (short)1191575552;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									global::AcpCommonLib.IAcpFeatureNode acpFeatureNode4 = enumerator.Current;
									num = (short)372441096;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								}
								goto IL_106F;
								IL_1074:
								num = (short)742981641;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								IL_1134:
								num = (short)836239364;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								IL_1132:
								goto IL_1134;
								IL_1190:
								num = (short)231538700;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								IL_106F:
								goto IL_1190;
							}
							IL_129C:
							IL_12B9:
							goto IL_164D;
						}
						finally
						{
							num = (short)1884094464;
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
										goto IL_12F0;
									}
									continue;
								case 1:
									goto IL_1328;
								case 2:
									enumerator.Dispose();
									num = (short)2010382337;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								IL_12F0:
								if (enumerator == null)
								{
									break;
								}
								num = (short)1545797634;
								num2 = (int)((global::System.IntPtr)num);
							}
							IL_1328:;
						}
						return;
					case 54:
						num = (short)1595080728;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 55:
						goto IL_1431;
					case 56:
						goto IL_14FD;
					case 57:
						if (controlHeadO9Recset != null)
						{
							num = (short)556859433;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return;
					}
					goto IL_116;
					IL_42B:
					global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO9.O9DataButtonInnerSection o9DataButtonInnerSection = self as global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO9.O9DataButtonInnerSection;
					acpListField = o9DataButtonInnerSection.CHO9DataButtonConvIndex_A41414;
					acpListField2 = o9DataButtonInnerSection.RadErgCtrlHeadO9DataButtonCnvFeature_A36528;
					num = (short)1817640973;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_49C:
					num = (short)1254555684;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_7E3:
					consolidatedActionBCOListInnerSection = (self as global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO9.ConsolidatedActionBCOListInnerSection);
					num = (short)328663077;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_A6F:
					controlHeadO7Recset = null;
					o7DataButtonInnerRecset = null;
					controlHeadO7Recset = (global::AcpCommonLib.FeatureManager.GetFeature(4114) as global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO7.ControlHeadO7Recset);
					num = (short)589430800;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_B61:
					num = (short)840433670;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_F6C:
					keypadMicAndAccessoriesRecset = null;
					dataButtonInnerRecset2 = null;
					keypadMicAndAccessoriesRecset = (global::AcpCommonLib.FeatureManager.GetFeature(2128) as global::Motorola.MackinawCPS.CoreFeatures.KeypadMicAndAccessories.KeypadMicAndAccessoriesRecset);
					num = (short)1305280532;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_138C:
					num = (short)608239646;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_1431:
					controlHeadO9Recset = null;
					o9DataButtonInnerRecset = null;
					controlHeadO9Recset = (global::AcpCommonLib.FeatureManager.GetFeature(4003) as global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO9.ControlHeadO9Recset);
					num = (short)1241382921;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_1484:
					num = (short)526057486;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_14FD:
					num = (short)445775929;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_15DC:
					controlHeadO3Recset = null;
					dataButtonInnerRecset = null;
					controlHeadO3Recset = (global::AcpCommonLib.FeatureManager.GetFeature(2127) as global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO3.ControlHeadO3Recset);
					num = (short)858062886;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_164D:
					num = (short)1719205940;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_16CA:
					flag = false;
					num = (short)781385745;
					num2 = (int)((global::System.IntPtr)num);
				}
				IL_B99:
				num = (short)1519452160;
				short num4 = num;
				return;
				IL_116:
				acpListField = null;
				acpListField2 = null;
				featureSectionId = self.FeatureSectionId;
				num = (short)1609302028;
				num2 = (int)((global::System.IntPtr)num);
				goto IL_27;
			}
			}
		}

		// Token: 0x06008698 RID: 34456 RVA: 0x007D238C File Offset: 0x007D058C
		public static void ConValueSetIfDataTrkIndexChanged(global::AcpCommonLib.IAcpFeatureSection self, global::AcpCommonLib.UndoRedo.ContainerTask task)
		{
			short num = (short)1787363328;
			int num2 = (int)num;
			switch (num2)
			{
			default:
			{
				switch (0)
				{
				case 0:
					goto IL_102;
				}
				int featureSectionId;
				global::AcpBusinessLayer.AcpListField acpListField;
				global::AcpBusinessLayer.AcpListField acpListField2;
				for (;;)
				{
					IL_27:
					global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO9.ControlHeadO9Recset controlHeadO9Recset;
					bool flag;
					global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO7.O7DataButtonInnerRecset o7DataButtonInnerRecset;
					global::System.Collections.Generic.IEnumerator<global::AcpBusinessLayer.FeatureNode> enumerator;
					global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO3.ControlHeadO3Recset controlHeadO3Recset;
					global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO9.O9DataButtonInnerRecset o9DataButtonInnerRecset;
					global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO3.DataButtonInnerRecset dataButtonInnerRecset;
					global::Motorola.MackinawCPS.CoreFeatures.KeypadMicAndAccessories.DataButtonInnerRecset dataButtonInnerRecset2;
					global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO7.ControlHeadO7Recset controlHeadO7Recset;
					switch (num2)
					{
					case 0:
						if (controlHeadO9Recset.Count > 0)
						{
							num = (short)453443605;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return;
					case 1:
						flag = false;
						enumerator = o7DataButtonInnerRecset.GetEnumerator();
						num = (short)1032126502;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 2:
					{
						if (featureSectionId != 10608)
						{
							num = (short)783613980;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO9.O9DataButtonInnerSection o9DataButtonInnerSection = self as global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO9.O9DataButtonInnerSection;
						acpListField = o9DataButtonInnerSection.CHO9DataButtonTrkIndex_A41416;
						acpListField2 = o9DataButtonInnerSection.RadErgCtrlHeadO9DataButtonTrkFeature_A36526;
						num = (short)2037383188;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 3:
						if (controlHeadO3Recset != null)
						{
							num = (short)346554374;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_83C;
					case 4:
					{
						if (featureSectionId != 10209)
						{
							num = (short)307232808;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						global::Motorola.MackinawCPS.CoreFeatures.KeypadMicAndAccessories.DataButtonInnerSection dataButtonInnerSection = self as global::Motorola.MackinawCPS.CoreFeatures.KeypadMicAndAccessories.DataButtonInnerSection;
						acpListField = dataButtonInnerSection.RadErgoCfgKMTrunkingKMDatatButtonIndex_A41424;
						acpListField2 = dataButtonInnerSection.RadErgoCfgKMTrunkingKMDatatButtonFeature_A22605;
						num = (short)1292173329;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 5:
						if (o9DataButtonInnerRecset != null)
						{
							num = (short)1425604660;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_4B3;
					case 6:
						dataButtonInnerRecset = (controlHeadO3Recset[0][10234].EmbeddedRecset as global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO3.DataButtonInnerRecset);
						num = (short)1776615449;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 7:
						num = (short)404815872;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 8:
						goto IL_12A4;
					case 9:
						try
						{
							num = (short)1349320707;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								switch (num2)
								{
								case 0:
								{
									global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO9.ConsolidatedActionBCOListInner consolidatedActionBCOListInner;
									if (acpListField.Value != consolidatedActionBCOListInner.ConsolidatedActionBCOListInnerSection.RadErgoControlO9ACBCOListIndex_A36668.Value)
									{
										num = (short)1275527174;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									goto IL_121B;
								}
								case 1:
									num = (short)561315840;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 2:
									goto IL_121B;
								case 3:
									switch (0)
									{
									case 0:
										goto IL_10F5;
									}
									continue;
								case 4:
								{
									global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO9.ConsolidatedActionBCOListInner consolidatedActionBCOListInner;
									if (consolidatedActionBCOListInner.ConsolidatedActionBCOListInnerSection.RadErgoControlO9ACBCOListBco_A36666.Value == 134)
									{
										num = (short)1013841921;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									break;
								}
								case 5:
									goto IL_1233;
								case 6:
								{
									global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO9.ConsolidatedActionBCOListInner consolidatedActionBCOListInner;
									task.AddTask(new global::AcpBusinessLayer.UndoRedo.ModifyRecRefDataTask(consolidatedActionBCOListInner.ConsolidatedActionBCOListInnerSection.RadErgoControlO9ACBCOListIndex_A36668, acpListField.UIValue));
									num = (short)911409159;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 7:
									goto IL_11D8;
								case 8:
								{
									if (!enumerator.MoveNext())
									{
										num = (short)2128609282;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO9.ConsolidatedActionBCOListInner consolidatedActionBCOListInner = (global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO9.ConsolidatedActionBCOListInner)enumerator.Current;
									num = (short)1980563460;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								}
								IL_11DD:
								num = (short)827129864;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								IL_10F5:
								goto IL_11DD;
								IL_121B:
								num = (short)1782120453;
								num2 = (int)((global::System.IntPtr)num);
							}
							IL_11D8:
							IL_1233:
							return;
						}
						finally
						{
							num = (short)1192689664;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								switch (num2)
								{
								case 0:
									switch (0)
									{
									case 0:
										goto IL_126A;
									}
									continue;
								case 1:
									enumerator.Dispose();
									num = (short)1859649538;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 2:
									goto IL_12A1;
								}
								IL_126A:
								if (enumerator == null)
								{
									break;
								}
								num = (short)66060289;
								num2 = (int)((global::System.IntPtr)num);
							}
							IL_12A1:;
						}
						goto IL_12A4;
					case 10:
						num = (short)1783955500;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 11:
						if (o7DataButtonInnerRecset != null)
						{
							num = (short)1443037185;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_1322;
					case 12:
					{
						num = (short)1852571648;
						short num3 = num;
						global::Motorola.MackinawCPS.CoreFeatures.KeypadMicAndAccessories.KeypadMicAndAccessoriesRecset keypadMicAndAccessoriesRecset;
						dataButtonInnerRecset2 = (keypadMicAndAccessoriesRecset[0][10228].EmbeddedRecset as global::Motorola.MackinawCPS.CoreFeatures.KeypadMicAndAccessories.DataButtonInnerRecset);
						num = (short)599326754;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 13:
						goto IL_CDF;
					case 14:
						num = (short)782499862;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 15:
						if (controlHeadO7Recset != null)
						{
							num = (short)1474887729;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_626;
					case 16:
						goto IL_797;
					case 17:
						goto IL_5A3;
					case 18:
					{
						global::Motorola.MackinawCPS.CoreFeatures.KeypadMicAndAccessories.KeypadMicAndAccessoriesRecset keypadMicAndAccessoriesRecset;
						if (keypadMicAndAccessoriesRecset != null)
						{
							num = (short)1652883468;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_892;
					}
					case 19:
					{
						if (featureSectionId != 10212)
						{
							num = (short)423493659;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO3.DataButtonInnerSection dataButtonInnerSection2 = self as global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO3.DataButtonInnerSection;
						acpListField = dataButtonInnerSection2.CHO3DataButtonTrkIndex_A41420;
						acpListField2 = dataButtonInnerSection2.CntrlHeadO3TrunkingO3DatatButtonFeature_A22597;
						num = (short)841941040;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 20:
						goto IL_5A3;
					case 21:
						enumerator = (controlHeadO9Recset[0][10622].EmbeddedRecset as global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO9.ConsolidatedActionBCOListInnerRecset).GetEnumerator();
						num = (short)703594505;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 22:
						if (acpListField2.Value == 227)
						{
							num = (short)1298595856;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return;
					case 23:
						flag = false;
						enumerator = dataButtonInnerRecset.GetEnumerator();
						num = (short)1613037604;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 24:
						goto IL_626;
					case 25:
						goto IL_83C;
					case 26:
						return;
					case 27:
						num = (short)2024603687;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 28:
						num = (short)1283915805;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 29:
					{
						if (featureSectionId != 10713)
						{
							num = (short)378208266;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO7.O7DataButtonInnerSection o7DataButtonInnerSection = self as global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO7.O7DataButtonInnerSection;
						acpListField = o7DataButtonInnerSection.CHO7DataButtonTrkIndex_A41418;
						acpListField2 = o7DataButtonInnerSection.RadErgCtrlHeadO7DataButtonTrkFeature_A41297;
						num = (short)947781678;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 30:
						if (acpListField2.Value != 134)
						{
							num = (short)402980878;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_797;
					case 31:
						if (dataButtonInnerRecset2 != null)
						{
							num = (short)782762026;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_444;
					case 32:
					{
						if (acpListField == null)
						{
							num = (short)208732186;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						global::Motorola.MackinawCPS.CoreFeatures.KeypadMicAndAccessories.KeypadMicAndAccessoriesRecset keypadMicAndAccessoriesRecset = null;
						dataButtonInnerRecset2 = null;
						keypadMicAndAccessoriesRecset = (global::AcpCommonLib.FeatureManager.GetFeature(2128) as global::Motorola.MackinawCPS.CoreFeatures.KeypadMicAndAccessories.KeypadMicAndAccessoriesRecset);
						num = (short)414318610;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 33:
						if (dataButtonInnerRecset != null)
						{
							num = (short)1473183767;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_161E;
					case 34:
						goto IL_892;
					case 35:
						try
						{
							num = (short)2043478023;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								switch (num2)
								{
								case 0:
									num = (short)181796868;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 1:
								{
									global::AcpCommonLib.IAcpFeatureNode acpFeatureNode;
									if (acpListField.Value != (acpFeatureNode[10608] as global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO9.O9DataButtonInnerSection).CHO9DataButtonConvIndex_A41414.Value)
									{
										num = (short)1420361740;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									goto IL_E03;
								}
								case 2:
								{
									if (!enumerator.MoveNext())
									{
										num = (short)34799627;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									global::AcpCommonLib.IAcpFeatureNode acpFeatureNode = enumerator.Current;
									num = (short)1109786625;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 3:
									goto IL_E03;
								case 4:
									goto IL_EF5;
								case 5:
									if (flag)
									{
										num = (short)1764491264;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									break;
								case 6:
								{
									global::AcpCommonLib.IAcpFeatureNode acpFeatureNode;
									if (acpListField.Value != (acpFeatureNode[10608] as global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO9.O9DataButtonInnerSection).CHO9DataButtonTrkIndex_A41416.Value)
									{
										num = (short)1735065609;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									goto IL_EA3;
								}
								case 7:
									switch (0)
									{
									case 0:
										goto IL_D78;
									}
									continue;
								case 8:
									goto IL_F78;
								case 9:
								{
									global::AcpCommonLib.IAcpFeatureNode acpFeatureNode;
									task.AddTask(new global::AcpBusinessLayer.UndoRedo.ModifyRecRefDataTask((acpFeatureNode[10608] as global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO9.O9DataButtonInnerSection).CHO9DataButtonTrkIndex_A41416, acpListField.UIValue));
									flag = true;
									num = (short)1809645578;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 10:
									goto IL_EA3;
								case 11:
									num = (short)1033699336;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 12:
								{
									global::AcpCommonLib.IAcpFeatureNode acpFeatureNode;
									task.AddTask(new global::AcpBusinessLayer.UndoRedo.ModifyRecRefDataTask((acpFeatureNode[10608] as global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO9.O9DataButtonInnerSection).CHO9DataButtonConvIndex_A41414, acpListField.UIValue));
									flag = true;
									num = (short)27852803;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								}
								IL_DC2:
								num = (short)1686175746;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								IL_D78:
								goto IL_DC2;
								IL_E03:
								num = (short)1377304582;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								IL_EA3:
								num = (short)2090074117;
								num2 = (int)((global::System.IntPtr)num);
							}
							IL_EF5:
							IL_F78:
							goto IL_4B3;
						}
						finally
						{
							num = (short)564461568;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								switch (num2)
								{
								case 0:
									switch (0)
									{
									case 0:
										goto IL_FB0;
									}
									continue;
								case 1:
									enumerator.Dispose();
									num = (short)1026424834;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 2:
									goto IL_FE7;
								}
								IL_FB0:
								if (enumerator == null)
								{
									break;
								}
								num = (short)1215889409;
								num2 = (int)((global::System.IntPtr)num);
							}
							IL_FE7:;
						}
						goto IL_FEA;
					case 36:
						try
						{
							num = (short)784334852;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								switch (num2)
								{
								case 0:
								{
									global::AcpCommonLib.IAcpFeatureNode acpFeatureNode2;
									task.AddTask(new global::AcpBusinessLayer.UndoRedo.ModifyRecRefDataTask((acpFeatureNode2[10212] as global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO3.DataButtonInnerSection).CHO3DataButtonTrkIndex_A41420, acpListField.UIValue));
									flag = true;
									num = (short)1553858571;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 1:
									goto IL_15AD;
								case 2:
									goto IL_148A;
								case 3:
								{
									if (!enumerator.MoveNext())
									{
										num = (short)237043719;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									global::AcpCommonLib.IAcpFeatureNode acpFeatureNode2 = enumerator.Current;
									num = (short)929300488;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 4:
									switch (0)
									{
									case 0:
										goto IL_13B8;
									}
									continue;
								case 5:
								{
									global::AcpCommonLib.IAcpFeatureNode acpFeatureNode2;
									if (acpListField.Value != (acpFeatureNode2[10212] as global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO3.DataButtonInnerSection).CHO3DataButtonTrkIndex_A41420.Value)
									{
										num = (short)1963589632;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									goto IL_148F;
								}
								case 6:
								{
									global::AcpCommonLib.IAcpFeatureNode acpFeatureNode2;
									task.AddTask(new global::AcpBusinessLayer.UndoRedo.ModifyRecRefDataTask((acpFeatureNode2[10212] as global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO3.DataButtonInnerSection).CHO3DataButtonConvIndex_A41419, acpListField.UIValue));
									flag = true;
									num = (short)1824063500;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 7:
									num = (short)1131216897;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 8:
								{
									global::AcpCommonLib.IAcpFeatureNode acpFeatureNode2;
									if (acpListField.Value != (acpFeatureNode2[10212] as global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO3.DataButtonInnerSection).CHO3DataButtonConvIndex_A41419.Value)
									{
										num = (short)677642246;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									goto IL_141C;
								}
								case 9:
									num = (short)1869217794;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 10:
									if (flag)
									{
										num = (short)499777545;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									break;
								case 11:
									goto IL_148F;
								case 12:
									goto IL_141C;
								}
								goto IL_13B8;
								IL_141C:
								num = (short)748879877;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								IL_148F:
								num = (short)1817378826;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								IL_1556:
								num = (short)1552809987;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								IL_13B8:
								goto IL_1556;
							}
							IL_148A:
							IL_15AD:;
						}
						finally
						{
							num = (short)1440874496;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								switch (num2)
								{
								case 0:
									switch (0)
									{
									case 0:
										goto IL_15E3;
									}
									continue;
								case 1:
									enumerator.Dispose();
									num = (short)1034682370;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 2:
									goto IL_161B;
								}
								IL_15E3:
								if (enumerator == null)
								{
									break;
								}
								num = (short)1945894913;
								num2 = (int)((global::System.IntPtr)num);
							}
							IL_161B:;
						}
						goto IL_161E;
					case 37:
						if (controlHeadO9Recset != null)
						{
							num = (short)173015047;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return;
					case 38:
						try
						{
							num = (short)675282951;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								switch (num2)
								{
								case 0:
								{
									global::AcpCommonLib.IAcpFeatureNode acpFeatureNode3;
									task.AddTask(new global::AcpBusinessLayer.UndoRedo.ModifyRecRefDataTask((acpFeatureNode3[10713] as global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO7.O7DataButtonInnerSection).CHO7DataButtonConvIndex_A41417, acpListField.UIValue));
									flag = true;
									num = (short)2079391756;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 1:
								{
									global::AcpCommonLib.IAcpFeatureNode acpFeatureNode3;
									task.AddTask(new global::AcpBusinessLayer.UndoRedo.ModifyRecRefDataTask((acpFeatureNode3[10713] as global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO7.O7DataButtonInnerSection).CHO7DataButtonTrkIndex_A41418, acpListField.UIValue));
									flag = true;
									num = (short)854786051;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 2:
									if (flag)
									{
										num = (short)350486539;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									break;
								case 3:
									goto IL_1F3;
								case 4:
								{
									global::AcpCommonLib.IAcpFeatureNode acpFeatureNode3;
									if (acpListField.Value != (acpFeatureNode3[10713] as global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO7.O7DataButtonInnerSection).CHO7DataButtonTrkIndex_A41418.Value)
									{
										num = (short)1058144257;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									goto IL_1F3;
								}
								case 5:
								{
									global::AcpCommonLib.IAcpFeatureNode acpFeatureNode3;
									if (acpListField.Value != (acpFeatureNode3[10713] as global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO7.O7DataButtonInnerSection).CHO7DataButtonConvIndex_A41417.Value)
									{
										num = (short)813826048;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									goto IL_311;
								}
								case 6:
								{
									if (!enumerator.MoveNext())
									{
										num = (short)245563401;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									global::AcpCommonLib.IAcpFeatureNode acpFeatureNode3 = enumerator.Current;
									num = (short)2046164997;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 7:
									switch (0)
									{
									case 0:
										goto IL_1D3;
									}
									continue;
								case 8:
									goto IL_3CF;
								case 9:
									num = (short)679411720;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 10:
									goto IL_1EE;
								case 11:
									num = (short)1744109578;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 12:
									goto IL_311;
								}
								goto IL_1D3;
								IL_1F3:
								num = (short)779288578;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								IL_227:
								num = (short)23461894;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								IL_1D3:
								goto IL_227;
								IL_311:
								num = (short)848560132;
								num2 = (int)((global::System.IntPtr)num);
							}
							IL_1EE:
							IL_3CF:
							goto IL_1322;
						}
						finally
						{
							num = (short)1005780993;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								switch (num2)
								{
								case 0:
									enumerator.Dispose();
									num = (short)884801538;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 1:
									switch (0)
									{
									case 0:
										goto IL_407;
									}
									continue;
								case 2:
									goto IL_441;
								}
								IL_407:
								if (enumerator == null)
								{
									break;
								}
								num = (short)532545536;
								num2 = (int)((global::System.IntPtr)num);
							}
							IL_441:;
						}
						goto IL_444;
					case 39:
						goto IL_5A3;
					case 40:
						num = (short)309067795;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 41:
						try
						{
							num = (short)635961351;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								switch (num2)
								{
								case 0:
								{
									global::AcpCommonLib.IAcpFeatureNode acpFeatureNode4;
									task.AddTask(new global::AcpBusinessLayer.UndoRedo.ModifyRecRefDataTask((acpFeatureNode4[10209] as global::Motorola.MackinawCPS.CoreFeatures.KeypadMicAndAccessories.DataButtonInnerSection).RadErgoCfgKMTrunkingKMDatatButtonIndex_A41424, acpListField.UIValue));
									flag = true;
									num = (short)190119946;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 1:
								{
									if (!enumerator.MoveNext())
									{
										num = (short)1321992204;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									global::AcpCommonLib.IAcpFeatureNode acpFeatureNode4 = enumerator.Current;
									num = (short)1600782338;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 2:
								{
									global::AcpCommonLib.IAcpFeatureNode acpFeatureNode4;
									if (acpListField.Value != (acpFeatureNode4[10209] as global::Motorola.MackinawCPS.CoreFeatures.KeypadMicAndAccessories.DataButtonInnerSection).RadErgoCfgKMConventionalKMDatatButtonIndex_A41423.Value)
									{
										num = (short)1476001803;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									goto IL_B29;
								}
								case 3:
									num = (short)1872363526;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 4:
									goto IL_B29;
								case 5:
								{
									global::AcpCommonLib.IAcpFeatureNode acpFeatureNode4;
									if (acpListField.Value != (acpFeatureNode4[10209] as global::Motorola.MackinawCPS.CoreFeatures.KeypadMicAndAccessories.DataButtonInnerSection).RadErgoCfgKMTrunkingKMDatatButtonIndex_A41424.Value)
									{
										num = (short)1204486144;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									goto IL_AEF;
								}
								case 6:
									goto IL_AEA;
								case 7:
									switch (0)
									{
									case 0:
										goto IL_A27;
									}
									continue;
								case 8:
									goto IL_C6B;
								case 9:
									if (flag)
									{
										num = (short)1808531459;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									break;
								case 10:
									goto IL_A6B;
								case 11:
								{
									global::AcpCommonLib.IAcpFeatureNode acpFeatureNode4;
									task.AddTask(new global::AcpBusinessLayer.UndoRedo.ModifyRecRefDataTask((acpFeatureNode4[10209] as global::Motorola.MackinawCPS.CoreFeatures.KeypadMicAndAccessories.DataButtonInnerSection).RadErgoCfgKMConventionalKMDatatButtonIndex_A41423, acpListField.UIValue));
									flag = true;
									num = (short)74514436;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 12:
								{
									num = (short)971863401;
									short num4 = num;
									num = (short)681604457;
									switch ((num4 == num) ? 1 : 0)
									{
									case 0:
									case 2:
										goto IL_A6B;
									default:
										num = (short)1951531008;
										if (num != 0)
										{
										}
										num = (short)1064173576;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									break;
								}
								}
								goto IL_A27;
								IL_AEF:
								num = (short)64225289;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								IL_A6B:
								goto IL_AEF;
								IL_B29:
								num = (short)1865023493;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								IL_BC9:
								num = (short)2105999361;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								IL_A27:
								goto IL_BC9;
							}
							IL_AEA:
							IL_C6B:
							goto IL_444;
						}
						finally
						{
							num = (short)520814593;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								switch (num2)
								{
								case 0:
									enumerator.Dispose();
									num = (short)173670402;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 1:
									switch (0)
									{
									case 0:
										goto IL_CA4;
									}
									continue;
								case 2:
									goto IL_CDC;
								}
								IL_CA4:
								if (enumerator == null)
								{
									break;
								}
								num = (short)2096562176;
								num2 = (int)((global::System.IntPtr)num);
							}
							IL_CDC:;
						}
						goto IL_CDF;
					case 42:
						goto IL_FEA;
					case 43:
						if (featureSectionId <= 10212)
						{
							num = (short)567279617;
							if (num != 0)
							{
							}
							num = (short)500105263;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)1373700098;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 44:
						goto IL_5A3;
					case 45:
						if (acpListField2 != null)
						{
							num = (short)1901264946;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return;
					case 46:
						goto IL_5A3;
					case 47:
						num = (short)1832583172;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 48:
						goto IL_5A3;
					case 49:
						o7DataButtonInnerRecset = (controlHeadO7Recset[0][10717].EmbeddedRecset as global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO7.O7DataButtonInnerRecset);
						num = (short)778764312;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 50:
						num = (short)366149662;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 51:
						if (controlHeadO9Recset != null)
						{
							num = (short)679018504;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_CDF;
					case 52:
						flag = false;
						enumerator = o9DataButtonInnerRecset.GetEnumerator();
						num = (short)586154019;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_102;
					IL_444:
					num = (short)1439563809;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_4B3:
					num = (short)1919287341;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_5A3:
					num = (short)1943994400;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_626:
					controlHeadO9Recset = null;
					o9DataButtonInnerRecset = null;
					controlHeadO9Recset = (global::AcpCommonLib.FeatureManager.GetFeature(4003) as global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO9.ControlHeadO9Recset);
					num = (short)913965107;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_797:
					num = (short)1616773157;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_83C:
					controlHeadO7Recset = null;
					o7DataButtonInnerRecset = null;
					controlHeadO7Recset = (global::AcpCommonLib.FeatureManager.GetFeature(4114) as global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO7.ControlHeadO7Recset);
					num = (short)194117647;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_892:
					controlHeadO3Recset = null;
					dataButtonInnerRecset = null;
					controlHeadO3Recset = (global::AcpCommonLib.FeatureManager.GetFeature(2127) as global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO3.ControlHeadO3Recset);
					num = (short)752418819;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_CDF:
					flag = false;
					num = (short)1289355295;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_FEA:
					enumerator = dataButtonInnerRecset2.GetEnumerator();
					num = (short)453836841;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_12A4:
					o9DataButtonInnerRecset = (controlHeadO9Recset[0][10611].EmbeddedRecset as global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO9.O9DataButtonInnerRecset);
					num = (short)989986829;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_1322:
					num = (short)1197932549;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_161E:
					num = (short)991428619;
					num2 = (int)((global::System.IntPtr)num);
				}
				return;
				IL_102:
				acpListField = null;
				acpListField2 = null;
				featureSectionId = self.FeatureSectionId;
				num = (short)1400635435;
				num2 = (int)((global::System.IntPtr)num);
				goto IL_27;
			}
			}
		}

		// Token: 0x06008699 RID: 34457 RVA: 0x007D3AB8 File Offset: 0x007D1CB8
		internal static bool ConDataButtonIndexValid(global::AcpCommonLib.IAcpFeatureSection self, int index)
		{
			short num = (short)1043267584;
			int num2 = (int)num;
			switch (num2)
			{
			default:
			{
				switch (0)
				{
				case 0:
					goto IL_3C;
				}
				bool result;
				global::Motorola.MackinawCPS.CoreFeatures.ActionConsolidation.ActionConsolidationRecset actionConsolidationRecset;
				for (;;)
				{
					IL_29:
					global::System.Collections.Generic.IEnumerator<global::AcpBusinessLayer.FeatureNode> enumerator;
					switch (num2)
					{
					case 0:
						return false;
					case 1:
						try
						{
							num = (short)2031222840;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								global::AcpCommonLib.IAcpFeatureNode acpFeatureNode;
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
									if (!enumerator.MoveNext())
									{
										num = (short)250216496;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									acpFeatureNode = enumerator.Current;
									num = (short)1747451925;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 1:
								{
									global::Motorola.MackinawCPS.CoreFeatures.RadioWide.RadioWideRecset radioWideRecset;
									if (radioWideRecset != null)
									{
										num = (short)258801707;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									goto IL_591;
								}
								case 2:
									flag = false;
									goto IL_4D8;
								case 3:
									if (flag2)
									{
										num = (short)1327497260;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									num = (short)294846476;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 4:
								{
									global::Motorola.MackinawCPS.CoreFeatures.RadioWide.GeneralLightbarPatternInnerRecset generalLightbarPatternInnerRecset;
									int num3;
									if (generalLightbarPatternInnerRecset.Count > num3)
									{
										num = (short)819200014;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									goto IL_591;
								}
								case 5:
									flag3 = false;
									goto IL_B0C;
								case 6:
								{
									global::Motorola.MackinawCPS.CoreFeatures.RadioWide.GeneralLightbarPatternInner generalLightbarPatternInner;
									global::Motorola.MackinawCPS.CoreFeatures.RadioWide.GeneralLightbarPatternInnerSection generalLightbarPatternInnerSection = generalLightbarPatternInner.GeneralLightbarPatternInnerSection;
									flag2 = (generalLightbarPatternInnerSection.RadWideGenLightBarPatternRelay1_A36506.Value == 3);
									num = (short)544079906;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 7:
									if (flag2)
									{
										num = (short)485752874;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									num = (short)1876033555;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 8:
									if (flag2)
									{
										num = (short)582942771;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									num = (short)341966873;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 9:
								{
									global::Motorola.MackinawCPS.CoreFeatures.RadioWide.GeneralLightbarPatternInnerRecset generalLightbarPatternInnerRecset;
									int num3;
									if (generalLightbarPatternInnerRecset[num3] != null)
									{
										num = (short)1438187578;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									goto IL_591;
								}
								case 10:
								{
									global::Motorola.MackinawCPS.CoreFeatures.RadioWide.GeneralLightbarPatternInner generalLightbarPatternInner;
									if (generalLightbarPatternInner != null)
									{
										num = (short)468779014;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									goto IL_591;
								}
								case 12:
									flag4 = false;
									goto IL_7F8;
								case 13:
									num = (short)1735524409;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 14:
									num = (short)209256457;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 16:
									if ((acpFeatureNode[10615] as global::Motorola.MackinawCPS.CoreFeatures.ActionConsolidation.General).RadioErgoConfigACActionType_A42871.Value == 0)
									{
										num = (short)9961509;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									goto IL_570;
								case 18:
									if (flag2)
									{
										num = (short)310509618;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									num = (short)605945909;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 19:
									flag5 = false;
									goto IL_3D8;
								case 20:
								{
									global::Motorola.MackinawCPS.CoreFeatures.RadioWide.GeneralLightbarPatternInnerSection generalLightbarPatternInnerSection;
									flag6 = (generalLightbarPatternInnerSection.RadWideGenLightBarPatternRelay9_A36515.Value == 3);
									goto IL_A67;
								}
								case 21:
									if (index - 1 == (acpFeatureNode.Parent as global::AcpBusinessLayer.Recordset).IndexOf(acpFeatureNode))
									{
										num = (short)813891648;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									break;
								case 22:
									num = (short)1455554601;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 23:
								{
									global::Motorola.MackinawCPS.CoreFeatures.RadioWide.GeneralLightbarPatternInnerSection generalLightbarPatternInnerSection;
									flag7 = (generalLightbarPatternInnerSection.RadWideGenLightBarPatternRelay3_A36508.Value == 3);
									goto IL_8A1;
								}
								case 24:
									goto IL_764;
								case 25:
									flag7 = false;
									goto IL_8A1;
								case 26:
								{
									global::Motorola.MackinawCPS.CoreFeatures.RadioWide.GeneralLightbarPatternInnerSection generalLightbarPatternInnerSection;
									flag8 = (generalLightbarPatternInnerSection.RadWideGenLightBarPatternRelay2_A36507.Value == 3);
									goto IL_9BE;
								}
								case 27:
									flag9 = false;
									goto IL_836;
								case 28:
									num = (short)646316071;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 29:
								{
									if ((acpFeatureNode[10615] as global::Motorola.MackinawCPS.CoreFeatures.ActionConsolidation.General).RadioErgoConfigACRelayPattern_A36582.Value <= 0)
									{
										num = (short)585826334;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									int num3 = (acpFeatureNode[10615] as global::Motorola.MackinawCPS.CoreFeatures.ActionConsolidation.General).RadioErgoConfigACRelayPattern_A36582.Value - 1;
									flag2 = false;
									global::Motorola.MackinawCPS.CoreFeatures.RadioWide.RadioWideRecset radioWideRecset = global::AcpCommonLib.FeatureManager.GetFeature(2045) as global::Motorola.MackinawCPS.CoreFeatures.RadioWide.RadioWideRecset;
									num = (short)1461911553;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 30:
									result = false;
									num = (short)508493841;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 31:
									goto IL_465;
								case 32:
									if (flag2)
									{
										num = (short)341377046;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									num = (short)888864795;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 33:
								{
									global::Motorola.MackinawCPS.CoreFeatures.RadioWide.GeneralLightbarPatternInnerSection generalLightbarPatternInnerSection;
									flag4 = (generalLightbarPatternInnerSection.RadWideGenLightBarPatternRelay8_A36513.Value == 3);
									goto IL_7F8;
								}
								case 34:
									if (flag2)
									{
										num = (short)407699491;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									num = (short)1890779198;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 35:
									num = (short)1087832090;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 36:
									num = (short)1169162260;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 37:
									num = (short)1382547480;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 38:
									goto IL_B64;
								case 39:
								{
									global::Motorola.MackinawCPS.CoreFeatures.RadioWide.GeneralLightbarPatternInnerSection generalLightbarPatternInnerSection;
									flag3 = (generalLightbarPatternInnerSection.RadWideGenLightBarPatternRelay6_A36511.Value == 3);
									goto IL_B0C;
								}
								case 40:
									goto IL_591;
								case 41:
								{
									global::Motorola.MackinawCPS.CoreFeatures.RadioWide.GeneralLightbarPatternInnerSection generalLightbarPatternInnerSection;
									flag9 = (generalLightbarPatternInnerSection.RadWideGenLightBarPatternRelay5_A36510.Value == 3);
									goto IL_836;
								}
								case 42:
									num = (short)688980027;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 43:
								{
									global::Motorola.MackinawCPS.CoreFeatures.RadioWide.RadioWideRecset radioWideRecset;
									global::Motorola.MackinawCPS.CoreFeatures.RadioWide.GeneralLightbarPatternInnerRecset generalLightbarPatternInnerRecset = radioWideRecset[0][10604].EmbeddedRecset as global::Motorola.MackinawCPS.CoreFeatures.RadioWide.GeneralLightbarPatternInnerRecset;
									num = (short)1382678532;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 44:
									num = (short)1843724321;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 45:
								{
									global::Motorola.MackinawCPS.CoreFeatures.RadioWide.GeneralLightbarPatternInnerSection generalLightbarPatternInnerSection;
									flag10 = (generalLightbarPatternInnerSection.RadWideGenLightBarPatternRelay4_A36509.Value == 3);
									goto IL_9FC;
								}
								case 46:
									num = (short)536084527;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 47:
									if ((acpFeatureNode[10615] as global::Motorola.MackinawCPS.CoreFeatures.ActionConsolidation.General).RadioErgoConfigACSirenType_A36584.Value != 1)
									{
										num = (short)454492173;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									goto IL_465;
								case 48:
									num = (short)1868103718;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 49:
									if (flag2)
									{
										num = (short)1126367292;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									num = (short)1589051394;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 50:
									num = (short)616169517;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 51:
									num = (short)867631127;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 52:
									if (flag2)
									{
										num = (short)1044119580;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									num = (short)784596997;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 53:
									flag10 = false;
									goto IL_9FC;
								case 54:
									if (flag2)
									{
										num = (short)1623261220;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									num = (short)1294008375;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 55:
									flag6 = false;
									goto IL_A67;
								case 56:
									switch (0)
									{
									case 0:
										goto IL_1D7;
									}
									continue;
								case 57:
									if ((acpFeatureNode[10615] as global::Motorola.MackinawCPS.CoreFeatures.ActionConsolidation.General).RadioErgoConfigACSirenType_A36584.Value == 7)
									{
										num = (short)1914568735;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									result = false;
									num = (short)2072838159;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 58:
								{
									global::Motorola.MackinawCPS.CoreFeatures.RadioWide.GeneralLightbarPatternInnerRecset generalLightbarPatternInnerRecset;
									int num3;
									global::Motorola.MackinawCPS.CoreFeatures.RadioWide.GeneralLightbarPatternInner generalLightbarPatternInner = generalLightbarPatternInnerRecset[num3] as global::Motorola.MackinawCPS.CoreFeatures.RadioWide.GeneralLightbarPatternInner;
									num = (short)1161363466;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 59:
								{
									global::Motorola.MackinawCPS.CoreFeatures.RadioWide.GeneralLightbarPatternInnerSection generalLightbarPatternInnerSection;
									flag5 = (generalLightbarPatternInnerSection.RadWideGenLightBarPatternRelay10_A36516.Value == 3);
									goto IL_3D8;
								}
								case 60:
									num = (short)866910269;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 61:
								{
									global::Motorola.MackinawCPS.CoreFeatures.RadioWide.GeneralLightbarPatternInnerSection generalLightbarPatternInnerSection;
									flag = (generalLightbarPatternInnerSection.RadWideGenLightBarPatternRelay7_A36512.Value == 3);
									goto IL_4D8;
								}
								case 62:
									flag8 = false;
									goto IL_9BE;
								case 63:
								{
									num = (short)428748344;
									short num4 = num;
									num = (short)1632448056;
									switch ((num4 == num) ? 1 : 0)
									{
									case 0:
									case 2:
										goto IL_764;
									default:
										num = (short)1723400192;
										if (num != 0)
										{
										}
										break;
									}
									break;
								}
								case 64:
									num = (short)1943666704;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								goto IL_1D7;
								IL_3D8:
								flag2 = flag5;
								num = (short)1854668840;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								IL_424:
								num = (short)367198208;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								IL_1D7:
								goto IL_424;
								IL_465:
								num = (short)1903034397;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								IL_4D8:
								flag2 = flag;
								num = (short)1275068419;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								IL_570:
								result = false;
								num = (short)1606811659;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								IL_764:
								if ((acpFeatureNode[10615] as global::Motorola.MackinawCPS.CoreFeatures.ActionConsolidation.General).RadioErgoConfigACGeneralActionAllowed_A36579.Value)
								{
									num = (short)1694695470;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								goto IL_570;
								IL_591:
								result = flag2;
								num = (short)347406399;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								IL_7F8:
								flag2 = flag4;
								num = (short)710344758;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								IL_836:
								flag2 = flag9;
								num = (short)475004980;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								IL_8A1:
								flag2 = flag7;
								num = (short)1499463698;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								IL_9BE:
								flag2 = flag8;
								num = (short)269025288;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								IL_9FC:
								flag2 = flag10;
								num = (short)545128480;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								IL_A67:
								flag2 = flag6;
								num = (short)1759248391;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								IL_B0C:
								flag2 = flag3;
								num = (short)2115829809;
								num2 = (int)((global::System.IntPtr)num);
							}
							IL_B64:
							return result;
						}
						finally
						{
							num = (short)3407874;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								switch (num2)
								{
								case 0:
									enumerator.Dispose();
									num = (short)802553857;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 1:
									goto IL_BD4;
								case 2:
									switch (0)
									{
									case 0:
										goto IL_B9C;
									}
									continue;
								}
								IL_B9C:
								if (enumerator == null)
								{
									break;
								}
								num = (short)724697088;
								num2 = (int)((global::System.IntPtr)num);
							}
							IL_BD4:;
						}
						goto IL_BD7;
					case 2:
						if (index == 0)
						{
							num = (short)344260608;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_BD7;
					}
					goto IL_3C;
					IL_BD7:
					num = (short)1177616385;
					if (num != 0)
					{
					}
					enumerator = actionConsolidationRecset.GetEnumerator();
					num = (short)1269497857;
					num2 = (int)((global::System.IntPtr)num);
				}
				return false;
				IL_3C:
				num = (short)4718592;
				short num5 = num;
				actionConsolidationRecset = (global::AcpCommonLib.FeatureManager.GetFeature(4008) as global::Motorola.MackinawCPS.CoreFeatures.ActionConsolidation.ActionConsolidationRecset);
				result = true;
				num = (short)1415249922;
				num2 = (int)((global::System.IntPtr)num);
				goto IL_29;
			}
			}
		}

		// Token: 0x0600869A RID: 34458 RVA: 0x007D4708 File Offset: 0x007D2908
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
						num2 = (short)2136473625;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					num2 = (short)536412167;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 1:
					if (featureSectionId <= 10212)
					{
						num2 = (short)1188233235;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					num2 = (short)1862270981;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 2:
					goto IL_58A;
				case 3:
					goto IL_443;
				case 4:
					if (featureSectionId != 10209)
					{
						num2 = (short)1925513240;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					acpListField = (self as global::Motorola.MackinawCPS.CoreFeatures.KeypadMicAndAccessories.DataButtonInnerSection).RadErgoCfgKMConventionalKMDatatButtonFeature_A22603;
					num2 = (short)568393751;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 5:
					if (featureSectionId != 10608)
					{
						num2 = (short)1328939021;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					acpListField = (self as global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO9.O9DataButtonInnerSection).RadErgCtrlHeadO9DataButtonCnvFeature_A36528;
					num2 = (short)1783234575;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 6:
				{
					num2 = (short)1311571968;
					short num3 = num2;
					num2 = (short)1663303680;
					num = (int)((global::System.IntPtr)num2);
					continue;
				}
				case 7:
					if (acpListField.Value == 140)
					{
						num2 = (short)1478230018;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					num2 = (short)713687066;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 8:
					num2 = (short)2084438036;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 9:
					if (acpListField != null)
					{
						num2 = (short)1751318534;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					return true;
				case 10:
					if (index != 227)
					{
						num2 = (short)532611084;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					return false;
				case 11:
					num2 = (short)1294401568;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 12:
					goto IL_229;
				case 13:
					num2 = (short)1193476112;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 14:
					num2 = (short)1858338833;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 15:
					goto IL_443;
				case 16:
					goto IL_361;
				case 17:
					goto IL_443;
				case 18:
				{
					num2 = (short)275253895;
					short num4 = num2;
					num2 = (short)1010764423;
					switch ((num4 == num2) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_361;
					default:
						goto IL_1CE;
					}
					break;
				}
				case 19:
					num2 = (short)474152964;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 20:
					if (index != 228)
					{
						num2 = (short)872087563;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					return false;
				case 21:
					if (radioWide.DualRadio.RadWideDualRadioSelection_A42236.Value != 0)
					{
						num2 = (short)2088370210;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					num2 = (short)1975648286;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 22:
					num2 = (short)1913782293;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 23:
					goto IL_443;
				case 24:
					num2 = (short)201916444;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 25:
					goto IL_2DD;
				case 26:
					if (acpListField.Value == 228)
					{
						num2 = (short)2048393238;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					num2 = (short)84607005;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 27:
					goto IL_443;
				case 28:
					if (featureSectionId != 10212)
					{
						num2 = (short)769589281;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					acpListField = (self as global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO3.DataButtonInnerSection).CntrlHeadO3ConventionalO3DatatButtonFeature_A22595;
					num2 = (short)559480867;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 29:
					if (radioWide.DualRadio.RadWideDualRadioSelection_A42236.Value != 0)
					{
						num2 = (short)598343688;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					num2 = (short)1054867466;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 30:
					if (index != 227)
					{
						num2 = (short)1824915474;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					return false;
				case 31:
					goto IL_3ED;
				case 32:
					if (index != 227)
					{
						num2 = (short)1425670175;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					return false;
				case 33:
					num2 = (short)1917386779;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 34:
					goto IL_12D;
				case 35:
					goto IL_443;
				}
				goto IL_A0;
				IL_361:
				if (featureSectionId != 10713)
				{
					num2 = (short)991363086;
					num = (int)((global::System.IntPtr)num2);
					continue;
				}
				acpListField = (self as global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO7.O7DataButtonInnerSection).RadErgCtrlHeadO7DataButtonCnvFeature_A41299;
				num2 = (short)1365180419;
				num = (int)((global::System.IntPtr)num2);
				continue;
				IL_443:
				radioWide = (global::AcpCommonLib.FeatureManager.GetFeature(2045)[0] as global::Motorola.MackinawCPS.CoreFeatures.RadioWide.RadioWide);
				num2 = (short)68222985;
				num = (int)((global::System.IntPtr)num2);
			}
			return false;
			IL_12D:
			return index == 228;
			IL_1CE:
			num2 = (short)276758528;
			if (num2 != 0)
			{
			}
			return index != 140;
			IL_229:
			return index != 140;
			IL_2DD:
			return index == 227;
			IL_3ED:
			return index != 140;
			IL_58A:
			num2 = (short)47448065;
			if (num2 != 0)
			{
			}
			return index == 140;
			IL_A0:
			acpListField = null;
			featureSectionId = self.FeatureSectionId;
			num2 = (short)807731201;
			num = (int)((global::System.IntPtr)num2);
			goto IL_0A;
		}

		// Token: 0x0600869B RID: 34459 RVA: 0x007D4D60 File Offset: 0x007D2F60
		internal static void ConMFKButtonBehaviorToShepherds(global::AcpCommonLib.IAcpFeatureSection self, global::AcpCommonLib.UndoRedo.ContainerTask task)
		{
			short num = (short)408354816;
			int num2 = (int)num;
			switch (num2)
			{
			default:
			{
				switch (0)
				{
				case 0:
					goto IL_76;
				}
				global::AcpBusinessLayer.AcpListField radErgoControlO2MFKButtonPress_A;
				global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO7.O7MultiFunctionKnob o7MultiFunctionKnob;
				global::AcpBusinessLayer.AcpListField radErgoControlO7MFKButtonPress_A;
				for (;;)
				{
					IL_27:
					global::Motorola.MackinawCPS.CoreFeatures.Shepherds.ShepherdsRecset shepherdsRecset;
					int featureSectionId;
					switch (num2)
					{
					case 0:
						goto IL_130;
					case 1:
					{
						global::Motorola.MackinawCPS.CoreFeatures.Shepherds.SignalIndependentProductIndependentNonProgrammableButtonListInnerRecset signalIndependentProductIndependentNonProgrammableButtonListInnerRecset = shepherdsRecset[0][10031].EmbeddedRecset as global::Motorola.MackinawCPS.CoreFeatures.Shepherds.SignalIndependentProductIndependentNonProgrammableButtonListInnerRecset;
						num = (short)177209348;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 2:
						num = (short)1417019398;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 3:
						if (global::ConstraintHelper.UtilityMack.IsMobile())
						{
							num = (short)834600976;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return;
					case 4:
					{
						global::Motorola.MackinawCPS.CoreFeatures.Shepherds.SignalIndependentProductIndependentNonProgrammableButtonListInnerRecset signalIndependentProductIndependentNonProgrammableButtonListInnerRecset;
						if (signalIndependentProductIndependentNonProgrammableButtonListInnerRecset != null)
						{
							num = (short)657850376;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return;
					}
					case 5:
					{
						if (featureSectionId == 10721)
						{
							num = (short)833093642;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						int value = radErgoControlO2MFKButtonPress_A.Value;
						num = (short)1992228876;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 6:
						if (shepherdsRecset[0] != null)
						{
							num = (short)1111097345;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return;
					case 7:
						if (shepherdsRecset != null)
						{
							num = (short)61407234;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return;
					case 8:
					{
						global::Motorola.MackinawCPS.CoreFeatures.Shepherds.SignalIndependentProductIndependentNonProgrammableButtonListInnerRecset signalIndependentProductIndependentNonProgrammableButtonListInnerRecset;
						global::System.Collections.Generic.IEnumerator<global::AcpBusinessLayer.FeatureNode> enumerator = signalIndependentProductIndependentNonProgrammableButtonListInnerRecset.GetEnumerator();
						num = (short)1790771215;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 9:
						if (o7MultiFunctionKnob.RefRadioWide.Labtool.RadWideLabtoolMFKEmergencyAccess_A42216.Value)
						{
							num = (short)1253572621;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return;
					case 10:
					{
						int value = radErgoControlO2MFKButtonPress_A.Value;
						task.AddTask(new global::AcpBusinessLayer.UndoRedo.ModifyDataTask<int>(radErgoControlO7MFKButtonPress_A, value));
						num = (short)1231814667;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 11:
					{
						num = (short)1277362177;
						if (num != 0)
						{
						}
						num = (short)557711360;
						short num3 = num;
						goto IL_130;
					}
					case 12:
						goto IL_130;
					case 13:
						goto IL_3BC;
					case 14:
						num = (short)158203909;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 15:
						try
						{
							num = (short)951255045;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								switch (num2)
								{
								case 0:
									goto IL_2F6;
								case 1:
									num = (short)2099707904;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 2:
								{
									global::AcpCommonLib.IAcpFeatureNode acpFeatureNode;
									if ((acpFeatureNode[10032] as global::Motorola.MackinawCPS.CoreFeatures.Shepherds.SignalIndependentProductIndependentNonProgrammableButtonListInnerSection).RadErgoCfgSignalIndependentProductIndependentNonProgrammableButtonBCO_A19777.Value == 91)
									{
										num = (short)1934032899;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									break;
								}
								case 3:
								{
									int value;
									global::AcpCommonLib.IAcpFeatureNode acpFeatureNode;
									task.AddTask(new global::AcpBusinessLayer.UndoRedo.ModifyDataTask<int>((acpFeatureNode[10032] as global::Motorola.MackinawCPS.CoreFeatures.Shepherds.SignalIndependentProductIndependentNonProgrammableButtonListInnerSection).RadErgoCfgSignalIndependentProductIndependentNonProgrammableButtonFeature_A19778, value));
									num = (short)1004601350;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 4:
								{
									global::System.Collections.Generic.IEnumerator<global::AcpBusinessLayer.FeatureNode> enumerator;
									if (!enumerator.MoveNext())
									{
										num = (short)1897332737;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									global::AcpCommonLib.IAcpFeatureNode acpFeatureNode = enumerator.Current;
									num = (short)864288770;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 5:
									switch (0)
									{
									case 0:
										goto IL_203;
									}
									continue;
								case 6:
									goto IL_29A;
								}
								IL_29F:
								num = (short)1754595332;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								IL_203:
								goto IL_29F;
							}
							IL_29A:
							IL_2F6:
							return;
						}
						finally
						{
							num = (short)439615489;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								global::System.Collections.Generic.IEnumerator<global::AcpBusinessLayer.FeatureNode> enumerator;
								switch (num2)
								{
								case 0:
									goto IL_3B9;
								case 1:
									switch (0)
									{
									case 0:
										goto IL_32F;
									}
									continue;
								case 2:
								{
									num = (short)170217775;
									short num4 = num;
									num = (short)241389871;
									switch ((num4 == num) ? 1 : 0)
									{
									case 0:
									case 2:
										goto IL_3B9;
									default:
										num = (short)984154112;
										if (num != 0)
										{
										}
										enumerator.Dispose();
										num = (short)1820917760;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									break;
								}
								}
								IL_32F:
								if (enumerator == null)
								{
									break;
								}
								num = (short)1262813186;
								num2 = (int)((global::System.IntPtr)num);
							}
							IL_3B9:;
						}
						goto IL_3BC;
					case 16:
						num = (short)1543110665;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 17:
					{
						if (featureSectionId != 10718)
						{
							num = (short)703070222;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						int value = radErgoControlO7MFKButtonPress_A.Value;
						task.AddTask(new global::AcpBusinessLayer.UndoRedo.ModifyDataTask<int>(radErgoControlO2MFKButtonPress_A, value));
						num = (short)27328512;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					}
					goto IL_76;
					IL_130:
					shepherdsRecset = (global::AcpCommonLib.FeatureManager.GetFeature(2013) as global::Motorola.MackinawCPS.CoreFeatures.Shepherds.ShepherdsRecset);
					num = (short)251002887;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_3BC:
					featureSectionId = self.FeatureSectionId;
					num = (short)2090663953;
					num2 = (int)((global::System.IntPtr)num);
				}
				return;
				IL_76:
				o7MultiFunctionKnob = (self as global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO7.O7MultiFunctionKnob);
				radErgoControlO2MFKButtonPress_A = o7MultiFunctionKnob.RefControlHeadO2.O2MultiFunctionKnob.RadErgoControlO2MFKButtonPress_A42217;
				radErgoControlO7MFKButtonPress_A = o7MultiFunctionKnob.RadErgoControlO7MFKButtonPress_A42218;
				num = (short)1862729731;
				num2 = (int)((global::System.IntPtr)num);
				goto IL_27;
			}
			}
		}

		// Token: 0x0600869C RID: 34460 RVA: 0x007D5320 File Offset: 0x007D3520
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
						num2 = (short)624099329;
						if (num2 != 0)
						{
						}
						num2 = (short)13893632;
						short num3 = num2;
						num2 = (short)1852637185;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_145;
				case 1:
					num2 = (short)1209729029;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 2:
					num2 = (short)1254621184;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 3:
					return false;
				case 4:
					IL_52:
					if (radioWide != null)
					{
						num2 = (short)2011430914;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_145;
				case 5:
					if (index == 140)
					{
						num2 = (short)2112290819;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_145;
				}
				goto IL_28;
				IL_145:
				num2 = (short)1438884446;
				short num4 = num2;
				num2 = (short)1904845406;
				switch ((num4 == num2) ? 1 : 0)
				{
				case 0:
				case 2:
					goto IL_52;
				default:
					goto IL_179;
				}
			}
			return false;
			IL_179:
			num2 = (short)355270656;
			if (num2 != 0)
			{
			}
			return true;
			IL_28:
			radioWide = (global::AcpCommonLib.FeatureManager.GetFeature(2045)[0] as global::Motorola.MackinawCPS.CoreFeatures.RadioWide.RadioWide);
			num2 = (short)2125987844;
			num = (int)((global::System.IntPtr)num2);
			goto IL_0A;
		}

		// Token: 0x0600869D RID: 34461 RVA: 0x007D54BC File Offset: 0x007D36BC
		internal static bool ConControlHeadEmergencyFeaturesSelect(global::AcpCommonLib.IAcpFeatureSection self, int index)
		{
			short num = (short)433586176;
			int num2 = (int)num;
			switch (num2)
			{
			default:
			{
				switch (0)
				{
				case 0:
					goto IL_C6;
				}
				bool result;
				global::AcpBusinessLayer.AcpListField radErgoWideControlHeadMultipleControlHeadStyle_A;
				global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO7.O7InnerSection o7InnerSection;
				global::Motorola.MackinawCPS.CoreFeatures.RadioWide.Features features;
				global::AcpBusinessLayer.AcpField<bool> radErgoWideControlHeadMultiControlHead_A;
				global::AcpBusinessLayer.AcpListField radWideDualRadioSelection_A;
				for (;;)
				{
					IL_27:
					bool flag;
					bool flag2;
					bool flag3;
					switch (num2)
					{
					case 0:
						num = (short)2068119560;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 1:
						goto IL_1E8;
					case 2:
						return result;
					case 3:
						if (index <= 138)
						{
							num = (short)1442447381;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)34799651;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 4:
						if (radErgoWideControlHeadMultipleControlHeadStyle_A.Value == 1)
						{
							num = (short)382009358;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_1E8;
					case 5:
						num = (short)23199756;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 6:
						if (index != 31)
						{
							num = (short)127729679;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)1786970131;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 7:
						if (index != 138)
						{
							num = (short)902889498;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)1293090839;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 8:
						if (o7InnerSection.RefRadioWide.DualRadio.RadWideDualRadioEmergencyRadio_A42239.Value == 2)
						{
							num = (short)1880752155;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_2D4;
					case 9:
						flag = !o7InnerSection.RefRadioWide.Features.RadWideTPSFiregroundEvacuationTone_A7980.Value;
						goto IL_415;
					case 10:
						return result;
					case 11:
						return result;
					case 12:
						if (index - 290 > 1)
						{
							num = (short)472973340;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						result = features.RadWideFeaturesChannelFallbackEnableValue;
						num = (short)156696601;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 13:
						flag = true;
						goto IL_415;
					case 14:
						num = (short)1329070109;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 15:
						goto IL_247;
					case 16:
						if (index != 163)
						{
							num = (short)1332543488;
							short num3 = num;
							num = (short)48365573;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)742719492;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 17:
						flag2 = (radErgoWideControlHeadMultipleControlHeadStyle_A.Value == 0);
						goto IL_37F;
					case 18:
						flag3 = !radErgoWideControlHeadMultiControlHead_A.Value;
						goto IL_61A;
					case 19:
						if (radWideDualRadioSelection_A.Value == 1)
						{
							num = (short)1055129600;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_2D4;
					case 20:
						return result;
					case 21:
						num = (short)2066743297;
						if (num != 0)
						{
						}
						num = (short)968818694;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 22:
						return result;
					case 23:
						if (radErgoWideControlHeadMultiControlHead_A.Value)
						{
							num = (short)1190002720;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)2069364772;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 24:
						flag3 = true;
						goto IL_61A;
					case 25:
						return result;
					case 26:
						num = (short)1657405451;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 27:
						num = (short)553910281;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 28:
						num = (short)60227604;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 29:
						if (!radErgoWideControlHeadMultiControlHead_A.Value)
						{
							num = (short)1442381825;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)1414135832;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 30:
						num = (short)1343094800;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 31:
						num = (short)123797511;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 32:
						num = (short)1099038737;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 33:
					{
						num = (short)594683822;
						short num4 = num;
						num = (short)938616750;
						switch ((num4 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_247;
						default:
							num = (short)921108480;
							if (num != 0)
							{
							}
							if (index - 124 > 2)
							{
								num = (short)1912143903;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							result = (radWideDualRadioSelection_A.Value == 0);
							num = (short)1820196866;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						break;
					}
					case 34:
						return result;
					case 35:
						if (index != 140)
						{
							num = (short)15269918;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						result = (radWideDualRadioSelection_A.Value != 0);
						num = (short)1723662346;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 36:
						flag2 = false;
						goto IL_37F;
					case 37:
						return result;
					}
					goto IL_C6;
					IL_1E8:
					num = (short)681246738;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_247:
					num = (short)486211617;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_2D4:
					num = (short)1479802893;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_37F:
					result = flag2;
					num = (short)1302069285;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_415:
					result = flag;
					num = (short)632291362;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_61A:
					result = flag3;
					num = (short)1142554646;
					num2 = (int)((global::System.IntPtr)num);
				}
				return result;
				IL_C6:
				o7InnerSection = (self as global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO7.O7InnerSection);
				radErgoWideControlHeadMultipleControlHeadStyle_A = o7InnerSection.RefRadioErgonomicsWide.ControlHead.RadErgoWideControlHeadMultipleControlHeadStyle_A8561;
				radWideDualRadioSelection_A = o7InnerSection.RefRadioWide.DualRadio.RadWideDualRadioSelection_A42236;
				radErgoWideControlHeadMultiControlHead_A = o7InnerSection.RefRadioErgonomicsWide.ControlHead.RadErgoWideControlHeadMultiControlHead_A8550;
				features = (global::AcpCommonLib.FeatureManager.GetFeature(2045)[0][10105] as global::Motorola.MackinawCPS.CoreFeatures.RadioWide.Features);
				result = true;
				num = (short)475201539;
				num2 = (int)((global::System.IntPtr)num);
				goto IL_27;
			}
			}
		}
	}
}
