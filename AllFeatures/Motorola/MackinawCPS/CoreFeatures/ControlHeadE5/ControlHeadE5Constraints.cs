using System;
using System.Collections.Generic;
using AcpBusinessLayer;
using AcpBusinessLayer.UndoRedo;
using AcpCommonLib;
using AcpCommonLib.UndoRedo;
using Motorola.MackinawCPS.CoreFeatures.ActionConsolidation;
using Motorola.MackinawCPS.CoreFeatures.ControlHeadO2;
using Motorola.MackinawCPS.CoreFeatures.ControlHeadO3;
using Motorola.MackinawCPS.CoreFeatures.ControlHeadO5;
using Motorola.MackinawCPS.CoreFeatures.ControlHeadO7;
using Motorola.MackinawCPS.CoreFeatures.ControlHeadO9;
using Motorola.MackinawCPS.CoreFeatures.DEK;
using Motorola.MackinawCPS.CoreFeatures.KeypadMicAndAccessories;
using Motorola.MackinawCPS.CoreFeatures.RadioErgonomicsWide;
using Motorola.MackinawCPS.CoreFeatures.RadioVIPs;
using Motorola.MackinawCPS.CoreFeatures.RadioWide;
using Motorola.MackinawCPS.CoreFeatures.Shepherds;

