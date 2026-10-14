using System;
using System.CodeDom.Compiler;
using System.Collections;
using System.Collections.Generic;
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
using Infragistics.Windows.DataPresenter;
using SpecialFeatures.AcpReportManagerLib;
using SpecialFeatures.Ucl.Contact;

namespace SpecialFeatures.Ucl.HotList
{
	// Token: 0x020001D4 RID: 468
	public class UclAstroCallHotListPage : global::AcpUI.AcpPageFeature, global::AcpUILib.IAcpPageFeature, global::System.Windows.Markup.IComponentConnector, global::System.Windows.Markup.IStyleConnector
	{
		// Token: 0x060016BB RID: 5819 RVA: 0x001F3EBC File Offset: 0x001F20BC
		public UclAstroCallHotListPage()
		{
			try
			{
				this.InitializeComponent();
			}
			catch (global::System.Exception)
			{
			}
			global::AcpUI.Common.Utility.SetDirection(this);
		}

		// Token: 0x060016BC RID: 5820 RVA: 0x001F3EF4 File Offset: 0x001F20F4
		public override void SetDataContext()
		{
			switch (0)
			{
			case 0:
				goto IL_28;
			}
			int num;
			short num2;
			for (;;)
			{
				IL_0A:
				switch (num)
				{
				case 0:
					goto IL_6D;
				case 1:
					if (global::AcpCommonLib.AppInfoManager.AppMode == global::AcpCommonLib.ApplicationMode.CustomViewConfigurationMode)
					{
						num2 = (short)1174077445;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					base.DataContext = global::AcpCommonLib.FeatureManager.GetFeature(2210);
					num2 = (short)2046885892;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 2:
				{
					num2 = (short)1684406272;
					short num3 = num2;
					num2 = (short)839394457;
					short num4 = num2;
					num2 = (short)250619033;
					switch ((num4 == num2) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_83;
					default:
						goto IL_1A1;
					}
					break;
				}
				case 3:
					num2 = (short)965148673;
					if (num2 != 0)
					{
					}
					if (global::AcpCommonLib.AppInfoManager.AppMode == global::AcpCommonLib.ApplicationMode.CodeplugComparisonMode)
					{
						num2 = (short)1267597314;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_1E4;
				case 4:
					goto IL_6D;
				case 5:
					base.DataContext = global::AcpCommonLib.AppInfoManager.DefaultDocument.GetFeature(2210);
					num2 = (short)1705639936;
					num = (int)((global::System.IntPtr)num2);
					continue;
				}
				goto IL_28;
				IL_83:
				num2 = (short)291635203;
				num = (int)((global::System.IntPtr)num2);
				continue;
				IL_6D:
				this.RecNavToolbarUclAstroCallHotList.MyRecordsetDataSource = (global::AcpCommonLib.IAcpRecordset)base.DataContext;
				goto IL_83;
			}
			IL_1A1:
			num2 = (short)1438384128;
			if (num2 != 0)
			{
			}
			object feature = global::AcpCommonLib.AppInfoManager.ComparatorDocument.GetFeature(2210);
			((global::AcpUILib.IAcpRecNavToolbar)this.RecNavToolbarUclAstroCallHotList).MySecondaryRecordsetDataSource = (global::AcpCommonLib.IAcpRecordset)feature;
			((global::AcpUILib.IAcpRecNavToolbar)this.RecNavToolbarUclAstroCallHotList).SyncDataSources();
			return;
			IL_1E4:
			((global::AcpUILib.IAcpRecNavToolbar)this.RecNavToolbarUclAstroCallHotList).MySecondaryRecordsetDataSource = null;
			return;
			IL_28:
			base.MyBaseRecNavToolbar = this.RecNavToolbarUclAstroCallHotList;
			num2 = (short)1096220673;
			num = (int)((global::System.IntPtr)num2);
			goto IL_0A;
		}

		// Token: 0x060016BD RID: 5821 RVA: 0x001F40F4 File Offset: 0x001F22F4
		public override void OnLoaded(object sender, global::System.Windows.RoutedEventArgs e)
		{
			short num = (short)891092992;
			int num2 = (int)num;
			switch (num2)
			{
			default:
				num = (short)668467205;
				num2 = (int)((global::System.IntPtr)num);
				for (;;)
				{
					object obj;
					global::AcpUI.AcpExpander acpExpander;
					global::System.Collections.IEnumerator enumerator;
					switch (num2)
					{
					case 0:
						goto IL_347;
					case 1:
					{
						global::System.Windows.Data.CollectionView collectionView = (global::System.Windows.Data.CollectionView)global::System.Windows.Data.CollectionViewSource.GetDefaultView(obj);
						this.RecNavToolbarAstroCallHotListHotList.MyDataPresenter = this.AstroCallHotListDataPresenter;
						num = (short)1987641352;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 2:
						num = (short)1880489985;
						if (num != 0)
						{
						}
						goto IL_3EC;
					case 3:
					{
						object myRecordsetDataSource;
						global::System.Windows.Data.CollectionView collectionView2 = (global::System.Windows.Data.CollectionView)global::System.Windows.Data.CollectionViewSource.GetDefaultView(myRecordsetDataSource);
						num = (short)1219035138;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 4:
					{
						this.RecNavToolbarUclAstroCallHotList.ChildToolbars.Add(this.RecNavToolbarAstroCallHotListHotList);
						base.MyBaseRecNavToolbar = this.RecNavToolbarUclAstroCallHotList;
						object myRecordsetDataSource = this.RecNavToolbarUclAstroCallHotList.MyRecordsetDataSource;
						num = (short)603848711;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 5:
						switch (0)
						{
						case 0:
							goto IL_6D;
						}
						continue;
					case 6:
						if (obj != null)
						{
							num = (short)968818689;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_260;
					case 7:
					{
						object myRecordsetDataSource;
						if (myRecordsetDataSource != null)
						{
							num = (short)136249347;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_3EC;
					}
					case 8:
						goto IL_260;
					case 9:
						try
						{
							num = (short)675086338;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								switch (num2)
								{
								case 0:
									goto IL_194;
								case 1:
									base.Expanders.Add(acpExpander);
									num = (short)1170538501;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 2:
									switch (0)
									{
									case 0:
										goto IL_D7;
									}
									continue;
								case 3:
									num = (short)600047616;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 4:
									if (!enumerator.MoveNext())
									{
										num = (short)35323907;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									acpExpander = (((global::System.Windows.UIElement)enumerator.Current) as global::AcpUI.AcpExpander);
									num = (short)1865940998;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 6:
									if (acpExpander != null)
									{
										num = (short)1113260033;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									break;
								}
								IL_11C:
								num = (short)1237647364;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								IL_D7:
								goto IL_11C;
							}
							IL_194:
							goto IL_309;
						}
						finally
						{
							switch (0)
							{
							case 0:
								goto IL_1B6;
							}
							global::System.IDisposable disposable;
							for (;;)
							{
								IL_1A3:
								switch (num2)
								{
								case 0:
									goto IL_25D;
								case 1:
									disposable.Dispose();
									num = (short)1011548160;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 2:
								{
									num = (short)849052911;
									short num3 = num;
									num = (short)382633199;
									switch ((num3 == num) ? 1 : 0)
									{
									case 0:
									case 2:
										goto IL_25D;
									default:
										num = (short)1364000768;
										if (num != 0)
										{
										}
										if (disposable != null)
										{
											num = (short)360120321;
											num2 = (int)((global::System.IntPtr)num);
											continue;
										}
										goto IL_25F;
									}
									break;
								}
								}
								goto IL_1B6;
							}
							IL_25D:
							IL_25F:
							goto EndFinally_9;
							IL_1B6:
							disposable = (enumerator as global::System.IDisposable);
							num = (short)1974337538;
							num2 = (int)((global::System.IntPtr)num);
							goto IL_1A3;
							EndFinally_9:;
						}
						goto IL_260;
						IL_309:
						this.MyStackPanel.Children[0].Focus();
						base.OnLoaded(sender, e);
						this.a = true;
						num = (short)417857536;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					IL_6D:
					if (!this.a)
					{
						num = (short)1308360708;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					break;
					IL_260:
					acpExpander = null;
					enumerator = this.MyStackPanel.Children.GetEnumerator();
					num = (short)181796864;
					short num4 = num;
					num = (short)1473445897;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_3EC:
					obj = null;
					obj = this.RecNavToolbarAstroCallHotListHotList.MyRecordsetDataSource;
					num = (short)1779630086;
					num2 = (int)((global::System.IntPtr)num);
				}
				IL_347:
				this.a();
				return;
			}
		}

		// Token: 0x060016BE RID: 5822 RVA: 0x001F4558 File Offset: 0x001F2758
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
					return;
				case 1:
					num2 = (short)1419968513;
					if (num2 != 0)
					{
					}
					base.OnUnloaded(sender, e);
					this.a = false;
					num2 = (short)580911104;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 2:
				{
					num2 = (short)937684040;
					short num3 = num2;
					num2 = (short)1052568648;
					switch ((num3 == num2) ? 1 : 0)
					{
					case 0:
					case 2:
						return;
					default:
					{
						num2 = (short)402718720;
						short num4 = num2;
						num2 = (short)1641742336;
						if (num2 != 0)
						{
						}
						if (this.a)
						{
							num2 = (short)1173553153;
							num = (int)((global::System.IntPtr)num2);
							continue;
						}
						return;
					}
					}
					break;
				}
				}
				goto IL_1C;
			}
			return;
			IL_1C:
			this.RecNavToolbarAstroCallHotListHotList.DataContext = null;
			this.RecNavToolbarUclAstroCallHotList.DataContext = null;
			this.RecNavToolbarAstroCallHotListHotList.MyDataPresenter = null;
			this.RecNavToolbarUclAstroCallHotList.MyDataPresenter = null;
			num2 = (short)1783758850;
			num = (int)((global::System.IntPtr)num2);
			goto IL_0A;
		}

		// Token: 0x060016BF RID: 5823 RVA: 0x001F46AC File Offset: 0x001F28AC
		private void OnFieldNameDoubleClick(object A_0, global::System.Windows.RoutedEventArgs A_1)
		{
			short num = (short)1670250496;
			short num2 = num;
			num = (short)1258263401;
			short num3 = num;
			num = (short)557093737;
			switch (num3 == num)
			{
			}
			num = (short)1784152065;
			if (num != 0)
			{
			}
			num = (short)1767243776;
			if (num != 0)
			{
			}
			global::AcpUI.Common.Utility.GetFieldHelpText(A_0);
		}

		// Token: 0x060016C0 RID: 5824 RVA: 0x001F4758 File Offset: 0x001F2958
		private void OnModeClick(object A_0, global::System.Windows.RoutedEventArgs A_1)
		{
			int a_ = 16;
			short num = (short)1829961728;
			switch (num)
			{
			default:
			{
				num = (short)590020625;
				int num2 = (int)((global::System.IntPtr)num);
				global::AcpCommonLib.IAcpRecordset myRecordsetDataSource2;
				for (;;)
				{
					num = (short)1602420736;
					short num3 = num;
					switch (num2)
					{
					case 0:
					{
						global::SpecialFeatures.Ucl.HotList.AstroCallHotList astroCallHotList;
						if (astroCallHotList != null)
						{
							num = (short)52559877;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)632094727;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 1:
						goto IL_299;
					case 2:
					{
						global::System.Windows.Data.CollectionView collectionView;
						if (collectionView.IsCurrentAfterLast)
						{
							num = (short)158072841;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						collectionView.MoveCurrentToFirst();
						num = (short)293404685;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 3:
					{
						((global::AcpUI.AcpRecNavToolbar)A_0).TableMode = false;
						object myRecordsetDataSource = this.RecNavToolbarAstroCallHotListHotList.MyRecordsetDataSource;
						num = (short)1043791876;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 4:
					{
						object myRecordsetDataSource;
						if (myRecordsetDataSource != null)
						{
							num = (short)1469906958;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return;
					}
					case 5:
					{
						global::SpecialFeatures.Ucl.HotList.AstroCallHotList astroCallHotList;
						global::System.Windows.Data.CollectionView collectionView;
						collectionView.MoveCurrentTo(astroCallHotList);
						num = (short)1455357973;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 6:
						myRecordsetDataSource2 = this.RecNavToolbarUclAstroCallHotList.MyRecordsetDataSource;
						num = (short)1334902800;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 7:
					{
						global::System.Windows.Data.CollectionView collectionView;
						if (collectionView.Count > 0)
						{
							num = (short)576716818;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_348;
					}
					case 8:
					{
						if (((global::AcpUI.AcpRecNavToolbar)A_0).TableMode)
						{
							num = (short)924057603;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)1364632336;
						short num4 = num;
						num = (short)1318888208;
						switch ((num4 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							continue;
						default:
							num = (short)900792320;
							if (num != 0)
							{
							}
							((global::AcpUI.AcpRecNavToolbar)A_0).TableMode = true;
							num = (short)1318649857;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						break;
					}
					case 9:
					{
						global::System.Windows.Data.CollectionView collectionView;
						collectionView.MoveCurrentToLast();
						num = (short)630194186;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 10:
						goto IL_226;
					case 11:
						if (((global::AcpUI.AcpRecNavToolbar)A_0).Name == global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("솒힘漢쮞캠첢즤얦좨\ud9aa\udcae얰솲\udab4\ud8b8ힺ톼껀럂规껆뫈뿊藌ꃎꗐ鿒볔ꓖ귘", a_))
						{
							num = (short)19857427;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return;
					case 12:
						goto IL_201;
					case 13:
						goto IL_1B9;
					case 14:
					{
						object myRecordsetDataSource;
						global::System.Windows.Data.CollectionView collectionView = (global::System.Windows.Data.CollectionView)global::System.Windows.Data.CollectionViewSource.GetDefaultView(myRecordsetDataSource);
						global::SpecialFeatures.Ucl.HotList.AstroCallHotList astroCallHotList = (global::SpecialFeatures.Ucl.HotList.AstroCallHotList)collectionView.CurrentItem;
						num = (short)888537088;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 15:
						num = (short)1841823745;
						if (num != 0)
						{
						}
						num = (short)1110966292;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 16:
						if (myRecordsetDataSource2 != null)
						{
							num = (short)2140536844;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return;
					case 17:
						switch (0)
						{
						case 0:
							goto IL_CE;
						}
						continue;
					case 18:
						num = (short)253231106;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 19:
						num = (short)2018246664;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 20:
						if (((global::AcpUI.AcpRecNavToolbar)A_0).Name == global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("솒힘漢쮞캠첢즤얦좨\ud9aa첮\uddb0운쎶쮸풺ﺼ\udebe귀꿂跄꣆뷈蟊꓌볎ꗐ", a_))
						{
							num = (short)258670598;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)283312139;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 21:
						goto IL_17C;
					}
					IL_CE:
					if (!(A_0 is global::AcpUI.AcpRecNavToolbar))
					{
						return;
					}
					num = (short)1352663055;
					num2 = (int)((global::System.IntPtr)num);
				}
				IL_17C:
				IL_1B9:
				goto IL_348;
				IL_201:
				base.NavigationService.Navigate(new global::System.Uri(myRecordsetDataSource2.UIPagePath, global::System.UriKind.RelativeOrAbsolute));
				return;
				IL_226:
				goto IL_348;
				IL_299:
				return;
				IL_348:
				((global::AcpUI.AcpRecNavToolbar)A_0).SyncDataSources();
				return;
			}
			}
		}

		// Token: 0x060016C1 RID: 5825 RVA: 0x001F4BE4 File Offset: 0x001F2DE4
		private void a()
		{
			switch (0)
			{
			case 0:
				goto IL_1C;
			}
			int num;
			short num2;
			global::SpecialFeatures.Ucl.Contact.UclContactRecset uclContactRecset;
			for (;;)
			{
				IL_0A:
				global::System.Collections.Generic.IEnumerator<global::AcpBusinessLayer.FeatureNode> enumerator;
				switch (num)
				{
				case 0:
					num2 = (short)1439105025;
					if (num2 != 0)
					{
					}
					try
					{
						num2 = (short)1137704960;
						num = (int)((global::System.IntPtr)num2);
						for (;;)
						{
							switch (num)
							{
							case 0:
								switch (0)
								{
								case 0:
									goto IL_C2;
								}
								continue;
							case 1:
								num2 = (short)2107310082;
								num = (int)((global::System.IntPtr)num2);
								continue;
							case 2:
								goto IL_148;
							case 4:
								if (!enumerator.MoveNext())
								{
									num2 = (short)186515457;
									num = (int)((global::System.IntPtr)num2);
									continue;
								}
								((global::AcpBusinessLayer.Recordset)((global::SpecialFeatures.Ucl.Contact.UclContact)enumerator.Current).AstroCallList.EmbeddedRecset).RefreshKeyMap();
								num2 = (short)829620227;
								num = (int)((global::System.IntPtr)num2);
								continue;
							}
							IL_C4:
							num2 = (short)499777540;
							num = (int)((global::System.IntPtr)num2);
							continue;
							IL_C2:
							goto IL_C4;
						}
						IL_148:
						return;
					}
					finally
					{
						num2 = (short)79036418;
						num = (int)((global::System.IntPtr)num2);
						for (;;)
						{
							switch (num)
							{
							case 0:
								goto IL_202;
							case 1:
								enumerator.Dispose();
								num2 = (short)1434714112;
								num = (int)((global::System.IntPtr)num2);
								continue;
							case 2:
								switch (0)
								{
								case 0:
									goto IL_17E;
								}
								continue;
							}
							IL_17E:
							if (enumerator == null)
							{
								break;
							}
							num2 = (short)585700818;
							short num3 = num2;
							num2 = (short)1948456402;
							switch ((num3 == num2) ? 1 : 0)
							{
							case 0:
							case 2:
								goto IL_204;
							default:
								num2 = (short)491520000;
								if (num2 != 0)
								{
								}
								num2 = (short)1084620801;
								num = (int)((global::System.IntPtr)num2);
								break;
							}
						}
						IL_202:
						IL_204:;
					}
					goto IL_205;
				case 1:
					goto IL_205;
				case 2:
					if (uclContactRecset != null)
					{
						num2 = (short)348585984;
						short num4 = num2;
						num2 = (short)1244987393;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					return;
				}
				goto IL_1C;
				IL_205:
				enumerator = uclContactRecset.GetEnumerator();
				num2 = (short)1760034816;
				num = (int)((global::System.IntPtr)num2);
			}
			return;
			IL_1C:
			uclContactRecset = (global::AcpCommonLib.FeatureManager.GetFeature(2200) as global::SpecialFeatures.Ucl.Contact.UclContactRecset);
			num2 = (short)286588930;
			num = (int)((global::System.IntPtr)num2);
			goto IL_0A;
		}

		// Token: 0x060016C2 RID: 5826 RVA: 0x001F4E50 File Offset: 0x001F3050
		private void HLinkAstroCallHotListClick(object A_0, global::System.Windows.RoutedEventArgs A_1)
		{
			short num = (short)1399324672;
			short num2 = num;
			num = (short)158300687;
			short num3 = num;
			num = (short)751335951;
			switch (num3 == num)
			{
			}
			num = (short)451149825;
			if (num != 0)
			{
			}
			num = (short)1122893824;
			if (num != 0)
			{
			}
			base.OnHLinkClick(A_0);
		}

		// Token: 0x060016C3 RID: 5827 RVA: 0x001F4F04 File Offset: 0x001F3104
		[global::System.Diagnostics.DebuggerNonUserCode]
		[global::System.CodeDom.Compiler.GeneratedCode("PresentationBuildTasks", "5.0.10.0")]
		public void InitializeComponent()
		{
			int a_ = 1;
			short num;
			if (!this.b)
			{
				num = (short)75634706;
				short num2 = num;
				num = (short)1508775954;
				switch ((num2 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					break;
				default:
				{
					num = (short)1814888448;
					if (num != 0)
					{
					}
					num = (short)2046230529;
					if (num != 0)
					{
					}
					this.b = true;
					global::System.Uri resourceLocator = new global::System.Uri(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("ꮃ햅ﺑ튓聯얟톡龣얥잧잩\udcab솭\udeafힱ\udab3습鞷\ud9b9\uddbb튽겿꓇ꏉ뿋뫍뗕럗듙뫛럝蟟韡難蟥鳧菩菫胭\udfef髱鯳苵铷鏹迻諽⿿省會樅椇礉砋簍缏焑甓稕琗爙猛樝䰟䬡圣別堧䬩䬫䬭ḯ䨱唳嬵吷", a_), global::System.UriKind.Relative);
					global::System.Windows.Application.LoadComponent(this, resourceLocator);
					return;
				}
				}
			}
			num = (short)1614610432;
			short num3 = num;
		}

		// Token: 0x060016C4 RID: 5828 RVA: 0x001F4FE4 File Offset: 0x001F31E4
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		[global::System.Diagnostics.DebuggerNonUserCode]
		[global::System.CodeDom.Compiler.GeneratedCode("PresentationBuildTasks", "5.0.10.0")]
		void global::System.Windows.Markup.IComponentConnector.Connect(int connectionId, object target)
		{
			short num = (short)1912471554;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				switch (num2)
				{
				case 0:
					goto IL_224;
				case 1:
					num = (short)562954240;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 2:
					switch (0)
					{
					case 0:
						goto IL_31;
					}
					continue;
				}
				IL_31:
				num = (short)2010120193;
				if (num != 0)
				{
				}
				switch (connectionId)
				{
				case 1:
					goto IL_3A3;
				case 2:
					goto IL_415;
				case 3:
				case 4:
					goto IL_46A;
				case 5:
					goto IL_389;
				case 6:
					goto IL_177;
				case 7:
					goto IL_25E;
				case 8:
					goto IL_229;
				case 9:
					goto IL_12F;
				case 10:
					goto IL_1D9;
				case 11:
					goto IL_33E;
				case 12:
					goto IL_26B;
				case 13:
					goto IL_31A;
				case 14:
					goto IL_358;
				case 15:
					goto IL_37C;
				case 16:
					goto IL_200;
				case 17:
					goto IL_2F3;
				case 18:
					goto IL_300;
				case 19:
					goto IL_3FB;
				case 20:
					goto IL_3E1;
				case 21:
					goto IL_1CC;
				case 22:
					goto IL_122;
				case 23:
					goto IL_3D4;
				case 24:
					goto IL_396;
				case 25:
					goto IL_30D;
				case 26:
					goto IL_439;
				case 27:
					goto IL_115;
				case 28:
					goto IL_19B;
				case 29:
					goto IL_45D;
				case 30:
					goto IL_285;
				case 31:
					goto IL_34B;
				case 32:
					goto IL_153;
				case 33:
					goto IL_278;
				case 34:
					goto IL_1E6;
				case 35:
					goto IL_3EE;
				case 36:
					goto IL_1BF;
				case 37:
					goto IL_408;
				case 38:
					goto IL_1F3;
				default:
					num = (short)931528705;
					num2 = (int)((global::System.IntPtr)num);
					break;
				}
			}
			IL_115:
			this.CVBtnContactAlias = (global::AcpUI.AcpCustomViewCheckBox)target;
			return;
			IL_122:
			this.CallIdTable_Col = (global::Infragistics.Windows.DataPresenter.UnboundField)target;
			return;
			IL_12F:
			this.RecNavToolbarAstroCallHotListHotList = (global::AcpUI.AcpChildRecNavToolbar)target;
			this.RecNavToolbarAstroCallHotListHotList.ModeClick += this.OnModeClick;
			return;
			IL_153:
			this.LblCallID = (global::AcpUI.AcpLabel)target;
			this.LblCallID.MouseDoubleClick += new global::System.Windows.Input.MouseButtonEventHandler(this.OnFieldNameDoubleClick);
			return;
			IL_177:
			this.HLinkAstroCallHotList = (global::System.Windows.Documents.Hyperlink)target;
			this.HLinkAstroCallHotList.Click += this.HLinkAstroCallHotListClick;
			return;
			IL_19B:
			this.LblContactAlias = (global::AcpUI.AcpLabel)target;
			this.LblContactAlias.MouseDoubleClick += new global::System.Windows.Input.MouseButtonEventHandler(this.OnFieldNameDoubleClick);
			return;
			IL_1BF:
			this.ContactAliasComp = (global::AcpUI.AcpViewOnlyCtrl)target;
			return;
			IL_1CC:
			this.ContactAliasTable_Col = (global::Infragistics.Windows.DataPresenter.UnboundField)target;
			return;
			IL_1D9:
			this.GrpBoxExpanderPseudo0 = (global::AcpUI.AcpGroupBox)target;
			return;
			IL_1E6:
			this.CompGridGeneralGrp = (global::System.Windows.Controls.Grid)target;
			return;
			IL_1F3:
			this.CallIDComp = (global::AcpUI.AcpViewOnlyCtrl)target;
			return;
			IL_200:
			this.CpyBtnHotListAlias = (global::AcpUI.AcpCopyButton)target;
			return;
			IL_224:
			goto IL_46A;
			IL_229:
			num = (short)1646657536;
			short num3 = num;
			this.ExpAstroCallHotList = (global::AcpUI.AcpExpander)target;
			return;
			IL_25E:
			this.MyStackPanel = (global::System.Windows.Controls.StackPanel)target;
			return;
			IL_26B:
			this.CVBtnAstroHotListAlias = (global::AcpUI.AcpCustomViewCheckBox)target;
			return;
			IL_278:
			this.RtdBtnCallID = (global::AcpUI.AcpRtdButton)target;
			return;
			IL_285:
			num = (short)1881738361;
			short num4 = num;
			num = (short)901254265;
			switch ((num4 == num) ? 1 : 0)
			{
			case 0:
			case 2:
				goto IL_224;
			default:
				num = (short)415956992;
				if (num != 0)
				{
				}
				this.CallID = (global::AcpUI.AcpComboBox)target;
				this.CallID.GotFocus += this.OnFieldNameDoubleClick;
				return;
			}
			IL_2F3:
			this.TxtBoxHotListAliasComp = (global::AcpUI.AcpViewOnlyCtrl)target;
			return;
			IL_300:
			this.GridFrame = (global::System.Windows.Controls.Grid)target;
			return;
			IL_30D:
			this.StdGridGeneralGrp = (global::System.Windows.Controls.Grid)target;
			return;
			IL_31A:
			this.LblHotListAlias = (global::AcpUI.AcpLabel)target;
			this.LblHotListAlias.MouseDoubleClick += new global::System.Windows.Input.MouseButtonEventHandler(this.OnFieldNameDoubleClick);
			return;
			IL_33E:
			this.StdGrpBoxExpanderColumn = (global::System.Windows.Controls.Grid)target;
			return;
			IL_34B:
			this.CVBtnCallID = (global::AcpUI.AcpCustomViewCheckBox)target;
			return;
			IL_358:
			this.TxtBoxHotListAlias = (global::AcpUI.AcpTextBox)target;
			this.TxtBoxHotListAlias.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_37C:
			this.CompGrpBoxExpanderColumn = (global::System.Windows.Controls.Grid)target;
			return;
			IL_389:
			this.ThemeBaseObj = (global::AcpUI.Common.AcpThemeBase)target;
			return;
			IL_396:
			this.grid = (global::System.Windows.Controls.Grid)target;
			return;
			IL_3A3:
			((global::SpecialFeatures.Ucl.HotList.UclAstroCallHotListPage)target).Loaded += this.OnLoaded;
			((global::SpecialFeatures.Ucl.HotList.UclAstroCallHotListPage)target).Unloaded += this.OnUnloaded;
			return;
			IL_3D4:
			this.GroupBoxSRecView = (global::AcpUI.AcpGroupBox)target;
			return;
			IL_3E1:
			this.AstroCallHotListDataPresenter = (global::AcpUI.AcpXamDataPresenter)target;
			return;
			IL_3EE:
			this.CopyButtonContactAlias = (global::AcpUI.AcpCopyButton)target;
			return;
			IL_3FB:
			this.GroupBoxTableView = (global::AcpUI.AcpGroupBox)target;
			return;
			IL_408:
			this.CopyButtonCallID = (global::AcpUI.AcpCopyButton)target;
			return;
			IL_415:
			this.RecNavToolbarUclAstroCallHotList = (global::AcpUI.AcpParentRecNavToolbar)target;
			this.RecNavToolbarUclAstroCallHotList.ModeClick += this.OnModeClick;
			return;
			IL_439:
			this.ContactAlias = (global::AcpUI.AcpComboBox)target;
			this.ContactAlias.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_45D:
			this.RtdBtnContactAlias = (global::AcpUI.AcpRtdButton)target;
			return;
			IL_46A:
			this.b = true;
		}

		// Token: 0x060016C5 RID: 5829 RVA: 0x001F5464 File Offset: 0x001F3664
		[global::System.Diagnostics.DebuggerNonUserCode]
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		[global::System.CodeDom.Compiler.GeneratedCode("PresentationBuildTasks", "5.0.10.0")]
		void global::System.Windows.Markup.IStyleConnector.Connect(int connectionId, object target)
		{
			short num;
			for (;;)
			{
				num = (short)282787840;
				int num2 = (int)((global::System.IntPtr)num);
				for (;;)
				{
					switch (num2)
					{
					case 0:
						switch (0)
						{
						case 0:
							goto IL_34;
						}
						continue;
					case 1:
						goto IL_E9;
					case 2:
						num = (short)279314435;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 3:
						if (connectionId != 4)
						{
							num = (short)510525441;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_EB;
					}
					IL_34:
					if (connectionId == 3)
					{
						goto IL_4E;
					}
					num = (short)2126315522;
					num2 = (int)((global::System.IntPtr)num);
				}
				IL_EB:
				num = (short)647874637;
				short num3 = num;
				num = (short)1863305293;
				switch ((num3 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					break;
				default:
					goto IL_121;
				}
			}
			IL_4E:
			num = (short)2108686336;
			short num4 = num;
			((global::AcpUI.AcpTableComboBox)target).GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_E9:
			num = (short)671285249;
			if (num != 0)
			{
			}
			return;
			IL_121:
			num = (short)1802960896;
			if (num != 0)
			{
			}
			((global::AcpUI.AcpTableComboBox)target).GotFocus += this.OnFieldNameDoubleClick;
		}

		// Token: 0x04000B9B RID: 2971
		private bool a;

		// Token: 0x04000B9C RID: 2972
		internal global::AcpUI.AcpParentRecNavToolbar RecNavToolbarUclAstroCallHotList;

		// Token: 0x04000B9D RID: 2973
		internal global::AcpUI.Common.AcpThemeBase ThemeBaseObj;

		// Token: 0x04000B9E RID: 2974
		internal global::System.Windows.Documents.Hyperlink HLinkAstroCallHotList;

		// Token: 0x04000B9F RID: 2975
		internal global::System.Windows.Controls.StackPanel MyStackPanel;

		// Token: 0x04000BA0 RID: 2976
		internal global::AcpUI.AcpExpander ExpAstroCallHotList;

		// Token: 0x04000BA1 RID: 2977
		internal global::AcpUI.AcpChildRecNavToolbar RecNavToolbarAstroCallHotListHotList;

		// Token: 0x04000BA2 RID: 2978
		internal global::AcpUI.AcpGroupBox GrpBoxExpanderPseudo0;

		// Token: 0x04000BA3 RID: 2979
		internal global::System.Windows.Controls.Grid StdGrpBoxExpanderColumn;

		// Token: 0x04000BA4 RID: 2980
		internal global::AcpUI.AcpCustomViewCheckBox CVBtnAstroHotListAlias;

		// Token: 0x04000BA5 RID: 2981
		internal global::AcpUI.AcpLabel LblHotListAlias;

		// Token: 0x04000BA6 RID: 2982
		internal global::AcpUI.AcpTextBox TxtBoxHotListAlias;

		// Token: 0x04000BA7 RID: 2983
		internal global::System.Windows.Controls.Grid CompGrpBoxExpanderColumn;

		// Token: 0x04000BA8 RID: 2984
		internal global::AcpUI.AcpCopyButton CpyBtnHotListAlias;

		// Token: 0x04000BA9 RID: 2985
		internal global::AcpUI.AcpViewOnlyCtrl TxtBoxHotListAliasComp;

		// Token: 0x04000BAA RID: 2986
		internal global::System.Windows.Controls.Grid GridFrame;

		// Token: 0x04000BAB RID: 2987
		internal global::AcpUI.AcpGroupBox GroupBoxTableView;

		// Token: 0x04000BAC RID: 2988
		internal global::AcpUI.AcpXamDataPresenter AstroCallHotListDataPresenter;

		// Token: 0x04000BAD RID: 2989
		internal global::Infragistics.Windows.DataPresenter.UnboundField ContactAliasTable_Col;

		// Token: 0x04000BAE RID: 2990
		internal global::Infragistics.Windows.DataPresenter.UnboundField CallIdTable_Col;

		// Token: 0x04000BAF RID: 2991
		internal global::AcpUI.AcpGroupBox GroupBoxSRecView;

		// Token: 0x04000BB0 RID: 2992
		internal global::System.Windows.Controls.Grid grid;

		// Token: 0x04000BB1 RID: 2993
		internal global::System.Windows.Controls.Grid StdGridGeneralGrp;

		// Token: 0x04000BB2 RID: 2994
		internal global::AcpUI.AcpComboBox ContactAlias;

		// Token: 0x04000BB3 RID: 2995
		internal global::AcpUI.AcpCustomViewCheckBox CVBtnContactAlias;

		// Token: 0x04000BB4 RID: 2996
		internal global::AcpUI.AcpLabel LblContactAlias;

		// Token: 0x04000BB5 RID: 2997
		internal global::AcpUI.AcpRtdButton RtdBtnContactAlias;

		// Token: 0x04000BB6 RID: 2998
		internal global::AcpUI.AcpComboBox CallID;

		// Token: 0x04000BB7 RID: 2999
		internal global::AcpUI.AcpCustomViewCheckBox CVBtnCallID;

		// Token: 0x04000BB8 RID: 3000
		internal global::AcpUI.AcpLabel LblCallID;

		// Token: 0x04000BB9 RID: 3001
		internal global::AcpUI.AcpRtdButton RtdBtnCallID;

		// Token: 0x04000BBA RID: 3002
		internal global::System.Windows.Controls.Grid CompGridGeneralGrp;

		// Token: 0x04000BBB RID: 3003
		internal global::AcpUI.AcpCopyButton CopyButtonContactAlias;

		// Token: 0x04000BBC RID: 3004
		internal global::AcpUI.AcpViewOnlyCtrl ContactAliasComp;

		// Token: 0x04000BBD RID: 3005
		internal global::AcpUI.AcpCopyButton CopyButtonCallID;

		// Token: 0x04000BBE RID: 3006
		internal global::AcpUI.AcpViewOnlyCtrl CallIDComp;

		// Token: 0x04000BBF RID: 3007
		private bool b;
	}
}
