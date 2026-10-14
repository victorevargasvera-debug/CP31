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

namespace Motorola.MackinawCPS.CoreFeatures.TrunkingSystem
{
	// Token: 0x020000A9 RID: 169
	public class PageTrunkingSystem : global::AcpUI.AcpPageFeature, global::System.Windows.Markup.IComponentConnector, global::System.Windows.Markup.IStyleConnector
	{
		// Token: 0x0600151B RID: 5403 RVA: 0x0013A120 File Offset: 0x00138320
		public PageTrunkingSystem()
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

		// Token: 0x0600151C RID: 5404 RVA: 0x0013A158 File Offset: 0x00138358
		public override void OnLoaded(object sender, global::System.Windows.RoutedEventArgs e)
		{
			short num = (short)1247084544;
			int num2 = (int)num;
			switch (num2)
			{
			default:
				num = (short)1891303435;
				num2 = (int)((global::System.IntPtr)num);
				for (;;)
				{
					object obj;
					global::System.Collections.IEnumerator enumerator;
					global::AcpUI.AcpExpander acpExpander;
					switch (num2)
					{
					case 0:
					{
						global::System.Windows.Data.CollectionView collectionView = (global::System.Windows.Data.CollectionView)global::System.Windows.Data.CollectionViewSource.GetDefaultView(obj);
						this.RecNavToolbarExpanderTrunkingSystemMessageAliasTable.MyDataPresenter = this.ExpanderTrunkingSystemMessageAliasTable;
						num = (short)972357651;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 1:
						goto IL_4DE;
					case 2:
						goto IL_4D9;
					case 3:
						goto IL_47F;
					case 4:
						try
						{
							num = (short)1630273542;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								switch (num2)
								{
								case 0:
								{
									num = (short)1867655494;
									short num3 = num;
									num = (short)1325738310;
									switch ((num3 == num) ? 1 : 0)
									{
									case 0:
									case 2:
										goto IL_1FA;
									default:
										num = (short)621150208;
										if (num != 0)
										{
										}
										num = (short)1998848002;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									break;
								}
								case 1:
									if (!enumerator.MoveNext())
									{
										num = (short)1138622464;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									goto IL_1FA;
								case 2:
									goto IL_2D9;
								case 3:
									base.Expanders.Add(acpExpander);
									num = (short)130613252;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 5:
									if (acpExpander != null)
									{
										num = (short)1449721859;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									break;
								case 6:
									switch (0)
									{
									case 0:
										goto IL_1D4;
									}
									continue;
								}
								goto IL_1D4;
								IL_1FA:
								acpExpander = (((global::System.Windows.UIElement)enumerator.Current) as global::AcpUI.AcpExpander);
								num = (short)322109445;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								IL_23D:
								num = (short)1145241601;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								IL_1D4:
								goto IL_23D;
							}
							IL_2D9:
							goto IL_4B0;
						}
						finally
						{
							switch (0)
							{
							case 0:
								goto IL_2FB;
							}
							global::System.IDisposable disposable;
							for (;;)
							{
								IL_2E8:
								switch (num2)
								{
								case 0:
									disposable.Dispose();
									num = (short)1583087617;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 1:
									goto IL_34E;
								case 2:
									if (disposable != null)
									{
										num = (short)468058112;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									goto IL_350;
								}
								goto IL_2FB;
							}
							IL_34E:
							IL_350:
							goto EndFinally_14;
							IL_2FB:
							disposable = (enumerator as global::System.IDisposable);
							num = (short)2044919810;
							num2 = (int)((global::System.IntPtr)num);
							goto IL_2E8;
							EndFinally_14:;
						}
						goto IL_351;
						IL_4B0:
						base.OnLoaded(sender, e);
						this.a = true;
						num = (short)637992962;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 5:
						goto IL_729;
					case 6:
						if (obj != null)
						{
							num = (short)1214578697;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_729;
					case 7:
						if (obj != null)
						{
							num = (short)1175977984;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_3C5;
					case 8:
						goto IL_D3;
					case 9:
					{
						global::System.Windows.Data.CollectionView collectionView2 = (global::System.Windows.Data.CollectionView)global::System.Windows.Data.CollectionViewSource.GetDefaultView(obj);
						this.RecNavToolbarExpanderTrunkingSystemStatusAliasTable.MyDataPresenter = this.ExpanderTrunkingSystemStatusAliasTable;
						num = (short)8323077;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 10:
					{
						global::System.Windows.Data.CollectionView collectionView3 = (global::System.Windows.Data.CollectionView)global::System.Windows.Data.CollectionViewSource.GetDefaultView(obj);
						this.RecNavToolbarExpanderTrunkingSystemOneTouchTable.MyDataPresenter = this.ExpanderTrunkingSystemOneTouchTable;
						num = (short)843579395;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 11:
						switch (0)
						{
						case 0:
							goto IL_A9;
						}
						continue;
					case 12:
						if (obj != null)
						{
							num = (short)537853976;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_62F;
					case 13:
						goto IL_40C;
					case 14:
					{
						num = (short)1073938433;
						if (num != 0)
						{
						}
						global::System.Windows.Data.CollectionView collectionView4 = (global::System.Windows.Data.CollectionView)global::System.Windows.Data.CollectionViewSource.GetDefaultView(obj);
						this.RecNavToolbarExpanderTrunkingSystemASTRO25ChannelIDTable.MyDataPresenter = this.ExpanderTrunkingSystemASTRO25ChannelIDTable;
						num = (short)1617887233;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 15:
						if (obj != null)
						{
							num = (short)1645543447;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_40C;
					case 16:
					{
						global::System.Windows.Data.CollectionView collectionView5 = (global::System.Windows.Data.CollectionView)global::System.Windows.Data.CollectionViewSource.GetDefaultView(obj);
						this.RecNavToolbarExpanderTrunkingSystemSiteAliasTable.MyDataPresenter = this.ExpanderTrunkingSystemSiteAliasTable;
						num = (short)1603338248;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 17:
						goto IL_62F;
					case 18:
						if (obj != null)
						{
							num = (short)1780482058;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_47F;
					case 19:
						goto IL_3C5;
					case 20:
						if (obj != null)
						{
							num = (short)798621712;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_D3;
					case 21:
						if (obj != null)
						{
							num = (short)1132658702;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_4DE;
					case 22:
						this.RecNavToolbarPageTrunkingSystem.ChildToolbars.Add(this.RecNavToolbarExpanderTrunkingSystemChannelRangesMHz);
						this.RecNavToolbarPageTrunkingSystem.ChildToolbars.Add(this.RecNavToolbarExpanderTrunkingSystemControlChannelsTable);
						this.RecNavToolbarPageTrunkingSystem.ChildToolbars.Add(this.RecNavToolbarExpanderTrunkingSystemASTRO25ChannelIDTable);
						this.RecNavToolbarPageTrunkingSystem.ChildToolbars.Add(this.RecNavToolbarExpanderTrunkingSystemMessageAliasTable);
						this.RecNavToolbarPageTrunkingSystem.ChildToolbars.Add(this.RecNavToolbarExpanderTrunkingSystemStatusAliasTable);
						this.RecNavToolbarPageTrunkingSystem.ChildToolbars.Add(this.RecNavToolbarExpanderTrunkingSystemSiteAliasTable);
						this.RecNavToolbarPageTrunkingSystem.ChildToolbars.Add(this.RecNavToolbarExpanderTrunkingSystemOneTouchTable);
						obj = null;
						obj = this.RecNavToolbarExpanderTrunkingSystemChannelRangesMHz.MyRecordsetDataSource;
						num = (short)2044395532;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 23:
					{
						global::System.Windows.Data.CollectionView collectionView6 = (global::System.Windows.Data.CollectionView)global::System.Windows.Data.CollectionViewSource.GetDefaultView(obj);
						this.RecNavToolbarExpanderTrunkingSystemControlChannelsTable.MyDataPresenter = this.ExpanderTrunkingSystemControlChannelsTable;
						num = (short)139788301;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 24:
						goto IL_351;
					}
					IL_A9:
					if (!this.a)
					{
						num = (short)1704722454;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					break;
					IL_D3:
					obj = this.RecNavToolbarExpanderTrunkingSystemOneTouchTable.MyRecordsetDataSource;
					num = (short)49086482;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_351:
					global::System.Windows.Data.CollectionView collectionView7 = (global::System.Windows.Data.CollectionView)global::System.Windows.Data.CollectionViewSource.GetDefaultView(obj);
					this.RecNavToolbarExpanderTrunkingSystemChannelRangesMHz.MyDataPresenter = this.ExpanderTrunkingSystemChannelRangesMHz;
					num = (short)459669521;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_3C5:
					obj = this.RecNavToolbarExpanderTrunkingSystemStatusAliasTable.MyRecordsetDataSource;
					num = (short)1129119750;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_40C:
					obj = this.RecNavToolbarExpanderTrunkingSystemASTRO25ChannelIDTable.MyRecordsetDataSource;
					num = (short)531103765;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_47F:
					acpExpander = null;
					enumerator = this.MyStackPanel.Children.GetEnumerator();
					num = (short)778960900;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_4DE:
					obj = this.RecNavToolbarExpanderTrunkingSystemMessageAliasTable.MyRecordsetDataSource;
					num = (short)1839726592;
					short num4 = num;
					num = (short)2118451207;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_62F:
					obj = this.RecNavToolbarExpanderTrunkingSystemControlChannelsTable.MyRecordsetDataSource;
					num = (short)247070735;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_729:
					obj = this.RecNavToolbarExpanderTrunkingSystemSiteAliasTable.MyRecordsetDataSource;
					num = (short)711131156;
					num2 = (int)((global::System.IntPtr)num);
				}
				IL_4D9:
				this.MyStackPanel.Children[0].Focus();
				return;
			}
		}

		// Token: 0x0600151D RID: 5405 RVA: 0x0013A90C File Offset: 0x00138B0C
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
					for (;;)
					{
						base.OnUnloaded(sender, e);
						this.a = false;
						num2 = (short)1017383709;
						short num3 = num2;
						num2 = (short)572984093;
						switch ((num3 == num2) ? 1 : 0)
						{
						case 0:
						case 2:
							break;
						default:
							goto IL_23C;
						}
					}
					IL_23C:
					num2 = (short)660013056;
					if (num2 != 0)
					{
					}
					num2 = (short)344850433;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 1:
					return;
				case 2:
					if (this.a)
					{
						num2 = (short)384499712;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					return;
				}
				goto IL_1C;
			}
			return;
			IL_1C:
			num2 = (short)1969225729;
			if (num2 != 0)
			{
			}
			this.RecNavToolbarPageTrunkingSystem.DataContext = null;
			this.RecNavToolbarPageTrunkingSystem.DataContext = null;
			this.RecNavToolbarPageTrunkingSystem.DataContext = null;
			this.RecNavToolbarPageTrunkingSystem.DataContext = null;
			this.RecNavToolbarPageTrunkingSystem.DataContext = null;
			this.RecNavToolbarPageTrunkingSystem.DataContext = null;
			this.RecNavToolbarPageTrunkingSystem.DataContext = null;
			this.RecNavToolbarExpanderTrunkingSystemChannelRangesMHz.DataContext = null;
			this.RecNavToolbarExpanderTrunkingSystemControlChannelsTable.DataContext = null;
			this.RecNavToolbarExpanderTrunkingSystemASTRO25ChannelIDTable.DataContext = null;
			this.RecNavToolbarExpanderTrunkingSystemMessageAliasTable.DataContext = null;
			this.RecNavToolbarExpanderTrunkingSystemStatusAliasTable.DataContext = null;
			this.RecNavToolbarExpanderTrunkingSystemSiteAliasTable.DataContext = null;
			this.RecNavToolbarExpanderTrunkingSystemOneTouchTable.DataContext = null;
			this.RecNavToolbarPageTrunkingSystem.MyDataPresenter = null;
			this.RecNavToolbarPageTrunkingSystem.MyDataPresenter = null;
			this.RecNavToolbarPageTrunkingSystem.MyDataPresenter = null;
			this.RecNavToolbarPageTrunkingSystem.MyDataPresenter = null;
			this.RecNavToolbarPageTrunkingSystem.MyDataPresenter = null;
			this.RecNavToolbarPageTrunkingSystem.MyDataPresenter = null;
			this.RecNavToolbarPageTrunkingSystem.MyDataPresenter = null;
			this.RecNavToolbarExpanderTrunkingSystemChannelRangesMHz.MyDataPresenter = null;
			this.RecNavToolbarExpanderTrunkingSystemControlChannelsTable.MyDataPresenter = null;
			this.RecNavToolbarExpanderTrunkingSystemASTRO25ChannelIDTable.MyDataPresenter = null;
			this.RecNavToolbarExpanderTrunkingSystemMessageAliasTable.MyDataPresenter = null;
			this.RecNavToolbarExpanderTrunkingSystemStatusAliasTable.MyDataPresenter = null;
			this.RecNavToolbarExpanderTrunkingSystemSiteAliasTable.MyDataPresenter = null;
			this.RecNavToolbarExpanderTrunkingSystemOneTouchTable.MyDataPresenter = null;
			num2 = (short)1699151872;
			short num4 = num2;
			num2 = (short)1639841794;
			num = (int)((global::System.IntPtr)num2);
			goto IL_0A;
		}

		// Token: 0x0600151E RID: 5406 RVA: 0x0013AB84 File Offset: 0x00138D84
		public override void SetDataContext()
		{
			short num = (short)1707540488;
			int num2 = (int)((global::System.IntPtr)num);
			object feature;
			for (;;)
			{
				switch (num2)
				{
				case 0:
					goto IL_A2;
				case 1:
					if (feature != null)
					{
						num = (short)459866116;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					return;
				case 2:
					goto IL_A2;
				case 3:
					if (global::AcpCommonLib.AppInfoManager.AppMode == global::AcpCommonLib.ApplicationMode.CodeplugComparisonMode)
					{
						num = (short)1775370247;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					((global::AcpUILib.IAcpRecNavToolbar)this.RecNavToolbarPageTrunkingSystem).MySecondaryRecordsetDataSource = null;
					num = (short)1835073541;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 4:
				{
					num = (short)1514769726;
					short num3 = num;
					num = (short)1954319678;
					switch ((num3 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						continue;
					default:
						goto IL_21C;
					}
					break;
				}
				case 5:
					goto IL_14A;
				case 6:
					base.DataContext = global::AcpCommonLib.AppInfoManager.DefaultDocument.GetFeature(2064);
					num = (short)145031170;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 7:
					feature = global::AcpCommonLib.AppInfoManager.ComparatorDocument.GetFeature(2064);
					num = (short)2095382529;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 8:
					num = (short)947781633;
					if (num != 0)
					{
					}
					switch (0)
					{
					case 0:
						goto IL_6F;
					}
					continue;
				}
				IL_6F:
				if (global::AcpCommonLib.AppInfoManager.AppMode == global::AcpCommonLib.ApplicationMode.CustomViewConfigurationMode)
				{
					num = (short)1032388614;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				base.DataContext = global::AcpCommonLib.FeatureManager.GetFeature(2064);
				num = (short)1522401280;
				short num4 = num;
				num = (short)202768384;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_A2:
				this.RecNavToolbarPageTrunkingSystem.DataContext = (global::AcpCommonLib.IAcpRecordset)base.DataContext;
				num = (short)1363738627;
				num2 = (int)((global::System.IntPtr)num);
			}
			IL_14A:
			return;
			IL_21C:
			num = (short)534249472;
			if (num != 0)
			{
			}
			((global::AcpUILib.IAcpRecNavToolbar)this.RecNavToolbarPageTrunkingSystem).MySecondaryRecordsetDataSource = (global::AcpCommonLib.IAcpRecordset)feature;
		}

		// Token: 0x0600151F RID: 5407 RVA: 0x0013ADCC File Offset: 0x00138FCC
		private void OnModeClick(object A_0, global::System.Windows.RoutedEventArgs A_1)
		{
			int a_ = 3;
			short num = (short)735379456;
			switch (num)
			{
			default:
			{
				num = (short)490078272;
				int num2 = (int)((global::System.IntPtr)num);
				for (;;)
				{
					switch (num2)
					{
					case 0:
						num = (short)1965162536;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 1:
						goto IL_26A;
					case 2:
						goto IL_F4A;
					case 3:
						if (((global::AcpUI.AcpRecNavToolbar)A_0).Name == global::AllFeatures.CodeplugGuid.b("雃ꏅꯇ蓉귋룍蓏뷑믓뫕뫗믙껛鯝食鋡藣裥賧迩黫뫭苯蟱髳鷵釷铹鯻귽秿焁瀃挅攇䬉弋娍䈏崑☓⌕嬗爙紛瀝丟䜡䠣漥氧縩䴫䰭尯圱", a_))
						{
							num = (short)2147024976;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_1035;
					case 4:
					{
						global::AcpCommonLib.IAcpRecordset myRecordsetDataSource;
						base.NavigationService.Navigate(new global::System.Uri(myRecordsetDataSource.UIPagePath, global::System.UriKind.RelativeOrAbsolute));
						num = (short)1436286996;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 5:
					{
						object myRecordsetDataSource2;
						global::System.Windows.Data.CollectionView collectionView = (global::System.Windows.Data.CollectionView)global::System.Windows.Data.CollectionViewSource.GetDefaultView(myRecordsetDataSource2);
						global::Motorola.MackinawCPS.CoreFeatures.TrunkingSystem.ControlChannelsInner controlChannelsInner = (global::Motorola.MackinawCPS.CoreFeatures.TrunkingSystem.ControlChannelsInner)collectionView.CurrentItem;
						num = (short)517931033;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 6:
					{
						object myRecordsetDataSource3;
						if (myRecordsetDataSource3 != null)
						{
							num = (short)707919957;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_449;
					}
					case 7:
						goto IL_DE9;
					case 8:
						goto IL_292;
					case 9:
						goto IL_D33;
					case 10:
					{
						global::System.Windows.Data.CollectionView collectionView2;
						global::Motorola.MackinawCPS.CoreFeatures.TrunkingSystem.SiteAliasInner siteAliasInner;
						collectionView2.MoveCurrentTo(siteAliasInner);
						num = (short)1657339938;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 11:
					{
						global::System.Windows.Data.CollectionView collectionView3;
						global::Motorola.MackinawCPS.CoreFeatures.TrunkingSystem.ASTRO25ChannelIDInner astro25ChannelIDInner;
						collectionView3.MoveCurrentTo(astro25ChannelIDInner);
						num = (short)856686704;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 12:
						goto IL_577;
					case 13:
						goto IL_EF0;
					case 14:
					{
						global::System.Windows.Data.CollectionView collectionView4;
						global::Motorola.MackinawCPS.CoreFeatures.TrunkingSystem.StatusAliasInner statusAliasInner;
						collectionView4.MoveCurrentTo(statusAliasInner);
						num = (short)1342177281;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 15:
						goto IL_26A;
					case 16:
						if (((global::AcpUI.AcpRecNavToolbar)A_0).Name == global::AllFeatures.CodeplugGuid.b("雃ꏅꯇ蓉귋룍蓏뷑믓뫕뫗믙껛鯝食鋡藣裥賧迩黫뫭苯蟱髳鷵釷铹鯻귽秿焁瀃挅攇䜉椋納挏猑猓猕夗瘙甛缝匟瘡䔣䐥䐧伩", a_))
						{
							num = (short)1302724702;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_F4A;
					case 17:
					{
						object myRecordsetDataSource4;
						if (myRecordsetDataSource4 != null)
						{
							num = (short)345047062;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_C3B;
					}
					case 18:
						if (((global::AcpUI.AcpRecNavToolbar)A_0).Name == global::AllFeatures.CodeplugGuid.b("雃ꏅꯇ蓉귋룍蓏뷑믓뫕뫗믙껛鯝食鋡藣裥賧迩黫뫭苯蟱髳鷵釷铹鯻귽秿焁瀃挅攇䤉挋怍搏怑笓稕嬗爙紛瀝丟䜡䠣唥簧䬩丫䈭唯", a_))
						{
							num = (short)581894198;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_6EE;
					case 19:
						if (((global::AcpUI.AcpRecNavToolbar)A_0).Name == global::AllFeatures.CodeplugGuid.b("雃ꏅꯇ蓉귋룍蓏뷑믓뫕뫗믙껛鯝食鋡藣裥賧迩黫뫭苯蟱髳鷵釷铹鯻귽秿焁瀃挅攇変砋漍搏朑朓圕琗猙紛洝琟䌡䘣䨥䴧", a_))
						{
							num = (short)503382044;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_EF0;
					case 20:
						goto IL_1322;
					case 21:
						goto IL_F4A;
					case 22:
					{
						object myRecordsetDataSource4;
						global::System.Windows.Data.CollectionView collectionView5 = (global::System.Windows.Data.CollectionView)global::System.Windows.Data.CollectionViewSource.GetDefaultView(myRecordsetDataSource4);
						global::Motorola.MackinawCPS.CoreFeatures.TrunkingSystem.ChannelRangesMHzInner channelRangesMHzInner = (global::Motorola.MackinawCPS.CoreFeatures.TrunkingSystem.ChannelRangesMHzInner)collectionView5.CurrentItem;
						num = (short)1409351706;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 23:
					{
						global::System.Windows.Data.CollectionView collectionView2;
						collectionView2.MoveCurrentToLast();
						num = (short)438894631;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 24:
					{
						global::System.Windows.Data.CollectionView collectionView6;
						if (collectionView6.IsCurrentAfterLast)
						{
							num = (short)959447086;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						collectionView6.MoveCurrentToFirst();
						num = (short)1302659183;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 25:
					{
						global::Motorola.MackinawCPS.CoreFeatures.TrunkingSystem.ControlChannelsInner controlChannelsInner;
						if (controlChannelsInner != null)
						{
							num = (short)897253497;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)699072595;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 26:
					{
						global::Motorola.MackinawCPS.CoreFeatures.TrunkingSystem.ChannelRangesMHzInner channelRangesMHzInner;
						if (channelRangesMHzInner != null)
						{
							num = (short)783286272;
							short num3 = num;
							num = (short)1781727292;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)516030506;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 27:
					{
						object myRecordsetDataSource5;
						if (myRecordsetDataSource5 != null)
						{
							num = (short)64487456;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return;
					}
					case 28:
						num = (short)1850671173;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 29:
					{
						global::System.Windows.Data.CollectionView collectionView6;
						global::Motorola.MackinawCPS.CoreFeatures.TrunkingSystem.MessageAliasInner messageAliasInner;
						collectionView6.MoveCurrentTo(messageAliasInner);
						num = (short)1517289573;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 30:
						num = (short)603455596;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 31:
						if (((global::AcpUI.AcpRecNavToolbar)A_0).Name == global::AllFeatures.CodeplugGuid.b("雃ꏅꯇ蓉귋룍蓏뷑믓뫕뫗믙껛鯝食鋡藣裥賧迩黫뫭苯蟱髳鷵釷铹鯻귽秿焁瀃挅攇䤉搋漍縏簑焓稕䨗笙爛礝䔟儡椣渥刧", a_))
						{
							num = (short)1650589800;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_C3B;
					case 32:
					{
						object myRecordsetDataSource5;
						global::System.Windows.Data.CollectionView collectionView7 = (global::System.Windows.Data.CollectionView)global::System.Windows.Data.CollectionViewSource.GetDefaultView(myRecordsetDataSource5);
						global::Motorola.MackinawCPS.CoreFeatures.TrunkingSystem.OneTouchInner oneTouchInner = (global::Motorola.MackinawCPS.CoreFeatures.TrunkingSystem.OneTouchInner)collectionView7.CurrentItem;
						num = (short)819200090;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 33:
					{
						object myRecordsetDataSource2;
						if (myRecordsetDataSource2 != null)
						{
							num = (short)1906180101;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_6EE;
					}
					case 34:
						goto IL_D33;
					case 35:
						goto IL_C3B;
					case 36:
						goto IL_154E;
					case 37:
					{
						global::Motorola.MackinawCPS.CoreFeatures.TrunkingSystem.SiteAliasInner siteAliasInner;
						if (siteAliasInner != null)
						{
							num = (short)389611530;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)1765802103;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 38:
					{
						global::System.Windows.Data.CollectionView collectionView;
						if (collectionView.IsCurrentAfterLast)
						{
							num = (short)680067195;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						collectionView.MoveCurrentToFirst();
						num = (short)1527185522;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 39:
						goto IL_D33;
					case 40:
					{
						global::System.Windows.Data.CollectionView collectionView4;
						if (collectionView4.IsCurrentAfterLast)
						{
							num = (short)1412235373;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						collectionView4.MoveCurrentToFirst();
						num = (short)1412759634;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 41:
						goto IL_6EE;
					case 42:
					{
						global::System.Windows.Data.CollectionView collectionView5;
						if (collectionView5.Count > 0)
						{
							num = (short)563544174;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_577;
					}
					case 43:
					{
						object myRecordsetDataSource6;
						global::System.Windows.Data.CollectionView collectionView4 = (global::System.Windows.Data.CollectionView)global::System.Windows.Data.CollectionViewSource.GetDefaultView(myRecordsetDataSource6);
						global::Motorola.MackinawCPS.CoreFeatures.TrunkingSystem.StatusAliasInner statusAliasInner = (global::Motorola.MackinawCPS.CoreFeatures.TrunkingSystem.StatusAliasInner)collectionView4.CurrentItem;
						num = (short)424345656;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 44:
					{
						global::System.Windows.Data.CollectionView collectionView7;
						collectionView7.MoveCurrentToLast();
						num = (short)1835466810;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 45:
						goto IL_449;
					case 46:
					{
						global::System.Windows.Data.CollectionView collectionView6;
						collectionView6.MoveCurrentToLast();
						num = (short)1058734088;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 47:
					{
						global::System.Windows.Data.CollectionView collectionView3;
						collectionView3.MoveCurrentToLast();
						num = (short)1283522636;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 48:
						goto IL_449;
					case 49:
						num = (short)222363734;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 50:
					{
						object myRecordsetDataSource7;
						global::System.Windows.Data.CollectionView collectionView3 = (global::System.Windows.Data.CollectionView)global::System.Windows.Data.CollectionViewSource.GetDefaultView(myRecordsetDataSource7);
						global::Motorola.MackinawCPS.CoreFeatures.TrunkingSystem.ASTRO25ChannelIDInner astro25ChannelIDInner = (global::Motorola.MackinawCPS.CoreFeatures.TrunkingSystem.ASTRO25ChannelIDInner)collectionView3.CurrentItem;
						num = (short)242548838;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 51:
					{
						global::System.Windows.Data.CollectionView collectionView5;
						if (collectionView5.IsCurrentAfterLast)
						{
							num = (short)893124669;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						collectionView5.MoveCurrentToFirst();
						num = (short)1523646476;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 52:
					{
						((global::AcpUI.AcpRecNavToolbar)A_0).TableMode = false;
						object myRecordsetDataSource7 = this.RecNavToolbarExpanderTrunkingSystemASTRO25ChannelIDTable.MyRecordsetDataSource;
						num = (short)2127888491;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 53:
					{
						object myRecordsetDataSource6;
						if (myRecordsetDataSource6 != null)
						{
							num = (short)1568210987;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_EF0;
					}
					case 54:
						num = (short)257032267;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 55:
						goto IL_1035;
					case 56:
					{
						global::Motorola.MackinawCPS.CoreFeatures.TrunkingSystem.StatusAliasInner statusAliasInner;
						if (statusAliasInner != null)
						{
							num = (short)1039990798;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)1170538611;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 57:
					{
						global::System.Windows.Data.CollectionView collectionView3;
						if (collectionView3.IsCurrentAfterLast)
						{
							num = (short)1822687279;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						collectionView3.MoveCurrentToFirst();
						num = (short)125173866;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 58:
						goto IL_112E;
					case 59:
						num = (short)674889766;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 60:
					{
						global::System.Windows.Data.CollectionView collectionView5;
						global::Motorola.MackinawCPS.CoreFeatures.TrunkingSystem.ChannelRangesMHzInner channelRangesMHzInner;
						collectionView5.MoveCurrentTo(channelRangesMHzInner);
						num = (short)1872887903;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 61:
					{
						global::System.Windows.Data.CollectionView collectionView5;
						collectionView5.MoveCurrentToLast();
						num = (short)829423716;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 62:
						goto IL_1035;
					case 63:
						if (((global::AcpUI.AcpRecNavToolbar)A_0).TableMode)
						{
							num = (short)2138046542;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						((global::AcpUI.AcpRecNavToolbar)A_0).TableMode = true;
						num = (short)136118320;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 64:
						switch (0)
						{
						case 0:
							goto IL_242;
						}
						continue;
					case 65:
						goto IL_7E8;
					case 66:
					{
						num = (short)935198721;
						if (num != 0)
						{
						}
						object myRecordsetDataSource8;
						global::System.Windows.Data.CollectionView collectionView6 = (global::System.Windows.Data.CollectionView)global::System.Windows.Data.CollectionViewSource.GetDefaultView(myRecordsetDataSource8);
						global::Motorola.MackinawCPS.CoreFeatures.TrunkingSystem.MessageAliasInner messageAliasInner = (global::Motorola.MackinawCPS.CoreFeatures.TrunkingSystem.MessageAliasInner)collectionView6.CurrentItem;
						goto IL_8E9;
					}
					case 67:
					{
						((global::AcpUI.AcpRecNavToolbar)A_0).TableMode = false;
						object myRecordsetDataSource4 = this.RecNavToolbarExpanderTrunkingSystemChannelRangesMHz.MyRecordsetDataSource;
						num = (short)7471121;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 68:
						if (((global::AcpUI.AcpRecNavToolbar)A_0).TableMode)
						{
							num = (short)1242103878;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						((global::AcpUI.AcpRecNavToolbar)A_0).TableMode = true;
						num = (short)75759733;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 69:
						if (((global::AcpUI.AcpRecNavToolbar)A_0).TableMode)
						{
							num = (short)1326317652;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						((global::AcpUI.AcpRecNavToolbar)A_0).TableMode = true;
						num = (short)476381282;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 70:
					{
						((global::AcpUI.AcpRecNavToolbar)A_0).TableMode = false;
						object myRecordsetDataSource5 = this.RecNavToolbarExpanderTrunkingSystemOneTouchTable.MyRecordsetDataSource;
						num = (short)1705639963;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 71:
						num = (short)929038404;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 72:
						goto IL_7E8;
					case 73:
					{
						num = (short)1279508468;
						short num4 = num;
						num = (short)1251196916;
						switch ((num4 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_8E9;
						default:
						{
							num = (short)2003894272;
							if (num != 0)
							{
							}
							((global::AcpUI.AcpRecNavToolbar)A_0).TableMode = false;
							object myRecordsetDataSource8 = this.RecNavToolbarExpanderTrunkingSystemMessageAliasTable.MyRecordsetDataSource;
							num = (short)143851609;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						}
						break;
					}
					case 74:
						if (((global::AcpUI.AcpRecNavToolbar)A_0).Name == global::AllFeatures.CodeplugGuid.b("雃ꏅꯇ蓉귋룍蓏뷑믓뫕뫗믙껛軝臟藡臣닥髧鿩苫藭駯鳱鏳ꗵ臷觹裻鯽淿", a_))
						{
							num = (short)1255800924;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_1322;
					case 75:
						if (((global::AcpUI.AcpRecNavToolbar)A_0).TableMode)
						{
							num = (short)698875981;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						((global::AcpUI.AcpRecNavToolbar)A_0).TableMode = true;
						num = (short)547160143;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 76:
						goto IL_4AF;
					case 77:
					{
						((global::AcpUI.AcpRecNavToolbar)A_0).TableMode = false;
						object myRecordsetDataSource2 = this.RecNavToolbarExpanderTrunkingSystemControlChannelsTable.MyRecordsetDataSource;
						num = (short)649068577;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 78:
					{
						((global::AcpUI.AcpRecNavToolbar)A_0).TableMode = false;
						object myRecordsetDataSource3 = this.RecNavToolbarExpanderTrunkingSystemSiteAliasTable.MyRecordsetDataSource;
						num = (short)1279918086;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 79:
						goto IL_6EE;
					case 80:
						num = (short)1522597969;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 81:
						if (((global::AcpUI.AcpRecNavToolbar)A_0).TableMode)
						{
							num = (short)985661492;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						((global::AcpUI.AcpRecNavToolbar)A_0).TableMode = true;
						num = (short)148176951;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 82:
						goto IL_26A;
					case 83:
					{
						global::System.Windows.Data.CollectionView collectionView;
						if (collectionView.Count > 0)
						{
							num = (short)1942487099;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_7E8;
					}
					case 84:
					{
						((global::AcpUI.AcpRecNavToolbar)A_0).TableMode = false;
						object myRecordsetDataSource6 = this.RecNavToolbarExpanderTrunkingSystemStatusAliasTable.MyRecordsetDataSource;
						num = (short)2079326261;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 85:
					{
						object myRecordsetDataSource3;
						global::System.Windows.Data.CollectionView collectionView2 = (global::System.Windows.Data.CollectionView)global::System.Windows.Data.CollectionViewSource.GetDefaultView(myRecordsetDataSource3);
						global::Motorola.MackinawCPS.CoreFeatures.TrunkingSystem.SiteAliasInner siteAliasInner = (global::Motorola.MackinawCPS.CoreFeatures.TrunkingSystem.SiteAliasInner)collectionView2.CurrentItem;
						num = (short)2127364133;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 86:
					{
						global::System.Windows.Data.CollectionView collectionView7;
						if (collectionView7.IsCurrentAfterLast)
						{
							num = (short)621674540;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						collectionView7.MoveCurrentToFirst();
						num = (short)648806436;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 87:
						if (((global::AcpUI.AcpRecNavToolbar)A_0).TableMode)
						{
							num = (short)1429733449;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						((global::AcpUI.AcpRecNavToolbar)A_0).TableMode = true;
						num = (short)822607874;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 88:
					{
						global::System.Windows.Data.CollectionView collectionView7;
						if (collectionView7.Count > 0)
						{
							num = (short)1062797361;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_4A3;
					}
					case 89:
					{
						object myRecordsetDataSource8;
						if (myRecordsetDataSource8 != null)
						{
							num = (short)2127298626;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_F4A;
					}
					case 90:
					{
						global::Motorola.MackinawCPS.CoreFeatures.TrunkingSystem.OneTouchInner oneTouchInner;
						if (oneTouchInner != null)
						{
							num = (short)474415207;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)2099904600;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 91:
						num = (short)585302090;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 92:
					{
						global::AcpCommonLib.IAcpRecordset myRecordsetDataSource = this.RecNavToolbarPageTrunkingSystem.MyRecordsetDataSource;
						num = (short)1815806070;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 93:
						if (((global::AcpUI.AcpRecNavToolbar)A_0).TableMode)
						{
							num = (short)1174470723;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						((global::AcpUI.AcpRecNavToolbar)A_0).TableMode = true;
						num = (short)711720995;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 94:
						num = (short)1699414103;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 95:
						goto IL_577;
					case 96:
						if (((global::AcpUI.AcpRecNavToolbar)A_0).Name == global::AllFeatures.CodeplugGuid.b("雃ꏅꯇ蓉귋룍蓏뷑믓뫕뫗믙껛鯝食鋡藣裥賧迩黫뫭苯蟱髳鷵釷铹鯻귽秿焁瀃挅攇䔉戋欍䐏紑愓甕瀗丙紛簝䰟䜡", a_))
						{
							num = (short)840302663;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return;
					case 97:
						num = (short)1464008767;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 98:
						goto IL_EF0;
					case 99:
						if (((global::AcpUI.AcpRecNavToolbar)A_0).Name == global::AllFeatures.CodeplugGuid.b("雃ꏅꯇ蓉귋룍蓏뷑믓뫕뫗믙껛鯝食鋡藣裥賧迩黫뫭苯蟱髳鷵釷铹鯻귽秿焁瀃挅攇変攋稍甏匑砓缕礗椙䠛缝䈟両䄣", a_))
						{
							num = (short)1920860257;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_449;
					case 100:
						goto IL_577;
					case 101:
						goto IL_292;
					case 102:
					{
						global::Motorola.MackinawCPS.CoreFeatures.TrunkingSystem.ASTRO25ChannelIDInner astro25ChannelIDInner;
						if (astro25ChannelIDInner != null)
						{
							num = (short)503054347;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)1182335100;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 103:
					{
						global::System.Windows.Data.CollectionView collectionView7;
						global::Motorola.MackinawCPS.CoreFeatures.TrunkingSystem.OneTouchInner oneTouchInner;
						collectionView7.MoveCurrentTo(oneTouchInner);
						num = (short)14680071;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 104:
						num = (short)946339933;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 105:
						goto IL_C3B;
					case 106:
						goto IL_4AF;
					case 107:
					{
						object myRecordsetDataSource7;
						if (myRecordsetDataSource7 != null)
						{
							num = (short)1611268146;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_1035;
					}
					case 108:
					{
						global::System.Windows.Data.CollectionView collectionView2;
						if (collectionView2.IsCurrentAfterLast)
						{
							num = (short)890241047;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						collectionView2.MoveCurrentToFirst();
						num = (short)1651638281;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 109:
					{
						global::System.Windows.Data.CollectionView collectionView4;
						collectionView4.MoveCurrentToLast();
						num = (short)66912271;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 110:
						num = (short)1839923251;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 111:
						goto IL_292;
					case 112:
						goto IL_4AF;
					case 113:
						num = (short)2073427992;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 114:
						goto IL_7E8;
					case 115:
					{
						global::System.Windows.Data.CollectionView collectionView4;
						if (collectionView4.Count > 0)
						{
							num = (short)1246167040;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_26A;
					}
					case 116:
					{
						global::System.Windows.Data.CollectionView collectionView6;
						if (collectionView6.Count > 0)
						{
							num = (short)1530134641;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_292;
					}
					case 117:
						return;
					case 118:
					{
						global::AcpCommonLib.IAcpRecordset myRecordsetDataSource;
						if (myRecordsetDataSource != null)
						{
							num = (short)694484996;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_1322;
					}
					case 119:
					{
						global::System.Windows.Data.CollectionView collectionView2;
						if (collectionView2.Count > 0)
						{
							num = (short)646053918;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_D33;
					}
					case 120:
					{
						global::Motorola.MackinawCPS.CoreFeatures.TrunkingSystem.MessageAliasInner messageAliasInner;
						if (messageAliasInner != null)
						{
							num = (short)1133183005;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)1719795828;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 121:
					{
						global::System.Windows.Data.CollectionView collectionView;
						global::Motorola.MackinawCPS.CoreFeatures.TrunkingSystem.ControlChannelsInner controlChannelsInner;
						collectionView.MoveCurrentTo(controlChannelsInner);
						num = (short)766902337;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 122:
						num = (short)88277049;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 123:
					{
						global::System.Windows.Data.CollectionView collectionView;
						collectionView.MoveCurrentToLast();
						num = (short)1328611400;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 124:
					{
						global::System.Windows.Data.CollectionView collectionView3;
						if (collectionView3.Count > 0)
						{
							num = (short)1910767738;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_4AF;
					}
					}
					IL_242:
					if (A_0 is global::AcpUI.AcpRecNavToolbar)
					{
						num = (short)1138229339;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					return;
					IL_26A:
					((global::AcpUI.AcpRecNavToolbar)A_0).SyncDataSources();
					num = (short)1312096269;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_292:
					((global::AcpUI.AcpRecNavToolbar)A_0).SyncDataSources();
					num = (short)1480458261;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_449:
					num = (short)445055072;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_4AF:
					((global::AcpUI.AcpRecNavToolbar)A_0).SyncDataSources();
					num = (short)911736894;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_577:
					((global::AcpUI.AcpRecNavToolbar)A_0).SyncDataSources();
					num = (short)1862795369;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_6EE:
					num = (short)1247477763;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_7E8:
					((global::AcpUI.AcpRecNavToolbar)A_0).SyncDataSources();
					num = (short)947191849;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_8E9:
					num = (short)482869368;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_C3B:
					num = (short)939720722;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_D33:
					((global::AcpUI.AcpRecNavToolbar)A_0).SyncDataSources();
					num = (short)1371602989;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_EF0:
					num = (short)1119027299;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_F4A:
					num = (short)778633235;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_1035:
					num = (short)355926032;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_1322:
					num = (short)1804337183;
					num2 = (int)((global::System.IntPtr)num);
				}
				IL_4A3:
				((global::AcpUI.AcpRecNavToolbar)A_0).SyncDataSources();
				return;
				IL_DE9:
				IL_112E:
				IL_154E:
				goto IL_4A3;
			}
			}
		}

		// Token: 0x06001520 RID: 5408 RVA: 0x0013C3C0 File Offset: 0x0013A5C0
		private void HLinkClick(object A_0, global::System.Windows.RoutedEventArgs A_1)
		{
			short num = (short)1069907225;
			short num2 = num;
			num = (short)111115545;
			switch (num2 == num)
			{
			}
			num = (short)1493893121;
			if (num != 0)
			{
			}
			num = (short)1932591104;
			if (num != 0)
			{
			}
			num = (short)1387331584;
			short num3 = num;
			base.OnHLinkClick(A_0);
		}

		// Token: 0x06001521 RID: 5409 RVA: 0x0013C470 File Offset: 0x0013A670
		private void OnFieldNameDoubleClick(object A_0, global::System.Windows.RoutedEventArgs A_1)
		{
			short num = (short)1177354241;
			if (num != 0)
			{
			}
			num = (short)1782736466;
			short num2 = num;
			num = (short)1597466194;
			switch (num2 == num)
			{
			}
			num = (short)2065956864;
			if (num != 0)
			{
			}
			num = (short)2044985344;
			short num3 = num;
			global::AcpUI.Common.Utility.GetFieldHelpText(A_0);
		}

		// Token: 0x06001522 RID: 5410 RVA: 0x0013C520 File Offset: 0x0013A720
		internal void OnExpanderTrunkingSystemChannelRangesMHzClick(object sender, global::System.Windows.RoutedEventArgs e)
		{
			switch (0)
			{
			case 0:
				goto IL_8F;
			}
			short num;
			int num3;
			object myRecordsetDataSource;
			global::Motorola.MackinawCPS.CoreFeatures.TrunkingSystem.ChannelRangesMHzInner item;
			for (;;)
			{
				IL_0A:
				num = (short)478838733;
				short num2 = num;
				num = (short)204177357;
				switch ((num2 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					goto IL_12A;
				default:
					num = (short)1395261441;
					if (num != 0)
					{
					}
					num = (short)1385758720;
					if (num != 0)
					{
					}
					switch (num3)
					{
					case 0:
						goto IL_128;
					case 1:
						((global::System.Windows.Data.CollectionView)global::System.Windows.Data.CollectionViewSource.GetDefaultView(myRecordsetDataSource)).MoveCurrentTo(item);
						this.RecNavToolbarExpanderTrunkingSystemChannelRangesMHz.SyncDataSources();
						num = (short)574685184;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					case 2:
						if (myRecordsetDataSource != null)
						{
							num = (short)874905601;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_12A;
					}
					goto IL_8F;
				}
			}
			IL_128:
			IL_12A:
			num = (short)449445888;
			short num4 = num;
			this.RecNavToolbarExpanderTrunkingSystemChannelRangesMHz.TableMode = false;
			return;
			IL_8F:
			item = (global::Motorola.MackinawCPS.CoreFeatures.TrunkingSystem.ChannelRangesMHzInner)((global::Infragistics.Windows.DataPresenter.CellValuePresenter)((global::AcpUI.AcpButton)e.Source).TemplatedParent).Record.DataItem;
			myRecordsetDataSource = this.RecNavToolbarExpanderTrunkingSystemChannelRangesMHz.MyRecordsetDataSource;
			num = (short)2020278274;
			num3 = (int)((global::System.IntPtr)num);
			goto IL_0A;
		}

		// Token: 0x06001523 RID: 5411 RVA: 0x0013C68C File Offset: 0x0013A88C
		internal void OnExpanderTrunkingSystemControlChannelsTableClick(object sender, global::System.Windows.RoutedEventArgs e)
		{
			short num = (short)900595713;
			if (num != 0)
			{
			}
			switch (0)
			{
			case 0:
				goto IL_8E;
			}
			int num3;
			object myRecordsetDataSource;
			global::Motorola.MackinawCPS.CoreFeatures.TrunkingSystem.ControlChannelsInner item;
			for (;;)
			{
				IL_32:
				num = (short)355895618;
				short num2 = num;
				num = (short)1712425282;
				switch ((num2 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					goto IL_12A;
				default:
					num = (short)1493630976;
					if (num != 0)
					{
					}
					switch (num3)
					{
					case 0:
						goto IL_128;
					case 1:
						((global::System.Windows.Data.CollectionView)global::System.Windows.Data.CollectionViewSource.GetDefaultView(myRecordsetDataSource)).MoveCurrentTo(item);
						this.RecNavToolbarExpanderTrunkingSystemControlChannelsTable.SyncDataSources();
						num = (short)1686241280;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					case 2:
						if (myRecordsetDataSource != null)
						{
							num = (short)1286144001;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_12A;
					}
					goto IL_8E;
				}
			}
			IL_128:
			IL_12A:
			num = (short)1030029312;
			short num4 = num;
			this.RecNavToolbarExpanderTrunkingSystemControlChannelsTable.TableMode = false;
			return;
			IL_8E:
			item = (global::Motorola.MackinawCPS.CoreFeatures.TrunkingSystem.ControlChannelsInner)((global::Infragistics.Windows.DataPresenter.CellValuePresenter)((global::AcpUI.AcpButton)e.Source).TemplatedParent).Record.DataItem;
			myRecordsetDataSource = this.RecNavToolbarExpanderTrunkingSystemControlChannelsTable.MyRecordsetDataSource;
			num = (short)179372034;
			num3 = (int)((global::System.IntPtr)num);
			goto IL_32;
		}

		// Token: 0x06001524 RID: 5412 RVA: 0x0013C7F8 File Offset: 0x0013A9F8
		internal void OnExpanderTrunkingSystemASTRO25ChannelIDTableClick(object sender, global::System.Windows.RoutedEventArgs e)
		{
			switch (0)
			{
			case 0:
				goto IL_8E;
			}
			short num;
			int num3;
			object myRecordsetDataSource;
			global::Motorola.MackinawCPS.CoreFeatures.TrunkingSystem.ASTRO25ChannelIDInner item;
			for (;;)
			{
				IL_0A:
				num = (short)2022589142;
				short num2 = num;
				num = (short)451298006;
				switch ((num2 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					goto IL_12A;
				default:
					num = (short)807862273;
					if (num != 0)
					{
					}
					num = (short)930021376;
					if (num != 0)
					{
					}
					switch (num3)
					{
					case 0:
						goto IL_128;
					case 1:
						((global::System.Windows.Data.CollectionView)global::System.Windows.Data.CollectionViewSource.GetDefaultView(myRecordsetDataSource)).MoveCurrentTo(item);
						this.RecNavToolbarExpanderTrunkingSystemASTRO25ChannelIDTable.SyncDataSources();
						num = (short)1716060160;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					case 2:
						if (myRecordsetDataSource != null)
						{
							num = (short)841678849;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_12A;
					}
					goto IL_8E;
				}
			}
			IL_128:
			IL_12A:
			num = (short)648675328;
			short num4 = num;
			this.RecNavToolbarExpanderTrunkingSystemASTRO25ChannelIDTable.TableMode = false;
			return;
			IL_8E:
			item = (global::Motorola.MackinawCPS.CoreFeatures.TrunkingSystem.ASTRO25ChannelIDInner)((global::Infragistics.Windows.DataPresenter.CellValuePresenter)((global::AcpUI.AcpButton)e.Source).TemplatedParent).Record.DataItem;
			myRecordsetDataSource = this.RecNavToolbarExpanderTrunkingSystemASTRO25ChannelIDTable.MyRecordsetDataSource;
			num = (short)233897986;
			num3 = (int)((global::System.IntPtr)num);
			goto IL_0A;
		}

		// Token: 0x06001525 RID: 5413 RVA: 0x0013C968 File Offset: 0x0013AB68
		internal void OnExpanderTrunkingSystemMessageAliasTableClick(object sender, global::System.Windows.RoutedEventArgs e)
		{
			switch (0)
			{
			case 0:
				goto IL_65;
			}
			short num;
			int num3;
			object myRecordsetDataSource;
			global::Motorola.MackinawCPS.CoreFeatures.TrunkingSystem.MessageAliasInner item;
			for (;;)
			{
				IL_0A:
				num = (short)1815665885;
				short num2 = num;
				num = (short)824827101;
				switch ((num2 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					goto IL_129;
				default:
					num = (short)1638072320;
					if (num != 0)
					{
					}
					switch (num3)
					{
					case 0:
						goto IL_127;
					case 1:
						num = (short)1892155393;
						if (num != 0)
						{
						}
						((global::System.Windows.Data.CollectionView)global::System.Windows.Data.CollectionViewSource.GetDefaultView(myRecordsetDataSource)).MoveCurrentTo(item);
						this.RecNavToolbarExpanderTrunkingSystemMessageAliasTable.SyncDataSources();
						num = (short)1497563136;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					case 2:
						if (myRecordsetDataSource != null)
						{
							num = (short)466878465;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_129;
					}
					goto IL_65;
				}
			}
			IL_127:
			IL_129:
			num = (short)681836544;
			short num4 = num;
			this.RecNavToolbarExpanderTrunkingSystemMessageAliasTable.TableMode = false;
			return;
			IL_65:
			item = (global::Motorola.MackinawCPS.CoreFeatures.TrunkingSystem.MessageAliasInner)((global::Infragistics.Windows.DataPresenter.CellValuePresenter)((global::AcpUI.AcpButton)e.Source).TemplatedParent).Record.DataItem;
			myRecordsetDataSource = this.RecNavToolbarExpanderTrunkingSystemMessageAliasTable.MyRecordsetDataSource;
			num = (short)1584726018;
			num3 = (int)((global::System.IntPtr)num);
			goto IL_0A;
		}

		// Token: 0x06001526 RID: 5414 RVA: 0x0013CAD8 File Offset: 0x0013ACD8
		internal void OnExpanderTrunkingSystemStatusAliasTableClick(object sender, global::System.Windows.RoutedEventArgs e)
		{
			switch (0)
			{
			case 0:
				goto IL_68;
			}
			short num;
			int num3;
			object myRecordsetDataSource;
			global::Motorola.MackinawCPS.CoreFeatures.TrunkingSystem.StatusAliasInner item;
			for (;;)
			{
				IL_0A:
				num = (short)652100694;
				short num2 = num;
				num = (short)573981782;
				switch ((num2 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					goto IL_12A;
				default:
					num = (short)1747058688;
					if (num != 0)
					{
					}
					switch (num3)
					{
					case 0:
						goto IL_128;
					case 1:
						((global::System.Windows.Data.CollectionView)global::System.Windows.Data.CollectionViewSource.GetDefaultView(myRecordsetDataSource)).MoveCurrentTo(item);
						this.RecNavToolbarExpanderTrunkingSystemStatusAliasTable.SyncDataSources();
						num = (short)687865857;
						if (num != 0)
						{
						}
						num = (short)468975616;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					case 2:
						if (myRecordsetDataSource != null)
						{
							num = (short)649265153;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_12A;
					}
					goto IL_68;
				}
			}
			IL_128:
			IL_12A:
			num = (short)1849360384;
			short num4 = num;
			this.RecNavToolbarExpanderTrunkingSystemStatusAliasTable.TableMode = false;
			return;
			IL_68:
			item = (global::Motorola.MackinawCPS.CoreFeatures.TrunkingSystem.StatusAliasInner)((global::Infragistics.Windows.DataPresenter.CellValuePresenter)((global::AcpUI.AcpButton)e.Source).TemplatedParent).Record.DataItem;
			myRecordsetDataSource = this.RecNavToolbarExpanderTrunkingSystemStatusAliasTable.MyRecordsetDataSource;
			num = (short)1628438530;
			num3 = (int)((global::System.IntPtr)num);
			goto IL_0A;
		}

		// Token: 0x06001527 RID: 5415 RVA: 0x0013CC44 File Offset: 0x0013AE44
		internal void OnExpanderTrunkingSystemSiteAliasTableClick(object sender, global::System.Windows.RoutedEventArgs e)
		{
			switch (0)
			{
			case 0:
				goto IL_8D;
			}
			short num;
			int num3;
			object myRecordsetDataSource;
			global::Motorola.MackinawCPS.CoreFeatures.TrunkingSystem.SiteAliasInner item;
			for (;;)
			{
				IL_0A:
				num = (short)207025707;
				short num2 = num;
				num = (short)1549923883;
				switch ((num2 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					goto IL_12A;
				default:
					num = (short)1353056256;
					if (num != 0)
					{
					}
					num = (short)1582497793;
					if (num != 0)
					{
					}
					switch (num3)
					{
					case 0:
						goto IL_128;
					case 1:
						((global::System.Windows.Data.CollectionView)global::System.Windows.Data.CollectionViewSource.GetDefaultView(myRecordsetDataSource)).MoveCurrentTo(item);
						this.RecNavToolbarExpanderTrunkingSystemSiteAliasTable.SyncDataSources();
						num = (short)94175232;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					case 2:
						if (myRecordsetDataSource != null)
						{
							num = (short)2115305473;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_12A;
					}
					goto IL_8D;
				}
			}
			IL_128:
			IL_12A:
			num = (short)882769920;
			short num4 = num;
			this.RecNavToolbarExpanderTrunkingSystemSiteAliasTable.TableMode = false;
			return;
			IL_8D:
			item = (global::Motorola.MackinawCPS.CoreFeatures.TrunkingSystem.SiteAliasInner)((global::Infragistics.Windows.DataPresenter.CellValuePresenter)((global::AcpUI.AcpButton)e.Source).TemplatedParent).Record.DataItem;
			myRecordsetDataSource = this.RecNavToolbarExpanderTrunkingSystemSiteAliasTable.MyRecordsetDataSource;
			num = (short)2137718786;
			num3 = (int)((global::System.IntPtr)num);
			goto IL_0A;
		}

		// Token: 0x06001528 RID: 5416 RVA: 0x0013CDB4 File Offset: 0x0013AFB4
		internal void OnExpanderTrunkingSystemOneTouchTableClick(object sender, global::System.Windows.RoutedEventArgs e)
		{
			switch (0)
			{
			case 0:
				goto IL_67;
			}
			short num;
			int num3;
			object myRecordsetDataSource;
			global::Motorola.MackinawCPS.CoreFeatures.TrunkingSystem.OneTouchInner item;
			for (;;)
			{
				IL_0A:
				num = (short)1503838605;
				short num2 = num;
				num = (short)196985229;
				switch ((num2 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					goto IL_129;
				default:
					num = (short)1344929792;
					if (num != 0)
					{
					}
					switch (num3)
					{
					case 0:
						goto IL_127;
					case 1:
						num = (short)1704722433;
						if (num != 0)
						{
						}
						((global::System.Windows.Data.CollectionView)global::System.Windows.Data.CollectionViewSource.GetDefaultView(myRecordsetDataSource)).MoveCurrentTo(item);
						this.RecNavToolbarExpanderTrunkingSystemOneTouchTable.SyncDataSources();
						num = (short)76939264;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					case 2:
						if (myRecordsetDataSource != null)
						{
							num = (short)1400438785;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_129;
					}
					goto IL_67;
				}
			}
			IL_127:
			IL_129:
			num = (short)1382023168;
			short num4 = num;
			this.RecNavToolbarExpanderTrunkingSystemOneTouchTable.TableMode = false;
			return;
			IL_67:
			item = (global::Motorola.MackinawCPS.CoreFeatures.TrunkingSystem.OneTouchInner)((global::Infragistics.Windows.DataPresenter.CellValuePresenter)((global::AcpUI.AcpButton)e.Source).TemplatedParent).Record.DataItem;
			myRecordsetDataSource = this.RecNavToolbarExpanderTrunkingSystemOneTouchTable.MyRecordsetDataSource;
			num = (short)134152194;
			num3 = (int)((global::System.IntPtr)num);
			goto IL_0A;
		}

		// Token: 0x06001529 RID: 5417 RVA: 0x0013CF20 File Offset: 0x0013B120
		[global::System.CodeDom.Compiler.GeneratedCode("PresentationBuildTasks", "5.0.10.0")]
		[global::System.Diagnostics.DebuggerNonUserCode]
		public void InitializeComponent()
		{
			int a_ = 14;
			if (!this.b)
			{
				short num = (short)1011045877;
				short num2 = num;
				num = (short)1353930229;
				switch ((num2 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					break;
				default:
				{
					num = (short)962592768;
					if (num != 0)
					{
					}
					num = (short)1250164736;
					short num3 = num;
					num = (short)279576577;
					if (num != 0)
					{
					}
					this.b = true;
					global::System.Uri resourceLocator = new global::System.Uri(global::AllFeatures.CodeplugGuid.b("郐뿒맔釖볘뫚꧜꫞鏠蛢雤\udce6諨蓪胬鿮黰鷲郴駶跸퓺觼跾琀洂渄渆月氊⠌㴎ℐ瀒稔礖缘爚稜樞匠䈢儤並䘨䔪Ȭ嬮䌰䘲嬴尶倸唺娼ᨾ獀獂㙄㹆㩈㽊⡌≎繐❒❔≖㝘ず㑜ㅞ٠ၢᱤᑦᵨ๪l䅮॰ቲᡴ᭶", a_), global::System.UriKind.Relative);
					global::System.Windows.Application.LoadComponent(this, resourceLocator);
					return;
				}
				}
			}
		}

		// Token: 0x0600152A RID: 5418 RVA: 0x0013D000 File Offset: 0x0013B200
		[global::System.Diagnostics.DebuggerNonUserCode]
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		[global::System.CodeDom.Compiler.GeneratedCode("PresentationBuildTasks", "5.0.10.0")]
		void global::System.Windows.Markup.IComponentConnector.Connect(int connectionId, object target)
		{
			short num = (short)658833410;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				switch (num2)
				{
				case 0:
					goto IL_3CC8;
				case 1:
					num = (short)1433468928;
					num2 = (int)((global::System.IntPtr)num);
					continue;
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
					goto IL_4AA2;
				case 2:
					goto IL_16CA;
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
					goto IL_5DA0;
				case 40:
					goto IL_1D53;
				case 41:
					goto IL_16A6;
				case 42:
					goto IL_4143;
				case 43:
					goto IL_1176;
				case 44:
					goto IL_469B;
				case 45:
					goto IL_5CA1;
				case 46:
					goto IL_5842;
				case 47:
					goto IL_4EC9;
				case 48:
					goto IL_2838;
				case 49:
					goto IL_5621;
				case 50:
					goto IL_5B4B;
				case 51:
					goto IL_458F;
				case 52:
					goto IL_5CF6;
				case 53:
					goto IL_48F7;
				case 54:
					goto IL_4CD0;
				case 55:
					goto IL_26E8;
				case 56:
					goto IL_1387;
				case 57:
					goto IL_393D;
				case 58:
					goto IL_26C1;
				case 59:
					goto IL_2C66;
				case 60:
					goto IL_1FD9;
				case 61:
					goto IL_5410;
				case 62:
					goto IL_4506;
				case 63:
					goto IL_44DF;
				case 64:
					goto IL_15D5;
				case 65:
					goto IL_55FD;
				case 66:
					goto IL_12FE;
				case 67:
					goto IL_3ACE;
				case 68:
					goto IL_274A;
				case 69:
					goto IL_4EA2;
				case 70:
					goto IL_23FB;
				case 71:
					goto IL_20D8;
				case 72:
					goto IL_59DD;
				case 73:
					goto IL_57A2;
				case 74:
					goto IL_4E30;
				case 75:
					goto IL_21C6;
				case 76:
					goto IL_447D;
				case 77:
					goto IL_18C7;
				case 78:
					goto IL_4E71;
				case 79:
					goto IL_5C39;
				case 80:
					goto IL_4AF7;
				case 81:
					goto IL_297B;
				case 82:
					goto IL_2DB6;
				case 83:
					goto IL_5009;
				case 84:
					goto IL_2676;
				case 85:
					goto IL_1BB2;
				case 86:
					goto IL_32FC;
				case 87:
					goto IL_4BEF;
				case 88:
					goto IL_502D;
				case 89:
					goto IL_4089;
				case 90:
					goto IL_3C66;
				case 91:
					goto IL_19A8;
				case 92:
					goto IL_4DAE;
				case 93:
					goto IL_45B3;
				case 94:
					goto IL_40F8;
				case 95:
					goto IL_285C;
				case 96:
					goto IL_1EB0;
				case 97:
					goto IL_4105;
				case 98:
					goto IL_2B30;
				case 99:
					goto IL_509F;
				case 100:
					goto IL_39D6;
				case 101:
					goto IL_3AF5;
				case 102:
					goto IL_301B;
				case 103:
					goto IL_321E;
				case 104:
					goto IL_3CE7;
				case 105:
					goto IL_4F2E;
				case 106:
					goto IL_3A21;
				case 107:
					goto IL_2DF7;
				case 108:
					goto IL_4520;
				case 109:
					goto IL_27AF;
				case 110:
					goto IL_13DF;
				case 111:
					goto IL_4A95;
				case 112:
					goto IL_4DD5;
				case 113:
					goto IL_3DD2;
				case 114:
					goto IL_1943;
				case 115:
					goto IL_2242;
				case 116:
					goto IL_2CBE;
				case 117:
					goto IL_34F9;
				case 118:
					goto IL_19B5;
				case 119:
					goto IL_208D;
				case 120:
					goto IL_511E;
				case 121:
					goto IL_3EFB;
				case 122:
					goto IL_3C18;
				case 123:
					goto IL_316B;
				case 124:
					goto IL_4167;
				case 125:
					goto IL_1D84;
				case 126:
					goto IL_4C16;
				case 127:
					goto IL_55A5;
				case 128:
					goto IL_5BDE;
				case 129:
					goto IL_49E5;
				case 130:
					goto IL_5332;
				case 131:
					goto IL_3890;
				case 132:
					goto IL_2AB1;
				case 133:
					goto IL_2757;
				case 134:
					goto IL_5A56;
				case 135:
					goto IL_1BD9;
				case 136:
					goto IL_44EC;
				case 137:
					goto IL_5D7C;
				case 138:
					goto IL_2A59;
				case 139:
					goto IL_41F0;
				case 140:
					goto IL_33AC;
				case 141:
					goto IL_426F;
				case 142:
					goto IL_15BB;
				case 143:
					goto IL_4B73;
				case 144:
					goto IL_5A63;
				case 145:
					goto IL_1C96;
				case 146:
					goto IL_319F;
				case 147:
					goto IL_5085;
				case 148:
					goto IL_1BF3;
				case 149:
					goto IL_436A;
				case 150:
					goto IL_46BF;
				case 151:
					goto IL_329A;
				case 152:
					goto IL_4174;
				case 153:
					goto IL_5278;
				case 154:
					goto IL_4966;
				case 155:
					goto IL_41FD;
				case 156:
					goto IL_3BD0;
				case 157:
					goto IL_4BFC;
				case 158:
					goto IL_2BAC;
				case 159:
					goto IL_2F3A;
				case 160:
					goto IL_2E73;
				case 161:
					goto IL_44AE;
				case 162:
					goto IL_23D7;
				case 163:
					goto IL_2B7B;
				case 164:
					goto IL_352D;
				case 165:
					goto IL_5B24;
				case 166:
					goto IL_4EFA;
				case 167:
					goto IL_3B4A;
				case 168:
					goto IL_108A;
				case 169:
					goto IL_4A57;
				case 170:
					goto IL_1DDC;
				case 171:
					goto IL_15E2;
				case 172:
					goto IL_19C2;
				case 173:
					goto IL_2045;
				case 174:
					goto IL_5C46;
				case 175:
					goto IL_1E4B;
				case 176:
					goto IL_5795;
				case 177:
					goto IL_1746;
				case 178:
					goto IL_339F;
				case 179:
					goto IL_1B8B;
				case 180:
					goto IL_15C8;
				case 181:
					goto IL_38B4;
				case 182:
					goto IL_3C3F;
				case 183:
					goto IL_14A9;
				case 184:
					goto IL_3E03;
				case 185:
					goto IL_3811;
				case 186:
					goto IL_3971;
				case 187:
					goto IL_13C5;
				case 188:
					goto IL_1BBF;
				case 189:
					goto IL_2151;
				case 190:
					goto IL_50AC;
				case 191:
					goto IL_54FB;
				case 192:
					goto IL_2574;
				case 193:
					goto IL_11BE;
				case 194:
					goto IL_13EC;
				case 195:
					goto IL_4E16;
				case 196:
					goto IL_5A87;
				case 197:
					goto IL_57AF;
				case 198:
					goto IL_571C;
				case 199:
					goto IL_5ACF;
				case 200:
					goto IL_137A;
				case 201:
					goto IL_2A4C;
				case 202:
					goto IL_1E58;
				case 203:
					goto IL_324F;
				case 204:
					goto IL_4FE5;
				case 205:
					goto IL_2DEA;
				case 206:
					goto IL_570F;
				case 207:
					goto IL_59A9;
				case 208:
					goto IL_5D58;
				case 209:
					goto IL_1C58;
				case 210:
					goto IL_3720;
				case 211:
					goto IL_2F9C;
				case 212:
					goto IL_37EA;
				case 213:
					goto IL_145E;
				case 214:
					goto IL_2FDD;
				case 215:
					goto IL_1D39;
				case 216:
					goto IL_4F5F;
				case 217:
					goto IL_3957;
				case 218:
					goto IL_27ED;
				case 219:
					goto IL_4D18;
				case 220:
					goto IL_3D6D;
				case 221:
					goto IL_3EA3;
				case 222:
					goto IL_3113;
				case 223:
					goto IL_4DFC;
				case 224:
					goto IL_3CDA;
				case 225:
					goto IL_2621;
				case 226:
					goto IL_551F;
				case 227:
					goto IL_303F;
				case 228:
					goto IL_119A;
				case 229:
					goto IL_2E1B;
				case 230:
					goto IL_3CCD;
				case 231:
					goto IL_3E65;
				case 232:
					goto IL_363F;
				case 233:
					goto IL_293A;
				case 234:
					goto IL_470A;
				case 235:
					goto IL_1BCC;
				case 236:
					goto IL_427C;
				case 237:
					goto IL_4575;
				case 238:
					goto IL_2368;
				case 239:
					goto IL_4D7D;
				case 240:
					goto IL_3F2F;
				case 241:
					goto IL_423B;
				case 242:
					goto IL_2DD0;
				case 243:
					goto IL_432C;
				case 244:
					goto IL_4935;
				case 245:
					goto IL_1406;
				case 246:
					goto IL_1059;
				case 247:
					goto IL_5D27;
				case 248:
					goto IL_4CA9;
				case 249:
					goto IL_1282;
				case 250:
					goto IL_5937;
				case 251:
					goto IL_4C6B;
				case 252:
					goto IL_51FC;
				case 253:
					goto IL_4D25;
				case 254:
					goto IL_58BB;
				case 255:
					goto IL_11E2;
				case 256:
					goto IL_46F0;
				case 257:
					goto IL_42BD;
				case 258:
					goto IL_46E3;
				case 259:
					goto IL_5567;
				case 260:
					goto IL_2ECB;
				case 261:
					goto IL_5370;
				case 262:
					goto IL_4262;
				case 263:
					goto IL_1E89;
				case 264:
					goto IL_5C53;
				case 265:
					goto IL_2C1B;
				case 266:
					goto IL_1597;
				case 267:
					goto IL_3A90;
				case 268:
					goto IL_2EF2;
				case 269:
					goto IL_50D3;
				case 270:
					goto IL_13B8;
				case 271:
					goto IL_2F6B;
				case 272:
					goto IL_1114;
				case 273:
					goto IL_4010;
				case 274:
					goto IL_45CD;
				case 275:
					goto IL_487B;
				case 276:
					goto IL_28B1;
				case 277:
					goto IL_379F;
				case 278:
					goto IL_12CD;
				case 279:
					goto IL_4A0C;
				case 280:
					goto IL_3876;
				case 281:
					goto IL_39E3;
				case 282:
					goto IL_1A3E;
				case 283:
					goto IL_12A9;
				case 284:
					goto IL_3106;
				case 285:
					goto IL_53A1;
				case 286:
					goto IL_255A;
				case 287:
					goto IL_1D1F;
				case 288:
					goto IL_2A1B;
				case 289:
					goto IL_3DB8;
				case 290:
					goto IL_219F;
				case 291:
					goto IL_503A;
				case 292:
					goto IL_3F22;
				case 293:
					goto IL_3CA4;
				case 294:
					goto IL_2764;
				case 295:
					goto IL_26DB;
				case 296:
					goto IL_2988;
				case 297:
					goto IL_3713;
				case 298:
					goto IL_2AA4;
				case 299:
					goto IL_36AE;
				case 300:
					goto IL_288D;
				case 301:
					goto IL_238C;
				case 302:
					goto IL_4B4F;
				case 303:
					goto IL_4449;
				case 304:
					goto IL_51A4;
				case 305:
					goto IL_1817;
				case 306:
					goto IL_2E35;
				case 307:
					goto IL_2995;
				case 308:
					goto IL_18EB;
				case 309:
					goto IL_1B7E;
				case 310:
					goto IL_1AC4;
				case 311:
					goto IL_47B4;
				case 312:
					goto IL_24CC;
				case 313:
					goto IL_30AE;
				case 314:
					goto IL_27E0;
				case 315:
					goto IL_129C;
				case 316:
					goto IL_1C31;
				case 317:
					goto IL_2536;
				case 318:
					goto IL_38C1;
				case 319:
					goto IL_344C;
				case 320:
					goto IL_17A8;
				case 321:
					goto IL_24D9;
				case 322:
					goto IL_5403;
				case 323:
					goto IL_34A1;
				case 324:
					goto IL_296E;
				case 325:
					goto IL_224F;
				case 326:
					goto IL_4A4A;
				case 327:
					goto IL_5A25;
				case 328:
					goto IL_2A8A;
				case 329:
					goto IL_33E0;
				case 330:
					goto IL_3785;
				case 331:
					goto IL_462F;
				case 332:
					goto IL_55F0;
				case 333:
					goto IL_3C8A;
				case 334:
					goto IL_2204;
				case 335:
					goto IL_2021;
				case 336:
					goto IL_4DEF;
				case 337:
					goto IL_4888;
				case 338:
					goto IL_5BEB;
				case 339:
					goto IL_3C32;
				case 340:
					goto IL_1BE6;
				case 341:
					goto IL_1275;
				case 342:
					goto IL_2529;
				case 343:
					goto IL_3E96;
				case 344:
					goto IL_246A;
				case 345:
					goto IL_52B6;
				case 346:
					goto IL_4248;
				case 347:
					goto IL_1478;
				case 348:
					goto IL_132F;
				case 349:
					goto IL_5496;
				case 350:
					goto IL_4181;
				case 351:
					goto IL_2422;
				case 352:
					goto IL_51CB;
				case 353:
					goto IL_2C01;
				case 354:
					goto IL_172C;
				case 355:
					goto IL_3C4C;
				case 356:
					goto IL_163A;
				case 357:
					goto IL_544E;
				case 358:
					goto IL_3804;
				case 359:
					goto IL_4C78;
				case 360:
					goto IL_15EF;
				case 361:
					goto IL_3FE9;
				case 362:
					goto IL_2E8D;
				case 363:
					goto IL_1FFD;
				case 364:
					goto IL_3151;
				case 365:
					goto IL_2D5E;
				case 366:
					goto IL_35D0;
				case 367:
					goto IL_2AEF;
				case 368:
					goto IL_2C8D;
				case 369:
					goto IL_2109;
				case 370:
					goto IL_26B4;
				case 371:
					goto IL_2771;
				case 372:
					goto IL_183B;
				case 373:
					goto IL_2CEF;
				case 374:
					goto IL_4677;
				case 375:
					goto IL_29F7;
				case 376:
					goto IL_36F9;
				case 377:
					goto IL_1360;
				case 378:
					goto IL_277E;
				case 379:
					goto IL_1B0F;
				case 380:
					goto IL_2273;
				case 381:
					goto IL_5574;
				case 382:
					goto IL_4456;
				case 383:
					goto IL_1974;
				case 384:
					goto IL_40DE;
				case 385:
					goto IL_26CE;
				case 386:
					goto IL_49B4;
				case 387:
					goto IL_537D;
				case 388:
					goto IL_5C12;
				case 389:
					goto IL_31EA;
				case 390:
					goto IL_14F4;
				case 391:
					goto IL_273D;
				case 392:
					goto IL_40AD;
				case 393:
					goto IL_5873;
				case 394:
					goto IL_4861;
				case 395:
					goto IL_1E31;
				case 396:
					goto IL_38F2;
				case 397:
					goto IL_1F9B;
				case 398:
					goto IL_2C73;
				case 399:
					goto IL_1FB5;
				case 400:
					goto IL_3852;
				case 401:
					goto IL_2EB1;
				case 402:
					goto IL_4F83;
				case 403:
					goto IL_3DAB;
				case 404:
					goto IL_4776;
				case 405:
					goto IL_2E42;
				case 406:
					goto IL_1AA0;
				case 407:
					goto IL_5220;
				case 408:
					goto IL_4E64;
				case 409:
					goto IL_381E;
				case 410:
					goto IL_56B7;
				case 411:
					goto IL_3204;
				case 412:
					goto IL_4544;
				case 413:
					goto IL_3547;
				case 414:
					goto IL_2D51;
				case 415:
					goto IL_5111;
				case 416:
					goto IL_599C;
				case 417:
					goto IL_1981;
				case 418:
					goto IL_43B2;
				case 419:
					goto IL_1708;
				case 420:
					goto IL_4DE2;
				case 421:
					goto IL_216B;
				case 422:
					goto IL_14E7;
				case 423:
					goto IL_55E3;
				case 424:
					goto IL_1244;
				case 425:
					goto IL_1220;
				case 426:
					goto IL_1501;
				case 427:
					goto IL_5C05;
				case 428:
					goto IL_54A3;
				case 429:
					goto IL_5B6F;
				case 430:
					goto IL_486E;
				case 431:
					goto IL_5897;
				case 432:
					goto IL_5771;
				case 433:
					goto IL_394A;
				case 434:
					goto IL_3D9E;
				case 435:
					goto IL_39BC;
				case 436:
					goto IL_41C9;
				case 437:
					goto IL_1535;
				case 438:
					goto IL_5A01;
				case 439:
					goto IL_353A;
				case 440:
					goto IL_443C;
				case 441:
					goto IL_2FC3;
				case 442:
					goto IL_3778;
				case 443:
					goto IL_4D32;
				case 444:
					goto IL_3D25;
				case 445:
					goto IL_2A28;
				case 446:
					goto IL_1B1C;
				case 447:
					goto IL_304C;
				case 448:
					goto IL_5C87;
				case 449:
					goto IL_248E;
				case 450:
					goto IL_337B;
				case 451:
					goto IL_2F16;
				case 452:
					goto IL_40D1;
				case 453:
					goto IL_5054;
				case 454:
					goto IL_16FB;
				case 455:
					goto IL_336E;
				case 456:
					goto IL_3FAB;
				case 457:
					goto IL_4653;
				case 458:
					goto IL_3A6C;
				case 459:
					goto IL_526B;
				case 460:
					goto IL_215E;
				case 461:
					goto IL_4854;
				case 462:
					goto IL_1739;
				case 463:
					goto IL_191F;
				case 464:
					goto IL_4A64;
				case 465:
					goto IL_4BD5;
				case 466:
					goto IL_269A;
				case 467:
					goto IL_4003;
				case 468:
					goto IL_258E;
				case 469:
					goto IL_4339;
				case 470:
					goto IL_2CFC;
				case 471:
					goto IL_2EBE;
				case 472:
					goto IL_1528;
				case 473:
					goto IL_59D0;
				case 474:
					goto IL_5D1A;
				case 475:
					goto IL_1ED4;
				case 476:
					goto IL_53AE;
				case 477:
					goto IL_3059;
				case 478:
					goto IL_50C6;
				case 479:
					goto IL_376B;
				case 480:
					goto IL_1C4B;
				case 481:
					goto IL_1169;
				case 482:
					goto IL_28E5;
				case 483:
					goto IL_2652;
				case 484:
					goto IL_2FB6;
				case 485:
					goto IL_20CB;
				case 486:
					goto IL_4FD8;
				case 487:
					goto IL_1322;
				case 488:
					goto IL_1CCA;
				case 489:
					goto IL_3964;
				case 490:
					goto IL_2A7D;
				case 491:
					goto IL_5543;
				case 492:
					goto IL_5CD2;
				case 493:
					goto IL_199B;
				case 494:
					goto IL_5975;
				case 495:
					goto IL_33B9;
				case 496:
					goto IL_4B42;
				case 497:
					goto IL_33D3;
				case 498:
					goto IL_390C;
				case 499:
					goto IL_2185;
				case 500:
					goto IL_3494;
				case 501:
					goto IL_3845;
				case 502:
					goto IL_39F0;
				case 503:
					goto IL_1EEE;
				case 504:
					goto IL_235B;
				case 505:
					goto IL_1EFB;
				case 506:
					goto IL_1A62;
				case 507:
					goto IL_5804;
				case 508:
					goto IL_5913;
				case 509:
					goto IL_5C2C;
				case 510:
					goto IL_2E28;
				case 511:
					goto IL_3E72;
				case 512:
					goto IL_292D;
				case 513:
					goto IL_54B0;
				case 514:
					goto IL_5669;
				case 515:
					goto IL_4F21;
				case 516:
					goto IL_49FF;
				case 517:
					goto IL_322B;
				case 518:
					goto IL_21F7;
				case 519:
					goto IL_165E;
				case 520:
					goto IL_56E8;
				case 521:
					goto IL_1B98;
				case 522:
					goto IL_40EB;
				case 523:
					goto IL_3FDC;
				case 524:
					goto IL_1DB5;
				case 525:
					goto IL_3578;
				case 526:
					goto IL_23B3;
				case 527:
					goto IL_12DA;
				case 528:
					goto IL_5811;
				case 529:
					goto IL_4E95;
				case 530:
					goto IL_52A9;
				case 531:
					goto IL_2DC3;
				case 532:
					goto IL_37C6;
				case 533:
					goto IL_5285;
				case 534:
					goto IL_4112;
				case 535:
					goto IL_3F9E;
				case 536:
					goto IL_17E6;
				case 537:
					goto IL_3706;
				case 538:
					goto IL_3D49;
				case 539:
					goto IL_1CFB;
				case 540:
					goto IL_5325;
				case 541:
					goto IL_54D4;
				case 542:
					goto IL_25E3;
				case 543:
					goto IL_5866;
				case 544:
					goto IL_278B;
				case 545:
					goto IL_55BF;
				case 546:
					goto IL_2235;
				case 547:
					goto IL_1A24;
				case 548:
					goto IL_30D2;
				case 549:
					goto IL_45F1;
				case 550:
					goto IL_21D3;
				case 551:
					goto IL_438E;
				case 552:
					goto IL_595B;
				case 553:
					goto IL_5BA0;
				case 554:
					goto IL_150E;
				case 555:
					goto IL_41D6;
				case 556:
					goto IL_2297;
				case 557:
					goto IL_25FD;
				case 558:
					goto IL_249B;
				case 559:
					goto IL_1912;
				case 560:
					goto IL_5173;
				case 561:
					goto IL_3506;
				case 562:
					goto IL_259B;
				case 563:
					goto IL_16EE;
				case 564:
					goto IL_300E;
				case 565:
					goto IL_5A32;
				case 566:
					goto IL_1485;
				case 567:
					goto IL_2415;
				case 568:
					goto IL_55B2;
				case 569:
					goto IL_2DA9;
				case 570:
					goto IL_58E2;
				case 571:
					goto IL_4E3D;
				case 572:
					goto IL_48C6;
				case 573:
					goto IL_3DC5;
				case 574:
					goto IL_2947;
				case 575:
					goto IL_49D8;
				case 576:
					goto IL_2E66;
				case 577:
					goto IL_3192;
				case 578:
					goto IL_232A;
				case 579:
					goto IL_4980;
				case 580:
					goto IL_1B5A;
				case 581:
					goto IL_4E57;
				case 582:
					goto IL_1573;
				case 583:
					goto IL_3144;
				case 584:
					goto IL_35C3;
				case 585:
					goto IL_4D3F;
				case 586:
					goto IL_1CBD;
				case 587:
					goto IL_448A;
				case 588:
					goto IL_3330;
				case 589:
					goto IL_3323;
				case 590:
					goto IL_3632;
				case 591:
					goto IL_2BDD;
				case 592:
					goto IL_1E96;
				case 593:
					goto IL_14C3;
				case 594:
					goto IL_569D;
				case 595:
					goto IL_5BAD;
				case 596:
					goto IL_1559;
				case 597:
					goto IL_104C;
				case 598:
					goto IL_3ECA;
				case 599:
					goto IL_44D2;
				case 600:
					goto IL_3EBD;
				case 601:
					goto IL_48D3;
				case 602:
					goto IL_3919;
				case 603:
					goto IL_3A2E;
				case 604:
					goto IL_281E;
				case 605:
					goto IL_530B;
				case 606:
					goto IL_1CB0;
				case 607:
					goto IL_2B6E;
				case 608:
					goto IL_49A7;
				case 609:
					goto IL_3FF6;
				case 610:
					goto IL_2A97;
				case 611:
					goto IL_30EC;
				case 612:
					goto IL_1893;
				case 613:
					goto IL_5683;
				case 614:
					goto IL_1C3E;
				case 615:
					goto IL_1777;
				case 616:
					goto IL_56F5;
				case 617:
					goto IL_3520;
				case 618:
					goto IL_5B31;
				case 619:
					goto IL_13F9;
				case 620:
					goto IL_3470;
				case 621:
					goto IL_1107;
				case 622:
					goto IL_1784;
				case 623:
					goto IL_186C;
				case 624:
					goto IL_3B6E;
				case 625:
					goto IL_32D8;
				case 626:
					goto IL_146B;
				case 627:
					goto IL_1E0D;
				case 628:
					goto IL_3C59;
				case 629:
					goto IL_3B3D;
				case 630:
					goto IL_49F2;
				case 631:
					goto IL_2337;
				case 632:
					goto IL_325C;
				case 633:
					goto IL_4FB4;
				case 634:
					goto IL_50E0;
				case 635:
					goto IL_2880;
				case 636:
					goto IL_3670;
				case 637:
					goto IL_3AAA;
				case 638:
					goto IL_5BF8;
				case 639:
					goto IL_3269;
				case 640:
					goto IL_59B6;
				case 641:
					goto IL_2C0E;
				case 642:
					goto IL_4B97;
				case 643:
					goto IL_2D78;
				case 644:
					goto IL_328D;
				case 645:
					goto IL_1616;
				case 646:
					goto IL_2D6B;
				case 647:
					goto IL_25F0;
				case 648:
					goto IL_5434;
				case 649:
					goto IL_2069;
				case 650:
					goto IL_36BB;
				case 651:
					goto IL_3F53;
				case 652:
					goto IL_4582;
				case 653:
					goto IL_2B61;
				case 654:
					goto IL_525E;
				case 655:
					goto IL_2C42;
				case 656:
					goto IL_4E23;
				case 657:
					goto IL_22D5;
				case 658:
					goto IL_5C1F;
				case 659:
					goto IL_442F;
				case 660:
					goto IL_4EBC;
				case 661:
					goto IL_5C7A;
				case 662:
					goto IL_2F78;
				case 663:
					goto IL_19CF;
				case 664:
					goto IL_18A0;
				case 665:
					goto IL_3663;
				case 666:
					goto IL_3F91;
				case 667:
					goto IL_5C60;
				case 668:
					goto IL_52FE;
				case 669:
					goto IL_4255;
				case 670:
					goto IL_422E;
				case 671:
					goto IL_1268;
				case 672:
					goto IL_251C;
				case 673:
					goto IL_24A8;
				case 674:
					goto IL_5598;
				case 675:
					goto IL_1A00;
				case 676:
					goto IL_1609;
				case 677:
					goto IL_3185;
				case 678:
					goto IL_1AD1;
				case 679:
					goto IL_18F8;
				case 680:
					goto IL_41A5;
				case 681:
					goto IL_29EA;
				case 682:
					goto IL_54E1;
				case 683:
					goto IL_1886;
				case 684:
					goto IL_5D34;
				case 685:
					goto IL_15FC;
				case 686:
					goto IL_307D;
				case 687:
					goto IL_1E3E;
				case 688:
					goto IL_50B9;
				case 689:
					goto IL_3F08;
				case 690:
					goto IL_5740;
				case 691:
					goto IL_17D9;
				case 692:
					goto IL_36C8;
				case 693:
					goto IL_2C35;
				case 694:
					goto IL_58D5;
				case 695:
					goto IL_39C9;
				case 696:
					goto IL_4221;
				case 697:
					goto IL_3585;
				case 698:
					goto IL_3513;
				case 699:
					goto IL_47FC;
				case 700:
					goto IL_1848;
				case 701:
					goto IL_482D;
				case 702:
					goto IL_4BE2;
				case 703:
					goto IL_1967;
				case 704:
					goto IL_4847;
				case 705:
					goto IL_3FB8;
				case 706:
					goto IL_522D;
				case 707:
					goto IL_18AD;
				case 708:
					goto IL_2581;
				case 709:
					goto IL_10AE;
				case 710:
					goto IL_4E4A;
				case 711:
					goto IL_460B;
				case 712:
					goto IL_3BF4;
				case 713:
					goto IL_2E80;
				case 714:
					goto IL_2D44;
				case 715:
					goto IL_3883;
				case 716:
					goto IL_23A6;
				case 717:
					goto IL_1F53;
				case 718:
					goto IL_2F47;
				case 719:
					goto IL_3D91;
				case 720:
					goto IL_5702;
				case 721:
					goto IL_3309;
				case 722:
					goto IL_46FD;
				case 723:
					goto IL_1028;
				case 724:
					goto IL_42FB;
				case 725:
					goto IL_51B1;
				case 726:
					goto IL_2567;
				case 727:
					goto IL_533F;
				case 728:
					goto IL_1E7C;
				case 729:
					goto IL_4041;
				case 730:
					goto IL_3E10;
				case 731:
					goto IL_1CEE;
				case 732:
					goto IL_33C6;
				case 733:
					goto IL_2FA9;
				case 734:
					goto IL_5676;
				case 735:
					goto IL_368A;
				case 736:
					goto IL_17F3;
				case 737:
					goto IL_54EE;
				case 738:
					goto IL_4B11;
				case 739:
					goto IL_2C80;
				case 740:
					goto IL_5968;
				case 741:
					goto IL_1682;
				case 742:
					goto IL_3CF4;
				case 743:
					goto IL_1F46;
				case 744:
					goto IL_21AC;
				case 745:
					goto IL_5C6D;
				case 746:
					goto IL_4A3D;
				case 747:
					goto IL_1C00;
				case 748:
					goto IL_3E41;
				case 749:
					goto IL_1DA8;
				case 750:
					goto IL_30F9;
				case 751:
					goto IL_37B9;
				case 752:
					goto IL_3178;
				case 753:
					goto IL_401D;
				case 754:
					goto IL_5472;
				case 755:
					goto IL_1EE1;
				case 756:
					goto IL_431F;
				case 757:
					goto IL_21B9;
				case 758:
					goto IL_37AC;
				case 759:
					goto IL_133C;
				case 760:
					goto IL_5645;
				case 761:
					goto IL_3838;
				case 762:
					goto IL_28D8;
				case 763:
					goto IL_4CC3;
				case 764:
					goto IL_3316;
				case 765:
					goto IL_52DA;
				case 766:
					goto IL_1B36;
				case 767:
					goto IL_4F14;
				case 768:
					goto IL_1420;
				case 769:
					goto IL_4959;
				case 770:
					goto IL_56AA;
				case 771:
					goto IL_57BC;
				case 772:
					goto IL_212D;
				case 773:
					goto IL_5251;
				case 774:
					goto IL_14B6;
				case 775:
					goto IL_26A7;
				case 776:
					goto IL_59C3;
				case 777:
					goto IL_5BBA;
				case 778:
					goto IL_47D8;
				case 779:
					goto IL_2B09;
				case 780:
					goto IL_2178;
				case 781:
					goto IL_3211;
				case 782:
					goto IL_48AC;
				case 783:
					goto IL_25BF;
				case 784:
					goto IL_2719;
				case 785:
					goto IL_2961;
				case 786:
					goto IL_34DF;
				case 787:
					goto IL_4CB6;
				case 788:
					goto IL_3137;
				case 789:
					goto IL_4752;
				case 790:
					goto IL_4065;
				case 791:
					goto IL_2B23;
				case 792:
					goto IL_1D46;
				case 793:
					goto IL_2408;
				case 794:
					goto IL_3EEE;
				case 795:
					goto IL_53F6;
				case 796:
					goto IL_4D70;
				case 797:
					goto IL_1753;
				case 798:
					goto IL_4C47;
				case 799:
					goto IL_13D2;
				case 800:
					goto IL_3744;
				case 801:
					goto IL_375E;
				case 802:
					goto IL_1566;
				case 803:
					goto IL_17B5;
				case 804:
					goto IL_398B;
				case 805:
					goto IL_250F;
				case 806:
					goto IL_367D;
				case 807:
					goto IL_20BE;
				case 808:
					goto IL_1D2C;
				case 809:
					goto IL_1F08;
				case 810:
					goto IL_19DC;
				case 811:
					goto IL_20B1;
				case 812:
					goto IL_34EC;
				case 813:
					goto IL_5047;
				case 814:
					goto IL_435D;
				case 815:
					goto IL_1F77;
				case 816:
					goto IL_2B88;
				case 817:
					goto IL_4A30;
				case 818:
					goto IL_1FA8;
				case 819:
					goto IL_4513;
				case 820:
					goto IL_3BC3;
				case 821:
					goto IL_2211;
				case 822:
					goto IL_11FC;
				case 823:
					goto IL_2D9C;
				case 824:
					goto IL_4EED;
				case 825:
					goto IL_28CB;
				case 826:
					goto IL_1DC2;
				case 827:
					goto IL_5ADC;
				case 828:
					goto IL_4B1E;
				case 829:
					goto IL_42EE;
				case 830:
					goto IL_107D;
				case 831:
					goto IL_37F7;
				case 832:
					goto IL_2FD0;
				case 833:
					goto IL_1C24;
				case 834:
					goto IL_22BB;
				case 835:
					goto IL_29C6;
				case 836:
					goto IL_58EF;
				case 837:
					goto IL_1879;
				case 838:
					goto IL_1CA3;
				case 839:
					goto IL_1413;
				case 840:
					goto IL_5CC5;
				case 841:
					goto IL_128F;
				case 842:
					goto IL_2BB9;
				case 843:
					goto IL_22F9;
				case 844:
					goto IL_3C97;
				case 845:
					goto IL_35B6;
				case 846:
					goto IL_1A86;
				case 847:
					goto IL_4973;
				case 848:
					goto IL_2CCB;
				case 849:
					goto IL_142D;
				case 850:
					goto IL_3E34;
				case 851:
					goto IL_3F15;
				case 852:
					goto IL_4DC8;
				case 853:
					goto IL_491B;
				case 854:
					goto IL_51D8;
				case 855:
					goto IL_4790;
				case 856:
					goto IL_4820;
				case 857:
					goto IL_18BA;
				case 858:
					goto IL_31B9;
				case 859:
					goto IL_4EAF;
				case 860:
					goto IL_282B;
				case 861:
					goto IL_38CE;
				case 862:
					goto IL_5180;
				case 863:
					goto IL_51BE;
				case 864:
					goto IL_36EC;
				case 865:
					goto IL_397E;
				case 866:
					goto IL_3792;
				case 867:
					goto IL_45C0;
				case 868:
					goto IL_4C85;
				case 869:
					goto IL_5AAB;
				case 870:
					goto IL_44F9;
				case 871:
					goto IL_483A;
				case 872:
					goto IL_4A88;
				case 873:
					goto IL_136D;
				case 874:
					goto IL_35DD;
				case 875:
					goto IL_3B19;
				case 876:
					goto IL_5441;
				case 877:
					goto IL_1451;
				case 878:
					goto IL_30A1;
				case 879:
					goto IL_34C5;
				case 880:
					goto IL_4463;
				case 881:
					goto IL_50ED;
				case 882:
					goto IL_4F3B;
				case 883:
					goto IL_3F84;
				case 884:
					goto IL_231D;
				case 885:
					goto IL_2CB1;
				case 886:
					goto IL_30DF;
				case 887:
					goto IL_3B9F;
				case 888:
					goto IL_1138;
				case 889:
					goto IL_42A3;
				case 890:
					goto IL_4289;
				case 891:
					goto IL_1A31;
				case 892:
					goto IL_4568;
				case 893:
					goto IL_42E1;
				case 894:
					goto IL_262E;
				case 895:
					goto IL_4D8A;
				case 896:
					goto IL_499A;
				case 897:
					goto IL_1C65;
				case 898:
					goto IL_39AF;
				case 899:
					goto IL_2AD5;
				case 900:
					goto IL_4AD3;
				case 901:
					goto IL_2D20;
				case 902:
					goto IL_41E3;
				case 903:
					goto IL_151B;
				case 904:
					goto IL_3A9D;
				case 905:
					goto IL_4DBB;
				case 906:
					goto IL_1BA5;
				case 907:
					goto IL_5B7C;
				case 908:
					goto IL_411F;
				case 909:
					goto IL_58C8;
				case 910:
					goto IL_4296;
				case 911:
					goto IL_5318;
				case 912:
					goto IL_5092;
				case 913:
					goto IL_11EF;
				case 914:
					goto IL_56C4;
				case 915:
					goto IL_1394;
				case 916:
					goto IL_1905;
				case 917:
					goto IL_3F77;
				case 918:
					goto IL_3AE8;
				case 919:
					goto IL_5B3E;
				case 920:
					goto IL_39FD;
				case 921:
					goto IL_10E3;
				case 922:
					goto IL_3D18;
				case 923:
					goto IL_1B29;
				case 924:
					goto IL_1AF5;
				case 925:
					goto IL_2ED8;
				case 926:
					goto IL_1DE9;
				case 927:
					goto IL_3A3B;
				case 928:
					goto IL_34D2;
				case 929:
					goto IL_5982;
				case 930:
					goto IL_1B02;
				case 931:
					goto IL_3ADB;
				case 932:
					goto IL_31AC;
				case 933:
					goto IL_360E;
				case 934:
					goto IL_27BC;
				case 935:
					goto IL_498D;
				case 936:
					goto IL_4928;
				case 937:
					goto IL_2C28;
				case 938:
					goto IL_4C3A;
				case 939:
					goto IL_5142;
				case 940:
					goto IL_57E0;
				case 941:
					goto IL_598F;
				case 942:
					goto IL_28BE;
				case 943:
					goto IL_42B0;
				case 944:
					goto IL_2AE2;
				case 945:
					goto IL_4470;
				case 946:
					goto IL_5061;
				case 947:
					goto IL_3B7B;
				case 948:
					goto IL_5C94;
				case 949:
					goto IL_4783;
				case 950:
					goto IL_1F2C;
				case 951:
					goto IL_3A5F;
				case 952:
					goto IL_356B;
				case 953:
					goto IL_382B;
				case 954:
					goto IL_3428;
				case 955:
					goto IL_2446;
				case 956:
					goto IL_4B04;
				case 957:
					goto IL_4E09;
				case 958:
					goto IL_315E;
				case 959:
					goto IL_4BA4;
				case 960:
					goto IL_1C72;
				case 961:
					goto IL_32A7;
				case 962:
					goto IL_29B9;
				case 963:
					goto IL_2192;
				case 964:
					goto IL_3001;
				case 965:
					goto IL_4C09;
				case 966:
					goto IL_27FA;
				case 967:
					goto IL_3592;
				case 968:
					goto IL_45FE;
				case 969:
					goto IL_1A93;
				case 970:
					goto IL_2954;
				case 971:
					goto IL_48B9;
				case 972:
					goto IL_4BB1;
				case 973:
					goto IL_581E;
				case 974:
					goto IL_5166;
				case 975:
					goto IL_38FF;
				case 976:
					goto IL_4F07;
				case 977:
					goto IL_5690;
				case 978:
					goto IL_2B3D;
				case 979:
					goto IL_2909;
				case 980:
					goto IL_333D;
				case 981:
					goto IL_2AFC;
				case 982:
					goto IL_3DF6;
				case 983:
					goto IL_3751;
				case 984:
					goto IL_31C6;
				case 985:
					goto IL_472E;
				case 986:
					goto IL_2EE5;
				case 987:
					goto IL_115C;
				case 988:
					goto IL_20FC;
				case 989:
					goto IL_43D6;
				case 990:
					goto IL_1D60;
				case 991:
					goto IL_4CF4;
				case 992:
					goto IL_1F39;
				case 993:
					goto IL_4D63;
				case 994:
					goto IL_2DDD;
				case 995:
					goto IL_270C;
				case 996:
					goto IL_3404;
				case 997:
					goto IL_334A;
				case 998:
					goto IL_3601;
				case 999:
					goto IL_3EB0;
				case 1000:
					goto IL_2399;
				case 1001:
					goto IL_5764;
				case 1002:
					goto IL_4F90;
				case 1003:
					goto IL_5B00;
				case 1004:
					goto IL_1DCF;
				case 1005:
					goto IL_31F7;
				case 1006:
					goto IL_198E;
				case 1007:
					goto IL_22C8;
				case 1008:
					goto IL_53D2;
				case 1009:
					goto IL_534C;
				case 1010:
					goto IL_1EA3;
				case 1011:
					goto IL_32CB;
				case 1012:
					goto IL_2B16;
				case 1013:
					goto IL_3C25;
				default:
					num = (short)2030632961;
					num2 = (int)((global::System.IntPtr)num);
					break;
				}
			}
			IL_1028:
			this.LblTrkSysASTRO25QuickFadeProtectms_A8807 = (global::AcpUI.AcpLabel)target;
			this.LblTrkSysASTRO25QuickFadeProtectms_A8807.MouseDoubleClick += new global::System.Windows.Input.MouseButtonEventHandler(this.OnFieldNameDoubleClick);
			return;
			IL_104C:
			this.ExpanderTrunkingSystemSiteAlias = (global::AcpUI.AcpExpander)target;
			return;
			IL_1059:
			this.LblTrkSysOBTChannelAssignmentListRxStartChannelNumber_A20478 = (global::AcpUI.AcpLabel)target;
			this.LblTrkSysOBTChannelAssignmentListRxStartChannelNumber_A20478.MouseDoubleClick += new global::System.Windows.Input.MouseButtonEventHandler(this.OnFieldNameDoubleClick);
			return;
			IL_107D:
			this.CpyBtnTrkSysDigitalFDMAFrameSyncNIDBERThreshold_A8159 = (global::AcpUI.AcpCopyButton)target;
			return;
			IL_108A:
			this.TrkSysGeneralDataProfileSelection_A19449 = (global::AcpUI.AcpComboBox)target;
			this.TrkSysGeneralDataProfileSelection_A19449.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_10AE:
			num = (short)1941635073;
			if (num != 0)
			{
			}
			this.TrkSysASTRO25ISPSequenceLengthsec_A8354Comp = (global::AcpUI.AcpLabel)target;
			return;
			IL_10E3:
			this.TrkSysSecureMultikeyDynamicTalkgroupKeySelect_A7918 = (global::AcpUI.AcpComboBox)target;
			this.TrkSysSecureMultikeyDynamicTalkgroupKeySelect_A7918.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_1107:
			this.CVBtnTrkSysSiteAlias_A24071 = (global::AcpUI.AcpCustomViewCheckBox)target;
			return;
			IL_1114:
			this.TrkSysControlChannelsTxFrequencyMHz_A9535 = (global::AcpUI.AcpTextBox)target;
			this.TrkSysControlChannelsTxFrequencyMHz_A9535.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_1138:
			this.TrkSysSecureMultikeyPrivateCallKeySelect_A8757 = (global::AcpUI.AcpComboBox)target;
			this.TrkSysSecureMultikeyPrivateCallKeySelect_A8757.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_115C:
			this.CpyBtnTrkSysLabtoolTrunkingSystemStatusAliasTextListItemID_A19968 = (global::AcpUI.AcpCopyButton)target;
			return;
			IL_1169:
			this.CVBtnTrkSysFeatureLocationOnPTT_43026 = (global::AcpUI.AcpCustomViewCheckBox)target;
			return;
			IL_1176:
			this.HLinkControlChannels = (global::System.Windows.Documents.Hyperlink)target;
			this.HLinkControlChannels.Click += this.HLinkClick;
			return;
			IL_119A:
			this.LblTrkSysOBTChannelAssignmentListTxSpacingKHz_A9520 = (global::AcpUI.AcpLabel)target;
			this.LblTrkSysOBTChannelAssignmentListTxSpacingKHz_A9520.MouseDoubleClick += new global::System.Windows.Input.MouseButtonEventHandler(this.OnFieldNameDoubleClick);
			return;
			IL_11BE:
			this.LblTrkSysOBTChannelRange_A24072 = (global::AcpUI.AcpLabel)target;
			this.LblTrkSysOBTChannelRange_A24072.MouseDoubleClick += new global::System.Windows.Input.MouseButtonEventHandler(this.OnFieldNameDoubleClick);
			return;
			IL_11E2:
			this.TrkSysOBTChannelAssignmentListTxStartChannelNumber_A20479Comp = (global::AcpUI.AcpTextBoxDecHex)target;
			return;
			IL_11EF:
			this.CVBtnTrkSysSecureMultikeyDynamicSecureClearStrapping_43489 = (global::AcpUI.AcpCustomViewCheckBox)target;
			return;
			IL_11FC:
			this.TrkSysDigitalF2TDMAFrameSyncBERThreshold_A1396 = (global::AcpUI.AcpTextBoxSpinner)target;
			this.TrkSysDigitalF2TDMAFrameSyncBERThreshold_A1396.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_1220:
			this.TrkSysFeaturesBusyLED_44911 = (global::AcpUI.AcpCheckBox)target;
			this.TrkSysFeaturesBusyLED_44911.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_1244:
			this.LblTrkSysFeaturesBusyLED_44911 = (global::AcpUI.AcpLabel)target;
			this.LblTrkSysFeaturesBusyLED_44911.MouseDoubleClick += new global::System.Windows.Input.MouseButtonEventHandler(this.OnFieldNameDoubleClick);
			return;
			IL_1268:
			this.ExpanderTrunkingSystemOneTouchTableSRecView = (global::AcpUI.AcpGroupBox)target;
			return;
			IL_1275:
			this.ExpanderTrunkingSystemFeatures = (global::AcpUI.AcpExpander)target;
			return;
			IL_1282:
			this.TrkSysOBTChannelAssignmentListRxStartChannelNumber_A20478Comp = (global::AcpUI.AcpTextBoxDecHex)target;
			return;
			IL_128F:
			this.CVBtnTrkSysSecureMultikeyASTROOTAR_A7494 = (global::AcpUI.AcpCustomViewCheckBox)target;
			return;
			IL_129C:
			this.CpyBtnTrkSysASTRO25ChannelIDChannelType_A1390 = (global::AcpUI.AcpCopyButton)target;
			return;
			IL_12A9:
			this.TrkSysLTEInterferingFreqPresent_A42198 = (global::AcpUI.AcpLabel)target;
			this.TrkSysLTEInterferingFreqPresent_A42198.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_12CD:
			this.ExpanderTrunkingSystemASTRO25ChannelID = (global::AcpUI.AcpExpander)target;
			return;
			IL_12DA:
			this.TrkSysTypeIIChannelSetupSplinterChannel_A9175 = (global::AcpUI.AcpCheckBox)target;
			this.TrkSysTypeIIChannelSetupSplinterChannel_A9175.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_12FE:
			this.TrkSysGeneralSystemKeyType_A38853 = (global::AcpUI.AcpComboBox)target;
			this.TrkSysGeneralSystemKeyType_A38853.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_1322:
			this.ExpanderTrunkingSystemMessageAlias = (global::AcpUI.AcpExpander)target;
			return;
			IL_132F:
			this.TrkSysFeaturesDTMFTimingTable_A7900Comp = (global::AcpUI.AcpLabel)target;
			return;
			IL_133C:
			this.LblTrkSysASTRO25EndF2TDMATransmitOnOutOfRange_A1394 = (global::AcpUI.AcpLabel)target;
			this.LblTrkSysASTRO25EndF2TDMATransmitOnOutOfRange_A1394.MouseDoubleClick += new global::System.Windows.Input.MouseButtonEventHandler(this.OnFieldNameDoubleClick);
			return;
			IL_1360:
			this.CpyBtnTrkPerFeaturesOTARadioAliasType_42854 = (global::AcpUI.AcpCopyButton)target;
			return;
			IL_136D:
			this.CVBtnTrkSysSecureMultikeyFailsoftKeySelect_A8012 = (global::AcpUI.AcpCustomViewCheckBox)target;
			return;
			IL_137A:
			this.CpyBtnTrkSysOBTChannelAssignmentListRxEnable_A9001 = (global::AcpUI.AcpCopyButton)target;
			return;
			IL_1387:
			this.MyStackPanel = (global::System.Windows.Controls.StackPanel)target;
			return;
			IL_1394:
			this.TrkSysSecureMultikeyDynamicSecureClearStrapping_43489 = (global::AcpUI.AcpComboBox)target;
			this.TrkSysSecureMultikeyDynamicSecureClearStrapping_43489.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_13B8:
			this.CpyBtnTrkSysControlChannelsRxFrequencyMHz_A9018 = (global::AcpUI.AcpCopyButton)target;
			return;
			IL_13C5:
			this.TrkSysOBTChannelAssignmentListRxStartChannelNumber_A20478_Col = (global::Infragistics.Windows.DataPresenter.UnboundField)target;
			return;
			IL_13D2:
			this.RTDBtnTrkSysDigitalAdaptivePower_A7509 = (global::AcpUI.AcpRtdButton)target;
			return;
			IL_13DF:
			this.CpyBtnTrkSysGeneralRFSSID_A8980 = (global::AcpUI.AcpCopyButton)target;
			return;
			IL_13EC:
			this.CpyBtnTrkSysOBTChannelRange_A24072 = (global::AcpUI.AcpCopyButton)target;
			return;
			IL_13F9:
			this.gridExpanderTrunkingSystemSiteAliasTableSRecView = (global::System.Windows.Controls.Grid)target;
			return;
			IL_1406:
			this.CVBtnTrkSysOBTChannelAssignmentListRxStartChannelNumber_A20478 = (global::AcpUI.AcpCustomViewCheckBox)target;
			return;
			IL_1413:
			this.TrkSysSecureMultikeyDESXLTxRxDefault_A7833Comp = (global::AcpUI.AcpCheckBox)target;
			return;
			IL_1420:
			this.CpyBtnTrkSysASTRO25Phase2VoiceCapable_A37972 = (global::AcpUI.AcpCopyButton)target;
			return;
			IL_142D:
			this.TrkSysSecureMultikeyOTARTx_A8676 = (global::AcpUI.AcpCheckBox)target;
			this.TrkSysSecureMultikeyOTARTx_A8676.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_1451:
			this.CpyBtnTrkSysSecureMultikeyFailsoftKeySelect_A8012 = (global::AcpUI.AcpCopyButton)target;
			return;
			IL_145E:
			this.TrkSysOBTChannelAssignmentListRxStartFrequencyMHz_A9029Comp = (global::AcpUI.AcpLabel)target;
			return;
			IL_146B:
			this.CVBtnTrkSysSiteAliasRFSSAliasNumber_A8978 = (global::AcpUI.AcpCustomViewCheckBox)target;
			return;
			IL_1478:
			this.CpyBtnTrkSysFeaturesDTMFTimingTable_A7900 = (global::AcpUI.AcpCopyButton)target;
			return;
			IL_1485:
			this.TrkSysStatusAliasStatusAliasEnable_A9195 = (global::AcpUI.AcpCheckBox)target;
			this.TrkSysStatusAliasStatusAliasEnable_A9195.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_14A9:
			this.TrkSysOBTChannelAssignmentListTxEnable_A9517_Col = (global::Infragistics.Windows.DataPresenter.UnboundField)target;
			return;
			IL_14B6:
			this.CpyBtnTrkSysASTRO25EndPhase2TDMATransmitOnOutOfRange_A37980 = (global::AcpUI.AcpCopyButton)target;
			return;
			IL_14C3:
			this.LblTrkSysStatusAliasStatusAliasText_A9193 = (global::AcpUI.AcpLabel)target;
			this.LblTrkSysStatusAliasStatusAliasText_A9193.MouseDoubleClick += new global::System.Windows.Input.MouseButtonEventHandler(this.OnFieldNameDoubleClick);
			return;
			IL_14E7:
			this.TrkSysFeaturesSecureLED_A9071Comp = (global::AcpUI.AcpCheckBox)target;
			return;
			IL_14F4:
			this.TrkSysFeaturesTxPowerLevel_A9557Comp = (global::AcpUI.AcpLabel)target;
			return;
			IL_1501:
			this.RTDBtnTrkSysFeaturesBusyLED_44911 = (global::AcpUI.AcpRtdButton)target;
			return;
			IL_150E:
			this.TrkSysTypeIIChannelSetupNPSPACChannelBandwidthkHz_A8571Comp = (global::AcpUI.AcpLabel)target;
			return;
			IL_151B:
			this.CpyBtnTrkSysSecureMultikeyInterconnectKeySelect_A8298 = (global::AcpUI.AcpCopyButton)target;
			return;
			IL_1528:
			this.CpyBtnTrkSysFeaturesChannel_A7647 = (global::AcpUI.AcpCopyButton)target;
			return;
			IL_1535:
			this.LblTrkSysFeaturesICUAAutoResetTimesec_A7515 = (global::AcpUI.AcpLabel)target;
			this.LblTrkSysFeaturesICUAAutoResetTimesec_A7515.MouseDoubleClick += new global::System.Windows.Input.MouseButtonEventHandler(this.OnFieldNameDoubleClick);
			return;
			IL_1559:
			this.TrkSysStatusAliasStatusAliasText_A9193Comp = (global::AcpUI.AcpLabel)target;
			return;
			IL_1566:
			this.CVBtnTrkSysDigitalHighDeviationTx_A19314 = (global::AcpUI.AcpCustomViewCheckBox)target;
			return;
			IL_1573:
			this.LblTrkSysStatusAlias_A24070 = (global::AcpUI.AcpLabel)target;
			this.LblTrkSysStatusAlias_A24070.MouseDoubleClick += new global::System.Windows.Input.MouseButtonEventHandler(this.OnFieldNameDoubleClick);
			return;
			IL_1597:
			this.TrkSysControlChannelsRxFrequencyMHz_A9018 = (global::AcpUI.AcpTextBox)target;
			this.TrkSysControlChannelsRxFrequencyMHz_A9018.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_15BB:
			this.CVBtnTrkSysLabtoolNetworkID_A8565 = (global::AcpUI.AcpCustomViewCheckBox)target;
			return;
			IL_15C8:
			this.TrkSysOBTChannelAssignmentListRxSpacingKHz_A9004_Col = (global::Infragistics.Windows.DataPresenter.UnboundField)target;
			return;
			IL_15D5:
			this.CVBtnTrkSysGeneralSystemKeyType_A38853 = (global::AcpUI.AcpCustomViewCheckBox)target;
			return;
			IL_15E2:
			this.TrkSysGeneralDataProfileSelection_A19449Comp = (global::AcpUI.AcpLabel)target;
			return;
			IL_15EF:
			this.TrkSysLabtoolEnable_A8669Comp = (global::AcpUI.AcpCheckBox)target;
			return;
			IL_15FC:
			this.CVBtnTrkSysOneTouchIndex_A8618 = (global::AcpUI.AcpCustomViewCheckBox)target;
			return;
			IL_1609:
			this.CpyBtnTrkSysOneTouchButton_A19763 = (global::AcpUI.AcpCopyButton)target;
			return;
			IL_1616:
			this.LblTrkSysSiteAliasSiteAliasType_A41343 = (global::AcpUI.AcpLabel)target;
			this.LblTrkSysSiteAliasSiteAliasType_A41343.MouseDoubleClick += new global::System.Windows.Input.MouseButtonEventHandler(this.OnFieldNameDoubleClick);
			return;
			IL_163A:
			this.LblTrkSysLabtoolEnable_A8669 = (global::AcpUI.AcpLabel)target;
			this.LblTrkSysLabtoolEnable_A8669.MouseDoubleClick += new global::System.Windows.Input.MouseButtonEventHandler(this.OnFieldNameDoubleClick);
			return;
			IL_165E:
			this.LblTrkSysMessageAliasMessageAliasText_A8503 = (global::AcpUI.AcpLabel)target;
			this.LblTrkSysMessageAliasMessageAliasText_A8503.MouseDoubleClick += new global::System.Windows.Input.MouseButtonEventHandler(this.OnFieldNameDoubleClick);
			return;
			IL_1682:
			this.LblTrkSysASTRO25ResponsePendingTimesec_A8945 = (global::AcpUI.AcpLabel)target;
			this.LblTrkSysASTRO25ResponsePendingTimesec_A8945.MouseDoubleClick += new global::System.Windows.Input.MouseButtonEventHandler(this.OnFieldNameDoubleClick);
			return;
			IL_16A6:
			this.HLinkGeneral = (global::System.Windows.Documents.Hyperlink)target;
			this.HLinkGeneral.Click += this.HLinkClick;
			return;
			IL_16CA:
			this.RecNavToolbarPageTrunkingSystem = (global::AcpUI.AcpParentRecNavToolbar)target;
			this.RecNavToolbarPageTrunkingSystem.ModeClick += this.OnModeClick;
			return;
			IL_16EE:
			this.GrpBoxExpanderTrunkingSystemStatusAliasPseudo0 = (global::AcpUI.AcpGroupBox)target;
			return;
			IL_16FB:
			this.SiteSelectableAlertAliasList_A42100Comp = (global::AcpUI.AcpLabel)target;
			return;
			IL_1708:
			this.TrkSysFeaturesSecureLED_A9071 = (global::AcpUI.AcpCheckBox)target;
			this.TrkSysFeaturesSecureLED_A9071.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_172C:
			this.TrkSysFeaturesRadioInhibit_A8833Comp = (global::AcpUI.AcpCheckBox)target;
			return;
			IL_1739:
			this.CVBtnTrkSysFeaturesZone_A9717 = (global::AcpUI.AcpCustomViewCheckBox)target;
			return;
			IL_1746:
			this.ExpanderTrunkingSystemChannelRangesMHz = (global::AcpUI.AcpXamDataPresenter)target;
			return;
			IL_1753:
			this.LblTrkSysDigitalAdaptivePower_A7509 = (global::AcpUI.AcpLabel)target;
			this.LblTrkSysDigitalAdaptivePower_A7509.MouseDoubleClick += new global::System.Windows.Input.MouseButtonEventHandler(this.OnFieldNameDoubleClick);
			return;
			IL_1777:
			this.TrkSysSiteAliasSiteAliasType_A41343_Col = (global::Infragistics.Windows.DataPresenter.UnboundField)target;
			return;
			IL_1784:
			this.LblTrkSysSiteAlias_A24071 = (global::AcpUI.AcpLabel)target;
			this.LblTrkSysSiteAlias_A24071.MouseDoubleClick += new global::System.Windows.Input.MouseButtonEventHandler(this.OnFieldNameDoubleClick);
			return;
			IL_17A8:
			this.RTDBtnTrkSysASTRO25ChannelIDTransmitOffsetSign_A9417 = (global::AcpUI.AcpRtdButton)target;
			return;
			IL_17B5:
			this.LblTrkSysDigitalHighDeviationTx_A19314 = (global::AcpUI.AcpLabel)target;
			this.LblTrkSysDigitalHighDeviationTx_A19314.MouseDoubleClick += new global::System.Windows.Input.MouseButtonEventHandler(this.OnFieldNameDoubleClick);
			return;
			IL_17D9:
			this.CVBtnTrkSysOneTouchAbbreviatedOneTouchAlias_A8622 = (global::AcpUI.AcpCustomViewCheckBox)target;
			return;
			IL_17E6:
			this.TrkSysTypeIIChannelSetupShuffledBandPlan_A9128Comp = (global::AcpUI.AcpCheckBox)target;
			return;
			IL_17F3:
			this.TrkSysASTRO25BusyUpdateTimesec_A7574 = (global::AcpUI.AcpTextBoxSpinner)target;
			this.TrkSysASTRO25BusyUpdateTimesec_A7574.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_1817:
			this.TrkSysASTRO25ChannelIDIdentifierEnable_A8222 = (global::AcpUI.AcpCheckBox)target;
			this.TrkSysASTRO25ChannelIDIdentifierEnable_A8222.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_183B:
			this.TrkSysFeaturesGroupTMSEable_42804Comp = (global::AcpUI.AcpLabel)target;
			return;
			IL_1848:
			this.TrkSysASTRO25MotorolaProprietaryFeatures_A8547 = (global::AcpUI.AcpCheckBox)target;
			this.TrkSysASTRO25MotorolaProprietaryFeatures_A8547.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_186C:
			this.CpyBtnTrkSysSiteAlias_A24071 = (global::AcpUI.AcpCopyButton)target;
			return;
			IL_1879:
			this.RTDBtnTrkSysSecureMultikeyDESXLTxRxDefault_A7833 = (global::AcpUI.AcpRtdButton)target;
			return;
			IL_1886:
			this.TrkSysOneTouchFeature_A8614Comp = (global::AcpUI.AcpLabel)target;
			return;
			IL_1893:
			this.TrkSysSiteAliasRFSSAliasNumber_A8978_Col = (global::Infragistics.Windows.DataPresenter.UnboundField)target;
			return;
			IL_18A0:
			this.ExpanderTrunkingSystemOneTouchTableGrid = (global::System.Windows.Controls.Grid)target;
			return;
			IL_18AD:
			this.RTDBtnTrkSysASTRO25ISPSequenceLengthsec_A8354 = (global::AcpUI.AcpRtdButton)target;
			return;
			IL_18BA:
			this.CpyBtnTrkSysSecureMultikeyKMFProfileIndex_A8382 = (global::AcpUI.AcpCopyButton)target;
			return;
			IL_18C7:
			this.LblTrkSysGeneralSystemKeyPresent_A9241 = (global::AcpUI.AcpLabel)target;
			this.LblTrkSysGeneralSystemKeyPresent_A9241.MouseDoubleClick += new global::System.Windows.Input.MouseButtonEventHandler(this.OnFieldNameDoubleClick);
			return;
			IL_18EB:
			this.RTDBtnTrkSysASTRO25ChannelIDIdentifierEnable_A8222 = (global::AcpUI.AcpRtdButton)target;
			return;
			IL_18F8:
			this.CVBtnTrkSysOneTouchFeature_A8614 = (global::AcpUI.AcpCustomViewCheckBox)target;
			return;
			IL_1905:
			this.RTDBtnTrkSysSecureMultikeyDynamicSecureClearStrapping_43489 = (global::AcpUI.AcpRtdButton)target;
			return;
			IL_1912:
			this.CpyBtnTrkSysTypeIIChannelSetupChannelAssignmentType_A7652 = (global::AcpUI.AcpCopyButton)target;
			return;
			IL_191F:
			this.LblTrkSysFeaturesZone_A9717 = (global::AcpUI.AcpLabel)target;
			this.LblTrkSysFeaturesZone_A9717.MouseDoubleClick += new global::System.Windows.Input.MouseButtonEventHandler(this.OnFieldNameDoubleClick);
			return;
			IL_1943:
			this.TrkSysGeneralSiteID_A9150 = (global::AcpUI.AcpTextBoxSpinnerDecHex)target;
			this.TrkSysGeneralSiteID_A9150.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_1967:
			this.TrkSysASTRO25MotorolaProprietaryFeatures_A8547Comp = (global::AcpUI.AcpCheckBox)target;
			return;
			IL_1974:
			this.CpyBtnTrkSysFeaturesOTARadioAliasUpdateEnable_A43057 = (global::AcpUI.AcpCopyButton)target;
			return;
			IL_1981:
			this.CVBtnTrkSysFeaturesSecureLED_A9071 = (global::AcpUI.AcpCustomViewCheckBox)target;
			return;
			IL_198E:
			this.TrkSysLabtoolTrunkingSystemSiteAliasTextListItemID_A19972Comp = (global::AcpUI.AcpLabel)target;
			return;
			IL_199B:
			this.RTDBtnTrkSysMessageAliasMessageAliasEnable_A8505 = (global::AcpUI.AcpRtdButton)target;
			return;
			IL_19A8:
			this.RTDBtnTrkSysGeneralCoverageType_A7782 = (global::AcpUI.AcpRtdButton)target;
			return;
			IL_19B5:
			this.CVBtnTrkSysGeneralUnitID_A12651 = (global::AcpUI.AcpCustomViewCheckBox)target;
			return;
			IL_19C2:
			this.ExpanderTrunkingSystemOBTChannelAssignment = (global::AcpUI.AcpExpander)target;
			return;
			IL_19CF:
			this.ExpanderTrunkingSystemOneTouchGrid = (global::System.Windows.Controls.Grid)target;
			return;
			IL_19DC:
			this.TrkSysDigitalPreambleLength_A8722 = (global::AcpUI.AcpTextBoxSpinner)target;
			this.TrkSysDigitalPreambleLength_A8722.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_1A00:
			this.LblTrkSysOneTouchButton_A19763 = (global::AcpUI.AcpLabel)target;
			this.LblTrkSysOneTouchButton_A19763.MouseDoubleClick += new global::System.Windows.Input.MouseButtonEventHandler(this.OnFieldNameDoubleClick);
			return;
			IL_1A24:
			this.CpyBtnTrkSysTypeIIChannelSetupChannelBandwidthkHz_A7654 = (global::AcpUI.AcpCopyButton)target;
			return;
			IL_1A31:
			this.TrkSysSecureMultikeyPrivateCallKeySelect_A8757Comp = (global::AcpUI.AcpLabel)target;
			return;
			IL_1A3E:
			this.LblTrkSysLTEInterferingFreqPresent_A42198 = (global::AcpUI.AcpLabel)target;
			this.LblTrkSysLTEInterferingFreqPresent_A42198.MouseDoubleClick += new global::System.Windows.Input.MouseButtonEventHandler(this.OnFieldNameDoubleClick);
			return;
			IL_1A62:
			this.TrkSysMsgAlias_A24069 = (global::AcpUI.AcpLabel)target;
			this.TrkSysMsgAlias_A24069.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_1A86:
			this.TrkSysSecureMultikeyASTROOTAR_A7494Comp = (global::AcpUI.AcpCheckBox)target;
			return;
			IL_1A93:
			this.CpyBtnTrkSysLabtoolTrunkingSystemControlChannelListItemID_A19964 = (global::AcpUI.AcpCopyButton)target;
			return;
			IL_1AA0:
			this.TrkSysFeaturesTxBaseTimeSec_A9512 = (global::AcpUI.AcpComboBox)target;
			this.TrkSysFeaturesTxBaseTimeSec_A9512.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_1AC4:
			this.TrkSysASTRO25ChannelIDIdentifierEnable_A8222Comp = (global::AcpUI.AcpCheckBox)target;
			return;
			IL_1AD1:
			this.TrkSysOneTouchFeature_A8614 = (global::AcpUI.AcpComboBox)target;
			this.TrkSysOneTouchFeature_A8614.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_1AF5:
			this.TrkSysSecureMultikeyDynamicTalkgroupKeySelect_A7918Comp = (global::AcpUI.AcpLabel)target;
			return;
			IL_1B02:
			this.TrkSysSecureMultikeyDynamicAGKeySelect_A7914Comp = (global::AcpUI.AcpLabel)target;
			return;
			IL_1B0F:
			this.CVBtnTrkSysFeaturesOTARadioAliasUpdateEnable_A43057 = (global::AcpUI.AcpCustomViewCheckBox)target;
			return;
			IL_1B1C:
			this.RTDBtnSiteSelectableAlertList_A42060 = (global::AcpUI.AcpRtdButton)target;
			return;
			IL_1B29:
			this.CpyBtnTrkSysSecureMultikeyDynamicTalkgroupKeySelect_A7918 = (global::AcpUI.AcpCopyButton)target;
			return;
			IL_1B36:
			this.TrkSysASTRO25Phase2VoiceCapable_A37972 = (global::AcpUI.AcpCheckBox)target;
			this.TrkSysASTRO25Phase2VoiceCapable_A37972.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_1B5A:
			this.TrkSysStatusAlias_A24070 = (global::AcpUI.AcpLabel)target;
			this.TrkSysStatusAlias_A24070.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_1B7E:
			this.CpyBtnTrkSysASTRO25ChannelIDIdentifierEnable_A8222 = (global::AcpUI.AcpCopyButton)target;
			return;
			IL_1B8B:
			this.TrkSysOBTChannelAssignmentListRxEnable_A9001_Col = (global::Infragistics.Windows.DataPresenter.UnboundField)target;
			return;
			IL_1B98:
			this.CpyBtnTrkSysMessageAliasMessageAliasText_A8503 = (global::AcpUI.AcpCopyButton)target;
			return;
			IL_1BA5:
			this.CVBtnTrkSysSecureMultikeySystemWideKeySelect_A9253 = (global::AcpUI.AcpCustomViewCheckBox)target;
			return;
			IL_1BB2:
			this.RTDBtnTrkSysGeneralSystemType_A9252 = (global::AcpUI.AcpRtdButton)target;
			return;
			IL_1BBF:
			this.TrkSysOBTChannelAssignmentListTxStartChannelNumber_A20479_Col = (global::Infragistics.Windows.DataPresenter.UnboundField)target;
			return;
			IL_1BCC:
			this.RTDBtnTrkSysOBTChannelAssignmentListTxStartFrequencyMHz_A9568 = (global::AcpUI.AcpRtdButton)target;
			return;
			IL_1BD9:
			this.TrkSysGeneralConnectToneHz_A7710Comp = (global::AcpUI.AcpLabel)target;
			return;
			IL_1BE6:
			this.TrkSysASTRO25ChannelIDBaseFrequencyMHz_A7546Comp = (global::AcpUI.AcpLabel)target;
			return;
			IL_1BF3:
			this.CVBtnTrkSysGeneralRFSSResponseTimems_A8981 = (global::AcpUI.AcpCustomViewCheckBox)target;
			return;
			IL_1C00:
			this.LblTrkSysASTRO25DefaultRCMAddress_A7813 = (global::AcpUI.AcpLabel)target;
			this.LblTrkSysASTRO25DefaultRCMAddress_A7813.MouseDoubleClick += new global::System.Windows.Input.MouseButtonEventHandler(this.OnFieldNameDoubleClick);
			return;
			IL_1C24:
			this.GrpBoxExpanderTrunkingSystemSecureMultikeyPseudo0 = (global::AcpUI.AcpGroupBox)target;
			return;
			IL_1C31:
			this.TrkSysASTRO25ChannelIDChannelType_A1390Comp = (global::AcpUI.AcpLabel)target;
			return;
			IL_1C3E:
			this.TrkSysSiteAliasSiteAliasText_A9146_Col = (global::Infragistics.Windows.DataPresenter.UnboundField)target;
			return;
			IL_1C4B:
			this.TrkSysFeaturesPASelection_A42882Comp = (global::AcpUI.AcpLabel)target;
			return;
			IL_1C58:
			this.CVBtnTrkSysOBTChannelAssignmentListRxStartFrequencyMHz_A9029 = (global::AcpUI.AcpCustomViewCheckBox)target;
			return;
			IL_1C65:
			this.CpyBtnTrkSysSecureMultikeyInterconnectSecureClearStrapping_43478 = (global::AcpUI.AcpCopyButton)target;
			return;
			IL_1C72:
			this.LblTrkSysLabtoolTrunkingSystemOneTouchListItemID_A22633 = (global::AcpUI.AcpLabel)target;
			this.LblTrkSysLabtoolTrunkingSystemOneTouchListItemID_A22633.MouseDoubleClick += new global::System.Windows.Input.MouseButtonEventHandler(this.OnFieldNameDoubleClick);
			return;
			IL_1C96:
			this.RTDBtnTrkSysLabtoolNetworkID_A8565 = (global::AcpUI.AcpRtdButton)target;
			return;
			IL_1CA3:
			this.CpyBtnTrkSysSecureMultikeyDESXLTxRxDefault_A7833 = (global::AcpUI.AcpCopyButton)target;
			return;
			IL_1CB0:
			this.ExpanderTrunkingSystemSiteAliasGrid = (global::System.Windows.Controls.Grid)target;
			return;
			IL_1CBD:
			this.CVBtnTrkSysStatusAliasStatusAliasNumber_A9190 = (global::AcpUI.AcpCustomViewCheckBox)target;
			return;
			IL_1CCA:
			this.RecNavToolbarExpanderTrunkingSystemMessageAliasTable = (global::AcpUI.AcpChildRecNavToolbar)target;
			this.RecNavToolbarExpanderTrunkingSystemMessageAliasTable.ModeClick += this.OnModeClick;
			return;
			IL_1CEE:
			this.RTDBtnTrkSysASTRO25PTTWarningTimems_A8781 = (global::AcpUI.AcpRtdButton)target;
			return;
			IL_1CFB:
			this.TrkSysTypeIIChannelSetupLegacyTransitSystem_A8429 = (global::AcpUI.AcpCheckBox)target;
			this.TrkSysTypeIIChannelSetupLegacyTransitSystem_A8429.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_1D1F:
			this.ExpanderTrunkingSystemASTRO25ChannelIDGrid = (global::System.Windows.Controls.Grid)target;
			return;
			IL_1D2C:
			this.CVBtnTrkSysDigitalPreambleLength_A8722 = (global::AcpUI.AcpCustomViewCheckBox)target;
			return;
			IL_1D39:
			this.CVBtnTrkSysOBTChannelAssignmentListRxEndFrequencyMHz_A9012 = (global::AcpUI.AcpCustomViewCheckBox)target;
			return;
			IL_1D46:
			this.CpyBtnTrkSysASTRO25GeoFenceMode_42322 = (global::AcpUI.AcpCopyButton)target;
			return;
			IL_1D53:
			this.ThemeBaseObj = (global::AcpUI.Common.AcpThemeBase)target;
			return;
			IL_1D60:
			this.LblTrkSysLabtoolTrunkingSystemMessageAliasListItemID_A19969 = (global::AcpUI.AcpLabel)target;
			this.LblTrkSysLabtoolTrunkingSystemMessageAliasListItemID_A19969.MouseDoubleClick += new global::System.Windows.Input.MouseButtonEventHandler(this.OnFieldNameDoubleClick);
			return;
			IL_1D84:
			this.LblTrkSysGeneralTypeIIFrequencyBand_A12491 = (global::AcpUI.AcpLabel)target;
			this.LblTrkSysGeneralTypeIIFrequencyBand_A12491.MouseDoubleClick += new global::System.Windows.Input.MouseButtonEventHandler(this.OnFieldNameDoubleClick);
			return;
			IL_1DA8:
			this.RTDBtnTrkSysASTRO25DefaultRCMAddress_A7813 = (global::AcpUI.AcpRtdButton)target;
			return;
			IL_1DB5:
			this.GrpBoxExpanderTrunkingSystemTypeIIChannelSetupPseudo0 = (global::AcpUI.AcpGroupBox)target;
			return;
			IL_1DC2:
			this.CVBtnTrkSysDigitalFDMAFrameSyncNIDBERThreshold_A8159 = (global::AcpUI.AcpCustomViewCheckBox)target;
			return;
			IL_1DCF:
			this.RTDBtnTrkSysLabtoolTrunkingSystemSiteAliasTextListItemID_A19972 = (global::AcpUI.AcpRtdButton)target;
			return;
			IL_1DDC:
			this.CpyBtnTrkSysGeneralDataProfileSelection_A19449 = (global::AcpUI.AcpCopyButton)target;
			return;
			IL_1DE9:
			this.LblTrkSysSecureMultikeyDynamicAGKeySelect_A7914 = (global::AcpUI.AcpLabel)target;
			this.LblTrkSysSecureMultikeyDynamicAGKeySelect_A7914.MouseDoubleClick += new global::System.Windows.Input.MouseButtonEventHandler(this.OnFieldNameDoubleClick);
			return;
			IL_1E0D:
			this.LblTrkSysSiteAliasRFSSAliasNumber_A8978 = (global::AcpUI.AcpLabel)target;
			this.LblTrkSysSiteAliasRFSSAliasNumber_A8978.MouseDoubleClick += new global::System.Windows.Input.MouseButtonEventHandler(this.OnFieldNameDoubleClick);
			return;
			IL_1E31:
			this.CpyBtnTrkSysFeaturesHearClear_A36422 = (global::AcpUI.AcpCopyButton)target;
			return;
			IL_1E3E:
			this.RTDBtnTrkSysOneTouchIndex_A8618 = (global::AcpUI.AcpRtdButton)target;
			return;
			IL_1E4B:
			this.ExpanderTrunkingSystemChannelRangesMHzGrid = (global::System.Windows.Controls.Grid)target;
			return;
			IL_1E58:
			this.TrkSysOBTChannelAssignmentListRxSpacingKHz_A9004 = (global::AcpUI.AcpComboBox)target;
			this.TrkSysOBTChannelAssignmentListRxSpacingKHz_A9004.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_1E7C:
			this.CVBtnTrkSysASTRO25PTTWarningTimems_A8781 = (global::AcpUI.AcpCustomViewCheckBox)target;
			return;
			IL_1E89:
			this.TrkSysControlChannelsTxFrequencyMHz_A9535_Col = (global::Infragistics.Windows.DataPresenter.UnboundField)target;
			return;
			IL_1E96:
			this.CVBtnTrkSysStatusAliasStatusAliasText_A9193 = (global::AcpUI.AcpCustomViewCheckBox)target;
			return;
			IL_1EA3:
			this.RTDBtnTrkSysLabtoolTrunkingSystemSiteAliasListItemID_A19971 = (global::AcpUI.AcpRtdButton)target;
			return;
			IL_1EB0:
			this.TrkSysGeneralHomeWACNID_A8205 = (global::AcpUI.AcpTextBoxSpinnerDecHex)target;
			this.TrkSysGeneralHomeWACNID_A8205.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_1ED4:
			this.CVBtnTrkSysFeaturesPASelection_A42882 = (global::AcpUI.AcpCustomViewCheckBox)target;
			return;
			IL_1EE1:
			this.RTDBtnTrkSysASTRO25F2VoiceCapable_A1395 = (global::AcpUI.AcpRtdButton)target;
			return;
			IL_1EEE:
			this.TrkSysMessageAliasMessageAliasText_A8503_Col = (global::Infragistics.Windows.DataPresenter.UnboundField)target;
			return;
			IL_1EFB:
			this.gridExpanderTrunkingSystemMessageAliasTableSRecView = (global::System.Windows.Controls.Grid)target;
			return;
			IL_1F08:
			this.LblTrkSysDigitalPreambleLength_A8722 = (global::AcpUI.AcpLabel)target;
			this.LblTrkSysDigitalPreambleLength_A8722.MouseDoubleClick += new global::System.Windows.Input.MouseButtonEventHandler(this.OnFieldNameDoubleClick);
			return;
			IL_1F2C:
			this.TrkSysSecureMultikeyAutoKeyIDRx_A43185Comp = (global::AcpUI.AcpCheckBox)target;
			return;
			IL_1F39:
			this.RTDBtnTrkSysLabtoolTrunkingSystemMessageAliasListItemID_A19969 = (global::AcpUI.AcpRtdButton)target;
			return;
			IL_1F46:
			this.RTDBtnTrkSysASTRO25ResponsePendingTimesec_A8945 = (global::AcpUI.AcpRtdButton)target;
			return;
			IL_1F53:
			this.LblTrkSysASTRO25ForceUnmuteTimems_A8141 = (global::AcpUI.AcpLabel)target;
			this.LblTrkSysASTRO25ForceUnmuteTimems_A8141.MouseDoubleClick += new global::System.Windows.Input.MouseButtonEventHandler(this.OnFieldNameDoubleClick);
			return;
			IL_1F77:
			this.LblTrkSysDigitalDigitalModulatorType_A7858 = (global::AcpUI.AcpLabel)target;
			this.LblTrkSysDigitalDigitalModulatorType_A7858.MouseDoubleClick += new global::System.Windows.Input.MouseButtonEventHandler(this.OnFieldNameDoubleClick);
			return;
			IL_1F9B:
			this.GrpBoxExpanderTrunkingSystemFeaturesRemoteMonitorRadioTrace = (global::AcpUI.AcpGroupBox)target;
			return;
			IL_1FA8:
			this.CpyBtnTrkSysDigitalDigitalModulatorType_A7858 = (global::AcpUI.AcpCopyButton)target;
			return;
			IL_1FB5:
			this.LblTrkSysFeaturesEnable_A7968 = (global::AcpUI.AcpLabel)target;
			this.LblTrkSysFeaturesEnable_A7968.MouseDoubleClick += new global::System.Windows.Input.MouseButtonEventHandler(this.OnFieldNameDoubleClick);
			return;
			IL_1FD9:
			this.LblTrkSysGeneralKeyofTrunkingSystem_A12658 = (global::AcpUI.AcpLabel)target;
			this.LblTrkSysGeneralKeyofTrunkingSystem_A12658.MouseDoubleClick += new global::System.Windows.Input.MouseButtonEventHandler(this.OnFieldNameDoubleClick);
			return;
			IL_1FFD:
			this.TrkSysFeaturesTextMessagingService_A9373 = (global::AcpUI.AcpComboBox)target;
			this.TrkSysFeaturesTextMessagingService_A9373.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_2021:
			this.TrkSysASTRO25ChannelIDBaseFrequencyMHz_A7546 = (global::AcpUI.AcpTextBox)target;
			this.TrkSysASTRO25ChannelIDBaseFrequencyMHz_A7546.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_2045:
			this.RecNavToolbarExpanderTrunkingSystemChannelRangesMHz = (global::AcpUI.AcpChildRecNavToolbar)target;
			this.RecNavToolbarExpanderTrunkingSystemChannelRangesMHz.ModeClick += this.OnModeClick;
			return;
			IL_2069:
			this.TrkSysSiteAliasSystemNumber_A19669 = (global::AcpUI.AcpTextBoxSpinnerDecHex)target;
			this.TrkSysSiteAliasSystemNumber_A19669.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_208D:
			this.LblTrkSysGeneralUnitID_A12651 = (global::AcpUI.AcpLabel)target;
			this.LblTrkSysGeneralUnitID_A12651.MouseDoubleClick += new global::System.Windows.Input.MouseButtonEventHandler(this.OnFieldNameDoubleClick);
			return;
			IL_20B1:
			this.RTDBtnTrkSysDigitalPreambleLength_A8722 = (global::AcpUI.AcpRtdButton)target;
			return;
			IL_20BE:
			this.TrkSysDigitalHighDeviationTx_A19314Comp = (global::AcpUI.AcpCheckBox)target;
			return;
			IL_20CB:
			this.CpyBtnTrkSysFeatureLocationOnPTT_43026 = (global::AcpUI.AcpCopyButton)target;
			return;
			IL_20D8:
			this.LblTrkSysGeneralAskRequired_A44909 = (global::AcpUI.AcpLabel)target;
			this.LblTrkSysGeneralAskRequired_A44909.MouseDoubleClick += new global::System.Windows.Input.MouseButtonEventHandler(this.OnFieldNameDoubleClick);
			return;
			IL_20FC:
			this.TrkSysLabtoolTrunkingSystemStatusAliasTextListItemID_A19968Comp = (global::AcpUI.AcpLabel)target;
			return;
			IL_2109:
			this.TrkSysFeaturesGroupTMSEable_42804 = (global::AcpUI.AcpComboBox)target;
			this.TrkSysFeaturesGroupTMSEable_42804.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_212D:
			this.TrkSysASTRO25EndPhase2TDMATransmitOnOutOfRange_A37980 = (global::AcpUI.AcpCheckBox)target;
			this.TrkSysASTRO25EndPhase2TDMATransmitOnOutOfRange_A37980.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_2151:
			this.ExpanderTrunkingSystemChannelRangesMHzSRecView = (global::AcpUI.AcpGroupBox)target;
			return;
			IL_215E:
			this.CpyBtnTrkSysFeaturesDynamicRegroupingEnable_A7969 = (global::AcpUI.AcpCopyButton)target;
			return;
			IL_216B:
			this.CpyBtnTrkSysFeaturesSecureLED_A9071 = (global::AcpUI.AcpCopyButton)target;
			return;
			IL_2178:
			this.CpyBtnTrkSysASTRO25ValidateNACAgainstSystemID_A20608 = (global::AcpUI.AcpCopyButton)target;
			return;
			IL_2185:
			this.ExpanderTrunkingSystemMessageAliasTable = (global::AcpUI.AcpXamDataPresenter)target;
			return;
			IL_2192:
			this.CpyBtnTrkSysLabtoolTrunkingSystemOneTouchListItemID_A22633 = (global::AcpUI.AcpCopyButton)target;
			return;
			IL_219F:
			this.ExpanderTrunkingSystemASTRO25ChannelIDTable = (global::AcpUI.AcpXamDataPresenter)target;
			return;
			IL_21AC:
			this.CpyBtnTrkSysASTRO25ResponsePendingTimesec_A8945 = (global::AcpUI.AcpCopyButton)target;
			return;
			IL_21B9:
			this.TrkSysASTRO25F2VoiceCapable_A1395Comp = (global::AcpUI.AcpCheckBox)target;
			return;
			IL_21C6:
			this.TrkSysGeneralAskRequired_A44909Comp = (global::AcpUI.AcpCheckBox)target;
			return;
			IL_21D3:
			this.LblTrkSysTypeIIChannelSetupNPSPACChannelBandwidthkHz_A8571 = (global::AcpUI.AcpLabel)target;
			this.LblTrkSysTypeIIChannelSetupNPSPACChannelBandwidthkHz_A8571.MouseDoubleClick += new global::System.Windows.Input.MouseButtonEventHandler(this.OnFieldNameDoubleClick);
			return;
			IL_21F7:
			this.CVBtnTrkSysMessageAliasMessageAliasText_A8503 = (global::AcpUI.AcpCustomViewCheckBox)target;
			return;
			IL_2204:
			this.TrkSysASTRO25ChannelIDChannelSpacingkHz_A7660Comp = (global::AcpUI.AcpLabel)target;
			return;
			IL_2211:
			this.LblTrkSysDigitalF2TDMAFrameSyncBERThreshold_A1396 = (global::AcpUI.AcpLabel)target;
			this.LblTrkSysDigitalF2TDMAFrameSyncBERThreshold_A1396.MouseDoubleClick += new global::System.Windows.Input.MouseButtonEventHandler(this.OnFieldNameDoubleClick);
			return;
			IL_2235:
			this.RTDBtnTrkSysTypeIIChannelSetupChannelBandwidthkHz_A7654 = (global::AcpUI.AcpRtdButton)target;
			return;
			IL_2242:
			this.RTDBtnTrkSysGeneralSiteID_A9150 = (global::AcpUI.AcpRtdButton)target;
			return;
			IL_224F:
			this.LblTrkSysASTRO25ChannelIDTransmitOffsetMHz_A9416 = (global::AcpUI.AcpLabel)target;
			this.LblTrkSysASTRO25ChannelIDTransmitOffsetMHz_A9416.MouseDoubleClick += new global::System.Windows.Input.MouseButtonEventHandler(this.OnFieldNameDoubleClick);
			return;
			IL_2273:
			this.LblTrkSysFeaturesOTARadioAliasUpdateEnable_A43057 = (global::AcpUI.AcpLabel)target;
			this.LblTrkSysFeaturesOTARadioAliasUpdateEnable_A43057.MouseDoubleClick += new global::System.Windows.Input.MouseButtonEventHandler(this.OnFieldNameDoubleClick);
			return;
			IL_2297:
			this.LblTrkSysTypeIIChannelSetupChannelAssignmentType_A7652 = (global::AcpUI.AcpLabel)target;
			this.LblTrkSysTypeIIChannelSetupChannelAssignmentType_A7652.MouseDoubleClick += new global::System.Windows.Input.MouseButtonEventHandler(this.OnFieldNameDoubleClick);
			return;
			IL_22BB:
			this.CVBtnTrkSysSecureMultikeyDESXLTxRxDefault_A7833 = (global::AcpUI.AcpCustomViewCheckBox)target;
			return;
			IL_22C8:
			this.CVBtnTrkSysLabtoolTrunkingSystemSiteAliasListItemID_A19971 = (global::AcpUI.AcpCustomViewCheckBox)target;
			return;
			IL_22D5:
			this.LblTrkSysSiteAliasHomeRASWACNNumber_A20169 = (global::AcpUI.AcpLabel)target;
			this.LblTrkSysSiteAliasHomeRASWACNNumber_A20169.MouseDoubleClick += new global::System.Windows.Input.MouseButtonEventHandler(this.OnFieldNameDoubleClick);
			return;
			IL_22F9:
			this.TrkSysSecureMultikeyASTROOTAR_A7494 = (global::AcpUI.AcpCheckBox)target;
			this.TrkSysSecureMultikeyASTROOTAR_A7494.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_231D:
			this.CpyBtnTrkSysSecureMultikeyPrivateCallSecureClearStrapping_43477 = (global::AcpUI.AcpCopyButton)target;
			return;
			IL_232A:
			this.ExpanderTrunkingSystemStatusAliasTableSRecView = (global::AcpUI.AcpGroupBox)target;
			return;
			IL_2337:
			this.TrkSysSiteAliasSiteAliasNumber_A9145 = (global::AcpUI.AcpTextBoxSpinnerDecHex)target;
			this.TrkSysSiteAliasSiteAliasNumber_A9145.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_235B:
			this.ExpanderTrunkingSystemMessageAliasTableSRecView = (global::AcpUI.AcpGroupBox)target;
			return;
			IL_2368:
			this.TrkSysOBTChannelAssignmentListTxEndFrequencyMHz_A9529 = (global::AcpUI.AcpTextBox)target;
			this.TrkSysOBTChannelAssignmentListTxEndFrequencyMHz_A9529.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_238C:
			this.CVBtnTrkSysAstro25ChannelID_A24066 = (global::AcpUI.AcpCustomViewCheckBox)target;
			return;
			IL_2399:
			this.TrkSysLabtoolTrunkingSystemMessageAliasTextListItemID_A19970Comp = (global::AcpUI.AcpLabel)target;
			return;
			IL_23A6:
			this.CVBtnTrkSysASTRO25ForceUnmuteTimems_A8141 = (global::AcpUI.AcpCustomViewCheckBox)target;
			return;
			IL_23B3:
			this.LblTrkSysTypeIIChannelSetupSplinterChannel_A9175 = (global::AcpUI.AcpLabel)target;
			this.LblTrkSysTypeIIChannelSetupSplinterChannel_A9175.MouseDoubleClick += new global::System.Windows.Input.MouseButtonEventHandler(this.OnFieldNameDoubleClick);
			return;
			IL_23D7:
			this.TrkSysGeneralNonAdjacentSiteSearch_A8568 = (global::AcpUI.AcpCheckBox)target;
			this.TrkSysGeneralNonAdjacentSiteSearch_A8568.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_23FB:
			this.CVBtnTrkSysGeneralAskRequired_A44909 = (global::AcpUI.AcpCustomViewCheckBox)target;
			return;
			IL_2408:
			this.TrkSysASTRO25GeoFenceMode_42322Comp = (global::AcpUI.AcpLabel)target;
			return;
			IL_2415:
			this.RTDBtnTrkSysStatusAliasStatusAliasEnable_A9195 = (global::AcpUI.AcpRtdButton)target;
			return;
			IL_2422:
			this.TrkSysFeaturesRadioInhibit_A8833 = (global::AcpUI.AcpCheckBox)target;
			this.TrkSysFeaturesRadioInhibit_A8833.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_2446:
			this.TrkSysLabtoolTrunkingSystemAPCOChannelIdentifierListItemID_A19965 = (global::AcpUI.AcpComboBox)target;
			this.TrkSysLabtoolTrunkingSystemAPCOChannelIdentifierListItemID_A19965.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_246A:
			this.LblTrkSysFeaturesDTMFTimingTable_A7900 = (global::AcpUI.AcpLabel)target;
			this.LblTrkSysFeaturesDTMFTimingTable_A7900.MouseDoubleClick += new global::System.Windows.Input.MouseButtonEventHandler(this.OnFieldNameDoubleClick);
			return;
			IL_248E:
			this.CVBtnSiteSelectableAlertAliasList_A42100 = (global::AcpUI.AcpCustomViewCheckBox)target;
			return;
			IL_249B:
			this.RTDBtnTrkSysTypeIIChannelSetupChannelAssignmentType_A7652 = (global::AcpUI.AcpRtdButton)target;
			return;
			IL_24A8:
			this.TrkSysOneTouchButton_A19763 = (global::AcpUI.AcpLabel)target;
			this.TrkSysOneTouchButton_A19763.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_24CC:
			this.CVBtnTrkSysASTRO25ChannelIDChannelType_A1390 = (global::AcpUI.AcpCustomViewCheckBox)target;
			return;
			IL_24D9:
			num = (short)716177408;
			short num3 = num;
			this.CpyBtnTrkSysASTRO25ChannelIDTransmitOffsetSign_A9417 = (global::AcpUI.AcpCopyButton)target;
			return;
			IL_250F:
			this.RTDBtnTrkSysDigitalHighDeviationTx_A19314 = (global::AcpUI.AcpRtdButton)target;
			return;
			IL_251C:
			this.gridExpanderTrunkingSystemOneTouchTableSRecView = (global::System.Windows.Controls.Grid)target;
			return;
			IL_2529:
			this.GrpBoxExpanderTrunkingSystemFeaturesPseudo0 = (global::AcpUI.AcpGroupBox)target;
			return;
			IL_2536:
			this.TrkSysASTRO25ChannelIDTransmitOffsetSign_A9417 = (global::AcpUI.AcpComboBox)target;
			this.TrkSysASTRO25ChannelIDTransmitOffsetSign_A9417.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_255A:
			this.TrkSysLTEInterferingFreqPresent_A42198Comp = (global::AcpUI.AcpLabel)target;
			return;
			IL_2567:
			this.CpyBtnTrkSysASTRO25QuickFadeProtectms_A8807 = (global::AcpUI.AcpCopyButton)target;
			return;
			IL_2574:
			this.CVBtnTrkSysOBTChannelRange_A24072 = (global::AcpUI.AcpCustomViewCheckBox)target;
			return;
			IL_2581:
			this.CpyBtnTrkSysASTRO25ISPSequenceLengthsec_A8354 = (global::AcpUI.AcpCopyButton)target;
			return;
			IL_258E:
			this.CVBtnTrkSysFeaturesChannel_A7647 = (global::AcpUI.AcpCustomViewCheckBox)target;
			return;
			IL_259B:
			this.RecNavToolbarExpanderTrunkingSystemStatusAliasTable = (global::AcpUI.AcpChildRecNavToolbar)target;
			this.RecNavToolbarExpanderTrunkingSystemStatusAliasTable.ModeClick += this.OnModeClick;
			return;
			IL_25BF:
			this.LblTrkSysASTRO25WUIDValiditySupport_A41483 = (global::AcpUI.AcpLabel)target;
			this.LblTrkSysASTRO25WUIDValiditySupport_A41483.MouseDoubleClick += new global::System.Windows.Input.MouseButtonEventHandler(this.OnFieldNameDoubleClick);
			return;
			IL_25E3:
			this.TrkSysTypeIIChannelSetupLegacyTransitSystem_A8429Comp = (global::AcpUI.AcpCheckBox)target;
			return;
			IL_25F0:
			this.CpyBtnTrkSysSiteAliasSiteAliasType_A41343 = (global::AcpUI.AcpCopyButton)target;
			return;
			IL_25FD:
			this.TrkSysTypeIIChannelSetupChannelAssignmentType_A7652 = (global::AcpUI.AcpComboBox)target;
			this.TrkSysTypeIIChannelSetupChannelAssignmentType_A7652.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_2621:
			this.TrkSysOBTChannelAssignmentListTxEnable_A9517Comp = (global::AcpUI.AcpCheckBox)target;
			return;
			IL_262E:
			this.LblTrkSysSecureMultikeyInterconnectSecureClearStrapping_43478 = (global::AcpUI.AcpLabel)target;
			this.LblTrkSysSecureMultikeyInterconnectSecureClearStrapping_43478.MouseDoubleClick += new global::System.Windows.Input.MouseButtonEventHandler(this.OnFieldNameDoubleClick);
			return;
			IL_2652:
			this.TrkSysFeatureLocationOnPTT_43026 = (global::AcpUI.AcpCheckBox)target;
			this.TrkSysFeatureLocationOnPTT_43026.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_2676:
			this.TrkSysGeneralSystemType_A9252 = (global::AcpUI.AcpComboBox)target;
			this.TrkSysGeneralSystemType_A9252.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_269A:
			this.CpyBtnTrkSysFeaturesZone_A9717 = (global::AcpUI.AcpCopyButton)target;
			return;
			IL_26A7:
			this.TrkSysASTRO25EndPhase2TDMATransmitOnOutOfRange_A37980Comp = (global::AcpUI.AcpCheckBox)target;
			return;
			IL_26B4:
			this.RTDBtnTrkSysFeaturesGroupTMSEable_42804 = (global::AcpUI.AcpRtdButton)target;
			return;
			IL_26C1:
			this.GrpBoxExpanderTrunkingSystemGeneralPseudo0 = (global::AcpUI.AcpGroupBox)target;
			return;
			IL_26CE:
			this.CVBtnTrkSysFeaturesTxPowerLevel_A9557 = (global::AcpUI.AcpCustomViewCheckBox)target;
			return;
			IL_26DB:
			this.TrkSysASTRO25ChannelIDTransmitOffsetMHz_A9416_Col = (global::Infragistics.Windows.DataPresenter.UnboundField)target;
			return;
			IL_26E8:
			this.HLinkBroadband = (global::System.Windows.Documents.Hyperlink)target;
			this.HLinkBroadband.Click += this.HLinkClick;
			return;
			IL_270C:
			this.CVBtnTrkSysLabtoolTrunkingSystemMessageAliasTextListItemID_A19970 = (global::AcpUI.AcpCustomViewCheckBox)target;
			return;
			IL_2719:
			this.TrkSysASTRO25WUIDValiditySupport_A41483 = (global::AcpUI.AcpCheckBox)target;
			this.TrkSysASTRO25WUIDValiditySupport_A41483.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_273D:
			this.CVBtnTrkSysFeaturesHearClear_A36422 = (global::AcpUI.AcpCustomViewCheckBox)target;
			return;
			IL_274A:
			this.CpyBtnTrkSysGeneralSystemKeyType_A38853 = (global::AcpUI.AcpCopyButton)target;
			return;
			IL_2757:
			this.RTDBtnTrkSysGeneralConnectToneHz_A7710 = (global::AcpUI.AcpRtdButton)target;
			return;
			IL_2764:
			this.TrkSysASTRO25ChannelIDTransmitOffsetSign_A9417_Col = (global::Infragistics.Windows.DataPresenter.UnboundField)target;
			return;
			IL_2771:
			this.CpyBtnTrkSysFeaturesGroupTMSEable_42804 = (global::AcpUI.AcpCopyButton)target;
			return;
			IL_277E:
			this.TrkPerFeaturesOTARadioAliasType_42854Comp = (global::AcpUI.AcpLabel)target;
			return;
			IL_278B:
			this.LblTrkSysTypeIIChannelSetupChannelBandwidthkHz_A7654 = (global::AcpUI.AcpLabel)target;
			this.LblTrkSysTypeIIChannelSetupChannelBandwidthkHz_A7654.MouseDoubleClick += new global::System.Windows.Input.MouseButtonEventHandler(this.OnFieldNameDoubleClick);
			return;
			IL_27AF:
			this.RTDBtnTrkSysGeneralRFSSID_A8980 = (global::AcpUI.AcpRtdButton)target;
			return;
			IL_27BC:
			this.TrkSysSecureMultikeyVirtualPartnerSecureClearStrapping_A43670 = (global::AcpUI.AcpComboBox)target;
			this.TrkSysSecureMultikeyVirtualPartnerSecureClearStrapping_A43670.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_27E0:
			this.RTDBtnTrkSysASTRO25ChannelIDChannelType_A1390 = (global::AcpUI.AcpRtdButton)target;
			return;
			IL_27ED:
			this.CpyBtnTrkSysOBTChannelAssignmentListRxEndFrequencyMHz_A9012 = (global::AcpUI.AcpCopyButton)target;
			return;
			IL_27FA:
			this.LblTrkSysLabtoolTrunkingSystemControlChannelListItemID_A19964 = (global::AcpUI.AcpLabel)target;
			this.LblTrkSysLabtoolTrunkingSystemControlChannelListItemID_A19964.MouseDoubleClick += new global::System.Windows.Input.MouseButtonEventHandler(this.OnFieldNameDoubleClick);
			return;
			IL_281E:
			this.CpyBtnTrkSysSiteAliasSiteAliasEnable_A9148 = (global::AcpUI.AcpCopyButton)target;
			return;
			IL_282B:
			this.CVBtnTrkSysSecureMultikeyPatchKeySelect_A8694 = (global::AcpUI.AcpCustomViewCheckBox)target;
			return;
			IL_2838:
			this.HLinkStatusAlias = (global::System.Windows.Documents.Hyperlink)target;
			this.HLinkStatusAlias.Click += this.HLinkClick;
			return;
			IL_285C:
			this.LblTrkSysGeneralHomeWACNID_A8205 = (global::AcpUI.AcpLabel)target;
			this.LblTrkSysGeneralHomeWACNID_A8205.MouseDoubleClick += new global::System.Windows.Input.MouseButtonEventHandler(this.OnFieldNameDoubleClick);
			return;
			IL_2880:
			this.CpyBtnTrkSysSiteAliasSiteAliasNumber_A9145 = (global::AcpUI.AcpCopyButton)target;
			return;
			IL_288D:
			this.TrkSysAstro25ChannelID_A24066 = (global::AcpUI.AcpLabel)target;
			this.TrkSysAstro25ChannelID_A24066.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_28B1:
			this.CpyBtnTrkSysControlChannelsTxFrequencyMHz_A9535 = (global::AcpUI.AcpCopyButton)target;
			return;
			IL_28BE:
			this.CpyBtnTrkSysSecureMultikeyVirtualPartnerKeySelect_A43669 = (global::AcpUI.AcpCopyButton)target;
			return;
			IL_28CB:
			this.TrkSysDigitalF2TDMAFrameSyncBERThreshold_A1396Comp = (global::AcpUI.AcpLabel)target;
			return;
			IL_28D8:
			this.CpyBtnTrkSysASTRO25EndF2TDMATransmitOnOutOfRange_A1394 = (global::AcpUI.AcpCopyButton)target;
			return;
			IL_28E5:
			this.LblTrkSysFeatureLocationOnPTT_43026 = (global::AcpUI.AcpLabel)target;
			this.LblTrkSysFeatureLocationOnPTT_43026.MouseDoubleClick += new global::System.Windows.Input.MouseButtonEventHandler(this.OnFieldNameDoubleClick);
			return;
			IL_2909:
			this.TrkSysLabtoolTrunkingSystemStatusAliasListItemID_A19967 = (global::AcpUI.AcpComboBox)target;
			this.TrkSysLabtoolTrunkingSystemStatusAliasListItemID_A19967.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_292D:
			this.CVBtnTrkSysMessageAliasMessageAliasNumber_A8500 = (global::AcpUI.AcpCustomViewCheckBox)target;
			return;
			IL_293A:
			this.CVBtnTrkSysOBTChannelAssignmentListTxStartFrequencyMHz_A9568 = (global::AcpUI.AcpCustomViewCheckBox)target;
			return;
			IL_2947:
			this.Position_37454 = (global::Infragistics.Windows.DataPresenter.UnboundField)target;
			return;
			IL_2954:
			this.TrkSysLabtoolTrunkingSystemControlChannelListItemID_A19964Comp = (global::AcpUI.AcpLabel)target;
			return;
			IL_2961:
			this.RTDBtnTrkSysASTRO25WUIDValiditySupport_A41483 = (global::AcpUI.AcpRtdButton)target;
			return;
			IL_296E:
			this.CVBtnTrkSysASTRO25ChannelIDTransmitOffsetMHz_A9416 = (global::AcpUI.AcpCustomViewCheckBox)target;
			return;
			IL_297B:
			this.TrkSysGeneralSystemKeyPresent_A9241Comp = (global::AcpUI.AcpLabel)target;
			return;
			IL_2988:
			this.TrkSysASTRO25ChannelIDChannelSpacingkHz_A7660_Col = (global::Infragistics.Windows.DataPresenter.UnboundField)target;
			return;
			IL_2995:
			this.LblTrkSysASTRO25ChannelIDIdentifierEnable_A8222 = (global::AcpUI.AcpLabel)target;
			this.LblTrkSysASTRO25ChannelIDIdentifierEnable_A8222.MouseDoubleClick += new global::System.Windows.Input.MouseButtonEventHandler(this.OnFieldNameDoubleClick);
			return;
			IL_29B9:
			this.RTDBtnTrkSysLabtoolTrunkingSystemOneTouchListItemID_A22633 = (global::AcpUI.AcpRtdButton)target;
			return;
			IL_29C6:
			this.LblTrkSysSecureMultikeyDESXLTxRxDefault_A7833 = (global::AcpUI.AcpLabel)target;
			this.LblTrkSysSecureMultikeyDESXLTxRxDefault_A7833.MouseDoubleClick += new global::System.Windows.Input.MouseButtonEventHandler(this.OnFieldNameDoubleClick);
			return;
			IL_29EA:
			this.RTDBtnTrkSysOneTouchFeature_A8614 = (global::AcpUI.AcpRtdButton)target;
			return;
			IL_29F7:
			this.TrkPerFeaturesOTARadioAliasType_42854 = (global::AcpUI.AcpComboBox)target;
			this.TrkPerFeaturesOTARadioAliasType_42854.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_2A1B:
			this.ExpanderTrunkingSystemASTRO25ChannelIDTableGrid = (global::System.Windows.Controls.Grid)target;
			return;
			IL_2A28:
			this.SiteSelectableAlertList_A42060 = (global::AcpUI.AcpComboBox)target;
			this.SiteSelectableAlertList_A42060.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_2A4C:
			this.TrkSysOBTChannelAssignmentListRxEnable_A9001Comp = (global::AcpUI.AcpCheckBox)target;
			return;
			IL_2A59:
			this.TrkSysGeneralFailsoftConnectToneHz_A8007 = (global::AcpUI.AcpComboBox)target;
			this.TrkSysGeneralFailsoftConnectToneHz_A8007.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_2A7D:
			this.CVBtnTrkSysMessageAliasMessageAliasEnable_A8505 = (global::AcpUI.AcpCustomViewCheckBox)target;
			return;
			IL_2A8A:
			this.TrkSysASTRO25ChannelIDTransmitOffsetMHz_A9416Comp = (global::AcpUI.AcpLabel)target;
			return;
			IL_2A97:
			this.Position_37455 = (global::Infragistics.Windows.DataPresenter.UnboundField)target;
			return;
			IL_2AA4:
			this.ExpanderTrunkingSystemASTRO25ChannelIDTableSRecView = (global::AcpUI.AcpGroupBox)target;
			return;
			IL_2AB1:
			this.TrkSysGeneralConnectToneHz_A7710 = (global::AcpUI.AcpComboBox)target;
			this.TrkSysGeneralConnectToneHz_A7710.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_2AD5:
			this.CVBtnTrkSysSecureMultikeyInterconnectKeySelect_A8298 = (global::AcpUI.AcpCustomViewCheckBox)target;
			return;
			IL_2AE2:
			this.GrpBoxExpanderTrunkingSystemSecureMultikeyPseudo6 = (global::AcpUI.AcpGroupBox)target;
			return;
			IL_2AEF:
			this.CVBtnTrkSysFeaturesGroupTMSEable_42804 = (global::AcpUI.AcpCustomViewCheckBox)target;
			return;
			IL_2AFC:
			this.CpyBtnTrkSysLabtoolTrunkingSystemStatusAliasListItemID_A19967 = (global::AcpUI.AcpCopyButton)target;
			return;
			IL_2B09:
			this.RTDBtnTrkSysASTRO25ValidateNACAgainstSystemID_A20608 = (global::AcpUI.AcpRtdButton)target;
			return;
			IL_2B16:
			this.TrkSysLabtoolTrunkingSystemSiteAliasListItemID_A19971Comp = (global::AcpUI.AcpLabel)target;
			return;
			IL_2B23:
			this.RTDBtnTrkSysASTRO25GeoFenceMode_42322 = (global::AcpUI.AcpRtdButton)target;
			return;
			IL_2B30:
			this.CpyBtnTrkSysGeneralHomeWACNID_A8205 = (global::AcpUI.AcpCopyButton)target;
			return;
			IL_2B3D:
			this.LblTrkSysLabtoolTrunkingSystemStatusAliasListItemID_A19967 = (global::AcpUI.AcpLabel)target;
			this.LblTrkSysLabtoolTrunkingSystemStatusAliasListItemID_A19967.MouseDoubleClick += new global::System.Windows.Input.MouseButtonEventHandler(this.OnFieldNameDoubleClick);
			return;
			IL_2B61:
			this.CpyBtnTrkSysSiteAliasSystemNumber_A19669 = (global::AcpUI.AcpCopyButton)target;
			return;
			IL_2B6E:
			this.ExpanderTrunkingSystemSiteAliasTableGrid = (global::System.Windows.Controls.Grid)target;
			return;
			IL_2B7B:
			this.RTDBtnTrkSysGeneralNonAdjacentSiteSearch_A8568 = (global::AcpUI.AcpRtdButton)target;
			return;
			IL_2B88:
			this.TrkSysDigitalDigitalModulatorType_A7858 = (global::AcpUI.AcpComboBox)target;
			this.TrkSysDigitalDigitalModulatorType_A7858.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_2BAC:
			this.CpyBtnTrkSysGeneralRFSSDebounceTimersec_A8979 = (global::AcpUI.AcpCopyButton)target;
			return;
			IL_2BB9:
			this.LblTrkSysSecureMultikeyASTROOTAR_A7494 = (global::AcpUI.AcpLabel)target;
			this.LblTrkSysSecureMultikeyASTROOTAR_A7494.MouseDoubleClick += new global::System.Windows.Input.MouseButtonEventHandler(this.OnFieldNameDoubleClick);
			return;
			IL_2BDD:
			this.TrkSysStatusAliasStatusAliasText_A9193 = (global::AcpUI.AcpTextBox)target;
			this.TrkSysStatusAliasStatusAliasText_A9193.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_2C01:
			this.CpyBtnTrkSysFeaturesRadioInhibit_A8833 = (global::AcpUI.AcpCopyButton)target;
			return;
			IL_2C0E:
			this.CpyBtnTrkSysSiteAliasSiteAliasText_A9146 = (global::AcpUI.AcpCopyButton)target;
			return;
			IL_2C1B:
			this.gridExpanderTrunkingSystemControlChannelsTableSRecView = (global::System.Windows.Controls.Grid)target;
			return;
			IL_2C28:
			this.TrkSysSecureMultikeyVirtualPartnerSecureClearStrapping_A43670Comp = (global::AcpUI.AcpLabel)target;
			return;
			IL_2C35:
			this.RTDBtnTrkSysOneTouchAbbreviatedOneTouchAlias_A8622 = (global::AcpUI.AcpRtdButton)target;
			return;
			IL_2C42:
			this.TrkSysSiteAliasHomeRASWACNNumber_A20169 = (global::AcpUI.AcpTextBoxSpinnerDecHex)target;
			this.TrkSysSiteAliasHomeRASWACNNumber_A20169.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_2C66:
			this.CVBtnTrkSysGeneralKeyofTrunkingSystem_A12658 = (global::AcpUI.AcpCustomViewCheckBox)target;
			return;
			IL_2C73:
			this.CVBtnTrkSysFeaturesEnable_A7968 = (global::AcpUI.AcpCustomViewCheckBox)target;
			return;
			IL_2C80:
			this.TrkSysASTRO25BusyUpdateTimesec_A7574Comp = (global::AcpUI.AcpLabel)target;
			return;
			IL_2C8D:
			this.LblTrkSysFeaturesGroupTMSEable_42804 = (global::AcpUI.AcpLabel)target;
			this.LblTrkSysFeaturesGroupTMSEable_42804.MouseDoubleClick += new global::System.Windows.Input.MouseButtonEventHandler(this.OnFieldNameDoubleClick);
			return;
			IL_2CB1:
			this.TrkSysSecureMultikeyPrivateCallSecureClearStrapping_43477Comp = (global::AcpUI.AcpLabel)target;
			return;
			IL_2CBE:
			this.CpyBtnTrkSysGeneralSiteID_A9150 = (global::AcpUI.AcpCopyButton)target;
			return;
			IL_2CCB:
			this.LblTrkSysSecureMultikeyOTARTx_A8676 = (global::AcpUI.AcpLabel)target;
			this.LblTrkSysSecureMultikeyOTARTx_A8676.MouseDoubleClick += new global::System.Windows.Input.MouseButtonEventHandler(this.OnFieldNameDoubleClick);
			return;
			IL_2CEF:
			this.CVBtnTrkPerFeaturesOTARadioAliasType_42854 = (global::AcpUI.AcpCustomViewCheckBox)target;
			return;
			IL_2CFC:
			this.TrkSysFeaturesChannel_A7647 = (global::AcpUI.AcpComboBox)target;
			this.TrkSysFeaturesChannel_A7647.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_2D20:
			this.TrkSysSecureMultikeyInterconnectKeySelect_A8298 = (global::AcpUI.AcpComboBox)target;
			this.TrkSysSecureMultikeyInterconnectKeySelect_A8298.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_2D44:
			this.CpyBtnTrkSysASTRO25MaximumSlotSizems_A8478 = (global::AcpUI.AcpCopyButton)target;
			return;
			IL_2D51:
			this.RTDBtnTrkSysFeaturesEmergencyAlarmRxIndicator_A7932 = (global::AcpUI.AcpRtdButton)target;
			return;
			IL_2D5E:
			this.CpyBtnTrkSysFeaturesTextMessagingService_A9373 = (global::AcpUI.AcpCopyButton)target;
			return;
			IL_2D6B:
			this.RTDBtnTrkSysSiteAliasSiteAliasType_A41343 = (global::AcpUI.AcpRtdButton)target;
			return;
			IL_2D78:
			this.TrkSysSiteAliasSiteAliasType_A41343 = (global::AcpUI.AcpComboBox)target;
			this.TrkSysSiteAliasSiteAliasType_A41343.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_2D9C:
			this.RTDBtnTrkSysDigitalF2TDMAFrameSyncBERThreshold_A1396 = (global::AcpUI.AcpRtdButton)target;
			return;
			IL_2DA9:
			this.TrkSysStatusAliasStatusAliasEnable_A9195Comp = (global::AcpUI.AcpCheckBox)target;
			return;
			IL_2DB6:
			this.CVBtnTrkSysGeneralSystemType_A9252 = (global::AcpUI.AcpCustomViewCheckBox)target;
			return;
			IL_2DC3:
			this.CVBtnTrkSysTypeIIChannelSetupShuffledBandPlan_A9128 = (global::AcpUI.AcpCustomViewCheckBox)target;
			return;
			IL_2DD0:
			this.CpyBtnTrkSysOBTChannelAssignmentListTxEndFrequencyMHz_A9529 = (global::AcpUI.AcpCopyButton)target;
			return;
			IL_2DDD:
			this.TrkSysLabtoolTrunkingSystemMessageAliasListItemID_A19969Comp = (global::AcpUI.AcpLabel)target;
			return;
			IL_2DEA:
			this.RTDBtnTrkSysOBTChannelAssignmentListRxSpacingKHz_A9004 = (global::AcpUI.AcpRtdButton)target;
			return;
			IL_2DF7:
			this.LblTrkSysGeneralRFSSID_A8980 = (global::AcpUI.AcpLabel)target;
			this.LblTrkSysGeneralRFSSID_A8980.MouseDoubleClick += new global::System.Windows.Input.MouseButtonEventHandler(this.OnFieldNameDoubleClick);
			return;
			IL_2E1B:
			this.RTDBtnTrkSysOBTChannelAssignmentListTxSpacingKHz_A9520 = (global::AcpUI.AcpRtdButton)target;
			return;
			IL_2E28:
			this.TrkSysMsgAlias_A24069Comp = (global::AcpUI.AcpLabel)target;
			return;
			IL_2E35:
			this.CVBtnTrkSysASTRO25ChannelIDIdentifierEnable_A8222 = (global::AcpUI.AcpCustomViewCheckBox)target;
			return;
			IL_2E42:
			this.LblTrkSysFeaturesTxBaseTimeSec_A9512 = (global::AcpUI.AcpLabel)target;
			this.LblTrkSysFeaturesTxBaseTimeSec_A9512.MouseDoubleClick += new global::System.Windows.Input.MouseButtonEventHandler(this.OnFieldNameDoubleClick);
			return;
			IL_2E66:
			this.TrkSysStatusAliasStatusAliasNumber_A9190_Col = (global::Infragistics.Windows.DataPresenter.UnboundField)target;
			return;
			IL_2E73:
			this.CVBtnTrkSysGeneralNonAdjacentSiteSearch_A8568 = (global::AcpUI.AcpCustomViewCheckBox)target;
			return;
			IL_2E80:
			this.RTDBtnTrkSysASTRO25MaximumSlotSizems_A8478 = (global::AcpUI.AcpRtdButton)target;
			return;
			IL_2E8D:
			this.LblTrkSysFeaturesTextMessagingService_A9373 = (global::AcpUI.AcpLabel)target;
			this.LblTrkSysFeaturesTextMessagingService_A9373.MouseDoubleClick += new global::System.Windows.Input.MouseButtonEventHandler(this.OnFieldNameDoubleClick);
			return;
			IL_2EB1:
			this.RTDBtnTrkSysFeaturesEnable_A7968 = (global::AcpUI.AcpRtdButton)target;
			return;
			IL_2EBE:
			this.RTDBtnTrkSysFeaturesChannel_A7647 = (global::AcpUI.AcpRtdButton)target;
			return;
			IL_2ECB:
			this.ExpanderTrunkingSystemControlChannelsTableTableView = (global::AcpUI.AcpGroupBox)target;
			return;
			IL_2ED8:
			this.CVBtnTrkSysSecureMultikeyDynamicAGKeySelect_A7914 = (global::AcpUI.AcpCustomViewCheckBox)target;
			return;
			IL_2EE5:
			this.RTDBtnTrkSysLabtoolTrunkingSystemStatusAliasTextListItemID_A19968 = (global::AcpUI.AcpRtdButton)target;
			return;
			IL_2EF2:
			this.LblTrkSysControlChannelsRxFrequencyMHz_A9018 = (global::AcpUI.AcpLabel)target;
			this.LblTrkSysControlChannelsRxFrequencyMHz_A9018.MouseDoubleClick += new global::System.Windows.Input.MouseButtonEventHandler(this.OnFieldNameDoubleClick);
			return;
			IL_2F16:
			this.SiteSelectableAlertAliasList_A42100 = (global::AcpUI.AcpComboBox)target;
			this.SiteSelectableAlertAliasList_A42100.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_2F3A:
			this.TrkSysGeneralRFSSDebounceTimersec_A8979Comp = (global::AcpUI.AcpLabel)target;
			return;
			IL_2F47:
			this.TrkSysASTRO25ForceUnmuteTimems_A8141 = (global::AcpUI.AcpTextBoxSpinner)target;
			this.TrkSysASTRO25ForceUnmuteTimems_A8141.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_2F6B:
			this.TrkSysControlChannelsRxFrequencyMHz_A9018Comp = (global::AcpUI.AcpLabel)target;
			return;
			IL_2F78:
			this.RecNavToolbarExpanderTrunkingSystemOneTouchTable = (global::AcpUI.AcpChildRecNavToolbar)target;
			this.RecNavToolbarExpanderTrunkingSystemOneTouchTable.ModeClick += this.OnModeClick;
			return;
			IL_2F9C:
			this.RTDBtnTrkSysOBTChannelAssignmentListRxStartFrequencyMHz_A9029 = (global::AcpUI.AcpRtdButton)target;
			return;
			IL_2FA9:
			this.TrkSysASTRO25PTTWarningTimems_A8781Comp = (global::AcpUI.AcpLabel)target;
			return;
			IL_2FB6:
			this.RTDBtnTrkSysFeatureLocationOnPTT_43026 = (global::AcpUI.AcpRtdButton)target;
			return;
			IL_2FC3:
			this.TrkSysFeaturesICUAAutoResetTimesec_A7515Comp = (global::AcpUI.AcpLabel)target;
			return;
			IL_2FD0:
			this.ExpanderTrunkingSystemSecureMultikey = (global::AcpUI.AcpExpander)target;
			return;
			IL_2FDD:
			this.TrkSysOBTChannelAssignmentListRxEndFrequencyMHz_A9012 = (global::AcpUI.AcpTextBox)target;
			this.TrkSysOBTChannelAssignmentListRxEndFrequencyMHz_A9012.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_3001:
			this.TrkSysLabtoolTrunkingSystemOneTouchListItemID_A22633Comp = (global::AcpUI.AcpLabel)target;
			return;
			IL_300E:
			this.CVBtnTrkSysStatusAliasStatusAliasEnable_A9195 = (global::AcpUI.AcpCustomViewCheckBox)target;
			return;
			IL_301B:
			this.TrkSysGeneralSystemID_A9239 = (global::AcpUI.AcpTextBoxSpinnerDecHex)target;
			this.TrkSysGeneralSystemID_A9239.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_303F:
			this.CVBtnTrkSysOBTChannelAssignmentListTxSpacingKHz_A9520 = (global::AcpUI.AcpCustomViewCheckBox)target;
			return;
			IL_304C:
			this.CpyBtnSiteSelectableAlertList_A42060 = (global::AcpUI.AcpCopyButton)target;
			return;
			IL_3059:
			this.TrkSysFeaturesPASelection_A42882 = (global::AcpUI.AcpComboBox)target;
			this.TrkSysFeaturesPASelection_A42882.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_307D:
			this.LblTrkSysOneTouchIndex_A8618 = (global::AcpUI.AcpLabel)target;
			this.LblTrkSysOneTouchIndex_A8618.MouseDoubleClick += new global::System.Windows.Input.MouseButtonEventHandler(this.OnFieldNameDoubleClick);
			return;
			IL_30A1:
			this.TrkSysSecureMultikeyFailsoftKeySelect_A8012Comp = (global::AcpUI.AcpLabel)target;
			return;
			IL_30AE:
			this.LblTrkSysASTRO25ChannelIDChannelType_A1390 = (global::AcpUI.AcpLabel)target;
			this.LblTrkSysASTRO25ChannelIDChannelType_A1390.MouseDoubleClick += new global::System.Windows.Input.MouseButtonEventHandler(this.OnFieldNameDoubleClick);
			return;
			IL_30D2:
			this.TrkSysTypeIIChannelSetupChannelBandwidthkHz_A7654Comp = (global::AcpUI.AcpLabel)target;
			return;
			IL_30DF:
			this.CVBtnTrkSysSecureMultikeyPrivateCallKeySelect_A8757 = (global::AcpUI.AcpCustomViewCheckBox)target;
			return;
			IL_30EC:
			this.TrkSysSiteAlias_A24071_Col = (global::Infragistics.Windows.DataPresenter.UnboundField)target;
			return;
			IL_30F9:
			this.CpyBtnTrkSysASTRO25DefaultRCMAddress_A7813 = (global::AcpUI.AcpCopyButton)target;
			return;
			IL_3106:
			this.RTDBtnTrkSysLTEInterferingFreqPresent_A42198 = (global::AcpUI.AcpRtdButton)target;
			return;
			IL_3113:
			this.LblTrkSysOBTChannelAssignmentListTxEnable_A9517 = (global::AcpUI.AcpLabel)target;
			this.LblTrkSysOBTChannelAssignmentListTxEnable_A9517.MouseDoubleClick += new global::System.Windows.Input.MouseButtonEventHandler(this.OnFieldNameDoubleClick);
			return;
			IL_3137:
			this.CVBtnTrkSysASTRO25GeoFenceMode_42322 = (global::AcpUI.AcpCustomViewCheckBox)target;
			return;
			IL_3144:
			this.CpyBtnTrkSysStatusAlias_A24070 = (global::AcpUI.AcpCopyButton)target;
			return;
			IL_3151:
			this.RTDBtnTrkSysFeaturesTextMessagingService_A9373 = (global::AcpUI.AcpRtdButton)target;
			return;
			IL_315E:
			this.TrkSysLabtoolTrunkingSystemAPCOChannelIdentifierListItemID_A19965Comp = (global::AcpUI.AcpLabel)target;
			return;
			IL_316B:
			this.TrkSysGeneralUnitID_A12651Comp = (global::AcpUI.AcpTextBoxDecHex)target;
			return;
			IL_3178:
			this.CVBtnTrkSysASTRO25F2VoiceCapable_A1395 = (global::AcpUI.AcpCustomViewCheckBox)target;
			return;
			IL_3185:
			this.TrkSysOneTouchButton_A19763Comp = (global::AcpUI.AcpLabel)target;
			return;
			IL_3192:
			this.TrkSysStatusAliasStatusAliasText_A9193_Col = (global::Infragistics.Windows.DataPresenter.UnboundField)target;
			return;
			IL_319F:
			this.CpyBtnTrkSysLabtoolNetworkID_A8565 = (global::AcpUI.AcpCopyButton)target;
			return;
			IL_31AC:
			this.CVBtnTrkSysSecureMultikeyVirtualPartnerSecureClearStrapping_A43670 = (global::AcpUI.AcpCustomViewCheckBox)target;
			return;
			IL_31B9:
			this.TrkSysSecureMultikeyKMFProfileIndex_A8382Comp = (global::AcpUI.AcpLabel)target;
			return;
			IL_31C6:
			this.LblTrkSysLabtoolTrunkingSystemStatusAliasTextListItemID_A19968 = (global::AcpUI.AcpLabel)target;
			this.LblTrkSysLabtoolTrunkingSystemStatusAliasTextListItemID_A19968.MouseDoubleClick += new global::System.Windows.Input.MouseButtonEventHandler(this.OnFieldNameDoubleClick);
			return;
			IL_31EA:
			this.CpyBtnTrkSysFeaturesTxPowerLevel_A9557 = (global::AcpUI.AcpCopyButton)target;
			return;
			IL_31F7:
			this.CpyBtnTrkSysLabtoolTrunkingSystemSiteAliasTextListItemID_A19972 = (global::AcpUI.AcpCopyButton)target;
			return;
			IL_3204:
			this.CVBtnTrkSysFeaturesEmergencyAlarmRxIndicator_A7932 = (global::AcpUI.AcpCustomViewCheckBox)target;
			return;
			IL_3211:
			this.TrkSysASTRO25ValidateNACAgainstSystemID_A20608Comp = (global::AcpUI.AcpCheckBox)target;
			return;
			IL_321E:
			this.RTDBtnTrkSysGeneralSystemID_A9239 = (global::AcpUI.AcpRtdButton)target;
			return;
			IL_322B:
			this.TrkSysMessageAliasMessageAliasText_A8503 = (global::AcpUI.AcpTextBox)target;
			this.TrkSysMessageAliasMessageAliasText_A8503.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_324F:
			this.CVBtnTrkSysOBTChannelAssignmentListRxSpacingKHz_A9004 = (global::AcpUI.AcpCustomViewCheckBox)target;
			return;
			IL_325C:
			this.CVBtnTrkSysSiteAliasSiteAliasNumber_A9145 = (global::AcpUI.AcpCustomViewCheckBox)target;
			return;
			IL_3269:
			this.LblTrkSysSiteAliasSiteAliasText_A9146 = (global::AcpUI.AcpLabel)target;
			this.LblTrkSysSiteAliasSiteAliasText_A9146.MouseDoubleClick += new global::System.Windows.Input.MouseButtonEventHandler(this.OnFieldNameDoubleClick);
			return;
			IL_328D:
			this.CVBtnTrkSysSiteAliasSiteAliasType_A41343 = (global::AcpUI.AcpCustomViewCheckBox)target;
			return;
			IL_329A:
			this.RTDBtnTrkSysGeneralRFSSResponseTimems_A8981 = (global::AcpUI.AcpRtdButton)target;
			return;
			IL_32A7:
			this.TrkSysLabtoolTrunkingSystemOneTouchListItemID_A22633 = (global::AcpUI.AcpComboBox)target;
			this.TrkSysLabtoolTrunkingSystemOneTouchListItemID_A22633.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_32CB:
			this.CpyBtnTrkSysLabtoolTrunkingSystemSiteAliasListItemID_A19971 = (global::AcpUI.AcpCopyButton)target;
			return;
			IL_32D8:
			this.TrkSysSiteAliasRFSSAliasNumber_A8978 = (global::AcpUI.AcpTextBoxSpinner)target;
			this.TrkSysSiteAliasRFSSAliasNumber_A8978.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_32FC:
			this.CpyBtnTrkSysGeneralSystemType_A9252 = (global::AcpUI.AcpCopyButton)target;
			return;
			IL_3309:
			this.TrkSysASTRO25ForceUnmuteTimems_A8141Comp = (global::AcpUI.AcpLabel)target;
			return;
			IL_3316:
			this.CVBtnTrkSysASTRO25Phase2VoiceCapable_A37972 = (global::AcpUI.AcpCustomViewCheckBox)target;
			return;
			IL_3323:
			this.CpyBtnTrkSysStatusAliasStatusAliasNumber_A9190 = (global::AcpUI.AcpCopyButton)target;
			return;
			IL_3330:
			this.RTDBtnTrkSysStatusAliasStatusAliasNumber_A9190 = (global::AcpUI.AcpRtdButton)target;
			return;
			IL_333D:
			this.RTDBtnTrkSysLabtoolTrunkingSystemStatusAliasListItemID_A19967 = (global::AcpUI.AcpRtdButton)target;
			return;
			IL_334A:
			this.TrkSysLabtoolTrunkingSystemMessageAliasTextListItemID_A19970 = (global::AcpUI.AcpComboBox)target;
			this.TrkSysLabtoolTrunkingSystemMessageAliasTextListItemID_A19970.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_336E:
			this.GrpBoxExpanderTrunkingSystemFeaturesDynamicRegrouping = (global::AcpUI.AcpGroupBox)target;
			return;
			IL_337B:
			this.LblSiteSelectableAlertAliasList_A42100 = (global::AcpUI.AcpLabel)target;
			this.LblSiteSelectableAlertAliasList_A42100.MouseDoubleClick += new global::System.Windows.Input.MouseButtonEventHandler(this.OnFieldNameDoubleClick);
			return;
			IL_339F:
			this.TrkSysOBTChannelRange_A24072_Col = (global::Infragistics.Windows.DataPresenter.UnboundField)target;
			return;
			IL_33AC:
			this.CpyBtnTrkSysGeneralFailsoftConnectToneHz_A8007 = (global::AcpUI.AcpCopyButton)target;
			return;
			IL_33B9:
			this.TrkSysMessageAliasMessageAliasEnable_A8505Comp = (global::AcpUI.AcpCheckBox)target;
			return;
			IL_33C6:
			this.CpyBtnTrkSysASTRO25PTTWarningTimems_A8781 = (global::AcpUI.AcpCopyButton)target;
			return;
			IL_33D3:
			this.ExpanderTrunkingSystemMessageAliasTableGrid = (global::System.Windows.Controls.Grid)target;
			return;
			IL_33E0:
			this.TrkSysASTRO25ChannelIDChannelSpacingkHz_A7660 = (global::AcpUI.AcpTextBox)target;
			this.TrkSysASTRO25ChannelIDChannelSpacingkHz_A7660.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_3404:
			this.LblTrkSysLabtoolTrunkingSystemMessageAliasTextListItemID_A19970 = (global::AcpUI.AcpLabel)target;
			this.LblTrkSysLabtoolTrunkingSystemMessageAliasTextListItemID_A19970.MouseDoubleClick += new global::System.Windows.Input.MouseButtonEventHandler(this.OnFieldNameDoubleClick);
			return;
			IL_3428:
			this.LblTrkSysLabtoolTrunkingSystemAPCOChannelIdentifierListItemID_A19965 = (global::AcpUI.AcpLabel)target;
			this.LblTrkSysLabtoolTrunkingSystemAPCOChannelIdentifierListItemID_A19965.MouseDoubleClick += new global::System.Windows.Input.MouseButtonEventHandler(this.OnFieldNameDoubleClick);
			return;
			IL_344C:
			this.LblTrkSysASTRO25ChannelIDTransmitOffsetSign_A9417 = (global::AcpUI.AcpLabel)target;
			this.LblTrkSysASTRO25ChannelIDTransmitOffsetSign_A9417.MouseDoubleClick += new global::System.Windows.Input.MouseButtonEventHandler(this.OnFieldNameDoubleClick);
			return;
			IL_3470:
			this.TrkSysSiteAlias_A24071 = (global::AcpUI.AcpLabel)target;
			this.TrkSysSiteAlias_A24071.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_3494:
			this.Position_37453 = (global::Infragistics.Windows.DataPresenter.UnboundField)target;
			return;
			IL_34A1:
			this.TrkSysASTRO25ChannelIDTransmitOffsetMHz_A9416 = (global::AcpUI.AcpTextBox)target;
			this.TrkSysASTRO25ChannelIDTransmitOffsetMHz_A9416.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_34C5:
			this.GrpBoxExpanderTrunkingSystemSecureMultikeyPrivateCall = (global::AcpUI.AcpGroupBox)target;
			return;
			IL_34D2:
			this.RTDBtnTrkSysSecureMultikeyDynamicAGKeySelect_A7914 = (global::AcpUI.AcpRtdButton)target;
			return;
			IL_34DF:
			this.CpyBtnTrkSysASTRO25WUIDValiditySupport_A41483 = (global::AcpUI.AcpCopyButton)target;
			return;
			IL_34EC:
			this.CpyBtnTrkSysDigitalPreambleLength_A8722 = (global::AcpUI.AcpCopyButton)target;
			return;
			IL_34F9:
			this.TrkSysGeneralSiteID_A9150Comp = (global::AcpUI.AcpTextBoxDecHex)target;
			return;
			IL_3506:
			this.ExpanderTrunkingSystemStatusAlias = (global::AcpUI.AcpExpander)target;
			return;
			IL_3513:
			this.CVBtnTrkSysASTRO25MotorolaProprietaryFeatures_A8547 = (global::AcpUI.AcpCustomViewCheckBox)target;
			return;
			IL_3520:
			this.TrkSysSiteAliasHomeRASWACNNumber_A20169_Col = (global::Infragistics.Windows.DataPresenter.UnboundField)target;
			return;
			IL_352D:
			this.CpyBtnTrkSysGeneralNonAdjacentSiteSearch_A8568 = (global::AcpUI.AcpCopyButton)target;
			return;
			IL_353A:
			this.RTDBtnTrkSysFeaturesICUAAutoResetTimesec_A7515 = (global::AcpUI.AcpRtdButton)target;
			return;
			IL_3547:
			this.TrkSysFeaturesEmergencyAlarmRxIndicator_A7932 = (global::AcpUI.AcpCheckBox)target;
			this.TrkSysFeaturesEmergencyAlarmRxIndicator_A7932.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_356B:
			this.GrpBoxExpanderTrunkingSystemLabtoolPseudo0 = (global::AcpUI.AcpGroupBox)target;
			return;
			IL_3578:
			this.CVBtnTrkSysTypeIIChannelSetupSplinterChannel_A9175 = (global::AcpUI.AcpCustomViewCheckBox)target;
			return;
			IL_3585:
			this.GrpBoxExpanderTrunkingSystemASTRO26Pseudo0 = (global::AcpUI.AcpGroupBox)target;
			return;
			IL_3592:
			this.TrkSysLabtoolTrunkingSystemControlChannelListItemID_A19964 = (global::AcpUI.AcpComboBox)target;
			this.TrkSysLabtoolTrunkingSystemControlChannelListItemID_A19964.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_35B6:
			this.CpyBtnTrkSysSecureMultikeyASTROOTAR_A7494 = (global::AcpUI.AcpCopyButton)target;
			return;
			IL_35C3:
			this.TrkSysStatusAlias_A24070Comp = (global::AcpUI.AcpLabel)target;
			return;
			IL_35D0:
			this.TrkSysFeaturesTextMessagingService_A9373Comp = (global::AcpUI.AcpLabel)target;
			return;
			IL_35DD:
			this.LblTrkSysSecureMultikeyFailsoftKeySelect_A8012 = (global::AcpUI.AcpLabel)target;
			this.LblTrkSysSecureMultikeyFailsoftKeySelect_A8012.MouseDoubleClick += new global::System.Windows.Input.MouseButtonEventHandler(this.OnFieldNameDoubleClick);
			return;
			IL_3601:
			this.RTDBtnTrkSysLabtoolTrunkingSystemMessageAliasTextListItemID_A19970 = (global::AcpUI.AcpRtdButton)target;
			return;
			IL_360E:
			this.LblTrkSysSecureMultikeyVirtualPartnerSecureClearStrapping_A43670 = (global::AcpUI.AcpLabel)target;
			this.LblTrkSysSecureMultikeyVirtualPartnerSecureClearStrapping_A43670.MouseDoubleClick += new global::System.Windows.Input.MouseButtonEventHandler(this.OnFieldNameDoubleClick);
			return;
			IL_3632:
			this.TrkSysStatusAliasStatusAliasNumber_A9190Comp = (global::AcpUI.AcpLabel)target;
			return;
			IL_363F:
			this.TrkSysOBTChannelAssignmentListTxStartFrequencyMHz_A9568 = (global::AcpUI.AcpTextBox)target;
			this.TrkSysOBTChannelAssignmentListTxStartFrequencyMHz_A9568.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_3663:
			this.ExpanderTrunkingSystemOneTouchTableTableView = (global::AcpUI.AcpGroupBox)target;
			return;
			IL_3670:
			this.TrkSysSiteAliasSiteAliasNumber_A9145Comp = (global::AcpUI.AcpTextBoxDecHex)target;
			return;
			IL_367D:
			this.CpyBtnTrkSysDigitalHighDeviationTx_A19314 = (global::AcpUI.AcpCopyButton)target;
			return;
			IL_368A:
			this.LblTrkSysASTRO25BusyUpdateTimesec_A7574 = (global::AcpUI.AcpLabel)target;
			this.LblTrkSysASTRO25BusyUpdateTimesec_A7574.MouseDoubleClick += new global::System.Windows.Input.MouseButtonEventHandler(this.OnFieldNameDoubleClick);
			return;
			IL_36AE:
			this.gridExpanderTrunkingSystemASTRO25ChannelIDTableSRecView = (global::System.Windows.Controls.Grid)target;
			return;
			IL_36BB:
			this.CVBtnTrkSysSiteAliasSystemNumber_A19669 = (global::AcpUI.AcpCustomViewCheckBox)target;
			return;
			IL_36C8:
			this.LblTrkSysOneTouchAbbreviatedOneTouchAlias_A8622 = (global::AcpUI.AcpLabel)target;
			this.LblTrkSysOneTouchAbbreviatedOneTouchAlias_A8622.MouseDoubleClick += new global::System.Windows.Input.MouseButtonEventHandler(this.OnFieldNameDoubleClick);
			return;
			IL_36EC:
			this.CpyBtnTrkSysSecureMultikeyPatchKeySelect_A8694 = (global::AcpUI.AcpCopyButton)target;
			return;
			IL_36F9:
			this.RTDBtnTrkPerFeaturesOTARadioAliasType_42854 = (global::AcpUI.AcpRtdButton)target;
			return;
			IL_3706:
			this.CVBtnTrkSysTypeIIChannelSetupLegacyTransitSystem_A8429 = (global::AcpUI.AcpCustomViewCheckBox)target;
			return;
			IL_3713:
			this.TrkSysASTRO25ChannelIDBaseFrequencyMHz_A7546_Col = (global::Infragistics.Windows.DataPresenter.UnboundField)target;
			return;
			IL_3720:
			this.LblTrkSysOBTChannelAssignmentListRxStartFrequencyMHz_A9029 = (global::AcpUI.AcpLabel)target;
			this.LblTrkSysOBTChannelAssignmentListRxStartFrequencyMHz_A9029.MouseDoubleClick += new global::System.Windows.Input.MouseButtonEventHandler(this.OnFieldNameDoubleClick);
			return;
			IL_3744:
			this.CpyBtnTrkSysDigitalAdaptivePower_A7509 = (global::AcpUI.AcpCopyButton)target;
			return;
			IL_3751:
			this.CVBtnTrkSysLabtoolTrunkingSystemStatusAliasTextListItemID_A19968 = (global::AcpUI.AcpCustomViewCheckBox)target;
			return;
			IL_375E:
			this.TrkSysDigitalAdaptivePower_A7509Comp = (global::AcpUI.AcpCheckBox)target;
			return;
			IL_376B:
			this.CpyBtnTrkSysFeaturesPASelection_A42882 = (global::AcpUI.AcpCopyButton)target;
			return;
			IL_3778:
			this.GrpBoxExpanderTrunkingSystemFeaturesSiteSelectableAlert = (global::AcpUI.AcpGroupBox)target;
			return;
			IL_3785:
			this.CVBtnTrkSysASTRO25ChannelIDChannelSpacingkHz_A7660 = (global::AcpUI.AcpCustomViewCheckBox)target;
			return;
			IL_3792:
			this.GrpBoxExpanderTrunkingSystemSecureMultikeyFailsoft = (global::AcpUI.AcpGroupBox)target;
			return;
			IL_379F:
			this.TrkSysControlChannelsTxFrequencyMHz_A9535Comp = (global::AcpUI.AcpLabel)target;
			return;
			IL_37AC:
			this.CVBtnTrkSysASTRO25EndF2TDMATransmitOnOutOfRange_A1394 = (global::AcpUI.AcpCustomViewCheckBox)target;
			return;
			IL_37B9:
			this.TrkSysASTRO25DefaultRCMAddress_A7813Comp = (global::AcpUI.AcpTextBoxDecHex)target;
			return;
			IL_37C6:
			this.LblTrkSysTypeIIChannelSetupShuffledBandPlan_A9128 = (global::AcpUI.AcpLabel)target;
			this.LblTrkSysTypeIIChannelSetupShuffledBandPlan_A9128.MouseDoubleClick += new global::System.Windows.Input.MouseButtonEventHandler(this.OnFieldNameDoubleClick);
			return;
			IL_37EA:
			this.CpyBtnTrkSysOBTChannelAssignmentListRxStartFrequencyMHz_A9029 = (global::AcpUI.AcpCopyButton)target;
			return;
			IL_37F7:
			this.TrkSysDigitalFDMAFrameSyncNIDBERThreshold_A8159Comp = (global::AcpUI.AcpLabel)target;
			return;
			IL_3804:
			this.RTDBtnTrkSysLabtoolEnable_A8669 = (global::AcpUI.AcpRtdButton)target;
			return;
			IL_3811:
			this.TrkSysOBTChannelAssignmentListTxStartFrequencyMHz_A9568_Col = (global::Infragistics.Windows.DataPresenter.UnboundField)target;
			return;
			IL_381E:
			this.TrkSysFeaturesTxBaseTimeSec_A9512Comp = (global::AcpUI.AcpLabel)target;
			return;
			IL_382B:
			this.CVBtnTrkSysLabtoolTrunkingSystemAPCOChannelIdentifierListItemID_A19965 = (global::AcpUI.AcpCustomViewCheckBox)target;
			return;
			IL_3838:
			this.RTDBtnTrkSysASTRO25EndF2TDMATransmitOnOutOfRange_A1394 = (global::AcpUI.AcpRtdButton)target;
			return;
			IL_3845:
			this.TrkSysMsgAlias_A24069_Col = (global::Infragistics.Windows.DataPresenter.UnboundField)target;
			return;
			IL_3852:
			this.TrkSysFeaturesEnable_A7968 = (global::AcpUI.AcpCheckBox)target;
			this.TrkSysFeaturesEnable_A7968.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_3876:
			this.GrpBoxExpanderTrunkingSystemASTRO25ChannelIDPseudo0 = (global::AcpUI.AcpGroupBox)target;
			return;
			IL_3883:
			this.TrkSysASTRO25MaximumSlotSizems_A8478Comp = (global::AcpUI.AcpLabel)target;
			return;
			IL_3890:
			this.LblTrkSysGeneralConnectToneHz_A7710 = (global::AcpUI.AcpLabel)target;
			this.LblTrkSysGeneralConnectToneHz_A7710.MouseDoubleClick += new global::System.Windows.Input.MouseButtonEventHandler(this.OnFieldNameDoubleClick);
			return;
			IL_38B4:
			this.TrkSysOBTChannelAssignmentListRxStartFrequencyMHz_A9029_Col = (global::Infragistics.Windows.DataPresenter.UnboundField)target;
			return;
			IL_38C1:
			this.CVBtnTrkSysASTRO25ChannelIDTransmitOffsetSign_A9417 = (global::AcpUI.AcpCustomViewCheckBox)target;
			return;
			IL_38CE:
			this.LblTrkSysSecureMultikeyPatchKeySelect_A8694 = (global::AcpUI.AcpLabel)target;
			this.LblTrkSysSecureMultikeyPatchKeySelect_A8694.MouseDoubleClick += new global::System.Windows.Input.MouseButtonEventHandler(this.OnFieldNameDoubleClick);
			return;
			IL_38F2:
			this.TrkSysFeaturesHearClear_A36422Comp = (global::AcpUI.AcpLabel)target;
			return;
			IL_38FF:
			this.CpyBtnTrkSysLabtoolTrunkingSystemIIOBTChannelAssignmentListItemID_A19966 = (global::AcpUI.AcpCopyButton)target;
			return;
			IL_390C:
			this.ExpanderTrunkingSystemMessageAliasTableTableView = (global::AcpUI.AcpGroupBox)target;
			return;
			IL_3919:
			this.TrkSysSiteAliasSiteAliasEnable_A9148 = (global::AcpUI.AcpCheckBox)target;
			this.TrkSysSiteAliasSiteAliasEnable_A9148.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_393D:
			this.ExpanderTrunkingSystemGeneral = (global::AcpUI.AcpExpander)target;
			return;
			IL_394A:
			this.RTDBtnTrkSysFeaturesICUAReset_A8249 = (global::AcpUI.AcpRtdButton)target;
			return;
			IL_3957:
			this.RTDBtnTrkSysOBTChannelAssignmentListRxEndFrequencyMHz_A9012 = (global::AcpUI.AcpRtdButton)target;
			return;
			IL_3964:
			this.GrpBoxExpanderTrunkingSystemMessageAliasPseudo0 = (global::AcpUI.AcpGroupBox)target;
			return;
			IL_3971:
			this.TrkSysOBTChannelAssignmentListTxEndFrequencyMHz_A9529_Col = (global::Infragistics.Windows.DataPresenter.UnboundField)target;
			return;
			IL_397E:
			this.TrkSysSecureMultikeyPatchKeySelect_A8694Comp = (global::AcpUI.AcpLabel)target;
			return;
			IL_398B:
			this.TrkSysDigitalHighDeviationTx_A19314 = (global::AcpUI.AcpCheckBox)target;
			this.TrkSysDigitalHighDeviationTx_A19314.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_39AF:
			this.TrkSysSecureMultikeyInterconnectSecureClearStrapping_43478Comp = (global::AcpUI.AcpLabel)target;
			return;
			IL_39BC:
			this.TrkSysFeaturesICUAReset_A8249Comp = (global::AcpUI.AcpLabel)target;
			return;
			IL_39C9:
			this.TrkSysOneTouchAbbreviatedOneTouchAlias_A8622Comp = (global::AcpUI.AcpLabel)target;
			return;
			IL_39D6:
			this.CVBtnTrkSysGeneralSystemID_A9239 = (global::AcpUI.AcpCustomViewCheckBox)target;
			return;
			IL_39E3:
			this.CVBtnTrkSysLTEInterferingFreqPresent_A42198 = (global::AcpUI.AcpCustomViewCheckBox)target;
			return;
			IL_39F0:
			this.TrkSysMessageAliasMessageAliasNumber_A8500_Col = (global::Infragistics.Windows.DataPresenter.UnboundField)target;
			return;
			IL_39FD:
			this.LblTrkSysSecureMultikeyDynamicTalkgroupKeySelect_A7918 = (global::AcpUI.AcpLabel)target;
			this.LblTrkSysSecureMultikeyDynamicTalkgroupKeySelect_A7918.MouseDoubleClick += new global::System.Windows.Input.MouseButtonEventHandler(this.OnFieldNameDoubleClick);
			return;
			IL_3A21:
			this.CVBtnTrkSysGeneralRFSSID_A8980 = (global::AcpUI.AcpCustomViewCheckBox)target;
			return;
			IL_3A2E:
			this.RTDBtnTrkSysSiteAliasSiteAliasEnable_A9148 = (global::AcpUI.AcpRtdButton)target;
			return;
			IL_3A3B:
			this.TrkSysSecureMultikeyDynamicAGKeySelect_A7914 = (global::AcpUI.AcpComboBox)target;
			this.TrkSysSecureMultikeyDynamicAGKeySelect_A7914.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_3A5F:
			this.ExpanderTrunkingSystemLabtool = (global::AcpUI.AcpExpander)target;
			return;
			IL_3A6C:
			this.TrkSysFeaturesDynamicRegroupingEnable_A7969 = (global::AcpUI.AcpCheckBox)target;
			this.TrkSysFeaturesDynamicRegroupingEnable_A7969.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_3A90:
			this.CVBtnTrkSysControlChannelsRxFrequencyMHz_A9018 = (global::AcpUI.AcpCustomViewCheckBox)target;
			return;
			IL_3A9D:
			this.TrkSysSecureMultikeyInterconnectKeySelect_A8298Comp = (global::AcpUI.AcpLabel)target;
			return;
			IL_3AAA:
			this.TrkSysSiteAliasSiteAliasText_A9146 = (global::AcpUI.AcpTextBox)target;
			this.TrkSysSiteAliasSiteAliasText_A9146.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_3ACE:
			this.RTDBtnTrkSysGeneralSystemKeyType_A38853 = (global::AcpUI.AcpRtdButton)target;
			return;
			IL_3ADB:
			this.GrpBoxExpanderTrunkingSystemSecureMultikeyVirtualPartner = (global::AcpUI.AcpGroupBox)target;
			return;
			IL_3AE8:
			this.TrkSysSecureMultikeyDynamicSecureClearStrapping_43489Comp = (global::AcpUI.AcpLabel)target;
			return;
			IL_3AF5:
			this.LblTrkSysGeneralSystemID_A9239 = (global::AcpUI.AcpLabel)target;
			this.LblTrkSysGeneralSystemID_A9239.MouseDoubleClick += new global::System.Windows.Input.MouseButtonEventHandler(this.OnFieldNameDoubleClick);
			return;
			IL_3B19:
			this.TrkSysSecureMultikeyFailsoftKeySelect_A8012 = (global::AcpUI.AcpComboBox)target;
			this.TrkSysSecureMultikeyFailsoftKeySelect_A8012.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_3B3D:
			this.CpyBtnTrkSysSiteAliasRFSSAliasNumber_A8978 = (global::AcpUI.AcpCopyButton)target;
			return;
			IL_3B4A:
			this.LblTrkSysGeneralDataProfileSelection_A19449 = (global::AcpUI.AcpLabel)target;
			this.LblTrkSysGeneralDataProfileSelection_A19449.MouseDoubleClick += new global::System.Windows.Input.MouseButtonEventHandler(this.OnFieldNameDoubleClick);
			return;
			IL_3B6E:
			this.TrkSysSiteAlias_A24071Comp = (global::AcpUI.AcpLabel)target;
			return;
			IL_3B7B:
			this.TrkSysSecureMultikeyAutoKeyIDRx_A43185 = (global::AcpUI.AcpCheckBox)target;
			this.TrkSysSecureMultikeyAutoKeyIDRx_A43185.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_3B9F:
			this.LblTrkSysSecureMultikeyPrivateCallKeySelect_A8757 = (global::AcpUI.AcpLabel)target;
			this.LblTrkSysSecureMultikeyPrivateCallKeySelect_A8757.MouseDoubleClick += new global::System.Windows.Input.MouseButtonEventHandler(this.OnFieldNameDoubleClick);
			return;
			IL_3BC3:
			this.CVBtnTrkSysDigitalF2TDMAFrameSyncBERThreshold_A1396 = (global::AcpUI.AcpCustomViewCheckBox)target;
			return;
			IL_3BD0:
			this.TrkSysGeneralRFSSDebounceTimersec_A8979 = (global::AcpUI.AcpTextBoxSpinner)target;
			this.TrkSysGeneralRFSSDebounceTimersec_A8979.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_3BF4:
			this.TrkSysASTRO25MaximumSlotSizems_A8478 = (global::AcpUI.AcpTextBoxSpinner)target;
			this.TrkSysASTRO25MaximumSlotSizems_A8478.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_3C18:
			this.CpyBtnTrkSysGeneralUnitID_A12651 = (global::AcpUI.AcpCopyButton)target;
			return;
			IL_3C25:
			this.ExpanderTrunkingSystemBroadband = (global::AcpUI.AcpExpander)target;
			return;
			IL_3C32:
			this.CpyBtnTrkSysASTRO25ChannelIDBaseFrequencyMHz_A7546 = (global::AcpUI.AcpCopyButton)target;
			return;
			IL_3C3F:
			this.TrkSysOBTChannelAssignmentListRxEndFrequencyMHz_A9012_Col = (global::Infragistics.Windows.DataPresenter.UnboundField)target;
			return;
			IL_3C4C:
			this.CVBtnTrkSysLabtoolEnable_A8669 = (global::AcpUI.AcpCustomViewCheckBox)target;
			return;
			IL_3C59:
			this.RTDBtnTrkSysSiteAliasRFSSAliasNumber_A8978 = (global::AcpUI.AcpRtdButton)target;
			return;
			IL_3C66:
			this.TrkSysGeneralCoverageType_A7782 = (global::AcpUI.AcpComboBox)target;
			this.TrkSysGeneralCoverageType_A7782.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_3C8A:
			this.CpyBtnTrkSysASTRO25ChannelIDChannelSpacingkHz_A7660 = (global::AcpUI.AcpCopyButton)target;
			return;
			IL_3C97:
			this.RTDBtnTrkSysSecureMultikeyASTROOTAR_A7494 = (global::AcpUI.AcpRtdButton)target;
			return;
			IL_3CA4:
			this.TrkSysASTRO25ChannelIDChannelType_A1390_Col = (global::Infragistics.Windows.DataPresenter.UnboundField)target;
			return;
			IL_3CC8:
			goto IL_5DA0;
			IL_3CCD:
			this.CpyBtnTrkSysOBTChannelAssignmentListTxSpacingKHz_A9520 = (global::AcpUI.AcpCopyButton)target;
			return;
			IL_3CDA:
			this.CpyBtnTrkSysOBTChannelAssignmentListTxEnable_A9517 = (global::AcpUI.AcpCopyButton)target;
			return;
			IL_3CE7:
			this.CpyBtnTrkSysGeneralSystemID_A9239 = (global::AcpUI.AcpCopyButton)target;
			return;
			IL_3CF4:
			this.TrkSysASTRO25ResponsePendingTimesec_A8945 = (global::AcpUI.AcpTextBoxSpinner)target;
			this.TrkSysASTRO25ResponsePendingTimesec_A8945.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_3D18:
			this.RTDBtnTrkSysSecureMultikeyDynamicTalkgroupKeySelect_A7918 = (global::AcpUI.AcpRtdButton)target;
			return;
			IL_3D25:
			this.LblSiteSelectableAlertList_A42060 = (global::AcpUI.AcpLabel)target;
			this.LblSiteSelectableAlertList_A42060.MouseDoubleClick += new global::System.Windows.Input.MouseButtonEventHandler(this.OnFieldNameDoubleClick);
			return;
			IL_3D49:
			this.LblTrkSysTypeIIChannelSetupLegacyTransitSystem_A8429 = (global::AcpUI.AcpLabel)target;
			this.LblTrkSysTypeIIChannelSetupLegacyTransitSystem_A8429.MouseDoubleClick += new global::System.Windows.Input.MouseButtonEventHandler(this.OnFieldNameDoubleClick);
			return;
			IL_3D6D:
			this.TrkSysOBTChannelAssignmentListTxEnable_A9517 = (global::AcpUI.AcpCheckBox)target;
			this.TrkSysOBTChannelAssignmentListTxEnable_A9517.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_3D91:
			this.RTDBtnTrkSysASTRO25ForceUnmuteTimems_A8141 = (global::AcpUI.AcpRtdButton)target;
			return;
			IL_3D9E:
			this.CpyBtnTrkSysFeaturesICUAReset_A8249 = (global::AcpUI.AcpCopyButton)target;
			return;
			IL_3DAB:
			this.TrkSysFeaturesEnable_A7968Comp = (global::AcpUI.AcpCheckBox)target;
			return;
			IL_3DB8:
			this.ExpanderTrunkingSystemASTRO25ChannelIDTableTableView = (global::AcpUI.AcpGroupBox)target;
			return;
			IL_3DC5:
			this.ExpanderTrunkingSystemStatusAliasTable = (global::AcpUI.AcpXamDataPresenter)target;
			return;
			IL_3DD2:
			this.LblTrkSysGeneralSiteID_A9150 = (global::AcpUI.AcpLabel)target;
			this.LblTrkSysGeneralSiteID_A9150.MouseDoubleClick += new global::System.Windows.Input.MouseButtonEventHandler(this.OnFieldNameDoubleClick);
			return;
			IL_3DF6:
			this.TrkSysLabtoolTrunkingSystemStatusAliasListItemID_A19967Comp = (global::AcpUI.AcpLabel)target;
			return;
			IL_3E03:
			this.TrkSysOBTChannelAssignmentListTxSpacingKHz_A9520_Col = (global::Infragistics.Windows.DataPresenter.UnboundField)target;
			return;
			IL_3E10:
			this.TrkSysASTRO25PTTWarningTimems_A8781 = (global::AcpUI.AcpTextBoxSpinner)target;
			this.TrkSysASTRO25PTTWarningTimems_A8781.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_3E34:
			this.RTDBtnTrkSysSecureMultikeyOTARTx_A8676 = (global::AcpUI.AcpRtdButton)target;
			return;
			IL_3E41:
			this.TrkSysASTRO25DefaultRCMAddress_A7813 = (global::AcpUI.AcpTextBoxSpinnerDecHex)target;
			this.TrkSysASTRO25DefaultRCMAddress_A7813.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_3E65:
			this.TrkSysOBTChannelAssignmentListTxSpacingKHz_A9520Comp = (global::AcpUI.AcpLabel)target;
			return;
			IL_3E72:
			this.TrkSysMessageAliasMessageAliasNumber_A8500 = (global::AcpUI.AcpTextBoxSpinner)target;
			this.TrkSysMessageAliasMessageAliasNumber_A8500.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_3E96:
			this.CVBtnTrkSysFeaturesDTMFTimingTable_A7900 = (global::AcpUI.AcpCustomViewCheckBox)target;
			return;
			IL_3EA3:
			this.CVBtnTrkSysOBTChannelAssignmentListTxEnable_A9517 = (global::AcpUI.AcpCustomViewCheckBox)target;
			return;
			IL_3EB0:
			this.CpyBtnTrkSysLabtoolTrunkingSystemMessageAliasTextListItemID_A19970 = (global::AcpUI.AcpCopyButton)target;
			return;
			IL_3EBD:
			this.CVBtnTrkSysSiteAliasSiteAliasEnable_A9148 = (global::AcpUI.AcpCustomViewCheckBox)target;
			return;
			IL_3ECA:
			this.RecNavToolbarExpanderTrunkingSystemSiteAliasTable = (global::AcpUI.AcpChildRecNavToolbar)target;
			this.RecNavToolbarExpanderTrunkingSystemSiteAliasTable.ModeClick += this.OnModeClick;
			return;
			IL_3EEE:
			this.ExpanderTrunkingSystemDigital = (global::AcpUI.AcpExpander)target;
			return;
			IL_3EFB:
			this.RTDBtnTrkSysGeneralUnitID_A12651 = (global::AcpUI.AcpRtdButton)target;
			return;
			IL_3F08:
			this.TrkSysOneTouchIndex_A8618Comp = (global::AcpUI.AcpLabel)target;
			return;
			IL_3F15:
			this.CpyBtnTrkSysSecureMultikeyOTARTx_A8676 = (global::AcpUI.AcpCopyButton)target;
			return;
			IL_3F22:
			this.TrkSysASTRO25ChannelIDIdentifierEnable_A8222_Col = (global::Infragistics.Windows.DataPresenter.UnboundField)target;
			return;
			IL_3F2F:
			this.LblTrkSysOBTChannelAssignmentListTxEndFrequencyMHz_A9529 = (global::AcpUI.AcpLabel)target;
			this.LblTrkSysOBTChannelAssignmentListTxEndFrequencyMHz_A9529.MouseDoubleClick += new global::System.Windows.Input.MouseButtonEventHandler(this.OnFieldNameDoubleClick);
			return;
			IL_3F53:
			this.LblTrkSysSiteAliasSystemNumber_A19669 = (global::AcpUI.AcpLabel)target;
			this.LblTrkSysSiteAliasSystemNumber_A19669.MouseDoubleClick += new global::System.Windows.Input.MouseButtonEventHandler(this.OnFieldNameDoubleClick);
			return;
			IL_3F77:
			this.CpyBtnTrkSysSecureMultikeyDynamicSecureClearStrapping_43489 = (global::AcpUI.AcpCopyButton)target;
			return;
			IL_3F84:
			this.RTDBtnTrkSysSecureMultikeyPrivateCallSecureClearStrapping_43477 = (global::AcpUI.AcpRtdButton)target;
			return;
			IL_3F91:
			this.ExpanderTrunkingSystemOneTouchTable = (global::AcpUI.AcpXamDataPresenter)target;
			return;
			IL_3F9E:
			this.CpyBtnTrkSysTypeIIChannelSetupShuffledBandPlan_A9128 = (global::AcpUI.AcpCopyButton)target;
			return;
			IL_3FAB:
			this.CVBtnTrkSysFeaturesDynamicRegroupingEnable_A7969 = (global::AcpUI.AcpCustomViewCheckBox)target;
			return;
			IL_3FB8:
			this.LblTrkSysASTRO25ISPSequenceLengthsec_A8354 = (global::AcpUI.AcpLabel)target;
			this.LblTrkSysASTRO25ISPSequenceLengthsec_A8354.MouseDoubleClick += new global::System.Windows.Input.MouseButtonEventHandler(this.OnFieldNameDoubleClick);
			return;
			IL_3FDC:
			this.ExpanderTrunkingSystemTypeIIChannelSetup = (global::AcpUI.AcpExpander)target;
			return;
			IL_3FE9:
			this.CVBtnTrkSysFeaturesTextMessagingService_A9373 = (global::AcpUI.AcpCustomViewCheckBox)target;
			return;
			IL_3FF6:
			this.ExpanderTrunkingSystemSiteAliasTable = (global::AcpUI.AcpXamDataPresenter)target;
			return;
			IL_4003:
			this.TrkSysFeaturesZone_A9717Comp = (global::AcpUI.AcpLabel)target;
			return;
			IL_4010:
			this.CVBtnTrkSysControlChannelsTxFrequencyMHz_A9535 = (global::AcpUI.AcpCustomViewCheckBox)target;
			return;
			IL_401D:
			this.LblTrkSysASTRO25F2VoiceCapable_A1395 = (global::AcpUI.AcpLabel)target;
			this.LblTrkSysASTRO25F2VoiceCapable_A1395.MouseDoubleClick += new global::System.Windows.Input.MouseButtonEventHandler(this.OnFieldNameDoubleClick);
			return;
			IL_4041:
			this.LblTrkSysASTRO25PTTWarningTimems_A8781 = (global::AcpUI.AcpLabel)target;
			this.LblTrkSysASTRO25PTTWarningTimems_A8781.MouseDoubleClick += new global::System.Windows.Input.MouseButtonEventHandler(this.OnFieldNameDoubleClick);
			return;
			IL_4065:
			this.TrkSysASTRO25GeoFenceMode_42322 = (global::AcpUI.AcpComboBox)target;
			this.TrkSysASTRO25GeoFenceMode_42322.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_4089:
			this.LblTrkSysGeneralCoverageType_A7782 = (global::AcpUI.AcpLabel)target;
			this.LblTrkSysGeneralCoverageType_A7782.MouseDoubleClick += new global::System.Windows.Input.MouseButtonEventHandler(this.OnFieldNameDoubleClick);
			return;
			IL_40AD:
			this.LblTrkSysFeaturesHearClear_A36422 = (global::AcpUI.AcpLabel)target;
			this.LblTrkSysFeaturesHearClear_A36422.MouseDoubleClick += new global::System.Windows.Input.MouseButtonEventHandler(this.OnFieldNameDoubleClick);
			return;
			IL_40D1:
			this.RTDBtnSiteSelectableAlertAliasList_A42100 = (global::AcpUI.AcpRtdButton)target;
			return;
			IL_40DE:
			this.TrkSysFeaturesOTARadioAliasUpdateEnable_A43057Comp = (global::AcpUI.AcpCheckBox)target;
			return;
			IL_40EB:
			this.TrkSysMessageAliasMessageAliasText_A8503Comp = (global::AcpUI.AcpLabel)target;
			return;
			IL_40F8:
			this.CVBtnTrkSysGeneralHomeWACNID_A8205 = (global::AcpUI.AcpCustomViewCheckBox)target;
			return;
			IL_4105:
			this.RTDBtnTrkSysGeneralHomeWACNID_A8205 = (global::AcpUI.AcpRtdButton)target;
			return;
			IL_4112:
			this.RTDBtnTrkSysTypeIIChannelSetupShuffledBandPlan_A9128 = (global::AcpUI.AcpRtdButton)target;
			return;
			IL_411F:
			this.TrkSysSecureMultikeySystemWideKeySelect_A9253 = (global::AcpUI.AcpComboBox)target;
			this.TrkSysSecureMultikeySystemWideKeySelect_A9253.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_4143:
			this.HLinkOBTChannelAssignment = (global::System.Windows.Documents.Hyperlink)target;
			this.HLinkOBTChannelAssignment.Click += this.HLinkClick;
			return;
			IL_4167:
			this.CVBtnTrkSysGeneralTypeIIFrequencyBand_A12491 = (global::AcpUI.AcpCustomViewCheckBox)target;
			return;
			IL_4174:
			this.CpyBtnTrkSysGeneralRFSSResponseTimems_A8981 = (global::AcpUI.AcpCopyButton)target;
			return;
			IL_4181:
			this.LblTrkSysFeaturesRadioInhibit_A8833 = (global::AcpUI.AcpLabel)target;
			this.LblTrkSysFeaturesRadioInhibit_A8833.MouseDoubleClick += new global::System.Windows.Input.MouseButtonEventHandler(this.OnFieldNameDoubleClick);
			return;
			IL_41A5:
			this.LblTrkSysOneTouchFeature_A8614 = (global::AcpUI.AcpLabel)target;
			this.LblTrkSysOneTouchFeature_A8614.MouseDoubleClick += new global::System.Windows.Input.MouseButtonEventHandler(this.OnFieldNameDoubleClick);
			return;
			IL_41C9:
			this.CVBtnTrkSysFeaturesICUAAutoResetTimesec_A7515 = (global::AcpUI.AcpCustomViewCheckBox)target;
			return;
			IL_41D6:
			this.CVBtnTrkSysTypeIIChannelSetupChannelAssignmentType_A7652 = (global::AcpUI.AcpCustomViewCheckBox)target;
			return;
			IL_41E3:
			this.RTDBtnTrkSysSecureMultikeyInterconnectKeySelect_A8298 = (global::AcpUI.AcpRtdButton)target;
			return;
			IL_41F0:
			this.RTDBtnTrkSysGeneralFailsoftConnectToneHz_A8007 = (global::AcpUI.AcpRtdButton)target;
			return;
			IL_41FD:
			this.LblTrkSysGeneralRFSSDebounceTimersec_A8979 = (global::AcpUI.AcpLabel)target;
			this.LblTrkSysGeneralRFSSDebounceTimersec_A8979.MouseDoubleClick += new global::System.Windows.Input.MouseButtonEventHandler(this.OnFieldNameDoubleClick);
			return;
			IL_4221:
			this.ExpanderTrunkingSystemASTRO26 = (global::AcpUI.AcpExpander)target;
			return;
			IL_422E:
			this.TrkSysOneTouchAbbreviatedOneTouchAlias_A8622_Col = (global::Infragistics.Windows.DataPresenter.UnboundField)target;
			return;
			IL_423B:
			this.RTDBtnTrkSysOBTChannelAssignmentListTxEndFrequencyMHz_A9529 = (global::AcpUI.AcpRtdButton)target;
			return;
			IL_4248:
			this.RTDBtnTrkSysFeaturesDTMFTimingTable_A7900 = (global::AcpUI.AcpRtdButton)target;
			return;
			IL_4255:
			this.TrkSysOneTouchIndex_A8618_Col = (global::Infragistics.Windows.DataPresenter.UnboundField)target;
			return;
			IL_4262:
			this.TrkSysControlChannelsRxFrequencyMHz_A9018_Col = (global::Infragistics.Windows.DataPresenter.UnboundField)target;
			return;
			IL_426F:
			this.TrkSysGeneralFailsoftConnectToneHz_A8007Comp = (global::AcpUI.AcpLabel)target;
			return;
			IL_427C:
			this.CpyBtnTrkSysOBTChannelAssignmentListTxStartFrequencyMHz_A9568 = (global::AcpUI.AcpCopyButton)target;
			return;
			IL_4289:
			this.CpyBtnTrkSysSecureMultikeyPrivateCallKeySelect_A8757 = (global::AcpUI.AcpCopyButton)target;
			return;
			IL_4296:
			this.CpyBtnTrkSysSecureMultikeySystemWideKeySelect_A9253 = (global::AcpUI.AcpCopyButton)target;
			return;
			IL_42A3:
			this.RTDBtnTrkSysSecureMultikeyPrivateCallKeySelect_A8757 = (global::AcpUI.AcpRtdButton)target;
			return;
			IL_42B0:
			this.TrkSysSecureMultikeyVirtualPartnerKeySelect_A43669Comp = (global::AcpUI.AcpLabel)target;
			return;
			IL_42BD:
			this.RecNavToolbarExpanderTrunkingSystemControlChannelsTable = (global::AcpUI.AcpChildRecNavToolbar)target;
			this.RecNavToolbarExpanderTrunkingSystemControlChannelsTable.ModeClick += this.OnModeClick;
			return;
			IL_42E1:
			this.CVBtnTrkSysSecureMultikeyInterconnectSecureClearStrapping_43478 = (global::AcpUI.AcpCustomViewCheckBox)target;
			return;
			IL_42EE:
			this.RTDBtnTrkSysDigitalFDMAFrameSyncNIDBERThreshold_A8159 = (global::AcpUI.AcpRtdButton)target;
			return;
			IL_42FB:
			this.TrkSysASTRO25QuickFadeProtectms_A8807 = (global::AcpUI.AcpTextBoxSpinner)target;
			this.TrkSysASTRO25QuickFadeProtectms_A8807.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_431F:
			this.CpyBtnTrkSysASTRO25F2VoiceCapable_A1395 = (global::AcpUI.AcpCopyButton)target;
			return;
			IL_432C:
			this.TrkSysOBTChannelAssignmentListTxEndFrequencyMHz_A9529Comp = (global::AcpUI.AcpLabel)target;
			return;
			IL_4339:
			this.LblTrkSysFeaturesChannel_A7647 = (global::AcpUI.AcpLabel)target;
			this.LblTrkSysFeaturesChannel_A7647.MouseDoubleClick += new global::System.Windows.Input.MouseButtonEventHandler(this.OnFieldNameDoubleClick);
			return;
			IL_435D:
			this.CVBtnTrkSysDigitalDigitalModulatorType_A7858 = (global::AcpUI.AcpCustomViewCheckBox)target;
			return;
			IL_436A:
			this.LblTrkSysGeneralRFSSResponseTimems_A8981 = (global::AcpUI.AcpLabel)target;
			this.LblTrkSysGeneralRFSSResponseTimems_A8981.MouseDoubleClick += new global::System.Windows.Input.MouseButtonEventHandler(this.OnFieldNameDoubleClick);
			return;
			IL_438E:
			this.TrkSysTypeIIChannelSetupNPSPACChannelBandwidthkHz_A8571 = (global::AcpUI.AcpComboBox)target;
			this.TrkSysTypeIIChannelSetupNPSPACChannelBandwidthkHz_A8571.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_43B2:
			this.LblTrkSysFeaturesSecureLED_A9071 = (global::AcpUI.AcpLabel)target;
			this.LblTrkSysFeaturesSecureLED_A9071.MouseDoubleClick += new global::System.Windows.Input.MouseButtonEventHandler(this.OnFieldNameDoubleClick);
			return;
			IL_43D6:
			num = (short)954078565;
			short num4 = num;
			num = (short)1774064997;
			switch ((num4 == num) ? 1 : 0)
			{
			case 0:
			case 2:
				IL_5702:
				this.CpyBtnTrkSysASTRO25ForceUnmuteTimems_A8141 = (global::AcpUI.AcpCopyButton)target;
				return;
			default:
				num = (short)1369309184;
				if (num != 0)
				{
				}
				this.CVBtnTrkSysLabtoolTrunkingSystemMessageAliasListItemID_A19969 = (global::AcpUI.AcpCustomViewCheckBox)target;
				return;
			}
			IL_442F:
			this.CpyBtnTrkSysSiteAliasHomeRASWACNNumber_A20169 = (global::AcpUI.AcpCopyButton)target;
			return;
			IL_443C:
			this.CpyBtnTrkSysFeaturesICUAAutoResetTimesec_A7515 = (global::AcpUI.AcpCopyButton)target;
			return;
			IL_4449:
			this.CpyBtnTrkSysAstro25ChannelID_A24066 = (global::AcpUI.AcpCopyButton)target;
			return;
			IL_4456:
			this.RTDBtnTrkSysFeaturesOTARadioAliasUpdateEnable_A43057 = (global::AcpUI.AcpRtdButton)target;
			return;
			IL_4463:
			this.CVBtnTrkSysSecureMultikeyPrivateCallSecureClearStrapping_43477 = (global::AcpUI.AcpCustomViewCheckBox)target;
			return;
			IL_4470:
			this.CVBtnTrkSysSecureMultikeyAutoKeyIDRx_A43185 = (global::AcpUI.AcpCustomViewCheckBox)target;
			return;
			IL_447D:
			this.CVBtnTrkSysGeneralSystemKeyPresent_A9241 = (global::AcpUI.AcpCustomViewCheckBox)target;
			return;
			IL_448A:
			this.LblTrkSysStatusAliasStatusAliasNumber_A9190 = (global::AcpUI.AcpLabel)target;
			this.LblTrkSysStatusAliasStatusAliasNumber_A9190.MouseDoubleClick += new global::System.Windows.Input.MouseButtonEventHandler(this.OnFieldNameDoubleClick);
			return;
			IL_44AE:
			this.LblTrkSysGeneralNonAdjacentSiteSearch_A8568 = (global::AcpUI.AcpLabel)target;
			this.LblTrkSysGeneralNonAdjacentSiteSearch_A8568.MouseDoubleClick += new global::System.Windows.Input.MouseButtonEventHandler(this.OnFieldNameDoubleClick);
			return;
			IL_44D2:
			this.GrpBoxExpanderTrunkingSystemSiteAliasPseudo0 = (global::AcpUI.AcpGroupBox)target;
			return;
			IL_44DF:
			this.TrkSysGeneralKeyofTrunkingSystem_A12658Comp = (global::AcpUI.AcpLabel)target;
			return;
			IL_44EC:
			this.CVBtnTrkSysGeneralFailsoftConnectToneHz_A8007 = (global::AcpUI.AcpCustomViewCheckBox)target;
			return;
			IL_44F9:
			this.RTDBtnTrkSysSecureMultikeyFailsoftSecureClearStrapping_43479 = (global::AcpUI.AcpRtdButton)target;
			return;
			IL_4506:
			this.CpyBtnTrkSysGeneralKeyofTrunkingSystem_A12658 = (global::AcpUI.AcpCopyButton)target;
			return;
			IL_4513:
			this.TrkSysDigitalDigitalModulatorType_A7858Comp = (global::AcpUI.AcpLabel)target;
			return;
			IL_4520:
			this.TrkSysGeneralRFSSID_A8980 = (global::AcpUI.AcpTextBoxSpinnerDecHex)target;
			this.TrkSysGeneralRFSSID_A8980.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_4544:
			this.LblTrkSysFeaturesEmergencyAlarmRxIndicator_A7932 = (global::AcpUI.AcpLabel)target;
			this.LblTrkSysFeaturesEmergencyAlarmRxIndicator_A7932.MouseDoubleClick += new global::System.Windows.Input.MouseButtonEventHandler(this.OnFieldNameDoubleClick);
			return;
			IL_4568:
			this.GrpBoxExpanderTrunkingSystemSecureMultikeyInterconnect = (global::AcpUI.AcpGroupBox)target;
			return;
			IL_4575:
			this.TrkSysOBTChannelAssignmentListTxStartFrequencyMHz_A9568Comp = (global::AcpUI.AcpLabel)target;
			return;
			IL_4582:
			this.RTDBtnTrkSysSiteAliasSystemNumber_A19669 = (global::AcpUI.AcpRtdButton)target;
			return;
			IL_458F:
			this.HLinkASTRO26 = (global::System.Windows.Documents.Hyperlink)target;
			this.HLinkASTRO26.Click += this.HLinkClick;
			return;
			IL_45B3:
			this.TrkSysGeneralCoverageType_A7782Comp = (global::AcpUI.AcpLabel)target;
			return;
			IL_45C0:
			this.CVBtnTrkSysSecureMultikeyFailsoftSecureClearStrapping_43479 = (global::AcpUI.AcpCustomViewCheckBox)target;
			return;
			IL_45CD:
			this.LblTrkSysControlChannelsTxFrequencyMHz_A9535 = (global::AcpUI.AcpLabel)target;
			this.LblTrkSysControlChannelsTxFrequencyMHz_A9535.MouseDoubleClick += new global::System.Windows.Input.MouseButtonEventHandler(this.OnFieldNameDoubleClick);
			return;
			IL_45F1:
			this.CVBtnTrkSysTypeIIChannelSetupNPSPACChannelBandwidthkHz_A8571 = (global::AcpUI.AcpCustomViewCheckBox)target;
			return;
			IL_45FE:
			this.RTDBtnTrkSysLabtoolTrunkingSystemControlChannelListItemID_A19964 = (global::AcpUI.AcpRtdButton)target;
			return;
			IL_460B:
			this.LblTrkSysASTRO25MaximumSlotSizems_A8478 = (global::AcpUI.AcpLabel)target;
			this.LblTrkSysASTRO25MaximumSlotSizems_A8478.MouseDoubleClick += new global::System.Windows.Input.MouseButtonEventHandler(this.OnFieldNameDoubleClick);
			return;
			IL_462F:
			this.LblTrkSysASTRO25ChannelIDChannelSpacingkHz_A7660 = (global::AcpUI.AcpLabel)target;
			this.LblTrkSysASTRO25ChannelIDChannelSpacingkHz_A7660.MouseDoubleClick += new global::System.Windows.Input.MouseButtonEventHandler(this.OnFieldNameDoubleClick);
			return;
			IL_4653:
			this.LblTrkSysFeaturesDynamicRegroupingEnable_A7969 = (global::AcpUI.AcpLabel)target;
			this.LblTrkSysFeaturesDynamicRegroupingEnable_A7969.MouseDoubleClick += new global::System.Windows.Input.MouseButtonEventHandler(this.OnFieldNameDoubleClick);
			return;
			IL_4677:
			this.LblTrkPerFeaturesOTARadioAliasType_42854 = (global::AcpUI.AcpLabel)target;
			this.LblTrkPerFeaturesOTARadioAliasType_42854.MouseDoubleClick += new global::System.Windows.Input.MouseButtonEventHandler(this.OnFieldNameDoubleClick);
			return;
			IL_469B:
			this.HLinkASTRO25ChannelID = (global::System.Windows.Documents.Hyperlink)target;
			this.HLinkASTRO25ChannelID.Click += this.HLinkClick;
			return;
			IL_46BF:
			this.TrkSysGeneralRFSSResponseTimems_A8981 = (global::AcpUI.AcpTextBoxSpinner)target;
			this.TrkSysGeneralRFSSResponseTimems_A8981.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_46E3:
			this.ExpanderTrunkingSystemControlChannelsGrid = (global::System.Windows.Controls.Grid)target;
			return;
			IL_46F0:
			this.ExpanderTrunkingSystemControlChannels = (global::AcpUI.AcpExpander)target;
			return;
			IL_46FD:
			this.CVBtnTrkSysASTRO25QuickFadeProtectms_A8807 = (global::AcpUI.AcpCustomViewCheckBox)target;
			return;
			IL_470A:
			this.LblTrkSysOBTChannelAssignmentListTxStartFrequencyMHz_A9568 = (global::AcpUI.AcpLabel)target;
			this.LblTrkSysOBTChannelAssignmentListTxStartFrequencyMHz_A9568.MouseDoubleClick += new global::System.Windows.Input.MouseButtonEventHandler(this.OnFieldNameDoubleClick);
			return;
			IL_472E:
			this.TrkSysLabtoolTrunkingSystemStatusAliasTextListItemID_A19968 = (global::AcpUI.AcpComboBox)target;
			this.TrkSysLabtoolTrunkingSystemStatusAliasTextListItemID_A19968.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_4752:
			this.LblTrkSysASTRO25GeoFenceMode_42322 = (global::AcpUI.AcpLabel)target;
			this.LblTrkSysASTRO25GeoFenceMode_42322.MouseDoubleClick += new global::System.Windows.Input.MouseButtonEventHandler(this.OnFieldNameDoubleClick);
			return;
			IL_4776:
			this.CVBtnTrkSysFeaturesTxBaseTimeSec_A9512 = (global::AcpUI.AcpCustomViewCheckBox)target;
			return;
			IL_4783:
			this.CpyBtnTrkSysSecureMultikeyAutoKeyIDRx_A43185 = (global::AcpUI.AcpCopyButton)target;
			return;
			IL_4790:
			this.TrkSysSecureMultikeyKMFProfileIndex_A8382 = (global::AcpUI.AcpComboBox)target;
			this.TrkSysSecureMultikeyKMFProfileIndex_A8382.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_47B4:
			this.TrkSysASTRO25ChannelIDChannelType_A1390 = (global::AcpUI.AcpComboBox)target;
			this.TrkSysASTRO25ChannelIDChannelType_A1390.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_47D8:
			this.TrkSysASTRO25ValidateNACAgainstSystemID_A20608 = (global::AcpUI.AcpCheckBox)target;
			this.TrkSysASTRO25ValidateNACAgainstSystemID_A20608.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_47FC:
			this.LblTrkSysASTRO25MotorolaProprietaryFeatures_A8547 = (global::AcpUI.AcpLabel)target;
			this.LblTrkSysASTRO25MotorolaProprietaryFeatures_A8547.MouseDoubleClick += new global::System.Windows.Input.MouseButtonEventHandler(this.OnFieldNameDoubleClick);
			return;
			IL_4820:
			this.RTDBtnTrkSysSecureMultikeyKMFProfileIndex_A8382 = (global::AcpUI.AcpRtdButton)target;
			return;
			IL_482D:
			this.RTDBtnTrkSysASTRO25MotorolaProprietaryFeatures_A8547 = (global::AcpUI.AcpRtdButton)target;
			return;
			IL_483A:
			this.CpyBtnTrkSysSecureMultikeyFailsoftSecureClearStrapping_43479 = (global::AcpUI.AcpCopyButton)target;
			return;
			IL_4847:
			this.CVBtnTrkSysASTRO25ISPSequenceLengthsec_A8354 = (global::AcpUI.AcpCustomViewCheckBox)target;
			return;
			IL_4854:
			this.TrkSysFeaturesDynamicRegroupingEnable_A7969Comp = (global::AcpUI.AcpCheckBox)target;
			return;
			IL_4861:
			this.RTDBtnTrkSysFeaturesHearClear_A36422 = (global::AcpUI.AcpRtdButton)target;
			return;
			IL_486E:
			this.CVBtnTrkSysFeaturesICUAReset_A8249 = (global::AcpUI.AcpCustomViewCheckBox)target;
			return;
			IL_487B:
			this.RTDBtnTrkSysControlChannelsTxFrequencyMHz_A9535 = (global::AcpUI.AcpRtdButton)target;
			return;
			IL_4888:
			this.LblTrkSysASTRO25ChannelIDBaseFrequencyMHz_A7546 = (global::AcpUI.AcpLabel)target;
			this.LblTrkSysASTRO25ChannelIDBaseFrequencyMHz_A7546.MouseDoubleClick += new global::System.Windows.Input.MouseButtonEventHandler(this.OnFieldNameDoubleClick);
			return;
			IL_48AC:
			this.CVBtnTrkSysASTRO25WUIDValiditySupport_A41483 = (global::AcpUI.AcpCustomViewCheckBox)target;
			return;
			IL_48B9:
			this.CVBtnTrkSysLabtoolTrunkingSystemIIOBTChannelAssignmentListItemID_A19966 = (global::AcpUI.AcpCustomViewCheckBox)target;
			return;
			IL_48C6:
			this.ExpanderTrunkingSystemStatusAliasTableTableView = (global::AcpUI.AcpGroupBox)target;
			return;
			IL_48D3:
			this.LblTrkSysSiteAliasSiteAliasEnable_A9148 = (global::AcpUI.AcpLabel)target;
			this.LblTrkSysSiteAliasSiteAliasEnable_A9148.MouseDoubleClick += new global::System.Windows.Input.MouseButtonEventHandler(this.OnFieldNameDoubleClick);
			return;
			IL_48F7:
			this.HLinkSecureMultikey = (global::System.Windows.Documents.Hyperlink)target;
			this.HLinkSecureMultikey.Click += this.HLinkClick;
			return;
			IL_491B:
			this.CVBtnTrkSysSecureMultikeyKMFProfileIndex_A8382 = (global::AcpUI.AcpCustomViewCheckBox)target;
			return;
			IL_4928:
			this.CpyBtnTrkSysSecureMultikeyVirtualPartnerSecureClearStrapping_A43670 = (global::AcpUI.AcpCopyButton)target;
			return;
			IL_4935:
			this.TrkSysOBTChannelAssignmentListRxStartChannelNumber_A20478 = (global::AcpUI.AcpTextBoxSpinnerDecHex)target;
			this.TrkSysOBTChannelAssignmentListRxStartChannelNumber_A20478.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_4959:
			this.TrkSysASTRO25Phase2VoiceCapable_A37972Comp = (global::AcpUI.AcpCheckBox)target;
			return;
			IL_4966:
			this.CVBtnTrkSysGeneralRFSSDebounceTimersec_A8979 = (global::AcpUI.AcpCustomViewCheckBox)target;
			return;
			IL_4973:
			this.CVBtnTrkSysSecureMultikeyOTARTx_A8676 = (global::AcpUI.AcpCustomViewCheckBox)target;
			return;
			IL_4980:
			this.gridExpanderTrunkingSystemStatusAliasTableSRecView = (global::System.Windows.Controls.Grid)target;
			return;
			IL_498D:
			this.RTDBtnTrkSysSecureMultikeyVirtualPartnerSecureClearStrapping_A43670 = (global::AcpUI.AcpRtdButton)target;
			return;
			IL_499A:
			this.RTDBtnTrkSysSecureMultikeyInterconnectSecureClearStrapping_43478 = (global::AcpUI.AcpRtdButton)target;
			return;
			IL_49A7:
			this.ExpanderTrunkingSystemSiteAliasTableTableView = (global::AcpUI.AcpGroupBox)target;
			return;
			IL_49B4:
			this.LblTrkSysFeaturesTxPowerLevel_A9557 = (global::AcpUI.AcpLabel)target;
			this.LblTrkSysFeaturesTxPowerLevel_A9557.MouseDoubleClick += new global::System.Windows.Input.MouseButtonEventHandler(this.OnFieldNameDoubleClick);
			return;
			IL_49D8:
			this.TrkSysStatusAlias_A24070_Col = (global::Infragistics.Windows.DataPresenter.UnboundField)target;
			return;
			IL_49E5:
			this.TrkSysGeneralTypeIIFrequencyBand_A12491Comp = (global::AcpUI.AcpLabel)target;
			return;
			IL_49F2:
			this.TrkSysSiteAliasRFSSAliasNumber_A8978Comp = (global::AcpUI.AcpLabel)target;
			return;
			IL_49FF:
			this.TrkSysMessageAliasMessageAliasNumber_A8500Comp = (global::AcpUI.AcpLabel)target;
			return;
			IL_4A0C:
			this.RecNavToolbarExpanderTrunkingSystemASTRO25ChannelIDTable = (global::AcpUI.AcpChildRecNavToolbar)target;
			this.RecNavToolbarExpanderTrunkingSystemASTRO25ChannelIDTable.ModeClick += this.OnModeClick;
			return;
			IL_4A30:
			this.RTDBtnTrkSysDigitalDigitalModulatorType_A7858 = (global::AcpUI.AcpRtdButton)target;
			return;
			IL_4A3D:
			this.CVBtnTrkSysASTRO25DefaultRCMAddress_A7813 = (global::AcpUI.AcpCustomViewCheckBox)target;
			return;
			IL_4A4A:
			this.RTDBtnTrkSysASTRO25ChannelIDTransmitOffsetMHz_A9416 = (global::AcpUI.AcpRtdButton)target;
			return;
			IL_4A57:
			this.RTDBtnTrkSysGeneralDataProfileSelection_A19449 = (global::AcpUI.AcpRtdButton)target;
			return;
			IL_4A64:
			this.TrkSysFeaturesZone_A9717 = (global::AcpUI.AcpComboBox)target;
			this.TrkSysFeaturesZone_A9717.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_4A88:
			this.TrkSysSecureMultikeyFailsoftSecureClearStrapping_43479Comp = (global::AcpUI.AcpLabel)target;
			return;
			IL_4A95:
			this.TrkSysGeneralRFSSID_A8980Comp = (global::AcpUI.AcpTextBoxDecHex)target;
			return;
			IL_4AA2:
			((global::Motorola.MackinawCPS.CoreFeatures.TrunkingSystem.PageTrunkingSystem)target).Loaded += this.OnLoaded;
			((global::Motorola.MackinawCPS.CoreFeatures.TrunkingSystem.PageTrunkingSystem)target).Unloaded += this.OnUnloaded;
			return;
			IL_4AD3:
			this.LblTrkSysSecureMultikeyInterconnectKeySelect_A8298 = (global::AcpUI.AcpLabel)target;
			this.LblTrkSysSecureMultikeyInterconnectKeySelect_A8298.MouseDoubleClick += new global::System.Windows.Input.MouseButtonEventHandler(this.OnFieldNameDoubleClick);
			return;
			IL_4AF7:
			this.CpyBtnTrkSysGeneralSystemKeyPresent_A9241 = (global::AcpUI.AcpCopyButton)target;
			return;
			IL_4B04:
			this.RTDBtnTrkSysLabtoolTrunkingSystemAPCOChannelIdentifierListItemID_A19965 = (global::AcpUI.AcpRtdButton)target;
			return;
			IL_4B11:
			this.CpyBtnTrkSysASTRO25BusyUpdateTimesec_A7574 = (global::AcpUI.AcpCopyButton)target;
			return;
			IL_4B1E:
			this.TrkSysDigitalFDMAFrameSyncNIDBERThreshold_A8159 = (global::AcpUI.AcpTextBoxSpinner)target;
			this.TrkSysDigitalFDMAFrameSyncNIDBERThreshold_A8159.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_4B42:
			this.ExpanderTrunkingSystemMessageAliasGrid = (global::System.Windows.Controls.Grid)target;
			return;
			IL_4B4F:
			this.LblTrkSysAstro25ChannelID_A24066 = (global::AcpUI.AcpLabel)target;
			this.LblTrkSysAstro25ChannelID_A24066.MouseDoubleClick += new global::System.Windows.Input.MouseButtonEventHandler(this.OnFieldNameDoubleClick);
			return;
			IL_4B73:
			this.LblTrkSysLabtoolNetworkID_A8565 = (global::AcpUI.AcpLabel)target;
			this.LblTrkSysLabtoolNetworkID_A8565.MouseDoubleClick += new global::System.Windows.Input.MouseButtonEventHandler(this.OnFieldNameDoubleClick);
			return;
			IL_4B97:
			this.TrkSysSiteAliasSiteAliasText_A9146Comp = (global::AcpUI.AcpLabel)target;
			return;
			IL_4BA4:
			this.CVBtnTrkSysLabtoolTrunkingSystemOneTouchListItemID_A22633 = (global::AcpUI.AcpCustomViewCheckBox)target;
			return;
			IL_4BB1:
			this.LblTrkSysLabtoolTrunkingSystemIIOBTChannelAssignmentListItemID_A19966 = (global::AcpUI.AcpLabel)target;
			this.LblTrkSysLabtoolTrunkingSystemIIOBTChannelAssignmentListItemID_A19966.MouseDoubleClick += new global::System.Windows.Input.MouseButtonEventHandler(this.OnFieldNameDoubleClick);
			return;
			IL_4BD5:
			this.RTDBtnTrkSysFeaturesZone_A9717 = (global::AcpUI.AcpRtdButton)target;
			return;
			IL_4BE2:
			this.CpyBtnTrkSysASTRO25MotorolaProprietaryFeatures_A8547 = (global::AcpUI.AcpCopyButton)target;
			return;
			IL_4BEF:
			this.TrkSysGeneralSystemType_A9252Comp = (global::AcpUI.AcpLabel)target;
			return;
			IL_4BFC:
			this.RTDBtnTrkSysGeneralRFSSDebounceTimersec_A8979 = (global::AcpUI.AcpRtdButton)target;
			return;
			IL_4C09:
			this.CVBtnTrkSysLabtoolTrunkingSystemControlChannelListItemID_A19964 = (global::AcpUI.AcpCustomViewCheckBox)target;
			return;
			IL_4C16:
			this.TrkSysGeneralTypeIIFrequencyBand_A12491 = (global::AcpUI.AcpComboBox)target;
			this.TrkSysGeneralTypeIIFrequencyBand_A12491.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_4C3A:
			this.CVBtnTrkSysSecureMultikeyVirtualPartnerKeySelect_A43669 = (global::AcpUI.AcpCustomViewCheckBox)target;
			return;
			IL_4C47:
			this.TrkSysDigitalAdaptivePower_A7509 = (global::AcpUI.AcpCheckBox)target;
			this.TrkSysDigitalAdaptivePower_A7509.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_4C6B:
			this.CVBtnTrkSysOBTChannelAssignmentListTxStartChannelNumber_A20479 = (global::AcpUI.AcpCustomViewCheckBox)target;
			return;
			IL_4C78:
			this.CpyBtnTrkSysLabtoolEnable_A8669 = (global::AcpUI.AcpCopyButton)target;
			return;
			IL_4C85:
			this.LblTrkSysSecureMultikeyFailsoftSecureClearStrapping_43479 = (global::AcpUI.AcpLabel)target;
			this.LblTrkSysSecureMultikeyFailsoftSecureClearStrapping_43479.MouseDoubleClick += new global::System.Windows.Input.MouseButtonEventHandler(this.OnFieldNameDoubleClick);
			return;
			IL_4CA9:
			this.CpyBtnTrkSysOBTChannelAssignmentListRxStartChannelNumber_A20478 = (global::AcpUI.AcpCopyButton)target;
			return;
			IL_4CB6:
			this.TrkSysASTRO25WUIDValiditySupport_A41483Comp = (global::AcpUI.AcpCheckBox)target;
			return;
			IL_4CC3:
			this.TrkSysASTRO25EndF2TDMATransmitOnOutOfRange_A1394Comp = (global::AcpUI.AcpCheckBox)target;
			return;
			IL_4CD0:
			this.HLinkLabtool = (global::System.Windows.Documents.Hyperlink)target;
			this.HLinkLabtool.Click += this.HLinkClick;
			return;
			IL_4CF4:
			this.TrkSysLabtoolTrunkingSystemMessageAliasListItemID_A19969 = (global::AcpUI.AcpComboBox)target;
			this.TrkSysLabtoolTrunkingSystemMessageAliasListItemID_A19969.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_4D18:
			this.TrkSysOBTChannelAssignmentListRxEndFrequencyMHz_A9012Comp = (global::AcpUI.AcpLabel)target;
			return;
			IL_4D25:
			this.RTDBtnTrkSysOBTChannelAssignmentListTxStartChannelNumber_A20479 = (global::AcpUI.AcpRtdButton)target;
			return;
			IL_4D32:
			this.CVBtnSiteSelectableAlertList_A42060 = (global::AcpUI.AcpCustomViewCheckBox)target;
			return;
			IL_4D3F:
			this.TrkSysStatusAliasStatusAliasNumber_A9190 = (global::AcpUI.AcpTextBoxSpinner)target;
			this.TrkSysStatusAliasStatusAliasNumber_A9190.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_4D63:
			this.CpyBtnTrkSysLabtoolTrunkingSystemMessageAliasListItemID_A19969 = (global::AcpUI.AcpCopyButton)target;
			return;
			IL_4D70:
			this.CVBtnTrkSysDigitalAdaptivePower_A7509 = (global::AcpUI.AcpCustomViewCheckBox)target;
			return;
			IL_4D7D:
			this.CVBtnTrkSysOBTChannelAssignmentListTxEndFrequencyMHz_A9529 = (global::AcpUI.AcpCustomViewCheckBox)target;
			return;
			IL_4D8A:
			this.TrkSysSecureMultikeyInterconnectSecureClearStrapping_43478 = (global::AcpUI.AcpComboBox)target;
			this.TrkSysSecureMultikeyInterconnectSecureClearStrapping_43478.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_4DAE:
			this.CpyBtnTrkSysGeneralCoverageType_A7782 = (global::AcpUI.AcpCopyButton)target;
			return;
			IL_4DBB:
			this.GrpBoxExpanderTrunkingSystemSecureMultikeyPseudo4 = (global::AcpUI.AcpGroupBox)target;
			return;
			IL_4DC8:
			this.TrkSysSecureMultikeyOTARTx_A8676Comp = (global::AcpUI.AcpCheckBox)target;
			return;
			IL_4DD5:
			this.CVBtnTrkSysGeneralSiteID_A9150 = (global::AcpUI.AcpCustomViewCheckBox)target;
			return;
			IL_4DE2:
			this.RTDBtnTrkSysFeaturesSecureLED_A9071 = (global::AcpUI.AcpRtdButton)target;
			return;
			IL_4DEF:
			this.CVBtnTrkSysASTRO25ChannelIDBaseFrequencyMHz_A7546 = (global::AcpUI.AcpCustomViewCheckBox)target;
			return;
			IL_4DFC:
			this.RTDBtnTrkSysOBTChannelAssignmentListTxEnable_A9517 = (global::AcpUI.AcpRtdButton)target;
			return;
			IL_4E09:
			this.CpyBtnTrkSysLabtoolTrunkingSystemAPCOChannelIdentifierListItemID_A19965 = (global::AcpUI.AcpCopyButton)target;
			return;
			IL_4E16:
			this.TrkSysOBTChannelRange_A24072Comp = (global::AcpUI.AcpLabel)target;
			return;
			IL_4E23:
			this.CVBtnTrkSysSiteAliasHomeRASWACNNumber_A20169 = (global::AcpUI.AcpCustomViewCheckBox)target;
			return;
			IL_4E30:
			this.CpyBtnTrkSysGeneralAskRequired_A44909 = (global::AcpUI.AcpCopyButton)target;
			return;
			IL_4E3D:
			this.ExpanderTrunkingSystemStatusAliasTableGrid = (global::System.Windows.Controls.Grid)target;
			return;
			IL_4E4A:
			this.CVBtnTrkSysASTRO25MaximumSlotSizems_A8478 = (global::AcpUI.AcpCustomViewCheckBox)target;
			return;
			IL_4E57:
			this.CVBtnTrkSysStatusAlias_A24070 = (global::AcpUI.AcpCustomViewCheckBox)target;
			return;
			IL_4E64:
			this.CpyBtnTrkSysFeaturesTxBaseTimeSec_A9512 = (global::AcpUI.AcpCopyButton)target;
			return;
			IL_4E71:
			this.TrkSysGeneralSystemKeyPresent_A9241 = (global::AcpUI.AcpLabel)target;
			this.TrkSysGeneralSystemKeyPresent_A9241.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_4E95:
			this.CpyBtnTrkSysTypeIIChannelSetupSplinterChannel_A9175 = (global::AcpUI.AcpCopyButton)target;
			return;
			IL_4EA2:
			this.TrkSysGeneralSystemKeyType_A38853Comp = (global::AcpUI.AcpLabel)target;
			return;
			IL_4EAF:
			this.GrpBoxExpanderTrunkingSystemSecureMultikeyPseudo1 = (global::AcpUI.AcpGroupBox)target;
			return;
			IL_4EBC:
			this.TrkSysSiteAliasHomeRASWACNNumber_A20169Comp = (global::AcpUI.AcpTextBoxDecHex)target;
			return;
			IL_4EC9:
			this.HLinkTypeIIChannelSetup = (global::System.Windows.Documents.Hyperlink)target;
			this.HLinkTypeIIChannelSetup.Click += this.HLinkClick;
			return;
			IL_4EED:
			this.CpyBtnTrkSysDigitalF2TDMAFrameSyncBERThreshold_A1396 = (global::AcpUI.AcpCopyButton)target;
			return;
			IL_4EFA:
			this.CVBtnTrkSysGeneralDataProfileSelection_A19449 = (global::AcpUI.AcpCustomViewCheckBox)target;
			return;
			IL_4F07:
			this.TrkSysLabtoolTrunkingSystemIIOBTChannelAssignmentListItemID_A19966Comp = (global::AcpUI.AcpLabel)target;
			return;
			IL_4F14:
			this.RTDBtnTrkSysASTRO25Phase2VoiceCapable_A37972 = (global::AcpUI.AcpRtdButton)target;
			return;
			IL_4F21:
			this.CpyBtnTrkSysMessageAliasMessageAliasNumber_A8500 = (global::AcpUI.AcpCopyButton)target;
			return;
			IL_4F2E:
			this.TrkSysGeneralSystemID_A9239Comp = (global::AcpUI.AcpTextBoxDecHex)target;
			return;
			IL_4F3B:
			this.TrkSysSecureMultikeyPrivateCallSecureClearStrapping_43477 = (global::AcpUI.AcpComboBox)target;
			this.TrkSysSecureMultikeyPrivateCallSecureClearStrapping_43477.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_4F5F:
			this.LblTrkSysOBTChannelAssignmentListRxEndFrequencyMHz_A9012 = (global::AcpUI.AcpLabel)target;
			this.LblTrkSysOBTChannelAssignmentListRxEndFrequencyMHz_A9012.MouseDoubleClick += new global::System.Windows.Input.MouseButtonEventHandler(this.OnFieldNameDoubleClick);
			return;
			IL_4F83:
			this.CpyBtnTrkSysFeaturesEnable_A7968 = (global::AcpUI.AcpCopyButton)target;
			return;
			IL_4F90:
			this.LblTrkSysLabtoolTrunkingSystemSiteAliasTextListItemID_A19972 = (global::AcpUI.AcpLabel)target;
			this.LblTrkSysLabtoolTrunkingSystemSiteAliasTextListItemID_A19972.MouseDoubleClick += new global::System.Windows.Input.MouseButtonEventHandler(this.OnFieldNameDoubleClick);
			return;
			IL_4FB4:
			this.LblTrkSysSiteAliasSiteAliasNumber_A9145 = (global::AcpUI.AcpLabel)target;
			this.LblTrkSysSiteAliasSiteAliasNumber_A9145.MouseDoubleClick += new global::System.Windows.Input.MouseButtonEventHandler(this.OnFieldNameDoubleClick);
			return;
			IL_4FD8:
			this.TrkSysFeatureLocationOnPTT_43026Comp = (global::AcpUI.AcpCheckBox)target;
			return;
			IL_4FE5:
			this.LblTrkSysOBTChannelAssignmentListRxSpacingKHz_A9004 = (global::AcpUI.AcpLabel)target;
			this.LblTrkSysOBTChannelAssignmentListRxSpacingKHz_A9004.MouseDoubleClick += new global::System.Windows.Input.MouseButtonEventHandler(this.OnFieldNameDoubleClick);
			return;
			IL_5009:
			this.LblTrkSysGeneralSystemType_A9252 = (global::AcpUI.AcpLabel)target;
			this.LblTrkSysGeneralSystemType_A9252.MouseDoubleClick += new global::System.Windows.Input.MouseButtonEventHandler(this.OnFieldNameDoubleClick);
			return;
			IL_502D:
			this.CVBtnTrkSysGeneralCoverageType_A7782 = (global::AcpUI.AcpCustomViewCheckBox)target;
			return;
			IL_503A:
			this.TrkSysAstro25ChannelID_A24066_Col = (global::Infragistics.Windows.DataPresenter.UnboundField)target;
			return;
			IL_5047:
			this.TrkSysDigitalPreambleLength_A8722Comp = (global::AcpUI.AcpLabel)target;
			return;
			IL_5054:
			this.CpyBtnSiteSelectableAlertAliasList_A42100 = (global::AcpUI.AcpCopyButton)target;
			return;
			IL_5061:
			this.LblTrkSysSecureMultikeyAutoKeyIDRx_A43185 = (global::AcpUI.AcpLabel)target;
			this.LblTrkSysSecureMultikeyAutoKeyIDRx_A43185.MouseDoubleClick += new global::System.Windows.Input.MouseButtonEventHandler(this.OnFieldNameDoubleClick);
			return;
			IL_5085:
			this.TrkSysLabtoolNetworkID_A8565Comp = (global::AcpUI.AcpTextBoxDecHex)target;
			return;
			IL_5092:
			this.GrpBoxExpanderTrunkingSystemSecureMultikeyDynamicRegrouping = (global::AcpUI.AcpGroupBox)target;
			return;
			IL_509F:
			this.TrkSysGeneralHomeWACNID_A8205Comp = (global::AcpUI.AcpTextBoxDecHex)target;
			return;
			IL_50AC:
			this.gridExpanderTrunkingSystemChannelRangesMHzSRecView = (global::System.Windows.Controls.Grid)target;
			return;
			IL_50B9:
			this.CpyBtnTrkSysOneTouchIndex_A8618 = (global::AcpUI.AcpCopyButton)target;
			return;
			IL_50C6:
			this.RTDBtnTrkSysFeaturesPASelection_A42882 = (global::AcpUI.AcpRtdButton)target;
			return;
			IL_50D3:
			this.RTDBtnTrkSysControlChannelsRxFrequencyMHz_A9018 = (global::AcpUI.AcpRtdButton)target;
			return;
			IL_50E0:
			this.RTDBtnTrkSysSiteAliasSiteAliasNumber_A9145 = (global::AcpUI.AcpRtdButton)target;
			return;
			IL_50ED:
			this.LblTrkSysSecureMultikeyPrivateCallSecureClearStrapping_43477 = (global::AcpUI.AcpLabel)target;
			this.LblTrkSysSecureMultikeyPrivateCallSecureClearStrapping_43477.MouseDoubleClick += new global::System.Windows.Input.MouseButtonEventHandler(this.OnFieldNameDoubleClick);
			return;
			IL_5111:
			this.CpyBtnTrkSysFeaturesEmergencyAlarmRxIndicator_A7932 = (global::AcpUI.AcpCopyButton)target;
			return;
			IL_511E:
			this.TrkSysGeneralUnitID_A12651 = (global::AcpUI.AcpTextBoxSpinnerDecHex)target;
			this.TrkSysGeneralUnitID_A12651.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_5142:
			this.LblTrkSysSecureMultikeyVirtualPartnerKeySelect_A43669 = (global::AcpUI.AcpLabel)target;
			this.LblTrkSysSecureMultikeyVirtualPartnerKeySelect_A43669.MouseDoubleClick += new global::System.Windows.Input.MouseButtonEventHandler(this.OnFieldNameDoubleClick);
			return;
			IL_5166:
			this.RTDBtnTrkSysLabtoolTrunkingSystemIIOBTChannelAssignmentListItemID_A19966 = (global::AcpUI.AcpRtdButton)target;
			return;
			IL_5173:
			this.TrkSysTypeIIChannelSetupChannelAssignmentType_A7652Comp = (global::AcpUI.AcpLabel)target;
			return;
			IL_5180:
			this.TrkSysSecureMultikeyPatchKeySelect_A8694 = (global::AcpUI.AcpComboBox)target;
			this.TrkSysSecureMultikeyPatchKeySelect_A8694.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_51A4:
			this.TrkSysAstro25ChannelID_A24066Comp = (global::AcpUI.AcpLabel)target;
			return;
			IL_51B1:
			this.RTDBtnTrkSysASTRO25QuickFadeProtectms_A8807 = (global::AcpUI.AcpRtdButton)target;
			return;
			IL_51BE:
			this.RTDBtnTrkSysSecureMultikeyPatchKeySelect_A8694 = (global::AcpUI.AcpRtdButton)target;
			return;
			IL_51CB:
			this.RTDBtnTrkSysFeaturesRadioInhibit_A8833 = (global::AcpUI.AcpRtdButton)target;
			return;
			IL_51D8:
			this.LblTrkSysSecureMultikeyKMFProfileIndex_A8382 = (global::AcpUI.AcpLabel)target;
			this.LblTrkSysSecureMultikeyKMFProfileIndex_A8382.MouseDoubleClick += new global::System.Windows.Input.MouseButtonEventHandler(this.OnFieldNameDoubleClick);
			return;
			IL_51FC:
			this.LblTrkSysOBTChannelAssignmentListTxStartChannelNumber_A20479 = (global::AcpUI.AcpLabel)target;
			this.LblTrkSysOBTChannelAssignmentListTxStartChannelNumber_A20479.MouseDoubleClick += new global::System.Windows.Input.MouseButtonEventHandler(this.OnFieldNameDoubleClick);
			return;
			IL_5220:
			this.RTDBtnTrkSysFeaturesTxBaseTimeSec_A9512 = (global::AcpUI.AcpRtdButton)target;
			return;
			IL_522D:
			this.TrkSysASTRO25ISPSequenceLengthsec_A8354 = (global::AcpUI.AcpTextBoxSpinner)target;
			this.TrkSysASTRO25ISPSequenceLengthsec_A8354.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_5251:
			this.RTDBtnTrkSysASTRO25EndPhase2TDMATransmitOnOutOfRange_A37980 = (global::AcpUI.AcpRtdButton)target;
			return;
			IL_525E:
			this.TrkSysSiteAliasSystemNumber_A19669Comp = (global::AcpUI.AcpTextBoxDecHex)target;
			return;
			IL_526B:
			this.RTDBtnTrkSysFeaturesDynamicRegroupingEnable_A7969 = (global::AcpUI.AcpRtdButton)target;
			return;
			IL_5278:
			this.TrkSysGeneralRFSSResponseTimems_A8981Comp = (global::AcpUI.AcpLabel)target;
			return;
			IL_5285:
			this.TrkSysTypeIIChannelSetupShuffledBandPlan_A9128 = (global::AcpUI.AcpCheckBox)target;
			this.TrkSysTypeIIChannelSetupShuffledBandPlan_A9128.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_52A9:
			this.TrkSysTypeIIChannelSetupSplinterChannel_A9175Comp = (global::AcpUI.AcpCheckBox)target;
			return;
			IL_52B6:
			this.TrkSysFeaturesDTMFTimingTable_A7900 = (global::AcpUI.AcpComboBox)target;
			this.TrkSysFeaturesDTMFTimingTable_A7900.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_52DA:
			this.LblTrkSysASTRO25Phase2VoiceCapable_A37972 = (global::AcpUI.AcpLabel)target;
			this.LblTrkSysASTRO25Phase2VoiceCapable_A37972.MouseDoubleClick += new global::System.Windows.Input.MouseButtonEventHandler(this.OnFieldNameDoubleClick);
			return;
			IL_52FE:
			this.TrkSysOneTouchFeature_A8614_Col = (global::Infragistics.Windows.DataPresenter.UnboundField)target;
			return;
			IL_530B:
			this.TrkSysSiteAliasSiteAliasEnable_A9148Comp = (global::AcpUI.AcpCheckBox)target;
			return;
			IL_5318:
			this.TrkSysSecureMultikeySystemWideKeySelect_A9253Comp = (global::AcpUI.AcpLabel)target;
			return;
			IL_5325:
			this.RTDBtnTrkSysTypeIIChannelSetupLegacyTransitSystem_A8429 = (global::AcpUI.AcpRtdButton)target;
			return;
			IL_5332:
			this.CVBtnTrkSysGeneralConnectToneHz_A7710 = (global::AcpUI.AcpCustomViewCheckBox)target;
			return;
			IL_533F:
			this.TrkSysASTRO25QuickFadeProtectms_A8807Comp = (global::AcpUI.AcpLabel)target;
			return;
			IL_534C:
			this.TrkSysLabtoolTrunkingSystemSiteAliasListItemID_A19971 = (global::AcpUI.AcpComboBox)target;
			this.TrkSysLabtoolTrunkingSystemSiteAliasListItemID_A19971.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_5370:
			this.ExpanderTrunkingSystemControlChannelsTable = (global::AcpUI.AcpXamDataPresenter)target;
			return;
			IL_537D:
			this.TrkSysFeaturesTxPowerLevel_A9557 = (global::AcpUI.AcpComboBox)target;
			this.TrkSysFeaturesTxPowerLevel_A9557.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_53A1:
			this.CpyBtnTrkSysLTEInterferingFreqPresent_A42198 = (global::AcpUI.AcpCopyButton)target;
			return;
			IL_53AE:
			this.LblTrkSysFeaturesPASelection_A42882 = (global::AcpUI.AcpLabel)target;
			this.LblTrkSysFeaturesPASelection_A42882.MouseDoubleClick += new global::System.Windows.Input.MouseButtonEventHandler(this.OnFieldNameDoubleClick);
			return;
			IL_53D2:
			this.LblTrkSysLabtoolTrunkingSystemSiteAliasListItemID_A19971 = (global::AcpUI.AcpLabel)target;
			this.LblTrkSysLabtoolTrunkingSystemSiteAliasListItemID_A19971.MouseDoubleClick += new global::System.Windows.Input.MouseButtonEventHandler(this.OnFieldNameDoubleClick);
			return;
			IL_53F6:
			this.GrpBoxExpanderTrunkingSystemDigitalPseudo0 = (global::AcpUI.AcpGroupBox)target;
			return;
			IL_5403:
			this.TrkSysASTRO25ChannelIDTransmitOffsetSign_A9417Comp = (global::AcpUI.AcpLabel)target;
			return;
			IL_5410:
			this.TrkSysGeneralKeyofTrunkingSystem_A12658 = (global::AcpUI.AcpTextBox)target;
			this.TrkSysGeneralKeyofTrunkingSystem_A12658.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_5434:
			this.TrkSysSiteAliasSiteAliasType_A41343Comp = (global::AcpUI.AcpLabel)target;
			return;
			IL_5441:
			this.RTDBtnTrkSysSecureMultikeyFailsoftKeySelect_A8012 = (global::AcpUI.AcpRtdButton)target;
			return;
			IL_544E:
			this.TrkSysLabtoolEnable_A8669 = (global::AcpUI.AcpCheckBox)target;
			this.TrkSysLabtoolEnable_A8669.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_5472:
			this.TrkSysASTRO25F2VoiceCapable_A1395 = (global::AcpUI.AcpCheckBox)target;
			this.TrkSysASTRO25F2VoiceCapable_A1395.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_5496:
			this.CVBtnTrkSysFeaturesRadioInhibit_A8833 = (global::AcpUI.AcpCustomViewCheckBox)target;
			return;
			IL_54A3:
			this.TrkSysFeaturesBusyLED_44911Comp = (global::AcpUI.AcpCheckBox)target;
			return;
			IL_54B0:
			this.LblTrkSysMessageAliasMessageAliasNumber_A8500 = (global::AcpUI.AcpLabel)target;
			this.LblTrkSysMessageAliasMessageAliasNumber_A8500.MouseDoubleClick += new global::System.Windows.Input.MouseButtonEventHandler(this.OnFieldNameDoubleClick);
			return;
			IL_54D4:
			this.CpyBtnTrkSysTypeIIChannelSetupLegacyTransitSystem_A8429 = (global::AcpUI.AcpCopyButton)target;
			return;
			IL_54E1:
			this.CpyBtnTrkSysOneTouchFeature_A8614 = (global::AcpUI.AcpCopyButton)target;
			return;
			IL_54EE:
			this.RTDBtnTrkSysASTRO25BusyUpdateTimesec_A7574 = (global::AcpUI.AcpRtdButton)target;
			return;
			IL_54FB:
			this.TrkSysOBTChannelRange_A24072 = (global::AcpUI.AcpLabel)target;
			this.TrkSysOBTChannelRange_A24072.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_551F:
			this.TrkSysOBTChannelAssignmentListTxSpacingKHz_A9520 = (global::AcpUI.AcpComboBox)target;
			this.TrkSysOBTChannelAssignmentListTxSpacingKHz_A9520.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_5543:
			this.LblTrkSysMessageAliasMessageAliasEnable_A8505 = (global::AcpUI.AcpLabel)target;
			this.LblTrkSysMessageAliasMessageAliasEnable_A8505.MouseDoubleClick += new global::System.Windows.Input.MouseButtonEventHandler(this.OnFieldNameDoubleClick);
			return;
			IL_5567:
			this.ExpanderTrunkingSystemControlChannelsTableGrid = (global::System.Windows.Controls.Grid)target;
			return;
			IL_5574:
			this.TrkSysFeaturesOTARadioAliasUpdateEnable_A43057 = (global::AcpUI.AcpCheckBox)target;
			this.TrkSysFeaturesOTARadioAliasUpdateEnable_A43057.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_5598:
			this.CVBtnTrkSysOneTouchButton_A19763 = (global::AcpUI.AcpCustomViewCheckBox)target;
			return;
			IL_55A5:
			this.RTDBtnTrkSysGeneralTypeIIFrequencyBand_A12491 = (global::AcpUI.AcpRtdButton)target;
			return;
			IL_55B2:
			this.CpyBtnTrkSysStatusAliasStatusAliasEnable_A9195 = (global::AcpUI.AcpCopyButton)target;
			return;
			IL_55BF:
			this.TrkSysTypeIIChannelSetupChannelBandwidthkHz_A7654 = (global::AcpUI.AcpComboBox)target;
			this.TrkSysTypeIIChannelSetupChannelBandwidthkHz_A7654.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_55E3:
			this.CVBtnTrkSysFeaturesBusyLED_44911 = (global::AcpUI.AcpCustomViewCheckBox)target;
			return;
			IL_55F0:
			this.RTDBtnTrkSysASTRO25ChannelIDChannelSpacingkHz_A7660 = (global::AcpUI.AcpRtdButton)target;
			return;
			IL_55FD:
			this.LblTrkSysGeneralSystemKeyType_A38853 = (global::AcpUI.AcpLabel)target;
			this.LblTrkSysGeneralSystemKeyType_A38853.MouseDoubleClick += new global::System.Windows.Input.MouseButtonEventHandler(this.OnFieldNameDoubleClick);
			return;
			IL_5621:
			this.HLinkSiteAlias = (global::System.Windows.Documents.Hyperlink)target;
			this.HLinkSiteAlias.Click += this.HLinkClick;
			return;
			IL_5645:
			this.TrkSysASTRO25EndF2TDMATransmitOnOutOfRange_A1394 = (global::AcpUI.AcpCheckBox)target;
			this.TrkSysASTRO25EndF2TDMATransmitOnOutOfRange_A1394.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_5669:
			this.RTDBtnTrkSysMessageAliasMessageAliasNumber_A8500 = (global::AcpUI.AcpRtdButton)target;
			return;
			IL_5676:
			this.CVBtnTrkSysASTRO25BusyUpdateTimesec_A7574 = (global::AcpUI.AcpCustomViewCheckBox)target;
			return;
			IL_5683:
			this.TrkSysSiteAliasSiteAliasNumber_A9145_Col = (global::Infragistics.Windows.DataPresenter.UnboundField)target;
			return;
			IL_5690:
			this.CVBtnTrkSysLabtoolTrunkingSystemStatusAliasListItemID_A19967 = (global::AcpUI.AcpCustomViewCheckBox)target;
			return;
			IL_569D:
			this.RTDBtnTrkSysStatusAliasStatusAliasText_A9193 = (global::AcpUI.AcpRtdButton)target;
			return;
			IL_56AA:
			this.CVBtnTrkSysASTRO25EndPhase2TDMATransmitOnOutOfRange_A37980 = (global::AcpUI.AcpCustomViewCheckBox)target;
			return;
			IL_56B7:
			this.GrpBoxExpanderTrunkingSystemFeaturesRadioErgo = (global::AcpUI.AcpGroupBox)target;
			return;
			IL_56C4:
			this.LblTrkSysSecureMultikeyDynamicSecureClearStrapping_43489 = (global::AcpUI.AcpLabel)target;
			this.LblTrkSysSecureMultikeyDynamicSecureClearStrapping_43489.MouseDoubleClick += new global::System.Windows.Input.MouseButtonEventHandler(this.OnFieldNameDoubleClick);
			return;
			IL_56E8:
			this.RTDBtnTrkSysMessageAliasMessageAliasText_A8503 = (global::AcpUI.AcpRtdButton)target;
			return;
			IL_56F5:
			this.TrkSysSiteAliasSystemNumber_A19669_Col = (global::Infragistics.Windows.DataPresenter.UnboundField)target;
			return;
			IL_570F:
			this.CpyBtnTrkSysOBTChannelAssignmentListRxSpacingKHz_A9004 = (global::AcpUI.AcpCopyButton)target;
			return;
			IL_571C:
			this.LblTrkSysOBTChannelAssignmentListRxEnable_A9001 = (global::AcpUI.AcpLabel)target;
			this.LblTrkSysOBTChannelAssignmentListRxEnable_A9001.MouseDoubleClick += new global::System.Windows.Input.MouseButtonEventHandler(this.OnFieldNameDoubleClick);
			return;
			IL_5740:
			this.TrkSysOneTouchAbbreviatedOneTouchAlias_A8622 = (global::AcpUI.AcpTextBox)target;
			this.TrkSysOneTouchAbbreviatedOneTouchAlias_A8622.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_5764:
			this.CVBtnTrkSysLabtoolTrunkingSystemSiteAliasTextListItemID_A19972 = (global::AcpUI.AcpCustomViewCheckBox)target;
			return;
			IL_5771:
			this.TrkSysFeaturesICUAReset_A8249 = (global::AcpUI.AcpComboBox)target;
			this.TrkSysFeaturesICUAReset_A8249.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_5795:
			this.ExpanderTrunkingSystemChannelRangesMHzTableView = (global::AcpUI.AcpGroupBox)target;
			return;
			IL_57A2:
			this.RTDBtnTrkSysGeneralAskRequired_A44909 = (global::AcpUI.AcpRtdButton)target;
			return;
			IL_57AF:
			this.CVBtnTrkSysOBTChannelAssignmentListRxEnable_A9001 = (global::AcpUI.AcpCustomViewCheckBox)target;
			return;
			IL_57BC:
			this.LblTrkSysASTRO25EndPhase2TDMATransmitOnOutOfRange_A37980 = (global::AcpUI.AcpLabel)target;
			this.LblTrkSysASTRO25EndPhase2TDMATransmitOnOutOfRange_A37980.MouseDoubleClick += new global::System.Windows.Input.MouseButtonEventHandler(this.OnFieldNameDoubleClick);
			return;
			IL_57E0:
			this.TrkSysSecureMultikeyVirtualPartnerKeySelect_A43669 = (global::AcpUI.AcpComboBox)target;
			this.TrkSysSecureMultikeyVirtualPartnerKeySelect_A43669.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_5804:
			this.CVBtnTrkSysMsgAlias_A24069 = (global::AcpUI.AcpCustomViewCheckBox)target;
			return;
			IL_5811:
			this.RTDBtnTrkSysTypeIIChannelSetupSplinterChannel_A9175 = (global::AcpUI.AcpRtdButton)target;
			return;
			IL_581E:
			this.TrkSysLabtoolTrunkingSystemIIOBTChannelAssignmentListItemID_A19966 = (global::AcpUI.AcpComboBox)target;
			this.TrkSysLabtoolTrunkingSystemIIOBTChannelAssignmentListItemID_A19966.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_5842:
			this.HLinkMessageAlias = (global::System.Windows.Documents.Hyperlink)target;
			this.HLinkMessageAlias.Click += this.HLinkClick;
			return;
			IL_5866:
			this.CVBtnTrkSysTypeIIChannelSetupChannelBandwidthkHz_A7654 = (global::AcpUI.AcpCustomViewCheckBox)target;
			return;
			IL_5873:
			this.TrkSysFeaturesHearClear_A36422 = (global::AcpUI.AcpComboBox)target;
			this.TrkSysFeaturesHearClear_A36422.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_5897:
			this.LblTrkSysFeaturesICUAReset_A8249 = (global::AcpUI.AcpLabel)target;
			this.LblTrkSysFeaturesICUAReset_A8249.MouseDoubleClick += new global::System.Windows.Input.MouseButtonEventHandler(this.OnFieldNameDoubleClick);
			return;
			IL_58BB:
			this.CpyBtnTrkSysOBTChannelAssignmentListTxStartChannelNumber_A20479 = (global::AcpUI.AcpCopyButton)target;
			return;
			IL_58C8:
			this.RTDBtnTrkSysSecureMultikeySystemWideKeySelect_A9253 = (global::AcpUI.AcpRtdButton)target;
			return;
			IL_58D5:
			this.CpyBtnTrkSysOneTouchAbbreviatedOneTouchAlias_A8622 = (global::AcpUI.AcpCopyButton)target;
			return;
			IL_58E2:
			this.ExpanderTrunkingSystemStatusAliasGrid = (global::System.Windows.Controls.Grid)target;
			return;
			IL_58EF:
			this.TrkSysSecureMultikeyDESXLTxRxDefault_A7833 = (global::AcpUI.AcpCheckBox)target;
			this.TrkSysSecureMultikeyDESXLTxRxDefault_A7833.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_5913:
			this.LblTrkSysMsgAlias_A24069 = (global::AcpUI.AcpLabel)target;
			this.LblTrkSysMsgAlias_A24069.MouseDoubleClick += new global::System.Windows.Input.MouseButtonEventHandler(this.OnFieldNameDoubleClick);
			return;
			IL_5937:
			this.TrkSysOBTChannelAssignmentListTxStartChannelNumber_A20479 = (global::AcpUI.AcpTextBoxSpinnerDecHex)target;
			this.TrkSysOBTChannelAssignmentListTxStartChannelNumber_A20479.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_595B:
			this.RTDBtnTrkSysTypeIIChannelSetupNPSPACChannelBandwidthkHz_A8571 = (global::AcpUI.AcpRtdButton)target;
			return;
			IL_5968:
			this.CVBtnTrkSysASTRO25ResponsePendingTimesec_A8945 = (global::AcpUI.AcpCustomViewCheckBox)target;
			return;
			IL_5975:
			this.CpyBtnTrkSysMessageAliasMessageAliasEnable_A8505 = (global::AcpUI.AcpCopyButton)target;
			return;
			IL_5982:
			this.CpyBtnTrkSysSecureMultikeyDynamicAGKeySelect_A7914 = (global::AcpUI.AcpCopyButton)target;
			return;
			IL_598F:
			this.RTDBtnTrkSysSecureMultikeyVirtualPartnerKeySelect_A43669 = (global::AcpUI.AcpRtdButton)target;
			return;
			IL_599C:
			this.TrkSysFeaturesEmergencyAlarmRxIndicator_A7932Comp = (global::AcpUI.AcpCheckBox)target;
			return;
			IL_59A9:
			this.TrkSysOBTChannelAssignmentListRxSpacingKHz_A9004Comp = (global::AcpUI.AcpLabel)target;
			return;
			IL_59B6:
			this.RTDBtnTrkSysSiteAliasSiteAliasText_A9146 = (global::AcpUI.AcpRtdButton)target;
			return;
			IL_59C3:
			this.CVBtnTrkSysASTRO25ValidateNACAgainstSystemID_A20608 = (global::AcpUI.AcpCustomViewCheckBox)target;
			return;
			IL_59D0:
			this.TrkSysFeaturesChannel_A7647Comp = (global::AcpUI.AcpLabel)target;
			return;
			IL_59DD:
			this.TrkSysGeneralAskRequired_A44909 = (global::AcpUI.AcpCheckBox)target;
			this.TrkSysGeneralAskRequired_A44909.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_5A01:
			this.TrkSysFeaturesICUAAutoResetTimesec_A7515 = (global::AcpUI.AcpTextBoxSpinner)target;
			this.TrkSysFeaturesICUAAutoResetTimesec_A7515.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_5A25:
			this.CpyBtnTrkSysASTRO25ChannelIDTransmitOffsetMHz_A9416 = (global::AcpUI.AcpCopyButton)target;
			return;
			IL_5A32:
			this.LblTrkSysStatusAliasStatusAliasEnable_A9195 = (global::AcpUI.AcpLabel)target;
			this.LblTrkSysStatusAliasStatusAliasEnable_A9195.MouseDoubleClick += new global::System.Windows.Input.MouseButtonEventHandler(this.OnFieldNameDoubleClick);
			return;
			IL_5A56:
			this.CpyBtnTrkSysGeneralConnectToneHz_A7710 = (global::AcpUI.AcpCopyButton)target;
			return;
			IL_5A63:
			this.TrkSysLabtoolNetworkID_A8565 = (global::AcpUI.AcpTextBoxSpinnerDecHex)target;
			this.TrkSysLabtoolNetworkID_A8565.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_5A87:
			this.TrkSysOBTChannelAssignmentListRxEnable_A9001 = (global::AcpUI.AcpCheckBox)target;
			this.TrkSysOBTChannelAssignmentListRxEnable_A9001.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_5AAB:
			this.TrkSysSecureMultikeyFailsoftSecureClearStrapping_43479 = (global::AcpUI.AcpComboBox)target;
			this.TrkSysSecureMultikeyFailsoftSecureClearStrapping_43479.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_5ACF:
			this.RTDBtnTrkSysOBTChannelAssignmentListRxEnable_A9001 = (global::AcpUI.AcpRtdButton)target;
			return;
			IL_5ADC:
			this.LblTrkSysDigitalFDMAFrameSyncNIDBERThreshold_A8159 = (global::AcpUI.AcpLabel)target;
			this.LblTrkSysDigitalFDMAFrameSyncNIDBERThreshold_A8159.MouseDoubleClick += new global::System.Windows.Input.MouseButtonEventHandler(this.OnFieldNameDoubleClick);
			return;
			IL_5B00:
			this.TrkSysLabtoolTrunkingSystemSiteAliasTextListItemID_A19972 = (global::AcpUI.AcpComboBox)target;
			this.TrkSysLabtoolTrunkingSystemSiteAliasTextListItemID_A19972.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_5B24:
			this.TrkSysGeneralNonAdjacentSiteSearch_A8568Comp = (global::AcpUI.AcpCheckBox)target;
			return;
			IL_5B31:
			this.ExpanderTrunkingSystemSiteAliasTableSRecView = (global::AcpUI.AcpGroupBox)target;
			return;
			IL_5B3E:
			this.CVBtnTrkSysSecureMultikeyDynamicTalkgroupKeySelect_A7918 = (global::AcpUI.AcpCustomViewCheckBox)target;
			return;
			IL_5B4B:
			this.HLinkOneTouch = (global::System.Windows.Documents.Hyperlink)target;
			this.HLinkOneTouch.Click += this.HLinkClick;
			return;
			IL_5B6F:
			this.GrpBoxExpanderTrunkingSystemFeaturesInCallUserAlert = (global::AcpUI.AcpGroupBox)target;
			return;
			IL_5B7C:
			this.LblTrkSysSecureMultikeySystemWideKeySelect_A9253 = (global::AcpUI.AcpLabel)target;
			this.LblTrkSysSecureMultikeySystemWideKeySelect_A9253.MouseDoubleClick += new global::System.Windows.Input.MouseButtonEventHandler(this.OnFieldNameDoubleClick);
			return;
			IL_5BA0:
			this.CpyBtnTrkSysTypeIIChannelSetupNPSPACChannelBandwidthkHz_A8571 = (global::AcpUI.AcpCopyButton)target;
			return;
			IL_5BAD:
			this.CpyBtnTrkSysStatusAliasStatusAliasText_A9193 = (global::AcpUI.AcpCopyButton)target;
			return;
			IL_5BBA:
			this.LblTrkSysASTRO25ValidateNACAgainstSystemID_A20608 = (global::AcpUI.AcpLabel)target;
			this.LblTrkSysASTRO25ValidateNACAgainstSystemID_A20608.MouseDoubleClick += new global::System.Windows.Input.MouseButtonEventHandler(this.OnFieldNameDoubleClick);
			return;
			IL_5BDE:
			this.CpyBtnTrkSysGeneralTypeIIFrequencyBand_A12491 = (global::AcpUI.AcpCopyButton)target;
			return;
			IL_5BEB:
			this.RTDBtnTrkSysASTRO25ChannelIDBaseFrequencyMHz_A7546 = (global::AcpUI.AcpRtdButton)target;
			return;
			IL_5BF8:
			this.CVBtnTrkSysSiteAliasSiteAliasText_A9146 = (global::AcpUI.AcpCustomViewCheckBox)target;
			return;
			IL_5C05:
			this.CpyBtnTrkSysFeaturesBusyLED_44911 = (global::AcpUI.AcpCopyButton)target;
			return;
			IL_5C12:
			this.RTDBtnTrkSysFeaturesTxPowerLevel_A9557 = (global::AcpUI.AcpRtdButton)target;
			return;
			IL_5C1F:
			this.RTDBtnTrkSysSiteAliasHomeRASWACNNumber_A20169 = (global::AcpUI.AcpRtdButton)target;
			return;
			IL_5C2C:
			this.CpyBtnTrkSysMsgAlias_A24069 = (global::AcpUI.AcpCopyButton)target;
			return;
			IL_5C39:
			this.RTDBtnTrkSysGeneralSystemKeyPresent_A9241 = (global::AcpUI.AcpRtdButton)target;
			return;
			IL_5C46:
			this.ExpanderTrunkingSystemOBTChannelAssignmentGrid = (global::System.Windows.Controls.Grid)target;
			return;
			IL_5C53:
			this.ExpanderTrunkingSystemControlChannelsTableSRecView = (global::AcpUI.AcpGroupBox)target;
			return;
			IL_5C60:
			this.TrkSysOneTouchButton_A19763_Col = (global::Infragistics.Windows.DataPresenter.UnboundField)target;
			return;
			IL_5C6D:
			this.TrkSysASTRO25ResponsePendingTimesec_A8945Comp = (global::AcpUI.AcpLabel)target;
			return;
			IL_5C7A:
			this.ExpanderTrunkingSystemOneTouch = (global::AcpUI.AcpExpander)target;
			return;
			IL_5C87:
			this.SiteSelectableAlertList_A42060Comp = (global::AcpUI.AcpLabel)target;
			return;
			IL_5C94:
			this.RTDBtnTrkSysSecureMultikeyAutoKeyIDRx_A43185 = (global::AcpUI.AcpRtdButton)target;
			return;
			IL_5CA1:
			this.HLinkFeatures = (global::System.Windows.Documents.Hyperlink)target;
			this.HLinkFeatures.Click += this.HLinkClick;
			return;
			IL_5CC5:
			this.GrpBoxExpanderTrunkingSystemSecureMultikeyOTAR = (global::AcpUI.AcpGroupBox)target;
			return;
			IL_5CD2:
			this.TrkSysMessageAliasMessageAliasEnable_A8505 = (global::AcpUI.AcpCheckBox)target;
			this.TrkSysMessageAliasMessageAliasEnable_A8505.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_5CF6:
			this.HLinkDigital = (global::System.Windows.Documents.Hyperlink)target;
			this.HLinkDigital.Click += this.HLinkClick;
			return;
			IL_5D1A:
			this.GrpBoxExpanderTrunkingSystemFeaturesPseudo5 = (global::AcpUI.AcpGroupBox)target;
			return;
			IL_5D27:
			this.RTDBtnTrkSysOBTChannelAssignmentListRxStartChannelNumber_A20478 = (global::AcpUI.AcpRtdButton)target;
			return;
			IL_5D34:
			this.TrkSysOneTouchIndex_A8618 = (global::AcpUI.AcpTextBoxSpinner)target;
			this.TrkSysOneTouchIndex_A8618.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_5D58:
			this.TrkSysOBTChannelAssignmentListRxStartFrequencyMHz_A9029 = (global::AcpUI.AcpTextBox)target;
			this.TrkSysOBTChannelAssignmentListRxStartFrequencyMHz_A9029.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_5D7C:
			this.LblTrkSysGeneralFailsoftConnectToneHz_A8007 = (global::AcpUI.AcpLabel)target;
			this.LblTrkSysGeneralFailsoftConnectToneHz_A8007.MouseDoubleClick += new global::System.Windows.Input.MouseButtonEventHandler(this.OnFieldNameDoubleClick);
			return;
			IL_5DA0:
			this.b = true;
		}

		// Token: 0x0600152B RID: 5419 RVA: 0x00142DB4 File Offset: 0x00140FB4
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		[global::System.CodeDom.Compiler.GeneratedCode("PresentationBuildTasks", "5.0.10.0")]
		[global::System.Diagnostics.DebuggerNonUserCode]
		void global::System.Windows.Markup.IStyleConnector.Connect(int connectionId, object target)
		{
			switch (connectionId)
			{
			case 3:
				((global::AcpUI.AcpTableViewOnlyCtrl)target).GotFocus += this.OnFieldNameDoubleClick;
				return;
			case 4:
				((global::AcpUI.AcpTableCheckBox)target).GotFocus += this.OnFieldNameDoubleClick;
				return;
			case 5:
				((global::AcpUI.AcpTableComboBox)target).GotFocus += this.OnFieldNameDoubleClick;
				return;
			case 6:
				break;
			case 7:
				((global::AcpUI.AcpTableTextBox)target).GotFocus += this.OnFieldNameDoubleClick;
				return;
			case 8:
				((global::AcpUI.AcpTableCheckBox)target).GotFocus += this.OnFieldNameDoubleClick;
				return;
			case 9:
				((global::AcpUI.AcpTableComboBox)target).GotFocus += this.OnFieldNameDoubleClick;
				return;
			case 10:
				((global::AcpUI.AcpTableTextBox)target).GotFocus += this.OnFieldNameDoubleClick;
				return;
			case 11:
				((global::AcpUI.AcpTableTextBox)target).GotFocus += this.OnFieldNameDoubleClick;
				return;
			case 12:
				((global::AcpUI.AcpTableTextBoxSpinnerDecHex)target).GotFocus += this.OnFieldNameDoubleClick;
				return;
			case 13:
				((global::AcpUI.AcpTableTextBoxSpinnerDecHex)target).GotFocus += this.OnFieldNameDoubleClick;
				return;
			case 14:
				((global::AcpUI.AcpTableTextBox)target).GotFocus += this.OnFieldNameDoubleClick;
				return;
			case 15:
				((global::AcpUI.AcpTableTextBox)target).GotFocus += this.OnFieldNameDoubleClick;
				return;
			case 16:
				((global::AcpUI.AcpTableViewOnlyCtrl)target).GotFocus += this.OnFieldNameDoubleClick;
				return;
			case 17:
				((global::AcpUI.AcpTableCheckBox)target).GotFocus += this.OnFieldNameDoubleClick;
				return;
			case 18:
				((global::AcpUI.AcpTableComboBox)target).GotFocus += this.OnFieldNameDoubleClick;
				return;
			case 19:
				((global::AcpUI.AcpTableComboBox)target).GotFocus += this.OnFieldNameDoubleClick;
				return;
			case 20:
				((global::AcpUI.AcpTableTextBox)target).GotFocus += this.OnFieldNameDoubleClick;
				return;
			case 21:
				((global::AcpUI.AcpTableTextBox)target).GotFocus += this.OnFieldNameDoubleClick;
				return;
			case 22:
			{
				short num = (short)1380679750;
				short num2 = num;
				num = (short)864714822;
				switch ((num2 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					goto IL_174;
				case 1:
					break;
				default:
				{
					num = (short)253493248;
					short num3 = num;
					break;
				}
				}
				num = (short)568721408;
				if (num != 0)
				{
				}
				((global::AcpUI.AcpTableTextBox)target).GotFocus += this.OnFieldNameDoubleClick;
				return;
			}
			case 23:
				((global::AcpUI.AcpTableViewOnlyCtrl)target).GotFocus += this.OnFieldNameDoubleClick;
				return;
			case 24:
				((global::AcpUI.AcpTableTextBoxSpinner)target).GotFocus += this.OnFieldNameDoubleClick;
				return;
			case 25:
				((global::AcpUI.AcpTableTextBox)target).GotFocus += this.OnFieldNameDoubleClick;
				return;
			case 26:
			{
				short num = (short)857210881;
				if (num != 0)
				{
				}
				((global::AcpUI.AcpTableViewOnlyCtrl)target).GotFocus += this.OnFieldNameDoubleClick;
				return;
			}
			case 27:
				((global::AcpUI.AcpTableTextBoxSpinner)target).GotFocus += this.OnFieldNameDoubleClick;
				return;
			case 28:
				((global::AcpUI.AcpTableTextBox)target).GotFocus += this.OnFieldNameDoubleClick;
				return;
			case 29:
				((global::AcpUI.AcpTableViewOnlyCtrl)target).GotFocus += this.OnFieldNameDoubleClick;
				return;
			case 30:
				((global::AcpUI.AcpTableTextBoxSpinner)target).GotFocus += this.OnFieldNameDoubleClick;
				return;
			case 31:
				((global::AcpUI.AcpTableTextBoxSpinnerDecHex)target).GotFocus += this.OnFieldNameDoubleClick;
				return;
			case 32:
				((global::AcpUI.AcpTableTextBox)target).GotFocus += this.OnFieldNameDoubleClick;
				return;
			case 33:
				((global::AcpUI.AcpTableComboBox)target).GotFocus += this.OnFieldNameDoubleClick;
				return;
			case 34:
				((global::AcpUI.AcpTableTextBoxSpinnerDecHex)target).GotFocus += this.OnFieldNameDoubleClick;
				return;
			case 35:
				((global::AcpUI.AcpTableTextBoxSpinnerDecHex)target).GotFocus += this.OnFieldNameDoubleClick;
				return;
			case 36:
				((global::AcpUI.AcpTableViewOnlyCtrl)target).GotFocus += this.OnFieldNameDoubleClick;
				return;
			case 37:
				((global::AcpUI.AcpTableComboBox)target).GotFocus += this.OnFieldNameDoubleClick;
				return;
			case 38:
				((global::AcpUI.AcpTableTextBoxSpinner)target).GotFocus += this.OnFieldNameDoubleClick;
				return;
			case 39:
				((global::AcpUI.AcpTableTextBox)target).GotFocus += this.OnFieldNameDoubleClick;
				return;
			default:
				return;
			}
			IL_174:
			((global::AcpUI.AcpTableTextBox)target).GotFocus += this.OnFieldNameDoubleClick;
		}

		// Token: 0x0400047E RID: 1150
		private bool a;

		// Token: 0x0400047F RID: 1151
		internal global::AcpUI.AcpParentRecNavToolbar RecNavToolbarPageTrunkingSystem;

		// Token: 0x04000480 RID: 1152
		internal global::AcpUI.Common.AcpThemeBase ThemeBaseObj;

		// Token: 0x04000481 RID: 1153
		internal global::System.Windows.Documents.Hyperlink HLinkGeneral;

		// Token: 0x04000482 RID: 1154
		internal global::System.Windows.Documents.Hyperlink HLinkOBTChannelAssignment;

		// Token: 0x04000483 RID: 1155
		internal global::System.Windows.Documents.Hyperlink HLinkControlChannels;

		// Token: 0x04000484 RID: 1156
		internal global::System.Windows.Documents.Hyperlink HLinkASTRO25ChannelID;

		// Token: 0x04000485 RID: 1157
		internal global::System.Windows.Documents.Hyperlink HLinkFeatures;

		// Token: 0x04000486 RID: 1158
		internal global::System.Windows.Documents.Hyperlink HLinkMessageAlias;

		// Token: 0x04000487 RID: 1159
		internal global::System.Windows.Documents.Hyperlink HLinkTypeIIChannelSetup;

		// Token: 0x04000488 RID: 1160
		internal global::System.Windows.Documents.Hyperlink HLinkStatusAlias;

		// Token: 0x04000489 RID: 1161
		internal global::System.Windows.Documents.Hyperlink HLinkSiteAlias;

		// Token: 0x0400048A RID: 1162
		internal global::System.Windows.Documents.Hyperlink HLinkOneTouch;

		// Token: 0x0400048B RID: 1163
		internal global::System.Windows.Documents.Hyperlink HLinkASTRO26;

		// Token: 0x0400048C RID: 1164
		internal global::System.Windows.Documents.Hyperlink HLinkDigital;

		// Token: 0x0400048D RID: 1165
		internal global::System.Windows.Documents.Hyperlink HLinkSecureMultikey;

		// Token: 0x0400048E RID: 1166
		internal global::System.Windows.Documents.Hyperlink HLinkLabtool;

		// Token: 0x0400048F RID: 1167
		internal global::System.Windows.Documents.Hyperlink HLinkBroadband;

		// Token: 0x04000490 RID: 1168
		internal global::System.Windows.Controls.StackPanel MyStackPanel;

		// Token: 0x04000491 RID: 1169
		internal global::AcpUI.AcpExpander ExpanderTrunkingSystemGeneral;

		// Token: 0x04000492 RID: 1170
		internal global::AcpUI.AcpGroupBox GrpBoxExpanderTrunkingSystemGeneralPseudo0;

		// Token: 0x04000493 RID: 1171
		internal global::AcpUI.AcpCustomViewCheckBox CVBtnTrkSysGeneralKeyofTrunkingSystem_A12658;

		// Token: 0x04000494 RID: 1172
		internal global::AcpUI.AcpLabel LblTrkSysGeneralKeyofTrunkingSystem_A12658;

		// Token: 0x04000495 RID: 1173
		internal global::AcpUI.AcpTextBox TrkSysGeneralKeyofTrunkingSystem_A12658;

		// Token: 0x04000496 RID: 1174
		internal global::AcpUI.AcpCopyButton CpyBtnTrkSysGeneralKeyofTrunkingSystem_A12658;

		// Token: 0x04000497 RID: 1175
		internal global::AcpUI.AcpLabel TrkSysGeneralKeyofTrunkingSystem_A12658Comp;

		// Token: 0x04000498 RID: 1176
		internal global::AcpUI.AcpCustomViewCheckBox CVBtnTrkSysGeneralSystemKeyType_A38853;

		// Token: 0x04000499 RID: 1177
		internal global::AcpUI.AcpLabel LblTrkSysGeneralSystemKeyType_A38853;

		// Token: 0x0400049A RID: 1178
		internal global::AcpUI.AcpComboBox TrkSysGeneralSystemKeyType_A38853;

		// Token: 0x0400049B RID: 1179
		internal global::AcpUI.AcpRtdButton RTDBtnTrkSysGeneralSystemKeyType_A38853;

		// Token: 0x0400049C RID: 1180
		internal global::AcpUI.AcpCopyButton CpyBtnTrkSysGeneralSystemKeyType_A38853;

		// Token: 0x0400049D RID: 1181
		internal global::AcpUI.AcpLabel TrkSysGeneralSystemKeyType_A38853Comp;

		// Token: 0x0400049E RID: 1182
		internal global::AcpUI.AcpCustomViewCheckBox CVBtnTrkSysGeneralAskRequired_A44909;

		// Token: 0x0400049F RID: 1183
		internal global::AcpUI.AcpLabel LblTrkSysGeneralAskRequired_A44909;

		// Token: 0x040004A0 RID: 1184
		internal global::AcpUI.AcpCheckBox TrkSysGeneralAskRequired_A44909;

		// Token: 0x040004A1 RID: 1185
		internal global::AcpUI.AcpRtdButton RTDBtnTrkSysGeneralAskRequired_A44909;

		// Token: 0x040004A2 RID: 1186
		internal global::AcpUI.AcpCopyButton CpyBtnTrkSysGeneralAskRequired_A44909;

		// Token: 0x040004A3 RID: 1187
		internal global::AcpUI.AcpCheckBox TrkSysGeneralAskRequired_A44909Comp;

		// Token: 0x040004A4 RID: 1188
		internal global::AcpUI.AcpCustomViewCheckBox CVBtnTrkSysGeneralSystemKeyPresent_A9241;

		// Token: 0x040004A5 RID: 1189
		internal global::AcpUI.AcpLabel LblTrkSysGeneralSystemKeyPresent_A9241;

		// Token: 0x040004A6 RID: 1190
		internal global::AcpUI.AcpLabel TrkSysGeneralSystemKeyPresent_A9241;

		// Token: 0x040004A7 RID: 1191
		internal global::AcpUI.AcpRtdButton RTDBtnTrkSysGeneralSystemKeyPresent_A9241;

		// Token: 0x040004A8 RID: 1192
		internal global::AcpUI.AcpCopyButton CpyBtnTrkSysGeneralSystemKeyPresent_A9241;

		// Token: 0x040004A9 RID: 1193
		internal global::AcpUI.AcpLabel TrkSysGeneralSystemKeyPresent_A9241Comp;

		// Token: 0x040004AA RID: 1194
		internal global::AcpUI.AcpCustomViewCheckBox CVBtnTrkSysGeneralSystemType_A9252;

		// Token: 0x040004AB RID: 1195
		internal global::AcpUI.AcpLabel LblTrkSysGeneralSystemType_A9252;

		// Token: 0x040004AC RID: 1196
		internal global::AcpUI.AcpComboBox TrkSysGeneralSystemType_A9252;

		// Token: 0x040004AD RID: 1197
		internal global::AcpUI.AcpRtdButton RTDBtnTrkSysGeneralSystemType_A9252;

		// Token: 0x040004AE RID: 1198
		internal global::AcpUI.AcpCopyButton CpyBtnTrkSysGeneralSystemType_A9252;

		// Token: 0x040004AF RID: 1199
		internal global::AcpUI.AcpLabel TrkSysGeneralSystemType_A9252Comp;

		// Token: 0x040004B0 RID: 1200
		internal global::AcpUI.AcpCustomViewCheckBox CVBtnTrkSysGeneralCoverageType_A7782;

		// Token: 0x040004B1 RID: 1201
		internal global::AcpUI.AcpLabel LblTrkSysGeneralCoverageType_A7782;

		// Token: 0x040004B2 RID: 1202
		internal global::AcpUI.AcpComboBox TrkSysGeneralCoverageType_A7782;

		// Token: 0x040004B3 RID: 1203
		internal global::AcpUI.AcpRtdButton RTDBtnTrkSysGeneralCoverageType_A7782;

		// Token: 0x040004B4 RID: 1204
		internal global::AcpUI.AcpCopyButton CpyBtnTrkSysGeneralCoverageType_A7782;

		// Token: 0x040004B5 RID: 1205
		internal global::AcpUI.AcpLabel TrkSysGeneralCoverageType_A7782Comp;

		// Token: 0x040004B6 RID: 1206
		internal global::AcpUI.AcpCustomViewCheckBox CVBtnTrkSysGeneralHomeWACNID_A8205;

		// Token: 0x040004B7 RID: 1207
		internal global::AcpUI.AcpLabel LblTrkSysGeneralHomeWACNID_A8205;

		// Token: 0x040004B8 RID: 1208
		internal global::AcpUI.AcpTextBoxSpinnerDecHex TrkSysGeneralHomeWACNID_A8205;

		// Token: 0x040004B9 RID: 1209
		internal global::AcpUI.AcpRtdButton RTDBtnTrkSysGeneralHomeWACNID_A8205;

		// Token: 0x040004BA RID: 1210
		internal global::AcpUI.AcpCopyButton CpyBtnTrkSysGeneralHomeWACNID_A8205;

		// Token: 0x040004BB RID: 1211
		internal global::AcpUI.AcpTextBoxDecHex TrkSysGeneralHomeWACNID_A8205Comp;

		// Token: 0x040004BC RID: 1212
		internal global::AcpUI.AcpCustomViewCheckBox CVBtnTrkSysGeneralSystemID_A9239;

		// Token: 0x040004BD RID: 1213
		internal global::AcpUI.AcpLabel LblTrkSysGeneralSystemID_A9239;

		// Token: 0x040004BE RID: 1214
		internal global::AcpUI.AcpTextBoxSpinnerDecHex TrkSysGeneralSystemID_A9239;

		// Token: 0x040004BF RID: 1215
		internal global::AcpUI.AcpRtdButton RTDBtnTrkSysGeneralSystemID_A9239;

		// Token: 0x040004C0 RID: 1216
		internal global::AcpUI.AcpCopyButton CpyBtnTrkSysGeneralSystemID_A9239;

		// Token: 0x040004C1 RID: 1217
		internal global::AcpUI.AcpTextBoxDecHex TrkSysGeneralSystemID_A9239Comp;

		// Token: 0x040004C2 RID: 1218
		internal global::AcpUI.AcpCustomViewCheckBox CVBtnTrkSysGeneralRFSSID_A8980;

		// Token: 0x040004C3 RID: 1219
		internal global::AcpUI.AcpLabel LblTrkSysGeneralRFSSID_A8980;

		// Token: 0x040004C4 RID: 1220
		internal global::AcpUI.AcpTextBoxSpinnerDecHex TrkSysGeneralRFSSID_A8980;

		// Token: 0x040004C5 RID: 1221
		internal global::AcpUI.AcpRtdButton RTDBtnTrkSysGeneralRFSSID_A8980;

		// Token: 0x040004C6 RID: 1222
		internal global::AcpUI.AcpCopyButton CpyBtnTrkSysGeneralRFSSID_A8980;

		// Token: 0x040004C7 RID: 1223
		internal global::AcpUI.AcpTextBoxDecHex TrkSysGeneralRFSSID_A8980Comp;

		// Token: 0x040004C8 RID: 1224
		internal global::AcpUI.AcpCustomViewCheckBox CVBtnTrkSysGeneralSiteID_A9150;

		// Token: 0x040004C9 RID: 1225
		internal global::AcpUI.AcpLabel LblTrkSysGeneralSiteID_A9150;

		// Token: 0x040004CA RID: 1226
		internal global::AcpUI.AcpTextBoxSpinnerDecHex TrkSysGeneralSiteID_A9150;

		// Token: 0x040004CB RID: 1227
		internal global::AcpUI.AcpRtdButton RTDBtnTrkSysGeneralSiteID_A9150;

		// Token: 0x040004CC RID: 1228
		internal global::AcpUI.AcpCopyButton CpyBtnTrkSysGeneralSiteID_A9150;

		// Token: 0x040004CD RID: 1229
		internal global::AcpUI.AcpTextBoxDecHex TrkSysGeneralSiteID_A9150Comp;

		// Token: 0x040004CE RID: 1230
		internal global::AcpUI.AcpCustomViewCheckBox CVBtnTrkSysGeneralUnitID_A12651;

		// Token: 0x040004CF RID: 1231
		internal global::AcpUI.AcpLabel LblTrkSysGeneralUnitID_A12651;

		// Token: 0x040004D0 RID: 1232
		internal global::AcpUI.AcpTextBoxSpinnerDecHex TrkSysGeneralUnitID_A12651;

		// Token: 0x040004D1 RID: 1233
		internal global::AcpUI.AcpRtdButton RTDBtnTrkSysGeneralUnitID_A12651;

		// Token: 0x040004D2 RID: 1234
		internal global::AcpUI.AcpCopyButton CpyBtnTrkSysGeneralUnitID_A12651;

		// Token: 0x040004D3 RID: 1235
		internal global::AcpUI.AcpTextBoxDecHex TrkSysGeneralUnitID_A12651Comp;

		// Token: 0x040004D4 RID: 1236
		internal global::AcpUI.AcpCustomViewCheckBox CVBtnTrkSysGeneralTypeIIFrequencyBand_A12491;

		// Token: 0x040004D5 RID: 1237
		internal global::AcpUI.AcpLabel LblTrkSysGeneralTypeIIFrequencyBand_A12491;

		// Token: 0x040004D6 RID: 1238
		internal global::AcpUI.AcpComboBox TrkSysGeneralTypeIIFrequencyBand_A12491;

		// Token: 0x040004D7 RID: 1239
		internal global::AcpUI.AcpRtdButton RTDBtnTrkSysGeneralTypeIIFrequencyBand_A12491;

		// Token: 0x040004D8 RID: 1240
		internal global::AcpUI.AcpCopyButton CpyBtnTrkSysGeneralTypeIIFrequencyBand_A12491;

		// Token: 0x040004D9 RID: 1241
		internal global::AcpUI.AcpLabel TrkSysGeneralTypeIIFrequencyBand_A12491Comp;

		// Token: 0x040004DA RID: 1242
		internal global::AcpUI.AcpCustomViewCheckBox CVBtnTrkSysGeneralConnectToneHz_A7710;

		// Token: 0x040004DB RID: 1243
		internal global::AcpUI.AcpLabel LblTrkSysGeneralConnectToneHz_A7710;

		// Token: 0x040004DC RID: 1244
		internal global::AcpUI.AcpComboBox TrkSysGeneralConnectToneHz_A7710;

		// Token: 0x040004DD RID: 1245
		internal global::AcpUI.AcpRtdButton RTDBtnTrkSysGeneralConnectToneHz_A7710;

		// Token: 0x040004DE RID: 1246
		internal global::AcpUI.AcpCopyButton CpyBtnTrkSysGeneralConnectToneHz_A7710;

		// Token: 0x040004DF RID: 1247
		internal global::AcpUI.AcpLabel TrkSysGeneralConnectToneHz_A7710Comp;

		// Token: 0x040004E0 RID: 1248
		internal global::AcpUI.AcpCustomViewCheckBox CVBtnTrkSysGeneralFailsoftConnectToneHz_A8007;

		// Token: 0x040004E1 RID: 1249
		internal global::AcpUI.AcpLabel LblTrkSysGeneralFailsoftConnectToneHz_A8007;

		// Token: 0x040004E2 RID: 1250
		internal global::AcpUI.AcpComboBox TrkSysGeneralFailsoftConnectToneHz_A8007;

		// Token: 0x040004E3 RID: 1251
		internal global::AcpUI.AcpRtdButton RTDBtnTrkSysGeneralFailsoftConnectToneHz_A8007;

		// Token: 0x040004E4 RID: 1252
		internal global::AcpUI.AcpCopyButton CpyBtnTrkSysGeneralFailsoftConnectToneHz_A8007;

		// Token: 0x040004E5 RID: 1253
		internal global::AcpUI.AcpLabel TrkSysGeneralFailsoftConnectToneHz_A8007Comp;

		// Token: 0x040004E6 RID: 1254
		internal global::AcpUI.AcpCustomViewCheckBox CVBtnTrkSysLabtoolNetworkID_A8565;

		// Token: 0x040004E7 RID: 1255
		internal global::AcpUI.AcpLabel LblTrkSysLabtoolNetworkID_A8565;

		// Token: 0x040004E8 RID: 1256
		internal global::AcpUI.AcpTextBoxSpinnerDecHex TrkSysLabtoolNetworkID_A8565;

		// Token: 0x040004E9 RID: 1257
		internal global::AcpUI.AcpRtdButton RTDBtnTrkSysLabtoolNetworkID_A8565;

		// Token: 0x040004EA RID: 1258
		internal global::AcpUI.AcpCopyButton CpyBtnTrkSysLabtoolNetworkID_A8565;

		// Token: 0x040004EB RID: 1259
		internal global::AcpUI.AcpTextBoxDecHex TrkSysLabtoolNetworkID_A8565Comp;

		// Token: 0x040004EC RID: 1260
		internal global::AcpUI.AcpCustomViewCheckBox CVBtnTrkSysGeneralRFSSResponseTimems_A8981;

		// Token: 0x040004ED RID: 1261
		internal global::AcpUI.AcpLabel LblTrkSysGeneralRFSSResponseTimems_A8981;

		// Token: 0x040004EE RID: 1262
		internal global::AcpUI.AcpTextBoxSpinner TrkSysGeneralRFSSResponseTimems_A8981;

		// Token: 0x040004EF RID: 1263
		internal global::AcpUI.AcpRtdButton RTDBtnTrkSysGeneralRFSSResponseTimems_A8981;

		// Token: 0x040004F0 RID: 1264
		internal global::AcpUI.AcpCopyButton CpyBtnTrkSysGeneralRFSSResponseTimems_A8981;

		// Token: 0x040004F1 RID: 1265
		internal global::AcpUI.AcpLabel TrkSysGeneralRFSSResponseTimems_A8981Comp;

		// Token: 0x040004F2 RID: 1266
		internal global::AcpUI.AcpCustomViewCheckBox CVBtnTrkSysGeneralRFSSDebounceTimersec_A8979;

		// Token: 0x040004F3 RID: 1267
		internal global::AcpUI.AcpLabel LblTrkSysGeneralRFSSDebounceTimersec_A8979;

		// Token: 0x040004F4 RID: 1268
		internal global::AcpUI.AcpTextBoxSpinner TrkSysGeneralRFSSDebounceTimersec_A8979;

		// Token: 0x040004F5 RID: 1269
		internal global::AcpUI.AcpRtdButton RTDBtnTrkSysGeneralRFSSDebounceTimersec_A8979;

		// Token: 0x040004F6 RID: 1270
		internal global::AcpUI.AcpCopyButton CpyBtnTrkSysGeneralRFSSDebounceTimersec_A8979;

		// Token: 0x040004F7 RID: 1271
		internal global::AcpUI.AcpLabel TrkSysGeneralRFSSDebounceTimersec_A8979Comp;

		// Token: 0x040004F8 RID: 1272
		internal global::AcpUI.AcpCustomViewCheckBox CVBtnTrkSysGeneralNonAdjacentSiteSearch_A8568;

		// Token: 0x040004F9 RID: 1273
		internal global::AcpUI.AcpLabel LblTrkSysGeneralNonAdjacentSiteSearch_A8568;

		// Token: 0x040004FA RID: 1274
		internal global::AcpUI.AcpCheckBox TrkSysGeneralNonAdjacentSiteSearch_A8568;

		// Token: 0x040004FB RID: 1275
		internal global::AcpUI.AcpRtdButton RTDBtnTrkSysGeneralNonAdjacentSiteSearch_A8568;

		// Token: 0x040004FC RID: 1276
		internal global::AcpUI.AcpCopyButton CpyBtnTrkSysGeneralNonAdjacentSiteSearch_A8568;

		// Token: 0x040004FD RID: 1277
		internal global::AcpUI.AcpCheckBox TrkSysGeneralNonAdjacentSiteSearch_A8568Comp;

		// Token: 0x040004FE RID: 1278
		internal global::AcpUI.AcpCustomViewCheckBox CVBtnTrkSysGeneralDataProfileSelection_A19449;

		// Token: 0x040004FF RID: 1279
		internal global::AcpUI.AcpLabel LblTrkSysGeneralDataProfileSelection_A19449;

		// Token: 0x04000500 RID: 1280
		internal global::AcpUI.AcpComboBox TrkSysGeneralDataProfileSelection_A19449;

		// Token: 0x04000501 RID: 1281
		internal global::AcpUI.AcpRtdButton RTDBtnTrkSysGeneralDataProfileSelection_A19449;

		// Token: 0x04000502 RID: 1282
		internal global::AcpUI.AcpCopyButton CpyBtnTrkSysGeneralDataProfileSelection_A19449;

		// Token: 0x04000503 RID: 1283
		internal global::AcpUI.AcpLabel TrkSysGeneralDataProfileSelection_A19449Comp;

		// Token: 0x04000504 RID: 1284
		internal global::AcpUI.AcpExpander ExpanderTrunkingSystemOBTChannelAssignment;

		// Token: 0x04000505 RID: 1285
		internal global::AcpUI.AcpChildRecNavToolbar RecNavToolbarExpanderTrunkingSystemChannelRangesMHz;

		// Token: 0x04000506 RID: 1286
		internal global::System.Windows.Controls.Grid ExpanderTrunkingSystemOBTChannelAssignmentGrid;

		// Token: 0x04000507 RID: 1287
		internal global::System.Windows.Controls.Grid ExpanderTrunkingSystemChannelRangesMHzGrid;

		// Token: 0x04000508 RID: 1288
		internal global::AcpUI.AcpGroupBox ExpanderTrunkingSystemChannelRangesMHzTableView;

		// Token: 0x04000509 RID: 1289
		internal global::AcpUI.AcpXamDataPresenter ExpanderTrunkingSystemChannelRangesMHz;

		// Token: 0x0400050A RID: 1290
		internal global::Infragistics.Windows.DataPresenter.UnboundField TrkSysOBTChannelRange_A24072_Col;

		// Token: 0x0400050B RID: 1291
		internal global::Infragistics.Windows.DataPresenter.UnboundField TrkSysOBTChannelAssignmentListRxEnable_A9001_Col;

		// Token: 0x0400050C RID: 1292
		internal global::Infragistics.Windows.DataPresenter.UnboundField TrkSysOBTChannelAssignmentListRxSpacingKHz_A9004_Col;

		// Token: 0x0400050D RID: 1293
		internal global::Infragistics.Windows.DataPresenter.UnboundField TrkSysOBTChannelAssignmentListRxStartFrequencyMHz_A9029_Col;

		// Token: 0x0400050E RID: 1294
		internal global::Infragistics.Windows.DataPresenter.UnboundField TrkSysOBTChannelAssignmentListRxEndFrequencyMHz_A9012_Col;

		// Token: 0x0400050F RID: 1295
		internal global::Infragistics.Windows.DataPresenter.UnboundField TrkSysOBTChannelAssignmentListTxEnable_A9517_Col;

		// Token: 0x04000510 RID: 1296
		internal global::Infragistics.Windows.DataPresenter.UnboundField TrkSysOBTChannelAssignmentListTxSpacingKHz_A9520_Col;

		// Token: 0x04000511 RID: 1297
		internal global::Infragistics.Windows.DataPresenter.UnboundField TrkSysOBTChannelAssignmentListTxStartFrequencyMHz_A9568_Col;

		// Token: 0x04000512 RID: 1298
		internal global::Infragistics.Windows.DataPresenter.UnboundField TrkSysOBTChannelAssignmentListTxEndFrequencyMHz_A9529_Col;

		// Token: 0x04000513 RID: 1299
		internal global::Infragistics.Windows.DataPresenter.UnboundField TrkSysOBTChannelAssignmentListRxStartChannelNumber_A20478_Col;

		// Token: 0x04000514 RID: 1300
		internal global::Infragistics.Windows.DataPresenter.UnboundField TrkSysOBTChannelAssignmentListTxStartChannelNumber_A20479_Col;

		// Token: 0x04000515 RID: 1301
		internal global::AcpUI.AcpGroupBox ExpanderTrunkingSystemChannelRangesMHzSRecView;

		// Token: 0x04000516 RID: 1302
		internal global::System.Windows.Controls.Grid gridExpanderTrunkingSystemChannelRangesMHzSRecView;

		// Token: 0x04000517 RID: 1303
		internal global::AcpUI.AcpLabel TrkSysOBTChannelRange_A24072;

		// Token: 0x04000518 RID: 1304
		internal global::AcpUI.AcpCustomViewCheckBox CVBtnTrkSysOBTChannelRange_A24072;

		// Token: 0x04000519 RID: 1305
		internal global::AcpUI.AcpLabel LblTrkSysOBTChannelRange_A24072;

		// Token: 0x0400051A RID: 1306
		internal global::AcpUI.AcpCopyButton CpyBtnTrkSysOBTChannelRange_A24072;

		// Token: 0x0400051B RID: 1307
		internal global::AcpUI.AcpLabel TrkSysOBTChannelRange_A24072Comp;

		// Token: 0x0400051C RID: 1308
		internal global::AcpUI.AcpCheckBox TrkSysOBTChannelAssignmentListRxEnable_A9001;

		// Token: 0x0400051D RID: 1309
		internal global::AcpUI.AcpCustomViewCheckBox CVBtnTrkSysOBTChannelAssignmentListRxEnable_A9001;

		// Token: 0x0400051E RID: 1310
		internal global::AcpUI.AcpLabel LblTrkSysOBTChannelAssignmentListRxEnable_A9001;

		// Token: 0x0400051F RID: 1311
		internal global::AcpUI.AcpRtdButton RTDBtnTrkSysOBTChannelAssignmentListRxEnable_A9001;

		// Token: 0x04000520 RID: 1312
		internal global::AcpUI.AcpCopyButton CpyBtnTrkSysOBTChannelAssignmentListRxEnable_A9001;

		// Token: 0x04000521 RID: 1313
		internal global::AcpUI.AcpCheckBox TrkSysOBTChannelAssignmentListRxEnable_A9001Comp;

		// Token: 0x04000522 RID: 1314
		internal global::AcpUI.AcpComboBox TrkSysOBTChannelAssignmentListRxSpacingKHz_A9004;

		// Token: 0x04000523 RID: 1315
		internal global::AcpUI.AcpCustomViewCheckBox CVBtnTrkSysOBTChannelAssignmentListRxSpacingKHz_A9004;

		// Token: 0x04000524 RID: 1316
		internal global::AcpUI.AcpLabel LblTrkSysOBTChannelAssignmentListRxSpacingKHz_A9004;

		// Token: 0x04000525 RID: 1317
		internal global::AcpUI.AcpRtdButton RTDBtnTrkSysOBTChannelAssignmentListRxSpacingKHz_A9004;

		// Token: 0x04000526 RID: 1318
		internal global::AcpUI.AcpCopyButton CpyBtnTrkSysOBTChannelAssignmentListRxSpacingKHz_A9004;

		// Token: 0x04000527 RID: 1319
		internal global::AcpUI.AcpLabel TrkSysOBTChannelAssignmentListRxSpacingKHz_A9004Comp;

		// Token: 0x04000528 RID: 1320
		internal global::AcpUI.AcpTextBox TrkSysOBTChannelAssignmentListRxStartFrequencyMHz_A9029;

		// Token: 0x04000529 RID: 1321
		internal global::AcpUI.AcpCustomViewCheckBox CVBtnTrkSysOBTChannelAssignmentListRxStartFrequencyMHz_A9029;

		// Token: 0x0400052A RID: 1322
		internal global::AcpUI.AcpLabel LblTrkSysOBTChannelAssignmentListRxStartFrequencyMHz_A9029;

		// Token: 0x0400052B RID: 1323
		internal global::AcpUI.AcpRtdButton RTDBtnTrkSysOBTChannelAssignmentListRxStartFrequencyMHz_A9029;

		// Token: 0x0400052C RID: 1324
		internal global::AcpUI.AcpCopyButton CpyBtnTrkSysOBTChannelAssignmentListRxStartFrequencyMHz_A9029;

		// Token: 0x0400052D RID: 1325
		internal global::AcpUI.AcpLabel TrkSysOBTChannelAssignmentListRxStartFrequencyMHz_A9029Comp;

		// Token: 0x0400052E RID: 1326
		internal global::AcpUI.AcpTextBox TrkSysOBTChannelAssignmentListRxEndFrequencyMHz_A9012;

		// Token: 0x0400052F RID: 1327
		internal global::AcpUI.AcpCustomViewCheckBox CVBtnTrkSysOBTChannelAssignmentListRxEndFrequencyMHz_A9012;

		// Token: 0x04000530 RID: 1328
		internal global::AcpUI.AcpLabel LblTrkSysOBTChannelAssignmentListRxEndFrequencyMHz_A9012;

		// Token: 0x04000531 RID: 1329
		internal global::AcpUI.AcpRtdButton RTDBtnTrkSysOBTChannelAssignmentListRxEndFrequencyMHz_A9012;

		// Token: 0x04000532 RID: 1330
		internal global::AcpUI.AcpCopyButton CpyBtnTrkSysOBTChannelAssignmentListRxEndFrequencyMHz_A9012;

		// Token: 0x04000533 RID: 1331
		internal global::AcpUI.AcpLabel TrkSysOBTChannelAssignmentListRxEndFrequencyMHz_A9012Comp;

		// Token: 0x04000534 RID: 1332
		internal global::AcpUI.AcpCheckBox TrkSysOBTChannelAssignmentListTxEnable_A9517;

		// Token: 0x04000535 RID: 1333
		internal global::AcpUI.AcpCustomViewCheckBox CVBtnTrkSysOBTChannelAssignmentListTxEnable_A9517;

		// Token: 0x04000536 RID: 1334
		internal global::AcpUI.AcpLabel LblTrkSysOBTChannelAssignmentListTxEnable_A9517;

		// Token: 0x04000537 RID: 1335
		internal global::AcpUI.AcpRtdButton RTDBtnTrkSysOBTChannelAssignmentListTxEnable_A9517;

		// Token: 0x04000538 RID: 1336
		internal global::AcpUI.AcpCopyButton CpyBtnTrkSysOBTChannelAssignmentListTxEnable_A9517;

		// Token: 0x04000539 RID: 1337
		internal global::AcpUI.AcpCheckBox TrkSysOBTChannelAssignmentListTxEnable_A9517Comp;

		// Token: 0x0400053A RID: 1338
		internal global::AcpUI.AcpComboBox TrkSysOBTChannelAssignmentListTxSpacingKHz_A9520;

		// Token: 0x0400053B RID: 1339
		internal global::AcpUI.AcpCustomViewCheckBox CVBtnTrkSysOBTChannelAssignmentListTxSpacingKHz_A9520;

		// Token: 0x0400053C RID: 1340
		internal global::AcpUI.AcpLabel LblTrkSysOBTChannelAssignmentListTxSpacingKHz_A9520;

		// Token: 0x0400053D RID: 1341
		internal global::AcpUI.AcpRtdButton RTDBtnTrkSysOBTChannelAssignmentListTxSpacingKHz_A9520;

		// Token: 0x0400053E RID: 1342
		internal global::AcpUI.AcpCopyButton CpyBtnTrkSysOBTChannelAssignmentListTxSpacingKHz_A9520;

		// Token: 0x0400053F RID: 1343
		internal global::AcpUI.AcpLabel TrkSysOBTChannelAssignmentListTxSpacingKHz_A9520Comp;

		// Token: 0x04000540 RID: 1344
		internal global::AcpUI.AcpTextBox TrkSysOBTChannelAssignmentListTxStartFrequencyMHz_A9568;

		// Token: 0x04000541 RID: 1345
		internal global::AcpUI.AcpCustomViewCheckBox CVBtnTrkSysOBTChannelAssignmentListTxStartFrequencyMHz_A9568;

		// Token: 0x04000542 RID: 1346
		internal global::AcpUI.AcpLabel LblTrkSysOBTChannelAssignmentListTxStartFrequencyMHz_A9568;

		// Token: 0x04000543 RID: 1347
		internal global::AcpUI.AcpRtdButton RTDBtnTrkSysOBTChannelAssignmentListTxStartFrequencyMHz_A9568;

		// Token: 0x04000544 RID: 1348
		internal global::AcpUI.AcpCopyButton CpyBtnTrkSysOBTChannelAssignmentListTxStartFrequencyMHz_A9568;

		// Token: 0x04000545 RID: 1349
		internal global::AcpUI.AcpLabel TrkSysOBTChannelAssignmentListTxStartFrequencyMHz_A9568Comp;

		// Token: 0x04000546 RID: 1350
		internal global::AcpUI.AcpTextBox TrkSysOBTChannelAssignmentListTxEndFrequencyMHz_A9529;

		// Token: 0x04000547 RID: 1351
		internal global::AcpUI.AcpCustomViewCheckBox CVBtnTrkSysOBTChannelAssignmentListTxEndFrequencyMHz_A9529;

		// Token: 0x04000548 RID: 1352
		internal global::AcpUI.AcpLabel LblTrkSysOBTChannelAssignmentListTxEndFrequencyMHz_A9529;

		// Token: 0x04000549 RID: 1353
		internal global::AcpUI.AcpRtdButton RTDBtnTrkSysOBTChannelAssignmentListTxEndFrequencyMHz_A9529;

		// Token: 0x0400054A RID: 1354
		internal global::AcpUI.AcpCopyButton CpyBtnTrkSysOBTChannelAssignmentListTxEndFrequencyMHz_A9529;

		// Token: 0x0400054B RID: 1355
		internal global::AcpUI.AcpLabel TrkSysOBTChannelAssignmentListTxEndFrequencyMHz_A9529Comp;

		// Token: 0x0400054C RID: 1356
		internal global::AcpUI.AcpTextBoxSpinnerDecHex TrkSysOBTChannelAssignmentListRxStartChannelNumber_A20478;

		// Token: 0x0400054D RID: 1357
		internal global::AcpUI.AcpCustomViewCheckBox CVBtnTrkSysOBTChannelAssignmentListRxStartChannelNumber_A20478;

		// Token: 0x0400054E RID: 1358
		internal global::AcpUI.AcpLabel LblTrkSysOBTChannelAssignmentListRxStartChannelNumber_A20478;

		// Token: 0x0400054F RID: 1359
		internal global::AcpUI.AcpRtdButton RTDBtnTrkSysOBTChannelAssignmentListRxStartChannelNumber_A20478;

		// Token: 0x04000550 RID: 1360
		internal global::AcpUI.AcpCopyButton CpyBtnTrkSysOBTChannelAssignmentListRxStartChannelNumber_A20478;

		// Token: 0x04000551 RID: 1361
		internal global::AcpUI.AcpTextBoxDecHex TrkSysOBTChannelAssignmentListRxStartChannelNumber_A20478Comp;

		// Token: 0x04000552 RID: 1362
		internal global::AcpUI.AcpTextBoxSpinnerDecHex TrkSysOBTChannelAssignmentListTxStartChannelNumber_A20479;

		// Token: 0x04000553 RID: 1363
		internal global::AcpUI.AcpCustomViewCheckBox CVBtnTrkSysOBTChannelAssignmentListTxStartChannelNumber_A20479;

		// Token: 0x04000554 RID: 1364
		internal global::AcpUI.AcpLabel LblTrkSysOBTChannelAssignmentListTxStartChannelNumber_A20479;

		// Token: 0x04000555 RID: 1365
		internal global::AcpUI.AcpRtdButton RTDBtnTrkSysOBTChannelAssignmentListTxStartChannelNumber_A20479;

		// Token: 0x04000556 RID: 1366
		internal global::AcpUI.AcpCopyButton CpyBtnTrkSysOBTChannelAssignmentListTxStartChannelNumber_A20479;

		// Token: 0x04000557 RID: 1367
		internal global::AcpUI.AcpTextBoxDecHex TrkSysOBTChannelAssignmentListTxStartChannelNumber_A20479Comp;

		// Token: 0x04000558 RID: 1368
		internal global::AcpUI.AcpExpander ExpanderTrunkingSystemControlChannels;

		// Token: 0x04000559 RID: 1369
		internal global::AcpUI.AcpChildRecNavToolbar RecNavToolbarExpanderTrunkingSystemControlChannelsTable;

		// Token: 0x0400055A RID: 1370
		internal global::System.Windows.Controls.Grid ExpanderTrunkingSystemControlChannelsGrid;

		// Token: 0x0400055B RID: 1371
		internal global::System.Windows.Controls.Grid ExpanderTrunkingSystemControlChannelsTableGrid;

		// Token: 0x0400055C RID: 1372
		internal global::AcpUI.AcpGroupBox ExpanderTrunkingSystemControlChannelsTableTableView;

		// Token: 0x0400055D RID: 1373
		internal global::AcpUI.AcpXamDataPresenter ExpanderTrunkingSystemControlChannelsTable;

		// Token: 0x0400055E RID: 1374
		internal global::Infragistics.Windows.DataPresenter.UnboundField TrkSysControlChannelsRxFrequencyMHz_A9018_Col;

		// Token: 0x0400055F RID: 1375
		internal global::Infragistics.Windows.DataPresenter.UnboundField TrkSysControlChannelsTxFrequencyMHz_A9535_Col;

		// Token: 0x04000560 RID: 1376
		internal global::AcpUI.AcpGroupBox ExpanderTrunkingSystemControlChannelsTableSRecView;

		// Token: 0x04000561 RID: 1377
		internal global::System.Windows.Controls.Grid gridExpanderTrunkingSystemControlChannelsTableSRecView;

		// Token: 0x04000562 RID: 1378
		internal global::AcpUI.AcpTextBox TrkSysControlChannelsRxFrequencyMHz_A9018;

		// Token: 0x04000563 RID: 1379
		internal global::AcpUI.AcpCustomViewCheckBox CVBtnTrkSysControlChannelsRxFrequencyMHz_A9018;

		// Token: 0x04000564 RID: 1380
		internal global::AcpUI.AcpLabel LblTrkSysControlChannelsRxFrequencyMHz_A9018;

		// Token: 0x04000565 RID: 1381
		internal global::AcpUI.AcpRtdButton RTDBtnTrkSysControlChannelsRxFrequencyMHz_A9018;

		// Token: 0x04000566 RID: 1382
		internal global::AcpUI.AcpCopyButton CpyBtnTrkSysControlChannelsRxFrequencyMHz_A9018;

		// Token: 0x04000567 RID: 1383
		internal global::AcpUI.AcpLabel TrkSysControlChannelsRxFrequencyMHz_A9018Comp;

		// Token: 0x04000568 RID: 1384
		internal global::AcpUI.AcpTextBox TrkSysControlChannelsTxFrequencyMHz_A9535;

		// Token: 0x04000569 RID: 1385
		internal global::AcpUI.AcpCustomViewCheckBox CVBtnTrkSysControlChannelsTxFrequencyMHz_A9535;

		// Token: 0x0400056A RID: 1386
		internal global::AcpUI.AcpLabel LblTrkSysControlChannelsTxFrequencyMHz_A9535;

		// Token: 0x0400056B RID: 1387
		internal global::AcpUI.AcpRtdButton RTDBtnTrkSysControlChannelsTxFrequencyMHz_A9535;

		// Token: 0x0400056C RID: 1388
		internal global::AcpUI.AcpCopyButton CpyBtnTrkSysControlChannelsTxFrequencyMHz_A9535;

		// Token: 0x0400056D RID: 1389
		internal global::AcpUI.AcpLabel TrkSysControlChannelsTxFrequencyMHz_A9535Comp;

		// Token: 0x0400056E RID: 1390
		internal global::AcpUI.AcpExpander ExpanderTrunkingSystemASTRO25ChannelID;

		// Token: 0x0400056F RID: 1391
		internal global::AcpUI.AcpChildRecNavToolbar RecNavToolbarExpanderTrunkingSystemASTRO25ChannelIDTable;

		// Token: 0x04000570 RID: 1392
		internal global::AcpUI.AcpGroupBox GrpBoxExpanderTrunkingSystemASTRO25ChannelIDPseudo0;

		// Token: 0x04000571 RID: 1393
		internal global::AcpUI.AcpCustomViewCheckBox CVBtnTrkSysLTEInterferingFreqPresent_A42198;

		// Token: 0x04000572 RID: 1394
		internal global::AcpUI.AcpLabel LblTrkSysLTEInterferingFreqPresent_A42198;

		// Token: 0x04000573 RID: 1395
		internal global::AcpUI.AcpLabel TrkSysLTEInterferingFreqPresent_A42198;

		// Token: 0x04000574 RID: 1396
		internal global::AcpUI.AcpRtdButton RTDBtnTrkSysLTEInterferingFreqPresent_A42198;

		// Token: 0x04000575 RID: 1397
		internal global::AcpUI.AcpCopyButton CpyBtnTrkSysLTEInterferingFreqPresent_A42198;

		// Token: 0x04000576 RID: 1398
		internal global::AcpUI.AcpLabel TrkSysLTEInterferingFreqPresent_A42198Comp;

		// Token: 0x04000577 RID: 1399
		internal global::System.Windows.Controls.Grid ExpanderTrunkingSystemASTRO25ChannelIDGrid;

		// Token: 0x04000578 RID: 1400
		internal global::System.Windows.Controls.Grid ExpanderTrunkingSystemASTRO25ChannelIDTableGrid;

		// Token: 0x04000579 RID: 1401
		internal global::AcpUI.AcpGroupBox ExpanderTrunkingSystemASTRO25ChannelIDTableTableView;

		// Token: 0x0400057A RID: 1402
		internal global::AcpUI.AcpXamDataPresenter ExpanderTrunkingSystemASTRO25ChannelIDTable;

		// Token: 0x0400057B RID: 1403
		internal global::Infragistics.Windows.DataPresenter.UnboundField TrkSysAstro25ChannelID_A24066_Col;

		// Token: 0x0400057C RID: 1404
		internal global::Infragistics.Windows.DataPresenter.UnboundField TrkSysASTRO25ChannelIDIdentifierEnable_A8222_Col;

		// Token: 0x0400057D RID: 1405
		internal global::Infragistics.Windows.DataPresenter.UnboundField TrkSysASTRO25ChannelIDChannelType_A1390_Col;

		// Token: 0x0400057E RID: 1406
		internal global::Infragistics.Windows.DataPresenter.UnboundField TrkSysASTRO25ChannelIDTransmitOffsetSign_A9417_Col;

		// Token: 0x0400057F RID: 1407
		internal global::Infragistics.Windows.DataPresenter.UnboundField TrkSysASTRO25ChannelIDTransmitOffsetMHz_A9416_Col;

		// Token: 0x04000580 RID: 1408
		internal global::Infragistics.Windows.DataPresenter.UnboundField TrkSysASTRO25ChannelIDChannelSpacingkHz_A7660_Col;

		// Token: 0x04000581 RID: 1409
		internal global::Infragistics.Windows.DataPresenter.UnboundField TrkSysASTRO25ChannelIDBaseFrequencyMHz_A7546_Col;

		// Token: 0x04000582 RID: 1410
		internal global::AcpUI.AcpGroupBox ExpanderTrunkingSystemASTRO25ChannelIDTableSRecView;

		// Token: 0x04000583 RID: 1411
		internal global::System.Windows.Controls.Grid gridExpanderTrunkingSystemASTRO25ChannelIDTableSRecView;

		// Token: 0x04000584 RID: 1412
		internal global::AcpUI.AcpLabel TrkSysAstro25ChannelID_A24066;

		// Token: 0x04000585 RID: 1413
		internal global::AcpUI.AcpCustomViewCheckBox CVBtnTrkSysAstro25ChannelID_A24066;

		// Token: 0x04000586 RID: 1414
		internal global::AcpUI.AcpLabel LblTrkSysAstro25ChannelID_A24066;

		// Token: 0x04000587 RID: 1415
		internal global::AcpUI.AcpCopyButton CpyBtnTrkSysAstro25ChannelID_A24066;

		// Token: 0x04000588 RID: 1416
		internal global::AcpUI.AcpLabel TrkSysAstro25ChannelID_A24066Comp;

		// Token: 0x04000589 RID: 1417
		internal global::AcpUI.AcpCheckBox TrkSysASTRO25ChannelIDIdentifierEnable_A8222;

		// Token: 0x0400058A RID: 1418
		internal global::AcpUI.AcpCustomViewCheckBox CVBtnTrkSysASTRO25ChannelIDIdentifierEnable_A8222;

		// Token: 0x0400058B RID: 1419
		internal global::AcpUI.AcpLabel LblTrkSysASTRO25ChannelIDIdentifierEnable_A8222;

		// Token: 0x0400058C RID: 1420
		internal global::AcpUI.AcpRtdButton RTDBtnTrkSysASTRO25ChannelIDIdentifierEnable_A8222;

		// Token: 0x0400058D RID: 1421
		internal global::AcpUI.AcpCopyButton CpyBtnTrkSysASTRO25ChannelIDIdentifierEnable_A8222;

		// Token: 0x0400058E RID: 1422
		internal global::AcpUI.AcpCheckBox TrkSysASTRO25ChannelIDIdentifierEnable_A8222Comp;

		// Token: 0x0400058F RID: 1423
		internal global::AcpUI.AcpComboBox TrkSysASTRO25ChannelIDChannelType_A1390;

		// Token: 0x04000590 RID: 1424
		internal global::AcpUI.AcpCustomViewCheckBox CVBtnTrkSysASTRO25ChannelIDChannelType_A1390;

		// Token: 0x04000591 RID: 1425
		internal global::AcpUI.AcpLabel LblTrkSysASTRO25ChannelIDChannelType_A1390;

		// Token: 0x04000592 RID: 1426
		internal global::AcpUI.AcpRtdButton RTDBtnTrkSysASTRO25ChannelIDChannelType_A1390;

		// Token: 0x04000593 RID: 1427
		internal global::AcpUI.AcpCopyButton CpyBtnTrkSysASTRO25ChannelIDChannelType_A1390;

		// Token: 0x04000594 RID: 1428
		internal global::AcpUI.AcpLabel TrkSysASTRO25ChannelIDChannelType_A1390Comp;

		// Token: 0x04000595 RID: 1429
		internal global::AcpUI.AcpComboBox TrkSysASTRO25ChannelIDTransmitOffsetSign_A9417;

		// Token: 0x04000596 RID: 1430
		internal global::AcpUI.AcpCustomViewCheckBox CVBtnTrkSysASTRO25ChannelIDTransmitOffsetSign_A9417;

		// Token: 0x04000597 RID: 1431
		internal global::AcpUI.AcpLabel LblTrkSysASTRO25ChannelIDTransmitOffsetSign_A9417;

		// Token: 0x04000598 RID: 1432
		internal global::AcpUI.AcpRtdButton RTDBtnTrkSysASTRO25ChannelIDTransmitOffsetSign_A9417;

		// Token: 0x04000599 RID: 1433
		internal global::AcpUI.AcpCopyButton CpyBtnTrkSysASTRO25ChannelIDTransmitOffsetSign_A9417;

		// Token: 0x0400059A RID: 1434
		internal global::AcpUI.AcpLabel TrkSysASTRO25ChannelIDTransmitOffsetSign_A9417Comp;

		// Token: 0x0400059B RID: 1435
		internal global::AcpUI.AcpTextBox TrkSysASTRO25ChannelIDTransmitOffsetMHz_A9416;

		// Token: 0x0400059C RID: 1436
		internal global::AcpUI.AcpCustomViewCheckBox CVBtnTrkSysASTRO25ChannelIDTransmitOffsetMHz_A9416;

		// Token: 0x0400059D RID: 1437
		internal global::AcpUI.AcpLabel LblTrkSysASTRO25ChannelIDTransmitOffsetMHz_A9416;

		// Token: 0x0400059E RID: 1438
		internal global::AcpUI.AcpRtdButton RTDBtnTrkSysASTRO25ChannelIDTransmitOffsetMHz_A9416;

		// Token: 0x0400059F RID: 1439
		internal global::AcpUI.AcpCopyButton CpyBtnTrkSysASTRO25ChannelIDTransmitOffsetMHz_A9416;

		// Token: 0x040005A0 RID: 1440
		internal global::AcpUI.AcpLabel TrkSysASTRO25ChannelIDTransmitOffsetMHz_A9416Comp;

		// Token: 0x040005A1 RID: 1441
		internal global::AcpUI.AcpTextBox TrkSysASTRO25ChannelIDChannelSpacingkHz_A7660;

		// Token: 0x040005A2 RID: 1442
		internal global::AcpUI.AcpCustomViewCheckBox CVBtnTrkSysASTRO25ChannelIDChannelSpacingkHz_A7660;

		// Token: 0x040005A3 RID: 1443
		internal global::AcpUI.AcpLabel LblTrkSysASTRO25ChannelIDChannelSpacingkHz_A7660;

		// Token: 0x040005A4 RID: 1444
		internal global::AcpUI.AcpRtdButton RTDBtnTrkSysASTRO25ChannelIDChannelSpacingkHz_A7660;

		// Token: 0x040005A5 RID: 1445
		internal global::AcpUI.AcpCopyButton CpyBtnTrkSysASTRO25ChannelIDChannelSpacingkHz_A7660;

		// Token: 0x040005A6 RID: 1446
		internal global::AcpUI.AcpLabel TrkSysASTRO25ChannelIDChannelSpacingkHz_A7660Comp;

		// Token: 0x040005A7 RID: 1447
		internal global::AcpUI.AcpTextBox TrkSysASTRO25ChannelIDBaseFrequencyMHz_A7546;

		// Token: 0x040005A8 RID: 1448
		internal global::AcpUI.AcpCustomViewCheckBox CVBtnTrkSysASTRO25ChannelIDBaseFrequencyMHz_A7546;

		// Token: 0x040005A9 RID: 1449
		internal global::AcpUI.AcpLabel LblTrkSysASTRO25ChannelIDBaseFrequencyMHz_A7546;

		// Token: 0x040005AA RID: 1450
		internal global::AcpUI.AcpRtdButton RTDBtnTrkSysASTRO25ChannelIDBaseFrequencyMHz_A7546;

		// Token: 0x040005AB RID: 1451
		internal global::AcpUI.AcpCopyButton CpyBtnTrkSysASTRO25ChannelIDBaseFrequencyMHz_A7546;

		// Token: 0x040005AC RID: 1452
		internal global::AcpUI.AcpLabel TrkSysASTRO25ChannelIDBaseFrequencyMHz_A7546Comp;

		// Token: 0x040005AD RID: 1453
		internal global::AcpUI.AcpExpander ExpanderTrunkingSystemFeatures;

		// Token: 0x040005AE RID: 1454
		internal global::AcpUI.AcpGroupBox GrpBoxExpanderTrunkingSystemFeaturesPseudo0;

		// Token: 0x040005AF RID: 1455
		internal global::AcpUI.AcpCustomViewCheckBox CVBtnTrkSysFeaturesDTMFTimingTable_A7900;

		// Token: 0x040005B0 RID: 1456
		internal global::AcpUI.AcpLabel LblTrkSysFeaturesDTMFTimingTable_A7900;

		// Token: 0x040005B1 RID: 1457
		internal global::AcpUI.AcpComboBox TrkSysFeaturesDTMFTimingTable_A7900;

		// Token: 0x040005B2 RID: 1458
		internal global::AcpUI.AcpRtdButton RTDBtnTrkSysFeaturesDTMFTimingTable_A7900;

		// Token: 0x040005B3 RID: 1459
		internal global::AcpUI.AcpCopyButton CpyBtnTrkSysFeaturesDTMFTimingTable_A7900;

		// Token: 0x040005B4 RID: 1460
		internal global::AcpUI.AcpLabel TrkSysFeaturesDTMFTimingTable_A7900Comp;

		// Token: 0x040005B5 RID: 1461
		internal global::AcpUI.AcpCustomViewCheckBox CVBtnTrkSysFeaturesRadioInhibit_A8833;

		// Token: 0x040005B6 RID: 1462
		internal global::AcpUI.AcpLabel LblTrkSysFeaturesRadioInhibit_A8833;

		// Token: 0x040005B7 RID: 1463
		internal global::AcpUI.AcpCheckBox TrkSysFeaturesRadioInhibit_A8833;

		// Token: 0x040005B8 RID: 1464
		internal global::AcpUI.AcpRtdButton RTDBtnTrkSysFeaturesRadioInhibit_A8833;

		// Token: 0x040005B9 RID: 1465
		internal global::AcpUI.AcpCopyButton CpyBtnTrkSysFeaturesRadioInhibit_A8833;

		// Token: 0x040005BA RID: 1466
		internal global::AcpUI.AcpCheckBox TrkSysFeaturesRadioInhibit_A8833Comp;

		// Token: 0x040005BB RID: 1467
		internal global::AcpUI.AcpCustomViewCheckBox CVBtnTrkSysLabtoolEnable_A8669;

		// Token: 0x040005BC RID: 1468
		internal global::AcpUI.AcpLabel LblTrkSysLabtoolEnable_A8669;

		// Token: 0x040005BD RID: 1469
		internal global::AcpUI.AcpCheckBox TrkSysLabtoolEnable_A8669;

		// Token: 0x040005BE RID: 1470
		internal global::AcpUI.AcpRtdButton RTDBtnTrkSysLabtoolEnable_A8669;

		// Token: 0x040005BF RID: 1471
		internal global::AcpUI.AcpCopyButton CpyBtnTrkSysLabtoolEnable_A8669;

		// Token: 0x040005C0 RID: 1472
		internal global::AcpUI.AcpCheckBox TrkSysLabtoolEnable_A8669Comp;

		// Token: 0x040005C1 RID: 1473
		internal global::AcpUI.AcpCustomViewCheckBox CVBtnTrkSysFeaturesTextMessagingService_A9373;

		// Token: 0x040005C2 RID: 1474
		internal global::AcpUI.AcpLabel LblTrkSysFeaturesTextMessagingService_A9373;

		// Token: 0x040005C3 RID: 1475
		internal global::AcpUI.AcpComboBox TrkSysFeaturesTextMessagingService_A9373;

		// Token: 0x040005C4 RID: 1476
		internal global::AcpUI.AcpRtdButton RTDBtnTrkSysFeaturesTextMessagingService_A9373;

		// Token: 0x040005C5 RID: 1477
		internal global::AcpUI.AcpCopyButton CpyBtnTrkSysFeaturesTextMessagingService_A9373;

		// Token: 0x040005C6 RID: 1478
		internal global::AcpUI.AcpLabel TrkSysFeaturesTextMessagingService_A9373Comp;

		// Token: 0x040005C7 RID: 1479
		internal global::AcpUI.AcpCustomViewCheckBox CVBtnTrkSysFeaturesGroupTMSEable_42804;

		// Token: 0x040005C8 RID: 1480
		internal global::AcpUI.AcpLabel LblTrkSysFeaturesGroupTMSEable_42804;

		// Token: 0x040005C9 RID: 1481
		internal global::AcpUI.AcpComboBox TrkSysFeaturesGroupTMSEable_42804;

		// Token: 0x040005CA RID: 1482
		internal global::AcpUI.AcpRtdButton RTDBtnTrkSysFeaturesGroupTMSEable_42804;

		// Token: 0x040005CB RID: 1483
		internal global::AcpUI.AcpCopyButton CpyBtnTrkSysFeaturesGroupTMSEable_42804;

		// Token: 0x040005CC RID: 1484
		internal global::AcpUI.AcpLabel TrkSysFeaturesGroupTMSEable_42804Comp;

		// Token: 0x040005CD RID: 1485
		internal global::AcpUI.AcpCustomViewCheckBox CVBtnTrkPerFeaturesOTARadioAliasType_42854;

		// Token: 0x040005CE RID: 1486
		internal global::AcpUI.AcpLabel LblTrkPerFeaturesOTARadioAliasType_42854;

		// Token: 0x040005CF RID: 1487
		internal global::AcpUI.AcpComboBox TrkPerFeaturesOTARadioAliasType_42854;

		// Token: 0x040005D0 RID: 1488
		internal global::AcpUI.AcpRtdButton RTDBtnTrkPerFeaturesOTARadioAliasType_42854;

		// Token: 0x040005D1 RID: 1489
		internal global::AcpUI.AcpCopyButton CpyBtnTrkPerFeaturesOTARadioAliasType_42854;

		// Token: 0x040005D2 RID: 1490
		internal global::AcpUI.AcpLabel TrkPerFeaturesOTARadioAliasType_42854Comp;

		// Token: 0x040005D3 RID: 1491
		internal global::AcpUI.AcpCustomViewCheckBox CVBtnTrkSysFeaturesOTARadioAliasUpdateEnable_A43057;

		// Token: 0x040005D4 RID: 1492
		internal global::AcpUI.AcpLabel LblTrkSysFeaturesOTARadioAliasUpdateEnable_A43057;

		// Token: 0x040005D5 RID: 1493
		internal global::AcpUI.AcpCheckBox TrkSysFeaturesOTARadioAliasUpdateEnable_A43057;

		// Token: 0x040005D6 RID: 1494
		internal global::AcpUI.AcpRtdButton RTDBtnTrkSysFeaturesOTARadioAliasUpdateEnable_A43057;

		// Token: 0x040005D7 RID: 1495
		internal global::AcpUI.AcpCopyButton CpyBtnTrkSysFeaturesOTARadioAliasUpdateEnable_A43057;

		// Token: 0x040005D8 RID: 1496
		internal global::AcpUI.AcpCheckBox TrkSysFeaturesOTARadioAliasUpdateEnable_A43057Comp;

		// Token: 0x040005D9 RID: 1497
		internal global::AcpUI.AcpCustomViewCheckBox CVBtnTrkSysFeaturesTxPowerLevel_A9557;

		// Token: 0x040005DA RID: 1498
		internal global::AcpUI.AcpLabel LblTrkSysFeaturesTxPowerLevel_A9557;

		// Token: 0x040005DB RID: 1499
		internal global::AcpUI.AcpComboBox TrkSysFeaturesTxPowerLevel_A9557;

		// Token: 0x040005DC RID: 1500
		internal global::AcpUI.AcpRtdButton RTDBtnTrkSysFeaturesTxPowerLevel_A9557;

		// Token: 0x040005DD RID: 1501
		internal global::AcpUI.AcpCopyButton CpyBtnTrkSysFeaturesTxPowerLevel_A9557;

		// Token: 0x040005DE RID: 1502
		internal global::AcpUI.AcpLabel TrkSysFeaturesTxPowerLevel_A9557Comp;

		// Token: 0x040005DF RID: 1503
		internal global::AcpUI.AcpCustomViewCheckBox CVBtnTrkSysFeaturesHearClear_A36422;

		// Token: 0x040005E0 RID: 1504
		internal global::AcpUI.AcpLabel LblTrkSysFeaturesHearClear_A36422;

		// Token: 0x040005E1 RID: 1505
		internal global::AcpUI.AcpComboBox TrkSysFeaturesHearClear_A36422;

		// Token: 0x040005E2 RID: 1506
		internal global::AcpUI.AcpRtdButton RTDBtnTrkSysFeaturesHearClear_A36422;

		// Token: 0x040005E3 RID: 1507
		internal global::AcpUI.AcpCopyButton CpyBtnTrkSysFeaturesHearClear_A36422;

		// Token: 0x040005E4 RID: 1508
		internal global::AcpUI.AcpLabel TrkSysFeaturesHearClear_A36422Comp;

		// Token: 0x040005E5 RID: 1509
		internal global::AcpUI.AcpGroupBox GrpBoxExpanderTrunkingSystemFeaturesRemoteMonitorRadioTrace;

		// Token: 0x040005E6 RID: 1510
		internal global::AcpUI.AcpCustomViewCheckBox CVBtnTrkSysFeaturesEnable_A7968;

		// Token: 0x040005E7 RID: 1511
		internal global::AcpUI.AcpLabel LblTrkSysFeaturesEnable_A7968;

		// Token: 0x040005E8 RID: 1512
		internal global::AcpUI.AcpCheckBox TrkSysFeaturesEnable_A7968;

		// Token: 0x040005E9 RID: 1513
		internal global::AcpUI.AcpRtdButton RTDBtnTrkSysFeaturesEnable_A7968;

		// Token: 0x040005EA RID: 1514
		internal global::AcpUI.AcpCopyButton CpyBtnTrkSysFeaturesEnable_A7968;

		// Token: 0x040005EB RID: 1515
		internal global::AcpUI.AcpCheckBox TrkSysFeaturesEnable_A7968Comp;

		// Token: 0x040005EC RID: 1516
		internal global::AcpUI.AcpCustomViewCheckBox CVBtnTrkSysFeaturesTxBaseTimeSec_A9512;

		// Token: 0x040005ED RID: 1517
		internal global::AcpUI.AcpLabel LblTrkSysFeaturesTxBaseTimeSec_A9512;

		// Token: 0x040005EE RID: 1518
		internal global::AcpUI.AcpComboBox TrkSysFeaturesTxBaseTimeSec_A9512;

		// Token: 0x040005EF RID: 1519
		internal global::AcpUI.AcpRtdButton RTDBtnTrkSysFeaturesTxBaseTimeSec_A9512;

		// Token: 0x040005F0 RID: 1520
		internal global::AcpUI.AcpCopyButton CpyBtnTrkSysFeaturesTxBaseTimeSec_A9512;

		// Token: 0x040005F1 RID: 1521
		internal global::AcpUI.AcpLabel TrkSysFeaturesTxBaseTimeSec_A9512Comp;

		// Token: 0x040005F2 RID: 1522
		internal global::AcpUI.AcpGroupBox GrpBoxExpanderTrunkingSystemFeaturesRadioErgo;

		// Token: 0x040005F3 RID: 1523
		internal global::AcpUI.AcpCustomViewCheckBox CVBtnTrkSysFeaturesEmergencyAlarmRxIndicator_A7932;

		// Token: 0x040005F4 RID: 1524
		internal global::AcpUI.AcpLabel LblTrkSysFeaturesEmergencyAlarmRxIndicator_A7932;

		// Token: 0x040005F5 RID: 1525
		internal global::AcpUI.AcpCheckBox TrkSysFeaturesEmergencyAlarmRxIndicator_A7932;

		// Token: 0x040005F6 RID: 1526
		internal global::AcpUI.AcpRtdButton RTDBtnTrkSysFeaturesEmergencyAlarmRxIndicator_A7932;

		// Token: 0x040005F7 RID: 1527
		internal global::AcpUI.AcpCopyButton CpyBtnTrkSysFeaturesEmergencyAlarmRxIndicator_A7932;

		// Token: 0x040005F8 RID: 1528
		internal global::AcpUI.AcpCheckBox TrkSysFeaturesEmergencyAlarmRxIndicator_A7932Comp;

		// Token: 0x040005F9 RID: 1529
		internal global::AcpUI.AcpCustomViewCheckBox CVBtnTrkSysFeaturesSecureLED_A9071;

		// Token: 0x040005FA RID: 1530
		internal global::AcpUI.AcpLabel LblTrkSysFeaturesSecureLED_A9071;

		// Token: 0x040005FB RID: 1531
		internal global::AcpUI.AcpCheckBox TrkSysFeaturesSecureLED_A9071;

		// Token: 0x040005FC RID: 1532
		internal global::AcpUI.AcpRtdButton RTDBtnTrkSysFeaturesSecureLED_A9071;

		// Token: 0x040005FD RID: 1533
		internal global::AcpUI.AcpCopyButton CpyBtnTrkSysFeaturesSecureLED_A9071;

		// Token: 0x040005FE RID: 1534
		internal global::AcpUI.AcpCheckBox TrkSysFeaturesSecureLED_A9071Comp;

		// Token: 0x040005FF RID: 1535
		internal global::AcpUI.AcpCustomViewCheckBox CVBtnTrkSysFeaturesBusyLED_44911;

		// Token: 0x04000600 RID: 1536
		internal global::AcpUI.AcpLabel LblTrkSysFeaturesBusyLED_44911;

		// Token: 0x04000601 RID: 1537
		internal global::AcpUI.AcpCheckBox TrkSysFeaturesBusyLED_44911;

		// Token: 0x04000602 RID: 1538
		internal global::AcpUI.AcpRtdButton RTDBtnTrkSysFeaturesBusyLED_44911;

		// Token: 0x04000603 RID: 1539
		internal global::AcpUI.AcpCopyButton CpyBtnTrkSysFeaturesBusyLED_44911;

		// Token: 0x04000604 RID: 1540
		internal global::AcpUI.AcpCheckBox TrkSysFeaturesBusyLED_44911Comp;

		// Token: 0x04000605 RID: 1541
		internal global::AcpUI.AcpGroupBox GrpBoxExpanderTrunkingSystemFeaturesInCallUserAlert;

		// Token: 0x04000606 RID: 1542
		internal global::AcpUI.AcpCustomViewCheckBox CVBtnTrkSysFeaturesICUAReset_A8249;

		// Token: 0x04000607 RID: 1543
		internal global::AcpUI.AcpLabel LblTrkSysFeaturesICUAReset_A8249;

		// Token: 0x04000608 RID: 1544
		internal global::AcpUI.AcpComboBox TrkSysFeaturesICUAReset_A8249;

		// Token: 0x04000609 RID: 1545
		internal global::AcpUI.AcpRtdButton RTDBtnTrkSysFeaturesICUAReset_A8249;

		// Token: 0x0400060A RID: 1546
		internal global::AcpUI.AcpCopyButton CpyBtnTrkSysFeaturesICUAReset_A8249;

		// Token: 0x0400060B RID: 1547
		internal global::AcpUI.AcpLabel TrkSysFeaturesICUAReset_A8249Comp;

		// Token: 0x0400060C RID: 1548
		internal global::AcpUI.AcpCustomViewCheckBox CVBtnTrkSysFeaturesICUAAutoResetTimesec_A7515;

		// Token: 0x0400060D RID: 1549
		internal global::AcpUI.AcpLabel LblTrkSysFeaturesICUAAutoResetTimesec_A7515;

		// Token: 0x0400060E RID: 1550
		internal global::AcpUI.AcpTextBoxSpinner TrkSysFeaturesICUAAutoResetTimesec_A7515;

		// Token: 0x0400060F RID: 1551
		internal global::AcpUI.AcpRtdButton RTDBtnTrkSysFeaturesICUAAutoResetTimesec_A7515;

		// Token: 0x04000610 RID: 1552
		internal global::AcpUI.AcpCopyButton CpyBtnTrkSysFeaturesICUAAutoResetTimesec_A7515;

		// Token: 0x04000611 RID: 1553
		internal global::AcpUI.AcpLabel TrkSysFeaturesICUAAutoResetTimesec_A7515Comp;

		// Token: 0x04000612 RID: 1554
		internal global::AcpUI.AcpGroupBox GrpBoxExpanderTrunkingSystemFeaturesSiteSelectableAlert;

		// Token: 0x04000613 RID: 1555
		internal global::AcpUI.AcpCustomViewCheckBox CVBtnSiteSelectableAlertList_A42060;

		// Token: 0x04000614 RID: 1556
		internal global::AcpUI.AcpLabel LblSiteSelectableAlertList_A42060;

		// Token: 0x04000615 RID: 1557
		internal global::AcpUI.AcpComboBox SiteSelectableAlertList_A42060;

		// Token: 0x04000616 RID: 1558
		internal global::AcpUI.AcpRtdButton RTDBtnSiteSelectableAlertList_A42060;

		// Token: 0x04000617 RID: 1559
		internal global::AcpUI.AcpCopyButton CpyBtnSiteSelectableAlertList_A42060;

		// Token: 0x04000618 RID: 1560
		internal global::AcpUI.AcpLabel SiteSelectableAlertList_A42060Comp;

		// Token: 0x04000619 RID: 1561
		internal global::AcpUI.AcpCustomViewCheckBox CVBtnSiteSelectableAlertAliasList_A42100;

		// Token: 0x0400061A RID: 1562
		internal global::AcpUI.AcpLabel LblSiteSelectableAlertAliasList_A42100;

		// Token: 0x0400061B RID: 1563
		internal global::AcpUI.AcpComboBox SiteSelectableAlertAliasList_A42100;

		// Token: 0x0400061C RID: 1564
		internal global::AcpUI.AcpRtdButton RTDBtnSiteSelectableAlertAliasList_A42100;

		// Token: 0x0400061D RID: 1565
		internal global::AcpUI.AcpCopyButton CpyBtnSiteSelectableAlertAliasList_A42100;

		// Token: 0x0400061E RID: 1566
		internal global::AcpUI.AcpLabel SiteSelectableAlertAliasList_A42100Comp;

		// Token: 0x0400061F RID: 1567
		internal global::AcpUI.AcpGroupBox GrpBoxExpanderTrunkingSystemFeaturesDynamicRegrouping;

		// Token: 0x04000620 RID: 1568
		internal global::AcpUI.AcpCustomViewCheckBox CVBtnTrkSysFeaturesDynamicRegroupingEnable_A7969;

		// Token: 0x04000621 RID: 1569
		internal global::AcpUI.AcpLabel LblTrkSysFeaturesDynamicRegroupingEnable_A7969;

		// Token: 0x04000622 RID: 1570
		internal global::AcpUI.AcpCheckBox TrkSysFeaturesDynamicRegroupingEnable_A7969;

		// Token: 0x04000623 RID: 1571
		internal global::AcpUI.AcpRtdButton RTDBtnTrkSysFeaturesDynamicRegroupingEnable_A7969;

		// Token: 0x04000624 RID: 1572
		internal global::AcpUI.AcpCopyButton CpyBtnTrkSysFeaturesDynamicRegroupingEnable_A7969;

		// Token: 0x04000625 RID: 1573
		internal global::AcpUI.AcpCheckBox TrkSysFeaturesDynamicRegroupingEnable_A7969Comp;

		// Token: 0x04000626 RID: 1574
		internal global::AcpUI.AcpCustomViewCheckBox CVBtnTrkSysFeaturesZone_A9717;

		// Token: 0x04000627 RID: 1575
		internal global::AcpUI.AcpLabel LblTrkSysFeaturesZone_A9717;

		// Token: 0x04000628 RID: 1576
		internal global::AcpUI.AcpComboBox TrkSysFeaturesZone_A9717;

		// Token: 0x04000629 RID: 1577
		internal global::AcpUI.AcpRtdButton RTDBtnTrkSysFeaturesZone_A9717;

		// Token: 0x0400062A RID: 1578
		internal global::AcpUI.AcpCopyButton CpyBtnTrkSysFeaturesZone_A9717;

		// Token: 0x0400062B RID: 1579
		internal global::AcpUI.AcpLabel TrkSysFeaturesZone_A9717Comp;

		// Token: 0x0400062C RID: 1580
		internal global::AcpUI.AcpCustomViewCheckBox CVBtnTrkSysFeaturesChannel_A7647;

		// Token: 0x0400062D RID: 1581
		internal global::AcpUI.AcpLabel LblTrkSysFeaturesChannel_A7647;

		// Token: 0x0400062E RID: 1582
		internal global::AcpUI.AcpComboBox TrkSysFeaturesChannel_A7647;

		// Token: 0x0400062F RID: 1583
		internal global::AcpUI.AcpRtdButton RTDBtnTrkSysFeaturesChannel_A7647;

		// Token: 0x04000630 RID: 1584
		internal global::AcpUI.AcpCopyButton CpyBtnTrkSysFeaturesChannel_A7647;

		// Token: 0x04000631 RID: 1585
		internal global::AcpUI.AcpLabel TrkSysFeaturesChannel_A7647Comp;

		// Token: 0x04000632 RID: 1586
		internal global::AcpUI.AcpGroupBox GrpBoxExpanderTrunkingSystemFeaturesPseudo5;

		// Token: 0x04000633 RID: 1587
		internal global::AcpUI.AcpCustomViewCheckBox CVBtnTrkSysFeaturesPASelection_A42882;

		// Token: 0x04000634 RID: 1588
		internal global::AcpUI.AcpLabel LblTrkSysFeaturesPASelection_A42882;

		// Token: 0x04000635 RID: 1589
		internal global::AcpUI.AcpComboBox TrkSysFeaturesPASelection_A42882;

		// Token: 0x04000636 RID: 1590
		internal global::AcpUI.AcpRtdButton RTDBtnTrkSysFeaturesPASelection_A42882;

		// Token: 0x04000637 RID: 1591
		internal global::AcpUI.AcpCopyButton CpyBtnTrkSysFeaturesPASelection_A42882;

		// Token: 0x04000638 RID: 1592
		internal global::AcpUI.AcpLabel TrkSysFeaturesPASelection_A42882Comp;

		// Token: 0x04000639 RID: 1593
		internal global::AcpUI.AcpCustomViewCheckBox CVBtnTrkSysFeatureLocationOnPTT_43026;

		// Token: 0x0400063A RID: 1594
		internal global::AcpUI.AcpLabel LblTrkSysFeatureLocationOnPTT_43026;

		// Token: 0x0400063B RID: 1595
		internal global::AcpUI.AcpCheckBox TrkSysFeatureLocationOnPTT_43026;

		// Token: 0x0400063C RID: 1596
		internal global::AcpUI.AcpRtdButton RTDBtnTrkSysFeatureLocationOnPTT_43026;

		// Token: 0x0400063D RID: 1597
		internal global::AcpUI.AcpCopyButton CpyBtnTrkSysFeatureLocationOnPTT_43026;

		// Token: 0x0400063E RID: 1598
		internal global::AcpUI.AcpCheckBox TrkSysFeatureLocationOnPTT_43026Comp;

		// Token: 0x0400063F RID: 1599
		internal global::AcpUI.AcpExpander ExpanderTrunkingSystemMessageAlias;

		// Token: 0x04000640 RID: 1600
		internal global::AcpUI.AcpChildRecNavToolbar RecNavToolbarExpanderTrunkingSystemMessageAliasTable;

		// Token: 0x04000641 RID: 1601
		internal global::AcpUI.AcpGroupBox GrpBoxExpanderTrunkingSystemMessageAliasPseudo0;

		// Token: 0x04000642 RID: 1602
		internal global::AcpUI.AcpCustomViewCheckBox CVBtnTrkSysMessageAliasMessageAliasEnable_A8505;

		// Token: 0x04000643 RID: 1603
		internal global::AcpUI.AcpLabel LblTrkSysMessageAliasMessageAliasEnable_A8505;

		// Token: 0x04000644 RID: 1604
		internal global::AcpUI.AcpCheckBox TrkSysMessageAliasMessageAliasEnable_A8505;

		// Token: 0x04000645 RID: 1605
		internal global::AcpUI.AcpRtdButton RTDBtnTrkSysMessageAliasMessageAliasEnable_A8505;

		// Token: 0x04000646 RID: 1606
		internal global::AcpUI.AcpCopyButton CpyBtnTrkSysMessageAliasMessageAliasEnable_A8505;

		// Token: 0x04000647 RID: 1607
		internal global::AcpUI.AcpCheckBox TrkSysMessageAliasMessageAliasEnable_A8505Comp;

		// Token: 0x04000648 RID: 1608
		internal global::System.Windows.Controls.Grid ExpanderTrunkingSystemMessageAliasGrid;

		// Token: 0x04000649 RID: 1609
		internal global::System.Windows.Controls.Grid ExpanderTrunkingSystemMessageAliasTableGrid;

		// Token: 0x0400064A RID: 1610
		internal global::AcpUI.AcpGroupBox ExpanderTrunkingSystemMessageAliasTableTableView;

		// Token: 0x0400064B RID: 1611
		internal global::AcpUI.AcpXamDataPresenter ExpanderTrunkingSystemMessageAliasTable;

		// Token: 0x0400064C RID: 1612
		internal global::Infragistics.Windows.DataPresenter.UnboundField Position_37453;

		// Token: 0x0400064D RID: 1613
		internal global::Infragistics.Windows.DataPresenter.UnboundField TrkSysMsgAlias_A24069_Col;

		// Token: 0x0400064E RID: 1614
		internal global::Infragistics.Windows.DataPresenter.UnboundField TrkSysMessageAliasMessageAliasNumber_A8500_Col;

		// Token: 0x0400064F RID: 1615
		internal global::Infragistics.Windows.DataPresenter.UnboundField TrkSysMessageAliasMessageAliasText_A8503_Col;

		// Token: 0x04000650 RID: 1616
		internal global::AcpUI.AcpGroupBox ExpanderTrunkingSystemMessageAliasTableSRecView;

		// Token: 0x04000651 RID: 1617
		internal global::System.Windows.Controls.Grid gridExpanderTrunkingSystemMessageAliasTableSRecView;

		// Token: 0x04000652 RID: 1618
		internal global::AcpUI.AcpLabel TrkSysMsgAlias_A24069;

		// Token: 0x04000653 RID: 1619
		internal global::AcpUI.AcpCustomViewCheckBox CVBtnTrkSysMsgAlias_A24069;

		// Token: 0x04000654 RID: 1620
		internal global::AcpUI.AcpLabel LblTrkSysMsgAlias_A24069;

		// Token: 0x04000655 RID: 1621
		internal global::AcpUI.AcpCopyButton CpyBtnTrkSysMsgAlias_A24069;

		// Token: 0x04000656 RID: 1622
		internal global::AcpUI.AcpLabel TrkSysMsgAlias_A24069Comp;

		// Token: 0x04000657 RID: 1623
		internal global::AcpUI.AcpTextBoxSpinner TrkSysMessageAliasMessageAliasNumber_A8500;

		// Token: 0x04000658 RID: 1624
		internal global::AcpUI.AcpCustomViewCheckBox CVBtnTrkSysMessageAliasMessageAliasNumber_A8500;

		// Token: 0x04000659 RID: 1625
		internal global::AcpUI.AcpLabel LblTrkSysMessageAliasMessageAliasNumber_A8500;

		// Token: 0x0400065A RID: 1626
		internal global::AcpUI.AcpRtdButton RTDBtnTrkSysMessageAliasMessageAliasNumber_A8500;

		// Token: 0x0400065B RID: 1627
		internal global::AcpUI.AcpCopyButton CpyBtnTrkSysMessageAliasMessageAliasNumber_A8500;

		// Token: 0x0400065C RID: 1628
		internal global::AcpUI.AcpLabel TrkSysMessageAliasMessageAliasNumber_A8500Comp;

		// Token: 0x0400065D RID: 1629
		internal global::AcpUI.AcpTextBox TrkSysMessageAliasMessageAliasText_A8503;

		// Token: 0x0400065E RID: 1630
		internal global::AcpUI.AcpCustomViewCheckBox CVBtnTrkSysMessageAliasMessageAliasText_A8503;

		// Token: 0x0400065F RID: 1631
		internal global::AcpUI.AcpLabel LblTrkSysMessageAliasMessageAliasText_A8503;

		// Token: 0x04000660 RID: 1632
		internal global::AcpUI.AcpRtdButton RTDBtnTrkSysMessageAliasMessageAliasText_A8503;

		// Token: 0x04000661 RID: 1633
		internal global::AcpUI.AcpCopyButton CpyBtnTrkSysMessageAliasMessageAliasText_A8503;

		// Token: 0x04000662 RID: 1634
		internal global::AcpUI.AcpLabel TrkSysMessageAliasMessageAliasText_A8503Comp;

		// Token: 0x04000663 RID: 1635
		internal global::AcpUI.AcpExpander ExpanderTrunkingSystemTypeIIChannelSetup;

		// Token: 0x04000664 RID: 1636
		internal global::AcpUI.AcpGroupBox GrpBoxExpanderTrunkingSystemTypeIIChannelSetupPseudo0;

		// Token: 0x04000665 RID: 1637
		internal global::AcpUI.AcpCustomViewCheckBox CVBtnTrkSysTypeIIChannelSetupSplinterChannel_A9175;

		// Token: 0x04000666 RID: 1638
		internal global::AcpUI.AcpLabel LblTrkSysTypeIIChannelSetupSplinterChannel_A9175;

		// Token: 0x04000667 RID: 1639
		internal global::AcpUI.AcpCheckBox TrkSysTypeIIChannelSetupSplinterChannel_A9175;

		// Token: 0x04000668 RID: 1640
		internal global::AcpUI.AcpRtdButton RTDBtnTrkSysTypeIIChannelSetupSplinterChannel_A9175;

		// Token: 0x04000669 RID: 1641
		internal global::AcpUI.AcpCopyButton CpyBtnTrkSysTypeIIChannelSetupSplinterChannel_A9175;

		// Token: 0x0400066A RID: 1642
		internal global::AcpUI.AcpCheckBox TrkSysTypeIIChannelSetupSplinterChannel_A9175Comp;

		// Token: 0x0400066B RID: 1643
		internal global::AcpUI.AcpCustomViewCheckBox CVBtnTrkSysTypeIIChannelSetupShuffledBandPlan_A9128;

		// Token: 0x0400066C RID: 1644
		internal global::AcpUI.AcpLabel LblTrkSysTypeIIChannelSetupShuffledBandPlan_A9128;

		// Token: 0x0400066D RID: 1645
		internal global::AcpUI.AcpCheckBox TrkSysTypeIIChannelSetupShuffledBandPlan_A9128;

		// Token: 0x0400066E RID: 1646
		internal global::AcpUI.AcpRtdButton RTDBtnTrkSysTypeIIChannelSetupShuffledBandPlan_A9128;

		// Token: 0x0400066F RID: 1647
		internal global::AcpUI.AcpCopyButton CpyBtnTrkSysTypeIIChannelSetupShuffledBandPlan_A9128;

		// Token: 0x04000670 RID: 1648
		internal global::AcpUI.AcpCheckBox TrkSysTypeIIChannelSetupShuffledBandPlan_A9128Comp;

		// Token: 0x04000671 RID: 1649
		internal global::AcpUI.AcpCustomViewCheckBox CVBtnTrkSysTypeIIChannelSetupLegacyTransitSystem_A8429;

		// Token: 0x04000672 RID: 1650
		internal global::AcpUI.AcpLabel LblTrkSysTypeIIChannelSetupLegacyTransitSystem_A8429;

		// Token: 0x04000673 RID: 1651
		internal global::AcpUI.AcpCheckBox TrkSysTypeIIChannelSetupLegacyTransitSystem_A8429;

		// Token: 0x04000674 RID: 1652
		internal global::AcpUI.AcpRtdButton RTDBtnTrkSysTypeIIChannelSetupLegacyTransitSystem_A8429;

		// Token: 0x04000675 RID: 1653
		internal global::AcpUI.AcpCopyButton CpyBtnTrkSysTypeIIChannelSetupLegacyTransitSystem_A8429;

		// Token: 0x04000676 RID: 1654
		internal global::AcpUI.AcpCheckBox TrkSysTypeIIChannelSetupLegacyTransitSystem_A8429Comp;

		// Token: 0x04000677 RID: 1655
		internal global::AcpUI.AcpCustomViewCheckBox CVBtnTrkSysTypeIIChannelSetupChannelBandwidthkHz_A7654;

		// Token: 0x04000678 RID: 1656
		internal global::AcpUI.AcpLabel LblTrkSysTypeIIChannelSetupChannelBandwidthkHz_A7654;

		// Token: 0x04000679 RID: 1657
		internal global::AcpUI.AcpComboBox TrkSysTypeIIChannelSetupChannelBandwidthkHz_A7654;

		// Token: 0x0400067A RID: 1658
		internal global::AcpUI.AcpRtdButton RTDBtnTrkSysTypeIIChannelSetupChannelBandwidthkHz_A7654;

		// Token: 0x0400067B RID: 1659
		internal global::AcpUI.AcpCopyButton CpyBtnTrkSysTypeIIChannelSetupChannelBandwidthkHz_A7654;

		// Token: 0x0400067C RID: 1660
		internal global::AcpUI.AcpLabel TrkSysTypeIIChannelSetupChannelBandwidthkHz_A7654Comp;

		// Token: 0x0400067D RID: 1661
		internal global::AcpUI.AcpCustomViewCheckBox CVBtnTrkSysTypeIIChannelSetupNPSPACChannelBandwidthkHz_A8571;

		// Token: 0x0400067E RID: 1662
		internal global::AcpUI.AcpLabel LblTrkSysTypeIIChannelSetupNPSPACChannelBandwidthkHz_A8571;

		// Token: 0x0400067F RID: 1663
		internal global::AcpUI.AcpComboBox TrkSysTypeIIChannelSetupNPSPACChannelBandwidthkHz_A8571;

		// Token: 0x04000680 RID: 1664
		internal global::AcpUI.AcpRtdButton RTDBtnTrkSysTypeIIChannelSetupNPSPACChannelBandwidthkHz_A8571;

		// Token: 0x04000681 RID: 1665
		internal global::AcpUI.AcpCopyButton CpyBtnTrkSysTypeIIChannelSetupNPSPACChannelBandwidthkHz_A8571;

		// Token: 0x04000682 RID: 1666
		internal global::AcpUI.AcpLabel TrkSysTypeIIChannelSetupNPSPACChannelBandwidthkHz_A8571Comp;

		// Token: 0x04000683 RID: 1667
		internal global::AcpUI.AcpCustomViewCheckBox CVBtnTrkSysTypeIIChannelSetupChannelAssignmentType_A7652;

		// Token: 0x04000684 RID: 1668
		internal global::AcpUI.AcpLabel LblTrkSysTypeIIChannelSetupChannelAssignmentType_A7652;

		// Token: 0x04000685 RID: 1669
		internal global::AcpUI.AcpComboBox TrkSysTypeIIChannelSetupChannelAssignmentType_A7652;

		// Token: 0x04000686 RID: 1670
		internal global::AcpUI.AcpRtdButton RTDBtnTrkSysTypeIIChannelSetupChannelAssignmentType_A7652;

		// Token: 0x04000687 RID: 1671
		internal global::AcpUI.AcpCopyButton CpyBtnTrkSysTypeIIChannelSetupChannelAssignmentType_A7652;

		// Token: 0x04000688 RID: 1672
		internal global::AcpUI.AcpLabel TrkSysTypeIIChannelSetupChannelAssignmentType_A7652Comp;

		// Token: 0x04000689 RID: 1673
		internal global::AcpUI.AcpExpander ExpanderTrunkingSystemStatusAlias;

		// Token: 0x0400068A RID: 1674
		internal global::AcpUI.AcpChildRecNavToolbar RecNavToolbarExpanderTrunkingSystemStatusAliasTable;

		// Token: 0x0400068B RID: 1675
		internal global::AcpUI.AcpGroupBox GrpBoxExpanderTrunkingSystemStatusAliasPseudo0;

		// Token: 0x0400068C RID: 1676
		internal global::AcpUI.AcpCustomViewCheckBox CVBtnTrkSysStatusAliasStatusAliasEnable_A9195;

		// Token: 0x0400068D RID: 1677
		internal global::AcpUI.AcpLabel LblTrkSysStatusAliasStatusAliasEnable_A9195;

		// Token: 0x0400068E RID: 1678
		internal global::AcpUI.AcpCheckBox TrkSysStatusAliasStatusAliasEnable_A9195;

		// Token: 0x0400068F RID: 1679
		internal global::AcpUI.AcpRtdButton RTDBtnTrkSysStatusAliasStatusAliasEnable_A9195;

		// Token: 0x04000690 RID: 1680
		internal global::AcpUI.AcpCopyButton CpyBtnTrkSysStatusAliasStatusAliasEnable_A9195;

		// Token: 0x04000691 RID: 1681
		internal global::AcpUI.AcpCheckBox TrkSysStatusAliasStatusAliasEnable_A9195Comp;

		// Token: 0x04000692 RID: 1682
		internal global::System.Windows.Controls.Grid ExpanderTrunkingSystemStatusAliasGrid;

		// Token: 0x04000693 RID: 1683
		internal global::System.Windows.Controls.Grid ExpanderTrunkingSystemStatusAliasTableGrid;

		// Token: 0x04000694 RID: 1684
		internal global::AcpUI.AcpGroupBox ExpanderTrunkingSystemStatusAliasTableTableView;

		// Token: 0x04000695 RID: 1685
		internal global::AcpUI.AcpXamDataPresenter ExpanderTrunkingSystemStatusAliasTable;

		// Token: 0x04000696 RID: 1686
		internal global::Infragistics.Windows.DataPresenter.UnboundField Position_37454;

		// Token: 0x04000697 RID: 1687
		internal global::Infragistics.Windows.DataPresenter.UnboundField TrkSysStatusAlias_A24070_Col;

		// Token: 0x04000698 RID: 1688
		internal global::Infragistics.Windows.DataPresenter.UnboundField TrkSysStatusAliasStatusAliasNumber_A9190_Col;

		// Token: 0x04000699 RID: 1689
		internal global::Infragistics.Windows.DataPresenter.UnboundField TrkSysStatusAliasStatusAliasText_A9193_Col;

		// Token: 0x0400069A RID: 1690
		internal global::AcpUI.AcpGroupBox ExpanderTrunkingSystemStatusAliasTableSRecView;

		// Token: 0x0400069B RID: 1691
		internal global::System.Windows.Controls.Grid gridExpanderTrunkingSystemStatusAliasTableSRecView;

		// Token: 0x0400069C RID: 1692
		internal global::AcpUI.AcpLabel TrkSysStatusAlias_A24070;

		// Token: 0x0400069D RID: 1693
		internal global::AcpUI.AcpCustomViewCheckBox CVBtnTrkSysStatusAlias_A24070;

		// Token: 0x0400069E RID: 1694
		internal global::AcpUI.AcpLabel LblTrkSysStatusAlias_A24070;

		// Token: 0x0400069F RID: 1695
		internal global::AcpUI.AcpCopyButton CpyBtnTrkSysStatusAlias_A24070;

		// Token: 0x040006A0 RID: 1696
		internal global::AcpUI.AcpLabel TrkSysStatusAlias_A24070Comp;

		// Token: 0x040006A1 RID: 1697
		internal global::AcpUI.AcpTextBoxSpinner TrkSysStatusAliasStatusAliasNumber_A9190;

		// Token: 0x040006A2 RID: 1698
		internal global::AcpUI.AcpCustomViewCheckBox CVBtnTrkSysStatusAliasStatusAliasNumber_A9190;

		// Token: 0x040006A3 RID: 1699
		internal global::AcpUI.AcpLabel LblTrkSysStatusAliasStatusAliasNumber_A9190;

		// Token: 0x040006A4 RID: 1700
		internal global::AcpUI.AcpRtdButton RTDBtnTrkSysStatusAliasStatusAliasNumber_A9190;

		// Token: 0x040006A5 RID: 1701
		internal global::AcpUI.AcpCopyButton CpyBtnTrkSysStatusAliasStatusAliasNumber_A9190;

		// Token: 0x040006A6 RID: 1702
		internal global::AcpUI.AcpLabel TrkSysStatusAliasStatusAliasNumber_A9190Comp;

		// Token: 0x040006A7 RID: 1703
		internal global::AcpUI.AcpTextBox TrkSysStatusAliasStatusAliasText_A9193;

		// Token: 0x040006A8 RID: 1704
		internal global::AcpUI.AcpCustomViewCheckBox CVBtnTrkSysStatusAliasStatusAliasText_A9193;

		// Token: 0x040006A9 RID: 1705
		internal global::AcpUI.AcpLabel LblTrkSysStatusAliasStatusAliasText_A9193;

		// Token: 0x040006AA RID: 1706
		internal global::AcpUI.AcpRtdButton RTDBtnTrkSysStatusAliasStatusAliasText_A9193;

		// Token: 0x040006AB RID: 1707
		internal global::AcpUI.AcpCopyButton CpyBtnTrkSysStatusAliasStatusAliasText_A9193;

		// Token: 0x040006AC RID: 1708
		internal global::AcpUI.AcpLabel TrkSysStatusAliasStatusAliasText_A9193Comp;

		// Token: 0x040006AD RID: 1709
		internal global::AcpUI.AcpExpander ExpanderTrunkingSystemSiteAlias;

		// Token: 0x040006AE RID: 1710
		internal global::AcpUI.AcpChildRecNavToolbar RecNavToolbarExpanderTrunkingSystemSiteAliasTable;

		// Token: 0x040006AF RID: 1711
		internal global::AcpUI.AcpGroupBox GrpBoxExpanderTrunkingSystemSiteAliasPseudo0;

		// Token: 0x040006B0 RID: 1712
		internal global::AcpUI.AcpCustomViewCheckBox CVBtnTrkSysSiteAliasSiteAliasEnable_A9148;

		// Token: 0x040006B1 RID: 1713
		internal global::AcpUI.AcpLabel LblTrkSysSiteAliasSiteAliasEnable_A9148;

		// Token: 0x040006B2 RID: 1714
		internal global::AcpUI.AcpCheckBox TrkSysSiteAliasSiteAliasEnable_A9148;

		// Token: 0x040006B3 RID: 1715
		internal global::AcpUI.AcpRtdButton RTDBtnTrkSysSiteAliasSiteAliasEnable_A9148;

		// Token: 0x040006B4 RID: 1716
		internal global::AcpUI.AcpCopyButton CpyBtnTrkSysSiteAliasSiteAliasEnable_A9148;

		// Token: 0x040006B5 RID: 1717
		internal global::AcpUI.AcpCheckBox TrkSysSiteAliasSiteAliasEnable_A9148Comp;

		// Token: 0x040006B6 RID: 1718
		internal global::System.Windows.Controls.Grid ExpanderTrunkingSystemSiteAliasGrid;

		// Token: 0x040006B7 RID: 1719
		internal global::System.Windows.Controls.Grid ExpanderTrunkingSystemSiteAliasTableGrid;

		// Token: 0x040006B8 RID: 1720
		internal global::AcpUI.AcpGroupBox ExpanderTrunkingSystemSiteAliasTableTableView;

		// Token: 0x040006B9 RID: 1721
		internal global::AcpUI.AcpXamDataPresenter ExpanderTrunkingSystemSiteAliasTable;

		// Token: 0x040006BA RID: 1722
		internal global::Infragistics.Windows.DataPresenter.UnboundField Position_37455;

		// Token: 0x040006BB RID: 1723
		internal global::Infragistics.Windows.DataPresenter.UnboundField TrkSysSiteAlias_A24071_Col;

		// Token: 0x040006BC RID: 1724
		internal global::Infragistics.Windows.DataPresenter.UnboundField TrkSysSiteAliasRFSSAliasNumber_A8978_Col;

		// Token: 0x040006BD RID: 1725
		internal global::Infragistics.Windows.DataPresenter.UnboundField TrkSysSiteAliasSiteAliasNumber_A9145_Col;

		// Token: 0x040006BE RID: 1726
		internal global::Infragistics.Windows.DataPresenter.UnboundField TrkSysSiteAliasSiteAliasText_A9146_Col;

		// Token: 0x040006BF RID: 1727
		internal global::Infragistics.Windows.DataPresenter.UnboundField TrkSysSiteAliasSiteAliasType_A41343_Col;

		// Token: 0x040006C0 RID: 1728
		internal global::Infragistics.Windows.DataPresenter.UnboundField TrkSysSiteAliasSystemNumber_A19669_Col;

		// Token: 0x040006C1 RID: 1729
		internal global::Infragistics.Windows.DataPresenter.UnboundField TrkSysSiteAliasHomeRASWACNNumber_A20169_Col;

		// Token: 0x040006C2 RID: 1730
		internal global::AcpUI.AcpGroupBox ExpanderTrunkingSystemSiteAliasTableSRecView;

		// Token: 0x040006C3 RID: 1731
		internal global::System.Windows.Controls.Grid gridExpanderTrunkingSystemSiteAliasTableSRecView;

		// Token: 0x040006C4 RID: 1732
		internal global::AcpUI.AcpLabel TrkSysSiteAlias_A24071;

		// Token: 0x040006C5 RID: 1733
		internal global::AcpUI.AcpCustomViewCheckBox CVBtnTrkSysSiteAlias_A24071;

		// Token: 0x040006C6 RID: 1734
		internal global::AcpUI.AcpLabel LblTrkSysSiteAlias_A24071;

		// Token: 0x040006C7 RID: 1735
		internal global::AcpUI.AcpCopyButton CpyBtnTrkSysSiteAlias_A24071;

		// Token: 0x040006C8 RID: 1736
		internal global::AcpUI.AcpLabel TrkSysSiteAlias_A24071Comp;

		// Token: 0x040006C9 RID: 1737
		internal global::AcpUI.AcpTextBoxSpinner TrkSysSiteAliasRFSSAliasNumber_A8978;

		// Token: 0x040006CA RID: 1738
		internal global::AcpUI.AcpCustomViewCheckBox CVBtnTrkSysSiteAliasRFSSAliasNumber_A8978;

		// Token: 0x040006CB RID: 1739
		internal global::AcpUI.AcpLabel LblTrkSysSiteAliasRFSSAliasNumber_A8978;

		// Token: 0x040006CC RID: 1740
		internal global::AcpUI.AcpRtdButton RTDBtnTrkSysSiteAliasRFSSAliasNumber_A8978;

		// Token: 0x040006CD RID: 1741
		internal global::AcpUI.AcpCopyButton CpyBtnTrkSysSiteAliasRFSSAliasNumber_A8978;

		// Token: 0x040006CE RID: 1742
		internal global::AcpUI.AcpLabel TrkSysSiteAliasRFSSAliasNumber_A8978Comp;

		// Token: 0x040006CF RID: 1743
		internal global::AcpUI.AcpTextBoxSpinnerDecHex TrkSysSiteAliasSiteAliasNumber_A9145;

		// Token: 0x040006D0 RID: 1744
		internal global::AcpUI.AcpCustomViewCheckBox CVBtnTrkSysSiteAliasSiteAliasNumber_A9145;

		// Token: 0x040006D1 RID: 1745
		internal global::AcpUI.AcpLabel LblTrkSysSiteAliasSiteAliasNumber_A9145;

		// Token: 0x040006D2 RID: 1746
		internal global::AcpUI.AcpRtdButton RTDBtnTrkSysSiteAliasSiteAliasNumber_A9145;

		// Token: 0x040006D3 RID: 1747
		internal global::AcpUI.AcpCopyButton CpyBtnTrkSysSiteAliasSiteAliasNumber_A9145;

		// Token: 0x040006D4 RID: 1748
		internal global::AcpUI.AcpTextBoxDecHex TrkSysSiteAliasSiteAliasNumber_A9145Comp;

		// Token: 0x040006D5 RID: 1749
		internal global::AcpUI.AcpTextBox TrkSysSiteAliasSiteAliasText_A9146;

		// Token: 0x040006D6 RID: 1750
		internal global::AcpUI.AcpCustomViewCheckBox CVBtnTrkSysSiteAliasSiteAliasText_A9146;

		// Token: 0x040006D7 RID: 1751
		internal global::AcpUI.AcpLabel LblTrkSysSiteAliasSiteAliasText_A9146;

		// Token: 0x040006D8 RID: 1752
		internal global::AcpUI.AcpRtdButton RTDBtnTrkSysSiteAliasSiteAliasText_A9146;

		// Token: 0x040006D9 RID: 1753
		internal global::AcpUI.AcpCopyButton CpyBtnTrkSysSiteAliasSiteAliasText_A9146;

		// Token: 0x040006DA RID: 1754
		internal global::AcpUI.AcpLabel TrkSysSiteAliasSiteAliasText_A9146Comp;

		// Token: 0x040006DB RID: 1755
		internal global::AcpUI.AcpComboBox TrkSysSiteAliasSiteAliasType_A41343;

		// Token: 0x040006DC RID: 1756
		internal global::AcpUI.AcpCustomViewCheckBox CVBtnTrkSysSiteAliasSiteAliasType_A41343;

		// Token: 0x040006DD RID: 1757
		internal global::AcpUI.AcpLabel LblTrkSysSiteAliasSiteAliasType_A41343;

		// Token: 0x040006DE RID: 1758
		internal global::AcpUI.AcpRtdButton RTDBtnTrkSysSiteAliasSiteAliasType_A41343;

		// Token: 0x040006DF RID: 1759
		internal global::AcpUI.AcpCopyButton CpyBtnTrkSysSiteAliasSiteAliasType_A41343;

		// Token: 0x040006E0 RID: 1760
		internal global::AcpUI.AcpLabel TrkSysSiteAliasSiteAliasType_A41343Comp;

		// Token: 0x040006E1 RID: 1761
		internal global::AcpUI.AcpTextBoxSpinnerDecHex TrkSysSiteAliasSystemNumber_A19669;

		// Token: 0x040006E2 RID: 1762
		internal global::AcpUI.AcpCustomViewCheckBox CVBtnTrkSysSiteAliasSystemNumber_A19669;

		// Token: 0x040006E3 RID: 1763
		internal global::AcpUI.AcpLabel LblTrkSysSiteAliasSystemNumber_A19669;

		// Token: 0x040006E4 RID: 1764
		internal global::AcpUI.AcpRtdButton RTDBtnTrkSysSiteAliasSystemNumber_A19669;

		// Token: 0x040006E5 RID: 1765
		internal global::AcpUI.AcpCopyButton CpyBtnTrkSysSiteAliasSystemNumber_A19669;

		// Token: 0x040006E6 RID: 1766
		internal global::AcpUI.AcpTextBoxDecHex TrkSysSiteAliasSystemNumber_A19669Comp;

		// Token: 0x040006E7 RID: 1767
		internal global::AcpUI.AcpTextBoxSpinnerDecHex TrkSysSiteAliasHomeRASWACNNumber_A20169;

		// Token: 0x040006E8 RID: 1768
		internal global::AcpUI.AcpCustomViewCheckBox CVBtnTrkSysSiteAliasHomeRASWACNNumber_A20169;

		// Token: 0x040006E9 RID: 1769
		internal global::AcpUI.AcpLabel LblTrkSysSiteAliasHomeRASWACNNumber_A20169;

		// Token: 0x040006EA RID: 1770
		internal global::AcpUI.AcpRtdButton RTDBtnTrkSysSiteAliasHomeRASWACNNumber_A20169;

		// Token: 0x040006EB RID: 1771
		internal global::AcpUI.AcpCopyButton CpyBtnTrkSysSiteAliasHomeRASWACNNumber_A20169;

		// Token: 0x040006EC RID: 1772
		internal global::AcpUI.AcpTextBoxDecHex TrkSysSiteAliasHomeRASWACNNumber_A20169Comp;

		// Token: 0x040006ED RID: 1773
		internal global::AcpUI.AcpExpander ExpanderTrunkingSystemOneTouch;

		// Token: 0x040006EE RID: 1774
		internal global::AcpUI.AcpChildRecNavToolbar RecNavToolbarExpanderTrunkingSystemOneTouchTable;

		// Token: 0x040006EF RID: 1775
		internal global::System.Windows.Controls.Grid ExpanderTrunkingSystemOneTouchGrid;

		// Token: 0x040006F0 RID: 1776
		internal global::System.Windows.Controls.Grid ExpanderTrunkingSystemOneTouchTableGrid;

		// Token: 0x040006F1 RID: 1777
		internal global::AcpUI.AcpGroupBox ExpanderTrunkingSystemOneTouchTableTableView;

		// Token: 0x040006F2 RID: 1778
		internal global::AcpUI.AcpXamDataPresenter ExpanderTrunkingSystemOneTouchTable;

		// Token: 0x040006F3 RID: 1779
		internal global::Infragistics.Windows.DataPresenter.UnboundField TrkSysOneTouchButton_A19763_Col;

		// Token: 0x040006F4 RID: 1780
		internal global::Infragistics.Windows.DataPresenter.UnboundField TrkSysOneTouchFeature_A8614_Col;

		// Token: 0x040006F5 RID: 1781
		internal global::Infragistics.Windows.DataPresenter.UnboundField TrkSysOneTouchIndex_A8618_Col;

		// Token: 0x040006F6 RID: 1782
		internal global::Infragistics.Windows.DataPresenter.UnboundField TrkSysOneTouchAbbreviatedOneTouchAlias_A8622_Col;

		// Token: 0x040006F7 RID: 1783
		internal global::AcpUI.AcpGroupBox ExpanderTrunkingSystemOneTouchTableSRecView;

		// Token: 0x040006F8 RID: 1784
		internal global::System.Windows.Controls.Grid gridExpanderTrunkingSystemOneTouchTableSRecView;

		// Token: 0x040006F9 RID: 1785
		internal global::AcpUI.AcpLabel TrkSysOneTouchButton_A19763;

		// Token: 0x040006FA RID: 1786
		internal global::AcpUI.AcpCustomViewCheckBox CVBtnTrkSysOneTouchButton_A19763;

		// Token: 0x040006FB RID: 1787
		internal global::AcpUI.AcpLabel LblTrkSysOneTouchButton_A19763;

		// Token: 0x040006FC RID: 1788
		internal global::AcpUI.AcpCopyButton CpyBtnTrkSysOneTouchButton_A19763;

		// Token: 0x040006FD RID: 1789
		internal global::AcpUI.AcpLabel TrkSysOneTouchButton_A19763Comp;

		// Token: 0x040006FE RID: 1790
		internal global::AcpUI.AcpComboBox TrkSysOneTouchFeature_A8614;

		// Token: 0x040006FF RID: 1791
		internal global::AcpUI.AcpCustomViewCheckBox CVBtnTrkSysOneTouchFeature_A8614;

		// Token: 0x04000700 RID: 1792
		internal global::AcpUI.AcpLabel LblTrkSysOneTouchFeature_A8614;

		// Token: 0x04000701 RID: 1793
		internal global::AcpUI.AcpRtdButton RTDBtnTrkSysOneTouchFeature_A8614;

		// Token: 0x04000702 RID: 1794
		internal global::AcpUI.AcpCopyButton CpyBtnTrkSysOneTouchFeature_A8614;

		// Token: 0x04000703 RID: 1795
		internal global::AcpUI.AcpLabel TrkSysOneTouchFeature_A8614Comp;

		// Token: 0x04000704 RID: 1796
		internal global::AcpUI.AcpTextBoxSpinner TrkSysOneTouchIndex_A8618;

		// Token: 0x04000705 RID: 1797
		internal global::AcpUI.AcpCustomViewCheckBox CVBtnTrkSysOneTouchIndex_A8618;

		// Token: 0x04000706 RID: 1798
		internal global::AcpUI.AcpLabel LblTrkSysOneTouchIndex_A8618;

		// Token: 0x04000707 RID: 1799
		internal global::AcpUI.AcpRtdButton RTDBtnTrkSysOneTouchIndex_A8618;

		// Token: 0x04000708 RID: 1800
		internal global::AcpUI.AcpCopyButton CpyBtnTrkSysOneTouchIndex_A8618;

		// Token: 0x04000709 RID: 1801
		internal global::AcpUI.AcpLabel TrkSysOneTouchIndex_A8618Comp;

		// Token: 0x0400070A RID: 1802
		internal global::AcpUI.AcpTextBox TrkSysOneTouchAbbreviatedOneTouchAlias_A8622;

		// Token: 0x0400070B RID: 1803
		internal global::AcpUI.AcpCustomViewCheckBox CVBtnTrkSysOneTouchAbbreviatedOneTouchAlias_A8622;

		// Token: 0x0400070C RID: 1804
		internal global::AcpUI.AcpLabel LblTrkSysOneTouchAbbreviatedOneTouchAlias_A8622;

		// Token: 0x0400070D RID: 1805
		internal global::AcpUI.AcpRtdButton RTDBtnTrkSysOneTouchAbbreviatedOneTouchAlias_A8622;

		// Token: 0x0400070E RID: 1806
		internal global::AcpUI.AcpCopyButton CpyBtnTrkSysOneTouchAbbreviatedOneTouchAlias_A8622;

		// Token: 0x0400070F RID: 1807
		internal global::AcpUI.AcpLabel TrkSysOneTouchAbbreviatedOneTouchAlias_A8622Comp;

		// Token: 0x04000710 RID: 1808
		internal global::AcpUI.AcpExpander ExpanderTrunkingSystemASTRO26;

		// Token: 0x04000711 RID: 1809
		internal global::AcpUI.AcpGroupBox GrpBoxExpanderTrunkingSystemASTRO26Pseudo0;

		// Token: 0x04000712 RID: 1810
		internal global::AcpUI.AcpCustomViewCheckBox CVBtnTrkSysASTRO25MotorolaProprietaryFeatures_A8547;

		// Token: 0x04000713 RID: 1811
		internal global::AcpUI.AcpLabel LblTrkSysASTRO25MotorolaProprietaryFeatures_A8547;

		// Token: 0x04000714 RID: 1812
		internal global::AcpUI.AcpCheckBox TrkSysASTRO25MotorolaProprietaryFeatures_A8547;

		// Token: 0x04000715 RID: 1813
		internal global::AcpUI.AcpRtdButton RTDBtnTrkSysASTRO25MotorolaProprietaryFeatures_A8547;

		// Token: 0x04000716 RID: 1814
		internal global::AcpUI.AcpCopyButton CpyBtnTrkSysASTRO25MotorolaProprietaryFeatures_A8547;

		// Token: 0x04000717 RID: 1815
		internal global::AcpUI.AcpCheckBox TrkSysASTRO25MotorolaProprietaryFeatures_A8547Comp;

		// Token: 0x04000718 RID: 1816
		internal global::AcpUI.AcpCustomViewCheckBox CVBtnTrkSysASTRO25ISPSequenceLengthsec_A8354;

		// Token: 0x04000719 RID: 1817
		internal global::AcpUI.AcpLabel LblTrkSysASTRO25ISPSequenceLengthsec_A8354;

		// Token: 0x0400071A RID: 1818
		internal global::AcpUI.AcpTextBoxSpinner TrkSysASTRO25ISPSequenceLengthsec_A8354;

		// Token: 0x0400071B RID: 1819
		internal global::AcpUI.AcpRtdButton RTDBtnTrkSysASTRO25ISPSequenceLengthsec_A8354;

		// Token: 0x0400071C RID: 1820
		internal global::AcpUI.AcpCopyButton CpyBtnTrkSysASTRO25ISPSequenceLengthsec_A8354;

		// Token: 0x0400071D RID: 1821
		internal global::AcpUI.AcpLabel TrkSysASTRO25ISPSequenceLengthsec_A8354Comp;

		// Token: 0x0400071E RID: 1822
		internal global::AcpUI.AcpCustomViewCheckBox CVBtnTrkSysASTRO25MaximumSlotSizems_A8478;

		// Token: 0x0400071F RID: 1823
		internal global::AcpUI.AcpLabel LblTrkSysASTRO25MaximumSlotSizems_A8478;

		// Token: 0x04000720 RID: 1824
		internal global::AcpUI.AcpTextBoxSpinner TrkSysASTRO25MaximumSlotSizems_A8478;

		// Token: 0x04000721 RID: 1825
		internal global::AcpUI.AcpRtdButton RTDBtnTrkSysASTRO25MaximumSlotSizems_A8478;

		// Token: 0x04000722 RID: 1826
		internal global::AcpUI.AcpCopyButton CpyBtnTrkSysASTRO25MaximumSlotSizems_A8478;

		// Token: 0x04000723 RID: 1827
		internal global::AcpUI.AcpLabel TrkSysASTRO25MaximumSlotSizems_A8478Comp;

		// Token: 0x04000724 RID: 1828
		internal global::AcpUI.AcpCustomViewCheckBox CVBtnTrkSysASTRO25ForceUnmuteTimems_A8141;

		// Token: 0x04000725 RID: 1829
		internal global::AcpUI.AcpLabel LblTrkSysASTRO25ForceUnmuteTimems_A8141;

		// Token: 0x04000726 RID: 1830
		internal global::AcpUI.AcpTextBoxSpinner TrkSysASTRO25ForceUnmuteTimems_A8141;

		// Token: 0x04000727 RID: 1831
		internal global::AcpUI.AcpRtdButton RTDBtnTrkSysASTRO25ForceUnmuteTimems_A8141;

		// Token: 0x04000728 RID: 1832
		internal global::AcpUI.AcpCopyButton CpyBtnTrkSysASTRO25ForceUnmuteTimems_A8141;

		// Token: 0x04000729 RID: 1833
		internal global::AcpUI.AcpLabel TrkSysASTRO25ForceUnmuteTimems_A8141Comp;

		// Token: 0x0400072A RID: 1834
		internal global::AcpUI.AcpCustomViewCheckBox CVBtnTrkSysASTRO25QuickFadeProtectms_A8807;

		// Token: 0x0400072B RID: 1835
		internal global::AcpUI.AcpLabel LblTrkSysASTRO25QuickFadeProtectms_A8807;

		// Token: 0x0400072C RID: 1836
		internal global::AcpUI.AcpTextBoxSpinner TrkSysASTRO25QuickFadeProtectms_A8807;

		// Token: 0x0400072D RID: 1837
		internal global::AcpUI.AcpRtdButton RTDBtnTrkSysASTRO25QuickFadeProtectms_A8807;

		// Token: 0x0400072E RID: 1838
		internal global::AcpUI.AcpCopyButton CpyBtnTrkSysASTRO25QuickFadeProtectms_A8807;

		// Token: 0x0400072F RID: 1839
		internal global::AcpUI.AcpLabel TrkSysASTRO25QuickFadeProtectms_A8807Comp;

		// Token: 0x04000730 RID: 1840
		internal global::AcpUI.AcpCustomViewCheckBox CVBtnTrkSysASTRO25PTTWarningTimems_A8781;

		// Token: 0x04000731 RID: 1841
		internal global::AcpUI.AcpLabel LblTrkSysASTRO25PTTWarningTimems_A8781;

		// Token: 0x04000732 RID: 1842
		internal global::AcpUI.AcpTextBoxSpinner TrkSysASTRO25PTTWarningTimems_A8781;

		// Token: 0x04000733 RID: 1843
		internal global::AcpUI.AcpRtdButton RTDBtnTrkSysASTRO25PTTWarningTimems_A8781;

		// Token: 0x04000734 RID: 1844
		internal global::AcpUI.AcpCopyButton CpyBtnTrkSysASTRO25PTTWarningTimems_A8781;

		// Token: 0x04000735 RID: 1845
		internal global::AcpUI.AcpLabel TrkSysASTRO25PTTWarningTimems_A8781Comp;

		// Token: 0x04000736 RID: 1846
		internal global::AcpUI.AcpCustomViewCheckBox CVBtnTrkSysASTRO25BusyUpdateTimesec_A7574;

		// Token: 0x04000737 RID: 1847
		internal global::AcpUI.AcpLabel LblTrkSysASTRO25BusyUpdateTimesec_A7574;

		// Token: 0x04000738 RID: 1848
		internal global::AcpUI.AcpTextBoxSpinner TrkSysASTRO25BusyUpdateTimesec_A7574;

		// Token: 0x04000739 RID: 1849
		internal global::AcpUI.AcpRtdButton RTDBtnTrkSysASTRO25BusyUpdateTimesec_A7574;

		// Token: 0x0400073A RID: 1850
		internal global::AcpUI.AcpCopyButton CpyBtnTrkSysASTRO25BusyUpdateTimesec_A7574;

		// Token: 0x0400073B RID: 1851
		internal global::AcpUI.AcpLabel TrkSysASTRO25BusyUpdateTimesec_A7574Comp;

		// Token: 0x0400073C RID: 1852
		internal global::AcpUI.AcpCustomViewCheckBox CVBtnTrkSysASTRO25ResponsePendingTimesec_A8945;

		// Token: 0x0400073D RID: 1853
		internal global::AcpUI.AcpLabel LblTrkSysASTRO25ResponsePendingTimesec_A8945;

		// Token: 0x0400073E RID: 1854
		internal global::AcpUI.AcpTextBoxSpinner TrkSysASTRO25ResponsePendingTimesec_A8945;

		// Token: 0x0400073F RID: 1855
		internal global::AcpUI.AcpRtdButton RTDBtnTrkSysASTRO25ResponsePendingTimesec_A8945;

		// Token: 0x04000740 RID: 1856
		internal global::AcpUI.AcpCopyButton CpyBtnTrkSysASTRO25ResponsePendingTimesec_A8945;

		// Token: 0x04000741 RID: 1857
		internal global::AcpUI.AcpLabel TrkSysASTRO25ResponsePendingTimesec_A8945Comp;

		// Token: 0x04000742 RID: 1858
		internal global::AcpUI.AcpCustomViewCheckBox CVBtnTrkSysASTRO25DefaultRCMAddress_A7813;

		// Token: 0x04000743 RID: 1859
		internal global::AcpUI.AcpLabel LblTrkSysASTRO25DefaultRCMAddress_A7813;

		// Token: 0x04000744 RID: 1860
		internal global::AcpUI.AcpTextBoxSpinnerDecHex TrkSysASTRO25DefaultRCMAddress_A7813;

		// Token: 0x04000745 RID: 1861
		internal global::AcpUI.AcpRtdButton RTDBtnTrkSysASTRO25DefaultRCMAddress_A7813;

		// Token: 0x04000746 RID: 1862
		internal global::AcpUI.AcpCopyButton CpyBtnTrkSysASTRO25DefaultRCMAddress_A7813;

		// Token: 0x04000747 RID: 1863
		internal global::AcpUI.AcpTextBoxDecHex TrkSysASTRO25DefaultRCMAddress_A7813Comp;

		// Token: 0x04000748 RID: 1864
		internal global::AcpUI.AcpCustomViewCheckBox CVBtnTrkSysASTRO25F2VoiceCapable_A1395;

		// Token: 0x04000749 RID: 1865
		internal global::AcpUI.AcpLabel LblTrkSysASTRO25F2VoiceCapable_A1395;

		// Token: 0x0400074A RID: 1866
		internal global::AcpUI.AcpCheckBox TrkSysASTRO25F2VoiceCapable_A1395;

		// Token: 0x0400074B RID: 1867
		internal global::AcpUI.AcpRtdButton RTDBtnTrkSysASTRO25F2VoiceCapable_A1395;

		// Token: 0x0400074C RID: 1868
		internal global::AcpUI.AcpCopyButton CpyBtnTrkSysASTRO25F2VoiceCapable_A1395;

		// Token: 0x0400074D RID: 1869
		internal global::AcpUI.AcpCheckBox TrkSysASTRO25F2VoiceCapable_A1395Comp;

		// Token: 0x0400074E RID: 1870
		internal global::AcpUI.AcpCustomViewCheckBox CVBtnTrkSysASTRO25EndF2TDMATransmitOnOutOfRange_A1394;

		// Token: 0x0400074F RID: 1871
		internal global::AcpUI.AcpLabel LblTrkSysASTRO25EndF2TDMATransmitOnOutOfRange_A1394;

		// Token: 0x04000750 RID: 1872
		internal global::AcpUI.AcpCheckBox TrkSysASTRO25EndF2TDMATransmitOnOutOfRange_A1394;

		// Token: 0x04000751 RID: 1873
		internal global::AcpUI.AcpRtdButton RTDBtnTrkSysASTRO25EndF2TDMATransmitOnOutOfRange_A1394;

		// Token: 0x04000752 RID: 1874
		internal global::AcpUI.AcpCopyButton CpyBtnTrkSysASTRO25EndF2TDMATransmitOnOutOfRange_A1394;

		// Token: 0x04000753 RID: 1875
		internal global::AcpUI.AcpCheckBox TrkSysASTRO25EndF2TDMATransmitOnOutOfRange_A1394Comp;

		// Token: 0x04000754 RID: 1876
		internal global::AcpUI.AcpCustomViewCheckBox CVBtnTrkSysASTRO25Phase2VoiceCapable_A37972;

		// Token: 0x04000755 RID: 1877
		internal global::AcpUI.AcpLabel LblTrkSysASTRO25Phase2VoiceCapable_A37972;

		// Token: 0x04000756 RID: 1878
		internal global::AcpUI.AcpCheckBox TrkSysASTRO25Phase2VoiceCapable_A37972;

		// Token: 0x04000757 RID: 1879
		internal global::AcpUI.AcpRtdButton RTDBtnTrkSysASTRO25Phase2VoiceCapable_A37972;

		// Token: 0x04000758 RID: 1880
		internal global::AcpUI.AcpCopyButton CpyBtnTrkSysASTRO25Phase2VoiceCapable_A37972;

		// Token: 0x04000759 RID: 1881
		internal global::AcpUI.AcpCheckBox TrkSysASTRO25Phase2VoiceCapable_A37972Comp;

		// Token: 0x0400075A RID: 1882
		internal global::AcpUI.AcpCustomViewCheckBox CVBtnTrkSysASTRO25EndPhase2TDMATransmitOnOutOfRange_A37980;

		// Token: 0x0400075B RID: 1883
		internal global::AcpUI.AcpLabel LblTrkSysASTRO25EndPhase2TDMATransmitOnOutOfRange_A37980;

		// Token: 0x0400075C RID: 1884
		internal global::AcpUI.AcpCheckBox TrkSysASTRO25EndPhase2TDMATransmitOnOutOfRange_A37980;

		// Token: 0x0400075D RID: 1885
		internal global::AcpUI.AcpRtdButton RTDBtnTrkSysASTRO25EndPhase2TDMATransmitOnOutOfRange_A37980;

		// Token: 0x0400075E RID: 1886
		internal global::AcpUI.AcpCopyButton CpyBtnTrkSysASTRO25EndPhase2TDMATransmitOnOutOfRange_A37980;

		// Token: 0x0400075F RID: 1887
		internal global::AcpUI.AcpCheckBox TrkSysASTRO25EndPhase2TDMATransmitOnOutOfRange_A37980Comp;

		// Token: 0x04000760 RID: 1888
		internal global::AcpUI.AcpCustomViewCheckBox CVBtnTrkSysASTRO25ValidateNACAgainstSystemID_A20608;

		// Token: 0x04000761 RID: 1889
		internal global::AcpUI.AcpLabel LblTrkSysASTRO25ValidateNACAgainstSystemID_A20608;

		// Token: 0x04000762 RID: 1890
		internal global::AcpUI.AcpCheckBox TrkSysASTRO25ValidateNACAgainstSystemID_A20608;

		// Token: 0x04000763 RID: 1891
		internal global::AcpUI.AcpRtdButton RTDBtnTrkSysASTRO25ValidateNACAgainstSystemID_A20608;

		// Token: 0x04000764 RID: 1892
		internal global::AcpUI.AcpCopyButton CpyBtnTrkSysASTRO25ValidateNACAgainstSystemID_A20608;

		// Token: 0x04000765 RID: 1893
		internal global::AcpUI.AcpCheckBox TrkSysASTRO25ValidateNACAgainstSystemID_A20608Comp;

		// Token: 0x04000766 RID: 1894
		internal global::AcpUI.AcpCustomViewCheckBox CVBtnTrkSysASTRO25WUIDValiditySupport_A41483;

		// Token: 0x04000767 RID: 1895
		internal global::AcpUI.AcpLabel LblTrkSysASTRO25WUIDValiditySupport_A41483;

		// Token: 0x04000768 RID: 1896
		internal global::AcpUI.AcpCheckBox TrkSysASTRO25WUIDValiditySupport_A41483;

		// Token: 0x04000769 RID: 1897
		internal global::AcpUI.AcpRtdButton RTDBtnTrkSysASTRO25WUIDValiditySupport_A41483;

		// Token: 0x0400076A RID: 1898
		internal global::AcpUI.AcpCopyButton CpyBtnTrkSysASTRO25WUIDValiditySupport_A41483;

		// Token: 0x0400076B RID: 1899
		internal global::AcpUI.AcpCheckBox TrkSysASTRO25WUIDValiditySupport_A41483Comp;

		// Token: 0x0400076C RID: 1900
		internal global::AcpUI.AcpCustomViewCheckBox CVBtnTrkSysASTRO25GeoFenceMode_42322;

		// Token: 0x0400076D RID: 1901
		internal global::AcpUI.AcpLabel LblTrkSysASTRO25GeoFenceMode_42322;

		// Token: 0x0400076E RID: 1902
		internal global::AcpUI.AcpComboBox TrkSysASTRO25GeoFenceMode_42322;

		// Token: 0x0400076F RID: 1903
		internal global::AcpUI.AcpRtdButton RTDBtnTrkSysASTRO25GeoFenceMode_42322;

		// Token: 0x04000770 RID: 1904
		internal global::AcpUI.AcpCopyButton CpyBtnTrkSysASTRO25GeoFenceMode_42322;

		// Token: 0x04000771 RID: 1905
		internal global::AcpUI.AcpLabel TrkSysASTRO25GeoFenceMode_42322Comp;

		// Token: 0x04000772 RID: 1906
		internal global::AcpUI.AcpExpander ExpanderTrunkingSystemDigital;

		// Token: 0x04000773 RID: 1907
		internal global::AcpUI.AcpGroupBox GrpBoxExpanderTrunkingSystemDigitalPseudo0;

		// Token: 0x04000774 RID: 1908
		internal global::AcpUI.AcpCustomViewCheckBox CVBtnTrkSysDigitalAdaptivePower_A7509;

		// Token: 0x04000775 RID: 1909
		internal global::AcpUI.AcpLabel LblTrkSysDigitalAdaptivePower_A7509;

		// Token: 0x04000776 RID: 1910
		internal global::AcpUI.AcpCheckBox TrkSysDigitalAdaptivePower_A7509;

		// Token: 0x04000777 RID: 1911
		internal global::AcpUI.AcpRtdButton RTDBtnTrkSysDigitalAdaptivePower_A7509;

		// Token: 0x04000778 RID: 1912
		internal global::AcpUI.AcpCopyButton CpyBtnTrkSysDigitalAdaptivePower_A7509;

		// Token: 0x04000779 RID: 1913
		internal global::AcpUI.AcpCheckBox TrkSysDigitalAdaptivePower_A7509Comp;

		// Token: 0x0400077A RID: 1914
		internal global::AcpUI.AcpCustomViewCheckBox CVBtnTrkSysDigitalHighDeviationTx_A19314;

		// Token: 0x0400077B RID: 1915
		internal global::AcpUI.AcpLabel LblTrkSysDigitalHighDeviationTx_A19314;

		// Token: 0x0400077C RID: 1916
		internal global::AcpUI.AcpCheckBox TrkSysDigitalHighDeviationTx_A19314;

		// Token: 0x0400077D RID: 1917
		internal global::AcpUI.AcpRtdButton RTDBtnTrkSysDigitalHighDeviationTx_A19314;

		// Token: 0x0400077E RID: 1918
		internal global::AcpUI.AcpCopyButton CpyBtnTrkSysDigitalHighDeviationTx_A19314;

		// Token: 0x0400077F RID: 1919
		internal global::AcpUI.AcpCheckBox TrkSysDigitalHighDeviationTx_A19314Comp;

		// Token: 0x04000780 RID: 1920
		internal global::AcpUI.AcpCustomViewCheckBox CVBtnTrkSysDigitalPreambleLength_A8722;

		// Token: 0x04000781 RID: 1921
		internal global::AcpUI.AcpLabel LblTrkSysDigitalPreambleLength_A8722;

		// Token: 0x04000782 RID: 1922
		internal global::AcpUI.AcpTextBoxSpinner TrkSysDigitalPreambleLength_A8722;

		// Token: 0x04000783 RID: 1923
		internal global::AcpUI.AcpRtdButton RTDBtnTrkSysDigitalPreambleLength_A8722;

		// Token: 0x04000784 RID: 1924
		internal global::AcpUI.AcpCopyButton CpyBtnTrkSysDigitalPreambleLength_A8722;

		// Token: 0x04000785 RID: 1925
		internal global::AcpUI.AcpLabel TrkSysDigitalPreambleLength_A8722Comp;

		// Token: 0x04000786 RID: 1926
		internal global::AcpUI.AcpCustomViewCheckBox CVBtnTrkSysDigitalDigitalModulatorType_A7858;

		// Token: 0x04000787 RID: 1927
		internal global::AcpUI.AcpLabel LblTrkSysDigitalDigitalModulatorType_A7858;

		// Token: 0x04000788 RID: 1928
		internal global::AcpUI.AcpComboBox TrkSysDigitalDigitalModulatorType_A7858;

		// Token: 0x04000789 RID: 1929
		internal global::AcpUI.AcpRtdButton RTDBtnTrkSysDigitalDigitalModulatorType_A7858;

		// Token: 0x0400078A RID: 1930
		internal global::AcpUI.AcpCopyButton CpyBtnTrkSysDigitalDigitalModulatorType_A7858;

		// Token: 0x0400078B RID: 1931
		internal global::AcpUI.AcpLabel TrkSysDigitalDigitalModulatorType_A7858Comp;

		// Token: 0x0400078C RID: 1932
		internal global::AcpUI.AcpCustomViewCheckBox CVBtnTrkSysDigitalF2TDMAFrameSyncBERThreshold_A1396;

		// Token: 0x0400078D RID: 1933
		internal global::AcpUI.AcpLabel LblTrkSysDigitalF2TDMAFrameSyncBERThreshold_A1396;

		// Token: 0x0400078E RID: 1934
		internal global::AcpUI.AcpTextBoxSpinner TrkSysDigitalF2TDMAFrameSyncBERThreshold_A1396;

		// Token: 0x0400078F RID: 1935
		internal global::AcpUI.AcpRtdButton RTDBtnTrkSysDigitalF2TDMAFrameSyncBERThreshold_A1396;

		// Token: 0x04000790 RID: 1936
		internal global::AcpUI.AcpCopyButton CpyBtnTrkSysDigitalF2TDMAFrameSyncBERThreshold_A1396;

		// Token: 0x04000791 RID: 1937
		internal global::AcpUI.AcpLabel TrkSysDigitalF2TDMAFrameSyncBERThreshold_A1396Comp;

		// Token: 0x04000792 RID: 1938
		internal global::AcpUI.AcpCustomViewCheckBox CVBtnTrkSysDigitalFDMAFrameSyncNIDBERThreshold_A8159;

		// Token: 0x04000793 RID: 1939
		internal global::AcpUI.AcpLabel LblTrkSysDigitalFDMAFrameSyncNIDBERThreshold_A8159;

		// Token: 0x04000794 RID: 1940
		internal global::AcpUI.AcpTextBoxSpinner TrkSysDigitalFDMAFrameSyncNIDBERThreshold_A8159;

		// Token: 0x04000795 RID: 1941
		internal global::AcpUI.AcpRtdButton RTDBtnTrkSysDigitalFDMAFrameSyncNIDBERThreshold_A8159;

		// Token: 0x04000796 RID: 1942
		internal global::AcpUI.AcpCopyButton CpyBtnTrkSysDigitalFDMAFrameSyncNIDBERThreshold_A8159;

		// Token: 0x04000797 RID: 1943
		internal global::AcpUI.AcpLabel TrkSysDigitalFDMAFrameSyncNIDBERThreshold_A8159Comp;

		// Token: 0x04000798 RID: 1944
		internal global::AcpUI.AcpExpander ExpanderTrunkingSystemSecureMultikey;

		// Token: 0x04000799 RID: 1945
		internal global::AcpUI.AcpGroupBox GrpBoxExpanderTrunkingSystemSecureMultikeyPseudo0;

		// Token: 0x0400079A RID: 1946
		internal global::AcpUI.AcpCustomViewCheckBox CVBtnTrkSysSecureMultikeyDESXLTxRxDefault_A7833;

		// Token: 0x0400079B RID: 1947
		internal global::AcpUI.AcpLabel LblTrkSysSecureMultikeyDESXLTxRxDefault_A7833;

		// Token: 0x0400079C RID: 1948
		internal global::AcpUI.AcpCheckBox TrkSysSecureMultikeyDESXLTxRxDefault_A7833;

		// Token: 0x0400079D RID: 1949
		internal global::AcpUI.AcpRtdButton RTDBtnTrkSysSecureMultikeyDESXLTxRxDefault_A7833;

		// Token: 0x0400079E RID: 1950
		internal global::AcpUI.AcpCopyButton CpyBtnTrkSysSecureMultikeyDESXLTxRxDefault_A7833;

		// Token: 0x0400079F RID: 1951
		internal global::AcpUI.AcpCheckBox TrkSysSecureMultikeyDESXLTxRxDefault_A7833Comp;

		// Token: 0x040007A0 RID: 1952
		internal global::AcpUI.AcpGroupBox GrpBoxExpanderTrunkingSystemSecureMultikeyOTAR;

		// Token: 0x040007A1 RID: 1953
		internal global::AcpUI.AcpCustomViewCheckBox CVBtnTrkSysSecureMultikeyASTROOTAR_A7494;

		// Token: 0x040007A2 RID: 1954
		internal global::AcpUI.AcpLabel LblTrkSysSecureMultikeyASTROOTAR_A7494;

		// Token: 0x040007A3 RID: 1955
		internal global::AcpUI.AcpCheckBox TrkSysSecureMultikeyASTROOTAR_A7494;

		// Token: 0x040007A4 RID: 1956
		internal global::AcpUI.AcpRtdButton RTDBtnTrkSysSecureMultikeyASTROOTAR_A7494;

		// Token: 0x040007A5 RID: 1957
		internal global::AcpUI.AcpCopyButton CpyBtnTrkSysSecureMultikeyASTROOTAR_A7494;

		// Token: 0x040007A6 RID: 1958
		internal global::AcpUI.AcpCheckBox TrkSysSecureMultikeyASTROOTAR_A7494Comp;

		// Token: 0x040007A7 RID: 1959
		internal global::AcpUI.AcpCustomViewCheckBox CVBtnTrkSysSecureMultikeyOTARTx_A8676;

		// Token: 0x040007A8 RID: 1960
		internal global::AcpUI.AcpLabel LblTrkSysSecureMultikeyOTARTx_A8676;

		// Token: 0x040007A9 RID: 1961
		internal global::AcpUI.AcpCheckBox TrkSysSecureMultikeyOTARTx_A8676;

		// Token: 0x040007AA RID: 1962
		internal global::AcpUI.AcpRtdButton RTDBtnTrkSysSecureMultikeyOTARTx_A8676;

		// Token: 0x040007AB RID: 1963
		internal global::AcpUI.AcpCopyButton CpyBtnTrkSysSecureMultikeyOTARTx_A8676;

		// Token: 0x040007AC RID: 1964
		internal global::AcpUI.AcpCheckBox TrkSysSecureMultikeyOTARTx_A8676Comp;

		// Token: 0x040007AD RID: 1965
		internal global::AcpUI.AcpCustomViewCheckBox CVBtnTrkSysSecureMultikeyKMFProfileIndex_A8382;

		// Token: 0x040007AE RID: 1966
		internal global::AcpUI.AcpLabel LblTrkSysSecureMultikeyKMFProfileIndex_A8382;

		// Token: 0x040007AF RID: 1967
		internal global::AcpUI.AcpComboBox TrkSysSecureMultikeyKMFProfileIndex_A8382;

		// Token: 0x040007B0 RID: 1968
		internal global::AcpUI.AcpRtdButton RTDBtnTrkSysSecureMultikeyKMFProfileIndex_A8382;

		// Token: 0x040007B1 RID: 1969
		internal global::AcpUI.AcpCopyButton CpyBtnTrkSysSecureMultikeyKMFProfileIndex_A8382;

		// Token: 0x040007B2 RID: 1970
		internal global::AcpUI.AcpLabel TrkSysSecureMultikeyKMFProfileIndex_A8382Comp;

		// Token: 0x040007B3 RID: 1971
		internal global::AcpUI.AcpGroupBox GrpBoxExpanderTrunkingSystemSecureMultikeyPseudo1;

		// Token: 0x040007B4 RID: 1972
		internal global::AcpUI.AcpCustomViewCheckBox CVBtnTrkSysSecureMultikeyPatchKeySelect_A8694;

		// Token: 0x040007B5 RID: 1973
		internal global::AcpUI.AcpLabel LblTrkSysSecureMultikeyPatchKeySelect_A8694;

		// Token: 0x040007B6 RID: 1974
		internal global::AcpUI.AcpComboBox TrkSysSecureMultikeyPatchKeySelect_A8694;

		// Token: 0x040007B7 RID: 1975
		internal global::AcpUI.AcpRtdButton RTDBtnTrkSysSecureMultikeyPatchKeySelect_A8694;

		// Token: 0x040007B8 RID: 1976
		internal global::AcpUI.AcpCopyButton CpyBtnTrkSysSecureMultikeyPatchKeySelect_A8694;

		// Token: 0x040007B9 RID: 1977
		internal global::AcpUI.AcpLabel TrkSysSecureMultikeyPatchKeySelect_A8694Comp;

		// Token: 0x040007BA RID: 1978
		internal global::AcpUI.AcpGroupBox GrpBoxExpanderTrunkingSystemSecureMultikeyFailsoft;

		// Token: 0x040007BB RID: 1979
		internal global::AcpUI.AcpCustomViewCheckBox CVBtnTrkSysSecureMultikeyFailsoftSecureClearStrapping_43479;

		// Token: 0x040007BC RID: 1980
		internal global::AcpUI.AcpLabel LblTrkSysSecureMultikeyFailsoftSecureClearStrapping_43479;

		// Token: 0x040007BD RID: 1981
		internal global::AcpUI.AcpComboBox TrkSysSecureMultikeyFailsoftSecureClearStrapping_43479;

		// Token: 0x040007BE RID: 1982
		internal global::AcpUI.AcpRtdButton RTDBtnTrkSysSecureMultikeyFailsoftSecureClearStrapping_43479;

		// Token: 0x040007BF RID: 1983
		internal global::AcpUI.AcpCopyButton CpyBtnTrkSysSecureMultikeyFailsoftSecureClearStrapping_43479;

		// Token: 0x040007C0 RID: 1984
		internal global::AcpUI.AcpLabel TrkSysSecureMultikeyFailsoftSecureClearStrapping_43479Comp;

		// Token: 0x040007C1 RID: 1985
		internal global::AcpUI.AcpCustomViewCheckBox CVBtnTrkSysSecureMultikeyFailsoftKeySelect_A8012;

		// Token: 0x040007C2 RID: 1986
		internal global::AcpUI.AcpLabel LblTrkSysSecureMultikeyFailsoftKeySelect_A8012;

		// Token: 0x040007C3 RID: 1987
		internal global::AcpUI.AcpComboBox TrkSysSecureMultikeyFailsoftKeySelect_A8012;

		// Token: 0x040007C4 RID: 1988
		internal global::AcpUI.AcpRtdButton RTDBtnTrkSysSecureMultikeyFailsoftKeySelect_A8012;

		// Token: 0x040007C5 RID: 1989
		internal global::AcpUI.AcpCopyButton CpyBtnTrkSysSecureMultikeyFailsoftKeySelect_A8012;

		// Token: 0x040007C6 RID: 1990
		internal global::AcpUI.AcpLabel TrkSysSecureMultikeyFailsoftKeySelect_A8012Comp;

		// Token: 0x040007C7 RID: 1991
		internal global::AcpUI.AcpGroupBox GrpBoxExpanderTrunkingSystemSecureMultikeyPrivateCall;

		// Token: 0x040007C8 RID: 1992
		internal global::AcpUI.AcpCustomViewCheckBox CVBtnTrkSysSecureMultikeyPrivateCallSecureClearStrapping_43477;

		// Token: 0x040007C9 RID: 1993
		internal global::AcpUI.AcpLabel LblTrkSysSecureMultikeyPrivateCallSecureClearStrapping_43477;

		// Token: 0x040007CA RID: 1994
		internal global::AcpUI.AcpComboBox TrkSysSecureMultikeyPrivateCallSecureClearStrapping_43477;

		// Token: 0x040007CB RID: 1995
		internal global::AcpUI.AcpRtdButton RTDBtnTrkSysSecureMultikeyPrivateCallSecureClearStrapping_43477;

		// Token: 0x040007CC RID: 1996
		internal global::AcpUI.AcpCopyButton CpyBtnTrkSysSecureMultikeyPrivateCallSecureClearStrapping_43477;

		// Token: 0x040007CD RID: 1997
		internal global::AcpUI.AcpLabel TrkSysSecureMultikeyPrivateCallSecureClearStrapping_43477Comp;

		// Token: 0x040007CE RID: 1998
		internal global::AcpUI.AcpCustomViewCheckBox CVBtnTrkSysSecureMultikeyPrivateCallKeySelect_A8757;

		// Token: 0x040007CF RID: 1999
		internal global::AcpUI.AcpLabel LblTrkSysSecureMultikeyPrivateCallKeySelect_A8757;

		// Token: 0x040007D0 RID: 2000
		internal global::AcpUI.AcpComboBox TrkSysSecureMultikeyPrivateCallKeySelect_A8757;

		// Token: 0x040007D1 RID: 2001
		internal global::AcpUI.AcpRtdButton RTDBtnTrkSysSecureMultikeyPrivateCallKeySelect_A8757;

		// Token: 0x040007D2 RID: 2002
		internal global::AcpUI.AcpCopyButton CpyBtnTrkSysSecureMultikeyPrivateCallKeySelect_A8757;

		// Token: 0x040007D3 RID: 2003
		internal global::AcpUI.AcpLabel TrkSysSecureMultikeyPrivateCallKeySelect_A8757Comp;

		// Token: 0x040007D4 RID: 2004
		internal global::AcpUI.AcpGroupBox GrpBoxExpanderTrunkingSystemSecureMultikeyInterconnect;

		// Token: 0x040007D5 RID: 2005
		internal global::AcpUI.AcpCustomViewCheckBox CVBtnTrkSysSecureMultikeyInterconnectSecureClearStrapping_43478;

		// Token: 0x040007D6 RID: 2006
		internal global::AcpUI.AcpLabel LblTrkSysSecureMultikeyInterconnectSecureClearStrapping_43478;

		// Token: 0x040007D7 RID: 2007
		internal global::AcpUI.AcpComboBox TrkSysSecureMultikeyInterconnectSecureClearStrapping_43478;

		// Token: 0x040007D8 RID: 2008
		internal global::AcpUI.AcpRtdButton RTDBtnTrkSysSecureMultikeyInterconnectSecureClearStrapping_43478;

		// Token: 0x040007D9 RID: 2009
		internal global::AcpUI.AcpCopyButton CpyBtnTrkSysSecureMultikeyInterconnectSecureClearStrapping_43478;

		// Token: 0x040007DA RID: 2010
		internal global::AcpUI.AcpLabel TrkSysSecureMultikeyInterconnectSecureClearStrapping_43478Comp;

		// Token: 0x040007DB RID: 2011
		internal global::AcpUI.AcpCustomViewCheckBox CVBtnTrkSysSecureMultikeyInterconnectKeySelect_A8298;

		// Token: 0x040007DC RID: 2012
		internal global::AcpUI.AcpLabel LblTrkSysSecureMultikeyInterconnectKeySelect_A8298;

		// Token: 0x040007DD RID: 2013
		internal global::AcpUI.AcpComboBox TrkSysSecureMultikeyInterconnectKeySelect_A8298;

		// Token: 0x040007DE RID: 2014
		internal global::AcpUI.AcpRtdButton RTDBtnTrkSysSecureMultikeyInterconnectKeySelect_A8298;

		// Token: 0x040007DF RID: 2015
		internal global::AcpUI.AcpCopyButton CpyBtnTrkSysSecureMultikeyInterconnectKeySelect_A8298;

		// Token: 0x040007E0 RID: 2016
		internal global::AcpUI.AcpLabel TrkSysSecureMultikeyInterconnectKeySelect_A8298Comp;

		// Token: 0x040007E1 RID: 2017
		internal global::AcpUI.AcpGroupBox GrpBoxExpanderTrunkingSystemSecureMultikeyPseudo4;

		// Token: 0x040007E2 RID: 2018
		internal global::AcpUI.AcpCustomViewCheckBox CVBtnTrkSysSecureMultikeySystemWideKeySelect_A9253;

		// Token: 0x040007E3 RID: 2019
		internal global::AcpUI.AcpLabel LblTrkSysSecureMultikeySystemWideKeySelect_A9253;

		// Token: 0x040007E4 RID: 2020
		internal global::AcpUI.AcpComboBox TrkSysSecureMultikeySystemWideKeySelect_A9253;

		// Token: 0x040007E5 RID: 2021
		internal global::AcpUI.AcpRtdButton RTDBtnTrkSysSecureMultikeySystemWideKeySelect_A9253;

		// Token: 0x040007E6 RID: 2022
		internal global::AcpUI.AcpCopyButton CpyBtnTrkSysSecureMultikeySystemWideKeySelect_A9253;

		// Token: 0x040007E7 RID: 2023
		internal global::AcpUI.AcpLabel TrkSysSecureMultikeySystemWideKeySelect_A9253Comp;

		// Token: 0x040007E8 RID: 2024
		internal global::AcpUI.AcpGroupBox GrpBoxExpanderTrunkingSystemSecureMultikeyDynamicRegrouping;

		// Token: 0x040007E9 RID: 2025
		internal global::AcpUI.AcpCustomViewCheckBox CVBtnTrkSysSecureMultikeyDynamicSecureClearStrapping_43489;

		// Token: 0x040007EA RID: 2026
		internal global::AcpUI.AcpLabel LblTrkSysSecureMultikeyDynamicSecureClearStrapping_43489;

		// Token: 0x040007EB RID: 2027
		internal global::AcpUI.AcpComboBox TrkSysSecureMultikeyDynamicSecureClearStrapping_43489;

		// Token: 0x040007EC RID: 2028
		internal global::AcpUI.AcpRtdButton RTDBtnTrkSysSecureMultikeyDynamicSecureClearStrapping_43489;

		// Token: 0x040007ED RID: 2029
		internal global::AcpUI.AcpCopyButton CpyBtnTrkSysSecureMultikeyDynamicSecureClearStrapping_43489;

		// Token: 0x040007EE RID: 2030
		internal global::AcpUI.AcpLabel TrkSysSecureMultikeyDynamicSecureClearStrapping_43489Comp;

		// Token: 0x040007EF RID: 2031
		internal global::AcpUI.AcpCustomViewCheckBox CVBtnTrkSysSecureMultikeyDynamicTalkgroupKeySelect_A7918;

		// Token: 0x040007F0 RID: 2032
		internal global::AcpUI.AcpLabel LblTrkSysSecureMultikeyDynamicTalkgroupKeySelect_A7918;

		// Token: 0x040007F1 RID: 2033
		internal global::AcpUI.AcpComboBox TrkSysSecureMultikeyDynamicTalkgroupKeySelect_A7918;

		// Token: 0x040007F2 RID: 2034
		internal global::AcpUI.AcpRtdButton RTDBtnTrkSysSecureMultikeyDynamicTalkgroupKeySelect_A7918;

		// Token: 0x040007F3 RID: 2035
		internal global::AcpUI.AcpCopyButton CpyBtnTrkSysSecureMultikeyDynamicTalkgroupKeySelect_A7918;

		// Token: 0x040007F4 RID: 2036
		internal global::AcpUI.AcpLabel TrkSysSecureMultikeyDynamicTalkgroupKeySelect_A7918Comp;

		// Token: 0x040007F5 RID: 2037
		internal global::AcpUI.AcpCustomViewCheckBox CVBtnTrkSysSecureMultikeyDynamicAGKeySelect_A7914;

		// Token: 0x040007F6 RID: 2038
		internal global::AcpUI.AcpLabel LblTrkSysSecureMultikeyDynamicAGKeySelect_A7914;

		// Token: 0x040007F7 RID: 2039
		internal global::AcpUI.AcpComboBox TrkSysSecureMultikeyDynamicAGKeySelect_A7914;

		// Token: 0x040007F8 RID: 2040
		internal global::AcpUI.AcpRtdButton RTDBtnTrkSysSecureMultikeyDynamicAGKeySelect_A7914;

		// Token: 0x040007F9 RID: 2041
		internal global::AcpUI.AcpCopyButton CpyBtnTrkSysSecureMultikeyDynamicAGKeySelect_A7914;

		// Token: 0x040007FA RID: 2042
		internal global::AcpUI.AcpLabel TrkSysSecureMultikeyDynamicAGKeySelect_A7914Comp;

		// Token: 0x040007FB RID: 2043
		internal global::AcpUI.AcpGroupBox GrpBoxExpanderTrunkingSystemSecureMultikeyVirtualPartner;

		// Token: 0x040007FC RID: 2044
		internal global::AcpUI.AcpCustomViewCheckBox CVBtnTrkSysSecureMultikeyVirtualPartnerSecureClearStrapping_A43670;

		// Token: 0x040007FD RID: 2045
		internal global::AcpUI.AcpLabel LblTrkSysSecureMultikeyVirtualPartnerSecureClearStrapping_A43670;

		// Token: 0x040007FE RID: 2046
		internal global::AcpUI.AcpComboBox TrkSysSecureMultikeyVirtualPartnerSecureClearStrapping_A43670;

		// Token: 0x040007FF RID: 2047
		internal global::AcpUI.AcpRtdButton RTDBtnTrkSysSecureMultikeyVirtualPartnerSecureClearStrapping_A43670;

		// Token: 0x04000800 RID: 2048
		internal global::AcpUI.AcpCopyButton CpyBtnTrkSysSecureMultikeyVirtualPartnerSecureClearStrapping_A43670;

		// Token: 0x04000801 RID: 2049
		internal global::AcpUI.AcpLabel TrkSysSecureMultikeyVirtualPartnerSecureClearStrapping_A43670Comp;

		// Token: 0x04000802 RID: 2050
		internal global::AcpUI.AcpCustomViewCheckBox CVBtnTrkSysSecureMultikeyVirtualPartnerKeySelect_A43669;

		// Token: 0x04000803 RID: 2051
		internal global::AcpUI.AcpLabel LblTrkSysSecureMultikeyVirtualPartnerKeySelect_A43669;

		// Token: 0x04000804 RID: 2052
		internal global::AcpUI.AcpComboBox TrkSysSecureMultikeyVirtualPartnerKeySelect_A43669;

		// Token: 0x04000805 RID: 2053
		internal global::AcpUI.AcpRtdButton RTDBtnTrkSysSecureMultikeyVirtualPartnerKeySelect_A43669;

		// Token: 0x04000806 RID: 2054
		internal global::AcpUI.AcpCopyButton CpyBtnTrkSysSecureMultikeyVirtualPartnerKeySelect_A43669;

		// Token: 0x04000807 RID: 2055
		internal global::AcpUI.AcpLabel TrkSysSecureMultikeyVirtualPartnerKeySelect_A43669Comp;

		// Token: 0x04000808 RID: 2056
		internal global::AcpUI.AcpGroupBox GrpBoxExpanderTrunkingSystemSecureMultikeyPseudo6;

		// Token: 0x04000809 RID: 2057
		internal global::AcpUI.AcpCustomViewCheckBox CVBtnTrkSysSecureMultikeyAutoKeyIDRx_A43185;

		// Token: 0x0400080A RID: 2058
		internal global::AcpUI.AcpLabel LblTrkSysSecureMultikeyAutoKeyIDRx_A43185;

		// Token: 0x0400080B RID: 2059
		internal global::AcpUI.AcpCheckBox TrkSysSecureMultikeyAutoKeyIDRx_A43185;

		// Token: 0x0400080C RID: 2060
		internal global::AcpUI.AcpRtdButton RTDBtnTrkSysSecureMultikeyAutoKeyIDRx_A43185;

		// Token: 0x0400080D RID: 2061
		internal global::AcpUI.AcpCopyButton CpyBtnTrkSysSecureMultikeyAutoKeyIDRx_A43185;

		// Token: 0x0400080E RID: 2062
		internal global::AcpUI.AcpCheckBox TrkSysSecureMultikeyAutoKeyIDRx_A43185Comp;

		// Token: 0x0400080F RID: 2063
		internal global::AcpUI.AcpExpander ExpanderTrunkingSystemLabtool;

		// Token: 0x04000810 RID: 2064
		internal global::AcpUI.AcpGroupBox GrpBoxExpanderTrunkingSystemLabtoolPseudo0;

		// Token: 0x04000811 RID: 2065
		internal global::AcpUI.AcpCustomViewCheckBox CVBtnTrkSysLabtoolTrunkingSystemAPCOChannelIdentifierListItemID_A19965;

		// Token: 0x04000812 RID: 2066
		internal global::AcpUI.AcpLabel LblTrkSysLabtoolTrunkingSystemAPCOChannelIdentifierListItemID_A19965;

		// Token: 0x04000813 RID: 2067
		internal global::AcpUI.AcpComboBox TrkSysLabtoolTrunkingSystemAPCOChannelIdentifierListItemID_A19965;

		// Token: 0x04000814 RID: 2068
		internal global::AcpUI.AcpRtdButton RTDBtnTrkSysLabtoolTrunkingSystemAPCOChannelIdentifierListItemID_A19965;

		// Token: 0x04000815 RID: 2069
		internal global::AcpUI.AcpCopyButton CpyBtnTrkSysLabtoolTrunkingSystemAPCOChannelIdentifierListItemID_A19965;

		// Token: 0x04000816 RID: 2070
		internal global::AcpUI.AcpLabel TrkSysLabtoolTrunkingSystemAPCOChannelIdentifierListItemID_A19965Comp;

		// Token: 0x04000817 RID: 2071
		internal global::AcpUI.AcpCustomViewCheckBox CVBtnTrkSysLabtoolTrunkingSystemOneTouchListItemID_A22633;

		// Token: 0x04000818 RID: 2072
		internal global::AcpUI.AcpLabel LblTrkSysLabtoolTrunkingSystemOneTouchListItemID_A22633;

		// Token: 0x04000819 RID: 2073
		internal global::AcpUI.AcpComboBox TrkSysLabtoolTrunkingSystemOneTouchListItemID_A22633;

		// Token: 0x0400081A RID: 2074
		internal global::AcpUI.AcpRtdButton RTDBtnTrkSysLabtoolTrunkingSystemOneTouchListItemID_A22633;

		// Token: 0x0400081B RID: 2075
		internal global::AcpUI.AcpCopyButton CpyBtnTrkSysLabtoolTrunkingSystemOneTouchListItemID_A22633;

		// Token: 0x0400081C RID: 2076
		internal global::AcpUI.AcpLabel TrkSysLabtoolTrunkingSystemOneTouchListItemID_A22633Comp;

		// Token: 0x0400081D RID: 2077
		internal global::AcpUI.AcpCustomViewCheckBox CVBtnTrkSysLabtoolTrunkingSystemControlChannelListItemID_A19964;

		// Token: 0x0400081E RID: 2078
		internal global::AcpUI.AcpLabel LblTrkSysLabtoolTrunkingSystemControlChannelListItemID_A19964;

		// Token: 0x0400081F RID: 2079
		internal global::AcpUI.AcpComboBox TrkSysLabtoolTrunkingSystemControlChannelListItemID_A19964;

		// Token: 0x04000820 RID: 2080
		internal global::AcpUI.AcpRtdButton RTDBtnTrkSysLabtoolTrunkingSystemControlChannelListItemID_A19964;

		// Token: 0x04000821 RID: 2081
		internal global::AcpUI.AcpCopyButton CpyBtnTrkSysLabtoolTrunkingSystemControlChannelListItemID_A19964;

		// Token: 0x04000822 RID: 2082
		internal global::AcpUI.AcpLabel TrkSysLabtoolTrunkingSystemControlChannelListItemID_A19964Comp;

		// Token: 0x04000823 RID: 2083
		internal global::AcpUI.AcpCustomViewCheckBox CVBtnTrkSysLabtoolTrunkingSystemIIOBTChannelAssignmentListItemID_A19966;

		// Token: 0x04000824 RID: 2084
		internal global::AcpUI.AcpLabel LblTrkSysLabtoolTrunkingSystemIIOBTChannelAssignmentListItemID_A19966;

		// Token: 0x04000825 RID: 2085
		internal global::AcpUI.AcpComboBox TrkSysLabtoolTrunkingSystemIIOBTChannelAssignmentListItemID_A19966;

		// Token: 0x04000826 RID: 2086
		internal global::AcpUI.AcpRtdButton RTDBtnTrkSysLabtoolTrunkingSystemIIOBTChannelAssignmentListItemID_A19966;

		// Token: 0x04000827 RID: 2087
		internal global::AcpUI.AcpCopyButton CpyBtnTrkSysLabtoolTrunkingSystemIIOBTChannelAssignmentListItemID_A19966;

		// Token: 0x04000828 RID: 2088
		internal global::AcpUI.AcpLabel TrkSysLabtoolTrunkingSystemIIOBTChannelAssignmentListItemID_A19966Comp;

		// Token: 0x04000829 RID: 2089
		internal global::AcpUI.AcpCustomViewCheckBox CVBtnTrkSysLabtoolTrunkingSystemStatusAliasListItemID_A19967;

		// Token: 0x0400082A RID: 2090
		internal global::AcpUI.AcpLabel LblTrkSysLabtoolTrunkingSystemStatusAliasListItemID_A19967;

		// Token: 0x0400082B RID: 2091
		internal global::AcpUI.AcpComboBox TrkSysLabtoolTrunkingSystemStatusAliasListItemID_A19967;

		// Token: 0x0400082C RID: 2092
		internal global::AcpUI.AcpRtdButton RTDBtnTrkSysLabtoolTrunkingSystemStatusAliasListItemID_A19967;

		// Token: 0x0400082D RID: 2093
		internal global::AcpUI.AcpCopyButton CpyBtnTrkSysLabtoolTrunkingSystemStatusAliasListItemID_A19967;

		// Token: 0x0400082E RID: 2094
		internal global::AcpUI.AcpLabel TrkSysLabtoolTrunkingSystemStatusAliasListItemID_A19967Comp;

		// Token: 0x0400082F RID: 2095
		internal global::AcpUI.AcpCustomViewCheckBox CVBtnTrkSysLabtoolTrunkingSystemStatusAliasTextListItemID_A19968;

		// Token: 0x04000830 RID: 2096
		internal global::AcpUI.AcpLabel LblTrkSysLabtoolTrunkingSystemStatusAliasTextListItemID_A19968;

		// Token: 0x04000831 RID: 2097
		internal global::AcpUI.AcpComboBox TrkSysLabtoolTrunkingSystemStatusAliasTextListItemID_A19968;

		// Token: 0x04000832 RID: 2098
		internal global::AcpUI.AcpRtdButton RTDBtnTrkSysLabtoolTrunkingSystemStatusAliasTextListItemID_A19968;

		// Token: 0x04000833 RID: 2099
		internal global::AcpUI.AcpCopyButton CpyBtnTrkSysLabtoolTrunkingSystemStatusAliasTextListItemID_A19968;

		// Token: 0x04000834 RID: 2100
		internal global::AcpUI.AcpLabel TrkSysLabtoolTrunkingSystemStatusAliasTextListItemID_A19968Comp;

		// Token: 0x04000835 RID: 2101
		internal global::AcpUI.AcpCustomViewCheckBox CVBtnTrkSysLabtoolTrunkingSystemMessageAliasListItemID_A19969;

		// Token: 0x04000836 RID: 2102
		internal global::AcpUI.AcpLabel LblTrkSysLabtoolTrunkingSystemMessageAliasListItemID_A19969;

		// Token: 0x04000837 RID: 2103
		internal global::AcpUI.AcpComboBox TrkSysLabtoolTrunkingSystemMessageAliasListItemID_A19969;

		// Token: 0x04000838 RID: 2104
		internal global::AcpUI.AcpRtdButton RTDBtnTrkSysLabtoolTrunkingSystemMessageAliasListItemID_A19969;

		// Token: 0x04000839 RID: 2105
		internal global::AcpUI.AcpCopyButton CpyBtnTrkSysLabtoolTrunkingSystemMessageAliasListItemID_A19969;

		// Token: 0x0400083A RID: 2106
		internal global::AcpUI.AcpLabel TrkSysLabtoolTrunkingSystemMessageAliasListItemID_A19969Comp;

		// Token: 0x0400083B RID: 2107
		internal global::AcpUI.AcpCustomViewCheckBox CVBtnTrkSysLabtoolTrunkingSystemMessageAliasTextListItemID_A19970;

		// Token: 0x0400083C RID: 2108
		internal global::AcpUI.AcpLabel LblTrkSysLabtoolTrunkingSystemMessageAliasTextListItemID_A19970;

		// Token: 0x0400083D RID: 2109
		internal global::AcpUI.AcpComboBox TrkSysLabtoolTrunkingSystemMessageAliasTextListItemID_A19970;

		// Token: 0x0400083E RID: 2110
		internal global::AcpUI.AcpRtdButton RTDBtnTrkSysLabtoolTrunkingSystemMessageAliasTextListItemID_A19970;

		// Token: 0x0400083F RID: 2111
		internal global::AcpUI.AcpCopyButton CpyBtnTrkSysLabtoolTrunkingSystemMessageAliasTextListItemID_A19970;

		// Token: 0x04000840 RID: 2112
		internal global::AcpUI.AcpLabel TrkSysLabtoolTrunkingSystemMessageAliasTextListItemID_A19970Comp;

		// Token: 0x04000841 RID: 2113
		internal global::AcpUI.AcpCustomViewCheckBox CVBtnTrkSysLabtoolTrunkingSystemSiteAliasTextListItemID_A19972;

		// Token: 0x04000842 RID: 2114
		internal global::AcpUI.AcpLabel LblTrkSysLabtoolTrunkingSystemSiteAliasTextListItemID_A19972;

		// Token: 0x04000843 RID: 2115
		internal global::AcpUI.AcpComboBox TrkSysLabtoolTrunkingSystemSiteAliasTextListItemID_A19972;

		// Token: 0x04000844 RID: 2116
		internal global::AcpUI.AcpRtdButton RTDBtnTrkSysLabtoolTrunkingSystemSiteAliasTextListItemID_A19972;

		// Token: 0x04000845 RID: 2117
		internal global::AcpUI.AcpCopyButton CpyBtnTrkSysLabtoolTrunkingSystemSiteAliasTextListItemID_A19972;

		// Token: 0x04000846 RID: 2118
		internal global::AcpUI.AcpLabel TrkSysLabtoolTrunkingSystemSiteAliasTextListItemID_A19972Comp;

		// Token: 0x04000847 RID: 2119
		internal global::AcpUI.AcpCustomViewCheckBox CVBtnTrkSysLabtoolTrunkingSystemSiteAliasListItemID_A19971;

		// Token: 0x04000848 RID: 2120
		internal global::AcpUI.AcpLabel LblTrkSysLabtoolTrunkingSystemSiteAliasListItemID_A19971;

		// Token: 0x04000849 RID: 2121
		internal global::AcpUI.AcpComboBox TrkSysLabtoolTrunkingSystemSiteAliasListItemID_A19971;

		// Token: 0x0400084A RID: 2122
		internal global::AcpUI.AcpRtdButton RTDBtnTrkSysLabtoolTrunkingSystemSiteAliasListItemID_A19971;

		// Token: 0x0400084B RID: 2123
		internal global::AcpUI.AcpCopyButton CpyBtnTrkSysLabtoolTrunkingSystemSiteAliasListItemID_A19971;

		// Token: 0x0400084C RID: 2124
		internal global::AcpUI.AcpLabel TrkSysLabtoolTrunkingSystemSiteAliasListItemID_A19971Comp;

		// Token: 0x0400084D RID: 2125
		internal global::AcpUI.AcpExpander ExpanderTrunkingSystemBroadband;

		// Token: 0x0400084E RID: 2126
		private bool b;
	}
}
