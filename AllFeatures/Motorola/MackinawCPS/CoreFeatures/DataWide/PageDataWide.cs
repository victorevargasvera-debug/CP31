using System;
using System.CodeDom.Compiler;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Diagnostics;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Markup;
using AcpBusinessLayer;
using AcpCommonLib;
using AcpUI;
using AcpUI.Common;
using AcpUILib;
using AllFeatures;
using CommonResources;
using Infragistics.Windows.DataPresenter;

namespace Motorola.MackinawCPS.CoreFeatures.DataWide
{
	// Token: 0x020004D2 RID: 1234
	public class PageDataWide : global::AcpUI.AcpPageFeature, global::System.Windows.Markup.IComponentConnector, global::System.Windows.Markup.IStyleConnector
	{
		// Token: 0x0600A33C RID: 41788 RVA: 0x00982A1C File Offset: 0x00980C1C
		public PageDataWide()
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

		// Token: 0x0600A33D RID: 41789 RVA: 0x00982A54 File Offset: 0x00980C54
		public override void OnLoaded(object sender, global::System.Windows.RoutedEventArgs e)
		{
			short num = (short)2103181312;
			int num2 = (int)num;
			switch (num2)
			{
			default:
				num = (short)1080688653;
				num2 = (int)((global::System.IntPtr)num);
				for (;;)
				{
					object obj;
					global::AcpUI.AcpExpander acpExpander;
					global::System.Collections.IEnumerator enumerator;
					switch (num2)
					{
					case 0:
						goto IL_338;
					case 1:
					{
						global::System.Windows.Data.CollectionView collectionView = (global::System.Windows.Data.CollectionView)global::System.Windows.Data.CollectionViewSource.GetDefaultView(obj);
						this.RecNavToolbarExpanderDataWideDataModemTable.MyDataPresenter = this.ExpanderDataWideDataModemTable;
						num = (short)580452359;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 2:
						obj = null;
						obj = this.RecNavToolbarExpanderDataWideConfiguredNetworksList.MyRecordsetDataSource;
						num = (short)1850671119;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 3:
					{
						global::System.Windows.Data.CollectionView collectionView2 = (global::System.Windows.Data.CollectionView)global::System.Windows.Data.CollectionViewSource.GetDefaultView(obj);
						this.RecNavToolbarExpanderDataWideNATListTable.MyDataPresenter = this.ExpanderDataWideNATListTable;
						num = (short)1044512773;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 4:
						goto IL_44E;
					case 5:
						goto IL_3D1;
					case 6:
						goto IL_374;
					case 7:
						goto IL_496;
					case 8:
						goto IL_176;
					case 9:
					{
						global::System.Windows.Data.CollectionView collectionView3 = (global::System.Windows.Data.CollectionView)global::System.Windows.Data.CollectionViewSource.GetDefaultView(obj);
						this.RecNavToolbarExpanderDataWideDataUserListTable.MyDataPresenter = this.ExpanderDataWideDataUserListTable;
						num = (short)2092056837;
						short num3 = num;
						num = (short)1415659781;
						switch ((num3 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_D2;
						default:
							num = (short)673710080;
							if (num != 0)
							{
							}
							num = (short)1734606852;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						break;
					}
					case 10:
						if (obj != null)
						{
							num = (short)850722819;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_3D1;
					case 11:
						if (obj != null)
						{
							num = (short)1862205441;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_496;
					case 12:
						try
						{
							num = (short)988020737;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								switch (num2)
								{
								case 0:
									if (acpExpander != null)
									{
										num = (short)1299972100;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									break;
								case 1:
									switch (0)
									{
									case 0:
										goto IL_200;
									}
									continue;
								case 2:
									goto IL_2C0;
								case 3:
									num = (short)1742602242;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 4:
									base.Expanders.Add(acpExpander);
									num = (short)281411590;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 5:
									if (!enumerator.MoveNext())
									{
										num = (short)355401731;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									acpExpander = (((global::System.Windows.UIElement)enumerator.Current) as global::AcpUI.AcpExpander);
									num = (short)1931870208;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								IL_26A:
								num = (short)1857683461;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								IL_200:
								goto IL_26A;
							}
							IL_2C0:
							goto IL_3A4;
						}
						finally
						{
							switch (0)
							{
							case 0:
								goto IL_2E2;
							}
							global::System.IDisposable disposable;
							for (;;)
							{
								IL_2CF:
								switch (num2)
								{
								case 0:
									if (disposable != null)
									{
										num = (short)1358626818;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									goto IL_337;
								case 1:
									goto IL_335;
								case 2:
									disposable.Dispose();
									num = (short)12517377;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								goto IL_2E2;
							}
							IL_335:
							IL_337:
							goto EndFinally_12;
							IL_2E2:
							disposable = (enumerator as global::System.IDisposable);
							num = (short)168296448;
							num2 = (int)((global::System.IntPtr)num);
							goto IL_2CF;
							EndFinally_12:;
						}
						goto IL_338;
						IL_3A4:
						base.OnLoaded(sender, e);
						this.a = true;
						num = (short)325058578;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 13:
						switch (0)
						{
						case 0:
							goto IL_8F;
						}
						continue;
					case 14:
						if (obj != null)
						{
							num = (short)1277624337;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_374;
					case 15:
					{
						num = (short)1262354432;
						short num4 = num;
						if (obj != null)
						{
							num = (short)229900288;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_176;
					}
					case 16:
						if (obj != null)
						{
							num = (short)680001545;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_44E;
					case 17:
					{
						global::System.Windows.Data.CollectionView collectionView4 = (global::System.Windows.Data.CollectionView)global::System.Windows.Data.CollectionViewSource.GetDefaultView(obj);
						this.RecNavToolbarExpanderDataWideQuickTextMessageListTable.MyDataPresenter = this.ExpanderDataWideQuickTextMessageListTable;
						goto IL_D2;
					}
					case 18:
						goto IL_3CC;
					}
					IL_8F:
					if (!this.a)
					{
						num = (short)285540354;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					break;
					IL_D2:
					num = (short)209125382;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_176:
					obj = this.RecNavToolbarExpanderDataWideDataModemTable.MyRecordsetDataSource;
					num = (short)1945370635;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_338:
					global::System.Windows.Data.CollectionView collectionView5 = (global::System.Windows.Data.CollectionView)global::System.Windows.Data.CollectionViewSource.GetDefaultView(obj);
					this.RecNavToolbarExpanderDataWideConfiguredNetworksList.MyDataPresenter = this.ExpanderDataWideConfiguredNetworksList;
					num = (short)1694105608;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_374:
					acpExpander = null;
					enumerator = this.MyStackPanel.Children.GetEnumerator();
					num = (short)2015232012;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_3D1:
					obj = this.RecNavToolbarExpanderDataWideDataUserListTable.MyRecordsetDataSource;
					num = (short)180289552;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_44E:
					obj = this.RecNavToolbarExpanderDataWideQuickTextMessageListTable.MyRecordsetDataSource;
					num = (short)1160511502;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_496:
					obj = this.RecNavToolbarExpanderDataWideNATListTable.MyRecordsetDataSource;
					num = (short)733806593;
					if (num != 0)
					{
					}
					num = (short)1273233418;
					num2 = (int)((global::System.IntPtr)num);
				}
				IL_3CC:
				this.PostOnLoaded(sender, e);
				this.MyStackPanel.Children[0].Focus();
				return;
			}
		}

		// Token: 0x0600A33E RID: 41790 RVA: 0x0098304C File Offset: 0x0098124C
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
					if (this.a)
					{
						num2 = (short)1703018498;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_143;
				case 1:
					goto IL_141;
				case 2:
				{
					num2 = (short)1970894098;
					short num3 = num2;
					num2 = (short)827946258;
					switch ((num3 == num2) ? 1 : 0)
					{
					case 0:
					case 2:
						break;
					default:
						num2 = (short)1701511168;
						if (num2 != 0)
						{
						}
						base.OnUnloaded(sender, e);
						this.a = false;
						num2 = (short)1477246977;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					break;
				}
				}
				goto IL_1C;
			}
			IL_141:
			IL_143:
			num2 = (short)1360003072;
			short num4 = num2;
			num2 = (short)1905852417;
			if (num2 != 0)
			{
			}
			return;
			IL_1C:
			this.RecNavToolbarExpanderDataWideConfiguredNetworksList.DataContext = null;
			this.RecNavToolbarExpanderDataWideDataModemTable.DataContext = null;
			this.RecNavToolbarExpanderDataWideNATListTable.DataContext = null;
			this.RecNavToolbarExpanderDataWideDataUserListTable.DataContext = null;
			this.RecNavToolbarExpanderDataWideQuickTextMessageListTable.DataContext = null;
			this.RecNavToolbarExpanderDataWideConfiguredNetworksList.MyDataPresenter = null;
			this.RecNavToolbarExpanderDataWideDataModemTable.MyDataPresenter = null;
			this.RecNavToolbarExpanderDataWideNATListTable.MyDataPresenter = null;
			this.RecNavToolbarExpanderDataWideDataUserListTable.MyDataPresenter = null;
			this.RecNavToolbarExpanderDataWideQuickTextMessageListTable.MyDataPresenter = null;
			num2 = (short)270860288;
			num = (int)((global::System.IntPtr)num2);
			goto IL_0A;
		}

		// Token: 0x0600A33F RID: 41791 RVA: 0x009831EC File Offset: 0x009813EC
		public override void SetDataContext()
		{
			short num = (short)1227620356;
			int num2 = (int)((global::System.IntPtr)num);
			object feature;
			for (;;)
			{
				switch (num2)
				{
				case 0:
					goto IL_7FF;
				case 1:
					num = (short)348651544;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 2:
					if (feature != null)
					{
						num = (short)960692233;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_7C5;
				case 3:
					num = (short)1082392594;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 4:
					switch (0)
					{
					case 0:
						goto IL_F1;
					}
					continue;
				case 5:
					num = (short)257949716;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 6:
					goto IL_7FF;
				case 7:
					if (((global::AcpCommonLib.IAcpRecordset)feature)[0][10793] != null)
					{
						num = (short)251658250;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_7C5;
				case 8:
				{
					num = (short)818760863;
					short num3 = num;
					num = (short)2005290143;
					switch ((num3 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_88D;
					default:
						num = (short)610467840;
						if (num != 0)
						{
						}
						if (((global::AcpCommonLib.IAcpRecordset)feature)[0] != null)
						{
							num = (short)1424424997;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_628;
					}
					break;
				}
				case 9:
					num = (short)232390700;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 10:
					num = (short)54329380;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 11:
					if (((global::AcpCommonLib.IAcpRecordset)feature)[0][10071].EmbeddedRecset != null)
					{
						num = (short)1636499477;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					return;
				case 12:
					num = (short)1768620033;
					if (num != 0)
					{
					}
					((global::AcpUILib.IAcpRecNavToolbar)this.RecNavToolbarExpanderDataWideDataUserListTable).MySecondaryRecordsetDataSource = ((global::AcpCommonLib.IAcpRecordset)feature)[0][10069].EmbeddedRecset;
					((global::AcpUILib.IAcpRecNavToolbar)this.RecNavToolbarExpanderDataWideDataUserListTable).SyncDataSources();
					num = (short)989528102;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 13:
					feature = global::AcpCommonLib.AppInfoManager.ComparatorDocument.GetFeature(2028);
					num = (short)1323827202;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 14:
					return;
				case 15:
					goto IL_88D;
				case 16:
					num = (short)1946222614;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 17:
					num = (short)1109917719;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 18:
					if (((global::AcpCommonLib.IAcpRecordset)feature)[0][10067].EmbeddedRecset != null)
					{
						num = (short)209518623;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_98C;
				case 19:
					num = (short)156368904;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 20:
					if (((global::AcpCommonLib.IAcpRecordset)feature)[0][10071] != null)
					{
						num = (short)890109991;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					return;
				case 21:
					goto IL_379;
				case 22:
					if (((global::AcpCommonLib.IAcpRecordset)feature)[0] != null)
					{
						num = (short)1933705249;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_98C;
				case 23:
					if (((global::AcpCommonLib.IAcpRecordset)feature)[0][10849] != null)
					{
						num = (short)1093271601;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_88D;
				case 24:
					if (((global::AcpCommonLib.IAcpRecordset)feature)[0] != null)
					{
						num = (short)1581580293;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					return;
				case 25:
					if (feature != null)
					{
						num = (short)1597702145;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					return;
				case 26:
					if (feature != null)
					{
						num = (short)1993211923;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_628;
				case 27:
					num = (short)296091689;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 28:
					((global::AcpUILib.IAcpRecNavToolbar)this.RecNavToolbarExpanderDataWideDataModemTable).MySecondaryRecordsetDataSource = ((global::AcpCommonLib.IAcpRecordset)feature)[0][10849].EmbeddedRecset;
					((global::AcpUILib.IAcpRecNavToolbar)this.RecNavToolbarExpanderDataWideDataModemTable).SyncDataSources();
					num = (short)1138556943;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 29:
					if (feature != null)
					{
						num = (short)389152798;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_88D;
				case 30:
					num = (short)1873149999;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 31:
					((global::AcpUILib.IAcpRecNavToolbar)this.RecNavToolbarExpanderDataWideNATListTable).MySecondaryRecordsetDataSource = ((global::AcpCommonLib.IAcpRecordset)feature)[0][10067].EmbeddedRecset;
					((global::AcpUILib.IAcpRecNavToolbar)this.RecNavToolbarExpanderDataWideNATListTable).SyncDataSources();
					num = (short)934019118;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 32:
					base.DataContext = global::AcpCommonLib.AppInfoManager.DefaultDocument.GetFeature(2028);
					num = (short)1890844678;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 33:
					num = (short)986513451;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 34:
					goto IL_7C5;
				case 35:
					if (global::AcpCommonLib.AppInfoManager.AppMode == global::AcpCommonLib.ApplicationMode.CodeplugComparisonMode)
					{
						num = (short)1551958029;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					((global::AcpUILib.IAcpRecNavToolbar)this.RecNavToolbarExpanderDataWideConfiguredNetworksList).MySecondaryRecordsetDataSource = null;
					((global::AcpUILib.IAcpRecNavToolbar)this.RecNavToolbarExpanderDataWideDataModemTable).MySecondaryRecordsetDataSource = null;
					((global::AcpUILib.IAcpRecNavToolbar)this.RecNavToolbarExpanderDataWideNATListTable).MySecondaryRecordsetDataSource = null;
					((global::AcpUILib.IAcpRecNavToolbar)this.RecNavToolbarExpanderDataWideDataUserListTable).MySecondaryRecordsetDataSource = null;
					((global::AcpUILib.IAcpRecNavToolbar)this.RecNavToolbarExpanderDataWideQuickTextMessageListTable).MySecondaryRecordsetDataSource = null;
					num = (short)1972764686;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 36:
					if (((global::AcpCommonLib.IAcpRecordset)feature)[0][10793].EmbeddedRecset != null)
					{
						num = (short)1791754288;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_7C5;
				case 37:
					num = (short)131858477;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 38:
					goto IL_628;
				case 39:
					num = (short)1374617611;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 40:
					if (feature != null)
					{
						num = (short)113246224;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_98C;
				case 41:
					if (((global::AcpCommonLib.IAcpRecordset)feature)[0][10069].EmbeddedRecset != null)
					{
						num = (short)1803747340;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_628;
				case 42:
					num = (short)1251016711;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 43:
					if (((global::AcpCommonLib.IAcpRecordset)feature)[0][10067] != null)
					{
						num = (short)1245904899;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_98C;
				case 44:
					if (((global::AcpCommonLib.IAcpRecordset)feature)[0] != null)
					{
						num = (short)938344490;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_7C5;
				case 45:
					if (((global::AcpCommonLib.IAcpRecordset)feature)[0][10069] != null)
					{
						num = (short)997326875;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_628;
				case 46:
					goto IL_98C;
				case 47:
					if (((global::AcpCommonLib.IAcpRecordset)feature)[0] != null)
					{
						num = (short)505282577;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_88D;
				case 48:
					((global::AcpUILib.IAcpRecNavToolbar)this.RecNavToolbarExpanderDataWideConfiguredNetworksList).MySecondaryRecordsetDataSource = ((global::AcpCommonLib.IAcpRecordset)feature)[0][10793].EmbeddedRecset;
					((global::AcpUILib.IAcpRecNavToolbar)this.RecNavToolbarExpanderDataWideConfiguredNetworksList).SyncDataSources();
					num = (short)912523298;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 49:
					num = (short)1859452978;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 50:
					if (((global::AcpCommonLib.IAcpRecordset)feature)[0][10849].EmbeddedRecset != null)
					{
						num = (short)391905308;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_88D;
				}
				IL_F1:
				if (global::AcpCommonLib.AppInfoManager.AppMode == global::AcpCommonLib.ApplicationMode.CustomViewConfigurationMode)
				{
					num = (short)584777760;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				base.DataContext = global::AcpCommonLib.FeatureManager.GetFeature(2028);
				num = (short)1528561664;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_628:
				num = (short)1505755161;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_7C5:
				num = (short)59834397;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_7FF:
				num = (short)1581776931;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_88D:
				num = (short)883752960;
				short num4 = num;
				num = (short)386859048;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_98C:
				num = (short)1607335962;
				num2 = (int)((global::System.IntPtr)num);
			}
			IL_379:
			((global::AcpUILib.IAcpRecNavToolbar)this.RecNavToolbarExpanderDataWideQuickTextMessageListTable).MySecondaryRecordsetDataSource = ((global::AcpCommonLib.IAcpRecordset)feature)[0][10071].EmbeddedRecset;
			((global::AcpUILib.IAcpRecNavToolbar)this.RecNavToolbarExpanderDataWideQuickTextMessageListTable).SyncDataSources();
		}

		// Token: 0x0600A340 RID: 41792 RVA: 0x00983BC0 File Offset: 0x00981DC0
		private void OnModeClick(object A_0, global::System.Windows.RoutedEventArgs A_1)
		{
			int a_ = 12;
			short num = (short)839516160;
			switch (num)
			{
			default:
			{
				num = (short)1135804420;
				int num2 = (int)((global::System.IntPtr)num);
				object myRecordsetDataSource;
				for (;;)
				{
					switch (num2)
					{
					case 0:
						goto IL_6A7;
					case 1:
						goto IL_1E2;
					case 2:
						goto IL_73E;
					case 3:
						if (((global::AcpUI.AcpRecNavToolbar)A_0).TableMode)
						{
							num = (short)451411997;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						((global::AcpUI.AcpRecNavToolbar)A_0).TableMode = true;
						num = (short)146735104;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 4:
						switch (0)
						{
						case 0:
							goto IL_F1;
						}
						continue;
					case 5:
						if (((global::AcpUI.AcpRecNavToolbar)A_0).Name == global::AllFeatures.CodeplugGuid.b("鿌꫎닐鷒듔ꇖ跘듚닜돞菠苢韤ꋦ釨鯪賬臮闰雲蟴돶飸迺鳼ꣾ栀朂怄嘆簈戊渌搎䔐瘒洔挖吘縚渜氞䀠䐢䀤欦䀨堪夬笮倰儲头制", a_))
						{
							num = (short)602865670;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return;
					case 6:
						num = (short)961282059;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 7:
						if (((global::AcpUI.AcpRecNavToolbar)A_0).Name == global::AllFeatures.CodeplugGuid.b("鿌꫎닐鷒듔ꇖ跘듚닜돞菠苢韤ꋦ釨鯪賬臮闰雲蟴돶飸迺鳼ꣾ栀朂怄䌆栈缊氌䈎縐眒瀔稖䴘稚缜猞䐠", a_))
						{
							num = (short)594804773;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_6A7;
					case 8:
						((global::AcpUI.AcpRecNavToolbar)A_0).TableMode = false;
						myRecordsetDataSource = this.RecNavToolbarExpanderDataWideQuickTextMessageListTable.MyRecordsetDataSource;
						num = (short)678952980;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 9:
					{
						((global::AcpUI.AcpRecNavToolbar)A_0).TableMode = false;
						object myRecordsetDataSource2 = this.RecNavToolbarExpanderDataWideDataUserListTable.MyRecordsetDataSource;
						num = (short)989659153;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 10:
						if (((global::AcpUI.AcpRecNavToolbar)A_0).TableMode)
						{
							num = (short)603324425;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						((global::AcpUI.AcpRecNavToolbar)A_0).TableMode = true;
						num = (short)2057895954;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 11:
					{
						num = (short)249495552;
						short num3 = num;
						if (((global::AcpUI.AcpRecNavToolbar)A_0).TableMode)
						{
							goto IL_415;
						}
						((global::AcpUI.AcpRecNavToolbar)A_0).TableMode = true;
						num = (short)959643688;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 12:
						goto IL_659;
					case 13:
					{
						object myRecordsetDataSource3;
						global::System.Windows.Data.CollectionView collectionView = (global::System.Windows.Data.CollectionView)global::System.Windows.Data.CollectionViewSource.GetDefaultView(myRecordsetDataSource3);
						global::Motorola.MackinawCPS.CoreFeatures.DataWide.DataModemTableInner item = (global::Motorola.MackinawCPS.CoreFeatures.DataWide.DataModemTableInner)collectionView.CurrentItem;
						collectionView.MoveCurrentTo(item);
						((global::AcpUI.AcpRecNavToolbar)A_0).SyncDataSources();
						num = (short)235929631;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 14:
						goto IL_4DA;
					case 15:
						if (((global::AcpUI.AcpRecNavToolbar)A_0).TableMode)
						{
							num = (short)1120927774;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						((global::AcpUI.AcpRecNavToolbar)A_0).TableMode = true;
						num = (short)2126643214;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 16:
					{
						object myRecordsetDataSource4;
						if (myRecordsetDataSource4 != null)
						{
							num = (short)1514471451;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_4DA;
					}
					case 17:
					{
						object myRecordsetDataSource2;
						if (myRecordsetDataSource2 != null)
						{
							num = (short)689766421;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_1E2;
					}
					case 18:
						goto IL_1E2;
					case 19:
						if (((global::AcpUI.AcpRecNavToolbar)A_0).TableMode)
						{
							num = (short)412286999;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						((global::AcpUI.AcpRecNavToolbar)A_0).TableMode = true;
						num = (short)829685786;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 20:
						if (myRecordsetDataSource != null)
						{
							num = (short)802291724;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return;
					case 21:
					{
						object myRecordsetDataSource2;
						global::System.Windows.Data.CollectionView collectionView2 = (global::System.Windows.Data.CollectionView)global::System.Windows.Data.CollectionViewSource.GetDefaultView(myRecordsetDataSource2);
						global::Motorola.MackinawCPS.CoreFeatures.DataWide.DataUserListInner item2 = (global::Motorola.MackinawCPS.CoreFeatures.DataWide.DataUserListInner)collectionView2.CurrentItem;
						collectionView2.MoveCurrentTo(item2);
						((global::AcpUI.AcpRecNavToolbar)A_0).SyncDataSources();
						num = (short)1453654017;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 22:
					{
						object myRecordsetDataSource3;
						if (myRecordsetDataSource3 != null)
						{
							num = (short)193658893;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_6A7;
					}
					case 23:
					{
						((global::AcpUI.AcpRecNavToolbar)A_0).TableMode = false;
						object myRecordsetDataSource5 = this.RecNavToolbarExpanderDataWideNATListTable.MyRecordsetDataSource;
						num = (short)934412321;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 24:
					{
						num = (short)974192641;
						if (num != 0)
						{
						}
						object myRecordsetDataSource5;
						global::System.Windows.Data.CollectionView collectionView3 = (global::System.Windows.Data.CollectionView)global::System.Windows.Data.CollectionViewSource.GetDefaultView(myRecordsetDataSource5);
						global::Motorola.MackinawCPS.CoreFeatures.DataWide.NATListInner item3 = (global::Motorola.MackinawCPS.CoreFeatures.DataWide.NATListInner)collectionView3.CurrentItem;
						collectionView3.MoveCurrentTo(item3);
						((global::AcpUI.AcpRecNavToolbar)A_0).SyncDataSources();
						num = (short)552534018;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 25:
						goto IL_4DA;
					case 26:
						goto IL_73E;
					case 27:
					{
						object myRecordsetDataSource4;
						global::System.Windows.Data.CollectionView collectionView4 = (global::System.Windows.Data.CollectionView)global::System.Windows.Data.CollectionViewSource.GetDefaultView(myRecordsetDataSource4);
						global::Motorola.MackinawCPS.CoreFeatures.DataWide.ConfiguredNetworksListInner item4 = (global::Motorola.MackinawCPS.CoreFeatures.DataWide.ConfiguredNetworksListInner)collectionView4.CurrentItem;
						collectionView4.MoveCurrentTo(item4);
						((global::AcpUI.AcpRecNavToolbar)A_0).SyncDataSources();
						num = (short)1087504409;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 28:
						if (((global::AcpUI.AcpRecNavToolbar)A_0).Name == global::AllFeatures.CodeplugGuid.b("鿌꫎닐鷒듔ꇖ跘듚닜돞菠苢韤ꋦ釨鯪賬臮闰雲蟴돶飸迺鳼ꣾ栀朂怄䌆栈缊氌娎成瘒朔嬖瀘栚検䬞䀠䄢䤤䈦", a_))
						{
							num = (short)1875181600;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_1E2;
					case 29:
					{
						((global::AcpUI.AcpRecNavToolbar)A_0).TableMode = false;
						object myRecordsetDataSource3 = this.RecNavToolbarExpanderDataWideDataModemTable.MyRecordsetDataSource;
						num = (short)2034499606;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 30:
					{
						((global::AcpUI.AcpRecNavToolbar)A_0).TableMode = false;
						object myRecordsetDataSource4 = this.RecNavToolbarExpanderDataWideConfiguredNetworksList.MyRecordsetDataSource;
						num = (short)1562902544;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 31:
						goto IL_6A7;
					case 32:
						num = (short)2084962314;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 33:
					{
						object myRecordsetDataSource5;
						if (myRecordsetDataSource5 != null)
						{
							num = (short)94306328;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_73E;
					}
					case 34:
						num = (short)1736638479;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 35:
						num = (short)476971046;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 36:
						num = (short)880345107;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 37:
						num = (short)1777467395;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 38:
						if (((global::AcpUI.AcpRecNavToolbar)A_0).Name == global::AllFeatures.CodeplugGuid.b("鿌꫎닐鷒듔ꇖ跘듚닜돞菠苢韤ꋦ釨鯪賬臮闰雲蟴돶飸迺鳼ꣾ栀朂怄䐆昈攊欌明瘐昒朔爖紘唚砜欞嘠䰢圤䰦娨未䐬尮䔰", a_))
						{
							num = (short)1657077794;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_4DA;
					case 39:
						if (((global::AcpUI.AcpRecNavToolbar)A_0).Name == global::AllFeatures.CodeplugGuid.b("鿌꫎닐鷒듔ꇖ跘듚닜돞菠苢韤ꋦ釨鯪賬臮闰雲蟴돶飸迺鳼ꣾ栀朂怄䤆䠈弊䄌明成朒䄔瘖笘眚砜", a_))
						{
							num = (short)1511194660;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_73E;
					case 40:
						goto IL_456;
					}
					IL_F1:
					if (A_0 is global::AcpUI.AcpRecNavToolbar)
					{
						num = (short)116719651;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					break;
					IL_1E2:
					num = (short)122486789;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_415:
					num = (short)1419706376;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_4DA:
					num = (short)622957304;
					short num4 = num;
					num = (short)1329697528;
					switch ((num4 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_415;
					default:
						num = (short)1432944640;
						if (num != 0)
						{
						}
						num = (short)1238761479;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					IL_6A7:
					num = (short)2069757991;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_73E:
					num = (short)1278607388;
					num2 = (int)((global::System.IntPtr)num);
				}
				IL_456:
				return;
				IL_659:
				global::System.Windows.Data.CollectionView collectionView5 = (global::System.Windows.Data.CollectionView)global::System.Windows.Data.CollectionViewSource.GetDefaultView(myRecordsetDataSource);
				global::Motorola.MackinawCPS.CoreFeatures.DataWide.QuickTextMessageListInner item5 = (global::Motorola.MackinawCPS.CoreFeatures.DataWide.QuickTextMessageListInner)collectionView5.CurrentItem;
				collectionView5.MoveCurrentTo(item5);
				((global::AcpUI.AcpRecNavToolbar)A_0).SyncDataSources();
				return;
			}
			}
		}

		// Token: 0x0600A341 RID: 41793 RVA: 0x00984454 File Offset: 0x00982654
		private void HLinkClick(object A_0, global::System.Windows.RoutedEventArgs A_1)
		{
			short num = (short)1184169984;
			short num2 = num;
			num = (short)1096920796;
			short num3 = num;
			num = (short)999403228;
			switch (num3 == num)
			{
			}
			num = (short)853934081;
			if (num != 0)
			{
			}
			num = (short)1441464320;
			if (num != 0)
			{
			}
			base.OnHLinkClick(A_0);
		}

		// Token: 0x0600A342 RID: 41794 RVA: 0x00984504 File Offset: 0x00982704
		private void OnFieldNameDoubleClick(object A_0, global::System.Windows.RoutedEventArgs A_1)
		{
			short num = (short)1792344065;
			if (num != 0)
			{
			}
			num = (short)737280000;
			short num2 = num;
			num = (short)842762697;
			short num3 = num;
			num = (short)1447856585;
			switch (num3 == num)
			{
			}
			num = (short)1666383872;
			if (num != 0)
			{
			}
			global::AcpUI.Common.Utility.GetFieldHelpText(A_0);
		}

		// Token: 0x0600A343 RID: 41795 RVA: 0x009845B8 File Offset: 0x009827B8
		internal void OnExpanderDataWideConfiguredNetworksListClick(object sender, global::System.Windows.RoutedEventArgs e)
		{
			switch (0)
			{
			case 0:
				goto IL_1C;
			}
			short num2;
			object myRecordsetDataSource;
			global::Motorola.MackinawCPS.CoreFeatures.DataWide.ConfiguredNetworksListInner item;
			for (;;)
			{
				IL_0A:
				int num;
				switch (num)
				{
				case 0:
				{
					num2 = (short)1130889216;
					short num3 = num2;
					if (myRecordsetDataSource != null)
					{
						num2 = (short)542375938;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_152;
				}
				case 1:
					goto IL_128;
				case 2:
					((global::System.Windows.Data.CollectionView)global::System.Windows.Data.CollectionViewSource.GetDefaultView(myRecordsetDataSource)).MoveCurrentTo(item);
					this.RecNavToolbarExpanderDataWideConfiguredNetworksList.SyncDataSources();
					num2 = (short)934871041;
					num = (int)((global::System.IntPtr)num2);
					continue;
				}
				goto IL_1C;
			}
			IL_128:
			num2 = (short)2127429633;
			if (num2 != 0)
			{
			}
			IL_152:
			this.RecNavToolbarExpanderDataWideConfiguredNetworksList.TableMode = false;
			return;
			IL_1C:
			item = (global::Motorola.MackinawCPS.CoreFeatures.DataWide.ConfiguredNetworksListInner)((global::Infragistics.Windows.DataPresenter.CellValuePresenter)((global::AcpUI.AcpButton)e.Source).TemplatedParent).Record.DataItem;
			myRecordsetDataSource = this.RecNavToolbarExpanderDataWideConfiguredNetworksList.MyRecordsetDataSource;
			num2 = (short)1091052839;
			short num4 = num2;
			num2 = (short)922821927;
			switch ((num4 == num2) ? 1 : 0)
			{
			case 0:
			case 2:
				goto IL_0A;
			default:
			{
				num2 = (short)360775680;
				if (num2 != 0)
				{
				}
				num2 = (short)2092302336;
				int num = (int)((global::System.IntPtr)num2);
				goto IL_0A;
			}
			}
		}

		// Token: 0x0600A344 RID: 41796 RVA: 0x00984724 File Offset: 0x00982924
		internal void OnExpanderDataWideDataModemTableClick(object sender, global::System.Windows.RoutedEventArgs e)
		{
			switch (0)
			{
			case 0:
				goto IL_1C;
			}
			object myRecordsetDataSource;
			short num2;
			global::Motorola.MackinawCPS.CoreFeatures.DataWide.DataModemTableInner item;
			for (;;)
			{
				IL_0A:
				int num;
				switch (num)
				{
				case 0:
					if (myRecordsetDataSource != null)
					{
						num2 = (short)1335230466;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_156;
				case 1:
					goto IL_154;
				case 2:
					((global::System.Windows.Data.CollectionView)global::System.Windows.Data.CollectionViewSource.GetDefaultView(myRecordsetDataSource)).MoveCurrentTo(item);
					this.RecNavToolbarExpanderDataWideDataModemTable.SyncDataSources();
					num2 = (short)908525569;
					num = (int)((global::System.IntPtr)num2);
					continue;
				}
				goto IL_1C;
			}
			IL_154:
			IL_156:
			this.RecNavToolbarExpanderDataWideDataModemTable.TableMode = false;
			return;
			IL_1C:
			item = (global::Motorola.MackinawCPS.CoreFeatures.DataWide.DataModemTableInner)((global::Infragistics.Windows.DataPresenter.CellValuePresenter)((global::AcpUI.AcpButton)e.Source).TemplatedParent).Record.DataItem;
			myRecordsetDataSource = this.RecNavToolbarExpanderDataWideDataModemTable.MyRecordsetDataSource;
			num2 = (short)1960235657;
			short num3 = num2;
			num2 = (short)496620169;
			switch ((num3 == num2) ? 1 : 0)
			{
			case 0:
			case 2:
				goto IL_0A;
			default:
			{
				num2 = (short)1717960705;
				if (num2 != 0)
				{
				}
				num2 = (short)285278208;
				if (num2 != 0)
				{
				}
				num2 = (short)870252544;
				short num4 = num2;
				num2 = (short)1441792000;
				int num = (int)((global::System.IntPtr)num2);
				goto IL_0A;
			}
			}
		}

		// Token: 0x0600A345 RID: 41797 RVA: 0x00984894 File Offset: 0x00982A94
		internal void OnExpanderDataWideNATListTableClick(object sender, global::System.Windows.RoutedEventArgs e)
		{
			switch (0)
			{
			case 0:
				goto IL_1C;
			}
			object myRecordsetDataSource;
			short num2;
			global::Motorola.MackinawCPS.CoreFeatures.DataWide.NATListInner item;
			for (;;)
			{
				IL_0A:
				int num;
				switch (num)
				{
				case 0:
					if (myRecordsetDataSource != null)
					{
						num2 = (short)308019202;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_155;
				case 1:
					goto IL_153;
				case 2:
					((global::System.Windows.Data.CollectionView)global::System.Windows.Data.CollectionViewSource.GetDefaultView(myRecordsetDataSource)).MoveCurrentTo(item);
					this.RecNavToolbarExpanderDataWideNATListTable.SyncDataSources();
					num2 = (short)299433985;
					num = (int)((global::System.IntPtr)num2);
					continue;
				}
				goto IL_1C;
			}
			IL_153:
			IL_155:
			this.RecNavToolbarExpanderDataWideNATListTable.TableMode = false;
			return;
			IL_1C:
			num2 = (short)1959067649;
			if (num2 != 0)
			{
			}
			item = (global::Motorola.MackinawCPS.CoreFeatures.DataWide.NATListInner)((global::Infragistics.Windows.DataPresenter.CellValuePresenter)((global::AcpUI.AcpButton)e.Source).TemplatedParent).Record.DataItem;
			myRecordsetDataSource = this.RecNavToolbarExpanderDataWideNATListTable.MyRecordsetDataSource;
			num2 = (short)1786547462;
			short num3 = num2;
			num2 = (short)527404294;
			switch ((num3 == num2) ? 1 : 0)
			{
			case 0:
			case 2:
				goto IL_0A;
			default:
			{
				num2 = (short)1630142464;
				if (num2 != 0)
				{
				}
				num2 = (short)375062528;
				short num4 = num2;
				num2 = (short)2114125824;
				int num = (int)((global::System.IntPtr)num2);
				goto IL_0A;
			}
			}
		}

		// Token: 0x0600A346 RID: 41798 RVA: 0x00984A04 File Offset: 0x00982C04
		internal void OnExpanderDataWideDataUserListTableClick(object sender, global::System.Windows.RoutedEventArgs e)
		{
			switch (0)
			{
			case 0:
				goto IL_1C;
			}
			object myRecordsetDataSource;
			short num2;
			global::Motorola.MackinawCPS.CoreFeatures.DataWide.DataUserListInner item;
			for (;;)
			{
				IL_0A:
				int num;
				switch (num)
				{
				case 0:
					if (myRecordsetDataSource != null)
					{
						num2 = (short)1051459586;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_150;
				case 1:
					goto IL_14E;
				case 2:
					((global::System.Windows.Data.CollectionView)global::System.Windows.Data.CollectionViewSource.GetDefaultView(myRecordsetDataSource)).MoveCurrentTo(item);
					this.RecNavToolbarExpanderDataWideDataUserListTable.SyncDataSources();
					num2 = (short)1264713729;
					num = (int)((global::System.IntPtr)num2);
					continue;
				}
				goto IL_1C;
			}
			IL_14E:
			IL_150:
			this.RecNavToolbarExpanderDataWideDataUserListTable.TableMode = false;
			return;
			IL_1C:
			num2 = (short)704053249;
			if (num2 != 0)
			{
			}
			item = (global::Motorola.MackinawCPS.CoreFeatures.DataWide.DataUserListInner)((global::Infragistics.Windows.DataPresenter.CellValuePresenter)((global::AcpUI.AcpButton)e.Source).TemplatedParent).Record.DataItem;
			myRecordsetDataSource = this.RecNavToolbarExpanderDataWideDataUserListTable.MyRecordsetDataSource;
			num2 = (short)1532957544;
			short num3 = num2;
			num2 = (short)12784488;
			switch ((num3 == num2) ? 1 : 0)
			{
			case 0:
			case 2:
				goto IL_0A;
			default:
			{
				num2 = (short)1368195072;
				if (num2 != 0)
				{
				}
				num2 = (short)248250368;
				short num4 = num2;
				num2 = (short)1108410368;
				int num = (int)((global::System.IntPtr)num2);
				goto IL_0A;
			}
			}
		}

		// Token: 0x0600A347 RID: 41799 RVA: 0x00984B70 File Offset: 0x00982D70
		internal void OnExpanderDataWideQuickTextMessageListTableClick(object sender, global::System.Windows.RoutedEventArgs e)
		{
			short num = (short)1842282497;
			if (num != 0)
			{
			}
			switch (0)
			{
			case 0:
				goto IL_43;
			}
			object myRecordsetDataSource;
			global::Motorola.MackinawCPS.CoreFeatures.DataWide.QuickTextMessageListInner item;
			for (;;)
			{
				IL_31:
				int num2;
				switch (num2)
				{
				case 0:
					if (myRecordsetDataSource != null)
					{
						num = (short)333905922;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_153;
				case 1:
					goto IL_151;
				case 2:
					((global::System.Windows.Data.CollectionView)global::System.Windows.Data.CollectionViewSource.GetDefaultView(myRecordsetDataSource)).MoveCurrentTo(item);
					this.RecNavToolbarExpanderDataWideQuickTextMessageListTable.SyncDataSources();
					num = (short)1355284481;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				goto IL_43;
			}
			IL_151:
			IL_153:
			this.RecNavToolbarExpanderDataWideQuickTextMessageListTable.TableMode = false;
			return;
			IL_43:
			item = (global::Motorola.MackinawCPS.CoreFeatures.DataWide.QuickTextMessageListInner)((global::Infragistics.Windows.DataPresenter.CellValuePresenter)((global::AcpUI.AcpButton)e.Source).TemplatedParent).Record.DataItem;
			myRecordsetDataSource = this.RecNavToolbarExpanderDataWideQuickTextMessageListTable.MyRecordsetDataSource;
			num = (short)373086416;
			short num3 = num;
			num = (short)1602541776;
			switch ((num3 == num) ? 1 : 0)
			{
			case 0:
			case 2:
				goto IL_31;
			default:
			{
				num = (short)322502656;
				if (num != 0)
				{
				}
				num = (short)1866661888;
				short num4 = num;
				num = (short)151322624;
				int num2 = (int)((global::System.IntPtr)num);
				goto IL_31;
			}
			}
		}

		// Token: 0x0600A348 RID: 41800 RVA: 0x00984CDC File Offset: 0x00982EDC
		private void PostOnLoaded(object A_0, global::System.Windows.RoutedEventArgs A_1)
		{
			short num = (short)1027772607;
			short num2 = num;
			num = (short)432509119;
			switch (num2 == num)
			{
			default:
			{
				num = (short)1256390656;
				short num3 = num;
				break;
			}
			case true:
				break;
			}
			num = (short)1460273153;
			if (num != 0)
			{
			}
			num = (short)846725120;
			if (num != 0)
			{
			}
			this.a();
		}

		// Token: 0x0600A349 RID: 41801 RVA: 0x00984D8C File Offset: 0x00982F8C
		private void a()
		{
			short num = (short)1403715586;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				num = (short)20113253;
				short num3 = num;
				num = (short)1474422629;
				switch ((num3 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					return;
				default:
				{
					num = (short)1880621056;
					if (num != 0)
					{
					}
					global::System.Collections.ObjectModel.ObservableCollection<global::AcpBusinessLayer.ListItem> observableCollection;
					global::System.Collections.ObjectModel.ObservableCollection<global::AcpBusinessLayer.ListItem> observableCollection2;
					switch (num2)
					{
					case 0:
						observableCollection = null;
						goto IL_2F0;
					case 1:
						return;
					case 2:
						switch (0)
						{
						case 0:
							goto IL_8D;
						}
						continue;
					case 3:
						try
						{
							num = (short)754122756;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								switch (num2)
								{
								case 0:
									num = (short)1638465544;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 1:
									goto IL_1F2;
								case 2:
									this.RecNavToolbarExpanderDataWideDataModemTable.Visibility = global::System.Windows.Visibility.Hidden;
									num = (short)1093926915;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 4:
									switch (0)
									{
									case 0:
										goto IL_F5;
									}
									continue;
								case 5:
								{
									global::System.Collections.Generic.IEnumerator<global::AcpBusinessLayer.ListItem> enumerator;
									if (!enumerator.MoveNext())
									{
										num = (short)303169542;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									global::AcpBusinessLayer.ListItem listItem = enumerator.Current;
									num = (short)390922247;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 6:
									num = (short)187891713;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 7:
								{
									global::AcpBusinessLayer.ListItem listItem;
									if (listItem.ItemName == global::CommonResources.AcgResources.ID_WIRELESS)
									{
										num = (short)619577344;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									break;
								}
								case 8:
								{
									global::AcpBusinessLayer.ListItem listItem;
									if (!listItem.ItemVisibility)
									{
										num = (short)1304035330;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									break;
								}
								}
								IL_F7:
								num = (short)1132331013;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								IL_F5:
								goto IL_F7;
							}
							IL_1F2:
							return;
						}
						finally
						{
							num = (short)1664745472;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								global::System.Collections.Generic.IEnumerator<global::AcpBusinessLayer.ListItem> enumerator;
								switch (num2)
								{
								case 0:
									switch (0)
									{
									case 0:
										goto IL_227;
									}
									continue;
								case 1:
									goto IL_25C;
								case 2:
									enumerator.Dispose();
									num = (short)640155649;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								IL_227:
								if (enumerator == null)
								{
									break;
								}
								num = (short)1702100994;
								num2 = (int)((global::System.IntPtr)num);
							}
							IL_25C:;
						}
						goto IL_25F;
					case 4:
						observableCollection = null;
						goto IL_2F0;
					case 5:
					{
						if (observableCollection2 == null)
						{
							num = (short)2041905153;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						global::System.Collections.Generic.IEnumerator<global::AcpBusinessLayer.ListItem> enumerator = observableCollection2.GetEnumerator();
						num = (short)1332936707;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 6:
						observableCollection = null;
						goto IL_2F0;
					}
					IL_8D:
					global::Motorola.MackinawCPS.CoreFeatures.DataWide.DataWide dataWide = global::AcpCommonLib.FeatureManager.GetFeature(2028)[0] as global::Motorola.MackinawCPS.CoreFeatures.DataWide.DataWide;
					if (dataWide == null)
					{
						num = (short)1516175364;
						num2 = (int)((global::System.IntPtr)num);
						break;
					}
					IL_25F:
					global::Motorola.MackinawCPS.CoreFeatures.DataWide.ExternalDataModem externalDataModem = dataWide.ExternalDataModem;
					if (externalDataModem == null)
					{
						num = (short)8126464;
						num2 = (int)((global::System.IntPtr)num);
						break;
					}
					global::AcpBusinessLayer.AcpListField modemConnectionType_ = externalDataModem.ModemConnectionType_43350;
					if (modemConnectionType_ == null)
					{
						num = (short)952827910;
						num2 = (int)((global::System.IntPtr)num);
						break;
					}
					observableCollection = modemConnectionType_.Items;
					IL_2F0:
					observableCollection2 = observableCollection;
					num = (short)1357512704;
					short num4 = num;
					num = (short)1634140161;
					if (num != 0)
					{
					}
					num = (short)1460862981;
					num2 = (int)((global::System.IntPtr)num);
					break;
				}
				}
			}
		}

		// Token: 0x0600A34A RID: 41802 RVA: 0x00985134 File Offset: 0x00983334
		[global::System.CodeDom.Compiler.GeneratedCode("PresentationBuildTasks", "5.0.10.0")]
		[global::System.Diagnostics.DebuggerNonUserCode]
		public void InitializeComponent()
		{
			int a_ = 16;
			short num = (short)1236664320;
			short num2 = num;
			num = (short)215972773;
			short num3 = num;
			num = (short)660044709;
			switch ((num3 == num) ? 1 : 0)
			{
			case 0:
			case 2:
				break;
			default:
				num = (short)1159593984;
				if (num != 0)
				{
				}
				num = (short)718667777;
				if (num != 0)
				{
				}
				if (!this.b)
				{
					this.b = true;
					global::System.Uri resourceLocator = new global::System.Uri(global::AllFeatures.CodeplugGuid.b("ﻐ鋒맔믖鿘뻚볜ꯞ铠釢胤铦틨裪苬苮臰鳲鯴鋶韸迺틼鯾怀眂搄∆㬈㬊渌怎缐甒簔瀖氘椚簜欞䠠䰢䬤ࠦ䴨䨪夬丮ᐰĲԴ䀶倸强堼ှ╀≂ㅄ♆㹈≊⥌⩎罐⭒㑔㩖㕘", a_), global::System.UriKind.Relative);
					global::System.Windows.Application.LoadComponent(this, resourceLocator);
					return;
				}
				break;
			}
		}

		// Token: 0x0600A34B RID: 41803 RVA: 0x00985218 File Offset: 0x00983418
		[global::System.Diagnostics.DebuggerNonUserCode]
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		[global::System.CodeDom.Compiler.GeneratedCode("PresentationBuildTasks", "5.0.10.0")]
		void global::System.Windows.Markup.IComponentConnector.Connect(int connectionId, object target)
		{
			short num = (short)848232448;
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
					goto IL_38A7;
				case 2:
					num = (short)2096955393;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				IL_32:
				switch (connectionId)
				{
				case 1:
					goto IL_1257;
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
					goto IL_4252;
				case 27:
					goto IL_19A5;
				case 28:
					goto IL_1233;
				case 29:
					goto IL_C16;
				case 30:
					goto IL_3D1B;
				case 31:
					goto IL_40C7;
				case 32:
					goto IL_404E;
				case 33:
					goto IL_2392;
				case 34:
					goto IL_4105;
				case 35:
					goto IL_351C;
				case 36:
					goto IL_36F2;
				case 37:
					goto IL_2259;
				case 38:
					goto IL_E3E;
				case 39:
					goto IL_2232;
				case 40:
					goto IL_27D7;
				case 41:
					goto IL_1BA1;
				case 42:
					goto IL_41BC;
				case 43:
					goto IL_3C4A;
				case 44:
					goto IL_10E8;
				case 45:
					goto IL_D9E;
				case 46:
					goto IL_3CB9;
				case 47:
					goto IL_22A4;
				case 48:
					goto IL_1F95;
				case 49:
					goto IL_1C5B;
				case 50:
					goto IL_3845;
				case 51:
					goto IL_3CC6;
				case 52:
					goto IL_1DBC;
				case 53:
					goto IL_3F87;
				case 54:
					goto IL_148F;
				case 55:
					goto IL_2E7F;
				case 56:
					goto IL_24A7;
				case 57:
					goto IL_21E7;
				case 58:
					goto IL_2910;
				case 59:
					goto IL_177A;
				case 60:
					goto IL_35E3;
				case 61:
					goto IL_3730;
				case 62:
					goto IL_3617;
				case 63:
					goto IL_1570;
				case 64:
					goto IL_38DD;
				case 65:
					goto IL_399A;
				case 66:
					goto IL_1ABD;
				case 67:
					goto IL_23B6;
				case 68:
					goto IL_268A;
				case 69:
					goto IL_2DA1;
				case 70:
					goto IL_2B9E;
				case 71:
					goto IL_37E0;
				case 72:
					goto IL_3AEA;
				case 73:
					goto IL_2951;
				case 74:
					goto IL_307C;
				case 75:
					goto IL_2309;
				case 76:
					goto IL_EAD;
				case 77:
					goto IL_3486;
				case 78:
					goto IL_1E38;
				case 79:
					goto IL_14F4;
				case 80:
					goto IL_282F;
				case 81:
					goto IL_1BF9;
				case 82:
					goto IL_1594;
				case 83:
					goto IL_3D3F;
				case 84:
					goto IL_2CC0;
				case 85:
					goto IL_3E5E;
				case 86:
					goto IL_19D6;
				case 87:
					goto IL_3DC8;
				case 88:
					goto IL_4096;
				case 89:
					goto IL_3D4C;
				case 90:
					goto IL_2F46;
				case 91:
					goto IL_22B1;
				case 92:
					goto IL_25DD;
				case 93:
					goto IL_17A1;
				case 94:
					goto IL_37AF;
				case 95:
					goto IL_2585;
				case 96:
					goto IL_3DEC;
				case 97:
					goto IL_2CF4;
				case 98:
					goto IL_10CE;
				case 99:
					goto IL_3757;
				case 100:
					goto IL_188C;
				case 101:
					goto IL_2E1D;
				case 102:
					goto IL_17E9;
				case 103:
					goto IL_40EB;
				case 104:
					goto IL_3493;
				case 105:
					goto IL_3407;
				case 106:
					goto IL_30DE;
				case 107:
					goto IL_2AA6;
				case 108:
					goto IL_271D;
				case 109:
					goto IL_29DF;
				case 110:
					goto IL_1F88;
				case 111:
					goto IL_26EC;
				case 112:
					goto IL_357E;
				case 113:
					goto IL_3807;
				case 114:
					goto IL_2F22;
				case 115:
					goto IL_1BC8;
				case 116:
					goto IL_1A17;
				case 117:
					goto IL_BAE;
				case 118:
					goto IL_15B8;
				case 119:
					goto IL_110C;
				case 120:
					goto IL_39DB;
				case 121:
					goto IL_1A6F;
				case 122:
					goto IL_4136;
				case 123:
					goto IL_12F7;
				case 124:
					goto IL_173C;
				case 125:
					goto IL_10DB;
				case 126:
					goto IL_3F32;
				case 127:
					goto IL_F77;
				case 128:
					goto IL_33E0;
				case 129:
					goto IL_32FF;
				case 130:
					goto IL_E93;
				case 131:
					goto IL_1787;
				case 132:
					goto IL_20E5;
				case 133:
					goto IL_1CBD;
				case 134:
					goto IL_354D;
				case 135:
					goto IL_C47;
				case 136:
					goto IL_EBA;
				case 137:
					goto IL_2DE9;
				case 138:
					goto IL_3A7B;
				case 139:
					goto IL_E1A;
				case 140:
					goto IL_2578;
				case 141:
					goto IL_3935;
				case 142:
					goto IL_1A7C;
				case 143:
					goto IL_2944;
				case 144:
					goto IL_38B9;
				case 145:
					goto IL_2AF1;
				case 146:
					goto IL_1865;
				case 147:
					goto IL_2B77;
				case 148:
					goto IL_38AC;
				case 149:
					goto IL_F43;
				case 150:
					goto IL_195D;
				case 151:
					goto IL_3A26;
				case 152:
					goto IL_235E;
				case 153:
					goto IL_2C68;
				case 154:
					goto IL_321E;
				case 155:
					goto IL_3E6B;
				case 156:
					goto IL_21A9;
				case 157:
					goto IL_2BAB;
				case 158:
					goto IL_295E;
				case 159:
					goto IL_C3A;
				case 160:
					goto IL_3B63;
				case 161:
					goto IL_3E13;
				case 162:
					goto IL_2438;
				case 163:
					goto IL_3FEC;
				case 164:
					goto IL_1794;
				case 165:
					goto IL_1F19;
				case 166:
					goto IL_292A;
				case 167:
					goto IL_3C16;
				case 168:
					goto IL_369D;
				case 169:
					goto IL_3E3A;
				case 170:
					goto IL_35F0;
				case 171:
					goto IL_337E;
				case 172:
					goto IL_B94;
				case 173:
					goto IL_ED4;
				case 174:
					goto IL_3455;
				case 175:
					goto IL_CF4;
				case 176:
					goto IL_3EC3;
				case 177:
					goto IL_3883;
				case 178:
					goto IL_2A4E;
				case 179:
					goto IL_C54;
				case 180:
					goto IL_32F2;
				case 181:
					goto IL_278C;
				case 182:
					goto IL_2A75;
				case 183:
					goto IL_3969;
				case 184:
					goto IL_1A96;
				case 185:
					goto IL_2AD7;
				case 186:
					goto IL_10C1;
				case 187:
					goto IL_3276;
				case 188:
					goto IL_3B3F;
				case 189:
					goto IL_E6F;
				case 190:
					goto IL_23DD;
				case 191:
					goto IL_BE2;
				case 192:
					goto IL_34A0;
				case 193:
					goto IL_2C5B;
				case 194:
					goto IL_2547;
				case 195:
					goto IL_20B4;
				case 196:
					goto IL_D6D;
				case 197:
					goto IL_3364;
				case 198:
					goto IL_164B;
				case 199:
					goto IL_D60;
				case 200:
					goto IL_41C9;
				case 201:
					goto IL_3869;
				case 202:
					goto IL_192C;
				case 203:
					goto IL_1D67;
				case 204:
					goto IL_224C;
				case 205:
					goto IL_22BE;
				case 206:
					goto IL_24CB;
				case 207:
					goto IL_25D0;
				case 208:
					goto IL_2FE6;
				case 209:
					goto IL_1F26;
				case 210:
					goto IL_23D0;
				case 211:
					goto IL_303B;
				case 212:
					goto IL_2978;
				case 213:
					goto IL_204F;
				case 214:
					goto IL_1718;
				case 215:
					goto IL_13C8;
				case 216:
					goto IL_168C;
				case 217:
					goto IL_149C;
				case 218:
					goto IL_2351;
				case 219:
					goto IL_20A7;
				case 220:
					goto IL_24D8;
				case 221:
					goto IL_D3C;
				case 222:
					goto IL_205C;
				case 223:
					goto IL_1827;
				case 224:
					goto IL_2C1A;
				case 225:
					goto IL_37FA;
				case 226:
					goto IL_1359;
				case 227:
					goto IL_2483;
				case 228:
					goto IL_1E45;
				case 229:
					goto IL_2F91;
				case 230:
					goto IL_4010;
				case 231:
					goto IL_25B6;
				case 232:
					goto IL_3C88;
				case 233:
					goto IL_1DFA;
				case 234:
					goto IL_1BBB;
				case 235:
					goto IL_33FA;
				case 236:
					goto IL_209A;
				case 237:
					goto IL_382B;
				case 238:
					goto IL_17C5;
				case 239:
					goto IL_1FED;
				case 240:
					goto IL_CE7;
				case 241:
					goto IL_3A6E;
				case 242:
					goto IL_32D8;
				case 243:
					goto IL_1FBC;
				case 244:
					goto IL_3181;
				case 245:
					goto IL_DB8;
				case 246:
					goto IL_F5D;
				case 247:
					goto IL_3BEF;
				case 248:
					goto IL_3C6E;
				case 249:
					goto IL_275B;
				case 250:
					goto IL_12C6;
				case 251:
					goto IL_11DE;
				case 252:
					goto IL_3D59;
				case 253:
					goto IL_3448;
				case 254:
					goto IL_1130;
				case 255:
					goto IL_1BAE;
				case 256:
					goto IL_29F9;
				case 257:
					goto IL_28B8;
				case 258:
					goto IL_2225;
				case 259:
					goto IL_1C8C;
				case 260:
					goto IL_27FE;
				case 261:
					goto IL_22CB;
				case 262:
					goto IL_261B;
				case 263:
					goto IL_13EC;
				case 264:
					goto IL_253A;
				case 265:
					goto IL_DE9;
				case 266:
					goto IL_16C0;
				case 267:
					goto IL_1E52;
				case 268:
					goto IL_22D8;
				case 269:
					goto IL_223F;
				case 270:
					goto IL_150E;
				case 271:
					goto IL_2860;
				case 272:
					goto IL_2CA6;
				case 273:
					goto IL_2297;
				case 274:
					goto IL_34D1;
				case 275:
					goto IL_3E20;
				case 276:
					goto IL_FF0;
				case 277:
					goto IL_1B7A;
				case 278:
					goto IL_1A55;
				case 279:
					goto IL_3414;
				case 280:
					goto IL_1B94;
				case 281:
					goto IL_2D3F;
				case 282:
					goto IL_395C;
				case 283:
					goto IL_4174;
				case 284:
					goto IL_27E4;
				case 285:
					goto IL_167F;
				case 286:
					goto IL_3FB8;
				case 287:
					goto IL_2A1D;
				case 288:
					goto IL_310F;
				case 289:
					goto IL_2985;
				case 290:
					goto IL_3FDF;
				case 291:
					goto IL_2D87;
				case 292:
					goto IL_28AB;
				case 293:
					goto IL_151B;
				case 294:
					goto IL_3C7B;
				case 295:
					goto IL_12A2;
				case 296:
					goto IL_1D05;
				case 297:
					goto IL_FE3;
				case 298:
					goto IL_CB6;
				case 299:
					goto IL_C92;
				case 300:
					goto IL_3540;
				case 301:
					goto IL_FFD;
				case 302:
					goto IL_3357;
				case 303:
					goto IL_35C9;
				case 304:
					goto IL_394F;
				case 305:
					goto IL_30EB;
				case 306:
					goto IL_3BC8;
				case 307:
					goto IL_3904;
				case 308:
					goto IL_1076;
				case 309:
					goto IL_3690;
				case 310:
					goto IL_3C09;
				case 311:
					goto IL_2F15;
				case 312:
					goto IL_2B46;
				case 313:
					goto IL_256B;
				case 314:
					goto IL_16E4;
				case 315:
					goto IL_2011;
				case 316:
					goto IL_2EF1;
				case 317:
					goto IL_3D73;
				case 318:
					goto IL_2BCF;
				case 319:
					goto IL_2A99;
				case 320:
					goto IL_334A;
				case 321:
					goto IL_1295;
				case 322:
					goto IL_21F4;
				case 323:
					goto IL_1CE1;
				case 324:
					goto IL_4245;
				case 325:
					goto IL_14E7;
				case 326:
					goto IL_3F56;
				case 327:
					goto IL_12EA;
				case 328:
					goto IL_212D;
				case 329:
					goto IL_355A;
				case 330:
					goto IL_343B;
				case 331:
					goto IL_286D;
				case 332:
					goto IL_2A41;
				case 333:
					goto IL_1069;
				case 334:
					goto IL_1ACA;
				case 335:
					goto IL_34EB;
				case 336:
					goto IL_21DA;
				case 337:
					goto IL_C09;
				case 338:
					goto IL_4143;
				case 339:
					goto IL_2411;
				case 340:
					goto IL_1841;
				case 341:
					goto IL_1C37;
				case 342:
					goto IL_35FD;
				case 343:
					goto IL_DAB;
				case 344:
					goto IL_18EE;
				case 345:
					goto IL_2BDC;
				case 346:
					goto IL_2592;
				case 347:
					goto IL_2B22;
				case 348:
					goto IL_1563;
				case 349:
					goto IL_2F53;
				case 350:
					goto IL_2F84;
				case 351:
					goto IL_1D36;
				case 352:
					goto IL_1EF5;
				case 353:
					goto IL_3017;
				case 354:
					goto IL_1AFB;
				case 355:
					goto IL_1B08;
				case 356:
					goto IL_3BE2;
				case 357:
					goto IL_1658;
				case 358:
					goto IL_3A4A;
				case 359:
					goto IL_33BC;
				case 360:
					goto IL_296B;
				case 361:
					goto IL_242B;
				case 362:
					goto IL_3CAC;
				case 363:
					goto IL_32E5;
				case 364:
					goto IL_1DD6;
				case 365:
					goto IL_1749;
				case 366:
					goto IL_1202;
				case 367:
					goto IL_3129;
				case 368:
					goto IL_1F7B;
				case 369:
					goto IL_19F0;
				case 370:
					goto IL_2DC5;
				case 371:
					goto IL_D7A;
				case 372:
					goto IL_3BBB;
				case 373:
					goto IL_41FA;
				case 374:
					goto IL_291D;
				case 375:
					goto IL_3928;
				case 376:
					goto IL_3CD3;
				case 377:
					goto IL_3F94;
				case 378:
					goto IL_13AE;
				case 379:
					goto IL_191F;
				case 380:
					goto IL_216B;
				case 381:
					goto IL_4238;
				case 382:
					goto IL_3D80;
				case 383:
					goto IL_22E5;
				case 384:
					goto IL_1E2B;
				case 385:
					goto IL_161A;
				case 386:
					goto IL_3BFC;
				case 387:
					goto IL_1DC9;
				case 388:
					goto IL_30A0;
				case 389:
					goto IL_2185;
				case 390:
					goto IL_1021;
				case 391:
					goto IL_2035;
				case 392:
					goto IL_1E5F;
				case 393:
					goto IL_14DA;
				case 394:
					goto IL_2C27;
				case 395:
					goto IL_2151;
				case 396:
					goto IL_398D;
				case 397:
					goto IL_1288;
				case 398:
					goto IL_1FAF;
				case 399:
					goto IL_F6A;
				case 400:
					goto IL_3AD0;
				case 401:
					goto IL_2903;
				case 402:
					goto IL_3211;
				case 403:
					goto IL_2B91;
				case 404:
					goto IL_3174;
				case 405:
					goto IL_1EC4;
				case 406:
					goto IL_3AC3;
				case 407:
					goto IL_170B;
				case 408:
					goto IL_245C;
				case 409:
					goto IL_10B4;
				case 410:
					goto IL_29A9;
				case 411:
					goto IL_2ECA;
				case 412:
					goto IL_2CE7;
				case 413:
					goto IL_18E1;
				case 414:
					goto IL_2EBD;
				case 415:
					goto IL_2C82;
				case 416:
					goto IL_1AA3;
				case 417:
					goto IL_FBF;
				case 418:
					goto IL_3838;
				case 419:
					goto IL_274E;
				case 420:
					goto IL_B87;
				case 421:
					goto IL_1083;
				case 422:
					goto IL_350F;
				case 423:
					goto IL_363B;
				case 424:
					goto IL_3764;
				case 425:
					goto IL_374A;
				case 426:
					goto IL_18D4;
				case 427:
					goto IL_26C8;
				case 428:
					goto IL_2378;
				case 429:
					goto IL_4072;
				case 430:
					goto IL_30D1;
				case 431:
					goto IL_1444;
				case 432:
					goto IL_1834;
				case 433:
					goto IL_36CE;
				case 434:
					goto IL_25C3;
				case 435:
					goto IL_1311;
				case 436:
					goto IL_BD5;
				case 437:
					goto IL_EC7;
				case 438:
					goto IL_2C41;
				case 439:
					goto IL_1406;
				case 440:
					goto IL_F50;
				case 441:
					goto IL_1335;
				case 442:
					goto IL_300A;
				case 443:
					goto IL_1A48;
				case 444:
					goto IL_2E72;
				case 445:
					goto IL_1ED1;
				case 446:
					goto IL_3FD2;
				case 447:
					goto IL_3238;
				case 448:
					goto IL_2DF6;
				case 449:
					goto IL_40BA;
				case 450:
					goto IL_23C3;
				case 451:
					goto IL_3283;
				case 452:
					goto IL_28D2;
				case 453:
					goto IL_2768;
				case 454:
					goto IL_28C5;
				case 455:
					goto IL_1185;
				case 456:
					goto IL_2178;
				case 457:
					goto IL_1BD5;
				case 458:
					goto IL_2E03;
				case 459:
					goto IL_3B70;
				case 460:
					goto IL_2E10;
				case 461:
					goto IL_26BB;
				case 462:
					goto IL_1E86;
				case 463:
					goto IL_27B3;
				case 464:
					goto IL_3BAE;
				case 465:
					goto IL_4198;
				case 466:
					goto IL_322B;
				case 467:
					goto IL_3F18;
				case 468:
					goto IL_1451;
				case 469:
					goto IL_15C5;
				case 470:
					goto IL_2AE4;
				case 471:
					goto IL_CC3;
				case 472:
					goto IL_208D;
				case 473:
					goto IL_2042;
				case 474:
					goto IL_3E2D;
				case 475:
					goto IL_3AF7;
				case 476:
					goto IL_160D;
				case 477:
					goto IL_1161;
				case 478:
					goto IL_35D6;
				case 479:
					goto IL_1699;
				case 480:
					goto IL_14A9;
				case 481:
					goto IL_2516;
				case 482:
					goto IL_1437;
				case 483:
					goto IL_113D;
				case 484:
					goto IL_2CDA;
				case 485:
					goto IL_1A62;
				case 486:
					goto IL_3D66;
				case 487:
					goto IL_32A7;
				case 488:
					goto IL_13A1;
				case 489:
					goto IL_2BE9;
				case 490:
					goto IL_27A6;
				case 491:
					goto IL_37D3;
				case 492:
					goto IL_3BD5;
				case 493:
					goto IL_30AD;
				case 494:
					goto IL_13F9;
				case 495:
					goto IL_3136;
				case 496:
					goto IL_3942;
				case 497:
					goto IL_1501;
				case 498:
					goto IL_BBB;
				case 499:
					goto IL_2109;
				case 500:
					goto IL_3479;
				case 501:
					goto IL_145E;
				case 502:
					goto IL_3E06;
				case 503:
					goto IL_3C30;
				case 504:
					goto IL_1F6E;
				case 505:
					goto IL_1B60;
				case 506:
					goto IL_2887;
				case 507:
					goto IL_29EC;
				case 508:
					goto IL_39FF;
				case 509:
					goto IL_B7A;
				case 510:
					goto IL_2ACA;
				case 511:
					goto IL_2EA3;
				case 512:
					goto IL_20D8;
				case 513:
					goto IL_38EA;
				case 514:
					goto IL_1A89;
				case 515:
					goto IL_3269;
				case 516:
					goto IL_18FB;
				case 517:
					goto IL_3DF9;
				case 518:
					goto IL_2F60;
				case 519:
					goto IL_2B15;
				case 520:
					goto IL_13BB;
				case 521:
					goto IL_27F1;
				case 522:
					goto IL_120F;
				case 523:
					goto IL_1D8B;
				case 524:
					goto IL_1B3C;
				case 525:
					goto IL_3A19;
				case 526:
					goto IL_33AF;
				case 527:
					goto IL_3C23;
				case 528:
					goto IL_17F6;
				case 529:
					goto IL_19E3;
				case 530:
					goto IL_338B;
				case 531:
					goto IL_2C4E;
				case 532:
					goto IL_342E;
				case 533:
					goto IL_1AEE;
				case 534:
					goto IL_DDC;
				case 535:
					goto IL_1D98;
				case 536:
					goto IL_2CCD;
				case 537:
					goto IL_4207;
				case 538:
					goto IL_3F25;
				case 539:
					goto IL_2404;
				case 540:
					goto IL_16FE;
				case 541:
					goto IL_EEE;
				case 542:
					goto IL_2EB0;
				case 543:
					goto IL_4214;
				case 544:
					goto IL_3ADD;
				case 545:
					goto IL_F9B;
				case 546:
					goto IL_1CB0;
				case 547:
					goto IL_37A2;
				case 548:
					goto IL_2218;
				case 549:
					goto IL_2D94;
				case 550:
					goto IL_1D12;
				case 551:
					goto IL_264C;
				case 552:
					goto IL_3C3D;
				case 553:
					goto IL_215E;
				case 554:
					goto IL_228A;
				case 555:
					goto IL_2476;
				case 556:
					goto IL_3062;
				case 557:
					goto IL_333D;
				case 558:
					goto IL_1981;
				case 559:
					goto IL_1FA2;
				case 560:
					goto IL_2666;
				case 561:
					goto IL_2C75;
				case 562:
					goto IL_EA0;
				case 563:
					goto IL_1304;
				case 564:
					goto IL_10A7;
				case 565:
					goto IL_330C;
				case 566:
					goto IL_325C;
				case 567:
					goto IL_137D;
				case 568:
					goto IL_2069;
				case 569:
					goto IL_1C1D;
				case 570:
					goto IL_1C2A;
				case 571:
					goto IL_1950;
				case 572:
					goto IL_1B15;
				case 573:
					goto IL_15E9;
				case 574:
					goto IL_3F63;
				case 575:
					goto IL_1B6D;
				case 576:
					goto IL_306F;
				case 577:
					goto IL_1B87;
				case 578:
					goto IL_C85;
				case 579:
					goto IL_3598;
				case 580:
					goto IL_26F9;
				case 581:
					goto IL_3876;
				case 582:
					goto IL_1E1E;
				case 583:
					goto IL_19FD;
				case 584:
					goto IL_BA1;
				case 585:
					goto IL_28DF;
				case 586:
					goto IL_3EF4;
				case 587:
					goto IL_23F7;
				case 588:
					goto IL_181A;
				case 589:
					goto IL_33ED;
				case 590:
					goto IL_EE1;
				case 591:
					goto IL_18B0;
				case 592:
					goto IL_D18;
				case 593:
					goto IL_142A;
				case 594:
					goto IL_1E6C;
				case 595:
					goto IL_3A0C;
				case 596:
					goto IL_3167;
				case 597:
					goto IL_1E93;
				case 598:
					goto IL_EFB;
				case 599:
					goto IL_1665;
				case 600:
					goto IL_2509;
				case 601:
					goto IL_2741;
				case 602:
					goto IL_2B6A;
				case 603:
					goto IL_283C;
				case 604:
					goto IL_3B1B;
				case 605:
					goto IL_4129;
				case 606:
					goto IL_1482;
				case 607:
					goto IL_40F8;
				case 608:
					goto IL_401D;
				case 609:
					goto IL_32CB;
				case 610:
					goto IL_2385;
				case 611:
					goto IL_2D0E;
				case 612:
					goto IL_34AD;
				case 613:
					goto IL_3371;
				case 614:
					goto IL_373D;
				case 615:
					goto IL_E0D;
				case 616:
					goto IL_358B;
				case 617:
					goto IL_31A5;
				case 618:
					goto IL_F1F;
				case 619:
					goto IL_3795;
				case 620:
					goto IL_3048;
				case 621:
					goto IL_3BA1;
				case 622:
					goto IL_2C0D;
				case 623:
					goto IL_3ED0;
				case 624:
					goto IL_3E92;
				case 625:
					goto IL_BEF;
				case 626:
					goto IL_1EB7;
				case 627:
					goto IL_2822;
				case 628:
					goto IL_2C34;
				case 629:
					goto IL_4150;
				case 630:
					goto IL_1627;
				case 631:
					goto IL_36C1;
				case 632:
					goto IL_21CD;
				case 633:
					goto IL_1872;
				case 634:
					goto IL_35BC;
				case 635:
					goto IL_3DA4;
				case 636:
					goto IL_1045;
				case 637:
					goto IL_25EA;
				case 638:
					goto IL_287A;
				case 639:
					goto IL_176D;
				case 640:
					goto IL_3B94;
				case 641:
					goto IL_3723;
				case 642:
					goto IL_38F7;
				case 643:
					goto IL_C61;
				case 644:
					goto IL_365F;
				case 645:
					goto IL_E62;
				case 646:
					goto IL_360A;
				case 647:
					goto IL_3055;
				case 648:
					goto IL_BC8;
				case 649:
					goto IL_14B6;
				case 650:
					goto IL_31ED;
				case 651:
					goto IL_3716;
				case 652:
					goto IL_16F1;
				case 653:
					goto IL_16A6;
				case 654:
					goto IL_2A5B;
				case 655:
					goto IL_1A24;
				case 656:
					goto IL_3CF7;
				case 657:
					goto IL_3E78;
				case 658:
					goto IL_16B3;
				case 659:
					goto IL_2D01;
				case 660:
					goto IL_2799;
				case 661:
					goto IL_232D;
				case 662:
					goto IL_3771;
				case 663:
					goto IL_3E85;
				case 664:
					goto IL_3421;
				case 665:
					goto IL_311C;
				case 666:
					goto IL_23EA;
				case 667:
					goto IL_25F7;
				case 668:
					goto IL_2FC2;
				case 669:
					goto IL_3683;
				case 670:
					goto IL_1B22;
				case 671:
					goto IL_3EB6;
				case 672:
					goto IL_315A;
				case 673:
					goto IL_1FC9;
				case 674:
					goto IL_2E41;
				case 675:
					goto IL_2CB3;
				case 676:
					goto IL_2B84;
				case 677:
					goto IL_187F;
				case 678:
					goto IL_24FC;
				case 679:
					goto IL_1D43;
				case 680:
					goto IL_402A;
				case 681:
					goto IL_236B;
				case 682:
					goto IL_34DE;
				case 683:
					goto IL_1672;
				case 684:
					goto IL_2469;
				case 685:
					goto IL_41D6;
				case 686:
					goto IL_3319;
				case 687:
					goto IL_2ED7;
				case 688:
					goto IL_26AE;
				case 689:
					goto IL_39A7;
				case 690:
					goto IL_241E;
				case 691:
					goto IL_2628;
				case 692:
					goto IL_3A9F;
				case 693:
					goto IL_2D32;
				case 694:
					goto IL_2A68;
				case 695:
					goto IL_BFC;
				case 696:
					goto IL_1C7F;
				case 697:
					goto IL_2F9E;
				case 698:
					goto IL_19B2;
				case 699:
					goto IL_1B2F;
				case 700:
					goto IL_227D;
				case 701:
					goto IL_2937;
				case 702:
					goto IL_2EE4;
				case 703:
					goto IL_31C9;
				case 704:
					goto IL_1F4A;
				case 705:
					goto IL_3FC5;
				case 706:
					goto IL_37ED;
				case 707:
					goto IL_1A0A;
				case 708:
					goto IL_1E79;
				case 709:
					goto IL_153F;
				case 710:
					goto IL_2D63;
				case 711:
					goto IL_1AB0;
				case 712:
					goto IL_2E65;
				case 713:
					goto IL_2659;
				default:
					num = (short)1003159554;
					num2 = (int)((global::System.IntPtr)num);
					break;
				}
			}
			IL_B7A:
			this.ExpanderDataWideNATListTableTableView = (global::AcpUI.AcpGroupBox)target;
			return;
			IL_B87:
			this.DataWideExternalDataModemNetworkPriority_43358Comp = (global::AcpUI.AcpLabel)target;
			return;
			IL_B94:
			this.AcknowledgedGunHolsterStateReportingEnable_43551Comp = (global::AcpUI.AcpCheckBox)target;
			return;
			IL_BA1:
			this.CVBtnDataConfigDataWideMaxHeaderSizeAllowedForCompression_A36206 = (global::AcpUI.AcpCustomViewCheckBox)target;
			return;
			IL_BAE:
			this.DataWideGeneralDVRIPAddress_A41818Comp = (global::AcpUI.AcpLabel)target;
			return;
			IL_BBB:
			this.DataWideMG90WirelessSatelliteFriendlyName_43787Comp = (global::AcpUI.AcpLabel)target;
			return;
			IL_BC8:
			this.CVBtnDataWideLabtoolDATA_CFGPacketDataActivateWaitTimerSec_A8686 = (global::AcpUI.AcpCustomViewCheckBox)target;
			return;
			IL_BD5:
			this.RTDBtnDataWideEncryptedNetworkPassword_43361 = (global::AcpUI.AcpRtdButton)target;
			return;
			IL_BE2:
			this.CpyBtnDataWidePOP25OTAPRejectEnable_A8671 = (global::AcpUI.AcpCopyButton)target;
			return;
			IL_BEF:
			this.RTDBtnDataWideWIFIOTAPTCPPort_42627 = (global::AcpUI.AcpRtdButton)target;
			return;
			IL_BFC:
			this.CloudRegion_43554Comp = (global::AcpUI.AcpLabel)target;
			return;
			IL_C09:
			this.CpyBtnDataWideDataModemPassword_A42848 = (global::AcpUI.AcpCopyButton)target;
			return;
			IL_C16:
			this.HLinkPOP25 = (global::System.Windows.Documents.Hyperlink)target;
			this.HLinkPOP25.Click += this.HLinkClick;
			return;
			IL_C3A:
			this.CpyBtnSensorMeasurementReporting_A43021 = (global::AcpUI.AcpCopyButton)target;
			return;
			IL_C47:
			this.CpyBtnDataWideLTEAPCOAvalancheTime_A42204 = (global::AcpUI.AcpCopyButton)target;
			return;
			IL_C54:
			this.ExpanderDataWidePOP25 = (global::AcpUI.AcpExpander)target;
			return;
			IL_C61:
			this.LblLabtoolContextRenewalTimerMin = (global::AcpUI.AcpLabel)target;
			this.LblLabtoolContextRenewalTimerMin.MouseDoubleClick += new global::System.Windows.Input.MouseButtonEventHandler(this.OnFieldNameDoubleClick);
			return;
			IL_C85:
			this.CVBtnDataConfigDataWideMaxNumOfCompreHeadersBetweenFullHeaders_A36205 = (global::AcpUI.AcpCustomViewCheckBox)target;
			return;
			IL_C92:
			this.DataWideWiFiNetworkEncryptedNetworkPassword_42517 = (global::AcpUI.AcpPasswordEyeBox)target;
			this.DataWideWiFiNetworkEncryptedNetworkPassword_42517.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_CB6:
			this.DataWideWiFiNetworkSecurityType_42516Comp = (global::AcpUI.AcpLabel)target;
			return;
			IL_CC3:
			this.LblDataWideExternalDataModemOpenTime_43367 = (global::AcpUI.AcpLabel)target;
			this.LblDataWideExternalDataModemOpenTime_43367.MouseDoubleClick += new global::System.Windows.Input.MouseButtonEventHandler(this.OnFieldNameDoubleClick);
			return;
			IL_CE7:
			this.RTDBtnDataWideLTEOperation_A42215 = (global::AcpUI.AcpRtdButton)target;
			return;
			IL_CF4:
			this.AcknowledgedStunGunStateReportingEnable_43552 = (global::AcpUI.AcpCheckBox)target;
			this.AcknowledgedStunGunStateReportingEnable_43552.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_D18:
			this.DataConfigDataWideMaxTimeBetweenFullHeaders_A36200 = (global::AcpUI.AcpTextBoxSpinner)target;
			this.DataConfigDataWideMaxTimeBetweenFullHeaders_A36200.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_D3C:
			this.DataWideLTEOpenMaxGuardTime_A42391 = (global::AcpUI.AcpTextBoxSpinner)target;
			this.DataWideLTEOpenMaxGuardTime_A42391.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_D60:
			this.ExpanderDataWideLTE = (global::AcpUI.AcpExpander)target;
			return;
			IL_D6D:
			this.RTDBtnDataWidePOP25AutoResetEnable_A37221 = (global::AcpUI.AcpRtdButton)target;
			return;
			IL_D7A:
			this.DataWideExternalDataModemLTEFriendlyName_43775 = (global::AcpUI.AcpTextBox)target;
			this.DataWideExternalDataModemLTEFriendlyName_43775.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_D9E:
			this.RTDBtnDataWideGeneralSNMPTraps_A9166 = (global::AcpUI.AcpRtdButton)target;
			return;
			IL_DAB:
			this.CpyBtnDataWideExternalDataModemVPNTunnel_43024 = (global::AcpUI.AcpCopyButton)target;
			return;
			IL_DB8:
			this.DataWideDataOnRoaming_A42216 = (global::AcpUI.AcpCheckBox)target;
			this.DataWideDataOnRoaming_A42216.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_DDC:
			this.ExpanderDataWideDataUserList = (global::AcpUI.AcpExpander)target;
			return;
			IL_DE9:
			this.LblDataWideWIFIAllowUserControl = (global::AcpUI.AcpLabel)target;
			this.LblDataWideWIFIAllowUserControl.MouseDoubleClick += new global::System.Windows.Input.MouseButtonEventHandler(this.OnFieldNameDoubleClick);
			return;
			IL_E0D:
			this.DataConfDataWidePortConAuthenticationUDPPort_A37608Comp = (global::AcpUI.AcpLabel)target;
			return;
			IL_E1A:
			this.DataWideGeneralBroadbandCheckbackTime_A42862 = (global::AcpUI.AcpTextBoxSpinner)target;
			this.DataWideGeneralBroadbandCheckbackTime_A42862.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_E3E:
			this.HLinkLabtoolDATA_CFG = (global::System.Windows.Documents.Hyperlink)target;
			this.HLinkLabtoolDATA_CFG.Click += this.HLinkClick;
			return;
			IL_E62:
			this.RTDBtnLabtoolContextRenewalTimerMin = (global::AcpUI.AcpRtdButton)target;
			return;
			IL_E6F:
			this.DataWidePOP25OTAPRejectEnable_A8671 = (global::AcpUI.AcpCheckBox)target;
			this.DataWidePOP25OTAPRejectEnable_A8671.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_E93:
			this.DataWideGeneralInternalRadioSubnet_A42073Comp = (global::AcpUI.AcpLabel)target;
			return;
			IL_EA0:
			this.CpyBtnDataWideQuickTextMessageListQuickTextMessage_A8810 = (global::AcpUI.AcpCopyButton)target;
			return;
			IL_EAD:
			this.RTDBtnDataWideGeneralPeerIPAddressAssignmentType1_A22376 = (global::AcpUI.AcpRtdButton)target;
			return;
			IL_EBA:
			this.DataWideLTEAPCOAvalancheTime_A42204Comp = (global::AcpUI.AcpLabel)target;
			return;
			IL_EC7:
			this.CpyBtnDataWideEncryptedNetworkPassword_43361 = (global::AcpUI.AcpCopyButton)target;
			return;
			IL_ED4:
			this.CVBtnAcknowledgedStunGunStateReportingEnable_43552 = (global::AcpUI.AcpCustomViewCheckBox)target;
			return;
			IL_EE1:
			this.CVBtnDataConfigDataWideMaxTimeBetweenFullHeaders_A36200 = (global::AcpUI.AcpCustomViewCheckBox)target;
			return;
			IL_EEE:
			this.ExpanderDataWideDataUserListTableSRecView = (global::AcpUI.AcpGroupBox)target;
			return;
			IL_EFB:
			this.DataCfgDataWideMaxSetupTimeAllowedforCCA_A36193 = (global::AcpUI.AcpTextBoxSpinner)target;
			this.DataCfgDataWideMaxSetupTimeAllowedforCCA_A36193.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_F1F:
			this.DataWideP25LocationReportingUDPPort_42413 = (global::AcpUI.AcpTextBoxSpinner)target;
			this.DataWideP25LocationReportingUDPPort_42413.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_F43:
			this.CVBtnDataWideExternalTextMessagingBroadcast_42418 = (global::AcpUI.AcpCustomViewCheckBox)target;
			return;
			IL_F50:
			this.CVBtnDataWideExternalDataModemType_43362 = (global::AcpUI.AcpCustomViewCheckBox)target;
			return;
			IL_F5D:
			this.RTDBtnDataWideDataOnRoaming_A42216 = (global::AcpUI.AcpRtdButton)target;
			return;
			IL_F6A:
			this.DataWideExternalDataModemNetworkSsid_43358_Col = (global::Infragistics.Windows.DataPresenter.UnboundField)target;
			return;
			IL_F77:
			this.DataWideGeneralInternalRadioSubnet_A42073 = (global::AcpUI.AcpTextBox)target;
			this.DataWideGeneralInternalRadioSubnet_A42073.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_F9B:
			this.LblDataWideDataUserListDataUserInformation_A7800 = (global::AcpUI.AcpLabel)target;
			this.LblDataWideDataUserListDataUserInformation_A7800.MouseDoubleClick += new global::System.Windows.Input.MouseButtonEventHandler(this.OnFieldNameDoubleClick);
			return;
			IL_FBF:
			this.LblDataWideExternalDataModemNetworkPriority_43358 = (global::AcpUI.AcpLabel)target;
			this.LblDataWideExternalDataModemNetworkPriority_43358.MouseDoubleClick += new global::System.Windows.Input.MouseButtonEventHandler(this.OnFieldNameDoubleClick);
			return;
			IL_FE3:
			this.CpyBtnDataWideWiFiNetworkSecurityType_42516 = (global::AcpUI.AcpCopyButton)target;
			return;
			IL_FF0:
			this.DataWideWiFiNetworkSecurityType_42516_Col = (global::Infragistics.Windows.DataPresenter.UnboundField)target;
			return;
			IL_FFD:
			this.LblDataWideWiFiNetworkEncryptedNetworkPassword_42517 = (global::AcpUI.AcpLabel)target;
			this.LblDataWideWiFiNetworkEncryptedNetworkPassword_42517.MouseDoubleClick += new global::System.Windows.Input.MouseButtonEventHandler(this.OnFieldNameDoubleClick);
			return;
			IL_1021:
			this.DataWideExternalDataModemWifiPowerupGuardTime = (global::AcpUI.AcpTextBoxSpinner)target;
			this.DataWideExternalDataModemWifiPowerupGuardTime.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_1045:
			this.DataWideKVLKeyloadingUDPPort_43205 = (global::AcpUI.AcpTextBoxSpinner)target;
			this.DataWideKVLKeyloadingUDPPort_43205.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_1069:
			this.CVBtnDataWideDataModemPassword_A42848 = (global::AcpUI.AcpCustomViewCheckBox)target;
			return;
			IL_1076:
			this.RTDBtnDataWideWIFINetworkHidden = (global::AcpUI.AcpRtdButton)target;
			return;
			IL_1083:
			this.DataWideExternalDataModemNetworkSsid_43358 = (global::AcpUI.AcpTextBox)target;
			this.DataWideExternalDataModemNetworkSsid_43358.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_10A7:
			this.ExpanderDataWideDataProtocolConfiguration = (global::AcpUI.AcpExpander)target;
			return;
			IL_10B4:
			this.DataWideMG90WirelessLTEFriendlyName_43786_Col = (global::Infragistics.Windows.DataPresenter.UnboundField)target;
			return;
			IL_10C1:
			this.DataWidePOP25OTAPIndications_A8670Comp = (global::AcpUI.AcpLabel)target;
			return;
			IL_10CE:
			this.GrpBoxExpanderDataWideGeneralPseudo2 = (global::AcpUI.AcpGroupBox)target;
			return;
			IL_10DB:
			this.CVBtnDataWideGeneralInternalRadioSubnet_A42073 = (global::AcpUI.AcpCustomViewCheckBox)target;
			return;
			IL_10E8:
			this.DataWideGeneralSNMPTraps_A9166 = (global::AcpUI.AcpCheckBox)target;
			this.DataWideGeneralSNMPTraps_A9166.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_110C:
			this.LblDataWideGeneralPeerIPAddressAssignmentType2_A22377 = (global::AcpUI.AcpLabel)target;
			this.LblDataWideGeneralPeerIPAddressAssignmentType2_A22377.MouseDoubleClick += new global::System.Windows.Input.MouseButtonEventHandler(this.OnFieldNameDoubleClick);
			return;
			IL_1130:
			this.DataWideLTEHWEnableComp = (global::AcpUI.AcpCheckBox)target;
			return;
			IL_113D:
			this.LblDataWideMG90WirelessLTEFriendlyName_43786 = (global::AcpUI.AcpLabel)target;
			this.LblDataWideMG90WirelessLTEFriendlyName_43786.MouseDoubleClick += new global::System.Windows.Input.MouseButtonEventHandler(this.OnFieldNameDoubleClick);
			return;
			IL_1161:
			this.LblDataWideMG90WirelessVPNFriendlyName_43785 = (global::AcpUI.AcpLabel)target;
			this.LblDataWideMG90WirelessVPNFriendlyName_43785.MouseDoubleClick += new global::System.Windows.Input.MouseButtonEventHandler(this.OnFieldNameDoubleClick);
			return;
			IL_1185:
			num = (short)1848688375;
			short num3 = num;
			num = (short)138657527;
			switch ((num3 == num) ? 1 : 0)
			{
			case 0:
			case 2:
				IL_2E7F:
				this.LblDataWideGeneralICMPEcho_A8219 = (global::AcpUI.AcpLabel)target;
				this.LblDataWideGeneralICMPEcho_A8219.MouseDoubleClick += new global::System.Windows.Input.MouseButtonEventHandler(this.OnFieldNameDoubleClick);
				return;
			default:
				num = (short)1076166656;
				if (num != 0)
				{
				}
				this.CpyBtnDataWideExternalDataModemPort = (global::AcpUI.AcpCopyButton)target;
				return;
			}
			IL_11DE:
			this.DataWideLTEHWEnable = (global::AcpUI.AcpCheckBox)target;
			this.DataWideLTEHWEnable.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_1202:
			this.RTDBtnDataWideExternalDataModemVPNFriendlyName_43774 = (global::AcpUI.AcpRtdButton)target;
			return;
			IL_120F:
			this.DataWideNATListStaticNATIPAddress_A9181 = (global::AcpUI.AcpTextBox)target;
			this.DataWideNATListStaticNATIPAddress_A9181.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_1233:
			this.HLinkGeneral = (global::System.Windows.Documents.Hyperlink)target;
			this.HLinkGeneral.Click += this.HLinkClick;
			return;
			IL_1257:
			((global::Motorola.MackinawCPS.CoreFeatures.DataWide.PageDataWide)target).Loaded += this.OnLoaded;
			((global::Motorola.MackinawCPS.CoreFeatures.DataWide.PageDataWide)target).Unloaded += this.OnUnloaded;
			return;
			IL_1288:
			this.ExpanderDataWideDataModemTable = (global::AcpUI.AcpXamDataPresenter)target;
			return;
			IL_1295:
			this.CVBtnDataWideExternalDataModemType_42843 = (global::AcpUI.AcpCustomViewCheckBox)target;
			return;
			IL_12A2:
			this.LblDataWideWiFiNetworkSecurityType_42516 = (global::AcpUI.AcpLabel)target;
			this.LblDataWideWiFiNetworkSecurityType_42516.MouseDoubleClick += new global::System.Windows.Input.MouseButtonEventHandler(this.OnFieldNameDoubleClick);
			return;
			IL_12C6:
			this.LblDataWideLTEHWEnable = (global::AcpUI.AcpLabel)target;
			this.LblDataWideLTEHWEnable.MouseDoubleClick += new global::System.Windows.Input.MouseButtonEventHandler(this.OnFieldNameDoubleClick);
			return;
			IL_12EA:
			this.CVBtnDataWideExternalDataModemPort_42851 = (global::AcpUI.AcpCustomViewCheckBox)target;
			return;
			IL_12F7:
			this.DataWideGeneralPeerIPAddressAssignmentType2_A22377Comp = (global::AcpUI.AcpLabel)target;
			return;
			IL_1304:
			this.DataWideQuickTextMessageListQuickTextMessage_A8810Comp = (global::AcpUI.AcpLabel)target;
			return;
			IL_1311:
			this.LblDataWideEncryptedNetworkPassword_43361 = (global::AcpUI.AcpLabel)target;
			this.LblDataWideEncryptedNetworkPassword_43361.MouseDoubleClick += new global::System.Windows.Input.MouseButtonEventHandler(this.OnFieldNameDoubleClick);
			return;
			IL_1335:
			this.LblDataWideExternalDataModemType_43362 = (global::AcpUI.AcpLabel)target;
			this.LblDataWideExternalDataModemType_43362.MouseDoubleClick += new global::System.Windows.Input.MouseButtonEventHandler(this.OnFieldNameDoubleClick);
			return;
			IL_1359:
			this.LblDataWideLTEClass3AccessPointName_A42392 = (global::AcpUI.AcpLabel)target;
			this.LblDataWideLTEClass3AccessPointName_A42392.MouseDoubleClick += new global::System.Windows.Input.MouseButtonEventHandler(this.OnFieldNameDoubleClick);
			return;
			IL_137D:
			this.LblDataConfigDataWideMaxNumofNonTCPIPHCContexts_A36192 = (global::AcpUI.AcpLabel)target;
			this.LblDataConfigDataWideMaxNumofNonTCPIPHCContexts_A36192.MouseDoubleClick += new global::System.Windows.Input.MouseButtonEventHandler(this.OnFieldNameDoubleClick);
			return;
			IL_13A1:
			this.CVBtnDataWideMG90WirelessSatelliteEnable_43788 = (global::AcpUI.AcpCustomViewCheckBox)target;
			return;
			IL_13AE:
			this.RTDBtnDataWideExternalDataModemMG90SatelliteEnabled_43777 = (global::AcpUI.AcpRtdButton)target;
			return;
			IL_13BB:
			this.CpyBtnDataWideNATListLANPort_A8385 = (global::AcpUI.AcpCopyButton)target;
			return;
			IL_13C8:
			this.DataWideLTEModeChangeMaxDetachTime_A42208 = (global::AcpUI.AcpTextBoxSpinner)target;
			this.DataWideLTEModeChangeMaxDetachTime_A42208.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_13EC:
			this.DataWideWIFIEnable_42506Comp = (global::AcpUI.AcpCheckBox)target;
			return;
			IL_13F9:
			this.CVBtnDataWideMG90WirelessSatelliteFriendlyName_43787 = (global::AcpUI.AcpCustomViewCheckBox)target;
			return;
			IL_1406:
			this.DataWideExternalDataModemType_43362 = (global::AcpUI.AcpComboBox)target;
			this.DataWideExternalDataModemType_43362.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_142A:
			this.RTDBtnDataConfigDataWideMaxTimeBetweenFullHeaders_A36200 = (global::AcpUI.AcpRtdButton)target;
			return;
			IL_1437:
			this.CVBtnDataWideMG90WirelessLTEFriendlyName_43786 = (global::AcpUI.AcpCustomViewCheckBox)target;
			return;
			IL_1444:
			this.CpyBtnDataWideExternalDataModemSecurityType_43360 = (global::AcpUI.AcpCopyButton)target;
			return;
			IL_1451:
			this.DataWideExternalDataOORTime_43366Comp = (global::AcpUI.AcpLabel)target;
			return;
			IL_145E:
			this.LblDataWideExternalDataModemHiddenNetwork_44814 = (global::AcpUI.AcpLabel)target;
			this.LblDataWideExternalDataModemHiddenNetwork_44814.MouseDoubleClick += new global::System.Windows.Input.MouseButtonEventHandler(this.OnFieldNameDoubleClick);
			return;
			IL_1482:
			this.CpyBtnDataCfgDataWideTimeSourceVar_A36196 = (global::AcpUI.AcpCopyButton)target;
			return;
			IL_148F:
			this.CVBtnDataWideGeneralICMPEcho_A8219 = (global::AcpUI.AcpCustomViewCheckBox)target;
			return;
			IL_149C:
			this.CpyBtnDataWideLTEModeChangeMaxDetachTime_A42208 = (global::AcpUI.AcpCopyButton)target;
			return;
			IL_14A9:
			this.DataWideMG90WirelessVPNFriendlyName_43785Comp = (global::AcpUI.AcpLabel)target;
			return;
			IL_14B6:
			this.LblDataWideLabtoolDATA_CFGPacketDataActivateWaitTimerSec_A8686 = (global::AcpUI.AcpLabel)target;
			this.LblDataWideLabtoolDATA_CFGPacketDataActivateWaitTimerSec_A8686.MouseDoubleClick += new global::System.Windows.Input.MouseButtonEventHandler(this.OnFieldNameDoubleClick);
			return;
			IL_14DA:
			this.DataWideExternalDataModemWifiPowerupGuardTimeComp = (global::AcpUI.AcpLabel)target;
			return;
			IL_14E7:
			this.CpyBtnDataWideExternalDataModemType_42843 = (global::AcpUI.AcpCopyButton)target;
			return;
			IL_14F4:
			this.GrpBoxExpanderDataWideGeneralBluetoothDialUpNetworkingAddresses = (global::AcpUI.AcpGroupBox)target;
			return;
			IL_1501:
			this.CpyBtnDataWideMG90WirelessSatelliteFriendlyName_43787 = (global::AcpUI.AcpCopyButton)target;
			return;
			IL_150E:
			this.ExpanderDataWideWIFIGrid = (global::System.Windows.Controls.Grid)target;
			return;
			IL_151B:
			this.DataWideWiFiNetworkSecurityType_42516 = (global::AcpUI.AcpComboBox)target;
			this.DataWideWiFiNetworkSecurityType_42516.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_153F:
			this.LblDataWideVirtualPartnerGatewayHostname_43557 = (global::AcpUI.AcpLabel)target;
			this.LblDataWideVirtualPartnerGatewayHostname_43557.MouseDoubleClick += new global::System.Windows.Input.MouseButtonEventHandler(this.OnFieldNameDoubleClick);
			return;
			IL_1563:
			this.RTDBtnDataWideExternalDataModemOutOfRangeThreshold_42853 = (global::AcpUI.AcpRtdButton)target;
			return;
			IL_1570:
			this.DataWideGeneralSubscriberIPAddress1_A9222 = (global::AcpUI.AcpTextBox)target;
			this.DataWideGeneralSubscriberIPAddress1_A9222.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_1594:
			this.DataWideGeneralBTDUNSUIPAddress_A41120 = (global::AcpUI.AcpTextBox)target;
			this.DataWideGeneralBTDUNSUIPAddress_A41120.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_15B8:
			this.CVBtnDataWideGeneralPeerIPAddressAssignmentType2_A22377 = (global::AcpUI.AcpCustomViewCheckBox)target;
			return;
			IL_15C5:
			this.DataWideExternalDataModemOpenTime_43367 = (global::AcpUI.AcpTextBoxSpinner)target;
			this.DataWideExternalDataModemOpenTime_43367.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_15E9:
			this.LblDataConfigDataWideMaxNumofTCPIPHCContexts_A36194 = (global::AcpUI.AcpLabel)target;
			this.LblDataConfigDataWideMaxNumofTCPIPHCContexts_A36194.MouseDoubleClick += new global::System.Windows.Input.MouseButtonEventHandler(this.OnFieldNameDoubleClick);
			return;
			IL_160D:
			this.CVBtnDataWideMG90WirelessVPNFriendlyName_43785 = (global::AcpUI.AcpCustomViewCheckBox)target;
			return;
			IL_161A:
			this.CpyBtnDataWideExternalDataModemMG90SatelliteFriendlyName_43776 = (global::AcpUI.AcpCopyButton)target;
			return;
			IL_1627:
			this.SensorMeasurementReportingUDPPort_A43022 = (global::AcpUI.AcpTextBoxSpinner)target;
			this.SensorMeasurementReportingUDPPort_A43022.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_164B:
			this.DataWidePOP25AutoResetEnable_A37221Comp = (global::AcpUI.AcpCheckBox)target;
			return;
			IL_1658:
			this.CVBtnDataWideExternalDataModemOpenMaxGuardTime_42856 = (global::AcpUI.AcpCustomViewCheckBox)target;
			return;
			IL_1665:
			this.RTDBtnDataCfgDataWideMaxSetupTimeAllowedforCCA_A36193 = (global::AcpUI.AcpRtdButton)target;
			return;
			IL_1672:
			this.RandomAccessAckTimerMsec_42016Comp = (global::AcpUI.AcpLabel)target;
			return;
			IL_167F:
			this.CpyBtnDataWideWiFiNetworkPriority_42512 = (global::AcpUI.AcpCopyButton)target;
			return;
			IL_168C:
			this.RTDBtnDataWideLTEModeChangeMaxDetachTime_A42208 = (global::AcpUI.AcpRtdButton)target;
			return;
			IL_1699:
			this.CpyBtnDataWideMG90WirelessVPNFriendlyName_43785 = (global::AcpUI.AcpCopyButton)target;
			return;
			IL_16A6:
			this.DataWideLabtoolDATA_CFGPacketDataActivateWaitTimerSec_A8686Comp = (global::AcpUI.AcpLabel)target;
			return;
			IL_16B3:
			this.CpyBtnDataWideLabtoolDATA_CFGOTAPDefaultInactivityTimer_A8668 = (global::AcpUI.AcpCopyButton)target;
			return;
			IL_16C0:
			this.DataWideWIFIAllowUserControl = (global::AcpUI.AcpCheckBox)target;
			this.DataWideWIFIAllowUserControl.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_16E4:
			this.CVBtnModemConnectionType_43350 = (global::AcpUI.AcpCustomViewCheckBox)target;
			return;
			IL_16F1:
			this.CpyBtnDataWideLabtoolDATA_CFGPacketDataActivateWaitTimerSec_A8686 = (global::AcpUI.AcpCopyButton)target;
			return;
			IL_16FE:
			this.DataWideDataUserListDataUserInformation_A7800_Col = (global::Infragistics.Windows.DataPresenter.UnboundField)target;
			return;
			IL_170B:
			this.DataWideExternalDataModemOpenTime_43367_Col = (global::Infragistics.Windows.DataPresenter.UnboundField)target;
			return;
			IL_1718:
			this.LblDataWideLTEModeChangeMaxDetachTime_A42208 = (global::AcpUI.AcpLabel)target;
			this.LblDataWideLTEModeChangeMaxDetachTime_A42208.MouseDoubleClick += new global::System.Windows.Input.MouseButtonEventHandler(this.OnFieldNameDoubleClick);
			return;
			IL_173C:
			this.GrpBoxExpanderDataWideGeneralPseudo3 = (global::AcpUI.AcpGroupBox)target;
			return;
			IL_1749:
			this.DataWideExternalDataModemVPNFriendlyName_43774 = (global::AcpUI.AcpTextBox)target;
			this.DataWideExternalDataModemVPNFriendlyName_43774.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_176D:
			this.DataWideKVLKeyloadingUDPPort_43205Comp = (global::AcpUI.AcpLabel)target;
			return;
			IL_177A:
			this.DataWideGeneralICMPEcho_A8219Comp = (global::AcpUI.AcpCheckBox)target;
			return;
			IL_1787:
			this.CVBtnDataWideLTEAPCOAvalancheTime_A42204 = (global::AcpUI.AcpCustomViewCheckBox)target;
			return;
			IL_1794:
			this.RTDBtnAcknowledgedWeaponFiredEventReportingEnable_43582 = (global::AcpUI.AcpRtdButton)target;
			return;
			IL_17A1:
			this.LblDataWideGeneralBTDUNPeerIPAddressAssignmentType_A41124 = (global::AcpUI.AcpLabel)target;
			this.LblDataWideGeneralBTDUNPeerIPAddressAssignmentType_A41124.MouseDoubleClick += new global::System.Windows.Input.MouseButtonEventHandler(this.OnFieldNameDoubleClick);
			return;
			IL_17C5:
			this.LblDataWideLTEOperation_A42215 = (global::AcpUI.AcpLabel)target;
			this.LblDataWideLTEOperation_A42215.MouseDoubleClick += new global::System.Windows.Input.MouseButtonEventHandler(this.OnFieldNameDoubleClick);
			return;
			IL_17E9:
			this.RTDBtnDataWideGeneralDeleteMessagesOnSessionEnd_41308 = (global::AcpUI.AcpRtdButton)target;
			return;
			IL_17F6:
			this.DataWideNATListWANPort_A9677 = (global::AcpUI.AcpTextBoxSpinner)target;
			this.DataWideNATListWANPort_A9677.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_181A:
			this.CpyBtnDataConfigDataWideMaxHeaderSizeAllowedForCompression_A36206 = (global::AcpUI.AcpCopyButton)target;
			return;
			IL_1827:
			this.CpyBtnDataWideLTEOpenMaxGuardTime_A42391 = (global::AcpUI.AcpCopyButton)target;
			return;
			IL_1834:
			this.DataWideExternalDataModemSecurityType_43360Comp = (global::AcpUI.AcpLabel)target;
			return;
			IL_1841:
			this.LblDataWideExternalDataModemVPNTunnel_43024 = (global::AcpUI.AcpLabel)target;
			this.LblDataWideExternalDataModemVPNTunnel_43024.MouseDoubleClick += new global::System.Windows.Input.MouseButtonEventHandler(this.OnFieldNameDoubleClick);
			return;
			IL_1865:
			this.RTDBtnDirectTMSContentDisplay_42323 = (global::AcpUI.AcpRtdButton)target;
			return;
			IL_1872:
			this.SensorMeasurementReportingUDPPort_A43022Comp = (global::AcpUI.AcpLabel)target;
			return;
			IL_187F:
			this.DataWideDVRSActWaitTime_A40128Comp = (global::AcpUI.AcpLabel)target;
			return;
			IL_188C:
			this.LblDataWideGeneralDeleteMessagesOnSessionEnd_41308 = (global::AcpUI.AcpLabel)target;
			this.LblDataWideGeneralDeleteMessagesOnSessionEnd_41308.MouseDoubleClick += new global::System.Windows.Input.MouseButtonEventHandler(this.OnFieldNameDoubleClick);
			return;
			IL_18B0:
			this.LblDataConfigDataWideMaxTimeBetweenFullHeaders_A36200 = (global::AcpUI.AcpLabel)target;
			this.LblDataConfigDataWideMaxTimeBetweenFullHeaders_A36200.MouseDoubleClick += new global::System.Windows.Input.MouseButtonEventHandler(this.OnFieldNameDoubleClick);
			return;
			IL_18D4:
			this.DataWideExternalDataModemNetworkSsid_43358Comp = (global::AcpUI.AcpLabel)target;
			return;
			IL_18E1:
			this.ExpanderDataWideDataModemTableSRecView = (global::AcpUI.AcpGroupBox)target;
			return;
			IL_18EE:
			this.DataWideExternalDataModemVPNTunnel_43024Comp = (global::AcpUI.AcpLabel)target;
			return;
			IL_18FB:
			this.DataWideNATListLANPort_A8385 = (global::AcpUI.AcpTextBoxSpinner)target;
			this.DataWideNATListLANPort_A8385.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_191F:
			this.CpyBtnDataWideExternalDataModemMG90SatelliteEnabled_43777 = (global::AcpUI.AcpCopyButton)target;
			return;
			IL_192C:
			this.LblDataWideLTEOutOfRangeThresholdTime_A42206 = (global::AcpUI.AcpLabel)target;
			this.LblDataWideLTEOutOfRangeThresholdTime_A42206.MouseDoubleClick += new global::System.Windows.Input.MouseButtonEventHandler(this.OnFieldNameDoubleClick);
			return;
			IL_1950:
			this.DataConfigDataWideMaxNumofNonTCPIPHCContexts_A36192Comp = (global::AcpUI.AcpLabel)target;
			return;
			IL_195D:
			this.LblDataWideExternalTextMessagingBroadcast_42418 = (global::AcpUI.AcpLabel)target;
			this.LblDataWideExternalTextMessagingBroadcast_42418.MouseDoubleClick += new global::System.Windows.Input.MouseButtonEventHandler(this.OnFieldNameDoubleClick);
			return;
			IL_1981:
			this.DataWideQuickTextMessageListQuickTextMessage_A8810 = (global::AcpUI.AcpTextBox)target;
			this.DataWideQuickTextMessageListQuickTextMessage_A8810.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_19A5:
			this.ThemeBaseObj = (global::AcpUI.Common.AcpThemeBase)target;
			return;
			IL_19B2:
			this.DataWideLabtoolDeviceProvisioningServiceURI_43555 = (global::AcpUI.AcpTextBox)target;
			this.DataWideLabtoolDeviceProvisioningServiceURI_43555.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_19D6:
			this.CVBtnDataWideGeneralBTDUNPeerIPAddress_A41123 = (global::AcpUI.AcpCustomViewCheckBox)target;
			return;
			IL_19E3:
			this.CVBtnDataWideNATListWANPort_A9677 = (global::AcpUI.AcpCustomViewCheckBox)target;
			return;
			IL_19F0:
			this.CVBtnDataWideExternalDataModemLTEFriendlyName_43775 = (global::AcpUI.AcpCustomViewCheckBox)target;
			return;
			IL_19FD:
			this.DataConfigDataWideMaxNumOfCompreHeadersBetweenFullHeaders_A36205Comp = (global::AcpUI.AcpLabel)target;
			return;
			IL_1A0A:
			this.DataWideIdentityManagementGatewayHostname_43556Comp = (global::AcpUI.AcpLabel)target;
			return;
			IL_1A17:
			this.CpyBtnDataWideGeneralDVRIPAddress_A41818 = (global::AcpUI.AcpCopyButton)target;
			return;
			IL_1A24:
			this.LblDataWideLabtoolDATA_CFGOTAPDefaultInactivityTimer_A8668 = (global::AcpUI.AcpLabel)target;
			this.LblDataWideLabtoolDATA_CFGOTAPDefaultInactivityTimer_A8668.MouseDoubleClick += new global::System.Windows.Input.MouseButtonEventHandler(this.OnFieldNameDoubleClick);
			return;
			IL_1A48:
			this.CpyBtnDataWideExternalDataModemType_43362 = (global::AcpUI.AcpCopyButton)target;
			return;
			IL_1A55:
			this.DataWideWIFINetworkHidden_Col = (global::Infragistics.Windows.DataPresenter.UnboundField)target;
			return;
			IL_1A62:
			this.CpyBtnDataWideMG90WirelessLTEFriendlyName_43786 = (global::AcpUI.AcpCopyButton)target;
			return;
			IL_1A6F:
			this.RTDBtnDataWideGeneralPeerIPAddressAssignmentType2_A22377 = (global::AcpUI.AcpRtdButton)target;
			return;
			IL_1A7C:
			this.DataWideGeneralBroadbandCheckbackTime_A42862Comp = (global::AcpUI.AcpLabel)target;
			return;
			IL_1A89:
			this.ExpanderDataWideNATListTableSRecView = (global::AcpUI.AcpGroupBox)target;
			return;
			IL_1A96:
			this.RTDBtnDataWidePOP25OTAPIndications_A8670 = (global::AcpUI.AcpRtdButton)target;
			return;
			IL_1AA3:
			this.CVBtnDataWideExternalDataModemNetworkPriority_43358 = (global::AcpUI.AcpCustomViewCheckBox)target;
			return;
			IL_1AB0:
			this.RTDBtnDataWideVirtualPartnerGatewayHostname_43557 = (global::AcpUI.AcpRtdButton)target;
			return;
			IL_1ABD:
			this.DataWideGeneralSubscriberIPAddress1_A9222Comp = (global::AcpUI.AcpLabel)target;
			return;
			IL_1ACA:
			this.LblDataWideDataModemPassword_A42848 = (global::AcpUI.AcpLabel)target;
			this.LblDataWideDataModemPassword_A42848.MouseDoubleClick += new global::System.Windows.Input.MouseButtonEventHandler(this.OnFieldNameDoubleClick);
			return;
			IL_1AEE:
			this.DataWideNATListWANPort_A9677Comp = (global::AcpUI.AcpLabel)target;
			return;
			IL_1AFB:
			this.RTDBtnDataWideExternalDataModemPowerupMaxGuardTime_42855 = (global::AcpUI.AcpRtdButton)target;
			return;
			IL_1B08:
			this.CpyBtnDataWideExternalDataModemPowerupMaxGuardTime_42855 = (global::AcpUI.AcpCopyButton)target;
			return;
			IL_1B15:
			this.CVBtnDataConfigDataWideMaxNumofTCPIPHCContexts_A36194 = (global::AcpUI.AcpCustomViewCheckBox)target;
			return;
			IL_1B22:
			this.CpyBtnLabtoolContextActivationHoldoffTimerSec = (global::AcpUI.AcpCopyButton)target;
			return;
			IL_1B2F:
			this.RTDBtnDataWideLabtoolDeviceProvisioningServiceURI_43555 = (global::AcpUI.AcpRtdButton)target;
			return;
			IL_1B3C:
			this.LblDataWideNATListStaticNATIPAddress_A9181 = (global::AcpUI.AcpLabel)target;
			this.LblDataWideNATListStaticNATIPAddress_A9181.MouseDoubleClick += new global::System.Windows.Input.MouseButtonEventHandler(this.OnFieldNameDoubleClick);
			return;
			IL_1B60:
			this.ExpanderDataWideNATList = (global::AcpUI.AcpExpander)target;
			return;
			IL_1B6D:
			this.RTDBtnDataConfigDataWideMaxNumofTCPIPHCContexts_A36194 = (global::AcpUI.AcpRtdButton)target;
			return;
			IL_1B7A:
			this.DataWideWiFiNetworkEncryptedNetworkPassword_42517_Col = (global::Infragistics.Windows.DataPresenter.UnboundField)target;
			return;
			IL_1B87:
			this.DataConfigDataWideMaxNumofTCPIPHCContexts_A36194Comp = (global::AcpUI.AcpLabel)target;
			return;
			IL_1B94:
			this.gridExpanderDataWideConfiguredNetworksListSRecView = (global::System.Windows.Controls.Grid)target;
			return;
			IL_1BA1:
			this.GrpBoxExpanderDataWideGeneralPseudo0 = (global::AcpUI.AcpGroupBox)target;
			return;
			IL_1BAE:
			this.ExpanderDataWideWIFI = (global::AcpUI.AcpExpander)target;
			return;
			IL_1BBB:
			this.RTDBtnDataWideLTELTECheckbackTime_A42205 = (global::AcpUI.AcpRtdButton)target;
			return;
			IL_1BC8:
			this.RTDBtnDataWideGeneralDVRIPAddress_A41818 = (global::AcpUI.AcpRtdButton)target;
			return;
			IL_1BD5:
			this.DataWideExternalDataVpnTunnel_43365 = (global::AcpUI.AcpTextBoxSpinner)target;
			this.DataWideExternalDataVpnTunnel_43365.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_1BF9:
			this.LblDataWideGeneralBTDUNSUIPAddress_A41120 = (global::AcpUI.AcpLabel)target;
			this.LblDataWideGeneralBTDUNSUIPAddress_A41120.MouseDoubleClick += new global::System.Windows.Input.MouseButtonEventHandler(this.OnFieldNameDoubleClick);
			return;
			IL_1C1D:
			this.RTDBtnDataConfigDataWideMaxNumofNonTCPIPHCContexts_A36192 = (global::AcpUI.AcpRtdButton)target;
			return;
			IL_1C2A:
			this.CpyBtnDataConfigDataWideMaxNumofNonTCPIPHCContexts_A36192 = (global::AcpUI.AcpCopyButton)target;
			return;
			IL_1C37:
			this.DataWideExternalDataModemVPNTunnel_43024 = (global::AcpUI.AcpTextBoxSpinner)target;
			this.DataWideExternalDataModemVPNTunnel_43024.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_1C5B:
			this.LblDataWideGeneralContextDeactivationAlertTone_A7715 = (global::AcpUI.AcpLabel)target;
			this.LblDataWideGeneralContextDeactivationAlertTone_A7715.MouseDoubleClick += new global::System.Windows.Input.MouseButtonEventHandler(this.OnFieldNameDoubleClick);
			return;
			IL_1C7F:
			this.CVBtnDataWideLabtoolDeviceProvisioningServiceURI_43555 = (global::AcpUI.AcpCustomViewCheckBox)target;
			return;
			IL_1C8C:
			this.LblDataWideWIFIEnable_42506 = (global::AcpUI.AcpLabel)target;
			this.LblDataWideWIFIEnable_42506.MouseDoubleClick += new global::System.Windows.Input.MouseButtonEventHandler(this.OnFieldNameDoubleClick);
			return;
			IL_1CB0:
			this.RTDBtnDataWideDataUserListDataUserInformation_A7800 = (global::AcpUI.AcpRtdButton)target;
			return;
			IL_1CBD:
			this.DataWideLTEAPCOAvalancheTime_A42204 = (global::AcpUI.AcpTextBoxSpinner)target;
			this.DataWideLTEAPCOAvalancheTime_A42204.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_1CE1:
			this.DataWideExternalDataModemType_42843 = (global::AcpUI.AcpComboBox)target;
			this.DataWideExternalDataModemType_42843.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_1D05:
			this.RTDBtnDataWideWiFiNetworkSecurityType_42516 = (global::AcpUI.AcpRtdButton)target;
			return;
			IL_1D12:
			this.RecNavToolbarExpanderDataWideQuickTextMessageListTable = (global::AcpUI.AcpRecNavToolbar)target;
			this.RecNavToolbarExpanderDataWideQuickTextMessageListTable.ModeClick += this.OnModeClick;
			return;
			IL_1D36:
			this.CVBtnDataWideExternalDataModemPowerupMaxGuardTime_42855 = (global::AcpUI.AcpCustomViewCheckBox)target;
			return;
			IL_1D43:
			this.LblRandomAccessAckTimerMsec_42016 = (global::AcpUI.AcpLabel)target;
			this.LblRandomAccessAckTimerMsec_42016.MouseDoubleClick += new global::System.Windows.Input.MouseButtonEventHandler(this.OnFieldNameDoubleClick);
			return;
			IL_1D67:
			this.DataWideLTEOutOfRangeThresholdTime_A42206 = (global::AcpUI.AcpTextBoxSpinner)target;
			this.DataWideLTEOutOfRangeThresholdTime_A42206.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_1D8B:
			this.CVBtnDataWideNATListStaticNATIPAddress_A9181 = (global::AcpUI.AcpCustomViewCheckBox)target;
			return;
			IL_1D98:
			this.RecNavToolbarExpanderDataWideDataUserListTable = (global::AcpUI.AcpRecNavToolbar)target;
			this.RecNavToolbarExpanderDataWideDataUserListTable.ModeClick += this.OnModeClick;
			return;
			IL_1DBC:
			this.CpyBtnDataWideGeneralContextDeactivationAlertTone_A7715 = (global::AcpUI.AcpCopyButton)target;
			return;
			IL_1DC9:
			this.GrpBoxExpanderDataWideExternalDataModemPseudo1 = (global::AcpUI.AcpGroupBox)target;
			return;
			IL_1DD6:
			this.LblDataWideExternalDataModemVPNFriendlyName_43774 = (global::AcpUI.AcpLabel)target;
			this.LblDataWideExternalDataModemVPNFriendlyName_43774.MouseDoubleClick += new global::System.Windows.Input.MouseButtonEventHandler(this.OnFieldNameDoubleClick);
			return;
			IL_1DFA:
			this.DataWideLTELTECheckbackTime_A42205 = (global::AcpUI.AcpTextBoxSpinner)target;
			this.DataWideLTELTECheckbackTime_A42205.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_1E1E:
			this.CpyBtnDataConfigDataWideMaxNumOfCompreHeadersBetweenFullHeaders_A36205 = (global::AcpUI.AcpCopyButton)target;
			return;
			IL_1E2B:
			this.RTDBtnDataWideExternalDataModemMG90SatelliteFriendlyName_43776 = (global::AcpUI.AcpRtdButton)target;
			return;
			IL_1E38:
			this.DataWideGeneralPeerIPAddressAssignmentType1_A22376Comp = (global::AcpUI.AcpLabel)target;
			return;
			IL_1E45:
			this.RTDBtnDataWideLTEClass3AccessPointName_A42392 = (global::AcpUI.AcpRtdButton)target;
			return;
			IL_1E52:
			this.RTDBtnDataWideWIFIAllowUserControl = (global::AcpUI.AcpRtdButton)target;
			return;
			IL_1E5F:
			this.CpyBtnDataWideExternalDataModemWifiPowerupGuardTime = (global::AcpUI.AcpCopyButton)target;
			return;
			IL_1E6C:
			this.CpyBtnDataConfigDataWideMaxTimeBetweenFullHeaders_A36200 = (global::AcpUI.AcpCopyButton)target;
			return;
			IL_1E79:
			this.CVBtnDataWideVirtualPartnerGatewayHostname_43557 = (global::AcpUI.AcpCustomViewCheckBox)target;
			return;
			IL_1E86:
			this.DataWideExternalDataVpnTunnel_43365Comp = (global::AcpUI.AcpLabel)target;
			return;
			IL_1E93:
			this.LblDataCfgDataWideMaxSetupTimeAllowedforCCA_A36193 = (global::AcpUI.AcpLabel)target;
			this.LblDataCfgDataWideMaxSetupTimeAllowedforCCA_A36193.MouseDoubleClick += new global::System.Windows.Input.MouseButtonEventHandler(this.OnFieldNameDoubleClick);
			return;
			IL_1EB7:
			this.CpyBtnDataWideWIFIOTAPTCPPort_42627 = (global::AcpUI.AcpCopyButton)target;
			return;
			IL_1EC4:
			this.DataWideExternalDataVpnTunnel_43365_Col = (global::Infragistics.Windows.DataPresenter.UnboundField)target;
			return;
			IL_1ED1:
			this.DataWideEncryptedModemPassword_43361 = (global::AcpUI.AcpPasswordEyeBox)target;
			this.DataWideEncryptedModemPassword_43361.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_1EF5:
			this.LblDataWideExternalDataModemPowerupMaxGuardTime_42855 = (global::AcpUI.AcpLabel)target;
			this.LblDataWideExternalDataModemPowerupMaxGuardTime_42855.MouseDoubleClick += new global::System.Windows.Input.MouseButtonEventHandler(this.OnFieldNameDoubleClick);
			return;
			IL_1F19:
			this.CpyBtnAcknowledgedWeaponFiredEventReportingEnable_43582 = (global::AcpUI.AcpCopyButton)target;
			return;
			IL_1F26:
			this.DataWideLTEOffMaxDetachTime_A42207 = (global::AcpUI.AcpTextBoxSpinner)target;
			this.DataWideLTEOffMaxDetachTime_A42207.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_1F4A:
			this.DataWideIdentityManagementGatewayHostname_43556 = (global::AcpUI.AcpTextBox)target;
			this.DataWideIdentityManagementGatewayHostname_43556.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_1F6E:
			this.DataWideExternalDataModemHiddenNetwork_44814Comp = (global::AcpUI.AcpLabel)target;
			return;
			IL_1F7B:
			this.DataWideExternalDataModemVPNFriendlyName_43774Comp = (global::AcpUI.AcpLabel)target;
			return;
			IL_1F88:
			this.CpyBtnDataWideGeneralMobileSubIPAddress_A41819 = (global::AcpUI.AcpCopyButton)target;
			return;
			IL_1F95:
			this.CVBtnDataWideGeneralContextDeactivationAlertTone_A7715 = (global::AcpUI.AcpCustomViewCheckBox)target;
			return;
			IL_1FA2:
			this.CVBtnDataWideQuickTextMessageListQuickTextMessage_A8810 = (global::AcpUI.AcpCustomViewCheckBox)target;
			return;
			IL_1FAF:
			this.DataWideExternalDataModemNetworkPriority_43358_Col = (global::Infragistics.Windows.DataPresenter.UnboundField)target;
			return;
			IL_1FBC:
			this.CVBtnDataWideDataOnRoaming_A42216 = (global::AcpUI.AcpCustomViewCheckBox)target;
			return;
			IL_1FC9:
			this.LblDataWideDVRSActWaitTime_A40128 = (global::AcpUI.AcpLabel)target;
			this.LblDataWideDVRSActWaitTime_A40128.MouseDoubleClick += new global::System.Windows.Input.MouseButtonEventHandler(this.OnFieldNameDoubleClick);
			return;
			IL_1FED:
			this.DataWideLTEOperation_A42215 = (global::AcpUI.AcpCheckBox)target;
			this.DataWideLTEOperation_A42215.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_2011:
			this.LblModemConnectionType_43350 = (global::AcpUI.AcpLabel)target;
			this.LblModemConnectionType_43350.MouseDoubleClick += new global::System.Windows.Input.MouseButtonEventHandler(this.OnFieldNameDoubleClick);
			return;
			IL_2035:
			this.RTDBtnDataWideExternalDataModemWifiPowerupGuardTime = (global::AcpUI.AcpRtdButton)target;
			return;
			IL_2042:
			this.CpyBtnDataWideExternalDataModemOpenTime_43367 = (global::AcpUI.AcpCopyButton)target;
			return;
			IL_204F:
			this.CVBtnDataWideLTEModeChangeMaxDetachTime_A42208 = (global::AcpUI.AcpCustomViewCheckBox)target;
			return;
			IL_205C:
			this.RTDBtnDataWideLTEOpenMaxGuardTime_A42391 = (global::AcpUI.AcpRtdButton)target;
			return;
			IL_2069:
			this.DataConfigDataWideMaxNumofNonTCPIPHCContexts_A36192 = (global::AcpUI.AcpTextBoxSpinner)target;
			this.DataConfigDataWideMaxNumofNonTCPIPHCContexts_A36192.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_208D:
			this.RTDBtnDataWideExternalDataModemOpenTime_43367 = (global::AcpUI.AcpRtdButton)target;
			return;
			IL_209A:
			this.DataWideLTELTECheckbackTime_A42205Comp = (global::AcpUI.AcpLabel)target;
			return;
			IL_20A7:
			this.CVBtnDataWideLTEOpenMaxGuardTime_A42391 = (global::AcpUI.AcpCustomViewCheckBox)target;
			return;
			IL_20B4:
			this.DataWidePOP25AutoResetEnable_A37221 = (global::AcpUI.AcpCheckBox)target;
			this.DataWidePOP25AutoResetEnable_A37221.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_20D8:
			this.DataWideNATListStaticNATIPAddress_A9181_Col = (global::Infragistics.Windows.DataPresenter.UnboundField)target;
			return;
			IL_20E5:
			this.LblDataWideLTEAPCOAvalancheTime_A42204 = (global::AcpUI.AcpLabel)target;
			this.LblDataWideLTEAPCOAvalancheTime_A42204.MouseDoubleClick += new global::System.Windows.Input.MouseButtonEventHandler(this.OnFieldNameDoubleClick);
			return;
			IL_2109:
			this.DataWideExternalDataModemHiddenNetwork_44814 = (global::AcpUI.AcpCheckBox)target;
			this.DataWideExternalDataModemHiddenNetwork_44814.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_212D:
			this.LblDataWideExternalDataModemPort_42851 = (global::AcpUI.AcpLabel)target;
			this.LblDataWideExternalDataModemPort_42851.MouseDoubleClick += new global::System.Windows.Input.MouseButtonEventHandler(this.OnFieldNameDoubleClick);
			return;
			IL_2151:
			this.ExpanderDataWideDataModemTableGrid = (global::System.Windows.Controls.Grid)target;
			return;
			IL_215E:
			this.ExpanderDataWideQuickTextMessageListTableTableView = (global::AcpUI.AcpGroupBox)target;
			return;
			IL_216B:
			this.DataWideExternalDataModemMG90SatelliteEnabled_43777Comp = (global::AcpUI.AcpCheckBox)target;
			return;
			IL_2178:
			this.DataWideExternalDataModemPortComp = (global::AcpUI.AcpLabel)target;
			return;
			IL_2185:
			this.LblDataWideExternalDataModemWifiPowerupGuardTime = (global::AcpUI.AcpLabel)target;
			this.LblDataWideExternalDataModemWifiPowerupGuardTime.MouseDoubleClick += new global::System.Windows.Input.MouseButtonEventHandler(this.OnFieldNameDoubleClick);
			return;
			IL_21A9:
			this.LblSensorMeasurementReporting_A43021 = (global::AcpUI.AcpLabel)target;
			this.LblSensorMeasurementReporting_A43021.MouseDoubleClick += new global::System.Windows.Input.MouseButtonEventHandler(this.OnFieldNameDoubleClick);
			return;
			IL_21CD:
			this.CpyBtnSensorMeasurementReportingUDPPort_A43022 = (global::AcpUI.AcpCopyButton)target;
			return;
			IL_21DA:
			this.RTDBtnDataWideDataModemPassword_A42848 = (global::AcpUI.AcpRtdButton)target;
			return;
			IL_21E7:
			this.RTDBtnDataWideGeneralICMPEcho_A8219 = (global::AcpUI.AcpRtdButton)target;
			return;
			IL_21F4:
			this.LblDataWideExternalDataModemType_42843 = (global::AcpUI.AcpLabel)target;
			this.LblDataWideExternalDataModemType_42843.MouseDoubleClick += new global::System.Windows.Input.MouseButtonEventHandler(this.OnFieldNameDoubleClick);
			return;
			IL_2218:
			this.DataWideDataUserListDataUserInformation_A7800Comp = (global::AcpUI.AcpLabel)target;
			return;
			IL_2225:
			this.CVBtnDataWideWIFIEnable_42506 = (global::AcpUI.AcpCustomViewCheckBox)target;
			return;
			IL_2232:
			this.MyStackPanel = (global::System.Windows.Controls.StackPanel)target;
			return;
			IL_223F:
			this.DataWideWIFIAllowUserControlComp = (global::AcpUI.AcpCheckBox)target;
			return;
			IL_224C:
			this.RTDBtnDataWideLTEOutOfRangeThresholdTime_A42206 = (global::AcpUI.AcpRtdButton)target;
			return;
			IL_2259:
			this.HLinkPortConfiguration = (global::System.Windows.Documents.Hyperlink)target;
			this.HLinkPortConfiguration.Click += this.HLinkClick;
			return;
			IL_227D:
			this.CpyBtnDataWideLabtoolDeviceProvisioningServiceURI_43555 = (global::AcpUI.AcpCopyButton)target;
			return;
			IL_228A:
			this.ExpanderDataWideQuickTextMessageListTable = (global::AcpUI.AcpXamDataPresenter)target;
			return;
			IL_2297:
			this.ExpanderDataWideConfiguredNetworksList = (global::AcpUI.AcpXamDataPresenter)target;
			return;
			IL_22A4:
			this.DataWideGeneralSNMPTraps_A9166Comp = (global::AcpUI.AcpCheckBox)target;
			return;
			IL_22B1:
			this.DataWideGeneralBTDUNPeerIPAddress_A41123Comp = (global::AcpUI.AcpLabel)target;
			return;
			IL_22BE:
			this.CpyBtnDataWideLTEOutOfRangeThresholdTime_A42206 = (global::AcpUI.AcpCopyButton)target;
			return;
			IL_22CB:
			this.RTDBtnDataWideWIFIEnable_42506 = (global::AcpUI.AcpRtdButton)target;
			return;
			IL_22D8:
			this.CpyBtnDataWideWIFIAllowUserControl = (global::AcpUI.AcpCopyButton)target;
			return;
			IL_22E5:
			this.DataWideExternalDataModemMG90SatelliteFriendlyName_43776 = (global::AcpUI.AcpTextBox)target;
			this.DataWideExternalDataModemMG90SatelliteFriendlyName_43776.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_2309:
			this.DataWideGeneralPeerIPAddressAssignmentType1_A22376 = (global::AcpUI.AcpComboBox)target;
			this.DataWideGeneralPeerIPAddressAssignmentType1_A22376.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_232D:
			this.LblLabtoolDefaultReadyTimerSec = (global::AcpUI.AcpLabel)target;
			this.LblLabtoolDefaultReadyTimerSec.MouseDoubleClick += new global::System.Windows.Input.MouseButtonEventHandler(this.OnFieldNameDoubleClick);
			return;
			IL_2351:
			this.DataWideLTEModeChangeMaxDetachTime_A42208Comp = (global::AcpUI.AcpLabel)target;
			return;
			IL_235E:
			this.RTDBtnDataWideExternalTextMessagingBroadcast_42418 = (global::AcpUI.AcpRtdButton)target;
			return;
			IL_236B:
			this.RTDBtnRandomAccessAckTimerMsec_42016 = (global::AcpUI.AcpRtdButton)target;
			return;
			IL_2378:
			this.CVBtnDataWideExternalDataModemSecurityType_43360 = (global::AcpUI.AcpCustomViewCheckBox)target;
			return;
			IL_2385:
			this.CVBtnDataConfDataWidePortConAuthenticationUDPPort_A37608 = (global::AcpUI.AcpCustomViewCheckBox)target;
			return;
			IL_2392:
			this.HLinkNATList = (global::System.Windows.Documents.Hyperlink)target;
			this.HLinkNATList.Click += this.HLinkClick;
			return;
			IL_23B6:
			this.CVBtnDataWideGeneralPeerIPAddress1_A8524 = (global::AcpUI.AcpCustomViewCheckBox)target;
			return;
			IL_23C3:
			this.DataWideEncryptedModemPassword_43361Comp = (global::AcpUI.AcpLabel)target;
			return;
			IL_23D0:
			this.RTDBtnDataWideLTEOffMaxDetachTime_A42207 = (global::AcpUI.AcpRtdButton)target;
			return;
			IL_23DD:
			this.RTDBtnDataWidePOP25OTAPRejectEnable_A8671 = (global::AcpUI.AcpRtdButton)target;
			return;
			IL_23EA:
			this.CVBtnLabtoolContextActivationHoldoffTimerSec = (global::AcpUI.AcpCustomViewCheckBox)target;
			return;
			IL_23F7:
			this.RTDBtnDataConfigDataWideMaxHeaderSizeAllowedForCompression_A36206 = (global::AcpUI.AcpRtdButton)target;
			return;
			IL_2404:
			this.ExpanderDataWideDataUserListTable = (global::AcpUI.AcpXamDataPresenter)target;
			return;
			IL_2411:
			this.CVBtnDataWideExternalDataModemVPNTunnel_43024 = (global::AcpUI.AcpCustomViewCheckBox)target;
			return;
			IL_241E:
			this.CVBtnCloudRegion_43554 = (global::AcpUI.AcpCustomViewCheckBox)target;
			return;
			IL_242B:
			this.CpyBtnDataWideExternalDataModemOpenMaxGuardTime_42856 = (global::AcpUI.AcpCopyButton)target;
			return;
			IL_2438:
			this.LblAcknowledgedWeaponFiredEventReportingEnable_43582 = (global::AcpUI.AcpLabel)target;
			this.LblAcknowledgedWeaponFiredEventReportingEnable_43582.MouseDoubleClick += new global::System.Windows.Input.MouseButtonEventHandler(this.OnFieldNameDoubleClick);
			return;
			IL_245C:
			this.DataWideMG90WirelessVPNFriendlyName_43785_Col = (global::Infragistics.Windows.DataPresenter.UnboundField)target;
			return;
			IL_2469:
			this.CVBtnDataWideLabtoolDeviceProvisioningServiceIDScope_43553 = (global::AcpUI.AcpCustomViewCheckBox)target;
			return;
			IL_2476:
			this.DataWideQuickTextMessageListQuickTextMessage_A8810_Col = (global::Infragistics.Windows.DataPresenter.UnboundField)target;
			return;
			IL_2483:
			this.DataWideLTEClass3AccessPointName_A42392 = (global::AcpUI.AcpTextBox)target;
			this.DataWideLTEClass3AccessPointName_A42392.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_24A7:
			this.DataWideGeneralICMPEcho_A8219 = (global::AcpUI.AcpCheckBox)target;
			this.DataWideGeneralICMPEcho_A8219.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_24CB:
			this.DataWideLTEOutOfRangeThresholdTime_A42206Comp = (global::AcpUI.AcpLabel)target;
			return;
			IL_24D8:
			this.LblDataWideLTEOpenMaxGuardTime_A42391 = (global::AcpUI.AcpLabel)target;
			this.LblDataWideLTEOpenMaxGuardTime_A42391.MouseDoubleClick += new global::System.Windows.Input.MouseButtonEventHandler(this.OnFieldNameDoubleClick);
			return;
			IL_24FC:
			this.CVBtnRandomAccessAckTimerMsec_42016 = (global::AcpUI.AcpCustomViewCheckBox)target;
			return;
			IL_2509:
			this.CpyBtnDataCfgDataWideMaxSetupTimeAllowedforCCA_A36193 = (global::AcpUI.AcpCopyButton)target;
			return;
			IL_2516:
			this.DataWideMG90WirelessLTEFriendlyName_43786 = (global::AcpUI.AcpTextBox)target;
			this.DataWideMG90WirelessLTEFriendlyName_43786.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_253A:
			this.CVBtnDataWideWIFIAllowUserControl = (global::AcpUI.AcpCustomViewCheckBox)target;
			return;
			IL_2547:
			this.LblDataWidePOP25AutoResetEnable_A37221 = (global::AcpUI.AcpLabel)target;
			this.LblDataWidePOP25AutoResetEnable_A37221.MouseDoubleClick += new global::System.Windows.Input.MouseButtonEventHandler(this.OnFieldNameDoubleClick);
			return;
			IL_256B:
			this.GrpBoxExpanderDataWideExternalDataModemPseudo0 = (global::AcpUI.AcpGroupBox)target;
			return;
			IL_2578:
			this.RTDBtnDataWideGeneralBroadbandCheckbackTime_A42862 = (global::AcpUI.AcpRtdButton)target;
			return;
			IL_2585:
			this.RTDBtnDataWideGeneralBTDUNPeerIPAddressAssignmentType_A41124 = (global::AcpUI.AcpRtdButton)target;
			return;
			IL_2592:
			this.LblDataWideExternalDataModemOutOfRangeThreshold_42853 = (global::AcpUI.AcpLabel)target;
			this.LblDataWideExternalDataModemOutOfRangeThreshold_42853.MouseDoubleClick += new global::System.Windows.Input.MouseButtonEventHandler(this.OnFieldNameDoubleClick);
			return;
			IL_25B6:
			this.CVBtnDataWideLTELTECheckbackTime_A42205 = (global::AcpUI.AcpCustomViewCheckBox)target;
			return;
			IL_25C3:
			this.CVBtnDataWideEncryptedNetworkPassword_43361 = (global::AcpUI.AcpCustomViewCheckBox)target;
			return;
			IL_25D0:
			this.CVBtnDataWideLTEOffMaxDetachTime_A42207 = (global::AcpUI.AcpCustomViewCheckBox)target;
			return;
			IL_25DD:
			this.CVBtnDataWideGeneralBTDUNPeerIPAddressAssignmentType_A41124 = (global::AcpUI.AcpCustomViewCheckBox)target;
			return;
			IL_25EA:
			this.RTDBtnDataWideKVLKeyloadingUDPPort_43205 = (global::AcpUI.AcpRtdButton)target;
			return;
			IL_25F7:
			this.LblLabtoolContextActivationHoldoffTimerSec = (global::AcpUI.AcpLabel)target;
			this.LblLabtoolContextActivationHoldoffTimerSec.MouseDoubleClick += new global::System.Windows.Input.MouseButtonEventHandler(this.OnFieldNameDoubleClick);
			return;
			IL_261B:
			this.CpyBtnDataWideWIFIEnable_42506 = (global::AcpUI.AcpCopyButton)target;
			return;
			IL_2628:
			this.LblCloudRegion_43554 = (global::AcpUI.AcpLabel)target;
			this.LblCloudRegion_43554.MouseDoubleClick += new global::System.Windows.Input.MouseButtonEventHandler(this.OnFieldNameDoubleClick);
			return;
			IL_264C:
			this.ExpanderDataWideQuickTextMessageListGrid = (global::System.Windows.Controls.Grid)target;
			return;
			IL_2659:
			this.DataWideVirtualPartnerGatewayHostname_43557Comp = (global::AcpUI.AcpLabel)target;
			return;
			IL_2666:
			this.LblDataWideQuickTextMessageListQuickTextMessage_A8810 = (global::AcpUI.AcpLabel)target;
			this.LblDataWideQuickTextMessageListQuickTextMessage_A8810.MouseDoubleClick += new global::System.Windows.Input.MouseButtonEventHandler(this.OnFieldNameDoubleClick);
			return;
			IL_268A:
			this.LblDataWideGeneralPeerIPAddress1_A8524 = (global::AcpUI.AcpLabel)target;
			this.LblDataWideGeneralPeerIPAddress1_A8524.MouseDoubleClick += new global::System.Windows.Input.MouseButtonEventHandler(this.OnFieldNameDoubleClick);
			return;
			IL_26AE:
			this.CpyBtnDataWideLabtoolDeviceProvisioningServiceIDScope_43553 = (global::AcpUI.AcpCopyButton)target;
			return;
			IL_26BB:
			this.CpyBtnDataWideExternalDataVpnTunnel_43365 = (global::AcpUI.AcpCopyButton)target;
			return;
			IL_26C8:
			this.DataWideExternalDataModemSecurityType_43360 = (global::AcpUI.AcpComboBox)target;
			this.DataWideExternalDataModemSecurityType_43360.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_26EC:
			this.DataWideGeneralMobileSubIPAddress_A41819Comp = (global::AcpUI.AcpLabel)target;
			return;
			IL_26F9:
			this.DataConfigDataWideMaxNumOfCompreHeadersBetweenFullHeaders_A36205 = (global::AcpUI.AcpTextBoxSpinner)target;
			this.DataConfigDataWideMaxNumOfCompreHeadersBetweenFullHeaders_A36205.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_271D:
			this.DataWideGeneralMobileSubIPAddress_A41819 = (global::AcpUI.AcpTextBox)target;
			this.DataWideGeneralMobileSubIPAddress_A41819.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_2741:
			this.DataCfgDataWideMaxSetupTimeAllowedforCCA_A36193Comp = (global::AcpUI.AcpLabel)target;
			return;
			IL_274E:
			this.CpyBtnDataWideExternalDataModemNetworkPriority_43358 = (global::AcpUI.AcpCopyButton)target;
			return;
			IL_275B:
			this.CVBtnDataWideLTEHWEnable = (global::AcpUI.AcpCustomViewCheckBox)target;
			return;
			IL_2768:
			this.LblDataWideExternalDataModemPort = (global::AcpUI.AcpLabel)target;
			this.LblDataWideExternalDataModemPort.MouseDoubleClick += new global::System.Windows.Input.MouseButtonEventHandler(this.OnFieldNameDoubleClick);
			return;
			IL_278C:
			this.CVBtnDataWidePOP25OTAPIndications_A8670 = (global::AcpUI.AcpCustomViewCheckBox)target;
			return;
			IL_2799:
			this.CVBtnLabtoolDefaultReadyTimerSec = (global::AcpUI.AcpCustomViewCheckBox)target;
			return;
			IL_27A6:
			this.RTDBtnDataWideMG90WirelessSatelliteEnable_43788 = (global::AcpUI.AcpRtdButton)target;
			return;
			IL_27B3:
			this.DataWideExternalDataOORTime_43366 = (global::AcpUI.AcpTextBoxSpinner)target;
			this.DataWideExternalDataOORTime_43366.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_27D7:
			this.ExpanderDataWideGeneral = (global::AcpUI.AcpExpander)target;
			return;
			IL_27E4:
			this.RTDBtnDataWideWiFiNetworkPriority_42512 = (global::AcpUI.AcpRtdButton)target;
			return;
			IL_27F1:
			this.DataWideNATListLANPort_A8385Comp = (global::AcpUI.AcpLabel)target;
			return;
			IL_27FE:
			this.DataWideWIFIEnable_42506 = (global::AcpUI.AcpCheckBox)target;
			this.DataWideWIFIEnable_42506.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_2822:
			this.DataWideWIFIOTAPTCPPort_42627Comp = (global::AcpUI.AcpLabel)target;
			return;
			IL_282F:
			this.CVBtnDataWideGeneralBTDUNSUIPAddress_A41120 = (global::AcpUI.AcpCustomViewCheckBox)target;
			return;
			IL_283C:
			this.LblDataCfgDataWideTimeSourceVar_A36196 = (global::AcpUI.AcpLabel)target;
			this.LblDataCfgDataWideTimeSourceVar_A36196.MouseDoubleClick += new global::System.Windows.Input.MouseButtonEventHandler(this.OnFieldNameDoubleClick);
			return;
			IL_2860:
			this.ExpanderDataWideConfiguredNetworksListGrid = (global::System.Windows.Controls.Grid)target;
			return;
			IL_286D:
			this.CpyBtnDataWideExternalDataModemPort_42851 = (global::AcpUI.AcpCopyButton)target;
			return;
			IL_287A:
			this.CpyBtnDataWideKVLKeyloadingUDPPort_43205 = (global::AcpUI.AcpCopyButton)target;
			return;
			IL_2887:
			this.RecNavToolbarExpanderDataWideNATListTable = (global::AcpUI.AcpRecNavToolbar)target;
			this.RecNavToolbarExpanderDataWideNATListTable.ModeClick += this.OnModeClick;
			return;
			IL_28AB:
			this.DataWideWiFiNetworkSSID_42519Comp = (global::AcpUI.AcpLabel)target;
			return;
			IL_28B8:
			this.GrpBoxExpanderDataWideWIFIPseudo0 = (global::AcpUI.AcpGroupBox)target;
			return;
			IL_28C5:
			this.RTDBtnDataWideExternalDataModemPort = (global::AcpUI.AcpRtdButton)target;
			return;
			IL_28D2:
			this.CVBtnDataWideExternalDataModemPort = (global::AcpUI.AcpCustomViewCheckBox)target;
			return;
			IL_28DF:
			this.LblDataConfigDataWideMaxHeaderSizeAllowedForCompression_A36206 = (global::AcpUI.AcpLabel)target;
			this.LblDataConfigDataWideMaxHeaderSizeAllowedForCompression_A36206.MouseDoubleClick += new global::System.Windows.Input.MouseButtonEventHandler(this.OnFieldNameDoubleClick);
			return;
			IL_2903:
			this.DataWideEncryptedNetworkPassword_43361_Col = (global::Infragistics.Windows.DataPresenter.UnboundField)target;
			return;
			IL_2910:
			this.CpyBtnDataWideGeneralICMPEcho_A8219 = (global::AcpUI.AcpCopyButton)target;
			return;
			IL_291D:
			this.DataWideExternalDataModemLTEFriendlyName_43775Comp = (global::AcpUI.AcpLabel)target;
			return;
			IL_292A:
			this.AcknowledgedWeaponFiredEventReportingEnable_43582Comp = (global::AcpUI.AcpCheckBox)target;
			return;
			IL_2937:
			this.DataWideLabtoolDeviceProvisioningServiceURI_43555Comp = (global::AcpUI.AcpLabel)target;
			return;
			IL_2944:
			this.CVBtnDirectTMSContentDisplay_42323 = (global::AcpUI.AcpCustomViewCheckBox)target;
			return;
			IL_2951:
			this.CVBtnDataWideGeneralPeerIPAddressAssignmentType1_A22376 = (global::AcpUI.AcpCustomViewCheckBox)target;
			return;
			IL_295E:
			this.RTDBtnSensorMeasurementReporting_A43021 = (global::AcpUI.AcpRtdButton)target;
			return;
			IL_296B:
			this.RTDBtnDataWideExternalDataModemOpenMaxGuardTime_42856 = (global::AcpUI.AcpRtdButton)target;
			return;
			IL_2978:
			this.DataWideLTEOffMaxDetachTime_A42207Comp = (global::AcpUI.AcpLabel)target;
			return;
			IL_2985:
			this.LblDataWideWiFiNetworkSSID_42519 = (global::AcpUI.AcpLabel)target;
			this.LblDataWideWiFiNetworkSSID_42519.MouseDoubleClick += new global::System.Windows.Input.MouseButtonEventHandler(this.OnFieldNameDoubleClick);
			return;
			IL_29A9:
			num = (short)318242816;
			short num4 = num;
			this.DataWideMG90WirelessSatelliteEnable_43788_Col = (global::Infragistics.Windows.DataPresenter.UnboundField)target;
			return;
			IL_29DF:
			this.RTDBtnDataWideGeneralMobileSubIPAddress_A41819 = (global::AcpUI.AcpRtdButton)target;
			return;
			IL_29EC:
			this.ExpanderDataWideNATListGrid = (global::System.Windows.Controls.Grid)target;
			return;
			IL_29F9:
			this.RecNavToolbarExpanderDataWideConfiguredNetworksList = (global::AcpUI.AcpRecNavToolbar)target;
			this.RecNavToolbarExpanderDataWideConfiguredNetworksList.ModeClick += this.OnModeClick;
			return;
			IL_2A1D:
			this.DataWideWiFiNetworkSSID_42519 = (global::AcpUI.AcpTextBox)target;
			this.DataWideWiFiNetworkSSID_42519.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_2A41:
			this.DataWideExternalDataModemPort_42851Comp = (global::AcpUI.AcpLabel)target;
			return;
			IL_2A4E:
			this.AcknowledgedStunGunStateReportingEnable_43552Comp = (global::AcpUI.AcpCheckBox)target;
			return;
			IL_2A5B:
			this.CVBtnDataWideLabtoolDATA_CFGOTAPDefaultInactivityTimer_A8668 = (global::AcpUI.AcpCustomViewCheckBox)target;
			return;
			IL_2A68:
			this.CpyBtnCloudRegion_43554 = (global::AcpUI.AcpCopyButton)target;
			return;
			IL_2A75:
			this.LblDataWidePOP25OTAPIndications_A8670 = (global::AcpUI.AcpLabel)target;
			this.LblDataWidePOP25OTAPIndications_A8670.MouseDoubleClick += new global::System.Windows.Input.MouseButtonEventHandler(this.OnFieldNameDoubleClick);
			return;
			IL_2A99:
			this.ModemConnectionType_43350Comp = (global::AcpUI.AcpLabel)target;
			return;
			IL_2AA6:
			this.LblDataWideGeneralMobileSubIPAddress_A41819 = (global::AcpUI.AcpLabel)target;
			this.LblDataWideGeneralMobileSubIPAddress_A41819.MouseDoubleClick += new global::System.Windows.Input.MouseButtonEventHandler(this.OnFieldNameDoubleClick);
			return;
			IL_2ACA:
			this.ExpanderDataWideNATListTable = (global::AcpUI.AcpXamDataPresenter)target;
			return;
			IL_2AD7:
			this.CpyBtnDataWidePOP25OTAPIndications_A8670 = (global::AcpUI.AcpCopyButton)target;
			return;
			IL_2AE4:
			this.CVBtnDataWideExternalDataModemOpenTime_43367 = (global::AcpUI.AcpCustomViewCheckBox)target;
			return;
			IL_2AF1:
			this.DirectTMSContentDisplay_42323 = (global::AcpUI.AcpCheckBox)target;
			this.DirectTMSContentDisplay_42323.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_2B15:
			this.RTDBtnDataWideNATListLANPort_A8385 = (global::AcpUI.AcpRtdButton)target;
			return;
			IL_2B22:
			this.DataWideExternalDataModemOutOfRangeThreshold_42853 = (global::AcpUI.AcpTextBoxSpinner)target;
			this.DataWideExternalDataModemOutOfRangeThreshold_42853.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_2B46:
			this.RecNavToolbarExpanderDataWideDataModemTable = (global::AcpUI.AcpRecNavToolbar)target;
			this.RecNavToolbarExpanderDataWideDataModemTable.ModeClick += this.OnModeClick;
			return;
			IL_2B6A:
			this.CVBtnDataCfgDataWideTimeSourceVar_A36196 = (global::AcpUI.AcpCustomViewCheckBox)target;
			return;
			IL_2B77:
			this.CpyBtnDirectTMSContentDisplay_42323 = (global::AcpUI.AcpCopyButton)target;
			return;
			IL_2B84:
			this.CpyBtnDataWideDVRSActWaitTime_A40128 = (global::AcpUI.AcpCopyButton)target;
			return;
			IL_2B91:
			this.DataWideEncryptedModemPassword_43361_Col = (global::Infragistics.Windows.DataPresenter.UnboundField)target;
			return;
			IL_2B9E:
			this.RTDBtnDataWideGeneralPeerIPAddress1_A8524 = (global::AcpUI.AcpRtdButton)target;
			return;
			IL_2BAB:
			this.SensorMeasurementReporting_A43021 = (global::AcpUI.AcpCheckBox)target;
			this.SensorMeasurementReporting_A43021.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_2BCF:
			this.CpyBtnModemConnectionType_43350 = (global::AcpUI.AcpCopyButton)target;
			return;
			IL_2BDC:
			this.CVBtnDataWideExternalDataModemOutOfRangeThreshold_42853 = (global::AcpUI.AcpCustomViewCheckBox)target;
			return;
			IL_2BE9:
			this.LblDataWideMG90WirelessSatelliteEnable_43788 = (global::AcpUI.AcpLabel)target;
			this.LblDataWideMG90WirelessSatelliteEnable_43788.MouseDoubleClick += new global::System.Windows.Input.MouseButtonEventHandler(this.OnFieldNameDoubleClick);
			return;
			IL_2C0D:
			this.CVBtnDataWideWIFIOTAPTCPPort_42627 = (global::AcpUI.AcpCustomViewCheckBox)target;
			return;
			IL_2C1A:
			this.DataWideLTEOpenMaxGuardTime_A42391Comp = (global::AcpUI.AcpLabel)target;
			return;
			IL_2C27:
			this.ExpanderDataWideExternalDataModemGrid = (global::System.Windows.Controls.Grid)target;
			return;
			IL_2C34:
			this.CVBtnSensorMeasurementReportingUDPPort_A43022 = (global::AcpUI.AcpCustomViewCheckBox)target;
			return;
			IL_2C41:
			this.DataWideEncryptedNetworkPassword_43361Comp = (global::AcpUI.AcpLabel)target;
			return;
			IL_2C4E:
			this.RTDBtnDataWideNATListWANPort_A9677 = (global::AcpUI.AcpRtdButton)target;
			return;
			IL_2C5B:
			this.CVBtnDataWidePOP25AutoResetEnable_A37221 = (global::AcpUI.AcpCustomViewCheckBox)target;
			return;
			IL_2C68:
			this.CpyBtnDataWideExternalTextMessagingBroadcast_42418 = (global::AcpUI.AcpCopyButton)target;
			return;
			IL_2C75:
			this.RTDBtnDataWideQuickTextMessageListQuickTextMessage_A8810 = (global::AcpUI.AcpRtdButton)target;
			return;
			IL_2C82:
			this.DataWideExternalDataModemNetworkPriority_43358 = (global::AcpUI.AcpTextBoxSpinner)target;
			this.DataWideExternalDataModemNetworkPriority_43358.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_2CA6:
			this.ExpanderDataWideConfiguredNetworksListTableView = (global::AcpUI.AcpGroupBox)target;
			return;
			IL_2CB3:
			this.RTDBtnDataWideDVRSActWaitTime_A40128 = (global::AcpUI.AcpRtdButton)target;
			return;
			IL_2CC0:
			this.CpyBtnDataWideGeneralBTDUNSUIPAddress_A41120 = (global::AcpUI.AcpCopyButton)target;
			return;
			IL_2CCD:
			this.ExpanderDataWideDataUserListGrid = (global::System.Windows.Controls.Grid)target;
			return;
			IL_2CDA:
			this.RTDBtnDataWideMG90WirelessLTEFriendlyName_43786 = (global::AcpUI.AcpRtdButton)target;
			return;
			IL_2CE7:
			this.DataWideExternalDataModemHiddenNetwork_44814_Col = (global::Infragistics.Windows.DataPresenter.UnboundField)target;
			return;
			IL_2CF4:
			this.DataWideGeneralBTDUNPeerIPAddressAssignmentType_A41124Comp = (global::AcpUI.AcpLabel)target;
			return;
			IL_2D01:
			this.DataWideLabtoolDATA_CFGOTAPDefaultInactivityTimer_A8668Comp = (global::AcpUI.AcpLabel)target;
			return;
			IL_2D0E:
			this.LblDataConfDataWidePortConAuthenticationUDPPort_A37608 = (global::AcpUI.AcpLabel)target;
			this.LblDataConfDataWidePortConAuthenticationUDPPort_A37608.MouseDoubleClick += new global::System.Windows.Input.MouseButtonEventHandler(this.OnFieldNameDoubleClick);
			return;
			IL_2D32:
			this.RTDBtnCloudRegion_43554 = (global::AcpUI.AcpRtdButton)target;
			return;
			IL_2D3F:
			this.DataWideWiFiNetworkPriority_42512 = (global::AcpUI.AcpTextBoxSpinner)target;
			this.DataWideWiFiNetworkPriority_42512.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_2D63:
			this.DataWideVirtualPartnerGatewayHostname_43557 = (global::AcpUI.AcpTextBox)target;
			this.DataWideVirtualPartnerGatewayHostname_43557.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_2D87:
			this.CpyBtnDataWideWiFiNetworkSSID_42519 = (global::AcpUI.AcpCopyButton)target;
			return;
			IL_2D94:
			this.ExpanderDataWideQuickTextMessageList = (global::AcpUI.AcpExpander)target;
			return;
			IL_2DA1:
			this.DataWideGeneralPeerIPAddress1_A8524 = (global::AcpUI.AcpTextBox)target;
			this.DataWideGeneralPeerIPAddress1_A8524.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_2DC5:
			this.LblDataWideExternalDataModemLTEFriendlyName_43775 = (global::AcpUI.AcpLabel)target;
			this.LblDataWideExternalDataModemLTEFriendlyName_43775.MouseDoubleClick += new global::System.Windows.Input.MouseButtonEventHandler(this.OnFieldNameDoubleClick);
			return;
			IL_2DE9:
			this.CVBtnDataWideGeneralBroadbandCheckbackTime_A42862 = (global::AcpUI.AcpCustomViewCheckBox)target;
			return;
			IL_2DF6:
			this.RTDBtnDataWideEncryptedModemPassword_43361 = (global::AcpUI.AcpRtdButton)target;
			return;
			IL_2E03:
			this.CVBtnDataWideExternalDataVpnTunnel_43365 = (global::AcpUI.AcpCustomViewCheckBox)target;
			return;
			IL_2E10:
			this.RTDBtnDataWideExternalDataVpnTunnel_43365 = (global::AcpUI.AcpRtdButton)target;
			return;
			IL_2E1D:
			this.DataWideGeneralDeleteMessagesOnSessionEnd_41308 = (global::AcpUI.AcpCheckBox)target;
			this.DataWideGeneralDeleteMessagesOnSessionEnd_41308.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_2E41:
			this.DataWideDVRSActWaitTime_A40128 = (global::AcpUI.AcpTextBoxSpinner)target;
			this.DataWideDVRSActWaitTime_A40128.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_2E65:
			this.CpyBtnDataWideVirtualPartnerGatewayHostname_43557 = (global::AcpUI.AcpCopyButton)target;
			return;
			IL_2E72:
			this.DataWideExternalDataModemType_43362Comp = (global::AcpUI.AcpLabel)target;
			return;
			IL_2EA3:
			this.DataWideNATListLANPort_A8385_Col = (global::Infragistics.Windows.DataPresenter.UnboundField)target;
			return;
			IL_2EB0:
			this.gridExpanderDataWideDataUserListTableSRecView = (global::System.Windows.Controls.Grid)target;
			return;
			IL_2EBD:
			this.gridExpanderDataWideDataModemTableSRecView = (global::System.Windows.Controls.Grid)target;
			return;
			IL_2ECA:
			this.DataWideMG90WirelessSatelliteFriendlyName_43787_Col = (global::Infragistics.Windows.DataPresenter.UnboundField)target;
			return;
			IL_2ED7:
			this.RTDBtnDataWideLabtoolDeviceProvisioningServiceIDScope_43553 = (global::AcpUI.AcpRtdButton)target;
			return;
			IL_2EE4:
			this.CVBtnDataWideIdentityManagementGatewayHostname_43556 = (global::AcpUI.AcpCustomViewCheckBox)target;
			return;
			IL_2EF1:
			this.ModemConnectionType_43350 = (global::AcpUI.AcpComboBox)target;
			this.ModemConnectionType_43350.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_2F15:
			this.ExpanderDataWideExternalDataModem = (global::AcpUI.AcpExpander)target;
			return;
			IL_2F22:
			this.DataWideGeneralDVRIPAddress_A41818 = (global::AcpUI.AcpTextBox)target;
			this.DataWideGeneralDVRIPAddress_A41818.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_2F46:
			this.CpyBtnDataWideGeneralBTDUNPeerIPAddress_A41123 = (global::AcpUI.AcpCopyButton)target;
			return;
			IL_2F53:
			this.CpyBtnDataWideExternalDataModemOutOfRangeThreshold_42853 = (global::AcpUI.AcpCopyButton)target;
			return;
			IL_2F60:
			this.LblDataWideNATListLANPort_A8385 = (global::AcpUI.AcpLabel)target;
			this.LblDataWideNATListLANPort_A8385.MouseDoubleClick += new global::System.Windows.Input.MouseButtonEventHandler(this.OnFieldNameDoubleClick);
			return;
			IL_2F84:
			this.DataWideExternalDataModemOutOfRangeThreshold_42853Comp = (global::AcpUI.AcpLabel)target;
			return;
			IL_2F91:
			this.CpyBtnDataWideLTEClass3AccessPointName_A42392 = (global::AcpUI.AcpCopyButton)target;
			return;
			IL_2F9E:
			this.LblDataWideLabtoolDeviceProvisioningServiceURI_43555 = (global::AcpUI.AcpLabel)target;
			this.LblDataWideLabtoolDeviceProvisioningServiceURI_43555.MouseDoubleClick += new global::System.Windows.Input.MouseButtonEventHandler(this.OnFieldNameDoubleClick);
			return;
			IL_2FC2:
			this.LabtoolContextActivationHoldoffTimerSec = (global::AcpUI.AcpTextBoxSpinner)target;
			this.LabtoolContextActivationHoldoffTimerSec.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_2FE6:
			this.LblDataWideLTEOffMaxDetachTime_A42207 = (global::AcpUI.AcpLabel)target;
			this.LblDataWideLTEOffMaxDetachTime_A42207.MouseDoubleClick += new global::System.Windows.Input.MouseButtonEventHandler(this.OnFieldNameDoubleClick);
			return;
			IL_300A:
			this.RTDBtnDataWideExternalDataModemType_43362 = (global::AcpUI.AcpRtdButton)target;
			return;
			IL_3017:
			this.DataWideExternalDataModemPowerupMaxGuardTime_42855 = (global::AcpUI.AcpTextBoxSpinner)target;
			this.DataWideExternalDataModemPowerupMaxGuardTime_42855.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_303B:
			this.CpyBtnDataWideLTEOffMaxDetachTime_A42207 = (global::AcpUI.AcpCopyButton)target;
			return;
			IL_3048:
			this.CpyBtnDataWideP25LocationReportingUDPPort_42413 = (global::AcpUI.AcpCopyButton)target;
			return;
			IL_3055:
			this.LabtoolContextRenewalTimerMinComp = (global::AcpUI.AcpLabel)target;
			return;
			IL_3062:
			this.ExpanderDataWideQuickTextMessageListTableSRecView = (global::AcpUI.AcpGroupBox)target;
			return;
			IL_306F:
			this.CpyBtnDataConfigDataWideMaxNumofTCPIPHCContexts_A36194 = (global::AcpUI.AcpCopyButton)target;
			return;
			IL_307C:
			this.LblDataWideGeneralPeerIPAddressAssignmentType1_A22376 = (global::AcpUI.AcpLabel)target;
			this.LblDataWideGeneralPeerIPAddressAssignmentType1_A22376.MouseDoubleClick += new global::System.Windows.Input.MouseButtonEventHandler(this.OnFieldNameDoubleClick);
			return;
			IL_30A0:
			this.CVBtnDataWideExternalDataModemWifiPowerupGuardTime = (global::AcpUI.AcpCustomViewCheckBox)target;
			return;
			IL_30AD:
			this.DataWideMG90WirelessSatelliteFriendlyName_43787 = (global::AcpUI.AcpTextBox)target;
			this.DataWideMG90WirelessSatelliteFriendlyName_43787.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_30D1:
			this.RTDBtnDataWideExternalDataModemSecurityType_43360 = (global::AcpUI.AcpRtdButton)target;
			return;
			IL_30DE:
			this.CVBtnDataWideGeneralMobileSubIPAddress_A41819 = (global::AcpUI.AcpCustomViewCheckBox)target;
			return;
			IL_30EB:
			this.DataWideWIFINetworkHidden = (global::AcpUI.AcpCheckBox)target;
			this.DataWideWIFINetworkHidden.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_310F:
			this.CVBtnDataWideWiFiNetworkSSID_42519 = (global::AcpUI.AcpCustomViewCheckBox)target;
			return;
			IL_311C:
			this.LabtoolDefaultReadyTimerSecComp = (global::AcpUI.AcpLabel)target;
			return;
			IL_3129:
			this.CpyBtnDataWideExternalDataModemVPNFriendlyName_43774 = (global::AcpUI.AcpCopyButton)target;
			return;
			IL_3136:
			this.LblDataWideMG90WirelessSatelliteFriendlyName_43787 = (global::AcpUI.AcpLabel)target;
			this.LblDataWideMG90WirelessSatelliteFriendlyName_43787.MouseDoubleClick += new global::System.Windows.Input.MouseButtonEventHandler(this.OnFieldNameDoubleClick);
			return;
			IL_315A:
			this.CVBtnDataWideDVRSActWaitTime_A40128 = (global::AcpUI.AcpCustomViewCheckBox)target;
			return;
			IL_3167:
			this.CVBtnDataCfgDataWideMaxSetupTimeAllowedforCCA_A36193 = (global::AcpUI.AcpCustomViewCheckBox)target;
			return;
			IL_3174:
			this.DataWideExternalDataModemPort_Col = (global::Infragistics.Windows.DataPresenter.UnboundField)target;
			return;
			IL_3181:
			this.LblDataWideDataOnRoaming_A42216 = (global::AcpUI.AcpLabel)target;
			this.LblDataWideDataOnRoaming_A42216.MouseDoubleClick += new global::System.Windows.Input.MouseButtonEventHandler(this.OnFieldNameDoubleClick);
			return;
			IL_31A5:
			this.LblDataWideP25LocationReportingUDPPort_42413 = (global::AcpUI.AcpLabel)target;
			this.LblDataWideP25LocationReportingUDPPort_42413.MouseDoubleClick += new global::System.Windows.Input.MouseButtonEventHandler(this.OnFieldNameDoubleClick);
			return;
			IL_31C9:
			this.LblDataWideIdentityManagementGatewayHostname_43556 = (global::AcpUI.AcpLabel)target;
			this.LblDataWideIdentityManagementGatewayHostname_43556.MouseDoubleClick += new global::System.Windows.Input.MouseButtonEventHandler(this.OnFieldNameDoubleClick);
			return;
			IL_31ED:
			this.DataWideLabtoolDATA_CFGPacketDataActivateWaitTimerSec_A8686 = (global::AcpUI.AcpTextBoxSpinner)target;
			this.DataWideLabtoolDATA_CFGPacketDataActivateWaitTimerSec_A8686.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_3211:
			this.DataWideExternalDataModemType_43362_Col = (global::Infragistics.Windows.DataPresenter.UnboundField)target;
			return;
			IL_321E:
			this.DataWideExternalTextMessagingBroadcast_42418Comp = (global::AcpUI.AcpCheckBox)target;
			return;
			IL_322B:
			this.RTDBtnDataWideExternalDataOORTime_43366 = (global::AcpUI.AcpRtdButton)target;
			return;
			IL_3238:
			this.LblDataWideEncryptedModemPassword_43361 = (global::AcpUI.AcpLabel)target;
			this.LblDataWideEncryptedModemPassword_43361.MouseDoubleClick += new global::System.Windows.Input.MouseButtonEventHandler(this.OnFieldNameDoubleClick);
			return;
			IL_325C:
			this.CVBtnDataConfigDataWideMaxNumofNonTCPIPHCContexts_A36192 = (global::AcpUI.AcpCustomViewCheckBox)target;
			return;
			IL_3269:
			this.gridExpanderDataWideNATListTableSRecView = (global::System.Windows.Controls.Grid)target;
			return;
			IL_3276:
			this.CVBtnDataWidePOP25OTAPRejectEnable_A8671 = (global::AcpUI.AcpCustomViewCheckBox)target;
			return;
			IL_3283:
			this.DataWideExternalDataModemPort = (global::AcpUI.AcpTextBoxSpinner)target;
			this.DataWideExternalDataModemPort.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_32A7:
			this.DataWideMG90WirelessSatelliteEnable_43788 = (global::AcpUI.AcpCheckBox)target;
			this.DataWideMG90WirelessSatelliteEnable_43788.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_32CB:
			this.GrpBoxExpanderDataWidePortConfigurationPseudo0 = (global::AcpUI.AcpGroupBox)target;
			return;
			IL_32D8:
			this.DataWideLTEOperation_A42215Comp = (global::AcpUI.AcpCheckBox)target;
			return;
			IL_32E5:
			this.CVBtnDataWideExternalDataModemVPNFriendlyName_43774 = (global::AcpUI.AcpCustomViewCheckBox)target;
			return;
			IL_32F2:
			this.GrpBoxExpanderDataWidePOP25Pseudo0 = (global::AcpUI.AcpGroupBox)target;
			return;
			IL_32FF:
			this.CpyBtnDataWideGeneralInternalRadioSubnet_A42073 = (global::AcpUI.AcpCopyButton)target;
			return;
			IL_330C:
			this.GrpBoxExpanderDataWideDataProtocolConfigurationPseudo0 = (global::AcpUI.AcpGroupBox)target;
			return;
			IL_3319:
			this.DataWideLabtoolDeviceProvisioningServiceIDScope_43553 = (global::AcpUI.AcpTextBox)target;
			this.DataWideLabtoolDeviceProvisioningServiceIDScope_43553.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_333D:
			this.gridExpanderDataWideQuickTextMessageListTableSRecView = (global::System.Windows.Controls.Grid)target;
			return;
			IL_334A:
			this.GrpBoxExpanderDataWideExternalDataModemWiredModemConfiguration = (global::AcpUI.AcpGroupBox)target;
			return;
			IL_3357:
			this.RTDBtnDataWideWiFiNetworkEncryptedNetworkPassword_42517 = (global::AcpUI.AcpRtdButton)target;
			return;
			IL_3364:
			this.CpyBtnDataWidePOP25AutoResetEnable_A37221 = (global::AcpUI.AcpCopyButton)target;
			return;
			IL_3371:
			this.RTDBtnDataConfDataWidePortConAuthenticationUDPPort_A37608 = (global::AcpUI.AcpRtdButton)target;
			return;
			IL_337E:
			this.CpyBtnAcknowledgedGunHolsterStateReportingEnable_43551 = (global::AcpUI.AcpCopyButton)target;
			return;
			IL_338B:
			this.LblDataWideNATListWANPort_A9677 = (global::AcpUI.AcpLabel)target;
			this.LblDataWideNATListWANPort_A9677.MouseDoubleClick += new global::System.Windows.Input.MouseButtonEventHandler(this.OnFieldNameDoubleClick);
			return;
			IL_33AF:
			this.CpyBtnDataWideNATListStaticNATIPAddress_A9181 = (global::AcpUI.AcpCopyButton)target;
			return;
			IL_33BC:
			this.DataWideExternalDataModemOpenMaxGuardTime_42856 = (global::AcpUI.AcpTextBoxSpinner)target;
			this.DataWideExternalDataModemOpenMaxGuardTime_42856.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_33E0:
			this.RTDBtnDataWideGeneralInternalRadioSubnet_A42073 = (global::AcpUI.AcpRtdButton)target;
			return;
			IL_33ED:
			this.DataConfigDataWideMaxHeaderSizeAllowedForCompression_A36206Comp = (global::AcpUI.AcpLabel)target;
			return;
			IL_33FA:
			this.CpyBtnDataWideLTELTECheckbackTime_A42205 = (global::AcpUI.AcpCopyButton)target;
			return;
			IL_3407:
			this.GrpBoxExpanderDataWideGeneralSerialLink2Addresses = (global::AcpUI.AcpGroupBox)target;
			return;
			IL_3414:
			this.ExpanderDataWideConfiguredNetworksListSRecView = (global::AcpUI.AcpGroupBox)target;
			return;
			IL_3421:
			this.CpyBtnLabtoolDefaultReadyTimerSec = (global::AcpUI.AcpCopyButton)target;
			return;
			IL_342E:
			this.CpyBtnDataWideNATListWANPort_A9677 = (global::AcpUI.AcpCopyButton)target;
			return;
			IL_343B:
			this.RTDBtnDataWideExternalDataModemPort_42851 = (global::AcpUI.AcpRtdButton)target;
			return;
			IL_3448:
			this.CpyBtnDataWideLTEHWEnable = (global::AcpUI.AcpCopyButton)target;
			return;
			IL_3455:
			this.LblAcknowledgedStunGunStateReportingEnable_43552 = (global::AcpUI.AcpLabel)target;
			this.LblAcknowledgedStunGunStateReportingEnable_43552.MouseDoubleClick += new global::System.Windows.Input.MouseButtonEventHandler(this.OnFieldNameDoubleClick);
			return;
			IL_3479:
			this.CVBtnDataWideExternalDataModemHiddenNetwork_44814 = (global::AcpUI.AcpCustomViewCheckBox)target;
			return;
			IL_3486:
			this.CpyBtnDataWideGeneralPeerIPAddressAssignmentType1_A22376 = (global::AcpUI.AcpCopyButton)target;
			return;
			IL_3493:
			this.DataWideGeneralDeleteMessagesOnSessionEnd_41308Comp = (global::AcpUI.AcpCheckBox)target;
			return;
			IL_34A0:
			this.DataWidePOP25OTAPRejectEnable_A8671Comp = (global::AcpUI.AcpCheckBox)target;
			return;
			IL_34AD:
			this.DataConfDataWidePortConAuthenticationUDPPort_A37608 = (global::AcpUI.AcpTextBoxSpinner)target;
			this.DataConfDataWidePortConAuthenticationUDPPort_A37608.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_34D1:
			this.DataWideWiFiNetworkPriority_42512_Col = (global::Infragistics.Windows.DataPresenter.UnboundField)target;
			return;
			IL_34DE:
			this.CpyBtnRandomAccessAckTimerMsec_42016 = (global::AcpUI.AcpCopyButton)target;
			return;
			IL_34EB:
			this.DataWideDataModemPassword_A42848 = (global::AcpUI.AcpPasswordEyeBox)target;
			this.DataWideDataModemPassword_A42848.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_350F:
			this.CVBtnDataWideExternalDataModemNetworkSsid_43358 = (global::AcpUI.AcpCustomViewCheckBox)target;
			return;
			IL_351C:
			this.HLinkQuickTextMessageList = (global::System.Windows.Documents.Hyperlink)target;
			this.HLinkQuickTextMessageList.Click += this.HLinkClick;
			return;
			IL_3540:
			this.CVBtnDataWideWiFiNetworkEncryptedNetworkPassword_42517 = (global::AcpUI.AcpCustomViewCheckBox)target;
			return;
			IL_354D:
			this.RTDBtnDataWideLTEAPCOAvalancheTime_A42204 = (global::AcpUI.AcpRtdButton)target;
			return;
			IL_355A:
			this.DataWideExternalDataModemPort_42851 = (global::AcpUI.AcpTextBoxSpinner)target;
			this.DataWideExternalDataModemPort_42851.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_357E:
			this.CVBtnDataWideGeneralDVRIPAddress_A41818 = (global::AcpUI.AcpCustomViewCheckBox)target;
			return;
			IL_358B:
			this.CVBtnDataWideP25LocationReportingUDPPort_42413 = (global::AcpUI.AcpCustomViewCheckBox)target;
			return;
			IL_3598:
			this.LblDataConfigDataWideMaxNumOfCompreHeadersBetweenFullHeaders_A36205 = (global::AcpUI.AcpLabel)target;
			this.LblDataConfigDataWideMaxNumOfCompreHeadersBetweenFullHeaders_A36205.MouseDoubleClick += new global::System.Windows.Input.MouseButtonEventHandler(this.OnFieldNameDoubleClick);
			return;
			IL_35BC:
			this.CVBtnDataWideKVLKeyloadingUDPPort_43205 = (global::AcpUI.AcpCustomViewCheckBox)target;
			return;
			IL_35C9:
			this.CpyBtnDataWideWiFiNetworkEncryptedNetworkPassword_42517 = (global::AcpUI.AcpCopyButton)target;
			return;
			IL_35D6:
			this.RTDBtnDataWideMG90WirelessVPNFriendlyName_43785 = (global::AcpUI.AcpRtdButton)target;
			return;
			IL_35E3:
			this.GrpBoxExpanderDataWideGeneralSerialLink1Addresses = (global::AcpUI.AcpGroupBox)target;
			return;
			IL_35F0:
			this.RTDBtnAcknowledgedGunHolsterStateReportingEnable_43551 = (global::AcpUI.AcpRtdButton)target;
			return;
			IL_35FD:
			this.RTDBtnDataWideExternalDataModemVPNTunnel_43024 = (global::AcpUI.AcpRtdButton)target;
			return;
			IL_360A:
			this.CpyBtnLabtoolContextRenewalTimerMin = (global::AcpUI.AcpCopyButton)target;
			return;
			IL_3617:
			this.LblDataWideGeneralSubscriberIPAddress1_A9222 = (global::AcpUI.AcpLabel)target;
			this.LblDataWideGeneralSubscriberIPAddress1_A9222.MouseDoubleClick += new global::System.Windows.Input.MouseButtonEventHandler(this.OnFieldNameDoubleClick);
			return;
			IL_363B:
			this.LblDataWideExternalDataModemNetworkSsid_43358 = (global::AcpUI.AcpLabel)target;
			this.LblDataWideExternalDataModemNetworkSsid_43358.MouseDoubleClick += new global::System.Windows.Input.MouseButtonEventHandler(this.OnFieldNameDoubleClick);
			return;
			IL_365F:
			this.LabtoolContextRenewalTimerMin = (global::AcpUI.AcpTextBoxSpinner)target;
			this.LabtoolContextRenewalTimerMin.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_3683:
			this.RTDBtnLabtoolContextActivationHoldoffTimerSec = (global::AcpUI.AcpRtdButton)target;
			return;
			IL_3690:
			this.CpyBtnDataWideWIFINetworkHidden = (global::AcpUI.AcpCopyButton)target;
			return;
			IL_369D:
			this.LblAcknowledgedGunHolsterStateReportingEnable_43551 = (global::AcpUI.AcpLabel)target;
			this.LblAcknowledgedGunHolsterStateReportingEnable_43551.MouseDoubleClick += new global::System.Windows.Input.MouseButtonEventHandler(this.OnFieldNameDoubleClick);
			return;
			IL_36C1:
			this.RTDBtnSensorMeasurementReportingUDPPort_A43022 = (global::AcpUI.AcpRtdButton)target;
			return;
			IL_36CE:
			this.DataWideEncryptedNetworkPassword_43361 = (global::AcpUI.AcpPasswordEyeBox)target;
			this.DataWideEncryptedNetworkPassword_43361.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_36F2:
			this.HLinkDataProtocolConfiguration = (global::System.Windows.Documents.Hyperlink)target;
			this.HLinkDataProtocolConfiguration.Click += this.HLinkClick;
			return;
			IL_3716:
			this.RTDBtnDataWideLabtoolDATA_CFGPacketDataActivateWaitTimerSec_A8686 = (global::AcpUI.AcpRtdButton)target;
			return;
			IL_3723:
			this.GrpBoxExpanderDataWideLabtoolDATA_CFGPseudo0 = (global::AcpUI.AcpGroupBox)target;
			return;
			IL_3730:
			this.CVBtnDataWideGeneralSubscriberIPAddress1_A9222 = (global::AcpUI.AcpCustomViewCheckBox)target;
			return;
			IL_373D:
			this.CpyBtnDataConfDataWidePortConAuthenticationUDPPort_A37608 = (global::AcpUI.AcpCopyButton)target;
			return;
			IL_374A:
			this.CpyBtnDataWideExternalDataModemNetworkSsid_43358 = (global::AcpUI.AcpCopyButton)target;
			return;
			IL_3757:
			this.CVBtnDataWideGeneralDeleteMessagesOnSessionEnd_41308 = (global::AcpUI.AcpCustomViewCheckBox)target;
			return;
			IL_3764:
			this.RTDBtnDataWideExternalDataModemNetworkSsid_43358 = (global::AcpUI.AcpRtdButton)target;
			return;
			IL_3771:
			this.LabtoolDefaultReadyTimerSec = (global::AcpUI.AcpTextBoxSpinner)target;
			this.LabtoolDefaultReadyTimerSec.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_3795:
			this.RTDBtnDataWideP25LocationReportingUDPPort_42413 = (global::AcpUI.AcpRtdButton)target;
			return;
			IL_37A2:
			this.CpyBtnDataWideDataUserListDataUserInformation_A7800 = (global::AcpUI.AcpCopyButton)target;
			return;
			IL_37AF:
			this.DataWideGeneralBTDUNPeerIPAddressAssignmentType_A41124 = (global::AcpUI.AcpComboBox)target;
			this.DataWideGeneralBTDUNPeerIPAddressAssignmentType_A41124.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_37D3:
			this.CpyBtnDataWideMG90WirelessSatelliteEnable_43788 = (global::AcpUI.AcpCopyButton)target;
			return;
			IL_37E0:
			this.CpyBtnDataWideGeneralPeerIPAddress1_A8524 = (global::AcpUI.AcpCopyButton)target;
			return;
			IL_37ED:
			this.CpyBtnDataWideIdentityManagementGatewayHostname_43556 = (global::AcpUI.AcpCopyButton)target;
			return;
			IL_37FA:
			this.CVBtnDataWideLTEClass3AccessPointName_A42392 = (global::AcpUI.AcpCustomViewCheckBox)target;
			return;
			IL_3807:
			this.LblDataWideGeneralDVRIPAddress_A41818 = (global::AcpUI.AcpLabel)target;
			this.LblDataWideGeneralDVRIPAddress_A41818.MouseDoubleClick += new global::System.Windows.Input.MouseButtonEventHandler(this.OnFieldNameDoubleClick);
			return;
			IL_382B:
			this.CVBtnDataWideLTEOperation_A42215 = (global::AcpUI.AcpCustomViewCheckBox)target;
			return;
			IL_3838:
			this.RTDBtnDataWideExternalDataModemNetworkPriority_43358 = (global::AcpUI.AcpRtdButton)target;
			return;
			IL_3845:
			this.DataWideGeneralContextDeactivationAlertTone_A7715 = (global::AcpUI.AcpCheckBox)target;
			this.DataWideGeneralContextDeactivationAlertTone_A7715.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_3869:
			this.CVBtnDataWideLTEOutOfRangeThresholdTime_A42206 = (global::AcpUI.AcpCustomViewCheckBox)target;
			return;
			IL_3876:
			this.RTDBtnDataConfigDataWideMaxNumOfCompreHeadersBetweenFullHeaders_A36205 = (global::AcpUI.AcpRtdButton)target;
			return;
			IL_3883:
			this.CpyBtnAcknowledgedStunGunStateReportingEnable_43552 = (global::AcpUI.AcpCopyButton)target;
			return;
			IL_38A7:
			goto IL_4252;
			IL_38AC:
			this.DirectTMSContentDisplay_42323Comp = (global::AcpUI.AcpCheckBox)target;
			return;
			IL_38B9:
			this.LblDirectTMSContentDisplay_42323 = (global::AcpUI.AcpLabel)target;
			this.LblDirectTMSContentDisplay_42323.MouseDoubleClick += new global::System.Windows.Input.MouseButtonEventHandler(this.OnFieldNameDoubleClick);
			return;
			IL_38DD:
			this.RTDBtnDataWideGeneralSubscriberIPAddress1_A9222 = (global::AcpUI.AcpRtdButton)target;
			return;
			IL_38EA:
			this.DataWideNATListWANPort_A9677_Col = (global::Infragistics.Windows.DataPresenter.UnboundField)target;
			return;
			IL_38F7:
			this.CVBtnLabtoolContextRenewalTimerMin = (global::AcpUI.AcpCustomViewCheckBox)target;
			return;
			IL_3904:
			this.LblDataWideWIFINetworkHidden = (global::AcpUI.AcpLabel)target;
			this.LblDataWideWIFINetworkHidden.MouseDoubleClick += new global::System.Windows.Input.MouseButtonEventHandler(this.OnFieldNameDoubleClick);
			return;
			IL_3928:
			this.CVBtnDataWideExternalDataModemMG90SatelliteEnabled_43777 = (global::AcpUI.AcpCustomViewCheckBox)target;
			return;
			IL_3935:
			this.CpyBtnDataWideGeneralBroadbandCheckbackTime_A42862 = (global::AcpUI.AcpCopyButton)target;
			return;
			IL_3942:
			this.RTDBtnDataWideMG90WirelessSatelliteFriendlyName_43787 = (global::AcpUI.AcpRtdButton)target;
			return;
			IL_394F:
			this.DataWideWiFiNetworkEncryptedNetworkPassword_42517Comp = (global::AcpUI.AcpLabel)target;
			return;
			IL_395C:
			this.CVBtnDataWideWiFiNetworkPriority_42512 = (global::AcpUI.AcpCustomViewCheckBox)target;
			return;
			IL_3969:
			this.DataWidePOP25OTAPIndications_A8670 = (global::AcpUI.AcpComboBox)target;
			this.DataWidePOP25OTAPIndications_A8670.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_398D:
			this.ExpanderDataWideDataModemTableTableView = (global::AcpUI.AcpGroupBox)target;
			return;
			IL_399A:
			this.CpyBtnDataWideGeneralSubscriberIPAddress1_A9222 = (global::AcpUI.AcpCopyButton)target;
			return;
			IL_39A7:
			num = (short)2125725697;
			if (num != 0)
			{
			}
			this.DataWideLabtoolDeviceProvisioningServiceIDScope_43553Comp = (global::AcpUI.AcpLabel)target;
			return;
			IL_39DB:
			this.DataWideGeneralPeerIPAddressAssignmentType2_A22377 = (global::AcpUI.AcpComboBox)target;
			this.DataWideGeneralPeerIPAddressAssignmentType2_A22377.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_39FF:
			this.ExpanderDataWideNATListTableGrid = (global::System.Windows.Controls.Grid)target;
			return;
			IL_3A0C:
			this.DataConfigDataWideMaxTimeBetweenFullHeaders_A36200Comp = (global::AcpUI.AcpLabel)target;
			return;
			IL_3A19:
			this.RTDBtnDataWideNATListStaticNATIPAddress_A9181 = (global::AcpUI.AcpRtdButton)target;
			return;
			IL_3A26:
			this.DataWideExternalTextMessagingBroadcast_42418 = (global::AcpUI.AcpCheckBox)target;
			this.DataWideExternalTextMessagingBroadcast_42418.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_3A4A:
			this.LblDataWideExternalDataModemOpenMaxGuardTime_42856 = (global::AcpUI.AcpLabel)target;
			this.LblDataWideExternalDataModemOpenMaxGuardTime_42856.MouseDoubleClick += new global::System.Windows.Input.MouseButtonEventHandler(this.OnFieldNameDoubleClick);
			return;
			IL_3A6E:
			this.CpyBtnDataWideLTEOperation_A42215 = (global::AcpUI.AcpCopyButton)target;
			return;
			IL_3A7B:
			this.LblDataWideGeneralBroadbandCheckbackTime_A42862 = (global::AcpUI.AcpLabel)target;
			this.LblDataWideGeneralBroadbandCheckbackTime_A42862.MouseDoubleClick += new global::System.Windows.Input.MouseButtonEventHandler(this.OnFieldNameDoubleClick);
			return;
			IL_3A9F:
			this.CloudRegion_43554 = (global::AcpUI.AcpTextBox)target;
			this.CloudRegion_43554.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_3AC3:
			this.DataWideExternalDataOORTime_43366_Col = (global::Infragistics.Windows.DataPresenter.UnboundField)target;
			return;
			IL_3AD0:
			this.DataWideExternalDataModemSecurityType_43360_Col = (global::Infragistics.Windows.DataPresenter.UnboundField)target;
			return;
			IL_3ADD:
			this.CVBtnDataWideDataUserListDataUserInformation_A7800 = (global::AcpUI.AcpCustomViewCheckBox)target;
			return;
			IL_3AEA:
			this.DataWideGeneralPeerIPAddress1_A8524Comp = (global::AcpUI.AcpLabel)target;
			return;
			IL_3AF7:
			this.DataWideMG90WirelessVPNFriendlyName_43785 = (global::AcpUI.AcpTextBox)target;
			this.DataWideMG90WirelessVPNFriendlyName_43785.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_3B1B:
			this.DataCfgDataWideTimeSourceVar_A36196 = (global::AcpUI.AcpTextBoxSpinner)target;
			this.DataCfgDataWideTimeSourceVar_A36196.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_3B3F:
			this.LblDataWidePOP25OTAPRejectEnable_A8671 = (global::AcpUI.AcpLabel)target;
			this.LblDataWidePOP25OTAPRejectEnable_A8671.MouseDoubleClick += new global::System.Windows.Input.MouseButtonEventHandler(this.OnFieldNameDoubleClick);
			return;
			IL_3B63:
			this.SensorMeasurementReporting_A43021Comp = (global::AcpUI.AcpCheckBox)target;
			return;
			IL_3B70:
			this.LblDataWideExternalDataVpnTunnel_43365 = (global::AcpUI.AcpLabel)target;
			this.LblDataWideExternalDataVpnTunnel_43365.MouseDoubleClick += new global::System.Windows.Input.MouseButtonEventHandler(this.OnFieldNameDoubleClick);
			return;
			IL_3B94:
			this.ExpanderDataWideLabtoolDATA_CFG = (global::AcpUI.AcpExpander)target;
			return;
			IL_3BA1:
			this.DataWideP25LocationReportingUDPPort_42413Comp = (global::AcpUI.AcpLabel)target;
			return;
			IL_3BAE:
			this.CVBtnDataWideExternalDataOORTime_43366 = (global::AcpUI.AcpCustomViewCheckBox)target;
			return;
			IL_3BBB:
			this.RTDBtnDataWideExternalDataModemLTEFriendlyName_43775 = (global::AcpUI.AcpRtdButton)target;
			return;
			IL_3BC8:
			this.CVBtnDataWideWIFINetworkHidden = (global::AcpUI.AcpCustomViewCheckBox)target;
			return;
			IL_3BD5:
			this.DataWideMG90WirelessSatelliteEnable_43788Comp = (global::AcpUI.AcpCheckBox)target;
			return;
			IL_3BE2:
			this.DataWideExternalDataModemPowerupMaxGuardTime_42855Comp = (global::AcpUI.AcpLabel)target;
			return;
			IL_3BEF:
			this.CpyBtnDataWideDataOnRoaming_A42216 = (global::AcpUI.AcpCopyButton)target;
			return;
			IL_3BFC:
			this.DataWideExternalDataModemMG90SatelliteFriendlyName_43776Comp = (global::AcpUI.AcpLabel)target;
			return;
			IL_3C09:
			this.DataWideWIFINetworkHiddenComp = (global::AcpUI.AcpLabel)target;
			return;
			IL_3C16:
			this.CVBtnAcknowledgedGunHolsterStateReportingEnable_43551 = (global::AcpUI.AcpCustomViewCheckBox)target;
			return;
			IL_3C23:
			this.DataWideNATListStaticNATIPAddress_A9181Comp = (global::AcpUI.AcpLabel)target;
			return;
			IL_3C30:
			this.CpyBtnDataWideExternalDataModemHiddenNetwork_44814 = (global::AcpUI.AcpCopyButton)target;
			return;
			IL_3C3D:
			this.ExpanderDataWideQuickTextMessageListTableGrid = (global::System.Windows.Controls.Grid)target;
			return;
			IL_3C4A:
			this.LblDataWideGeneralSNMPTraps_A9166 = (global::AcpUI.AcpLabel)target;
			this.LblDataWideGeneralSNMPTraps_A9166.MouseDoubleClick += new global::System.Windows.Input.MouseButtonEventHandler(this.OnFieldNameDoubleClick);
			return;
			IL_3C6E:
			this.DataWideDataOnRoaming_A42216Comp = (global::AcpUI.AcpCheckBox)target;
			return;
			IL_3C7B:
			this.CVBtnDataWideWiFiNetworkSecurityType_42516 = (global::AcpUI.AcpCustomViewCheckBox)target;
			return;
			IL_3C88:
			this.LblDataWideLTELTECheckbackTime_A42205 = (global::AcpUI.AcpLabel)target;
			this.LblDataWideLTELTECheckbackTime_A42205.MouseDoubleClick += new global::System.Windows.Input.MouseButtonEventHandler(this.OnFieldNameDoubleClick);
			return;
			IL_3CAC:
			this.DataWideExternalDataModemOpenMaxGuardTime_42856Comp = (global::AcpUI.AcpLabel)target;
			return;
			IL_3CB9:
			this.CpyBtnDataWideGeneralSNMPTraps_A9166 = (global::AcpUI.AcpCopyButton)target;
			return;
			IL_3CC6:
			this.RTDBtnDataWideGeneralContextDeactivationAlertTone_A7715 = (global::AcpUI.AcpRtdButton)target;
			return;
			IL_3CD3:
			this.LblDataWideExternalDataModemMG90SatelliteEnabled_43777 = (global::AcpUI.AcpLabel)target;
			this.LblDataWideExternalDataModemMG90SatelliteEnabled_43777.MouseDoubleClick += new global::System.Windows.Input.MouseButtonEventHandler(this.OnFieldNameDoubleClick);
			return;
			IL_3CF7:
			this.DataWideLabtoolDATA_CFGOTAPDefaultInactivityTimer_A8668 = (global::AcpUI.AcpTextBoxSpinner)target;
			this.DataWideLabtoolDATA_CFGOTAPDefaultInactivityTimer_A8668.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_3D1B:
			this.HLinkLTE = (global::System.Windows.Documents.Hyperlink)target;
			this.HLinkLTE.Click += this.HLinkClick;
			return;
			IL_3D3F:
			this.RTDBtnDataWideGeneralBTDUNSUIPAddress_A41120 = (global::AcpUI.AcpRtdButton)target;
			return;
			IL_3D4C:
			this.RTDBtnDataWideGeneralBTDUNPeerIPAddress_A41123 = (global::AcpUI.AcpRtdButton)target;
			return;
			IL_3D59:
			this.RTDBtnDataWideLTEHWEnable = (global::AcpUI.AcpRtdButton)target;
			return;
			IL_3D66:
			this.DataWideMG90WirelessLTEFriendlyName_43786Comp = (global::AcpUI.AcpLabel)target;
			return;
			IL_3D73:
			this.RTDBtnModemConnectionType_43350 = (global::AcpUI.AcpRtdButton)target;
			return;
			IL_3D80:
			this.LblDataWideExternalDataModemMG90SatelliteFriendlyName_43776 = (global::AcpUI.AcpLabel)target;
			this.LblDataWideExternalDataModemMG90SatelliteFriendlyName_43776.MouseDoubleClick += new global::System.Windows.Input.MouseButtonEventHandler(this.OnFieldNameDoubleClick);
			return;
			IL_3DA4:
			this.LblDataWideKVLKeyloadingUDPPort_43205 = (global::AcpUI.AcpLabel)target;
			this.LblDataWideKVLKeyloadingUDPPort_43205.MouseDoubleClick += new global::System.Windows.Input.MouseButtonEventHandler(this.OnFieldNameDoubleClick);
			return;
			IL_3DC8:
			this.LblDataWideGeneralBTDUNPeerIPAddress_A41123 = (global::AcpUI.AcpLabel)target;
			this.LblDataWideGeneralBTDUNPeerIPAddress_A41123.MouseDoubleClick += new global::System.Windows.Input.MouseButtonEventHandler(this.OnFieldNameDoubleClick);
			return;
			IL_3DEC:
			this.CpyBtnDataWideGeneralBTDUNPeerIPAddressAssignmentType_A41124 = (global::AcpUI.AcpCopyButton)target;
			return;
			IL_3DF9:
			this.CVBtnDataWideNATListLANPort_A8385 = (global::AcpUI.AcpCustomViewCheckBox)target;
			return;
			IL_3E06:
			this.RTDBtnDataWideExternalDataModemHiddenNetwork_44814 = (global::AcpUI.AcpRtdButton)target;
			return;
			IL_3E13:
			this.CVBtnAcknowledgedWeaponFiredEventReportingEnable_43582 = (global::AcpUI.AcpCustomViewCheckBox)target;
			return;
			IL_3E20:
			this.DataWideWiFiNetworkSSID_42519_Col = (global::Infragistics.Windows.DataPresenter.UnboundField)target;
			return;
			IL_3E2D:
			this.DataWideExternalDataModemOpenTime_43367Comp = (global::AcpUI.AcpLabel)target;
			return;
			IL_3E3A:
			this.AcknowledgedGunHolsterStateReportingEnable_43551 = (global::AcpUI.AcpCheckBox)target;
			this.AcknowledgedGunHolsterStateReportingEnable_43551.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_3E5E:
			this.DataWideGeneralBTDUNSUIPAddress_A41120Comp = (global::AcpUI.AcpLabel)target;
			return;
			IL_3E6B:
			this.CVBtnSensorMeasurementReporting_A43021 = (global::AcpUI.AcpCustomViewCheckBox)target;
			return;
			IL_3E78:
			this.RTDBtnDataWideLabtoolDATA_CFGOTAPDefaultInactivityTimer_A8668 = (global::AcpUI.AcpRtdButton)target;
			return;
			IL_3E85:
			this.RTDBtnLabtoolDefaultReadyTimerSec = (global::AcpUI.AcpRtdButton)target;
			return;
			IL_3E92:
			this.DataWideWIFIOTAPTCPPort_42627 = (global::AcpUI.AcpTextBoxSpinner)target;
			this.DataWideWIFIOTAPTCPPort_42627.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_3EB6:
			this.LabtoolContextActivationHoldoffTimerSecComp = (global::AcpUI.AcpLabel)target;
			return;
			IL_3EC3:
			this.RTDBtnAcknowledgedStunGunStateReportingEnable_43552 = (global::AcpUI.AcpRtdButton)target;
			return;
			IL_3ED0:
			this.LblDataWideWIFIOTAPTCPPort_42627 = (global::AcpUI.AcpLabel)target;
			this.LblDataWideWIFIOTAPTCPPort_42627.MouseDoubleClick += new global::System.Windows.Input.MouseButtonEventHandler(this.OnFieldNameDoubleClick);
			return;
			IL_3EF4:
			this.DataConfigDataWideMaxHeaderSizeAllowedForCompression_A36206 = (global::AcpUI.AcpTextBoxSpinner)target;
			this.DataConfigDataWideMaxHeaderSizeAllowedForCompression_A36206.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_3F18:
			this.CpyBtnDataWideExternalDataOORTime_43366 = (global::AcpUI.AcpCopyButton)target;
			return;
			IL_3F25:
			this.ExpanderDataWideDataUserListTableTableView = (global::AcpUI.AcpGroupBox)target;
			return;
			IL_3F32:
			this.LblDataWideGeneralInternalRadioSubnet_A42073 = (global::AcpUI.AcpLabel)target;
			this.LblDataWideGeneralInternalRadioSubnet_A42073.MouseDoubleClick += new global::System.Windows.Input.MouseButtonEventHandler(this.OnFieldNameDoubleClick);
			return;
			IL_3F56:
			this.DataWideExternalDataModemType_42843Comp = (global::AcpUI.AcpLabel)target;
			return;
			IL_3F63:
			this.DataConfigDataWideMaxNumofTCPIPHCContexts_A36194 = (global::AcpUI.AcpTextBoxSpinner)target;
			this.DataConfigDataWideMaxNumofTCPIPHCContexts_A36194.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_3F87:
			this.DataWideGeneralContextDeactivationAlertTone_A7715Comp = (global::AcpUI.AcpCheckBox)target;
			return;
			IL_3F94:
			this.DataWideExternalDataModemMG90SatelliteEnabled_43777 = (global::AcpUI.AcpCheckBox)target;
			this.DataWideExternalDataModemMG90SatelliteEnabled_43777.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_3FB8:
			this.DataWideWiFiNetworkPriority_42512Comp = (global::AcpUI.AcpLabel)target;
			return;
			IL_3FC5:
			this.RTDBtnDataWideIdentityManagementGatewayHostname_43556 = (global::AcpUI.AcpRtdButton)target;
			return;
			IL_3FD2:
			this.CVBtnDataWideEncryptedModemPassword_43361 = (global::AcpUI.AcpCustomViewCheckBox)target;
			return;
			IL_3FDF:
			this.RTDBtnDataWideWiFiNetworkSSID_42519 = (global::AcpUI.AcpRtdButton)target;
			return;
			IL_3FEC:
			this.AcknowledgedWeaponFiredEventReportingEnable_43582 = (global::AcpUI.AcpCheckBox)target;
			this.AcknowledgedWeaponFiredEventReportingEnable_43582.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_4010:
			this.DataWideLTEClass3AccessPointName_A42392Comp = (global::AcpUI.AcpLabel)target;
			return;
			IL_401D:
			this.ExpanderDataWidePortConfiguration = (global::AcpUI.AcpExpander)target;
			return;
			IL_402A:
			this.RandomAccessAckTimerMsec_42016 = (global::AcpUI.AcpTextBoxSpinner)target;
			this.RandomAccessAckTimerMsec_42016.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_404E:
			this.HLinkExternalDataModem = (global::System.Windows.Documents.Hyperlink)target;
			this.HLinkExternalDataModem.Click += this.HLinkClick;
			return;
			IL_4072:
			this.LblDataWideExternalDataModemSecurityType_43360 = (global::AcpUI.AcpLabel)target;
			this.LblDataWideExternalDataModemSecurityType_43360.MouseDoubleClick += new global::System.Windows.Input.MouseButtonEventHandler(this.OnFieldNameDoubleClick);
			return;
			IL_4096:
			this.DataWideGeneralBTDUNPeerIPAddress_A41123 = (global::AcpUI.AcpTextBox)target;
			this.DataWideGeneralBTDUNPeerIPAddress_A41123.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_40BA:
			this.CpyBtnDataWideEncryptedModemPassword_43361 = (global::AcpUI.AcpCopyButton)target;
			return;
			IL_40C7:
			this.HLinkWIFI = (global::System.Windows.Documents.Hyperlink)target;
			this.HLinkWIFI.Click += this.HLinkClick;
			return;
			IL_40EB:
			this.CpyBtnDataWideGeneralDeleteMessagesOnSessionEnd_41308 = (global::AcpUI.AcpCopyButton)target;
			return;
			IL_40F8:
			this.DataCfgDataWideTimeSourceVar_A36196Comp = (global::AcpUI.AcpLabel)target;
			return;
			IL_4105:
			this.HLinkDataUserList = (global::System.Windows.Documents.Hyperlink)target;
			this.HLinkDataUserList.Click += this.HLinkClick;
			return;
			IL_4129:
			this.RTDBtnDataCfgDataWideTimeSourceVar_A36196 = (global::AcpUI.AcpRtdButton)target;
			return;
			IL_4136:
			this.CpyBtnDataWideGeneralPeerIPAddressAssignmentType2_A22377 = (global::AcpUI.AcpCopyButton)target;
			return;
			IL_4143:
			this.DataWideDataModemPassword_A42848Comp = (global::AcpUI.AcpLabel)target;
			return;
			IL_4150:
			this.LblSensorMeasurementReportingUDPPort_A43022 = (global::AcpUI.AcpLabel)target;
			this.LblSensorMeasurementReportingUDPPort_A43022.MouseDoubleClick += new global::System.Windows.Input.MouseButtonEventHandler(this.OnFieldNameDoubleClick);
			return;
			IL_4174:
			this.LblDataWideWiFiNetworkPriority_42512 = (global::AcpUI.AcpLabel)target;
			this.LblDataWideWiFiNetworkPriority_42512.MouseDoubleClick += new global::System.Windows.Input.MouseButtonEventHandler(this.OnFieldNameDoubleClick);
			return;
			IL_4198:
			this.LblDataWideExternalDataOORTime_43366 = (global::AcpUI.AcpLabel)target;
			this.LblDataWideExternalDataOORTime_43366.MouseDoubleClick += new global::System.Windows.Input.MouseButtonEventHandler(this.OnFieldNameDoubleClick);
			return;
			IL_41BC:
			this.CVBtnDataWideGeneralSNMPTraps_A9166 = (global::AcpUI.AcpCustomViewCheckBox)target;
			return;
			IL_41C9:
			this.GrpBoxExpanderDataWideLTEPseudo0 = (global::AcpUI.AcpGroupBox)target;
			return;
			IL_41D6:
			this.LblDataWideLabtoolDeviceProvisioningServiceIDScope_43553 = (global::AcpUI.AcpLabel)target;
			this.LblDataWideLabtoolDeviceProvisioningServiceIDScope_43553.MouseDoubleClick += new global::System.Windows.Input.MouseButtonEventHandler(this.OnFieldNameDoubleClick);
			return;
			IL_41FA:
			this.CpyBtnDataWideExternalDataModemLTEFriendlyName_43775 = (global::AcpUI.AcpCopyButton)target;
			return;
			IL_4207:
			this.ExpanderDataWideDataUserListTableGrid = (global::System.Windows.Controls.Grid)target;
			return;
			IL_4214:
			this.DataWideDataUserListDataUserInformation_A7800 = (global::AcpUI.AcpTextBox)target;
			this.DataWideDataUserListDataUserInformation_A7800.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_4238:
			this.CVBtnDataWideExternalDataModemMG90SatelliteFriendlyName_43776 = (global::AcpUI.AcpCustomViewCheckBox)target;
			return;
			IL_4245:
			this.RTDBtnDataWideExternalDataModemType_42843 = (global::AcpUI.AcpRtdButton)target;
			return;
			IL_4252:
			this.b = true;
		}

		// Token: 0x0600A34C RID: 41804 RVA: 0x00989480 File Offset: 0x00987680
		[global::System.Diagnostics.DebuggerNonUserCode]
		[global::System.CodeDom.Compiler.GeneratedCode("PresentationBuildTasks", "5.0.10.0")]
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		void global::System.Windows.Markup.IStyleConnector.Connect(int connectionId, object target)
		{
			switch (connectionId)
			{
			case 2:
				((global::AcpUI.AcpTableTextBoxSpinner)target).GotFocus += this.OnFieldNameDoubleClick;
				return;
			case 3:
				((global::AcpUI.AcpTableTextBox)target).GotFocus += this.OnFieldNameDoubleClick;
				return;
			case 4:
				((global::AcpUI.AcpTableComboBox)target).GotFocus += this.OnFieldNameDoubleClick;
				return;
			case 5:
				((global::AcpUI.AcpTablePasswordEyeBox)target).GotFocus += this.OnFieldNameDoubleClick;
				return;
			case 6:
				((global::AcpUI.AcpTableCheckBox)target).GotFocus += this.OnFieldNameDoubleClick;
				return;
			case 7:
				((global::AcpUI.AcpTableTextBoxSpinner)target).GotFocus += this.OnFieldNameDoubleClick;
				return;
			case 8:
				((global::AcpUI.AcpTableTextBox)target).GotFocus += this.OnFieldNameDoubleClick;
				return;
			case 9:
				((global::AcpUI.AcpTableComboBox)target).GotFocus += this.OnFieldNameDoubleClick;
				return;
			case 10:
				((global::AcpUI.AcpTablePasswordEyeBox)target).GotFocus += this.OnFieldNameDoubleClick;
				return;
			case 11:
				((global::AcpUI.AcpTableComboBox)target).GotFocus += this.OnFieldNameDoubleClick;
				return;
			case 12:
			{
				short num = (short)1266809080;
				short num2 = num;
				num = (short)1316681976;
				switch ((num2 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					break;
				default:
					num = (short)597753856;
					if (num != 0)
					{
					}
					((global::AcpUI.AcpTablePasswordEyeBox)target).GotFocus += this.OnFieldNameDoubleClick;
					return;
				}
				break;
			}
			case 13:
			{
				short num = (short)2053439489;
				if (num != 0)
				{
				}
				((global::AcpUI.AcpTableTextBoxSpinner)target).GotFocus += this.OnFieldNameDoubleClick;
				return;
			}
			case 14:
				((global::AcpUI.AcpTableTextBoxSpinner)target).GotFocus += this.OnFieldNameDoubleClick;
				return;
			case 15:
				((global::AcpUI.AcpTableTextBoxSpinner)target).GotFocus += this.OnFieldNameDoubleClick;
				return;
			case 16:
				((global::AcpUI.AcpTableTextBoxSpinner)target).GotFocus += this.OnFieldNameDoubleClick;
				return;
			case 17:
				((global::AcpUI.AcpTableTextBox)target).GotFocus += this.OnFieldNameDoubleClick;
				return;
			case 18:
				((global::AcpUI.AcpTableTextBox)target).GotFocus += this.OnFieldNameDoubleClick;
				return;
			case 19:
				break;
			case 20:
				((global::AcpUI.AcpTableTextBox)target).GotFocus += this.OnFieldNameDoubleClick;
				return;
			case 21:
				((global::AcpUI.AcpTableTextBoxSpinner)target).GotFocus += this.OnFieldNameDoubleClick;
				return;
			case 22:
				((global::AcpUI.AcpTableTextBox)target).GotFocus += this.OnFieldNameDoubleClick;
				return;
			case 23:
			{
				short num = (short)54591488;
				short num3 = num;
				((global::AcpUI.AcpTableTextBoxSpinner)target).GotFocus += this.OnFieldNameDoubleClick;
				return;
			}
			case 24:
				((global::AcpUI.AcpTableTextBox)target).GotFocus += this.OnFieldNameDoubleClick;
				return;
			case 25:
				((global::AcpUI.AcpTableTextBox)target).GotFocus += this.OnFieldNameDoubleClick;
				return;
			case 26:
				((global::AcpUI.AcpTableCheckBox)target).GotFocus += this.OnFieldNameDoubleClick;
				return;
			default:
				return;
			}
			((global::AcpUI.AcpTableCheckBox)target).GotFocus += this.OnFieldNameDoubleClick;
		}

		// Token: 0x04004E23 RID: 20003
		private bool a;

		// Token: 0x04004E24 RID: 20004
		internal global::AcpUI.Common.AcpThemeBase ThemeBaseObj;

		// Token: 0x04004E25 RID: 20005
		internal global::System.Windows.Documents.Hyperlink HLinkGeneral;

		// Token: 0x04004E26 RID: 20006
		internal global::System.Windows.Documents.Hyperlink HLinkPOP25;

		// Token: 0x04004E27 RID: 20007
		internal global::System.Windows.Documents.Hyperlink HLinkLTE;

		// Token: 0x04004E28 RID: 20008
		internal global::System.Windows.Documents.Hyperlink HLinkWIFI;

		// Token: 0x04004E29 RID: 20009
		internal global::System.Windows.Documents.Hyperlink HLinkExternalDataModem;

		// Token: 0x04004E2A RID: 20010
		internal global::System.Windows.Documents.Hyperlink HLinkNATList;

		// Token: 0x04004E2B RID: 20011
		internal global::System.Windows.Documents.Hyperlink HLinkDataUserList;

		// Token: 0x04004E2C RID: 20012
		internal global::System.Windows.Documents.Hyperlink HLinkQuickTextMessageList;

		// Token: 0x04004E2D RID: 20013
		internal global::System.Windows.Documents.Hyperlink HLinkDataProtocolConfiguration;

		// Token: 0x04004E2E RID: 20014
		internal global::System.Windows.Documents.Hyperlink HLinkPortConfiguration;

		// Token: 0x04004E2F RID: 20015
		internal global::System.Windows.Documents.Hyperlink HLinkLabtoolDATA_CFG;

		// Token: 0x04004E30 RID: 20016
		internal global::System.Windows.Controls.StackPanel MyStackPanel;

		// Token: 0x04004E31 RID: 20017
		internal global::AcpUI.AcpExpander ExpanderDataWideGeneral;

		// Token: 0x04004E32 RID: 20018
		internal global::AcpUI.AcpGroupBox GrpBoxExpanderDataWideGeneralPseudo0;

		// Token: 0x04004E33 RID: 20019
		internal global::AcpUI.AcpCustomViewCheckBox CVBtnDataWideGeneralSNMPTraps_A9166;

		// Token: 0x04004E34 RID: 20020
		internal global::AcpUI.AcpLabel LblDataWideGeneralSNMPTraps_A9166;

		// Token: 0x04004E35 RID: 20021
		internal global::AcpUI.AcpCheckBox DataWideGeneralSNMPTraps_A9166;

		// Token: 0x04004E36 RID: 20022
		internal global::AcpUI.AcpRtdButton RTDBtnDataWideGeneralSNMPTraps_A9166;

		// Token: 0x04004E37 RID: 20023
		internal global::AcpUI.AcpCopyButton CpyBtnDataWideGeneralSNMPTraps_A9166;

		// Token: 0x04004E38 RID: 20024
		internal global::AcpUI.AcpCheckBox DataWideGeneralSNMPTraps_A9166Comp;

		// Token: 0x04004E39 RID: 20025
		internal global::AcpUI.AcpCustomViewCheckBox CVBtnDataWideGeneralContextDeactivationAlertTone_A7715;

		// Token: 0x04004E3A RID: 20026
		internal global::AcpUI.AcpLabel LblDataWideGeneralContextDeactivationAlertTone_A7715;

		// Token: 0x04004E3B RID: 20027
		internal global::AcpUI.AcpCheckBox DataWideGeneralContextDeactivationAlertTone_A7715;

		// Token: 0x04004E3C RID: 20028
		internal global::AcpUI.AcpRtdButton RTDBtnDataWideGeneralContextDeactivationAlertTone_A7715;

		// Token: 0x04004E3D RID: 20029
		internal global::AcpUI.AcpCopyButton CpyBtnDataWideGeneralContextDeactivationAlertTone_A7715;

		// Token: 0x04004E3E RID: 20030
		internal global::AcpUI.AcpCheckBox DataWideGeneralContextDeactivationAlertTone_A7715Comp;

		// Token: 0x04004E3F RID: 20031
		internal global::AcpUI.AcpCustomViewCheckBox CVBtnDataWideGeneralICMPEcho_A8219;

		// Token: 0x04004E40 RID: 20032
		internal global::AcpUI.AcpLabel LblDataWideGeneralICMPEcho_A8219;

		// Token: 0x04004E41 RID: 20033
		internal global::AcpUI.AcpCheckBox DataWideGeneralICMPEcho_A8219;

		// Token: 0x04004E42 RID: 20034
		internal global::AcpUI.AcpRtdButton RTDBtnDataWideGeneralICMPEcho_A8219;

		// Token: 0x04004E43 RID: 20035
		internal global::AcpUI.AcpCopyButton CpyBtnDataWideGeneralICMPEcho_A8219;

		// Token: 0x04004E44 RID: 20036
		internal global::AcpUI.AcpCheckBox DataWideGeneralICMPEcho_A8219Comp;

		// Token: 0x04004E45 RID: 20037
		internal global::AcpUI.AcpGroupBox GrpBoxExpanderDataWideGeneralSerialLink1Addresses;

		// Token: 0x04004E46 RID: 20038
		internal global::AcpUI.AcpCustomViewCheckBox CVBtnDataWideGeneralSubscriberIPAddress1_A9222;

		// Token: 0x04004E47 RID: 20039
		internal global::AcpUI.AcpLabel LblDataWideGeneralSubscriberIPAddress1_A9222;

		// Token: 0x04004E48 RID: 20040
		internal global::AcpUI.AcpTextBox DataWideGeneralSubscriberIPAddress1_A9222;

		// Token: 0x04004E49 RID: 20041
		internal global::AcpUI.AcpRtdButton RTDBtnDataWideGeneralSubscriberIPAddress1_A9222;

		// Token: 0x04004E4A RID: 20042
		internal global::AcpUI.AcpCopyButton CpyBtnDataWideGeneralSubscriberIPAddress1_A9222;

		// Token: 0x04004E4B RID: 20043
		internal global::AcpUI.AcpLabel DataWideGeneralSubscriberIPAddress1_A9222Comp;

		// Token: 0x04004E4C RID: 20044
		internal global::AcpUI.AcpCustomViewCheckBox CVBtnDataWideGeneralPeerIPAddress1_A8524;

		// Token: 0x04004E4D RID: 20045
		internal global::AcpUI.AcpLabel LblDataWideGeneralPeerIPAddress1_A8524;

		// Token: 0x04004E4E RID: 20046
		internal global::AcpUI.AcpTextBox DataWideGeneralPeerIPAddress1_A8524;

		// Token: 0x04004E4F RID: 20047
		internal global::AcpUI.AcpRtdButton RTDBtnDataWideGeneralPeerIPAddress1_A8524;

		// Token: 0x04004E50 RID: 20048
		internal global::AcpUI.AcpCopyButton CpyBtnDataWideGeneralPeerIPAddress1_A8524;

		// Token: 0x04004E51 RID: 20049
		internal global::AcpUI.AcpLabel DataWideGeneralPeerIPAddress1_A8524Comp;

		// Token: 0x04004E52 RID: 20050
		internal global::AcpUI.AcpCustomViewCheckBox CVBtnDataWideGeneralPeerIPAddressAssignmentType1_A22376;

		// Token: 0x04004E53 RID: 20051
		internal global::AcpUI.AcpLabel LblDataWideGeneralPeerIPAddressAssignmentType1_A22376;

		// Token: 0x04004E54 RID: 20052
		internal global::AcpUI.AcpComboBox DataWideGeneralPeerIPAddressAssignmentType1_A22376;

		// Token: 0x04004E55 RID: 20053
		internal global::AcpUI.AcpRtdButton RTDBtnDataWideGeneralPeerIPAddressAssignmentType1_A22376;

		// Token: 0x04004E56 RID: 20054
		internal global::AcpUI.AcpCopyButton CpyBtnDataWideGeneralPeerIPAddressAssignmentType1_A22376;

		// Token: 0x04004E57 RID: 20055
		internal global::AcpUI.AcpLabel DataWideGeneralPeerIPAddressAssignmentType1_A22376Comp;

		// Token: 0x04004E58 RID: 20056
		internal global::AcpUI.AcpGroupBox GrpBoxExpanderDataWideGeneralBluetoothDialUpNetworkingAddresses;

		// Token: 0x04004E59 RID: 20057
		internal global::AcpUI.AcpCustomViewCheckBox CVBtnDataWideGeneralBTDUNSUIPAddress_A41120;

		// Token: 0x04004E5A RID: 20058
		internal global::AcpUI.AcpLabel LblDataWideGeneralBTDUNSUIPAddress_A41120;

		// Token: 0x04004E5B RID: 20059
		internal global::AcpUI.AcpTextBox DataWideGeneralBTDUNSUIPAddress_A41120;

		// Token: 0x04004E5C RID: 20060
		internal global::AcpUI.AcpRtdButton RTDBtnDataWideGeneralBTDUNSUIPAddress_A41120;

		// Token: 0x04004E5D RID: 20061
		internal global::AcpUI.AcpCopyButton CpyBtnDataWideGeneralBTDUNSUIPAddress_A41120;

		// Token: 0x04004E5E RID: 20062
		internal global::AcpUI.AcpLabel DataWideGeneralBTDUNSUIPAddress_A41120Comp;

		// Token: 0x04004E5F RID: 20063
		internal global::AcpUI.AcpCustomViewCheckBox CVBtnDataWideGeneralBTDUNPeerIPAddress_A41123;

		// Token: 0x04004E60 RID: 20064
		internal global::AcpUI.AcpLabel LblDataWideGeneralBTDUNPeerIPAddress_A41123;

		// Token: 0x04004E61 RID: 20065
		internal global::AcpUI.AcpTextBox DataWideGeneralBTDUNPeerIPAddress_A41123;

		// Token: 0x04004E62 RID: 20066
		internal global::AcpUI.AcpRtdButton RTDBtnDataWideGeneralBTDUNPeerIPAddress_A41123;

		// Token: 0x04004E63 RID: 20067
		internal global::AcpUI.AcpCopyButton CpyBtnDataWideGeneralBTDUNPeerIPAddress_A41123;

		// Token: 0x04004E64 RID: 20068
		internal global::AcpUI.AcpLabel DataWideGeneralBTDUNPeerIPAddress_A41123Comp;

		// Token: 0x04004E65 RID: 20069
		internal global::AcpUI.AcpCustomViewCheckBox CVBtnDataWideGeneralBTDUNPeerIPAddressAssignmentType_A41124;

		// Token: 0x04004E66 RID: 20070
		internal global::AcpUI.AcpLabel LblDataWideGeneralBTDUNPeerIPAddressAssignmentType_A41124;

		// Token: 0x04004E67 RID: 20071
		internal global::AcpUI.AcpComboBox DataWideGeneralBTDUNPeerIPAddressAssignmentType_A41124;

		// Token: 0x04004E68 RID: 20072
		internal global::AcpUI.AcpRtdButton RTDBtnDataWideGeneralBTDUNPeerIPAddressAssignmentType_A41124;

		// Token: 0x04004E69 RID: 20073
		internal global::AcpUI.AcpCopyButton CpyBtnDataWideGeneralBTDUNPeerIPAddressAssignmentType_A41124;

		// Token: 0x04004E6A RID: 20074
		internal global::AcpUI.AcpLabel DataWideGeneralBTDUNPeerIPAddressAssignmentType_A41124Comp;

		// Token: 0x04004E6B RID: 20075
		internal global::AcpUI.AcpGroupBox GrpBoxExpanderDataWideGeneralPseudo2;

		// Token: 0x04004E6C RID: 20076
		internal global::AcpUI.AcpCustomViewCheckBox CVBtnDataWideGeneralDeleteMessagesOnSessionEnd_41308;

		// Token: 0x04004E6D RID: 20077
		internal global::AcpUI.AcpLabel LblDataWideGeneralDeleteMessagesOnSessionEnd_41308;

		// Token: 0x04004E6E RID: 20078
		internal global::AcpUI.AcpCheckBox DataWideGeneralDeleteMessagesOnSessionEnd_41308;

		// Token: 0x04004E6F RID: 20079
		internal global::AcpUI.AcpRtdButton RTDBtnDataWideGeneralDeleteMessagesOnSessionEnd_41308;

		// Token: 0x04004E70 RID: 20080
		internal global::AcpUI.AcpCopyButton CpyBtnDataWideGeneralDeleteMessagesOnSessionEnd_41308;

		// Token: 0x04004E71 RID: 20081
		internal global::AcpUI.AcpCheckBox DataWideGeneralDeleteMessagesOnSessionEnd_41308Comp;

		// Token: 0x04004E72 RID: 20082
		internal global::AcpUI.AcpGroupBox GrpBoxExpanderDataWideGeneralSerialLink2Addresses;

		// Token: 0x04004E73 RID: 20083
		internal global::AcpUI.AcpCustomViewCheckBox CVBtnDataWideGeneralMobileSubIPAddress_A41819;

		// Token: 0x04004E74 RID: 20084
		internal global::AcpUI.AcpLabel LblDataWideGeneralMobileSubIPAddress_A41819;

		// Token: 0x04004E75 RID: 20085
		internal global::AcpUI.AcpTextBox DataWideGeneralMobileSubIPAddress_A41819;

		// Token: 0x04004E76 RID: 20086
		internal global::AcpUI.AcpRtdButton RTDBtnDataWideGeneralMobileSubIPAddress_A41819;

		// Token: 0x04004E77 RID: 20087
		internal global::AcpUI.AcpCopyButton CpyBtnDataWideGeneralMobileSubIPAddress_A41819;

		// Token: 0x04004E78 RID: 20088
		internal global::AcpUI.AcpLabel DataWideGeneralMobileSubIPAddress_A41819Comp;

		// Token: 0x04004E79 RID: 20089
		internal global::AcpUI.AcpCustomViewCheckBox CVBtnDataWideGeneralDVRIPAddress_A41818;

		// Token: 0x04004E7A RID: 20090
		internal global::AcpUI.AcpLabel LblDataWideGeneralDVRIPAddress_A41818;

		// Token: 0x04004E7B RID: 20091
		internal global::AcpUI.AcpTextBox DataWideGeneralDVRIPAddress_A41818;

		// Token: 0x04004E7C RID: 20092
		internal global::AcpUI.AcpRtdButton RTDBtnDataWideGeneralDVRIPAddress_A41818;

		// Token: 0x04004E7D RID: 20093
		internal global::AcpUI.AcpCopyButton CpyBtnDataWideGeneralDVRIPAddress_A41818;

		// Token: 0x04004E7E RID: 20094
		internal global::AcpUI.AcpLabel DataWideGeneralDVRIPAddress_A41818Comp;

		// Token: 0x04004E7F RID: 20095
		internal global::AcpUI.AcpCustomViewCheckBox CVBtnDataWideGeneralPeerIPAddressAssignmentType2_A22377;

		// Token: 0x04004E80 RID: 20096
		internal global::AcpUI.AcpLabel LblDataWideGeneralPeerIPAddressAssignmentType2_A22377;

		// Token: 0x04004E81 RID: 20097
		internal global::AcpUI.AcpComboBox DataWideGeneralPeerIPAddressAssignmentType2_A22377;

		// Token: 0x04004E82 RID: 20098
		internal global::AcpUI.AcpRtdButton RTDBtnDataWideGeneralPeerIPAddressAssignmentType2_A22377;

		// Token: 0x04004E83 RID: 20099
		internal global::AcpUI.AcpCopyButton CpyBtnDataWideGeneralPeerIPAddressAssignmentType2_A22377;

		// Token: 0x04004E84 RID: 20100
		internal global::AcpUI.AcpLabel DataWideGeneralPeerIPAddressAssignmentType2_A22377Comp;

		// Token: 0x04004E85 RID: 20101
		internal global::AcpUI.AcpGroupBox GrpBoxExpanderDataWideGeneralPseudo3;

		// Token: 0x04004E86 RID: 20102
		internal global::AcpUI.AcpCustomViewCheckBox CVBtnDataWideGeneralInternalRadioSubnet_A42073;

		// Token: 0x04004E87 RID: 20103
		internal global::AcpUI.AcpLabel LblDataWideGeneralInternalRadioSubnet_A42073;

		// Token: 0x04004E88 RID: 20104
		internal global::AcpUI.AcpTextBox DataWideGeneralInternalRadioSubnet_A42073;

		// Token: 0x04004E89 RID: 20105
		internal global::AcpUI.AcpRtdButton RTDBtnDataWideGeneralInternalRadioSubnet_A42073;

		// Token: 0x04004E8A RID: 20106
		internal global::AcpUI.AcpCopyButton CpyBtnDataWideGeneralInternalRadioSubnet_A42073;

		// Token: 0x04004E8B RID: 20107
		internal global::AcpUI.AcpLabel DataWideGeneralInternalRadioSubnet_A42073Comp;

		// Token: 0x04004E8C RID: 20108
		internal global::AcpUI.AcpCustomViewCheckBox CVBtnDataWideLTEAPCOAvalancheTime_A42204;

		// Token: 0x04004E8D RID: 20109
		internal global::AcpUI.AcpLabel LblDataWideLTEAPCOAvalancheTime_A42204;

		// Token: 0x04004E8E RID: 20110
		internal global::AcpUI.AcpTextBoxSpinner DataWideLTEAPCOAvalancheTime_A42204;

		// Token: 0x04004E8F RID: 20111
		internal global::AcpUI.AcpRtdButton RTDBtnDataWideLTEAPCOAvalancheTime_A42204;

		// Token: 0x04004E90 RID: 20112
		internal global::AcpUI.AcpCopyButton CpyBtnDataWideLTEAPCOAvalancheTime_A42204;

		// Token: 0x04004E91 RID: 20113
		internal global::AcpUI.AcpLabel DataWideLTEAPCOAvalancheTime_A42204Comp;

		// Token: 0x04004E92 RID: 20114
		internal global::AcpUI.AcpCustomViewCheckBox CVBtnDataWideGeneralBroadbandCheckbackTime_A42862;

		// Token: 0x04004E93 RID: 20115
		internal global::AcpUI.AcpLabel LblDataWideGeneralBroadbandCheckbackTime_A42862;

		// Token: 0x04004E94 RID: 20116
		internal global::AcpUI.AcpTextBoxSpinner DataWideGeneralBroadbandCheckbackTime_A42862;

		// Token: 0x04004E95 RID: 20117
		internal global::AcpUI.AcpRtdButton RTDBtnDataWideGeneralBroadbandCheckbackTime_A42862;

		// Token: 0x04004E96 RID: 20118
		internal global::AcpUI.AcpCopyButton CpyBtnDataWideGeneralBroadbandCheckbackTime_A42862;

		// Token: 0x04004E97 RID: 20119
		internal global::AcpUI.AcpLabel DataWideGeneralBroadbandCheckbackTime_A42862Comp;

		// Token: 0x04004E98 RID: 20120
		internal global::AcpUI.AcpCustomViewCheckBox CVBtnDirectTMSContentDisplay_42323;

		// Token: 0x04004E99 RID: 20121
		internal global::AcpUI.AcpLabel LblDirectTMSContentDisplay_42323;

		// Token: 0x04004E9A RID: 20122
		internal global::AcpUI.AcpCheckBox DirectTMSContentDisplay_42323;

		// Token: 0x04004E9B RID: 20123
		internal global::AcpUI.AcpRtdButton RTDBtnDirectTMSContentDisplay_42323;

		// Token: 0x04004E9C RID: 20124
		internal global::AcpUI.AcpCopyButton CpyBtnDirectTMSContentDisplay_42323;

		// Token: 0x04004E9D RID: 20125
		internal global::AcpUI.AcpCheckBox DirectTMSContentDisplay_42323Comp;

		// Token: 0x04004E9E RID: 20126
		internal global::AcpUI.AcpCustomViewCheckBox CVBtnDataWideExternalTextMessagingBroadcast_42418;

		// Token: 0x04004E9F RID: 20127
		internal global::AcpUI.AcpLabel LblDataWideExternalTextMessagingBroadcast_42418;

		// Token: 0x04004EA0 RID: 20128
		internal global::AcpUI.AcpCheckBox DataWideExternalTextMessagingBroadcast_42418;

		// Token: 0x04004EA1 RID: 20129
		internal global::AcpUI.AcpRtdButton RTDBtnDataWideExternalTextMessagingBroadcast_42418;

		// Token: 0x04004EA2 RID: 20130
		internal global::AcpUI.AcpCopyButton CpyBtnDataWideExternalTextMessagingBroadcast_42418;

		// Token: 0x04004EA3 RID: 20131
		internal global::AcpUI.AcpCheckBox DataWideExternalTextMessagingBroadcast_42418Comp;

		// Token: 0x04004EA4 RID: 20132
		internal global::AcpUI.AcpCustomViewCheckBox CVBtnSensorMeasurementReporting_A43021;

		// Token: 0x04004EA5 RID: 20133
		internal global::AcpUI.AcpLabel LblSensorMeasurementReporting_A43021;

		// Token: 0x04004EA6 RID: 20134
		internal global::AcpUI.AcpCheckBox SensorMeasurementReporting_A43021;

		// Token: 0x04004EA7 RID: 20135
		internal global::AcpUI.AcpRtdButton RTDBtnSensorMeasurementReporting_A43021;

		// Token: 0x04004EA8 RID: 20136
		internal global::AcpUI.AcpCopyButton CpyBtnSensorMeasurementReporting_A43021;

		// Token: 0x04004EA9 RID: 20137
		internal global::AcpUI.AcpCheckBox SensorMeasurementReporting_A43021Comp;

		// Token: 0x04004EAA RID: 20138
		internal global::AcpUI.AcpCustomViewCheckBox CVBtnAcknowledgedWeaponFiredEventReportingEnable_43582;

		// Token: 0x04004EAB RID: 20139
		internal global::AcpUI.AcpLabel LblAcknowledgedWeaponFiredEventReportingEnable_43582;

		// Token: 0x04004EAC RID: 20140
		internal global::AcpUI.AcpCheckBox AcknowledgedWeaponFiredEventReportingEnable_43582;

		// Token: 0x04004EAD RID: 20141
		internal global::AcpUI.AcpRtdButton RTDBtnAcknowledgedWeaponFiredEventReportingEnable_43582;

		// Token: 0x04004EAE RID: 20142
		internal global::AcpUI.AcpCopyButton CpyBtnAcknowledgedWeaponFiredEventReportingEnable_43582;

		// Token: 0x04004EAF RID: 20143
		internal global::AcpUI.AcpCheckBox AcknowledgedWeaponFiredEventReportingEnable_43582Comp;

		// Token: 0x04004EB0 RID: 20144
		internal global::AcpUI.AcpCustomViewCheckBox CVBtnAcknowledgedGunHolsterStateReportingEnable_43551;

		// Token: 0x04004EB1 RID: 20145
		internal global::AcpUI.AcpLabel LblAcknowledgedGunHolsterStateReportingEnable_43551;

		// Token: 0x04004EB2 RID: 20146
		internal global::AcpUI.AcpCheckBox AcknowledgedGunHolsterStateReportingEnable_43551;

		// Token: 0x04004EB3 RID: 20147
		internal global::AcpUI.AcpRtdButton RTDBtnAcknowledgedGunHolsterStateReportingEnable_43551;

		// Token: 0x04004EB4 RID: 20148
		internal global::AcpUI.AcpCopyButton CpyBtnAcknowledgedGunHolsterStateReportingEnable_43551;

		// Token: 0x04004EB5 RID: 20149
		internal global::AcpUI.AcpCheckBox AcknowledgedGunHolsterStateReportingEnable_43551Comp;

		// Token: 0x04004EB6 RID: 20150
		internal global::AcpUI.AcpCustomViewCheckBox CVBtnAcknowledgedStunGunStateReportingEnable_43552;

		// Token: 0x04004EB7 RID: 20151
		internal global::AcpUI.AcpLabel LblAcknowledgedStunGunStateReportingEnable_43552;

		// Token: 0x04004EB8 RID: 20152
		internal global::AcpUI.AcpCheckBox AcknowledgedStunGunStateReportingEnable_43552;

		// Token: 0x04004EB9 RID: 20153
		internal global::AcpUI.AcpRtdButton RTDBtnAcknowledgedStunGunStateReportingEnable_43552;

		// Token: 0x04004EBA RID: 20154
		internal global::AcpUI.AcpCopyButton CpyBtnAcknowledgedStunGunStateReportingEnable_43552;

		// Token: 0x04004EBB RID: 20155
		internal global::AcpUI.AcpCheckBox AcknowledgedStunGunStateReportingEnable_43552Comp;

		// Token: 0x04004EBC RID: 20156
		internal global::AcpUI.AcpExpander ExpanderDataWidePOP25;

		// Token: 0x04004EBD RID: 20157
		internal global::AcpUI.AcpGroupBox GrpBoxExpanderDataWidePOP25Pseudo0;

		// Token: 0x04004EBE RID: 20158
		internal global::AcpUI.AcpCustomViewCheckBox CVBtnDataWidePOP25OTAPIndications_A8670;

		// Token: 0x04004EBF RID: 20159
		internal global::AcpUI.AcpLabel LblDataWidePOP25OTAPIndications_A8670;

		// Token: 0x04004EC0 RID: 20160
		internal global::AcpUI.AcpComboBox DataWidePOP25OTAPIndications_A8670;

		// Token: 0x04004EC1 RID: 20161
		internal global::AcpUI.AcpRtdButton RTDBtnDataWidePOP25OTAPIndications_A8670;

		// Token: 0x04004EC2 RID: 20162
		internal global::AcpUI.AcpCopyButton CpyBtnDataWidePOP25OTAPIndications_A8670;

		// Token: 0x04004EC3 RID: 20163
		internal global::AcpUI.AcpLabel DataWidePOP25OTAPIndications_A8670Comp;

		// Token: 0x04004EC4 RID: 20164
		internal global::AcpUI.AcpCustomViewCheckBox CVBtnDataWidePOP25OTAPRejectEnable_A8671;

		// Token: 0x04004EC5 RID: 20165
		internal global::AcpUI.AcpLabel LblDataWidePOP25OTAPRejectEnable_A8671;

		// Token: 0x04004EC6 RID: 20166
		internal global::AcpUI.AcpCheckBox DataWidePOP25OTAPRejectEnable_A8671;

		// Token: 0x04004EC7 RID: 20167
		internal global::AcpUI.AcpRtdButton RTDBtnDataWidePOP25OTAPRejectEnable_A8671;

		// Token: 0x04004EC8 RID: 20168
		internal global::AcpUI.AcpCopyButton CpyBtnDataWidePOP25OTAPRejectEnable_A8671;

		// Token: 0x04004EC9 RID: 20169
		internal global::AcpUI.AcpCheckBox DataWidePOP25OTAPRejectEnable_A8671Comp;

		// Token: 0x04004ECA RID: 20170
		internal global::AcpUI.AcpCustomViewCheckBox CVBtnDataWidePOP25AutoResetEnable_A37221;

		// Token: 0x04004ECB RID: 20171
		internal global::AcpUI.AcpLabel LblDataWidePOP25AutoResetEnable_A37221;

		// Token: 0x04004ECC RID: 20172
		internal global::AcpUI.AcpCheckBox DataWidePOP25AutoResetEnable_A37221;

		// Token: 0x04004ECD RID: 20173
		internal global::AcpUI.AcpRtdButton RTDBtnDataWidePOP25AutoResetEnable_A37221;

		// Token: 0x04004ECE RID: 20174
		internal global::AcpUI.AcpCopyButton CpyBtnDataWidePOP25AutoResetEnable_A37221;

		// Token: 0x04004ECF RID: 20175
		internal global::AcpUI.AcpCheckBox DataWidePOP25AutoResetEnable_A37221Comp;

		// Token: 0x04004ED0 RID: 20176
		internal global::AcpUI.AcpExpander ExpanderDataWideLTE;

		// Token: 0x04004ED1 RID: 20177
		internal global::AcpUI.AcpGroupBox GrpBoxExpanderDataWideLTEPseudo0;

		// Token: 0x04004ED2 RID: 20178
		internal global::AcpUI.AcpCustomViewCheckBox CVBtnDataWideLTEOutOfRangeThresholdTime_A42206;

		// Token: 0x04004ED3 RID: 20179
		internal global::AcpUI.AcpLabel LblDataWideLTEOutOfRangeThresholdTime_A42206;

		// Token: 0x04004ED4 RID: 20180
		internal global::AcpUI.AcpTextBoxSpinner DataWideLTEOutOfRangeThresholdTime_A42206;

		// Token: 0x04004ED5 RID: 20181
		internal global::AcpUI.AcpRtdButton RTDBtnDataWideLTEOutOfRangeThresholdTime_A42206;

		// Token: 0x04004ED6 RID: 20182
		internal global::AcpUI.AcpCopyButton CpyBtnDataWideLTEOutOfRangeThresholdTime_A42206;

		// Token: 0x04004ED7 RID: 20183
		internal global::AcpUI.AcpLabel DataWideLTEOutOfRangeThresholdTime_A42206Comp;

		// Token: 0x04004ED8 RID: 20184
		internal global::AcpUI.AcpCustomViewCheckBox CVBtnDataWideLTEOffMaxDetachTime_A42207;

		// Token: 0x04004ED9 RID: 20185
		internal global::AcpUI.AcpLabel LblDataWideLTEOffMaxDetachTime_A42207;

		// Token: 0x04004EDA RID: 20186
		internal global::AcpUI.AcpTextBoxSpinner DataWideLTEOffMaxDetachTime_A42207;

		// Token: 0x04004EDB RID: 20187
		internal global::AcpUI.AcpRtdButton RTDBtnDataWideLTEOffMaxDetachTime_A42207;

		// Token: 0x04004EDC RID: 20188
		internal global::AcpUI.AcpCopyButton CpyBtnDataWideLTEOffMaxDetachTime_A42207;

		// Token: 0x04004EDD RID: 20189
		internal global::AcpUI.AcpLabel DataWideLTEOffMaxDetachTime_A42207Comp;

		// Token: 0x04004EDE RID: 20190
		internal global::AcpUI.AcpCustomViewCheckBox CVBtnDataWideLTEModeChangeMaxDetachTime_A42208;

		// Token: 0x04004EDF RID: 20191
		internal global::AcpUI.AcpLabel LblDataWideLTEModeChangeMaxDetachTime_A42208;

		// Token: 0x04004EE0 RID: 20192
		internal global::AcpUI.AcpTextBoxSpinner DataWideLTEModeChangeMaxDetachTime_A42208;

		// Token: 0x04004EE1 RID: 20193
		internal global::AcpUI.AcpRtdButton RTDBtnDataWideLTEModeChangeMaxDetachTime_A42208;

		// Token: 0x04004EE2 RID: 20194
		internal global::AcpUI.AcpCopyButton CpyBtnDataWideLTEModeChangeMaxDetachTime_A42208;

		// Token: 0x04004EE3 RID: 20195
		internal global::AcpUI.AcpLabel DataWideLTEModeChangeMaxDetachTime_A42208Comp;

		// Token: 0x04004EE4 RID: 20196
		internal global::AcpUI.AcpCustomViewCheckBox CVBtnDataWideLTEOpenMaxGuardTime_A42391;

		// Token: 0x04004EE5 RID: 20197
		internal global::AcpUI.AcpLabel LblDataWideLTEOpenMaxGuardTime_A42391;

		// Token: 0x04004EE6 RID: 20198
		internal global::AcpUI.AcpTextBoxSpinner DataWideLTEOpenMaxGuardTime_A42391;

		// Token: 0x04004EE7 RID: 20199
		internal global::AcpUI.AcpRtdButton RTDBtnDataWideLTEOpenMaxGuardTime_A42391;

		// Token: 0x04004EE8 RID: 20200
		internal global::AcpUI.AcpCopyButton CpyBtnDataWideLTEOpenMaxGuardTime_A42391;

		// Token: 0x04004EE9 RID: 20201
		internal global::AcpUI.AcpLabel DataWideLTEOpenMaxGuardTime_A42391Comp;

		// Token: 0x04004EEA RID: 20202
		internal global::AcpUI.AcpCustomViewCheckBox CVBtnDataWideLTEClass3AccessPointName_A42392;

		// Token: 0x04004EEB RID: 20203
		internal global::AcpUI.AcpLabel LblDataWideLTEClass3AccessPointName_A42392;

		// Token: 0x04004EEC RID: 20204
		internal global::AcpUI.AcpTextBox DataWideLTEClass3AccessPointName_A42392;

		// Token: 0x04004EED RID: 20205
		internal global::AcpUI.AcpRtdButton RTDBtnDataWideLTEClass3AccessPointName_A42392;

		// Token: 0x04004EEE RID: 20206
		internal global::AcpUI.AcpCopyButton CpyBtnDataWideLTEClass3AccessPointName_A42392;

		// Token: 0x04004EEF RID: 20207
		internal global::AcpUI.AcpLabel DataWideLTEClass3AccessPointName_A42392Comp;

		// Token: 0x04004EF0 RID: 20208
		internal global::AcpUI.AcpCustomViewCheckBox CVBtnDataWideLTELTECheckbackTime_A42205;

		// Token: 0x04004EF1 RID: 20209
		internal global::AcpUI.AcpLabel LblDataWideLTELTECheckbackTime_A42205;

		// Token: 0x04004EF2 RID: 20210
		internal global::AcpUI.AcpTextBoxSpinner DataWideLTELTECheckbackTime_A42205;

		// Token: 0x04004EF3 RID: 20211
		internal global::AcpUI.AcpRtdButton RTDBtnDataWideLTELTECheckbackTime_A42205;

		// Token: 0x04004EF4 RID: 20212
		internal global::AcpUI.AcpCopyButton CpyBtnDataWideLTELTECheckbackTime_A42205;

		// Token: 0x04004EF5 RID: 20213
		internal global::AcpUI.AcpLabel DataWideLTELTECheckbackTime_A42205Comp;

		// Token: 0x04004EF6 RID: 20214
		internal global::AcpUI.AcpCustomViewCheckBox CVBtnDataWideLTEOperation_A42215;

		// Token: 0x04004EF7 RID: 20215
		internal global::AcpUI.AcpLabel LblDataWideLTEOperation_A42215;

		// Token: 0x04004EF8 RID: 20216
		internal global::AcpUI.AcpCheckBox DataWideLTEOperation_A42215;

		// Token: 0x04004EF9 RID: 20217
		internal global::AcpUI.AcpRtdButton RTDBtnDataWideLTEOperation_A42215;

		// Token: 0x04004EFA RID: 20218
		internal global::AcpUI.AcpCopyButton CpyBtnDataWideLTEOperation_A42215;

		// Token: 0x04004EFB RID: 20219
		internal global::AcpUI.AcpCheckBox DataWideLTEOperation_A42215Comp;

		// Token: 0x04004EFC RID: 20220
		internal global::AcpUI.AcpCustomViewCheckBox CVBtnDataWideDataOnRoaming_A42216;

		// Token: 0x04004EFD RID: 20221
		internal global::AcpUI.AcpLabel LblDataWideDataOnRoaming_A42216;

		// Token: 0x04004EFE RID: 20222
		internal global::AcpUI.AcpCheckBox DataWideDataOnRoaming_A42216;

		// Token: 0x04004EFF RID: 20223
		internal global::AcpUI.AcpRtdButton RTDBtnDataWideDataOnRoaming_A42216;

		// Token: 0x04004F00 RID: 20224
		internal global::AcpUI.AcpCopyButton CpyBtnDataWideDataOnRoaming_A42216;

		// Token: 0x04004F01 RID: 20225
		internal global::AcpUI.AcpCheckBox DataWideDataOnRoaming_A42216Comp;

		// Token: 0x04004F02 RID: 20226
		internal global::AcpUI.AcpCustomViewCheckBox CVBtnDataWideLTEHWEnable;

		// Token: 0x04004F03 RID: 20227
		internal global::AcpUI.AcpLabel LblDataWideLTEHWEnable;

		// Token: 0x04004F04 RID: 20228
		internal global::AcpUI.AcpCheckBox DataWideLTEHWEnable;

		// Token: 0x04004F05 RID: 20229
		internal global::AcpUI.AcpRtdButton RTDBtnDataWideLTEHWEnable;

		// Token: 0x04004F06 RID: 20230
		internal global::AcpUI.AcpCopyButton CpyBtnDataWideLTEHWEnable;

		// Token: 0x04004F07 RID: 20231
		internal global::AcpUI.AcpCheckBox DataWideLTEHWEnableComp;

		// Token: 0x04004F08 RID: 20232
		internal global::AcpUI.AcpExpander ExpanderDataWideWIFI;

		// Token: 0x04004F09 RID: 20233
		internal global::AcpUI.AcpRecNavToolbar RecNavToolbarExpanderDataWideConfiguredNetworksList;

		// Token: 0x04004F0A RID: 20234
		internal global::AcpUI.AcpGroupBox GrpBoxExpanderDataWideWIFIPseudo0;

		// Token: 0x04004F0B RID: 20235
		internal global::AcpUI.AcpCustomViewCheckBox CVBtnDataWideWIFIEnable_42506;

		// Token: 0x04004F0C RID: 20236
		internal global::AcpUI.AcpLabel LblDataWideWIFIEnable_42506;

		// Token: 0x04004F0D RID: 20237
		internal global::AcpUI.AcpCheckBox DataWideWIFIEnable_42506;

		// Token: 0x04004F0E RID: 20238
		internal global::AcpUI.AcpRtdButton RTDBtnDataWideWIFIEnable_42506;

		// Token: 0x04004F0F RID: 20239
		internal global::AcpUI.AcpCopyButton CpyBtnDataWideWIFIEnable_42506;

		// Token: 0x04004F10 RID: 20240
		internal global::AcpUI.AcpCheckBox DataWideWIFIEnable_42506Comp;

		// Token: 0x04004F11 RID: 20241
		internal global::AcpUI.AcpCustomViewCheckBox CVBtnDataWideWIFIAllowUserControl;

		// Token: 0x04004F12 RID: 20242
		internal global::AcpUI.AcpLabel LblDataWideWIFIAllowUserControl;

		// Token: 0x04004F13 RID: 20243
		internal global::AcpUI.AcpCheckBox DataWideWIFIAllowUserControl;

		// Token: 0x04004F14 RID: 20244
		internal global::AcpUI.AcpRtdButton RTDBtnDataWideWIFIAllowUserControl;

		// Token: 0x04004F15 RID: 20245
		internal global::AcpUI.AcpCopyButton CpyBtnDataWideWIFIAllowUserControl;

		// Token: 0x04004F16 RID: 20246
		internal global::AcpUI.AcpCheckBox DataWideWIFIAllowUserControlComp;

		// Token: 0x04004F17 RID: 20247
		internal global::System.Windows.Controls.Grid ExpanderDataWideWIFIGrid;

		// Token: 0x04004F18 RID: 20248
		internal global::System.Windows.Controls.Grid ExpanderDataWideConfiguredNetworksListGrid;

		// Token: 0x04004F19 RID: 20249
		internal global::AcpUI.AcpGroupBox ExpanderDataWideConfiguredNetworksListTableView;

		// Token: 0x04004F1A RID: 20250
		internal global::AcpUI.AcpXamDataPresenter ExpanderDataWideConfiguredNetworksList;

		// Token: 0x04004F1B RID: 20251
		internal global::Infragistics.Windows.DataPresenter.UnboundField DataWideWiFiNetworkPriority_42512_Col;

		// Token: 0x04004F1C RID: 20252
		internal global::Infragistics.Windows.DataPresenter.UnboundField DataWideWiFiNetworkSSID_42519_Col;

		// Token: 0x04004F1D RID: 20253
		internal global::Infragistics.Windows.DataPresenter.UnboundField DataWideWiFiNetworkSecurityType_42516_Col;

		// Token: 0x04004F1E RID: 20254
		internal global::Infragistics.Windows.DataPresenter.UnboundField DataWideWiFiNetworkEncryptedNetworkPassword_42517_Col;

		// Token: 0x04004F1F RID: 20255
		internal global::Infragistics.Windows.DataPresenter.UnboundField DataWideWIFINetworkHidden_Col;

		// Token: 0x04004F20 RID: 20256
		internal global::AcpUI.AcpGroupBox ExpanderDataWideConfiguredNetworksListSRecView;

		// Token: 0x04004F21 RID: 20257
		internal global::System.Windows.Controls.Grid gridExpanderDataWideConfiguredNetworksListSRecView;

		// Token: 0x04004F22 RID: 20258
		internal global::AcpUI.AcpTextBoxSpinner DataWideWiFiNetworkPriority_42512;

		// Token: 0x04004F23 RID: 20259
		internal global::AcpUI.AcpCustomViewCheckBox CVBtnDataWideWiFiNetworkPriority_42512;

		// Token: 0x04004F24 RID: 20260
		internal global::AcpUI.AcpLabel LblDataWideWiFiNetworkPriority_42512;

		// Token: 0x04004F25 RID: 20261
		internal global::AcpUI.AcpRtdButton RTDBtnDataWideWiFiNetworkPriority_42512;

		// Token: 0x04004F26 RID: 20262
		internal global::AcpUI.AcpCopyButton CpyBtnDataWideWiFiNetworkPriority_42512;

		// Token: 0x04004F27 RID: 20263
		internal global::AcpUI.AcpLabel DataWideWiFiNetworkPriority_42512Comp;

		// Token: 0x04004F28 RID: 20264
		internal global::AcpUI.AcpTextBox DataWideWiFiNetworkSSID_42519;

		// Token: 0x04004F29 RID: 20265
		internal global::AcpUI.AcpCustomViewCheckBox CVBtnDataWideWiFiNetworkSSID_42519;

		// Token: 0x04004F2A RID: 20266
		internal global::AcpUI.AcpLabel LblDataWideWiFiNetworkSSID_42519;

		// Token: 0x04004F2B RID: 20267
		internal global::AcpUI.AcpRtdButton RTDBtnDataWideWiFiNetworkSSID_42519;

		// Token: 0x04004F2C RID: 20268
		internal global::AcpUI.AcpCopyButton CpyBtnDataWideWiFiNetworkSSID_42519;

		// Token: 0x04004F2D RID: 20269
		internal global::AcpUI.AcpLabel DataWideWiFiNetworkSSID_42519Comp;

		// Token: 0x04004F2E RID: 20270
		internal global::AcpUI.AcpComboBox DataWideWiFiNetworkSecurityType_42516;

		// Token: 0x04004F2F RID: 20271
		internal global::AcpUI.AcpCustomViewCheckBox CVBtnDataWideWiFiNetworkSecurityType_42516;

		// Token: 0x04004F30 RID: 20272
		internal global::AcpUI.AcpLabel LblDataWideWiFiNetworkSecurityType_42516;

		// Token: 0x04004F31 RID: 20273
		internal global::AcpUI.AcpRtdButton RTDBtnDataWideWiFiNetworkSecurityType_42516;

		// Token: 0x04004F32 RID: 20274
		internal global::AcpUI.AcpCopyButton CpyBtnDataWideWiFiNetworkSecurityType_42516;

		// Token: 0x04004F33 RID: 20275
		internal global::AcpUI.AcpLabel DataWideWiFiNetworkSecurityType_42516Comp;

		// Token: 0x04004F34 RID: 20276
		internal global::AcpUI.AcpPasswordEyeBox DataWideWiFiNetworkEncryptedNetworkPassword_42517;

		// Token: 0x04004F35 RID: 20277
		internal global::AcpUI.AcpCustomViewCheckBox CVBtnDataWideWiFiNetworkEncryptedNetworkPassword_42517;

		// Token: 0x04004F36 RID: 20278
		internal global::AcpUI.AcpLabel LblDataWideWiFiNetworkEncryptedNetworkPassword_42517;

		// Token: 0x04004F37 RID: 20279
		internal global::AcpUI.AcpRtdButton RTDBtnDataWideWiFiNetworkEncryptedNetworkPassword_42517;

		// Token: 0x04004F38 RID: 20280
		internal global::AcpUI.AcpCopyButton CpyBtnDataWideWiFiNetworkEncryptedNetworkPassword_42517;

		// Token: 0x04004F39 RID: 20281
		internal global::AcpUI.AcpLabel DataWideWiFiNetworkEncryptedNetworkPassword_42517Comp;

		// Token: 0x04004F3A RID: 20282
		internal global::AcpUI.AcpCheckBox DataWideWIFINetworkHidden;

		// Token: 0x04004F3B RID: 20283
		internal global::AcpUI.AcpCustomViewCheckBox CVBtnDataWideWIFINetworkHidden;

		// Token: 0x04004F3C RID: 20284
		internal global::AcpUI.AcpLabel LblDataWideWIFINetworkHidden;

		// Token: 0x04004F3D RID: 20285
		internal global::AcpUI.AcpRtdButton RTDBtnDataWideWIFINetworkHidden;

		// Token: 0x04004F3E RID: 20286
		internal global::AcpUI.AcpCopyButton CpyBtnDataWideWIFINetworkHidden;

		// Token: 0x04004F3F RID: 20287
		internal global::AcpUI.AcpLabel DataWideWIFINetworkHiddenComp;

		// Token: 0x04004F40 RID: 20288
		internal global::AcpUI.AcpExpander ExpanderDataWideExternalDataModem;

		// Token: 0x04004F41 RID: 20289
		internal global::AcpUI.AcpRecNavToolbar RecNavToolbarExpanderDataWideDataModemTable;

		// Token: 0x04004F42 RID: 20290
		internal global::AcpUI.AcpGroupBox GrpBoxExpanderDataWideExternalDataModemPseudo0;

		// Token: 0x04004F43 RID: 20291
		internal global::AcpUI.AcpCustomViewCheckBox CVBtnModemConnectionType_43350;

		// Token: 0x04004F44 RID: 20292
		internal global::AcpUI.AcpLabel LblModemConnectionType_43350;

		// Token: 0x04004F45 RID: 20293
		internal global::AcpUI.AcpComboBox ModemConnectionType_43350;

		// Token: 0x04004F46 RID: 20294
		internal global::AcpUI.AcpRtdButton RTDBtnModemConnectionType_43350;

		// Token: 0x04004F47 RID: 20295
		internal global::AcpUI.AcpCopyButton CpyBtnModemConnectionType_43350;

		// Token: 0x04004F48 RID: 20296
		internal global::AcpUI.AcpLabel ModemConnectionType_43350Comp;

		// Token: 0x04004F49 RID: 20297
		internal global::AcpUI.AcpGroupBox GrpBoxExpanderDataWideExternalDataModemWiredModemConfiguration;

		// Token: 0x04004F4A RID: 20298
		internal global::AcpUI.AcpCustomViewCheckBox CVBtnDataWideExternalDataModemType_42843;

		// Token: 0x04004F4B RID: 20299
		internal global::AcpUI.AcpLabel LblDataWideExternalDataModemType_42843;

		// Token: 0x04004F4C RID: 20300
		internal global::AcpUI.AcpComboBox DataWideExternalDataModemType_42843;

		// Token: 0x04004F4D RID: 20301
		internal global::AcpUI.AcpRtdButton RTDBtnDataWideExternalDataModemType_42843;

		// Token: 0x04004F4E RID: 20302
		internal global::AcpUI.AcpCopyButton CpyBtnDataWideExternalDataModemType_42843;

		// Token: 0x04004F4F RID: 20303
		internal global::AcpUI.AcpLabel DataWideExternalDataModemType_42843Comp;

		// Token: 0x04004F50 RID: 20304
		internal global::AcpUI.AcpCustomViewCheckBox CVBtnDataWideExternalDataModemPort_42851;

		// Token: 0x04004F51 RID: 20305
		internal global::AcpUI.AcpLabel LblDataWideExternalDataModemPort_42851;

		// Token: 0x04004F52 RID: 20306
		internal global::AcpUI.AcpTextBoxSpinner DataWideExternalDataModemPort_42851;

		// Token: 0x04004F53 RID: 20307
		internal global::AcpUI.AcpRtdButton RTDBtnDataWideExternalDataModemPort_42851;

		// Token: 0x04004F54 RID: 20308
		internal global::AcpUI.AcpCopyButton CpyBtnDataWideExternalDataModemPort_42851;

		// Token: 0x04004F55 RID: 20309
		internal global::AcpUI.AcpLabel DataWideExternalDataModemPort_42851Comp;

		// Token: 0x04004F56 RID: 20310
		internal global::AcpUI.AcpCustomViewCheckBox CVBtnDataWideDataModemPassword_A42848;

		// Token: 0x04004F57 RID: 20311
		internal global::AcpUI.AcpLabel LblDataWideDataModemPassword_A42848;

		// Token: 0x04004F58 RID: 20312
		internal global::AcpUI.AcpPasswordEyeBox DataWideDataModemPassword_A42848;

		// Token: 0x04004F59 RID: 20313
		internal global::AcpUI.AcpRtdButton RTDBtnDataWideDataModemPassword_A42848;

		// Token: 0x04004F5A RID: 20314
		internal global::AcpUI.AcpCopyButton CpyBtnDataWideDataModemPassword_A42848;

		// Token: 0x04004F5B RID: 20315
		internal global::AcpUI.AcpLabel DataWideDataModemPassword_A42848Comp;

		// Token: 0x04004F5C RID: 20316
		internal global::AcpUI.AcpCustomViewCheckBox CVBtnDataWideExternalDataModemVPNTunnel_43024;

		// Token: 0x04004F5D RID: 20317
		internal global::AcpUI.AcpLabel LblDataWideExternalDataModemVPNTunnel_43024;

		// Token: 0x04004F5E RID: 20318
		internal global::AcpUI.AcpTextBoxSpinner DataWideExternalDataModemVPNTunnel_43024;

		// Token: 0x04004F5F RID: 20319
		internal global::AcpUI.AcpRtdButton RTDBtnDataWideExternalDataModemVPNTunnel_43024;

		// Token: 0x04004F60 RID: 20320
		internal global::AcpUI.AcpCopyButton CpyBtnDataWideExternalDataModemVPNTunnel_43024;

		// Token: 0x04004F61 RID: 20321
		internal global::AcpUI.AcpLabel DataWideExternalDataModemVPNTunnel_43024Comp;

		// Token: 0x04004F62 RID: 20322
		internal global::AcpUI.AcpCustomViewCheckBox CVBtnDataWideExternalDataModemOutOfRangeThreshold_42853;

		// Token: 0x04004F63 RID: 20323
		internal global::AcpUI.AcpLabel LblDataWideExternalDataModemOutOfRangeThreshold_42853;

		// Token: 0x04004F64 RID: 20324
		internal global::AcpUI.AcpTextBoxSpinner DataWideExternalDataModemOutOfRangeThreshold_42853;

		// Token: 0x04004F65 RID: 20325
		internal global::AcpUI.AcpRtdButton RTDBtnDataWideExternalDataModemOutOfRangeThreshold_42853;

		// Token: 0x04004F66 RID: 20326
		internal global::AcpUI.AcpCopyButton CpyBtnDataWideExternalDataModemOutOfRangeThreshold_42853;

		// Token: 0x04004F67 RID: 20327
		internal global::AcpUI.AcpLabel DataWideExternalDataModemOutOfRangeThreshold_42853Comp;

		// Token: 0x04004F68 RID: 20328
		internal global::AcpUI.AcpCustomViewCheckBox CVBtnDataWideExternalDataModemPowerupMaxGuardTime_42855;

		// Token: 0x04004F69 RID: 20329
		internal global::AcpUI.AcpLabel LblDataWideExternalDataModemPowerupMaxGuardTime_42855;

		// Token: 0x04004F6A RID: 20330
		internal global::AcpUI.AcpTextBoxSpinner DataWideExternalDataModemPowerupMaxGuardTime_42855;

		// Token: 0x04004F6B RID: 20331
		internal global::AcpUI.AcpRtdButton RTDBtnDataWideExternalDataModemPowerupMaxGuardTime_42855;

		// Token: 0x04004F6C RID: 20332
		internal global::AcpUI.AcpCopyButton CpyBtnDataWideExternalDataModemPowerupMaxGuardTime_42855;

		// Token: 0x04004F6D RID: 20333
		internal global::AcpUI.AcpLabel DataWideExternalDataModemPowerupMaxGuardTime_42855Comp;

		// Token: 0x04004F6E RID: 20334
		internal global::AcpUI.AcpCustomViewCheckBox CVBtnDataWideExternalDataModemOpenMaxGuardTime_42856;

		// Token: 0x04004F6F RID: 20335
		internal global::AcpUI.AcpLabel LblDataWideExternalDataModemOpenMaxGuardTime_42856;

		// Token: 0x04004F70 RID: 20336
		internal global::AcpUI.AcpTextBoxSpinner DataWideExternalDataModemOpenMaxGuardTime_42856;

		// Token: 0x04004F71 RID: 20337
		internal global::AcpUI.AcpRtdButton RTDBtnDataWideExternalDataModemOpenMaxGuardTime_42856;

		// Token: 0x04004F72 RID: 20338
		internal global::AcpUI.AcpCopyButton CpyBtnDataWideExternalDataModemOpenMaxGuardTime_42856;

		// Token: 0x04004F73 RID: 20339
		internal global::AcpUI.AcpLabel DataWideExternalDataModemOpenMaxGuardTime_42856Comp;

		// Token: 0x04004F74 RID: 20340
		internal global::AcpUI.AcpCustomViewCheckBox CVBtnDataWideExternalDataModemVPNFriendlyName_43774;

		// Token: 0x04004F75 RID: 20341
		internal global::AcpUI.AcpLabel LblDataWideExternalDataModemVPNFriendlyName_43774;

		// Token: 0x04004F76 RID: 20342
		internal global::AcpUI.AcpTextBox DataWideExternalDataModemVPNFriendlyName_43774;

		// Token: 0x04004F77 RID: 20343
		internal global::AcpUI.AcpRtdButton RTDBtnDataWideExternalDataModemVPNFriendlyName_43774;

		// Token: 0x04004F78 RID: 20344
		internal global::AcpUI.AcpCopyButton CpyBtnDataWideExternalDataModemVPNFriendlyName_43774;

		// Token: 0x04004F79 RID: 20345
		internal global::AcpUI.AcpLabel DataWideExternalDataModemVPNFriendlyName_43774Comp;

		// Token: 0x04004F7A RID: 20346
		internal global::AcpUI.AcpCustomViewCheckBox CVBtnDataWideExternalDataModemLTEFriendlyName_43775;

		// Token: 0x04004F7B RID: 20347
		internal global::AcpUI.AcpLabel LblDataWideExternalDataModemLTEFriendlyName_43775;

		// Token: 0x04004F7C RID: 20348
		internal global::AcpUI.AcpTextBox DataWideExternalDataModemLTEFriendlyName_43775;

		// Token: 0x04004F7D RID: 20349
		internal global::AcpUI.AcpRtdButton RTDBtnDataWideExternalDataModemLTEFriendlyName_43775;

		// Token: 0x04004F7E RID: 20350
		internal global::AcpUI.AcpCopyButton CpyBtnDataWideExternalDataModemLTEFriendlyName_43775;

		// Token: 0x04004F7F RID: 20351
		internal global::AcpUI.AcpLabel DataWideExternalDataModemLTEFriendlyName_43775Comp;

		// Token: 0x04004F80 RID: 20352
		internal global::AcpUI.AcpCustomViewCheckBox CVBtnDataWideExternalDataModemMG90SatelliteEnabled_43777;

		// Token: 0x04004F81 RID: 20353
		internal global::AcpUI.AcpLabel LblDataWideExternalDataModemMG90SatelliteEnabled_43777;

		// Token: 0x04004F82 RID: 20354
		internal global::AcpUI.AcpCheckBox DataWideExternalDataModemMG90SatelliteEnabled_43777;

		// Token: 0x04004F83 RID: 20355
		internal global::AcpUI.AcpRtdButton RTDBtnDataWideExternalDataModemMG90SatelliteEnabled_43777;

		// Token: 0x04004F84 RID: 20356
		internal global::AcpUI.AcpCopyButton CpyBtnDataWideExternalDataModemMG90SatelliteEnabled_43777;

		// Token: 0x04004F85 RID: 20357
		internal global::AcpUI.AcpCheckBox DataWideExternalDataModemMG90SatelliteEnabled_43777Comp;

		// Token: 0x04004F86 RID: 20358
		internal global::AcpUI.AcpCustomViewCheckBox CVBtnDataWideExternalDataModemMG90SatelliteFriendlyName_43776;

		// Token: 0x04004F87 RID: 20359
		internal global::AcpUI.AcpLabel LblDataWideExternalDataModemMG90SatelliteFriendlyName_43776;

		// Token: 0x04004F88 RID: 20360
		internal global::AcpUI.AcpTextBox DataWideExternalDataModemMG90SatelliteFriendlyName_43776;

		// Token: 0x04004F89 RID: 20361
		internal global::AcpUI.AcpRtdButton RTDBtnDataWideExternalDataModemMG90SatelliteFriendlyName_43776;

		// Token: 0x04004F8A RID: 20362
		internal global::AcpUI.AcpCopyButton CpyBtnDataWideExternalDataModemMG90SatelliteFriendlyName_43776;

		// Token: 0x04004F8B RID: 20363
		internal global::AcpUI.AcpLabel DataWideExternalDataModemMG90SatelliteFriendlyName_43776Comp;

		// Token: 0x04004F8C RID: 20364
		internal global::AcpUI.AcpGroupBox GrpBoxExpanderDataWideExternalDataModemPseudo1;

		// Token: 0x04004F8D RID: 20365
		internal global::AcpUI.AcpCustomViewCheckBox CVBtnDataWideExternalDataModemWifiPowerupGuardTime;

		// Token: 0x04004F8E RID: 20366
		internal global::AcpUI.AcpLabel LblDataWideExternalDataModemWifiPowerupGuardTime;

		// Token: 0x04004F8F RID: 20367
		internal global::AcpUI.AcpTextBoxSpinner DataWideExternalDataModemWifiPowerupGuardTime;

		// Token: 0x04004F90 RID: 20368
		internal global::AcpUI.AcpRtdButton RTDBtnDataWideExternalDataModemWifiPowerupGuardTime;

		// Token: 0x04004F91 RID: 20369
		internal global::AcpUI.AcpCopyButton CpyBtnDataWideExternalDataModemWifiPowerupGuardTime;

		// Token: 0x04004F92 RID: 20370
		internal global::AcpUI.AcpLabel DataWideExternalDataModemWifiPowerupGuardTimeComp;

		// Token: 0x04004F93 RID: 20371
		internal global::System.Windows.Controls.Grid ExpanderDataWideExternalDataModemGrid;

		// Token: 0x04004F94 RID: 20372
		internal global::System.Windows.Controls.Grid ExpanderDataWideDataModemTableGrid;

		// Token: 0x04004F95 RID: 20373
		internal global::AcpUI.AcpGroupBox ExpanderDataWideDataModemTableTableView;

		// Token: 0x04004F96 RID: 20374
		internal global::AcpUI.AcpXamDataPresenter ExpanderDataWideDataModemTable;

		// Token: 0x04004F97 RID: 20375
		internal global::Infragistics.Windows.DataPresenter.UnboundField DataWideExternalDataModemNetworkPriority_43358_Col;

		// Token: 0x04004F98 RID: 20376
		internal global::Infragistics.Windows.DataPresenter.UnboundField DataWideExternalDataModemNetworkSsid_43358_Col;

		// Token: 0x04004F99 RID: 20377
		internal global::Infragistics.Windows.DataPresenter.UnboundField DataWideExternalDataModemSecurityType_43360_Col;

		// Token: 0x04004F9A RID: 20378
		internal global::Infragistics.Windows.DataPresenter.UnboundField DataWideEncryptedNetworkPassword_43361_Col;

		// Token: 0x04004F9B RID: 20379
		internal global::Infragistics.Windows.DataPresenter.UnboundField DataWideExternalDataModemType_43362_Col;

		// Token: 0x04004F9C RID: 20380
		internal global::Infragistics.Windows.DataPresenter.UnboundField DataWideEncryptedModemPassword_43361_Col;

		// Token: 0x04004F9D RID: 20381
		internal global::Infragistics.Windows.DataPresenter.UnboundField DataWideExternalDataModemPort_Col;

		// Token: 0x04004F9E RID: 20382
		internal global::Infragistics.Windows.DataPresenter.UnboundField DataWideExternalDataVpnTunnel_43365_Col;

		// Token: 0x04004F9F RID: 20383
		internal global::Infragistics.Windows.DataPresenter.UnboundField DataWideExternalDataOORTime_43366_Col;

		// Token: 0x04004FA0 RID: 20384
		internal global::Infragistics.Windows.DataPresenter.UnboundField DataWideExternalDataModemOpenTime_43367_Col;

		// Token: 0x04004FA1 RID: 20385
		internal global::Infragistics.Windows.DataPresenter.UnboundField DataWideMG90WirelessVPNFriendlyName_43785_Col;

		// Token: 0x04004FA2 RID: 20386
		internal global::Infragistics.Windows.DataPresenter.UnboundField DataWideMG90WirelessLTEFriendlyName_43786_Col;

		// Token: 0x04004FA3 RID: 20387
		internal global::Infragistics.Windows.DataPresenter.UnboundField DataWideMG90WirelessSatelliteEnable_43788_Col;

		// Token: 0x04004FA4 RID: 20388
		internal global::Infragistics.Windows.DataPresenter.UnboundField DataWideMG90WirelessSatelliteFriendlyName_43787_Col;

		// Token: 0x04004FA5 RID: 20389
		internal global::Infragistics.Windows.DataPresenter.UnboundField DataWideExternalDataModemHiddenNetwork_44814_Col;

		// Token: 0x04004FA6 RID: 20390
		internal global::AcpUI.AcpGroupBox ExpanderDataWideDataModemTableSRecView;

		// Token: 0x04004FA7 RID: 20391
		internal global::System.Windows.Controls.Grid gridExpanderDataWideDataModemTableSRecView;

		// Token: 0x04004FA8 RID: 20392
		internal global::AcpUI.AcpTextBoxSpinner DataWideExternalDataModemNetworkPriority_43358;

		// Token: 0x04004FA9 RID: 20393
		internal global::AcpUI.AcpCustomViewCheckBox CVBtnDataWideExternalDataModemNetworkPriority_43358;

		// Token: 0x04004FAA RID: 20394
		internal global::AcpUI.AcpLabel LblDataWideExternalDataModemNetworkPriority_43358;

		// Token: 0x04004FAB RID: 20395
		internal global::AcpUI.AcpRtdButton RTDBtnDataWideExternalDataModemNetworkPriority_43358;

		// Token: 0x04004FAC RID: 20396
		internal global::AcpUI.AcpCopyButton CpyBtnDataWideExternalDataModemNetworkPriority_43358;

		// Token: 0x04004FAD RID: 20397
		internal global::AcpUI.AcpLabel DataWideExternalDataModemNetworkPriority_43358Comp;

		// Token: 0x04004FAE RID: 20398
		internal global::AcpUI.AcpTextBox DataWideExternalDataModemNetworkSsid_43358;

		// Token: 0x04004FAF RID: 20399
		internal global::AcpUI.AcpCustomViewCheckBox CVBtnDataWideExternalDataModemNetworkSsid_43358;

		// Token: 0x04004FB0 RID: 20400
		internal global::AcpUI.AcpLabel LblDataWideExternalDataModemNetworkSsid_43358;

		// Token: 0x04004FB1 RID: 20401
		internal global::AcpUI.AcpRtdButton RTDBtnDataWideExternalDataModemNetworkSsid_43358;

		// Token: 0x04004FB2 RID: 20402
		internal global::AcpUI.AcpCopyButton CpyBtnDataWideExternalDataModemNetworkSsid_43358;

		// Token: 0x04004FB3 RID: 20403
		internal global::AcpUI.AcpLabel DataWideExternalDataModemNetworkSsid_43358Comp;

		// Token: 0x04004FB4 RID: 20404
		internal global::AcpUI.AcpComboBox DataWideExternalDataModemSecurityType_43360;

		// Token: 0x04004FB5 RID: 20405
		internal global::AcpUI.AcpCustomViewCheckBox CVBtnDataWideExternalDataModemSecurityType_43360;

		// Token: 0x04004FB6 RID: 20406
		internal global::AcpUI.AcpLabel LblDataWideExternalDataModemSecurityType_43360;

		// Token: 0x04004FB7 RID: 20407
		internal global::AcpUI.AcpRtdButton RTDBtnDataWideExternalDataModemSecurityType_43360;

		// Token: 0x04004FB8 RID: 20408
		internal global::AcpUI.AcpCopyButton CpyBtnDataWideExternalDataModemSecurityType_43360;

		// Token: 0x04004FB9 RID: 20409
		internal global::AcpUI.AcpLabel DataWideExternalDataModemSecurityType_43360Comp;

		// Token: 0x04004FBA RID: 20410
		internal global::AcpUI.AcpPasswordEyeBox DataWideEncryptedNetworkPassword_43361;

		// Token: 0x04004FBB RID: 20411
		internal global::AcpUI.AcpCustomViewCheckBox CVBtnDataWideEncryptedNetworkPassword_43361;

		// Token: 0x04004FBC RID: 20412
		internal global::AcpUI.AcpLabel LblDataWideEncryptedNetworkPassword_43361;

		// Token: 0x04004FBD RID: 20413
		internal global::AcpUI.AcpRtdButton RTDBtnDataWideEncryptedNetworkPassword_43361;

		// Token: 0x04004FBE RID: 20414
		internal global::AcpUI.AcpCopyButton CpyBtnDataWideEncryptedNetworkPassword_43361;

		// Token: 0x04004FBF RID: 20415
		internal global::AcpUI.AcpLabel DataWideEncryptedNetworkPassword_43361Comp;

		// Token: 0x04004FC0 RID: 20416
		internal global::AcpUI.AcpComboBox DataWideExternalDataModemType_43362;

		// Token: 0x04004FC1 RID: 20417
		internal global::AcpUI.AcpCustomViewCheckBox CVBtnDataWideExternalDataModemType_43362;

		// Token: 0x04004FC2 RID: 20418
		internal global::AcpUI.AcpLabel LblDataWideExternalDataModemType_43362;

		// Token: 0x04004FC3 RID: 20419
		internal global::AcpUI.AcpRtdButton RTDBtnDataWideExternalDataModemType_43362;

		// Token: 0x04004FC4 RID: 20420
		internal global::AcpUI.AcpCopyButton CpyBtnDataWideExternalDataModemType_43362;

		// Token: 0x04004FC5 RID: 20421
		internal global::AcpUI.AcpLabel DataWideExternalDataModemType_43362Comp;

		// Token: 0x04004FC6 RID: 20422
		internal global::AcpUI.AcpPasswordEyeBox DataWideEncryptedModemPassword_43361;

		// Token: 0x04004FC7 RID: 20423
		internal global::AcpUI.AcpCustomViewCheckBox CVBtnDataWideEncryptedModemPassword_43361;

		// Token: 0x04004FC8 RID: 20424
		internal global::AcpUI.AcpLabel LblDataWideEncryptedModemPassword_43361;

		// Token: 0x04004FC9 RID: 20425
		internal global::AcpUI.AcpRtdButton RTDBtnDataWideEncryptedModemPassword_43361;

		// Token: 0x04004FCA RID: 20426
		internal global::AcpUI.AcpCopyButton CpyBtnDataWideEncryptedModemPassword_43361;

		// Token: 0x04004FCB RID: 20427
		internal global::AcpUI.AcpLabel DataWideEncryptedModemPassword_43361Comp;

		// Token: 0x04004FCC RID: 20428
		internal global::AcpUI.AcpTextBoxSpinner DataWideExternalDataModemPort;

		// Token: 0x04004FCD RID: 20429
		internal global::AcpUI.AcpCustomViewCheckBox CVBtnDataWideExternalDataModemPort;

		// Token: 0x04004FCE RID: 20430
		internal global::AcpUI.AcpLabel LblDataWideExternalDataModemPort;

		// Token: 0x04004FCF RID: 20431
		internal global::AcpUI.AcpRtdButton RTDBtnDataWideExternalDataModemPort;

		// Token: 0x04004FD0 RID: 20432
		internal global::AcpUI.AcpCopyButton CpyBtnDataWideExternalDataModemPort;

		// Token: 0x04004FD1 RID: 20433
		internal global::AcpUI.AcpLabel DataWideExternalDataModemPortComp;

		// Token: 0x04004FD2 RID: 20434
		internal global::AcpUI.AcpTextBoxSpinner DataWideExternalDataVpnTunnel_43365;

		// Token: 0x04004FD3 RID: 20435
		internal global::AcpUI.AcpCustomViewCheckBox CVBtnDataWideExternalDataVpnTunnel_43365;

		// Token: 0x04004FD4 RID: 20436
		internal global::AcpUI.AcpLabel LblDataWideExternalDataVpnTunnel_43365;

		// Token: 0x04004FD5 RID: 20437
		internal global::AcpUI.AcpRtdButton RTDBtnDataWideExternalDataVpnTunnel_43365;

		// Token: 0x04004FD6 RID: 20438
		internal global::AcpUI.AcpCopyButton CpyBtnDataWideExternalDataVpnTunnel_43365;

		// Token: 0x04004FD7 RID: 20439
		internal global::AcpUI.AcpLabel DataWideExternalDataVpnTunnel_43365Comp;

		// Token: 0x04004FD8 RID: 20440
		internal global::AcpUI.AcpTextBoxSpinner DataWideExternalDataOORTime_43366;

		// Token: 0x04004FD9 RID: 20441
		internal global::AcpUI.AcpCustomViewCheckBox CVBtnDataWideExternalDataOORTime_43366;

		// Token: 0x04004FDA RID: 20442
		internal global::AcpUI.AcpLabel LblDataWideExternalDataOORTime_43366;

		// Token: 0x04004FDB RID: 20443
		internal global::AcpUI.AcpRtdButton RTDBtnDataWideExternalDataOORTime_43366;

		// Token: 0x04004FDC RID: 20444
		internal global::AcpUI.AcpCopyButton CpyBtnDataWideExternalDataOORTime_43366;

		// Token: 0x04004FDD RID: 20445
		internal global::AcpUI.AcpLabel DataWideExternalDataOORTime_43366Comp;

		// Token: 0x04004FDE RID: 20446
		internal global::AcpUI.AcpTextBoxSpinner DataWideExternalDataModemOpenTime_43367;

		// Token: 0x04004FDF RID: 20447
		internal global::AcpUI.AcpCustomViewCheckBox CVBtnDataWideExternalDataModemOpenTime_43367;

		// Token: 0x04004FE0 RID: 20448
		internal global::AcpUI.AcpLabel LblDataWideExternalDataModemOpenTime_43367;

		// Token: 0x04004FE1 RID: 20449
		internal global::AcpUI.AcpRtdButton RTDBtnDataWideExternalDataModemOpenTime_43367;

		// Token: 0x04004FE2 RID: 20450
		internal global::AcpUI.AcpCopyButton CpyBtnDataWideExternalDataModemOpenTime_43367;

		// Token: 0x04004FE3 RID: 20451
		internal global::AcpUI.AcpLabel DataWideExternalDataModemOpenTime_43367Comp;

		// Token: 0x04004FE4 RID: 20452
		internal global::AcpUI.AcpTextBox DataWideMG90WirelessVPNFriendlyName_43785;

		// Token: 0x04004FE5 RID: 20453
		internal global::AcpUI.AcpCustomViewCheckBox CVBtnDataWideMG90WirelessVPNFriendlyName_43785;

		// Token: 0x04004FE6 RID: 20454
		internal global::AcpUI.AcpLabel LblDataWideMG90WirelessVPNFriendlyName_43785;

		// Token: 0x04004FE7 RID: 20455
		internal global::AcpUI.AcpRtdButton RTDBtnDataWideMG90WirelessVPNFriendlyName_43785;

		// Token: 0x04004FE8 RID: 20456
		internal global::AcpUI.AcpCopyButton CpyBtnDataWideMG90WirelessVPNFriendlyName_43785;

		// Token: 0x04004FE9 RID: 20457
		internal global::AcpUI.AcpLabel DataWideMG90WirelessVPNFriendlyName_43785Comp;

		// Token: 0x04004FEA RID: 20458
		internal global::AcpUI.AcpTextBox DataWideMG90WirelessLTEFriendlyName_43786;

		// Token: 0x04004FEB RID: 20459
		internal global::AcpUI.AcpCustomViewCheckBox CVBtnDataWideMG90WirelessLTEFriendlyName_43786;

		// Token: 0x04004FEC RID: 20460
		internal global::AcpUI.AcpLabel LblDataWideMG90WirelessLTEFriendlyName_43786;

		// Token: 0x04004FED RID: 20461
		internal global::AcpUI.AcpRtdButton RTDBtnDataWideMG90WirelessLTEFriendlyName_43786;

		// Token: 0x04004FEE RID: 20462
		internal global::AcpUI.AcpCopyButton CpyBtnDataWideMG90WirelessLTEFriendlyName_43786;

		// Token: 0x04004FEF RID: 20463
		internal global::AcpUI.AcpLabel DataWideMG90WirelessLTEFriendlyName_43786Comp;

		// Token: 0x04004FF0 RID: 20464
		internal global::AcpUI.AcpCheckBox DataWideMG90WirelessSatelliteEnable_43788;

		// Token: 0x04004FF1 RID: 20465
		internal global::AcpUI.AcpCustomViewCheckBox CVBtnDataWideMG90WirelessSatelliteEnable_43788;

		// Token: 0x04004FF2 RID: 20466
		internal global::AcpUI.AcpLabel LblDataWideMG90WirelessSatelliteEnable_43788;

		// Token: 0x04004FF3 RID: 20467
		internal global::AcpUI.AcpRtdButton RTDBtnDataWideMG90WirelessSatelliteEnable_43788;

		// Token: 0x04004FF4 RID: 20468
		internal global::AcpUI.AcpCopyButton CpyBtnDataWideMG90WirelessSatelliteEnable_43788;

		// Token: 0x04004FF5 RID: 20469
		internal global::AcpUI.AcpCheckBox DataWideMG90WirelessSatelliteEnable_43788Comp;

		// Token: 0x04004FF6 RID: 20470
		internal global::AcpUI.AcpTextBox DataWideMG90WirelessSatelliteFriendlyName_43787;

		// Token: 0x04004FF7 RID: 20471
		internal global::AcpUI.AcpCustomViewCheckBox CVBtnDataWideMG90WirelessSatelliteFriendlyName_43787;

		// Token: 0x04004FF8 RID: 20472
		internal global::AcpUI.AcpLabel LblDataWideMG90WirelessSatelliteFriendlyName_43787;

		// Token: 0x04004FF9 RID: 20473
		internal global::AcpUI.AcpRtdButton RTDBtnDataWideMG90WirelessSatelliteFriendlyName_43787;

		// Token: 0x04004FFA RID: 20474
		internal global::AcpUI.AcpCopyButton CpyBtnDataWideMG90WirelessSatelliteFriendlyName_43787;

		// Token: 0x04004FFB RID: 20475
		internal global::AcpUI.AcpLabel DataWideMG90WirelessSatelliteFriendlyName_43787Comp;

		// Token: 0x04004FFC RID: 20476
		internal global::AcpUI.AcpCheckBox DataWideExternalDataModemHiddenNetwork_44814;

		// Token: 0x04004FFD RID: 20477
		internal global::AcpUI.AcpCustomViewCheckBox CVBtnDataWideExternalDataModemHiddenNetwork_44814;

		// Token: 0x04004FFE RID: 20478
		internal global::AcpUI.AcpLabel LblDataWideExternalDataModemHiddenNetwork_44814;

		// Token: 0x04004FFF RID: 20479
		internal global::AcpUI.AcpRtdButton RTDBtnDataWideExternalDataModemHiddenNetwork_44814;

		// Token: 0x04005000 RID: 20480
		internal global::AcpUI.AcpCopyButton CpyBtnDataWideExternalDataModemHiddenNetwork_44814;

		// Token: 0x04005001 RID: 20481
		internal global::AcpUI.AcpLabel DataWideExternalDataModemHiddenNetwork_44814Comp;

		// Token: 0x04005002 RID: 20482
		internal global::AcpUI.AcpExpander ExpanderDataWideNATList;

		// Token: 0x04005003 RID: 20483
		internal global::AcpUI.AcpRecNavToolbar RecNavToolbarExpanderDataWideNATListTable;

		// Token: 0x04005004 RID: 20484
		internal global::System.Windows.Controls.Grid ExpanderDataWideNATListGrid;

		// Token: 0x04005005 RID: 20485
		internal global::System.Windows.Controls.Grid ExpanderDataWideNATListTableGrid;

		// Token: 0x04005006 RID: 20486
		internal global::AcpUI.AcpGroupBox ExpanderDataWideNATListTableTableView;

		// Token: 0x04005007 RID: 20487
		internal global::AcpUI.AcpXamDataPresenter ExpanderDataWideNATListTable;

		// Token: 0x04005008 RID: 20488
		internal global::Infragistics.Windows.DataPresenter.UnboundField DataWideNATListLANPort_A8385_Col;

		// Token: 0x04005009 RID: 20489
		internal global::Infragistics.Windows.DataPresenter.UnboundField DataWideNATListStaticNATIPAddress_A9181_Col;

		// Token: 0x0400500A RID: 20490
		internal global::Infragistics.Windows.DataPresenter.UnboundField DataWideNATListWANPort_A9677_Col;

		// Token: 0x0400500B RID: 20491
		internal global::AcpUI.AcpGroupBox ExpanderDataWideNATListTableSRecView;

		// Token: 0x0400500C RID: 20492
		internal global::System.Windows.Controls.Grid gridExpanderDataWideNATListTableSRecView;

		// Token: 0x0400500D RID: 20493
		internal global::AcpUI.AcpTextBoxSpinner DataWideNATListLANPort_A8385;

		// Token: 0x0400500E RID: 20494
		internal global::AcpUI.AcpCustomViewCheckBox CVBtnDataWideNATListLANPort_A8385;

		// Token: 0x0400500F RID: 20495
		internal global::AcpUI.AcpLabel LblDataWideNATListLANPort_A8385;

		// Token: 0x04005010 RID: 20496
		internal global::AcpUI.AcpRtdButton RTDBtnDataWideNATListLANPort_A8385;

		// Token: 0x04005011 RID: 20497
		internal global::AcpUI.AcpCopyButton CpyBtnDataWideNATListLANPort_A8385;

		// Token: 0x04005012 RID: 20498
		internal global::AcpUI.AcpLabel DataWideNATListLANPort_A8385Comp;

		// Token: 0x04005013 RID: 20499
		internal global::AcpUI.AcpTextBox DataWideNATListStaticNATIPAddress_A9181;

		// Token: 0x04005014 RID: 20500
		internal global::AcpUI.AcpCustomViewCheckBox CVBtnDataWideNATListStaticNATIPAddress_A9181;

		// Token: 0x04005015 RID: 20501
		internal global::AcpUI.AcpLabel LblDataWideNATListStaticNATIPAddress_A9181;

		// Token: 0x04005016 RID: 20502
		internal global::AcpUI.AcpRtdButton RTDBtnDataWideNATListStaticNATIPAddress_A9181;

		// Token: 0x04005017 RID: 20503
		internal global::AcpUI.AcpCopyButton CpyBtnDataWideNATListStaticNATIPAddress_A9181;

		// Token: 0x04005018 RID: 20504
		internal global::AcpUI.AcpLabel DataWideNATListStaticNATIPAddress_A9181Comp;

		// Token: 0x04005019 RID: 20505
		internal global::AcpUI.AcpTextBoxSpinner DataWideNATListWANPort_A9677;

		// Token: 0x0400501A RID: 20506
		internal global::AcpUI.AcpCustomViewCheckBox CVBtnDataWideNATListWANPort_A9677;

		// Token: 0x0400501B RID: 20507
		internal global::AcpUI.AcpLabel LblDataWideNATListWANPort_A9677;

		// Token: 0x0400501C RID: 20508
		internal global::AcpUI.AcpRtdButton RTDBtnDataWideNATListWANPort_A9677;

		// Token: 0x0400501D RID: 20509
		internal global::AcpUI.AcpCopyButton CpyBtnDataWideNATListWANPort_A9677;

		// Token: 0x0400501E RID: 20510
		internal global::AcpUI.AcpLabel DataWideNATListWANPort_A9677Comp;

		// Token: 0x0400501F RID: 20511
		internal global::AcpUI.AcpExpander ExpanderDataWideDataUserList;

		// Token: 0x04005020 RID: 20512
		internal global::AcpUI.AcpRecNavToolbar RecNavToolbarExpanderDataWideDataUserListTable;

		// Token: 0x04005021 RID: 20513
		internal global::System.Windows.Controls.Grid ExpanderDataWideDataUserListGrid;

		// Token: 0x04005022 RID: 20514
		internal global::System.Windows.Controls.Grid ExpanderDataWideDataUserListTableGrid;

		// Token: 0x04005023 RID: 20515
		internal global::AcpUI.AcpGroupBox ExpanderDataWideDataUserListTableTableView;

		// Token: 0x04005024 RID: 20516
		internal global::AcpUI.AcpXamDataPresenter ExpanderDataWideDataUserListTable;

		// Token: 0x04005025 RID: 20517
		internal global::Infragistics.Windows.DataPresenter.UnboundField DataWideDataUserListDataUserInformation_A7800_Col;

		// Token: 0x04005026 RID: 20518
		internal global::AcpUI.AcpGroupBox ExpanderDataWideDataUserListTableSRecView;

		// Token: 0x04005027 RID: 20519
		internal global::System.Windows.Controls.Grid gridExpanderDataWideDataUserListTableSRecView;

		// Token: 0x04005028 RID: 20520
		internal global::AcpUI.AcpTextBox DataWideDataUserListDataUserInformation_A7800;

		// Token: 0x04005029 RID: 20521
		internal global::AcpUI.AcpCustomViewCheckBox CVBtnDataWideDataUserListDataUserInformation_A7800;

		// Token: 0x0400502A RID: 20522
		internal global::AcpUI.AcpLabel LblDataWideDataUserListDataUserInformation_A7800;

		// Token: 0x0400502B RID: 20523
		internal global::AcpUI.AcpRtdButton RTDBtnDataWideDataUserListDataUserInformation_A7800;

		// Token: 0x0400502C RID: 20524
		internal global::AcpUI.AcpCopyButton CpyBtnDataWideDataUserListDataUserInformation_A7800;

		// Token: 0x0400502D RID: 20525
		internal global::AcpUI.AcpLabel DataWideDataUserListDataUserInformation_A7800Comp;

		// Token: 0x0400502E RID: 20526
		internal global::AcpUI.AcpExpander ExpanderDataWideQuickTextMessageList;

		// Token: 0x0400502F RID: 20527
		internal global::AcpUI.AcpRecNavToolbar RecNavToolbarExpanderDataWideQuickTextMessageListTable;

		// Token: 0x04005030 RID: 20528
		internal global::System.Windows.Controls.Grid ExpanderDataWideQuickTextMessageListGrid;

		// Token: 0x04005031 RID: 20529
		internal global::System.Windows.Controls.Grid ExpanderDataWideQuickTextMessageListTableGrid;

		// Token: 0x04005032 RID: 20530
		internal global::AcpUI.AcpGroupBox ExpanderDataWideQuickTextMessageListTableTableView;

		// Token: 0x04005033 RID: 20531
		internal global::AcpUI.AcpXamDataPresenter ExpanderDataWideQuickTextMessageListTable;

		// Token: 0x04005034 RID: 20532
		internal global::Infragistics.Windows.DataPresenter.UnboundField DataWideQuickTextMessageListQuickTextMessage_A8810_Col;

		// Token: 0x04005035 RID: 20533
		internal global::AcpUI.AcpGroupBox ExpanderDataWideQuickTextMessageListTableSRecView;

		// Token: 0x04005036 RID: 20534
		internal global::System.Windows.Controls.Grid gridExpanderDataWideQuickTextMessageListTableSRecView;

		// Token: 0x04005037 RID: 20535
		internal global::AcpUI.AcpTextBox DataWideQuickTextMessageListQuickTextMessage_A8810;

		// Token: 0x04005038 RID: 20536
		internal global::AcpUI.AcpCustomViewCheckBox CVBtnDataWideQuickTextMessageListQuickTextMessage_A8810;

		// Token: 0x04005039 RID: 20537
		internal global::AcpUI.AcpLabel LblDataWideQuickTextMessageListQuickTextMessage_A8810;

		// Token: 0x0400503A RID: 20538
		internal global::AcpUI.AcpRtdButton RTDBtnDataWideQuickTextMessageListQuickTextMessage_A8810;

		// Token: 0x0400503B RID: 20539
		internal global::AcpUI.AcpCopyButton CpyBtnDataWideQuickTextMessageListQuickTextMessage_A8810;

		// Token: 0x0400503C RID: 20540
		internal global::AcpUI.AcpLabel DataWideQuickTextMessageListQuickTextMessage_A8810Comp;

		// Token: 0x0400503D RID: 20541
		internal global::AcpUI.AcpExpander ExpanderDataWideDataProtocolConfiguration;

		// Token: 0x0400503E RID: 20542
		internal global::AcpUI.AcpGroupBox GrpBoxExpanderDataWideDataProtocolConfigurationPseudo0;

		// Token: 0x0400503F RID: 20543
		internal global::AcpUI.AcpCustomViewCheckBox CVBtnDataConfigDataWideMaxNumofNonTCPIPHCContexts_A36192;

		// Token: 0x04005040 RID: 20544
		internal global::AcpUI.AcpLabel LblDataConfigDataWideMaxNumofNonTCPIPHCContexts_A36192;

		// Token: 0x04005041 RID: 20545
		internal global::AcpUI.AcpTextBoxSpinner DataConfigDataWideMaxNumofNonTCPIPHCContexts_A36192;

		// Token: 0x04005042 RID: 20546
		internal global::AcpUI.AcpRtdButton RTDBtnDataConfigDataWideMaxNumofNonTCPIPHCContexts_A36192;

		// Token: 0x04005043 RID: 20547
		internal global::AcpUI.AcpCopyButton CpyBtnDataConfigDataWideMaxNumofNonTCPIPHCContexts_A36192;

		// Token: 0x04005044 RID: 20548
		internal global::AcpUI.AcpLabel DataConfigDataWideMaxNumofNonTCPIPHCContexts_A36192Comp;

		// Token: 0x04005045 RID: 20549
		internal global::AcpUI.AcpCustomViewCheckBox CVBtnDataConfigDataWideMaxNumofTCPIPHCContexts_A36194;

		// Token: 0x04005046 RID: 20550
		internal global::AcpUI.AcpLabel LblDataConfigDataWideMaxNumofTCPIPHCContexts_A36194;

		// Token: 0x04005047 RID: 20551
		internal global::AcpUI.AcpTextBoxSpinner DataConfigDataWideMaxNumofTCPIPHCContexts_A36194;

		// Token: 0x04005048 RID: 20552
		internal global::AcpUI.AcpRtdButton RTDBtnDataConfigDataWideMaxNumofTCPIPHCContexts_A36194;

		// Token: 0x04005049 RID: 20553
		internal global::AcpUI.AcpCopyButton CpyBtnDataConfigDataWideMaxNumofTCPIPHCContexts_A36194;

		// Token: 0x0400504A RID: 20554
		internal global::AcpUI.AcpLabel DataConfigDataWideMaxNumofTCPIPHCContexts_A36194Comp;

		// Token: 0x0400504B RID: 20555
		internal global::AcpUI.AcpCustomViewCheckBox CVBtnDataConfigDataWideMaxNumOfCompreHeadersBetweenFullHeaders_A36205;

		// Token: 0x0400504C RID: 20556
		internal global::AcpUI.AcpLabel LblDataConfigDataWideMaxNumOfCompreHeadersBetweenFullHeaders_A36205;

		// Token: 0x0400504D RID: 20557
		internal global::AcpUI.AcpTextBoxSpinner DataConfigDataWideMaxNumOfCompreHeadersBetweenFullHeaders_A36205;

		// Token: 0x0400504E RID: 20558
		internal global::AcpUI.AcpRtdButton RTDBtnDataConfigDataWideMaxNumOfCompreHeadersBetweenFullHeaders_A36205;

		// Token: 0x0400504F RID: 20559
		internal global::AcpUI.AcpCopyButton CpyBtnDataConfigDataWideMaxNumOfCompreHeadersBetweenFullHeaders_A36205;

		// Token: 0x04005050 RID: 20560
		internal global::AcpUI.AcpLabel DataConfigDataWideMaxNumOfCompreHeadersBetweenFullHeaders_A36205Comp;

		// Token: 0x04005051 RID: 20561
		internal global::AcpUI.AcpCustomViewCheckBox CVBtnDataConfigDataWideMaxHeaderSizeAllowedForCompression_A36206;

		// Token: 0x04005052 RID: 20562
		internal global::AcpUI.AcpLabel LblDataConfigDataWideMaxHeaderSizeAllowedForCompression_A36206;

		// Token: 0x04005053 RID: 20563
		internal global::AcpUI.AcpTextBoxSpinner DataConfigDataWideMaxHeaderSizeAllowedForCompression_A36206;

		// Token: 0x04005054 RID: 20564
		internal global::AcpUI.AcpRtdButton RTDBtnDataConfigDataWideMaxHeaderSizeAllowedForCompression_A36206;

		// Token: 0x04005055 RID: 20565
		internal global::AcpUI.AcpCopyButton CpyBtnDataConfigDataWideMaxHeaderSizeAllowedForCompression_A36206;

		// Token: 0x04005056 RID: 20566
		internal global::AcpUI.AcpLabel DataConfigDataWideMaxHeaderSizeAllowedForCompression_A36206Comp;

		// Token: 0x04005057 RID: 20567
		internal global::AcpUI.AcpCustomViewCheckBox CVBtnDataConfigDataWideMaxTimeBetweenFullHeaders_A36200;

		// Token: 0x04005058 RID: 20568
		internal global::AcpUI.AcpLabel LblDataConfigDataWideMaxTimeBetweenFullHeaders_A36200;

		// Token: 0x04005059 RID: 20569
		internal global::AcpUI.AcpTextBoxSpinner DataConfigDataWideMaxTimeBetweenFullHeaders_A36200;

		// Token: 0x0400505A RID: 20570
		internal global::AcpUI.AcpRtdButton RTDBtnDataConfigDataWideMaxTimeBetweenFullHeaders_A36200;

		// Token: 0x0400505B RID: 20571
		internal global::AcpUI.AcpCopyButton CpyBtnDataConfigDataWideMaxTimeBetweenFullHeaders_A36200;

		// Token: 0x0400505C RID: 20572
		internal global::AcpUI.AcpLabel DataConfigDataWideMaxTimeBetweenFullHeaders_A36200Comp;

		// Token: 0x0400505D RID: 20573
		internal global::AcpUI.AcpCustomViewCheckBox CVBtnDataCfgDataWideMaxSetupTimeAllowedforCCA_A36193;

		// Token: 0x0400505E RID: 20574
		internal global::AcpUI.AcpLabel LblDataCfgDataWideMaxSetupTimeAllowedforCCA_A36193;

		// Token: 0x0400505F RID: 20575
		internal global::AcpUI.AcpTextBoxSpinner DataCfgDataWideMaxSetupTimeAllowedforCCA_A36193;

		// Token: 0x04005060 RID: 20576
		internal global::AcpUI.AcpRtdButton RTDBtnDataCfgDataWideMaxSetupTimeAllowedforCCA_A36193;

		// Token: 0x04005061 RID: 20577
		internal global::AcpUI.AcpCopyButton CpyBtnDataCfgDataWideMaxSetupTimeAllowedforCCA_A36193;

		// Token: 0x04005062 RID: 20578
		internal global::AcpUI.AcpLabel DataCfgDataWideMaxSetupTimeAllowedforCCA_A36193Comp;

		// Token: 0x04005063 RID: 20579
		internal global::AcpUI.AcpCustomViewCheckBox CVBtnDataCfgDataWideTimeSourceVar_A36196;

		// Token: 0x04005064 RID: 20580
		internal global::AcpUI.AcpLabel LblDataCfgDataWideTimeSourceVar_A36196;

		// Token: 0x04005065 RID: 20581
		internal global::AcpUI.AcpTextBoxSpinner DataCfgDataWideTimeSourceVar_A36196;

		// Token: 0x04005066 RID: 20582
		internal global::AcpUI.AcpRtdButton RTDBtnDataCfgDataWideTimeSourceVar_A36196;

		// Token: 0x04005067 RID: 20583
		internal global::AcpUI.AcpCopyButton CpyBtnDataCfgDataWideTimeSourceVar_A36196;

		// Token: 0x04005068 RID: 20584
		internal global::AcpUI.AcpLabel DataCfgDataWideTimeSourceVar_A36196Comp;

		// Token: 0x04005069 RID: 20585
		internal global::AcpUI.AcpExpander ExpanderDataWidePortConfiguration;

		// Token: 0x0400506A RID: 20586
		internal global::AcpUI.AcpGroupBox GrpBoxExpanderDataWidePortConfigurationPseudo0;

		// Token: 0x0400506B RID: 20587
		internal global::AcpUI.AcpCustomViewCheckBox CVBtnDataConfDataWidePortConAuthenticationUDPPort_A37608;

		// Token: 0x0400506C RID: 20588
		internal global::AcpUI.AcpLabel LblDataConfDataWidePortConAuthenticationUDPPort_A37608;

		// Token: 0x0400506D RID: 20589
		internal global::AcpUI.AcpTextBoxSpinner DataConfDataWidePortConAuthenticationUDPPort_A37608;

		// Token: 0x0400506E RID: 20590
		internal global::AcpUI.AcpRtdButton RTDBtnDataConfDataWidePortConAuthenticationUDPPort_A37608;

		// Token: 0x0400506F RID: 20591
		internal global::AcpUI.AcpCopyButton CpyBtnDataConfDataWidePortConAuthenticationUDPPort_A37608;

		// Token: 0x04005070 RID: 20592
		internal global::AcpUI.AcpLabel DataConfDataWidePortConAuthenticationUDPPort_A37608Comp;

		// Token: 0x04005071 RID: 20593
		internal global::AcpUI.AcpCustomViewCheckBox CVBtnDataWideP25LocationReportingUDPPort_42413;

		// Token: 0x04005072 RID: 20594
		internal global::AcpUI.AcpLabel LblDataWideP25LocationReportingUDPPort_42413;

		// Token: 0x04005073 RID: 20595
		internal global::AcpUI.AcpTextBoxSpinner DataWideP25LocationReportingUDPPort_42413;

		// Token: 0x04005074 RID: 20596
		internal global::AcpUI.AcpRtdButton RTDBtnDataWideP25LocationReportingUDPPort_42413;

		// Token: 0x04005075 RID: 20597
		internal global::AcpUI.AcpCopyButton CpyBtnDataWideP25LocationReportingUDPPort_42413;

		// Token: 0x04005076 RID: 20598
		internal global::AcpUI.AcpLabel DataWideP25LocationReportingUDPPort_42413Comp;

		// Token: 0x04005077 RID: 20599
		internal global::AcpUI.AcpCustomViewCheckBox CVBtnDataWideWIFIOTAPTCPPort_42627;

		// Token: 0x04005078 RID: 20600
		internal global::AcpUI.AcpLabel LblDataWideWIFIOTAPTCPPort_42627;

		// Token: 0x04005079 RID: 20601
		internal global::AcpUI.AcpTextBoxSpinner DataWideWIFIOTAPTCPPort_42627;

		// Token: 0x0400507A RID: 20602
		internal global::AcpUI.AcpRtdButton RTDBtnDataWideWIFIOTAPTCPPort_42627;

		// Token: 0x0400507B RID: 20603
		internal global::AcpUI.AcpCopyButton CpyBtnDataWideWIFIOTAPTCPPort_42627;

		// Token: 0x0400507C RID: 20604
		internal global::AcpUI.AcpLabel DataWideWIFIOTAPTCPPort_42627Comp;

		// Token: 0x0400507D RID: 20605
		internal global::AcpUI.AcpCustomViewCheckBox CVBtnSensorMeasurementReportingUDPPort_A43022;

		// Token: 0x0400507E RID: 20606
		internal global::AcpUI.AcpLabel LblSensorMeasurementReportingUDPPort_A43022;

		// Token: 0x0400507F RID: 20607
		internal global::AcpUI.AcpTextBoxSpinner SensorMeasurementReportingUDPPort_A43022;

		// Token: 0x04005080 RID: 20608
		internal global::AcpUI.AcpRtdButton RTDBtnSensorMeasurementReportingUDPPort_A43022;

		// Token: 0x04005081 RID: 20609
		internal global::AcpUI.AcpCopyButton CpyBtnSensorMeasurementReportingUDPPort_A43022;

		// Token: 0x04005082 RID: 20610
		internal global::AcpUI.AcpLabel SensorMeasurementReportingUDPPort_A43022Comp;

		// Token: 0x04005083 RID: 20611
		internal global::AcpUI.AcpCustomViewCheckBox CVBtnDataWideKVLKeyloadingUDPPort_43205;

		// Token: 0x04005084 RID: 20612
		internal global::AcpUI.AcpLabel LblDataWideKVLKeyloadingUDPPort_43205;

		// Token: 0x04005085 RID: 20613
		internal global::AcpUI.AcpTextBoxSpinner DataWideKVLKeyloadingUDPPort_43205;

		// Token: 0x04005086 RID: 20614
		internal global::AcpUI.AcpRtdButton RTDBtnDataWideKVLKeyloadingUDPPort_43205;

		// Token: 0x04005087 RID: 20615
		internal global::AcpUI.AcpCopyButton CpyBtnDataWideKVLKeyloadingUDPPort_43205;

		// Token: 0x04005088 RID: 20616
		internal global::AcpUI.AcpLabel DataWideKVLKeyloadingUDPPort_43205Comp;

		// Token: 0x04005089 RID: 20617
		internal global::AcpUI.AcpExpander ExpanderDataWideLabtoolDATA_CFG;

		// Token: 0x0400508A RID: 20618
		internal global::AcpUI.AcpGroupBox GrpBoxExpanderDataWideLabtoolDATA_CFGPseudo0;

		// Token: 0x0400508B RID: 20619
		internal global::AcpUI.AcpCustomViewCheckBox CVBtnLabtoolContextRenewalTimerMin;

		// Token: 0x0400508C RID: 20620
		internal global::AcpUI.AcpLabel LblLabtoolContextRenewalTimerMin;

		// Token: 0x0400508D RID: 20621
		internal global::AcpUI.AcpTextBoxSpinner LabtoolContextRenewalTimerMin;

		// Token: 0x0400508E RID: 20622
		internal global::AcpUI.AcpRtdButton RTDBtnLabtoolContextRenewalTimerMin;

		// Token: 0x0400508F RID: 20623
		internal global::AcpUI.AcpCopyButton CpyBtnLabtoolContextRenewalTimerMin;

		// Token: 0x04005090 RID: 20624
		internal global::AcpUI.AcpLabel LabtoolContextRenewalTimerMinComp;

		// Token: 0x04005091 RID: 20625
		internal global::AcpUI.AcpCustomViewCheckBox CVBtnDataWideLabtoolDATA_CFGPacketDataActivateWaitTimerSec_A8686;

		// Token: 0x04005092 RID: 20626
		internal global::AcpUI.AcpLabel LblDataWideLabtoolDATA_CFGPacketDataActivateWaitTimerSec_A8686;

		// Token: 0x04005093 RID: 20627
		internal global::AcpUI.AcpTextBoxSpinner DataWideLabtoolDATA_CFGPacketDataActivateWaitTimerSec_A8686;

		// Token: 0x04005094 RID: 20628
		internal global::AcpUI.AcpRtdButton RTDBtnDataWideLabtoolDATA_CFGPacketDataActivateWaitTimerSec_A8686;

		// Token: 0x04005095 RID: 20629
		internal global::AcpUI.AcpCopyButton CpyBtnDataWideLabtoolDATA_CFGPacketDataActivateWaitTimerSec_A8686;

		// Token: 0x04005096 RID: 20630
		internal global::AcpUI.AcpLabel DataWideLabtoolDATA_CFGPacketDataActivateWaitTimerSec_A8686Comp;

		// Token: 0x04005097 RID: 20631
		internal global::AcpUI.AcpCustomViewCheckBox CVBtnDataWideLabtoolDATA_CFGOTAPDefaultInactivityTimer_A8668;

		// Token: 0x04005098 RID: 20632
		internal global::AcpUI.AcpLabel LblDataWideLabtoolDATA_CFGOTAPDefaultInactivityTimer_A8668;

		// Token: 0x04005099 RID: 20633
		internal global::AcpUI.AcpTextBoxSpinner DataWideLabtoolDATA_CFGOTAPDefaultInactivityTimer_A8668;

		// Token: 0x0400509A RID: 20634
		internal global::AcpUI.AcpRtdButton RTDBtnDataWideLabtoolDATA_CFGOTAPDefaultInactivityTimer_A8668;

		// Token: 0x0400509B RID: 20635
		internal global::AcpUI.AcpCopyButton CpyBtnDataWideLabtoolDATA_CFGOTAPDefaultInactivityTimer_A8668;

		// Token: 0x0400509C RID: 20636
		internal global::AcpUI.AcpLabel DataWideLabtoolDATA_CFGOTAPDefaultInactivityTimer_A8668Comp;

		// Token: 0x0400509D RID: 20637
		internal global::AcpUI.AcpCustomViewCheckBox CVBtnLabtoolDefaultReadyTimerSec;

		// Token: 0x0400509E RID: 20638
		internal global::AcpUI.AcpLabel LblLabtoolDefaultReadyTimerSec;

		// Token: 0x0400509F RID: 20639
		internal global::AcpUI.AcpTextBoxSpinner LabtoolDefaultReadyTimerSec;

		// Token: 0x040050A0 RID: 20640
		internal global::AcpUI.AcpRtdButton RTDBtnLabtoolDefaultReadyTimerSec;

		// Token: 0x040050A1 RID: 20641
		internal global::AcpUI.AcpCopyButton CpyBtnLabtoolDefaultReadyTimerSec;

		// Token: 0x040050A2 RID: 20642
		internal global::AcpUI.AcpLabel LabtoolDefaultReadyTimerSecComp;

		// Token: 0x040050A3 RID: 20643
		internal global::AcpUI.AcpCustomViewCheckBox CVBtnLabtoolContextActivationHoldoffTimerSec;

		// Token: 0x040050A4 RID: 20644
		internal global::AcpUI.AcpLabel LblLabtoolContextActivationHoldoffTimerSec;

		// Token: 0x040050A5 RID: 20645
		internal global::AcpUI.AcpTextBoxSpinner LabtoolContextActivationHoldoffTimerSec;

		// Token: 0x040050A6 RID: 20646
		internal global::AcpUI.AcpRtdButton RTDBtnLabtoolContextActivationHoldoffTimerSec;

		// Token: 0x040050A7 RID: 20647
		internal global::AcpUI.AcpCopyButton CpyBtnLabtoolContextActivationHoldoffTimerSec;

		// Token: 0x040050A8 RID: 20648
		internal global::AcpUI.AcpLabel LabtoolContextActivationHoldoffTimerSecComp;

		// Token: 0x040050A9 RID: 20649
		internal global::AcpUI.AcpCustomViewCheckBox CVBtnDataWideDVRSActWaitTime_A40128;

		// Token: 0x040050AA RID: 20650
		internal global::AcpUI.AcpLabel LblDataWideDVRSActWaitTime_A40128;

		// Token: 0x040050AB RID: 20651
		internal global::AcpUI.AcpTextBoxSpinner DataWideDVRSActWaitTime_A40128;

		// Token: 0x040050AC RID: 20652
		internal global::AcpUI.AcpRtdButton RTDBtnDataWideDVRSActWaitTime_A40128;

		// Token: 0x040050AD RID: 20653
		internal global::AcpUI.AcpCopyButton CpyBtnDataWideDVRSActWaitTime_A40128;

		// Token: 0x040050AE RID: 20654
		internal global::AcpUI.AcpLabel DataWideDVRSActWaitTime_A40128Comp;

		// Token: 0x040050AF RID: 20655
		internal global::AcpUI.AcpCustomViewCheckBox CVBtnRandomAccessAckTimerMsec_42016;

		// Token: 0x040050B0 RID: 20656
		internal global::AcpUI.AcpLabel LblRandomAccessAckTimerMsec_42016;

		// Token: 0x040050B1 RID: 20657
		internal global::AcpUI.AcpTextBoxSpinner RandomAccessAckTimerMsec_42016;

		// Token: 0x040050B2 RID: 20658
		internal global::AcpUI.AcpRtdButton RTDBtnRandomAccessAckTimerMsec_42016;

		// Token: 0x040050B3 RID: 20659
		internal global::AcpUI.AcpCopyButton CpyBtnRandomAccessAckTimerMsec_42016;

		// Token: 0x040050B4 RID: 20660
		internal global::AcpUI.AcpLabel RandomAccessAckTimerMsec_42016Comp;

		// Token: 0x040050B5 RID: 20661
		internal global::AcpUI.AcpCustomViewCheckBox CVBtnDataWideLabtoolDeviceProvisioningServiceIDScope_43553;

		// Token: 0x040050B6 RID: 20662
		internal global::AcpUI.AcpLabel LblDataWideLabtoolDeviceProvisioningServiceIDScope_43553;

		// Token: 0x040050B7 RID: 20663
		internal global::AcpUI.AcpTextBox DataWideLabtoolDeviceProvisioningServiceIDScope_43553;

		// Token: 0x040050B8 RID: 20664
		internal global::AcpUI.AcpRtdButton RTDBtnDataWideLabtoolDeviceProvisioningServiceIDScope_43553;

		// Token: 0x040050B9 RID: 20665
		internal global::AcpUI.AcpCopyButton CpyBtnDataWideLabtoolDeviceProvisioningServiceIDScope_43553;

		// Token: 0x040050BA RID: 20666
		internal global::AcpUI.AcpLabel DataWideLabtoolDeviceProvisioningServiceIDScope_43553Comp;

		// Token: 0x040050BB RID: 20667
		internal global::AcpUI.AcpCustomViewCheckBox CVBtnCloudRegion_43554;

		// Token: 0x040050BC RID: 20668
		internal global::AcpUI.AcpLabel LblCloudRegion_43554;

		// Token: 0x040050BD RID: 20669
		internal global::AcpUI.AcpTextBox CloudRegion_43554;

		// Token: 0x040050BE RID: 20670
		internal global::AcpUI.AcpRtdButton RTDBtnCloudRegion_43554;

		// Token: 0x040050BF RID: 20671
		internal global::AcpUI.AcpCopyButton CpyBtnCloudRegion_43554;

		// Token: 0x040050C0 RID: 20672
		internal global::AcpUI.AcpLabel CloudRegion_43554Comp;

		// Token: 0x040050C1 RID: 20673
		internal global::AcpUI.AcpCustomViewCheckBox CVBtnDataWideLabtoolDeviceProvisioningServiceURI_43555;

		// Token: 0x040050C2 RID: 20674
		internal global::AcpUI.AcpLabel LblDataWideLabtoolDeviceProvisioningServiceURI_43555;

		// Token: 0x040050C3 RID: 20675
		internal global::AcpUI.AcpTextBox DataWideLabtoolDeviceProvisioningServiceURI_43555;

		// Token: 0x040050C4 RID: 20676
		internal global::AcpUI.AcpRtdButton RTDBtnDataWideLabtoolDeviceProvisioningServiceURI_43555;

		// Token: 0x040050C5 RID: 20677
		internal global::AcpUI.AcpCopyButton CpyBtnDataWideLabtoolDeviceProvisioningServiceURI_43555;

		// Token: 0x040050C6 RID: 20678
		internal global::AcpUI.AcpLabel DataWideLabtoolDeviceProvisioningServiceURI_43555Comp;

		// Token: 0x040050C7 RID: 20679
		internal global::AcpUI.AcpCustomViewCheckBox CVBtnDataWideIdentityManagementGatewayHostname_43556;

		// Token: 0x040050C8 RID: 20680
		internal global::AcpUI.AcpLabel LblDataWideIdentityManagementGatewayHostname_43556;

		// Token: 0x040050C9 RID: 20681
		internal global::AcpUI.AcpTextBox DataWideIdentityManagementGatewayHostname_43556;

		// Token: 0x040050CA RID: 20682
		internal global::AcpUI.AcpRtdButton RTDBtnDataWideIdentityManagementGatewayHostname_43556;

		// Token: 0x040050CB RID: 20683
		internal global::AcpUI.AcpCopyButton CpyBtnDataWideIdentityManagementGatewayHostname_43556;

		// Token: 0x040050CC RID: 20684
		internal global::AcpUI.AcpLabel DataWideIdentityManagementGatewayHostname_43556Comp;

		// Token: 0x040050CD RID: 20685
		internal global::AcpUI.AcpCustomViewCheckBox CVBtnDataWideVirtualPartnerGatewayHostname_43557;

		// Token: 0x040050CE RID: 20686
		internal global::AcpUI.AcpLabel LblDataWideVirtualPartnerGatewayHostname_43557;

		// Token: 0x040050CF RID: 20687
		internal global::AcpUI.AcpTextBox DataWideVirtualPartnerGatewayHostname_43557;

		// Token: 0x040050D0 RID: 20688
		internal global::AcpUI.AcpRtdButton RTDBtnDataWideVirtualPartnerGatewayHostname_43557;

		// Token: 0x040050D1 RID: 20689
		internal global::AcpUI.AcpCopyButton CpyBtnDataWideVirtualPartnerGatewayHostname_43557;

		// Token: 0x040050D2 RID: 20690
		internal global::AcpUI.AcpLabel DataWideVirtualPartnerGatewayHostname_43557Comp;

		// Token: 0x040050D3 RID: 20691
		private bool b;
	}
}
