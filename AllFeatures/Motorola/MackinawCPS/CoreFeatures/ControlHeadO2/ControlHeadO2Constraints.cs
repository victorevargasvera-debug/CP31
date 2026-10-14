using System;
using System.Collections.Generic;
using AcpBusinessLayer;
using AcpBusinessLayer.UndoRedo;
using AcpCommonLib;
using AcpCommonLib.UndoRedo;
using ConstraintHelper;
using Motorola.MackinawCPS.CoreFeatures.ControlHeadE5;
using Motorola.MackinawCPS.CoreFeatures.ControlHeadO3;
using Motorola.MackinawCPS.CoreFeatures.ControlHeadO5;
using Motorola.MackinawCPS.CoreFeatures.ControlHeadO7;
using Motorola.MackinawCPS.CoreFeatures.ControlHeadO9;
using Motorola.MackinawCPS.CoreFeatures.KeypadMicAndAccessories;
using Motorola.MackinawCPS.CoreFeatures.RadioWide;
using Motorola.MackinawCPS.CoreFeatures.Shepherds;
using Motorola.MackinawCPS.CoreFeatures.Switches;

namespace Motorola.MackinawCPS.CoreFeatures.ControlHeadO2
{
	// Token: 0x020003D2 RID: 978
	public static class ControlHeadO2Constraints
	{
		// Token: 0x06008B5A RID: 35674 RVA: 0x008230B8 File Offset: 0x008212B8
		public static void ConSyncUpDownBtnFeature(global::AcpCommonLib.IAcpFeatureSection self, global::AcpCommonLib.UndoRedo.ContainerTask task)
		{
			short num = (short)313982976;
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
				global::AcpCommonLib.IAcpRecordset parentRecset;
				int num4;
				bool flag;
				int num5;
				for (;;)
				{
					IL_27:
					global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO2.O2NavigationControlsTableInnerSection o2NavigationControlsTableInnerSection;
					switch (num2)
					{
					case 0:
						num = (short)476577801;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 1:
					{
						num = (short)829358080;
						short num3 = num;
						num = (short)911867942;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 2:
						goto IL_3DC;
					case 3:
						num = (short)550371346;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 4:
						num = (short)590544921;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 5:
						if (parentRecset[1] == self.Parent)
						{
							num = (short)2069168154;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_1BB;
					case 6:
						if (num4 == 38)
						{
							num = (short)1587675153;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_4F5;
					case 7:
						goto IL_6D9;
					case 8:
						goto IL_492;
					case 9:
						if (num4 != 88)
						{
							num = (short)482541584;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_3DC;
					case 10:
						if (!flag)
						{
							num = (short)144965651;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num5 = o2NavigationControlsTableInnerSection.RadErgoControlO2UpDownButton_A41278.Value;
						num4 = num5 - 1;
						num = (short)1848180775;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 11:
						goto IL_5FB;
					case 12:
						if (num5 != 66)
						{
							num = (short)753401879;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_3DC;
					case 13:
						num = (short)1490288641;
						if (num != 0)
						{
						}
						num = (short)1170210828;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 14:
						goto IL_401;
					case 15:
						num = (short)1528496138;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 16:
						num = (short)120455195;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 17:
						num5 = 38;
						num = (short)1491468323;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 18:
						if (num5 == 0)
						{
							num = (short)1163526151;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)1611661346;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 19:
						num4 = o2NavigationControlsTableInnerSection.RadErgoControlO2UpDownButton_A41278.Value;
						num5 = num4 + 1;
						num = (short)1574961158;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 20:
					{
						if (num5 != 87)
						{
							goto IL_6DE;
						}
						num = (short)32795218;
						short num6 = num;
						num = (short)1819961938;
						switch ((num6 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_4D6;
						default:
							num = (short)1322319872;
							if (num != 0)
							{
							}
							num = (short)853409794;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						break;
					}
					case 21:
						num = (short)662044704;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 22:
						if (num4 != 65)
						{
							num = (short)1489108993;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_3DC;
					case 23:
						num = (short)422248468;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 24:
						if (parentRecset != null)
						{
							num = (short)1224671253;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return;
					case 25:
						if (num5 != 64)
						{
							num = (short)1470758925;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_3DC;
					case 26:
						flag = true;
						goto IL_4D6;
					case 27:
						if (num5 != 143)
						{
							num = (short)1871904772;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_3DC;
					case 28:
						if (num4 != 0)
						{
							num = (short)1892483075;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return;
					case 29:
						num4 = 38;
						num = (short)1552678923;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 30:
						if (o2NavigationControlsTableInnerSection != null)
						{
							num = (short)1894187023;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return;
					case 31:
						goto IL_17F;
					case 32:
						if (parentRecset.Count < 2)
						{
							num = (short)253558792;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)1696923653;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 33:
						goto IL_1BB;
					case 34:
						if (num4 != 144)
						{
							num = (short)851705893;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_3DC;
					case 35:
						goto IL_4F5;
					case 36:
						goto IL_17F;
					case 37:
						num = (short)870776854;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 38:
						if (num4 != 67)
						{
							num = (short)391380992;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_3DC;
					case 39:
						if (num5 == 38)
						{
							num = (short)201195549;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_5FB;
					}
					goto IL_CE;
					IL_17F:
					num = (short)1389101084;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_1BB:
					o2NavigationControlsTableInnerSection = (self as global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO2.O2NavigationControlsTableInnerSection);
					num = (short)1323565086;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_3DC:
					num4 = 143;
					num5 = 144;
					num = (short)1301807118;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_4D6:
					num = (short)1016987681;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_4F5:
					task.AddTask(new global::AcpBusinessLayer.UndoRedo.ModifyDataTask<int>((self.ParentRecset[1] as global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO2.O2NavigationControlsTableInner).O2NavigationControlsTableInnerSection.RadErgoControlO2UpDownButton_A41278, num5));
					num = (short)37683231;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_5FB:
					task.AddTask(new global::AcpBusinessLayer.UndoRedo.ModifyDataTask<int>((self.ParentRecset[0] as global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO2.O2NavigationControlsTableInner).O2NavigationControlsTableInnerSection.RadErgoControlO2UpDownButton_A41278, num4));
					num = (short)218628132;
					num2 = (int)((global::System.IntPtr)num);
				}
				return;
				IL_401:
				goto IL_6DE;
				IL_492:
				return;
				IL_6D9:
				return;
				IL_6DE:
				global::Motorola.MackinawCPS.CoreFeatures.ControlHeadE5.ControlHeadE5Constraints.SyncNavigationControlsCPField(task, num4, num5);
				global::Motorola.MackinawCPS.CoreFeatures.ControlHeadE5.ControlHeadE5Constraints.SyncE5NavigationControls(task, num4, num5);
				global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO3.ControlHeadO3Constraints.SyncO3NavigationControls(task, num4, num5);
				global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO7.ControlHeadO7Constraints.SyncO7NavigationControls(task, num4, num5);
				global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO5.ControlHeadO5Constraints.SyncO5NavigationControls(task, num4, num5);
				global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO9.ControlHeadO9Constraints.SyncO9NavigationControls(task, num4, num5);
				global::Motorola.MackinawCPS.CoreFeatures.KeypadMicAndAccessories.KeypadMicAndAccessoriesConstraints.SyncKeypadMicAndAccessoriesNavigationControls(task, num4, num5);
				global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO7.ControlHeadO7Constraints.CalculateValidityForO2O7MFK();
				return;
				IL_CE:
				num4 = 0;
				num5 = 0;
				flag = false;
				parentRecset = self.ParentRecset;
				num = (short)1396244504;
				num2 = (int)((global::System.IntPtr)num);
				goto IL_27;
			}
			}
		}

		// Token: 0x06008B5B RID: 35675 RVA: 0x008237E0 File Offset: 0x008219E0
		public static void SyncO2NavigationControls(global::AcpCommonLib.UndoRedo.ContainerTask task, int upButtonConfigedFeatureValue, int downButtonConfigedFeatureValue)
		{
			short num = (short)1011089408;
			int num2 = (int)num;
			switch (num2)
			{
			default:
			{
				switch (0)
				{
				case 0:
					goto IL_44;
				}
				global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO2.ControlHeadO2Recset controlHeadO2Recset;
				for (;;)
				{
					IL_29:
					switch (num2)
					{
					case 0:
					{
						global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO2.O2NavigationControlsTableInnerRecset o2NavigationControlsTableInnerRecset;
						if (o2NavigationControlsTableInnerRecset != null)
						{
							goto IL_1CE;
						}
						return;
					}
					case 1:
						if (controlHeadO2Recset != null)
						{
							num = (short)319619074;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return;
					case 2:
					{
						num = (short)1915634790;
						short num3 = num;
						num = (short)410403942;
						switch ((num3 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_1CE;
						default:
						{
							num = (short)478019584;
							if (num != 0)
							{
							}
							global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO2.O2NavigationControlsTableInnerRecset o2NavigationControlsTableInnerRecset = controlHeadO2Recset[0][10722].EmbeddedRecset as global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO2.O2NavigationControlsTableInnerRecset;
							num = (short)982188032;
							short num4 = num;
							num = (short)1147731968;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						}
						break;
					}
					case 3:
						return;
					case 4:
					{
						global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO2.O2NavigationControlsTableInnerRecset o2NavigationControlsTableInnerRecset;
						global::AcpBusinessLayer.AcpListField radErgoControlO2UpDownButton_A = (o2NavigationControlsTableInnerRecset[0][10725] as global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO2.O2NavigationControlsTableInnerSection).RadErgoControlO2UpDownButton_A41278;
						task.AddTask(new global::AcpBusinessLayer.UndoRedo.ModifyDataTask<int>(radErgoControlO2UpDownButton_A, upButtonConfigedFeatureValue));
						global::AcpBusinessLayer.AcpListField radErgoControlO2UpDownButton_A2 = (o2NavigationControlsTableInnerRecset[1][10725] as global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO2.O2NavigationControlsTableInnerSection).RadErgoControlO2UpDownButton_A41278;
						task.AddTask(new global::AcpBusinessLayer.UndoRedo.ModifyDataTask<int>(radErgoControlO2UpDownButton_A2, downButtonConfigedFeatureValue));
						num = (short)123863041;
						if (num != 0)
						{
						}
						num = (short)1572667395;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					}
					goto IL_44;
					IL_1CE:
					num = (short)851640324;
					num2 = (int)((global::System.IntPtr)num);
				}
				return;
				IL_44:
				controlHeadO2Recset = (global::AcpCommonLib.FeatureManager.GetFeature(4115) as global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO2.ControlHeadO2Recset);
				num = (short)1582956545;
				num2 = (int)((global::System.IntPtr)num);
				goto IL_29;
			}
			}
		}

		// Token: 0x06008B5C RID: 35676 RVA: 0x008239D8 File Offset: 0x00821BD8
		public static void ConSynSwitchMFKWithO2(global::AcpCommonLib.IAcpFeatureSection self, global::AcpCommonLib.UndoRedo.ContainerTask task)
		{
			short num = (short)725958504;
			short num2 = num;
			num = (short)38158184;
			switch ((num2 == num) ? 1 : 0)
			{
			case 0:
			case 2:
				break;
			default:
			{
				num = (short)1963851776;
				if (num != 0)
				{
				}
				num = (short)2003435520;
				short num3 = num;
				num = (short)546242560;
				switch (num)
				{
				}
				break;
			}
			}
			global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO2.O2MFKAssignmentControlInnerSection o2MFKAssignmentControlInnerSection = self as global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO2.O2MFKAssignmentControlInnerSection;
			int radErgoControlO2MFKFeatureAssignment_A41275Value = o2MFKAssignmentControlInnerSection.RadErgoControlO2MFKFeatureAssignment_A41275Value;
			global::System.Collections.Generic.IEnumerator<global::AcpBusinessLayer.FeatureNode> enumerator = (((global::AcpCommonLib.FeatureManager.GetFeature(2038) as global::Motorola.MackinawCPS.CoreFeatures.Switches.SwitchesRecset)[0] as global::Motorola.MackinawCPS.CoreFeatures.Switches.Switches).MultiFunctionKnob.EmbeddedRecset as global::Motorola.MackinawCPS.CoreFeatures.Switches.MFKAssignmentControlInnerRecset).GetEnumerator();
			try
			{
				num = (short)2072641536;
				int num4 = (int)((global::System.IntPtr)num);
				for (;;)
				{
					switch (num4)
					{
					case 0:
						switch (0)
						{
						case 0:
							goto IL_11C;
						}
						continue;
					case 1:
					{
						global::Motorola.MackinawCPS.CoreFeatures.Switches.MFKAssignmentControlInner mfkassignmentControlInner;
						task.AddTask(mfkassignmentControlInner.MFKAssignmentControlInnerSection.RadErgoControlSwitchsMFKFeatureAssignment_A38514.GetModifyDataTask(radErgoControlO2MFKFeatureAssignment_A41275Value));
						num = (short)1697579011;
						num4 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 2:
					{
						global::Motorola.MackinawCPS.CoreFeatures.Switches.MFKAssignmentControlInner mfkassignmentControlInner;
						if (mfkassignmentControlInner.MFKAssignmentControlInnerSection.RadErgoControlSwitchsMFKFeatureAssignment_A38514Value != radErgoControlO2MFKFeatureAssignment_A41275Value)
						{
							num = (short)1643315201;
							num4 = (int)((global::System.IntPtr)num);
							continue;
						}
						break;
					}
					case 3:
						goto IL_247;
					case 4:
					{
						global::Motorola.MackinawCPS.CoreFeatures.Switches.MFKAssignmentControlInner mfkassignmentControlInner;
						if (mfkassignmentControlInner.MFKAssignmentControlInnerSection.SwitchMFKAssignmentControlName_A38529Value == o2MFKAssignmentControlInnerSection.O2MFKAssignmentControlName_A41274Value)
						{
							num = (short)909508613;
							num4 = (int)((global::System.IntPtr)num);
							continue;
						}
						break;
					}
					case 5:
						num = (short)48496642;
						num4 = (int)((global::System.IntPtr)num);
						continue;
					case 6:
					{
						if (!enumerator.MoveNext())
						{
							num = (short)356188167;
							num4 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)1381695489;
						if (num != 0)
						{
						}
						global::Motorola.MackinawCPS.CoreFeatures.Switches.MFKAssignmentControlInner mfkassignmentControlInner = (global::Motorola.MackinawCPS.CoreFeatures.Switches.MFKAssignmentControlInner)enumerator.Current;
						num = (short)834076676;
						num4 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 7:
						num = (short)1740308488;
						num4 = (int)((global::System.IntPtr)num);
						continue;
					case 8:
						goto IL_266;
					}
					IL_197:
					num = (short)641662982;
					num4 = (int)((global::System.IntPtr)num);
					continue;
					IL_11C:
					goto IL_197;
				}
				IL_247:
				IL_266:;
			}
			finally
			{
				num = (short)1545928704;
				int num4 = (int)((global::System.IntPtr)num);
				for (;;)
				{
					switch (num4)
					{
					case 0:
						switch (0)
						{
						case 0:
							goto IL_29B;
						}
						continue;
					case 1:
						enumerator.Dispose();
						num = (short)622002178;
						num4 = (int)((global::System.IntPtr)num);
						continue;
					case 2:
						goto IL_2D1;
					}
					IL_29B:
					if (enumerator == null)
					{
						break;
					}
					num = (short)1790967809;
					num4 = (int)((global::System.IntPtr)num);
				}
				IL_2D1:;
			}
		}

		// Token: 0x06008B5D RID: 35677 RVA: 0x00823CD8 File Offset: 0x00821ED8
		internal static bool ConPrimaryFunctionIsNonBlankO2(global::AcpCommonLib.IAcpFeatureSection self)
		{
			short num = (short)288948224;
			int num2 = (int)num;
			switch (num2)
			{
			default:
			{
				switch (0)
				{
				case 0:
					goto IL_5E;
				}
				global::Motorola.MackinawCPS.CoreFeatures.RadioWide.RadioWide radioWide;
				global::AcpCommonLib.IAcpRecordset parentRecset;
				bool result;
				for (;;)
				{
					IL_27:
					global::AcpCommonLib.IAcpFeatureNode parent;
					switch (num2)
					{
					case 0:
						if (radioWide.DualRadio.RadWideDualRadioSelection_A42236.Value != 0)
						{
							num = (short)1832321025;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_263;
					case 1:
						return false;
					case 2:
						if (radioWide != null)
						{
							num = (short)1424031751;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_263;
					case 3:
					{
						global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO2.O2MultiFunctionKnob o2MultiFunctionKnob;
						if (o2MultiFunctionKnob.RadErgoControlO2MFKButtonPress_A42217 != null)
						{
							num = (short)2052456458;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_1AF;
					}
					case 4:
					{
						global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO2.O2MultiFunctionKnob o2MultiFunctionKnob;
						if (o2MultiFunctionKnob != null)
						{
							goto IL_244;
						}
						goto IL_1AF;
					}
					case 5:
						num = (short)868810755;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 6:
					{
						global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO2.O2MultiFunctionKnob o2MultiFunctionKnob;
						if (o2MultiFunctionKnob.RadErgoControlO2MFKButtonPress_A42217.Value == 31)
						{
							num = (short)548274184;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_1AF;
					}
					case 7:
						num = (short)1522925568;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 8:
					{
						num = (short)283504763;
						short num3 = num;
						num = (short)47378555;
						switch ((num3 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_244;
						default:
							goto IL_154;
						}
						break;
					}
					case 9:
					{
						global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO2.O2MultiFunctionKnob o2MultiFunctionKnob = parentRecset.ParentSection as global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO2.O2MultiFunctionKnob;
						num = (short)573505540;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 10:
						num = (short)746848262;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 11:
						num = (short)1782513665;
						if (num != 0)
						{
						}
						if ((parent.Parent as global::AcpBusinessLayer.Recordset).IndexOf(parent) == 1)
						{
							num = (short)885456905;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return result;
					}
					goto IL_5E;
					IL_244:
					num = (short)1388183557;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_263:
					global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO2.O2MFKAssignmentControlInnerSection o2MFKAssignmentControlInnerSection = self as global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO2.O2MFKAssignmentControlInnerSection;
					parentRecset = self.ParentRecset;
					parent = o2MFKAssignmentControlInnerSection.RadErgoControlO2MFKFeatureAssignment_A41275.Parent.Parent;
					num = (short)1937244171;
					num2 = (int)((global::System.IntPtr)num);
				}
				IL_154:
				num = (short)280952832;
				if (num != 0)
				{
				}
				return false;
				IL_1AF:
				return (parentRecset[0] as global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO2.O2MFKAssignmentControlInner).O2MFKAssignmentControlInnerSection.RadErgoControlO2MFKFeatureAssignment_A41275.Value != 38;
				IL_5E:
				result = true;
				radioWide = (global::AcpCommonLib.FeatureManager.GetFeature(2045)[0] as global::Motorola.MackinawCPS.CoreFeatures.RadioWide.RadioWide);
				num = (short)1504116736;
				short num4 = num;
				num = (short)455081986;
				num2 = (int)((global::System.IntPtr)num);
				goto IL_27;
			}
			}
		}

		// Token: 0x06008B5E RID: 35678 RVA: 0x00823FD8 File Offset: 0x008221D8
		public static bool ConValidityMFKAssignControlO2(global::AcpCommonLib.IAcpFeatureSection self, int index)
		{
			short num = (short)1333264384;
			int num2 = (int)num;
			switch (num2)
			{
			default:
			{
				bool result;
				global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO2.O2MultiFunctionKnob o2MultiFunctionKnob;
				bool flag;
				switch (0)
				{
				case 0:
					break;
				default:
				{
					for (;;)
					{
						IL_28:
						global::Motorola.MackinawCPS.CoreFeatures.Shepherds.ShepherdsRecset shepherdsRecset;
						global::AcpCommonLib.IAcpRecordset parentRecset;
						int num4;
						switch (num2)
						{
						case 0:
							num = (short)679018497;
							if (num != 0)
							{
							}
							num = (short)227934228;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 1:
							return false;
						case 2:
						{
							global::System.Collections.Generic.IEnumerator<global::AcpBusinessLayer.FeatureNode> enumerator = (shepherdsRecset[0][10031].EmbeddedRecset as global::Motorola.MackinawCPS.CoreFeatures.Shepherds.SignalIndependentProductIndependentNonProgrammableButtonListInnerRecset).GetEnumerator();
							num = (short)15204375;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						case 3:
							goto IL_6B2;
						case 4:
							return true;
						case 5:
							num = (short)1104150552;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 6:
						{
							int value = (parentRecset[0] as global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO2.O2MFKAssignmentControlInner).O2MFKAssignmentControlInnerSection.RadErgoControlO2MFKFeatureAssignment_A41275.Value;
							num = (short)773193762;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						case 7:
						{
							int value2 = (parentRecset[1] as global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO2.O2MFKAssignmentControlInner).O2MFKAssignmentControlInnerSection.RadErgoControlO2MFKFeatureAssignment_A41275.Value;
							num = (short)252051472;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						case 8:
							return false;
						case 9:
							num = (short)1775632397;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 10:
							goto IL_81F;
						case 11:
						{
							if (index == 23)
							{
								goto IL_667;
							}
							num = (short)419795316;
							short num3 = num;
							num = (short)633180532;
							switch ((num3 == num) ? 1 : 0)
							{
							case 0:
							case 2:
								goto IL_D0;
							default:
								num = (short)1204420608;
								if (num != 0)
								{
								}
								num = (short)1419640840;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							break;
						}
						case 12:
							if (parentRecset[1] == self.Parent)
							{
								num = (short)1354563590;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							return result;
						case 13:
							if (parentRecset[0] == self.Parent)
							{
								num = (short)1901985799;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							goto IL_667;
						case 14:
							if (o2MultiFunctionKnob.RadErgoControlO2MFKButtonPress_A42217.Value == 31)
							{
								num = (short)857604100;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							goto IL_5B2;
						case 15:
							num = (short)1487273998;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 16:
							if (index == 38)
							{
								num = (short)129433601;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							num = (short)862781472;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 17:
						{
							int value2;
							if (value2 != 23)
							{
								num = (short)581632028;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							goto IL_667;
						}
						case 18:
							goto IL_6B2;
						case 19:
							if (o2MultiFunctionKnob != null)
							{
								num = (short)158400517;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							goto IL_5B2;
						case 20:
						{
							int value;
							if (value != 23)
							{
								num = (short)124780571;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							return result;
						}
						case 21:
							if (shepherdsRecset != null)
							{
								num = (short)1414987809;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							goto IL_5FE;
						case 22:
							return false;
						case 23:
							try
							{
								num = (short)944308224;
								num2 = (int)((global::System.IntPtr)num);
								for (;;)
								{
									switch (num2)
									{
									case 0:
										switch (0)
										{
										case 0:
											goto IL_2ED;
										}
										continue;
									case 1:
										num = (short)2053832712;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									case 2:
									{
										global::System.Collections.Generic.IEnumerator<global::AcpBusinessLayer.FeatureNode> enumerator;
										if (!enumerator.MoveNext())
										{
											num = (short)630915073;
											num2 = (int)((global::System.IntPtr)num);
											continue;
										}
										global::AcpCommonLib.IAcpFeatureNode acpFeatureNode = enumerator.Current;
										num = (short)419627014;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									case 3:
										goto IL_3FF;
									case 4:
									{
										global::AcpCommonLib.IAcpFeatureNode acpFeatureNode;
										if ((acpFeatureNode[10032] as global::Motorola.MackinawCPS.CoreFeatures.Shepherds.SignalIndependentProductIndependentNonProgrammableButtonListInnerSection).RadErgoCfgSignalIndependentProductIndependentNonProgrammableButtonFeature_A19778.Value == 87)
										{
											num = (short)928382981;
											num2 = (int)((global::System.IntPtr)num);
											continue;
										}
										break;
									}
									case 5:
										flag = true;
										num = (short)892862467;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									case 6:
									{
										global::AcpCommonLib.IAcpFeatureNode acpFeatureNode;
										if ((acpFeatureNode[10032] as global::Motorola.MackinawCPS.CoreFeatures.Shepherds.SignalIndependentProductIndependentNonProgrammableButtonListInnerSection).RadErgoCfgSignalIndependentProductIndependentNonProgrammableButtonBCO_A19777.Value == 135)
										{
											num = (short)1477836807;
											num2 = (int)((global::System.IntPtr)num);
											continue;
										}
										break;
									}
									case 7:
										num = (short)707067908;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									case 8:
										goto IL_41D;
									}
									IL_3A7:
									num = (short)286916610;
									num2 = (int)((global::System.IntPtr)num);
									continue;
									IL_2ED:
									goto IL_3A7;
								}
								IL_3FF:
								IL_41D:
								goto IL_5FE;
							}
							finally
							{
								num = (short)240386048;
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
											goto IL_456;
										}
										continue;
									case 1:
										enumerator.Dispose();
										num = (short)2035154946;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									case 2:
										goto IL_48D;
									}
									IL_456:
									if (enumerator == null)
									{
										break;
									}
									num = (short)1024786433;
									num2 = (int)((global::System.IntPtr)num);
								}
								IL_48D:;
							}
							goto IL_490;
						case 24:
							if (o2MultiFunctionKnob.RadErgoControlO2MFKButtonPress_A42217 != null)
							{
								num = (short)479526927;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							goto IL_5B2;
						case 25:
							if (shepherdsRecset.Count > 0)
							{
								num = (short)1764425730;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							goto IL_5FE;
						case 26:
							if (num4 >= parentRecset.Count)
							{
								num = (short)415367177;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							(parentRecset[num4] as global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO2.O2MFKAssignmentControlInner).O2MFKAssignmentControlInnerSection.RadErgoControlO2MFKFeatureAssignment_A41275.CalculateApplicability();
							num4++;
							num = (short)106037251;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 27:
							num = (short)1395392542;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 28:
							num = (short)529530891;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 29:
							num = (short)731840529;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 30:
							if (index != 23)
							{
								num = (short)1431830550;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							return result;
						case 31:
							if (!flag)
							{
								num = (short)1219559424;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							return result;
						case 32:
							if (!flag)
							{
								num = (short)651296797;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							goto IL_667;
						case 33:
							num = (short)1298530329;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 34:
						{
							int value;
							if (value == 38)
							{
								num = (short)1658191882;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							goto IL_490;
						}
						}
						goto IL_BB;
						IL_490:
						num = (short)692715551;
						num2 = (int)((global::System.IntPtr)num);
						continue;
						IL_5B2:
						shepherdsRecset = (global::AcpCommonLib.FeatureManager.GetFeature(2013) as global::Motorola.MackinawCPS.CoreFeatures.Shepherds.ShepherdsRecset);
						num = (short)1822294037;
						num2 = (int)((global::System.IntPtr)num);
						continue;
						IL_5FE:
						parentRecset = self.ParentRecset;
						num4 = 0;
						num = (short)1710030866;
						num2 = (int)((global::System.IntPtr)num);
						continue;
						IL_667:
						num = (short)1014104076;
						num2 = (int)((global::System.IntPtr)num);
						continue;
						IL_6B2:
						num = (short)1543372826;
						num2 = (int)((global::System.IntPtr)num);
					}
					return false;
					IL_81F:
					num = (short)1452081152;
					short num5 = num;
					return false;
				}
				}
				IL_BB:
				result = true;
				flag = false;
				o2MultiFunctionKnob = (self.ParentRecset.ParentSection as global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO2.O2MultiFunctionKnob);
				IL_D0:
				num = (short)1646919699;
				num2 = (int)((global::System.IntPtr)num);
				goto IL_28;
			}
			}
		}

		// Token: 0x06008B5F RID: 35679 RVA: 0x00824864 File Offset: 0x00822A64
		public static void ConSyncOrangeBtn(global::AcpCommonLib.IAcpFeatureSection self, global::AcpCommonLib.UndoRedo.ContainerTask task)
		{
			short num = (short)2064777216;
			int num2 = (int)num;
			switch (num2)
			{
			default:
			{
				switch (0)
				{
				case 0:
					goto IL_FB;
				}
				for (;;)
				{
					IL_28:
					global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO5.ControlHeadO5Recset controlHeadO5Recset;
					global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO5.O5InnerRecset o5InnerRecset;
					int num3;
					global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO7.ControlHeadO7Recset controlHeadO7Recset;
					global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO7.O7InnerRecset o7InnerRecset;
					global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO2.O2InnerRecset o2InnerRecset;
					global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO2.ControlHeadO2Recset controlHeadO2Recset;
					global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO9.ControlHeadO9Recset controlHeadO9Recset;
					global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO9.O9InnerRecset o9InnerRecset;
					bool flag;
					switch (num2)
					{
					case 0:
						o5InnerRecset = (controlHeadO5Recset[0][10227].EmbeddedRecset as global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO5.O5InnerRecset);
						num = (short)1507786783;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 1:
					{
						int featureSectionId;
						if (featureSectionId != 10715)
						{
							num = (short)402391058;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_4DA;
					}
					case 2:
					{
						int featureSectionId;
						if (featureSectionId != 10627)
						{
							num = (short)116588588;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num3 = (self as global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO9.O9InnerSection).CHO9EmergencyButtonFeature_A36682.Value;
						num = (short)1928069143;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 3:
						o7InnerRecset = (controlHeadO7Recset[0][10719].EmbeddedRecset as global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO7.O7InnerRecset);
						num = (short)701038619;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 4:
						try
						{
							num = (short)1465253894;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								switch (num2)
								{
								case 0:
								{
									global::AcpCommonLib.IAcpFeatureNode acpFeatureNode;
									if (num3 != (acpFeatureNode[10901] as global::Motorola.MackinawCPS.CoreFeatures.ControlHeadE5.E5InnerSection).CHE5EmergencyButtonFeature_43768.Value)
									{
										num = (short)1976893443;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									break;
								}
								case 1:
									num = (short)1552547842;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 2:
									goto IL_8FF;
								case 3:
								{
									global::AcpCommonLib.IAcpFeatureNode acpFeatureNode;
									task.AddTask(new global::AcpBusinessLayer.UndoRedo.ModifyDataTask<int>((acpFeatureNode[10901] as global::Motorola.MackinawCPS.CoreFeatures.ControlHeadE5.E5InnerSection).CHE5EmergencyButtonFeature_43768, num3));
									num = (short)306905093;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 4:
								{
									global::System.Collections.Generic.IEnumerator<global::AcpBusinessLayer.FeatureNode> enumerator;
									if (!enumerator.MoveNext())
									{
										num = (short)941948929;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									global::AcpCommonLib.IAcpFeatureNode acpFeatureNode = enumerator.Current;
									num = (short)2073427968;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 6:
									switch (0)
									{
									case 0:
										goto IL_811;
									}
									continue;
								}
								IL_813:
								num = (short)1638137860;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								IL_811:
								goto IL_813;
							}
							IL_8FF:
							goto IL_D48;
						}
						finally
						{
							num = (short)1758003202;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								global::System.Collections.Generic.IEnumerator<global::AcpBusinessLayer.FeatureNode> enumerator;
								switch (num2)
								{
								case 0:
									goto IL_96F;
								case 1:
									enumerator.Dispose();
									num = (short)2113798144;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 2:
									switch (0)
									{
									case 0:
										goto IL_937;
									}
									continue;
								}
								IL_937:
								if (enumerator == null)
								{
									break;
								}
								num = (short)1845297153;
								num2 = (int)((global::System.IntPtr)num);
							}
							IL_96F:;
						}
						goto IL_972;
					case 5:
						goto IL_A2D;
					case 6:
					{
						int featureSectionId;
						if (featureSectionId == 10901)
						{
							num = (short)450232334;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_C20;
					}
					case 7:
					{
						int featureSectionId;
						if (featureSectionId != 10716)
						{
							num = (short)1412497450;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num3 = (self as global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO2.O2InnerSection).CHO2EmergencyButtonFeature_A41272.Value;
						num = (short)136970287;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 8:
						goto IL_972;
					case 9:
						if (o2InnerRecset != null)
						{
							num = (short)1288437784;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_10CD;
					case 10:
						if (controlHeadO2Recset != null)
						{
							num = (short)239403028;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_D0B;
					case 11:
						goto IL_70D;
					case 12:
						return;
					case 13:
						if (controlHeadO9Recset != null)
						{
							num = (short)1701773346;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_70D;
					case 14:
						num3 = (self as global::Motorola.MackinawCPS.CoreFeatures.ControlHeadE5.E5InnerSection).CHE5EmergencyButtonFeature_43768.Value;
						num = (short)1683685415;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 15:
						goto IL_A2D;
					case 16:
						goto IL_D0B;
					case 17:
						if (o7InnerRecset != null)
						{
							num = (short)104464434;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_778;
					case 18:
						goto IL_1035;
					case 19:
						try
						{
							num = (short)2007433220;
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
										num = (short)2127822851;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									global::AcpCommonLib.IAcpFeatureNode acpFeatureNode2 = enumerator.Current;
									num = (short)569114625;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 1:
								{
									global::AcpCommonLib.IAcpFeatureNode acpFeatureNode2;
									if (num3 != (acpFeatureNode2[10211] as global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO5.O5InnerSection).CntrlHeadO5SignalIndependentO5M5MXChiefCHButtonButtonFeature_A19754.Value)
									{
										num = (short)171900934;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									break;
								}
								case 3:
									num = (short)856293381;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 4:
									switch (0)
									{
									case 0:
										goto IL_1D8;
									}
									continue;
								case 5:
									goto IL_2C8;
								case 6:
								{
									global::AcpCommonLib.IAcpFeatureNode acpFeatureNode2;
									task.AddTask(new global::AcpBusinessLayer.UndoRedo.ModifyDataTask<int>((acpFeatureNode2[10211] as global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO5.O5InnerSection).CntrlHeadO5SignalIndependentO5M5MXChiefCHButtonButtonFeature_A19754, num3));
									num = (short)840826882;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								}
								IL_1DA:
								num = (short)419889152;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								IL_1D8:
								goto IL_1DA;
							}
							IL_2C8:
							goto IL_1078;
						}
						finally
						{
							num = (short)1165623298;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								global::System.Collections.Generic.IEnumerator<global::AcpBusinessLayer.FeatureNode> enumerator;
								switch (num2)
								{
								case 0:
									goto IL_338;
								case 1:
									enumerator.Dispose();
									num = (short)2080112640;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 2:
									switch (0)
									{
									case 0:
										goto IL_301;
									}
									continue;
								}
								IL_301:
								if (enumerator == null)
								{
									break;
								}
								num = (short)1322909697;
								num2 = (int)((global::System.IntPtr)num);
							}
							IL_338:;
						}
						goto Block_3;
					case 20:
						o2InnerRecset = (controlHeadO2Recset[0][10723].EmbeddedRecset as global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO2.O2InnerRecset);
						num = (short)1239220240;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 21:
					{
						global::System.Collections.Generic.IEnumerator<global::AcpBusinessLayer.FeatureNode> enumerator = o9InnerRecset.GetEnumerator();
						num = (short)1035665443;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 22:
						goto IL_B07;
					case 23:
						goto IL_A2D;
					case 24:
					{
						global::System.Collections.Generic.IEnumerator<global::AcpBusinessLayer.FeatureNode> enumerator = o2InnerRecset.GetEnumerator();
						num = (short)542572576;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 25:
						goto IL_C20;
					case 26:
						goto IL_A2D;
					case 27:
						goto IL_D97;
					case 28:
						if (o9InnerRecset != null)
						{
							num = (short)1538457621;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return;
					case 29:
						if (controlHeadO5Recset != null)
						{
							goto IL_1100;
						}
						goto IL_111E;
					case 30:
					{
						global::System.Collections.Generic.IEnumerator<global::AcpBusinessLayer.FeatureNode> enumerator = o5InnerRecset.GetEnumerator();
						num = (short)517865491;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 31:
						goto IL_111E;
					case 32:
						goto IL_33B;
					case 33:
					{
						int featureSectionId;
						if (featureSectionId != 10211)
						{
							num = (short)374931457;
							if (num != 0)
							{
							}
							num = (short)1421934635;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num3 = (self as global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO5.O5InnerSection).CntrlHeadO5SignalIndependentO5M5MXChiefCHButtonButtonFeature_A19754.Value;
						num = (short)1272578074;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 34:
						o9InnerRecset = (controlHeadO9Recset[0][10626].EmbeddedRecset as global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO9.O9InnerRecset);
						num = (short)1793720331;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 35:
						try
						{
							num = (short)1426325510;
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
										num = (short)134676483;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									global::AcpCommonLib.IAcpFeatureNode acpFeatureNode3 = enumerator.Current;
									num = (short)292749313;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 1:
								{
									global::AcpCommonLib.IAcpFeatureNode acpFeatureNode3;
									if (num3 != (acpFeatureNode3[10627] as global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO9.O9InnerSection).CHO9EmergencyButtonFeature_A36682.Value)
									{
										num = (short)1529806853;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									break;
								}
								case 2:
									goto IL_FC3;
								case 3:
									num = (short)2096889858;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 5:
								{
									global::AcpCommonLib.IAcpFeatureNode acpFeatureNode3;
									task.AddTask(new global::AcpBusinessLayer.UndoRedo.ModifyDataTask<int>((acpFeatureNode3[10627] as global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO9.O9InnerSection).CHO9EmergencyButtonFeature_A36682, num3));
									num = (short)1526398980;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 6:
									switch (0)
									{
									case 0:
										goto IL_ED7;
									}
									continue;
								}
								IL_F70:
								num = (short)970063872;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								IL_ED7:
								goto IL_F70;
							}
							IL_FC3:
							return;
						}
						finally
						{
							num = (short)535166978;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								global::System.Collections.Generic.IEnumerator<global::AcpBusinessLayer.FeatureNode> enumerator;
								switch (num2)
								{
								case 0:
									goto IL_1032;
								case 1:
									enumerator.Dispose();
									num = (short)1345912832;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 2:
									switch (0)
									{
									case 0:
										goto IL_FFA;
									}
									continue;
								}
								IL_FFA:
								if (enumerator == null)
								{
									break;
								}
								num = (short)385351681;
								num2 = (int)((global::System.IntPtr)num);
							}
							IL_1032:;
						}
						goto IL_1035;
					case 36:
					{
						if (!flag)
						{
							num = (short)1384579084;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						global::Motorola.MackinawCPS.CoreFeatures.ControlHeadE5.ControlHeadE5Recset controlHeadE5Recset = null;
						global::Motorola.MackinawCPS.CoreFeatures.ControlHeadE5.E5InnerRecset e5InnerRecset = null;
						controlHeadE5Recset = (global::AcpCommonLib.FeatureManager.GetFeature(4236) as global::Motorola.MackinawCPS.CoreFeatures.ControlHeadE5.ControlHeadE5Recset);
						num = (short)599916584;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 37:
					{
						global::Motorola.MackinawCPS.CoreFeatures.ControlHeadE5.E5InnerRecset e5InnerRecset;
						if (e5InnerRecset != null)
						{
							num = (short)344588333;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_D48;
					}
					case 38:
					{
						global::Motorola.MackinawCPS.CoreFeatures.ControlHeadE5.ControlHeadE5Recset controlHeadE5Recset;
						global::Motorola.MackinawCPS.CoreFeatures.ControlHeadE5.E5InnerRecset e5InnerRecset = controlHeadE5Recset[0][10902].EmbeddedRecset as global::Motorola.MackinawCPS.CoreFeatures.ControlHeadE5.E5InnerRecset;
						num = (short)753336342;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 39:
						goto IL_A2D;
					case 40:
					{
						global::Motorola.MackinawCPS.CoreFeatures.ControlHeadE5.ControlHeadE5Recset controlHeadE5Recset;
						if (controlHeadE5Recset != null)
						{
							num = (short)1216348198;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_B07;
					}
					case 41:
						try
						{
							num = (short)747438086;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								switch (num2)
								{
								case 0:
									num = (short)1823801346;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 1:
								{
									global::AcpCommonLib.IAcpFeatureNode acpFeatureNode4;
									task.AddTask(new global::AcpBusinessLayer.UndoRedo.ModifyDataTask<int>((acpFeatureNode4[10715] as global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO7.O7InnerSection).CHO7EmergencyButtonFeature_A41291, num3));
									num = (short)1838546947;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 2:
									goto IL_633;
								case 4:
								{
									global::AcpCommonLib.IAcpFeatureNode acpFeatureNode4;
									if (num3 != (acpFeatureNode4[10715] as global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO7.O7InnerSection).CHO7EmergencyButtonFeature_A41291.Value)
									{
										num = (short)1683423233;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									break;
								}
								case 5:
								{
									global::System.Collections.Generic.IEnumerator<global::AcpBusinessLayer.FeatureNode> enumerator;
									if (!enumerator.MoveNext())
									{
										num = (short)89718784;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									global::AcpCommonLib.IAcpFeatureNode acpFeatureNode4 = enumerator.Current;
									num = (short)120389636;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 6:
									switch (0)
									{
									case 0:
										goto IL_54C;
									}
									continue;
								}
								IL_5A1:
								num = (short)371851269;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								IL_54C:
								goto IL_5A1;
							}
							IL_633:
							goto IL_778;
						}
						finally
						{
							num = (short)1809448962;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								global::System.Collections.Generic.IEnumerator<global::AcpBusinessLayer.FeatureNode> enumerator;
								switch (num2)
								{
								case 0:
									goto IL_6A2;
								case 1:
									enumerator.Dispose();
									num = (short)1130102784;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 2:
									switch (0)
									{
									case 0:
										goto IL_66A;
									}
									continue;
								}
								IL_66A:
								if (enumerator == null)
								{
									break;
								}
								num = (short)1620115457;
								num2 = (int)((global::System.IntPtr)num);
							}
							IL_6A2:;
						}
						goto IL_6A5;
					case 42:
						goto IL_6A5;
					case 43:
					{
						num = (short)650772480;
						short num4 = num;
						num = (short)611713026;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 44:
						num = (short)538443801;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 45:
					{
						global::Motorola.MackinawCPS.CoreFeatures.ControlHeadE5.E5InnerRecset e5InnerRecset;
						global::System.Collections.Generic.IEnumerator<global::AcpBusinessLayer.FeatureNode> enumerator = e5InnerRecset.GetEnumerator();
						num = (short)306446340;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 46:
						if (o5InnerRecset != null)
						{
							num = (short)296484894;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_1078;
					case 47:
						goto IL_A2D;
					case 48:
					{
						int featureSectionId;
						if (featureSectionId <= 10627)
						{
							num = (short)44630024;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)1347354625;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 49:
						if (controlHeadO7Recset != null)
						{
							num = (short)556007427;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_D97;
					case 50:
					{
						global::System.Collections.Generic.IEnumerator<global::AcpBusinessLayer.FeatureNode> enumerator = o7InnerRecset.GetEnumerator();
						num = (short)1839333417;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					}
					goto IL_FB;
					IL_4DA:
					num3 = (self as global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO7.O7InnerSection).CHO7EmergencyButtonFeature_A41291.Value;
					num = (short)453312517;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					Block_3:
					try
					{
						IL_33B:
						num = (short)2108162054;
						num2 = (int)((global::System.IntPtr)num);
						for (;;)
						{
							switch (num2)
							{
							case 0:
							{
								global::AcpCommonLib.IAcpFeatureNode acpFeatureNode5;
								task.AddTask(new global::AcpBusinessLayer.UndoRedo.ModifyDataTask<int>((acpFeatureNode5[10716] as global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO2.O2InnerSection).CHO2EmergencyButtonFeature_A41272, num3));
								num = (short)84410371;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							case 1:
								num = (short)109707266;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							case 2:
								goto IL_468;
							case 4:
							{
								global::System.Collections.Generic.IEnumerator<global::AcpBusinessLayer.FeatureNode> enumerator;
								if (!enumerator.MoveNext())
								{
									num = (short)1034616833;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								global::AcpCommonLib.IAcpFeatureNode acpFeatureNode5 = enumerator.Current;
								num = (short)429457413;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							case 5:
							{
								global::AcpCommonLib.IAcpFeatureNode acpFeatureNode5;
								if (num3 != (acpFeatureNode5[10716] as global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO2.O2InnerSection).CHO2EmergencyButtonFeature_A41272.Value)
								{
									num = (short)336920576;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								break;
							}
							case 6:
								switch (0)
								{
								case 0:
									goto IL_37D;
								}
								continue;
							}
							IL_37F:
							num = (short)1176240132;
							num2 = (int)((global::System.IntPtr)num);
							continue;
							IL_37D:
							goto IL_37F;
						}
						IL_468:
						goto IL_10CD;
					}
					finally
					{
						num = (short)647888898;
						num2 = (int)((global::System.IntPtr)num);
						for (;;)
						{
							global::System.Collections.Generic.IEnumerator<global::AcpBusinessLayer.FeatureNode> enumerator;
							switch (num2)
							{
							case 0:
								goto IL_4D7;
							case 1:
								enumerator.Dispose();
								num = (short)171442176;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							case 2:
								switch (0)
								{
								case 0:
									goto IL_4A0;
								}
								continue;
							}
							IL_4A0:
							if (enumerator == null)
							{
								break;
							}
							num = (short)966852609;
							num2 = (int)((global::System.IntPtr)num);
						}
						IL_4D7:;
					}
					goto IL_4DA;
					IL_6A5:
					num = (short)811204614;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_70D:
					num = (short)350027804;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_778:
					controlHeadO9Recset = null;
					o9InnerRecset = null;
					controlHeadO9Recset = (global::AcpCommonLib.FeatureManager.GetFeature(4003) as global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO9.ControlHeadO9Recset);
					num = (short)1056505869;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_972:
					num = (short)2043871265;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_A2D:
					num = (short)1199964196;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_B07:
					num = (short)1262420005;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_C20:
					flag = false;
					num = (short)531234831;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_D0B:
					num = (short)1507196937;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_D48:
					controlHeadO2Recset = null;
					o2InnerRecset = null;
					controlHeadO2Recset = (global::AcpCommonLib.FeatureManager.GetFeature(4115) as global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO2.ControlHeadO2Recset);
					num = (short)1347289098;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_D97:
					num = (short)1537540113;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_1035:
					num = (short)1491140615;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_1078:
					controlHeadO7Recset = null;
					o7InnerRecset = null;
					controlHeadO7Recset = (global::AcpCommonLib.FeatureManager.GetFeature(4114) as global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO7.ControlHeadO7Recset);
					num = (short)1255866417;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_10CD:
					controlHeadO5Recset = null;
					o5InnerRecset = null;
					controlHeadO5Recset = (global::AcpCommonLib.FeatureManager.GetFeature(2130) as global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO5.ControlHeadO5Recset);
					num = (short)536608797;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_111E:
					num = (short)629342254;
					num2 = (int)((global::System.IntPtr)num);
				}
				return;
				IL_FB:
				num = (short)1523842785;
				short num5 = num;
				num = (short)1545469665;
				switch ((num5 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					IL_1100:
					num = (short)1037434880;
					num2 = (int)((global::System.IntPtr)num);
					goto IL_28;
				default:
				{
					num = (short)705298432;
					if (num != 0)
					{
					}
					int num3 = 0;
					bool flag = true;
					int featureSectionId = self.FeatureSectionId;
					num = (short)1741553712;
					num2 = (int)((global::System.IntPtr)num);
					goto IL_28;
				}
				}
				break;
			}
			}
		}

		// Token: 0x06008B60 RID: 35680 RVA: 0x00825A48 File Offset: 0x00823C48
		public static bool conDownButtonApplicable(global::AcpCommonLib.IAcpFeatureSection self)
		{
			if (self.ParentRecset[1] == self.Parent)
			{
				short num;
				for (;;)
				{
					num = (short)1739815929;
					short num2 = num;
					num = (short)622558201;
					switch ((num2 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						break;
					default:
						goto IL_4F;
					}
				}
				IL_4F:
				num = (short)2043936768;
				if (num != 0)
				{
				}
				num = (short)1745747968;
				short num3 = num;
				num = (short)606994433;
				if (num != 0)
				{
				}
				return false;
			}
			return true;
		}

		// Token: 0x06008B61 RID: 35681 RVA: 0x00825B14 File Offset: 0x00823D14
		internal static void ConMFKButtonBehaviorToShepherds(global::AcpCommonLib.IAcpFeatureSection self, global::AcpCommonLib.UndoRedo.ContainerTask task)
		{
			short num = (short)1111883776;
			int num2 = (int)num;
			switch (num2)
			{
			default:
			{
				switch (0)
				{
				case 0:
					goto IL_78;
				}
				global::AcpBusinessLayer.AcpListField radErgoControlO7MFKButtonPress_A;
				global::AcpBusinessLayer.AcpListField radErgoControlO2MFKButtonPress_A;
				global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO2.O2MultiFunctionKnob o2MultiFunctionKnob;
				for (;;)
				{
					IL_29:
					global::Motorola.MackinawCPS.CoreFeatures.Shepherds.ShepherdsRecset shepherdsRecset;
					int featureSectionId;
					switch (num2)
					{
					case 0:
						num = (short)1728053261;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 1:
						if (shepherdsRecset != null)
						{
							num = (short)40239113;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return;
					case 2:
						goto IL_3E2;
					case 3:
					{
						if (featureSectionId != 10718)
						{
							num = (short)539492362;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						int value = radErgoControlO7MFKButtonPress_A.Value;
						task.AddTask(new global::AcpBusinessLayer.UndoRedo.ModifyDataTask<int>(radErgoControlO2MFKButtonPress_A, value));
						num = (short)1246101515;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 4:
					{
						if (featureSectionId == 10721)
						{
							num = (short)311164940;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						int value = radErgoControlO2MFKButtonPress_A.Value;
						num = (short)221970449;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 5:
						if (shepherdsRecset[0] != null)
						{
							num = (short)1415315471;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return;
					case 6:
						try
						{
							num = (short)895614981;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								global::System.Collections.Generic.IEnumerator<global::AcpBusinessLayer.FeatureNode> enumerator;
								global::AcpCommonLib.IAcpFeatureNode acpFeatureNode;
								switch (num2)
								{
								case 0:
									if (!enumerator.MoveNext())
									{
										num = (short)421658627;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									goto IL_282;
								case 1:
									if ((acpFeatureNode[10032] as global::Motorola.MackinawCPS.CoreFeatures.Shepherds.SignalIndependentProductIndependentNonProgrammableButtonListInnerSection).RadErgoCfgSignalIndependentProductIndependentNonProgrammableButtonBCO_A19777.Value == 91)
									{
										num = (short)1860698114;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									break;
								case 2:
								{
									int value;
									task.AddTask(new global::AcpBusinessLayer.UndoRedo.ModifyDataTask<int>((acpFeatureNode[10032] as global::Motorola.MackinawCPS.CoreFeatures.Shepherds.SignalIndependentProductIndependentNonProgrammableButtonListInnerSection).RadErgoCfgSignalIndependentProductIndependentNonProgrammableButtonFeature_A19778, value));
									num = (short)1722810372;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 3:
									num = (short)433061894;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 4:
									goto IL_313;
								case 5:
								{
									num = (short)1966642606;
									short num3 = num;
									num = (short)1328846254;
									switch ((num3 == num) ? 1 : 0)
									{
									case 0:
									case 2:
										goto IL_282;
									default:
										num = (short)546373632;
										if (num != 0)
										{
										}
										switch (0)
										{
										case 0:
											goto IL_27D;
										}
										continue;
									}
									break;
								}
								case 6:
									goto IL_370;
								}
								goto IL_27D;
								IL_282:
								acpFeatureNode = enumerator.Current;
								num = (short)1634205697;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								IL_318:
								num = (short)1692270592;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								IL_27D:
								goto IL_318;
							}
							IL_313:
							IL_370:
							return;
						}
						finally
						{
							num = (short)1552678913;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								global::System.Collections.Generic.IEnumerator<global::AcpBusinessLayer.FeatureNode> enumerator;
								switch (num2)
								{
								case 0:
									enumerator.Dispose();
									num = (short)286064642;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 1:
									switch (0)
									{
									case 0:
										goto IL_3A8;
									}
									continue;
								case 2:
									goto IL_3DF;
								}
								IL_3A8:
								if (enumerator == null)
								{
									break;
								}
								num = (short)1052966912;
								num2 = (int)((global::System.IntPtr)num);
							}
							IL_3DF:;
						}
						goto IL_3E2;
					case 7:
					{
						global::Motorola.MackinawCPS.CoreFeatures.Shepherds.SignalIndependentProductIndependentNonProgrammableButtonListInnerRecset signalIndependentProductIndependentNonProgrammableButtonListInnerRecset;
						global::System.Collections.Generic.IEnumerator<global::AcpBusinessLayer.FeatureNode> enumerator = signalIndependentProductIndependentNonProgrammableButtonListInnerRecset.GetEnumerator();
						num = (short)1664024582;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 8:
						goto IL_132;
					case 9:
						num = (short)264437765;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 10:
						num = (short)347340804;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 11:
						goto IL_132;
					case 12:
					{
						int value = radErgoControlO2MFKButtonPress_A.Value;
						task.AddTask(new global::AcpBusinessLayer.UndoRedo.ModifyDataTask<int>(radErgoControlO7MFKButtonPress_A, value));
						num = (short)1000341512;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 13:
						num = (short)359333889;
						if (num != 0)
						{
						}
						if (o2MultiFunctionKnob.RefRadioWide.Labtool.RadWideLabtoolMFKEmergencyAccess_A42216.Value)
						{
							num = (short)641859586;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return;
					case 14:
					{
						global::Motorola.MackinawCPS.CoreFeatures.Shepherds.SignalIndependentProductIndependentNonProgrammableButtonListInnerRecset signalIndependentProductIndependentNonProgrammableButtonListInnerRecset;
						if (signalIndependentProductIndependentNonProgrammableButtonListInnerRecset != null)
						{
							num = (short)725811207;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return;
					}
					case 15:
					{
						global::Motorola.MackinawCPS.CoreFeatures.Shepherds.SignalIndependentProductIndependentNonProgrammableButtonListInnerRecset signalIndependentProductIndependentNonProgrammableButtonListInnerRecset = shepherdsRecset[0][10031].EmbeddedRecset as global::Motorola.MackinawCPS.CoreFeatures.Shepherds.SignalIndependentProductIndependentNonProgrammableButtonListInnerRecset;
						num = (short)1258487822;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 16:
						if (global::ConstraintHelper.UtilityMack.IsMobile())
						{
							num = (short)1517551616;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return;
					case 17:
						goto IL_132;
					}
					goto IL_78;
					IL_132:
					shepherdsRecset = (global::AcpCommonLib.FeatureManager.GetFeature(2013) as global::Motorola.MackinawCPS.CoreFeatures.Shepherds.ShepherdsRecset);
					num = (short)1378025472;
					short num4 = num;
					num = (short)848101377;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_3E2:
					featureSectionId = self.FeatureSectionId;
					num = (short)1725890563;
					num2 = (int)((global::System.IntPtr)num);
				}
				return;
				IL_78:
				o2MultiFunctionKnob = (self as global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO2.O2MultiFunctionKnob);
				radErgoControlO2MFKButtonPress_A = o2MultiFunctionKnob.RadErgoControlO2MFKButtonPress_A42217;
				radErgoControlO7MFKButtonPress_A = o2MultiFunctionKnob.RefControlHeadO7.O7MultiFunctionKnob.RadErgoControlO7MFKButtonPress_A42218;
				num = (short)1068564496;
				num2 = (int)((global::System.IntPtr)num);
				goto IL_29;
			}
			}
		}

		// Token: 0x06008B62 RID: 35682 RVA: 0x008260CC File Offset: 0x008242CC
		internal static bool ConStandaloneRadioSystemEnableApp(global::AcpCommonLib.IAcpFeatureSection self)
		{
			switch (0)
			{
			case 0:
				goto IL_48;
			}
			short num;
			int num3;
			global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO2.ControlHeadO2 controlHeadO;
			for (;;)
			{
				IL_0A:
				num = (short)1218969600;
				short num2 = num;
				switch (num3)
				{
				case 0:
					goto IL_F6;
				case 1:
					controlHeadO = (self.ParentRecset.ParentSection.Parent as global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO2.ControlHeadO2);
					num = (short)1107427331;
					num3 = (int)((global::System.IntPtr)num);
					continue;
				case 2:
				{
					if (self.ParentRecset.IsEmbeddedRecset)
					{
						num = (short)2096300033;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					}
					num = (short)802356438;
					short num4 = num;
					num = (short)606338262;
					switch ((num4 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						break;
					default:
						num = (short)289669120;
						if (num != 0)
						{
						}
						controlHeadO = (self.Parent as global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO2.ControlHeadO2);
						num = (short)129957888;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					}
					break;
				}
				case 3:
					goto IL_14D;
				}
				goto IL_48;
			}
			IL_F6:
			num = (short)866975745;
			if (num != 0)
			{
			}
			IL_14D:
			return controlHeadO.O2MultiFunctionKnob.RefRadioWide.DualRadio.RadWideDualRadioSelection_A42236.Value == 0;
			IL_48:
			controlHeadO = null;
			num = (short)461242370;
			num3 = (int)((global::System.IntPtr)num);
			goto IL_0A;
		}

		// Token: 0x06008B63 RID: 35683 RVA: 0x00826248 File Offset: 0x00824448
		internal static bool ConControlHeadEmergencyFeaturesSelect(global::AcpCommonLib.IAcpFeatureSection self, int index)
		{
			short num = (short)918880256;
			int num2 = (int)num;
			switch (num2)
			{
			default:
			{
				bool result;
				for (;;)
				{
					IL_1D:
					switch (0)
					{
					case 0:
						goto IL_C6;
					}
					global::AcpBusinessLayer.AcpListField radWideDualRadioSelection_A;
					global::Motorola.MackinawCPS.CoreFeatures.RadioWide.Features features;
					global::AcpBusinessLayer.AcpListField radErgoWideControlHeadMultipleControlHeadStyle_A;
					global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO2.O2InnerSection o2InnerSection;
					global::AcpBusinessLayer.AcpField<bool> radErgoWideControlHeadMultiControlHead_A;
					for (;;)
					{
						IL_27:
						bool flag;
						bool flag2;
						bool flag3;
						switch (num2)
						{
						case 0:
							num = (short)760086560;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 1:
							flag = false;
							goto IL_389;
						case 2:
							if (index != 140)
							{
								num = (short)1974927397;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							result = (radWideDualRadioSelection_A.Value != 0);
							num = (short)339935249;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 3:
							return result;
						case 4:
							flag2 = true;
							goto IL_41E;
						case 5:
							if (radWideDualRadioSelection_A.Value == 1)
							{
								num = (short)940834841;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							goto IL_2D9;
						case 6:
							num = (short)586088460;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 7:
							return result;
						case 8:
							num = (short)715259918;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 9:
							if (index - 290 > 1)
							{
								num = (short)890699776;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							result = features.RadWideFeaturesChannelFallbackEnableValue;
							num = (short)1603338247;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 10:
							if (index != 31)
							{
								num = (short)1918107669;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							num = (short)1613758469;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 11:
							num = (short)888995862;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 12:
							flag = (radErgoWideControlHeadMultipleControlHeadStyle_A.Value == 0);
							goto IL_389;
						case 13:
							num = (short)926220289;
							if (num != 0)
							{
							}
							if (index - 124 > 2)
							{
								num = (short)1923809288;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							result = (radWideDualRadioSelection_A.Value == 0);
							num = (short)1345585155;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 14:
							if (index != 138)
							{
								num = (short)961609752;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							num = (short)1264582679;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 15:
						{
							num = (short)1770299209;
							short num3 = num;
							num = (short)940547913;
							switch ((num3 == num) ? 1 : 0)
							{
							case 0:
							case 2:
								goto IL_1D;
							default:
								num = (short)861667328;
								if (num != 0)
								{
								}
								goto IL_1EC;
							}
							break;
						}
						case 16:
							return result;
						case 17:
							return result;
						case 18:
							if (o2InnerSection.RefRadioWide.DualRadio.RadWideDualRadioEmergencyRadio_A42239.Value == 2)
							{
								num = (short)1468399642;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							goto IL_2D9;
						case 19:
							num = (short)339607561;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 20:
							if (radErgoWideControlHeadMultipleControlHeadStyle_A.Value == 1)
							{
								num = (short)2056519691;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							goto IL_1EC;
						case 21:
							num = (short)860749837;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 22:
							if (!radErgoWideControlHeadMultiControlHead_A.Value)
							{
								num = (short)1149894671;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							num = (short)462684187;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 23:
							if (radErgoWideControlHeadMultiControlHead_A.Value)
							{
								num = (short)2025586694;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							num = (short)329318401;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 24:
							num = (short)2125004835;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 25:
							num = (short)1374748690;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 26:
							num = (short)466550815;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 27:
							flag3 = true;
							goto IL_623;
						case 28:
							num = (short)1811742730;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 29:
							return result;
						case 30:
							if (index != 163)
							{
								num = (short)925106195;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							num = (short)261947412;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 31:
							flag2 = !o2InnerSection.RefRadioWide.Features.RadWideTPSFiregroundEvacuationTone_A7980.Value;
							goto IL_41E;
						case 32:
							return result;
						case 33:
							return result;
						case 34:
							flag3 = !radErgoWideControlHeadMultiControlHead_A.Value;
							goto IL_623;
						case 35:
							return result;
						case 36:
							if (index <= 138)
							{
								num = (short)937492508;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							num = (short)1603272706;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 37:
							num = (short)151781406;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						break;
						IL_1EC:
						num = (short)880214050;
						num2 = (int)((global::System.IntPtr)num);
						continue;
						IL_2D9:
						num = (short)2127953924;
						num2 = (int)((global::System.IntPtr)num);
						continue;
						IL_389:
						result = flag;
						num = (short)241893405;
						num2 = (int)((global::System.IntPtr)num);
						continue;
						IL_41E:
						result = flag2;
						num = (short)327221264;
						num2 = (int)((global::System.IntPtr)num);
						continue;
						IL_623:
						result = flag3;
						num = (short)1979449377;
						num2 = (int)((global::System.IntPtr)num);
					}
					IL_C6:
					num = (short)556204032;
					short num4 = num;
					o2InnerSection = (self as global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO2.O2InnerSection);
					radErgoWideControlHeadMultipleControlHeadStyle_A = o2InnerSection.RefRadioErgonomicsWide.ControlHead.RadErgoWideControlHeadMultipleControlHeadStyle_A8561;
					radWideDualRadioSelection_A = o2InnerSection.RefRadioWide.DualRadio.RadWideDualRadioSelection_A42236;
					radErgoWideControlHeadMultiControlHead_A = o2InnerSection.RefRadioErgonomicsWide.ControlHead.RadErgoWideControlHeadMultiControlHead_A8550;
					features = (global::AcpCommonLib.FeatureManager.GetFeature(2045)[0][10105] as global::Motorola.MackinawCPS.CoreFeatures.RadioWide.Features);
					result = true;
					num = (short)2090795044;
					num2 = (int)((global::System.IntPtr)num);
					goto IL_27;
				}
				return result;
			}
			}
		}
	}
}
