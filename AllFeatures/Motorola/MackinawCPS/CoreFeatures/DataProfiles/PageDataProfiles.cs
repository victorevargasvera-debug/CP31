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

namespace Motorola.MackinawCPS.CoreFeatures.DataProfiles
{
	// Token: 0x020004F5 RID: 1269
	public class PageDataProfiles : global::AcpUI.AcpPageFeature, global::System.Windows.Markup.IComponentConnector, global::System.Windows.Markup.IStyleConnector
	{
		// Token: 0x0600AA6B RID: 43627 RVA: 0x009EA73C File Offset: 0x009E893C
		public PageDataProfiles()
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

		// Token: 0x0600AA6C RID: 43628 RVA: 0x009EA774 File Offset: 0x009E8974
		public override void OnLoaded(object sender, global::System.Windows.RoutedEventArgs e)
		{
			short num = (short)281477120;
			int num2 = (int)num;
			switch (num2)
			{
			default:
				num = (short)1294794760;
				num2 = (int)((global::System.IntPtr)num);
				for (;;)
				{
					num = (short)2103125359;
					short num3 = num;
					num = (short)1167992175;
					object obj;
					switch ((num3 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						break;
					default:
					{
						num = (short)1564213248;
						if (num != 0)
						{
						}
						global::AcpUI.AcpExpander acpExpander;
						global::System.Collections.IEnumerator enumerator;
						switch (num2)
						{
						case 0:
							if (obj != null)
							{
								num = (short)1339686919;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							goto IL_449;
						case 1:
							goto IL_38B;
						case 2:
							if (obj != null)
							{
								num = (short)186646540;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							goto IL_38B;
						case 3:
							if (obj != null)
							{
								num = (short)51314698;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							goto IL_490;
						case 4:
							goto IL_449;
						case 5:
							this.RecNavToolbarPageDataProfiles.ChildToolbars.Add(this.RecNavToolbarExpanderDataProfilesDACList);
							this.RecNavToolbarPageDataProfiles.ChildToolbars.Add(this.RecNavToolbarExpanderDataProfilesTrunkingGroupIDList);
							this.RecNavToolbarPageDataProfiles.ChildToolbars.Add(this.RecNavToolbarExpanderDataProfilesEIDBypassListTable);
							obj = null;
							obj = this.RecNavToolbarExpanderDataProfilesDACList.MyRecordsetDataSource;
							num = (short)58720256;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 6:
							goto IL_3E4;
						case 7:
						{
							global::System.Windows.Data.CollectionView collectionView = (global::System.Windows.Data.CollectionView)global::System.Windows.Data.CollectionViewSource.GetDefaultView(obj);
							this.RecNavToolbarExpanderDataProfilesDACList.MyDataPresenter = this.ExpanderDataProfilesDACList;
							num = (short)753532932;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						case 8:
							switch (0)
							{
							case 0:
								goto IL_C3;
							}
							continue;
						case 9:
							try
							{
								num = (short)49086466;
								num2 = (int)((global::System.IntPtr)num);
								for (;;)
								{
									switch (num2)
									{
									case 0:
										if (acpExpander != null)
										{
											num = (short)752287749;
											num2 = (int)((global::System.IntPtr)num);
											continue;
										}
										break;
									case 1:
										if (!enumerator.MoveNext())
										{
											num = (short)894173187;
											num2 = (int)((global::System.IntPtr)num);
											continue;
										}
										acpExpander = (((global::System.Windows.UIElement)enumerator.Current) as global::AcpUI.AcpExpander);
										num = (short)1039532032;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									case 2:
										switch (0)
										{
										case 0:
											goto IL_12E;
										}
										continue;
									case 3:
										num = (short)1134690310;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									case 5:
										base.Expanders.Add(acpExpander);
										num = (short)1388511236;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									case 6:
										goto IL_1E9;
									}
									IL_130:
									num = (short)1361641473;
									num2 = (int)((global::System.IntPtr)num);
									continue;
									IL_12E:
									goto IL_130;
								}
								IL_1E9:
								goto IL_3BC;
							}
							finally
							{
								switch (0)
								{
								case 0:
									goto IL_20B;
								}
								global::System.IDisposable disposable;
								for (;;)
								{
									IL_1F8:
									switch (num2)
									{
									case 0:
										if (disposable != null)
										{
											num = (short)805961729;
											num2 = (int)((global::System.IntPtr)num);
											continue;
										}
										goto IL_260;
									case 1:
										disposable.Dispose();
										num = (short)332464130;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									case 2:
										goto IL_25E;
									}
									goto IL_20B;
								}
								IL_25E:
								IL_260:
								goto EndFinally_10;
								IL_20B:
								disposable = (enumerator as global::System.IDisposable);
								num = (short)137953280;
								num2 = (int)((global::System.IntPtr)num);
								goto IL_1F8;
								EndFinally_10:;
							}
							goto IL_261;
							IL_3BC:
							base.OnLoaded(sender, e);
							this.a = true;
							num = (short)429654022;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 10:
							goto IL_48B;
						case 11:
							goto IL_490;
						case 12:
							goto IL_261;
						}
						IL_C3:
						if (!this.a)
						{
							num = (short)1159790597;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_4D8;
						IL_261:
						global::System.Windows.Data.CollectionView collectionView2 = (global::System.Windows.Data.CollectionView)global::System.Windows.Data.CollectionViewSource.GetDefaultView(obj);
						this.RecNavToolbarExpanderDataProfilesEIDBypassListTable.MyDataPresenter = this.ExpanderDataProfilesEIDBypassListTable;
						num = (short)1109000192;
						short num4 = num;
						num = (short)2107441153;
						num2 = (int)((global::System.IntPtr)num);
						continue;
						IL_38B:
						acpExpander = null;
						enumerator = this.MyStackPanel.Children.GetEnumerator();
						num = (short)1011679241;
						num2 = (int)((global::System.IntPtr)num);
						continue;
						IL_449:
						obj = this.RecNavToolbarExpanderDataProfilesTrunkingGroupIDList.MyRecordsetDataSource;
						num = (short)45416451;
						num2 = (int)((global::System.IntPtr)num);
						continue;
						IL_490:
						obj = this.RecNavToolbarExpanderDataProfilesEIDBypassListTable.MyRecordsetDataSource;
						num = (short)1565589506;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					}
					IL_48B:
					num = (short)1108344833;
					if (num != 0)
					{
					}
					global::System.Windows.Data.CollectionView collectionView3 = (global::System.Windows.Data.CollectionView)global::System.Windows.Data.CollectionViewSource.GetDefaultView(obj);
					this.RecNavToolbarExpanderDataProfilesTrunkingGroupIDList.MyDataPresenter = this.ExpanderDataProfilesTrunkingGroupIDList;
					num = (short)438697995;
					num2 = (int)((global::System.IntPtr)num);
				}
				IL_3E4:
				IL_4D8:
				this.PostOnLoaded(sender, e);
				this.MyStackPanel.Children[0].Focus();
				return;
			}
		}

		// Token: 0x0600AA6D RID: 43629 RVA: 0x009EAC94 File Offset: 0x009E8E94
		public override void OnUnloaded(object sender, global::System.Windows.RoutedEventArgs e)
		{
			switch (0)
			{
			case 0:
				goto IL_1C;
			}
			short num2;
			for (;;)
			{
				IL_0A:
				int num;
				switch (num)
				{
				case 0:
					num2 = (short)1785856001;
					if (num2 != 0)
					{
					}
					if (this.a)
					{
						num2 = (short)710344705;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					return;
				case 1:
					goto IL_17E;
				case 2:
					return;
				}
				goto IL_1C;
			}
			return;
			IL_1C:
			this.RecNavToolbarPageDataProfiles.DataContext = null;
			this.RecNavToolbarPageDataProfiles.DataContext = null;
			this.RecNavToolbarPageDataProfiles.DataContext = null;
			this.RecNavToolbarExpanderDataProfilesDACList.DataContext = null;
			this.RecNavToolbarExpanderDataProfilesTrunkingGroupIDList.DataContext = null;
			this.RecNavToolbarExpanderDataProfilesEIDBypassListTable.DataContext = null;
			this.RecNavToolbarPageDataProfiles.MyDataPresenter = null;
			this.RecNavToolbarPageDataProfiles.MyDataPresenter = null;
			this.RecNavToolbarPageDataProfiles.MyDataPresenter = null;
			this.RecNavToolbarExpanderDataProfilesDACList.MyDataPresenter = null;
			this.RecNavToolbarExpanderDataProfilesTrunkingGroupIDList.MyDataPresenter = null;
			this.RecNavToolbarExpanderDataProfilesEIDBypassListTable.MyDataPresenter = null;
			num2 = (short)436345718;
			short num3 = num2;
			num2 = (short)2019498870;
			switch ((num3 == num2) ? 1 : 0)
			{
			case 0:
			case 2:
			{
				IL_17E:
				base.OnUnloaded(sender, e);
				this.a = false;
				num2 = (short)125501442;
				int num = (int)((global::System.IntPtr)num2);
				goto IL_0A;
			}
			default:
			{
				num2 = (short)1399390208;
				short num4 = num2;
				num2 = (short)676134912;
				if (num2 != 0)
				{
				}
				num2 = (short)2102198272;
				int num = (int)((global::System.IntPtr)num2);
				goto IL_0A;
			}
			}
		}

		// Token: 0x0600AA6E RID: 43630 RVA: 0x009EAE4C File Offset: 0x009E904C
		public override void SetDataContext()
		{
			short num = (short)56229892;
			int num2 = (int)((global::System.IntPtr)num);
			object feature;
			for (;;)
			{
				switch (num2)
				{
				case 0:
				{
					num = (short)1905328129;
					if (num != 0)
					{
					}
					base.DataContext = global::AcpCommonLib.AppInfoManager.DefaultDocument.GetFeature(2054);
					num = (short)1664155648;
					short num3 = num;
					num = (short)1909456901;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				case 1:
					if (feature != null)
					{
						num = (short)49020936;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					return;
				case 2:
					goto IL_1EA;
				case 3:
					if (global::AcpCommonLib.AppInfoManager.AppMode == global::AcpCommonLib.ApplicationMode.CodeplugComparisonMode)
					{
						num = (short)1043726338;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					((global::AcpUILib.IAcpRecNavToolbar)this.RecNavToolbarPageDataProfiles).MySecondaryRecordsetDataSource = null;
					num = (short)186384391;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 4:
					switch (0)
					{
					case 0:
						goto IL_48;
					}
					continue;
				case 5:
					goto IL_A1;
				case 6:
					goto IL_A1;
				case 7:
					goto IL_16F;
				case 8:
					goto IL_22B;
				}
				IL_48:
				if (global::AcpCommonLib.AppInfoManager.AppMode == global::AcpCommonLib.ApplicationMode.CustomViewConfigurationMode)
				{
					num = (short)207159296;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				base.DataContext = global::AcpCommonLib.FeatureManager.GetFeature(2054);
				num = (short)1478664798;
				short num4 = num;
				num = (short)697868894;
				switch ((num4 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					goto IL_1EA;
				default:
					num = (short)721289216;
					if (num != 0)
					{
					}
					num = (short)79364102;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				IL_A1:
				this.RecNavToolbarPageDataProfiles.DataContext = (global::AcpCommonLib.IAcpRecordset)base.DataContext;
				num = (short)230227971;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_1EA:
				feature = global::AcpCommonLib.AppInfoManager.ComparatorDocument.GetFeature(2054);
				num = (short)639565825;
				num2 = (int)((global::System.IntPtr)num);
			}
			IL_16F:
			return;
			IL_22B:
			((global::AcpUILib.IAcpRecNavToolbar)this.RecNavToolbarPageDataProfiles).MySecondaryRecordsetDataSource = (global::AcpCommonLib.IAcpRecordset)feature;
		}

		// Token: 0x0600AA6F RID: 43631 RVA: 0x009EB08C File Offset: 0x009E928C
		private void OnModeClick(object A_0, global::System.Windows.RoutedEventArgs A_1)
		{
			int a_ = 17;
			short num = (short)1457192960;
			switch (num)
			{
			default:
			{
				num = (short)1502609460;
				int num2 = (int)((global::System.IntPtr)num);
				for (;;)
				{
					global::System.Windows.Data.CollectionView collectionView3;
					global::Motorola.MackinawCPS.CoreFeatures.DataProfiles.EIDBypassListInner eidbypassListInner;
					switch (num2)
					{
					case 0:
					{
						global::System.Windows.Data.CollectionView collectionView;
						if (collectionView.IsCurrentAfterLast)
						{
							num = (short)1551958020;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						collectionView.MoveCurrentToFirst();
						num = (short)943521843;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 1:
						num = (short)600899620;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 2:
					{
						object myRecordsetDataSource;
						global::System.Windows.Data.CollectionView collectionView = (global::System.Windows.Data.CollectionView)global::System.Windows.Data.CollectionViewSource.GetDefaultView(myRecordsetDataSource);
						global::Motorola.MackinawCPS.CoreFeatures.DataProfiles.TrunkingGroupIDListInner trunkingGroupIDListInner = (global::Motorola.MackinawCPS.CoreFeatures.DataProfiles.TrunkingGroupIDListInner)collectionView.CurrentItem;
						num = (short)2086535206;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 3:
					{
						object myRecordsetDataSource2;
						if (myRecordsetDataSource2 != null)
						{
							num = (short)1442119721;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return;
					}
					case 4:
					{
						global::System.Windows.Data.CollectionView collectionView;
						collectionView.MoveCurrentToLast();
						num = (short)1467220011;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 5:
						if (((global::AcpUI.AcpRecNavToolbar)A_0).Name == global::AllFeatures.CodeplugGuid.b("胑뇓뗕雗믙ꫛ諝迟跡裣蓥觧飩ꧫ雭胯鏱髳鋵鷷裹룻鿽瓿持吃琅朇氉攋戍甏愑儓引尗堙攛渝䄟儡圣樥䄧天堫稭儯倱堳匵", a_))
						{
							num = (short)1321533441;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return;
					case 6:
					{
						global::Motorola.MackinawCPS.CoreFeatures.DataProfiles.DACListInner daclistInner;
						if (daclistInner != null)
						{
							num = (short)1304821771;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)656015397;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 7:
					{
						global::AcpCommonLib.IAcpRecordset myRecordsetDataSource3;
						base.NavigationService.Navigate(new global::System.Uri(myRecordsetDataSource3.UIPagePath, global::System.UriKind.RelativeOrAbsolute));
						num = (short)472186934;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 8:
						goto IL_7C7;
					case 9:
					{
						global::AcpCommonLib.IAcpRecordset myRecordsetDataSource3;
						if (myRecordsetDataSource3 != null)
						{
							num = (short)36110343;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_7F6;
					}
					case 10:
					{
						((global::AcpUI.AcpRecNavToolbar)A_0).TableMode = false;
						object myRecordsetDataSource4 = this.RecNavToolbarExpanderDataProfilesDACList.MyRecordsetDataSource;
						num = (short)1176895530;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 11:
					{
						global::Motorola.MackinawCPS.CoreFeatures.DataProfiles.DACListInner daclistInner;
						global::System.Windows.Data.CollectionView collectionView2;
						collectionView2.MoveCurrentTo(daclistInner);
						num = (short)60227606;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 12:
						goto IL_3EB;
					case 13:
						if (collectionView3.Count > 0)
						{
							num = (short)335282209;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_9D9;
					case 14:
					{
						global::System.Windows.Data.CollectionView collectionView2;
						if (collectionView2.IsCurrentAfterLast)
						{
							num = (short)804847631;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						collectionView2.MoveCurrentToFirst();
						num = (short)1350500405;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 15:
					{
						global::System.Windows.Data.CollectionView collectionView2;
						collectionView2.MoveCurrentToLast();
						num = (short)488046611;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 16:
					{
						num = (short)1024049727;
						short num3 = num;
						num = (short)983482943;
						switch ((num3 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_7C7;
						default:
						{
							num = (short)1301282816;
							if (num != 0)
							{
							}
							((global::AcpUI.AcpRecNavToolbar)A_0).TableMode = false;
							object myRecordsetDataSource2 = this.RecNavToolbarExpanderDataProfilesEIDBypassListTable.MyRecordsetDataSource;
							num = (short)1860239363;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						}
						break;
					}
					case 17:
						num = (short)1990131713;
						if (num != 0)
						{
						}
						if (((global::AcpUI.AcpRecNavToolbar)A_0).TableMode)
						{
							num = (short)1051918346;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						((global::AcpUI.AcpRecNavToolbar)A_0).TableMode = true;
						num = (short)1455751207;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 18:
						if (((global::AcpUI.AcpRecNavToolbar)A_0).Name == global::AllFeatures.CodeplugGuid.b("胑뇓뗕雗믙ꫛ諝迟跡裣蓥觧飩볫迭韯韱냳韵賷鯹곻賽濿搁洃樅洇礉", a_))
						{
							num = (short)476643372;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_7F6;
					case 19:
						goto IL_7CC;
					case 20:
						goto IL_23E;
					case 21:
						if (((global::AcpUI.AcpRecNavToolbar)A_0).Name == global::AllFeatures.CodeplugGuid.b("胑뇓뗕雗믙ꫛ諝迟跡裣蓥觧飩ꧫ雭胯鏱髳鋵鷷裹룻鿽瓿持吃琅朇氉攋戍甏愑倓圕嬗嘙甛洝吟", a_))
						{
							num = (short)696254495;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_3F0;
					case 22:
						goto IL_7CC;
					case 23:
					{
						object myRecordsetDataSource;
						if (myRecordsetDataSource != null)
						{
							num = (short)1885995010;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_15B;
					}
					case 24:
						collectionView3.MoveCurrentToLast();
						num = (short)1388380205;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 25:
						if (((global::AcpUI.AcpRecNavToolbar)A_0).Name == global::AllFeatures.CodeplugGuid.b("胑뇓뗕雗믙ꫛ諝迟跡裣蓥觧飩ꧫ雭胯鏱髳鋵鷷裹룻鿽瓿持吃琅朇氉攋戍甏愑䀓搕洗琙眛眝丟䔡挣吥䜧弩尫札琯縱崳䔵䰷", a_))
						{
							num = (short)1907490863;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_15B;
					case 26:
						num = (short)1691484178;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 27:
						goto IL_15B;
					case 28:
					{
						global::System.Windows.Data.CollectionView collectionView;
						global::Motorola.MackinawCPS.CoreFeatures.DataProfiles.TrunkingGroupIDListInner trunkingGroupIDListInner;
						collectionView.MoveCurrentTo(trunkingGroupIDListInner);
						num = (short)1893466168;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 29:
					{
						object myRecordsetDataSource4;
						global::System.Windows.Data.CollectionView collectionView2 = (global::System.Windows.Data.CollectionView)global::System.Windows.Data.CollectionViewSource.GetDefaultView(myRecordsetDataSource4);
						global::Motorola.MackinawCPS.CoreFeatures.DataProfiles.DACListInner daclistInner = (global::Motorola.MackinawCPS.CoreFeatures.DataProfiles.DACListInner)collectionView2.CurrentItem;
						num = (short)225705990;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 30:
						num = (short)1714880526;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 31:
						num = (short)992673809;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 32:
						if (collectionView3.IsCurrentAfterLast)
						{
							num = (short)1332019224;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						collectionView3.MoveCurrentToFirst();
						num = (short)551419938;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 33:
						num = (short)554237984;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 34:
						goto IL_2F9;
					case 35:
					{
						global::System.Windows.Data.CollectionView collectionView;
						if (collectionView.Count > 0)
						{
							num = (short)1691811889;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_90F;
					}
					case 36:
						if (((global::AcpUI.AcpRecNavToolbar)A_0).TableMode)
						{
							num = (short)2085027856;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						((global::AcpUI.AcpRecNavToolbar)A_0).TableMode = true;
						num = (short)282525708;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 37:
					{
						global::System.Windows.Data.CollectionView collectionView2;
						if (collectionView2.Count > 0)
						{
							num = (short)1036779550;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_7CC;
					}
					case 38:
					{
						global::Motorola.MackinawCPS.CoreFeatures.DataProfiles.TrunkingGroupIDListInner trunkingGroupIDListInner;
						if (trunkingGroupIDListInner != null)
						{
							num = (short)677117980;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)1485373475;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 39:
						goto IL_3F0;
					case 40:
						if (((global::AcpUI.AcpRecNavToolbar)A_0).TableMode)
						{
							num = (short)26279984;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						((global::AcpUI.AcpRecNavToolbar)A_0).TableMode = true;
						num = (short)642842670;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 41:
					{
						object myRecordsetDataSource2;
						collectionView3 = (global::System.Windows.Data.CollectionView)global::System.Windows.Data.CollectionViewSource.GetDefaultView(myRecordsetDataSource2);
						eidbypassListInner = (global::Motorola.MackinawCPS.CoreFeatures.DataProfiles.EIDBypassListInner)collectionView3.CurrentItem;
						num = (short)335740983;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 42:
					{
						object myRecordsetDataSource4;
						if (myRecordsetDataSource4 != null)
						{
							num = (short)325910557;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_3F0;
					}
					case 43:
						goto IL_90F;
					case 44:
					{
						num = (short)1902116864;
						short num4 = num;
						global::AcpCommonLib.IAcpRecordset myRecordsetDataSource3 = this.RecNavToolbarPageDataProfiles.MyRecordsetDataSource;
						num = (short)1832452105;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 45:
						goto IL_9AF;
					case 46:
						goto IL_15B;
					case 47:
						num = (short)373555240;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 48:
					{
						((global::AcpUI.AcpRecNavToolbar)A_0).TableMode = false;
						object myRecordsetDataSource = this.RecNavToolbarExpanderDataProfilesTrunkingGroupIDList.MyRecordsetDataSource;
						num = (short)936312855;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 49:
						num = (short)858980352;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 50:
						goto IL_3F0;
					case 51:
						goto IL_90F;
					case 52:
						switch (0)
						{
						case 0:
							goto IL_133;
						}
						continue;
					case 53:
						goto IL_7CC;
					case 54:
						goto IL_7F6;
					case 55:
						if (eidbypassListInner != null)
						{
							num = (short)799014920;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)1437925389;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 56:
						goto IL_90F;
					}
					IL_133:
					if (A_0 is global::AcpUI.AcpRecNavToolbar)
					{
						num = (short)620298266;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					return;
					IL_15B:
					num = (short)20512773;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_3F0:
					num = (short)1324285977;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_7C7:
					collectionView3.MoveCurrentTo(eidbypassListInner);
					num = (short)32964628;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_7CC:
					((global::AcpUI.AcpRecNavToolbar)A_0).SyncDataSources();
					num = (short)1036976178;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_7F6:
					num = (short)596705301;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_90F:
					((global::AcpUI.AcpRecNavToolbar)A_0).SyncDataSources();
					num = (short)333840411;
					num2 = (int)((global::System.IntPtr)num);
				}
				IL_23E:
				IL_2F9:
				goto IL_9D9;
				IL_3EB:
				return;
				IL_9AF:
				IL_9D9:
				((global::AcpUI.AcpRecNavToolbar)A_0).SyncDataSources();
				return;
			}
			}
		}

		// Token: 0x0600AA70 RID: 43632 RVA: 0x009EBAFC File Offset: 0x009E9CFC
		private void HLinkClick(object A_0, global::System.Windows.RoutedEventArgs A_1)
		{
			short num = (short)1251747574;
			short num2 = num;
			num = (short)2134451958;
			switch (num2 == num)
			{
			}
			num = (short)556597249;
			if (num != 0)
			{
			}
			num = (short)1383399424;
			if (num != 0)
			{
			}
			num = (short)726597632;
			short num3 = num;
			base.OnHLinkClick(A_0);
		}

		// Token: 0x0600AA71 RID: 43633 RVA: 0x009EBBB0 File Offset: 0x009E9DB0
		private void OnFieldNameDoubleClick(object A_0, global::System.Windows.RoutedEventArgs A_1)
		{
			short num = (short)1258094593;
			if (num != 0)
			{
			}
			num = (short)1468920655;
			short num2 = num;
			num = (short)1398338383;
			switch (num2 == num)
			{
			}
			num = (short)1124859904;
			if (num != 0)
			{
			}
			num = (short)1879703552;
			short num3 = num;
			global::AcpUI.Common.Utility.GetFieldHelpText(A_0);
		}

		// Token: 0x0600AA72 RID: 43634 RVA: 0x009EBC60 File Offset: 0x009E9E60
		internal void OnExpanderDataProfilesDACListClick(object sender, global::System.Windows.RoutedEventArgs e)
		{
			short num = (short)239629193;
			short num2 = num;
			num = (short)2066510729;
			object myRecordsetDataSource;
			global::Motorola.MackinawCPS.CoreFeatures.DataProfiles.DACListInner item;
			int num3;
			switch ((num2 == num) ? 1 : 0)
			{
			case 0:
			case 2:
				IL_118:
				((global::System.Windows.Data.CollectionView)global::System.Windows.Data.CollectionViewSource.GetDefaultView(myRecordsetDataSource)).MoveCurrentTo(item);
				this.RecNavToolbarExpanderDataProfilesDACList.SyncDataSources();
				num = (short)1258160130;
				num3 = (int)((global::System.IntPtr)num);
				break;
			default:
				num = (short)1950613504;
				if (num != 0)
				{
				}
				switch (0)
				{
				case 0:
					goto IL_8B;
				}
				break;
			}
			for (;;)
			{
				IL_53:
				num = (short)881262593;
				if (num != 0)
				{
				}
				switch (num3)
				{
				case 0:
					goto IL_116;
				case 1:
					if (myRecordsetDataSource != null)
					{
						num = (short)1748041728;
						short num4 = num;
						num = (short)1973288960;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_14E;
				case 2:
					goto IL_14C;
				}
				goto IL_8B;
			}
			IL_116:
			goto IL_118;
			IL_14C:
			IL_14E:
			this.RecNavToolbarExpanderDataProfilesDACList.TableMode = false;
			return;
			IL_8B:
			item = (global::Motorola.MackinawCPS.CoreFeatures.DataProfiles.DACListInner)((global::Infragistics.Windows.DataPresenter.CellValuePresenter)((global::AcpUI.AcpButton)e.Source).TemplatedParent).Record.DataItem;
			myRecordsetDataSource = this.RecNavToolbarExpanderDataProfilesDACList.MyRecordsetDataSource;
			num = (short)1768554497;
			num3 = (int)((global::System.IntPtr)num);
			goto IL_53;
		}

		// Token: 0x0600AA73 RID: 43635 RVA: 0x009EBDC8 File Offset: 0x009E9FC8
		internal void OnExpanderDataProfilesTrunkingGroupIDListClick(object sender, global::System.Windows.RoutedEventArgs e)
		{
			short num = (short)1016475732;
			short num2 = num;
			num = (short)1501442132;
			object myRecordsetDataSource;
			global::Motorola.MackinawCPS.CoreFeatures.DataProfiles.TrunkingGroupIDListInner item;
			int num3;
			switch ((num2 == num) ? 1 : 0)
			{
			case 0:
			case 2:
				IL_F4:
				((global::System.Windows.Data.CollectionView)global::System.Windows.Data.CollectionViewSource.GetDefaultView(myRecordsetDataSource)).MoveCurrentTo(item);
				this.RecNavToolbarExpanderDataProfilesTrunkingGroupIDList.SyncDataSources();
				num = (short)50200578;
				num3 = (int)((global::System.IntPtr)num);
				break;
			default:
				num = (short)1944190976;
				if (num != 0)
				{
				}
				switch (0)
				{
				case 0:
					goto IL_67;
				}
				break;
			}
			for (;;)
			{
				IL_55:
				switch (num3)
				{
				case 0:
					goto IL_C9;
				case 1:
					if (myRecordsetDataSource != null)
					{
						num = (short)2046099456;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_153;
				case 2:
					goto IL_129;
				}
				goto IL_67;
			}
			IL_C9:
			num = (short)1316093952;
			short num4 = num;
			goto IL_F4;
			IL_129:
			num = (short)356057089;
			if (num != 0)
			{
			}
			IL_153:
			this.RecNavToolbarExpanderDataProfilesTrunkingGroupIDList.TableMode = false;
			return;
			IL_67:
			item = (global::Motorola.MackinawCPS.CoreFeatures.DataProfiles.TrunkingGroupIDListInner)((global::Infragistics.Windows.DataPresenter.CellValuePresenter)((global::AcpUI.AcpButton)e.Source).TemplatedParent).Record.DataItem;
			myRecordsetDataSource = this.RecNavToolbarExpanderDataProfilesTrunkingGroupIDList.MyRecordsetDataSource;
			num = (short)499712001;
			num3 = (int)((global::System.IntPtr)num);
			goto IL_55;
		}

		// Token: 0x0600AA74 RID: 43636 RVA: 0x009EBF34 File Offset: 0x009EA134
		internal void OnExpanderDataProfilesEIDBypassListTableClick(object sender, global::System.Windows.RoutedEventArgs e)
		{
			short num = (short)1017830497;
			short num2 = num;
			num = (short)1001118817;
			object myRecordsetDataSource;
			global::Motorola.MackinawCPS.CoreFeatures.DataProfiles.EIDBypassListInner item;
			int num3;
			switch ((num2 == num) ? 1 : 0)
			{
			case 0:
			case 2:
				IL_118:
				((global::System.Windows.Data.CollectionView)global::System.Windows.Data.CollectionViewSource.GetDefaultView(myRecordsetDataSource)).MoveCurrentTo(item);
				this.RecNavToolbarExpanderDataProfilesEIDBypassListTable.SyncDataSources();
				num = (short)300875778;
				num3 = (int)((global::System.IntPtr)num);
				break;
			default:
				num = (short)1011744768;
				if (num != 0)
				{
				}
				switch (0)
				{
				case 0:
					goto IL_8C;
				}
				break;
			}
			for (;;)
			{
				IL_54:
				num = (short)527564801;
				if (num != 0)
				{
				}
				switch (num3)
				{
				case 0:
					goto IL_116;
				case 1:
					if (myRecordsetDataSource != null)
					{
						num = (short)892665856;
						short num4 = num;
						num = (short)158728192;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_14E;
				case 2:
					goto IL_14C;
				}
				goto IL_8C;
			}
			IL_116:
			goto IL_118;
			IL_14C:
			IL_14E:
			this.RecNavToolbarExpanderDataProfilesEIDBypassListTable.TableMode = false;
			return;
			IL_8C:
			item = (global::Motorola.MackinawCPS.CoreFeatures.DataProfiles.EIDBypassListInner)((global::Infragistics.Windows.DataPresenter.CellValuePresenter)((global::AcpUI.AcpButton)e.Source).TemplatedParent).Record.DataItem;
			myRecordsetDataSource = this.RecNavToolbarExpanderDataProfilesEIDBypassListTable.MyRecordsetDataSource;
			num = (short)73203713;
			num3 = (int)((global::System.IntPtr)num);
			goto IL_54;
		}

		// Token: 0x0600AA75 RID: 43637 RVA: 0x009EC09C File Offset: 0x009EA29C
		private void PostOnLoaded(object A_0, global::System.Windows.RoutedEventArgs A_1)
		{
			short num = (short)2095813371;
			short num2 = num;
			num = (short)1094030075;
			switch (num2 == num)
			{
			}
			num = (short)719323137;
			if (num != 0)
			{
			}
			num = (short)1027538944;
			if (num != 0)
			{
			}
			num = (short)1224409088;
			short num3 = num;
			this.a();
		}

		// Token: 0x0600AA76 RID: 43638 RVA: 0x009EC14C File Offset: 0x009EA34C
		private void a()
		{
			short num = (short)1435921339;
			short num2 = num;
			num = (short)1291283387;
			switch (num2 == num)
			{
			}
			num = (short)263323648;
			if (num != 0)
			{
			}
			num = (short)1232732161;
			if (num != 0)
			{
			}
			num = (short)1065549824;
			short num3 = num;
			this.DataProfilesTrunkingGroupID_ASTRO25DataGroupID_A36204_Col.Settings.CellWidth = 180.0;
		}

		// Token: 0x0600AA77 RID: 43639 RVA: 0x009EC210 File Offset: 0x009EA410
		[global::System.CodeDom.Compiler.GeneratedCode("PresentationBuildTasks", "5.0.10.0")]
		[global::System.Diagnostics.DebuggerNonUserCode]
		public void InitializeComponent()
		{
			int a_ = 8;
			short num = (short)1902968833;
			if (num != 0)
			{
			}
			if (this.b)
			{
				num = (short)2001673118;
				short num2 = num;
				num = (short)1532566430;
				switch ((num2 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					break;
				default:
					num = (short)691994624;
					if (num != 0)
					{
					}
					break;
				}
				return;
			}
			num = (short)496369664;
			short num3 = num;
			this.b = true;
			global::System.Uri resourceLocator = new global::System.Uri(global::AllFeatures.CodeplugGuid.b("諊ꇌꏎ韐뛒듔ꏖ곘꧚룜곞\udae0胢諤諦駨蓪菬諮鿰蟲\udaf4鏶飸迺鳼\udafe㌀㌂昄栆月洊搌栎搐愒琔挖瀘琚猜〞䔠䈢儤䘦నᤪᴬ弮䌰尲匴帶唸帺丼ှ╀≂ㅄ♆㥈㥊≌⥎㡐㽒ご⑖睘⍚㱜㉞ൠ", a_), global::System.UriKind.Relative);
			global::System.Windows.Application.LoadComponent(this, resourceLocator);
		}

		// Token: 0x0600AA78 RID: 43640 RVA: 0x009EC2F4 File Offset: 0x009EA4F4
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		[global::System.CodeDom.Compiler.GeneratedCode("PresentationBuildTasks", "5.0.10.0")]
		[global::System.Diagnostics.DebuggerNonUserCode]
		void global::System.Windows.Markup.IComponentConnector.Connect(int connectionId, object target)
		{
			short num = (short)1836777472;
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
					num = (short)886243330;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 2:
					goto IL_156B;
				}
				IL_30:
				switch (connectionId)
				{
				case 1:
					goto IL_EBC;
				case 2:
					goto IL_E98;
				case 3:
				case 4:
				case 5:
				case 6:
				case 7:
					goto IL_320E;
				case 8:
					goto IL_951;
				case 9:
					goto IL_31DD;
				case 10:
					goto IL_310F;
				case 11:
					goto IL_1FCB;
				case 12:
					goto IL_317B;
				case 13:
					goto IL_1E36;
				case 14:
					goto IL_1DF8;
				case 15:
					goto IL_B1D;
				case 16:
					goto IL_2427;
				case 17:
					goto IL_17A4;
				case 18:
					goto IL_30AD;
				case 19:
					goto IL_DC7;
				case 20:
					goto IL_A94;
				case 21:
					goto IL_2BC5;
				case 22:
					goto IL_1B72;
				case 23:
					goto IL_188C;
				case 24:
					goto IL_1EAF;
				case 25:
					goto IL_1963;
				case 26:
					goto IL_2D7D;
				case 27:
					goto IL_1098;
				case 28:
					goto IL_25A5;
				case 29:
					goto IL_1D96;
				case 30:
					goto IL_13B1;
				case 31:
					goto IL_210E;
				case 32:
					goto IL_2B15;
				case 33:
					goto IL_11A7;
				case 34:
					goto IL_2FBB;
				case 35:
					goto IL_16A9;
				case 36:
					goto IL_2894;
				case 37:
					goto IL_1FEF;
				case 38:
					goto IL_2336;
				case 39:
					goto IL_3065;
				case 40:
					goto IL_2614;
				case 41:
					goto IL_1F2B;
				case 42:
					goto IL_19C8;
				case 43:
					goto IL_B8C;
				case 44:
					goto IL_2A23;
				case 45:
					goto IL_1114;
				case 46:
					goto IL_182A;
				case 47:
					goto IL_2496;
				case 48:
					goto IL_11CB;
				case 49:
					goto IL_2C5E;
				case 50:
					goto IL_1594;
				case 51:
					goto IL_2DB1;
				case 52:
					goto IL_2A96;
				case 53:
					goto IL_1EBC;
				case 54:
					goto IL_225B;
				case 55:
					goto IL_13EF;
				case 56:
					goto IL_21D5;
				case 57:
					goto IL_2B7A;
				case 58:
					goto IL_2F97;
				case 59:
					goto IL_DAD;
				case 60:
					goto IL_1495;
				case 61:
					goto IL_2C51;
				case 62:
					goto IL_1409;
				case 63:
					goto IL_2785;
				case 64:
					goto IL_2679;
				case 65:
					goto IL_239B;
				case 66:
					goto IL_1B65;
				case 67:
					goto IL_236A;
				case 68:
					goto IL_2EAC;
				case 69:
					goto IL_3157;
				case 70:
					goto IL_17F9;
				case 71:
					goto IL_15EC;
				case 72:
					goto IL_2B46;
				case 73:
					goto IL_8D2;
				case 74:
					goto IL_DD4;
				case 75:
					goto IL_11D8;
				case 76:
					goto IL_1644;
				case 77:
					goto IL_138A;
				case 78:
					goto IL_DBA;
				case 79:
					goto IL_F5C;
				case 80:
					goto IL_C6D;
				case 81:
					goto IL_2F1B;
				case 82:
					goto IL_1CC2;
				case 83:
					goto IL_B5B;
				case 84:
					goto IL_13BE;
				case 85:
					goto IL_29B4;
				case 86:
					goto IL_18D7;
				case 87:
					goto IL_96B;
				case 88:
					goto IL_B99;
				case 89:
					goto IL_21B1;
				case 90:
					goto IL_B10;
				case 91:
					goto IL_2607;
				case 92:
					goto IL_27E7;
				case 93:
					goto IL_1668;
				case 94:
					goto IL_283F;
				case 95:
					goto IL_1457;
				case 96:
					goto IL_2F7D;
				case 97:
					goto IL_1F69;
				case 98:
					goto IL_C22;
				case 99:
					goto IL_1521;
				case 100:
					goto IL_3041;
				case 101:
					goto IL_1D58;
				case 102:
					goto IL_2638;
				case 103:
					goto IL_28A1;
				case 104:
					goto IL_25ED;
				case 105:
					goto IL_95E;
				case 106:
					goto IL_20CD;
				case 107:
					goto IL_319F;
				case 108:
					goto IL_13CB;
				case 109:
					goto IL_1AF6;
				case 110:
					goto IL_2E6B;
				case 111:
					goto IL_2D25;
				case 112:
					goto IL_2716;
				case 113:
					goto IL_2CE7;
				case 114:
					goto IL_23DC;
				case 115:
					goto IL_8A1;
				case 116:
					goto IL_BCA;
				case 117:
					goto IL_A18;
				case 118:
					goto IL_2754;
				case 119:
					goto IL_27B6;
				case 120:
					goto IL_978;
				case 121:
					goto IL_29A7;
				case 122:
					goto IL_2CA9;
				case 123:
					goto IL_202D;
				case 124:
					goto IL_1682;
				case 125:
					goto IL_2180;
				case 126:
					goto IL_D89;
				case 127:
					goto IL_1C91;
				case 128:
					goto IL_B4E;
				case 129:
					goto IL_91D;
				case 130:
					goto IL_3034;
				case 131:
					goto IL_211B;
				case 132:
					goto IL_1E29;
				case 133:
					goto IL_A63;
				case 134:
					goto IL_1EC9;
				case 135:
					goto IL_A56;
				case 136:
					goto IL_126B;
				case 137:
					goto IL_1507;
				case 138:
					goto IL_193C;
				case 139:
					goto IL_2237;
				case 140:
					goto IL_2009;
				case 141:
					goto IL_1B03;
				case 142:
					goto IL_2652;
				case 143:
					goto IL_1C15;
				case 144:
					goto IL_1C84;
				case 145:
					goto IL_1366;
				case 146:
					goto IL_1F45;
				case 147:
					goto IL_FE8;
				case 148:
					goto IL_10BC;
				case 149:
					goto IL_12C3;
				case 150:
					goto IL_1C22;
				case 151:
					goto IL_2128;
				case 152:
					goto IL_A32;
				case 153:
					goto IL_1430;
				case 154:
					goto IL_3102;
				case 155:
					goto IL_19D5;
				case 156:
					goto IL_F90;
				case 157:
					goto IL_2101;
				case 158:
					goto IL_28E2;
				case 159:
					goto IL_1C60;
				case 160:
					goto IL_17EC;
				case 161:
					goto IL_198A;
				case 162:
					goto IL_1BE1;
				case 163:
					goto IL_2F8A;
				case 164:
					goto IL_13FC;
				case 165:
					goto IL_A0B;
				case 166:
					goto IL_21EF;
				case 167:
					goto IL_1BB0;
				case 168:
					goto IL_2DE2;
				case 169:
					goto IL_3201;
				case 170:
					goto IL_AAE;
				case 171:
					goto IL_2DD5;
				case 172:
					goto IL_C3C;
				case 173:
					goto IL_17C8;
				case 174:
					goto IL_F42;
				case 175:
					goto IL_E5A;
				case 176:
					goto IL_23C2;
				case 177:
					goto IL_1DEB;
				case 178:
					goto IL_DE1;
				case 179:
					goto IL_251F;
				case 180:
					goto IL_18BD;
				case 181:
					goto IL_1EED;
				case 182:
					goto IL_26C1;
				case 183:
					goto IL_130E;
				case 184:
					goto IL_FF5;
				case 185:
					goto IL_AC8;
				case 186:
					goto IL_19E2;
				case 187:
					goto IL_1E1C;
				case 188:
					goto IL_247C;
				case 189:
					goto IL_1145;
				case 190:
					goto IL_1EFA;
				case 191:
					goto IL_1E8B;
				case 192:
					goto IL_1766;
				case 193:
					goto IL_CCF;
				case 194:
					goto IL_162A;
				case 195:
					goto IL_1797;
				case 196:
					goto IL_2173;
				case 197:
					goto IL_22B0;
				case 198:
					goto IL_24B0;
				case 199:
					goto IL_12B6;
				case 200:
					goto IL_29F2;
				case 201:
					goto IL_2AE1;
				case 202:
					goto IL_244B;
				case 203:
					goto IL_31D0;
				case 204:
					goto IL_26CE;
				case 205:
					goto IL_1152;
				case 206:
					goto IL_18F1;
				case 207:
					goto IL_265F;
				case 208:
					goto IL_9F1;
				case 209:
					goto IL_9E4;
				case 210:
					goto IL_F1E;
				case 211:
					goto IL_CAB;
				case 212:
					goto IL_2512;
				case 213:
					goto IL_CDC;
				case 214:
					goto IL_2AFB;
				case 215:
					goto IL_2C44;
				case 216:
					goto IL_2C37;
				case 217:
					goto IL_2F3F;
				case 218:
					goto IL_D3E;
				case 219:
					goto IL_1BEE;
				case 220:
					goto IL_2E9F;
				case 221:
					goto IL_2D18;
				case 222:
					goto IL_131B;
				case 223:
					goto IL_218D;
				case 224:
					goto IL_1DA3;
				case 225:
					goto IL_2825;
				case 226:
					goto IL_18E4;
				case 227:
					goto IL_F11;
				case 228:
					goto IL_2C9C;
				case 229:
					goto IL_1D0A;
				case 230:
					goto IL_10F0;
				case 231:
					goto IL_2761;
				case 232:
					goto IL_F4F;
				case 233:
					goto IL_1D89;
				case 234:
					goto IL_28AE;
				case 235:
					goto IL_16B6;
				case 236:
					goto IL_D1A;
				case 237:
					goto IL_24D4;
				case 238:
					goto IL_944;
				case 239:
					goto IL_2C6B;
				case 240:
					goto IL_187F;
				case 241:
					goto IL_144A;
				case 242:
					goto IL_208F;
				case 243:
					goto IL_26F2;
				case 244:
					goto IL_AA1;
				case 245:
					goto IL_14C9;
				case 246:
					goto IL_1AE9;
				case 247:
					goto IL_119A;
				case 248:
					goto IL_2DFC;
				case 249:
					goto IL_190B;
				case 250:
					goto IL_21E2;
				case 251:
					goto IL_16E7;
				case 252:
					goto IL_16F4;
				case 253:
					goto IL_1278;
				case 254:
					goto IL_2E47;
				case 255:
					goto IL_2801;
				case 256:
					goto IL_2645;
				case 257:
					goto IL_20C0;
				case 258:
					goto IL_197D;
				case 259:
					goto IL_1397;
				case 260:
					goto IL_1B41;
				case 261:
					goto IL_E67;
				case 262:
					goto IL_15AE;
				case 263:
					goto IL_28BB;
				case 264:
					goto IL_A87;
				case 265:
					goto IL_2D8A;
				case 266:
					goto IL_25C9;
				case 267:
					goto IL_2B22;
				case 268:
					goto IL_1D31;
				case 269:
					goto IL_14FA;
				case 270:
					goto IL_FCE;
				case 271:
					goto IL_2EC6;
				case 272:
					goto IL_30BA;
				case 273:
					goto IL_19A4;
				case 274:
					goto IL_123A;
				case 275:
					goto IL_1970;
				case 276:
					goto IL_1D4B;
				case 277:
					goto IL_1BFB;
				case 278:
					goto IL_2BF9;
				case 279:
					goto IL_CE9;
				case 280:
					goto IL_10E3;
				case 281:
					goto IL_1A06;
				case 282:
					goto IL_1BA3;
				case 283:
					goto IL_1D17;
				case 284:
					goto IL_C60;
				case 285:
					goto IL_EED;
				case 286:
					goto IL_1F07;
				case 287:
					goto IL_2598;
				case 288:
					goto IL_1AB8;
				case 289:
					goto IL_2BEC;
				case 290:
					goto IL_2DA4;
				case 291:
					goto IL_1342;
				case 292:
					goto IL_2906;
				case 293:
					goto IL_D7C;
				case 294:
					goto IL_2887;
				case 295:
					goto IL_14BC;
				case 296:
					goto IL_20DA;
				case 297:
					goto IL_168F;
				case 298:
					goto IL_C9E;
				case 299:
					goto IL_266C;
				case 300:
					goto IL_87D;
				case 301:
					goto IL_D62;
				case 302:
					goto IL_2A72;
				case 303:
					goto IL_23B5;
				case 304:
					goto IL_2EB9;
				case 305:
					goto IL_14AF;
				case 306:
					goto IL_29CE;
				case 307:
					goto IL_235D;
				case 308:
					goto IL_1F9A;
				case 309:
					goto IL_104D;
				case 310:
					goto IL_143D;
				case 311:
					goto IL_2BB8;
				case 312:
					goto IL_910;
				case 313:
					goto IL_1AC5;
				case 314:
					goto IL_BBD;
				case 315:
					goto IL_F76;
				case 316:
					goto IL_C2F;
				case 317:
					goto IL_100F;
				case 318:
					goto IL_F83;
				case 319:
					goto IL_161D;
				case 320:
					goto IL_2D0B;
				case 321:
					goto IL_2213;
				case 322:
					goto IL_2F63;
				case 323:
					goto IL_295F;
				case 324:
					goto IL_2567;
				case 325:
					goto IL_1FFC;
				case 326:
					goto IL_1D3E;
				case 327:
					goto IL_E4D;
				case 328:
					goto IL_181D;
				case 329:
					goto IL_23CF;
				case 330:
					goto IL_2543;
				case 331:
					goto IL_1A2D;
				case 332:
					goto IL_2B53;
				case 333:
					goto IL_2350;
				case 334:
					goto IL_241A;
				case 335:
					goto IL_2B60;
				case 336:
					goto IL_1C3C;
				case 337:
					goto IL_11FC;
				case 338:
					goto IL_9FE;
				case 339:
					goto IL_105A;
				case 340:
					goto IL_1C08;
				case 341:
					goto IL_2B6D;
				case 342:
					goto IL_2EF7;
				case 343:
					goto IL_E29;
				case 344:
					goto IL_12D0;
				case 345:
					goto IL_122D;
				case 346:
					goto IL_10C9;
				case 347:
					goto IL_2D97;
				case 348:
					goto IL_E05;
				case 349:
					goto IL_1029;
				case 350:
					goto IL_1637;
				case 351:
					goto IL_2166;
				case 352:
					goto IL_27DA;
				case 353:
					goto IL_FC1;
				case 354:
					goto IL_240D;
				case 355:
					goto IL_2A65;
				case 356:
					goto IL_30DE;
				case 357:
					goto IL_1CE6;
				case 358:
					goto IL_1002;
				case 359:
					goto IL_8DF;
				case 360:
					goto IL_1138;
				case 361:
					goto IL_28C8;
				case 362:
					goto IL_1B1D;
				case 363:
					goto IL_1067;
				case 364:
					goto IL_2505;
				case 365:
					goto IL_1735;
				case 366:
					goto IL_870;
				case 367:
					goto IL_2E20;
				case 368:
					goto IL_3010;
				case 369:
					goto IL_269D;
				case 370:
					goto IL_1CB5;
				case 371:
					goto IL_1675;
				case 372:
					goto IL_2BD2;
				case 373:
					goto IL_27A9;
				case 374:
					goto IL_14D6;
				case 375:
					goto IL_2458;
				case 376:
					goto IL_FDB;
				case 377:
					goto IL_E8B;
				case 378:
					goto IL_1949;
				case 379:
					goto IL_1728;
				case 380:
					goto IL_2C78;
				case 381:
					goto IL_2ED3;
				case 382:
					goto IL_15A1;
				case 383:
					goto IL_1416;
				case 384:
					goto IL_27F4;
				case 385:
					goto IL_1956;
				case 386:
					goto IL_ABB;
				case 387:
					goto IL_16C3;
				case 388:
					goto IL_2FDF;
				case 389:
					goto IL_2A58;
				case 390:
					goto IL_BFB;
				case 391:
					goto IL_2082;
				case 392:
					goto IL_1335;
				case 393:
					goto IL_C7A;
				case 394:
					goto IL_2983;
				case 395:
					goto IL_18CA;
				case 396:
					goto IL_2BDF;
				case 397:
					goto IL_2B08;
				case 398:
					goto IL_18FE;
				case 399:
					goto IL_1DC7;
				case 400:
					goto IL_22F8;
				case 401:
					goto IL_1D24;
				case 402:
					goto IL_20F4;
				case 403:
					goto IL_1B96;
				case 404:
					goto IL_1E7E;
				case 405:
					goto IL_152E;
				case 406:
					goto IL_B68;
				case 407:
					goto IL_2329;
				case 408:
					goto IL_D6F;
				case 409:
					goto IL_F69;
				case 410:
					goto IL_2D63;
				case 411:
					goto IL_185B;
				case 412:
					goto IL_F9D;
				case 413:
					goto IL_184E;
				case 414:
					goto IL_1514;
				case 415:
					goto IL_1701;
				case 416:
					goto IL_1220;
				case 417:
					goto IL_1742;
				case 418:
					goto IL_9C0;
				case 419:
					goto IL_1C2F;
				case 420:
					goto IL_178A;
				case 421:
					goto IL_2D70;
				case 422:
					goto IL_29C1;
				case 423:
					goto IL_8AE;
				case 424:
					goto IL_2377;
				case 425:
					goto IL_15BB;
				case 426:
					goto IL_1997;
				case 427:
					goto IL_1423;
				case 428:
					goto IL_A25;
				case 429:
					goto IL_BD7;
				case 430:
					goto IL_2574;
				case 431:
					goto IL_14A2;
				case 432:
					goto IL_101C;
				case 433:
					goto IL_2F70;
				case 434:
					goto IL_C08;
				case 435:
					goto IL_205E;
				case 436:
					goto IL_1A13;
				case 437:
					goto IL_1285;
				case 438:
					goto IL_1A9E;
				case 439:
					goto IL_2E3A;
				case 440:
					goto IL_2159;
				case 441:
					goto IL_23A8;
				case 442:
					goto IL_108B;
				case 443:
					goto IL_24A3;
				case 444:
					goto IL_3089;
				case 445:
					goto IL_2832;
				case 446:
					goto IL_AEC;
				case 447:
					goto IL_2E78;
				case 448:
					goto IL_C15;
				case 449:
					goto IL_1FBE;
				case 450:
					goto IL_2D32;
				case 451:
					goto IL_2AC7;
				case 452:
					goto IL_3133;
				case 453:
					goto IL_92A;
				case 454:
					goto IL_2E92;
				case 455:
					goto IL_31C3;
				case 456:
					goto IL_1AAB;
				case 457:
					goto IL_2489;
				case 458:
					goto IL_28D5;
				case 459:
					goto IL_1247;
				case 460:
					goto IL_293B;
				case 461:
					goto IL_24F8;
				case 462:
					goto IL_147B;
				case 463:
					goto IL_D0D;
				case 464:
					goto IL_1D7C;
				case 465:
					goto IL_2268;
				case 466:
					goto IL_99C;
				case 467:
					goto IL_13A4;
				case 468:
					goto IL_B41;
				case 469:
					goto IL_2D56;
				case 470:
					goto IL_3003;
				case 471:
					goto IL_8EC;
				case 472:
					goto IL_2CC3;
				case 473:
					goto IL_2DEF;
				case 474:
					goto IL_10D6;
				case 475:
					goto IL_2723;
				case 476:
					goto IL_1328;
				case 477:
					goto IL_12DD;
				case 478:
					goto IL_15F9;
				case 479:
					goto IL_2400;
				case 480:
					goto IL_1301;
				case 481:
					goto IL_2E2D;
				case 482:
					goto IL_2ABA;
				case 483:
					goto IL_1F38;
				case 484:
					goto IL_2E85;
				case 485:
					goto IL_228C;
				case 486:
					goto IL_203A;
				case 487:
					goto IL_2B9E;
				case 488:
					goto IL_2C1D;
				case 489:
					goto IL_170E;
				case 490:
					goto IL_1BD4;
				case 491:
					goto IL_2863;
				case 492:
					goto IL_29FF;
				case 493:
					goto IL_214C;
				case 494:
					goto IL_1488;
				case 495:
					goto IL_192F;
				case 496:
					goto IL_20E7;
				case 497:
					goto IL_1F76;
				case 498:
					goto IL_1292;
				case 499:
					goto IL_2C2A;
				case 500:
					goto IL_2343;
				case 501:
					goto IL_2CB6;
				case 502:
					goto IL_20B3;
				case 503:
					goto IL_22D4;
				case 504:
					goto IL_2730;
				case 505:
					goto IL_937;
				case 506:
					goto IL_18B0;
				case 507:
					goto IL_2AD4;
				case 508:
					goto IL_171B;
				case 509:
					goto IL_1570;
				case 510:
					goto IL_1E5A;
				case 511:
					goto IL_25FA;
				case 512:
					goto IL_1B10;
				case 513:
					goto IL_2BAB;
				case 514:
					goto IL_1A20;
				case 515:
					goto IL_15C8;
				case 516:
					goto IL_1176;
				case 517:
					goto IL_2AEE;
				case 518:
					goto IL_169C;
				case 519:
					goto IL_231C;
				default:
					num = (short)914751489;
					num2 = (int)((global::System.IntPtr)num);
					break;
				}
			}
			IL_870:
			this.DataProfNLSKMFProfSele_A36419Comp = (global::AcpUI.AcpLabel)target;
			return;
			IL_87D:
			this.DataProfilesDACOperationalMode_A36199 = (global::AcpUI.AcpComboBox)target;
			this.DataProfilesDACOperationalMode_A36199.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_8A1:
			this.RTDBtnDataProfilesGeneralBTDUNPeerIPAddress_A41127 = (global::AcpUI.AcpRtdButton)target;
			return;
			IL_8AE:
			this.LblDataProfVPNRekeyMargin_A42212 = (global::AcpUI.AcpLabel)target;
			this.LblDataProfVPNRekeyMargin_A42212.MouseDoubleClick += new global::System.Windows.Input.MouseButtonEventHandler(this.OnFieldNameDoubleClick);
			return;
			IL_8D2:
			this.DataProfGeneralAutoGenerateIPAddress_A19320Comp = (global::AcpUI.AcpCheckBox)target;
			return;
			IL_8DF:
			this.CpyBtnDataProfNLSSecClrStrp_A36415 = (global::AcpUI.AcpCopyButton)target;
			return;
			IL_8EC:
			this.LblQueueDwellTimerSec_42015 = (global::AcpUI.AcpLabel)target;
			this.LblQueueDwellTimerSec_42015.MouseDoubleClick += new global::System.Windows.Input.MouseButtonEventHandler(this.OnFieldNameDoubleClick);
			return;
			IL_910:
			this.ExpanderDataProfilesTrunkingGroupID = (global::AcpUI.AcpExpander)target;
			return;
			IL_91D:
			this.CpyBtnDataProfGeneralSubscriberAirInterfaceIPAddress_A9220 = (global::AcpUI.AcpCopyButton)target;
			return;
			IL_92A:
			this.RTDBtnDataProfEIDByPassListAddrType_A36418 = (global::AcpUI.AcpRtdButton)target;
			return;
			IL_937:
			this.RTDBtnDataProfLabtoolTrk25EIDBypassListItemID_A36423 = (global::AcpUI.AcpRtdButton)target;
			return;
			IL_944:
			this.RTDBtnDatProFeaturesStartSequence_A20537 = (global::AcpUI.AcpRtdButton)target;
			return;
			IL_951:
			this.ThemeBaseObj = (global::AcpUI.Common.AcpThemeBase)target;
			return;
			IL_95E:
			this.GrpBoxExpanderDataProfilesGeneralBluetoothDialUpNetworkingAddresses = (global::AcpUI.AcpGroupBox)target;
			return;
			IL_96B:
			this.CVBtnDataProfGeneralSubscriberIPAddress_A21157 = (global::AcpUI.AcpCustomViewCheckBox)target;
			return;
			IL_978:
			this.DataProfilesGeneralBTDUNPeerIPAddressAssignmentType_A41128 = (global::AcpUI.AcpComboBox)target;
			this.DataProfilesGeneralBTDUNPeerIPAddressAssignmentType_A41128.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_99C:
			this.AllowEnhancedDataToBeSentOnClassicDataChannel_42014 = (global::AcpUI.AcpCheckBox)target;
			this.AllowEnhancedDataToBeSentOnClassicDataChannel_42014.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_9C0:
			this.DataProfVPNDeadPeerDetectionInterval_A42211 = (global::AcpUI.AcpTextBoxSpinner)target;
			this.DataProfVPNDeadPeerDetectionInterval_A42211.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_9E4:
			this.CVBtnDataProfFeaturesAutomaticRegistrationServerAddress_A7524 = (global::AcpUI.AcpCustomViewCheckBox)target;
			return;
			IL_9F1:
			this.DataProfFeaturesARSMode_A7465Comp = (global::AcpUI.AcpLabel)target;
			return;
			IL_9FE:
			this.RTDBtnDataProfBroadbandSource_A42858 = (global::AcpUI.AcpRtdButton)target;
			return;
			IL_A0B:
			this.CVBtnDataProfFeaturesTerminalData_A9288 = (global::AcpUI.AcpCustomViewCheckBox)target;
			return;
			IL_A18:
			this.DataProfilesGeneralBTDUNPeerIPAddress_A41127Comp = (global::AcpUI.AcpLabel)target;
			return;
			IL_A25:
			this.CVBtnDataProfVPNRekeyAttempts_A42213 = (global::AcpUI.AcpCustomViewCheckBox)target;
			return;
			IL_A32:
			this.DataConigurationDataProfilePacketDataRegistrationVersion_A36210 = (global::AcpUI.AcpComboBox)target;
			this.DataConigurationDataProfilePacketDataRegistrationVersion_A36210.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_A56:
			this.RTDBtnDataConfigDataProfIntersystemData_A42381 = (global::AcpUI.AcpRtdButton)target;
			return;
			IL_A63:
			this.LblDataConfigDataProfIntersystemData_A42381 = (global::AcpUI.AcpLabel)target;
			this.LblDataConfigDataProfIntersystemData_A42381.MouseDoubleClick += new global::System.Windows.Input.MouseButtonEventHandler(this.OnFieldNameDoubleClick);
			return;
			IL_A87:
			this.DatProFeaturesTransmissionInhibitValue_A20541Comp = (global::AcpUI.AcpLabel)target;
			return;
			IL_A94:
			this.GrpBoxExpanderDataProfilesGeneralPseudo0 = (global::AcpUI.AcpGroupBox)target;
			return;
			IL_AA1:
			this.RTDBtnDatProFeaturesStopSequence_A20538 = (global::AcpUI.AcpRtdButton)target;
			return;
			IL_AAE:
			this.DataProfFeaturesTerminalData_A9288Comp = (global::AcpUI.AcpCheckBox)target;
			return;
			IL_ABB:
			this.CVBtnDataProfVPNSecClrStrp_A42120 = (global::AcpUI.AcpCustomViewCheckBox)target;
			return;
			IL_AC8:
			this.LblDataProfFeaturesARSRetryTimermin_A7466 = (global::AcpUI.AcpLabel)target;
			this.LblDataProfFeaturesARSRetryTimermin_A7466.MouseDoubleClick += new global::System.Windows.Input.MouseButtonEventHandler(this.OnFieldNameDoubleClick);
			return;
			IL_AEC:
			this.LblDataProfEIDByPassListIPAddr_A36417 = (global::AcpUI.AcpLabel)target;
			this.LblDataProfEIDByPassListIPAddr_A36417.MouseDoubleClick += new global::System.Windows.Input.MouseButtonEventHandler(this.OnFieldNameDoubleClick);
			return;
			IL_B10:
			this.RTDBtnDataProfGeneralSubscriberIPAddress_A21157 = (global::AcpUI.AcpRtdButton)target;
			return;
			IL_B1D:
			this.HLinkEIDBypassList = (global::System.Windows.Documents.Hyperlink)target;
			this.HLinkEIDBypassList.Click += this.HLinkClick;
			return;
			IL_B41:
			this.CpyBtnAllowEnhancedDataToBeSentOnClassicDataChannel_42014 = (global::AcpUI.AcpCopyButton)target;
			return;
			IL_B4E:
			this.RTDBtnDataProfGeneralSubscriberAirInterfaceIPAddress_A9220 = (global::AcpUI.AcpRtdButton)target;
			return;
			IL_B5B:
			this.RTDBtnDataProfGeneralAutoGenerateTargetIPAddress_A41697 = (global::AcpUI.AcpRtdButton)target;
			return;
			IL_B68:
			this.DataProfVPNMessageRetransmissionTime_A42209 = (global::AcpUI.AcpTextBoxSpinner)target;
			this.DataProfVPNMessageRetransmissionTime_A42209.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_B8C:
			this.DataProfGeneralQueueDwellTimersec_A8806Comp = (global::AcpUI.AcpLabel)target;
			return;
			IL_B99:
			this.LblDataProfGeneralSubscriberIPAddress_A21157 = (global::AcpUI.AcpLabel)target;
			this.LblDataProfGeneralSubscriberIPAddress_A21157.MouseDoubleClick += new global::System.Windows.Input.MouseButtonEventHandler(this.OnFieldNameDoubleClick);
			return;
			IL_BBD:
			this.ExpanderDataProfilesTrunkingGroupIDGrid = (global::System.Windows.Controls.Grid)target;
			return;
			IL_BCA:
			this.CpyBtnDataProfilesGeneralBTDUNPeerIPAddress_A41127 = (global::AcpUI.AcpCopyButton)target;
			return;
			IL_BD7:
			this.LblDataProfVPNRekeyAttempts_A42213 = (global::AcpUI.AcpLabel)target;
			this.LblDataProfVPNRekeyAttempts_A42213.MouseDoubleClick += new global::System.Windows.Input.MouseButtonEventHandler(this.OnFieldNameDoubleClick);
			return;
			IL_BFB:
			this.CpyBtnDataProfVPNSecClrStrp_A42120 = (global::AcpUI.AcpCopyButton)target;
			return;
			IL_C08:
			this.ExpanderDataProfilesEIDBypassList = (global::AcpUI.AcpExpander)target;
			return;
			IL_C15:
			this.CpyBtnDataProfEIDByPassListIPAddr_A36417 = (global::AcpUI.AcpCopyButton)target;
			return;
			IL_C22:
			this.DataProfGeneralMobileComputerIPAddress_A8523Comp = (global::AcpUI.AcpLabel)target;
			return;
			IL_C2F:
			this.ExpanderDataProfilesTrunkingGroupIDListTableView = (global::AcpUI.AcpGroupBox)target;
			return;
			IL_C3C:
			this.LblTrkSysLabtoolRetransmissionTimersec_A8672 = (global::AcpUI.AcpLabel)target;
			this.LblTrkSysLabtoolRetransmissionTimersec_A8672.MouseDoubleClick += new global::System.Windows.Input.MouseButtonEventHandler(this.OnFieldNameDoubleClick);
			return;
			IL_C60:
			this.CVBtnDataProfFeaturesAtakField = (global::AcpUI.AcpCustomViewCheckBox)target;
			return;
			IL_C6D:
			this.CVBtnDataProfGeneralAutoGenerateTargetIPAddress_A41697 = (global::AcpUI.AcpCustomViewCheckBox)target;
			return;
			IL_C7A:
			this.LblDataProfVPNKeySelection_42280 = (global::AcpUI.AcpLabel)target;
			this.LblDataProfVPNKeySelection_42280.MouseDoubleClick += new global::System.Windows.Input.MouseButtonEventHandler(this.OnFieldNameDoubleClick);
			return;
			IL_C9E:
			this.ExpanderDataProfilesDACListSRecView = (global::AcpUI.AcpGroupBox)target;
			return;
			IL_CAB:
			this.DataProfFeaturesAutomaticRegistrationServerAddress_A7524 = (global::AcpUI.AcpTextBox)target;
			this.DataProfFeaturesAutomaticRegistrationServerAddress_A7524.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_CCF:
			this.RTDBtnDataProfFeaturesApplicationTimeBetweenAttemptssec_A7460 = (global::AcpUI.AcpRtdButton)target;
			return;
			IL_CDC:
			this.CpyBtnDataProfFeaturesAutomaticRegistrationServerAddress_A7524 = (global::AcpUI.AcpCopyButton)target;
			return;
			IL_CE9:
			this.DatProFeaturesDestinationPort_A20544 = (global::AcpUI.AcpTextBoxSpinner)target;
			this.DatProFeaturesDestinationPort_A20544.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_D0D:
			this.DatProFeaturesPortListSelection_A42011Comp = (global::AcpUI.AcpLabel)target;
			return;
			IL_D1A:
			this.LblDatProFeaturesStartSequence_A20537 = (global::AcpUI.AcpLabel)target;
			this.LblDatProFeaturesStartSequence_A20537.MouseDoubleClick += new global::System.Windows.Input.MouseButtonEventHandler(this.OnFieldNameDoubleClick);
			return;
			IL_D3E:
			this.DataProfFeaturesDirLocReg_A42332 = (global::AcpUI.AcpCheckBox)target;
			this.DataProfFeaturesDirLocReg_A42332.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_D62:
			this.CVBtnDataProfilesDACOperationalMode_A36199 = (global::AcpUI.AcpCustomViewCheckBox)target;
			return;
			IL_D6F:
			this.CpyBtnDataProfVPNMessageRetransmissionTime_A42209 = (global::AcpUI.AcpCopyButton)target;
			return;
			IL_D7C:
			this.ExpanderDataProfilesDACListGrid = (global::System.Windows.Controls.Grid)target;
			return;
			IL_D89:
			this.LblDataProfGeneralSubscriberAirInterfaceIPAddress_A9220 = (global::AcpUI.AcpLabel)target;
			this.LblDataProfGeneralSubscriberAirInterfaceIPAddress_A9220.MouseDoubleClick += new global::System.Windows.Input.MouseButtonEventHandler(this.OnFieldNameDoubleClick);
			return;
			IL_DAD:
			this.RTDBtnPriorityScanRxVoiceInterruptsData_A42590 = (global::AcpUI.AcpRtdButton)target;
			return;
			IL_DBA:
			this.CpyBtnDataWideGeneralNATEnable_A38866 = (global::AcpUI.AcpCopyButton)target;
			return;
			IL_DC7:
			this.ExpanderDataProfilesGeneral = (global::AcpUI.AcpExpander)target;
			return;
			IL_DD4:
			this.CVBtnDataWideGeneralNATEnable_A38866 = (global::AcpUI.AcpCustomViewCheckBox)target;
			return;
			IL_DE1:
			this.LblDataProfFeatureContxActivHldoffMode_A36469 = (global::AcpUI.AcpLabel)target;
			this.LblDataProfFeatureContxActivHldoffMode_A36469.MouseDoubleClick += new global::System.Windows.Input.MouseButtonEventHandler(this.OnFieldNameDoubleClick);
			return;
			IL_E05:
			this.LblDataProfLTEBackupPTTGatewayPort_A43618 = (global::AcpUI.AcpLabel)target;
			this.LblDataProfLTEBackupPTTGatewayPort_A43618.MouseDoubleClick += new global::System.Windows.Input.MouseButtonEventHandler(this.OnFieldNameDoubleClick);
			return;
			IL_E29:
			this.DataProfLTEBackupPTTGatewayHostname_A43621 = (global::AcpUI.AcpTextBox)target;
			this.DataProfLTEBackupPTTGatewayHostname_A43621.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_E4D:
			this.ExpanderDataProfilesLTE = (global::AcpUI.AcpExpander)target;
			return;
			IL_E5A:
			this.CpyBtnTrkSysLabtoolRetransmissionTimersec_A8672 = (global::AcpUI.AcpCopyButton)target;
			return;
			IL_E67:
			this.DatProFeaturesTransmissionInhibitValue_A20541 = (global::AcpUI.AcpTextBoxSpinner)target;
			this.DatProFeaturesTransmissionInhibitValue_A20541.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_E8B:
			this.CpyBtnDataProfNLSEncGatewayAddr_A36412 = (global::AcpUI.AcpCopyButton)target;
			return;
			IL_E98:
			this.RecNavToolbarPageDataProfiles = (global::AcpUI.AcpParentRecNavToolbar)target;
			this.RecNavToolbarPageDataProfiles.ModeClick += this.OnModeClick;
			return;
			IL_EBC:
			((global::Motorola.MackinawCPS.CoreFeatures.DataProfiles.PageDataProfiles)target).Loaded += this.OnLoaded;
			((global::Motorola.MackinawCPS.CoreFeatures.DataProfiles.PageDataProfiles)target).Unloaded += this.OnUnloaded;
			return;
			IL_EED:
			this.LblDataProfFeaturesAtakField = (global::AcpUI.AcpLabel)target;
			this.LblDataProfFeaturesAtakField.MouseDoubleClick += new global::System.Windows.Input.MouseButtonEventHandler(this.OnFieldNameDoubleClick);
			return;
			IL_F11:
			this.DataProfFeaturesLocServerIPAddr_A42333Comp = (global::AcpUI.AcpLabel)target;
			return;
			IL_F1E:
			this.LblDataProfFeaturesAutomaticRegistrationServerAddress_A7524 = (global::AcpUI.AcpLabel)target;
			this.LblDataProfFeaturesAutomaticRegistrationServerAddress_A7524.MouseDoubleClick += new global::System.Windows.Input.MouseButtonEventHandler(this.OnFieldNameDoubleClick);
			return;
			IL_F42:
			this.RTDBtnTrkSysLabtoolRetransmissionTimersec_A8672 = (global::AcpUI.AcpRtdButton)target;
			return;
			IL_F4F:
			this.RTDBtnDatProFeaturesPADMode_A20536 = (global::AcpUI.AcpRtdButton)target;
			return;
			IL_F5C:
			this.DataWideGeneralNATEnable_A38866Comp = (global::AcpUI.AcpCheckBox)target;
			return;
			IL_F69:
			this.DataProfVPNMessageRetransmissionTime_A42209Comp = (global::AcpUI.AcpLabel)target;
			return;
			IL_F76:
			this.ExpanderDataProfilesTrunkingGroupIDListGrid = (global::System.Windows.Controls.Grid)target;
			return;
			IL_F83:
			this.DataProfilesTrunkingGroupID_ASTRO25DataGroupID_A36204_Col = (global::Infragistics.Windows.DataPresenter.UnboundField)target;
			return;
			IL_F90:
			this.GrpBoxExpanderDataProfilesGeneralPseudo3 = (global::AcpUI.AcpGroupBox)target;
			return;
			IL_F9D:
			this.DataProfVPNMessageRetransmissionAttempts_A42210 = (global::AcpUI.AcpTextBoxSpinner)target;
			this.DataProfVPNMessageRetransmissionAttempts_A42210.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_FC1:
			this.ExpanderDataProfilesNetworkLayerSecurity = (global::AcpUI.AcpExpander)target;
			return;
			IL_FCE:
			this.DatProFeaturesMaximumBufferThreshold_A20542Comp = (global::AcpUI.AcpLabel)target;
			return;
			IL_FDB:
			this.RTDBtnDataProfNLSEncGatewayAddr_A36412 = (global::AcpUI.AcpRtdButton)target;
			return;
			IL_FE8:
			this.RTDBtnDataConfigDataProfContextActivationHoldoffTime_A36551 = (global::AcpUI.AcpRtdButton)target;
			return;
			IL_FF5:
			this.CVBtnDataProfFeaturesARSRetryTimermin_A7466 = (global::AcpUI.AcpCustomViewCheckBox)target;
			return;
			IL_1002:
			this.RTDBtnDataProfNLSSecClrStrp_A36415 = (global::AcpUI.AcpRtdButton)target;
			return;
			IL_100F:
			this.ExpanderDataProfilesTrunkingGroupIDList = (global::AcpUI.AcpXamDataPresenter)target;
			return;
			IL_101C:
			this.CpyBtnDataProfVPNRekeyAttempts_A42213 = (global::AcpUI.AcpCopyButton)target;
			return;
			IL_1029:
			this.DataProfLTEBackupPTTGatewayPort_A43618 = (global::AcpUI.AcpTextBoxSpinner)target;
			this.DataProfLTEBackupPTTGatewayPort_A43618.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_104D:
			this.RTDBtnDataProfilesDACSlotSize_A36203 = (global::AcpUI.AcpRtdButton)target;
			return;
			IL_105A:
			this.CpyBtnDataProfBroadbandSource_A42858 = (global::AcpUI.AcpCopyButton)target;
			return;
			IL_1067:
			this.DataProfNLSKMFProfSele_A36419 = (global::AcpUI.AcpComboBox)target;
			this.DataProfNLSKMFProfSele_A36419.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_108B:
			this.ExpanderDataProfilesEIDBypassListTableSRecView = (global::AcpUI.AcpGroupBox)target;
			return;
			IL_1098:
			this.LblDataProfGeneralDataProfileType_A21320 = (global::AcpUI.AcpLabel)target;
			this.LblDataProfGeneralDataProfileType_A21320.MouseDoubleClick += new global::System.Windows.Input.MouseButtonEventHandler(this.OnFieldNameDoubleClick);
			return;
			IL_10BC:
			this.CpyBtnDataConfigDataProfContextActivationHoldoffTime_A36551 = (global::AcpUI.AcpCopyButton)target;
			return;
			IL_10C9:
			this.DataProfLTEBackupPTTGatewayHostname_A43621Comp = (global::AcpUI.AcpLabel)target;
			return;
			IL_10D6:
			this.CpyBtnQueueDwellTimerSec_42015 = (global::AcpUI.AcpCopyButton)target;
			return;
			IL_10E3:
			this.RTDBtnDatProFeaturesDestinationPort_A20544 = (global::AcpUI.AcpRtdButton)target;
			return;
			IL_10F0:
			this.LblDatProFeaturesPADMode_A20536 = (global::AcpUI.AcpLabel)target;
			this.LblDatProFeaturesPADMode_A20536.MouseDoubleClick += new global::System.Windows.Input.MouseButtonEventHandler(this.OnFieldNameDoubleClick);
			return;
			IL_1114:
			this.LblDataProfGeneralDataScanPreambleLength_A7798 = (global::AcpUI.AcpLabel)target;
			this.LblDataProfGeneralDataScanPreambleLength_A7798.MouseDoubleClick += new global::System.Windows.Input.MouseButtonEventHandler(this.OnFieldNameDoubleClick);
			return;
			IL_1138:
			this.DataProfNLSSecClrStrp_A36415Comp = (global::AcpUI.AcpLabel)target;
			return;
			IL_1145:
			this.DataProfFeaturesARSRetryTimermin_A7466Comp = (global::AcpUI.AcpLabel)target;
			return;
			IL_1152:
			this.DataProfFeaturesARSMode_A7465 = (global::AcpUI.AcpComboBox)target;
			this.DataProfFeaturesARSMode_A7465.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_1176:
			this.DataProfLabtoolDATA_PROFTrunkingARSDeregistrationDelayTimer_A9475 = (global::AcpUI.AcpTextBoxSpinner)target;
			this.DataProfLabtoolDATA_PROFTrunkingARSDeregistrationDelayTimer_A9475.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_119A:
			this.CVBtnDatProFeaturesEscapeSequence_A20539 = (global::AcpUI.AcpCustomViewCheckBox)target;
			return;
			IL_11A7:
			this.LblDataProfGeneralPacketDataMode_A8689 = (global::AcpUI.AcpLabel)target;
			this.LblDataProfGeneralPacketDataMode_A8689.MouseDoubleClick += new global::System.Windows.Input.MouseButtonEventHandler(this.OnFieldNameDoubleClick);
			return;
			IL_11CB:
			this.CpyBtnDataProfGeneralDataScanPreambleLength_A7798 = (global::AcpUI.AcpCopyButton)target;
			return;
			IL_11D8:
			this.LblDataWideGeneralNATEnable_A38866 = (global::AcpUI.AcpLabel)target;
			this.LblDataWideGeneralNATEnable_A38866.MouseDoubleClick += new global::System.Windows.Input.MouseButtonEventHandler(this.OnFieldNameDoubleClick);
			return;
			IL_11FC:
			this.DataProfBroadbandSource_A42858 = (global::AcpUI.AcpComboBox)target;
			this.DataProfBroadbandSource_A42858.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_1220:
			this.CVBtnDataProfVPNDeadPeerDetectionInterval_A42211 = (global::AcpUI.AcpCustomViewCheckBox)target;
			return;
			IL_122D:
			this.CpyBtnDataProfLTEBackupPTTGatewayHostname_A43621 = (global::AcpUI.AcpCopyButton)target;
			return;
			IL_123A:
			this.RTDBtnDatProFeaturesDestinationAddress_A20543 = (global::AcpUI.AcpRtdButton)target;
			return;
			IL_1247:
			this.LblDatProFeaturesPortListSelection_A42011 = (global::AcpUI.AcpLabel)target;
			this.LblDatProFeaturesPortListSelection_A42011.MouseDoubleClick += new global::System.Windows.Input.MouseButtonEventHandler(this.OnFieldNameDoubleClick);
			return;
			IL_126B:
			this.CpyBtnDataConfigDataProfIntersystemData_A42381 = (global::AcpUI.AcpCopyButton)target;
			return;
			IL_1278:
			this.CVBtnDatProFeaturesReceiveIdleTimeOut_A20540 = (global::AcpUI.AcpCustomViewCheckBox)target;
			return;
			IL_1285:
			this.ExpanderDataProfilesEIDBypassListTableGrid = (global::System.Windows.Controls.Grid)target;
			return;
			IL_1292:
			this.DataConfigurationDataProfileTrunkingA25DataGroupIDListItemNameId_A36219 = (global::AcpUI.AcpComboBox)target;
			this.DataConfigurationDataProfileTrunkingA25DataGroupIDListItemNameId_A36219.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_12B6:
			this.RTDBtnDataProfFeaturesApplicationNumberofAttempts_A7458 = (global::AcpUI.AcpRtdButton)target;
			return;
			IL_12C3:
			this.DataConfigDataProfContextActivationHoldoffTime_A36551Comp = (global::AcpUI.AcpLabel)target;
			return;
			IL_12D0:
			this.RTDBtnDataProfLTEBackupPTTGatewayHostname_A43621 = (global::AcpUI.AcpRtdButton)target;
			return;
			IL_12DD:
			this.LblDatProSendDataDurEmerHangtime_A43103 = (global::AcpUI.AcpLabel)target;
			this.LblDatProSendDataDurEmerHangtime_A43103.MouseDoubleClick += new global::System.Windows.Input.MouseButtonEventHandler(this.OnFieldNameDoubleClick);
			return;
			IL_1301:
			this.CpyBtnDatProSendDataDurEmerHangtime_A43103 = (global::AcpUI.AcpCopyButton)target;
			return;
			IL_130E:
			this.GrpBoxExpanderDataProfilesFeaturesRetryTimers = (global::AcpUI.AcpGroupBox)target;
			return;
			IL_131B:
			this.CVBtnDataProfFeaturesLocServerIPAddr_A42333 = (global::AcpUI.AcpCustomViewCheckBox)target;
			return;
			IL_1328:
			this.CVBtnDatProSendDataDurEmerHangtime_A43103 = (global::AcpUI.AcpCustomViewCheckBox)target;
			return;
			IL_1335:
			this.CVBtnDataProfVPNKeySelection_42280 = (global::AcpUI.AcpCustomViewCheckBox)target;
			return;
			IL_1342:
			this.RecNavToolbarExpanderDataProfilesDACList = (global::AcpUI.AcpChildRecNavToolbar)target;
			this.RecNavToolbarExpanderDataProfilesDACList.ModeClick += this.OnModeClick;
			return;
			IL_1366:
			this.LblDataConfigDataProfContextActivationHoldoffTime_A36551 = (global::AcpUI.AcpLabel)target;
			this.LblDataConfigDataProfContextActivationHoldoffTime_A36551.MouseDoubleClick += new global::System.Windows.Input.MouseButtonEventHandler(this.OnFieldNameDoubleClick);
			return;
			IL_138A:
			this.RTDBtnDataWideGeneralNATEnable_A38866 = (global::AcpUI.AcpRtdButton)target;
			return;
			IL_1397:
			this.CVBtnDatProFeaturesTransmissionInhibitValue_A20541 = (global::AcpUI.AcpCustomViewCheckBox)target;
			return;
			IL_13A4:
			this.RTDBtnAllowEnhancedDataToBeSentOnClassicDataChannel_42014 = (global::AcpUI.AcpRtdButton)target;
			return;
			IL_13B1:
			this.CpyBtnDataProfGeneralDataProfileType_A21320 = (global::AcpUI.AcpCopyButton)target;
			return;
			IL_13BE:
			this.CpyBtnDataProfGeneralAutoGenerateTargetIPAddress_A41697 = (global::AcpUI.AcpCopyButton)target;
			return;
			IL_13CB:
			this.DataProfilesGeneralBTDUNSUIPAddress_A41126 = (global::AcpUI.AcpTextBox)target;
			this.DataProfilesGeneralBTDUNSUIPAddress_A41126.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_13EF:
			this.TrkSysLabtoolRxVoiceInterruptsData_A9043Comp = (global::AcpUI.AcpCheckBox)target;
			return;
			IL_13FC:
			this.GrpBoxExpanderDataProfilesFeaturesPseudo0 = (global::AcpUI.AcpGroupBox)target;
			return;
			IL_1409:
			this.CVBtnDataProfGeneralLimitedBroadcast_A8431 = (global::AcpUI.AcpCustomViewCheckBox)target;
			return;
			IL_1416:
			this.CpyBtnDataProfNLSAllowRxClrPackData_A36414 = (global::AcpUI.AcpCopyButton)target;
			return;
			IL_1423:
			this.DataProfVPNRekeyMargin_A42212Comp = (global::AcpUI.AcpLabel)target;
			return;
			IL_1430:
			this.RTDBtnDataConigurationDataProfilePacketDataRegistrationVersion_A36210 = (global::AcpUI.AcpRtdButton)target;
			return;
			IL_143D:
			this.CpyBtnDataProfilesDACSlotSize_A36203 = (global::AcpUI.AcpCopyButton)target;
			return;
			IL_144A:
			this.CVBtnDatProFeaturesStopSequence_A20538 = (global::AcpUI.AcpCustomViewCheckBox)target;
			return;
			IL_1457:
			this.DataProfGeneralMobileComputerIPAddress_A8523 = (global::AcpUI.AcpTextBox)target;
			this.DataProfGeneralMobileComputerIPAddress_A8523.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_147B:
			this.CpyBtnDatProFeaturesPortListSelection_A42011 = (global::AcpUI.AcpCopyButton)target;
			return;
			IL_1488:
			this.CpyBtnDataConfigurationDataProfileTrunkingA25DACMappingListItemNameId_A36218 = (global::AcpUI.AcpCopyButton)target;
			return;
			IL_1495:
			this.CpyBtnPriorityScanRxVoiceInterruptsData_A42590 = (global::AcpUI.AcpCopyButton)target;
			return;
			IL_14A2:
			this.RTDBtnDataProfVPNRekeyAttempts_A42213 = (global::AcpUI.AcpRtdButton)target;
			return;
			IL_14AF:
			this.DataProfilesDACOperationalMode_A36199Comp = (global::AcpUI.AcpLabel)target;
			return;
			IL_14BC:
			this.ExpanderDataProfilesDACList = (global::AcpUI.AcpXamDataPresenter)target;
			return;
			IL_14C9:
			this.CpyBtnDatProFeaturesStopSequence_A20538 = (global::AcpUI.AcpCopyButton)target;
			return;
			IL_14D6:
			this.LblDataProfNLSEncGatewayAddr_A36412 = (global::AcpUI.AcpLabel)target;
			this.LblDataProfNLSEncGatewayAddr_A36412.MouseDoubleClick += new global::System.Windows.Input.MouseButtonEventHandler(this.OnFieldNameDoubleClick);
			return;
			IL_14FA:
			this.CpyBtnDatProFeaturesMaximumBufferThreshold_A20542 = (global::AcpUI.AcpCopyButton)target;
			return;
			IL_1507:
			this.DataConfigDataProfIntersystemData_A42381Comp = (global::AcpUI.AcpCheckBox)target;
			return;
			IL_1514:
			this.CpyBtnDataProfVPNMessageRetransmissionAttempts_A42210 = (global::AcpUI.AcpCopyButton)target;
			return;
			IL_1521:
			this.CVBtnDataWideGeneralPeerIPAddressAssignmentType_A22263 = (global::AcpUI.AcpCustomViewCheckBox)target;
			return;
			IL_152E:
			this.LblDataProfVPNMessageRetransmissionTime_A42209 = (global::AcpUI.AcpLabel)target;
			this.LblDataProfVPNMessageRetransmissionTime_A42209.MouseDoubleClick += new global::System.Windows.Input.MouseButtonEventHandler(this.OnFieldNameDoubleClick);
			return;
			IL_156B:
			goto IL_320E;
			IL_1570:
			this.LblDataProfLabtoolDATA_PROFConventionalARSDeregistrationDelayTimer_A20991 = (global::AcpUI.AcpLabel)target;
			this.LblDataProfLabtoolDATA_PROFConventionalARSDeregistrationDelayTimer_A20991.MouseDoubleClick += new global::System.Windows.Input.MouseButtonEventHandler(this.OnFieldNameDoubleClick);
			return;
			IL_1594:
			this.CVBtnTrkSysLabtoolRxVoiceInterruptsData_A9043 = (global::AcpUI.AcpCustomViewCheckBox)target;
			return;
			IL_15A1:
			this.RTDBtnDataProfNLSAllowRxClrPackData_A36414 = (global::AcpUI.AcpRtdButton)target;
			return;
			IL_15AE:
			this.RTDBtnDatProFeaturesTransmissionInhibitValue_A20541 = (global::AcpUI.AcpRtdButton)target;
			return;
			IL_15BB:
			this.RTDBtnDataProfVPNRekeyMargin_A42212 = (global::AcpUI.AcpRtdButton)target;
			return;
			IL_15C8:
			this.LblDataProfLabtoolDATA_PROFTrunkingARSDeregistrationDelayTimer_A9475 = (global::AcpUI.AcpLabel)target;
			this.LblDataProfLabtoolDATA_PROFTrunkingARSDeregistrationDelayTimer_A9475.MouseDoubleClick += new global::System.Windows.Input.MouseButtonEventHandler(this.OnFieldNameDoubleClick);
			return;
			IL_15EC:
			this.RTDBtnDataProfGeneralAutoGenerateIPAddress_A19320 = (global::AcpUI.AcpRtdButton)target;
			return;
			IL_15F9:
			this.DatProSendDataDurEmerHangtime_A43103 = (global::AcpUI.AcpCheckBox)target;
			this.DatProSendDataDurEmerHangtime_A43103.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_161D:
			this.ExpanderDataProfilesTrunkingGroupIDListSRecView = (global::AcpUI.AcpGroupBox)target;
			return;
			IL_162A:
			this.CpyBtnDataProfFeaturesApplicationTimeBetweenAttemptssec_A7460 = (global::AcpUI.AcpCopyButton)target;
			return;
			IL_1637:
			this.RTDBtnDataProfLTEBackupPTTGatewayPort_A43618 = (global::AcpUI.AcpRtdButton)target;
			return;
			IL_1644:
			this.DataWideGeneralNATEnable_A38866 = (global::AcpUI.AcpCheckBox)target;
			this.DataWideGeneralNATEnable_A38866.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_1668:
			this.CVBtnDataProfGeneralMobileComputerIPAddress_A8523 = (global::AcpUI.AcpCustomViewCheckBox)target;
			return;
			IL_1675:
			this.CpyBtnDataProfNLSKeySele_A36410 = (global::AcpUI.AcpCopyButton)target;
			return;
			IL_1682:
			this.GrpBoxExpanderDataProfilesGeneralPseudo2 = (global::AcpUI.AcpGroupBox)target;
			return;
			IL_168F:
			this.DataProfilesDACSlotSize_A36203_Col = (global::Infragistics.Windows.DataPresenter.UnboundField)target;
			return;
			IL_169C:
			this.CpyBtnDataProfLabtoolDATA_PROFTrunkingARSDeregistrationDelayTimer_A9475 = (global::AcpUI.AcpCopyButton)target;
			return;
			IL_16A9:
			this.RTDBtnDataProfGeneralPacketDataMode_A8689 = (global::AcpUI.AcpRtdButton)target;
			return;
			IL_16B6:
			this.CVBtnDatProFeaturesStartSequence_A20537 = (global::AcpUI.AcpCustomViewCheckBox)target;
			return;
			IL_16C3:
			this.LblDataProfVPNSecClrStrp_A42120 = (global::AcpUI.AcpLabel)target;
			this.LblDataProfVPNSecClrStrp_A42120.MouseDoubleClick += new global::System.Windows.Input.MouseButtonEventHandler(this.OnFieldNameDoubleClick);
			return;
			IL_16E7:
			this.CpyBtnDatProFeaturesEscapeSequence_A20539 = (global::AcpUI.AcpCopyButton)target;
			return;
			IL_16F4:
			this.DatProFeaturesEscapeSequence_A20539Comp = (global::AcpUI.AcpLabel)target;
			return;
			IL_1701:
			this.DataProfVPNMessageRetransmissionAttempts_A42210Comp = (global::AcpUI.AcpLabel)target;
			return;
			IL_170E:
			this.DataProfLabtoolDATA_PROFDataDeliveryMode_A11468Comp = (global::AcpUI.AcpLabel)target;
			return;
			IL_171B:
			this.CVBtnDataProfLabtoolDATA_PROFConventionalARSDeregistrationDelayTimer_A20991 = (global::AcpUI.AcpCustomViewCheckBox)target;
			return;
			IL_1728:
			this.CVBtnDataProfNLSAllowRxClrPackData_A36414 = (global::AcpUI.AcpCustomViewCheckBox)target;
			return;
			IL_1735:
			this.CpyBtnDataProfNLSKMFProfSele_A36419 = (global::AcpUI.AcpCopyButton)target;
			return;
			IL_1742:
			this.LblDataProfVPNDeadPeerDetectionInterval_A42211 = (global::AcpUI.AcpLabel)target;
			this.LblDataProfVPNDeadPeerDetectionInterval_A42211.MouseDoubleClick += new global::System.Windows.Input.MouseButtonEventHandler(this.OnFieldNameDoubleClick);
			return;
			IL_1766:
			this.DataProfFeaturesApplicationTimeBetweenAttemptssec_A7460 = (global::AcpUI.AcpTextBoxSpinner)target;
			this.DataProfFeaturesApplicationTimeBetweenAttemptssec_A7460.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_178A:
			this.CpyBtnDataProfVPNDeadPeerDetectionInterval_A42211 = (global::AcpUI.AcpCopyButton)target;
			return;
			IL_1797:
			this.DataProfFeaturesApplicationTimeBetweenAttemptssec_A7460Comp = (global::AcpUI.AcpLabel)target;
			return;
			IL_17A4:
			this.HLinkLabtoolDATA_PROF = (global::System.Windows.Documents.Hyperlink)target;
			this.HLinkLabtoolDATA_PROF.Click += this.HLinkClick;
			return;
			IL_17C8:
			this.TrkSysLabtoolRetransmissionTimersec_A8672 = (global::AcpUI.AcpTextBoxSpinner)target;
			this.TrkSysLabtoolRetransmissionTimersec_A8672.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_17EC:
			this.RTDBtnDataConfigDataProfIPHeaderCompressionEnable_A36190 = (global::AcpUI.AcpRtdButton)target;
			return;
			IL_17F9:
			this.DataProfGeneralAutoGenerateIPAddress_A19320 = (global::AcpUI.AcpCheckBox)target;
			this.DataProfGeneralAutoGenerateIPAddress_A19320.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_181D:
			this.GrpBoxExpanderDataProfilesLTEPseudo0 = (global::AcpUI.AcpGroupBox)target;
			return;
			IL_182A:
			this.DataProfGeneralDataScanPreambleLength_A7798 = (global::AcpUI.AcpTextBoxSpinner)target;
			this.DataProfGeneralDataScanPreambleLength_A7798.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_184E:
			this.RTDBtnDataProfVPNMessageRetransmissionAttempts_A42210 = (global::AcpUI.AcpRtdButton)target;
			return;
			IL_185B:
			this.LblDataProfVPNMessageRetransmissionAttempts_A42210 = (global::AcpUI.AcpLabel)target;
			this.LblDataProfVPNMessageRetransmissionAttempts_A42210.MouseDoubleClick += new global::System.Windows.Input.MouseButtonEventHandler(this.OnFieldNameDoubleClick);
			return;
			IL_187F:
			this.DatProFeaturesStartSequence_A20537Comp = (global::AcpUI.AcpLabel)target;
			return;
			IL_188C:
			this.DataProfGeneralkeyofDataProfiles_A19446 = (global::AcpUI.AcpTextBox)target;
			this.DataProfGeneralkeyofDataProfiles_A19446.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_18B0:
			this.CpyBtnDataProfLabtoolTrk25EIDBypassListItemID_A36423 = (global::AcpUI.AcpCopyButton)target;
			return;
			IL_18BD:
			this.RTDBtnDataProfFeatureContxActivHldoffMode_A36469 = (global::AcpUI.AcpRtdButton)target;
			return;
			IL_18CA:
			this.RTDBtnDataProfVPNKeySelection_42280 = (global::AcpUI.AcpRtdButton)target;
			return;
			IL_18D7:
			this.GrpBoxExpanderDataProfilesGeneralSerialLink1Addresses = (global::AcpUI.AcpGroupBox)target;
			return;
			IL_18E4:
			this.CpyBtnDataProfFeaturesLocServerIPAddr_A42333 = (global::AcpUI.AcpCopyButton)target;
			return;
			IL_18F1:
			this.RTDBtnDataProfFeaturesARSMode_A7465 = (global::AcpUI.AcpRtdButton)target;
			return;
			IL_18FE:
			this.CVBtnDataProfVPNGatewayIPAddress_A42079 = (global::AcpUI.AcpCustomViewCheckBox)target;
			return;
			IL_190B:
			this.DatProFeaturesEscapeSequence_A20539 = (global::AcpUI.AcpTextBox)target;
			this.DatProFeaturesEscapeSequence_A20539.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_192F:
			this.DataConfigurationDataProfileTrunkingA25DACMappingListItemNameId_A36218Comp = (global::AcpUI.AcpLabel)target;
			return;
			IL_193C:
			this.CVBtnDataConfigDataProfRandomHoldOffTime_A36552 = (global::AcpUI.AcpCustomViewCheckBox)target;
			return;
			IL_1949:
			this.DataProfNLSEncGatewayAddr_A36412Comp = (global::AcpUI.AcpLabel)target;
			return;
			IL_1956:
			this.GrpBoxExpanderDataProfilesNetworkLayerSecurityVPN = (global::AcpUI.AcpGroupBox)target;
			return;
			IL_1963:
			this.DataProfGeneralkeyofDataProfiles_A19446Comp = (global::AcpUI.AcpLabel)target;
			return;
			IL_1970:
			this.CpyBtnDatProFeaturesDestinationAddress_A20543 = (global::AcpUI.AcpCopyButton)target;
			return;
			IL_197D:
			this.DatProFeaturesReceiveIdleTimeOut_A20540Comp = (global::AcpUI.AcpLabel)target;
			return;
			IL_198A:
			this.CpyBtnDataConfigDataProfIPHeaderCompressionEnable_A36190 = (global::AcpUI.AcpCopyButton)target;
			return;
			IL_1997:
			this.CpyBtnDataProfVPNRekeyMargin_A42212 = (global::AcpUI.AcpCopyButton)target;
			return;
			IL_19A4:
			this.DatProFeaturesDestinationAddress_A20543 = (global::AcpUI.AcpTextBox)target;
			this.DatProFeaturesDestinationAddress_A20543.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_19C8:
			this.CpyBtnDataProfGeneralQueueDwellTimersec_A8806 = (global::AcpUI.AcpCopyButton)target;
			return;
			IL_19D5:
			this.DataConigurationDataProfilePacketDataRegistrationVersion_A36210Comp = (global::AcpUI.AcpLabel)target;
			return;
			IL_19E2:
			this.DataProfFeaturesARSRetryTimermin_A7466 = (global::AcpUI.AcpTextBoxSpinner)target;
			this.DataProfFeaturesARSRetryTimermin_A7466.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_1A06:
			this.CpyBtnDatProFeaturesDestinationPort_A20544 = (global::AcpUI.AcpCopyButton)target;
			return;
			IL_1A13:
			this.ExpanderDataProfilesEIDBypassListGrid = (global::System.Windows.Controls.Grid)target;
			return;
			IL_1A20:
			this.CVBtnDataProfLabtoolDATA_PROFTrunkingARSDeregistrationDelayTimer_A9475 = (global::AcpUI.AcpCustomViewCheckBox)target;
			return;
			IL_1A2D:
			num = (short)2092598771;
			short num3 = num;
			num = (short)1365542387;
			switch ((num3 == num) ? 1 : 0)
			{
			case 0:
			case 2:
				IL_2607:
				this.CpyBtnDataProfGeneralSubscriberIPAddress_A21157 = (global::AcpUI.AcpCopyButton)target;
				return;
			default:
				num = (short)1359347712;
				if (num != 0)
				{
				}
				this.DataProfLTEEnabled_A42075 = (global::AcpUI.AcpCheckBox)target;
				this.DataProfLTEEnabled_A42075.GotFocus += this.OnFieldNameDoubleClick;
				return;
			}
			IL_1A9E:
			this.ExpanderDataProfilesEIDBypassListTableTableView = (global::AcpUI.AcpGroupBox)target;
			return;
			IL_1AAB:
			this.ExpanderDataProfilesEnhancedData = (global::AcpUI.AcpExpander)target;
			return;
			IL_1AB8:
			this.CpyBtnDataProfFeaturesAtakField = (global::AcpUI.AcpCopyButton)target;
			return;
			IL_1AC5:
			this.RecNavToolbarExpanderDataProfilesTrunkingGroupIDList = (global::AcpUI.AcpChildRecNavToolbar)target;
			this.RecNavToolbarExpanderDataProfilesTrunkingGroupIDList.ModeClick += this.OnModeClick;
			return;
			IL_1AE9:
			this.DatProFeaturesStopSequence_A20538Comp = (global::AcpUI.AcpLabel)target;
			return;
			IL_1AF6:
			this.RTDBtnDataProfilesGeneralBTDUNSUIPAddress_A41126 = (global::AcpUI.AcpRtdButton)target;
			return;
			IL_1B03:
			this.RTDBtnDataConfigDataProfRandomHoldOffTime_A36552 = (global::AcpUI.AcpRtdButton)target;
			return;
			IL_1B10:
			this.CpyBtnDataProfLabtoolDATA_PROFConventionalARSDeregistrationDelayTimer_A20991 = (global::AcpUI.AcpCopyButton)target;
			return;
			IL_1B1D:
			this.LblDataProfNLSKMFProfSele_A36419 = (global::AcpUI.AcpLabel)target;
			this.LblDataProfNLSKMFProfSele_A36419.MouseDoubleClick += new global::System.Windows.Input.MouseButtonEventHandler(this.OnFieldNameDoubleClick);
			return;
			IL_1B41:
			this.LblDatProFeaturesTransmissionInhibitValue_A20541 = (global::AcpUI.AcpLabel)target;
			this.LblDatProFeaturesTransmissionInhibitValue_A20541.MouseDoubleClick += new global::System.Windows.Input.MouseButtonEventHandler(this.OnFieldNameDoubleClick);
			return;
			IL_1B65:
			this.CpyBtnDataProfGeneralLimitedBroadcast_A8431 = (global::AcpUI.AcpCopyButton)target;
			return;
			IL_1B72:
			this.LblDataProfGeneralkeyofDataProfiles_A19446 = (global::AcpUI.AcpLabel)target;
			this.LblDataProfGeneralkeyofDataProfiles_A19446.MouseDoubleClick += new global::System.Windows.Input.MouseButtonEventHandler(this.OnFieldNameDoubleClick);
			return;
			IL_1B96:
			this.DataProfVPNGatewayIPAddress_A42079Comp = (global::AcpUI.AcpLabel)target;
			return;
			IL_1BA3:
			this.DatProFeaturesDestinationPort_A20544Comp = (global::AcpUI.AcpLabel)target;
			return;
			IL_1BB0:
			this.DataProfFeaturesTerminalData_A9288 = (global::AcpUI.AcpCheckBox)target;
			this.DataProfFeaturesTerminalData_A9288.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_1BD4:
			this.CVBtnDataConfigurationDataProfileTrunkingA25DACMappingListItemNameId_A36218 = (global::AcpUI.AcpCustomViewCheckBox)target;
			return;
			IL_1BE1:
			this.DataConfigDataProfIPHeaderCompressionEnable_A36190Comp = (global::AcpUI.AcpCheckBox)target;
			return;
			IL_1BEE:
			this.RTDBtnDataProfFeaturesDirLocReg_A42332 = (global::AcpUI.AcpRtdButton)target;
			return;
			IL_1BFB:
			this.CVBtnDatProFeaturesDestinationPort_A20544 = (global::AcpUI.AcpCustomViewCheckBox)target;
			return;
			IL_1C08:
			this.DataProfBroadbandSource_A42858Comp = (global::AcpUI.AcpLabel)target;
			return;
			IL_1C15:
			this.DataConfigDataProfRandomHoldOffTime_A36552Comp = (global::AcpUI.AcpCheckBox)target;
			return;
			IL_1C22:
			this.CVBtnDataConigurationDataProfilePacketDataRegistrationVersion_A36210 = (global::AcpUI.AcpCustomViewCheckBox)target;
			return;
			IL_1C2F:
			this.RTDBtnDataProfVPNDeadPeerDetectionInterval_A42211 = (global::AcpUI.AcpRtdButton)target;
			return;
			IL_1C3C:
			this.LblDataProfBroadbandSource_A42858 = (global::AcpUI.AcpLabel)target;
			this.LblDataProfBroadbandSource_A42858.MouseDoubleClick += new global::System.Windows.Input.MouseButtonEventHandler(this.OnFieldNameDoubleClick);
			return;
			IL_1C60:
			this.DataConfigDataProfIPHeaderCompressionEnable_A36190 = (global::AcpUI.AcpCheckBox)target;
			this.DataConfigDataProfIPHeaderCompressionEnable_A36190.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_1C84:
			this.CVBtnDataConfigDataProfContextActivationHoldoffTime_A36551 = (global::AcpUI.AcpCustomViewCheckBox)target;
			return;
			IL_1C91:
			this.DataProfGeneralSubscriberAirInterfaceIPAddress_A9220 = (global::AcpUI.AcpTextBox)target;
			this.DataProfGeneralSubscriberAirInterfaceIPAddress_A9220.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_1CB5:
			this.RTDBtnDataProfNLSKeySele_A36410 = (global::AcpUI.AcpRtdButton)target;
			return;
			IL_1CC2:
			this.DataProfGeneralAutoGenerateTargetIPAddress_A41697 = (global::AcpUI.AcpCheckBox)target;
			this.DataProfGeneralAutoGenerateTargetIPAddress_A41697.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_1CE6:
			this.DataProfNLSSecClrStrp_A36415 = (global::AcpUI.AcpComboBox)target;
			this.DataProfNLSSecClrStrp_A36415.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_1D0A:
			this.CVBtnDatProFeaturesPADMode_A20536 = (global::AcpUI.AcpCustomViewCheckBox)target;
			return;
			IL_1D17:
			this.GrpBoxExpanderDataProfilesFeaturesATAK = (global::AcpUI.AcpGroupBox)target;
			return;
			IL_1D24:
			this.RTDBtnDataProfVPNGatewayIPAddress_A42079 = (global::AcpUI.AcpRtdButton)target;
			return;
			IL_1D31:
			this.RTDBtnDatProFeaturesMaximumBufferThreshold_A20542 = (global::AcpUI.AcpRtdButton)target;
			return;
			IL_1D3E:
			this.DataProfilesTrunkingGroupID_ASTRO25DataGroupID_A36204Comp = (global::AcpUI.AcpTextBoxDecHex)target;
			return;
			IL_1D4B:
			this.DatProFeaturesDestinationAddress_A20543Comp = (global::AcpUI.AcpLabel)target;
			return;
			IL_1D58:
			this.DataWideGeneralPeerIPAddressAssignmentType_A22263 = (global::AcpUI.AcpComboBox)target;
			this.DataWideGeneralPeerIPAddressAssignmentType_A22263.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_1D7C:
			this.CVBtnAllowEnhancedDataToBeSentOnClassicDataChannel_42014 = (global::AcpUI.AcpCustomViewCheckBox)target;
			return;
			IL_1D89:
			this.CpyBtnDatProFeaturesPADMode_A20536 = (global::AcpUI.AcpCopyButton)target;
			return;
			IL_1D96:
			this.RTDBtnDataProfGeneralDataProfileType_A21320 = (global::AcpUI.AcpRtdButton)target;
			return;
			IL_1DA3:
			this.DataProfFeaturesLocServerIPAddr_A42333 = (global::AcpUI.AcpTextBox)target;
			this.DataProfFeaturesLocServerIPAddr_A42333.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_1DC7:
			this.LblDataProfVPNGatewayIPAddress_A42079 = (global::AcpUI.AcpLabel)target;
			this.LblDataProfVPNGatewayIPAddress_A42079.MouseDoubleClick += new global::System.Windows.Input.MouseButtonEventHandler(this.OnFieldNameDoubleClick);
			return;
			IL_1DEB:
			this.CVBtnDataProfFeatureContxActivHldoffMode_A36469 = (global::AcpUI.AcpCustomViewCheckBox)target;
			return;
			IL_1DF8:
			this.HLinkNetworkLayerSecurity = (global::System.Windows.Documents.Hyperlink)target;
			this.HLinkNetworkLayerSecurity.Click += this.HLinkClick;
			return;
			IL_1E1C:
			this.RTDBtnDataProfFeaturesARSRetryTimermin_A7466 = (global::AcpUI.AcpRtdButton)target;
			return;
			IL_1E29:
			this.CVBtnDataConfigDataProfIntersystemData_A42381 = (global::AcpUI.AcpCustomViewCheckBox)target;
			return;
			IL_1E36:
			this.HLinkLTE = (global::System.Windows.Documents.Hyperlink)target;
			this.HLinkLTE.Click += this.HLinkClick;
			return;
			IL_1E5A:
			this.DataProfLabtoolDATA_PROFConventionalARSDeregistrationDelayTimer_A20991 = (global::AcpUI.AcpTextBoxSpinner)target;
			this.DataProfLabtoolDATA_PROFConventionalARSDeregistrationDelayTimer_A20991.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_1E7E:
			this.CVBtnDataProfVPNMessageRetransmissionTime_A42209 = (global::AcpUI.AcpCustomViewCheckBox)target;
			return;
			IL_1E8B:
			this.LblDataProfFeaturesApplicationTimeBetweenAttemptssec_A7460 = (global::AcpUI.AcpLabel)target;
			this.LblDataProfFeaturesApplicationTimeBetweenAttemptssec_A7460.MouseDoubleClick += new global::System.Windows.Input.MouseButtonEventHandler(this.OnFieldNameDoubleClick);
			return;
			IL_1EAF:
			this.CpyBtnDataProfGeneralkeyofDataProfiles_A19446 = (global::AcpUI.AcpCopyButton)target;
			return;
			IL_1EBC:
			this.RTDBtnTrkSysLabtoolRxVoiceInterruptsData_A9043 = (global::AcpUI.AcpRtdButton)target;
			return;
			IL_1EC9:
			this.DataConfigDataProfIntersystemData_A42381 = (global::AcpUI.AcpCheckBox)target;
			this.DataConfigDataProfIntersystemData_A42381.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_1EED:
			this.CpyBtnDataProfFeatureContxActivHldoffMode_A36469 = (global::AcpUI.AcpCopyButton)target;
			return;
			IL_1EFA:
			this.CVBtnDataProfFeaturesApplicationTimeBetweenAttemptssec_A7460 = (global::AcpUI.AcpCustomViewCheckBox)target;
			return;
			IL_1F07:
			this.DataProfFeaturesAtakField = (global::AcpUI.AcpCheckBox)target;
			this.DataProfFeaturesAtakField.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_1F2B:
			this.RTDBtnDataProfGeneralQueueDwellTimersec_A8806 = (global::AcpUI.AcpRtdButton)target;
			return;
			IL_1F38:
			this.GrpBoxExpanderDataProfilesLabtoolDATA_PROFPseudo0 = (global::AcpUI.AcpGroupBox)target;
			return;
			IL_1F45:
			this.DataConfigDataProfContextActivationHoldoffTime_A36551 = (global::AcpUI.AcpTextBoxSpinner)target;
			this.DataConfigDataProfContextActivationHoldoffTime_A36551.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_1F69:
			this.CpyBtnDataProfGeneralMobileComputerIPAddress_A8523 = (global::AcpUI.AcpCopyButton)target;
			return;
			IL_1F76:
			this.LblDataConfigurationDataProfileTrunkingA25DataGroupIDListItemNameId_A36219 = (global::AcpUI.AcpLabel)target;
			this.LblDataConfigurationDataProfileTrunkingA25DataGroupIDListItemNameId_A36219.MouseDoubleClick += new global::System.Windows.Input.MouseButtonEventHandler(this.OnFieldNameDoubleClick);
			return;
			IL_1F9A:
			this.LblDataProfilesDACSlotSize_A36203 = (global::AcpUI.AcpLabel)target;
			this.LblDataProfilesDACSlotSize_A36203.MouseDoubleClick += new global::System.Windows.Input.MouseButtonEventHandler(this.OnFieldNameDoubleClick);
			return;
			IL_1FBE:
			this.DataProfEIDByPassListIPAddr_A36417Comp = (global::AcpUI.AcpLabel)target;
			return;
			IL_1FCB:
			this.HLinkDAC = (global::System.Windows.Documents.Hyperlink)target;
			this.HLinkDAC.Click += this.HLinkClick;
			return;
			IL_1FEF:
			this.DataProfGeneralPacketDataMode_A8689Comp = (global::AcpUI.AcpLabel)target;
			return;
			IL_1FFC:
			this.CpyBtnDataProfilesTrunkingGroupID_ASTRO25DataGroupID_A36204 = (global::AcpUI.AcpCopyButton)target;
			return;
			IL_2009:
			this.DataConfigDataProfRandomHoldOffTime_A36552 = (global::AcpUI.AcpCheckBox)target;
			this.DataConfigDataProfRandomHoldOffTime_A36552.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_202D:
			this.DataProfilesGeneralBTDUNPeerIPAddressAssignmentType_A41128Comp = (global::AcpUI.AcpLabel)target;
			return;
			IL_203A:
			this.DataProfLabtoolDATA_PROFDataDeliveryMode_A11468 = (global::AcpUI.AcpComboBox)target;
			this.DataProfLabtoolDATA_PROFDataDeliveryMode_A11468.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_205E:
			this.RecNavToolbarExpanderDataProfilesEIDBypassListTable = (global::AcpUI.AcpChildRecNavToolbar)target;
			this.RecNavToolbarExpanderDataProfilesEIDBypassListTable.ModeClick += this.OnModeClick;
			return;
			IL_2082:
			this.DataProfVPNSecClrStrp_A42120Comp = (global::AcpUI.AcpLabel)target;
			return;
			IL_208F:
			this.LblDatProFeaturesStopSequence_A20538 = (global::AcpUI.AcpLabel)target;
			this.LblDatProFeaturesStopSequence_A20538.MouseDoubleClick += new global::System.Windows.Input.MouseButtonEventHandler(this.OnFieldNameDoubleClick);
			return;
			IL_20B3:
			this.CVBtnDataProfLabtoolTrk25EIDBypassListItemID_A36423 = (global::AcpUI.AcpCustomViewCheckBox)target;
			return;
			IL_20C0:
			this.CpyBtnDatProFeaturesReceiveIdleTimeOut_A20540 = (global::AcpUI.AcpCopyButton)target;
			return;
			IL_20CD:
			this.CVBtnDataProfilesGeneralBTDUNSUIPAddress_A41126 = (global::AcpUI.AcpCustomViewCheckBox)target;
			return;
			IL_20DA:
			this.DataProfilesDACOperationalMode_A36199_Col = (global::Infragistics.Windows.DataPresenter.UnboundField)target;
			return;
			IL_20E7:
			this.CVBtnDataConfigurationDataProfileTrunkingA25DataGroupIDListItemNameId_A36219 = (global::AcpUI.AcpCustomViewCheckBox)target;
			return;
			IL_20F4:
			this.CpyBtnDataProfVPNGatewayIPAddress_A42079 = (global::AcpUI.AcpCopyButton)target;
			return;
			IL_2101:
			this.CVBtnDataConfigDataProfIPHeaderCompressionEnable_A36190 = (global::AcpUI.AcpCustomViewCheckBox)target;
			return;
			IL_210E:
			this.DataProfGeneralDataProfileType_A21320Comp = (global::AcpUI.AcpLabel)target;
			return;
			IL_211B:
			this.GrpBoxExpanderDataProfilesGeneralRegistration = (global::AcpUI.AcpGroupBox)target;
			return;
			IL_2128:
			this.LblDataConigurationDataProfilePacketDataRegistrationVersion_A36210 = (global::AcpUI.AcpLabel)target;
			this.LblDataConigurationDataProfilePacketDataRegistrationVersion_A36210.MouseDoubleClick += new global::System.Windows.Input.MouseButtonEventHandler(this.OnFieldNameDoubleClick);
			return;
			IL_214C:
			this.RTDBtnDataConfigurationDataProfileTrunkingA25DACMappingListItemNameId_A36218 = (global::AcpUI.AcpRtdButton)target;
			return;
			IL_2159:
			this.DataProfEIDByPassListIPAddr_A36417_Col = (global::Infragistics.Windows.DataPresenter.UnboundField)target;
			return;
			IL_2166:
			this.CpyBtnDataProfLTEBackupPTTGatewayPort_A43618 = (global::AcpUI.AcpCopyButton)target;
			return;
			IL_2173:
			this.CVBtnDataProfFeaturesApplicationNumberofAttempts_A7458 = (global::AcpUI.AcpCustomViewCheckBox)target;
			return;
			IL_2180:
			this.CVBtnDataProfGeneralSubscriberAirInterfaceIPAddress_A9220 = (global::AcpUI.AcpCustomViewCheckBox)target;
			return;
			IL_218D:
			this.LblDataProfFeaturesLocServerIPAddr_A42333 = (global::AcpUI.AcpLabel)target;
			this.LblDataProfFeaturesLocServerIPAddr_A42333.MouseDoubleClick += new global::System.Windows.Input.MouseButtonEventHandler(this.OnFieldNameDoubleClick);
			return;
			IL_21B1:
			this.DataProfGeneralSubscriberIPAddress_A21157 = (global::AcpUI.AcpTextBox)target;
			this.DataProfGeneralSubscriberIPAddress_A21157.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_21D5:
			this.CVBtnPriorityScanRxVoiceInterruptsData_A42590 = (global::AcpUI.AcpCustomViewCheckBox)target;
			return;
			IL_21E2:
			this.RTDBtnDatProFeaturesEscapeSequence_A20539 = (global::AcpUI.AcpRtdButton)target;
			return;
			IL_21EF:
			this.LblDataProfFeaturesTerminalData_A9288 = (global::AcpUI.AcpLabel)target;
			this.LblDataProfFeaturesTerminalData_A9288.MouseDoubleClick += new global::System.Windows.Input.MouseButtonEventHandler(this.OnFieldNameDoubleClick);
			return;
			IL_2213:
			this.DataProfilesTrunkingGroupID_ASTRO25DataGroupID_A36204 = (global::AcpUI.AcpTextBoxSpinnerDecHex)target;
			this.DataProfilesTrunkingGroupID_ASTRO25DataGroupID_A36204.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_2237:
			this.LblDataConfigDataProfRandomHoldOffTime_A36552 = (global::AcpUI.AcpLabel)target;
			this.LblDataConfigDataProfRandomHoldOffTime_A36552.MouseDoubleClick += new global::System.Windows.Input.MouseButtonEventHandler(this.OnFieldNameDoubleClick);
			return;
			IL_225B:
			this.CpyBtnTrkSysLabtoolRxVoiceInterruptsData_A9043 = (global::AcpUI.AcpCopyButton)target;
			return;
			IL_2268:
			this.LblAllowEnhancedDataToBeSentOnClassicDataChannel_42014 = (global::AcpUI.AcpLabel)target;
			this.LblAllowEnhancedDataToBeSentOnClassicDataChannel_42014.MouseDoubleClick += new global::System.Windows.Input.MouseButtonEventHandler(this.OnFieldNameDoubleClick);
			return;
			IL_228C:
			this.LblDataProfLabtoolDATA_PROFDataDeliveryMode_A11468 = (global::AcpUI.AcpLabel)target;
			this.LblDataProfLabtoolDATA_PROFDataDeliveryMode_A11468.MouseDoubleClick += new global::System.Windows.Input.MouseButtonEventHandler(this.OnFieldNameDoubleClick);
			return;
			IL_22B0:
			this.LblDataProfFeaturesApplicationNumberofAttempts_A7458 = (global::AcpUI.AcpLabel)target;
			this.LblDataProfFeaturesApplicationNumberofAttempts_A7458.MouseDoubleClick += new global::System.Windows.Input.MouseButtonEventHandler(this.OnFieldNameDoubleClick);
			return;
			IL_22D4:
			this.LblDataProfLabtoolTrk25EIDBypassListItemID_A36423 = (global::AcpUI.AcpLabel)target;
			this.LblDataProfLabtoolTrk25EIDBypassListItemID_A36423.MouseDoubleClick += new global::System.Windows.Input.MouseButtonEventHandler(this.OnFieldNameDoubleClick);
			return;
			IL_22F8:
			this.DataProfVPNGatewayIPAddress_A42079 = (global::AcpUI.AcpTextBox)target;
			this.DataProfVPNGatewayIPAddress_A42079.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_231C:
			this.DataProfLabtoolDATA_PROFTrunkingARSDeregistrationDelayTimer_A9475Comp = (global::AcpUI.AcpLabel)target;
			return;
			IL_2329:
			this.RTDBtnDataProfVPNMessageRetransmissionTime_A42209 = (global::AcpUI.AcpRtdButton)target;
			return;
			IL_2336:
			this.CVBtnDataProfGeneralQueueDwellTimersec_A8806 = (global::AcpUI.AcpCustomViewCheckBox)target;
			return;
			IL_2343:
			this.CpyBtnDataConfigurationDataProfileTrunkingA25DataGroupIDListItemNameId_A36219 = (global::AcpUI.AcpCopyButton)target;
			return;
			IL_2350:
			this.CpyBtnDataProfLTEEnabled_A42075 = (global::AcpUI.AcpCopyButton)target;
			return;
			IL_235D:
			this.CVBtnDataProfilesDACSlotSize_A36203 = (global::AcpUI.AcpCustomViewCheckBox)target;
			return;
			IL_236A:
			this.DataProfGeneralLimitedBroadcast_A8431Comp = (global::AcpUI.AcpCheckBox)target;
			return;
			IL_2377:
			this.DataProfVPNRekeyMargin_A42212 = (global::AcpUI.AcpTextBoxSpinner)target;
			this.DataProfVPNRekeyMargin_A42212.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_239B:
			this.RTDBtnDataProfGeneralLimitedBroadcast_A8431 = (global::AcpUI.AcpRtdButton)target;
			return;
			IL_23A8:
			this.DataProfEIDByPassListAddrType_A36418_Col = (global::Infragistics.Windows.DataPresenter.UnboundField)target;
			return;
			IL_23B5:
			this.RTDBtnDataProfilesDACOperationalMode_A36199 = (global::AcpUI.AcpRtdButton)target;
			return;
			IL_23C2:
			this.TrkSysLabtoolRetransmissionTimersec_A8672Comp = (global::AcpUI.AcpLabel)target;
			return;
			IL_23CF:
			this.CVBtnDataProfLTEEnabled_A42075 = (global::AcpUI.AcpCustomViewCheckBox)target;
			return;
			IL_23DC:
			this.DataProfilesGeneralBTDUNPeerIPAddress_A41127 = (global::AcpUI.AcpTextBox)target;
			this.DataProfilesGeneralBTDUNPeerIPAddress_A41127.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_2400:
			this.RTDBtnDatProSendDataDurEmerHangtime_A43103 = (global::AcpUI.AcpRtdButton)target;
			return;
			IL_240D:
			this.GrpBoxExpanderDataProfilesNetworkLayerSecurityPacketDataAPCO25 = (global::AcpUI.AcpGroupBox)target;
			return;
			IL_241A:
			this.DataProfLTEEnabled_A42075Comp = (global::AcpUI.AcpCheckBox)target;
			return;
			IL_2427:
			this.HLinkEnhancedData = (global::System.Windows.Documents.Hyperlink)target;
			this.HLinkEnhancedData.Click += this.HLinkClick;
			return;
			IL_244B:
			this.GrpBoxExpanderDataProfilesFeaturesARS = (global::AcpUI.AcpGroupBox)target;
			return;
			IL_2458:
			this.DataProfNLSEncGatewayAddr_A36412 = (global::AcpUI.AcpTextBox)target;
			this.DataProfNLSEncGatewayAddr_A36412.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_247C:
			this.CpyBtnDataProfFeaturesARSRetryTimermin_A7466 = (global::AcpUI.AcpCopyButton)target;
			return;
			IL_2489:
			this.GrpBoxExpanderDataProfilesEnhancedDataPseudo0 = (global::AcpUI.AcpGroupBox)target;
			return;
			IL_2496:
			this.RTDBtnDataProfGeneralDataScanPreambleLength_A7798 = (global::AcpUI.AcpRtdButton)target;
			return;
			IL_24A3:
			this.gridExpanderDataProfilesEIDBypassListTableSRecView = (global::System.Windows.Controls.Grid)target;
			return;
			IL_24B0:
			this.DataProfFeaturesApplicationNumberofAttempts_A7458 = (global::AcpUI.AcpTextBoxSpinner)target;
			this.DataProfFeaturesApplicationNumberofAttempts_A7458.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_24D4:
			this.DatProFeaturesStartSequence_A20537 = (global::AcpUI.AcpTextBox)target;
			this.DatProFeaturesStartSequence_A20537.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_24F8:
			this.RTDBtnDatProFeaturesPortListSelection_A42011 = (global::AcpUI.AcpRtdButton)target;
			return;
			IL_2505:
			this.RTDBtnDataProfNLSKMFProfSele_A36419 = (global::AcpUI.AcpRtdButton)target;
			return;
			IL_2512:
			this.RTDBtnDataProfFeaturesAutomaticRegistrationServerAddress_A7524 = (global::AcpUI.AcpRtdButton)target;
			return;
			IL_251F:
			this.DataProfFeatureContxActivHldoffMode_A36469 = (global::AcpUI.AcpComboBox)target;
			this.DataProfFeatureContxActivHldoffMode_A36469.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_2543:
			this.LblDataProfLTEEnabled_A42075 = (global::AcpUI.AcpLabel)target;
			this.LblDataProfLTEEnabled_A42075.MouseDoubleClick += new global::System.Windows.Input.MouseButtonEventHandler(this.OnFieldNameDoubleClick);
			return;
			IL_2567:
			this.RTDBtnDataProfilesTrunkingGroupID_ASTRO25DataGroupID_A36204 = (global::AcpUI.AcpRtdButton)target;
			return;
			IL_2574:
			this.DataProfVPNRekeyAttempts_A42213 = (global::AcpUI.AcpTextBoxSpinner)target;
			this.DataProfVPNRekeyAttempts_A42213.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_2598:
			this.RTDBtnDataProfFeaturesAtakField = (global::AcpUI.AcpRtdButton)target;
			return;
			IL_25A5:
			this.DataProfGeneralDataProfileType_A21320 = (global::AcpUI.AcpComboBox)target;
			this.DataProfGeneralDataProfileType_A21320.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_25C9:
			this.LblDatProFeaturesMaximumBufferThreshold_A20542 = (global::AcpUI.AcpLabel)target;
			this.LblDatProFeaturesMaximumBufferThreshold_A20542.MouseDoubleClick += new global::System.Windows.Input.MouseButtonEventHandler(this.OnFieldNameDoubleClick);
			return;
			IL_25ED:
			this.DataWideGeneralPeerIPAddressAssignmentType_A22263Comp = (global::AcpUI.AcpLabel)target;
			return;
			IL_25FA:
			this.RTDBtnDataProfLabtoolDATA_PROFConventionalARSDeregistrationDelayTimer_A20991 = (global::AcpUI.AcpRtdButton)target;
			return;
			IL_2614:
			this.DataProfGeneralQueueDwellTimersec_A8806 = (global::AcpUI.AcpTextBoxSpinner)target;
			this.DataProfGeneralQueueDwellTimersec_A8806.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_2638:
			this.RTDBtnDataWideGeneralPeerIPAddressAssignmentType_A22263 = (global::AcpUI.AcpRtdButton)target;
			return;
			IL_2645:
			this.RTDBtnDatProFeaturesReceiveIdleTimeOut_A20540 = (global::AcpUI.AcpRtdButton)target;
			return;
			IL_2652:
			this.CpyBtnDataConfigDataProfRandomHoldOffTime_A36552 = (global::AcpUI.AcpCopyButton)target;
			return;
			IL_265F:
			this.CpyBtnDataProfFeaturesARSMode_A7465 = (global::AcpUI.AcpCopyButton)target;
			return;
			IL_266C:
			this.gridExpanderDataProfilesDACListSRecView = (global::System.Windows.Controls.Grid)target;
			return;
			IL_2679:
			this.DataProfGeneralLimitedBroadcast_A8431 = (global::AcpUI.AcpCheckBox)target;
			this.DataProfGeneralLimitedBroadcast_A8431.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_269D:
			this.DataProfNLSKeySele_A36410 = (global::AcpUI.AcpComboBox)target;
			this.DataProfNLSKeySele_A36410.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_26C1:
			this.DataProfFeatureContxActivHldoffMode_A36469Comp = (global::AcpUI.AcpLabel)target;
			return;
			IL_26CE:
			this.LblDataProfFeaturesARSMode_A7465 = (global::AcpUI.AcpLabel)target;
			this.LblDataProfFeaturesARSMode_A7465.MouseDoubleClick += new global::System.Windows.Input.MouseButtonEventHandler(this.OnFieldNameDoubleClick);
			return;
			IL_26F2:
			this.DatProFeaturesStopSequence_A20538 = (global::AcpUI.AcpTextBox)target;
			this.DatProFeaturesStopSequence_A20538.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_2716:
			this.CVBtnDataProfilesGeneralBTDUNPeerIPAddress_A41127 = (global::AcpUI.AcpCustomViewCheckBox)target;
			return;
			IL_2723:
			this.QueueDwellTimerSec_42015Comp = (global::AcpUI.AcpLabel)target;
			return;
			IL_2730:
			this.DataProfLabtoolTrk25EIDBypassListItemID_A36423 = (global::AcpUI.AcpComboBox)target;
			this.DataProfLabtoolTrk25EIDBypassListItemID_A36423.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_2754:
			this.CVBtnDataProfilesGeneralBTDUNPeerIPAddressAssignmentType_A41128 = (global::AcpUI.AcpCustomViewCheckBox)target;
			return;
			IL_2761:
			this.DatProFeaturesPADMode_A20536 = (global::AcpUI.AcpComboBox)target;
			this.DatProFeaturesPADMode_A20536.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_2785:
			this.LblDataProfGeneralLimitedBroadcast_A8431 = (global::AcpUI.AcpLabel)target;
			this.LblDataProfGeneralLimitedBroadcast_A8431.MouseDoubleClick += new global::System.Windows.Input.MouseButtonEventHandler(this.OnFieldNameDoubleClick);
			return;
			IL_27A9:
			this.CVBtnDataProfNLSEncGatewayAddr_A36412 = (global::AcpUI.AcpCustomViewCheckBox)target;
			return;
			IL_27B6:
			this.LblDataProfilesGeneralBTDUNPeerIPAddressAssignmentType_A41128 = (global::AcpUI.AcpLabel)target;
			this.LblDataProfilesGeneralBTDUNPeerIPAddressAssignmentType_A41128.MouseDoubleClick += new global::System.Windows.Input.MouseButtonEventHandler(this.OnFieldNameDoubleClick);
			return;
			IL_27DA:
			this.DataProfLTEBackupPTTGatewayPort_A43618Comp = (global::AcpUI.AcpLabel)target;
			return;
			IL_27E7:
			this.DataProfGeneralSubscriberIPAddress_A21157Comp = (global::AcpUI.AcpLabel)target;
			return;
			IL_27F4:
			this.DataProfNLSAllowRxClrPackData_A36414Comp = (global::AcpUI.AcpCheckBox)target;
			return;
			IL_2801:
			this.DatProFeaturesReceiveIdleTimeOut_A20540 = (global::AcpUI.AcpTextBoxSpinner)target;
			this.DatProFeaturesReceiveIdleTimeOut_A20540.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_2825:
			this.RTDBtnDataProfFeaturesLocServerIPAddr_A42333 = (global::AcpUI.AcpRtdButton)target;
			return;
			IL_2832:
			this.CVBtnDataProfEIDByPassListIPAddr_A36417 = (global::AcpUI.AcpCustomViewCheckBox)target;
			return;
			IL_283F:
			this.LblDataProfGeneralMobileComputerIPAddress_A8523 = (global::AcpUI.AcpLabel)target;
			this.LblDataProfGeneralMobileComputerIPAddress_A8523.MouseDoubleClick += new global::System.Windows.Input.MouseButtonEventHandler(this.OnFieldNameDoubleClick);
			return;
			IL_2863:
			this.LblDataConfigurationDataProfileTrunkingA25DACMappingListItemNameId_A36218 = (global::AcpUI.AcpLabel)target;
			this.LblDataConfigurationDataProfileTrunkingA25DACMappingListItemNameId_A36218.MouseDoubleClick += new global::System.Windows.Input.MouseButtonEventHandler(this.OnFieldNameDoubleClick);
			return;
			IL_2887:
			this.ExpanderDataProfilesDACListTableView = (global::AcpUI.AcpGroupBox)target;
			return;
			IL_2894:
			this.CpyBtnDataProfGeneralPacketDataMode_A8689 = (global::AcpUI.AcpCopyButton)target;
			return;
			IL_28A1:
			this.CpyBtnDataWideGeneralPeerIPAddressAssignmentType_A22263 = (global::AcpUI.AcpCopyButton)target;
			return;
			IL_28AE:
			this.DatProFeaturesPADMode_A20536Comp = (global::AcpUI.AcpLabel)target;
			return;
			IL_28BB:
			this.CpyBtnDatProFeaturesTransmissionInhibitValue_A20541 = (global::AcpUI.AcpCopyButton)target;
			return;
			IL_28C8:
			this.CVBtnDataProfNLSKMFProfSele_A36419 = (global::AcpUI.AcpCustomViewCheckBox)target;
			return;
			IL_28D5:
			this.CVBtnDatProFeaturesPortListSelection_A42011 = (global::AcpUI.AcpCustomViewCheckBox)target;
			return;
			IL_28E2:
			this.LblDataConfigDataProfIPHeaderCompressionEnable_A36190 = (global::AcpUI.AcpLabel)target;
			this.LblDataConfigDataProfIPHeaderCompressionEnable_A36190.MouseDoubleClick += new global::System.Windows.Input.MouseButtonEventHandler(this.OnFieldNameDoubleClick);
			return;
			IL_2906:
			num = (short)1696989184;
			short num4 = num;
			this.ExpanderDataProfilesDACGrid = (global::System.Windows.Controls.Grid)target;
			return;
			IL_293B:
			this.DatProFeaturesPortListSelection_A42011 = (global::AcpUI.AcpComboBox)target;
			this.DatProFeaturesPortListSelection_A42011.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_295F:
			this.LblDataProfilesTrunkingGroupID_ASTRO25DataGroupID_A36204 = (global::AcpUI.AcpLabel)target;
			this.LblDataProfilesTrunkingGroupID_ASTRO25DataGroupID_A36204.MouseDoubleClick += new global::System.Windows.Input.MouseButtonEventHandler(this.OnFieldNameDoubleClick);
			return;
			IL_2983:
			this.DataProfVPNKeySelection_42280 = (global::AcpUI.AcpComboBox)target;
			this.DataProfVPNKeySelection_42280.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_29A7:
			this.RTDBtnDataProfilesGeneralBTDUNPeerIPAddressAssignmentType_A41128 = (global::AcpUI.AcpRtdButton)target;
			return;
			IL_29B4:
			this.DataProfGeneralAutoGenerateTargetIPAddress_A41697Comp = (global::AcpUI.AcpCheckBox)target;
			return;
			IL_29C1:
			this.CVBtnDataProfVPNRekeyMargin_A42212 = (global::AcpUI.AcpCustomViewCheckBox)target;
			return;
			IL_29CE:
			this.DataProfilesDACSlotSize_A36203 = (global::AcpUI.AcpComboBox)target;
			this.DataProfilesDACSlotSize_A36203.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_29F2:
			this.CpyBtnDataProfFeaturesApplicationNumberofAttempts_A7458 = (global::AcpUI.AcpCopyButton)target;
			return;
			IL_29FF:
			this.DataConfigurationDataProfileTrunkingA25DACMappingListItemNameId_A36218 = (global::AcpUI.AcpComboBox)target;
			this.DataConfigurationDataProfileTrunkingA25DACMappingListItemNameId_A36218.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_2A23:
			num = (short)265486337;
			if (num != 0)
			{
			}
			this.CVBtnDataProfGeneralDataScanPreambleLength_A7798 = (global::AcpUI.AcpCustomViewCheckBox)target;
			return;
			IL_2A58:
			this.RTDBtnDataProfVPNSecClrStrp_A42120 = (global::AcpUI.AcpRtdButton)target;
			return;
			IL_2A65:
			this.CVBtnDataProfNLSSecClrStrp_A36415 = (global::AcpUI.AcpCustomViewCheckBox)target;
			return;
			IL_2A72:
			this.LblDataProfilesDACOperationalMode_A36199 = (global::AcpUI.AcpLabel)target;
			this.LblDataProfilesDACOperationalMode_A36199.MouseDoubleClick += new global::System.Windows.Input.MouseButtonEventHandler(this.OnFieldNameDoubleClick);
			return;
			IL_2A96:
			this.TrkSysLabtoolRxVoiceInterruptsData_A9043 = (global::AcpUI.AcpCheckBox)target;
			this.TrkSysLabtoolRxVoiceInterruptsData_A9043.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_2ABA:
			this.ExpanderDataProfilesLabtoolDATA_PROF = (global::AcpUI.AcpExpander)target;
			return;
			IL_2AC7:
			this.CVBtnDataProfEIDByPassListAddrType_A36418 = (global::AcpUI.AcpCustomViewCheckBox)target;
			return;
			IL_2AD4:
			this.DataProfLabtoolTrk25EIDBypassListItemID_A36423Comp = (global::AcpUI.AcpLabel)target;
			return;
			IL_2AE1:
			this.DataProfFeaturesApplicationNumberofAttempts_A7458Comp = (global::AcpUI.AcpLabel)target;
			return;
			IL_2AEE:
			this.RTDBtnDataProfLabtoolDATA_PROFTrunkingARSDeregistrationDelayTimer_A9475 = (global::AcpUI.AcpRtdButton)target;
			return;
			IL_2AFB:
			this.DataProfFeaturesAutomaticRegistrationServerAddress_A7524Comp = (global::AcpUI.AcpLabel)target;
			return;
			IL_2B08:
			this.DataProfVPNKeySelection_42280Comp = (global::AcpUI.AcpLabel)target;
			return;
			IL_2B15:
			this.CVBtnDataProfGeneralPacketDataMode_A8689 = (global::AcpUI.AcpCustomViewCheckBox)target;
			return;
			IL_2B22:
			this.DatProFeaturesMaximumBufferThreshold_A20542 = (global::AcpUI.AcpTextBoxSpinner)target;
			this.DatProFeaturesMaximumBufferThreshold_A20542.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_2B46:
			this.CpyBtnDataProfGeneralAutoGenerateIPAddress_A19320 = (global::AcpUI.AcpCopyButton)target;
			return;
			IL_2B53:
			this.RTDBtnDataProfLTEEnabled_A42075 = (global::AcpUI.AcpRtdButton)target;
			return;
			IL_2B60:
			this.CVBtnDataProfBroadbandSource_A42858 = (global::AcpUI.AcpCustomViewCheckBox)target;
			return;
			IL_2B6D:
			this.CVBtnDataProfLTEBackupPTTGatewayHostname_A43621 = (global::AcpUI.AcpCustomViewCheckBox)target;
			return;
			IL_2B7A:
			this.LblPriorityScanRxVoiceInterruptsData_A42590 = (global::AcpUI.AcpLabel)target;
			this.LblPriorityScanRxVoiceInterruptsData_A42590.MouseDoubleClick += new global::System.Windows.Input.MouseButtonEventHandler(this.OnFieldNameDoubleClick);
			return;
			IL_2B9E:
			this.RTDBtnDataProfLabtoolDATA_PROFDataDeliveryMode_A11468 = (global::AcpUI.AcpRtdButton)target;
			return;
			IL_2BAB:
			this.DataProfLabtoolDATA_PROFConventionalARSDeregistrationDelayTimer_A20991Comp = (global::AcpUI.AcpLabel)target;
			return;
			IL_2BB8:
			this.DataProfilesDACSlotSize_A36203Comp = (global::AcpUI.AcpLabel)target;
			return;
			IL_2BC5:
			this.CVBtnDataProfGeneralkeyofDataProfiles_A19446 = (global::AcpUI.AcpCustomViewCheckBox)target;
			return;
			IL_2BD2:
			this.DataProfNLSKeySele_A36410Comp = (global::AcpUI.AcpLabel)target;
			return;
			IL_2BDF:
			this.CpyBtnDataProfVPNKeySelection_42280 = (global::AcpUI.AcpCopyButton)target;
			return;
			IL_2BEC:
			this.DataProfFeaturesAtakFieldComp = (global::AcpUI.AcpCheckBox)target;
			return;
			IL_2BF9:
			this.LblDatProFeaturesDestinationPort_A20544 = (global::AcpUI.AcpLabel)target;
			this.LblDatProFeaturesDestinationPort_A20544.MouseDoubleClick += new global::System.Windows.Input.MouseButtonEventHandler(this.OnFieldNameDoubleClick);
			return;
			IL_2C1D:
			this.CpyBtnDataProfLabtoolDATA_PROFDataDeliveryMode_A11468 = (global::AcpUI.AcpCopyButton)target;
			return;
			IL_2C2A:
			this.RTDBtnDataConfigurationDataProfileTrunkingA25DataGroupIDListItemNameId_A36219 = (global::AcpUI.AcpRtdButton)target;
			return;
			IL_2C37:
			this.CVBtnDataProfFeaturesDirLocReg_A42332 = (global::AcpUI.AcpCustomViewCheckBox)target;
			return;
			IL_2C44:
			this.GrpBoxExpanderDataProfilesFeaturesDLR = (global::AcpUI.AcpGroupBox)target;
			return;
			IL_2C51:
			this.PriorityScanRxVoiceInterruptsData_A42590Comp = (global::AcpUI.AcpCheckBox)target;
			return;
			IL_2C5E:
			this.DataProfGeneralDataScanPreambleLength_A7798Comp = (global::AcpUI.AcpLabel)target;
			return;
			IL_2C6B:
			this.CpyBtnDatProFeaturesStartSequence_A20537 = (global::AcpUI.AcpCopyButton)target;
			return;
			IL_2C78:
			this.LblDataProfNLSAllowRxClrPackData_A36414 = (global::AcpUI.AcpLabel)target;
			this.LblDataProfNLSAllowRxClrPackData_A36414.MouseDoubleClick += new global::System.Windows.Input.MouseButtonEventHandler(this.OnFieldNameDoubleClick);
			return;
			IL_2C9C:
			this.GrpBoxExpanderDataProfilesFeaturesProtocolAssemblerDisassembler = (global::AcpUI.AcpGroupBox)target;
			return;
			IL_2CA9:
			this.CpyBtnDataProfilesGeneralBTDUNPeerIPAddressAssignmentType_A41128 = (global::AcpUI.AcpCopyButton)target;
			return;
			IL_2CB6:
			this.DataConfigurationDataProfileTrunkingA25DataGroupIDListItemNameId_A36219Comp = (global::AcpUI.AcpLabel)target;
			return;
			IL_2CC3:
			this.QueueDwellTimerSec_42015 = (global::AcpUI.AcpTextBoxSpinner)target;
			this.QueueDwellTimerSec_42015.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_2CE7:
			this.LblDataProfilesGeneralBTDUNPeerIPAddress_A41127 = (global::AcpUI.AcpLabel)target;
			this.LblDataProfilesGeneralBTDUNPeerIPAddress_A41127.MouseDoubleClick += new global::System.Windows.Input.MouseButtonEventHandler(this.OnFieldNameDoubleClick);
			return;
			IL_2D0B:
			this.gridExpanderDataProfilesTrunkingGroupIDListSRecView = (global::System.Windows.Controls.Grid)target;
			return;
			IL_2D18:
			this.DataProfFeaturesDirLocReg_A42332Comp = (global::AcpUI.AcpCheckBox)target;
			return;
			IL_2D25:
			this.DataProfilesGeneralBTDUNSUIPAddress_A41126Comp = (global::AcpUI.AcpLabel)target;
			return;
			IL_2D32:
			this.DataProfEIDByPassListAddrType_A36418 = (global::AcpUI.AcpComboBox)target;
			this.DataProfEIDByPassListAddrType_A36418.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_2D56:
			this.AllowEnhancedDataToBeSentOnClassicDataChannel_42014Comp = (global::AcpUI.AcpCheckBox)target;
			return;
			IL_2D63:
			this.CVBtnDataProfVPNMessageRetransmissionAttempts_A42210 = (global::AcpUI.AcpCustomViewCheckBox)target;
			return;
			IL_2D70:
			this.DataProfVPNDeadPeerDetectionInterval_A42211Comp = (global::AcpUI.AcpLabel)target;
			return;
			IL_2D7D:
			this.CVBtnDataProfGeneralDataProfileType_A21320 = (global::AcpUI.AcpCustomViewCheckBox)target;
			return;
			IL_2D8A:
			this.CVBtnDatProFeaturesMaximumBufferThreshold_A20542 = (global::AcpUI.AcpCustomViewCheckBox)target;
			return;
			IL_2D97:
			this.CVBtnDataProfLTEBackupPTTGatewayPort_A43618 = (global::AcpUI.AcpCustomViewCheckBox)target;
			return;
			IL_2DA4:
			this.ExpanderDataProfilesDAC = (global::AcpUI.AcpExpander)target;
			return;
			IL_2DB1:
			this.LblTrkSysLabtoolRxVoiceInterruptsData_A9043 = (global::AcpUI.AcpLabel)target;
			this.LblTrkSysLabtoolRxVoiceInterruptsData_A9043.MouseDoubleClick += new global::System.Windows.Input.MouseButtonEventHandler(this.OnFieldNameDoubleClick);
			return;
			IL_2DD5:
			this.CVBtnTrkSysLabtoolRetransmissionTimersec_A8672 = (global::AcpUI.AcpCustomViewCheckBox)target;
			return;
			IL_2DE2:
			this.RTDBtnDataProfFeaturesTerminalData_A9288 = (global::AcpUI.AcpRtdButton)target;
			return;
			IL_2DEF:
			this.RTDBtnQueueDwellTimerSec_42015 = (global::AcpUI.AcpRtdButton)target;
			return;
			IL_2DFC:
			this.LblDatProFeaturesEscapeSequence_A20539 = (global::AcpUI.AcpLabel)target;
			this.LblDatProFeaturesEscapeSequence_A20539.MouseDoubleClick += new global::System.Windows.Input.MouseButtonEventHandler(this.OnFieldNameDoubleClick);
			return;
			IL_2E20:
			this.CVBtnDataProfNLSKeySele_A36410 = (global::AcpUI.AcpCustomViewCheckBox)target;
			return;
			IL_2E2D:
			this.DatProSendDataDurEmerHangtime_A43103Comp = (global::AcpUI.AcpCheckBox)target;
			return;
			IL_2E3A:
			this.ExpanderDataProfilesEIDBypassListTable = (global::AcpUI.AcpXamDataPresenter)target;
			return;
			IL_2E47:
			this.LblDatProFeaturesReceiveIdleTimeOut_A20540 = (global::AcpUI.AcpLabel)target;
			this.LblDatProFeaturesReceiveIdleTimeOut_A20540.MouseDoubleClick += new global::System.Windows.Input.MouseButtonEventHandler(this.OnFieldNameDoubleClick);
			return;
			IL_2E6B:
			this.CpyBtnDataProfilesGeneralBTDUNSUIPAddress_A41126 = (global::AcpUI.AcpCopyButton)target;
			return;
			IL_2E78:
			this.RTDBtnDataProfEIDByPassListIPAddr_A36417 = (global::AcpUI.AcpRtdButton)target;
			return;
			IL_2E85:
			this.CVBtnDataProfLabtoolDATA_PROFDataDeliveryMode_A11468 = (global::AcpUI.AcpCustomViewCheckBox)target;
			return;
			IL_2E92:
			this.CpyBtnDataProfEIDByPassListAddrType_A36418 = (global::AcpUI.AcpCopyButton)target;
			return;
			IL_2E9F:
			this.CpyBtnDataProfFeaturesDirLocReg_A42332 = (global::AcpUI.AcpCopyButton)target;
			return;
			IL_2EAC:
			this.CVBtnDataProfGeneralAutoGenerateIPAddress_A19320 = (global::AcpUI.AcpCustomViewCheckBox)target;
			return;
			IL_2EB9:
			this.CpyBtnDataProfilesDACOperationalMode_A36199 = (global::AcpUI.AcpCopyButton)target;
			return;
			IL_2EC6:
			this.CVBtnDatProFeaturesDestinationAddress_A20543 = (global::AcpUI.AcpCustomViewCheckBox)target;
			return;
			IL_2ED3:
			this.DataProfNLSAllowRxClrPackData_A36414 = (global::AcpUI.AcpCheckBox)target;
			this.DataProfNLSAllowRxClrPackData_A36414.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_2EF7:
			this.LblDataProfLTEBackupPTTGatewayHostname_A43621 = (global::AcpUI.AcpLabel)target;
			this.LblDataProfLTEBackupPTTGatewayHostname_A43621.MouseDoubleClick += new global::System.Windows.Input.MouseButtonEventHandler(this.OnFieldNameDoubleClick);
			return;
			IL_2F1B:
			this.LblDataProfGeneralAutoGenerateTargetIPAddress_A41697 = (global::AcpUI.AcpLabel)target;
			this.LblDataProfGeneralAutoGenerateTargetIPAddress_A41697.MouseDoubleClick += new global::System.Windows.Input.MouseButtonEventHandler(this.OnFieldNameDoubleClick);
			return;
			IL_2F3F:
			this.LblDataProfFeaturesDirLocReg_A42332 = (global::AcpUI.AcpLabel)target;
			this.LblDataProfFeaturesDirLocReg_A42332.MouseDoubleClick += new global::System.Windows.Input.MouseButtonEventHandler(this.OnFieldNameDoubleClick);
			return;
			IL_2F63:
			this.CVBtnDataProfilesTrunkingGroupID_ASTRO25DataGroupID_A36204 = (global::AcpUI.AcpCustomViewCheckBox)target;
			return;
			IL_2F70:
			this.DataProfVPNRekeyAttempts_A42213Comp = (global::AcpUI.AcpLabel)target;
			return;
			IL_2F7D:
			this.RTDBtnDataProfGeneralMobileComputerIPAddress_A8523 = (global::AcpUI.AcpRtdButton)target;
			return;
			IL_2F8A:
			this.ExpanderDataProfilesFeatures = (global::AcpUI.AcpExpander)target;
			return;
			IL_2F97:
			this.PriorityScanRxVoiceInterruptsData_A42590 = (global::AcpUI.AcpCheckBox)target;
			this.PriorityScanRxVoiceInterruptsData_A42590.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_2FBB:
			this.DataProfGeneralPacketDataMode_A8689 = (global::AcpUI.AcpComboBox)target;
			this.DataProfGeneralPacketDataMode_A8689.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_2FDF:
			this.DataProfVPNSecClrStrp_A42120 = (global::AcpUI.AcpComboBox)target;
			this.DataProfVPNSecClrStrp_A42120.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_3003:
			this.CVBtnQueueDwellTimerSec_42015 = (global::AcpUI.AcpCustomViewCheckBox)target;
			return;
			IL_3010:
			this.LblDataProfNLSKeySele_A36410 = (global::AcpUI.AcpLabel)target;
			this.LblDataProfNLSKeySele_A36410.MouseDoubleClick += new global::System.Windows.Input.MouseButtonEventHandler(this.OnFieldNameDoubleClick);
			return;
			IL_3034:
			this.DataProfGeneralSubscriberAirInterfaceIPAddress_A9220Comp = (global::AcpUI.AcpLabel)target;
			return;
			IL_3041:
			this.LblDataWideGeneralPeerIPAddressAssignmentType_A22263 = (global::AcpUI.AcpLabel)target;
			this.LblDataWideGeneralPeerIPAddressAssignmentType_A22263.MouseDoubleClick += new global::System.Windows.Input.MouseButtonEventHandler(this.OnFieldNameDoubleClick);
			return;
			IL_3065:
			this.LblDataProfGeneralQueueDwellTimersec_A8806 = (global::AcpUI.AcpLabel)target;
			this.LblDataProfGeneralQueueDwellTimersec_A8806.MouseDoubleClick += new global::System.Windows.Input.MouseButtonEventHandler(this.OnFieldNameDoubleClick);
			return;
			IL_3089:
			this.DataProfEIDByPassListIPAddr_A36417 = (global::AcpUI.AcpTextBox)target;
			this.DataProfEIDByPassListIPAddr_A36417.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_30AD:
			this.MyStackPanel = (global::System.Windows.Controls.StackPanel)target;
			return;
			IL_30BA:
			this.LblDatProFeaturesDestinationAddress_A20543 = (global::AcpUI.AcpLabel)target;
			this.LblDatProFeaturesDestinationAddress_A20543.MouseDoubleClick += new global::System.Windows.Input.MouseButtonEventHandler(this.OnFieldNameDoubleClick);
			return;
			IL_30DE:
			this.LblDataProfNLSSecClrStrp_A36415 = (global::AcpUI.AcpLabel)target;
			this.LblDataProfNLSSecClrStrp_A36415.MouseDoubleClick += new global::System.Windows.Input.MouseButtonEventHandler(this.OnFieldNameDoubleClick);
			return;
			IL_3102:
			this.CpyBtnDataConigurationDataProfilePacketDataRegistrationVersion_A36210 = (global::AcpUI.AcpCopyButton)target;
			return;
			IL_310F:
			this.HLinkFeatures = (global::System.Windows.Documents.Hyperlink)target;
			this.HLinkFeatures.Click += this.HLinkClick;
			return;
			IL_3133:
			this.LblDataProfEIDByPassListAddrType_A36418 = (global::AcpUI.AcpLabel)target;
			this.LblDataProfEIDByPassListAddrType_A36418.MouseDoubleClick += new global::System.Windows.Input.MouseButtonEventHandler(this.OnFieldNameDoubleClick);
			return;
			IL_3157:
			this.LblDataProfGeneralAutoGenerateIPAddress_A19320 = (global::AcpUI.AcpLabel)target;
			this.LblDataProfGeneralAutoGenerateIPAddress_A19320.MouseDoubleClick += new global::System.Windows.Input.MouseButtonEventHandler(this.OnFieldNameDoubleClick);
			return;
			IL_317B:
			this.HLinkTrunkingGroupID = (global::System.Windows.Documents.Hyperlink)target;
			this.HLinkTrunkingGroupID.Click += this.HLinkClick;
			return;
			IL_319F:
			this.LblDataProfilesGeneralBTDUNSUIPAddress_A41126 = (global::AcpUI.AcpLabel)target;
			this.LblDataProfilesGeneralBTDUNSUIPAddress_A41126.MouseDoubleClick += new global::System.Windows.Input.MouseButtonEventHandler(this.OnFieldNameDoubleClick);
			return;
			IL_31C3:
			this.DataProfEIDByPassListAddrType_A36418Comp = (global::AcpUI.AcpLabel)target;
			return;
			IL_31D0:
			this.CVBtnDataProfFeaturesARSMode_A7465 = (global::AcpUI.AcpCustomViewCheckBox)target;
			return;
			IL_31DD:
			this.HLinkGeneral = (global::System.Windows.Documents.Hyperlink)target;
			this.HLinkGeneral.Click += this.HLinkClick;
			return;
			IL_3201:
			this.CpyBtnDataProfFeaturesTerminalData_A9288 = (global::AcpUI.AcpCopyButton)target;
			return;
			IL_320E:
			this.b = true;
		}

		// Token: 0x0600AA79 RID: 43641 RVA: 0x009EF518 File Offset: 0x009ED718
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		[global::System.Diagnostics.DebuggerNonUserCode]
		[global::System.CodeDom.Compiler.GeneratedCode("PresentationBuildTasks", "5.0.10.0")]
		void global::System.Windows.Markup.IStyleConnector.Connect(int connectionId, object target)
		{
			switch (connectionId)
			{
			case 3:
			{
				short num = (short)2080178177;
				if (num != 0)
				{
				}
				((global::AcpUI.AcpTableComboBox)target).GotFocus += this.OnFieldNameDoubleClick;
				return;
			}
			case 4:
				((global::AcpUI.AcpTableComboBox)target).GotFocus += this.OnFieldNameDoubleClick;
				return;
			case 5:
				((global::AcpUI.AcpTableTextBoxSpinnerDecHex)target).GotFocus += this.OnFieldNameDoubleClick;
				return;
			case 6:
				((global::AcpUI.AcpTableTextBox)target).GotFocus += this.OnFieldNameDoubleClick;
				return;
			case 7:
				((global::AcpUI.AcpTableComboBox)target).GotFocus += this.OnFieldNameDoubleClick;
				return;
			default:
			{
				short num;
				for (;;)
				{
					num = (short)67709743;
					short num2 = num;
					num = (short)1590307631;
					switch ((num2 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						break;
					default:
						goto IL_84;
					}
				}
				IL_84:
				num = (short)681312256;
				if (num != 0)
				{
				}
				num = (short)242221056;
				short num3 = num;
				return;
			}
			}
		}

		// Token: 0x04005156 RID: 20822
		private bool a;

		// Token: 0x04005157 RID: 20823
		internal global::AcpUI.AcpParentRecNavToolbar RecNavToolbarPageDataProfiles;

		// Token: 0x04005158 RID: 20824
		internal global::AcpUI.Common.AcpThemeBase ThemeBaseObj;

		// Token: 0x04005159 RID: 20825
		internal global::System.Windows.Documents.Hyperlink HLinkGeneral;

		// Token: 0x0400515A RID: 20826
		internal global::System.Windows.Documents.Hyperlink HLinkFeatures;

		// Token: 0x0400515B RID: 20827
		internal global::System.Windows.Documents.Hyperlink HLinkDAC;

		// Token: 0x0400515C RID: 20828
		internal global::System.Windows.Documents.Hyperlink HLinkTrunkingGroupID;

		// Token: 0x0400515D RID: 20829
		internal global::System.Windows.Documents.Hyperlink HLinkLTE;

		// Token: 0x0400515E RID: 20830
		internal global::System.Windows.Documents.Hyperlink HLinkNetworkLayerSecurity;

		// Token: 0x0400515F RID: 20831
		internal global::System.Windows.Documents.Hyperlink HLinkEIDBypassList;

		// Token: 0x04005160 RID: 20832
		internal global::System.Windows.Documents.Hyperlink HLinkEnhancedData;

		// Token: 0x04005161 RID: 20833
		internal global::System.Windows.Documents.Hyperlink HLinkLabtoolDATA_PROF;

		// Token: 0x04005162 RID: 20834
		internal global::System.Windows.Controls.StackPanel MyStackPanel;

		// Token: 0x04005163 RID: 20835
		internal global::AcpUI.AcpExpander ExpanderDataProfilesGeneral;

		// Token: 0x04005164 RID: 20836
		internal global::AcpUI.AcpGroupBox GrpBoxExpanderDataProfilesGeneralPseudo0;

		// Token: 0x04005165 RID: 20837
		internal global::AcpUI.AcpCustomViewCheckBox CVBtnDataProfGeneralkeyofDataProfiles_A19446;

		// Token: 0x04005166 RID: 20838
		internal global::AcpUI.AcpLabel LblDataProfGeneralkeyofDataProfiles_A19446;

		// Token: 0x04005167 RID: 20839
		internal global::AcpUI.AcpTextBox DataProfGeneralkeyofDataProfiles_A19446;

		// Token: 0x04005168 RID: 20840
		internal global::AcpUI.AcpCopyButton CpyBtnDataProfGeneralkeyofDataProfiles_A19446;

		// Token: 0x04005169 RID: 20841
		internal global::AcpUI.AcpLabel DataProfGeneralkeyofDataProfiles_A19446Comp;

		// Token: 0x0400516A RID: 20842
		internal global::AcpUI.AcpCustomViewCheckBox CVBtnDataProfGeneralDataProfileType_A21320;

		// Token: 0x0400516B RID: 20843
		internal global::AcpUI.AcpLabel LblDataProfGeneralDataProfileType_A21320;

		// Token: 0x0400516C RID: 20844
		internal global::AcpUI.AcpComboBox DataProfGeneralDataProfileType_A21320;

		// Token: 0x0400516D RID: 20845
		internal global::AcpUI.AcpRtdButton RTDBtnDataProfGeneralDataProfileType_A21320;

		// Token: 0x0400516E RID: 20846
		internal global::AcpUI.AcpCopyButton CpyBtnDataProfGeneralDataProfileType_A21320;

		// Token: 0x0400516F RID: 20847
		internal global::AcpUI.AcpLabel DataProfGeneralDataProfileType_A21320Comp;

		// Token: 0x04005170 RID: 20848
		internal global::AcpUI.AcpCustomViewCheckBox CVBtnDataProfGeneralPacketDataMode_A8689;

		// Token: 0x04005171 RID: 20849
		internal global::AcpUI.AcpLabel LblDataProfGeneralPacketDataMode_A8689;

		// Token: 0x04005172 RID: 20850
		internal global::AcpUI.AcpComboBox DataProfGeneralPacketDataMode_A8689;

		// Token: 0x04005173 RID: 20851
		internal global::AcpUI.AcpRtdButton RTDBtnDataProfGeneralPacketDataMode_A8689;

		// Token: 0x04005174 RID: 20852
		internal global::AcpUI.AcpCopyButton CpyBtnDataProfGeneralPacketDataMode_A8689;

		// Token: 0x04005175 RID: 20853
		internal global::AcpUI.AcpLabel DataProfGeneralPacketDataMode_A8689Comp;

		// Token: 0x04005176 RID: 20854
		internal global::AcpUI.AcpCustomViewCheckBox CVBtnDataProfGeneralQueueDwellTimersec_A8806;

		// Token: 0x04005177 RID: 20855
		internal global::AcpUI.AcpLabel LblDataProfGeneralQueueDwellTimersec_A8806;

		// Token: 0x04005178 RID: 20856
		internal global::AcpUI.AcpTextBoxSpinner DataProfGeneralQueueDwellTimersec_A8806;

		// Token: 0x04005179 RID: 20857
		internal global::AcpUI.AcpRtdButton RTDBtnDataProfGeneralQueueDwellTimersec_A8806;

		// Token: 0x0400517A RID: 20858
		internal global::AcpUI.AcpCopyButton CpyBtnDataProfGeneralQueueDwellTimersec_A8806;

		// Token: 0x0400517B RID: 20859
		internal global::AcpUI.AcpLabel DataProfGeneralQueueDwellTimersec_A8806Comp;

		// Token: 0x0400517C RID: 20860
		internal global::AcpUI.AcpCustomViewCheckBox CVBtnDataProfGeneralDataScanPreambleLength_A7798;

		// Token: 0x0400517D RID: 20861
		internal global::AcpUI.AcpLabel LblDataProfGeneralDataScanPreambleLength_A7798;

		// Token: 0x0400517E RID: 20862
		internal global::AcpUI.AcpTextBoxSpinner DataProfGeneralDataScanPreambleLength_A7798;

		// Token: 0x0400517F RID: 20863
		internal global::AcpUI.AcpRtdButton RTDBtnDataProfGeneralDataScanPreambleLength_A7798;

		// Token: 0x04005180 RID: 20864
		internal global::AcpUI.AcpCopyButton CpyBtnDataProfGeneralDataScanPreambleLength_A7798;

		// Token: 0x04005181 RID: 20865
		internal global::AcpUI.AcpLabel DataProfGeneralDataScanPreambleLength_A7798Comp;

		// Token: 0x04005182 RID: 20866
		internal global::AcpUI.AcpCustomViewCheckBox CVBtnTrkSysLabtoolRxVoiceInterruptsData_A9043;

		// Token: 0x04005183 RID: 20867
		internal global::AcpUI.AcpLabel LblTrkSysLabtoolRxVoiceInterruptsData_A9043;

		// Token: 0x04005184 RID: 20868
		internal global::AcpUI.AcpCheckBox TrkSysLabtoolRxVoiceInterruptsData_A9043;

		// Token: 0x04005185 RID: 20869
		internal global::AcpUI.AcpRtdButton RTDBtnTrkSysLabtoolRxVoiceInterruptsData_A9043;

		// Token: 0x04005186 RID: 20870
		internal global::AcpUI.AcpCopyButton CpyBtnTrkSysLabtoolRxVoiceInterruptsData_A9043;

		// Token: 0x04005187 RID: 20871
		internal global::AcpUI.AcpCheckBox TrkSysLabtoolRxVoiceInterruptsData_A9043Comp;

		// Token: 0x04005188 RID: 20872
		internal global::AcpUI.AcpCustomViewCheckBox CVBtnPriorityScanRxVoiceInterruptsData_A42590;

		// Token: 0x04005189 RID: 20873
		internal global::AcpUI.AcpLabel LblPriorityScanRxVoiceInterruptsData_A42590;

		// Token: 0x0400518A RID: 20874
		internal global::AcpUI.AcpCheckBox PriorityScanRxVoiceInterruptsData_A42590;

		// Token: 0x0400518B RID: 20875
		internal global::AcpUI.AcpRtdButton RTDBtnPriorityScanRxVoiceInterruptsData_A42590;

		// Token: 0x0400518C RID: 20876
		internal global::AcpUI.AcpCopyButton CpyBtnPriorityScanRxVoiceInterruptsData_A42590;

		// Token: 0x0400518D RID: 20877
		internal global::AcpUI.AcpCheckBox PriorityScanRxVoiceInterruptsData_A42590Comp;

		// Token: 0x0400518E RID: 20878
		internal global::AcpUI.AcpCustomViewCheckBox CVBtnDataProfGeneralLimitedBroadcast_A8431;

		// Token: 0x0400518F RID: 20879
		internal global::AcpUI.AcpLabel LblDataProfGeneralLimitedBroadcast_A8431;

		// Token: 0x04005190 RID: 20880
		internal global::AcpUI.AcpCheckBox DataProfGeneralLimitedBroadcast_A8431;

		// Token: 0x04005191 RID: 20881
		internal global::AcpUI.AcpRtdButton RTDBtnDataProfGeneralLimitedBroadcast_A8431;

		// Token: 0x04005192 RID: 20882
		internal global::AcpUI.AcpCopyButton CpyBtnDataProfGeneralLimitedBroadcast_A8431;

		// Token: 0x04005193 RID: 20883
		internal global::AcpUI.AcpCheckBox DataProfGeneralLimitedBroadcast_A8431Comp;

		// Token: 0x04005194 RID: 20884
		internal global::AcpUI.AcpCustomViewCheckBox CVBtnDataProfGeneralAutoGenerateIPAddress_A19320;

		// Token: 0x04005195 RID: 20885
		internal global::AcpUI.AcpLabel LblDataProfGeneralAutoGenerateIPAddress_A19320;

		// Token: 0x04005196 RID: 20886
		internal global::AcpUI.AcpCheckBox DataProfGeneralAutoGenerateIPAddress_A19320;

		// Token: 0x04005197 RID: 20887
		internal global::AcpUI.AcpRtdButton RTDBtnDataProfGeneralAutoGenerateIPAddress_A19320;

		// Token: 0x04005198 RID: 20888
		internal global::AcpUI.AcpCopyButton CpyBtnDataProfGeneralAutoGenerateIPAddress_A19320;

		// Token: 0x04005199 RID: 20889
		internal global::AcpUI.AcpCheckBox DataProfGeneralAutoGenerateIPAddress_A19320Comp;

		// Token: 0x0400519A RID: 20890
		internal global::AcpUI.AcpCustomViewCheckBox CVBtnDataWideGeneralNATEnable_A38866;

		// Token: 0x0400519B RID: 20891
		internal global::AcpUI.AcpLabel LblDataWideGeneralNATEnable_A38866;

		// Token: 0x0400519C RID: 20892
		internal global::AcpUI.AcpCheckBox DataWideGeneralNATEnable_A38866;

		// Token: 0x0400519D RID: 20893
		internal global::AcpUI.AcpRtdButton RTDBtnDataWideGeneralNATEnable_A38866;

		// Token: 0x0400519E RID: 20894
		internal global::AcpUI.AcpCopyButton CpyBtnDataWideGeneralNATEnable_A38866;

		// Token: 0x0400519F RID: 20895
		internal global::AcpUI.AcpCheckBox DataWideGeneralNATEnable_A38866Comp;

		// Token: 0x040051A0 RID: 20896
		internal global::AcpUI.AcpCustomViewCheckBox CVBtnDataProfGeneralAutoGenerateTargetIPAddress_A41697;

		// Token: 0x040051A1 RID: 20897
		internal global::AcpUI.AcpLabel LblDataProfGeneralAutoGenerateTargetIPAddress_A41697;

		// Token: 0x040051A2 RID: 20898
		internal global::AcpUI.AcpCheckBox DataProfGeneralAutoGenerateTargetIPAddress_A41697;

		// Token: 0x040051A3 RID: 20899
		internal global::AcpUI.AcpRtdButton RTDBtnDataProfGeneralAutoGenerateTargetIPAddress_A41697;

		// Token: 0x040051A4 RID: 20900
		internal global::AcpUI.AcpCopyButton CpyBtnDataProfGeneralAutoGenerateTargetIPAddress_A41697;

		// Token: 0x040051A5 RID: 20901
		internal global::AcpUI.AcpCheckBox DataProfGeneralAutoGenerateTargetIPAddress_A41697Comp;

		// Token: 0x040051A6 RID: 20902
		internal global::AcpUI.AcpGroupBox GrpBoxExpanderDataProfilesGeneralSerialLink1Addresses;

		// Token: 0x040051A7 RID: 20903
		internal global::AcpUI.AcpCustomViewCheckBox CVBtnDataProfGeneralSubscriberIPAddress_A21157;

		// Token: 0x040051A8 RID: 20904
		internal global::AcpUI.AcpLabel LblDataProfGeneralSubscriberIPAddress_A21157;

		// Token: 0x040051A9 RID: 20905
		internal global::AcpUI.AcpTextBox DataProfGeneralSubscriberIPAddress_A21157;

		// Token: 0x040051AA RID: 20906
		internal global::AcpUI.AcpRtdButton RTDBtnDataProfGeneralSubscriberIPAddress_A21157;

		// Token: 0x040051AB RID: 20907
		internal global::AcpUI.AcpCopyButton CpyBtnDataProfGeneralSubscriberIPAddress_A21157;

		// Token: 0x040051AC RID: 20908
		internal global::AcpUI.AcpLabel DataProfGeneralSubscriberIPAddress_A21157Comp;

		// Token: 0x040051AD RID: 20909
		internal global::AcpUI.AcpCustomViewCheckBox CVBtnDataProfGeneralMobileComputerIPAddress_A8523;

		// Token: 0x040051AE RID: 20910
		internal global::AcpUI.AcpLabel LblDataProfGeneralMobileComputerIPAddress_A8523;

		// Token: 0x040051AF RID: 20911
		internal global::AcpUI.AcpTextBox DataProfGeneralMobileComputerIPAddress_A8523;

		// Token: 0x040051B0 RID: 20912
		internal global::AcpUI.AcpRtdButton RTDBtnDataProfGeneralMobileComputerIPAddress_A8523;

		// Token: 0x040051B1 RID: 20913
		internal global::AcpUI.AcpCopyButton CpyBtnDataProfGeneralMobileComputerIPAddress_A8523;

		// Token: 0x040051B2 RID: 20914
		internal global::AcpUI.AcpLabel DataProfGeneralMobileComputerIPAddress_A8523Comp;

		// Token: 0x040051B3 RID: 20915
		internal global::AcpUI.AcpCustomViewCheckBox CVBtnDataWideGeneralPeerIPAddressAssignmentType_A22263;

		// Token: 0x040051B4 RID: 20916
		internal global::AcpUI.AcpLabel LblDataWideGeneralPeerIPAddressAssignmentType_A22263;

		// Token: 0x040051B5 RID: 20917
		internal global::AcpUI.AcpComboBox DataWideGeneralPeerIPAddressAssignmentType_A22263;

		// Token: 0x040051B6 RID: 20918
		internal global::AcpUI.AcpRtdButton RTDBtnDataWideGeneralPeerIPAddressAssignmentType_A22263;

		// Token: 0x040051B7 RID: 20919
		internal global::AcpUI.AcpCopyButton CpyBtnDataWideGeneralPeerIPAddressAssignmentType_A22263;

		// Token: 0x040051B8 RID: 20920
		internal global::AcpUI.AcpLabel DataWideGeneralPeerIPAddressAssignmentType_A22263Comp;

		// Token: 0x040051B9 RID: 20921
		internal global::AcpUI.AcpGroupBox GrpBoxExpanderDataProfilesGeneralBluetoothDialUpNetworkingAddresses;

		// Token: 0x040051BA RID: 20922
		internal global::AcpUI.AcpCustomViewCheckBox CVBtnDataProfilesGeneralBTDUNSUIPAddress_A41126;

		// Token: 0x040051BB RID: 20923
		internal global::AcpUI.AcpLabel LblDataProfilesGeneralBTDUNSUIPAddress_A41126;

		// Token: 0x040051BC RID: 20924
		internal global::AcpUI.AcpTextBox DataProfilesGeneralBTDUNSUIPAddress_A41126;

		// Token: 0x040051BD RID: 20925
		internal global::AcpUI.AcpRtdButton RTDBtnDataProfilesGeneralBTDUNSUIPAddress_A41126;

		// Token: 0x040051BE RID: 20926
		internal global::AcpUI.AcpCopyButton CpyBtnDataProfilesGeneralBTDUNSUIPAddress_A41126;

		// Token: 0x040051BF RID: 20927
		internal global::AcpUI.AcpLabel DataProfilesGeneralBTDUNSUIPAddress_A41126Comp;

		// Token: 0x040051C0 RID: 20928
		internal global::AcpUI.AcpCustomViewCheckBox CVBtnDataProfilesGeneralBTDUNPeerIPAddress_A41127;

		// Token: 0x040051C1 RID: 20929
		internal global::AcpUI.AcpLabel LblDataProfilesGeneralBTDUNPeerIPAddress_A41127;

		// Token: 0x040051C2 RID: 20930
		internal global::AcpUI.AcpTextBox DataProfilesGeneralBTDUNPeerIPAddress_A41127;

		// Token: 0x040051C3 RID: 20931
		internal global::AcpUI.AcpRtdButton RTDBtnDataProfilesGeneralBTDUNPeerIPAddress_A41127;

		// Token: 0x040051C4 RID: 20932
		internal global::AcpUI.AcpCopyButton CpyBtnDataProfilesGeneralBTDUNPeerIPAddress_A41127;

		// Token: 0x040051C5 RID: 20933
		internal global::AcpUI.AcpLabel DataProfilesGeneralBTDUNPeerIPAddress_A41127Comp;

		// Token: 0x040051C6 RID: 20934
		internal global::AcpUI.AcpCustomViewCheckBox CVBtnDataProfilesGeneralBTDUNPeerIPAddressAssignmentType_A41128;

		// Token: 0x040051C7 RID: 20935
		internal global::AcpUI.AcpLabel LblDataProfilesGeneralBTDUNPeerIPAddressAssignmentType_A41128;

		// Token: 0x040051C8 RID: 20936
		internal global::AcpUI.AcpComboBox DataProfilesGeneralBTDUNPeerIPAddressAssignmentType_A41128;

		// Token: 0x040051C9 RID: 20937
		internal global::AcpUI.AcpRtdButton RTDBtnDataProfilesGeneralBTDUNPeerIPAddressAssignmentType_A41128;

		// Token: 0x040051CA RID: 20938
		internal global::AcpUI.AcpCopyButton CpyBtnDataProfilesGeneralBTDUNPeerIPAddressAssignmentType_A41128;

		// Token: 0x040051CB RID: 20939
		internal global::AcpUI.AcpLabel DataProfilesGeneralBTDUNPeerIPAddressAssignmentType_A41128Comp;

		// Token: 0x040051CC RID: 20940
		internal global::AcpUI.AcpGroupBox GrpBoxExpanderDataProfilesGeneralPseudo2;

		// Token: 0x040051CD RID: 20941
		internal global::AcpUI.AcpCustomViewCheckBox CVBtnDataProfGeneralSubscriberAirInterfaceIPAddress_A9220;

		// Token: 0x040051CE RID: 20942
		internal global::AcpUI.AcpLabel LblDataProfGeneralSubscriberAirInterfaceIPAddress_A9220;

		// Token: 0x040051CF RID: 20943
		internal global::AcpUI.AcpTextBox DataProfGeneralSubscriberAirInterfaceIPAddress_A9220;

		// Token: 0x040051D0 RID: 20944
		internal global::AcpUI.AcpRtdButton RTDBtnDataProfGeneralSubscriberAirInterfaceIPAddress_A9220;

		// Token: 0x040051D1 RID: 20945
		internal global::AcpUI.AcpCopyButton CpyBtnDataProfGeneralSubscriberAirInterfaceIPAddress_A9220;

		// Token: 0x040051D2 RID: 20946
		internal global::AcpUI.AcpLabel DataProfGeneralSubscriberAirInterfaceIPAddress_A9220Comp;

		// Token: 0x040051D3 RID: 20947
		internal global::AcpUI.AcpGroupBox GrpBoxExpanderDataProfilesGeneralRegistration;

		// Token: 0x040051D4 RID: 20948
		internal global::AcpUI.AcpCustomViewCheckBox CVBtnDataConfigDataProfIntersystemData_A42381;

		// Token: 0x040051D5 RID: 20949
		internal global::AcpUI.AcpLabel LblDataConfigDataProfIntersystemData_A42381;

		// Token: 0x040051D6 RID: 20950
		internal global::AcpUI.AcpCheckBox DataConfigDataProfIntersystemData_A42381;

		// Token: 0x040051D7 RID: 20951
		internal global::AcpUI.AcpRtdButton RTDBtnDataConfigDataProfIntersystemData_A42381;

		// Token: 0x040051D8 RID: 20952
		internal global::AcpUI.AcpCopyButton CpyBtnDataConfigDataProfIntersystemData_A42381;

		// Token: 0x040051D9 RID: 20953
		internal global::AcpUI.AcpCheckBox DataConfigDataProfIntersystemData_A42381Comp;

		// Token: 0x040051DA RID: 20954
		internal global::AcpUI.AcpCustomViewCheckBox CVBtnDataConfigDataProfRandomHoldOffTime_A36552;

		// Token: 0x040051DB RID: 20955
		internal global::AcpUI.AcpLabel LblDataConfigDataProfRandomHoldOffTime_A36552;

		// Token: 0x040051DC RID: 20956
		internal global::AcpUI.AcpCheckBox DataConfigDataProfRandomHoldOffTime_A36552;

		// Token: 0x040051DD RID: 20957
		internal global::AcpUI.AcpRtdButton RTDBtnDataConfigDataProfRandomHoldOffTime_A36552;

		// Token: 0x040051DE RID: 20958
		internal global::AcpUI.AcpCopyButton CpyBtnDataConfigDataProfRandomHoldOffTime_A36552;

		// Token: 0x040051DF RID: 20959
		internal global::AcpUI.AcpCheckBox DataConfigDataProfRandomHoldOffTime_A36552Comp;

		// Token: 0x040051E0 RID: 20960
		internal global::AcpUI.AcpCustomViewCheckBox CVBtnDataConfigDataProfContextActivationHoldoffTime_A36551;

		// Token: 0x040051E1 RID: 20961
		internal global::AcpUI.AcpLabel LblDataConfigDataProfContextActivationHoldoffTime_A36551;

		// Token: 0x040051E2 RID: 20962
		internal global::AcpUI.AcpTextBoxSpinner DataConfigDataProfContextActivationHoldoffTime_A36551;

		// Token: 0x040051E3 RID: 20963
		internal global::AcpUI.AcpRtdButton RTDBtnDataConfigDataProfContextActivationHoldoffTime_A36551;

		// Token: 0x040051E4 RID: 20964
		internal global::AcpUI.AcpCopyButton CpyBtnDataConfigDataProfContextActivationHoldoffTime_A36551;

		// Token: 0x040051E5 RID: 20965
		internal global::AcpUI.AcpLabel DataConfigDataProfContextActivationHoldoffTime_A36551Comp;

		// Token: 0x040051E6 RID: 20966
		internal global::AcpUI.AcpCustomViewCheckBox CVBtnDataConigurationDataProfilePacketDataRegistrationVersion_A36210;

		// Token: 0x040051E7 RID: 20967
		internal global::AcpUI.AcpLabel LblDataConigurationDataProfilePacketDataRegistrationVersion_A36210;

		// Token: 0x040051E8 RID: 20968
		internal global::AcpUI.AcpComboBox DataConigurationDataProfilePacketDataRegistrationVersion_A36210;

		// Token: 0x040051E9 RID: 20969
		internal global::AcpUI.AcpRtdButton RTDBtnDataConigurationDataProfilePacketDataRegistrationVersion_A36210;

		// Token: 0x040051EA RID: 20970
		internal global::AcpUI.AcpCopyButton CpyBtnDataConigurationDataProfilePacketDataRegistrationVersion_A36210;

		// Token: 0x040051EB RID: 20971
		internal global::AcpUI.AcpLabel DataConigurationDataProfilePacketDataRegistrationVersion_A36210Comp;

		// Token: 0x040051EC RID: 20972
		internal global::AcpUI.AcpGroupBox GrpBoxExpanderDataProfilesGeneralPseudo3;

		// Token: 0x040051ED RID: 20973
		internal global::AcpUI.AcpCustomViewCheckBox CVBtnDataConfigDataProfIPHeaderCompressionEnable_A36190;

		// Token: 0x040051EE RID: 20974
		internal global::AcpUI.AcpLabel LblDataConfigDataProfIPHeaderCompressionEnable_A36190;

		// Token: 0x040051EF RID: 20975
		internal global::AcpUI.AcpCheckBox DataConfigDataProfIPHeaderCompressionEnable_A36190;

		// Token: 0x040051F0 RID: 20976
		internal global::AcpUI.AcpRtdButton RTDBtnDataConfigDataProfIPHeaderCompressionEnable_A36190;

		// Token: 0x040051F1 RID: 20977
		internal global::AcpUI.AcpCopyButton CpyBtnDataConfigDataProfIPHeaderCompressionEnable_A36190;

		// Token: 0x040051F2 RID: 20978
		internal global::AcpUI.AcpCheckBox DataConfigDataProfIPHeaderCompressionEnable_A36190Comp;

		// Token: 0x040051F3 RID: 20979
		internal global::AcpUI.AcpExpander ExpanderDataProfilesFeatures;

		// Token: 0x040051F4 RID: 20980
		internal global::AcpUI.AcpGroupBox GrpBoxExpanderDataProfilesFeaturesPseudo0;

		// Token: 0x040051F5 RID: 20981
		internal global::AcpUI.AcpCustomViewCheckBox CVBtnDataProfFeaturesTerminalData_A9288;

		// Token: 0x040051F6 RID: 20982
		internal global::AcpUI.AcpLabel LblDataProfFeaturesTerminalData_A9288;

		// Token: 0x040051F7 RID: 20983
		internal global::AcpUI.AcpCheckBox DataProfFeaturesTerminalData_A9288;

		// Token: 0x040051F8 RID: 20984
		internal global::AcpUI.AcpRtdButton RTDBtnDataProfFeaturesTerminalData_A9288;

		// Token: 0x040051F9 RID: 20985
		internal global::AcpUI.AcpCopyButton CpyBtnDataProfFeaturesTerminalData_A9288;

		// Token: 0x040051FA RID: 20986
		internal global::AcpUI.AcpCheckBox DataProfFeaturesTerminalData_A9288Comp;

		// Token: 0x040051FB RID: 20987
		internal global::AcpUI.AcpCustomViewCheckBox CVBtnTrkSysLabtoolRetransmissionTimersec_A8672;

		// Token: 0x040051FC RID: 20988
		internal global::AcpUI.AcpLabel LblTrkSysLabtoolRetransmissionTimersec_A8672;

		// Token: 0x040051FD RID: 20989
		internal global::AcpUI.AcpTextBoxSpinner TrkSysLabtoolRetransmissionTimersec_A8672;

		// Token: 0x040051FE RID: 20990
		internal global::AcpUI.AcpRtdButton RTDBtnTrkSysLabtoolRetransmissionTimersec_A8672;

		// Token: 0x040051FF RID: 20991
		internal global::AcpUI.AcpCopyButton CpyBtnTrkSysLabtoolRetransmissionTimersec_A8672;

		// Token: 0x04005200 RID: 20992
		internal global::AcpUI.AcpLabel TrkSysLabtoolRetransmissionTimersec_A8672Comp;

		// Token: 0x04005201 RID: 20993
		internal global::AcpUI.AcpCustomViewCheckBox CVBtnDataProfFeatureContxActivHldoffMode_A36469;

		// Token: 0x04005202 RID: 20994
		internal global::AcpUI.AcpLabel LblDataProfFeatureContxActivHldoffMode_A36469;

		// Token: 0x04005203 RID: 20995
		internal global::AcpUI.AcpComboBox DataProfFeatureContxActivHldoffMode_A36469;

		// Token: 0x04005204 RID: 20996
		internal global::AcpUI.AcpRtdButton RTDBtnDataProfFeatureContxActivHldoffMode_A36469;

		// Token: 0x04005205 RID: 20997
		internal global::AcpUI.AcpCopyButton CpyBtnDataProfFeatureContxActivHldoffMode_A36469;

		// Token: 0x04005206 RID: 20998
		internal global::AcpUI.AcpLabel DataProfFeatureContxActivHldoffMode_A36469Comp;

		// Token: 0x04005207 RID: 20999
		internal global::AcpUI.AcpGroupBox GrpBoxExpanderDataProfilesFeaturesRetryTimers;

		// Token: 0x04005208 RID: 21000
		internal global::AcpUI.AcpCustomViewCheckBox CVBtnDataProfFeaturesARSRetryTimermin_A7466;

		// Token: 0x04005209 RID: 21001
		internal global::AcpUI.AcpLabel LblDataProfFeaturesARSRetryTimermin_A7466;

		// Token: 0x0400520A RID: 21002
		internal global::AcpUI.AcpTextBoxSpinner DataProfFeaturesARSRetryTimermin_A7466;

		// Token: 0x0400520B RID: 21003
		internal global::AcpUI.AcpRtdButton RTDBtnDataProfFeaturesARSRetryTimermin_A7466;

		// Token: 0x0400520C RID: 21004
		internal global::AcpUI.AcpCopyButton CpyBtnDataProfFeaturesARSRetryTimermin_A7466;

		// Token: 0x0400520D RID: 21005
		internal global::AcpUI.AcpLabel DataProfFeaturesARSRetryTimermin_A7466Comp;

		// Token: 0x0400520E RID: 21006
		internal global::AcpUI.AcpCustomViewCheckBox CVBtnDataProfFeaturesApplicationTimeBetweenAttemptssec_A7460;

		// Token: 0x0400520F RID: 21007
		internal global::AcpUI.AcpLabel LblDataProfFeaturesApplicationTimeBetweenAttemptssec_A7460;

		// Token: 0x04005210 RID: 21008
		internal global::AcpUI.AcpTextBoxSpinner DataProfFeaturesApplicationTimeBetweenAttemptssec_A7460;

		// Token: 0x04005211 RID: 21009
		internal global::AcpUI.AcpRtdButton RTDBtnDataProfFeaturesApplicationTimeBetweenAttemptssec_A7460;

		// Token: 0x04005212 RID: 21010
		internal global::AcpUI.AcpCopyButton CpyBtnDataProfFeaturesApplicationTimeBetweenAttemptssec_A7460;

		// Token: 0x04005213 RID: 21011
		internal global::AcpUI.AcpLabel DataProfFeaturesApplicationTimeBetweenAttemptssec_A7460Comp;

		// Token: 0x04005214 RID: 21012
		internal global::AcpUI.AcpCustomViewCheckBox CVBtnDataProfFeaturesApplicationNumberofAttempts_A7458;

		// Token: 0x04005215 RID: 21013
		internal global::AcpUI.AcpLabel LblDataProfFeaturesApplicationNumberofAttempts_A7458;

		// Token: 0x04005216 RID: 21014
		internal global::AcpUI.AcpTextBoxSpinner DataProfFeaturesApplicationNumberofAttempts_A7458;

		// Token: 0x04005217 RID: 21015
		internal global::AcpUI.AcpRtdButton RTDBtnDataProfFeaturesApplicationNumberofAttempts_A7458;

		// Token: 0x04005218 RID: 21016
		internal global::AcpUI.AcpCopyButton CpyBtnDataProfFeaturesApplicationNumberofAttempts_A7458;

		// Token: 0x04005219 RID: 21017
		internal global::AcpUI.AcpLabel DataProfFeaturesApplicationNumberofAttempts_A7458Comp;

		// Token: 0x0400521A RID: 21018
		internal global::AcpUI.AcpGroupBox GrpBoxExpanderDataProfilesFeaturesARS;

		// Token: 0x0400521B RID: 21019
		internal global::AcpUI.AcpCustomViewCheckBox CVBtnDataProfFeaturesARSMode_A7465;

		// Token: 0x0400521C RID: 21020
		internal global::AcpUI.AcpLabel LblDataProfFeaturesARSMode_A7465;

		// Token: 0x0400521D RID: 21021
		internal global::AcpUI.AcpComboBox DataProfFeaturesARSMode_A7465;

		// Token: 0x0400521E RID: 21022
		internal global::AcpUI.AcpRtdButton RTDBtnDataProfFeaturesARSMode_A7465;

		// Token: 0x0400521F RID: 21023
		internal global::AcpUI.AcpCopyButton CpyBtnDataProfFeaturesARSMode_A7465;

		// Token: 0x04005220 RID: 21024
		internal global::AcpUI.AcpLabel DataProfFeaturesARSMode_A7465Comp;

		// Token: 0x04005221 RID: 21025
		internal global::AcpUI.AcpCustomViewCheckBox CVBtnDataProfFeaturesAutomaticRegistrationServerAddress_A7524;

		// Token: 0x04005222 RID: 21026
		internal global::AcpUI.AcpLabel LblDataProfFeaturesAutomaticRegistrationServerAddress_A7524;

		// Token: 0x04005223 RID: 21027
		internal global::AcpUI.AcpTextBox DataProfFeaturesAutomaticRegistrationServerAddress_A7524;

		// Token: 0x04005224 RID: 21028
		internal global::AcpUI.AcpRtdButton RTDBtnDataProfFeaturesAutomaticRegistrationServerAddress_A7524;

		// Token: 0x04005225 RID: 21029
		internal global::AcpUI.AcpCopyButton CpyBtnDataProfFeaturesAutomaticRegistrationServerAddress_A7524;

		// Token: 0x04005226 RID: 21030
		internal global::AcpUI.AcpLabel DataProfFeaturesAutomaticRegistrationServerAddress_A7524Comp;

		// Token: 0x04005227 RID: 21031
		internal global::AcpUI.AcpGroupBox GrpBoxExpanderDataProfilesFeaturesDLR;

		// Token: 0x04005228 RID: 21032
		internal global::AcpUI.AcpCustomViewCheckBox CVBtnDataProfFeaturesDirLocReg_A42332;

		// Token: 0x04005229 RID: 21033
		internal global::AcpUI.AcpLabel LblDataProfFeaturesDirLocReg_A42332;

		// Token: 0x0400522A RID: 21034
		internal global::AcpUI.AcpCheckBox DataProfFeaturesDirLocReg_A42332;

		// Token: 0x0400522B RID: 21035
		internal global::AcpUI.AcpRtdButton RTDBtnDataProfFeaturesDirLocReg_A42332;

		// Token: 0x0400522C RID: 21036
		internal global::AcpUI.AcpCopyButton CpyBtnDataProfFeaturesDirLocReg_A42332;

		// Token: 0x0400522D RID: 21037
		internal global::AcpUI.AcpCheckBox DataProfFeaturesDirLocReg_A42332Comp;

		// Token: 0x0400522E RID: 21038
		internal global::AcpUI.AcpCustomViewCheckBox CVBtnDataProfFeaturesLocServerIPAddr_A42333;

		// Token: 0x0400522F RID: 21039
		internal global::AcpUI.AcpLabel LblDataProfFeaturesLocServerIPAddr_A42333;

		// Token: 0x04005230 RID: 21040
		internal global::AcpUI.AcpTextBox DataProfFeaturesLocServerIPAddr_A42333;

		// Token: 0x04005231 RID: 21041
		internal global::AcpUI.AcpRtdButton RTDBtnDataProfFeaturesLocServerIPAddr_A42333;

		// Token: 0x04005232 RID: 21042
		internal global::AcpUI.AcpCopyButton CpyBtnDataProfFeaturesLocServerIPAddr_A42333;

		// Token: 0x04005233 RID: 21043
		internal global::AcpUI.AcpLabel DataProfFeaturesLocServerIPAddr_A42333Comp;

		// Token: 0x04005234 RID: 21044
		internal global::AcpUI.AcpGroupBox GrpBoxExpanderDataProfilesFeaturesProtocolAssemblerDisassembler;

		// Token: 0x04005235 RID: 21045
		internal global::AcpUI.AcpCustomViewCheckBox CVBtnDatProFeaturesPADMode_A20536;

		// Token: 0x04005236 RID: 21046
		internal global::AcpUI.AcpLabel LblDatProFeaturesPADMode_A20536;

		// Token: 0x04005237 RID: 21047
		internal global::AcpUI.AcpComboBox DatProFeaturesPADMode_A20536;

		// Token: 0x04005238 RID: 21048
		internal global::AcpUI.AcpRtdButton RTDBtnDatProFeaturesPADMode_A20536;

		// Token: 0x04005239 RID: 21049
		internal global::AcpUI.AcpCopyButton CpyBtnDatProFeaturesPADMode_A20536;

		// Token: 0x0400523A RID: 21050
		internal global::AcpUI.AcpLabel DatProFeaturesPADMode_A20536Comp;

		// Token: 0x0400523B RID: 21051
		internal global::AcpUI.AcpCustomViewCheckBox CVBtnDatProFeaturesStartSequence_A20537;

		// Token: 0x0400523C RID: 21052
		internal global::AcpUI.AcpLabel LblDatProFeaturesStartSequence_A20537;

		// Token: 0x0400523D RID: 21053
		internal global::AcpUI.AcpTextBox DatProFeaturesStartSequence_A20537;

		// Token: 0x0400523E RID: 21054
		internal global::AcpUI.AcpRtdButton RTDBtnDatProFeaturesStartSequence_A20537;

		// Token: 0x0400523F RID: 21055
		internal global::AcpUI.AcpCopyButton CpyBtnDatProFeaturesStartSequence_A20537;

		// Token: 0x04005240 RID: 21056
		internal global::AcpUI.AcpLabel DatProFeaturesStartSequence_A20537Comp;

		// Token: 0x04005241 RID: 21057
		internal global::AcpUI.AcpCustomViewCheckBox CVBtnDatProFeaturesStopSequence_A20538;

		// Token: 0x04005242 RID: 21058
		internal global::AcpUI.AcpLabel LblDatProFeaturesStopSequence_A20538;

		// Token: 0x04005243 RID: 21059
		internal global::AcpUI.AcpTextBox DatProFeaturesStopSequence_A20538;

		// Token: 0x04005244 RID: 21060
		internal global::AcpUI.AcpRtdButton RTDBtnDatProFeaturesStopSequence_A20538;

		// Token: 0x04005245 RID: 21061
		internal global::AcpUI.AcpCopyButton CpyBtnDatProFeaturesStopSequence_A20538;

		// Token: 0x04005246 RID: 21062
		internal global::AcpUI.AcpLabel DatProFeaturesStopSequence_A20538Comp;

		// Token: 0x04005247 RID: 21063
		internal global::AcpUI.AcpCustomViewCheckBox CVBtnDatProFeaturesEscapeSequence_A20539;

		// Token: 0x04005248 RID: 21064
		internal global::AcpUI.AcpLabel LblDatProFeaturesEscapeSequence_A20539;

		// Token: 0x04005249 RID: 21065
		internal global::AcpUI.AcpTextBox DatProFeaturesEscapeSequence_A20539;

		// Token: 0x0400524A RID: 21066
		internal global::AcpUI.AcpRtdButton RTDBtnDatProFeaturesEscapeSequence_A20539;

		// Token: 0x0400524B RID: 21067
		internal global::AcpUI.AcpCopyButton CpyBtnDatProFeaturesEscapeSequence_A20539;

		// Token: 0x0400524C RID: 21068
		internal global::AcpUI.AcpLabel DatProFeaturesEscapeSequence_A20539Comp;

		// Token: 0x0400524D RID: 21069
		internal global::AcpUI.AcpCustomViewCheckBox CVBtnDatProFeaturesReceiveIdleTimeOut_A20540;

		// Token: 0x0400524E RID: 21070
		internal global::AcpUI.AcpLabel LblDatProFeaturesReceiveIdleTimeOut_A20540;

		// Token: 0x0400524F RID: 21071
		internal global::AcpUI.AcpTextBoxSpinner DatProFeaturesReceiveIdleTimeOut_A20540;

		// Token: 0x04005250 RID: 21072
		internal global::AcpUI.AcpRtdButton RTDBtnDatProFeaturesReceiveIdleTimeOut_A20540;

		// Token: 0x04005251 RID: 21073
		internal global::AcpUI.AcpCopyButton CpyBtnDatProFeaturesReceiveIdleTimeOut_A20540;

		// Token: 0x04005252 RID: 21074
		internal global::AcpUI.AcpLabel DatProFeaturesReceiveIdleTimeOut_A20540Comp;

		// Token: 0x04005253 RID: 21075
		internal global::AcpUI.AcpCustomViewCheckBox CVBtnDatProFeaturesTransmissionInhibitValue_A20541;

		// Token: 0x04005254 RID: 21076
		internal global::AcpUI.AcpLabel LblDatProFeaturesTransmissionInhibitValue_A20541;

		// Token: 0x04005255 RID: 21077
		internal global::AcpUI.AcpTextBoxSpinner DatProFeaturesTransmissionInhibitValue_A20541;

		// Token: 0x04005256 RID: 21078
		internal global::AcpUI.AcpRtdButton RTDBtnDatProFeaturesTransmissionInhibitValue_A20541;

		// Token: 0x04005257 RID: 21079
		internal global::AcpUI.AcpCopyButton CpyBtnDatProFeaturesTransmissionInhibitValue_A20541;

		// Token: 0x04005258 RID: 21080
		internal global::AcpUI.AcpLabel DatProFeaturesTransmissionInhibitValue_A20541Comp;

		// Token: 0x04005259 RID: 21081
		internal global::AcpUI.AcpCustomViewCheckBox CVBtnDatProFeaturesMaximumBufferThreshold_A20542;

		// Token: 0x0400525A RID: 21082
		internal global::AcpUI.AcpLabel LblDatProFeaturesMaximumBufferThreshold_A20542;

		// Token: 0x0400525B RID: 21083
		internal global::AcpUI.AcpTextBoxSpinner DatProFeaturesMaximumBufferThreshold_A20542;

		// Token: 0x0400525C RID: 21084
		internal global::AcpUI.AcpRtdButton RTDBtnDatProFeaturesMaximumBufferThreshold_A20542;

		// Token: 0x0400525D RID: 21085
		internal global::AcpUI.AcpCopyButton CpyBtnDatProFeaturesMaximumBufferThreshold_A20542;

		// Token: 0x0400525E RID: 21086
		internal global::AcpUI.AcpLabel DatProFeaturesMaximumBufferThreshold_A20542Comp;

		// Token: 0x0400525F RID: 21087
		internal global::AcpUI.AcpCustomViewCheckBox CVBtnDatProFeaturesDestinationAddress_A20543;

		// Token: 0x04005260 RID: 21088
		internal global::AcpUI.AcpLabel LblDatProFeaturesDestinationAddress_A20543;

		// Token: 0x04005261 RID: 21089
		internal global::AcpUI.AcpTextBox DatProFeaturesDestinationAddress_A20543;

		// Token: 0x04005262 RID: 21090
		internal global::AcpUI.AcpRtdButton RTDBtnDatProFeaturesDestinationAddress_A20543;

		// Token: 0x04005263 RID: 21091
		internal global::AcpUI.AcpCopyButton CpyBtnDatProFeaturesDestinationAddress_A20543;

		// Token: 0x04005264 RID: 21092
		internal global::AcpUI.AcpLabel DatProFeaturesDestinationAddress_A20543Comp;

		// Token: 0x04005265 RID: 21093
		internal global::AcpUI.AcpCustomViewCheckBox CVBtnDatProFeaturesDestinationPort_A20544;

		// Token: 0x04005266 RID: 21094
		internal global::AcpUI.AcpLabel LblDatProFeaturesDestinationPort_A20544;

		// Token: 0x04005267 RID: 21095
		internal global::AcpUI.AcpTextBoxSpinner DatProFeaturesDestinationPort_A20544;

		// Token: 0x04005268 RID: 21096
		internal global::AcpUI.AcpRtdButton RTDBtnDatProFeaturesDestinationPort_A20544;

		// Token: 0x04005269 RID: 21097
		internal global::AcpUI.AcpCopyButton CpyBtnDatProFeaturesDestinationPort_A20544;

		// Token: 0x0400526A RID: 21098
		internal global::AcpUI.AcpLabel DatProFeaturesDestinationPort_A20544Comp;

		// Token: 0x0400526B RID: 21099
		internal global::AcpUI.AcpGroupBox GrpBoxExpanderDataProfilesFeaturesATAK;

		// Token: 0x0400526C RID: 21100
		internal global::AcpUI.AcpCustomViewCheckBox CVBtnDataProfFeaturesAtakField;

		// Token: 0x0400526D RID: 21101
		internal global::AcpUI.AcpLabel LblDataProfFeaturesAtakField;

		// Token: 0x0400526E RID: 21102
		internal global::AcpUI.AcpCheckBox DataProfFeaturesAtakField;

		// Token: 0x0400526F RID: 21103
		internal global::AcpUI.AcpRtdButton RTDBtnDataProfFeaturesAtakField;

		// Token: 0x04005270 RID: 21104
		internal global::AcpUI.AcpCopyButton CpyBtnDataProfFeaturesAtakField;

		// Token: 0x04005271 RID: 21105
		internal global::AcpUI.AcpCheckBox DataProfFeaturesAtakFieldComp;

		// Token: 0x04005272 RID: 21106
		internal global::AcpUI.AcpExpander ExpanderDataProfilesDAC;

		// Token: 0x04005273 RID: 21107
		internal global::AcpUI.AcpChildRecNavToolbar RecNavToolbarExpanderDataProfilesDACList;

		// Token: 0x04005274 RID: 21108
		internal global::System.Windows.Controls.Grid ExpanderDataProfilesDACGrid;

		// Token: 0x04005275 RID: 21109
		internal global::System.Windows.Controls.Grid ExpanderDataProfilesDACListGrid;

		// Token: 0x04005276 RID: 21110
		internal global::AcpUI.AcpGroupBox ExpanderDataProfilesDACListTableView;

		// Token: 0x04005277 RID: 21111
		internal global::AcpUI.AcpXamDataPresenter ExpanderDataProfilesDACList;

		// Token: 0x04005278 RID: 21112
		internal global::Infragistics.Windows.DataPresenter.UnboundField DataProfilesDACOperationalMode_A36199_Col;

		// Token: 0x04005279 RID: 21113
		internal global::Infragistics.Windows.DataPresenter.UnboundField DataProfilesDACSlotSize_A36203_Col;

		// Token: 0x0400527A RID: 21114
		internal global::AcpUI.AcpGroupBox ExpanderDataProfilesDACListSRecView;

		// Token: 0x0400527B RID: 21115
		internal global::System.Windows.Controls.Grid gridExpanderDataProfilesDACListSRecView;

		// Token: 0x0400527C RID: 21116
		internal global::AcpUI.AcpComboBox DataProfilesDACOperationalMode_A36199;

		// Token: 0x0400527D RID: 21117
		internal global::AcpUI.AcpCustomViewCheckBox CVBtnDataProfilesDACOperationalMode_A36199;

		// Token: 0x0400527E RID: 21118
		internal global::AcpUI.AcpLabel LblDataProfilesDACOperationalMode_A36199;

		// Token: 0x0400527F RID: 21119
		internal global::AcpUI.AcpRtdButton RTDBtnDataProfilesDACOperationalMode_A36199;

		// Token: 0x04005280 RID: 21120
		internal global::AcpUI.AcpCopyButton CpyBtnDataProfilesDACOperationalMode_A36199;

		// Token: 0x04005281 RID: 21121
		internal global::AcpUI.AcpLabel DataProfilesDACOperationalMode_A36199Comp;

		// Token: 0x04005282 RID: 21122
		internal global::AcpUI.AcpComboBox DataProfilesDACSlotSize_A36203;

		// Token: 0x04005283 RID: 21123
		internal global::AcpUI.AcpCustomViewCheckBox CVBtnDataProfilesDACSlotSize_A36203;

		// Token: 0x04005284 RID: 21124
		internal global::AcpUI.AcpLabel LblDataProfilesDACSlotSize_A36203;

		// Token: 0x04005285 RID: 21125
		internal global::AcpUI.AcpRtdButton RTDBtnDataProfilesDACSlotSize_A36203;

		// Token: 0x04005286 RID: 21126
		internal global::AcpUI.AcpCopyButton CpyBtnDataProfilesDACSlotSize_A36203;

		// Token: 0x04005287 RID: 21127
		internal global::AcpUI.AcpLabel DataProfilesDACSlotSize_A36203Comp;

		// Token: 0x04005288 RID: 21128
		internal global::AcpUI.AcpExpander ExpanderDataProfilesTrunkingGroupID;

		// Token: 0x04005289 RID: 21129
		internal global::AcpUI.AcpChildRecNavToolbar RecNavToolbarExpanderDataProfilesTrunkingGroupIDList;

		// Token: 0x0400528A RID: 21130
		internal global::System.Windows.Controls.Grid ExpanderDataProfilesTrunkingGroupIDGrid;

		// Token: 0x0400528B RID: 21131
		internal global::System.Windows.Controls.Grid ExpanderDataProfilesTrunkingGroupIDListGrid;

		// Token: 0x0400528C RID: 21132
		internal global::AcpUI.AcpGroupBox ExpanderDataProfilesTrunkingGroupIDListTableView;

		// Token: 0x0400528D RID: 21133
		internal global::AcpUI.AcpXamDataPresenter ExpanderDataProfilesTrunkingGroupIDList;

		// Token: 0x0400528E RID: 21134
		internal global::Infragistics.Windows.DataPresenter.UnboundField DataProfilesTrunkingGroupID_ASTRO25DataGroupID_A36204_Col;

		// Token: 0x0400528F RID: 21135
		internal global::AcpUI.AcpGroupBox ExpanderDataProfilesTrunkingGroupIDListSRecView;

		// Token: 0x04005290 RID: 21136
		internal global::System.Windows.Controls.Grid gridExpanderDataProfilesTrunkingGroupIDListSRecView;

		// Token: 0x04005291 RID: 21137
		internal global::AcpUI.AcpTextBoxSpinnerDecHex DataProfilesTrunkingGroupID_ASTRO25DataGroupID_A36204;

		// Token: 0x04005292 RID: 21138
		internal global::AcpUI.AcpCustomViewCheckBox CVBtnDataProfilesTrunkingGroupID_ASTRO25DataGroupID_A36204;

		// Token: 0x04005293 RID: 21139
		internal global::AcpUI.AcpLabel LblDataProfilesTrunkingGroupID_ASTRO25DataGroupID_A36204;

		// Token: 0x04005294 RID: 21140
		internal global::AcpUI.AcpRtdButton RTDBtnDataProfilesTrunkingGroupID_ASTRO25DataGroupID_A36204;

		// Token: 0x04005295 RID: 21141
		internal global::AcpUI.AcpCopyButton CpyBtnDataProfilesTrunkingGroupID_ASTRO25DataGroupID_A36204;

		// Token: 0x04005296 RID: 21142
		internal global::AcpUI.AcpTextBoxDecHex DataProfilesTrunkingGroupID_ASTRO25DataGroupID_A36204Comp;

		// Token: 0x04005297 RID: 21143
		internal global::AcpUI.AcpExpander ExpanderDataProfilesLTE;

		// Token: 0x04005298 RID: 21144
		internal global::AcpUI.AcpGroupBox GrpBoxExpanderDataProfilesLTEPseudo0;

		// Token: 0x04005299 RID: 21145
		internal global::AcpUI.AcpCustomViewCheckBox CVBtnDataProfLTEEnabled_A42075;

		// Token: 0x0400529A RID: 21146
		internal global::AcpUI.AcpLabel LblDataProfLTEEnabled_A42075;

		// Token: 0x0400529B RID: 21147
		internal global::AcpUI.AcpCheckBox DataProfLTEEnabled_A42075;

		// Token: 0x0400529C RID: 21148
		internal global::AcpUI.AcpRtdButton RTDBtnDataProfLTEEnabled_A42075;

		// Token: 0x0400529D RID: 21149
		internal global::AcpUI.AcpCopyButton CpyBtnDataProfLTEEnabled_A42075;

		// Token: 0x0400529E RID: 21150
		internal global::AcpUI.AcpCheckBox DataProfLTEEnabled_A42075Comp;

		// Token: 0x0400529F RID: 21151
		internal global::AcpUI.AcpCustomViewCheckBox CVBtnDataProfBroadbandSource_A42858;

		// Token: 0x040052A0 RID: 21152
		internal global::AcpUI.AcpLabel LblDataProfBroadbandSource_A42858;

		// Token: 0x040052A1 RID: 21153
		internal global::AcpUI.AcpComboBox DataProfBroadbandSource_A42858;

		// Token: 0x040052A2 RID: 21154
		internal global::AcpUI.AcpRtdButton RTDBtnDataProfBroadbandSource_A42858;

		// Token: 0x040052A3 RID: 21155
		internal global::AcpUI.AcpCopyButton CpyBtnDataProfBroadbandSource_A42858;

		// Token: 0x040052A4 RID: 21156
		internal global::AcpUI.AcpLabel DataProfBroadbandSource_A42858Comp;

		// Token: 0x040052A5 RID: 21157
		internal global::AcpUI.AcpCustomViewCheckBox CVBtnDataProfLTEBackupPTTGatewayHostname_A43621;

		// Token: 0x040052A6 RID: 21158
		internal global::AcpUI.AcpLabel LblDataProfLTEBackupPTTGatewayHostname_A43621;

		// Token: 0x040052A7 RID: 21159
		internal global::AcpUI.AcpTextBox DataProfLTEBackupPTTGatewayHostname_A43621;

		// Token: 0x040052A8 RID: 21160
		internal global::AcpUI.AcpRtdButton RTDBtnDataProfLTEBackupPTTGatewayHostname_A43621;

		// Token: 0x040052A9 RID: 21161
		internal global::AcpUI.AcpCopyButton CpyBtnDataProfLTEBackupPTTGatewayHostname_A43621;

		// Token: 0x040052AA RID: 21162
		internal global::AcpUI.AcpLabel DataProfLTEBackupPTTGatewayHostname_A43621Comp;

		// Token: 0x040052AB RID: 21163
		internal global::AcpUI.AcpCustomViewCheckBox CVBtnDataProfLTEBackupPTTGatewayPort_A43618;

		// Token: 0x040052AC RID: 21164
		internal global::AcpUI.AcpLabel LblDataProfLTEBackupPTTGatewayPort_A43618;

		// Token: 0x040052AD RID: 21165
		internal global::AcpUI.AcpTextBoxSpinner DataProfLTEBackupPTTGatewayPort_A43618;

		// Token: 0x040052AE RID: 21166
		internal global::AcpUI.AcpRtdButton RTDBtnDataProfLTEBackupPTTGatewayPort_A43618;

		// Token: 0x040052AF RID: 21167
		internal global::AcpUI.AcpCopyButton CpyBtnDataProfLTEBackupPTTGatewayPort_A43618;

		// Token: 0x040052B0 RID: 21168
		internal global::AcpUI.AcpLabel DataProfLTEBackupPTTGatewayPort_A43618Comp;

		// Token: 0x040052B1 RID: 21169
		internal global::AcpUI.AcpExpander ExpanderDataProfilesNetworkLayerSecurity;

		// Token: 0x040052B2 RID: 21170
		internal global::AcpUI.AcpGroupBox GrpBoxExpanderDataProfilesNetworkLayerSecurityPacketDataAPCO25;

		// Token: 0x040052B3 RID: 21171
		internal global::AcpUI.AcpCustomViewCheckBox CVBtnDataProfNLSSecClrStrp_A36415;

		// Token: 0x040052B4 RID: 21172
		internal global::AcpUI.AcpLabel LblDataProfNLSSecClrStrp_A36415;

		// Token: 0x040052B5 RID: 21173
		internal global::AcpUI.AcpComboBox DataProfNLSSecClrStrp_A36415;

		// Token: 0x040052B6 RID: 21174
		internal global::AcpUI.AcpRtdButton RTDBtnDataProfNLSSecClrStrp_A36415;

		// Token: 0x040052B7 RID: 21175
		internal global::AcpUI.AcpCopyButton CpyBtnDataProfNLSSecClrStrp_A36415;

		// Token: 0x040052B8 RID: 21176
		internal global::AcpUI.AcpLabel DataProfNLSSecClrStrp_A36415Comp;

		// Token: 0x040052B9 RID: 21177
		internal global::AcpUI.AcpCustomViewCheckBox CVBtnDataProfNLSKMFProfSele_A36419;

		// Token: 0x040052BA RID: 21178
		internal global::AcpUI.AcpLabel LblDataProfNLSKMFProfSele_A36419;

		// Token: 0x040052BB RID: 21179
		internal global::AcpUI.AcpComboBox DataProfNLSKMFProfSele_A36419;

		// Token: 0x040052BC RID: 21180
		internal global::AcpUI.AcpRtdButton RTDBtnDataProfNLSKMFProfSele_A36419;

		// Token: 0x040052BD RID: 21181
		internal global::AcpUI.AcpCopyButton CpyBtnDataProfNLSKMFProfSele_A36419;

		// Token: 0x040052BE RID: 21182
		internal global::AcpUI.AcpLabel DataProfNLSKMFProfSele_A36419Comp;

		// Token: 0x040052BF RID: 21183
		internal global::AcpUI.AcpCustomViewCheckBox CVBtnDataProfNLSKeySele_A36410;

		// Token: 0x040052C0 RID: 21184
		internal global::AcpUI.AcpLabel LblDataProfNLSKeySele_A36410;

		// Token: 0x040052C1 RID: 21185
		internal global::AcpUI.AcpComboBox DataProfNLSKeySele_A36410;

		// Token: 0x040052C2 RID: 21186
		internal global::AcpUI.AcpRtdButton RTDBtnDataProfNLSKeySele_A36410;

		// Token: 0x040052C3 RID: 21187
		internal global::AcpUI.AcpCopyButton CpyBtnDataProfNLSKeySele_A36410;

		// Token: 0x040052C4 RID: 21188
		internal global::AcpUI.AcpLabel DataProfNLSKeySele_A36410Comp;

		// Token: 0x040052C5 RID: 21189
		internal global::AcpUI.AcpCustomViewCheckBox CVBtnDataProfNLSEncGatewayAddr_A36412;

		// Token: 0x040052C6 RID: 21190
		internal global::AcpUI.AcpLabel LblDataProfNLSEncGatewayAddr_A36412;

		// Token: 0x040052C7 RID: 21191
		internal global::AcpUI.AcpTextBox DataProfNLSEncGatewayAddr_A36412;

		// Token: 0x040052C8 RID: 21192
		internal global::AcpUI.AcpRtdButton RTDBtnDataProfNLSEncGatewayAddr_A36412;

		// Token: 0x040052C9 RID: 21193
		internal global::AcpUI.AcpCopyButton CpyBtnDataProfNLSEncGatewayAddr_A36412;

		// Token: 0x040052CA RID: 21194
		internal global::AcpUI.AcpLabel DataProfNLSEncGatewayAddr_A36412Comp;

		// Token: 0x040052CB RID: 21195
		internal global::AcpUI.AcpCustomViewCheckBox CVBtnDataProfNLSAllowRxClrPackData_A36414;

		// Token: 0x040052CC RID: 21196
		internal global::AcpUI.AcpLabel LblDataProfNLSAllowRxClrPackData_A36414;

		// Token: 0x040052CD RID: 21197
		internal global::AcpUI.AcpCheckBox DataProfNLSAllowRxClrPackData_A36414;

		// Token: 0x040052CE RID: 21198
		internal global::AcpUI.AcpRtdButton RTDBtnDataProfNLSAllowRxClrPackData_A36414;

		// Token: 0x040052CF RID: 21199
		internal global::AcpUI.AcpCopyButton CpyBtnDataProfNLSAllowRxClrPackData_A36414;

		// Token: 0x040052D0 RID: 21200
		internal global::AcpUI.AcpCheckBox DataProfNLSAllowRxClrPackData_A36414Comp;

		// Token: 0x040052D1 RID: 21201
		internal global::AcpUI.AcpGroupBox GrpBoxExpanderDataProfilesNetworkLayerSecurityVPN;

		// Token: 0x040052D2 RID: 21202
		internal global::AcpUI.AcpCustomViewCheckBox CVBtnDataProfVPNSecClrStrp_A42120;

		// Token: 0x040052D3 RID: 21203
		internal global::AcpUI.AcpLabel LblDataProfVPNSecClrStrp_A42120;

		// Token: 0x040052D4 RID: 21204
		internal global::AcpUI.AcpComboBox DataProfVPNSecClrStrp_A42120;

		// Token: 0x040052D5 RID: 21205
		internal global::AcpUI.AcpRtdButton RTDBtnDataProfVPNSecClrStrp_A42120;

		// Token: 0x040052D6 RID: 21206
		internal global::AcpUI.AcpCopyButton CpyBtnDataProfVPNSecClrStrp_A42120;

		// Token: 0x040052D7 RID: 21207
		internal global::AcpUI.AcpLabel DataProfVPNSecClrStrp_A42120Comp;

		// Token: 0x040052D8 RID: 21208
		internal global::AcpUI.AcpCustomViewCheckBox CVBtnDataProfVPNKeySelection_42280;

		// Token: 0x040052D9 RID: 21209
		internal global::AcpUI.AcpLabel LblDataProfVPNKeySelection_42280;

		// Token: 0x040052DA RID: 21210
		internal global::AcpUI.AcpComboBox DataProfVPNKeySelection_42280;

		// Token: 0x040052DB RID: 21211
		internal global::AcpUI.AcpRtdButton RTDBtnDataProfVPNKeySelection_42280;

		// Token: 0x040052DC RID: 21212
		internal global::AcpUI.AcpCopyButton CpyBtnDataProfVPNKeySelection_42280;

		// Token: 0x040052DD RID: 21213
		internal global::AcpUI.AcpLabel DataProfVPNKeySelection_42280Comp;

		// Token: 0x040052DE RID: 21214
		internal global::AcpUI.AcpCustomViewCheckBox CVBtnDataProfVPNGatewayIPAddress_A42079;

		// Token: 0x040052DF RID: 21215
		internal global::AcpUI.AcpLabel LblDataProfVPNGatewayIPAddress_A42079;

		// Token: 0x040052E0 RID: 21216
		internal global::AcpUI.AcpTextBox DataProfVPNGatewayIPAddress_A42079;

		// Token: 0x040052E1 RID: 21217
		internal global::AcpUI.AcpRtdButton RTDBtnDataProfVPNGatewayIPAddress_A42079;

		// Token: 0x040052E2 RID: 21218
		internal global::AcpUI.AcpCopyButton CpyBtnDataProfVPNGatewayIPAddress_A42079;

		// Token: 0x040052E3 RID: 21219
		internal global::AcpUI.AcpLabel DataProfVPNGatewayIPAddress_A42079Comp;

		// Token: 0x040052E4 RID: 21220
		internal global::AcpUI.AcpCustomViewCheckBox CVBtnDataProfVPNMessageRetransmissionTime_A42209;

		// Token: 0x040052E5 RID: 21221
		internal global::AcpUI.AcpLabel LblDataProfVPNMessageRetransmissionTime_A42209;

		// Token: 0x040052E6 RID: 21222
		internal global::AcpUI.AcpTextBoxSpinner DataProfVPNMessageRetransmissionTime_A42209;

		// Token: 0x040052E7 RID: 21223
		internal global::AcpUI.AcpRtdButton RTDBtnDataProfVPNMessageRetransmissionTime_A42209;

		// Token: 0x040052E8 RID: 21224
		internal global::AcpUI.AcpCopyButton CpyBtnDataProfVPNMessageRetransmissionTime_A42209;

		// Token: 0x040052E9 RID: 21225
		internal global::AcpUI.AcpLabel DataProfVPNMessageRetransmissionTime_A42209Comp;

		// Token: 0x040052EA RID: 21226
		internal global::AcpUI.AcpCustomViewCheckBox CVBtnDataProfVPNMessageRetransmissionAttempts_A42210;

		// Token: 0x040052EB RID: 21227
		internal global::AcpUI.AcpLabel LblDataProfVPNMessageRetransmissionAttempts_A42210;

		// Token: 0x040052EC RID: 21228
		internal global::AcpUI.AcpTextBoxSpinner DataProfVPNMessageRetransmissionAttempts_A42210;

		// Token: 0x040052ED RID: 21229
		internal global::AcpUI.AcpRtdButton RTDBtnDataProfVPNMessageRetransmissionAttempts_A42210;

		// Token: 0x040052EE RID: 21230
		internal global::AcpUI.AcpCopyButton CpyBtnDataProfVPNMessageRetransmissionAttempts_A42210;

		// Token: 0x040052EF RID: 21231
		internal global::AcpUI.AcpLabel DataProfVPNMessageRetransmissionAttempts_A42210Comp;

		// Token: 0x040052F0 RID: 21232
		internal global::AcpUI.AcpCustomViewCheckBox CVBtnDataProfVPNDeadPeerDetectionInterval_A42211;

		// Token: 0x040052F1 RID: 21233
		internal global::AcpUI.AcpLabel LblDataProfVPNDeadPeerDetectionInterval_A42211;

		// Token: 0x040052F2 RID: 21234
		internal global::AcpUI.AcpTextBoxSpinner DataProfVPNDeadPeerDetectionInterval_A42211;

		// Token: 0x040052F3 RID: 21235
		internal global::AcpUI.AcpRtdButton RTDBtnDataProfVPNDeadPeerDetectionInterval_A42211;

		// Token: 0x040052F4 RID: 21236
		internal global::AcpUI.AcpCopyButton CpyBtnDataProfVPNDeadPeerDetectionInterval_A42211;

		// Token: 0x040052F5 RID: 21237
		internal global::AcpUI.AcpLabel DataProfVPNDeadPeerDetectionInterval_A42211Comp;

		// Token: 0x040052F6 RID: 21238
		internal global::AcpUI.AcpCustomViewCheckBox CVBtnDataProfVPNRekeyMargin_A42212;

		// Token: 0x040052F7 RID: 21239
		internal global::AcpUI.AcpLabel LblDataProfVPNRekeyMargin_A42212;

		// Token: 0x040052F8 RID: 21240
		internal global::AcpUI.AcpTextBoxSpinner DataProfVPNRekeyMargin_A42212;

		// Token: 0x040052F9 RID: 21241
		internal global::AcpUI.AcpRtdButton RTDBtnDataProfVPNRekeyMargin_A42212;

		// Token: 0x040052FA RID: 21242
		internal global::AcpUI.AcpCopyButton CpyBtnDataProfVPNRekeyMargin_A42212;

		// Token: 0x040052FB RID: 21243
		internal global::AcpUI.AcpLabel DataProfVPNRekeyMargin_A42212Comp;

		// Token: 0x040052FC RID: 21244
		internal global::AcpUI.AcpCustomViewCheckBox CVBtnDataProfVPNRekeyAttempts_A42213;

		// Token: 0x040052FD RID: 21245
		internal global::AcpUI.AcpLabel LblDataProfVPNRekeyAttempts_A42213;

		// Token: 0x040052FE RID: 21246
		internal global::AcpUI.AcpTextBoxSpinner DataProfVPNRekeyAttempts_A42213;

		// Token: 0x040052FF RID: 21247
		internal global::AcpUI.AcpRtdButton RTDBtnDataProfVPNRekeyAttempts_A42213;

		// Token: 0x04005300 RID: 21248
		internal global::AcpUI.AcpCopyButton CpyBtnDataProfVPNRekeyAttempts_A42213;

		// Token: 0x04005301 RID: 21249
		internal global::AcpUI.AcpLabel DataProfVPNRekeyAttempts_A42213Comp;

		// Token: 0x04005302 RID: 21250
		internal global::AcpUI.AcpExpander ExpanderDataProfilesEIDBypassList;

		// Token: 0x04005303 RID: 21251
		internal global::AcpUI.AcpChildRecNavToolbar RecNavToolbarExpanderDataProfilesEIDBypassListTable;

		// Token: 0x04005304 RID: 21252
		internal global::System.Windows.Controls.Grid ExpanderDataProfilesEIDBypassListGrid;

		// Token: 0x04005305 RID: 21253
		internal global::System.Windows.Controls.Grid ExpanderDataProfilesEIDBypassListTableGrid;

		// Token: 0x04005306 RID: 21254
		internal global::AcpUI.AcpGroupBox ExpanderDataProfilesEIDBypassListTableTableView;

		// Token: 0x04005307 RID: 21255
		internal global::AcpUI.AcpXamDataPresenter ExpanderDataProfilesEIDBypassListTable;

		// Token: 0x04005308 RID: 21256
		internal global::Infragistics.Windows.DataPresenter.UnboundField DataProfEIDByPassListIPAddr_A36417_Col;

		// Token: 0x04005309 RID: 21257
		internal global::Infragistics.Windows.DataPresenter.UnboundField DataProfEIDByPassListAddrType_A36418_Col;

		// Token: 0x0400530A RID: 21258
		internal global::AcpUI.AcpGroupBox ExpanderDataProfilesEIDBypassListTableSRecView;

		// Token: 0x0400530B RID: 21259
		internal global::System.Windows.Controls.Grid gridExpanderDataProfilesEIDBypassListTableSRecView;

		// Token: 0x0400530C RID: 21260
		internal global::AcpUI.AcpTextBox DataProfEIDByPassListIPAddr_A36417;

		// Token: 0x0400530D RID: 21261
		internal global::AcpUI.AcpCustomViewCheckBox CVBtnDataProfEIDByPassListIPAddr_A36417;

		// Token: 0x0400530E RID: 21262
		internal global::AcpUI.AcpLabel LblDataProfEIDByPassListIPAddr_A36417;

		// Token: 0x0400530F RID: 21263
		internal global::AcpUI.AcpRtdButton RTDBtnDataProfEIDByPassListIPAddr_A36417;

		// Token: 0x04005310 RID: 21264
		internal global::AcpUI.AcpCopyButton CpyBtnDataProfEIDByPassListIPAddr_A36417;

		// Token: 0x04005311 RID: 21265
		internal global::AcpUI.AcpLabel DataProfEIDByPassListIPAddr_A36417Comp;

		// Token: 0x04005312 RID: 21266
		internal global::AcpUI.AcpComboBox DataProfEIDByPassListAddrType_A36418;

		// Token: 0x04005313 RID: 21267
		internal global::AcpUI.AcpCustomViewCheckBox CVBtnDataProfEIDByPassListAddrType_A36418;

		// Token: 0x04005314 RID: 21268
		internal global::AcpUI.AcpLabel LblDataProfEIDByPassListAddrType_A36418;

		// Token: 0x04005315 RID: 21269
		internal global::AcpUI.AcpRtdButton RTDBtnDataProfEIDByPassListAddrType_A36418;

		// Token: 0x04005316 RID: 21270
		internal global::AcpUI.AcpCopyButton CpyBtnDataProfEIDByPassListAddrType_A36418;

		// Token: 0x04005317 RID: 21271
		internal global::AcpUI.AcpLabel DataProfEIDByPassListAddrType_A36418Comp;

		// Token: 0x04005318 RID: 21272
		internal global::AcpUI.AcpExpander ExpanderDataProfilesEnhancedData;

		// Token: 0x04005319 RID: 21273
		internal global::AcpUI.AcpGroupBox GrpBoxExpanderDataProfilesEnhancedDataPseudo0;

		// Token: 0x0400531A RID: 21274
		internal global::AcpUI.AcpCustomViewCheckBox CVBtnDatProFeaturesPortListSelection_A42011;

		// Token: 0x0400531B RID: 21275
		internal global::AcpUI.AcpLabel LblDatProFeaturesPortListSelection_A42011;

		// Token: 0x0400531C RID: 21276
		internal global::AcpUI.AcpComboBox DatProFeaturesPortListSelection_A42011;

		// Token: 0x0400531D RID: 21277
		internal global::AcpUI.AcpRtdButton RTDBtnDatProFeaturesPortListSelection_A42011;

		// Token: 0x0400531E RID: 21278
		internal global::AcpUI.AcpCopyButton CpyBtnDatProFeaturesPortListSelection_A42011;

		// Token: 0x0400531F RID: 21279
		internal global::AcpUI.AcpLabel DatProFeaturesPortListSelection_A42011Comp;

		// Token: 0x04005320 RID: 21280
		internal global::AcpUI.AcpCustomViewCheckBox CVBtnAllowEnhancedDataToBeSentOnClassicDataChannel_42014;

		// Token: 0x04005321 RID: 21281
		internal global::AcpUI.AcpLabel LblAllowEnhancedDataToBeSentOnClassicDataChannel_42014;

		// Token: 0x04005322 RID: 21282
		internal global::AcpUI.AcpCheckBox AllowEnhancedDataToBeSentOnClassicDataChannel_42014;

		// Token: 0x04005323 RID: 21283
		internal global::AcpUI.AcpRtdButton RTDBtnAllowEnhancedDataToBeSentOnClassicDataChannel_42014;

		// Token: 0x04005324 RID: 21284
		internal global::AcpUI.AcpCopyButton CpyBtnAllowEnhancedDataToBeSentOnClassicDataChannel_42014;

		// Token: 0x04005325 RID: 21285
		internal global::AcpUI.AcpCheckBox AllowEnhancedDataToBeSentOnClassicDataChannel_42014Comp;

		// Token: 0x04005326 RID: 21286
		internal global::AcpUI.AcpCustomViewCheckBox CVBtnQueueDwellTimerSec_42015;

		// Token: 0x04005327 RID: 21287
		internal global::AcpUI.AcpLabel LblQueueDwellTimerSec_42015;

		// Token: 0x04005328 RID: 21288
		internal global::AcpUI.AcpTextBoxSpinner QueueDwellTimerSec_42015;

		// Token: 0x04005329 RID: 21289
		internal global::AcpUI.AcpRtdButton RTDBtnQueueDwellTimerSec_42015;

		// Token: 0x0400532A RID: 21290
		internal global::AcpUI.AcpCopyButton CpyBtnQueueDwellTimerSec_42015;

		// Token: 0x0400532B RID: 21291
		internal global::AcpUI.AcpLabel QueueDwellTimerSec_42015Comp;

		// Token: 0x0400532C RID: 21292
		internal global::AcpUI.AcpCustomViewCheckBox CVBtnDatProSendDataDurEmerHangtime_A43103;

		// Token: 0x0400532D RID: 21293
		internal global::AcpUI.AcpLabel LblDatProSendDataDurEmerHangtime_A43103;

		// Token: 0x0400532E RID: 21294
		internal global::AcpUI.AcpCheckBox DatProSendDataDurEmerHangtime_A43103;

		// Token: 0x0400532F RID: 21295
		internal global::AcpUI.AcpRtdButton RTDBtnDatProSendDataDurEmerHangtime_A43103;

		// Token: 0x04005330 RID: 21296
		internal global::AcpUI.AcpCopyButton CpyBtnDatProSendDataDurEmerHangtime_A43103;

		// Token: 0x04005331 RID: 21297
		internal global::AcpUI.AcpCheckBox DatProSendDataDurEmerHangtime_A43103Comp;

		// Token: 0x04005332 RID: 21298
		internal global::AcpUI.AcpExpander ExpanderDataProfilesLabtoolDATA_PROF;

		// Token: 0x04005333 RID: 21299
		internal global::AcpUI.AcpGroupBox GrpBoxExpanderDataProfilesLabtoolDATA_PROFPseudo0;

		// Token: 0x04005334 RID: 21300
		internal global::AcpUI.AcpCustomViewCheckBox CVBtnDataProfLabtoolDATA_PROFDataDeliveryMode_A11468;

		// Token: 0x04005335 RID: 21301
		internal global::AcpUI.AcpLabel LblDataProfLabtoolDATA_PROFDataDeliveryMode_A11468;

		// Token: 0x04005336 RID: 21302
		internal global::AcpUI.AcpComboBox DataProfLabtoolDATA_PROFDataDeliveryMode_A11468;

		// Token: 0x04005337 RID: 21303
		internal global::AcpUI.AcpRtdButton RTDBtnDataProfLabtoolDATA_PROFDataDeliveryMode_A11468;

		// Token: 0x04005338 RID: 21304
		internal global::AcpUI.AcpCopyButton CpyBtnDataProfLabtoolDATA_PROFDataDeliveryMode_A11468;

		// Token: 0x04005339 RID: 21305
		internal global::AcpUI.AcpLabel DataProfLabtoolDATA_PROFDataDeliveryMode_A11468Comp;

		// Token: 0x0400533A RID: 21306
		internal global::AcpUI.AcpCustomViewCheckBox CVBtnDataConfigurationDataProfileTrunkingA25DACMappingListItemNameId_A36218;

		// Token: 0x0400533B RID: 21307
		internal global::AcpUI.AcpLabel LblDataConfigurationDataProfileTrunkingA25DACMappingListItemNameId_A36218;

		// Token: 0x0400533C RID: 21308
		internal global::AcpUI.AcpComboBox DataConfigurationDataProfileTrunkingA25DACMappingListItemNameId_A36218;

		// Token: 0x0400533D RID: 21309
		internal global::AcpUI.AcpRtdButton RTDBtnDataConfigurationDataProfileTrunkingA25DACMappingListItemNameId_A36218;

		// Token: 0x0400533E RID: 21310
		internal global::AcpUI.AcpCopyButton CpyBtnDataConfigurationDataProfileTrunkingA25DACMappingListItemNameId_A36218;

		// Token: 0x0400533F RID: 21311
		internal global::AcpUI.AcpLabel DataConfigurationDataProfileTrunkingA25DACMappingListItemNameId_A36218Comp;

		// Token: 0x04005340 RID: 21312
		internal global::AcpUI.AcpCustomViewCheckBox CVBtnDataConfigurationDataProfileTrunkingA25DataGroupIDListItemNameId_A36219;

		// Token: 0x04005341 RID: 21313
		internal global::AcpUI.AcpLabel LblDataConfigurationDataProfileTrunkingA25DataGroupIDListItemNameId_A36219;

		// Token: 0x04005342 RID: 21314
		internal global::AcpUI.AcpComboBox DataConfigurationDataProfileTrunkingA25DataGroupIDListItemNameId_A36219;

		// Token: 0x04005343 RID: 21315
		internal global::AcpUI.AcpRtdButton RTDBtnDataConfigurationDataProfileTrunkingA25DataGroupIDListItemNameId_A36219;

		// Token: 0x04005344 RID: 21316
		internal global::AcpUI.AcpCopyButton CpyBtnDataConfigurationDataProfileTrunkingA25DataGroupIDListItemNameId_A36219;

		// Token: 0x04005345 RID: 21317
		internal global::AcpUI.AcpLabel DataConfigurationDataProfileTrunkingA25DataGroupIDListItemNameId_A36219Comp;

		// Token: 0x04005346 RID: 21318
		internal global::AcpUI.AcpCustomViewCheckBox CVBtnDataProfLabtoolTrk25EIDBypassListItemID_A36423;

		// Token: 0x04005347 RID: 21319
		internal global::AcpUI.AcpLabel LblDataProfLabtoolTrk25EIDBypassListItemID_A36423;

		// Token: 0x04005348 RID: 21320
		internal global::AcpUI.AcpComboBox DataProfLabtoolTrk25EIDBypassListItemID_A36423;

		// Token: 0x04005349 RID: 21321
		internal global::AcpUI.AcpRtdButton RTDBtnDataProfLabtoolTrk25EIDBypassListItemID_A36423;

		// Token: 0x0400534A RID: 21322
		internal global::AcpUI.AcpCopyButton CpyBtnDataProfLabtoolTrk25EIDBypassListItemID_A36423;

		// Token: 0x0400534B RID: 21323
		internal global::AcpUI.AcpLabel DataProfLabtoolTrk25EIDBypassListItemID_A36423Comp;

		// Token: 0x0400534C RID: 21324
		internal global::AcpUI.AcpCustomViewCheckBox CVBtnDataProfLabtoolDATA_PROFConventionalARSDeregistrationDelayTimer_A20991;

		// Token: 0x0400534D RID: 21325
		internal global::AcpUI.AcpLabel LblDataProfLabtoolDATA_PROFConventionalARSDeregistrationDelayTimer_A20991;

		// Token: 0x0400534E RID: 21326
		internal global::AcpUI.AcpTextBoxSpinner DataProfLabtoolDATA_PROFConventionalARSDeregistrationDelayTimer_A20991;

		// Token: 0x0400534F RID: 21327
		internal global::AcpUI.AcpRtdButton RTDBtnDataProfLabtoolDATA_PROFConventionalARSDeregistrationDelayTimer_A20991;

		// Token: 0x04005350 RID: 21328
		internal global::AcpUI.AcpCopyButton CpyBtnDataProfLabtoolDATA_PROFConventionalARSDeregistrationDelayTimer_A20991;

		// Token: 0x04005351 RID: 21329
		internal global::AcpUI.AcpLabel DataProfLabtoolDATA_PROFConventionalARSDeregistrationDelayTimer_A20991Comp;

		// Token: 0x04005352 RID: 21330
		internal global::AcpUI.AcpCustomViewCheckBox CVBtnDataProfLabtoolDATA_PROFTrunkingARSDeregistrationDelayTimer_A9475;

		// Token: 0x04005353 RID: 21331
		internal global::AcpUI.AcpLabel LblDataProfLabtoolDATA_PROFTrunkingARSDeregistrationDelayTimer_A9475;

		// Token: 0x04005354 RID: 21332
		internal global::AcpUI.AcpTextBoxSpinner DataProfLabtoolDATA_PROFTrunkingARSDeregistrationDelayTimer_A9475;

		// Token: 0x04005355 RID: 21333
		internal global::AcpUI.AcpRtdButton RTDBtnDataProfLabtoolDATA_PROFTrunkingARSDeregistrationDelayTimer_A9475;

		// Token: 0x04005356 RID: 21334
		internal global::AcpUI.AcpCopyButton CpyBtnDataProfLabtoolDATA_PROFTrunkingARSDeregistrationDelayTimer_A9475;

		// Token: 0x04005357 RID: 21335
		internal global::AcpUI.AcpLabel DataProfLabtoolDATA_PROFTrunkingARSDeregistrationDelayTimer_A9475Comp;

		// Token: 0x04005358 RID: 21336
		private bool b;
	}
}
