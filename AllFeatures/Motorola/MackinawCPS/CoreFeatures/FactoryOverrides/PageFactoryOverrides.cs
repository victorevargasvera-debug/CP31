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

namespace Motorola.MackinawCPS.CoreFeatures.FactoryOverrides
{
	// Token: 0x0200044E RID: 1102
	public class PageFactoryOverrides : global::AcpUI.AcpPageFeature, global::System.Windows.Markup.IComponentConnector, global::System.Windows.Markup.IStyleConnector
	{
		// Token: 0x060093A5 RID: 37797 RVA: 0x008B01E8 File Offset: 0x008AE3E8
		public PageFactoryOverrides()
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

		// Token: 0x060093A6 RID: 37798 RVA: 0x008B0220 File Offset: 0x008AE420
		public override void OnLoaded(object sender, global::System.Windows.RoutedEventArgs e)
		{
			short num = (short)2006646784;
			short num2 = num;
			num = (short)2001403904;
			int num3 = (int)num;
			switch (num3)
			{
			default:
				for (;;)
				{
					IL_46:
					num = (short)650117134;
					num3 = (int)((global::System.IntPtr)num);
					for (;;)
					{
						object obj;
						global::AcpUI.AcpExpander acpExpander;
						global::System.Collections.IEnumerator enumerator;
						switch (num3)
						{
						case 0:
							if (obj != null)
							{
								num = (short)651231235;
								num3 = (int)((global::System.IntPtr)num);
								continue;
							}
							goto IL_58C;
						case 1:
							if (obj != null)
							{
								num = (short)507183124;
								num3 = (int)((global::System.IntPtr)num);
								continue;
							}
							goto IL_685;
						case 2:
							goto IL_436;
						case 3:
							goto IL_32E;
						case 4:
							goto IL_58C;
						case 5:
						{
							global::System.Windows.Data.CollectionView collectionView = (global::System.Windows.Data.CollectionView)global::System.Windows.Data.CollectionViewSource.GetDefaultView(obj);
							this.RecNavToolbarExpanderFactoryOverridesRxFrequencyList.MyDataPresenter = this.ExpanderFactoryOverridesRxFrequencyList;
							num = (short)726925327;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						}
						case 6:
							if (obj != null)
							{
								num = (short)2043543573;
								num3 = (int)((global::System.IntPtr)num);
								continue;
							}
							goto IL_F8;
						case 7:
							goto IL_685;
						case 8:
							goto IL_F8;
						case 9:
							goto IL_3A3;
						case 10:
							if (obj != null)
							{
								num = (short)1743716375;
								num3 = (int)((global::System.IntPtr)num);
								continue;
							}
							goto IL_3A3;
						case 11:
							goto IL_4D2;
						case 12:
							obj = null;
							obj = this.RecNavToolbarExpanderFactoryOverridesRxSynthesizerReferenceDividerListTable.MyRecordsetDataSource;
							num = (short)1484652544;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						case 13:
						{
							global::System.Windows.Data.CollectionView collectionView2 = (global::System.Windows.Data.CollectionView)global::System.Windows.Data.CollectionViewSource.GetDefaultView(obj);
							this.RecNavToolbarExpanderFactoryOverridesTxSSIClockRateListTable.MyDataPresenter = this.ExpanderFactoryOverridesTxSSIClockRateListTable;
							num = (short)1228210198;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						}
						case 14:
							switch (0)
							{
							case 0:
								goto IL_D0;
							}
							continue;
						case 15:
							goto IL_47B;
						case 16:
							try
							{
								num = (short)163446784;
								num3 = (int)((global::System.IntPtr)num);
								for (;;)
								{
									switch (num3)
									{
									case 0:
										switch (0)
										{
										case 0:
											goto IL_1FA;
										}
										continue;
									case 1:
										if (acpExpander != null)
										{
											num = (short)1376256005;
											num3 = (int)((global::System.IntPtr)num);
											continue;
										}
										break;
									case 3:
										goto IL_2B7;
									case 4:
										if (!enumerator.MoveNext())
										{
											num = (short)1388642310;
											num3 = (int)((global::System.IntPtr)num);
											continue;
										}
										acpExpander = (((global::System.Windows.UIElement)enumerator.Current) as global::AcpUI.AcpExpander);
										num = (short)1771372545;
										num3 = (int)((global::System.IntPtr)num);
										continue;
									case 5:
										base.Expanders.Add(acpExpander);
										num = (short)1647050754;
										num3 = (int)((global::System.IntPtr)num);
										continue;
									case 6:
										num = (short)137166851;
										num3 = (int)((global::System.IntPtr)num);
										continue;
									}
									IL_264:
									num = (short)578093060;
									num3 = (int)((global::System.IntPtr)num);
									continue;
									IL_1FA:
									goto IL_264;
								}
								IL_2B7:
								goto IL_4AB;
							}
							finally
							{
								switch (0)
								{
								case 0:
									goto IL_2D9;
								}
								global::System.IDisposable disposable;
								for (;;)
								{
									IL_2C6:
									switch (num3)
									{
									case 0:
										if (disposable != null)
										{
											num = (short)1979449345;
											num3 = (int)((global::System.IntPtr)num);
											continue;
										}
										goto IL_32D;
									case 1:
										disposable.Dispose();
										num = (short)43843586;
										num3 = (int)((global::System.IntPtr)num);
										continue;
									case 2:
										goto IL_32B;
									}
									goto IL_2D9;
								}
								IL_32B:
								IL_32D:
								goto EndFinally_14;
								IL_2D9:
								disposable = (enumerator as global::System.IDisposable);
								num = (short)1518338048;
								num3 = (int)((global::System.IntPtr)num);
								goto IL_2C6;
								EndFinally_14:;
							}
							goto IL_32E;
							IL_4AB:
							base.OnLoaded(sender, e);
							this.a = true;
							num = (short)1767374859;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						case 17:
							if (obj != null)
							{
								num = (short)2050687000;
								num3 = (int)((global::System.IntPtr)num);
								continue;
							}
							goto IL_436;
						case 18:
							if (obj != null)
							{
								num = (short)46923781;
								num3 = (int)((global::System.IntPtr)num);
								continue;
							}
							goto IL_47B;
						case 19:
							if (obj != null)
							{
								num = (short)1384579085;
								num3 = (int)((global::System.IntPtr)num);
								continue;
							}
							goto IL_4D7;
						case 20:
						{
							global::System.Windows.Data.CollectionView collectionView3 = (global::System.Windows.Data.CollectionView)global::System.Windows.Data.CollectionViewSource.GetDefaultView(obj);
							this.RecNavToolbarExpanderFactoryOverridesRxSSIClockRateTXMode.MyDataPresenter = this.ExpanderFactoryOverridesRxSSIClockRateTXMode;
							num = (short)324141063;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						}
						case 21:
						{
							global::System.Windows.Data.CollectionView collectionView4 = (global::System.Windows.Data.CollectionView)global::System.Windows.Data.CollectionViewSource.GetDefaultView(obj);
							this.RecNavToolbarExpanderFactoryOverridesSecondLOInjectionFrequencyList.MyDataPresenter = this.ExpanderFactoryOverridesSecondLOInjectionFrequencyList;
							num = (short)1224802312;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						}
						case 22:
							goto IL_4D7;
						case 23:
						{
							global::System.Windows.Data.CollectionView collectionView5 = (global::System.Windows.Data.CollectionView)global::System.Windows.Data.CollectionViewSource.GetDefaultView(obj);
							this.RecNavToolbarExpanderFactoryOverridesRxSSIClockRateListTable.MyDataPresenter = this.ExpanderFactoryOverridesRxSSIClockRateListTable;
							num = (short)1747386377;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						}
						case 24:
						{
							global::System.Windows.Data.CollectionView collectionView6 = (global::System.Windows.Data.CollectionView)global::System.Windows.Data.CollectionViewSource.GetDefaultView(obj);
							this.RecNavToolbarExpanderFactoryOverridesTxSynthesizerReferenceDividerListTable.MyDataPresenter = this.ExpanderFactoryOverridesTxSynthesizerReferenceDividerListTable;
							num = (short)891944962;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						}
						}
						IL_D0:
						if (!this.a)
						{
							num = (short)1411383308;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_6CC;
						IL_F8:
						obj = this.RecNavToolbarExpanderFactoryOverridesRxFrequencyList.MyRecordsetDataSource;
						num = (short)80674834;
						num3 = (int)((global::System.IntPtr)num);
						continue;
						IL_32E:
						global::System.Windows.Data.CollectionView collectionView7 = (global::System.Windows.Data.CollectionView)global::System.Windows.Data.CollectionViewSource.GetDefaultView(obj);
						this.RecNavToolbarExpanderFactoryOverridesRxSynthesizerReferenceDividerListTable.MyDataPresenter = this.ExpanderFactoryOverridesRxSynthesizerReferenceDividerListTable;
						num = (short)1441333252;
						num3 = (int)((global::System.IntPtr)num);
						continue;
						IL_3A3:
						num = (short)947712874;
						short num4 = num;
						num = (short)2068181866;
						switch ((num4 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_46;
						default:
							num = (short)224985088;
							if (num != 0)
							{
							}
							obj = this.RecNavToolbarExpanderFactoryOverridesRxSSIClockRateTXMode.MyRecordsetDataSource;
							num = (short)383188993;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						}
						IL_436:
						obj = this.RecNavToolbarExpanderFactoryOverridesTxSSIClockRateListTable.MyRecordsetDataSource;
						num = (short)594804755;
						num3 = (int)((global::System.IntPtr)num);
						continue;
						IL_47B:
						acpExpander = null;
						enumerator = this.MyStackPanel.Children.GetEnumerator();
						num = (short)1919287312;
						num3 = (int)((global::System.IntPtr)num);
						continue;
						IL_4D7:
						num = (short)1165950977;
						if (num != 0)
						{
						}
						obj = this.RecNavToolbarExpanderFactoryOverridesRxSSIClockRateListTable.MyRecordsetDataSource;
						num = (short)2003369994;
						num3 = (int)((global::System.IntPtr)num);
						continue;
						IL_58C:
						obj = this.RecNavToolbarExpanderFactoryOverridesTxSynthesizerReferenceDividerListTable.MyRecordsetDataSource;
						num = (short)337772561;
						num3 = (int)((global::System.IntPtr)num);
						continue;
						IL_685:
						obj = this.RecNavToolbarExpanderFactoryOverridesSecondLOInjectionFrequencyList.MyRecordsetDataSource;
						num = (short)1221591046;
						num3 = (int)((global::System.IntPtr)num);
					}
				}
				IL_4D2:
				IL_6CC:
				this.MyStackPanel.Children[0].Focus();
				return;
			}
		}

		// Token: 0x060093A7 RID: 37799 RVA: 0x008B092C File Offset: 0x008AEB2C
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
				{
					if (!this.a)
					{
						return;
					}
					num2 = (short)826504972;
					short num3 = num2;
					num2 = (short)1278506764;
					switch ((num3 == num2) ? 1 : 0)
					{
					case 0:
					case 2:
						continue;
					default:
						num2 = (short)1308688384;
						if (num2 != 0)
						{
						}
						num2 = (short)17629185;
						if (num2 != 0)
						{
						}
						num2 = (short)1426718721;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					break;
				}
				case 1:
					base.OnUnloaded(sender, e);
					this.a = false;
					num2 = (short)2054094850;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 2:
					return;
				}
				goto IL_1C;
			}
			return;
			IL_1C:
			num2 = (short)1166147584;
			short num4 = num2;
			this.RecNavToolbarExpanderFactoryOverridesRxSynthesizerReferenceDividerListTable.DataContext = null;
			this.RecNavToolbarExpanderFactoryOverridesTxSynthesizerReferenceDividerListTable.DataContext = null;
			this.RecNavToolbarExpanderFactoryOverridesTxSSIClockRateListTable.DataContext = null;
			this.RecNavToolbarExpanderFactoryOverridesRxSSIClockRateListTable.DataContext = null;
			this.RecNavToolbarExpanderFactoryOverridesRxSSIClockRateTXMode.DataContext = null;
			this.RecNavToolbarExpanderFactoryOverridesSecondLOInjectionFrequencyList.DataContext = null;
			this.RecNavToolbarExpanderFactoryOverridesRxFrequencyList.DataContext = null;
			this.RecNavToolbarExpanderFactoryOverridesRxSynthesizerReferenceDividerListTable.MyDataPresenter = null;
			this.RecNavToolbarExpanderFactoryOverridesTxSynthesizerReferenceDividerListTable.MyDataPresenter = null;
			this.RecNavToolbarExpanderFactoryOverridesTxSSIClockRateListTable.MyDataPresenter = null;
			this.RecNavToolbarExpanderFactoryOverridesRxSSIClockRateListTable.MyDataPresenter = null;
			this.RecNavToolbarExpanderFactoryOverridesRxSSIClockRateTXMode.MyDataPresenter = null;
			this.RecNavToolbarExpanderFactoryOverridesSecondLOInjectionFrequencyList.MyDataPresenter = null;
			this.RecNavToolbarExpanderFactoryOverridesRxFrequencyList.MyDataPresenter = null;
			num2 = (short)735576064;
			num = (int)((global::System.IntPtr)num2);
			goto IL_0A;
		}

