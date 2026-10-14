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

namespace Motorola.MackinawCPS.CoreFeatures.VirtualPartnerAlert
{
	// Token: 0x020001B8 RID: 440
	public class PageVirtualPartnerAlert : global::AcpUI.AcpPageFeature, global::System.Windows.Markup.IComponentConnector, global::System.Windows.Markup.IStyleConnector
	{
		// Token: 0x060051A5 RID: 20901 RVA: 0x004A3294 File Offset: 0x004A1494
		public PageVirtualPartnerAlert()
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

		// Token: 0x060051A6 RID: 20902 RVA: 0x004A32CC File Offset: 0x004A14CC
		public override void OnLoaded(object sender, global::System.Windows.RoutedEventArgs e)
		{
			short num = (short)1539440640;
			int num2 = (int)num;
			switch (num2)
			{
			default:
			{
				num = (short)376373250;
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
						global::System.Windows.Data.CollectionView collectionView = (global::System.Windows.Data.CollectionView)global::System.Windows.Data.CollectionViewSource.GetDefaultView(obj);
						this.RecNavToolbarExpanderVirtualPartnerAlertAlertList.MyDataPresenter = this.ExpanderVirtualPartnerAlertAlertList;
						num = (short)36962309;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 1:
					{
						object obj;
						if (obj != null)
						{
							num = (short)1207894016;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_84;
					}
					case 2:
						switch (0)
						{
						case 0:
							goto IL_60;
						}
						continue;
					case 3:
						goto IL_132;
					case 4:
					{
						this.RecNavToolbarPageVirtualPartnerAlert.ChildToolbars.Add(this.RecNavToolbarExpanderVirtualPartnerAlertAlertList);
						object obj = null;
						obj = this.RecNavToolbarExpanderVirtualPartnerAlertAlertList.MyRecordsetDataSource;
						num = (short)762183681;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 5:
						goto IL_84;
					case 6:
						try
						{
							num = (short)845283330;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								switch (num2)
								{
								case 0:
									if (acpExpander != null)
									{
										num = (short)1152101985;
										short num3 = num;
										num = (short)1937223265;
										switch ((num3 == num) ? 1 : 0)
										{
										case 0:
										case 2:
											goto IL_263;
										default:
											num = (short)340787200;
											if (num != 0)
											{
											}
											num = (short)2107637763;
											num2 = (int)((global::System.IntPtr)num);
											continue;
										}
									}
									break;
								case 2:
									switch (0)
									{
									case 0:
										goto IL_204;
									}
									continue;
								case 3:
									base.Expanders.Add(acpExpander);
									num = (short)1482948609;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 4:
									if (!enumerator.MoveNext())
									{
										num = (short)97189894;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									goto IL_263;
								case 5:
									goto IL_313;
								case 6:
									num = (short)460193797;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								IL_206:
								num = (short)338362372;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								IL_204:
								goto IL_206;
								IL_263:
								acpExpander = (((global::System.Windows.UIElement)enumerator.Current) as global::AcpUI.AcpExpander);
								num = (short)990773248;
								num2 = (int)((global::System.IntPtr)num);
							}
							IL_313:
							goto IL_10A;
						}
						finally
						{
							switch (0)
							{
							case 0:
								goto IL_335;
							}
							global::System.IDisposable disposable;
							for (;;)
							{
								IL_322:
								switch (num2)
								{
								case 0:
									disposable.Dispose();
									num = (short)169476097;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 1:
									goto IL_387;
								case 2:
									if (disposable != null)
									{
										num = (short)1314717696;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									goto IL_389;
								}
								goto IL_335;
							}
							IL_387:
							IL_389:
							goto EndFinally_8;
							IL_335:
							disposable = (enumerator as global::System.IDisposable);
							num = (short)398196738;
							num2 = (int)((global::System.IntPtr)num);
							goto IL_322;
							EndFinally_8:;
						}
						goto IL_38A;
						IL_10A:
						base.OnLoaded(sender, e);
						this.a = true;
						num = (short)385351683;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					IL_60:
					if (!this.a)
					{
						num = (short)2078408708;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_38A;
					IL_84:
					acpExpander = null;
					enumerator = this.MyStackPanel.Children.GetEnumerator();
					num = (short)1715863558;
					num2 = (int)((global::System.IntPtr)num);
				}
				IL_132:
				num = (short)12320768;
				short num4 = num;
				num = (short)338624513;
				if (num != 0)
				{
				}
				IL_38A:
				this.MyStackPanel.Children[0].Focus();
				return;
			}
			}
		}

		// Token: 0x060051A7 RID: 20903 RVA: 0x004A3698 File Offset: 0x004A1898
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
					num2 = (short)1517486081;
					if (num2 != 0)
					{
					}
					goto IL_AA;
				case 1:
					goto IL_FE;
				case 2:
					if (this.a)
					{
						num2 = (short)57212928;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_FE;
				}
				goto IL_1C;
				IL_AA:
				num2 = (short)1084817408;
				short num3 = num2;
				base.OnUnloaded(sender, e);
				this.a = false;
				num2 = (short)1228406785;
				num = (int)((global::System.IntPtr)num2);
				continue;
				IL_FE:
				num2 = (short)787121804;
				short num4 = num2;
				num2 = (short)198149772;
				switch ((num4 == num2) ? 1 : 0)
				{
				case 0:
				case 2:
					goto IL_AA;
				default:
					goto IL_133;
				}
			}
			IL_133:
			num2 = (short)1285554176;
			if (num2 != 0)
			{
			}
			return;
			IL_1C:
			this.RecNavToolbarPageVirtualPartnerAlert.DataContext = null;
			this.RecNavToolbarExpanderVirtualPartnerAlertAlertList.DataContext = null;
			this.RecNavToolbarPageVirtualPartnerAlert.MyDataPresenter = null;
			this.RecNavToolbarExpanderVirtualPartnerAlertAlertList.MyDataPresenter = null;
			num2 = (short)1261240322;
			num = (int)((global::System.IntPtr)num2);
			goto IL_0A;
		}

		// Token: 0x060051A8 RID: 20904 RVA: 0x004A37F0 File Offset: 0x004A19F0
		public override void SetDataContext()
		{
			short num = (short)2075197444;
			int num2 = (int)((global::System.IntPtr)num);
			object feature;
			for (;;)
			{
				num = (short)1527119873;
				if (num != 0)
				{
				}
				switch (num2)
				{
				case 0:
					goto IL_1E3;
				case 1:
				{
					num = (short)1727004672;
					short num3 = num;
					goto IL_A2;
				}
				case 2:
					goto IL_1E8;
				case 3:
					goto IL_A2;
				case 4:
					switch (0)
					{
					case 0:
						goto IL_6F;
					}
					continue;
				case 5:
					IL_1C8:
					if (feature != null)
					{
						num = (short)2001076224;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_1E8;
				case 6:
					base.DataContext = global::AcpCommonLib.AppInfoManager.DefaultDocument.GetFeature(4231);
					num = (short)425394177;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 7:
					feature = global::AcpCommonLib.AppInfoManager.ComparatorDocument.GetFeature(4231);
					num = (short)1228472325;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 8:
					if (global::AcpCommonLib.AppInfoManager.AppMode == global::AcpCommonLib.ApplicationMode.CodeplugComparisonMode)
					{
						num = (short)90570759;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					((global::AcpUILib.IAcpRecNavToolbar)this.RecNavToolbarPageVirtualPartnerAlert).MySecondaryRecordsetDataSource = null;
					num = (short)242352130;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				IL_6F:
				if (global::AcpCommonLib.AppInfoManager.AppMode == global::AcpCommonLib.ApplicationMode.CustomViewConfigurationMode)
				{
					num = (short)376373254;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				base.DataContext = global::AcpCommonLib.FeatureManager.GetFeature(4231);
				num = (short)1512505347;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_A2:
				this.RecNavToolbarPageVirtualPartnerAlert.DataContext = (global::AcpCommonLib.IAcpRecordset)base.DataContext;
				num = (short)1292435464;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_1E8:
				num = (short)1753007285;
				short num4 = num;
				num = (short)414434485;
				switch ((num4 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					goto IL_1C8;
				default:
					goto IL_21D;
				}
			}
			IL_1E3:
			((global::AcpUILib.IAcpRecNavToolbar)this.RecNavToolbarPageVirtualPartnerAlert).MySecondaryRecordsetDataSource = (global::AcpCommonLib.IAcpRecordset)feature;
			return;
			IL_21D:
			num = (short)208142336;
			if (num != 0)
			{
			}
		}

		// Token: 0x060051A9 RID: 20905 RVA: 0x004A3A30 File Offset: 0x004A1C30
		private void OnModeClick(object A_0, global::System.Windows.RoutedEventArgs A_1)
		{
			int a_ = 4;
			short num = (short)1268776960;
			short num2 = num;
			num = (short)974848000;
			switch (num)
			{
			default:
			{
				num = (short)694878226;
				int num3 = (int)((global::System.IntPtr)num);
				for (;;)
				{
					switch (num3)
					{
					case 0:
					{
						if (!((global::AcpUI.AcpRecNavToolbar)A_0).TableMode)
						{
							((global::AcpUI.AcpRecNavToolbar)A_0).TableMode = true;
							num = (short)1352728597;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)1206200290;
						short num4 = num;
						num = (short)288761826;
						switch ((num4 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_234;
						default:
							num = (short)589561856;
							if (num != 0)
							{
							}
							num = (short)884080641;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						}
						break;
					}
					case 1:
					{
						((global::AcpUI.AcpRecNavToolbar)A_0).TableMode = false;
						object myRecordsetDataSource = this.RecNavToolbarExpanderVirtualPartnerAlertAlertList.MyRecordsetDataSource;
						num = (short)1344208905;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 2:
					{
						global::AcpCommonLib.IAcpRecordset myRecordsetDataSource2 = this.RecNavToolbarPageVirtualPartnerAlert.MyRecordsetDataSource;
						num = (short)440008708;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 3:
					{
						global::Motorola.MackinawCPS.CoreFeatures.VirtualPartnerAlert.AlertListInner alertListInner;
						if (alertListInner != null)
						{
							num = (short)1647640595;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)370475022;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 4:
					{
						global::AcpCommonLib.IAcpRecordset myRecordsetDataSource2;
						if (myRecordsetDataSource2 != null)
						{
							num = (short)1063321617;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_2D0;
					}
					case 5:
						goto IL_24C;
					case 6:
					{
						global::System.Windows.Data.CollectionView collectionView;
						collectionView.MoveCurrentToLast();
						goto IL_234;
					}
					case 7:
						num = (short)449773568;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					case 8:
						num = (short)413728779;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					case 9:
					{
						object myRecordsetDataSource;
						if (myRecordsetDataSource != null)
						{
							num = (short)968622096;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						}
						return;
					}
					case 10:
						num = (short)1612775437;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					case 11:
						if (((global::AcpUI.AcpRecNavToolbar)A_0).Name == global::AllFeatures.CodeplugGuid.b("韄ꋆ꫈藊곌많藐볒뫔믖믘뫚꿜连胠蓢胤뇦胨駪駬髮郰鿲ꗴ零诸迺鏼髾猀䈂椄戆笈缊", a_))
						{
							num = (short)2047803394;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_2D0;
					case 12:
						if (((global::AcpUI.AcpRecNavToolbar)A_0).Name == global::AllFeatures.CodeplugGuid.b("韄ꋆ꫈藊곌많藐볒뫔믖믘뫚꿜髞駠鏢蓤触跨軪鿬맮飰臲致苶飸韺근黾猀眂欄戆笈䨊愌樎挐朒吔笖簘椚検匞䠠倢儤", a_))
						{
							num = (short)476446727;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						}
						return;
					case 13:
					{
						global::System.Windows.Data.CollectionView collectionView;
						if (collectionView.IsCurrentAfterLast)
						{
							num = (short)2084306950;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						}
						collectionView.MoveCurrentToFirst();
						num = (short)1660289046;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 14:
					{
						global::System.Windows.Data.CollectionView collectionView;
						if (collectionView.Count > 0)
						{
							num = (short)1584267274;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_327;
					}
					case 15:
						goto IL_186;
					case 16:
					{
						object myRecordsetDataSource;
						global::System.Windows.Data.CollectionView collectionView = (global::System.Windows.Data.CollectionView)global::System.Windows.Data.CollectionViewSource.GetDefaultView(myRecordsetDataSource);
						global::Motorola.MackinawCPS.CoreFeatures.VirtualPartnerAlert.AlertListInner alertListInner = (global::Motorola.MackinawCPS.CoreFeatures.VirtualPartnerAlert.AlertListInner)collectionView.CurrentItem;
						num = (short)1577517059;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 17:
					{
						global::AcpCommonLib.IAcpRecordset myRecordsetDataSource2;
						base.NavigationService.Navigate(new global::System.Uri(myRecordsetDataSource2.UIPagePath, global::System.UriKind.RelativeOrAbsolute));
						num = (short)1748631572;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 18:
						num = (short)447479809;
						if (num != 0)
						{
						}
						switch (0)
						{
						case 0:
							goto IL_FD;
						}
						continue;
					case 19:
					{
						global::Motorola.MackinawCPS.CoreFeatures.VirtualPartnerAlert.AlertListInner alertListInner;
						global::System.Windows.Data.CollectionView collectionView;
						collectionView.MoveCurrentTo(alertListInner);
						num = (short)829685775;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 20:
						goto IL_2D0;
					case 21:
						goto IL_276;
					case 22:
						goto IL_1E0;
					}
					IL_FD:
					if (A_0 is global::AcpUI.AcpRecNavToolbar)
					{
						num = (short)329908232;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					}
					return;
					IL_234:
					num = (short)702742533;
					num3 = (int)((global::System.IntPtr)num);
					continue;
					IL_2D0:
					num = (short)950730764;
					num3 = (int)((global::System.IntPtr)num);
				}
				IL_186:
				IL_1E0:
				IL_24C:
				goto IL_327;
				IL_276:
				return;
				IL_327:
				((global::AcpUI.AcpRecNavToolbar)A_0).SyncDataSources();
				return;
			}
			}
		}

		// Token: 0x060051AA RID: 20906 RVA: 0x004A3EEC File Offset: 0x004A20EC
		private void HLinkClick(object A_0, global::System.Windows.RoutedEventArgs A_1)
		{
			short num = (short)1956567513;
			short num2 = num;
			num = (short)644012505;
			switch (num2 == num)
			{
			}
			num = (short)1701052416;
			short num3 = num;
			num = (short)860422145;
			if (num != 0)
			{
			}
			num = (short)1409286144;
			if (num != 0)
			{
			}
			base.OnHLinkClick(A_0);
		}

		// Token: 0x060051AB RID: 20907 RVA: 0x004A3F9C File Offset: 0x004A219C
		private void OnFieldNameDoubleClick(object A_0, global::System.Windows.RoutedEventArgs A_1)
		{
			short num = (short)1601143338;
			short num2 = num;
			num = (short)456360490;
			switch (num2 == num)
			{
			}
			num = (short)1366818816;
			short num3 = num;
			num = (short)1514668033;
			if (num != 0)
			{
			}
			num = (short)677969920;
			if (num != 0)
			{
			}
			global::AcpUI.Common.Utility.GetFieldHelpText(A_0);
		}

		// Token: 0x060051AC RID: 20908 RVA: 0x004A404C File Offset: 0x004A224C
		internal void OnExpanderVirtualPartnerAlertAlertListClick(object sender, global::System.Windows.RoutedEventArgs e)
		{
			switch (0)
			{
			case 0:
				goto IL_1C;
			}
			int num;
			object myRecordsetDataSource;
			short num2;
			global::Motorola.MackinawCPS.CoreFeatures.VirtualPartnerAlert.AlertListInner item;
			for (;;)
			{
				IL_0A:
				switch (num)
				{
				case 0:
					goto IL_AA;
				case 1:
					goto IL_109;
				case 2:
					if (myRecordsetDataSource != null)
					{
						num2 = (short)128253952;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_109;
				}
				goto IL_1C;
				IL_AA:
				num2 = (short)600899584;
				short num3 = num2;
				((global::System.Windows.Data.CollectionView)global::System.Windows.Data.CollectionViewSource.GetDefaultView(myRecordsetDataSource)).MoveCurrentTo(item);
				this.RecNavToolbarExpanderVirtualPartnerAlertAlertList.SyncDataSources();
				num2 = (short)1606090753;
				num = (int)((global::System.IntPtr)num2);
				continue;
				IL_109:
				num2 = (short)1492735062;
				short num4 = num2;
				num2 = (short)864113750;
				switch ((num4 == num2) ? 1 : 0)
				{
				case 0:
				case 2:
					goto IL_AA;
				default:
					goto IL_140;
				}
			}
			IL_140:
			num2 = (short)576258048;
			if (num2 != 0)
			{
			}
			this.RecNavToolbarExpanderVirtualPartnerAlertAlertList.TableMode = false;
			return;
			IL_1C:
			item = (global::Motorola.MackinawCPS.CoreFeatures.VirtualPartnerAlert.AlertListInner)((global::Infragistics.Windows.DataPresenter.CellValuePresenter)((global::AcpUI.AcpButton)e.Source).TemplatedParent).Record.DataItem;
			myRecordsetDataSource = this.RecNavToolbarExpanderVirtualPartnerAlertAlertList.MyRecordsetDataSource;
			num2 = (short)1013317633;
			if (num2 != 0)
			{
			}
			num2 = (short)562298882;
			num = (int)((global::System.IntPtr)num2);
			goto IL_0A;
		}

		// Token: 0x060051AD RID: 20909 RVA: 0x004A41BC File Offset: 0x004A23BC
		[global::System.CodeDom.Compiler.GeneratedCode("PresentationBuildTasks", "5.0.10.0")]
		[global::System.Diagnostics.DebuggerNonUserCode]
		public void InitializeComponent()
		{
			int a_ = 17;
			short num;
			while (this.b)
			{
				num = (short)3523408;
				short num2 = num;
				num = (short)1731642192;
				switch ((num2 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					break;
				default:
					num = (short)1054212097;
					if (num != 0)
					{
					}
					num = (short)1312751616;
					if (num != 0)
					{
					}
					return;
				}
			}
			num = (short)1068040192;
			short num3 = num;
			this.b = true;
			global::System.Uri resourceLocator = new global::System.Uri(global::AllFeatures.CodeplugGuid.b("﷑闓뫕듗鳙맛뿝铟韡難菥鯧퇩迫臭鷯英鯳飵鷷铹裻퇽狿持怃漅朇⼉㸋㸍甏怑猓礕瘗甙焛眝䌟儡ģᐥᠧ䤩䌫䀭嘯嬱匳䌵䨷嬹䠻圽⼿ⱁ歃ぅⅇ㡉㡋㭍ㅏ㹑煓摕桗⩙㵛ⱝᑟౡţᑥ䵧塩屫཭ᱯ᝱ٳɵ坷౹ᕻ౽ﺋ揄ﺏﾙ躟\udaa1얣쮥쒧", a_), global::System.UriKind.Relative);
			global::System.Windows.Application.LoadComponent(this, resourceLocator);
		}

		// Token: 0x060051AE RID: 20910 RVA: 0x004A429C File Offset: 0x004A249C
		[global::System.CodeDom.Compiler.GeneratedCode("PresentationBuildTasks", "5.0.10.0")]
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		[global::System.Diagnostics.DebuggerNonUserCode]
		void global::System.Windows.Markup.IComponentConnector.Connect(int connectionId, object target)
		{
			short num = (short)851902466;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				switch (num2)
				{
				case 0:
					num = (short)571408385;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 1:
					goto IL_25B;
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
					goto IL_3E7;
				case 2:
					goto IL_466;
				case 3:
				case 4:
				case 5:
					goto IL_4E2;
				case 6:
					goto IL_459;
				case 7:
					goto IL_17E;
				case 8:
					goto IL_3CD;
				case 9:
					goto IL_284;
				case 10:
					goto IL_260;
				case 11:
					goto IL_11A;
				case 12:
					goto IL_1F7;
				case 13:
					goto IL_35C;
				case 14:
					goto IL_291;
				case 15:
					goto IL_38D;
				case 16:
					goto IL_34F;
				case 17:
					goto IL_39A;
				case 18:
					goto IL_2F3;
				case 19:
					goto IL_235;
				case 20:
					goto IL_2E6;
				case 21:
					goto IL_497;
				case 22:
					goto IL_425;
				case 23:
					goto IL_43F;
				case 24:
					goto IL_418;
				case 25:
					goto IL_10D;
				case 26:
					goto IL_1D3;
				case 27:
					goto IL_3DA;
				case 28:
					goto IL_32B;
				case 29:
					goto IL_4A4;
				case 30:
					goto IL_1A2;
				case 31:
					goto IL_100;
				case 32:
					goto IL_4BE;
				case 33:
					goto IL_4B1;
				case 34:
					goto IL_2C2;
				case 35:
					goto IL_380;
				case 36:
					goto IL_127;
				case 37:
					goto IL_432;
				case 38:
					goto IL_204;
				case 39:
					goto IL_2B5;
				case 40:
					goto IL_1AF;
				case 41:
					goto IL_44C;
				case 42:
					goto IL_48A;
				case 43:
					goto IL_228;
				default:
					num = (short)971767808;
					num2 = (int)((global::System.IntPtr)num);
					break;
				}
			}
			IL_100:
			this.VirtualPartnerAlertListResultCode_43682Comp = (global::AcpUI.AcpLabel)target;
			return;
			IL_10D:
			this.gridExpanderVirtualPartnerAlertAlertListSRecView = (global::System.Windows.Controls.Grid)target;
			return;
			IL_11A:
			this.GrpBoxExpanderVirtualPartnerAlertGeneralPseudo0 = (global::AcpUI.AcpGroupBox)target;
			return;
			IL_127:
			num = (short)38023410;
			short num3 = num;
			num = (short)717435122;
			switch ((num3 == num) ? 1 : 0)
			{
			case 0:
			case 2:
				IL_2C2:
				this.LblVirtualPartnerAlertAlias_A43683 = (global::AcpUI.AcpLabel)target;
				this.LblVirtualPartnerAlertAlias_A43683.MouseDoubleClick += new global::System.Windows.Input.MouseButtonEventHandler(this.OnFieldNameDoubleClick);
				return;
			default:
				num = (short)1457324032;
				if (num != 0)
				{
				}
				this.CpyBtnVirtualPartnerAlertAlias_A43683 = (global::AcpUI.AcpCopyButton)target;
				return;
			}
			IL_17E:
			this.HLinkGeneral = (global::System.Windows.Documents.Hyperlink)target;
			this.HLinkGeneral.Click += this.HLinkClick;
			return;
			IL_1A2:
			this.CpyBtnVirtualPartnerAlertListResultCode_43682 = (global::AcpUI.AcpCopyButton)target;
			return;
			IL_1AF:
			this.LblVPAlertListAlertAction_A43684 = (global::AcpUI.AcpLabel)target;
			this.LblVPAlertListAlertAction_A43684.MouseDoubleClick += new global::System.Windows.Input.MouseButtonEventHandler(this.OnFieldNameDoubleClick);
			return;
			IL_1D3:
			this.VirtualPartnerAlertListResultCode_43682 = (global::AcpUI.AcpLabel)target;
			this.VirtualPartnerAlertListResultCode_43682.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_1F7:
			this.CVBtnVirtualPartnerAlertListName_43679 = (global::AcpUI.AcpCustomViewCheckBox)target;
			return;
			IL_204:
			this.VPAlertListAlertAction_A43684 = (global::AcpUI.AcpComboBox)target;
			this.VPAlertListAlertAction_A43684.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_228:
			this.VPAlertListAlertAction_A43684Comp = (global::AcpUI.AcpLabel)target;
			return;
			IL_235:
			this.ExpanderVirtualPartnerAlertAlertListTableView = (global::AcpUI.AcpGroupBox)target;
			return;
			IL_25B:
			goto IL_4E2;
			IL_260:
			this.RecNavToolbarExpanderVirtualPartnerAlertAlertList = (global::AcpUI.AcpChildRecNavToolbar)target;
			this.RecNavToolbarExpanderVirtualPartnerAlertAlertList.ModeClick += this.OnModeClick;
			return;
			IL_284:
			this.ExpanderVirtualPartnerAlertGeneral = (global::AcpUI.AcpExpander)target;
			return;
			IL_291:
			this.VirtualPartnerAlertListName_43679 = (global::AcpUI.AcpTextBox)target;
			this.VirtualPartnerAlertListName_43679.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_2B5:
			this.CVBtnVPAlertListAlertAction_A43684 = (global::AcpUI.AcpCustomViewCheckBox)target;
			return;
			IL_2E6:
			this.ExpanderVirtualPartnerAlertAlertList = (global::AcpUI.AcpXamDataPresenter)target;
			return;
			IL_2F3:
			num = (short)682885120;
			short num4 = num;
			this.ExpanderVirtualPartnerAlertAlertListGrid = (global::System.Windows.Controls.Grid)target;
			return;
			IL_32B:
			this.LblVirtualPartnerAlertListResultCode_43682 = (global::AcpUI.AcpLabel)target;
			this.LblVirtualPartnerAlertListResultCode_43682.MouseDoubleClick += new global::System.Windows.Input.MouseButtonEventHandler(this.OnFieldNameDoubleClick);
			return;
			IL_34F:
			this.VirtualPartnerAlertListName_43679Comp = (global::AcpUI.AcpLabel)target;
			return;
			IL_35C:
			this.LblVirtualPartnerAlertListName_43679 = (global::AcpUI.AcpLabel)target;
			this.LblVirtualPartnerAlertListName_43679.MouseDoubleClick += new global::System.Windows.Input.MouseButtonEventHandler(this.OnFieldNameDoubleClick);
			return;
			IL_380:
			this.RTDBtnVirtualPartnerAlertAlias_A43683 = (global::AcpUI.AcpRtdButton)target;
			return;
			IL_38D:
			this.CpyBtnVirtualPartnerAlertListName_43679 = (global::AcpUI.AcpCopyButton)target;
			return;
			IL_39A:
			num = (short)202637313;
			if (num != 0)
			{
			}
			this.ExpanderVirtualPartnerAlertGeneralGrid = (global::System.Windows.Controls.Grid)target;
			return;
			IL_3CD:
			this.MyStackPanel = (global::System.Windows.Controls.StackPanel)target;
			return;
			IL_3DA:
			this.CVBtnVirtualPartnerAlertListResultCode_43682 = (global::AcpUI.AcpCustomViewCheckBox)target;
			return;
			IL_3E7:
			((global::Motorola.MackinawCPS.CoreFeatures.VirtualPartnerAlert.PageVirtualPartnerAlert)target).Loaded += this.OnLoaded;
			((global::Motorola.MackinawCPS.CoreFeatures.VirtualPartnerAlert.PageVirtualPartnerAlert)target).Unloaded += this.OnUnloaded;
			return;
			IL_418:
			this.ExpanderVirtualPartnerAlertAlertListSRecView = (global::AcpUI.AcpGroupBox)target;
			return;
			IL_425:
			this.VirtualPartnerAlertAlias_A43683_Col = (global::Infragistics.Windows.DataPresenter.UnboundField)target;
			return;
			IL_432:
			this.VirtualPartnerAlertAlias_A43683Comp = (global::AcpUI.AcpLabel)target;
			return;
			IL_43F:
			this.VPAlertListAlertAction_A43684_Col = (global::Infragistics.Windows.DataPresenter.UnboundField)target;
			return;
			IL_44C:
			this.RTDBtnVPAlertListAlertAction_A43684 = (global::AcpUI.AcpRtdButton)target;
			return;
			IL_459:
			this.ThemeBaseObj = (global::AcpUI.Common.AcpThemeBase)target;
			return;
			IL_466:
			this.RecNavToolbarPageVirtualPartnerAlert = (global::AcpUI.AcpParentRecNavToolbar)target;
			this.RecNavToolbarPageVirtualPartnerAlert.ModeClick += this.OnModeClick;
			return;
			IL_48A:
			this.CpyBtnVPAlertListAlertAction_A43684 = (global::AcpUI.AcpCopyButton)target;
			return;
			IL_497:
			this.VirtualPartnerAlertListResultCode_43682_Col = (global::Infragistics.Windows.DataPresenter.UnboundField)target;
			return;
			IL_4A4:
			this.RTDBtnVirtualPartnerAlertListResultCode_43682 = (global::AcpUI.AcpRtdButton)target;
			return;
			IL_4B1:
			this.CVBtnVirtualPartnerAlertAlias_A43683 = (global::AcpUI.AcpCustomViewCheckBox)target;
			return;
			IL_4BE:
			this.VirtualPartnerAlertAlias_A43683 = (global::AcpUI.AcpTextBox)target;
			this.VirtualPartnerAlertAlias_A43683.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_4E2:
			this.b = true;
		}

		// Token: 0x060051AF RID: 20911 RVA: 0x004A4794 File Offset: 0x004A2994
		[global::System.CodeDom.Compiler.GeneratedCode("PresentationBuildTasks", "5.0.10.0")]
		[global::System.Diagnostics.DebuggerNonUserCode]
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		void global::System.Windows.Markup.IStyleConnector.Connect(int connectionId, object target)
		{
			short num;
			switch (connectionId)
			{
			case 3:
				break;
			case 4:
				((global::AcpUI.AcpTableTextBox)target).GotFocus += this.OnFieldNameDoubleClick;
				return;
			case 5:
				((global::AcpUI.AcpTableComboBox)target).GotFocus += this.OnFieldNameDoubleClick;
				return;
			default:
			{
				num = (short)679746887;
				short num2 = num;
				num = (short)1192435015;
				switch ((num2 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					break;
				default:
					num = (short)516751361;
					if (num != 0)
					{
					}
					num = (short)1485111296;
					if (num != 0)
					{
					}
					return;
				}
				break;
			}
			}
			num = (short)137101312;
			short num3 = num;
			((global::AcpUI.AcpTableViewOnlyCtrl)target).GotFocus += this.OnFieldNameDoubleClick;
		}

		// Token: 0x04001EED RID: 7917
		private bool a;

		// Token: 0x04001EEE RID: 7918
		internal global::AcpUI.AcpParentRecNavToolbar RecNavToolbarPageVirtualPartnerAlert;

		// Token: 0x04001EEF RID: 7919
		internal global::AcpUI.Common.AcpThemeBase ThemeBaseObj;

		// Token: 0x04001EF0 RID: 7920
		internal global::System.Windows.Documents.Hyperlink HLinkGeneral;

		// Token: 0x04001EF1 RID: 7921
		internal global::System.Windows.Controls.StackPanel MyStackPanel;

		// Token: 0x04001EF2 RID: 7922
		internal global::AcpUI.AcpExpander ExpanderVirtualPartnerAlertGeneral;

		// Token: 0x04001EF3 RID: 7923
		internal global::AcpUI.AcpChildRecNavToolbar RecNavToolbarExpanderVirtualPartnerAlertAlertList;

		// Token: 0x04001EF4 RID: 7924
		internal global::AcpUI.AcpGroupBox GrpBoxExpanderVirtualPartnerAlertGeneralPseudo0;

		// Token: 0x04001EF5 RID: 7925
		internal global::AcpUI.AcpCustomViewCheckBox CVBtnVirtualPartnerAlertListName_43679;

		// Token: 0x04001EF6 RID: 7926
		internal global::AcpUI.AcpLabel LblVirtualPartnerAlertListName_43679;

		// Token: 0x04001EF7 RID: 7927
		internal global::AcpUI.AcpTextBox VirtualPartnerAlertListName_43679;

		// Token: 0x04001EF8 RID: 7928
		internal global::AcpUI.AcpCopyButton CpyBtnVirtualPartnerAlertListName_43679;

		// Token: 0x04001EF9 RID: 7929
		internal global::AcpUI.AcpLabel VirtualPartnerAlertListName_43679Comp;

		// Token: 0x04001EFA RID: 7930
		internal global::System.Windows.Controls.Grid ExpanderVirtualPartnerAlertGeneralGrid;

		// Token: 0x04001EFB RID: 7931
		internal global::System.Windows.Controls.Grid ExpanderVirtualPartnerAlertAlertListGrid;

		// Token: 0x04001EFC RID: 7932
		internal global::AcpUI.AcpGroupBox ExpanderVirtualPartnerAlertAlertListTableView;

		// Token: 0x04001EFD RID: 7933
		internal global::AcpUI.AcpXamDataPresenter ExpanderVirtualPartnerAlertAlertList;

		// Token: 0x04001EFE RID: 7934
		internal global::Infragistics.Windows.DataPresenter.UnboundField VirtualPartnerAlertListResultCode_43682_Col;

		// Token: 0x04001EFF RID: 7935
		internal global::Infragistics.Windows.DataPresenter.UnboundField VirtualPartnerAlertAlias_A43683_Col;

		// Token: 0x04001F00 RID: 7936
		internal global::Infragistics.Windows.DataPresenter.UnboundField VPAlertListAlertAction_A43684_Col;

		// Token: 0x04001F01 RID: 7937
		internal global::AcpUI.AcpGroupBox ExpanderVirtualPartnerAlertAlertListSRecView;

		// Token: 0x04001F02 RID: 7938
		internal global::System.Windows.Controls.Grid gridExpanderVirtualPartnerAlertAlertListSRecView;

		// Token: 0x04001F03 RID: 7939
		internal global::AcpUI.AcpLabel VirtualPartnerAlertListResultCode_43682;

		// Token: 0x04001F04 RID: 7940
		internal global::AcpUI.AcpCustomViewCheckBox CVBtnVirtualPartnerAlertListResultCode_43682;

		// Token: 0x04001F05 RID: 7941
		internal global::AcpUI.AcpLabel LblVirtualPartnerAlertListResultCode_43682;

		// Token: 0x04001F06 RID: 7942
		internal global::AcpUI.AcpRtdButton RTDBtnVirtualPartnerAlertListResultCode_43682;

		// Token: 0x04001F07 RID: 7943
		internal global::AcpUI.AcpCopyButton CpyBtnVirtualPartnerAlertListResultCode_43682;

		// Token: 0x04001F08 RID: 7944
		internal global::AcpUI.AcpLabel VirtualPartnerAlertListResultCode_43682Comp;

		// Token: 0x04001F09 RID: 7945
		internal global::AcpUI.AcpTextBox VirtualPartnerAlertAlias_A43683;

		// Token: 0x04001F0A RID: 7946
		internal global::AcpUI.AcpCustomViewCheckBox CVBtnVirtualPartnerAlertAlias_A43683;

		// Token: 0x04001F0B RID: 7947
		internal global::AcpUI.AcpLabel LblVirtualPartnerAlertAlias_A43683;

		// Token: 0x04001F0C RID: 7948
		internal global::AcpUI.AcpRtdButton RTDBtnVirtualPartnerAlertAlias_A43683;

		// Token: 0x04001F0D RID: 7949
		internal global::AcpUI.AcpCopyButton CpyBtnVirtualPartnerAlertAlias_A43683;

		// Token: 0x04001F0E RID: 7950
		internal global::AcpUI.AcpLabel VirtualPartnerAlertAlias_A43683Comp;

		// Token: 0x04001F0F RID: 7951
		internal global::AcpUI.AcpComboBox VPAlertListAlertAction_A43684;

		// Token: 0x04001F10 RID: 7952
		internal global::AcpUI.AcpCustomViewCheckBox CVBtnVPAlertListAlertAction_A43684;

		// Token: 0x04001F11 RID: 7953
		internal global::AcpUI.AcpLabel LblVPAlertListAlertAction_A43684;

		// Token: 0x04001F12 RID: 7954
		internal global::AcpUI.AcpRtdButton RTDBtnVPAlertListAlertAction_A43684;

		// Token: 0x04001F13 RID: 7955
		internal global::AcpUI.AcpCopyButton CpyBtnVPAlertListAlertAction_A43684;

		// Token: 0x04001F14 RID: 7956
		internal global::AcpUI.AcpLabel VPAlertListAlertAction_A43684Comp;

		// Token: 0x04001F15 RID: 7957
		private bool b;
	}
}
