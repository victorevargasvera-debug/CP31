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
using ConstraintHelper;
using Infragistics.Windows.DataPresenter;

namespace Motorola.MackinawCPS.CoreFeatures.MissionCriticalGeofence
{
	// Token: 0x0200026D RID: 621
	public class PageMissionCriticalGeofence : global::AcpUI.AcpPageFeature, global::System.Windows.Markup.IComponentConnector, global::System.Windows.Markup.IStyleConnector
	{
		// Token: 0x06006EDE RID: 28382 RVA: 0x0062C1E8 File Offset: 0x0062A3E8
		public PageMissionCriticalGeofence()
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

		// Token: 0x06006EDF RID: 28383 RVA: 0x0062C220 File Offset: 0x0062A420
		public override void OnLoaded(object sender, global::System.Windows.RoutedEventArgs e)
		{
			short num = (short)1408892928;
			int num2 = (int)num;
			switch (num2)
			{
			default:
				num = (short)2095448065;
				num2 = (int)((global::System.IntPtr)num);
				for (;;)
				{
					global::AcpUI.AcpExpander acpExpander;
					global::System.Collections.IEnumerator enumerator;
					switch (num2)
					{
					case 0:
					{
						object obj;
						if (obj != null)
						{
							num = (short)495517700;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_AE;
					}
					case 1:
					{
						num = (short)698089472;
						short num3 = num;
						switch (0)
						{
						case 0:
							goto IL_8A;
						}
						continue;
					}
					case 2:
						goto IL_188;
					case 3:
					{
						this.RecNavToolbarPageMissionCriticalGeofence.ChildToolbars.Add(this.RecNavToolbarExpanderMissionCriticalGeofenceCoordinates);
						object obj = null;
						obj = this.RecNavToolbarExpanderMissionCriticalGeofenceCoordinates.MyRecordsetDataSource;
						num = (short)710279168;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 4:
					{
						object obj;
						global::System.Windows.Data.CollectionView collectionView = (global::System.Windows.Data.CollectionView)global::System.Windows.Data.CollectionViewSource.GetDefaultView(obj);
						this.RecNavToolbarExpanderMissionCriticalGeofenceCoordinates.MyDataPresenter = this.ExpanderMissionCriticalGeofenceCoordinates;
						num = (short)2028863494;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 5:
						try
						{
							num = (short)56688641;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								switch (num2)
								{
								case 0:
									goto IL_254;
								case 1:
									goto IL_1DC;
								case 2:
									base.Expanders.Add(acpExpander);
									num = (short)61800448;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 3:
									if (!enumerator.MoveNext())
									{
										num = (short)95354885;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									acpExpander = (((global::System.Windows.UIElement)enumerator.Current) as global::AcpUI.AcpExpander);
									num = (short)1856700420;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 4:
									if (acpExpander != null)
									{
										num = (short)1046085634;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									goto IL_254;
								case 5:
									num = (short)2085945350;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 6:
									goto IL_319;
								}
								goto IL_209;
								IL_1DC:
								switch (0)
								{
								case 0:
								{
									IL_209:
									num = (short)1131475893;
									short num4 = num;
									num = (short)548664245;
									switch ((num4 == num) ? 1 : 0)
									{
									case 0:
									case 2:
										goto IL_1DC;
									default:
										num = (short)631308288;
										if (num != 0)
										{
										}
										goto IL_254;
									}
									break;
								}
								}
								continue;
								IL_254:
								num = (short)1289748483;
								num2 = (int)((global::System.IntPtr)num);
							}
							IL_319:
							goto IL_161;
						}
						finally
						{
							switch (0)
							{
							case 0:
								goto IL_33B;
							}
							global::System.IDisposable disposable;
							for (;;)
							{
								IL_328:
								switch (num2)
								{
								case 0:
									disposable.Dispose();
									num = (short)2138243074;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 1:
									if (disposable != null)
									{
										num = (short)177930240;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									goto IL_38E;
								case 2:
									goto IL_38C;
								}
								goto IL_33B;
							}
							IL_38C:
							IL_38E:
							goto EndFinally_8;
							IL_33B:
							disposable = (enumerator as global::System.IDisposable);
							num = (short)759955457;
							num2 = (int)((global::System.IntPtr)num);
							goto IL_328;
							EndFinally_8:;
						}
						goto IL_38F;
						IL_161:
						base.OnLoaded(sender, e);
						this.a = true;
						num = (short)1248591874;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 6:
						goto IL_AE;
					}
					IL_8A:
					if (!this.a)
					{
						num = (short)490209283;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					break;
					IL_AE:
					num = (short)1023475713;
					if (num != 0)
					{
					}
					acpExpander = null;
					enumerator = this.MyStackPanel.Children.GetEnumerator();
					num = (short)817758213;
					num2 = (int)((global::System.IntPtr)num);
				}
				IL_188:
				IL_38F:
				this.MyStackPanel.Children[0].Focus();
				return;
			}
		}

		// Token: 0x06006EE0 RID: 28384 RVA: 0x0062C5F0 File Offset: 0x0062A7F0
		public override void OnUnloaded(object sender, global::System.Windows.RoutedEventArgs e)
		{
			short num = (short)1443538907;
			short num2 = num;
			num = (short)1752606683;
			switch ((num2 == num) ? 1 : 0)
			{
			case 0:
			case 2:
				return;
			case 1:
				break;
			default:
			{
				num = (short)1516503040;
				short num3 = num;
				break;
			}
			}
			num = (short)1258815489;
			if (num != 0)
			{
			}
			num = (short)208273408;
			if (num != 0)
			{
			}
			switch (0)
			{
			case 0:
				goto IL_B8;
			}
			int num4;
			for (;;)
			{
				IL_A6:
				switch (num4)
				{
				case 0:
					base.OnUnloaded(sender, e);
					this.a = false;
					num = (short)1689255938;
					num4 = (int)((global::System.IntPtr)num);
					continue;
				case 1:
					if (this.a)
					{
						num = (short)1185021952;
						num4 = (int)((global::System.IntPtr)num);
						continue;
					}
					return;
				case 2:
					goto IL_140;
				}
				goto IL_B8;
			}
			IL_140:
			return;
			IL_B8:
			this.RecNavToolbarPageMissionCriticalGeofence.DataContext = null;
			this.RecNavToolbarExpanderMissionCriticalGeofenceCoordinates.DataContext = null;
			this.RecNavToolbarPageMissionCriticalGeofence.MyDataPresenter = null;
			this.RecNavToolbarExpanderMissionCriticalGeofenceCoordinates.MyDataPresenter = null;
			num = (short)1294204929;
			num4 = (int)((global::System.IntPtr)num);
			goto IL_A6;
		}

		// Token: 0x06006EE1 RID: 28385 RVA: 0x0062C740 File Offset: 0x0062A940
		public override void SetDataContext()
		{
			short num = (short)2125266944;
			int num2 = (int)((global::System.IntPtr)num);
			object feature;
			for (;;)
			{
				switch (num2)
				{
				case 0:
					switch (0)
					{
					case 0:
						goto IL_48;
					}
					continue;
				case 1:
					goto IL_1C6;
				case 2:
					goto IL_7F;
				case 3:
					base.DataContext = global::AcpCommonLib.AppInfoManager.DefaultDocument.GetFeature(4174);
					num = (short)279773186;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 4:
					goto IL_239;
				case 5:
					if (global::AcpCommonLib.AppInfoManager.AppMode == global::AcpCommonLib.ApplicationMode.CodeplugComparisonMode)
					{
						num = (short)1191444487;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_1A2;
				case 6:
					goto IL_7F;
				case 7:
					feature = global::AcpCommonLib.AppInfoManager.ComparatorDocument.GetFeature(4174);
					num = (short)354287624;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 8:
					if (feature != null)
					{
						num = (short)418512900;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					return;
				}
				IL_48:
				if (global::AcpCommonLib.AppInfoManager.AppMode == global::AcpCommonLib.ApplicationMode.CustomViewConfigurationMode)
				{
					num = (short)2114125827;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				base.DataContext = global::AcpCommonLib.FeatureManager.GetFeature(4174);
				num = (short)230359046;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_7F:
				num = (short)1460911611;
				short num3 = num;
				num = (short)1991359995;
				switch ((num3 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					IL_1A2:
					((global::AcpUILib.IAcpRecNavToolbar)this.RecNavToolbarPageMissionCriticalGeofence).MySecondaryRecordsetDataSource = null;
					num = (short)324337665;
					num2 = (int)((global::System.IntPtr)num);
					break;
				default:
				{
					num = (short)728629249;
					if (num != 0)
					{
					}
					num = (short)1401946112;
					if (num != 0)
					{
					}
					this.RecNavToolbarPageMissionCriticalGeofence.DataContext = (global::AcpCommonLib.IAcpRecordset)base.DataContext;
					num = (short)1390149632;
					short num4 = num;
					num = (short)1953824773;
					num2 = (int)((global::System.IntPtr)num);
					break;
				}
				}
			}
			IL_1C6:
			return;
			IL_239:
			((global::AcpUILib.IAcpRecNavToolbar)this.RecNavToolbarPageMissionCriticalGeofence).MySecondaryRecordsetDataSource = (global::AcpCommonLib.IAcpRecordset)feature;
		}

		// Token: 0x06006EE2 RID: 28386 RVA: 0x0062C98C File Offset: 0x0062AB8C
		private void OnModeClick(object A_0, global::System.Windows.RoutedEventArgs A_1)
		{
			int a_ = 3;
			short num = (short)1220935680;
			switch (num)
			{
			default:
			{
				num = (short)668729354;
				int num2 = (int)((global::System.IntPtr)num);
				for (;;)
				{
					global::Motorola.MackinawCPS.CoreFeatures.MissionCriticalGeofence.CoordinatesInner coordinatesInner;
					switch (num2)
					{
					case 0:
					{
						global::System.Windows.Data.CollectionView collectionView;
						if (collectionView.IsCurrentAfterLast)
						{
							num = (short)172752902;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						collectionView.MoveCurrentToFirst();
						num = (short)1474625553;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 1:
						goto IL_130;
					case 2:
						goto IL_2A4;
					case 3:
						goto IL_258;
					case 4:
					{
						object myRecordsetDataSource;
						global::System.Windows.Data.CollectionView collectionView = (global::System.Windows.Data.CollectionView)global::System.Windows.Data.CollectionViewSource.GetDefaultView(myRecordsetDataSource);
						coordinatesInner = (global::Motorola.MackinawCPS.CoreFeatures.MissionCriticalGeofence.CoordinatesInner)collectionView.CurrentItem;
						num = (short)1310723;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 5:
					{
						global::System.Windows.Data.CollectionView collectionView;
						collectionView.MoveCurrentTo(coordinatesInner);
						num = (short)2084765697;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 6:
					{
						global::System.Windows.Data.CollectionView collectionView;
						collectionView.MoveCurrentToLast();
						num = (short)161677328;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 7:
						if (((global::AcpUI.AcpRecNavToolbar)A_0).Name == global::AllFeatures.CodeplugGuid.b("雃ꏅꯇ蓉귋룍蓏뷑믓뫕뫗믙껛軝臟藡臣ꯥ臧駩鿫蟭鿯鳱럳蓵釷軹闻鷽懿渁䌃挅朇氉椋怍猏眑", a_))
						{
							num = (short)1903296534;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_2A4;
					case 8:
					{
						object myRecordsetDataSource;
						if (myRecordsetDataSource != null)
						{
							num = (short)1720320004;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return;
					}
					case 9:
						num = (short)1095958535;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 10:
						switch (0)
						{
						case 0:
							goto IL_A8;
						}
						continue;
					case 11:
					{
						global::AcpCommonLib.IAcpRecordset myRecordsetDataSource2;
						base.NavigationService.Navigate(new global::System.Uri(myRecordsetDataSource2.UIPagePath, global::System.UriKind.RelativeOrAbsolute));
						num = (short)1808793602;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 12:
					{
						num = (short)918813869;
						short num3 = num;
						num = (short)1171782829;
						switch ((num3 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_258;
						default:
						{
							num = (short)371851264;
							if (num != 0)
							{
							}
							global::System.Windows.Data.CollectionView collectionView;
							if (collectionView.Count > 0)
							{
								num = (short)815595533;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							goto IL_300;
						}
						}
						break;
					}
					case 13:
						num = (short)277544960;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 14:
						if (((global::AcpUI.AcpRecNavToolbar)A_0).TableMode)
						{
							num = (short)1949433876;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						((global::AcpUI.AcpRecNavToolbar)A_0).TableMode = true;
						num = (short)1437925397;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 15:
						if (((global::AcpUI.AcpRecNavToolbar)A_0).Name == global::AllFeatures.CodeplugGuid.b("雃ꏅꯇ蓉귋룍蓏뷑믓뫕뫗믙껛鯝食鋡藣裥賧迩黫ꏭ駯臱蟳鿵韷铹뿻賽槿瘁洃攅椇昉䬋欍缏琑焓砕笗缙弛焝伟倡䀣伥䘧䬩堫䬭䌯", a_))
						{
							num = (short)770310162;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return;
					case 16:
						goto IL_1F9;
					case 17:
						goto IL_18A;
					case 18:
						num = (short)1703542798;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 19:
					{
						global::AcpCommonLib.IAcpRecordset myRecordsetDataSource2;
						if (myRecordsetDataSource2 != null)
						{
							num = (short)1719009291;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_2A4;
					}
					case 20:
					{
						((global::AcpUI.AcpRecNavToolbar)A_0).TableMode = false;
						object myRecordsetDataSource = this.RecNavToolbarExpanderMissionCriticalGeofenceCoordinates.MyRecordsetDataSource;
						num = (short)282722312;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 21:
						goto IL_222;
					case 22:
					{
						global::AcpCommonLib.IAcpRecordset myRecordsetDataSource2 = this.RecNavToolbarPageMissionCriticalGeofence.MyRecordsetDataSource;
						num = (short)134545427;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					}
					IL_A8:
					if (A_0 is global::AcpUI.AcpRecNavToolbar)
					{
						num = (short)1734541321;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					return;
					IL_258:
					num = (short)673382400;
					short num4 = num;
					if (coordinatesInner != null)
					{
						num = (short)81002501;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					num = (short)294977537;
					if (num != 0)
					{
					}
					num = (short)792985612;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_2A4:
					num = (short)97583119;
					num2 = (int)((global::System.IntPtr)num);
				}
				IL_130:
				IL_18A:
				IL_1F9:
				goto IL_300;
				IL_222:
				return;
				IL_300:
				((global::AcpUI.AcpRecNavToolbar)A_0).SyncDataSources();
				return;
			}
			}
		}

		// Token: 0x06006EE3 RID: 28387 RVA: 0x0062CE48 File Offset: 0x0062B048
		private void HLinkClick(object A_0, global::System.Windows.RoutedEventArgs A_1)
		{
			short num = (short)1589072534;
			short num2 = num;
			num = (short)304632470;
			switch (num2 == num)
			{
			}
			num = (short)1826881536;
			short num3 = num;
			num = (short)498597888;
			if (num != 0)
			{
			}
			num = (short)612040705;
			if (num != 0)
			{
			}
			base.OnHLinkClick(A_0);
		}

		// Token: 0x06006EE4 RID: 28388 RVA: 0x0062CEF4 File Offset: 0x0062B0F4
		private void ImportMapClick(object A_0, global::System.Windows.RoutedEventArgs A_1)
		{
			short num = (short)1879024115;
			short num2 = num;
			num = (short)1550754291;
			switch (num2 == num)
			{
			}
			num = (short)743964672;
			short num3 = num;
			num = (short)697237505;
			if (num != 0)
			{
			}
			num = (short)6946816;
			if (num != 0)
			{
			}
			global::ConstraintHelper.UtilityMack.ImportExportMap(this.GeofenceAliasName_42867.Value, true);
		}

		// Token: 0x06006EE5 RID: 28389 RVA: 0x0062CFB0 File Offset: 0x0062B1B0
		private void ExportMapClick(object A_0, global::System.Windows.RoutedEventArgs A_1)
		{
			short num = (short)1617715611;
			short num2 = num;
			num = (short)1658413467;
			switch (num2 == num)
			{
			}
			num = (short)87752704;
			short num3 = num;
			num = (short)451608576;
			if (num != 0)
			{
			}
			num = (short)1910898689;
			if (num != 0)
			{
			}
			global::ConstraintHelper.UtilityMack.ImportExportMap(this.GeofenceAliasName_42867.Value, false);
		}

		// Token: 0x06006EE6 RID: 28390 RVA: 0x0062D068 File Offset: 0x0062B268
		private void OnFieldNameDoubleClick(object A_0, global::System.Windows.RoutedEventArgs A_1)
		{
			short num = (short)2059468801;
			if (num != 0)
			{
			}
			num = (short)1822150082;
			short num2 = num;
			num = (short)1943195074;
			switch (num2 == num)
			{
			default:
			{
				num = (short)1453326336;
				short num3 = num;
				break;
			}
			case true:
				break;
			}
			num = (short)13041664;
			if (num != 0)
			{
			}
			global::AcpUI.Common.Utility.GetFieldHelpText(A_0);
		}

		// Token: 0x06006EE7 RID: 28391 RVA: 0x0062D118 File Offset: 0x0062B318
		internal void OnExpanderMissionCriticalGeofenceCoordinatesClick(object sender, global::System.Windows.RoutedEventArgs e)
		{
			switch (0)
			{
			case 0:
				goto IL_1C;
			}
			int num;
			short num2;
			object myRecordsetDataSource;
			global::Motorola.MackinawCPS.CoreFeatures.MissionCriticalGeofence.CoordinatesInner item;
			for (;;)
			{
				IL_0A:
				switch (num)
				{
				case 0:
				{
					num2 = (short)1473773569;
					if (num2 != 0)
					{
					}
					num2 = (short)2116321805;
					short num3 = num2;
					num2 = (short)452035085;
					switch ((num3 == num2) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_67;
					default:
					{
						num2 = (short)1201864704;
						if (num2 != 0)
						{
						}
						((global::System.Windows.Data.CollectionView)global::System.Windows.Data.CollectionViewSource.GetDefaultView(myRecordsetDataSource)).MoveCurrentTo(item);
						this.RecNavToolbarExpanderMissionCriticalGeofenceCoordinates.SyncDataSources();
						num2 = (short)1307770880;
						short num4 = num2;
						num2 = (short)1153499137;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					}
					break;
				}
				case 1:
					goto IL_14D;
				case 2:
					if (myRecordsetDataSource != null)
					{
						goto IL_67;
					}
					goto IL_14F;
				}
				goto IL_1C;
				IL_67:
				num2 = (short)484900864;
				num = (int)((global::System.IntPtr)num2);
			}
			IL_14D:
			IL_14F:
			this.RecNavToolbarExpanderMissionCriticalGeofenceCoordinates.TableMode = false;
			return;
			IL_1C:
			item = (global::Motorola.MackinawCPS.CoreFeatures.MissionCriticalGeofence.CoordinatesInner)((global::Infragistics.Windows.DataPresenter.CellValuePresenter)((global::AcpUI.AcpButton)e.Source).TemplatedParent).Record.DataItem;
			myRecordsetDataSource = this.RecNavToolbarExpanderMissionCriticalGeofenceCoordinates.MyRecordsetDataSource;
			num2 = (short)973340674;
			num = (int)((global::System.IntPtr)num2);
			goto IL_0A;
		}

		// Token: 0x06006EE8 RID: 28392 RVA: 0x0062D280 File Offset: 0x0062B480
		[global::System.CodeDom.Compiler.GeneratedCode("PresentationBuildTasks", "5.0.10.0")]
		[global::System.Diagnostics.DebuggerNonUserCode]
		public void InitializeComponent()
		{
			int a_ = 18;
			if (this.b)
			{
				short num = (short)1757055084;
				short num2 = num;
				num = (short)2125826156;
				switch ((num2 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					break;
				default:
				{
					num = (short)1780219905;
					if (num != 0)
					{
					}
					num = (short)103219200;
					short num3 = num;
					num = (short)565313536;
					if (num != 0)
					{
					}
					break;
				}
				}
				return;
			}
			this.b = true;
			global::System.Uri resourceLocator = new global::System.Uri(global::AllFeatures.CodeplugGuid.b("ﳒ铔믖뗘鷚룜뻞闠離韤苦髨탪軬胮鳰菲髴駶鳸闺觼탾猀戂愄渆昈⸊㼌㼎琐愒爔砖眘琚瀜瘞䈠倢$ᔦᤨ䠪䈬䄮地娲刴䈶䬸娺䤼嘾⹀ⵂ橄⩆⁈㡊㹌♎㹐㵒灔敖楘㡚⽜㙞ᕠ੢٤٦ը乪彬彮ᙰᙲᩴᅶᱸᕺṼ᩾꺀愈ﲔﲜ욠욢쪤솦첨얪캬쪮龰쮲풴\udab6햸", a_), global::System.UriKind.Relative);
			global::System.Windows.Application.LoadComponent(this, resourceLocator);
		}

		// Token: 0x06006EE9 RID: 28393 RVA: 0x0062D364 File Offset: 0x0062B564
		[global::System.Diagnostics.DebuggerNonUserCode]
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		[global::System.CodeDom.Compiler.GeneratedCode("PresentationBuildTasks", "5.0.10.0")]
		void global::System.Windows.Markup.IComponentConnector.Connect(int connectionId, object target)
		{
			short num = (short)1372651522;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				switch (num2)
				{
				case 0:
					num = (short)2082603009;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 1:
					goto IL_25E;
				case 2:
					switch (0)
					{
					case 0:
						goto IL_31;
					}
					continue;
				}
				IL_31:
				switch (connectionId)
				{
				case 1:
					goto IL_3E7;
				case 2:
					goto IL_47D;
				case 3:
				case 4:
					goto IL_6E9;
				case 5:
					goto IL_6DC;
				case 6:
					goto IL_4EC;
				case 7:
					goto IL_646;
				case 8:
					goto IL_470;
				case 9:
					goto IL_182;
				case 10:
					goto IL_4D2;
				case 11:
					goto IL_270;
				case 12:
					goto IL_5CD;
				case 13:
					goto IL_263;
				case 14:
					goto IL_168;
				case 15:
					goto IL_354;
				case 16:
					goto IL_1E4;
				case 17:
					goto IL_3CD;
				case 18:
					goto IL_27D;
				case 19:
					goto IL_3C0;
				case 20:
					goto IL_39C;
				case 21:
					goto IL_330;
				case 22:
					goto IL_4C5;
				case 23:
					goto IL_510;
				case 24:
					goto IL_43C;
				case 25:
					goto IL_316;
				case 26:
					goto IL_2F2;
				case 27:
					goto IL_222;
				case 28:
					goto IL_52A;
				case 29:
					goto IL_456;
				case 30:
					goto IL_6A8;
				case 31:
					goto IL_615;
				case 32:
					goto IL_418;
				case 33:
					goto IL_684;
				case 34:
					goto IL_3DA;
				case 35:
					goto IL_677;
				case 36:
					goto IL_15B;
				case 37:
					goto IL_1D7;
				case 38:
					goto IL_622;
				case 39:
					goto IL_5F1;
				case 40:
					goto IL_323;
				case 41:
					goto IL_6B5;
				case 42:
					goto IL_51D;
				case 43:
					goto IL_1A6;
				case 44:
					goto IL_14E;
				case 45:
					goto IL_6C2;
				case 46:
					goto IL_55B;
				case 47:
					goto IL_66A;
				case 48:
					goto IL_449;
				case 49:
					goto IL_2E5;
				case 50:
					goto IL_4DF;
				case 51:
					goto IL_378;
				case 52:
					goto IL_175;
				case 53:
					goto IL_537;
				case 54:
					goto IL_463;
				case 55:
					goto IL_208;
				case 56:
					goto IL_2D8;
				case 57:
					goto IL_1B3;
				case 58:
					goto IL_5B3;
				case 59:
					goto IL_4A1;
				case 60:
					goto IL_5C0;
				case 61:
					goto IL_215;
				case 62:
					goto IL_6CF;
				default:
					num = (short)1043398656;
					num2 = (int)((global::System.IntPtr)num);
					break;
				}
			}
			IL_14E:
			this.ExpanderMissionCriticalGeofenceCoordinatesGrid = (global::System.Windows.Controls.Grid)target;
			return;
			IL_15B:
			this.McGeofenceEntryAction_42887Comp = (global::AcpUI.AcpLabel)target;
			return;
			IL_168:
			this.CVBtnGeofenceAliasName_42867 = (global::AcpUI.AcpCustomViewCheckBox)target;
			return;
			IL_175:
			this.CVBtnMcGeofenceLongitude_42893 = (global::AcpUI.AcpCustomViewCheckBox)target;
			return;
			IL_182:
			this.BtnExportMap = (global::System.Windows.Controls.Button)target;
			this.BtnExportMap.Click += this.ExportMapClick;
			return;
			IL_1A6:
			this.ExpanderMissionCriticalGeofenceGeneralGrid = (global::System.Windows.Controls.Grid)target;
			return;
			IL_1B3:
			this.McGeofenceLatitude_42894 = (global::AcpUI.AcpTextBox)target;
			this.McGeofenceLatitude_42894.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_1D7:
			this.CVBtnMcGeofenceExitAction_42888 = (global::AcpUI.AcpCustomViewCheckBox)target;
			return;
			IL_1E4:
			this.GeofenceAliasName_42867 = (global::AcpUI.AcpTextBox)target;
			this.GeofenceAliasName_42867.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_208:
			this.CpyBtnMcGeofenceLongitude_42893 = (global::AcpUI.AcpCopyButton)target;
			return;
			IL_215:
			this.CpyBtnMcGeofenceLatitude_42894 = (global::AcpUI.AcpCopyButton)target;
			return;
			IL_222:
			this.McGeofenceRadiusInMeters_42890 = (global::AcpUI.AcpTextBoxSpinner)target;
			this.McGeofenceRadiusInMeters_42890.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_25E:
			goto IL_6E9;
			IL_263:
			this.GrpBoxExpanderMissionCriticalGeofenceGeneralPseudo0 = (global::AcpUI.AcpGroupBox)target;
			return;
			IL_270:
			this.ExpanderMissionCriticalGeofenceGeneral = (global::AcpUI.AcpExpander)target;
			return;
			IL_27D:
			num = (short)1140195329;
			if (num != 0)
			{
			}
			num = (short)1943404544;
			short num3 = num;
			this.GeofenceAliasName_42867Comp = (global::AcpUI.AcpLabel)target;
			return;
			IL_2D8:
			this.McGeofenceLongitude_42893Comp = (global::AcpUI.AcpLabel)target;
			return;
			IL_2E5:
			this.ExpanderMissionCriticalGeofenceCoordinatesSRecView = (global::AcpUI.AcpGroupBox)target;
			return;
			IL_2F2:
			this.LblMcGeofenceRadiusInMeters_42890 = (global::AcpUI.AcpLabel)target;
			this.LblMcGeofenceRadiusInMeters_42890.MouseDoubleClick += new global::System.Windows.Input.MouseButtonEventHandler(this.OnFieldNameDoubleClick);
			return;
			IL_316:
			this.CVBtnMcGeofenceRadiusInMeters_42890 = (global::AcpUI.AcpCustomViewCheckBox)target;
			return;
			IL_323:
			this.RTDBtnMcGeofenceExitAction_42888 = (global::AcpUI.AcpRtdButton)target;
			return;
			IL_330:
			this.McGeofencePriority_42879 = (global::AcpUI.AcpTextBoxSpinner)target;
			this.McGeofencePriority_42879.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_354:
			this.LblGeofenceAliasName_42867 = (global::AcpUI.AcpLabel)target;
			this.LblGeofenceAliasName_42867.MouseDoubleClick += new global::System.Windows.Input.MouseButtonEventHandler(this.OnFieldNameDoubleClick);
			return;
			IL_378:
			this.McGeofenceLongitude_42893 = (global::AcpUI.AcpTextBox)target;
			this.McGeofenceLongitude_42893.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_39C:
			this.LblMcGeofencePriority_42879 = (global::AcpUI.AcpLabel)target;
			this.LblMcGeofencePriority_42879.MouseDoubleClick += new global::System.Windows.Input.MouseButtonEventHandler(this.OnFieldNameDoubleClick);
			return;
			IL_3C0:
			this.CVBtnMcGeofencePriority_42879 = (global::AcpUI.AcpCustomViewCheckBox)target;
			return;
			IL_3CD:
			this.CpyBtnGeofenceAliasName_42867 = (global::AcpUI.AcpCopyButton)target;
			return;
			IL_3DA:
			this.RTDBtnMcGeofenceEntryAction_42887 = (global::AcpUI.AcpRtdButton)target;
			return;
			IL_3E7:
			((global::Motorola.MackinawCPS.CoreFeatures.MissionCriticalGeofence.PageMissionCriticalGeofence)target).Loaded += this.OnLoaded;
			((global::Motorola.MackinawCPS.CoreFeatures.MissionCriticalGeofence.PageMissionCriticalGeofence)target).Unloaded += this.OnUnloaded;
			return;
			IL_418:
			this.LblMcGeofenceEntryAction_42887 = (global::AcpUI.AcpLabel)target;
			this.LblMcGeofenceEntryAction_42887.MouseDoubleClick += new global::System.Windows.Input.MouseButtonEventHandler(this.OnFieldNameDoubleClick);
			return;
			IL_43C:
			this.McGeofencePriority_42879Comp = (global::AcpUI.AcpLabel)target;
			return;
			IL_449:
			this.McGeofenceLatitude_42894_Col = (global::Infragistics.Windows.DataPresenter.UnboundField)target;
			return;
			IL_456:
			this.CpyBtnMcGeofenceRadiusInMeters_42890 = (global::AcpUI.AcpCopyButton)target;
			return;
			IL_463:
			this.RTDBtnMcGeofenceLongitude_42893 = (global::AcpUI.AcpRtdButton)target;
			return;
			IL_470:
			this.Temp = (global::System.Windows.Controls.Button)target;
			return;
			IL_47D:
			this.RecNavToolbarPageMissionCriticalGeofence = (global::AcpUI.AcpParentRecNavToolbar)target;
			this.RecNavToolbarPageMissionCriticalGeofence.ModeClick += this.OnModeClick;
			return;
			IL_4A1:
			this.LblMcGeofenceLatitude_42894 = (global::AcpUI.AcpLabel)target;
			this.LblMcGeofenceLatitude_42894.MouseDoubleClick += new global::System.Windows.Input.MouseButtonEventHandler(this.OnFieldNameDoubleClick);
			return;
			IL_4C5:
			this.RTDBtnMcGeofencePriority_42879 = (global::AcpUI.AcpRtdButton)target;
			return;
			IL_4D2:
			this.MyStackPanel = (global::System.Windows.Controls.StackPanel)target;
			return;
			IL_4DF:
			this.gridExpanderMissionCriticalGeofenceCoordinatesSRecView = (global::System.Windows.Controls.Grid)target;
			return;
			IL_4EC:
			this.HLinkGeneral = (global::System.Windows.Documents.Hyperlink)target;
			this.HLinkGeneral.Click += this.HLinkClick;
			return;
			IL_510:
			this.CpyBtnMcGeofencePriority_42879 = (global::AcpUI.AcpCopyButton)target;
			return;
			IL_51D:
			this.McGeofenceExitAction_42888Comp = (global::AcpUI.AcpLabel)target;
			return;
			IL_52A:
			this.RTDBtnMcGeofenceRadiusInMeters_42890 = (global::AcpUI.AcpRtdButton)target;
			return;
			IL_537:
			this.LblMcGeofenceLongitude_42893 = (global::AcpUI.AcpLabel)target;
			this.LblMcGeofenceLongitude_42893.MouseDoubleClick += new global::System.Windows.Input.MouseButtonEventHandler(this.OnFieldNameDoubleClick);
			return;
			IL_55B:
			num = (short)1884024015;
			short num4 = num;
			num = (short)1736371407;
			switch ((num4 == num) ? 1 : 0)
			{
			case 0:
			case 2:
				goto IL_1A6;
			default:
				num = (short)147914752;
				if (num != 0)
				{
				}
				this.ExpanderMissionCriticalGeofenceCoordinates = (global::AcpUI.AcpXamDataPresenter)target;
				return;
			}
			IL_5B3:
			this.CVBtnMcGeofenceLatitude_42894 = (global::AcpUI.AcpCustomViewCheckBox)target;
			return;
			IL_5C0:
			this.RTDBtnMcGeofenceLatitude_42894 = (global::AcpUI.AcpRtdButton)target;
			return;
			IL_5CD:
			this.RecNavToolbarExpanderMissionCriticalGeofenceCoordinates = (global::AcpUI.AcpChildRecNavToolbar)target;
			this.RecNavToolbarExpanderMissionCriticalGeofenceCoordinates.ModeClick += this.OnModeClick;
			return;
			IL_5F1:
			this.McGeofenceExitAction_42888 = (global::AcpUI.AcpComboBox)target;
			this.McGeofenceExitAction_42888.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_615:
			this.CVBtnMcGeofenceEntryAction_42887 = (global::AcpUI.AcpCustomViewCheckBox)target;
			return;
			IL_622:
			this.LblMcGeofenceExitAction_42888 = (global::AcpUI.AcpLabel)target;
			this.LblMcGeofenceExitAction_42888.MouseDoubleClick += new global::System.Windows.Input.MouseButtonEventHandler(this.OnFieldNameDoubleClick);
			return;
			IL_646:
			this.BtnImportMap = (global::System.Windows.Controls.Button)target;
			this.BtnImportMap.Click += this.ImportMapClick;
			return;
			IL_66A:
			this.McGeofenceLongitude_42893_Col = (global::Infragistics.Windows.DataPresenter.UnboundField)target;
			return;
			IL_677:
			this.CpyBtnMcGeofenceEntryAction_42887 = (global::AcpUI.AcpCopyButton)target;
			return;
			IL_684:
			this.McGeofenceEntryAction_42887 = (global::AcpUI.AcpComboBox)target;
			this.McGeofenceEntryAction_42887.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_6A8:
			this.McGeofenceRadiusInMeters_42890Comp = (global::AcpUI.AcpLabel)target;
			return;
			IL_6B5:
			this.CpyBtnMcGeofenceExitAction_42888 = (global::AcpUI.AcpCopyButton)target;
			return;
			IL_6C2:
			this.ExpanderMissionCriticalGeofenceCoordinatesTableView = (global::AcpUI.AcpGroupBox)target;
			return;
			IL_6CF:
			this.McGeofenceLatitude_42894Comp = (global::AcpUI.AcpLabel)target;
			return;
			IL_6DC:
			this.ThemeBaseObj = (global::AcpUI.Common.AcpThemeBase)target;
			return;
			IL_6E9:
			this.b = true;
		}

		// Token: 0x06006EEA RID: 28394 RVA: 0x0062DA64 File Offset: 0x0062BC64
		[global::System.Diagnostics.DebuggerNonUserCode]
		[global::System.CodeDom.Compiler.GeneratedCode("PresentationBuildTasks", "5.0.10.0")]
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		void global::System.Windows.Markup.IStyleConnector.Connect(int connectionId, object target)
		{
			short num = (short)782368771;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				switch (num2)
				{
				case 0:
					goto IL_92;
				case 1:
				{
					if (connectionId != 4)
					{
						num = (short)769654786;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					num = (short)1887400852;
					short num3 = num;
					num = (short)1745056660;
					switch ((num3 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_92;
					default:
						goto IL_FB;
					}
					break;
				}
				case 2:
					return;
				case 3:
					switch (0)
					{
					case 0:
						goto IL_36;
					}
					continue;
				}
				IL_36:
				if (connectionId != 3)
				{
					num = (short)459538433;
					if (num != 0)
					{
					}
					num = (short)113770496;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				break;
				IL_92:
				num = (short)114753537;
				num2 = (int)((global::System.IntPtr)num);
			}
			((global::AcpUI.AcpTableTextBox)target).GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_FB:
			num = (short)2029649920;
			short num4 = num;
			num = (short)1460207616;
			if (num != 0)
			{
			}
			((global::AcpUI.AcpTableTextBox)target).GotFocus += this.OnFieldNameDoubleClick;
		}

		// Token: 0x04002AF1 RID: 10993
		private bool a;

		// Token: 0x04002AF2 RID: 10994
		internal global::AcpUI.AcpParentRecNavToolbar RecNavToolbarPageMissionCriticalGeofence;

		// Token: 0x04002AF3 RID: 10995
		internal global::AcpUI.Common.AcpThemeBase ThemeBaseObj;

		// Token: 0x04002AF4 RID: 10996
		internal global::System.Windows.Documents.Hyperlink HLinkGeneral;

		// Token: 0x04002AF5 RID: 10997
		internal global::System.Windows.Controls.Button BtnImportMap;

		// Token: 0x04002AF6 RID: 10998
		internal global::System.Windows.Controls.Button Temp;

		// Token: 0x04002AF7 RID: 10999
		internal global::System.Windows.Controls.Button BtnExportMap;

		// Token: 0x04002AF8 RID: 11000
		internal global::System.Windows.Controls.StackPanel MyStackPanel;

		// Token: 0x04002AF9 RID: 11001
		internal global::AcpUI.AcpExpander ExpanderMissionCriticalGeofenceGeneral;

		// Token: 0x04002AFA RID: 11002
		internal global::AcpUI.AcpChildRecNavToolbar RecNavToolbarExpanderMissionCriticalGeofenceCoordinates;

		// Token: 0x04002AFB RID: 11003
		internal global::AcpUI.AcpGroupBox GrpBoxExpanderMissionCriticalGeofenceGeneralPseudo0;

		// Token: 0x04002AFC RID: 11004
		internal global::AcpUI.AcpCustomViewCheckBox CVBtnGeofenceAliasName_42867;

		// Token: 0x04002AFD RID: 11005
		internal global::AcpUI.AcpLabel LblGeofenceAliasName_42867;

		// Token: 0x04002AFE RID: 11006
		internal global::AcpUI.AcpTextBox GeofenceAliasName_42867;

		// Token: 0x04002AFF RID: 11007
		internal global::AcpUI.AcpCopyButton CpyBtnGeofenceAliasName_42867;

		// Token: 0x04002B00 RID: 11008
		internal global::AcpUI.AcpLabel GeofenceAliasName_42867Comp;

		// Token: 0x04002B01 RID: 11009
		internal global::AcpUI.AcpCustomViewCheckBox CVBtnMcGeofencePriority_42879;

		// Token: 0x04002B02 RID: 11010
		internal global::AcpUI.AcpLabel LblMcGeofencePriority_42879;

		// Token: 0x04002B03 RID: 11011
		internal global::AcpUI.AcpTextBoxSpinner McGeofencePriority_42879;

		// Token: 0x04002B04 RID: 11012
		internal global::AcpUI.AcpRtdButton RTDBtnMcGeofencePriority_42879;

		// Token: 0x04002B05 RID: 11013
		internal global::AcpUI.AcpCopyButton CpyBtnMcGeofencePriority_42879;

		// Token: 0x04002B06 RID: 11014
		internal global::AcpUI.AcpLabel McGeofencePriority_42879Comp;

		// Token: 0x04002B07 RID: 11015
		internal global::AcpUI.AcpCustomViewCheckBox CVBtnMcGeofenceRadiusInMeters_42890;

		// Token: 0x04002B08 RID: 11016
		internal global::AcpUI.AcpLabel LblMcGeofenceRadiusInMeters_42890;

		// Token: 0x04002B09 RID: 11017
		internal global::AcpUI.AcpTextBoxSpinner McGeofenceRadiusInMeters_42890;

		// Token: 0x04002B0A RID: 11018
		internal global::AcpUI.AcpRtdButton RTDBtnMcGeofenceRadiusInMeters_42890;

		// Token: 0x04002B0B RID: 11019
		internal global::AcpUI.AcpCopyButton CpyBtnMcGeofenceRadiusInMeters_42890;

		// Token: 0x04002B0C RID: 11020
		internal global::AcpUI.AcpLabel McGeofenceRadiusInMeters_42890Comp;

		// Token: 0x04002B0D RID: 11021
		internal global::AcpUI.AcpCustomViewCheckBox CVBtnMcGeofenceEntryAction_42887;

		// Token: 0x04002B0E RID: 11022
		internal global::AcpUI.AcpLabel LblMcGeofenceEntryAction_42887;

		// Token: 0x04002B0F RID: 11023
		internal global::AcpUI.AcpComboBox McGeofenceEntryAction_42887;

		// Token: 0x04002B10 RID: 11024
		internal global::AcpUI.AcpRtdButton RTDBtnMcGeofenceEntryAction_42887;

		// Token: 0x04002B11 RID: 11025
		internal global::AcpUI.AcpCopyButton CpyBtnMcGeofenceEntryAction_42887;

		// Token: 0x04002B12 RID: 11026
		internal global::AcpUI.AcpLabel McGeofenceEntryAction_42887Comp;

		// Token: 0x04002B13 RID: 11027
		internal global::AcpUI.AcpCustomViewCheckBox CVBtnMcGeofenceExitAction_42888;

		// Token: 0x04002B14 RID: 11028
		internal global::AcpUI.AcpLabel LblMcGeofenceExitAction_42888;

		// Token: 0x04002B15 RID: 11029
		internal global::AcpUI.AcpComboBox McGeofenceExitAction_42888;

		// Token: 0x04002B16 RID: 11030
		internal global::AcpUI.AcpRtdButton RTDBtnMcGeofenceExitAction_42888;

		// Token: 0x04002B17 RID: 11031
		internal global::AcpUI.AcpCopyButton CpyBtnMcGeofenceExitAction_42888;

		// Token: 0x04002B18 RID: 11032
		internal global::AcpUI.AcpLabel McGeofenceExitAction_42888Comp;

		// Token: 0x04002B19 RID: 11033
		internal global::System.Windows.Controls.Grid ExpanderMissionCriticalGeofenceGeneralGrid;

		// Token: 0x04002B1A RID: 11034
		internal global::System.Windows.Controls.Grid ExpanderMissionCriticalGeofenceCoordinatesGrid;

		// Token: 0x04002B1B RID: 11035
		internal global::AcpUI.AcpGroupBox ExpanderMissionCriticalGeofenceCoordinatesTableView;

		// Token: 0x04002B1C RID: 11036
		internal global::AcpUI.AcpXamDataPresenter ExpanderMissionCriticalGeofenceCoordinates;

		// Token: 0x04002B1D RID: 11037
		internal global::Infragistics.Windows.DataPresenter.UnboundField McGeofenceLongitude_42893_Col;

		// Token: 0x04002B1E RID: 11038
		internal global::Infragistics.Windows.DataPresenter.UnboundField McGeofenceLatitude_42894_Col;

		// Token: 0x04002B1F RID: 11039
		internal global::AcpUI.AcpGroupBox ExpanderMissionCriticalGeofenceCoordinatesSRecView;

		// Token: 0x04002B20 RID: 11040
		internal global::System.Windows.Controls.Grid gridExpanderMissionCriticalGeofenceCoordinatesSRecView;

		// Token: 0x04002B21 RID: 11041
		internal global::AcpUI.AcpTextBox McGeofenceLongitude_42893;

		// Token: 0x04002B22 RID: 11042
		internal global::AcpUI.AcpCustomViewCheckBox CVBtnMcGeofenceLongitude_42893;

		// Token: 0x04002B23 RID: 11043
		internal global::AcpUI.AcpLabel LblMcGeofenceLongitude_42893;

		// Token: 0x04002B24 RID: 11044
		internal global::AcpUI.AcpRtdButton RTDBtnMcGeofenceLongitude_42893;

		// Token: 0x04002B25 RID: 11045
		internal global::AcpUI.AcpCopyButton CpyBtnMcGeofenceLongitude_42893;

		// Token: 0x04002B26 RID: 11046
		internal global::AcpUI.AcpLabel McGeofenceLongitude_42893Comp;

		// Token: 0x04002B27 RID: 11047
		internal global::AcpUI.AcpTextBox McGeofenceLatitude_42894;

		// Token: 0x04002B28 RID: 11048
		internal global::AcpUI.AcpCustomViewCheckBox CVBtnMcGeofenceLatitude_42894;

		// Token: 0x04002B29 RID: 11049
		internal global::AcpUI.AcpLabel LblMcGeofenceLatitude_42894;

		// Token: 0x04002B2A RID: 11050
		internal global::AcpUI.AcpRtdButton RTDBtnMcGeofenceLatitude_42894;

		// Token: 0x04002B2B RID: 11051
		internal global::AcpUI.AcpCopyButton CpyBtnMcGeofenceLatitude_42894;

		// Token: 0x04002B2C RID: 11052
		internal global::AcpUI.AcpLabel McGeofenceLatitude_42894Comp;

		// Token: 0x04002B2D RID: 11053
		private bool b;
	}
}