		// Token: 0x060093A8 RID: 37800 RVA: 0x008B0B00 File Offset: 0x008AED00
		public override void SetDataContext()
		{
			short num = (short)1806565378;
			int num2 = (int)((global::System.IntPtr)num);
			object feature;
			for (;;)
			{
				switch (num2)
				{
				case 0:
					if (((global::AcpCommonLib.IAcpRecordset)feature)[0][10008] != null)
					{
						num = (short)999227444;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_8F1;
				case 1:
					if (((global::AcpCommonLib.IAcpRecordset)feature)[0][10612] != null)
					{
						num = (short)1778188311;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_A7C;
				case 2:
				{
					num = (short)1583611904;
					short num3 = num;
					switch (0)
					{
					case 0:
						goto IL_163;
					}
					continue;
				}
				case 3:
					base.DataContext = global::AcpCommonLib.AppInfoManager.DefaultDocument.GetFeature(2003);
					num = (short)1743126558;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 4:
					goto IL_9C7;
				case 5:
					num = (short)1571880960;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 6:
					if (((global::AcpCommonLib.IAcpRecordset)feature)[0][10801] != null)
					{
						num = (short)1601962015;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_CC6;
				case 7:
					if (feature != null)
					{
						num = (short)1204289573;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_8F1;
				case 8:
					((global::AcpUILib.IAcpRecNavToolbar)this.RecNavToolbarExpanderFactoryOverridesRxSynthesizerReferenceDividerListTable).MySecondaryRecordsetDataSource = ((global::AcpCommonLib.IAcpRecordset)feature)[0][10006].EmbeddedRecset;
					((global::AcpUILib.IAcpRecNavToolbar)this.RecNavToolbarExpanderFactoryOverridesRxSynthesizerReferenceDividerListTable).SyncDataSources();
					num = (short)307101752;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 9:
					goto IL_A7C;
				case 10:
					if (feature != null)
					{
						num = (short)919601164;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_5C5;
				case 11:
					if (((global::AcpCommonLib.IAcpRecordset)feature)[0] != null)
					{
						num = (short)1959067707;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_CC6;
				case 12:
					num = (short)731316285;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 13:
					if (((global::AcpCommonLib.IAcpRecordset)feature)[0][10905].EmbeddedRecset != null)
					{
						num = (short)1019084829;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					return;
				case 14:
					goto IL_B77;
				case 15:
					num = (short)1221328909;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 16:
					goto IL_618;
				case 17:
					num = (short)1652883472;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 18:
					if (feature != null)
					{
						num = (short)1656488003;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_A7C;
				case 19:
					num = (short)62783514;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 20:
					num = (short)2092892161;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 21:
					((global::AcpUILib.IAcpRecNavToolbar)this.RecNavToolbarExpanderFactoryOverridesSecondLOInjectionFrequencyList).MySecondaryRecordsetDataSource = ((global::AcpCommonLib.IAcpRecordset)feature)[0][10010].EmbeddedRecset;
					((global::AcpUILib.IAcpRecNavToolbar)this.RecNavToolbarExpanderFactoryOverridesSecondLOInjectionFrequencyList).SyncDataSources();
					num = (short)1724776486;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 22:
					num = (short)1516372012;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 23:
					num = (short)133169177;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 24:
					if (((global::AcpCommonLib.IAcpRecordset)feature)[0] != null)
					{
						num = (short)833945622;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					return;
				case 25:
					if (((global::AcpCommonLib.IAcpRecordset)feature)[0][10612].EmbeddedRecset != null)
					{
						num = (short)1161822271;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_A7C;
				case 26:
					if (((global::AcpCommonLib.IAcpRecordset)feature)[0] != null)
					{
						num = (short)1892417587;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_6A5;
				case 27:
					goto IL_8F1;
				case 28:
					if (((global::AcpCommonLib.IAcpRecordset)feature)[0][10010] != null)
					{
						num = (short)1668087861;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_6A5;
				case 29:
					goto IL_C75;
				case 30:
					goto IL_B77;
				case 31:
					num = (short)1434583102;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 32:
					if (feature != null)
					{
						num = (short)280887364;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_9C7;
				case 33:
					num = (short)1163984951;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 34:
					if (feature != null)
					{
						num = (short)1238695993;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_CC6;
				case 35:
					num = (short)1975451702;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 36:
					if (((global::AcpCommonLib.IAcpRecordset)feature)[0] != null)
					{
						num = (short)1046282273;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_9C7;
				case 37:
					num = (short)1854668841;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 38:
					goto IL_6A5;
				case 39:
					if (((global::AcpCommonLib.IAcpRecordset)feature)[0] != null)
					{
						num = (short)295174164;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_A7C;
				case 40:
					goto IL_53E;
				case 41:
					if (((global::AcpCommonLib.IAcpRecordset)feature)[0] != null)
					{
						num = (short)420478981;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_8F1;
				case 42:
					if (((global::AcpCommonLib.IAcpRecordset)feature)[0][10006] != null)
					{
						num = (short)600178705;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_5C5;
				case 43:
					((global::AcpUILib.IAcpRecNavToolbar)this.RecNavToolbarExpanderFactoryOverridesTxSynthesizerReferenceDividerListTable).MySecondaryRecordsetDataSource = ((global::AcpCommonLib.IAcpRecordset)feature)[0][10008].EmbeddedRecset;
					((global::AcpUILib.IAcpRecNavToolbar)this.RecNavToolbarExpanderFactoryOverridesTxSynthesizerReferenceDividerListTable).SyncDataSources();
					num = (short)84738075;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 44:
					if (((global::AcpCommonLib.IAcpRecordset)feature)[0][10905] != null)
					{
						num = (short)1637351439;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					return;
				case 45:
				{
					num = (short)278899428;
					short num4 = num;
					num = (short)1546627812;
					switch ((num4 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_618;
					default:
						num = (short)1577517056;
						if (num != 0)
						{
						}
						((global::AcpUILib.IAcpRecNavToolbar)this.RecNavToolbarExpanderFactoryOverridesRxSSIClockRateTXMode).MySecondaryRecordsetDataSource = ((global::AcpCommonLib.IAcpRecordset)feature)[0][10801].EmbeddedRecset;
						((global::AcpUILib.IAcpRecNavToolbar)this.RecNavToolbarExpanderFactoryOverridesRxSSIClockRateTXMode).SyncDataSources();
						num = (short)1800536122;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					break;
				}
				case 46:
					if (((global::AcpCommonLib.IAcpRecordset)feature)[0][10010].EmbeddedRecset != null)
					{
						num = (short)1969487893;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_6A5;
				case 47:
					if (feature != null)
					{
						num = (short)1223950400;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					return;
				case 48:
					num = (short)1266352170;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 49:
					if (((global::AcpCommonLib.IAcpRecordset)feature)[0][10008].EmbeddedRecset != null)
					{
						num = (short)379453483;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_8F1;
				case 50:
					((global::AcpUILib.IAcpRecNavToolbar)this.RecNavToolbarExpanderFactoryOverridesRxSSIClockRateListTable).MySecondaryRecordsetDataSource = ((global::AcpCommonLib.IAcpRecordset)feature)[0][10791].EmbeddedRecset;
					((global::AcpUILib.IAcpRecNavToolbar)this.RecNavToolbarExpanderFactoryOverridesRxSSIClockRateListTable).SyncDataSources();
					num = (short)230227972;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 51:
					num = (short)1329922076;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 52:
					num = (short)1841233969;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 53:
					num = (short)373030958;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 54:
					if (((global::AcpCommonLib.IAcpRecordset)feature)[0][10791].EmbeddedRecset != null)
					{
						num = (short)1948188722;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_9C7;
				case 55:
					if (((global::AcpCommonLib.IAcpRecordset)feature)[0][10791] != null)
					{
						num = (short)168624163;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_9C7;
				case 56:
					goto IL_5C5;
				case 57:
					num = (short)231866379;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 58:
					goto IL_CC6;
				case 59:
					num = (short)463536134;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 60:
					if (feature != null)
					{
						num = (short)2082537491;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_6A5;
				case 61:
					if (((global::AcpCommonLib.IAcpRecordset)feature)[0] != null)
					{
						num = (short)2012479536;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_5C5;
				case 62:
					if (((global::AcpCommonLib.IAcpRecordset)feature)[0][10801].EmbeddedRecset != null)
					{
						num = (short)1441071149;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_CC6;
				case 63:
					((global::AcpUILib.IAcpRecNavToolbar)this.RecNavToolbarExpanderFactoryOverridesTxSSIClockRateListTable).MySecondaryRecordsetDataSource = ((global::AcpCommonLib.IAcpRecordset)feature)[0][10612].EmbeddedRecset;
					((global::AcpUILib.IAcpRecNavToolbar)this.RecNavToolbarExpanderFactoryOverridesTxSSIClockRateListTable).SyncDataSources();
					num = (short)1504313353;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 64:
					num = (short)178520088;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 65:
					if (global::AcpCommonLib.AppInfoManager.AppMode == global::AcpCommonLib.ApplicationMode.CodeplugComparisonMode)
					{
						num = (short)1988689986;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					((global::AcpUILib.IAcpRecNavToolbar)this.RecNavToolbarExpanderFactoryOverridesRxSynthesizerReferenceDividerListTable).MySecondaryRecordsetDataSource = null;
					((global::AcpUILib.IAcpRecNavToolbar)this.RecNavToolbarExpanderFactoryOverridesTxSynthesizerReferenceDividerListTable).MySecondaryRecordsetDataSource = null;
					((global::AcpUILib.IAcpRecNavToolbar)this.RecNavToolbarExpanderFactoryOverridesTxSSIClockRateListTable).MySecondaryRecordsetDataSource = null;
					((global::AcpUILib.IAcpRecNavToolbar)this.RecNavToolbarExpanderFactoryOverridesRxSSIClockRateListTable).MySecondaryRecordsetDataSource = null;
					((global::AcpUILib.IAcpRecNavToolbar)this.RecNavToolbarExpanderFactoryOverridesRxSSIClockRateTXMode).MySecondaryRecordsetDataSource = null;
					((global::AcpUILib.IAcpRecNavToolbar)this.RecNavToolbarExpanderFactoryOverridesSecondLOInjectionFrequencyList).MySecondaryRecordsetDataSource = null;
					((global::AcpUILib.IAcpRecNavToolbar)this.RecNavToolbarExpanderFactoryOverridesRxFrequencyList).MySecondaryRecordsetDataSource = null;
					num = (short)249364520;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 66:
					feature = global::AcpCommonLib.AppInfoManager.ComparatorDocument.GetFeature(2003);
					num = (short)1712521217;
					if (num != 0)
					{
					}
					num = (short)6160394;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 67:
					num = (short)1188167719;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 68:
					num = (short)409534500;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				IL_163:
				if (global::AcpCommonLib.AppInfoManager.AppMode == global::AcpCommonLib.ApplicationMode.CustomViewConfigurationMode)
				{
					num = (short)1605500931;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				base.DataContext = global::AcpCommonLib.FeatureManager.GetFeature(2003);
				num = (short)486866958;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_5C5:
				num = (short)133562375;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_618:
				if (((global::AcpCommonLib.IAcpRecordset)feature)[0][10006].EmbeddedRecset != null)
				{
					num = (short)1773928456;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				goto IL_5C5;
				IL_6A5:
				num = (short)1243873327;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_8F1:
				num = (short)325976082;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_9C7:
				num = (short)1291190306;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_A7C:
				num = (short)1395392544;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_B77:
				num = (short)500105281;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_CC6:
				num = (short)402522172;
				num2 = (int)((global::System.IntPtr)num);
			}
			IL_53E:
			return;
			IL_C75:
			((global::AcpUILib.IAcpRecNavToolbar)this.RecNavToolbarExpanderFactoryOverridesRxFrequencyList).MySecondaryRecordsetDataSource = ((global::AcpCommonLib.IAcpRecordset)feature)[0][10905].EmbeddedRecset;
			((global::AcpUILib.IAcpRecNavToolbar)this.RecNavToolbarExpanderFactoryOverridesRxFrequencyList).SyncDataSources();
		}

		// Token: 0x060093A9 RID: 37801 RVA: 0x008B180C File Offset: 0x008AFA0C
		private void OnModeClick(object A_0, global::System.Windows.RoutedEventArgs A_1)
		{
			int a_ = 19;
			short num = (short)1000931328;
			switch (num)
			{
			default:
			{
				num = (short)1174667277;
				int num2 = (int)((global::System.IntPtr)num);
				object myRecordsetDataSource7;
				for (;;)
				{
					switch (num2)
					{
					case 0:
					{
						num = (short)1611857920;
						short num3 = num;
						num = (short)1166606391;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 1:
					{
						object myRecordsetDataSource;
						if (myRecordsetDataSource != null)
						{
							num = (short)776142856;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_AD5;
					}
					case 2:
					{
						((global::AcpUI.AcpRecNavToolbar)A_0).TableMode = false;
						object myRecordsetDataSource = this.RecNavToolbarExpanderFactoryOverridesRxSSIClockRateTXMode.MyRecordsetDataSource;
						num = (short)283049985;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 3:
						if (((global::AcpUI.AcpRecNavToolbar)A_0).Name == global::AllFeatures.CodeplugGuid.b("蛓돕믗铙뷛꣝듟跡诣諥諧诩黫꯭裯英闳飵鳷鿹軻룽懿愁瀃椅稇猉䌋砍甏怑易缕簗缙漛䰝堟搡嘣䌥大弩䤫䀭匯䬱砳張䬷丹", a_))
						{
							num = (short)1156120590;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return;
					case 4:
						num = (short)1342439440;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 5:
					{
						object myRecordsetDataSource2;
						global::System.Windows.Data.CollectionView collectionView = (global::System.Windows.Data.CollectionView)global::System.Windows.Data.CollectionViewSource.GetDefaultView(myRecordsetDataSource2);
						global::Motorola.MackinawCPS.CoreFeatures.FactoryOverrides.TxSSIClockRateListInner item = (global::Motorola.MackinawCPS.CoreFeatures.FactoryOverrides.TxSSIClockRateListInner)collectionView.CurrentItem;
						collectionView.MoveCurrentTo(item);
						((global::AcpUI.AcpRecNavToolbar)A_0).SyncDataSources();
						num = (short)1651179573;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 6:
						goto IL_5B9;
					case 7:
						if (((global::AcpUI.AcpRecNavToolbar)A_0).Name == global::AllFeatures.CodeplugGuid.b("蛓돕믗铙뷛꣝듟跡诣諥諧诩黫꯭裯英闳飵鳷鿹軻룽懿愁瀃椅稇猉䌋砍甏怑易缕簗缙漛䰝堟無眣漥欧䘩䌫䴭嬯怱唳䈵崷渹搻猽⼿♁⅃", a_))
						{
							num = (short)7602205;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_AD5;
					case 8:
					{
						object myRecordsetDataSource;
						global::System.Windows.Data.CollectionView collectionView2 = (global::System.Windows.Data.CollectionView)global::System.Windows.Data.CollectionViewSource.GetDefaultView(myRecordsetDataSource);
						global::Motorola.MackinawCPS.CoreFeatures.FactoryOverrides.RxSSIClockRateTXModeInner item2 = (global::Motorola.MackinawCPS.CoreFeatures.FactoryOverrides.RxSSIClockRateTXModeInner)collectionView2.CurrentItem;
						collectionView2.MoveCurrentTo(item2);
						((global::AcpUI.AcpRecNavToolbar)A_0).SyncDataSources();
						num = (short)1049821240;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 9:
						goto IL_3CB;
					case 10:
						goto IL_AD5;
					case 11:
					{
						object myRecordsetDataSource3;
						if (myRecordsetDataSource3 != null)
						{
							num = (short)409403420;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_9FD;
					}
					case 12:
					{
						((global::AcpUI.AcpRecNavToolbar)A_0).TableMode = false;
						object myRecordsetDataSource4 = this.RecNavToolbarExpanderFactoryOverridesSecondLOInjectionFrequencyList.MyRecordsetDataSource;
						num = (short)1862991905;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 13:
						switch (0)
						{
						case 0:
							goto IL_131;
						}
						continue;
					case 14:
						num = (short)1905262643;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 15:
						goto IL_3CB;
					case 16:
						if (((global::AcpUI.AcpRecNavToolbar)A_0).TableMode)
						{
							num = (short)884080676;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						((global::AcpUI.AcpRecNavToolbar)A_0).TableMode = true;
						num = (short)1861419049;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 17:
						if (((global::AcpUI.AcpRecNavToolbar)A_0).TableMode)
						{
							num = (short)953745410;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						((global::AcpUI.AcpRecNavToolbar)A_0).TableMode = true;
						num = (short)1957494794;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 18:
					{
						object myRecordsetDataSource5;
						global::System.Windows.Data.CollectionView collectionView3 = (global::System.Windows.Data.CollectionView)global::System.Windows.Data.CollectionViewSource.GetDefaultView(myRecordsetDataSource5);
						global::Motorola.MackinawCPS.CoreFeatures.FactoryOverrides.RxSynthesizerReferenceDividerListInner item3 = (global::Motorola.MackinawCPS.CoreFeatures.FactoryOverrides.RxSynthesizerReferenceDividerListInner)collectionView3.CurrentItem;
						collectionView3.MoveCurrentTo(item3);
						((global::AcpUI.AcpRecNavToolbar)A_0).SyncDataSources();
						num = (short)193003572;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 19:
					{
						object myRecordsetDataSource6;
						global::System.Windows.Data.CollectionView collectionView4 = (global::System.Windows.Data.CollectionView)global::System.Windows.Data.CollectionViewSource.GetDefaultView(myRecordsetDataSource6);
						global::Motorola.MackinawCPS.CoreFeatures.FactoryOverrides.TxSynthesizerReferenceDividerListInner item4 = (global::Motorola.MackinawCPS.CoreFeatures.FactoryOverrides.TxSynthesizerReferenceDividerListInner)collectionView4.CurrentItem;
						collectionView4.MoveCurrentTo(item4);
						((global::AcpUI.AcpRecNavToolbar)A_0).SyncDataSources();
						num = (short)1875116038;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 20:
						if (myRecordsetDataSource7 != null)
						{
							num = (short)336920619;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return;
					case 21:
						if (((global::AcpUI.AcpRecNavToolbar)A_0).Name == global::AllFeatures.CodeplugGuid.b("蛓돕믗铙뷛꣝듟跡诣諥諧诩黫꯭裯英闳飵鳷鿹軻룽懿愁瀃椅稇猉䌋砍甏怑易缕簗缙漛䰝堟無崣䠥尧䈩䤫崭夯䠱儳䐵樷弹娻嬽㈿❁⩃╅ⵇ้╋㡍㥏㙑ㅓ⑕ᑗ㍙⽛⩝㑟͡٣੥൧", a_))
						{
							num = (short)1314979875;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_561;
					case 22:
						if (((global::AcpUI.AcpRecNavToolbar)A_0).Name == global::AllFeatures.CodeplugGuid.b("蛓돕믗铙뷛꣝듟跡诣諥諧诩黫꯭裯英闳飵鳷鿹軻룽懿愁瀃椅稇猉䌋砍甏怑易缕簗缙漛䨝堟無眣漥欧䘩䌫䴭嬯怱唳䈵崷瘹唻䴽㐿ᙁ╃⑅⑇⽉", a_))
						{
							num = (short)51183663;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_6C5;
					case 23:
					{
						object myRecordsetDataSource5;
						if (myRecordsetDataSource5 != null)
						{
							num = (short)591659026;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_561;
					}
					case 24:
						goto IL_5B9;
					case 25:
					{
						num = (short)1573278599;
						short num4 = num;
						num = (short)1886540679;
						switch ((num4 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_7B2;
						default:
							num = (short)1532493824;
							if (num != 0)
							{
							}
							if (((global::AcpUI.AcpRecNavToolbar)A_0).Name == global::AllFeatures.CodeplugGuid.b("蛓돕믗铙뷛꣝듟跡诣諥諧诩黫꯭裯英闳飵鳷鿹軻룽懿愁瀃椅稇猉䌋砍甏怑易缕簗缙漛䰝堟無眣漥欧䘩䌫䴭嬯怱唳䈵崷瘹唻䴽㐿ᙁ╃⑅⑇⽉", a_))
							{
								num = (short)313131012;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							goto IL_9FD;
						}
						break;
					}
					case 26:
						num = (short)2100297749;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 27:
						if (((global::AcpUI.AcpRecNavToolbar)A_0).TableMode)
						{
							num = (short)1750270000;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						((global::AcpUI.AcpRecNavToolbar)A_0).TableMode = true;
						num = (short)2066481183;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 28:
					{
						object myRecordsetDataSource3;
						global::System.Windows.Data.CollectionView collectionView5 = (global::System.Windows.Data.CollectionView)global::System.Windows.Data.CollectionViewSource.GetDefaultView(myRecordsetDataSource3);
						global::Motorola.MackinawCPS.CoreFeatures.FactoryOverrides.RxSSIClockRateListInner item5 = (global::Motorola.MackinawCPS.CoreFeatures.FactoryOverrides.RxSSIClockRateListInner)collectionView5.CurrentItem;
						collectionView5.MoveCurrentTo(item5);
						((global::AcpUI.AcpRecNavToolbar)A_0).SyncDataSources();
						num = (short)158793770;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 29:
						num = (short)2058485777;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 30:
						if (((global::AcpUI.AcpRecNavToolbar)A_0).Name == global::AllFeatures.CodeplugGuid.b("蛓돕믗铙뷛꣝듟跡诣諥諧诩黫꯭裯英闳飵鳷鿹軻룽懿愁瀃椅稇猉䌋砍甏怑易缕簗缙漛䨝堟無崣䠥尧䈩䤫崭夯䠱儳䐵樷弹娻嬽㈿❁⩃╅ⵇ้╋㡍㥏㙑ㅓ⑕ᑗ㍙⽛⩝㑟͡٣੥൧", a_))
						{
							num = (short)1476395008;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_5B9;
					case 31:
						goto IL_6C5;
					case 32:
						((global::AcpUI.AcpRecNavToolbar)A_0).TableMode = false;
						myRecordsetDataSource7 = this.RecNavToolbarExpanderFactoryOverridesRxFrequencyList.MyRecordsetDataSource;
						num = (short)1134559252;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 33:
					{
						object myRecordsetDataSource4;
						if (myRecordsetDataSource4 != null)
						{
							num = (short)2054815790;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_3CB;
					}
					case 34:
						if (((global::AcpUI.AcpRecNavToolbar)A_0).TableMode)
						{
							num = (short)2136342568;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						((global::AcpUI.AcpRecNavToolbar)A_0).TableMode = true;
						num = (short)474415153;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 35:
						num = (short)1274806306;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 36:
					{
						((global::AcpUI.AcpRecNavToolbar)A_0).TableMode = false;
						object myRecordsetDataSource3 = this.RecNavToolbarExpanderFactoryOverridesRxSSIClockRateListTable.MyRecordsetDataSource;
						num = (short)1692991499;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 37:
						if (((global::AcpUI.AcpRecNavToolbar)A_0).TableMode)
						{
							num = (short)376307724;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						((global::AcpUI.AcpRecNavToolbar)A_0).TableMode = true;
						num = (short)74579983;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 38:
					{
						object myRecordsetDataSource2;
						if (myRecordsetDataSource2 != null)
						{
							num = (short)1944780805;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_6C5;
					}
					case 39:
					{
						((global::AcpUI.AcpRecNavToolbar)A_0).TableMode = false;
						object myRecordsetDataSource6 = this.RecNavToolbarExpanderFactoryOverridesTxSynthesizerReferenceDividerListTable.MyRecordsetDataSource;
						num = (short)1632370742;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 40:
					{
						((global::AcpUI.AcpRecNavToolbar)A_0).TableMode = false;
						object myRecordsetDataSource5 = this.RecNavToolbarExpanderFactoryOverridesRxSynthesizerReferenceDividerListTable.MyRecordsetDataSource;
						num = (short)118947863;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 41:
						goto IL_9FD;
					case 42:
						goto IL_9FD;
					case 43:
						goto IL_335;
					case 44:
						num = (short)701300773;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 45:
						return;
					case 46:
					{
						object myRecordsetDataSource4;
						global::System.Windows.Data.CollectionView collectionView6 = (global::System.Windows.Data.CollectionView)global::System.Windows.Data.CollectionViewSource.GetDefaultView(myRecordsetDataSource4);
						global::Motorola.MackinawCPS.CoreFeatures.FactoryOverrides.SecondLOInjectionFrequencyListInner item6 = (global::Motorola.MackinawCPS.CoreFeatures.FactoryOverrides.SecondLOInjectionFrequencyListInner)collectionView6.CurrentItem;
						collectionView6.MoveCurrentTo(item6);
						((global::AcpUI.AcpRecNavToolbar)A_0).SyncDataSources();
						num = (short)1637154825;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 47:
						goto IL_7B2;
					case 48:
					{
						((global::AcpUI.AcpRecNavToolbar)A_0).TableMode = false;
						object myRecordsetDataSource2 = this.RecNavToolbarExpanderFactoryOverridesTxSSIClockRateListTable.MyRecordsetDataSource;
						num = (short)2031550502;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 49:
						goto IL_561;
					case 50:
						if (((global::AcpUI.AcpRecNavToolbar)A_0).Name == global::AllFeatures.CodeplugGuid.b("蛓돕믗铙뷛꣝듟跡诣諥諧诩黫꯭裯英闳飵鳷鿹軻룽懿愁瀃椅稇猉䌋砍甏怑易缕簗缙漛䴝䔟䄡䬣䠥䰧昩挫札帯報儳唵䰷匹医倽ؿぁ⅃㝅㵇⽉≋ⵍ⥏ṑ㵓╕ⱗ", a_))
						{
							num = (short)2072707116;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_3CB;
					case 51:
						if (((global::AcpUI.AcpRecNavToolbar)A_0).TableMode)
						{
							num = (short)1850540064;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						((global::AcpUI.AcpRecNavToolbar)A_0).TableMode = true;
						num = (short)1008074797;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 52:
						goto IL_561;
					case 53:
						goto IL_6C5;
					case 54:
					{
						object myRecordsetDataSource6;
						if (myRecordsetDataSource6 != null)
						{
							num = (short)31260691;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_5B9;
					}
					case 55:
						if (((global::AcpUI.AcpRecNavToolbar)A_0).TableMode)
						{
							num = (short)1305870375;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						((global::AcpUI.AcpRecNavToolbar)A_0).TableMode = true;
						num = (short)127139864;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 56:
						goto IL_AD5;
					}
					IL_131:
					if (A_0 is global::AcpUI.AcpRecNavToolbar)
					{
						num = (short)1040121857;
						if (num != 0)
						{
						}
						num = (short)577306650;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					return;
					IL_3CB:
					num = (short)88670211;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_561:
					num = (short)637337630;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_5B9:
					num = (short)1601437718;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_6C5:
					num = (short)415694873;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_7B2:
					num = (short)1170014235;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_9FD:
					num = (short)637927431;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_AD5:
					num = (short)1483997234;
					num2 = (int)((global::System.IntPtr)num);
				}
				IL_335:
				global::System.Windows.Data.CollectionView collectionView7 = (global::System.Windows.Data.CollectionView)global::System.Windows.Data.CollectionViewSource.GetDefaultView(myRecordsetDataSource7);
				global::Motorola.MackinawCPS.CoreFeatures.FactoryOverrides.RxFrequencyListInner item7 = (global::Motorola.MackinawCPS.CoreFeatures.FactoryOverrides.RxFrequencyListInner)collectionView7.CurrentItem;
				collectionView7.MoveCurrentTo(item7);
				((global::AcpUI.AcpRecNavToolbar)A_0).SyncDataSources();
				return;
			}
			}
		}

		// Token: 0x060093AA RID: 37802 RVA: 0x008B23CC File Offset: 0x008B05CC
		private void HLinkClick(object A_0, global::System.Windows.RoutedEventArgs A_1)
		{
			short num = (short)1213767425;
			short num2 = num;
			num = (short)389259009;
			switch (num2 == num)
			{
			}
			num = (short)603062273;
			if (num != 0)
			{
			}
			num = (short)793313280;
			short num3 = num;
			num = (short)1805058048;
			if (num != 0)
			{
			}
			base.OnHLinkClick(A_0);
		}

		// Token: 0x060093AB RID: 37803 RVA: 0x008B2480 File Offset: 0x008B0680
		private void OnFieldNameDoubleClick(object A_0, global::System.Windows.RoutedEventArgs A_1)
		{
			short num = (short)971158634;
			short num2 = num;
			num = (short)727561322;
			switch (num2 == num)
			{
			}
			num = (short)360054784;
			if (num != 0)
			{
			}
			num = (short)1638662144;
			short num3 = num;
			num = (short)1491009537;
			if (num != 0)
			{
			}
			global::AcpUI.Common.Utility.GetFieldHelpText(A_0);
		}

		// Token: 0x060093AC RID: 37804 RVA: 0x008B2534 File Offset: 0x008B0734
		internal void OnExpanderFactoryOverridesRxSynthesizerReferenceDividerListTableClick(object sender, global::System.Windows.RoutedEventArgs e)
		{
			switch (0)
			{
			case 0:
				goto IL_43;
			}
			short num;
			int num2;
			object myRecordsetDataSource;
			global::Motorola.MackinawCPS.CoreFeatures.FactoryOverrides.RxSynthesizerReferenceDividerListInner item;
			for (;;)
			{
				IL_0A:
				num = (short)187826177;
				if (num != 0)
				{
				}
				switch (num2)
				{
				case 0:
					goto IL_CD;
				case 1:
				{
					num = (short)70132644;
					short num3 = num;
					num = (short)508568484;
					switch ((num3 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_CD;
					default:
						goto IL_137;
					}
					break;
				}
				case 2:
					if (myRecordsetDataSource != null)
					{
						num = (short)1045233664;
						short num4 = num;
						num = (short)1936982016;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_14F;
				}
				goto IL_43;
				IL_CD:
				((global::System.Windows.Data.CollectionView)global::System.Windows.Data.CollectionViewSource.GetDefaultView(myRecordsetDataSource)).MoveCurrentTo(item);
				this.RecNavToolbarExpanderFactoryOverridesRxSynthesizerReferenceDividerListTable.SyncDataSources();
				num = (short)1203634177;
				num2 = (int)((global::System.IntPtr)num);
			}
			IL_137:
			num = (short)1574699008;
			if (num != 0)
			{
			}
			IL_14F:
			this.RecNavToolbarExpanderFactoryOverridesRxSynthesizerReferenceDividerListTable.TableMode = false;
			return;
			IL_43:
			item = (global::Motorola.MackinawCPS.CoreFeatures.FactoryOverrides.RxSynthesizerReferenceDividerListInner)((global::Infragistics.Windows.DataPresenter.CellValuePresenter)((global::AcpUI.AcpButton)e.Source).TemplatedParent).Record.DataItem;
			myRecordsetDataSource = this.RecNavToolbarExpanderFactoryOverridesRxSynthesizerReferenceDividerListTable.MyRecordsetDataSource;
			num = (short)1864892418;
			num2 = (int)((global::System.IntPtr)num);
			goto IL_0A;
		}

		// Token: 0x060093AD RID: 37805 RVA: 0x008B269C File Offset: 0x008B089C
		internal void OnExpanderFactoryOverridesTxSynthesizerReferenceDividerListTableClick(object sender, global::System.Windows.RoutedEventArgs e)
		{
			switch (0)
			{
			case 0:
				goto IL_1C;
			}
			int num;
			short num2;
			object myRecordsetDataSource;
			global::Motorola.MackinawCPS.CoreFeatures.FactoryOverrides.TxSynthesizerReferenceDividerListInner item;
			for (;;)
			{
				IL_0A:
				switch (num)
				{
				case 0:
					goto IL_D3;
				case 1:
				{
					num2 = (short)58046408;
					short num3 = num2;
					num2 = (short)1216526280;
					switch ((num3 == num2) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_D3;
					default:
						goto IL_13F;
					}
					break;
				}
				case 2:
					num2 = (short)1122304001;
					if (num2 != 0)
					{
					}
					if (myRecordsetDataSource != null)
					{
						num2 = (short)565903360;
						short num4 = num2;
						num2 = (short)1888092160;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_156;
				}
				goto IL_1C;
				IL_D3:
				((global::System.Windows.Data.CollectionView)global::System.Windows.Data.CollectionViewSource.GetDefaultView(myRecordsetDataSource)).MoveCurrentTo(item);
				this.RecNavToolbarExpanderFactoryOverridesTxSynthesizerReferenceDividerListTable.SyncDataSources();
				num2 = (short)1632960513;
				num = (int)((global::System.IntPtr)num2);
			}
			IL_13F:
			num2 = (short)132251648;
			if (num2 != 0)
			{
			}
			IL_156:
			this.RecNavToolbarExpanderFactoryOverridesTxSynthesizerReferenceDividerListTable.TableMode = false;
			return;
			IL_1C:
			item = (global::Motorola.MackinawCPS.CoreFeatures.FactoryOverrides.TxSynthesizerReferenceDividerListInner)((global::Infragistics.Windows.DataPresenter.CellValuePresenter)((global::AcpUI.AcpButton)e.Source).TemplatedParent).Record.DataItem;
			myRecordsetDataSource = this.RecNavToolbarExpanderFactoryOverridesTxSynthesizerReferenceDividerListTable.MyRecordsetDataSource;
			num2 = (short)231538690;
			num = (int)((global::System.IntPtr)num2);
			goto IL_0A;
		}

		// Token: 0x060093AE RID: 37806 RVA: 0x008B280C File Offset: 0x008B0A0C
		internal void OnExpanderFactoryOverridesTxSSIClockRateListTableClick(object sender, global::System.Windows.RoutedEventArgs e)
		{
			switch (0)
			{
			case 0:
				goto IL_1C;
			}
			int num;
			short num2;
			object myRecordsetDataSource;
			global::Motorola.MackinawCPS.CoreFeatures.FactoryOverrides.TxSSIClockRateListInner item;
			for (;;)
			{
				IL_0A:
				switch (num)
				{
				case 0:
					goto IL_7C;
				case 1:
				{
					num2 = (short)1617035265;
					if (num2 != 0)
					{
					}
					num2 = (short)414057158;
					short num3 = num2;
					num2 = (short)1236140742;
					switch ((num3 == num2) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_7C;
					default:
						goto IL_139;
					}
					break;
				}
				case 2:
					if (myRecordsetDataSource != null)
					{
						num2 = (short)206176256;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_151;
				}
				goto IL_1C;
				IL_7C:
				num2 = (short)16908288;
				short num4 = num2;
				((global::System.Windows.Data.CollectionView)global::System.Windows.Data.CollectionViewSource.GetDefaultView(myRecordsetDataSource)).MoveCurrentTo(item);
				this.RecNavToolbarExpanderFactoryOverridesTxSSIClockRateListTable.SyncDataSources();
				num2 = (short)1630666753;
				num = (int)((global::System.IntPtr)num2);
			}
			IL_139:
			num2 = (short)1167851520;
			if (num2 != 0)
			{
			}
			IL_151:
			this.RecNavToolbarExpanderFactoryOverridesTxSSIClockRateListTable.TableMode = false;
			return;
			IL_1C:
			item = (global::Motorola.MackinawCPS.CoreFeatures.FactoryOverrides.TxSSIClockRateListInner)((global::Infragistics.Windows.DataPresenter.CellValuePresenter)((global::AcpUI.AcpButton)e.Source).TemplatedParent).Record.DataItem;
			myRecordsetDataSource = this.RecNavToolbarExpanderFactoryOverridesTxSSIClockRateListTable.MyRecordsetDataSource;
			num2 = (short)691208194;
			num = (int)((global::System.IntPtr)num2);
			goto IL_0A;
		}

		// Token: 0x060093AF RID: 37807 RVA: 0x008B2978 File Offset: 0x008B0B78
		internal void OnExpanderFactoryOverridesRxSSIClockRateListTableClick(object sender, global::System.Windows.RoutedEventArgs e)
		{
			switch (0)
			{
			case 0:
				goto IL_1C;
			}
			int num;
			short num2;
			object myRecordsetDataSource;
			global::Motorola.MackinawCPS.CoreFeatures.FactoryOverrides.RxSSIClockRateListInner item;
			for (;;)
			{
				IL_0A:
				switch (num)
				{
				case 0:
					goto IL_7C;
				case 1:
				{
					num2 = (short)46148331;
					short num3 = num2;
					num2 = (short)703474411;
					switch ((num3 == num2) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_7C;
					default:
						goto IL_137;
					}
					break;
				}
				case 2:
					if (myRecordsetDataSource != null)
					{
						num2 = (short)1642004480;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_14F;
				}
				goto IL_1C;
				IL_7C:
				num2 = (short)1872625664;
				short num4 = num2;
				num2 = (short)1641086977;
				if (num2 != 0)
				{
				}
				((global::System.Windows.Data.CollectionView)global::System.Windows.Data.CollectionViewSource.GetDefaultView(myRecordsetDataSource)).MoveCurrentTo(item);
				this.RecNavToolbarExpanderFactoryOverridesRxSSIClockRateListTable.SyncDataSources();
				num2 = (short)695599105;
				num = (int)((global::System.IntPtr)num2);
			}
			IL_137:
			num2 = (short)1279459328;
			if (num2 != 0)
			{
			}
			IL_14F:
			this.RecNavToolbarExpanderFactoryOverridesRxSSIClockRateListTable.TableMode = false;
			return;
			IL_1C:
			item = (global::Motorola.MackinawCPS.CoreFeatures.FactoryOverrides.RxSSIClockRateListInner)((global::Infragistics.Windows.DataPresenter.CellValuePresenter)((global::AcpUI.AcpButton)e.Source).TemplatedParent).Record.DataItem;
			myRecordsetDataSource = this.RecNavToolbarExpanderFactoryOverridesRxSSIClockRateListTable.MyRecordsetDataSource;
			num2 = (short)613810178;
			num = (int)((global::System.IntPtr)num2);
			goto IL_0A;
		}

		// Token: 0x060093B0 RID: 37808 RVA: 0x008B2AE0 File Offset: 0x008B0CE0
		internal void OnExpanderFactoryOverridesRxSSIClockRateTXModeClick(object sender, global::System.Windows.RoutedEventArgs e)
		{
			switch (0)
			{
			case 0:
				goto IL_42;
			}
			short num;
			int num2;
			object myRecordsetDataSource;
			global::Motorola.MackinawCPS.CoreFeatures.FactoryOverrides.RxSSIClockRateTXModeInner item;
			for (;;)
			{
				IL_0A:
				num = (short)380502017;
				if (num != 0)
				{
				}
				switch (num2)
				{
				case 0:
					goto IL_CF;
				case 1:
				{
					num = (short)736487182;
					short num3 = num;
					num = (short)71689998;
					switch ((num3 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_CF;
					default:
						goto IL_13C;
					}
					break;
				}
				case 2:
					if (myRecordsetDataSource != null)
					{
						num = (short)1590493184;
						short num4 = num;
						num = (short)217645056;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_154;
				}
				goto IL_42;
				IL_CF:
				((global::System.Windows.Data.CollectionView)global::System.Windows.Data.CollectionViewSource.GetDefaultView(myRecordsetDataSource)).MoveCurrentTo(item);
				this.RecNavToolbarExpanderFactoryOverridesRxSSIClockRateTXMode.SyncDataSources();
				num = (short)867696641;
				num2 = (int)((global::System.IntPtr)num);
			}
			IL_13C:
			num = (short)1109065728;
			if (num != 0)
			{
			}
			IL_154:
			this.RecNavToolbarExpanderFactoryOverridesRxSSIClockRateTXMode.TableMode = false;
			return;
			IL_42:
			item = (global::Motorola.MackinawCPS.CoreFeatures.FactoryOverrides.RxSSIClockRateTXModeInner)((global::Infragistics.Windows.DataPresenter.CellValuePresenter)((global::AcpUI.AcpButton)e.Source).TemplatedParent).Record.DataItem;
			myRecordsetDataSource = this.RecNavToolbarExpanderFactoryOverridesRxSSIClockRateTXMode.MyRecordsetDataSource;
			num = (short)1723858946;
			num2 = (int)((global::System.IntPtr)num);
			goto IL_0A;
		}

		// Token: 0x060093B1 RID: 37809 RVA: 0x008B2C50 File Offset: 0x008B0E50
		internal void OnExpanderFactoryOverridesSecondLOInjectionFrequencyListClick(object sender, global::System.Windows.RoutedEventArgs e)
		{
			switch (0)
			{
			case 0:
				goto IL_1C;
			}
			int num;
			short num2;
			object myRecordsetDataSource;
			global::Motorola.MackinawCPS.CoreFeatures.FactoryOverrides.SecondLOInjectionFrequencyListInner item;
			for (;;)
			{
				IL_0A:
				switch (num)
				{
				case 0:
					goto IL_CE;
				case 1:
				{
					num2 = (short)920622731;
					short num3 = num2;
					num2 = (short)1739495051;
					switch ((num3 == num2) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_CE;
					default:
						goto IL_139;
					}
					break;
				}
				case 2:
					if (myRecordsetDataSource != null)
					{
						num2 = (short)1132199936;
						short num4 = num2;
						num2 = (short)905969664;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_151;
				}
				goto IL_1C;
				IL_CE:
				((global::System.Windows.Data.CollectionView)global::System.Windows.Data.CollectionViewSource.GetDefaultView(myRecordsetDataSource)).MoveCurrentTo(item);
				this.RecNavToolbarExpanderFactoryOverridesSecondLOInjectionFrequencyList.SyncDataSources();
				num2 = (short)551419905;
				num = (int)((global::System.IntPtr)num2);
			}
			IL_139:
			num2 = (short)1383792640;
			if (num2 != 0)
			{
			}
			IL_151:
			this.RecNavToolbarExpanderFactoryOverridesSecondLOInjectionFrequencyList.TableMode = false;
			return;
			IL_1C:
			num2 = (short)1285357569;
			if (num2 != 0)
			{
			}
			item = (global::Motorola.MackinawCPS.CoreFeatures.FactoryOverrides.SecondLOInjectionFrequencyListInner)((global::Infragistics.Windows.DataPresenter.CellValuePresenter)((global::AcpUI.AcpButton)e.Source).TemplatedParent).Record.DataItem;
			myRecordsetDataSource = this.RecNavToolbarExpanderFactoryOverridesSecondLOInjectionFrequencyList.MyRecordsetDataSource;
			num2 = (short)1326186498;
			num = (int)((global::System.IntPtr)num2);
			goto IL_0A;
		}

		// Token: 0x060093B2 RID: 37810 RVA: 0x008B2DBC File Offset: 0x008B0FBC
		internal void OnExpanderFactoryOverridesRxFrequencyListClick(object sender, global::System.Windows.RoutedEventArgs e)
		{
			switch (0)
			{
			case 0:
				goto IL_1C;
			}
			int num;
			short num2;
			object myRecordsetDataSource;
			global::Motorola.MackinawCPS.CoreFeatures.FactoryOverrides.RxFrequencyListInner item;
			for (;;)
			{
				IL_0A:
				switch (num)
				{
				case 0:
					goto IL_7C;
				case 1:
				{
					num2 = (short)577399829;
					short num3 = num2;
					num2 = (short)440232981;
					switch ((num3 == num2) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_7C;
					default:
						goto IL_112;
					}
					break;
				}
				case 2:
					if (myRecordsetDataSource != null)
					{
						num2 = (short)780795904;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_150;
				}
				goto IL_1C;
				IL_7C:
				num2 = (short)257556480;
				short num4 = num2;
				((global::System.Windows.Data.CollectionView)global::System.Windows.Data.CollectionViewSource.GetDefaultView(myRecordsetDataSource)).MoveCurrentTo(item);
				this.RecNavToolbarExpanderFactoryOverridesRxFrequencyList.SyncDataSources();
				num2 = (short)1997930497;
				num = (int)((global::System.IntPtr)num2);
			}
			IL_112:
			num2 = (short)1563688960;
			if (num2 != 0)
			{
			}
			num2 = (short)1926758401;
			if (num2 != 0)
			{
			}
			IL_150:
			this.RecNavToolbarExpanderFactoryOverridesRxFrequencyList.TableMode = false;
			return;
			IL_1C:
			item = (global::Motorola.MackinawCPS.CoreFeatures.FactoryOverrides.RxFrequencyListInner)((global::Infragistics.Windows.DataPresenter.CellValuePresenter)((global::AcpUI.AcpButton)e.Source).TemplatedParent).Record.DataItem;
			myRecordsetDataSource = this.RecNavToolbarExpanderFactoryOverridesRxFrequencyList.MyRecordsetDataSource;
			num2 = (short)1301020674;
			num = (int)((global::System.IntPtr)num2);
			goto IL_0A;
		}

		// Token: 0x060093B3 RID: 37811 RVA: 0x008B2F28 File Offset: 0x008B1128
		[global::System.CodeDom.Compiler.GeneratedCode("PresentationBuildTasks", "5.0.10.0")]
		[global::System.Diagnostics.DebuggerNonUserCode]
		public void InitializeComponent()
		{
			int a_ = 8;
			short num = (short)1813403629;
			short num2 = num;
			num = (short)768366573;
			switch ((num2 == num) ? 1 : 0)
			{
			case 0:
			case 2:
				break;
			default:
				num = (short)644612096;
				if (num != 0)
				{
				}
				if (!this.b)
				{
					num = (short)1896742913;
					if (num != 0)
					{
					}
					this.b = true;
					global::System.Uri resourceLocator = new global::System.Uri(global::AllFeatures.CodeplugGuid.b("諊ꇌꏎ韐뛒듔ꏖ곘꧚룜곞\udae0胢諤諦駨蓪菬諮鿰蟲\udaf4釶飸飺觼郾猀稂\u2004㔆㤈搊笌樎挐愒簔猖簘栚㈜礞䀠䀢儤䠦嬨刪䈬央吰䄲䜴帶崸帺丼ᄾ㥀≂⡄⭆", a_), global::System.UriKind.Relative);
					global::System.Windows.Application.LoadComponent(this, resourceLocator);
					return;
				}
				break;
			}
			num = (short)1300430848;
			short num3 = num;
		}

		// Token: 0x060093B4 RID: 37812 RVA: 0x008B3008 File Offset: 0x008B1208
		[global::System.CodeDom.Compiler.GeneratedCode("PresentationBuildTasks", "5.0.10.0")]
		[global::System.Diagnostics.DebuggerNonUserCode]
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		void global::System.Windows.Markup.IComponentConnector.Connect(int connectionId, object target)
		{
			short num = (short)192741376;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				switch (num2)
				{
				case 0:
					switch (0)
					{
					case 0:
						goto IL_32;
					}
					continue;
				case 1:
					num = (short)1930493954;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 2:
					goto IL_967;
				}
				IL_32:
				switch (connectionId)
				{
				case 1:
					goto IL_447;
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
					goto IL_FA2;
				case 14:
					goto IL_96C;
				case 15:
					goto IL_630;
				case 16:
					goto IL_590;
				case 17:
					goto IL_8AC;
				case 18:
					goto IL_E0A;
				case 19:
					goto IL_F4A;
				case 20:
					goto IL_B08;
				case 21:
					goto IL_BE9;
				case 22:
					goto IL_E5F;
				case 23:
					goto IL_B84;
				case 24:
					goto IL_6B6;
				case 25:
					goto IL_C0D;
				case 26:
					goto IL_892;
				case 27:
					goto IL_DB5;
				case 28:
					goto IL_E2E;
				case 29:
					goto IL_EA7;
				case 30:
					goto IL_8D0;
				case 31:
					goto IL_89F;
				case 32:
					goto IL_7C5;
				case 33:
					goto IL_336;
				case 34:
					goto IL_C1A;
				case 35:
					goto IL_685;
				case 36:
					goto IL_623;
				case 37:
					goto IL_49C;
				case 38:
					goto IL_9FA;
				case 39:
					goto IL_6C3;
				case 40:
					goto IL_DA8;
				case 41:
					goto IL_763;
				case 42:
					goto IL_478;
				case 43:
					goto IL_E52;
				case 44:
					goto IL_CC0;
				case 45:
					goto IL_31C;
				case 46:
					goto IL_C7F;
				case 47:
					goto IL_52B;
				case 48:
					goto IL_6F4;
				case 49:
					goto IL_4A9;
				case 50:
					goto IL_3E5;
				case 51:
					goto IL_885;
				case 52:
					goto IL_576;
				case 53:
					goto IL_569;
				case 54:
					goto IL_678;
				case 55:
					goto IL_EF5;
				case 56:
					goto IL_B2C;
				case 57:
					goto IL_D39;
				case 58:
					goto IL_55C;
				case 59:
					goto IL_A6F;
				case 60:
					goto IL_F95;
				case 61:
					goto IL_A2E;
				case 62:
					goto IL_51E;
				case 63:
					goto IL_CB3;
				case 64:
					goto IL_B9E;
				case 65:
					goto IL_5D8;
				case 66:
					goto IL_E83;
				case 67:
					goto IL_928;
				case 68:
					goto IL_794;
				case 69:
					goto IL_9E0;
				case 70:
					goto IL_5F2;
				case 71:
					goto IL_8DD;
				case 72:
					goto IL_A7C;
				case 73:
					goto IL_BC2;
				case 74:
					goto IL_504;
				case 75:
					goto IL_4D0;
				case 76:
					goto IL_810;
				case 77:
					goto IL_D46;
				case 78:
					goto IL_B77;
				case 79:
					goto IL_851;
				case 80:
					goto IL_803;
				case 81:
					goto IL_81D;
				case 82:
					goto IL_9AA;
				case 83:
					goto IL_43A;
				case 84:
					goto IL_ECE;
				case 85:
					goto IL_DD9;
				case 86:
					goto IL_986;
				case 87:
					goto IL_844;
				case 88:
					goto IL_5B4;
				case 89:
					goto IL_BDC;
				case 90:
					goto IL_9ED;
				case 91:
					goto IL_C8C;
				case 92:
					goto IL_D84;
				case 93:
					goto IL_583;
				case 94:
					goto IL_B53;
				case 95:
					goto IL_935;
				case 96:
					goto IL_C65;
				case 97:
					goto IL_A55;
				case 98:
					goto IL_82A;
				case 99:
					goto IL_7A1;
				case 100:
					goto IL_F7B;
				case 101:
					goto IL_EE8;
				case 102:
					goto IL_878;
				case 103:
					goto IL_30F;
				case 104:
					goto IL_7F6;
				case 105:
					goto IL_979;
				case 106:
					goto IL_38B;
				case 107:
					goto IL_85E;
				case 108:
					goto IL_770;
				case 109:
					goto IL_EDB;
				case 110:
					goto IL_6D0;
				case 111:
					goto IL_AD4;
				case 112:
					goto IL_F88;
				case 113:
					goto IL_AAD;
				case 114:
					goto IL_C41;
				case 115:
					goto IL_511;
				case 116:
					goto IL_904;
				case 117:
					goto IL_A14;
				case 118:
					goto IL_A21;
				case 119:
					goto IL_B39;
				case 120:
					goto IL_8F7;
				case 121:
					goto IL_35A;
				case 122:
					goto IL_8EA;
				case 123:
					goto IL_AE1;
				case 124:
					goto IL_302;
				case 125:
					goto IL_AC7;
				case 126:
					goto IL_C27;
				case 127:
					goto IL_A48;
				case 128:
					goto IL_AA0;
				case 129:
					goto IL_B91;
				case 130:
					goto IL_7D2;
				case 131:
					goto IL_5E5;
				case 132:
					goto IL_725;
				case 133:
					goto IL_942;
				case 134:
					goto IL_AEE;
				case 135:
					goto IL_A62;
				case 136:
					goto IL_692;
				case 137:
					goto IL_86B;
				case 138:
					goto IL_CE4;
				case 139:
					goto IL_4C3;
				case 140:
					goto IL_D77;
				case 141:
					goto IL_F6E;
				case 142:
					goto IL_329;
				case 143:
					goto IL_538;
				case 144:
					goto IL_EB4;
				case 145:
					goto IL_718;
				case 146:
					goto IL_749;
				case 147:
					goto IL_A07;
				case 148:
					goto IL_A3B;
				case 149:
					goto IL_616;
				case 150:
					goto IL_756;
				case 151:
					goto IL_409;
				case 152:
					goto IL_EC1;
				case 153:
					goto IL_DE6;
				case 154:
					goto IL_C34;
				case 155:
					goto IL_4B6;
				case 156:
					goto IL_ABA;
				case 157:
					goto IL_37E;
				case 158:
					goto IL_654;
				case 159:
					goto IL_837;
				case 160:
					goto IL_C99;
				case 161:
					goto IL_AFB;
				case 162:
					goto IL_D6A;
				case 163:
					goto IL_C72;
				case 164:
					goto IL_D08;
				case 165:
					goto IL_B46;
				case 166:
					goto IL_D15;
				case 167:
					goto IL_42D;
				case 168:
					goto IL_F26;
				case 169:
					goto IL_CA6;
				case 170:
					goto IL_F19;
				case 171:
					goto IL_BCF;
				default:
					num = (short)1737621505;
					num2 = (int)((global::System.IntPtr)num);
					break;
				}
			}
			IL_302:
			this.ExpanderFactoryOverridesRxSSIClockRateTXModeTableView = (global::AcpUI.AcpGroupBox)target;
			return;
			IL_30F:
			this.ExpanderFactoryOverridesRxSSIClockRateListTable = (global::AcpUI.AcpXamDataPresenter)target;
			return;
			IL_31C:
			this.RTDBtnFctOrdsRxSynthesizerReferenceDividerListRxFreqMHz_A9017 = (global::AcpUI.AcpRtdButton)target;
			return;
			IL_329:
			this.ExpanderFactoryOverridesSecondLOInjectionFrequency = (global::AcpUI.AcpExpander)target;
			return;
			IL_336:
			this.RecNavToolbarExpanderFactoryOverridesRxSynthesizerReferenceDividerListTable = (global::AcpUI.AcpRecNavToolbar)target;
			this.RecNavToolbarExpanderFactoryOverridesRxSynthesizerReferenceDividerListTable.ModeClick += this.OnModeClick;
			return;
			IL_35A:
			this.RecNavToolbarExpanderFactoryOverridesRxSSIClockRateTXMode = (global::AcpUI.AcpRecNavToolbar)target;
			this.RecNavToolbarExpanderFactoryOverridesRxSSIClockRateTXMode.ModeClick += this.OnModeClick;
			return;
			IL_37E:
			this.ExpanderFactoryOverridesRxFrequency = (global::AcpUI.AcpExpander)target;
			return;
			IL_38B:
			num = (short)1655261759;
			short num3 = num;
			num = (short)573852223;
			switch ((num3 == num) ? 1 : 0)
			{
			case 0:
			case 2:
				IL_52B:
				this.FctOrdsRxSynthesizerReferenceDividerListRxFreqMHz_A9017Comp = (global::AcpUI.AcpLabel)target;
				return;
			default:
				num = (short)1490092032;
				if (num != 0)
				{
				}
				this.ExpanderFactoryOverridesRxSSIClockRateListTableSRecView = (global::AcpUI.AcpGroupBox)target;
				return;
			}
			IL_3E5:
			this.LblFctOrdsRxSynthesizerReferenceDividerListRxRefDivMHz_A8925 = (global::AcpUI.AcpLabel)target;
			this.LblFctOrdsRxSynthesizerReferenceDividerListRxRefDivMHz_A8925.MouseDoubleClick += new global::System.Windows.Input.MouseButtonEventHandler(this.OnFieldNameDoubleClick);
			return;
			IL_409:
			this.FctOrdsSecondLOInjectionFrequencySecondLOInjectionFrequency_A9062 = (global::AcpUI.AcpTextBox)target;
			this.FctOrdsSecondLOInjectionFrequencySecondLOInjectionFrequency_A9062.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_42D:
			this.CVBtnFctOrdsRxFrequencyListRxFrequency = (global::AcpUI.AcpCustomViewCheckBox)target;
			return;
			IL_43A:
			this.FctOrdsTxSSIClockRateListTxSSIClockRateMHz_A36578_Col = (global::Infragistics.Windows.DataPresenter.UnboundField)target;
			return;
			IL_447:
			((global::Motorola.MackinawCPS.CoreFeatures.FactoryOverrides.PageFactoryOverrides)target).Loaded += this.OnLoaded;
			((global::Motorola.MackinawCPS.CoreFeatures.FactoryOverrides.PageFactoryOverrides)target).Unloaded += this.OnUnloaded;
			return;
			IL_478:
			this.FctOrdsRxSynthesizerReferenceDividerListRxFreqMHz_A9017 = (global::AcpUI.AcpTextBox)target;
			this.FctOrdsRxSynthesizerReferenceDividerListRxFreqMHz_A9017.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_49C:
			this.ExpanderFactoryOverridesRxSynthesizerReferenceDividerListTable = (global::AcpUI.AcpXamDataPresenter)target;
			return;
			IL_4A9:
			this.CVBtnFctOrdsRxSynthesizerReferenceDividerListRxRefDivMHz_A8925 = (global::AcpUI.AcpCustomViewCheckBox)target;
			return;
			IL_4B6:
			this.CpyBtnFctOrdsSecondLOInjectionFrequencySecondLOInjectionFrequency_A9062 = (global::AcpUI.AcpCopyButton)target;
			return;
			IL_4C3:
			this.RTDBtnFctOrdsRxSSIClockRateTxModeRxSSIClockRateMHz_A42780 = (global::AcpUI.AcpRtdButton)target;
			return;
			IL_4D0:
			num = (short)1134886913;
			if (num != 0)
			{
			}
			this.FctOrdsRxSynthesizerReferenceDividerListTxRefDivMHz_A8924Comp = (global::AcpUI.AcpLabel)target;
			return;
			IL_504:
			this.CpyBtnFctOrdsRxSynthesizerReferenceDividerListTxRefDivMHz_A8924 = (global::AcpUI.AcpCopyButton)target;
			return;
			IL_511:
			this.CVBtnFctOrdsRxSSIClockRateListRxSSIClockRateMHz_A42469 = (global::AcpUI.AcpCustomViewCheckBox)target;
			return;
			IL_51E:
			this.ExpanderFactoryOverridesTxSynthesizerReferenceDividerListTableSRecView = (global::AcpUI.AcpGroupBox)target;
			return;
			IL_538:
			this.RecNavToolbarExpanderFactoryOverridesSecondLOInjectionFrequencyList = (global::AcpUI.AcpRecNavToolbar)target;
			this.RecNavToolbarExpanderFactoryOverridesSecondLOInjectionFrequencyList.ModeClick += this.OnModeClick;
			return;
			IL_55C:
			this.ExpanderFactoryOverridesTxSynthesizerReferenceDividerListTableTableView = (global::AcpUI.AcpGroupBox)target;
			return;
			IL_569:
			this.FctOrdsRxSynthesizerReferenceDividerListRxRefDivMHz_A8925Comp = (global::AcpUI.AcpLabel)target;
			return;
			IL_576:
			this.CpyBtnFctOrdsRxSynthesizerReferenceDividerListRxRefDivMHz_A8925 = (global::AcpUI.AcpCopyButton)target;
			return;
			IL_583:
			this.CVBtnFctOrdsTxSSIClockRateListTxSSIClockRateMHz_A36578 = (global::AcpUI.AcpCustomViewCheckBox)target;
			return;
			IL_590:
			this.HLinkRxSynthesizerReferenceDividerList = (global::System.Windows.Documents.Hyperlink)target;
			this.HLinkRxSynthesizerReferenceDividerList.Click += this.HLinkClick;
			return;
			IL_5B4:
			this.LblFctOrdsTxSSIClockRateListTxFrequencyMHz_A36577 = (global::AcpUI.AcpLabel)target;
			this.LblFctOrdsTxSSIClockRateListTxFrequencyMHz_A36577.MouseDoubleClick += new global::System.Windows.Input.MouseButtonEventHandler(this.OnFieldNameDoubleClick);
			return;
			IL_5D8:
			this.CVBtnFctOrdsTxSynthesizerReferenceDividerListTxFreqMHz_A9534 = (global::AcpUI.AcpCustomViewCheckBox)target;
			return;
			IL_5E5:
			this.CVBtnFctOrdsRxSSIClockRateListTxModeTxFrequencyMHz_A42777 = (global::AcpUI.AcpCustomViewCheckBox)target;
			return;
			IL_5F2:
			this.FctOrdsRxSynthesizerReferenceDividerListTxRefDivMHz_A8924 = (global::AcpUI.AcpComboBox)target;
			this.FctOrdsRxSynthesizerReferenceDividerListTxRefDivMHz_A8924.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_616:
			this.ExpanderFactoryOverridesSecondLOInjectionFrequencyListSRecView = (global::AcpUI.AcpGroupBox)target;
			return;
			IL_623:
			this.ExpanderFactoryOverridesRxSynthesizerReferenceDividerListTableTableView = (global::AcpUI.AcpGroupBox)target;
			return;
			IL_630:
			this.HLinkGeneral = (global::System.Windows.Documents.Hyperlink)target;
			this.HLinkGeneral.Click += this.HLinkClick;
			return;
			IL_654:
			this.RecNavToolbarExpanderFactoryOverridesRxFrequencyList = (global::AcpUI.AcpRecNavToolbar)target;
			this.RecNavToolbarExpanderFactoryOverridesRxFrequencyList.ModeClick += this.OnModeClick;
			return;
			IL_678:
			this.ExpanderFactoryOverridesTxSynthesizerReferenceDividerList = (global::AcpUI.AcpExpander)target;
			return;
			IL_685:
			this.ExpanderFactoryOverridesRxSynthesizerReferenceDividerListTableGrid = (global::System.Windows.Controls.Grid)target;
			return;
			IL_692:
			this.FctOrdsRxSSIClockRateTxModeRxSSIClockRateMHz_A42780 = (global::AcpUI.AcpComboBox)target;
			this.FctOrdsRxSSIClockRateTxModeRxSSIClockRateMHz_A42780.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_6B6:
			this.ExpanderFactoryOverridesGeneral = (global::AcpUI.AcpExpander)target;
			return;
			IL_6C3:
			this.FctOrdsRxSynthesizerReferenceDividerListRxRefDivMHz_A8925_Col = (global::Infragistics.Windows.DataPresenter.UnboundField)target;
			return;
			IL_6D0:
			this.LblFctOrdsRxSSIClockRateListRxFrequencyMHz_A42468 = (global::AcpUI.AcpLabel)target;
			this.LblFctOrdsRxSSIClockRateListRxFrequencyMHz_A42468.MouseDoubleClick += new global::System.Windows.Input.MouseButtonEventHandler(this.OnFieldNameDoubleClick);
			return;
			IL_6F4:
			this.FctOrdsRxSynthesizerReferenceDividerListRxRefDivMHz_A8925 = (global::AcpUI.AcpComboBox)target;
			this.FctOrdsRxSynthesizerReferenceDividerListRxRefDivMHz_A8925.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_718:
			this.ExpanderFactoryOverridesSecondLOInjectionFrequencyListGrid = (global::System.Windows.Controls.Grid)target;
			return;
			IL_725:
			this.LblFctOrdsRxSSIClockRateListTxModeTxFrequencyMHz_A42777 = (global::AcpUI.AcpLabel)target;
			this.LblFctOrdsRxSSIClockRateListTxModeTxFrequencyMHz_A42777.MouseDoubleClick += new global::System.Windows.Input.MouseButtonEventHandler(this.OnFieldNameDoubleClick);
			return;
			IL_749:
			this.ExpanderFactoryOverridesSecondLOInjectionFrequencyListTableView = (global::AcpUI.AcpGroupBox)target;
			return;
			IL_756:
			this.gridExpanderFactoryOverridesSecondLOInjectionFrequencyListSRecView = (global::System.Windows.Controls.Grid)target;
			return;
			IL_763:
			this.gridExpanderFactoryOverridesRxSynthesizerReferenceDividerListTableSRecView = (global::System.Windows.Controls.Grid)target;
			return;
			IL_770:
			this.FctOrdsRxSSIClockRateListRxFrequencyMHz_A42468 = (global::AcpUI.AcpTextBox)target;
			this.FctOrdsRxSSIClockRateListRxFrequencyMHz_A42468.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_794:
			this.CpyBtnFctOrdsTxSynthesizerReferenceDividerListTxFreqMHz_A9534 = (global::AcpUI.AcpCopyButton)target;
			return;
			IL_7A1:
			this.RecNavToolbarExpanderFactoryOverridesRxSSIClockRateListTable = (global::AcpUI.AcpRecNavToolbar)target;
			this.RecNavToolbarExpanderFactoryOverridesRxSSIClockRateListTable.ModeClick += this.OnModeClick;
			return;
			IL_7C5:
			this.ExpanderFactoryOverridesRxSynthesizerReferenceDividerList = (global::AcpUI.AcpExpander)target;
			return;
			IL_7D2:
			this.FctOrdsRxSSIClockRateListTxModeTxFrequencyMHz_A42777 = (global::AcpUI.AcpTextBox)target;
			this.FctOrdsRxSSIClockRateListTxModeTxFrequencyMHz_A42777.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_7F6:
			this.FctOrdsRxSSIClockRateListRxFrequencyMHz_A42468_Col = (global::Infragistics.Windows.DataPresenter.UnboundField)target;
			return;
			IL_803:
			this.ExpanderFactoryOverridesTxSSIClockRateListTableTableView = (global::AcpUI.AcpGroupBox)target;
			return;
			IL_810:
			this.ExpanderFactoryOverridesTxSSIClockRateList = (global::AcpUI.AcpExpander)target;
			return;
			IL_81D:
			this.ExpanderFactoryOverridesTxSSIClockRateListTable = (global::AcpUI.AcpXamDataPresenter)target;
			return;
			IL_82A:
			this.ExpanderFactoryOverridesRxSSIClockRateList = (global::AcpUI.AcpExpander)target;
			return;
			IL_837:
			this.ExpanderFactoryOverridesRxFrequencyGrid = (global::System.Windows.Controls.Grid)target;
			return;
			IL_844:
			this.CVBtnFctOrdsTxSSIClockRateListTxFrequencyMHz_A36577 = (global::AcpUI.AcpCustomViewCheckBox)target;
			return;
			IL_851:
			this.ExpanderFactoryOverridesTxSSIClockRateListTableGrid = (global::System.Windows.Controls.Grid)target;
			return;
			IL_85E:
			this.gridExpanderFactoryOverridesRxSSIClockRateListTableSRecView = (global::System.Windows.Controls.Grid)target;
			return;
			IL_86B:
			this.CVBtnFctOrdsRxSSIClockRateTxModeRxSSIClockRateMHz_A42780 = (global::AcpUI.AcpCustomViewCheckBox)target;
			return;
			IL_878:
			this.ExpanderFactoryOverridesRxSSIClockRateListTableTableView = (global::AcpUI.AcpGroupBox)target;
			return;
			IL_885:
			this.RTDBtnFctOrdsRxSynthesizerReferenceDividerListRxRefDivMHz_A8925 = (global::AcpUI.AcpRtdButton)target;
			return;
			IL_892:
			this.CVBtnRadWideAdvancedFactoryOverrides_A8004 = (global::AcpUI.AcpCustomViewCheckBox)target;
			return;
			IL_89F:
			this.RadWideAdvancedFactoryOverrides_A8004Comp = (global::AcpUI.AcpCheckBox)target;
			return;
			IL_8AC:
			this.HLinkTxSynthesizerReferenceDividerList = (global::System.Windows.Documents.Hyperlink)target;
			this.HLinkTxSynthesizerReferenceDividerList.Click += this.HLinkClick;
			return;
			IL_8D0:
			this.CpyBtnRadWideAdvancedFactoryOverrides_A8004 = (global::AcpUI.AcpCopyButton)target;
			return;
			IL_8DD:
			this.CVBtnFctOrdsRxSynthesizerReferenceDividerListTxRefDivMHz_A8924 = (global::AcpUI.AcpCustomViewCheckBox)target;
			return;
			IL_8EA:
			this.ExpanderFactoryOverridesRxSSIRateTXModeGrid = (global::System.Windows.Controls.Grid)target;
			return;
			IL_8F7:
			this.ExpanderFactoryOverridesRxSSIRateTXMode = (global::AcpUI.AcpExpander)target;
			return;
			IL_904:
			this.LblFctOrdsRxSSIClockRateListRxSSIClockRateMHz_A42469 = (global::AcpUI.AcpLabel)target;
			this.LblFctOrdsRxSSIClockRateListRxSSIClockRateMHz_A42469.MouseDoubleClick += new global::System.Windows.Input.MouseButtonEventHandler(this.OnFieldNameDoubleClick);
			return;
			IL_928:
			this.RTDBtnFctOrdsTxSynthesizerReferenceDividerListTxFreqMHz_A9534 = (global::AcpUI.AcpRtdButton)target;
			return;
			IL_935:
			this.RTDBtnFctOrdsTxSSIClockRateListTxSSIClockRateMHz_A36578 = (global::AcpUI.AcpRtdButton)target;
			return;
			IL_942:
			this.RTDBtnFctOrdsRxSSIClockRateListTxModeTxFrequencyMHz_A42777 = (global::AcpUI.AcpRtdButton)target;
			return;
			IL_967:
			goto IL_FA2;
			IL_96C:
			this.ThemeBaseObj = (global::AcpUI.Common.AcpThemeBase)target;
			return;
			IL_979:
			this.FctOrdsRxSSIClockRateListRxSSIClockRateMHz_A42469_Col = (global::Infragistics.Windows.DataPresenter.UnboundField)target;
			return;
			IL_986:
			this.FctOrdsTxSSIClockRateListTxFrequencyMHz_A36577 = (global::AcpUI.AcpTextBox)target;
			this.FctOrdsTxSSIClockRateListTxFrequencyMHz_A36577.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_9AA:
			num = (short)555286528;
			short num4 = num;
			this.FctOrdsTxSSIClockRateListTxFrequencyMHz_A36577_Col = (global::Infragistics.Windows.DataPresenter.UnboundField)target;
			return;
			IL_9E0:
			this.FctOrdsTxSynthesizerReferenceDividerListTxFreqMHz_A9534Comp = (global::AcpUI.AcpLabel)target;
			return;
			IL_9ED:
			this.CpyBtnFctOrdsTxSSIClockRateListTxFrequencyMHz_A36577 = (global::AcpUI.AcpCopyButton)target;
			return;
			IL_9FA:
			this.FctOrdsRxSynthesizerReferenceDividerListRxFreqMHz_A9017_Col = (global::Infragistics.Windows.DataPresenter.UnboundField)target;
			return;
			IL_A07:
			this.ExpanderFactoryOverridesSecondLOInjectionFrequencyList = (global::AcpUI.AcpXamDataPresenter)target;
			return;
			IL_A14:
			this.RTDBtnFctOrdsRxSSIClockRateListRxSSIClockRateMHz_A42469 = (global::AcpUI.AcpRtdButton)target;
			return;
			IL_A21:
			this.CpyBtnFctOrdsRxSSIClockRateListRxSSIClockRateMHz_A42469 = (global::AcpUI.AcpCopyButton)target;
			return;
			IL_A2E:
			this.FctOrdsRxSynthesizerReferenceDividerListTxRefDivMHz_A8924_Col = (global::Infragistics.Windows.DataPresenter.UnboundField)target;
			return;
			IL_A3B:
			this.FctOrdsSecondLOInjectionFrequencySecondLOInjectionFrequency_A9062_Col = (global::Infragistics.Windows.DataPresenter.UnboundField)target;
			return;
			IL_A48:
			this.FctOrdsRxSSIClockRateTxModeRxSSIClockRateMHz_A42780_Col = (global::Infragistics.Windows.DataPresenter.UnboundField)target;
			return;
			IL_A55:
			this.FctOrdsTxSSIClockRateListTxSSIClockRateMHz_A36578Comp = (global::AcpUI.AcpLabel)target;
			return;
			IL_A62:
			this.FctOrdsRxSSIClockRateListTxModeTxFrequencyMHz_A42777Comp = (global::AcpUI.AcpLabel)target;
			return;
			IL_A6F:
			this.ExpanderFactoryOverridesTxSynthesizerReferenceDividerListTable = (global::AcpUI.AcpXamDataPresenter)target;
			return;
			IL_A7C:
			this.LblFctOrdsRxSynthesizerReferenceDividerListTxRefDivMHz_A8924 = (global::AcpUI.AcpLabel)target;
			this.LblFctOrdsRxSynthesizerReferenceDividerListTxRefDivMHz_A8924.MouseDoubleClick += new global::System.Windows.Input.MouseButtonEventHandler(this.OnFieldNameDoubleClick);
			return;
			IL_AA0:
			this.ExpanderFactoryOverridesRxSSIClockRateTXModeSRecView = (global::AcpUI.AcpGroupBox)target;
			return;
			IL_AAD:
			this.FctOrdsRxSSIClockRateListRxFrequencyMHz_A42468Comp = (global::AcpUI.AcpLabel)target;
			return;
			IL_ABA:
			this.FctOrdsSecondLOInjectionFrequencySecondLOInjectionFrequency_A9062Comp = (global::AcpUI.AcpLabel)target;
			return;
			IL_AC7:
			this.ExpanderFactoryOverridesRxSSIClockRateTXMode = (global::AcpUI.AcpXamDataPresenter)target;
			return;
			IL_AD4:
			this.RTDBtnFctOrdsRxSSIClockRateListRxFrequencyMHz_A42468 = (global::AcpUI.AcpRtdButton)target;
			return;
			IL_AE1:
			this.ExpanderFactoryOverridesRxSSIClockRateTXModeGrid = (global::System.Windows.Controls.Grid)target;
			return;
			IL_AEE:
			this.CpyBtnFctOrdsRxSSIClockRateListTxModeTxFrequencyMHz_A42777 = (global::AcpUI.AcpCopyButton)target;
			return;
			IL_AFB:
			this.ExpanderFactoryOverridesRxFrequencyListTableView = (global::AcpUI.AcpGroupBox)target;
			return;
			IL_B08:
			this.HLinkRxSSIRateTXMode = (global::System.Windows.Documents.Hyperlink)target;
			this.HLinkRxSSIRateTXMode.Click += this.HLinkClick;
			return;
			IL_B2C:
			this.ExpanderFactoryOverridesTxSynthesizerReferenceDividerListGrid = (global::System.Windows.Controls.Grid)target;
			return;
			IL_B39:
			this.FctOrdsRxSSIClockRateListRxSSIClockRateMHz_A42469Comp = (global::AcpUI.AcpLabel)target;
			return;
			IL_B46:
			this.gridExpanderFactoryOverridesRxFrequencyListSRecView = (global::System.Windows.Controls.Grid)target;
			return;
			IL_B53:
			this.LblFctOrdsTxSSIClockRateListTxSSIClockRateMHz_A36578 = (global::AcpUI.AcpLabel)target;
			this.LblFctOrdsTxSSIClockRateListTxSSIClockRateMHz_A36578.MouseDoubleClick += new global::System.Windows.Input.MouseButtonEventHandler(this.OnFieldNameDoubleClick);
			return;
			IL_B77:
			this.ExpanderFactoryOverridesTxSSIClockRateListGrid = (global::System.Windows.Controls.Grid)target;
			return;
			IL_B84:
			this.MyStackPanel = (global::System.Windows.Controls.StackPanel)target;
			return;
			IL_B91:
			this.gridExpanderFactoryOverridesRxSSIClockRateTXModeSRecView = (global::System.Windows.Controls.Grid)target;
			return;
			IL_B9E:
			this.FctOrdsTxSynthesizerReferenceDividerListTxFreqMHz_A9534 = (global::AcpUI.AcpTextBox)target;
			this.FctOrdsTxSynthesizerReferenceDividerListTxFreqMHz_A9534.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_BC2:
			this.RTDBtnFctOrdsRxSynthesizerReferenceDividerListTxRefDivMHz_A8924 = (global::AcpUI.AcpRtdButton)target;
			return;
			IL_BCF:
			this.FctOrdsRxFrequencyListRxFrequencyComp = (global::AcpUI.AcpLabel)target;
			return;
			IL_BDC:
			this.RTDBtnFctOrdsTxSSIClockRateListTxFrequencyMHz_A36577 = (global::AcpUI.AcpRtdButton)target;
			return;
			IL_BE9:
			this.HLinkSecondLOInjectionFrequency = (global::System.Windows.Documents.Hyperlink)target;
			this.HLinkSecondLOInjectionFrequency.Click += this.HLinkClick;
			return;
			IL_C0D:
			this.GrpBoxExpanderFactoryOverridesGeneralPseudo0 = (global::AcpUI.AcpGroupBox)target;
			return;
			IL_C1A:
			this.ExpanderFactoryOverridesRxSynthesizerReferenceDividerListGrid = (global::System.Windows.Controls.Grid)target;
			return;
			IL_C27:
			this.FctOrdsRxSSIClockRateListTxModeTxFrequencyMHz_A42777_Col = (global::Infragistics.Windows.DataPresenter.UnboundField)target;
			return;
			IL_C34:
			this.RTDBtnFctOrdsSecondLOInjectionFrequencySecondLOInjectionFrequency_A9062 = (global::AcpUI.AcpRtdButton)target;
			return;
			IL_C41:
			this.FctOrdsRxSSIClockRateListRxSSIClockRateMHz_A42469 = (global::AcpUI.AcpComboBox)target;
			this.FctOrdsRxSSIClockRateListRxSSIClockRateMHz_A42469.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_C65:
			this.CpyBtnFctOrdsTxSSIClockRateListTxSSIClockRateMHz_A36578 = (global::AcpUI.AcpCopyButton)target;
			return;
			IL_C72:
			this.FctOrdsRxFrequencyListRxFrequency_Col = (global::Infragistics.Windows.DataPresenter.UnboundField)target;
			return;
			IL_C7F:
			this.CpyBtnFctOrdsRxSynthesizerReferenceDividerListRxFreqMHz_A9017 = (global::AcpUI.AcpCopyButton)target;
			return;
			IL_C8C:
			this.FctOrdsTxSSIClockRateListTxFrequencyMHz_A36577Comp = (global::AcpUI.AcpLabel)target;
			return;
			IL_C99:
			this.ExpanderFactoryOverridesRxFrequencyListGrid = (global::System.Windows.Controls.Grid)target;
			return;
			IL_CA6:
			this.RTDBtnFctOrdsRxFrequencyListRxFrequency = (global::AcpUI.AcpRtdButton)target;
			return;
			IL_CB3:
			this.gridExpanderFactoryOverridesTxSynthesizerReferenceDividerListTableSRecView = (global::System.Windows.Controls.Grid)target;
			return;
			IL_CC0:
			this.LblFctOrdsRxSynthesizerReferenceDividerListRxFreqMHz_A9017 = (global::AcpUI.AcpLabel)target;
			this.LblFctOrdsRxSynthesizerReferenceDividerListRxFreqMHz_A9017.MouseDoubleClick += new global::System.Windows.Input.MouseButtonEventHandler(this.OnFieldNameDoubleClick);
			return;
			IL_CE4:
			this.LblFctOrdsRxSSIClockRateTxModeRxSSIClockRateMHz_A42780 = (global::AcpUI.AcpLabel)target;
			this.LblFctOrdsRxSSIClockRateTxModeRxSSIClockRateMHz_A42780.MouseDoubleClick += new global::System.Windows.Input.MouseButtonEventHandler(this.OnFieldNameDoubleClick);
			return;
			IL_D08:
			this.ExpanderFactoryOverridesRxFrequencyListSRecView = (global::AcpUI.AcpGroupBox)target;
			return;
			IL_D15:
			this.FctOrdsRxFrequencyListRxFrequency = (global::AcpUI.AcpTextBox)target;
			this.FctOrdsRxFrequencyListRxFrequency.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_D39:
			this.ExpanderFactoryOverridesTxSynthesizerReferenceDividerListTableGrid = (global::System.Windows.Controls.Grid)target;
			return;
			IL_D46:
			this.RecNavToolbarExpanderFactoryOverridesTxSSIClockRateListTable = (global::AcpUI.AcpRecNavToolbar)target;
			this.RecNavToolbarExpanderFactoryOverridesTxSSIClockRateListTable.ModeClick += this.OnModeClick;
			return;
			IL_D6A:
			this.ExpanderFactoryOverridesRxFrequencyList = (global::AcpUI.AcpXamDataPresenter)target;
			return;
			IL_D77:
			this.CpyBtnFctOrdsRxSSIClockRateTxModeRxSSIClockRateMHz_A42780 = (global::AcpUI.AcpCopyButton)target;
			return;
			IL_D84:
			this.FctOrdsTxSSIClockRateListTxSSIClockRateMHz_A36578 = (global::AcpUI.AcpComboBox)target;
			this.FctOrdsTxSSIClockRateListTxSSIClockRateMHz_A36578.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_DA8:
			this.ExpanderFactoryOverridesRxSynthesizerReferenceDividerListTableSRecView = (global::AcpUI.AcpGroupBox)target;
			return;
			IL_DB5:
			this.LblRadWideAdvancedFactoryOverrides_A8004 = (global::AcpUI.AcpLabel)target;
			this.LblRadWideAdvancedFactoryOverrides_A8004.MouseDoubleClick += new global::System.Windows.Input.MouseButtonEventHandler(this.OnFieldNameDoubleClick);
			return;
			IL_DD9:
			this.gridExpanderFactoryOverridesTxSSIClockRateListTableSRecView = (global::System.Windows.Controls.Grid)target;
			return;
			IL_DE6:
			this.LblFctOrdsSecondLOInjectionFrequencySecondLOInjectionFrequency_A9062 = (global::AcpUI.AcpLabel)target;
			this.LblFctOrdsSecondLOInjectionFrequencySecondLOInjectionFrequency_A9062.MouseDoubleClick += new global::System.Windows.Input.MouseButtonEventHandler(this.OnFieldNameDoubleClick);
			return;
			IL_E0A:
			this.HLinkTxSSIClockRateList = (global::System.Windows.Documents.Hyperlink)target;
			this.HLinkTxSSIClockRateList.Click += this.HLinkClick;
			return;
			IL_E2E:
			this.RadWideAdvancedFactoryOverrides_A8004 = (global::AcpUI.AcpCheckBox)target;
			this.RadWideAdvancedFactoryOverrides_A8004.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_E52:
			this.CVBtnFctOrdsRxSynthesizerReferenceDividerListRxFreqMHz_A9017 = (global::AcpUI.AcpCustomViewCheckBox)target;
			return;
			IL_E5F:
			this.HLinkRxFrequency = (global::System.Windows.Documents.Hyperlink)target;
			this.HLinkRxFrequency.Click += this.HLinkClick;
			return;
			IL_E83:
			this.LblFctOrdsTxSynthesizerReferenceDividerListTxFreqMHz_A9534 = (global::AcpUI.AcpLabel)target;
			this.LblFctOrdsTxSynthesizerReferenceDividerListTxFreqMHz_A9534.MouseDoubleClick += new global::System.Windows.Input.MouseButtonEventHandler(this.OnFieldNameDoubleClick);
			return;
			IL_EA7:
			this.RTDBtnRadWideAdvancedFactoryOverrides_A8004 = (global::AcpUI.AcpRtdButton)target;
			return;
			IL_EB4:
			this.ExpanderFactoryOverridesSecondLOInjectionFrequencyGrid = (global::System.Windows.Controls.Grid)target;
			return;
			IL_EC1:
			this.CVBtnFctOrdsSecondLOInjectionFrequencySecondLOInjectionFrequency_A9062 = (global::AcpUI.AcpCustomViewCheckBox)target;
			return;
			IL_ECE:
			this.ExpanderFactoryOverridesTxSSIClockRateListTableSRecView = (global::AcpUI.AcpGroupBox)target;
			return;
			IL_EDB:
			this.CVBtnFctOrdsRxSSIClockRateListRxFrequencyMHz_A42468 = (global::AcpUI.AcpCustomViewCheckBox)target;
			return;
			IL_EE8:
			this.ExpanderFactoryOverridesRxSSIClockRateListTableGrid = (global::System.Windows.Controls.Grid)target;
			return;
			IL_EF5:
			this.RecNavToolbarExpanderFactoryOverridesTxSynthesizerReferenceDividerListTable = (global::AcpUI.AcpRecNavToolbar)target;
			this.RecNavToolbarExpanderFactoryOverridesTxSynthesizerReferenceDividerListTable.ModeClick += this.OnModeClick;
			return;
			IL_F19:
			this.CpyBtnFctOrdsRxFrequencyListRxFrequency = (global::AcpUI.AcpCopyButton)target;
			return;
			IL_F26:
			this.LblFctOrdsRxFrequencyListRxFrequency = (global::AcpUI.AcpLabel)target;
			this.LblFctOrdsRxFrequencyListRxFrequency.MouseDoubleClick += new global::System.Windows.Input.MouseButtonEventHandler(this.OnFieldNameDoubleClick);
			return;
			IL_F4A:
			this.HLinkRxSSIClockRateList = (global::System.Windows.Documents.Hyperlink)target;
			this.HLinkRxSSIClockRateList.Click += this.HLinkClick;
			return;
			IL_F6E:
			this.FctOrdsRxSSIClockRateTxModeRxSSIClockRateMHz_A42780Comp = (global::AcpUI.AcpLabel)target;
			return;
			IL_F7B:
			this.ExpanderFactoryOverridesRxSSIClockRateListGrid = (global::System.Windows.Controls.Grid)target;
			return;
			IL_F88:
			this.CpyBtnFctOrdsRxSSIClockRateListRxFrequencyMHz_A42468 = (global::AcpUI.AcpCopyButton)target;
			return;
			IL_F95:
			this.FctOrdsTxSynthesizerReferenceDividerListTxFreqMHz_A9534_Col = (global::Infragistics.Windows.DataPresenter.UnboundField)target;
			return;
			IL_FA2:
			this.b = true;
		}

		// Token: 0x060093B5 RID: 37813 RVA: 0x008B3FC0 File Offset: 0x008B21C0
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		[global::System.Diagnostics.DebuggerNonUserCode]
		[global::System.CodeDom.Compiler.GeneratedCode("PresentationBuildTasks", "5.0.10.0")]
		void global::System.Windows.Markup.IStyleConnector.Connect(int connectionId, object target)
		{
			short num;
			for (;;)
			{
				num = (short)211419136;
				short num2 = num;
				switch (connectionId)
				{
				case 2:
					goto IL_13D;
				case 3:
				{
					num = (short)1124073473;
					if (num != 0)
					{
					}
					num = (short)1114130749;
					short num3 = num;
					num = (short)980633917;
					switch ((num3 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						continue;
					default:
						goto IL_F8;
					}
					break;
				}
				case 4:
					goto IL_1CE;
				case 5:
					goto IL_185;
				case 6:
					goto IL_1B6;
				case 7:
					goto IL_81;
				case 8:
					goto IL_155;
				case 9:
					goto IL_69;
				case 10:
					goto IL_19E;
				case 11:
					goto IL_125;
				case 12:
					goto IL_16D;
				case 13:
					goto IL_1E6;
				}
				break;
			}
			return;
			IL_69:
			((global::AcpUI.AcpTableComboBox)target).GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_81:
			((global::AcpUI.AcpTableComboBox)target).GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_F8:
			num = (short)1221066752;
			if (num != 0)
			{
			}
			((global::AcpUI.AcpTableComboBox)target).GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_125:
			((global::AcpUI.AcpTableComboBox)target).GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_13D:
			((global::AcpUI.AcpTableTextBox)target).GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_155:
			((global::AcpUI.AcpTableTextBox)target).GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_16D:
			((global::AcpUI.AcpTableTextBox)target).GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_185:
			((global::AcpUI.AcpTableComboBox)target).GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_19E:
			((global::AcpUI.AcpTableTextBox)target).GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_1B6:
			((global::AcpUI.AcpTableTextBox)target).GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_1CE:
			((global::AcpUI.AcpTableTextBox)target).GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_1E6:
			((global::AcpUI.AcpTableTextBox)target).GotFocus += this.OnFieldNameDoubleClick;
		}

		// Token: 0x0400493C RID: 18748
		private bool a;

		// Token: 0x0400493D RID: 18749
		internal global::AcpUI.Common.AcpThemeBase ThemeBaseObj;

		// Token: 0x0400493E RID: 18750
		internal global::System.Windows.Documents.Hyperlink HLinkGeneral;

		// Token: 0x0400493F RID: 18751
		internal global::System.Windows.Documents.Hyperlink HLinkRxSynthesizerReferenceDividerList;

		// Token: 0x04004940 RID: 18752
		internal global::System.Windows.Documents.Hyperlink HLinkTxSynthesizerReferenceDividerList;

		// Token: 0x04004941 RID: 18753
		internal global::System.Windows.Documents.Hyperlink HLinkTxSSIClockRateList;

		// Token: 0x04004942 RID: 18754
		internal global::System.Windows.Documents.Hyperlink HLinkRxSSIClockRateList;

		// Token: 0x04004943 RID: 18755
		internal global::System.Windows.Documents.Hyperlink HLinkRxSSIRateTXMode;

		// Token: 0x04004944 RID: 18756
		internal global::System.Windows.Documents.Hyperlink HLinkSecondLOInjectionFrequency;

		// Token: 0x04004945 RID: 18757
		internal global::System.Windows.Documents.Hyperlink HLinkRxFrequency;

		// Token: 0x04004946 RID: 18758
		internal global::System.Windows.Controls.StackPanel MyStackPanel;

		// Token: 0x04004947 RID: 18759
		internal global::AcpUI.AcpExpander ExpanderFactoryOverridesGeneral;

		// Token: 0x04004948 RID: 18760
		internal global::AcpUI.AcpGroupBox GrpBoxExpanderFactoryOverridesGeneralPseudo0;

		// Token: 0x04004949 RID: 18761
		internal global::AcpUI.AcpCustomViewCheckBox CVBtnRadWideAdvancedFactoryOverrides_A8004;

		// Token: 0x0400494A RID: 18762
		internal global::AcpUI.AcpLabel LblRadWideAdvancedFactoryOverrides_A8004;

		// Token: 0x0400494B RID: 18763
		internal global::AcpUI.AcpCheckBox RadWideAdvancedFactoryOverrides_A8004;

		// Token: 0x0400494C RID: 18764
		internal global::AcpUI.AcpRtdButton RTDBtnRadWideAdvancedFactoryOverrides_A8004;

		// Token: 0x0400494D RID: 18765
		internal global::AcpUI.AcpCopyButton CpyBtnRadWideAdvancedFactoryOverrides_A8004;

		// Token: 0x0400494E RID: 18766
		internal global::AcpUI.AcpCheckBox RadWideAdvancedFactoryOverrides_A8004Comp;

		// Token: 0x0400494F RID: 18767
		internal global::AcpUI.AcpExpander ExpanderFactoryOverridesRxSynthesizerReferenceDividerList;

		// Token: 0x04004950 RID: 18768
		internal global::AcpUI.AcpRecNavToolbar RecNavToolbarExpanderFactoryOverridesRxSynthesizerReferenceDividerListTable;

		// Token: 0x04004951 RID: 18769
		internal global::System.Windows.Controls.Grid ExpanderFactoryOverridesRxSynthesizerReferenceDividerListGrid;

		// Token: 0x04004952 RID: 18770
		internal global::System.Windows.Controls.Grid ExpanderFactoryOverridesRxSynthesizerReferenceDividerListTableGrid;

		// Token: 0x04004953 RID: 18771
		internal global::AcpUI.AcpGroupBox ExpanderFactoryOverridesRxSynthesizerReferenceDividerListTableTableView;

		// Token: 0x04004954 RID: 18772
		internal global::AcpUI.AcpXamDataPresenter ExpanderFactoryOverridesRxSynthesizerReferenceDividerListTable;

		// Token: 0x04004955 RID: 18773
		internal global::Infragistics.Windows.DataPresenter.UnboundField FctOrdsRxSynthesizerReferenceDividerListRxFreqMHz_A9017_Col;

		// Token: 0x04004956 RID: 18774
		internal global::Infragistics.Windows.DataPresenter.UnboundField FctOrdsRxSynthesizerReferenceDividerListRxRefDivMHz_A8925_Col;

		// Token: 0x04004957 RID: 18775
		internal global::AcpUI.AcpGroupBox ExpanderFactoryOverridesRxSynthesizerReferenceDividerListTableSRecView;

		// Token: 0x04004958 RID: 18776
		internal global::System.Windows.Controls.Grid gridExpanderFactoryOverridesRxSynthesizerReferenceDividerListTableSRecView;

		// Token: 0x04004959 RID: 18777
		internal global::AcpUI.AcpTextBox FctOrdsRxSynthesizerReferenceDividerListRxFreqMHz_A9017;

		// Token: 0x0400495A RID: 18778
		internal global::AcpUI.AcpCustomViewCheckBox CVBtnFctOrdsRxSynthesizerReferenceDividerListRxFreqMHz_A9017;

		// Token: 0x0400495B RID: 18779
		internal global::AcpUI.AcpLabel LblFctOrdsRxSynthesizerReferenceDividerListRxFreqMHz_A9017;

		// Token: 0x0400495C RID: 18780
		internal global::AcpUI.AcpRtdButton RTDBtnFctOrdsRxSynthesizerReferenceDividerListRxFreqMHz_A9017;

		// Token: 0x0400495D RID: 18781
		internal global::AcpUI.AcpCopyButton CpyBtnFctOrdsRxSynthesizerReferenceDividerListRxFreqMHz_A9017;

		// Token: 0x0400495E RID: 18782
		internal global::AcpUI.AcpLabel FctOrdsRxSynthesizerReferenceDividerListRxFreqMHz_A9017Comp;

		// Token: 0x0400495F RID: 18783
		internal global::AcpUI.AcpComboBox FctOrdsRxSynthesizerReferenceDividerListRxRefDivMHz_A8925;

		// Token: 0x04004960 RID: 18784
		internal global::AcpUI.AcpCustomViewCheckBox CVBtnFctOrdsRxSynthesizerReferenceDividerListRxRefDivMHz_A8925;

		// Token: 0x04004961 RID: 18785
		internal global::AcpUI.AcpLabel LblFctOrdsRxSynthesizerReferenceDividerListRxRefDivMHz_A8925;

		// Token: 0x04004962 RID: 18786
		internal global::AcpUI.AcpRtdButton RTDBtnFctOrdsRxSynthesizerReferenceDividerListRxRefDivMHz_A8925;

		// Token: 0x04004963 RID: 18787
		internal global::AcpUI.AcpCopyButton CpyBtnFctOrdsRxSynthesizerReferenceDividerListRxRefDivMHz_A8925;

		// Token: 0x04004964 RID: 18788
		internal global::AcpUI.AcpLabel FctOrdsRxSynthesizerReferenceDividerListRxRefDivMHz_A8925Comp;

		// Token: 0x04004965 RID: 18789
		internal global::AcpUI.AcpExpander ExpanderFactoryOverridesTxSynthesizerReferenceDividerList;

		// Token: 0x04004966 RID: 18790
		internal global::AcpUI.AcpRecNavToolbar RecNavToolbarExpanderFactoryOverridesTxSynthesizerReferenceDividerListTable;

		// Token: 0x04004967 RID: 18791
		internal global::System.Windows.Controls.Grid ExpanderFactoryOverridesTxSynthesizerReferenceDividerListGrid;

		// Token: 0x04004968 RID: 18792
		internal global::System.Windows.Controls.Grid ExpanderFactoryOverridesTxSynthesizerReferenceDividerListTableGrid;

		// Token: 0x04004969 RID: 18793
		internal global::AcpUI.AcpGroupBox ExpanderFactoryOverridesTxSynthesizerReferenceDividerListTableTableView;

		// Token: 0x0400496A RID: 18794
		internal global::AcpUI.AcpXamDataPresenter ExpanderFactoryOverridesTxSynthesizerReferenceDividerListTable;

		// Token: 0x0400496B RID: 18795
		internal global::Infragistics.Windows.DataPresenter.UnboundField FctOrdsTxSynthesizerReferenceDividerListTxFreqMHz_A9534_Col;

		// Token: 0x0400496C RID: 18796
		internal global::Infragistics.Windows.DataPresenter.UnboundField FctOrdsRxSynthesizerReferenceDividerListTxRefDivMHz_A8924_Col;

		// Token: 0x0400496D RID: 18797
		internal global::AcpUI.AcpGroupBox ExpanderFactoryOverridesTxSynthesizerReferenceDividerListTableSRecView;

		// Token: 0x0400496E RID: 18798
		internal global::System.Windows.Controls.Grid gridExpanderFactoryOverridesTxSynthesizerReferenceDividerListTableSRecView;

		// Token: 0x0400496F RID: 18799
		internal global::AcpUI.AcpTextBox FctOrdsTxSynthesizerReferenceDividerListTxFreqMHz_A9534;

		// Token: 0x04004970 RID: 18800
		internal global::AcpUI.AcpCustomViewCheckBox CVBtnFctOrdsTxSynthesizerReferenceDividerListTxFreqMHz_A9534;

		// Token: 0x04004971 RID: 18801
		internal global::AcpUI.AcpLabel LblFctOrdsTxSynthesizerReferenceDividerListTxFreqMHz_A9534;

		// Token: 0x04004972 RID: 18802
		internal global::AcpUI.AcpRtdButton RTDBtnFctOrdsTxSynthesizerReferenceDividerListTxFreqMHz_A9534;

		// Token: 0x04004973 RID: 18803
		internal global::AcpUI.AcpCopyButton CpyBtnFctOrdsTxSynthesizerReferenceDividerListTxFreqMHz_A9534;

		// Token: 0x04004974 RID: 18804
		internal global::AcpUI.AcpLabel FctOrdsTxSynthesizerReferenceDividerListTxFreqMHz_A9534Comp;

		// Token: 0x04004975 RID: 18805
		internal global::AcpUI.AcpComboBox FctOrdsRxSynthesizerReferenceDividerListTxRefDivMHz_A8924;

		// Token: 0x04004976 RID: 18806
		internal global::AcpUI.AcpCustomViewCheckBox CVBtnFctOrdsRxSynthesizerReferenceDividerListTxRefDivMHz_A8924;

		// Token: 0x04004977 RID: 18807
		internal global::AcpUI.AcpLabel LblFctOrdsRxSynthesizerReferenceDividerListTxRefDivMHz_A8924;

		// Token: 0x04004978 RID: 18808
		internal global::AcpUI.AcpRtdButton RTDBtnFctOrdsRxSynthesizerReferenceDividerListTxRefDivMHz_A8924;

		// Token: 0x04004979 RID: 18809
		internal global::AcpUI.AcpCopyButton CpyBtnFctOrdsRxSynthesizerReferenceDividerListTxRefDivMHz_A8924;

		// Token: 0x0400497A RID: 18810
		internal global::AcpUI.AcpLabel FctOrdsRxSynthesizerReferenceDividerListTxRefDivMHz_A8924Comp;

		// Token: 0x0400497B RID: 18811
		internal global::AcpUI.AcpExpander ExpanderFactoryOverridesTxSSIClockRateList;

		// Token: 0x0400497C RID: 18812
		internal global::AcpUI.AcpRecNavToolbar RecNavToolbarExpanderFactoryOverridesTxSSIClockRateListTable;

		// Token: 0x0400497D RID: 18813
		internal global::System.Windows.Controls.Grid ExpanderFactoryOverridesTxSSIClockRateListGrid;

		// Token: 0x0400497E RID: 18814
		internal global::System.Windows.Controls.Grid ExpanderFactoryOverridesTxSSIClockRateListTableGrid;

		// Token: 0x0400497F RID: 18815
		internal global::AcpUI.AcpGroupBox ExpanderFactoryOverridesTxSSIClockRateListTableTableView;

		// Token: 0x04004980 RID: 18816
		internal global::AcpUI.AcpXamDataPresenter ExpanderFactoryOverridesTxSSIClockRateListTable;

		// Token: 0x04004981 RID: 18817
		internal global::Infragistics.Windows.DataPresenter.UnboundField FctOrdsTxSSIClockRateListTxFrequencyMHz_A36577_Col;

		// Token: 0x04004982 RID: 18818
		internal global::Infragistics.Windows.DataPresenter.UnboundField FctOrdsTxSSIClockRateListTxSSIClockRateMHz_A36578_Col;

		// Token: 0x04004983 RID: 18819
		internal global::AcpUI.AcpGroupBox ExpanderFactoryOverridesTxSSIClockRateListTableSRecView;

		// Token: 0x04004984 RID: 18820
		internal global::System.Windows.Controls.Grid gridExpanderFactoryOverridesTxSSIClockRateListTableSRecView;

		// Token: 0x04004985 RID: 18821
		internal global::AcpUI.AcpTextBox FctOrdsTxSSIClockRateListTxFrequencyMHz_A36577;

		// Token: 0x04004986 RID: 18822
		internal global::AcpUI.AcpCustomViewCheckBox CVBtnFctOrdsTxSSIClockRateListTxFrequencyMHz_A36577;

		// Token: 0x04004987 RID: 18823
		internal global::AcpUI.AcpLabel LblFctOrdsTxSSIClockRateListTxFrequencyMHz_A36577;

		// Token: 0x04004988 RID: 18824
		internal global::AcpUI.AcpRtdButton RTDBtnFctOrdsTxSSIClockRateListTxFrequencyMHz_A36577;

		// Token: 0x04004989 RID: 18825
		internal global::AcpUI.AcpCopyButton CpyBtnFctOrdsTxSSIClockRateListTxFrequencyMHz_A36577;

		// Token: 0x0400498A RID: 18826
		internal global::AcpUI.AcpLabel FctOrdsTxSSIClockRateListTxFrequencyMHz_A36577Comp;

		// Token: 0x0400498B RID: 18827
		internal global::AcpUI.AcpComboBox FctOrdsTxSSIClockRateListTxSSIClockRateMHz_A36578;

		// Token: 0x0400498C RID: 18828
		internal global::AcpUI.AcpCustomViewCheckBox CVBtnFctOrdsTxSSIClockRateListTxSSIClockRateMHz_A36578;

		// Token: 0x0400498D RID: 18829
		internal global::AcpUI.AcpLabel LblFctOrdsTxSSIClockRateListTxSSIClockRateMHz_A36578;

		// Token: 0x0400498E RID: 18830
		internal global::AcpUI.AcpRtdButton RTDBtnFctOrdsTxSSIClockRateListTxSSIClockRateMHz_A36578;

		// Token: 0x0400498F RID: 18831
		internal global::AcpUI.AcpCopyButton CpyBtnFctOrdsTxSSIClockRateListTxSSIClockRateMHz_A36578;

		// Token: 0x04004990 RID: 18832
		internal global::AcpUI.AcpLabel FctOrdsTxSSIClockRateListTxSSIClockRateMHz_A36578Comp;

		// Token: 0x04004991 RID: 18833
		internal global::AcpUI.AcpExpander ExpanderFactoryOverridesRxSSIClockRateList;

		// Token: 0x04004992 RID: 18834
		internal global::AcpUI.AcpRecNavToolbar RecNavToolbarExpanderFactoryOverridesRxSSIClockRateListTable;

		// Token: 0x04004993 RID: 18835
		internal global::System.Windows.Controls.Grid ExpanderFactoryOverridesRxSSIClockRateListGrid;

		// Token: 0x04004994 RID: 18836
		internal global::System.Windows.Controls.Grid ExpanderFactoryOverridesRxSSIClockRateListTableGrid;

		// Token: 0x04004995 RID: 18837
		internal global::AcpUI.AcpGroupBox ExpanderFactoryOverridesRxSSIClockRateListTableTableView;

		// Token: 0x04004996 RID: 18838
		internal global::AcpUI.AcpXamDataPresenter ExpanderFactoryOverridesRxSSIClockRateListTable;

		// Token: 0x04004997 RID: 18839
		internal global::Infragistics.Windows.DataPresenter.UnboundField FctOrdsRxSSIClockRateListRxFrequencyMHz_A42468_Col;

		// Token: 0x04004998 RID: 18840
		internal global::Infragistics.Windows.DataPresenter.UnboundField FctOrdsRxSSIClockRateListRxSSIClockRateMHz_A42469_Col;

		// Token: 0x04004999 RID: 18841
		internal global::AcpUI.AcpGroupBox ExpanderFactoryOverridesRxSSIClockRateListTableSRecView;

		// Token: 0x0400499A RID: 18842
		internal global::System.Windows.Controls.Grid gridExpanderFactoryOverridesRxSSIClockRateListTableSRecView;

		// Token: 0x0400499B RID: 18843
		internal global::AcpUI.AcpTextBox FctOrdsRxSSIClockRateListRxFrequencyMHz_A42468;

		// Token: 0x0400499C RID: 18844
		internal global::AcpUI.AcpCustomViewCheckBox CVBtnFctOrdsRxSSIClockRateListRxFrequencyMHz_A42468;

		// Token: 0x0400499D RID: 18845
		internal global::AcpUI.AcpLabel LblFctOrdsRxSSIClockRateListRxFrequencyMHz_A42468;

		// Token: 0x0400499E RID: 18846
		internal global::AcpUI.AcpRtdButton RTDBtnFctOrdsRxSSIClockRateListRxFrequencyMHz_A42468;

		// Token: 0x0400499F RID: 18847
		internal global::AcpUI.AcpCopyButton CpyBtnFctOrdsRxSSIClockRateListRxFrequencyMHz_A42468;

		// Token: 0x040049A0 RID: 18848
		internal global::AcpUI.AcpLabel FctOrdsRxSSIClockRateListRxFrequencyMHz_A42468Comp;

		// Token: 0x040049A1 RID: 18849
		internal global::AcpUI.AcpComboBox FctOrdsRxSSIClockRateListRxSSIClockRateMHz_A42469;

		// Token: 0x040049A2 RID: 18850
		internal global::AcpUI.AcpCustomViewCheckBox CVBtnFctOrdsRxSSIClockRateListRxSSIClockRateMHz_A42469;

		// Token: 0x040049A3 RID: 18851
		internal global::AcpUI.AcpLabel LblFctOrdsRxSSIClockRateListRxSSIClockRateMHz_A42469;

		// Token: 0x040049A4 RID: 18852
		internal global::AcpUI.AcpRtdButton RTDBtnFctOrdsRxSSIClockRateListRxSSIClockRateMHz_A42469;

		// Token: 0x040049A5 RID: 18853
		internal global::AcpUI.AcpCopyButton CpyBtnFctOrdsRxSSIClockRateListRxSSIClockRateMHz_A42469;

		// Token: 0x040049A6 RID: 18854
		internal global::AcpUI.AcpLabel FctOrdsRxSSIClockRateListRxSSIClockRateMHz_A42469Comp;

		// Token: 0x040049A7 RID: 18855
		internal global::AcpUI.AcpExpander ExpanderFactoryOverridesRxSSIRateTXMode;

		// Token: 0x040049A8 RID: 18856
		internal global::AcpUI.AcpRecNavToolbar RecNavToolbarExpanderFactoryOverridesRxSSIClockRateTXMode;

		// Token: 0x040049A9 RID: 18857
		internal global::System.Windows.Controls.Grid ExpanderFactoryOverridesRxSSIRateTXModeGrid;

		// Token: 0x040049AA RID: 18858
		internal global::System.Windows.Controls.Grid ExpanderFactoryOverridesRxSSIClockRateTXModeGrid;

		// Token: 0x040049AB RID: 18859
		internal global::AcpUI.AcpGroupBox ExpanderFactoryOverridesRxSSIClockRateTXModeTableView;

		// Token: 0x040049AC RID: 18860
		internal global::AcpUI.AcpXamDataPresenter ExpanderFactoryOverridesRxSSIClockRateTXMode;

		// Token: 0x040049AD RID: 18861
		internal global::Infragistics.Windows.DataPresenter.UnboundField FctOrdsRxSSIClockRateListTxModeTxFrequencyMHz_A42777_Col;

		// Token: 0x040049AE RID: 18862
		internal global::Infragistics.Windows.DataPresenter.UnboundField FctOrdsRxSSIClockRateTxModeRxSSIClockRateMHz_A42780_Col;

		// Token: 0x040049AF RID: 18863
		internal global::AcpUI.AcpGroupBox ExpanderFactoryOverridesRxSSIClockRateTXModeSRecView;

		// Token: 0x040049B0 RID: 18864
		internal global::System.Windows.Controls.Grid gridExpanderFactoryOverridesRxSSIClockRateTXModeSRecView;

		// Token: 0x040049B1 RID: 18865
		internal global::AcpUI.AcpTextBox FctOrdsRxSSIClockRateListTxModeTxFrequencyMHz_A42777;

		// Token: 0x040049B2 RID: 18866
		internal global::AcpUI.AcpCustomViewCheckBox CVBtnFctOrdsRxSSIClockRateListTxModeTxFrequencyMHz_A42777;

		// Token: 0x040049B3 RID: 18867
		internal global::AcpUI.AcpLabel LblFctOrdsRxSSIClockRateListTxModeTxFrequencyMHz_A42777;

		// Token: 0x040049B4 RID: 18868
		internal global::AcpUI.AcpRtdButton RTDBtnFctOrdsRxSSIClockRateListTxModeTxFrequencyMHz_A42777;

		// Token: 0x040049B5 RID: 18869
		internal global::AcpUI.AcpCopyButton CpyBtnFctOrdsRxSSIClockRateListTxModeTxFrequencyMHz_A42777;

		// Token: 0x040049B6 RID: 18870
		internal global::AcpUI.AcpLabel FctOrdsRxSSIClockRateListTxModeTxFrequencyMHz_A42777Comp;

		// Token: 0x040049B7 RID: 18871
		internal global::AcpUI.AcpComboBox FctOrdsRxSSIClockRateTxModeRxSSIClockRateMHz_A42780;

		// Token: 0x040049B8 RID: 18872
		internal global::AcpUI.AcpCustomViewCheckBox CVBtnFctOrdsRxSSIClockRateTxModeRxSSIClockRateMHz_A42780;

		// Token: 0x040049B9 RID: 18873
		internal global::AcpUI.AcpLabel LblFctOrdsRxSSIClockRateTxModeRxSSIClockRateMHz_A42780;

		// Token: 0x040049BA RID: 18874
		internal global::AcpUI.AcpRtdButton RTDBtnFctOrdsRxSSIClockRateTxModeRxSSIClockRateMHz_A42780;

		// Token: 0x040049BB RID: 18875
		internal global::AcpUI.AcpCopyButton CpyBtnFctOrdsRxSSIClockRateTxModeRxSSIClockRateMHz_A42780;

		// Token: 0x040049BC RID: 18876
		internal global::AcpUI.AcpLabel FctOrdsRxSSIClockRateTxModeRxSSIClockRateMHz_A42780Comp;

		// Token: 0x040049BD RID: 18877
		internal global::AcpUI.AcpExpander ExpanderFactoryOverridesSecondLOInjectionFrequency;

		// Token: 0x040049BE RID: 18878
		internal global::AcpUI.AcpRecNavToolbar RecNavToolbarExpanderFactoryOverridesSecondLOInjectionFrequencyList;

		// Token: 0x040049BF RID: 18879
		internal global::System.Windows.Controls.Grid ExpanderFactoryOverridesSecondLOInjectionFrequencyGrid;

		// Token: 0x040049C0 RID: 18880
		internal global::System.Windows.Controls.Grid ExpanderFactoryOverridesSecondLOInjectionFrequencyListGrid;

		// Token: 0x040049C1 RID: 18881
		internal global::AcpUI.AcpGroupBox ExpanderFactoryOverridesSecondLOInjectionFrequencyListTableView;

		// Token: 0x040049C2 RID: 18882
		internal global::AcpUI.AcpXamDataPresenter ExpanderFactoryOverridesSecondLOInjectionFrequencyList;

		// Token: 0x040049C3 RID: 18883
		internal global::Infragistics.Windows.DataPresenter.UnboundField FctOrdsSecondLOInjectionFrequencySecondLOInjectionFrequency_A9062_Col;

		// Token: 0x040049C4 RID: 18884
		internal global::AcpUI.AcpGroupBox ExpanderFactoryOverridesSecondLOInjectionFrequencyListSRecView;

		// Token: 0x040049C5 RID: 18885
		internal global::System.Windows.Controls.Grid gridExpanderFactoryOverridesSecondLOInjectionFrequencyListSRecView;

		// Token: 0x040049C6 RID: 18886
		internal global::AcpUI.AcpTextBox FctOrdsSecondLOInjectionFrequencySecondLOInjectionFrequency_A9062;

		// Token: 0x040049C7 RID: 18887
		internal global::AcpUI.AcpCustomViewCheckBox CVBtnFctOrdsSecondLOInjectionFrequencySecondLOInjectionFrequency_A9062;

		// Token: 0x040049C8 RID: 18888
		internal global::AcpUI.AcpLabel LblFctOrdsSecondLOInjectionFrequencySecondLOInjectionFrequency_A9062;

		// Token: 0x040049C9 RID: 18889
		internal global::AcpUI.AcpRtdButton RTDBtnFctOrdsSecondLOInjectionFrequencySecondLOInjectionFrequency_A9062;

		// Token: 0x040049CA RID: 18890
		internal global::AcpUI.AcpCopyButton CpyBtnFctOrdsSecondLOInjectionFrequencySecondLOInjectionFrequency_A9062;

		// Token: 0x040049CB RID: 18891
		internal global::AcpUI.AcpLabel FctOrdsSecondLOInjectionFrequencySecondLOInjectionFrequency_A9062Comp;

		// Token: 0x040049CC RID: 18892
		internal global::AcpUI.AcpExpander ExpanderFactoryOverridesRxFrequency;

		// Token: 0x040049CD RID: 18893
		internal global::AcpUI.AcpRecNavToolbar RecNavToolbarExpanderFactoryOverridesRxFrequencyList;

		// Token: 0x040049CE RID: 18894
		internal global::System.Windows.Controls.Grid ExpanderFactoryOverridesRxFrequencyGrid;

		// Token: 0x040049CF RID: 18895
		internal global::System.Windows.Controls.Grid ExpanderFactoryOverridesRxFrequencyListGrid;

		// Token: 0x040049D0 RID: 18896
		internal global::AcpUI.AcpGroupBox ExpanderFactoryOverridesRxFrequencyListTableView;

		// Token: 0x040049D1 RID: 18897
		internal global::AcpUI.AcpXamDataPresenter ExpanderFactoryOverridesRxFrequencyList;

		// Token: 0x040049D2 RID: 18898
		internal global::Infragistics.Windows.DataPresenter.UnboundField FctOrdsRxFrequencyListRxFrequency_Col;

		// Token: 0x040049D3 RID: 18899
		internal global::AcpUI.AcpGroupBox ExpanderFactoryOverridesRxFrequencyListSRecView;

		// Token: 0x040049D4 RID: 18900
		internal global::System.Windows.Controls.Grid gridExpanderFactoryOverridesRxFrequencyListSRecView;

		// Token: 0x040049D5 RID: 18901
		internal global::AcpUI.AcpTextBox FctOrdsRxFrequencyListRxFrequency;

		// Token: 0x040049D6 RID: 18902
		internal global::AcpUI.AcpCustomViewCheckBox CVBtnFctOrdsRxFrequencyListRxFrequency;

		// Token: 0x040049D7 RID: 18903
		internal global::AcpUI.AcpLabel LblFctOrdsRxFrequencyListRxFrequency;

		// Token: 0x040049D8 RID: 18904
		internal global::AcpUI.AcpRtdButton RTDBtnFctOrdsRxFrequencyListRxFrequency;

		// Token: 0x040049D9 RID: 18905
		internal global::AcpUI.AcpCopyButton CpyBtnFctOrdsRxFrequencyListRxFrequency;

		// Token: 0x040049DA RID: 18906
		internal global::AcpUI.AcpLabel FctOrdsRxFrequencyListRxFrequencyComp;

		// Token: 0x040049DB RID: 18907
		private bool b;
	}
}
