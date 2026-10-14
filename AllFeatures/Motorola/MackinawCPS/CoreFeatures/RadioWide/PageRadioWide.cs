using System;
using System.CodeDom.Compiler;
using System.Collections;
using System.ComponentModel;
using System.Diagnostics;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Markup;
using AcpCommonLib;
using AcpUI;
using AcpUI.Common;
using AcpUILib;
using AllFeatures;
using Infragistics.Windows.DataPresenter;

namespace Motorola.MackinawCPS.CoreFeatures.RadioWide
{
	// Token: 0x0200017C RID: 380
	public class PageRadioWide : global::AcpUI.AcpPageFeature, global::System.Windows.Markup.IComponentConnector, global::System.Windows.Markup.IStyleConnector
	{
		// Token: 0x06003DF5 RID: 15861 RVA: 0x0039AB78 File Offset: 0x00398D78
		public PageRadioWide()
		{
			try
			{
				this.InitializeComponent();
				global::AcpUI.Common.Utility.SetDirection(this);
			}
			catch (global::System.Exception)
			{
			}
		}

		// Token: 0x06003DF6 RID: 15862 RVA: 0x0039ABB0 File Offset: 0x00398DB0
		public override void OnLoaded(object sender, global::System.Windows.RoutedEventArgs e)
		{
			short num = (short)1987903488;
			int num2 = (int)num;
			switch (num2)
			{
			default:
				num = (short)202375173;
				num2 = (int)((global::System.IntPtr)num);
				for (;;)
				{
					object obj;
					global::AcpUI.AcpExpander acpExpander;
					global::System.Collections.IEnumerator enumerator;
					switch (num2)
					{
					case 0:
						goto IL_3A8;
					case 1:
						goto IL_56E;
					case 2:
						goto IL_43B;
					case 3:
					{
						global::System.Windows.Data.CollectionView collectionView = (global::System.Windows.Data.CollectionView)global::System.Windows.Data.CollectionViewSource.GetDefaultView(obj);
						this.RecNavToolbarExpanderRadioWideTxPowerLevelsByFrequencyRangeNewBandPlan.MyDataPresenter = this.ExpanderRadioWideTxPowerLevelsByFrequencyRangeNewBandPlan;
						num = (short)763559938;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 4:
						goto IL_4DC;
					case 5:
						switch (0)
						{
						case 0:
							goto IL_AA;
						}
						continue;
					case 6:
						goto IL_4D7;
					case 7:
					{
						global::System.Windows.Data.CollectionView collectionView2 = (global::System.Windows.Data.CollectionView)global::System.Windows.Data.CollectionViewSource.GetDefaultView(obj);
						this.RecNavToolbarExpanderRadioWideRelockTimer.MyDataPresenter = this.ExpanderRadioWideRelockTimer;
						num = (short)1845559305;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 8:
						if (obj != null)
						{
							num = (short)1467285523;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_3A8;
					case 9:
						goto IL_47F;
					case 10:
						goto IL_D2;
					case 11:
						if (obj != null)
						{
							num = (short)122617868;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_68F;
					case 12:
					{
						global::System.Windows.Data.CollectionView collectionView3 = (global::System.Windows.Data.CollectionView)global::System.Windows.Data.CollectionViewSource.GetDefaultView(obj);
						this.RecNavToolbarExpanderRadioWideFCCNarrowBandingFrequencySplitTable.MyDataPresenter = this.ExpanderRadioWideFCCNarrowBandingFrequencySplitTable;
						num = (short)537329680;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 13:
						if (obj != null)
						{
							num = (short)105578520;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_D2;
					case 14:
						if (obj != null)
						{
							num = (short)1972305938;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_4DC;
					case 15:
						if (obj != null)
						{
							num = (short)2141585411;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_43B;
					case 16:
						goto IL_68F;
					case 17:
						goto IL_332;
					case 18:
					{
						global::System.Windows.Data.CollectionView collectionView4 = (global::System.Windows.Data.CollectionView)global::System.Windows.Data.CollectionViewSource.GetDefaultView(obj);
						this.RecNavToolbarExpanderRadioWideRxFrequencySplitFPP.MyDataPresenter = this.ExpanderRadioWideRxFrequencySplitFPP;
						num = (short)30998532;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 19:
					{
						num = (short)1994063872;
						short num3 = num;
						global::System.Windows.Data.CollectionView collectionView5 = (global::System.Windows.Data.CollectionView)global::System.Windows.Data.CollectionViewSource.GetDefaultView(obj);
						this.RecNavToolbarExpanderRadioWideTxFrequencySplitFPP.MyDataPresenter = this.ExpanderRadioWideTxFrequencySplitFPP;
						num = (short)592052224;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 20:
						if (obj != null)
						{
							num = (short)328138769;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_56E;
					case 21:
						if (obj != null)
						{
							num = (short)1889337345;
							if (num != 0)
							{
							}
							num = (short)965804039;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_47F;
					case 22:
						obj = null;
						obj = this.RecNavToolbarExpanderRadioWideTxPowerLevelsByFrequencyRange.MyRecordsetDataSource;
						num = (short)685572116;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 23:
						try
						{
							num = (short)16384004;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								switch (num2)
								{
								case 0:
									num = (short)1874329606;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 2:
									if (acpExpander != null)
									{
										num = (short)1923481605;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									break;
								case 3:
									if (!enumerator.MoveNext())
									{
										num = (short)858259456;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									acpExpander = (((global::System.Windows.UIElement)enumerator.Current) as global::AcpUI.AcpExpander);
									num = (short)707198978;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 4:
									switch (0)
									{
									case 0:
										goto IL_1FA;
									}
									continue;
								case 5:
									base.Expanders.Add(acpExpander);
									num = (short)2034368513;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 6:
									goto IL_2B9;
								}
								IL_264:
								num = (short)2116354051;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								IL_1FA:
								goto IL_264;
							}
							IL_2B9:
							goto IL_4B0;
						}
						finally
						{
							switch (0)
							{
							case 0:
								goto IL_2DB;
							}
							global::System.IDisposable disposable;
							for (;;)
							{
								IL_2C8:
								switch (num2)
								{
								case 0:
									if (disposable != null)
									{
										num = (short)750714881;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									goto IL_331;
								case 1:
									disposable.Dispose();
									num = (short)973864962;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 2:
									goto IL_32F;
								}
								goto IL_2DB;
							}
							IL_32F:
							IL_331:
							goto EndFinally_14;
							IL_2DB:
							disposable = (enumerator as global::System.IDisposable);
							num = (short)1052114944;
							num2 = (int)((global::System.IntPtr)num);
							goto IL_2C8;
							EndFinally_14:;
						}
						goto IL_332;
						IL_4B0:
						base.OnLoaded(sender, e);
						this.a = true;
						num = (short)76677126;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 24:
					{
						global::System.Windows.Data.CollectionView collectionView6 = (global::System.Windows.Data.CollectionView)global::System.Windows.Data.CollectionViewSource.GetDefaultView(obj);
						this.RecNavToolbarExpanderRadioWideGeneralLightbarPattern.MyDataPresenter = this.ExpanderRadioWideGeneralLightbarPattern;
						goto IL_389;
					}
					}
					IL_AA:
					if (!this.a)
					{
						num = (short)650182678;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					break;
					IL_D2:
					obj = this.RecNavToolbarExpanderRadioWideRelockTimer.MyRecordsetDataSource;
					num = (short)980353045;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_332:
					global::System.Windows.Data.CollectionView collectionView7 = (global::System.Windows.Data.CollectionView)global::System.Windows.Data.CollectionViewSource.GetDefaultView(obj);
					this.RecNavToolbarExpanderRadioWideTxPowerLevelsByFrequencyRange.MyDataPresenter = this.ExpanderRadioWideTxPowerLevelsByFrequencyRange;
					num = (short)106561537;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_389:
					num = (short)1246560266;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_3A8:
					obj = this.RecNavToolbarExpanderRadioWideFCCNarrowBandingFrequencySplitTable.MyRecordsetDataSource;
					num = (short)276676312;
					short num4 = num;
					num = (short)797163224;
					switch ((num4 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_389;
					default:
						num = (short)1125580800;
						if (num != 0)
						{
						}
						num = (short)1131479051;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					IL_43B:
					obj = this.RecNavToolbarExpanderRadioWideRxFrequencySplitFPP.MyRecordsetDataSource;
					num = (short)1023475726;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_47F:
					acpExpander = null;
					enumerator = this.MyStackPanel.Children.GetEnumerator();
					num = (short)91881495;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_4DC:
					obj = this.RecNavToolbarExpanderRadioWideTxFrequencySplitFPP.MyRecordsetDataSource;
					num = (short)77332488;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_56E:
					obj = this.RecNavToolbarExpanderRadioWideTxPowerLevelsByFrequencyRangeNewBandPlan.MyRecordsetDataSource;
					num = (short)1160445967;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_68F:
					obj = this.RecNavToolbarExpanderRadioWideGeneralLightbarPattern.MyRecordsetDataSource;
					num = (short)2058354701;
					num2 = (int)((global::System.IntPtr)num);
				}
				IL_4D7:
				this.MyStackPanel.Children[0].Focus();
				return;
			}
		}

		// Token: 0x06003DF7 RID: 15863 RVA: 0x0039B2CC File Offset: 0x003994CC
		public override void OnUnloaded(object sender, global::System.Windows.RoutedEventArgs e)
		{
			switch (0)
			{
			case 0:
				goto IL_1C;
			}
			int num;
			short num2;
			for (;;)
			{
				IL_0A:
				switch (num)
				{
				case 0:
					num2 = (short)2017525761;
					if (num2 != 0)
					{
					}
					if (this.a)
					{
						num2 = (short)63176705;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					return;
				case 1:
				{
					num2 = (short)976028006;
					short num3 = num2;
					num2 = (short)1140719974;
					switch ((num3 == num2) ? 1 : 0)
					{
					case 0:
					case 2:
						continue;
					default:
					{
						num2 = (short)1620574208;
						if (num2 != 0)
						{
						}
						base.OnUnloaded(sender, e);
						this.a = false;
						num2 = (short)952500224;
						short num4 = num2;
						num2 = (short)1660944386;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					}
					break;
				}
				case 2:
					return;
				}
				goto IL_1C;
			}
			return;
			IL_1C:
			this.RecNavToolbarExpanderRadioWideTxPowerLevelsByFrequencyRange.DataContext = null;
			this.RecNavToolbarExpanderRadioWideTxPowerLevelsByFrequencyRangeNewBandPlan.DataContext = null;
			this.RecNavToolbarExpanderRadioWideRxFrequencySplitFPP.DataContext = null;
			this.RecNavToolbarExpanderRadioWideTxFrequencySplitFPP.DataContext = null;
			this.RecNavToolbarExpanderRadioWideFCCNarrowBandingFrequencySplitTable.DataContext = null;
			this.RecNavToolbarExpanderRadioWideGeneralLightbarPattern.DataContext = null;
			this.RecNavToolbarExpanderRadioWideRelockTimer.DataContext = null;
			this.RecNavToolbarExpanderRadioWideTxPowerLevelsByFrequencyRange.MyDataPresenter = null;
			this.RecNavToolbarExpanderRadioWideTxPowerLevelsByFrequencyRangeNewBandPlan.MyDataPresenter = null;
			this.RecNavToolbarExpanderRadioWideRxFrequencySplitFPP.MyDataPresenter = null;
			this.RecNavToolbarExpanderRadioWideTxFrequencySplitFPP.MyDataPresenter = null;
			this.RecNavToolbarExpanderRadioWideFCCNarrowBandingFrequencySplitTable.MyDataPresenter = null;
			this.RecNavToolbarExpanderRadioWideGeneralLightbarPattern.MyDataPresenter = null;
			this.RecNavToolbarExpanderRadioWideRelockTimer.MyDataPresenter = null;
			num2 = (short)1805451264;
			num = (int)((global::System.IntPtr)num2);
			goto IL_0A;
		}

		// Token: 0x06003DF8 RID: 15864 RVA: 0x0039B49C File Offset: 0x0039969C
		public override void SetDataContext()
		{
			short num = (short)389873697;
			int num2 = (int)((global::System.IntPtr)num);
			object feature;
			for (;;)
			{
				switch (num2)
				{
				case 0:
					if (((global::AcpCommonLib.IAcpRecordset)feature)[0][10606] != null)
					{
						num = (short)357236767;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					return;
				case 1:
					goto IL_A4E;
				case 2:
					if (((global::AcpCommonLib.IAcpRecordset)feature)[0][10636].EmbeddedRecset != null)
					{
						num = (short)1404174360;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_C87;
				case 3:
					((global::AcpUILib.IAcpRecNavToolbar)this.RecNavToolbarExpanderRadioWideRxFrequencySplitFPP).MySecondaryRecordsetDataSource = ((global::AcpCommonLib.IAcpRecordset)feature)[0][10096].EmbeddedRecset;
					((global::AcpUILib.IAcpRecNavToolbar)this.RecNavToolbarExpanderRadioWideRxFrequencySplitFPP).SyncDataSources();
					num = (short)400293900;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 4:
					if (((global::AcpCommonLib.IAcpRecordset)feature)[0] != null)
					{
						num = (short)896401463;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_97E;
				case 5:
					goto IL_B5D;
				case 6:
					num = (short)1198129192;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 7:
					if (((global::AcpCommonLib.IAcpRecordset)feature)[0][10103].EmbeddedRecset != null)
					{
						num = (short)1098186786;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_551;
				case 8:
					if (((global::AcpCommonLib.IAcpRecordset)feature)[0] != null)
					{
						num = (short)790626325;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_8AA;
				case 9:
					num = (short)1822097467;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 10:
					if (((global::AcpCommonLib.IAcpRecordset)feature)[0] != null)
					{
						num = (short)145096731;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_659;
				case 11:
					if (feature != null)
					{
						num = (short)1261043742;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_8AA;
				case 12:
					goto IL_A36;
				case 13:
					((global::AcpUILib.IAcpRecNavToolbar)this.RecNavToolbarExpanderRadioWideGeneralLightbarPattern).MySecondaryRecordsetDataSource = ((global::AcpCommonLib.IAcpRecordset)feature)[0][10604].EmbeddedRecset;
					((global::AcpUILib.IAcpRecNavToolbar)this.RecNavToolbarExpanderRadioWideGeneralLightbarPattern).SyncDataSources();
					num = (short)558956609;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 14:
					if (((global::AcpCommonLib.IAcpRecordset)feature)[0][10103] != null)
					{
						num = (short)422903866;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_551;
				case 15:
					goto IL_551;
				case 16:
					goto IL_8AA;
				case 17:
					num = (short)1783889962;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 18:
					goto IL_C36;
				case 19:
				{
					num = (short)775109859;
					short num3 = num;
					num = (short)2178275;
					switch ((num3 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_A4E;
					default:
						num = (short)1076035584;
						if (num != 0)
						{
						}
						if (feature != null)
						{
							num = (short)1476067396;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_659;
					}
					break;
				}
				case 20:
					if (feature != null)
					{
						num = (short)645791750;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_A36;
				case 21:
					num = (short)1421672496;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 22:
					if (feature != null)
					{
						num = (short)970457120;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_551;
				case 23:
					num = (short)214433858;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 24:
					((global::AcpUILib.IAcpRecNavToolbar)this.RecNavToolbarExpanderRadioWideFCCNarrowBandingFrequencySplitTable).MySecondaryRecordsetDataSource = ((global::AcpCommonLib.IAcpRecordset)feature)[0][10636].EmbeddedRecset;
					((global::AcpUILib.IAcpRecNavToolbar)this.RecNavToolbarExpanderRadioWideFCCNarrowBandingFrequencySplitTable).SyncDataSources();
					num = (short)2080768038;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 25:
					if (((global::AcpCommonLib.IAcpRecordset)feature)[0][10606].EmbeddedRecset != null)
					{
						num = (short)748027922;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					return;
				case 26:
					num = (short)288489474;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 27:
					num = (short)599588911;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 28:
					((global::AcpUILib.IAcpRecNavToolbar)this.RecNavToolbarExpanderRadioWideTxPowerLevelsByFrequencyRangeNewBandPlan).MySecondaryRecordsetDataSource = ((global::AcpCommonLib.IAcpRecordset)feature)[0][10761].EmbeddedRecset;
					((global::AcpUILib.IAcpRecNavToolbar)this.RecNavToolbarExpanderRadioWideTxPowerLevelsByFrequencyRangeNewBandPlan).SyncDataSources();
					num = (short)85000208;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 29:
					num = (short)1250820132;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 30:
					num = (short)357564424;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 31:
					num = (short)1357185049;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 32:
					num = (short)1334509614;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 33:
					switch (0)
					{
					case 0:
						goto IL_139;
					}
					continue;
				case 34:
					((global::AcpUILib.IAcpRecNavToolbar)this.RecNavToolbarExpanderRadioWideTxPowerLevelsByFrequencyRange).MySecondaryRecordsetDataSource = ((global::AcpCommonLib.IAcpRecordset)feature)[0][10103].EmbeddedRecset;
					((global::AcpUILib.IAcpRecNavToolbar)this.RecNavToolbarExpanderRadioWideTxPowerLevelsByFrequencyRange).SyncDataSources();
					num = (short)1491337231;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 35:
					base.DataContext = global::AcpCommonLib.AppInfoManager.DefaultDocument.GetFeature(2045);
					num = (short)1796800563;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 36:
					if (((global::AcpCommonLib.IAcpRecordset)feature)[0][10096].EmbeddedRecset != null)
					{
						num = (short)492699651;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_A36;
				case 37:
					goto IL_4CA;
				case 38:
					goto IL_C87;
				case 39:
					if (((global::AcpCommonLib.IAcpRecordset)feature)[0][10761].EmbeddedRecset != null)
					{
						num = (short)1287061504;
						short num4 = num;
						num = (short)1052377116;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_8AA;
				case 40:
					if (((global::AcpCommonLib.IAcpRecordset)feature)[0] != null)
					{
						num = (short)986316867;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_A36;
				case 41:
					if (feature != null)
					{
						num = (short)746455057;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					return;
				case 42:
					if (((global::AcpCommonLib.IAcpRecordset)feature)[0] != null)
					{
						num = (short)1640366140;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					return;
				case 43:
					goto IL_97E;
				case 44:
					if (((global::AcpCommonLib.IAcpRecordset)feature)[0][10096] != null)
					{
						num = (short)277807133;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_A36;
				case 45:
					num = (short)770572292;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 46:
					if (((global::AcpCommonLib.IAcpRecordset)feature)[0] != null)
					{
						num = (short)1202520114;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_551;
				case 47:
					num = (short)1897398273;
					if (num != 0)
					{
					}
					if (((global::AcpCommonLib.IAcpRecordset)feature)[0][10604] != null)
					{
						num = (short)476119049;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_659;
				case 48:
					if (((global::AcpCommonLib.IAcpRecordset)feature)[0][10761] != null)
					{
						num = (short)959512628;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_8AA;
				case 49:
					((global::AcpUILib.IAcpRecNavToolbar)this.RecNavToolbarExpanderRadioWideTxFrequencySplitFPP).MySecondaryRecordsetDataSource = ((global::AcpCommonLib.IAcpRecordset)feature)[0][10094].EmbeddedRecset;
					((global::AcpUILib.IAcpRecNavToolbar)this.RecNavToolbarExpanderRadioWideTxFrequencySplitFPP).SyncDataSources();
					num = (short)1570766891;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 50:
					num = (short)815071246;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 51:
					goto IL_B5D;
				case 52:
					num = (short)720306215;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 53:
					if (((global::AcpCommonLib.IAcpRecordset)feature)[0][10636] != null)
					{
						num = (short)764608538;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_C87;
				case 54:
					num = (short)1003487285;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 55:
					num = (short)842989625;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 56:
					if (global::AcpCommonLib.AppInfoManager.AppMode == global::AcpCommonLib.ApplicationMode.CodeplugComparisonMode)
					{
						num = (short)558759997;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					((global::AcpUILib.IAcpRecNavToolbar)this.RecNavToolbarExpanderRadioWideTxPowerLevelsByFrequencyRange).MySecondaryRecordsetDataSource = null;
					((global::AcpUILib.IAcpRecNavToolbar)this.RecNavToolbarExpanderRadioWideTxPowerLevelsByFrequencyRangeNewBandPlan).MySecondaryRecordsetDataSource = null;
					((global::AcpUILib.IAcpRecNavToolbar)this.RecNavToolbarExpanderRadioWideRxFrequencySplitFPP).MySecondaryRecordsetDataSource = null;
					((global::AcpUILib.IAcpRecNavToolbar)this.RecNavToolbarExpanderRadioWideTxFrequencySplitFPP).MySecondaryRecordsetDataSource = null;
					((global::AcpUILib.IAcpRecNavToolbar)this.RecNavToolbarExpanderRadioWideFCCNarrowBandingFrequencySplitTable).MySecondaryRecordsetDataSource = null;
					((global::AcpUILib.IAcpRecNavToolbar)this.RecNavToolbarExpanderRadioWideGeneralLightbarPattern).MySecondaryRecordsetDataSource = null;
					((global::AcpUILib.IAcpRecNavToolbar)this.RecNavToolbarExpanderRadioWideRelockTimer).MySecondaryRecordsetDataSource = null;
					num = (short)808779813;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 57:
					if (((global::AcpCommonLib.IAcpRecordset)feature)[0][10094] != null)
					{
						num = (short)826605591;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_97E;
				case 58:
					num = (short)1356464135;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 59:
					if (((global::AcpCommonLib.IAcpRecordset)feature)[0][10604].EmbeddedRecset != null)
					{
						num = (short)715128845;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_659;
				case 60:
					num = (short)805502976;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 61:
					feature = global::AcpCommonLib.AppInfoManager.ComparatorDocument.GetFeature(2045);
					num = (short)1239744534;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 62:
					if (((global::AcpCommonLib.IAcpRecordset)feature)[0] != null)
					{
						num = (short)1698365494;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_C87;
				case 63:
					if (feature != null)
					{
						num = (short)499646528;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_C87;
				case 64:
					num = (short)896598078;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 65:
					goto IL_659;
				case 66:
					if (((global::AcpCommonLib.IAcpRecordset)feature)[0][10094].EmbeddedRecset != null)
					{
						num = (short)877068337;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_97E;
				case 67:
					num = (short)1669791788;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 68:
					num = (short)1331560458;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				IL_139:
				if (global::AcpCommonLib.AppInfoManager.AppMode == global::AcpCommonLib.ApplicationMode.CustomViewConfigurationMode)
				{
					num = (short)399179811;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				base.DataContext = global::AcpCommonLib.FeatureManager.GetFeature(2045);
				num = (short)585498629;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_551:
				num = (short)180158475;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_659:
				num = (short)999292969;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_8AA:
				num = (short)26869780;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_97E:
				num = (short)20906047;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_A4E:
				if (feature != null)
				{
					num = (short)1825439789;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				goto IL_97E;
				IL_A36:
				num = (short)185008129;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_B5D:
				num = (short)278331448;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_C87:
				num = (short)819986451;
				num2 = (int)((global::System.IntPtr)num);
			}
			IL_4CA:
			return;
			IL_C36:
			((global::AcpUILib.IAcpRecNavToolbar)this.RecNavToolbarExpanderRadioWideRelockTimer).MySecondaryRecordsetDataSource = ((global::AcpCommonLib.IAcpRecordset)feature)[0][10606].EmbeddedRecset;
			((global::AcpUILib.IAcpRecNavToolbar)this.RecNavToolbarExpanderRadioWideRelockTimer).SyncDataSources();
		}

		// Token: 0x06003DF9 RID: 15865 RVA: 0x0039C1B4 File Offset: 0x0039A3B4
		private void OnModeClick(object A_0, global::System.Windows.RoutedEventArgs A_1)
		{
			int a_ = 13;
			short num = (short)1469775872;
			switch (num)
			{
			default:
			{
				num = (short)2037579814;
				int num2 = (int)((global::System.IntPtr)num);
				object myRecordsetDataSource5;
				for (;;)
				{
					switch (num2)
					{
					case 0:
					{
						if (((global::AcpUI.AcpRecNavToolbar)A_0).TableMode)
						{
							num = (short)1373634571;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)1748631552;
						short num3 = num;
						((global::AcpUI.AcpRecNavToolbar)A_0).TableMode = true;
						num = (short)2129854477;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 1:
					{
						((global::AcpUI.AcpRecNavToolbar)A_0).TableMode = false;
						object myRecordsetDataSource = this.RecNavToolbarExpanderRadioWideTxPowerLevelsByFrequencyRange.MyRecordsetDataSource;
						num = (short)897843220;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 2:
					{
						((global::AcpUI.AcpRecNavToolbar)A_0).TableMode = false;
						object myRecordsetDataSource2 = this.RecNavToolbarExpanderRadioWideGeneralLightbarPattern.MyRecordsetDataSource;
						num = (short)932642859;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 3:
						goto IL_6C2;
					case 4:
					{
						object myRecordsetDataSource3;
						if (myRecordsetDataSource3 != null)
						{
							num = (short)1843658792;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_9EC;
					}
					case 5:
					{
						object myRecordsetDataSource4;
						global::System.Windows.Data.CollectionView collectionView = (global::System.Windows.Data.CollectionView)global::System.Windows.Data.CollectionViewSource.GetDefaultView(myRecordsetDataSource4);
						global::Motorola.MackinawCPS.CoreFeatures.RadioWide.FCCNarrowBandingFrequencySplitInner item = (global::Motorola.MackinawCPS.CoreFeatures.RadioWide.FCCNarrowBandingFrequencySplitInner)collectionView.CurrentItem;
						collectionView.MoveCurrentTo(item);
						((global::AcpUI.AcpRecNavToolbar)A_0).SyncDataSources();
						num = (short)318439448;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 6:
						if (((global::AcpUI.AcpRecNavToolbar)A_0).TableMode)
						{
							num = (short)1099956225;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						((global::AcpUI.AcpRecNavToolbar)A_0).TableMode = true;
						num = (short)1126170655;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 7:
						goto IL_5B4;
					case 8:
						if (((global::AcpUI.AcpRecNavToolbar)A_0).TableMode)
						{
							num = (short)1728249858;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						((global::AcpUI.AcpRecNavToolbar)A_0).TableMode = true;
						num = (short)432734218;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 9:
						num = (short)945422342;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 10:
						goto IL_3F6;
					case 11:
					{
						((global::AcpUI.AcpRecNavToolbar)A_0).TableMode = false;
						object myRecordsetDataSource4 = this.RecNavToolbarExpanderRadioWideFCCNarrowBandingFrequencySplitTable.MyRecordsetDataSource;
						num = (short)1295712292;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 12:
						if (myRecordsetDataSource5 != null)
						{
							num = (short)1540882488;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return;
					case 13:
						goto IL_AC6;
					case 14:
						num = (short)1803419656;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 15:
						if (((global::AcpUI.AcpRecNavToolbar)A_0).Name == global::AllFeatures.CodeplugGuid.b("鳍뗏뇑髓럕껗軙돛뇝賟胡藣铥귧鋩鳫迭黯雱釳蓵꫷鯹飻韽濿唁洃戅洇䴉椋怍甏怑甓稕吗猙笛瘝吟䀡䔣吥砧䬩堫娭唯䀱娳", a_))
						{
							num = (short)909967374;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_3F6;
					case 16:
						num = (short)770506775;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 17:
					{
						object myRecordsetDataSource6;
						global::System.Windows.Data.CollectionView collectionView2 = (global::System.Windows.Data.CollectionView)global::System.Windows.Data.CollectionViewSource.GetDefaultView(myRecordsetDataSource6);
						global::Motorola.MackinawCPS.CoreFeatures.RadioWide.TxPowerLevelsByFrequencyRangeNewBandPlanInner item2 = (global::Motorola.MackinawCPS.CoreFeatures.RadioWide.TxPowerLevelsByFrequencyRangeNewBandPlanInner)collectionView2.CurrentItem;
						collectionView2.MoveCurrentTo(item2);
						((global::AcpUI.AcpRecNavToolbar)A_0).SyncDataSources();
						num = (short)241369110;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 18:
						if (((global::AcpUI.AcpRecNavToolbar)A_0).Name == global::AllFeatures.CodeplugGuid.b("鳍뗏뇑髓럕껗軙돛뇝賟胡藣铥귧鋩鳫迭黯雱釳蓵꫷鯹飻韽濿唁洃戅洇帉琋䠍戏眑攓挕紗琙缛朝猟刡䠣伥尧氩簫縭", a_))
						{
							num = (short)1330642965;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_9EC;
					case 19:
					{
						object myRecordsetDataSource;
						global::System.Windows.Data.CollectionView collectionView3 = (global::System.Windows.Data.CollectionView)global::System.Windows.Data.CollectionViewSource.GetDefaultView(myRecordsetDataSource);
						global::Motorola.MackinawCPS.CoreFeatures.RadioWide.TxPowerLevelsByFrequencyRangeInner item3 = (global::Motorola.MackinawCPS.CoreFeatures.RadioWide.TxPowerLevelsByFrequencyRangeInner)collectionView3.CurrentItem;
						collectionView3.MoveCurrentTo(item3);
						((global::AcpUI.AcpRecNavToolbar)A_0).SyncDataSources();
						num = (short)2002780190;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 20:
					{
						object myRecordsetDataSource;
						if (myRecordsetDataSource != null)
						{
							num = (short)1102118931;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_55E;
					}
					case 21:
						num = (short)1719140377;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 22:
						goto IL_5B4;
					case 23:
						if (((global::AcpUI.AcpRecNavToolbar)A_0).TableMode)
						{
							num = (short)2109341737;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						((global::AcpUI.AcpRecNavToolbar)A_0).TableMode = true;
						num = (short)353042439;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 24:
						goto IL_AC6;
					case 25:
						if (((global::AcpUI.AcpRecNavToolbar)A_0).TableMode)
						{
							num = (short)1221722163;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						((global::AcpUI.AcpRecNavToolbar)A_0).TableMode = true;
						num = (short)582615077;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 26:
						if (((global::AcpUI.AcpRecNavToolbar)A_0).Name == global::AllFeatures.CodeplugGuid.b("鳍뗏뇑髓럕껗軙돛뇝賟胡藣铥귧鋩鳫迭黯雱釳蓵꫷鯹飻韽濿唁洃戅洇堉椋戍缏焑缓䈕焗眙礛氝", a_))
						{
							num = (short)1274019874;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return;
					case 27:
						if (((global::AcpUI.AcpRecNavToolbar)A_0).Name == global::AllFeatures.CodeplugGuid.b("鳍뗏뇑髓럕껗軙돛뇝賟胡藣铥귧鋩鳫迭黯雱釳蓵꫷鯹飻韽濿唁洃戅洇帉琋帍缏攑焓搕吗缙樛笝䰟儡昣弥渧堩䤫弭䔯圱娳唵䄷根崻倽✿❁", a_))
						{
							num = (short)1055522825;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_55E;
					case 28:
						goto IL_9EC;
					case 29:
						num = (short)5832704;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 30:
						goto IL_55E;
					case 31:
						goto IL_55E;
					case 32:
					{
						((global::AcpUI.AcpRecNavToolbar)A_0).TableMode = false;
						object myRecordsetDataSource7 = this.RecNavToolbarExpanderRadioWideRxFrequencySplitFPP.MyRecordsetDataSource;
						num = (short)1054867510;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 33:
						if (((global::AcpUI.AcpRecNavToolbar)A_0).Name == global::AllFeatures.CodeplugGuid.b("鳍뗏뇑髓럕껗軙돛뇝賟胡藣铥귧鋩鳫迭黯雱釳蓵꫷鯹飻韽濿唁洃戅洇帉琋帍缏攑焓搕吗缙樛笝䰟儡昣弥渧堩䤫弭䔯圱娳唵䄷根崻倽✿❁੃⍅㽇ࡉⵋ⁍㑏ɑ㡓㝕㙗", a_))
						{
							num = (short)1846542352;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_5B4;
					case 34:
						num = (short)2136866855;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 35:
						return;
					case 36:
					{
						object myRecordsetDataSource4;
						if (myRecordsetDataSource4 == null)
						{
							goto IL_AC6;
						}
						num = (short)170943671;
						short num4 = num;
						num = (short)1511417015;
						switch ((num4 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							return;
						default:
							num = (short)519241728;
							if (num != 0)
							{
							}
							num = (short)304611333;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						break;
					}
					case 37:
						goto IL_9EC;
					case 38:
						switch (0)
						{
						case 0:
							goto IL_131;
						}
						continue;
					case 39:
						if (((global::AcpUI.AcpRecNavToolbar)A_0).TableMode)
						{
							num = (short)843251761;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						((global::AcpUI.AcpRecNavToolbar)A_0).TableMode = true;
						num = (short)1795883043;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 40:
					{
						object myRecordsetDataSource3;
						global::System.Windows.Data.CollectionView collectionView4 = (global::System.Windows.Data.CollectionView)global::System.Windows.Data.CollectionViewSource.GetDefaultView(myRecordsetDataSource3);
						global::Motorola.MackinawCPS.CoreFeatures.RadioWide.TxFrequencySplitFPPInner item4 = (global::Motorola.MackinawCPS.CoreFeatures.RadioWide.TxFrequencySplitFPPInner)collectionView4.CurrentItem;
						collectionView4.MoveCurrentTo(item4);
						((global::AcpUI.AcpRecNavToolbar)A_0).SyncDataSources();
						num = (short)2012545052;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 41:
					{
						((global::AcpUI.AcpRecNavToolbar)A_0).TableMode = false;
						object myRecordsetDataSource6 = this.RecNavToolbarExpanderRadioWideTxPowerLevelsByFrequencyRangeNewBandPlan.MyRecordsetDataSource;
						num = (short)791085101;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 42:
						goto IL_6C2;
					case 43:
					{
						object myRecordsetDataSource2;
						if (myRecordsetDataSource2 != null)
						{
							num = (short)438960181;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_3F6;
					}
					case 44:
						num = (short)1861550107;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 45:
					{
						object myRecordsetDataSource6;
						if (myRecordsetDataSource6 != null)
						{
							num = (short)1193017361;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_5B4;
					}
					case 46:
						num = (short)489160759;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 47:
						if (((global::AcpUI.AcpRecNavToolbar)A_0).Name == global::AllFeatures.CodeplugGuid.b("鳍뗏뇑髓럕껗軙돛뇝賟胡藣铥귧鋩鳫迭黯雱釳蓵꫷鯹飻韽濿唁洃戅洇䰉伋䴍帏猑易搕眗洙帛缝丟䘡䴣䠥伧氩師䬭䄯䜱儳堵嬷䌹漻丽ⰿ⭁ぃቅ⥇⡉⁋⭍", a_))
						{
							num = (short)1774125085;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_AC6;
					case 48:
						goto IL_3F6;
					case 49:
						((global::AcpUI.AcpRecNavToolbar)A_0).TableMode = false;
						myRecordsetDataSource5 = this.RecNavToolbarExpanderRadioWideRelockTimer.MyRecordsetDataSource;
						num = (short)1300365324;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 50:
						if (((global::AcpUI.AcpRecNavToolbar)A_0).Name == global::AllFeatures.CodeplugGuid.b("鳍뗏뇑髓럕껗軙돛뇝賟胡藣铥귧鋩鳫迭黯雱釳蓵꫷鯹飻韽濿唁洃戅洇堉琋䠍戏眑攓挕紗琙缛朝猟刡䠣伥尧氩簫縭", a_))
						{
							num = (short)1503068206;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_6C2;
					case 51:
					{
						((global::AcpUI.AcpRecNavToolbar)A_0).TableMode = false;
						object myRecordsetDataSource3 = this.RecNavToolbarExpanderRadioWideTxFrequencySplitFPP.MyRecordsetDataSource;
						num = (short)1975058436;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 52:
					{
						object myRecordsetDataSource7;
						global::System.Windows.Data.CollectionView collectionView5 = (global::System.Windows.Data.CollectionView)global::System.Windows.Data.CollectionViewSource.GetDefaultView(myRecordsetDataSource7);
						global::Motorola.MackinawCPS.CoreFeatures.RadioWide.RxFrequencySplitFPPInner item5 = (global::Motorola.MackinawCPS.CoreFeatures.RadioWide.RxFrequencySplitFPPInner)collectionView5.CurrentItem;
						collectionView5.MoveCurrentTo(item5);
						((global::AcpUI.AcpRecNavToolbar)A_0).SyncDataSources();
						num = (short)21364778;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 53:
					{
						object myRecordsetDataSource2;
						global::System.Windows.Data.CollectionView collectionView6 = (global::System.Windows.Data.CollectionView)global::System.Windows.Data.CollectionViewSource.GetDefaultView(myRecordsetDataSource2);
						global::Motorola.MackinawCPS.CoreFeatures.RadioWide.GeneralLightbarPatternInner item6 = (global::Motorola.MackinawCPS.CoreFeatures.RadioWide.GeneralLightbarPatternInner)collectionView6.CurrentItem;
						collectionView6.MoveCurrentTo(item6);
						((global::AcpUI.AcpRecNavToolbar)A_0).SyncDataSources();
						num = (short)1210581040;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 54:
					{
						object myRecordsetDataSource7;
						if (myRecordsetDataSource7 != null)
						{
							num = (short)408944692;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_6C2;
					}
					case 55:
						if (((global::AcpUI.AcpRecNavToolbar)A_0).TableMode)
						{
							num = (short)370802720;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						((global::AcpUI.AcpRecNavToolbar)A_0).TableMode = true;
						num = (short)1530920963;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 56:
						goto IL_362;
					}
					IL_131:
					num = (short)510394369;
					if (num != 0)
					{
					}
					if (A_0 is global::AcpUI.AcpRecNavToolbar)
					{
						num = (short)930480172;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					return;
					IL_3F6:
					num = (short)376700954;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_55E:
					num = (short)1823277089;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_5B4:
					num = (short)1383465010;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_6C2:
					num = (short)1735458834;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_9EC:
					num = (short)4587567;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_AC6:
					num = (short)2118189071;
					num2 = (int)((global::System.IntPtr)num);
				}
				IL_362:
				global::System.Windows.Data.CollectionView collectionView7 = (global::System.Windows.Data.CollectionView)global::System.Windows.Data.CollectionViewSource.GetDefaultView(myRecordsetDataSource5);
				global::Motorola.MackinawCPS.CoreFeatures.RadioWide.RelockTimerInner item7 = (global::Motorola.MackinawCPS.CoreFeatures.RadioWide.RelockTimerInner)collectionView7.CurrentItem;
				collectionView7.MoveCurrentTo(item7);
				((global::AcpUI.AcpRecNavToolbar)A_0).SyncDataSources();
				return;
			}
			}
		}

		// Token: 0x06003DFA RID: 15866 RVA: 0x0039CD60 File Offset: 0x0039AF60
		private void HLinkClick(object A_0, global::System.Windows.RoutedEventArgs A_1)
		{
			short num = (short)1073480090;
			short num2 = num;
			num = (short)1120272794;
			switch (num2 == num)
			{
			}
			num = (short)1816068097;
			if (num != 0)
			{
			}
			num = (short)2034106368;
			if (num != 0)
			{
			}
			num = (short)484835328;
			short num3 = num;
			base.OnHLinkClick(A_0);
		}

		// Token: 0x06003DFB RID: 15867 RVA: 0x0039CE10 File Offset: 0x0039B010
		private void OnFieldNameDoubleClick(object A_0, global::System.Windows.RoutedEventArgs A_1)
		{
			short num = (short)1393129723;
			short num2 = num;
			num = (short)349862139;
			switch (num2 == num)
			{
			}
			num = (short)489816064;
			if (num != 0)
			{
			}
			num = (short)1319895041;
			if (num != 0)
			{
			}
			num = (short)775159808;
			short num3 = num;
			global::AcpUI.Common.Utility.GetFieldHelpText(A_0);
		}

		// Token: 0x06003DFC RID: 15868 RVA: 0x0039CEBC File Offset: 0x0039B0BC
		internal void OnExpanderRadioWideTxPowerLevelsByFrequencyRangeClick(object sender, global::System.Windows.RoutedEventArgs e)
		{
			short num;
			int num3;
			object myRecordsetDataSource;
			global::Motorola.MackinawCPS.CoreFeatures.RadioWide.TxPowerLevelsByFrequencyRangeInner item;
			switch (0)
			{
			case 0:
				break;
			default:
				for (;;)
				{
					IL_0A:
					num = (short)1080364649;
					short num2 = num;
					num = (short)1244073577;
					switch ((num2 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_96;
					default:
						num = (short)1763901440;
						if (num != 0)
						{
						}
						switch (num3)
						{
						case 0:
							goto IL_14F;
						case 1:
							((global::System.Windows.Data.CollectionView)global::System.Windows.Data.CollectionViewSource.GetDefaultView(myRecordsetDataSource)).MoveCurrentTo(item);
							this.RecNavToolbarExpanderRadioWideTxPowerLevelsByFrequencyRange.SyncDataSources();
							num = (short)1217986560;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						case 2:
						{
							num = (short)102039552;
							short num4 = num;
							if (myRecordsetDataSource != null)
							{
								num = (short)1040121857;
								if (num != 0)
								{
								}
								num = (short)556662785;
								num3 = (int)((global::System.IntPtr)num);
								continue;
							}
							goto IL_151;
						}
						}
						goto IL_65;
					}
				}
				IL_14F:
				IL_151:
				this.RecNavToolbarExpanderRadioWideTxPowerLevelsByFrequencyRange.TableMode = false;
				return;
			}
			IL_65:
			item = (global::Motorola.MackinawCPS.CoreFeatures.RadioWide.TxPowerLevelsByFrequencyRangeInner)((global::Infragistics.Windows.DataPresenter.CellValuePresenter)((global::AcpUI.AcpButton)e.Source).TemplatedParent).Record.DataItem;
			myRecordsetDataSource = this.RecNavToolbarExpanderRadioWideTxPowerLevelsByFrequencyRange.MyRecordsetDataSource;
			IL_96:
			num = (short)704970754;
			num3 = (int)((global::System.IntPtr)num);
			goto IL_0A;
		}

		// Token: 0x06003DFD RID: 15869 RVA: 0x0039D028 File Offset: 0x0039B228
		internal void OnExpanderRadioWideTxPowerLevelsByFrequencyRangeNewBandPlanClick(object sender, global::System.Windows.RoutedEventArgs e)
		{
			short num;
			int num3;
			object myRecordsetDataSource;
			global::Motorola.MackinawCPS.CoreFeatures.RadioWide.TxPowerLevelsByFrequencyRangeNewBandPlanInner item;
			switch (0)
			{
			case 0:
				break;
			default:
				for (;;)
				{
					IL_0A:
					num = (short)1182594320;
					short num2 = num;
					num = (short)1446180112;
					switch ((num2 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_98;
					default:
						num = (short)1932525568;
						if (num != 0)
						{
						}
						switch (num3)
						{
						case 0:
							goto IL_128;
						case 1:
							((global::System.Windows.Data.CollectionView)global::System.Windows.Data.CollectionViewSource.GetDefaultView(myRecordsetDataSource)).MoveCurrentTo(item);
							this.RecNavToolbarExpanderRadioWideTxPowerLevelsByFrequencyRangeNewBandPlan.SyncDataSources();
							num = (short)1815150592;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						case 2:
						{
							num = (short)488505344;
							short num4 = num;
							if (myRecordsetDataSource != null)
							{
								num = (short)1029832705;
								num3 = (int)((global::System.IntPtr)num);
								continue;
							}
							goto IL_12A;
						}
						}
						goto IL_67;
					}
				}
				IL_128:
				IL_12A:
				num = (short)1132855297;
				if (num != 0)
				{
				}
				this.RecNavToolbarExpanderRadioWideTxPowerLevelsByFrequencyRangeNewBandPlan.TableMode = false;
				return;
			}
			IL_67:
			item = (global::Motorola.MackinawCPS.CoreFeatures.RadioWide.TxPowerLevelsByFrequencyRangeNewBandPlanInner)((global::Infragistics.Windows.DataPresenter.CellValuePresenter)((global::AcpUI.AcpButton)e.Source).TemplatedParent).Record.DataItem;
			myRecordsetDataSource = this.RecNavToolbarExpanderRadioWideTxPowerLevelsByFrequencyRangeNewBandPlan.MyRecordsetDataSource;
			IL_98:
			num = (short)996212738;
			num3 = (int)((global::System.IntPtr)num);
			goto IL_0A;
		}

		// Token: 0x06003DFE RID: 15870 RVA: 0x0039D194 File Offset: 0x0039B394
		internal void OnExpanderRadioWideRxFrequencySplitFPPClick(object sender, global::System.Windows.RoutedEventArgs e)
		{
			short num;
			int num3;
			object myRecordsetDataSource;
			global::Motorola.MackinawCPS.CoreFeatures.RadioWide.RxFrequencySplitFPPInner item;
			switch (0)
			{
			case 0:
				break;
			default:
				for (;;)
				{
					IL_0A:
					num = (short)82519974;
					short num2 = num;
					num = (short)10561446;
					switch ((num2 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_BE;
					default:
						num = (short)1397686272;
						if (num != 0)
						{
						}
						num = (short)483590145;
						if (num != 0)
						{
						}
						switch (num3)
						{
						case 0:
							goto IL_14D;
						case 1:
							((global::System.Windows.Data.CollectionView)global::System.Windows.Data.CollectionViewSource.GetDefaultView(myRecordsetDataSource)).MoveCurrentTo(item);
							this.RecNavToolbarExpanderRadioWideRxFrequencySplitFPP.SyncDataSources();
							num = (short)334692352;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						case 2:
							if (myRecordsetDataSource != null)
							{
								num = (short)1606549505;
								num3 = (int)((global::System.IntPtr)num);
								continue;
							}
							goto IL_14F;
						}
						goto IL_8D;
					}
				}
				IL_14D:
				IL_14F:
				this.RecNavToolbarExpanderRadioWideRxFrequencySplitFPP.TableMode = false;
				return;
			}
			IL_8D:
			item = (global::Motorola.MackinawCPS.CoreFeatures.RadioWide.RxFrequencySplitFPPInner)((global::Infragistics.Windows.DataPresenter.CellValuePresenter)((global::AcpUI.AcpButton)e.Source).TemplatedParent).Record.DataItem;
			myRecordsetDataSource = this.RecNavToolbarExpanderRadioWideRxFrequencySplitFPP.MyRecordsetDataSource;
			IL_BE:
			num = (short)663814144;
			short num4 = num;
			num = (short)850264066;
			num3 = (int)((global::System.IntPtr)num);
			goto IL_0A;
		}

		// Token: 0x06003DFF RID: 15871 RVA: 0x0039D2FC File Offset: 0x0039B4FC
		internal void OnExpanderRadioWideTxFrequencySplitFPPClick(object sender, global::System.Windows.RoutedEventArgs e)
		{
			short num;
			int num3;
			object myRecordsetDataSource;
			global::Motorola.MackinawCPS.CoreFeatures.RadioWide.TxFrequencySplitFPPInner item;
			switch (0)
			{
			case 0:
				break;
			default:
				for (;;)
				{
					IL_0A:
					num = (short)99003176;
					short num2 = num;
					num = (short)765504296;
					switch ((num2 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_98;
					default:
						num = (short)567279616;
						if (num != 0)
						{
						}
						switch (num3)
						{
						case 0:
							goto IL_151;
						case 1:
							((global::System.Windows.Data.CollectionView)global::System.Windows.Data.CollectionViewSource.GetDefaultView(myRecordsetDataSource)).MoveCurrentTo(item);
							this.RecNavToolbarExpanderRadioWideTxFrequencySplitFPP.SyncDataSources();
							num = (short)700841984;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						case 2:
							if (myRecordsetDataSource != null)
							{
								num = (short)170131457;
								num3 = (int)((global::System.IntPtr)num);
								continue;
							}
							goto IL_153;
						}
						goto IL_67;
					}
				}
				IL_151:
				IL_153:
				this.RecNavToolbarExpanderRadioWideTxFrequencySplitFPP.TableMode = false;
				return;
			}
			IL_67:
			item = (global::Motorola.MackinawCPS.CoreFeatures.RadioWide.TxFrequencySplitFPPInner)((global::Infragistics.Windows.DataPresenter.CellValuePresenter)((global::AcpUI.AcpButton)e.Source).TemplatedParent).Record.DataItem;
			myRecordsetDataSource = this.RecNavToolbarExpanderRadioWideTxFrequencySplitFPP.MyRecordsetDataSource;
			IL_98:
			num = (short)214171649;
			if (num != 0)
			{
			}
			num = (short)1941241856;
			short num4 = num;
			num = (short)1774452738;
			num3 = (int)((global::System.IntPtr)num);
			goto IL_0A;
		}

		// Token: 0x06003E00 RID: 15872 RVA: 0x0039D468 File Offset: 0x0039B668
		internal void OnExpanderRadioWideFCCNarrowBandingFrequencySplitTableClick(object sender, global::System.Windows.RoutedEventArgs e)
		{
			short num;
			int num3;
			object myRecordsetDataSource;
			global::Motorola.MackinawCPS.CoreFeatures.RadioWide.FCCNarrowBandingFrequencySplitInner item;
			switch (0)
			{
			case 0:
				break;
			default:
				for (;;)
				{
					IL_0A:
					num = (short)1601067617;
					short num2 = num;
					num = (short)1616796257;
					switch ((num2 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_97;
					default:
						num = (short)149159936;
						if (num != 0)
						{
						}
						switch (num3)
						{
						case 0:
							goto IL_14F;
						case 1:
							((global::System.Windows.Data.CollectionView)global::System.Windows.Data.CollectionViewSource.GetDefaultView(myRecordsetDataSource)).MoveCurrentTo(item);
							this.RecNavToolbarExpanderRadioWideFCCNarrowBandingFrequencySplitTable.SyncDataSources();
							num = (short)192020480;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						case 2:
						{
							num = (short)1530527744;
							short num4 = num;
							if (myRecordsetDataSource != null)
							{
								num = (short)412024833;
								if (num != 0)
								{
								}
								num = (short)693305345;
								num3 = (int)((global::System.IntPtr)num);
								continue;
							}
							goto IL_151;
						}
						}
						goto IL_66;
					}
				}
				IL_14F:
				IL_151:
				this.RecNavToolbarExpanderRadioWideFCCNarrowBandingFrequencySplitTable.TableMode = false;
				return;
			}
			IL_66:
			item = (global::Motorola.MackinawCPS.CoreFeatures.RadioWide.FCCNarrowBandingFrequencySplitInner)((global::Infragistics.Windows.DataPresenter.CellValuePresenter)((global::AcpUI.AcpButton)e.Source).TemplatedParent).Record.DataItem;
			myRecordsetDataSource = this.RecNavToolbarExpanderRadioWideFCCNarrowBandingFrequencySplitTable.MyRecordsetDataSource;
			IL_97:
			num = (short)764608514;
			num3 = (int)((global::System.IntPtr)num);
			goto IL_0A;
		}

		// Token: 0x06003E01 RID: 15873 RVA: 0x0039D5D4 File Offset: 0x0039B7D4
		internal void OnExpanderRadioWideGeneralLightbarPatternClick(object sender, global::System.Windows.RoutedEventArgs e)
		{
			short num;
			int num3;
			object myRecordsetDataSource;
			global::Motorola.MackinawCPS.CoreFeatures.RadioWide.GeneralLightbarPatternInner item;
			switch (0)
			{
			case 0:
				break;
			default:
				for (;;)
				{
					IL_0A:
					num = (short)1408692562;
					short num2 = num;
					num = (short)1496379730;
					switch ((num2 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_BF;
					default:
						num = (short)102563841;
						if (num != 0)
						{
						}
						num = (short)1376911360;
						if (num != 0)
						{
						}
						switch (num3)
						{
						case 0:
							goto IL_14E;
						case 1:
							((global::System.Windows.Data.CollectionView)global::System.Windows.Data.CollectionViewSource.GetDefaultView(myRecordsetDataSource)).MoveCurrentTo(item);
							this.RecNavToolbarExpanderRadioWideGeneralLightbarPattern.SyncDataSources();
							num = (short)212271104;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						case 2:
							if (myRecordsetDataSource != null)
							{
								num = (short)1805385729;
								num3 = (int)((global::System.IntPtr)num);
								continue;
							}
							goto IL_150;
						}
						goto IL_8E;
					}
				}
				IL_14E:
				IL_150:
				this.RecNavToolbarExpanderRadioWideGeneralLightbarPattern.TableMode = false;
				return;
			}
			IL_8E:
			item = (global::Motorola.MackinawCPS.CoreFeatures.RadioWide.GeneralLightbarPatternInner)((global::Infragistics.Windows.DataPresenter.CellValuePresenter)((global::AcpUI.AcpButton)e.Source).TemplatedParent).Record.DataItem;
			myRecordsetDataSource = this.RecNavToolbarExpanderRadioWideGeneralLightbarPattern.MyRecordsetDataSource;
			IL_BF:
			num = (short)1045561344;
			short num4 = num;
			num = (short)793444354;
			num3 = (int)((global::System.IntPtr)num);
			goto IL_0A;
		}

		// Token: 0x06003E02 RID: 15874 RVA: 0x0039D740 File Offset: 0x0039B940
		internal void OnExpanderRadioWideRelockTimerClick(object sender, global::System.Windows.RoutedEventArgs e)
		{
			short num;
			int num3;
			object myRecordsetDataSource;
			global::Motorola.MackinawCPS.CoreFeatures.RadioWide.RelockTimerInner item;
			switch (0)
			{
			case 0:
				break;
			default:
				for (;;)
				{
					IL_0A:
					num = (short)1848007323;
					short num2 = num;
					num = (short)442194587;
					switch ((num2 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_C0;
					default:
						num = (short)183959552;
						if (num != 0)
						{
						}
						switch (num3)
						{
						case 0:
							goto IL_151;
						case 1:
							((global::System.Windows.Data.CollectionView)global::System.Windows.Data.CollectionViewSource.GetDefaultView(myRecordsetDataSource)).MoveCurrentTo(item);
							this.RecNavToolbarExpanderRadioWideRelockTimer.SyncDataSources();
							num = (short)145358848;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						case 2:
							if (myRecordsetDataSource != null)
							{
								num = (short)967835649;
								num3 = (int)((global::System.IntPtr)num);
								continue;
							}
							goto IL_153;
						}
						goto IL_67;
					}
				}
				IL_151:
				IL_153:
				this.RecNavToolbarExpanderRadioWideRelockTimer.TableMode = false;
				return;
			}
			IL_67:
			num = (short)1660420097;
			if (num != 0)
			{
			}
			item = (global::Motorola.MackinawCPS.CoreFeatures.RadioWide.RelockTimerInner)((global::Infragistics.Windows.DataPresenter.CellValuePresenter)((global::AcpUI.AcpButton)e.Source).TemplatedParent).Record.DataItem;
			myRecordsetDataSource = this.RecNavToolbarExpanderRadioWideRelockTimer.MyRecordsetDataSource;
			IL_C0:
			num = (short)2069757952;
			short num4 = num;
			num = (short)119472130;
			num3 = (int)((global::System.IntPtr)num);
			goto IL_0A;
		}

		// Token: 0x06003E03 RID: 15875 RVA: 0x0039D8AC File Offset: 0x0039BAAC
		private void RadWideUserInformationandPasswordsUnlockPassword_A8690_GotMouseCapture(object A_0, global::System.Windows.Input.MouseEventArgs A_1)
		{
			short num;
			int num3;
			global::System.Windows.Controls.PasswordBox passwordBox;
			switch (0)
			{
			case 0:
				break;
			default:
				for (;;)
				{
					IL_0A:
					num = (short)1687320763;
					short num2 = num;
					num = (short)1344501947;
					switch ((num2 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_72;
					default:
						num = (short)723714048;
						if (num != 0)
						{
						}
						switch (num3)
						{
						case 0:
							return;
						case 1:
							num = (short)17367041;
							if (num != 0)
							{
							}
							passwordBox.SelectAll();
							num = (short)1473445888;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						case 2:
						{
							num = (short)138280960;
							short num4 = num;
							if (passwordBox != null)
							{
								num = (short)1836384257;
								num3 = (int)((global::System.IntPtr)num);
								continue;
							}
							return;
						}
						}
						goto IL_66;
					}
				}
				return;
			}
			IL_66:
			passwordBox = (A_1.OriginalSource as global::System.Windows.Controls.PasswordBox);
			IL_72:
			num = (short)1942224898;
			num3 = (int)((global::System.IntPtr)num);
			goto IL_0A;
		}

		// Token: 0x06003E04 RID: 15876 RVA: 0x0039D9CC File Offset: 0x0039BBCC
		private void RadWideUserInformationandPasswordsUnlockPassword_A8690_GotKeyboardFocus(object A_0, global::System.Windows.Input.KeyboardFocusChangedEventArgs A_1)
		{
			short num;
			int num3;
			global::System.Windows.Controls.PasswordBox passwordBox;
			switch (0)
			{
			case 0:
				break;
			default:
				for (;;)
				{
					IL_0A:
					num = (short)599503461;
					short num2 = num;
					num = (short)1492234853;
					switch ((num2 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_72;
					default:
						num = (short)1665007616;
						if (num != 0)
						{
						}
						switch (num3)
						{
						case 0:
							return;
						case 1:
							num = (short)519634945;
							if (num != 0)
							{
							}
							passwordBox.SelectAll();
							num = (short)361693184;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						case 2:
						{
							num = (short)1932918784;
							short num4 = num;
							if (passwordBox != null)
							{
								num = (short)2039218177;
								num3 = (int)((global::System.IntPtr)num);
								continue;
							}
							return;
						}
						}
						goto IL_66;
					}
				}
				return;
			}
			IL_66:
			passwordBox = (A_1.OriginalSource as global::System.Windows.Controls.PasswordBox);
			IL_72:
			num = (short)132382722;
			num3 = (int)((global::System.IntPtr)num);
			goto IL_0A;
		}

		// Token: 0x06003E05 RID: 15877 RVA: 0x0039DAEC File Offset: 0x0039BCEC
		[global::System.Diagnostics.DebuggerNonUserCode]
		[global::System.CodeDom.Compiler.GeneratedCode("PresentationBuildTasks", "5.0.10.0")]
		public void InitializeComponent()
		{
			int a_ = 0;
			short num = (short)1053753345;
			if (num != 0)
			{
			}
			if (!this.b)
			{
				num = (short)999137;
				short num2 = num;
				num = (short)667696865;
				switch ((num2 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					break;
				default:
				{
					num = (short)2002059264;
					if (num != 0)
					{
					}
					num = (short)268894208;
					short num3 = num;
					this.b = true;
					global::System.Uri resourceLocator = new global::System.Uri(global::AllFeatures.CodeplugGuid.b("苂꧄ꯆ迈껊곌믎ꓐꇒ냔ꓖ룚닜닞釠賢诤苦蟨鿪심鷮郰韲鳴飶\udcf8짺췼裾栀朂怄⠆笈樊椌明縐搒簔猖簘㔚攜縞䰠伢", a_), global::System.UriKind.Relative);
					global::System.Windows.Application.LoadComponent(this, resourceLocator);
					return;
				}
				}
			}
		}

		// Token: 0x06003E06 RID: 15878 RVA: 0x0039DBCC File Offset: 0x0039BDCC
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		[global::System.CodeDom.Compiler.GeneratedCode("PresentationBuildTasks", "5.0.10.0")]
		[global::System.Diagnostics.DebuggerNonUserCode]
		void global::System.Windows.Markup.IComponentConnector.Connect(int connectionId, object target)
		{
			short num = (short)747896834;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				switch (num2)
				{
				case 0:
					num = (short)464519169;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 1:
					goto IL_5C23;
				case 2:
					switch (0)
					{
					case 0:
						goto IL_30;
					}
					continue;
				}
				IL_30:
				switch (connectionId)
				{
				case 1:
					goto IL_4D6B;
				case 2:
				case 3:
				case 4:
				case 5:
				case 6:
				case 7:
				case 8:
				case 9:
				case 10:
				case 11:
				case 12:
				case 13:
				case 14:
				case 15:
				case 16:
				case 17:
				case 18:
				case 19:
				case 20:
				case 21:
				case 22:
				case 23:
				case 24:
				case 25:
				case 26:
				case 27:
				case 28:
				case 29:
				case 30:
				case 31:
				case 32:
				case 33:
				case 34:
				case 35:
				case 36:
				case 37:
				case 38:
				case 39:
				case 40:
				case 41:
				case 42:
				case 43:
				case 44:
					goto IL_BE95;
				case 45:
					goto IL_7574;
				case 46:
					goto IL_9619;
				case 47:
					goto IL_2D95;
				case 48:
					goto IL_2699;
				case 49:
					goto IL_9429;
				case 50:
					goto IL_A4AD;
				case 51:
					goto IL_5240;
				case 52:
					goto IL_2675;
				case 53:
					goto IL_833B;
				case 54:
					goto IL_A43E;
				case 55:
					goto IL_7427;
				case 56:
					goto IL_20E9;
				case 57:
					goto IL_57BF;
				case 58:
					goto IL_B08B;
				case 59:
					goto IL_7FF8;
				case 60:
					goto IL_B04D;
				case 61:
					goto IL_8671;
				case 62:
					goto IL_B6E1;
				case 63:
					goto IL_A59B;
				case 64:
					goto IL_A1B1;
				case 65:
					goto IL_94D6;
				case 66:
					goto IL_3896;
				case 67:
					goto IL_607A;
				case 68:
					goto IL_9067;
				case 69:
					goto IL_7044;
				case 70:
					goto IL_7954;
				case 71:
					goto IL_9019;
				case 72:
					goto IL_6952;
				case 73:
					goto IL_79D0;
				case 74:
					goto IL_9152;
				case 75:
					goto IL_971E;
				case 76:
					goto IL_8B79;
				case 77:
					goto IL_A044;
				case 78:
					goto IL_8B3B;
				case 79:
					goto IL_B8B7;
				case 80:
					goto IL_9E5E;
				case 81:
					goto IL_7E39;
				case 82:
					goto IL_22CC;
				case 83:
					goto IL_570F;
				case 84:
					goto IL_375D;
				case 85:
					goto IL_66EC;
				case 86:
					goto IL_8205;
				case 87:
					goto IL_3D20;
				case 88:
					goto IL_371F;
				case 89:
					goto IL_3049;
				case 90:
					goto IL_85CE;
				case 91:
					goto IL_A84C;
				case 92:
					goto IL_8BEB;
				case 93:
					goto IL_9145;
				case 94:
					goto IL_5A1B;
				case 95:
					goto IL_A142;
				case 96:
					goto IL_5E25;
				case 97:
					goto IL_25A4;
				case 98:
					goto IL_4A6A;
				case 99:
					goto IL_B8DB;
				case 100:
					goto IL_84D0;
				case 101:
					goto IL_222C;
				case 102:
					goto IL_9F0E;
				case 103:
					goto IL_9FBE;
				case 104:
					goto IL_8573;
				case 105:
					goto IL_B28C;
				case 106:
					goto IL_37BF;
				case 107:
					goto IL_B350;
				case 108:
					goto IL_7961;
				case 109:
					goto IL_A5BF;
				case 110:
					goto IL_346B;
				case 111:
					goto IL_3131;
				case 112:
					goto IL_ABDA;
				case 113:
					goto IL_6C44;
				case 114:
					goto IL_5658;
				case 115:
					goto IL_9CFD;
				case 116:
					goto IL_87C7;
				case 117:
					goto IL_561A;
				case 118:
					goto IL_4BCD;
				case 119:
					goto IL_9F01;
				case 120:
					goto IL_7210;
				case 121:
					goto IL_324D;
				case 122:
					goto IL_6053;
				case 123:
					goto IL_28AD;
				case 124:
					goto IL_ADA0;
				case 125:
					goto IL_7543;
				case 126:
					goto IL_8390;
				case 127:
					goto IL_6520;
				case 128:
					goto IL_712F;
				case 129:
					goto IL_39C2;
				case 130:
					goto IL_91BA;
				case 131:
					goto IL_7D34;
				case 132:
					goto IL_B668;
				case 133:
					goto IL_3E9E;
				case 134:
					goto IL_A9A6;
				case 135:
					goto IL_99C1;
				case 136:
					goto IL_994F;
				case 137:
					goto IL_88F9;
				case 138:
					goto IL_7149;
				case 139:
					goto IL_BD5F;
				case 140:
					goto IL_36D4;
				case 141:
					goto IL_66DF;
				case 142:
					goto IL_2B98;
				case 143:
					goto IL_B9BC;
				case 144:
					goto IL_BDC1;
				case 145:
					goto IL_43FB;
				case 146:
					goto IL_96D0;
				case 147:
					goto IL_AB82;
				case 148:
					goto IL_85FF;
				case 149:
					goto IL_55B8;
				case 150:
					goto IL_B97E;
				case 151:
					goto IL_5FCA;
				case 152:
					goto IL_29BC;
				case 153:
					goto IL_6022;
				case 154:
					goto IL_61A3;
				case 155:
					goto IL_B743;
				case 156:
					goto IL_61B0;
				case 157:
					goto IL_B299;
				case 158:
					goto IL_5C35;
				case 159:
					goto IL_38BA;
				case 160:
					goto IL_88DF;
				case 161:
					goto IL_6F18;
				case 162:
					goto IL_A169;
				case 163:
					goto IL_816C;
				case 164:
					goto IL_2F4E;
				case 165:
					goto IL_6239;
				case 166:
					goto IL_3BEA;
				case 167:
					goto IL_A73D;
				case 168:
					goto IL_62B8;
				case 169:
					goto IL_6DF6;
				case 170:
					goto IL_5CFF;
				case 171:
					goto IL_7AA1;
				case 172:
					goto IL_4D20;
				case 173:
					goto IL_A244;
				case 174:
					goto IL_941C;
				case 175:
					goto IL_B508;
				case 176:
					goto IL_519D;
				case 177:
					goto IL_9E2D;
				case 178:
					goto IL_6FBB;
				case 179:
					goto IL_411A;
				case 180:
					goto IL_9A78;
				case 181:
					goto IL_7D68;
				case 182:
					goto IL_571C;
				case 183:
					goto IL_610D;
				case 184:
					goto IL_4334;
				case 185:
					goto IL_5EEC;
				case 186:
					goto IL_9C26;
				case 187:
					goto IL_3F0D;
				case 188:
					goto IL_A69D;
				case 189:
					goto IL_68B2;
				case 190:
					goto IL_A2D7;
				case 191:
					goto IL_4B03;
				case 192:
					goto IL_2324;
				case 193:
					goto IL_520C;
				case 194:
					goto IL_4C0B;
				case 195:
					goto IL_3824;
				case 196:
					goto IL_4DCD;
				case 197:
					goto IL_5219;
				case 198:
					goto IL_6B04;
				case 199:
					goto IL_74A0;
				case 200:
					goto IL_71D2;
				case 201:
					goto IL_2929;
				case 202:
					goto IL_A0F4;
				case 203:
					goto IL_3D78;
				case 204:
					goto IL_32F7;
				case 205:
					goto IL_995C;
				case 206:
					goto IL_825D;
				case 207:
					goto IL_4B37;
				case 208:
					goto IL_29C9;
				case 209:
					goto IL_7E2C;
				case 210:
					goto IL_B4BA;
				case 211:
					goto IL_5689;
				case 212:
					goto IL_AC87;
				case 213:
					goto IL_30B8;
				case 214:
					goto IL_A1D5;
				case 215:
					goto IL_45CA;
				case 216:
					goto IL_8E71;
				case 217:
					goto IL_9D45;
				case 218:
					goto IL_9790;
				case 219:
					goto IL_4EB8;
				case 220:
					goto IL_5F41;
				case 221:
					goto IL_AE29;
				case 222:
					goto IL_6687;
				case 223:
					goto IL_7343;
				case 224:
					goto IL_2DC6;
				case 225:
					goto IL_4253;
				case 226:
					goto IL_5264;
				case 227:
					goto IL_5BFE;
				case 228:
					goto IL_7B72;
				case 229:
					goto IL_873E;
				case 230:
					goto IL_AE05;
				case 231:
					goto IL_500F;
				case 232:
					goto IL_89D7;
				case 233:
					goto IL_9345;
				case 234:
					goto IL_4CBB;
				case 235:
					goto IL_5D54;
				case 236:
					goto IL_727F;
				case 237:
					goto IL_A70C;
				case 238:
					goto IL_A275;
				case 239:
					goto IL_7A3F;
				case 240:
					goto IL_6487;
				case 241:
					goto IL_B926;
				case 242:
					goto IL_37CC;
				case 243:
					goto IL_3B26;
				case 244:
					goto IL_A76E;
				case 245:
					goto IL_2BBF;
				case 246:
					goto IL_8B6C;
				case 247:
					goto IL_763B;
				case 248:
					goto IL_8F58;
				case 249:
					goto IL_8A9B;
				case 250:
					goto IL_9892;
				case 251:
					goto IL_A8EC;
				case 252:
					goto IL_819D;
				case 253:
					goto IL_3A89;
				case 254:
					goto IL_A870;
				case 255:
					goto IL_A3DC;
				case 256:
					goto IL_8D6C;
				case 257:
					goto IL_B135;
				case 258:
					goto IL_5B20;
				case 259:
					goto IL_621F;
				case 260:
					goto IL_89B3;
				case 261:
					goto IL_2573;
				case 262:
					goto IL_9E51;
				case 263:
					goto IL_44F0;
				case 264:
					goto IL_49D4;
				case 265:
					goto IL_79B6;
				case 266:
					goto IL_2C93;
				case 267:
					goto IL_710B;
				case 268:
					goto IL_A282;
				case 269:
					goto IL_72D4;
				case 270:
					goto IL_881F;
				case 271:
					goto IL_2BD9;
				case 272:
					goto IL_8BC4;
				case 273:
					goto IL_5627;
				case 274:
					goto IL_52D6;
				case 275:
					goto IL_A322;
				case 276:
					goto IL_42CC;
				case 277:
					goto IL_539A;
				case 278:
					goto IL_6EB3;
				case 279:
					goto IL_63FB;
				case 280:
					goto IL_5C83;
				case 281:
					goto IL_A2F1;
				case 282:
					goto IL_AA9E;
				case 283:
					goto IL_9B28;
				case 284:
					goto IL_73E6;
				case 285:
					goto IL_9FEF;
				case 286:
					goto IL_4382;
				case 287:
					goto IL_706B;
				case 288:
					goto IL_57E3;
				case 289:
					goto IL_B5C5;
				case 290:
					goto IL_96C3;
				case 291:
					goto IL_6B38;
				case 292:
					goto IL_A536;
				case 293:
					goto IL_97E5;
				case 294:
					goto IL_98D3;
				case 295:
					goto IL_B111;
				case 296:
					goto IL_6D49;
				case 297:
					goto IL_60C2;
				case 298:
					goto IL_3C66;
				case 299:
					goto IL_6CD7;
				case 300:
					goto IL_54C3;
				case 301:
					goto IL_5271;
				case 302:
					goto IL_3F72;
				case 303:
					goto IL_900C;
				case 304:
					goto IL_4039;
				case 305:
					goto IL_6246;
				case 306:
					goto IL_5D0C;
				case 307:
					goto IL_3447;
				case 308:
					goto IL_3C35;
				case 309:
					goto IL_2025;
				case 310:
					goto IL_9B73;
				case 311:
					goto IL_A128;
				case 312:
					goto IL_91EB;
				case 313:
					goto IL_7930;
				case 314:
					goto IL_5A8A;
				case 315:
					goto IL_ACB8;
				case 316:
					goto IL_52FA;
				case 317:
					goto IL_4615;
				case 318:
					goto IL_25C8;
				case 319:
					goto IL_2E35;
				case 320:
					goto IL_29D6;
				case 321:
					goto IL_BC67;
				case 322:
					goto IL_A7F4;
				case 323:
					goto IL_8A6A;
				case 324:
					goto IL_3087;
				case 325:
					goto IL_BBB0;
				case 326:
					goto IL_B705;
				case 327:
					goto IL_BBF8;
				case 328:
					goto IL_2EBB;
				case 329:
					goto IL_870A;
				case 330:
					goto IL_272C;
				case 331:
					goto IL_4C8A;
				case 332:
					goto IL_6E34;
				case 333:
					goto IL_B35D;
				case 334:
					goto IL_A529;
				case 335:
					goto IL_8853;
				case 336:
					goto IL_55D2;
				case 337:
					goto IL_2B43;
				case 338:
					goto IL_2597;
				case 339:
					goto IL_B53C;
				case 340:
					goto IL_80B2;
				case 341:
					goto IL_B6B0;
				case 342:
					goto IL_2433;
				case 343:
					goto IL_44CC;
				case 344:
					goto IL_8664;
				case 345:
					goto IL_BE0C;
				case 346:
					goto IL_B75D;
				case 347:
					goto IL_AB9C;
				case 348:
					goto IL_7F17;
				case 349:
					goto IL_3193;
				case 350:
					goto IL_230A;
				case 351:
					goto IL_2BA5;
				case 352:
					goto IL_6FF9;
				case 353:
					goto IL_4C49;
				case 354:
					goto IL_5BA9;
				case 355:
					goto IL_B31F;
				case 356:
					goto IL_96DD;
				case 357:
					goto IL_7037;
				case 358:
					goto IL_91A0;
				case 359:
					goto IL_86F0;
				case 360:
					goto IL_2131;
				case 361:
					goto IL_660B;
				case 362:
					goto IL_2331;
				case 363:
					goto IL_8839;
				case 364:
					goto IL_3600;
				case 365:
					goto IL_4CF9;
				case 366:
					goto IL_4F00;
				case 367:
					goto IL_49E1;
				case 368:
					goto IL_B7E6;
				case 369:
					goto IL_744B;
				case 370:
					goto IL_9033;
				case 371:
					goto IL_7581;
				case 372:
					goto IL_B90C;
				case 373:
					goto IL_916C;
				case 374:
					goto IL_4955;
				case 375:
					goto IL_22A8;
				case 376:
					goto IL_2EC8;
				case 377:
					goto IL_9B42;
				case 378:
					goto IL_4A9E;
				case 379:
					goto IL_7006;
				case 380:
					goto IL_3A65;
				case 381:
					goto IL_6B45;
				case 382:
					goto IL_5F99;
				case 383:
					goto IL_76E8;
				case 384:
					goto IL_6F7D;
				case 385:
					goto IL_7381;
				case 386:
					goto IL_774A;
				case 387:
					goto IL_BAEF;
				case 388:
					goto IL_3F00;
				case 389:
					goto IL_434E;
				case 390:
					goto IL_ACAB;
				case 391:
					goto IL_2C3E;
				case 392:
					goto IL_68D6;
				case 393:
					goto IL_8148;
				case 394:
					goto IL_8EFD;
				case 395:
					goto IL_B4EE;
				case 396:
					goto IL_9338;
				case 397:
					goto IL_68A5;
				case 398:
					goto IL_A828;
				case 399:
					goto IL_23D1;
				case 400:
					goto IL_82BF;
				case 401:
					goto IL_A2CA;
				case 402:
					goto IL_6196;
				case 403:
					goto IL_4084;
				case 404:
					goto IL_2D4D;
				case 405:
					goto IL_969F;
				case 406:
					goto IL_86E3;
				case 407:
					goto IL_A92A;
				case 408:
					goto IL_B377;
				case 409:
					goto IL_40F3;
				case 410:
					goto IL_B1EC;
				case 411:
					goto IL_7DE4;
				case 412:
					goto IL_94A5;
				case 413:
					goto IL_3862;
				case 414:
					goto IL_A638;
				case 415:
					goto IL_ADBA;
				case 416:
					goto IL_A0C0;
				case 417:
					goto IL_B886;
				case 418:
					goto IL_6BEF;
				case 419:
					goto IL_A9DA;
				case 420:
					goto IL_8E64;
				case 421:
					goto IL_481F;
				case 422:
					goto IL_7265;
				case 423:
					goto IL_762E;
				case 424:
					goto IL_8036;
				case 425:
					goto IL_4917;
				case 426:
					goto IL_B515;
				case 427:
					goto IL_7DD7;
				case 428:
					goto IL_AE9B;
				case 429:
					goto IL_4212;
				case 430:
					goto IL_4A84;
				case 431:
					goto IL_210D;
				case 432:
					goto IL_4E25;
				case 433:
					goto IL_367F;
				case 434:
					goto IL_A937;
				case 435:
					goto IL_613E;
				case 436:
					goto IL_4127;
				case 437:
					goto IL_BC74;
				case 438:
					goto IL_B237;
				case 439:
					goto IL_3F1A;
				case 440:
					goto IL_9878;
				case 441:
					goto IL_4FA0;
				case 442:
					goto IL_81D1;
				case 443:
					goto IL_7788;
				case 444:
					goto IL_7EA8;
				case 445:
					goto IL_B07E;
				case 446:
					goto IL_7374;
				case 447:
					goto IL_3953;
				case 448:
					goto IL_2BB2;
				case 449:
					goto IL_9138;
				case 450:
					goto IL_4DA9;
				case 451:
					goto IL_4F4B;
				case 452:
					goto IL_685A;
				case 453:
					goto IL_6B69;
				case 454:
					goto IL_4D9C;
				case 455:
					goto IL_33D8;
				case 456:
					goto IL_5E56;
				case 457:
					goto IL_BC12;
				case 458:
					goto IL_5845;
				case 459:
					goto IL_4710;
				case 460:
					goto IL_A1E2;
				case 461:
					goto IL_832E;
				case 462:
					goto IL_53A7;
				case 463:
					goto IL_830A;
				case 464:
					goto IL_2362;
				case 465:
					goto IL_8F17;
				case 466:
					goto IL_B7CC;
				case 467:
					goto IL_200B;
				case 468:
					goto IL_56DE;
				case 469:
					goto IL_5F7F;
				case 470:
					goto IL_A982;
				case 471:
					goto IL_AA7A;
				case 472:
					goto IL_952B;
				case 473:
					goto IL_3EE6;
				case 474:
					goto IL_21C7;
				case 475:
					goto IL_71F6;
				case 476:
					goto IL_992B;
				case 477:
					goto IL_5338;
				case 478:
					goto IL_505A;
				case 479:
					goto IL_BCBC;
				case 480:
					goto IL_6396;
				case 481:
					goto IL_B033;
				case 482:
					goto IL_546E;
				case 483:
					goto IL_97FF;
				case 484:
					goto IL_213E;
				case 485:
					goto IL_9BE5;
				case 486:
					goto IL_9969;
				case 487:
					goto IL_B343;
				case 488:
					goto IL_6D56;
				case 489:
					goto IL_6836;
				case 490:
					goto IL_7662;
				case 491:
					goto IL_5ED2;
				case 492:
					goto IL_B879;
				case 493:
					goto IL_5A70;
				case 494:
					goto IL_BBD4;
				case 495:
					goto IL_90E3;
				case 496:
					goto IL_8657;
				case 497:
					goto IL_A645;
				case 498:
					goto IL_662F;
				case 499:
					goto IL_AEC2;
				case 500:
					goto IL_B39E;
				case 501:
					goto IL_2EF9;
				case 502:
					goto IL_716D;
				case 503:
					goto IL_5DE7;
				case 504:
					goto IL_9179;
				case 505:
					goto IL_A8DF;
				case 506:
					goto IL_254F;
				case 507:
					goto IL_6B9A;
				case 508:
					goto IL_7B8C;
				case 509:
					goto IL_81AA;
				case 510:
					goto IL_B78E;
				case 511:
					goto IL_6284;
				case 512:
					goto IL_3FE1;
				case 513:
					goto IL_5DA9;
				case 514:
					goto IL_5E7A;
				case 515:
					goto IL_22FD;
				case 516:
					goto IL_5814;
				case 517:
					goto IL_A91D;
				case 518:
					goto IL_7E08;
				case 519:
					goto IL_A06B;
				case 520:
					goto IL_85B4;
				case 521:
					goto IL_2087;
				case 522:
					goto IL_3CD5;
				case 523:
					goto IL_7203;
				case 524:
					goto IL_57F0;
				case 525:
					goto IL_AFC4;
				case 526:
					goto IL_401F;
				case 527:
					goto IL_5416;
				case 528:
					goto IL_96EA;
				case 529:
					goto IL_A550;
				case 530:
					goto IL_4053;
				case 531:
					goto IL_21FB;
				case 532:
					goto IL_9576;
				case 533:
					goto IL_8BD1;
				case 534:
					goto IL_9776;
				case 535:
					goto IL_86AF;
				case 536:
					goto IL_8A46;
				case 537:
					goto IL_898F;
				case 538:
					goto IL_38E1;
				case 539:
					goto IL_2A24;
				case 540:
					goto IL_64C5;
				case 541:
					goto IL_21EE;
				case 542:
					goto IL_6327;
				case 543:
					goto IL_61D4;
				case 544:
					goto IL_A543;
				case 545:
					goto IL_8ACC;
				case 546:
					goto IL_9CCC;
				case 547:
					goto IL_B4E1;
				case 548:
					goto IL_AD6F;
				case 549:
					goto IL_6AB9;
				case 550:
					goto IL_B00C;
				case 551:
					goto IL_2D33;
				case 552:
					goto IL_538D;
				case 553:
					goto IL_574D;
				case 554:
					goto IL_9240;
				case 555:
					goto IL_B6BD;
				case 556:
					goto IL_64DF;
				case 557:
					goto IL_35E6;
				case 558:
					goto IL_3226;
				case 559:
					goto IL_95C1;
				case 560:
					goto IL_9307;
				case 561:
					goto IL_41EE;
				case 562:
					goto IL_3A4B;
				case 563:
					goto IL_7CE9;
				case 564:
					goto IL_4BA6;
				case 565:
					goto IL_5988;
				case 566:
					goto IL_ADE1;
				case 567:
					goto IL_9738;
				case 568:
					goto IL_6649;
				case 569:
					goto IL_9352;
				case 570:
					goto IL_8B93;
				case 571:
					goto IL_37F0;
				case 572:
					goto IL_80BF;
				case 573:
					goto IL_489E;
				case 574:
					goto IL_5152;
				case 575:
					goto IL_39CF;
				case 576:
					goto IL_A39E;
				case 577:
					goto IL_3750;
				case 578:
					goto IL_9F80;
				case 579:
					goto IL_3B02;
				case 580:
					goto IL_8CBC;
				case 581:
					goto IL_5B47;
				case 582:
					goto IL_98AC;
				case 583:
					goto IL_951E;
				case 584:
					goto IL_27E6;
				case 585:
					goto IL_33E5;
				case 586:
					goto IL_38D4;
				case 587:
					goto IL_4B10;
				case 588:
					goto IL_6513;
				case 589:
					goto IL_49BA;
				case 590:
					goto IL_A4EB;
				case 591:
					goto IL_7BE4;
				case 592:
					goto IL_28BA;
				case 593:
					goto IL_4E87;
				case 594:
					goto IL_BAC8;
				case 595:
					goto IL_8D3B;
				case 596:
					goto IL_2A65;
				case 597:
					goto IL_8ECC;
				case 598:
					goto IL_2B1F;
				case 599:
					goto IL_69E2;
				case 600:
					goto IL_3F4B;
				case 601:
					goto IL_39DC;
				case 602:
					goto IL_B5F6;
				case 603:
					goto IL_58AA;
				case 604:
					goto IL_4196;
				case 605:
					goto IL_504D;
				case 606:
					goto IL_21E1;
				case 607:
					goto IL_2C17;
				case 608:
					goto IL_B489;
				case 609:
					goto IL_7992;
				case 610:
					goto IL_356A;
				case 611:
					goto IL_7648;
				case 612:
					goto IL_3855;
				case 613:
					goto IL_2777;
				case 614:
					goto IL_4812;
				case 615:
					goto IL_477F;
				case 616:
					goto IL_A894;
				case 617:
					goto IL_4D47;
				case 618:
					goto IL_5C76;
				case 619:
					goto IL_35D9;
				case 620:
					goto IL_BCD6;
				case 621:
					goto IL_454B;
				case 622:
					goto IL_99CE;
				case 623:
					goto IL_5556;
				case 624:
					goto IL_358E;
				case 625:
					goto IL_6A47;
				case 626:
					goto IL_39B5;
				case 627:
					goto IL_A9B3;
				case 628:
					goto IL_3ABA;
				case 629:
					goto IL_751F;
				case 630:
					goto IL_3304;
				case 631:
					goto IL_9A85;
				case 632:
					goto IL_4572;
				case 633:
					goto IL_6E99;
				case 634:
					goto IL_AD4B;
				case 635:
					goto IL_B9C9;
				case 636:
					goto IL_66D2;
				case 637:
					goto IL_6439;
				case 638:
					goto IL_49EE;
				case 639:
					goto IL_4524;
				case 640:
					goto IL_808E;
				case 641:
					goto IL_5F5B;
				case 642:
					goto IL_BDF2;
				case 643:
					goto IL_789A;
				case 644:
					goto IL_5781;
				case 645:
					goto IL_8796;
				case 646:
					goto IL_9A54;
				case 647:
					goto IL_B41A;
				case 648:
					goto IL_5B9C;
				case 649:
					goto IL_B7D9;
				case 650:
					goto IL_307A;
				case 651:
					goto IL_32A2;
				case 652:
					goto IL_7E53;
				case 653:
					goto IL_8542;
				case 654:
					goto IL_486D;
				case 655:
					goto IL_79F4;
				case 656:
					goto IL_BDE5;
				case 657:
					goto IL_2BCC;
				case 658:
					goto IL_6365;
				case 659:
					goto IL_5995;
				case 660:
					goto IL_21BA;
				case 661:
					goto IL_BE88;
				case 662:
					goto IL_8074;
				case 663:
					goto IL_B750;
				case 664:
					goto IL_75A8;
				case 665:
					goto IL_658F;
				case 666:
					goto IL_35CC;
				case 667:
					goto IL_2419;
				case 668:
					goto IL_4D2D;
				case 669:
					goto IL_7923;
				case 670:
					goto IL_2246;
				case 671:
					goto IL_655E;
				case 672:
					goto IL_B65B;
				case 673:
					goto IL_34F1;
				case 674:
					goto IL_9CA5;
				case 675:
					goto IL_AA3C;
				case 676:
					goto IL_97C1;
				case 677:
					goto IL_4F7C;
				case 678:
					goto IL_920F;
				case 679:
					goto IL_6656;
				case 680:
					goto IL_3CA4;
				case 681:
					goto IL_89E4;
				case 682:
					goto IL_26E4;
				case 683:
					goto IL_7ECC;
				case 684:
					goto IL_95B4;
				case 685:
					goto IL_2637;
				case 686:
					goto IL_34C0;
				case 687:
					goto IL_AFB7;
				case 688:
					goto IL_4CD5;
				case 689:
					goto IL_535C;
				case 690:
					goto IL_8B2E;
				case 691:
					goto IL_A462;
				case 692:
					goto IL_25EC;
				case 693:
					goto IL_BD21;
				case 694:
					goto IL_7A7D;
				case 695:
					goto IL_892A;
				case 696:
					goto IL_8731;
				case 697:
					goto IL_79C3;
				case 698:
					goto IL_5295;
				case 699:
					goto IL_AB20;
				case 700:
					goto IL_3FA3;
				case 701:
					goto IL_7350;
				case 702:
					goto IL_92C6;
				case 703:
					goto IL_4239;
				case 704:
					goto IL_B3DC;
				case 705:
					goto IL_5DCD;
				case 706:
					goto IL_3056;
				case 707:
					goto IL_3B7B;
				case 708:
					goto IL_8E57;
				case 709:
					goto IL_57B2;
				case 710:
					goto IL_3D92;
				case 711:
					goto IL_3D47;
				case 712:
					goto IL_3E18;
				case 713:
					goto IL_B68C;
				case 714:
					goto IL_B556;
				case 715:
					goto IL_64D2;
				case 716:
					goto IL_3162;
				case 717:
					goto IL_8CD6;
				case 718:
					goto IL_280A;
				case 719:
					goto IL_37FD;
				case 720:
					goto IL_4D06;
				case 721:
					goto IL_8029;
				case 722:
					goto IL_A0DA;
				case 723:
					goto IL_3712;
				case 724:
					goto IL_3A27;
				case 725:
					goto IL_7B41;
				case 726:
					goto IL_4948;
				case 727:
					goto IL_BD90;
				case 728:
					goto IL_46B8;
				case 729:
					goto IL_2277;
				case 730:
					goto IL_50E6;
				case 731:
					goto IL_9538;
				case 732:
					goto IL_90D6;
				case 733:
					goto IL_380A;
				case 734:
					goto IL_63A3;
				case 735:
					goto IL_A7C3;
				case 736:
					goto IL_2AB0;
				case 737:
					goto IL_89F1;
				case 738:
					goto IL_3311;
				case 739:
					goto IL_5AEF;
				case 740:
					goto IL_AE6A;
				case 741:
					goto IL_98F7;
				case 742:
					goto IL_47E1;
				case 743:
					goto IL_2971;
				case 744:
					goto IL_557A;
				case 745:
					goto IL_4300;
				case 746:
					goto IL_9B1B;
				case 747:
					goto IL_A9CD;
				case 748:
					goto IL_372C;
				case 749:
					goto IL_614B;
				case 750:
					goto IL_70C0;
				case 751:
					goto IL_67B0;
				case 752:
					goto IL_9AAC;
				case 753:
					goto IL_7C77;
				case 754:
					goto IL_6D7A;
				case 755:
					goto IL_247E;
				case 756:
					goto IL_51F2;
				case 757:
					goto IL_9A92;
				case 758:
					goto IL_586C;
				case 759:
					goto IL_37B2;
				case 760:
					goto IL_699A;
				case 761:
					goto IL_B3F6;
				case 762:
					goto IL_3FC7;
				case 763:
					goto IL_3D2D;
				case 764:
					goto IL_935F;
				case 765:
					goto IL_6EA6;
				case 766:
					goto IL_A77B;
				case 767:
					goto IL_5957;
				case 768:
					goto IL_2E8A;
				case 769:
					goto IL_62AB;
				case 770:
					goto IL_A0E7;
				case 771:
					goto IL_6015;
				case 772:
					goto IL_BCF0;
				case 773:
					goto IL_840C;
				case 774:
					goto IL_51C1;
				case 775:
					goto IL_2FF4;
				case 776:
					goto IL_95CE;
				case 777:
					goto IL_3F58;
				case 778:
					goto IL_A2E4;
				case 779:
					goto IL_6B1E;
				case 780:
					goto IL_3025;
				case 781:
					goto IL_9EB9;
				case 782:
					goto IL_A11B;
				case 783:
					goto IL_88C5;
				case 784:
					goto IL_4A1F;
				case 785:
					goto IL_66C5;
				case 786:
					goto IL_4E63;
				case 787:
					goto IL_785C;
				case 788:
					goto IL_49AD;
				case 789:
					goto IL_BC05;
				case 790:
					goto IL_431A;
				case 791:
					goto IL_2A58;
				case 792:
					goto IL_BC43;
				case 793:
					goto IL_87E1;
				case 794:
					goto IL_6F32;
				case 795:
					goto IL_AFAA;
				case 796:
					goto IL_B391;
				case 797:
					goto IL_6CE4;
				case 798:
					goto IL_7719;
				case 799:
					goto IL_5696;
				case 800:
					goto IL_74C7;
				case 801:
					goto IL_9E92;
				case 802:
					goto IL_B040;
				case 803:
					goto IL_3E0B;
				case 804:
					goto IL_AF6C;
				case 805:
					goto IL_65B3;
				case 806:
					goto IL_989F;
				case 807:
					goto IL_462F;
				case 808:
					goto IL_4979;
				case 809:
					goto IL_78B4;
				case 810:
					goto IL_936C;
				case 811:
					goto IL_AC56;
				case 812:
					goto IL_7655;
				case 813:
					goto IL_2995;
				case 814:
					goto IL_26D7;
				case 815:
					goto IL_5F4E;
				case 816:
					goto IL_BC98;
				case 817:
					goto IL_B25B;
				case 818:
					goto IL_B83B;
				case 819:
					goto IL_8DAA;
				case 820:
					goto IL_BB72;
				case 821:
					goto IL_2471;
				case 822:
					goto IL_550B;
				case 823:
					goto IL_24A2;
				case 824:
					goto IL_7D75;
				case 825:
					goto IL_31C4;
				case 826:
					goto IL_7C5D;
				case 827:
					goto IL_8383;
				case 828:
					goto IL_7550;
				case 829:
					goto IL_2172;
				case 830:
					goto IL_84DD;
				case 831:
					goto IL_2165;
				case 832:
					goto IL_972B;
				case 833:
					goto IL_7E9B;
				case 834:
					goto IL_70CD;
				case 835:
					goto IL_7CF6;
				case 836:
					goto IL_8C7E;
				case 837:
					goto IL_7D1A;
				case 838:
					goto IL_88AB;
				case 839:
					goto IL_8695;
				case 840:
					goto IL_7ADF;
				case 841:
					goto IL_9C67;
				case 842:
					goto IL_A47C;
				case 843:
					goto IL_597B;
				case 844:
					goto IL_963D;
				case 845:
					goto IL_88B8;
				case 846:
					goto IL_69BE;
				case 847:
					goto IL_9CD9;
				case 848:
					goto IL_2504;
				case 849:
					goto IL_A58E;
				case 850:
					goto IL_A8D2;
				case 851:
					goto IL_8107;
				case 852:
					goto IL_8A77;
				case 853:
					goto IL_6D0B;
				case 854:
					goto IL_40C2;
				case 855:
					goto IL_7B27;
				case 856:
					goto IL_B36A;
				case 857:
					goto IL_6AAC;
				case 858:
					goto IL_6C51;
				case 859:
					goto IL_8FC4;
				case 860:
					goto IL_4A77;
				case 861:
					goto IL_4E56;
				case 862:
					goto IL_98C6;
				case 863:
					goto IL_93DE;
				case 864:
					goto IL_4134;
				case 865:
					goto IL_4AD2;
				case 866:
					goto IL_4622;
				case 867:
					goto IL_9FB1;
				case 868:
					goto IL_52AF;
				case 869:
					goto IL_6205;
				case 870:
					goto IL_2AD4;
				case 871:
					goto IL_3A58;
				case 872:
					goto IL_6881;
				case 873:
					goto IL_AECF;
				case 874:
					goto IL_5E87;
				case 875:
					goto IL_AE36;
				case 876:
					goto IL_877C;
				case 877:
					goto IL_402C;
				case 878:
					goto IL_8A15;
				case 879:
					goto IL_829B;
				case 880:
					goto IL_705E;
				case 881:
					goto IL_8F4B;
				case 882:
					goto IL_26CA;
				case 883:
					goto IL_5549;
				case 884:
					goto IL_44BF;
				case 885:
					goto IL_34FE;
				case 886:
					goto IL_4DF4;
				case 887:
					goto IL_4860;
				case 888:
					goto IL_6CFE;
				case 889:
					goto IL_63EE;
				case 890:
					goto IL_7AD2;
				case 891:
					goto IL_578E;
				case 892:
					goto IL_AD27;
				case 893:
					goto IL_44B2;
				case 894:
					goto IL_A944;
				case 895:
					goto IL_B712;
				case 896:
					goto IL_8580;
				case 897:
					goto IL_A46F;
				case 898:
					goto IL_2708;
				case 899:
					goto IL_746F;
				case 900:
					goto IL_A40D;
				case 901:
					goto IL_51E5;
				case 902:
					goto IL_594A;
				case 903:
					goto IL_31B7;
				case 904:
					goto IL_8D86;
				case 905:
					goto IL_2905;
				case 906:
					goto IL_859A;
				case 907:
					goto IL_50BF;
				case 908:
					goto IL_77DD;
				case 909:
					goto IL_A391;
				case 910:
					goto IL_5BCD;
				case 911:
					goto IL_964A;
				case 912:
					goto IL_7CB5;
				case 913:
					goto IL_86FD;
				case 914:
					goto IL_7272;
				case 915:
					goto IL_3FD4;
				case 916:
					goto IL_A33C;
				case 917:
					goto IL_3D9F;
				case 918:
					goto IL_36E1;
				case 919:
					goto IL_4B99;
				case 920:
					goto IL_361A;
				case 921:
					goto IL_AD0D;
				case 922:
					goto IL_708F;
				case 923:
					goto IL_24E0;
				case 924:
					goto IL_5CCE;
				case 925:
					goto IL_4158;
				case 926:
					goto IL_9DD8;
				case 927:
					goto IL_7FD1;
				case 928:
					goto IL_6260;
				case 929:
					goto IL_80E3;
				case 930:
					goto IL_8E19;
				case 931:
					goto IL_2F5B;
				case 932:
					goto IL_97F2;
				case 933:
					goto IL_7FA0;
				case 934:
					goto IL_ABA9;
				case 935:
					goto IL_5492;
				case 936:
					goto IL_40B5;
				case 937:
					goto IL_78A7;
				case 938:
					goto IL_2C31;
				case 939:
					goto IL_64EC;
				case 940:
					goto IL_A79F;
				case 941:
					goto IL_512E;
				case 942:
					goto IL_392C;
				case 943:
					goto IL_99B4;
				case 944:
					goto IL_AE43;
				case 945:
					goto IL_9BB1;
				case 946:
					goto IL_20C5;
				case 947:
					goto IL_663C;
				case 948:
					goto IL_781E;
				case 949:
					goto IL_ACC5;
				case 950:
					goto IL_3A96;
				case 951:
					goto IL_9C33;
				case 952:
					goto IL_6DDC;
				case 953:
					goto IL_3124;
				case 954:
					goto IL_2239;
				case 955:
					goto IL_2CF5;
				case 956:
					goto IL_36B0;
				case 957:
					goto IL_6189;
				case 958:
					goto IL_A801;
				case 959:
					goto IL_9569;
				case 960:
					goto IL_999A;
				case 961:
					goto IL_B603;
				case 962:
					goto IL_7F6C;
				case 963:
					goto IL_7400;
				case 964:
					goto IL_29AF;
				case 965:
					goto IL_BA1E;
				case 966:
					goto IL_4A91;
				case 967:
					goto IL_44FD;
				case 968:
					goto IL_8982;
				case 969:
					goto IL_4853;
				case 970:
					goto IL_6EFE;
				case 971:
					goto IL_96F7;
				case 972:
					goto IL_4517;
				case 973:
					goto IL_6F8A;
				case 974:
					goto IL_AA0B;
				case 975:
					goto IL_9186;
				case 976:
					goto IL_8566;
				case 977:
					goto IL_7DA6;
				case 978:
					goto IL_4565;
				case 979:
					goto IL_31F5;
				case 980:
					goto IL_8528;
				case 981:
					goto IL_805A;
				case 982:
					goto IL_92D3;
				case 983:
					goto IL_7013;
				case 984:
					goto IL_8EA5;
				case 985:
					goto IL_B848;
				case 986:
					goto IL_AF9D;
				case 987:
					goto IL_2F75;
				case 988:
					goto IL_759B;
				case 989:
					goto IL_4A39;
				case 990:
					goto IL_4B1D;
				case 991:
					goto IL_2F82;
				case 992:
					goto IL_2A31;
				case 993:
					goto IL_77EA;
				case 994:
					goto IL_6B11;
				case 995:
					goto IL_78FF;
				case 996:
					goto IL_33CB;
				case 997:
					goto IL_3F27;
				case 998:
					goto IL_9C98;
				case 999:
					goto IL_49A0;
				case 1000:
					goto IL_5C69;
				case 1001:
					goto IL_9EDD;
				case 1002:
					goto IL_82D9;
				case 1003:
					goto IL_8D48;
				case 1004:
					goto IL_3946;
				case 1005:
					goto IL_9193;
				case 1006:
					goto IL_4F6F;
				case 1007:
					goto IL_766F;
				case 1008:
					goto IL_7CC2;
				case 1009:
					goto IL_AB3A;
				case 1010:
					goto IL_8281;
				case 1011:
					goto IL_4341;
				case 1012:
					goto IL_78E5;
				case 1013:
					goto IL_9FFC;
				case 1014:
					goto IL_83FF;
				case 1015:
					goto IL_9D52;
				case 1016:
					goto IL_2644;
				case 1017:
					goto IL_7FDE;
				case 1018:
					goto IL_9B35;
				case 1019:
					goto IL_B8E8;
				case 1020:
					goto IL_B026;
				case 1021:
					goto IL_327E;
				case 1022:
					goto IL_8B86;
				case 1023:
					goto IL_2B67;
				case 1024:
					goto IL_7E46;
				case 1025:
					goto IL_74D4;
				case 1026:
					goto IL_9A9F;
				case 1027:
					goto IL_821F;
				case 1028:
					goto IL_788D;
				case 1029:
					goto IL_9C5A;
				case 1030:
					goto IL_2E0E;
				case 1031:
					goto IL_6734;
				case 1032:
					goto IL_AEA8;
				case 1033:
					goto IL_4660;
				case 1034:
					goto IL_A10E;
				case 1035:
					goto IL_B86C;
				case 1036:
					goto IL_221F;
				case 1037:
					goto IL_BA2B;
				case 1038:
					goto IL_343A;
				case 1039:
					goto IL_6914;
				case 1040:
					goto IL_940F;
				case 1041:
					goto IL_51FF;
				case 1042:
					goto IL_5B3A;
				case 1043:
					goto IL_65D7;
				case 1044:
					goto IL_3EC2;
				case 1045:
					goto IL_BE7B;
				case 1046:
					goto IL_8D21;
				case 1047:
					goto IL_93C4;
				case 1048:
					goto IL_6100;
				case 1049:
					goto IL_50D9;
				case 1050:
					goto IL_27B5;
				case 1051:
					goto IL_AE5D;
				case 1052:
					goto IL_6AF7;
				case 1053:
					goto IL_9BFF;
				case 1054:
					goto IL_AAD5;
				case 1055:
					goto IL_986B;
				case 1056:
					goto IL_6EF1;
				case 1057:
					goto IL_5226;
				case 1058:
					goto IL_6E4E;
				case 1059:
					goto IL_9AC6;
				case 1060:
					goto IL_2D26;
				case 1061:
					goto IL_7C6A;
				case 1062:
					goto IL_8B0A;
				case 1063:
					goto IL_490A;
				case 1064:
					goto IL_602F;
				case 1065:
					goto IL_713C;
				case 1066:
					goto IL_3817;
				case 1067:
					goto IL_41BA;
				case 1068:
					goto IL_6F97;
				case 1069:
					goto IL_3658;
				case 1070:
					goto IL_9A30;
				case 1071:
					goto IL_4E18;
				case 1072:
					goto IL_92E0;
				case 1073:
					goto IL_8C64;
				case 1074:
					goto IL_A2A6;
				case 1075:
					goto IL_50B2;
				case 1076:
					goto IL_32D3;
				case 1077:
					goto IL_2A0A;
				case 1078:
					goto IL_4805;
				case 1079:
					goto IL_7B34;
				case 1080:
					goto IL_874B;
				case 1081:
					goto IL_642C;
				case 1082:
					goto IL_7AAE;
				case 1083:
					goto IL_B964;
				case 1084:
					goto IL_A14F;
				case 1085:
					goto IL_3271;
				case 1086:
					goto IL_AF48;
				case 1087:
					goto IL_7D5B;
				case 1088:
					goto IL_A9E7;
				case 1089:
					goto IL_575A;
				case 1090:
					goto IL_24C6;
				case 1091:
					goto IL_6A85;
				case 1092:
					goto IL_8FA0;
				case 1093:
					goto IL_641F;
				case 1094:
					goto IL_331E;
				case 1095:
					goto IL_410D;
				case 1096:
					goto IL_75F0;
				case 1097:
					goto IL_94C9;
				case 1098:
					goto IL_54E7;
				case 1099:
					goto IL_7CA8;
				case 1100:
					goto IL_3522;
				case 1101:
					goto IL_3672;
				case 1102:
					goto IL_52BC;
				case 1103:
					goto IL_28F8;
				case 1104:
					goto IL_67E1;
				case 1105:
					goto IL_8717;
				case 1106:
					goto IL_3627;
				case 1107:
					goto IL_26BD;
				case 1108:
					goto IL_6938;
				case 1109:
					goto IL_9704;
				case 1110:
					goto IL_45D7;
				case 1111:
					goto IL_65E4;
				case 1112:
					goto IL_7C84;
				case 1113:
					goto IL_7F0A;
				case 1114:
					goto IL_647A;
				case 1115:
					goto IL_2426;
				case 1116:
					goto IL_349C;
				case 1117:
					goto IL_9769;
				case 1118:
					goto IL_3E7A;
				case 1119:
					goto IL_6A3A;
				case 1120:
					goto IL_A676;
				case 1121:
					goto IL_72C7;
				case 1122:
					goto IL_84AC;
				case 1123:
					goto IL_3960;
				case 1124:
					goto IL_9847;
				case 1125:
					goto IL_AF90;
				case 1126:
					goto IL_A4DE;
				case 1127:
					goto IL_3F65;
				case 1128:
					goto IL_A55D;
				case 1129:
					goto IL_42BF;
				case 1130:
					goto IL_A135;
				case 1131:
					goto IL_A9C0;
				case 1132:
					goto IL_760A;
				case 1133:
					goto IL_66A1;
				case 1134:
					goto IL_422C;
				case 1135:
					goto IL_B4FB;
				case 1136:
					goto IL_850E;
				case 1137:
					goto IL_A0B3;
				case 1138:
					goto IL_6976;
				case 1139:
					goto IL_7C15;
				case 1140:
					goto IL_8B5F;
				case 1141:
					goto IL_758E;
				case 1142:
					goto IL_33B1;
				case 1143:
					goto IL_AA6D;
				case 1144:
					goto IL_4E94;
				case 1145:
					goto IL_2AFB;
				case 1146:
					goto IL_2542;
				case 1147:
					goto IL_95FF;
				case 1148:
					goto IL_B64E;
				case 1149:
					goto IL_ADC7;
				case 1150:
					goto IL_59EA;
				case 1151:
					goto IL_6A54;
				case 1152:
					goto IL_46AB;
				case 1153:
					goto IL_7329;
				case 1154:
					goto IL_7F86;
				case 1155:
					goto IL_B5B8;
				case 1156:
					goto IL_2CD1;
				case 1157:
					goto IL_4446;
				case 1158:
					goto IL_AC7A;
				case 1159:
					goto IL_9026;
				case 1160:
					goto IL_4439;
				case 1161:
					goto IL_B0F7;
				case 1162:
					goto IL_82E6;
				case 1163:
					goto IL_62F6;
				case 1164:
					goto IL_3C97;
				case 1165:
					goto IL_8EBF;
				case 1166:
					goto IL_4703;
				case 1167:
					goto IL_738E;
				case 1168:
					goto IL_A220;
				case 1169:
					goto IL_2F1D;
				case 1170:
					goto IL_85A7;
				case 1171:
					goto IL_2464;
				case 1172:
					goto IL_5ABB;
				case 1173:
					goto IL_2511;
				case 1174:
					goto IL_83F2;
				case 1175:
					goto IL_AC0B;
				case 1176:
					goto IL_9271;
				case 1177:
					goto IL_5AFC;
				case 1178:
					goto IL_ADD4;
				case 1179:
					goto IL_55C5;
				case 1180:
					goto IL_1FFE;
				case 1181:
					goto IL_8250;
				case 1182:
					goto IL_6EC0;
				case 1183:
					goto IL_B2FB;
				case 1184:
					goto IL_6694;
				case 1185:
					goto IL_BE6E;
				case 1186:
					goto IL_4FDE;
				case 1187:
					goto IL_387C;
				case 1188:
					goto IL_55F6;
				case 1189:
					goto IL_A56A;
				case 1190:
					goto IL_5FEE;
				case 1191:
					goto IL_9783;
				case 1192:
					goto IL_3C28;
				case 1193:
					goto IL_4B5B;
				case 1194:
					goto IL_3ADE;
				case 1195:
					goto IL_2CAD;
				case 1196:
					goto IL_41D4;
				case 1197:
					goto IL_8CC9;
				case 1198:
					goto IL_4A5D;
				case 1199:
					goto IL_4FD1;
				case 1200:
					goto IL_835F;
				case 1201:
					goto IL_9AF7;
				case 1202:
					goto IL_9498;
				case 1203:
					goto IL_8E0C;
				case 1204:
					goto IL_5A0E;
				case 1205:
					goto IL_5E94;
				case 1206:
					goto IL_6008;
				case 1207:
					goto IL_2862;
				case 1208:
					goto IL_A08F;
				case 1209:
					goto IL_275D;
				case 1210:
					goto IL_A690;
				case 1211:
					goto IL_2C24;
				case 1212:
					goto IL_9AB9;
				case 1213:
					goto IL_8BF8;
				case 1214:
					goto IL_A6DB;
				case 1215:
					goto IL_9A16;
				case 1216:
					goto IL_6B2B;
				case 1217:
					goto IL_828E;
				case 1218:
					goto IL_276A;
				case 1219:
					goto IL_4608;
				case 1220:
					goto IL_2824;
				case 1221:
					goto IL_4558;
				case 1222:
					goto IL_2355;
				case 1223:
					goto IL_B5D2;
				case 1224:
					goto IL_B47C;
				case 1225:
					goto IL_510A;
				case 1226:
					goto IL_43EE;
				case 1227:
					goto IL_9FA4;
				case 1228:
					goto IL_207A;
				case 1229:
					goto IL_6C82;
				case 1230:
					goto IL_5AE2;
				case 1231:
					goto IL_B18A;
				case 1232:
					goto IL_2E7D;
				case 1233:
					goto IL_6796;
				case 1234:
					goto IL_6E7F;
				case 1235:
					goto IL_23F5;
				case 1236:
					goto IL_435B;
				case 1237:
					goto IL_B7A8;
				case 1238:
					goto IL_BD52;
				case 1239:
					goto IL_AB06;
				case 1240:
					goto IL_76DB;
				case 1241:
					goto IL_4C56;
				case 1242:
					goto IL_75CC;
				case 1243:
					goto IL_9F73;
				case 1244:
					goto IL_38C7;
				case 1245:
					goto IL_33BE;
				case 1246:
					goto IL_9BD8;
				case 1247:
					goto IL_5B2D;
				case 1248:
					goto IL_6A20;
				case 1249:
					goto IL_4C3C;
				case 1250:
					goto IL_4D13;
				case 1251:
					goto IL_8C71;
				case 1252:
					goto IL_AA49;
				case 1253:
					goto IL_8AFD;
				case 1254:
					goto IL_8FE8;
				case 1255:
					goto IL_4368;
				case 1256:
					goto IL_472A;
				case 1257:
					goto IL_960C;
				case 1258:
					goto IL_9B80;
				case 1259:
					goto IL_6765;
				case 1260:
					goto IL_3CB1;
				case 1261:
					goto IL_4BC0;
				case 1262:
					goto IL_882C;
				case 1263:
					goto IL_A5E3;
				case 1264:
					goto IL_7234;
				case 1265:
					goto IL_4375;
				case 1266:
					goto IL_A251;
				case 1267:
					goto IL_BDFF;
				case 1268:
					goto IL_AC49;
				case 1269:
					goto IL_6460;
				case 1270:
					goto IL_3E49;
				case 1271:
					goto IL_2613;
				case 1272:
					goto IL_A4D1;
				case 1273:
					goto IL_3E3C;
				case 1274:
					goto IL_991E;
				case 1275:
					goto IL_AD1A;
				case 1276:
					goto IL_5067;
				case 1277:
					goto IL_6291;
				case 1278:
					goto IL_6CA6;
				case 1279:
					goto IL_3665;
				case 1280:
					goto IL_B0AF;
				case 1281:
					goto IL_478C;
				case 1282:
					goto IL_A3AB;
				case 1283:
					goto IL_30AB;
				case 1284:
					goto IL_B5AB;
				case 1285:
					goto IL_88D2;
				case 1286:
					goto IL_6805;
				case 1287:
					goto IL_3C1B;
				case 1288:
					goto IL_56EB;
				case 1289:
					goto IL_5CA7;
				case 1290:
					goto IL_6FC8;
				case 1291:
					goto IL_6C13;
				case 1292:
					goto IL_3D13;
				case 1293:
					goto IL_B206;
				case 1294:
					goto IL_617C;
				case 1295:
					goto IL_BAD5;
				case 1296:
					goto IL_A614;
				case 1297:
					goto IL_BCFD;
				case 1298:
					goto IL_A80E;
				case 1299:
					goto IL_4077;
				case 1300:
					goto IL_A15C;
				case 1301:
					goto IL_8121;
				case 1302:
					goto IL_335C;
				case 1303:
					goto IL_B71F;
				case 1304:
					goto IL_851B;
				case 1305:
					goto IL_BCE3;
				case 1306:
					goto IL_B79B;
				case 1307:
					goto IL_29E3;
				case 1308:
					goto IL_A8B8;
				case 1309:
					goto IL_2886;
				case 1310:
					goto IL_97B4;
				case 1311:
					goto IL_553C;
				case 1312:
					goto IL_471D;
				case 1313:
					goto IL_81C4;
				case 1314:
					goto IL_6D3C;
				case 1315:
					goto IL_8724;
				case 1316:
					goto IL_9DCB;
				case 1317:
					goto IL_8F31;
				case 1318:
					goto IL_8419;
				case 1319:
					goto IL_50A5;
				case 1320:
					goto IL_9E6B;
				case 1321:
					goto IL_B82E;
				case 1322:
					goto IL_5380;
				case 1323:
					goto IL_7F93;
				case 1324:
					goto IL_429B;
				case 1325:
					goto IL_8D07;
				case 1326:
					goto IL_8C1C;
				case 1327:
					goto IL_9F66;
				case 1328:
					goto IL_532B;
				case 1329:
					goto IL_2196;
				case 1330:
					goto IL_6D2F;
				case 1331:
					goto IL_35A8;
				case 1332:
					goto IL_29FD;
				case 1333:
					goto IL_B9A2;
				case 1334:
					goto IL_2606;
				case 1335:
					goto IL_3546;
				case 1336:
					goto IL_77F7;
				case 1337:
					goto IL_2A72;
				case 1338:
					goto IL_8846;
				case 1339:
					goto IL_4165;
				case 1340:
					goto IL_52A2;
				case 1341:
					goto IL_28C7;
				case 1342:
					goto IL_3A1A;
				case 1343:
					goto IL_5FA6;
				case 1344:
					goto IL_8E98;
				case 1345:
					goto IL_A6CE;
				case 1346:
					goto IL_B384;
				case 1347:
					goto IL_283E;
				case 1348:
					goto IL_6D9E;
				case 1349:
					goto IL_84EA;
				case 1350:
					goto IL_606D;
				case 1351:
					goto IL_6F0B;
				case 1352:
					goto IL_7BB3;
				case 1353:
					goto IL_8C98;
				case 1354:
					goto IL_25F9;
				case 1355:
					goto IL_2E97;
				case 1356:
					goto IL_6CF1;
				case 1357:
					goto IL_7804;
				case 1358:
					goto IL_9885;
				case 1359:
					goto IL_B142;
				case 1360:
					goto IL_6544;
				case 1361:
					goto IL_9E09;
				case 1362:
					goto IL_27A8;
				case 1363:
					goto IL_AEF3;
				case 1364:
					goto IL_858D;
				case 1365:
					goto IL_3CEF;
				case 1366:
					goto IL_86C9;
				case 1367:
					goto IL_4799;
				case 1368:
					goto IL_5033;
				case 1369:
					goto IL_7258;
				case 1370:
					goto IL_7CDC;
				case 1371:
					goto IL_5307;
				case 1372:
					goto IL_4684;
				case 1373:
					goto IL_B80A;
				case 1374:
					goto IL_8D79;
				case 1375:
					goto IL_4AF6;
				case 1376:
					goto IL_45FB;
				case 1377:
					goto IL_BD2E;
				case 1378:
					goto IL_773D;
				case 1379:
					goto IL_63CA;
				case 1380:
					goto IL_2817;
				case 1381:
					goto IL_9F4C;
				case 1382:
					goto IL_7505;
				case 1383:
					goto IL_7FAD;
				case 1384:
					goto IL_AEB5;
				case 1385:
					goto IL_294D;
				case 1386:
					goto IL_58DB;
				case 1387:
					goto IL_7DCA;
				case 1388:
					goto IL_9E78;
				case 1389:
					goto IL_847B;
				case 1390:
					goto IL_58F5;
				case 1391:
					goto IL_7A25;
				case 1392:
					goto IL_8CFA;
				case 1393:
					goto IL_BE3D;
				case 1394:
					goto IL_B52F;
				case 1395:
					goto IL_2893;
				case 1396:
					goto IL_B971;
				case 1397:
					goto IL_93D1;
				case 1398:
					goto IL_7A32;
				case 1399:
					goto IL_B2CA;
				case 1400:
					goto IL_360D;
				case 1401:
					goto IL_8C40;
				case 1402:
					goto IL_7493;
				case 1403:
					goto IL_6ADD;
				case 1404:
					goto IL_3F7F;
				case 1405:
					goto IL_593D;
				case 1406:
					goto IL_2032;
				case 1407:
					goto IL_50CC;
				case 1408:
					goto IL_894E;
				case 1409:
					goto IL_92B9;
				case 1410:
					goto IL_4046;
				case 1411:
					goto IL_5774;
				case 1412:
					goto IL_8081;
				case 1413:
					goto IL_3DE7;
				case 1414:
					goto IL_5821;
				case 1415:
					goto IL_6453;
				case 1416:
					goto IL_441F;
				case 1417:
					goto IL_8BDE;
				case 1418:
					goto IL_2FDA;
				case 1419:
					goto IL_6F3F;
				case 1420:
					goto IL_9D21;
				case 1421:
					goto IL_342D;
				case 1422:
					goto IL_49C7;
				case 1423:
					goto IL_801C;
				case 1424:
					goto IL_4E49;
				case 1425:
					goto IL_5CDB;
				case 1426:
					goto IL_A8F9;
				case 1427:
					goto IL_939D;
				case 1428:
					goto IL_4CAE;
				case 1429:
					goto IL_6253;
				case 1430:
					goto IL_74BA;
				case 1431:
					goto IL_6663;
				case 1432:
					goto IL_76F5;
				case 1433:
					goto IL_5454;
				case 1434:
					goto IL_1FF1;
				case 1435:
					goto IL_A051;
				case 1436:
					goto IL_717A;
				case 1437:
					goto IL_BAA4;
				case 1438:
					goto IL_2ED5;
				case 1439:
					goto IL_35F3;
				case 1440:
					goto IL_77AC;
				case 1441:
					goto IL_7A70;
				case 1442:
					goto IL_2D19;
				case 1443:
					goto IL_4091;
				case 1444:
					goto IL_AAE2;
				case 1445:
					goto IL_450A;
				case 1446:
					goto IL_8812;
				case 1447:
					goto IL_6E8C;
				case 1448:
					goto IL_915F;
				case 1449:
					goto IL_72A3;
				case 1450:
					goto IL_6DB8;
				case 1451:
					goto IL_516C;
				case 1452:
					goto IL_4F0D;
				case 1453:
					goto IL_65F1;
				case 1454:
					goto IL_876F;
				case 1455:
					goto IL_27C2;
				case 1456:
					goto IL_475B;
				case 1457:
					goto IL_9EAC;
				case 1458:
					goto IL_912B;
				case 1459:
					goto IL_8DB7;
				case 1460:
					goto IL_9F59;
				case 1461:
					goto IL_7D82;
				case 1462:
					goto IL_8DC4;
				case 1463:
					goto IL_A6C1;
				case 1464:
					goto IL_B549;
				case 1465:
					goto IL_3D3A;
				case 1466:
					goto IL_6867;
				case 1467:
					goto IL_2651;
				case 1468:
					goto IL_7693;
				case 1469:
					goto IL_5FFB;
				case 1470:
					goto IL_8EB2;
				case 1471:
					goto IL_41E1;
				case 1472:
					goto IL_2FCD;
				case 1473:
					goto IL_76B7;
				case 1474:
					goto IL_2BE6;
				case 1475:
					goto IL_3233;
				case 1476:
					goto IL_82CC;
				case 1477:
					goto IL_955C;
				case 1478:
					goto IL_6E41;
				case 1479:
					goto IL_2DEA;
				case 1480:
					goto IL_4277;
				case 1481:
					goto IL_4DDA;
				case 1482:
					goto IL_BD83;
				case 1483:
					goto IL_9F32;
				case 1484:
					goto IL_86D6;
				case 1485:
					goto IL_6E5B;
				case 1486:
					goto IL_B166;
				case 1487:
					goto IL_5C4F;
				case 1488:
					goto IL_92ED;
				case 1489:
					goto IL_515F;
				case 1490:
					goto IL_4F3E;
				case 1491:
					goto IL_48E6;
				case 1492:
					goto IL_8906;
				case 1493:
					goto IL_2F68;
				case 1494:
					goto IL_71B8;
				case 1495:
					goto IL_5461;
				case 1496:
					goto IL_86BC;
				case 1497:
					goto IL_A6E8;
				case 1498:
					goto IL_5B78;
				case 1499:
					goto IL_63B0;
				case 1500:
					goto IL_8E7E;
				case 1501:
					goto IL_3240;
				case 1502:
					goto IL_7D27;
				case 1503:
					goto IL_A020;
				case 1504:
					goto IL_69FC;
				case 1505:
					goto IL_7B65;
				case 1506:
					goto IL_226A;
				case 1507:
					goto IL_391F;
				case 1508:
					goto IL_442C;
				case 1509:
					goto IL_48C2;
				case 1510:
					goto IL_B933;
				case 1511:
					goto IL_8212;
				case 1512:
					goto IL_634B;
				case 1513:
					goto IL_4993;
				case 1514:
					goto IL_6758;
				case 1515:
					goto IL_844A;
				case 1516:
					goto IL_8BA0;
				case 1517:
					goto IL_2AEE;
				case 1518:
					goto IL_905A;
				case 1519:
					goto IL_8D2E;
				case 1520:
					goto IL_B9AF;
				case 1521:
					goto IL_6494;
				case 1522:
					goto IL_967B;
				case 1523:
					goto IL_6829;
				case 1524:
					goto IL_A730;
				case 1525:
					goto IL_A0CD;
				case 1526:
					goto IL_237C;
				case 1527:
					goto IL_9BA4;
				case 1528:
					goto IL_B019;
				case 1529:
					goto IL_36EE;
				case 1530:
					goto IL_A74A;
				case 1531:
					goto IL_3186;
				case 1532:
					goto IL_9C8B;
				case 1533:
					goto IL_8F24;
				case 1534:
					goto IL_B27F;
				case 1535:
					goto IL_5A7D;
				case 1536:
					goto IL_6A78;
				case 1537:
					goto IL_A18D;
				case 1538:
					goto IL_BE4A;
				case 1539:
					goto IL_2457;
				case 1540:
					goto IL_A50F;
				case 1541:
					goto IL_9C0C;
				case 1542:
					goto IL_3BAC;
				case 1543:
					goto IL_4327;
				case 1544:
					goto IL_74F8;
				case 1545:
					goto IL_6710;
				case 1546:
					goto IL_31D1;
				case 1547:
					goto IL_65FE;
				case 1548:
					goto IL_70F1;
				case 1549:
					goto IL_364B;
				case 1550:
					goto IL_5E18;
				case 1551:
					goto IL_378E;
				case 1552:
					goto IL_3991;
				case 1553:
					goto IL_83E5;
				case 1554:
					goto IL_45B0;
				case 1555:
					goto IL_421F;
				case 1556:
					goto IL_B8AA;
				case 1557:
					goto IL_B44B;
				case 1558:
					goto IL_A652;
				case 1559:
					goto IL_8C8B;
				case 1560:
					goto IL_B641;
				case 1561:
					goto IL_67A3;
				case 1562:
					goto IL_58CE;
				case 1563:
					goto IL_94FA;
				case 1564:
					goto IL_59B9;
				case 1565:
					goto IL_8E26;
				case 1566:
					goto IL_75FD;
				case 1567:
					goto IL_3BDD;
				case 1568:
					goto IL_68FA;
				case 1569:
					goto IL_2D71;
				case 1570:
					goto IL_BA4F;
				case 1571:
					goto IL_71C5;
				case 1572:
					goto IL_A683;
				case 1573:
					goto IL_585F;
				case 1574:
					goto IL_A05E;
				case 1575:
					goto IL_3478;
				case 1576:
					goto IL_5179;
				case 1577:
					goto IL_74AD;
				case 1578:
					goto IL_85F2;
				case 1579:
					goto IL_A101;
				case 1580:
					goto IL_2750;
				case 1581:
					goto IL_4FEB;
				case 1582:
					goto IL_9D9A;
				case 1583:
					goto IL_60F3;
				case 1584:
					goto IL_AB2D;
				case 1585:
					goto IL_777B;
				case 1586:
					goto IL_482C;
				case 1587:
					goto IL_AB5E;
				case 1588:
					goto IL_2784;
				case 1589:
					goto IL_2317;
				case 1590:
					goto IL_4AB8;
				case 1591:
					goto IL_81B7;
				case 1592:
					goto IL_4846;
				case 1593:
					goto IL_251E;
				case 1594:
					goto IL_921C;
				case 1595:
					goto IL_359B;
				case 1596:
					goto IL_87D4;
				case 1597:
					goto IL_BCC9;
				case 1598:
					goto IL_45BD;
				case 1599:
					goto IL_7E77;
				case 1600:
					goto IL_4737;
				case 1601:
					goto IL_2D40;
				case 1602:
					goto IL_29F0;
				case 1603:
					goto IL_2FA6;
				case 1604:
					goto IL_8243;
				case 1605:
					goto IL_30DC;
				case 1606:
					goto IL_3100;
				case 1607:
					goto IL_B2EE;
				case 1608:
					goto IL_54B6;
				case 1609:
					goto IL_81EB;
				case 1610:
					goto IL_7D41;
				case 1611:
					goto IL_3C42;
				case 1612:
					goto IL_8DE8;
				case 1613:
					goto IL_9711;
				case 1614:
					goto IL_9904;
				case 1615:
					goto IL_2FE7;
				case 1616:
					goto IL_6582;
				case 1617:
					goto IL_5DF4;
				case 1618:
					goto IL_B1AE;
				case 1619:
					goto IL_6446;
				case 1620:
					goto IL_AB8F;
				case 1621:
					goto IL_3018;
				case 1622:
					goto IL_567C;
				case 1623:
					goto IL_3E56;
				case 1624:
					goto IL_32AF;
				case 1625:
					goto IL_3912;
				case 1626:
					goto IL_B9ED;
				case 1627:
					goto IL_7BA6;
				case 1628:
					goto IL_A360;
				case 1629:
					goto IL_5B54;
				case 1630:
					goto IL_7C39;
				case 1631:
					goto IL_6E27;
				case 1632:
					goto IL_4C7D;
				case 1633:
					goto IL_9911;
				case 1634:
					goto IL_860C;
				case 1635:
					goto IL_73C2;
				case 1636:
					goto IL_40CF;
				case 1637:
					goto IL_2E1B;
				case 1638:
					goto IL_2158;
				case 1639:
					goto IL_B3CF;
				case 1640:
					goto IL_493B;
				case 1641:
					goto IL_A7D0;
				case 1642:
					goto IL_5D85;
				case 1643:
					goto IL_3A0D;
				case 1644:
					goto IL_6DAB;
				case 1645:
					goto IL_3342;
				case 1646:
					goto IL_782B;
				case 1647:
					goto IL_ABE7;
				case 1648:
					goto IL_5430;
				case 1649:
					goto IL_9E85;
				case 1650:
					goto IL_2C0A;
				case 1651:
					goto IL_2018;
				case 1652:
					goto IL_5EC5;
				case 1653:
					goto IL_8426;
				case 1654:
					goto IL_3C73;
				case 1655:
					goto IL_947E;
				case 1656:
					goto IL_6F63;
				case 1657:
					goto IL_469E;
				case 1658:
					goto IL_2831;
				case 1659:
					goto IL_AF24;
				case 1660:
					goto IL_3380;
				case 1661:
					goto IL_2CA0;
				case 1662:
					goto IL_98B9;
				case 1663:
					goto IL_9CB2;
				case 1664:
					goto IL_3D85;
				case 1665:
					goto IL_B76A;
				case 1666:
					goto IL_B587;
				case 1667:
					goto IL_5C5C;
				case 1668:
					goto IL_236F;
				case 1669:
					goto IL_4D3A;
				case 1670:
					goto IL_5040;
				case 1671:
					goto IL_4F1A;
				case 1672:
					goto IL_9823;
				case 1673:
					goto IL_21D4;
				case 1674:
					goto IL_2A3E;
				case 1675:
					goto IL_63BD;
				case 1676:
					goto IL_61F8;
				case 1677:
					goto IL_609E;
				case 1678:
					goto IL_5A97;
				case 1679:
					goto IL_6AEA;
				case 1680:
					goto IL_966E;
				case 1681:
					goto IL_B957;
				case 1682:
					goto IL_B3E9;
				case 1683:
					goto IL_77B9;
				case 1684:
					goto IL_5A28;
				case 1685:
					goto IL_42E6;
				case 1686:
					goto IL_740D;
				case 1687:
					goto IL_BBA3;
				case 1688:
					goto IL_9E9F;
				case 1689:
					goto IL_2389;
				case 1690:
					goto IL_6BBE;
				case 1691:
					goto IL_9C4D;
				case 1692:
					goto IL_92FA;
				case 1693:
					goto IL_3889;
				case 1694:
					goto IL_589D;
				case 1695:
					goto IL_99F2;
				case 1696:
					goto IL_49FB;
				case 1697:
					goto IL_28A0;
				case 1698:
					goto IL_8067;
				case 1699:
					goto IL_58E8;
				case 1700:
					goto IL_8190;
				case 1701:
					goto IL_8E33;
				case 1702:
					goto IL_90A5;
				case 1703:
					goto IL_BAE2;
				case 1704:
					goto IL_4AAB;
				case 1705:
					goto IL_A213;
				case 1706:
					goto IL_B46F;
				case 1707:
					goto IL_47BD;
				case 1708:
					goto IL_AA18;
				case 1709:
					goto IL_9F3F;
				case 1710:
					goto IL_B071;
				case 1711:
					goto IL_9BCB;
				case 1712:
					goto IL_B1F9;
				case 1713:
					goto IL_5F1D;
				case 1714:
					goto IL_487A;
				case 1715:
					goto IL_6506;
				case 1716:
					goto IL_B2BD;
				case 1717:
					goto IL_5740;
				case 1718:
					goto IL_948B;
				case 1719:
					goto IL_A951;
				case 1720:
					goto IL_B0D3;
				case 1721:
					goto IL_99A7;
				case 1722:
					goto IL_A81B;
				case 1723:
					goto IL_6060;
				case 1724:
					goto IL_BA73;
				case 1725:
					goto IL_8EF0;
				case 1726:
					goto IL_7F48;
				case 1727:
					goto IL_9D76;
				case 1728:
					goto IL_863D;
				case 1729:
					goto IL_564B;
				case 1730:
					goto IL_8535;
				case 1731:
					goto IL_5BF1;
				case 1732:
					goto IL_4172;
				case 1733:
					goto IL_5919;
				case 1734:
					goto IL_46C5;
				case 1735:
					goto IL_B4C7;
				case 1736:
					goto IL_7B7F;
				case 1737:
					goto IL_6A2D;
				case 1738:
					goto IL_9583;
				case 1739:
					goto IL_2284;
				case 1740:
					goto IL_73B5;
				case 1741:
					goto IL_5DDA;
				case 1742:
					goto IL_457F;
				case 1743:
					goto IL_4C2F;
				case 1744:
					goto IL_95DB;
				case 1745:
					goto IL_23AD;
				case 1746:
					goto IL_B3C2;
				case 1747:
					goto IL_93AA;
				case 1748:
					goto IL_8F3E;
				case 1749:
					goto IL_41C7;
				case 1750:
					goto IL_8619;
				case 1751:
					goto IL_AFE8;
				case 1752:
					goto IL_5587;
				case 1753:
					goto IL_33A4;
				case 1754:
					goto IL_813B;
				case 1755:
					goto IL_3D6B;
				case 1756:
					goto IL_93EB;
				case 1757:
					goto IL_78C1;
				case 1758:
					goto IL_776E;
				case 1759:
					goto IL_8789;
				case 1760:
					goto IL_B43E;
				case 1761:
					goto IL_53CB;
				case 1762:
					goto IL_56BA;
				case 1763:
					goto IL_53E5;
				case 1764:
					goto IL_2A17;
				case 1765:
					goto IL_5098;
				case 1766:
					goto IL_631A;
				case 1767:
					goto IL_4C70;
				case 1768:
					goto IL_368C;
				case 1769:
					goto IL_2094;
				case 1770:
					goto IL_95A7;
				case 1771:
					goto IL_6389;
				case 1772:
					goto IL_7F3B;
				case 1773:
					goto IL_B4D4;
				case 1774:
					goto IL_6B76;
				case 1775:
					goto IL_72E1;
				case 1776:
					goto IL_5423;
				case 1777:
					goto IL_5C28;
				case 1778:
					goto IL_3B4A;
				case 1779:
					goto IL_5AD5;
				case 1780:
					goto IL_2C4B;
				case 1781:
					goto IL_A41A;
				case 1782:
					goto IL_6358;
				case 1783:
					goto IL_AC18;
				case 1784:
					goto IL_4AC5;
				case 1785:
					goto IL_7C08;
				case 1786:
					goto IL_7187;
				case 1787:
					goto IL_3DC3;
				case 1788:
					goto IL_6131;
				case 1789:
					goto IL_85C1;
				case 1790:
					goto IL_7811;
				case 1791:
					goto IL_812E;
				case 1792:
					goto IL_6CB3;
				case 1793:
					goto IL_BE19;
				case 1794:
					goto IL_52C9;
				case 1795:
					goto IL_9BF2;
				case 1796:
					goto IL_24D3;
				case 1797:
					goto IL_5EDF;
				case 1798:
					goto IL_2B74;
				case 1799:
					goto IL_5EF9;
				case 1800:
					goto IL_6551;
				case 1801:
					goto IL_4BB3;
				case 1802:
					goto IL_629E;
				case 1803:
					goto IL_A32F;
				case 1804:
					goto IL_9DE5;
				case 1805:
					goto IL_6FD5;
				case 1806:
					goto IL_A8C5;
				case 1807:
					goto IL_53D8;
				case 1808:
					goto IL_5233;
				case 1809:
					goto IL_70B3;
				case 1810:
					goto IL_87A3;
				case 1811:
					goto IL_7BC0;
				case 1812:
					goto IL_AD93;
				case 1813:
					goto IL_932B;
				case 1814:
					goto IL_6EE4;
				case 1815:
					goto IL_28EB;
				case 1816:
					goto IL_67BD;
				case 1817:
					goto IL_7A4C;
				case 1818:
					goto IL_A3CF;
				case 1819:
					goto IL_9FE2;
				case 1820:
					goto IL_214B;
				case 1821:
					goto IL_A400;
				case 1822:
					goto IL_22D9;
				case 1823:
					goto IL_B9FA;
				case 1824:
					goto IL_7EF0;
				case 1825:
					goto IL_9390;
				case 1826:
					goto IL_8D14;
				case 1827:
					goto IL_646D;
				case 1828:
					goto IL_A5F0;
				case 1829:
					goto IL_91C7;
				case 1830:
					goto IL_2A96;
				case 1831:
					goto IL_9C40;
				case 1832:
					goto IL_2AE1;
				case 1833:
					goto IL_4005;
				case 1834:
					goto IL_2E59;
				case 1835:
					goto IL_2056;
				case 1836:
					goto IL_9264;
				case 1837:
					goto IL_7512;
				case 1838:
					goto IL_81F8;
				case 1839:
					goto IL_622C;
				case 1840:
					goto IL_AE77;
				case 1841:
					goto IL_5074;
				case 1842:
					goto IL_846E;
				case 1843:
					goto IL_4B2A;
				case 1844:
					goto IL_B919;
				case 1845:
					goto IL_2AA3;
				case 1846:
					goto IL_4BE7;
				case 1847:
					goto IL_BB7F;
				case 1848:
					goto IL_4B68;
				case 1849:
					goto IL_3848;
				case 1850:
					goto IL_42D9;
				case 1851:
					goto IL_83D8;
				case 1852:
					goto IL_458C;
				case 1853:
					goto IL_5A4C;
				case 1854:
					goto IL_69EF;
				case 1855:
					goto IL_5AC8;
				case 1856:
					goto IL_AB13;
				case 1857:
					goto IL_4DE7;
				case 1858:
					goto IL_7B03;
				case 1859:
					goto IL_AF00;
				case 1860:
					goto IL_4BDA;
				case 1861:
					goto IL_7F79;
				case 1862:
					goto IL_3CE2;
				case 1863:
					goto IL_741A;
				case 1864:
					goto IL_46DF;
				case 1865:
					goto IL_5D61;
				case 1866:
					goto IL_BC36;
				case 1867:
					goto IL_B522;
				case 1868:
					goto IL_86A2;
				case 1869:
					goto IL_7336;
				case 1870:
					goto IL_38EE;
				case 1871:
					goto IL_945A;
				case 1872:
					goto IL_81DE;
				case 1873:
					goto IL_B1DF;
				case 1874:
					goto IL_8ABF;
				case 1875:
					goto IL_8805;
				case 1876:
					goto IL_3B57;
				case 1877:
					goto IL_BB4E;
				case 1878:
					goto IL_7EFD;
				case 1879:
					goto IL_5409;
				case 1880:
					goto IL_62DC;
				case 1881:
					goto IL_73A8;
				case 1882:
					goto IL_5594;
				case 1883:
					goto IL_83B4;
				case 1884:
					goto IL_7FEB;
				case 1885:
					goto IL_90C9;
				case 1886:
					goto IL_6DE9;
				case 1887:
					goto IL_2FB3;
				case 1888:
					goto IL_9976;
				case 1889:
					goto IL_A2FE;
				case 1890:
					goto IL_6F25;
				case 1891:
					goto IL_6907;
				case 1892:
					goto IL_6F70;
				case 1893:
					goto IL_5C42;
				case 1894:
					goto IL_B496;
				case 1895:
					goto IL_5879;
				case 1896:
					goto IL_B57A;
				case 1897:
					goto IL_6A92;
				case 1898:
					goto IL_4C63;
				case 1899:
					goto IL_8E8B;
				case 1900:
					goto IL_AC25;
				case 1901:
					goto IL_34CD;
				case 1902:
					goto IL_6C75;
				case 1903:
					goto IL_88EC;
				case 1904:
					goto IL_B610;
				case 1905:
					goto IL_6A9F;
				case 1906:
					goto IL_463C;
				case 1907:
					goto IL_2C6F;
				case 1908:
					goto IL_5CB4;
				case 1909:
					goto IL_6212;
				case 1910:
					goto IL_4246;
				case 1911:
					goto IL_73F3;
				case 1912:
					goto IL_4B75;
				case 1913:
					goto IL_9295;
				case 1914:
					goto IL_4986;
				case 1915:
					goto IL_453E;
				case 1916:
					goto IL_3219;
				case 1917:
					goto IL_93B7;
				case 1918:
					goto IL_43A6;
				case 1919:
					goto IL_39E9;
				case 1920:
					goto IL_4100;
				case 1921:
					goto IL_B22A;
				case 1922:
					goto IL_5F8C;
				case 1923:
					goto IL_386F;
				case 1924:
					goto IL_5D30;
				case 1925:
					goto IL_9107;
				case 1926:
					goto IL_5CC1;
				case 1927:
					goto IL_5767;
				case 1928:
					goto IL_2A4B;
				case 1929:
					goto IL_70FE;
				case 1930:
					goto IL_6C20;
				case 1931:
					goto IL_396D;
				case 1932:
					goto IL_8F0A;
				case 1933:
					goto IL_4691;
				case 1934:
					goto IL_59DD;
				case 1935:
					goto IL_9040;
				case 1936:
					goto IL_9074;
				case 1937:
					goto IL_9AD3;
				case 1938:
					goto IL_7985;
				case 1939:
					goto IL_9BBE;
				case 1940:
					goto IL_91AD;
				case 1941:
					goto IL_A975;
				case 1942:
					goto IL_7305;
				case 1943:
					goto IL_7838;
				case 1944:
					goto IL_B1D2;
				case 1945:
					goto IL_7D4E;
				case 1946:
					goto IL_62E9;
				case 1947:
					goto IL_7CCF;
				case 1948:
					goto IL_8AD9;
				case 1949:
					goto IL_60CF;
				case 1950:
					goto IL_B104;
				case 1951:
					goto IL_9C19;
				case 1952:
					goto IL_8A39;
				case 1953:
					goto IL_3939;
				case 1954:
					goto IL_BA80;
				case 1955:
					goto IL_3BF7;
				case 1956:
					goto IL_4A2C;
				case 1957:
					goto IL_3B9F;
				case 1958:
					goto IL_7051;
				case 1959:
					goto IL_AE50;
				case 1960:
					goto IL_446A;
				case 1961:
					goto IL_6772;
				case 1962:
					goto IL_BB41;
				case 1963:
					goto IL_5852;
				case 1964:
					goto IL_42F3;
				case 1965:
					goto IL_5E49;
				case 1966:
					goto IL_ADAD;
				case 1967:
					goto IL_5EA1;
				case 1968:
					goto IL_4EDC;
				case 1969:
					goto IL_20B8;
				case 1970:
					goto IL_9DBE;
				case 1971:
					goto IL_4012;
				case 1972:
					goto IL_2DB9;
				case 1973:
					goto IL_313E;
				case 1974:
					goto IL_ACE9;
				case 1975:
					goto IL_4839;
				case 1976:
					goto IL_739B;
				case 1977:
					goto IL_78F2;
				case 1978:
					goto IL_2FC0;
				case 1979:
					goto IL_552F;
				case 1980:
					goto IL_A1EF;
				case 1981:
					goto IL_A489;
				case 1982:
					goto IL_616F;
				case 1983:
					goto IL_9A23;
				case 1984:
					goto IL_3781;
				case 1985:
					goto IL_3EF3;
				case 1986:
					goto IL_A36D;
				case 1987:
					goto IL_8F7C;
				case 1988:
					goto IL_975C;
				case 1989:
					goto IL_904D;
				case 1990:
					goto IL_A51C;
				case 1991:
					goto IL_4531;
				case 1992:
					goto IL_448E;
				case 1993:
					goto IL_4FAD;
				case 1994:
					goto IL_46D2;
				case 1995:
					goto IL_6945;
				case 1996:
					goto IL_6874;
				case 1997:
					goto IL_7880;
				case 1998:
					goto IL_3409;
				case 1999:
					goto IL_9B4F;
				case 2000:
					goto IL_6E1A;
				case 2001:
					goto IL_944D;
				case 2002:
					goto IL_8114;
				case 2003:
					goto IL_7B99;
				case 2004:
					goto IL_2E28;
				case 2005:
					goto IL_B61D;
				case 2006:
					goto IL_8488;
				case 2007:
					goto IL_64F9;
				case 2008:
					goto IL_29A2;
				case 2009:
					goto IL_334F;
				case 2010:
					goto IL_430D;
				case 2011:
					goto IL_6BE2;
				case 2012:
					goto IL_864A;
				case 2013:
					goto IL_7A01;
				case 2014:
					goto IL_BD9D;
				case 2015:
					goto IL_71AB;
				case 2016:
					goto IL_2F41;
				case 2017:
					goto IL_9CBF;
				case 2018:
					goto IL_ABCD;
				case 2019:
					goto IL_3BB9;
				case 2020:
					goto IL_43CA;
				case 2021:
					goto IL_4CC8;
				case 2022:
					goto IL_9098;
				case 2023:
					goto IL_64B8;
				default:
					num = (short)63569920;
					num2 = (int)((global::System.IntPtr)num);
					break;
				}
			}
			IL_1FF1:
			this.CpyBtnRadWideBluetoothBluetoothPairingType_A37036 = (global::AcpUI.AcpCopyButton)target;
			return;
			IL_1FFE:
			this.RadWideTPSFiregroundPeriodicUpdateTimer_A33467Comp = (global::AcpUI.AcpLabel)target;
			return;
			IL_200B:
			this.ExpanderRadioWideFeatures = (global::AcpUI.AcpExpander)target;
			return;
			IL_2018:
			this.RadWideLabtoolReadWriteVoiceFiles_A8893Comp = (global::AcpUI.AcpCheckBox)target;
			return;
			IL_2025:
			this.CpyBtnRadWideUserInformationandPINPassword_41303 = (global::AcpUI.AcpCopyButton)target;
			return;
			IL_2032:
			this.LblRadWideGunlockRelocktimerTimer_A36522 = (global::AcpUI.AcpLabel)target;
			this.LblRadWideGunlockRelocktimerTimer_A36522.MouseDoubleClick += new global::System.Windows.Input.MouseButtonEventHandler(this.OnFieldNameDoubleClick);
			return;
			IL_2056:
			this.RadWideLabtoolUserSelectablePLEnhancement_43031 = (global::AcpUI.AcpLabel)target;
			this.RadWideLabtoolUserSelectablePLEnhancement_43031.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_207A:
			this.RadWideLabtoolRxBandSplitName_A24797Comp = (global::AcpUI.AcpLabel)target;
			return;
			IL_2087:
			this.CpyBtnRadWideFeaturesInactivityAutoPoweroff_A38013 = (global::AcpUI.AcpCopyButton)target;
			return;
			IL_2094:
			this.ManDownPersonalityConfigurableCapable_42082 = (global::AcpUI.AcpLabel)target;
			this.ManDownPersonalityConfigurableCapable_42082.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_20B8:
			this.RTDBtnRadWideLabtoolCertMgmtMotorolaSolutionsPKIPort = (global::AcpUI.AcpRtdButton)target;
			return;
			IL_20C5:
			this.RecNavToolbarExpanderRadioWideTxPowerLevelsByFrequencyRange = (global::AcpUI.AcpRecNavToolbar)target;
			this.RecNavToolbarExpanderRadioWideTxPowerLevelsByFrequencyRange.ModeClick += this.OnModeClick;
			return;
			IL_20E9:
			this.HLinkTPS = (global::System.Windows.Documents.Hyperlink)target;
			this.HLinkTPS.Click += this.HLinkClick;
			return;
			IL_210D:
			this.LblRadWideUserinfoPassRequiredForGunlock_A36531 = (global::AcpUI.AcpLabel)target;
			this.LblRadWideUserinfoPassRequiredForGunlock_A36531.MouseDoubleClick += new global::System.Windows.Input.MouseButtonEventHandler(this.OnFieldNameDoubleClick);
			return;
			IL_2131:
			this.CVBtnRadWideUserInformationandPasswordsProtectedZonePassword_A8766 = (global::AcpUI.AcpCustomViewCheckBox)target;
			return;
			IL_213E:
			this.RTDBtnRadWideTPSFiregroundEvacuationTone_A7980 = (global::AcpUI.AcpRtdButton)target;
			return;
			IL_214B:
			this.RadioWideDVRSTrunkingStatusCapability_A42772Comp = (global::AcpUI.AcpLabel)target;
			return;
			IL_2158:
			this.CpyBtnRadWideLabtoolDisplayContrastConfiguration_A7873 = (global::AcpUI.AcpCopyButton)target;
			return;
			IL_2165:
			this.CpyBtnRadWideLocP25LocationReporting_42412 = (global::AcpUI.AcpCopyButton)target;
			return;
			IL_2172:
			this.RadWideLocP25LocationReporting_42412 = (global::AcpUI.AcpCheckBox)target;
			this.RadWideLocP25LocationReporting_42412.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_2196:
			this.RadWideGenLightBarPatternRelay1_A36506 = (global::AcpUI.AcpComboBox)target;
			this.RadWideGenLightBarPatternRelay1_A36506.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_21BA:
			this.RTDBtnRadCfgVirtualPartnerMode = (global::AcpUI.AcpRtdButton)target;
			return;
			IL_21C7:
			this.RadWideFeaturesBlockPendingCAPC_A7564Comp = (global::AcpUI.AcpCheckBox)target;
			return;
			IL_21D4:
			this.RTDBtnRadWideLabtoolSirenAndLightsKeypadEnable_A41413 = (global::AcpUI.AcpRtdButton)target;
			return;
			IL_21E1:
			this.CpyBtnRadWideFeaturesTargetZoneOnOffHook_A42355 = (global::AcpUI.AcpCopyButton)target;
			return;
			IL_21EE:
			this.CVBtnRadWideAdvancedRecordAudio_A8922 = (global::AcpUI.AcpCustomViewCheckBox)target;
			return;
			IL_21FB:
			this.RadWideFeaturesDisableIgnitionAutoPowerOffAlert_A38015 = (global::AcpUI.AcpCheckBox)target;
			this.RadWideFeaturesDisableIgnitionAutoPowerOffAlert_A38015.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_221F:
			this.RadWideTransmitPowerLevelsTxPowerLevelHighW_A8152Comp = (global::AcpUI.AcpLabel)target;
			return;
			IL_222C:
			this.CVBtnRadWideAdvancedMaximumTxDeviation_A8480 = (global::AcpUI.AcpCustomViewCheckBox)target;
			return;
			IL_2239:
			this.CVBtnRadWideTxPowerLevelsNewBandPlan78MHzBandSelection_A41851 = (global::AcpUI.AcpCustomViewCheckBox)target;
			return;
			IL_2246:
			this.LblRadCfgVirtualPartnerInactivityTime = (global::AcpUI.AcpLabel)target;
			this.LblRadCfgVirtualPartnerInactivityTime.MouseDoubleClick += new global::System.Windows.Input.MouseButtonEventHandler(this.OnFieldNameDoubleClick);
			return;
			IL_226A:
			this.CpyBtnRadWideBluetoothBluetoothPANNetworkAddress_41983 = (global::AcpUI.AcpCopyButton)target;
			return;
			IL_2277:
			this.CVBtnRadWideDualRadioEmergencyRadio_A42239 = (global::AcpUI.AcpCustomViewCheckBox)target;
			return;
			IL_2284:
			this.RadWideLabtoolAudibleBeaconRoutingCapable_A41974 = (global::AcpUI.AcpLabel)target;
			this.RadWideLabtoolAudibleBeaconRoutingCapable_A41974.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_22A8:
			this.RadWideUserInformationandPasswordsMandatoryPassword_A8461 = (global::AcpUI.AcpCheckBox)target;
			this.RadWideUserInformationandPasswordsMandatoryPassword_A8461.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_22CC:
			this.RadWideRecentCallListDeleteEnableComp = (global::AcpUI.AcpCheckBox)target;
			return;
			IL_22D9:
			this.LblRadioWideMOSCADACE3000Capability_A42772 = (global::AcpUI.AcpLabel)target;
			this.LblRadioWideMOSCADACE3000Capability_A42772.MouseDoubleClick += new global::System.Windows.Input.MouseButtonEventHandler(this.OnFieldNameDoubleClick);
			return;
			IL_22FD:
			this.CpyBtnSwitchConventionalSwitchesPosition1_A12643 = (global::AcpUI.AcpCopyButton)target;
			return;
			IL_230A:
			this.RTDBtnRadWideUserInformationandPasswordsRadioAlias_A8829 = (global::AcpUI.AcpRtdButton)target;
			return;
			IL_2317:
			this.RTDBtnRadWideLabtoolKeypadType_A8372 = (global::AcpUI.AcpRtdButton)target;
			return;
			IL_2324:
			this.RadWideAlertTonesVolumeAdjustToneDisableComp = (global::AcpUI.AcpCheckBox)target;
			return;
			IL_2331:
			this.RadWideUserInformationandPasswordsProtectedZonePassword_A8766 = (global::AcpUI.AcpPasswordEyeBox)target;
			this.RadWideUserInformationandPasswordsProtectedZonePassword_A8766.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_2355:
			this.gridExpanderRadioWideRxFrequencySplitFPPSRecView = (global::System.Windows.Controls.Grid)target;
			return;
			IL_2362:
			this.RTDBtnRadWideConventionalDynamicIDWithPassword_A43705 = (global::AcpUI.AcpRtdButton)target;
			return;
			IL_236F:
			this.CpyBtnRadWideLabtoolSirenPaSystemLookup_A9143 = (global::AcpUI.AcpCopyButton)target;
			return;
			IL_237C:
			this.ExpanderRadioWideLTE = (global::AcpUI.AcpExpander)target;
			return;
			IL_2389:
			this.LblRadWideEmergencyRxTxAlertToneSet_A41508 = (global::AcpUI.AcpLabel)target;
			this.LblRadWideEmergencyRxTxAlertToneSet_A41508.MouseDoubleClick += new global::System.Windows.Input.MouseButtonEventHandler(this.OnFieldNameDoubleClick);
			return;
			IL_23AD:
			this.RadWideLabtoolAPX6000P25Radio_A42121 = (global::AcpUI.AcpLabel)target;
			this.RadWideLabtoolAPX6000P25Radio_A42121.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_23D1:
			this.RadWideUserInformationandPasswordsRadioLockRadioInhibitOnDeadlock_A3584 = (global::AcpUI.AcpCheckBox)target;
			this.RadWideUserInformationandPasswordsRadioLockRadioInhibitOnDeadlock_A3584.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_23F5:
			this.RadWideLabtoolRxEndFrequencySplit_A9015 = (global::AcpUI.AcpTextBox)target;
			this.RadWideLabtoolRxEndFrequencySplit_A9015.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_2419:
			this.CpyBtnRadWideFeaturesVirtualPartnerAudioPriority = (global::AcpUI.AcpCopyButton)target;
			return;
			IL_2426:
			this.RadWideTransmitPowerLevelsTrkTxPowerLevelLowW_A41860Comp = (global::AcpUI.AcpLabel)target;
			return;
			IL_2433:
			this.LblRadWideUserInformationandPasswordsRadioAliasEnable_A8830 = (global::AcpUI.AcpLabel)target;
			this.LblRadWideUserInformationandPasswordsRadioAliasEnable_A8830.MouseDoubleClick += new global::System.Windows.Input.MouseButtonEventHandler(this.OnFieldNameDoubleClick);
			return;
			IL_2457:
			this.RTDBtnAdvancedExternalMicOnly = (global::AcpUI.AcpRtdButton)target;
			return;
			IL_2464:
			this.CpyBtnRadWideTPSEmergencyPTTTransmission_A41544 = (global::AcpUI.AcpCopyButton)target;
			return;
			IL_2471:
			this.CVBtnGPSFailToneInterval_42329 = (global::AcpUI.AcpCustomViewCheckBox)target;
			return;
			IL_247E:
			this.RadWideDualRadioFixedRadioSwapMenu_A42241 = (global::AcpUI.AcpCheckBox)target;
			this.RadWideDualRadioFixedRadioSwapMenu_A42241.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_24A2:
			this.GPSFailToneInterval_42329 = (global::AcpUI.AcpTextBoxSpinner)target;
			this.GPSFailToneInterval_42329.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_24C6:
			this.CpyBtnRadWideTransmitPowerLevelsConvTxPowerLevelMinimumW_A41863 = (global::AcpUI.AcpCopyButton)target;
			return;
			IL_24D3:
			this.TPSCapable_A42312Comp = (global::AcpUI.AcpLabel)target;
			return;
			IL_24E0:
			this.AdvancedAuxTransmitSensitivity_A7530 = (global::AcpUI.AcpComboBox)target;
			this.AdvancedAuxTransmitSensitivity_A7530.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_2504:
			this.RTDBtnRadWideFeaturesMapping = (global::AcpUI.AcpRtdButton)target;
			return;
			IL_2511:
			this.ExpanderRadioWideFireground = (global::AcpUI.AcpExpander)target;
			return;
			IL_251E:
			this.LblRadWideLabtoolZoneSelectorOnSwitch_A19550 = (global::AcpUI.AcpLabel)target;
			this.LblRadWideLabtoolZoneSelectorOnSwitch_A19550.MouseDoubleClick += new global::System.Windows.Input.MouseButtonEventHandler(this.OnFieldNameDoubleClick);
			return;
			IL_2542:
			this.RTDBtnRadWideTPSAudibleEmergencyBeaconRouting_A41972 = (global::AcpUI.AcpRtdButton)target;
			return;
			IL_254F:
			this.LblRadWideAdvancedCyclicKeying_A7795 = (global::AcpUI.AcpLabel)target;
			this.LblRadWideAdvancedCyclicKeying_A7795.MouseDoubleClick += new global::System.Windows.Input.MouseButtonEventHandler(this.OnFieldNameDoubleClick);
			return;
			IL_2573:
			this.RadWideAlertTonesRSMVolumeSetTone = (global::AcpUI.AcpComboBox)target;
			this.RadWideAlertTonesRSMVolumeSetTone.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_2597:
			this.RTDBtnRadWideUserInformationandUserLoginUnitID_41306 = (global::AcpUI.AcpRtdButton)target;
			return;
			IL_25A4:
			this.RadWideGeneralDateFormat_A7802 = (global::AcpUI.AcpComboBox)target;
			this.RadWideGeneralDateFormat_A7802.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_25C8:
			this.LblRadWideUserInformationandPINPasswordPart2_41304 = (global::AcpUI.AcpLabel)target;
			this.LblRadWideUserInformationandPINPasswordPart2_41304.MouseDoubleClick += new global::System.Windows.Input.MouseButtonEventHandler(this.OnFieldNameDoubleClick);
			return;
			IL_25EC:
			this.RadWideFeatureAnalogWidebandDataComp = (global::AcpUI.AcpCheckBox)target;
			return;
			IL_25F9:
			this.CVBtnRadWideGenLightBarPatternRelay5_A36510 = (global::AcpUI.AcpCustomViewCheckBox)target;
			return;
			IL_2606:
			this.RadWideGenLightBarPatternRelay1_A36506Comp = (global::AcpUI.AcpLabel)target;
			return;
			IL_2613:
			this.RecNavToolbarExpanderRadioWideFCCNarrowBandingFrequencySplitTable = (global::AcpUI.AcpRecNavToolbar)target;
			this.RecNavToolbarExpanderRadioWideFCCNarrowBandingFrequencySplitTable.ModeClick += this.OnModeClick;
			return;
			IL_2637:
			this.CpyBtnRadWideFeaturesPowerManagementStandbyTime = (global::AcpUI.AcpCopyButton)target;
			return;
			IL_2644:
			this.RTDBtnRadWideTransmitPowerLevelsTxPowerLevelLowW_A8153 = (global::AcpUI.AcpRtdButton)target;
			return;
			IL_2651:
			this.LblRadWideBluetoothFriendlyNameEditable_A41182 = (global::AcpUI.AcpLabel)target;
			this.LblRadWideBluetoothFriendlyNameEditable_A41182.MouseDoubleClick += new global::System.Windows.Input.MouseButtonEventHandler(this.OnFieldNameDoubleClick);
			return;
			IL_2675:
			this.HLinkDigitalAudioOptions = (global::System.Windows.Documents.Hyperlink)target;
			this.HLinkDigitalAudioOptions.Click += this.HLinkClick;
			return;
			IL_2699:
			this.HLinkUserInformationAndPasswords = (global::System.Windows.Documents.Hyperlink)target;
			this.HLinkUserInformationAndPasswords.Click += this.HLinkClick;
			return;
			IL_26BD:
			this.RTDBtnRadWideTransmitPowerLevelsConvTxPowerLevelLowW_A41861 = (global::AcpUI.AcpRtdButton)target;
			return;
			IL_26CA:
			this.RadWideDigitalAudioOptionsWeakSignalFringe_A9679Comp = (global::AcpUI.AcpCheckBox)target;
			return;
			IL_26D7:
			this.RadWideLocationDistanceUnit_A13080Comp = (global::AcpUI.AcpLabel)target;
			return;
			IL_26E4:
			this.LblRadWideFeaturesPowerManagementStandbyTime = (global::AcpUI.AcpLabel)target;
			this.LblRadWideFeaturesPowerManagementStandbyTime.MouseDoubleClick += new global::System.Windows.Input.MouseButtonEventHandler(this.OnFieldNameDoubleClick);
			return;
			IL_2708:
			this.LblRadWideRxAudioControlMidrangeEqualization_A8508 = (global::AcpUI.AcpLabel)target;
			this.LblRadWideRxAudioControlMidrangeEqualization_A8508.MouseDoubleClick += new global::System.Windows.Input.MouseButtonEventHandler(this.OnFieldNameDoubleClick);
			return;
			IL_272C:
			this.LblRadWideUserInformationandUserLoginUnitIDTextSize_41309 = (global::AcpUI.AcpLabel)target;
			this.LblRadWideUserInformationandUserLoginUnitIDTextSize_41309.MouseDoubleClick += new global::System.Windows.Input.MouseButtonEventHandler(this.OnFieldNameDoubleClick);
			return;
			IL_2750:
			this.CVBtnRadWideLabtoolControlHeadSelection_A7723 = (global::AcpUI.AcpCustomViewCheckBox)target;
			return;
			IL_275D:
			this.RTDBtnRadWidePAACKAlertsonPTT_A43099 = (global::AcpUI.AcpRtdButton)target;
			return;
			IL_276A:
			this.RadWideLabtoolRxBandSplitName_A24797_Col = (global::Infragistics.Windows.DataPresenter.UnboundField)target;
			return;
			IL_2777:
			this.RadWideFeaturesTargetChanOnOffHook_A42356Comp = (global::AcpUI.AcpLabel)target;
			return;
			IL_2784:
			this.RadWideLabtoolKeypadType_A8372 = (global::AcpUI.AcpComboBox)target;
			this.RadWideLabtoolKeypadType_A8372.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_27A8:
			this.RTDBtnRadWideGenLightBarPatternRelay6_A36511 = (global::AcpUI.AcpRtdButton)target;
			return;
			IL_27B5:
			this.RadWideTransmitPowerLevelsFrequencyRangeStartMHz_A41856_Col = (global::Infragistics.Windows.DataPresenter.UnboundField)target;
			return;
			IL_27C2:
			this.LblRadWideBluetoothBluetoothReconnectTimer_A37037 = (global::AcpUI.AcpLabel)target;
			this.LblRadWideBluetoothBluetoothReconnectTimer_A37037.MouseDoubleClick += new global::System.Windows.Input.MouseButtonEventHandler(this.OnFieldNameDoubleClick);
			return;
			IL_27E6:
			this.LblRadWideFeaturesAccessoryCableConfiguration_41997 = (global::AcpUI.AcpLabel)target;
			this.LblRadWideFeaturesAccessoryCableConfiguration_41997.MouseDoubleClick += new global::System.Windows.Input.MouseButtonEventHandler(this.OnFieldNameDoubleClick);
			return;
			IL_280A:
			this.RTDBtnRadWideFeaturesEnableInvalidSIMNotification_A44945 = (global::AcpUI.AcpRtdButton)target;
			return;
			IL_2817:
			this.RTDBtnRadWideGenLightBarPatternRelay9_A36515 = (global::AcpUI.AcpRtdButton)target;
			return;
			IL_2824:
			this.RadWideLabtoolRxEndFrequencySplit_A9015_Col = (global::Infragistics.Windows.DataPresenter.UnboundField)target;
			return;
			IL_2831:
			this.CVBtnRadWideLabtoolSirenPaOnly_A9142 = (global::AcpUI.AcpCustomViewCheckBox)target;
			return;
			IL_283E:
			this.RadWideGenLightBarPatternRelay4_A36509 = (global::AcpUI.AcpComboBox)target;
			this.RadWideGenLightBarPatternRelay4_A36509.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_2862:
			this.LblRadWidePAACKAlertsonPTT_A43099 = (global::AcpUI.AcpLabel)target;
			this.LblRadWidePAACKAlertsonPTT_A43099.MouseDoubleClick += new global::System.Windows.Input.MouseButtonEventHandler(this.OnFieldNameDoubleClick);
			return;
			IL_2886:
			this.ExpanderRadioWideGeneralLightbarPatternTableView = (global::AcpUI.AcpGroupBox)target;
			return;
			IL_2893:
			this.RadWideGunlockRelocktimerName_A36521_Col = (global::Infragistics.Windows.DataPresenter.UnboundField)target;
			return;
			IL_28A0:
			this.RTDBtnRadWideRadioKilled_A41559 = (global::AcpUI.AcpRtdButton)target;
			return;
			IL_28AD:
			this.CpyBtnRadWideGeneralOwnerAdvancedKeyType_A38663 = (global::AcpUI.AcpCopyButton)target;
			return;
			IL_28BA:
			this.RTDBtnRadWideFeaturesChannelFallbackEnable = (global::AcpUI.AcpRtdButton)target;
			return;
			IL_28C7:
			this.RadWideGenLightBarPatternRelay3_A36508 = (global::AcpUI.AcpComboBox)target;
			this.RadWideGenLightBarPatternRelay3_A36508.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_28EB:
			this.CVBtnRadioWideDVRSTrunkingStatusCapability_A42772 = (global::AcpUI.AcpCustomViewCheckBox)target;
			return;
			IL_28F8:
			this.RadWideTransmitPowerLevelsTxPowerLevelLowW_A41855Comp = (global::AcpUI.AcpLabel)target;
			return;
			IL_2905:
			this.RadWideLabtoolMultipleConversationDisable_A19552 = (global::AcpUI.AcpCheckBox)target;
			this.RadWideLabtoolMultipleConversationDisable_A19552.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_2929:
			this.RadWideAlertTonesScanAlertToneEnable_A19555 = (global::AcpUI.AcpCheckBox)target;
			this.RadWideAlertTonesScanAlertToneEnable_A19555.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_294D:
			this.LblRadWideGenLightBarPatternRelay10_A36516 = (global::AcpUI.AcpLabel)target;
			this.LblRadWideGenLightBarPatternRelay10_A36516.MouseDoubleClick += new global::System.Windows.Input.MouseButtonEventHandler(this.OnFieldNameDoubleClick);
			return;
			IL_2971:
			this.RadWideDualRadioSecRadioTransmissionCapability_A42238 = (global::AcpUI.AcpCheckBox)target;
			this.RadWideDualRadioSecRadioTransmissionCapability_A42238.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_2995:
			this.CpyBtnRadWideLocationDistanceUnit_A13080 = (global::AcpUI.AcpCopyButton)target;
			return;
			IL_29A2:
			this.CpyBtnRadWideLabtoolRCLastJobSetUUID = (global::AcpUI.AcpCopyButton)target;
			return;
			IL_29AF:
			this.RadWidePowerLevelBandFrequency_A41063_Col = (global::Infragistics.Windows.DataPresenter.UnboundField)target;
			return;
			IL_29BC:
			this.RTDBtnRadWideGeneralTlsPskPort_44842 = (global::AcpUI.AcpRtdButton)target;
			return;
			IL_29C9:
			this.RTDBtnRadWideAlertTonesZeroLevelAudioMute_A9689 = (global::AcpUI.AcpRtdButton)target;
			return;
			IL_29D6:
			this.RTDBtnRadWideUserInformationandPINPasswordPart2_41304 = (global::AcpUI.AcpRtdButton)target;
			return;
			IL_29E3:
			this.ExpanderRadioWideLightbarPatternGrid = (global::System.Windows.Controls.Grid)target;
			return;
			IL_29F0:
			this.CpyBtnRadWideLabtoolChannelSelectorOnSwitch_A19551 = (global::AcpUI.AcpCopyButton)target;
			return;
			IL_29FD:
			this.RTDBtnRadWideGenLightBarPatternRelay1_A36506 = (global::AcpUI.AcpRtdButton)target;
			return;
			IL_2A0A:
			this.RTDBtnRadWideTransmitPowerLevelsFrequencyRangeEndMHz_A41857 = (global::AcpUI.AcpRtdButton)target;
			return;
			IL_2A17:
			this.RTDBtnRadWideLabtoolMFKEmergencyAccess_A42216 = (global::AcpUI.AcpRtdButton)target;
			return;
			IL_2A24:
			this.CpyBtnRadWideAdvancedRFModem_A8972 = (global::AcpUI.AcpCopyButton)target;
			return;
			IL_2A31:
			this.RTDBtnRadWideTransmitPowerLevelsFrequencyRangeEndMHz_A20037 = (global::AcpUI.AcpRtdButton)target;
			return;
			IL_2A3E:
			this.CpyBtnRadWideLabtoolSirenAndLightsKeypadEnable_A41413 = (global::AcpUI.AcpCopyButton)target;
			return;
			IL_2A4B:
			this.AllowPSUSecure_43809Comp = (global::AcpUI.AcpLabel)target;
			return;
			IL_2A58:
			this.CVBtnRadWideLocationDisplayPeerLocation_42433 = (global::AcpUI.AcpCustomViewCheckBox)target;
			return;
			IL_2A65:
			this.CVBtnRadWideFeaturesChanChangeOnOffHookEnable_A42354 = (global::AcpUI.AcpCustomViewCheckBox)target;
			return;
			IL_2A72:
			this.LblRadWideGenLightBarPatternRelay2_A36507 = (global::AcpUI.AcpLabel)target;
			this.LblRadWideGenLightBarPatternRelay2_A36507.MouseDoubleClick += new global::System.Windows.Input.MouseButtonEventHandler(this.OnFieldNameDoubleClick);
			return;
			IL_2A96:
			this.RTDBtnRadWideLabtoolPAAlertCapability_A42944 = (global::AcpUI.AcpRtdButton)target;
			return;
			IL_2AA3:
			this.CVBtnRadWideLabtoolLimitedISSIDVRSOperationCapable_43045 = (global::AcpUI.AcpCustomViewCheckBox)target;
			return;
			IL_2AB0:
			this.LblRadWideDualRadioTalkgroupMuteOption_A42290 = (global::AcpUI.AcpLabel)target;
			this.LblRadWideDualRadioTalkgroupMuteOption_A42290.MouseDoubleClick += new global::System.Windows.Input.MouseButtonEventHandler(this.OnFieldNameDoubleClick);
			return;
			IL_2AD4:
			this.GrpBoxExpanderRadioWideDigitalAudioOptionsDigitalOutboundIndicators = (global::AcpUI.AcpGroupBox)target;
			return;
			IL_2AE1:
			this.RadWideLabtoolPAAlertCapability_A42944Comp = (global::AcpUI.AcpLabel)target;
			return;
			IL_2AEE:
			this.RTDBtnRadWideBluetoothAudioBackwardsCompatibility_A44942 = (global::AcpUI.AcpRtdButton)target;
			return;
			IL_2AFB:
			this.RadWideTPSAudibleEmergencyBeaconRouting_A41972 = (global::AcpUI.AcpComboBox)target;
			this.RadWideTPSAudibleEmergencyBeaconRouting_A41972.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_2B1F:
			this.RadWideFeaturesChanChangeOnOffHookEnable_A42354 = (global::AcpUI.AcpCheckBox)target;
			this.RadWideFeaturesChanChangeOnOffHookEnable_A42354.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_2B43:
			this.RadWideUserInformationandUserLoginUnitID_41306 = (global::AcpUI.AcpTextBox)target;
			this.RadWideUserInformationandUserLoginUnitID_41306.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_2B67:
			this.CpyBtnRadWideTransmitPowerLevelsConvTxPowerLevelLowW_A41175 = (global::AcpUI.AcpCopyButton)target;
			return;
			IL_2B74:
			this.LblRadWideLabtoolAPXDualKnobs_A42537 = (global::AcpUI.AcpLabel)target;
			this.LblRadWideLabtoolAPXDualKnobs_A42537.MouseDoubleClick += new global::System.Windows.Input.MouseButtonEventHandler(this.OnFieldNameDoubleClick);
			return;
			IL_2B98:
			this.RadWideGeneralPskId_44840Comp = (global::AcpUI.AcpLabel)target;
			return;
			IL_2BA5:
			this.CpyBtnRadWideUserInformationandPasswordsRadioAlias_A8829 = (global::AcpUI.AcpCopyButton)target;
			return;
			IL_2BB2:
			this.GrpBoxExpanderRadioWideUserInformationAndPasswordsPseudo5 = (global::AcpUI.AcpGroupBox)target;
			return;
			IL_2BBF:
			this.CpyBtnRadWideOutOfRangeToneSelection_A42450 = (global::AcpUI.AcpCopyButton)target;
			return;
			IL_2BCC:
			this.CVBtnRadCfgVirtualPartnerMode = (global::AcpUI.AcpCustomViewCheckBox)target;
			return;
			IL_2BD9:
			this.RadProfAlertTonesLED_A8428Comp = (global::AcpUI.AcpCheckBox)target;
			return;
			IL_2BE6:
			this.RadWideBluetoothFriendlyName_A41181 = (global::AcpUI.AcpTextBox)target;
			this.RadWideBluetoothFriendlyName_A41181.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_2C0A:
			this.CpyBtnRadWideLabtoolReadWriteVoiceFiles_A8893 = (global::AcpUI.AcpCopyButton)target;
			return;
			IL_2C17:
			this.RadWideFeaturesTargetZoneOnOffHook_A42355Comp = (global::AcpUI.AcpLabel)target;
			return;
			IL_2C24:
			this.RadWidePAACKAlertsonPTT_A43099Comp = (global::AcpUI.AcpCheckBox)target;
			return;
			IL_2C31:
			this.RadWideCombineTxWithRxFilteredAudio_44808Comp = (global::AcpUI.AcpCheckBox)target;
			return;
			IL_2C3E:
			this.CVBtnRadWideUserInformationandPasswordsRadioLockAttemptsAllowed_A3582 = (global::AcpUI.AcpCustomViewCheckBox)target;
			return;
			IL_2C4B:
			this.LblEmergencyHotAuxMicConfigurability_A42301 = (global::AcpUI.AcpLabel)target;
			this.LblEmergencyHotAuxMicConfigurability_A42301.MouseDoubleClick += new global::System.Windows.Input.MouseButtonEventHandler(this.OnFieldNameDoubleClick);
			return;
			IL_2C6F:
			this.MARVELL_DNP_43591 = (global::AcpUI.AcpLabel)target;
			this.MARVELL_DNP_43591.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_2C93:
			this.CVBtnRadProfAlertTonesLED_A8428 = (global::AcpUI.AcpCustomViewCheckBox)target;
			return;
			IL_2CA0:
			this.RTDBtnRadWideLabtoolSirenPaOnly_A9142 = (global::AcpUI.AcpRtdButton)target;
			return;
			IL_2CAD:
			this.RadWideFiregroundPTTTransmission_A33515 = (global::AcpUI.AcpComboBox)target;
			this.RadWideFiregroundPTTTransmission_A33515.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_2CD1:
			this.LblRadWideTPSFiregroundEmergencyCallDekeySidetone_A7936 = (global::AcpUI.AcpLabel)target;
			this.LblRadWideTPSFiregroundEmergencyCallDekeySidetone_A7936.MouseDoubleClick += new global::System.Windows.Input.MouseButtonEventHandler(this.OnFieldNameDoubleClick);
			return;
			IL_2CF5:
			this.LblRadWideTxPowerLevelsNewBandPlan78MHzBandSelection_A41851 = (global::AcpUI.AcpLabel)target;
			this.LblRadWideTxPowerLevelsNewBandPlan78MHzBandSelection_A41851.MouseDoubleClick += new global::System.Windows.Input.MouseButtonEventHandler(this.OnFieldNameDoubleClick);
			return;
			IL_2D19:
			this.CVBtnRadWideSecureNFCPairing_A44931 = (global::AcpUI.AcpCustomViewCheckBox)target;
			return;
			IL_2D26:
			this.ExpanderRadioWideTxPowerLevelsByFrequencyRangeNewBandPlanSRecView = (global::AcpUI.AcpGroupBox)target;
			return;
			IL_2D33:
			this.CpyBtnRadWideAdvancedPreAmp_A8733 = (global::AcpUI.AcpCopyButton)target;
			return;
			IL_2D40:
			this.RTDBtnRadWideLabtoolChannelSelectorOnSwitch_A19551 = (global::AcpUI.AcpRtdButton)target;
			return;
			IL_2D4D:
			this.LblRadWideUserInformationandPasswordsRadioLockForceChangePassword_A3583 = (global::AcpUI.AcpLabel)target;
			this.LblRadWideUserInformationandPasswordsRadioLockForceChangePassword_A3583.MouseDoubleClick += new global::System.Windows.Input.MouseButtonEventHandler(this.OnFieldNameDoubleClick);
			return;
			IL_2D71:
			this.LblRadWideLabtoolFatalError_A8015 = (global::AcpUI.AcpLabel)target;
			this.LblRadWideLabtoolFatalError_A8015.MouseDoubleClick += new global::System.Windows.Input.MouseButtonEventHandler(this.OnFieldNameDoubleClick);
			return;
			IL_2D95:
			this.HLinkAlertTones = (global::System.Windows.Documents.Hyperlink)target;
			this.HLinkAlertTones.Click += this.HLinkClick;
			return;
			IL_2DB9:
			this.CVBtnRadWideLabtoolCertMgmtMotorolaSolutionsPKIHostname = (global::AcpUI.AcpCustomViewCheckBox)target;
			return;
			IL_2DC6:
			this.LblRadProfAlertTonesEnhancedMuteTonesOperation_A42150 = (global::AcpUI.AcpLabel)target;
			this.LblRadProfAlertTonesEnhancedMuteTonesOperation_A42150.MouseDoubleClick += new global::System.Windows.Input.MouseButtonEventHandler(this.OnFieldNameDoubleClick);
			return;
			IL_2DEA:
			this.LblRadWideBluetoothReplacePairingInfo_A41562 = (global::AcpUI.AcpLabel)target;
			this.LblRadWideBluetoothReplacePairingInfo_A41562.MouseDoubleClick += new global::System.Windows.Input.MouseButtonEventHandler(this.OnFieldNameDoubleClick);
			return;
			IL_2E0E:
			this.RadWideTransmitPowerLevelsTrkTxPowerLevelLowW_A41176Comp = (global::AcpUI.AcpLabel)target;
			return;
			IL_2E1B:
			this.RTDBtnRadWideLabtoolDisplayContrastConfiguration_A7873 = (global::AcpUI.AcpRtdButton)target;
			return;
			IL_2E28:
			this.CVBtnRadWideLabtoolRCLastJobSetUUID = (global::AcpUI.AcpCustomViewCheckBox)target;
			return;
			IL_2E35:
			this.RadWideUserInformationandPINPasswordPart2_41304 = (global::AcpUI.AcpTextBox)target;
			this.RadWideUserInformationandPINPasswordPart2_41304.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_2E59:
			this.LblRadWideLabtoolUserSelectablePLEnhancement_43031 = (global::AcpUI.AcpLabel)target;
			this.LblRadWideLabtoolUserSelectablePLEnhancement_43031.MouseDoubleClick += new global::System.Windows.Input.MouseButtonEventHandler(this.OnFieldNameDoubleClick);
			return;
			IL_2E7D:
			this.RTDBtnRadWideLabtoolRxStartFrequencySplit_A9032 = (global::AcpUI.AcpRtdButton)target;
			return;
			IL_2E8A:
			this.RTDBtnMultiRadioSystemEnable_A42248 = (global::AcpUI.AcpRtdButton)target;
			return;
			IL_2E97:
			this.LblRadWideGenLightBarPatternRelay5_A36510 = (global::AcpUI.AcpLabel)target;
			this.LblRadWideGenLightBarPatternRelay5_A36510.MouseDoubleClick += new global::System.Windows.Input.MouseButtonEventHandler(this.OnFieldNameDoubleClick);
			return;
			IL_2EBB:
			this.RadWideUserInformationandUserLoginUnitIDEnable_41305Comp = (global::AcpUI.AcpCheckBox)target;
			return;
			IL_2EC8:
			this.RTDBtnRadWideUserInformationandPasswordsMandatoryPassword_A8461 = (global::AcpUI.AcpRtdButton)target;
			return;
			IL_2ED5:
			this.RadWideStandardNFCPairing_A44928 = (global::AcpUI.AcpCheckBox)target;
			this.RadWideStandardNFCPairing_A44928.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_2EF9:
			this.IsolatedGCAIAccessoryPlugAndPlayDisable_42927 = (global::AcpUI.AcpCheckBox)target;
			this.IsolatedGCAIAccessoryPlugAndPlayDisable_42927.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_2F1D:
			this.RadWideTPSEmergencyPTTTransmission_A41544 = (global::AcpUI.AcpComboBox)target;
			this.RadWideTPSEmergencyPTTTransmission_A41544.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_2F41:
			this.CpyBtnSensorEventDisableTimer_43198 = (global::AcpUI.AcpCopyButton)target;
			return;
			IL_2F4E:
			this.RTDBtnRadWideGeneralDnsSdPort_44844 = (global::AcpUI.AcpRtdButton)target;
			return;
			IL_2F5B:
			this.CpyBtnRadWideAudioConfigurationLevel_42740 = (global::AcpUI.AcpCopyButton)target;
			return;
			IL_2F68:
			this.RTDBtnRadWideBluetoothBluetoothDeviceInquiryDuration_41977 = (global::AcpUI.AcpRtdButton)target;
			return;
			IL_2F75:
			this.CpyBtnRadWideTransmitPowerLevelsFrequencyRangeStartMHz_A19994 = (global::AcpUI.AcpCopyButton)target;
			return;
			IL_2F82:
			this.LblRadWideTransmitPowerLevelsFrequencyRangeEndMHz_A20037 = (global::AcpUI.AcpLabel)target;
			this.LblRadWideTransmitPowerLevelsFrequencyRangeEndMHz_A20037.MouseDoubleClick += new global::System.Windows.Input.MouseButtonEventHandler(this.OnFieldNameDoubleClick);
			return;
			IL_2FA6:
			this.RadWideLabtoolChannelSelectorOnSwitch_A19551Comp = (global::AcpUI.AcpCheckBox)target;
			return;
			IL_2FB3:
			this.CVBtnRadWideLabtoolIntelligentPriorityScanCapable_43411 = (global::AcpUI.AcpCustomViewCheckBox)target;
			return;
			IL_2FC0:
			this.GrpBoxExpanderRadioWideLabtoolDeviceManagement = (global::AcpUI.AcpGroupBox)target;
			return;
			IL_2FCD:
			this.CVBtnRadWideBluetoothFriendlyName_A41181 = (global::AcpUI.AcpCustomViewCheckBox)target;
			return;
			IL_2FDA:
			this.CVBtnRadWideBluetoothBluetoothTones_A37035 = (global::AcpUI.AcpCustomViewCheckBox)target;
			return;
			IL_2FE7:
			this.RadWideLabtoolFlipDisplayOption_A8140Comp = (global::AcpUI.AcpCheckBox)target;
			return;
			IL_2FF4:
			this.RadWideLocationLocationEnable_A8448 = (global::AcpUI.AcpCheckBox)target;
			this.RadWideLocationLocationEnable_A8448.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_3018:
			this.RadWideLabtoolFreeRevolvingRotary_A8147Comp = (global::AcpUI.AcpCheckBox)target;
			return;
			IL_3025:
			this.LblRadWideLocationUserSelectableLocationEnable_A9605 = (global::AcpUI.AcpLabel)target;
			this.LblRadWideLocationUserSelectableLocationEnable_A9605.MouseDoubleClick += new global::System.Windows.Input.MouseButtonEventHandler(this.OnFieldNameDoubleClick);
			return;
			IL_3049:
			this.CVBtnRadWideGeneralTimeFormat_A9377 = (global::AcpUI.AcpCustomViewCheckBox)target;
			return;
			IL_3056:
			this.LblRadWideFeaturesRadioInhibitUIEnabled_44914 = (global::AcpUI.AcpLabel)target;
			this.LblRadWideFeaturesRadioInhibitUIEnabled_44914.MouseDoubleClick += new global::System.Windows.Input.MouseButtonEventHandler(this.OnFieldNameDoubleClick);
			return;
			IL_307A:
			this.RadWideFeaturesVoiceControlPriorityComp = (global::AcpUI.AcpLabel)target;
			return;
			IL_3087:
			this.LblRadWideUserInformationandUserLoginUnitIDEnable_41305 = (global::AcpUI.AcpLabel)target;
			this.LblRadWideUserInformationandUserLoginUnitIDEnable_41305.MouseDoubleClick += new global::System.Windows.Input.MouseButtonEventHandler(this.OnFieldNameDoubleClick);
			return;
			IL_30AB:
			this.RTDBtnRadWideLabtoolFCCNarrowBandStartFrequency_A38270 = (global::AcpUI.AcpRtdButton)target;
			return;
			IL_30B8:
			this.RadProfAlertTonesCallAlertToneAutoReset_A7596 = (global::AcpUI.AcpCheckBox)target;
			this.RadProfAlertTonesCallAlertToneAutoReset_A7596.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_30DC:
			this.LblRadWideLabtoolDisplayType_A7887 = (global::AcpUI.AcpLabel)target;
			this.LblRadWideLabtoolDisplayType_A7887.MouseDoubleClick += new global::System.Windows.Input.MouseButtonEventHandler(this.OnFieldNameDoubleClick);
			return;
			IL_3100:
			this.RadWideLabtoolDisplayType_A7887 = (global::AcpUI.AcpComboBox)target;
			this.RadWideLabtoolDisplayType_A7887.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_3124:
			this.RadWideTransmitPowerLevelsTxPowerLevelConfigType_A41179Comp = (global::AcpUI.AcpLabel)target;
			return;
			IL_3131:
			this.CpyBtnRadWideAdvancedUltraNarrowIntermediateFreqFilter_A9592 = (global::AcpUI.AcpCopyButton)target;
			return;
			IL_313E:
			this.LblRadWideLabtoolCertMgmtMotorolaSolutionsPKIHostname = (global::AcpUI.AcpLabel)target;
			this.LblRadWideLabtoolCertMgmtMotorolaSolutionsPKIHostname.MouseDoubleClick += new global::System.Windows.Input.MouseButtonEventHandler(this.OnFieldNameDoubleClick);
			return;
			IL_3162:
			this.LblRadWideFeaturesEnableInvalidSIMNotification_A44945 = (global::AcpUI.AcpLabel)target;
			this.LblRadWideFeaturesEnableInvalidSIMNotification_A44945.MouseDoubleClick += new global::System.Windows.Input.MouseButtonEventHandler(this.OnFieldNameDoubleClick);
			return;
			IL_3186:
			this.RTDBtnRadWideLabtoolLTEUsed_A42064 = (global::AcpUI.AcpRtdButton)target;
			return;
			IL_3193:
			this.RadWideUserInformationandPasswordsRadioAlias_A8829 = (global::AcpUI.AcpTextBox)target;
			this.RadWideUserInformationandPasswordsRadioAlias_A8829.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_31B7:
			this.CVBtnRadWideLabtoolMultipleConversationDisable_A19552 = (global::AcpUI.AcpCustomViewCheckBox)target;
			return;
			IL_31C4:
			this.CpyBtnGPSFailToneInterval_42329 = (global::AcpUI.AcpCopyButton)target;
			return;
			IL_31D1:
			this.RadWideLabtoolSmartLowBatteryThreshold_A20201 = (global::AcpUI.AcpTextBoxSpinner)target;
			this.RadWideLabtoolSmartLowBatteryThreshold_A20201.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_31F5:
			this.LblRadWidePowerLevelBandFrequency_A41063 = (global::AcpUI.AcpLabel)target;
			this.LblRadWidePowerLevelBandFrequency_A41063.MouseDoubleClick += new global::System.Windows.Input.MouseButtonEventHandler(this.OnFieldNameDoubleClick);
			return;
			IL_3219:
			this.TEN_DIGIT_RL_PSWD_capable_43711Comp = (global::AcpUI.AcpLabel)target;
			return;
			IL_3226:
			this.RadWideFeaturePreAmpVHF_A42960Comp = (global::AcpUI.AcpCheckBox)target;
			return;
			IL_3233:
			this.RTDBtnRadWideBluetoothFriendlyName_A41181 = (global::AcpUI.AcpRtdButton)target;
			return;
			IL_3240:
			this.RadWideBluetoothBluetoothDiscoverableExpirationTimer_41980Comp = (global::AcpUI.AcpLabel)target;
			return;
			IL_324D:
			this.RadWideGeneralOwnerAdvancedKeyType_A38663 = (global::AcpUI.AcpComboBox)target;
			this.RadWideGeneralOwnerAdvancedKeyType_A38663.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_3271:
			this.RadWideTransmitPowerLevelsTxPowerLevelMinimumW_A41858Comp = (global::AcpUI.AcpLabel)target;
			return;
			IL_327E:
			this.LblRadWideTransmitPowerLevelsConvTxPowerLevelLowW_A41175 = (global::AcpUI.AcpLabel)target;
			this.LblRadWideTransmitPowerLevelsConvTxPowerLevelLowW_A41175.MouseDoubleClick += new global::System.Windows.Input.MouseButtonEventHandler(this.OnFieldNameDoubleClick);
			return;
			IL_32A2:
			this.CVBtnRadErgoWideAdvancedModeSelTxName = (global::AcpUI.AcpCustomViewCheckBox)target;
			return;
			IL_32AF:
			this.RadWideLabtoolRadioWritePasswordEnable_A8889 = (global::AcpUI.AcpLabel)target;
			this.RadWideLabtoolRadioWritePasswordEnable_A8889.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_32D3:
			this.LblRadWideTransmitPowerLevelsFrequencyRangeEndMHz_A41857 = (global::AcpUI.AcpLabel)target;
			this.LblRadWideTransmitPowerLevelsFrequencyRangeEndMHz_A41857.MouseDoubleClick += new global::System.Windows.Input.MouseButtonEventHandler(this.OnFieldNameDoubleClick);
			return;
			IL_32F7:
			this.RadWideAlertTonesScanAlertToneEnable_A19555Comp = (global::AcpUI.AcpCheckBox)target;
			return;
			IL_3304:
			this.RTDBtnRadWideFeaturesExtRFRoute_A43020 = (global::AcpUI.AcpRtdButton)target;
			return;
			IL_3311:
			this.RTDBtnRadWideDualRadioTalkgroupMuteOption_A42290 = (global::AcpUI.AcpRtdButton)target;
			return;
			IL_331E:
			this.LblRadWideTransmitPowerLevelsTrkTxPowerLevelMinimumW_A41862 = (global::AcpUI.AcpLabel)target;
			this.LblRadWideTransmitPowerLevelsTrkTxPowerLevelMinimumW_A41862.MouseDoubleClick += new global::System.Windows.Input.MouseButtonEventHandler(this.OnFieldNameDoubleClick);
			return;
			IL_3342:
			this.RadWideLabtoolControlHeadConfiguration_A7722Comp = (global::AcpUI.AcpCheckBox)target;
			return;
			IL_334F:
			this.RadWideLabtoolRCLastJobSetUUIDComp = (global::AcpUI.AcpLabel)target;
			return;
			IL_335C:
			this.LblRadWideUniversalRelayControllerFatalError_A37194 = (global::AcpUI.AcpLabel)target;
			this.LblRadWideUniversalRelayControllerFatalError_A37194.MouseDoubleClick += new global::System.Windows.Input.MouseButtonEventHandler(this.OnFieldNameDoubleClick);
			return;
			IL_3380:
			this.RadWideLabtoolSirenPaOnly_A9142 = (global::AcpUI.AcpCheckBox)target;
			this.RadWideLabtoolSirenPaOnly_A9142.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_33A4:
			this.CpyBtnRadWideLabtoolSuppressEmergencyCallCapability_A42143 = (global::AcpUI.AcpCopyButton)target;
			return;
			IL_33B1:
			this.RadWideTPSAudibleEmergencyBeaconsec_A7502Comp = (global::AcpUI.AcpLabel)target;
			return;
			IL_33BE:
			this.ExpanderRadioWideTxFrequencySplitFPPTableView = (global::AcpUI.AcpGroupBox)target;
			return;
			IL_33CB:
			this.CVBtnRadWideTransmitPowerLevelsTxPowerLevelMinimumW_A20038 = (global::AcpUI.AcpCustomViewCheckBox)target;
			return;
			IL_33D8:
			this.CVBtnRadWideUserInformationandCachedCredentialsUserLoginMode_41307 = (global::AcpUI.AcpCustomViewCheckBox)target;
			return;
			IL_33E5:
			this.RadWideFeaturesAccessoryCableConfiguration_41997 = (global::AcpUI.AcpComboBox)target;
			this.RadWideFeaturesAccessoryCableConfiguration_41997.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_3409:
			this.LblRadWideLabtoolDeviceMgmtEnterpriseWifiCodeplugId = (global::AcpUI.AcpLabel)target;
			this.LblRadWideLabtoolDeviceMgmtEnterpriseWifiCodeplugId.MouseDoubleClick += new global::System.Windows.Input.MouseButtonEventHandler(this.OnFieldNameDoubleClick);
			return;
			IL_342D:
			this.RTDBtnRadWideBluetoothBluetoothTones_A37035 = (global::AcpUI.AcpRtdButton)target;
			return;
			IL_343A:
			this.CVBtnRadWideTransmitPowerLevelsTxPowerLevelMaximumW_A20039 = (global::AcpUI.AcpCustomViewCheckBox)target;
			return;
			IL_3447:
			this.RadWideUserInformationandPINPassword_41303 = (global::AcpUI.AcpPasswordEyeBox)target;
			this.RadWideUserInformationandPINPassword_41303.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_346B:
			this.RTDBtnRadWideAdvancedUltraNarrowIntermediateFreqFilter_A9592 = (global::AcpUI.AcpRtdButton)target;
			return;
			IL_3478:
			this.LblRadWideLabtoolArchiveReadPasswordEnable_A7462 = (global::AcpUI.AcpLabel)target;
			this.LblRadWideLabtoolArchiveReadPasswordEnable_A7462.MouseDoubleClick += new global::System.Windows.Input.MouseButtonEventHandler(this.OnFieldNameDoubleClick);
			return;
			IL_349C:
			this.RadWideTransmitPowerLevelsTxPowerLevelHighW_A41854 = (global::AcpUI.AcpTextBox)target;
			this.RadWideTransmitPowerLevelsTxPowerLevelHighW_A41854.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_34C0:
			this.RadWideFeaturesPowerManagementStandbyTimeComp = (global::AcpUI.AcpLabel)target;
			return;
			IL_34CD:
			this.RadioWideLabtoolDisableWindNoiseReductionLevelForAccessories_43548 = (global::AcpUI.AcpLabel)target;
			this.RadioWideLabtoolDisableWindNoiseReductionLevelForAccessories_43548.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_34F1:
			this.CpyBtnRadCfgVirtualPartnerInactivityTime = (global::AcpUI.AcpCopyButton)target;
			return;
			IL_34FE:
			this.LblRadWideDigitalAudioOptionsStrongInterference2_A9206 = (global::AcpUI.AcpLabel)target;
			this.LblRadWideDigitalAudioOptionsStrongInterference2_A9206.MouseDoubleClick += new global::System.Windows.Input.MouseButtonEventHandler(this.OnFieldNameDoubleClick);
			return;
			IL_3522:
			this.LblRadWideTransmitPowerLevelsTxPowerLevelLowW_A41855 = (global::AcpUI.AcpLabel)target;
			this.LblRadWideTransmitPowerLevelsTxPowerLevelLowW_A41855.MouseDoubleClick += new global::System.Windows.Input.MouseButtonEventHandler(this.OnFieldNameDoubleClick);
			return;
			IL_3546:
			this.RadWideGenLightBarPatternRelay2_A36507 = (global::AcpUI.AcpComboBox)target;
			this.RadWideGenLightBarPatternRelay2_A36507.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_356A:
			this.RadWideFeaturesTargetChanOnOffHook_A42356 = (global::AcpUI.AcpComboBox)target;
			this.RadWideFeaturesTargetChanOnOffHook_A42356.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_358E:
			this.RTDBtnRadWideFeaturesVoiceAbsenceTimer_42458 = (global::AcpUI.AcpRtdButton)target;
			return;
			IL_359B:
			this.RTDBtnRadWideLabtoolZoneSelectorOnSwitch_A19550 = (global::AcpUI.AcpRtdButton)target;
			return;
			IL_35A8:
			this.LblRadWideGenLightBarPatternRelay1_A36506 = (global::AcpUI.AcpLabel)target;
			this.LblRadWideGenLightBarPatternRelay1_A36506.MouseDoubleClick += new global::System.Windows.Input.MouseButtonEventHandler(this.OnFieldNameDoubleClick);
			return;
			IL_35CC:
			this.RTDBtnRadWideFeaturesVirtualPartnerAudioPriority = (global::AcpUI.AcpRtdButton)target;
			return;
			IL_35D9:
			this.CpyBtnRadWideTransmitPowerLevelsBandSplitOverride_A41064 = (global::AcpUI.AcpCopyButton)target;
			return;
			IL_35E6:
			this.CpyBtnRadWideFeaturePreAmpVHF_A42960 = (global::AcpUI.AcpCopyButton)target;
			return;
			IL_35F3:
			this.RTDBtnRadWideStandardNFCPairing_A44928 = (global::AcpUI.AcpRtdButton)target;
			return;
			IL_3600:
			this.CpyBtnRadWideUserInformationandPasswordsProtectedZonePassword_A8766 = (global::AcpUI.AcpCopyButton)target;
			return;
			IL_360D:
			this.CVBtnRadWideGunlockRelocktimerName_A36521 = (global::AcpUI.AcpCustomViewCheckBox)target;
			return;
			IL_361A:
			this.RadWideAdvancedAuxPTTAudioSource_A7529Comp = (global::AcpUI.AcpLabel)target;
			return;
			IL_3627:
			this.LblRadWideTransmitPowerLevelsConvTxPowerLevelLowW_A41861 = (global::AcpUI.AcpLabel)target;
			this.LblRadWideTransmitPowerLevelsConvTxPowerLevelLowW_A41861.MouseDoubleClick += new global::System.Windows.Input.MouseButtonEventHandler(this.OnFieldNameDoubleClick);
			return;
			IL_364B:
			this.RadWideLabtoolSmartLowBatteryThreshold_A20201Comp = (global::AcpUI.AcpLabel)target;
			return;
			IL_3658:
			this.CVBtnRadWideTransmitPowerLevelsFrequencyRangeStartMHz_A41856 = (global::AcpUI.AcpCustomViewCheckBox)target;
			return;
			IL_3665:
			this.gridExpanderRadioWideFCCNarrowBandingFrequencySplitTableSRecView = (global::System.Windows.Controls.Grid)target;
			return;
			IL_3672:
			this.RTDBtnRadWideTransmitPowerLevelsTxPowerLevelLowW_A41855 = (global::AcpUI.AcpRtdButton)target;
			return;
			IL_367F:
			this.RTDBtnRadWideUserinfoPassRequiredForGunlock_A36531 = (global::AcpUI.AcpRtdButton)target;
			return;
			IL_368C:
			this.LblManDownPersonalityConfigurableCapable_42082 = (global::AcpUI.AcpLabel)target;
			this.LblManDownPersonalityConfigurableCapable_42082.MouseDoubleClick += new global::System.Windows.Input.MouseButtonEventHandler(this.OnFieldNameDoubleClick);
			return;
			IL_36B0:
			this.RadWideTxPowerLevelsNewBandPlan78MHzBandSelection_A41851 = (global::AcpUI.AcpComboBox)target;
			this.RadWideTxPowerLevelsNewBandPlan78MHzBandSelection_A41851.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_36D4:
			this.RTDBtnRadWideGeneralPskId_44840 = (global::AcpUI.AcpRtdButton)target;
			return;
			IL_36E1:
			this.RTDBtnRadWideAdvancedAuxPTTAudioSource_A7529 = (global::AcpUI.AcpRtdButton)target;
			return;
			IL_36EE:
			this.LblRadWideLabtoolLTEUsed_A42064 = (global::AcpUI.AcpLabel)target;
			this.LblRadWideLabtoolLTEUsed_A42064.MouseDoubleClick += new global::System.Windows.Input.MouseButtonEventHandler(this.OnFieldNameDoubleClick);
			return;
			IL_3712:
			this.CVBtnRadWideDualRadioSelection_A42236 = (global::AcpUI.AcpCustomViewCheckBox)target;
			return;
			IL_371F:
			this.RadInfoGeneralMotorcycleRadio_A8546Comp = (global::AcpUI.AcpLabel)target;
			return;
			IL_372C:
			this.LblRadWideDualRadioCrossBandMuteOption_A42240 = (global::AcpUI.AcpLabel)target;
			this.LblRadWideDualRadioCrossBandMuteOption_A42240.MouseDoubleClick += new global::System.Windows.Input.MouseButtonEventHandler(this.OnFieldNameDoubleClick);
			return;
			IL_3750:
			this.CVBtnRadWideFeaturesDisplayLastAcknowledgedUserStatusorMessage_A42000 = (global::AcpUI.AcpCustomViewCheckBox)target;
			return;
			IL_375D:
			this.LblRadInfoGeneralMotorcycleRadio_A8546 = (global::AcpUI.AcpLabel)target;
			this.LblRadInfoGeneralMotorcycleRadio_A8546.MouseDoubleClick += new global::System.Windows.Input.MouseButtonEventHandler(this.OnFieldNameDoubleClick);
			return;
			IL_3781:
			this.RadWideLabtoolDeviceMgmtSeamlessUpdateRmPskIdComp = (global::AcpUI.AcpLabel)target;
			return;
			IL_378E:
			this.LblRadWideLabtoolEarlyWarningBatteryThreshold_A23977 = (global::AcpUI.AcpLabel)target;
			this.LblRadWideLabtoolEarlyWarningBatteryThreshold_A23977.MouseDoubleClick += new global::System.Windows.Input.MouseButtonEventHandler(this.OnFieldNameDoubleClick);
			return;
			IL_37B2:
			this.CVBtnRadDualRadioFatalErrorOption_A42243 = (global::AcpUI.AcpCustomViewCheckBox)target;
			return;
			IL_37BF:
			this.RadWideAdvancedMaximumTxDeviation_A8480Comp = (global::AcpUI.AcpLabel)target;
			return;
			IL_37CC:
			this.LblRadWideOutOfRangeToneSelection_A42450 = (global::AcpUI.AcpLabel)target;
			this.LblRadWideOutOfRangeToneSelection_A42450.MouseDoubleClick += new global::System.Windows.Input.MouseButtonEventHandler(this.OnFieldNameDoubleClick);
			return;
			IL_37F0:
			this.CVBtnRadWideFeaturesNFPACompliant = (global::AcpUI.AcpCustomViewCheckBox)target;
			return;
			IL_37FD:
			this.CpyBtnRadWideFeaturesEnableInvalidSIMNotification_A44945 = (global::AcpUI.AcpCopyButton)target;
			return;
			IL_380A:
			this.CpyBtnRadWideDualRadioEmergencyRadio_A42239 = (global::AcpUI.AcpCopyButton)target;
			return;
			IL_3817:
			this.CpyBtnRadWidePowerLevelBandFrequency_A41864 = (global::AcpUI.AcpCopyButton)target;
			return;
			IL_3824:
			this.RadProfAlertTonesPowerUpSelfTestAlertTone_A8718 = (global::AcpUI.AcpCheckBox)target;
			this.RadProfAlertTonesPowerUpSelfTestAlertTone_A8718.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_3848:
			this.CpyBtnRadWideLabtoolLimitedISSIDVRSOperationCapable_43045 = (global::AcpUI.AcpCopyButton)target;
			return;
			IL_3855:
			this.CpyBtnRadWideFeaturesTargetChanOnOffHook_A42356 = (global::AcpUI.AcpCopyButton)target;
			return;
			IL_3862:
			this.RTDBtnRadWideUserInformationAndPasswordsTacticalInhibitEnable_A34405 = (global::AcpUI.AcpRtdButton)target;
			return;
			IL_386F:
			this.CVBtnAllowPSUSecure_43809 = (global::AcpUI.AcpCustomViewCheckBox)target;
			return;
			IL_387C:
			this.CVBtnRadWideTPSFiregroundEvacuationAcknowledgement_A33216 = (global::AcpUI.AcpCustomViewCheckBox)target;
			return;
			IL_3889:
			this.RadWideEmergencyRxTxAlertToneSet_A41508Comp = (global::AcpUI.AcpLabel)target;
			return;
			IL_3896:
			this.HLinkLabtool = (global::System.Windows.Documents.Hyperlink)target;
			this.HLinkLabtool.Click += this.HLinkClick;
			return;
			IL_38BA:
			this.CpyBtnRadWideGeneralDnsSdAddress_44843 = (global::AcpUI.AcpCopyButton)target;
			return;
			IL_38C7:
			this.ExpanderRadioWideTxFrequencySplitFPPGrid = (global::System.Windows.Controls.Grid)target;
			return;
			IL_38D4:
			this.RTDBtnRadWideFeaturesAccessoryCableConfiguration_41997 = (global::AcpUI.AcpRtdButton)target;
			return;
			IL_38E1:
			this.RTDBtnRadWideAdvancedRFModem_A8972 = (global::AcpUI.AcpRtdButton)target;
			return;
			IL_38EE:
			this.LblRadWideLabtoolEmergencyCallOnlywithHotMicCapable_A43162 = (global::AcpUI.AcpLabel)target;
			this.LblRadWideLabtoolEmergencyCallOnlywithHotMicCapable_A43162.MouseDoubleClick += new global::System.Windows.Input.MouseButtonEventHandler(this.OnFieldNameDoubleClick);
			return;
			IL_3912:
			this.RTDBtnRadWideLabtoolRadioWritePasswordEnable_A8889 = (global::AcpUI.AcpRtdButton)target;
			return;
			IL_391F:
			this.RadWideBluetoothBluetoothPANNetworkAddress_41983Comp = (global::AcpUI.AcpLabel)target;
			return;
			IL_392C:
			this.RTDBtnRadWideAudioOptionsSelectBluetoothMicForAuxPTTAudioSource_44819 = (global::AcpUI.AcpRtdButton)target;
			return;
			IL_3939:
			this.CVBtnRadWideLabtoolSupportO3ControlHeadPCIBit_44884 = (global::AcpUI.AcpCustomViewCheckBox)target;
			return;
			IL_3946:
			this.RTDBtnRadWideTransmitPowerLevelsConvTxPowerLevelMinimumW_A41173 = (global::AcpUI.AcpRtdButton)target;
			return;
			IL_3953:
			this.RadWideUserinfoPassRequiredForSiren_A36533Comp = (global::AcpUI.AcpCheckBox)target;
			return;
			IL_3960:
			this.CVBtnRadWideTransmitPowerLevelsTxPowerLevelMaximumW_A41859 = (global::AcpUI.AcpCustomViewCheckBox)target;
			return;
			IL_396D:
			this.UCLContactsLimitationEnhancement_43811 = (global::AcpUI.AcpLabel)target;
			this.UCLContactsLimitationEnhancement_43811.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_3991:
			this.RadWideLabtoolEarlyWarningBatteryThreshold_A23977 = (global::AcpUI.AcpTextBoxSpinner)target;
			this.RadWideLabtoolEarlyWarningBatteryThreshold_A23977.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_39B5:
			this.RadWideFeaturesVoiceAbsenceTimer_42458Comp = (global::AcpUI.AcpLabel)target;
			return;
			IL_39C2:
			this.CpyBtnRadWideGeneralOwnerSystemID_A37153 = (global::AcpUI.AcpCopyButton)target;
			return;
			IL_39CF:
			this.CpyBtnRadWideFeaturesNFPACompliant = (global::AcpUI.AcpCopyButton)target;
			return;
			IL_39DC:
			this.RadWideFeaturesChanChangeOnOffHookEnable_A42354Comp = (global::AcpUI.AcpCheckBox)target;
			return;
			IL_39E9:
			this.RadioWideLabtoolExtendedPLToneSet_43769 = (global::AcpUI.AcpLabel)target;
			this.RadioWideLabtoolExtendedPLToneSet_43769.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_3A0D:
			this.RTDBtnRadWideLabtoolControlHeadConfiguration_A7722 = (global::AcpUI.AcpRtdButton)target;
			return;
			IL_3A1A:
			this.CVBtnRadWideGenLightBarPatternRelay3_A36508 = (global::AcpUI.AcpCustomViewCheckBox)target;
			return;
			IL_3A27:
			this.LblRadWideDualRadioSelection_A42236 = (global::AcpUI.AcpLabel)target;
			this.LblRadWideDualRadioSelection_A42236.MouseDoubleClick += new global::System.Windows.Input.MouseButtonEventHandler(this.OnFieldNameDoubleClick);
			return;
			IL_3A4B:
			this.RTDBtnRadWideFeaturePreAmpUHF_A42962 = (global::AcpUI.AcpRtdButton)target;
			return;
			IL_3A58:
			this.CVBtnRadWideDigitalAudioOptionsStrongInterference1_A9207 = (global::AcpUI.AcpCustomViewCheckBox)target;
			return;
			IL_3A65:
			this.LblRadWideUserInformationandPasswordsMaximumPasswordLength_A8477 = (global::AcpUI.AcpLabel)target;
			this.LblRadWideUserInformationandPasswordsMaximumPasswordLength_A8477.MouseDoubleClick += new global::System.Windows.Input.MouseButtonEventHandler(this.OnFieldNameDoubleClick);
			return;
			IL_3A89:
			this.CVBtnRadioWidePTTWarningTone = (global::AcpUI.AcpCustomViewCheckBox)target;
			return;
			IL_3A96:
			this.RadWideTransmitPowerLevelsTxPowerLevelConfigType_A41179 = (global::AcpUI.AcpComboBox)target;
			this.RadWideTransmitPowerLevelsTxPowerLevelConfigType_A41179.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_3ABA:
			this.LblRadWideFeaturesExtRFRoute_A43020 = (global::AcpUI.AcpLabel)target;
			this.LblRadWideFeaturesExtRFRoute_A43020.MouseDoubleClick += new global::System.Windows.Input.MouseButtonEventHandler(this.OnFieldNameDoubleClick);
			return;
			IL_3ADE:
			this.LblRadWideFiregroundPTTTransmission_A33515 = (global::AcpUI.AcpLabel)target;
			this.LblRadWideFiregroundPTTTransmission_A33515.MouseDoubleClick += new global::System.Windows.Input.MouseButtonEventHandler(this.OnFieldNameDoubleClick);
			return;
			IL_3B02:
			this.RadWideFeaturesDisplayLastAcknowledgedUserStatusorMessage_A42000 = (global::AcpUI.AcpCheckBox)target;
			this.RadWideFeaturesDisplayLastAcknowledgedUserStatusorMessage_A42000.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_3B26:
			this.RadWideOutOfRangeToneSelection_A42450 = (global::AcpUI.AcpComboBox)target;
			this.RadWideOutOfRangeToneSelection_A42450.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_3B4A:
			this.ToneEmergencyConfigurableCapable_42083Comp = (global::AcpUI.AcpLabel)target;
			return;
			IL_3B57:
			this.LblRadioWideLabtoolZoneCloneCapable_43238 = (global::AcpUI.AcpLabel)target;
			this.LblRadioWideLabtoolZoneCloneCapable_43238.MouseDoubleClick += new global::System.Windows.Input.MouseButtonEventHandler(this.OnFieldNameDoubleClick);
			return;
			IL_3B7B:
			this.RadWideFeaturesRadioInhibitUIEnabled_44914 = (global::AcpUI.AcpCheckBox)target;
			this.RadWideFeaturesRadioInhibitUIEnabled_44914.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_3B9F:
			this.CpyBtnRadWideLabtoolSupportO3ControlHeadPCIBit_44884 = (global::AcpUI.AcpCopyButton)target;
			return;
			IL_3BAC:
			this.ExpanderRadioWideLabtool = (global::AcpUI.AcpExpander)target;
			return;
			IL_3BB9:
			this.LblSensorEventNotificationEnable_43525 = (global::AcpUI.AcpLabel)target;
			this.LblSensorEventNotificationEnable_43525.MouseDoubleClick += new global::System.Windows.Input.MouseButtonEventHandler(this.OnFieldNameDoubleClick);
			return;
			IL_3BDD:
			this.RadWideLabtoolConsoletteModelEnable_A7713Comp = (global::AcpUI.AcpCheckBox)target;
			return;
			IL_3BEA:
			this.RadWideGeneralDnsSdPort_44844Comp = (global::AcpUI.AcpLabel)target;
			return;
			IL_3BF7:
			this.RadWideLabtoolSupportO3ControlHeadPCIBit_44884 = (global::AcpUI.AcpLabel)target;
			this.RadWideLabtoolSupportO3ControlHeadPCIBit_44884.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_3C1B:
			this.CVBtnRadWideLabtoolFCCNarrowBandEndFrequency_A38271 = (global::AcpUI.AcpCustomViewCheckBox)target;
			return;
			IL_3C28:
			this.RadWideTPSFiregroundEvacuationAcknowledgement_A33216Comp = (global::AcpUI.AcpLabel)target;
			return;
			IL_3C35:
			this.RTDBtnRadWideUserInformationandPINPassword_41303 = (global::AcpUI.AcpRtdButton)target;
			return;
			IL_3C42:
			this.LblRadWideLabtoolFlipDisplayOption_A8140 = (global::AcpUI.AcpLabel)target;
			this.LblRadWideLabtoolFlipDisplayOption_A8140.MouseDoubleClick += new global::System.Windows.Input.MouseButtonEventHandler(this.OnFieldNameDoubleClick);
			return;
			IL_3C66:
			this.RadWideUserInformationandPasswordsSoftIDUsernameDisplayTextSize_A23453Comp = (global::AcpUI.AcpLabel)target;
			return;
			IL_3C73:
			this.RadWideLabtoolSirenPaFatalError_A9141 = (global::AcpUI.AcpCheckBox)target;
			this.RadWideLabtoolSirenPaFatalError_A9141.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_3C97:
			this.RTDBtnRadWideTPSPTTTransmission_A41545 = (global::AcpUI.AcpRtdButton)target;
			return;
			IL_3CA4:
			this.RadWideFeaturesSmartMessagingSmartMessageModeComp = (global::AcpUI.AcpLabel)target;
			return;
			IL_3CB1:
			this.LblRadWideLabtoolTxStartFrequencySplit_A9571 = (global::AcpUI.AcpLabel)target;
			this.LblRadWideLabtoolTxStartFrequencySplit_A9571.MouseDoubleClick += new global::System.Windows.Input.MouseButtonEventHandler(this.OnFieldNameDoubleClick);
			return;
			IL_3CD5:
			this.RadWideFeaturesInactivityAutoPoweroff_A38013Comp = (global::AcpUI.AcpLabel)target;
			return;
			IL_3CE2:
			this.RadWideLabtoolAPXSingletoneCapable_43080Comp = (global::AcpUI.AcpLabel)target;
			return;
			IL_3CEF:
			this.RadWideGenLightBarPatternRelay7_A36512 = (global::AcpUI.AcpComboBox)target;
			this.RadWideGenLightBarPatternRelay7_A36512.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_3D13:
			this.ExpanderRadioWideLightbarPattern = (global::AcpUI.AcpExpander)target;
			return;
			IL_3D20:
			this.CpyBtnRadInfoGeneralMotorcycleRadio_A8546 = (global::AcpUI.AcpCopyButton)target;
			return;
			IL_3D2D:
			this.CpyBtnRadDualRadioFatalErrorOption_A42243 = (global::AcpUI.AcpCopyButton)target;
			return;
			IL_3D3A:
			this.RadWideBluetoothBluetoothDropTimer_A37038Comp = (global::AcpUI.AcpLabel)target;
			return;
			IL_3D47:
			this.CVBtnRadWideFeaturesRadioInhibitDisplayTextLine1_44915 = (global::AcpUI.AcpLabel)target;
			this.CVBtnRadWideFeaturesRadioInhibitDisplayTextLine1_44915.MouseDoubleClick += new global::System.Windows.Input.MouseButtonEventHandler(this.OnFieldNameDoubleClick);
			return;
			IL_3D6B:
			this.CVBtnRadWideLabtoolMaritimeRadioSoftware_A42191 = (global::AcpUI.AcpCustomViewCheckBox)target;
			return;
			IL_3D78:
			this.CpyBtnRadWideAlertTonesScanAlertToneEnable_A19555 = (global::AcpUI.AcpCopyButton)target;
			return;
			IL_3D85:
			this.CVBtnRadWideLabtoolSirenPaSystemLookup_A9143 = (global::AcpUI.AcpCustomViewCheckBox)target;
			return;
			IL_3D92:
			this.RadWideFeaturesRadioInhibitUIEnabled_44914Comp = (global::AcpUI.AcpCheckBox)target;
			return;
			IL_3D9F:
			this.RadWideAdvancedAuxPTTAudioSource_A7529 = (global::AcpUI.AcpComboBox)target;
			this.RadWideAdvancedAuxPTTAudioSource_A7529.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_3DC3:
			this.PASSAlarmFilterCapable_A42387 = (global::AcpUI.AcpLabel)target;
			this.PASSAlarmFilterCapable_A42387.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_3DE7:
			this.LblRadWideBluetoothBluetoothEnable_A37028 = (global::AcpUI.AcpLabel)target;
			this.LblRadWideBluetoothBluetoothEnable_A37028.MouseDoubleClick += new global::System.Windows.Input.MouseButtonEventHandler(this.OnFieldNameDoubleClick);
			return;
			IL_3E0B:
			this.CVBtnRadWideLocationDisplayFormat_A41561 = (global::AcpUI.AcpCustomViewCheckBox)target;
			return;
			IL_3E18:
			this.RadWideFeaturesRadioInhibitDisplayTextLine1_44915 = (global::AcpUI.AcpTextBox)target;
			this.RadWideFeaturesRadioInhibitDisplayTextLine1_44915.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_3E3C:
			this.ExpanderRadioWideFCCNarrowBandingFrequencySplitTableGrid = (global::System.Windows.Controls.Grid)target;
			return;
			IL_3E49:
			this.ExpanderRadioWideFCCNarrowBandingFrequencySplit = (global::AcpUI.AcpExpander)target;
			return;
			IL_3E56:
			this.LblRadWideLabtoolRadioWritePasswordEnable_A8889 = (global::AcpUI.AcpLabel)target;
			this.LblRadWideLabtoolRadioWritePasswordEnable_A8889.MouseDoubleClick += new global::System.Windows.Input.MouseButtonEventHandler(this.OnFieldNameDoubleClick);
			return;
			IL_3E7A:
			this.LblRadWideTransmitPowerLevelsTxPowerLevelHighW_A41854 = (global::AcpUI.AcpLabel)target;
			this.LblRadWideTransmitPowerLevelsTxPowerLevelHighW_A41854.MouseDoubleClick += new global::System.Windows.Input.MouseButtonEventHandler(this.OnFieldNameDoubleClick);
			return;
			IL_3E9E:
			this.RadWideGeneralOwnerWACNID_A38656 = (global::AcpUI.AcpTextBoxSpinnerDecHex)target;
			this.RadWideGeneralOwnerWACNID_A38656.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_3EC2:
			this.RecNavToolbarExpanderRadioWideTxPowerLevelsByFrequencyRangeNewBandPlan = (global::AcpUI.AcpRecNavToolbar)target;
			this.RecNavToolbarExpanderRadioWideTxPowerLevelsByFrequencyRangeNewBandPlan.ModeClick += this.OnModeClick;
			return;
			IL_3EE6:
			this.CpyBtnRadWideFeaturesBlockPendingCAPC_A7564 = (global::AcpUI.AcpCopyButton)target;
			return;
			IL_3EF3:
			this.CVBtnRadWideLabtoolDeviceMgmtSeamlessUpdateRmPsk = (global::AcpUI.AcpCustomViewCheckBox)target;
			return;
			IL_3F00:
			this.RTDBtnRadWideUserInformationandPasswordsUnlockPassword_A8690 = (global::AcpUI.AcpRtdButton)target;
			return;
			IL_3F0D:
			this.CVBtnRadWideAlertTonesVolumeAdjustToneDisable = (global::AcpUI.AcpCustomViewCheckBox)target;
			return;
			IL_3F1A:
			this.RTDBtnRadWideUserinfoPassRequiredForLightbar_A36532 = (global::AcpUI.AcpRtdButton)target;
			return;
			IL_3F27:
			this.LblRadWideTransmitPowerLevelsTxPowerLevelMinimumW_A20038 = (global::AcpUI.AcpLabel)target;
			this.LblRadWideTransmitPowerLevelsTxPowerLevelMinimumW_A20038.MouseDoubleClick += new global::System.Windows.Input.MouseButtonEventHandler(this.OnFieldNameDoubleClick);
			return;
			IL_3F4B:
			this.CpyBtnRadWideFeaturesChanChangeOnOffHookEnable_A42354 = (global::AcpUI.AcpCopyButton)target;
			return;
			IL_3F58:
			this.CpyBtnRadWideLocationLocationEnable_A8448 = (global::AcpUI.AcpCopyButton)target;
			return;
			IL_3F65:
			this.RadWideTransmitPowerLevelsTxPowerLevelMaximumW_A41859Comp = (global::AcpUI.AcpLabel)target;
			return;
			IL_3F72:
			this.RTDBtnRadWideUserInformationandPasswordsSoftIDUsername_A9169 = (global::AcpUI.AcpRtdButton)target;
			return;
			IL_3F7F:
			this.RadWideGunlockRelocktimerTimer_A36522 = (global::AcpUI.AcpTextBoxSpinner)target;
			this.RadWideGunlockRelocktimerTimer_A36522.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_3FA3:
			this.LblRadWideCustomLogoEnabled = (global::AcpUI.AcpLabel)target;
			this.LblRadWideCustomLogoEnabled.MouseDoubleClick += new global::System.Windows.Input.MouseButtonEventHandler(this.OnFieldNameDoubleClick);
			return;
			IL_3FC7:
			this.RTDBtnRadDualRadioFatalErrorOption_A42243 = (global::AcpUI.AcpRtdButton)target;
			return;
			IL_3FD4:
			this.CVBtnRadWideAdvancedAuxPTTAudioSource_A7529 = (global::AcpUI.AcpCustomViewCheckBox)target;
			return;
			IL_3FE1:
			this.LblSwitchConventionalSwitchesPosition1_A12643 = (global::AcpUI.AcpLabel)target;
			this.LblSwitchConventionalSwitchesPosition1_A12643.MouseDoubleClick += new global::System.Windows.Input.MouseButtonEventHandler(this.OnFieldNameDoubleClick);
			return;
			IL_4005:
			this.CVBtnRadWideLabtoolUserSelectablePLEnhancement_43031 = (global::AcpUI.AcpCustomViewCheckBox)target;
			return;
			IL_4012:
			this.RadWideLabtoolCertMgmtMotorolaSolutionsPKIPortComp = (global::AcpUI.AcpLabel)target;
			return;
			IL_401F:
			this.RTDBtnRadWideFeaturesIgnitionAutoPoweroff_A38014 = (global::AcpUI.AcpRtdButton)target;
			return;
			IL_402C:
			this.CVBtnRadWideDigitalAudioOptionsWeakSignalFringe_A9679 = (global::AcpUI.AcpCustomViewCheckBox)target;
			return;
			IL_4039:
			this.RadWideUserInformationandPasswordsSoftIDUsername_A9169Comp = (global::AcpUI.AcpLabel)target;
			return;
			IL_4046:
			this.ExpanderRadioWideBluetooth = (global::AcpUI.AcpExpander)target;
			return;
			IL_4053:
			this.LblRadWideFeaturesDisableIgnitionAutoPowerOffAlert_A38015 = (global::AcpUI.AcpLabel)target;
			this.LblRadWideFeaturesDisableIgnitionAutoPowerOffAlert_A38015.MouseDoubleClick += new global::System.Windows.Input.MouseButtonEventHandler(this.OnFieldNameDoubleClick);
			return;
			IL_4077:
			this.CpyBtnRadWideUniversalRelayControllerEquipped_A37191 = (global::AcpUI.AcpCopyButton)target;
			return;
			IL_4084:
			this.CVBtnRadWideUserInformationandPasswordsRadioLockForceChangePassword_A3583 = (global::AcpUI.AcpCustomViewCheckBox)target;
			return;
			IL_4091:
			this.LblRadWideSecureNFCPairing_A44931 = (global::AcpUI.AcpLabel)target;
			this.LblRadWideSecureNFCPairing_A44931.MouseDoubleClick += new global::System.Windows.Input.MouseButtonEventHandler(this.OnFieldNameDoubleClick);
			return;
			IL_40B5:
			this.RTDBtnRadWideCombineTxWithRxFilteredAudio_44808 = (global::AcpUI.AcpRtdButton)target;
			return;
			IL_40C2:
			this.RTDBtnRadWideSmartMappingServerAssistedLocation = (global::AcpUI.AcpRtdButton)target;
			return;
			IL_40CF:
			this.RadWideLabtoolDisplayContrastConfiguration_A7873 = (global::AcpUI.AcpTextBoxDecHex)target;
			this.RadWideLabtoolDisplayContrastConfiguration_A7873.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_40F3:
			this.GrpBoxExpanderRadioWideUserInformationAndPasswordsTacticalInhibit = (global::AcpUI.AcpGroupBox)target;
			return;
			IL_4100:
			this.RTDBtnRadioWideLabtoolExtendedPLToneSet_43769 = (global::AcpUI.AcpRtdButton)target;
			return;
			IL_410D:
			this.RTDBtnRadWideTransmitPowerLevelsTrkTxPowerLevelMinimumW_A41862 = (global::AcpUI.AcpRtdButton)target;
			return;
			IL_411A:
			this.CpyBtnRadProfAlertTonesAlertTones_A7428 = (global::AcpUI.AcpCopyButton)target;
			return;
			IL_4127:
			this.CVBtnRadWideUserinfoPassRequiredForLightbar_A36532 = (global::AcpUI.AcpCustomViewCheckBox)target;
			return;
			IL_4134:
			this.LblRadCfgLocationReporting = (global::AcpUI.AcpLabel)target;
			this.LblRadCfgLocationReporting.MouseDoubleClick += new global::System.Windows.Input.MouseButtonEventHandler(this.OnFieldNameDoubleClick);
			return;
			IL_4158:
			this.CpyBtnAdvancedAuxTransmitSensitivity_A7530 = (global::AcpUI.AcpCopyButton)target;
			return;
			IL_4165:
			this.CpyBtnRadWideGenLightBarPatternRelay2_A36507 = (global::AcpUI.AcpCopyButton)target;
			return;
			IL_4172:
			this.LblRadWideLabtoolEmergencyRevertCapable_A41918 = (global::AcpUI.AcpLabel)target;
			this.LblRadWideLabtoolEmergencyRevertCapable_A41918.MouseDoubleClick += new global::System.Windows.Input.MouseButtonEventHandler(this.OnFieldNameDoubleClick);
			return;
			IL_4196:
			this.RadWideFeaturesTargetZoneOnOffHook_A42355 = (global::AcpUI.AcpComboBox)target;
			this.RadWideFeaturesTargetZoneOnOffHook_A42355.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_41BA:
			this.RadWidePowerLevelBandFrequency_A41864Comp = (global::AcpUI.AcpLabel)target;
			return;
			IL_41C7:
			this.CVBtnRadWideLabtoolSuppressEmergencyCallCapability_A42143 = (global::AcpUI.AcpCustomViewCheckBox)target;
			return;
			IL_41D4:
			this.RTDBtnRadWideFiregroundPTTTransmission_A33515 = (global::AcpUI.AcpRtdButton)target;
			return;
			IL_41E1:
			this.RadWideBluetoothFriendlyNameEditable_A41182Comp = (global::AcpUI.AcpCheckBox)target;
			return;
			IL_41EE:
			this.RadWideFeaturePreAmpUHF_A42962 = (global::AcpUI.AcpCheckBox)target;
			this.RadWideFeaturePreAmpUHF_A42962.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_4212:
			this.GrpBoxExpanderRadioWideUserInformationAndPasswordsPasswordRequiredFor = (global::AcpUI.AcpGroupBox)target;
			return;
			IL_421F:
			this.RadWideLabtoolEarlyWarningBatteryThreshold_A23977Comp = (global::AcpUI.AcpLabel)target;
			return;
			IL_422C:
			this.RTDBtnRadWideTPSFiregroundVoiceTxEndTone_A9655 = (global::AcpUI.AcpRtdButton)target;
			return;
			IL_4239:
			this.CpyBtnRadWideCustomLogoEnabled = (global::AcpUI.AcpCopyButton)target;
			return;
			IL_4246:
			this.MARVELL_DNP_43591Comp = (global::AcpUI.AcpLabel)target;
			return;
			IL_4253:
			this.RadProfAlertTonesEnhancedMuteTonesOperation_A42150 = (global::AcpUI.AcpComboBox)target;
			this.RadProfAlertTonesEnhancedMuteTonesOperation_A42150.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_4277:
			this.RadWideBluetoothReplacePairingInfo_A41562 = (global::AcpUI.AcpCheckBox)target;
			this.RadWideBluetoothReplacePairingInfo_A41562.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_429B:
			this.RadWideGenLgtBarName_A36505 = (global::AcpUI.AcpTextBox)target;
			this.RadWideGenLgtBarName_A36505.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_42BF:
			this.ExpanderRadioWideTPS = (global::AcpUI.AcpExpander)target;
			return;
			IL_42CC:
			this.CpyBtnRadWideAlertTonesTxChirp_A9523 = (global::AcpUI.AcpCopyButton)target;
			return;
			IL_42D9:
			this.RadWideLabtoolLimitedISSIDVRSOperationCapable_43045Comp = (global::AcpUI.AcpLabel)target;
			return;
			IL_42E6:
			this.RTDBtnRadWideLabtoolDynamicZoneCable_A41258 = (global::AcpUI.AcpRtdButton)target;
			return;
			IL_42F3:
			this.RadWideLabtoolAnalogWideBandDataPCIBit_44885Comp = (global::AcpUI.AcpLabel)target;
			return;
			IL_4300:
			this.CpyBtnRadWideDualRadioSecRadioTransmissionCapability_A42238 = (global::AcpUI.AcpCopyButton)target;
			return;
			IL_430D:
			this.ExpanderRadioWideSensor = (global::AcpUI.AcpExpander)target;
			return;
			IL_431A:
			this.RadWideLocationGpsMode_A22627Comp = (global::AcpUI.AcpLabel)target;
			return;
			IL_4327:
			this.GrpBoxExpanderRadioWideLabtoolPseudo0 = (global::AcpUI.AcpGroupBox)target;
			return;
			IL_4334:
			this.RTDBtnRadWideAlertTonesVolumeAdjustToneOffset_A9656 = (global::AcpUI.AcpRtdButton)target;
			return;
			IL_4341:
			this.CpyBtnRadWideTransmitPowerLevelsTrkTxPowerLevelMinimumW_A41174 = (global::AcpUI.AcpCopyButton)target;
			return;
			IL_434E:
			this.CpyBtnRadWideUserInformationandPasswordsUnlockPassword_A8690 = (global::AcpUI.AcpCopyButton)target;
			return;
			IL_435B:
			this.CVBtnRadWideLabtoolRxEndFrequencySplit_A9015 = (global::AcpUI.AcpCustomViewCheckBox)target;
			return;
			IL_4368:
			this.RTDBtnRadWideLabtoolTxBandSplitName_A24799 = (global::AcpUI.AcpRtdButton)target;
			return;
			IL_4375:
			this.CVBtnRadWideLabtoolTxEndFrequencySplit_A9532 = (global::AcpUI.AcpCustomViewCheckBox)target;
			return;
			IL_4382:
			this.LblRadWideAdvancedSmartLowBatteryAlert_A9165 = (global::AcpUI.AcpLabel)target;
			this.LblRadWideAdvancedSmartLowBatteryAlert_A9165.MouseDoubleClick += new global::System.Windows.Input.MouseButtonEventHandler(this.OnFieldNameDoubleClick);
			return;
			IL_43A6:
			this.LblRadioWideLabtoolExtendedPLToneSet_43769 = (global::AcpUI.AcpLabel)target;
			this.LblRadioWideLabtoolExtendedPLToneSet_43769.MouseDoubleClick += new global::System.Windows.Input.MouseButtonEventHandler(this.OnFieldNameDoubleClick);
			return;
			IL_43CA:
			this.SensorEventNotificationEnable_43525 = (global::AcpUI.AcpCheckBox)target;
			this.SensorEventNotificationEnable_43525.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_43EE:
			this.RTDBtnRadWideLabtoolRxBandSplitName_A24797 = (global::AcpUI.AcpRtdButton)target;
			return;
			IL_43FB:
			this.RadWideGeneralTlsPsk_44841 = (global::AcpUI.AcpTextBox)target;
			this.RadWideGeneralTlsPsk_44841.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_441F:
			this.CpyBtnRadWideBluetoothBluetoothEnable_A37028 = (global::AcpUI.AcpCopyButton)target;
			return;
			IL_442C:
			this.CVBtnRadWideBluetoothLegacyPINPairing = (global::AcpUI.AcpCustomViewCheckBox)target;
			return;
			IL_4439:
			this.RadWideTPSFiregroundEmergencyCallDekeySidetone_A7936Comp = (global::AcpUI.AcpCheckBox)target;
			return;
			IL_4446:
			this.RadWideTPSFiregroundEmergencyCallDekeySidetone_A7936 = (global::AcpUI.AcpCheckBox)target;
			this.RadWideTPSFiregroundEmergencyCallDekeySidetone_A7936.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_446A:
			this.LblRadWideLabtoolAnalogWideBandDataPCIBit_44885 = (global::AcpUI.AcpLabel)target;
			this.LblRadWideLabtoolAnalogWideBandDataPCIBit_44885.MouseDoubleClick += new global::System.Windows.Input.MouseButtonEventHandler(this.OnFieldNameDoubleClick);
			return;
			IL_448E:
			this.LblRadWideLabtoolDeviceMgmtSeamlessUpdateGatewayHostname = (global::AcpUI.AcpLabel)target;
			this.LblRadWideLabtoolDeviceMgmtSeamlessUpdateGatewayHostname.MouseDoubleClick += new global::System.Windows.Input.MouseButtonEventHandler(this.OnFieldNameDoubleClick);
			return;
			IL_44B2:
			this.RTDBtnRadWideDigitalAudioOptionsWeakSignalFringe_A9678 = (global::AcpUI.AcpRtdButton)target;
			return;
			IL_44BF:
			this.CVBtnRadWideDigitalAudioOptionsStrongInterference2_A9206 = (global::AcpUI.AcpCustomViewCheckBox)target;
			return;
			IL_44CC:
			this.RadWideUserInformationandPasswordsRadioAliasEnable_A8830 = (global::AcpUI.AcpCheckBox)target;
			this.RadWideUserInformationandPasswordsRadioAliasEnable_A8830.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_44F0:
			this.CpyBtnRadWideAlertTonesRSMVolumeSetTone = (global::AcpUI.AcpCopyButton)target;
			return;
			IL_44FD:
			this.RadWideTransmitPowerLevelsTxPowerLevelMinimumW_A20038_Col = (global::Infragistics.Windows.DataPresenter.UnboundField)target;
			return;
			IL_450A:
			this.RTDBtnRadWideSecureNFCPairing_A44931 = (global::AcpUI.AcpRtdButton)target;
			return;
			IL_4517:
			this.RadWideTransmitPowerLevelsTrkTxPowerLevelLowW_A41176_Col = (global::Infragistics.Windows.DataPresenter.UnboundField)target;
			return;
			IL_4524:
			this.CVBtnRadWideFeaturesRecordPlaybackAudioBufferSize_A43125 = (global::AcpUI.AcpCustomViewCheckBox)target;
			return;
			IL_4531:
			this.CVBtnRadWideLabtoolDeviceMgmtSeamlessUpdateGatewayHostname = (global::AcpUI.AcpCustomViewCheckBox)target;
			return;
			IL_453E:
			this.CpyBtnTEN_DIGIT_RL_PSWD_capable_43711 = (global::AcpUI.AcpCopyButton)target;
			return;
			IL_454B:
			this.CVBtnRadWideFeaturesVoiceAbsenceTimer_42458 = (global::AcpUI.AcpCustomViewCheckBox)target;
			return;
			IL_4558:
			this.ExpanderRadioWideRxFrequencySplitFPPSRecView = (global::AcpUI.AcpGroupBox)target;
			return;
			IL_4565:
			this.CVBtnRadWidePowerLevelBandFrequency_A41063 = (global::AcpUI.AcpCustomViewCheckBox)target;
			return;
			IL_4572:
			this.RadWideFeaturesExtRFRoute_A43020Comp = (global::AcpUI.AcpLabel)target;
			return;
			IL_457F:
			this.RadWideLabtoolAudibleBeaconRoutingCapable_A41974Comp = (global::AcpUI.AcpLabel)target;
			return;
			IL_458C:
			this.LblRadWideLabtoolActiveMicForBTPTTCapable_43053 = (global::AcpUI.AcpLabel)target;
			this.LblRadWideLabtoolActiveMicForBTPTTCapable_43053.MouseDoubleClick += new global::System.Windows.Input.MouseButtonEventHandler(this.OnFieldNameDoubleClick);
			return;
			IL_45B0:
			this.CpyBtnRadWideLabtoolEarlyWarningBatteryThreshold_A23977 = (global::AcpUI.AcpCopyButton)target;
			return;
			IL_45BD:
			this.CVBtnRadWideLabtoolChannelSelectorOnSwitch_A19551 = (global::AcpUI.AcpCustomViewCheckBox)target;
			return;
			IL_45CA:
			this.CpyBtnRadProfAlertTonesCallAlertToneAutoReset_A7596 = (global::AcpUI.AcpCopyButton)target;
			return;
			IL_45D7:
			this.RadWideTransmitPowerLevelsTrkTxPowerLevelLowW_A41860 = (global::AcpUI.AcpTextBox)target;
			this.RadWideTransmitPowerLevelsTrkTxPowerLevelLowW_A41860.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_45FB:
			this.RadWideGenLightBarPatternRelay8_A36513Comp = (global::AcpUI.AcpLabel)target;
			return;
			IL_4608:
			this.RadWideLabtoolRxStartFrequencySplit_A9032_Col = (global::Infragistics.Windows.DataPresenter.UnboundField)target;
			return;
			IL_4615:
			this.CVBtnRadWideUserInformationandPINPasswordPart2_41304 = (global::AcpUI.AcpCustomViewCheckBox)target;
			return;
			IL_4622:
			this.RTDBtnRadCfgLocationReporting = (global::AcpUI.AcpRtdButton)target;
			return;
			IL_462F:
			this.CpyBtnRadWideLocationDisplayFormat_A41561 = (global::AcpUI.AcpCopyButton)target;
			return;
			IL_463C:
			this.LblMARVELL_DNP_43591 = (global::AcpUI.AcpLabel)target;
			this.LblMARVELL_DNP_43591.MouseDoubleClick += new global::System.Windows.Input.MouseButtonEventHandler(this.OnFieldNameDoubleClick);
			return;
			IL_4660:
			this.LblRadWideTransmitPowerLevelsTxPowerLevelHighW_A8152 = (global::AcpUI.AcpLabel)target;
			this.LblRadWideTransmitPowerLevelsTxPowerLevelHighW_A8152.MouseDoubleClick += new global::System.Windows.Input.MouseButtonEventHandler(this.OnFieldNameDoubleClick);
			return;
			IL_4684:
			this.CVBtnRadWideGenLightBarPatternRelay8_A36513 = (global::AcpUI.AcpCustomViewCheckBox)target;
			return;
			IL_4691:
			this.CpyBtnUCLContactsLimitationEnhancement_43811 = (global::AcpUI.AcpCopyButton)target;
			return;
			IL_469E:
			this.RadWideLabtoolSirenPaFatalError_A9141Comp = (global::AcpUI.AcpCheckBox)target;
			return;
			IL_46AB:
			this.RTDBtnRadWideTPSFiregroundEmergencyAlarmRetryRatesec_A7929 = (global::AcpUI.AcpRtdButton)target;
			return;
			IL_46B8:
			this.RadWideDualRadioSelection_A42236Comp = (global::AcpUI.AcpLabel)target;
			return;
			IL_46C5:
			this.RTDBtnRadWideLabtoolEmergencyRevertCapable_A41918 = (global::AcpUI.AcpRtdButton)target;
			return;
			IL_46D2:
			this.RTDBtnRadWideLabtoolDeviceMgmtSeamlessUpdateGatewayHostname = (global::AcpUI.AcpRtdButton)target;
			return;
			IL_46DF:
			this.LblRadWideLabtoolEnhancedARS_A43084 = (global::AcpUI.AcpLabel)target;
			this.LblRadWideLabtoolEnhancedARS_A43084.MouseDoubleClick += new global::System.Windows.Input.MouseButtonEventHandler(this.OnFieldNameDoubleClick);
			return;
			IL_4703:
			this.RadWideTPSPTTTransmission_A41545Comp = (global::AcpUI.AcpLabel)target;
			return;
			IL_4710:
			this.CpyBtnRadWideUserInformationandCachedCredentialsUserLoginMode_41307 = (global::AcpUI.AcpCopyButton)target;
			return;
			IL_471D:
			this.RadWideGenLightBarPatternRelay1_A36506_Col = (global::Infragistics.Windows.DataPresenter.UnboundField)target;
			return;
			IL_472A:
			this.CpyBtnRadWideLabtoolTxBandSplitName_A24799 = (global::AcpUI.AcpCopyButton)target;
			return;
			IL_4737:
			this.RadWideLabtoolChannelSelectorOnSwitch_A19551 = (global::AcpUI.AcpCheckBox)target;
			this.RadWideLabtoolChannelSelectorOnSwitch_A19551.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_475B:
			this.RadWideBluetoothBluetoothReconnectTimer_A37037 = (global::AcpUI.AcpTextBoxSpinner)target;
			this.RadWideBluetoothBluetoothReconnectTimer_A37037.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_477F:
			this.CVBtnRadWideTransmitPowerLevelsBandSplitOverride_A41064 = (global::AcpUI.AcpCustomViewCheckBox)target;
			return;
			IL_478C:
			this.CVBtnRadWideLabtoolFCCNarrowBandStartFrequency_A38270 = (global::AcpUI.AcpCustomViewCheckBox)target;
			return;
			IL_4799:
			this.LblRadWideGenLightBarPatternRelay7_A36512 = (global::AcpUI.AcpLabel)target;
			this.LblRadWideGenLightBarPatternRelay7_A36512.MouseDoubleClick += new global::System.Windows.Input.MouseButtonEventHandler(this.OnFieldNameDoubleClick);
			return;
			IL_47BD:
			this.LblRadWideLabtoolEncryptedPINPassword_A41702 = (global::AcpUI.AcpLabel)target;
			this.LblRadWideLabtoolEncryptedPINPassword_A41702.MouseDoubleClick += new global::System.Windows.Input.MouseButtonEventHandler(this.OnFieldNameDoubleClick);
			return;
			IL_47E1:
			this.LblRadWideDualRadioSecRadioTransmissionCapability_A42238 = (global::AcpUI.AcpLabel)target;
			this.LblRadWideDualRadioSecRadioTransmissionCapability_A42238.MouseDoubleClick += new global::System.Windows.Input.MouseButtonEventHandler(this.OnFieldNameDoubleClick);
			return;
			IL_4805:
			this.CpyBtnRadWideTransmitPowerLevelsFrequencyRangeEndMHz_A41857 = (global::AcpUI.AcpCopyButton)target;
			return;
			IL_4812:
			this.GrpBoxExpanderRadioWideFeaturesPseudo1 = (global::AcpUI.AcpGroupBox)target;
			return;
			IL_481F:
			this.RadWideUserInformationAndPasswordsTacticalInhibitEncodePassword_A34395Comp = (global::AcpUI.AcpLabel)target;
			return;
			IL_482C:
			this.CVBtnRadWideLabtoolKeypadType_A8372 = (global::AcpUI.AcpCustomViewCheckBox)target;
			return;
			IL_4839:
			this.RTDBtnRadWideLabtoolCertMgmtMotorolaSolutionsPKIHostname = (global::AcpUI.AcpRtdButton)target;
			return;
			IL_4846:
			this.CVBtnRadWideLabtoolZoneSelectorOnSwitch_A19550 = (global::AcpUI.AcpCustomViewCheckBox)target;
			return;
			IL_4853:
			this.RadWideTransmitPowerLevelsTrkTxPowerLevelMinimumW_A41174_Col = (global::Infragistics.Windows.DataPresenter.UnboundField)target;
			return;
			IL_4860:
			this.RTDBtnRadWideDigitalAudioOptionsStrongInterference2_A9206 = (global::AcpUI.AcpRtdButton)target;
			return;
			IL_486D:
			this.RTDBtnRadErgoWideAdvancedModeSelTxName = (global::AcpUI.AcpRtdButton)target;
			return;
			IL_487A:
			this.RadioWideReqFWVersion_A42872 = (global::AcpUI.AcpTextBox)target;
			this.RadioWideReqFWVersion_A42872.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_489E:
			this.RadWideFeaturesNFPACompliant = (global::AcpUI.AcpCheckBox)target;
			this.RadWideFeaturesNFPACompliant.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_48C2:
			this.LblRadWideBluetoothLegacyBluetoothPINPairing = (global::AcpUI.AcpLabel)target;
			this.LblRadWideBluetoothLegacyBluetoothPINPairing.MouseDoubleClick += new global::System.Windows.Input.MouseButtonEventHandler(this.OnFieldNameDoubleClick);
			return;
			IL_48E6:
			this.LblRadWideBluetoothBluetoothDeviceInquiryDuration_41977 = (global::AcpUI.AcpLabel)target;
			this.LblRadWideBluetoothBluetoothDeviceInquiryDuration_41977.MouseDoubleClick += new global::System.Windows.Input.MouseButtonEventHandler(this.OnFieldNameDoubleClick);
			return;
			IL_490A:
			this.CVBtnRadWidePowerLevelBandFrequency_A41864 = (global::AcpUI.AcpCustomViewCheckBox)target;
			return;
			IL_4917:
			this.RadWideUserInformationandPasswordsTacticalServiceEncodePassword = (global::AcpUI.AcpPasswordEyeBox)target;
			this.RadWideUserInformationandPasswordsTacticalServiceEncodePassword.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_493B:
			this.CVBtnRadWideLabtoolControlHeadConfiguration_A7722 = (global::AcpUI.AcpCustomViewCheckBox)target;
			return;
			IL_4948:
			this.RTDBtnRadWideDualRadioSelection_A42236 = (global::AcpUI.AcpRtdButton)target;
			return;
			IL_4955:
			this.LblRadWideUserInformationandPasswordsMandatoryPassword_A8461 = (global::AcpUI.AcpLabel)target;
			this.LblRadWideUserInformationandPasswordsMandatoryPassword_A8461.MouseDoubleClick += new global::System.Windows.Input.MouseButtonEventHandler(this.OnFieldNameDoubleClick);
			return;
			IL_4979:
			this.RadWideLocationDisplayFormat_A41561Comp = (global::AcpUI.AcpLabel)target;
			return;
			IL_4986:
			this.RTDBtnTEN_DIGIT_RL_PSWD_capable_43711 = (global::AcpUI.AcpRtdButton)target;
			return;
			IL_4993:
			this.RadWideBluetoothLegacyBluetoothPINPairingComp = (global::AcpUI.AcpCheckBox)target;
			return;
			IL_49A0:
			this.CpyBtnRadWideTransmitPowerLevelsTxPowerLevelMinimumW_A20038 = (global::AcpUI.AcpCopyButton)target;
			return;
			IL_49AD:
			this.RTDBtnRadWideLocationGpsMode_A22627 = (global::AcpUI.AcpRtdButton)target;
			return;
			IL_49BA:
			this.CVBtnRadWideFeaturesChannelFallbackEnable = (global::AcpUI.AcpCustomViewCheckBox)target;
			return;
			IL_49C7:
			this.CpyBtnRadWideBluetoothBluetoothTones_A37035 = (global::AcpUI.AcpCopyButton)target;
			return;
			IL_49D4:
			this.RadWideAlertTonesRSMVolumeSetToneComp = (global::AcpUI.AcpLabel)target;
			return;
			IL_49E1:
			this.CVBtnRadWideUserInformationandPasswordsRadioLock_A8836 = (global::AcpUI.AcpCustomViewCheckBox)target;
			return;
			IL_49EE:
			this.RadWideFeaturesRadioCertificationType_43064Comp = (global::AcpUI.AcpLabel)target;
			return;
			IL_49FB:
			this.RadWideRadioKilled_A41559 = (global::AcpUI.AcpCheckBox)target;
			this.RadWideRadioKilled_A41559.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_4A1F:
			this.RadWideLocationUserSelectableLocationEnable_A9605Comp = (global::AcpUI.AcpCheckBox)target;
			return;
			IL_4A2C:
			this.RTDBtnRadWideLabtoolSupportO3ControlHeadPCIBit_44884 = (global::AcpUI.AcpRtdButton)target;
			return;
			IL_4A39:
			this.RadWideTransmitPowerLevelsFrequencyRangeEndMHz_A20037 = (global::AcpUI.AcpTextBox)target;
			this.RadWideTransmitPowerLevelsFrequencyRangeEndMHz_A20037.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_4A5D:
			this.RadWideFiregroundPTTTransmission_A33515Comp = (global::AcpUI.AcpLabel)target;
			return;
			IL_4A6A:
			this.RTDBtnRadWideGeneralDateFormat_A7802 = (global::AcpUI.AcpRtdButton)target;
			return;
			IL_4A77:
			this.RTDBtnRadWideReverseGeocodedLocationDisplayFormat = (global::AcpUI.AcpRtdButton)target;
			return;
			IL_4A84:
			this.CVBtnRadWideUserinfoPassRequiredForGunlock_A36531 = (global::AcpUI.AcpCustomViewCheckBox)target;
			return;
			IL_4A91:
			this.RadWideTransmitPowerLevelsFrequencyRangeEndMHz_A20037_Col = (global::Infragistics.Windows.DataPresenter.UnboundField)target;
			return;
			IL_4A9E:
			this.RadWideUserInformationandPasswordsMandatoryPassword_A8461Comp = (global::AcpUI.AcpCheckBox)target;
			return;
			IL_4AAB:
			this.CpyBtnRadWideLabtoolEncryptPassword_A41695 = (global::AcpUI.AcpCopyButton)target;
			return;
			IL_4AB8:
			this.CpyBtnRadWideLabtoolKeypadType_A8372 = (global::AcpUI.AcpCopyButton)target;
			return;
			IL_4AC5:
			this.EmergencyHotAuxMicConfigurability_A42301Comp = (global::AcpUI.AcpLabel)target;
			return;
			IL_4AD2:
			this.RadCfgLocationReporting = (global::AcpUI.AcpComboBox)target;
			this.RadCfgLocationReporting.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_4AF6:
			this.CpyBtnRadWideGenLightBarPatternRelay8_A36513 = (global::AcpUI.AcpCopyButton)target;
			return;
			IL_4B03:
			this.CpyBtnRadWideAlertTonesVolumeAdjustToneDisable = (global::AcpUI.AcpCopyButton)target;
			return;
			IL_4B10:
			this.CpyBtnRadWideFeaturesAccessoryCableConfiguration_41997 = (global::AcpUI.AcpCopyButton)target;
			return;
			IL_4B1D:
			this.CVBtnRadWideTransmitPowerLevelsFrequencyRangeEndMHz_A20037 = (global::AcpUI.AcpCustomViewCheckBox)target;
			return;
			IL_4B2A:
			this.CpyBtnRadWideLabtoolConsolidatedActionEnhancement_A43036 = (global::AcpUI.AcpCopyButton)target;
			return;
			IL_4B37:
			this.RadWideAlertTonesZeroLevelAudioMute_A9689 = (global::AcpUI.AcpCheckBox)target;
			this.RadWideAlertTonesZeroLevelAudioMute_A9689.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_4B5B:
			this.CVBtnRadWideFiregroundPTTTransmission_A33515 = (global::AcpUI.AcpCustomViewCheckBox)target;
			return;
			IL_4B68:
			this.RTDBtnRadWideLabtoolLimitedISSIDVRSOperationCapable_43045 = (global::AcpUI.AcpRtdButton)target;
			return;
			IL_4B75:
			this.LblTEN_DIGIT_RL_PSWD_capable_43711 = (global::AcpUI.AcpLabel)target;
			this.LblTEN_DIGIT_RL_PSWD_capable_43711.MouseDoubleClick += new global::System.Windows.Input.MouseButtonEventHandler(this.OnFieldNameDoubleClick);
			return;
			IL_4B99:
			this.CpyBtnRadWideAdvancedAuxPTTAudioSource_A7529 = (global::AcpUI.AcpCopyButton)target;
			return;
			IL_4BA6:
			this.RadWideFeaturePreAmpUHF_A42962Comp = (global::AcpUI.AcpCheckBox)target;
			return;
			IL_4BB3:
			this.CpyBtnRadWideLabtoolAPXDualKnobs_A42537 = (global::AcpUI.AcpCopyButton)target;
			return;
			IL_4BC0:
			this.RTDBtnRadWideLabtoolTxStartFrequencySplit_A9571 = (global::AcpUI.AcpRtdButton)target;
			return;
			IL_4BCD:
			this.RadWideGeneralASKRequired_A37152Comp = (global::AcpUI.AcpCheckBox)target;
			return;
			IL_4BDA:
			this.RTDBtnRadWideLabtoolAPXSingletoneCapable_43080 = (global::AcpUI.AcpRtdButton)target;
			return;
			IL_4BE7:
			this.LblRadWideLabtoolLimitedISSIDVRSOperationCapable_43045 = (global::AcpUI.AcpLabel)target;
			this.LblRadWideLabtoolLimitedISSIDVRSOperationCapable_43045.MouseDoubleClick += new global::System.Windows.Input.MouseButtonEventHandler(this.OnFieldNameDoubleClick);
			return;
			IL_4C0B:
			this.LblRadProfAlertTonesPowerUpSelfTestAlertTone_A8718 = (global::AcpUI.AcpLabel)target;
			this.LblRadProfAlertTonesPowerUpSelfTestAlertTone_A8718.MouseDoubleClick += new global::System.Windows.Input.MouseButtonEventHandler(this.OnFieldNameDoubleClick);
			return;
			IL_4C2F:
			this.CVBtnRadWideLabtoolAPX6000P25Radio_A42121 = (global::AcpUI.AcpCustomViewCheckBox)target;
			return;
			IL_4C3C:
			this.RadWideLabtoolTxEndFrequencySplit_A9532_Col = (global::Infragistics.Windows.DataPresenter.UnboundField)target;
			return;
			IL_4C49:
			this.CVBtnRadWideUserInformationandPasswordsUserLoginAuthenticationType_A44926 = (global::AcpUI.AcpCustomViewCheckBox)target;
			return;
			IL_4C56:
			this.ExpanderRadioWideTxFrequencySplit = (global::AcpUI.AcpExpander)target;
			return;
			IL_4C63:
			this.RadWideLabtoolDisableEncryption_43371Comp = (global::AcpUI.AcpLabel)target;
			return;
			IL_4C70:
			this.CVBtnManDownPersonalityConfigurableCapable_42082 = (global::AcpUI.AcpCustomViewCheckBox)target;
			return;
			IL_4C7D:
			this.CpyBtnRadWideLabtoolRadioReadPasswordEnable_A8869 = (global::AcpUI.AcpCopyButton)target;
			return;
			IL_4C8A:
			this.RadWideUserInformationandUserLoginUnitIDTextSize_41309 = (global::AcpUI.AcpLabel)target;
			this.RadWideUserInformationandUserLoginUnitIDTextSize_41309.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_4CAE:
			this.CpyBtnRadWideBluetoothBluetoothRSMLED_A37039 = (global::AcpUI.AcpCopyButton)target;
			return;
			IL_4CBB:
			this.RadProfAlertTonesMuteTonesOperation_A8562Comp = (global::AcpUI.AcpLabel)target;
			return;
			IL_4CC8:
			this.RTDBtnSensorEventNotificationEnable_43525 = (global::AcpUI.AcpRtdButton)target;
			return;
			IL_4CD5:
			this.LblRadWideFeatureAnalogWidebandData = (global::AcpUI.AcpLabel)target;
			this.LblRadWideFeatureAnalogWidebandData.MouseDoubleClick += new global::System.Windows.Input.MouseButtonEventHandler(this.OnFieldNameDoubleClick);
			return;
			IL_4CF9:
			this.RadWideUserInformationandPasswordsProtectedZonePassword_A8766Comp = (global::AcpUI.AcpLabel)target;
			return;
			IL_4D06:
			this.RadWideFeaturesEnableInvalidSIMNotification_A44945Comp = (global::AcpUI.AcpCheckBox)target;
			return;
			IL_4D13:
			this.ExpanderRadioWideTxFrequencySplitFPPSRecView = (global::AcpUI.AcpGroupBox)target;
			return;
			IL_4D20:
			this.RadWideGeneralProgrammingPath_44845Comp = (global::AcpUI.AcpLabel)target;
			return;
			IL_4D2D:
			this.RadWideFeaturesVirtualPartnerAudioPriorityComp = (global::AcpUI.AcpLabel)target;
			return;
			IL_4D3A:
			this.RadWideLabtoolSirenPaSystemLookup_A9143Comp = (global::AcpUI.AcpCheckBox)target;
			return;
			IL_4D47:
			this.RadWideTransmitPowerLevelsBandSplitOverride_A41064 = (global::AcpUI.AcpComboBox)target;
			this.RadWideTransmitPowerLevelsBandSplitOverride_A41064.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_4D6B:
			((global::Motorola.MackinawCPS.CoreFeatures.RadioWide.PageRadioWide)target).Loaded += this.OnLoaded;
			((global::Motorola.MackinawCPS.CoreFeatures.RadioWide.PageRadioWide)target).Unloaded += this.OnUnloaded;
			return;
			IL_4D9C:
			this.RadWideUserInformationandPasswordsSecureHardwareAutoLogin_A7508Comp = (global::AcpUI.AcpCheckBox)target;
			return;
			IL_4DA9:
			this.LblRadWideUserInformationandPasswordsSecureHardwareAutoLogin_A7508 = (global::AcpUI.AcpLabel)target;
			this.LblRadWideUserInformationandPasswordsSecureHardwareAutoLogin_A7508.MouseDoubleClick += new global::System.Windows.Input.MouseButtonEventHandler(this.OnFieldNameDoubleClick);
			return;
			IL_4DCD:
			this.RTDBtnRadProfAlertTonesPowerUpSelfTestAlertTone_A8718 = (global::AcpUI.AcpRtdButton)target;
			return;
			IL_4DDA:
			this.RTDBtnRadWideBluetoothReplacePairingInfo_A41562 = (global::AcpUI.AcpRtdButton)target;
			return;
			IL_4DE7:
			this.CVBtnRadWideLabtoolAPXSingletoneCapable_43080 = (global::AcpUI.AcpCustomViewCheckBox)target;
			return;
			IL_4DF4:
			this.RadWideDigitalAudioOptionsStrongInterference2_A9206 = (global::AcpUI.AcpCheckBox)target;
			this.RadWideDigitalAudioOptionsStrongInterference2_A9206.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_4E18:
			this.RTDBtnRadWideTransmitPowerLevelsFrequencyRangeStartMHz_A41856 = (global::AcpUI.AcpRtdButton)target;
			return;
			IL_4E25:
			this.RadWideUserinfoPassRequiredForGunlock_A36531 = (global::AcpUI.AcpCheckBox)target;
			this.RadWideUserinfoPassRequiredForGunlock_A36531.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_4E49:
			this.CVBtnRadWideBluetoothBluetoothRSMLED_A37039 = (global::AcpUI.AcpCustomViewCheckBox)target;
			return;
			IL_4E56:
			this.CpyBtnRadWideReverseGeocodedLocationDisplayFormat = (global::AcpUI.AcpCopyButton)target;
			return;
			IL_4E63:
			this.LblRadWideLocationGpsMode_A22627 = (global::AcpUI.AcpLabel)target;
			this.LblRadWideLocationGpsMode_A22627.MouseDoubleClick += new global::System.Windows.Input.MouseButtonEventHandler(this.OnFieldNameDoubleClick);
			return;
			IL_4E87:
			this.CpyBtnRadWideFeaturesChannelFallbackEnable = (global::AcpUI.AcpCopyButton)target;
			return;
			IL_4E94:
			this.LblRadWideTPSAudibleEmergencyBeaconRouting_A41972 = (global::AcpUI.AcpLabel)target;
			this.LblRadWideTPSAudibleEmergencyBeaconRouting_A41972.MouseDoubleClick += new global::System.Windows.Input.MouseButtonEventHandler(this.OnFieldNameDoubleClick);
			return;
			IL_4EB8:
			this.RadProfAlertTonesRotaryAlert_A8983 = (global::AcpUI.AcpComboBox)target;
			this.RadProfAlertTonesRotaryAlert_A8983.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_4EDC:
			this.RadWideLabtoolCertMgmtMotorolaSolutionsPKIPort = (global::AcpUI.AcpTextBoxSpinner)target;
			this.RadWideLabtoolCertMgmtMotorolaSolutionsPKIPort.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_4F00:
			this.GrpBoxExpanderRadioWideUserInformationAndPasswordsRadioLock = (global::AcpUI.AcpGroupBox)target;
			return;
			IL_4F0D:
			this.CpyBtnRadWideMPPPairingOnlyWithLTE_A42320 = (global::AcpUI.AcpCopyButton)target;
			return;
			IL_4F1A:
			this.LblRadWideLabtoolSirenAndLightsKeypadEnable_A41413 = (global::AcpUI.AcpLabel)target;
			this.LblRadWideLabtoolSirenAndLightsKeypadEnable_A41413.MouseDoubleClick += new global::System.Windows.Input.MouseButtonEventHandler(this.OnFieldNameDoubleClick);
			return;
			IL_4F3E:
			this.CVBtnRadWideBluetoothBluetoothDeviceInquiryDuration_41977 = (global::AcpUI.AcpCustomViewCheckBox)target;
			return;
			IL_4F4B:
			this.RadWideUserInformationandPasswordsSecureHardwareAutoLogin_A7508 = (global::AcpUI.AcpCheckBox)target;
			this.RadWideUserInformationandPasswordsSecureHardwareAutoLogin_A7508.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_4F6F:
			this.RadWideTransmitPowerLevelsConvTxPowerLevelMinimumW_A41173Comp = (global::AcpUI.AcpLabel)target;
			return;
			IL_4F7C:
			this.RadWideFeaturesSmartMessagingSmartMessageMode = (global::AcpUI.AcpComboBox)target;
			this.RadWideFeaturesSmartMessagingSmartMessageMode.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_4FA0:
			this.RadWideUserinfoPassRequiredForLightbar_A36532Comp = (global::AcpUI.AcpCheckBox)target;
			return;
			IL_4FAD:
			this.RadWideLabtoolDeviceMgmtSeamlessUpdateGatewayHostname = (global::AcpUI.AcpTextBox)target;
			this.RadWideLabtoolDeviceMgmtSeamlessUpdateGatewayHostname.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_4FD1:
			this.CVBtnRadWideTPSFiregroundEmergencyPTTTransmission_A33203 = (global::AcpUI.AcpCustomViewCheckBox)target;
			return;
			IL_4FDE:
			this.RadWideTPSFiregroundRespondToPolls_A33573Comp = (global::AcpUI.AcpCheckBox)target;
			return;
			IL_4FEB:
			this.LblRadWideLabtoolControlHeadSelection_A7723 = (global::AcpUI.AcpLabel)target;
			this.LblRadWideLabtoolControlHeadSelection_A7723.MouseDoubleClick += new global::System.Windows.Input.MouseButtonEventHandler(this.OnFieldNameDoubleClick);
			return;
			IL_500F:
			this.RadProfAlertTonesMuteTonesOperation_A8562 = (global::AcpUI.AcpComboBox)target;
			this.RadProfAlertTonesMuteTonesOperation_A8562.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_5033:
			this.RTDBtnRadWideGenLightBarPatternRelay7_A36512 = (global::AcpUI.AcpRtdButton)target;
			return;
			IL_5040:
			this.CVBtnRadWideLabtoolSirenAndLightsKeypadEnable_A41413 = (global::AcpUI.AcpCustomViewCheckBox)target;
			return;
			IL_504D:
			this.RTDBtnRadWideFeaturesTargetZoneOnOffHook_A42355 = (global::AcpUI.AcpRtdButton)target;
			return;
			IL_505A:
			this.RTDBtnRadWideFeaturesRotarySwitchScanPrgm_A8986 = (global::AcpUI.AcpRtdButton)target;
			return;
			IL_5067:
			this.RadWideLabtoolFCCNarrowBandStartFrequency_A38270_Col = (global::Infragistics.Windows.DataPresenter.UnboundField)target;
			return;
			IL_5074:
			this.RadWideLabtoolConsolidatedActionEnhancement_A43036 = (global::AcpUI.AcpLabel)target;
			this.RadWideLabtoolConsolidatedActionEnhancement_A43036.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_5098:
			this.CpyBtnRadWideLabtoolMFKEmergencyAccess_A42216 = (global::AcpUI.AcpCopyButton)target;
			return;
			IL_50A5:
			this.RadWideGenLightBarPatternRelay8_A36513_Col = (global::Infragistics.Windows.DataPresenter.UnboundField)target;
			return;
			IL_50B2:
			this.CVBtnRadWideTransmitPowerLevelsFrequencyRangeEndMHz_A41857 = (global::AcpUI.AcpCustomViewCheckBox)target;
			return;
			IL_50BF:
			this.CpyBtnRadWideLabtoolMultipleConversationDisable_A19552 = (global::AcpUI.AcpCopyButton)target;
			return;
			IL_50CC:
			this.RTDBtnRadWideGunlockRelocktimerTimer_A36522 = (global::AcpUI.AcpRtdButton)target;
			return;
			IL_50D9:
			this.RadWidePowerLevelBandFrequency_A41864_Col = (global::Infragistics.Windows.DataPresenter.UnboundField)target;
			return;
			IL_50E6:
			this.LblRadWideDualRadioEmergencyRadio_A42239 = (global::AcpUI.AcpLabel)target;
			this.LblRadWideDualRadioEmergencyRadio_A42239.MouseDoubleClick += new global::System.Windows.Input.MouseButtonEventHandler(this.OnFieldNameDoubleClick);
			return;
			IL_510A:
			this.LblRadWideLabtoolRxBandSplitName_A24797 = (global::AcpUI.AcpLabel)target;
			this.LblRadWideLabtoolRxBandSplitName_A24797.MouseDoubleClick += new global::System.Windows.Input.MouseButtonEventHandler(this.OnFieldNameDoubleClick);
			return;
			IL_512E:
			this.RadWideAudioOptionsSelectBluetoothMicForAuxPTTAudioSource_44819 = (global::AcpUI.AcpCheckBox)target;
			this.RadWideAudioOptionsSelectBluetoothMicForAuxPTTAudioSource_44819.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_5152:
			this.RTDBtnRadWideFeaturesNFPACompliant = (global::AcpUI.AcpRtdButton)target;
			return;
			IL_515F:
			this.RadWideBluetoothActiveRSMInternalMicIfNotBtMic_A41576Comp = (global::AcpUI.AcpCheckBox)target;
			return;
			IL_516C:
			this.RTDBtnRadWideMPPPairingOnlyWithLTE_A42320 = (global::AcpUI.AcpRtdButton)target;
			return;
			IL_5179:
			this.RadWideLabtoolArchiveReadPasswordEnable_A7462 = (global::AcpUI.AcpLabel)target;
			this.RadWideLabtoolArchiveReadPasswordEnable_A7462.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_519D:
			this.LblRadProfAlertTonesAlertTones_A7428 = (global::AcpUI.AcpLabel)target;
			this.LblRadProfAlertTonesAlertTones_A7428.MouseDoubleClick += new global::System.Windows.Input.MouseButtonEventHandler(this.OnFieldNameDoubleClick);
			return;
			IL_51C1:
			this.LblRadWideLocationLocationEnable_A8448 = (global::AcpUI.AcpLabel)target;
			this.LblRadWideLocationLocationEnable_A8448.MouseDoubleClick += new global::System.Windows.Input.MouseButtonEventHandler(this.OnFieldNameDoubleClick);
			return;
			IL_51E5:
			this.CpyBtnRadWideRxAudioControlMidrangeEqualization_A8508 = (global::AcpUI.AcpCopyButton)target;
			return;
			IL_51F2:
			this.RTDBtnRadWideDualRadioFixedRadioSwapMenu_A42241 = (global::AcpUI.AcpRtdButton)target;
			return;
			IL_51FF:
			this.CpyBtnRadWideTransmitPowerLevelsTxPowerLevelMaximumW_A20039 = (global::AcpUI.AcpCopyButton)target;
			return;
			IL_520C:
			this.CVBtnRadProfAlertTonesPowerUpSelfTestAlertTone_A8718 = (global::AcpUI.AcpCustomViewCheckBox)target;
			return;
			IL_5219:
			this.CpyBtnRadProfAlertTonesPowerUpSelfTestAlertTone_A8718 = (global::AcpUI.AcpCopyButton)target;
			return;
			IL_5226:
			this.RadWideTransmitPowerLevelsTrkTxPowerLevelLowW_A41860_Col = (global::Infragistics.Windows.DataPresenter.UnboundField)target;
			return;
			IL_5233:
			this.RadWideLabtoolAudioEnhancement_A42736Comp = (global::AcpUI.AcpLabel)target;
			return;
			IL_5240:
			this.HLinkLocation = (global::System.Windows.Documents.Hyperlink)target;
			this.HLinkLocation.Click += this.HLinkClick;
			return;
			IL_5264:
			this.RTDBtnRadProfAlertTonesEnhancedMuteTonesOperation_A42150 = (global::AcpUI.AcpRtdButton)target;
			return;
			IL_5271:
			this.RadWideUserInformationandPasswordsSoftIDUsername_A9169 = (global::AcpUI.AcpTextBox)target;
			this.RadWideUserInformationandPasswordsSoftIDUsername_A9169.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_5295:
			this.RadWideFeaturesVLIFPLOSSFIELD_A9596Comp = (global::AcpUI.AcpLabel)target;
			return;
			IL_52A2:
			this.RadWideGenLightBarPatternRelay2_A36507Comp = (global::AcpUI.AcpLabel)target;
			return;
			IL_52AF:
			this.RadCfgLocationReportingComp = (global::AcpUI.AcpLabel)target;
			return;
			IL_52BC:
			this.CpyBtnRadWideTransmitPowerLevelsTxPowerLevelLowW_A41855 = (global::AcpUI.AcpCopyButton)target;
			return;
			IL_52C9:
			this.RTDBtnTPSCapable_A42312 = (global::AcpUI.AcpRtdButton)target;
			return;
			IL_52D6:
			this.RadWideAlertTonesTxChirp_A9523 = (global::AcpUI.AcpCheckBox)target;
			this.RadWideAlertTonesTxChirp_A9523.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_52FA:
			this.RadWideUserInformationandPasswordsPIN_A8705Comp = (global::AcpUI.AcpLabel)target;
			return;
			IL_5307:
			this.RadWideGenLightBarPatternRelay8_A36513 = (global::AcpUI.AcpComboBox)target;
			this.RadWideGenLightBarPatternRelay8_A36513.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_532B:
			this.RadWideGenLgtBarName_A36505Comp = (global::AcpUI.AcpLabel)target;
			return;
			IL_5338:
			this.RadWideFeaturesRotarySwitchScanPrgm_A8986 = (global::AcpUI.AcpComboBox)target;
			this.RadWideFeaturesRotarySwitchScanPrgm_A8986.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_535C:
			this.RadWideFeatureAnalogWidebandData = (global::AcpUI.AcpCheckBox)target;
			this.RadWideFeatureAnalogWidebandData.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_5380:
			this.ExpanderRadioWideGeneralLightbarPatternSRecView = (global::AcpUI.AcpGroupBox)target;
			return;
			IL_538D:
			this.RadWideAdvancedPreAmp_A8733Comp = (global::AcpUI.AcpCheckBox)target;
			return;
			IL_539A:
			this.RadWideAlertTonesTxChirp_A9523Comp = (global::AcpUI.AcpCheckBox)target;
			return;
			IL_53A7:
			this.LblRadWideConventionalDynamicIDWithPassword_A43705 = (global::AcpUI.AcpLabel)target;
			this.LblRadWideConventionalDynamicIDWithPassword_A43705.MouseDoubleClick += new global::System.Windows.Input.MouseButtonEventHandler(this.OnFieldNameDoubleClick);
			return;
			IL_53CB:
			this.CVBtnRadWideLabtoolMFKEmergencyAccess_A42216 = (global::AcpUI.AcpCustomViewCheckBox)target;
			return;
			IL_53D8:
			this.CpyBtnRadWideLabtoolAudioEnhancement_A42736 = (global::AcpUI.AcpCopyButton)target;
			return;
			IL_53E5:
			this.RadWideLabtoolMFKEmergencyAccess_A42216 = (global::AcpUI.AcpLabel)target;
			this.RadWideLabtoolMFKEmergencyAccess_A42216.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_5409:
			this.CpyBtnRadioWideLabtoolZoneCloneCapable_43238 = (global::AcpUI.AcpCopyButton)target;
			return;
			IL_5416:
			this.CpyBtnRadWideFeaturesIgnitionAutoPoweroff_A38014 = (global::AcpUI.AcpCopyButton)target;
			return;
			IL_5423:
			this.RTDBtnToneEmergencyConfigurableCapable_42083 = (global::AcpUI.AcpRtdButton)target;
			return;
			IL_5430:
			this.RadWideLabtoolReadWriteVoiceFiles_A8893 = (global::AcpUI.AcpCheckBox)target;
			this.RadWideLabtoolReadWriteVoiceFiles_A8893.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_5454:
			this.RTDBtnRadWideBluetoothBluetoothPairingType_A37036 = (global::AcpUI.AcpRtdButton)target;
			return;
			IL_5461:
			this.RadWideBluetoothBluetoothDeviceInquiryDuration_41977Comp = (global::AcpUI.AcpLabel)target;
			return;
			IL_546E:
			this.LblRadWideTPSFiregroundEvacuationTone_A7980 = (global::AcpUI.AcpLabel)target;
			this.LblRadWideTPSFiregroundEvacuationTone_A7980.MouseDoubleClick += new global::System.Windows.Input.MouseButtonEventHandler(this.OnFieldNameDoubleClick);
			return;
			IL_5492:
			this.RadWideCombineTxWithRxFilteredAudio_44808 = (global::AcpUI.AcpCheckBox)target;
			this.RadWideCombineTxWithRxFilteredAudio_44808.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_54B6:
			this.CpyBtnRadWideLabtoolDisplayType_A7887 = (global::AcpUI.AcpCopyButton)target;
			return;
			IL_54C3:
			this.LblRadWideUserInformationandPasswordsSoftIDUsername_A9169 = (global::AcpUI.AcpLabel)target;
			this.LblRadWideUserInformationandPasswordsSoftIDUsername_A9169.MouseDoubleClick += new global::System.Windows.Input.MouseButtonEventHandler(this.OnFieldNameDoubleClick);
			return;
			IL_54E7:
			this.RadWideTransmitPowerLevelsTxPowerLevelLowW_A41855 = (global::AcpUI.AcpTextBox)target;
			this.RadWideTransmitPowerLevelsTxPowerLevelLowW_A41855.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_550B:
			this.LblGPSFailToneInterval_42329 = (global::AcpUI.AcpLabel)target;
			this.LblGPSFailToneInterval_42329.MouseDoubleClick += new global::System.Windows.Input.MouseButtonEventHandler(this.OnFieldNameDoubleClick);
			return;
			IL_552F:
			this.CVBtnRadWideLabtoolDeviceMgmtSeamlessUpdateRmPskId = (global::AcpUI.AcpCustomViewCheckBox)target;
			return;
			IL_553C:
			this.RadWideGenLgtBarName_A36505_Col = (global::Infragistics.Windows.DataPresenter.UnboundField)target;
			return;
			IL_5549:
			this.GrpBoxExpanderRadioWideDigitalAudioOptionsDigitalInboundIndicators = (global::AcpUI.AcpGroupBox)target;
			return;
			IL_5556:
			this.RadWideFeaturesVoiceAbsenceTimer_42458 = (global::AcpUI.AcpTextBoxSpinner)target;
			this.RadWideFeaturesVoiceAbsenceTimer_42458.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_557A:
			this.RTDBtnRadWideDualRadioSecRadioTransmissionCapability_A42238 = (global::AcpUI.AcpRtdButton)target;
			return;
			IL_5587:
			this.RTDBtnRadWideLabtoolSuppressEmergencyCallCapability_A42143 = (global::AcpUI.AcpRtdButton)target;
			return;
			IL_5594:
			this.LblRadioWideLabtoolEmergencyCallTermination_43348 = (global::AcpUI.AcpLabel)target;
			this.LblRadioWideLabtoolEmergencyCallTermination_43348.MouseDoubleClick += new global::System.Windows.Input.MouseButtonEventHandler(this.OnFieldNameDoubleClick);
			return;
			IL_55B8:
			this.CVRadWideGeneralTlsPskPort_44842 = (global::AcpUI.AcpCustomViewCheckBox)target;
			return;
			IL_55C5:
			this.CpyBtnRadWideTPSFiregroundPeriodicUpdateTimer_A33467 = (global::AcpUI.AcpCopyButton)target;
			return;
			IL_55D2:
			this.LblRadWideUserInformationandUserLoginUnitID_41306 = (global::AcpUI.AcpLabel)target;
			this.LblRadWideUserInformationandUserLoginUnitID_41306.MouseDoubleClick += new global::System.Windows.Input.MouseButtonEventHandler(this.OnFieldNameDoubleClick);
			return;
			IL_55F6:
			this.LblRadWideTPSFiregroundEvacuationAcknowledgement_A33216 = (global::AcpUI.AcpLabel)target;
			this.LblRadWideTPSFiregroundEvacuationAcknowledgement_A33216.MouseDoubleClick += new global::System.Windows.Input.MouseButtonEventHandler(this.OnFieldNameDoubleClick);
			return;
			IL_561A:
			this.CpyBtnRadWideGeneralASKRequired_A37152 = (global::AcpUI.AcpCopyButton)target;
			return;
			IL_5627:
			this.LblRadWideAlertTonesTxChirp_A9523 = (global::AcpUI.AcpLabel)target;
			this.LblRadWideAlertTonesTxChirp_A9523.MouseDoubleClick += new global::System.Windows.Input.MouseButtonEventHandler(this.OnFieldNameDoubleClick);
			return;
			IL_564B:
			this.CpyBtnRadWideLabtoolUltraLowPowerSoldierMacCapable_A41710 = (global::AcpUI.AcpCopyButton)target;
			return;
			IL_5658:
			this.LblRadWideGeneralASKRequired_A37152 = (global::AcpUI.AcpLabel)target;
			this.LblRadWideGeneralASKRequired_A37152.MouseDoubleClick += new global::System.Windows.Input.MouseButtonEventHandler(this.OnFieldNameDoubleClick);
			return;
			IL_567C:
			this.CVBtnRadWideLabtoolRadioWritePasswordEnable_A8889 = (global::AcpUI.AcpCustomViewCheckBox)target;
			return;
			IL_5689:
			this.CVBtnRadProfAlertTonesCallAlertToneAutoReset_A7596 = (global::AcpUI.AcpCustomViewCheckBox)target;
			return;
			IL_5696:
			this.RadWideLocationMaxStoredLocationRequests_A8473 = (global::AcpUI.AcpTextBoxSpinner)target;
			this.RadWideLocationMaxStoredLocationRequests_A8473.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_56BA:
			this.LblRadWideLabtoolMFKEmergencyAccess_A42216 = (global::AcpUI.AcpLabel)target;
			this.LblRadWideLabtoolMFKEmergencyAccess_A42216.MouseDoubleClick += new global::System.Windows.Input.MouseButtonEventHandler(this.OnFieldNameDoubleClick);
			return;
			IL_56DE:
			this.GrpBoxExpanderRadioWideFeaturesPseudo0 = (global::AcpUI.AcpGroupBox)target;
			return;
			IL_56EB:
			this.LblRadWideLabtoolFCCNarrowBandEndFrequency_A38271 = (global::AcpUI.AcpLabel)target;
			this.LblRadWideLabtoolFCCNarrowBandEndFrequency_A38271.MouseDoubleClick += new global::System.Windows.Input.MouseButtonEventHandler(this.OnFieldNameDoubleClick);
			return;
			IL_570F:
			this.CVBtnRadInfoGeneralMotorcycleRadio_A8546 = (global::AcpUI.AcpCustomViewCheckBox)target;
			return;
			IL_571C:
			this.LblRadWideAlertTonesVolumeAdjustToneOffset_A9656 = (global::AcpUI.AcpLabel)target;
			this.LblRadWideAlertTonesVolumeAdjustToneOffset_A9656.MouseDoubleClick += new global::System.Windows.Input.MouseButtonEventHandler(this.OnFieldNameDoubleClick);
			return;
			IL_5740:
			this.RadioWideReqFWVersion_A42872Comp = (global::AcpUI.AcpLabel)target;
			return;
			IL_574D:
			this.CVBtnRadWideFeaturePreAmpVHF_A42960 = (global::AcpUI.AcpCustomViewCheckBox)target;
			return;
			IL_575A:
			this.RTDBtnRadWideTransmitPowerLevelsConvTxPowerLevelMinimumW_A41863 = (global::AcpUI.AcpRtdButton)target;
			return;
			IL_5767:
			this.CpyBtnAllowPSUSecure_43809 = (global::AcpUI.AcpCopyButton)target;
			return;
			IL_5774:
			this.GrpBoxExpanderRadioWideBluetoothPseudo0 = (global::AcpUI.AcpGroupBox)target;
			return;
			IL_5781:
			this.RadWideFeaturesRecordPlaybackAudioBufferSize_A43125Comp = (global::AcpUI.AcpLabel)target;
			return;
			IL_578E:
			this.LblRadWideDigitalAudioOptionsWeakSignalFringe_A9678 = (global::AcpUI.AcpLabel)target;
			this.LblRadWideDigitalAudioOptionsWeakSignalFringe_A9678.MouseDoubleClick += new global::System.Windows.Input.MouseButtonEventHandler(this.OnFieldNameDoubleClick);
			return;
			IL_57B2:
			this.CpyBtnRadWideFeaturesRadioInhibitUIEnabled_44914 = (global::AcpUI.AcpCopyButton)target;
			return;
			IL_57BF:
			this.HLinkFireground = (global::System.Windows.Documents.Hyperlink)target;
			this.HLinkFireground.Click += this.HLinkClick;
			return;
			IL_57E3:
			this.RTDBtnRadWideAdvancedSmartLowBatteryAlert_A9165 = (global::AcpUI.AcpRtdButton)target;
			return;
			IL_57F0:
			this.LblRadWideFeaturesIgnitionAutoPoweroff_A38014 = (global::AcpUI.AcpLabel)target;
			this.LblRadWideFeaturesIgnitionAutoPoweroff_A38014.MouseDoubleClick += new global::System.Windows.Input.MouseButtonEventHandler(this.OnFieldNameDoubleClick);
			return;
			IL_5814:
			this.SwitchConventionalSwitchesPosition1_A12643Comp = (global::AcpUI.AcpLabel)target;
			return;
			IL_5821:
			this.RadWideBluetoothBluetoothEnable_A37028 = (global::AcpUI.AcpCheckBox)target;
			this.RadWideBluetoothBluetoothEnable_A37028.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_5845:
			this.RTDBtnRadWideUserInformationandCachedCredentialsUserLoginMode_41307 = (global::AcpUI.AcpRtdButton)target;
			return;
			IL_5852:
			this.CpyBtnRadWideLabtoolAnalogWideBandDataPCIBit_44885 = (global::AcpUI.AcpCopyButton)target;
			return;
			IL_585F:
			this.RadWideLabtoolFatalError_A8015Comp = (global::AcpUI.AcpCheckBox)target;
			return;
			IL_586C:
			this.RadWideDualRadioFixedRadioSwapMenu_A42241Comp = (global::AcpUI.AcpCheckBox)target;
			return;
			IL_5879:
			this.RadWideLabtoolDisableEncryption_43371 = (global::AcpUI.AcpLabel)target;
			this.RadWideLabtoolDisableEncryption_43371.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_589D:
			this.CVBtnRadWideRadioKilled_A41559 = (global::AcpUI.AcpCustomViewCheckBox)target;
			return;
			IL_58AA:
			this.LblRadWideFeaturesTargetZoneOnOffHook_A42355 = (global::AcpUI.AcpLabel)target;
			this.LblRadWideFeaturesTargetZoneOnOffHook_A42355.MouseDoubleClick += new global::System.Windows.Input.MouseButtonEventHandler(this.OnFieldNameDoubleClick);
			return;
			IL_58CE:
			this.CVBtnRadWideLabtoolConsoletteModelEnable_A7713 = (global::AcpUI.AcpCustomViewCheckBox)target;
			return;
			IL_58DB:
			this.RTDBtnRadWideGenLightBarPatternRelay10_A36516 = (global::AcpUI.AcpRtdButton)target;
			return;
			IL_58E8:
			this.RadWideRadioKilled_A41559Comp = (global::AcpUI.AcpCheckBox)target;
			return;
			IL_58F5:
			this.RecNavToolbarExpanderRadioWideRelockTimer = (global::AcpUI.AcpRecNavToolbar)target;
			this.RecNavToolbarExpanderRadioWideRelockTimer.ModeClick += this.OnModeClick;
			return;
			IL_5919:
			this.RadWideLabtoolEmergencyRevertCapable_A41918 = (global::AcpUI.AcpLabel)target;
			this.RadWideLabtoolEmergencyRevertCapable_A41918.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_593D:
			this.CVBtnRadWideGunlockRelocktimerTimer_A36522 = (global::AcpUI.AcpCustomViewCheckBox)target;
			return;
			IL_594A:
			this.RadWideRxAudioControlMidrangeEqualization_A8508Comp = (global::AcpUI.AcpCheckBox)target;
			return;
			IL_5957:
			this.MultiRadioSystemEnable_A42248 = (global::AcpUI.AcpLabel)target;
			this.MultiRadioSystemEnable_A42248.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_597B:
			this.CpyBtnRadWideLocationSystemManagedGeofence_43042 = (global::AcpUI.AcpCopyButton)target;
			return;
			IL_5988:
			this.CVBtnRadWideFeatureDynamicIcons_A42963 = (global::AcpUI.AcpCustomViewCheckBox)target;
			return;
			IL_5995:
			this.RadCfgVirtualPartnerMode = (global::AcpUI.AcpComboBox)target;
			this.RadCfgVirtualPartnerMode.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_59B9:
			this.RadWideLabtoolConsoletteModelEnable_A7713 = (global::AcpUI.AcpCheckBox)target;
			this.RadWideLabtoolConsoletteModelEnable_A7713.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_59DD:
			this.UCLContactsLimitationEnhancement_43811Comp = (global::AcpUI.AcpLabel)target;
			return;
			IL_59EA:
			this.LblRadWideTPSFiregroundEmergencyAlarmRetryRatesec_A7929 = (global::AcpUI.AcpLabel)target;
			this.LblRadWideTPSFiregroundEmergencyAlarmRetryRatesec_A7929.MouseDoubleClick += new global::System.Windows.Input.MouseButtonEventHandler(this.OnFieldNameDoubleClick);
			return;
			IL_5A0E:
			this.RadWideTPSFiregroundEmergencyPTTTransmission_A33203Comp = (global::AcpUI.AcpLabel)target;
			return;
			IL_5A1B:
			this.RadWideGeneralTimeFormat_A9377Comp = (global::AcpUI.AcpLabel)target;
			return;
			IL_5A28:
			this.RadWideLabtoolDynamicZoneCable_A41258 = (global::AcpUI.AcpLabel)target;
			this.RadWideLabtoolDynamicZoneCable_A41258.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_5A4C:
			this.RadWideLabtoolActiveMicForBTPTTCapable_43053 = (global::AcpUI.AcpLabel)target;
			this.RadWideLabtoolActiveMicForBTPTTCapable_43053.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_5A70:
			this.CVBtnRadWideFeaturesZoneCloneEnable_43130 = (global::AcpUI.AcpCustomViewCheckBox)target;
			return;
			IL_5A7D:
			this.GrpBoxExpanderRadioWideDepotPseudo0 = (global::AcpUI.AcpGroupBox)target;
			return;
			IL_5A8A:
			this.RTDBtnRadWideUserInformationandPasswordsPIN_A8705 = (global::AcpUI.AcpRtdButton)target;
			return;
			IL_5A97:
			this.TrunkingRadioInhibited_A19483 = (global::AcpUI.AcpCheckBox)target;
			this.TrunkingRadioInhibited_A19483.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_5ABB:
			this.RadWideTPSEmergencyPTTTransmission_A41544Comp = (global::AcpUI.AcpLabel)target;
			return;
			IL_5AC8:
			this.CpyBtnRadWideLabtoolActiveMicForBTPTTCapable_43053 = (global::AcpUI.AcpCopyButton)target;
			return;
			IL_5AD5:
			this.CVBtnEmergencyHotAuxMicConfigurability_A42301 = (global::AcpUI.AcpCustomViewCheckBox)target;
			return;
			IL_5AE2:
			this.CVBtnRadWideLabtoolRxStartFrequencySplit_A9032 = (global::AcpUI.AcpCustomViewCheckBox)target;
			return;
			IL_5AEF:
			this.CpyBtnRadWideDualRadioTalkgroupMuteOption_A42290 = (global::AcpUI.AcpCopyButton)target;
			return;
			IL_5AFC:
			this.RadWideTPSFiregroundPeriodicUpdateTimer_A33467 = (global::AcpUI.AcpTextBoxSpinner)target;
			this.RadWideTPSFiregroundPeriodicUpdateTimer_A33467.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_5B20:
			this.RadioWidePTTWarningToneComp = (global::AcpUI.AcpLabel)target;
			return;
			IL_5B2D:
			this.RadWideLabtoolTxBandSplitName_A24799_Col = (global::Infragistics.Windows.DataPresenter.UnboundField)target;
			return;
			IL_5B3A:
			this.RadWideTransmitPowerLevelsTxPowerLevelMaximumW_A20039Comp = (global::AcpUI.AcpLabel)target;
			return;
			IL_5B47:
			this.CpyBtnRadWideFeaturesDisplayLastAcknowledgedUserStatusorMessage_A42000 = (global::AcpUI.AcpCopyButton)target;
			return;
			IL_5B54:
			this.LblRadWideLabtoolRadioReadPasswordEnable_A8869 = (global::AcpUI.AcpLabel)target;
			this.LblRadWideLabtoolRadioReadPasswordEnable_A8869.MouseDoubleClick += new global::System.Windows.Input.MouseButtonEventHandler(this.OnFieldNameDoubleClick);
			return;
			IL_5B78:
			this.RadWideBluetoothBluetoothDiscoverableExpirationTimer_41980 = (global::AcpUI.AcpTextBoxSpinner)target;
			this.RadWideBluetoothBluetoothDiscoverableExpirationTimer_41980.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_5B9C:
			this.RTDBtnRadWideFeaturesVoiceControlPriority = (global::AcpUI.AcpRtdButton)target;
			return;
			IL_5BA9:
			this.LblRadWideUserInformationandPasswordsUserLoginAuthenticationType_A44926 = (global::AcpUI.AcpLabel)target;
			this.LblRadWideUserInformationandPasswordsUserLoginAuthenticationType_A44926.MouseDoubleClick += new global::System.Windows.Input.MouseButtonEventHandler(this.OnFieldNameDoubleClick);
			return;
			IL_5BCD:
			this.LblRadWideLabtoolDigitalAnalogBalance_A7851 = (global::AcpUI.AcpLabel)target;
			this.LblRadWideLabtoolDigitalAnalogBalance_A7851.MouseDoubleClick += new global::System.Windows.Input.MouseButtonEventHandler(this.OnFieldNameDoubleClick);
			return;
			IL_5BF1:
			this.CVBtnRadWideLabtoolEmergencyRevertCapable_A41918 = (global::AcpUI.AcpCustomViewCheckBox)target;
			return;
			IL_5BFE:
			this.CpyBtnRadProfAlertTonesEnhancedMuteTonesOperation_A42150 = (global::AcpUI.AcpCopyButton)target;
			return;
			IL_5C23:
			goto IL_BE95;
			IL_5C28:
			this.CpyBtnToneEmergencyConfigurableCapable_42083 = (global::AcpUI.AcpCopyButton)target;
			return;
			IL_5C35:
			this.RTDBtnRadWideGeneralDnsSdAddress_44843 = (global::AcpUI.AcpRtdButton)target;
			return;
			IL_5C42:
			this.CVBtnRadWideLabtoolDisableEncryption_43371 = (global::AcpUI.AcpCustomViewCheckBox)target;
			return;
			IL_5C4F:
			this.RTDBtnRadWideBluetoothActiveRSMInternalMicIfNotBtMic_A41576 = (global::AcpUI.AcpRtdButton)target;
			return;
			IL_5C5C:
			this.RTDBtnRadWideLabtoolSirenPaSystemLookup_A9143 = (global::AcpUI.AcpRtdButton)target;
			return;
			IL_5C69:
			this.RadWideTransmitPowerLevelsTxPowerLevelMinimumW_A20038Comp = (global::AcpUI.AcpLabel)target;
			return;
			IL_5C76:
			this.RTDBtnRadWideTransmitPowerLevelsBandSplitOverride_A41064 = (global::AcpUI.AcpRtdButton)target;
			return;
			IL_5C83:
			this.RadProfAlertTonesStandbyChirpsec_A9179 = (global::AcpUI.AcpTextBoxSpinner)target;
			this.RadProfAlertTonesStandbyChirpsec_A9179.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_5CA7:
			this.RTDBtnRadWideLabtoolFCCNarrowBandEndFrequency_A38271 = (global::AcpUI.AcpRtdButton)target;
			return;
			IL_5CB4:
			this.RTDBtnMARVELL_DNP_43591 = (global::AcpUI.AcpRtdButton)target;
			return;
			IL_5CC1:
			this.RTDBtnAllowPSUSecure_43809 = (global::AcpUI.AcpRtdButton)target;
			return;
			IL_5CCE:
			this.RTDBtnAdvancedAuxTransmitSensitivity_A7530 = (global::AcpUI.AcpRtdButton)target;
			return;
			IL_5CDB:
			this.LblRadWideBluetoothBluetoothRSMLED_A37039 = (global::AcpUI.AcpLabel)target;
			this.LblRadWideBluetoothBluetoothRSMLED_A37039.MouseDoubleClick += new global::System.Windows.Input.MouseButtonEventHandler(this.OnFieldNameDoubleClick);
			return;
			IL_5CFF:
			this.RTDBtnRadWideGeneralProgrammingPath_44845 = (global::AcpUI.AcpRtdButton)target;
			return;
			IL_5D0C:
			this.LblRadWideUserInformationandPINPassword_41303 = (global::AcpUI.AcpLabel)target;
			this.LblRadWideUserInformationandPINPassword_41303.MouseDoubleClick += new global::System.Windows.Input.MouseButtonEventHandler(this.OnFieldNameDoubleClick);
			return;
			IL_5D30:
			this.LblAllowPSUSecure_43809 = (global::AcpUI.AcpLabel)target;
			this.LblAllowPSUSecure_43809.MouseDoubleClick += new global::System.Windows.Input.MouseButtonEventHandler(this.OnFieldNameDoubleClick);
			return;
			IL_5D54:
			this.CVBtnRadProfAlertTonesNewMuteTonesOperation_A42149 = (global::AcpUI.AcpCustomViewCheckBox)target;
			return;
			IL_5D61:
			this.RadWideLabtoolEnhancedARS_A43084 = (global::AcpUI.AcpLabel)target;
			this.RadWideLabtoolEnhancedARS_A43084.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_5D85:
			this.RadWideLabtoolControlHeadConfiguration_A7722 = (global::AcpUI.AcpCheckBox)target;
			this.RadWideLabtoolControlHeadConfiguration_A7722.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_5DA9:
			this.SwitchConventionalSwitchesPosition1_A12643 = (global::AcpUI.AcpComboBox)target;
			this.SwitchConventionalSwitchesPosition1_A12643.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_5DCD:
			this.CVBtnRadWideFeaturesRadioInhibitUIEnabled_44914 = (global::AcpUI.AcpCustomViewCheckBox)target;
			return;
			IL_5DDA:
			this.CpyBtnRadWideLabtoolAudibleBeaconRoutingCapable_A41974 = (global::AcpUI.AcpCopyButton)target;
			return;
			IL_5DE7:
			this.CpyBtnIsolatedGCAIAccessoryPlugAndPlayDisable_42927 = (global::AcpUI.AcpCopyButton)target;
			return;
			IL_5DF4:
			this.LblRadWideLabtoolFreeRevolvingRotary_A8147 = (global::AcpUI.AcpLabel)target;
			this.LblRadWideLabtoolFreeRevolvingRotary_A8147.MouseDoubleClick += new global::System.Windows.Input.MouseButtonEventHandler(this.OnFieldNameDoubleClick);
			return;
			IL_5E18:
			this.CVBtnRadWideLabtoolEarlyWarningBatteryThreshold_A23977 = (global::AcpUI.AcpCustomViewCheckBox)target;
			return;
			IL_5E25:
			this.LblRadWideGeneralDateFormat_A7802 = (global::AcpUI.AcpLabel)target;
			this.LblRadWideGeneralDateFormat_A7802.MouseDoubleClick += new global::System.Windows.Input.MouseButtonEventHandler(this.OnFieldNameDoubleClick);
			return;
			IL_5E49:
			this.GrpBoxExpanderRadioWideLabtoolCertificateManagement = (global::AcpUI.AcpGroupBox)target;
			return;
			IL_5E56:
			this.LblRadWideUserInformationandCachedCredentialsUserLoginMode_41307 = (global::AcpUI.AcpLabel)target;
			this.LblRadWideUserInformationandCachedCredentialsUserLoginMode_41307.MouseDoubleClick += new global::System.Windows.Input.MouseButtonEventHandler(this.OnFieldNameDoubleClick);
			return;
			IL_5E7A:
			this.RTDBtnSwitchConventionalSwitchesPosition1_A12643 = (global::AcpUI.AcpRtdButton)target;
			return;
			IL_5E87:
			this.RTDBtnRadWideDigitalAudioOptionsStrongInterference1_A9207 = (global::AcpUI.AcpRtdButton)target;
			return;
			IL_5E94:
			this.GrpBoxExpanderRadioWideFiregroundPseudo1 = (global::AcpUI.AcpGroupBox)target;
			return;
			IL_5EA1:
			this.LblRadWideLabtoolCertMgmtMotorolaSolutionsPKIPort = (global::AcpUI.AcpLabel)target;
			this.LblRadWideLabtoolCertMgmtMotorolaSolutionsPKIPort.MouseDoubleClick += new global::System.Windows.Input.MouseButtonEventHandler(this.OnFieldNameDoubleClick);
			return;
			IL_5EC5:
			this.CVBtnRadWideLabtoolSirenPaFatalError_A9141 = (global::AcpUI.AcpCustomViewCheckBox)target;
			return;
			IL_5ED2:
			this.CpyBtnZnChanCfgFPPProtectionFPPEnable_A8142 = (global::AcpUI.AcpCopyButton)target;
			return;
			IL_5EDF:
			this.CVBtnRadWideLabtoolAPXDualKnobs_A42537 = (global::AcpUI.AcpCustomViewCheckBox)target;
			return;
			IL_5EEC:
			this.CpyBtnRadWideAlertTonesVolumeAdjustToneOffset_A9656 = (global::AcpUI.AcpCopyButton)target;
			return;
			IL_5EF9:
			this.RadWideLabtoolAPXDualKnobs_A42537 = (global::AcpUI.AcpLabel)target;
			this.RadWideLabtoolAPXDualKnobs_A42537.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_5F1D:
			this.LblRadioWideReqFWVersion_A42872 = (global::AcpUI.AcpLabel)target;
			this.LblRadioWideReqFWVersion_A42872.MouseDoubleClick += new global::System.Windows.Input.MouseButtonEventHandler(this.OnFieldNameDoubleClick);
			return;
			IL_5F41:
			this.RTDBtnRadProfAlertTonesRotaryAlert_A8983 = (global::AcpUI.AcpRtdButton)target;
			return;
			IL_5F4E:
			this.CVBtnRadWideLocationExitLocationMenuonPTT_A13081 = (global::AcpUI.AcpCustomViewCheckBox)target;
			return;
			IL_5F5B:
			this.RadWideFeaturesRecordPlaybackAudioBufferSize_A43125 = (global::AcpUI.AcpTextBoxSpinner)target;
			this.RadWideFeaturesRecordPlaybackAudioBufferSize_A43125.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_5F7F:
			this.CVBtnRadWideFeaturesBlockPendingCAPC_A7564 = (global::AcpUI.AcpCustomViewCheckBox)target;
			return;
			IL_5F8C:
			this.RadioWideLabtoolExtendedPLToneSet_43769Comp = (global::AcpUI.AcpLabel)target;
			return;
			IL_5F99:
			this.RTDBtnRadWideUserInformationandPasswordsMaximumPasswordLength_A8477 = (global::AcpUI.AcpRtdButton)target;
			return;
			IL_5FA6:
			this.LblRadWideGenLightBarPatternRelay3_A36508 = (global::AcpUI.AcpLabel)target;
			this.LblRadWideGenLightBarPatternRelay3_A36508.MouseDoubleClick += new global::System.Windows.Input.MouseButtonEventHandler(this.OnFieldNameDoubleClick);
			return;
			IL_5FCA:
			this.RadWideGeneralTlsPskPort_44842 = (global::AcpUI.AcpTextBoxSpinner)target;
			this.RadWideGeneralTlsPskPort_44842.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_5FEE:
			this.RTDBtnRadWideTPSFiregroundEvacuationAcknowledgement_A33216 = (global::AcpUI.AcpRtdButton)target;
			return;
			IL_5FFB:
			this.RTDBtnRadWideBluetoothFriendlyNameEditable_A41182 = (global::AcpUI.AcpRtdButton)target;
			return;
			IL_6008:
			this.CVBtnRadWidePAACKAlertsonPTT_A43099 = (global::AcpUI.AcpCustomViewCheckBox)target;
			return;
			IL_6015:
			this.ExpanderRadioWideLocation = (global::AcpUI.AcpExpander)target;
			return;
			IL_6022:
			this.CpyBtnRadWideGeneralTlsPskPort_44842 = (global::AcpUI.AcpCopyButton)target;
			return;
			IL_602F:
			this.LblRadWidePowerLevelBandFrequency_A41864 = (global::AcpUI.AcpLabel)target;
			this.LblRadWidePowerLevelBandFrequency_A41864.MouseDoubleClick += new global::System.Windows.Input.MouseButtonEventHandler(this.OnFieldNameDoubleClick);
			return;
			IL_6053:
			this.RTDBtnRadWideGeneralOwnerAdvancedKeyType_A38663 = (global::AcpUI.AcpRtdButton)target;
			return;
			IL_6060:
			this.RadWideLabtoolSeamlessUpdateOutOfBoxExperienceComp = (global::AcpUI.AcpLabel)target;
			return;
			IL_606D:
			this.RTDBtnRadWideGenLightBarPatternRelay4_A36509 = (global::AcpUI.AcpRtdButton)target;
			return;
			IL_607A:
			this.HLinkSensor = (global::System.Windows.Documents.Hyperlink)target;
			this.HLinkSensor.Click += this.HLinkClick;
			return;
			IL_609E:
			this.LblTrunkingRadioInhibited_A19483 = (global::AcpUI.AcpLabel)target;
			this.LblTrunkingRadioInhibited_A19483.MouseDoubleClick += new global::System.Windows.Input.MouseButtonEventHandler(this.OnFieldNameDoubleClick);
			return;
			IL_60C2:
			this.CpyBtnRadWideUserInformationandPasswordsSoftIDUsernameDisplayTextSize_A23453 = (global::AcpUI.AcpCopyButton)target;
			return;
			IL_60CF:
			this.RadWideLabtoolADPGatingPCIBit_44813 = (global::AcpUI.AcpLabel)target;
			this.RadWideLabtoolADPGatingPCIBit_44813.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_60F3:
			this.RTDBtnRadWideLabtoolControlHeadSelection_A7723 = (global::AcpUI.AcpRtdButton)target;
			return;
			IL_6100:
			this.ExpanderRadioWideTxPowerLevelsByFrequencyRangeNewBandPlan = (global::AcpUI.AcpXamDataPresenter)target;
			return;
			IL_610D:
			this.RadWideAlertTonesVolumeAdjustToneOffset_A9656 = (global::AcpUI.AcpCheckBox)target;
			this.RadWideAlertTonesVolumeAdjustToneOffset_A9656.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_6131:
			this.RTDBtnPASSAlarmFilterCapable_A42387 = (global::AcpUI.AcpRtdButton)target;
			return;
			IL_613E:
			this.RadWideUserinfoPassRequiredForGunlock_A36531Comp = (global::AcpUI.AcpCheckBox)target;
			return;
			IL_614B:
			this.RadWideDualRadioCrossBandMuteOption_A42240 = (global::AcpUI.AcpCheckBox)target;
			this.RadWideDualRadioCrossBandMuteOption_A42240.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_616F:
			this.RTDBtnRadWideLabtoolDeviceMgmtSeamlessUpdateRmPskId = (global::AcpUI.AcpRtdButton)target;
			return;
			IL_617C:
			this.GrpBoxExpanderRadioWideLightbarPatternPseudo0 = (global::AcpUI.AcpGroupBox)target;
			return;
			IL_6189:
			this.RTDBtnRadWideTxPowerLevelsNewBandPlan78MHzBandSelection_A41851 = (global::AcpUI.AcpRtdButton)target;
			return;
			IL_6196:
			this.RadWideUserInformationandPasswordsRadioLockRadioInhibitOnDeadlock_A3584Comp = (global::AcpUI.AcpCheckBox)target;
			return;
			IL_61A3:
			this.RadWideGeneralTlsPskPort_44842Comp = (global::AcpUI.AcpLabel)target;
			return;
			IL_61B0:
			this.LblRadWideGeneralDnsSdAddress_44843 = (global::AcpUI.AcpLabel)target;
			this.LblRadWideGeneralDnsSdAddress_44843.MouseDoubleClick += new global::System.Windows.Input.MouseButtonEventHandler(this.OnFieldNameDoubleClick);
			return;
			IL_61D4:
			this.RadWideAdvancedRecordAudio_A8922 = (global::AcpUI.AcpComboBox)target;
			this.RadWideAdvancedRecordAudio_A8922.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_61F8:
			this.CVBtnTrunkingRadioInhibited_A19483 = (global::AcpUI.AcpCustomViewCheckBox)target;
			return;
			IL_6205:
			this.ExpanderRadioWideDigitalAudioOptions = (global::AcpUI.AcpExpander)target;
			return;
			IL_6212:
			this.CpyBtnMARVELL_DNP_43591 = (global::AcpUI.AcpCopyButton)target;
			return;
			IL_621F:
			this.CVBtnRadWideAlertTonesRSMVolumeSetTone = (global::AcpUI.AcpCustomViewCheckBox)target;
			return;
			IL_622C:
			this.CVBtnRadWideLabtoolConsolidatedActionEnhancement_A43036 = (global::AcpUI.AcpCustomViewCheckBox)target;
			return;
			IL_6239:
			this.CpyBtnRadWideGeneralDnsSdPort_44844 = (global::AcpUI.AcpCopyButton)target;
			return;
			IL_6246:
			this.CVBtnRadWideUserInformationandPINPassword_41303 = (global::AcpUI.AcpCustomViewCheckBox)target;
			return;
			IL_6253:
			this.RadWideBluetoothBluetoothRSMLED_A37039Comp = (global::AcpUI.AcpCheckBox)target;
			return;
			IL_6260:
			this.LblRadWideAudioConfigurationLevel_42740 = (global::AcpUI.AcpLabel)target;
			this.LblRadWideAudioConfigurationLevel_42740.MouseDoubleClick += new global::System.Windows.Input.MouseButtonEventHandler(this.OnFieldNameDoubleClick);
			return;
			IL_6284:
			this.CVBtnSwitchConventionalSwitchesPosition1_A12643 = (global::AcpUI.AcpCustomViewCheckBox)target;
			return;
			IL_6291:
			this.RadWideLabtoolFCCNarrowBandEndFrequency_A38271_Col = (global::Infragistics.Windows.DataPresenter.UnboundField)target;
			return;
			IL_629E:
			this.RadWideLabtoolAPXDualKnobs_A42537Comp = (global::AcpUI.AcpLabel)target;
			return;
			IL_62AB:
			this.CpyBtnMultiRadioSystemEnable_A42248 = (global::AcpUI.AcpCopyButton)target;
			return;
			IL_62B8:
			this.LblRadWideGeneralProgrammingPath_44845 = (global::AcpUI.AcpLabel)target;
			this.LblRadWideGeneralProgrammingPath_44845.MouseDoubleClick += new global::System.Windows.Input.MouseButtonEventHandler(this.OnFieldNameDoubleClick);
			return;
			IL_62DC:
			this.RadioWideLabtoolZoneCloneCapable_43238Comp = (global::AcpUI.AcpLabel)target;
			return;
			IL_62E9:
			this.RadWideLabtoolIndirectPTTAudioRoutingPCI_44817Comp = (global::AcpUI.AcpLabel)target;
			return;
			IL_62F6:
			this.RadWideTPSPTTTransmission_A41545 = (global::AcpUI.AcpComboBox)target;
			this.RadWideTPSPTTTransmission_A41545.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_631A:
			this.RadWideLabtoolMFKEmergencyAccess_A42216Comp = (global::AcpUI.AcpLabel)target;
			return;
			IL_6327:
			this.LblRadWideAdvancedRecordAudio_A8922 = (global::AcpUI.AcpLabel)target;
			this.LblRadWideAdvancedRecordAudio_A8922.MouseDoubleClick += new global::System.Windows.Input.MouseButtonEventHandler(this.OnFieldNameDoubleClick);
			return;
			IL_634B:
			this.CpyBtnRadWideBluetoothLegacyBluetoothPINPairing = (global::AcpUI.AcpCopyButton)target;
			return;
			IL_6358:
			this.RTDBtnEmergencyHotAuxMicConfigurability_A42301 = (global::AcpUI.AcpRtdButton)target;
			return;
			IL_6365:
			this.LblRadCfgVirtualPartnerMode = (global::AcpUI.AcpLabel)target;
			this.LblRadCfgVirtualPartnerMode.MouseDoubleClick += new global::System.Windows.Input.MouseButtonEventHandler(this.OnFieldNameDoubleClick);
			return;
			IL_6389:
			this.CpyBtnManDownPersonalityConfigurableCapable_42082 = (global::AcpUI.AcpCopyButton)target;
			return;
			IL_6396:
			this.RadWideFeaturesRotarySwitchScanPrgm_A8986Comp = (global::AcpUI.AcpLabel)target;
			return;
			IL_63A3:
			this.RadWideDualRadioEmergencyRadio_A42239Comp = (global::AcpUI.AcpLabel)target;
			return;
			IL_63B0:
			this.RTDBtnRadWideBluetoothBluetoothDiscoverableExpirationTimer_41980 = (global::AcpUI.AcpRtdButton)target;
			return;
			IL_63BD:
			this.RadWideLabtoolSirenAndLightsKeypadEnable_A41413Comp = (global::AcpUI.AcpLabel)target;
			return;
			IL_63CA:
			this.LblRadWideGenLightBarPatternRelay9_A36515 = (global::AcpUI.AcpLabel)target;
			this.LblRadWideGenLightBarPatternRelay9_A36515.MouseDoubleClick += new global::System.Windows.Input.MouseButtonEventHandler(this.OnFieldNameDoubleClick);
			return;
			IL_63EE:
			this.RadWideDigitalAudioOptionsStrongInterference2_A9206Comp = (global::AcpUI.AcpCheckBox)target;
			return;
			IL_63FB:
			this.LblRadProfAlertTonesStandbyChirpsec_A9179 = (global::AcpUI.AcpLabel)target;
			this.LblRadProfAlertTonesStandbyChirpsec_A9179.MouseDoubleClick += new global::System.Windows.Input.MouseButtonEventHandler(this.OnFieldNameDoubleClick);
			return;
			IL_641F:
			this.CVBtnRadWideTransmitPowerLevelsTrkTxPowerLevelMinimumW_A41862 = (global::AcpUI.AcpCustomViewCheckBox)target;
			return;
			IL_642C:
			this.CVBtnRadWideTransmitPowerLevelsTxPowerLevelMinimumW_A41858 = (global::AcpUI.AcpCustomViewCheckBox)target;
			return;
			IL_6439:
			this.CpyBtnRadWideFeaturesRadioCertificationType_43064 = (global::AcpUI.AcpCopyButton)target;
			return;
			IL_6446:
			this.RTDBtnRadWideLabtoolFreeRevolvingRotary_A8147 = (global::AcpUI.AcpRtdButton)target;
			return;
			IL_6453:
			this.RTDBtnRadWideBluetoothBluetoothEnable_A37028 = (global::AcpUI.AcpRtdButton)target;
			return;
			IL_6460:
			this.RadWideLabtoolTxEndFrequencySplit_A9532Comp = (global::AcpUI.AcpLabel)target;
			return;
			IL_646D:
			this.CVBtnRadWideLabtoolPAAlertCapability_A42944 = (global::AcpUI.AcpCustomViewCheckBox)target;
			return;
			IL_647A:
			this.CpyBtnRadWideTransmitPowerLevelsTrkTxPowerLevelLowW_A41860 = (global::AcpUI.AcpCopyButton)target;
			return;
			IL_6487:
			this.RadProfAlertTonesNewMuteTonesOperation_A42149Comp = (global::AcpUI.AcpLabel)target;
			return;
			IL_6494:
			this.LblRadWideBluetoothImproveAudioLatency_A44943 = (global::AcpUI.AcpLabel)target;
			this.LblRadWideBluetoothImproveAudioLatency_A44943.MouseDoubleClick += new global::System.Windows.Input.MouseButtonEventHandler(this.OnFieldNameDoubleClick);
			return;
			IL_64B8:
			this.SensorEventNotificationEnable_43525Comp = (global::AcpUI.AcpCheckBox)target;
			return;
			IL_64C5:
			this.RadWideAdvancedRFModem_A8972Comp = (global::AcpUI.AcpLabel)target;
			return;
			IL_64D2:
			this.CVBtnRadWideFeaturesEnableInvalidSIMNotification_A44945 = (global::AcpUI.AcpCustomViewCheckBox)target;
			return;
			IL_64DF:
			this.RTDBtnRadWideFeaturePreAmpVHF_A42960 = (global::AcpUI.AcpRtdButton)target;
			return;
			IL_64EC:
			this.CVBtnRadWideAudioOptionsSelectBluetoothMicForAuxPTTAudioSource_44819 = (global::AcpUI.AcpCustomViewCheckBox)target;
			return;
			IL_64F9:
			this.RTDBtnRadWideLabtoolRCLastJobSetUUID = (global::AcpUI.AcpRtdButton)target;
			return;
			IL_6506:
			this.RTDBtnRadioWideReqFWVersion_A42872 = (global::AcpUI.AcpRtdButton)target;
			return;
			IL_6513:
			this.RadWideFeaturesAccessoryCableConfiguration_41997Comp = (global::AcpUI.AcpLabel)target;
			return;
			IL_6520:
			this.RadWideGeneralOwnerSystemID_A37153 = (global::AcpUI.AcpTextBoxSpinnerDecHex)target;
			this.RadWideGeneralOwnerSystemID_A37153.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_6544:
			this.CVBtnRadWideGenLightBarPatternRelay6_A36511 = (global::AcpUI.AcpCustomViewCheckBox)target;
			return;
			IL_6551:
			this.RTDBtnRadWideLabtoolAPXDualKnobs_A42537 = (global::AcpUI.AcpRtdButton)target;
			return;
			IL_655E:
			this.RadCfgVirtualPartnerInactivityTime = (global::AcpUI.AcpTextBoxSpinner)target;
			this.RadCfgVirtualPartnerInactivityTime.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_6582:
			this.CVBtnRadWideLabtoolFreeRevolvingRotary_A8147 = (global::AcpUI.AcpCustomViewCheckBox)target;
			return;
			IL_658F:
			this.RadWideFeaturesVirtualPartnerAudioPriority = (global::AcpUI.AcpComboBox)target;
			this.RadWideFeaturesVirtualPartnerAudioPriority.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_65B3:
			this.RadWideLocationDisplayFormat_A41561 = (global::AcpUI.AcpComboBox)target;
			this.RadWideLocationDisplayFormat_A41561.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_65D7:
			this.ExpanderRadioWideTxPowerLevelsNewBandPlan = (global::AcpUI.AcpExpander)target;
			return;
			IL_65E4:
			this.CVBtnRadWideTransmitPowerLevelsTrkTxPowerLevelLowW_A41860 = (global::AcpUI.AcpCustomViewCheckBox)target;
			return;
			IL_65F1:
			this.RadWideMPPPairingOnlyWithLTE_A42320Comp = (global::AcpUI.AcpLabel)target;
			return;
			IL_65FE:
			this.RTDBtnRadWideLabtoolSmartLowBatteryThreshold_A20201 = (global::AcpUI.AcpRtdButton)target;
			return;
			IL_660B:
			this.LblRadWideUserInformationandPasswordsProtectedZonePassword_A8766 = (global::AcpUI.AcpLabel)target;
			this.LblRadWideUserInformationandPasswordsProtectedZonePassword_A8766.MouseDoubleClick += new global::System.Windows.Input.MouseButtonEventHandler(this.OnFieldNameDoubleClick);
			return;
			IL_662F:
			this.RadWideFeaturesZoneCloneEnable_43130Comp = (global::AcpUI.AcpCheckBox)target;
			return;
			IL_663C:
			this.GrpBoxExpanderRadioWideTransmitPowerLevelsPseudo0 = (global::AcpUI.AcpGroupBox)target;
			return;
			IL_6649:
			this.RTDBtnRadWideFeatureDynamicIcons_A42963 = (global::AcpUI.AcpRtdButton)target;
			return;
			IL_6656:
			this.CpyBtnRadWideFeaturesSmartMessagingSmartMessageMode = (global::AcpUI.AcpCopyButton)target;
			return;
			IL_6663:
			this.LblRadWideBluetoothBluetoothPairingType_A37036 = (global::AcpUI.AcpLabel)target;
			this.LblRadWideBluetoothBluetoothPairingType_A37036.MouseDoubleClick += new global::System.Windows.Input.MouseButtonEventHandler(this.OnFieldNameDoubleClick);
			return;
			IL_6687:
			this.RadProfAlertTonesRotaryAlert_A8983Comp = (global::AcpUI.AcpLabel)target;
			return;
			IL_6694:
			this.RTDBtnRadWideTPSFiregroundRespondToPolls_A33573 = (global::AcpUI.AcpRtdButton)target;
			return;
			IL_66A1:
			this.RadWideTPSFiregroundVoiceTxEndTone_A9655 = (global::AcpUI.AcpCheckBox)target;
			this.RadWideTPSFiregroundVoiceTxEndTone_A9655.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_66C5:
			this.CVBtnRadWideLocationGpsMode_A22627 = (global::AcpUI.AcpCustomViewCheckBox)target;
			return;
			IL_66D2:
			this.RTDBtnRadWideFeaturesRadioCertificationType_43064 = (global::AcpUI.AcpRtdButton)target;
			return;
			IL_66DF:
			this.CpyBtnRadWideGeneralPskId_44840 = (global::AcpUI.AcpCopyButton)target;
			return;
			IL_66EC:
			this.RadInfoGeneralMotorcycleRadio_A8546 = (global::AcpUI.AcpLabel)target;
			this.RadInfoGeneralMotorcycleRadio_A8546.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_6710:
			this.LblRadWideLabtoolSmartLowBatteryThreshold_A20201 = (global::AcpUI.AcpLabel)target;
			this.LblRadWideLabtoolSmartLowBatteryThreshold_A20201.MouseDoubleClick += new global::System.Windows.Input.MouseButtonEventHandler(this.OnFieldNameDoubleClick);
			return;
			IL_6734:
			this.RadWideTransmitPowerLevelsTxPowerLevelHighW_A8152 = (global::AcpUI.AcpTextBox)target;
			this.RadWideTransmitPowerLevelsTxPowerLevelHighW_A8152.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_6758:
			this.CVBtnRadWideBluetoothAudioBackwardsCompatibility_A44942 = (global::AcpUI.AcpCustomViewCheckBox)target;
			return;
			IL_6765:
			this.CVBtnRadWideLabtoolTxStartFrequencySplit_A9571 = (global::AcpUI.AcpCustomViewCheckBox)target;
			return;
			IL_6772:
			this.RadWideLabtoolAnalogWideBandDataPCIBit_44885 = (global::AcpUI.AcpLabel)target;
			this.RadWideLabtoolAnalogWideBandDataPCIBit_44885.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_6796:
			this.CpyBtnRadWideLabtoolRxStartFrequencySplit_A9032 = (global::AcpUI.AcpCopyButton)target;
			return;
			IL_67A3:
			this.RadWideLabtoolRadioPassword_A8837Comp = (global::AcpUI.AcpLabel)target;
			return;
			IL_67B0:
			this.CpyBtnRadWideDualRadioCrossBandMuteOption_A42240 = (global::AcpUI.AcpCopyButton)target;
			return;
			IL_67BD:
			this.LblRadioWideDVRSTrunkingStatusCapability_A42772 = (global::AcpUI.AcpLabel)target;
			this.LblRadioWideDVRSTrunkingStatusCapability_A42772.MouseDoubleClick += new global::System.Windows.Input.MouseButtonEventHandler(this.OnFieldNameDoubleClick);
			return;
			IL_67E1:
			this.RadWideTransmitPowerLevelsConvTxPowerLevelLowW_A41861 = (global::AcpUI.AcpTextBox)target;
			this.RadWideTransmitPowerLevelsConvTxPowerLevelLowW_A41861.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_6805:
			this.RadWideLabtoolFCCNarrowBandEndFrequency_A38271 = (global::AcpUI.AcpTextBox)target;
			this.RadWideLabtoolFCCNarrowBandEndFrequency_A38271.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_6829:
			this.RTDBtnRadWideBluetoothImproveAudioLatency_A44943 = (global::AcpUI.AcpRtdButton)target;
			return;
			IL_6836:
			this.ZnChanCfgFPPProtectionFPPEnable_A8142 = (global::AcpUI.AcpCheckBox)target;
			this.ZnChanCfgFPPProtectionFPPEnable_A8142.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_685A:
			this.RTDBtnRadWideUserInformationandPasswordsSecureHardwareAutoLogin_A7508 = (global::AcpUI.AcpRtdButton)target;
			return;
			IL_6867:
			this.CVBtnRadWideBluetoothFriendlyNameEditable_A41182 = (global::AcpUI.AcpCustomViewCheckBox)target;
			return;
			IL_6874:
			this.RadWideLabtoolDeviceMgmtSeamlessUpdateGatewayHostnameComp = (global::AcpUI.AcpLabel)target;
			return;
			IL_6881:
			this.LblRadWideDigitalAudioOptionsStrongInterference1_A9207 = (global::AcpUI.AcpLabel)target;
			this.LblRadWideDigitalAudioOptionsStrongInterference1_A9207.MouseDoubleClick += new global::System.Windows.Input.MouseButtonEventHandler(this.OnFieldNameDoubleClick);
			return;
			IL_68A5:
			this.CVBtnRadWideUserInformationandPasswordsRadioLockRadioInhibitOnDeadlock_A3584 = (global::AcpUI.AcpCustomViewCheckBox)target;
			return;
			IL_68B2:
			this.RadWideAlertTonesVolumeAdjustToneDisable = (global::AcpUI.AcpCheckBox)target;
			this.RadWideAlertTonesVolumeAdjustToneDisable.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_68D6:
			this.LblRadWideUserInformationandPasswordsRadioLockAttemptsAllowed_A3582 = (global::AcpUI.AcpLabel)target;
			this.LblRadWideUserInformationandPasswordsRadioLockAttemptsAllowed_A3582.MouseDoubleClick += new global::System.Windows.Input.MouseButtonEventHandler(this.OnFieldNameDoubleClick);
			return;
			IL_68FA:
			this.CVBtnRadWideLabtoolFatalError_A8015 = (global::AcpUI.AcpCustomViewCheckBox)target;
			return;
			IL_6907:
			this.CpyBtnRadWideLabtoolIntelligentPriorityScanCapable_43411 = (global::AcpUI.AcpCopyButton)target;
			return;
			IL_6914:
			this.LblRadWideTransmitPowerLevelsTxPowerLevelMaximumW_A20039 = (global::AcpUI.AcpLabel)target;
			this.LblRadWideTransmitPowerLevelsTxPowerLevelMaximumW_A20039.MouseDoubleClick += new global::System.Windows.Input.MouseButtonEventHandler(this.OnFieldNameDoubleClick);
			return;
			IL_6938:
			this.CpyBtnRadWideTransmitPowerLevelsConvTxPowerLevelLowW_A41861 = (global::AcpUI.AcpCopyButton)target;
			return;
			IL_6945:
			this.CpyBtnRadWideLabtoolDeviceMgmtSeamlessUpdateGatewayHostname = (global::AcpUI.AcpCopyButton)target;
			return;
			IL_6952:
			this.LblRadWideGeneralLogDisp_A9756 = (global::AcpUI.AcpLabel)target;
			this.LblRadWideGeneralLogDisp_A9756.MouseDoubleClick += new global::System.Windows.Input.MouseButtonEventHandler(this.OnFieldNameDoubleClick);
			return;
			IL_6976:
			this.LblRadWideTPSAudibleEmergencyBeaconsec_A7502 = (global::AcpUI.AcpLabel)target;
			this.LblRadWideTPSAudibleEmergencyBeaconsec_A7502.MouseDoubleClick += new global::System.Windows.Input.MouseButtonEventHandler(this.OnFieldNameDoubleClick);
			return;
			IL_699A:
			this.LblRadDualRadioFatalErrorOption_A42243 = (global::AcpUI.AcpLabel)target;
			this.LblRadDualRadioFatalErrorOption_A42243.MouseDoubleClick += new global::System.Windows.Input.MouseButtonEventHandler(this.OnFieldNameDoubleClick);
			return;
			IL_69BE:
			this.LblRadWideFeaturesMapping = (global::AcpUI.AcpLabel)target;
			this.LblRadWideFeaturesMapping.MouseDoubleClick += new global::System.Windows.Input.MouseButtonEventHandler(this.OnFieldNameDoubleClick);
			return;
			IL_69E2:
			this.RTDBtnRadWideFeaturesChanChangeOnOffHookEnable_A42354 = (global::AcpUI.AcpRtdButton)target;
			return;
			IL_69EF:
			this.RTDBtnRadWideLabtoolActiveMicForBTPTTCapable_43053 = (global::AcpUI.AcpRtdButton)target;
			return;
			IL_69FC:
			this.RadWideBluetoothBluetoothPANNetworkAddress_41983 = (global::AcpUI.AcpTextBox)target;
			this.RadWideBluetoothBluetoothPANNetworkAddress_41983.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_6A20:
			this.RadWideLabtoolTxStartFrequencySplit_A9571_Col = (global::Infragistics.Windows.DataPresenter.UnboundField)target;
			return;
			IL_6A2D:
			this.CVBtnRadWideLabtoolAudibleBeaconRoutingCapable_A41974 = (global::AcpUI.AcpCustomViewCheckBox)target;
			return;
			IL_6A3A:
			this.RTDBtnRadWideTransmitPowerLevelsTxPowerLevelHighW_A41854 = (global::AcpUI.AcpRtdButton)target;
			return;
			IL_6A47:
			this.CpyBtnRadWideFeaturesVoiceAbsenceTimer_42458 = (global::AcpUI.AcpCopyButton)target;
			return;
			IL_6A54:
			this.RadWideTPSFiregroundEmergencyAlarmRetryRatesec_A7929 = (global::AcpUI.AcpTextBoxSpinner)target;
			this.RadWideTPSFiregroundEmergencyAlarmRetryRatesec_A7929.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_6A78:
			this.CVBtnAdvancedExternalMicOnly = (global::AcpUI.AcpCustomViewCheckBox)target;
			return;
			IL_6A85:
			this.RadWideTransmitPowerLevelsConvTxPowerLevelMinimumW_A41863Comp = (global::AcpUI.AcpLabel)target;
			return;
			IL_6A92:
			this.CpyBtnRadWideLabtoolDisableEncryption_43371 = (global::AcpUI.AcpCopyButton)target;
			return;
			IL_6A9F:
			this.CVBtnMARVELL_DNP_43591 = (global::AcpUI.AcpCustomViewCheckBox)target;
			return;
			IL_6AAC:
			this.CVBtnRadWideReverseGeocodedLocationDisplayFormat = (global::AcpUI.AcpCustomViewCheckBox)target;
			return;
			IL_6AB9:
			this.RadWideAdvancedPreAmp_A8733 = (global::AcpUI.AcpCheckBox)target;
			this.RadWideAdvancedPreAmp_A8733.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_6ADD:
			this.RadWideGunlockRelocktimerName_A36521Comp = (global::AcpUI.AcpLabel)target;
			return;
			IL_6AEA:
			this.RTDBtnTrunkingRadioInhibited_A19483 = (global::AcpUI.AcpRtdButton)target;
			return;
			IL_6AF7:
			this.RadWideTransmitPowerLevelsTxPowerLevelMinimumW_A41858_Col = (global::Infragistics.Windows.DataPresenter.UnboundField)target;
			return;
			IL_6B04:
			this.RadProfAlertTonesPowerUpSelfTestAlertTone_A8718Comp = (global::AcpUI.AcpCheckBox)target;
			return;
			IL_6B11:
			this.RadWideTransmitPowerLevelsFrequencyRangeEndMHz_A20037Comp = (global::AcpUI.AcpLabel)target;
			return;
			IL_6B1E:
			this.CVBtnRadWideLocationUserSelectableLocationEnable_A9605 = (global::AcpUI.AcpCustomViewCheckBox)target;
			return;
			IL_6B2B:
			this.ExpanderRadioWideRxFrequencySplitFPPTableView = (global::AcpUI.AcpGroupBox)target;
			return;
			IL_6B38:
			this.ExpanderRadioWideUserInformationAndPasswords = (global::AcpUI.AcpExpander)target;
			return;
			IL_6B45:
			this.RadWideUserInformationandPasswordsMaximumPasswordLength_A8477 = (global::AcpUI.AcpTextBoxSpinner)target;
			this.RadWideUserInformationandPasswordsMaximumPasswordLength_A8477.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_6B69:
			this.CpyBtnRadWideUserInformationandPasswordsSecureHardwareAutoLogin_A7508 = (global::AcpUI.AcpCopyButton)target;
			return;
			IL_6B76:
			this.LblToneEmergencyConfigurableCapable_42083 = (global::AcpUI.AcpLabel)target;
			this.LblToneEmergencyConfigurableCapable_42083.MouseDoubleClick += new global::System.Windows.Input.MouseButtonEventHandler(this.OnFieldNameDoubleClick);
			return;
			IL_6B9A:
			this.RadWideAdvancedCyclicKeying_A7795 = (global::AcpUI.AcpCheckBox)target;
			this.RadWideAdvancedCyclicKeying_A7795.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_6BBE:
			this.RadWideEmergencyRxTxAlertToneSet_A41508 = (global::AcpUI.AcpComboBox)target;
			this.RadWideEmergencyRxTxAlertToneSet_A41508.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_6BE2:
			this.GrpBoxExpanderRadioWideSensorPseudo0 = (global::AcpUI.AcpGroupBox)target;
			return;
			IL_6BEF:
			this.RadWideUserInformationAndPasswordsTacticalInhibitEncodePassword_A34395 = (global::AcpUI.AcpPasswordEyeBox)target;
			this.RadWideUserInformationAndPasswordsTacticalInhibitEncodePassword_A34395.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_6C13:
			this.RadWideLabtoolFCCNarrowBandEndFrequency_A38271Comp = (global::AcpUI.AcpLabel)target;
			return;
			IL_6C20:
			this.LblUCLContactsLimitationEnhancement_43811 = (global::AcpUI.AcpLabel)target;
			this.LblUCLContactsLimitationEnhancement_43811.MouseDoubleClick += new global::System.Windows.Input.MouseButtonEventHandler(this.OnFieldNameDoubleClick);
			return;
			IL_6C44:
			this.CVBtnRadWideGeneralASKRequired_A37152 = (global::AcpUI.AcpCustomViewCheckBox)target;
			return;
			IL_6C51:
			this.LblRadWideReverseGeocodedLocationDisplayFormat = (global::AcpUI.AcpLabel)target;
			this.LblRadWideReverseGeocodedLocationDisplayFormat.MouseDoubleClick += new global::System.Windows.Input.MouseButtonEventHandler(this.OnFieldNameDoubleClick);
			return;
			IL_6C75:
			this.RTDBtnRadioWideLabtoolDisableWindNoiseReductionLevelForAccessories_43548 = (global::AcpUI.AcpRtdButton)target;
			return;
			IL_6C82:
			this.RadWideLabtoolRxStartFrequencySplit_A9032 = (global::AcpUI.AcpTextBox)target;
			this.RadWideLabtoolRxStartFrequencySplit_A9032.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_6CA6:
			this.ExpanderRadioWideFCCNarrowBandingFrequencySplitTableSRecView = (global::AcpUI.AcpGroupBox)target;
			return;
			IL_6CB3:
			this.LblTPSCapable_A42312 = (global::AcpUI.AcpLabel)target;
			this.LblTPSCapable_A42312.MouseDoubleClick += new global::System.Windows.Input.MouseButtonEventHandler(this.OnFieldNameDoubleClick);
			return;
			IL_6CD7:
			this.CVBtnRadWideUserInformationandPasswordsSoftIDUsername_A9169 = (global::AcpUI.AcpCustomViewCheckBox)target;
			return;
			IL_6CE4:
			this.CVBtnRadWideLocationMaxStoredLocationRequests_A8473 = (global::AcpUI.AcpCustomViewCheckBox)target;
			return;
			IL_6CF1:
			this.RTDBtnRadWideGenLightBarPatternRelay5_A36510 = (global::AcpUI.AcpRtdButton)target;
			return;
			IL_6CFE:
			this.CpyBtnRadWideDigitalAudioOptionsStrongInterference2_A9206 = (global::AcpUI.AcpCopyButton)target;
			return;
			IL_6D0B:
			this.RadWideSmartMappingServerAssistedLocation = (global::AcpUI.AcpCheckBox)target;
			this.RadWideSmartMappingServerAssistedLocation.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_6D2F:
			this.CVBtnRadWideGenLightBarPatternRelay1_A36506 = (global::AcpUI.AcpCustomViewCheckBox)target;
			return;
			IL_6D3C:
			this.RadWideGenLightBarPatternRelay3_A36508_Col = (global::Infragistics.Windows.DataPresenter.UnboundField)target;
			return;
			IL_6D49:
			this.RTDBtnRadWideUserInformationandPasswordsSoftIDUsernameDisplayTextSize_A23453 = (global::AcpUI.AcpRtdButton)target;
			return;
			IL_6D56:
			this.LblZnChanCfgFPPProtectionFPPEnable_A8142 = (global::AcpUI.AcpLabel)target;
			this.LblZnChanCfgFPPProtectionFPPEnable_A8142.MouseDoubleClick += new global::System.Windows.Input.MouseButtonEventHandler(this.OnFieldNameDoubleClick);
			return;
			IL_6D7A:
			this.LblRadWideDualRadioFixedRadioSwapMenu_A42241 = (global::AcpUI.AcpLabel)target;
			this.LblRadWideDualRadioFixedRadioSwapMenu_A42241.MouseDoubleClick += new global::System.Windows.Input.MouseButtonEventHandler(this.OnFieldNameDoubleClick);
			return;
			IL_6D9E:
			this.CVBtnRadWideGenLightBarPatternRelay4_A36509 = (global::AcpUI.AcpCustomViewCheckBox)target;
			return;
			IL_6DAB:
			this.CpyBtnRadWideLabtoolControlHeadConfiguration_A7722 = (global::AcpUI.AcpCopyButton)target;
			return;
			IL_6DB8:
			this.RadWideMPPPairingOnlyWithLTE_A42320 = (global::AcpUI.AcpLabel)target;
			this.RadWideMPPPairingOnlyWithLTE_A42320.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_6DDC:
			this.CpyBtnRadWideTransmitPowerLevelsTxPowerLevelConfigType_A41179 = (global::AcpUI.AcpCopyButton)target;
			return;
			IL_6DE9:
			this.RadioWideLabtoolEmergencyCallTermination_43348Comp = (global::AcpUI.AcpLabel)target;
			return;
			IL_6DF6:
			this.RadWideGeneralProgrammingPath_44845 = (global::AcpUI.AcpComboBox)target;
			this.RadWideGeneralProgrammingPath_44845.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_6E1A:
			this.RTDBtnRadWideLabtoolDeviceMgmtEnterpriseWifiCodeplugId = (global::AcpUI.AcpRtdButton)target;
			return;
			IL_6E27:
			this.RTDBtnRadWideLabtoolRadioReadPasswordEnable_A8869 = (global::AcpUI.AcpRtdButton)target;
			return;
			IL_6E34:
			this.RTDBtnRadWideUserInformationandUserLoginUnitIDTextSize_41309 = (global::AcpUI.AcpRtdButton)target;
			return;
			IL_6E41:
			this.CVBtnRadWideBluetoothReplacePairingInfo_A41562 = (global::AcpUI.AcpCustomViewCheckBox)target;
			return;
			IL_6E4E:
			this.RadWideTransmitPowerLevelsTxPowerLevelHighW_A41854_Col = (global::Infragistics.Windows.DataPresenter.UnboundField)target;
			return;
			IL_6E5B:
			this.LblRadWideBluetoothActiveRSMInternalMicIfNotBtMic_A41576 = (global::AcpUI.AcpLabel)target;
			this.LblRadWideBluetoothActiveRSMInternalMicIfNotBtMic_A41576.MouseDoubleClick += new global::System.Windows.Input.MouseButtonEventHandler(this.OnFieldNameDoubleClick);
			return;
			IL_6E7F:
			this.RadWideLabtoolRxStartFrequencySplit_A9032Comp = (global::AcpUI.AcpLabel)target;
			return;
			IL_6E8C:
			this.RadWideSecureNFCPairing_A44931Comp = (global::AcpUI.AcpCheckBox)target;
			return;
			IL_6E99:
			this.CVBtnRadWideFeaturesRadioCertificationType_43064 = (global::AcpUI.AcpCustomViewCheckBox)target;
			return;
			IL_6EA6:
			this.CVBtnMultiRadioSystemEnable_A42248 = (global::AcpUI.AcpCustomViewCheckBox)target;
			return;
			IL_6EB3:
			this.CVBtnRadProfAlertTonesStandbyChirpsec_A9179 = (global::AcpUI.AcpCustomViewCheckBox)target;
			return;
			IL_6EC0:
			this.LblRadWideTPSFiregroundRespondToPolls_A33573 = (global::AcpUI.AcpLabel)target;
			this.LblRadWideTPSFiregroundRespondToPolls_A33573.MouseDoubleClick += new global::System.Windows.Input.MouseButtonEventHandler(this.OnFieldNameDoubleClick);
			return;
			IL_6EE4:
			this.RadWideLabtoolDynamicZoneScanCapability_42749Comp = (global::AcpUI.AcpLabel)target;
			return;
			IL_6EF1:
			this.RadWideTransmitPowerLevelsConvTxPowerLevelLowW_A41861_Col = (global::Infragistics.Windows.DataPresenter.UnboundField)target;
			return;
			IL_6EFE:
			this.RadWideTransmitPowerLevelsTxPowerLevelLowW_A8153_Col = (global::Infragistics.Windows.DataPresenter.UnboundField)target;
			return;
			IL_6F0B:
			this.CpyBtnRadWideGenLightBarPatternRelay4_A36509 = (global::AcpUI.AcpCopyButton)target;
			return;
			IL_6F18:
			this.CVRadWideGeneralDnsSdPort_44844 = (global::AcpUI.AcpCustomViewCheckBox)target;
			return;
			IL_6F25:
			this.RTDBtnRadWideLabtoolIntelligentPriorityScanCapable_43411 = (global::AcpUI.AcpRtdButton)target;
			return;
			IL_6F32:
			this.RTDBtnRadWideLocationDisplayPeerLocation_42433 = (global::AcpUI.AcpRtdButton)target;
			return;
			IL_6F3F:
			this.LblRadWideBluetoothBluetoothTones_A37035 = (global::AcpUI.AcpLabel)target;
			this.LblRadWideBluetoothBluetoothTones_A37035.MouseDoubleClick += new global::System.Windows.Input.MouseButtonEventHandler(this.OnFieldNameDoubleClick);
			return;
			IL_6F63:
			this.CpyBtnRadWideLabtoolSirenPaFatalError_A9141 = (global::AcpUI.AcpCopyButton)target;
			return;
			IL_6F70:
			this.RadWideLabtoolIntelligentPriorityScanCapable_43411Comp = (global::AcpUI.AcpLabel)target;
			return;
			IL_6F7D:
			this.RadWideUserInformationandPasswordsMaximumPasswordLength_A8477Comp = (global::AcpUI.AcpLabel)target;
			return;
			IL_6F8A:
			this.RadWideTransmitPowerLevelsTxPowerLevelHighW_A8152_Col = (global::Infragistics.Windows.DataPresenter.UnboundField)target;
			return;
			IL_6F97:
			this.RadWideTransmitPowerLevelsFrequencyRangeStartMHz_A41856 = (global::AcpUI.AcpTextBox)target;
			this.RadWideTransmitPowerLevelsFrequencyRangeStartMHz_A41856.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_6FBB:
			this.RTDBtnRadProfAlertTonesAlertTones_A7428 = (global::AcpUI.AcpRtdButton)target;
			return;
			IL_6FC8:
			this.CpyBtnRadWideLabtoolFCCNarrowBandEndFrequency_A38271 = (global::AcpUI.AcpCopyButton)target;
			return;
			IL_6FD5:
			this.RadWideLabtoolAudioEnhancement_A42736 = (global::AcpUI.AcpLabel)target;
			this.RadWideLabtoolAudioEnhancement_A42736.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_6FF9:
			this.RadWideUserInformationandPasswordsRadioAlias_A8829Comp = (global::AcpUI.AcpLabel)target;
			return;
			IL_7006:
			this.CVBtnRadWideUserInformationandPasswordsMaximumPasswordLength_A8477 = (global::AcpUI.AcpCustomViewCheckBox)target;
			return;
			IL_7013:
			this.RadWideTransmitPowerLevelsFrequencyRangeStartMHz_A19994 = (global::AcpUI.AcpTextBox)target;
			this.RadWideTransmitPowerLevelsFrequencyRangeStartMHz_A19994.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_7037:
			this.CpyBtnRadWideUserInformationandPasswordsUserLoginAuthenticationType_A44926 = (global::AcpUI.AcpCopyButton)target;
			return;
			IL_7044:
			this.ExpanderRadioWideGeneral = (global::AcpUI.AcpExpander)target;
			return;
			IL_7051:
			this.RadWideLabtoolSupportO3ControlHeadPCIBitComp = (global::AcpUI.AcpLabel)target;
			return;
			IL_705E:
			this.RTDBtnRadWideDigitalAudioOptionsWeakSignalFringe_A9679 = (global::AcpUI.AcpRtdButton)target;
			return;
			IL_706B:
			this.RadWideAdvancedSmartLowBatteryAlert_A9165 = (global::AcpUI.AcpComboBox)target;
			this.RadWideAdvancedSmartLowBatteryAlert_A9165.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_708F:
			this.LblAdvancedAuxTransmitSensitivity_A7530 = (global::AcpUI.AcpLabel)target;
			this.LblAdvancedAuxTransmitSensitivity_A7530.MouseDoubleClick += new global::System.Windows.Input.MouseButtonEventHandler(this.OnFieldNameDoubleClick);
			return;
			IL_70B3:
			this.CVBtnRadWideLabtoolDynamicZoneScanCapability_42749 = (global::AcpUI.AcpCustomViewCheckBox)target;
			return;
			IL_70C0:
			this.RTDBtnRadWideDualRadioCrossBandMuteOption_A42240 = (global::AcpUI.AcpRtdButton)target;
			return;
			IL_70CD:
			this.LblRadioErgoConfigACMissionCriticalGeofenceMode_42918 = (global::AcpUI.AcpLabel)target;
			this.LblRadioErgoConfigACMissionCriticalGeofenceMode_42918.MouseDoubleClick += new global::System.Windows.Input.MouseButtonEventHandler(this.OnFieldNameDoubleClick);
			return;
			IL_70F1:
			this.CpyBtnRadWideLabtoolSmartLowBatteryThreshold_A20201 = (global::AcpUI.AcpCopyButton)target;
			return;
			IL_70FE:
			this.CVBtnUCLContactsLimitationEnhancement_43811 = (global::AcpUI.AcpCustomViewCheckBox)target;
			return;
			IL_710B:
			this.LblRadProfAlertTonesLED_A8428 = (global::AcpUI.AcpLabel)target;
			this.LblRadProfAlertTonesLED_A8428.MouseDoubleClick += new global::System.Windows.Input.MouseButtonEventHandler(this.OnFieldNameDoubleClick);
			return;
			IL_712F:
			this.RTDBtnRadWideGeneralOwnerSystemID_A37153 = (global::AcpUI.AcpRtdButton)target;
			return;
			IL_713C:
			this.RTDBtnRadWidePowerLevelBandFrequency_A41864 = (global::AcpUI.AcpRtdButton)target;
			return;
			IL_7149:
			this.LblRadWideGeneralPskId_44840 = (global::AcpUI.AcpLabel)target;
			this.LblRadWideGeneralPskId_44840.MouseDoubleClick += new global::System.Windows.Input.MouseButtonEventHandler(this.OnFieldNameDoubleClick);
			return;
			IL_716D:
			this.RTDBtnIsolatedGCAIAccessoryPlugAndPlayDisable_42927 = (global::AcpUI.AcpRtdButton)target;
			return;
			IL_717A:
			this.CVBtnRadWideStandardNFCPairing_A44928 = (global::AcpUI.AcpCustomViewCheckBox)target;
			return;
			IL_7187:
			this.LblPASSAlarmFilterCapable_A42387 = (global::AcpUI.AcpLabel)target;
			this.LblPASSAlarmFilterCapable_A42387.MouseDoubleClick += new global::System.Windows.Input.MouseButtonEventHandler(this.OnFieldNameDoubleClick);
			return;
			IL_71AB:
			this.RTDBtnSensorEventDisableTimer_43198 = (global::AcpUI.AcpRtdButton)target;
			return;
			IL_71B8:
			this.CpyBtnRadWideBluetoothBluetoothDeviceInquiryDuration_41977 = (global::AcpUI.AcpCopyButton)target;
			return;
			IL_71C5:
			this.RTDBtnRadWideLabtoolFatalError_A8015 = (global::AcpUI.AcpRtdButton)target;
			return;
			IL_71D2:
			this.LblRadWideAlertTonesScanAlertToneEnable_A19555 = (global::AcpUI.AcpLabel)target;
			this.LblRadWideAlertTonesScanAlertToneEnable_A19555.MouseDoubleClick += new global::System.Windows.Input.MouseButtonEventHandler(this.OnFieldNameDoubleClick);
			return;
			IL_71F6:
			this.CVBtnRadWideFeaturesRotarySwitchScanPrgm_A8986 = (global::AcpUI.AcpCustomViewCheckBox)target;
			return;
			IL_7203:
			this.CVBtnRadWideFeaturesIgnitionAutoPoweroff_A38014 = (global::AcpUI.AcpCustomViewCheckBox)target;
			return;
			IL_7210:
			this.LblRadWideGeneralOwnerAdvancedKeyType_A38663 = (global::AcpUI.AcpLabel)target;
			this.LblRadWideGeneralOwnerAdvancedKeyType_A38663.MouseDoubleClick += new global::System.Windows.Input.MouseButtonEventHandler(this.OnFieldNameDoubleClick);
			return;
			IL_7234:
			this.RadWideLabtoolTxEndFrequencySplit_A9532 = (global::AcpUI.AcpTextBox)target;
			this.RadWideLabtoolTxEndFrequencySplit_A9532.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_7258:
			this.CpyBtnRadWideGenLightBarPatternRelay7_A36512 = (global::AcpUI.AcpCopyButton)target;
			return;
			IL_7265:
			this.GrpBoxExpanderRadioWideUserInformationAndPasswordsTacticaService = (global::AcpUI.AcpGroupBox)target;
			return;
			IL_7272:
			this.RadWideLabtoolDigitalAnalogBalance_A7851Comp = (global::AcpUI.AcpLabel)target;
			return;
			IL_727F:
			this.LblRadProfAlertTonesNewMuteTonesOperation_A42149 = (global::AcpUI.AcpLabel)target;
			this.LblRadProfAlertTonesNewMuteTonesOperation_A42149.MouseDoubleClick += new global::System.Windows.Input.MouseButtonEventHandler(this.OnFieldNameDoubleClick);
			return;
			IL_72A3:
			this.LblRadWideMPPPairingOnlyWithLTE_A42320 = (global::AcpUI.AcpLabel)target;
			this.LblRadWideMPPPairingOnlyWithLTE_A42320.MouseDoubleClick += new global::System.Windows.Input.MouseButtonEventHandler(this.OnFieldNameDoubleClick);
			return;
			IL_72C7:
			this.RadWideTransmitPowerLevelsTxPowerLevelHighW_A41854Comp = (global::AcpUI.AcpLabel)target;
			return;
			IL_72D4:
			this.RTDBtnRadProfAlertTonesLED_A8428 = (global::AcpUI.AcpRtdButton)target;
			return;
			IL_72E1:
			this.ToneEmergencyConfigurableCapable_42083 = (global::AcpUI.AcpLabel)target;
			this.ToneEmergencyConfigurableCapable_42083.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_7305:
			this.LblRadWideLabtoolIndirectPTTAudioRoutingPCI_44817 = (global::AcpUI.AcpLabel)target;
			this.LblRadWideLabtoolIndirectPTTAudioRoutingPCI_44817.MouseDoubleClick += new global::System.Windows.Input.MouseButtonEventHandler(this.OnFieldNameDoubleClick);
			return;
			IL_7329:
			this.CpyBtnRadWideTPSFiregroundEmergencyAlarmRetryRatesec_A7929 = (global::AcpUI.AcpCopyButton)target;
			return;
			IL_7336:
			this.CVBtnRadWideLabtoolEmergencyCallOnlywithHotMicCapable_A43162 = (global::AcpUI.AcpCustomViewCheckBox)target;
			return;
			IL_7343:
			this.CVBtnRadProfAlertTonesEnhancedMuteTonesOperation_A42150 = (global::AcpUI.AcpCustomViewCheckBox)target;
			return;
			IL_7350:
			this.RadWideCustomLogoEnabled = (global::AcpUI.AcpCheckBox)target;
			this.RadWideCustomLogoEnabled.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_7374:
			this.CpyBtnRadWideUserinfoPassRequiredForSiren_A36533 = (global::AcpUI.AcpCopyButton)target;
			return;
			IL_7381:
			this.CVBtnRadWideUserInformationandPasswordsUnlockPassword_A8690 = (global::AcpUI.AcpCustomViewCheckBox)target;
			return;
			IL_738E:
			this.CVBtnRadWideTPSEmergencyPTTTransmission_A41544 = (global::AcpUI.AcpCustomViewCheckBox)target;
			return;
			IL_739B:
			this.CpyBtnRadWideLabtoolCertMgmtMotorolaSolutionsPKIHostname = (global::AcpUI.AcpCopyButton)target;
			return;
			IL_73A8:
			this.CVBtnRadioWideLabtoolEmergencyCallTermination_43348 = (global::AcpUI.AcpCustomViewCheckBox)target;
			return;
			IL_73B5:
			this.RTDBtnRadWideLabtoolAudibleBeaconRoutingCapable_A41974 = (global::AcpUI.AcpRtdButton)target;
			return;
			IL_73C2:
			this.LblRadWideLabtoolDisplayContrastConfiguration_A7873 = (global::AcpUI.AcpLabel)target;
			this.LblRadWideLabtoolDisplayContrastConfiguration_A7873.MouseDoubleClick += new global::System.Windows.Input.MouseButtonEventHandler(this.OnFieldNameDoubleClick);
			return;
			IL_73E6:
			this.GrpBoxExpanderRadioWideAlertTonesPseudo1 = (global::AcpUI.AcpGroupBox)target;
			return;
			IL_73F3:
			this.CVBtnTEN_DIGIT_RL_PSWD_capable_43711 = (global::AcpUI.AcpCustomViewCheckBox)target;
			return;
			IL_7400:
			this.ExpanderRadioWideTxPowerLevelsByFrequencyRange = (global::AcpUI.AcpXamDataPresenter)target;
			return;
			IL_740D:
			this.CpyBtnRadWideLabtoolDynamicZoneCable_A41258 = (global::AcpUI.AcpCopyButton)target;
			return;
			IL_741A:
			this.CVBtnRadWideLabtoolEnhancedARS_A43084 = (global::AcpUI.AcpCustomViewCheckBox)target;
			return;
			IL_7427:
			this.HLinkTPSFireground = (global::System.Windows.Documents.Hyperlink)target;
			this.HLinkTPSFireground.Click += this.HLinkClick;
			return;
			IL_744B:
			this.RadWideUserInformationandPasswordsRadioLock_A8836 = (global::AcpUI.AcpCheckBox)target;
			this.RadWideUserInformationandPasswordsRadioLock_A8836.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_746F:
			this.RadWideRxAudioControlMidrangeEqualization_A8508 = (global::AcpUI.AcpCheckBox)target;
			this.RadWideRxAudioControlMidrangeEqualization_A8508.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_7493:
			this.CpyBtnRadWideGunlockRelocktimerName_A36521 = (global::AcpUI.AcpCopyButton)target;
			return;
			IL_74A0:
			this.CVBtnRadWideAlertTonesScanAlertToneEnable_A19555 = (global::AcpUI.AcpCustomViewCheckBox)target;
			return;
			IL_74AD:
			this.RTDBtnRadWideLabtoolArchiveReadPasswordEnable_A7462 = (global::AcpUI.AcpRtdButton)target;
			return;
			IL_74BA:
			this.CVBtnRadWideBluetoothBluetoothPairingType_A37036 = (global::AcpUI.AcpCustomViewCheckBox)target;
			return;
			IL_74C7:
			this.RTDBtnRadWideLocationMaxStoredLocationRequests_A8473 = (global::AcpUI.AcpRtdButton)target;
			return;
			IL_74D4:
			this.RadWideTransmitPowerLevelsTrkTxPowerLevelLowW_A41176 = (global::AcpUI.AcpTextBox)target;
			this.RadWideTransmitPowerLevelsTrkTxPowerLevelLowW_A41176.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_74F8:
			this.CVBtnRadWideLabtoolSmartLowBatteryThreshold_A20201 = (global::AcpUI.AcpCustomViewCheckBox)target;
			return;
			IL_7505:
			this.RadWideGenLightBarPatternRelay9_A36515Comp = (global::AcpUI.AcpLabel)target;
			return;
			IL_7512:
			this.CpyBtnRadWideLabtoolUserSelectablePLEnhancement_43031 = (global::AcpUI.AcpCopyButton)target;
			return;
			IL_751F:
			this.RadWideFeaturesExtRFRoute_A43020 = (global::AcpUI.AcpComboBox)target;
			this.RadWideFeaturesExtRFRoute_A43020.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_7543:
			this.CVBtnRadWideGeneralOwnerSystemID_A37153 = (global::AcpUI.AcpCustomViewCheckBox)target;
			return;
			IL_7550:
			this.LblRadWideLocP25LocationReporting_42412 = (global::AcpUI.AcpLabel)target;
			this.LblRadWideLocP25LocationReporting_42412.MouseDoubleClick += new global::System.Windows.Input.MouseButtonEventHandler(this.OnFieldNameDoubleClick);
			return;
			IL_7574:
			this.ThemeBaseObj = (global::AcpUI.Common.AcpThemeBase)target;
			return;
			IL_7581:
			this.CpyBtnRadWideUserInformationandPasswordsRadioLock_A8836 = (global::AcpUI.AcpCopyButton)target;
			return;
			IL_758E:
			this.CpyBtnRadWideTPSAudibleEmergencyBeaconsec_A7502 = (global::AcpUI.AcpCopyButton)target;
			return;
			IL_759B:
			this.RadWideTransmitPowerLevelsFrequencyRangeStartMHz_A19994Comp = (global::AcpUI.AcpLabel)target;
			return;
			IL_75A8:
			this.LblRadWideFeaturesVirtualPartnerAudioPriority = (global::AcpUI.AcpLabel)target;
			this.LblRadWideFeaturesVirtualPartnerAudioPriority.MouseDoubleClick += new global::System.Windows.Input.MouseButtonEventHandler(this.OnFieldNameDoubleClick);
			return;
			IL_75CC:
			this.RecNavToolbarExpanderRadioWideTxFrequencySplitFPP = (global::AcpUI.AcpRecNavToolbar)target;
			this.RecNavToolbarExpanderRadioWideTxFrequencySplitFPP.ModeClick += this.OnModeClick;
			return;
			IL_75F0:
			this.CpyBtnRadWideTransmitPowerLevelsTrkTxPowerLevelMinimumW_A41862 = (global::AcpUI.AcpCopyButton)target;
			return;
			IL_75FD:
			this.CpyBtnRadWideLabtoolConsoletteModelEnable_A7713 = (global::AcpUI.AcpCopyButton)target;
			return;
			IL_760A:
			this.LblRadWideTPSFiregroundVoiceTxEndTone_A9655 = (global::AcpUI.AcpLabel)target;
			this.LblRadWideTPSFiregroundVoiceTxEndTone_A9655.MouseDoubleClick += new global::System.Windows.Input.MouseButtonEventHandler(this.OnFieldNameDoubleClick);
			return;
			IL_762E:
			this.CVBtnRadWideUserInformationandPasswordsTacticalServiceEncodePassword = (global::AcpUI.AcpCustomViewCheckBox)target;
			return;
			IL_763B:
			this.CVBtnRadWideTalkProhibitToneSelection_A42416 = (global::AcpUI.AcpCustomViewCheckBox)target;
			return;
			IL_7648:
			this.RTDBtnRadWideFeaturesTargetChanOnOffHook_A42356 = (global::AcpUI.AcpRtdButton)target;
			return;
			IL_7655:
			this.RTDBtnRadWideLocationDistanceUnit_A13080 = (global::AcpUI.AcpRtdButton)target;
			return;
			IL_7662:
			this.RTDBtnZnChanCfgFPPProtectionFPPEnable_A8142 = (global::AcpUI.AcpRtdButton)target;
			return;
			IL_766F:
			this.RadWideTransmitPowerLevelsTrkTxPowerLevelMinimumW_A41174 = (global::AcpUI.AcpTextBox)target;
			this.RadWideTransmitPowerLevelsTrkTxPowerLevelMinimumW_A41174.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_7693:
			this.RadWideBluetoothFriendlyNameEditable_A41182 = (global::AcpUI.AcpCheckBox)target;
			this.RadWideBluetoothFriendlyNameEditable_A41182.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_76B7:
			this.LblRadWideBluetoothFriendlyName_A41181 = (global::AcpUI.AcpLabel)target;
			this.LblRadWideBluetoothFriendlyName_A41181.MouseDoubleClick += new global::System.Windows.Input.MouseButtonEventHandler(this.OnFieldNameDoubleClick);
			return;
			IL_76DB:
			this.RadWideLabtoolRxEndFrequencySplit_A9015Comp = (global::AcpUI.AcpLabel)target;
			return;
			IL_76E8:
			this.CpyBtnRadWideUserInformationandPasswordsMaximumPasswordLength_A8477 = (global::AcpUI.AcpCopyButton)target;
			return;
			IL_76F5:
			this.RadWideBluetoothBluetoothPairingType_A37036 = (global::AcpUI.AcpComboBox)target;
			this.RadWideBluetoothBluetoothPairingType_A37036.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_7719:
			this.LblRadWideLocationMaxStoredLocationRequests_A8473 = (global::AcpUI.AcpLabel)target;
			this.LblRadWideLocationMaxStoredLocationRequests_A8473.MouseDoubleClick += new global::System.Windows.Input.MouseButtonEventHandler(this.OnFieldNameDoubleClick);
			return;
			IL_773D:
			this.CVBtnRadWideGenLightBarPatternRelay9_A36515 = (global::AcpUI.AcpCustomViewCheckBox)target;
			return;
			IL_774A:
			this.LblRadWideUserInformationandPasswordsUnlockPassword_A8690 = (global::AcpUI.AcpLabel)target;
			this.LblRadWideUserInformationandPasswordsUnlockPassword_A8690.MouseDoubleClick += new global::System.Windows.Input.MouseButtonEventHandler(this.OnFieldNameDoubleClick);
			return;
			IL_776E:
			this.RTDBtnRadWideLabtoolMaritimeRadioSoftware_A42191 = (global::AcpUI.AcpRtdButton)target;
			return;
			IL_777B:
			this.RadWideLabtoolControlHeadSelection_A7723Comp = (global::AcpUI.AcpLabel)target;
			return;
			IL_7788:
			this.LblRadWideUserinfoPassRequiredForSiren_A36533 = (global::AcpUI.AcpLabel)target;
			this.LblRadWideUserinfoPassRequiredForSiren_A36533.MouseDoubleClick += new global::System.Windows.Input.MouseButtonEventHandler(this.OnFieldNameDoubleClick);
			return;
			IL_77AC:
			this.CpyBtnRadWideStandardNFCPairing_A44928 = (global::AcpUI.AcpCopyButton)target;
			return;
			IL_77B9:
			this.LblRadWideLabtoolDynamicZoneCable_A41258 = (global::AcpUI.AcpLabel)target;
			this.LblRadWideLabtoolDynamicZoneCable_A41258.MouseDoubleClick += new global::System.Windows.Input.MouseButtonEventHandler(this.OnFieldNameDoubleClick);
			return;
			IL_77DD:
			this.RadWideLabtoolMultipleConversationDisable_A19552Comp = (global::AcpUI.AcpCheckBox)target;
			return;
			IL_77EA:
			this.CpyBtnRadWideTransmitPowerLevelsFrequencyRangeEndMHz_A20037 = (global::AcpUI.AcpCopyButton)target;
			return;
			IL_77F7:
			this.CVBtnRadWideGenLightBarPatternRelay2_A36507 = (global::AcpUI.AcpCustomViewCheckBox)target;
			return;
			IL_7804:
			this.CpyBtnRadWideGenLightBarPatternRelay5_A36510 = (global::AcpUI.AcpCopyButton)target;
			return;
			IL_7811:
			this.PASSAlarmFilterCapable_A42387Comp = (global::AcpUI.AcpLabel)target;
			return;
			IL_781E:
			this.CVBtnRadWideTransmitPowerLevelsTxPowerLevelConfigType_A41179 = (global::AcpUI.AcpCustomViewCheckBox)target;
			return;
			IL_782B:
			this.CVBtnRadWideLabtoolReadWriteVoiceFiles_A8893 = (global::AcpUI.AcpCustomViewCheckBox)target;
			return;
			IL_7838:
			this.RadWideLabtoolIndirectPTTAudioRoutingPCI_44817 = (global::AcpUI.AcpLabel)target;
			this.RadWideLabtoolIndirectPTTAudioRoutingPCI_44817.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_785C:
			this.RadWideLocationGpsMode_A22627 = (global::AcpUI.AcpComboBox)target;
			this.RadWideLocationGpsMode_A22627.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_7880:
			this.CVBtnRadWideLabtoolDeviceMgmtEnterpriseWifiCodeplugId = (global::AcpUI.AcpCustomViewCheckBox)target;
			return;
			IL_788D:
			this.RTDBtnRadWideTransmitPowerLevelsTrkTxPowerLevelLowW_A41176 = (global::AcpUI.AcpRtdButton)target;
			return;
			IL_789A:
			this.CpyBtnRadWideFeaturesRecordPlaybackAudioBufferSize_A43125 = (global::AcpUI.AcpCopyButton)target;
			return;
			IL_78A7:
			this.CpyBtnRadWideCombineTxWithRxFilteredAudio_44808 = (global::AcpUI.AcpCopyButton)target;
			return;
			IL_78B4:
			this.CVBtnRadWideLocationDistanceUnit_A13080 = (global::AcpUI.AcpCustomViewCheckBox)target;
			return;
			IL_78C1:
			this.RadWideLabtoolMaritimeRadioSoftware_A42191 = (global::AcpUI.AcpLabel)target;
			this.RadWideLabtoolMaritimeRadioSoftware_A42191.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_78E5:
			this.RadWideTransmitPowerLevelsTrkTxPowerLevelMinimumW_A41174Comp = (global::AcpUI.AcpLabel)target;
			return;
			IL_78F2:
			this.RadWideLabtoolCertMgmtMotorolaSolutionsPKIHostnameComp = (global::AcpUI.AcpLabel)target;
			return;
			IL_78FF:
			this.RadWideTransmitPowerLevelsTxPowerLevelMinimumW_A20038 = (global::AcpUI.AcpTextBox)target;
			this.RadWideTransmitPowerLevelsTxPowerLevelMinimumW_A20038.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_7923:
			this.CVBtnRadCfgVirtualPartnerInactivityTime = (global::AcpUI.AcpCustomViewCheckBox)target;
			return;
			IL_7930:
			this.RadWideUserInformationandPasswordsPIN_A8705 = (global::AcpUI.AcpTextBox)target;
			this.RadWideUserInformationandPasswordsPIN_A8705.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_7954:
			this.GrpBoxExpanderRadioWideGeneralPseudo0 = (global::AcpUI.AcpGroupBox)target;
			return;
			IL_7961:
			this.LblRadWideAdvancedUltraNarrowIntermediateFreqFilter_A9592 = (global::AcpUI.AcpLabel)target;
			this.LblRadWideAdvancedUltraNarrowIntermediateFreqFilter_A9592.MouseDoubleClick += new global::System.Windows.Input.MouseButtonEventHandler(this.OnFieldNameDoubleClick);
			return;
			IL_7985:
			this.RTDBtnDVRSRangeExt_44809 = (global::AcpUI.AcpRtdButton)target;
			return;
			IL_7992:
			this.LblRadWideFeaturesTargetChanOnOffHook_A42356 = (global::AcpUI.AcpLabel)target;
			this.LblRadWideFeaturesTargetChanOnOffHook_A42356.MouseDoubleClick += new global::System.Windows.Input.MouseButtonEventHandler(this.OnFieldNameDoubleClick);
			return;
			IL_79B6:
			this.GrpBoxExpanderRadioWideAlertTonesLowBattery = (global::AcpUI.AcpGroupBox)target;
			return;
			IL_79C3:
			this.CpyBtnRadWideFeaturesVLIFPLOSSFIELD_A9596 = (global::AcpUI.AcpCopyButton)target;
			return;
			IL_79D0:
			this.RadWideGeneralLogDisp_A9756 = (global::AcpUI.AcpCheckBox)target;
			this.RadWideGeneralLogDisp_A9756.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_79F4:
			this.CpyBtnRadErgoWideAdvancedModeSelTxName = (global::AcpUI.AcpCopyButton)target;
			return;
			IL_7A01:
			this.LblSensorEventDisableTimer_43198 = (global::AcpUI.AcpLabel)target;
			this.LblSensorEventDisableTimer_43198.MouseDoubleClick += new global::System.Windows.Input.MouseButtonEventHandler(this.OnFieldNameDoubleClick);
			return;
			IL_7A25:
			this.ExpanderRadioWideGunLockGrid = (global::System.Windows.Controls.Grid)target;
			return;
			IL_7A32:
			this.gridExpanderRadioWideRelockTimerSRecView = (global::System.Windows.Controls.Grid)target;
			return;
			IL_7A3F:
			this.CpyBtnRadProfAlertTonesNewMuteTonesOperation_A42149 = (global::AcpUI.AcpCopyButton)target;
			return;
			IL_7A4C:
			this.RadioWideDVRSTrunkingStatusCapability_A42772 = (global::AcpUI.AcpLabel)target;
			this.RadioWideDVRSTrunkingStatusCapability_A42772.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_7A70:
			this.RadWideStandardNFCPairing_A44928Comp = (global::AcpUI.AcpCheckBox)target;
			return;
			IL_7A7D:
			this.LblRadWideFeaturesVLIFPLOSSFIELD_A9596 = (global::AcpUI.AcpLabel)target;
			this.LblRadWideFeaturesVLIFPLOSSFIELD_A9596.MouseDoubleClick += new global::System.Windows.Input.MouseButtonEventHandler(this.OnFieldNameDoubleClick);
			return;
			IL_7AA1:
			this.CpyBtnRadWideGeneralProgrammingPath_44845 = (global::AcpUI.AcpCopyButton)target;
			return;
			IL_7AAE:
			this.LblRadWideTransmitPowerLevelsTxPowerLevelMinimumW_A41858 = (global::AcpUI.AcpLabel)target;
			this.LblRadWideTransmitPowerLevelsTxPowerLevelMinimumW_A41858.MouseDoubleClick += new global::System.Windows.Input.MouseButtonEventHandler(this.OnFieldNameDoubleClick);
			return;
			IL_7AD2:
			this.CVBtnRadWideDigitalAudioOptionsWeakSignalFringe_A9678 = (global::AcpUI.AcpCustomViewCheckBox)target;
			return;
			IL_7ADF:
			this.LblRadWideLocationSystemManagedGeofence_43042 = (global::AcpUI.AcpLabel)target;
			this.LblRadWideLocationSystemManagedGeofence_43042.MouseDoubleClick += new global::System.Windows.Input.MouseButtonEventHandler(this.OnFieldNameDoubleClick);
			return;
			IL_7B03:
			this.LblRadWideLabtoolAPXSingletoneCapable_43080 = (global::AcpUI.AcpLabel)target;
			this.LblRadWideLabtoolAPXSingletoneCapable_43080.MouseDoubleClick += new global::System.Windows.Input.MouseButtonEventHandler(this.OnFieldNameDoubleClick);
			return;
			IL_7B27:
			this.CpyBtnRadWideSmartMappingServerAssistedLocation = (global::AcpUI.AcpCopyButton)target;
			return;
			IL_7B34:
			this.RadWideTransmitPowerLevelsFrequencyRangeEndMHz_A41857Comp = (global::AcpUI.AcpLabel)target;
			return;
			IL_7B41:
			this.RadWideDualRadioSelection_A42236 = (global::AcpUI.AcpComboBox)target;
			this.RadWideDualRadioSelection_A42236.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_7B65:
			this.RTDBtnRadWideBluetoothBluetoothPANNetworkAddress_41983 = (global::AcpUI.AcpRtdButton)target;
			return;
			IL_7B72:
			this.RadProfAlertTonesEnhancedMuteTonesOperation_A42150Comp = (global::AcpUI.AcpLabel)target;
			return;
			IL_7B7F:
			this.RadWideLabtoolEmergencyRevertCapable_A41918Comp = (global::AcpUI.AcpLabel)target;
			return;
			IL_7B8C:
			this.RTDBtnRadWideAdvancedCyclicKeying_A7795 = (global::AcpUI.AcpRtdButton)target;
			return;
			IL_7B99:
			this.GrpBoxExpanderRadioWideLabtoolRCLastJobSetUUID = (global::AcpUI.AcpGroupBox)target;
			return;
			IL_7BA6:
			this.RadWideLabtoolRadioWritePasswordEnable_A8889Comp = (global::AcpUI.AcpLabel)target;
			return;
			IL_7BB3:
			this.RadWideGenLightBarPatternRelay4_A36509Comp = (global::AcpUI.AcpLabel)target;
			return;
			IL_7BC0:
			this.RadWideLabtoolDynamicZoneScanCapability_42749 = (global::AcpUI.AcpLabel)target;
			this.RadWideLabtoolDynamicZoneScanCapability_42749.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_7BE4:
			this.RadWideFeaturesChannelFallbackEnable = (global::AcpUI.AcpCheckBox)target;
			this.RadWideFeaturesChannelFallbackEnable.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_7C08:
			this.CVBtnPASSAlarmFilterCapable_A42387 = (global::AcpUI.AcpCustomViewCheckBox)target;
			return;
			IL_7C15:
			this.RadWideTPSAudibleEmergencyBeaconsec_A7502 = (global::AcpUI.AcpTextBoxSpinner)target;
			this.RadWideTPSAudibleEmergencyBeaconsec_A7502.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_7C39:
			this.RadWideLabtoolRadioReadPasswordEnable_A8869 = (global::AcpUI.AcpLabel)target;
			this.RadWideLabtoolRadioReadPasswordEnable_A8869.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_7C5D:
			this.GPSFailToneInterval_42329Comp = (global::AcpUI.AcpLabel)target;
			return;
			IL_7C6A:
			this.gridExpanderRadioWideTxPowerLevelsByFrequencyRangeNewBandPlanSRecView = (global::System.Windows.Controls.Grid)target;
			return;
			IL_7C77:
			this.CVBtnRadWideDualRadioFixedRadioSwapMenu_A42241 = (global::AcpUI.AcpCustomViewCheckBox)target;
			return;
			IL_7C84:
			this.LblRadWideTransmitPowerLevelsTrkTxPowerLevelLowW_A41860 = (global::AcpUI.AcpLabel)target;
			this.LblRadWideTransmitPowerLevelsTrkTxPowerLevelLowW_A41860.MouseDoubleClick += new global::System.Windows.Input.MouseButtonEventHandler(this.OnFieldNameDoubleClick);
			return;
			IL_7CA8:
			this.CVBtnRadWideTransmitPowerLevelsTxPowerLevelLowW_A41855 = (global::AcpUI.AcpCustomViewCheckBox)target;
			return;
			IL_7CB5:
			this.RTDBtnRadWideLabtoolDigitalAnalogBalance_A7851 = (global::AcpUI.AcpRtdButton)target;
			return;
			IL_7CC2:
			this.CVBtnRadWideTransmitPowerLevelsTrkTxPowerLevelMinimumW_A41174 = (global::AcpUI.AcpCustomViewCheckBox)target;
			return;
			IL_7CCF:
			this.CVBtnRadWideLabtoolADPGatingPCIBit = (global::AcpUI.AcpCustomViewCheckBox)target;
			return;
			IL_7CDC:
			this.RadWideGenLightBarPatternRelay7_A36512Comp = (global::AcpUI.AcpLabel)target;
			return;
			IL_7CE9:
			this.CpyBtnRadWideFeaturePreAmpUHF_A42962 = (global::AcpUI.AcpCopyButton)target;
			return;
			IL_7CF6:
			this.RadioErgoConfigACMissionCriticalGeofenceMode_42918 = (global::AcpUI.AcpComboBox)target;
			this.RadioErgoConfigACMissionCriticalGeofenceMode_42918.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_7D1A:
			this.CpyBtnRadioErgoConfigACMissionCriticalGeofenceMode_42918 = (global::AcpUI.AcpCopyButton)target;
			return;
			IL_7D27:
			this.CVBtnRadWideBluetoothBluetoothPANNetworkAddress_41983 = (global::AcpUI.AcpCustomViewCheckBox)target;
			return;
			IL_7D34:
			this.CVBtnRadWideGeneralOwnerWACNID_A38656 = (global::AcpUI.AcpCustomViewCheckBox)target;
			return;
			IL_7D41:
			this.CVBtnRadWideLabtoolFlipDisplayOption_A8140 = (global::AcpUI.AcpCustomViewCheckBox)target;
			return;
			IL_7D4E:
			this.CpyBtnRadWideLabtoolIndirectPTTAudioRoutingPCI_44817 = (global::AcpUI.AcpCopyButton)target;
			return;
			IL_7D5B:
			this.CVBtnRadWideTransmitPowerLevelsConvTxPowerLevelMinimumW_A41863 = (global::AcpUI.AcpCustomViewCheckBox)target;
			return;
			IL_7D68:
			this.CVBtnRadWideAlertTonesVolumeAdjustToneOffset_A9656 = (global::AcpUI.AcpCustomViewCheckBox)target;
			return;
			IL_7D75:
			this.RTDBtnGPSFailToneInterval_42329 = (global::AcpUI.AcpRtdButton)target;
			return;
			IL_7D82:
			this.LblRadWideBluetoothBluetoothDropTimer_A37038 = (global::AcpUI.AcpLabel)target;
			this.LblRadWideBluetoothBluetoothDropTimer_A37038.MouseDoubleClick += new global::System.Windows.Input.MouseButtonEventHandler(this.OnFieldNameDoubleClick);
			return;
			IL_7DA6:
			this.RadWidePowerLevelBandFrequency_A41063 = (global::AcpUI.AcpLabel)target;
			this.RadWidePowerLevelBandFrequency_A41063.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_7DCA:
			this.CpyBtnRadWideGenLightBarPatternRelay10_A36516 = (global::AcpUI.AcpCopyButton)target;
			return;
			IL_7DD7:
			this.CpyBtnRadWideUserInformationandPasswordsTacticalServiceEncodePassword = (global::AcpUI.AcpCopyButton)target;
			return;
			IL_7DE4:
			this.LblRadWideUserInformationAndPasswordsTacticalInhibitEnable_A34405 = (global::AcpUI.AcpLabel)target;
			this.LblRadWideUserInformationAndPasswordsTacticalInhibitEnable_A34405.MouseDoubleClick += new global::System.Windows.Input.MouseButtonEventHandler(this.OnFieldNameDoubleClick);
			return;
			IL_7E08:
			this.LblRadWideFeaturesInactivityAutoPoweroff_A38013 = (global::AcpUI.AcpLabel)target;
			this.LblRadWideFeaturesInactivityAutoPoweroff_A38013.MouseDoubleClick += new global::System.Windows.Input.MouseButtonEventHandler(this.OnFieldNameDoubleClick);
			return;
			IL_7E2C:
			this.CpyBtnRadWideAlertTonesZeroLevelAudioMute_A9689 = (global::AcpUI.AcpCopyButton)target;
			return;
			IL_7E39:
			this.CpyBtnRadWideRecentCallListDeleteEnable = (global::AcpUI.AcpCopyButton)target;
			return;
			IL_7E46:
			this.RadWideTransmitPowerLevelsConvTxPowerLevelLowW_A41175Comp = (global::AcpUI.AcpLabel)target;
			return;
			IL_7E53:
			this.LblRadErgoWideAdvancedModeSelTxName = (global::AcpUI.AcpLabel)target;
			this.LblRadErgoWideAdvancedModeSelTxName.MouseDoubleClick += new global::System.Windows.Input.MouseButtonEventHandler(this.OnFieldNameDoubleClick);
			return;
			IL_7E77:
			this.LblRadWideLabtoolChannelSelectorOnSwitch_A19551 = (global::AcpUI.AcpLabel)target;
			this.LblRadWideLabtoolChannelSelectorOnSwitch_A19551.MouseDoubleClick += new global::System.Windows.Input.MouseButtonEventHandler(this.OnFieldNameDoubleClick);
			return;
			IL_7E9B:
			this.CVBtnRadioErgoConfigACMissionCriticalGeofenceMode_42918 = (global::AcpUI.AcpCustomViewCheckBox)target;
			return;
			IL_7EA8:
			this.RadWideUserinfoPassRequiredForSiren_A36533 = (global::AcpUI.AcpCheckBox)target;
			this.RadWideUserinfoPassRequiredForSiren_A36533.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_7ECC:
			this.RadWideFeaturesPowerManagementStandbyTime = (global::AcpUI.AcpTextBoxSpinner)target;
			this.RadWideFeaturesPowerManagementStandbyTime.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_7EF0:
			this.RTDBtnRadioWideMOSCADACE3000Capability_A42772 = (global::AcpUI.AcpRtdButton)target;
			return;
			IL_7EFD:
			this.RTDBtnRadioWideLabtoolZoneCloneCapable_43238 = (global::AcpUI.AcpRtdButton)target;
			return;
			IL_7F0A:
			this.RTDBtnRadWideTransmitPowerLevelsTrkTxPowerLevelLowW_A41860 = (global::AcpUI.AcpRtdButton)target;
			return;
			IL_7F17:
			this.LblRadWideUserInformationandPasswordsRadioAlias_A8829 = (global::AcpUI.AcpLabel)target;
			this.LblRadWideUserInformationandPasswordsRadioAlias_A8829.MouseDoubleClick += new global::System.Windows.Input.MouseButtonEventHandler(this.OnFieldNameDoubleClick);
			return;
			IL_7F3B:
			this.ManDownPersonalityConfigurableCapable_42082Comp = (global::AcpUI.AcpLabel)target;
			return;
			IL_7F48:
			this.LblRadWideLabtoolUltraLowPowerSoldierMacCapable_A41710 = (global::AcpUI.AcpLabel)target;
			this.LblRadWideLabtoolUltraLowPowerSoldierMacCapable_A41710.MouseDoubleClick += new global::System.Windows.Input.MouseButtonEventHandler(this.OnFieldNameDoubleClick);
			return;
			IL_7F6C:
			this.ExpanderRadioWideTxPowerLevelsByFrequencyRangeTableView = (global::AcpUI.AcpGroupBox)target;
			return;
			IL_7F79:
			this.CpyBtnRadWideLabtoolAPXSingletoneCapable_43080 = (global::AcpUI.AcpCopyButton)target;
			return;
			IL_7F86:
			this.RadWideTPSFiregroundEmergencyAlarmRetryRatesec_A7929Comp = (global::AcpUI.AcpLabel)target;
			return;
			IL_7F93:
			this.gridExpanderRadioWideGeneralLightbarPatternSRecView = (global::System.Windows.Controls.Grid)target;
			return;
			IL_7FA0:
			this.CVBtnRadWideCombineTxWithRxFilteredAudio_44808 = (global::AcpUI.AcpCustomViewCheckBox)target;
			return;
			IL_7FAD:
			this.RadWideGenLightBarPatternRelay10_A36516 = (global::AcpUI.AcpComboBox)target;
			this.RadWideGenLightBarPatternRelay10_A36516.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_7FD1:
			this.CVBtnRadWideAudioConfigurationLevel_42740 = (global::AcpUI.AcpCustomViewCheckBox)target;
			return;
			IL_7FDE:
			this.CpyBtnRadWideTransmitPowerLevelsTxPowerLevelLowW_A8153 = (global::AcpUI.AcpCopyButton)target;
			return;
			IL_7FEB:
			this.RTDBtnRadioWideLabtoolEmergencyCallTermination_43348 = (global::AcpUI.AcpRtdButton)target;
			return;
			IL_7FF8:
			this.HLinkTxFrequencySplit = (global::System.Windows.Documents.Hyperlink)target;
			this.HLinkTxFrequencySplit.Click += this.HLinkClick;
			return;
			IL_801C:
			this.RadWideBluetoothBluetoothTones_A37035Comp = (global::AcpUI.AcpCheckBox)target;
			return;
			IL_8029:
			this.ExpanderRadioWideDualRadio = (global::AcpUI.AcpExpander)target;
			return;
			IL_8036:
			this.LblRadWideUserInformationandPasswordsTacticalServiceEncodePassword = (global::AcpUI.AcpLabel)target;
			this.LblRadWideUserInformationandPasswordsTacticalServiceEncodePassword.MouseDoubleClick += new global::System.Windows.Input.MouseButtonEventHandler(this.OnFieldNameDoubleClick);
			return;
			IL_805A:
			this.CpyBtnRadWidePowerLevelBandFrequency_A41063 = (global::AcpUI.AcpCopyButton)target;
			return;
			IL_8067:
			this.CpyBtnRadWideRadioKilled_A41559 = (global::AcpUI.AcpCopyButton)target;
			return;
			IL_8074:
			this.RadCfgVirtualPartnerModeComp = (global::AcpUI.AcpLabel)target;
			return;
			IL_8081:
			this.CVBtnRadWideBluetoothBluetoothEnable_A37028 = (global::AcpUI.AcpCustomViewCheckBox)target;
			return;
			IL_808E:
			this.LblRadWideFeaturesRecordPlaybackAudioBufferSize_A43125 = (global::AcpUI.AcpLabel)target;
			this.LblRadWideFeaturesRecordPlaybackAudioBufferSize_A43125.MouseDoubleClick += new global::System.Windows.Input.MouseButtonEventHandler(this.OnFieldNameDoubleClick);
			return;
			IL_80B2:
			this.RadWideUserInformationandUserLoginUnitID_41306Comp = (global::AcpUI.AcpLabel)target;
			return;
			IL_80BF:
			this.LblRadWideFeaturesNFPACompliant = (global::AcpUI.AcpLabel)target;
			this.LblRadWideFeaturesNFPACompliant.MouseDoubleClick += new global::System.Windows.Input.MouseButtonEventHandler(this.OnFieldNameDoubleClick);
			return;
			IL_80E3:
			this.RadWideAudioConfigurationLevel_42740 = (global::AcpUI.AcpComboBox)target;
			this.RadWideAudioConfigurationLevel_42740.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_8107:
			this.CVBtnRadWideSmartMappingServerAssistedLocation = (global::AcpUI.AcpCustomViewCheckBox)target;
			return;
			IL_8114:
			this.RadWideLabtoolDeviceMgmtEnterpriseWifiCodeplugIdComp = (global::AcpUI.AcpLabel)target;
			return;
			IL_8121:
			this.CVBtnRadWideUniversalRelayControllerFatalError_A37194 = (global::AcpUI.AcpCustomViewCheckBox)target;
			return;
			IL_812E:
			this.CVBtnTPSCapable_A42312 = (global::AcpUI.AcpCustomViewCheckBox)target;
			return;
			IL_813B:
			this.RadWideLabtoolSuppressEmergencyCallCapability_A42143Comp = (global::AcpUI.AcpLabel)target;
			return;
			IL_8148:
			this.RadWideUserInformationandPasswordsRadioLockAttemptsAllowed_A3582 = (global::AcpUI.AcpTextBoxSpinner)target;
			this.RadWideUserInformationandPasswordsRadioLockAttemptsAllowed_A3582.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_816C:
			this.RadWideGeneralDnsSdPort_44844 = (global::AcpUI.AcpTextBoxSpinner)target;
			this.RadWideGeneralDnsSdPort_44844.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_8190:
			this.CVBtnRadWideLabtoolEncryptPassword_A41695 = (global::AcpUI.AcpCustomViewCheckBox)target;
			return;
			IL_819D:
			this.RadWideTalkProhibitToneSelection_A42416Comp = (global::AcpUI.AcpLabel)target;
			return;
			IL_81AA:
			this.CpyBtnRadWideAdvancedCyclicKeying_A7795 = (global::AcpUI.AcpCopyButton)target;
			return;
			IL_81B7:
			this.RadWideLabtoolKeypadType_A8372Comp = (global::AcpUI.AcpLabel)target;
			return;
			IL_81C4:
			this.RadWideGenLightBarPatternRelay2_A36507_Col = (global::Infragistics.Windows.DataPresenter.UnboundField)target;
			return;
			IL_81D1:
			this.CVBtnRadWideUserinfoPassRequiredForSiren_A36533 = (global::AcpUI.AcpCustomViewCheckBox)target;
			return;
			IL_81DE:
			this.RTDBtnRadWideLabtoolEmergencyCallOnlywithHotMicCapable_A43162 = (global::AcpUI.AcpRtdButton)target;
			return;
			IL_81EB:
			this.RadWideLabtoolDisplayType_A7887Comp = (global::AcpUI.AcpLabel)target;
			return;
			IL_81F8:
			this.RadWideLabtoolUserSelectablePLEnhancement_43031Comp = (global::AcpUI.AcpLabel)target;
			return;
			IL_8205:
			this.RTDBtnRadInfoGeneralMotorcycleRadio_A8546 = (global::AcpUI.AcpRtdButton)target;
			return;
			IL_8212:
			this.RTDBtnRadWideBluetoothLegacyBluetoothPINPairing = (global::AcpUI.AcpRtdButton)target;
			return;
			IL_821F:
			this.LblRadWideTransmitPowerLevelsTrkTxPowerLevelLowW_A41176 = (global::AcpUI.AcpLabel)target;
			this.LblRadWideTransmitPowerLevelsTrkTxPowerLevelLowW_A41176.MouseDoubleClick += new global::System.Windows.Input.MouseButtonEventHandler(this.OnFieldNameDoubleClick);
			return;
			IL_8243:
			this.CVBtnRadWideLabtoolDisplayType_A7887 = (global::AcpUI.AcpCustomViewCheckBox)target;
			return;
			IL_8250:
			this.CVBtnRadWideTPSFiregroundRespondToPolls_A33573 = (global::AcpUI.AcpCustomViewCheckBox)target;
			return;
			IL_825D:
			this.LblRadWideAlertTonesZeroLevelAudioMute_A9689 = (global::AcpUI.AcpLabel)target;
			this.LblRadWideAlertTonesZeroLevelAudioMute_A9689.MouseDoubleClick += new global::System.Windows.Input.MouseButtonEventHandler(this.OnFieldNameDoubleClick);
			return;
			IL_8281:
			this.RTDBtnRadWideTransmitPowerLevelsTrkTxPowerLevelMinimumW_A41174 = (global::AcpUI.AcpRtdButton)target;
			return;
			IL_828E:
			this.ExpanderRadioWideRxFrequencySplitFPP = (global::AcpUI.AcpXamDataPresenter)target;
			return;
			IL_829B:
			this.RadWideDigitalAudioOptionsWeakSignalFringe_A9679 = (global::AcpUI.AcpCheckBox)target;
			this.RadWideDigitalAudioOptionsWeakSignalFringe_A9679.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_82BF:
			this.RTDBtnRadWideUserInformationandPasswordsRadioLockRadioInhibitOnDeadlock_A3584 = (global::AcpUI.AcpRtdButton)target;
			return;
			IL_82CC:
			this.CpyBtnRadWideBluetoothFriendlyName_A41181 = (global::AcpUI.AcpCopyButton)target;
			return;
			IL_82D9:
			this.CVBtnRadWideTransmitPowerLevelsConvTxPowerLevelMinimumW_A41173 = (global::AcpUI.AcpCustomViewCheckBox)target;
			return;
			IL_82E6:
			this.LblRadWideTPSPTTTransmission_A41545 = (global::AcpUI.AcpLabel)target;
			this.LblRadWideTPSPTTTransmission_A41545.MouseDoubleClick += new global::System.Windows.Input.MouseButtonEventHandler(this.OnFieldNameDoubleClick);
			return;
			IL_830A:
			this.RadWideConventionalDynamicIDWithPassword_A43705 = (global::AcpUI.AcpPasswordEyeBox)target;
			this.RadWideConventionalDynamicIDWithPassword_A43705.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_832E:
			this.CVBtnRadWideConventionalDynamicIDWithPassword_A43705 = (global::AcpUI.AcpCustomViewCheckBox)target;
			return;
			IL_833B:
			this.HLinkTransmitPowerLevels = (global::System.Windows.Documents.Hyperlink)target;
			this.HLinkTransmitPowerLevels.Click += this.HLinkClick;
			return;
			IL_835F:
			this.LblRadWideTPSFiregroundEmergencyPTTTransmission_A33203 = (global::AcpUI.AcpLabel)target;
			this.LblRadWideTPSFiregroundEmergencyPTTTransmission_A33203.MouseDoubleClick += new global::System.Windows.Input.MouseButtonEventHandler(this.OnFieldNameDoubleClick);
			return;
			IL_8383:
			this.CVBtnRadWideLocP25LocationReporting_42412 = (global::AcpUI.AcpCustomViewCheckBox)target;
			return;
			IL_8390:
			this.LblRadWideGeneralOwnerSystemID_A37153 = (global::AcpUI.AcpLabel)target;
			this.LblRadWideGeneralOwnerSystemID_A37153.MouseDoubleClick += new global::System.Windows.Input.MouseButtonEventHandler(this.OnFieldNameDoubleClick);
			return;
			IL_83B4:
			this.RadioWideLabtoolEmergencyCallTermination_43348 = (global::AcpUI.AcpLabel)target;
			this.RadioWideLabtoolEmergencyCallTermination_43348.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_83D8:
			this.CVBtnRadWideLabtoolActiveMicForBTPTTCapable_43053 = (global::AcpUI.AcpCustomViewCheckBox)target;
			return;
			IL_83E5:
			this.RTDBtnRadWideLabtoolEarlyWarningBatteryThreshold_A23977 = (global::AcpUI.AcpRtdButton)target;
			return;
			IL_83F2:
			this.GrpBoxExpanderRadioWideFiregroundConventionalConfiguration = (global::AcpUI.AcpGroupBox)target;
			return;
			IL_83FF:
			this.CVBtnRadWideTransmitPowerLevelsTxPowerLevelLowW_A8153 = (global::AcpUI.AcpCustomViewCheckBox)target;
			return;
			IL_840C:
			this.CVBtnRadWideLocationLocationEnable_A8448 = (global::AcpUI.AcpCustomViewCheckBox)target;
			return;
			IL_8419:
			this.RadWideGenLightBarPatternRelay7_A36512_Col = (global::Infragistics.Windows.DataPresenter.UnboundField)target;
			return;
			IL_8426:
			this.LblRadWideLabtoolSirenPaFatalError_A9141 = (global::AcpUI.AcpLabel)target;
			this.LblRadWideLabtoolSirenPaFatalError_A9141.MouseDoubleClick += new global::System.Windows.Input.MouseButtonEventHandler(this.OnFieldNameDoubleClick);
			return;
			IL_844A:
			this.LblRadWideBluetoothAudioBackwardsCompatibility_A44942 = (global::AcpUI.AcpLabel)target;
			this.LblRadWideBluetoothAudioBackwardsCompatibility_A44942.MouseDoubleClick += new global::System.Windows.Input.MouseButtonEventHandler(this.OnFieldNameDoubleClick);
			return;
			IL_846E:
			this.RTDBtnRadWideLabtoolConsolidatedActionEnhancement_A43036 = (global::AcpUI.AcpRtdButton)target;
			return;
			IL_847B:
			this.ExpanderRadioWideGunLock = (global::AcpUI.AcpExpander)target;
			return;
			IL_8488:
			this.RadWideLabtoolRCLastJobSetUUID = (global::AcpUI.AcpTextBox)target;
			this.RadWideLabtoolRCLastJobSetUUID.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_84AC:
			this.RadWideTransmitPowerLevelsTxPowerLevelMaximumW_A41859 = (global::AcpUI.AcpTextBox)target;
			this.RadWideTransmitPowerLevelsTxPowerLevelMaximumW_A41859.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_84D0:
			this.RadWideGeneralDateFormat_A7802Comp = (global::AcpUI.AcpLabel)target;
			return;
			IL_84DD:
			this.RTDBtnRadWideLocP25LocationReporting_42412 = (global::AcpUI.AcpRtdButton)target;
			return;
			IL_84EA:
			this.LblRadWideGenLightBarPatternRelay4_A36509 = (global::AcpUI.AcpLabel)target;
			this.LblRadWideGenLightBarPatternRelay4_A36509.MouseDoubleClick += new global::System.Windows.Input.MouseButtonEventHandler(this.OnFieldNameDoubleClick);
			return;
			IL_850E:
			this.RadWideTPSFiregroundVoiceTxEndTone_A9655Comp = (global::AcpUI.AcpCheckBox)target;
			return;
			IL_851B:
			this.RTDBtnRadWideUniversalRelayControllerFatalError_A37194 = (global::AcpUI.AcpRtdButton)target;
			return;
			IL_8528:
			this.RTDBtnRadWidePowerLevelBandFrequency_A41063 = (global::AcpUI.AcpRtdButton)target;
			return;
			IL_8535:
			this.RadWideLabtoolUltraLowPowerSoldierMacCapable_A41710Comp = (global::AcpUI.AcpLabel)target;
			return;
			IL_8542:
			this.RadErgoWideAdvancedModeSelTxName = (global::AcpUI.AcpComboBox)target;
			this.RadErgoWideAdvancedModeSelTxName.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_8566:
			this.gridExpanderRadioWideTxPowerLevelsByFrequencyRangeSRecView = (global::System.Windows.Controls.Grid)target;
			return;
			IL_8573:
			this.RTDBtnRadWideAdvancedMaximumTxDeviation_A8480 = (global::AcpUI.AcpRtdButton)target;
			return;
			IL_8580:
			this.GrpBoxExpanderRadioWideDigitalAudioOptionsPseudo2 = (global::AcpUI.AcpGroupBox)target;
			return;
			IL_858D:
			this.RadWideGenLightBarPatternRelay6_A36511Comp = (global::AcpUI.AcpLabel)target;
			return;
			IL_859A:
			this.RTDBtnRadWideLabtoolMultipleConversationDisable_A19552 = (global::AcpUI.AcpRtdButton)target;
			return;
			IL_85A7:
			this.RTDBtnRadWideTPSEmergencyPTTTransmission_A41544 = (global::AcpUI.AcpRtdButton)target;
			return;
			IL_85B4:
			this.RTDBtnRadWideFeaturesInactivityAutoPoweroff_A38013 = (global::AcpUI.AcpRtdButton)target;
			return;
			IL_85C1:
			this.CpyBtnPASSAlarmFilterCapable_A42387 = (global::AcpUI.AcpCopyButton)target;
			return;
			IL_85CE:
			this.LblRadWideGeneralTimeFormat_A9377 = (global::AcpUI.AcpLabel)target;
			this.LblRadWideGeneralTimeFormat_A9377.MouseDoubleClick += new global::System.Windows.Input.MouseButtonEventHandler(this.OnFieldNameDoubleClick);
			return;
			IL_85F2:
			this.CpyBtnRadWideLabtoolArchiveReadPasswordEnable_A7462 = (global::AcpUI.AcpCopyButton)target;
			return;
			IL_85FF:
			this.RadWideGeneralTlsPsk_44841Comp = (global::AcpUI.AcpLabel)target;
			return;
			IL_860C:
			this.CVBtnRadWideLabtoolDisplayContrastConfiguration_A7873 = (global::AcpUI.AcpCustomViewCheckBox)target;
			return;
			IL_8619:
			this.LblRadWideLabtoolSuppressEmergencyCallCapability_A42143 = (global::AcpUI.AcpLabel)target;
			this.LblRadWideLabtoolSuppressEmergencyCallCapability_A42143.MouseDoubleClick += new global::System.Windows.Input.MouseButtonEventHandler(this.OnFieldNameDoubleClick);
			return;
			IL_863D:
			this.RTDBtnRadWideLabtoolUltraLowPowerSoldierMacCapable_A41710 = (global::AcpUI.AcpRtdButton)target;
			return;
			IL_864A:
			this.CVBtnSensorEventDisableTimer_43198 = (global::AcpUI.AcpCustomViewCheckBox)target;
			return;
			IL_8657:
			this.RTDBtnRadWideFeaturesZoneCloneEnable_43130 = (global::AcpUI.AcpRtdButton)target;
			return;
			IL_8664:
			this.RTDBtnRadWideUserInformationandPasswordsRadioAliasEnable_A8830 = (global::AcpUI.AcpRtdButton)target;
			return;
			IL_8671:
			this.HLinkLightbarPattern = (global::System.Windows.Documents.Hyperlink)target;
			this.HLinkLightbarPattern.Click += this.HLinkClick;
			return;
			IL_8695:
			this.CVBtnRadWideLocationSystemManagedGeofence_43042 = (global::AcpUI.AcpCustomViewCheckBox)target;
			return;
			IL_86A2:
			this.RadWideLabtoolEnhancedARS_A43084Comp = (global::AcpUI.AcpLabel)target;
			return;
			IL_86AF:
			this.CVBtnRadWideAdvancedRFModem_A8972 = (global::AcpUI.AcpCustomViewCheckBox)target;
			return;
			IL_86BC:
			this.CVBtnRadWideBluetoothBluetoothDiscoverableExpirationTimer_41980 = (global::AcpUI.AcpCustomViewCheckBox)target;
			return;
			IL_86C9:
			this.CVBtnRadWideGenLightBarPatternRelay7_A36512 = (global::AcpUI.AcpCustomViewCheckBox)target;
			return;
			IL_86D6:
			this.CVBtnRadWideBluetoothActiveRSMInternalMicIfNotBtMic_A41576 = (global::AcpUI.AcpCustomViewCheckBox)target;
			return;
			IL_86E3:
			this.RTDBtnRadWideUserInformationandPasswordsRadioLockForceChangePassword_A3583 = (global::AcpUI.AcpRtdButton)target;
			return;
			IL_86F0:
			this.GrpBoxExpanderRadioWideUserInformationAndPasswordsZoneProtection = (global::AcpUI.AcpGroupBox)target;
			return;
			IL_86FD:
			this.CpyBtnRadWideLabtoolDigitalAnalogBalance_A7851 = (global::AcpUI.AcpCopyButton)target;
			return;
			IL_870A:
			this.CVBtnRadWideUserInformationandUserLoginUnitIDTextSize_41309 = (global::AcpUI.AcpCustomViewCheckBox)target;
			return;
			IL_8717:
			this.CVBtnRadWideTransmitPowerLevelsConvTxPowerLevelLowW_A41861 = (global::AcpUI.AcpCustomViewCheckBox)target;
			return;
			IL_8724:
			this.RadWideGenLightBarPatternRelay4_A36509_Col = (global::Infragistics.Windows.DataPresenter.UnboundField)target;
			return;
			IL_8731:
			this.RTDBtnRadWideFeaturesVLIFPLOSSFIELD_A9596 = (global::AcpUI.AcpRtdButton)target;
			return;
			IL_873E:
			this.CVBtnRadProfAlertTonesMuteTonesOperation_A8562 = (global::AcpUI.AcpCustomViewCheckBox)target;
			return;
			IL_874B:
			this.RadWideTransmitPowerLevelsTxPowerLevelMinimumW_A41858 = (global::AcpUI.AcpTextBox)target;
			this.RadWideTransmitPowerLevelsTxPowerLevelMinimumW_A41858.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_876F:
			this.CVBtnRadWideBluetoothBluetoothReconnectTimer_A37037 = (global::AcpUI.AcpCustomViewCheckBox)target;
			return;
			IL_877C:
			this.RadWideDigitalAudioOptionsStrongInterference1_A9207Comp = (global::AcpUI.AcpCheckBox)target;
			return;
			IL_8789:
			this.CpyBtnRadWideLabtoolMaritimeRadioSoftware_A42191 = (global::AcpUI.AcpCopyButton)target;
			return;
			IL_8796:
			this.CVBtnRadWideFeaturesVoiceControlPriority = (global::AcpUI.AcpCustomViewCheckBox)target;
			return;
			IL_87A3:
			this.LblRadWideLabtoolDynamicZoneScanCapability_42749 = (global::AcpUI.AcpLabel)target;
			this.LblRadWideLabtoolDynamicZoneScanCapability_42749.MouseDoubleClick += new global::System.Windows.Input.MouseButtonEventHandler(this.OnFieldNameDoubleClick);
			return;
			IL_87C7:
			this.RTDBtnRadWideGeneralASKRequired_A37152 = (global::AcpUI.AcpRtdButton)target;
			return;
			IL_87D4:
			this.CpyBtnRadWideLabtoolZoneSelectorOnSwitch_A19550 = (global::AcpUI.AcpCopyButton)target;
			return;
			IL_87E1:
			this.RadWideLocationDisplayPeerLocation_42433 = (global::AcpUI.AcpCheckBox)target;
			this.RadWideLocationDisplayPeerLocation_42433.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_8805:
			this.CVBtnRadioWideLabtoolZoneCloneCapable_43238 = (global::AcpUI.AcpCustomViewCheckBox)target;
			return;
			IL_8812:
			this.CpyBtnRadWideSecureNFCPairing_A44931 = (global::AcpUI.AcpCopyButton)target;
			return;
			IL_881F:
			this.CpyBtnRadProfAlertTonesLED_A8428 = (global::AcpUI.AcpCopyButton)target;
			return;
			IL_882C:
			this.CpyBtnRadWideLabtoolTxStartFrequencySplit_A9571 = (global::AcpUI.AcpCopyButton)target;
			return;
			IL_8839:
			this.RTDBtnRadWideUserInformationandPasswordsProtectedZonePassword_A8766 = (global::AcpUI.AcpRtdButton)target;
			return;
			IL_8846:
			this.RTDBtnRadWideGenLightBarPatternRelay2_A36507 = (global::AcpUI.AcpRtdButton)target;
			return;
			IL_8853:
			num = (short)66424165;
			short num3 = num;
			num = (short)2019593573;
			switch ((num3 == num) ? 1 : 0)
			{
			case 0:
			case 2:
				goto IL_2F82;
			default:
				num = (short)637599744;
				if (num != 0)
				{
				}
				this.CVBtnRadWideUserInformationandUserLoginUnitID_41306 = (global::AcpUI.AcpCustomViewCheckBox)target;
				return;
			}
			IL_88AB:
			this.RadioErgoConfigACMissionCriticalGeofenceMode_42918Comp = (global::AcpUI.AcpLabel)target;
			return;
			IL_88B8:
			this.CVBtnRadWideFeaturesMapping = (global::AcpUI.AcpCustomViewCheckBox)target;
			return;
			IL_88C5:
			this.CpyBtnRadWideLocationUserSelectableLocationEnable_A9605 = (global::AcpUI.AcpCopyButton)target;
			return;
			IL_88D2:
			this.RadWideLabtoolFCCNarrowBandStartFrequency_A38270Comp = (global::AcpUI.AcpLabel)target;
			return;
			IL_88DF:
			this.RadWideGeneralDnsSdAddress_44843Comp = (global::AcpUI.AcpLabel)target;
			return;
			IL_88EC:
			this.CpyBtnRadioWideLabtoolDisableWindNoiseReductionLevelForAccessories_43548 = (global::AcpUI.AcpCopyButton)target;
			return;
			IL_88F9:
			this.CVBtnRadWideGeneralPskId_44840 = (global::AcpUI.AcpCustomViewCheckBox)target;
			return;
			IL_8906:
			this.RadWideBluetoothBluetoothDeviceInquiryDuration_41977 = (global::AcpUI.AcpTextBoxSpinner)target;
			this.RadWideBluetoothBluetoothDeviceInquiryDuration_41977.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_892A:
			this.RadWideFeaturesVLIFPLOSSFIELD_A9596 = (global::AcpUI.AcpComboBox)target;
			this.RadWideFeaturesVLIFPLOSSFIELD_A9596.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_894E:
			num = (short)1297154049;
			if (num != 0)
			{
			}
			this.CpyBtnRadWideGunlockRelocktimerTimer_A36522 = (global::AcpUI.AcpCopyButton)target;
			return;
			IL_8982:
			this.RadWideTransmitPowerLevelsConvTxPowerLevelMinimumW_A41173_Col = (global::Infragistics.Windows.DataPresenter.UnboundField)target;
			return;
			IL_898F:
			this.RadWideAdvancedRFModem_A8972 = (global::AcpUI.AcpComboBox)target;
			this.RadWideAdvancedRFModem_A8972.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_89B3:
			this.LblRadWideAlertTonesRSMVolumeSetTone = (global::AcpUI.AcpLabel)target;
			this.LblRadWideAlertTonesRSMVolumeSetTone.MouseDoubleClick += new global::System.Windows.Input.MouseButtonEventHandler(this.OnFieldNameDoubleClick);
			return;
			IL_89D7:
			this.RTDBtnRadProfAlertTonesMuteTonesOperation_A8562 = (global::AcpUI.AcpRtdButton)target;
			return;
			IL_89E4:
			this.CVBtnRadWideFeaturesPowerManagementStandbyTime = (global::AcpUI.AcpCustomViewCheckBox)target;
			return;
			IL_89F1:
			this.RadWideDualRadioTalkgroupMuteOption_A42290 = (global::AcpUI.AcpComboBox)target;
			this.RadWideDualRadioTalkgroupMuteOption_A42290.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_8A15:
			this.LblRadWideDigitalAudioOptionsWeakSignalFringe_A9679 = (global::AcpUI.AcpLabel)target;
			this.LblRadWideDigitalAudioOptionsWeakSignalFringe_A9679.MouseDoubleClick += new global::System.Windows.Input.MouseButtonEventHandler(this.OnFieldNameDoubleClick);
			return;
			IL_8A39:
			this.RadWideLabtoolADPGatingPCIBitComp = (global::AcpUI.AcpLabel)target;
			return;
			IL_8A46:
			this.LblRadWideAdvancedRFModem_A8972 = (global::AcpUI.AcpLabel)target;
			this.LblRadWideAdvancedRFModem_A8972.MouseDoubleClick += new global::System.Windows.Input.MouseButtonEventHandler(this.OnFieldNameDoubleClick);
			return;
			IL_8A6A:
			this.CVBtnRadWideUserInformationandUserLoginUnitIDEnable_41305 = (global::AcpUI.AcpCustomViewCheckBox)target;
			return;
			IL_8A77:
			this.LblRadWideSmartMappingServerAssistedLocation = (global::AcpUI.AcpLabel)target;
			this.LblRadWideSmartMappingServerAssistedLocation.MouseDoubleClick += new global::System.Windows.Input.MouseButtonEventHandler(this.OnFieldNameDoubleClick);
			return;
			IL_8A9B:
			this.RadWideTalkProhibitToneSelection_A42416 = (global::AcpUI.AcpComboBox)target;
			this.RadWideTalkProhibitToneSelection_A42416.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_8ABF:
			this.RadWideLabtoolEmergencyCallOnlywithHotMicCapable_A43162Comp = (global::AcpUI.AcpLabel)target;
			return;
			IL_8ACC:
			this.CpyBtnRadWideAdvancedRecordAudio_A8922 = (global::AcpUI.AcpCopyButton)target;
			return;
			IL_8AD9:
			this.LblRadWideLabtoolADPGatingPCIBit = (global::AcpUI.AcpLabel)target;
			this.LblRadWideLabtoolADPGatingPCIBit.MouseDoubleClick += new global::System.Windows.Input.MouseButtonEventHandler(this.OnFieldNameDoubleClick);
			return;
			IL_8AFD:
			this.CVBtnRadWideLabtoolTxBandSplitName_A24799 = (global::AcpUI.AcpCustomViewCheckBox)target;
			return;
			IL_8B0A:
			this.RadWidePowerLevelBandFrequency_A41864 = (global::AcpUI.AcpLabel)target;
			this.RadWidePowerLevelBandFrequency_A41864.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_8B2E:
			this.RTDBtnRadWideFeatureAnalogWidebandData = (global::AcpUI.AcpRtdButton)target;
			return;
			IL_8B3B:
			this.LblRadWideRecentCallListDeleteEnable = (global::AcpUI.AcpLabel)target;
			this.LblRadWideRecentCallListDeleteEnable.MouseDoubleClick += new global::System.Windows.Input.MouseButtonEventHandler(this.OnFieldNameDoubleClick);
			return;
			IL_8B5F:
			this.RTDBtnRadWideTPSAudibleEmergencyBeaconsec_A7502 = (global::AcpUI.AcpRtdButton)target;
			return;
			IL_8B6C:
			this.RadWideOutOfRangeToneSelection_A42450Comp = (global::AcpUI.AcpLabel)target;
			return;
			IL_8B79:
			this.RadWideGeneralLogDisp_A9756Comp = (global::AcpUI.AcpCheckBox)target;
			return;
			IL_8B86:
			this.RTDBtnRadWideTransmitPowerLevelsConvTxPowerLevelLowW_A41175 = (global::AcpUI.AcpRtdButton)target;
			return;
			IL_8B93:
			this.RadWideFeatureDynamicIcons_A42963Comp = (global::AcpUI.AcpCheckBox)target;
			return;
			IL_8BA0:
			this.RadWideBluetoothAudioBackwardsCompatibility_A44942 = (global::AcpUI.AcpCheckBox)target;
			this.RadWideBluetoothAudioBackwardsCompatibility_A44942.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_8BC4:
			this.CVBtnRadWideAlertTonesTxChirp_A9523 = (global::AcpUI.AcpCustomViewCheckBox)target;
			return;
			IL_8BD1:
			this.CpyBtnRadWideFeaturesDisableIgnitionAutoPowerOffAlert_A38015 = (global::AcpUI.AcpCopyButton)target;
			return;
			IL_8BDE:
			this.RadWideBluetoothBluetoothEnable_A37028Comp = (global::AcpUI.AcpCheckBox)target;
			return;
			IL_8BEB:
			this.RTDBtnRadWideGeneralTimeFormat_A9377 = (global::AcpUI.AcpRtdButton)target;
			return;
			IL_8BF8:
			this.RecNavToolbarExpanderRadioWideRxFrequencySplitFPP = (global::AcpUI.AcpRecNavToolbar)target;
			this.RecNavToolbarExpanderRadioWideRxFrequencySplitFPP.ModeClick += this.OnModeClick;
			return;
			IL_8C1C:
			this.LblRadWideGenLgtBarName_A36505 = (global::AcpUI.AcpLabel)target;
			this.LblRadWideGenLgtBarName_A36505.MouseDoubleClick += new global::System.Windows.Input.MouseButtonEventHandler(this.OnFieldNameDoubleClick);
			return;
			IL_8C40:
			this.LblRadWideGunlockRelocktimerName_A36521 = (global::AcpUI.AcpLabel)target;
			this.LblRadWideGunlockRelocktimerName_A36521.MouseDoubleClick += new global::System.Windows.Input.MouseButtonEventHandler(this.OnFieldNameDoubleClick);
			return;
			IL_8C64:
			this.RadWideTransmitPowerLevelsFrequencyRangeStartMHz_A41856Comp = (global::AcpUI.AcpLabel)target;
			return;
			IL_8C71:
			this.gridExpanderRadioWideTxFrequencySplitFPPSRecView = (global::System.Windows.Controls.Grid)target;
			return;
			IL_8C7E:
			this.RTDBtnRadioErgoConfigACMissionCriticalGeofenceMode_42918 = (global::AcpUI.AcpRtdButton)target;
			return;
			IL_8C8B:
			this.RTDBtnRadWideLabtoolRadioPassword_A8837 = (global::AcpUI.AcpRtdButton)target;
			return;
			IL_8C98:
			this.RadWideGenLightBarPatternRelay5_A36510 = (global::AcpUI.AcpComboBox)target;
			this.RadWideGenLightBarPatternRelay5_A36510.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_8CBC:
			this.RTDBtnRadWideFeaturesDisplayLastAcknowledgedUserStatusorMessage_A42000 = (global::AcpUI.AcpRtdButton)target;
			return;
			IL_8CC9:
			this.CpyBtnRadWideFiregroundPTTTransmission_A33515 = (global::AcpUI.AcpCopyButton)target;
			return;
			IL_8CD6:
			this.RadWideFeaturesEnableInvalidSIMNotification_A44945 = (global::AcpUI.AcpCheckBox)target;
			this.RadWideFeaturesEnableInvalidSIMNotification_A44945.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_8CFA:
			this.ExpanderRadioWideRelockTimerGrid = (global::System.Windows.Controls.Grid)target;
			return;
			IL_8D07:
			this.CVBtnRadWideGenLgtBarName_A36505 = (global::AcpUI.AcpCustomViewCheckBox)target;
			return;
			IL_8D14:
			this.RadioWideMOSCADACE3000Capability_A42772Comp = (global::AcpUI.AcpLabel)target;
			return;
			IL_8D21:
			this.ExpanderRadioWideTxPowerLevelsByFrequencyRangeNewBandPlanGrid = (global::System.Windows.Controls.Grid)target;
			return;
			IL_8D2E:
			this.RadWideBluetoothAudioBackwardsCompatibility_A44942Comp = (global::AcpUI.AcpCheckBox)target;
			return;
			IL_8D3B:
			this.GrpBoxExpanderRadioWideFeaturesChannelChangeOnHUB = (global::AcpUI.AcpGroupBox)target;
			return;
			IL_8D48:
			this.LblRadWideTransmitPowerLevelsConvTxPowerLevelMinimumW_A41173 = (global::AcpUI.AcpLabel)target;
			this.LblRadWideTransmitPowerLevelsConvTxPowerLevelMinimumW_A41173.MouseDoubleClick += new global::System.Windows.Input.MouseButtonEventHandler(this.OnFieldNameDoubleClick);
			return;
			IL_8D6C:
			this.RTDBtnRadioWidePTTWarningTone = (global::AcpUI.AcpRtdButton)target;
			return;
			IL_8D79:
			this.RTDBtnRadWideGenLightBarPatternRelay8_A36513 = (global::AcpUI.AcpRtdButton)target;
			return;
			IL_8D86:
			this.LblRadWideLabtoolMultipleConversationDisable_A19552 = (global::AcpUI.AcpLabel)target;
			this.LblRadWideLabtoolMultipleConversationDisable_A19552.MouseDoubleClick += new global::System.Windows.Input.MouseButtonEventHandler(this.OnFieldNameDoubleClick);
			return;
			IL_8DAA:
			this.CpyBtnRadWideLocationExitLocationMenuonPTT_A13081 = (global::AcpUI.AcpCopyButton)target;
			return;
			IL_8DB7:
			this.RadWideBluetoothBluetoothReconnectTimer_A37037Comp = (global::AcpUI.AcpLabel)target;
			return;
			IL_8DC4:
			this.RadWideBluetoothBluetoothDropTimer_A37038 = (global::AcpUI.AcpComboBox)target;
			this.RadWideBluetoothBluetoothDropTimer_A37038.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_8DE8:
			this.RadWideLabtoolFlipDisplayOption_A8140 = (global::AcpUI.AcpCheckBox)target;
			this.RadWideLabtoolFlipDisplayOption_A8140.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_8E0C:
			this.CpyBtnRadWideTPSFiregroundEmergencyPTTTransmission_A33203 = (global::AcpUI.AcpCopyButton)target;
			return;
			IL_8E19:
			this.RTDBtnRadWideAudioConfigurationLevel_42740 = (global::AcpUI.AcpRtdButton)target;
			return;
			IL_8E26:
			this.RTDBtnRadWideLabtoolConsoletteModelEnable_A7713 = (global::AcpUI.AcpRtdButton)target;
			return;
			IL_8E33:
			this.LblRadWideLabtoolEncryptPassword_A41695 = (global::AcpUI.AcpLabel)target;
			this.LblRadWideLabtoolEncryptPassword_A41695.MouseDoubleClick += new global::System.Windows.Input.MouseButtonEventHandler(this.OnFieldNameDoubleClick);
			return;
			IL_8E57:
			this.RTDBtnRadWideFeaturesRadioInhibitUIEnabled_44914 = (global::AcpUI.AcpRtdButton)target;
			return;
			IL_8E64:
			this.CpyBtnRadWideUserInformationAndPasswordsTacticalInhibitEncodePassword_A34395 = (global::AcpUI.AcpCopyButton)target;
			return;
			IL_8E71:
			this.RadProfAlertTonesCallAlertToneAutoReset_A7596Comp = (global::AcpUI.AcpCheckBox)target;
			return;
			IL_8E7E:
			this.CpyBtnRadWideBluetoothBluetoothDiscoverableExpirationTimer_41980 = (global::AcpUI.AcpCopyButton)target;
			return;
			IL_8E8B:
			this.CVBtnRadioWideLabtoolDisableWindNoiseReductionLevelForAccessories_43548 = (global::AcpUI.AcpCustomViewCheckBox)target;
			return;
			IL_8E98:
			this.RTDBtnRadWideGenLightBarPatternRelay3_A36508 = (global::AcpUI.AcpRtdButton)target;
			return;
			IL_8EA5:
			this.CVBtnRadWideTransmitPowerLevelsFrequencyRangeStartMHz_A19994 = (global::AcpUI.AcpCustomViewCheckBox)target;
			return;
			IL_8EB2:
			this.CpyBtnRadWideBluetoothFriendlyNameEditable_A41182 = (global::AcpUI.AcpCopyButton)target;
			return;
			IL_8EBF:
			this.CpyBtnRadWideTPSPTTTransmission_A41545 = (global::AcpUI.AcpCopyButton)target;
			return;
			IL_8ECC:
			this.LblRadWideFeaturesChanChangeOnOffHookEnable_A42354 = (global::AcpUI.AcpLabel)target;
			this.LblRadWideFeaturesChanChangeOnOffHookEnable_A42354.MouseDoubleClick += new global::System.Windows.Input.MouseButtonEventHandler(this.OnFieldNameDoubleClick);
			return;
			IL_8EF0:
			this.CVBtnRadWideLabtoolUltraLowPowerSoldierMacCapable_A41710 = (global::AcpUI.AcpCustomViewCheckBox)target;
			return;
			IL_8EFD:
			this.RTDBtnRadWideUserInformationandPasswordsRadioLockAttemptsAllowed_A3582 = (global::AcpUI.AcpRtdButton)target;
			return;
			IL_8F0A:
			this.RTDBtnUCLContactsLimitationEnhancement_43811 = (global::AcpUI.AcpRtdButton)target;
			return;
			IL_8F17:
			this.CpyBtnRadWideConventionalDynamicIDWithPassword_A43705 = (global::AcpUI.AcpCopyButton)target;
			return;
			IL_8F24:
			this.RadWideLabtoolLTEUsed_A42064Comp = (global::AcpUI.AcpLabel)target;
			return;
			IL_8F31:
			this.RadWideGenLightBarPatternRelay6_A36511_Col = (global::Infragistics.Windows.DataPresenter.UnboundField)target;
			return;
			IL_8F3E:
			this.RadWideLabtoolAPX6000P25Radio_A42121Comp = (global::AcpUI.AcpLabel)target;
			return;
			IL_8F4B:
			this.CpyBtnRadWideDigitalAudioOptionsWeakSignalFringe_A9679 = (global::AcpUI.AcpCopyButton)target;
			return;
			IL_8F58:
			this.LblRadWideTalkProhibitToneSelection_A42416 = (global::AcpUI.AcpLabel)target;
			this.LblRadWideTalkProhibitToneSelection_A42416.MouseDoubleClick += new global::System.Windows.Input.MouseButtonEventHandler(this.OnFieldNameDoubleClick);
			return;
			IL_8F7C:
			this.RadWideLabtoolDeviceMgmtSeamlessUpdateRmPsk = (global::AcpUI.AcpTextBox)target;
			this.RadWideLabtoolDeviceMgmtSeamlessUpdateRmPsk.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_8FA0:
			this.RadWideTransmitPowerLevelsTrkTxPowerLevelMinimumW_A41862 = (global::AcpUI.AcpTextBox)target;
			this.RadWideTransmitPowerLevelsTrkTxPowerLevelMinimumW_A41862.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_8FC4:
			this.RadWideReverseGeocodedLocationDisplayFormat = (global::AcpUI.AcpComboBox)target;
			this.RadWideReverseGeocodedLocationDisplayFormat.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_8FE8:
			this.LblRadWideLabtoolTxBandSplitName_A24799 = (global::AcpUI.AcpLabel)target;
			this.LblRadWideLabtoolTxBandSplitName_A24799.MouseDoubleClick += new global::System.Windows.Input.MouseButtonEventHandler(this.OnFieldNameDoubleClick);
			return;
			IL_900C:
			this.CpyBtnRadWideUserInformationandPasswordsSoftIDUsername_A9169 = (global::AcpUI.AcpCopyButton)target;
			return;
			IL_9019:
			this.CVBtnRadWideGeneralLogDisp_A9756 = (global::AcpUI.AcpCustomViewCheckBox)target;
			return;
			IL_9026:
			this.CpyBtnRadWideTPSFiregroundEmergencyCallDekeySidetone_A7936 = (global::AcpUI.AcpCopyButton)target;
			return;
			IL_9033:
			this.RTDBtnRadWideUserInformationandPasswordsRadioLock_A8836 = (global::AcpUI.AcpRtdButton)target;
			return;
			IL_9040:
			this.CVBtnDVRSRangeExt_44809 = (global::AcpUI.AcpCustomViewCheckBox)target;
			return;
			IL_904D:
			this.CpyBtnRadWideLabtoolDeviceMgmtSeamlessUpdateRmPsk = (global::AcpUI.AcpCopyButton)target;
			return;
			IL_905A:
			this.CpyBtnRadWideBluetoothAudioBackwardsCompatibility_A44942 = (global::AcpUI.AcpCopyButton)target;
			return;
			IL_9067:
			this.MyStackPanel = (global::System.Windows.Controls.StackPanel)target;
			return;
			IL_9074:
			this.LblDVRSRangeExt_44809 = (global::AcpUI.AcpLabel)target;
			this.LblDVRSRangeExt_44809.MouseDoubleClick += new global::System.Windows.Input.MouseButtonEventHandler(this.OnFieldNameDoubleClick);
			return;
			IL_9098:
			this.CpyBtnSensorEventNotificationEnable_43525 = (global::AcpUI.AcpCopyButton)target;
			return;
			IL_90A5:
			this.RadWideLabtoolEncryptPassword_A41695 = (global::AcpUI.AcpLabel)target;
			this.RadWideLabtoolEncryptPassword_A41695.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_90C9:
			this.CpyBtnRadioWideLabtoolEmergencyCallTermination_43348 = (global::AcpUI.AcpCopyButton)target;
			return;
			IL_90D6:
			this.RTDBtnRadWideDualRadioEmergencyRadio_A42239 = (global::AcpUI.AcpRtdButton)target;
			return;
			IL_90E3:
			this.RadWideFeaturesZoneCloneEnable_43130 = (global::AcpUI.AcpCheckBox)target;
			this.RadWideFeaturesZoneCloneEnable_43130.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_9107:
			this.AllowPSUSecure_43809 = (global::AcpUI.AcpLabel)target;
			this.AllowPSUSecure_43809.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_912B:
			this.CpyBtnRadWideBluetoothBluetoothReconnectTimer_A37037 = (global::AcpUI.AcpCopyButton)target;
			return;
			IL_9138:
			this.CVBtnRadWideUserInformationandPasswordsSecureHardwareAutoLogin_A7508 = (global::AcpUI.AcpCustomViewCheckBox)target;
			return;
			IL_9145:
			this.CpyBtnRadWideGeneralTimeFormat_A9377 = (global::AcpUI.AcpCopyButton)target;
			return;
			IL_9152:
			this.RTDBtnRadWideGeneralLogDisp_A9756 = (global::AcpUI.AcpRtdButton)target;
			return;
			IL_915F:
			this.CVBtnRadWideMPPPairingOnlyWithLTE_A42320 = (global::AcpUI.AcpCustomViewCheckBox)target;
			return;
			IL_916C:
			this.CVBtnRadWideUserInformationandPasswordsMandatoryPassword_A8461 = (global::AcpUI.AcpCustomViewCheckBox)target;
			return;
			IL_9179:
			this.IsolatedGCAIAccessoryPlugAndPlayDisable_42927Comp = (global::AcpUI.AcpCheckBox)target;
			return;
			IL_9186:
			this.ExpanderRadioWideTxPowerLevelsByFrequencyRangeSRecView = (global::AcpUI.AcpGroupBox)target;
			return;
			IL_9193:
			this.CpyBtnRadWideTransmitPowerLevelsConvTxPowerLevelMinimumW_A41173 = (global::AcpUI.AcpCopyButton)target;
			return;
			IL_91A0:
			this.RadWideUserInformationandPasswordsUserLoginAuthenticationType_A44926Comp = (global::AcpUI.AcpLabel)target;
			return;
			IL_91AD:
			this.DVRSRangeExt_44809Comp = (global::AcpUI.AcpLabel)target;
			return;
			IL_91BA:
			this.RadWideGeneralOwnerSystemID_A37153Comp = (global::AcpUI.AcpTextBoxDecHex)target;
			return;
			IL_91C7:
			this.RadWideLabtoolPAAlertCapability_A42944 = (global::AcpUI.AcpLabel)target;
			this.RadWideLabtoolPAAlertCapability_A42944.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_91EB:
			this.LblRadWideUserInformationandPasswordsPIN_A8705 = (global::AcpUI.AcpLabel)target;
			this.LblRadWideUserInformationandPasswordsPIN_A8705.MouseDoubleClick += new global::System.Windows.Input.MouseButtonEventHandler(this.OnFieldNameDoubleClick);
			return;
			IL_920F:
			this.RTDBtnRadWideFeaturesSmartMessagingSmartMessageMode = (global::AcpUI.AcpRtdButton)target;
			return;
			IL_921C:
			this.RadWideLabtoolZoneSelectorOnSwitch_A19550 = (global::AcpUI.AcpCheckBox)target;
			this.RadWideLabtoolZoneSelectorOnSwitch_A19550.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_9240:
			this.LblRadWideFeaturePreAmpVHF_A42960 = (global::AcpUI.AcpLabel)target;
			this.LblRadWideFeaturePreAmpVHF_A42960.MouseDoubleClick += new global::System.Windows.Input.MouseButtonEventHandler(this.OnFieldNameDoubleClick);
			return;
			IL_9264:
			this.RTDBtnRadWideLabtoolUserSelectablePLEnhancement_43031 = (global::AcpUI.AcpRtdButton)target;
			return;
			IL_9271:
			this.LblRadWideTPSFiregroundPeriodicUpdateTimer_A33467 = (global::AcpUI.AcpLabel)target;
			this.LblRadWideTPSFiregroundPeriodicUpdateTimer_A33467.MouseDoubleClick += new global::System.Windows.Input.MouseButtonEventHandler(this.OnFieldNameDoubleClick);
			return;
			IL_9295:
			this.TEN_DIGIT_RL_PSWD_capable_43711 = (global::AcpUI.AcpLabel)target;
			this.TEN_DIGIT_RL_PSWD_capable_43711.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_92B9:
			this.RadWideGunlockRelocktimerTimer_A36522Comp = (global::AcpUI.AcpLabel)target;
			return;
			IL_92C6:
			this.RTDBtnRadWideCustomLogoEnabled = (global::AcpUI.AcpRtdButton)target;
			return;
			IL_92D3:
			this.RadWidePowerLevelBandFrequency_A41063Comp = (global::AcpUI.AcpLabel)target;
			return;
			IL_92E0:
			this.CpyBtnRadWideTransmitPowerLevelsFrequencyRangeStartMHz_A41856 = (global::AcpUI.AcpCopyButton)target;
			return;
			IL_92ED:
			this.CpyBtnRadWideBluetoothActiveRSMInternalMicIfNotBtMic_A41576 = (global::AcpUI.AcpCopyButton)target;
			return;
			IL_92FA:
			this.CpyBtnRadWideEmergencyRxTxAlertToneSet_A41508 = (global::AcpUI.AcpCopyButton)target;
			return;
			IL_9307:
			this.LblRadWideFeaturePreAmpUHF_A42962 = (global::AcpUI.AcpLabel)target;
			this.LblRadWideFeaturePreAmpUHF_A42962.MouseDoubleClick += new global::System.Windows.Input.MouseButtonEventHandler(this.OnFieldNameDoubleClick);
			return;
			IL_932B:
			this.CpyBtnRadWideLabtoolDynamicZoneScanCapability_42749 = (global::AcpUI.AcpCopyButton)target;
			return;
			IL_9338:
			this.RadWideUserInformationandPasswordsRadioLockAttemptsAllowed_A3582Comp = (global::AcpUI.AcpLabel)target;
			return;
			IL_9345:
			this.CpyBtnRadProfAlertTonesMuteTonesOperation_A8562 = (global::AcpUI.AcpCopyButton)target;
			return;
			IL_9352:
			this.CpyBtnRadWideFeatureDynamicIcons_A42963 = (global::AcpUI.AcpCopyButton)target;
			return;
			IL_935F:
			this.RadDualRadioFatalErrorOption_A42243Comp = (global::AcpUI.AcpLabel)target;
			return;
			IL_936C:
			this.LblRadWideLocationDistanceUnit_A13080 = (global::AcpUI.AcpLabel)target;
			this.LblRadWideLocationDistanceUnit_A13080.MouseDoubleClick += new global::System.Windows.Input.MouseButtonEventHandler(this.OnFieldNameDoubleClick);
			return;
			IL_9390:
			this.CpyBtnRadioWideMOSCADACE3000Capability_A42772 = (global::AcpUI.AcpCopyButton)target;
			return;
			IL_939D:
			this.RTDBtnRadWideBluetoothBluetoothRSMLED_A37039 = (global::AcpUI.AcpRtdButton)target;
			return;
			IL_93AA:
			this.CpyBtnRadWideLabtoolAPX6000P25Radio_A42121 = (global::AcpUI.AcpCopyButton)target;
			return;
			IL_93B7:
			this.CVBtnRadioWideLabtoolExtendedPLToneSet_43769 = (global::AcpUI.AcpCustomViewCheckBox)target;
			return;
			IL_93C4:
			this.ExpanderRadioWideTxPowerLevelsByFrequencyRangeNewBandPlanTableView = (global::AcpUI.AcpGroupBox)target;
			return;
			IL_93D1:
			this.ExpanderRadioWideRelockTimerSRecView = (global::AcpUI.AcpGroupBox)target;
			return;
			IL_93DE:
			this.CVBtnRadCfgLocationReporting = (global::AcpUI.AcpCustomViewCheckBox)target;
			return;
			IL_93EB:
			this.LblRadWideLabtoolMaritimeRadioSoftware_A42191 = (global::AcpUI.AcpLabel)target;
			this.LblRadWideLabtoolMaritimeRadioSoftware_A42191.MouseDoubleClick += new global::System.Windows.Input.MouseButtonEventHandler(this.OnFieldNameDoubleClick);
			return;
			IL_940F:
			this.RTDBtnRadWideTransmitPowerLevelsTxPowerLevelMaximumW_A20039 = (global::AcpUI.AcpRtdButton)target;
			return;
			IL_941C:
			this.GrpBoxExpanderRadioWideAlertTonesPseudo0 = (global::AcpUI.AcpGroupBox)target;
			return;
			IL_9429:
			this.HLinkFeatures = (global::System.Windows.Documents.Hyperlink)target;
			this.HLinkFeatures.Click += this.HLinkClick;
			return;
			IL_944D:
			this.CpyBtnRadWideLabtoolDeviceMgmtEnterpriseWifiCodeplugId = (global::AcpUI.AcpCopyButton)target;
			return;
			IL_945A:
			this.RadWideLabtoolEmergencyCallOnlywithHotMicCapable_A43162 = (global::AcpUI.AcpLabel)target;
			this.RadWideLabtoolEmergencyCallOnlywithHotMicCapable_A43162.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_947E:
			this.RTDBtnRadWideLabtoolSirenPaFatalError_A9141 = (global::AcpUI.AcpRtdButton)target;
			return;
			IL_948B:
			this.CVBtnRadWideLabtoolSeamlessUpdateOutOfBoxExperience = (global::AcpUI.AcpCustomViewCheckBox)target;
			return;
			IL_9498:
			this.RTDBtnRadWideTPSFiregroundEmergencyPTTTransmission_A33203 = (global::AcpUI.AcpRtdButton)target;
			return;
			IL_94A5:
			this.RadWideUserInformationAndPasswordsTacticalInhibitEnable_A34405 = (global::AcpUI.AcpCheckBox)target;
			this.RadWideUserInformationAndPasswordsTacticalInhibitEnable_A34405.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_94C9:
			this.RadWideTransmitPowerLevelsTrkTxPowerLevelMinimumW_A41862Comp = (global::AcpUI.AcpLabel)target;
			return;
			IL_94D6:
			this.HLinkDepot = (global::System.Windows.Documents.Hyperlink)target;
			this.HLinkDepot.Click += this.HLinkClick;
			return;
			IL_94FA:
			this.LblRadWideLabtoolConsoletteModelEnable_A7713 = (global::AcpUI.AcpLabel)target;
			this.LblRadWideLabtoolConsoletteModelEnable_A7713.MouseDoubleClick += new global::System.Windows.Input.MouseButtonEventHandler(this.OnFieldNameDoubleClick);
			return;
			IL_951E:
			this.CVBtnRadWideFeaturesAccessoryCableConfiguration_41997 = (global::AcpUI.AcpCustomViewCheckBox)target;
			return;
			IL_952B:
			this.RTDBtnRadWideFeaturesBlockPendingCAPC_A7564 = (global::AcpUI.AcpRtdButton)target;
			return;
			IL_9538:
			this.RadWideDualRadioEmergencyRadio_A42239 = (global::AcpUI.AcpComboBox)target;
			this.RadWideDualRadioEmergencyRadio_A42239.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_955C:
			this.RadWideBluetoothFriendlyName_A41181Comp = (global::AcpUI.AcpLabel)target;
			return;
			IL_9569:
			this.RadWideTxPowerLevelsNewBandPlan78MHzBandSelection_A41851Comp = (global::AcpUI.AcpLabel)target;
			return;
			IL_9576:
			this.RTDBtnRadWideFeaturesDisableIgnitionAutoPowerOffAlert_A38015 = (global::AcpUI.AcpRtdButton)target;
			return;
			IL_9583:
			this.LblRadWideLabtoolAudibleBeaconRoutingCapable_A41974 = (global::AcpUI.AcpLabel)target;
			this.LblRadWideLabtoolAudibleBeaconRoutingCapable_A41974.MouseDoubleClick += new global::System.Windows.Input.MouseButtonEventHandler(this.OnFieldNameDoubleClick);
			return;
			IL_95A7:
			this.RTDBtnManDownPersonalityConfigurableCapable_42082 = (global::AcpUI.AcpRtdButton)target;
			return;
			IL_95B4:
			this.RTDBtnRadWideFeaturesPowerManagementStandbyTime = (global::AcpUI.AcpRtdButton)target;
			return;
			IL_95C1:
			this.CVBtnRadWideFeaturePreAmpUHF_A42962 = (global::AcpUI.AcpCustomViewCheckBox)target;
			return;
			IL_95CE:
			this.RTDBtnRadWideLocationLocationEnable_A8448 = (global::AcpUI.AcpRtdButton)target;
			return;
			IL_95DB:
			this.LblRadWideLabtoolAPX6000P25Radio_A42121 = (global::AcpUI.AcpLabel)target;
			this.LblRadWideLabtoolAPX6000P25Radio_A42121.MouseDoubleClick += new global::System.Windows.Input.MouseButtonEventHandler(this.OnFieldNameDoubleClick);
			return;
			IL_95FF:
			this.CpyBtnRadWideTPSAudibleEmergencyBeaconRouting_A41972 = (global::AcpUI.AcpCopyButton)target;
			return;
			IL_960C:
			this.RadWideLabtoolTxBandSplitName_A24799Comp = (global::AcpUI.AcpLabel)target;
			return;
			IL_9619:
			this.HLinkGeneral = (global::System.Windows.Documents.Hyperlink)target;
			this.HLinkGeneral.Click += this.HLinkClick;
			return;
			IL_963D:
			this.RadWideLocationSystemManagedGeofence_43042Comp = (global::AcpUI.AcpCheckBox)target;
			return;
			IL_964A:
			this.RadWideLabtoolDigitalAnalogBalance_A7851 = (global::AcpUI.AcpComboBox)target;
			this.RadWideLabtoolDigitalAnalogBalance_A7851.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_966E:
			this.CpyBtnTrunkingRadioInhibited_A19483 = (global::AcpUI.AcpCopyButton)target;
			return;
			IL_967B:
			this.RadWideBluetoothImproveAudioLatency_A44943 = (global::AcpUI.AcpCheckBox)target;
			this.RadWideBluetoothImproveAudioLatency_A44943.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_969F:
			this.RadWideUserInformationandPasswordsRadioLockForceChangePassword_A3583 = (global::AcpUI.AcpCheckBox)target;
			this.RadWideUserInformationandPasswordsRadioLockForceChangePassword_A3583.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_96C3:
			this.RadWideAdvancedSmartLowBatteryAlert_A9165Comp = (global::AcpUI.AcpLabel)target;
			return;
			IL_96D0:
			this.RTDBtnRadWideGeneralTlsPsk_44841 = (global::AcpUI.AcpRtdButton)target;
			return;
			IL_96DD:
			this.RTDBtnRadWideUserInformationandPasswordsUserLoginAuthenticationType_A44926 = (global::AcpUI.AcpRtdButton)target;
			return;
			IL_96EA:
			this.RadWideFeaturesIgnitionAutoPoweroff_A38014Comp = (global::AcpUI.AcpLabel)target;
			return;
			IL_96F7:
			this.RadWideTransmitPowerLevelsConvTxPowerLevelLowW_A41175_Col = (global::Infragistics.Windows.DataPresenter.UnboundField)target;
			return;
			IL_9704:
			this.RadWideTransmitPowerLevelsConvTxPowerLevelLowW_A41861Comp = (global::AcpUI.AcpLabel)target;
			return;
			IL_9711:
			this.RTDBtnRadWideLabtoolFlipDisplayOption_A8140 = (global::AcpUI.AcpRtdButton)target;
			return;
			IL_971E:
			this.CpyBtnRadWideGeneralLogDisp_A9756 = (global::AcpUI.AcpCopyButton)target;
			return;
			IL_972B:
			this.RadWideLocP25LocationReporting_42412Comp = (global::AcpUI.AcpCheckBox)target;
			return;
			IL_9738:
			this.RadWideFeatureDynamicIcons_A42963 = (global::AcpUI.AcpCheckBox)target;
			this.RadWideFeatureDynamicIcons_A42963.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_975C:
			this.RTDBtnRadWideLabtoolDeviceMgmtSeamlessUpdateRmPsk = (global::AcpUI.AcpRtdButton)target;
			return;
			IL_9769:
			this.CVBtnRadWideTransmitPowerLevelsTxPowerLevelHighW_A41854 = (global::AcpUI.AcpCustomViewCheckBox)target;
			return;
			IL_9776:
			this.RadWideFeaturesDisableIgnitionAutoPowerOffAlert_A38015Comp = (global::AcpUI.AcpCheckBox)target;
			return;
			IL_9783:
			this.CpyBtnRadWideTPSFiregroundEvacuationAcknowledgement_A33216 = (global::AcpUI.AcpCopyButton)target;
			return;
			IL_9790:
			this.LblRadProfAlertTonesRotaryAlert_A8983 = (global::AcpUI.AcpLabel)target;
			this.LblRadProfAlertTonesRotaryAlert_A8983.MouseDoubleClick += new global::System.Windows.Input.MouseButtonEventHandler(this.OnFieldNameDoubleClick);
			return;
			IL_97B4:
			this.ExpanderRadioWideGeneralLightbarPattern = (global::AcpUI.AcpXamDataPresenter)target;
			return;
			IL_97C1:
			this.LblRadWideFeaturesSmartMessagingSmartMessageMode = (global::AcpUI.AcpLabel)target;
			this.LblRadWideFeaturesSmartMessagingSmartMessageMode.MouseDoubleClick += new global::System.Windows.Input.MouseButtonEventHandler(this.OnFieldNameDoubleClick);
			return;
			IL_97E5:
			this.CVBtnRadWideUserInformationandPasswordsSoftIDUsernameDisplayTextSize_A23453 = (global::AcpUI.AcpCustomViewCheckBox)target;
			return;
			IL_97F2:
			this.RadWideAudioConfigurationLevel_42740Comp = (global::AcpUI.AcpLabel)target;
			return;
			IL_97FF:
			this.RadWideTPSFiregroundEvacuationTone_A7980 = (global::AcpUI.AcpCheckBox)target;
			this.RadWideTPSFiregroundEvacuationTone_A7980.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_9823:
			this.RadWideLabtoolSirenAndLightsKeypadEnable_A41413 = (global::AcpUI.AcpLabel)target;
			this.RadWideLabtoolSirenAndLightsKeypadEnable_A41413.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_9847:
			this.LblRadWideTransmitPowerLevelsTxPowerLevelMaximumW_A41859 = (global::AcpUI.AcpLabel)target;
			this.LblRadWideTransmitPowerLevelsTxPowerLevelMaximumW_A41859.MouseDoubleClick += new global::System.Windows.Input.MouseButtonEventHandler(this.OnFieldNameDoubleClick);
			return;
			IL_986B:
			this.RadWideTransmitPowerLevelsTxPowerLevelLowW_A41855_Col = (global::Infragistics.Windows.DataPresenter.UnboundField)target;
			return;
			IL_9878:
			this.CpyBtnRadWideUserinfoPassRequiredForLightbar_A36532 = (global::AcpUI.AcpCopyButton)target;
			return;
			IL_9885:
			this.RadWideGenLightBarPatternRelay5_A36510Comp = (global::AcpUI.AcpLabel)target;
			return;
			IL_9892:
			this.RTDBtnRadWideTalkProhibitToneSelection_A42416 = (global::AcpUI.AcpRtdButton)target;
			return;
			IL_989F:
			this.RTDBtnRadWideLocationDisplayFormat_A41561 = (global::AcpUI.AcpRtdButton)target;
			return;
			IL_98AC:
			this.RadWideFeaturesDisplayLastAcknowledgedUserStatusorMessage_A42000Comp = (global::AcpUI.AcpCheckBox)target;
			return;
			IL_98B9:
			this.CpyBtnRadWideLabtoolSirenPaOnly_A9142 = (global::AcpUI.AcpCopyButton)target;
			return;
			IL_98C6:
			this.RadWideReverseGeocodedLocationDisplayFormatComp = (global::AcpUI.AcpLabel)target;
			return;
			IL_98D3:
			this.LblRadWideUserInformationandPasswordsSoftIDUsernameDisplayTextSize_A23453 = (global::AcpUI.AcpLabel)target;
			this.LblRadWideUserInformationandPasswordsSoftIDUsernameDisplayTextSize_A23453.MouseDoubleClick += new global::System.Windows.Input.MouseButtonEventHandler(this.OnFieldNameDoubleClick);
			return;
			IL_98F7:
			this.CVBtnRadWideDualRadioSecRadioTransmissionCapability_A42238 = (global::AcpUI.AcpCustomViewCheckBox)target;
			return;
			IL_9904:
			this.CpyBtnRadWideLabtoolFlipDisplayOption_A8140 = (global::AcpUI.AcpCopyButton)target;
			return;
			IL_9911:
			this.RadWideLabtoolRadioReadPasswordEnable_A8869Comp = (global::AcpUI.AcpLabel)target;
			return;
			IL_991E:
			this.ExpanderRadioWideFCCNarrowBandingFrequencySplitTableTableView = (global::AcpUI.AcpGroupBox)target;
			return;
			IL_992B:
			this.LblRadWideFeaturesRotarySwitchScanPrgm_A8986 = (global::AcpUI.AcpLabel)target;
			this.LblRadWideFeaturesRotarySwitchScanPrgm_A8986.MouseDoubleClick += new global::System.Windows.Input.MouseButtonEventHandler(this.OnFieldNameDoubleClick);
			return;
			IL_994F:
			this.RadWideGeneralOwnerWACNID_A38656Comp = (global::AcpUI.AcpTextBoxDecHex)target;
			return;
			IL_995C:
			this.CVBtnRadWideAlertTonesZeroLevelAudioMute_A9689 = (global::AcpUI.AcpCustomViewCheckBox)target;
			return;
			IL_9969:
			this.RadWideTPSFiregroundEvacuationTone_A7980Comp = (global::AcpUI.AcpCheckBox)target;
			return;
			IL_9976:
			this.LblRadWideLabtoolIntelligentPriorityScanCapable_43411 = (global::AcpUI.AcpLabel)target;
			this.LblRadWideLabtoolIntelligentPriorityScanCapable_43411.MouseDoubleClick += new global::System.Windows.Input.MouseButtonEventHandler(this.OnFieldNameDoubleClick);
			return;
			IL_999A:
			this.ExpanderRadioWideTransmitPowerLevelsGrid = (global::System.Windows.Controls.Grid)target;
			return;
			IL_99A7:
			this.RTDBtnRadWideLabtoolSeamlessUpdateOutOfBoxExperience = (global::AcpUI.AcpRtdButton)target;
			return;
			IL_99B4:
			this.CpyBtnRadWideAudioOptionsSelectBluetoothMicForAuxPTTAudioSource_44819 = (global::AcpUI.AcpCopyButton)target;
			return;
			IL_99C1:
			this.CpyBtnRadWideGeneralOwnerWACNID_A38656 = (global::AcpUI.AcpCopyButton)target;
			return;
			IL_99CE:
			this.LblRadWideFeaturesVoiceAbsenceTimer_42458 = (global::AcpUI.AcpLabel)target;
			this.LblRadWideFeaturesVoiceAbsenceTimer_42458.MouseDoubleClick += new global::System.Windows.Input.MouseButtonEventHandler(this.OnFieldNameDoubleClick);
			return;
			IL_99F2:
			this.LblRadWideRadioKilled_A41559 = (global::AcpUI.AcpLabel)target;
			this.LblRadWideRadioKilled_A41559.MouseDoubleClick += new global::System.Windows.Input.MouseButtonEventHandler(this.OnFieldNameDoubleClick);
			return;
			IL_9A16:
			this.ExpanderRadioWideRxFrequencySplitFPPGrid = (global::System.Windows.Controls.Grid)target;
			return;
			IL_9A23:
			this.CpyBtnRadWideLabtoolDeviceMgmtSeamlessUpdateRmPskId = (global::AcpUI.AcpCopyButton)target;
			return;
			IL_9A30:
			this.LblRadWideTransmitPowerLevelsFrequencyRangeStartMHz_A41856 = (global::AcpUI.AcpLabel)target;
			this.LblRadWideTransmitPowerLevelsFrequencyRangeStartMHz_A41856.MouseDoubleClick += new global::System.Windows.Input.MouseButtonEventHandler(this.OnFieldNameDoubleClick);
			return;
			IL_9A54:
			this.LblRadWideFeaturesVoiceControlPriority = (global::AcpUI.AcpLabel)target;
			this.LblRadWideFeaturesVoiceControlPriority.MouseDoubleClick += new global::System.Windows.Input.MouseButtonEventHandler(this.OnFieldNameDoubleClick);
			return;
			IL_9A78:
			this.RadProfAlertTonesAlertTones_A7428Comp = (global::AcpUI.AcpCheckBox)target;
			return;
			IL_9A85:
			this.CpyBtnRadWideFeaturesExtRFRoute_A43020 = (global::AcpUI.AcpCopyButton)target;
			return;
			IL_9A92:
			this.CpyBtnRadWideDualRadioFixedRadioSwapMenu_A42241 = (global::AcpUI.AcpCopyButton)target;
			return;
			IL_9A9F:
			this.CVBtnRadWideTransmitPowerLevelsTrkTxPowerLevelLowW_A41176 = (global::AcpUI.AcpCustomViewCheckBox)target;
			return;
			IL_9AAC:
			this.RadWideDualRadioCrossBandMuteOption_A42240Comp = (global::AcpUI.AcpCheckBox)target;
			return;
			IL_9AB9:
			this.ExpanderRadioWideRxFrequencySplit = (global::AcpUI.AcpExpander)target;
			return;
			IL_9AC6:
			this.RadWideTransmitPowerLevelsTxPowerLevelMaximumW_A41859_Col = (global::Infragistics.Windows.DataPresenter.UnboundField)target;
			return;
			IL_9AD3:
			this.DVRSRangeExt_44809 = (global::AcpUI.AcpLabel)target;
			this.DVRSRangeExt_44809.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_9AF7:
			this.RadWideTPSFiregroundEmergencyPTTTransmission_A33203 = (global::AcpUI.AcpComboBox)target;
			this.RadWideTPSFiregroundEmergencyPTTTransmission_A33203.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_9B1B:
			this.RadWideDualRadioSecRadioTransmissionCapability_A42238Comp = (global::AcpUI.AcpCheckBox)target;
			return;
			IL_9B28:
			this.RadProfAlertTonesStandbyChirpsec_A9179Comp = (global::AcpUI.AcpLabel)target;
			return;
			IL_9B35:
			this.RadWideTransmitPowerLevelsTxPowerLevelLowW_A8153Comp = (global::AcpUI.AcpLabel)target;
			return;
			IL_9B42:
			this.CpyBtnRadWideUserInformationandPasswordsMandatoryPassword_A8461 = (global::AcpUI.AcpCopyButton)target;
			return;
			IL_9B4F:
			this.RadWideLabtoolDeviceMgmtEnterpriseWifiCodeplugId = (global::AcpUI.AcpTextBox)target;
			this.RadWideLabtoolDeviceMgmtEnterpriseWifiCodeplugId.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_9B73:
			this.RadWideUserInformationandPINPassword_41303Comp = (global::AcpUI.AcpLabel)target;
			return;
			IL_9B80:
			this.RadWideLabtoolTxStartFrequencySplit_A9571 = (global::AcpUI.AcpTextBox)target;
			this.RadWideLabtoolTxStartFrequencySplit_A9571.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_9BA4:
			this.GrpBoxExpanderRadioWideLTEPseudo0 = (global::AcpUI.AcpGroupBox)target;
			return;
			IL_9BB1:
			this.ExpanderRadioWideTransmitPowerLevels = (global::AcpUI.AcpExpander)target;
			return;
			IL_9BBE:
			this.CpyBtnDVRSRangeExt_44809 = (global::AcpUI.AcpCopyButton)target;
			return;
			IL_9BCB:
			this.RadWideLabtoolEncryptedPINPassword_A41702Comp = (global::AcpUI.AcpLabel)target;
			return;
			IL_9BD8:
			this.ExpanderRadioWideTxFrequencySplitFPP = (global::AcpUI.AcpXamDataPresenter)target;
			return;
			IL_9BE5:
			this.CpyBtnRadWideTPSFiregroundEvacuationTone_A7980 = (global::AcpUI.AcpCopyButton)target;
			return;
			IL_9BF2:
			this.CpyBtnTPSCapable_A42312 = (global::AcpUI.AcpCopyButton)target;
			return;
			IL_9BFF:
			this.RadWideTransmitPowerLevelsConvTxPowerLevelMinimumW_A41863_Col = (global::Infragistics.Windows.DataPresenter.UnboundField)target;
			return;
			IL_9C0C:
			this.AdvancedExternalMicOnlyComp = (global::AcpUI.AcpCheckBox)target;
			return;
			IL_9C19:
			this.CpyBtnRadWideLabtoolADPGatingPCIBit = (global::AcpUI.AcpCopyButton)target;
			return;
			IL_9C26:
			this.RadWideAlertTonesVolumeAdjustToneOffset_A9656Comp = (global::AcpUI.AcpCheckBox)target;
			return;
			IL_9C33:
			this.RTDBtnRadWideTransmitPowerLevelsTxPowerLevelConfigType_A41179 = (global::AcpUI.AcpRtdButton)target;
			return;
			IL_9C40:
			this.CpyBtnRadWideLabtoolPAAlertCapability_A42944 = (global::AcpUI.AcpCopyButton)target;
			return;
			IL_9C4D:
			this.RTDBtnRadWideEmergencyRxTxAlertToneSet_A41508 = (global::AcpUI.AcpRtdButton)target;
			return;
			IL_9C5A:
			this.CpyBtnRadWideTransmitPowerLevelsTrkTxPowerLevelLowW_A41176 = (global::AcpUI.AcpCopyButton)target;
			return;
			IL_9C67:
			this.RadWideLocationSystemManagedGeofence_43042 = (global::AcpUI.AcpCheckBox)target;
			this.RadWideLocationSystemManagedGeofence_43042.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_9C8B:
			this.CpyBtnRadWideLabtoolLTEUsed_A42064 = (global::AcpUI.AcpCopyButton)target;
			return;
			IL_9C98:
			this.RTDBtnRadWideTransmitPowerLevelsTxPowerLevelMinimumW_A20038 = (global::AcpUI.AcpRtdButton)target;
			return;
			IL_9CA5:
			this.RadCfgVirtualPartnerInactivityTimeComp = (global::AcpUI.AcpLabel)target;
			return;
			IL_9CB2:
			this.RadWideLabtoolSirenPaOnly_A9142Comp = (global::AcpUI.AcpCheckBox)target;
			return;
			IL_9CBF:
			this.SensorEventDisableTimer_43198Comp = (global::AcpUI.AcpLabel)target;
			return;
			IL_9CCC:
			this.RadWideAdvancedRecordAudio_A8922Comp = (global::AcpUI.AcpLabel)target;
			return;
			IL_9CD9:
			this.RadWideFeaturesMapping = (global::AcpUI.AcpComboBox)target;
			this.RadWideFeaturesMapping.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_9CFD:
			this.RadWideGeneralASKRequired_A37152 = (global::AcpUI.AcpCheckBox)target;
			this.RadWideGeneralASKRequired_A37152.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_9D21:
			this.RadWideBluetoothBluetoothTones_A37035 = (global::AcpUI.AcpCheckBox)target;
			this.RadWideBluetoothBluetoothTones_A37035.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_9D45:
			this.CVBtnRadProfAlertTonesRotaryAlert_A8983 = (global::AcpUI.AcpCustomViewCheckBox)target;
			return;
			IL_9D52:
			this.LblRadWideTransmitPowerLevelsTxPowerLevelLowW_A8153 = (global::AcpUI.AcpLabel)target;
			this.LblRadWideTransmitPowerLevelsTxPowerLevelLowW_A8153.MouseDoubleClick += new global::System.Windows.Input.MouseButtonEventHandler(this.OnFieldNameDoubleClick);
			return;
			IL_9D76:
			this.RadWideLabtoolUltraLowPowerSoldierMacCapable_A41710 = (global::AcpUI.AcpLabel)target;
			this.RadWideLabtoolUltraLowPowerSoldierMacCapable_A41710.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_9D9A:
			this.RadWideLabtoolControlHeadSelection_A7723 = (global::AcpUI.AcpComboBox)target;
			this.RadWideLabtoolControlHeadSelection_A7723.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_9DBE:
			this.CpyBtnRadWideLabtoolCertMgmtMotorolaSolutionsPKIPort = (global::AcpUI.AcpCopyButton)target;
			return;
			IL_9DCB:
			this.RadWideGenLightBarPatternRelay5_A36510_Col = (global::Infragistics.Windows.DataPresenter.UnboundField)target;
			return;
			IL_9DD8:
			this.AdvancedAuxTransmitSensitivity_A7530Comp = (global::AcpUI.AcpLabel)target;
			return;
			IL_9DE5:
			this.LblRadWideLabtoolAudioEnhancement_A42736 = (global::AcpUI.AcpLabel)target;
			this.LblRadWideLabtoolAudioEnhancement_A42736.MouseDoubleClick += new global::System.Windows.Input.MouseButtonEventHandler(this.OnFieldNameDoubleClick);
			return;
			IL_9E09:
			this.LblRadWideGenLightBarPatternRelay6_A36511 = (global::AcpUI.AcpLabel)target;
			this.LblRadWideGenLightBarPatternRelay6_A36511.MouseDoubleClick += new global::System.Windows.Input.MouseButtonEventHandler(this.OnFieldNameDoubleClick);
			return;
			IL_9E2D:
			this.RadProfAlertTonesAlertTones_A7428 = (global::AcpUI.AcpCheckBox)target;
			this.RadProfAlertTonesAlertTones_A7428.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_9E51:
			this.RTDBtnRadWideAlertTonesRSMVolumeSetTone = (global::AcpUI.AcpRtdButton)target;
			return;
			IL_9E5E:
			this.RTDBtnRadWideRecentCallListDeleteEnable = (global::AcpUI.AcpRtdButton)target;
			return;
			IL_9E6B:
			this.RadWideGenLightBarPatternRelay9_A36515_Col = (global::Infragistics.Windows.DataPresenter.UnboundField)target;
			return;
			IL_9E78:
			this.RadWideGenLightBarPatternRelay10_A36516Comp = (global::AcpUI.AcpLabel)target;
			return;
			IL_9E85:
			this.RTDBtnRadWideLabtoolReadWriteVoiceFiles_A8893 = (global::AcpUI.AcpRtdButton)target;
			return;
			IL_9E92:
			this.CpyBtnRadWideLocationMaxStoredLocationRequests_A8473 = (global::AcpUI.AcpCopyButton)target;
			return;
			IL_9E9F:
			this.CVBtnRadWideEmergencyRxTxAlertToneSet_A41508 = (global::AcpUI.AcpCustomViewCheckBox)target;
			return;
			IL_9EAC:
			this.RTDBtnRadWideBluetoothBluetoothReconnectTimer_A37037 = (global::AcpUI.AcpRtdButton)target;
			return;
			IL_9EB9:
			this.RadWideLocationUserSelectableLocationEnable_A9605 = (global::AcpUI.AcpCheckBox)target;
			this.RadWideLocationUserSelectableLocationEnable_A9605.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_9EDD:
			this.RadWideTransmitPowerLevelsConvTxPowerLevelMinimumW_A41173 = (global::AcpUI.AcpTextBox)target;
			this.RadWideTransmitPowerLevelsConvTxPowerLevelMinimumW_A41173.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_9F01:
			this.CVBtnRadWideGeneralOwnerAdvancedKeyType_A38663 = (global::AcpUI.AcpCustomViewCheckBox)target;
			return;
			IL_9F0E:
			this.LblRadWideAdvancedMaximumTxDeviation_A8480 = (global::AcpUI.AcpLabel)target;
			this.LblRadWideAdvancedMaximumTxDeviation_A8480.MouseDoubleClick += new global::System.Windows.Input.MouseButtonEventHandler(this.OnFieldNameDoubleClick);
			return;
			IL_9F32:
			this.RadWideBluetoothReplacePairingInfo_A41562Comp = (global::AcpUI.AcpCheckBox)target;
			return;
			IL_9F3F:
			this.RTDBtnRadWideLabtoolEncryptedPINPassword_A41702 = (global::AcpUI.AcpRtdButton)target;
			return;
			IL_9F4C:
			this.CpyBtnRadWideGenLightBarPatternRelay9_A36515 = (global::AcpUI.AcpCopyButton)target;
			return;
			IL_9F59:
			this.CVBtnRadWideBluetoothBluetoothDropTimer_A37038 = (global::AcpUI.AcpCustomViewCheckBox)target;
			return;
			IL_9F66:
			this.CpyBtnRadWideGenLgtBarName_A36505 = (global::AcpUI.AcpCopyButton)target;
			return;
			IL_9F73:
			this.ExpanderRadioWideTxFrequencySplitGrid = (global::System.Windows.Controls.Grid)target;
			return;
			IL_9F80:
			this.LblRadWideFeaturesDisplayLastAcknowledgedUserStatusorMessage_A42000 = (global::AcpUI.AcpLabel)target;
			this.LblRadWideFeaturesDisplayLastAcknowledgedUserStatusorMessage_A42000.MouseDoubleClick += new global::System.Windows.Input.MouseButtonEventHandler(this.OnFieldNameDoubleClick);
			return;
			IL_9FA4:
			this.CpyBtnRadWideLabtoolRxBandSplitName_A24797 = (global::AcpUI.AcpCopyButton)target;
			return;
			IL_9FB1:
			this.CpyBtnRadCfgLocationReporting = (global::AcpUI.AcpCopyButton)target;
			return;
			IL_9FBE:
			this.RadWideAdvancedMaximumTxDeviation_A8480 = (global::AcpUI.AcpComboBox)target;
			this.RadWideAdvancedMaximumTxDeviation_A8480.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_9FE2:
			this.CpyBtnRadioWideDVRSTrunkingStatusCapability_A42772 = (global::AcpUI.AcpCopyButton)target;
			return;
			IL_9FEF:
			this.CVBtnRadWideAdvancedSmartLowBatteryAlert_A9165 = (global::AcpUI.AcpCustomViewCheckBox)target;
			return;
			IL_9FFC:
			this.RadWideTransmitPowerLevelsTxPowerLevelLowW_A8153 = (global::AcpUI.AcpTextBox)target;
			this.RadWideTransmitPowerLevelsTxPowerLevelLowW_A8153.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_A020:
			this.LblRadWideBluetoothBluetoothPANNetworkAddress_41983 = (global::AcpUI.AcpLabel)target;
			this.LblRadWideBluetoothBluetoothPANNetworkAddress_41983.MouseDoubleClick += new global::System.Windows.Input.MouseButtonEventHandler(this.OnFieldNameDoubleClick);
			return;
			IL_A044:
			this.CVBtnRadWideRecentCallListDeleteEnable = (global::AcpUI.AcpCustomViewCheckBox)target;
			return;
			IL_A051:
			this.RadWideBluetoothBluetoothPairingType_A37036Comp = (global::AcpUI.AcpLabel)target;
			return;
			IL_A05E:
			this.CVBtnRadWideLabtoolArchiveReadPasswordEnable_A7462 = (global::AcpUI.AcpCustomViewCheckBox)target;
			return;
			IL_A06B:
			this.RadWideFeaturesInactivityAutoPoweroff_A38013 = (global::AcpUI.AcpTextBoxSpinner)target;
			this.RadWideFeaturesInactivityAutoPoweroff_A38013.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_A08F:
			this.RadWidePAACKAlertsonPTT_A43099 = (global::AcpUI.AcpCheckBox)target;
			this.RadWidePAACKAlertsonPTT_A43099.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_A0B3:
			this.CVBtnRadWideTPSAudibleEmergencyBeaconsec_A7502 = (global::AcpUI.AcpCustomViewCheckBox)target;
			return;
			IL_A0C0:
			this.CVBtnRadWideUserInformationAndPasswordsTacticalInhibitEncodePassword_A34395 = (global::AcpUI.AcpCustomViewCheckBox)target;
			return;
			IL_A0CD:
			this.RadWideBluetoothImproveAudioLatency_A44943Comp = (global::AcpUI.AcpCheckBox)target;
			return;
			IL_A0DA:
			this.GrpBoxExpanderRadioWideDualRadioPseudo0 = (global::AcpUI.AcpGroupBox)target;
			return;
			IL_A0E7:
			this.MultiRadioSystemEnable_A42248Comp = (global::AcpUI.AcpLabel)target;
			return;
			IL_A0F4:
			this.RTDBtnRadWideAlertTonesScanAlertToneEnable_A19555 = (global::AcpUI.AcpRtdButton)target;
			return;
			IL_A101:
			this.RadWideLabtoolArchiveReadPasswordEnable_A7462Comp = (global::AcpUI.AcpLabel)target;
			return;
			IL_A10E:
			this.RTDBtnRadWideTransmitPowerLevelsTxPowerLevelHighW_A8152 = (global::AcpUI.AcpRtdButton)target;
			return;
			IL_A11B:
			this.RTDBtnRadWideLocationUserSelectableLocationEnable_A9605 = (global::AcpUI.AcpRtdButton)target;
			return;
			IL_A128:
			this.CVBtnRadWideUserInformationandPasswordsPIN_A8705 = (global::AcpUI.AcpCustomViewCheckBox)target;
			return;
			IL_A135:
			this.GrpBoxExpanderRadioWideTPSPseudo0 = (global::AcpUI.AcpGroupBox)target;
			return;
			IL_A142:
			this.CVBtnRadWideGeneralDateFormat_A7802 = (global::AcpUI.AcpCustomViewCheckBox)target;
			return;
			IL_A14F:
			this.CpyBtnRadWideTransmitPowerLevelsTxPowerLevelMinimumW_A41858 = (global::AcpUI.AcpCopyButton)target;
			return;
			IL_A15C:
			this.RadWideUniversalRelayControllerEquipped_A37191Comp = (global::AcpUI.AcpCheckBox)target;
			return;
			IL_A169:
			this.LblRadWideGeneralDnsSdPort_44844 = (global::AcpUI.AcpLabel)target;
			this.LblRadWideGeneralDnsSdPort_44844.MouseDoubleClick += new global::System.Windows.Input.MouseButtonEventHandler(this.OnFieldNameDoubleClick);
			return;
			IL_A18D:
			this.LblAdvancedExternalMicOnly = (global::AcpUI.AcpLabel)target;
			this.LblAdvancedExternalMicOnly.MouseDoubleClick += new global::System.Windows.Input.MouseButtonEventHandler(this.OnFieldNameDoubleClick);
			return;
			IL_A1B1:
			this.HLinkLTE = (global::System.Windows.Documents.Hyperlink)target;
			this.HLinkLTE.Click += this.HLinkClick;
			return;
			IL_A1D5:
			this.RTDBtnRadProfAlertTonesCallAlertToneAutoReset_A7596 = (global::AcpUI.AcpRtdButton)target;
			return;
			IL_A1E2:
			this.RadWideUserInformationandCachedCredentialsUserLoginMode_41307Comp = (global::AcpUI.AcpLabel)target;
			return;
			IL_A1EF:
			this.LblRadWideLabtoolDeviceMgmtSeamlessUpdateRmPskId = (global::AcpUI.AcpLabel)target;
			this.LblRadWideLabtoolDeviceMgmtSeamlessUpdateRmPskId.MouseDoubleClick += new global::System.Windows.Input.MouseButtonEventHandler(this.OnFieldNameDoubleClick);
			return;
			IL_A213:
			this.RadWideLabtoolEncryptPassword_A41695Comp = (global::AcpUI.AcpLabel)target;
			return;
			IL_A220:
			this.LblRadWideTPSEmergencyPTTTransmission_A41544 = (global::AcpUI.AcpLabel)target;
			this.LblRadWideTPSEmergencyPTTTransmission_A41544.MouseDoubleClick += new global::System.Windows.Input.MouseButtonEventHandler(this.OnFieldNameDoubleClick);
			return;
			IL_A244:
			this.ExpanderRadioWideAlertTones = (global::AcpUI.AcpExpander)target;
			return;
			IL_A251:
			this.LblRadWideLabtoolTxEndFrequencySplit_A9532 = (global::AcpUI.AcpLabel)target;
			this.LblRadWideLabtoolTxEndFrequencySplit_A9532.MouseDoubleClick += new global::System.Windows.Input.MouseButtonEventHandler(this.OnFieldNameDoubleClick);
			return;
			IL_A275:
			this.RTDBtnRadProfAlertTonesNewMuteTonesOperation_A42149 = (global::AcpUI.AcpRtdButton)target;
			return;
			IL_A282:
			this.RadProfAlertTonesLED_A8428 = (global::AcpUI.AcpCheckBox)target;
			this.RadProfAlertTonesLED_A8428.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_A2A6:
			this.RadWideTransmitPowerLevelsFrequencyRangeEndMHz_A41857 = (global::AcpUI.AcpTextBox)target;
			this.RadWideTransmitPowerLevelsFrequencyRangeEndMHz_A41857.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_A2CA:
			this.CpyBtnRadWideUserInformationandPasswordsRadioLockRadioInhibitOnDeadlock_A3584 = (global::AcpUI.AcpCopyButton)target;
			return;
			IL_A2D7:
			this.RTDBtnRadWideAlertTonesVolumeAdjustToneDisable = (global::AcpUI.AcpRtdButton)target;
			return;
			IL_A2E4:
			this.RadWideLocationLocationEnable_A8448Comp = (global::AcpUI.AcpCheckBox)target;
			return;
			IL_A2F1:
			this.RTDBtnRadProfAlertTonesStandbyChirpsec_A9179 = (global::AcpUI.AcpRtdButton)target;
			return;
			IL_A2FE:
			this.RadWideLabtoolIntelligentPriorityScanCapable_43411 = (global::AcpUI.AcpLabel)target;
			this.RadWideLabtoolIntelligentPriorityScanCapable_43411.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_A322:
			this.RTDBtnRadWideAlertTonesTxChirp_A9523 = (global::AcpUI.AcpRtdButton)target;
			return;
			IL_A32F:
			this.CVBtnRadWideLabtoolAudioEnhancement_A42736 = (global::AcpUI.AcpCustomViewCheckBox)target;
			return;
			IL_A33C:
			this.LblRadWideAdvancedAuxPTTAudioSource_A7529 = (global::AcpUI.AcpLabel)target;
			this.LblRadWideAdvancedAuxPTTAudioSource_A7529.MouseDoubleClick += new global::System.Windows.Input.MouseButtonEventHandler(this.OnFieldNameDoubleClick);
			return;
			IL_A360:
			this.CVBtnRadWideLabtoolRadioReadPasswordEnable_A8869 = (global::AcpUI.AcpCustomViewCheckBox)target;
			return;
			IL_A36D:
			this.LblRadWideLabtoolDeviceMgmtSeamlessUpdateRmPsk = (global::AcpUI.AcpLabel)target;
			this.LblRadWideLabtoolDeviceMgmtSeamlessUpdateRmPsk.MouseDoubleClick += new global::System.Windows.Input.MouseButtonEventHandler(this.OnFieldNameDoubleClick);
			return;
			IL_A391:
			this.CVBtnRadWideLabtoolDigitalAnalogBalance_A7851 = (global::AcpUI.AcpCustomViewCheckBox)target;
			return;
			IL_A39E:
			this.RadWideFeaturesNFPACompliantComp = (global::AcpUI.AcpCheckBox)target;
			return;
			IL_A3AB:
			this.LblRadWideLabtoolFCCNarrowBandStartFrequency_A38270 = (global::AcpUI.AcpLabel)target;
			this.LblRadWideLabtoolFCCNarrowBandStartFrequency_A38270.MouseDoubleClick += new global::System.Windows.Input.MouseButtonEventHandler(this.OnFieldNameDoubleClick);
			return;
			IL_A3CF:
			this.RTDBtnRadioWideDVRSTrunkingStatusCapability_A42772 = (global::AcpUI.AcpRtdButton)target;
			return;
			IL_A3DC:
			this.RadioWidePTTWarningTone = (global::AcpUI.AcpComboBox)target;
			this.RadioWidePTTWarningTone.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_A400:
			this.CVBtnRadioWideMOSCADACE3000Capability_A42772 = (global::AcpUI.AcpCustomViewCheckBox)target;
			return;
			IL_A40D:
			this.RTDBtnRadWideRxAudioControlMidrangeEqualization_A8508 = (global::AcpUI.AcpRtdButton)target;
			return;
			IL_A41A:
			this.EmergencyHotAuxMicConfigurability_A42301 = (global::AcpUI.AcpLabel)target;
			this.EmergencyHotAuxMicConfigurability_A42301.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_A43E:
			this.HLinkTxPowerLevelsNewBandPlan = (global::System.Windows.Documents.Hyperlink)target;
			this.HLinkTxPowerLevelsNewBandPlan.Click += this.HLinkClick;
			return;
			IL_A462:
			this.CpyBtnRadWideFeatureAnalogWidebandData = (global::AcpUI.AcpCopyButton)target;
			return;
			IL_A46F:
			this.CVBtnRadWideRxAudioControlMidrangeEqualization_A8508 = (global::AcpUI.AcpCustomViewCheckBox)target;
			return;
			IL_A47C:
			this.RTDBtnRadWideLocationSystemManagedGeofence_43042 = (global::AcpUI.AcpRtdButton)target;
			return;
			IL_A489:
			this.RadWideLabtoolDeviceMgmtSeamlessUpdateRmPskId = (global::AcpUI.AcpTextBoxSpinner)target;
			this.RadWideLabtoolDeviceMgmtSeamlessUpdateRmPskId.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_A4AD:
			this.HLinkDualRadio = (global::System.Windows.Documents.Hyperlink)target;
			this.HLinkDualRadio.Click += this.HLinkClick;
			return;
			IL_A4D1:
			this.ExpanderRadioWideFCCNarrowBandingFrequencySplitGrid = (global::System.Windows.Controls.Grid)target;
			return;
			IL_A4DE:
			this.CpyBtnRadWideTransmitPowerLevelsTxPowerLevelMaximumW_A41859 = (global::AcpUI.AcpCopyButton)target;
			return;
			IL_A4EB:
			this.LblRadWideFeaturesChannelFallbackEnable = (global::AcpUI.AcpLabel)target;
			this.LblRadWideFeaturesChannelFallbackEnable.MouseDoubleClick += new global::System.Windows.Input.MouseButtonEventHandler(this.OnFieldNameDoubleClick);
			return;
			IL_A50F:
			this.CpyBtnAdvancedExternalMicOnly = (global::AcpUI.AcpCopyButton)target;
			return;
			IL_A51C:
			this.RadWideLabtoolDeviceMgmtSeamlessUpdateRmPskComp = (global::AcpUI.AcpLabel)target;
			return;
			IL_A529:
			this.RadWideUserInformationandUserLoginUnitIDTextSize_41309Comp = (global::AcpUI.AcpLabel)target;
			return;
			IL_A536:
			this.GrpBoxExpanderRadioWideUserInformationAndPasswordsUserInformation = (global::AcpUI.AcpGroupBox)target;
			return;
			IL_A543:
			this.RTDBtnRadWideAdvancedRecordAudio_A8922 = (global::AcpUI.AcpRtdButton)target;
			return;
			IL_A550:
			this.CVBtnRadWideFeaturesDisableIgnitionAutoPowerOffAlert_A38015 = (global::AcpUI.AcpCustomViewCheckBox)target;
			return;
			IL_A55D:
			this.ExpanderRadioWideTPSFireground = (global::AcpUI.AcpExpander)target;
			return;
			IL_A56A:
			this.RadWideTPSFiregroundEvacuationAcknowledgement_A33216 = (global::AcpUI.AcpComboBox)target;
			this.RadWideTPSFiregroundEvacuationAcknowledgement_A33216.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_A58E:
			this.CpyBtnRadWideFeaturesMapping = (global::AcpUI.AcpCopyButton)target;
			return;
			IL_A59B:
			this.HLinkBluetooth = (global::System.Windows.Documents.Hyperlink)target;
			this.HLinkBluetooth.Click += this.HLinkClick;
			return;
			IL_A5BF:
			this.RadWideAdvancedUltraNarrowIntermediateFreqFilter_A9592 = (global::AcpUI.AcpComboBox)target;
			this.RadWideAdvancedUltraNarrowIntermediateFreqFilter_A9592.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_A5E3:
			this.RadWideLabtoolTxStartFrequencySplit_A9571Comp = (global::AcpUI.AcpLabel)target;
			return;
			IL_A5F0:
			this.LblRadWideLabtoolPAAlertCapability_A42944 = (global::AcpUI.AcpLabel)target;
			this.LblRadWideLabtoolPAAlertCapability_A42944.MouseDoubleClick += new global::System.Windows.Input.MouseButtonEventHandler(this.OnFieldNameDoubleClick);
			return;
			IL_A614:
			this.LblRadWideUniversalRelayControllerEquipped_A37191 = (global::AcpUI.AcpLabel)target;
			this.LblRadWideUniversalRelayControllerEquipped_A37191.MouseDoubleClick += new global::System.Windows.Input.MouseButtonEventHandler(this.OnFieldNameDoubleClick);
			return;
			IL_A638:
			this.CpyBtnRadWideUserInformationAndPasswordsTacticalInhibitEnable_A34405 = (global::AcpUI.AcpCopyButton)target;
			return;
			IL_A645:
			this.CpyBtnRadWideFeaturesZoneCloneEnable_43130 = (global::AcpUI.AcpCopyButton)target;
			return;
			IL_A652:
			this.RadWideLabtoolRadioPassword_A8837 = (global::AcpUI.AcpLabel)target;
			this.RadWideLabtoolRadioPassword_A8837.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_A676:
			this.CpyBtnRadWideTransmitPowerLevelsTxPowerLevelHighW_A41854 = (global::AcpUI.AcpCopyButton)target;
			return;
			IL_A683:
			this.CpyBtnRadWideLabtoolFatalError_A8015 = (global::AcpUI.AcpCopyButton)target;
			return;
			IL_A690:
			this.CpyBtnRadWidePAACKAlertsonPTT_A43099 = (global::AcpUI.AcpCopyButton)target;
			return;
			IL_A69D:
			this.LblRadWideAlertTonesVolumeAdjustToneDisable = (global::AcpUI.AcpLabel)target;
			this.LblRadWideAlertTonesVolumeAdjustToneDisable.MouseDoubleClick += new global::System.Windows.Input.MouseButtonEventHandler(this.OnFieldNameDoubleClick);
			return;
			IL_A6C1:
			this.RTDBtnRadWideBluetoothBluetoothDropTimer_A37038 = (global::AcpUI.AcpRtdButton)target;
			return;
			IL_A6CE:
			this.CpyBtnRadWideGenLightBarPatternRelay3_A36508 = (global::AcpUI.AcpCopyButton)target;
			return;
			IL_A6DB:
			this.ExpanderRadioWideRxFrequencySplitGrid = (global::System.Windows.Controls.Grid)target;
			return;
			IL_A6E8:
			this.LblRadWideBluetoothBluetoothDiscoverableExpirationTimer_41980 = (global::AcpUI.AcpLabel)target;
			this.LblRadWideBluetoothBluetoothDiscoverableExpirationTimer_41980.MouseDoubleClick += new global::System.Windows.Input.MouseButtonEventHandler(this.OnFieldNameDoubleClick);
			return;
			IL_A70C:
			this.RadProfAlertTonesNewMuteTonesOperation_A42149 = (global::AcpUI.AcpComboBox)target;
			this.RadProfAlertTonesNewMuteTonesOperation_A42149.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_A730:
			this.CpyBtnRadWideBluetoothImproveAudioLatency_A44943 = (global::AcpUI.AcpCopyButton)target;
			return;
			IL_A73D:
			this.CVBtnRadWideGeneralProgrammingPath_44845 = (global::AcpUI.AcpCustomViewCheckBox)target;
			return;
			IL_A74A:
			this.RadWideLabtoolLTEUsed_A42064 = (global::AcpUI.AcpLabel)target;
			this.RadWideLabtoolLTEUsed_A42064.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_A76E:
			this.RTDBtnRadWideOutOfRangeToneSelection_A42450 = (global::AcpUI.AcpRtdButton)target;
			return;
			IL_A77B:
			this.LblMultiRadioSystemEnable_A42248 = (global::AcpUI.AcpLabel)target;
			this.LblMultiRadioSystemEnable_A42248.MouseDoubleClick += new global::System.Windows.Input.MouseButtonEventHandler(this.OnFieldNameDoubleClick);
			return;
			IL_A79F:
			this.LblRadWideAudioOptionsSelectBluetoothMicForAuxPTTAudioSource_44819 = (global::AcpUI.AcpLabel)target;
			this.LblRadWideAudioOptionsSelectBluetoothMicForAuxPTTAudioSource_44819.MouseDoubleClick += new global::System.Windows.Input.MouseButtonEventHandler(this.OnFieldNameDoubleClick);
			return;
			IL_A7C3:
			this.CVBtnRadWideDualRadioTalkgroupMuteOption_A42290 = (global::AcpUI.AcpCustomViewCheckBox)target;
			return;
			IL_A7D0:
			this.LblRadWideLabtoolControlHeadConfiguration_A7722 = (global::AcpUI.AcpLabel)target;
			this.LblRadWideLabtoolControlHeadConfiguration_A7722.MouseDoubleClick += new global::System.Windows.Input.MouseButtonEventHandler(this.OnFieldNameDoubleClick);
			return;
			IL_A7F4:
			this.RadWideUserInformationandPINPasswordPart2_41304Comp = (global::AcpUI.AcpLabel)target;
			return;
			IL_A801:
			this.CpyBtnRadWideTxPowerLevelsNewBandPlan78MHzBandSelection_A41851 = (global::AcpUI.AcpCopyButton)target;
			return;
			IL_A80E:
			this.RTDBtnRadWideUniversalRelayControllerEquipped_A37191 = (global::AcpUI.AcpRtdButton)target;
			return;
			IL_A81B:
			this.CpyBtnRadWideLabtoolSeamlessUpdateOutOfBoxExperience = (global::AcpUI.AcpCopyButton)target;
			return;
			IL_A828:
			this.LblRadWideUserInformationandPasswordsRadioLockRadioInhibitOnDeadlock_A3584 = (global::AcpUI.AcpLabel)target;
			this.LblRadWideUserInformationandPasswordsRadioLockRadioInhibitOnDeadlock_A3584.MouseDoubleClick += new global::System.Windows.Input.MouseButtonEventHandler(this.OnFieldNameDoubleClick);
			return;
			IL_A84C:
			this.RadWideGeneralTimeFormat_A9377 = (global::AcpUI.AcpComboBox)target;
			this.RadWideGeneralTimeFormat_A9377.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_A870:
			this.LblRadioWidePTTWarningTone = (global::AcpUI.AcpLabel)target;
			this.LblRadioWidePTTWarningTone.MouseDoubleClick += new global::System.Windows.Input.MouseButtonEventHandler(this.OnFieldNameDoubleClick);
			return;
			IL_A894:
			this.LblRadWideTransmitPowerLevelsBandSplitOverride_A41064 = (global::AcpUI.AcpLabel)target;
			this.LblRadWideTransmitPowerLevelsBandSplitOverride_A41064.MouseDoubleClick += new global::System.Windows.Input.MouseButtonEventHandler(this.OnFieldNameDoubleClick);
			return;
			IL_A8B8:
			this.ExpanderRadioWideGeneralLightbarPatternGrid = (global::System.Windows.Controls.Grid)target;
			return;
			IL_A8C5:
			this.RTDBtnRadWideLabtoolAudioEnhancement_A42736 = (global::AcpUI.AcpRtdButton)target;
			return;
			IL_A8D2:
			this.RadWideFeaturesMappingComp = (global::AcpUI.AcpLabel)target;
			return;
			IL_A8DF:
			this.CVBtnRadWideAdvancedCyclicKeying_A7795 = (global::AcpUI.AcpCustomViewCheckBox)target;
			return;
			IL_A8EC:
			this.CpyBtnRadWideTalkProhibitToneSelection_A42416 = (global::AcpUI.AcpCopyButton)target;
			return;
			IL_A8F9:
			this.RadWideBluetoothBluetoothRSMLED_A37039 = (global::AcpUI.AcpCheckBox)target;
			this.RadWideBluetoothBluetoothRSMLED_A37039.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_A91D:
			this.CVBtnRadWideFeaturesInactivityAutoPoweroff_A38013 = (global::AcpUI.AcpCustomViewCheckBox)target;
			return;
			IL_A92A:
			this.CpyBtnRadWideUserInformationandPasswordsRadioLockForceChangePassword_A3583 = (global::AcpUI.AcpCopyButton)target;
			return;
			IL_A937:
			this.CpyBtnRadWideUserinfoPassRequiredForGunlock_A36531 = (global::AcpUI.AcpCopyButton)target;
			return;
			IL_A944:
			this.CpyBtnRadWideDigitalAudioOptionsWeakSignalFringe_A9678 = (global::AcpUI.AcpCopyButton)target;
			return;
			IL_A951:
			this.LblRadWideLabtoolSeamlessUpdateOutOfBoxExperience = (global::AcpUI.AcpLabel)target;
			this.LblRadWideLabtoolSeamlessUpdateOutOfBoxExperience.MouseDoubleClick += new global::System.Windows.Input.MouseButtonEventHandler(this.OnFieldNameDoubleClick);
			return;
			IL_A975:
			this.CVBtnRadWideLabtoolIndirectPTTAudioRoutingPCI_44817 = (global::AcpUI.AcpCustomViewCheckBox)target;
			return;
			IL_A982:
			this.LblRadWideFeaturesBlockPendingCAPC_A7564 = (global::AcpUI.AcpLabel)target;
			this.LblRadWideFeaturesBlockPendingCAPC_A7564.MouseDoubleClick += new global::System.Windows.Input.MouseButtonEventHandler(this.OnFieldNameDoubleClick);
			return;
			IL_A9A6:
			this.RTDBtnRadWideGeneralOwnerWACNID_A38656 = (global::AcpUI.AcpRtdButton)target;
			return;
			IL_A9B3:
			this.CVBtnRadWideFeaturesExtRFRoute_A43020 = (global::AcpUI.AcpCustomViewCheckBox)target;
			return;
			IL_A9C0:
			this.CVBtnRadWideTPSFiregroundVoiceTxEndTone_A9655 = (global::AcpUI.AcpCustomViewCheckBox)target;
			return;
			IL_A9CD:
			this.CVBtnRadWideDualRadioCrossBandMuteOption_A42240 = (global::AcpUI.AcpCustomViewCheckBox)target;
			return;
			IL_A9DA:
			this.RTDBtnRadWideUserInformationAndPasswordsTacticalInhibitEncodePassword_A34395 = (global::AcpUI.AcpRtdButton)target;
			return;
			IL_A9E7:
			this.LblRadWideTransmitPowerLevelsConvTxPowerLevelMinimumW_A41863 = (global::AcpUI.AcpLabel)target;
			this.LblRadWideTransmitPowerLevelsConvTxPowerLevelMinimumW_A41863.MouseDoubleClick += new global::System.Windows.Input.MouseButtonEventHandler(this.OnFieldNameDoubleClick);
			return;
			IL_AA0B:
			this.RadWideTransmitPowerLevelsTxPowerLevelMaximumW_A20039_Col = (global::Infragistics.Windows.DataPresenter.UnboundField)target;
			return;
			IL_AA18:
			this.RadWideLabtoolEncryptedPINPassword_A41702 = (global::AcpUI.AcpTextBox)target;
			this.RadWideLabtoolEncryptedPINPassword_A41702.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_AA3C:
			this.CVBtnRadWideFeaturesSmartMessagingSmartMessageMode = (global::AcpUI.AcpCustomViewCheckBox)target;
			return;
			IL_AA49:
			this.RadWideLabtoolTxBandSplitName_A24799 = (global::AcpUI.AcpLabel)target;
			this.RadWideLabtoolTxBandSplitName_A24799.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_AA6D:
			this.CVBtnRadWideTPSAudibleEmergencyBeaconRouting_A41972 = (global::AcpUI.AcpCustomViewCheckBox)target;
			return;
			IL_AA7A:
			this.RadWideFeaturesBlockPendingCAPC_A7564 = (global::AcpUI.AcpCheckBox)target;
			this.RadWideFeaturesBlockPendingCAPC_A7564.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_AA9E:
			num = (short)2129920000;
			short num4 = num;
			this.CpyBtnRadProfAlertTonesStandbyChirpsec_A9179 = (global::AcpUI.AcpCopyButton)target;
			return;
			IL_AAD5:
			this.RadWideTransmitPowerLevelsTrkTxPowerLevelMinimumW_A41862_Col = (global::Infragistics.Windows.DataPresenter.UnboundField)target;
			return;
			IL_AAE2:
			this.RadWideSecureNFCPairing_A44931 = (global::AcpUI.AcpCheckBox)target;
			this.RadWideSecureNFCPairing_A44931.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_AB06:
			this.CpyBtnRadWideLabtoolRxEndFrequencySplit_A9015 = (global::AcpUI.AcpCopyButton)target;
			return;
			IL_AB13:
			this.RadWideLabtoolActiveMicForBTPTTCapable_43053Comp = (global::AcpUI.AcpLabel)target;
			return;
			IL_AB20:
			this.CVBtnRadWideCustomLogoEnabled = (global::AcpUI.AcpCustomViewCheckBox)target;
			return;
			IL_AB2D:
			this.CpyBtnRadWideLabtoolControlHeadSelection_A7723 = (global::AcpUI.AcpCopyButton)target;
			return;
			IL_AB3A:
			this.LblRadWideTransmitPowerLevelsTrkTxPowerLevelMinimumW_A41174 = (global::AcpUI.AcpLabel)target;
			this.LblRadWideTransmitPowerLevelsTrkTxPowerLevelMinimumW_A41174.MouseDoubleClick += new global::System.Windows.Input.MouseButtonEventHandler(this.OnFieldNameDoubleClick);
			return;
			IL_AB5E:
			this.LblRadWideLabtoolKeypadType_A8372 = (global::AcpUI.AcpLabel)target;
			this.LblRadWideLabtoolKeypadType_A8372.MouseDoubleClick += new global::System.Windows.Input.MouseButtonEventHandler(this.OnFieldNameDoubleClick);
			return;
			IL_AB82:
			this.CpyBtnRadWideGeneralTlsPsk_44841 = (global::AcpUI.AcpCopyButton)target;
			return;
			IL_AB8F:
			this.CpyBtnRadWideLabtoolFreeRevolvingRotary_A8147 = (global::AcpUI.AcpCopyButton)target;
			return;
			IL_AB9C:
			this.CVBtnRadWideUserInformationandPasswordsRadioAlias_A8829 = (global::AcpUI.AcpCustomViewCheckBox)target;
			return;
			IL_ABA9:
			this.LblRadWideCombineTxWithRxFilteredAudio_44808 = (global::AcpUI.AcpLabel)target;
			this.LblRadWideCombineTxWithRxFilteredAudio_44808.MouseDoubleClick += new global::System.Windows.Input.MouseButtonEventHandler(this.OnFieldNameDoubleClick);
			return;
			IL_ABCD:
			this.CVBtnSensorEventNotificationEnable_43525 = (global::AcpUI.AcpCustomViewCheckBox)target;
			return;
			IL_ABDA:
			this.RadWideAdvancedUltraNarrowIntermediateFreqFilter_A9592Comp = (global::AcpUI.AcpLabel)target;
			return;
			IL_ABE7:
			this.LblRadWideLabtoolReadWriteVoiceFiles_A8893 = (global::AcpUI.AcpLabel)target;
			this.LblRadWideLabtoolReadWriteVoiceFiles_A8893.MouseDoubleClick += new global::System.Windows.Input.MouseButtonEventHandler(this.OnFieldNameDoubleClick);
			return;
			IL_AC0B:
			this.CVBtnRadWideTPSFiregroundPeriodicUpdateTimer_A33467 = (global::AcpUI.AcpCustomViewCheckBox)target;
			return;
			IL_AC18:
			this.CpyBtnEmergencyHotAuxMicConfigurability_A42301 = (global::AcpUI.AcpCopyButton)target;
			return;
			IL_AC25:
			this.LblRadioWideLabtoolDisableWindNoiseReductionLevelForAccessories_43548 = (global::AcpUI.AcpLabel)target;
			this.LblRadioWideLabtoolDisableWindNoiseReductionLevelForAccessories_43548.MouseDoubleClick += new global::System.Windows.Input.MouseButtonEventHandler(this.OnFieldNameDoubleClick);
			return;
			IL_AC49:
			this.CpyBtnRadWideLabtoolTxEndFrequencySplit_A9532 = (global::AcpUI.AcpCopyButton)target;
			return;
			IL_AC56:
			this.RadWideLocationDistanceUnit_A13080 = (global::AcpUI.AcpComboBox)target;
			this.RadWideLocationDistanceUnit_A13080.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_AC7A:
			this.RTDBtnRadWideTPSFiregroundEmergencyCallDekeySidetone_A7936 = (global::AcpUI.AcpRtdButton)target;
			return;
			IL_AC87:
			this.LblRadProfAlertTonesCallAlertToneAutoReset_A7596 = (global::AcpUI.AcpLabel)target;
			this.LblRadProfAlertTonesCallAlertToneAutoReset_A7596.MouseDoubleClick += new global::System.Windows.Input.MouseButtonEventHandler(this.OnFieldNameDoubleClick);
			return;
			IL_ACAB:
			this.RadWideUserInformationandPasswordsUnlockPassword_A8690Comp = (global::AcpUI.AcpLabel)target;
			return;
			IL_ACB8:
			this.CpyBtnRadWideUserInformationandPasswordsPIN_A8705 = (global::AcpUI.AcpCopyButton)target;
			return;
			IL_ACC5:
			this.LblRadWideTransmitPowerLevelsTxPowerLevelConfigType_A41179 = (global::AcpUI.AcpLabel)target;
			this.LblRadWideTransmitPowerLevelsTxPowerLevelConfigType_A41179.MouseDoubleClick += new global::System.Windows.Input.MouseButtonEventHandler(this.OnFieldNameDoubleClick);
			return;
			IL_ACE9:
			this.RadWideLabtoolCertMgmtMotorolaSolutionsPKIHostname = (global::AcpUI.AcpTextBox)target;
			this.RadWideLabtoolCertMgmtMotorolaSolutionsPKIHostname.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_AD0D:
			this.CVBtnAdvancedAuxTransmitSensitivity_A7530 = (global::AcpUI.AcpCustomViewCheckBox)target;
			return;
			IL_AD1A:
			this.ExpanderRadioWideFCCNarrowBandingFrequencySplitTable = (global::AcpUI.AcpXamDataPresenter)target;
			return;
			IL_AD27:
			this.RadWideDigitalAudioOptionsWeakSignalFringe_A9678 = (global::AcpUI.AcpCheckBox)target;
			this.RadWideDigitalAudioOptionsWeakSignalFringe_A9678.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_AD4B:
			this.LblRadWideFeaturesRadioCertificationType_43064 = (global::AcpUI.AcpLabel)target;
			this.LblRadWideFeaturesRadioCertificationType_43064.MouseDoubleClick += new global::System.Windows.Input.MouseButtonEventHandler(this.OnFieldNameDoubleClick);
			return;
			IL_AD6F:
			this.LblRadWideAdvancedPreAmp_A8733 = (global::AcpUI.AcpLabel)target;
			this.LblRadWideAdvancedPreAmp_A8733.MouseDoubleClick += new global::System.Windows.Input.MouseButtonEventHandler(this.OnFieldNameDoubleClick);
			return;
			IL_AD93:
			this.RTDBtnRadWideLabtoolDynamicZoneScanCapability_42749 = (global::AcpUI.AcpRtdButton)target;
			return;
			IL_ADA0:
			this.RadWideGeneralOwnerAdvancedKeyType_A38663Comp = (global::AcpUI.AcpLabel)target;
			return;
			IL_ADAD:
			this.CVBtnRadWideLabtoolCertMgmtMotorolaSolutionsPKIPort = (global::AcpUI.AcpCustomViewCheckBox)target;
			return;
			IL_ADBA:
			this.RadWideUserInformationAndPasswordsTacticalInhibitEnable_A34405Comp = (global::AcpUI.AcpCheckBox)target;
			return;
			IL_ADC7:
			this.CVBtnRadWideTPSFiregroundEmergencyAlarmRetryRatesec_A7929 = (global::AcpUI.AcpCustomViewCheckBox)target;
			return;
			IL_ADD4:
			this.RTDBtnRadWideTPSFiregroundPeriodicUpdateTimer_A33467 = (global::AcpUI.AcpRtdButton)target;
			return;
			IL_ADE1:
			this.LblRadWideFeatureDynamicIcons_A42963 = (global::AcpUI.AcpLabel)target;
			this.LblRadWideFeatureDynamicIcons_A42963.MouseDoubleClick += new global::System.Windows.Input.MouseButtonEventHandler(this.OnFieldNameDoubleClick);
			return;
			IL_AE05:
			this.LblRadProfAlertTonesMuteTonesOperation_A8562 = (global::AcpUI.AcpLabel)target;
			this.LblRadProfAlertTonesMuteTonesOperation_A8562.MouseDoubleClick += new global::System.Windows.Input.MouseButtonEventHandler(this.OnFieldNameDoubleClick);
			return;
			IL_AE29:
			this.CpyBtnRadProfAlertTonesRotaryAlert_A8983 = (global::AcpUI.AcpCopyButton)target;
			return;
			IL_AE36:
			this.CpyBtnRadWideDigitalAudioOptionsStrongInterference1_A9207 = (global::AcpUI.AcpCopyButton)target;
			return;
			IL_AE43:
			this.RadWideAudioOptionsSelectBluetoothMicForAuxPTTAudioSource_44819Comp = (global::AcpUI.AcpCheckBox)target;
			return;
			IL_AE50:
			this.CVBtnRadWideLabtoolAnalogWideBandDataPCIBit_44885 = (global::AcpUI.AcpCustomViewCheckBox)target;
			return;
			IL_AE5D:
			this.RadWideTransmitPowerLevelsFrequencyRangeEndMHz_A41857_Col = (global::Infragistics.Windows.DataPresenter.UnboundField)target;
			return;
			IL_AE6A:
			this.RadWideDualRadioTalkgroupMuteOption_A42290Comp = (global::AcpUI.AcpLabel)target;
			return;
			IL_AE77:
			this.LblRadWideLabtoolConsolidatedActionEnhancement_A43036 = (global::AcpUI.AcpLabel)target;
			this.LblRadWideLabtoolConsolidatedActionEnhancement_A43036.MouseDoubleClick += new global::System.Windows.Input.MouseButtonEventHandler(this.OnFieldNameDoubleClick);
			return;
			IL_AE9B:
			this.RadWideUserInformationandPasswordsTacticalServiceEncodePasswordComp = (global::AcpUI.AcpLabel)target;
			return;
			IL_AEA8:
			this.CVBtnRadWideTransmitPowerLevelsTxPowerLevelHighW_A8152 = (global::AcpUI.AcpCustomViewCheckBox)target;
			return;
			IL_AEB5:
			this.CVBtnRadWideGenLightBarPatternRelay10_A36516 = (global::AcpUI.AcpCustomViewCheckBox)target;
			return;
			IL_AEC2:
			this.CVBtnIsolatedGCAIAccessoryPlugAndPlayDisable_42927 = (global::AcpUI.AcpCustomViewCheckBox)target;
			return;
			IL_AECF:
			this.RadWideDigitalAudioOptionsStrongInterference1_A9207 = (global::AcpUI.AcpCheckBox)target;
			this.RadWideDigitalAudioOptionsStrongInterference1_A9207.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_AEF3:
			this.CpyBtnRadWideGenLightBarPatternRelay6_A36511 = (global::AcpUI.AcpCopyButton)target;
			return;
			IL_AF00:
			this.RadWideLabtoolAPXSingletoneCapable_43080 = (global::AcpUI.AcpLabel)target;
			this.RadWideLabtoolAPXSingletoneCapable_43080.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_AF24:
			this.LblRadWideLabtoolSirenPaOnly_A9142 = (global::AcpUI.AcpLabel)target;
			this.LblRadWideLabtoolSirenPaOnly_A9142.MouseDoubleClick += new global::System.Windows.Input.MouseButtonEventHandler(this.OnFieldNameDoubleClick);
			return;
			IL_AF48:
			this.RadWideTransmitPowerLevelsConvTxPowerLevelMinimumW_A41863 = (global::AcpUI.AcpTextBox)target;
			this.RadWideTransmitPowerLevelsConvTxPowerLevelMinimumW_A41863.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_AF6C:
			this.LblRadWideLocationDisplayFormat_A41561 = (global::AcpUI.AcpLabel)target;
			this.LblRadWideLocationDisplayFormat_A41561.MouseDoubleClick += new global::System.Windows.Input.MouseButtonEventHandler(this.OnFieldNameDoubleClick);
			return;
			IL_AF90:
			this.RTDBtnRadWideTransmitPowerLevelsTxPowerLevelMaximumW_A41859 = (global::AcpUI.AcpRtdButton)target;
			return;
			IL_AF9D:
			this.RTDBtnRadWideTransmitPowerLevelsFrequencyRangeStartMHz_A19994 = (global::AcpUI.AcpRtdButton)target;
			return;
			IL_AFAA:
			this.CpyBtnRadWideLocationDisplayPeerLocation_42433 = (global::AcpUI.AcpCopyButton)target;
			return;
			IL_AFB7:
			this.CVBtnRadWideFeatureAnalogWidebandData = (global::AcpUI.AcpCustomViewCheckBox)target;
			return;
			IL_AFC4:
			this.RadWideFeaturesIgnitionAutoPoweroff_A38014 = (global::AcpUI.AcpTextBoxSpinner)target;
			this.RadWideFeaturesIgnitionAutoPoweroff_A38014.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_AFE8:
			this.RadWideLabtoolSuppressEmergencyCallCapability_A42143 = (global::AcpUI.AcpLabel)target;
			this.RadWideLabtoolSuppressEmergencyCallCapability_A42143.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_B00C:
			this.RTDBtnRadWideAdvancedPreAmp_A8733 = (global::AcpUI.AcpRtdButton)target;
			return;
			IL_B019:
			this.CVBtnRadWideLabtoolLTEUsed_A42064 = (global::AcpUI.AcpCustomViewCheckBox)target;
			return;
			IL_B026:
			this.CVBtnRadWideTransmitPowerLevelsConvTxPowerLevelLowW_A41175 = (global::AcpUI.AcpCustomViewCheckBox)target;
			return;
			IL_B033:
			this.CVBtnRadWideTPSFiregroundEvacuationTone_A7980 = (global::AcpUI.AcpCustomViewCheckBox)target;
			return;
			IL_B040:
			this.RadWideLocationMaxStoredLocationRequests_A8473Comp = (global::AcpUI.AcpLabel)target;
			return;
			IL_B04D:
			this.HLinkFCCNarrowBandingFrequencySplit = (global::System.Windows.Documents.Hyperlink)target;
			this.HLinkFCCNarrowBandingFrequencySplit.Click += this.HLinkClick;
			return;
			IL_B071:
			this.CpyBtnRadWideLabtoolEncryptedPINPassword_A41702 = (global::AcpUI.AcpCopyButton)target;
			return;
			IL_B07E:
			this.RTDBtnRadWideUserinfoPassRequiredForSiren_A36533 = (global::AcpUI.AcpRtdButton)target;
			return;
			IL_B08B:
			this.HLinkRxFrequencySplit = (global::System.Windows.Documents.Hyperlink)target;
			this.HLinkRxFrequencySplit.Click += this.HLinkClick;
			return;
			IL_B0AF:
			this.RadWideLabtoolFCCNarrowBandStartFrequency_A38270 = (global::AcpUI.AcpTextBox)target;
			this.RadWideLabtoolFCCNarrowBandStartFrequency_A38270.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_B0D3:
			this.RadWideLabtoolSeamlessUpdateOutOfBoxExperience = (global::AcpUI.AcpLabel)target;
			this.RadWideLabtoolSeamlessUpdateOutOfBoxExperience.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_B0F7:
			this.CVBtnRadWideTPSPTTTransmission_A41545 = (global::AcpUI.AcpCustomViewCheckBox)target;
			return;
			IL_B104:
			this.RTDBtnRadWideLabtoolADPGatingPCIBit = (global::AcpUI.AcpRtdButton)target;
			return;
			IL_B111:
			this.RadWideUserInformationandPasswordsSoftIDUsernameDisplayTextSize_A23453 = (global::AcpUI.AcpTextBoxSpinner)target;
			this.RadWideUserInformationandPasswordsSoftIDUsernameDisplayTextSize_A23453.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_B135:
			this.CpyBtnRadioWidePTTWarningTone = (global::AcpUI.AcpCopyButton)target;
			return;
			IL_B142:
			this.RadWideGenLightBarPatternRelay6_A36511 = (global::AcpUI.AcpComboBox)target;
			this.RadWideGenLightBarPatternRelay6_A36511.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_B166:
			this.RadWideBluetoothActiveRSMInternalMicIfNotBtMic_A41576 = (global::AcpUI.AcpCheckBox)target;
			this.RadWideBluetoothActiveRSMInternalMicIfNotBtMic_A41576.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_B18A:
			this.LblRadWideLabtoolRxStartFrequencySplit_A9032 = (global::AcpUI.AcpLabel)target;
			this.LblRadWideLabtoolRxStartFrequencySplit_A9032.MouseDoubleClick += new global::System.Windows.Input.MouseButtonEventHandler(this.OnFieldNameDoubleClick);
			return;
			IL_B1AE:
			this.RadWideLabtoolFreeRevolvingRotary_A8147 = (global::AcpUI.AcpCheckBox)target;
			this.RadWideLabtoolFreeRevolvingRotary_A8147.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_B1D2:
			this.RTDBtnRadWideLabtoolIndirectPTTAudioRoutingPCI_44817 = (global::AcpUI.AcpRtdButton)target;
			return;
			IL_B1DF:
			this.CpyBtnRadWideLabtoolEmergencyCallOnlywithHotMicCapable_A43162 = (global::AcpUI.AcpCopyButton)target;
			return;
			IL_B1EC:
			this.CVBtnRadWideUserInformationAndPasswordsTacticalInhibitEnable_A34405 = (global::AcpUI.AcpCustomViewCheckBox)target;
			return;
			IL_B1F9:
			this.CVBtnRadioWideReqFWVersion_A42872 = (global::AcpUI.AcpCustomViewCheckBox)target;
			return;
			IL_B206:
			this.RecNavToolbarExpanderRadioWideGeneralLightbarPattern = (global::AcpUI.AcpRecNavToolbar)target;
			this.RecNavToolbarExpanderRadioWideGeneralLightbarPattern.ModeClick += this.OnModeClick;
			return;
			IL_B22A:
			this.CpyBtnRadioWideLabtoolExtendedPLToneSet_43769 = (global::AcpUI.AcpCopyButton)target;
			return;
			IL_B237:
			this.RadWideUserinfoPassRequiredForLightbar_A36532 = (global::AcpUI.AcpCheckBox)target;
			this.RadWideUserinfoPassRequiredForLightbar_A36532.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_B25B:
			this.RadWideLocationExitLocationMenuonPTT_A13081 = (global::AcpUI.AcpCheckBox)target;
			this.RadWideLocationExitLocationMenuonPTT_A13081.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_B27F:
			this.ExpanderRadioWideDepot = (global::AcpUI.AcpExpander)target;
			return;
			IL_B28C:
			this.CpyBtnRadWideAdvancedMaximumTxDeviation_A8480 = (global::AcpUI.AcpCopyButton)target;
			return;
			IL_B299:
			this.RadWideGeneralDnsSdAddress_44843 = (global::AcpUI.AcpTextBox)target;
			this.RadWideGeneralDnsSdAddress_44843.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_B2BD:
			this.CpyBtnRadioWideReqFWVersion_A42872 = (global::AcpUI.AcpCopyButton)target;
			return;
			IL_B2CA:
			this.RadWideGunlockRelocktimerName_A36521 = (global::AcpUI.AcpLabel)target;
			this.RadWideGunlockRelocktimerName_A36521.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_B2EE:
			this.RTDBtnRadWideLabtoolDisplayType_A7887 = (global::AcpUI.AcpRtdButton)target;
			return;
			IL_B2FB:
			this.RadWideTPSFiregroundRespondToPolls_A33573 = (global::AcpUI.AcpCheckBox)target;
			this.RadWideTPSFiregroundRespondToPolls_A33573.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_B31F:
			this.RadWideUserInformationandPasswordsUserLoginAuthenticationType_A44926 = (global::AcpUI.AcpComboBox)target;
			this.RadWideUserInformationandPasswordsUserLoginAuthenticationType_A44926.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_B343:
			this.CVBtnZnChanCfgFPPProtectionFPPEnable_A8142 = (global::AcpUI.AcpCustomViewCheckBox)target;
			return;
			IL_B350:
			this.CVBtnRadWideAdvancedUltraNarrowIntermediateFreqFilter_A9592 = (global::AcpUI.AcpCustomViewCheckBox)target;
			return;
			IL_B35D:
			this.CpyBtnRadWideUserInformationandUserLoginUnitIDTextSize_41309 = (global::AcpUI.AcpCopyButton)target;
			return;
			IL_B36A:
			this.RadWideSmartMappingServerAssistedLocationComp = (global::AcpUI.AcpCheckBox)target;
			return;
			IL_B377:
			this.RadWideUserInformationandPasswordsRadioLockForceChangePassword_A3583Comp = (global::AcpUI.AcpCheckBox)target;
			return;
			IL_B384:
			this.RadWideGenLightBarPatternRelay3_A36508Comp = (global::AcpUI.AcpLabel)target;
			return;
			IL_B391:
			this.RadWideLocationDisplayPeerLocation_42433Comp = (global::AcpUI.AcpCheckBox)target;
			return;
			IL_B39E:
			this.LblIsolatedGCAIAccessoryPlugAndPlayDisable_42927 = (global::AcpUI.AcpLabel)target;
			this.LblIsolatedGCAIAccessoryPlugAndPlayDisable_42927.MouseDoubleClick += new global::System.Windows.Input.MouseButtonEventHandler(this.OnFieldNameDoubleClick);
			return;
			IL_B3C2:
			this.RTDBtnRadWideLabtoolAPX6000P25Radio_A42121 = (global::AcpUI.AcpRtdButton)target;
			return;
			IL_B3CF:
			this.RadWideLabtoolDisplayContrastConfiguration_A7873Comp = (global::AcpUI.AcpTextBoxDecHex)target;
			return;
			IL_B3DC:
			this.RadWideCustomLogoEnabledComp = (global::AcpUI.AcpCheckBox)target;
			return;
			IL_B3E9:
			this.CVBtnRadWideLabtoolDynamicZoneCable_A41258 = (global::AcpUI.AcpCustomViewCheckBox)target;
			return;
			IL_B3F6:
			this.RadDualRadioFatalErrorOption_A42243 = (global::AcpUI.AcpLabel)target;
			this.RadDualRadioFatalErrorOption_A42243.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_B41A:
			this.RadWideFeaturesVoiceControlPriority = (global::AcpUI.AcpComboBox)target;
			this.RadWideFeaturesVoiceControlPriority.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_B43E:
			this.RadWideLabtoolMaritimeRadioSoftware_A42191Comp = (global::AcpUI.AcpLabel)target;
			return;
			IL_B44B:
			this.LblRadWideLabtoolRadioPassword_A8837 = (global::AcpUI.AcpLabel)target;
			this.LblRadWideLabtoolRadioPassword_A8837.MouseDoubleClick += new global::System.Windows.Input.MouseButtonEventHandler(this.OnFieldNameDoubleClick);
			return;
			IL_B46F:
			this.CVBtnRadWideLabtoolEncryptedPINPassword_A41702 = (global::AcpUI.AcpCustomViewCheckBox)target;
			return;
			IL_B47C:
			this.CVBtnRadWideLabtoolRxBandSplitName_A24797 = (global::AcpUI.AcpCustomViewCheckBox)target;
			return;
			IL_B489:
			this.CVBtnRadWideFeaturesTargetChanOnOffHook_A42356 = (global::AcpUI.AcpCustomViewCheckBox)target;
			return;
			IL_B496:
			this.LblRadWideLabtoolDisableEncryption_43371 = (global::AcpUI.AcpLabel)target;
			this.LblRadWideLabtoolDisableEncryption_43371.MouseDoubleClick += new global::System.Windows.Input.MouseButtonEventHandler(this.OnFieldNameDoubleClick);
			return;
			IL_B4BA:
			this.RadWideAlertTonesZeroLevelAudioMute_A9689Comp = (global::AcpUI.AcpCheckBox)target;
			return;
			IL_B4C7:
			this.CpyBtnRadWideLabtoolEmergencyRevertCapable_A41918 = (global::AcpUI.AcpCopyButton)target;
			return;
			IL_B4D4:
			this.CVBtnToneEmergencyConfigurableCapable_42083 = (global::AcpUI.AcpCustomViewCheckBox)target;
			return;
			IL_B4E1:
			this.CVBtnRadWideAdvancedPreAmp_A8733 = (global::AcpUI.AcpCustomViewCheckBox)target;
			return;
			IL_B4EE:
			this.CpyBtnRadWideUserInformationandPasswordsRadioLockAttemptsAllowed_A3582 = (global::AcpUI.AcpCopyButton)target;
			return;
			IL_B4FB:
			this.CpyBtnRadWideTPSFiregroundVoiceTxEndTone_A9655 = (global::AcpUI.AcpCopyButton)target;
			return;
			IL_B508:
			this.CVBtnRadProfAlertTonesAlertTones_A7428 = (global::AcpUI.AcpCustomViewCheckBox)target;
			return;
			IL_B515:
			this.RTDBtnRadWideUserInformationandPasswordsTacticalServiceEncodePassword = (global::AcpUI.AcpRtdButton)target;
			return;
			IL_B522:
			this.CpyBtnRadWideLabtoolEnhancedARS_A43084 = (global::AcpUI.AcpCopyButton)target;
			return;
			IL_B52F:
			this.ExpanderRadioWideRelockTimer = (global::AcpUI.AcpXamDataPresenter)target;
			return;
			IL_B53C:
			this.CpyBtnRadWideUserInformationandUserLoginUnitID_41306 = (global::AcpUI.AcpCopyButton)target;
			return;
			IL_B549:
			this.CpyBtnRadWideBluetoothBluetoothDropTimer_A37038 = (global::AcpUI.AcpCopyButton)target;
			return;
			IL_B556:
			this.RadWideFeaturesRadioInhibitDisplayTextLine2_44916 = (global::AcpUI.AcpTextBox)target;
			this.RadWideFeaturesRadioInhibitDisplayTextLine2_44916.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_B57A:
			this.RTDBtnRadWideLabtoolDisableEncryption_43371 = (global::AcpUI.AcpRtdButton)target;
			return;
			IL_B587:
			this.RadWideLabtoolSirenPaSystemLookup_A9143 = (global::AcpUI.AcpCheckBox)target;
			this.RadWideLabtoolSirenPaSystemLookup_A9143.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_B5AB:
			this.CpyBtnRadWideLabtoolFCCNarrowBandStartFrequency_A38270 = (global::AcpUI.AcpCopyButton)target;
			return;
			IL_B5B8:
			this.CVBtnRadWideTPSFiregroundEmergencyCallDekeySidetone_A7936 = (global::AcpUI.AcpCustomViewCheckBox)target;
			return;
			IL_B5C5:
			this.CpyBtnRadWideAdvancedSmartLowBatteryAlert_A9165 = (global::AcpUI.AcpCopyButton)target;
			return;
			IL_B5D2:
			this.RadWideLabtoolRxBandSplitName_A24797 = (global::AcpUI.AcpLabel)target;
			this.RadWideLabtoolRxBandSplitName_A24797.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_B5F6:
			this.CVBtnRadWideFeaturesTargetZoneOnOffHook_A42355 = (global::AcpUI.AcpCustomViewCheckBox)target;
			return;
			IL_B603:
			this.ExpanderRadioWideTxPowerLevelsByFrequencyRangeGrid = (global::System.Windows.Controls.Grid)target;
			return;
			IL_B610:
			this.RadioWideLabtoolDisableWindNoiseReductionLevelForAccessories_43548Comp = (global::AcpUI.AcpLabel)target;
			return;
			IL_B61D:
			this.LblRadWideLabtoolRCLastJobSetUUID = (global::AcpUI.AcpLabel)target;
			this.LblRadWideLabtoolRCLastJobSetUUID.MouseDoubleClick += new global::System.Windows.Input.MouseButtonEventHandler(this.OnFieldNameDoubleClick);
			return;
			IL_B641:
			this.CpyBtnRadWideLabtoolRadioPassword_A8837 = (global::AcpUI.AcpCopyButton)target;
			return;
			IL_B64E:
			this.RadWideTPSAudibleEmergencyBeaconRouting_A41972Comp = (global::AcpUI.AcpLabel)target;
			return;
			IL_B65B:
			this.RTDBtnRadCfgVirtualPartnerInactivityTime = (global::AcpUI.AcpRtdButton)target;
			return;
			IL_B668:
			this.LblRadWideGeneralOwnerWACNID_A38656 = (global::AcpUI.AcpLabel)target;
			this.LblRadWideGeneralOwnerWACNID_A38656.MouseDoubleClick += new global::System.Windows.Input.MouseButtonEventHandler(this.OnFieldNameDoubleClick);
			return;
			IL_B68C:
			this.CVBtnRadWideFeaturesRadioInhibitDisplayTextLine2_44916 = (global::AcpUI.AcpLabel)target;
			this.CVBtnRadWideFeaturesRadioInhibitDisplayTextLine2_44916.MouseDoubleClick += new global::System.Windows.Input.MouseButtonEventHandler(this.OnFieldNameDoubleClick);
			return;
			IL_B6B0:
			this.CVBtnRadWideUserInformationandPasswordsRadioAliasEnable_A8830 = (global::AcpUI.AcpCustomViewCheckBox)target;
			return;
			IL_B6BD:
			this.RadWideFeaturePreAmpVHF_A42960 = (global::AcpUI.AcpCheckBox)target;
			this.RadWideFeaturePreAmpVHF_A42960.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_B6E1:
			this.HLinkGunLock = (global::System.Windows.Documents.Hyperlink)target;
			this.HLinkGunLock.Click += this.HLinkClick;
			return;
			IL_B705:
			this.RTDBtnRadWideUserInformationandUserLoginUnitIDEnable_41305 = (global::AcpUI.AcpRtdButton)target;
			return;
			IL_B712:
			this.RadWideDigitalAudioOptionsWeakSignalFringe_A9678Comp = (global::AcpUI.AcpCheckBox)target;
			return;
			IL_B71F:
			this.RadWideUniversalRelayControllerFatalError_A37194 = (global::AcpUI.AcpCheckBox)target;
			this.RadWideUniversalRelayControllerFatalError_A37194.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_B743:
			this.CVBtnRadWideGeneralDnsSdAddress_44843 = (global::AcpUI.AcpCustomViewCheckBox)target;
			return;
			IL_B750:
			this.CVBtnRadWideFeaturesVirtualPartnerAudioPriority = (global::AcpUI.AcpCustomViewCheckBox)target;
			return;
			IL_B75D:
			this.RadWideUserInformationandPasswordsRadioAliasEnable_A8830Comp = (global::AcpUI.AcpCheckBox)target;
			return;
			IL_B76A:
			this.LblRadWideLabtoolSirenPaSystemLookup_A9143 = (global::AcpUI.AcpLabel)target;
			this.LblRadWideLabtoolSirenPaSystemLookup_A9143.MouseDoubleClick += new global::System.Windows.Input.MouseButtonEventHandler(this.OnFieldNameDoubleClick);
			return;
			IL_B78E:
			this.RadWideAdvancedCyclicKeying_A7795Comp = (global::AcpUI.AcpCheckBox)target;
			return;
			IL_B79B:
			this.RadWideUniversalRelayControllerFatalError_A37194Comp = (global::AcpUI.AcpCheckBox)target;
			return;
			IL_B7A8:
			this.LblRadWideLabtoolRxEndFrequencySplit_A9015 = (global::AcpUI.AcpLabel)target;
			this.LblRadWideLabtoolRxEndFrequencySplit_A9015.MouseDoubleClick += new global::System.Windows.Input.MouseButtonEventHandler(this.OnFieldNameDoubleClick);
			return;
			IL_B7CC:
			this.RadWideConventionalDynamicIDWithPassword_A43705Comp = (global::AcpUI.AcpLabel)target;
			return;
			IL_B7D9:
			this.CpyBtnRadWideFeaturesVoiceControlPriority = (global::AcpUI.AcpCopyButton)target;
			return;
			IL_B7E6:
			this.LblRadWideUserInformationandPasswordsRadioLock_A8836 = (global::AcpUI.AcpLabel)target;
			this.LblRadWideUserInformationandPasswordsRadioLock_A8836.MouseDoubleClick += new global::System.Windows.Input.MouseButtonEventHandler(this.OnFieldNameDoubleClick);
			return;
			IL_B80A:
			this.LblRadWideGenLightBarPatternRelay8_A36513 = (global::AcpUI.AcpLabel)target;
			this.LblRadWideGenLightBarPatternRelay8_A36513.MouseDoubleClick += new global::System.Windows.Input.MouseButtonEventHandler(this.OnFieldNameDoubleClick);
			return;
			IL_B82E:
			this.RadWideGenLightBarPatternRelay10_A36516_Col = (global::Infragistics.Windows.DataPresenter.UnboundField)target;
			return;
			IL_B83B:
			this.RTDBtnRadWideLocationExitLocationMenuonPTT_A13081 = (global::AcpUI.AcpRtdButton)target;
			return;
			IL_B848:
			this.LblRadWideTransmitPowerLevelsFrequencyRangeStartMHz_A19994 = (global::AcpUI.AcpLabel)target;
			this.LblRadWideTransmitPowerLevelsFrequencyRangeStartMHz_A19994.MouseDoubleClick += new global::System.Windows.Input.MouseButtonEventHandler(this.OnFieldNameDoubleClick);
			return;
			IL_B86C:
			this.CpyBtnRadWideTransmitPowerLevelsTxPowerLevelHighW_A8152 = (global::AcpUI.AcpCopyButton)target;
			return;
			IL_B879:
			this.ZnChanCfgFPPProtectionFPPEnable_A8142Comp = (global::AcpUI.AcpCheckBox)target;
			return;
			IL_B886:
			this.LblRadWideUserInformationAndPasswordsTacticalInhibitEncodePassword_A34395 = (global::AcpUI.AcpLabel)target;
			this.LblRadWideUserInformationAndPasswordsTacticalInhibitEncodePassword_A34395.MouseDoubleClick += new global::System.Windows.Input.MouseButtonEventHandler(this.OnFieldNameDoubleClick);
			return;
			IL_B8AA:
			this.CVBtnRadWideLabtoolRadioPassword_A8837 = (global::AcpUI.AcpCustomViewCheckBox)target;
			return;
			IL_B8B7:
			this.RadWideRecentCallListDeleteEnable = (global::AcpUI.AcpCheckBox)target;
			this.RadWideRecentCallListDeleteEnable.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_B8DB:
			this.CpyBtnRadWideGeneralDateFormat_A7802 = (global::AcpUI.AcpCopyButton)target;
			return;
			IL_B8E8:
			this.RadWideTransmitPowerLevelsConvTxPowerLevelLowW_A41175 = (global::AcpUI.AcpTextBox)target;
			this.RadWideTransmitPowerLevelsConvTxPowerLevelLowW_A41175.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_B90C:
			this.RadWideUserInformationandPasswordsRadioLock_A8836Comp = (global::AcpUI.AcpCheckBox)target;
			return;
			IL_B919:
			this.RadWideLabtoolConsolidatedActionEnhancement_A43036Comp = (global::AcpUI.AcpLabel)target;
			return;
			IL_B926:
			this.CVBtnRadWideOutOfRangeToneSelection_A42450 = (global::AcpUI.AcpCustomViewCheckBox)target;
			return;
			IL_B933:
			this.RadWideBluetoothLegacyBluetoothPINPairing = (global::AcpUI.AcpCheckBox)target;
			this.RadWideBluetoothLegacyBluetoothPINPairing.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_B957:
			this.TrunkingRadioInhibited_A19483Comp = (global::AcpUI.AcpCheckBox)target;
			return;
			IL_B964:
			this.RTDBtnRadWideTransmitPowerLevelsTxPowerLevelMinimumW_A41858 = (global::AcpUI.AcpRtdButton)target;
			return;
			IL_B971:
			this.RadWideGunlockRelocktimerTimer_A36522_Col = (global::Infragistics.Windows.DataPresenter.UnboundField)target;
			return;
			IL_B97E:
			this.LblRadWideGeneralTlsPskPort_44842 = (global::AcpUI.AcpLabel)target;
			this.LblRadWideGeneralTlsPskPort_44842.MouseDoubleClick += new global::System.Windows.Input.MouseButtonEventHandler(this.OnFieldNameDoubleClick);
			return;
			IL_B9A2:
			this.CpyBtnRadWideGenLightBarPatternRelay1_A36506 = (global::AcpUI.AcpCopyButton)target;
			return;
			IL_B9AF:
			this.CVBtnRadWideBluetoothImproveAudioLatency_A44943 = (global::AcpUI.AcpCustomViewCheckBox)target;
			return;
			IL_B9BC:
			this.CVBtnRadWideGeneralTlsPsk_44841 = (global::AcpUI.AcpCustomViewCheckBox)target;
			return;
			IL_B9C9:
			this.RadWideFeaturesRadioCertificationType_43064 = (global::AcpUI.AcpComboBox)target;
			this.RadWideFeaturesRadioCertificationType_43064.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_B9ED:
			this.CpyBtnRadWideLabtoolRadioWritePasswordEnable_A8889 = (global::AcpUI.AcpCopyButton)target;
			return;
			IL_B9FA:
			this.RadioWideMOSCADACE3000Capability_A42772 = (global::AcpUI.AcpLabel)target;
			this.RadioWideMOSCADACE3000Capability_A42772.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_BA1E:
			this.RadWideTransmitPowerLevelsFrequencyRangeStartMHz_A19994_Col = (global::Infragistics.Windows.DataPresenter.UnboundField)target;
			return;
			IL_BA2B:
			this.RadWideTransmitPowerLevelsTxPowerLevelMaximumW_A20039 = (global::AcpUI.AcpTextBox)target;
			this.RadWideTransmitPowerLevelsTxPowerLevelMaximumW_A20039.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_BA4F:
			this.RadWideLabtoolFatalError_A8015 = (global::AcpUI.AcpCheckBox)target;
			this.RadWideLabtoolFatalError_A8015.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_BA73:
			this.GrpBoxExpanderRadioWideLabtoolProductCapabilityIndicators = (global::AcpUI.AcpGroupBox)target;
			return;
			IL_BA80:
			this.LblRadWideLabtoolSupportO3ControlHeadPCIBit_44884 = (global::AcpUI.AcpLabel)target;
			this.LblRadWideLabtoolSupportO3ControlHeadPCIBit_44884.MouseDoubleClick += new global::System.Windows.Input.MouseButtonEventHandler(this.OnFieldNameDoubleClick);
			return;
			IL_BAA4:
			this.LblRadWideStandardNFCPairing_A44928 = (global::AcpUI.AcpLabel)target;
			this.LblRadWideStandardNFCPairing_A44928.MouseDoubleClick += new global::System.Windows.Input.MouseButtonEventHandler(this.OnFieldNameDoubleClick);
			return;
			IL_BAC8:
			this.RadWideFeaturesChannelFallbackEnableComp = (global::AcpUI.AcpCheckBox)target;
			return;
			IL_BAD5:
			this.CVBtnRadWideUniversalRelayControllerEquipped_A37191 = (global::AcpUI.AcpCustomViewCheckBox)target;
			return;
			IL_BAE2:
			this.RTDBtnRadWideLabtoolEncryptPassword_A41695 = (global::AcpUI.AcpRtdButton)target;
			return;
			IL_BAEF:
			this.RadWideUserInformationandPasswordsUnlockPassword_A8690 = (global::AcpUI.AcpPasswordEyeBox)target;
			this.RadWideUserInformationandPasswordsUnlockPassword_A8690.GotFocus += this.OnFieldNameDoubleClick;
			this.RadWideUserInformationandPasswordsUnlockPassword_A8690.GotMouseCapture += this.RadWideUserInformationandPasswordsUnlockPassword_A8690_GotMouseCapture;
			this.RadWideUserInformationandPasswordsUnlockPassword_A8690.GotKeyboardFocus += this.RadWideUserInformationandPasswordsUnlockPassword_A8690_GotKeyboardFocus;
			return;
			IL_BB41:
			this.RTDBtnRadWideLabtoolAnalogWideBandDataPCIBit_44885 = (global::AcpUI.AcpRtdButton)target;
			return;
			IL_BB4E:
			this.RadioWideLabtoolZoneCloneCapable_43238 = (global::AcpUI.AcpLabel)target;
			this.RadioWideLabtoolZoneCloneCapable_43238.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_BB72:
			this.RadWideLocationExitLocationMenuonPTT_A13081Comp = (global::AcpUI.AcpCheckBox)target;
			return;
			IL_BB7F:
			this.RadWideLabtoolLimitedISSIDVRSOperationCapable_43045 = (global::AcpUI.AcpLabel)target;
			this.RadWideLabtoolLimitedISSIDVRSOperationCapable_43045.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_BBA3:
			this.RadWideLabtoolDynamicZoneCable_A41258Comp = (global::AcpUI.AcpLabel)target;
			return;
			IL_BBB0:
			this.RadWideUserInformationandUserLoginUnitIDEnable_41305 = (global::AcpUI.AcpCheckBox)target;
			this.RadWideUserInformationandUserLoginUnitIDEnable_41305.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_BBD4:
			this.LblRadWideFeaturesZoneCloneEnable_43130 = (global::AcpUI.AcpLabel)target;
			this.LblRadWideFeaturesZoneCloneEnable_43130.MouseDoubleClick += new global::System.Windows.Input.MouseButtonEventHandler(this.OnFieldNameDoubleClick);
			return;
			IL_BBF8:
			this.CpyBtnRadWideUserInformationandUserLoginUnitIDEnable_41305 = (global::AcpUI.AcpCopyButton)target;
			return;
			IL_BC05:
			this.CpyBtnRadWideLocationGpsMode_A22627 = (global::AcpUI.AcpCopyButton)target;
			return;
			IL_BC12:
			this.RadWideUserInformationandCachedCredentialsUserLoginMode_41307 = (global::AcpUI.AcpComboBox)target;
			this.RadWideUserInformationandCachedCredentialsUserLoginMode_41307.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_BC36:
			this.RTDBtnRadWideLabtoolEnhancedARS_A43084 = (global::AcpUI.AcpRtdButton)target;
			return;
			IL_BC43:
			this.LblRadWideLocationDisplayPeerLocation_42433 = (global::AcpUI.AcpLabel)target;
			this.LblRadWideLocationDisplayPeerLocation_42433.MouseDoubleClick += new global::System.Windows.Input.MouseButtonEventHandler(this.OnFieldNameDoubleClick);
			return;
			IL_BC67:
			this.CpyBtnRadWideUserInformationandPINPasswordPart2_41304 = (global::AcpUI.AcpCopyButton)target;
			return;
			IL_BC74:
			this.LblRadWideUserinfoPassRequiredForLightbar_A36532 = (global::AcpUI.AcpLabel)target;
			this.LblRadWideUserinfoPassRequiredForLightbar_A36532.MouseDoubleClick += new global::System.Windows.Input.MouseButtonEventHandler(this.OnFieldNameDoubleClick);
			return;
			IL_BC98:
			this.LblRadWideLocationExitLocationMenuonPTT_A13081 = (global::AcpUI.AcpLabel)target;
			this.LblRadWideLocationExitLocationMenuonPTT_A13081.MouseDoubleClick += new global::System.Windows.Input.MouseButtonEventHandler(this.OnFieldNameDoubleClick);
			return;
			IL_BCBC:
			this.CpyBtnRadWideFeaturesRotarySwitchScanPrgm_A8986 = (global::AcpUI.AcpCopyButton)target;
			return;
			IL_BCC9:
			this.RadWideLabtoolZoneSelectorOnSwitch_A19550Comp = (global::AcpUI.AcpCheckBox)target;
			return;
			IL_BCD6:
			this.RadWideTransmitPowerLevelsBandSplitOverride_A41064Comp = (global::AcpUI.AcpLabel)target;
			return;
			IL_BCE3:
			this.CpyBtnRadWideUniversalRelayControllerFatalError_A37194 = (global::AcpUI.AcpCopyButton)target;
			return;
			IL_BCF0:
			this.GrpBoxExpanderRadioWideLocationPseudo0 = (global::AcpUI.AcpGroupBox)target;
			return;
			IL_BCFD:
			this.RadWideUniversalRelayControllerEquipped_A37191 = (global::AcpUI.AcpCheckBox)target;
			this.RadWideUniversalRelayControllerEquipped_A37191.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_BD21:
			this.CVBtnRadWideFeaturesVLIFPLOSSFIELD_A9596 = (global::AcpUI.AcpCustomViewCheckBox)target;
			return;
			IL_BD2E:
			this.RadWideGenLightBarPatternRelay9_A36515 = (global::AcpUI.AcpComboBox)target;
			this.RadWideGenLightBarPatternRelay9_A36515.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_BD52:
			this.RTDBtnRadWideLabtoolRxEndFrequencySplit_A9015 = (global::AcpUI.AcpRtdButton)target;
			return;
			IL_BD5F:
			this.RadWideGeneralPskId_44840 = (global::AcpUI.AcpTextBox)target;
			this.RadWideGeneralPskId_44840.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_BD83:
			this.CpyBtnRadWideBluetoothReplacePairingInfo_A41562 = (global::AcpUI.AcpCopyButton)target;
			return;
			IL_BD90:
			this.CpyBtnRadWideDualRadioSelection_A42236 = (global::AcpUI.AcpCopyButton)target;
			return;
			IL_BD9D:
			this.SensorEventDisableTimer_43198 = (global::AcpUI.AcpTextBoxSpinner)target;
			this.SensorEventDisableTimer_43198.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_BDC1:
			this.LblRadWideGeneralTlsPsk_44841 = (global::AcpUI.AcpLabel)target;
			this.LblRadWideGeneralTlsPsk_44841.MouseDoubleClick += new global::System.Windows.Input.MouseButtonEventHandler(this.OnFieldNameDoubleClick);
			return;
			IL_BDE5:
			this.RadErgoWideAdvancedModeSelTxNameComp = (global::AcpUI.AcpLabel)target;
			return;
			IL_BDF2:
			this.RTDBtnRadWideFeaturesRecordPlaybackAudioBufferSize_A43125 = (global::AcpUI.AcpRtdButton)target;
			return;
			IL_BDFF:
			this.RTDBtnRadWideLabtoolTxEndFrequencySplit_A9532 = (global::AcpUI.AcpRtdButton)target;
			return;
			IL_BE0C:
			this.CpyBtnRadWideUserInformationandPasswordsRadioAliasEnable_A8830 = (global::AcpUI.AcpCopyButton)target;
			return;
			IL_BE19:
			this.TPSCapable_A42312 = (global::AcpUI.AcpLabel)target;
			this.TPSCapable_A42312.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_BE3D:
			this.ExpanderRadioWideRelockTimerTableView = (global::AcpUI.AcpGroupBox)target;
			return;
			IL_BE4A:
			this.AdvancedExternalMicOnly = (global::AcpUI.AcpCheckBox)target;
			this.AdvancedExternalMicOnly.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_BE6E:
			this.CpyBtnRadWideTPSFiregroundRespondToPolls_A33573 = (global::AcpUI.AcpCopyButton)target;
			return;
			IL_BE7B:
			this.ExpanderRadioWideTxPowerLevelsNewBandPlanGrid = (global::System.Windows.Controls.Grid)target;
			return;
			IL_BE88:
			this.CpyBtnRadCfgVirtualPartnerMode = (global::AcpUI.AcpCopyButton)target;
			return;
			IL_BE95:
			this.b = true;
		}

		// Token: 0x06003E07 RID: 15879 RVA: 0x003A9A78 File Offset: 0x003A7C78
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		[global::System.Diagnostics.DebuggerNonUserCode]
		[global::System.CodeDom.Compiler.GeneratedCode("PresentationBuildTasks", "5.0.10.0")]
		void global::System.Windows.Markup.IStyleConnector.Connect(int connectionId, object target)
		{
			switch (connectionId)
			{
			case 2:
				((global::AcpUI.AcpTableViewOnlyCtrl)target).GotFocus += this.OnFieldNameDoubleClick;
				return;
			case 3:
				((global::AcpUI.AcpTableTextBox)target).GotFocus += this.OnFieldNameDoubleClick;
				return;
			case 4:
				((global::AcpUI.AcpTableTextBox)target).GotFocus += this.OnFieldNameDoubleClick;
				return;
			case 5:
				break;
			case 6:
				((global::AcpUI.AcpTableTextBox)target).GotFocus += this.OnFieldNameDoubleClick;
				return;
			case 7:
				((global::AcpUI.AcpTableTextBox)target).GotFocus += this.OnFieldNameDoubleClick;
				return;
			case 8:
				((global::AcpUI.AcpTableTextBox)target).GotFocus += this.OnFieldNameDoubleClick;
				return;
			case 9:
				((global::AcpUI.AcpTableTextBox)target).GotFocus += this.OnFieldNameDoubleClick;
				return;
			case 10:
				((global::AcpUI.AcpTableTextBox)target).GotFocus += this.OnFieldNameDoubleClick;
				return;
			case 11:
				((global::AcpUI.AcpTableTextBox)target).GotFocus += this.OnFieldNameDoubleClick;
				return;
			case 12:
				((global::AcpUI.AcpTableTextBox)target).GotFocus += this.OnFieldNameDoubleClick;
				return;
			case 13:
				((global::AcpUI.AcpTableViewOnlyCtrl)target).GotFocus += this.OnFieldNameDoubleClick;
				return;
			case 14:
				((global::AcpUI.AcpTableTextBox)target).GotFocus += this.OnFieldNameDoubleClick;
				return;
			case 15:
				((global::AcpUI.AcpTableTextBox)target).GotFocus += this.OnFieldNameDoubleClick;
				return;
			case 16:
				((global::AcpUI.AcpTableTextBox)target).GotFocus += this.OnFieldNameDoubleClick;
				return;
			case 17:
				((global::AcpUI.AcpTableTextBox)target).GotFocus += this.OnFieldNameDoubleClick;
				return;
			case 18:
				((global::AcpUI.AcpTableTextBox)target).GotFocus += this.OnFieldNameDoubleClick;
				return;
			case 19:
				((global::AcpUI.AcpTableTextBox)target).GotFocus += this.OnFieldNameDoubleClick;
				return;
			case 20:
				((global::AcpUI.AcpTableTextBox)target).GotFocus += this.OnFieldNameDoubleClick;
				return;
			case 21:
				((global::AcpUI.AcpTableTextBox)target).GotFocus += this.OnFieldNameDoubleClick;
				return;
			case 22:
				((global::AcpUI.AcpTableTextBox)target).GotFocus += this.OnFieldNameDoubleClick;
				return;
			case 23:
				((global::AcpUI.AcpTableTextBox)target).GotFocus += this.OnFieldNameDoubleClick;
				return;
			case 24:
				((global::AcpUI.AcpTableViewOnlyCtrl)target).GotFocus += this.OnFieldNameDoubleClick;
				return;
			case 25:
				((global::AcpUI.AcpTableTextBox)target).GotFocus += this.OnFieldNameDoubleClick;
				return;
			case 26:
				((global::AcpUI.AcpTableTextBox)target).GotFocus += this.OnFieldNameDoubleClick;
				return;
			case 27:
				((global::AcpUI.AcpTableViewOnlyCtrl)target).GotFocus += this.OnFieldNameDoubleClick;
				return;
			case 28:
				((global::AcpUI.AcpTableTextBox)target).GotFocus += this.OnFieldNameDoubleClick;
				return;
			case 29:
				((global::AcpUI.AcpTableTextBox)target).GotFocus += this.OnFieldNameDoubleClick;
				return;
			case 30:
				((global::AcpUI.AcpTableTextBox)target).GotFocus += this.OnFieldNameDoubleClick;
				return;
			case 31:
			{
				short num = (short)351986235;
				short num2 = num;
				num = (short)72868411;
				switch ((num2 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					break;
				default:
					num = (short)174850048;
					if (num != 0)
					{
					}
					((global::AcpUI.AcpTableTextBox)target).GotFocus += this.OnFieldNameDoubleClick;
					return;
				}
				break;
			}
			case 32:
				((global::AcpUI.AcpTableTextBox)target).GotFocus += this.OnFieldNameDoubleClick;
				return;
			case 33:
				((global::AcpUI.AcpTableComboBox)target).GotFocus += this.OnFieldNameDoubleClick;
				return;
			case 34:
				((global::AcpUI.AcpTableComboBox)target).GotFocus += this.OnFieldNameDoubleClick;
				return;
			case 35:
				((global::AcpUI.AcpTableComboBox)target).GotFocus += this.OnFieldNameDoubleClick;
				return;
			case 36:
				((global::AcpUI.AcpTableComboBox)target).GotFocus += this.OnFieldNameDoubleClick;
				return;
			case 37:
				((global::AcpUI.AcpTableComboBox)target).GotFocus += this.OnFieldNameDoubleClick;
				return;
			case 38:
				((global::AcpUI.AcpTableComboBox)target).GotFocus += this.OnFieldNameDoubleClick;
				return;
			case 39:
				((global::AcpUI.AcpTableComboBox)target).GotFocus += this.OnFieldNameDoubleClick;
				return;
			case 40:
				((global::AcpUI.AcpTableComboBox)target).GotFocus += this.OnFieldNameDoubleClick;
				return;
			case 41:
				((global::AcpUI.AcpTableComboBox)target).GotFocus += this.OnFieldNameDoubleClick;
				return;
			case 42:
				((global::AcpUI.AcpTableComboBox)target).GotFocus += this.OnFieldNameDoubleClick;
				return;
			case 43:
			{
				short num = (short)236519425;
				if (num != 0)
				{
				}
				((global::AcpUI.AcpTableViewOnlyCtrl)target).GotFocus += this.OnFieldNameDoubleClick;
				return;
			}
			case 44:
				((global::AcpUI.AcpTableTextBoxSpinner)target).GotFocus += this.OnFieldNameDoubleClick;
				return;
			default:
			{
				short num = (short)1650917376;
				short num3 = num;
				return;
			}
			}
			((global::AcpUI.AcpTableTextBox)target).GotFocus += this.OnFieldNameDoubleClick;
		}

		// Token: 0x0400121F RID: 4639
		private bool a;

		// Token: 0x04001220 RID: 4640
		internal global::AcpUI.Common.AcpThemeBase ThemeBaseObj;

		// Token: 0x04001221 RID: 4641
		internal global::System.Windows.Documents.Hyperlink HLinkGeneral;

		// Token: 0x04001222 RID: 4642
		internal global::System.Windows.Documents.Hyperlink HLinkAlertTones;

		// Token: 0x04001223 RID: 4643
		internal global::System.Windows.Documents.Hyperlink HLinkUserInformationAndPasswords;

		// Token: 0x04001224 RID: 4644
		internal global::System.Windows.Documents.Hyperlink HLinkFeatures;

		// Token: 0x04001225 RID: 4645
		internal global::System.Windows.Documents.Hyperlink HLinkDualRadio;

		// Token: 0x04001226 RID: 4646
		internal global::System.Windows.Documents.Hyperlink HLinkLocation;

		// Token: 0x04001227 RID: 4647
		internal global::System.Windows.Documents.Hyperlink HLinkDigitalAudioOptions;

		// Token: 0x04001228 RID: 4648
		internal global::System.Windows.Documents.Hyperlink HLinkTransmitPowerLevels;

		// Token: 0x04001229 RID: 4649
		internal global::System.Windows.Documents.Hyperlink HLinkTxPowerLevelsNewBandPlan;

		// Token: 0x0400122A RID: 4650
		internal global::System.Windows.Documents.Hyperlink HLinkTPSFireground;

		// Token: 0x0400122B RID: 4651
		internal global::System.Windows.Documents.Hyperlink HLinkTPS;

		// Token: 0x0400122C RID: 4652
		internal global::System.Windows.Documents.Hyperlink HLinkFireground;

		// Token: 0x0400122D RID: 4653
		internal global::System.Windows.Documents.Hyperlink HLinkRxFrequencySplit;

		// Token: 0x0400122E RID: 4654
		internal global::System.Windows.Documents.Hyperlink HLinkTxFrequencySplit;

		// Token: 0x0400122F RID: 4655
		internal global::System.Windows.Documents.Hyperlink HLinkFCCNarrowBandingFrequencySplit;

		// Token: 0x04001230 RID: 4656
		internal global::System.Windows.Documents.Hyperlink HLinkLightbarPattern;

		// Token: 0x04001231 RID: 4657
		internal global::System.Windows.Documents.Hyperlink HLinkGunLock;

		// Token: 0x04001232 RID: 4658
		internal global::System.Windows.Documents.Hyperlink HLinkBluetooth;

		// Token: 0x04001233 RID: 4659
		internal global::System.Windows.Documents.Hyperlink HLinkLTE;

		// Token: 0x04001234 RID: 4660
		internal global::System.Windows.Documents.Hyperlink HLinkDepot;

		// Token: 0x04001235 RID: 4661
		internal global::System.Windows.Documents.Hyperlink HLinkLabtool;

		// Token: 0x04001236 RID: 4662
		internal global::System.Windows.Documents.Hyperlink HLinkSensor;

		// Token: 0x04001237 RID: 4663
		internal global::System.Windows.Controls.StackPanel MyStackPanel;

		// Token: 0x04001238 RID: 4664
		internal global::AcpUI.AcpExpander ExpanderRadioWideGeneral;

		// Token: 0x04001239 RID: 4665
		internal global::AcpUI.AcpGroupBox GrpBoxExpanderRadioWideGeneralPseudo0;

		// Token: 0x0400123A RID: 4666
		internal global::AcpUI.AcpCustomViewCheckBox CVBtnRadWideGeneralLogDisp_A9756;

		// Token: 0x0400123B RID: 4667
		internal global::AcpUI.AcpLabel LblRadWideGeneralLogDisp_A9756;

		// Token: 0x0400123C RID: 4668
		internal global::AcpUI.AcpCheckBox RadWideGeneralLogDisp_A9756;

		// Token: 0x0400123D RID: 4669
		internal global::AcpUI.AcpRtdButton RTDBtnRadWideGeneralLogDisp_A9756;

		// Token: 0x0400123E RID: 4670
		internal global::AcpUI.AcpCopyButton CpyBtnRadWideGeneralLogDisp_A9756;

		// Token: 0x0400123F RID: 4671
		internal global::AcpUI.AcpCheckBox RadWideGeneralLogDisp_A9756Comp;

		// Token: 0x04001240 RID: 4672
		internal global::AcpUI.AcpCustomViewCheckBox CVBtnRadWideRecentCallListDeleteEnable;

		// Token: 0x04001241 RID: 4673
		internal global::AcpUI.AcpLabel LblRadWideRecentCallListDeleteEnable;

		// Token: 0x04001242 RID: 4674
		internal global::AcpUI.AcpCheckBox RadWideRecentCallListDeleteEnable;

		// Token: 0x04001243 RID: 4675
		internal global::AcpUI.AcpRtdButton RTDBtnRadWideRecentCallListDeleteEnable;

		// Token: 0x04001244 RID: 4676
		internal global::AcpUI.AcpCopyButton CpyBtnRadWideRecentCallListDeleteEnable;

		// Token: 0x04001245 RID: 4677
		internal global::AcpUI.AcpCheckBox RadWideRecentCallListDeleteEnableComp;

		// Token: 0x04001246 RID: 4678
		internal global::AcpUI.AcpCustomViewCheckBox CVBtnRadInfoGeneralMotorcycleRadio_A8546;

		// Token: 0x04001247 RID: 4679
		internal global::AcpUI.AcpLabel LblRadInfoGeneralMotorcycleRadio_A8546;

		// Token: 0x04001248 RID: 4680
		internal global::AcpUI.AcpLabel RadInfoGeneralMotorcycleRadio_A8546;

		// Token: 0x04001249 RID: 4681
		internal global::AcpUI.AcpRtdButton RTDBtnRadInfoGeneralMotorcycleRadio_A8546;

		// Token: 0x0400124A RID: 4682
		internal global::AcpUI.AcpCopyButton CpyBtnRadInfoGeneralMotorcycleRadio_A8546;

		// Token: 0x0400124B RID: 4683
		internal global::AcpUI.AcpLabel RadInfoGeneralMotorcycleRadio_A8546Comp;

		// Token: 0x0400124C RID: 4684
		internal global::AcpUI.AcpCustomViewCheckBox CVBtnRadWideGeneralTimeFormat_A9377;

		// Token: 0x0400124D RID: 4685
		internal global::AcpUI.AcpLabel LblRadWideGeneralTimeFormat_A9377;

		// Token: 0x0400124E RID: 4686
		internal global::AcpUI.AcpComboBox RadWideGeneralTimeFormat_A9377;

		// Token: 0x0400124F RID: 4687
		internal global::AcpUI.AcpRtdButton RTDBtnRadWideGeneralTimeFormat_A9377;

		// Token: 0x04001250 RID: 4688
		internal global::AcpUI.AcpCopyButton CpyBtnRadWideGeneralTimeFormat_A9377;

		// Token: 0x04001251 RID: 4689
		internal global::AcpUI.AcpLabel RadWideGeneralTimeFormat_A9377Comp;

		// Token: 0x04001252 RID: 4690
		internal global::AcpUI.AcpCustomViewCheckBox CVBtnRadWideGeneralDateFormat_A7802;

		// Token: 0x04001253 RID: 4691
		internal global::AcpUI.AcpLabel LblRadWideGeneralDateFormat_A7802;

		// Token: 0x04001254 RID: 4692
		internal global::AcpUI.AcpComboBox RadWideGeneralDateFormat_A7802;

		// Token: 0x04001255 RID: 4693
		internal global::AcpUI.AcpRtdButton RTDBtnRadWideGeneralDateFormat_A7802;

		// Token: 0x04001256 RID: 4694
		internal global::AcpUI.AcpCopyButton CpyBtnRadWideGeneralDateFormat_A7802;

		// Token: 0x04001257 RID: 4695
		internal global::AcpUI.AcpLabel RadWideGeneralDateFormat_A7802Comp;

		// Token: 0x04001258 RID: 4696
		internal global::AcpUI.AcpCustomViewCheckBox CVBtnRadWideAdvancedMaximumTxDeviation_A8480;

		// Token: 0x04001259 RID: 4697
		internal global::AcpUI.AcpLabel LblRadWideAdvancedMaximumTxDeviation_A8480;

		// Token: 0x0400125A RID: 4698
		internal global::AcpUI.AcpComboBox RadWideAdvancedMaximumTxDeviation_A8480;

		// Token: 0x0400125B RID: 4699
		internal global::AcpUI.AcpRtdButton RTDBtnRadWideAdvancedMaximumTxDeviation_A8480;

		// Token: 0x0400125C RID: 4700
		internal global::AcpUI.AcpCopyButton CpyBtnRadWideAdvancedMaximumTxDeviation_A8480;

		// Token: 0x0400125D RID: 4701
		internal global::AcpUI.AcpLabel RadWideAdvancedMaximumTxDeviation_A8480Comp;

		// Token: 0x0400125E RID: 4702
		internal global::AcpUI.AcpCustomViewCheckBox CVBtnRadWideAdvancedUltraNarrowIntermediateFreqFilter_A9592;

		// Token: 0x0400125F RID: 4703
		internal global::AcpUI.AcpLabel LblRadWideAdvancedUltraNarrowIntermediateFreqFilter_A9592;

		// Token: 0x04001260 RID: 4704
		internal global::AcpUI.AcpComboBox RadWideAdvancedUltraNarrowIntermediateFreqFilter_A9592;

		// Token: 0x04001261 RID: 4705
		internal global::AcpUI.AcpRtdButton RTDBtnRadWideAdvancedUltraNarrowIntermediateFreqFilter_A9592;

		// Token: 0x04001262 RID: 4706
		internal global::AcpUI.AcpCopyButton CpyBtnRadWideAdvancedUltraNarrowIntermediateFreqFilter_A9592;

		// Token: 0x04001263 RID: 4707
		internal global::AcpUI.AcpLabel RadWideAdvancedUltraNarrowIntermediateFreqFilter_A9592Comp;

		// Token: 0x04001264 RID: 4708
		internal global::AcpUI.AcpCustomViewCheckBox CVBtnRadWideGeneralASKRequired_A37152;

		// Token: 0x04001265 RID: 4709
		internal global::AcpUI.AcpLabel LblRadWideGeneralASKRequired_A37152;

		// Token: 0x04001266 RID: 4710
		internal global::AcpUI.AcpCheckBox RadWideGeneralASKRequired_A37152;

		// Token: 0x04001267 RID: 4711
		internal global::AcpUI.AcpRtdButton RTDBtnRadWideGeneralASKRequired_A37152;

		// Token: 0x04001268 RID: 4712
		internal global::AcpUI.AcpCopyButton CpyBtnRadWideGeneralASKRequired_A37152;

		// Token: 0x04001269 RID: 4713
		internal global::AcpUI.AcpCheckBox RadWideGeneralASKRequired_A37152Comp;

		// Token: 0x0400126A RID: 4714
		internal global::AcpUI.AcpCustomViewCheckBox CVBtnRadWideGeneralOwnerAdvancedKeyType_A38663;

		// Token: 0x0400126B RID: 4715
		internal global::AcpUI.AcpLabel LblRadWideGeneralOwnerAdvancedKeyType_A38663;

		// Token: 0x0400126C RID: 4716
		internal global::AcpUI.AcpComboBox RadWideGeneralOwnerAdvancedKeyType_A38663;

		// Token: 0x0400126D RID: 4717
		internal global::AcpUI.AcpRtdButton RTDBtnRadWideGeneralOwnerAdvancedKeyType_A38663;

		// Token: 0x0400126E RID: 4718
		internal global::AcpUI.AcpCopyButton CpyBtnRadWideGeneralOwnerAdvancedKeyType_A38663;

		// Token: 0x0400126F RID: 4719
		internal global::AcpUI.AcpLabel RadWideGeneralOwnerAdvancedKeyType_A38663Comp;

		// Token: 0x04001270 RID: 4720
		internal global::AcpUI.AcpCustomViewCheckBox CVBtnRadWideGeneralOwnerSystemID_A37153;

		// Token: 0x04001271 RID: 4721
		internal global::AcpUI.AcpLabel LblRadWideGeneralOwnerSystemID_A37153;

		// Token: 0x04001272 RID: 4722
		internal global::AcpUI.AcpTextBoxSpinnerDecHex RadWideGeneralOwnerSystemID_A37153;

		// Token: 0x04001273 RID: 4723
		internal global::AcpUI.AcpRtdButton RTDBtnRadWideGeneralOwnerSystemID_A37153;

		// Token: 0x04001274 RID: 4724
		internal global::AcpUI.AcpCopyButton CpyBtnRadWideGeneralOwnerSystemID_A37153;

		// Token: 0x04001275 RID: 4725
		internal global::AcpUI.AcpTextBoxDecHex RadWideGeneralOwnerSystemID_A37153Comp;

		// Token: 0x04001276 RID: 4726
		internal global::AcpUI.AcpCustomViewCheckBox CVBtnRadWideGeneralOwnerWACNID_A38656;

		// Token: 0x04001277 RID: 4727
		internal global::AcpUI.AcpLabel LblRadWideGeneralOwnerWACNID_A38656;

		// Token: 0x04001278 RID: 4728
		internal global::AcpUI.AcpTextBoxSpinnerDecHex RadWideGeneralOwnerWACNID_A38656;

		// Token: 0x04001279 RID: 4729
		internal global::AcpUI.AcpRtdButton RTDBtnRadWideGeneralOwnerWACNID_A38656;

		// Token: 0x0400127A RID: 4730
		internal global::AcpUI.AcpCopyButton CpyBtnRadWideGeneralOwnerWACNID_A38656;

		// Token: 0x0400127B RID: 4731
		internal global::AcpUI.AcpTextBoxDecHex RadWideGeneralOwnerWACNID_A38656Comp;

		// Token: 0x0400127C RID: 4732
		internal global::AcpUI.AcpCustomViewCheckBox CVBtnRadWideGeneralPskId_44840;

		// Token: 0x0400127D RID: 4733
		internal global::AcpUI.AcpLabel LblRadWideGeneralPskId_44840;

		// Token: 0x0400127E RID: 4734
		internal global::AcpUI.AcpTextBox RadWideGeneralPskId_44840;

		// Token: 0x0400127F RID: 4735
		internal global::AcpUI.AcpRtdButton RTDBtnRadWideGeneralPskId_44840;

		// Token: 0x04001280 RID: 4736
		internal global::AcpUI.AcpCopyButton CpyBtnRadWideGeneralPskId_44840;

		// Token: 0x04001281 RID: 4737
		internal global::AcpUI.AcpLabel RadWideGeneralPskId_44840Comp;

		// Token: 0x04001282 RID: 4738
		internal global::AcpUI.AcpCustomViewCheckBox CVBtnRadWideGeneralTlsPsk_44841;

		// Token: 0x04001283 RID: 4739
		internal global::AcpUI.AcpLabel LblRadWideGeneralTlsPsk_44841;

		// Token: 0x04001284 RID: 4740
		internal global::AcpUI.AcpTextBox RadWideGeneralTlsPsk_44841;

		// Token: 0x04001285 RID: 4741
		internal global::AcpUI.AcpRtdButton RTDBtnRadWideGeneralTlsPsk_44841;

		// Token: 0x04001286 RID: 4742
		internal global::AcpUI.AcpCopyButton CpyBtnRadWideGeneralTlsPsk_44841;

		// Token: 0x04001287 RID: 4743
		internal global::AcpUI.AcpLabel RadWideGeneralTlsPsk_44841Comp;

		// Token: 0x04001288 RID: 4744
		internal global::AcpUI.AcpCustomViewCheckBox CVRadWideGeneralTlsPskPort_44842;

		// Token: 0x04001289 RID: 4745
		internal global::AcpUI.AcpLabel LblRadWideGeneralTlsPskPort_44842;

		// Token: 0x0400128A RID: 4746
		internal global::AcpUI.AcpTextBoxSpinner RadWideGeneralTlsPskPort_44842;

		// Token: 0x0400128B RID: 4747
		internal global::AcpUI.AcpRtdButton RTDBtnRadWideGeneralTlsPskPort_44842;

		// Token: 0x0400128C RID: 4748
		internal global::AcpUI.AcpCopyButton CpyBtnRadWideGeneralTlsPskPort_44842;

		// Token: 0x0400128D RID: 4749
		internal global::AcpUI.AcpLabel RadWideGeneralTlsPskPort_44842Comp;

		// Token: 0x0400128E RID: 4750
		internal global::AcpUI.AcpCustomViewCheckBox CVBtnRadWideGeneralDnsSdAddress_44843;

		// Token: 0x0400128F RID: 4751
		internal global::AcpUI.AcpLabel LblRadWideGeneralDnsSdAddress_44843;

		// Token: 0x04001290 RID: 4752
		internal global::AcpUI.AcpTextBox RadWideGeneralDnsSdAddress_44843;

		// Token: 0x04001291 RID: 4753
		internal global::AcpUI.AcpRtdButton RTDBtnRadWideGeneralDnsSdAddress_44843;

		// Token: 0x04001292 RID: 4754
		internal global::AcpUI.AcpCopyButton CpyBtnRadWideGeneralDnsSdAddress_44843;

		// Token: 0x04001293 RID: 4755
		internal global::AcpUI.AcpLabel RadWideGeneralDnsSdAddress_44843Comp;

		// Token: 0x04001294 RID: 4756
		internal global::AcpUI.AcpCustomViewCheckBox CVRadWideGeneralDnsSdPort_44844;

		// Token: 0x04001295 RID: 4757
		internal global::AcpUI.AcpLabel LblRadWideGeneralDnsSdPort_44844;

		// Token: 0x04001296 RID: 4758
		internal global::AcpUI.AcpTextBoxSpinner RadWideGeneralDnsSdPort_44844;

		// Token: 0x04001297 RID: 4759
		internal global::AcpUI.AcpRtdButton RTDBtnRadWideGeneralDnsSdPort_44844;

		// Token: 0x04001298 RID: 4760
		internal global::AcpUI.AcpCopyButton CpyBtnRadWideGeneralDnsSdPort_44844;

		// Token: 0x04001299 RID: 4761
		internal global::AcpUI.AcpLabel RadWideGeneralDnsSdPort_44844Comp;

		// Token: 0x0400129A RID: 4762
		internal global::AcpUI.AcpCustomViewCheckBox CVBtnRadWideGeneralProgrammingPath_44845;

		// Token: 0x0400129B RID: 4763
		internal global::AcpUI.AcpLabel LblRadWideGeneralProgrammingPath_44845;

		// Token: 0x0400129C RID: 4764
		internal global::AcpUI.AcpComboBox RadWideGeneralProgrammingPath_44845;

		// Token: 0x0400129D RID: 4765
		internal global::AcpUI.AcpRtdButton RTDBtnRadWideGeneralProgrammingPath_44845;

		// Token: 0x0400129E RID: 4766
		internal global::AcpUI.AcpCopyButton CpyBtnRadWideGeneralProgrammingPath_44845;

		// Token: 0x0400129F RID: 4767
		internal global::AcpUI.AcpLabel RadWideGeneralProgrammingPath_44845Comp;

		// Token: 0x040012A0 RID: 4768
		internal global::AcpUI.AcpExpander ExpanderRadioWideAlertTones;

		// Token: 0x040012A1 RID: 4769
		internal global::AcpUI.AcpGroupBox GrpBoxExpanderRadioWideAlertTonesPseudo0;

		// Token: 0x040012A2 RID: 4770
		internal global::AcpUI.AcpCustomViewCheckBox CVBtnRadProfAlertTonesAlertTones_A7428;

		// Token: 0x040012A3 RID: 4771
		internal global::AcpUI.AcpLabel LblRadProfAlertTonesAlertTones_A7428;

		// Token: 0x040012A4 RID: 4772
		internal global::AcpUI.AcpCheckBox RadProfAlertTonesAlertTones_A7428;

		// Token: 0x040012A5 RID: 4773
		internal global::AcpUI.AcpRtdButton RTDBtnRadProfAlertTonesAlertTones_A7428;

		// Token: 0x040012A6 RID: 4774
		internal global::AcpUI.AcpCopyButton CpyBtnRadProfAlertTonesAlertTones_A7428;

		// Token: 0x040012A7 RID: 4775
		internal global::AcpUI.AcpCheckBox RadProfAlertTonesAlertTones_A7428Comp;

		// Token: 0x040012A8 RID: 4776
		internal global::AcpUI.AcpCustomViewCheckBox CVBtnRadWideAlertTonesVolumeAdjustToneOffset_A9656;

		// Token: 0x040012A9 RID: 4777
		internal global::AcpUI.AcpLabel LblRadWideAlertTonesVolumeAdjustToneOffset_A9656;

		// Token: 0x040012AA RID: 4778
		internal global::AcpUI.AcpCheckBox RadWideAlertTonesVolumeAdjustToneOffset_A9656;

		// Token: 0x040012AB RID: 4779
		internal global::AcpUI.AcpRtdButton RTDBtnRadWideAlertTonesVolumeAdjustToneOffset_A9656;

		// Token: 0x040012AC RID: 4780
		internal global::AcpUI.AcpCopyButton CpyBtnRadWideAlertTonesVolumeAdjustToneOffset_A9656;

		// Token: 0x040012AD RID: 4781
		internal global::AcpUI.AcpCheckBox RadWideAlertTonesVolumeAdjustToneOffset_A9656Comp;

		// Token: 0x040012AE RID: 4782
		internal global::AcpUI.AcpCustomViewCheckBox CVBtnRadWideAlertTonesVolumeAdjustToneDisable;

		// Token: 0x040012AF RID: 4783
		internal global::AcpUI.AcpLabel LblRadWideAlertTonesVolumeAdjustToneDisable;

		// Token: 0x040012B0 RID: 4784
		internal global::AcpUI.AcpCheckBox RadWideAlertTonesVolumeAdjustToneDisable;

		// Token: 0x040012B1 RID: 4785
		internal global::AcpUI.AcpRtdButton RTDBtnRadWideAlertTonesVolumeAdjustToneDisable;

		// Token: 0x040012B2 RID: 4786
		internal global::AcpUI.AcpCopyButton CpyBtnRadWideAlertTonesVolumeAdjustToneDisable;

		// Token: 0x040012B3 RID: 4787
		internal global::AcpUI.AcpCheckBox RadWideAlertTonesVolumeAdjustToneDisableComp;

		// Token: 0x040012B4 RID: 4788
		internal global::AcpUI.AcpCustomViewCheckBox CVBtnRadProfAlertTonesPowerUpSelfTestAlertTone_A8718;

		// Token: 0x040012B5 RID: 4789
		internal global::AcpUI.AcpLabel LblRadProfAlertTonesPowerUpSelfTestAlertTone_A8718;

		// Token: 0x040012B6 RID: 4790
		internal global::AcpUI.AcpCheckBox RadProfAlertTonesPowerUpSelfTestAlertTone_A8718;

		// Token: 0x040012B7 RID: 4791
		internal global::AcpUI.AcpRtdButton RTDBtnRadProfAlertTonesPowerUpSelfTestAlertTone_A8718;

		// Token: 0x040012B8 RID: 4792
		internal global::AcpUI.AcpCopyButton CpyBtnRadProfAlertTonesPowerUpSelfTestAlertTone_A8718;

		// Token: 0x040012B9 RID: 4793
		internal global::AcpUI.AcpCheckBox RadProfAlertTonesPowerUpSelfTestAlertTone_A8718Comp;

		// Token: 0x040012BA RID: 4794
		internal global::AcpUI.AcpCustomViewCheckBox CVBtnRadWideAlertTonesScanAlertToneEnable_A19555;

		// Token: 0x040012BB RID: 4795
		internal global::AcpUI.AcpLabel LblRadWideAlertTonesScanAlertToneEnable_A19555;

		// Token: 0x040012BC RID: 4796
		internal global::AcpUI.AcpCheckBox RadWideAlertTonesScanAlertToneEnable_A19555;

		// Token: 0x040012BD RID: 4797
		internal global::AcpUI.AcpRtdButton RTDBtnRadWideAlertTonesScanAlertToneEnable_A19555;

		// Token: 0x040012BE RID: 4798
		internal global::AcpUI.AcpCopyButton CpyBtnRadWideAlertTonesScanAlertToneEnable_A19555;

		// Token: 0x040012BF RID: 4799
		internal global::AcpUI.AcpCheckBox RadWideAlertTonesScanAlertToneEnable_A19555Comp;

		// Token: 0x040012C0 RID: 4800
		internal global::AcpUI.AcpCustomViewCheckBox CVBtnRadWideAlertTonesZeroLevelAudioMute_A9689;

		// Token: 0x040012C1 RID: 4801
		internal global::AcpUI.AcpLabel LblRadWideAlertTonesZeroLevelAudioMute_A9689;

		// Token: 0x040012C2 RID: 4802
		internal global::AcpUI.AcpCheckBox RadWideAlertTonesZeroLevelAudioMute_A9689;

		// Token: 0x040012C3 RID: 4803
		internal global::AcpUI.AcpRtdButton RTDBtnRadWideAlertTonesZeroLevelAudioMute_A9689;

		// Token: 0x040012C4 RID: 4804
		internal global::AcpUI.AcpCopyButton CpyBtnRadWideAlertTonesZeroLevelAudioMute_A9689;

		// Token: 0x040012C5 RID: 4805
		internal global::AcpUI.AcpCheckBox RadWideAlertTonesZeroLevelAudioMute_A9689Comp;

		// Token: 0x040012C6 RID: 4806
		internal global::AcpUI.AcpCustomViewCheckBox CVBtnRadProfAlertTonesCallAlertToneAutoReset_A7596;

		// Token: 0x040012C7 RID: 4807
		internal global::AcpUI.AcpLabel LblRadProfAlertTonesCallAlertToneAutoReset_A7596;

		// Token: 0x040012C8 RID: 4808
		internal global::AcpUI.AcpCheckBox RadProfAlertTonesCallAlertToneAutoReset_A7596;

		// Token: 0x040012C9 RID: 4809
		internal global::AcpUI.AcpRtdButton RTDBtnRadProfAlertTonesCallAlertToneAutoReset_A7596;

		// Token: 0x040012CA RID: 4810
		internal global::AcpUI.AcpCopyButton CpyBtnRadProfAlertTonesCallAlertToneAutoReset_A7596;

		// Token: 0x040012CB RID: 4811
		internal global::AcpUI.AcpCheckBox RadProfAlertTonesCallAlertToneAutoReset_A7596Comp;

		// Token: 0x040012CC RID: 4812
		internal global::AcpUI.AcpCustomViewCheckBox CVBtnRadProfAlertTonesRotaryAlert_A8983;

		// Token: 0x040012CD RID: 4813
		internal global::AcpUI.AcpLabel LblRadProfAlertTonesRotaryAlert_A8983;

		// Token: 0x040012CE RID: 4814
		internal global::AcpUI.AcpComboBox RadProfAlertTonesRotaryAlert_A8983;

		// Token: 0x040012CF RID: 4815
		internal global::AcpUI.AcpRtdButton RTDBtnRadProfAlertTonesRotaryAlert_A8983;

		// Token: 0x040012D0 RID: 4816
		internal global::AcpUI.AcpCopyButton CpyBtnRadProfAlertTonesRotaryAlert_A8983;

		// Token: 0x040012D1 RID: 4817
		internal global::AcpUI.AcpLabel RadProfAlertTonesRotaryAlert_A8983Comp;

		// Token: 0x040012D2 RID: 4818
		internal global::AcpUI.AcpCustomViewCheckBox CVBtnRadProfAlertTonesEnhancedMuteTonesOperation_A42150;

		// Token: 0x040012D3 RID: 4819
		internal global::AcpUI.AcpLabel LblRadProfAlertTonesEnhancedMuteTonesOperation_A42150;

		// Token: 0x040012D4 RID: 4820
		internal global::AcpUI.AcpComboBox RadProfAlertTonesEnhancedMuteTonesOperation_A42150;

		// Token: 0x040012D5 RID: 4821
		internal global::AcpUI.AcpRtdButton RTDBtnRadProfAlertTonesEnhancedMuteTonesOperation_A42150;

		// Token: 0x040012D6 RID: 4822
		internal global::AcpUI.AcpCopyButton CpyBtnRadProfAlertTonesEnhancedMuteTonesOperation_A42150;

		// Token: 0x040012D7 RID: 4823
		internal global::AcpUI.AcpLabel RadProfAlertTonesEnhancedMuteTonesOperation_A42150Comp;

		// Token: 0x040012D8 RID: 4824
		internal global::AcpUI.AcpCustomViewCheckBox CVBtnRadProfAlertTonesMuteTonesOperation_A8562;

		// Token: 0x040012D9 RID: 4825
		internal global::AcpUI.AcpLabel LblRadProfAlertTonesMuteTonesOperation_A8562;

		// Token: 0x040012DA RID: 4826
		internal global::AcpUI.AcpComboBox RadProfAlertTonesMuteTonesOperation_A8562;

		// Token: 0x040012DB RID: 4827
		internal global::AcpUI.AcpRtdButton RTDBtnRadProfAlertTonesMuteTonesOperation_A8562;

		// Token: 0x040012DC RID: 4828
		internal global::AcpUI.AcpCopyButton CpyBtnRadProfAlertTonesMuteTonesOperation_A8562;

		// Token: 0x040012DD RID: 4829
		internal global::AcpUI.AcpLabel RadProfAlertTonesMuteTonesOperation_A8562Comp;

		// Token: 0x040012DE RID: 4830
		internal global::AcpUI.AcpCustomViewCheckBox CVBtnRadProfAlertTonesNewMuteTonesOperation_A42149;

		// Token: 0x040012DF RID: 4831
		internal global::AcpUI.AcpLabel LblRadProfAlertTonesNewMuteTonesOperation_A42149;

		// Token: 0x040012E0 RID: 4832
		internal global::AcpUI.AcpComboBox RadProfAlertTonesNewMuteTonesOperation_A42149;

		// Token: 0x040012E1 RID: 4833
		internal global::AcpUI.AcpRtdButton RTDBtnRadProfAlertTonesNewMuteTonesOperation_A42149;

		// Token: 0x040012E2 RID: 4834
		internal global::AcpUI.AcpCopyButton CpyBtnRadProfAlertTonesNewMuteTonesOperation_A42149;

		// Token: 0x040012E3 RID: 4835
		internal global::AcpUI.AcpLabel RadProfAlertTonesNewMuteTonesOperation_A42149Comp;

		// Token: 0x040012E4 RID: 4836
		internal global::AcpUI.AcpCustomViewCheckBox CVBtnRadWideOutOfRangeToneSelection_A42450;

		// Token: 0x040012E5 RID: 4837
		internal global::AcpUI.AcpLabel LblRadWideOutOfRangeToneSelection_A42450;

		// Token: 0x040012E6 RID: 4838
		internal global::AcpUI.AcpComboBox RadWideOutOfRangeToneSelection_A42450;

		// Token: 0x040012E7 RID: 4839
		internal global::AcpUI.AcpRtdButton RTDBtnRadWideOutOfRangeToneSelection_A42450;

		// Token: 0x040012E8 RID: 4840
		internal global::AcpUI.AcpCopyButton CpyBtnRadWideOutOfRangeToneSelection_A42450;

		// Token: 0x040012E9 RID: 4841
		internal global::AcpUI.AcpLabel RadWideOutOfRangeToneSelection_A42450Comp;

		// Token: 0x040012EA RID: 4842
		internal global::AcpUI.AcpCustomViewCheckBox CVBtnRadWideTalkProhibitToneSelection_A42416;

		// Token: 0x040012EB RID: 4843
		internal global::AcpUI.AcpLabel LblRadWideTalkProhibitToneSelection_A42416;

		// Token: 0x040012EC RID: 4844
		internal global::AcpUI.AcpComboBox RadWideTalkProhibitToneSelection_A42416;

		// Token: 0x040012ED RID: 4845
		internal global::AcpUI.AcpRtdButton RTDBtnRadWideTalkProhibitToneSelection_A42416;

		// Token: 0x040012EE RID: 4846
		internal global::AcpUI.AcpCopyButton CpyBtnRadWideTalkProhibitToneSelection_A42416;

		// Token: 0x040012EF RID: 4847
		internal global::AcpUI.AcpLabel RadWideTalkProhibitToneSelection_A42416Comp;

		// Token: 0x040012F0 RID: 4848
		internal global::AcpUI.AcpCustomViewCheckBox CVBtnRadioWidePTTWarningTone;

		// Token: 0x040012F1 RID: 4849
		internal global::AcpUI.AcpLabel LblRadioWidePTTWarningTone;

		// Token: 0x040012F2 RID: 4850
		internal global::AcpUI.AcpComboBox RadioWidePTTWarningTone;

		// Token: 0x040012F3 RID: 4851
		internal global::AcpUI.AcpRtdButton RTDBtnRadioWidePTTWarningTone;

		// Token: 0x040012F4 RID: 4852
		internal global::AcpUI.AcpCopyButton CpyBtnRadioWidePTTWarningTone;

		// Token: 0x040012F5 RID: 4853
		internal global::AcpUI.AcpLabel RadioWidePTTWarningToneComp;

		// Token: 0x040012F6 RID: 4854
		internal global::AcpUI.AcpCustomViewCheckBox CVBtnRadWideAlertTonesRSMVolumeSetTone;

		// Token: 0x040012F7 RID: 4855
		internal global::AcpUI.AcpLabel LblRadWideAlertTonesRSMVolumeSetTone;

		// Token: 0x040012F8 RID: 4856
		internal global::AcpUI.AcpComboBox RadWideAlertTonesRSMVolumeSetTone;

		// Token: 0x040012F9 RID: 4857
		internal global::AcpUI.AcpRtdButton RTDBtnRadWideAlertTonesRSMVolumeSetTone;

		// Token: 0x040012FA RID: 4858
		internal global::AcpUI.AcpCopyButton CpyBtnRadWideAlertTonesRSMVolumeSetTone;

		// Token: 0x040012FB RID: 4859
		internal global::AcpUI.AcpLabel RadWideAlertTonesRSMVolumeSetToneComp;

		// Token: 0x040012FC RID: 4860
		internal global::AcpUI.AcpGroupBox GrpBoxExpanderRadioWideAlertTonesLowBattery;

		// Token: 0x040012FD RID: 4861
		internal global::AcpUI.AcpCustomViewCheckBox CVBtnRadProfAlertTonesLED_A8428;

		// Token: 0x040012FE RID: 4862
		internal global::AcpUI.AcpLabel LblRadProfAlertTonesLED_A8428;

		// Token: 0x040012FF RID: 4863
		internal global::AcpUI.AcpCheckBox RadProfAlertTonesLED_A8428;

		// Token: 0x04001300 RID: 4864
		internal global::AcpUI.AcpRtdButton RTDBtnRadProfAlertTonesLED_A8428;

		// Token: 0x04001301 RID: 4865
		internal global::AcpUI.AcpCopyButton CpyBtnRadProfAlertTonesLED_A8428;

		// Token: 0x04001302 RID: 4866
		internal global::AcpUI.AcpCheckBox RadProfAlertTonesLED_A8428Comp;

		// Token: 0x04001303 RID: 4867
		internal global::AcpUI.AcpCustomViewCheckBox CVBtnRadWideAlertTonesTxChirp_A9523;

		// Token: 0x04001304 RID: 4868
		internal global::AcpUI.AcpLabel LblRadWideAlertTonesTxChirp_A9523;

		// Token: 0x04001305 RID: 4869
		internal global::AcpUI.AcpCheckBox RadWideAlertTonesTxChirp_A9523;

		// Token: 0x04001306 RID: 4870
		internal global::AcpUI.AcpRtdButton RTDBtnRadWideAlertTonesTxChirp_A9523;

		// Token: 0x04001307 RID: 4871
		internal global::AcpUI.AcpCopyButton CpyBtnRadWideAlertTonesTxChirp_A9523;

		// Token: 0x04001308 RID: 4872
		internal global::AcpUI.AcpCheckBox RadWideAlertTonesTxChirp_A9523Comp;

		// Token: 0x04001309 RID: 4873
		internal global::AcpUI.AcpCustomViewCheckBox CVBtnRadProfAlertTonesStandbyChirpsec_A9179;

		// Token: 0x0400130A RID: 4874
		internal global::AcpUI.AcpLabel LblRadProfAlertTonesStandbyChirpsec_A9179;

		// Token: 0x0400130B RID: 4875
		internal global::AcpUI.AcpTextBoxSpinner RadProfAlertTonesStandbyChirpsec_A9179;

		// Token: 0x0400130C RID: 4876
		internal global::AcpUI.AcpRtdButton RTDBtnRadProfAlertTonesStandbyChirpsec_A9179;

		// Token: 0x0400130D RID: 4877
		internal global::AcpUI.AcpCopyButton CpyBtnRadProfAlertTonesStandbyChirpsec_A9179;

		// Token: 0x0400130E RID: 4878
		internal global::AcpUI.AcpLabel RadProfAlertTonesStandbyChirpsec_A9179Comp;

		// Token: 0x0400130F RID: 4879
		internal global::AcpUI.AcpGroupBox GrpBoxExpanderRadioWideAlertTonesPseudo1;

		// Token: 0x04001310 RID: 4880
		internal global::AcpUI.AcpCustomViewCheckBox CVBtnRadWideAdvancedSmartLowBatteryAlert_A9165;

		// Token: 0x04001311 RID: 4881
		internal global::AcpUI.AcpLabel LblRadWideAdvancedSmartLowBatteryAlert_A9165;

		// Token: 0x04001312 RID: 4882
		internal global::AcpUI.AcpComboBox RadWideAdvancedSmartLowBatteryAlert_A9165;

		// Token: 0x04001313 RID: 4883
		internal global::AcpUI.AcpRtdButton RTDBtnRadWideAdvancedSmartLowBatteryAlert_A9165;

		// Token: 0x04001314 RID: 4884
		internal global::AcpUI.AcpCopyButton CpyBtnRadWideAdvancedSmartLowBatteryAlert_A9165;

		// Token: 0x04001315 RID: 4885
		internal global::AcpUI.AcpLabel RadWideAdvancedSmartLowBatteryAlert_A9165Comp;

		// Token: 0x04001316 RID: 4886
		internal global::AcpUI.AcpExpander ExpanderRadioWideUserInformationAndPasswords;

		// Token: 0x04001317 RID: 4887
		internal global::AcpUI.AcpGroupBox GrpBoxExpanderRadioWideUserInformationAndPasswordsUserInformation;

		// Token: 0x04001318 RID: 4888
		internal global::AcpUI.AcpCustomViewCheckBox CVBtnRadWideUserInformationandPasswordsSoftIDUsernameDisplayTextSize_A23453;

		// Token: 0x04001319 RID: 4889
		internal global::AcpUI.AcpLabel LblRadWideUserInformationandPasswordsSoftIDUsernameDisplayTextSize_A23453;

		// Token: 0x0400131A RID: 4890
		internal global::AcpUI.AcpTextBoxSpinner RadWideUserInformationandPasswordsSoftIDUsernameDisplayTextSize_A23453;

		// Token: 0x0400131B RID: 4891
		internal global::AcpUI.AcpRtdButton RTDBtnRadWideUserInformationandPasswordsSoftIDUsernameDisplayTextSize_A23453;

		// Token: 0x0400131C RID: 4892
		internal global::AcpUI.AcpCopyButton CpyBtnRadWideUserInformationandPasswordsSoftIDUsernameDisplayTextSize_A23453;

		// Token: 0x0400131D RID: 4893
		internal global::AcpUI.AcpLabel RadWideUserInformationandPasswordsSoftIDUsernameDisplayTextSize_A23453Comp;

		// Token: 0x0400131E RID: 4894
		internal global::AcpUI.AcpCustomViewCheckBox CVBtnRadWideUserInformationandPasswordsSoftIDUsername_A9169;

		// Token: 0x0400131F RID: 4895
		internal global::AcpUI.AcpLabel LblRadWideUserInformationandPasswordsSoftIDUsername_A9169;

		// Token: 0x04001320 RID: 4896
		internal global::AcpUI.AcpTextBox RadWideUserInformationandPasswordsSoftIDUsername_A9169;

		// Token: 0x04001321 RID: 4897
		internal global::AcpUI.AcpRtdButton RTDBtnRadWideUserInformationandPasswordsSoftIDUsername_A9169;

		// Token: 0x04001322 RID: 4898
		internal global::AcpUI.AcpCopyButton CpyBtnRadWideUserInformationandPasswordsSoftIDUsername_A9169;

		// Token: 0x04001323 RID: 4899
		internal global::AcpUI.AcpLabel RadWideUserInformationandPasswordsSoftIDUsername_A9169Comp;

		// Token: 0x04001324 RID: 4900
		internal global::AcpUI.AcpCustomViewCheckBox CVBtnRadWideUserInformationandPINPassword_41303;

		// Token: 0x04001325 RID: 4901
		internal global::AcpUI.AcpLabel LblRadWideUserInformationandPINPassword_41303;

		// Token: 0x04001326 RID: 4902
		internal global::AcpUI.AcpPasswordEyeBox RadWideUserInformationandPINPassword_41303;

		// Token: 0x04001327 RID: 4903
		internal global::AcpUI.AcpRtdButton RTDBtnRadWideUserInformationandPINPassword_41303;

		// Token: 0x04001328 RID: 4904
		internal global::AcpUI.AcpCopyButton CpyBtnRadWideUserInformationandPINPassword_41303;

		// Token: 0x04001329 RID: 4905
		internal global::AcpUI.AcpLabel RadWideUserInformationandPINPassword_41303Comp;

		// Token: 0x0400132A RID: 4906
		internal global::AcpUI.AcpCustomViewCheckBox CVBtnRadWideUserInformationandPasswordsPIN_A8705;

		// Token: 0x0400132B RID: 4907
		internal global::AcpUI.AcpLabel LblRadWideUserInformationandPasswordsPIN_A8705;

		// Token: 0x0400132C RID: 4908
		internal global::AcpUI.AcpTextBox RadWideUserInformationandPasswordsPIN_A8705;

		// Token: 0x0400132D RID: 4909
		internal global::AcpUI.AcpRtdButton RTDBtnRadWideUserInformationandPasswordsPIN_A8705;

		// Token: 0x0400132E RID: 4910
		internal global::AcpUI.AcpCopyButton CpyBtnRadWideUserInformationandPasswordsPIN_A8705;

		// Token: 0x0400132F RID: 4911
		internal global::AcpUI.AcpLabel RadWideUserInformationandPasswordsPIN_A8705Comp;

		// Token: 0x04001330 RID: 4912
		internal global::AcpUI.AcpCustomViewCheckBox CVBtnRadWideUserInformationandPINPasswordPart2_41304;

		// Token: 0x04001331 RID: 4913
		internal global::AcpUI.AcpLabel LblRadWideUserInformationandPINPasswordPart2_41304;

		// Token: 0x04001332 RID: 4914
		internal global::AcpUI.AcpTextBox RadWideUserInformationandPINPasswordPart2_41304;

		// Token: 0x04001333 RID: 4915
		internal global::AcpUI.AcpRtdButton RTDBtnRadWideUserInformationandPINPasswordPart2_41304;

		// Token: 0x04001334 RID: 4916
		internal global::AcpUI.AcpCopyButton CpyBtnRadWideUserInformationandPINPasswordPart2_41304;

		// Token: 0x04001335 RID: 4917
		internal global::AcpUI.AcpLabel RadWideUserInformationandPINPasswordPart2_41304Comp;

		// Token: 0x04001336 RID: 4918
		internal global::AcpUI.AcpCustomViewCheckBox CVBtnRadWideUserInformationandUserLoginUnitIDEnable_41305;

		// Token: 0x04001337 RID: 4919
		internal global::AcpUI.AcpLabel LblRadWideUserInformationandUserLoginUnitIDEnable_41305;

		// Token: 0x04001338 RID: 4920
		internal global::AcpUI.AcpCheckBox RadWideUserInformationandUserLoginUnitIDEnable_41305;

		// Token: 0x04001339 RID: 4921
		internal global::AcpUI.AcpRtdButton RTDBtnRadWideUserInformationandUserLoginUnitIDEnable_41305;

		// Token: 0x0400133A RID: 4922
		internal global::AcpUI.AcpCopyButton CpyBtnRadWideUserInformationandUserLoginUnitIDEnable_41305;

		// Token: 0x0400133B RID: 4923
		internal global::AcpUI.AcpCheckBox RadWideUserInformationandUserLoginUnitIDEnable_41305Comp;

		// Token: 0x0400133C RID: 4924
		internal global::AcpUI.AcpCustomViewCheckBox CVBtnRadWideUserInformationandUserLoginUnitIDTextSize_41309;

		// Token: 0x0400133D RID: 4925
		internal global::AcpUI.AcpLabel LblRadWideUserInformationandUserLoginUnitIDTextSize_41309;

		// Token: 0x0400133E RID: 4926
		internal global::AcpUI.AcpLabel RadWideUserInformationandUserLoginUnitIDTextSize_41309;

		// Token: 0x0400133F RID: 4927
		internal global::AcpUI.AcpRtdButton RTDBtnRadWideUserInformationandUserLoginUnitIDTextSize_41309;

		// Token: 0x04001340 RID: 4928
		internal global::AcpUI.AcpCopyButton CpyBtnRadWideUserInformationandUserLoginUnitIDTextSize_41309;

		// Token: 0x04001341 RID: 4929
		internal global::AcpUI.AcpLabel RadWideUserInformationandUserLoginUnitIDTextSize_41309Comp;

		// Token: 0x04001342 RID: 4930
		internal global::AcpUI.AcpCustomViewCheckBox CVBtnRadWideUserInformationandUserLoginUnitID_41306;

		// Token: 0x04001343 RID: 4931
		internal global::AcpUI.AcpLabel LblRadWideUserInformationandUserLoginUnitID_41306;

		// Token: 0x04001344 RID: 4932
		internal global::AcpUI.AcpTextBox RadWideUserInformationandUserLoginUnitID_41306;

		// Token: 0x04001345 RID: 4933
		internal global::AcpUI.AcpRtdButton RTDBtnRadWideUserInformationandUserLoginUnitID_41306;

		// Token: 0x04001346 RID: 4934
		internal global::AcpUI.AcpCopyButton CpyBtnRadWideUserInformationandUserLoginUnitID_41306;

		// Token: 0x04001347 RID: 4935
		internal global::AcpUI.AcpLabel RadWideUserInformationandUserLoginUnitID_41306Comp;

		// Token: 0x04001348 RID: 4936
		internal global::AcpUI.AcpCustomViewCheckBox CVBtnRadWideUserInformationandPasswordsRadioAliasEnable_A8830;

		// Token: 0x04001349 RID: 4937
		internal global::AcpUI.AcpLabel LblRadWideUserInformationandPasswordsRadioAliasEnable_A8830;

		// Token: 0x0400134A RID: 4938
		internal global::AcpUI.AcpCheckBox RadWideUserInformationandPasswordsRadioAliasEnable_A8830;

		// Token: 0x0400134B RID: 4939
		internal global::AcpUI.AcpRtdButton RTDBtnRadWideUserInformationandPasswordsRadioAliasEnable_A8830;

		// Token: 0x0400134C RID: 4940
		internal global::AcpUI.AcpCopyButton CpyBtnRadWideUserInformationandPasswordsRadioAliasEnable_A8830;

		// Token: 0x0400134D RID: 4941
		internal global::AcpUI.AcpCheckBox RadWideUserInformationandPasswordsRadioAliasEnable_A8830Comp;

		// Token: 0x0400134E RID: 4942
		internal global::AcpUI.AcpCustomViewCheckBox CVBtnRadWideUserInformationandPasswordsRadioAlias_A8829;

		// Token: 0x0400134F RID: 4943
		internal global::AcpUI.AcpLabel LblRadWideUserInformationandPasswordsRadioAlias_A8829;

		// Token: 0x04001350 RID: 4944
		internal global::AcpUI.AcpTextBox RadWideUserInformationandPasswordsRadioAlias_A8829;

		// Token: 0x04001351 RID: 4945
		internal global::AcpUI.AcpRtdButton RTDBtnRadWideUserInformationandPasswordsRadioAlias_A8829;

		// Token: 0x04001352 RID: 4946
		internal global::AcpUI.AcpCopyButton CpyBtnRadWideUserInformationandPasswordsRadioAlias_A8829;

		// Token: 0x04001353 RID: 4947
		internal global::AcpUI.AcpLabel RadWideUserInformationandPasswordsRadioAlias_A8829Comp;

		// Token: 0x04001354 RID: 4948
		internal global::AcpUI.AcpCustomViewCheckBox CVBtnRadWideUserInformationandPasswordsUserLoginAuthenticationType_A44926;

		// Token: 0x04001355 RID: 4949
		internal global::AcpUI.AcpLabel LblRadWideUserInformationandPasswordsUserLoginAuthenticationType_A44926;

		// Token: 0x04001356 RID: 4950
		internal global::AcpUI.AcpComboBox RadWideUserInformationandPasswordsUserLoginAuthenticationType_A44926;

		// Token: 0x04001357 RID: 4951
		internal global::AcpUI.AcpRtdButton RTDBtnRadWideUserInformationandPasswordsUserLoginAuthenticationType_A44926;

		// Token: 0x04001358 RID: 4952
		internal global::AcpUI.AcpCopyButton CpyBtnRadWideUserInformationandPasswordsUserLoginAuthenticationType_A44926;

		// Token: 0x04001359 RID: 4953
		internal global::AcpUI.AcpLabel RadWideUserInformationandPasswordsUserLoginAuthenticationType_A44926Comp;

		// Token: 0x0400135A RID: 4954
		internal global::AcpUI.AcpGroupBox GrpBoxExpanderRadioWideUserInformationAndPasswordsZoneProtection;

		// Token: 0x0400135B RID: 4955
		internal global::AcpUI.AcpCustomViewCheckBox CVBtnRadWideUserInformationandPasswordsProtectedZonePassword_A8766;

		// Token: 0x0400135C RID: 4956
		internal global::AcpUI.AcpLabel LblRadWideUserInformationandPasswordsProtectedZonePassword_A8766;

		// Token: 0x0400135D RID: 4957
		internal global::AcpUI.AcpPasswordEyeBox RadWideUserInformationandPasswordsProtectedZonePassword_A8766;

		// Token: 0x0400135E RID: 4958
		internal global::AcpUI.AcpRtdButton RTDBtnRadWideUserInformationandPasswordsProtectedZonePassword_A8766;

		// Token: 0x0400135F RID: 4959
		internal global::AcpUI.AcpCopyButton CpyBtnRadWideUserInformationandPasswordsProtectedZonePassword_A8766;

		// Token: 0x04001360 RID: 4960
		internal global::AcpUI.AcpLabel RadWideUserInformationandPasswordsProtectedZonePassword_A8766Comp;

		// Token: 0x04001361 RID: 4961
		internal global::AcpUI.AcpGroupBox GrpBoxExpanderRadioWideUserInformationAndPasswordsRadioLock;

		// Token: 0x04001362 RID: 4962
		internal global::AcpUI.AcpCustomViewCheckBox CVBtnRadWideUserInformationandPasswordsRadioLock_A8836;

		// Token: 0x04001363 RID: 4963
		internal global::AcpUI.AcpLabel LblRadWideUserInformationandPasswordsRadioLock_A8836;

		// Token: 0x04001364 RID: 4964
		internal global::AcpUI.AcpCheckBox RadWideUserInformationandPasswordsRadioLock_A8836;

		// Token: 0x04001365 RID: 4965
		internal global::AcpUI.AcpRtdButton RTDBtnRadWideUserInformationandPasswordsRadioLock_A8836;

		// Token: 0x04001366 RID: 4966
		internal global::AcpUI.AcpCopyButton CpyBtnRadWideUserInformationandPasswordsRadioLock_A8836;

		// Token: 0x04001367 RID: 4967
		internal global::AcpUI.AcpCheckBox RadWideUserInformationandPasswordsRadioLock_A8836Comp;

		// Token: 0x04001368 RID: 4968
		internal global::AcpUI.AcpCustomViewCheckBox CVBtnRadWideUserInformationandPasswordsMandatoryPassword_A8461;

		// Token: 0x04001369 RID: 4969
		internal global::AcpUI.AcpLabel LblRadWideUserInformationandPasswordsMandatoryPassword_A8461;

		// Token: 0x0400136A RID: 4970
		internal global::AcpUI.AcpCheckBox RadWideUserInformationandPasswordsMandatoryPassword_A8461;

		// Token: 0x0400136B RID: 4971
		internal global::AcpUI.AcpRtdButton RTDBtnRadWideUserInformationandPasswordsMandatoryPassword_A8461;

		// Token: 0x0400136C RID: 4972
		internal global::AcpUI.AcpCopyButton CpyBtnRadWideUserInformationandPasswordsMandatoryPassword_A8461;

		// Token: 0x0400136D RID: 4973
		internal global::AcpUI.AcpCheckBox RadWideUserInformationandPasswordsMandatoryPassword_A8461Comp;

		// Token: 0x0400136E RID: 4974
		internal global::AcpUI.AcpCustomViewCheckBox CVBtnRadWideUserInformationandPasswordsMaximumPasswordLength_A8477;

		// Token: 0x0400136F RID: 4975
		internal global::AcpUI.AcpLabel LblRadWideUserInformationandPasswordsMaximumPasswordLength_A8477;

		// Token: 0x04001370 RID: 4976
		internal global::AcpUI.AcpTextBoxSpinner RadWideUserInformationandPasswordsMaximumPasswordLength_A8477;

		// Token: 0x04001371 RID: 4977
		internal global::AcpUI.AcpRtdButton RTDBtnRadWideUserInformationandPasswordsMaximumPasswordLength_A8477;

		// Token: 0x04001372 RID: 4978
		internal global::AcpUI.AcpCopyButton CpyBtnRadWideUserInformationandPasswordsMaximumPasswordLength_A8477;

		// Token: 0x04001373 RID: 4979
		internal global::AcpUI.AcpLabel RadWideUserInformationandPasswordsMaximumPasswordLength_A8477Comp;

		// Token: 0x04001374 RID: 4980
		internal global::AcpUI.AcpCustomViewCheckBox CVBtnRadWideUserInformationandPasswordsUnlockPassword_A8690;

		// Token: 0x04001375 RID: 4981
		internal global::AcpUI.AcpLabel LblRadWideUserInformationandPasswordsUnlockPassword_A8690;

		// Token: 0x04001376 RID: 4982
		internal global::AcpUI.AcpPasswordEyeBox RadWideUserInformationandPasswordsUnlockPassword_A8690;

		// Token: 0x04001377 RID: 4983
		internal global::AcpUI.AcpRtdButton RTDBtnRadWideUserInformationandPasswordsUnlockPassword_A8690;

		// Token: 0x04001378 RID: 4984
		internal global::AcpUI.AcpCopyButton CpyBtnRadWideUserInformationandPasswordsUnlockPassword_A8690;

		// Token: 0x04001379 RID: 4985
		internal global::AcpUI.AcpLabel RadWideUserInformationandPasswordsUnlockPassword_A8690Comp;

		// Token: 0x0400137A RID: 4986
		internal global::AcpUI.AcpCustomViewCheckBox CVBtnRadWideUserInformationandPasswordsRadioLockAttemptsAllowed_A3582;

		// Token: 0x0400137B RID: 4987
		internal global::AcpUI.AcpLabel LblRadWideUserInformationandPasswordsRadioLockAttemptsAllowed_A3582;

		// Token: 0x0400137C RID: 4988
		internal global::AcpUI.AcpTextBoxSpinner RadWideUserInformationandPasswordsRadioLockAttemptsAllowed_A3582;

		// Token: 0x0400137D RID: 4989
		internal global::AcpUI.AcpRtdButton RTDBtnRadWideUserInformationandPasswordsRadioLockAttemptsAllowed_A3582;

		// Token: 0x0400137E RID: 4990
		internal global::AcpUI.AcpCopyButton CpyBtnRadWideUserInformationandPasswordsRadioLockAttemptsAllowed_A3582;

		// Token: 0x0400137F RID: 4991
		internal global::AcpUI.AcpLabel RadWideUserInformationandPasswordsRadioLockAttemptsAllowed_A3582Comp;

		// Token: 0x04001380 RID: 4992
		internal global::AcpUI.AcpCustomViewCheckBox CVBtnRadWideUserInformationandPasswordsRadioLockRadioInhibitOnDeadlock_A3584;

		// Token: 0x04001381 RID: 4993
		internal global::AcpUI.AcpLabel LblRadWideUserInformationandPasswordsRadioLockRadioInhibitOnDeadlock_A3584;

		// Token: 0x04001382 RID: 4994
		internal global::AcpUI.AcpCheckBox RadWideUserInformationandPasswordsRadioLockRadioInhibitOnDeadlock_A3584;

		// Token: 0x04001383 RID: 4995
		internal global::AcpUI.AcpRtdButton RTDBtnRadWideUserInformationandPasswordsRadioLockRadioInhibitOnDeadlock_A3584;

		// Token: 0x04001384 RID: 4996
		internal global::AcpUI.AcpCopyButton CpyBtnRadWideUserInformationandPasswordsRadioLockRadioInhibitOnDeadlock_A3584;

		// Token: 0x04001385 RID: 4997
		internal global::AcpUI.AcpCheckBox RadWideUserInformationandPasswordsRadioLockRadioInhibitOnDeadlock_A3584Comp;

		// Token: 0x04001386 RID: 4998
		internal global::AcpUI.AcpCustomViewCheckBox CVBtnRadWideUserInformationandPasswordsRadioLockForceChangePassword_A3583;

		// Token: 0x04001387 RID: 4999
		internal global::AcpUI.AcpLabel LblRadWideUserInformationandPasswordsRadioLockForceChangePassword_A3583;

		// Token: 0x04001388 RID: 5000
		internal global::AcpUI.AcpCheckBox RadWideUserInformationandPasswordsRadioLockForceChangePassword_A3583;

		// Token: 0x04001389 RID: 5001
		internal global::AcpUI.AcpRtdButton RTDBtnRadWideUserInformationandPasswordsRadioLockForceChangePassword_A3583;

		// Token: 0x0400138A RID: 5002
		internal global::AcpUI.AcpCopyButton CpyBtnRadWideUserInformationandPasswordsRadioLockForceChangePassword_A3583;

		// Token: 0x0400138B RID: 5003
		internal global::AcpUI.AcpCheckBox RadWideUserInformationandPasswordsRadioLockForceChangePassword_A3583Comp;

		// Token: 0x0400138C RID: 5004
		internal global::AcpUI.AcpGroupBox GrpBoxExpanderRadioWideUserInformationAndPasswordsTacticalInhibit;

		// Token: 0x0400138D RID: 5005
		internal global::AcpUI.AcpCustomViewCheckBox CVBtnRadWideUserInformationAndPasswordsTacticalInhibitEnable_A34405;

		// Token: 0x0400138E RID: 5006
		internal global::AcpUI.AcpLabel LblRadWideUserInformationAndPasswordsTacticalInhibitEnable_A34405;

		// Token: 0x0400138F RID: 5007
		internal global::AcpUI.AcpCheckBox RadWideUserInformationAndPasswordsTacticalInhibitEnable_A34405;

		// Token: 0x04001390 RID: 5008
		internal global::AcpUI.AcpRtdButton RTDBtnRadWideUserInformationAndPasswordsTacticalInhibitEnable_A34405;

		// Token: 0x04001391 RID: 5009
		internal global::AcpUI.AcpCopyButton CpyBtnRadWideUserInformationAndPasswordsTacticalInhibitEnable_A34405;

		// Token: 0x04001392 RID: 5010
		internal global::AcpUI.AcpCheckBox RadWideUserInformationAndPasswordsTacticalInhibitEnable_A34405Comp;

		// Token: 0x04001393 RID: 5011
		internal global::AcpUI.AcpCustomViewCheckBox CVBtnRadWideUserInformationAndPasswordsTacticalInhibitEncodePassword_A34395;

		// Token: 0x04001394 RID: 5012
		internal global::AcpUI.AcpLabel LblRadWideUserInformationAndPasswordsTacticalInhibitEncodePassword_A34395;

		// Token: 0x04001395 RID: 5013
		internal global::AcpUI.AcpPasswordEyeBox RadWideUserInformationAndPasswordsTacticalInhibitEncodePassword_A34395;

		// Token: 0x04001396 RID: 5014
		internal global::AcpUI.AcpRtdButton RTDBtnRadWideUserInformationAndPasswordsTacticalInhibitEncodePassword_A34395;

		// Token: 0x04001397 RID: 5015
		internal global::AcpUI.AcpCopyButton CpyBtnRadWideUserInformationAndPasswordsTacticalInhibitEncodePassword_A34395;

		// Token: 0x04001398 RID: 5016
		internal global::AcpUI.AcpLabel RadWideUserInformationAndPasswordsTacticalInhibitEncodePassword_A34395Comp;

		// Token: 0x04001399 RID: 5017
		internal global::AcpUI.AcpGroupBox GrpBoxExpanderRadioWideUserInformationAndPasswordsTacticaService;

		// Token: 0x0400139A RID: 5018
		internal global::AcpUI.AcpCustomViewCheckBox CVBtnRadWideUserInformationandPasswordsTacticalServiceEncodePassword;

		// Token: 0x0400139B RID: 5019
		internal global::AcpUI.AcpLabel LblRadWideUserInformationandPasswordsTacticalServiceEncodePassword;

		// Token: 0x0400139C RID: 5020
		internal global::AcpUI.AcpPasswordEyeBox RadWideUserInformationandPasswordsTacticalServiceEncodePassword;

		// Token: 0x0400139D RID: 5021
		internal global::AcpUI.AcpRtdButton RTDBtnRadWideUserInformationandPasswordsTacticalServiceEncodePassword;

		// Token: 0x0400139E RID: 5022
		internal global::AcpUI.AcpCopyButton CpyBtnRadWideUserInformationandPasswordsTacticalServiceEncodePassword;

		// Token: 0x0400139F RID: 5023
		internal global::AcpUI.AcpLabel RadWideUserInformationandPasswordsTacticalServiceEncodePasswordComp;

		// Token: 0x040013A0 RID: 5024
		internal global::AcpUI.AcpGroupBox GrpBoxExpanderRadioWideUserInformationAndPasswordsPasswordRequiredFor;

		// Token: 0x040013A1 RID: 5025
		internal global::AcpUI.AcpCustomViewCheckBox CVBtnRadWideUserinfoPassRequiredForGunlock_A36531;

		// Token: 0x040013A2 RID: 5026
		internal global::AcpUI.AcpLabel LblRadWideUserinfoPassRequiredForGunlock_A36531;

		// Token: 0x040013A3 RID: 5027
		internal global::AcpUI.AcpCheckBox RadWideUserinfoPassRequiredForGunlock_A36531;

		// Token: 0x040013A4 RID: 5028
		internal global::AcpUI.AcpRtdButton RTDBtnRadWideUserinfoPassRequiredForGunlock_A36531;

		// Token: 0x040013A5 RID: 5029
		internal global::AcpUI.AcpCopyButton CpyBtnRadWideUserinfoPassRequiredForGunlock_A36531;

		// Token: 0x040013A6 RID: 5030
		internal global::AcpUI.AcpCheckBox RadWideUserinfoPassRequiredForGunlock_A36531Comp;

		// Token: 0x040013A7 RID: 5031
		internal global::AcpUI.AcpCustomViewCheckBox CVBtnRadWideUserinfoPassRequiredForLightbar_A36532;

		// Token: 0x040013A8 RID: 5032
		internal global::AcpUI.AcpLabel LblRadWideUserinfoPassRequiredForLightbar_A36532;

		// Token: 0x040013A9 RID: 5033
		internal global::AcpUI.AcpCheckBox RadWideUserinfoPassRequiredForLightbar_A36532;

		// Token: 0x040013AA RID: 5034
		internal global::AcpUI.AcpRtdButton RTDBtnRadWideUserinfoPassRequiredForLightbar_A36532;

		// Token: 0x040013AB RID: 5035
		internal global::AcpUI.AcpCopyButton CpyBtnRadWideUserinfoPassRequiredForLightbar_A36532;

		// Token: 0x040013AC RID: 5036
		internal global::AcpUI.AcpCheckBox RadWideUserinfoPassRequiredForLightbar_A36532Comp;

		// Token: 0x040013AD RID: 5037
		internal global::AcpUI.AcpCustomViewCheckBox CVBtnRadWideUserinfoPassRequiredForSiren_A36533;

		// Token: 0x040013AE RID: 5038
		internal global::AcpUI.AcpLabel LblRadWideUserinfoPassRequiredForSiren_A36533;

		// Token: 0x040013AF RID: 5039
		internal global::AcpUI.AcpCheckBox RadWideUserinfoPassRequiredForSiren_A36533;

		// Token: 0x040013B0 RID: 5040
		internal global::AcpUI.AcpRtdButton RTDBtnRadWideUserinfoPassRequiredForSiren_A36533;

		// Token: 0x040013B1 RID: 5041
		internal global::AcpUI.AcpCopyButton CpyBtnRadWideUserinfoPassRequiredForSiren_A36533;

		// Token: 0x040013B2 RID: 5042
		internal global::AcpUI.AcpCheckBox RadWideUserinfoPassRequiredForSiren_A36533Comp;

		// Token: 0x040013B3 RID: 5043
		internal global::AcpUI.AcpGroupBox GrpBoxExpanderRadioWideUserInformationAndPasswordsPseudo5;

		// Token: 0x040013B4 RID: 5044
		internal global::AcpUI.AcpCustomViewCheckBox CVBtnRadWideUserInformationandPasswordsSecureHardwareAutoLogin_A7508;

		// Token: 0x040013B5 RID: 5045
		internal global::AcpUI.AcpLabel LblRadWideUserInformationandPasswordsSecureHardwareAutoLogin_A7508;

		// Token: 0x040013B6 RID: 5046
		internal global::AcpUI.AcpCheckBox RadWideUserInformationandPasswordsSecureHardwareAutoLogin_A7508;

		// Token: 0x040013B7 RID: 5047
		internal global::AcpUI.AcpRtdButton RTDBtnRadWideUserInformationandPasswordsSecureHardwareAutoLogin_A7508;

		// Token: 0x040013B8 RID: 5048
		internal global::AcpUI.AcpCopyButton CpyBtnRadWideUserInformationandPasswordsSecureHardwareAutoLogin_A7508;

		// Token: 0x040013B9 RID: 5049
		internal global::AcpUI.AcpCheckBox RadWideUserInformationandPasswordsSecureHardwareAutoLogin_A7508Comp;

		// Token: 0x040013BA RID: 5050
		internal global::AcpUI.AcpCustomViewCheckBox CVBtnRadWideUserInformationandCachedCredentialsUserLoginMode_41307;

		// Token: 0x040013BB RID: 5051
		internal global::AcpUI.AcpLabel LblRadWideUserInformationandCachedCredentialsUserLoginMode_41307;

		// Token: 0x040013BC RID: 5052
		internal global::AcpUI.AcpComboBox RadWideUserInformationandCachedCredentialsUserLoginMode_41307;

		// Token: 0x040013BD RID: 5053
		internal global::AcpUI.AcpRtdButton RTDBtnRadWideUserInformationandCachedCredentialsUserLoginMode_41307;

		// Token: 0x040013BE RID: 5054
		internal global::AcpUI.AcpCopyButton CpyBtnRadWideUserInformationandCachedCredentialsUserLoginMode_41307;

		// Token: 0x040013BF RID: 5055
		internal global::AcpUI.AcpLabel RadWideUserInformationandCachedCredentialsUserLoginMode_41307Comp;

		// Token: 0x040013C0 RID: 5056
		internal global::AcpUI.AcpCustomViewCheckBox CVBtnRadWideConventionalDynamicIDWithPassword_A43705;

		// Token: 0x040013C1 RID: 5057
		internal global::AcpUI.AcpLabel LblRadWideConventionalDynamicIDWithPassword_A43705;

		// Token: 0x040013C2 RID: 5058
		internal global::AcpUI.AcpPasswordEyeBox RadWideConventionalDynamicIDWithPassword_A43705;

		// Token: 0x040013C3 RID: 5059
		internal global::AcpUI.AcpRtdButton RTDBtnRadWideConventionalDynamicIDWithPassword_A43705;

		// Token: 0x040013C4 RID: 5060
		internal global::AcpUI.AcpCopyButton CpyBtnRadWideConventionalDynamicIDWithPassword_A43705;

		// Token: 0x040013C5 RID: 5061
		internal global::AcpUI.AcpLabel RadWideConventionalDynamicIDWithPassword_A43705Comp;

		// Token: 0x040013C6 RID: 5062
		internal global::AcpUI.AcpExpander ExpanderRadioWideFeatures;

		// Token: 0x040013C7 RID: 5063
		internal global::AcpUI.AcpGroupBox GrpBoxExpanderRadioWideFeaturesPseudo0;

		// Token: 0x040013C8 RID: 5064
		internal global::AcpUI.AcpCustomViewCheckBox CVBtnRadWideFeaturesBlockPendingCAPC_A7564;

		// Token: 0x040013C9 RID: 5065
		internal global::AcpUI.AcpLabel LblRadWideFeaturesBlockPendingCAPC_A7564;

		// Token: 0x040013CA RID: 5066
		internal global::AcpUI.AcpCheckBox RadWideFeaturesBlockPendingCAPC_A7564;

		// Token: 0x040013CB RID: 5067
		internal global::AcpUI.AcpRtdButton RTDBtnRadWideFeaturesBlockPendingCAPC_A7564;

		// Token: 0x040013CC RID: 5068
		internal global::AcpUI.AcpCopyButton CpyBtnRadWideFeaturesBlockPendingCAPC_A7564;

		// Token: 0x040013CD RID: 5069
		internal global::AcpUI.AcpCheckBox RadWideFeaturesBlockPendingCAPC_A7564Comp;

		// Token: 0x040013CE RID: 5070
		internal global::AcpUI.AcpCustomViewCheckBox CVBtnRadWideFeaturesRotarySwitchScanPrgm_A8986;

		// Token: 0x040013CF RID: 5071
		internal global::AcpUI.AcpLabel LblRadWideFeaturesRotarySwitchScanPrgm_A8986;

		// Token: 0x040013D0 RID: 5072
		internal global::AcpUI.AcpComboBox RadWideFeaturesRotarySwitchScanPrgm_A8986;

		// Token: 0x040013D1 RID: 5073
		internal global::AcpUI.AcpRtdButton RTDBtnRadWideFeaturesRotarySwitchScanPrgm_A8986;

		// Token: 0x040013D2 RID: 5074
		internal global::AcpUI.AcpCopyButton CpyBtnRadWideFeaturesRotarySwitchScanPrgm_A8986;

		// Token: 0x040013D3 RID: 5075
		internal global::AcpUI.AcpLabel RadWideFeaturesRotarySwitchScanPrgm_A8986Comp;

		// Token: 0x040013D4 RID: 5076
		internal global::AcpUI.AcpCustomViewCheckBox CVBtnRadWideTPSFiregroundEvacuationTone_A7980;

		// Token: 0x040013D5 RID: 5077
		internal global::AcpUI.AcpLabel LblRadWideTPSFiregroundEvacuationTone_A7980;

		// Token: 0x040013D6 RID: 5078
		internal global::AcpUI.AcpCheckBox RadWideTPSFiregroundEvacuationTone_A7980;

		// Token: 0x040013D7 RID: 5079
		internal global::AcpUI.AcpRtdButton RTDBtnRadWideTPSFiregroundEvacuationTone_A7980;

		// Token: 0x040013D8 RID: 5080
		internal global::AcpUI.AcpCopyButton CpyBtnRadWideTPSFiregroundEvacuationTone_A7980;

		// Token: 0x040013D9 RID: 5081
		internal global::AcpUI.AcpCheckBox RadWideTPSFiregroundEvacuationTone_A7980Comp;

		// Token: 0x040013DA RID: 5082
		internal global::AcpUI.AcpCustomViewCheckBox CVBtnZnChanCfgFPPProtectionFPPEnable_A8142;

		// Token: 0x040013DB RID: 5083
		internal global::AcpUI.AcpLabel LblZnChanCfgFPPProtectionFPPEnable_A8142;

		// Token: 0x040013DC RID: 5084
		internal global::AcpUI.AcpCheckBox ZnChanCfgFPPProtectionFPPEnable_A8142;

		// Token: 0x040013DD RID: 5085
		internal global::AcpUI.AcpRtdButton RTDBtnZnChanCfgFPPProtectionFPPEnable_A8142;

		// Token: 0x040013DE RID: 5086
		internal global::AcpUI.AcpCopyButton CpyBtnZnChanCfgFPPProtectionFPPEnable_A8142;

		// Token: 0x040013DF RID: 5087
		internal global::AcpUI.AcpCheckBox ZnChanCfgFPPProtectionFPPEnable_A8142Comp;

		// Token: 0x040013E0 RID: 5088
		internal global::AcpUI.AcpCustomViewCheckBox CVBtnRadWideFeaturesZoneCloneEnable_43130;

		// Token: 0x040013E1 RID: 5089
		internal global::AcpUI.AcpLabel LblRadWideFeaturesZoneCloneEnable_43130;

		// Token: 0x040013E2 RID: 5090
		internal global::AcpUI.AcpCheckBox RadWideFeaturesZoneCloneEnable_43130;

		// Token: 0x040013E3 RID: 5091
		internal global::AcpUI.AcpRtdButton RTDBtnRadWideFeaturesZoneCloneEnable_43130;

		// Token: 0x040013E4 RID: 5092
		internal global::AcpUI.AcpCopyButton CpyBtnRadWideFeaturesZoneCloneEnable_43130;

		// Token: 0x040013E5 RID: 5093
		internal global::AcpUI.AcpCheckBox RadWideFeaturesZoneCloneEnable_43130Comp;

		// Token: 0x040013E6 RID: 5094
		internal global::AcpUI.AcpCustomViewCheckBox CVBtnIsolatedGCAIAccessoryPlugAndPlayDisable_42927;

		// Token: 0x040013E7 RID: 5095
		internal global::AcpUI.AcpLabel LblIsolatedGCAIAccessoryPlugAndPlayDisable_42927;

		// Token: 0x040013E8 RID: 5096
		internal global::AcpUI.AcpCheckBox IsolatedGCAIAccessoryPlugAndPlayDisable_42927;

		// Token: 0x040013E9 RID: 5097
		internal global::AcpUI.AcpRtdButton RTDBtnIsolatedGCAIAccessoryPlugAndPlayDisable_42927;

		// Token: 0x040013EA RID: 5098
		internal global::AcpUI.AcpCopyButton CpyBtnIsolatedGCAIAccessoryPlugAndPlayDisable_42927;

		// Token: 0x040013EB RID: 5099
		internal global::AcpUI.AcpCheckBox IsolatedGCAIAccessoryPlugAndPlayDisable_42927Comp;

		// Token: 0x040013EC RID: 5100
		internal global::AcpUI.AcpCustomViewCheckBox CVBtnRadWideAdvancedCyclicKeying_A7795;

		// Token: 0x040013ED RID: 5101
		internal global::AcpUI.AcpLabel LblRadWideAdvancedCyclicKeying_A7795;

		// Token: 0x040013EE RID: 5102
		internal global::AcpUI.AcpCheckBox RadWideAdvancedCyclicKeying_A7795;

		// Token: 0x040013EF RID: 5103
		internal global::AcpUI.AcpRtdButton RTDBtnRadWideAdvancedCyclicKeying_A7795;

		// Token: 0x040013F0 RID: 5104
		internal global::AcpUI.AcpCopyButton CpyBtnRadWideAdvancedCyclicKeying_A7795;

		// Token: 0x040013F1 RID: 5105
		internal global::AcpUI.AcpCheckBox RadWideAdvancedCyclicKeying_A7795Comp;

		// Token: 0x040013F2 RID: 5106
		internal global::AcpUI.AcpCustomViewCheckBox CVBtnSwitchConventionalSwitchesPosition1_A12643;

		// Token: 0x040013F3 RID: 5107
		internal global::AcpUI.AcpLabel LblSwitchConventionalSwitchesPosition1_A12643;

		// Token: 0x040013F4 RID: 5108
		internal global::AcpUI.AcpComboBox SwitchConventionalSwitchesPosition1_A12643;

		// Token: 0x040013F5 RID: 5109
		internal global::AcpUI.AcpRtdButton RTDBtnSwitchConventionalSwitchesPosition1_A12643;

		// Token: 0x040013F6 RID: 5110
		internal global::AcpUI.AcpCopyButton CpyBtnSwitchConventionalSwitchesPosition1_A12643;

		// Token: 0x040013F7 RID: 5111
		internal global::AcpUI.AcpLabel SwitchConventionalSwitchesPosition1_A12643Comp;

		// Token: 0x040013F8 RID: 5112
		internal global::AcpUI.AcpCustomViewCheckBox CVBtnRadWideFeaturesInactivityAutoPoweroff_A38013;

		// Token: 0x040013F9 RID: 5113
		internal global::AcpUI.AcpLabel LblRadWideFeaturesInactivityAutoPoweroff_A38013;

		// Token: 0x040013FA RID: 5114
		internal global::AcpUI.AcpTextBoxSpinner RadWideFeaturesInactivityAutoPoweroff_A38013;

		// Token: 0x040013FB RID: 5115
		internal global::AcpUI.AcpRtdButton RTDBtnRadWideFeaturesInactivityAutoPoweroff_A38013;

		// Token: 0x040013FC RID: 5116
		internal global::AcpUI.AcpCopyButton CpyBtnRadWideFeaturesInactivityAutoPoweroff_A38013;

		// Token: 0x040013FD RID: 5117
		internal global::AcpUI.AcpLabel RadWideFeaturesInactivityAutoPoweroff_A38013Comp;

		// Token: 0x040013FE RID: 5118
		internal global::AcpUI.AcpCustomViewCheckBox CVBtnRadWideFeaturesIgnitionAutoPoweroff_A38014;

		// Token: 0x040013FF RID: 5119
		internal global::AcpUI.AcpLabel LblRadWideFeaturesIgnitionAutoPoweroff_A38014;

		// Token: 0x04001400 RID: 5120
		internal global::AcpUI.AcpTextBoxSpinner RadWideFeaturesIgnitionAutoPoweroff_A38014;

		// Token: 0x04001401 RID: 5121
		internal global::AcpUI.AcpRtdButton RTDBtnRadWideFeaturesIgnitionAutoPoweroff_A38014;

		// Token: 0x04001402 RID: 5122
		internal global::AcpUI.AcpCopyButton CpyBtnRadWideFeaturesIgnitionAutoPoweroff_A38014;

		// Token: 0x04001403 RID: 5123
		internal global::AcpUI.AcpLabel RadWideFeaturesIgnitionAutoPoweroff_A38014Comp;

		// Token: 0x04001404 RID: 5124
		internal global::AcpUI.AcpCustomViewCheckBox CVBtnRadWideFeaturesDisableIgnitionAutoPowerOffAlert_A38015;

		// Token: 0x04001405 RID: 5125
		internal global::AcpUI.AcpLabel LblRadWideFeaturesDisableIgnitionAutoPowerOffAlert_A38015;

		// Token: 0x04001406 RID: 5126
		internal global::AcpUI.AcpCheckBox RadWideFeaturesDisableIgnitionAutoPowerOffAlert_A38015;

		// Token: 0x04001407 RID: 5127
		internal global::AcpUI.AcpRtdButton RTDBtnRadWideFeaturesDisableIgnitionAutoPowerOffAlert_A38015;

		// Token: 0x04001408 RID: 5128
		internal global::AcpUI.AcpCopyButton CpyBtnRadWideFeaturesDisableIgnitionAutoPowerOffAlert_A38015;

		// Token: 0x04001409 RID: 5129
		internal global::AcpUI.AcpCheckBox RadWideFeaturesDisableIgnitionAutoPowerOffAlert_A38015Comp;

		// Token: 0x0400140A RID: 5130
		internal global::AcpUI.AcpCustomViewCheckBox CVBtnRadWideAdvancedRFModem_A8972;

		// Token: 0x0400140B RID: 5131
		internal global::AcpUI.AcpLabel LblRadWideAdvancedRFModem_A8972;

		// Token: 0x0400140C RID: 5132
		internal global::AcpUI.AcpComboBox RadWideAdvancedRFModem_A8972;

		// Token: 0x0400140D RID: 5133
		internal global::AcpUI.AcpRtdButton RTDBtnRadWideAdvancedRFModem_A8972;

		// Token: 0x0400140E RID: 5134
		internal global::AcpUI.AcpCopyButton CpyBtnRadWideAdvancedRFModem_A8972;

		// Token: 0x0400140F RID: 5135
		internal global::AcpUI.AcpLabel RadWideAdvancedRFModem_A8972Comp;

		// Token: 0x04001410 RID: 5136
		internal global::AcpUI.AcpCustomViewCheckBox CVBtnRadWideAdvancedRecordAudio_A8922;

		// Token: 0x04001411 RID: 5137
		internal global::AcpUI.AcpLabel LblRadWideAdvancedRecordAudio_A8922;

		// Token: 0x04001412 RID: 5138
		internal global::AcpUI.AcpComboBox RadWideAdvancedRecordAudio_A8922;

		// Token: 0x04001413 RID: 5139
		internal global::AcpUI.AcpRtdButton RTDBtnRadWideAdvancedRecordAudio_A8922;

		// Token: 0x04001414 RID: 5140
		internal global::AcpUI.AcpCopyButton CpyBtnRadWideAdvancedRecordAudio_A8922;

		// Token: 0x04001415 RID: 5141
		internal global::AcpUI.AcpLabel RadWideAdvancedRecordAudio_A8922Comp;

		// Token: 0x04001416 RID: 5142
		internal global::AcpUI.AcpCustomViewCheckBox CVBtnRadWideAdvancedPreAmp_A8733;

		// Token: 0x04001417 RID: 5143
		internal global::AcpUI.AcpLabel LblRadWideAdvancedPreAmp_A8733;

		// Token: 0x04001418 RID: 5144
		internal global::AcpUI.AcpCheckBox RadWideAdvancedPreAmp_A8733;

		// Token: 0x04001419 RID: 5145
		internal global::AcpUI.AcpRtdButton RTDBtnRadWideAdvancedPreAmp_A8733;

		// Token: 0x0400141A RID: 5146
		internal global::AcpUI.AcpCopyButton CpyBtnRadWideAdvancedPreAmp_A8733;

		// Token: 0x0400141B RID: 5147
		internal global::AcpUI.AcpCheckBox RadWideAdvancedPreAmp_A8733Comp;

		// Token: 0x0400141C RID: 5148
		internal global::AcpUI.AcpCustomViewCheckBox CVBtnRadWideFeaturePreAmpVHF_A42960;

		// Token: 0x0400141D RID: 5149
		internal global::AcpUI.AcpLabel LblRadWideFeaturePreAmpVHF_A42960;

		// Token: 0x0400141E RID: 5150
		internal global::AcpUI.AcpCheckBox RadWideFeaturePreAmpVHF_A42960;

		// Token: 0x0400141F RID: 5151
		internal global::AcpUI.AcpRtdButton RTDBtnRadWideFeaturePreAmpVHF_A42960;

		// Token: 0x04001420 RID: 5152
		internal global::AcpUI.AcpCopyButton CpyBtnRadWideFeaturePreAmpVHF_A42960;

		// Token: 0x04001421 RID: 5153
		internal global::AcpUI.AcpCheckBox RadWideFeaturePreAmpVHF_A42960Comp;

		// Token: 0x04001422 RID: 5154
		internal global::AcpUI.AcpCustomViewCheckBox CVBtnRadWideFeaturePreAmpUHF_A42962;

		// Token: 0x04001423 RID: 5155
		internal global::AcpUI.AcpLabel LblRadWideFeaturePreAmpUHF_A42962;

		// Token: 0x04001424 RID: 5156
		internal global::AcpUI.AcpCheckBox RadWideFeaturePreAmpUHF_A42962;

		// Token: 0x04001425 RID: 5157
		internal global::AcpUI.AcpRtdButton RTDBtnRadWideFeaturePreAmpUHF_A42962;

		// Token: 0x04001426 RID: 5158
		internal global::AcpUI.AcpCopyButton CpyBtnRadWideFeaturePreAmpUHF_A42962;

		// Token: 0x04001427 RID: 5159
		internal global::AcpUI.AcpCheckBox RadWideFeaturePreAmpUHF_A42962Comp;

		// Token: 0x04001428 RID: 5160
		internal global::AcpUI.AcpCustomViewCheckBox CVBtnRadWideFeatureDynamicIcons_A42963;

		// Token: 0x04001429 RID: 5161
		internal global::AcpUI.AcpLabel LblRadWideFeatureDynamicIcons_A42963;

		// Token: 0x0400142A RID: 5162
		internal global::AcpUI.AcpCheckBox RadWideFeatureDynamicIcons_A42963;

		// Token: 0x0400142B RID: 5163
		internal global::AcpUI.AcpRtdButton RTDBtnRadWideFeatureDynamicIcons_A42963;

		// Token: 0x0400142C RID: 5164
		internal global::AcpUI.AcpCopyButton CpyBtnRadWideFeatureDynamicIcons_A42963;

		// Token: 0x0400142D RID: 5165
		internal global::AcpUI.AcpCheckBox RadWideFeatureDynamicIcons_A42963Comp;

		// Token: 0x0400142E RID: 5166
		internal global::AcpUI.AcpCustomViewCheckBox CVBtnRadWideFeaturesNFPACompliant;

		// Token: 0x0400142F RID: 5167
		internal global::AcpUI.AcpLabel LblRadWideFeaturesNFPACompliant;

		// Token: 0x04001430 RID: 5168
		internal global::AcpUI.AcpCheckBox RadWideFeaturesNFPACompliant;

		// Token: 0x04001431 RID: 5169
		internal global::AcpUI.AcpRtdButton RTDBtnRadWideFeaturesNFPACompliant;

		// Token: 0x04001432 RID: 5170
		internal global::AcpUI.AcpCopyButton CpyBtnRadWideFeaturesNFPACompliant;

		// Token: 0x04001433 RID: 5171
		internal global::AcpUI.AcpCheckBox RadWideFeaturesNFPACompliantComp;

		// Token: 0x04001434 RID: 5172
		internal global::AcpUI.AcpCustomViewCheckBox CVBtnRadWideFeaturesDisplayLastAcknowledgedUserStatusorMessage_A42000;

		// Token: 0x04001435 RID: 5173
		internal global::AcpUI.AcpLabel LblRadWideFeaturesDisplayLastAcknowledgedUserStatusorMessage_A42000;

		// Token: 0x04001436 RID: 5174
		internal global::AcpUI.AcpCheckBox RadWideFeaturesDisplayLastAcknowledgedUserStatusorMessage_A42000;

		// Token: 0x04001437 RID: 5175
		internal global::AcpUI.AcpRtdButton RTDBtnRadWideFeaturesDisplayLastAcknowledgedUserStatusorMessage_A42000;

		// Token: 0x04001438 RID: 5176
		internal global::AcpUI.AcpCopyButton CpyBtnRadWideFeaturesDisplayLastAcknowledgedUserStatusorMessage_A42000;

		// Token: 0x04001439 RID: 5177
		internal global::AcpUI.AcpCheckBox RadWideFeaturesDisplayLastAcknowledgedUserStatusorMessage_A42000Comp;

		// Token: 0x0400143A RID: 5178
		internal global::AcpUI.AcpCustomViewCheckBox CVBtnRadWideFeaturesAccessoryCableConfiguration_41997;

		// Token: 0x0400143B RID: 5179
		internal global::AcpUI.AcpLabel LblRadWideFeaturesAccessoryCableConfiguration_41997;

		// Token: 0x0400143C RID: 5180
		internal global::AcpUI.AcpComboBox RadWideFeaturesAccessoryCableConfiguration_41997;

		// Token: 0x0400143D RID: 5181
		internal global::AcpUI.AcpRtdButton RTDBtnRadWideFeaturesAccessoryCableConfiguration_41997;

		// Token: 0x0400143E RID: 5182
		internal global::AcpUI.AcpCopyButton CpyBtnRadWideFeaturesAccessoryCableConfiguration_41997;

		// Token: 0x0400143F RID: 5183
		internal global::AcpUI.AcpLabel RadWideFeaturesAccessoryCableConfiguration_41997Comp;

		// Token: 0x04001440 RID: 5184
		internal global::AcpUI.AcpCustomViewCheckBox CVBtnRadWideFeaturesChannelFallbackEnable;

		// Token: 0x04001441 RID: 5185
		internal global::AcpUI.AcpLabel LblRadWideFeaturesChannelFallbackEnable;

		// Token: 0x04001442 RID: 5186
		internal global::AcpUI.AcpCheckBox RadWideFeaturesChannelFallbackEnable;

		// Token: 0x04001443 RID: 5187
		internal global::AcpUI.AcpRtdButton RTDBtnRadWideFeaturesChannelFallbackEnable;

		// Token: 0x04001444 RID: 5188
		internal global::AcpUI.AcpCopyButton CpyBtnRadWideFeaturesChannelFallbackEnable;

		// Token: 0x04001445 RID: 5189
		internal global::AcpUI.AcpCheckBox RadWideFeaturesChannelFallbackEnableComp;

		// Token: 0x04001446 RID: 5190
		internal global::AcpUI.AcpGroupBox GrpBoxExpanderRadioWideFeaturesChannelChangeOnHUB;

		// Token: 0x04001447 RID: 5191
		internal global::AcpUI.AcpCustomViewCheckBox CVBtnRadWideFeaturesChanChangeOnOffHookEnable_A42354;

		// Token: 0x04001448 RID: 5192
		internal global::AcpUI.AcpLabel LblRadWideFeaturesChanChangeOnOffHookEnable_A42354;

		// Token: 0x04001449 RID: 5193
		internal global::AcpUI.AcpCheckBox RadWideFeaturesChanChangeOnOffHookEnable_A42354;

		// Token: 0x0400144A RID: 5194
		internal global::AcpUI.AcpRtdButton RTDBtnRadWideFeaturesChanChangeOnOffHookEnable_A42354;

		// Token: 0x0400144B RID: 5195
		internal global::AcpUI.AcpCopyButton CpyBtnRadWideFeaturesChanChangeOnOffHookEnable_A42354;

		// Token: 0x0400144C RID: 5196
		internal global::AcpUI.AcpCheckBox RadWideFeaturesChanChangeOnOffHookEnable_A42354Comp;

		// Token: 0x0400144D RID: 5197
		internal global::AcpUI.AcpCustomViewCheckBox CVBtnRadWideFeaturesTargetZoneOnOffHook_A42355;

		// Token: 0x0400144E RID: 5198
		internal global::AcpUI.AcpLabel LblRadWideFeaturesTargetZoneOnOffHook_A42355;

		// Token: 0x0400144F RID: 5199
		internal global::AcpUI.AcpComboBox RadWideFeaturesTargetZoneOnOffHook_A42355;

		// Token: 0x04001450 RID: 5200
		internal global::AcpUI.AcpRtdButton RTDBtnRadWideFeaturesTargetZoneOnOffHook_A42355;

		// Token: 0x04001451 RID: 5201
		internal global::AcpUI.AcpCopyButton CpyBtnRadWideFeaturesTargetZoneOnOffHook_A42355;

		// Token: 0x04001452 RID: 5202
		internal global::AcpUI.AcpLabel RadWideFeaturesTargetZoneOnOffHook_A42355Comp;

		// Token: 0x04001453 RID: 5203
		internal global::AcpUI.AcpCustomViewCheckBox CVBtnRadWideFeaturesTargetChanOnOffHook_A42356;

		// Token: 0x04001454 RID: 5204
		internal global::AcpUI.AcpLabel LblRadWideFeaturesTargetChanOnOffHook_A42356;

		// Token: 0x04001455 RID: 5205
		internal global::AcpUI.AcpComboBox RadWideFeaturesTargetChanOnOffHook_A42356;

		// Token: 0x04001456 RID: 5206
		internal global::AcpUI.AcpRtdButton RTDBtnRadWideFeaturesTargetChanOnOffHook_A42356;

		// Token: 0x04001457 RID: 5207
		internal global::AcpUI.AcpCopyButton CpyBtnRadWideFeaturesTargetChanOnOffHook_A42356;

		// Token: 0x04001458 RID: 5208
		internal global::AcpUI.AcpLabel RadWideFeaturesTargetChanOnOffHook_A42356Comp;

		// Token: 0x04001459 RID: 5209
		internal global::AcpUI.AcpGroupBox GrpBoxExpanderRadioWideFeaturesPseudo1;

		// Token: 0x0400145A RID: 5210
		internal global::AcpUI.AcpCustomViewCheckBox CVBtnRadWideTransmitPowerLevelsBandSplitOverride_A41064;

		// Token: 0x0400145B RID: 5211
		internal global::AcpUI.AcpLabel LblRadWideTransmitPowerLevelsBandSplitOverride_A41064;

		// Token: 0x0400145C RID: 5212
		internal global::AcpUI.AcpComboBox RadWideTransmitPowerLevelsBandSplitOverride_A41064;

		// Token: 0x0400145D RID: 5213
		internal global::AcpUI.AcpRtdButton RTDBtnRadWideTransmitPowerLevelsBandSplitOverride_A41064;

		// Token: 0x0400145E RID: 5214
		internal global::AcpUI.AcpCopyButton CpyBtnRadWideTransmitPowerLevelsBandSplitOverride_A41064;

		// Token: 0x0400145F RID: 5215
		internal global::AcpUI.AcpLabel RadWideTransmitPowerLevelsBandSplitOverride_A41064Comp;

		// Token: 0x04001460 RID: 5216
		internal global::AcpUI.AcpCustomViewCheckBox CVBtnRadWideFeaturesVoiceAbsenceTimer_42458;

		// Token: 0x04001461 RID: 5217
		internal global::AcpUI.AcpLabel LblRadWideFeaturesVoiceAbsenceTimer_42458;

		// Token: 0x04001462 RID: 5218
		internal global::AcpUI.AcpTextBoxSpinner RadWideFeaturesVoiceAbsenceTimer_42458;

		// Token: 0x04001463 RID: 5219
		internal global::AcpUI.AcpRtdButton RTDBtnRadWideFeaturesVoiceAbsenceTimer_42458;

		// Token: 0x04001464 RID: 5220
		internal global::AcpUI.AcpCopyButton CpyBtnRadWideFeaturesVoiceAbsenceTimer_42458;

		// Token: 0x04001465 RID: 5221
		internal global::AcpUI.AcpLabel RadWideFeaturesVoiceAbsenceTimer_42458Comp;

		// Token: 0x04001466 RID: 5222
		internal global::AcpUI.AcpCustomViewCheckBox CVBtnRadWideFeaturesExtRFRoute_A43020;

		// Token: 0x04001467 RID: 5223
		internal global::AcpUI.AcpLabel LblRadWideFeaturesExtRFRoute_A43020;

		// Token: 0x04001468 RID: 5224
		internal global::AcpUI.AcpComboBox RadWideFeaturesExtRFRoute_A43020;

		// Token: 0x04001469 RID: 5225
		internal global::AcpUI.AcpRtdButton RTDBtnRadWideFeaturesExtRFRoute_A43020;

		// Token: 0x0400146A RID: 5226
		internal global::AcpUI.AcpCopyButton CpyBtnRadWideFeaturesExtRFRoute_A43020;

		// Token: 0x0400146B RID: 5227
		internal global::AcpUI.AcpLabel RadWideFeaturesExtRFRoute_A43020Comp;

		// Token: 0x0400146C RID: 5228
		internal global::AcpUI.AcpCustomViewCheckBox CVBtnRadWideFeaturesRadioCertificationType_43064;

		// Token: 0x0400146D RID: 5229
		internal global::AcpUI.AcpLabel LblRadWideFeaturesRadioCertificationType_43064;

		// Token: 0x0400146E RID: 5230
		internal global::AcpUI.AcpComboBox RadWideFeaturesRadioCertificationType_43064;

		// Token: 0x0400146F RID: 5231
		internal global::AcpUI.AcpRtdButton RTDBtnRadWideFeaturesRadioCertificationType_43064;

		// Token: 0x04001470 RID: 5232
		internal global::AcpUI.AcpCopyButton CpyBtnRadWideFeaturesRadioCertificationType_43064;

		// Token: 0x04001471 RID: 5233
		internal global::AcpUI.AcpLabel RadWideFeaturesRadioCertificationType_43064Comp;

		// Token: 0x04001472 RID: 5234
		internal global::AcpUI.AcpCustomViewCheckBox CVBtnRadWideFeaturesRecordPlaybackAudioBufferSize_A43125;

		// Token: 0x04001473 RID: 5235
		internal global::AcpUI.AcpLabel LblRadWideFeaturesRecordPlaybackAudioBufferSize_A43125;

		// Token: 0x04001474 RID: 5236
		internal global::AcpUI.AcpTextBoxSpinner RadWideFeaturesRecordPlaybackAudioBufferSize_A43125;

		// Token: 0x04001475 RID: 5237
		internal global::AcpUI.AcpRtdButton RTDBtnRadWideFeaturesRecordPlaybackAudioBufferSize_A43125;

		// Token: 0x04001476 RID: 5238
		internal global::AcpUI.AcpCopyButton CpyBtnRadWideFeaturesRecordPlaybackAudioBufferSize_A43125;

		// Token: 0x04001477 RID: 5239
		internal global::AcpUI.AcpLabel RadWideFeaturesRecordPlaybackAudioBufferSize_A43125Comp;

		// Token: 0x04001478 RID: 5240
		internal global::AcpUI.AcpCustomViewCheckBox CVBtnRadWideFeaturesVoiceControlPriority;

		// Token: 0x04001479 RID: 5241
		internal global::AcpUI.AcpLabel LblRadWideFeaturesVoiceControlPriority;

		// Token: 0x0400147A RID: 5242
		internal global::AcpUI.AcpComboBox RadWideFeaturesVoiceControlPriority;

		// Token: 0x0400147B RID: 5243
		internal global::AcpUI.AcpRtdButton RTDBtnRadWideFeaturesVoiceControlPriority;

		// Token: 0x0400147C RID: 5244
		internal global::AcpUI.AcpCopyButton CpyBtnRadWideFeaturesVoiceControlPriority;

		// Token: 0x0400147D RID: 5245
		internal global::AcpUI.AcpLabel RadWideFeaturesVoiceControlPriorityComp;

		// Token: 0x0400147E RID: 5246
		internal global::AcpUI.AcpCustomViewCheckBox CVBtnRadErgoWideAdvancedModeSelTxName;

		// Token: 0x0400147F RID: 5247
		internal global::AcpUI.AcpLabel LblRadErgoWideAdvancedModeSelTxName;

		// Token: 0x04001480 RID: 5248
		internal global::AcpUI.AcpComboBox RadErgoWideAdvancedModeSelTxName;

		// Token: 0x04001481 RID: 5249
		internal global::AcpUI.AcpRtdButton RTDBtnRadErgoWideAdvancedModeSelTxName;

		// Token: 0x04001482 RID: 5250
		internal global::AcpUI.AcpCopyButton CpyBtnRadErgoWideAdvancedModeSelTxName;

		// Token: 0x04001483 RID: 5251
		internal global::AcpUI.AcpLabel RadErgoWideAdvancedModeSelTxNameComp;

		// Token: 0x04001484 RID: 5252
		internal global::AcpUI.AcpCustomViewCheckBox CVBtnRadCfgVirtualPartnerMode;

		// Token: 0x04001485 RID: 5253
		internal global::AcpUI.AcpLabel LblRadCfgVirtualPartnerMode;

		// Token: 0x04001486 RID: 5254
		internal global::AcpUI.AcpComboBox RadCfgVirtualPartnerMode;

		// Token: 0x04001487 RID: 5255
		internal global::AcpUI.AcpRtdButton RTDBtnRadCfgVirtualPartnerMode;

		// Token: 0x04001488 RID: 5256
		internal global::AcpUI.AcpCopyButton CpyBtnRadCfgVirtualPartnerMode;

		// Token: 0x04001489 RID: 5257
		internal global::AcpUI.AcpLabel RadCfgVirtualPartnerModeComp;

		// Token: 0x0400148A RID: 5258
		internal global::AcpUI.AcpCustomViewCheckBox CVBtnRadWideFeaturesVirtualPartnerAudioPriority;

		// Token: 0x0400148B RID: 5259
		internal global::AcpUI.AcpLabel LblRadWideFeaturesVirtualPartnerAudioPriority;

		// Token: 0x0400148C RID: 5260
		internal global::AcpUI.AcpComboBox RadWideFeaturesVirtualPartnerAudioPriority;

		// Token: 0x0400148D RID: 5261
		internal global::AcpUI.AcpRtdButton RTDBtnRadWideFeaturesVirtualPartnerAudioPriority;

		// Token: 0x0400148E RID: 5262
		internal global::AcpUI.AcpCopyButton CpyBtnRadWideFeaturesVirtualPartnerAudioPriority;

		// Token: 0x0400148F RID: 5263
		internal global::AcpUI.AcpLabel RadWideFeaturesVirtualPartnerAudioPriorityComp;

		// Token: 0x04001490 RID: 5264
		internal global::AcpUI.AcpCustomViewCheckBox CVBtnRadCfgVirtualPartnerInactivityTime;

		// Token: 0x04001491 RID: 5265
		internal global::AcpUI.AcpLabel LblRadCfgVirtualPartnerInactivityTime;

		// Token: 0x04001492 RID: 5266
		internal global::AcpUI.AcpTextBoxSpinner RadCfgVirtualPartnerInactivityTime;

		// Token: 0x04001493 RID: 5267
		internal global::AcpUI.AcpRtdButton RTDBtnRadCfgVirtualPartnerInactivityTime;

		// Token: 0x04001494 RID: 5268
		internal global::AcpUI.AcpCopyButton CpyBtnRadCfgVirtualPartnerInactivityTime;

		// Token: 0x04001495 RID: 5269
		internal global::AcpUI.AcpLabel RadCfgVirtualPartnerInactivityTimeComp;

		// Token: 0x04001496 RID: 5270
		internal global::AcpUI.AcpCustomViewCheckBox CVBtnRadWideFeaturesSmartMessagingSmartMessageMode;

		// Token: 0x04001497 RID: 5271
		internal global::AcpUI.AcpLabel LblRadWideFeaturesSmartMessagingSmartMessageMode;

		// Token: 0x04001498 RID: 5272
		internal global::AcpUI.AcpComboBox RadWideFeaturesSmartMessagingSmartMessageMode;

		// Token: 0x04001499 RID: 5273
		internal global::AcpUI.AcpRtdButton RTDBtnRadWideFeaturesSmartMessagingSmartMessageMode;

		// Token: 0x0400149A RID: 5274
		internal global::AcpUI.AcpCopyButton CpyBtnRadWideFeaturesSmartMessagingSmartMessageMode;

		// Token: 0x0400149B RID: 5275
		internal global::AcpUI.AcpLabel RadWideFeaturesSmartMessagingSmartMessageModeComp;

		// Token: 0x0400149C RID: 5276
		internal global::AcpUI.AcpCustomViewCheckBox CVBtnRadWideFeaturesPowerManagementStandbyTime;

		// Token: 0x0400149D RID: 5277
		internal global::AcpUI.AcpLabel LblRadWideFeaturesPowerManagementStandbyTime;

		// Token: 0x0400149E RID: 5278
		internal global::AcpUI.AcpTextBoxSpinner RadWideFeaturesPowerManagementStandbyTime;

		// Token: 0x0400149F RID: 5279
		internal global::AcpUI.AcpRtdButton RTDBtnRadWideFeaturesPowerManagementStandbyTime;

		// Token: 0x040014A0 RID: 5280
		internal global::AcpUI.AcpCopyButton CpyBtnRadWideFeaturesPowerManagementStandbyTime;

		// Token: 0x040014A1 RID: 5281
		internal global::AcpUI.AcpLabel RadWideFeaturesPowerManagementStandbyTimeComp;

		// Token: 0x040014A2 RID: 5282
		internal global::AcpUI.AcpCustomViewCheckBox CVBtnRadWideFeatureAnalogWidebandData;

		// Token: 0x040014A3 RID: 5283
		internal global::AcpUI.AcpLabel LblRadWideFeatureAnalogWidebandData;

		// Token: 0x040014A4 RID: 5284
		internal global::AcpUI.AcpCheckBox RadWideFeatureAnalogWidebandData;

		// Token: 0x040014A5 RID: 5285
		internal global::AcpUI.AcpRtdButton RTDBtnRadWideFeatureAnalogWidebandData;

		// Token: 0x040014A6 RID: 5286
		internal global::AcpUI.AcpCopyButton CpyBtnRadWideFeatureAnalogWidebandData;

		// Token: 0x040014A7 RID: 5287
		internal global::AcpUI.AcpCheckBox RadWideFeatureAnalogWidebandDataComp;

		// Token: 0x040014A8 RID: 5288
		internal global::AcpUI.AcpCustomViewCheckBox CVBtnRadWideFeaturesVLIFPLOSSFIELD_A9596;

		// Token: 0x040014A9 RID: 5289
		internal global::AcpUI.AcpLabel LblRadWideFeaturesVLIFPLOSSFIELD_A9596;

		// Token: 0x040014AA RID: 5290
		internal global::AcpUI.AcpComboBox RadWideFeaturesVLIFPLOSSFIELD_A9596;

		// Token: 0x040014AB RID: 5291
		internal global::AcpUI.AcpRtdButton RTDBtnRadWideFeaturesVLIFPLOSSFIELD_A9596;

		// Token: 0x040014AC RID: 5292
		internal global::AcpUI.AcpCopyButton CpyBtnRadWideFeaturesVLIFPLOSSFIELD_A9596;

		// Token: 0x040014AD RID: 5293
		internal global::AcpUI.AcpLabel RadWideFeaturesVLIFPLOSSFIELD_A9596Comp;

		// Token: 0x040014AE RID: 5294
		internal global::AcpUI.AcpCustomViewCheckBox CVBtnRadWideCustomLogoEnabled;

		// Token: 0x040014AF RID: 5295
		internal global::AcpUI.AcpLabel LblRadWideCustomLogoEnabled;

		// Token: 0x040014B0 RID: 5296
		internal global::AcpUI.AcpCheckBox RadWideCustomLogoEnabled;

		// Token: 0x040014B1 RID: 5297
		internal global::AcpUI.AcpRtdButton RTDBtnRadWideCustomLogoEnabled;

		// Token: 0x040014B2 RID: 5298
		internal global::AcpUI.AcpCopyButton CpyBtnRadWideCustomLogoEnabled;

		// Token: 0x040014B3 RID: 5299
		internal global::AcpUI.AcpCheckBox RadWideCustomLogoEnabledComp;

		// Token: 0x040014B4 RID: 5300
		internal global::AcpUI.AcpCustomViewCheckBox CVBtnRadWideFeaturesRadioInhibitUIEnabled_44914;

		// Token: 0x040014B5 RID: 5301
		internal global::AcpUI.AcpLabel LblRadWideFeaturesRadioInhibitUIEnabled_44914;

		// Token: 0x040014B6 RID: 5302
		internal global::AcpUI.AcpCheckBox RadWideFeaturesRadioInhibitUIEnabled_44914;

		// Token: 0x040014B7 RID: 5303
		internal global::AcpUI.AcpRtdButton RTDBtnRadWideFeaturesRadioInhibitUIEnabled_44914;

		// Token: 0x040014B8 RID: 5304
		internal global::AcpUI.AcpCopyButton CpyBtnRadWideFeaturesRadioInhibitUIEnabled_44914;

		// Token: 0x040014B9 RID: 5305
		internal global::AcpUI.AcpCheckBox RadWideFeaturesRadioInhibitUIEnabled_44914Comp;

		// Token: 0x040014BA RID: 5306
		internal global::AcpUI.AcpLabel CVBtnRadWideFeaturesRadioInhibitDisplayTextLine1_44915;

		// Token: 0x040014BB RID: 5307
		internal global::AcpUI.AcpTextBox RadWideFeaturesRadioInhibitDisplayTextLine1_44915;

		// Token: 0x040014BC RID: 5308
		internal global::AcpUI.AcpLabel CVBtnRadWideFeaturesRadioInhibitDisplayTextLine2_44916;

		// Token: 0x040014BD RID: 5309
		internal global::AcpUI.AcpTextBox RadWideFeaturesRadioInhibitDisplayTextLine2_44916;

		// Token: 0x040014BE RID: 5310
		internal global::AcpUI.AcpCustomViewCheckBox CVBtnRadWideFeaturesEnableInvalidSIMNotification_A44945;

		// Token: 0x040014BF RID: 5311
		internal global::AcpUI.AcpLabel LblRadWideFeaturesEnableInvalidSIMNotification_A44945;

		// Token: 0x040014C0 RID: 5312
		internal global::AcpUI.AcpCheckBox RadWideFeaturesEnableInvalidSIMNotification_A44945;

		// Token: 0x040014C1 RID: 5313
		internal global::AcpUI.AcpRtdButton RTDBtnRadWideFeaturesEnableInvalidSIMNotification_A44945;

		// Token: 0x040014C2 RID: 5314
		internal global::AcpUI.AcpCopyButton CpyBtnRadWideFeaturesEnableInvalidSIMNotification_A44945;

		// Token: 0x040014C3 RID: 5315
		internal global::AcpUI.AcpCheckBox RadWideFeaturesEnableInvalidSIMNotification_A44945Comp;

		// Token: 0x040014C4 RID: 5316
		internal global::AcpUI.AcpExpander ExpanderRadioWideDualRadio;

		// Token: 0x040014C5 RID: 5317
		internal global::AcpUI.AcpGroupBox GrpBoxExpanderRadioWideDualRadioPseudo0;

		// Token: 0x040014C6 RID: 5318
		internal global::AcpUI.AcpCustomViewCheckBox CVBtnRadWideDualRadioSelection_A42236;

		// Token: 0x040014C7 RID: 5319
		internal global::AcpUI.AcpLabel LblRadWideDualRadioSelection_A42236;

		// Token: 0x040014C8 RID: 5320
		internal global::AcpUI.AcpComboBox RadWideDualRadioSelection_A42236;

		// Token: 0x040014C9 RID: 5321
		internal global::AcpUI.AcpRtdButton RTDBtnRadWideDualRadioSelection_A42236;

		// Token: 0x040014CA RID: 5322
		internal global::AcpUI.AcpCopyButton CpyBtnRadWideDualRadioSelection_A42236;

		// Token: 0x040014CB RID: 5323
		internal global::AcpUI.AcpLabel RadWideDualRadioSelection_A42236Comp;

		// Token: 0x040014CC RID: 5324
		internal global::AcpUI.AcpCustomViewCheckBox CVBtnRadWideDualRadioEmergencyRadio_A42239;

		// Token: 0x040014CD RID: 5325
		internal global::AcpUI.AcpLabel LblRadWideDualRadioEmergencyRadio_A42239;

		// Token: 0x040014CE RID: 5326
		internal global::AcpUI.AcpComboBox RadWideDualRadioEmergencyRadio_A42239;

		// Token: 0x040014CF RID: 5327
		internal global::AcpUI.AcpRtdButton RTDBtnRadWideDualRadioEmergencyRadio_A42239;

		// Token: 0x040014D0 RID: 5328
		internal global::AcpUI.AcpCopyButton CpyBtnRadWideDualRadioEmergencyRadio_A42239;

		// Token: 0x040014D1 RID: 5329
		internal global::AcpUI.AcpLabel RadWideDualRadioEmergencyRadio_A42239Comp;

		// Token: 0x040014D2 RID: 5330
		internal global::AcpUI.AcpCustomViewCheckBox CVBtnRadWideDualRadioTalkgroupMuteOption_A42290;

		// Token: 0x040014D3 RID: 5331
		internal global::AcpUI.AcpLabel LblRadWideDualRadioTalkgroupMuteOption_A42290;

		// Token: 0x040014D4 RID: 5332
		internal global::AcpUI.AcpComboBox RadWideDualRadioTalkgroupMuteOption_A42290;

		// Token: 0x040014D5 RID: 5333
		internal global::AcpUI.AcpRtdButton RTDBtnRadWideDualRadioTalkgroupMuteOption_A42290;

		// Token: 0x040014D6 RID: 5334
		internal global::AcpUI.AcpCopyButton CpyBtnRadWideDualRadioTalkgroupMuteOption_A42290;

		// Token: 0x040014D7 RID: 5335
		internal global::AcpUI.AcpLabel RadWideDualRadioTalkgroupMuteOption_A42290Comp;

		// Token: 0x040014D8 RID: 5336
		internal global::AcpUI.AcpCustomViewCheckBox CVBtnRadWideDualRadioSecRadioTransmissionCapability_A42238;

		// Token: 0x040014D9 RID: 5337
		internal global::AcpUI.AcpLabel LblRadWideDualRadioSecRadioTransmissionCapability_A42238;

		// Token: 0x040014DA RID: 5338
		internal global::AcpUI.AcpCheckBox RadWideDualRadioSecRadioTransmissionCapability_A42238;

		// Token: 0x040014DB RID: 5339
		internal global::AcpUI.AcpRtdButton RTDBtnRadWideDualRadioSecRadioTransmissionCapability_A42238;

		// Token: 0x040014DC RID: 5340
		internal global::AcpUI.AcpCopyButton CpyBtnRadWideDualRadioSecRadioTransmissionCapability_A42238;

		// Token: 0x040014DD RID: 5341
		internal global::AcpUI.AcpCheckBox RadWideDualRadioSecRadioTransmissionCapability_A42238Comp;

		// Token: 0x040014DE RID: 5342
		internal global::AcpUI.AcpCustomViewCheckBox CVBtnRadWideDualRadioCrossBandMuteOption_A42240;

		// Token: 0x040014DF RID: 5343
		internal global::AcpUI.AcpLabel LblRadWideDualRadioCrossBandMuteOption_A42240;

		// Token: 0x040014E0 RID: 5344
		internal global::AcpUI.AcpCheckBox RadWideDualRadioCrossBandMuteOption_A42240;

		// Token: 0x040014E1 RID: 5345
		internal global::AcpUI.AcpRtdButton RTDBtnRadWideDualRadioCrossBandMuteOption_A42240;

		// Token: 0x040014E2 RID: 5346
		internal global::AcpUI.AcpCopyButton CpyBtnRadWideDualRadioCrossBandMuteOption_A42240;

		// Token: 0x040014E3 RID: 5347
		internal global::AcpUI.AcpCheckBox RadWideDualRadioCrossBandMuteOption_A42240Comp;

		// Token: 0x040014E4 RID: 5348
		internal global::AcpUI.AcpCustomViewCheckBox CVBtnRadWideDualRadioFixedRadioSwapMenu_A42241;

		// Token: 0x040014E5 RID: 5349
		internal global::AcpUI.AcpLabel LblRadWideDualRadioFixedRadioSwapMenu_A42241;

		// Token: 0x040014E6 RID: 5350
		internal global::AcpUI.AcpCheckBox RadWideDualRadioFixedRadioSwapMenu_A42241;

		// Token: 0x040014E7 RID: 5351
		internal global::AcpUI.AcpRtdButton RTDBtnRadWideDualRadioFixedRadioSwapMenu_A42241;

		// Token: 0x040014E8 RID: 5352
		internal global::AcpUI.AcpCopyButton CpyBtnRadWideDualRadioFixedRadioSwapMenu_A42241;

		// Token: 0x040014E9 RID: 5353
		internal global::AcpUI.AcpCheckBox RadWideDualRadioFixedRadioSwapMenu_A42241Comp;

		// Token: 0x040014EA RID: 5354
		internal global::AcpUI.AcpCustomViewCheckBox CVBtnRadDualRadioFatalErrorOption_A42243;

		// Token: 0x040014EB RID: 5355
		internal global::AcpUI.AcpLabel LblRadDualRadioFatalErrorOption_A42243;

		// Token: 0x040014EC RID: 5356
		internal global::AcpUI.AcpLabel RadDualRadioFatalErrorOption_A42243;

		// Token: 0x040014ED RID: 5357
		internal global::AcpUI.AcpRtdButton RTDBtnRadDualRadioFatalErrorOption_A42243;

		// Token: 0x040014EE RID: 5358
		internal global::AcpUI.AcpCopyButton CpyBtnRadDualRadioFatalErrorOption_A42243;

		// Token: 0x040014EF RID: 5359
		internal global::AcpUI.AcpLabel RadDualRadioFatalErrorOption_A42243Comp;

		// Token: 0x040014F0 RID: 5360
		internal global::AcpUI.AcpCustomViewCheckBox CVBtnMultiRadioSystemEnable_A42248;

		// Token: 0x040014F1 RID: 5361
		internal global::AcpUI.AcpLabel LblMultiRadioSystemEnable_A42248;

		// Token: 0x040014F2 RID: 5362
		internal global::AcpUI.AcpLabel MultiRadioSystemEnable_A42248;

		// Token: 0x040014F3 RID: 5363
		internal global::AcpUI.AcpRtdButton RTDBtnMultiRadioSystemEnable_A42248;

		// Token: 0x040014F4 RID: 5364
		internal global::AcpUI.AcpCopyButton CpyBtnMultiRadioSystemEnable_A42248;

		// Token: 0x040014F5 RID: 5365
		internal global::AcpUI.AcpLabel MultiRadioSystemEnable_A42248Comp;

		// Token: 0x040014F6 RID: 5366
		internal global::AcpUI.AcpExpander ExpanderRadioWideLocation;

		// Token: 0x040014F7 RID: 5367
		internal global::AcpUI.AcpGroupBox GrpBoxExpanderRadioWideLocationPseudo0;

		// Token: 0x040014F8 RID: 5368
		internal global::AcpUI.AcpCustomViewCheckBox CVBtnRadWideLocationLocationEnable_A8448;

		// Token: 0x040014F9 RID: 5369
		internal global::AcpUI.AcpLabel LblRadWideLocationLocationEnable_A8448;

		// Token: 0x040014FA RID: 5370
		internal global::AcpUI.AcpCheckBox RadWideLocationLocationEnable_A8448;

		// Token: 0x040014FB RID: 5371
		internal global::AcpUI.AcpRtdButton RTDBtnRadWideLocationLocationEnable_A8448;

		// Token: 0x040014FC RID: 5372
		internal global::AcpUI.AcpCopyButton CpyBtnRadWideLocationLocationEnable_A8448;

		// Token: 0x040014FD RID: 5373
		internal global::AcpUI.AcpCheckBox RadWideLocationLocationEnable_A8448Comp;

		// Token: 0x040014FE RID: 5374
		internal global::AcpUI.AcpCustomViewCheckBox CVBtnRadWideLocationUserSelectableLocationEnable_A9605;

		// Token: 0x040014FF RID: 5375
		internal global::AcpUI.AcpLabel LblRadWideLocationUserSelectableLocationEnable_A9605;

		// Token: 0x04001500 RID: 5376
		internal global::AcpUI.AcpCheckBox RadWideLocationUserSelectableLocationEnable_A9605;

		// Token: 0x04001501 RID: 5377
		internal global::AcpUI.AcpRtdButton RTDBtnRadWideLocationUserSelectableLocationEnable_A9605;

		// Token: 0x04001502 RID: 5378
		internal global::AcpUI.AcpCopyButton CpyBtnRadWideLocationUserSelectableLocationEnable_A9605;

		// Token: 0x04001503 RID: 5379
		internal global::AcpUI.AcpCheckBox RadWideLocationUserSelectableLocationEnable_A9605Comp;

		// Token: 0x04001504 RID: 5380
		internal global::AcpUI.AcpCustomViewCheckBox CVBtnRadWideLocationGpsMode_A22627;

		// Token: 0x04001505 RID: 5381
		internal global::AcpUI.AcpLabel LblRadWideLocationGpsMode_A22627;

		// Token: 0x04001506 RID: 5382
		internal global::AcpUI.AcpComboBox RadWideLocationGpsMode_A22627;

		// Token: 0x04001507 RID: 5383
		internal global::AcpUI.AcpRtdButton RTDBtnRadWideLocationGpsMode_A22627;

		// Token: 0x04001508 RID: 5384
		internal global::AcpUI.AcpCopyButton CpyBtnRadWideLocationGpsMode_A22627;

		// Token: 0x04001509 RID: 5385
		internal global::AcpUI.AcpLabel RadWideLocationGpsMode_A22627Comp;

		// Token: 0x0400150A RID: 5386
		internal global::AcpUI.AcpCustomViewCheckBox CVBtnRadWideLocationDisplayPeerLocation_42433;

		// Token: 0x0400150B RID: 5387
		internal global::AcpUI.AcpLabel LblRadWideLocationDisplayPeerLocation_42433;

		// Token: 0x0400150C RID: 5388
		internal global::AcpUI.AcpCheckBox RadWideLocationDisplayPeerLocation_42433;

		// Token: 0x0400150D RID: 5389
		internal global::AcpUI.AcpRtdButton RTDBtnRadWideLocationDisplayPeerLocation_42433;

		// Token: 0x0400150E RID: 5390
		internal global::AcpUI.AcpCopyButton CpyBtnRadWideLocationDisplayPeerLocation_42433;

		// Token: 0x0400150F RID: 5391
		internal global::AcpUI.AcpCheckBox RadWideLocationDisplayPeerLocation_42433Comp;

		// Token: 0x04001510 RID: 5392
		internal global::AcpUI.AcpCustomViewCheckBox CVBtnRadWideLocationMaxStoredLocationRequests_A8473;

		// Token: 0x04001511 RID: 5393
		internal global::AcpUI.AcpLabel LblRadWideLocationMaxStoredLocationRequests_A8473;

		// Token: 0x04001512 RID: 5394
		internal global::AcpUI.AcpTextBoxSpinner RadWideLocationMaxStoredLocationRequests_A8473;

		// Token: 0x04001513 RID: 5395
		internal global::AcpUI.AcpRtdButton RTDBtnRadWideLocationMaxStoredLocationRequests_A8473;

		// Token: 0x04001514 RID: 5396
		internal global::AcpUI.AcpCopyButton CpyBtnRadWideLocationMaxStoredLocationRequests_A8473;

		// Token: 0x04001515 RID: 5397
		internal global::AcpUI.AcpLabel RadWideLocationMaxStoredLocationRequests_A8473Comp;

		// Token: 0x04001516 RID: 5398
		internal global::AcpUI.AcpCustomViewCheckBox CVBtnRadWideLocationDisplayFormat_A41561;

		// Token: 0x04001517 RID: 5399
		internal global::AcpUI.AcpLabel LblRadWideLocationDisplayFormat_A41561;

		// Token: 0x04001518 RID: 5400
		internal global::AcpUI.AcpComboBox RadWideLocationDisplayFormat_A41561;

		// Token: 0x04001519 RID: 5401
		internal global::AcpUI.AcpRtdButton RTDBtnRadWideLocationDisplayFormat_A41561;

		// Token: 0x0400151A RID: 5402
		internal global::AcpUI.AcpCopyButton CpyBtnRadWideLocationDisplayFormat_A41561;

		// Token: 0x0400151B RID: 5403
		internal global::AcpUI.AcpLabel RadWideLocationDisplayFormat_A41561Comp;

		// Token: 0x0400151C RID: 5404
		internal global::AcpUI.AcpCustomViewCheckBox CVBtnRadWideLocationDistanceUnit_A13080;

		// Token: 0x0400151D RID: 5405
		internal global::AcpUI.AcpLabel LblRadWideLocationDistanceUnit_A13080;

		// Token: 0x0400151E RID: 5406
		internal global::AcpUI.AcpComboBox RadWideLocationDistanceUnit_A13080;

		// Token: 0x0400151F RID: 5407
		internal global::AcpUI.AcpRtdButton RTDBtnRadWideLocationDistanceUnit_A13080;

		// Token: 0x04001520 RID: 5408
		internal global::AcpUI.AcpCopyButton CpyBtnRadWideLocationDistanceUnit_A13080;

		// Token: 0x04001521 RID: 5409
		internal global::AcpUI.AcpLabel RadWideLocationDistanceUnit_A13080Comp;

		// Token: 0x04001522 RID: 5410
		internal global::AcpUI.AcpCustomViewCheckBox CVBtnRadWideLocationExitLocationMenuonPTT_A13081;

		// Token: 0x04001523 RID: 5411
		internal global::AcpUI.AcpLabel LblRadWideLocationExitLocationMenuonPTT_A13081;

		// Token: 0x04001524 RID: 5412
		internal global::AcpUI.AcpCheckBox RadWideLocationExitLocationMenuonPTT_A13081;

		// Token: 0x04001525 RID: 5413
		internal global::AcpUI.AcpRtdButton RTDBtnRadWideLocationExitLocationMenuonPTT_A13081;

		// Token: 0x04001526 RID: 5414
		internal global::AcpUI.AcpCopyButton CpyBtnRadWideLocationExitLocationMenuonPTT_A13081;

		// Token: 0x04001527 RID: 5415
		internal global::AcpUI.AcpCheckBox RadWideLocationExitLocationMenuonPTT_A13081Comp;

		// Token: 0x04001528 RID: 5416
		internal global::AcpUI.AcpCustomViewCheckBox CVBtnGPSFailToneInterval_42329;

		// Token: 0x04001529 RID: 5417
		internal global::AcpUI.AcpLabel LblGPSFailToneInterval_42329;

		// Token: 0x0400152A RID: 5418
		internal global::AcpUI.AcpTextBoxSpinner GPSFailToneInterval_42329;

		// Token: 0x0400152B RID: 5419
		internal global::AcpUI.AcpRtdButton RTDBtnGPSFailToneInterval_42329;

		// Token: 0x0400152C RID: 5420
		internal global::AcpUI.AcpCopyButton CpyBtnGPSFailToneInterval_42329;

		// Token: 0x0400152D RID: 5421
		internal global::AcpUI.AcpLabel GPSFailToneInterval_42329Comp;

		// Token: 0x0400152E RID: 5422
		internal global::AcpUI.AcpCustomViewCheckBox CVBtnRadWideLocP25LocationReporting_42412;

		// Token: 0x0400152F RID: 5423
		internal global::AcpUI.AcpLabel LblRadWideLocP25LocationReporting_42412;

		// Token: 0x04001530 RID: 5424
		internal global::AcpUI.AcpCheckBox RadWideLocP25LocationReporting_42412;

		// Token: 0x04001531 RID: 5425
		internal global::AcpUI.AcpRtdButton RTDBtnRadWideLocP25LocationReporting_42412;

		// Token: 0x04001532 RID: 5426
		internal global::AcpUI.AcpCopyButton CpyBtnRadWideLocP25LocationReporting_42412;

		// Token: 0x04001533 RID: 5427
		internal global::AcpUI.AcpCheckBox RadWideLocP25LocationReporting_42412Comp;

		// Token: 0x04001534 RID: 5428
		internal global::AcpUI.AcpCustomViewCheckBox CVBtnRadioErgoConfigACMissionCriticalGeofenceMode_42918;

		// Token: 0x04001535 RID: 5429
		internal global::AcpUI.AcpLabel LblRadioErgoConfigACMissionCriticalGeofenceMode_42918;

		// Token: 0x04001536 RID: 5430
		internal global::AcpUI.AcpComboBox RadioErgoConfigACMissionCriticalGeofenceMode_42918;

		// Token: 0x04001537 RID: 5431
		internal global::AcpUI.AcpRtdButton RTDBtnRadioErgoConfigACMissionCriticalGeofenceMode_42918;

		// Token: 0x04001538 RID: 5432
		internal global::AcpUI.AcpCopyButton CpyBtnRadioErgoConfigACMissionCriticalGeofenceMode_42918;

		// Token: 0x04001539 RID: 5433
		internal global::AcpUI.AcpLabel RadioErgoConfigACMissionCriticalGeofenceMode_42918Comp;

		// Token: 0x0400153A RID: 5434
		internal global::AcpUI.AcpCustomViewCheckBox CVBtnRadWideLocationSystemManagedGeofence_43042;

		// Token: 0x0400153B RID: 5435
		internal global::AcpUI.AcpLabel LblRadWideLocationSystemManagedGeofence_43042;

		// Token: 0x0400153C RID: 5436
		internal global::AcpUI.AcpCheckBox RadWideLocationSystemManagedGeofence_43042;

		// Token: 0x0400153D RID: 5437
		internal global::AcpUI.AcpRtdButton RTDBtnRadWideLocationSystemManagedGeofence_43042;

		// Token: 0x0400153E RID: 5438
		internal global::AcpUI.AcpCopyButton CpyBtnRadWideLocationSystemManagedGeofence_43042;

		// Token: 0x0400153F RID: 5439
		internal global::AcpUI.AcpCheckBox RadWideLocationSystemManagedGeofence_43042Comp;

		// Token: 0x04001540 RID: 5440
		internal global::AcpUI.AcpCustomViewCheckBox CVBtnRadWideFeaturesMapping;

		// Token: 0x04001541 RID: 5441
		internal global::AcpUI.AcpLabel LblRadWideFeaturesMapping;

		// Token: 0x04001542 RID: 5442
		internal global::AcpUI.AcpComboBox RadWideFeaturesMapping;

		// Token: 0x04001543 RID: 5443
		internal global::AcpUI.AcpRtdButton RTDBtnRadWideFeaturesMapping;

		// Token: 0x04001544 RID: 5444
		internal global::AcpUI.AcpCopyButton CpyBtnRadWideFeaturesMapping;

		// Token: 0x04001545 RID: 5445
		internal global::AcpUI.AcpLabel RadWideFeaturesMappingComp;

		// Token: 0x04001546 RID: 5446
		internal global::AcpUI.AcpCustomViewCheckBox CVBtnRadWideSmartMappingServerAssistedLocation;

		// Token: 0x04001547 RID: 5447
		internal global::AcpUI.AcpLabel LblRadWideSmartMappingServerAssistedLocation;

		// Token: 0x04001548 RID: 5448
		internal global::AcpUI.AcpCheckBox RadWideSmartMappingServerAssistedLocation;

		// Token: 0x04001549 RID: 5449
		internal global::AcpUI.AcpRtdButton RTDBtnRadWideSmartMappingServerAssistedLocation;

		// Token: 0x0400154A RID: 5450
		internal global::AcpUI.AcpCopyButton CpyBtnRadWideSmartMappingServerAssistedLocation;

		// Token: 0x0400154B RID: 5451
		internal global::AcpUI.AcpCheckBox RadWideSmartMappingServerAssistedLocationComp;

		// Token: 0x0400154C RID: 5452
		internal global::AcpUI.AcpCustomViewCheckBox CVBtnRadWideReverseGeocodedLocationDisplayFormat;

		// Token: 0x0400154D RID: 5453
		internal global::AcpUI.AcpLabel LblRadWideReverseGeocodedLocationDisplayFormat;

		// Token: 0x0400154E RID: 5454
		internal global::AcpUI.AcpComboBox RadWideReverseGeocodedLocationDisplayFormat;

		// Token: 0x0400154F RID: 5455
		internal global::AcpUI.AcpRtdButton RTDBtnRadWideReverseGeocodedLocationDisplayFormat;

		// Token: 0x04001550 RID: 5456
		internal global::AcpUI.AcpCopyButton CpyBtnRadWideReverseGeocodedLocationDisplayFormat;

		// Token: 0x04001551 RID: 5457
		internal global::AcpUI.AcpLabel RadWideReverseGeocodedLocationDisplayFormatComp;

		// Token: 0x04001552 RID: 5458
		internal global::AcpUI.AcpCustomViewCheckBox CVBtnRadCfgLocationReporting;

		// Token: 0x04001553 RID: 5459
		internal global::AcpUI.AcpLabel LblRadCfgLocationReporting;

		// Token: 0x04001554 RID: 5460
		internal global::AcpUI.AcpComboBox RadCfgLocationReporting;

		// Token: 0x04001555 RID: 5461
		internal global::AcpUI.AcpRtdButton RTDBtnRadCfgLocationReporting;

		// Token: 0x04001556 RID: 5462
		internal global::AcpUI.AcpCopyButton CpyBtnRadCfgLocationReporting;

		// Token: 0x04001557 RID: 5463
		internal global::AcpUI.AcpLabel RadCfgLocationReportingComp;

		// Token: 0x04001558 RID: 5464
		internal global::AcpUI.AcpExpander ExpanderRadioWideDigitalAudioOptions;

		// Token: 0x04001559 RID: 5465
		internal global::AcpUI.AcpGroupBox GrpBoxExpanderRadioWideDigitalAudioOptionsDigitalOutboundIndicators;

		// Token: 0x0400155A RID: 5466
		internal global::AcpUI.AcpCustomViewCheckBox CVBtnRadWideDigitalAudioOptionsStrongInterference1_A9207;

		// Token: 0x0400155B RID: 5467
		internal global::AcpUI.AcpLabel LblRadWideDigitalAudioOptionsStrongInterference1_A9207;

		// Token: 0x0400155C RID: 5468
		internal global::AcpUI.AcpCheckBox RadWideDigitalAudioOptionsStrongInterference1_A9207;

		// Token: 0x0400155D RID: 5469
		internal global::AcpUI.AcpRtdButton RTDBtnRadWideDigitalAudioOptionsStrongInterference1_A9207;

		// Token: 0x0400155E RID: 5470
		internal global::AcpUI.AcpCopyButton CpyBtnRadWideDigitalAudioOptionsStrongInterference1_A9207;

		// Token: 0x0400155F RID: 5471
		internal global::AcpUI.AcpCheckBox RadWideDigitalAudioOptionsStrongInterference1_A9207Comp;

		// Token: 0x04001560 RID: 5472
		internal global::AcpUI.AcpCustomViewCheckBox CVBtnRadWideDigitalAudioOptionsWeakSignalFringe_A9679;

		// Token: 0x04001561 RID: 5473
		internal global::AcpUI.AcpLabel LblRadWideDigitalAudioOptionsWeakSignalFringe_A9679;

		// Token: 0x04001562 RID: 5474
		internal global::AcpUI.AcpCheckBox RadWideDigitalAudioOptionsWeakSignalFringe_A9679;

		// Token: 0x04001563 RID: 5475
		internal global::AcpUI.AcpRtdButton RTDBtnRadWideDigitalAudioOptionsWeakSignalFringe_A9679;

		// Token: 0x04001564 RID: 5476
		internal global::AcpUI.AcpCopyButton CpyBtnRadWideDigitalAudioOptionsWeakSignalFringe_A9679;

		// Token: 0x04001565 RID: 5477
		internal global::AcpUI.AcpCheckBox RadWideDigitalAudioOptionsWeakSignalFringe_A9679Comp;

		// Token: 0x04001566 RID: 5478
		internal global::AcpUI.AcpGroupBox GrpBoxExpanderRadioWideDigitalAudioOptionsDigitalInboundIndicators;

		// Token: 0x04001567 RID: 5479
		internal global::AcpUI.AcpCustomViewCheckBox CVBtnRadWideDigitalAudioOptionsStrongInterference2_A9206;

		// Token: 0x04001568 RID: 5480
		internal global::AcpUI.AcpLabel LblRadWideDigitalAudioOptionsStrongInterference2_A9206;

		// Token: 0x04001569 RID: 5481
		internal global::AcpUI.AcpCheckBox RadWideDigitalAudioOptionsStrongInterference2_A9206;

		// Token: 0x0400156A RID: 5482
		internal global::AcpUI.AcpRtdButton RTDBtnRadWideDigitalAudioOptionsStrongInterference2_A9206;

		// Token: 0x0400156B RID: 5483
		internal global::AcpUI.AcpCopyButton CpyBtnRadWideDigitalAudioOptionsStrongInterference2_A9206;

		// Token: 0x0400156C RID: 5484
		internal global::AcpUI.AcpCheckBox RadWideDigitalAudioOptionsStrongInterference2_A9206Comp;

		// Token: 0x0400156D RID: 5485
		internal global::AcpUI.AcpCustomViewCheckBox CVBtnRadWideDigitalAudioOptionsWeakSignalFringe_A9678;

		// Token: 0x0400156E RID: 5486
		internal global::AcpUI.AcpLabel LblRadWideDigitalAudioOptionsWeakSignalFringe_A9678;

		// Token: 0x0400156F RID: 5487
		internal global::AcpUI.AcpCheckBox RadWideDigitalAudioOptionsWeakSignalFringe_A9678;

		// Token: 0x04001570 RID: 5488
		internal global::AcpUI.AcpRtdButton RTDBtnRadWideDigitalAudioOptionsWeakSignalFringe_A9678;

		// Token: 0x04001571 RID: 5489
		internal global::AcpUI.AcpCopyButton CpyBtnRadWideDigitalAudioOptionsWeakSignalFringe_A9678;

		// Token: 0x04001572 RID: 5490
		internal global::AcpUI.AcpCheckBox RadWideDigitalAudioOptionsWeakSignalFringe_A9678Comp;

		// Token: 0x04001573 RID: 5491
		internal global::AcpUI.AcpGroupBox GrpBoxExpanderRadioWideDigitalAudioOptionsPseudo2;

		// Token: 0x04001574 RID: 5492
		internal global::AcpUI.AcpCustomViewCheckBox CVBtnRadWideRxAudioControlMidrangeEqualization_A8508;

		// Token: 0x04001575 RID: 5493
		internal global::AcpUI.AcpLabel LblRadWideRxAudioControlMidrangeEqualization_A8508;

		// Token: 0x04001576 RID: 5494
		internal global::AcpUI.AcpCheckBox RadWideRxAudioControlMidrangeEqualization_A8508;

		// Token: 0x04001577 RID: 5495
		internal global::AcpUI.AcpRtdButton RTDBtnRadWideRxAudioControlMidrangeEqualization_A8508;

		// Token: 0x04001578 RID: 5496
		internal global::AcpUI.AcpCopyButton CpyBtnRadWideRxAudioControlMidrangeEqualization_A8508;

		// Token: 0x04001579 RID: 5497
		internal global::AcpUI.AcpCheckBox RadWideRxAudioControlMidrangeEqualization_A8508Comp;

		// Token: 0x0400157A RID: 5498
		internal global::AcpUI.AcpCustomViewCheckBox CVBtnRadWideLabtoolMultipleConversationDisable_A19552;

		// Token: 0x0400157B RID: 5499
		internal global::AcpUI.AcpLabel LblRadWideLabtoolMultipleConversationDisable_A19552;

		// Token: 0x0400157C RID: 5500
		internal global::AcpUI.AcpCheckBox RadWideLabtoolMultipleConversationDisable_A19552;

		// Token: 0x0400157D RID: 5501
		internal global::AcpUI.AcpRtdButton RTDBtnRadWideLabtoolMultipleConversationDisable_A19552;

		// Token: 0x0400157E RID: 5502
		internal global::AcpUI.AcpCopyButton CpyBtnRadWideLabtoolMultipleConversationDisable_A19552;

		// Token: 0x0400157F RID: 5503
		internal global::AcpUI.AcpCheckBox RadWideLabtoolMultipleConversationDisable_A19552Comp;

		// Token: 0x04001580 RID: 5504
		internal global::AcpUI.AcpCustomViewCheckBox CVBtnRadWideLabtoolDigitalAnalogBalance_A7851;

		// Token: 0x04001581 RID: 5505
		internal global::AcpUI.AcpLabel LblRadWideLabtoolDigitalAnalogBalance_A7851;

		// Token: 0x04001582 RID: 5506
		internal global::AcpUI.AcpComboBox RadWideLabtoolDigitalAnalogBalance_A7851;

		// Token: 0x04001583 RID: 5507
		internal global::AcpUI.AcpRtdButton RTDBtnRadWideLabtoolDigitalAnalogBalance_A7851;

		// Token: 0x04001584 RID: 5508
		internal global::AcpUI.AcpCopyButton CpyBtnRadWideLabtoolDigitalAnalogBalance_A7851;

		// Token: 0x04001585 RID: 5509
		internal global::AcpUI.AcpLabel RadWideLabtoolDigitalAnalogBalance_A7851Comp;

		// Token: 0x04001586 RID: 5510
		internal global::AcpUI.AcpCustomViewCheckBox CVBtnRadWideAdvancedAuxPTTAudioSource_A7529;

		// Token: 0x04001587 RID: 5511
		internal global::AcpUI.AcpLabel LblRadWideAdvancedAuxPTTAudioSource_A7529;

		// Token: 0x04001588 RID: 5512
		internal global::AcpUI.AcpComboBox RadWideAdvancedAuxPTTAudioSource_A7529;

		// Token: 0x04001589 RID: 5513
		internal global::AcpUI.AcpRtdButton RTDBtnRadWideAdvancedAuxPTTAudioSource_A7529;

		// Token: 0x0400158A RID: 5514
		internal global::AcpUI.AcpCopyButton CpyBtnRadWideAdvancedAuxPTTAudioSource_A7529;

		// Token: 0x0400158B RID: 5515
		internal global::AcpUI.AcpLabel RadWideAdvancedAuxPTTAudioSource_A7529Comp;

		// Token: 0x0400158C RID: 5516
		internal global::AcpUI.AcpCustomViewCheckBox CVBtnAdvancedAuxTransmitSensitivity_A7530;

		// Token: 0x0400158D RID: 5517
		internal global::AcpUI.AcpLabel LblAdvancedAuxTransmitSensitivity_A7530;

		// Token: 0x0400158E RID: 5518
		internal global::AcpUI.AcpComboBox AdvancedAuxTransmitSensitivity_A7530;

		// Token: 0x0400158F RID: 5519
		internal global::AcpUI.AcpRtdButton RTDBtnAdvancedAuxTransmitSensitivity_A7530;

		// Token: 0x04001590 RID: 5520
		internal global::AcpUI.AcpCopyButton CpyBtnAdvancedAuxTransmitSensitivity_A7530;

		// Token: 0x04001591 RID: 5521
		internal global::AcpUI.AcpLabel AdvancedAuxTransmitSensitivity_A7530Comp;

		// Token: 0x04001592 RID: 5522
		internal global::AcpUI.AcpCustomViewCheckBox CVBtnRadWideAudioConfigurationLevel_42740;

		// Token: 0x04001593 RID: 5523
		internal global::AcpUI.AcpLabel LblRadWideAudioConfigurationLevel_42740;

		// Token: 0x04001594 RID: 5524
		internal global::AcpUI.AcpComboBox RadWideAudioConfigurationLevel_42740;

		// Token: 0x04001595 RID: 5525
		internal global::AcpUI.AcpRtdButton RTDBtnRadWideAudioConfigurationLevel_42740;

		// Token: 0x04001596 RID: 5526
		internal global::AcpUI.AcpCopyButton CpyBtnRadWideAudioConfigurationLevel_42740;

		// Token: 0x04001597 RID: 5527
		internal global::AcpUI.AcpLabel RadWideAudioConfigurationLevel_42740Comp;

		// Token: 0x04001598 RID: 5528
		internal global::AcpUI.AcpCustomViewCheckBox CVBtnRadWideCombineTxWithRxFilteredAudio_44808;

		// Token: 0x04001599 RID: 5529
		internal global::AcpUI.AcpLabel LblRadWideCombineTxWithRxFilteredAudio_44808;

		// Token: 0x0400159A RID: 5530
		internal global::AcpUI.AcpCheckBox RadWideCombineTxWithRxFilteredAudio_44808;

		// Token: 0x0400159B RID: 5531
		internal global::AcpUI.AcpRtdButton RTDBtnRadWideCombineTxWithRxFilteredAudio_44808;

		// Token: 0x0400159C RID: 5532
		internal global::AcpUI.AcpCopyButton CpyBtnRadWideCombineTxWithRxFilteredAudio_44808;

		// Token: 0x0400159D RID: 5533
		internal global::AcpUI.AcpCheckBox RadWideCombineTxWithRxFilteredAudio_44808Comp;

		// Token: 0x0400159E RID: 5534
		internal global::AcpUI.AcpCustomViewCheckBox CVBtnRadWideAudioOptionsSelectBluetoothMicForAuxPTTAudioSource_44819;

		// Token: 0x0400159F RID: 5535
		internal global::AcpUI.AcpLabel LblRadWideAudioOptionsSelectBluetoothMicForAuxPTTAudioSource_44819;

		// Token: 0x040015A0 RID: 5536
		internal global::AcpUI.AcpCheckBox RadWideAudioOptionsSelectBluetoothMicForAuxPTTAudioSource_44819;

		// Token: 0x040015A1 RID: 5537
		internal global::AcpUI.AcpRtdButton RTDBtnRadWideAudioOptionsSelectBluetoothMicForAuxPTTAudioSource_44819;

		// Token: 0x040015A2 RID: 5538
		internal global::AcpUI.AcpCopyButton CpyBtnRadWideAudioOptionsSelectBluetoothMicForAuxPTTAudioSource_44819;

		// Token: 0x040015A3 RID: 5539
		internal global::AcpUI.AcpCheckBox RadWideAudioOptionsSelectBluetoothMicForAuxPTTAudioSource_44819Comp;

		// Token: 0x040015A4 RID: 5540
		internal global::AcpUI.AcpExpander ExpanderRadioWideTransmitPowerLevels;

		// Token: 0x040015A5 RID: 5541
		internal global::AcpUI.AcpRecNavToolbar RecNavToolbarExpanderRadioWideTxPowerLevelsByFrequencyRange;

		// Token: 0x040015A6 RID: 5542
		internal global::AcpUI.AcpGroupBox GrpBoxExpanderRadioWideTransmitPowerLevelsPseudo0;

		// Token: 0x040015A7 RID: 5543
		internal global::AcpUI.AcpCustomViewCheckBox CVBtnRadWideTransmitPowerLevelsTxPowerLevelConfigType_A41179;

		// Token: 0x040015A8 RID: 5544
		internal global::AcpUI.AcpLabel LblRadWideTransmitPowerLevelsTxPowerLevelConfigType_A41179;

		// Token: 0x040015A9 RID: 5545
		internal global::AcpUI.AcpComboBox RadWideTransmitPowerLevelsTxPowerLevelConfigType_A41179;

		// Token: 0x040015AA RID: 5546
		internal global::AcpUI.AcpRtdButton RTDBtnRadWideTransmitPowerLevelsTxPowerLevelConfigType_A41179;

		// Token: 0x040015AB RID: 5547
		internal global::AcpUI.AcpCopyButton CpyBtnRadWideTransmitPowerLevelsTxPowerLevelConfigType_A41179;

		// Token: 0x040015AC RID: 5548
		internal global::AcpUI.AcpLabel RadWideTransmitPowerLevelsTxPowerLevelConfigType_A41179Comp;

		// Token: 0x040015AD RID: 5549
		internal global::AcpUI.AcpCustomViewCheckBox CVBtnRadWideTxPowerLevelsNewBandPlan78MHzBandSelection_A41851;

		// Token: 0x040015AE RID: 5550
		internal global::AcpUI.AcpLabel LblRadWideTxPowerLevelsNewBandPlan78MHzBandSelection_A41851;

		// Token: 0x040015AF RID: 5551
		internal global::AcpUI.AcpComboBox RadWideTxPowerLevelsNewBandPlan78MHzBandSelection_A41851;

		// Token: 0x040015B0 RID: 5552
		internal global::AcpUI.AcpRtdButton RTDBtnRadWideTxPowerLevelsNewBandPlan78MHzBandSelection_A41851;

		// Token: 0x040015B1 RID: 5553
		internal global::AcpUI.AcpCopyButton CpyBtnRadWideTxPowerLevelsNewBandPlan78MHzBandSelection_A41851;

		// Token: 0x040015B2 RID: 5554
		internal global::AcpUI.AcpLabel RadWideTxPowerLevelsNewBandPlan78MHzBandSelection_A41851Comp;

		// Token: 0x040015B3 RID: 5555
		internal global::System.Windows.Controls.Grid ExpanderRadioWideTransmitPowerLevelsGrid;

		// Token: 0x040015B4 RID: 5556
		internal global::System.Windows.Controls.Grid ExpanderRadioWideTxPowerLevelsByFrequencyRangeGrid;

		// Token: 0x040015B5 RID: 5557
		internal global::AcpUI.AcpGroupBox ExpanderRadioWideTxPowerLevelsByFrequencyRangeTableView;

		// Token: 0x040015B6 RID: 5558
		internal global::AcpUI.AcpXamDataPresenter ExpanderRadioWideTxPowerLevelsByFrequencyRange;

		// Token: 0x040015B7 RID: 5559
		internal global::Infragistics.Windows.DataPresenter.UnboundField RadWidePowerLevelBandFrequency_A41063_Col;

		// Token: 0x040015B8 RID: 5560
		internal global::Infragistics.Windows.DataPresenter.UnboundField RadWideTransmitPowerLevelsFrequencyRangeStartMHz_A19994_Col;

		// Token: 0x040015B9 RID: 5561
		internal global::Infragistics.Windows.DataPresenter.UnboundField RadWideTransmitPowerLevelsFrequencyRangeEndMHz_A20037_Col;

		// Token: 0x040015BA RID: 5562
		internal global::Infragistics.Windows.DataPresenter.UnboundField RadWideTransmitPowerLevelsTxPowerLevelMinimumW_A20038_Col;

		// Token: 0x040015BB RID: 5563
		internal global::Infragistics.Windows.DataPresenter.UnboundField RadWideTransmitPowerLevelsConvTxPowerLevelMinimumW_A41173_Col;

		// Token: 0x040015BC RID: 5564
		internal global::Infragistics.Windows.DataPresenter.UnboundField RadWideTransmitPowerLevelsTrkTxPowerLevelMinimumW_A41174_Col;

		// Token: 0x040015BD RID: 5565
		internal global::Infragistics.Windows.DataPresenter.UnboundField RadWideTransmitPowerLevelsTxPowerLevelLowW_A8153_Col;

		// Token: 0x040015BE RID: 5566
		internal global::Infragistics.Windows.DataPresenter.UnboundField RadWideTransmitPowerLevelsConvTxPowerLevelLowW_A41175_Col;

		// Token: 0x040015BF RID: 5567
		internal global::Infragistics.Windows.DataPresenter.UnboundField RadWideTransmitPowerLevelsTrkTxPowerLevelLowW_A41176_Col;

		// Token: 0x040015C0 RID: 5568
		internal global::Infragistics.Windows.DataPresenter.UnboundField RadWideTransmitPowerLevelsTxPowerLevelHighW_A8152_Col;

		// Token: 0x040015C1 RID: 5569
		internal global::Infragistics.Windows.DataPresenter.UnboundField RadWideTransmitPowerLevelsTxPowerLevelMaximumW_A20039_Col;

		// Token: 0x040015C2 RID: 5570
		internal global::AcpUI.AcpGroupBox ExpanderRadioWideTxPowerLevelsByFrequencyRangeSRecView;

		// Token: 0x040015C3 RID: 5571
		internal global::System.Windows.Controls.Grid gridExpanderRadioWideTxPowerLevelsByFrequencyRangeSRecView;

		// Token: 0x040015C4 RID: 5572
		internal global::AcpUI.AcpLabel RadWidePowerLevelBandFrequency_A41063;

		// Token: 0x040015C5 RID: 5573
		internal global::AcpUI.AcpCustomViewCheckBox CVBtnRadWidePowerLevelBandFrequency_A41063;

		// Token: 0x040015C6 RID: 5574
		internal global::AcpUI.AcpLabel LblRadWidePowerLevelBandFrequency_A41063;

		// Token: 0x040015C7 RID: 5575
		internal global::AcpUI.AcpRtdButton RTDBtnRadWidePowerLevelBandFrequency_A41063;

		// Token: 0x040015C8 RID: 5576
		internal global::AcpUI.AcpCopyButton CpyBtnRadWidePowerLevelBandFrequency_A41063;

		// Token: 0x040015C9 RID: 5577
		internal global::AcpUI.AcpLabel RadWidePowerLevelBandFrequency_A41063Comp;

		// Token: 0x040015CA RID: 5578
		internal global::AcpUI.AcpTextBox RadWideTransmitPowerLevelsFrequencyRangeStartMHz_A19994;

		// Token: 0x040015CB RID: 5579
		internal global::AcpUI.AcpCustomViewCheckBox CVBtnRadWideTransmitPowerLevelsFrequencyRangeStartMHz_A19994;

		// Token: 0x040015CC RID: 5580
		internal global::AcpUI.AcpLabel LblRadWideTransmitPowerLevelsFrequencyRangeStartMHz_A19994;

		// Token: 0x040015CD RID: 5581
		internal global::AcpUI.AcpRtdButton RTDBtnRadWideTransmitPowerLevelsFrequencyRangeStartMHz_A19994;

		// Token: 0x040015CE RID: 5582
		internal global::AcpUI.AcpCopyButton CpyBtnRadWideTransmitPowerLevelsFrequencyRangeStartMHz_A19994;

		// Token: 0x040015CF RID: 5583
		internal global::AcpUI.AcpLabel RadWideTransmitPowerLevelsFrequencyRangeStartMHz_A19994Comp;

		// Token: 0x040015D0 RID: 5584
		internal global::AcpUI.AcpTextBox RadWideTransmitPowerLevelsFrequencyRangeEndMHz_A20037;

		// Token: 0x040015D1 RID: 5585
		internal global::AcpUI.AcpCustomViewCheckBox CVBtnRadWideTransmitPowerLevelsFrequencyRangeEndMHz_A20037;

		// Token: 0x040015D2 RID: 5586
		internal global::AcpUI.AcpLabel LblRadWideTransmitPowerLevelsFrequencyRangeEndMHz_A20037;

		// Token: 0x040015D3 RID: 5587
		internal global::AcpUI.AcpRtdButton RTDBtnRadWideTransmitPowerLevelsFrequencyRangeEndMHz_A20037;

		// Token: 0x040015D4 RID: 5588
		internal global::AcpUI.AcpCopyButton CpyBtnRadWideTransmitPowerLevelsFrequencyRangeEndMHz_A20037;

		// Token: 0x040015D5 RID: 5589
		internal global::AcpUI.AcpLabel RadWideTransmitPowerLevelsFrequencyRangeEndMHz_A20037Comp;

		// Token: 0x040015D6 RID: 5590
		internal global::AcpUI.AcpTextBox RadWideTransmitPowerLevelsTxPowerLevelMinimumW_A20038;

		// Token: 0x040015D7 RID: 5591
		internal global::AcpUI.AcpCustomViewCheckBox CVBtnRadWideTransmitPowerLevelsTxPowerLevelMinimumW_A20038;

		// Token: 0x040015D8 RID: 5592
		internal global::AcpUI.AcpLabel LblRadWideTransmitPowerLevelsTxPowerLevelMinimumW_A20038;

		// Token: 0x040015D9 RID: 5593
		internal global::AcpUI.AcpRtdButton RTDBtnRadWideTransmitPowerLevelsTxPowerLevelMinimumW_A20038;

		// Token: 0x040015DA RID: 5594
		internal global::AcpUI.AcpCopyButton CpyBtnRadWideTransmitPowerLevelsTxPowerLevelMinimumW_A20038;

		// Token: 0x040015DB RID: 5595
		internal global::AcpUI.AcpLabel RadWideTransmitPowerLevelsTxPowerLevelMinimumW_A20038Comp;

		// Token: 0x040015DC RID: 5596
		internal global::AcpUI.AcpTextBox RadWideTransmitPowerLevelsConvTxPowerLevelMinimumW_A41173;

		// Token: 0x040015DD RID: 5597
		internal global::AcpUI.AcpCustomViewCheckBox CVBtnRadWideTransmitPowerLevelsConvTxPowerLevelMinimumW_A41173;

		// Token: 0x040015DE RID: 5598
		internal global::AcpUI.AcpLabel LblRadWideTransmitPowerLevelsConvTxPowerLevelMinimumW_A41173;

		// Token: 0x040015DF RID: 5599
		internal global::AcpUI.AcpRtdButton RTDBtnRadWideTransmitPowerLevelsConvTxPowerLevelMinimumW_A41173;

		// Token: 0x040015E0 RID: 5600
		internal global::AcpUI.AcpCopyButton CpyBtnRadWideTransmitPowerLevelsConvTxPowerLevelMinimumW_A41173;

		// Token: 0x040015E1 RID: 5601
		internal global::AcpUI.AcpLabel RadWideTransmitPowerLevelsConvTxPowerLevelMinimumW_A41173Comp;

		// Token: 0x040015E2 RID: 5602
		internal global::AcpUI.AcpTextBox RadWideTransmitPowerLevelsTrkTxPowerLevelMinimumW_A41174;

		// Token: 0x040015E3 RID: 5603
		internal global::AcpUI.AcpCustomViewCheckBox CVBtnRadWideTransmitPowerLevelsTrkTxPowerLevelMinimumW_A41174;

		// Token: 0x040015E4 RID: 5604
		internal global::AcpUI.AcpLabel LblRadWideTransmitPowerLevelsTrkTxPowerLevelMinimumW_A41174;

		// Token: 0x040015E5 RID: 5605
		internal global::AcpUI.AcpRtdButton RTDBtnRadWideTransmitPowerLevelsTrkTxPowerLevelMinimumW_A41174;

		// Token: 0x040015E6 RID: 5606
		internal global::AcpUI.AcpCopyButton CpyBtnRadWideTransmitPowerLevelsTrkTxPowerLevelMinimumW_A41174;

		// Token: 0x040015E7 RID: 5607
		internal global::AcpUI.AcpLabel RadWideTransmitPowerLevelsTrkTxPowerLevelMinimumW_A41174Comp;

		// Token: 0x040015E8 RID: 5608
		internal global::AcpUI.AcpTextBox RadWideTransmitPowerLevelsTxPowerLevelLowW_A8153;

		// Token: 0x040015E9 RID: 5609
		internal global::AcpUI.AcpCustomViewCheckBox CVBtnRadWideTransmitPowerLevelsTxPowerLevelLowW_A8153;

		// Token: 0x040015EA RID: 5610
		internal global::AcpUI.AcpLabel LblRadWideTransmitPowerLevelsTxPowerLevelLowW_A8153;

		// Token: 0x040015EB RID: 5611
		internal global::AcpUI.AcpRtdButton RTDBtnRadWideTransmitPowerLevelsTxPowerLevelLowW_A8153;

		// Token: 0x040015EC RID: 5612
		internal global::AcpUI.AcpCopyButton CpyBtnRadWideTransmitPowerLevelsTxPowerLevelLowW_A8153;

		// Token: 0x040015ED RID: 5613
		internal global::AcpUI.AcpLabel RadWideTransmitPowerLevelsTxPowerLevelLowW_A8153Comp;

		// Token: 0x040015EE RID: 5614
		internal global::AcpUI.AcpTextBox RadWideTransmitPowerLevelsConvTxPowerLevelLowW_A41175;

		// Token: 0x040015EF RID: 5615
		internal global::AcpUI.AcpCustomViewCheckBox CVBtnRadWideTransmitPowerLevelsConvTxPowerLevelLowW_A41175;

		// Token: 0x040015F0 RID: 5616
		internal global::AcpUI.AcpLabel LblRadWideTransmitPowerLevelsConvTxPowerLevelLowW_A41175;

		// Token: 0x040015F1 RID: 5617
		internal global::AcpUI.AcpRtdButton RTDBtnRadWideTransmitPowerLevelsConvTxPowerLevelLowW_A41175;

		// Token: 0x040015F2 RID: 5618
		internal global::AcpUI.AcpCopyButton CpyBtnRadWideTransmitPowerLevelsConvTxPowerLevelLowW_A41175;

		// Token: 0x040015F3 RID: 5619
		internal global::AcpUI.AcpLabel RadWideTransmitPowerLevelsConvTxPowerLevelLowW_A41175Comp;

		// Token: 0x040015F4 RID: 5620
		internal global::AcpUI.AcpTextBox RadWideTransmitPowerLevelsTrkTxPowerLevelLowW_A41176;

		// Token: 0x040015F5 RID: 5621
		internal global::AcpUI.AcpCustomViewCheckBox CVBtnRadWideTransmitPowerLevelsTrkTxPowerLevelLowW_A41176;

		// Token: 0x040015F6 RID: 5622
		internal global::AcpUI.AcpLabel LblRadWideTransmitPowerLevelsTrkTxPowerLevelLowW_A41176;

		// Token: 0x040015F7 RID: 5623
		internal global::AcpUI.AcpRtdButton RTDBtnRadWideTransmitPowerLevelsTrkTxPowerLevelLowW_A41176;

		// Token: 0x040015F8 RID: 5624
		internal global::AcpUI.AcpCopyButton CpyBtnRadWideTransmitPowerLevelsTrkTxPowerLevelLowW_A41176;

		// Token: 0x040015F9 RID: 5625
		internal global::AcpUI.AcpLabel RadWideTransmitPowerLevelsTrkTxPowerLevelLowW_A41176Comp;

		// Token: 0x040015FA RID: 5626
		internal global::AcpUI.AcpTextBox RadWideTransmitPowerLevelsTxPowerLevelHighW_A8152;

		// Token: 0x040015FB RID: 5627
		internal global::AcpUI.AcpCustomViewCheckBox CVBtnRadWideTransmitPowerLevelsTxPowerLevelHighW_A8152;

		// Token: 0x040015FC RID: 5628
		internal global::AcpUI.AcpLabel LblRadWideTransmitPowerLevelsTxPowerLevelHighW_A8152;

		// Token: 0x040015FD RID: 5629
		internal global::AcpUI.AcpRtdButton RTDBtnRadWideTransmitPowerLevelsTxPowerLevelHighW_A8152;

		// Token: 0x040015FE RID: 5630
		internal global::AcpUI.AcpCopyButton CpyBtnRadWideTransmitPowerLevelsTxPowerLevelHighW_A8152;

		// Token: 0x040015FF RID: 5631
		internal global::AcpUI.AcpLabel RadWideTransmitPowerLevelsTxPowerLevelHighW_A8152Comp;

		// Token: 0x04001600 RID: 5632
		internal global::AcpUI.AcpTextBox RadWideTransmitPowerLevelsTxPowerLevelMaximumW_A20039;

		// Token: 0x04001601 RID: 5633
		internal global::AcpUI.AcpCustomViewCheckBox CVBtnRadWideTransmitPowerLevelsTxPowerLevelMaximumW_A20039;

		// Token: 0x04001602 RID: 5634
		internal global::AcpUI.AcpLabel LblRadWideTransmitPowerLevelsTxPowerLevelMaximumW_A20039;

		// Token: 0x04001603 RID: 5635
		internal global::AcpUI.AcpRtdButton RTDBtnRadWideTransmitPowerLevelsTxPowerLevelMaximumW_A20039;

		// Token: 0x04001604 RID: 5636
		internal global::AcpUI.AcpCopyButton CpyBtnRadWideTransmitPowerLevelsTxPowerLevelMaximumW_A20039;

		// Token: 0x04001605 RID: 5637
		internal global::AcpUI.AcpLabel RadWideTransmitPowerLevelsTxPowerLevelMaximumW_A20039Comp;

		// Token: 0x04001606 RID: 5638
		internal global::AcpUI.AcpExpander ExpanderRadioWideTxPowerLevelsNewBandPlan;

		// Token: 0x04001607 RID: 5639
		internal global::AcpUI.AcpRecNavToolbar RecNavToolbarExpanderRadioWideTxPowerLevelsByFrequencyRangeNewBandPlan;

		// Token: 0x04001608 RID: 5640
		internal global::System.Windows.Controls.Grid ExpanderRadioWideTxPowerLevelsNewBandPlanGrid;

		// Token: 0x04001609 RID: 5641
		internal global::System.Windows.Controls.Grid ExpanderRadioWideTxPowerLevelsByFrequencyRangeNewBandPlanGrid;

		// Token: 0x0400160A RID: 5642
		internal global::AcpUI.AcpGroupBox ExpanderRadioWideTxPowerLevelsByFrequencyRangeNewBandPlanTableView;

		// Token: 0x0400160B RID: 5643
		internal global::AcpUI.AcpXamDataPresenter ExpanderRadioWideTxPowerLevelsByFrequencyRangeNewBandPlan;

		// Token: 0x0400160C RID: 5644
		internal global::Infragistics.Windows.DataPresenter.UnboundField RadWidePowerLevelBandFrequency_A41864_Col;

		// Token: 0x0400160D RID: 5645
		internal global::Infragistics.Windows.DataPresenter.UnboundField RadWideTransmitPowerLevelsFrequencyRangeStartMHz_A41856_Col;

		// Token: 0x0400160E RID: 5646
		internal global::Infragistics.Windows.DataPresenter.UnboundField RadWideTransmitPowerLevelsFrequencyRangeEndMHz_A41857_Col;

		// Token: 0x0400160F RID: 5647
		internal global::Infragistics.Windows.DataPresenter.UnboundField RadWideTransmitPowerLevelsTxPowerLevelMinimumW_A41858_Col;

		// Token: 0x04001610 RID: 5648
		internal global::Infragistics.Windows.DataPresenter.UnboundField RadWideTransmitPowerLevelsConvTxPowerLevelMinimumW_A41863_Col;

		// Token: 0x04001611 RID: 5649
		internal global::Infragistics.Windows.DataPresenter.UnboundField RadWideTransmitPowerLevelsTrkTxPowerLevelMinimumW_A41862_Col;

		// Token: 0x04001612 RID: 5650
		internal global::Infragistics.Windows.DataPresenter.UnboundField RadWideTransmitPowerLevelsTxPowerLevelLowW_A41855_Col;

		// Token: 0x04001613 RID: 5651
		internal global::Infragistics.Windows.DataPresenter.UnboundField RadWideTransmitPowerLevelsConvTxPowerLevelLowW_A41861_Col;

		// Token: 0x04001614 RID: 5652
		internal global::Infragistics.Windows.DataPresenter.UnboundField RadWideTransmitPowerLevelsTrkTxPowerLevelLowW_A41860_Col;

		// Token: 0x04001615 RID: 5653
		internal global::Infragistics.Windows.DataPresenter.UnboundField RadWideTransmitPowerLevelsTxPowerLevelHighW_A41854_Col;

		// Token: 0x04001616 RID: 5654
		internal global::Infragistics.Windows.DataPresenter.UnboundField RadWideTransmitPowerLevelsTxPowerLevelMaximumW_A41859_Col;

		// Token: 0x04001617 RID: 5655
		internal global::AcpUI.AcpGroupBox ExpanderRadioWideTxPowerLevelsByFrequencyRangeNewBandPlanSRecView;

		// Token: 0x04001618 RID: 5656
		internal global::System.Windows.Controls.Grid gridExpanderRadioWideTxPowerLevelsByFrequencyRangeNewBandPlanSRecView;

		// Token: 0x04001619 RID: 5657
		internal global::AcpUI.AcpLabel RadWidePowerLevelBandFrequency_A41864;

		// Token: 0x0400161A RID: 5658
		internal global::AcpUI.AcpCustomViewCheckBox CVBtnRadWidePowerLevelBandFrequency_A41864;

		// Token: 0x0400161B RID: 5659
		internal global::AcpUI.AcpLabel LblRadWidePowerLevelBandFrequency_A41864;

		// Token: 0x0400161C RID: 5660
		internal global::AcpUI.AcpRtdButton RTDBtnRadWidePowerLevelBandFrequency_A41864;

		// Token: 0x0400161D RID: 5661
		internal global::AcpUI.AcpCopyButton CpyBtnRadWidePowerLevelBandFrequency_A41864;

		// Token: 0x0400161E RID: 5662
		internal global::AcpUI.AcpLabel RadWidePowerLevelBandFrequency_A41864Comp;

		// Token: 0x0400161F RID: 5663
		internal global::AcpUI.AcpTextBox RadWideTransmitPowerLevelsFrequencyRangeStartMHz_A41856;

		// Token: 0x04001620 RID: 5664
		internal global::AcpUI.AcpCustomViewCheckBox CVBtnRadWideTransmitPowerLevelsFrequencyRangeStartMHz_A41856;

		// Token: 0x04001621 RID: 5665
		internal global::AcpUI.AcpLabel LblRadWideTransmitPowerLevelsFrequencyRangeStartMHz_A41856;

		// Token: 0x04001622 RID: 5666
		internal global::AcpUI.AcpRtdButton RTDBtnRadWideTransmitPowerLevelsFrequencyRangeStartMHz_A41856;

		// Token: 0x04001623 RID: 5667
		internal global::AcpUI.AcpCopyButton CpyBtnRadWideTransmitPowerLevelsFrequencyRangeStartMHz_A41856;

		// Token: 0x04001624 RID: 5668
		internal global::AcpUI.AcpLabel RadWideTransmitPowerLevelsFrequencyRangeStartMHz_A41856Comp;

		// Token: 0x04001625 RID: 5669
		internal global::AcpUI.AcpTextBox RadWideTransmitPowerLevelsFrequencyRangeEndMHz_A41857;

		// Token: 0x04001626 RID: 5670
		internal global::AcpUI.AcpCustomViewCheckBox CVBtnRadWideTransmitPowerLevelsFrequencyRangeEndMHz_A41857;

		// Token: 0x04001627 RID: 5671
		internal global::AcpUI.AcpLabel LblRadWideTransmitPowerLevelsFrequencyRangeEndMHz_A41857;

		// Token: 0x04001628 RID: 5672
		internal global::AcpUI.AcpRtdButton RTDBtnRadWideTransmitPowerLevelsFrequencyRangeEndMHz_A41857;

		// Token: 0x04001629 RID: 5673
		internal global::AcpUI.AcpCopyButton CpyBtnRadWideTransmitPowerLevelsFrequencyRangeEndMHz_A41857;

		// Token: 0x0400162A RID: 5674
		internal global::AcpUI.AcpLabel RadWideTransmitPowerLevelsFrequencyRangeEndMHz_A41857Comp;

		// Token: 0x0400162B RID: 5675
		internal global::AcpUI.AcpTextBox RadWideTransmitPowerLevelsTxPowerLevelMinimumW_A41858;

		// Token: 0x0400162C RID: 5676
		internal global::AcpUI.AcpCustomViewCheckBox CVBtnRadWideTransmitPowerLevelsTxPowerLevelMinimumW_A41858;

		// Token: 0x0400162D RID: 5677
		internal global::AcpUI.AcpLabel LblRadWideTransmitPowerLevelsTxPowerLevelMinimumW_A41858;

		// Token: 0x0400162E RID: 5678
		internal global::AcpUI.AcpRtdButton RTDBtnRadWideTransmitPowerLevelsTxPowerLevelMinimumW_A41858;

		// Token: 0x0400162F RID: 5679
		internal global::AcpUI.AcpCopyButton CpyBtnRadWideTransmitPowerLevelsTxPowerLevelMinimumW_A41858;

		// Token: 0x04001630 RID: 5680
		internal global::AcpUI.AcpLabel RadWideTransmitPowerLevelsTxPowerLevelMinimumW_A41858Comp;

		// Token: 0x04001631 RID: 5681
		internal global::AcpUI.AcpTextBox RadWideTransmitPowerLevelsConvTxPowerLevelMinimumW_A41863;

		// Token: 0x04001632 RID: 5682
		internal global::AcpUI.AcpCustomViewCheckBox CVBtnRadWideTransmitPowerLevelsConvTxPowerLevelMinimumW_A41863;

		// Token: 0x04001633 RID: 5683
		internal global::AcpUI.AcpLabel LblRadWideTransmitPowerLevelsConvTxPowerLevelMinimumW_A41863;

		// Token: 0x04001634 RID: 5684
		internal global::AcpUI.AcpRtdButton RTDBtnRadWideTransmitPowerLevelsConvTxPowerLevelMinimumW_A41863;

		// Token: 0x04001635 RID: 5685
		internal global::AcpUI.AcpCopyButton CpyBtnRadWideTransmitPowerLevelsConvTxPowerLevelMinimumW_A41863;

		// Token: 0x04001636 RID: 5686
		internal global::AcpUI.AcpLabel RadWideTransmitPowerLevelsConvTxPowerLevelMinimumW_A41863Comp;

		// Token: 0x04001637 RID: 5687
		internal global::AcpUI.AcpTextBox RadWideTransmitPowerLevelsTrkTxPowerLevelMinimumW_A41862;

		// Token: 0x04001638 RID: 5688
		internal global::AcpUI.AcpCustomViewCheckBox CVBtnRadWideTransmitPowerLevelsTrkTxPowerLevelMinimumW_A41862;

		// Token: 0x04001639 RID: 5689
		internal global::AcpUI.AcpLabel LblRadWideTransmitPowerLevelsTrkTxPowerLevelMinimumW_A41862;

		// Token: 0x0400163A RID: 5690
		internal global::AcpUI.AcpRtdButton RTDBtnRadWideTransmitPowerLevelsTrkTxPowerLevelMinimumW_A41862;

		// Token: 0x0400163B RID: 5691
		internal global::AcpUI.AcpCopyButton CpyBtnRadWideTransmitPowerLevelsTrkTxPowerLevelMinimumW_A41862;

		// Token: 0x0400163C RID: 5692
		internal global::AcpUI.AcpLabel RadWideTransmitPowerLevelsTrkTxPowerLevelMinimumW_A41862Comp;

		// Token: 0x0400163D RID: 5693
		internal global::AcpUI.AcpTextBox RadWideTransmitPowerLevelsTxPowerLevelLowW_A41855;

		// Token: 0x0400163E RID: 5694
		internal global::AcpUI.AcpCustomViewCheckBox CVBtnRadWideTransmitPowerLevelsTxPowerLevelLowW_A41855;

		// Token: 0x0400163F RID: 5695
		internal global::AcpUI.AcpLabel LblRadWideTransmitPowerLevelsTxPowerLevelLowW_A41855;

		// Token: 0x04001640 RID: 5696
		internal global::AcpUI.AcpRtdButton RTDBtnRadWideTransmitPowerLevelsTxPowerLevelLowW_A41855;

		// Token: 0x04001641 RID: 5697
		internal global::AcpUI.AcpCopyButton CpyBtnRadWideTransmitPowerLevelsTxPowerLevelLowW_A41855;

		// Token: 0x04001642 RID: 5698
		internal global::AcpUI.AcpLabel RadWideTransmitPowerLevelsTxPowerLevelLowW_A41855Comp;

		// Token: 0x04001643 RID: 5699
		internal global::AcpUI.AcpTextBox RadWideTransmitPowerLevelsConvTxPowerLevelLowW_A41861;

		// Token: 0x04001644 RID: 5700
		internal global::AcpUI.AcpCustomViewCheckBox CVBtnRadWideTransmitPowerLevelsConvTxPowerLevelLowW_A41861;

		// Token: 0x04001645 RID: 5701
		internal global::AcpUI.AcpLabel LblRadWideTransmitPowerLevelsConvTxPowerLevelLowW_A41861;

		// Token: 0x04001646 RID: 5702
		internal global::AcpUI.AcpRtdButton RTDBtnRadWideTransmitPowerLevelsConvTxPowerLevelLowW_A41861;

		// Token: 0x04001647 RID: 5703
		internal global::AcpUI.AcpCopyButton CpyBtnRadWideTransmitPowerLevelsConvTxPowerLevelLowW_A41861;

		// Token: 0x04001648 RID: 5704
		internal global::AcpUI.AcpLabel RadWideTransmitPowerLevelsConvTxPowerLevelLowW_A41861Comp;

		// Token: 0x04001649 RID: 5705
		internal global::AcpUI.AcpTextBox RadWideTransmitPowerLevelsTrkTxPowerLevelLowW_A41860;

		// Token: 0x0400164A RID: 5706
		internal global::AcpUI.AcpCustomViewCheckBox CVBtnRadWideTransmitPowerLevelsTrkTxPowerLevelLowW_A41860;

		// Token: 0x0400164B RID: 5707
		internal global::AcpUI.AcpLabel LblRadWideTransmitPowerLevelsTrkTxPowerLevelLowW_A41860;

		// Token: 0x0400164C RID: 5708
		internal global::AcpUI.AcpRtdButton RTDBtnRadWideTransmitPowerLevelsTrkTxPowerLevelLowW_A41860;

		// Token: 0x0400164D RID: 5709
		internal global::AcpUI.AcpCopyButton CpyBtnRadWideTransmitPowerLevelsTrkTxPowerLevelLowW_A41860;

		// Token: 0x0400164E RID: 5710
		internal global::AcpUI.AcpLabel RadWideTransmitPowerLevelsTrkTxPowerLevelLowW_A41860Comp;

		// Token: 0x0400164F RID: 5711
		internal global::AcpUI.AcpTextBox RadWideTransmitPowerLevelsTxPowerLevelHighW_A41854;

		// Token: 0x04001650 RID: 5712
		internal global::AcpUI.AcpCustomViewCheckBox CVBtnRadWideTransmitPowerLevelsTxPowerLevelHighW_A41854;

		// Token: 0x04001651 RID: 5713
		internal global::AcpUI.AcpLabel LblRadWideTransmitPowerLevelsTxPowerLevelHighW_A41854;

		// Token: 0x04001652 RID: 5714
		internal global::AcpUI.AcpRtdButton RTDBtnRadWideTransmitPowerLevelsTxPowerLevelHighW_A41854;

		// Token: 0x04001653 RID: 5715
		internal global::AcpUI.AcpCopyButton CpyBtnRadWideTransmitPowerLevelsTxPowerLevelHighW_A41854;

		// Token: 0x04001654 RID: 5716
		internal global::AcpUI.AcpLabel RadWideTransmitPowerLevelsTxPowerLevelHighW_A41854Comp;

		// Token: 0x04001655 RID: 5717
		internal global::AcpUI.AcpTextBox RadWideTransmitPowerLevelsTxPowerLevelMaximumW_A41859;

		// Token: 0x04001656 RID: 5718
		internal global::AcpUI.AcpCustomViewCheckBox CVBtnRadWideTransmitPowerLevelsTxPowerLevelMaximumW_A41859;

		// Token: 0x04001657 RID: 5719
		internal global::AcpUI.AcpLabel LblRadWideTransmitPowerLevelsTxPowerLevelMaximumW_A41859;

		// Token: 0x04001658 RID: 5720
		internal global::AcpUI.AcpRtdButton RTDBtnRadWideTransmitPowerLevelsTxPowerLevelMaximumW_A41859;

		// Token: 0x04001659 RID: 5721
		internal global::AcpUI.AcpCopyButton CpyBtnRadWideTransmitPowerLevelsTxPowerLevelMaximumW_A41859;

		// Token: 0x0400165A RID: 5722
		internal global::AcpUI.AcpLabel RadWideTransmitPowerLevelsTxPowerLevelMaximumW_A41859Comp;

		// Token: 0x0400165B RID: 5723
		internal global::AcpUI.AcpExpander ExpanderRadioWideTPSFireground;

		// Token: 0x0400165C RID: 5724
		internal global::AcpUI.AcpExpander ExpanderRadioWideTPS;

		// Token: 0x0400165D RID: 5725
		internal global::AcpUI.AcpGroupBox GrpBoxExpanderRadioWideTPSPseudo0;

		// Token: 0x0400165E RID: 5726
		internal global::AcpUI.AcpCustomViewCheckBox CVBtnRadWideTPSFiregroundVoiceTxEndTone_A9655;

		// Token: 0x0400165F RID: 5727
		internal global::AcpUI.AcpLabel LblRadWideTPSFiregroundVoiceTxEndTone_A9655;

		// Token: 0x04001660 RID: 5728
		internal global::AcpUI.AcpCheckBox RadWideTPSFiregroundVoiceTxEndTone_A9655;

		// Token: 0x04001661 RID: 5729
		internal global::AcpUI.AcpRtdButton RTDBtnRadWideTPSFiregroundVoiceTxEndTone_A9655;

		// Token: 0x04001662 RID: 5730
		internal global::AcpUI.AcpCopyButton CpyBtnRadWideTPSFiregroundVoiceTxEndTone_A9655;

		// Token: 0x04001663 RID: 5731
		internal global::AcpUI.AcpCheckBox RadWideTPSFiregroundVoiceTxEndTone_A9655Comp;

		// Token: 0x04001664 RID: 5732
		internal global::AcpUI.AcpCustomViewCheckBox CVBtnRadWideTPSAudibleEmergencyBeaconsec_A7502;

		// Token: 0x04001665 RID: 5733
		internal global::AcpUI.AcpLabel LblRadWideTPSAudibleEmergencyBeaconsec_A7502;

		// Token: 0x04001666 RID: 5734
		internal global::AcpUI.AcpTextBoxSpinner RadWideTPSAudibleEmergencyBeaconsec_A7502;

		// Token: 0x04001667 RID: 5735
		internal global::AcpUI.AcpRtdButton RTDBtnRadWideTPSAudibleEmergencyBeaconsec_A7502;

		// Token: 0x04001668 RID: 5736
		internal global::AcpUI.AcpCopyButton CpyBtnRadWideTPSAudibleEmergencyBeaconsec_A7502;

		// Token: 0x04001669 RID: 5737
		internal global::AcpUI.AcpLabel RadWideTPSAudibleEmergencyBeaconsec_A7502Comp;

		// Token: 0x0400166A RID: 5738
		internal global::AcpUI.AcpCustomViewCheckBox CVBtnRadWideTPSAudibleEmergencyBeaconRouting_A41972;

		// Token: 0x0400166B RID: 5739
		internal global::AcpUI.AcpLabel LblRadWideTPSAudibleEmergencyBeaconRouting_A41972;

		// Token: 0x0400166C RID: 5740
		internal global::AcpUI.AcpComboBox RadWideTPSAudibleEmergencyBeaconRouting_A41972;

		// Token: 0x0400166D RID: 5741
		internal global::AcpUI.AcpRtdButton RTDBtnRadWideTPSAudibleEmergencyBeaconRouting_A41972;

		// Token: 0x0400166E RID: 5742
		internal global::AcpUI.AcpCopyButton CpyBtnRadWideTPSAudibleEmergencyBeaconRouting_A41972;

		// Token: 0x0400166F RID: 5743
		internal global::AcpUI.AcpLabel RadWideTPSAudibleEmergencyBeaconRouting_A41972Comp;

		// Token: 0x04001670 RID: 5744
		internal global::AcpUI.AcpCustomViewCheckBox CVBtnRadWideTPSFiregroundEmergencyAlarmRetryRatesec_A7929;

		// Token: 0x04001671 RID: 5745
		internal global::AcpUI.AcpLabel LblRadWideTPSFiregroundEmergencyAlarmRetryRatesec_A7929;

		// Token: 0x04001672 RID: 5746
		internal global::AcpUI.AcpTextBoxSpinner RadWideTPSFiregroundEmergencyAlarmRetryRatesec_A7929;

		// Token: 0x04001673 RID: 5747
		internal global::AcpUI.AcpRtdButton RTDBtnRadWideTPSFiregroundEmergencyAlarmRetryRatesec_A7929;

		// Token: 0x04001674 RID: 5748
		internal global::AcpUI.AcpCopyButton CpyBtnRadWideTPSFiregroundEmergencyAlarmRetryRatesec_A7929;

		// Token: 0x04001675 RID: 5749
		internal global::AcpUI.AcpLabel RadWideTPSFiregroundEmergencyAlarmRetryRatesec_A7929Comp;

		// Token: 0x04001676 RID: 5750
		internal global::AcpUI.AcpCustomViewCheckBox CVBtnRadWideTPSFiregroundEmergencyCallDekeySidetone_A7936;

		// Token: 0x04001677 RID: 5751
		internal global::AcpUI.AcpLabel LblRadWideTPSFiregroundEmergencyCallDekeySidetone_A7936;

		// Token: 0x04001678 RID: 5752
		internal global::AcpUI.AcpCheckBox RadWideTPSFiregroundEmergencyCallDekeySidetone_A7936;

		// Token: 0x04001679 RID: 5753
		internal global::AcpUI.AcpRtdButton RTDBtnRadWideTPSFiregroundEmergencyCallDekeySidetone_A7936;

		// Token: 0x0400167A RID: 5754
		internal global::AcpUI.AcpCopyButton CpyBtnRadWideTPSFiregroundEmergencyCallDekeySidetone_A7936;

		// Token: 0x0400167B RID: 5755
		internal global::AcpUI.AcpCheckBox RadWideTPSFiregroundEmergencyCallDekeySidetone_A7936Comp;

		// Token: 0x0400167C RID: 5756
		internal global::AcpUI.AcpCustomViewCheckBox CVBtnRadWideTPSPTTTransmission_A41545;

		// Token: 0x0400167D RID: 5757
		internal global::AcpUI.AcpLabel LblRadWideTPSPTTTransmission_A41545;

		// Token: 0x0400167E RID: 5758
		internal global::AcpUI.AcpComboBox RadWideTPSPTTTransmission_A41545;

		// Token: 0x0400167F RID: 5759
		internal global::AcpUI.AcpRtdButton RTDBtnRadWideTPSPTTTransmission_A41545;

		// Token: 0x04001680 RID: 5760
		internal global::AcpUI.AcpCopyButton CpyBtnRadWideTPSPTTTransmission_A41545;

		// Token: 0x04001681 RID: 5761
		internal global::AcpUI.AcpLabel RadWideTPSPTTTransmission_A41545Comp;

		// Token: 0x04001682 RID: 5762
		internal global::AcpUI.AcpCustomViewCheckBox CVBtnRadWideTPSEmergencyPTTTransmission_A41544;

		// Token: 0x04001683 RID: 5763
		internal global::AcpUI.AcpLabel LblRadWideTPSEmergencyPTTTransmission_A41544;

		// Token: 0x04001684 RID: 5764
		internal global::AcpUI.AcpComboBox RadWideTPSEmergencyPTTTransmission_A41544;

		// Token: 0x04001685 RID: 5765
		internal global::AcpUI.AcpRtdButton RTDBtnRadWideTPSEmergencyPTTTransmission_A41544;

		// Token: 0x04001686 RID: 5766
		internal global::AcpUI.AcpCopyButton CpyBtnRadWideTPSEmergencyPTTTransmission_A41544;

		// Token: 0x04001687 RID: 5767
		internal global::AcpUI.AcpLabel RadWideTPSEmergencyPTTTransmission_A41544Comp;

		// Token: 0x04001688 RID: 5768
		internal global::AcpUI.AcpExpander ExpanderRadioWideFireground;

		// Token: 0x04001689 RID: 5769
		internal global::AcpUI.AcpGroupBox GrpBoxExpanderRadioWideFiregroundConventionalConfiguration;

		// Token: 0x0400168A RID: 5770
		internal global::AcpUI.AcpCustomViewCheckBox CVBtnRadWideTPSFiregroundPeriodicUpdateTimer_A33467;

		// Token: 0x0400168B RID: 5771
		internal global::AcpUI.AcpLabel LblRadWideTPSFiregroundPeriodicUpdateTimer_A33467;

		// Token: 0x0400168C RID: 5772
		internal global::AcpUI.AcpTextBoxSpinner RadWideTPSFiregroundPeriodicUpdateTimer_A33467;

		// Token: 0x0400168D RID: 5773
		internal global::AcpUI.AcpRtdButton RTDBtnRadWideTPSFiregroundPeriodicUpdateTimer_A33467;

		// Token: 0x0400168E RID: 5774
		internal global::AcpUI.AcpCopyButton CpyBtnRadWideTPSFiregroundPeriodicUpdateTimer_A33467;

		// Token: 0x0400168F RID: 5775
		internal global::AcpUI.AcpLabel RadWideTPSFiregroundPeriodicUpdateTimer_A33467Comp;

		// Token: 0x04001690 RID: 5776
		internal global::AcpUI.AcpCustomViewCheckBox CVBtnRadWideTPSFiregroundRespondToPolls_A33573;

		// Token: 0x04001691 RID: 5777
		internal global::AcpUI.AcpLabel LblRadWideTPSFiregroundRespondToPolls_A33573;

		// Token: 0x04001692 RID: 5778
		internal global::AcpUI.AcpCheckBox RadWideTPSFiregroundRespondToPolls_A33573;

		// Token: 0x04001693 RID: 5779
		internal global::AcpUI.AcpRtdButton RTDBtnRadWideTPSFiregroundRespondToPolls_A33573;

		// Token: 0x04001694 RID: 5780
		internal global::AcpUI.AcpCopyButton CpyBtnRadWideTPSFiregroundRespondToPolls_A33573;

		// Token: 0x04001695 RID: 5781
		internal global::AcpUI.AcpCheckBox RadWideTPSFiregroundRespondToPolls_A33573Comp;

		// Token: 0x04001696 RID: 5782
		internal global::AcpUI.AcpCustomViewCheckBox CVBtnRadWideTPSFiregroundEvacuationAcknowledgement_A33216;

		// Token: 0x04001697 RID: 5783
		internal global::AcpUI.AcpLabel LblRadWideTPSFiregroundEvacuationAcknowledgement_A33216;

		// Token: 0x04001698 RID: 5784
		internal global::AcpUI.AcpComboBox RadWideTPSFiregroundEvacuationAcknowledgement_A33216;

		// Token: 0x04001699 RID: 5785
		internal global::AcpUI.AcpRtdButton RTDBtnRadWideTPSFiregroundEvacuationAcknowledgement_A33216;

		// Token: 0x0400169A RID: 5786
		internal global::AcpUI.AcpCopyButton CpyBtnRadWideTPSFiregroundEvacuationAcknowledgement_A33216;

		// Token: 0x0400169B RID: 5787
		internal global::AcpUI.AcpLabel RadWideTPSFiregroundEvacuationAcknowledgement_A33216Comp;

		// Token: 0x0400169C RID: 5788
		internal global::AcpUI.AcpCustomViewCheckBox CVBtnRadWideFiregroundPTTTransmission_A33515;

		// Token: 0x0400169D RID: 5789
		internal global::AcpUI.AcpLabel LblRadWideFiregroundPTTTransmission_A33515;

		// Token: 0x0400169E RID: 5790
		internal global::AcpUI.AcpComboBox RadWideFiregroundPTTTransmission_A33515;

		// Token: 0x0400169F RID: 5791
		internal global::AcpUI.AcpRtdButton RTDBtnRadWideFiregroundPTTTransmission_A33515;

		// Token: 0x040016A0 RID: 5792
		internal global::AcpUI.AcpCopyButton CpyBtnRadWideFiregroundPTTTransmission_A33515;

		// Token: 0x040016A1 RID: 5793
		internal global::AcpUI.AcpLabel RadWideFiregroundPTTTransmission_A33515Comp;

		// Token: 0x040016A2 RID: 5794
		internal global::AcpUI.AcpCustomViewCheckBox CVBtnRadWideTPSFiregroundEmergencyPTTTransmission_A33203;

		// Token: 0x040016A3 RID: 5795
		internal global::AcpUI.AcpLabel LblRadWideTPSFiregroundEmergencyPTTTransmission_A33203;

		// Token: 0x040016A4 RID: 5796
		internal global::AcpUI.AcpComboBox RadWideTPSFiregroundEmergencyPTTTransmission_A33203;

		// Token: 0x040016A5 RID: 5797
		internal global::AcpUI.AcpRtdButton RTDBtnRadWideTPSFiregroundEmergencyPTTTransmission_A33203;

		// Token: 0x040016A6 RID: 5798
		internal global::AcpUI.AcpCopyButton CpyBtnRadWideTPSFiregroundEmergencyPTTTransmission_A33203;

		// Token: 0x040016A7 RID: 5799
		internal global::AcpUI.AcpLabel RadWideTPSFiregroundEmergencyPTTTransmission_A33203Comp;

		// Token: 0x040016A8 RID: 5800
		internal global::AcpUI.AcpGroupBox GrpBoxExpanderRadioWideFiregroundPseudo1;

		// Token: 0x040016A9 RID: 5801
		internal global::AcpUI.AcpCustomViewCheckBox CVBtnRadWidePAACKAlertsonPTT_A43099;

		// Token: 0x040016AA RID: 5802
		internal global::AcpUI.AcpLabel LblRadWidePAACKAlertsonPTT_A43099;

		// Token: 0x040016AB RID: 5803
		internal global::AcpUI.AcpCheckBox RadWidePAACKAlertsonPTT_A43099;

		// Token: 0x040016AC RID: 5804
		internal global::AcpUI.AcpRtdButton RTDBtnRadWidePAACKAlertsonPTT_A43099;

		// Token: 0x040016AD RID: 5805
		internal global::AcpUI.AcpCopyButton CpyBtnRadWidePAACKAlertsonPTT_A43099;

		// Token: 0x040016AE RID: 5806
		internal global::AcpUI.AcpCheckBox RadWidePAACKAlertsonPTT_A43099Comp;

		// Token: 0x040016AF RID: 5807
		internal global::AcpUI.AcpExpander ExpanderRadioWideRxFrequencySplit;

		// Token: 0x040016B0 RID: 5808
		internal global::AcpUI.AcpRecNavToolbar RecNavToolbarExpanderRadioWideRxFrequencySplitFPP;

		// Token: 0x040016B1 RID: 5809
		internal global::System.Windows.Controls.Grid ExpanderRadioWideRxFrequencySplitGrid;

		// Token: 0x040016B2 RID: 5810
		internal global::System.Windows.Controls.Grid ExpanderRadioWideRxFrequencySplitFPPGrid;

		// Token: 0x040016B3 RID: 5811
		internal global::AcpUI.AcpGroupBox ExpanderRadioWideRxFrequencySplitFPPTableView;

		// Token: 0x040016B4 RID: 5812
		internal global::AcpUI.AcpXamDataPresenter ExpanderRadioWideRxFrequencySplitFPP;

		// Token: 0x040016B5 RID: 5813
		internal global::Infragistics.Windows.DataPresenter.UnboundField RadWideLabtoolRxBandSplitName_A24797_Col;

		// Token: 0x040016B6 RID: 5814
		internal global::Infragistics.Windows.DataPresenter.UnboundField RadWideLabtoolRxStartFrequencySplit_A9032_Col;

		// Token: 0x040016B7 RID: 5815
		internal global::Infragistics.Windows.DataPresenter.UnboundField RadWideLabtoolRxEndFrequencySplit_A9015_Col;

		// Token: 0x040016B8 RID: 5816
		internal global::AcpUI.AcpGroupBox ExpanderRadioWideRxFrequencySplitFPPSRecView;

		// Token: 0x040016B9 RID: 5817
		internal global::System.Windows.Controls.Grid gridExpanderRadioWideRxFrequencySplitFPPSRecView;

		// Token: 0x040016BA RID: 5818
		internal global::AcpUI.AcpLabel RadWideLabtoolRxBandSplitName_A24797;

		// Token: 0x040016BB RID: 5819
		internal global::AcpUI.AcpCustomViewCheckBox CVBtnRadWideLabtoolRxBandSplitName_A24797;

		// Token: 0x040016BC RID: 5820
		internal global::AcpUI.AcpLabel LblRadWideLabtoolRxBandSplitName_A24797;

		// Token: 0x040016BD RID: 5821
		internal global::AcpUI.AcpRtdButton RTDBtnRadWideLabtoolRxBandSplitName_A24797;

		// Token: 0x040016BE RID: 5822
		internal global::AcpUI.AcpCopyButton CpyBtnRadWideLabtoolRxBandSplitName_A24797;

		// Token: 0x040016BF RID: 5823
		internal global::AcpUI.AcpLabel RadWideLabtoolRxBandSplitName_A24797Comp;

		// Token: 0x040016C0 RID: 5824
		internal global::AcpUI.AcpTextBox RadWideLabtoolRxStartFrequencySplit_A9032;

		// Token: 0x040016C1 RID: 5825
		internal global::AcpUI.AcpCustomViewCheckBox CVBtnRadWideLabtoolRxStartFrequencySplit_A9032;

		// Token: 0x040016C2 RID: 5826
		internal global::AcpUI.AcpLabel LblRadWideLabtoolRxStartFrequencySplit_A9032;

		// Token: 0x040016C3 RID: 5827
		internal global::AcpUI.AcpRtdButton RTDBtnRadWideLabtoolRxStartFrequencySplit_A9032;

		// Token: 0x040016C4 RID: 5828
		internal global::AcpUI.AcpCopyButton CpyBtnRadWideLabtoolRxStartFrequencySplit_A9032;

		// Token: 0x040016C5 RID: 5829
		internal global::AcpUI.AcpLabel RadWideLabtoolRxStartFrequencySplit_A9032Comp;

		// Token: 0x040016C6 RID: 5830
		internal global::AcpUI.AcpTextBox RadWideLabtoolRxEndFrequencySplit_A9015;

		// Token: 0x040016C7 RID: 5831
		internal global::AcpUI.AcpCustomViewCheckBox CVBtnRadWideLabtoolRxEndFrequencySplit_A9015;

		// Token: 0x040016C8 RID: 5832
		internal global::AcpUI.AcpLabel LblRadWideLabtoolRxEndFrequencySplit_A9015;

		// Token: 0x040016C9 RID: 5833
		internal global::AcpUI.AcpRtdButton RTDBtnRadWideLabtoolRxEndFrequencySplit_A9015;

		// Token: 0x040016CA RID: 5834
		internal global::AcpUI.AcpCopyButton CpyBtnRadWideLabtoolRxEndFrequencySplit_A9015;

		// Token: 0x040016CB RID: 5835
		internal global::AcpUI.AcpLabel RadWideLabtoolRxEndFrequencySplit_A9015Comp;

		// Token: 0x040016CC RID: 5836
		internal global::AcpUI.AcpExpander ExpanderRadioWideTxFrequencySplit;

		// Token: 0x040016CD RID: 5837
		internal global::AcpUI.AcpRecNavToolbar RecNavToolbarExpanderRadioWideTxFrequencySplitFPP;

		// Token: 0x040016CE RID: 5838
		internal global::System.Windows.Controls.Grid ExpanderRadioWideTxFrequencySplitGrid;

		// Token: 0x040016CF RID: 5839
		internal global::System.Windows.Controls.Grid ExpanderRadioWideTxFrequencySplitFPPGrid;

		// Token: 0x040016D0 RID: 5840
		internal global::AcpUI.AcpGroupBox ExpanderRadioWideTxFrequencySplitFPPTableView;

		// Token: 0x040016D1 RID: 5841
		internal global::AcpUI.AcpXamDataPresenter ExpanderRadioWideTxFrequencySplitFPP;

		// Token: 0x040016D2 RID: 5842
		internal global::Infragistics.Windows.DataPresenter.UnboundField RadWideLabtoolTxBandSplitName_A24799_Col;

		// Token: 0x040016D3 RID: 5843
		internal global::Infragistics.Windows.DataPresenter.UnboundField RadWideLabtoolTxStartFrequencySplit_A9571_Col;

		// Token: 0x040016D4 RID: 5844
		internal global::Infragistics.Windows.DataPresenter.UnboundField RadWideLabtoolTxEndFrequencySplit_A9532_Col;

		// Token: 0x040016D5 RID: 5845
		internal global::AcpUI.AcpGroupBox ExpanderRadioWideTxFrequencySplitFPPSRecView;

		// Token: 0x040016D6 RID: 5846
		internal global::System.Windows.Controls.Grid gridExpanderRadioWideTxFrequencySplitFPPSRecView;

		// Token: 0x040016D7 RID: 5847
		internal global::AcpUI.AcpLabel RadWideLabtoolTxBandSplitName_A24799;

		// Token: 0x040016D8 RID: 5848
		internal global::AcpUI.AcpCustomViewCheckBox CVBtnRadWideLabtoolTxBandSplitName_A24799;

		// Token: 0x040016D9 RID: 5849
		internal global::AcpUI.AcpLabel LblRadWideLabtoolTxBandSplitName_A24799;

		// Token: 0x040016DA RID: 5850
		internal global::AcpUI.AcpRtdButton RTDBtnRadWideLabtoolTxBandSplitName_A24799;

		// Token: 0x040016DB RID: 5851
		internal global::AcpUI.AcpCopyButton CpyBtnRadWideLabtoolTxBandSplitName_A24799;

		// Token: 0x040016DC RID: 5852
		internal global::AcpUI.AcpLabel RadWideLabtoolTxBandSplitName_A24799Comp;

		// Token: 0x040016DD RID: 5853
		internal global::AcpUI.AcpTextBox RadWideLabtoolTxStartFrequencySplit_A9571;

		// Token: 0x040016DE RID: 5854
		internal global::AcpUI.AcpCustomViewCheckBox CVBtnRadWideLabtoolTxStartFrequencySplit_A9571;

		// Token: 0x040016DF RID: 5855
		internal global::AcpUI.AcpLabel LblRadWideLabtoolTxStartFrequencySplit_A9571;

		// Token: 0x040016E0 RID: 5856
		internal global::AcpUI.AcpRtdButton RTDBtnRadWideLabtoolTxStartFrequencySplit_A9571;

		// Token: 0x040016E1 RID: 5857
		internal global::AcpUI.AcpCopyButton CpyBtnRadWideLabtoolTxStartFrequencySplit_A9571;

		// Token: 0x040016E2 RID: 5858
		internal global::AcpUI.AcpLabel RadWideLabtoolTxStartFrequencySplit_A9571Comp;

		// Token: 0x040016E3 RID: 5859
		internal global::AcpUI.AcpTextBox RadWideLabtoolTxEndFrequencySplit_A9532;

		// Token: 0x040016E4 RID: 5860
		internal global::AcpUI.AcpCustomViewCheckBox CVBtnRadWideLabtoolTxEndFrequencySplit_A9532;

		// Token: 0x040016E5 RID: 5861
		internal global::AcpUI.AcpLabel LblRadWideLabtoolTxEndFrequencySplit_A9532;

		// Token: 0x040016E6 RID: 5862
		internal global::AcpUI.AcpRtdButton RTDBtnRadWideLabtoolTxEndFrequencySplit_A9532;

		// Token: 0x040016E7 RID: 5863
		internal global::AcpUI.AcpCopyButton CpyBtnRadWideLabtoolTxEndFrequencySplit_A9532;

		// Token: 0x040016E8 RID: 5864
		internal global::AcpUI.AcpLabel RadWideLabtoolTxEndFrequencySplit_A9532Comp;

		// Token: 0x040016E9 RID: 5865
		internal global::AcpUI.AcpExpander ExpanderRadioWideFCCNarrowBandingFrequencySplit;

		// Token: 0x040016EA RID: 5866
		internal global::AcpUI.AcpRecNavToolbar RecNavToolbarExpanderRadioWideFCCNarrowBandingFrequencySplitTable;

		// Token: 0x040016EB RID: 5867
		internal global::System.Windows.Controls.Grid ExpanderRadioWideFCCNarrowBandingFrequencySplitGrid;

		// Token: 0x040016EC RID: 5868
		internal global::System.Windows.Controls.Grid ExpanderRadioWideFCCNarrowBandingFrequencySplitTableGrid;

		// Token: 0x040016ED RID: 5869
		internal global::AcpUI.AcpGroupBox ExpanderRadioWideFCCNarrowBandingFrequencySplitTableTableView;

		// Token: 0x040016EE RID: 5870
		internal global::AcpUI.AcpXamDataPresenter ExpanderRadioWideFCCNarrowBandingFrequencySplitTable;

		// Token: 0x040016EF RID: 5871
		internal global::Infragistics.Windows.DataPresenter.UnboundField RadWideLabtoolFCCNarrowBandStartFrequency_A38270_Col;

		// Token: 0x040016F0 RID: 5872
		internal global::Infragistics.Windows.DataPresenter.UnboundField RadWideLabtoolFCCNarrowBandEndFrequency_A38271_Col;

		// Token: 0x040016F1 RID: 5873
		internal global::AcpUI.AcpGroupBox ExpanderRadioWideFCCNarrowBandingFrequencySplitTableSRecView;

		// Token: 0x040016F2 RID: 5874
		internal global::System.Windows.Controls.Grid gridExpanderRadioWideFCCNarrowBandingFrequencySplitTableSRecView;

		// Token: 0x040016F3 RID: 5875
		internal global::AcpUI.AcpTextBox RadWideLabtoolFCCNarrowBandStartFrequency_A38270;

		// Token: 0x040016F4 RID: 5876
		internal global::AcpUI.AcpCustomViewCheckBox CVBtnRadWideLabtoolFCCNarrowBandStartFrequency_A38270;

		// Token: 0x040016F5 RID: 5877
		internal global::AcpUI.AcpLabel LblRadWideLabtoolFCCNarrowBandStartFrequency_A38270;

		// Token: 0x040016F6 RID: 5878
		internal global::AcpUI.AcpRtdButton RTDBtnRadWideLabtoolFCCNarrowBandStartFrequency_A38270;

		// Token: 0x040016F7 RID: 5879
		internal global::AcpUI.AcpCopyButton CpyBtnRadWideLabtoolFCCNarrowBandStartFrequency_A38270;

		// Token: 0x040016F8 RID: 5880
		internal global::AcpUI.AcpLabel RadWideLabtoolFCCNarrowBandStartFrequency_A38270Comp;

		// Token: 0x040016F9 RID: 5881
		internal global::AcpUI.AcpTextBox RadWideLabtoolFCCNarrowBandEndFrequency_A38271;

		// Token: 0x040016FA RID: 5882
		internal global::AcpUI.AcpCustomViewCheckBox CVBtnRadWideLabtoolFCCNarrowBandEndFrequency_A38271;

		// Token: 0x040016FB RID: 5883
		internal global::AcpUI.AcpLabel LblRadWideLabtoolFCCNarrowBandEndFrequency_A38271;

		// Token: 0x040016FC RID: 5884
		internal global::AcpUI.AcpRtdButton RTDBtnRadWideLabtoolFCCNarrowBandEndFrequency_A38271;

		// Token: 0x040016FD RID: 5885
		internal global::AcpUI.AcpCopyButton CpyBtnRadWideLabtoolFCCNarrowBandEndFrequency_A38271;

		// Token: 0x040016FE RID: 5886
		internal global::AcpUI.AcpLabel RadWideLabtoolFCCNarrowBandEndFrequency_A38271Comp;

		// Token: 0x040016FF RID: 5887
		internal global::AcpUI.AcpExpander ExpanderRadioWideLightbarPattern;

		// Token: 0x04001700 RID: 5888
		internal global::AcpUI.AcpRecNavToolbar RecNavToolbarExpanderRadioWideGeneralLightbarPattern;

		// Token: 0x04001701 RID: 5889
		internal global::AcpUI.AcpGroupBox GrpBoxExpanderRadioWideLightbarPatternPseudo0;

		// Token: 0x04001702 RID: 5890
		internal global::AcpUI.AcpCustomViewCheckBox CVBtnRadWideUniversalRelayControllerEquipped_A37191;

		// Token: 0x04001703 RID: 5891
		internal global::AcpUI.AcpLabel LblRadWideUniversalRelayControllerEquipped_A37191;

		// Token: 0x04001704 RID: 5892
		internal global::AcpUI.AcpCheckBox RadWideUniversalRelayControllerEquipped_A37191;

		// Token: 0x04001705 RID: 5893
		internal global::AcpUI.AcpRtdButton RTDBtnRadWideUniversalRelayControllerEquipped_A37191;

		// Token: 0x04001706 RID: 5894
		internal global::AcpUI.AcpCopyButton CpyBtnRadWideUniversalRelayControllerEquipped_A37191;

		// Token: 0x04001707 RID: 5895
		internal global::AcpUI.AcpCheckBox RadWideUniversalRelayControllerEquipped_A37191Comp;

		// Token: 0x04001708 RID: 5896
		internal global::AcpUI.AcpCustomViewCheckBox CVBtnRadWideUniversalRelayControllerFatalError_A37194;

		// Token: 0x04001709 RID: 5897
		internal global::AcpUI.AcpLabel LblRadWideUniversalRelayControllerFatalError_A37194;

		// Token: 0x0400170A RID: 5898
		internal global::AcpUI.AcpCheckBox RadWideUniversalRelayControllerFatalError_A37194;

		// Token: 0x0400170B RID: 5899
		internal global::AcpUI.AcpRtdButton RTDBtnRadWideUniversalRelayControllerFatalError_A37194;

		// Token: 0x0400170C RID: 5900
		internal global::AcpUI.AcpCopyButton CpyBtnRadWideUniversalRelayControllerFatalError_A37194;

		// Token: 0x0400170D RID: 5901
		internal global::AcpUI.AcpCheckBox RadWideUniversalRelayControllerFatalError_A37194Comp;

		// Token: 0x0400170E RID: 5902
		internal global::System.Windows.Controls.Grid ExpanderRadioWideLightbarPatternGrid;

		// Token: 0x0400170F RID: 5903
		internal global::System.Windows.Controls.Grid ExpanderRadioWideGeneralLightbarPatternGrid;

		// Token: 0x04001710 RID: 5904
		internal global::AcpUI.AcpGroupBox ExpanderRadioWideGeneralLightbarPatternTableView;

		// Token: 0x04001711 RID: 5905
		internal global::AcpUI.AcpXamDataPresenter ExpanderRadioWideGeneralLightbarPattern;

		// Token: 0x04001712 RID: 5906
		internal global::Infragistics.Windows.DataPresenter.UnboundField RadWideGenLgtBarName_A36505_Col;

		// Token: 0x04001713 RID: 5907
		internal global::Infragistics.Windows.DataPresenter.UnboundField RadWideGenLightBarPatternRelay1_A36506_Col;

		// Token: 0x04001714 RID: 5908
		internal global::Infragistics.Windows.DataPresenter.UnboundField RadWideGenLightBarPatternRelay2_A36507_Col;

		// Token: 0x04001715 RID: 5909
		internal global::Infragistics.Windows.DataPresenter.UnboundField RadWideGenLightBarPatternRelay3_A36508_Col;

		// Token: 0x04001716 RID: 5910
		internal global::Infragistics.Windows.DataPresenter.UnboundField RadWideGenLightBarPatternRelay4_A36509_Col;

		// Token: 0x04001717 RID: 5911
		internal global::Infragistics.Windows.DataPresenter.UnboundField RadWideGenLightBarPatternRelay5_A36510_Col;

		// Token: 0x04001718 RID: 5912
		internal global::Infragistics.Windows.DataPresenter.UnboundField RadWideGenLightBarPatternRelay6_A36511_Col;

		// Token: 0x04001719 RID: 5913
		internal global::Infragistics.Windows.DataPresenter.UnboundField RadWideGenLightBarPatternRelay7_A36512_Col;

		// Token: 0x0400171A RID: 5914
		internal global::Infragistics.Windows.DataPresenter.UnboundField RadWideGenLightBarPatternRelay8_A36513_Col;

		// Token: 0x0400171B RID: 5915
		internal global::Infragistics.Windows.DataPresenter.UnboundField RadWideGenLightBarPatternRelay9_A36515_Col;

		// Token: 0x0400171C RID: 5916
		internal global::Infragistics.Windows.DataPresenter.UnboundField RadWideGenLightBarPatternRelay10_A36516_Col;

		// Token: 0x0400171D RID: 5917
		internal global::AcpUI.AcpGroupBox ExpanderRadioWideGeneralLightbarPatternSRecView;

		// Token: 0x0400171E RID: 5918
		internal global::System.Windows.Controls.Grid gridExpanderRadioWideGeneralLightbarPatternSRecView;

		// Token: 0x0400171F RID: 5919
		internal global::AcpUI.AcpTextBox RadWideGenLgtBarName_A36505;

		// Token: 0x04001720 RID: 5920
		internal global::AcpUI.AcpCustomViewCheckBox CVBtnRadWideGenLgtBarName_A36505;

		// Token: 0x04001721 RID: 5921
		internal global::AcpUI.AcpLabel LblRadWideGenLgtBarName_A36505;

		// Token: 0x04001722 RID: 5922
		internal global::AcpUI.AcpCopyButton CpyBtnRadWideGenLgtBarName_A36505;

		// Token: 0x04001723 RID: 5923
		internal global::AcpUI.AcpLabel RadWideGenLgtBarName_A36505Comp;

		// Token: 0x04001724 RID: 5924
		internal global::AcpUI.AcpComboBox RadWideGenLightBarPatternRelay1_A36506;

		// Token: 0x04001725 RID: 5925
		internal global::AcpUI.AcpCustomViewCheckBox CVBtnRadWideGenLightBarPatternRelay1_A36506;

		// Token: 0x04001726 RID: 5926
		internal global::AcpUI.AcpLabel LblRadWideGenLightBarPatternRelay1_A36506;

		// Token: 0x04001727 RID: 5927
		internal global::AcpUI.AcpRtdButton RTDBtnRadWideGenLightBarPatternRelay1_A36506;

		// Token: 0x04001728 RID: 5928
		internal global::AcpUI.AcpCopyButton CpyBtnRadWideGenLightBarPatternRelay1_A36506;

		// Token: 0x04001729 RID: 5929
		internal global::AcpUI.AcpLabel RadWideGenLightBarPatternRelay1_A36506Comp;

		// Token: 0x0400172A RID: 5930
		internal global::AcpUI.AcpComboBox RadWideGenLightBarPatternRelay2_A36507;

		// Token: 0x0400172B RID: 5931
		internal global::AcpUI.AcpCustomViewCheckBox CVBtnRadWideGenLightBarPatternRelay2_A36507;

		// Token: 0x0400172C RID: 5932
		internal global::AcpUI.AcpLabel LblRadWideGenLightBarPatternRelay2_A36507;

		// Token: 0x0400172D RID: 5933
		internal global::AcpUI.AcpRtdButton RTDBtnRadWideGenLightBarPatternRelay2_A36507;

		// Token: 0x0400172E RID: 5934
		internal global::AcpUI.AcpCopyButton CpyBtnRadWideGenLightBarPatternRelay2_A36507;

		// Token: 0x0400172F RID: 5935
		internal global::AcpUI.AcpLabel RadWideGenLightBarPatternRelay2_A36507Comp;

		// Token: 0x04001730 RID: 5936
		internal global::AcpUI.AcpComboBox RadWideGenLightBarPatternRelay3_A36508;

		// Token: 0x04001731 RID: 5937
		internal global::AcpUI.AcpCustomViewCheckBox CVBtnRadWideGenLightBarPatternRelay3_A36508;

		// Token: 0x04001732 RID: 5938
		internal global::AcpUI.AcpLabel LblRadWideGenLightBarPatternRelay3_A36508;

		// Token: 0x04001733 RID: 5939
		internal global::AcpUI.AcpRtdButton RTDBtnRadWideGenLightBarPatternRelay3_A36508;

		// Token: 0x04001734 RID: 5940
		internal global::AcpUI.AcpCopyButton CpyBtnRadWideGenLightBarPatternRelay3_A36508;

		// Token: 0x04001735 RID: 5941
		internal global::AcpUI.AcpLabel RadWideGenLightBarPatternRelay3_A36508Comp;

		// Token: 0x04001736 RID: 5942
		internal global::AcpUI.AcpComboBox RadWideGenLightBarPatternRelay4_A36509;

		// Token: 0x04001737 RID: 5943
		internal global::AcpUI.AcpCustomViewCheckBox CVBtnRadWideGenLightBarPatternRelay4_A36509;

		// Token: 0x04001738 RID: 5944
		internal global::AcpUI.AcpLabel LblRadWideGenLightBarPatternRelay4_A36509;

		// Token: 0x04001739 RID: 5945
		internal global::AcpUI.AcpRtdButton RTDBtnRadWideGenLightBarPatternRelay4_A36509;

		// Token: 0x0400173A RID: 5946
		internal global::AcpUI.AcpCopyButton CpyBtnRadWideGenLightBarPatternRelay4_A36509;

		// Token: 0x0400173B RID: 5947
		internal global::AcpUI.AcpLabel RadWideGenLightBarPatternRelay4_A36509Comp;

		// Token: 0x0400173C RID: 5948
		internal global::AcpUI.AcpComboBox RadWideGenLightBarPatternRelay5_A36510;

		// Token: 0x0400173D RID: 5949
		internal global::AcpUI.AcpCustomViewCheckBox CVBtnRadWideGenLightBarPatternRelay5_A36510;

		// Token: 0x0400173E RID: 5950
		internal global::AcpUI.AcpLabel LblRadWideGenLightBarPatternRelay5_A36510;

		// Token: 0x0400173F RID: 5951
		internal global::AcpUI.AcpRtdButton RTDBtnRadWideGenLightBarPatternRelay5_A36510;

		// Token: 0x04001740 RID: 5952
		internal global::AcpUI.AcpCopyButton CpyBtnRadWideGenLightBarPatternRelay5_A36510;

		// Token: 0x04001741 RID: 5953
		internal global::AcpUI.AcpLabel RadWideGenLightBarPatternRelay5_A36510Comp;

		// Token: 0x04001742 RID: 5954
		internal global::AcpUI.AcpComboBox RadWideGenLightBarPatternRelay6_A36511;

		// Token: 0x04001743 RID: 5955
		internal global::AcpUI.AcpCustomViewCheckBox CVBtnRadWideGenLightBarPatternRelay6_A36511;

		// Token: 0x04001744 RID: 5956
		internal global::AcpUI.AcpLabel LblRadWideGenLightBarPatternRelay6_A36511;

		// Token: 0x04001745 RID: 5957
		internal global::AcpUI.AcpRtdButton RTDBtnRadWideGenLightBarPatternRelay6_A36511;

		// Token: 0x04001746 RID: 5958
		internal global::AcpUI.AcpCopyButton CpyBtnRadWideGenLightBarPatternRelay6_A36511;

		// Token: 0x04001747 RID: 5959
		internal global::AcpUI.AcpLabel RadWideGenLightBarPatternRelay6_A36511Comp;

		// Token: 0x04001748 RID: 5960
		internal global::AcpUI.AcpComboBox RadWideGenLightBarPatternRelay7_A36512;

		// Token: 0x04001749 RID: 5961
		internal global::AcpUI.AcpCustomViewCheckBox CVBtnRadWideGenLightBarPatternRelay7_A36512;

		// Token: 0x0400174A RID: 5962
		internal global::AcpUI.AcpLabel LblRadWideGenLightBarPatternRelay7_A36512;

		// Token: 0x0400174B RID: 5963
		internal global::AcpUI.AcpRtdButton RTDBtnRadWideGenLightBarPatternRelay7_A36512;

		// Token: 0x0400174C RID: 5964
		internal global::AcpUI.AcpCopyButton CpyBtnRadWideGenLightBarPatternRelay7_A36512;

		// Token: 0x0400174D RID: 5965
		internal global::AcpUI.AcpLabel RadWideGenLightBarPatternRelay7_A36512Comp;

		// Token: 0x0400174E RID: 5966
		internal global::AcpUI.AcpComboBox RadWideGenLightBarPatternRelay8_A36513;

		// Token: 0x0400174F RID: 5967
		internal global::AcpUI.AcpCustomViewCheckBox CVBtnRadWideGenLightBarPatternRelay8_A36513;

		// Token: 0x04001750 RID: 5968
		internal global::AcpUI.AcpLabel LblRadWideGenLightBarPatternRelay8_A36513;

		// Token: 0x04001751 RID: 5969
		internal global::AcpUI.AcpRtdButton RTDBtnRadWideGenLightBarPatternRelay8_A36513;

		// Token: 0x04001752 RID: 5970
		internal global::AcpUI.AcpCopyButton CpyBtnRadWideGenLightBarPatternRelay8_A36513;

		// Token: 0x04001753 RID: 5971
		internal global::AcpUI.AcpLabel RadWideGenLightBarPatternRelay8_A36513Comp;

		// Token: 0x04001754 RID: 5972
		internal global::AcpUI.AcpComboBox RadWideGenLightBarPatternRelay9_A36515;

		// Token: 0x04001755 RID: 5973
		internal global::AcpUI.AcpCustomViewCheckBox CVBtnRadWideGenLightBarPatternRelay9_A36515;

		// Token: 0x04001756 RID: 5974
		internal global::AcpUI.AcpLabel LblRadWideGenLightBarPatternRelay9_A36515;

		// Token: 0x04001757 RID: 5975
		internal global::AcpUI.AcpRtdButton RTDBtnRadWideGenLightBarPatternRelay9_A36515;

		// Token: 0x04001758 RID: 5976
		internal global::AcpUI.AcpCopyButton CpyBtnRadWideGenLightBarPatternRelay9_A36515;

		// Token: 0x04001759 RID: 5977
		internal global::AcpUI.AcpLabel RadWideGenLightBarPatternRelay9_A36515Comp;

		// Token: 0x0400175A RID: 5978
		internal global::AcpUI.AcpComboBox RadWideGenLightBarPatternRelay10_A36516;

		// Token: 0x0400175B RID: 5979
		internal global::AcpUI.AcpCustomViewCheckBox CVBtnRadWideGenLightBarPatternRelay10_A36516;

		// Token: 0x0400175C RID: 5980
		internal global::AcpUI.AcpLabel LblRadWideGenLightBarPatternRelay10_A36516;

		// Token: 0x0400175D RID: 5981
		internal global::AcpUI.AcpRtdButton RTDBtnRadWideGenLightBarPatternRelay10_A36516;

		// Token: 0x0400175E RID: 5982
		internal global::AcpUI.AcpCopyButton CpyBtnRadWideGenLightBarPatternRelay10_A36516;

		// Token: 0x0400175F RID: 5983
		internal global::AcpUI.AcpLabel RadWideGenLightBarPatternRelay10_A36516Comp;

		// Token: 0x04001760 RID: 5984
		internal global::AcpUI.AcpExpander ExpanderRadioWideGunLock;

		// Token: 0x04001761 RID: 5985
		internal global::AcpUI.AcpRecNavToolbar RecNavToolbarExpanderRadioWideRelockTimer;

		// Token: 0x04001762 RID: 5986
		internal global::System.Windows.Controls.Grid ExpanderRadioWideGunLockGrid;

		// Token: 0x04001763 RID: 5987
		internal global::System.Windows.Controls.Grid ExpanderRadioWideRelockTimerGrid;

		// Token: 0x04001764 RID: 5988
		internal global::AcpUI.AcpGroupBox ExpanderRadioWideRelockTimerTableView;

		// Token: 0x04001765 RID: 5989
		internal global::AcpUI.AcpXamDataPresenter ExpanderRadioWideRelockTimer;

		// Token: 0x04001766 RID: 5990
		internal global::Infragistics.Windows.DataPresenter.UnboundField RadWideGunlockRelocktimerName_A36521_Col;

		// Token: 0x04001767 RID: 5991
		internal global::Infragistics.Windows.DataPresenter.UnboundField RadWideGunlockRelocktimerTimer_A36522_Col;

		// Token: 0x04001768 RID: 5992
		internal global::AcpUI.AcpGroupBox ExpanderRadioWideRelockTimerSRecView;

		// Token: 0x04001769 RID: 5993
		internal global::System.Windows.Controls.Grid gridExpanderRadioWideRelockTimerSRecView;

		// Token: 0x0400176A RID: 5994
		internal global::AcpUI.AcpLabel RadWideGunlockRelocktimerName_A36521;

		// Token: 0x0400176B RID: 5995
		internal global::AcpUI.AcpCustomViewCheckBox CVBtnRadWideGunlockRelocktimerName_A36521;

		// Token: 0x0400176C RID: 5996
		internal global::AcpUI.AcpLabel LblRadWideGunlockRelocktimerName_A36521;

		// Token: 0x0400176D RID: 5997
		internal global::AcpUI.AcpCopyButton CpyBtnRadWideGunlockRelocktimerName_A36521;

		// Token: 0x0400176E RID: 5998
		internal global::AcpUI.AcpLabel RadWideGunlockRelocktimerName_A36521Comp;

		// Token: 0x0400176F RID: 5999
		internal global::AcpUI.AcpTextBoxSpinner RadWideGunlockRelocktimerTimer_A36522;

		// Token: 0x04001770 RID: 6000
		internal global::AcpUI.AcpCustomViewCheckBox CVBtnRadWideGunlockRelocktimerTimer_A36522;

		// Token: 0x04001771 RID: 6001
		internal global::AcpUI.AcpLabel LblRadWideGunlockRelocktimerTimer_A36522;

		// Token: 0x04001772 RID: 6002
		internal global::AcpUI.AcpRtdButton RTDBtnRadWideGunlockRelocktimerTimer_A36522;

		// Token: 0x04001773 RID: 6003
		internal global::AcpUI.AcpCopyButton CpyBtnRadWideGunlockRelocktimerTimer_A36522;

		// Token: 0x04001774 RID: 6004
		internal global::AcpUI.AcpLabel RadWideGunlockRelocktimerTimer_A36522Comp;

		// Token: 0x04001775 RID: 6005
		internal global::AcpUI.AcpExpander ExpanderRadioWideBluetooth;

		// Token: 0x04001776 RID: 6006
		internal global::AcpUI.AcpGroupBox GrpBoxExpanderRadioWideBluetoothPseudo0;

		// Token: 0x04001777 RID: 6007
		internal global::AcpUI.AcpCustomViewCheckBox CVBtnRadWideBluetoothBluetoothEnable_A37028;

		// Token: 0x04001778 RID: 6008
		internal global::AcpUI.AcpLabel LblRadWideBluetoothBluetoothEnable_A37028;

		// Token: 0x04001779 RID: 6009
		internal global::AcpUI.AcpCheckBox RadWideBluetoothBluetoothEnable_A37028;

		// Token: 0x0400177A RID: 6010
		internal global::AcpUI.AcpRtdButton RTDBtnRadWideBluetoothBluetoothEnable_A37028;

		// Token: 0x0400177B RID: 6011
		internal global::AcpUI.AcpCopyButton CpyBtnRadWideBluetoothBluetoothEnable_A37028;

		// Token: 0x0400177C RID: 6012
		internal global::AcpUI.AcpCheckBox RadWideBluetoothBluetoothEnable_A37028Comp;

		// Token: 0x0400177D RID: 6013
		internal global::AcpUI.AcpCustomViewCheckBox CVBtnRadWideBluetoothBluetoothTones_A37035;

		// Token: 0x0400177E RID: 6014
		internal global::AcpUI.AcpLabel LblRadWideBluetoothBluetoothTones_A37035;

		// Token: 0x0400177F RID: 6015
		internal global::AcpUI.AcpCheckBox RadWideBluetoothBluetoothTones_A37035;

		// Token: 0x04001780 RID: 6016
		internal global::AcpUI.AcpRtdButton RTDBtnRadWideBluetoothBluetoothTones_A37035;

		// Token: 0x04001781 RID: 6017
		internal global::AcpUI.AcpCopyButton CpyBtnRadWideBluetoothBluetoothTones_A37035;

		// Token: 0x04001782 RID: 6018
		internal global::AcpUI.AcpCheckBox RadWideBluetoothBluetoothTones_A37035Comp;

		// Token: 0x04001783 RID: 6019
		internal global::AcpUI.AcpCustomViewCheckBox CVBtnRadWideBluetoothBluetoothRSMLED_A37039;

		// Token: 0x04001784 RID: 6020
		internal global::AcpUI.AcpLabel LblRadWideBluetoothBluetoothRSMLED_A37039;

		// Token: 0x04001785 RID: 6021
		internal global::AcpUI.AcpCheckBox RadWideBluetoothBluetoothRSMLED_A37039;

		// Token: 0x04001786 RID: 6022
		internal global::AcpUI.AcpRtdButton RTDBtnRadWideBluetoothBluetoothRSMLED_A37039;

		// Token: 0x04001787 RID: 6023
		internal global::AcpUI.AcpCopyButton CpyBtnRadWideBluetoothBluetoothRSMLED_A37039;

		// Token: 0x04001788 RID: 6024
		internal global::AcpUI.AcpCheckBox RadWideBluetoothBluetoothRSMLED_A37039Comp;

		// Token: 0x04001789 RID: 6025
		internal global::AcpUI.AcpCustomViewCheckBox CVBtnRadWideBluetoothBluetoothPairingType_A37036;

		// Token: 0x0400178A RID: 6026
		internal global::AcpUI.AcpLabel LblRadWideBluetoothBluetoothPairingType_A37036;

		// Token: 0x0400178B RID: 6027
		internal global::AcpUI.AcpComboBox RadWideBluetoothBluetoothPairingType_A37036;

		// Token: 0x0400178C RID: 6028
		internal global::AcpUI.AcpRtdButton RTDBtnRadWideBluetoothBluetoothPairingType_A37036;

		// Token: 0x0400178D RID: 6029
		internal global::AcpUI.AcpCopyButton CpyBtnRadWideBluetoothBluetoothPairingType_A37036;

		// Token: 0x0400178E RID: 6030
		internal global::AcpUI.AcpLabel RadWideBluetoothBluetoothPairingType_A37036Comp;

		// Token: 0x0400178F RID: 6031
		internal global::AcpUI.AcpCustomViewCheckBox CVBtnRadWideStandardNFCPairing_A44928;

		// Token: 0x04001790 RID: 6032
		internal global::AcpUI.AcpLabel LblRadWideStandardNFCPairing_A44928;

		// Token: 0x04001791 RID: 6033
		internal global::AcpUI.AcpCheckBox RadWideStandardNFCPairing_A44928;

		// Token: 0x04001792 RID: 6034
		internal global::AcpUI.AcpRtdButton RTDBtnRadWideStandardNFCPairing_A44928;

		// Token: 0x04001793 RID: 6035
		internal global::AcpUI.AcpCopyButton CpyBtnRadWideStandardNFCPairing_A44928;

		// Token: 0x04001794 RID: 6036
		internal global::AcpUI.AcpCheckBox RadWideStandardNFCPairing_A44928Comp;

		// Token: 0x04001795 RID: 6037
		internal global::AcpUI.AcpCustomViewCheckBox CVBtnRadWideSecureNFCPairing_A44931;

		// Token: 0x04001796 RID: 6038
		internal global::AcpUI.AcpLabel LblRadWideSecureNFCPairing_A44931;

		// Token: 0x04001797 RID: 6039
		internal global::AcpUI.AcpCheckBox RadWideSecureNFCPairing_A44931;

		// Token: 0x04001798 RID: 6040
		internal global::AcpUI.AcpRtdButton RTDBtnRadWideSecureNFCPairing_A44931;

		// Token: 0x04001799 RID: 6041
		internal global::AcpUI.AcpCopyButton CpyBtnRadWideSecureNFCPairing_A44931;

		// Token: 0x0400179A RID: 6042
		internal global::AcpUI.AcpCheckBox RadWideSecureNFCPairing_A44931Comp;

		// Token: 0x0400179B RID: 6043
		internal global::AcpUI.AcpCustomViewCheckBox CVBtnRadWideMPPPairingOnlyWithLTE_A42320;

		// Token: 0x0400179C RID: 6044
		internal global::AcpUI.AcpLabel LblRadWideMPPPairingOnlyWithLTE_A42320;

		// Token: 0x0400179D RID: 6045
		internal global::AcpUI.AcpLabel RadWideMPPPairingOnlyWithLTE_A42320;

		// Token: 0x0400179E RID: 6046
		internal global::AcpUI.AcpRtdButton RTDBtnRadWideMPPPairingOnlyWithLTE_A42320;

		// Token: 0x0400179F RID: 6047
		internal global::AcpUI.AcpCopyButton CpyBtnRadWideMPPPairingOnlyWithLTE_A42320;

		// Token: 0x040017A0 RID: 6048
		internal global::AcpUI.AcpLabel RadWideMPPPairingOnlyWithLTE_A42320Comp;

		// Token: 0x040017A1 RID: 6049
		internal global::AcpUI.AcpCustomViewCheckBox CVBtnRadWideBluetoothBluetoothReconnectTimer_A37037;

		// Token: 0x040017A2 RID: 6050
		internal global::AcpUI.AcpLabel LblRadWideBluetoothBluetoothReconnectTimer_A37037;

		// Token: 0x040017A3 RID: 6051
		internal global::AcpUI.AcpTextBoxSpinner RadWideBluetoothBluetoothReconnectTimer_A37037;

		// Token: 0x040017A4 RID: 6052
		internal global::AcpUI.AcpRtdButton RTDBtnRadWideBluetoothBluetoothReconnectTimer_A37037;

		// Token: 0x040017A5 RID: 6053
		internal global::AcpUI.AcpCopyButton CpyBtnRadWideBluetoothBluetoothReconnectTimer_A37037;

		// Token: 0x040017A6 RID: 6054
		internal global::AcpUI.AcpLabel RadWideBluetoothBluetoothReconnectTimer_A37037Comp;

		// Token: 0x040017A7 RID: 6055
		internal global::AcpUI.AcpCustomViewCheckBox CVBtnRadWideBluetoothBluetoothDropTimer_A37038;

		// Token: 0x040017A8 RID: 6056
		internal global::AcpUI.AcpLabel LblRadWideBluetoothBluetoothDropTimer_A37038;

		// Token: 0x040017A9 RID: 6057
		internal global::AcpUI.AcpComboBox RadWideBluetoothBluetoothDropTimer_A37038;

		// Token: 0x040017AA RID: 6058
		internal global::AcpUI.AcpRtdButton RTDBtnRadWideBluetoothBluetoothDropTimer_A37038;

		// Token: 0x040017AB RID: 6059
		internal global::AcpUI.AcpCopyButton CpyBtnRadWideBluetoothBluetoothDropTimer_A37038;

		// Token: 0x040017AC RID: 6060
		internal global::AcpUI.AcpLabel RadWideBluetoothBluetoothDropTimer_A37038Comp;

		// Token: 0x040017AD RID: 6061
		internal global::AcpUI.AcpCustomViewCheckBox CVBtnRadWideBluetoothFriendlyNameEditable_A41182;

		// Token: 0x040017AE RID: 6062
		internal global::AcpUI.AcpLabel LblRadWideBluetoothFriendlyNameEditable_A41182;

		// Token: 0x040017AF RID: 6063
		internal global::AcpUI.AcpCheckBox RadWideBluetoothFriendlyNameEditable_A41182;

		// Token: 0x040017B0 RID: 6064
		internal global::AcpUI.AcpRtdButton RTDBtnRadWideBluetoothFriendlyNameEditable_A41182;

		// Token: 0x040017B1 RID: 6065
		internal global::AcpUI.AcpCopyButton CpyBtnRadWideBluetoothFriendlyNameEditable_A41182;

		// Token: 0x040017B2 RID: 6066
		internal global::AcpUI.AcpCheckBox RadWideBluetoothFriendlyNameEditable_A41182Comp;

		// Token: 0x040017B3 RID: 6067
		internal global::AcpUI.AcpCustomViewCheckBox CVBtnRadWideBluetoothFriendlyName_A41181;

		// Token: 0x040017B4 RID: 6068
		internal global::AcpUI.AcpLabel LblRadWideBluetoothFriendlyName_A41181;

		// Token: 0x040017B5 RID: 6069
		internal global::AcpUI.AcpTextBox RadWideBluetoothFriendlyName_A41181;

		// Token: 0x040017B6 RID: 6070
		internal global::AcpUI.AcpRtdButton RTDBtnRadWideBluetoothFriendlyName_A41181;

		// Token: 0x040017B7 RID: 6071
		internal global::AcpUI.AcpCopyButton CpyBtnRadWideBluetoothFriendlyName_A41181;

		// Token: 0x040017B8 RID: 6072
		internal global::AcpUI.AcpLabel RadWideBluetoothFriendlyName_A41181Comp;

		// Token: 0x040017B9 RID: 6073
		internal global::AcpUI.AcpCustomViewCheckBox CVBtnRadWideBluetoothReplacePairingInfo_A41562;

		// Token: 0x040017BA RID: 6074
		internal global::AcpUI.AcpLabel LblRadWideBluetoothReplacePairingInfo_A41562;

		// Token: 0x040017BB RID: 6075
		internal global::AcpUI.AcpCheckBox RadWideBluetoothReplacePairingInfo_A41562;

		// Token: 0x040017BC RID: 6076
		internal global::AcpUI.AcpRtdButton RTDBtnRadWideBluetoothReplacePairingInfo_A41562;

		// Token: 0x040017BD RID: 6077
		internal global::AcpUI.AcpCopyButton CpyBtnRadWideBluetoothReplacePairingInfo_A41562;

		// Token: 0x040017BE RID: 6078
		internal global::AcpUI.AcpCheckBox RadWideBluetoothReplacePairingInfo_A41562Comp;

		// Token: 0x040017BF RID: 6079
		internal global::AcpUI.AcpCustomViewCheckBox CVBtnRadWideBluetoothActiveRSMInternalMicIfNotBtMic_A41576;

		// Token: 0x040017C0 RID: 6080
		internal global::AcpUI.AcpLabel LblRadWideBluetoothActiveRSMInternalMicIfNotBtMic_A41576;

		// Token: 0x040017C1 RID: 6081
		internal global::AcpUI.AcpCheckBox RadWideBluetoothActiveRSMInternalMicIfNotBtMic_A41576;

		// Token: 0x040017C2 RID: 6082
		internal global::AcpUI.AcpRtdButton RTDBtnRadWideBluetoothActiveRSMInternalMicIfNotBtMic_A41576;

		// Token: 0x040017C3 RID: 6083
		internal global::AcpUI.AcpCopyButton CpyBtnRadWideBluetoothActiveRSMInternalMicIfNotBtMic_A41576;

		// Token: 0x040017C4 RID: 6084
		internal global::AcpUI.AcpCheckBox RadWideBluetoothActiveRSMInternalMicIfNotBtMic_A41576Comp;

		// Token: 0x040017C5 RID: 6085
		internal global::AcpUI.AcpCustomViewCheckBox CVBtnRadWideBluetoothBluetoothDeviceInquiryDuration_41977;

		// Token: 0x040017C6 RID: 6086
		internal global::AcpUI.AcpLabel LblRadWideBluetoothBluetoothDeviceInquiryDuration_41977;

		// Token: 0x040017C7 RID: 6087
		internal global::AcpUI.AcpTextBoxSpinner RadWideBluetoothBluetoothDeviceInquiryDuration_41977;

		// Token: 0x040017C8 RID: 6088
		internal global::AcpUI.AcpRtdButton RTDBtnRadWideBluetoothBluetoothDeviceInquiryDuration_41977;

		// Token: 0x040017C9 RID: 6089
		internal global::AcpUI.AcpCopyButton CpyBtnRadWideBluetoothBluetoothDeviceInquiryDuration_41977;

		// Token: 0x040017CA RID: 6090
		internal global::AcpUI.AcpLabel RadWideBluetoothBluetoothDeviceInquiryDuration_41977Comp;

		// Token: 0x040017CB RID: 6091
		internal global::AcpUI.AcpCustomViewCheckBox CVBtnRadWideBluetoothBluetoothDiscoverableExpirationTimer_41980;

		// Token: 0x040017CC RID: 6092
		internal global::AcpUI.AcpLabel LblRadWideBluetoothBluetoothDiscoverableExpirationTimer_41980;

		// Token: 0x040017CD RID: 6093
		internal global::AcpUI.AcpTextBoxSpinner RadWideBluetoothBluetoothDiscoverableExpirationTimer_41980;

		// Token: 0x040017CE RID: 6094
		internal global::AcpUI.AcpRtdButton RTDBtnRadWideBluetoothBluetoothDiscoverableExpirationTimer_41980;

		// Token: 0x040017CF RID: 6095
		internal global::AcpUI.AcpCopyButton CpyBtnRadWideBluetoothBluetoothDiscoverableExpirationTimer_41980;

		// Token: 0x040017D0 RID: 6096
		internal global::AcpUI.AcpLabel RadWideBluetoothBluetoothDiscoverableExpirationTimer_41980Comp;

		// Token: 0x040017D1 RID: 6097
		internal global::AcpUI.AcpCustomViewCheckBox CVBtnRadWideBluetoothBluetoothPANNetworkAddress_41983;

		// Token: 0x040017D2 RID: 6098
		internal global::AcpUI.AcpLabel LblRadWideBluetoothBluetoothPANNetworkAddress_41983;

		// Token: 0x040017D3 RID: 6099
		internal global::AcpUI.AcpTextBox RadWideBluetoothBluetoothPANNetworkAddress_41983;

		// Token: 0x040017D4 RID: 6100
		internal global::AcpUI.AcpRtdButton RTDBtnRadWideBluetoothBluetoothPANNetworkAddress_41983;

		// Token: 0x040017D5 RID: 6101
		internal global::AcpUI.AcpCopyButton CpyBtnRadWideBluetoothBluetoothPANNetworkAddress_41983;

		// Token: 0x040017D6 RID: 6102
		internal global::AcpUI.AcpLabel RadWideBluetoothBluetoothPANNetworkAddress_41983Comp;

		// Token: 0x040017D7 RID: 6103
		internal global::AcpUI.AcpCustomViewCheckBox CVBtnRadWideBluetoothLegacyPINPairing;

		// Token: 0x040017D8 RID: 6104
		internal global::AcpUI.AcpLabel LblRadWideBluetoothLegacyBluetoothPINPairing;

		// Token: 0x040017D9 RID: 6105
		internal global::AcpUI.AcpCheckBox RadWideBluetoothLegacyBluetoothPINPairing;

		// Token: 0x040017DA RID: 6106
		internal global::AcpUI.AcpRtdButton RTDBtnRadWideBluetoothLegacyBluetoothPINPairing;

		// Token: 0x040017DB RID: 6107
		internal global::AcpUI.AcpCopyButton CpyBtnRadWideBluetoothLegacyBluetoothPINPairing;

		// Token: 0x040017DC RID: 6108
		internal global::AcpUI.AcpCheckBox RadWideBluetoothLegacyBluetoothPINPairingComp;

		// Token: 0x040017DD RID: 6109
		internal global::AcpUI.AcpCustomViewCheckBox CVBtnRadWideBluetoothAudioBackwardsCompatibility_A44942;

		// Token: 0x040017DE RID: 6110
		internal global::AcpUI.AcpLabel LblRadWideBluetoothAudioBackwardsCompatibility_A44942;

		// Token: 0x040017DF RID: 6111
		internal global::AcpUI.AcpCheckBox RadWideBluetoothAudioBackwardsCompatibility_A44942;

		// Token: 0x040017E0 RID: 6112
		internal global::AcpUI.AcpRtdButton RTDBtnRadWideBluetoothAudioBackwardsCompatibility_A44942;

		// Token: 0x040017E1 RID: 6113
		internal global::AcpUI.AcpCopyButton CpyBtnRadWideBluetoothAudioBackwardsCompatibility_A44942;

		// Token: 0x040017E2 RID: 6114
		internal global::AcpUI.AcpCheckBox RadWideBluetoothAudioBackwardsCompatibility_A44942Comp;

		// Token: 0x040017E3 RID: 6115
		internal global::AcpUI.AcpCustomViewCheckBox CVBtnRadWideBluetoothImproveAudioLatency_A44943;

		// Token: 0x040017E4 RID: 6116
		internal global::AcpUI.AcpLabel LblRadWideBluetoothImproveAudioLatency_A44943;

		// Token: 0x040017E5 RID: 6117
		internal global::AcpUI.AcpCheckBox RadWideBluetoothImproveAudioLatency_A44943;

		// Token: 0x040017E6 RID: 6118
		internal global::AcpUI.AcpRtdButton RTDBtnRadWideBluetoothImproveAudioLatency_A44943;

		// Token: 0x040017E7 RID: 6119
		internal global::AcpUI.AcpCopyButton CpyBtnRadWideBluetoothImproveAudioLatency_A44943;

		// Token: 0x040017E8 RID: 6120
		internal global::AcpUI.AcpCheckBox RadWideBluetoothImproveAudioLatency_A44943Comp;

		// Token: 0x040017E9 RID: 6121
		internal global::AcpUI.AcpExpander ExpanderRadioWideLTE;

		// Token: 0x040017EA RID: 6122
		internal global::AcpUI.AcpGroupBox GrpBoxExpanderRadioWideLTEPseudo0;

		// Token: 0x040017EB RID: 6123
		internal global::AcpUI.AcpCustomViewCheckBox CVBtnRadWideLabtoolLTEUsed_A42064;

		// Token: 0x040017EC RID: 6124
		internal global::AcpUI.AcpLabel LblRadWideLabtoolLTEUsed_A42064;

		// Token: 0x040017ED RID: 6125
		internal global::AcpUI.AcpLabel RadWideLabtoolLTEUsed_A42064;

		// Token: 0x040017EE RID: 6126
		internal global::AcpUI.AcpRtdButton RTDBtnRadWideLabtoolLTEUsed_A42064;

		// Token: 0x040017EF RID: 6127
		internal global::AcpUI.AcpCopyButton CpyBtnRadWideLabtoolLTEUsed_A42064;

		// Token: 0x040017F0 RID: 6128
		internal global::AcpUI.AcpLabel RadWideLabtoolLTEUsed_A42064Comp;

		// Token: 0x040017F1 RID: 6129
		internal global::AcpUI.AcpExpander ExpanderRadioWideDepot;

		// Token: 0x040017F2 RID: 6130
		internal global::AcpUI.AcpGroupBox GrpBoxExpanderRadioWideDepotPseudo0;

		// Token: 0x040017F3 RID: 6131
		internal global::AcpUI.AcpCustomViewCheckBox CVBtnAdvancedExternalMicOnly;

		// Token: 0x040017F4 RID: 6132
		internal global::AcpUI.AcpLabel LblAdvancedExternalMicOnly;

		// Token: 0x040017F5 RID: 6133
		internal global::AcpUI.AcpCheckBox AdvancedExternalMicOnly;

		// Token: 0x040017F6 RID: 6134
		internal global::AcpUI.AcpRtdButton RTDBtnAdvancedExternalMicOnly;

		// Token: 0x040017F7 RID: 6135
		internal global::AcpUI.AcpCopyButton CpyBtnAdvancedExternalMicOnly;

		// Token: 0x040017F8 RID: 6136
		internal global::AcpUI.AcpCheckBox AdvancedExternalMicOnlyComp;

		// Token: 0x040017F9 RID: 6137
		internal global::AcpUI.AcpExpander ExpanderRadioWideLabtool;

		// Token: 0x040017FA RID: 6138
		internal global::AcpUI.AcpGroupBox GrpBoxExpanderRadioWideLabtoolPseudo0;

		// Token: 0x040017FB RID: 6139
		internal global::AcpUI.AcpCustomViewCheckBox CVBtnRadWideLabtoolSmartLowBatteryThreshold_A20201;

		// Token: 0x040017FC RID: 6140
		internal global::AcpUI.AcpLabel LblRadWideLabtoolSmartLowBatteryThreshold_A20201;

		// Token: 0x040017FD RID: 6141
		internal global::AcpUI.AcpTextBoxSpinner RadWideLabtoolSmartLowBatteryThreshold_A20201;

		// Token: 0x040017FE RID: 6142
		internal global::AcpUI.AcpRtdButton RTDBtnRadWideLabtoolSmartLowBatteryThreshold_A20201;

		// Token: 0x040017FF RID: 6143
		internal global::AcpUI.AcpCopyButton CpyBtnRadWideLabtoolSmartLowBatteryThreshold_A20201;

		// Token: 0x04001800 RID: 6144
		internal global::AcpUI.AcpLabel RadWideLabtoolSmartLowBatteryThreshold_A20201Comp;

		// Token: 0x04001801 RID: 6145
		internal global::AcpUI.AcpCustomViewCheckBox CVBtnRadWideLabtoolEarlyWarningBatteryThreshold_A23977;

		// Token: 0x04001802 RID: 6146
		internal global::AcpUI.AcpLabel LblRadWideLabtoolEarlyWarningBatteryThreshold_A23977;

		// Token: 0x04001803 RID: 6147
		internal global::AcpUI.AcpTextBoxSpinner RadWideLabtoolEarlyWarningBatteryThreshold_A23977;

		// Token: 0x04001804 RID: 6148
		internal global::AcpUI.AcpRtdButton RTDBtnRadWideLabtoolEarlyWarningBatteryThreshold_A23977;

		// Token: 0x04001805 RID: 6149
		internal global::AcpUI.AcpCopyButton CpyBtnRadWideLabtoolEarlyWarningBatteryThreshold_A23977;

		// Token: 0x04001806 RID: 6150
		internal global::AcpUI.AcpLabel RadWideLabtoolEarlyWarningBatteryThreshold_A23977Comp;

		// Token: 0x04001807 RID: 6151
		internal global::AcpUI.AcpCustomViewCheckBox CVBtnRadWideLabtoolRadioPassword_A8837;

		// Token: 0x04001808 RID: 6152
		internal global::AcpUI.AcpLabel LblRadWideLabtoolRadioPassword_A8837;

		// Token: 0x04001809 RID: 6153
		internal global::AcpUI.AcpLabel RadWideLabtoolRadioPassword_A8837;

		// Token: 0x0400180A RID: 6154
		internal global::AcpUI.AcpRtdButton RTDBtnRadWideLabtoolRadioPassword_A8837;

		// Token: 0x0400180B RID: 6155
		internal global::AcpUI.AcpCopyButton CpyBtnRadWideLabtoolRadioPassword_A8837;

		// Token: 0x0400180C RID: 6156
		internal global::AcpUI.AcpLabel RadWideLabtoolRadioPassword_A8837Comp;

		// Token: 0x0400180D RID: 6157
		internal global::AcpUI.AcpCustomViewCheckBox CVBtnRadWideLabtoolConsoletteModelEnable_A7713;

		// Token: 0x0400180E RID: 6158
		internal global::AcpUI.AcpLabel LblRadWideLabtoolConsoletteModelEnable_A7713;

		// Token: 0x0400180F RID: 6159
		internal global::AcpUI.AcpCheckBox RadWideLabtoolConsoletteModelEnable_A7713;

		// Token: 0x04001810 RID: 6160
		internal global::AcpUI.AcpRtdButton RTDBtnRadWideLabtoolConsoletteModelEnable_A7713;

		// Token: 0x04001811 RID: 6161
		internal global::AcpUI.AcpCopyButton CpyBtnRadWideLabtoolConsoletteModelEnable_A7713;

		// Token: 0x04001812 RID: 6162
		internal global::AcpUI.AcpCheckBox RadWideLabtoolConsoletteModelEnable_A7713Comp;

		// Token: 0x04001813 RID: 6163
		internal global::AcpUI.AcpCustomViewCheckBox CVBtnRadWideLabtoolFatalError_A8015;

		// Token: 0x04001814 RID: 6164
		internal global::AcpUI.AcpLabel LblRadWideLabtoolFatalError_A8015;

		// Token: 0x04001815 RID: 6165
		internal global::AcpUI.AcpCheckBox RadWideLabtoolFatalError_A8015;

		// Token: 0x04001816 RID: 6166
		internal global::AcpUI.AcpRtdButton RTDBtnRadWideLabtoolFatalError_A8015;

		// Token: 0x04001817 RID: 6167
		internal global::AcpUI.AcpCopyButton CpyBtnRadWideLabtoolFatalError_A8015;

		// Token: 0x04001818 RID: 6168
		internal global::AcpUI.AcpCheckBox RadWideLabtoolFatalError_A8015Comp;

		// Token: 0x04001819 RID: 6169
		internal global::AcpUI.AcpCustomViewCheckBox CVBtnRadWideLabtoolArchiveReadPasswordEnable_A7462;

		// Token: 0x0400181A RID: 6170
		internal global::AcpUI.AcpLabel LblRadWideLabtoolArchiveReadPasswordEnable_A7462;

		// Token: 0x0400181B RID: 6171
		internal global::AcpUI.AcpLabel RadWideLabtoolArchiveReadPasswordEnable_A7462;

		// Token: 0x0400181C RID: 6172
		internal global::AcpUI.AcpRtdButton RTDBtnRadWideLabtoolArchiveReadPasswordEnable_A7462;

		// Token: 0x0400181D RID: 6173
		internal global::AcpUI.AcpCopyButton CpyBtnRadWideLabtoolArchiveReadPasswordEnable_A7462;

		// Token: 0x0400181E RID: 6174
		internal global::AcpUI.AcpLabel RadWideLabtoolArchiveReadPasswordEnable_A7462Comp;

		// Token: 0x0400181F RID: 6175
		internal global::AcpUI.AcpCustomViewCheckBox CVBtnRadWideLabtoolControlHeadSelection_A7723;

		// Token: 0x04001820 RID: 6176
		internal global::AcpUI.AcpLabel LblRadWideLabtoolControlHeadSelection_A7723;

		// Token: 0x04001821 RID: 6177
		internal global::AcpUI.AcpComboBox RadWideLabtoolControlHeadSelection_A7723;

		// Token: 0x04001822 RID: 6178
		internal global::AcpUI.AcpRtdButton RTDBtnRadWideLabtoolControlHeadSelection_A7723;

		// Token: 0x04001823 RID: 6179
		internal global::AcpUI.AcpCopyButton CpyBtnRadWideLabtoolControlHeadSelection_A7723;

		// Token: 0x04001824 RID: 6180
		internal global::AcpUI.AcpLabel RadWideLabtoolControlHeadSelection_A7723Comp;

		// Token: 0x04001825 RID: 6181
		internal global::AcpUI.AcpCustomViewCheckBox CVBtnRadWideLabtoolKeypadType_A8372;

		// Token: 0x04001826 RID: 6182
		internal global::AcpUI.AcpLabel LblRadWideLabtoolKeypadType_A8372;

		// Token: 0x04001827 RID: 6183
		internal global::AcpUI.AcpComboBox RadWideLabtoolKeypadType_A8372;

		// Token: 0x04001828 RID: 6184
		internal global::AcpUI.AcpRtdButton RTDBtnRadWideLabtoolKeypadType_A8372;

		// Token: 0x04001829 RID: 6185
		internal global::AcpUI.AcpCopyButton CpyBtnRadWideLabtoolKeypadType_A8372;

		// Token: 0x0400182A RID: 6186
		internal global::AcpUI.AcpLabel RadWideLabtoolKeypadType_A8372Comp;

		// Token: 0x0400182B RID: 6187
		internal global::AcpUI.AcpCustomViewCheckBox CVBtnRadWideLabtoolZoneSelectorOnSwitch_A19550;

		// Token: 0x0400182C RID: 6188
		internal global::AcpUI.AcpLabel LblRadWideLabtoolZoneSelectorOnSwitch_A19550;

		// Token: 0x0400182D RID: 6189
		internal global::AcpUI.AcpCheckBox RadWideLabtoolZoneSelectorOnSwitch_A19550;

		// Token: 0x0400182E RID: 6190
		internal global::AcpUI.AcpRtdButton RTDBtnRadWideLabtoolZoneSelectorOnSwitch_A19550;

		// Token: 0x0400182F RID: 6191
		internal global::AcpUI.AcpCopyButton CpyBtnRadWideLabtoolZoneSelectorOnSwitch_A19550;

		// Token: 0x04001830 RID: 6192
		internal global::AcpUI.AcpCheckBox RadWideLabtoolZoneSelectorOnSwitch_A19550Comp;

		// Token: 0x04001831 RID: 6193
		internal global::AcpUI.AcpCustomViewCheckBox CVBtnRadWideLabtoolChannelSelectorOnSwitch_A19551;

		// Token: 0x04001832 RID: 6194
		internal global::AcpUI.AcpLabel LblRadWideLabtoolChannelSelectorOnSwitch_A19551;

		// Token: 0x04001833 RID: 6195
		internal global::AcpUI.AcpCheckBox RadWideLabtoolChannelSelectorOnSwitch_A19551;

		// Token: 0x04001834 RID: 6196
		internal global::AcpUI.AcpRtdButton RTDBtnRadWideLabtoolChannelSelectorOnSwitch_A19551;

		// Token: 0x04001835 RID: 6197
		internal global::AcpUI.AcpCopyButton CpyBtnRadWideLabtoolChannelSelectorOnSwitch_A19551;

		// Token: 0x04001836 RID: 6198
		internal global::AcpUI.AcpCheckBox RadWideLabtoolChannelSelectorOnSwitch_A19551Comp;

		// Token: 0x04001837 RID: 6199
		internal global::AcpUI.AcpCustomViewCheckBox CVBtnRadWideLabtoolDisplayType_A7887;

		// Token: 0x04001838 RID: 6200
		internal global::AcpUI.AcpLabel LblRadWideLabtoolDisplayType_A7887;

		// Token: 0x04001839 RID: 6201
		internal global::AcpUI.AcpComboBox RadWideLabtoolDisplayType_A7887;

		// Token: 0x0400183A RID: 6202
		internal global::AcpUI.AcpRtdButton RTDBtnRadWideLabtoolDisplayType_A7887;

		// Token: 0x0400183B RID: 6203
		internal global::AcpUI.AcpCopyButton CpyBtnRadWideLabtoolDisplayType_A7887;

		// Token: 0x0400183C RID: 6204
		internal global::AcpUI.AcpLabel RadWideLabtoolDisplayType_A7887Comp;

		// Token: 0x0400183D RID: 6205
		internal global::AcpUI.AcpCustomViewCheckBox CVBtnRadWideLabtoolFlipDisplayOption_A8140;

		// Token: 0x0400183E RID: 6206
		internal global::AcpUI.AcpLabel LblRadWideLabtoolFlipDisplayOption_A8140;

		// Token: 0x0400183F RID: 6207
		internal global::AcpUI.AcpCheckBox RadWideLabtoolFlipDisplayOption_A8140;

		// Token: 0x04001840 RID: 6208
		internal global::AcpUI.AcpRtdButton RTDBtnRadWideLabtoolFlipDisplayOption_A8140;

		// Token: 0x04001841 RID: 6209
		internal global::AcpUI.AcpCopyButton CpyBtnRadWideLabtoolFlipDisplayOption_A8140;

		// Token: 0x04001842 RID: 6210
		internal global::AcpUI.AcpCheckBox RadWideLabtoolFlipDisplayOption_A8140Comp;

		// Token: 0x04001843 RID: 6211
		internal global::AcpUI.AcpCustomViewCheckBox CVBtnRadWideLabtoolFreeRevolvingRotary_A8147;

		// Token: 0x04001844 RID: 6212
		internal global::AcpUI.AcpLabel LblRadWideLabtoolFreeRevolvingRotary_A8147;

		// Token: 0x04001845 RID: 6213
		internal global::AcpUI.AcpCheckBox RadWideLabtoolFreeRevolvingRotary_A8147;

		// Token: 0x04001846 RID: 6214
		internal global::AcpUI.AcpRtdButton RTDBtnRadWideLabtoolFreeRevolvingRotary_A8147;

		// Token: 0x04001847 RID: 6215
		internal global::AcpUI.AcpCopyButton CpyBtnRadWideLabtoolFreeRevolvingRotary_A8147;

		// Token: 0x04001848 RID: 6216
		internal global::AcpUI.AcpCheckBox RadWideLabtoolFreeRevolvingRotary_A8147Comp;

		// Token: 0x04001849 RID: 6217
		internal global::AcpUI.AcpCustomViewCheckBox CVBtnRadWideLabtoolRadioWritePasswordEnable_A8889;

		// Token: 0x0400184A RID: 6218
		internal global::AcpUI.AcpLabel LblRadWideLabtoolRadioWritePasswordEnable_A8889;

		// Token: 0x0400184B RID: 6219
		internal global::AcpUI.AcpLabel RadWideLabtoolRadioWritePasswordEnable_A8889;

		// Token: 0x0400184C RID: 6220
		internal global::AcpUI.AcpRtdButton RTDBtnRadWideLabtoolRadioWritePasswordEnable_A8889;

		// Token: 0x0400184D RID: 6221
		internal global::AcpUI.AcpCopyButton CpyBtnRadWideLabtoolRadioWritePasswordEnable_A8889;

		// Token: 0x0400184E RID: 6222
		internal global::AcpUI.AcpLabel RadWideLabtoolRadioWritePasswordEnable_A8889Comp;

		// Token: 0x0400184F RID: 6223
		internal global::AcpUI.AcpCustomViewCheckBox CVBtnRadWideLabtoolRadioReadPasswordEnable_A8869;

		// Token: 0x04001850 RID: 6224
		internal global::AcpUI.AcpLabel LblRadWideLabtoolRadioReadPasswordEnable_A8869;

		// Token: 0x04001851 RID: 6225
		internal global::AcpUI.AcpLabel RadWideLabtoolRadioReadPasswordEnable_A8869;

		// Token: 0x04001852 RID: 6226
		internal global::AcpUI.AcpRtdButton RTDBtnRadWideLabtoolRadioReadPasswordEnable_A8869;

		// Token: 0x04001853 RID: 6227
		internal global::AcpUI.AcpCopyButton CpyBtnRadWideLabtoolRadioReadPasswordEnable_A8869;

		// Token: 0x04001854 RID: 6228
		internal global::AcpUI.AcpLabel RadWideLabtoolRadioReadPasswordEnable_A8869Comp;

		// Token: 0x04001855 RID: 6229
		internal global::AcpUI.AcpCustomViewCheckBox CVBtnRadWideLabtoolDisplayContrastConfiguration_A7873;

		// Token: 0x04001856 RID: 6230
		internal global::AcpUI.AcpLabel LblRadWideLabtoolDisplayContrastConfiguration_A7873;

		// Token: 0x04001857 RID: 6231
		internal global::AcpUI.AcpTextBoxDecHex RadWideLabtoolDisplayContrastConfiguration_A7873;

		// Token: 0x04001858 RID: 6232
		internal global::AcpUI.AcpRtdButton RTDBtnRadWideLabtoolDisplayContrastConfiguration_A7873;

		// Token: 0x04001859 RID: 6233
		internal global::AcpUI.AcpCopyButton CpyBtnRadWideLabtoolDisplayContrastConfiguration_A7873;

		// Token: 0x0400185A RID: 6234
		internal global::AcpUI.AcpTextBoxDecHex RadWideLabtoolDisplayContrastConfiguration_A7873Comp;

		// Token: 0x0400185B RID: 6235
		internal global::AcpUI.AcpCustomViewCheckBox CVBtnRadWideLabtoolControlHeadConfiguration_A7722;

		// Token: 0x0400185C RID: 6236
		internal global::AcpUI.AcpLabel LblRadWideLabtoolControlHeadConfiguration_A7722;

		// Token: 0x0400185D RID: 6237
		internal global::AcpUI.AcpCheckBox RadWideLabtoolControlHeadConfiguration_A7722;

		// Token: 0x0400185E RID: 6238
		internal global::AcpUI.AcpRtdButton RTDBtnRadWideLabtoolControlHeadConfiguration_A7722;

		// Token: 0x0400185F RID: 6239
		internal global::AcpUI.AcpCopyButton CpyBtnRadWideLabtoolControlHeadConfiguration_A7722;

		// Token: 0x04001860 RID: 6240
		internal global::AcpUI.AcpCheckBox RadWideLabtoolControlHeadConfiguration_A7722Comp;

		// Token: 0x04001861 RID: 6241
		internal global::AcpUI.AcpCustomViewCheckBox CVBtnRadWideLabtoolReadWriteVoiceFiles_A8893;

		// Token: 0x04001862 RID: 6242
		internal global::AcpUI.AcpLabel LblRadWideLabtoolReadWriteVoiceFiles_A8893;

		// Token: 0x04001863 RID: 6243
		internal global::AcpUI.AcpCheckBox RadWideLabtoolReadWriteVoiceFiles_A8893;

		// Token: 0x04001864 RID: 6244
		internal global::AcpUI.AcpRtdButton RTDBtnRadWideLabtoolReadWriteVoiceFiles_A8893;

		// Token: 0x04001865 RID: 6245
		internal global::AcpUI.AcpCopyButton CpyBtnRadWideLabtoolReadWriteVoiceFiles_A8893;

		// Token: 0x04001866 RID: 6246
		internal global::AcpUI.AcpCheckBox RadWideLabtoolReadWriteVoiceFiles_A8893Comp;

		// Token: 0x04001867 RID: 6247
		internal global::AcpUI.AcpCustomViewCheckBox CVBtnRadWideLabtoolSirenPaFatalError_A9141;

		// Token: 0x04001868 RID: 6248
		internal global::AcpUI.AcpLabel LblRadWideLabtoolSirenPaFatalError_A9141;

		// Token: 0x04001869 RID: 6249
		internal global::AcpUI.AcpCheckBox RadWideLabtoolSirenPaFatalError_A9141;

		// Token: 0x0400186A RID: 6250
		internal global::AcpUI.AcpRtdButton RTDBtnRadWideLabtoolSirenPaFatalError_A9141;

		// Token: 0x0400186B RID: 6251
		internal global::AcpUI.AcpCopyButton CpyBtnRadWideLabtoolSirenPaFatalError_A9141;

		// Token: 0x0400186C RID: 6252
		internal global::AcpUI.AcpCheckBox RadWideLabtoolSirenPaFatalError_A9141Comp;

		// Token: 0x0400186D RID: 6253
		internal global::AcpUI.AcpCustomViewCheckBox CVBtnRadWideLabtoolSirenPaOnly_A9142;

		// Token: 0x0400186E RID: 6254
		internal global::AcpUI.AcpLabel LblRadWideLabtoolSirenPaOnly_A9142;

		// Token: 0x0400186F RID: 6255
		internal global::AcpUI.AcpCheckBox RadWideLabtoolSirenPaOnly_A9142;

		// Token: 0x04001870 RID: 6256
		internal global::AcpUI.AcpRtdButton RTDBtnRadWideLabtoolSirenPaOnly_A9142;

		// Token: 0x04001871 RID: 6257
		internal global::AcpUI.AcpCopyButton CpyBtnRadWideLabtoolSirenPaOnly_A9142;

		// Token: 0x04001872 RID: 6258
		internal global::AcpUI.AcpCheckBox RadWideLabtoolSirenPaOnly_A9142Comp;

		// Token: 0x04001873 RID: 6259
		internal global::AcpUI.AcpCustomViewCheckBox CVBtnRadWideLabtoolSirenPaSystemLookup_A9143;

		// Token: 0x04001874 RID: 6260
		internal global::AcpUI.AcpLabel LblRadWideLabtoolSirenPaSystemLookup_A9143;

		// Token: 0x04001875 RID: 6261
		internal global::AcpUI.AcpCheckBox RadWideLabtoolSirenPaSystemLookup_A9143;

		// Token: 0x04001876 RID: 6262
		internal global::AcpUI.AcpRtdButton RTDBtnRadWideLabtoolSirenPaSystemLookup_A9143;

		// Token: 0x04001877 RID: 6263
		internal global::AcpUI.AcpCopyButton CpyBtnRadWideLabtoolSirenPaSystemLookup_A9143;

		// Token: 0x04001878 RID: 6264
		internal global::AcpUI.AcpCheckBox RadWideLabtoolSirenPaSystemLookup_A9143Comp;

		// Token: 0x04001879 RID: 6265
		internal global::AcpUI.AcpCustomViewCheckBox CVBtnRadWideLabtoolSirenAndLightsKeypadEnable_A41413;

		// Token: 0x0400187A RID: 6266
		internal global::AcpUI.AcpLabel LblRadWideLabtoolSirenAndLightsKeypadEnable_A41413;

		// Token: 0x0400187B RID: 6267
		internal global::AcpUI.AcpLabel RadWideLabtoolSirenAndLightsKeypadEnable_A41413;

		// Token: 0x0400187C RID: 6268
		internal global::AcpUI.AcpRtdButton RTDBtnRadWideLabtoolSirenAndLightsKeypadEnable_A41413;

		// Token: 0x0400187D RID: 6269
		internal global::AcpUI.AcpCopyButton CpyBtnRadWideLabtoolSirenAndLightsKeypadEnable_A41413;

		// Token: 0x0400187E RID: 6270
		internal global::AcpUI.AcpLabel RadWideLabtoolSirenAndLightsKeypadEnable_A41413Comp;

		// Token: 0x0400187F RID: 6271
		internal global::AcpUI.AcpCustomViewCheckBox CVBtnTrunkingRadioInhibited_A19483;

		// Token: 0x04001880 RID: 6272
		internal global::AcpUI.AcpLabel LblTrunkingRadioInhibited_A19483;

		// Token: 0x04001881 RID: 6273
		internal global::AcpUI.AcpCheckBox TrunkingRadioInhibited_A19483;

		// Token: 0x04001882 RID: 6274
		internal global::AcpUI.AcpRtdButton RTDBtnTrunkingRadioInhibited_A19483;

		// Token: 0x04001883 RID: 6275
		internal global::AcpUI.AcpCopyButton CpyBtnTrunkingRadioInhibited_A19483;

		// Token: 0x04001884 RID: 6276
		internal global::AcpUI.AcpCheckBox TrunkingRadioInhibited_A19483Comp;

		// Token: 0x04001885 RID: 6277
		internal global::AcpUI.AcpCustomViewCheckBox CVBtnRadWideLabtoolDynamicZoneCable_A41258;

		// Token: 0x04001886 RID: 6278
		internal global::AcpUI.AcpLabel LblRadWideLabtoolDynamicZoneCable_A41258;

		// Token: 0x04001887 RID: 6279
		internal global::AcpUI.AcpLabel RadWideLabtoolDynamicZoneCable_A41258;

		// Token: 0x04001888 RID: 6280
		internal global::AcpUI.AcpRtdButton RTDBtnRadWideLabtoolDynamicZoneCable_A41258;

		// Token: 0x04001889 RID: 6281
		internal global::AcpUI.AcpCopyButton CpyBtnRadWideLabtoolDynamicZoneCable_A41258;

		// Token: 0x0400188A RID: 6282
		internal global::AcpUI.AcpLabel RadWideLabtoolDynamicZoneCable_A41258Comp;

		// Token: 0x0400188B RID: 6283
		internal global::AcpUI.AcpCustomViewCheckBox CVBtnRadWideEmergencyRxTxAlertToneSet_A41508;

		// Token: 0x0400188C RID: 6284
		internal global::AcpUI.AcpLabel LblRadWideEmergencyRxTxAlertToneSet_A41508;

		// Token: 0x0400188D RID: 6285
		internal global::AcpUI.AcpComboBox RadWideEmergencyRxTxAlertToneSet_A41508;

		// Token: 0x0400188E RID: 6286
		internal global::AcpUI.AcpRtdButton RTDBtnRadWideEmergencyRxTxAlertToneSet_A41508;

		// Token: 0x0400188F RID: 6287
		internal global::AcpUI.AcpCopyButton CpyBtnRadWideEmergencyRxTxAlertToneSet_A41508;

		// Token: 0x04001890 RID: 6288
		internal global::AcpUI.AcpLabel RadWideEmergencyRxTxAlertToneSet_A41508Comp;

		// Token: 0x04001891 RID: 6289
		internal global::AcpUI.AcpCustomViewCheckBox CVBtnRadWideRadioKilled_A41559;

		// Token: 0x04001892 RID: 6290
		internal global::AcpUI.AcpLabel LblRadWideRadioKilled_A41559;

		// Token: 0x04001893 RID: 6291
		internal global::AcpUI.AcpCheckBox RadWideRadioKilled_A41559;

		// Token: 0x04001894 RID: 6292
		internal global::AcpUI.AcpRtdButton RTDBtnRadWideRadioKilled_A41559;

		// Token: 0x04001895 RID: 6293
		internal global::AcpUI.AcpCopyButton CpyBtnRadWideRadioKilled_A41559;

		// Token: 0x04001896 RID: 6294
		internal global::AcpUI.AcpCheckBox RadWideRadioKilled_A41559Comp;

		// Token: 0x04001897 RID: 6295
		internal global::AcpUI.AcpCustomViewCheckBox CVBtnRadWideLabtoolEncryptPassword_A41695;

		// Token: 0x04001898 RID: 6296
		internal global::AcpUI.AcpLabel LblRadWideLabtoolEncryptPassword_A41695;

		// Token: 0x04001899 RID: 6297
		internal global::AcpUI.AcpLabel RadWideLabtoolEncryptPassword_A41695;

		// Token: 0x0400189A RID: 6298
		internal global::AcpUI.AcpRtdButton RTDBtnRadWideLabtoolEncryptPassword_A41695;

		// Token: 0x0400189B RID: 6299
		internal global::AcpUI.AcpCopyButton CpyBtnRadWideLabtoolEncryptPassword_A41695;

		// Token: 0x0400189C RID: 6300
		internal global::AcpUI.AcpLabel RadWideLabtoolEncryptPassword_A41695Comp;

		// Token: 0x0400189D RID: 6301
		internal global::AcpUI.AcpCustomViewCheckBox CVBtnRadWideLabtoolEncryptedPINPassword_A41702;

		// Token: 0x0400189E RID: 6302
		internal global::AcpUI.AcpLabel LblRadWideLabtoolEncryptedPINPassword_A41702;

		// Token: 0x0400189F RID: 6303
		internal global::AcpUI.AcpTextBox RadWideLabtoolEncryptedPINPassword_A41702;

		// Token: 0x040018A0 RID: 6304
		internal global::AcpUI.AcpRtdButton RTDBtnRadWideLabtoolEncryptedPINPassword_A41702;

		// Token: 0x040018A1 RID: 6305
		internal global::AcpUI.AcpCopyButton CpyBtnRadWideLabtoolEncryptedPINPassword_A41702;

		// Token: 0x040018A2 RID: 6306
		internal global::AcpUI.AcpLabel RadWideLabtoolEncryptedPINPassword_A41702Comp;

		// Token: 0x040018A3 RID: 6307
		internal global::AcpUI.AcpCustomViewCheckBox CVBtnRadioWideReqFWVersion_A42872;

		// Token: 0x040018A4 RID: 6308
		internal global::AcpUI.AcpLabel LblRadioWideReqFWVersion_A42872;

		// Token: 0x040018A5 RID: 6309
		internal global::AcpUI.AcpTextBox RadioWideReqFWVersion_A42872;

		// Token: 0x040018A6 RID: 6310
		internal global::AcpUI.AcpRtdButton RTDBtnRadioWideReqFWVersion_A42872;

		// Token: 0x040018A7 RID: 6311
		internal global::AcpUI.AcpCopyButton CpyBtnRadioWideReqFWVersion_A42872;

		// Token: 0x040018A8 RID: 6312
		internal global::AcpUI.AcpLabel RadioWideReqFWVersion_A42872Comp;

		// Token: 0x040018A9 RID: 6313
		internal global::AcpUI.AcpCustomViewCheckBox CVBtnRadWideLabtoolSeamlessUpdateOutOfBoxExperience;

		// Token: 0x040018AA RID: 6314
		internal global::AcpUI.AcpLabel LblRadWideLabtoolSeamlessUpdateOutOfBoxExperience;

		// Token: 0x040018AB RID: 6315
		internal global::AcpUI.AcpLabel RadWideLabtoolSeamlessUpdateOutOfBoxExperience;

		// Token: 0x040018AC RID: 6316
		internal global::AcpUI.AcpRtdButton RTDBtnRadWideLabtoolSeamlessUpdateOutOfBoxExperience;

		// Token: 0x040018AD RID: 6317
		internal global::AcpUI.AcpCopyButton CpyBtnRadWideLabtoolSeamlessUpdateOutOfBoxExperience;

		// Token: 0x040018AE RID: 6318
		internal global::AcpUI.AcpLabel RadWideLabtoolSeamlessUpdateOutOfBoxExperienceComp;

		// Token: 0x040018AF RID: 6319
		internal global::AcpUI.AcpGroupBox GrpBoxExpanderRadioWideLabtoolProductCapabilityIndicators;

		// Token: 0x040018B0 RID: 6320
		internal global::AcpUI.AcpCustomViewCheckBox CVBtnRadWideLabtoolUltraLowPowerSoldierMacCapable_A41710;

		// Token: 0x040018B1 RID: 6321
		internal global::AcpUI.AcpLabel LblRadWideLabtoolUltraLowPowerSoldierMacCapable_A41710;

		// Token: 0x040018B2 RID: 6322
		internal global::AcpUI.AcpLabel RadWideLabtoolUltraLowPowerSoldierMacCapable_A41710;

		// Token: 0x040018B3 RID: 6323
		internal global::AcpUI.AcpRtdButton RTDBtnRadWideLabtoolUltraLowPowerSoldierMacCapable_A41710;

		// Token: 0x040018B4 RID: 6324
		internal global::AcpUI.AcpCopyButton CpyBtnRadWideLabtoolUltraLowPowerSoldierMacCapable_A41710;

		// Token: 0x040018B5 RID: 6325
		internal global::AcpUI.AcpLabel RadWideLabtoolUltraLowPowerSoldierMacCapable_A41710Comp;

		// Token: 0x040018B6 RID: 6326
		internal global::AcpUI.AcpCustomViewCheckBox CVBtnRadWideLabtoolEmergencyRevertCapable_A41918;

		// Token: 0x040018B7 RID: 6327
		internal global::AcpUI.AcpLabel LblRadWideLabtoolEmergencyRevertCapable_A41918;

		// Token: 0x040018B8 RID: 6328
		internal global::AcpUI.AcpLabel RadWideLabtoolEmergencyRevertCapable_A41918;

		// Token: 0x040018B9 RID: 6329
		internal global::AcpUI.AcpRtdButton RTDBtnRadWideLabtoolEmergencyRevertCapable_A41918;

		// Token: 0x040018BA RID: 6330
		internal global::AcpUI.AcpCopyButton CpyBtnRadWideLabtoolEmergencyRevertCapable_A41918;

		// Token: 0x040018BB RID: 6331
		internal global::AcpUI.AcpLabel RadWideLabtoolEmergencyRevertCapable_A41918Comp;

		// Token: 0x040018BC RID: 6332
		internal global::AcpUI.AcpCustomViewCheckBox CVBtnRadWideLabtoolAudibleBeaconRoutingCapable_A41974;

		// Token: 0x040018BD RID: 6333
		internal global::AcpUI.AcpLabel LblRadWideLabtoolAudibleBeaconRoutingCapable_A41974;

		// Token: 0x040018BE RID: 6334
		internal global::AcpUI.AcpLabel RadWideLabtoolAudibleBeaconRoutingCapable_A41974;

		// Token: 0x040018BF RID: 6335
		internal global::AcpUI.AcpRtdButton RTDBtnRadWideLabtoolAudibleBeaconRoutingCapable_A41974;

		// Token: 0x040018C0 RID: 6336
		internal global::AcpUI.AcpCopyButton CpyBtnRadWideLabtoolAudibleBeaconRoutingCapable_A41974;

		// Token: 0x040018C1 RID: 6337
		internal global::AcpUI.AcpLabel RadWideLabtoolAudibleBeaconRoutingCapable_A41974Comp;

		// Token: 0x040018C2 RID: 6338
		internal global::AcpUI.AcpCustomViewCheckBox CVBtnRadWideLabtoolAPX6000P25Radio_A42121;

		// Token: 0x040018C3 RID: 6339
		internal global::AcpUI.AcpLabel LblRadWideLabtoolAPX6000P25Radio_A42121;

		// Token: 0x040018C4 RID: 6340
		internal global::AcpUI.AcpLabel RadWideLabtoolAPX6000P25Radio_A42121;

		// Token: 0x040018C5 RID: 6341
		internal global::AcpUI.AcpRtdButton RTDBtnRadWideLabtoolAPX6000P25Radio_A42121;

		// Token: 0x040018C6 RID: 6342
		internal global::AcpUI.AcpCopyButton CpyBtnRadWideLabtoolAPX6000P25Radio_A42121;

		// Token: 0x040018C7 RID: 6343
		internal global::AcpUI.AcpLabel RadWideLabtoolAPX6000P25Radio_A42121Comp;

		// Token: 0x040018C8 RID: 6344
		internal global::AcpUI.AcpCustomViewCheckBox CVBtnRadWideLabtoolSuppressEmergencyCallCapability_A42143;

		// Token: 0x040018C9 RID: 6345
		internal global::AcpUI.AcpLabel LblRadWideLabtoolSuppressEmergencyCallCapability_A42143;

		// Token: 0x040018CA RID: 6346
		internal global::AcpUI.AcpLabel RadWideLabtoolSuppressEmergencyCallCapability_A42143;

		// Token: 0x040018CB RID: 6347
		internal global::AcpUI.AcpRtdButton RTDBtnRadWideLabtoolSuppressEmergencyCallCapability_A42143;

		// Token: 0x040018CC RID: 6348
		internal global::AcpUI.AcpCopyButton CpyBtnRadWideLabtoolSuppressEmergencyCallCapability_A42143;

		// Token: 0x040018CD RID: 6349
		internal global::AcpUI.AcpLabel RadWideLabtoolSuppressEmergencyCallCapability_A42143Comp;

		// Token: 0x040018CE RID: 6350
		internal global::AcpUI.AcpCustomViewCheckBox CVBtnRadWideLabtoolMaritimeRadioSoftware_A42191;

		// Token: 0x040018CF RID: 6351
		internal global::AcpUI.AcpLabel LblRadWideLabtoolMaritimeRadioSoftware_A42191;

		// Token: 0x040018D0 RID: 6352
		internal global::AcpUI.AcpLabel RadWideLabtoolMaritimeRadioSoftware_A42191;

		// Token: 0x040018D1 RID: 6353
		internal global::AcpUI.AcpRtdButton RTDBtnRadWideLabtoolMaritimeRadioSoftware_A42191;

		// Token: 0x040018D2 RID: 6354
		internal global::AcpUI.AcpCopyButton CpyBtnRadWideLabtoolMaritimeRadioSoftware_A42191;

		// Token: 0x040018D3 RID: 6355
		internal global::AcpUI.AcpLabel RadWideLabtoolMaritimeRadioSoftware_A42191Comp;

		// Token: 0x040018D4 RID: 6356
		internal global::AcpUI.AcpCustomViewCheckBox CVBtnRadWideLabtoolMFKEmergencyAccess_A42216;

		// Token: 0x040018D5 RID: 6357
		internal global::AcpUI.AcpLabel LblRadWideLabtoolMFKEmergencyAccess_A42216;

		// Token: 0x040018D6 RID: 6358
		internal global::AcpUI.AcpLabel RadWideLabtoolMFKEmergencyAccess_A42216;

		// Token: 0x040018D7 RID: 6359
		internal global::AcpUI.AcpRtdButton RTDBtnRadWideLabtoolMFKEmergencyAccess_A42216;

		// Token: 0x040018D8 RID: 6360
		internal global::AcpUI.AcpCopyButton CpyBtnRadWideLabtoolMFKEmergencyAccess_A42216;

		// Token: 0x040018D9 RID: 6361
		internal global::AcpUI.AcpLabel RadWideLabtoolMFKEmergencyAccess_A42216Comp;

		// Token: 0x040018DA RID: 6362
		internal global::AcpUI.AcpCustomViewCheckBox CVBtnManDownPersonalityConfigurableCapable_42082;

		// Token: 0x040018DB RID: 6363
		internal global::AcpUI.AcpLabel LblManDownPersonalityConfigurableCapable_42082;

		// Token: 0x040018DC RID: 6364
		internal global::AcpUI.AcpLabel ManDownPersonalityConfigurableCapable_42082;

		// Token: 0x040018DD RID: 6365
		internal global::AcpUI.AcpRtdButton RTDBtnManDownPersonalityConfigurableCapable_42082;

		// Token: 0x040018DE RID: 6366
		internal global::AcpUI.AcpCopyButton CpyBtnManDownPersonalityConfigurableCapable_42082;

		// Token: 0x040018DF RID: 6367
		internal global::AcpUI.AcpLabel ManDownPersonalityConfigurableCapable_42082Comp;

		// Token: 0x040018E0 RID: 6368
		internal global::AcpUI.AcpCustomViewCheckBox CVBtnToneEmergencyConfigurableCapable_42083;

		// Token: 0x040018E1 RID: 6369
		internal global::AcpUI.AcpLabel LblToneEmergencyConfigurableCapable_42083;

		// Token: 0x040018E2 RID: 6370
		internal global::AcpUI.AcpLabel ToneEmergencyConfigurableCapable_42083;

		// Token: 0x040018E3 RID: 6371
		internal global::AcpUI.AcpRtdButton RTDBtnToneEmergencyConfigurableCapable_42083;

		// Token: 0x040018E4 RID: 6372
		internal global::AcpUI.AcpCopyButton CpyBtnToneEmergencyConfigurableCapable_42083;

		// Token: 0x040018E5 RID: 6373
		internal global::AcpUI.AcpLabel ToneEmergencyConfigurableCapable_42083Comp;

		// Token: 0x040018E6 RID: 6374
		internal global::AcpUI.AcpCustomViewCheckBox CVBtnEmergencyHotAuxMicConfigurability_A42301;

		// Token: 0x040018E7 RID: 6375
		internal global::AcpUI.AcpLabel LblEmergencyHotAuxMicConfigurability_A42301;

		// Token: 0x040018E8 RID: 6376
		internal global::AcpUI.AcpLabel EmergencyHotAuxMicConfigurability_A42301;

		// Token: 0x040018E9 RID: 6377
		internal global::AcpUI.AcpRtdButton RTDBtnEmergencyHotAuxMicConfigurability_A42301;

		// Token: 0x040018EA RID: 6378
		internal global::AcpUI.AcpCopyButton CpyBtnEmergencyHotAuxMicConfigurability_A42301;

		// Token: 0x040018EB RID: 6379
		internal global::AcpUI.AcpLabel EmergencyHotAuxMicConfigurability_A42301Comp;

		// Token: 0x040018EC RID: 6380
		internal global::AcpUI.AcpCustomViewCheckBox CVBtnPASSAlarmFilterCapable_A42387;

		// Token: 0x040018ED RID: 6381
		internal global::AcpUI.AcpLabel LblPASSAlarmFilterCapable_A42387;

		// Token: 0x040018EE RID: 6382
		internal global::AcpUI.AcpLabel PASSAlarmFilterCapable_A42387;

		// Token: 0x040018EF RID: 6383
		internal global::AcpUI.AcpRtdButton RTDBtnPASSAlarmFilterCapable_A42387;

		// Token: 0x040018F0 RID: 6384
		internal global::AcpUI.AcpCopyButton CpyBtnPASSAlarmFilterCapable_A42387;

		// Token: 0x040018F1 RID: 6385
		internal global::AcpUI.AcpLabel PASSAlarmFilterCapable_A42387Comp;

		// Token: 0x040018F2 RID: 6386
		internal global::AcpUI.AcpCustomViewCheckBox CVBtnTPSCapable_A42312;

		// Token: 0x040018F3 RID: 6387
		internal global::AcpUI.AcpLabel LblTPSCapable_A42312;

		// Token: 0x040018F4 RID: 6388
		internal global::AcpUI.AcpLabel TPSCapable_A42312;

		// Token: 0x040018F5 RID: 6389
		internal global::AcpUI.AcpRtdButton RTDBtnTPSCapable_A42312;

		// Token: 0x040018F6 RID: 6390
		internal global::AcpUI.AcpCopyButton CpyBtnTPSCapable_A42312;

		// Token: 0x040018F7 RID: 6391
		internal global::AcpUI.AcpLabel TPSCapable_A42312Comp;

		// Token: 0x040018F8 RID: 6392
		internal global::AcpUI.AcpCustomViewCheckBox CVBtnRadWideLabtoolAPXDualKnobs_A42537;

		// Token: 0x040018F9 RID: 6393
		internal global::AcpUI.AcpLabel LblRadWideLabtoolAPXDualKnobs_A42537;

		// Token: 0x040018FA RID: 6394
		internal global::AcpUI.AcpLabel RadWideLabtoolAPXDualKnobs_A42537;

		// Token: 0x040018FB RID: 6395
		internal global::AcpUI.AcpRtdButton RTDBtnRadWideLabtoolAPXDualKnobs_A42537;

		// Token: 0x040018FC RID: 6396
		internal global::AcpUI.AcpCopyButton CpyBtnRadWideLabtoolAPXDualKnobs_A42537;

		// Token: 0x040018FD RID: 6397
		internal global::AcpUI.AcpLabel RadWideLabtoolAPXDualKnobs_A42537Comp;

		// Token: 0x040018FE RID: 6398
		internal global::AcpUI.AcpCustomViewCheckBox CVBtnRadWideLabtoolAudioEnhancement_A42736;

		// Token: 0x040018FF RID: 6399
		internal global::AcpUI.AcpLabel LblRadWideLabtoolAudioEnhancement_A42736;

		// Token: 0x04001900 RID: 6400
		internal global::AcpUI.AcpLabel RadWideLabtoolAudioEnhancement_A42736;

		// Token: 0x04001901 RID: 6401
		internal global::AcpUI.AcpRtdButton RTDBtnRadWideLabtoolAudioEnhancement_A42736;

		// Token: 0x04001902 RID: 6402
		internal global::AcpUI.AcpCopyButton CpyBtnRadWideLabtoolAudioEnhancement_A42736;

		// Token: 0x04001903 RID: 6403
		internal global::AcpUI.AcpLabel RadWideLabtoolAudioEnhancement_A42736Comp;

		// Token: 0x04001904 RID: 6404
		internal global::AcpUI.AcpCustomViewCheckBox CVBtnRadWideLabtoolDynamicZoneScanCapability_42749;

		// Token: 0x04001905 RID: 6405
		internal global::AcpUI.AcpLabel LblRadWideLabtoolDynamicZoneScanCapability_42749;

		// Token: 0x04001906 RID: 6406
		internal global::AcpUI.AcpLabel RadWideLabtoolDynamicZoneScanCapability_42749;

		// Token: 0x04001907 RID: 6407
		internal global::AcpUI.AcpRtdButton RTDBtnRadWideLabtoolDynamicZoneScanCapability_42749;

		// Token: 0x04001908 RID: 6408
		internal global::AcpUI.AcpCopyButton CpyBtnRadWideLabtoolDynamicZoneScanCapability_42749;

		// Token: 0x04001909 RID: 6409
		internal global::AcpUI.AcpLabel RadWideLabtoolDynamicZoneScanCapability_42749Comp;

		// Token: 0x0400190A RID: 6410
		internal global::AcpUI.AcpCustomViewCheckBox CVBtnRadioWideDVRSTrunkingStatusCapability_A42772;

		// Token: 0x0400190B RID: 6411
		internal global::AcpUI.AcpLabel LblRadioWideDVRSTrunkingStatusCapability_A42772;

		// Token: 0x0400190C RID: 6412
		internal global::AcpUI.AcpLabel RadioWideDVRSTrunkingStatusCapability_A42772;

		// Token: 0x0400190D RID: 6413
		internal global::AcpUI.AcpRtdButton RTDBtnRadioWideDVRSTrunkingStatusCapability_A42772;

		// Token: 0x0400190E RID: 6414
		internal global::AcpUI.AcpCopyButton CpyBtnRadioWideDVRSTrunkingStatusCapability_A42772;

		// Token: 0x0400190F RID: 6415
		internal global::AcpUI.AcpLabel RadioWideDVRSTrunkingStatusCapability_A42772Comp;

		// Token: 0x04001910 RID: 6416
		internal global::AcpUI.AcpCustomViewCheckBox CVBtnRadioWideMOSCADACE3000Capability_A42772;

		// Token: 0x04001911 RID: 6417
		internal global::AcpUI.AcpLabel LblRadioWideMOSCADACE3000Capability_A42772;

		// Token: 0x04001912 RID: 6418
		internal global::AcpUI.AcpLabel RadioWideMOSCADACE3000Capability_A42772;

		// Token: 0x04001913 RID: 6419
		internal global::AcpUI.AcpRtdButton RTDBtnRadioWideMOSCADACE3000Capability_A42772;

		// Token: 0x04001914 RID: 6420
		internal global::AcpUI.AcpCopyButton CpyBtnRadioWideMOSCADACE3000Capability_A42772;

		// Token: 0x04001915 RID: 6421
		internal global::AcpUI.AcpLabel RadioWideMOSCADACE3000Capability_A42772Comp;

		// Token: 0x04001916 RID: 6422
		internal global::AcpUI.AcpCustomViewCheckBox CVBtnRadWideLabtoolPAAlertCapability_A42944;

		// Token: 0x04001917 RID: 6423
		internal global::AcpUI.AcpLabel LblRadWideLabtoolPAAlertCapability_A42944;

		// Token: 0x04001918 RID: 6424
		internal global::AcpUI.AcpLabel RadWideLabtoolPAAlertCapability_A42944;

		// Token: 0x04001919 RID: 6425
		internal global::AcpUI.AcpRtdButton RTDBtnRadWideLabtoolPAAlertCapability_A42944;

		// Token: 0x0400191A RID: 6426
		internal global::AcpUI.AcpCopyButton CpyBtnRadWideLabtoolPAAlertCapability_A42944;

		// Token: 0x0400191B RID: 6427
		internal global::AcpUI.AcpLabel RadWideLabtoolPAAlertCapability_A42944Comp;

		// Token: 0x0400191C RID: 6428
		internal global::AcpUI.AcpCustomViewCheckBox CVBtnRadWideLabtoolUserSelectablePLEnhancement_43031;

		// Token: 0x0400191D RID: 6429
		internal global::AcpUI.AcpLabel LblRadWideLabtoolUserSelectablePLEnhancement_43031;

		// Token: 0x0400191E RID: 6430
		internal global::AcpUI.AcpLabel RadWideLabtoolUserSelectablePLEnhancement_43031;

		// Token: 0x0400191F RID: 6431
		internal global::AcpUI.AcpRtdButton RTDBtnRadWideLabtoolUserSelectablePLEnhancement_43031;

		// Token: 0x04001920 RID: 6432
		internal global::AcpUI.AcpCopyButton CpyBtnRadWideLabtoolUserSelectablePLEnhancement_43031;

		// Token: 0x04001921 RID: 6433
		internal global::AcpUI.AcpLabel RadWideLabtoolUserSelectablePLEnhancement_43031Comp;

		// Token: 0x04001922 RID: 6434
		internal global::AcpUI.AcpCustomViewCheckBox CVBtnRadWideLabtoolConsolidatedActionEnhancement_A43036;

		// Token: 0x04001923 RID: 6435
		internal global::AcpUI.AcpLabel LblRadWideLabtoolConsolidatedActionEnhancement_A43036;

		// Token: 0x04001924 RID: 6436
		internal global::AcpUI.AcpLabel RadWideLabtoolConsolidatedActionEnhancement_A43036;

		// Token: 0x04001925 RID: 6437
		internal global::AcpUI.AcpRtdButton RTDBtnRadWideLabtoolConsolidatedActionEnhancement_A43036;

		// Token: 0x04001926 RID: 6438
		internal global::AcpUI.AcpCopyButton CpyBtnRadWideLabtoolConsolidatedActionEnhancement_A43036;

		// Token: 0x04001927 RID: 6439
		internal global::AcpUI.AcpLabel RadWideLabtoolConsolidatedActionEnhancement_A43036Comp;

		// Token: 0x04001928 RID: 6440
		internal global::AcpUI.AcpCustomViewCheckBox CVBtnRadWideLabtoolLimitedISSIDVRSOperationCapable_43045;

		// Token: 0x04001929 RID: 6441
		internal global::AcpUI.AcpLabel LblRadWideLabtoolLimitedISSIDVRSOperationCapable_43045;

		// Token: 0x0400192A RID: 6442
		internal global::AcpUI.AcpLabel RadWideLabtoolLimitedISSIDVRSOperationCapable_43045;

		// Token: 0x0400192B RID: 6443
		internal global::AcpUI.AcpRtdButton RTDBtnRadWideLabtoolLimitedISSIDVRSOperationCapable_43045;

		// Token: 0x0400192C RID: 6444
		internal global::AcpUI.AcpCopyButton CpyBtnRadWideLabtoolLimitedISSIDVRSOperationCapable_43045;

		// Token: 0x0400192D RID: 6445
		internal global::AcpUI.AcpLabel RadWideLabtoolLimitedISSIDVRSOperationCapable_43045Comp;

		// Token: 0x0400192E RID: 6446
		internal global::AcpUI.AcpCustomViewCheckBox CVBtnRadWideLabtoolActiveMicForBTPTTCapable_43053;

		// Token: 0x0400192F RID: 6447
		internal global::AcpUI.AcpLabel LblRadWideLabtoolActiveMicForBTPTTCapable_43053;

		// Token: 0x04001930 RID: 6448
		internal global::AcpUI.AcpLabel RadWideLabtoolActiveMicForBTPTTCapable_43053;

		// Token: 0x04001931 RID: 6449
		internal global::AcpUI.AcpRtdButton RTDBtnRadWideLabtoolActiveMicForBTPTTCapable_43053;

		// Token: 0x04001932 RID: 6450
		internal global::AcpUI.AcpCopyButton CpyBtnRadWideLabtoolActiveMicForBTPTTCapable_43053;

		// Token: 0x04001933 RID: 6451
		internal global::AcpUI.AcpLabel RadWideLabtoolActiveMicForBTPTTCapable_43053Comp;

		// Token: 0x04001934 RID: 6452
		internal global::AcpUI.AcpCustomViewCheckBox CVBtnRadWideLabtoolAPXSingletoneCapable_43080;

		// Token: 0x04001935 RID: 6453
		internal global::AcpUI.AcpLabel LblRadWideLabtoolAPXSingletoneCapable_43080;

		// Token: 0x04001936 RID: 6454
		internal global::AcpUI.AcpLabel RadWideLabtoolAPXSingletoneCapable_43080;

		// Token: 0x04001937 RID: 6455
		internal global::AcpUI.AcpRtdButton RTDBtnRadWideLabtoolAPXSingletoneCapable_43080;

		// Token: 0x04001938 RID: 6456
		internal global::AcpUI.AcpCopyButton CpyBtnRadWideLabtoolAPXSingletoneCapable_43080;

		// Token: 0x04001939 RID: 6457
		internal global::AcpUI.AcpLabel RadWideLabtoolAPXSingletoneCapable_43080Comp;

		// Token: 0x0400193A RID: 6458
		internal global::AcpUI.AcpCustomViewCheckBox CVBtnRadWideLabtoolEnhancedARS_A43084;

		// Token: 0x0400193B RID: 6459
		internal global::AcpUI.AcpLabel LblRadWideLabtoolEnhancedARS_A43084;

		// Token: 0x0400193C RID: 6460
		internal global::AcpUI.AcpLabel RadWideLabtoolEnhancedARS_A43084;

		// Token: 0x0400193D RID: 6461
		internal global::AcpUI.AcpRtdButton RTDBtnRadWideLabtoolEnhancedARS_A43084;

		// Token: 0x0400193E RID: 6462
		internal global::AcpUI.AcpCopyButton CpyBtnRadWideLabtoolEnhancedARS_A43084;

		// Token: 0x0400193F RID: 6463
		internal global::AcpUI.AcpLabel RadWideLabtoolEnhancedARS_A43084Comp;

		// Token: 0x04001940 RID: 6464
		internal global::AcpUI.AcpCustomViewCheckBox CVBtnRadWideLabtoolEmergencyCallOnlywithHotMicCapable_A43162;

		// Token: 0x04001941 RID: 6465
		internal global::AcpUI.AcpLabel LblRadWideLabtoolEmergencyCallOnlywithHotMicCapable_A43162;

		// Token: 0x04001942 RID: 6466
		internal global::AcpUI.AcpLabel RadWideLabtoolEmergencyCallOnlywithHotMicCapable_A43162;

		// Token: 0x04001943 RID: 6467
		internal global::AcpUI.AcpRtdButton RTDBtnRadWideLabtoolEmergencyCallOnlywithHotMicCapable_A43162;

		// Token: 0x04001944 RID: 6468
		internal global::AcpUI.AcpCopyButton CpyBtnRadWideLabtoolEmergencyCallOnlywithHotMicCapable_A43162;

		// Token: 0x04001945 RID: 6469
		internal global::AcpUI.AcpLabel RadWideLabtoolEmergencyCallOnlywithHotMicCapable_A43162Comp;

		// Token: 0x04001946 RID: 6470
		internal global::AcpUI.AcpCustomViewCheckBox CVBtnRadioWideLabtoolZoneCloneCapable_43238;

		// Token: 0x04001947 RID: 6471
		internal global::AcpUI.AcpLabel LblRadioWideLabtoolZoneCloneCapable_43238;

		// Token: 0x04001948 RID: 6472
		internal global::AcpUI.AcpLabel RadioWideLabtoolZoneCloneCapable_43238;

		// Token: 0x04001949 RID: 6473
		internal global::AcpUI.AcpRtdButton RTDBtnRadioWideLabtoolZoneCloneCapable_43238;

		// Token: 0x0400194A RID: 6474
		internal global::AcpUI.AcpCopyButton CpyBtnRadioWideLabtoolZoneCloneCapable_43238;

		// Token: 0x0400194B RID: 6475
		internal global::AcpUI.AcpLabel RadioWideLabtoolZoneCloneCapable_43238Comp;

		// Token: 0x0400194C RID: 6476
		internal global::AcpUI.AcpCustomViewCheckBox CVBtnRadioWideLabtoolEmergencyCallTermination_43348;

		// Token: 0x0400194D RID: 6477
		internal global::AcpUI.AcpLabel LblRadioWideLabtoolEmergencyCallTermination_43348;

		// Token: 0x0400194E RID: 6478
		internal global::AcpUI.AcpLabel RadioWideLabtoolEmergencyCallTermination_43348;

		// Token: 0x0400194F RID: 6479
		internal global::AcpUI.AcpRtdButton RTDBtnRadioWideLabtoolEmergencyCallTermination_43348;

		// Token: 0x04001950 RID: 6480
		internal global::AcpUI.AcpCopyButton CpyBtnRadioWideLabtoolEmergencyCallTermination_43348;

		// Token: 0x04001951 RID: 6481
		internal global::AcpUI.AcpLabel RadioWideLabtoolEmergencyCallTermination_43348Comp;

		// Token: 0x04001952 RID: 6482
		internal global::AcpUI.AcpCustomViewCheckBox CVBtnRadWideLabtoolIntelligentPriorityScanCapable_43411;

		// Token: 0x04001953 RID: 6483
		internal global::AcpUI.AcpLabel LblRadWideLabtoolIntelligentPriorityScanCapable_43411;

		// Token: 0x04001954 RID: 6484
		internal global::AcpUI.AcpLabel RadWideLabtoolIntelligentPriorityScanCapable_43411;

		// Token: 0x04001955 RID: 6485
		internal global::AcpUI.AcpRtdButton RTDBtnRadWideLabtoolIntelligentPriorityScanCapable_43411;

		// Token: 0x04001956 RID: 6486
		internal global::AcpUI.AcpCopyButton CpyBtnRadWideLabtoolIntelligentPriorityScanCapable_43411;

		// Token: 0x04001957 RID: 6487
		internal global::AcpUI.AcpLabel RadWideLabtoolIntelligentPriorityScanCapable_43411Comp;

		// Token: 0x04001958 RID: 6488
		internal global::AcpUI.AcpCustomViewCheckBox CVBtnRadWideLabtoolDisableEncryption_43371;

		// Token: 0x04001959 RID: 6489
		internal global::AcpUI.AcpLabel LblRadWideLabtoolDisableEncryption_43371;

		// Token: 0x0400195A RID: 6490
		internal global::AcpUI.AcpLabel RadWideLabtoolDisableEncryption_43371;

		// Token: 0x0400195B RID: 6491
		internal global::AcpUI.AcpRtdButton RTDBtnRadWideLabtoolDisableEncryption_43371;

		// Token: 0x0400195C RID: 6492
		internal global::AcpUI.AcpCopyButton CpyBtnRadWideLabtoolDisableEncryption_43371;

		// Token: 0x0400195D RID: 6493
		internal global::AcpUI.AcpLabel RadWideLabtoolDisableEncryption_43371Comp;

		// Token: 0x0400195E RID: 6494
		internal global::AcpUI.AcpCustomViewCheckBox CVBtnRadioWideLabtoolDisableWindNoiseReductionLevelForAccessories_43548;

		// Token: 0x0400195F RID: 6495
		internal global::AcpUI.AcpLabel LblRadioWideLabtoolDisableWindNoiseReductionLevelForAccessories_43548;

		// Token: 0x04001960 RID: 6496
		internal global::AcpUI.AcpLabel RadioWideLabtoolDisableWindNoiseReductionLevelForAccessories_43548;

		// Token: 0x04001961 RID: 6497
		internal global::AcpUI.AcpRtdButton RTDBtnRadioWideLabtoolDisableWindNoiseReductionLevelForAccessories_43548;

		// Token: 0x04001962 RID: 6498
		internal global::AcpUI.AcpCopyButton CpyBtnRadioWideLabtoolDisableWindNoiseReductionLevelForAccessories_43548;

		// Token: 0x04001963 RID: 6499
		internal global::AcpUI.AcpLabel RadioWideLabtoolDisableWindNoiseReductionLevelForAccessories_43548Comp;

		// Token: 0x04001964 RID: 6500
		internal global::AcpUI.AcpCustomViewCheckBox CVBtnMARVELL_DNP_43591;

		// Token: 0x04001965 RID: 6501
		internal global::AcpUI.AcpLabel LblMARVELL_DNP_43591;

		// Token: 0x04001966 RID: 6502
		internal global::AcpUI.AcpLabel MARVELL_DNP_43591;

		// Token: 0x04001967 RID: 6503
		internal global::AcpUI.AcpRtdButton RTDBtnMARVELL_DNP_43591;

		// Token: 0x04001968 RID: 6504
		internal global::AcpUI.AcpCopyButton CpyBtnMARVELL_DNP_43591;

		// Token: 0x04001969 RID: 6505
		internal global::AcpUI.AcpLabel MARVELL_DNP_43591Comp;

		// Token: 0x0400196A RID: 6506
		internal global::AcpUI.AcpCustomViewCheckBox CVBtnTEN_DIGIT_RL_PSWD_capable_43711;

		// Token: 0x0400196B RID: 6507
		internal global::AcpUI.AcpLabel LblTEN_DIGIT_RL_PSWD_capable_43711;

		// Token: 0x0400196C RID: 6508
		internal global::AcpUI.AcpLabel TEN_DIGIT_RL_PSWD_capable_43711;

		// Token: 0x0400196D RID: 6509
		internal global::AcpUI.AcpRtdButton RTDBtnTEN_DIGIT_RL_PSWD_capable_43711;

		// Token: 0x0400196E RID: 6510
		internal global::AcpUI.AcpCopyButton CpyBtnTEN_DIGIT_RL_PSWD_capable_43711;

		// Token: 0x0400196F RID: 6511
		internal global::AcpUI.AcpLabel TEN_DIGIT_RL_PSWD_capable_43711Comp;

		// Token: 0x04001970 RID: 6512
		internal global::AcpUI.AcpCustomViewCheckBox CVBtnRadioWideLabtoolExtendedPLToneSet_43769;

		// Token: 0x04001971 RID: 6513
		internal global::AcpUI.AcpLabel LblRadioWideLabtoolExtendedPLToneSet_43769;

		// Token: 0x04001972 RID: 6514
		internal global::AcpUI.AcpLabel RadioWideLabtoolExtendedPLToneSet_43769;

		// Token: 0x04001973 RID: 6515
		internal global::AcpUI.AcpRtdButton RTDBtnRadioWideLabtoolExtendedPLToneSet_43769;

		// Token: 0x04001974 RID: 6516
		internal global::AcpUI.AcpCopyButton CpyBtnRadioWideLabtoolExtendedPLToneSet_43769;

		// Token: 0x04001975 RID: 6517
		internal global::AcpUI.AcpLabel RadioWideLabtoolExtendedPLToneSet_43769Comp;

		// Token: 0x04001976 RID: 6518
		internal global::AcpUI.AcpCustomViewCheckBox CVBtnAllowPSUSecure_43809;

		// Token: 0x04001977 RID: 6519
		internal global::AcpUI.AcpLabel LblAllowPSUSecure_43809;

		// Token: 0x04001978 RID: 6520
		internal global::AcpUI.AcpLabel AllowPSUSecure_43809;

		// Token: 0x04001979 RID: 6521
		internal global::AcpUI.AcpRtdButton RTDBtnAllowPSUSecure_43809;

		// Token: 0x0400197A RID: 6522
		internal global::AcpUI.AcpCopyButton CpyBtnAllowPSUSecure_43809;

		// Token: 0x0400197B RID: 6523
		internal global::AcpUI.AcpLabel AllowPSUSecure_43809Comp;

		// Token: 0x0400197C RID: 6524
		internal global::AcpUI.AcpCustomViewCheckBox CVBtnUCLContactsLimitationEnhancement_43811;

		// Token: 0x0400197D RID: 6525
		internal global::AcpUI.AcpLabel LblUCLContactsLimitationEnhancement_43811;

		// Token: 0x0400197E RID: 6526
		internal global::AcpUI.AcpLabel UCLContactsLimitationEnhancement_43811;

		// Token: 0x0400197F RID: 6527
		internal global::AcpUI.AcpRtdButton RTDBtnUCLContactsLimitationEnhancement_43811;

		// Token: 0x04001980 RID: 6528
		internal global::AcpUI.AcpCopyButton CpyBtnUCLContactsLimitationEnhancement_43811;

		// Token: 0x04001981 RID: 6529
		internal global::AcpUI.AcpLabel UCLContactsLimitationEnhancement_43811Comp;

		// Token: 0x04001982 RID: 6530
		internal global::AcpUI.AcpCustomViewCheckBox CVBtnDVRSRangeExt_44809;

		// Token: 0x04001983 RID: 6531
		internal global::AcpUI.AcpLabel LblDVRSRangeExt_44809;

		// Token: 0x04001984 RID: 6532
		internal global::AcpUI.AcpLabel DVRSRangeExt_44809;

		// Token: 0x04001985 RID: 6533
		internal global::AcpUI.AcpRtdButton RTDBtnDVRSRangeExt_44809;

		// Token: 0x04001986 RID: 6534
		internal global::AcpUI.AcpCopyButton CpyBtnDVRSRangeExt_44809;

		// Token: 0x04001987 RID: 6535
		internal global::AcpUI.AcpLabel DVRSRangeExt_44809Comp;

		// Token: 0x04001988 RID: 6536
		internal global::AcpUI.AcpCustomViewCheckBox CVBtnRadWideLabtoolIndirectPTTAudioRoutingPCI_44817;

		// Token: 0x04001989 RID: 6537
		internal global::AcpUI.AcpLabel LblRadWideLabtoolIndirectPTTAudioRoutingPCI_44817;

		// Token: 0x0400198A RID: 6538
		internal global::AcpUI.AcpLabel RadWideLabtoolIndirectPTTAudioRoutingPCI_44817;

		// Token: 0x0400198B RID: 6539
		internal global::AcpUI.AcpRtdButton RTDBtnRadWideLabtoolIndirectPTTAudioRoutingPCI_44817;

		// Token: 0x0400198C RID: 6540
		internal global::AcpUI.AcpCopyButton CpyBtnRadWideLabtoolIndirectPTTAudioRoutingPCI_44817;

		// Token: 0x0400198D RID: 6541
		internal global::AcpUI.AcpLabel RadWideLabtoolIndirectPTTAudioRoutingPCI_44817Comp;

		// Token: 0x0400198E RID: 6542
		internal global::AcpUI.AcpCustomViewCheckBox CVBtnRadWideLabtoolADPGatingPCIBit;

		// Token: 0x0400198F RID: 6543
		internal global::AcpUI.AcpLabel LblRadWideLabtoolADPGatingPCIBit;

		// Token: 0x04001990 RID: 6544
		internal global::AcpUI.AcpLabel RadWideLabtoolADPGatingPCIBit_44813;

		// Token: 0x04001991 RID: 6545
		internal global::AcpUI.AcpRtdButton RTDBtnRadWideLabtoolADPGatingPCIBit;

		// Token: 0x04001992 RID: 6546
		internal global::AcpUI.AcpCopyButton CpyBtnRadWideLabtoolADPGatingPCIBit;

		// Token: 0x04001993 RID: 6547
		internal global::AcpUI.AcpLabel RadWideLabtoolADPGatingPCIBitComp;

		// Token: 0x04001994 RID: 6548
		internal global::AcpUI.AcpCustomViewCheckBox CVBtnRadWideLabtoolSupportO3ControlHeadPCIBit_44884;

		// Token: 0x04001995 RID: 6549
		internal global::AcpUI.AcpLabel LblRadWideLabtoolSupportO3ControlHeadPCIBit_44884;

		// Token: 0x04001996 RID: 6550
		internal global::AcpUI.AcpLabel RadWideLabtoolSupportO3ControlHeadPCIBit_44884;

		// Token: 0x04001997 RID: 6551
		internal global::AcpUI.AcpRtdButton RTDBtnRadWideLabtoolSupportO3ControlHeadPCIBit_44884;

		// Token: 0x04001998 RID: 6552
		internal global::AcpUI.AcpCopyButton CpyBtnRadWideLabtoolSupportO3ControlHeadPCIBit_44884;

		// Token: 0x04001999 RID: 6553
		internal global::AcpUI.AcpLabel RadWideLabtoolSupportO3ControlHeadPCIBitComp;

		// Token: 0x0400199A RID: 6554
		internal global::AcpUI.AcpCustomViewCheckBox CVBtnRadWideLabtoolAnalogWideBandDataPCIBit_44885;

		// Token: 0x0400199B RID: 6555
		internal global::AcpUI.AcpLabel LblRadWideLabtoolAnalogWideBandDataPCIBit_44885;

		// Token: 0x0400199C RID: 6556
		internal global::AcpUI.AcpLabel RadWideLabtoolAnalogWideBandDataPCIBit_44885;

		// Token: 0x0400199D RID: 6557
		internal global::AcpUI.AcpRtdButton RTDBtnRadWideLabtoolAnalogWideBandDataPCIBit_44885;

		// Token: 0x0400199E RID: 6558
		internal global::AcpUI.AcpCopyButton CpyBtnRadWideLabtoolAnalogWideBandDataPCIBit_44885;

		// Token: 0x0400199F RID: 6559
		internal global::AcpUI.AcpLabel RadWideLabtoolAnalogWideBandDataPCIBit_44885Comp;

		// Token: 0x040019A0 RID: 6560
		internal global::AcpUI.AcpGroupBox GrpBoxExpanderRadioWideLabtoolCertificateManagement;

		// Token: 0x040019A1 RID: 6561
		internal global::AcpUI.AcpCustomViewCheckBox CVBtnRadWideLabtoolCertMgmtMotorolaSolutionsPKIPort;

		// Token: 0x040019A2 RID: 6562
		internal global::AcpUI.AcpLabel LblRadWideLabtoolCertMgmtMotorolaSolutionsPKIPort;

		// Token: 0x040019A3 RID: 6563
		internal global::AcpUI.AcpTextBoxSpinner RadWideLabtoolCertMgmtMotorolaSolutionsPKIPort;

		// Token: 0x040019A4 RID: 6564
		internal global::AcpUI.AcpRtdButton RTDBtnRadWideLabtoolCertMgmtMotorolaSolutionsPKIPort;

		// Token: 0x040019A5 RID: 6565
		internal global::AcpUI.AcpCopyButton CpyBtnRadWideLabtoolCertMgmtMotorolaSolutionsPKIPort;

		// Token: 0x040019A6 RID: 6566
		internal global::AcpUI.AcpLabel RadWideLabtoolCertMgmtMotorolaSolutionsPKIPortComp;

		// Token: 0x040019A7 RID: 6567
		internal global::AcpUI.AcpCustomViewCheckBox CVBtnRadWideLabtoolCertMgmtMotorolaSolutionsPKIHostname;

		// Token: 0x040019A8 RID: 6568
		internal global::AcpUI.AcpLabel LblRadWideLabtoolCertMgmtMotorolaSolutionsPKIHostname;

		// Token: 0x040019A9 RID: 6569
		internal global::AcpUI.AcpTextBox RadWideLabtoolCertMgmtMotorolaSolutionsPKIHostname;

		// Token: 0x040019AA RID: 6570
		internal global::AcpUI.AcpRtdButton RTDBtnRadWideLabtoolCertMgmtMotorolaSolutionsPKIHostname;

		// Token: 0x040019AB RID: 6571
		internal global::AcpUI.AcpCopyButton CpyBtnRadWideLabtoolCertMgmtMotorolaSolutionsPKIHostname;

		// Token: 0x040019AC RID: 6572
		internal global::AcpUI.AcpLabel RadWideLabtoolCertMgmtMotorolaSolutionsPKIHostnameComp;

		// Token: 0x040019AD RID: 6573
		internal global::AcpUI.AcpGroupBox GrpBoxExpanderRadioWideLabtoolDeviceManagement;

		// Token: 0x040019AE RID: 6574
		internal global::AcpUI.AcpCustomViewCheckBox CVBtnRadWideLabtoolDeviceMgmtSeamlessUpdateRmPskId;

		// Token: 0x040019AF RID: 6575
		internal global::AcpUI.AcpLabel LblRadWideLabtoolDeviceMgmtSeamlessUpdateRmPskId;

		// Token: 0x040019B0 RID: 6576
		internal global::AcpUI.AcpTextBoxSpinner RadWideLabtoolDeviceMgmtSeamlessUpdateRmPskId;

		// Token: 0x040019B1 RID: 6577
		internal global::AcpUI.AcpRtdButton RTDBtnRadWideLabtoolDeviceMgmtSeamlessUpdateRmPskId;

		// Token: 0x040019B2 RID: 6578
		internal global::AcpUI.AcpCopyButton CpyBtnRadWideLabtoolDeviceMgmtSeamlessUpdateRmPskId;

		// Token: 0x040019B3 RID: 6579
		internal global::AcpUI.AcpLabel RadWideLabtoolDeviceMgmtSeamlessUpdateRmPskIdComp;

		// Token: 0x040019B4 RID: 6580
		internal global::AcpUI.AcpCustomViewCheckBox CVBtnRadWideLabtoolDeviceMgmtSeamlessUpdateRmPsk;

		// Token: 0x040019B5 RID: 6581
		internal global::AcpUI.AcpLabel LblRadWideLabtoolDeviceMgmtSeamlessUpdateRmPsk;

		// Token: 0x040019B6 RID: 6582
		internal global::AcpUI.AcpTextBox RadWideLabtoolDeviceMgmtSeamlessUpdateRmPsk;

		// Token: 0x040019B7 RID: 6583
		internal global::AcpUI.AcpRtdButton RTDBtnRadWideLabtoolDeviceMgmtSeamlessUpdateRmPsk;

		// Token: 0x040019B8 RID: 6584
		internal global::AcpUI.AcpCopyButton CpyBtnRadWideLabtoolDeviceMgmtSeamlessUpdateRmPsk;

		// Token: 0x040019B9 RID: 6585
		internal global::AcpUI.AcpLabel RadWideLabtoolDeviceMgmtSeamlessUpdateRmPskComp;

		// Token: 0x040019BA RID: 6586
		internal global::AcpUI.AcpCustomViewCheckBox CVBtnRadWideLabtoolDeviceMgmtSeamlessUpdateGatewayHostname;

		// Token: 0x040019BB RID: 6587
		internal global::AcpUI.AcpLabel LblRadWideLabtoolDeviceMgmtSeamlessUpdateGatewayHostname;

		// Token: 0x040019BC RID: 6588
		internal global::AcpUI.AcpTextBox RadWideLabtoolDeviceMgmtSeamlessUpdateGatewayHostname;

		// Token: 0x040019BD RID: 6589
		internal global::AcpUI.AcpRtdButton RTDBtnRadWideLabtoolDeviceMgmtSeamlessUpdateGatewayHostname;

		// Token: 0x040019BE RID: 6590
		internal global::AcpUI.AcpCopyButton CpyBtnRadWideLabtoolDeviceMgmtSeamlessUpdateGatewayHostname;

		// Token: 0x040019BF RID: 6591
		internal global::AcpUI.AcpLabel RadWideLabtoolDeviceMgmtSeamlessUpdateGatewayHostnameComp;

		// Token: 0x040019C0 RID: 6592
		internal global::AcpUI.AcpCustomViewCheckBox CVBtnRadWideLabtoolDeviceMgmtEnterpriseWifiCodeplugId;

		// Token: 0x040019C1 RID: 6593
		internal global::AcpUI.AcpLabel LblRadWideLabtoolDeviceMgmtEnterpriseWifiCodeplugId;

		// Token: 0x040019C2 RID: 6594
		internal global::AcpUI.AcpTextBox RadWideLabtoolDeviceMgmtEnterpriseWifiCodeplugId;

		// Token: 0x040019C3 RID: 6595
		internal global::AcpUI.AcpRtdButton RTDBtnRadWideLabtoolDeviceMgmtEnterpriseWifiCodeplugId;

		// Token: 0x040019C4 RID: 6596
		internal global::AcpUI.AcpCopyButton CpyBtnRadWideLabtoolDeviceMgmtEnterpriseWifiCodeplugId;

		// Token: 0x040019C5 RID: 6597
		internal global::AcpUI.AcpLabel RadWideLabtoolDeviceMgmtEnterpriseWifiCodeplugIdComp;

		// Token: 0x040019C6 RID: 6598
		internal global::AcpUI.AcpGroupBox GrpBoxExpanderRadioWideLabtoolRCLastJobSetUUID;

		// Token: 0x040019C7 RID: 6599
		internal global::AcpUI.AcpCustomViewCheckBox CVBtnRadWideLabtoolRCLastJobSetUUID;

		// Token: 0x040019C8 RID: 6600
		internal global::AcpUI.AcpLabel LblRadWideLabtoolRCLastJobSetUUID;

		// Token: 0x040019C9 RID: 6601
		internal global::AcpUI.AcpTextBox RadWideLabtoolRCLastJobSetUUID;

		// Token: 0x040019CA RID: 6602
		internal global::AcpUI.AcpRtdButton RTDBtnRadWideLabtoolRCLastJobSetUUID;

		// Token: 0x040019CB RID: 6603
		internal global::AcpUI.AcpCopyButton CpyBtnRadWideLabtoolRCLastJobSetUUID;

		// Token: 0x040019CC RID: 6604
		internal global::AcpUI.AcpLabel RadWideLabtoolRCLastJobSetUUIDComp;

		// Token: 0x040019CD RID: 6605
		internal global::AcpUI.AcpExpander ExpanderRadioWideSensor;

		// Token: 0x040019CE RID: 6606
		internal global::AcpUI.AcpGroupBox GrpBoxExpanderRadioWideSensorPseudo0;

		// Token: 0x040019CF RID: 6607
		internal global::AcpUI.AcpCustomViewCheckBox CVBtnSensorEventDisableTimer_43198;

		// Token: 0x040019D0 RID: 6608
		internal global::AcpUI.AcpLabel LblSensorEventDisableTimer_43198;

		// Token: 0x040019D1 RID: 6609
		internal global::AcpUI.AcpTextBoxSpinner SensorEventDisableTimer_43198;

		// Token: 0x040019D2 RID: 6610
		internal global::AcpUI.AcpRtdButton RTDBtnSensorEventDisableTimer_43198;

		// Token: 0x040019D3 RID: 6611
		internal global::AcpUI.AcpCopyButton CpyBtnSensorEventDisableTimer_43198;

		// Token: 0x040019D4 RID: 6612
		internal global::AcpUI.AcpLabel SensorEventDisableTimer_43198Comp;

		// Token: 0x040019D5 RID: 6613
		internal global::AcpUI.AcpCustomViewCheckBox CVBtnSensorEventNotificationEnable_43525;

		// Token: 0x040019D6 RID: 6614
		internal global::AcpUI.AcpLabel LblSensorEventNotificationEnable_43525;

		// Token: 0x040019D7 RID: 6615
		internal global::AcpUI.AcpCheckBox SensorEventNotificationEnable_43525;

		// Token: 0x040019D8 RID: 6616
		internal global::AcpUI.AcpRtdButton RTDBtnSensorEventNotificationEnable_43525;

		// Token: 0x040019D9 RID: 6617
		internal global::AcpUI.AcpCopyButton CpyBtnSensorEventNotificationEnable_43525;

		// Token: 0x040019DA RID: 6618
		internal global::AcpUI.AcpCheckBox SensorEventNotificationEnable_43525Comp;

		// Token: 0x040019DB RID: 6619
		private bool b;
	}
}
