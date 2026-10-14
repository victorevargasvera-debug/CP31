using System;
using System.CodeDom.Compiler;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Threading;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Markup;
using ACPBrowser;
using AcpBusinessLayer;
using AcpCommonLib;
using AcpUI;
using AcpUI.Common;
using AcpUILib;
using CommonResources;
using ConstraintHelper;
using Infragistics.Windows.DataPresenter.Events;
using Motorola.MackinawCPS.CoreFeatures.ActionConsolidation;
using Motorola.MackinawCPS.CoreFeatures.ConventionalPersonality;
using Motorola.MackinawCPS.CoreFeatures.ConventionalWide;
using Motorola.MackinawCPS.CoreFeatures.DataProfiles;
using Motorola.MackinawCPS.CoreFeatures.RadioInformation;
using Motorola.MackinawCPS.CoreFeatures.RadioWide;
using Motorola.MackinawCPS.CoreFeatures.TrunkingEmergencyProfiles;
using Motorola.MackinawCPS.CoreFeatures.TrunkingSystem;
using SpecialFeatures.AcpReportManagerLib;
using SpecialFeatures.Flashport;
using SpecialFeatures.Flashport.FlashRadio;

namespace SpecialFeatures.RadioFeatureSet
{
	// Token: 0x02000080 RID: 128
	public class PageRadioFeatureSet : global::AcpUI.AcpPageFeature, global::AcpUILib.IAcpPageFeature, global::System.Windows.Markup.IComponentConnector
	{
		// Token: 0x06000A1E RID: 2590 RVA: 0x000B902C File Offset: 0x000B722C
		public PageRadioFeatureSet()
		{
			int a_ = 19;
			base..ctor();
			try
			{
				this.InitializeComponent();
				goto IL_11;
			}
			catch (global::System.Exception)
			{
				goto IL_11;
			}
			goto IL_47;
			IL_11:
			if (!global::System.Threading.Thread.CurrentThread.CurrentCulture.Name.ToLower().StartsWith(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("", a_)))
			{
				return;
			}
			IL_47:
			this.FeatureSetGeneralPurchasedFLASHcode.FlowDirection = global::System.Windows.FlowDirection.LeftToRight;
			this.FeatureSetGeneralPurchasedFLASHcode.TextAlignment = global::System.Windows.TextAlignment.Right;
			this.FeatureSetGeneralUsedFLASHcode.FlowDirection = global::System.Windows.FlowDirection.LeftToRight;
			this.FeatureSetGeneralUsedFLASHcode.TextAlignment = global::System.Windows.TextAlignment.Right;
		}

		// Token: 0x1700040D RID: 1037
		// (get) Token: 0x06000A1F RID: 2591 RVA: 0x000B90C4 File Offset: 0x000B72C4
		public global::SpecialFeatures.RadioFeatureSet.RadioFeatureSetRecset FeatSetRecSet
		{
			get
			{
				short num = (short)439812096;
				short num2 = num;
				num = (short)1116529034;
				short num3 = num;
				num = (short)1328669066;
				switch (num3 == num)
				{
				}
				num = (short)1034682368;
				if (num != 0)
				{
				}
				num = (short)146014209;
				if (num != 0)
				{
				}
				return this.a;
			}
		}

