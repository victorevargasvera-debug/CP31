using System;
using System.Collections.Generic;
using AcpBusinessLayer;
using AcpBusinessLayer.UndoRedo;
using AcpCommonLib;
using AcpCommonLib.UndoRedo;
using CommonResources;
using Motorola.MackinawCPS.CoreFeatures.ActionConsolidation;
using Motorola.MackinawCPS.CoreFeatures.Buttons;
using Motorola.MackinawCPS.CoreFeatures.ControlHeadE5;
using Motorola.MackinawCPS.CoreFeatures.ControlHeadO2;
using Motorola.MackinawCPS.CoreFeatures.ControlHeadO3;
using Motorola.MackinawCPS.CoreFeatures.ControlHeadO5;
using Motorola.MackinawCPS.CoreFeatures.ControlHeadO7;
using Motorola.MackinawCPS.CoreFeatures.ControlHeadO9;
using Motorola.MackinawCPS.CoreFeatures.EmergencyWide;
using Motorola.MackinawCPS.CoreFeatures.RadioInformation;
using Motorola.MackinawCPS.CoreFeatures.RadioWide;
using Motorola.MackinawCPS.CoreFeatures.TrunkingEmergencyProfiles;

namespace Motorola.MackinawCPS.CoreFeatures.KeypadMicAndAccessories
{
	// Token: 0x02000306 RID: 774
	public static class KeypadMicAndAccessoriesConstraints
	{
		// Token: 0x06007B38 RID: 31544 RVA: 0x007047A0 File Offset: 0x007029A0
		public static void ConSyncUpDownBtnFeature(global::AcpCommonLib.IAcpFeatureSection self, global::AcpCommonLib.UndoRedo.ContainerTask task)
		{
			int num3;
			int num5;
			for (;;)
			{
				IL_00:
				short num = (short)1189216256;
				int num2 = (int)num;
				switch (num2)
				{
				default:
				{
					switch (0)
					{
					case 0:
						goto IL_CF;
					}
					bool flag;
					global::AcpCommonLib.IAcpRecordset parentRecset;
					for (;;)
					{
						IL_28:
						global::Motorola.MackinawCPS.CoreFeatures.KeypadMicAndAccessories.KMANavigationControlsTableInnerSection kmanavigationControlsTableInnerSection;
						switch (num2)
						{
						case 0:
							if (num3 != 67)
							{
								num = (short)688390155;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							goto IL_394;
						case 1:
							goto IL_6D7;
						case 2:
							num = (short)125501463;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 3:
							num3 = 38;
							num = (short)372244487;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 4:
						{
							num = (short)1115029504;
							short num4 = num;
							num = (short)1151991821;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						case 5:
							if (num5 != 66)
							{
								num = (short)1109065761;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							goto IL_394;
						case 6:
							goto IL_448;
						case 7:
							goto IL_5FB;
						case 8:
						{
							num = (short)1844707329;
							if (num != 0)
							{
							}
							num = (short)460852193;
							short num6 = num;
							num = (short)639503329;
							switch ((num6 == num) ? 1 : 0)
							{
							case 0:
							case 2:
								goto IL_00;
							default:
								num = (short)1901985792;
								if (num != 0)
								{
								}
								goto IL_1BB;
							}
							break;
						}
						case 9:
							if (num3 != 88)
							{
								num = (short)212074527;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							goto IL_394;
						case 10:
							if (!flag)
							{
								num = (short)472776721;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							num5 = kmanavigationControlsTableInnerSection.RadErgoControlKMAUpDownButton_41760.Value;
							num3 = num5 - 1;
							num = (short)2068709413;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 11:
							num = (short)977469449;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 12:
							goto IL_394;
						case 13:
							if (num3 != 65)
							{
								num = (short)1479475224;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							goto IL_394;
						case 14:
							num = (short)393543690;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 15:
							goto IL_17D;
						case 16:
							if (kmanavigationControlsTableInnerSection != null)
							{
								num = (short)950075406;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							return;
						case 17:
							num3 = kmanavigationControlsTableInnerSection.RadErgoControlKMAUpDownButton_41760.Value;
							num5 = num3 + 1;
							num = (short)2080833563;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 18:
							flag = true;
							num = (short)1222639624;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 19:
							num5 = 38;
							num = (short)1900806165;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 20:
							if (parentRecset != null)
							{
								num = (short)1224212519;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							return;
						case 21:
							goto IL_51B;
						case 22:
							if (num3 != 0)
							{
								num = (short)1433927708;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							return;
						case 23:
							if (num5 != 64)
							{
								num = (short)1061879834;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							goto IL_394;
						case 24:
							num = (short)1290207232;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 25:
							if (parentRecset.Count < 2)
							{
								num = (short)1006305286;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							num = (short)2010775582;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 26:
							num = (short)1942159365;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 27:
							if (num3 == 38)
							{
								num = (short)450560019;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							goto IL_51B;
						case 28:
							num = (short)1982595104;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 29:
							goto IL_17D;
						case 30:
							if (parentRecset[1] == self.Parent)
							{
								num = (short)230948882;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							goto IL_1BB;
						case 31:
							num = (short)331022370;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 32:
							if (num5 == 0)
							{
								num = (short)1357709313;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							num = (short)1995898918;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 33:
							num = (short)840761380;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 34:
							if (num5 != 143)
							{
								num = (short)608960514;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							goto IL_394;
						case 35:
							goto IL_3B8;
						case 36:
							if (num5 == 87)
							{
								num = (short)1089404940;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							goto IL_6DC;
						case 37:
							if (num5 == 38)
							{
								num = (short)671023107;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							goto IL_5FB;
						case 38:
							if (num3 != 144)
							{
								num = (short)18284548;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							goto IL_394;
						case 39:
							num = (short)1450115097;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						break;
						IL_17D:
						num = (short)303890454;
						num2 = (int)((global::System.IntPtr)num);
						continue;
						IL_1BB:
						kmanavigationControlsTableInnerSection = (self as global::Motorola.MackinawCPS.CoreFeatures.KeypadMicAndAccessories.KMANavigationControlsTableInnerSection);
						num = (short)664076304;
						num2 = (int)((global::System.IntPtr)num);
						continue;
						IL_394:
						num3 = 143;
						num5 = 144;
						num = (short)17039395;
						num2 = (int)((global::System.IntPtr)num);
						continue;
						IL_51B:
						task.AddTask(new global::AcpBusinessLayer.UndoRedo.ModifyDataTask<int>((self.ParentRecset[1] as global::Motorola.MackinawCPS.CoreFeatures.KeypadMicAndAccessories.KMANavigationControlsTableInner).KMANavigationControlsTableInnerSection.RadErgoControlKMAUpDownButton_41760, num5));
						num = (short)430112783;
						num2 = (int)((global::System.IntPtr)num);
						continue;
						IL_5FB:
						task.AddTask(new global::AcpBusinessLayer.UndoRedo.ModifyDataTask<int>((self.ParentRecset[1] as global::Motorola.MackinawCPS.CoreFeatures.KeypadMicAndAccessories.KMANavigationControlsTableInner).KMANavigationControlsTableInnerSection.RadErgoControlKMAUpDownButton_41760, num5));
						num = (short)2026242077;
						num2 = (int)((global::System.IntPtr)num);
					}
					IL_CF:
					num3 = 0;
					num5 = 0;
					flag = false;
					parentRecset = self.ParentRecset;
					num = (short)1817706516;
					num2 = (int)((global::System.IntPtr)num);
					goto IL_28;
				}
				}
			}
			return;
			IL_3B8:
			goto IL_6DC;
			IL_448:
			return;
			IL_6D7:
			return;
			IL_6DC:
			global::Motorola.MackinawCPS.CoreFeatures.ControlHeadE5.ControlHeadE5Constraints.SyncNavigationControlsCPField(task, num3, num5);
			global::Motorola.MackinawCPS.CoreFeatures.ControlHeadE5.ControlHeadE5Constraints.SyncE5NavigationControls(task, num3, num5);
			global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO2.ControlHeadO2Constraints.SyncO2NavigationControls(task, num3, num5);
			global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO3.ControlHeadO3Constraints.SyncO3NavigationControls(task, num3, num5);
			global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO7.ControlHeadO7Constraints.SyncO7NavigationControls(task, num3, num5);
			global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO5.ControlHeadO5Constraints.SyncO5NavigationControls(task, num3, num5);
			global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO9.ControlHeadO9Constraints.SyncO9NavigationControls(task, num3, num5);
			global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO7.ControlHeadO7Constraints.CalculateValidityForO2O7MFK();
		}

		// Token: 0x06007B39 RID: 31545 RVA: 0x00704EC8 File Offset: 0x007030C8
		public static void SyncKeypadMicAndAccessoriesNavigationControls(global::AcpCommonLib.UndoRedo.ContainerTask task, int upButtonConfigedFeatureValue, int downButtonConfigedFeatureValue)
		{
			short num = (short)1174601728;
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
				global::Motorola.MackinawCPS.CoreFeatures.KeypadMicAndAccessories.KeypadMicAndAccessoriesRecset keypadMicAndAccessoriesRecset;
				for (;;)
				{
					IL_28:
					switch (num2)
					{
					case 0:
						return;
					case 1:
					{
						global::Motorola.MackinawCPS.CoreFeatures.KeypadMicAndAccessories.KMANavigationControlsTableInnerRecset kmanavigationControlsTableInnerRecset;
						global::AcpBusinessLayer.AcpListField radErgoControlKMAUpDownButton_ = (kmanavigationControlsTableInnerRecset[0][10754] as global::Motorola.MackinawCPS.CoreFeatures.KeypadMicAndAccessories.KMANavigationControlsTableInnerSection).RadErgoControlKMAUpDownButton_41760;
						task.AddTask(new global::AcpBusinessLayer.UndoRedo.ModifyDataTask<int>(radErgoControlKMAUpDownButton_, upButtonConfigedFeatureValue));
						global::AcpBusinessLayer.AcpListField radErgoControlKMAUpDownButton_2 = (kmanavigationControlsTableInnerRecset[1][10754] as global::Motorola.MackinawCPS.CoreFeatures.KeypadMicAndAccessories.KMANavigationControlsTableInnerSection).RadErgoControlKMAUpDownButton_41760;
						task.AddTask(new global::AcpBusinessLayer.UndoRedo.ModifyDataTask<int>(radErgoControlKMAUpDownButton_2, downButtonConfigedFeatureValue));
						num = (short)586153984;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 2:
					{
						num = (short)1069312085;
						short num3 = num;
						num = (short)1578920021;
						switch ((num3 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							return;
						default:
						{
							num = (short)526319616;
							if (num != 0)
							{
							}
							num = (short)913702912;
							short num4 = num;
							num = (short)1700986881;
							if (num != 0)
							{
							}
							global::Motorola.MackinawCPS.CoreFeatures.KeypadMicAndAccessories.KMANavigationControlsTableInnerRecset kmanavigationControlsTableInnerRecset;
							if (kmanavigationControlsTableInnerRecset != null)
							{
								num = (short)1795686401;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							return;
						}
						}
						break;
					}
					case 3:
					{
						global::Motorola.MackinawCPS.CoreFeatures.KeypadMicAndAccessories.KMANavigationControlsTableInnerRecset kmanavigationControlsTableInnerRecset = keypadMicAndAccessoriesRecset[0][10753].EmbeddedRecset as global::Motorola.MackinawCPS.CoreFeatures.KeypadMicAndAccessories.KMANavigationControlsTableInnerRecset;
						num = (short)1303183362;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 4:
						if (keypadMicAndAccessoriesRecset != null)
						{
							num = (short)963117059;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return;
					}
					goto IL_43;
				}
				return;
				IL_43:
				keypadMicAndAccessoriesRecset = (global::AcpCommonLib.FeatureManager.GetFeature(2128) as global::Motorola.MackinawCPS.CoreFeatures.KeypadMicAndAccessories.KeypadMicAndAccessoriesRecset);
				num = (short)1693843460;
				num2 = (int)((global::System.IntPtr)num);
				goto IL_28;
			}
			}
		}

		// Token: 0x06007B3A RID: 31546 RVA: 0x007050BC File Offset: 0x007032BC
		public static void ConSyncCnvDataBtnFeature(global::AcpCommonLib.IAcpFeatureSection self, global::AcpCommonLib.UndoRedo.ContainerTask task)
		{
			short num = (short)1900085248;
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
				global::AcpBusinessLayer.AcpRecRefField acpRecRefField;
				int num3;
				int featureSectionId;
				global::AcpBusinessLayer.AcpListField acpListField;
				bool flag2;
				for (;;)
				{
					IL_27:
					global::Motorola.MackinawCPS.CoreFeatures.Buttons.DataButtonInnerRecset dataButtonInnerRecset;
					global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO9.ConsolidatedActionBCOListInnerRecset consolidatedActionBCOListInnerRecset;
					global::System.Collections.Generic.IEnumerator<global::AcpBusinessLayer.FeatureNode> enumerator;
					bool flag;
					global::Motorola.MackinawCPS.CoreFeatures.Buttons.ButtonsRecset buttonsRecset;
					global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO7.ControlHeadO7Recset controlHeadO7Recset;
					global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO7.O7DataButtonInnerRecset o7DataButtonInnerRecset;
					global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO9.O9DataButtonInnerRecset o9DataButtonInnerRecset;
					global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO3.ControlHeadO3Recset controlHeadO3Recset;
					global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO3.DataButtonInnerRecset dataButtonInnerRecset3;
					global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO9.ControlHeadO9Recset controlHeadO9Recset;
					global::Motorola.MackinawCPS.CoreFeatures.RadioWide.RadioWide radioWide;
					switch (num2)
					{
					case 0:
						return;
					case 1:
						if (dataButtonInnerRecset != null)
						{
							num = (short)396623933;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_B44;
					case 2:
					{
						task.AddTask(new global::AcpBusinessLayer.UndoRedo.AddRecordTask(consolidatedActionBCOListInnerRecset.CreateDefaultRecord()));
						int index = consolidatedActionBCOListInnerRecset.Count - 1;
						global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO9.ConsolidatedActionBCOListInner consolidatedActionBCOListInner = consolidatedActionBCOListInnerRecset[index] as global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO9.ConsolidatedActionBCOListInner;
						task.AddTask(new global::AcpBusinessLayer.UndoRedo.ModifyDataTask<int>(consolidatedActionBCOListInner.ConsolidatedActionBCOListInnerSection.RadErgoControlO9ACBCOListBco_A36666, 134));
						task.AddTask(new global::AcpBusinessLayer.UndoRedo.ModifyRecRefDataTask(consolidatedActionBCOListInner.ConsolidatedActionBCOListInnerSection.RadErgoControlO9ACBCOListIndex_A36668, acpRecRefField.UIValue));
						num = (short)1491009569;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 3:
						try
						{
							num = (short)156958722;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								switch (num2)
								{
								case 0:
									goto IL_1777;
								case 1:
								{
									if (!enumerator.MoveNext())
									{
										num = (short)1181548548;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO9.ConsolidatedActionBCOListInner consolidatedActionBCOListInner2 = (global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO9.ConsolidatedActionBCOListInner)enumerator.Current;
									num = (short)754778119;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 2:
									switch (0)
									{
									case 0:
										goto IL_16B4;
									}
									continue;
								case 3:
									if (num3 != 227)
									{
										num = (short)907542537;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									flag = true;
									num = (short)230817803;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 4:
									goto IL_1888;
								case 5:
								{
									global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO9.ConsolidatedActionBCOListInner consolidatedActionBCOListInner2;
									if (acpRecRefField.Value != consolidatedActionBCOListInner2.ConsolidatedActionBCOListInnerSection.RadErgoControlO9ACBCOListIndex_A36668.Value)
									{
										num = (short)990248970;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									goto IL_1888;
								}
								case 6:
									num = (short)100073477;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 7:
								{
									global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO9.ConsolidatedActionBCOListInner consolidatedActionBCOListInner2;
									if (consolidatedActionBCOListInner2.ConsolidatedActionBCOListInnerSection.RadErgoControlO9ACBCOListBco_A36666.Value == 134)
									{
										num = (short)1242103821;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									break;
								}
								case 8:
									goto IL_18A0;
								case 9:
								{
									global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO9.ConsolidatedActionBCOListInner consolidatedActionBCOListInner2;
									task.AddTask(new global::AcpBusinessLayer.UndoRedo.DeleteRecordTask(consolidatedActionBCOListInner2));
									num = (short)787808256;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 10:
								{
									global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO9.ConsolidatedActionBCOListInner consolidatedActionBCOListInner2;
									task.AddTask(new global::AcpBusinessLayer.UndoRedo.ModifyRecRefDataTask(consolidatedActionBCOListInner2.ConsolidatedActionBCOListInnerSection.RadErgoControlO9ACBCOListIndex_A36668, acpRecRefField.UIValue));
									num = (short)1178009612;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 11:
									if (acpRecRefField != null)
									{
										num = (short)571146246;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									goto IL_1888;
								case 12:
									goto IL_16ED;
								case 13:
									num = (short)1750925315;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								IL_17CF:
								num = (short)45088769;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								IL_16B4:
								goto IL_17CF;
								IL_1888:
								num = (short)1565130760;
								num2 = (int)((global::System.IntPtr)num);
							}
							IL_16ED:
							IL_1777:
							IL_18A0:
							goto IL_A6E;
						}
						finally
						{
							num = (short)1324023810;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								switch (num2)
								{
								case 0:
									enumerator.Dispose();
									num = (short)1376911361;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 1:
									goto IL_1911;
								case 2:
									switch (0)
									{
									case 0:
										goto IL_18D7;
									}
									continue;
								}
								IL_18D7:
								if (enumerator == null)
								{
									break;
								}
								num = (short)1507852288;
								num2 = (int)((global::System.IntPtr)num);
							}
							IL_1911:;
						}
						goto Block_30;
					case 4:
					{
						num = (short)170393601;
						if (num != 0)
						{
						}
						if (featureSectionId != 10209)
						{
							num = (short)313131039;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						global::Motorola.MackinawCPS.CoreFeatures.KeypadMicAndAccessories.DataButtonInnerSection dataButtonInnerSection = self as global::Motorola.MackinawCPS.CoreFeatures.KeypadMicAndAccessories.DataButtonInnerSection;
						num3 = dataButtonInnerSection.RadErgoCfgKMConventionalKMDatatButtonFeature_A22603.Value;
						acpRecRefField = dataButtonInnerSection.RadErgoCfgKMConventionalKMDatatButtonIndex_A41423;
						acpListField = dataButtonInnerSection.RadErgoCfgKMTrunkingKMDatatButtonFeature_A22605;
						num = (short)1038942281;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 5:
						if (acpListField != null)
						{
							num = (short)1636696079;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return;
					case 6:
						goto IL_AEF;
					case 7:
						if (buttonsRecset != null)
						{
							num = (short)1267597344;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_3E6;
					case 8:
						goto IL_BFA;
					case 9:
						if (controlHeadO7Recset != null)
						{
							num = (short)1654063194;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_12C6;
					case 10:
						goto IL_3E6;
					case 11:
						num = (short)13893711;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 12:
					{
						global::Motorola.MackinawCPS.CoreFeatures.KeypadMicAndAccessories.DataButtonInnerRecset dataButtonInnerRecset2;
						enumerator = dataButtonInnerRecset2.GetEnumerator();
						num = (short)269221964;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 13:
						enumerator = o7DataButtonInnerRecset.GetEnumerator();
						num = (short)88604689;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 14:
						goto IL_1618;
					case 15:
						goto IL_1574;
					case 16:
						try
						{
							num = (short)1699020803;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								switch (num2)
								{
								case 0:
									goto IL_144F;
								case 1:
								{
									global::AcpCommonLib.IAcpFeatureNode acpFeatureNode;
									if (num3 != (acpFeatureNode[10090] as global::Motorola.MackinawCPS.CoreFeatures.Buttons.DataButtonInnerSection).BtnConventionalButtonDatatButtonFeature_A22610.Value)
									{
										num = (short)1524760578;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									break;
								}
								case 2:
								{
									global::AcpCommonLib.IAcpFeatureNode acpFeatureNode;
									task.AddTask(new global::AcpBusinessLayer.UndoRedo.ModifyDataTask<int>((acpFeatureNode[10090] as global::Motorola.MackinawCPS.CoreFeatures.Buttons.DataButtonInnerSection).BtnConventionalButtonDatatButtonFeature_A22610, num3));
									num = (short)1157431296;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 3:
									switch (0)
									{
									case 0:
										goto IL_1415;
									}
									continue;
								case 4:
									num = (short)4653062;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 5:
								{
									if (!enumerator.MoveNext())
									{
										num = (short)1266483204;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									global::AcpCommonLib.IAcpFeatureNode acpFeatureNode = enumerator.Current;
									num = (short)783220737;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 6:
									goto IL_1502;
								}
								IL_1454:
								num = (short)1313603589;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								IL_1415:
								goto IL_1454;
							}
							IL_144F:
							IL_1502:
							goto IL_E7E;
						}
						finally
						{
							num = (short)1860304897;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								switch (num2)
								{
								case 0:
									enumerator.Dispose();
									num = (short)1536622594;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 1:
									switch (0)
									{
									case 0:
										goto IL_1539;
									}
									continue;
								case 2:
									goto IL_1571;
								}
								IL_1539:
								if (enumerator == null)
								{
									break;
								}
								num = (short)1687683072;
								num2 = (int)((global::System.IntPtr)num);
							}
							IL_1571:;
						}
						goto IL_1574;
					case 17:
						goto IL_C92;
						try
						{
							for (;;)
							{
								IL_C92:
								num = (short)920059909;
								num2 = (int)((global::System.IntPtr)num);
								for (;;)
								{
									switch (num2)
									{
									case 0:
										num = (short)484966402;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									case 1:
									{
										global::AcpCommonLib.IAcpFeatureNode acpFeatureNode2;
										task.AddTask(new global::AcpBusinessLayer.UndoRedo.ModifyDataTask<int>((acpFeatureNode2[10713] as global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO7.O7DataButtonInnerSection).RadErgCtrlHeadO7DataButtonCnvFeature_A41299, num3));
										num = (short)2117009411;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									case 2:
										goto IL_E0C;
									case 3:
										goto IL_D0E;
									case 4:
									{
										if (!enumerator.MoveNext())
										{
											num = (short)1598160896;
											num2 = (int)((global::System.IntPtr)num);
											continue;
										}
										global::AcpCommonLib.IAcpFeatureNode acpFeatureNode2 = enumerator.Current;
										num = (short)1092943878;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									case 5:
										switch (0)
										{
										case 0:
											goto IL_CD5;
										}
										continue;
									case 6:
									{
										global::AcpCommonLib.IAcpFeatureNode acpFeatureNode2;
										if (num3 != (acpFeatureNode2[10713] as global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO7.O7DataButtonInnerSection).RadErgCtrlHeadO7DataButtonCnvFeature_A41299.Value)
										{
											num = (short)912055702;
											short num4 = num;
											num = (short)377150870;
											switch ((num4 == num) ? 1 : 0)
											{
											case 0:
											case 2:
												goto IL_C92;
											default:
												num = (short)648413184;
												if (num != 0)
												{
												}
												num = (short)781910017;
												num2 = (int)((global::System.IntPtr)num);
												continue;
											}
										}
										break;
									}
									}
									IL_D13:
									num = (short)1114116;
									num2 = (int)((global::System.IntPtr)num);
									continue;
									IL_CD5:
									goto IL_D13;
								}
							}
							IL_D0E:
							IL_E0C:
							goto IL_1BF9;
						}
						finally
						{
							num = (short)1779957761;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								switch (num2)
								{
								case 0:
									goto IL_E7B;
								case 1:
									switch (0)
									{
									case 0:
										goto IL_E44;
									}
									continue;
								case 2:
									enumerator.Dispose();
									num = (short)16449536;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								IL_E44:
								if (enumerator == null)
								{
									break;
								}
								num = (short)851312642;
								num2 = (int)((global::System.IntPtr)num);
							}
							IL_E7B:;
						}
						goto IL_E7E;
					case 18:
						try
						{
							num = (short)945946627;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								switch (num2)
								{
								case 0:
									goto IL_119F;
								case 1:
								{
									global::AcpCommonLib.IAcpFeatureNode acpFeatureNode3;
									if (num3 != (acpFeatureNode3[10713] as global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO7.O7DataButtonInnerSection).RadErgCtrlHeadO7DataButtonTrkFeature_A41297.Value)
									{
										num = (short)861732866;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									break;
								}
								case 2:
								{
									global::AcpCommonLib.IAcpFeatureNode acpFeatureNode3;
									task.AddTask(new global::AcpBusinessLayer.UndoRedo.ModifyDataTask<int>((acpFeatureNode3[10713] as global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO7.O7DataButtonInnerSection).RadErgCtrlHeadO7DataButtonTrkFeature_A41297, num3));
									num = (short)417333248;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 3:
									switch (0)
									{
									case 0:
										goto IL_1165;
									}
									continue;
								case 4:
									num = (short)682033158;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 5:
								{
									if (!enumerator.MoveNext())
									{
										num = (short)1780350980;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									global::AcpCommonLib.IAcpFeatureNode acpFeatureNode3 = enumerator.Current;
									num = (short)286654465;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 6:
									goto IL_1253;
								}
								IL_11A4:
								num = (short)1944453125;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								IL_1165:
								goto IL_11A4;
							}
							IL_119F:
							IL_1253:
							goto IL_1BBC;
						}
						finally
						{
							num = (short)42532865;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								switch (num2)
								{
								case 0:
									enumerator.Dispose();
									num = (short)1635713026;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 1:
									switch (0)
									{
									case 0:
										goto IL_128C;
									}
									continue;
								case 2:
									goto IL_12C3;
								}
								IL_128C:
								if (enumerator == null)
								{
									break;
								}
								num = (short)443219968;
								num2 = (int)((global::System.IntPtr)num);
							}
							IL_12C3:;
						}
						goto IL_12C6;
					case 19:
						try
						{
							num = (short)1080623107;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								switch (num2)
								{
								case 0:
								{
									global::AcpCommonLib.IAcpFeatureNode acpFeatureNode4;
									if (num3 != (acpFeatureNode4[10090] as global::Motorola.MackinawCPS.CoreFeatures.Buttons.DataButtonInnerSection).BtnTrunkingButtonDatatButtonFeature_A22608.Value)
									{
										num = (short)1833697281;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									break;
								}
								case 1:
								{
									global::AcpCommonLib.IAcpFeatureNode acpFeatureNode4;
									task.AddTask(new global::AcpBusinessLayer.UndoRedo.ModifyDataTask<int>((acpFeatureNode4[10090] as global::Motorola.MackinawCPS.CoreFeatures.Buttons.DataButtonInnerSection).BtnTrunkingButtonDatatButtonFeature_A22608, num3));
									num = (short)181141510;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 2:
								{
									if (!enumerator.MoveNext())
									{
										num = (short)2140930053;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									global::AcpCommonLib.IAcpFeatureNode acpFeatureNode4 = enumerator.Current;
									num = (short)1823277056;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 3:
									switch (0)
									{
									case 0:
										goto IL_766;
									}
									continue;
								case 4:
									goto IL_851;
								case 5:
									num = (short)611713028;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 6:
									goto IL_834;
								}
								IL_7BD:
								num = (short)1802960898;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								IL_766:
								goto IL_7BD;
							}
							IL_834:
							IL_851:
							goto IL_B44;
						}
						finally
						{
							num = (short)272433152;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								switch (num2)
								{
								case 0:
									switch (0)
									{
									case 0:
										goto IL_888;
									}
									continue;
								case 1:
									enumerator.Dispose();
									num = (short)930152450;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 2:
									goto IL_8C2;
								}
								IL_888:
								if (enumerator == null)
								{
									break;
								}
								num = (short)1304100865;
								num2 = (int)((global::System.IntPtr)num);
							}
							IL_8C2:;
						}
						goto Block_12;
					case 20:
						if (num3 == 227)
						{
							num = (short)505610312;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_224A;
					case 21:
						if (o9DataButtonInnerRecset != null)
						{
							num = (short)1050411096;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return;
					case 22:
					{
						if (featureSectionId != 10090)
						{
							num = (short)1936916561;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						global::Motorola.MackinawCPS.CoreFeatures.Buttons.DataButtonInnerSection dataButtonInnerSection2 = self as global::Motorola.MackinawCPS.CoreFeatures.Buttons.DataButtonInnerSection;
						num3 = dataButtonInnerSection2.BtnConventionalButtonDatatButtonFeature_A22610.Value;
						acpListField = dataButtonInnerSection2.BtnTrunkingButtonDatatButtonFeature_A22608;
						num = (short)1742798887;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 23:
						num = (short)729284642;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 24:
						enumerator = consolidatedActionBCOListInnerRecset.GetEnumerator();
						num = (short)1903165443;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 25:
						if (featureSectionId != 10212)
						{
							num = (short)1254359108;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_1E96;
					case 26:
					{
						global::Motorola.MackinawCPS.CoreFeatures.KeypadMicAndAccessories.DataButtonInnerRecset dataButtonInnerRecset2;
						enumerator = dataButtonInnerRecset2.GetEnumerator();
						num = (short)827850789;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 27:
						goto IL_1618;
					case 28:
						if (controlHeadO3Recset != null)
						{
							num = (short)1724842024;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_BFA;
					case 29:
					{
						global::Motorola.MackinawCPS.CoreFeatures.KeypadMicAndAccessories.KeypadMicAndAccessoriesRecset keypadMicAndAccessoriesRecset;
						if (keypadMicAndAccessoriesRecset != null)
						{
							num = (short)256180287;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_AEF;
					}
					case 30:
						if (num3 != 140)
						{
							num = (short)1544355915;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_1B33;
					case 31:
						num = (short)2010972220;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 32:
						dataButtonInnerRecset = (buttonsRecset[0][10089].EmbeddedRecset as global::Motorola.MackinawCPS.CoreFeatures.Buttons.DataButtonInnerRecset);
						num = (short)665780234;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 33:
						goto IL_224A;
					case 34:
						goto IL_6C9;
					case 35:
					{
						global::Motorola.MackinawCPS.CoreFeatures.KeypadMicAndAccessories.DataButtonInnerRecset dataButtonInnerRecset2;
						if (dataButtonInnerRecset2 != null)
						{
							num = (short)373948428;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_15B4;
					}
					case 36:
						goto IL_215C;
					case 37:
						goto IL_8C5;
					case 38:
						enumerator = dataButtonInnerRecset.GetEnumerator();
						num = (short)533069840;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 39:
						goto IL_1618;
					case 40:
						dataButtonInnerRecset3 = (controlHeadO3Recset[0][10234].EmbeddedRecset as global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO3.DataButtonInnerRecset);
						num = (short)2031812616;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 41:
						goto IL_60B;
					case 42:
						if (o9DataButtonInnerRecset != null)
						{
							num = (short)958660694;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_22E;
					case 43:
						goto IL_12C6;
					case 44:
						num = (short)1510015006;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 45:
						if (!acpListField.HiddenStatic)
						{
							num = (short)914686009;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_1B33;
					case 46:
						enumerator = o7DataButtonInnerRecset.GetEnumerator();
						num = (short)1773731858;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 47:
						if (controlHeadO9Recset != null)
						{
							num = (short)429391950;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_AB1;
					case 48:
						goto IL_1618;
					case 49:
						goto IL_1618;
					case 50:
						num = (short)1492648013;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 51:
					{
						global::Motorola.MackinawCPS.CoreFeatures.KeypadMicAndAccessories.DataButtonInnerRecset dataButtonInnerRecset2;
						if (dataButtonInnerRecset2 != null)
						{
							num = (short)331677722;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_220E;
					}
					case 52:
						if (dataButtonInnerRecset != null)
						{
							num = (short)1873608742;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_E7E;
					case 53:
						if (num3 != 227)
						{
							num = (short)1028718636;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_1B33;
					case 54:
						if (featureSectionId <= 10209)
						{
							num = (short)1543635014;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)1663959065;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 55:
						if (consolidatedActionBCOListInnerRecset != null)
						{
							num = (short)677249048;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_224A;
					case 56:
						if (o7DataButtonInnerRecset != null)
						{
							num = (short)1316749358;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_1BBC;
					case 57:
						goto IL_15AF;
					case 58:
						if (controlHeadO9Recset != null)
						{
							num = (short)212402260;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_224A;
					case 59:
					{
						if (!flag2)
						{
							num = (short)1109196800;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						global::Motorola.MackinawCPS.CoreFeatures.KeypadMicAndAccessories.KeypadMicAndAccessoriesRecset keypadMicAndAccessoriesRecset = null;
						global::Motorola.MackinawCPS.CoreFeatures.KeypadMicAndAccessories.DataButtonInnerRecset dataButtonInnerRecset2 = null;
						keypadMicAndAccessoriesRecset = (global::AcpCommonLib.FeatureManager.GetFeature(2128) as global::Motorola.MackinawCPS.CoreFeatures.KeypadMicAndAccessories.KeypadMicAndAccessoriesRecset);
						num = (short)256245789;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 60:
						goto IL_6C9;
					case 61:
						enumerator = dataButtonInnerRecset.GetEnumerator();
						num = (short)1430781971;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 62:
						enumerator = dataButtonInnerRecset3.GetEnumerator();
						num = (short)1296105543;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 63:
					{
						global::Motorola.MackinawCPS.CoreFeatures.KeypadMicAndAccessories.KeypadMicAndAccessoriesRecset keypadMicAndAccessoriesRecset;
						global::Motorola.MackinawCPS.CoreFeatures.KeypadMicAndAccessories.DataButtonInnerRecset dataButtonInnerRecset2 = keypadMicAndAccessoriesRecset[0][10228].EmbeddedRecset as global::Motorola.MackinawCPS.CoreFeatures.KeypadMicAndAccessories.DataButtonInnerRecset;
						num = (short)1738276870;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 64:
						consolidatedActionBCOListInnerRecset = (controlHeadO9Recset[0][10622].EmbeddedRecset as global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO9.ConsolidatedActionBCOListInnerRecset);
						num = (short)913047607;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 65:
						if (!flag)
						{
							num = (short)790691842;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_224A;
					case 66:
						if (controlHeadO9Recset.Count > 0)
						{
							num = (short)861077568;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_224A;
					case 67:
						try
						{
							num = (short)637075459;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								switch (num2)
								{
								case 0:
									goto IL_4E2;
								case 1:
								{
									global::AcpCommonLib.IAcpFeatureNode acpFeatureNode5;
									if (num3 != (acpFeatureNode5[10608] as global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO9.O9DataButtonInnerSection).RadErgCtrlHeadO9DataButtonTrkFeature_A36526.Value)
									{
										num = (short)1109262338;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									break;
								}
								case 2:
								{
									global::AcpCommonLib.IAcpFeatureNode acpFeatureNode5;
									task.AddTask(new global::AcpBusinessLayer.UndoRedo.ModifyDataTask<int>((acpFeatureNode5[10608] as global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO9.O9DataButtonInnerSection).RadErgCtrlHeadO9DataButtonTrkFeature_A36526, num3));
									num = (short)1114636288;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 3:
									switch (0)
									{
									case 0:
										goto IL_4A5;
									}
									continue;
								case 4:
									goto IL_59A;
								case 5:
								{
									if (!enumerator.MoveNext())
									{
										num = (short)1607139334;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									global::AcpCommonLib.IAcpFeatureNode acpFeatureNode5 = enumerator.Current;
									num = (short)662568961;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 6:
									num = (short)874184708;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								IL_543:
								num = (short)1040449541;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								IL_4A5:
								goto IL_543;
							}
							IL_4E2:
							IL_59A:
							return;
						}
						finally
						{
							num = (short)1546518528;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								switch (num2)
								{
								case 0:
									switch (0)
									{
									case 0:
										goto IL_5D1;
									}
									continue;
								case 1:
									enumerator.Dispose();
									num = (short)888340482;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 2:
									goto IL_608;
								}
								IL_5D1:
								if (enumerator == null)
								{
									break;
								}
								num = (short)421855233;
								num2 = (int)((global::System.IntPtr)num);
							}
							IL_608:;
						}
						goto IL_60B;
					case 68:
						num = (short)1168310341;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 69:
						if (featureSectionId != 10608)
						{
							num = (short)185532466;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_107F;
					case 70:
						num = (short)865468438;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 71:
						try
						{
							num = (short)1709506565;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								switch (num2)
								{
								case 0:
									goto IL_FB3;
								case 1:
									num = (short)1879638018;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 2:
									goto IL_100E;
								case 3:
								{
									global::AcpCommonLib.IAcpFeatureNode acpFeatureNode6;
									if (num3 != (acpFeatureNode6[10212] as global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO3.DataButtonInnerSection).CntrlHeadO3TrunkingO3DatatButtonFeature_A22597.Value)
									{
										num = (short)1320878084;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									break;
								}
								case 4:
								{
									global::AcpCommonLib.IAcpFeatureNode acpFeatureNode6;
									task.AddTask(new global::AcpBusinessLayer.UndoRedo.ModifyDataTask<int>((acpFeatureNode6[10212] as global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO3.DataButtonInnerSection).CntrlHeadO3TrunkingO3DatatButtonFeature_A22597, num3));
									num = (short)2104885248;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 5:
									switch (0)
									{
									case 0:
										goto IL_F20;
									}
									continue;
								case 6:
								{
									if (!enumerator.MoveNext())
									{
										num = (short)2006843393;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									global::AcpCommonLib.IAcpFeatureNode acpFeatureNode6 = enumerator.Current;
									num = (short)1422721027;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								}
								IL_FB8:
								num = (short)1274413062;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								IL_F20:
								goto IL_FB8;
							}
							IL_FB3:
							IL_100E:
							goto IL_34F;
						}
						finally
						{
							num = (short)394854401;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								switch (num2)
								{
								case 0:
									enumerator.Dispose();
									num = (short)1450639362;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 1:
									switch (0)
									{
									case 0:
										goto IL_1045;
									}
									continue;
								case 2:
									goto IL_107C;
								}
								IL_1045:
								if (enumerator == null)
								{
									break;
								}
								num = (short)779354112;
								num2 = (int)((global::System.IntPtr)num);
							}
							IL_107C:;
						}
						goto IL_107F;
					case 72:
						num = (short)479199297;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 73:
						goto IL_1618;
					case 74:
						try
						{
							num = (short)1001259013;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								switch (num2)
								{
								case 0:
									goto IL_20EA;
								case 1:
									goto IL_208C;
								case 2:
									num = (short)756940800;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 3:
								{
									global::AcpCommonLib.IAcpFeatureNode acpFeatureNode7;
									task.AddTask(new global::AcpBusinessLayer.UndoRedo.ModifyDataTask<int>((acpFeatureNode7[10608] as global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO9.O9DataButtonInnerSection).RadErgCtrlHeadO9DataButtonCnvFeature_A36528, num3));
									num = (short)343277569;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 4:
								{
									if (!enumerator.MoveNext())
									{
										num = (short)305070082;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									global::AcpCommonLib.IAcpFeatureNode acpFeatureNode7 = enumerator.Current;
									num = (short)40370182;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 5:
									switch (0)
									{
									case 0:
										goto IL_1FFA;
									}
									continue;
								case 6:
								{
									global::AcpCommonLib.IAcpFeatureNode acpFeatureNode7;
									if (num3 != (acpFeatureNode7[10608] as global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO9.O9DataButtonInnerSection).RadErgCtrlHeadO9DataButtonCnvFeature_A36528.Value)
									{
										num = (short)2116222979;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									break;
								}
								}
								IL_2091:
								num = (short)1593311236;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								IL_1FFA:
								goto IL_2091;
							}
							IL_208C:
							IL_20EA:
							goto IL_22E;
						}
						finally
						{
							num = (short)1810628610;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								switch (num2)
								{
								case 0:
									goto IL_2159;
								case 1:
									enumerator.Dispose();
									num = (short)1031012352;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 2:
									switch (0)
									{
									case 0:
										goto IL_2121;
									}
									continue;
								}
								IL_2121:
								if (enumerator == null)
								{
									break;
								}
								num = (short)1365901313;
								num2 = (int)((global::System.IntPtr)num);
							}
							IL_2159:;
						}
						goto IL_215C;
					case 75:
						num = (short)780009561;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 76:
						try
						{
							num = (short)1654259717;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								switch (num2)
								{
								case 0:
									goto IL_1E24;
								case 1:
									num = (short)1175650304;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 2:
								{
									global::AcpCommonLib.IAcpFeatureNode acpFeatureNode8;
									task.AddTask(new global::AcpBusinessLayer.UndoRedo.ModifyDataTask<int>((acpFeatureNode8[10209] as global::Motorola.MackinawCPS.CoreFeatures.KeypadMicAndAccessories.DataButtonInnerSection).RadErgoCfgKMTrunkingKMDatatButtonFeature_A22605, num3));
									num = (short)1197801478;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 3:
								{
									if (!enumerator.MoveNext())
									{
										num = (short)961150977;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									global::AcpCommonLib.IAcpFeatureNode acpFeatureNode8 = enumerator.Current;
									num = (short)1642921988;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 4:
								{
									global::AcpCommonLib.IAcpFeatureNode acpFeatureNode8;
									if (num3 != (acpFeatureNode8[10209] as global::Motorola.MackinawCPS.CoreFeatures.KeypadMicAndAccessories.DataButtonInnerSection).RadErgoCfgKMTrunkingKMDatatButtonFeature_A22605.Value)
									{
										num = (short)2009530370;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									break;
								}
								case 5:
									switch (0)
									{
									case 0:
										goto IL_1D36;
									}
									continue;
								case 6:
									goto IL_1D6F;
								}
								IL_1D74:
								num = (short)1270415363;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								IL_1D36:
								goto IL_1D74;
							}
							IL_1D6F:
							IL_1E24:
							goto IL_15B4;
						}
						finally
						{
							num = (short)1184104450;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								switch (num2)
								{
								case 0:
									enumerator.Dispose();
									num = (short)1069613057;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 1:
									goto IL_1E93;
								case 2:
									switch (0)
									{
									case 0:
										goto IL_1E5B;
									}
									continue;
								}
								IL_1E5B:
								if (enumerator == null)
								{
									break;
								}
								num = (short)1746993152;
								num2 = (int)((global::System.IntPtr)num);
							}
							IL_1E93:;
						}
						goto IL_1E96;
					case 77:
					{
						if (featureSectionId != 10713)
						{
							num = (short)1855062039;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO7.O7DataButtonInnerSection o7DataButtonInnerSection = self as global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO7.O7DataButtonInnerSection;
						num3 = o7DataButtonInnerSection.RadErgCtrlHeadO7DataButtonCnvFeature_A41299.Value;
						acpRecRefField = o7DataButtonInnerSection.CHO7DataButtonConvIndex_A41417;
						acpListField = o7DataButtonInnerSection.RadErgCtrlHeadO7DataButtonTrkFeature_A41297;
						num = (short)697434126;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 78:
						o9DataButtonInnerRecset = (controlHeadO9Recset[0][10611].EmbeddedRecset as global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO9.O9DataButtonInnerRecset);
						num = (short)1703739475;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 79:
					{
						num = (short)1333657600;
						short num5 = num;
						if (radioWide.DualRadio.RadWideDualRadioSelection_A42236 == 0)
						{
							num = (short)420741156;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_1B33;
					}
					case 80:
						if (dataButtonInnerRecset3 != null)
						{
							num = (short)572653609;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_1C36;
					case 81:
						num = (short)1838284804;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 82:
						if (dataButtonInnerRecset3 != null)
						{
							num = (short)105709630;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_34F;
					case 83:
						goto IL_AB1;
					case 84:
						goto IL_1AB4;
					case 85:
						goto IL_1914;
					case 86:
						enumerator = o9DataButtonInnerRecset.GetEnumerator();
						num = (short)483065930;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 87:
						if (o7DataButtonInnerRecset != null)
						{
							num = (short)1121779725;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_1BF9;
					case 88:
						enumerator = o9DataButtonInnerRecset.GetEnumerator();
						num = (short)148897859;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 89:
						if (num3 == 228)
						{
							num = (short)418775051;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_215C;
					case 90:
						o7DataButtonInnerRecset = (controlHeadO7Recset[0][10717].EmbeddedRecset as global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO7.O7DataButtonInnerRecset);
						num = (short)1104019499;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_19A;
					IL_22E:
					consolidatedActionBCOListInnerRecset = null;
					flag = false;
					num = (short)1056833594;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_34F:
					num = (short)1086128184;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_3E6:
					controlHeadO3Recset = null;
					dataButtonInnerRecset3 = null;
					controlHeadO3Recset = (global::AcpCommonLib.FeatureManager.GetFeature(2127) as global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO3.ControlHeadO3Recset);
					num = (short)1333395484;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_60B:
					enumerator = dataButtonInnerRecset3.GetEnumerator();
					num = (short)501940309;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_6C9:
					flag2 = false;
					num = (short)1649541168;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_A6E:
					num = (short)532414484;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					Block_12:
					try
					{
						IL_8C5:
						num = (short)248709123;
						num2 = (int)((global::System.IntPtr)num);
						for (;;)
						{
							switch (num2)
							{
							case 0:
								goto IL_945;
							case 1:
							{
								global::AcpCommonLib.IAcpFeatureNode acpFeatureNode9;
								if (num3 != (acpFeatureNode9[10209] as global::Motorola.MackinawCPS.CoreFeatures.KeypadMicAndAccessories.DataButtonInnerSection).RadErgoCfgKMConventionalKMDatatButtonFeature_A22603.Value)
								{
									num = (short)1447952386;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								break;
							}
							case 2:
							{
								global::AcpCommonLib.IAcpFeatureNode acpFeatureNode9;
								task.AddTask(new global::AcpBusinessLayer.UndoRedo.ModifyDataTask<int>((acpFeatureNode9[10209] as global::Motorola.MackinawCPS.CoreFeatures.KeypadMicAndAccessories.DataButtonInnerSection).RadErgoCfgKMConventionalKMDatatButtonFeature_A22603, num3));
								num = (short)1132527616;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							case 3:
								switch (0)
								{
								case 0:
									goto IL_907;
								}
								continue;
							case 4:
								goto IL_9FC;
							case 5:
							{
								if (!enumerator.MoveNext())
								{
									num = (short)1020461062;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								global::AcpCommonLib.IAcpFeatureNode acpFeatureNode9 = enumerator.Current;
								num = (short)1156775937;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							case 6:
								num = (short)963837956;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							IL_9A8:
							num = (short)2002911237;
							num2 = (int)((global::System.IntPtr)num);
							continue;
							IL_907:
							goto IL_9A8;
						}
						IL_945:
						IL_9FC:
						goto IL_220E;
					}
					finally
					{
						num = (short)1896153088;
						num2 = (int)((global::System.IntPtr)num);
						for (;;)
						{
							switch (num2)
							{
							case 0:
								switch (0)
								{
								case 0:
									goto IL_A33;
								}
								continue;
							case 1:
								enumerator.Dispose();
								num = (short)129368066;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							case 2:
								goto IL_A6B;
							}
							IL_A33:
							if (enumerator == null)
							{
								break;
							}
							num = (short)1506148353;
							num2 = (int)((global::System.IntPtr)num);
						}
						IL_A6B:;
					}
					goto IL_A6E;
					IL_AB1:
					num = (short)948961332;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_AEF:
					buttonsRecset = null;
					dataButtonInnerRecset = null;
					buttonsRecset = (global::AcpCommonLib.FeatureManager.GetFeature(2042) as global::Motorola.MackinawCPS.CoreFeatures.Buttons.ButtonsRecset);
					num = (short)1258815495;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_B44:
					num = (short)1905000483;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_BFA:
					controlHeadO7Recset = null;
					o7DataButtonInnerRecset = null;
					controlHeadO7Recset = (global::AcpCommonLib.FeatureManager.GetFeature(4114) as global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO7.ControlHeadO7Recset);
					num = (short)614400009;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_E7E:
					num = (short)818806835;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_107F:
					global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO9.O9DataButtonInnerSection o9DataButtonInnerSection = self as global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO9.O9DataButtonInnerSection;
					num3 = o9DataButtonInnerSection.RadErgCtrlHeadO9DataButtonCnvFeature_A36528.Value;
					acpRecRefField = o9DataButtonInnerSection.CHO9DataButtonConvIndex_A41414;
					acpListField = o9DataButtonInnerSection.RadErgCtrlHeadO9DataButtonTrkFeature_A36526;
					num = (short)137625649;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_12C6:
					controlHeadO9Recset = null;
					o9DataButtonInnerRecset = null;
					controlHeadO9Recset = (global::AcpCommonLib.FeatureManager.GetFeature(4003) as global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO9.ControlHeadO9Recset);
					num = (short)1397751855;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_1574:
					num = (short)753467437;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_15B4:
					num = (short)1522204754;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_1618:
					num = (short)1938751547;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_1AB4:
					num = (short)1975779394;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					Block_30:
					try
					{
						IL_1914:
						num = (short)1740570629;
						num2 = (int)((global::System.IntPtr)num);
						for (;;)
						{
							switch (num2)
							{
							case 0:
								goto IL_1A41;
							case 1:
							{
								if (!enumerator.MoveNext())
								{
									num = (short)1677131780;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								global::AcpCommonLib.IAcpFeatureNode acpFeatureNode10 = enumerator.Current;
								num = (short)1660878854;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							case 2:
								goto IL_1A23;
							case 3:
							{
								global::AcpCommonLib.IAcpFeatureNode acpFeatureNode10;
								task.AddTask(new global::AcpBusinessLayer.UndoRedo.ModifyDataTask<int>((acpFeatureNode10[10212] as global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO3.DataButtonInnerSection).CntrlHeadO3ConventionalO3DatatButtonFeature_A22595, num3));
								num = (short)1029177346;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							case 4:
								num = (short)2115239936;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							case 5:
								switch (0)
								{
								case 0:
									goto IL_1956;
								}
								continue;
							case 6:
							{
								global::AcpCommonLib.IAcpFeatureNode acpFeatureNode10;
								if (num3 != (acpFeatureNode10[10212] as global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO3.DataButtonInnerSection).CntrlHeadO3ConventionalO3DatatButtonFeature_A22595.Value)
								{
									num = (short)913244163;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								break;
							}
							}
							IL_19AD:
							num = (short)1274544129;
							num2 = (int)((global::System.IntPtr)num);
							continue;
							IL_1956:
							goto IL_19AD;
						}
						IL_1A23:
						IL_1A41:
						goto IL_1C36;
					}
					finally
					{
						num = (short)1962278914;
						num2 = (int)((global::System.IntPtr)num);
						for (;;)
						{
							switch (num2)
							{
							case 0:
								enumerator.Dispose();
								num = (short)56492033;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							case 1:
								goto IL_1AB1;
							case 2:
								switch (0)
								{
								case 0:
									goto IL_1A78;
								}
								continue;
							}
							IL_1A78:
							if (enumerator == null)
							{
								break;
							}
							num = (short)1033175040;
							num2 = (int)((global::System.IntPtr)num);
						}
						IL_1AB1:;
					}
					goto IL_1AB4;
					IL_1B33:
					num = (short)595787777;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_1BBC:
					num = (short)367656981;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_1BF9:
					num = (short)1371209770;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_1C36:
					num = (short)530907223;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_1E96:
					global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO3.DataButtonInnerSection dataButtonInnerSection3 = self as global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO3.DataButtonInnerSection;
					num3 = dataButtonInnerSection3.CntrlHeadO3ConventionalO3DatatButtonFeature_A22595.Value;
					acpRecRefField = dataButtonInnerSection3.CHO3DataButtonConvIndex_A41419;
					acpListField = dataButtonInnerSection3.CntrlHeadO3TrunkingO3DatatButtonFeature_A22597;
					num = (short)1038155803;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_215C:
					num = (short)696320005;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_220E:
					num = (short)1039335504;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_224A:
					radioWide = ((global::AcpCommonLib.FeatureManager.GetFeature(2045) as global::Motorola.MackinawCPS.CoreFeatures.RadioWide.RadioWideRecset)[0] as global::Motorola.MackinawCPS.CoreFeatures.RadioWide.RadioWide);
					num = (short)548667445;
					num2 = (int)((global::System.IntPtr)num);
				}
				return;
				IL_15AF:
				return;
				IL_19A:
				num3 = 0;
				flag2 = true;
				acpRecRefField = null;
				acpListField = null;
				featureSectionId = self.FeatureSectionId;
				num = (short)1384382518;
				num2 = (int)((global::System.IntPtr)num);
				goto IL_27;
			}
			}
		}

		// Token: 0x06007B3B RID: 31547 RVA: 0x007074E8 File Offset: 0x007056E8
		public static void ConSyncTrkDataBtnFeature(global::AcpCommonLib.IAcpFeatureSection self, global::AcpCommonLib.UndoRedo.ContainerTask task)
		{
			short num = (short)1766981632;
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
				int featureSectionId;
				bool flag;
				global::AcpBusinessLayer.AcpRecRefField acpRecRefField;
				for (;;)
				{
					IL_27:
					global::System.Collections.Generic.IEnumerator<global::AcpBusinessLayer.FeatureNode> enumerator;
					global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO7.O7DataButtonInnerRecset o7DataButtonInnerRecset;
					global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO9.O9DataButtonInnerRecset o9DataButtonInnerRecset;
					global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO7.ControlHeadO7Recset controlHeadO7Recset;
					global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO3.ControlHeadO3Recset controlHeadO3Recset;
					global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO3.DataButtonInnerRecset dataButtonInnerRecset;
					global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO9.ControlHeadO9Recset controlHeadO9Recset;
					global::Motorola.MackinawCPS.CoreFeatures.KeypadMicAndAccessories.DataButtonInnerRecset dataButtonInnerRecset2;
					bool flag2;
					global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO9.ConsolidatedActionBCOListInnerRecset consolidatedActionBCOListInnerRecset;
					global::Motorola.MackinawCPS.CoreFeatures.Buttons.DataButtonInnerRecset dataButtonInnerRecset3;
					global::Motorola.MackinawCPS.CoreFeatures.RadioWide.RadioWide radioWide;
					global::Motorola.MackinawCPS.CoreFeatures.Buttons.ButtonsRecset buttonsRecset;
					switch (num2)
					{
					case 0:
						try
						{
							num = (short)515702786;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								switch (num2)
								{
								case 0:
									goto IL_1DC2;
								case 1:
								{
									global::AcpCommonLib.IAcpFeatureNode acpFeatureNode;
									if (num3 != (acpFeatureNode[10608] as global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO9.O9DataButtonInnerSection).RadErgCtrlHeadO9DataButtonTrkFeature_A36526.Value)
									{
										num = (short)1767964676;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									break;
								}
								case 2:
									switch (0)
									{
									case 0:
										goto IL_1CF6;
									}
									continue;
								case 3:
								{
									if (!enumerator.MoveNext())
									{
										num = (short)182255621;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									global::AcpCommonLib.IAcpFeatureNode acpFeatureNode = enumerator.Current;
									num = (short)1464991745;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 4:
								{
									global::AcpCommonLib.IAcpFeatureNode acpFeatureNode;
									task.AddTask(new global::AcpBusinessLayer.UndoRedo.ModifyDataTask<int>((acpFeatureNode[10608] as global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO9.O9DataButtonInnerSection).RadErgCtrlHeadO9DataButtonTrkFeature_A36526, num3));
									num = (short)1236271104;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 5:
									num = (short)669515782;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 6:
									goto IL_1DDF;
								}
								IL_1CF8:
								num = (short)465108995;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								IL_1CF6:
								goto IL_1CF8;
							}
							IL_1DC2:
							IL_1DDF:
							goto IL_1878;
						}
						finally
						{
							num = (short)2034892801;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								switch (num2)
								{
								case 0:
									enumerator.Dispose();
									num = (short)2000551938;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 1:
									switch (0)
									{
									case 0:
										goto IL_1E17;
									}
									continue;
								case 2:
									goto IL_1E4F;
								}
								IL_1E17:
								if (enumerator == null)
								{
									break;
								}
								num = (short)1622278144;
								num2 = (int)((global::System.IntPtr)num);
							}
							IL_1E4F:;
						}
						goto IL_1E52;
					case 1:
						if (featureSectionId != 10212)
						{
							num = (short)874577958;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_1E52;
					case 2:
						enumerator = o7DataButtonInnerRecset.GetEnumerator();
						num = (short)1772552237;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 3:
						goto IL_836;
					case 4:
						enumerator = o9DataButtonInnerRecset.GetEnumerator();
						num = (short)1235157015;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 5:
						o7DataButtonInnerRecset = (controlHeadO7Recset[0][10717].EmbeddedRecset as global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO7.O7DataButtonInnerRecset);
						num = (short)229179438;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 6:
						try
						{
							num = (short)833880066;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								switch (num2)
								{
								case 0:
									goto IL_206A;
								case 1:
								{
									global::AcpCommonLib.IAcpFeatureNode acpFeatureNode2;
									if (num3 != (acpFeatureNode2[10090] as global::Motorola.MackinawCPS.CoreFeatures.Buttons.DataButtonInnerSection).BtnTrunkingButtonDatatButtonFeature_A22608.Value)
									{
										num = (short)340525060;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									break;
								}
								case 2:
									switch (0)
									{
									case 0:
										goto IL_1F6C;
									}
									continue;
								case 3:
								{
									if (!enumerator.MoveNext())
									{
										num = (short)1782710277;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									global::AcpCommonLib.IAcpFeatureNode acpFeatureNode2 = enumerator.Current;
									num = (short)1331560449;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 4:
								{
									global::AcpCommonLib.IAcpFeatureNode acpFeatureNode2;
									task.AddTask(new global::AcpBusinessLayer.UndoRedo.ModifyDataTask<int>((acpFeatureNode2[10090] as global::Motorola.MackinawCPS.CoreFeatures.Buttons.DataButtonInnerSection).BtnTrunkingButtonDatatButtonFeature_A22608, num3));
									num = (short)1009319936;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 5:
									num = (short)1696071686;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 6:
									goto IL_2088;
								}
								IL_1F6E:
								num = (short)1636827137;
								if (num != 0)
								{
								}
								num = (short)733872131;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								IL_1F6C:
								goto IL_1F6E;
							}
							IL_206A:
							IL_2088:
							goto IL_218B;
						}
						finally
						{
							num = (short)1269432321;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								switch (num2)
								{
								case 0:
									enumerator.Dispose();
									num = (short)264634370;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 1:
									switch (0)
									{
									case 0:
										goto IL_20C1;
									}
									continue;
								case 2:
									goto IL_20FA;
								}
								IL_20C1:
								if (enumerator == null)
								{
									break;
								}
								num = (short)313851904;
								num2 = (int)((global::System.IntPtr)num);
							}
							IL_20FA:;
						}
						goto IL_20FD;
					case 7:
						dataButtonInnerRecset = (controlHeadO3Recset[0][10234].EmbeddedRecset as global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO3.DataButtonInnerRecset);
						num = (short)242483254;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 8:
						if (num3 == 228)
						{
							num = (short)1698037842;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return;
					case 9:
						goto IL_11C7;
					case 10:
						if (controlHeadO9Recset != null)
						{
							num = (short)1601175588;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_21CA;
					case 11:
					{
						if (!flag)
						{
							num = (short)636813376;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						global::Motorola.MackinawCPS.CoreFeatures.KeypadMicAndAccessories.KeypadMicAndAccessoriesRecset keypadMicAndAccessoriesRecset = null;
						dataButtonInnerRecset2 = null;
						keypadMicAndAccessoriesRecset = (global::AcpCommonLib.FeatureManager.GetFeature(2128) as global::Motorola.MackinawCPS.CoreFeatures.KeypadMicAndAccessories.KeypadMicAndAccessoriesRecset);
						num = (short)316604435;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 12:
						num = (short)2059075659;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 13:
						if (!flag2)
						{
							num = (short)1214382122;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_21CA;
					case 14:
						num = (short)1808334861;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 15:
						goto IL_1674;
					case 16:
						if (o7DataButtonInnerRecset != null)
						{
							num = (short)314703874;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_D45;
					case 17:
						goto IL_1674;
					case 18:
						goto IL_15D4;
					case 19:
					{
						global::Motorola.MackinawCPS.CoreFeatures.KeypadMicAndAccessories.KeypadMicAndAccessoriesRecset keypadMicAndAccessoriesRecset;
						if (keypadMicAndAccessoriesRecset != null)
						{
							num = (short)899285041;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_A42;
					}
					case 20:
						goto IL_193D;
					case 21:
						enumerator = dataButtonInnerRecset.GetEnumerator();
						num = (short)1491402823;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 22:
						if (o7DataButtonInnerRecset != null)
						{
							num = (short)1404108881;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_1BC2;
					case 23:
						try
						{
							num = (short)650903556;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								switch (num2)
								{
								case 0:
								{
									global::AcpCommonLib.IAcpFeatureNode acpFeatureNode3;
									if (num3 != (acpFeatureNode3[10608] as global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO9.O9DataButtonInnerSection).RadErgCtrlHeadO9DataButtonCnvFeature_A36528.Value)
									{
										num = (short)684982275;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									break;
								}
								case 1:
									num = (short)1176502274;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 2:
									goto IL_55A;
								case 3:
								{
									global::AcpCommonLib.IAcpFeatureNode acpFeatureNode3;
									task.AddTask(new global::AcpBusinessLayer.UndoRedo.ModifyDataTask<int>((acpFeatureNode3[10608] as global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO9.O9DataButtonInnerSection).RadErgCtrlHeadO9DataButtonCnvFeature_A36528, num3));
									num = (short)856752133;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 4:
									switch (0)
									{
									case 0:
										goto IL_461;
									}
									continue;
								case 5:
									goto IL_49E;
								case 6:
								{
									if (!enumerator.MoveNext())
									{
										num = (short)815792129;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									global::AcpCommonLib.IAcpFeatureNode acpFeatureNode3 = enumerator.Current;
									num = (short)1281359872;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								}
								IL_503:
								num = (short)66584582;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								IL_461:
								goto IL_503;
							}
							IL_49E:
							IL_55A:
							return;
						}
						finally
						{
							num = (short)1738342401;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								switch (num2)
								{
								case 0:
									enumerator.Dispose();
									num = (short)13828098;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 1:
									switch (0)
									{
									case 0:
										goto IL_592;
									}
									continue;
								case 2:
									goto IL_5CA;
								}
								IL_592:
								if (enumerator == null)
								{
									break;
								}
								num = (short)214630400;
								num2 = (int)((global::System.IntPtr)num);
							}
							IL_5CA:;
						}
						goto IL_5CD;
					case 24:
						consolidatedActionBCOListInnerRecset = (controlHeadO9Recset[0][10622].EmbeddedRecset as global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO9.ConsolidatedActionBCOListInnerRecset);
						num = (short)761659419;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 25:
						goto IL_1674;
					case 26:
						enumerator = dataButtonInnerRecset3.GetEnumerator();
						num = (short)247070775;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 27:
						if (consolidatedActionBCOListInnerRecset != null)
						{
							num = (short)861732921;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_21CA;
					case 28:
						goto IL_1674;
					case 29:
						if (o9DataButtonInnerRecset != null)
						{
							num = (short)720830507;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_1878;
					case 30:
						num = (short)2132213812;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 31:
						if (num3 != 227)
						{
							num = (short)1147600908;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_DC8;
					case 32:
						num = (short)1595146287;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 33:
						if (num3 == 227)
						{
							num = (short)896008206;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_21CA;
					case 34:
						if (radioWide.DualRadio.RadWideDualRadioSelection_A42236 == 0)
						{
							num = (short)572915732;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_DC8;
					case 35:
						if (controlHeadO3Recset != null)
						{
							num = (short)1118502919;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_CB7;
					case 36:
						num = (short)292487205;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 37:
						if (controlHeadO9Recset.Count > 0)
						{
							num = (short)1742733336;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_21CA;
					case 38:
						num = (short)802684990;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 39:
						if (buttonsRecset != null)
						{
							num = (short)1932984320;
							short num4 = num;
							num = (short)1740177417;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_3A2;
					case 40:
						goto IL_635;
					case 41:
						o9DataButtonInnerRecset = (controlHeadO9Recset[0][10611].EmbeddedRecset as global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO9.O9DataButtonInnerRecset);
						num = (short)1521352782;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 42:
					{
						task.AddTask(new global::AcpBusinessLayer.UndoRedo.AddRecordTask(consolidatedActionBCOListInnerRecset.CreateDefaultRecord()));
						int index = consolidatedActionBCOListInnerRecset.Count - 1;
						global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO9.ConsolidatedActionBCOListInner consolidatedActionBCOListInner = consolidatedActionBCOListInnerRecset[index] as global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO9.ConsolidatedActionBCOListInner;
						task.AddTask(new global::AcpBusinessLayer.UndoRedo.ModifyDataTask<int>(consolidatedActionBCOListInner.ConsolidatedActionBCOListInnerSection.RadErgoControlO9ACBCOListBco_A36666, 134));
						task.AddTask(new global::AcpBusinessLayer.UndoRedo.ModifyRecRefDataTask(consolidatedActionBCOListInner.ConsolidatedActionBCOListInnerSection.RadErgoControlO9ACBCOListIndex_A36668, acpRecRefField.UIValue));
						num = (short)1089732661;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 43:
						goto IL_20FD;
					case 44:
						if (controlHeadO9Recset != null)
						{
							num = (short)1848311849;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_A05;
					case 45:
						try
						{
							num = (short)224329734;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								switch (num2)
								{
								case 0:
									goto IL_1B11;
								case 1:
								{
									global::AcpCommonLib.IAcpFeatureNode acpFeatureNode4;
									if (num3 != (acpFeatureNode4[10713] as global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO7.O7DataButtonInnerSection).RadErgCtrlHeadO7DataButtonTrkFeature_A41297.Value)
									{
										num = (short)1283653634;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									break;
								}
								case 2:
								{
									global::AcpCommonLib.IAcpFeatureNode acpFeatureNode4;
									task.AddTask(new global::AcpBusinessLayer.UndoRedo.ModifyDataTask<int>((acpFeatureNode4[10713] as global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO7.O7DataButtonInnerSection).RadErgCtrlHeadO7DataButtonTrkFeature_A41297, num3));
									num = (short)1992097796;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 3:
								{
									if (!enumerator.MoveNext())
									{
										num = (short)1645608965;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									global::AcpCommonLib.IAcpFeatureNode acpFeatureNode4 = enumerator.Current;
									num = (short)1144193025;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 4:
									goto IL_1A59;
								case 5:
									num = (short)12976128;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 6:
									switch (0)
									{
									case 0:
										goto IL_1A1D;
									}
									continue;
								}
								IL_1ABD:
								num = (short)1750859779;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								IL_1A1D:
								goto IL_1ABD;
							}
							IL_1A59:
							IL_1B11:
							goto IL_D45;
						}
						finally
						{
							num = (short)1403453441;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								switch (num2)
								{
								case 0:
									enumerator.Dispose();
									num = (short)689700866;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 1:
									switch (0)
									{
									case 0:
										goto IL_1B48;
									}
									continue;
								case 2:
									goto IL_1B80;
								}
								IL_1B48:
								if (enumerator == null)
								{
									break;
								}
								num = (short)1632894976;
								num2 = (int)((global::System.IntPtr)num);
							}
							IL_1B80:;
						}
						goto IL_1B83;
					case 46:
						goto IL_C62;
					case 47:
					{
						if (featureSectionId != 10713)
						{
							num = (short)1060569118;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO7.O7DataButtonInnerSection o7DataButtonInnerSection = self as global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO7.O7DataButtonInnerSection;
						num3 = o7DataButtonInnerSection.RadErgCtrlHeadO7DataButtonTrkFeature_A41297.Value;
						acpRecRefField = o7DataButtonInnerSection.CHO7DataButtonTrkIndex_A41418;
						num = (short)2007891983;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 48:
						try
						{
							num = (short)555352070;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								switch (num2)
								{
								case 0:
									goto IL_1156;
								case 1:
								{
									if (!enumerator.MoveNext())
									{
										num = (short)511508482;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									global::AcpCommonLib.IAcpFeatureNode acpFeatureNode5 = enumerator.Current;
									num = (short)1405157379;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 2:
									num = (short)2015035392;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 3:
								{
									global::AcpCommonLib.IAcpFeatureNode acpFeatureNode5;
									if (num3 != (acpFeatureNode5[10713] as global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO7.O7DataButtonInnerSection).RadErgCtrlHeadO7DataButtonCnvFeature_A41299.Value)
									{
										num = (short)1317994501;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									break;
								}
								case 4:
									goto IL_10A0;
								case 5:
								{
									global::AcpCommonLib.IAcpFeatureNode acpFeatureNode5;
									task.AddTask(new global::AcpBusinessLayer.UndoRedo.ModifyDataTask<int>((acpFeatureNode5[10713] as global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO7.O7DataButtonInnerSection).RadErgCtrlHeadO7DataButtonCnvFeature_A41299, num3));
									num = (short)1898315780;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 6:
									switch (0)
									{
									case 0:
										goto IL_1067;
									}
									continue;
								}
								IL_10A5:
								num = (short)890830849;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								IL_1067:
								goto IL_10A5;
							}
							IL_10A0:
							IL_1156:
							goto IL_1BC2;
						}
						finally
						{
							num = (short)241500162;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								switch (num2)
								{
								case 0:
									goto IL_11C4;
								case 1:
									enumerator.Dispose();
									num = (short)2047082496;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 2:
									switch (0)
									{
									case 0:
										goto IL_118D;
									}
									continue;
								}
								IL_118D:
								if (enumerator == null)
								{
									break;
								}
								num = (short)308019201;
								num2 = (int)((global::System.IntPtr)num);
							}
							IL_11C4:;
						}
						goto IL_11C7;
					case 49:
					{
						global::Motorola.MackinawCPS.CoreFeatures.KeypadMicAndAccessories.KeypadMicAndAccessoriesRecset keypadMicAndAccessoriesRecset;
						dataButtonInnerRecset2 = (keypadMicAndAccessoriesRecset[0][10228].EmbeddedRecset as global::Motorola.MackinawCPS.CoreFeatures.KeypadMicAndAccessories.DataButtonInnerRecset);
						num = (short)839450703;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 50:
						if (dataButtonInnerRecset2 != null)
						{
							num = (short)881852482;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_15FB;
					case 51:
						if (featureSectionId <= 10209)
						{
							num = (short)754974779;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)1703936001;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 52:
						goto IL_635;
					case 53:
						goto IL_21CA;
					case 54:
						goto IL_CB7;
					case 55:
						try
						{
							num = (short)1549139972;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								switch (num2)
								{
								case 0:
								{
									global::AcpCommonLib.IAcpFeatureNode acpFeatureNode6;
									task.AddTask(new global::AcpBusinessLayer.UndoRedo.ModifyDataTask<int>((acpFeatureNode6[10090] as global::Motorola.MackinawCPS.CoreFeatures.Buttons.DataButtonInnerSection).BtnConventionalButtonDatatButtonFeature_A22610, num3));
									num = (short)1811873795;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 1:
									num = (short)2047475714;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 2:
									goto IL_7C3;
								case 3:
									goto IL_767;
								case 4:
									switch (0)
									{
									case 0:
										goto IL_6D2;
									}
									continue;
								case 5:
								{
									global::AcpCommonLib.IAcpFeatureNode acpFeatureNode6;
									if (num3 != (acpFeatureNode6[10090] as global::Motorola.MackinawCPS.CoreFeatures.Buttons.DataButtonInnerSection).BtnConventionalButtonDatatButtonFeature_A22610.Value)
									{
										num = (short)407502848;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									break;
								}
								case 6:
								{
									if (!enumerator.MoveNext())
									{
										num = (short)1828913153;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									global::AcpCommonLib.IAcpFeatureNode acpFeatureNode6 = enumerator.Current;
									num = (short)109182981;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								}
								IL_76C:
								num = (short)2123300870;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								IL_6D2:
								goto IL_76C;
							}
							IL_767:
							IL_7C3:
							goto IL_1C78;
						}
						finally
						{
							num = (short)1804533761;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								switch (num2)
								{
								case 0:
									enumerator.Dispose();
									num = (short)708116482;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 1:
									switch (0)
									{
									case 0:
										goto IL_7FC;
									}
									continue;
								case 2:
									goto IL_833;
								}
								IL_7FC:
								if (enumerator == null)
								{
									break;
								}
								num = (short)1970339840;
								num2 = (int)((global::System.IntPtr)num);
							}
							IL_833:;
						}
						goto Block_8;
					case 56:
						try
						{
							num = (short)110624774;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								switch (num2)
								{
								case 0:
									goto IL_1807;
								case 1:
								{
									global::AcpCommonLib.IAcpFeatureNode acpFeatureNode7;
									task.AddTask(new global::AcpBusinessLayer.UndoRedo.ModifyDataTask<int>((acpFeatureNode7[10212] as global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO3.DataButtonInnerSection).CntrlHeadO3TrunkingO3DatatButtonFeature_A22597, num3));
									num = (short)1304363013;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 2:
								{
									if (!enumerator.MoveNext())
									{
										num = (short)1429536771;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									global::AcpCommonLib.IAcpFeatureNode acpFeatureNode7 = enumerator.Current;
									num = (short)376635396;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 3:
									num = (short)883032064;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 4:
								{
									global::AcpCommonLib.IAcpFeatureNode acpFeatureNode7;
									if (num3 != (acpFeatureNode7[10212] as global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO3.DataButtonInnerSection).CntrlHeadO3TrunkingO3DatatButtonFeature_A22597.Value)
									{
										num = (short)1853227009;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									break;
								}
								case 5:
									goto IL_17E9;
								case 6:
									switch (0)
									{
									case 0:
										goto IL_171C;
									}
									continue;
								}
								IL_1772:
								num = (short)753991682;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								IL_171C:
								goto IL_1772;
							}
							IL_17E9:
							IL_1807:
							goto IL_199C;
						}
						finally
						{
							num = (short)1379336194;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								switch (num2)
								{
								case 0:
									goto IL_1875;
								case 1:
									enumerator.Dispose();
									num = (short)696647680;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 2:
									switch (0)
									{
									case 0:
										goto IL_183E;
									}
									continue;
								}
								IL_183E:
								if (enumerator == null)
								{
									break;
								}
								num = (short)825163777;
								num2 = (int)((global::System.IntPtr)num);
							}
							IL_1875:;
						}
						goto IL_1878;
					case 57:
						enumerator = consolidatedActionBCOListInnerRecset.GetEnumerator();
						num = (short)1763508309;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 58:
						num = (short)239206440;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 59:
						num = (short)1697054796;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 60:
						goto IL_1674;
					case 61:
						goto IL_3A2;
					case 62:
						if (featureSectionId != 10608)
						{
							num = (short)1660551200;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_FAC;
					case 63:
						if (o9DataButtonInnerRecset != null)
						{
							num = (short)778895364;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return;
					case 64:
						return;
					case 65:
						try
						{
							num = (short)781844484;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								switch (num2)
								{
								case 0:
								{
									global::AcpCommonLib.IAcpFeatureNode acpFeatureNode8;
									task.AddTask(new global::AcpBusinessLayer.UndoRedo.ModifyDataTask<int>((acpFeatureNode8[10209] as global::Motorola.MackinawCPS.CoreFeatures.KeypadMicAndAccessories.DataButtonInnerSection).RadErgoCfgKMConventionalKMDatatButtonFeature_A22603, num3));
									num = (short)1761869825;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 1:
									goto IL_BD0;
								case 2:
									goto IL_BEE;
								case 3:
								{
									if (!enumerator.MoveNext())
									{
										num = (short)894435334;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									global::AcpCommonLib.IAcpFeatureNode acpFeatureNode8 = enumerator.Current;
									num = (short)530382853;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 4:
									switch (0)
									{
									case 0:
										goto IL_B01;
									}
									continue;
								case 5:
								{
									global::AcpCommonLib.IAcpFeatureNode acpFeatureNode8;
									if (num3 != (acpFeatureNode8[10209] as global::Motorola.MackinawCPS.CoreFeatures.KeypadMicAndAccessories.DataButtonInnerSection).RadErgoCfgKMConventionalKMDatatButtonFeature_A22603.Value)
									{
										num = (short)1370554368;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									break;
								}
								case 6:
									num = (short)744357890;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								IL_B56:
								num = (short)1097334787;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								IL_B01:
								goto IL_B56;
							}
							IL_BD0:
							IL_BEE:
							goto IL_15FB;
						}
						finally
						{
							num = (short)1602945025;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								switch (num2)
								{
								case 0:
									enumerator.Dispose();
									num = (short)683671554;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 1:
									switch (0)
									{
									case 0:
										goto IL_C25;
									}
									continue;
								case 2:
									goto IL_C5F;
								}
								IL_C25:
								if (enumerator == null)
								{
									break;
								}
								num = (short)728891392;
								num2 = (int)((global::System.IntPtr)num);
							}
							IL_C5F:;
						}
						goto IL_C62;
					case 66:
						enumerator = dataButtonInnerRecset2.GetEnumerator();
						num = (short)1150877761;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 67:
						num = (short)1734213715;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 68:
						goto IL_5CD;
					case 69:
						num = (short)621477896;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 70:
						if (dataButtonInnerRecset3 != null)
						{
							num = (short)1349517330;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_218B;
					case 71:
						try
						{
							num = (short)76021766;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								switch (num2)
								{
								case 0:
									goto IL_F36;
								case 1:
								{
									if (!enumerator.MoveNext())
									{
										num = (short)1239810050;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									global::AcpCommonLib.IAcpFeatureNode acpFeatureNode9 = enumerator.Current;
									num = (short)1930100739;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 2:
									num = (short)624099328;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 3:
								{
									global::AcpCommonLib.IAcpFeatureNode acpFeatureNode9;
									if (num3 != (acpFeatureNode9[10212] as global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO3.DataButtonInnerSection).CntrlHeadO3ConventionalO3DatatButtonFeature_A22595.Value)
									{
										num = (short)1918435333;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									break;
								}
								case 4:
									goto IL_E82;
								case 5:
								{
									global::AcpCommonLib.IAcpFeatureNode acpFeatureNode9;
									task.AddTask(new global::AcpBusinessLayer.UndoRedo.ModifyDataTask<int>((acpFeatureNode9[10212] as global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO3.DataButtonInnerSection).CntrlHeadO3ConventionalO3DatatButtonFeature_A22595, num3));
									num = (short)434962436;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 6:
									switch (0)
									{
									case 0:
										goto IL_E48;
									}
									continue;
								}
								IL_E87:
								num = (short)2121924609;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								IL_E48:
								goto IL_E87;
							}
							IL_E82:
							IL_F36:
							goto IL_1636;
						}
						finally
						{
							num = (short)1978138626;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								switch (num2)
								{
								case 0:
									goto IL_FA9;
								case 1:
									enumerator.Dispose();
									num = (short)895221760;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 2:
									switch (0)
									{
									case 0:
										goto IL_F6F;
									}
									continue;
								}
								IL_F6F:
								if (enumerator == null)
								{
									break;
								}
								num = (short)177930241;
								num2 = (int)((global::System.IntPtr)num);
							}
							IL_FA9:;
						}
						goto IL_FAC;
					case 72:
						goto IL_9DE;
					case 73:
						if (dataButtonInnerRecset3 != null)
						{
							num = (short)226295834;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_1C78;
					case 74:
						if (dataButtonInnerRecset != null)
						{
							num = (short)1485504580;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_199C;
					case 75:
						if (num3 != 140)
						{
							num = (short)1339490373;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_DC8;
					case 76:
						if (featureSectionId != 10090)
						{
							num = (short)689111107;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num3 = (self as global::Motorola.MackinawCPS.CoreFeatures.Buttons.DataButtonInnerSection).BtnTrunkingButtonDatatButtonFeature_A22608.Value;
						num = (short)1806762009;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 77:
						if (dataButtonInnerRecset != null)
						{
							num = (short)210894869;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_1636;
					case 78:
						goto IL_A05;
					case 79:
						goto IL_A42;
					case 80:
						goto IL_1674;
					case 81:
						enumerator = o7DataButtonInnerRecset.GetEnumerator();
						num = (short)448593968;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 82:
						num = (short)1759117346;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 83:
					{
						if (featureSectionId != 10209)
						{
							num = (short)480051258;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						global::Motorola.MackinawCPS.CoreFeatures.KeypadMicAndAccessories.DataButtonInnerSection dataButtonInnerSection = self as global::Motorola.MackinawCPS.CoreFeatures.KeypadMicAndAccessories.DataButtonInnerSection;
						num3 = dataButtonInnerSection.RadErgoCfgKMTrunkingKMDatatButtonFeature_A22605.Value;
						acpRecRefField = dataButtonInnerSection.RadErgoCfgKMTrunkingKMDatatButtonIndex_A41424;
						num = (short)808255516;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 84:
						if (dataButtonInnerRecset2 != null)
						{
							num = (short)938082376;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_1BFF;
					case 85:
						try
						{
							num = (short)1463418893;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								switch (num2)
								{
								case 0:
								{
									global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO9.ConsolidatedActionBCOListInner consolidatedActionBCOListInner2;
									task.AddTask(new global::AcpBusinessLayer.UndoRedo.DeleteRecordTask(consolidatedActionBCOListInner2));
									num = (short)1947205641;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 1:
									goto IL_14FC;
								case 2:
								{
									global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO9.ConsolidatedActionBCOListInner consolidatedActionBCOListInner2;
									task.AddTask(new global::AcpBusinessLayer.UndoRedo.ModifyRecRefDataTask(consolidatedActionBCOListInner2.ConsolidatedActionBCOListInnerSection.RadErgoControlO9ACBCOListIndex_A36668, acpRecRefField.UIValue));
									num = (short)79953927;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 3:
								{
									global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO9.ConsolidatedActionBCOListInner consolidatedActionBCOListInner2;
									if (acpRecRefField.Value != consolidatedActionBCOListInner2.ConsolidatedActionBCOListInnerSection.RadErgoControlO9ACBCOListIndex_A36668.Value)
									{
										num = (short)306511874;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									goto IL_14FC;
								}
								case 4:
								{
									if (!enumerator.MoveNext())
									{
										num = (short)1960968193;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO9.ConsolidatedActionBCOListInner consolidatedActionBCOListInner2 = (global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO9.ConsolidatedActionBCOListInner)enumerator.Current;
									num = (short)979042309;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 5:
								{
									global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO9.ConsolidatedActionBCOListInner consolidatedActionBCOListInner2;
									if (consolidatedActionBCOListInner2.ConsolidatedActionBCOListInnerSection.RadErgoControlO9ACBCOListBco_A36666.Value == 134)
									{
										num = (short)1572864012;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									break;
								}
								case 6:
									goto IL_1515;
								case 7:
									goto IL_135B;
								case 8:
									if (num3 != 227)
									{
										num = (short)1732116480;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									flag2 = true;
									num = (short)1044905994;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 9:
									goto IL_13C0;
								case 10:
									if (acpRecRefField != null)
									{
										num = (short)921960459;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									goto IL_14FC;
								case 11:
									num = (short)1460928515;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 12:
									num = (short)1981612040;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 13:
									switch (0)
									{
									case 0:
										goto IL_1324;
									}
									continue;
								}
								IL_1418:
								num = (short)2139553796;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								IL_1324:
								goto IL_1418;
								IL_14FC:
								num = (short)1705967622;
								num2 = (int)((global::System.IntPtr)num);
							}
							IL_135B:
							IL_13C0:
							IL_1515:
							goto IL_1B83;
						}
						finally
						{
							for (;;)
							{
								IL_151A:
								num = (short)1378222082;
								num2 = (int)((global::System.IntPtr)num);
								for (;;)
								{
									num = (short)1230087522;
									short num5 = num;
									num = (short)1236247906;
									switch ((num5 == num) ? 1 : 0)
									{
									case 0:
									case 2:
										goto IL_151A;
									default:
										num = (short)299499520;
										if (num != 0)
										{
										}
										switch (num2)
										{
										case 0:
											goto IL_15D1;
										case 1:
											enumerator.Dispose();
											num = (short)2061041664;
											num2 = (int)((global::System.IntPtr)num);
											continue;
										case 2:
											switch (0)
											{
											case 0:
												goto IL_1596;
											}
											continue;
										}
										IL_1596:
										if (enumerator == null)
										{
											goto IL_15D3;
										}
										num = (short)649330689;
										num2 = (int)((global::System.IntPtr)num);
										break;
									}
								}
							}
							IL_15D1:
							IL_15D3:;
						}
						goto IL_15D4;
					case 86:
						if (controlHeadO7Recset != null)
						{
							num = (short)527958021;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_C62;
					}
					goto IL_18A;
					IL_3A2:
					controlHeadO3Recset = null;
					dataButtonInnerRecset = null;
					controlHeadO3Recset = (global::AcpCommonLib.FeatureManager.GetFeature(2127) as global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO3.ControlHeadO3Recset);
					num = (short)1024786467;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_5CD:
					enumerator = dataButtonInnerRecset.GetEnumerator();
					num = (short)1842151480;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_635:
					flag = false;
					num = (short)1280966673;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_9DE:
					enumerator = dataButtonInnerRecset2.GetEnumerator();
					num = (short)1236729859;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					Block_8:
					try
					{
						IL_836:
						num = (short)1190068228;
						num2 = (int)((global::System.IntPtr)num);
						for (;;)
						{
							switch (num2)
							{
							case 0:
								num = (short)1394540546;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							case 1:
							{
								global::AcpCommonLib.IAcpFeatureNode acpFeatureNode10;
								task.AddTask(new global::AcpBusinessLayer.UndoRedo.ModifyDataTask<int>((acpFeatureNode10[10209] as global::Motorola.MackinawCPS.CoreFeatures.KeypadMicAndAccessories.DataButtonInnerSection).RadErgoCfgKMTrunkingKMDatatButtonFeature_A22605, num3));
								num = (short)1178206211;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							case 2:
								goto IL_96A;
							case 3:
								goto IL_8ED;
							case 4:
								switch (0)
								{
								case 0:
									goto IL_879;
								}
								continue;
							case 5:
							{
								if (!enumerator.MoveNext())
								{
									num = (short)595132416;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								global::AcpCommonLib.IAcpFeatureNode acpFeatureNode10 = enumerator.Current;
								num = (short)371785734;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							case 6:
							{
								global::AcpCommonLib.IAcpFeatureNode acpFeatureNode10;
								if (num3 != (acpFeatureNode10[10209] as global::Motorola.MackinawCPS.CoreFeatures.KeypadMicAndAccessories.DataButtonInnerSection).RadErgoCfgKMTrunkingKMDatatButtonFeature_A22605.Value)
								{
									num = (short)336723969;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								break;
							}
							}
							IL_87B:
							num = (short)323616773;
							num2 = (int)((global::System.IntPtr)num);
							continue;
							IL_879:
							goto IL_87B;
						}
						IL_8ED:
						IL_96A:
						goto IL_1BFF;
					}
					finally
					{
						num = (short)110362625;
						num2 = (int)((global::System.IntPtr)num);
						for (;;)
						{
							switch (num2)
							{
							case 0:
								enumerator.Dispose();
								num = (short)1116143618;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							case 1:
								switch (0)
								{
								case 0:
									goto IL_9A3;
								}
								continue;
							case 2:
								goto IL_9DB;
							}
							IL_9A3:
							if (enumerator == null)
							{
								break;
							}
							num = (short)1975713792;
							num2 = (int)((global::System.IntPtr)num);
						}
						IL_9DB:;
					}
					goto IL_9DE;
					IL_A05:
					num = (short)1991835718;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_A42:
					buttonsRecset = null;
					dataButtonInnerRecset3 = null;
					buttonsRecset = (global::AcpCommonLib.FeatureManager.GetFeature(2042) as global::Motorola.MackinawCPS.CoreFeatures.Buttons.ButtonsRecset);
					num = (short)480116775;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_C62:
					controlHeadO9Recset = null;
					o9DataButtonInnerRecset = null;
					controlHeadO9Recset = (global::AcpCommonLib.FeatureManager.GetFeature(4003) as global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO9.ControlHeadO9Recset);
					num = (short)492896300;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_CB7:
					controlHeadO7Recset = null;
					o7DataButtonInnerRecset = null;
					controlHeadO7Recset = (global::AcpCommonLib.FeatureManager.GetFeature(4114) as global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO7.ControlHeadO7Recset);
					num = (short)1811677270;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_D45:
					num = (short)7864349;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_DC8:
					num = (short)1236140105;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_FAC:
					global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO9.O9DataButtonInnerSection o9DataButtonInnerSection = self as global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO9.O9DataButtonInnerSection;
					num3 = o9DataButtonInnerSection.RadErgCtrlHeadO9DataButtonTrkFeature_A36526.Value;
					acpRecRefField = o9DataButtonInnerSection.CHO9DataButtonTrkIndex_A41416;
					num = (short)1214513212;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_11C7:
					dataButtonInnerRecset3 = (buttonsRecset[0][10089].EmbeddedRecset as global::Motorola.MackinawCPS.CoreFeatures.Buttons.DataButtonInnerRecset);
					num = (short)670892093;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_15D4:
					enumerator = dataButtonInnerRecset3.GetEnumerator();
					num = (short)1231552518;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_15FB:
					num = (short)1434648653;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_1636:
					num = (short)677642262;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_1674:
					num = (short)691273739;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_1878:
					consolidatedActionBCOListInnerRecset = null;
					flag2 = false;
					num = (short)1722941450;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_199C:
					num = (short)1103364112;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_1B83:
					num = (short)162201633;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_1BC2:
					num = (short)172621887;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_1BFF:
					num = (short)449970250;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_1C78:
					num = (short)580059186;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_1E52:
					global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO3.DataButtonInnerSection dataButtonInnerSection2 = self as global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO3.DataButtonInnerSection;
					num3 = dataButtonInnerSection2.CntrlHeadO3TrunkingO3DatatButtonFeature_A22597.Value;
					acpRecRefField = dataButtonInnerSection2.CHO3DataButtonTrkIndex_A41420;
					num = (short)2098462800;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_20FD:
					enumerator = o9DataButtonInnerRecset.GetEnumerator();
					num = (short)2122711040;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_218B:
					num = (short)1158938708;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_21CA:
					radioWide = ((global::AcpCommonLib.FeatureManager.GetFeature(2045) as global::Motorola.MackinawCPS.CoreFeatures.RadioWide.RadioWideRecset)[0] as global::Motorola.MackinawCPS.CoreFeatures.RadioWide.RadioWide);
					num = (short)1437794335;
					num2 = (int)((global::System.IntPtr)num);
				}
				return;
				IL_193D:
				return;
				IL_18A:
				num3 = 0;
				flag = true;
				acpRecRefField = null;
				featureSectionId = self.FeatureSectionId;
				num = (short)818282547;
				num2 = (int)((global::System.IntPtr)num);
				goto IL_27;
			}
			}
		}

		// Token: 0x06007B3C RID: 31548 RVA: 0x0070988C File Offset: 0x00707A8C
		public static bool conDownButtonApplicable(global::AcpCommonLib.IAcpFeatureSection self)
		{
			short num;
			for (;;)
			{
				num = (short)371326977;
				if (num != 0)
				{
				}
				if (self.ParentRecset[1] == self.Parent)
				{
					num = (short)875865297;
					short num2 = num;
					num = (short)382837969;
					switch ((num2 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						continue;
					case 1:
						goto IL_97;
					}
					break;
				}
				return true;
			}
			num = (short)1597833216;
			short num3 = num;
			IL_97:
			num = (short)1289945088;
			if (num != 0)
			{
			}
			return false;
		}

		// Token: 0x06007B3D RID: 31549 RVA: 0x0070994C File Offset: 0x00707B4C
		internal static bool ConKPMDataButtonConvIndexApplicable(global::AcpCommonLib.IAcpFeatureSection self)
		{
			while ((self as global::Motorola.MackinawCPS.CoreFeatures.KeypadMicAndAccessories.DataButtonInnerSection).RadErgoCfgKMConventionalKMDatatButtonFeature_A22603.Value == 227)
			{
				short num = (short)1345430609;
				short num2 = num;
				num = (short)1216390225;
				switch ((num2 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					break;
				default:
				{
					num = (short)1032978432;
					short num3 = num;
					num = (short)58851329;
					if (num != 0)
					{
					}
					num = (short)110297088;
					if (num != 0)
					{
					}
					return true;
				}
				}
			}
			return false;
		}

		// Token: 0x06007B3E RID: 31550 RVA: 0x00709A14 File Offset: 0x00707C14
		internal static bool ConKPMDataButtonTrkIndexApplicable(global::AcpCommonLib.IAcpFeatureSection self)
		{
			short num = (short)964755456;
			short num2 = num;
			if ((self as global::Motorola.MackinawCPS.CoreFeatures.KeypadMicAndAccessories.DataButtonInnerSection).RadErgoCfgKMTrunkingKMDatatButtonFeature_A22605.Value == 227)
			{
				num = (short)1696799921;
				short num3 = num;
				num = (short)1629297841;
				switch ((num3 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					break;
				default:
					num = (short)1020657665;
					if (num != 0)
					{
					}
					num = (short)391118848;
					if (num != 0)
					{
					}
					return true;
				}
			}
			return false;
		}

		// Token: 0x06007B3F RID: 31551 RVA: 0x00709ADC File Offset: 0x00707CDC
		public static void ConValueSetIfDataCnvIndexChanged(global::AcpCommonLib.IAcpFeatureSection self, global::AcpCommonLib.UndoRedo.ContainerTask task)
		{
			short num = (short)226820096;
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
					global::Motorola.MackinawCPS.CoreFeatures.KeypadMicAndAccessories.DataButtonInnerRecset dataButtonInnerRecset;
					global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO9.ConsolidatedActionBCOListInnerSection consolidatedActionBCOListInnerSection;
					bool flag;
					global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO9.ControlHeadO9Recset controlHeadO9Recset;
					global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO3.ControlHeadO3Recset controlHeadO3Recset;
					global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO3.DataButtonInnerRecset dataButtonInnerRecset2;
					global::Motorola.MackinawCPS.CoreFeatures.KeypadMicAndAccessories.KeypadMicAndAccessoriesRecset keypadMicAndAccessoriesRecset;
					global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO9.O9DataButtonInnerRecset o9DataButtonInnerRecset;
					global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO7.O7DataButtonInnerRecset o7DataButtonInnerRecset;
					global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO7.ControlHeadO7Recset controlHeadO7Recset;
					switch (num2)
					{
					case 0:
						return;
					case 1:
						goto IL_16D9;
					case 2:
					{
						global::System.Collections.Generic.IEnumerator<global::AcpBusinessLayer.FeatureNode> enumerator = dataButtonInnerRecset.GetEnumerator();
						num = (short)976683020;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 3:
						if (134 == consolidatedActionBCOListInnerSection.RadErgoControlO9ACBCOListBco_A36666.Value)
						{
							num = (short)1781334056;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_BB9;
					case 4:
						num = (short)2000551969;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 5:
						goto IL_BB9;
					case 6:
						try
						{
							num = (short)256966667;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								global::AcpCommonLib.IAcpFeatureNode acpFeatureNode;
								switch (num2)
								{
								case 0:
									if (acpListField.Value != (acpFeatureNode[10608] as global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO9.O9DataButtonInnerSection).CHO9DataButtonConvIndex_A41414.Value)
									{
										num = (short)795410437;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									goto IL_118D;
								case 1:
									goto IL_107F;
								case 2:
									num = (short)197525514;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 3:
									goto IL_12A9;
								case 4:
									goto IL_118D;
								case 5:
									goto IL_1149;
								case 6:
									task.AddTask(new global::AcpBusinessLayer.UndoRedo.ModifyRecRefDataTask((acpFeatureNode[10608] as global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO9.O9DataButtonInnerSection).CHO9DataButtonTrkIndex_A41416, acpListField.UIValue));
									flag = true;
									num = (short)716242945;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 7:
								{
									global::System.Collections.Generic.IEnumerator<global::AcpBusinessLayer.FeatureNode> enumerator;
									if (!enumerator.MoveNext())
									{
										num = (short)390004738;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									acpFeatureNode = enumerator.Current;
									num = (short)1934295040;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 8:
									if (acpListField.Value != (acpFeatureNode[10608] as global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO9.O9DataButtonInnerSection).CHO9DataButtonTrkIndex_A41416.Value)
									{
										num = (short)191102982;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									goto IL_107F;
								case 9:
									if (flag)
									{
										num = (short)730923020;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									break;
								case 10:
									goto IL_12C6;
								case 11:
									switch (0)
									{
									case 0:
										goto IL_107A;
									}
									continue;
								case 12:
								{
									num = (short)1238472709;
									short num3 = num;
									num = (short)2053937157;
									switch ((num3 == num) ? 1 : 0)
									{
									case 0:
									case 2:
										goto IL_1149;
									default:
										num = (short)517865472;
										if (num != 0)
										{
										}
										num = (short)1765146627;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									break;
								}
								}
								goto IL_107A;
								IL_107F:
								num = (short)1150091273;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								IL_1149:
								task.AddTask(new global::AcpBusinessLayer.UndoRedo.ModifyRecRefDataTask((acpFeatureNode[10608] as global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO9.O9DataButtonInnerSection).CHO9DataButtonConvIndex_A41414, acpListField.UIValue));
								flag = true;
								num = (short)1369767940;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								IL_118D:
								num = (short)751370248;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								IL_11E9:
								num = (short)274137095;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								IL_107A:
								goto IL_11E9;
							}
							IL_12A9:
							IL_12C6:
							goto IL_165A;
						}
						finally
						{
							num = (short)1091567618;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								global::System.Collections.Generic.IEnumerator<global::AcpBusinessLayer.FeatureNode> enumerator;
								switch (num2)
								{
								case 0:
									enumerator.Dispose();
									num = (short)1236467713;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 1:
									goto IL_1338;
								case 2:
									switch (0)
									{
									case 0:
										goto IL_12FF;
									}
									continue;
								}
								IL_12FF:
								if (enumerator == null)
								{
									break;
								}
								num = (short)931004416;
								num2 = (int)((global::System.IntPtr)num);
							}
							IL_1338:;
						}
						return;
					case 7:
						num = (short)1035927568;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 8:
					{
						if (featureSectionId != 10209)
						{
							num = (short)168755204;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						global::Motorola.MackinawCPS.CoreFeatures.KeypadMicAndAccessories.DataButtonInnerSection dataButtonInnerSection = self as global::Motorola.MackinawCPS.CoreFeatures.KeypadMicAndAccessories.DataButtonInnerSection;
						acpListField = dataButtonInnerSection.RadErgoCfgKMConventionalKMDatatButtonIndex_A41423;
						acpListField2 = dataButtonInnerSection.RadErgoCfgKMConventionalKMDatatButtonFeature_A22603;
						num = (short)1379074061;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 9:
						goto IL_1441;
					case 10:
					{
						if (featureSectionId != 10713)
						{
							num = (short)954531861;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO7.O7DataButtonInnerSection o7DataButtonInnerSection = self as global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO7.O7DataButtonInnerSection;
						acpListField = o7DataButtonInnerSection.CHO7DataButtonConvIndex_A41417;
						acpListField2 = o7DataButtonInnerSection.RadErgCtrlHeadO7DataButtonCnvFeature_A41299;
						num = (short)1514143766;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 11:
						if (controlHeadO9Recset != null)
						{
							num = (short)1907753002;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_16D9;
					case 12:
						try
						{
							num = (short)507117574;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								switch (num2)
								{
								case 0:
									goto IL_665;
								case 1:
								{
									global::AcpCommonLib.IAcpFeatureNode acpFeatureNode2;
									task.AddTask(new global::AcpBusinessLayer.UndoRedo.ModifyRecRefDataTask((acpFeatureNode2[10209] as global::Motorola.MackinawCPS.CoreFeatures.KeypadMicAndAccessories.DataButtonInnerSection).RadErgoCfgKMTrunkingKMDatatButtonIndex_A41424, acpListField.UIValue));
									flag = true;
									num = (short)968359936;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 2:
								{
									global::System.Collections.Generic.IEnumerator<global::AcpBusinessLayer.FeatureNode> enumerator;
									if (!enumerator.MoveNext())
									{
										num = (short)533397512;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									global::AcpCommonLib.IAcpFeatureNode acpFeatureNode2 = enumerator.Current;
									num = (short)1545797641;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 3:
								{
									global::AcpCommonLib.IAcpFeatureNode acpFeatureNode2;
									if (acpListField.Value != (acpFeatureNode2[10209] as global::Motorola.MackinawCPS.CoreFeatures.KeypadMicAndAccessories.DataButtonInnerSection).RadErgoCfgKMTrunkingKMDatatButtonIndex_A41424.Value)
									{
										num = (short)463929345;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									goto IL_665;
								}
								case 4:
									goto IL_6B6;
								case 5:
									goto IL_5C4;
								case 6:
									switch (0)
									{
									case 0:
										goto IL_57B;
									}
									continue;
								case 7:
									num = (short)150994948;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 8:
									num = (short)1630273548;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 9:
								{
									global::AcpCommonLib.IAcpFeatureNode acpFeatureNode2;
									if (acpListField.Value != (acpFeatureNode2[10209] as global::Motorola.MackinawCPS.CoreFeatures.KeypadMicAndAccessories.DataButtonInnerSection).RadErgoCfgKMConventionalKMDatatButtonIndex_A41423.Value)
									{
										num = (short)193921035;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									goto IL_5C4;
								}
								case 10:
									if (flag)
									{
										num = (short)891879431;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									break;
								case 11:
								{
									global::AcpCommonLib.IAcpFeatureNode acpFeatureNode2;
									task.AddTask(new global::AcpBusinessLayer.UndoRedo.ModifyRecRefDataTask((acpFeatureNode2[10209] as global::Motorola.MackinawCPS.CoreFeatures.KeypadMicAndAccessories.DataButtonInnerSection).RadErgoCfgKMConventionalKMDatatButtonIndex_A41423, acpListField.UIValue));
									flag = true;
									num = (short)1700724741;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 12:
									goto IL_777;
								}
								goto IL_57B;
								IL_5C4:
								num = (short)1560870915;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								IL_665:
								num = (short)942735370;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								IL_6BB:
								num = (short)296157186;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								IL_57B:
								goto IL_6BB;
							}
							IL_6B6:
							IL_777:
							goto IL_139A;
						}
						finally
						{
							num = (short)1298399232;
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
										goto IL_7AF;
									}
									continue;
								case 1:
									enumerator.Dispose();
									num = (short)2121007106;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 2:
									goto IL_7E7;
								}
								IL_7AF:
								if (enumerator == null)
								{
									break;
								}
								num = (short)832634881;
								num2 = (int)((global::System.IntPtr)num);
							}
							IL_7E7:;
						}
						goto IL_7EA;
					case 13:
						goto IL_BB9;
					case 14:
						num = (short)798949384;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 15:
						dataButtonInnerRecset2 = (controlHeadO3Recset[0][10234].EmbeddedRecset as global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO3.DataButtonInnerRecset);
						num = (short)1477509147;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 16:
						if (acpListField2.Value != 134)
						{
							num = (short)1877934125;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_150B;
					case 17:
						if (acpListField == null)
						{
							num = (short)1777205248;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_F9B;
					case 18:
						num = (short)33095690;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 19:
						goto IL_BB9;
					case 20:
						if (keypadMicAndAccessoriesRecset != null)
						{
							num = (short)143654938;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_15E8;
					case 21:
						num = (short)70647864;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 22:
						goto IL_BB9;
					case 23:
						if (featureSectionId != 10608)
						{
							num = (short)751763493;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_42D;
					case 24:
						if (controlHeadO9Recset != null)
						{
							num = (short)380698670;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return;
					case 25:
					{
						flag = false;
						global::System.Collections.Generic.IEnumerator<global::AcpBusinessLayer.FeatureNode> enumerator = o9DataButtonInnerRecset.GetEnumerator();
						num = (short)1212612614;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 26:
						dataButtonInnerRecset = (keypadMicAndAccessoriesRecset[0][10228].EmbeddedRecset as global::Motorola.MackinawCPS.CoreFeatures.KeypadMicAndAccessories.DataButtonInnerRecset);
						num = (short)1932263468;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 27:
						goto IL_AA0;
					case 28:
					{
						flag = false;
						global::System.Collections.Generic.IEnumerator<global::AcpBusinessLayer.FeatureNode> enumerator = o7DataButtonInnerRecset.GetEnumerator();
						num = (short)1272053792;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 29:
						if (featureSectionId <= 10212)
						{
							num = (short)881983502;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)2109276183;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 30:
						if (dataButtonInnerRecset2 != null)
						{
							num = (short)1837826086;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_4A0;
					case 31:
						if (o7DataButtonInnerRecset != null)
						{
							num = (short)1441726492;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_1492;
					case 32:
						try
						{
							num = (short)807534596;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								switch (num2)
								{
								case 0:
									goto IL_247;
								case 1:
								{
									global::AcpCommonLib.IAcpFeatureNode acpFeatureNode3;
									if (acpListField.Value != (acpFeatureNode3[10713] as global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO7.O7DataButtonInnerSection).CHO7DataButtonConvIndex_A41417.Value)
									{
										num = (short)201326600;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									goto IL_283;
								}
								case 2:
									num = (short)662503434;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 3:
									num = (short)1289420806;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 4:
									switch (0)
									{
									case 0:
										goto IL_1C1;
									}
									continue;
								case 5:
									if (flag)
									{
										num = (short)458948610;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									break;
								case 6:
									goto IL_3BA;
								case 7:
								{
									global::AcpCommonLib.IAcpFeatureNode acpFeatureNode3;
									if (acpListField.Value != (acpFeatureNode3[10713] as global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO7.O7DataButtonInnerSection).CHO7DataButtonTrkIndex_A41418.Value)
									{
										num = (short)1824063500;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									goto IL_247;
								}
								case 8:
								{
									global::AcpCommonLib.IAcpFeatureNode acpFeatureNode3;
									task.AddTask(new global::AcpBusinessLayer.UndoRedo.ModifyRecRefDataTask((acpFeatureNode3[10713] as global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO7.O7DataButtonInnerSection).CHO7DataButtonConvIndex_A41417, acpListField.UIValue));
									flag = true;
									num = (short)1766588427;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 9:
								{
									global::System.Collections.Generic.IEnumerator<global::AcpBusinessLayer.FeatureNode> enumerator;
									if (!enumerator.MoveNext())
									{
										num = (short)1655046147;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									global::AcpCommonLib.IAcpFeatureNode acpFeatureNode3 = enumerator.Current;
									num = (short)966262785;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 10:
									goto IL_39C;
								case 11:
									goto IL_283;
								case 12:
								{
									global::AcpCommonLib.IAcpFeatureNode acpFeatureNode3;
									task.AddTask(new global::AcpBusinessLayer.UndoRedo.ModifyRecRefDataTask((acpFeatureNode3[10713] as global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO7.O7DataButtonInnerSection).CHO7DataButtonTrkIndex_A41418, acpListField.UIValue));
									flag = true;
									num = (short)213450752;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								}
								IL_1C6:
								num = (short)332857353;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								IL_1C1:
								goto IL_1C6;
								IL_247:
								num = (short)575799301;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								IL_283:
								num = (short)465764359;
								num2 = (int)((global::System.IntPtr)num);
							}
							IL_39C:
							IL_3BA:
							goto IL_1492;
						}
						finally
						{
							num = (short)1119813633;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								global::System.Collections.Generic.IEnumerator<global::AcpBusinessLayer.FeatureNode> enumerator;
								switch (num2)
								{
								case 0:
									goto IL_42A;
								case 1:
									switch (0)
									{
									case 0:
										goto IL_3F3;
									}
									continue;
								case 2:
									enumerator.Dispose();
									num = (short)968949760;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								IL_3F3:
								if (enumerator == null)
								{
									break;
								}
								num = (short)2067529730;
								num2 = (int)((global::System.IntPtr)num);
							}
							IL_42A:;
						}
						goto IL_42D;
					case 33:
					{
						if (featureSectionId != 10212)
						{
							num = (short)2093678645;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO3.DataButtonInnerSection dataButtonInnerSection2 = self as global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO3.DataButtonInnerSection;
						acpListField = dataButtonInnerSection2.CHO3DataButtonConvIndex_A41419;
						acpListField2 = dataButtonInnerSection2.CntrlHeadO3ConventionalO3DatatButtonFeature_A22595;
						num = (short)507641861;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 34:
						o7DataButtonInnerRecset = (controlHeadO7Recset[0][10717].EmbeddedRecset as global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO7.O7DataButtonInnerRecset);
						num = (short)243990537;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 35:
						if (controlHeadO7Recset != null)
						{
							num = (short)338624512;
							short num4 = num;
							num = (short)686948386;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_1441;
					case 36:
						goto IL_BB9;
					case 37:
						num = (short)1376649255;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 38:
					{
						flag = false;
						global::System.Collections.Generic.IEnumerator<global::AcpBusinessLayer.FeatureNode> enumerator = dataButtonInnerRecset2.GetEnumerator();
						num = (short)858193961;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 39:
						if (featureSectionId != 10623)
						{
							num = (short)2015232018;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_7EA;
					case 40:
						acpListField = consolidatedActionBCOListInnerSection.RadErgoControlO9ACBCOListIndex_A36668;
						num = (short)1406337043;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 41:
						try
						{
							num = (short)502726660;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								switch (num2)
								{
								case 0:
								{
									global::AcpCommonLib.IAcpFeatureNode acpFeatureNode4;
									task.AddTask(new global::AcpBusinessLayer.UndoRedo.ModifyRecRefDataTask((acpFeatureNode4[10212] as global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO3.DataButtonInnerSection).CHO3DataButtonTrkIndex_A41420, acpListField.UIValue));
									flag = true;
									num = (short)965083143;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 1:
								{
									global::AcpCommonLib.IAcpFeatureNode acpFeatureNode4;
									task.AddTask(new global::AcpBusinessLayer.UndoRedo.ModifyRecRefDataTask((acpFeatureNode4[10212] as global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO3.DataButtonInnerSection).CHO3DataButtonConvIndex_A41419, acpListField.UIValue));
									flag = true;
									num = (short)730267654;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 2:
								{
									global::AcpCommonLib.IAcpFeatureNode acpFeatureNode4;
									if (acpListField.Value != (acpFeatureNode4[10212] as global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO3.DataButtonInnerSection).CHO3DataButtonConvIndex_A41419.Value)
									{
										num = (short)515309569;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									goto IL_DE3;
								}
								case 3:
									num = (short)2071724037;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 4:
									switch (0)
									{
									case 0:
										goto IL_D39;
									}
									continue;
								case 5:
									goto IL_F2A;
								case 6:
									goto IL_DE3;
								case 7:
									goto IL_E7D;
								case 8:
								{
									global::System.Collections.Generic.IEnumerator<global::AcpBusinessLayer.FeatureNode> enumerator;
									if (!enumerator.MoveNext())
									{
										num = (short)2047934467;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									global::AcpCommonLib.IAcpFeatureNode acpFeatureNode4 = enumerator.Current;
									num = (short)1819017218;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 9:
									goto IL_ECC;
								case 10:
									if (flag)
									{
										num = (short)1943994379;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									break;
								case 11:
									num = (short)877264905;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 12:
								{
									global::AcpCommonLib.IAcpFeatureNode acpFeatureNode4;
									if (acpListField.Value != (acpFeatureNode4[10212] as global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO3.DataButtonInnerSection).CHO3DataButtonTrkIndex_A41420.Value)
									{
										num = (short)1828323328;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									goto IL_E7D;
								}
								}
								goto IL_D39;
								IL_DE3:
								num = (short)2043936780;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								IL_E7D:
								num = (short)433061898;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								IL_ED1:
								num = (short)1505099784;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								IL_D39:
								goto IL_ED1;
							}
							IL_ECC:
							IL_F2A:
							goto IL_4A0;
						}
						finally
						{
							num = (short)1357316098;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								global::System.Collections.Generic.IEnumerator<global::AcpBusinessLayer.FeatureNode> enumerator;
								switch (num2)
								{
								case 0:
									enumerator.Dispose();
									num = (short)1700397057;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 1:
									goto IL_F98;
								case 2:
									switch (0)
									{
									case 0:
										goto IL_F61;
									}
									continue;
								}
								IL_F61:
								if (enumerator == null)
								{
									break;
								}
								num = (short)1495269376;
								num2 = (int)((global::System.IntPtr)num);
							}
							IL_F98:;
						}
						goto IL_F9B;
					case 42:
						o9DataButtonInnerRecset = (controlHeadO9Recset[0][10611].EmbeddedRecset as global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO9.O9DataButtonInnerRecset);
						num = (short)817168385;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 43:
						try
						{
							num = (short)1183514626;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								switch (num2)
								{
								case 0:
								{
									global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO9.ConsolidatedActionBCOListInner consolidatedActionBCOListInner;
									task.AddTask(new global::AcpBusinessLayer.UndoRedo.ModifyRecRefDataTask(consolidatedActionBCOListInner.ConsolidatedActionBCOListInnerSection.RadErgoControlO9ACBCOListIndex_A36668, acpListField.UIValue));
									num = (short)1616314374;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 1:
								{
									global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO9.ConsolidatedActionBCOListInner consolidatedActionBCOListInner;
									if (acpListField.Value != consolidatedActionBCOListInner.ConsolidatedActionBCOListInnerSection.RadErgoControlO9ACBCOListIndex_A36668.Value)
									{
										num = (short)241041408;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									goto IL_9EC;
								}
								case 2:
									switch (0)
									{
									case 0:
										goto IL_8CB;
									}
									continue;
								case 3:
								{
									global::System.Collections.Generic.IEnumerator<global::AcpBusinessLayer.FeatureNode> enumerator;
									if (!enumerator.MoveNext())
									{
										num = (short)1038024708;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO9.ConsolidatedActionBCOListInner consolidatedActionBCOListInner = (global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO9.ConsolidatedActionBCOListInner)enumerator.Current;
									num = (short)858062853;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 4:
									goto IL_9EC;
								case 5:
								{
									global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO9.ConsolidatedActionBCOListInner consolidatedActionBCOListInner;
									if (consolidatedActionBCOListInner.ConsolidatedActionBCOListInnerSection.RadErgoControlO9ACBCOListBco_A36666.Value == 134)
									{
										num = (short)20709383;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									break;
								}
								case 6:
									goto IL_94F;
								case 7:
									num = (short)968425473;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 8:
									goto IL_A05;
								}
								IL_954:
								num = (short)1253507075;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								IL_8CB:
								goto IL_954;
								IL_9EC:
								num = (short)1144520712;
								num2 = (int)((global::System.IntPtr)num);
							}
							IL_94F:
							IL_A05:
							return;
						}
						finally
						{
							num = (short)70057986;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								global::System.Collections.Generic.IEnumerator<global::AcpBusinessLayer.FeatureNode> enumerator;
								switch (num2)
								{
								case 0:
									goto IL_A74;
								case 1:
									enumerator.Dispose();
									num = (short)229900288;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 2:
									switch (0)
									{
									case 0:
										goto IL_A3C;
									}
									continue;
								}
								IL_A3C:
								if (enumerator == null)
								{
									break;
								}
								num = (short)1757937665;
								num2 = (int)((global::System.IntPtr)num);
							}
							IL_A74:
							num = (short)238551041;
							if (num != 0)
							{
							}
						}
						goto IL_AA0;
					case 44:
						goto IL_15E8;
					case 45:
						num = (short)761135151;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 46:
						num = (short)352780336;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 47:
						if (acpListField2.Value == 227)
						{
							num = (short)1975713842;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return;
					case 48:
						if (controlHeadO9Recset.Count > 0)
						{
							num = (short)382009395;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return;
					case 49:
						if (dataButtonInnerRecset != null)
						{
							num = (short)270139394;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_139A;
					case 50:
						goto IL_150B;
					case 51:
					{
						global::System.Collections.Generic.IEnumerator<global::AcpBusinessLayer.FeatureNode> enumerator = (controlHeadO9Recset[0][10622].EmbeddedRecset as global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO9.ConsolidatedActionBCOListInnerRecset).GetEnumerator();
						num = (short)1732968491;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 52:
						if (o9DataButtonInnerRecset != null)
						{
							num = (short)1022951449;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_165A;
					case 53:
						num = (short)52559929;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 54:
						if (acpListField2 != null)
						{
							num = (short)1215692807;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return;
					case 55:
						if (controlHeadO3Recset != null)
						{
							num = (short)1402929167;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_AA0;
					case 56:
						goto IL_BB9;
					case 57:
						goto IL_BB9;
					}
					goto IL_116;
					IL_42D:
					global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO9.O9DataButtonInnerSection o9DataButtonInnerSection = self as global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO9.O9DataButtonInnerSection;
					acpListField = o9DataButtonInnerSection.CHO9DataButtonConvIndex_A41414;
					acpListField2 = o9DataButtonInnerSection.RadErgCtrlHeadO9DataButtonCnvFeature_A36528;
					num = (short)1018298404;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_4A0:
					num = (short)648675359;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_7EA:
					consolidatedActionBCOListInnerSection = (self as global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO9.ConsolidatedActionBCOListInnerSection);
					num = (short)564723715;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_AA0:
					controlHeadO7Recset = null;
					o7DataButtonInnerRecset = null;
					controlHeadO7Recset = (global::AcpCommonLib.FeatureManager.GetFeature(4114) as global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO7.ControlHeadO7Recset);
					num = (short)1884356643;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_BB9:
					num = (short)695533585;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_F9B:
					keypadMicAndAccessoriesRecset = null;
					dataButtonInnerRecset = null;
					keypadMicAndAccessoriesRecset = (global::AcpCommonLib.FeatureManager.GetFeature(2128) as global::Motorola.MackinawCPS.CoreFeatures.KeypadMicAndAccessories.KeypadMicAndAccessoriesRecset);
					num = (short)2106916884;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_139A:
					num = (short)1151926302;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_1441:
					controlHeadO9Recset = null;
					o9DataButtonInnerRecset = null;
					controlHeadO9Recset = (global::AcpCommonLib.FeatureManager.GetFeature(4003) as global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO9.ControlHeadO9Recset);
					num = (short)836042763;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_1492:
					num = (short)1090781236;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_150B:
					num = (short)305856536;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_15E8:
					controlHeadO3Recset = null;
					dataButtonInnerRecset2 = null;
					controlHeadO3Recset = (global::AcpCommonLib.FeatureManager.GetFeature(2127) as global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO3.ControlHeadO3Recset);
					num = (short)1020330039;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_165A:
					num = (short)890044470;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_16D9:
					flag = false;
					num = (short)1548943409;
					num2 = (int)((global::System.IntPtr)num);
				}
				return;
				IL_116:
				acpListField = null;
				acpListField2 = null;
				featureSectionId = self.FeatureSectionId;
				num = (short)1516634141;
				num2 = (int)((global::System.IntPtr)num);
				goto IL_27;
			}
			}
		}

		// Token: 0x06007B40 RID: 31552 RVA: 0x0070B2D0 File Offset: 0x007094D0
		public static void ConValueSetIfDataTrkIndexChanged(global::AcpCommonLib.IAcpFeatureSection self, global::AcpCommonLib.UndoRedo.ContainerTask task)
		{
			short num = (short)1071251456;
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
					bool flag;
					global::System.Collections.Generic.IEnumerator<global::AcpBusinessLayer.FeatureNode> enumerator;
					global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO3.ControlHeadO3Recset controlHeadO3Recset;
					global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO9.ControlHeadO9Recset controlHeadO9Recset;
					global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO7.ControlHeadO7Recset controlHeadO7Recset;
					global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO7.O7DataButtonInnerRecset o7DataButtonInnerRecset;
					global::Motorola.MackinawCPS.CoreFeatures.KeypadMicAndAccessories.DataButtonInnerRecset dataButtonInnerRecset;
					global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO9.O9DataButtonInnerRecset o9DataButtonInnerRecset;
					global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO3.DataButtonInnerRecset dataButtonInnerRecset2;
					switch (num2)
					{
					case 0:
						goto IL_575;
					case 1:
					{
						if (featureSectionId != 10212)
						{
							num = (short)406192165;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO3.DataButtonInnerSection dataButtonInnerSection = self as global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO3.DataButtonInnerSection;
						acpListField = dataButtonInnerSection.CHO3DataButtonTrkIndex_A41420;
						acpListField2 = dataButtonInnerSection.CntrlHeadO3TrunkingO3DatatButtonFeature_A22597;
						num = (short)1252851712;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 2:
						try
						{
							num = (short)2089287686;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								switch (num2)
								{
								case 0:
								{
									global::AcpCommonLib.IAcpFeatureNode acpFeatureNode;
									task.AddTask(new global::AcpBusinessLayer.UndoRedo.ModifyRecRefDataTask((acpFeatureNode[10212] as global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO3.DataButtonInnerSection).CHO3DataButtonTrkIndex_A41420, acpListField.UIValue));
									flag = true;
									num = (short)413859852;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 1:
									goto IL_15BD;
								case 2:
								{
									global::AcpCommonLib.IAcpFeatureNode acpFeatureNode;
									if (acpListField.Value != (acpFeatureNode[10212] as global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO3.DataButtonInnerSection).CHO3DataButtonTrkIndex_A41420.Value)
									{
										num = (short)990183424;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									goto IL_149D;
								}
								case 3:
									goto IL_1428;
								case 4:
									num = (short)2008678407;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 5:
									if (flag)
									{
										num = (short)1393033220;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									break;
								case 6:
									switch (0)
									{
									case 0:
										goto IL_13C1;
									}
									continue;
								case 7:
									goto IL_1498;
								case 8:
									num = (short)890044417;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 9:
								{
									global::AcpCommonLib.IAcpFeatureNode acpFeatureNode;
									task.AddTask(new global::AcpBusinessLayer.UndoRedo.ModifyRecRefDataTask((acpFeatureNode[10212] as global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO3.DataButtonInnerSection).CHO3DataButtonConvIndex_A41419, acpListField.UIValue));
									flag = true;
									num = (short)717946883;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 10:
								{
									global::AcpCommonLib.IAcpFeatureNode acpFeatureNode;
									if (acpListField.Value != (acpFeatureNode[10212] as global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO3.DataButtonInnerSection).CHO3DataButtonConvIndex_A41419.Value)
									{
										num = (short)712376329;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									goto IL_1428;
								}
								case 11:
								{
									if (!enumerator.MoveNext())
									{
										num = (short)1404174344;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									global::AcpCommonLib.IAcpFeatureNode acpFeatureNode = enumerator.Current;
									num = (short)1739980810;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 12:
									goto IL_149D;
								}
								goto IL_13C1;
								IL_1428:
								num = (short)175898626;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								IL_149D:
								num = (short)1482358789;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								IL_1563:
								num = (short)1061224459;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								IL_13C1:
								goto IL_1563;
							}
							IL_1498:
							IL_15BD:;
						}
						finally
						{
							num = (short)1551106048;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								switch (num2)
								{
								case 0:
									switch (0)
									{
									case 0:
										goto IL_15F1;
									}
									continue;
								case 1:
									goto IL_162A;
								case 2:
									enumerator.Dispose();
									num = (short)66060289;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								IL_15F1:
								if (enumerator == null)
								{
									break;
								}
								num = (short)864223234;
								num2 = (int)((global::System.IntPtr)num);
							}
							IL_162A:;
						}
						goto IL_162D;
					case 3:
						try
						{
							num = (short)1044381702;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								switch (num2)
								{
								case 0:
								{
									global::AcpCommonLib.IAcpFeatureNode acpFeatureNode2;
									if (acpListField.Value != (acpFeatureNode2[10608] as global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO9.O9DataButtonInnerSection).CHO9DataButtonConvIndex_A41414.Value)
									{
										num = (short)648151043;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									goto IL_DB8;
								}
								case 1:
									if (flag)
									{
										num = (short)1089667076;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									break;
								case 2:
								{
									if (!enumerator.MoveNext())
									{
										num = (short)1328480261;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									global::AcpCommonLib.IAcpFeatureNode acpFeatureNode2 = enumerator.Current;
									num = (short)497483776;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 3:
								{
									global::AcpCommonLib.IAcpFeatureNode acpFeatureNode2;
									task.AddTask(new global::AcpBusinessLayer.UndoRedo.ModifyRecRefDataTask((acpFeatureNode2[10608] as global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO9.O9DataButtonInnerSection).CHO9DataButtonConvIndex_A41414, acpListField.UIValue));
									flag = true;
									num = (short)529334281;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 4:
									num = (short)2146172939;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 5:
									num = (short)1270743050;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 6:
									switch (0)
									{
									case 0:
										goto IL_D2E;
									}
									continue;
								case 7:
								{
									global::AcpCommonLib.IAcpFeatureNode acpFeatureNode2;
									if (acpListField.Value != (acpFeatureNode2[10608] as global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO9.O9DataButtonInnerSection).CHO9DataButtonTrkIndex_A41416.Value)
									{
										num = (short)523567116;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									goto IL_E59;
								}
								case 8:
									goto IL_E59;
								case 9:
									goto IL_DB8;
								case 10:
									goto IL_F2D;
								case 11:
									goto IL_EAA;
								case 12:
								{
									global::AcpCommonLib.IAcpFeatureNode acpFeatureNode2;
									task.AddTask(new global::AcpBusinessLayer.UndoRedo.ModifyRecRefDataTask((acpFeatureNode2[10608] as global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO9.O9DataButtonInnerSection).CHO9DataButtonTrkIndex_A41416, acpListField.UIValue));
									flag = true;
									num = (short)2132148232;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								}
								IL_D77:
								num = (short)1061945346;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								IL_D2E:
								goto IL_D77;
								IL_DB8:
								num = (short)1830223879;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								IL_E59:
								num = (short)481492993;
								num2 = (int)((global::System.IntPtr)num);
							}
							IL_EAA:
							IL_F2D:
							goto IL_485;
						}
						finally
						{
							num = (short)329056257;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								switch (num2)
								{
								case 0:
									enumerator.Dispose();
									num = (short)180092930;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 1:
								{
									num = (short)10307017;
									short num3 = num;
									num = (short)1763657161;
									switch ((num3 == num) ? 1 : 0)
									{
									case 0:
									case 2:
										goto IL_FE7;
									default:
										num = (short)1375862784;
										if (num != 0)
										{
										}
										switch (0)
										{
										case 0:
											goto IL_FB0;
										}
										continue;
									}
									break;
								}
								case 2:
									goto IL_FE7;
								}
								IL_FB0:
								if (enumerator == null)
								{
									break;
								}
								num = (short)527630336;
								num2 = (int)((global::System.IntPtr)num);
							}
							IL_FE7:;
						}
						goto IL_FEA;
					case 4:
						goto IL_575;
					case 5:
						if (acpListField2 != null)
						{
							num = (short)1254096907;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return;
					case 6:
						try
						{
							num = (short)146210822;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								switch (num2)
								{
								case 0:
								{
									if (!enumerator.MoveNext())
									{
										num = (short)1356398595;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									global::AcpCommonLib.IAcpFeatureNode acpFeatureNode3 = enumerator.Current;
									num = (short)1474297858;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 1:
								{
									global::AcpCommonLib.IAcpFeatureNode acpFeatureNode3;
									if (acpListField.Value != (acpFeatureNode3[10209] as global::Motorola.MackinawCPS.CoreFeatures.KeypadMicAndAccessories.DataButtonInnerSection).RadErgoCfgKMTrunkingKMDatatButtonIndex_A41424.Value)
									{
										num = (short)1672216580;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									goto IL_AEE;
								}
								case 2:
								{
									global::AcpCommonLib.IAcpFeatureNode acpFeatureNode3;
									if (acpListField.Value != (acpFeatureNode3[10209] as global::Motorola.MackinawCPS.CoreFeatures.KeypadMicAndAccessories.DataButtonInnerSection).RadErgoCfgKMConventionalKMDatatButtonIndex_A41423.Value)
									{
										num = (short)436076549;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									goto IL_B29;
								}
								case 3:
									num = (short)1226702858;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 4:
								{
									global::AcpCommonLib.IAcpFeatureNode acpFeatureNode3;
									task.AddTask(new global::AcpBusinessLayer.UndoRedo.ModifyRecRefDataTask((acpFeatureNode3[10209] as global::Motorola.MackinawCPS.CoreFeatures.KeypadMicAndAccessories.DataButtonInnerSection).RadErgoCfgKMTrunkingKMDatatButtonIndex_A41424, acpListField.UIValue));
									flag = true;
									num = (short)1546911752;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 5:
								{
									global::AcpCommonLib.IAcpFeatureNode acpFeatureNode3;
									task.AddTask(new global::AcpBusinessLayer.UndoRedo.ModifyRecRefDataTask((acpFeatureNode3[10209] as global::Motorola.MackinawCPS.CoreFeatures.KeypadMicAndAccessories.DataButtonInnerSection).RadErgoCfgKMConventionalKMDatatButtonIndex_A41423, acpListField.UIValue));
									flag = true;
									num = (short)1762197515;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 6:
									switch (0)
									{
									case 0:
										goto IL_A23;
									}
									continue;
								case 7:
									goto IL_AE9;
								case 8:
									goto IL_AEE;
								case 9:
									num = (short)1295319047;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 10:
									goto IL_C23;
								case 11:
									goto IL_B29;
								case 12:
									if (flag)
									{
										num = (short)584843273;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									break;
								}
								goto IL_A23;
								IL_AEE:
								num = (short)446758924;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								IL_B29:
								num = (short)1691549697;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								IL_BC9:
								num = (short)1858076672;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								IL_A23:
								goto IL_BC9;
							}
							IL_AE9:
							IL_C23:
							goto IL_418;
						}
						finally
						{
							num = (short)1599406080;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								switch (num2)
								{
								case 0:
									switch (0)
									{
									case 0:
										goto IL_C5A;
									}
									continue;
								case 1:
									goto IL_C91;
								case 2:
									enumerator.Dispose();
									num = (short)1531314177;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								IL_C5A:
								if (enumerator == null)
								{
									break;
								}
								num = (short)1337851906;
								num2 = (int)((global::System.IntPtr)num);
							}
							IL_C91:;
						}
						goto IL_C94;
					case 7:
						if (controlHeadO3Recset != null)
						{
							num = (short)457572386;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_7E8;
					case 8:
						if (controlHeadO9Recset != null)
						{
							num = (short)965935144;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_C94;
					case 9:
						goto IL_575;
					case 10:
						if (controlHeadO7Recset != null)
						{
							num = (short)1803092003;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_5F9;
					case 11:
						num = (short)1310720015;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 12:
						try
						{
							num = (short)1982857221;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								switch (num2)
								{
								case 0:
									goto IL_1236;
								case 1:
								{
									if (!enumerator.MoveNext())
									{
										num = (short)389414920;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO9.ConsolidatedActionBCOListInner consolidatedActionBCOListInner = (global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO9.ConsolidatedActionBCOListInner)enumerator.Current;
									num = (short)2142765060;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 2:
									goto IL_11D9;
								case 3:
									num = (short)989003783;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 4:
								{
									global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO9.ConsolidatedActionBCOListInner consolidatedActionBCOListInner;
									if (consolidatedActionBCOListInner.ConsolidatedActionBCOListInnerSection.RadErgoControlO9ACBCOListBco_A36666.Value == 134)
									{
										num = (short)31457283;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									break;
								}
								case 5:
									switch (0)
									{
									case 0:
										goto IL_10F8;
									}
									continue;
								case 6:
								{
									global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO9.ConsolidatedActionBCOListInner consolidatedActionBCOListInner;
									task.AddTask(new global::AcpBusinessLayer.UndoRedo.ModifyRecRefDataTask(consolidatedActionBCOListInner.ConsolidatedActionBCOListInnerSection.RadErgoControlO9ACBCOListIndex_A36668, acpListField.UIValue));
									num = (short)1896218626;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 7:
								{
									global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO9.ConsolidatedActionBCOListInner consolidatedActionBCOListInner;
									if (acpListField.Value != consolidatedActionBCOListInner.ConsolidatedActionBCOListInnerSection.RadErgoControlO9ACBCOListIndex_A36668.Value)
									{
										num = (short)1562181638;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									goto IL_121E;
								}
								case 8:
									goto IL_121E;
								}
								IL_11DE:
								num = (short)1383858177;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								IL_10F8:
								goto IL_11DE;
								IL_121E:
								num = (short)425590784;
								num2 = (int)((global::System.IntPtr)num);
							}
							IL_11D9:
							IL_1236:
							return;
						}
						finally
						{
							num = (short)1373765633;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								switch (num2)
								{
								case 0:
									enumerator.Dispose();
									num = (short)922419202;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 1:
									switch (0)
									{
									case 0:
										goto IL_126F;
									}
									continue;
								case 2:
									goto IL_12A7;
								}
								IL_126F:
								if (enumerator == null)
								{
									break;
								}
								num = (short)1436024832;
								num2 = (int)((global::System.IntPtr)num);
							}
							IL_12A7:;
						}
						goto IL_12AA;
					case 13:
					{
						global::Motorola.MackinawCPS.CoreFeatures.KeypadMicAndAccessories.KeypadMicAndAccessoriesRecset keypadMicAndAccessoriesRecset;
						if (keypadMicAndAccessoriesRecset != null)
						{
							num = (short)1544880170;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_83B;
					}
					case 14:
					{
						num = (short)373620736;
						short num4 = num;
						goto IL_7E8;
					}
					case 15:
						if (acpListField2.Value != 134)
						{
							num = (short)1730347026;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_746;
					case 16:
						goto IL_575;
					case 17:
						if (o7DataButtonInnerRecset != null)
						{
							num = (short)270336022;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_1328;
					case 18:
						num = (short)1831862301;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 19:
						if (dataButtonInnerRecset != null)
						{
							num = (short)32440372;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_418;
					case 20:
						try
						{
							num = (short)1901789196;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								switch (num2)
								{
								case 0:
								{
									global::AcpCommonLib.IAcpFeatureNode acpFeatureNode4;
									task.AddTask(new global::AcpBusinessLayer.UndoRedo.ModifyRecRefDataTask((acpFeatureNode4[10713] as global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO7.O7DataButtonInnerSection).CHO7DataButtonTrkIndex_A41418, acpListField.UIValue));
									flag = true;
									num = (short)1797128198;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 1:
									num = (short)211550210;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 2:
									goto IL_3A5;
								case 3:
								{
									global::AcpCommonLib.IAcpFeatureNode acpFeatureNode4;
									if (acpListField.Value != (acpFeatureNode4[10713] as global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO7.O7DataButtonInnerSection).CHO7DataButtonConvIndex_A41417.Value)
									{
										num = (short)118489096;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									goto IL_2E7;
								}
								case 4:
								{
									global::AcpCommonLib.IAcpFeatureNode acpFeatureNode4;
									if (acpListField.Value != (acpFeatureNode4[10713] as global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO7.O7DataButtonInnerSection).CHO7DataButtonTrkIndex_A41418.Value)
									{
										num = (short)467271680;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									goto IL_1CC;
								}
								case 5:
									if (flag)
									{
										num = (short)1924333578;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									break;
								case 6:
									goto IL_1CC;
								case 7:
								{
									if (!enumerator.MoveNext())
									{
										num = (short)1416691713;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									global::AcpCommonLib.IAcpFeatureNode acpFeatureNode4 = enumerator.Current;
									num = (short)299565059;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 8:
								{
									global::AcpCommonLib.IAcpFeatureNode acpFeatureNode4;
									task.AddTask(new global::AcpBusinessLayer.UndoRedo.ModifyRecRefDataTask((acpFeatureNode4[10713] as global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO7.O7DataButtonInnerSection).CHO7DataButtonConvIndex_A41417, acpListField.UIValue));
									flag = true;
									num = (short)56360969;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 9:
									goto IL_2E7;
								case 10:
									num = (short)1649541131;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 11:
									goto IL_1C7;
								case 12:
									switch (0)
									{
									case 0:
										goto IL_1AD;
									}
									continue;
								}
								goto IL_1AD;
								IL_1CC:
								num = (short)1964900357;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								IL_200:
								num = (short)179372039;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								IL_1AD:
								goto IL_200;
								IL_2E7:
								num = (short)1999634436;
								num2 = (int)((global::System.IntPtr)num);
							}
							IL_1C7:
							IL_3A5:
							goto IL_1328;
						}
						finally
						{
							num = (short)98304000;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								switch (num2)
								{
								case 0:
									switch (0)
									{
									case 0:
										goto IL_3DC;
									}
									continue;
								case 1:
									goto IL_415;
								case 2:
									enumerator.Dispose();
									num = (short)1148715009;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								IL_3DC:
								if (enumerator == null)
								{
									break;
								}
								num = (short)964493314;
								num2 = (int)((global::System.IntPtr)num);
							}
							IL_415:;
						}
						goto IL_418;
					case 21:
						goto IL_5F9;
					case 22:
						flag = false;
						enumerator = o7DataButtonInnerRecset.GetEnumerator();
						num = (short)1402470420;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 23:
						flag = false;
						enumerator = o9DataButtonInnerRecset.GetEnumerator();
						num = (short)193200131;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 24:
						flag = false;
						enumerator = dataButtonInnerRecset2.GetEnumerator();
						num = (short)2142437378;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 25:
					{
						if (featureSectionId != 10209)
						{
							num = (short)1042022428;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						global::Motorola.MackinawCPS.CoreFeatures.KeypadMicAndAccessories.DataButtonInnerSection dataButtonInnerSection2 = self as global::Motorola.MackinawCPS.CoreFeatures.KeypadMicAndAccessories.DataButtonInnerSection;
						acpListField = dataButtonInnerSection2.RadErgoCfgKMTrunkingKMDatatButtonIndex_A41424;
						acpListField2 = dataButtonInnerSection2.RadErgoCfgKMTrunkingKMDatatButtonFeature_A22605;
						num = (short)1173684233;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 26:
					{
						if (featureSectionId != 10713)
						{
							num = (short)1746796591;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO7.O7DataButtonInnerSection o7DataButtonInnerSection = self as global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO7.O7DataButtonInnerSection;
						acpListField = o7DataButtonInnerSection.CHO7DataButtonTrkIndex_A41418;
						acpListField2 = o7DataButtonInnerSection.RadErgCtrlHeadO7DataButtonTrkFeature_A41297;
						num = (short)1142030363;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 27:
						num = (short)1744764929;
						if (num != 0)
						{
						}
						goto IL_575;
					case 28:
						num = (short)1672871937;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 29:
						if (acpListField2.Value == 227)
						{
							num = (short)1509294123;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return;
					case 30:
						if (controlHeadO9Recset != null)
						{
							num = (short)1451884575;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return;
					case 31:
						num = (short)1309737009;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 32:
						return;
					case 33:
						num = (short)1273888793;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 34:
						dataButtonInnerRecset2 = (controlHeadO3Recset[0][10234].EmbeddedRecset as global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO3.DataButtonInnerRecset);
						num = (short)581042190;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 35:
						o7DataButtonInnerRecset = (controlHeadO7Recset[0][10717].EmbeddedRecset as global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO7.O7DataButtonInnerRecset);
						num = (short)962396181;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 36:
					{
						if (acpListField == null)
						{
							num = (short)1935081504;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						global::Motorola.MackinawCPS.CoreFeatures.KeypadMicAndAccessories.KeypadMicAndAccessoriesRecset keypadMicAndAccessoriesRecset = null;
						dataButtonInnerRecset = null;
						keypadMicAndAccessoriesRecset = (global::AcpCommonLib.FeatureManager.GetFeature(2128) as global::Motorola.MackinawCPS.CoreFeatures.KeypadMicAndAccessories.KeypadMicAndAccessoriesRecset);
						num = (short)1899626509;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 37:
						num = (short)1179779111;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 38:
						enumerator = (controlHeadO9Recset[0][10622].EmbeddedRecset as global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO9.ConsolidatedActionBCOListInnerRecset).GetEnumerator();
						num = (short)1727987724;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 39:
						goto IL_575;
					case 40:
						goto IL_12AA;
					case 41:
						if (o9DataButtonInnerRecset != null)
						{
							num = (short)372441111;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_485;
					case 42:
					{
						global::Motorola.MackinawCPS.CoreFeatures.KeypadMicAndAccessories.KeypadMicAndAccessoriesRecset keypadMicAndAccessoriesRecset;
						dataButtonInnerRecset = (keypadMicAndAccessoriesRecset[0][10228].EmbeddedRecset as global::Motorola.MackinawCPS.CoreFeatures.KeypadMicAndAccessories.DataButtonInnerRecset);
						num = (short)287244332;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 43:
						goto IL_746;
					case 44:
						goto IL_83B;
					case 45:
						num = (short)1265958938;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 46:
						if (featureSectionId <= 10212)
						{
							num = (short)1393623073;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)943783984;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 47:
						num = (short)1471086596;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 48:
					{
						if (featureSectionId != 10608)
						{
							num = (short)1666580525;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO9.O9DataButtonInnerSection o9DataButtonInnerSection = self as global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO9.O9DataButtonInnerSection;
						acpListField = o9DataButtonInnerSection.CHO9DataButtonTrkIndex_A41416;
						acpListField2 = o9DataButtonInnerSection.RadErgCtrlHeadO9DataButtonTrkFeature_A36526;
						num = (short)1964638224;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 49:
						if (controlHeadO9Recset.Count > 0)
						{
							num = (short)747700262;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return;
					case 50:
						if (dataButtonInnerRecset2 != null)
						{
							num = (short)228130840;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_162D;
					case 51:
						goto IL_C94;
					case 52:
						goto IL_FEA;
					}
					goto IL_102;
					IL_418:
					num = (short)1163460658;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_485:
					num = (short)1486815237;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_575:
					num = (short)870711332;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_5F9:
					controlHeadO9Recset = null;
					o9DataButtonInnerRecset = null;
					controlHeadO9Recset = (global::AcpCommonLib.FeatureManager.GetFeature(4003) as global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO9.ControlHeadO9Recset);
					num = (short)1754595336;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_746:
					num = (short)996868126;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_7E8:
					controlHeadO7Recset = null;
					o7DataButtonInnerRecset = null;
					controlHeadO7Recset = (global::AcpCommonLib.FeatureManager.GetFeature(4114) as global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO7.ControlHeadO7Recset);
					num = (short)204013578;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_83B:
					controlHeadO3Recset = null;
					dataButtonInnerRecset2 = null;
					controlHeadO3Recset = (global::AcpCommonLib.FeatureManager.GetFeature(2127) as global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO3.ControlHeadO3Recset);
					num = (short)681771015;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_C94:
					flag = false;
					num = (short)393543699;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_FEA:
					enumerator = dataButtonInnerRecset.GetEnumerator();
					num = (short)1486880774;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_12AA:
					o9DataButtonInnerRecset = (controlHeadO9Recset[0][10611].EmbeddedRecset as global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO9.O9DataButtonInnerRecset);
					num = (short)1484062771;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_1328:
					num = (short)466878505;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_162D:
					num = (short)869007377;
					num2 = (int)((global::System.IntPtr)num);
				}
				return;
				IL_102:
				acpListField = null;
				acpListField2 = null;
				featureSectionId = self.FeatureSectionId;
				num = (short)63701038;
				num2 = (int)((global::System.IntPtr)num);
				goto IL_27;
			}
			}
		}

		// Token: 0x06007B41 RID: 31553 RVA: 0x0070CA08 File Offset: 0x0070AC08
		internal static bool ConDataButtonIndexValid(global::AcpCommonLib.IAcpFeatureSection self, int index)
		{
			short num = (short)2060124160;
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
						if (index == 0)
						{
							num = (short)919994369;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_BDC;
					case 1:
						return false;
					case 2:
						try
						{
							num = (short)1085145136;
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
									global::Motorola.MackinawCPS.CoreFeatures.RadioWide.GeneralLightbarPatternInnerSection generalLightbarPatternInnerSection;
									flag = (generalLightbarPatternInnerSection.RadWideGenLightBarPatternRelay8_A36513.Value == 3);
									goto IL_7AB;
								}
								case 1:
									num = (short)106102802;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 2:
								{
									global::Motorola.MackinawCPS.CoreFeatures.RadioWide.GeneralLightbarPatternInnerSection generalLightbarPatternInnerSection;
									flag2 = (generalLightbarPatternInnerSection.RadWideGenLightBarPatternRelay5_A36510.Value == 3);
									goto IL_7EB;
								}
								case 3:
									goto IL_468;
								case 4:
									num = (short)1052377146;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 5:
								{
									global::Motorola.MackinawCPS.CoreFeatures.RadioWide.GeneralLightbarPatternInnerSection generalLightbarPatternInnerSection;
									flag3 = (generalLightbarPatternInnerSection.RadWideGenLightBarPatternRelay6_A36511.Value == 3);
									goto IL_AC6;
								}
								case 6:
									if (flag4)
									{
										num = (short)322109495;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									num = (short)1088225311;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 7:
									if (flag4)
									{
										num = (short)555417659;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									num = (short)848232463;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 8:
								{
									global::Motorola.MackinawCPS.CoreFeatures.RadioWide.RadioWideRecset radioWideRecset;
									if (radioWideRecset != null)
									{
										num = (short)55640077;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									goto IL_595;
								}
								case 9:
								{
									global::Motorola.MackinawCPS.CoreFeatures.RadioWide.GeneralLightbarPatternInnerSection generalLightbarPatternInnerSection;
									flag5 = (generalLightbarPatternInnerSection.RadWideGenLightBarPatternRelay4_A36509.Value == 3);
									goto IL_9B3;
								}
								case 10:
									if (flag4)
									{
										num = (short)967639073;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									num = (short)663224370;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 11:
									num = (short)1868693504;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 12:
								{
									global::Motorola.MackinawCPS.CoreFeatures.RadioWide.GeneralLightbarPatternInnerRecset generalLightbarPatternInnerRecset;
									int num3;
									if (generalLightbarPatternInnerRecset.Count > num3)
									{
										num = (short)786890804;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									goto IL_595;
								}
								case 13:
								{
									global::Motorola.MackinawCPS.CoreFeatures.RadioWide.RadioWideRecset radioWideRecset;
									global::Motorola.MackinawCPS.CoreFeatures.RadioWide.GeneralLightbarPatternInnerRecset generalLightbarPatternInnerRecset = radioWideRecset[0][10604].EmbeddedRecset as global::Motorola.MackinawCPS.CoreFeatures.RadioWide.GeneralLightbarPatternInnerRecset;
									num = (short)2139095052;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 14:
								{
									global::Motorola.MackinawCPS.CoreFeatures.RadioWide.GeneralLightbarPatternInnerSection generalLightbarPatternInnerSection;
									flag6 = (generalLightbarPatternInnerSection.RadWideGenLightBarPatternRelay7_A36512.Value == 3);
									goto IL_4DC;
								}
								case 15:
									flag5 = false;
									goto IL_9B3;
								case 16:
									num = (short)1614675998;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 17:
									num = (short)1974796325;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 18:
								{
									global::Motorola.MackinawCPS.CoreFeatures.RadioWide.GeneralLightbarPatternInnerSection generalLightbarPatternInnerSection;
									flag7 = (generalLightbarPatternInnerSection.RadWideGenLightBarPatternRelay10_A36516.Value == 3);
									goto IL_3DB;
								}
								case 19:
									if (flag4)
									{
										num = (short)989003822;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									num = (short)1975058471;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 20:
									if (flag4)
									{
										num = (short)1346371595;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									num = (short)674824224;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 21:
								{
									global::Motorola.MackinawCPS.CoreFeatures.RadioWide.GeneralLightbarPatternInner generalLightbarPatternInner;
									global::Motorola.MackinawCPS.CoreFeatures.RadioWide.GeneralLightbarPatternInnerSection generalLightbarPatternInnerSection = generalLightbarPatternInner.GeneralLightbarPatternInnerSection;
									flag4 = (generalLightbarPatternInnerSection.RadWideGenLightBarPatternRelay1_A36506.Value == 3);
									num = (short)815136774;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 22:
								{
									global::Motorola.MackinawCPS.CoreFeatures.RadioWide.GeneralLightbarPatternInnerSection generalLightbarPatternInnerSection;
									flag8 = (generalLightbarPatternInnerSection.RadWideGenLightBarPatternRelay9_A36515.Value == 3);
									goto IL_A21;
								}
								case 23:
								{
									global::Motorola.MackinawCPS.CoreFeatures.RadioWide.GeneralLightbarPatternInnerSection generalLightbarPatternInnerSection;
									flag9 = (generalLightbarPatternInnerSection.RadWideGenLightBarPatternRelay2_A36507.Value == 3);
									goto IL_977;
								}
								case 24:
									flag2 = false;
									goto IL_7EB;
								case 25:
								{
									global::Motorola.MackinawCPS.CoreFeatures.RadioWide.GeneralLightbarPatternInnerRecset generalLightbarPatternInnerRecset;
									int num3;
									global::Motorola.MackinawCPS.CoreFeatures.RadioWide.GeneralLightbarPatternInner generalLightbarPatternInner = generalLightbarPatternInnerRecset[num3] as global::Motorola.MackinawCPS.CoreFeatures.RadioWide.GeneralLightbarPatternInner;
									num = (short)1017577532;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 26:
								{
									global::AcpCommonLib.IAcpFeatureNode acpFeatureNode;
									if (index - 1 == (acpFeatureNode.Parent as global::AcpBusinessLayer.Recordset).IndexOf(acpFeatureNode))
									{
										num = (short)2059141137;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									break;
								}
								case 27:
								{
									global::Motorola.MackinawCPS.CoreFeatures.RadioWide.GeneralLightbarPatternInnerRecset generalLightbarPatternInnerRecset;
									int num3;
									if (generalLightbarPatternInnerRecset[num3] != null)
									{
										num = (short)1841233945;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									goto IL_595;
								}
								case 28:
								{
									global::AcpCommonLib.IAcpFeatureNode acpFeatureNode;
									if ((acpFeatureNode[10615] as global::Motorola.MackinawCPS.CoreFeatures.ActionConsolidation.General).RadioErgoConfigACSirenType_A36584.Value != 1)
									{
										num = (short)1369964560;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									goto IL_468;
								}
								case 29:
								{
									global::Motorola.MackinawCPS.CoreFeatures.RadioWide.GeneralLightbarPatternInnerSection generalLightbarPatternInnerSection;
									flag10 = (generalLightbarPatternInnerSection.RadWideGenLightBarPatternRelay3_A36508.Value == 3);
									goto IL_855;
								}
								case 30:
								{
									global::AcpCommonLib.IAcpFeatureNode acpFeatureNode;
									if ((acpFeatureNode[10615] as global::Motorola.MackinawCPS.CoreFeatures.ActionConsolidation.General).RadioErgoConfigACSirenType_A36584.Value == 7)
									{
										num = (short)1407057923;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									result = false;
									num = (short)533987379;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 31:
									flag9 = false;
									goto IL_977;
								case 32:
									flag = false;
									goto IL_7AB;
								case 33:
									num = (short)125370373;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 34:
									flag10 = false;
									goto IL_855;
								case 35:
									if (flag4)
									{
										num = (short)1060438017;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									num = (short)1255997493;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 36:
									num = (short)752156700;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 37:
								{
									global::AcpCommonLib.IAcpFeatureNode acpFeatureNode;
									if ((acpFeatureNode[10615] as global::Motorola.MackinawCPS.CoreFeatures.ActionConsolidation.General).RadioErgoConfigACActionType_A42871.Value == 0)
									{
										num = (short)1443102765;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									goto IL_574;
								}
								case 38:
									if (flag4)
									{
										num = (short)738656312;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									num = (short)537329688;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 39:
									flag8 = false;
									goto IL_A21;
								case 41:
									goto IL_595;
								case 42:
								{
									global::AcpCommonLib.IAcpFeatureNode acpFeatureNode;
									if ((acpFeatureNode[10615] as global::Motorola.MackinawCPS.CoreFeatures.ActionConsolidation.General).RadioErgoConfigACRelayPattern_A36582.Value <= 0)
									{
										num = (short)1717239851;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									int num3 = (acpFeatureNode[10615] as global::Motorola.MackinawCPS.CoreFeatures.ActionConsolidation.General).RadioErgoConfigACRelayPattern_A36582.Value - 1;
									flag4 = false;
									global::Motorola.MackinawCPS.CoreFeatures.RadioWide.RadioWideRecset radioWideRecset = global::AcpCommonLib.FeatureManager.GetFeature(2045) as global::Motorola.MackinawCPS.CoreFeatures.RadioWide.RadioWideRecset;
									num = (short)1079509000;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 43:
									result = false;
									num = (short)1667366952;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 44:
								{
									if (!enumerator.MoveNext())
									{
										num = (short)124583940;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									global::AcpCommonLib.IAcpFeatureNode acpFeatureNode = enumerator.Current;
									num = (short)392822810;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 45:
									num = (short)1694302262;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 46:
									num = (short)1186332694;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 48:
									switch (0)
									{
									case 0:
										goto IL_1D8;
									}
									continue;
								case 50:
									flag3 = false;
									goto IL_AC6;
								case 52:
									num = (short)1677000731;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 53:
									flag7 = false;
									goto IL_3DB;
								case 54:
								{
									global::AcpCommonLib.IAcpFeatureNode acpFeatureNode;
									if ((acpFeatureNode[10615] as global::Motorola.MackinawCPS.CoreFeatures.ActionConsolidation.General).RadioErgoConfigACGeneralActionAllowed_A36579.Value)
									{
										num = (short)1100283940;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									goto IL_574;
								}
								case 55:
									num = (short)1283588119;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 56:
									num = (short)1558839298;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 57:
									flag6 = false;
									goto IL_4DC;
								case 58:
									goto IL_B20;
								case 59:
									num = (short)1291780105;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 60:
								{
									global::Motorola.MackinawCPS.CoreFeatures.RadioWide.GeneralLightbarPatternInner generalLightbarPatternInner;
									if (generalLightbarPatternInner != null)
									{
										num = (short)510459925;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									goto IL_595;
								}
								case 61:
									if (flag4)
									{
										num = (short)1145307199;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									num = (short)1568145465;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 62:
									if (flag4)
									{
										num = (short)1438515264;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									num = (short)658833442;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 63:
									num = (short)721747982;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 64:
									num = (short)1646526493;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								goto IL_1D8;
								IL_3DB:
								flag4 = flag7;
								num = (short)316669993;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								IL_428:
								num = (short)1772290092;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								IL_1D8:
								goto IL_428;
								IL_468:
								num = (short)1555759146;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								IL_4DC:
								flag4 = flag6;
								num = (short)1308229652;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								IL_574:
								result = false;
								num = (short)2000945201;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								IL_595:
								result = flag4;
								num = (short)1311244335;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								IL_7AB:
								flag4 = flag;
								num = (short)69992467;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								IL_7EB:
								flag4 = flag2;
								num = (short)482082826;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								IL_855:
								flag4 = flag10;
								num = (short)1807613959;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								IL_977:
								flag4 = flag9;
								num = (short)222887998;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								IL_9B3:
								flag4 = flag5;
								num = (short)695730214;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								IL_A21:
								flag4 = flag8;
								num = (short)1103757347;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								IL_AC6:
								flag4 = flag3;
								num = (short)1759969341;
								num2 = (int)((global::System.IntPtr)num);
							}
							IL_B20:
							return result;
						}
						finally
						{
							num = (short)1615819877;
							short num4 = num;
							num = (short)1771992165;
							switch ((num4 == num) ? 1 : 0)
							{
							case 0:
							case 2:
								IL_BBE:
								enumerator.Dispose();
								num = (short)1420296192;
								num2 = (int)((global::System.IntPtr)num);
								break;
							default:
								num = (short)516030464;
								if (num != 0)
								{
								}
								num = (short)362151937;
								num2 = (int)((global::System.IntPtr)num);
								break;
							}
							for (;;)
							{
								switch (num2)
								{
								case 0:
									goto IL_BD9;
								case 1:
									switch (0)
									{
									case 0:
										goto IL_BA4;
									}
									continue;
								case 2:
									goto IL_BBC;
								}
								IL_BA4:
								if (enumerator == null)
								{
									goto IL_BDB;
								}
								num = (short)292356098;
								num2 = (int)((global::System.IntPtr)num);
							}
							IL_BBC:
							goto IL_BBE;
							IL_BD9:
							IL_BDB:;
						}
						goto IL_BDC;
					}
					goto IL_3C;
					IL_BDC:
					enumerator = actionConsolidationRecset.GetEnumerator();
					num = (short)1901395969;
					if (num != 0)
					{
					}
					num = (short)1624702978;
					num2 = (int)((global::System.IntPtr)num);
				}
				return false;
				IL_3C:
				num = (short)1638268928;
				short num5 = num;
				actionConsolidationRecset = (global::AcpCommonLib.FeatureManager.GetFeature(4008) as global::Motorola.MackinawCPS.CoreFeatures.ActionConsolidation.ActionConsolidationRecset);
				result = true;
				num = (short)2018050048;
				num2 = (int)((global::System.IntPtr)num);
				goto IL_29;
			}
			}
		}

		// Token: 0x06007B42 RID: 31554 RVA: 0x0070D65C File Offset: 0x0070B85C
		internal static bool conDataBtnTrkFeatureValid(global::AcpCommonLib.IAcpFeatureSection self, int index)
		{
			switch (0)
			{
			case 0:
				goto IL_A0;
			}
			int num;
			short num2;
			global::AcpBusinessLayer.AcpListField acpListField;
			int featureSectionId;
			for (;;)
			{
				IL_0A:
				global::Motorola.MackinawCPS.CoreFeatures.RadioWide.RadioWide radioWide;
				switch (num)
				{
				case 0:
					goto IL_5BB;
				case 1:
					if (index != 227)
					{
						num2 = (short)1517879314;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					return false;
				case 2:
					goto IL_237;
				case 3:
					num2 = (short)672464903;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 4:
					num2 = (short)1137573922;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 5:
					if (acpListField != null)
					{
						num2 = (short)509280277;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					return true;
				case 6:
					if (featureSectionId != 10212)
					{
						num2 = (short)348323844;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					acpListField = (self as global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO3.DataButtonInnerSection).CntrlHeadO3ConventionalO3DatatButtonFeature_A22595;
					num2 = (short)966787096;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 7:
					if (featureSectionId != 10713)
					{
						num2 = (short)691601428;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					acpListField = (self as global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO7.O7DataButtonInnerSection).RadErgCtrlHeadO7DataButtonCnvFeature_A41299;
					num2 = (short)1825964063;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 8:
					if (acpListField.Value == 140)
					{
						num2 = (short)1985544192;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					num2 = (short)50331663;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 9:
					goto IL_180;
				case 10:
					if (acpListField.Value == 227)
					{
						num2 = (short)1278345251;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					num2 = (short)1522204680;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 11:
					num2 = (short)487260161;
					if (num2 != 0)
					{
					}
					if (featureSectionId <= 10212)
					{
						num2 = (short)348717078;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					num2 = (short)83886108;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 12:
					goto IL_453;
				case 13:
					goto IL_453;
				case 14:
					if (featureSectionId != 10209)
					{
						num2 = (short)2038759443;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					acpListField = (self as global::Motorola.MackinawCPS.CoreFeatures.KeypadMicAndAccessories.DataButtonInnerSection).RadErgoCfgKMConventionalKMDatatButtonFeature_A22603;
					num2 = (short)1452605452;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 15:
					if (acpListField.Value == 228)
					{
						num2 = (short)786300954;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					num2 = (short)59703323;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 16:
					goto IL_3FC;
				case 17:
					if (radioWide.DualRadio.RadWideDualRadioSelection_A42236.Value != 0)
					{
						num2 = (short)1491861513;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					num2 = (short)237568001;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 18:
					goto IL_649;
				case 19:
					num2 = (short)1623654406;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 20:
					num2 = (short)1262878733;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 21:
					num2 = (short)879886346;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 22:
					goto IL_10A;
				case 23:
					if (index != 227)
					{
						num2 = (short)1244332048;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					return false;
				case 24:
					goto IL_453;
				case 25:
					if (index != 227)
					{
						num2 = (short)1102839810;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					return false;
				case 26:
					num2 = (short)2133590033;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 27:
					if (radioWide.DualRadio.RadWideDualRadioSelection_A42236.Value != 0)
					{
						num2 = (short)1350041633;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					num2 = (short)207159321;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 28:
					if (featureSectionId != 10608)
					{
						num2 = (short)1260453891;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					acpListField = (self as global::Motorola.MackinawCPS.CoreFeatures.ControlHeadO9.O9DataButtonInnerSection).RadErgCtrlHeadO9DataButtonCnvFeature_A36528;
					num2 = (short)512688158;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 29:
					num2 = (short)1165426711;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 30:
				{
					num2 = (short)895528355;
					short num3 = num2;
					num2 = (short)224701859;
					switch ((num3 == num2) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_10A;
					default:
						num2 = (short)1109065728;
						if (num2 != 0)
						{
						}
						goto IL_453;
					}
					break;
				}
				case 31:
					goto IL_453;
				case 32:
					if (index != 228)
					{
						num2 = (short)884015133;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					return false;
				case 33:
					num2 = (short)1437204512;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 34:
					goto IL_453;
				case 35:
					goto IL_2EC;
				}
				goto IL_A0;
				IL_10A:
				num2 = (short)2132410368;
				short num4 = num2;
				num2 = (short)627245070;
				num = (int)((global::System.IntPtr)num2);
				continue;
				IL_453:
				radioWide = (global::AcpCommonLib.FeatureManager.GetFeature(2045)[0] as global::Motorola.MackinawCPS.CoreFeatures.RadioWide.RadioWide);
				num2 = (short)480706565;
				num = (int)((global::System.IntPtr)num2);
			}
			return false;
			IL_180:
			return index == 228;
			IL_237:
			return index != 140;
			IL_2EC:
			return index == 227;
			IL_3FC:
			return index != 140;
			IL_5BB:
			return index == 140;
			IL_649:
			return index != 140;
			IL_A0:
			acpListField = null;
			featureSectionId = self.FeatureSectionId;
			num2 = (short)826605579;
			num = (int)((global::System.IntPtr)num2);
			goto IL_0A;
		}

		// Token: 0x06007B43 RID: 31555 RVA: 0x0070DCB8 File Offset: 0x0070BEB8
		private static bool a(int A_0)
		{
			short num = (short)1691942912;
			short num2 = num;
			num = (short)976598974;
			short num3 = num;
			num = (short)1013102526;
			switch (num3 == num)
			{
			}
			num = (short)1382875137;
			if (num != 0)
			{
			}
			num = (short)177995776;
			if (num != 0)
			{
			}
			return global::System.Array.IndexOf<int>(new int[]
			{
				212,
				209,
				236,
				211,
				235,
				210,
				212,
				209,
				236,
				211,
				235,
				210
			}, A_0) > -1;
		}

		// Token: 0x06007B44 RID: 31556 RVA: 0x0070DD80 File Offset: 0x0070BF80
		private static bool a()
		{
			short num = (short)1981387610;
			short num2 = num;
			num = (short)244487002;
			int num3;
			switch ((num2 == num) ? 1 : 0)
			{
			case 0:
			case 2:
				IL_149:
				num = (short)1841430529;
				num3 = (int)((global::System.IntPtr)num);
				break;
			default:
				num = (short)47775744;
				if (num != 0)
				{
				}
				switch (0)
				{
				case 0:
					goto IL_6D;
				}
				break;
			}
			global::Motorola.MackinawCPS.CoreFeatures.RadioInformation.RadioInformationRecset radioInformationRecset;
			for (;;)
			{
				IL_53:
				switch (num3)
				{
				case 0:
					if (radioInformationRecset != null)
					{
						num = (short)168099841;
						if (num != 0)
						{
						}
						num = (short)1766850564;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					}
					return true;
				case 1:
					goto IL_160;
				case 2:
					goto IL_EB;
				case 3:
					if (radioInformationRecset.Count == 0)
					{
						goto IL_149;
					}
					num = (short)654835714;
					num3 = (int)((global::System.IntPtr)num);
					continue;
				case 4:
				{
					num = (short)614072320;
					short num4 = num;
					num = (short)710934531;
					num3 = (int)((global::System.IntPtr)num);
					continue;
				}
				}
				goto IL_6D;
			}
			IL_EB:
			global::Motorola.MackinawCPS.CoreFeatures.RadioInformation.RadioInformation radioInformation = radioInformationRecset[0] as global::Motorola.MackinawCPS.CoreFeatures.RadioInformation.RadioInformation;
			return radioInformation != null && !radioInformation.Labtool.RadInfoLabtoolDualRadioOperation_A42245.Value;
			IL_160:
			return true;
			IL_6D:
			radioInformationRecset = (global::AcpCommonLib.FeatureManager.GetFeature(2049) as global::Motorola.MackinawCPS.CoreFeatures.RadioInformation.RadioInformationRecset);
			num = (short)1610088448;
			num3 = (int)((global::System.IntPtr)num);
			goto IL_53;
		}

		// Token: 0x06007B45 RID: 31557 RVA: 0x0070DF04 File Offset: 0x0070C104
		internal static void ConSyncCnvKMBtnFeature(global::AcpCommonLib.IAcpFeatureSection self, global::AcpCommonLib.UndoRedo.ContainerTask task)
		{
			switch (0)
			{
			case 0:
				goto IL_78;
			}
			int num;
			short num2;
			global::Motorola.MackinawCPS.CoreFeatures.KeypadMicAndAccessories.KMButtonInnerSection kmbuttonInnerSection;
			for (;;)
			{
				IL_0A:
				switch (num)
				{
				case 0:
					goto IL_F5;
				case 1:
				{
					num2 = (short)138485464;
					short num3 = num2;
					num2 = (short)1270161112;
					switch ((num3 == num2) ? 1 : 0)
					{
					case 0:
					case 2:
						break;
					default:
					{
						num2 = (short)1854865408;
						short num4 = num2;
						num2 = (short)1649934336;
						if (num2 != 0)
						{
						}
						if (kmbuttonInnerSection.RadErgoCfgKMConventionalKMButtonFeature_A19646.Value != 125)
						{
							num2 = (short)1970470914;
							num = (int)((global::System.IntPtr)num2);
							continue;
						}
						goto IL_FA;
					}
					}
					break;
				}
				case 2:
					num2 = (short)906362903;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 3:
					if (kmbuttonInnerSection != null)
					{
						num2 = (short)983957519;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					return;
				case 4:
					if (!global::Motorola.MackinawCPS.CoreFeatures.KeypadMicAndAccessories.KeypadMicAndAccessoriesConstraints.a(kmbuttonInnerSection.RadErgoCfgKMConventionalKMButtonFeature_A19646.Value))
					{
						num2 = (short)1405157386;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					return;
				case 5:
					task.AddTask(new global::AcpBusinessLayer.UndoRedo.ModifyDataTask<int>(kmbuttonInnerSection.RadErgoCfgKMTrunkingKMButtonFeature_A19746, 140));
					num2 = (short)1700528135;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 6:
					num2 = (short)1017708545;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 7:
					goto IL_16E;
				case 8:
					num2 = (short)1665007629;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 9:
					if (global::Motorola.MackinawCPS.CoreFeatures.KeypadMicAndAccessories.KeypadMicAndAccessoriesConstraints.a(kmbuttonInnerSection.RadErgoCfgKMTrunkingKMButtonFeature_A19746.Value))
					{
						num2 = (short)1380319252;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					return;
				case 10:
					num2 = (short)1587347465;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 11:
					if (kmbuttonInnerSection.RadErgoCfgKMConventionalKMButtonFeature_A19646.Value == 140)
					{
						num2 = (short)313458693;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_16E;
				case 12:
					goto IL_3C7;
				case 13:
					if (kmbuttonInnerSection.RadErgoCfgKMConventionalKMButtonFeature_A19646.Value != 70)
					{
						num2 = (short)12189710;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_FA;
				case 14:
					num2 = (short)1477312533;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 15:
					num2 = (short)620691467;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 16:
					if (global::Motorola.MackinawCPS.CoreFeatures.KeypadMicAndAccessories.KeypadMicAndAccessoriesConstraints.a(kmbuttonInnerSection.RadErgoCfgKMConventionalKMButtonFeature_A19646.Value))
					{
						num2 = (short)444989465;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_1B3;
				case 17:
					goto IL_FA;
				case 18:
					if (kmbuttonInnerSection.RefRadioWide.DualRadio.RadWideDualRadioSelection_A42236.Value == 0)
					{
						num2 = (short)919076876;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_22D;
				case 19:
					if (global::Motorola.MackinawCPS.CoreFeatures.KeypadMicAndAccessories.KeypadMicAndAccessoriesConstraints.a())
					{
						num2 = (short)2094006272;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_1B3;
				case 20:
					task.AddTask(new global::AcpBusinessLayer.UndoRedo.ModifyDataTask<int>(kmbuttonInnerSection.RadErgoCfgKMTrunkingKMButtonFeature_A19746, 35));
					num2 = (short)279248920;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 21:
					if (kmbuttonInnerSection.RadErgoCfgKMConventionalKMButtonFeature_A19646.Value == 228)
					{
						num2 = (short)1070137361;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_3C7;
				case 22:
					if (kmbuttonInnerSection.RadErgoCfgKMConventionalKMButtonFeature_A19646.Value != 124)
					{
						num2 = (short)206635014;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_FA;
				case 23:
					if (kmbuttonInnerSection.RadErgoCfgKMConventionalKMButtonFeature_A19646.Value != 126)
					{
						num2 = (short)321191944;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_FA;
				case 24:
					return;
				case 25:
					num2 = (short)1204224019;
					num = (int)((global::System.IntPtr)num2);
					continue;
				}
				goto IL_78;
				IL_FA:
				num2 = (short)1202388993;
				if (num2 != 0)
				{
				}
				num2 = (short)1101856786;
				num = (int)((global::System.IntPtr)num2);
				continue;
				IL_16E:
				num2 = (short)286130198;
				num = (int)((global::System.IntPtr)num2);
				continue;
				IL_1B3:
				num2 = (short)722337796;
				num = (int)((global::System.IntPtr)num2);
				continue;
				IL_3C7:
				num2 = (short)1440284688;
				num = (int)((global::System.IntPtr)num2);
			}
			IL_F5:
			IL_22D:
			task.AddTask(new global::AcpBusinessLayer.UndoRedo.ModifyDataTask<int>(kmbuttonInnerSection.RadErgoCfgKMTrunkingKMButtonFeature_A19746, kmbuttonInnerSection.RadErgoCfgKMConventionalKMButtonFeature_A19646.Value));
			return;
			IL_78:
			kmbuttonInnerSection = (self as global::Motorola.MackinawCPS.CoreFeatures.KeypadMicAndAccessories.KMButtonInnerSection);
			num2 = (short)1767374851;
			num = (int)((global::System.IntPtr)num2);
			goto IL_0A;
		}

		// Token: 0x06007B46 RID: 31558 RVA: 0x0070E3F8 File Offset: 0x0070C5F8
		internal static void ConSyncTrkKMBtnFeature(global::AcpCommonLib.IAcpFeatureSection self, global::AcpCommonLib.UndoRedo.ContainerTask task)
		{
			switch (0)
			{
			case 0:
				goto IL_58;
			}
			int num;
			global::Motorola.MackinawCPS.CoreFeatures.KeypadMicAndAccessories.KMButtonInnerSection kmbuttonInnerSection;
			short num2;
			for (;;)
			{
				IL_0A:
				switch (num)
				{
				case 0:
					if (kmbuttonInnerSection.RadErgoCfgKMTrunkingKMButtonFeature_A19746.Value != 125)
					{
						num2 = (short)1628241923;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_156;
				case 1:
					if (kmbuttonInnerSection.RadErgoCfgKMTrunkingKMButtonFeature_A19746.Value == 140)
					{
						num2 = (short)1279328268;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_321;
				case 2:
					goto IL_156;
				case 3:
					num2 = (short)288686094;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 4:
					goto IL_321;
				case 5:
					num2 = (short)1014235142;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 6:
					if (kmbuttonInnerSection.RadErgoCfgKMTrunkingKMButtonFeature_A19746.Value != 70)
					{
						num2 = (short)728694792;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_156;
				case 7:
					if (kmbuttonInnerSection != null)
					{
						num2 = (short)1691811851;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					return;
				case 8:
				{
					num2 = (short)1395356114;
					short num3 = num2;
					num2 = (short)1047425490;
					switch ((num3 == num2) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_375;
					default:
						num2 = (short)1994326016;
						if (num2 != 0)
						{
						}
						num2 = (short)2087190538;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					break;
				}
				case 9:
					if (kmbuttonInnerSection.RefRadioWide.DualRadio.RadWideDualRadioSelection_A42236.Value != 0)
					{
						num2 = (short)604962832;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					return;
				case 10:
					if (kmbuttonInnerSection.RadErgoCfgKMTrunkingKMButtonFeature_A19746.Value == 228)
					{
						num2 = (short)861995010;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					return;
				case 11:
					num2 = (short)2042953729;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 12:
					task.AddTask(new global::AcpBusinessLayer.UndoRedo.ModifyDataTask<int>(kmbuttonInnerSection.RadErgoCfgKMConventionalKMButtonFeature_A19646, 140));
					num2 = (short)82903044;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 13:
					if (kmbuttonInnerSection.RadErgoCfgKMTrunkingKMButtonFeature_A19746.Value != 124)
					{
						goto IL_375;
					}
					goto IL_156;
				case 14:
					if (kmbuttonInnerSection.RadErgoCfgKMTrunkingKMButtonFeature_A19746.Value != 126)
					{
						num2 = (short)970588165;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_156;
				case 15:
					num2 = (short)68550656;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 16:
					task.AddTask(new global::AcpBusinessLayer.UndoRedo.ModifyDataTask<int>(kmbuttonInnerSection.RadErgoCfgKMConventionalKMButtonFeature_A19646, kmbuttonInnerSection.RadErgoCfgKMTrunkingKMButtonFeature_A19746.Value));
					num2 = (short)1434386433;
					if (num2 != 0)
					{
					}
					num2 = (short)843317265;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 17:
					return;
				}
				goto IL_58;
				IL_156:
				num2 = (short)1434058761;
				num = (int)((global::System.IntPtr)num2);
				continue;
				IL_321:
				num2 = (short)357498880;
				short num4 = num2;
				num2 = (short)870776845;
				num = (int)((global::System.IntPtr)num2);
				continue;
				IL_375:
				num2 = (short)688652303;
				num = (int)((global::System.IntPtr)num2);
			}
			return;
			IL_58:
			kmbuttonInnerSection = (self as global::Motorola.MackinawCPS.CoreFeatures.KeypadMicAndAccessories.KMButtonInnerSection);
			num2 = (short)1527644167;
			num = (int)((global::System.IntPtr)num2);
			goto IL_0A;
		}

		// Token: 0x06007B47 RID: 31559 RVA: 0x0070E798 File Offset: 0x0070C998
		internal static bool ConKMTrunkingButtonIsValid(global::AcpCommonLib.IAcpFeatureSection self, int index)
		{
			short num = (short)1539899392;
			int num2 = (int)num;
			switch (num2)
			{
			default:
			{
				switch (0)
				{
				case 0:
					goto IL_16B;
				}
				global::Motorola.MackinawCPS.CoreFeatures.EmergencyWide.EmergencyWide emergencyWide;
				bool flag;
				global::Motorola.MackinawCPS.CoreFeatures.KeypadMicAndAccessories.KMButtonInnerSection kmbuttonInnerSection;
				int num3;
				global::AcpBusinessLayer.AcpListField radErgoWideControlHeadMultipleControlHeadStyle_A;
				global::Motorola.MackinawCPS.CoreFeatures.RadioWide.Features features;
				global::AcpBusinessLayer.AcpField<bool> radErgoWideControlHeadMultiControlHead_A;
				global::Motorola.MackinawCPS.CoreFeatures.TrunkingEmergencyProfiles.TrunkingEmergencyProfilesRecset trunkingEmergencyProfilesRecset;
				for (;;)
				{
					IL_28:
					bool flag2;
					bool flag3;
					bool flag4;
					switch (num2)
					{
					case 0:
						if (index != 217)
						{
							num = (short)2118516791;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						flag = (emergencyWide.EmergencyWideImpactDetection.EmerWideImpactDetectionConfigLevel_A43384.Value != 0);
						num = (short)1069678599;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 1:
						flag2 = false;
						goto IL_A9E;
					case 2:
						if (kmbuttonInnerSection.RefRadioWide.DualRadio.RadWideDualRadioSelection_A42236.Value != 0)
						{
							num = (short)946143273;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_94D;
					case 3:
						if (index != 140)
						{
							num = (short)598474830;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)2058092605;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 4:
						num = (short)1748434963;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 5:
						num = (short)1536884812;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 6:
						if (index != 70)
						{
							num = (short)1078657032;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_595;
					case 7:
						goto IL_2F9;
					case 8:
						goto IL_8AC;
					case 9:
						num = (short)1036386342;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 10:
						num = (short)1511915582;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 11:
						if (kmbuttonInnerSection.RadErgoCfgKMConventionalKMButtonFeature_A19646.Value != index)
						{
							num = (short)795017267;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_54A;
					case 12:
						num = (short)1384906776;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 13:
						goto IL_2F9;
					case 14:
						flag3 = true;
						goto IL_8E9;
					case 15:
						if (num3 == 0)
						{
							num = (short)2056192071;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_94D;
					case 16:
						return false;
					case 17:
						flag3 = (kmbuttonInnerSection.RadErgoCfgKMTrunkingKMButtonBCO_A19745.Value == 144);
						goto IL_8E9;
					case 18:
						num = (short)1801060352;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 19:
						if (index == 126)
						{
							num = (short)1685258266;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_94D;
					case 20:
						if (!global::Motorola.MackinawCPS.CoreFeatures.KeypadMicAndAccessories.KeypadMicAndAccessoriesConstraints.a(kmbuttonInnerSection.RadErgoCfgKMConventionalKMButtonFeature_A19646.Value))
						{
							num = (short)74579973;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_A5D;
					case 21:
						flag2 = (radErgoWideControlHeadMultipleControlHeadStyle_A.Value == 0);
						goto IL_A9E;
					case 22:
						goto IL_6AE;
					case 23:
						num = (short)2143092804;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 24:
						if (index != 126)
						{
							num = (short)697106488;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_39B;
					case 25:
						if (index != 124)
						{
							num = (short)2040397833;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_595;
					case 26:
						goto IL_595;
					case 27:
						num = (short)2146238534;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 28:
						if (index != 31)
						{
							num = (short)1578500156;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_595;
					case 29:
						goto IL_2F9;
					case 30:
					{
						num = (short)1921777664;
						short num4 = num;
						num = (short)1149698094;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 31:
						if (index - 290 > 1)
						{
							num = (short)1177878561;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)711196673;
						if (num != 0)
						{
						}
						flag = features.RadWideFeaturesChannelFallbackEnableValue;
						num = (short)1454309416;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 32:
						if (!radErgoWideControlHeadMultiControlHead_A.Value)
						{
							num = (short)1605697578;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)2033385520;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 33:
						num = (short)953876537;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 34:
						if (index != 124)
						{
							num = (short)1435435018;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_39B;
					case 35:
						if (radErgoWideControlHeadMultiControlHead_A.Value)
						{
							num = (short)607125570;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)1667301377;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 36:
						num = (short)970457099;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 37:
						goto IL_39B;
					case 38:
						if (index != 125)
						{
							num = (short)2055143428;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_595;
					case 39:
						num = (short)354156617;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 40:
						goto IL_2F9;
					case 41:
						num = (short)675676175;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 42:
						goto IL_B4A;
					case 43:
						num = (short)229965855;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 44:
						try
						{
							num = (short)33319861;
							short num5 = num;
							num = (short)86076341;
							switch ((num5 == num) ? 1 : 0)
							{
							case 0:
							case 2:
								IL_81D:
								flag = true;
								num = (short)319029249;
								num2 = (int)((global::System.IntPtr)num);
								break;
							default:
								num = (short)720240640;
								if (num != 0)
								{
								}
								num = (short)394133506;
								num2 = (int)((global::System.IntPtr)num);
								break;
							}
							for (;;)
							{
								switch (num2)
								{
								case 0:
								{
									global::System.Collections.Generic.IEnumerator<global::AcpBusinessLayer.FeatureNode> enumerator;
									if (((global::Motorola.MackinawCPS.CoreFeatures.TrunkingEmergencyProfiles.TrunkingEmergencyProfiles)enumerator.Current).EmergencyCompatibilityOptionsTrunking.EmergencyExitControl_43341.Value == 3)
									{
										num = (short)2069168132;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									break;
								}
								case 2:
									switch (0)
									{
									case 0:
										goto IL_77A;
									}
									continue;
								case 3:
									num = (short)1384316933;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 4:
									goto IL_81D;
								case 5:
									goto IL_83A;
								case 6:
								{
									global::System.Collections.Generic.IEnumerator<global::AcpBusinessLayer.FeatureNode> enumerator;
									if (!enumerator.MoveNext())
									{
										num = (short)1687355395;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									num = (short)105971712;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								}
								IL_796:
								num = (short)1527578630;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								IL_77A:
								goto IL_796;
							}
							IL_83A:
							goto IL_9F2;
						}
						finally
						{
							num = (short)316473345;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								global::System.Collections.Generic.IEnumerator<global::AcpBusinessLayer.FeatureNode> enumerator;
								switch (num2)
								{
								case 0:
									goto IL_8A9;
								case 1:
									switch (0)
									{
									case 0:
										goto IL_871;
									}
									continue;
								case 2:
									enumerator.Dispose();
									num = (short)1090453504;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								IL_871:
								if (enumerator == null)
								{
									break;
								}
								num = (short)1057488898;
								num2 = (int)((global::System.IntPtr)num);
							}
							IL_8A9:;
						}
						goto IL_8AC;
						IL_9F2:
						num = (short)1725104195;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 45:
						goto IL_2F9;
					case 46:
						if (global::Motorola.MackinawCPS.CoreFeatures.KeypadMicAndAccessories.KeypadMicAndAccessoriesConstraints.a())
						{
							num = (short)803864592;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_A5D;
					case 47:
					{
						if (index != 266)
						{
							num = (short)142278695;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						flag = false;
						global::System.Collections.Generic.IEnumerator<global::AcpBusinessLayer.FeatureNode> enumerator = trunkingEmergencyProfilesRecset.GetEnumerator();
						num = (short)1761673260;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 48:
						flag4 = true;
						goto IL_C33;
					case 49:
						if (index != 163)
						{
							num = (short)1561985042;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)1329528904;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 50:
						if (index != 70)
						{
							num = (short)1191051333;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_39B;
					case 51:
						return false;
					case 52:
						flag = false;
						num = (short)1803223069;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 53:
						num = (short)1384316960;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 54:
						if (kmbuttonInnerSection.RefRadioWide.DualRadio.RadWideDualRadioSelection_A42236.Value != 0)
						{
							num = (short)516882468;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_54A;
					case 55:
						num = (short)848298061;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 56:
						num = (short)30408754;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 57:
						goto IL_2F9;
					case 58:
						if (kmbuttonInnerSection.RadErgoCfgKMTrunkingKMButtonBCO_A19745.Value != 146)
						{
							num = (short)1464139803;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_5E5;
					case 59:
						if (index == 228)
						{
							num = (short)614924325;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_54A;
					case 60:
						num = (short)1746075654;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 61:
						goto IL_6DB;
					case 62:
						if (index != 125)
						{
							num = (short)1614675980;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_39B;
					case 63:
						flag4 = !radErgoWideControlHeadMultiControlHead_A.Value;
						goto IL_C33;
					case 64:
						goto IL_2F9;
					case 65:
						if (index <= 217)
						{
							num = (short)372113431;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)1069285423;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 66:
						num = (short)1203699733;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 67:
						if (kmbuttonInnerSection.RadErgoCfgKMTrunkingKMButtonBCO_A19745.Value != 145)
						{
							num = (short)1399849012;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_2F9;
					case 68:
						if (index != 138)
						{
							num = (short)203751498;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)997195811;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 69:
						num = (short)1730740283;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 70:
						if (kmbuttonInnerSection.RadErgoCfgKMTrunkingKMButtonBCO_A19745.Value != 145)
						{
							num = (short)2100559947;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_5E5;
					case 71:
						return false;
					case 72:
						if (radErgoWideControlHeadMultipleControlHeadStyle_A.Value == 1)
						{
							num = (short)32636981;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_B4A;
					case 73:
						if (index != 267)
						{
							num = (short)69599275;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)1307443258;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 74:
						num = (short)27918385;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 75:
						num = (short)196542481;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 76:
						if (global::Motorola.MackinawCPS.CoreFeatures.KeypadMicAndAccessories.KeypadMicAndAccessoriesConstraints.a(index))
						{
							num = (short)295567390;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_A5D;
					case 77:
						goto IL_2F9;
					case 78:
						num = (short)1545601046;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_16B;
					IL_2F9:
					num = (short)540213251;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_39B:
					num = (short)780599350;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_54A:
					num = (short)1000996884;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_595:
					num = (short)1084817410;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_5E5:
					num = (short)1952645134;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_8AC:
					num = (short)2047344665;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_8E9:
					flag = flag3;
					num = (short)1876885549;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_94D:
					num = (short)1130037282;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_A5D:
					num = (short)206569537;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_A9E:
					flag = flag2;
					num = (short)421855296;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_B4A:
					num = (short)12976191;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_C33:
					flag = flag4;
					num = (short)778043405;
					num2 = (int)((global::System.IntPtr)num);
				}
				return false;
				IL_6AE:
				global::AcpBusinessLayer.AcpListField radErgoCfgKMConventionalKMButtonFeature_A;
				bool flag5 = radErgoCfgKMConventionalKMButtonFeature_A.Value != 140;
				goto IL_EA2;
				IL_6DB:
				flag5 = (radErgoCfgKMConventionalKMButtonFeature_A.Value == 140);
				IL_EA2:
				bool flag6 = flag5;
				return flag && flag6;
				IL_16B:
				kmbuttonInnerSection = (self as global::Motorola.MackinawCPS.CoreFeatures.KeypadMicAndAccessories.KMButtonInnerSection);
				radErgoWideControlHeadMultipleControlHeadStyle_A = kmbuttonInnerSection.RefRadioErgonomicsWide.ControlHead.RadErgoWideControlHeadMultipleControlHeadStyle_A8561;
				radErgoCfgKMConventionalKMButtonFeature_A = kmbuttonInnerSection.RadErgoCfgKMConventionalKMButtonFeature_A19646;
				trunkingEmergencyProfilesRecset = (global::AcpCommonLib.FeatureManager.GetFeature(2076) as global::Motorola.MackinawCPS.CoreFeatures.TrunkingEmergencyProfiles.TrunkingEmergencyProfilesRecset);
				emergencyWide = (global::AcpCommonLib.FeatureManager.GetFeature(2032)[0] as global::Motorola.MackinawCPS.CoreFeatures.EmergencyWide.EmergencyWide);
				features = (global::AcpCommonLib.FeatureManager.GetFeature(2045)[0][10105] as global::Motorola.MackinawCPS.CoreFeatures.RadioWide.Features);
				radErgoWideControlHeadMultiControlHead_A = kmbuttonInnerSection.RefRadioErgonomicsWide.ControlHead.RadErgoWideControlHeadMultiControlHead_A8550;
				global::AcpCommonLib.IAcpFeatureNode parent = kmbuttonInnerSection.RadErgoCfgKMTrunkingKMButtonFeature_A19746.Parent.Parent;
				num3 = (parent.Parent as global::AcpBusinessLayer.Recordset).IndexOf(parent);
				flag = true;
				num = (short)865402908;
				num2 = (int)((global::System.IntPtr)num);
				goto IL_28;
			}
			}
		}

		// Token: 0x06007B48 RID: 31560 RVA: 0x0070F66C File Offset: 0x0070D86C
		internal static bool ConSetEditabilityTrkFeature(global::AcpCommonLib.IAcpFeatureSection self)
		{
			switch (0)
			{
			case 0:
				goto IL_20;
			}
			int num;
			short num2;
			global::Motorola.MackinawCPS.CoreFeatures.KeypadMicAndAccessories.KMButtonInnerSection kmbuttonInnerSection;
			for (;;)
			{
				IL_0A:
				switch (num)
				{
				case 0:
					goto IL_F0;
				case 1:
				{
					num2 = (short)1366841599;
					short num3 = num2;
					num2 = (short)1700223231;
					switch ((num3 == num2) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_C6;
					default:
						num2 = (short)417529856;
						if (num2 != 0)
						{
						}
						if (kmbuttonInnerSection == null)
						{
							num2 = (short)582877186;
							num = (int)((global::System.IntPtr)num2);
							continue;
						}
						num2 = (short)1573257219;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					break;
				}
				case 2:
					return true;
				case 3:
					goto IL_C6;
				}
				goto IL_20;
				IL_C6:
				if (!global::Motorola.MackinawCPS.CoreFeatures.KeypadMicAndAccessories.KeypadMicAndAccessoriesConstraints.a(kmbuttonInnerSection.RadErgoCfgKMConventionalKMButtonFeature_A19646.Value))
				{
					return true;
				}
				num2 = (short)440532992;
				num = (int)((global::System.IntPtr)num2);
			}
			return true;
			IL_F0:
			num2 = (short)679215105;
			if (num2 != 0)
			{
			}
			num2 = (short)1477050368;
			short num4 = num2;
			return !global::Motorola.MackinawCPS.CoreFeatures.KeypadMicAndAccessories.KeypadMicAndAccessoriesConstraints.a();
			IL_20:
			kmbuttonInnerSection = (self as global::Motorola.MackinawCPS.CoreFeatures.KeypadMicAndAccessories.KMButtonInnerSection);
			num2 = (short)830472193;
			num = (int)((global::System.IntPtr)num2);
			goto IL_0A;
		}

		// Token: 0x06007B49 RID: 31561 RVA: 0x0070F7C4 File Offset: 0x0070D9C4
		internal static bool conDataBtnConvFeatureValid(global::AcpCommonLib.IAcpFeatureSection self, int index)
		{
			int num;
			global::Motorola.MackinawCPS.CoreFeatures.RadioWide.RadioWide radioWide;
			short num2;
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
						if (radioWide.DualRadio.RadWideDualRadioSelection_A42236.Value == 0)
						{
							num2 = (short)851247105;
							num = (int)((global::System.IntPtr)num2);
							continue;
						}
						return true;
					case 1:
					{
						num2 = (short)2046136508;
						short num3 = num2;
						num2 = (short)273846460;
						switch ((num3 == num2) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_3E;
						case 1:
							break;
						default:
						{
							num2 = (short)855900160;
							short num4 = num2;
							break;
						}
						}
						num2 = (short)260243456;
						if (num2 != 0)
						{
						}
						num2 = (short)874840068;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					case 2:
						num2 = (short)1124990976;
						num = (int)((global::System.IntPtr)num2);
						continue;
					case 3:
						if (radioWide != null)
						{
							num2 = (short)1188954114;
							num = (int)((global::System.IntPtr)num2);
							continue;
						}
						return true;
					case 4:
						if (index == 140)
						{
							num2 = (short)1651703813;
							num = (int)((global::System.IntPtr)num2);
							continue;
						}
						return true;
					case 5:
						goto IL_A9;
					}
					goto IL_28;
				}
				IL_A9:
				num2 = (short)1012465665;
				if (num2 != 0)
				{
				}
				return false;
			}
			IL_28:
			radioWide = (global::AcpCommonLib.FeatureManager.GetFeature(2045)[0] as global::Motorola.MackinawCPS.CoreFeatures.RadioWide.RadioWide);
			IL_3E:
			num2 = (short)834076675;
			num = (int)((global::System.IntPtr)num2);
			goto IL_0A;
		}

		// Token: 0x06007B4A RID: 31562 RVA: 0x0070F960 File Offset: 0x0070DB60
		internal static bool ConConvFeatureIsSameAsTrk(global::AcpCommonLib.IAcpFeatureSection self, int index)
		{
			short num = (short)927924224;
			int num2 = (int)num;
			switch (num2)
			{
			default:
			{
				switch (0)
				{
				case 0:
					goto IL_13F;
				}
				global::Motorola.MackinawCPS.CoreFeatures.KeypadMicAndAccessories.KMButtonInnerSection kmbuttonInnerSection;
				bool result;
				global::AcpBusinessLayer.AcpField<bool> radErgoWideControlHeadMultiControlHead_A;
				int num3;
				global::Motorola.MackinawCPS.CoreFeatures.EmergencyWide.EmergencyWide emergencyWide;
				global::AcpBusinessLayer.AcpListField radErgoWideControlHeadMultipleControlHeadStyle_A;
				global::Motorola.MackinawCPS.CoreFeatures.RadioWide.Features features;
				for (;;)
				{
					IL_28:
					bool flag;
					bool flag2;
					bool flag3;
					switch (num2)
					{
					case 0:
						num = (short)856752171;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 1:
						if (index - 109 > 1)
						{
							num = (short)1360592951;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)108331030;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 2:
						goto IL_9AE;
					case 3:
						num = (short)1979908144;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 4:
						if (index != kmbuttonInnerSection.RadErgoCfgKMTrunkingKMButtonFeature_A19746.Value)
						{
							num = (short)822411301;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_45C;
					case 5:
						if (index != 70)
						{
							num = (short)1947402275;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_806;
					case 6:
						if (index != 125)
						{
							num = (short)897384468;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_806;
					case 7:
						num = (short)165806138;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 8:
						goto IL_A5A;
					case 9:
						if (index != 125)
						{
							num = (short)259588159;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_7C0;
					case 10:
						goto IL_752;
					case 11:
						num = (short)1885995017;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 12:
						num = (short)1922170898;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 13:
						num = (short)504496134;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 14:
						num = (short)1016725544;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 15:
						if (index != 163)
						{
							num = (short)1981022208;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)86442036;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 16:
						num = (short)1699151911;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 17:
						if (index != 140)
						{
							num = (short)37552170;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						result = (kmbuttonInnerSection.RefRadioWide.DualRadio.RadWideDualRadioSelection_A42236.Value != 0);
						num = (short)647233602;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 18:
						if (index == 228)
						{
							num = (short)142147616;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_45C;
					case 19:
						num = (short)1154809879;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 20:
						num = (short)1651507226;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 21:
						if (kmbuttonInnerSection.RefRadioWide.DualRadio.RadWideDualRadioSelection_A42236.Value != 0)
						{
							num = (short)1114898481;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_45C;
					case 22:
						if (kmbuttonInnerSection.RefRadioWide.UserInformationAndPasswords.RadWideUserInformationandPasswordsRadioLock_A8836.Value)
						{
							num = (short)840499219;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)198639681;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 23:
						flag = !(kmbuttonInnerSection.RadErgoCfgKMButtonName_A22561.Value == global::CommonResources.AcgResources.ID_SIDETOPBUTTON);
						goto IL_994;
					case 24:
						flag2 = true;
						goto IL_933;
					case 25:
						goto IL_8F1;
					case 26:
						if (index == 126)
						{
							num = (short)2144993327;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_4DD;
					case 27:
						num = (short)323813397;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 28:
						return result;
					case 29:
						num = (short)356646966;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 30:
						goto IL_94E;
					case 31:
						if (index != 124)
						{
							num = (short)1530462221;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_806;
					case 32:
						goto IL_7C0;
					case 33:
						if (radErgoWideControlHeadMultiControlHead_A.Value)
						{
							num = (short)2099642397;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)1935605820;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 34:
						if (kmbuttonInnerSection.RefRadioWide.DualRadio.RadWideDualRadioSelection_A42236.Value != 0)
						{
							num = (short)878379022;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_4DD;
					case 35:
						num = (short)101122079;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 36:
						if (index != 124)
						{
							num = (short)1468203019;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_7C0;
					case 37:
						return false;
					case 38:
						num = (short)1987575809;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 39:
						if (index != 70)
						{
							num = (short)921174028;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_7C0;
					case 40:
						if (num3 == 0)
						{
							num = (short)219283497;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_4DD;
					case 41:
						return false;
					case 42:
						num = (short)1037041689;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 43:
						if (index != 217)
						{
							num = (short)1963393031;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						result = (emergencyWide.EmergencyWideImpactDetection.EmerWideImpactDetectionConfigLevel_A43384.Value != 0);
						num = (short)1143406600;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 44:
						if (index <= 140)
						{
							num = (short)459014182;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)1910833167;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 45:
						num = (short)297730052;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 46:
					{
						if (radErgoWideControlHeadMultiControlHead_A.Value)
						{
							num = (short)1868431384;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)458895599;
						short num4 = num;
						num = (short)2090807535;
						switch ((num4 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_6E6;
						default:
							num = (short)352518144;
							if (num != 0)
							{
							}
							num = (short)443809802;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						break;
					}
					case 47:
						goto IL_806;
					case 48:
						goto IL_A77;
					case 49:
						goto IL_6E6;
					case 50:
						num = (short)227934209;
						if (num != 0)
						{
						}
						if (index != 126)
						{
							num = (short)1808990224;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_7C0;
					case 51:
						if (index != 138)
						{
							num = (short)1649672254;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)1271791649;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 52:
						if (radErgoWideControlHeadMultipleControlHeadStyle_A.Value == 1)
						{
							num = (short)1158676539;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_752;
					case 53:
						goto IL_457;
					case 54:
						flag3 = (radErgoWideControlHeadMultipleControlHeadStyle_A.Value == 0);
						goto IL_B47;
					case 55:
						num = (short)1704722483;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 56:
						num = (short)757792773;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 57:
						flag2 = !radErgoWideControlHeadMultiControlHead_A.Value;
						goto IL_933;
					case 58:
						if (index - 290 > 1)
						{
							num = (short)2029125635;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						result = features.RadWideFeaturesChannelFallbackEnableValue;
						num = (short)339345461;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 59:
						num = (short)230293550;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 60:
					{
						num = (short)655294464;
						short num5 = num;
						flag3 = false;
						goto IL_B47;
					}
					case 61:
						if (index != 31)
						{
							num = (short)1687748664;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_806;
					case 62:
						num = (short)698482705;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 63:
						num = (short)1776091186;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 64:
						if (index == kmbuttonInnerSection.RadErgoCfgKMConventionalKMButtonFeature_A19646.Value)
						{
							num = (short)1910374445;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_45C;
					case 65:
						flag = true;
						goto IL_994;
					case 66:
						goto IL_696;
					case 67:
						if (!kmbuttonInnerSection.RadErgoCfgKMTrunkingKMButtonFeature_A19746.HiddenStatic)
						{
							num = (short)347996187;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_45C;
					}
					goto IL_13F;
					IL_45C:
					result = true;
					num = (short)1162149932;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_4DD:
					num = (short)1756823588;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_6E6:
					num = (short)303431744;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_752:
					num = (short)1873150009;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_7C0:
					num = (short)649658435;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_806:
					num = (short)1296039970;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_933:
					result = flag2;
					num = (short)727121950;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_994:
					result = flag;
					num = (short)142475266;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_B47:
					result = flag3;
					num = (short)1823146012;
					num2 = (int)((global::System.IntPtr)num);
				}
				return false;
				IL_457:
				IL_696:
				IL_8F1:
				IL_94E:
				IL_9AE:
				IL_A5A:
				IL_A77:
				return result;
				IL_13F:
				kmbuttonInnerSection = (self as global::Motorola.MackinawCPS.CoreFeatures.KeypadMicAndAccessories.KMButtonInnerSection);
				radErgoWideControlHeadMultipleControlHeadStyle_A = kmbuttonInnerSection.RefRadioErgonomicsWide.ControlHead.RadErgoWideControlHeadMultipleControlHeadStyle_A8561;
				emergencyWide = (global::AcpCommonLib.FeatureManager.GetFeature(2032)[0] as global::Motorola.MackinawCPS.CoreFeatures.EmergencyWide.EmergencyWide);
				features = (global::AcpCommonLib.FeatureManager.GetFeature(2045)[0][10105] as global::Motorola.MackinawCPS.CoreFeatures.RadioWide.Features);
				radErgoWideControlHeadMultiControlHead_A = kmbuttonInnerSection.RefRadioErgonomicsWide.ControlHead.RadErgoWideControlHeadMultiControlHead_A8550;
				global::AcpCommonLib.IAcpFeatureNode parent = kmbuttonInnerSection.RadErgoCfgKMConventionalKMButtonFeature_A19646.Parent.Parent;
				num3 = (parent.Parent as global::AcpBusinessLayer.Recordset).IndexOf(parent);
				num = (short)479854653;
				num2 = (int)((global::System.IntPtr)num);
				goto IL_28;
			}
			}
		}
	}
}
