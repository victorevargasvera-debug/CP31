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

namespace Motorola.MackinawCPS.CoreFeatures.TrunkingPersonality
{
	// Token: 0x020000D1 RID: 209
	public class PageTrunkingPersonality : global::AcpUI.AcpPageFeature, global::System.Windows.Markup.IComponentConnector, global::System.Windows.Markup.IStyleConnector
	{
		// Token: 0x06001E29 RID: 7721 RVA: 0x001DBEE4 File Offset: 0x001DA0E4
		public PageTrunkingPersonality()
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

		// Token: 0x06001E2A RID: 7722 RVA: 0x001DBF1C File Offset: 0x001DA11C
		public override void OnLoaded(object sender, global::System.Windows.RoutedEventArgs e)
		{
			short num = (short)1135804416;
			int num2 = (int)num;
			switch (num2)
			{
			default:
				num = (short)1279131652;
				num2 = (int)((global::System.IntPtr)num);
				for (;;)
				{
					object obj;
					global::AcpUI.AcpExpander acpExpander;
					global::System.Collections.IEnumerator enumerator;
					switch (num2)
					{
					case 0:
						goto IL_314;
					case 1:
						goto IL_3C5;
					case 2:
						if (obj != null)
						{
							num = (short)1829830656;
							short num3 = num;
							num = (short)816447494;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_282;
					case 3:
						if (obj != null)
						{
							num = (short)1613037577;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_3C5;
					case 4:
						switch (0)
						{
						case 0:
							goto IL_6C;
						}
						continue;
					case 5:
						try
						{
							num = (short)1696858113;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								switch (num2)
								{
								case 0:
									base.Expanders.Add(acpExpander);
									num = (short)7143426;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 1:
									switch (0)
									{
									case 0:
										goto IL_FE;
									}
									continue;
								case 3:
									if (!enumerator.MoveNext())
									{
										num = (short)436076550;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									acpExpander = (((global::System.Windows.UIElement)enumerator.Current) as global::AcpUI.AcpExpander);
									num = (short)1844314117;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 4:
									goto IL_1B8;
								case 5:
									if (acpExpander != null)
									{
										num = (short)637403136;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									break;
								case 6:
									num = (short)540213252;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								IL_140:
								num = (short)698613763;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								IL_FE:
								goto IL_140;
							}
							IL_1B8:
							goto IL_2EC;
						}
						finally
						{
							for (;;)
							{
								IL_1BD:
								switch (0)
								{
								case 0:
									goto IL_1DA;
								}
								global::System.IDisposable disposable;
								for (;;)
								{
									IL_1C7:
									switch (num2)
									{
									case 0:
										goto IL_27F;
									case 1:
									{
										if (disposable == null)
										{
											goto IL_281;
										}
										num = (short)1688950154;
										short num4 = num;
										num = (short)1502238090;
										switch ((num4 == num) ? 1 : 0)
										{
										case 0:
										case 2:
											goto IL_1BD;
										default:
											num = (short)1803026432;
											if (num != 0)
											{
											}
											num = (short)1956577282;
											num2 = (int)((global::System.IntPtr)num);
											continue;
										}
										break;
									}
									case 2:
										disposable.Dispose();
										num = (short)1562509312;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									break;
								}
								IL_1DA:
								disposable = (enumerator as global::System.IDisposable);
								num = (short)1765998593;
								num2 = (int)((global::System.IntPtr)num);
								goto IL_1C7;
							}
							IL_27F:
							IL_281:;
						}
						goto IL_282;
						IL_2EC:
						base.OnLoaded(sender, e);
						this.a = true;
						num = (short)635568128;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 6:
					{
						global::System.Windows.Data.CollectionView collectionView = (global::System.Windows.Data.CollectionView)global::System.Windows.Data.CollectionViewSource.GetDefaultView(obj);
						this.RecNavToolbarExpanderTrunkingPersonalityPreferredSitesTable.MyDataPresenter = this.ExpanderTrunkingPersonalityPreferredSitesTable;
						num = (short)1290469383;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 7:
						goto IL_282;
					case 8:
						num = (short)2008809473;
						if (num != 0)
						{
						}
						this.RecNavToolbarPageTrunkingPersonality.ChildToolbars.Add(this.RecNavToolbarExpanderTrunkingPersonalityTalkgroupTable);
						this.RecNavToolbarPageTrunkingPersonality.ChildToolbars.Add(this.RecNavToolbarExpanderTrunkingPersonalityPreferredSitesTable);
						obj = null;
						obj = this.RecNavToolbarExpanderTrunkingPersonalityTalkgroupTable.MyRecordsetDataSource;
						num = (short)253296643;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 9:
					{
						global::System.Windows.Data.CollectionView collectionView2 = (global::System.Windows.Data.CollectionView)global::System.Windows.Data.CollectionViewSource.GetDefaultView(obj);
						this.RecNavToolbarExpanderTrunkingPersonalityTalkgroupTable.MyDataPresenter = this.ExpanderTrunkingPersonalityTalkgroupTable;
						num = (short)1692794881;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					}
					IL_6C:
					if (!this.a)
					{
						num = (short)1740898312;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					break;
					IL_282:
					acpExpander = null;
					enumerator = this.MyStackPanel.Children.GetEnumerator();
					num = (short)406650885;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_3C5:
					obj = this.RecNavToolbarExpanderTrunkingPersonalityPreferredSitesTable.MyRecordsetDataSource;
					num = (short)1982070786;
					num2 = (int)((global::System.IntPtr)num);
				}
				IL_314:
				this.MyStackPanel.Children[0].Focus();
				return;
			}
		}

		// Token: 0x06001E2B RID: 7723 RVA: 0x001DC390 File Offset: 0x001DA590
		public override void OnUnloaded(object sender, global::System.Windows.RoutedEventArgs e)
		{
			switch (0)
			{
			case 0:
				goto IL_BB;
			}
			short num;
			int num4;
			for (;;)
			{
				IL_0A:
				num = (short)253362177;
				if (num != 0)
				{
				}
				num = (short)2046492672;
				short num2 = num;
				num = (short)1792441762;
				short num3 = num;
				num = (short)1217297826;
				switch ((num3 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					break;
				default:
					num = (short)1782448128;
					if (num != 0)
					{
					}
					switch (num4)
					{
					case 0:
						return;
					case 1:
						base.OnUnloaded(sender, e);
						this.a = false;
						num = (short)1877475328;
						num4 = (int)((global::System.IntPtr)num);
						continue;
					case 2:
						if (this.a)
						{
							goto IL_13A;
						}
						return;
					}
					goto IL_BB;
				}
				IL_13A:
				num = (short)1634926593;
				num4 = (int)((global::System.IntPtr)num);
			}
			return;
			IL_BB:
			this.RecNavToolbarPageTrunkingPersonality.DataContext = null;
			this.RecNavToolbarPageTrunkingPersonality.DataContext = null;
			this.RecNavToolbarExpanderTrunkingPersonalityTalkgroupTable.DataContext = null;
			this.RecNavToolbarExpanderTrunkingPersonalityPreferredSitesTable.DataContext = null;
			this.RecNavToolbarPageTrunkingPersonality.MyDataPresenter = null;
			this.RecNavToolbarPageTrunkingPersonality.MyDataPresenter = null;
			this.RecNavToolbarExpanderTrunkingPersonalityTalkgroupTable.MyDataPresenter = null;
			this.RecNavToolbarExpanderTrunkingPersonalityPreferredSitesTable.MyDataPresenter = null;
			num = (short)1503068162;
			num4 = (int)((global::System.IntPtr)num);
			goto IL_0A;
		}

		// Token: 0x06001E2C RID: 7724 RVA: 0x001DC51C File Offset: 0x001DA71C
		public override void SetDataContext()
		{
			short num = (short)790691848;
			int num2 = (int)((global::System.IntPtr)num);
			object feature;
			for (;;)
			{
				num = (short)1326841856;
				short num3 = num;
				switch (num2)
				{
				case 0:
					goto IL_A6;
				case 1:
					base.DataContext = global::AcpCommonLib.AppInfoManager.DefaultDocument.GetFeature(2072);
					num = (short)801374208;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 2:
					goto IL_14E;
				case 3:
					goto IL_A6;
				case 4:
					goto IL_F3;
				case 5:
					if (global::AcpCommonLib.AppInfoManager.AppMode == global::AcpCommonLib.ApplicationMode.CodeplugComparisonMode)
					{
						num = (short)1556152324;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					((global::AcpUILib.IAcpRecNavToolbar)this.RecNavToolbarPageTrunkingPersonality).MySecondaryRecordsetDataSource = null;
					num = (short)505282562;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 6:
					goto IL_238;
				case 7:
				{
					if (feature == null)
					{
						return;
					}
					num = (short)373536918;
					short num4 = num;
					num = (short)347519126;
					switch ((num4 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_F3;
					default:
						num = (short)1001914369;
						if (num != 0)
						{
						}
						num = (short)1959198720;
						if (num != 0)
						{
						}
						num = (short)1313669126;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					break;
				}
				case 8:
					switch (0)
					{
					case 0:
						goto IL_72;
					}
					continue;
				}
				IL_72:
				if (global::AcpCommonLib.AppInfoManager.AppMode == global::AcpCommonLib.ApplicationMode.CustomViewConfigurationMode)
				{
					num = (short)1007353857;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				base.DataContext = global::AcpCommonLib.FeatureManager.GetFeature(2072);
				num = (short)1707868163;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_A6:
				this.RecNavToolbarPageTrunkingPersonality.DataContext = (global::AcpCommonLib.IAcpRecordset)base.DataContext;
				num = (short)1014693893;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_F3:
				feature = global::AcpCommonLib.AppInfoManager.ComparatorDocument.GetFeature(2072);
				num = (short)364118023;
				num2 = (int)((global::System.IntPtr)num);
			}
			IL_14E:
			return;
			IL_238:
			((global::AcpUILib.IAcpRecNavToolbar)this.RecNavToolbarPageTrunkingPersonality).MySecondaryRecordsetDataSource = (global::AcpCommonLib.IAcpRecordset)feature;
		}

		// Token: 0x06001E2D RID: 7725 RVA: 0x001DC768 File Offset: 0x001DA968
		private void OnModeClick(object A_0, global::System.Windows.RoutedEventArgs A_1)
		{
			int a_ = 16;
			short num = (short)1709768704;
			switch (num)
			{
			default:
			{
				num = (short)172228647;
				int num2 = (int)((global::System.IntPtr)num);
				for (;;)
				{
					switch (num2)
					{
					case 0:
						if (((global::AcpUI.AcpRecNavToolbar)A_0).Name == global::AllFeatures.CodeplugGuid.b("菐뛒뛔駖룘귚觜냞軠迢蟤蛦鯨믪賬裮铰ꟲ蟴苶韸郺铼釾昀匂怄甆稈搊挌渎紐稒愔渖", a_))
						{
							num = (short)533069836;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_496;
					case 1:
						goto IL_57A;
					case 2:
					{
						((global::AcpUI.AcpRecNavToolbar)A_0).TableMode = false;
						object myRecordsetDataSource = this.RecNavToolbarExpanderTrunkingPersonalityTalkgroupTable.MyRecordsetDataSource;
						num = (short)933625888;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 3:
					{
						global::System.Windows.Data.CollectionView collectionView;
						if (collectionView.IsCurrentAfterLast)
						{
							num = (short)392101918;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						collectionView.MoveCurrentToFirst();
						num = (short)1501429765;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 4:
					{
						global::System.Windows.Data.CollectionView collectionView;
						global::Motorola.MackinawCPS.CoreFeatures.TrunkingPersonality.PreferredSitesInner preferredSitesInner;
						collectionView.MoveCurrentTo(preferredSitesInner);
						num = (short)1312751617;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 5:
						goto IL_551;
					case 6:
					{
						global::System.Windows.Data.CollectionView collectionView2;
						global::Motorola.MackinawCPS.CoreFeatures.TrunkingPersonality.TalkgroupInner talkgroupInner;
						collectionView2.MoveCurrentTo(talkgroupInner);
						num = (short)1499267100;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 7:
					{
						object myRecordsetDataSource2;
						if (myRecordsetDataSource2 != null)
						{
							num = (short)1732706325;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_713;
					}
					case 8:
						if (((global::AcpUI.AcpRecNavToolbar)A_0).Name == global::AllFeatures.CodeplugGuid.b("菐뛒뛔駖룘귚觜냞軠迢蟤蛦鯨껪闬鿮郰鷲釴鋶诸꿺迼諾漀栂氄椆済嬊栌紎成簒笔瘖甘爚検昞焠儢䀤䄦䰨太弬䨮唰怲尴䌶尸䠺椼帾⍀⽂⁄", a_))
						{
							num = (short)889454609;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_713;
					case 9:
						num = (short)539623424;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 10:
						goto IL_496;
					case 11:
						if (((global::AcpUI.AcpRecNavToolbar)A_0).TableMode)
						{
							num = (short)1648361485;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						((global::AcpUI.AcpRecNavToolbar)A_0).TableMode = true;
						num = (short)780992531;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 12:
					{
						global::AcpCommonLib.IAcpRecordset myRecordsetDataSource3 = this.RecNavToolbarPageTrunkingPersonality.MyRecordsetDataSource;
						num = (short)2033385510;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 13:
					{
						((global::AcpUI.AcpRecNavToolbar)A_0).TableMode = false;
						object myRecordsetDataSource2 = this.RecNavToolbarExpanderTrunkingPersonalityPreferredSitesTable.MyRecordsetDataSource;
						num = (short)1722810375;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 14:
						num = (short)875954179;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 15:
						goto IL_379;
					case 16:
					{
						object myRecordsetDataSource;
						global::System.Windows.Data.CollectionView collectionView2 = (global::System.Windows.Data.CollectionView)global::System.Windows.Data.CollectionViewSource.GetDefaultView(myRecordsetDataSource);
						global::Motorola.MackinawCPS.CoreFeatures.TrunkingPersonality.TalkgroupInner talkgroupInner = (global::Motorola.MackinawCPS.CoreFeatures.TrunkingPersonality.TalkgroupInner)collectionView2.CurrentItem;
						num = (short)312475684;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 17:
						num = (short)1589837835;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 18:
					{
						global::System.Windows.Data.CollectionView collectionView2;
						collectionView2.MoveCurrentToLast();
						num = (short)1204355097;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 19:
						goto IL_713;
					case 20:
					{
						global::System.Windows.Data.CollectionView collectionView;
						if (collectionView.Count > 0)
						{
							num = (short)448462862;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_2A8;
					}
					case 21:
					{
						object myRecordsetDataSource2;
						global::System.Windows.Data.CollectionView collectionView = (global::System.Windows.Data.CollectionView)global::System.Windows.Data.CollectionViewSource.GetDefaultView(myRecordsetDataSource2);
						global::Motorola.MackinawCPS.CoreFeatures.TrunkingPersonality.PreferredSitesInner preferredSitesInner = (global::Motorola.MackinawCPS.CoreFeatures.TrunkingPersonality.PreferredSitesInner)collectionView.CurrentItem;
						num = (short)760545317;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 22:
						goto IL_6BB;
					case 23:
						num = (short)2004877336;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 24:
					{
						global::System.Windows.Data.CollectionView collectionView2;
						if (collectionView2.IsCurrentAfterLast)
						{
							num = (short)1585840146;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						collectionView2.MoveCurrentToFirst();
						num = (short)508887073;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 25:
						goto IL_2B4;
					case 26:
						if (((global::AcpUI.AcpRecNavToolbar)A_0).Name == global::AllFeatures.CodeplugGuid.b("菐뛒뛔駖룘귚觜냞軠迢蟤蛦鯨껪闬鿮郰鷲釴鋶诸꿺迼諾漀栂氄椆済嬊栌紎成簒笔瘖甘爚検昞甠䈢䤤䰦丨太䈬娮䄰朲吴唶唸帺", a_))
						{
							num = (short)1099759651;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_6BB;
					case 27:
						goto IL_6BB;
					case 28:
						goto IL_2B4;
					case 29:
					{
						global::AcpCommonLib.IAcpRecordset myRecordsetDataSource3;
						base.NavigationService.Navigate(new global::System.Uri(myRecordsetDataSource3.UIPagePath, global::System.UriKind.RelativeOrAbsolute));
						num = (short)1936850954;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 30:
					{
						global::System.Windows.Data.CollectionView collectionView;
						collectionView.MoveCurrentToLast();
						num = (short)240582671;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 31:
					{
						global::System.Windows.Data.CollectionView collectionView2;
						if (collectionView2.Count > 0)
						{
							num = (short)1007550487;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_2B4;
					}
					case 32:
					{
						object myRecordsetDataSource;
						if (myRecordsetDataSource != null)
						{
							num = (short)886833168;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_6BB;
					}
					case 33:
						goto IL_2B4;
					case 34:
						if (((global::AcpUI.AcpRecNavToolbar)A_0).TableMode)
						{
							num = (short)1956773890;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						((global::AcpUI.AcpRecNavToolbar)A_0).TableMode = true;
						num = (short)1358102555;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 35:
						num = (short)808321058;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 36:
					{
						IL_334:
						global::Motorola.MackinawCPS.CoreFeatures.TrunkingPersonality.TalkgroupInner talkgroupInner;
						if (talkgroupInner != null)
						{
							num = (short)1528365062;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)716505119;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 37:
					{
						global::Motorola.MackinawCPS.CoreFeatures.TrunkingPersonality.PreferredSitesInner preferredSitesInner;
						if (preferredSitesInner != null)
						{
							num = (short)2093481988;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)2144993300;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 38:
					{
						global::AcpCommonLib.IAcpRecordset myRecordsetDataSource3;
						if (myRecordsetDataSource3 != null)
						{
							num = (short)1637351453;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_496;
					}
					case 39:
						switch (0)
						{
						case 0:
							goto IL_ED;
						}
						continue;
					}
					IL_ED:
					if (A_0 is global::AcpUI.AcpRecNavToolbar)
					{
						num = (short)810024969;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_713;
					IL_2B4:
					num = (short)999030785;
					if (num != 0)
					{
					}
					((global::AcpUI.AcpRecNavToolbar)A_0).SyncDataSources();
					num = (short)1114439702;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_713:
					num = (short)1081115745;
					short num3 = num;
					num = (short)1562215521;
					switch ((num3 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_334;
					default:
						goto IL_747;
					}
					IL_496:
					num = (short)1989541914;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_6BB:
					num = (short)735576072;
					num2 = (int)((global::System.IntPtr)num);
				}
				IL_2A8:
				((global::AcpUI.AcpRecNavToolbar)A_0).SyncDataSources();
				return;
				IL_379:
				IL_551:
				IL_57A:
				goto IL_2A8;
				IL_747:
				num = (short)2128805888;
				if (num != 0)
				{
				}
				num = (short)9175040;
				short num4 = num;
				return;
			}
			}
		}

		// Token: 0x06001E2E RID: 7726 RVA: 0x001DCEFC File Offset: 0x001DB0FC
		private void HLinkClick(object A_0, global::System.Windows.RoutedEventArgs A_1)
		{
			short num = (short)1373209836;
			short num2 = num;
			num = (short)1822721260;
			switch (num2 == num)
			{
			default:
			{
				num = (short)801570816;
				short num3 = num;
				break;
			}
			case true:
				break;
			}
			num = (short)766640129;
			if (num != 0)
			{
			}
			num = (short)296288256;
			if (num != 0)
			{
			}
			base.OnHLinkClick(A_0);
		}

		// Token: 0x06001E2F RID: 7727 RVA: 0x001DCFB0 File Offset: 0x001DB1B0
		private void OnFieldNameDoubleClick(object A_0, global::System.Windows.RoutedEventArgs A_1)
		{
			short num = (short)1897102520;
			short num2 = num;
			num = (short)552434872;
			switch (num2 == num)
			{
			default:
			{
				num = (short)1645608960;
				short num3 = num;
				break;
			}
			case true:
				break;
			}
			num = (short)870383617;
			if (num != 0)
			{
			}
			num = (short)1732706304;
			if (num != 0)
			{
			}
			global::AcpUI.Common.Utility.GetFieldHelpText(A_0);
		}

		// Token: 0x06001E30 RID: 7728 RVA: 0x001DD060 File Offset: 0x001DB260
		internal void OnExpanderTrunkingPersonalityTalkgroupTableClick(object sender, global::System.Windows.RoutedEventArgs e)
		{
			switch (0)
			{
			case 0:
				goto IL_8F;
			}
			short num;
			int num4;
			object myRecordsetDataSource;
			global::Motorola.MackinawCPS.CoreFeatures.TrunkingPersonality.TalkgroupInner item;
			for (;;)
			{
				IL_0A:
				num = (short)1711991958;
				short num2 = num;
				num = (short)585886870;
				switch ((num2 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					break;
				case 1:
					goto IL_68;
				default:
				{
					num = (short)1625096192;
					short num3 = num;
					goto IL_68;
				}
				}
				IL_103:
				num = (short)1561985025;
				num4 = (int)((global::System.IntPtr)num);
				continue;
				IL_68:
				num = (short)2045378560;
				if (num != 0)
				{
				}
				switch (num4)
				{
				case 0:
					goto IL_152;
				case 1:
					((global::System.Windows.Data.CollectionView)global::System.Windows.Data.CollectionViewSource.GetDefaultView(myRecordsetDataSource)).MoveCurrentTo(item);
					this.RecNavToolbarExpanderTrunkingPersonalityTalkgroupTable.SyncDataSources();
					num = (short)1966931968;
					num4 = (int)((global::System.IntPtr)num);
					continue;
				case 2:
					num = (short)786235393;
					if (num != 0)
					{
					}
					if (myRecordsetDataSource != null)
					{
						goto IL_103;
					}
					goto IL_154;
				}
				goto IL_8F;
			}
			IL_152:
			IL_154:
			this.RecNavToolbarExpanderTrunkingPersonalityTalkgroupTable.TableMode = false;
			return;
			IL_8F:
			item = (global::Motorola.MackinawCPS.CoreFeatures.TrunkingPersonality.TalkgroupInner)((global::Infragistics.Windows.DataPresenter.CellValuePresenter)((global::AcpUI.AcpButton)e.Source).TemplatedParent).Record.DataItem;
			myRecordsetDataSource = this.RecNavToolbarExpanderTrunkingPersonalityTalkgroupTable.MyRecordsetDataSource;
			num = (short)881524738;
			num4 = (int)((global::System.IntPtr)num);
			goto IL_0A;
		}

		// Token: 0x06001E31 RID: 7729 RVA: 0x001DD1D0 File Offset: 0x001DB3D0
		internal void OnExpanderTrunkingPersonalityPreferredSitesTableClick(object sender, global::System.Windows.RoutedEventArgs e)
		{
			switch (0)
			{
			case 0:
				goto IL_BA;
			}
			short num;
			int num4;
			object myRecordsetDataSource;
			global::Motorola.MackinawCPS.CoreFeatures.TrunkingPersonality.PreferredSitesInner item;
			for (;;)
			{
				IL_0A:
				num = (short)2115504264;
				short num2 = num;
				num = (short)1887504520;
				switch ((num2 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					break;
				case 1:
					goto IL_6B;
				default:
				{
					num = (short)1519583232;
					short num3 = num;
					goto IL_6B;
				}
				}
				IL_105:
				num = (short)1623588865;
				num4 = (int)((global::System.IntPtr)num);
				continue;
				IL_6B:
				num = (short)1192755200;
				if (num != 0)
				{
				}
				num = (short)1345388545;
				if (num != 0)
				{
				}
				switch (num4)
				{
				case 0:
					goto IL_152;
				case 1:
					((global::System.Windows.Data.CollectionView)global::System.Windows.Data.CollectionViewSource.GetDefaultView(myRecordsetDataSource)).MoveCurrentTo(item);
					this.RecNavToolbarExpanderTrunkingPersonalityPreferredSitesTable.SyncDataSources();
					num = (short)1400045568;
					num4 = (int)((global::System.IntPtr)num);
					continue;
				case 2:
					if (myRecordsetDataSource != null)
					{
						goto IL_105;
					}
					goto IL_154;
				}
				goto IL_BA;
			}
			IL_152:
			IL_154:
			this.RecNavToolbarExpanderTrunkingPersonalityPreferredSitesTable.TableMode = false;
			return;
			IL_BA:
			item = (global::Motorola.MackinawCPS.CoreFeatures.TrunkingPersonality.PreferredSitesInner)((global::Infragistics.Windows.DataPresenter.CellValuePresenter)((global::AcpUI.AcpButton)e.Source).TemplatedParent).Record.DataItem;
			myRecordsetDataSource = this.RecNavToolbarExpanderTrunkingPersonalityPreferredSitesTable.MyRecordsetDataSource;
			num = (short)845086722;
			num4 = (int)((global::System.IntPtr)num);
			goto IL_0A;
		}

		// Token: 0x06001E32 RID: 7730 RVA: 0x001DD340 File Offset: 0x001DB540
		[global::System.CodeDom.Compiler.GeneratedCode("PresentationBuildTasks", "5.0.10.0")]
		[global::System.Diagnostics.DebuggerNonUserCode]
		public void InitializeComponent()
		{
			int a_ = 13;
			if (this.b)
			{
				short num = (short)500977895;
				short num2 = num;
				num = (short)811421927;
				switch ((num2 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					break;
				default:
				{
					num = (short)652607488;
					short num3 = num;
					num = (short)349175809;
					if (num != 0)
					{
					}
					num = (short)2086338560;
					if (num != 0)
					{
					}
					return;
				}
				}
			}
			this.b = true;
			global::System.Uri resourceLocator = new global::System.Uri(global::AllFeatures.CodeplugGuid.b("量뻑룓郕뷗믙꣛ꯝ鋟蟡韣\udde5诧藩臫黭鿯鳱釳飵賷헹裻賽痿氁漃漅昇洉⤋㰍‏焑笓砕縗猙笛欝刟䌡倣伥䜧䐩̫娭䈯䜱娳崵儷吹嬻ᬽ爿牁㑃⍅㩇㥉⍋⁍ㅏ㹑㵓≕⅗留⡛ⱝᕟౡལཥ٧൩ᱫ୭ɯű᭳ᡵ᥷ᙹᕻ੽勵겁ﲃ", a_), global::System.UriKind.Relative);
			global::System.Windows.Application.LoadComponent(this, resourceLocator);
		}

		// Token: 0x06001E33 RID: 7731 RVA: 0x001DD424 File Offset: 0x001DB624
		[global::System.Diagnostics.DebuggerNonUserCode]
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		[global::System.CodeDom.Compiler.GeneratedCode("PresentationBuildTasks", "5.0.10.0")]
		void global::System.Windows.Markup.IComponentConnector.Connect(int connectionId, object target)
		{
			short num = (short)1468858368;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				switch (num2)
				{
				case 0:
					switch (0)
					{
					case 0:
						goto IL_30;
					}
					continue;
				case 1:
					num = (short)1271267330;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 2:
					goto IL_37D0;
				}
				IL_30:
				switch (connectionId)
				{
				case 1:
					goto IL_110D;
				case 2:
					goto IL_10E9;
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
					goto IL_3A41;
				case 24:
					goto IL_18B6;
				case 25:
					goto IL_B18;
				case 26:
					goto IL_39EC;
				case 27:
					goto IL_3445;
				case 28:
					goto IL_2288;
				case 29:
					goto IL_35ED;
				case 30:
					goto IL_3740;
				case 31:
					goto IL_214F;
				case 32:
					goto IL_2111;
				case 33:
					goto IL_CFB;
				case 34:
					goto IL_269F;
				case 35:
					goto IL_1B0E;
				case 36:
					goto IL_38AC;
				case 37:
					goto IL_FEA;
				case 38:
					goto IL_CA0;
				case 39:
					goto IL_34F5;
				case 40:
					goto IL_219A;
				case 41:
					goto IL_1ED0;
				case 42:
					goto IL_1BDB;
				case 43:
					goto IL_3529;
				case 44:
					goto IL_2D91;
				case 45:
					goto IL_1CE0;
				case 46:
					goto IL_1327;
				case 47:
					goto IL_362B;
				case 48:
					goto IL_2806;
				case 49:
					goto IL_20C6;
				case 50:
					goto IL_23E2;
				case 51:
					goto IL_165D;
				case 52:
					goto IL_36DB;
				case 53:
					goto IL_3398;
				case 54:
					goto IL_141F;
				case 55:
					goto IL_2CCA;
				case 56:
					goto IL_1A13;
				case 57:
					goto IL_3806;
				case 58:
					goto IL_22AC;
				case 59:
					goto IL_2580;
				case 60:
					goto IL_2AB0;
				case 61:
					goto IL_2F77;
				case 62:
					goto IL_36C1;
				case 63:
					goto IL_2875;
				case 64:
					goto IL_21FF;
				case 65:
					goto IL_3669;
				case 66:
					goto IL_D6A;
				case 67:
					goto IL_1D5C;
				case 68:
					goto IL_13A3;
				case 69:
					goto IL_1B90;
				case 70:
					goto IL_270E;
				case 71:
					goto IL_1443;
				case 72:
					goto IL_2BE9;
				case 73:
					goto IL_34A7;
				case 74:
					goto IL_18D0;
				case 75:
					goto IL_33A5;
				case 76:
					goto IL_2E2A;
				case 77:
					goto IL_32EB;
				case 78:
					goto IL_21A7;
				case 79:
					goto IL_24EA;
				case 80:
					goto IL_169B;
				case 81:
					goto IL_3966;
				case 82:
					goto IL_2492;
				case 83:
					goto IL_2C34;
				case 84:
					goto IL_FB9;
				case 85:
					goto IL_2D46;
				case 86:
					goto IL_176F;
				case 87:
					goto IL_3702;
				case 88:
					goto IL_16B5;
				case 89:
					goto IL_2FC2;
				case 90:
					goto IL_32C4;
				case 91:
					goto IL_29B8;
				case 92:
					goto IL_2613;
				case 93:
					goto IL_28F1;
				case 94:
					goto IL_1EAC;
				case 95:
					goto IL_25F9;
				case 96:
					goto IL_2E1D;
				case 97:
					goto IL_348D;
				case 98:
					goto IL_1B76;
				case 99:
					goto IL_1956;
				case 100:
					goto IL_31E3;
				case 101:
					goto IL_A54;
				case 102:
					goto IL_100E;
				case 103:
					goto IL_1450;
				case 104:
					goto IL_19AE;
				case 105:
					goto IL_38DD;
				case 106:
					goto IL_117F;
				case 107:
					goto IL_FC6;
				case 108:
					goto IL_15EB;
				case 109:
					goto IL_EA7;
				case 110:
					goto IL_3847;
				case 111:
					goto IL_2CFB;
				case 112:
					goto IL_D39;
				case 113:
					goto IL_166A;
				case 114:
					goto IL_2009;
				case 115:
					goto IL_1C3D;
				case 116:
					goto IL_37D5;
				case 117:
					goto IL_B60;
				case 118:
					goto IL_D77;
				case 119:
					goto IL_30D4;
				case 120:
					goto IL_CEE;
				case 121:
					goto IL_2485;
				case 122:
					goto IL_2868;
				case 123:
					goto IL_19BB;
				case 124:
					goto IL_3598;
				case 125:
					goto IL_2A1A;
				case 126:
					goto IL_2A72;
				case 127:
					goto IL_1748;
				case 128:
					goto IL_2B7A;
				case 129:
					goto IL_E2E;
				case 130:
					goto IL_1885;
				case 131:
					goto IL_37E2;
				case 132:
					goto IL_223D;
				case 133:
					goto IL_337E;
				case 134:
					goto IL_209F;
				case 135:
					goto IL_2ABD;
				case 136:
					goto IL_2899;
				case 137:
					goto IL_3279;
				case 138:
					goto IL_B3C;
				case 139:
					goto IL_2373;
				case 140:
					goto IL_3502;
				case 141:
					goto IL_2837;
				case 142:
					goto IL_168E;
				case 143:
					goto IL_1E54;
				case 144:
					goto IL_3795;
				case 145:
					goto IL_31D6;
				case 146:
					goto IL_36F5;
				case 147:
					goto IL_315A;
				case 148:
					goto IL_325F;
				case 149:
					goto IL_A3A;
				case 150:
					goto IL_DBF;
				case 151:
					goto IL_C24;
				case 152:
					goto IL_2977;
				case 153:
					goto IL_33C9;
				case 154:
					goto IL_2654;
				case 155:
					goto IL_299E;
				case 156:
					goto IL_B6D;
				case 157:
					goto IL_3764;
				case 158:
					goto IL_29E9;
				case 159:
					goto IL_3726;
				case 160:
					goto IL_19EC;
				case 161:
					goto IL_2B6D;
				case 162:
					goto IL_F95;
				case 163:
					goto IL_22EA;
				case 164:
					goto IL_32DE;
				case 165:
					goto IL_D2C;
				case 166:
					goto IL_AB6;
				case 167:
					goto IL_246B;
				case 168:
					goto IL_1FD8;
				case 169:
					goto IL_2EE1;
				case 170:
					goto IL_C6F;
				case 171:
					goto IL_2F1F;
				case 172:
					goto IL_14CC;
				case 173:
					goto IL_C62;
				case 174:
					goto IL_2142;
				case 175:
					goto IL_183D;
				case 176:
					goto IL_1CA2;
				case 177:
					goto IL_21B4;
				case 178:
					goto IL_23EF;
				case 179:
					goto IL_24DD;
				case 180:
					goto IL_22DD;
				case 181:
					goto IL_1E78;
				case 182:
					goto IL_2E8C;
				case 183:
					goto IL_28B3;
				case 184:
					goto IL_1F8A;
				case 185:
					goto IL_15DE;
				case 186:
					goto IL_1FCB;
				case 187:
					goto IL_1277;
				case 188:
					goto IL_1334;
				case 189:
					goto IL_153B;
				case 190:
					goto IL_2230;
				case 191:
					goto IL_1F97;
				case 192:
					goto IL_C55;
				case 193:
					goto IL_23FC;
				case 194:
					goto IL_170A;
				case 195:
					goto IL_2B15;
				case 196:
					goto IL_11E1;
				case 197:
					goto IL_23BE;
				case 198:
					goto IL_1D69;
				case 199:
					goto IL_3928;
				case 200:
					goto IL_31BC;
				case 201:
					goto IL_24C3;
				case 202:
					goto IL_1D1E;
				case 203:
					goto IL_1B52;
				case 204:
					goto IL_1FBE;
				case 205:
					goto IL_307C;
				case 206:
					goto IL_1F3F;
				case 207:
					goto IL_16A8;
				case 208:
					goto IL_C00;
				case 209:
					goto IL_335A;
				case 210:
					goto IL_3892;
				case 211:
					goto IL_1F25;
				case 212:
					goto IL_33FA;
				case 213:
					goto IL_CBA;
				case 214:
					goto IL_32F8;
				case 215:
					goto IL_E5F;
				case 216:
					goto IL_3959;
				case 217:
					goto IL_263A;
				case 218:
					goto IL_1165;
				case 219:
					goto IL_10AB;
				case 220:
					goto IL_1B45;
				case 221:
					goto IL_2BB8;
				case 222:
					goto IL_101B;
				case 223:
					goto IL_27C5;
				case 224:
					goto IL_2104;
				case 225:
					goto IL_1C23;
				case 226:
					goto IL_2756;
				case 227:
					goto IL_21C1;
				case 228:
					goto IL_26DD;
				case 229:
					goto IL_1284;
				case 230:
					goto IL_159D;
				case 231:
					goto IL_CD4;
				case 232:
					goto IL_1D76;
				case 233:
					goto IL_2447;
				case 234:
					goto IL_211E;
				case 235:
					goto IL_13BD;
				case 236:
					goto IL_21E5;
				case 237:
					goto IL_2528;
				case 238:
					goto IL_218D;
				case 239:
					goto IL_2922;
				case 240:
					goto IL_F09;
				case 241:
					goto IL_1AD0;
				case 242:
					goto IL_1994;
				case 243:
					goto IL_1B01;
				case 244:
					goto IL_3885;
				case 245:
					goto IL_323B;
				case 246:
					goto IL_2C68;
				case 247:
					goto IL_2FF3;
				case 248:
					goto IL_152E;
				case 249:
					goto IL_26AC;
				case 250:
					goto IL_34DB;
				case 251:
					goto IL_2946;
				case 252:
					goto IL_3469;
				case 253:
					goto IL_28D7;
				case 254:
					goto IL_2C99;
				case 255:
					goto IL_13CA;
				case 256:
					goto IL_1C57;
				case 257:
					goto IL_1158;
				case 258:
					goto IL_27A1;
				case 259:
					goto IL_BCF;
				case 260:
					goto IL_BC2;
				case 261:
					goto IL_EFC;
				case 262:
					goto IL_358B;
				case 263:
					goto IL_F2D;
				case 264:
					goto IL_3861;
				case 265:
					goto IL_2FCF;
				case 266:
					goto IL_322E;
				case 267:
					goto IL_382D;
				case 268:
					goto IL_2E10;
				case 269:
					goto IL_F61;
				case 270:
					goto IL_2DEC;
				case 271:
					goto IL_3336;
				case 272:
					goto IL_1F4C;
				case 273:
					goto IL_15AA;
				case 274:
					goto IL_2A58;
				case 275:
					goto IL_2478;
				case 276:
					goto IL_3A1D;
				case 277:
					goto IL_2ACA;
				case 278:
					goto IL_20EA;
				case 279:
					goto IL_29AB;
				case 280:
					goto IL_114B;
				case 281:
					goto IL_1C4A;
				case 282:
					goto IL_342B;
				case 283:
					goto IL_1396;
				case 284:
					goto IL_203A;
				case 285:
					goto IL_1172;
				case 286:
					goto IL_32B7;
				case 287:
					goto IL_349A;
				case 288:
					goto IL_2763;
				case 289:
					goto IL_20B9;
				case 290:
					goto IL_F54;
				case 291:
					goto IL_1A20;
				case 292:
					goto IL_31C9;
				case 293:
					goto IL_B0B;
				case 294:
					goto IL_296A;
				case 295:
					goto IL_1BCE;
				case 296:
					goto IL_173B;
				case 297:
					goto IL_234C;
				case 298:
					goto IL_2E68;
				case 299:
					goto IL_CAD;
				case 300:
					goto IL_17E8;
				case 301:
					goto IL_2E4E;
				case 302:
					goto IL_24B6;
				case 303:
					goto IL_13FB;
				case 304:
					goto IL_2A4B;
				case 305:
					goto IL_1E30;
				case 306:
					goto IL_1C71;
				case 307:
					goto IL_2AD7;
				case 308:
					goto IL_1A3A;
				case 309:
					goto IL_1A47;
				case 310:
					goto IL_2F12;
				case 311:
					goto IL_14D9;
				case 312:
					goto IL_350F;
				case 313:
					goto IL_28A6;
				case 314:
					goto IL_2366;
				case 315:
					goto IL_3935;
				case 316:
					goto IL_3024;
				case 317:
					goto IL_1CFA;
				case 318:
					goto IL_15F8;
				case 319:
					goto IL_10B8;
				case 320:
					goto IL_1E9F;
				case 321:
					goto IL_1901;
				case 322:
					goto IL_383A;
				case 323:
					goto IL_C7C;
				case 324:
					goto IL_2CEE;
				case 325:
					goto IL_282A;
				case 326:
					goto IL_3733;
				case 327:
					goto IL_39A4;
				case 328:
					goto IL_2061;
				case 329:
					goto IL_1819;
				case 330:
					goto IL_125D;
				case 331:
					goto IL_365C;
				case 332:
					goto IL_3438;
				case 333:
					goto IL_2F84;
				case 334:
					goto IL_1D4F;
				case 335:
					goto IL_149B;
				case 336:
					goto IL_1CED;
				case 337:
					goto IL_21F2;
				case 338:
					goto IL_2092;
				case 339:
					goto IL_1F59;
				case 340:
					goto IL_F3A;
				case 341:
					goto IL_1D83;
				case 342:
					goto IL_1389;
				case 343:
					goto IL_306F;
				case 344:
					goto IL_2047;
				case 345:
					goto IL_1F01;
				case 346:
					goto IL_113E;
				case 347:
					goto IL_E83;
				case 348:
					goto IL_30C7;
				case 349:
					goto IL_2B22;
				case 350:
					goto IL_27F9;
				case 351:
					goto IL_3676;
				case 352:
					goto IL_1E16;
				case 353:
					goto IL_2A8C;
				case 354:
					goto IL_15D1;
				case 355:
					goto IL_2DC5;
				case 356:
					goto IL_F88;
				case 357:
					goto IL_2380;
				case 358:
					goto IL_28E4;
				case 359:
					goto IL_17C4;
				case 360:
					goto IL_2DB8;
				case 361:
					goto IL_2C27;
				case 362:
					goto IL_19F9;
				case 363:
					goto IL_ED8;
				case 364:
					goto IL_354D;
				case 365:
					goto IL_A16;
				case 366:
					goto IL_F6E;
				case 367:
					goto IL_262D;
				case 368:
					goto IL_2BAB;
				case 369:
					goto IL_35C9;
				case 370:
					goto IL_3997;
				case 371:
					goto IL_17A0;
				case 372:
					goto IL_25EC;
				case 373:
					goto IL_2FB5;
				case 374:
					goto IL_226E;
				case 375:
					goto IL_3105;
				case 376:
					goto IL_12DC;
				case 377:
					goto IL_1717;
				case 378:
					goto IL_2D84;
				case 379:
					goto IL_AA9;
				case 380:
					goto IL_11C7;
				case 381:
					goto IL_D9B;
				case 382:
					goto IL_24D0;
				case 383:
					goto IL_E3B;
				case 384:
					goto IL_129E;
				case 385:
					goto IL_11D4;
				case 386:
					goto IL_1987;
				case 387:
					goto IL_2B3C;
				case 388:
					goto IL_1E23;
				case 389:
					goto IL_2F05;
				case 390:
					goto IL_3167;
				case 391:
					goto IL_2D08;
				case 392:
					goto IL_389F;
				case 393:
					goto IL_22D0;
				case 394:
					goto IL_27DF;
				case 395:
					goto IL_2647;
				case 396:
					goto IL_206E;
				case 397:
					goto IL_1087;
				case 398:
					goto IL_1B83;
				case 399:
					goto IL_27D2;
				case 400:
					goto IL_36CE;
				case 401:
					goto IL_2D2C;
				case 402:
					goto IL_1DD8;
				case 403:
					goto IL_25C8;
				case 404:
					goto IL_2692;
				case 405:
					goto IL_2D39;
				case 406:
					goto IL_30F8;
				case 407:
					goto IL_34E8;
				case 408:
					goto IL_12E9;
				case 409:
					goto IL_145D;
				case 410:
					goto IL_BF3;
				case 411:
					goto IL_1FB1;
				case 412:
					goto IL_1F7D;
				case 413:
					goto IL_391B;
				case 414:
					goto IL_29F6;
				case 415:
					goto IL_1063;
				case 416:
					goto IL_148E;
				case 417:
					goto IL_155F;
				case 418:
					goto IL_1358;
				case 419:
					goto IL_318B;
				case 420:
					goto IL_12B8;
				case 421:
					goto IL_103F;
				case 422:
					goto IL_243A;
				case 423:
					goto IL_19A1;
				case 424:
					goto IL_3854;
				case 425:
					goto IL_2C1A;
				case 426:
					goto IL_1239;
				case 427:
					goto IL_266E;
				case 428:
					goto IL_338B;
				case 429:
					goto IL_2AE4;
				case 430:
					goto IL_2FA8;
				case 431:
					goto IL_1291;
				case 432:
					goto IL_3031;
				case 433:
					goto IL_13B0;
				case 434:
					goto IL_A78;
				case 435:
					goto IL_2016;
				case 436:
					goto IL_3813;
				case 437:
					goto IL_130D;
				case 438:
					goto IL_38EA;
				case 439:
					goto IL_1E92;
				case 440:
					goto IL_1AB6;
				case 441:
					goto IL_277D;
				case 442:
					goto IL_3136;
				case 443:
					goto IL_A09;
				case 444:
					goto IL_2915;
				case 445:
					goto IL_2D9E;
				case 446:
					goto IL_1FFC;
				case 447:
					goto IL_29C5;
				case 448:
					goto IL_19C8;
				case 449:
					goto IL_32AA;
				case 450:
					goto IL_180C;
				case 451:
					goto IL_3329;
				case 452:
					goto IL_2E5B;
				case 453:
					goto IL_126A;
				case 454:
					goto IL_26B9;
				case 455:
					goto IL_10C5;
				case 456:
					goto IL_1CC6;
				case 457:
					goto IL_1AA9;
				case 458:
					goto IL_2A3E;
				case 459:
					goto IL_329D;
				case 460:
					goto IL_18DD;
				case 461:
					goto IL_16D9;
				case 462:
					goto IL_36B4;
				case 463:
					goto IL_3788;
				case 464:
					goto IL_1CD3;
				case 465:
					goto IL_CC7;
				case 466:
					goto IL_1A2D;
				case 467:
					goto IL_2B49;
				case 468:
					goto IL_2BF6;
				case 469:
					goto IL_3A10;
				case 470:
					goto IL_233F;
				case 471:
					goto IL_DF0;
				case 472:
					goto IL_15C4;
				case 473:
					goto IL_2DAB;
				case 474:
					goto IL_EB4;
				case 475:
					goto IL_38F7;
				case 476:
					goto IL_1C30;
				case 477:
					goto IL_3221;
				case 478:
					goto IL_20F7;
				case 479:
					goto IL_1C64;
				case 480:
					goto IL_2542;
				case 481:
					goto IL_2CA6;
				case 482:
					goto IL_2054;
				case 483:
					goto IL_23B1;
				case 484:
					goto IL_2180;
				case 485:
					goto IL_2F46;
				case 486:
					goto IL_1EDD;
				case 487:
					goto IL_1892;
				case 488:
					goto IL_2573;
				case 489:
					goto IL_D5D;
				case 490:
					goto IL_3129;
				case 491:
					goto IL_F7B;
				case 492:
					goto IL_11A3;
				case 493:
					goto IL_2B87;
				case 494:
					goto IL_1FA4;
				case 495:
					goto IL_1205;
				case 496:
					goto IL_1BB4;
				case 497:
					goto IL_1BC1;
				case 498:
					goto IL_1861;
				case 499:
					goto IL_1A6B;
				case 500:
					goto IL_1481;
				case 501:
					goto IL_3207;
				case 502:
					goto IL_1AC3;
				case 503:
					goto IL_BB5;
				case 504:
					goto IL_1ADD;
				case 505:
					goto IL_2F53;
				case 506:
					goto IL_34C1;
				case 507:
					goto IL_2606;
				case 508:
					goto IL_1D42;
				case 509:
					goto IL_A47;
				case 510:
					goto IL_1925;
				case 511:
					goto IL_3638;
				case 512:
					goto IL_27EC;
				case 513:
					goto IL_16FD;
				case 514:
					goto IL_DE3;
				case 515:
					goto IL_C48;
				case 516:
					goto IL_231B;
				case 517:
					goto IL_177C;
				case 518:
					goto IL_12AB;
				case 519:
					goto IL_32D1;
				case 520:
					goto IL_1DA7;
				case 521:
					goto IL_DFD;
				case 522:
					goto IL_304B;
				case 523:
					goto IL_14FD;
				case 524:
					goto IL_1DFC;
				case 525:
					goto IL_242D;
				case 526:
					goto IL_2620;
				case 527:
					goto IL_36A7;
				case 528:
					goto IL_2732;
				case 529:
					goto IL_131A;
				case 530:
					goto IL_2A65;
				case 531:
					goto IL_39C8;
				case 532:
					goto IL_3198;
				case 533:
					goto IL_326C;
				case 534:
					goto IL_227B;
				case 535:
					goto IL_2C4E;
				case 536:
					goto IL_CE1;
				case 537:
					goto IL_33D6;
				case 538:
					goto IL_E0A;
				case 539:
					goto IL_3089;
				case 540:
					goto IL_3820;
				case 541:
					goto IL_2F2C;
				case 542:
					goto IL_34B4;
				case 543:
					goto IL_2AF1;
				case 544:
					goto IL_AC3;
				case 545:
					goto IL_35BC;
				case 546:
					goto IL_1E09;
				case 547:
					goto IL_2701;
				case 548:
					goto IL_361E;
				case 549:
					goto IL_2B2F;
				case 550:
					goto IL_14BF;
				case 551:
					goto IL_34CE;
				case 552:
					goto IL_20AC;
				case 553:
					goto IL_1755;
				case 554:
					goto IL_3611;
				case 555:
					goto IL_F47;
				case 556:
					goto IL_24F7;
				case 557:
					goto IL_2770;
				case 558:
					goto IL_1650;
				case 559:
					goto IL_355A;
				case 560:
					goto IL_B91;
				case 561:
					goto IL_30BA;
				case 562:
					goto IL_D08;
				case 563:
					goto IL_2F39;
				case 564:
					goto IL_351C;
				case 565:
					goto IL_A9C;
				case 566:
					goto IL_1365;
				case 567:
					goto IL_398A;
				case 568:
					goto IL_3567;
				case 569:
					goto IL_15B7;
				case 570:
					goto IL_156C;
				case 571:
					goto IL_2984;
				case 572:
					goto IL_1963;
				case 573:
					goto IL_331C;
				case 574:
					goto IL_1579;
				case 575:
					goto IL_2661;
				case 576:
					goto IL_2C41;
				case 577:
					goto IL_2223;
				case 578:
					goto IL_3000;
				case 579:
					goto IL_2ED4;
				case 580:
					goto IL_2504;
				case 581:
					goto IL_230E;
				case 582:
					goto IL_369A;
				case 583:
					goto IL_303E;
				case 584:
					goto IL_3407;
				case 585:
					goto IL_1A8F;
				case 586:
					goto IL_2D53;
				case 587:
					goto IL_1F32;
				case 588:
					goto IL_2BDC;
				case 589:
					goto IL_2A7F;
				case 590:
					goto IL_2409;
				case 591:
					goto IL_1762;
				case 592:
					goto IL_1C7E;
				case 593:
					goto IL_3214;
				case 594:
					goto IL_2261;
				case 595:
					goto IL_23A4;
				case 596:
					goto IL_1521;
				case 597:
					goto IL_38D0;
				case 598:
					goto IL_2DD2;
				case 599:
					goto IL_25A4;
				case 600:
					goto IL_2EB0;
				case 601:
					goto IL_2359;
				case 602:
					goto IL_2535;
				case 603:
					goto IL_2C5B;
				case 604:
					goto IL_2991;
				case 605:
					goto IL_AE7;
				case 606:
					goto IL_1BFF;
				case 607:
					goto IL_2DDF;
				case 608:
					goto IL_18C3;
				case 609:
					goto IL_1A9C;
				case 610:
					goto IL_2173;
				case 611:
					goto IL_2844;
				case 612:
					goto IL_3096;
				case 613:
					goto IL_1E85;
				case 614:
					goto IL_36E8;
				case 615:
					goto IL_2C8C;
				case 616:
					goto IL_1949;
				case 617:
					goto IL_1DB4;
				case 618:
					goto IL_13D7;
				case 619:
					goto IL_2D77;
				case 620:
					goto IL_1A06;
				case 621:
					goto IL_2566;
				default:
					num = (short)588120065;
					num2 = (int)((global::System.IntPtr)num);
					break;
				}
			}
			IL_A09:
			this.RTDBtnTrkPerFeaturesScanListSelection_A9053 = (global::AcpUI.AcpRtdButton)target;
			return;
			IL_A16:
			this.LblTrkPerTalkgroupSecondaryFailsoftTxFrequencyMHz_A8902 = (global::AcpUI.AcpLabel)target;
			this.LblTrkPerTalkgroupSecondaryFailsoftTxFrequencyMHz_A8902.MouseDoubleClick += new global::System.Windows.Input.MouseButtonEventHandler(this.OnFieldNameDoubleClick);
			return;
			IL_A3A:
			this.CVBtnTrkEmerProfGeneralTalkgroup_A8969 = (global::AcpUI.AcpCustomViewCheckBox)target;
			return;
			IL_A47:
			this.CVBtnTrkPerFeatureBackupPTTOperation_A43628 = (global::AcpUI.AcpCustomViewCheckBox)target;
			return;
			IL_A54:
			this.TrkPerGeneralRxFrequencyMHz_A8910 = (global::AcpUI.AcpTextBox)target;
			this.TrkPerGeneralRxFrequencyMHz_A8910.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_A78:
			this.LblTrkPerFeaturesPhoneOperation_A8701 = (global::AcpUI.AcpLabel)target;
			this.LblTrkPerFeaturesPhoneOperation_A8701.MouseDoubleClick += new global::System.Windows.Input.MouseButtonEventHandler(this.OnFieldNameDoubleClick);
			return;
			IL_A9C:
			this.TrkPerPreferredSitesSiteID_A9151Comp = (global::AcpUI.AcpTextBoxDecHex)target;
			return;
			IL_AA9:
			this.CpyBtnTrkPerTalkgroupTGWACNID_A19716 = (global::AcpUI.AcpCopyButton)target;
			return;
			IL_AB6:
			this.TrkEmerProfGeneralSecureClearStrapping_A9092Comp = (global::AcpUI.AcpLabel)target;
			return;
			IL_AC3:
			this.TrkPerPreferredSitesAllowEmergencyAtBlockedSite_44910 = (global::AcpUI.AcpCheckBox)target;
			this.TrkPerPreferredSitesAllowEmergencyAtBlockedSite_44910.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_AE7:
			this.LblTrkPerLabtoolTrunkingPersonalityPreferredSiteStatusListItemID_A19962 = (global::AcpUI.AcpLabel)target;
			this.LblTrkPerLabtoolTrunkingPersonalityPreferredSiteStatusListItemID_A19962.MouseDoubleClick += new global::System.Windows.Input.MouseButtonEventHandler(this.OnFieldNameDoubleClick);
			return;
			IL_B0B:
			this.TrkPerTalkgroupTGSystemID_A19715_Col = (global::Infragistics.Windows.DataPresenter.UnboundField)target;
			return;
			IL_B18:
			this.HLinkGeneral = (global::System.Windows.Documents.Hyperlink)target;
			this.HLinkGeneral.Click += this.HLinkClick;
			return;
			IL_B3C:
			this.TrkPerLabtoolTrunkingEmergencyProfileCompositeItemID_A19980 = (global::AcpUI.AcpComboBox)target;
			this.TrkPerLabtoolTrunkingEmergencyProfileCompositeItemID_A19980.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_B60:
			this.CVBtnTrkPerGeneralSecondaryRxFrequencyMHz_A8904 = (global::AcpUI.AcpCustomViewCheckBox)target;
			return;
			IL_B6D:
			this.LblTrkEmerProfGeneralVoiceSignalType_A7500 = (global::AcpUI.AcpLabel)target;
			this.LblTrkEmerProfGeneralVoiceSignalType_A7500.MouseDoubleClick += new global::System.Windows.Input.MouseButtonEventHandler(this.OnFieldNameDoubleClick);
			return;
			IL_B91:
			this.TrkPerPreferredSitesSiteID_A9151 = (global::AcpUI.AcpTextBoxSpinnerDecHex)target;
			this.TrkPerPreferredSitesSiteID_A9151.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_BB5:
			this.CVBtnTrkPerFeaturesPriorityDispatchTimeOutTimersec_43598 = (global::AcpUI.AcpCustomViewCheckBox)target;
			return;
			IL_BC2:
			this.RTDBtnTrkPerAnnouncementGroupAGSystemID_A19705 = (global::AcpUI.AcpRtdButton)target;
			return;
			IL_BCF:
			this.TrkPerAnnouncementGroupAGSystemID_A19705 = (global::AcpUI.AcpTextBoxSpinnerDecHex)target;
			this.TrkPerAnnouncementGroupAGSystemID_A19705.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_BF3:
			this.RTDBtnTrkPerCallPageHotListItemID_A19982 = (global::AcpUI.AcpRtdButton)target;
			return;
			IL_C00:
			this.LblTrkPerAnnouncementGroupAGSecureClearStrapping_A9089 = (global::AcpUI.AcpLabel)target;
			this.LblTrkPerAnnouncementGroupAGSecureClearStrapping_A9089.MouseDoubleClick += new global::System.Windows.Input.MouseButtonEventHandler(this.OnFieldNameDoubleClick);
			return;
			IL_C24:
			this.TrkEmerProfGeneralTalkgroup_A8969 = (global::AcpUI.AcpTextBoxSpinnerDecHex)target;
			this.TrkEmerProfGeneralTalkgroup_A8969.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_C48:
			this.CVBtnTrkPerFeaturesHazardZoneModePersonality = (global::AcpUI.AcpCustomViewCheckBox)target;
			return;
			IL_C55:
			this.TrkPerGeneralRevertChannel_A41917Comp = (global::AcpUI.AcpLabel)target;
			return;
			IL_C62:
			this.GrpBoxExpanderTrunkingPersonalityGeneralPseudo3 = (global::AcpUI.AcpGroupBox)target;
			return;
			IL_C6F:
			this.RTDBtnTrkEmerProfGeneralKeySelect_A8970 = (global::AcpUI.AcpRtdButton)target;
			return;
			IL_C7C:
			this.LblTrkPerTalkgroupSecureClearStrapping_A9095 = (global::AcpUI.AcpLabel)target;
			this.LblTrkPerTalkgroupSecureClearStrapping_A9095.MouseDoubleClick += new global::System.Windows.Input.MouseButtonEventHandler(this.OnFieldNameDoubleClick);
			return;
			IL_CA0:
			this.CpyBtnTrkPerGeneralTrunkingPersonalityName_A12659 = (global::AcpUI.AcpCopyButton)target;
			return;
			IL_CAD:
			this.CVBtnTrkSysGeneralKeyofTrunkingTalkgroup_A20742 = (global::AcpUI.AcpCustomViewCheckBox)target;
			return;
			IL_CBA:
			this.CVBtnTrkPerAnnouncementGroupAGKeySelect_A7414 = (global::AcpUI.AcpCustomViewCheckBox)target;
			return;
			IL_CC7:
			this.GrpBoxExpanderTrunkingPersonalityFeaturesRadioErgo = (global::AcpUI.AcpGroupBox)target;
			return;
			IL_CD4:
			this.TrkPerAnnouncementGroupAGFailsoftRxFrequencyMHz_A9582Comp = (global::AcpUI.AcpLabel)target;
			return;
			IL_CE1:
			this.CVBtnTrkPerPreferredSitesSiteListType_A43581 = (global::AcpUI.AcpCustomViewCheckBox)target;
			return;
			IL_CEE:
			this.RTDBtnTrkPerGeneralSecondaryRxFrequencyMHz_A8904 = (global::AcpUI.AcpRtdButton)target;
			return;
			IL_CFB:
			this.ExpanderTrunkingPersonalityGeneral = (global::AcpUI.AcpExpander)target;
			return;
			IL_D08:
			this.LblTrkPerPreferredSitesSiteID_A9151 = (global::AcpUI.AcpLabel)target;
			this.LblTrkPerPreferredSitesSiteID_A9151.MouseDoubleClick += new global::System.Windows.Input.MouseButtonEventHandler(this.OnFieldNameDoubleClick);
			return;
			IL_D2C:
			this.CpyBtnTrkEmerProfGeneralSecureClearStrapping_A9092 = (global::AcpUI.AcpCopyButton)target;
			return;
			IL_D39:
			this.LblTrkPerGeneralSecondaryFailsoft_A19991 = (global::AcpUI.AcpLabel)target;
			this.LblTrkPerGeneralSecondaryFailsoft_A19991.MouseDoubleClick += new global::System.Windows.Input.MouseButtonEventHandler(this.OnFieldNameDoubleClick);
			return;
			IL_D5D:
			this.CpyBtnTrkPerFeaturesHotKeypadDTMF_A8209 = (global::AcpUI.AcpCopyButton)target;
			return;
			IL_D6A:
			this.CpyBtnTrkPerGeneralTimeOutTimersec_A9379 = (global::AcpUI.AcpCopyButton)target;
			return;
			IL_D77:
			this.LblTrkPerGeneralSecondaryRxFrequencyMHz_A8904 = (global::AcpUI.AcpLabel)target;
			this.LblTrkPerGeneralSecondaryRxFrequencyMHz_A8904.MouseDoubleClick += new global::System.Windows.Input.MouseButtonEventHandler(this.OnFieldNameDoubleClick);
			return;
			IL_D9B:
			this.TrkPerTalkgroupAstroOTARProfileIndex_43687 = (global::AcpUI.AcpComboBox)target;
			this.TrkPerTalkgroupAstroOTARProfileIndex_43687.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_DBF:
			this.LblTrkEmerProfGeneralTalkgroup_A8969 = (global::AcpUI.AcpLabel)target;
			this.LblTrkEmerProfGeneralTalkgroup_A8969.MouseDoubleClick += new global::System.Windows.Input.MouseButtonEventHandler(this.OnFieldNameDoubleClick);
			return;
			IL_DE3:
			this.TrkPerFeatureBackupPTTOperation_A43628Comp = (global::AcpUI.AcpLabel)target;
			return;
			IL_DF0:
			this.TrkPerFeaturesTalkPermitTone_A9271Comp = (global::AcpUI.AcpCheckBox)target;
			return;
			IL_DFD:
			this.CVBtnTrkPerFeaturesTacticalPublicSafetyUIEnable = (global::AcpUI.AcpCustomViewCheckBox)target;
			return;
			IL_E0A:
			this.TrkPerPreferredSitesSiteListType_A43581 = (global::AcpUI.AcpComboBox)target;
			this.TrkPerPreferredSitesSiteListType_A43581.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_E2E:
			this.GrpBoxExpanderTrunkingPersonalityGeneralPseudo2 = (global::AcpUI.AcpGroupBox)target;
			return;
			IL_E3B:
			this.LblTrkPerTalkgroupAstroOTARProfileIndex_43687 = (global::AcpUI.AcpLabel)target;
			this.LblTrkPerTalkgroupAstroOTARProfileIndex_43687.MouseDoubleClick += new global::System.Windows.Input.MouseButtonEventHandler(this.OnFieldNameDoubleClick);
			return;
			IL_E5F:
			this.TrkPerAnnouncementGroupAGKeySelect_A7414 = (global::AcpUI.AcpComboBox)target;
			this.TrkPerAnnouncementGroupAGKeySelect_A7414.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_E83:
			this.LblTrkPerTalkgroupFailsoftTxFrequencyMHz_A8003 = (global::AcpUI.AcpLabel)target;
			this.LblTrkPerTalkgroupFailsoftTxFrequencyMHz_A8003.MouseDoubleClick += new global::System.Windows.Input.MouseButtonEventHandler(this.OnFieldNameDoubleClick);
			return;
			IL_EA7:
			this.CpyBtnTrkPerGeneralTxFrequencyMHz_A9413 = (global::AcpUI.AcpCopyButton)target;
			return;
			IL_EB4:
			this.LblTrkPerFeaturesSecureProperCodeDetect_A8763 = (global::AcpUI.AcpLabel)target;
			this.LblTrkPerFeaturesSecureProperCodeDetect_A8763.MouseDoubleClick += new global::System.Windows.Input.MouseButtonEventHandler(this.OnFieldNameDoubleClick);
			return;
			IL_ED8:
			this.TrkPerTalkgroupSecondaryFailsoftTxFrequencyMHz_A8902 = (global::AcpUI.AcpTextBox)target;
			this.TrkPerTalkgroupSecondaryFailsoftTxFrequencyMHz_A8902.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_EFC:
			this.CpyBtnTrkPerAnnouncementGroupAGSystemID_A19705 = (global::AcpUI.AcpCopyButton)target;
			return;
			IL_F09:
			this.TrkPerAnnouncementGroupAGSecondaryFailsoft_A19990 = (global::AcpUI.AcpCheckBox)target;
			this.TrkPerAnnouncementGroupAGSecondaryFailsoft_A19990.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_F2D:
			this.CVBtnTrkPerAnnouncementGroupAGWACNID_A19706 = (global::AcpUI.AcpCustomViewCheckBox)target;
			return;
			IL_F3A:
			this.CVBtnTrkPerTalkgroupFailsoftRxFrequencyMHz_A8001 = (global::AcpUI.AcpCustomViewCheckBox)target;
			return;
			IL_F47:
			this.TrkPerPreferredSitesSystemID_A19466_Col = (global::Infragistics.Windows.DataPresenter.UnboundField)target;
			return;
			IL_F54:
			this.TrkPerTalkgroupTGSecondaryFailsoft_A19989_Col = (global::Infragistics.Windows.DataPresenter.UnboundField)target;
			return;
			IL_F61:
			this.CVBtnTrkPerAnnouncementGroupAstroOTARProfileIndex_43686 = (global::AcpUI.AcpCustomViewCheckBox)target;
			return;
			IL_F6E:
			this.RTDBtnTrkPerTalkgroupSecondaryFailsoftTxFrequencyMHz_A8902 = (global::AcpUI.AcpRtdButton)target;
			return;
			IL_F7B:
			this.CVBtnTrkPerFeatureDTMFMicEn_A42482 = (global::AcpUI.AcpCustomViewCheckBox)target;
			return;
			IL_F88:
			this.TrkPerTalkgroupTGSecondaryFailsoft_A19989Comp = (global::AcpUI.AcpCheckBox)target;
			return;
			IL_F95:
			this.LblTrkEmerProfGeneralSecureClearStrapping_A9092 = (global::AcpUI.AcpLabel)target;
			this.LblTrkEmerProfGeneralSecureClearStrapping_A9092.MouseDoubleClick += new global::System.Windows.Input.MouseButtonEventHandler(this.OnFieldNameDoubleClick);
			return;
			IL_FB9:
			this.CpyBtnTrkPerGeneralFailsoftType_A8599 = (global::AcpUI.AcpCopyButton)target;
			return;
			IL_FC6:
			this.TrkPerGeneralTxFrequencyMHz_A9413 = (global::AcpUI.AcpTextBox)target;
			this.TrkPerGeneralTxFrequencyMHz_A9413.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_FEA:
			this.TrkPerGeneralTrunkingPersonalityName_A12659 = (global::AcpUI.AcpTextBox)target;
			this.TrkPerGeneralTrunkingPersonalityName_A12659.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_100E:
			this.RTDBtnTrkPerGeneralRxFrequencyMHz_A8910 = (global::AcpUI.AcpRtdButton)target;
			return;
			IL_101B:
			this.TrkPerAnnouncementGroupAnnouncementGroupFailsoft_A8597 = (global::AcpUI.AcpCheckBox)target;
			this.TrkPerAnnouncementGroupAnnouncementGroupFailsoft_A8597.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_103F:
			this.TrkPerCallPageAutomaticCallAlert_A9754 = (global::AcpUI.AcpCheckBox)target;
			this.TrkPerCallPageAutomaticCallAlert_A9754.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_1063:
			this.TrkPerCallPageInCallUserAlertEnable_A9434 = (global::AcpUI.AcpCheckBox)target;
			this.TrkPerCallPageInCallUserAlertEnable_A9434.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_1087:
			this.TrkPerCallPagePrivateCallOperation_A8759 = (global::AcpUI.AcpComboBox)target;
			this.TrkPerCallPagePrivateCallOperation_A8759.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_10AB:
			this.GrpBoxExpanderTrunkingPersonalityAnnouncementGroupTalkgroupFailsoft = (global::AcpUI.AcpGroupBox)target;
			return;
			IL_10B8:
			this.CpyBtnTrkPerTalkgroupTxVoiceSignalType_A9575 = (global::AcpUI.AcpCopyButton)target;
			return;
			IL_10C5:
			this.TrkPerFeaturesStatusEnable_A9188 = (global::AcpUI.AcpCheckBox)target;
			this.TrkPerFeaturesStatusEnable_A9188.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_10E9:
			this.RecNavToolbarPageTrunkingPersonality = (global::AcpUI.AcpParentRecNavToolbar)target;
			this.RecNavToolbarPageTrunkingPersonality.ModeClick += this.OnModeClick;
			return;
			IL_110D:
			((global::Motorola.MackinawCPS.CoreFeatures.TrunkingPersonality.PageTrunkingPersonality)target).Loaded += this.OnLoaded;
			((global::Motorola.MackinawCPS.CoreFeatures.TrunkingPersonality.PageTrunkingPersonality)target).Unloaded += this.OnUnloaded;
			return;
			IL_113E:
			this.CVBtnTrkPerTalkgroupFailsoftTxFrequencyMHz_A8003 = (global::AcpUI.AcpCustomViewCheckBox)target;
			return;
			IL_114B:
			this.ExpanderTrunkingPersonalityTalkgroupTable = (global::AcpUI.AcpXamDataPresenter)target;
			return;
			IL_1158:
			this.CVBtnTrkPerAnnouncementGroupAGSystemID_A19705 = (global::AcpUI.AcpCustomViewCheckBox)target;
			return;
			IL_1165:
			this.TrkPerAnnouncementGroupAGKeySelect_A7414Comp = (global::AcpUI.AcpLabel)target;
			return;
			IL_1172:
			this.TrkPerTalkgroupSecureClearStrapping_A9095_Col = (global::Infragistics.Windows.DataPresenter.UnboundField)target;
			return;
			IL_117F:
			this.LblTrkPerGeneralTxFrequencyMHz_A9413 = (global::AcpUI.AcpLabel)target;
			this.LblTrkPerGeneralTxFrequencyMHz_A9413.MouseDoubleClick += new global::System.Windows.Input.MouseButtonEventHandler(this.OnFieldNameDoubleClick);
			return;
			IL_11A3:
			this.LblTrkPerFeatureDTMFMicEn_A42482 = (global::AcpUI.AcpLabel)target;
			this.LblTrkPerFeatureDTMFMicEn_A42482.MouseDoubleClick += new global::System.Windows.Input.MouseButtonEventHandler(this.OnFieldNameDoubleClick);
			return;
			IL_11C7:
			this.TrkPerTalkgroupTGWACNID_A19716Comp = (global::AcpUI.AcpTextBoxDecHex)target;
			return;
			IL_11D4:
			this.CpyBtnTrkPerTalkgroupAstroOTARProfileIndex_43687 = (global::AcpUI.AcpCopyButton)target;
			return;
			IL_11E1:
			this.LblTrkPerAnnouncementGroupAnnouncementGroup_A7444 = (global::AcpUI.AcpLabel)target;
			this.LblTrkPerAnnouncementGroupAnnouncementGroup_A7444.MouseDoubleClick += new global::System.Windows.Input.MouseButtonEventHandler(this.OnFieldNameDoubleClick);
			return;
			IL_1205:
			num = (short)674037761;
			if (num != 0)
			{
			}
			this.CpyBtnTrkPerFeatureDTMFMicEn_A42482 = (global::AcpUI.AcpCopyButton)target;
			return;
			IL_1239:
			this.LblTrkPerFeaturesAstroAlertingToneTable = (global::AcpUI.AcpLabel)target;
			this.LblTrkPerFeaturesAstroAlertingToneTable.MouseDoubleClick += new global::System.Windows.Input.MouseButtonEventHandler(this.OnFieldNameDoubleClick);
			return;
			IL_125D:
			this.RTDBtnTrkPerTalkgroupKeySelect_A8365 = (global::AcpUI.AcpRtdButton)target;
			return;
			IL_126A:
			this.CVBtnTrkPerFeaturesStatusEnable_A9188 = (global::AcpUI.AcpCustomViewCheckBox)target;
			return;
			IL_1277:
			this.CVBtnTrkPerGeneralRevertChannel_A41917 = (global::AcpUI.AcpCustomViewCheckBox)target;
			return;
			IL_1284:
			this.RTDBtnTrkPerAnnouncementGroupAGFailsoftRxFrequencyMHz_A9582 = (global::AcpUI.AcpRtdButton)target;
			return;
			IL_1291:
			this.ExpanderTrunkingPersonalityFeatures = (global::AcpUI.AcpExpander)target;
			return;
			IL_129E:
			this.RTDBtnTrkPerTalkgroupAstroOTARProfileIndex_43687 = (global::AcpUI.AcpRtdButton)target;
			return;
			IL_12AB:
			this.RTDBtnTrkPerFeaturesHazardZoneModePersonality = (global::AcpUI.AcpRtdButton)target;
			return;
			IL_12B8:
			this.LblTrkPerCallPageAutomaticCallAlert_A9754 = (global::AcpUI.AcpLabel)target;
			this.LblTrkPerCallPageAutomaticCallAlert_A9754.MouseDoubleClick += new global::System.Windows.Input.MouseButtonEventHandler(this.OnFieldNameDoubleClick);
			return;
			IL_12DC:
			this.CVBtnTrkPerTalkgroupTGWACNID_A19716 = (global::AcpUI.AcpCustomViewCheckBox)target;
			return;
			IL_12E9:
			this.LblTrkPerCallPageHotListItemID_A19982 = (global::AcpUI.AcpLabel)target;
			this.LblTrkPerCallPageHotListItemID_A19982.MouseDoubleClick += new global::System.Windows.Input.MouseButtonEventHandler(this.OnFieldNameDoubleClick);
			return;
			IL_130D:
			this.CpyBtnTrkPerFeaturesPhoneOperation_A8701 = (global::AcpUI.AcpCopyButton)target;
			return;
			IL_131A:
			this.GrpBoxExpanderTrunkingPersonalityPreferredSitesPseudo0 = (global::AcpUI.AcpGroupBox)target;
			return;
			IL_1327:
			this.TrkPerGeneralSystem_A9237Comp = (global::AcpUI.AcpLabel)target;
			return;
			IL_1334:
			this.LblTrkPerGeneralRevertChannel_A41917 = (global::AcpUI.AcpLabel)target;
			this.LblTrkPerGeneralRevertChannel_A41917.MouseDoubleClick += new global::System.Windows.Input.MouseButtonEventHandler(this.OnFieldNameDoubleClick);
			return;
			IL_1358:
			this.TrkPerCallPageInCallUserAlertEnable_A9434Comp = (global::AcpUI.AcpCheckBox)target;
			return;
			IL_1365:
			this.TrkPerPreferredSitesPreferredStatus_A8734 = (global::AcpUI.AcpComboBox)target;
			this.TrkPerPreferredSitesPreferredStatus_A8734.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_1389:
			this.RTDBtnTrkPerTalkgroupFailsoftRxFrequencyMHz_A8001 = (global::AcpUI.AcpRtdButton)target;
			return;
			IL_1396:
			this.TrkPerTalkgroupPriorityDispatch_43599_Col = (global::Infragistics.Windows.DataPresenter.UnboundField)target;
			return;
			IL_13A3:
			this.CVBtnTrkPerGeneralAdvancedRFAGC_A7409 = (global::AcpUI.AcpCustomViewCheckBox)target;
			return;
			IL_13B0:
			this.CVBtnTrkPerFeaturesPhoneOperation_A8701 = (global::AcpUI.AcpCustomViewCheckBox)target;
			return;
			IL_13BD:
			this.RTDBtnTrkPerAnnouncementGroupAGFailsoftTxFrequencyMHz_A9583 = (global::AcpUI.AcpRtdButton)target;
			return;
			IL_13CA:
			this.TrkPerAnnouncementGroupAGSecondaryFSTxFrequencyMHz_A12903Comp = (global::AcpUI.AcpLabel)target;
			return;
			IL_13D7:
			this.TrkPerLabtoolTrunkingPersonalityAGTGFSListItemID_A21508 = (global::AcpUI.AcpComboBox)target;
			this.TrkPerLabtoolTrunkingPersonalityAGTGFSListItemID_A21508.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_13FB:
			this.TrkPerTalkgroupTalkgroup_A9274 = (global::AcpUI.AcpTextBoxDecHex)target;
			this.TrkPerTalkgroupTalkgroup_A9274.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_141F:
			this.LblTrkPerGeneralUnitID_A9593 = (global::AcpUI.AcpLabel)target;
			this.LblTrkPerGeneralUnitID_A9593.MouseDoubleClick += new global::System.Windows.Input.MouseButtonEventHandler(this.OnFieldNameDoubleClick);
			return;
			IL_1443:
			this.RTDBtnTrkPerGeneralAdvancedRFAGC_A7409 = (global::AcpUI.AcpRtdButton)target;
			return;
			IL_1450:
			this.CpyBtnTrkPerGeneralRxFrequencyMHz_A8910 = (global::AcpUI.AcpCopyButton)target;
			return;
			IL_145D:
			this.TrkPerCallPageHotListItemID_A19982 = (global::AcpUI.AcpComboBox)target;
			this.TrkPerCallPageHotListItemID_A19982.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_1481:
			this.RTDBtnTrkPerEndTxOnVoiceAbsence_42461 = (global::AcpUI.AcpRtdButton)target;
			return;
			IL_148E:
			this.RTDBtnTrkPerCallPageInCallUserAlertEnable_A9434 = (global::AcpUI.AcpRtdButton)target;
			return;
			IL_149B:
			this.LblTrkPerTalkgroupTalkgroupFailsoft_A8005 = (global::AcpUI.AcpLabel)target;
			this.LblTrkPerTalkgroupTalkgroupFailsoft_A8005.MouseDoubleClick += new global::System.Windows.Input.MouseButtonEventHandler(this.OnFieldNameDoubleClick);
			return;
			IL_14BF:
			this.ExpanderTrunkingPersonalityPreferredSitesTableTableView = (global::AcpUI.AcpGroupBox)target;
			return;
			IL_14CC:
			this.TrkEmerProfGeneralKeySelect_A8970Comp = (global::AcpUI.AcpLabel)target;
			return;
			IL_14D9:
			this.LblTrkPerTalkgroupPriorityDispatch_43599 = (global::AcpUI.AcpLabel)target;
			this.LblTrkPerTalkgroupPriorityDispatch_43599.MouseDoubleClick += new global::System.Windows.Input.MouseButtonEventHandler(this.OnFieldNameDoubleClick);
			return;
			IL_14FD:
			this.TrkPerFeaturesTacticalPublicSafetyUIEnable = (global::AcpUI.AcpCheckBox)target;
			this.TrkPerFeaturesTacticalPublicSafetyUIEnable.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_1521:
			this.ExpanderTrunkingPersonalityLabtool = (global::AcpUI.AcpExpander)target;
			return;
			IL_152E:
			this.CpyBtnTrkPerAnnouncementGroupAGSecondaryFSRxFrequencyMHz_A8895 = (global::AcpUI.AcpCopyButton)target;
			return;
			IL_153B:
			this.TrkPerGeneralRevertChannel_A41917 = (global::AcpUI.AcpComboBox)target;
			this.TrkPerGeneralRevertChannel_A41917.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_155F:
			this.CpyBtnTrkPerCallPageInCallUserAlertEnable_A9434 = (global::AcpUI.AcpCopyButton)target;
			return;
			IL_156C:
			this.CpyBtnTrkPerPreferredSitesPreferredStatus_A8734 = (global::AcpUI.AcpCopyButton)target;
			return;
			IL_1579:
			this.LblTrkPerPreferredSitesSystemIDRFSSID_A9240 = (global::AcpUI.AcpLabel)target;
			this.LblTrkPerPreferredSitesSystemIDRFSSID_A9240.MouseDoubleClick += new global::System.Windows.Input.MouseButtonEventHandler(this.OnFieldNameDoubleClick);
			return;
			IL_159D:
			this.CpyBtnTrkPerAnnouncementGroupAGFailsoftRxFrequencyMHz_A9582 = (global::AcpUI.AcpCopyButton)target;
			return;
			IL_15AA:
			this.CpyBtnTrkPerAnnouncementGroupAstroOTARProfileIndex_43686 = (global::AcpUI.AcpCopyButton)target;
			return;
			IL_15B7:
			this.RTDBtnTrkPerPreferredSitesPreferredStatus_A8734 = (global::AcpUI.AcpRtdButton)target;
			return;
			IL_15C4:
			this.GrpBoxExpanderTrunkingPersonalityFeaturesPseudo3 = (global::AcpUI.AcpGroupBox)target;
			return;
			IL_15D1:
			this.RTDBtnTrkPerTalkgroupTGSecondaryFailsoft_A19989 = (global::AcpUI.AcpRtdButton)target;
			return;
			IL_15DE:
			this.CpyBtnTrkPerGeneralRevertZone_A41916 = (global::AcpUI.AcpCopyButton)target;
			return;
			IL_15EB:
			this.RTDBtnTrkPerGeneralTxFrequencyMHz_A9413 = (global::AcpUI.AcpRtdButton)target;
			return;
			IL_15F8:
			num = (short)1911517713;
			short num3 = num;
			num = (short)1041723921;
			switch ((num3 == num) ? 1 : 0)
			{
			case 0:
			case 2:
				IL_2F46:
				this.CVBtnTrkPerFeaturesHotKeypadDTMF_A8209 = (global::AcpUI.AcpCustomViewCheckBox)target;
				return;
			default:
				num = (short)1178664960;
				if (num != 0)
				{
				}
				this.RTDBtnTrkPerTalkgroupTxVoiceSignalType_A9575 = (global::AcpUI.AcpRtdButton)target;
				return;
			}
			IL_1650:
			this.ExpanderTrunkingPersonalityPreferredSitesTableSRecView = (global::AcpUI.AcpGroupBox)target;
			return;
			IL_165D:
			this.CpyBtnTrkPerGeneralProtocolType_A8767 = (global::AcpUI.AcpCopyButton)target;
			return;
			IL_166A:
			this.TrkPerGeneralSecondaryFailsoft_A19991 = (global::AcpUI.AcpCheckBox)target;
			this.TrkPerGeneralSecondaryFailsoft_A19991.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_168E:
			this.CVBtnTrkPerGeneralEmergencyRevertType_A41914 = (global::AcpUI.AcpCustomViewCheckBox)target;
			return;
			IL_169B:
			this.CVBtnTrkPerGeneralFailsoftType_A8599 = (global::AcpUI.AcpCustomViewCheckBox)target;
			return;
			IL_16A8:
			this.CVBtnTrkPerAnnouncementGroupAGSecureClearStrapping_A9089 = (global::AcpUI.AcpCustomViewCheckBox)target;
			return;
			IL_16B5:
			this.TrkPerGeneralStrictFailsoftbyTalkgroup_43782 = (global::AcpUI.AcpCheckBox)target;
			this.TrkPerGeneralStrictFailsoftbyTalkgroup_43782.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_16D9:
			this.TrkPerFeaturesMessageEnable_A8499 = (global::AcpUI.AcpCheckBox)target;
			this.TrkPerFeaturesMessageEnable_A8499.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_16FD:
			this.CpyBtnTrkPerFeatureBackupPTTOperation_A43628 = (global::AcpUI.AcpCopyButton)target;
			return;
			IL_170A:
			this.GrpBoxExpanderTrunkingPersonalityAnnouncementGroupPseudo0 = (global::AcpUI.AcpGroupBox)target;
			return;
			IL_1717:
			this.LblTrkPerTalkgroupTGWACNID_A19716 = (global::AcpUI.AcpLabel)target;
			this.LblTrkPerTalkgroupTGWACNID_A19716.MouseDoubleClick += new global::System.Windows.Input.MouseButtonEventHandler(this.OnFieldNameDoubleClick);
			return;
			IL_173B:
			this.ExpanderTrunkingPersonalityTalkgroupTableSRecView = (global::AcpUI.AcpGroupBox)target;
			return;
			IL_1748:
			this.CpyBtnTrkPerGeneralSecondaryTxFrequencyMHz_A12902 = (global::AcpUI.AcpCopyButton)target;
			return;
			IL_1755:
			this.TrkPerPreferredSitesPreferredStatus_A8734_Col = (global::Infragistics.Windows.DataPresenter.UnboundField)target;
			return;
			IL_1762:
			this.CVBtnTrkPerPreferredSitesWildcard_A43586 = (global::AcpUI.AcpCustomViewCheckBox)target;
			return;
			IL_176F:
			this.CVBtnTrkPerGeneralStrictFailsoftbyTalkgroup_43782 = (global::AcpUI.AcpCustomViewCheckBox)target;
			return;
			IL_177C:
			this.TrkPerFeaturesHazardZoneModePersonality = (global::AcpUI.AcpCheckBox)target;
			this.TrkPerFeaturesHazardZoneModePersonality.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_17A0:
			this.LblTrkPerTalkgroupTGSystemID_A19715 = (global::AcpUI.AcpLabel)target;
			this.LblTrkPerTalkgroupTGSystemID_A19715.MouseDoubleClick += new global::System.Windows.Input.MouseButtonEventHandler(this.OnFieldNameDoubleClick);
			return;
			IL_17C4:
			this.LblTrkPerTalkgroupSecondaryFailsoftRxFrequencyMHz_A8900 = (global::AcpUI.AcpLabel)target;
			this.LblTrkPerTalkgroupSecondaryFailsoftRxFrequencyMHz_A8900.MouseDoubleClick += new global::System.Windows.Input.MouseButtonEventHandler(this.OnFieldNameDoubleClick);
			return;
			IL_17E8:
			this.LblTrkSysGeneralKeyofTrunkingTalkgroup_A20742 = (global::AcpUI.AcpLabel)target;
			this.LblTrkSysGeneralKeyofTrunkingTalkgroup_A20742.MouseDoubleClick += new global::System.Windows.Input.MouseButtonEventHandler(this.OnFieldNameDoubleClick);
			return;
			IL_180C:
			this.CpyBtnTrkPerFeaturesAutomaticScan_A7528 = (global::AcpUI.AcpCopyButton)target;
			return;
			IL_1819:
			this.LblTrkPerTalkgroupKeySelect_A8365 = (global::AcpUI.AcpLabel)target;
			this.LblTrkPerTalkgroupKeySelect_A8365.MouseDoubleClick += new global::System.Windows.Input.MouseButtonEventHandler(this.OnFieldNameDoubleClick);
			return;
			IL_183D:
			this.LblTrkPerFeaturesDVRSProf_A41796 = (global::AcpUI.AcpLabel)target;
			this.LblTrkPerFeaturesDVRSProf_A41796.MouseDoubleClick += new global::System.Windows.Input.MouseButtonEventHandler(this.OnFieldNameDoubleClick);
			return;
			IL_1861:
			this.LblTrkPerEndTxOnVoiceAbsence_42461 = (global::AcpUI.AcpLabel)target;
			this.LblTrkPerEndTxOnVoiceAbsence_42461.MouseDoubleClick += new global::System.Windows.Input.MouseButtonEventHandler(this.OnFieldNameDoubleClick);
			return;
			IL_1885:
			this.CVBtnTrkPerGeneralDisableTransmitMode_A41742 = (global::AcpUI.AcpCustomViewCheckBox)target;
			return;
			IL_1892:
			this.TrkPerFeaturesHotKeypadDTMF_A8209 = (global::AcpUI.AcpCheckBox)target;
			this.TrkPerFeaturesHotKeypadDTMF_A8209.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_18B6:
			this.ThemeBaseObj = (global::AcpUI.Common.AcpThemeBase)target;
			return;
			IL_18C3:
			this.CpyBtnTrkPerLabtoolTrunkingPersonalityPreferredSiteStatusListItemID_A19962 = (global::AcpUI.AcpCopyButton)target;
			return;
			IL_18D0:
			this.CVBtnTrkPerGeneralConversationType_A7781 = (global::AcpUI.AcpCustomViewCheckBox)target;
			return;
			IL_18DD:
			this.LblTrkPerFeaturesMessageEnable_A8499 = (global::AcpUI.AcpLabel)target;
			this.LblTrkPerFeaturesMessageEnable_A8499.MouseDoubleClick += new global::System.Windows.Input.MouseButtonEventHandler(this.OnFieldNameDoubleClick);
			return;
			IL_1901:
			this.TrkPerTalkgroupSecureClearStrapping_A9095 = (global::AcpUI.AcpComboBox)target;
			this.TrkPerTalkgroupSecureClearStrapping_A9095.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_1925:
			this.LblTrkPerFeatureBackupPTTOperation_A43628 = (global::AcpUI.AcpLabel)target;
			this.LblTrkPerFeatureBackupPTTOperation_A43628.MouseDoubleClick += new global::System.Windows.Input.MouseButtonEventHandler(this.OnFieldNameDoubleClick);
			return;
			IL_1949:
			this.CVBtnTrkPerLabtoolTrunkingPersonalityAGTGFSListItemID_A21508 = (global::AcpUI.AcpCustomViewCheckBox)target;
			return;
			IL_1956:
			this.CVBtnTrkPerGeneralRxFrequencyMHz_A8910 = (global::AcpUI.AcpCustomViewCheckBox)target;
			return;
			IL_1963:
			this.TrkPerPreferredSitesSystemIDRFSSID_A9240 = (global::AcpUI.AcpTextBoxSpinnerDecHex)target;
			this.TrkPerPreferredSitesSystemIDRFSSID_A9240.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_1987:
			this.TrkPerTalkgroupAstroOTARProfileIndex_43687Comp = (global::AcpUI.AcpLabel)target;
			return;
			IL_1994:
			this.CpyBtnTrkPerAnnouncementGroupAGSecondaryFailsoft_A19990 = (global::AcpUI.AcpCopyButton)target;
			return;
			IL_19A1:
			this.CpyBtnTrkPerCallPageAutomaticCallAlert_A9754 = (global::AcpUI.AcpCopyButton)target;
			return;
			IL_19AE:
			this.TrkPerGeneralRxFrequencyMHz_A8910Comp = (global::AcpUI.AcpLabel)target;
			return;
			IL_19BB:
			this.CVBtnTrkPerGeneralSecondaryTxFrequencyMHz_A12902 = (global::AcpUI.AcpCustomViewCheckBox)target;
			return;
			IL_19C8:
			this.TrkPerFeaturesAutomaticScan_A7528 = (global::AcpUI.AcpCheckBox)target;
			this.TrkPerFeaturesAutomaticScan_A7528.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_19EC:
			this.TrkEmerProfGeneralVoiceSignalType_A7500Comp = (global::AcpUI.AcpLabel)target;
			return;
			IL_19F9:
			this.TrkPerTalkgroupSecondaryFailsoftRxFrequencyMHz_A8900Comp = (global::AcpUI.AcpLabel)target;
			return;
			IL_1A06:
			this.CpyBtnTrkPerLabtoolTrunkingPersonalityAGTGFSListItemID_A21508 = (global::AcpUI.AcpCopyButton)target;
			return;
			IL_1A13:
			this.RTDBtnTrkPerGeneralUnitID_A9593 = (global::AcpUI.AcpRtdButton)target;
			return;
			IL_1A20:
			this.TrkPerTalkgroupSecondaryFailsoftRxFrequencyMHz_A8900_Col = (global::Infragistics.Windows.DataPresenter.UnboundField)target;
			return;
			IL_1A2D:
			this.CVBtnTrkPerFeaturesTalkPermitTone_A9271 = (global::AcpUI.AcpCustomViewCheckBox)target;
			return;
			IL_1A3A:
			this.TrkPerTalkgroupTalkgroup_A9274Comp = (global::AcpUI.AcpTextBoxDecHex)target;
			return;
			IL_1A47:
			this.TrkPerTalkgroupPriorityDispatch_43599 = (global::AcpUI.AcpComboBox)target;
			this.TrkPerTalkgroupPriorityDispatch_43599.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_1A6B:
			this.TrkPerEndTxOnVoiceAbsence_42461 = (global::AcpUI.AcpCheckBox)target;
			this.TrkPerEndTxOnVoiceAbsence_42461.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_1A8F:
			this.CVBtnTrkPerPreferredSitesRASWACNID_A20445 = (global::AcpUI.AcpCustomViewCheckBox)target;
			return;
			IL_1A9C:
			this.TrkPerLabtoolTrunkingPersonalityPreferredSiteStatusListItemID_A19962Comp = (global::AcpUI.AcpLabel)target;
			return;
			IL_1AA9:
			this.CpyBtnTrkPerFeaturesStatusEnable_A9188 = (global::AcpUI.AcpCopyButton)target;
			return;
			IL_1AB6:
			this.CVBtnTrkPerFeaturesScanListSelection_A9053 = (global::AcpUI.AcpCustomViewCheckBox)target;
			return;
			IL_1AC3:
			this.TrkPerEndTxOnVoiceAbsence_42461Comp = (global::AcpUI.AcpCheckBox)target;
			return;
			IL_1AD0:
			this.RTDBtnTrkPerAnnouncementGroupAGSecondaryFailsoft_A19990 = (global::AcpUI.AcpRtdButton)target;
			return;
			IL_1ADD:
			this.LblTrkPerFeaturesPriorityDispatchTimeOutTimersec_43598 = (global::AcpUI.AcpLabel)target;
			this.LblTrkPerFeaturesPriorityDispatchTimeOutTimersec_43598.MouseDoubleClick += new global::System.Windows.Input.MouseButtonEventHandler(this.OnFieldNameDoubleClick);
			return;
			IL_1B01:
			this.TrkPerAnnouncementGroupAGSecondaryFailsoft_A19990Comp = (global::AcpUI.AcpCheckBox)target;
			return;
			IL_1B0E:
			num = (short)713555968;
			short num4 = num;
			this.CVBtnTrkPerGeneralTrunkingPersonalityName_A12659 = (global::AcpUI.AcpCustomViewCheckBox)target;
			return;
			IL_1B45:
			this.CVBtnTrkPerAnnouncementGroupAnnouncementGroupFailsoft_A8597 = (global::AcpUI.AcpCustomViewCheckBox)target;
			return;
			IL_1B52:
			this.TrkPerAnnouncementGroupAGVoiceSignalType_A7478 = (global::AcpUI.AcpComboBox)target;
			this.TrkPerAnnouncementGroupAGVoiceSignalType_A7478.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_1B76:
			this.GrpBoxExpanderTrunkingPersonalityGeneralTypeIIFailsoftByPersonality = (global::AcpUI.AcpGroupBox)target;
			return;
			IL_1B83:
			this.RTDBtnTrkPerCallPagePrivateCallOperation_A8759 = (global::AcpUI.AcpRtdButton)target;
			return;
			IL_1B90:
			this.LblTrkPerGeneralAdvancedRFAGC_A7409 = (global::AcpUI.AcpLabel)target;
			this.LblTrkPerGeneralAdvancedRFAGC_A7409.MouseDoubleClick += new global::System.Windows.Input.MouseButtonEventHandler(this.OnFieldNameDoubleClick);
			return;
			IL_1BB4:
			this.TrkPerFeatureDTMFMicEn_A42482Comp = (global::AcpUI.AcpCheckBox)target;
			return;
			IL_1BC1:
			this.CVBtnTrkPerEndTxOnVoiceAbsence_42461 = (global::AcpUI.AcpCustomViewCheckBox)target;
			return;
			IL_1BCE:
			this.TrkPerTalkgroupAstroOTARProfileIndex_43687_Col = (global::Infragistics.Windows.DataPresenter.UnboundField)target;
			return;
			IL_1BDB:
			this.LblTrkPerGeneralSystem_A9237 = (global::AcpUI.AcpLabel)target;
			this.LblTrkPerGeneralSystem_A9237.MouseDoubleClick += new global::System.Windows.Input.MouseButtonEventHandler(this.OnFieldNameDoubleClick);
			return;
			IL_1BFF:
			this.TrkPerLabtoolTrunkingPersonalityPreferredSiteStatusListItemID_A19962 = (global::AcpUI.AcpComboBox)target;
			this.TrkPerLabtoolTrunkingPersonalityPreferredSiteStatusListItemID_A19962.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_1C23:
			this.TrkPerAnnouncementGroupAnnouncementGroupFailsoft_A8597Comp = (global::AcpUI.AcpCheckBox)target;
			return;
			IL_1C30:
			this.RTDBtnTrkPerFeaturesSecureProperCodeDetect_A8763 = (global::AcpUI.AcpRtdButton)target;
			return;
			IL_1C3D:
			this.CpyBtnTrkPerGeneralSecondaryFailsoft_A19991 = (global::AcpUI.AcpCopyButton)target;
			return;
			IL_1C4A:
			this.TrkSysGeneralKeyofTrunkingTalkgroup_A20742_Col = (global::Infragistics.Windows.DataPresenter.UnboundField)target;
			return;
			IL_1C57:
			this.GrpBoxExpanderTrunkingPersonalityAnnouncementGroupPseudo1 = (global::AcpUI.AcpGroupBox)target;
			return;
			IL_1C64:
			this.CVBtnTrkPerIgnoreRxClearVoice_A41610 = (global::AcpUI.AcpCustomViewCheckBox)target;
			return;
			IL_1C71:
			this.RTDBtnTrkPerTalkgroupTalkgroup_A9274 = (global::AcpUI.AcpRtdButton)target;
			return;
			IL_1C7E:
			this.LblTrkPerPreferredSitesWildcard_A43586 = (global::AcpUI.AcpLabel)target;
			this.LblTrkPerPreferredSitesWildcard_A43586.MouseDoubleClick += new global::System.Windows.Input.MouseButtonEventHandler(this.OnFieldNameDoubleClick);
			return;
			IL_1CA2:
			this.TrkPerFeaturesDVRSProf_A41796 = (global::AcpUI.AcpComboBox)target;
			this.TrkPerFeaturesDVRSProf_A41796.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_1CC6:
			this.RTDBtnTrkPerFeaturesStatusEnable_A9188 = (global::AcpUI.AcpRtdButton)target;
			return;
			IL_1CD3:
			this.TrkPerFeaturesMessageEnable_A8499Comp = (global::AcpUI.AcpCheckBox)target;
			return;
			IL_1CE0:
			this.CpyBtnTrkPerGeneralSystem_A9237 = (global::AcpUI.AcpCopyButton)target;
			return;
			IL_1CED:
			this.RTDBtnTrkPerTalkgroupTalkgroupFailsoft_A8005 = (global::AcpUI.AcpRtdButton)target;
			return;
			IL_1CFA:
			this.LblTrkPerTalkgroupTxVoiceSignalType_A9575 = (global::AcpUI.AcpLabel)target;
			this.LblTrkPerTalkgroupTxVoiceSignalType_A9575.MouseDoubleClick += new global::System.Windows.Input.MouseButtonEventHandler(this.OnFieldNameDoubleClick);
			return;
			IL_1D1E:
			this.LblTrkPerAnnouncementGroupAGVoiceSignalType_A7478 = (global::AcpUI.AcpLabel)target;
			this.LblTrkPerAnnouncementGroupAGVoiceSignalType_A7478.MouseDoubleClick += new global::System.Windows.Input.MouseButtonEventHandler(this.OnFieldNameDoubleClick);
			return;
			IL_1D42:
			this.TrkPerFeaturesPriorityDispatchTimeOutTimersec_43598Comp = (global::AcpUI.AcpLabel)target;
			return;
			IL_1D4F:
			this.CVBtnTrkPerTalkgroupTalkgroupFailsoft_A8005 = (global::AcpUI.AcpCustomViewCheckBox)target;
			return;
			IL_1D5C:
			this.TrkPerGeneralTimeOutTimersec_A9379Comp = (global::AcpUI.AcpLabel)target;
			return;
			IL_1D69:
			this.RTDBtnTrkPerAnnouncementGroupAnnouncementGroup_A7444 = (global::AcpUI.AcpRtdButton)target;
			return;
			IL_1D76:
			this.CVBtnTrkPerAnnouncementGroupAGFailsoftTxFrequencyMHz_A9583 = (global::AcpUI.AcpCustomViewCheckBox)target;
			return;
			IL_1D83:
			this.LblTrkPerTalkgroupFailsoftRxFrequencyMHz_A8001 = (global::AcpUI.AcpLabel)target;
			this.LblTrkPerTalkgroupFailsoftRxFrequencyMHz_A8001.MouseDoubleClick += new global::System.Windows.Input.MouseButtonEventHandler(this.OnFieldNameDoubleClick);
			return;
			IL_1DA7:
			this.TrkPerFeaturesHazardZoneModePersonalityComp = (global::AcpUI.AcpCheckBox)target;
			return;
			IL_1DB4:
			this.LblTrkPerLabtoolTrunkingPersonalityAGTGFSListItemID_A21508 = (global::AcpUI.AcpLabel)target;
			this.LblTrkPerLabtoolTrunkingPersonalityAGTGFSListItemID_A21508.MouseDoubleClick += new global::System.Windows.Input.MouseButtonEventHandler(this.OnFieldNameDoubleClick);
			return;
			IL_1DD8:
			this.LblTrkPerCallPageCallAlertPageOperation_A7597 = (global::AcpUI.AcpLabel)target;
			this.LblTrkPerCallPageCallAlertPageOperation_A7597.MouseDoubleClick += new global::System.Windows.Input.MouseButtonEventHandler(this.OnFieldNameDoubleClick);
			return;
			IL_1DFC:
			this.RTDBtnTrkPerFeaturesTacticalPublicSafetyUIEnable = (global::AcpUI.AcpRtdButton)target;
			return;
			IL_1E09:
			this.CpyBtnTrkPerPreferredSitesAllowEmergencyAtBlockedSite_44910 = (global::AcpUI.AcpCopyButton)target;
			return;
			IL_1E16:
			this.CVBtnTrkPerTalkgroupTGSecondaryFailsoft_A19989 = (global::AcpUI.AcpCustomViewCheckBox)target;
			return;
			IL_1E23:
			this.GrpBoxExpanderTrunkingPersonalityCallPagePseudo0 = (global::AcpUI.AcpGroupBox)target;
			return;
			IL_1E30:
			this.LblTrkPerTalkgroupTalkgroup_A9274 = (global::AcpUI.AcpLabel)target;
			this.LblTrkPerTalkgroupTalkgroup_A9274.MouseDoubleClick += new global::System.Windows.Input.MouseButtonEventHandler(this.OnFieldNameDoubleClick);
			return;
			IL_1E54:
			this.LblTrkPerGeneralEmergencyRevertType_A41914 = (global::AcpUI.AcpLabel)target;
			this.LblTrkPerGeneralEmergencyRevertType_A41914.MouseDoubleClick += new global::System.Windows.Input.MouseButtonEventHandler(this.OnFieldNameDoubleClick);
			return;
			IL_1E78:
			this.CVBtnTrkPerGeneralRevertZone_A41916 = (global::AcpUI.AcpCustomViewCheckBox)target;
			return;
			IL_1E85:
			this.RTDBtnTrkPerLabtoolTrunkingPersonalityTalkGroupAliasListItemID_A19960 = (global::AcpUI.AcpRtdButton)target;
			return;
			IL_1E92:
			this.GrpBoxExpanderTrunkingPersonalityFeaturesScan = (global::AcpUI.AcpGroupBox)target;
			return;
			IL_1E9F:
			this.TrkPerTalkgroupTxVoiceSignalType_A9575Comp = (global::AcpUI.AcpLabel)target;
			return;
			IL_1EAC:
			this.TrkPerGeneralBroadbandProtection = (global::AcpUI.AcpCheckBox)target;
			this.TrkPerGeneralBroadbandProtection.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_1ED0:
			this.CVBtnTrkPerGeneralSystem_A9237 = (global::AcpUI.AcpCustomViewCheckBox)target;
			return;
			IL_1EDD:
			this.LblTrkPerFeaturesHotKeypadDTMF_A8209 = (global::AcpUI.AcpLabel)target;
			this.LblTrkPerFeaturesHotKeypadDTMF_A8209.MouseDoubleClick += new global::System.Windows.Input.MouseButtonEventHandler(this.OnFieldNameDoubleClick);
			return;
			IL_1F01:
			this.TrkPerTalkgroupFailsoftTxFrequencyMHz_A8003 = (global::AcpUI.AcpTextBox)target;
			this.TrkPerTalkgroupFailsoftTxFrequencyMHz_A8003.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_1F25:
			this.CpyBtnTrkPerAnnouncementGroupAGSecureClearStrapping_A9089 = (global::AcpUI.AcpCopyButton)target;
			return;
			IL_1F32:
			this.RTDBtnTrkPerPreferredSitesRASWACNID_A20445 = (global::AcpUI.AcpRtdButton)target;
			return;
			IL_1F3F:
			this.TrkPerAnnouncementGroupAGVoiceSignalType_A7478Comp = (global::AcpUI.AcpLabel)target;
			return;
			IL_1F4C:
			this.RTDBtnTrkPerAnnouncementGroupAstroOTARProfileIndex_43686 = (global::AcpUI.AcpRtdButton)target;
			return;
			IL_1F59:
			this.TrkPerTalkgroupFailsoftRxFrequencyMHz_A8001 = (global::AcpUI.AcpTextBox)target;
			this.TrkPerTalkgroupFailsoftRxFrequencyMHz_A8001.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_1F7D:
			this.TrkPerCallPageHotListItemID_A19982Comp = (global::AcpUI.AcpLabel)target;
			return;
			IL_1F8A:
			this.RTDBtnTrkPerGeneralRevertZone_A41916 = (global::AcpUI.AcpRtdButton)target;
			return;
			IL_1F97:
			this.CpyBtnTrkPerGeneralRevertChannel_A41917 = (global::AcpUI.AcpCopyButton)target;
			return;
			IL_1FA4:
			this.RTDBtnTrkPerFeatureDTMFMicEn_A42482 = (global::AcpUI.AcpRtdButton)target;
			return;
			IL_1FB1:
			this.CpyBtnTrkPerCallPageHotListItemID_A19982 = (global::AcpUI.AcpCopyButton)target;
			return;
			IL_1FBE:
			this.RTDBtnTrkPerAnnouncementGroupAGVoiceSignalType_A7478 = (global::AcpUI.AcpRtdButton)target;
			return;
			IL_1FCB:
			this.TrkPerGeneralRevertZone_A41916Comp = (global::AcpUI.AcpLabel)target;
			return;
			IL_1FD8:
			this.LblTrkEmerProfGeneralKeySelect_A8970 = (global::AcpUI.AcpLabel)target;
			this.LblTrkEmerProfGeneralKeySelect_A8970.MouseDoubleClick += new global::System.Windows.Input.MouseButtonEventHandler(this.OnFieldNameDoubleClick);
			return;
			IL_1FFC:
			this.CVBtnTrkPerFeaturesAutomaticScan_A7528 = (global::AcpUI.AcpCustomViewCheckBox)target;
			return;
			IL_2009:
			this.RTDBtnTrkPerGeneralSecondaryFailsoft_A19991 = (global::AcpUI.AcpRtdButton)target;
			return;
			IL_2016:
			this.TrkPerFeaturesPhoneOperation_A8701 = (global::AcpUI.AcpComboBox)target;
			this.TrkPerFeaturesPhoneOperation_A8701.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_203A:
			this.TrkPerTalkgroupTxVoiceSignalType_A9575_Col = (global::Infragistics.Windows.DataPresenter.UnboundField)target;
			return;
			IL_2047:
			this.TrkPerTalkgroupFailsoftRxFrequencyMHz_A8001Comp = (global::AcpUI.AcpLabel)target;
			return;
			IL_2054:
			this.RTDBtnTrkPerIgnoreRxClearVoice_A41610 = (global::AcpUI.AcpRtdButton)target;
			return;
			IL_2061:
			this.CVBtnTrkPerTalkgroupKeySelect_A8365 = (global::AcpUI.AcpCustomViewCheckBox)target;
			return;
			IL_206E:
			this.LblTrkPerCallPagePrivateCallOperation_A8759 = (global::AcpUI.AcpLabel)target;
			this.LblTrkPerCallPagePrivateCallOperation_A8759.MouseDoubleClick += new global::System.Windows.Input.MouseButtonEventHandler(this.OnFieldNameDoubleClick);
			return;
			IL_2092:
			this.TrkPerTalkgroupTalkgroupFailsoft_A8005Comp = (global::AcpUI.AcpCheckBox)target;
			return;
			IL_209F:
			this.CpyBtnTrkPerGeneralDisableTransmitMode_A41742 = (global::AcpUI.AcpCopyButton)target;
			return;
			IL_20AC:
			this.TrkPerPreferredSitesSiteID_A9151_Col = (global::Infragistics.Windows.DataPresenter.UnboundField)target;
			return;
			IL_20B9:
			this.TrkPerTalkgroupFailsoftTxFrequencyMHz_A8003_Col = (global::Infragistics.Windows.DataPresenter.UnboundField)target;
			return;
			IL_20C6:
			this.TrkPerGeneralProtocolType_A8767 = (global::AcpUI.AcpComboBox)target;
			this.TrkPerGeneralProtocolType_A8767.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_20EA:
			this.ExpanderTrunkingPersonalityTalkgroupTableGrid = (global::System.Windows.Controls.Grid)target;
			return;
			IL_20F7:
			this.TrkPerFeaturesSecureProperCodeDetect_A8763Comp = (global::AcpUI.AcpCheckBox)target;
			return;
			IL_2104:
			this.CpyBtnTrkPerAnnouncementGroupAnnouncementGroupFailsoft_A8597 = (global::AcpUI.AcpCopyButton)target;
			return;
			IL_2111:
			this.MyStackPanel = (global::System.Windows.Controls.StackPanel)target;
			return;
			IL_211E:
			this.TrkPerAnnouncementGroupAGFailsoftTxFrequencyMHz_A9583 = (global::AcpUI.AcpTextBox)target;
			this.TrkPerAnnouncementGroupAGFailsoftTxFrequencyMHz_A9583.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_2142:
			this.CVBtnTrkPerFeaturesDVRSProf_A41796 = (global::AcpUI.AcpCustomViewCheckBox)target;
			return;
			IL_214F:
			this.HLinkLabtool = (global::System.Windows.Documents.Hyperlink)target;
			this.HLinkLabtool.Click += this.HLinkClick;
			return;
			IL_2173:
			this.CVBtnTrkPerLabtoolTrunkingPersonalityTalkGroupAliasListItemID_A19960 = (global::AcpUI.AcpCustomViewCheckBox)target;
			return;
			IL_2180:
			this.TrkPerIgnoreRxClearVoice_A41610Comp = (global::AcpUI.AcpCheckBox)target;
			return;
			IL_218D:
			this.CVBtnTrkPerAnnouncementGroupAGSecondaryFailsoft_A19990 = (global::AcpUI.AcpCustomViewCheckBox)target;
			return;
			IL_219A:
			this.GrpBoxExpanderTrunkingPersonalityGeneralSystemInfo = (global::AcpUI.AcpGroupBox)target;
			return;
			IL_21A7:
			this.CpyBtnTrkPerGeneralConversationType_A7781 = (global::AcpUI.AcpCopyButton)target;
			return;
			IL_21B4:
			this.RTDBtnTrkPerFeaturesDVRSProf_A41796 = (global::AcpUI.AcpRtdButton)target;
			return;
			IL_21C1:
			this.LblTrkPerAnnouncementGroupAGFailsoftRxFrequencyMHz_A9582 = (global::AcpUI.AcpLabel)target;
			this.LblTrkPerAnnouncementGroupAGFailsoftRxFrequencyMHz_A9582.MouseDoubleClick += new global::System.Windows.Input.MouseButtonEventHandler(this.OnFieldNameDoubleClick);
			return;
			IL_21E5:
			this.CpyBtnTrkPerAnnouncementGroupAGFailsoftTxFrequencyMHz_A9583 = (global::AcpUI.AcpCopyButton)target;
			return;
			IL_21F2:
			this.CpyBtnTrkPerTalkgroupTalkgroupFailsoft_A8005 = (global::AcpUI.AcpCopyButton)target;
			return;
			IL_21FF:
			this.TrkPerGeneralTimeOutTimersec_A9379 = (global::AcpUI.AcpTextBoxSpinner)target;
			this.TrkPerGeneralTimeOutTimersec_A9379.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_2223:
			this.TrkPerPreferredSitesSystemIDRFSSID_A9240Comp = (global::AcpUI.AcpTextBoxDecHex)target;
			return;
			IL_2230:
			this.RTDBtnTrkPerGeneralRevertChannel_A41917 = (global::AcpUI.AcpRtdButton)target;
			return;
			IL_223D:
			this.TrkPerGeneralDisableTransmitMode_A41742 = (global::AcpUI.AcpComboBox)target;
			this.TrkPerGeneralDisableTransmitMode_A41742.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_2261:
			this.CpyBtnTrkPerPreferredSitesWildcard_A43586 = (global::AcpUI.AcpCopyButton)target;
			return;
			IL_226E:
			this.TrkPerTalkgroupTGSystemID_A19715Comp = (global::AcpUI.AcpTextBoxDecHex)target;
			return;
			IL_227B:
			this.CpyBtnTrkPerPreferredSitesIgnoreSiteResourcePreference_A8239 = (global::AcpUI.AcpCopyButton)target;
			return;
			IL_2288:
			this.HLinkCallPage = (global::System.Windows.Documents.Hyperlink)target;
			this.HLinkCallPage.Click += this.HLinkClick;
			return;
			IL_22AC:
			this.LblTrkPerGeneralSystemID_A9238 = (global::AcpUI.AcpLabel)target;
			this.LblTrkPerGeneralSystemID_A9238.MouseDoubleClick += new global::System.Windows.Input.MouseButtonEventHandler(this.OnFieldNameDoubleClick);
			return;
			IL_22D0:
			this.CpyBtnTrkPerCallPagePrivateCallType_A8760 = (global::AcpUI.AcpCopyButton)target;
			return;
			IL_22DD:
			this.GrpBoxExpanderTrunkingPersonalityGeneralEmergencySystemRevert = (global::AcpUI.AcpGroupBox)target;
			return;
			IL_22EA:
			this.TrkEmerProfGeneralSecureClearStrapping_A9092 = (global::AcpUI.AcpComboBox)target;
			this.TrkEmerProfGeneralSecureClearStrapping_A9092.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_230E:
			this.RTDBtnTrkPerPreferredSitesSystemID_A19466 = (global::AcpUI.AcpRtdButton)target;
			return;
			IL_231B:
			this.LblTrkPerFeaturesHazardZoneModePersonality = (global::AcpUI.AcpLabel)target;
			this.LblTrkPerFeaturesHazardZoneModePersonality.MouseDoubleClick += new global::System.Windows.Input.MouseButtonEventHandler(this.OnFieldNameDoubleClick);
			return;
			IL_233F:
			this.CpyBtnTrkPerFeaturesTalkPermitTone_A9271 = (global::AcpUI.AcpCopyButton)target;
			return;
			IL_234C:
			this.gridExpanderTrunkingPersonalityTalkgroupTableSRecView = (global::System.Windows.Controls.Grid)target;
			return;
			IL_2359:
			this.RTDBtnTrkPerLabtoolSystemKey_A9242 = (global::AcpUI.AcpRtdButton)target;
			return;
			IL_2366:
			this.TrkPerTalkgroupPriorityDispatch_43599Comp = (global::AcpUI.AcpLabel)target;
			return;
			IL_2373:
			this.RTDBtnTrkPerLabtoolTrunkingEmergencyProfileCompositeItemID_A19980 = (global::AcpUI.AcpRtdButton)target;
			return;
			IL_2380:
			this.TrkPerTalkgroupSecondaryFailsoftRxFrequencyMHz_A8900 = (global::AcpUI.AcpTextBox)target;
			this.TrkPerTalkgroupSecondaryFailsoftRxFrequencyMHz_A8900.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_23A4:
			this.TrkPerPreferredSitesWildcard_A43586Comp = (global::AcpUI.AcpLabel)target;
			return;
			IL_23B1:
			this.CpyBtnTrkPerIgnoreRxClearVoice_A41610 = (global::AcpUI.AcpCopyButton)target;
			return;
			IL_23BE:
			this.TrkPerAnnouncementGroupAnnouncementGroup_A7444 = (global::AcpUI.AcpTextBoxCustomDecHex)target;
			this.TrkPerAnnouncementGroupAnnouncementGroup_A7444.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_23E2:
			this.RTDBtnTrkPerGeneralProtocolType_A8767 = (global::AcpUI.AcpRtdButton)target;
			return;
			IL_23EF:
			this.CpyBtnTrkPerFeaturesDVRSProf_A41796 = (global::AcpUI.AcpCopyButton)target;
			return;
			IL_23FC:
			this.ExpanderTrunkingPersonalityAnnouncementGroup = (global::AcpUI.AcpExpander)target;
			return;
			IL_2409:
			this.TrkPerPreferredSitesWildcard_A43586 = (global::AcpUI.AcpComboBox)target;
			this.TrkPerPreferredSitesWildcard_A43586.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_242D:
			this.CpyBtnTrkPerFeaturesTacticalPublicSafetyUIEnable = (global::AcpUI.AcpCopyButton)target;
			return;
			IL_243A:
			this.RTDBtnTrkPerCallPageAutomaticCallAlert_A9754 = (global::AcpUI.AcpRtdButton)target;
			return;
			IL_2447:
			this.LblTrkPerAnnouncementGroupAGFailsoftTxFrequencyMHz_A9583 = (global::AcpUI.AcpLabel)target;
			this.LblTrkPerAnnouncementGroupAGFailsoftTxFrequencyMHz_A9583.MouseDoubleClick += new global::System.Windows.Input.MouseButtonEventHandler(this.OnFieldNameDoubleClick);
			return;
			IL_246B:
			this.CVBtnTrkEmerProfGeneralKeySelect_A8970 = (global::AcpUI.AcpCustomViewCheckBox)target;
			return;
			IL_2478:
			this.ExpanderTrunkingPersonalityTalkgroup = (global::AcpUI.AcpExpander)target;
			return;
			IL_2485:
			this.CpyBtnTrkPerGeneralSecondaryRxFrequencyMHz_A8904 = (global::AcpUI.AcpCopyButton)target;
			return;
			IL_2492:
			this.TrkPerGeneralFailsoftType_A8599 = (global::AcpUI.AcpComboBox)target;
			this.TrkPerGeneralFailsoftType_A8599.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_24B6:
			this.TrkSysGeneralKeyofTrunkingTalkgroup_A20742Comp = (global::AcpUI.AcpLabel)target;
			return;
			IL_24C3:
			this.CVBtnTrkPerAnnouncementGroupAGVoiceSignalType_A7478 = (global::AcpUI.AcpCustomViewCheckBox)target;
			return;
			IL_24D0:
			this.CVBtnTrkPerTalkgroupAstroOTARProfileIndex_43687 = (global::AcpUI.AcpCustomViewCheckBox)target;
			return;
			IL_24DD:
			this.TrkPerFeaturesDVRSProf_A41796Comp = (global::AcpUI.AcpLabel)target;
			return;
			IL_24EA:
			this.TrkPerGeneralConversationType_A7781Comp = (global::AcpUI.AcpLabel)target;
			return;
			IL_24F7:
			this.TrkPerPreferredSitesRASWACNID_A20445_Col = (global::Infragistics.Windows.DataPresenter.UnboundField)target;
			return;
			IL_2504:
			this.LblTrkPerPreferredSitesSystemID_A19466 = (global::AcpUI.AcpLabel)target;
			this.LblTrkPerPreferredSitesSystemID_A19466.MouseDoubleClick += new global::System.Windows.Input.MouseButtonEventHandler(this.OnFieldNameDoubleClick);
			return;
			IL_2528:
			this.TrkPerAnnouncementGroupAGFailsoftTxFrequencyMHz_A9583Comp = (global::AcpUI.AcpLabel)target;
			return;
			IL_2535:
			this.CpyBtnTrkPerLabtoolSystemKey_A9242 = (global::AcpUI.AcpCopyButton)target;
			return;
			IL_2542:
			this.LblTrkPerIgnoreRxClearVoice_A41610 = (global::AcpUI.AcpLabel)target;
			this.LblTrkPerIgnoreRxClearVoice_A41610.MouseDoubleClick += new global::System.Windows.Input.MouseButtonEventHandler(this.OnFieldNameDoubleClick);
			return;
			IL_2566:
			this.TrkPerLabtoolTrunkingPersonalityAGTGFSListItemID_A21508Comp = (global::AcpUI.AcpLabel)target;
			return;
			IL_2573:
			this.RTDBtnTrkPerFeaturesHotKeypadDTMF_A8209 = (global::AcpUI.AcpRtdButton)target;
			return;
			IL_2580:
			this.TrkPerGeneralSystemID_A9238 = (global::AcpUI.AcpTextBoxDecHex)target;
			this.TrkPerGeneralSystemID_A9238.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_25A4:
			this.LblTrkPerLabtoolSystemKey_A9242 = (global::AcpUI.AcpLabel)target;
			this.LblTrkPerLabtoolSystemKey_A9242.MouseDoubleClick += new global::System.Windows.Input.MouseButtonEventHandler(this.OnFieldNameDoubleClick);
			return;
			IL_25C8:
			this.TrkPerCallPageCallAlertPageOperation_A7597 = (global::AcpUI.AcpComboBox)target;
			this.TrkPerCallPageCallAlertPageOperation_A7597.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_25EC:
			this.RTDBtnTrkPerTalkgroupTGSystemID_A19715 = (global::AcpUI.AcpRtdButton)target;
			return;
			IL_25F9:
			this.RTDBtnTrkPerGeneralBroadbandProtection = (global::AcpUI.AcpRtdButton)target;
			return;
			IL_2606:
			this.CpyBtnTrkPerFeaturesPriorityDispatchTimeOutTimersec_43598 = (global::AcpUI.AcpCopyButton)target;
			return;
			IL_2613:
			this.CVBtnTrkPerGeneralBroadbandProtection = (global::AcpUI.AcpCustomViewCheckBox)target;
			return;
			IL_2620:
			this.TrkPerFeaturesTacticalPublicSafetyUIEnableComp = (global::AcpUI.AcpCheckBox)target;
			return;
			IL_262D:
			this.CpyBtnTrkPerTalkgroupSecondaryFailsoftTxFrequencyMHz_A8902 = (global::AcpUI.AcpCopyButton)target;
			return;
			IL_263A:
			this.CpyBtnTrkPerAnnouncementGroupAGKeySelect_A7414 = (global::AcpUI.AcpCopyButton)target;
			return;
			IL_2647:
			this.CVBtnTrkPerCallPagePrivateCallOperation_A8759 = (global::AcpUI.AcpCustomViewCheckBox)target;
			return;
			IL_2654:
			this.TrkEmerProfGeneralTalkgroup_A8969Comp = (global::AcpUI.AcpTextBoxDecHex)target;
			return;
			IL_2661:
			this.RTDBtnTrkPerPreferredSitesSystemIDRFSSID_A9240 = (global::AcpUI.AcpRtdButton)target;
			return;
			IL_266E:
			this.TrkPerFeaturesAstroAlertingToneTable = (global::AcpUI.AcpComboBox)target;
			this.TrkPerFeaturesAstroAlertingToneTable.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_2692:
			this.RTDBtnTrkPerCallPageCallAlertPageOperation_A7597 = (global::AcpUI.AcpRtdButton)target;
			return;
			IL_269F:
			this.GrpBoxExpanderTrunkingPersonalityGeneralPseudo0 = (global::AcpUI.AcpGroupBox)target;
			return;
			IL_26AC:
			this.TrkPerAnnouncementGroupAGSecondaryFSRxFrequencyMHz_A8895Comp = (global::AcpUI.AcpLabel)target;
			return;
			IL_26B9:
			this.LblTrkPerFeaturesStatusEnable_A9188 = (global::AcpUI.AcpLabel)target;
			this.LblTrkPerFeaturesStatusEnable_A9188.MouseDoubleClick += new global::System.Windows.Input.MouseButtonEventHandler(this.OnFieldNameDoubleClick);
			return;
			IL_26DD:
			this.TrkPerAnnouncementGroupAGFailsoftRxFrequencyMHz_A9582 = (global::AcpUI.AcpTextBox)target;
			this.TrkPerAnnouncementGroupAGFailsoftRxFrequencyMHz_A9582.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_2701:
			this.TrkPerPreferredSitesAllowEmergencyAtBlockedSite_44910Comp = (global::AcpUI.AcpCheckBox)target;
			return;
			IL_270E:
			this.TrkPerGeneralAdvancedRFAGC_A7409 = (global::AcpUI.AcpComboBox)target;
			this.TrkPerGeneralAdvancedRFAGC_A7409.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_2732:
			this.RecNavToolbarExpanderTrunkingPersonalityPreferredSitesTable = (global::AcpUI.AcpChildRecNavToolbar)target;
			this.RecNavToolbarExpanderTrunkingPersonalityPreferredSitesTable.ModeClick += this.OnModeClick;
			return;
			IL_2756:
			this.CVBtnTrkPerAnnouncementGroupAGFailsoftRxFrequencyMHz_A9582 = (global::AcpUI.AcpCustomViewCheckBox)target;
			return;
			IL_2763:
			this.TrkPerTalkgroupFailsoftRxFrequencyMHz_A8001_Col = (global::Infragistics.Windows.DataPresenter.UnboundField)target;
			return;
			IL_2770:
			this.TrkPerPreferredSitesWildcard_A43586_Col = (global::Infragistics.Windows.DataPresenter.UnboundField)target;
			return;
			IL_277D:
			this.LblTrkPerFeaturesScanListSelection_A9053 = (global::AcpUI.AcpLabel)target;
			this.LblTrkPerFeaturesScanListSelection_A9053.MouseDoubleClick += new global::System.Windows.Input.MouseButtonEventHandler(this.OnFieldNameDoubleClick);
			return;
			IL_27A1:
			this.LblTrkPerAnnouncementGroupAGSystemID_A19705 = (global::AcpUI.AcpLabel)target;
			this.LblTrkPerAnnouncementGroupAGSystemID_A19705.MouseDoubleClick += new global::System.Windows.Input.MouseButtonEventHandler(this.OnFieldNameDoubleClick);
			return;
			IL_27C5:
			this.RTDBtnTrkPerAnnouncementGroupAnnouncementGroupFailsoft_A8597 = (global::AcpUI.AcpRtdButton)target;
			return;
			IL_27D2:
			this.CpyBtnTrkPerCallPagePrivateCallOperation_A8759 = (global::AcpUI.AcpCopyButton)target;
			return;
			IL_27DF:
			this.TrkPerCallPagePrivateCallType_A8760Comp = (global::AcpUI.AcpLabel)target;
			return;
			IL_27EC:
			this.RTDBtnTrkPerFeatureBackupPTTOperation_A43628 = (global::AcpUI.AcpRtdButton)target;
			return;
			IL_27F9:
			this.TrkPerTalkgroupFailsoftTxFrequencyMHz_A8003Comp = (global::AcpUI.AcpLabel)target;
			return;
			IL_2806:
			this.LblTrkPerGeneralProtocolType_A8767 = (global::AcpUI.AcpLabel)target;
			this.LblTrkPerGeneralProtocolType_A8767.MouseDoubleClick += new global::System.Windows.Input.MouseButtonEventHandler(this.OnFieldNameDoubleClick);
			return;
			IL_282A:
			this.CpyBtnTrkPerTalkgroupSecureClearStrapping_A9095 = (global::AcpUI.AcpCopyButton)target;
			return;
			IL_2837:
			this.TrkPerLabtoolTrunkingEmergencyProfileCompositeItemID_A19980Comp = (global::AcpUI.AcpLabel)target;
			return;
			IL_2844:
			this.LblTrkPerLabtoolTrunkingPersonalityTalkGroupAliasListItemID_A19960 = (global::AcpUI.AcpLabel)target;
			this.LblTrkPerLabtoolTrunkingPersonalityTalkGroupAliasListItemID_A19960.MouseDoubleClick += new global::System.Windows.Input.MouseButtonEventHandler(this.OnFieldNameDoubleClick);
			return;
			IL_2868:
			this.TrkPerGeneralSecondaryRxFrequencyMHz_A8904Comp = (global::AcpUI.AcpLabel)target;
			return;
			IL_2875:
			this.LblTrkPerGeneralTimeOutTimersec_A9379 = (global::AcpUI.AcpLabel)target;
			this.LblTrkPerGeneralTimeOutTimersec_A9379.MouseDoubleClick += new global::System.Windows.Input.MouseButtonEventHandler(this.OnFieldNameDoubleClick);
			return;
			IL_2899:
			this.CVBtnTrkPerLabtoolTrunkingEmergencyProfileCompositeItemID_A19980 = (global::AcpUI.AcpCustomViewCheckBox)target;
			return;
			IL_28A6:
			this.CpyBtnTrkPerTalkgroupPriorityDispatch_43599 = (global::AcpUI.AcpCopyButton)target;
			return;
			IL_28B3:
			this.TrkPerGeneralRevertZone_A41916 = (global::AcpUI.AcpComboBox)target;
			this.TrkPerGeneralRevertZone_A41916.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_28D7:
			this.RTDBtnTrkPerAnnouncementGroupAGSecondaryFSTxFrequencyMHz_A12903 = (global::AcpUI.AcpRtdButton)target;
			return;
			IL_28E4:
			this.CVBtnTrkPerTalkgroupSecondaryFailsoftRxFrequencyMHz_A8900 = (global::AcpUI.AcpCustomViewCheckBox)target;
			return;
			IL_28F1:
			this.LblTrkPerGeneralBroadbandProtection = (global::AcpUI.AcpLabel)target;
			this.LblTrkPerGeneralBroadbandProtection.MouseDoubleClick += new global::System.Windows.Input.MouseButtonEventHandler(this.OnFieldNameDoubleClick);
			return;
			IL_2915:
			this.CpyBtnTrkPerFeaturesScanListSelection_A9053 = (global::AcpUI.AcpCopyButton)target;
			return;
			IL_2922:
			this.LblTrkPerAnnouncementGroupAGSecondaryFailsoft_A19990 = (global::AcpUI.AcpLabel)target;
			this.LblTrkPerAnnouncementGroupAGSecondaryFailsoft_A19990.MouseDoubleClick += new global::System.Windows.Input.MouseButtonEventHandler(this.OnFieldNameDoubleClick);
			return;
			IL_2946:
			this.LblTrkPerAnnouncementGroupAGSecondaryFSTxFrequencyMHz_A12903 = (global::AcpUI.AcpLabel)target;
			this.LblTrkPerAnnouncementGroupAGSecondaryFSTxFrequencyMHz_A12903.MouseDoubleClick += new global::System.Windows.Input.MouseButtonEventHandler(this.OnFieldNameDoubleClick);
			return;
			IL_296A:
			this.TrkPerTalkgroupTGWACNID_A19716_Col = (global::Infragistics.Windows.DataPresenter.UnboundField)target;
			return;
			IL_2977:
			this.RTDBtnTrkEmerProfGeneralTalkgroup_A8969 = (global::AcpUI.AcpRtdButton)target;
			return;
			IL_2984:
			this.TrkPerPreferredSitesPreferredStatus_A8734Comp = (global::AcpUI.AcpLabel)target;
			return;
			IL_2991:
			this.CVBtnTrkPerLabtoolTrunkingPersonalityPreferredSiteStatusListItemID_A19962 = (global::AcpUI.AcpCustomViewCheckBox)target;
			return;
			IL_299E:
			this.CVBtnTrkEmerProfGeneralVoiceSignalType_A7500 = (global::AcpUI.AcpCustomViewCheckBox)target;
			return;
			IL_29AB:
			this.ExpanderTrunkingPersonalityTalkgroupTableTableView = (global::AcpUI.AcpGroupBox)target;
			return;
			IL_29B8:
			this.TrkPerGeneralStrictFailsoftbyTalkgroup_43782Comp = (global::AcpUI.AcpCheckBox)target;
			return;
			IL_29C5:
			this.LblTrkPerFeaturesAutomaticScan_A7528 = (global::AcpUI.AcpLabel)target;
			this.LblTrkPerFeaturesAutomaticScan_A7528.MouseDoubleClick += new global::System.Windows.Input.MouseButtonEventHandler(this.OnFieldNameDoubleClick);
			return;
			IL_29E9:
			this.RTDBtnTrkEmerProfGeneralVoiceSignalType_A7500 = (global::AcpUI.AcpRtdButton)target;
			return;
			IL_29F6:
			this.LblTrkPerCallPageInCallUserAlertEnable_A9434 = (global::AcpUI.AcpLabel)target;
			this.LblTrkPerCallPageInCallUserAlertEnable_A9434.MouseDoubleClick += new global::System.Windows.Input.MouseButtonEventHandler(this.OnFieldNameDoubleClick);
			return;
			IL_2A1A:
			this.TrkPerGeneralSecondaryTxFrequencyMHz_A12902 = (global::AcpUI.AcpTextBox)target;
			this.TrkPerGeneralSecondaryTxFrequencyMHz_A12902.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_2A3E:
			this.TrkPerFeaturesStatusEnable_A9188Comp = (global::AcpUI.AcpCheckBox)target;
			return;
			IL_2A4B:
			this.CVBtnTrkPerTalkgroupTalkgroup_A9274 = (global::AcpUI.AcpCustomViewCheckBox)target;
			return;
			IL_2A58:
			this.TrkPerAnnouncementGroupAstroOTARProfileIndex_43686Comp = (global::AcpUI.AcpLabel)target;
			return;
			IL_2A65:
			this.CVBtnTrkPerPreferredSitesIgnoreSiteResourcePreference_A8239 = (global::AcpUI.AcpCustomViewCheckBox)target;
			return;
			IL_2A72:
			this.RTDBtnTrkPerGeneralSecondaryTxFrequencyMHz_A12902 = (global::AcpUI.AcpRtdButton)target;
			return;
			IL_2A7F:
			this.TrkPerPreferredSitesRASWACNID_A20445Comp = (global::AcpUI.AcpTextBoxDecHex)target;
			return;
			IL_2A8C:
			this.LblTrkPerTalkgroupTGSecondaryFailsoft_A19989 = (global::AcpUI.AcpLabel)target;
			this.LblTrkPerTalkgroupTGSecondaryFailsoft_A19989.MouseDoubleClick += new global::System.Windows.Input.MouseButtonEventHandler(this.OnFieldNameDoubleClick);
			return;
			IL_2AB0:
			this.RTDBtnTrkPerGeneralSystemID_A9238 = (global::AcpUI.AcpRtdButton)target;
			return;
			IL_2ABD:
			this.TrkPerGeneralDisableTransmitMode_A41742Comp = (global::AcpUI.AcpLabel)target;
			return;
			IL_2ACA:
			this.ExpanderTrunkingPersonalityTalkgroupGrid = (global::System.Windows.Controls.Grid)target;
			return;
			IL_2AD7:
			this.CpyBtnTrkPerTalkgroupTalkgroup_A9274 = (global::AcpUI.AcpCopyButton)target;
			return;
			IL_2AE4:
			this.CpyBtnTrkPerFeaturesAstroAlertingToneTable = (global::AcpUI.AcpCopyButton)target;
			return;
			IL_2AF1:
			this.LblTrkPerPreferredSitesAllowEmergencyAtBlockedSite_44910 = (global::AcpUI.AcpLabel)target;
			this.LblTrkPerPreferredSitesAllowEmergencyAtBlockedSite_44910.MouseDoubleClick += new global::System.Windows.Input.MouseButtonEventHandler(this.OnFieldNameDoubleClick);
			return;
			IL_2B15:
			this.CVBtnTrkPerAnnouncementGroupAnnouncementGroup_A7444 = (global::AcpUI.AcpCustomViewCheckBox)target;
			return;
			IL_2B22:
			this.CpyBtnTrkPerTalkgroupFailsoftTxFrequencyMHz_A8003 = (global::AcpUI.AcpCopyButton)target;
			return;
			IL_2B2F:
			this.ExpanderTrunkingPersonalityPreferredSitesTableGrid = (global::System.Windows.Controls.Grid)target;
			return;
			IL_2B3C:
			this.ExpanderTrunkingPersonalityCallPage = (global::AcpUI.AcpExpander)target;
			return;
			IL_2B49:
			this.LblTrkPerFeaturesTalkPermitTone_A9271 = (global::AcpUI.AcpLabel)target;
			this.LblTrkPerFeaturesTalkPermitTone_A9271.MouseDoubleClick += new global::System.Windows.Input.MouseButtonEventHandler(this.OnFieldNameDoubleClick);
			return;
			IL_2B6D:
			this.CVBtnTrkEmerProfGeneralSecureClearStrapping_A9092 = (global::AcpUI.AcpCustomViewCheckBox)target;
			return;
			IL_2B7A:
			this.TrkPerGeneralSecondaryTxFrequencyMHz_A12902Comp = (global::AcpUI.AcpLabel)target;
			return;
			IL_2B87:
			this.TrkPerFeatureDTMFMicEn_A42482 = (global::AcpUI.AcpCheckBox)target;
			this.TrkPerFeatureDTMFMicEn_A42482.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_2BAB:
			this.TrkPerTalkgroupSecondaryFailsoftTxFrequencyMHz_A8902Comp = (global::AcpUI.AcpLabel)target;
			return;
			IL_2BB8:
			this.LblTrkPerAnnouncementGroupAnnouncementGroupFailsoft_A8597 = (global::AcpUI.AcpLabel)target;
			this.LblTrkPerAnnouncementGroupAnnouncementGroupFailsoft_A8597.MouseDoubleClick += new global::System.Windows.Input.MouseButtonEventHandler(this.OnFieldNameDoubleClick);
			return;
			IL_2BDC:
			this.CpyBtnTrkPerPreferredSitesRASWACNID_A20445 = (global::AcpUI.AcpCopyButton)target;
			return;
			IL_2BE9:
			this.CpyBtnTrkPerGeneralAdvancedRFAGC_A7409 = (global::AcpUI.AcpCopyButton)target;
			return;
			IL_2BF6:
			this.TrkPerFeaturesTalkPermitTone_A9271 = (global::AcpUI.AcpCheckBox)target;
			this.TrkPerFeaturesTalkPermitTone_A9271.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_2C1A:
			this.CVBtnTrkPerFeaturesAstroAlertingToneTable = (global::AcpUI.AcpCustomViewCheckBox)target;
			return;
			IL_2C27:
			this.CpyBtnTrkPerTalkgroupSecondaryFailsoftRxFrequencyMHz_A8900 = (global::AcpUI.AcpCopyButton)target;
			return;
			IL_2C34:
			this.RTDBtnTrkPerGeneralFailsoftType_A8599 = (global::AcpUI.AcpRtdButton)target;
			return;
			IL_2C41:
			this.CpyBtnTrkPerPreferredSitesSystemIDRFSSID_A9240 = (global::AcpUI.AcpCopyButton)target;
			return;
			IL_2C4E:
			this.TrkPerPreferredSitesIgnoreSiteResourcePreference_A8239Comp = (global::AcpUI.AcpCheckBox)target;
			return;
			IL_2C5B:
			this.TrkPerLabtoolSystemKey_A9242Comp = (global::AcpUI.AcpLabel)target;
			return;
			IL_2C68:
			this.TrkPerAnnouncementGroupAGSecondaryFSRxFrequencyMHz_A8895 = (global::AcpUI.AcpTextBox)target;
			this.TrkPerAnnouncementGroupAGSecondaryFSRxFrequencyMHz_A8895.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_2C8C:
			this.TrkPerLabtoolTrunkingPersonalityTalkGroupAliasListItemID_A19960Comp = (global::AcpUI.AcpLabel)target;
			return;
			IL_2C99:
			this.CpyBtnTrkPerAnnouncementGroupAGSecondaryFSTxFrequencyMHz_A12903 = (global::AcpUI.AcpCopyButton)target;
			return;
			IL_2CA6:
			this.TrkPerIgnoreRxClearVoice_A41610 = (global::AcpUI.AcpCheckBox)target;
			this.TrkPerIgnoreRxClearVoice_A41610.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_2CCA:
			this.TrkPerGeneralUnitID_A9593 = (global::AcpUI.AcpTextBoxDecHex)target;
			this.TrkPerGeneralUnitID_A9593.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_2CEE:
			this.RTDBtnTrkPerTalkgroupSecureClearStrapping_A9095 = (global::AcpUI.AcpRtdButton)target;
			return;
			IL_2CFB:
			this.CVBtnTrkPerGeneralSecondaryFailsoft_A19991 = (global::AcpUI.AcpCustomViewCheckBox)target;
			return;
			IL_2D08:
			this.TrkPerCallPagePrivateCallType_A8760 = (global::AcpUI.AcpComboBox)target;
			this.TrkPerCallPagePrivateCallType_A8760.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_2D2C:
			this.CVBtnTrkPerCallPageCallAlertPageOperation_A7597 = (global::AcpUI.AcpCustomViewCheckBox)target;
			return;
			IL_2D39:
			this.CpyBtnTrkPerCallPageCallAlertPageOperation_A7597 = (global::AcpUI.AcpCopyButton)target;
			return;
			IL_2D46:
			this.TrkPerGeneralFailsoftType_A8599Comp = (global::AcpUI.AcpLabel)target;
			return;
			IL_2D53:
			this.LblTrkPerPreferredSitesRASWACNID_A20445 = (global::AcpUI.AcpLabel)target;
			this.LblTrkPerPreferredSitesRASWACNID_A20445.MouseDoubleClick += new global::System.Windows.Input.MouseButtonEventHandler(this.OnFieldNameDoubleClick);
			return;
			IL_2D77:
			this.RTDBtnTrkPerLabtoolTrunkingPersonalityAGTGFSListItemID_A21508 = (global::AcpUI.AcpRtdButton)target;
			return;
			IL_2D84:
			this.RTDBtnTrkPerTalkgroupTGWACNID_A19716 = (global::AcpUI.AcpRtdButton)target;
			return;
			IL_2D91:
			this.RTDBtnTrkPerGeneralSystem_A9237 = (global::AcpUI.AcpRtdButton)target;
			return;
			IL_2D9E:
			this.TrkPerFeaturesScanListSelection_A9053Comp = (global::AcpUI.AcpLabel)target;
			return;
			IL_2DAB:
			this.CVBtnTrkPerFeaturesSecureProperCodeDetect_A8763 = (global::AcpUI.AcpCustomViewCheckBox)target;
			return;
			IL_2DB8:
			this.RTDBtnTrkPerTalkgroupSecondaryFailsoftRxFrequencyMHz_A8900 = (global::AcpUI.AcpRtdButton)target;
			return;
			IL_2DC5:
			this.CpyBtnTrkPerTalkgroupTGSecondaryFailsoft_A19989 = (global::AcpUI.AcpCopyButton)target;
			return;
			IL_2DD2:
			this.CVBtnTrkPerLabtoolSystemKey_A9242 = (global::AcpUI.AcpCustomViewCheckBox)target;
			return;
			IL_2DDF:
			this.RTDBtnTrkPerLabtoolTrunkingPersonalityPreferredSiteStatusListItemID_A19962 = (global::AcpUI.AcpRtdButton)target;
			return;
			IL_2DEC:
			this.LblTrkPerAnnouncementGroupAstroOTARProfileIndex_43686 = (global::AcpUI.AcpLabel)target;
			this.LblTrkPerAnnouncementGroupAstroOTARProfileIndex_43686.MouseDoubleClick += new global::System.Windows.Input.MouseButtonEventHandler(this.OnFieldNameDoubleClick);
			return;
			IL_2E10:
			this.TrkPerAnnouncementGroupAGWACNID_A19706Comp = (global::AcpUI.AcpTextBoxDecHex)target;
			return;
			IL_2E1D:
			this.CpyBtnTrkPerGeneralBroadbandProtection = (global::AcpUI.AcpCopyButton)target;
			return;
			IL_2E2A:
			this.TrkPerGeneralConversationType_A7781 = (global::AcpUI.AcpComboBox)target;
			this.TrkPerGeneralConversationType_A7781.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_2E4E:
			this.CpyBtnTrkSysGeneralKeyofTrunkingTalkgroup_A20742 = (global::AcpUI.AcpCopyButton)target;
			return;
			IL_2E5B:
			this.GrpBoxExpanderTrunkingPersonalityFeaturesStatusMessage = (global::AcpUI.AcpGroupBox)target;
			return;
			IL_2E68:
			this.TrkSysGeneralKeyofTrunkingTalkgroup_A20742 = (global::AcpUI.AcpTextBox)target;
			this.TrkSysGeneralKeyofTrunkingTalkgroup_A20742.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_2E8C:
			this.LblTrkPerGeneralRevertZone_A41916 = (global::AcpUI.AcpLabel)target;
			this.LblTrkPerGeneralRevertZone_A41916.MouseDoubleClick += new global::System.Windows.Input.MouseButtonEventHandler(this.OnFieldNameDoubleClick);
			return;
			IL_2EB0:
			this.TrkPerLabtoolSystemKey_A9242 = (global::AcpUI.AcpLabel)target;
			this.TrkPerLabtoolSystemKey_A9242.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_2ED4:
			this.CVBtnTrkPerPreferredSitesSystemID_A19466 = (global::AcpUI.AcpCustomViewCheckBox)target;
			return;
			IL_2EE1:
			this.TrkEmerProfGeneralKeySelect_A8970 = (global::AcpUI.AcpComboBox)target;
			this.TrkEmerProfGeneralKeySelect_A8970.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_2F05:
			this.CVBtnTrkPerCallPagePrivateCallType_A8760 = (global::AcpUI.AcpCustomViewCheckBox)target;
			return;
			IL_2F12:
			this.CVBtnTrkPerTalkgroupPriorityDispatch_43599 = (global::AcpUI.AcpCustomViewCheckBox)target;
			return;
			IL_2F1F:
			this.CpyBtnTrkEmerProfGeneralKeySelect_A8970 = (global::AcpUI.AcpCopyButton)target;
			return;
			IL_2F2C:
			this.TrkPerPreferredSitesSiteListType_A43581Comp = (global::AcpUI.AcpLabel)target;
			return;
			IL_2F39:
			this.RTDBtnTrkPerPreferredSitesSiteID_A9151 = (global::AcpUI.AcpRtdButton)target;
			return;
			IL_2F53:
			this.TrkPerFeaturesPriorityDispatchTimeOutTimersec_43598 = (global::AcpUI.AcpTextBoxSpinner)target;
			this.TrkPerFeaturesPriorityDispatchTimeOutTimersec_43598.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_2F77:
			this.GrpBoxExpanderTrunkingPersonalityGeneralPseudo1 = (global::AcpUI.AcpGroupBox)target;
			return;
			IL_2F84:
			this.TrkPerTalkgroupTalkgroupFailsoft_A8005 = (global::AcpUI.AcpCheckBox)target;
			this.TrkPerTalkgroupTalkgroupFailsoft_A8005.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_2FA8:
			this.TrkPerFeaturesAstroAlertingToneTableComp = (global::AcpUI.AcpLabel)target;
			return;
			IL_2FB5:
			this.CpyBtnTrkPerTalkgroupTGSystemID_A19715 = (global::AcpUI.AcpCopyButton)target;
			return;
			IL_2FC2:
			this.RTDBtnTrkPerGeneralStrictFailsoftbyTalkgroup_43782 = (global::AcpUI.AcpRtdButton)target;
			return;
			IL_2FCF:
			this.TrkPerAnnouncementGroupAGWACNID_A19706 = (global::AcpUI.AcpTextBoxSpinnerDecHex)target;
			this.TrkPerAnnouncementGroupAGWACNID_A19706.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_2FF3:
			this.RTDBtnTrkPerAnnouncementGroupAGSecondaryFSRxFrequencyMHz_A8895 = (global::AcpUI.AcpRtdButton)target;
			return;
			IL_3000:
			this.TrkPerPreferredSitesSystemID_A19466 = (global::AcpUI.AcpTextBoxSpinnerDecHex)target;
			this.TrkPerPreferredSitesSystemID_A19466.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_3024:
			this.CVBtnTrkPerTalkgroupTxVoiceSignalType_A9575 = (global::AcpUI.AcpCustomViewCheckBox)target;
			return;
			IL_3031:
			this.GrpBoxExpanderTrunkingPersonalityFeaturesPseudo0 = (global::AcpUI.AcpGroupBox)target;
			return;
			IL_303E:
			this.TrkPerPreferredSitesSystemID_A19466Comp = (global::AcpUI.AcpTextBoxDecHex)target;
			return;
			IL_304B:
			this.LblTrkPerFeaturesTacticalPublicSafetyUIEnable = (global::AcpUI.AcpLabel)target;
			this.LblTrkPerFeaturesTacticalPublicSafetyUIEnable.MouseDoubleClick += new global::System.Windows.Input.MouseButtonEventHandler(this.OnFieldNameDoubleClick);
			return;
			IL_306F:
			this.CpyBtnTrkPerTalkgroupFailsoftRxFrequencyMHz_A8001 = (global::AcpUI.AcpCopyButton)target;
			return;
			IL_307C:
			this.CpyBtnTrkPerAnnouncementGroupAGVoiceSignalType_A7478 = (global::AcpUI.AcpCopyButton)target;
			return;
			IL_3089:
			this.RTDBtnTrkPerPreferredSitesSiteListType_A43581 = (global::AcpUI.AcpRtdButton)target;
			return;
			IL_3096:
			this.TrkPerLabtoolTrunkingPersonalityTalkGroupAliasListItemID_A19960 = (global::AcpUI.AcpComboBox)target;
			this.TrkPerLabtoolTrunkingPersonalityTalkGroupAliasListItemID_A19960.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_30BA:
			this.CVBtnTrkPerPreferredSitesSiteID_A9151 = (global::AcpUI.AcpCustomViewCheckBox)target;
			return;
			IL_30C7:
			this.RTDBtnTrkPerTalkgroupFailsoftTxFrequencyMHz_A8003 = (global::AcpUI.AcpRtdButton)target;
			return;
			IL_30D4:
			this.TrkPerGeneralSecondaryRxFrequencyMHz_A8904 = (global::AcpUI.AcpTextBox)target;
			this.TrkPerGeneralSecondaryRxFrequencyMHz_A8904.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_30F8:
			this.TrkPerCallPageCallAlertPageOperation_A7597Comp = (global::AcpUI.AcpLabel)target;
			return;
			IL_3105:
			this.TrkPerTalkgroupTGWACNID_A19716 = (global::AcpUI.AcpTextBoxSpinnerDecHex)target;
			this.TrkPerTalkgroupTGWACNID_A19716.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_3129:
			this.TrkPerFeaturesHotKeypadDTMF_A8209Comp = (global::AcpUI.AcpCheckBox)target;
			return;
			IL_3136:
			this.TrkPerFeaturesScanListSelection_A9053 = (global::AcpUI.AcpComboBox)target;
			this.TrkPerFeaturesScanListSelection_A9053.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_315A:
			this.TrkPerGeneralEmergencyRevertType_A41914Comp = (global::AcpUI.AcpLabel)target;
			return;
			IL_3167:
			this.LblTrkPerCallPagePrivateCallType_A8760 = (global::AcpUI.AcpLabel)target;
			this.LblTrkPerCallPagePrivateCallType_A8760.MouseDoubleClick += new global::System.Windows.Input.MouseButtonEventHandler(this.OnFieldNameDoubleClick);
			return;
			IL_318B:
			this.CVBtnTrkPerCallPageAutomaticCallAlert_A9754 = (global::AcpUI.AcpCustomViewCheckBox)target;
			return;
			IL_3198:
			this.TrkPerPreferredSitesIgnoreSiteResourcePreference_A8239 = (global::AcpUI.AcpCheckBox)target;
			this.TrkPerPreferredSitesIgnoreSiteResourcePreference_A8239.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_31BC:
			this.TrkPerAnnouncementGroupAnnouncementGroup_A7444Comp = (global::AcpUI.AcpTextBoxCustomDecHex)target;
			return;
			IL_31C9:
			this.TrkPerTalkgroupSecondaryFailsoftTxFrequencyMHz_A8902_Col = (global::Infragistics.Windows.DataPresenter.UnboundField)target;
			return;
			IL_31D6:
			this.RTDBtnTrkPerGeneralEmergencyRevertType_A41914 = (global::AcpUI.AcpRtdButton)target;
			return;
			IL_31E3:
			this.LblTrkPerGeneralRxFrequencyMHz_A8910 = (global::AcpUI.AcpLabel)target;
			this.LblTrkPerGeneralRxFrequencyMHz_A8910.MouseDoubleClick += new global::System.Windows.Input.MouseButtonEventHandler(this.OnFieldNameDoubleClick);
			return;
			IL_3207:
			this.CpyBtnTrkPerEndTxOnVoiceAbsence_42461 = (global::AcpUI.AcpCopyButton)target;
			return;
			IL_3214:
			this.RTDBtnTrkPerPreferredSitesWildcard_A43586 = (global::AcpUI.AcpRtdButton)target;
			return;
			IL_3221:
			this.CpyBtnTrkPerFeaturesSecureProperCodeDetect_A8763 = (global::AcpUI.AcpCopyButton)target;
			return;
			IL_322E:
			this.RTDBtnTrkPerAnnouncementGroupAGWACNID_A19706 = (global::AcpUI.AcpRtdButton)target;
			return;
			IL_323B:
			this.LblTrkPerAnnouncementGroupAGSecondaryFSRxFrequencyMHz_A8895 = (global::AcpUI.AcpLabel)target;
			this.LblTrkPerAnnouncementGroupAGSecondaryFSRxFrequencyMHz_A8895.MouseDoubleClick += new global::System.Windows.Input.MouseButtonEventHandler(this.OnFieldNameDoubleClick);
			return;
			IL_325F:
			this.GrpBoxExpanderTrunkingPersonalityGeneralEmergencyTalkbackRevert = (global::AcpUI.AcpGroupBox)target;
			return;
			IL_326C:
			this.RTDBtnTrkPerPreferredSitesIgnoreSiteResourcePreference_A8239 = (global::AcpUI.AcpRtdButton)target;
			return;
			IL_3279:
			this.LblTrkPerLabtoolTrunkingEmergencyProfileCompositeItemID_A19980 = (global::AcpUI.AcpLabel)target;
			this.LblTrkPerLabtoolTrunkingEmergencyProfileCompositeItemID_A19980.MouseDoubleClick += new global::System.Windows.Input.MouseButtonEventHandler(this.OnFieldNameDoubleClick);
			return;
			IL_329D:
			this.CVBtnTrkPerFeaturesMessageEnable_A8499 = (global::AcpUI.AcpCustomViewCheckBox)target;
			return;
			IL_32AA:
			this.RTDBtnTrkPerFeaturesAutomaticScan_A7528 = (global::AcpUI.AcpRtdButton)target;
			return;
			IL_32B7:
			this.TrkPerTalkgroupKeySelect_A8365_Col = (global::Infragistics.Windows.DataPresenter.UnboundField)target;
			return;
			IL_32C4:
			this.CpyBtnTrkPerGeneralStrictFailsoftbyTalkgroup_43782 = (global::AcpUI.AcpCopyButton)target;
			return;
			IL_32D1:
			this.CpyBtnTrkPerFeaturesHazardZoneModePersonality = (global::AcpUI.AcpCopyButton)target;
			return;
			IL_32DE:
			this.RTDBtnTrkEmerProfGeneralSecureClearStrapping_A9092 = (global::AcpUI.AcpRtdButton)target;
			return;
			IL_32EB:
			this.RTDBtnTrkPerGeneralConversationType_A7781 = (global::AcpUI.AcpRtdButton)target;
			return;
			IL_32F8:
			this.LblTrkPerAnnouncementGroupAGKeySelect_A7414 = (global::AcpUI.AcpLabel)target;
			this.LblTrkPerAnnouncementGroupAGKeySelect_A7414.MouseDoubleClick += new global::System.Windows.Input.MouseButtonEventHandler(this.OnFieldNameDoubleClick);
			return;
			IL_331C:
			this.CVBtnTrkPerPreferredSitesSystemIDRFSSID_A9240 = (global::AcpUI.AcpCustomViewCheckBox)target;
			return;
			IL_3329:
			this.TrkPerFeaturesAutomaticScan_A7528Comp = (global::AcpUI.AcpCheckBox)target;
			return;
			IL_3336:
			this.TrkPerAnnouncementGroupAstroOTARProfileIndex_43686 = (global::AcpUI.AcpComboBox)target;
			this.TrkPerAnnouncementGroupAstroOTARProfileIndex_43686.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_335A:
			this.TrkPerAnnouncementGroupAGSecureClearStrapping_A9089 = (global::AcpUI.AcpComboBox)target;
			this.TrkPerAnnouncementGroupAGSecureClearStrapping_A9089.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_337E:
			this.RTDBtnTrkPerGeneralDisableTransmitMode_A41742 = (global::AcpUI.AcpRtdButton)target;
			return;
			IL_338B:
			this.RTDBtnTrkPerFeaturesAstroAlertingToneTable = (global::AcpUI.AcpRtdButton)target;
			return;
			IL_3398:
			this.CVBtnTrkPerGeneralUnitID_A9593 = (global::AcpUI.AcpCustomViewCheckBox)target;
			return;
			IL_33A5:
			this.LblTrkPerGeneralConversationType_A7781 = (global::AcpUI.AcpLabel)target;
			this.LblTrkPerGeneralConversationType_A7781.MouseDoubleClick += new global::System.Windows.Input.MouseButtonEventHandler(this.OnFieldNameDoubleClick);
			return;
			IL_33C9:
			this.CpyBtnTrkEmerProfGeneralTalkgroup_A8969 = (global::AcpUI.AcpCopyButton)target;
			return;
			IL_33D6:
			this.LblTrkPerPreferredSitesSiteListType_A43581 = (global::AcpUI.AcpLabel)target;
			this.LblTrkPerPreferredSitesSiteListType_A43581.MouseDoubleClick += new global::System.Windows.Input.MouseButtonEventHandler(this.OnFieldNameDoubleClick);
			return;
			IL_33FA:
			this.TrkPerAnnouncementGroupAGSecureClearStrapping_A9089Comp = (global::AcpUI.AcpLabel)target;
			return;
			IL_3407:
			this.TrkPerPreferredSitesRASWACNID_A20445 = (global::AcpUI.AcpTextBoxSpinnerDecHex)target;
			this.TrkPerPreferredSitesRASWACNID_A20445.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_342B:
			this.TrkPerTalkgroupTalkgroup_A9274_Col = (global::Infragistics.Windows.DataPresenter.UnboundField)target;
			return;
			IL_3438:
			this.TrkPerTalkgroupKeySelect_A8365Comp = (global::AcpUI.AcpLabel)target;
			return;
			IL_3445:
			this.HLinkTalkgroup = (global::System.Windows.Documents.Hyperlink)target;
			this.HLinkTalkgroup.Click += this.HLinkClick;
			return;
			IL_3469:
			this.TrkPerAnnouncementGroupAGSecondaryFSTxFrequencyMHz_A12903 = (global::AcpUI.AcpTextBox)target;
			this.TrkPerAnnouncementGroupAGSecondaryFSTxFrequencyMHz_A12903.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_348D:
			this.TrkPerGeneralBroadbandProtectionComp = (global::AcpUI.AcpCheckBox)target;
			return;
			IL_349A:
			this.TrkPerTalkgroupTalkgroupFailsoft_A8005_Col = (global::Infragistics.Windows.DataPresenter.UnboundField)target;
			return;
			IL_34A7:
			this.TrkPerGeneralAdvancedRFAGC_A7409Comp = (global::AcpUI.AcpLabel)target;
			return;
			IL_34B4:
			this.CVBtnTrkPerPreferredSitesAllowEmergencyAtBlockedSite_44910 = (global::AcpUI.AcpCustomViewCheckBox)target;
			return;
			IL_34C1:
			this.RTDBtnTrkPerFeaturesPriorityDispatchTimeOutTimersec_43598 = (global::AcpUI.AcpRtdButton)target;
			return;
			IL_34CE:
			this.ExpanderTrunkingPersonalityPreferredSitesTable = (global::AcpUI.AcpXamDataPresenter)target;
			return;
			IL_34DB:
			this.CVBtnTrkPerAnnouncementGroupAGSecondaryFSTxFrequencyMHz_A12903 = (global::AcpUI.AcpCustomViewCheckBox)target;
			return;
			IL_34E8:
			this.CVBtnTrkPerCallPageHotListItemID_A19982 = (global::AcpUI.AcpCustomViewCheckBox)target;
			return;
			IL_34F5:
			this.TrkPerGeneralTrunkingPersonalityName_A12659Comp = (global::AcpUI.AcpLabel)target;
			return;
			IL_3502:
			this.CpyBtnTrkPerLabtoolTrunkingEmergencyProfileCompositeItemID_A19980 = (global::AcpUI.AcpCopyButton)target;
			return;
			IL_350F:
			this.RTDBtnTrkPerTalkgroupPriorityDispatch_43599 = (global::AcpUI.AcpRtdButton)target;
			return;
			IL_351C:
			this.CpyBtnTrkPerPreferredSitesSiteID_A9151 = (global::AcpUI.AcpCopyButton)target;
			return;
			IL_3529:
			this.TrkPerGeneralSystem_A9237 = (global::AcpUI.AcpComboBox)target;
			this.TrkPerGeneralSystem_A9237.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_354D:
			this.CVBtnTrkPerTalkgroupSecondaryFailsoftTxFrequencyMHz_A8902 = (global::AcpUI.AcpCustomViewCheckBox)target;
			return;
			IL_355A:
			this.gridExpanderTrunkingPersonalityPreferredSitesTableSRecView = (global::System.Windows.Controls.Grid)target;
			return;
			IL_3567:
			this.LblTrkPerPreferredSitesPreferredStatus_A8734 = (global::AcpUI.AcpLabel)target;
			this.LblTrkPerPreferredSitesPreferredStatus_A8734.MouseDoubleClick += new global::System.Windows.Input.MouseButtonEventHandler(this.OnFieldNameDoubleClick);
			return;
			IL_358B:
			this.TrkPerAnnouncementGroupAGSystemID_A19705Comp = (global::AcpUI.AcpTextBoxDecHex)target;
			return;
			IL_3598:
			this.LblTrkPerGeneralSecondaryTxFrequencyMHz_A12902 = (global::AcpUI.AcpLabel)target;
			this.LblTrkPerGeneralSecondaryTxFrequencyMHz_A12902.MouseDoubleClick += new global::System.Windows.Input.MouseButtonEventHandler(this.OnFieldNameDoubleClick);
			return;
			IL_35BC:
			this.RTDBtnTrkPerPreferredSitesAllowEmergencyAtBlockedSite_44910 = (global::AcpUI.AcpRtdButton)target;
			return;
			IL_35C9:
			this.TrkPerTalkgroupTGSystemID_A19715 = (global::AcpUI.AcpTextBoxSpinnerDecHex)target;
			this.TrkPerTalkgroupTGSystemID_A19715.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_35ED:
			this.HLinkFeatures = (global::System.Windows.Documents.Hyperlink)target;
			this.HLinkFeatures.Click += this.HLinkClick;
			return;
			IL_3611:
			this.TrkPerPreferredSitesSystemIDRFSSID_A9240_Col = (global::Infragistics.Windows.DataPresenter.UnboundField)target;
			return;
			IL_361E:
			this.ExpanderTrunkingPersonalityPreferredSitesGrid = (global::System.Windows.Controls.Grid)target;
			return;
			IL_362B:
			this.CVBtnTrkPerGeneralProtocolType_A8767 = (global::AcpUI.AcpCustomViewCheckBox)target;
			return;
			IL_3638:
			this.TrkPerFeatureBackupPTTOperation_A43628 = (global::AcpUI.AcpComboBox)target;
			this.TrkPerFeatureBackupPTTOperation_A43628.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_365C:
			this.CpyBtnTrkPerTalkgroupKeySelect_A8365 = (global::AcpUI.AcpCopyButton)target;
			return;
			IL_3669:
			this.RTDBtnTrkPerGeneralTimeOutTimersec_A9379 = (global::AcpUI.AcpRtdButton)target;
			return;
			IL_3676:
			this.TrkPerTalkgroupTGSecondaryFailsoft_A19989 = (global::AcpUI.AcpCheckBox)target;
			this.TrkPerTalkgroupTGSecondaryFailsoft_A19989.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_369A:
			this.CpyBtnTrkPerPreferredSitesSystemID_A19466 = (global::AcpUI.AcpCopyButton)target;
			return;
			IL_36A7:
			this.ExpanderTrunkingPersonalityPreferredSites = (global::AcpUI.AcpExpander)target;
			return;
			IL_36B4:
			this.RTDBtnTrkPerFeaturesMessageEnable_A8499 = (global::AcpUI.AcpRtdButton)target;
			return;
			IL_36C1:
			this.CVBtnTrkPerGeneralTimeOutTimersec_A9379 = (global::AcpUI.AcpCustomViewCheckBox)target;
			return;
			IL_36CE:
			this.TrkPerCallPagePrivateCallOperation_A8759Comp = (global::AcpUI.AcpLabel)target;
			return;
			IL_36DB:
			this.TrkPerGeneralProtocolType_A8767Comp = (global::AcpUI.AcpLabel)target;
			return;
			IL_36E8:
			this.CpyBtnTrkPerLabtoolTrunkingPersonalityTalkGroupAliasListItemID_A19960 = (global::AcpUI.AcpCopyButton)target;
			return;
			IL_36F5:
			this.CpyBtnTrkPerGeneralEmergencyRevertType_A41914 = (global::AcpUI.AcpCopyButton)target;
			return;
			IL_3702:
			this.LblTrkPerGeneralStrictFailsoftbyTalkgroup_43782 = (global::AcpUI.AcpLabel)target;
			this.LblTrkPerGeneralStrictFailsoftbyTalkgroup_43782.MouseDoubleClick += new global::System.Windows.Input.MouseButtonEventHandler(this.OnFieldNameDoubleClick);
			return;
			IL_3726:
			this.CpyBtnTrkEmerProfGeneralVoiceSignalType_A7500 = (global::AcpUI.AcpCopyButton)target;
			return;
			IL_3733:
			this.TrkPerTalkgroupSecureClearStrapping_A9095Comp = (global::AcpUI.AcpLabel)target;
			return;
			IL_3740:
			this.HLinkPreferredSites = (global::System.Windows.Documents.Hyperlink)target;
			this.HLinkPreferredSites.Click += this.HLinkClick;
			return;
			IL_3764:
			this.TrkEmerProfGeneralVoiceSignalType_A7500 = (global::AcpUI.AcpComboBox)target;
			this.TrkEmerProfGeneralVoiceSignalType_A7500.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_3788:
			this.CpyBtnTrkPerFeaturesMessageEnable_A8499 = (global::AcpUI.AcpCopyButton)target;
			return;
			IL_3795:
			this.TrkPerGeneralEmergencyRevertType_A41914 = (global::AcpUI.AcpComboBox)target;
			this.TrkPerGeneralEmergencyRevertType_A41914.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_37D0:
			goto IL_3A41;
			IL_37D5:
			this.TrkPerGeneralSecondaryFailsoft_A19991Comp = (global::AcpUI.AcpCheckBox)target;
			return;
			IL_37E2:
			this.LblTrkPerGeneralDisableTransmitMode_A41742 = (global::AcpUI.AcpLabel)target;
			this.LblTrkPerGeneralDisableTransmitMode_A41742.MouseDoubleClick += new global::System.Windows.Input.MouseButtonEventHandler(this.OnFieldNameDoubleClick);
			return;
			IL_3806:
			this.CVBtnTrkPerGeneralSystemID_A9238 = (global::AcpUI.AcpCustomViewCheckBox)target;
			return;
			IL_3813:
			this.RTDBtnTrkPerFeaturesPhoneOperation_A8701 = (global::AcpUI.AcpRtdButton)target;
			return;
			IL_3820:
			this.CpyBtnTrkPerPreferredSitesSiteListType_A43581 = (global::AcpUI.AcpCopyButton)target;
			return;
			IL_382D:
			this.CpyBtnTrkPerAnnouncementGroupAGWACNID_A19706 = (global::AcpUI.AcpCopyButton)target;
			return;
			IL_383A:
			this.CVBtnTrkPerTalkgroupSecureClearStrapping_A9095 = (global::AcpUI.AcpCustomViewCheckBox)target;
			return;
			IL_3847:
			this.TrkPerGeneralTxFrequencyMHz_A9413Comp = (global::AcpUI.AcpLabel)target;
			return;
			IL_3854:
			this.TrkPerCallPageAutomaticCallAlert_A9754Comp = (global::AcpUI.AcpCheckBox)target;
			return;
			IL_3861:
			this.LblTrkPerAnnouncementGroupAGWACNID_A19706 = (global::AcpUI.AcpLabel)target;
			this.LblTrkPerAnnouncementGroupAGWACNID_A19706.MouseDoubleClick += new global::System.Windows.Input.MouseButtonEventHandler(this.OnFieldNameDoubleClick);
			return;
			IL_3885:
			this.CVBtnTrkPerAnnouncementGroupAGSecondaryFSRxFrequencyMHz_A8895 = (global::AcpUI.AcpCustomViewCheckBox)target;
			return;
			IL_3892:
			this.RTDBtnTrkPerAnnouncementGroupAGSecureClearStrapping_A9089 = (global::AcpUI.AcpRtdButton)target;
			return;
			IL_389F:
			this.RTDBtnTrkPerCallPagePrivateCallType_A8760 = (global::AcpUI.AcpRtdButton)target;
			return;
			IL_38AC:
			this.LblTrkPerGeneralTrunkingPersonalityName_A12659 = (global::AcpUI.AcpLabel)target;
			this.LblTrkPerGeneralTrunkingPersonalityName_A12659.MouseDoubleClick += new global::System.Windows.Input.MouseButtonEventHandler(this.OnFieldNameDoubleClick);
			return;
			IL_38D0:
			this.GrpBoxExpanderTrunkingPersonalityLabtoolPseudo0 = (global::AcpUI.AcpGroupBox)target;
			return;
			IL_38DD:
			this.CVBtnTrkPerGeneralTxFrequencyMHz_A9413 = (global::AcpUI.AcpCustomViewCheckBox)target;
			return;
			IL_38EA:
			this.TrkPerFeaturesPhoneOperation_A8701Comp = (global::AcpUI.AcpLabel)target;
			return;
			IL_38F7:
			this.TrkPerFeaturesSecureProperCodeDetect_A8763 = (global::AcpUI.AcpCheckBox)target;
			this.TrkPerFeaturesSecureProperCodeDetect_A8763.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_391B:
			this.CVBtnTrkPerCallPageInCallUserAlertEnable_A9434 = (global::AcpUI.AcpCustomViewCheckBox)target;
			return;
			IL_3928:
			this.CpyBtnTrkPerAnnouncementGroupAnnouncementGroup_A7444 = (global::AcpUI.AcpCopyButton)target;
			return;
			IL_3935:
			this.TrkPerTalkgroupTxVoiceSignalType_A9575 = (global::AcpUI.AcpComboBox)target;
			this.TrkPerTalkgroupTxVoiceSignalType_A9575.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_3959:
			this.RTDBtnTrkPerAnnouncementGroupAGKeySelect_A7414 = (global::AcpUI.AcpRtdButton)target;
			return;
			IL_3966:
			this.LblTrkPerGeneralFailsoftType_A8599 = (global::AcpUI.AcpLabel)target;
			this.LblTrkPerGeneralFailsoftType_A8599.MouseDoubleClick += new global::System.Windows.Input.MouseButtonEventHandler(this.OnFieldNameDoubleClick);
			return;
			IL_398A:
			this.CVBtnTrkPerPreferredSitesPreferredStatus_A8734 = (global::AcpUI.AcpCustomViewCheckBox)target;
			return;
			IL_3997:
			this.CVBtnTrkPerTalkgroupTGSystemID_A19715 = (global::AcpUI.AcpCustomViewCheckBox)target;
			return;
			IL_39A4:
			this.TrkPerTalkgroupKeySelect_A8365 = (global::AcpUI.AcpComboBox)target;
			this.TrkPerTalkgroupKeySelect_A8365.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_39C8:
			this.LblTrkPerPreferredSitesIgnoreSiteResourcePreference_A8239 = (global::AcpUI.AcpLabel)target;
			this.LblTrkPerPreferredSitesIgnoreSiteResourcePreference_A8239.MouseDoubleClick += new global::System.Windows.Input.MouseButtonEventHandler(this.OnFieldNameDoubleClick);
			return;
			IL_39EC:
			this.HLinkAnnouncementGroup = (global::System.Windows.Documents.Hyperlink)target;
			this.HLinkAnnouncementGroup.Click += this.HLinkClick;
			return;
			IL_3A10:
			this.RTDBtnTrkPerFeaturesTalkPermitTone_A9271 = (global::AcpUI.AcpRtdButton)target;
			return;
			IL_3A1D:
			this.RecNavToolbarExpanderTrunkingPersonalityTalkgroupTable = (global::AcpUI.AcpChildRecNavToolbar)target;
			this.RecNavToolbarExpanderTrunkingPersonalityTalkgroupTable.ModeClick += this.OnModeClick;
			return;
			IL_3A41:
			this.b = true;
		}

		// Token: 0x06001E34 RID: 7732 RVA: 0x001E0E7C File Offset: 0x001DF07C
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		[global::System.Diagnostics.DebuggerNonUserCode]
		[global::System.CodeDom.Compiler.GeneratedCode("PresentationBuildTasks", "5.0.10.0")]
		void global::System.Windows.Markup.IStyleConnector.Connect(int connectionId, object target)
		{
			switch (connectionId)
			{
			case 3:
				((global::AcpUI.AcpTableTextBox)target).GotFocus += this.OnFieldNameDoubleClick;
				return;
			case 4:
			{
				short num = (short)483124307;
				short num2 = num;
				num = (short)1287709779;
				switch ((num2 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					break;
				default:
				{
					num = (short)1820196864;
					short num3 = num;
					num = (short)1374683136;
					if (num != 0)
					{
					}
					((global::AcpUI.AcpTableTextBoxDecHex)target).GotFocus += this.OnFieldNameDoubleClick;
					return;
				}
				}
				break;
			}
			case 5:
				((global::AcpUI.AcpTableComboBox)target).GotFocus += this.OnFieldNameDoubleClick;
				return;
			case 6:
				((global::AcpUI.AcpTableComboBox)target).GotFocus += this.OnFieldNameDoubleClick;
				return;
			case 7:
				((global::AcpUI.AcpTableComboBox)target).GotFocus += this.OnFieldNameDoubleClick;
				return;
			case 8:
				((global::AcpUI.AcpTableComboBox)target).GotFocus += this.OnFieldNameDoubleClick;
				return;
			case 9:
				((global::AcpUI.AcpTableCheckBox)target).GotFocus += this.OnFieldNameDoubleClick;
				return;
			case 10:
				((global::AcpUI.AcpTableTextBox)target).GotFocus += this.OnFieldNameDoubleClick;
				return;
			case 11:
				((global::AcpUI.AcpTableTextBox)target).GotFocus += this.OnFieldNameDoubleClick;
				return;
			case 12:
				((global::AcpUI.AcpTableCheckBox)target).GotFocus += this.OnFieldNameDoubleClick;
				return;
			case 13:
				break;
			case 14:
				((global::AcpUI.AcpTableTextBox)target).GotFocus += this.OnFieldNameDoubleClick;
				return;
			case 15:
				((global::AcpUI.AcpTableTextBoxSpinnerDecHex)target).GotFocus += this.OnFieldNameDoubleClick;
				return;
			case 16:
				((global::AcpUI.AcpTableTextBoxSpinnerDecHex)target).GotFocus += this.OnFieldNameDoubleClick;
				return;
			case 17:
				((global::AcpUI.AcpTableComboBox)target).GotFocus += this.OnFieldNameDoubleClick;
				return;
			case 18:
				((global::AcpUI.AcpTableTextBoxSpinnerDecHex)target).GotFocus += this.OnFieldNameDoubleClick;
				return;
			case 19:
				((global::AcpUI.AcpTableComboBox)target).GotFocus += this.OnFieldNameDoubleClick;
				return;
			case 20:
				((global::AcpUI.AcpTableTextBoxSpinnerDecHex)target).GotFocus += this.OnFieldNameDoubleClick;
				return;
			case 21:
				((global::AcpUI.AcpTableTextBoxSpinnerDecHex)target).GotFocus += this.OnFieldNameDoubleClick;
				return;
			case 22:
			{
				short num = (short)1872494593;
				if (num != 0)
				{
				}
				((global::AcpUI.AcpTableTextBoxSpinnerDecHex)target).GotFocus += this.OnFieldNameDoubleClick;
				return;
			}
			case 23:
				((global::AcpUI.AcpTableComboBox)target).GotFocus += this.OnFieldNameDoubleClick;
				return;
			default:
				return;
			}
			((global::AcpUI.AcpTableTextBox)target).GotFocus += this.OnFieldNameDoubleClick;
		}

		// Token: 0x0400091A RID: 2330
		private bool a;

		// Token: 0x0400091B RID: 2331
		internal global::AcpUI.AcpParentRecNavToolbar RecNavToolbarPageTrunkingPersonality;

		// Token: 0x0400091C RID: 2332
		internal global::AcpUI.Common.AcpThemeBase ThemeBaseObj;

		// Token: 0x0400091D RID: 2333
		internal global::System.Windows.Documents.Hyperlink HLinkGeneral;

		// Token: 0x0400091E RID: 2334
		internal global::System.Windows.Documents.Hyperlink HLinkAnnouncementGroup;

		// Token: 0x0400091F RID: 2335
		internal global::System.Windows.Documents.Hyperlink HLinkTalkgroup;

		// Token: 0x04000920 RID: 2336
		internal global::System.Windows.Documents.Hyperlink HLinkCallPage;

		// Token: 0x04000921 RID: 2337
		internal global::System.Windows.Documents.Hyperlink HLinkFeatures;

		// Token: 0x04000922 RID: 2338
		internal global::System.Windows.Documents.Hyperlink HLinkPreferredSites;

		// Token: 0x04000923 RID: 2339
		internal global::System.Windows.Documents.Hyperlink HLinkLabtool;

		// Token: 0x04000924 RID: 2340
		internal global::System.Windows.Controls.StackPanel MyStackPanel;

		// Token: 0x04000925 RID: 2341
		internal global::AcpUI.AcpExpander ExpanderTrunkingPersonalityGeneral;

		// Token: 0x04000926 RID: 2342
		internal global::AcpUI.AcpGroupBox GrpBoxExpanderTrunkingPersonalityGeneralPseudo0;

		// Token: 0x04000927 RID: 2343
		internal global::AcpUI.AcpCustomViewCheckBox CVBtnTrkPerGeneralTrunkingPersonalityName_A12659;

		// Token: 0x04000928 RID: 2344
		internal global::AcpUI.AcpLabel LblTrkPerGeneralTrunkingPersonalityName_A12659;

		// Token: 0x04000929 RID: 2345
		internal global::AcpUI.AcpTextBox TrkPerGeneralTrunkingPersonalityName_A12659;

		// Token: 0x0400092A RID: 2346
		internal global::AcpUI.AcpCopyButton CpyBtnTrkPerGeneralTrunkingPersonalityName_A12659;

		// Token: 0x0400092B RID: 2347
		internal global::AcpUI.AcpLabel TrkPerGeneralTrunkingPersonalityName_A12659Comp;

		// Token: 0x0400092C RID: 2348
		internal global::AcpUI.AcpGroupBox GrpBoxExpanderTrunkingPersonalityGeneralSystemInfo;

		// Token: 0x0400092D RID: 2349
		internal global::AcpUI.AcpCustomViewCheckBox CVBtnTrkPerGeneralSystem_A9237;

		// Token: 0x0400092E RID: 2350
		internal global::AcpUI.AcpLabel LblTrkPerGeneralSystem_A9237;

		// Token: 0x0400092F RID: 2351
		internal global::AcpUI.AcpComboBox TrkPerGeneralSystem_A9237;

		// Token: 0x04000930 RID: 2352
		internal global::AcpUI.AcpRtdButton RTDBtnTrkPerGeneralSystem_A9237;

		// Token: 0x04000931 RID: 2353
		internal global::AcpUI.AcpCopyButton CpyBtnTrkPerGeneralSystem_A9237;

		// Token: 0x04000932 RID: 2354
		internal global::AcpUI.AcpLabel TrkPerGeneralSystem_A9237Comp;

		// Token: 0x04000933 RID: 2355
		internal global::AcpUI.AcpCustomViewCheckBox CVBtnTrkPerGeneralProtocolType_A8767;

		// Token: 0x04000934 RID: 2356
		internal global::AcpUI.AcpLabel LblTrkPerGeneralProtocolType_A8767;

		// Token: 0x04000935 RID: 2357
		internal global::AcpUI.AcpComboBox TrkPerGeneralProtocolType_A8767;

		// Token: 0x04000936 RID: 2358
		internal global::AcpUI.AcpRtdButton RTDBtnTrkPerGeneralProtocolType_A8767;

		// Token: 0x04000937 RID: 2359
		internal global::AcpUI.AcpCopyButton CpyBtnTrkPerGeneralProtocolType_A8767;

		// Token: 0x04000938 RID: 2360
		internal global::AcpUI.AcpLabel TrkPerGeneralProtocolType_A8767Comp;

		// Token: 0x04000939 RID: 2361
		internal global::AcpUI.AcpCustomViewCheckBox CVBtnTrkPerGeneralUnitID_A9593;

		// Token: 0x0400093A RID: 2362
		internal global::AcpUI.AcpLabel LblTrkPerGeneralUnitID_A9593;

		// Token: 0x0400093B RID: 2363
		internal global::AcpUI.AcpTextBoxDecHex TrkPerGeneralUnitID_A9593;

		// Token: 0x0400093C RID: 2364
		internal global::AcpUI.AcpRtdButton RTDBtnTrkPerGeneralUnitID_A9593;

		// Token: 0x0400093D RID: 2365
		internal global::AcpUI.AcpCustomViewCheckBox CVBtnTrkPerGeneralSystemID_A9238;

		// Token: 0x0400093E RID: 2366
		internal global::AcpUI.AcpLabel LblTrkPerGeneralSystemID_A9238;

		// Token: 0x0400093F RID: 2367
		internal global::AcpUI.AcpTextBoxDecHex TrkPerGeneralSystemID_A9238;

		// Token: 0x04000940 RID: 2368
		internal global::AcpUI.AcpRtdButton RTDBtnTrkPerGeneralSystemID_A9238;

		// Token: 0x04000941 RID: 2369
		internal global::AcpUI.AcpGroupBox GrpBoxExpanderTrunkingPersonalityGeneralPseudo1;

		// Token: 0x04000942 RID: 2370
		internal global::AcpUI.AcpCustomViewCheckBox CVBtnTrkPerGeneralTimeOutTimersec_A9379;

		// Token: 0x04000943 RID: 2371
		internal global::AcpUI.AcpLabel LblTrkPerGeneralTimeOutTimersec_A9379;

		// Token: 0x04000944 RID: 2372
		internal global::AcpUI.AcpTextBoxSpinner TrkPerGeneralTimeOutTimersec_A9379;

		// Token: 0x04000945 RID: 2373
		internal global::AcpUI.AcpRtdButton RTDBtnTrkPerGeneralTimeOutTimersec_A9379;

		// Token: 0x04000946 RID: 2374
		internal global::AcpUI.AcpCopyButton CpyBtnTrkPerGeneralTimeOutTimersec_A9379;

		// Token: 0x04000947 RID: 2375
		internal global::AcpUI.AcpLabel TrkPerGeneralTimeOutTimersec_A9379Comp;

		// Token: 0x04000948 RID: 2376
		internal global::AcpUI.AcpCustomViewCheckBox CVBtnTrkPerGeneralAdvancedRFAGC_A7409;

		// Token: 0x04000949 RID: 2377
		internal global::AcpUI.AcpLabel LblTrkPerGeneralAdvancedRFAGC_A7409;

		// Token: 0x0400094A RID: 2378
		internal global::AcpUI.AcpComboBox TrkPerGeneralAdvancedRFAGC_A7409;

		// Token: 0x0400094B RID: 2379
		internal global::AcpUI.AcpRtdButton RTDBtnTrkPerGeneralAdvancedRFAGC_A7409;

		// Token: 0x0400094C RID: 2380
		internal global::AcpUI.AcpCopyButton CpyBtnTrkPerGeneralAdvancedRFAGC_A7409;

		// Token: 0x0400094D RID: 2381
		internal global::AcpUI.AcpLabel TrkPerGeneralAdvancedRFAGC_A7409Comp;

		// Token: 0x0400094E RID: 2382
		internal global::AcpUI.AcpCustomViewCheckBox CVBtnTrkPerGeneralConversationType_A7781;

		// Token: 0x0400094F RID: 2383
		internal global::AcpUI.AcpLabel LblTrkPerGeneralConversationType_A7781;

		// Token: 0x04000950 RID: 2384
		internal global::AcpUI.AcpComboBox TrkPerGeneralConversationType_A7781;

		// Token: 0x04000951 RID: 2385
		internal global::AcpUI.AcpRtdButton RTDBtnTrkPerGeneralConversationType_A7781;

		// Token: 0x04000952 RID: 2386
		internal global::AcpUI.AcpCopyButton CpyBtnTrkPerGeneralConversationType_A7781;

		// Token: 0x04000953 RID: 2387
		internal global::AcpUI.AcpLabel TrkPerGeneralConversationType_A7781Comp;

		// Token: 0x04000954 RID: 2388
		internal global::AcpUI.AcpCustomViewCheckBox CVBtnTrkPerGeneralFailsoftType_A8599;

		// Token: 0x04000955 RID: 2389
		internal global::AcpUI.AcpLabel LblTrkPerGeneralFailsoftType_A8599;

		// Token: 0x04000956 RID: 2390
		internal global::AcpUI.AcpComboBox TrkPerGeneralFailsoftType_A8599;

		// Token: 0x04000957 RID: 2391
		internal global::AcpUI.AcpRtdButton RTDBtnTrkPerGeneralFailsoftType_A8599;

		// Token: 0x04000958 RID: 2392
		internal global::AcpUI.AcpCopyButton CpyBtnTrkPerGeneralFailsoftType_A8599;

		// Token: 0x04000959 RID: 2393
		internal global::AcpUI.AcpLabel TrkPerGeneralFailsoftType_A8599Comp;

		// Token: 0x0400095A RID: 2394
		internal global::AcpUI.AcpCustomViewCheckBox CVBtnTrkPerGeneralStrictFailsoftbyTalkgroup_43782;

		// Token: 0x0400095B RID: 2395
		internal global::AcpUI.AcpLabel LblTrkPerGeneralStrictFailsoftbyTalkgroup_43782;

		// Token: 0x0400095C RID: 2396
		internal global::AcpUI.AcpCheckBox TrkPerGeneralStrictFailsoftbyTalkgroup_43782;

		// Token: 0x0400095D RID: 2397
		internal global::AcpUI.AcpRtdButton RTDBtnTrkPerGeneralStrictFailsoftbyTalkgroup_43782;

		// Token: 0x0400095E RID: 2398
		internal global::AcpUI.AcpCopyButton CpyBtnTrkPerGeneralStrictFailsoftbyTalkgroup_43782;

		// Token: 0x0400095F RID: 2399
		internal global::AcpUI.AcpCheckBox TrkPerGeneralStrictFailsoftbyTalkgroup_43782Comp;

		// Token: 0x04000960 RID: 2400
		internal global::AcpUI.AcpCustomViewCheckBox CVBtnTrkPerGeneralBroadbandProtection;

		// Token: 0x04000961 RID: 2401
		internal global::AcpUI.AcpLabel LblTrkPerGeneralBroadbandProtection;

		// Token: 0x04000962 RID: 2402
		internal global::AcpUI.AcpCheckBox TrkPerGeneralBroadbandProtection;

		// Token: 0x04000963 RID: 2403
		internal global::AcpUI.AcpRtdButton RTDBtnTrkPerGeneralBroadbandProtection;

		// Token: 0x04000964 RID: 2404
		internal global::AcpUI.AcpCopyButton CpyBtnTrkPerGeneralBroadbandProtection;

		// Token: 0x04000965 RID: 2405
		internal global::AcpUI.AcpCheckBox TrkPerGeneralBroadbandProtectionComp;

		// Token: 0x04000966 RID: 2406
		internal global::AcpUI.AcpGroupBox GrpBoxExpanderTrunkingPersonalityGeneralTypeIIFailsoftByPersonality;

		// Token: 0x04000967 RID: 2407
		internal global::AcpUI.AcpCustomViewCheckBox CVBtnTrkPerGeneralRxFrequencyMHz_A8910;

		// Token: 0x04000968 RID: 2408
		internal global::AcpUI.AcpLabel LblTrkPerGeneralRxFrequencyMHz_A8910;

		// Token: 0x04000969 RID: 2409
		internal global::AcpUI.AcpTextBox TrkPerGeneralRxFrequencyMHz_A8910;

		// Token: 0x0400096A RID: 2410
		internal global::AcpUI.AcpRtdButton RTDBtnTrkPerGeneralRxFrequencyMHz_A8910;

		// Token: 0x0400096B RID: 2411
		internal global::AcpUI.AcpCopyButton CpyBtnTrkPerGeneralRxFrequencyMHz_A8910;

		// Token: 0x0400096C RID: 2412
		internal global::AcpUI.AcpLabel TrkPerGeneralRxFrequencyMHz_A8910Comp;

		// Token: 0x0400096D RID: 2413
		internal global::AcpUI.AcpCustomViewCheckBox CVBtnTrkPerGeneralTxFrequencyMHz_A9413;

		// Token: 0x0400096E RID: 2414
		internal global::AcpUI.AcpLabel LblTrkPerGeneralTxFrequencyMHz_A9413;

		// Token: 0x0400096F RID: 2415
		internal global::AcpUI.AcpTextBox TrkPerGeneralTxFrequencyMHz_A9413;

		// Token: 0x04000970 RID: 2416
		internal global::AcpUI.AcpRtdButton RTDBtnTrkPerGeneralTxFrequencyMHz_A9413;

		// Token: 0x04000971 RID: 2417
		internal global::AcpUI.AcpCopyButton CpyBtnTrkPerGeneralTxFrequencyMHz_A9413;

		// Token: 0x04000972 RID: 2418
		internal global::AcpUI.AcpLabel TrkPerGeneralTxFrequencyMHz_A9413Comp;

		// Token: 0x04000973 RID: 2419
		internal global::AcpUI.AcpCustomViewCheckBox CVBtnTrkPerGeneralSecondaryFailsoft_A19991;

		// Token: 0x04000974 RID: 2420
		internal global::AcpUI.AcpLabel LblTrkPerGeneralSecondaryFailsoft_A19991;

		// Token: 0x04000975 RID: 2421
		internal global::AcpUI.AcpCheckBox TrkPerGeneralSecondaryFailsoft_A19991;

		// Token: 0x04000976 RID: 2422
		internal global::AcpUI.AcpRtdButton RTDBtnTrkPerGeneralSecondaryFailsoft_A19991;

		// Token: 0x04000977 RID: 2423
		internal global::AcpUI.AcpCopyButton CpyBtnTrkPerGeneralSecondaryFailsoft_A19991;

		// Token: 0x04000978 RID: 2424
		internal global::AcpUI.AcpCheckBox TrkPerGeneralSecondaryFailsoft_A19991Comp;

		// Token: 0x04000979 RID: 2425
		internal global::AcpUI.AcpCustomViewCheckBox CVBtnTrkPerGeneralSecondaryRxFrequencyMHz_A8904;

		// Token: 0x0400097A RID: 2426
		internal global::AcpUI.AcpLabel LblTrkPerGeneralSecondaryRxFrequencyMHz_A8904;

		// Token: 0x0400097B RID: 2427
		internal global::AcpUI.AcpTextBox TrkPerGeneralSecondaryRxFrequencyMHz_A8904;

		// Token: 0x0400097C RID: 2428
		internal global::AcpUI.AcpRtdButton RTDBtnTrkPerGeneralSecondaryRxFrequencyMHz_A8904;

		// Token: 0x0400097D RID: 2429
		internal global::AcpUI.AcpCopyButton CpyBtnTrkPerGeneralSecondaryRxFrequencyMHz_A8904;

		// Token: 0x0400097E RID: 2430
		internal global::AcpUI.AcpLabel TrkPerGeneralSecondaryRxFrequencyMHz_A8904Comp;

		// Token: 0x0400097F RID: 2431
		internal global::AcpUI.AcpCustomViewCheckBox CVBtnTrkPerGeneralSecondaryTxFrequencyMHz_A12902;

		// Token: 0x04000980 RID: 2432
		internal global::AcpUI.AcpLabel LblTrkPerGeneralSecondaryTxFrequencyMHz_A12902;

		// Token: 0x04000981 RID: 2433
		internal global::AcpUI.AcpTextBox TrkPerGeneralSecondaryTxFrequencyMHz_A12902;

		// Token: 0x04000982 RID: 2434
		internal global::AcpUI.AcpRtdButton RTDBtnTrkPerGeneralSecondaryTxFrequencyMHz_A12902;

		// Token: 0x04000983 RID: 2435
		internal global::AcpUI.AcpCopyButton CpyBtnTrkPerGeneralSecondaryTxFrequencyMHz_A12902;

		// Token: 0x04000984 RID: 2436
		internal global::AcpUI.AcpLabel TrkPerGeneralSecondaryTxFrequencyMHz_A12902Comp;

		// Token: 0x04000985 RID: 2437
		internal global::AcpUI.AcpGroupBox GrpBoxExpanderTrunkingPersonalityGeneralPseudo2;

		// Token: 0x04000986 RID: 2438
		internal global::AcpUI.AcpCustomViewCheckBox CVBtnTrkPerGeneralDisableTransmitMode_A41742;

		// Token: 0x04000987 RID: 2439
		internal global::AcpUI.AcpLabel LblTrkPerGeneralDisableTransmitMode_A41742;

		// Token: 0x04000988 RID: 2440
		internal global::AcpUI.AcpComboBox TrkPerGeneralDisableTransmitMode_A41742;

		// Token: 0x04000989 RID: 2441
		internal global::AcpUI.AcpRtdButton RTDBtnTrkPerGeneralDisableTransmitMode_A41742;

		// Token: 0x0400098A RID: 2442
		internal global::AcpUI.AcpCopyButton CpyBtnTrkPerGeneralDisableTransmitMode_A41742;

		// Token: 0x0400098B RID: 2443
		internal global::AcpUI.AcpLabel TrkPerGeneralDisableTransmitMode_A41742Comp;

		// Token: 0x0400098C RID: 2444
		internal global::AcpUI.AcpCustomViewCheckBox CVBtnTrkPerLabtoolTrunkingEmergencyProfileCompositeItemID_A19980;

		// Token: 0x0400098D RID: 2445
		internal global::AcpUI.AcpLabel LblTrkPerLabtoolTrunkingEmergencyProfileCompositeItemID_A19980;

		// Token: 0x0400098E RID: 2446
		internal global::AcpUI.AcpComboBox TrkPerLabtoolTrunkingEmergencyProfileCompositeItemID_A19980;

		// Token: 0x0400098F RID: 2447
		internal global::AcpUI.AcpRtdButton RTDBtnTrkPerLabtoolTrunkingEmergencyProfileCompositeItemID_A19980;

		// Token: 0x04000990 RID: 2448
		internal global::AcpUI.AcpCopyButton CpyBtnTrkPerLabtoolTrunkingEmergencyProfileCompositeItemID_A19980;

		// Token: 0x04000991 RID: 2449
		internal global::AcpUI.AcpLabel TrkPerLabtoolTrunkingEmergencyProfileCompositeItemID_A19980Comp;

		// Token: 0x04000992 RID: 2450
		internal global::AcpUI.AcpCustomViewCheckBox CVBtnTrkPerGeneralEmergencyRevertType_A41914;

		// Token: 0x04000993 RID: 2451
		internal global::AcpUI.AcpLabel LblTrkPerGeneralEmergencyRevertType_A41914;

		// Token: 0x04000994 RID: 2452
		internal global::AcpUI.AcpComboBox TrkPerGeneralEmergencyRevertType_A41914;

		// Token: 0x04000995 RID: 2453
		internal global::AcpUI.AcpRtdButton RTDBtnTrkPerGeneralEmergencyRevertType_A41914;

		// Token: 0x04000996 RID: 2454
		internal global::AcpUI.AcpCopyButton CpyBtnTrkPerGeneralEmergencyRevertType_A41914;

		// Token: 0x04000997 RID: 2455
		internal global::AcpUI.AcpLabel TrkPerGeneralEmergencyRevertType_A41914Comp;

		// Token: 0x04000998 RID: 2456
		internal global::AcpUI.AcpGroupBox GrpBoxExpanderTrunkingPersonalityGeneralEmergencyTalkbackRevert;

		// Token: 0x04000999 RID: 2457
		internal global::AcpUI.AcpCustomViewCheckBox CVBtnTrkEmerProfGeneralTalkgroup_A8969;

		// Token: 0x0400099A RID: 2458
		internal global::AcpUI.AcpLabel LblTrkEmerProfGeneralTalkgroup_A8969;

		// Token: 0x0400099B RID: 2459
		internal global::AcpUI.AcpTextBoxSpinnerDecHex TrkEmerProfGeneralTalkgroup_A8969;

		// Token: 0x0400099C RID: 2460
		internal global::AcpUI.AcpRtdButton RTDBtnTrkEmerProfGeneralTalkgroup_A8969;

		// Token: 0x0400099D RID: 2461
		internal global::AcpUI.AcpCopyButton CpyBtnTrkEmerProfGeneralTalkgroup_A8969;

		// Token: 0x0400099E RID: 2462
		internal global::AcpUI.AcpTextBoxDecHex TrkEmerProfGeneralTalkgroup_A8969Comp;

		// Token: 0x0400099F RID: 2463
		internal global::AcpUI.AcpCustomViewCheckBox CVBtnTrkEmerProfGeneralVoiceSignalType_A7500;

		// Token: 0x040009A0 RID: 2464
		internal global::AcpUI.AcpLabel LblTrkEmerProfGeneralVoiceSignalType_A7500;

		// Token: 0x040009A1 RID: 2465
		internal global::AcpUI.AcpComboBox TrkEmerProfGeneralVoiceSignalType_A7500;

		// Token: 0x040009A2 RID: 2466
		internal global::AcpUI.AcpRtdButton RTDBtnTrkEmerProfGeneralVoiceSignalType_A7500;

		// Token: 0x040009A3 RID: 2467
		internal global::AcpUI.AcpCopyButton CpyBtnTrkEmerProfGeneralVoiceSignalType_A7500;

		// Token: 0x040009A4 RID: 2468
		internal global::AcpUI.AcpLabel TrkEmerProfGeneralVoiceSignalType_A7500Comp;

		// Token: 0x040009A5 RID: 2469
		internal global::AcpUI.AcpCustomViewCheckBox CVBtnTrkEmerProfGeneralSecureClearStrapping_A9092;

		// Token: 0x040009A6 RID: 2470
		internal global::AcpUI.AcpLabel LblTrkEmerProfGeneralSecureClearStrapping_A9092;

		// Token: 0x040009A7 RID: 2471
		internal global::AcpUI.AcpComboBox TrkEmerProfGeneralSecureClearStrapping_A9092;

		// Token: 0x040009A8 RID: 2472
		internal global::AcpUI.AcpRtdButton RTDBtnTrkEmerProfGeneralSecureClearStrapping_A9092;

		// Token: 0x040009A9 RID: 2473
		internal global::AcpUI.AcpCopyButton CpyBtnTrkEmerProfGeneralSecureClearStrapping_A9092;

		// Token: 0x040009AA RID: 2474
		internal global::AcpUI.AcpLabel TrkEmerProfGeneralSecureClearStrapping_A9092Comp;

		// Token: 0x040009AB RID: 2475
		internal global::AcpUI.AcpCustomViewCheckBox CVBtnTrkEmerProfGeneralKeySelect_A8970;

		// Token: 0x040009AC RID: 2476
		internal global::AcpUI.AcpLabel LblTrkEmerProfGeneralKeySelect_A8970;

		// Token: 0x040009AD RID: 2477
		internal global::AcpUI.AcpComboBox TrkEmerProfGeneralKeySelect_A8970;

		// Token: 0x040009AE RID: 2478
		internal global::AcpUI.AcpRtdButton RTDBtnTrkEmerProfGeneralKeySelect_A8970;

		// Token: 0x040009AF RID: 2479
		internal global::AcpUI.AcpCopyButton CpyBtnTrkEmerProfGeneralKeySelect_A8970;

		// Token: 0x040009B0 RID: 2480
		internal global::AcpUI.AcpLabel TrkEmerProfGeneralKeySelect_A8970Comp;

		// Token: 0x040009B1 RID: 2481
		internal global::AcpUI.AcpGroupBox GrpBoxExpanderTrunkingPersonalityGeneralPseudo3;

		// Token: 0x040009B2 RID: 2482
		internal global::AcpUI.AcpCustomViewCheckBox CVBtnTrkPerFeaturesDVRSProf_A41796;

		// Token: 0x040009B3 RID: 2483
		internal global::AcpUI.AcpLabel LblTrkPerFeaturesDVRSProf_A41796;

		// Token: 0x040009B4 RID: 2484
		internal global::AcpUI.AcpComboBox TrkPerFeaturesDVRSProf_A41796;

		// Token: 0x040009B5 RID: 2485
		internal global::AcpUI.AcpRtdButton RTDBtnTrkPerFeaturesDVRSProf_A41796;

		// Token: 0x040009B6 RID: 2486
		internal global::AcpUI.AcpCopyButton CpyBtnTrkPerFeaturesDVRSProf_A41796;

		// Token: 0x040009B7 RID: 2487
		internal global::AcpUI.AcpLabel TrkPerFeaturesDVRSProf_A41796Comp;

		// Token: 0x040009B8 RID: 2488
		internal global::AcpUI.AcpGroupBox GrpBoxExpanderTrunkingPersonalityGeneralEmergencySystemRevert;

		// Token: 0x040009B9 RID: 2489
		internal global::AcpUI.AcpCustomViewCheckBox CVBtnTrkPerGeneralRevertZone_A41916;

		// Token: 0x040009BA RID: 2490
		internal global::AcpUI.AcpLabel LblTrkPerGeneralRevertZone_A41916;

		// Token: 0x040009BB RID: 2491
		internal global::AcpUI.AcpComboBox TrkPerGeneralRevertZone_A41916;

		// Token: 0x040009BC RID: 2492
		internal global::AcpUI.AcpRtdButton RTDBtnTrkPerGeneralRevertZone_A41916;

		// Token: 0x040009BD RID: 2493
		internal global::AcpUI.AcpCopyButton CpyBtnTrkPerGeneralRevertZone_A41916;

		// Token: 0x040009BE RID: 2494
		internal global::AcpUI.AcpLabel TrkPerGeneralRevertZone_A41916Comp;

		// Token: 0x040009BF RID: 2495
		internal global::AcpUI.AcpCustomViewCheckBox CVBtnTrkPerGeneralRevertChannel_A41917;

		// Token: 0x040009C0 RID: 2496
		internal global::AcpUI.AcpLabel LblTrkPerGeneralRevertChannel_A41917;

		// Token: 0x040009C1 RID: 2497
		internal global::AcpUI.AcpComboBox TrkPerGeneralRevertChannel_A41917;

		// Token: 0x040009C2 RID: 2498
		internal global::AcpUI.AcpRtdButton RTDBtnTrkPerGeneralRevertChannel_A41917;

		// Token: 0x040009C3 RID: 2499
		internal global::AcpUI.AcpCopyButton CpyBtnTrkPerGeneralRevertChannel_A41917;

		// Token: 0x040009C4 RID: 2500
		internal global::AcpUI.AcpLabel TrkPerGeneralRevertChannel_A41917Comp;

		// Token: 0x040009C5 RID: 2501
		internal global::AcpUI.AcpExpander ExpanderTrunkingPersonalityAnnouncementGroup;

		// Token: 0x040009C6 RID: 2502
		internal global::AcpUI.AcpGroupBox GrpBoxExpanderTrunkingPersonalityAnnouncementGroupPseudo0;

		// Token: 0x040009C7 RID: 2503
		internal global::AcpUI.AcpCustomViewCheckBox CVBtnTrkPerAnnouncementGroupAnnouncementGroup_A7444;

		// Token: 0x040009C8 RID: 2504
		internal global::AcpUI.AcpLabel LblTrkPerAnnouncementGroupAnnouncementGroup_A7444;

		// Token: 0x040009C9 RID: 2505
		internal global::AcpUI.AcpTextBoxCustomDecHex TrkPerAnnouncementGroupAnnouncementGroup_A7444;

		// Token: 0x040009CA RID: 2506
		internal global::AcpUI.AcpRtdButton RTDBtnTrkPerAnnouncementGroupAnnouncementGroup_A7444;

		// Token: 0x040009CB RID: 2507
		internal global::AcpUI.AcpCopyButton CpyBtnTrkPerAnnouncementGroupAnnouncementGroup_A7444;

		// Token: 0x040009CC RID: 2508
		internal global::AcpUI.AcpTextBoxCustomDecHex TrkPerAnnouncementGroupAnnouncementGroup_A7444Comp;

		// Token: 0x040009CD RID: 2509
		internal global::AcpUI.AcpCustomViewCheckBox CVBtnTrkPerAnnouncementGroupAGVoiceSignalType_A7478;

		// Token: 0x040009CE RID: 2510
		internal global::AcpUI.AcpLabel LblTrkPerAnnouncementGroupAGVoiceSignalType_A7478;

		// Token: 0x040009CF RID: 2511
		internal global::AcpUI.AcpComboBox TrkPerAnnouncementGroupAGVoiceSignalType_A7478;

		// Token: 0x040009D0 RID: 2512
		internal global::AcpUI.AcpRtdButton RTDBtnTrkPerAnnouncementGroupAGVoiceSignalType_A7478;

		// Token: 0x040009D1 RID: 2513
		internal global::AcpUI.AcpCopyButton CpyBtnTrkPerAnnouncementGroupAGVoiceSignalType_A7478;

		// Token: 0x040009D2 RID: 2514
		internal global::AcpUI.AcpLabel TrkPerAnnouncementGroupAGVoiceSignalType_A7478Comp;

		// Token: 0x040009D3 RID: 2515
		internal global::AcpUI.AcpCustomViewCheckBox CVBtnTrkPerAnnouncementGroupAGSecureClearStrapping_A9089;

		// Token: 0x040009D4 RID: 2516
		internal global::AcpUI.AcpLabel LblTrkPerAnnouncementGroupAGSecureClearStrapping_A9089;

		// Token: 0x040009D5 RID: 2517
		internal global::AcpUI.AcpComboBox TrkPerAnnouncementGroupAGSecureClearStrapping_A9089;

		// Token: 0x040009D6 RID: 2518
		internal global::AcpUI.AcpRtdButton RTDBtnTrkPerAnnouncementGroupAGSecureClearStrapping_A9089;

		// Token: 0x040009D7 RID: 2519
		internal global::AcpUI.AcpCopyButton CpyBtnTrkPerAnnouncementGroupAGSecureClearStrapping_A9089;

		// Token: 0x040009D8 RID: 2520
		internal global::AcpUI.AcpLabel TrkPerAnnouncementGroupAGSecureClearStrapping_A9089Comp;

		// Token: 0x040009D9 RID: 2521
		internal global::AcpUI.AcpCustomViewCheckBox CVBtnTrkPerAnnouncementGroupAGKeySelect_A7414;

		// Token: 0x040009DA RID: 2522
		internal global::AcpUI.AcpLabel LblTrkPerAnnouncementGroupAGKeySelect_A7414;

		// Token: 0x040009DB RID: 2523
		internal global::AcpUI.AcpComboBox TrkPerAnnouncementGroupAGKeySelect_A7414;

		// Token: 0x040009DC RID: 2524
		internal global::AcpUI.AcpRtdButton RTDBtnTrkPerAnnouncementGroupAGKeySelect_A7414;

		// Token: 0x040009DD RID: 2525
		internal global::AcpUI.AcpCopyButton CpyBtnTrkPerAnnouncementGroupAGKeySelect_A7414;

		// Token: 0x040009DE RID: 2526
		internal global::AcpUI.AcpLabel TrkPerAnnouncementGroupAGKeySelect_A7414Comp;

		// Token: 0x040009DF RID: 2527
		internal global::AcpUI.AcpGroupBox GrpBoxExpanderTrunkingPersonalityAnnouncementGroupTalkgroupFailsoft;

		// Token: 0x040009E0 RID: 2528
		internal global::AcpUI.AcpCustomViewCheckBox CVBtnTrkPerAnnouncementGroupAnnouncementGroupFailsoft_A8597;

		// Token: 0x040009E1 RID: 2529
		internal global::AcpUI.AcpLabel LblTrkPerAnnouncementGroupAnnouncementGroupFailsoft_A8597;

		// Token: 0x040009E2 RID: 2530
		internal global::AcpUI.AcpCheckBox TrkPerAnnouncementGroupAnnouncementGroupFailsoft_A8597;

		// Token: 0x040009E3 RID: 2531
		internal global::AcpUI.AcpRtdButton RTDBtnTrkPerAnnouncementGroupAnnouncementGroupFailsoft_A8597;

		// Token: 0x040009E4 RID: 2532
		internal global::AcpUI.AcpCopyButton CpyBtnTrkPerAnnouncementGroupAnnouncementGroupFailsoft_A8597;

		// Token: 0x040009E5 RID: 2533
		internal global::AcpUI.AcpCheckBox TrkPerAnnouncementGroupAnnouncementGroupFailsoft_A8597Comp;

		// Token: 0x040009E6 RID: 2534
		internal global::AcpUI.AcpCustomViewCheckBox CVBtnTrkPerAnnouncementGroupAGFailsoftRxFrequencyMHz_A9582;

		// Token: 0x040009E7 RID: 2535
		internal global::AcpUI.AcpLabel LblTrkPerAnnouncementGroupAGFailsoftRxFrequencyMHz_A9582;

		// Token: 0x040009E8 RID: 2536
		internal global::AcpUI.AcpTextBox TrkPerAnnouncementGroupAGFailsoftRxFrequencyMHz_A9582;

		// Token: 0x040009E9 RID: 2537
		internal global::AcpUI.AcpRtdButton RTDBtnTrkPerAnnouncementGroupAGFailsoftRxFrequencyMHz_A9582;

		// Token: 0x040009EA RID: 2538
		internal global::AcpUI.AcpCopyButton CpyBtnTrkPerAnnouncementGroupAGFailsoftRxFrequencyMHz_A9582;

		// Token: 0x040009EB RID: 2539
		internal global::AcpUI.AcpLabel TrkPerAnnouncementGroupAGFailsoftRxFrequencyMHz_A9582Comp;

		// Token: 0x040009EC RID: 2540
		internal global::AcpUI.AcpCustomViewCheckBox CVBtnTrkPerAnnouncementGroupAGFailsoftTxFrequencyMHz_A9583;

		// Token: 0x040009ED RID: 2541
		internal global::AcpUI.AcpLabel LblTrkPerAnnouncementGroupAGFailsoftTxFrequencyMHz_A9583;

		// Token: 0x040009EE RID: 2542
		internal global::AcpUI.AcpTextBox TrkPerAnnouncementGroupAGFailsoftTxFrequencyMHz_A9583;

		// Token: 0x040009EF RID: 2543
		internal global::AcpUI.AcpRtdButton RTDBtnTrkPerAnnouncementGroupAGFailsoftTxFrequencyMHz_A9583;

		// Token: 0x040009F0 RID: 2544
		internal global::AcpUI.AcpCopyButton CpyBtnTrkPerAnnouncementGroupAGFailsoftTxFrequencyMHz_A9583;

		// Token: 0x040009F1 RID: 2545
		internal global::AcpUI.AcpLabel TrkPerAnnouncementGroupAGFailsoftTxFrequencyMHz_A9583Comp;

		// Token: 0x040009F2 RID: 2546
		internal global::AcpUI.AcpCustomViewCheckBox CVBtnTrkPerAnnouncementGroupAGSecondaryFailsoft_A19990;

		// Token: 0x040009F3 RID: 2547
		internal global::AcpUI.AcpLabel LblTrkPerAnnouncementGroupAGSecondaryFailsoft_A19990;

		// Token: 0x040009F4 RID: 2548
		internal global::AcpUI.AcpCheckBox TrkPerAnnouncementGroupAGSecondaryFailsoft_A19990;

		// Token: 0x040009F5 RID: 2549
		internal global::AcpUI.AcpRtdButton RTDBtnTrkPerAnnouncementGroupAGSecondaryFailsoft_A19990;

		// Token: 0x040009F6 RID: 2550
		internal global::AcpUI.AcpCopyButton CpyBtnTrkPerAnnouncementGroupAGSecondaryFailsoft_A19990;

		// Token: 0x040009F7 RID: 2551
		internal global::AcpUI.AcpCheckBox TrkPerAnnouncementGroupAGSecondaryFailsoft_A19990Comp;

		// Token: 0x040009F8 RID: 2552
		internal global::AcpUI.AcpCustomViewCheckBox CVBtnTrkPerAnnouncementGroupAGSecondaryFSRxFrequencyMHz_A8895;

		// Token: 0x040009F9 RID: 2553
		internal global::AcpUI.AcpLabel LblTrkPerAnnouncementGroupAGSecondaryFSRxFrequencyMHz_A8895;

		// Token: 0x040009FA RID: 2554
		internal global::AcpUI.AcpTextBox TrkPerAnnouncementGroupAGSecondaryFSRxFrequencyMHz_A8895;

		// Token: 0x040009FB RID: 2555
		internal global::AcpUI.AcpRtdButton RTDBtnTrkPerAnnouncementGroupAGSecondaryFSRxFrequencyMHz_A8895;

		// Token: 0x040009FC RID: 2556
		internal global::AcpUI.AcpCopyButton CpyBtnTrkPerAnnouncementGroupAGSecondaryFSRxFrequencyMHz_A8895;

		// Token: 0x040009FD RID: 2557
		internal global::AcpUI.AcpLabel TrkPerAnnouncementGroupAGSecondaryFSRxFrequencyMHz_A8895Comp;

		// Token: 0x040009FE RID: 2558
		internal global::AcpUI.AcpCustomViewCheckBox CVBtnTrkPerAnnouncementGroupAGSecondaryFSTxFrequencyMHz_A12903;

		// Token: 0x040009FF RID: 2559
		internal global::AcpUI.AcpLabel LblTrkPerAnnouncementGroupAGSecondaryFSTxFrequencyMHz_A12903;

		// Token: 0x04000A00 RID: 2560
		internal global::AcpUI.AcpTextBox TrkPerAnnouncementGroupAGSecondaryFSTxFrequencyMHz_A12903;

		// Token: 0x04000A01 RID: 2561
		internal global::AcpUI.AcpRtdButton RTDBtnTrkPerAnnouncementGroupAGSecondaryFSTxFrequencyMHz_A12903;

		// Token: 0x04000A02 RID: 2562
		internal global::AcpUI.AcpCopyButton CpyBtnTrkPerAnnouncementGroupAGSecondaryFSTxFrequencyMHz_A12903;

		// Token: 0x04000A03 RID: 2563
		internal global::AcpUI.AcpLabel TrkPerAnnouncementGroupAGSecondaryFSTxFrequencyMHz_A12903Comp;

		// Token: 0x04000A04 RID: 2564
		internal global::AcpUI.AcpGroupBox GrpBoxExpanderTrunkingPersonalityAnnouncementGroupPseudo1;

		// Token: 0x04000A05 RID: 2565
		internal global::AcpUI.AcpCustomViewCheckBox CVBtnTrkPerAnnouncementGroupAGSystemID_A19705;

		// Token: 0x04000A06 RID: 2566
		internal global::AcpUI.AcpLabel LblTrkPerAnnouncementGroupAGSystemID_A19705;

		// Token: 0x04000A07 RID: 2567
		internal global::AcpUI.AcpTextBoxSpinnerDecHex TrkPerAnnouncementGroupAGSystemID_A19705;

		// Token: 0x04000A08 RID: 2568
		internal global::AcpUI.AcpRtdButton RTDBtnTrkPerAnnouncementGroupAGSystemID_A19705;

		// Token: 0x04000A09 RID: 2569
		internal global::AcpUI.AcpCopyButton CpyBtnTrkPerAnnouncementGroupAGSystemID_A19705;

		// Token: 0x04000A0A RID: 2570
		internal global::AcpUI.AcpTextBoxDecHex TrkPerAnnouncementGroupAGSystemID_A19705Comp;

		// Token: 0x04000A0B RID: 2571
		internal global::AcpUI.AcpCustomViewCheckBox CVBtnTrkPerAnnouncementGroupAGWACNID_A19706;

		// Token: 0x04000A0C RID: 2572
		internal global::AcpUI.AcpLabel LblTrkPerAnnouncementGroupAGWACNID_A19706;

		// Token: 0x04000A0D RID: 2573
		internal global::AcpUI.AcpTextBoxSpinnerDecHex TrkPerAnnouncementGroupAGWACNID_A19706;

		// Token: 0x04000A0E RID: 2574
		internal global::AcpUI.AcpRtdButton RTDBtnTrkPerAnnouncementGroupAGWACNID_A19706;

		// Token: 0x04000A0F RID: 2575
		internal global::AcpUI.AcpCopyButton CpyBtnTrkPerAnnouncementGroupAGWACNID_A19706;

		// Token: 0x04000A10 RID: 2576
		internal global::AcpUI.AcpTextBoxDecHex TrkPerAnnouncementGroupAGWACNID_A19706Comp;

		// Token: 0x04000A11 RID: 2577
		internal global::AcpUI.AcpCustomViewCheckBox CVBtnTrkPerAnnouncementGroupAstroOTARProfileIndex_43686;

		// Token: 0x04000A12 RID: 2578
		internal global::AcpUI.AcpLabel LblTrkPerAnnouncementGroupAstroOTARProfileIndex_43686;

		// Token: 0x04000A13 RID: 2579
		internal global::AcpUI.AcpComboBox TrkPerAnnouncementGroupAstroOTARProfileIndex_43686;

		// Token: 0x04000A14 RID: 2580
		internal global::AcpUI.AcpRtdButton RTDBtnTrkPerAnnouncementGroupAstroOTARProfileIndex_43686;

		// Token: 0x04000A15 RID: 2581
		internal global::AcpUI.AcpCopyButton CpyBtnTrkPerAnnouncementGroupAstroOTARProfileIndex_43686;

		// Token: 0x04000A16 RID: 2582
		internal global::AcpUI.AcpLabel TrkPerAnnouncementGroupAstroOTARProfileIndex_43686Comp;

		// Token: 0x04000A17 RID: 2583
		internal global::AcpUI.AcpExpander ExpanderTrunkingPersonalityTalkgroup;

		// Token: 0x04000A18 RID: 2584
		internal global::AcpUI.AcpChildRecNavToolbar RecNavToolbarExpanderTrunkingPersonalityTalkgroupTable;

		// Token: 0x04000A19 RID: 2585
		internal global::System.Windows.Controls.Grid ExpanderTrunkingPersonalityTalkgroupGrid;

		// Token: 0x04000A1A RID: 2586
		internal global::System.Windows.Controls.Grid ExpanderTrunkingPersonalityTalkgroupTableGrid;

		// Token: 0x04000A1B RID: 2587
		internal global::AcpUI.AcpGroupBox ExpanderTrunkingPersonalityTalkgroupTableTableView;

		// Token: 0x04000A1C RID: 2588
		internal global::AcpUI.AcpXamDataPresenter ExpanderTrunkingPersonalityTalkgroupTable;

		// Token: 0x04000A1D RID: 2589
		internal global::Infragistics.Windows.DataPresenter.UnboundField TrkSysGeneralKeyofTrunkingTalkgroup_A20742_Col;

		// Token: 0x04000A1E RID: 2590
		internal global::Infragistics.Windows.DataPresenter.UnboundField TrkPerTalkgroupTalkgroup_A9274_Col;

		// Token: 0x04000A1F RID: 2591
		internal global::Infragistics.Windows.DataPresenter.UnboundField TrkPerTalkgroupPriorityDispatch_43599_Col;

		// Token: 0x04000A20 RID: 2592
		internal global::Infragistics.Windows.DataPresenter.UnboundField TrkPerTalkgroupTxVoiceSignalType_A9575_Col;

		// Token: 0x04000A21 RID: 2593
		internal global::Infragistics.Windows.DataPresenter.UnboundField TrkPerTalkgroupSecureClearStrapping_A9095_Col;

		// Token: 0x04000A22 RID: 2594
		internal global::Infragistics.Windows.DataPresenter.UnboundField TrkPerTalkgroupKeySelect_A8365_Col;

		// Token: 0x04000A23 RID: 2595
		internal global::Infragistics.Windows.DataPresenter.UnboundField TrkPerTalkgroupTalkgroupFailsoft_A8005_Col;

		// Token: 0x04000A24 RID: 2596
		internal global::Infragistics.Windows.DataPresenter.UnboundField TrkPerTalkgroupFailsoftRxFrequencyMHz_A8001_Col;

		// Token: 0x04000A25 RID: 2597
		internal global::Infragistics.Windows.DataPresenter.UnboundField TrkPerTalkgroupFailsoftTxFrequencyMHz_A8003_Col;

		// Token: 0x04000A26 RID: 2598
		internal global::Infragistics.Windows.DataPresenter.UnboundField TrkPerTalkgroupTGSecondaryFailsoft_A19989_Col;

		// Token: 0x04000A27 RID: 2599
		internal global::Infragistics.Windows.DataPresenter.UnboundField TrkPerTalkgroupSecondaryFailsoftRxFrequencyMHz_A8900_Col;

		// Token: 0x04000A28 RID: 2600
		internal global::Infragistics.Windows.DataPresenter.UnboundField TrkPerTalkgroupSecondaryFailsoftTxFrequencyMHz_A8902_Col;

		// Token: 0x04000A29 RID: 2601
		internal global::Infragistics.Windows.DataPresenter.UnboundField TrkPerTalkgroupTGSystemID_A19715_Col;

		// Token: 0x04000A2A RID: 2602
		internal global::Infragistics.Windows.DataPresenter.UnboundField TrkPerTalkgroupTGWACNID_A19716_Col;

		// Token: 0x04000A2B RID: 2603
		internal global::Infragistics.Windows.DataPresenter.UnboundField TrkPerTalkgroupAstroOTARProfileIndex_43687_Col;

		// Token: 0x04000A2C RID: 2604
		internal global::AcpUI.AcpGroupBox ExpanderTrunkingPersonalityTalkgroupTableSRecView;

		// Token: 0x04000A2D RID: 2605
		internal global::System.Windows.Controls.Grid gridExpanderTrunkingPersonalityTalkgroupTableSRecView;

		// Token: 0x04000A2E RID: 2606
		internal global::AcpUI.AcpTextBox TrkSysGeneralKeyofTrunkingTalkgroup_A20742;

		// Token: 0x04000A2F RID: 2607
		internal global::AcpUI.AcpCustomViewCheckBox CVBtnTrkSysGeneralKeyofTrunkingTalkgroup_A20742;

		// Token: 0x04000A30 RID: 2608
		internal global::AcpUI.AcpLabel LblTrkSysGeneralKeyofTrunkingTalkgroup_A20742;

		// Token: 0x04000A31 RID: 2609
		internal global::AcpUI.AcpCopyButton CpyBtnTrkSysGeneralKeyofTrunkingTalkgroup_A20742;

		// Token: 0x04000A32 RID: 2610
		internal global::AcpUI.AcpLabel TrkSysGeneralKeyofTrunkingTalkgroup_A20742Comp;

		// Token: 0x04000A33 RID: 2611
		internal global::AcpUI.AcpTextBoxDecHex TrkPerTalkgroupTalkgroup_A9274;

		// Token: 0x04000A34 RID: 2612
		internal global::AcpUI.AcpCustomViewCheckBox CVBtnTrkPerTalkgroupTalkgroup_A9274;

		// Token: 0x04000A35 RID: 2613
		internal global::AcpUI.AcpLabel LblTrkPerTalkgroupTalkgroup_A9274;

		// Token: 0x04000A36 RID: 2614
		internal global::AcpUI.AcpRtdButton RTDBtnTrkPerTalkgroupTalkgroup_A9274;

		// Token: 0x04000A37 RID: 2615
		internal global::AcpUI.AcpCopyButton CpyBtnTrkPerTalkgroupTalkgroup_A9274;

		// Token: 0x04000A38 RID: 2616
		internal global::AcpUI.AcpTextBoxDecHex TrkPerTalkgroupTalkgroup_A9274Comp;

		// Token: 0x04000A39 RID: 2617
		internal global::AcpUI.AcpComboBox TrkPerTalkgroupPriorityDispatch_43599;

		// Token: 0x04000A3A RID: 2618
		internal global::AcpUI.AcpCustomViewCheckBox CVBtnTrkPerTalkgroupPriorityDispatch_43599;

		// Token: 0x04000A3B RID: 2619
		internal global::AcpUI.AcpLabel LblTrkPerTalkgroupPriorityDispatch_43599;

		// Token: 0x04000A3C RID: 2620
		internal global::AcpUI.AcpRtdButton RTDBtnTrkPerTalkgroupPriorityDispatch_43599;

		// Token: 0x04000A3D RID: 2621
		internal global::AcpUI.AcpCopyButton CpyBtnTrkPerTalkgroupPriorityDispatch_43599;

		// Token: 0x04000A3E RID: 2622
		internal global::AcpUI.AcpLabel TrkPerTalkgroupPriorityDispatch_43599Comp;

		// Token: 0x04000A3F RID: 2623
		internal global::AcpUI.AcpComboBox TrkPerTalkgroupTxVoiceSignalType_A9575;

		// Token: 0x04000A40 RID: 2624
		internal global::AcpUI.AcpCustomViewCheckBox CVBtnTrkPerTalkgroupTxVoiceSignalType_A9575;

		// Token: 0x04000A41 RID: 2625
		internal global::AcpUI.AcpLabel LblTrkPerTalkgroupTxVoiceSignalType_A9575;

		// Token: 0x04000A42 RID: 2626
		internal global::AcpUI.AcpRtdButton RTDBtnTrkPerTalkgroupTxVoiceSignalType_A9575;

		// Token: 0x04000A43 RID: 2627
		internal global::AcpUI.AcpCopyButton CpyBtnTrkPerTalkgroupTxVoiceSignalType_A9575;

		// Token: 0x04000A44 RID: 2628
		internal global::AcpUI.AcpLabel TrkPerTalkgroupTxVoiceSignalType_A9575Comp;

		// Token: 0x04000A45 RID: 2629
		internal global::AcpUI.AcpComboBox TrkPerTalkgroupSecureClearStrapping_A9095;

		// Token: 0x04000A46 RID: 2630
		internal global::AcpUI.AcpCustomViewCheckBox CVBtnTrkPerTalkgroupSecureClearStrapping_A9095;

		// Token: 0x04000A47 RID: 2631
		internal global::AcpUI.AcpLabel LblTrkPerTalkgroupSecureClearStrapping_A9095;

		// Token: 0x04000A48 RID: 2632
		internal global::AcpUI.AcpRtdButton RTDBtnTrkPerTalkgroupSecureClearStrapping_A9095;

		// Token: 0x04000A49 RID: 2633
		internal global::AcpUI.AcpCopyButton CpyBtnTrkPerTalkgroupSecureClearStrapping_A9095;

		// Token: 0x04000A4A RID: 2634
		internal global::AcpUI.AcpLabel TrkPerTalkgroupSecureClearStrapping_A9095Comp;

		// Token: 0x04000A4B RID: 2635
		internal global::AcpUI.AcpComboBox TrkPerTalkgroupKeySelect_A8365;

		// Token: 0x04000A4C RID: 2636
		internal global::AcpUI.AcpCustomViewCheckBox CVBtnTrkPerTalkgroupKeySelect_A8365;

		// Token: 0x04000A4D RID: 2637
		internal global::AcpUI.AcpLabel LblTrkPerTalkgroupKeySelect_A8365;

		// Token: 0x04000A4E RID: 2638
		internal global::AcpUI.AcpRtdButton RTDBtnTrkPerTalkgroupKeySelect_A8365;

		// Token: 0x04000A4F RID: 2639
		internal global::AcpUI.AcpCopyButton CpyBtnTrkPerTalkgroupKeySelect_A8365;

		// Token: 0x04000A50 RID: 2640
		internal global::AcpUI.AcpLabel TrkPerTalkgroupKeySelect_A8365Comp;

		// Token: 0x04000A51 RID: 2641
		internal global::AcpUI.AcpCheckBox TrkPerTalkgroupTalkgroupFailsoft_A8005;

		// Token: 0x04000A52 RID: 2642
		internal global::AcpUI.AcpCustomViewCheckBox CVBtnTrkPerTalkgroupTalkgroupFailsoft_A8005;

		// Token: 0x04000A53 RID: 2643
		internal global::AcpUI.AcpLabel LblTrkPerTalkgroupTalkgroupFailsoft_A8005;

		// Token: 0x04000A54 RID: 2644
		internal global::AcpUI.AcpRtdButton RTDBtnTrkPerTalkgroupTalkgroupFailsoft_A8005;

		// Token: 0x04000A55 RID: 2645
		internal global::AcpUI.AcpCopyButton CpyBtnTrkPerTalkgroupTalkgroupFailsoft_A8005;

		// Token: 0x04000A56 RID: 2646
		internal global::AcpUI.AcpCheckBox TrkPerTalkgroupTalkgroupFailsoft_A8005Comp;

		// Token: 0x04000A57 RID: 2647
		internal global::AcpUI.AcpTextBox TrkPerTalkgroupFailsoftRxFrequencyMHz_A8001;

		// Token: 0x04000A58 RID: 2648
		internal global::AcpUI.AcpCustomViewCheckBox CVBtnTrkPerTalkgroupFailsoftRxFrequencyMHz_A8001;

		// Token: 0x04000A59 RID: 2649
		internal global::AcpUI.AcpLabel LblTrkPerTalkgroupFailsoftRxFrequencyMHz_A8001;

		// Token: 0x04000A5A RID: 2650
		internal global::AcpUI.AcpRtdButton RTDBtnTrkPerTalkgroupFailsoftRxFrequencyMHz_A8001;

		// Token: 0x04000A5B RID: 2651
		internal global::AcpUI.AcpCopyButton CpyBtnTrkPerTalkgroupFailsoftRxFrequencyMHz_A8001;

		// Token: 0x04000A5C RID: 2652
		internal global::AcpUI.AcpLabel TrkPerTalkgroupFailsoftRxFrequencyMHz_A8001Comp;

		// Token: 0x04000A5D RID: 2653
		internal global::AcpUI.AcpTextBox TrkPerTalkgroupFailsoftTxFrequencyMHz_A8003;

		// Token: 0x04000A5E RID: 2654
		internal global::AcpUI.AcpCustomViewCheckBox CVBtnTrkPerTalkgroupFailsoftTxFrequencyMHz_A8003;

		// Token: 0x04000A5F RID: 2655
		internal global::AcpUI.AcpLabel LblTrkPerTalkgroupFailsoftTxFrequencyMHz_A8003;

		// Token: 0x04000A60 RID: 2656
		internal global::AcpUI.AcpRtdButton RTDBtnTrkPerTalkgroupFailsoftTxFrequencyMHz_A8003;

		// Token: 0x04000A61 RID: 2657
		internal global::AcpUI.AcpCopyButton CpyBtnTrkPerTalkgroupFailsoftTxFrequencyMHz_A8003;

		// Token: 0x04000A62 RID: 2658
		internal global::AcpUI.AcpLabel TrkPerTalkgroupFailsoftTxFrequencyMHz_A8003Comp;

		// Token: 0x04000A63 RID: 2659
		internal global::AcpUI.AcpCheckBox TrkPerTalkgroupTGSecondaryFailsoft_A19989;

		// Token: 0x04000A64 RID: 2660
		internal global::AcpUI.AcpCustomViewCheckBox CVBtnTrkPerTalkgroupTGSecondaryFailsoft_A19989;

		// Token: 0x04000A65 RID: 2661
		internal global::AcpUI.AcpLabel LblTrkPerTalkgroupTGSecondaryFailsoft_A19989;

		// Token: 0x04000A66 RID: 2662
		internal global::AcpUI.AcpRtdButton RTDBtnTrkPerTalkgroupTGSecondaryFailsoft_A19989;

		// Token: 0x04000A67 RID: 2663
		internal global::AcpUI.AcpCopyButton CpyBtnTrkPerTalkgroupTGSecondaryFailsoft_A19989;

		// Token: 0x04000A68 RID: 2664
		internal global::AcpUI.AcpCheckBox TrkPerTalkgroupTGSecondaryFailsoft_A19989Comp;

		// Token: 0x04000A69 RID: 2665
		internal global::AcpUI.AcpTextBox TrkPerTalkgroupSecondaryFailsoftRxFrequencyMHz_A8900;

		// Token: 0x04000A6A RID: 2666
		internal global::AcpUI.AcpCustomViewCheckBox CVBtnTrkPerTalkgroupSecondaryFailsoftRxFrequencyMHz_A8900;

		// Token: 0x04000A6B RID: 2667
		internal global::AcpUI.AcpLabel LblTrkPerTalkgroupSecondaryFailsoftRxFrequencyMHz_A8900;

		// Token: 0x04000A6C RID: 2668
		internal global::AcpUI.AcpRtdButton RTDBtnTrkPerTalkgroupSecondaryFailsoftRxFrequencyMHz_A8900;

		// Token: 0x04000A6D RID: 2669
		internal global::AcpUI.AcpCopyButton CpyBtnTrkPerTalkgroupSecondaryFailsoftRxFrequencyMHz_A8900;

		// Token: 0x04000A6E RID: 2670
		internal global::AcpUI.AcpLabel TrkPerTalkgroupSecondaryFailsoftRxFrequencyMHz_A8900Comp;

		// Token: 0x04000A6F RID: 2671
		internal global::AcpUI.AcpTextBox TrkPerTalkgroupSecondaryFailsoftTxFrequencyMHz_A8902;

		// Token: 0x04000A70 RID: 2672
		internal global::AcpUI.AcpCustomViewCheckBox CVBtnTrkPerTalkgroupSecondaryFailsoftTxFrequencyMHz_A8902;

		// Token: 0x04000A71 RID: 2673
		internal global::AcpUI.AcpLabel LblTrkPerTalkgroupSecondaryFailsoftTxFrequencyMHz_A8902;

		// Token: 0x04000A72 RID: 2674
		internal global::AcpUI.AcpRtdButton RTDBtnTrkPerTalkgroupSecondaryFailsoftTxFrequencyMHz_A8902;

		// Token: 0x04000A73 RID: 2675
		internal global::AcpUI.AcpCopyButton CpyBtnTrkPerTalkgroupSecondaryFailsoftTxFrequencyMHz_A8902;

		// Token: 0x04000A74 RID: 2676
		internal global::AcpUI.AcpLabel TrkPerTalkgroupSecondaryFailsoftTxFrequencyMHz_A8902Comp;

		// Token: 0x04000A75 RID: 2677
		internal global::AcpUI.AcpTextBoxSpinnerDecHex TrkPerTalkgroupTGSystemID_A19715;

		// Token: 0x04000A76 RID: 2678
		internal global::AcpUI.AcpCustomViewCheckBox CVBtnTrkPerTalkgroupTGSystemID_A19715;

		// Token: 0x04000A77 RID: 2679
		internal global::AcpUI.AcpLabel LblTrkPerTalkgroupTGSystemID_A19715;

		// Token: 0x04000A78 RID: 2680
		internal global::AcpUI.AcpRtdButton RTDBtnTrkPerTalkgroupTGSystemID_A19715;

		// Token: 0x04000A79 RID: 2681
		internal global::AcpUI.AcpCopyButton CpyBtnTrkPerTalkgroupTGSystemID_A19715;

		// Token: 0x04000A7A RID: 2682
		internal global::AcpUI.AcpTextBoxDecHex TrkPerTalkgroupTGSystemID_A19715Comp;

		// Token: 0x04000A7B RID: 2683
		internal global::AcpUI.AcpTextBoxSpinnerDecHex TrkPerTalkgroupTGWACNID_A19716;

		// Token: 0x04000A7C RID: 2684
		internal global::AcpUI.AcpCustomViewCheckBox CVBtnTrkPerTalkgroupTGWACNID_A19716;

		// Token: 0x04000A7D RID: 2685
		internal global::AcpUI.AcpLabel LblTrkPerTalkgroupTGWACNID_A19716;

		// Token: 0x04000A7E RID: 2686
		internal global::AcpUI.AcpRtdButton RTDBtnTrkPerTalkgroupTGWACNID_A19716;

		// Token: 0x04000A7F RID: 2687
		internal global::AcpUI.AcpCopyButton CpyBtnTrkPerTalkgroupTGWACNID_A19716;

		// Token: 0x04000A80 RID: 2688
		internal global::AcpUI.AcpTextBoxDecHex TrkPerTalkgroupTGWACNID_A19716Comp;

		// Token: 0x04000A81 RID: 2689
		internal global::AcpUI.AcpComboBox TrkPerTalkgroupAstroOTARProfileIndex_43687;

		// Token: 0x04000A82 RID: 2690
		internal global::AcpUI.AcpCustomViewCheckBox CVBtnTrkPerTalkgroupAstroOTARProfileIndex_43687;

		// Token: 0x04000A83 RID: 2691
		internal global::AcpUI.AcpLabel LblTrkPerTalkgroupAstroOTARProfileIndex_43687;

		// Token: 0x04000A84 RID: 2692
		internal global::AcpUI.AcpRtdButton RTDBtnTrkPerTalkgroupAstroOTARProfileIndex_43687;

		// Token: 0x04000A85 RID: 2693
		internal global::AcpUI.AcpCopyButton CpyBtnTrkPerTalkgroupAstroOTARProfileIndex_43687;

		// Token: 0x04000A86 RID: 2694
		internal global::AcpUI.AcpLabel TrkPerTalkgroupAstroOTARProfileIndex_43687Comp;

		// Token: 0x04000A87 RID: 2695
		internal global::AcpUI.AcpExpander ExpanderTrunkingPersonalityCallPage;

		// Token: 0x04000A88 RID: 2696
		internal global::AcpUI.AcpGroupBox GrpBoxExpanderTrunkingPersonalityCallPagePseudo0;

		// Token: 0x04000A89 RID: 2697
		internal global::AcpUI.AcpCustomViewCheckBox CVBtnTrkPerCallPagePrivateCallType_A8760;

		// Token: 0x04000A8A RID: 2698
		internal global::AcpUI.AcpLabel LblTrkPerCallPagePrivateCallType_A8760;

		// Token: 0x04000A8B RID: 2699
		internal global::AcpUI.AcpComboBox TrkPerCallPagePrivateCallType_A8760;

		// Token: 0x04000A8C RID: 2700
		internal global::AcpUI.AcpRtdButton RTDBtnTrkPerCallPagePrivateCallType_A8760;

		// Token: 0x04000A8D RID: 2701
		internal global::AcpUI.AcpCopyButton CpyBtnTrkPerCallPagePrivateCallType_A8760;

		// Token: 0x04000A8E RID: 2702
		internal global::AcpUI.AcpLabel TrkPerCallPagePrivateCallType_A8760Comp;

		// Token: 0x04000A8F RID: 2703
		internal global::AcpUI.AcpCustomViewCheckBox CVBtnTrkPerCallPagePrivateCallOperation_A8759;

		// Token: 0x04000A90 RID: 2704
		internal global::AcpUI.AcpLabel LblTrkPerCallPagePrivateCallOperation_A8759;

		// Token: 0x04000A91 RID: 2705
		internal global::AcpUI.AcpComboBox TrkPerCallPagePrivateCallOperation_A8759;

		// Token: 0x04000A92 RID: 2706
		internal global::AcpUI.AcpRtdButton RTDBtnTrkPerCallPagePrivateCallOperation_A8759;

		// Token: 0x04000A93 RID: 2707
		internal global::AcpUI.AcpCopyButton CpyBtnTrkPerCallPagePrivateCallOperation_A8759;

		// Token: 0x04000A94 RID: 2708
		internal global::AcpUI.AcpLabel TrkPerCallPagePrivateCallOperation_A8759Comp;

		// Token: 0x04000A95 RID: 2709
		internal global::AcpUI.AcpCustomViewCheckBox CVBtnTrkPerCallPageCallAlertPageOperation_A7597;

		// Token: 0x04000A96 RID: 2710
		internal global::AcpUI.AcpLabel LblTrkPerCallPageCallAlertPageOperation_A7597;

		// Token: 0x04000A97 RID: 2711
		internal global::AcpUI.AcpComboBox TrkPerCallPageCallAlertPageOperation_A7597;

		// Token: 0x04000A98 RID: 2712
		internal global::AcpUI.AcpRtdButton RTDBtnTrkPerCallPageCallAlertPageOperation_A7597;

		// Token: 0x04000A99 RID: 2713
		internal global::AcpUI.AcpCopyButton CpyBtnTrkPerCallPageCallAlertPageOperation_A7597;

		// Token: 0x04000A9A RID: 2714
		internal global::AcpUI.AcpLabel TrkPerCallPageCallAlertPageOperation_A7597Comp;

		// Token: 0x04000A9B RID: 2715
		internal global::AcpUI.AcpCustomViewCheckBox CVBtnTrkPerCallPageHotListItemID_A19982;

		// Token: 0x04000A9C RID: 2716
		internal global::AcpUI.AcpLabel LblTrkPerCallPageHotListItemID_A19982;

		// Token: 0x04000A9D RID: 2717
		internal global::AcpUI.AcpComboBox TrkPerCallPageHotListItemID_A19982;

		// Token: 0x04000A9E RID: 2718
		internal global::AcpUI.AcpRtdButton RTDBtnTrkPerCallPageHotListItemID_A19982;

		// Token: 0x04000A9F RID: 2719
		internal global::AcpUI.AcpCopyButton CpyBtnTrkPerCallPageHotListItemID_A19982;

		// Token: 0x04000AA0 RID: 2720
		internal global::AcpUI.AcpLabel TrkPerCallPageHotListItemID_A19982Comp;

		// Token: 0x04000AA1 RID: 2721
		internal global::AcpUI.AcpCustomViewCheckBox CVBtnTrkPerCallPageInCallUserAlertEnable_A9434;

		// Token: 0x04000AA2 RID: 2722
		internal global::AcpUI.AcpLabel LblTrkPerCallPageInCallUserAlertEnable_A9434;

		// Token: 0x04000AA3 RID: 2723
		internal global::AcpUI.AcpCheckBox TrkPerCallPageInCallUserAlertEnable_A9434;

		// Token: 0x04000AA4 RID: 2724
		internal global::AcpUI.AcpRtdButton RTDBtnTrkPerCallPageInCallUserAlertEnable_A9434;

		// Token: 0x04000AA5 RID: 2725
		internal global::AcpUI.AcpCopyButton CpyBtnTrkPerCallPageInCallUserAlertEnable_A9434;

		// Token: 0x04000AA6 RID: 2726
		internal global::AcpUI.AcpCheckBox TrkPerCallPageInCallUserAlertEnable_A9434Comp;

		// Token: 0x04000AA7 RID: 2727
		internal global::AcpUI.AcpCustomViewCheckBox CVBtnTrkPerCallPageAutomaticCallAlert_A9754;

		// Token: 0x04000AA8 RID: 2728
		internal global::AcpUI.AcpLabel LblTrkPerCallPageAutomaticCallAlert_A9754;

		// Token: 0x04000AA9 RID: 2729
		internal global::AcpUI.AcpCheckBox TrkPerCallPageAutomaticCallAlert_A9754;

		// Token: 0x04000AAA RID: 2730
		internal global::AcpUI.AcpRtdButton RTDBtnTrkPerCallPageAutomaticCallAlert_A9754;

		// Token: 0x04000AAB RID: 2731
		internal global::AcpUI.AcpCopyButton CpyBtnTrkPerCallPageAutomaticCallAlert_A9754;

		// Token: 0x04000AAC RID: 2732
		internal global::AcpUI.AcpCheckBox TrkPerCallPageAutomaticCallAlert_A9754Comp;

		// Token: 0x04000AAD RID: 2733
		internal global::AcpUI.AcpCustomViewCheckBox CVBtnTrkPerFeaturesAstroAlertingToneTable;

		// Token: 0x04000AAE RID: 2734
		internal global::AcpUI.AcpLabel LblTrkPerFeaturesAstroAlertingToneTable;

		// Token: 0x04000AAF RID: 2735
		internal global::AcpUI.AcpComboBox TrkPerFeaturesAstroAlertingToneTable;

		// Token: 0x04000AB0 RID: 2736
		internal global::AcpUI.AcpRtdButton RTDBtnTrkPerFeaturesAstroAlertingToneTable;

		// Token: 0x04000AB1 RID: 2737
		internal global::AcpUI.AcpCopyButton CpyBtnTrkPerFeaturesAstroAlertingToneTable;

		// Token: 0x04000AB2 RID: 2738
		internal global::AcpUI.AcpLabel TrkPerFeaturesAstroAlertingToneTableComp;

		// Token: 0x04000AB3 RID: 2739
		internal global::AcpUI.AcpExpander ExpanderTrunkingPersonalityFeatures;

		// Token: 0x04000AB4 RID: 2740
		internal global::AcpUI.AcpGroupBox GrpBoxExpanderTrunkingPersonalityFeaturesPseudo0;

		// Token: 0x04000AB5 RID: 2741
		internal global::AcpUI.AcpCustomViewCheckBox CVBtnTrkPerFeaturesPhoneOperation_A8701;

		// Token: 0x04000AB6 RID: 2742
		internal global::AcpUI.AcpLabel LblTrkPerFeaturesPhoneOperation_A8701;

		// Token: 0x04000AB7 RID: 2743
		internal global::AcpUI.AcpComboBox TrkPerFeaturesPhoneOperation_A8701;

		// Token: 0x04000AB8 RID: 2744
		internal global::AcpUI.AcpRtdButton RTDBtnTrkPerFeaturesPhoneOperation_A8701;

		// Token: 0x04000AB9 RID: 2745
		internal global::AcpUI.AcpCopyButton CpyBtnTrkPerFeaturesPhoneOperation_A8701;

		// Token: 0x04000ABA RID: 2746
		internal global::AcpUI.AcpLabel TrkPerFeaturesPhoneOperation_A8701Comp;

		// Token: 0x04000ABB RID: 2747
		internal global::AcpUI.AcpGroupBox GrpBoxExpanderTrunkingPersonalityFeaturesScan;

		// Token: 0x04000ABC RID: 2748
		internal global::AcpUI.AcpCustomViewCheckBox CVBtnTrkPerFeaturesScanListSelection_A9053;

		// Token: 0x04000ABD RID: 2749
		internal global::AcpUI.AcpLabel LblTrkPerFeaturesScanListSelection_A9053;

		// Token: 0x04000ABE RID: 2750
		internal global::AcpUI.AcpComboBox TrkPerFeaturesScanListSelection_A9053;

		// Token: 0x04000ABF RID: 2751
		internal global::AcpUI.AcpRtdButton RTDBtnTrkPerFeaturesScanListSelection_A9053;

		// Token: 0x04000AC0 RID: 2752
		internal global::AcpUI.AcpCopyButton CpyBtnTrkPerFeaturesScanListSelection_A9053;

		// Token: 0x04000AC1 RID: 2753
		internal global::AcpUI.AcpLabel TrkPerFeaturesScanListSelection_A9053Comp;

		// Token: 0x04000AC2 RID: 2754
		internal global::AcpUI.AcpCustomViewCheckBox CVBtnTrkPerFeaturesAutomaticScan_A7528;

		// Token: 0x04000AC3 RID: 2755
		internal global::AcpUI.AcpLabel LblTrkPerFeaturesAutomaticScan_A7528;

		// Token: 0x04000AC4 RID: 2756
		internal global::AcpUI.AcpCheckBox TrkPerFeaturesAutomaticScan_A7528;

		// Token: 0x04000AC5 RID: 2757
		internal global::AcpUI.AcpRtdButton RTDBtnTrkPerFeaturesAutomaticScan_A7528;

		// Token: 0x04000AC6 RID: 2758
		internal global::AcpUI.AcpCopyButton CpyBtnTrkPerFeaturesAutomaticScan_A7528;

		// Token: 0x04000AC7 RID: 2759
		internal global::AcpUI.AcpCheckBox TrkPerFeaturesAutomaticScan_A7528Comp;

		// Token: 0x04000AC8 RID: 2760
		internal global::AcpUI.AcpGroupBox GrpBoxExpanderTrunkingPersonalityFeaturesStatusMessage;

		// Token: 0x04000AC9 RID: 2761
		internal global::AcpUI.AcpCustomViewCheckBox CVBtnTrkPerFeaturesStatusEnable_A9188;

		// Token: 0x04000ACA RID: 2762
		internal global::AcpUI.AcpLabel LblTrkPerFeaturesStatusEnable_A9188;

		// Token: 0x04000ACB RID: 2763
		internal global::AcpUI.AcpCheckBox TrkPerFeaturesStatusEnable_A9188;

		// Token: 0x04000ACC RID: 2764
		internal global::AcpUI.AcpRtdButton RTDBtnTrkPerFeaturesStatusEnable_A9188;

		// Token: 0x04000ACD RID: 2765
		internal global::AcpUI.AcpCopyButton CpyBtnTrkPerFeaturesStatusEnable_A9188;

		// Token: 0x04000ACE RID: 2766
		internal global::AcpUI.AcpCheckBox TrkPerFeaturesStatusEnable_A9188Comp;

		// Token: 0x04000ACF RID: 2767
		internal global::AcpUI.AcpCustomViewCheckBox CVBtnTrkPerFeaturesMessageEnable_A8499;

		// Token: 0x04000AD0 RID: 2768
		internal global::AcpUI.AcpLabel LblTrkPerFeaturesMessageEnable_A8499;

		// Token: 0x04000AD1 RID: 2769
		internal global::AcpUI.AcpCheckBox TrkPerFeaturesMessageEnable_A8499;

		// Token: 0x04000AD2 RID: 2770
		internal global::AcpUI.AcpRtdButton RTDBtnTrkPerFeaturesMessageEnable_A8499;

		// Token: 0x04000AD3 RID: 2771
		internal global::AcpUI.AcpCopyButton CpyBtnTrkPerFeaturesMessageEnable_A8499;

		// Token: 0x04000AD4 RID: 2772
		internal global::AcpUI.AcpCheckBox TrkPerFeaturesMessageEnable_A8499Comp;

		// Token: 0x04000AD5 RID: 2773
		internal global::AcpUI.AcpGroupBox GrpBoxExpanderTrunkingPersonalityFeaturesRadioErgo;

		// Token: 0x04000AD6 RID: 2774
		internal global::AcpUI.AcpCustomViewCheckBox CVBtnTrkPerFeaturesTalkPermitTone_A9271;

		// Token: 0x04000AD7 RID: 2775
		internal global::AcpUI.AcpLabel LblTrkPerFeaturesTalkPermitTone_A9271;

		// Token: 0x04000AD8 RID: 2776
		internal global::AcpUI.AcpCheckBox TrkPerFeaturesTalkPermitTone_A9271;

		// Token: 0x04000AD9 RID: 2777
		internal global::AcpUI.AcpRtdButton RTDBtnTrkPerFeaturesTalkPermitTone_A9271;

		// Token: 0x04000ADA RID: 2778
		internal global::AcpUI.AcpCopyButton CpyBtnTrkPerFeaturesTalkPermitTone_A9271;

		// Token: 0x04000ADB RID: 2779
		internal global::AcpUI.AcpCheckBox TrkPerFeaturesTalkPermitTone_A9271Comp;

		// Token: 0x04000ADC RID: 2780
		internal global::AcpUI.AcpGroupBox GrpBoxExpanderTrunkingPersonalityFeaturesPseudo3;

		// Token: 0x04000ADD RID: 2781
		internal global::AcpUI.AcpCustomViewCheckBox CVBtnTrkPerFeaturesSecureProperCodeDetect_A8763;

		// Token: 0x04000ADE RID: 2782
		internal global::AcpUI.AcpLabel LblTrkPerFeaturesSecureProperCodeDetect_A8763;

		// Token: 0x04000ADF RID: 2783
		internal global::AcpUI.AcpCheckBox TrkPerFeaturesSecureProperCodeDetect_A8763;

		// Token: 0x04000AE0 RID: 2784
		internal global::AcpUI.AcpRtdButton RTDBtnTrkPerFeaturesSecureProperCodeDetect_A8763;

		// Token: 0x04000AE1 RID: 2785
		internal global::AcpUI.AcpCopyButton CpyBtnTrkPerFeaturesSecureProperCodeDetect_A8763;

		// Token: 0x04000AE2 RID: 2786
		internal global::AcpUI.AcpCheckBox TrkPerFeaturesSecureProperCodeDetect_A8763Comp;

		// Token: 0x04000AE3 RID: 2787
		internal global::AcpUI.AcpCustomViewCheckBox CVBtnTrkPerIgnoreRxClearVoice_A41610;

		// Token: 0x04000AE4 RID: 2788
		internal global::AcpUI.AcpLabel LblTrkPerIgnoreRxClearVoice_A41610;

		// Token: 0x04000AE5 RID: 2789
		internal global::AcpUI.AcpCheckBox TrkPerIgnoreRxClearVoice_A41610;

		// Token: 0x04000AE6 RID: 2790
		internal global::AcpUI.AcpRtdButton RTDBtnTrkPerIgnoreRxClearVoice_A41610;

		// Token: 0x04000AE7 RID: 2791
		internal global::AcpUI.AcpCopyButton CpyBtnTrkPerIgnoreRxClearVoice_A41610;

		// Token: 0x04000AE8 RID: 2792
		internal global::AcpUI.AcpCheckBox TrkPerIgnoreRxClearVoice_A41610Comp;

		// Token: 0x04000AE9 RID: 2793
		internal global::AcpUI.AcpCustomViewCheckBox CVBtnTrkPerFeaturesHotKeypadDTMF_A8209;

		// Token: 0x04000AEA RID: 2794
		internal global::AcpUI.AcpLabel LblTrkPerFeaturesHotKeypadDTMF_A8209;

		// Token: 0x04000AEB RID: 2795
		internal global::AcpUI.AcpCheckBox TrkPerFeaturesHotKeypadDTMF_A8209;

		// Token: 0x04000AEC RID: 2796
		internal global::AcpUI.AcpRtdButton RTDBtnTrkPerFeaturesHotKeypadDTMF_A8209;

		// Token: 0x04000AED RID: 2797
		internal global::AcpUI.AcpCopyButton CpyBtnTrkPerFeaturesHotKeypadDTMF_A8209;

		// Token: 0x04000AEE RID: 2798
		internal global::AcpUI.AcpCheckBox TrkPerFeaturesHotKeypadDTMF_A8209Comp;

		// Token: 0x04000AEF RID: 2799
		internal global::AcpUI.AcpCustomViewCheckBox CVBtnTrkPerFeatureDTMFMicEn_A42482;

		// Token: 0x04000AF0 RID: 2800
		internal global::AcpUI.AcpLabel LblTrkPerFeatureDTMFMicEn_A42482;

		// Token: 0x04000AF1 RID: 2801
		internal global::AcpUI.AcpCheckBox TrkPerFeatureDTMFMicEn_A42482;

		// Token: 0x04000AF2 RID: 2802
		internal global::AcpUI.AcpRtdButton RTDBtnTrkPerFeatureDTMFMicEn_A42482;

		// Token: 0x04000AF3 RID: 2803
		internal global::AcpUI.AcpCopyButton CpyBtnTrkPerFeatureDTMFMicEn_A42482;

		// Token: 0x04000AF4 RID: 2804
		internal global::AcpUI.AcpCheckBox TrkPerFeatureDTMFMicEn_A42482Comp;

		// Token: 0x04000AF5 RID: 2805
		internal global::AcpUI.AcpCustomViewCheckBox CVBtnTrkPerEndTxOnVoiceAbsence_42461;

		// Token: 0x04000AF6 RID: 2806
		internal global::AcpUI.AcpLabel LblTrkPerEndTxOnVoiceAbsence_42461;

		// Token: 0x04000AF7 RID: 2807
		internal global::AcpUI.AcpCheckBox TrkPerEndTxOnVoiceAbsence_42461;

		// Token: 0x04000AF8 RID: 2808
		internal global::AcpUI.AcpRtdButton RTDBtnTrkPerEndTxOnVoiceAbsence_42461;

		// Token: 0x04000AF9 RID: 2809
		internal global::AcpUI.AcpCopyButton CpyBtnTrkPerEndTxOnVoiceAbsence_42461;

		// Token: 0x04000AFA RID: 2810
		internal global::AcpUI.AcpCheckBox TrkPerEndTxOnVoiceAbsence_42461Comp;

		// Token: 0x04000AFB RID: 2811
		internal global::AcpUI.AcpCustomViewCheckBox CVBtnTrkPerFeaturesPriorityDispatchTimeOutTimersec_43598;

		// Token: 0x04000AFC RID: 2812
		internal global::AcpUI.AcpLabel LblTrkPerFeaturesPriorityDispatchTimeOutTimersec_43598;

		// Token: 0x04000AFD RID: 2813
		internal global::AcpUI.AcpTextBoxSpinner TrkPerFeaturesPriorityDispatchTimeOutTimersec_43598;

		// Token: 0x04000AFE RID: 2814
		internal global::AcpUI.AcpRtdButton RTDBtnTrkPerFeaturesPriorityDispatchTimeOutTimersec_43598;

		// Token: 0x04000AFF RID: 2815
		internal global::AcpUI.AcpCopyButton CpyBtnTrkPerFeaturesPriorityDispatchTimeOutTimersec_43598;

		// Token: 0x04000B00 RID: 2816
		internal global::AcpUI.AcpLabel TrkPerFeaturesPriorityDispatchTimeOutTimersec_43598Comp;

		// Token: 0x04000B01 RID: 2817
		internal global::AcpUI.AcpCustomViewCheckBox CVBtnTrkPerFeatureBackupPTTOperation_A43628;

		// Token: 0x04000B02 RID: 2818
		internal global::AcpUI.AcpLabel LblTrkPerFeatureBackupPTTOperation_A43628;

		// Token: 0x04000B03 RID: 2819
		internal global::AcpUI.AcpComboBox TrkPerFeatureBackupPTTOperation_A43628;

		// Token: 0x04000B04 RID: 2820
		internal global::AcpUI.AcpRtdButton RTDBtnTrkPerFeatureBackupPTTOperation_A43628;

		// Token: 0x04000B05 RID: 2821
		internal global::AcpUI.AcpCopyButton CpyBtnTrkPerFeatureBackupPTTOperation_A43628;

		// Token: 0x04000B06 RID: 2822
		internal global::AcpUI.AcpLabel TrkPerFeatureBackupPTTOperation_A43628Comp;

		// Token: 0x04000B07 RID: 2823
		internal global::AcpUI.AcpCustomViewCheckBox CVBtnTrkPerFeaturesHazardZoneModePersonality;

		// Token: 0x04000B08 RID: 2824
		internal global::AcpUI.AcpLabel LblTrkPerFeaturesHazardZoneModePersonality;

		// Token: 0x04000B09 RID: 2825
		internal global::AcpUI.AcpCheckBox TrkPerFeaturesHazardZoneModePersonality;

		// Token: 0x04000B0A RID: 2826
		internal global::AcpUI.AcpRtdButton RTDBtnTrkPerFeaturesHazardZoneModePersonality;

		// Token: 0x04000B0B RID: 2827
		internal global::AcpUI.AcpCopyButton CpyBtnTrkPerFeaturesHazardZoneModePersonality;

		// Token: 0x04000B0C RID: 2828
		internal global::AcpUI.AcpCheckBox TrkPerFeaturesHazardZoneModePersonalityComp;

		// Token: 0x04000B0D RID: 2829
		internal global::AcpUI.AcpCustomViewCheckBox CVBtnTrkPerFeaturesTacticalPublicSafetyUIEnable;

		// Token: 0x04000B0E RID: 2830
		internal global::AcpUI.AcpLabel LblTrkPerFeaturesTacticalPublicSafetyUIEnable;

		// Token: 0x04000B0F RID: 2831
		internal global::AcpUI.AcpCheckBox TrkPerFeaturesTacticalPublicSafetyUIEnable;

		// Token: 0x04000B10 RID: 2832
		internal global::AcpUI.AcpRtdButton RTDBtnTrkPerFeaturesTacticalPublicSafetyUIEnable;

		// Token: 0x04000B11 RID: 2833
		internal global::AcpUI.AcpCopyButton CpyBtnTrkPerFeaturesTacticalPublicSafetyUIEnable;

		// Token: 0x04000B12 RID: 2834
		internal global::AcpUI.AcpCheckBox TrkPerFeaturesTacticalPublicSafetyUIEnableComp;

		// Token: 0x04000B13 RID: 2835
		internal global::AcpUI.AcpExpander ExpanderTrunkingPersonalityPreferredSites;

		// Token: 0x04000B14 RID: 2836
		internal global::AcpUI.AcpChildRecNavToolbar RecNavToolbarExpanderTrunkingPersonalityPreferredSitesTable;

		// Token: 0x04000B15 RID: 2837
		internal global::AcpUI.AcpGroupBox GrpBoxExpanderTrunkingPersonalityPreferredSitesPseudo0;

		// Token: 0x04000B16 RID: 2838
		internal global::AcpUI.AcpCustomViewCheckBox CVBtnTrkPerPreferredSitesIgnoreSiteResourcePreference_A8239;

		// Token: 0x04000B17 RID: 2839
		internal global::AcpUI.AcpLabel LblTrkPerPreferredSitesIgnoreSiteResourcePreference_A8239;

		// Token: 0x04000B18 RID: 2840
		internal global::AcpUI.AcpCheckBox TrkPerPreferredSitesIgnoreSiteResourcePreference_A8239;

		// Token: 0x04000B19 RID: 2841
		internal global::AcpUI.AcpRtdButton RTDBtnTrkPerPreferredSitesIgnoreSiteResourcePreference_A8239;

		// Token: 0x04000B1A RID: 2842
		internal global::AcpUI.AcpCopyButton CpyBtnTrkPerPreferredSitesIgnoreSiteResourcePreference_A8239;

		// Token: 0x04000B1B RID: 2843
		internal global::AcpUI.AcpCheckBox TrkPerPreferredSitesIgnoreSiteResourcePreference_A8239Comp;

		// Token: 0x04000B1C RID: 2844
		internal global::AcpUI.AcpCustomViewCheckBox CVBtnTrkPerPreferredSitesSiteListType_A43581;

		// Token: 0x04000B1D RID: 2845
		internal global::AcpUI.AcpLabel LblTrkPerPreferredSitesSiteListType_A43581;

		// Token: 0x04000B1E RID: 2846
		internal global::AcpUI.AcpComboBox TrkPerPreferredSitesSiteListType_A43581;

		// Token: 0x04000B1F RID: 2847
		internal global::AcpUI.AcpRtdButton RTDBtnTrkPerPreferredSitesSiteListType_A43581;

		// Token: 0x04000B20 RID: 2848
		internal global::AcpUI.AcpCopyButton CpyBtnTrkPerPreferredSitesSiteListType_A43581;

		// Token: 0x04000B21 RID: 2849
		internal global::AcpUI.AcpLabel TrkPerPreferredSitesSiteListType_A43581Comp;

		// Token: 0x04000B22 RID: 2850
		internal global::AcpUI.AcpCustomViewCheckBox CVBtnTrkPerPreferredSitesAllowEmergencyAtBlockedSite_44910;

		// Token: 0x04000B23 RID: 2851
		internal global::AcpUI.AcpLabel LblTrkPerPreferredSitesAllowEmergencyAtBlockedSite_44910;

		// Token: 0x04000B24 RID: 2852
		internal global::AcpUI.AcpCheckBox TrkPerPreferredSitesAllowEmergencyAtBlockedSite_44910;

		// Token: 0x04000B25 RID: 2853
		internal global::AcpUI.AcpRtdButton RTDBtnTrkPerPreferredSitesAllowEmergencyAtBlockedSite_44910;

		// Token: 0x04000B26 RID: 2854
		internal global::AcpUI.AcpCopyButton CpyBtnTrkPerPreferredSitesAllowEmergencyAtBlockedSite_44910;

		// Token: 0x04000B27 RID: 2855
		internal global::AcpUI.AcpCheckBox TrkPerPreferredSitesAllowEmergencyAtBlockedSite_44910Comp;

		// Token: 0x04000B28 RID: 2856
		internal global::System.Windows.Controls.Grid ExpanderTrunkingPersonalityPreferredSitesGrid;

		// Token: 0x04000B29 RID: 2857
		internal global::System.Windows.Controls.Grid ExpanderTrunkingPersonalityPreferredSitesTableGrid;

		// Token: 0x04000B2A RID: 2858
		internal global::AcpUI.AcpGroupBox ExpanderTrunkingPersonalityPreferredSitesTableTableView;

		// Token: 0x04000B2B RID: 2859
		internal global::AcpUI.AcpXamDataPresenter ExpanderTrunkingPersonalityPreferredSitesTable;

		// Token: 0x04000B2C RID: 2860
		internal global::Infragistics.Windows.DataPresenter.UnboundField TrkPerPreferredSitesSiteID_A9151_Col;

		// Token: 0x04000B2D RID: 2861
		internal global::Infragistics.Windows.DataPresenter.UnboundField TrkPerPreferredSitesPreferredStatus_A8734_Col;

		// Token: 0x04000B2E RID: 2862
		internal global::Infragistics.Windows.DataPresenter.UnboundField TrkPerPreferredSitesSystemIDRFSSID_A9240_Col;

		// Token: 0x04000B2F RID: 2863
		internal global::Infragistics.Windows.DataPresenter.UnboundField TrkPerPreferredSitesSystemID_A19466_Col;

		// Token: 0x04000B30 RID: 2864
		internal global::Infragistics.Windows.DataPresenter.UnboundField TrkPerPreferredSitesRASWACNID_A20445_Col;

		// Token: 0x04000B31 RID: 2865
		internal global::Infragistics.Windows.DataPresenter.UnboundField TrkPerPreferredSitesWildcard_A43586_Col;

		// Token: 0x04000B32 RID: 2866
		internal global::AcpUI.AcpGroupBox ExpanderTrunkingPersonalityPreferredSitesTableSRecView;

		// Token: 0x04000B33 RID: 2867
		internal global::System.Windows.Controls.Grid gridExpanderTrunkingPersonalityPreferredSitesTableSRecView;

		// Token: 0x04000B34 RID: 2868
		internal global::AcpUI.AcpTextBoxSpinnerDecHex TrkPerPreferredSitesSiteID_A9151;

		// Token: 0x04000B35 RID: 2869
		internal global::AcpUI.AcpCustomViewCheckBox CVBtnTrkPerPreferredSitesSiteID_A9151;

		// Token: 0x04000B36 RID: 2870
		internal global::AcpUI.AcpLabel LblTrkPerPreferredSitesSiteID_A9151;

		// Token: 0x04000B37 RID: 2871
		internal global::AcpUI.AcpRtdButton RTDBtnTrkPerPreferredSitesSiteID_A9151;

		// Token: 0x04000B38 RID: 2872
		internal global::AcpUI.AcpCopyButton CpyBtnTrkPerPreferredSitesSiteID_A9151;

		// Token: 0x04000B39 RID: 2873
		internal global::AcpUI.AcpTextBoxDecHex TrkPerPreferredSitesSiteID_A9151Comp;

		// Token: 0x04000B3A RID: 2874
		internal global::AcpUI.AcpComboBox TrkPerPreferredSitesPreferredStatus_A8734;

		// Token: 0x04000B3B RID: 2875
		internal global::AcpUI.AcpCustomViewCheckBox CVBtnTrkPerPreferredSitesPreferredStatus_A8734;

		// Token: 0x04000B3C RID: 2876
		internal global::AcpUI.AcpLabel LblTrkPerPreferredSitesPreferredStatus_A8734;

		// Token: 0x04000B3D RID: 2877
		internal global::AcpUI.AcpRtdButton RTDBtnTrkPerPreferredSitesPreferredStatus_A8734;

		// Token: 0x04000B3E RID: 2878
		internal global::AcpUI.AcpCopyButton CpyBtnTrkPerPreferredSitesPreferredStatus_A8734;

		// Token: 0x04000B3F RID: 2879
		internal global::AcpUI.AcpLabel TrkPerPreferredSitesPreferredStatus_A8734Comp;

		// Token: 0x04000B40 RID: 2880
		internal global::AcpUI.AcpTextBoxSpinnerDecHex TrkPerPreferredSitesSystemIDRFSSID_A9240;

		// Token: 0x04000B41 RID: 2881
		internal global::AcpUI.AcpCustomViewCheckBox CVBtnTrkPerPreferredSitesSystemIDRFSSID_A9240;

		// Token: 0x04000B42 RID: 2882
		internal global::AcpUI.AcpLabel LblTrkPerPreferredSitesSystemIDRFSSID_A9240;

		// Token: 0x04000B43 RID: 2883
		internal global::AcpUI.AcpRtdButton RTDBtnTrkPerPreferredSitesSystemIDRFSSID_A9240;

		// Token: 0x04000B44 RID: 2884
		internal global::AcpUI.AcpCopyButton CpyBtnTrkPerPreferredSitesSystemIDRFSSID_A9240;

		// Token: 0x04000B45 RID: 2885
		internal global::AcpUI.AcpTextBoxDecHex TrkPerPreferredSitesSystemIDRFSSID_A9240Comp;

		// Token: 0x04000B46 RID: 2886
		internal global::AcpUI.AcpTextBoxSpinnerDecHex TrkPerPreferredSitesSystemID_A19466;

		// Token: 0x04000B47 RID: 2887
		internal global::AcpUI.AcpCustomViewCheckBox CVBtnTrkPerPreferredSitesSystemID_A19466;

		// Token: 0x04000B48 RID: 2888
		internal global::AcpUI.AcpLabel LblTrkPerPreferredSitesSystemID_A19466;

		// Token: 0x04000B49 RID: 2889
		internal global::AcpUI.AcpRtdButton RTDBtnTrkPerPreferredSitesSystemID_A19466;

		// Token: 0x04000B4A RID: 2890
		internal global::AcpUI.AcpCopyButton CpyBtnTrkPerPreferredSitesSystemID_A19466;

		// Token: 0x04000B4B RID: 2891
		internal global::AcpUI.AcpTextBoxDecHex TrkPerPreferredSitesSystemID_A19466Comp;

		// Token: 0x04000B4C RID: 2892
		internal global::AcpUI.AcpTextBoxSpinnerDecHex TrkPerPreferredSitesRASWACNID_A20445;

		// Token: 0x04000B4D RID: 2893
		internal global::AcpUI.AcpCustomViewCheckBox CVBtnTrkPerPreferredSitesRASWACNID_A20445;

		// Token: 0x04000B4E RID: 2894
		internal global::AcpUI.AcpLabel LblTrkPerPreferredSitesRASWACNID_A20445;

		// Token: 0x04000B4F RID: 2895
		internal global::AcpUI.AcpRtdButton RTDBtnTrkPerPreferredSitesRASWACNID_A20445;

		// Token: 0x04000B50 RID: 2896
		internal global::AcpUI.AcpCopyButton CpyBtnTrkPerPreferredSitesRASWACNID_A20445;

		// Token: 0x04000B51 RID: 2897
		internal global::AcpUI.AcpTextBoxDecHex TrkPerPreferredSitesRASWACNID_A20445Comp;

		// Token: 0x04000B52 RID: 2898
		internal global::AcpUI.AcpComboBox TrkPerPreferredSitesWildcard_A43586;

		// Token: 0x04000B53 RID: 2899
		internal global::AcpUI.AcpCustomViewCheckBox CVBtnTrkPerPreferredSitesWildcard_A43586;

		// Token: 0x04000B54 RID: 2900
		internal global::AcpUI.AcpLabel LblTrkPerPreferredSitesWildcard_A43586;

		// Token: 0x04000B55 RID: 2901
		internal global::AcpUI.AcpRtdButton RTDBtnTrkPerPreferredSitesWildcard_A43586;

		// Token: 0x04000B56 RID: 2902
		internal global::AcpUI.AcpCopyButton CpyBtnTrkPerPreferredSitesWildcard_A43586;

		// Token: 0x04000B57 RID: 2903
		internal global::AcpUI.AcpLabel TrkPerPreferredSitesWildcard_A43586Comp;

		// Token: 0x04000B58 RID: 2904
		internal global::AcpUI.AcpExpander ExpanderTrunkingPersonalityLabtool;

		// Token: 0x04000B59 RID: 2905
		internal global::AcpUI.AcpGroupBox GrpBoxExpanderTrunkingPersonalityLabtoolPseudo0;

		// Token: 0x04000B5A RID: 2906
		internal global::AcpUI.AcpCustomViewCheckBox CVBtnTrkPerLabtoolSystemKey_A9242;

		// Token: 0x04000B5B RID: 2907
		internal global::AcpUI.AcpLabel LblTrkPerLabtoolSystemKey_A9242;

		// Token: 0x04000B5C RID: 2908
		internal global::AcpUI.AcpLabel TrkPerLabtoolSystemKey_A9242;

		// Token: 0x04000B5D RID: 2909
		internal global::AcpUI.AcpRtdButton RTDBtnTrkPerLabtoolSystemKey_A9242;

		// Token: 0x04000B5E RID: 2910
		internal global::AcpUI.AcpCopyButton CpyBtnTrkPerLabtoolSystemKey_A9242;

		// Token: 0x04000B5F RID: 2911
		internal global::AcpUI.AcpLabel TrkPerLabtoolSystemKey_A9242Comp;

		// Token: 0x04000B60 RID: 2912
		internal global::AcpUI.AcpCustomViewCheckBox CVBtnTrkPerLabtoolTrunkingPersonalityPreferredSiteStatusListItemID_A19962;

		// Token: 0x04000B61 RID: 2913
		internal global::AcpUI.AcpLabel LblTrkPerLabtoolTrunkingPersonalityPreferredSiteStatusListItemID_A19962;

		// Token: 0x04000B62 RID: 2914
		internal global::AcpUI.AcpComboBox TrkPerLabtoolTrunkingPersonalityPreferredSiteStatusListItemID_A19962;

		// Token: 0x04000B63 RID: 2915
		internal global::AcpUI.AcpRtdButton RTDBtnTrkPerLabtoolTrunkingPersonalityPreferredSiteStatusListItemID_A19962;

		// Token: 0x04000B64 RID: 2916
		internal global::AcpUI.AcpCopyButton CpyBtnTrkPerLabtoolTrunkingPersonalityPreferredSiteStatusListItemID_A19962;

		// Token: 0x04000B65 RID: 2917
		internal global::AcpUI.AcpLabel TrkPerLabtoolTrunkingPersonalityPreferredSiteStatusListItemID_A19962Comp;

		// Token: 0x04000B66 RID: 2918
		internal global::AcpUI.AcpCustomViewCheckBox CVBtnTrkPerLabtoolTrunkingPersonalityTalkGroupAliasListItemID_A19960;

		// Token: 0x04000B67 RID: 2919
		internal global::AcpUI.AcpLabel LblTrkPerLabtoolTrunkingPersonalityTalkGroupAliasListItemID_A19960;

		// Token: 0x04000B68 RID: 2920
		internal global::AcpUI.AcpComboBox TrkPerLabtoolTrunkingPersonalityTalkGroupAliasListItemID_A19960;

		// Token: 0x04000B69 RID: 2921
		internal global::AcpUI.AcpRtdButton RTDBtnTrkPerLabtoolTrunkingPersonalityTalkGroupAliasListItemID_A19960;

		// Token: 0x04000B6A RID: 2922
		internal global::AcpUI.AcpCopyButton CpyBtnTrkPerLabtoolTrunkingPersonalityTalkGroupAliasListItemID_A19960;

		// Token: 0x04000B6B RID: 2923
		internal global::AcpUI.AcpLabel TrkPerLabtoolTrunkingPersonalityTalkGroupAliasListItemID_A19960Comp;

		// Token: 0x04000B6C RID: 2924
		internal global::AcpUI.AcpCustomViewCheckBox CVBtnTrkPerLabtoolTrunkingPersonalityAGTGFSListItemID_A21508;

		// Token: 0x04000B6D RID: 2925
		internal global::AcpUI.AcpLabel LblTrkPerLabtoolTrunkingPersonalityAGTGFSListItemID_A21508;

		// Token: 0x04000B6E RID: 2926
		internal global::AcpUI.AcpComboBox TrkPerLabtoolTrunkingPersonalityAGTGFSListItemID_A21508;

		// Token: 0x04000B6F RID: 2927
		internal global::AcpUI.AcpRtdButton RTDBtnTrkPerLabtoolTrunkingPersonalityAGTGFSListItemID_A21508;

		// Token: 0x04000B70 RID: 2928
		internal global::AcpUI.AcpCopyButton CpyBtnTrkPerLabtoolTrunkingPersonalityAGTGFSListItemID_A21508;

		// Token: 0x04000B71 RID: 2929
		internal global::AcpUI.AcpLabel TrkPerLabtoolTrunkingPersonalityAGTGFSListItemID_A21508Comp;

		// Token: 0x04000B72 RID: 2930
		private bool b;
	}
}