		// Token: 0x06000A20 RID: 2592 RVA: 0x000B9174 File Offset: 0x000B7374
		public override void OnLoaded(object sender, global::System.Windows.RoutedEventArgs e)
		{
			switch (0)
			{
			case 0:
				goto IL_20;
			}
			int num;
			short num2;
			global::AcpUI.AcpExpander acpExpander;
			global::System.Collections.IEnumerator enumerator;
			for (;;)
			{
				IL_0A:
				switch (num)
				{
				case 0:
					try
					{
						num2 = (short)1489174529;
						num = (int)((global::System.IntPtr)num2);
						for (;;)
						{
							switch (num)
							{
							case 0:
								if (acpExpander != null)
								{
									num2 = (short)1672019974;
									num = (int)((global::System.IntPtr)num2);
									continue;
								}
								break;
							case 1:
								switch (0)
								{
								case 0:
									goto IL_134;
								}
								continue;
							case 3:
								num2 = (short)1235812357;
								num = (int)((global::System.IntPtr)num2);
								continue;
							case 4:
								if (!enumerator.MoveNext())
								{
									num2 = (short)184418307;
									num = (int)((global::System.IntPtr)num2);
									continue;
								}
								acpExpander = (((global::System.Windows.UIElement)enumerator.Current) as global::AcpUI.AcpExpander);
								num2 = (short)162856960;
								num = (int)((global::System.IntPtr)num2);
								continue;
							case 5:
								goto IL_1E6;
							case 6:
								base.Expanders.Add(acpExpander);
								num2 = (short)1741094914;
								num = (int)((global::System.IntPtr)num2);
								continue;
							}
							IL_175:
							num2 = (short)672464900;
							num = (int)((global::System.IntPtr)num2);
							continue;
							IL_134:
							goto IL_175;
						}
						IL_1E6:
						goto IL_74;
					}
					finally
					{
						switch (0)
						{
						case 0:
							goto IL_207;
						}
						global::System.IDisposable disposable;
						for (;;)
						{
							IL_1F5:
							switch (num)
							{
							case 0:
								goto IL_2A8;
							case 1:
								if (disposable != null)
								{
									num2 = (short)827260930;
									num = (int)((global::System.IntPtr)num2);
									continue;
								}
								goto IL_2AA;
							case 2:
							{
								num2 = (short)2063402212;
								short num3 = num2;
								num2 = (short)1433076964;
								switch ((num3 == num2) ? 1 : 0)
								{
								case 0:
								case 2:
									goto IL_2AA;
								default:
									num2 = (short)1478819840;
									if (num2 != 0)
									{
									}
									disposable.Dispose();
									num2 = (short)2029387776;
									num = (int)((global::System.IntPtr)num2);
									continue;
								}
								break;
							}
							}
							goto IL_207;
						}
						IL_2A8:
						IL_2AA:
						goto EndFinally_7;
						IL_207:
						disposable = (enumerator as global::System.IDisposable);
						num2 = (short)693567489;
						num = (int)((global::System.IntPtr)num2);
						goto IL_1F5;
						EndFinally_7:;
					}
					goto IL_2AB;
					IL_74:
					this.MyStackPanel.Children[0].Focus();
					num2 = (short)88539139;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 1:
					goto IL_2AB;
				case 2:
					return;
				case 3:
				{
					num2 = (short)486735872;
					short num4 = num2;
					if (!base.IsKeyboardFocusWithin)
					{
						num2 = (short)1759969281;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					return;
				}
				}
				goto IL_20;
				IL_2AB:
				global::System.Windows.Input.Keyboard.Focus(this);
				num2 = (short)1611202562;
				num = (int)((global::System.IntPtr)num2);
			}
			return;
			IL_20:
			num2 = (short)1384448001;
			if (num2 != 0)
			{
			}
			acpExpander = null;
			enumerator = this.MyStackPanel.Children.GetEnumerator();
			num2 = (short)607125504;
			num = (int)((global::System.IntPtr)num2);
			goto IL_0A;
		}

		// Token: 0x06000A21 RID: 2593 RVA: 0x000B945C File Offset: 0x000B765C
		public override void SetDataContext()
		{
			short num = (short)1614348288;
			short num2 = num;
			num = (short)2142765057;
			if (num != 0)
			{
			}
			num = (short)524268886;
			short num3 = num;
			num = (short)386839894;
			switch (num3 == num)
			{
			}
			num = (short)1162412032;
			if (num != 0)
			{
			}
			this.c();
			this.Calculate();
			base.DataContext = global::SpecialFeatures.Flashport.FlashDataManager.GetFeature(this.a.RecsetId);
		}

		// Token: 0x06000A22 RID: 2594 RVA: 0x000B9528 File Offset: 0x000B7728
		private void OnFieldNameDoubleClick(object A_0, global::System.Windows.RoutedEventArgs A_1)
		{
			short num = (short)1933180928;
			short num2 = num;
			num = (short)1325638594;
			short num3 = num;
			num = (short)1787864002;
			switch (num3 == num)
			{
			}
			num = (short)1068630016;
			if (num != 0)
			{
			}
			num = (short)1413152769;
			if (num != 0)
			{
			}
			global::AcpUI.Common.Utility.GetFieldHelpText(A_0);
		}

		// Token: 0x06000A23 RID: 2595 RVA: 0x000B95D4 File Offset: 0x000B77D4
		private void HLinkClick(object A_0, global::System.Windows.RoutedEventArgs A_1)
		{
			short num = (short)757137408;
			short num2 = num;
			num = (short)1188700783;
			short num3 = num;
			num = (short)458629743;
			switch (num3 == num)
			{
			}
			num = (short)1903689728;
			if (num != 0)
			{
			}
			num = (short)906559489;
			if (num != 0)
			{
			}
			base.OnHLinkClick(A_0);
		}

		// Token: 0x06000A24 RID: 2596 RVA: 0x000B9688 File Offset: 0x000B7888
		private void c()
		{
			short num = (short)1252655104;
			short num2 = num;
			num = (short)2106452915;
			short num3 = num;
			num = (short)127134643;
			switch (num3 == num)
			{
			}
			num = (short)1685127169;
			if (num != 0)
			{
			}
			num = (short)1303707648;
			if (num != 0)
			{
			}
			this.a = new global::SpecialFeatures.RadioFeatureSet.RadioFeatureSetRecset();
			this.a.AddRecord(this.a.CreateDefaultRecord());
		}

		// Token: 0x06000A25 RID: 2597 RVA: 0x000B9754 File Offset: 0x000B7954
		private void ExpanderRadioFeatureSetUsedTable_RecordActivating(object A_0, global::Infragistics.Windows.DataPresenter.Events.RecordActivatingEventArgs A_1)
		{
			short num = (short)1037828096;
			short num2 = num;
			num = (short)2017525761;
			if (num != 0)
			{
			}
			num = (short)490111631;
			short num3 = num;
			num = (short)930382479;
			switch (num3 == num)
			{
			}
			num = (short)1190264832;
			if (num != 0)
			{
			}
			A_1.Cancel = true;
		}

		// Token: 0x06000A26 RID: 2598 RVA: 0x000B9804 File Offset: 0x000B7A04
		internal bool Calculate()
		{
			short num = (short)1089732608;
			int num2 = (int)num;
			switch (num2)
			{
			default:
			{
				num = (short)536477696;
				short num3 = num;
				bool result = false;
				try
				{
					switch (0)
					{
					case 0:
						goto IL_9C;
					}
					global::SpecialFeatures.RadioFeatureSet.RadioFeatureSet radioFeatureSet;
					global::Motorola.MackinawCPS.CoreFeatures.RadioInformation.RadioInformation radioInformation;
					string radInfoFLASHportFLASHcode_A8132Value;
					for (;;)
					{
						IL_55:
						global::SpecialFeatures.Flashport.FlashRadio.FlashcodeTable flashcodeTable;
						global::SpecialFeatures.Flashport.Recordset embeddedRecset;
						switch (num2)
						{
						case 0:
							num = (short)805044232;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 1:
							goto IL_1A8;
						case 2:
							if (this.a == null)
							{
								num = (short)1998454789;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							goto IL_1A8;
						case 3:
							if (this.a.Count <= 0)
							{
								num = (short)1617231887;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							goto IL_89F;
						case 4:
							if (radioFeatureSet == null)
							{
								num = (short)4390922;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							goto IL_7EA;
						case 5:
							this.a = new global::SpecialFeatures.RadioFeatureSet.RadioFeatureSetRecset();
							num = (short)142147585;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 6:
							goto IL_89F;
						case 7:
							radioFeatureSet = (this.a[0] as global::SpecialFeatures.RadioFeatureSet.RadioFeatureSet);
							num = (short)1750925323;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 8:
							if (this.a.Count > 0)
							{
								num = (short)406847495;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							goto IL_861;
						case 9:
							if (this.a != null)
							{
								num = (short)1044578304;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							goto IL_861;
						case 10:
							radioFeatureSet = new global::SpecialFeatures.RadioFeatureSet.RadioFeatureSet(this.a);
							num = (short)685113357;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 11:
							goto IL_861;
						case 12:
							goto IL_1EA;
							try
							{
								for (;;)
								{
									IL_1EA:
									string featureSetGeneralUsedFLASHcodeValue = radioFeatureSet.General.FeatureSetGeneralUsedFLASHcodeValue;
									flashcodeTable.InitTable(true, radioInformation.General.RadInfoGeneralModelNumber_A8539.Value, false);
									global::System.Collections.Generic.IEnumerator<global::SpecialFeatures.Flashport.FlashRadio.Option> enumerator = flashcodeTable.FLASHcode.GetEnumerator();
									try
									{
										num = (short)1338900494;
										num2 = (int)((global::System.IntPtr)num);
										for (;;)
										{
											global::SpecialFeatures.RadioFeatureSet.FeatureSetInner featureSetInner;
											switch (num2)
											{
											case 0:
											{
												global::SpecialFeatures.Flashport.FlashRadio.Option option;
												if (flashcodeTable.IsOptionEnabledInFlashcode(option, featureSetGeneralUsedFLASHcodeValue))
												{
													num = (short)1436745732;
													num2 = (int)((global::System.IntPtr)num);
													continue;
												}
												featureSetInner.FeatureSetInnerSection.FeatureSetEnabledInUsedFlashcodeValue = global::CommonResources.AppResources.No_Id;
												global::System.Enum[] array = new global::System.Enum[]
												{
													global::SpecialFeatures.Flashport.FlashRadio.OptionIDs._7_800_MHz_Primary_Band,
													global::SpecialFeatures.Flashport.FlashRadio.OptionIDs.VHF_MP_Primary_Band,
													global::SpecialFeatures.Flashport.FlashRadio.OptionIDs.VHF_HP_Primary_Band,
													global::SpecialFeatures.Flashport.FlashRadio.OptionIDs.UHF_R1_MP_Primary_Band,
													global::SpecialFeatures.Flashport.FlashRadio.OptionIDs.UHF_R1_HP_Primary_Band,
													global::SpecialFeatures.Flashport.FlashRadio.OptionIDs.UHF_R2_MP_Primary_Band,
													global::SpecialFeatures.Flashport.FlashRadio.OptionIDs._900MHZ_ID,
													global::SpecialFeatures.Flashport.FlashRadio.OptionIDs._7_800_MHz_Primary_Band,
													global::SpecialFeatures.Flashport.FlashRadio.OptionIDs.VHF_Primary_Band,
													global::SpecialFeatures.Flashport.FlashRadio.OptionIDs.UHF_Range_1_Primary_Band,
													global::SpecialFeatures.Flashport.FlashRadio.OptionIDs.UHF_Range_2_Primary_Band,
													global::SpecialFeatures.Flashport.FlashRadio.OptionIDs._900MHZ_ID,
													global::SpecialFeatures.Flashport.FlashRadio.OptionIDs.Enable_Dual_Band_Operation,
													global::SpecialFeatures.Flashport.FlashRadio.OptionIDs.Primary_Band_800_900MHz
												};
												global::System.Enum[] array2 = new global::System.Enum[]
												{
													global::SpecialFeatures.Flashport.FlashRadio.OptionIDs._7_800_MHz_Secondary_Band,
													global::SpecialFeatures.Flashport.FlashRadio.OptionIDs.UHF_Range_1_Secondary_Band,
													global::SpecialFeatures.Flashport.FlashRadio.OptionIDs.UHF_Range_2_Secondary_Band,
													global::SpecialFeatures.Flashport.FlashRadio.OptionIDs.VHF_Secondary_Band,
													global::SpecialFeatures.Flashport.FlashRadio.OptionIDs.UHF_R1_HP_Secondary_Band,
													global::SpecialFeatures.Flashport.FlashRadio.OptionIDs.VHF_HP_Secondary_Band,
													global::SpecialFeatures.Flashport.FlashRadio.OptionIDs.VHF_MPZ_Secondary_Band,
													global::SpecialFeatures.Flashport.FlashRadio.OptionIDs.UHF_R2_MP_Secondary_Band,
													global::SpecialFeatures.Flashport.FlashRadio.OptionIDs.UHF_R1_MP_Secondary_Band
												};
												num = (short)953483269;
												num2 = (int)((global::System.IntPtr)num);
												continue;
											}
											case 1:
												featureSetInner.FeatureSetInnerSection.FeatureSetEnabledInUsedFlashcodeValue = global::CommonResources.AppResources.Yes_Id;
												num = (short)1496055820;
												num2 = (int)((global::System.IntPtr)num);
												continue;
											case 2:
												featureSetInner.FeatureSetInnerSection.FeatureSetEnabledInUsedFlashcodeValue = global::CommonResources.AppResources.Yes_Id;
												num = (short)1847394315;
												num2 = (int)((global::System.IntPtr)num);
												continue;
											case 4:
												featureSetInner.FeatureSetInnerSection.FeatureSetEnabledInUsedFlashcodeValue = global::CommonResources.AppResources.Yes_Id;
												num = (short)1871904774;
												num2 = (int)((global::System.IntPtr)num);
												continue;
											case 5:
											{
												global::SpecialFeatures.Flashport.FlashRadio.Option option;
												global::System.Enum[] array;
												if (global::System.Array.IndexOf<global::System.Enum>(array, option.OptionID) > -1)
												{
													num = (short)197853185;
													num2 = (int)((global::System.IntPtr)num);
													continue;
												}
												num = (short)1463156745;
												num2 = (int)((global::System.IntPtr)num);
												continue;
											}
											case 6:
												goto IL_5B6;
											case 7:
											{
												if (!enumerator.MoveNext())
												{
													num = (short)727449617;
													num2 = (int)((global::System.IntPtr)num);
													continue;
												}
												global::SpecialFeatures.Flashport.FlashRadio.Option option = enumerator.Current;
												num = (short)1948581904;
												num2 = (int)((global::System.IntPtr)num);
												continue;
											}
											case 8:
												num = (short)2031484941;
												num2 = (int)((global::System.IntPtr)num);
												continue;
											case 9:
											{
												global::SpecialFeatures.Flashport.FlashRadio.Option option;
												global::System.Enum[] array2;
												if (global::System.Array.IndexOf<global::System.Enum>(array2, option.OptionID) > -1)
												{
													num = (short)1992884232;
													num2 = (int)((global::System.IntPtr)num);
													continue;
												}
												goto IL_5B6;
											}
											case 10:
											{
												featureSetInner = new global::SpecialFeatures.RadioFeatureSet.FeatureSetInner(embeddedRecset);
												global::SpecialFeatures.Flashport.FlashRadio.Option option;
												featureSetInner.FeatureSetInnerSection.FeatureSetPurchasedFeatureNameValue = option.ToString();
												num = (short)718995456;
												num2 = (int)((global::System.IntPtr)num);
												continue;
											}
											case 11:
												goto IL_5B6;
											case 12:
												goto IL_5B6;
											case 13:
												if (radioInformation.Labtool.RadInfoLabtoolDualBandEnable_A23986Value)
												{
													num = (short)1882456066;
													num2 = (int)((global::System.IntPtr)num);
													continue;
												}
												goto IL_5B6;
											case 14:
												switch (0)
												{
												case 0:
													goto IL_28F;
												}
												continue;
											case 15:
												goto IL_640;
											case 16:
											{
												global::SpecialFeatures.Flashport.FlashRadio.Option option;
												if (flashcodeTable.IsOptionEnabledInFlashcode(option, radInfoFLASHportFLASHcode_A8132Value))
												{
													num = (short)1395851274;
													num2 = (int)((global::System.IntPtr)num);
													continue;
												}
												break;
											}
											case 17:
												num = (short)2057437199;
												num2 = (int)((global::System.IntPtr)num);
												continue;
											}
											IL_2BF:
											num = (short)907149319;
											num2 = (int)((global::System.IntPtr)num);
											continue;
											IL_28F:
											goto IL_2BF;
											IL_5B6:
											embeddedRecset.AddRecord(featureSetInner);
											num = (short)907149315;
											num2 = (int)((global::System.IntPtr)num);
										}
										IL_640:;
									}
									finally
									{
										num = (short)1627127810;
										num2 = (int)((global::System.IntPtr)num);
										for (;;)
										{
											switch (num2)
											{
											case 0:
												goto IL_6AB;
											case 1:
												enumerator.Dispose();
												num = (short)1977679872;
												num2 = (int)((global::System.IntPtr)num);
												continue;
											case 2:
												switch (0)
												{
												case 0:
													goto IL_674;
												}
												continue;
											}
											IL_674:
											if (enumerator == null)
											{
												break;
											}
											num = (short)2077491201;
											num2 = (int)((global::System.IntPtr)num);
										}
										IL_6AB:;
									}
									num = (short)1986267027;
									short num4 = num;
									num = (short)332203923;
									switch ((num4 == num) ? 1 : 0)
									{
									case 0:
									case 2:
										break;
									default:
										goto IL_6E2;
									}
								}
								IL_6E2:
								num = (short)413401088;
								if (num != 0)
								{
								}
								goto IL_148;
							}
							finally
							{
								num = (short)177340418;
								num2 = (int)((global::System.IntPtr)num);
								for (;;)
								{
									switch (num2)
									{
									case 0:
										goto IL_768;
									case 1:
										((global::System.IDisposable)flashcodeTable).Dispose();
										num = (short)2058878976;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									case 2:
										switch (0)
										{
										case 0:
											goto IL_730;
										}
										continue;
									}
									IL_730:
									if (flashcodeTable == null)
									{
										break;
									}
									num = (short)1689190401;
									num2 = (int)((global::System.IntPtr)num);
								}
								IL_768:;
							}
							goto IL_76B;
							IL_148:
							this.b = radioFeatureSet.ExtendedFeatureSet.EmbeddedRecset;
							this.b();
							num = (short)1152647171;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 13:
							goto IL_7EA;
						case 14:
							goto IL_8C6;
						case 15:
							goto IL_76B;
						}
						goto IL_9C;
						IL_1A8:
						num = (short)2054619145;
						num2 = (int)((global::System.IntPtr)num);
						continue;
						IL_76B:
						this.a.AddRecord(radioFeatureSet);
						num = (short)479002630;
						num2 = (int)((global::System.IntPtr)num);
						continue;
						IL_7EA:
						radioFeatureSet.General.FeatureSetGeneralPurchasedFLASHcodeValue = radInfoFLASHportFLASHcode_A8132Value;
						radioFeatureSet.General.FeatureSetGeneralUsedFLASHcodeValue = global::SpecialFeatures.RadioFeatureSet.FeatureSetConstraints.getUsedFcodeValue();
						embeddedRecset = radioFeatureSet.FeatureSet.EmbeddedRecset;
						flashcodeTable = new global::SpecialFeatures.Flashport.FlashRadio.FlashcodeTable(true);
						num = (short)2056912908;
						num2 = (int)((global::System.IntPtr)num);
						continue;
						IL_861:
						num = (short)1861222404;
						num2 = (int)((global::System.IntPtr)num);
						continue;
						IL_89F:
						global::SpecialFeatures.Flashport.FlashDataManager.AddFeature(this.a);
						result = true;
						num = (short)486735886;
						num2 = (int)((global::System.IntPtr)num);
					}
					IL_8C6:
					goto IL_8DE;
					IL_9C:
					radioInformation = (global::AcpCommonLib.FeatureManager.GetFeature(2049)[0] as global::Motorola.MackinawCPS.CoreFeatures.RadioInformation.RadioInformation);
					radInfoFLASHportFLASHcode_A8132Value = radioInformation.FLASHport.RadInfoFLASHportFLASHcode_A8132Value;
					radioFeatureSet = null;
					num = (short)59834370;
					num2 = (int)((global::System.IntPtr)num);
					goto IL_55;
				}
				catch (global::System.Exception ex)
				{
					global::AcpCommonLib.AppInfoManager.StatusMsgReport.RegisterMessage(global::AcpCommonLib.StatusMsgType.Error, ex.Message);
				}
				IL_8DE:
				num = (short)7733249;
				if (num != 0)
				{
				}
				return result;
			}
			}
		}

		// Token: 0x06000A27 RID: 2599 RVA: 0x000BA164 File Offset: 0x000B8364
		private void F1HelpCommandCanExcute(object A_0, global::System.Windows.Input.CanExecuteRoutedEventArgs A_1)
		{
			short num = (short)185436867;
			short num2 = num;
			num = (short)469732035;
			switch (num2 == num)
			{
			}
			num = (short)1453326337;
			if (num != 0)
			{
			}
			num = (short)2126577664;
			if (num != 0)
			{
			}
			num = (short)483655680;
			short num3 = num;
			A_1.CanExecute = true;
		}

		// Token: 0x06000A28 RID: 2600 RVA: 0x000BA214 File Offset: 0x000B8414
		private void buttonHelp_Click(object A_0, global::System.Windows.RoutedEventArgs A_1)
		{
			int a_ = 17;
			short num;
			try
			{
				num = (short)1988208892;
				short num2 = num;
				num = (short)1467525372;
				switch (num2 == num)
				{
				}
				num = (short)2086862849;
				if (num != 0)
				{
				}
				num = (short)1813053440;
				if (num != 0)
				{
				}
				global::ACPBrowser.Utility.CloseHelpWindowIfOpen();
				global::ACPBrowser.Utility.DisplayCPSHelpDITA(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("랓ﲗꪙꪛ겝钟삡잣", a_));
			}
			catch (global::System.Exception)
			{
			}
			num = (short)1383989248;
			short num3 = num;
		}

		// Token: 0x06000A29 RID: 2601 RVA: 0x000BA2F8 File Offset: 0x000B84F8
		private void buttonClose_Click(object A_0, global::System.Windows.RoutedEventArgs A_1)
		{
			short num = (short)236542265;
			short num2 = num;
			num = (short)1301371193;
			switch (num2 == num)
			{
			}
			num = (short)928907265;
			if (num != 0)
			{
			}
			num = (short)99221504;
			if (num != 0)
			{
			}
			num = (short)261750784;
			short num3 = num;
			((global::System.Windows.Window)base.Parent).Close();
		}

		// Token: 0x06000A2A RID: 2602 RVA: 0x000BA3B4 File Offset: 0x000B85B4
		private void a(string A_0, bool A_1, global::SpecialFeatures.RadioFeatureSet.PageRadioFeatureSet.PCIExcisedConstraint A_2)
		{
			short num = (short)699465732;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				bool flag;
				global::SpecialFeatures.RadioFeatureSet.ExtendedFeatureSetInner extendedFeatureSetInner;
				switch (num2)
				{
				case 0:
					flag = A_1;
					goto IL_BC;
				case 1:
					IL_142:
					num = (short)149684225;
					if (num != 0)
					{
					}
					extendedFeatureSetInner.ExtendedFeatureSetInnerSection.IsUseforPermanentExcised = (A_2 == null);
					num = (short)767229958;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 2:
					this.b.AddRecord(extendedFeatureSetInner);
					num = (short)981401605;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 3:
				{
					num = (short)389218304;
					short num3 = num;
					flag = A_2();
					goto IL_BC;
				}
				case 4:
					switch (0)
					{
					case 0:
						goto IL_44;
					}
					continue;
				case 5:
					return;
				case 6:
					if (A_1)
					{
						num = (short)2054356994;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					return;
				case 7:
					num = (short)271450115;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				IL_44:
				if (A_2 != null)
				{
					num = (short)1866792967;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				num = (short)1537540096;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_BC:
				bool extendedFeatureSetEnabled_boolValue = flag;
				extendedFeatureSetInner = new global::SpecialFeatures.RadioFeatureSet.ExtendedFeatureSetInner(this.b);
				extendedFeatureSetInner.ExtendedFeatureSetInnerSection.ExtendedFeatureSetFeatureNameValue = A_0;
				extendedFeatureSetInner.ExtendedFeatureSetInnerSection.ExtendedFeatureSetEnabled_boolValue = extendedFeatureSetEnabled_boolValue;
				num = (short)1902895029;
				short num4 = num;
				num = (short)191094709;
				switch ((num4 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					goto IL_142;
				default:
					num = (short)578617344;
					if (num != 0)
					{
					}
					num = (short)1987444737;
					num2 = (int)((global::System.IntPtr)num);
					break;
				}
			}
		}

		// Token: 0x06000A2B RID: 2603 RVA: 0x000BA59C File Offset: 0x000B879C
		private void b()
		{
			short num = (short)1763704832;
			int num2 = (int)num;
			switch (num2)
			{
			default:
			{
				switch (0)
				{
				case 0:
					goto IL_123;
				}
				global::Motorola.MackinawCPS.CoreFeatures.RadioInformation.RadioInformation radioInformation;
				global::Motorola.MackinawCPS.CoreFeatures.RadioWide.RadioWide radioWide;
				bool flag;
				global::Motorola.MackinawCPS.CoreFeatures.ConventionalWide.ConventionalWide conventionalWide;
				for (;;)
				{
					IL_28:
					global::Motorola.MackinawCPS.CoreFeatures.ConventionalPersonality.ConventionalPersonalityRecset conventionalPersonalityRecset;
					global::Motorola.MackinawCPS.CoreFeatures.ActionConsolidation.ActionConsolidationRecset actionConsolidationRecset;
					global::Motorola.MackinawCPS.CoreFeatures.DataProfiles.DataProfilesRecset dataProfilesRecset;
					global::Motorola.MackinawCPS.CoreFeatures.TrunkingEmergencyProfiles.TrunkingEmergencyProfiles trunkingEmergencyProfiles;
					switch (num2)
					{
					case 0:
						this.a(global::CommonResources.AcgResources.ID_EXTENDED700MHZRANGE, radioInformation.FrequencyRanges.RadInfoFrequencyRanges700MHzUsedinCodeplug_A42551.Value, null);
						num = (short)42729477;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 1:
						goto IL_F4B;
					case 2:
						if (conventionalPersonalityRecset != null)
						{
							num = (short)730333238;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_864;
					case 3:
						this.a(global::CommonResources.AcgResources.ID_USERSELECTABLEPLENHANCEMENT, radioWide.Labtool.RadWideLabtoolUserSelectablePLEnhancement_43031.Value, new global::SpecialFeatures.RadioFeatureSet.PageRadioFeatureSet.PCIExcisedConstraint(global::SpecialFeatures.RadioFeatureSet.PCIGatings.IsUserSelectablePLEnhancementUsed));
						num = (short)736821257;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 4:
						if (!actionConsolidationRecset.HiddenStatic)
						{
							num = (short)1221656609;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_92C;
					case 5:
						goto IL_10B4;
					case 6:
						if (dataProfilesRecset != null)
						{
							num = (short)1762328590;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_DAD;
					case 7:
						if (radioInformation.FrequencyRanges.RadInfoFrequencyRangesExtendRange762Capable_A43555.Value)
						{
							num = (short)310771712;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_10B6;
					case 8:
						num = (short)1271463960;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 9:
						goto IL_864;
					case 10:
						if (global::ConstraintHelper.UtilityMack.IsPortableOnly())
						{
							num = (short)1933967399;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_F8E;
					case 11:
						if (actionConsolidationRecset != null)
						{
							num = (short)1907032086;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_92C;
					case 12:
						goto IL_266;
					case 13:
						if (radioInformation.Labtool.RadInfoLabtoolQ445FiregroundSupport_A8796.Value)
						{
							num = (short)1532821544;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_648;
					case 14:
						num = (short)1507983413;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 15:
						goto IL_E82;
					case 16:
						if (conventionalPersonalityRecset.Count > 0)
						{
							num = (short)1290534929;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_864;
					case 17:
					{
						global::Motorola.MackinawCPS.CoreFeatures.ConventionalPersonality.FrequencyOptionsInnerRecset frequencyOptionsInnerRecset = (conventionalPersonalityRecset[0] as global::Motorola.MackinawCPS.CoreFeatures.ConventionalPersonality.ConventionalPersonality).Features.Parent[10148].EmbeddedRecset as global::Motorola.MackinawCPS.CoreFeatures.ConventionalPersonality.FrequencyOptionsInnerRecset;
						num = (short)1530265635;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 18:
						if (global::ConstraintHelper.UtilityMack.IsPortablePro)
						{
							num = (short)1829371946;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_C6A;
					case 19:
						if (!trunkingEmergencyProfiles.General.TrkEmerProfGeneralEmergencyOperation_A7926.HiddenStatic)
						{
							num = (short)251396139;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_E82;
					case 20:
					{
						global::Motorola.MackinawCPS.CoreFeatures.ConventionalPersonality.FrequencyOptionsInnerRecset frequencyOptionsInnerRecset;
						if (!(frequencyOptionsInnerRecset[0] as global::Motorola.MackinawCPS.CoreFeatures.ConventionalPersonality.FrequencyOptionsInner).FrequencyOptionsInnerSection.CnvPerConventionalChannelOptionsUserSelectablePLMPLEnhance_43029.HiddenStatic)
						{
							num = (short)1598488579;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_864;
					}
					case 21:
					{
						global::System.Collections.Generic.IEnumerator<global::AcpBusinessLayer.ListItem> enumerator = ((global::AcpCommonLib.FeatureManager.GetFeature(2064) as global::Motorola.MackinawCPS.CoreFeatures.TrunkingSystem.TrunkingSystemRecset)[0] as global::Motorola.MackinawCPS.CoreFeatures.TrunkingSystem.TrunkingSystem).General.TrkSysGeneralCoverageType_A7782.Items.GetEnumerator();
						num = (short)110297144;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 22:
						num = (short)865796100;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 23:
						if (radioInformation.Labtool.RadInfoLabtoolQ53NonFEDFPPAndZoneClone_A8799.Value)
						{
							num = (short)677511169;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_F8E;
					case 24:
						if (radioWide.TPS.RadWideTPSAudibleEmergencyBeaconRouting_A41972 != null)
						{
							num = (short)480968761;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_266;
					case 25:
						goto IL_F8E;
					case 26:
					{
						global::Motorola.MackinawCPS.CoreFeatures.ConventionalPersonality.FrequencyOptionsInnerRecset frequencyOptionsInnerRecset;
						if (frequencyOptionsInnerRecset.Count > 0)
						{
							num = (short)931004453;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_864;
					}
					case 27:
						goto IL_C6A;
					case 28:
						goto IL_38B;
					case 29:
						if (!(dataProfilesRecset[0] as global::Motorola.MackinawCPS.CoreFeatures.DataProfiles.DataProfiles).Features.DataProfFeaturesARSMode_A7465.HiddenStatic)
						{
							num = (short)678035515;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_DAD;
					case 30:
						if (radioInformation.Labtool.RadInfoLabtoolManDown_A40006.Value)
						{
							num = (short)925237297;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_38B;
					case 31:
						num = (short)510328861;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 32:
						if (radioWide.TPS != null)
						{
							num = (short)2078408712;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_266;
					case 33:
						this.a(global::CommonResources.AcgResources.ID_CONSOLIDATEDACTIONSENHANCEMENT, radioWide.Labtool.RadWideLabtoolConsolidatedActionEnhancement_A43036.Value, new global::SpecialFeatures.RadioFeatureSet.PageRadioFeatureSet.PCIExcisedConstraint(global::SpecialFeatures.RadioFeatureSet.PCIGatings.IsConsolidatedActionsEnhancementUsed));
						num = (short)481099814;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 34:
						if (radioInformation.Labtool.RadioInfoLabToolGA00631DvrsMsuOperation_A41827.Value)
						{
							num = (short)885194810;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_572;
					case 35:
					{
						global::Motorola.MackinawCPS.CoreFeatures.ConventionalPersonality.FrequencyOptionsInnerRecset frequencyOptionsInnerRecset;
						if (frequencyOptionsInnerRecset != null)
						{
							num = (short)500367404;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_864;
					}
					case 36:
						if (!radioInformation.Labtool.RadInfoLabtoolQ52FEDFPPAndZoneClone_A8798.Value)
						{
							num = (short)835518516;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_F4B;
					case 37:
						num = (short)632029204;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 38:
						goto IL_92C;
					case 39:
						num = (short)1128529956;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 40:
						this.a(global::CommonResources.AcgResources.ID_PERSONNELACCOUNTABILITYALERTCAPABLE, radioWide.Labtool.RadWideLabtoolPAAlertCapability_A42944.Value, new global::SpecialFeatures.RadioFeatureSet.PageRadioFeatureSet.PCIExcisedConstraint(global::SpecialFeatures.RadioFeatureSet.PCIGatings.IsPersonnelAccountabilityAlertUsed));
						num = (short)1480589362;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 41:
						this.a(global::CommonResources.AcgResources.ID_AUDIBLEEMERGENCYBEACONROUTING, radioWide.Labtool.RadWideLabtoolAudibleBeaconRoutingCapable_A41974.Value && !flag, new global::SpecialFeatures.RadioFeatureSet.PageRadioFeatureSet.PCIExcisedConstraint(global::SpecialFeatures.RadioFeatureSet.PCIGatings.IsBeaconRoutingUsed));
						this.a(global::CommonResources.AppResources.Expanded_MDC_ID_Capable, conventionalWide.Labtool.CnvWideLabtoolExpandedMDCID_A41790.Value, new global::SpecialFeatures.RadioFeatureSet.PageRadioFeatureSet.PCIExcisedConstraint(global::SpecialFeatures.RadioFeatureSet.PCIGatings.ExpandedMDC1200Excised));
						num = (short)1286995998;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 42:
						this.a(global::CommonResources.AcgResources.ID_ACTIVEMICFORBLUETOOTHPTTCAPABLE, radioWide.Labtool.RadWideLabtoolActiveMicForBTPTTCapable_43053.Value, new global::SpecialFeatures.RadioFeatureSet.PageRadioFeatureSet.PCIExcisedConstraint(global::SpecialFeatures.RadioFeatureSet.PCIGatings.IsActiveMicForPTTUsed));
						num = (short)851443739;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 43:
						this.a(global::CommonResources.AcgResources.ID_EMERGENCYCALLONLYWITHHOTMICCAPABLE, radioWide.Labtool.RadWideLabtoolEmergencyCallOnlywithHotMicCapable_A43162Value, new global::SpecialFeatures.RadioFeatureSet.PageRadioFeatureSet.PCIExcisedConstraint(global::SpecialFeatures.RadioFeatureSet.PCIGatings.IsEmergencyCallOnlywithHotMicCapableUsed));
						num = (short)2044067855;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 44:
						num = (short)1964245018;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 45:
						this.a(global::CommonResources.AcgResources.ID_MOSCADACE3600CAPABLE, global::ConstraintHelper.UtilityMack.IsMobile() && radioWide.Labtool.RadioWideMOSCADACE3000Capability_A42772.Value, new global::SpecialFeatures.RadioFeatureSet.PageRadioFeatureSet.PCIExcisedConstraint(global::SpecialFeatures.RadioFeatureSet.PCIGatings.IsMOSCADIsUsed));
						num = (short)236322829;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 46:
						this.a(global::CommonResources.AcgResources.ID_MFKEMERGENCYACCESS, global::ConstraintHelper.UtilityMack.IsMobile() && radioWide.Labtool.RadWideLabtoolMFKEmergencyAccess_A42216.Value, new global::SpecialFeatures.RadioFeatureSet.PageRadioFeatureSet.PCIExcisedConstraint(global::SpecialFeatures.RadioFeatureSet.PCIGatings.IsMFKEmergencyAccessUsed));
						this.a(global::CommonResources.AppResources.Emergency_Hot_Aux_Mic_ID, global::SpecialFeatures.RadioFeatureSet.PCIGatings.IsEmergencyHotMicAvailable(), new global::SpecialFeatures.RadioFeatureSet.PageRadioFeatureSet.PCIExcisedConstraint(global::SpecialFeatures.RadioFeatureSet.PCIGatings.IsEmergencyHotMicUsed));
						this.a(global::CommonResources.AppResources.Audible_Emergency_Beacon_ID, global::SpecialFeatures.RadioFeatureSet.PCIGatings.IsAudibleEmergencyBeaconAvailable(), new global::SpecialFeatures.RadioFeatureSet.PageRadioFeatureSet.PCIExcisedConstraint(global::SpecialFeatures.RadioFeatureSet.PCIGatings.IsAudibleEmergencyBeaconUsed));
						this.a(global::CommonResources.AcgResources.ID_AUDIOENHANCEMENT, radioWide.Labtool.RadWideLabtoolAudioEnhancement_A42736.Value, new global::SpecialFeatures.RadioFeatureSet.PageRadioFeatureSet.PCIExcisedConstraint(global::SpecialFeatures.RadioFeatureSet.PCIGatings.IsAudioEnhacementUsed));
						this.a(global::CommonResources.AppResources.WWP_2_Knobs_Capable, radioWide.Labtool.RadWideLabtoolAPXDualKnobs_A42537.Value, null);
						this.a(global::CommonResources.AcgResources.ID_DYNAMICZONESCANCAPABILITY, global::SpecialFeatures.RadioFeatureSet.PCIGatings.IsDynamicZoneScanCapabilityAvailable(), new global::SpecialFeatures.RadioFeatureSet.PageRadioFeatureSet.PCIExcisedConstraint(global::SpecialFeatures.RadioFeatureSet.PCIGatings.IsDynamicZoneScanCapabilityUsed));
						num = (short)114688034;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 47:
						if (trunkingEmergencyProfiles != null)
						{
							num = (short)1770389552;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_E82;
					case 48:
						num = (short)745996307;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 49:
						this.a(global::CommonResources.AppResources.ManDown_Emer_Prf_Cfg, radioWide.Labtool.ManDownPersonalityConfigurableCapable_42082.Value, new global::SpecialFeatures.RadioFeatureSet.PageRadioFeatureSet.PCIExcisedConstraint(global::SpecialFeatures.RadioFeatureSet.PCIGatings.IsManDownPerCfgCapUsed));
						this.a(global::CommonResources.AppResources.Emer_Tone_Cfg, radioWide.Labtool.ToneEmergencyConfigurableCapable_42083.Value, new global::SpecialFeatures.RadioFeatureSet.PageRadioFeatureSet.PCIExcisedConstraint(global::SpecialFeatures.RadioFeatureSet.PCIGatings.IsToneEmerCfgCapUsed));
						num = (short)1975975964;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 50:
						goto IL_648;
					case 51:
						goto IL_DAD;
					case 52:
						num = (short)692781079;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 53:
						if (dataProfilesRecset.Count > 0)
						{
							num = (short)986578975;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_DAD;
					case 54:
					{
						num = (short)1212547072;
						short num3 = num;
						num = (short)934215696;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 55:
						if (radioInformation.Labtool.RadioInfoLabToolGA00631DvrsMsuOperation_A41827.Value)
						{
							num = (short)2095841301;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_BED;
					case 56:
						try
						{
							num = (short)217120768;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								switch (num2)
								{
								case 0:
									switch (0)
									{
									case 0:
										goto IL_A07;
									}
									continue;
								case 1:
									num = (short)1322647554;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 2:
								{
									global::AcpBusinessLayer.ListItem listItem;
									if (listItem.ItemVisibility)
									{
										num = (short)1100152838;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									break;
								}
								case 3:
									goto IL_B2D;
								case 4:
									num = (short)880541699;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 5:
								{
									global::AcpBusinessLayer.ListItem listItem;
									if (listItem.ItemName == global::CommonResources.AcgResources.ID_INTERWACNROAMING)
									{
										num = (short)1615396865;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									break;
								}
								case 6:
									this.a(global::CommonResources.AcgResources.ID_LIMITEDISSIDVRSOPERATIONCAPABLE, radioWide.Labtool.RadWideLabtoolLimitedISSIDVRSOperationCapable_43045, new global::SpecialFeatures.RadioFeatureSet.PageRadioFeatureSet.PCIExcisedConstraint(global::SpecialFeatures.RadioFeatureSet.PCIGatings.IsLimitedISSIDVRSOperationCapableUsed));
									num = (short)1311113224;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 7:
								{
									global::System.Collections.Generic.IEnumerator<global::AcpBusinessLayer.ListItem> enumerator;
									if (!enumerator.MoveNext())
									{
										num = (short)543227908;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									global::AcpBusinessLayer.ListItem listItem = enumerator.Current;
									num = (short)898760709;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								}
								IL_A40:
								num = (short)267386887;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								IL_A07:
								goto IL_A40;
							}
							IL_B2D:;
						}
						finally
						{
							for (;;)
							{
								IL_B32:
								num = (short)1784807425;
								num2 = (int)((global::System.IntPtr)num);
								for (;;)
								{
									global::System.Collections.Generic.IEnumerator<global::AcpBusinessLayer.ListItem> enumerator;
									switch (num2)
									{
									case 0:
										goto IL_BEA;
									case 1:
									{
										num = (short)398145942;
										short num4 = num;
										num = (short)1310341526;
										switch ((num4 == num) ? 1 : 0)
										{
										case 0:
										case 2:
											goto IL_B32;
										default:
											num = (short)1933377536;
											if (num != 0)
											{
											}
											switch (0)
											{
											case 0:
												goto IL_BAF;
											}
											continue;
										}
										break;
									}
									case 2:
										enumerator.Dispose();
										num = (short)1325334528;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									IL_BAF:
									if (enumerator == null)
									{
										goto IL_BEC;
									}
									num = (short)1565523970;
									num2 = (int)((global::System.IntPtr)num);
								}
							}
							IL_BEA:
							IL_BEC:;
						}
						goto IL_BED;
					case 57:
						flag = radioWide.TPS.RadWideTPSAudibleEmergencyBeaconRouting_A41972.HiddenStatic;
						num = (short)1159528460;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 58:
						this.a(global::CommonResources.AppResources.DVRS_Trunking_Status_ID, radioWide.Labtool.RadioWideDVRSTrunkingStatusCapability_A42772.Value, new global::SpecialFeatures.RadioFeatureSet.PageRadioFeatureSet.PCIExcisedConstraint(global::SpecialFeatures.RadioFeatureSet.PCIGatings.IsDVRSTRKStatusCapabilityUsed));
						num = (short)2085027900;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 59:
						this.a(global::CommonResources.AcgResources.ID_ENHANCEDARS, radioWide.Labtool.RadWideLabtoolEnhancedARS_A43084.Value, new global::SpecialFeatures.RadioFeatureSet.PageRadioFeatureSet.PCIExcisedConstraint(global::SpecialFeatures.RadioFeatureSet.PCIGatings.IsEnhancedARSUsed));
						num = (short)1649082419;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 60:
						goto IL_572;
					}
					goto IL_123;
					IL_266:
					num = (short)1945763881;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_38B:
					this.a(global::CommonResources.AppResources.Disable_Emergency_Call_Indications_Capable, radioWide.Labtool.RadWideLabtoolSuppressEmergencyCallCapability_A42143.Value, new global::SpecialFeatures.RadioFeatureSet.PageRadioFeatureSet.PCIExcisedConstraint(global::SpecialFeatures.RadioFeatureSet.PCIGatings.DisableEmergencyCallIndicationsExcised));
					this.a(global::CommonResources.AppResources.PASS_Alarm_Filter_Capable, radioWide.Labtool.PASSAlarmFilterCapable_A42387.Value, new global::SpecialFeatures.RadioFeatureSet.PageRadioFeatureSet.PCIExcisedConstraint(global::SpecialFeatures.RadioFeatureSet.PCIGatings.IsPassAlarmFilterUsed));
					this.a(global::CommonResources.AcgResources.ID_MARITIMERADIOSOFTWARE, radioWide.Labtool.RadWideLabtoolMaritimeRadioSoftware_A42191Value, null);
					this.a(global::CommonResources.AppResources.APX6000_P25_Radio, radioWide.Labtool.RadWideLabtoolAPX6000P25Radio_A42121Value, null);
					num = (short)506527790;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_572:
					num = (short)222691373;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_648:
					num = (short)189923329;
					if (num != 0)
					{
					}
					conventionalPersonalityRecset = (global::AcpCommonLib.FeatureManager.GetFeature(2059) as global::Motorola.MackinawCPS.CoreFeatures.ConventionalPersonality.ConventionalPersonalityRecset);
					num = (short)49348610;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_864:
					actionConsolidationRecset = (global::AcpCommonLib.FeatureManager.GetFeature(4008) as global::Motorola.MackinawCPS.CoreFeatures.ActionConsolidation.ActionConsolidationRecset);
					num = (short)1763246091;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_92C:
					num = (short)487718967;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_BED:
					num = (short)759037970;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_C6A:
					this.a(global::CommonResources.AcgResources.ID_APXSINGLETONECAPABLE, radioWide.Labtool.RadWideLabtoolAPXSingletoneCapable_43080.Value, new global::SpecialFeatures.RadioFeatureSet.PageRadioFeatureSet.PCIExcisedConstraint(global::SpecialFeatures.RadioFeatureSet.PCIGatings.IsAPXSingletoneCapableUsed));
					dataProfilesRecset = (global::AcpCommonLib.FeatureManager.GetFeature(2054) as global::Motorola.MackinawCPS.CoreFeatures.DataProfiles.DataProfilesRecset);
					num = (short)74252294;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_DAD:
					trunkingEmergencyProfiles = (global::AcpCommonLib.FeatureManager.GetFeature(2076)[0] as global::Motorola.MackinawCPS.CoreFeatures.TrunkingEmergencyProfiles.TrunkingEmergencyProfiles);
					num = (short)1446182959;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_E82:
					num = (short)30474250;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_F4B:
					this.a(global::CommonResources.AcgResources.ID_ZONECLONECAPABLE, radioWide.Labtool.RadioWideLabtoolZoneCloneCapable_43238.Value, new global::SpecialFeatures.RadioFeatureSet.PageRadioFeatureSet.PCIExcisedConstraint(global::SpecialFeatures.RadioFeatureSet.PCIGatings.IsZoneCloneCapableUsed));
					num = (short)1075314713;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_F8E:
					this.a(global::CommonResources.AcgResources.ID_EMERGENCYCALLTERMINATION, radioWide.Labtool.RadioWideLabtoolEmergencyCallTermination_43348.Value, new global::SpecialFeatures.RadioFeatureSet.PageRadioFeatureSet.PCIExcisedConstraint(global::SpecialFeatures.RadioFeatureSet.PCIGatings.IsEmergencyCallTerminationCapableUsed));
					this.a(global::CommonResources.AcgResources.ID_INTELLIGENTPRIORITYSCANCAPABLE, radioWide.Labtool.RadWideLabtoolIntelligentPriorityScanCapable_43411.Value, new global::SpecialFeatures.RadioFeatureSet.PageRadioFeatureSet.PCIExcisedConstraint(global::SpecialFeatures.RadioFeatureSet.PCIGatings.IsIPSCapableUsed));
					this.a(global::CommonResources.AcgResources.ID_DISABLEENCRYPTION, radioWide.Labtool.RadWideLabtoolDisableEncryption_43371.Value, null);
					this.a(global::CommonResources.AcgResources.ID_DISABLEWINDNOISEREDUCTIONLEVELFORACCESSORIES, radioWide.Labtool.RadioWideLabtoolDisableWindNoiseReductionLevelForAccessories_43548.Value, null);
					this.a(global::CommonResources.AcgResources.ID_RADIOLOCKPASSWORDEXTENSIONCAPABLE, radioWide.Labtool.TEN_DIGIT_RL_PSWD_capable_43711.Value, new global::SpecialFeatures.RadioFeatureSet.PageRadioFeatureSet.PCIExcisedConstraint(global::SpecialFeatures.RadioFeatureSet.PCIGatings.IsRadioLockExtensionCapableUsed));
					num = (short)266076167;
					num2 = (int)((global::System.IntPtr)num);
				}
				IL_10B4:
				IL_10B6:
				this.a(global::CommonResources.AcgResources.ID_EXTENDEDUHFR1480MHZCAPABLE, radioInformation.FrequencyRanges.RadInfoFrequencyRangesExtendedUHFR1480MHzCapable_A43578.Value, null);
				this.a(global::CommonResources.AcgResources.ID_EXTENDEDPLTONESET, radioWide.Labtool.RadioWideLabtoolExtendedPLToneSet_43769.Value, new global::SpecialFeatures.RadioFeatureSet.PageRadioFeatureSet.PCIExcisedConstraint(global::SpecialFeatures.RadioFeatureSet.PCIGatings.IsExtendedPLToneSetUsed));
				this.a(global::CommonResources.AcgResources.ID_ALLOWPSUSECURE, radioWide.Labtool.AllowPSUSecure_43809.Value, new global::SpecialFeatures.RadioFeatureSet.PageRadioFeatureSet.PCIExcisedConstraint(global::SpecialFeatures.RadioFeatureSet.PCIGatings.IsAllowPSUSecureUsed));
				this.a(global::CommonResources.AcgResources.ID_UCLCONTACTSLIMITATIONENHANCEMENT, radioWide.Labtool.UCLContactsLimitationEnhancement_43811.Value, new global::SpecialFeatures.RadioFeatureSet.PageRadioFeatureSet.PCIExcisedConstraint(global::SpecialFeatures.RadioFeatureSet.PCIGatings.IsUCLContactsLimitationEnhancementUsed));
				this.a(global::CommonResources.AcgResources.ID_REMOTEMOUNTO3CH, radioInformation.Labtool.RadInfoLabtoolAPX1500EHNO3CH_A44832.Value, new global::SpecialFeatures.RadioFeatureSet.PageRadioFeatureSet.PCIExcisedConstraint(global::SpecialFeatures.RadioFeatureSet.PCIGatings.IsRemoteMountO3Capable));
				this.a(global::CommonResources.AcgResources.ID_DVRSRANGEEXT, radioWide.Labtool.DVRSRangeExt_44809.Value, new global::SpecialFeatures.RadioFeatureSet.PageRadioFeatureSet.PCIExcisedConstraint(global::SpecialFeatures.RadioFeatureSet.PCIGatings.IsDVRSRangeExtUsed));
				this.a(global::CommonResources.AcgResources.ID_INDIRECTPTTAUDIOROUTINGPCI, radioWide.Labtool.RadWideLabtoolIndirectPTTAudioRoutingPCI_44817.Value, new global::SpecialFeatures.RadioFeatureSet.PageRadioFeatureSet.PCIExcisedConstraint(global::SpecialFeatures.RadioFeatureSet.PCIGatings.IsIndirectPTTAudioRoutingUsed));
				this.a(global::CommonResources.AcgResources.ID_ANALOGWIDEBANDDATAPCI, radioWide.Labtool.RadWideLabtoolAnalogWideBandDataPCIBit_44885.Value, new global::SpecialFeatures.RadioFeatureSet.PageRadioFeatureSet.PCIExcisedConstraint(global::SpecialFeatures.RadioFeatureSet.PCIGatings.IsAnalogWidebandDataPCIRoutingUsed));
				return;
				IL_123:
				radioInformation = (global::AcpCommonLib.FeatureManager.GetFeature(2049)[0] as global::Motorola.MackinawCPS.CoreFeatures.RadioInformation.RadioInformation);
				radioWide = (global::AcpCommonLib.FeatureManager.GetFeature(2045)[0] as global::Motorola.MackinawCPS.CoreFeatures.RadioWide.RadioWide);
				conventionalWide = (global::AcpCommonLib.FeatureManager.GetFeature(2024)[0] as global::Motorola.MackinawCPS.CoreFeatures.ConventionalWide.ConventionalWide);
				this.a(global::CommonResources.AppResources.Extended_UHF_R1_Capable, radioInformation.FrequencyRanges.RadInfoFrequencyRangesExtendedUHFR1Capable_A41443Value, null);
				this.a(global::CommonResources.AppResources.Ultra_Low_Power_Capable, radioWide.Labtool.RadWideLabtoolUltraLowPowerSoldierMacCapable_A41710Value, null);
				this.a(global::CommonResources.AppResources.Emergency_Revert_Capable, radioWide.Labtool.RadWideLabtoolEmergencyRevertCapable_A41918.Value, new global::SpecialFeatures.RadioFeatureSet.PageRadioFeatureSet.PCIExcisedConstraint(global::SpecialFeatures.RadioFeatureSet.PCIGatings.IsMulitEmergencyRevertUsed));
				flag = true;
				num = (short)1861812256;
				num2 = (int)((global::System.IntPtr)num);
				goto IL_28;
			}
			}
		}

		// Token: 0x06000A2C RID: 2604 RVA: 0x000BB7A8 File Offset: 0x000B99A8
		private void a()
		{
			short num = (short)1388395531;
			short num2 = num;
			num = (short)288766987;
			switch (num2 == num)
			{
			}
			num = (short)590544897;
			if (num != 0)
			{
			}
			num = (short)1358233600;
			if (num != 0)
			{
			}
			num = (short)702873600;
			short num3 = num;
			this.ExpanderRadioFeatureSetGeneral.IsExpanded = true;
			this.ExpanderRadioFeatureSetGeneral.Visibility = global::System.Windows.Visibility.Visible;
			this.ExpanderRadioFeatureSetUsed.IsExpanded = true;
			this.ExpanderRadioFeatureSetUsed.Visibility = global::System.Windows.Visibility.Visible;
		}

		// Token: 0x06000A2D RID: 2605 RVA: 0x000BB884 File Offset: 0x000B9A84
		[global::System.Diagnostics.DebuggerNonUserCode]
		[global::System.CodeDom.Compiler.GeneratedCode("PresentationBuildTasks", "5.0.10.0")]
		public void InitializeComponent()
		{
			int a_ = 10;
			short num;
			for (;;)
			{
				num = (short)982646784;
				short num2 = num;
				if (this.c)
				{
					break;
				}
				num = (short)718896537;
				short num3 = num;
				num = (short)1020755353;
				switch ((num3 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					break;
				default:
					goto IL_97;
				}
			}
			num = (short)1640169473;
			if (num != 0)
			{
			}
			return;
			IL_97:
			num = (short)2026045440;
			if (num != 0)
			{
			}
			this.c = true;
			global::System.Uri resourceLocator = new global::System.Uri(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("ꊌ\udc8eﺖ\udb9c爵삠힢키햦첨\ud8aa隬첮\udeb0\udeb2어\ud8b6ힸ\udeba펼쮾뇂꓄ꏆꃈ꓊ꯌ꫎냐꟒ꃔꗖ볘꣚룜ꯞ컠釢蓤菦胨蓪诬諮郰蟲胴藶鳸裺飼课⼀笂搄樆攈", a_), global::System.UriKind.Relative);
			global::System.Windows.Application.LoadComponent(this, resourceLocator);
		}

		// Token: 0x06000A2E RID: 2606 RVA: 0x000BB964 File Offset: 0x000B9B64
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		[global::System.Diagnostics.DebuggerNonUserCode]
		[global::System.CodeDom.Compiler.GeneratedCode("PresentationBuildTasks", "5.0.10.0")]
		void global::System.Windows.Markup.IComponentConnector.Connect(int connectionId, object target)
		{
			short num = (short)685375489;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				switch (num2)
				{
				case 0:
					goto IL_244;
				case 1:
					switch (0)
					{
					case 0:
						goto IL_30;
					}
					continue;
				case 2:
					goto IL_9D;
				}
				IL_30:
				switch (connectionId)
				{
				case 1:
					goto IL_328;
				case 2:
					goto IL_11B;
				case 3:
					goto IL_249;
				case 4:
					goto IL_EA;
				case 5:
					goto IL_188;
				case 6:
					goto IL_256;
				case 7:
					goto IL_21F;
				case 8:
					goto IL_27A;
				case 9:
				{
					num = (short)2128228044;
					short num3 = num;
					num = (short)1686187724;
					switch ((num3 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						break;
					default:
						goto IL_305;
					}
					break;
				}
				case 10:
					goto IL_17B;
				case 11:
					goto IL_C6;
				case 12:
					goto IL_341;
				case 13:
					goto IL_2AB;
				case 14:
					goto IL_A2;
				case 15:
					goto IL_14A;
				case 16:
					goto IL_287;
				case 17:
					goto IL_10E;
				case 18:
					goto IL_1AC;
				case 19:
					goto IL_157;
				case 20:
					goto IL_1FB;
				default:
					num = (short)2063204354;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				IL_9D:
				num = (short)253820928;
				num2 = (int)((global::System.IntPtr)num);
			}
			IL_A2:
			this.FeatureSetGeneralUsedFLASHcode = (global::AcpUI.AcpTextBox)target;
			this.FeatureSetGeneralUsedFLASHcode.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_C6:
			this.LblFeatureSetGeneralPurchasedFLASHcode = (global::AcpUI.AcpLabel)target;
			this.LblFeatureSetGeneralPurchasedFLASHcode.MouseDoubleClick += new global::System.Windows.Input.MouseButtonEventHandler(this.OnFieldNameDoubleClick);
			return;
			IL_EA:
			this.HLinkRadioFeatureSetGeneral = (global::System.Windows.Documents.Hyperlink)target;
			this.HLinkRadioFeatureSetGeneral.Click += this.HLinkClick;
			return;
			IL_10E:
			this.ExpanderRadioExtendedFeatureSetUsed = (global::AcpUI.AcpExpander)target;
			return;
			IL_11B:
			((global::System.Windows.Input.CommandBinding)target).Executed += new global::System.Windows.Input.ExecutedRoutedEventHandler(this.buttonHelp_Click);
			((global::System.Windows.Input.CommandBinding)target).CanExecute += this.F1HelpCommandCanExcute;
			return;
			IL_14A:
			this.ExpanderRadioFeatureSetUsed = (global::AcpUI.AcpExpander)target;
			return;
			IL_157:
			this.buttonClose = (global::System.Windows.Controls.Button)target;
			this.buttonClose.Click += this.buttonClose_Click;
			return;
			IL_17B:
			this.StdGrpBoxExpanderRadioFeatureSetGeneralPseudo0 = (global::System.Windows.Controls.Grid)target;
			return;
			IL_188:
			this.HLinkRadioFeatureSetUsed = (global::System.Windows.Documents.Hyperlink)target;
			this.HLinkRadioFeatureSetUsed.Click += this.HLinkClick;
			return;
			IL_1AC:
			num = (short)2083258368;
			short num4 = num;
			this.ExpanderRadioExtendedFeatureSetUsedTable = (global::AcpUI.AcpXamDataPresenter)target;
			this.ExpanderRadioExtendedFeatureSetUsedTable.RecordActivating += this.ExpanderRadioFeatureSetUsedTable_RecordActivating;
			return;
			IL_1FB:
			this.buttonHelp = (global::System.Windows.Controls.Button)target;
			this.buttonHelp.Click += this.buttonHelp_Click;
			return;
			IL_21F:
			this.MyStackPanel = (global::System.Windows.Controls.StackPanel)target;
			return;
			IL_244:
			this.c = true;
			return;
			IL_249:
			this.ThemeBaseObj = (global::AcpUI.Common.AcpThemeBase)target;
			return;
			IL_256:
			this.HLinkRadioExtendedFeatureSetUsed = (global::System.Windows.Documents.Hyperlink)target;
			this.HLinkRadioExtendedFeatureSetUsed.Click += this.HLinkClick;
			return;
			IL_27A:
			this.ExpanderRadioFeatureSetGeneral = (global::AcpUI.AcpExpander)target;
			return;
			IL_287:
			this.ExpanderRadioFeatureSetUsedTable = (global::AcpUI.AcpXamDataPresenter)target;
			this.ExpanderRadioFeatureSetUsedTable.RecordActivating += this.ExpanderRadioFeatureSetUsedTable_RecordActivating;
			return;
			IL_2AB:
			this.LblFeatureSetGeneralUsedFLASHcode = (global::AcpUI.AcpLabel)target;
			this.LblFeatureSetGeneralUsedFLASHcode.MouseDoubleClick += new global::System.Windows.Input.MouseButtonEventHandler(this.OnFieldNameDoubleClick);
			return;
			IL_305:
			num = (short)665583616;
			if (num != 0)
			{
			}
			this.GrpBoxExpanderRadioFeatureSetGeneralPseudo0 = (global::AcpUI.AcpGroupBox)target;
			return;
			IL_328:
			((global::SpecialFeatures.RadioFeatureSet.PageRadioFeatureSet)target).Loaded += this.OnLoaded;
			return;
			IL_341:
			num = (short)561905665;
			if (num != 0)
			{
			}
			this.FeatureSetGeneralPurchasedFLASHcode = (global::AcpUI.AcpTextBox)target;
			this.FeatureSetGeneralPurchasedFLASHcode.GotFocus += this.OnFieldNameDoubleClick;
		}

		// Token: 0x040003E5 RID: 997
		private global::SpecialFeatures.RadioFeatureSet.RadioFeatureSetRecset a;

		// Token: 0x040003E6 RID: 998
		private global::SpecialFeatures.Flashport.Recordset b;

		// Token: 0x040003E7 RID: 999
		internal global::AcpUI.Common.AcpThemeBase ThemeBaseObj;

		// Token: 0x040003E8 RID: 1000
		internal global::System.Windows.Documents.Hyperlink HLinkRadioFeatureSetGeneral;

		// Token: 0x040003E9 RID: 1001
		internal global::System.Windows.Documents.Hyperlink HLinkRadioFeatureSetUsed;

		// Token: 0x040003EA RID: 1002
		internal global::System.Windows.Documents.Hyperlink HLinkRadioExtendedFeatureSetUsed;

		// Token: 0x040003EB RID: 1003
		internal global::System.Windows.Controls.StackPanel MyStackPanel;

		// Token: 0x040003EC RID: 1004
		internal global::AcpUI.AcpExpander ExpanderRadioFeatureSetGeneral;

		// Token: 0x040003ED RID: 1005
		internal global::AcpUI.AcpGroupBox GrpBoxExpanderRadioFeatureSetGeneralPseudo0;

		// Token: 0x040003EE RID: 1006
		internal global::System.Windows.Controls.Grid StdGrpBoxExpanderRadioFeatureSetGeneralPseudo0;

		// Token: 0x040003EF RID: 1007
		internal global::AcpUI.AcpLabel LblFeatureSetGeneralPurchasedFLASHcode;

		// Token: 0x040003F0 RID: 1008
		internal global::AcpUI.AcpTextBox FeatureSetGeneralPurchasedFLASHcode;

		// Token: 0x040003F1 RID: 1009
		internal global::AcpUI.AcpLabel LblFeatureSetGeneralUsedFLASHcode;

		// Token: 0x040003F2 RID: 1010
		internal global::AcpUI.AcpTextBox FeatureSetGeneralUsedFLASHcode;

		// Token: 0x040003F3 RID: 1011
		internal global::AcpUI.AcpExpander ExpanderRadioFeatureSetUsed;

		// Token: 0x040003F4 RID: 1012
		internal global::AcpUI.AcpXamDataPresenter ExpanderRadioFeatureSetUsedTable;

		// Token: 0x040003F5 RID: 1013
		internal global::AcpUI.AcpExpander ExpanderRadioExtendedFeatureSetUsed;

		// Token: 0x040003F6 RID: 1014
		internal global::AcpUI.AcpXamDataPresenter ExpanderRadioExtendedFeatureSetUsedTable;

		// Token: 0x040003F7 RID: 1015
		internal global::System.Windows.Controls.Button buttonClose;

		// Token: 0x040003F8 RID: 1016
		internal global::System.Windows.Controls.Button buttonHelp;

		// Token: 0x040003F9 RID: 1017
		private bool c;

		// Token: 0x02000081 RID: 129
		// (Invoke) Token: 0x06000A30 RID: 2608
		public delegate bool PCIExcisedConstraint();
	}
}