namespace Motorola.MackinawCPS.CoreFeatures.ControlHeadE5
{
	// Token: 0x020003E8 RID: 1000
	public static class ControlHeadE5Constraints
	{
		// Token: 0x06008C88 RID: 35976 RVA: 0x00836964 File Offset: 0x00834B64
		public static bool ConDownButtonApplicable(global::AcpCommonLib.IAcpFeatureSection self)
		{
			switch (0)
			{
			case 0:
				goto IL_28;
			}
			global::AcpCommonLib.IAcpRecordset parentRecset;
			short num2;
			for (;;)
			{
				IL_0A:
				int num;
				switch (num)
				{
				case 0:
					goto IL_11E;
				case 1:
					if (parentRecset.Count > 1)
					{
						num2 = (short)1060962309;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					return true;
				case 2:
					if (parentRecset != null)
					{
						num2 = (short)1053360131;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					return true;
				case 3:
					num2 = (short)1898381313;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 4:
					return false;
				case 5:
					num2 = (short)2093940736;
					num = (int)((global::System.IntPtr)num2);
					continue;
				}
				goto IL_28;
			}
			return false;
			IL_28:
			num2 = (short)748027904;
			short num3 = num2;
			num2 = (short)430047233;
			if (num2 != 0)
			{
			}
			parentRecset = self.ParentRecset;
			num2 = (short)724824119;
			short num4 = num2;
			num2 = (short)897642551;
			switch ((num4 == num2) ? 1 : 0)
			{
			case 0:
			case 2:
				IL_11E:
				if (parentRecset[1] == self.Parent)
				{
					num2 = (short)23920644;
					int num = (int)((global::System.IntPtr)num2);
					goto IL_0A;
				}
				break;
			default:
			{
				num2 = (short)1940717568;
				if (num2 != 0)
				{
				}
				num2 = (short)417595394;
				int num = (int)((global::System.IntPtr)num2);
				goto IL_0A;
			}
			}
			return true;
		}

		// Token: 0x06008C89 RID: 35977 RVA: 0x00836AF4 File Offset: 0x00834CF4
		public static void ConSyncUpDownBtnFeature(global::AcpCommonLib.IAcpFeatureSection self, global::AcpCommonLib.UndoRedo.ContainerTask task)
		{
			short num = (short)1377501184;
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
				bool flag;
				int num4;
				global::AcpCommonLib.IAcpRecordset parentRecset;
				for (;;)
				{
					IL_27:
					global::Motorola.MackinawCPS.CoreFeatures.ControlHeadE5.E5NavigationControlsTableInnerSection e5NavigationControlsTableInnerSection;
					switch (num2)
					{
					case 0:
						if (num3 == 0)
						{
							num = (short)1889927194;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)2130182161;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 1:
						if (!flag)
						{
							num = (short)239992870;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num3 = e5NavigationControlsTableInnerSection.RadErgoControlE5UpDownButton_43752.Value;
						num4 = num3 - 1;
						num = (short)1624178696;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 2:
						flag = true;
						num = (short)670040093;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 3:
						goto IL_157;
					case 4:
						num = (short)1428291585;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 5:
						goto IL_3BA;
					case 6:
					{
						num = (short)1258631191;
						short num5 = num;
						num = (short)393490455;
						switch ((num5 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_40A;
						default:
							num = (short)740294656;
							if (num != 0)
							{
							}
							num = (short)1489240103;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						break;
					}
					case 7:
						goto IL_40A;
					case 8:
						if (num3 == 38)
						{
							num = (short)1386217479;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_5D8;
					case 9:
						goto IL_5D8;
					case 10:
						if (num4 != 65)
						{
							num = (short)1179254814;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_396;
					case 11:
						goto IL_157;
					case 12:
						num3 = 38;
						num = (short)34799639;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 13:
						if (parentRecset != null)
						{
							num = (short)422314020;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return;
					case 14:
						if (num3 != 143)
						{
							num = (short)1417674771;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_396;
					case 15:
						goto IL_44D;
					case 16:
						if (num4 != 0)
						{
							num = (short)448659478;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return;
					case 17:
						if (num4 != 144)
						{
							num = (short)2028732437;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_396;
					case 18:
						if (num3 == 87)
						{
							num = (short)1392050201;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_6E7;
					case 19:
						num = (short)1419051040;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 20:
						if (parentRecset.Count < 2)
						{
							num = (short)21430287;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)1907949596;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 21:
						num = (short)429457418;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 22:
						num = (short)145424384;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 23:
						goto IL_4AD;
					case 24:
						num = (short)1780154403;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 25:
						goto IL_396;
					case 26:
						goto IL_6E2;
					case 27:
						if (e5NavigationControlsTableInnerSection != null)
						{
							num = (short)1784741892;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return;
					case 28:
						if (parentRecset[1] == self.Parent)
						{
							num = (short)74645506;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_193;
					case 29:
						goto IL_193;
					case 30:
						num = (short)890306593;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 31:
					{
						num = (short)1616314368;
						short num6 = num;
						num = (short)1629093902;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 32:
						if (num3 != 64)
						{
							num = (short)1662517272;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_396;
					case 33:
						if (num4 != 67)
						{
							num = (short)1788805126;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_396;
					case 34:
						num = (short)1391001618;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 35:
						if (num3 != 66)
						{
							num = (short)839516194;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_396;
					case 36:
						num = (short)286457876;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 37:
						if (num4 == 38)
						{
							num = (short)682688513;
							if (num != 0)
							{
							}
							num = (short)372768780;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_4AD;
					case 38:
						num4 = e5NavigationControlsTableInnerSection.RadErgoControlE5UpDownButton_43752.Value;
						num3 = num4 + 1;
						num = (short)1430650917;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 39:
						if (num4 != 88)
						{
							num = (short)2085814303;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_396;
					}
					goto IL_CE;
					IL_157:
					num = (short)1186725904;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_193:
					e5NavigationControlsTableInnerSection = (self as global::Motorola.MackinawCPS.CoreFeatures.ControlHeadE5.E5NavigationControlsTableInnerSection);
					num = (short)374538267;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_396:
					num4 = 143;
					num3 = 144;
					num = (short)376504325;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_40A:
					num4 = 38;
					num = (short)1540554761;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_4AD:
					task.AddTask(new global::AcpBusinessLayer.UndoRedo.ModifyDataTask<int>((self.ParentRecset[1] as global::Motorola.MackinawCPS.CoreFeatures.ControlHeadE5.E5NavigationControlsTableInner).E5NavigationControlsTableInnerSection.RadErgoControlE5UpDownButton_43752, num3));
					num = (short)490340363;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_5D8:
					task.AddTask(new global::AcpBusinessLayer.UndoRedo.ModifyDataTask<int>((self.ParentRecset[0] as global::Motorola.MackinawCPS.CoreFeatures.ControlHeadE5.E5NavigationControlsTableInner).E5NavigationControlsTableInnerSection.RadErgoControlE5UpDownButton_43752, num4));
					num = (short)1696137219;
					num2 = (int)((global::System.IntPtr)num);
				}
				return;
				IL_3BA:
				goto IL_6E7;
				IL_44D:
				return;
				IL_6E2:
				return;
				IL_6E7:
				global::Motorola.MackinawCPS.CoreFeatures.ControlHeadE5.ControlHeadE5Constraints.SyncNavigationControlsCPField(task, num4, num3);
				global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO2.ControlHeadO2Constraints.SyncO2NavigationControls(task, num4, num3);
				global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO3.ControlHeadO3Constraints.SyncO3NavigationControls(task, num4, num3);
				global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO7.ControlHeadO7Constraints.SyncO7NavigationControls(task, num4, num3);
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
				num = (short)1989083149;
				num2 = (int)((global::System.IntPtr)num);
				goto IL_27;
			}
			}
		}

		// Token: 0x06008C8A RID: 35978 RVA: 0x00837228 File Offset: 0x00835428
		public static void SyncE5NavigationControls(global::AcpCommonLib.UndoRedo.ContainerTask task, int upButtonConfigedFeatureValue, int downButtonConfigedFeatureValue)
		{
			short num = (short)258998272;
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
				global::Motorola.MackinawCPS.CoreFeatures.ControlHeadE5.E5NavigationControlsTableInnerRecset e5NavigationControlsTableInnerRecset;
				for (;;)
				{
					IL_28:
					num = (short)1906638848;
					short num3 = num;
					switch (num2)
					{
					case 0:
						if (e5NavigationControlsTableInnerRecset != null)
						{
							num = (short)901644292;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return;
					case 1:
					{
						global::Motorola.MackinawCPS.CoreFeatures.ControlHeadE5.ControlHeadE5Recset controlHeadE5Recset;
						if (controlHeadE5Recset != null)
						{
							num = (short)312999938;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return;
					}
					case 2:
					{
						global::Motorola.MackinawCPS.CoreFeatures.ControlHeadE5.ControlHeadE5Recset controlHeadE5Recset;
						e5NavigationControlsTableInnerRecset = (controlHeadE5Recset[0][10896].EmbeddedRecset as global::Motorola.MackinawCPS.CoreFeatures.ControlHeadE5.E5NavigationControlsTableInnerRecset);
						num = (short)1776025600;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 3:
						goto IL_194;
					case 4:
						goto IL_1E5;
					}
					goto IL_6B;
				}
				IL_194:
				return;
				IL_1E5:
				global::AcpBusinessLayer.AcpListField radErgoControlE5UpDownButton_ = (e5NavigationControlsTableInnerRecset[0][10897] as global::Motorola.MackinawCPS.CoreFeatures.ControlHeadE5.E5NavigationControlsTableInnerSection).RadErgoControlE5UpDownButton_43752;
				task.AddTask(new global::AcpBusinessLayer.UndoRedo.ModifyDataTask<int>(radErgoControlE5UpDownButton_, upButtonConfigedFeatureValue));
				global::AcpBusinessLayer.AcpListField radErgoControlE5UpDownButton_2 = (e5NavigationControlsTableInnerRecset[1][10897] as global::Motorola.MackinawCPS.CoreFeatures.ControlHeadE5.E5NavigationControlsTableInnerSection).RadErgoControlE5UpDownButton_43752;
				task.AddTask(new global::AcpBusinessLayer.UndoRedo.ModifyDataTask<int>(radErgoControlE5UpDownButton_2, downButtonConfigedFeatureValue));
				goto IL_154;
				IL_6B:
				num = (short)2053702007;
				short num4 = num;
				num = (short)1515520375;
				switch ((num4 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					IL_154:
					num = (short)1122107393;
					if (num != 0)
					{
					}
					num = (short)2040528899;
					num2 = (int)((global::System.IntPtr)num);
					goto IL_28;
				default:
				{
					num = (short)664731648;
					if (num != 0)
					{
					}
					global::Motorola.MackinawCPS.CoreFeatures.ControlHeadE5.ControlHeadE5Recset controlHeadE5Recset = global::AcpCommonLib.FeatureManager.GetFeature(4236) as global::Motorola.MackinawCPS.CoreFeatures.ControlHeadE5.ControlHeadE5Recset;
					num = (short)52756481;
					num2 = (int)((global::System.IntPtr)num);
					goto IL_28;
				}
				}
				break;
			}
			}
		}

		// Token: 0x06008C8B RID: 35979 RVA: 0x00837420 File Offset: 0x00835620
		public static void SyncNavigationControlsCPField(global::AcpCommonLib.UndoRedo.ContainerTask task, int upButtonConfigedFeatureValue, int downButtonConfigedFeatureValue)
		{
			short num = (short)809124958;
			short num2 = num;
			num = (short)1834894430;
			switch ((num2 == num) ? 1 : 0)
			{
			case 0:
			case 2:
				break;
			default:
			{
				num = (short)1479016448;
				if (num != 0)
				{
				}
				num = (short)183435264;
				short num3 = num;
				num = (short)790626304;
				switch (num)
				{
				}
				break;
			}
			}
			num = (short)2083651585;
			if (num != 0)
			{
			}
			global::System.Collections.Generic.IEnumerator<global::AcpBusinessLayer.FeatureNode> enumerator = ((global::AcpCommonLib.FeatureManager.GetFeature(2013) as global::Motorola.MackinawCPS.CoreFeatures.Shepherds.ShepherdsRecset)[0][10031].EmbeddedRecset as global::Motorola.MackinawCPS.CoreFeatures.Shepherds.SignalIndependentProductIndependentNonProgrammableButtonListInnerRecset).GetEnumerator();
			try
			{
				num = (short)1037500426;
				int num4 = (int)((global::System.IntPtr)num);
				for (;;)
				{
					switch (num4)
					{
					case 0:
					{
						global::AcpCommonLib.IAcpFeatureNode acpFeatureNode;
						task.AddTask(new global::AcpBusinessLayer.UndoRedo.ModifyDataTask<int>((acpFeatureNode[10032] as global::Motorola.MackinawCPS.CoreFeatures.Shepherds.SignalIndependentProductIndependentNonProgrammableButtonListInnerSection).RadErgoCfgSignalIndependentProductIndependentNonProgrammableButtonFeature_A19778, upButtonConfigedFeatureValue));
						num = (short)1324351501;
						num4 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 1:
					{
						int value;
						if (value == 135)
						{
							num = (short)1084424203;
							num4 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)1362821124;
						num4 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 2:
					{
						int value2;
						if (upButtonConfigedFeatureValue != value2)
						{
							num = (short)1506279424;
							num4 = (int)((global::System.IntPtr)num);
							continue;
						}
						break;
					}
					case 3:
					{
						global::AcpCommonLib.IAcpFeatureNode acpFeatureNode;
						int value3 = (acpFeatureNode[10032] as global::Motorola.MackinawCPS.CoreFeatures.Shepherds.SignalIndependentProductIndependentNonProgrammableButtonListInnerSection).RadErgoCfgSignalIndependentProductIndependentNonProgrammableButtonFeature_A19778.Value;
						num = (short)901971973;
						num4 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 4:
					{
						int value;
						if (value == 136)
						{
							num = (short)256901123;
							num4 = (int)((global::System.IntPtr)num);
							continue;
						}
						break;
					}
					case 5:
					{
						int value3;
						if (downButtonConfigedFeatureValue != value3)
						{
							num = (short)238157832;
							num4 = (int)((global::System.IntPtr)num);
							continue;
						}
						break;
					}
					case 7:
						num = (short)1053818889;
						num4 = (int)((global::System.IntPtr)num);
						continue;
					case 8:
					{
						global::AcpCommonLib.IAcpFeatureNode acpFeatureNode;
						task.AddTask(new global::AcpBusinessLayer.UndoRedo.ModifyDataTask<int>((acpFeatureNode[10032] as global::Motorola.MackinawCPS.CoreFeatures.Shepherds.SignalIndependentProductIndependentNonProgrammableButtonListInnerSection).RadErgoCfgSignalIndependentProductIndependentNonProgrammableButtonFeature_A19778, downButtonConfigedFeatureValue));
						num = (short)354942982;
						num4 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 9:
						goto IL_373;
					case 10:
						switch (0)
						{
						case 0:
							goto IL_14A;
						}
						continue;
					case 11:
					{
						global::AcpCommonLib.IAcpFeatureNode acpFeatureNode;
						int value2 = (acpFeatureNode[10032] as global::Motorola.MackinawCPS.CoreFeatures.Shepherds.SignalIndependentProductIndependentNonProgrammableButtonListInnerSection).RadErgoCfgSignalIndependentProductIndependentNonProgrammableButtonFeature_A19778.Value;
						num = (short)149815298;
						num4 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 12:
					{
						if (!enumerator.MoveNext())
						{
							num = (short)1701642247;
							num4 = (int)((global::System.IntPtr)num);
							continue;
						}
						global::AcpCommonLib.IAcpFeatureNode acpFeatureNode = enumerator.Current;
						int value = (acpFeatureNode[10032] as global::Motorola.MackinawCPS.CoreFeatures.Shepherds.SignalIndependentProductIndependentNonProgrammableButtonListInnerSection).RadErgoCfgSignalIndependentProductIndependentNonProgrammableButtonBCO_A19777.Value;
						num = (short)1235877889;
						num4 = (int)((global::System.IntPtr)num);
						continue;
					}
					}
					IL_29C:
					num = (short)1950679052;
					num4 = (int)((global::System.IntPtr)num);
					continue;
					IL_14A:
					goto IL_29C;
				}
				IL_373:;
			}
			finally
			{
				num = (short)1025310720;
				int num4 = (int)((global::System.IntPtr)num);
				for (;;)
				{
					switch (num4)
					{
					case 0:
						switch (0)
						{
						case 0:
							goto IL_3A8;
						}
						continue;
					case 1:
						enumerator.Dispose();
						num = (short)634585090;
						num4 = (int)((global::System.IntPtr)num);
						continue;
					case 2:
						goto IL_3DF;
					}
					IL_3A8:
					if (enumerator == null)
					{
						break;
					}
					num = (short)353501185;
					num4 = (int)((global::System.IntPtr)num);
				}
				IL_3DF:;
			}
		}

		// Token: 0x06008C8C RID: 35980 RVA: 0x0083782C File Offset: 0x00835A2C
		public static void ConSyncBottomFunctionButton(global::AcpCommonLib.IAcpFeatureSection self, global::AcpCommonLib.UndoRedo.ContainerTask task)
		{
			short num = (short)1541799936;
			int num2 = (int)num;
			switch (num2)
			{
			default:
			{
				switch (0)
				{
				case 0:
					goto IL_A2;
				}
				global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO9.BottomFunctionProgrammableButtonInnerSection bottomFunctionProgrammableButtonInnerSection;
				global::Motorola.MackinawCPS.CoreFeatures.ControlHeadE5.E5BottomFunctionButtonInnerSection e5BottomFunctionButtonInnerSection;
				for (;;)
				{
					IL_27:
					object obj;
					global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO9.RelayPatternBCOListListInnerRecset relayPatternBCOListListInnerRecset;
					global::AcpBusinessLayer.AcpListField acpListField;
					global::System.Collections.Generic.IEnumerator<global::AcpBusinessLayer.FeatureNode> enumerator;
					global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO9.ControlHeadO9Recset controlHeadO9Recset;
					object obj2;
					global::AcpBusinessLayer.AcpListField acpListField2;
					global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO9.BottomFunctionButtonBCOListInnerRecset bottomFunctionButtonBCOListInnerRecset;
					switch (num2)
					{
					case 0:
						if (bottomFunctionProgrammableButtonInnerSection != null)
						{
							num = (short)181534725;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return;
					case 1:
						obj = null;
						goto IL_1C6;
					case 2:
						num = (short)1948975124;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 3:
					{
						global::Motorola.MackinawCPS.CoreFeatures.RadioWide.GeneralLightbarPatternInnerRecset recset = (global::AcpCommonLib.FeatureManager.GetFeature(2045) as global::Motorola.MackinawCPS.CoreFeatures.RadioWide.RadioWideRecset)[0][10604].EmbeddedRecset as global::Motorola.MackinawCPS.CoreFeatures.RadioWide.GeneralLightbarPatternInnerRecset;
						bottomFunctionProgrammableButtonInnerSection.CHO9BottomFunctionButtonIndex_A36665.SetRecset(recset);
						task.AddTask(new global::AcpBusinessLayer.UndoRedo.AddRecordTask(relayPatternBCOListListInnerRecset.CreateDefaultRecord()));
						int index = relayPatternBCOListListInnerRecset.Count - 1;
						global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO9.RelayPatternBCOListListInner relayPatternBCOListListInner = relayPatternBCOListListInnerRecset[index] as global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO9.RelayPatternBCOListListInner;
						global::AcpBusinessLayer.AcpListField e5BottomFunctionButtonBCO_;
						task.AddTask(new global::AcpBusinessLayer.UndoRedo.ModifyDataTask<int>(relayPatternBCOListListInner.RelayPatternBCOListListInnerSection.RdEgoO9DirLtbarPatternBcoListBco_A36661, e5BottomFunctionButtonBCO_.Value));
						task.AddTask(new global::AcpBusinessLayer.UndoRedo.ModifyRecRefDataTask(relayPatternBCOListListInner.RelayPatternBCOListListInnerSection.RdEgoO9DirLtbarPatternBcoListIndex_A36707, e5BottomFunctionButtonInnerSection.E5BottomFunctionButtonIndex_43759.UIValue));
						num = (short)1730084882;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 4:
						num = (short)1547829249;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 5:
						num = (short)1732313112;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 6:
						goto IL_1D6;
					case 7:
					{
						num = (short)632815616;
						short num3 = num;
						num = (short)1411645454;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 8:
						acpListField = e5BottomFunctionButtonInnerSection.E5BottomFunctionButtonFeature_43758;
						goto IL_9D2;
					case 9:
						try
						{
							num = (short)1607663621;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								num = (short)1293133325;
								short num4 = num;
								num = (short)2120132109;
								switch ((num4 == num) ? 1 : 0)
								{
								case 0:
								case 2:
									break;
								default:
									num = (short)2012479488;
									if (num != 0)
									{
									}
									switch (num2)
									{
									case 0:
										goto IL_7AF;
									case 1:
									{
										global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO9.RelayPatternBCOListListInner relayPatternBCOListListInner2;
										task.AddTask(new global::AcpBusinessLayer.UndoRedo.DeleteRecordTask(relayPatternBCOListListInner2));
										num = (short)1850015744;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									case 2:
									{
										global::AcpBusinessLayer.AcpListField e5BottomFunctionButtonBCO_;
										global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO9.RelayPatternBCOListListInner relayPatternBCOListListInner2;
										if (relayPatternBCOListListInner2.RelayPatternBCOListListInnerSection.RdEgoO9DirLtbarPatternBcoListBco_A36661.Value == e5BottomFunctionButtonBCO_.Value)
										{
											num = (short)479395841;
											num2 = (int)((global::System.IntPtr)num);
											continue;
										}
										break;
									}
									case 3:
										goto IL_80D;
									case 4:
									{
										if (!enumerator.MoveNext())
										{
											num = (short)1236467718;
											num2 = (int)((global::System.IntPtr)num);
											continue;
										}
										global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO9.RelayPatternBCOListListInner relayPatternBCOListListInner2 = (global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO9.RelayPatternBCOListListInner)enumerator.Current;
										num = (short)1962541058;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									case 5:
										switch (0)
										{
										case 0:
											goto IL_72A;
										}
										continue;
									case 6:
										goto IL_7F4;
									}
									IL_7B4:
									num = (short)769851396;
									num2 = (int)((global::System.IntPtr)num);
									continue;
									IL_72A:
									goto IL_7B4;
								}
								IL_7F4:
								num = (short)2057109507;
								num2 = (int)((global::System.IntPtr)num);
							}
							IL_7AF:
							IL_80D:
							goto IL_35C;
						}
						finally
						{
							num = (short)2067398657;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								switch (num2)
								{
								case 0:
									enumerator.Dispose();
									num = (short)861798402;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 1:
									switch (0)
									{
									case 0:
										goto IL_845;
									}
									continue;
								case 2:
									goto IL_87D;
								}
								IL_845:
								if (enumerator == null)
								{
									break;
								}
								num = (short)1568800768;
								num2 = (int)((global::System.IntPtr)num);
							}
							IL_87D:;
						}
						goto IL_880;
					case 10:
						if (controlHeadO9Recset == null)
						{
							num = (short)1096810500;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)35651595;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 11:
						obj = controlHeadO9Recset[0][10618].EmbeddedRecset;
						goto IL_1C6;
					case 12:
						obj2 = null;
						goto IL_57D;
					case 13:
						try
						{
							num = (short)2101673989;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								switch (num2)
								{
								case 0:
								{
									if (!enumerator.MoveNext())
									{
										num = (short)1920598020;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO9.ConsolidatedActionBCOListInner consolidatedActionBCOListInner = (global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO9.ConsolidatedActionBCOListInner)enumerator.Current;
									num = (short)678428674;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 1:
								{
									global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO9.ConsolidatedActionBCOListInner consolidatedActionBCOListInner;
									task.AddTask(new global::AcpBusinessLayer.UndoRedo.DeleteRecordTask(consolidatedActionBCOListInner));
									num = (short)849543174;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 2:
								{
									global::AcpBusinessLayer.AcpListField e5BottomFunctionButtonBCO_;
									global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO9.ConsolidatedActionBCOListInner consolidatedActionBCOListInner;
									if (consolidatedActionBCOListInner.ConsolidatedActionBCOListInnerSection.RadErgoControlO9ACBCOListBco_A36666.Value == e5BottomFunctionButtonBCO_.Value)
									{
										num = (short)2006712321;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									break;
								}
								case 3:
									goto IL_B37;
								case 4:
									num = (short)46465027;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 5:
									switch (0)
									{
									case 0:
										goto IL_A62;
									}
									continue;
								case 6:
									goto IL_B19;
								}
								IL_AB9:
								num = (short)1030488064;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								IL_A62:
								goto IL_AB9;
							}
							IL_B19:
							IL_B37:
							goto IL_1D6;
						}
						finally
						{
							num = (short)1895759873;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								switch (num2)
								{
								case 0:
									enumerator.Dispose();
									num = (short)1334968322;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 1:
									switch (0)
									{
									case 0:
										goto IL_B70;
									}
									continue;
								case 2:
									goto IL_BA7;
								}
								IL_B70:
								if (enumerator == null)
								{
									break;
								}
								num = (short)344326144;
								num2 = (int)((global::System.IntPtr)num);
							}
							IL_BA7:;
						}
						goto IL_BAA;
					case 14:
						return;
					case 15:
						num = (short)409141276;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 16:
					{
						global::Motorola.MackinawCPS.CoreFeatures.ActionConsolidation.ActionConsolidationRecset recset2 = global::AcpCommonLib.FeatureManager.GetFeature(4008) as global::Motorola.MackinawCPS.CoreFeatures.ActionConsolidation.ActionConsolidationRecset;
						bottomFunctionProgrammableButtonInnerSection.CHO9BottomFunctionButtonIndex_A36665.SetRecset(recset2);
						global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO9.ConsolidatedActionBCOListInnerRecset consolidatedActionBCOListInnerRecset;
						task.AddTask(new global::AcpBusinessLayer.UndoRedo.AddRecordTask(consolidatedActionBCOListInnerRecset.CreateDefaultRecord()));
						int index2 = consolidatedActionBCOListInnerRecset.Count - 1;
						global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO9.ConsolidatedActionBCOListInner consolidatedActionBCOListInner2 = consolidatedActionBCOListInnerRecset[index2] as global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO9.ConsolidatedActionBCOListInner;
						global::AcpBusinessLayer.AcpListField e5BottomFunctionButtonBCO_;
						task.AddTask(new global::AcpBusinessLayer.UndoRedo.ModifyDataTask<int>(consolidatedActionBCOListInner2.ConsolidatedActionBCOListInnerSection.RadErgoControlO9ACBCOListBco_A36666, e5BottomFunctionButtonBCO_.Value));
						task.AddTask(new global::AcpBusinessLayer.UndoRedo.ModifyRecRefDataTask(consolidatedActionBCOListInner2.ConsolidatedActionBCOListInnerSection.RadErgoControlO9ACBCOListIndex_A36668, e5BottomFunctionButtonInnerSection.E5BottomFunctionButtonIndex_43759.UIValue));
						num = (short)66256902;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 17:
						if (acpListField2.Value == 207)
						{
							num = (short)456720387;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						enumerator = relayPatternBCOListListInnerRecset.GetEnumerator();
						num = (short)1585446921;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 18:
						goto IL_35C;
					case 19:
					{
						if (acpListField2.Value == 206)
						{
							num = (short)968294416;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO9.ConsolidatedActionBCOListInnerRecset consolidatedActionBCOListInnerRecset;
						enumerator = consolidatedActionBCOListInnerRecset.GetEnumerator();
						num = (short)740491277;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 20:
						if (bottomFunctionProgrammableButtonInnerSection.CHO9BottomFunctionButtonFeature_A36664.Value != acpListField2.Value)
						{
							num = (short)2088370202;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_35C;
					case 21:
						if (bottomFunctionButtonBCOListInnerRecset == null)
						{
							num = (short)1860173831;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_880;
					case 22:
						goto IL_911;
					case 23:
					{
						global::AcpBusinessLayer.AcpListField e5BottomFunctionButtonBCO_;
						if (bottomFunctionProgrammableButtonInnerSection.CHO9BottomFunctionButtonBCO_A36660.Value == e5BottomFunctionButtonBCO_.Value)
						{
							num = (short)1599864834;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_35C;
					}
					case 24:
					{
						if (acpListField2 == null)
						{
							num = (short)1402339350;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						global::AcpBusinessLayer.AcpListField e5BottomFunctionButtonBCO_ = e5BottomFunctionButtonInnerSection.E5BottomFunctionButtonBCO_43757;
						num = (short)1947729943;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 25:
						if (e5BottomFunctionButtonInnerSection == null)
						{
							num = (short)607387649;
							if (num != 0)
							{
							}
							num = (short)719323151;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)2122121224;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 26:
					{
						task.AddTask(new global::AcpBusinessLayer.UndoRedo.ModifyDataTask<int>(bottomFunctionProgrammableButtonInnerSection.CHO9BottomFunctionButtonFeature_A36664, acpListField2.Value));
						global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO9.ConsolidatedActionBCOListInnerRecset consolidatedActionBCOListInnerRecset = controlHeadO9Recset[0][10622].EmbeddedRecset as global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO9.ConsolidatedActionBCOListInnerRecset;
						num = (short)1522466835;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 27:
						try
						{
							num = (short)1203306501;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								switch (num2)
								{
								case 0:
								{
									global::AcpBusinessLayer.AcpListField e5BottomFunctionButtonBCO_;
									global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO9.BottomFunctionButtonBCOListInner bottomFunctionButtonBCOListInner;
									if (bottomFunctionButtonBCOListInner.BottomFunctionButtonBCOListInnerSection.CHO9BottomFunctionButtonBCO_A36827.Value == e5BottomFunctionButtonBCO_.Value)
									{
										num = (short)350158852;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									break;
								}
								case 1:
									num = (short)1438449667;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 2:
								{
									if (!enumerator.MoveNext())
									{
										num = (short)6291457;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO9.BottomFunctionButtonBCOListInner bottomFunctionButtonBCOListInner = (global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO9.BottomFunctionButtonBCOListInner)enumerator.Current;
									num = (short)629080064;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 3:
									goto IL_50A;
								case 4:
								{
									global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO9.BottomFunctionButtonBCOListInner bottomFunctionButtonBCOListInner;
									task.AddTask(new global::AcpBusinessLayer.UndoRedo.ModifyDataTask<int>(bottomFunctionButtonBCOListInner.BottomFunctionButtonBCOListInnerSection.CHO9BottomFunctionButtonFeature_A36826, acpListField2.Value));
									num = (short)2080571398;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 5:
									switch (0)
									{
									case 0:
										goto IL_420;
									}
									continue;
								case 6:
									goto IL_4ED;
								}
								IL_422:
								num = (short)949092354;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								IL_420:
								goto IL_422;
							}
							IL_4ED:
							IL_50A:
							goto IL_BAA;
						}
						finally
						{
							num = (short)1098973185;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								switch (num2)
								{
								case 0:
									enumerator.Dispose();
									num = (short)1762852866;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 1:
									switch (0)
									{
									case 0:
										goto IL_541;
									}
									continue;
								case 2:
									goto IL_57A;
								}
								IL_541:
								if (enumerator == null)
								{
									break;
								}
								num = (short)166854656;
								num2 = (int)((global::System.IntPtr)num);
							}
							IL_57A:;
						}
						goto IL_57D;
					case 28:
						acpListField = null;
						goto IL_9D2;
					}
					goto IL_A2;
					IL_1C6:
					global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO9.BottomFunctionProgrammableButtonInnerRecset bottomFunctionProgrammableButtonInnerRecset = obj as global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO9.BottomFunctionProgrammableButtonInnerRecset;
					if (bottomFunctionProgrammableButtonInnerRecset == null)
					{
						num = (short)645267468;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					obj2 = bottomFunctionProgrammableButtonInnerRecset[0][10619];
					goto IL_57D;
					IL_1D6:
					relayPatternBCOListListInnerRecset = (controlHeadO9Recset[0][10620].EmbeddedRecset as global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO9.RelayPatternBCOListListInnerRecset);
					num = (short)934477841;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_35C:
					bottomFunctionButtonBCOListInnerRecset = (controlHeadO9Recset[0][10628].EmbeddedRecset as global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO9.BottomFunctionButtonBCOListInnerRecset);
					num = (short)1289355285;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_57D:
					bottomFunctionProgrammableButtonInnerSection = (obj2 as global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO9.BottomFunctionProgrammableButtonInnerSection);
					num = (short)408289280;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_880:
					enumerator = bottomFunctionButtonBCOListInnerRecset.GetEnumerator();
					num = (short)468910107;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_9D2:
					acpListField2 = acpListField;
					controlHeadO9Recset = (global::AcpCommonLib.FeatureManager.GetFeature(4003) as global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO9.ControlHeadO9Recset);
					num = (short)456523786;
					num2 = (int)((global::System.IntPtr)num);
				}
				return;
				IL_911:
				return;
				IL_BAA:
				e5BottomFunctionButtonInnerSection.E5BottomFunctionButtonIndex_43759.CalculateValidity();
				bottomFunctionProgrammableButtonInnerSection.CHO9BottomFunctionButtonIndex_A36665.CalculateValidity();
				return;
				IL_A2:
				e5BottomFunctionButtonInnerSection = (self as global::Motorola.MackinawCPS.CoreFeatures.ControlHeadE5.E5BottomFunctionButtonInnerSection);
				num = (short)173080601;
				num2 = (int)((global::System.IntPtr)num);
				goto IL_27;
			}
			}
		}

		// Token: 0x06008C8D RID: 35981 RVA: 0x00838448 File Offset: 0x00836648
		public static void ConSyncOrangeBtn(global::AcpCommonLib.IAcpFeatureSection self, global::AcpCommonLib.UndoRedo.ContainerTask task)
		{
			short num = (short)1774649344;
			int num2 = (int)num;
			switch (num2)
			{
			default:
			{
				switch (0)
				{
				case 0:
					goto IL_A8;
				}
				global::Motorola.MackinawCPS.CoreFeatures.ControlHeadE5.E5InnerRecset e5InnerRecset;
				int che5EmergencyButtonFeature_43768Value;
				global::Motorola.MackinawCPS.CoreFeatures.ControlHeadE5.ControlHeadE5Recset controlHeadE5Recset;
				for (;;)
				{
					IL_29:
					global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO7.ControlHeadO7Recset controlHeadO7Recset;
					global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO9.O9InnerRecset o9InnerRecset;
					global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO2.ControlHeadO2Recset controlHeadO2Recset;
					global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO2.O2InnerRecset o2InnerRecset;
					global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO9.ControlHeadO9Recset controlHeadO9Recset;
					global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO5.ControlHeadO5Recset controlHeadO5Recset;
					global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO7.O7InnerRecset o7InnerRecset;
					global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO5.O5InnerRecset o5InnerRecset;
					switch (num2)
					{
					case 0:
						goto IL_606;
					case 1:
						if (controlHeadO7Recset != null)
						{
							num = (short)1441333260;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_386;
					case 2:
						goto IL_640;
					case 3:
						if (e5InnerRecset != null)
						{
							num = (short)1667235862;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_152;
					case 4:
					{
						global::System.Collections.Generic.IEnumerator<global::AcpBusinessLayer.FeatureNode> enumerator = o9InnerRecset.GetEnumerator();
						num = (short)1978073101;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 5:
						if (o9InnerRecset != null)
						{
							num = (short)45023236;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return;
					case 6:
						if (controlHeadO2Recset != null)
						{
							num = (short)398065673;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_606;
					case 7:
					{
						global::System.Collections.Generic.IEnumerator<global::AcpBusinessLayer.FeatureNode> enumerator = o2InnerRecset.GetEnumerator();
						num = (short)1954807837;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 8:
						if (controlHeadO9Recset != null)
						{
							num = (short)1498349583;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_640;
					case 9:
						o2InnerRecset = (controlHeadO2Recset[0][10723].EmbeddedRecset as global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO2.O2InnerRecset);
						num = (short)512229376;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 10:
						try
						{
							num = (short)108134406;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								switch (num2)
								{
								case 0:
									num = (short)743899140;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 2:
								{
									global::AcpCommonLib.IAcpFeatureNode acpFeatureNode;
									task.AddTask(new global::AcpBusinessLayer.UndoRedo.ModifyDataTask<int>((acpFeatureNode[10901] as global::Motorola.MackinawCPS.CoreFeatures.ControlHeadE5.E5InnerSection).CHE5EmergencyButtonFeature_43768, che5EmergencyButtonFeature_43768Value));
									num = (short)1543503873;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 3:
								{
									global::AcpCommonLib.IAcpFeatureNode acpFeatureNode;
									if (che5EmergencyButtonFeature_43768Value != (acpFeatureNode[10901] as global::Motorola.MackinawCPS.CoreFeatures.ControlHeadE5.E5InnerSection).CHE5EmergencyButtonFeature_43768.Value)
									{
										num = (short)1312489474;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									break;
								}
								case 4:
									goto IL_311;
								case 5:
								{
									global::System.Collections.Generic.IEnumerator<global::AcpBusinessLayer.FeatureNode> enumerator;
									if (!enumerator.MoveNext())
									{
										num = (short)1219887104;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									global::AcpCommonLib.IAcpFeatureNode acpFeatureNode = enumerator.Current;
									num = (short)1255604227;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 6:
									switch (0)
									{
									case 0:
										goto IL_224;
									}
									continue;
								}
								IL_2BB:
								num = (short)1136984069;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								IL_224:
								goto IL_2BB;
							}
							IL_311:
							goto IL_152;
						}
						finally
						{
							num = (short)1193213954;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								global::System.Collections.Generic.IEnumerator<global::AcpBusinessLayer.FeatureNode> enumerator;
								switch (num2)
								{
								case 0:
									goto IL_383;
								case 1:
									enumerator.Dispose();
									num = (short)2082406400;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 2:
									switch (0)
									{
									case 0:
										goto IL_349;
									}
									continue;
								}
								IL_349:
								if (enumerator == null)
								{
									break;
								}
								num = (short)1878523905;
								num2 = (int)((global::System.IntPtr)num);
							}
							IL_383:;
						}
						goto IL_386;
					case 11:
						if (controlHeadE5Recset != null)
						{
							num = (short)517931026;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_C16;
					case 12:
						goto IL_DF1;
					case 13:
					{
						num = (short)1153630208;
						short num3 = num;
						try
						{
							num = (short)659161094;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								switch (num2)
								{
								case 1:
								{
									global::AcpCommonLib.IAcpFeatureNode acpFeatureNode2;
									if (che5EmergencyButtonFeature_43768Value != (acpFeatureNode2[10627] as global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO9.O9InnerSection).CHO9EmergencyButtonFeature_A36682.Value)
									{
										num = (short)2110128131;
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
										num = (short)283049989;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									global::AcpCommonLib.IAcpFeatureNode acpFeatureNode2 = enumerator.Current;
									num = (short)1413545985;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 3:
								{
									global::AcpCommonLib.IAcpFeatureNode acpFeatureNode2;
									task.AddTask(new global::AcpBusinessLayer.UndoRedo.ModifyDataTask<int>((acpFeatureNode2[10627] as global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO9.O9InnerSection).CHO9EmergencyButtonFeature_A36682, che5EmergencyButtonFeature_43768Value));
									num = (short)1593966592;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 4:
									goto IL_D7B;
								case 5:
									num = (short)1847525380;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 6:
									switch (0)
									{
									case 0:
										goto IL_C94;
									}
									continue;
								}
								IL_CEA:
								num = (short)257687554;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								IL_C94:
								goto IL_CEA;
							}
							IL_D7B:
							return;
						}
						finally
						{
							num = (short)927924226;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								global::System.Collections.Generic.IEnumerator<global::AcpBusinessLayer.FeatureNode> enumerator;
								switch (num2)
								{
								case 0:
									goto IL_DEE;
								case 1:
									enumerator.Dispose();
									num = (short)1711734784;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 2:
									switch (0)
									{
									case 0:
										goto IL_DB4;
									}
									continue;
								}
								IL_DB4:
								if (enumerator == null)
								{
									break;
								}
								num = (short)1085079553;
								num2 = (int)((global::System.IntPtr)num);
							}
							IL_DEE:;
						}
						goto IL_DF1;
					}
					case 14:
						goto IL_386;
					case 15:
						o9InnerRecset = (controlHeadO9Recset[0][10626].EmbeddedRecset as global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO9.O9InnerRecset);
						num = (short)170721282;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 16:
						goto IL_AD8;
					case 17:
						if (o2InnerRecset != null)
						{
							num = (short)2077949959;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_67E;
					case 18:
						e5InnerRecset = (controlHeadE5Recset[0][10902].EmbeddedRecset as global::Motorola.MackinawCPS.CoreFeatures.ControlHeadE5.E5InnerRecset);
						num = (short)1783496729;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 19:
						goto IL_BB5;
					case 20:
						if (controlHeadO5Recset != null)
						{
							num = (short)964362256;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_BB5;
					case 21:
					{
						global::System.Collections.Generic.IEnumerator<global::AcpBusinessLayer.FeatureNode> enumerator = o7InnerRecset.GetEnumerator();
						num = (short)2074738716;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 22:
					{
						global::System.Collections.Generic.IEnumerator<global::AcpBusinessLayer.FeatureNode> enumerator = e5InnerRecset.GetEnumerator();
						num = (short)1810825226;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 23:
					{
						global::System.Collections.Generic.IEnumerator<global::AcpBusinessLayer.FeatureNode> enumerator = o5InnerRecset.GetEnumerator();
						num = (short)985989147;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 24:
						if (o5InnerRecset != null)
						{
							num = (short)706936855;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_B13;
					case 25:
						goto IL_C16;
					case 26:
						if (o7InnerRecset != null)
						{
							num = (short)299958293;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_8E4;
					case 27:
						try
						{
							num = (short)854720518;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								switch (num2)
								{
								case 0:
								{
									global::AcpCommonLib.IAcpFeatureNode acpFeatureNode3;
									task.AddTask(new global::AcpBusinessLayer.UndoRedo.ModifyDataTask<int>((acpFeatureNode3[10211] as global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO5.O5InnerSection).CntrlHeadO5SignalIndependentO5M5MXChiefCHButtonButtonFeature_A19754, che5EmergencyButtonFeature_43768Value));
									num = (short)1165695533;
									short num4 = num;
									num = (short)830216749;
									switch ((num4 == num) ? 1 : 0)
									{
									case 0:
									case 2:
										continue;
									default:
										num = (short)792461312;
										if (num != 0)
										{
										}
										num = (short)1382285313;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									break;
								}
								case 2:
									num = (short)153681924;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 3:
								{
									global::System.Collections.Generic.IEnumerator<global::AcpBusinessLayer.FeatureNode> enumerator;
									if (!enumerator.MoveNext())
									{
										num = (short)2099838978;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									global::AcpCommonLib.IAcpFeatureNode acpFeatureNode3 = enumerator.Current;
									num = (short)1659043845;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 4:
									goto IL_594;
								case 5:
								{
									global::AcpCommonLib.IAcpFeatureNode acpFeatureNode3;
									if (che5EmergencyButtonFeature_43768Value != (acpFeatureNode3[10211] as global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO5.O5InnerSection).CntrlHeadO5SignalIndependentO5M5MXChiefCHButtonButtonFeature_A19754.Value)
									{
										num = (short)812515328;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									break;
								}
								case 6:
									switch (0)
									{
									case 0:
										goto IL_456;
									}
									continue;
								}
								IL_4E3:
								num = (short)481689603;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								IL_456:
								goto IL_4E3;
							}
							IL_594:
							goto IL_B13;
						}
						finally
						{
							num = (short)1776680962;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								global::System.Collections.Generic.IEnumerator<global::AcpBusinessLayer.FeatureNode> enumerator;
								switch (num2)
								{
								case 0:
									goto IL_603;
								case 1:
									enumerator.Dispose();
									num = (short)1564540928;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 2:
									switch (0)
									{
									case 0:
										goto IL_5CC;
									}
									continue;
								}
								IL_5CC:
								if (enumerator == null)
								{
									break;
								}
								num = (short)1827602433;
								num2 = (int)((global::System.IntPtr)num);
							}
							IL_603:;
						}
						goto IL_606;
					case 28:
						try
						{
							num = (short)155189254;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								switch (num2)
								{
								case 1:
								{
									global::AcpCommonLib.IAcpFeatureNode acpFeatureNode4;
									if (che5EmergencyButtonFeature_43768Value != (acpFeatureNode4[10715] as global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO7.O7InnerSection).CHO7EmergencyButtonFeature_A41291.Value)
									{
										num = (short)1804009475;
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
										num = (short)398000133;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									global::AcpCommonLib.IAcpFeatureNode acpFeatureNode4 = enumerator.Current;
									num = (short)1244463105;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 3:
								{
									global::AcpCommonLib.IAcpFeatureNode acpFeatureNode4;
									task.AddTask(new global::AcpBusinessLayer.UndoRedo.ModifyDataTask<int>((acpFeatureNode4[10715] as global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO7.O7InnerSection).CHO7EmergencyButtonFeature_A41291, che5EmergencyButtonFeature_43768Value));
									num = (short)880279552;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 4:
									goto IL_A64;
								case 5:
									num = (short)450297860;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 6:
									switch (0)
									{
									case 0:
										goto IL_97B;
									}
									continue;
								}
								IL_9D1:
								num = (short)1668808706;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								IL_97B:
								goto IL_9D1;
							}
							IL_A64:
							goto IL_8E4;
						}
						finally
						{
							num = (short)1021313026;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								global::System.Collections.Generic.IEnumerator<global::AcpBusinessLayer.FeatureNode> enumerator;
								switch (num2)
								{
								case 0:
									goto IL_AD5;
								case 1:
									enumerator.Dispose();
									num = (short)1065025536;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 2:
									switch (0)
									{
									case 0:
										goto IL_A9C;
									}
									continue;
								}
								IL_A9C:
								if (enumerator == null)
								{
									break;
								}
								num = (short)83886081;
								num2 = (int)((global::System.IntPtr)num);
							}
							IL_AD5:;
						}
						goto IL_AD8;
					case 29:
						try
						{
							num = (short)1262682118;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								switch (num2)
								{
								case 1:
								{
									global::AcpCommonLib.IAcpFeatureNode acpFeatureNode5;
									if (che5EmergencyButtonFeature_43768Value != (acpFeatureNode5[10716] as global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO2.O2InnerSection).CHO2EmergencyButtonFeature_A41272.Value)
									{
										num = (short)1589706755;
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
										num = (short)1037303813;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									global::AcpCommonLib.IAcpFeatureNode acpFeatureNode5 = enumerator.Current;
									num = (short)2049835009;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 3:
								{
									global::AcpCommonLib.IAcpFeatureNode acpFeatureNode5;
									task.AddTask(new global::AcpBusinessLayer.UndoRedo.ModifyDataTask<int>((acpFeatureNode5[10716] as global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO2.O2InnerSection).CHO2EmergencyButtonFeature_A41272, che5EmergencyButtonFeature_43768Value));
									num = (short)1379205120;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 4:
									goto IL_871;
								case 5:
									num = (short)318701572;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 6:
									switch (0)
									{
									case 0:
										goto IL_786;
									}
									continue;
								}
								IL_7DE:
								num = (short)1975779330;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								IL_786:
								goto IL_7DE;
							}
							IL_871:
							goto IL_67E;
						}
						finally
						{
							num = (short)1780809730;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								global::System.Collections.Generic.IEnumerator<global::AcpBusinessLayer.FeatureNode> enumerator;
								switch (num2)
								{
								case 0:
									goto IL_8E1;
								case 1:
									enumerator.Dispose();
									num = (short)2036334592;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 2:
									switch (0)
									{
									case 0:
										goto IL_8A9;
									}
									continue;
								}
								IL_8A9:
								if (enumerator == null)
								{
									break;
								}
								num = (short)941883393;
								num2 = (int)((global::System.IntPtr)num);
							}
							IL_8E1:;
						}
						goto IL_8E4;
					}
					goto IL_A8;
					IL_152:
					controlHeadO2Recset = null;
					o2InnerRecset = null;
					controlHeadO2Recset = (global::AcpCommonLib.FeatureManager.GetFeature(4115) as global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO2.ControlHeadO2Recset);
					num = (short)467599366;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_386:
					num = (short)2023620634;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_606:
					num = (short)494141457;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_640:
					num = (short)203161605;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_67E:
					controlHeadO5Recset = null;
					o5InnerRecset = null;
					controlHeadO5Recset = (global::AcpCommonLib.FeatureManager.GetFeature(2130) as global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO5.ControlHeadO5Recset);
					num = (short)259719188;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_8E4:
					controlHeadO9Recset = null;
					o9InnerRecset = null;
					controlHeadO9Recset = (global::AcpCommonLib.FeatureManager.GetFeature(4003) as global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO9.ControlHeadO9Recset);
					num = (short)1698496520;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_AD8:
					o5InnerRecset = (controlHeadO5Recset[0][10227].EmbeddedRecset as global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO5.O5InnerRecset);
					num = (short)1806696467;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_B13:
					controlHeadO7Recset = null;
					o7InnerRecset = null;
					controlHeadO7Recset = (global::AcpCommonLib.FeatureManager.GetFeature(4114) as global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO7.ControlHeadO7Recset);
					num = (short)1582301185;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_BB5:
					num = (short)1176174616;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_C16:
					num = (short)1727791107;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_DF1:
					o7InnerRecset = (controlHeadO7Recset[0][10719].EmbeddedRecset as global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO7.O7InnerRecset);
					num = (short)1081868302;
					num2 = (int)((global::System.IntPtr)num);
				}
				return;
				IL_A8:
				num = (short)1837367297;
				if (num != 0)
				{
				}
				che5EmergencyButtonFeature_43768Value = (self as global::Motorola.MackinawCPS.CoreFeatures.ControlHeadE5.E5InnerSection).CHE5EmergencyButtonFeature_43768Value;
				controlHeadE5Recset = null;
				e5InnerRecset = null;
				controlHeadE5Recset = (global::AcpCommonLib.FeatureManager.GetFeature(4236) as global::Motorola.MackinawCPS.CoreFeatures.ControlHeadE5.ControlHeadE5Recset);
				num = (short)646578187;
				num2 = (int)((global::System.IntPtr)num);
				goto IL_29;
			}
			}
		}

		// Token: 0x06008C8E RID: 35982 RVA: 0x00839300 File Offset: 0x00837500
		internal static bool ConControlHeadEmergencyFeaturesSelect(global::AcpCommonLib.IAcpFeatureSection self, int index)
		{
			short num = (short)616169472;
			short num2 = num;
			num = (short)1343677854;
			short num3 = num;
			num = (short)1493362078;
			int num4;
			switch ((num3 == num) ? 1 : 0)
			{
			case 0:
			case 2:
				IL_277:
				if (index != 31)
				{
					num = (short)503447575;
					num4 = (int)((global::System.IntPtr)num);
				}
				else
				{
					num = (short)1989672986;
					num4 = (int)((global::System.IntPtr)num);
				}
				break;
			default:
				num = (short)649396224;
				if (num != 0)
				{
				}
				num = (short)1945698304;
				num4 = (int)num;
				switch (num4)
				{
				default:
					switch (0)
					{
					case 0:
						goto IL_13D;
					}
					break;
				}
				break;
			}
			bool result;
			global::AcpBusinessLayer.AcpListField radWideDualRadioSelection_A;
			global::Motorola.MackinawCPS.CoreFeatures.ControlHeadE5.E5InnerSection e5InnerSection;
			global::AcpBusinessLayer.AcpField<bool> radErgoWideControlHeadMultiControlHead_A;
			global::Motorola.MackinawCPS.CoreFeatures.RadioWide.Features features;
			global::AcpBusinessLayer.AcpListField radErgoWideControlHeadMultipleControlHeadStyle_A;
			for (;;)
			{
				IL_9E:
				bool flag;
				bool flag2;
				bool flag3;
				switch (num4)
				{
				case 0:
					if (index <= 138)
					{
						num = (short)353763342;
						num4 = (int)((global::System.IntPtr)num);
						continue;
					}
					num = (short)1912406019;
					num4 = (int)((global::System.IntPtr)num);
					continue;
				case 1:
					return result;
				case 2:
					return result;
				case 3:
					if (index != 140)
					{
						num = (short)428736536;
						num4 = (int)((global::System.IntPtr)num);
						continue;
					}
					result = (radWideDualRadioSelection_A.Value != 0);
					num = (short)213581825;
					if (num != 0)
					{
					}
					num = (short)189988896;
					num4 = (int)((global::System.IntPtr)num);
					continue;
				case 4:
					flag = !e5InnerSection.RefRadioWide.Features.RadWideTPSFiregroundEvacuationTone_A7980.Value;
					goto IL_465;
				case 5:
					flag = true;
					goto IL_465;
				case 6:
					flag2 = true;
					goto IL_621;
				case 7:
					return result;
				case 8:
					num = (short)1872297997;
					num4 = (int)((global::System.IntPtr)num);
					continue;
				case 9:
					return result;
				case 10:
					if (radErgoWideControlHeadMultiControlHead_A.Value)
					{
						num = (short)390266910;
						num4 = (int)((global::System.IntPtr)num);
						continue;
					}
					num = (short)1384710181;
					num4 = (int)((global::System.IntPtr)num);
					continue;
				case 11:
					return result;
				case 12:
					num = (short)1014562825;
					num4 = (int)((global::System.IntPtr)num);
					continue;
				case 13:
					if (index - 290 > 1)
					{
						num = (short)388694036;
						num4 = (int)((global::System.IntPtr)num);
						continue;
					}
					result = features.RadWideFeaturesChannelFallbackEnableValue;
					num = (short)1998258195;
					num4 = (int)((global::System.IntPtr)num);
					continue;
				case 14:
					num = (short)6946832;
					num4 = (int)((global::System.IntPtr)num);
					continue;
				case 15:
					num = (short)950599684;
					num4 = (int)((global::System.IntPtr)num);
					continue;
				case 16:
					goto IL_277;
				case 17:
					if (!radErgoWideControlHeadMultiControlHead_A.Value)
					{
						num = (short)1003094038;
						num4 = (int)((global::System.IntPtr)num);
						continue;
					}
					num = (short)2116091910;
					num4 = (int)((global::System.IntPtr)num);
					continue;
				case 18:
					flag2 = !radErgoWideControlHeadMultiControlHead_A.Value;
					goto IL_621;
				case 19:
					return result;
				case 20:
					num = (short)672268290;
					num4 = (int)((global::System.IntPtr)num);
					continue;
				case 21:
					num = (short)1042022428;
					num4 = (int)((global::System.IntPtr)num);
					continue;
				case 22:
					goto IL_239;
				case 23:
					num = (short)329973794;
					num4 = (int)((global::System.IntPtr)num);
					continue;
				case 24:
					num = (short)1461911583;
					num4 = (int)((global::System.IntPtr)num);
					continue;
				case 25:
					if (e5InnerSection.RefRadioWide.DualRadio.RadWideDualRadioEmergencyRadio_A42239.Value == 2)
					{
						num = (short)1617362959;
						num4 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_324;
				case 26:
					if (radWideDualRadioSelection_A.Value == 1)
					{
						num = (short)102170659;
						num4 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_324;
				case 27:
					return result;
				case 28:
					if (index != 138)
					{
						num = (short)1287651340;
						num4 = (int)((global::System.IntPtr)num);
						continue;
					}
					num = (short)2129723402;
					num4 = (int)((global::System.IntPtr)num);
					continue;
				case 29:
					flag3 = (radErgoWideControlHeadMultipleControlHeadStyle_A.Value == 0);
					goto IL_3CF;
				case 30:
					num = (short)936247325;
					num4 = (int)((global::System.IntPtr)num);
					continue;
				case 31:
					if (index != 163)
					{
						num = (short)195559432;
						num4 = (int)((global::System.IntPtr)num);
						continue;
					}
					num = (short)27525153;
					num4 = (int)((global::System.IntPtr)num);
					continue;
				case 32:
					return result;
				case 33:
					if (radErgoWideControlHeadMultipleControlHeadStyle_A.Value == 1)
					{
						num = (short)1575288868;
						num4 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_239;
				case 34:
					if (index - 124 > 2)
					{
						num = (short)2085945365;
						num4 = (int)((global::System.IntPtr)num);
						continue;
					}
					result = (radWideDualRadioSelection_A.Value == 0);
					num = (short)642121739;
					num4 = (int)((global::System.IntPtr)num);
					continue;
				case 35:
					num = (short)393241;
					num4 = (int)((global::System.IntPtr)num);
					continue;
				case 36:
					num = (short)486670353;
					num4 = (int)((global::System.IntPtr)num);
					continue;
				case 37:
					flag3 = false;
					goto IL_3CF;
				}
				goto IL_13D;
				IL_239:
				num = (short)321650706;
				num4 = (int)((global::System.IntPtr)num);
				continue;
				IL_324:
				num = (short)1860173829;
				num4 = (int)((global::System.IntPtr)num);
				continue;
				IL_3CF:
				result = flag3;
				num = (short)305397761;
				num4 = (int)((global::System.IntPtr)num);
				continue;
				IL_465:
				result = flag;
				num = (short)262340635;
				num4 = (int)((global::System.IntPtr)num);
				continue;
				IL_621:
				result = flag2;
				num = (short)1057095687;
				num4 = (int)((global::System.IntPtr)num);
			}
			return result;
			IL_13D:
			e5InnerSection = (self as global::Motorola.MackinawCPS.CoreFeatures.ControlHeadE5.E5InnerSection);
			radErgoWideControlHeadMultipleControlHeadStyle_A = e5InnerSection.RefRadioErgonomicsWide.ControlHead.RadErgoWideControlHeadMultipleControlHeadStyle_A8561;
			radWideDualRadioSelection_A = e5InnerSection.RefRadioWide.DualRadio.RadWideDualRadioSelection_A42236;
			radErgoWideControlHeadMultiControlHead_A = e5InnerSection.RefRadioErgonomicsWide.ControlHead.RadErgoWideControlHeadMultiControlHead_A8550;
			features = (global::AcpCommonLib.FeatureManager.GetFeature(2045)[0][10105] as global::Motorola.MackinawCPS.CoreFeatures.RadioWide.Features);
			result = true;
			num = (short)155713536;
			num4 = (int)((global::System.IntPtr)num);
			goto IL_9E;
		}

		// Token: 0x06008C8F RID: 35983 RVA: 0x008399D4 File Offset: 0x00837BD4
		internal static bool ConBottomFunctionButtonIndexIsApplicable(global::AcpCommonLib.IAcpFeatureSection self)
		{
			switch (0)
			{
			case 0:
				goto IL_20;
			}
			int num;
			global::AcpBusinessLayer.AcpListField e5BottomFunctionButtonFeature_;
			short num2;
			global::Motorola.MackinawCPS.CoreFeatures.ControlHeadE5.E5BottomFunctionButtonInnerSection e5BottomFunctionButtonInnerSection;
			for (;;)
			{
				IL_0A:
				switch (num)
				{
				case 0:
					if (e5BottomFunctionButtonFeature_.Value != 206)
					{
						num2 = (short)434896896;
						short num3 = num2;
						num2 = (short)732430338;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					return true;
				case 1:
					goto IL_3B;
				case 2:
				{
					num2 = (short)1741029377;
					if (num2 != 0)
					{
					}
					num2 = (short)1572900063;
					short num4 = num2;
					num2 = (short)1983352031;
					switch ((num4 == num2) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_3B;
					default:
						goto IL_12E;
					}
					break;
				}
				case 3:
					return false;
				}
				goto IL_20;
				IL_3B:
				if (e5BottomFunctionButtonInnerSection == null)
				{
					num2 = (short)693239811;
					num = (int)((global::System.IntPtr)num2);
				}
				else
				{
					e5BottomFunctionButtonFeature_ = e5BottomFunctionButtonInnerSection.E5BottomFunctionButtonFeature_43758;
					num2 = (short)1583284224;
					num = (int)((global::System.IntPtr)num2);
				}
			}
			return false;
			IL_12E:
			num2 = (short)675479552;
			if (num2 != 0)
			{
			}
			return e5BottomFunctionButtonFeature_.Value == 207;
			IL_20:
			e5BottomFunctionButtonInnerSection = (self as global::Motorola.MackinawCPS.CoreFeatures.ControlHeadE5.E5BottomFunctionButtonInnerSection);
			num2 = (short)261750785;
			num = (int)((global::System.IntPtr)num2);
			goto IL_0A;
		}

		// Token: 0x06008C90 RID: 35984 RVA: 0x00839B30 File Offset: 0x00837D30
		internal static bool ConDualRadioSelectionIsStandaloneRadio(global::AcpCommonLib.IAcpFeatureSection self)
		{
			global::Motorola.MackinawCPS.CoreFeatures.RadioWide.RadioWide radioWide;
			short num;
			for (;;)
			{
				radioWide = (global::AcpCommonLib.FeatureManager.GetFeature(2045)[0] as global::Motorola.MackinawCPS.CoreFeatures.RadioWide.RadioWide);
				if (radioWide != null)
				{
					goto IL_BC;
				}
				num = (short)1253901395;
				short num2 = num;
				num = (short)917242963;
				switch ((num2 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					break;
				default:
					goto IL_53;
				}
			}
			IL_53:
			num = (short)1241317377;
			if (num != 0)
			{
			}
			num = (short)1510866944;
			if (num != 0)
			{
			}
			num = (short)1376583680;
			short num3 = num;
			return false;
			IL_BC:
			return radioWide.DualRadio.RadWideDualRadioSelection_A42236.Value == 0;
		}

		// Token: 0x06008C91 RID: 35985 RVA: 0x00839C0C File Offset: 0x00837E0C
		public static void ConSyncBottomFunctionButtonIndex(global::AcpCommonLib.IAcpFeatureSection self, global::AcpCommonLib.UndoRedo.ContainerTask task)
		{
			short num = (short)1861484544;
			short num2 = num;
			num = (short)647823360;
			int num3 = (int)num;
			switch (num3)
			{
			default:
			{
				switch (0)
				{
				case 0:
					goto IL_C0;
				}
				global::Motorola.MackinawCPS.CoreFeatures.ControlHeadE5.E5BottomFunctionButtonInnerSection e5BottomFunctionButtonInnerSection;
				for (;;)
				{
					IL_51:
					global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO9.ControlHeadO9Recset controlHeadO9Recset;
					global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO9.BottomFunctionProgrammableButtonInnerSection bottomFunctionProgrammableButtonInnerSection;
					global::AcpBusinessLayer.AcpRecRefField acpRecRefField;
					global::AcpBusinessLayer.AcpListField acpListField;
					global::AcpBusinessLayer.AcpListField acpListField2;
					global::AcpBusinessLayer.AcpListField e5BottomFunctionButtonBCO_;
					object obj;
					global::AcpBusinessLayer.AcpRecRefField acpRecRefField2;
					global::AcpCommonLib.IAcpRecordset acpRecordset;
					switch (num3)
					{
					case 0:
					{
						num = (short)1495597057;
						if (num != 0)
						{
						}
						global::System.Collections.Generic.IEnumerator<global::AcpBusinessLayer.FeatureNode> enumerator = (controlHeadO9Recset[0][10622].EmbeddedRecset as global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO9.ConsolidatedActionBCOListInnerRecset).GetEnumerator();
						num = (short)56688646;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 1:
						task.AddTask(new global::AcpBusinessLayer.UndoRedo.ModifyRecRefDataTask(bottomFunctionProgrammableButtonInnerSection.CHO9BottomFunctionButtonIndex_A36665, acpRecRefField.UIValue));
						num = (short)561315847;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					case 2:
						num = (short)708902930;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					case 3:
						if (acpListField.Value == 207)
						{
							num = (short)2139815956;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						}
						return;
					case 4:
						acpListField2 = null;
						goto IL_405;
					case 5:
						acpListField2 = e5BottomFunctionButtonInnerSection.E5BottomFunctionButtonFeature_43758;
						goto IL_405;
					case 6:
						try
						{
							num = (short)2112618499;
							num3 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								switch (num3)
								{
								case 0:
								{
									global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO9.ConsolidatedActionBCOListInner consolidatedActionBCOListInner;
									task.AddTask(new global::AcpBusinessLayer.UndoRedo.ModifyRecRefDataTask(consolidatedActionBCOListInner.ConsolidatedActionBCOListInnerSection.RadErgoControlO9ACBCOListIndex_A36668, acpRecRefField.UIValue));
									num = (short)1206583302;
									num3 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 1:
								{
									global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO9.ConsolidatedActionBCOListInner consolidatedActionBCOListInner;
									if (consolidatedActionBCOListInner.ConsolidatedActionBCOListInnerSection.RadErgoControlO9ACBCOListBco_A36666.Value == e5BottomFunctionButtonBCO_.Value)
									{
										num = (short)1396637696;
										num3 = (int)((global::System.IntPtr)num);
										continue;
									}
									break;
								}
								case 2:
									goto IL_793;
								case 3:
									switch (0)
									{
									case 0:
										goto IL_653;
									}
									continue;
								case 4:
									goto IL_66B;
								case 5:
									num = (short)371720194;
									num3 = (int)((global::System.IntPtr)num);
									continue;
								case 6:
								{
									num = (short)98431982;
									short num4 = num;
									num = (short)1596060654;
									switch ((num4 == num) ? 1 : 0)
									{
									case 0:
									case 2:
										goto IL_66B;
									default:
										goto IL_6FC;
									}
									break;
								}
								}
								IL_655:
								num = (short)1550647300;
								num3 = (int)((global::System.IntPtr)num);
								continue;
								IL_653:
								goto IL_655;
								IL_66B:
								global::System.Collections.Generic.IEnumerator<global::AcpBusinessLayer.FeatureNode> enumerator;
								if (!enumerator.MoveNext())
								{
									num = (short)327548933;
									num3 = (int)((global::System.IntPtr)num);
								}
								else
								{
									global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO9.ConsolidatedActionBCOListInner consolidatedActionBCOListInner = (global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO9.ConsolidatedActionBCOListInner)enumerator.Current;
									num = (short)869597185;
									num3 = (int)((global::System.IntPtr)num);
								}
							}
							IL_6FC:
							num = (short)519700480;
							if (num != 0)
							{
							}
							IL_793:
							return;
						}
						finally
						{
							num = (short)1813643265;
							num3 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								global::System.Collections.Generic.IEnumerator<global::AcpBusinessLayer.FeatureNode> enumerator;
								switch (num3)
								{
								case 0:
									goto IL_805;
								case 1:
									switch (0)
									{
									case 0:
										goto IL_7CB;
									}
									continue;
								case 2:
									enumerator.Dispose();
									num = (short)1363804160;
									num3 = (int)((global::System.IntPtr)num);
									continue;
								}
								IL_7CB:
								if (enumerator == null)
								{
									break;
								}
								num = (short)327483394;
								num3 = (int)((global::System.IntPtr)num);
							}
							IL_805:;
						}
						goto IL_808;
					case 7:
						goto IL_4E0;
					case 8:
						return;
					case 9:
						if (controlHeadO9Recset == null)
						{
							num = (short)1325858830;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)1067778060;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					case 10:
						obj = null;
						goto IL_808;
					case 11:
						acpRecRefField2 = null;
						goto IL_5C5;
					case 12:
						acpRecordset = controlHeadO9Recset[0][10618].EmbeddedRecset;
						goto IL_475;
					case 13:
						if (acpListField.Value == 206)
						{
							num = (short)1274413056;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)705691651;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					case 14:
						num = (short)2004156435;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					case 15:
						if (bottomFunctionProgrammableButtonInnerSection.CHO9BottomFunctionButtonBCO_A36660.Value == e5BottomFunctionButtonBCO_.Value)
						{
							num = (short)535035905;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_4E0;
					case 16:
						if (bottomFunctionProgrammableButtonInnerSection != null)
						{
							num = (short)277544962;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						}
						return;
					case 17:
						try
						{
							num = (short)1849491459;
							num3 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								switch (num3)
								{
								case 0:
									num = (short)1862729730;
									num3 = (int)((global::System.IntPtr)num);
									continue;
								case 1:
								{
									global::System.Collections.Generic.IEnumerator<global::AcpBusinessLayer.FeatureNode> enumerator;
									if (!enumerator.MoveNext())
									{
										num = (short)768606208;
										num3 = (int)((global::System.IntPtr)num);
										continue;
									}
									global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO9.RelayPatternBCOListListInner relayPatternBCOListListInner = (global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO9.RelayPatternBCOListListInner)enumerator.Current;
									num = (short)1565589508;
									num3 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 2:
									goto IL_321;
								case 3:
									switch (0)
									{
									case 0:
										goto IL_234;
									}
									continue;
								case 4:
								{
									global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO9.RelayPatternBCOListListInner relayPatternBCOListListInner;
									if (relayPatternBCOListListInner.RelayPatternBCOListListInnerSection.RdEgoO9DirLtbarPatternBcoListBco_A36661.Value == e5BottomFunctionButtonBCO_.Value)
									{
										num = (short)1895956485;
										num3 = (int)((global::System.IntPtr)num);
										continue;
									}
									break;
								}
								case 5:
								{
									global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO9.RelayPatternBCOListListInner relayPatternBCOListListInner;
									task.AddTask(new global::AcpBusinessLayer.UndoRedo.ModifyRecRefDataTask(relayPatternBCOListListInner.RelayPatternBCOListListInnerSection.RdEgoO9DirLtbarPatternBcoListIndex_A36707, acpRecRefField.UIValue));
									num = (short)1484849158;
									num3 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 6:
									goto IL_2C5;
								}
								IL_2CA:
								num = (short)2024669185;
								num3 = (int)((global::System.IntPtr)num);
								continue;
								IL_234:
								goto IL_2CA;
							}
							IL_2C5:
							IL_321:
							return;
						}
						finally
						{
							num = (short)674168833;
							num3 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								global::System.Collections.Generic.IEnumerator<global::AcpBusinessLayer.FeatureNode> enumerator;
								switch (num3)
								{
								case 0:
									goto IL_393;
								case 1:
									switch (0)
									{
									case 0:
										goto IL_359;
									}
									continue;
								case 2:
									enumerator.Dispose();
									num = (short)285868032;
									num3 = (int)((global::System.IntPtr)num);
									continue;
								}
								IL_359:
								if (enumerator == null)
								{
									break;
								}
								num = (short)1142882306;
								num3 = (int)((global::System.IntPtr)num);
							}
							IL_393:;
						}
						goto IL_396;
					case 18:
						if (acpRecRefField == null)
						{
							num = (short)1649868808;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_396;
					case 19:
						acpRecordset = null;
						goto IL_475;
					case 20:
					{
						global::System.Collections.Generic.IEnumerator<global::AcpBusinessLayer.FeatureNode> enumerator = (controlHeadO9Recset[0][10620].EmbeddedRecset as global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO9.RelayPatternBCOListListInnerRecset).GetEnumerator();
						num = (short)1812004881;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 21:
						if (e5BottomFunctionButtonInnerSection == null)
						{
							num = (short)1774059542;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)1492385797;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					case 22:
						num = (short)454295556;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					case 23:
						acpRecRefField2 = e5BottomFunctionButtonInnerSection.E5BottomFunctionButtonIndex_43759;
						goto IL_5C5;
					case 24:
						if (e5BottomFunctionButtonInnerSection == null)
						{
							num = (short)549978137;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)1365704727;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					case 25:
						num = (short)493748235;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_C0;
					IL_396:
					e5BottomFunctionButtonBCO_ = e5BottomFunctionButtonInnerSection.E5BottomFunctionButtonBCO_43757;
					num = (short)1692139535;
					num3 = (int)((global::System.IntPtr)num);
					continue;
					IL_405:
					acpListField = acpListField2;
					num = (short)495255576;
					num3 = (int)((global::System.IntPtr)num);
					continue;
					IL_475:
					global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO9.BottomFunctionProgrammableButtonInnerRecset bottomFunctionProgrammableButtonInnerRecset = acpRecordset as global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO9.BottomFunctionProgrammableButtonInnerRecset;
					if (bottomFunctionProgrammableButtonInnerRecset == null)
					{
						num = (short)1672085514;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					}
					obj = bottomFunctionProgrammableButtonInnerRecset[0][10619];
					goto IL_808;
					IL_4E0:
					num = (short)1492516877;
					num3 = (int)((global::System.IntPtr)num);
					continue;
					IL_5C5:
					acpRecRefField = acpRecRefField2;
					controlHeadO9Recset = (global::AcpCommonLib.FeatureManager.GetFeature(4003) as global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO9.ControlHeadO9Recset);
					num = (short)751042569;
					num3 = (int)((global::System.IntPtr)num);
					continue;
					IL_808:
					bottomFunctionProgrammableButtonInnerSection = (obj as global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO9.BottomFunctionProgrammableButtonInnerSection);
					num = (short)1725628432;
					num3 = (int)((global::System.IntPtr)num);
				}
				return;
				IL_C0:
				e5BottomFunctionButtonInnerSection = (self as global::Motorola.MackinawCPS.CoreFeatures.ControlHeadE5.E5BottomFunctionButtonInnerSection);
				num = (short)837222421;
				num3 = (int)((global::System.IntPtr)num);
				goto IL_51;
			}
			}
		}

		// Token: 0x06008C92 RID: 35986 RVA: 0x0083A4B8 File Offset: 0x008386B8
		public static bool ConBottomButtonFeatureIsValid(global::AcpCommonLib.IAcpFeatureSection self, int index)
		{
			short num = (short)1222770688;
			int num2 = (int)num;
			switch (num2)
			{
			default:
			{
				switch (0)
				{
				case 0:
					goto IL_97;
				}
				global::System.Collections.Generic.IEnumerator<global::AcpBusinessLayer.FeatureNode> enumerator;
				bool result;
				global::Motorola.MackinawCPS.CoreFeatures.DEK.DEKVIPInnerRecset dekvipinnerRecset;
				global::AcpBusinessLayer.AcpListField radErgoWideControlHeadMultipleControlHeadStyle_A;
				global::AcpBusinessLayer.AcpField<bool> radErgoWideControlHeadMultiControlHead_A;
				global::Motorola.MackinawCPS.CoreFeatures.RadioVIPs.RadioVIPInnerRecset radioVIPInnerRecset;
				for (;;)
				{
					IL_28:
					switch (num2)
					{
					case 0:
						if (index != 163)
						{
							num = (short)1321664528;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_2F1;
					case 1:
						num = (short)126156815;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 2:
						goto IL_57B;
					case 3:
						num = (short)1149370373;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 4:
						num = (short)287571968;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 5:
						if (index - 290 > 1)
						{
							num = (short)1586954249;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_1088;
					case 6:
						try
						{
							num = (short)1382481921;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								switch (num2)
								{
								case 0:
									if (!enumerator.MoveNext())
									{
										num = (short)1299644421;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									num = (short)75825158;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 1:
									switch (0)
									{
									case 0:
										goto IL_884;
									}
									continue;
								case 2:
									goto IL_950;
								case 3:
									goto IL_8A0;
								case 4:
									result = true;
									num = (short)1734148099;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 5:
									num = (short)267583490;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 6:
									if ((((global::AcpCommonLib.IAcpFeatureNode)enumerator.Current)[10207] as global::Motorola.MackinawCPS.CoreFeatures.RadioVIPs.RadioVIPInnerSection).RadVipOutputFeature_A20947.Value == 12)
									{
										num = (short)421593092;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									break;
								}
								IL_8FA:
								num = (short)327680;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								IL_884:
								goto IL_8FA;
							}
							IL_8A0:
							return result;
							IL_950:
							goto IL_374;
						}
						finally
						{
							num = (short)1420689410;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								switch (num2)
								{
								case 0:
									goto IL_9C0;
								case 1:
									enumerator.Dispose();
									num = (short)1358692352;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 2:
									switch (0)
									{
									case 0:
										goto IL_988;
									}
									continue;
								}
								IL_988:
								if (enumerator == null)
								{
									break;
								}
								num = (short)1832714241;
								num2 = (int)((global::System.IntPtr)num);
							}
							IL_9C0:;
						}
						goto Block_10;
						IL_374:
						enumerator = dekvipinnerRecset.GetEnumerator();
						num = (short)21495830;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 7:
						if (radErgoWideControlHeadMultipleControlHeadStyle_A.Value == 1)
						{
							num = (short)1154351121;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_B45;
					case 8:
						goto IL_10B0;
					case 9:
						num = (short)521011210;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 10:
						goto IL_36F;
					case 11:
						if (index != 207)
						{
							num = (short)811597827;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_39B;
					case 12:
						goto IL_352;
					case 13:
						goto IL_9C3;
					case 14:
						if (radErgoWideControlHeadMultiControlHead_A.Value)
						{
							num = (short)1508114450;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return false;
					case 15:
						switch (index)
						{
						case 134:
							num = (short)1588723713;
							if (num != 0)
							{
							}
							enumerator = radioVIPInnerRecset.GetEnumerator();
							num = (short)1150877715;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 135:
							enumerator = radioVIPInnerRecset.GetEnumerator();
							num = (short)484048909;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 136:
							enumerator = radioVIPInnerRecset.GetEnumerator();
							num = (short)2040397847;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 137:
							enumerator = radioVIPInnerRecset.GetEnumerator();
							num = (short)1470169094;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 138:
							num = (short)76152846;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 139:
							return true;
						case 140:
							goto IL_FDA;
						default:
							num = (short)211353604;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						break;
					case 16:
						num = (short)86573080;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 17:
						goto IL_540;
					case 18:
						goto IL_61B;
					case 19:
						try
						{
							num = (short)872546309;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								switch (num2)
								{
								case 0:
									num = (short)1739390977;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 1:
								{
									global::AcpCommonLib.IAcpFeatureNode acpFeatureNode;
									if ((acpFeatureNode[10207] as global::Motorola.MackinawCPS.CoreFeatures.RadioVIPs.RadioVIPInnerSection).RadVipOutputFeature_A20947.Value == 12)
									{
										num = (short)739180551;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									break;
								}
								case 2:
								{
									if (!enumerator.MoveNext())
									{
										num = (short)1912274952;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									global::AcpCommonLib.IAcpFeatureNode acpFeatureNode = enumerator.Current;
									num = (short)1285357577;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 3:
									num = (short)410255370;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 4:
									goto IL_DE4;
								case 5:
									switch (0)
									{
									case 0:
										goto IL_C62;
									}
									continue;
								case 6:
									goto IL_D29;
								case 7:
									goto IL_D0E;
								case 8:
									num = (short)344653828;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 9:
								{
									global::AcpCommonLib.IAcpFeatureNode acpFeatureNode;
									if ((acpFeatureNode[10207] as global::Motorola.MackinawCPS.CoreFeatures.RadioVIPs.RadioVIPInnerSection).RadVipOutputFeature_A20947.Value != 10)
									{
										num = (short)1443299331;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									goto IL_D0E;
								}
								case 10:
								{
									global::AcpCommonLib.IAcpFeatureNode acpFeatureNode;
									if ((acpFeatureNode[10207] as global::Motorola.MackinawCPS.CoreFeatures.RadioVIPs.RadioVIPInnerSection).RadVipOutputFeature_A20947.Value != 11)
									{
										num = (short)444071936;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									goto IL_D0E;
								}
								}
								goto IL_C62;
								IL_D0E:
								result = true;
								num = (short)308019206;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								IL_D2E:
								num = (short)641204226;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								IL_C62:
								goto IL_D2E;
							}
							IL_D29:
							return result;
							IL_DE4:
							goto IL_332;
						}
						finally
						{
							num = (short)1072037890;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								switch (num2)
								{
								case 0:
									goto IL_E56;
								case 1:
									enumerator.Dispose();
									num = (short)1597112320;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 2:
									switch (0)
									{
									case 0:
										goto IL_E1B;
									}
									continue;
								}
								IL_E1B:
								if (enumerator == null)
								{
									break;
								}
								num = (short)1889468417;
								num2 = (int)((global::System.IntPtr)num);
							}
							IL_E56:;
						}
						goto Block_13;
						IL_332:
						enumerator = dekvipinnerRecset.GetEnumerator();
						num = (short)227999756;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 20:
						if (index <= 163)
						{
							num = (short)1753546753;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)2012413963;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 21:
						try
						{
							num = (short)1192755201;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								switch (num2)
								{
								case 0:
									num = (short)1929838594;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 1:
									switch (0)
									{
									case 0:
										goto IL_404;
									}
									continue;
								case 2:
									goto IL_4CE;
								case 3:
									if ((((global::AcpCommonLib.IAcpFeatureNode)enumerator.Current)[10206] as global::Motorola.MackinawCPS.CoreFeatures.DEK.DEKVIPInnerSection).DEKVIPOutputFeature_A21346.Value == 11)
									{
										num = (short)624820230;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									break;
								case 4:
									if (!enumerator.MoveNext())
									{
										num = (short)1425211392;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									num = (short)313786371;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 5:
									goto IL_4B1;
								case 6:
									result = true;
									num = (short)1961820165;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								IL_458:
								num = (short)1730215940;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								IL_404:
								goto IL_458;
							}
							IL_4B1:
							return result;
							IL_4CE:
							return false;
						}
						finally
						{
							num = (short)1472069634;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								switch (num2)
								{
								case 0:
									goto IL_53D;
								case 1:
									enumerator.Dispose();
									num = (short)2014969856;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 2:
									switch (0)
									{
									case 0:
										goto IL_506;
									}
									continue;
								}
								IL_506:
								if (enumerator == null)
								{
									break;
								}
								num = (short)1499201537;
								num2 = (int)((global::System.IntPtr)num);
							}
							IL_53D:;
						}
						goto IL_540;
					case 22:
						try
						{
							num = (short)402128897;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								switch (num2)
								{
								case 0:
									if ((((global::AcpCommonLib.IAcpFeatureNode)enumerator.Current)[10206] as global::Motorola.MackinawCPS.CoreFeatures.DEK.DEKVIPInnerSection).DEKVIPOutputFeature_A21346.Value == 12)
									{
										num = (short)1335099397;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									break;
								case 1:
									switch (0)
									{
									case 0:
										goto IL_1BA;
									}
									continue;
								case 2:
									goto IL_280;
								case 3:
									if (!enumerator.MoveNext())
									{
										num = (short)990969862;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									num = (short)116391936;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 4:
									goto IL_20A;
								case 5:
									result = true;
									num = (short)1379794948;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 6:
									num = (short)1862008834;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								IL_1BC:
								num = (short)1405157379;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								IL_1BA:
								goto IL_1BC;
							}
							IL_20A:
							return result;
							IL_280:
							return false;
						}
						finally
						{
							num = (short)933167106;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								switch (num2)
								{
								case 0:
									goto IL_2EE;
								case 1:
									enumerator.Dispose();
									num = (short)461504512;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 2:
									switch (0)
									{
									case 0:
										goto IL_2B7;
									}
									continue;
								}
								IL_2B7:
								if (enumerator == null)
								{
									break;
								}
								num = (short)133562369;
								num2 = (int)((global::System.IntPtr)num);
							}
							IL_2EE:;
						}
						goto IL_2F1;
					case 23:
						goto IL_E59;
					case 24:
						goto IL_1059;
					case 25:
						if (!radErgoWideControlHeadMultiControlHead_A.Value)
						{
							num = (short)869072898;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return true;
					}
					goto IL_97;
					IL_2F1:
					num = (short)1606746119;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_540:
					num = (short)154796057;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					Block_13:
					try
					{
						IL_E59:
						num = (short)297205761;
						num2 = (int)((global::System.IntPtr)num);
						for (;;)
						{
							switch (num2)
							{
							case 0:
								if (!enumerator.MoveNext())
								{
									num = (short)1218445317;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								num = (short)1996226563;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							case 1:
								switch (0)
								{
								case 0:
									goto IL_E9B;
								}
								continue;
							case 2:
								goto IL_F67;
							case 3:
								if ((((global::AcpCommonLib.IAcpFeatureNode)enumerator.Current)[10207] as global::Motorola.MackinawCPS.CoreFeatures.RadioVIPs.RadioVIPInnerSection).RadVipOutputFeature_A20947.Value == 11)
								{
									num = (short)938803206;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								break;
							case 4:
								goto IL_F0A;
							case 5:
								num = (short)1034354690;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							case 6:
								result = true;
								num = (short)153026564;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							IL_F0F:
							num = (short)1134690304;
							num2 = (int)((global::System.IntPtr)num);
							continue;
							IL_E9B:
							goto IL_F0F;
						}
						IL_F0A:
						return result;
						IL_F67:
						goto IL_BC3;
					}
					finally
					{
						num = (short)1199046656;
						num2 = (int)((global::System.IntPtr)num);
						for (;;)
						{
							switch (num2)
							{
							case 0:
								switch (0)
								{
								case 0:
									goto IL_F9F;
								}
								continue;
							case 1:
								goto IL_FD7;
							case 2:
								enumerator.Dispose();
								num = (short)1623916545;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							IL_F9F:
							if (enumerator == null)
							{
								break;
							}
							num = (short)1701969922;
							num2 = (int)((global::System.IntPtr)num);
						}
						IL_FD7:;
					}
					goto IL_FDA;
					IL_BC3:
					enumerator = dekvipinnerRecset.GetEnumerator();
					num = (short)226623509;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					Block_10:
					try
					{
						IL_9C3:
						num = (short)501284865;
						num2 = (int)((global::System.IntPtr)num);
						for (;;)
						{
							switch (num2)
							{
							case 0:
								if ((((global::AcpCommonLib.IAcpFeatureNode)enumerator.Current)[10207] as global::Motorola.MackinawCPS.CoreFeatures.RadioVIPs.RadioVIPInnerSection).RadVipOutputFeature_A20947.Value == 10)
								{
									num = (short)235012101;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								break;
							case 1:
								switch (0)
								{
								case 0:
									goto IL_A06;
								}
								continue;
							case 2:
								goto IL_AD2;
							case 3:
								goto IL_A21;
							case 4:
								num = (short)888274946;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							case 5:
								result = true;
								num = (short)1226702851;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							case 6:
								if (!enumerator.MoveNext())
								{
									num = (short)2007040004;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								num = (short)680591360;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							IL_A26:
							num = (short)746979334;
							num2 = (int)((global::System.IntPtr)num);
							continue;
							IL_A06:
							goto IL_A26;
						}
						IL_A21:
						return result;
						IL_AD2:
						goto IL_1090;
					}
					finally
					{
						num = (short)55246850;
						num2 = (int)((global::System.IntPtr)num);
						for (;;)
						{
							switch (num2)
							{
							case 0:
								goto IL_B42;
							case 1:
								enumerator.Dispose();
								num = (short)718667776;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							case 2:
								switch (0)
								{
								case 0:
									goto IL_B0A;
								}
								continue;
							}
							IL_B0A:
							if (enumerator == null)
							{
								break;
							}
							num = (short)908460033;
							num2 = (int)((global::System.IntPtr)num);
						}
						IL_B42:;
					}
					goto IL_B45;
					IL_1090:
					enumerator = dekvipinnerRecset.GetEnumerator();
					num = (short)573767688;
					num2 = (int)((global::System.IntPtr)num);
				}
				IL_352:
				try
				{
					num = (short)2062090246;
					num2 = (int)((global::System.IntPtr)num);
					for (;;)
					{
						switch (num2)
						{
						case 0:
						{
							global::AcpCommonLib.IAcpFeatureNode acpFeatureNode2;
							if ((acpFeatureNode2[10206] as global::Motorola.MackinawCPS.CoreFeatures.DEK.DEKVIPInnerSection).DEKVIPOutputFeature_A21346.Value != 11)
							{
								num = (short)1297022980;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							goto IL_12BB;
						}
						case 1:
						{
							global::AcpCommonLib.IAcpFeatureNode acpFeatureNode2;
							if ((acpFeatureNode2[10206] as global::Motorola.MackinawCPS.CoreFeatures.DEK.DEKVIPInnerSection).DEKVIPOutputFeature_A21346.Value != 10)
							{
								num = (short)1516306435;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							goto IL_12BB;
						}
						case 2:
							goto IL_12F5;
						case 3:
							num = (short)1381040128;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 4:
							num = (short)1058078729;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 5:
							goto IL_12BB;
						case 6:
							switch (0)
							{
							case 0:
								goto IL_1175;
							}
							continue;
						case 7:
							goto IL_12D7;
						case 8:
							num = (short)275906562;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 9:
						{
							global::AcpCommonLib.IAcpFeatureNode acpFeatureNode2;
							if ((acpFeatureNode2[10206] as global::Motorola.MackinawCPS.CoreFeatures.DEK.DEKVIPInnerSection).DEKVIPOutputFeature_A21346.Value == 12)
							{
								num = (short)600768517;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							break;
						}
						case 10:
						{
							if (!enumerator.MoveNext())
							{
								num = (short)1839202312;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							global::AcpCommonLib.IAcpFeatureNode acpFeatureNode2 = enumerator.Current;
							num = (short)613548033;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						}
						IL_127C:
						num = (short)1378615306;
						num2 = (int)((global::System.IntPtr)num);
						continue;
						IL_1175:
						goto IL_127C;
						IL_12BB:
						result = true;
						num = (short)428015623;
						num2 = (int)((global::System.IntPtr)num);
					}
					IL_12D7:
					return result;
					IL_12F5:
					return false;
				}
				finally
				{
					num = (short)493289472;
					num2 = (int)((global::System.IntPtr)num);
					for (;;)
					{
						switch (num2)
						{
						case 0:
							switch (0)
							{
							case 0:
								goto IL_132C;
							}
							continue;
						case 1:
							goto IL_1364;
						case 2:
							enumerator.Dispose();
							num = (short)1401749505;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						IL_132C:
						if (enumerator == null)
						{
							break;
						}
						num = (short)186646530;
						num2 = (int)((global::System.IntPtr)num);
					}
					IL_1364:;
				}
				return result;
				IL_36F:
				return true;
				IL_39B:
				return (global::AcpCommonLib.FeatureManager.GetFeature(2045)[0] as global::Motorola.MackinawCPS.CoreFeatures.RadioWide.RadioWide).LightbarPattern.RadWideUniversalRelayControllerEquipped_A37191.Value;
				IL_57B:
				goto IL_B45;
				IL_61B:
				return radErgoWideControlHeadMultipleControlHeadStyle_A.Value == 0;
				IL_B45:
				return !radErgoWideControlHeadMultiControlHead_A.Value;
				IL_FDA:
				return (global::AcpCommonLib.FeatureManager.GetFeature(2045)[0] as global::Motorola.MackinawCPS.CoreFeatures.RadioWide.RadioWide).DualRadio.RadWideDualRadioSelection_A42236 != 0;
				IL_1059:
				num = (short)830734336;
				short num3 = num;
				return true;
				IL_1088:
				global::Motorola.MackinawCPS.CoreFeatures.RadioWide.Features features;
				return features.RadWideFeaturesChannelFallbackEnableValue;
				IL_10B0:
				try
				{
					num = (short)1315766273;
					num2 = (int)((global::System.IntPtr)num);
					for (;;)
					{
						switch (num2)
						{
						case 0:
							if (!enumerator.MoveNext())
							{
								num = (short)103481349;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							num = (short)1964900358;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 1:
							switch (0)
							{
							case 0:
								goto IL_6B4;
							}
							continue;
						case 2:
							goto IL_7D0;
						case 3:
							goto IL_71D;
						case 4:
						{
							result = true;
							num = (short)1318449369;
							short num4 = num;
							num = (short)869462233;
							switch ((num4 == num) ? 1 : 0)
							{
							case 0:
							case 2:
								break;
							default:
								num = (short)755826688;
								if (num != 0)
								{
								}
								num = (short)1515585539;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							break;
						}
						case 5:
							num = (short)1780285442;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 6:
							if ((((global::AcpCommonLib.IAcpFeatureNode)enumerator.Current)[10206] as global::Motorola.MackinawCPS.CoreFeatures.DEK.DEKVIPInnerSection).DEKVIPOutputFeature_A21346.Value == 10)
							{
								num = (short)1963851780;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							break;
						}
						IL_77C:
						num = (short)825622528;
						num2 = (int)((global::System.IntPtr)num);
						continue;
						IL_6B4:
						goto IL_77C;
					}
					IL_71D:
					return result;
					IL_7D0:;
				}
				finally
				{
					num = (short)1464336386;
					num2 = (int)((global::System.IntPtr)num);
					for (;;)
					{
						switch (num2)
						{
						case 0:
							goto IL_83D;
						case 1:
							enumerator.Dispose();
							num = (short)846462976;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 2:
							switch (0)
							{
							case 0:
								goto IL_804;
							}
							continue;
						}
						IL_804:
						if (enumerator == null)
						{
							break;
						}
						num = (short)1919418369;
						num2 = (int)((global::System.IntPtr)num);
					}
					IL_83D:;
				}
				return false;
				IL_97:
				global::Motorola.MackinawCPS.CoreFeatures.RadioErgonomicsWide.RadioErgonomicsWide radioErgonomicsWide = global::AcpCommonLib.FeatureManager.GetFeature(2033)[0] as global::Motorola.MackinawCPS.CoreFeatures.RadioErgonomicsWide.RadioErgonomicsWide;
				radErgoWideControlHeadMultipleControlHeadStyle_A = radioErgonomicsWide.ControlHead.RadErgoWideControlHeadMultipleControlHeadStyle_A8561;
				radErgoWideControlHeadMultiControlHead_A = radioErgonomicsWide.ControlHead.RadErgoWideControlHeadMultiControlHead_A8550;
				radioVIPInnerRecset = ((global::AcpCommonLib.FeatureManager.GetFeature(2125) as global::Motorola.MackinawCPS.CoreFeatures.RadioVIPs.RadioVIPsRecset)[0][10218].EmbeddedRecset as global::Motorola.MackinawCPS.CoreFeatures.RadioVIPs.RadioVIPInnerRecset);
				dekvipinnerRecset = ((global::AcpCommonLib.FeatureManager.GetFeature(2129) as global::Motorola.MackinawCPS.CoreFeatures.DEK.DEKRecset)[0][10233].EmbeddedRecset as global::Motorola.MackinawCPS.CoreFeatures.DEK.DEKVIPInnerRecset);
				features = (global::AcpCommonLib.FeatureManager.GetFeature(2045)[0][10105] as global::Motorola.MackinawCPS.CoreFeatures.RadioWide.Features);
				num = (short)589824020;
				num2 = (int)((global::System.IntPtr)num);
				goto IL_28;
			}
			}
		}

		// Token: 0x06008C93 RID: 35987 RVA: 0x0083B8F4 File Offset: 0x00839AF4
		internal static bool ConBottomFunctionButtonIndexIsValid(global::AcpCommonLib.IAcpFeatureSection self, int index)
		{
			short num = (short)502595584;
			switch (num)
			{
			default:
			{
				num = (short)2094202894;
				int num2 = (int)((global::System.IntPtr)num);
				for (;;)
				{
					bool result;
					global::System.Collections.Generic.IEnumerator<global::AcpBusinessLayer.FeatureNode> enumerator;
					global::AcpBusinessLayer.AcpListField acpListField;
					global::AcpBusinessLayer.AcpListField acpListField2;
					global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO9.ControlHeadO9Recset controlHeadO9Recset;
					switch (num2)
					{
					case 0:
						try
						{
							num = (short)376569864;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								switch (num2)
								{
								case 0:
									num = (short)151388161;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 1:
								{
									global::AcpCommonLib.IAcpFeatureNode acpFeatureNode;
									if ((acpFeatureNode[10615] as global::Motorola.MackinawCPS.CoreFeatures.ActionConsolidation.General).RadioErgoConfigACActionType_A42871.Value != 0)
									{
										num = (short)1564475395;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									break;
								}
								case 2:
									goto IL_1E3;
								case 3:
									result = false;
									num = (short)1264910338;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 4:
								{
									global::AcpCommonLib.IAcpFeatureNode acpFeatureNode;
									if (index - 1 == (acpFeatureNode.Parent as global::AcpBusinessLayer.Recordset).IndexOf(acpFeatureNode))
									{
										num = (short)1538785280;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									break;
								}
								case 5:
									goto IL_2AE;
								case 6:
								{
									if (!enumerator.MoveNext())
									{
										num = (short)1684144135;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									global::AcpCommonLib.IAcpFeatureNode acpFeatureNode = enumerator.Current;
									num = (short)1975779332;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 7:
									num = (short)1724710917;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 8:
									switch (0)
									{
									case 0:
										goto IL_18A;
									}
									continue;
								}
								IL_18C:
								num = (short)924254214;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								IL_18A:
								goto IL_18C;
							}
							IL_1E3:
							return result;
							IL_2AE:
							goto IL_546;
						}
						finally
						{
							num = (short)1218379778;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								switch (num2)
								{
								case 0:
									enumerator.Dispose();
									num = (short)97124353;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 1:
									goto IL_31F;
								case 2:
									switch (0)
									{
									case 0:
										goto IL_2E5;
									}
									continue;
								}
								IL_2E5:
								if (enumerator == null)
								{
									break;
								}
								num = (short)106168320;
								num2 = (int)((global::System.IntPtr)num);
							}
							IL_31F:;
						}
						goto IL_322;
					case 1:
						acpListField = null;
						goto IL_47B;
					case 2:
						if (index == 0)
						{
							num = (short)1709703174;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)395509773;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 3:
					{
						num = (short)975634432;
						short num3 = num;
						global::Motorola.MackinawCPS.CoreFeatures.ActionConsolidation.ActionConsolidationRecset actionConsolidationRecset = global::AcpCommonLib.FeatureManager.GetFeature(4008) as global::Motorola.MackinawCPS.CoreFeatures.ActionConsolidation.ActionConsolidationRecset;
						num = (short)176750603;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 4:
						num = 16;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 5:
						return false;
					case 6:
						return false;
					case 7:
						return true;
					case 8:
						try
						{
							num = (short)472252424;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								switch (num2)
								{
								case 0:
									num = (short)1335296005;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 1:
								{
									global::AcpCommonLib.IAcpFeatureNode acpFeatureNode2;
									if ((acpFeatureNode2[10610] as global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO9.DirectionalButtonsListInnerSection).RadErgCtrlHeadO9DirLightBarIndex_A36601.Value == index)
									{
										num = (short)46792707;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									break;
								}
								case 2:
									goto IL_65F;
								case 3:
									result = false;
									num = (short)1538588674;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 4:
								{
									if (!enumerator.MoveNext())
									{
										num = (short)351797248;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									global::AcpCommonLib.IAcpFeatureNode acpFeatureNode2 = enumerator.Current;
									num = (short)1702559750;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 5:
									goto IL_70E;
								case 6:
								{
									global::AcpCommonLib.IAcpFeatureNode acpFeatureNode2;
									if ((acpFeatureNode2[10610] as global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO9.DirectionalButtonsListInnerSection).RadErgCtrlHeadO9DirLightBarFeature_A36597.Value == acpListField2.Value)
									{
										num = (short)580386823;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									break;
								}
								case 7:
									num = (short)825360385;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 8:
									switch (0)
									{
									case 0:
										goto IL_5E0;
									}
									continue;
								}
								IL_6B5:
								num = (short)1300430852;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								IL_5E0:
								goto IL_6B5;
							}
							IL_65F:
							return result;
							IL_70E:
							return true;
						}
						finally
						{
							num = (short)1484914690;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								switch (num2)
								{
								case 0:
									enumerator.Dispose();
									num = (short)913637377;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 1:
									goto IL_780;
								case 2:
									switch (0)
									{
									case 0:
										goto IL_747;
									}
									continue;
								}
								IL_747:
								if (enumerator == null)
								{
									break;
								}
								num = (short)525860864;
								num2 = (int)((global::System.IntPtr)num);
							}
							IL_780:;
						}
						goto Block_11;
					case 9:
						goto IL_783;
					case 10:
						if (acpListField2.Value != 207)
						{
							num = (short)950861831;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_103;
					case 11:
					{
						global::Motorola.MackinawCPS.CoreFeatures.ActionConsolidation.ActionConsolidationRecset actionConsolidationRecset;
						if (actionConsolidationRecset == null)
						{
							num = (short)319160325;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)1657470977;
						if (num != 0)
						{
						}
						enumerator = actionConsolidationRecset.GetEnumerator();
						num = (short)319684608;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 12:
					{
						global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO9.DirectionalButtonsListInnerRecset directionalButtonsListInnerRecset;
						enumerator = directionalButtonsListInnerRecset.GetEnumerator();
						num = (short)1024983048;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 13:
						if (acpListField2.Value == 206)
						{
							num = (short)1099890691;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_546;
					case 14:
						switch (0)
						{
						case 0:
							goto IL_90;
						}
						continue;
					case 15:
						num = (short)1144324106;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 16:
						if (acpListField2.Value != 206)
						{
							num = (short)2009858063;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_103;
					case 17:
					{
						global::Motorola.MackinawCPS.CoreFeatures.RadioWide.RadioWide radioWide = global::AcpCommonLib.FeatureManager.GetFeature(2045)[0] as global::Motorola.MackinawCPS.CoreFeatures.RadioWide.RadioWide;
						global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO9.DirectionalButtonsListInnerRecset directionalButtonsListInnerRecset = controlHeadO9Recset[0][10609].EmbeddedRecset as global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO9.DirectionalButtonsListInnerRecset;
						if (radioWide.LightbarPattern.RadWideUniversalRelayControllerEquipped_A37191.Value)
						{
							num = (short)1520304140;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return true;
					}
					case 18:
						if (acpListField2 != null)
						{
							num = (short)1072824324;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_103;
					}
					goto IL_90;
					IL_103:
					num = (short)1979842562;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_322:
					num = (short)1846738945;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_90:
					global::Motorola.MackinawCPS.CoreFeatures.ControlHeadE5.E5BottomFunctionButtonInnerSection e5BottomFunctionButtonInnerSection = self as global::Motorola.MackinawCPS.CoreFeatures.ControlHeadE5.E5BottomFunctionButtonInnerSection;
					if (e5BottomFunctionButtonInnerSection == null)
					{
						goto IL_322;
					}
					acpListField = e5BottomFunctionButtonInnerSection.E5BottomFunctionButtonFeature_43758;
					goto IL_47B;
					Block_11:
					try
					{
						IL_783:
						num = (short)2052128776;
						num2 = (int)((global::System.IntPtr)num);
						for (;;)
						{
							switch (num2)
							{
							case 0:
								goto IL_8BB;
							case 1:
								num = (short)288751621;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							case 2:
							{
								if (!enumerator.MoveNext())
								{
									num = (short)296943617;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								global::AcpCommonLib.IAcpFeatureNode acpFeatureNode3 = enumerator.Current;
								num = (short)1075511302;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							case 3:
								goto IL_8D6;
							case 4:
							{
								global::AcpCommonLib.IAcpFeatureNode acpFeatureNode3;
								if ((acpFeatureNode3[10617] as global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO9.TopFunctionProgrammableButtonListInnerSection).O9CHCnvTopFunctionButtonIndex_A36634.Value == index)
								{
									num = (short)1979449344;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								break;
							}
							case 5:
								goto IL_947;
							case 6:
							{
								num = (short)620946397;
								short num4 = num;
								num = (short)290907101;
								switch ((num4 == num) ? 1 : 0)
								{
								case 0:
								case 2:
									goto IL_8BB;
								default:
								{
									num = (short)1386610688;
									if (num != 0)
									{
									}
									global::AcpCommonLib.IAcpFeatureNode acpFeatureNode3;
									if ((acpFeatureNode3[10617] as global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO9.TopFunctionProgrammableButtonListInnerSection).O9CHCnvTopFunctionButtonFeature_A36629.Value == acpListField2.Value)
									{
										num = (short)1898184711;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									break;
								}
								}
								break;
							}
							case 7:
								num = (short)409468932;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							case 8:
								switch (0)
								{
								case 0:
									goto IL_7CE;
								}
								continue;
							}
							IL_87A:
							num = (short)1286340610;
							num2 = (int)((global::System.IntPtr)num);
							continue;
							IL_7CE:
							goto IL_87A;
							IL_8BB:
							result = false;
							num = (short)725352451;
							num2 = (int)((global::System.IntPtr)num);
						}
						IL_8D6:
						return result;
						IL_947:
						goto IL_3FF;
					}
					finally
					{
						num = (short)285343746;
						num2 = (int)((global::System.IntPtr)num);
						for (;;)
						{
							switch (num2)
							{
							case 0:
								enumerator.Dispose();
								num = (short)1099235329;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							case 1:
								goto IL_9B6;
							case 2:
								switch (0)
								{
								case 0:
									goto IL_97E;
								}
								continue;
							}
							IL_97E:
							if (enumerator == null)
							{
								break;
							}
							num = (short)867041280;
							num2 = (int)((global::System.IntPtr)num);
						}
						IL_9B6:;
					}
					return result;
					IL_3FF:
					num = (short)180289553;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_47B:
					acpListField2 = acpListField;
					num = (short)2023489554;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_546:
					controlHeadO9Recset = (global::AcpCommonLib.FeatureManager.GetFeature(4003) as global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO9.ControlHeadO9Recset);
					enumerator = (controlHeadO9Recset[0][10616].EmbeddedRecset as global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO9.TopFunctionProgrammableButtonListInnerRecset).GetEnumerator();
					num = (short)1111425033;
					num2 = (int)((global::System.IntPtr)num);
				}
				return true;
			}
			}
		}

		// Token: 0x040043F5 RID: 17397
		private const int a = 135;

		// Token: 0x040043F6 RID: 17398
		private const int b = 136;
	}
}
