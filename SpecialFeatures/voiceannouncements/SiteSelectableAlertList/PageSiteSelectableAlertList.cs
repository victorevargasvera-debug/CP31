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
using Infragistics.Windows.DataPresenter;
using SpecialFeatures.AcpReportManagerLib;

namespace SpecialFeatures.VoiceAnnouncements.SiteSelectableAlertList
{
	// Token: 0x02000036 RID: 54
	public class PageSiteSelectableAlertList : global::AcpUI.AcpPageFeature, global::System.Windows.Markup.IComponentConnector, global::System.Windows.Markup.IStyleConnector
	{
		// Token: 0x06000698 RID: 1688 RVA: 0x00062180 File Offset: 0x00060380
		public PageSiteSelectableAlertList()
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

		// Token: 0x06000699 RID: 1689 RVA: 0x000621B8 File Offset: 0x000603B8
		public override void OnLoaded(object sender, global::System.Windows.RoutedEventArgs e)
		{
			for (;;)
			{
				IL_00:
				short num = (short)615841792;
				int num2 = (int)num;
				switch (num2)
				{
				default:
					num = (short)927662081;
					num2 = (int)((global::System.IntPtr)num);
					for (;;)
					{
						global::System.Collections.IEnumerator enumerator;
						global::AcpUI.AcpExpander acpExpander;
						switch (num2)
						{
						case 0:
						{
							this.RecNavToolbarPageSiteSelectableAlertList.ChildToolbars.Add(this.RecNavToolbarExpanderSiteSelectableAlertListSiteSelectableAlertTable);
							object obj = null;
							obj = this.RecNavToolbarExpanderSiteSelectableAlertListSiteSelectableAlertTable.MyRecordsetDataSource;
							num = (short)1580990469;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						case 1:
							switch (0)
							{
							case 0:
								goto IL_62;
							}
							continue;
						case 2:
							goto IL_1AA;
						case 3:
							try
							{
								num = (short)1197211649;
								num2 = (int)((global::System.IntPtr)num);
								for (;;)
								{
									switch (num2)
									{
									case 0:
										if (!enumerator.MoveNext())
										{
											num = (short)201981955;
											num2 = (int)((global::System.IntPtr)num);
											continue;
										}
										acpExpander = (((global::System.Windows.UIElement)enumerator.Current) as global::AcpUI.AcpExpander);
										num = (short)1021902852;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									case 1:
										switch (0)
										{
										case 0:
											goto IL_253;
										}
										continue;
									case 2:
										base.Expanders.Add(acpExpander);
										num = (short)45416453;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									case 3:
										num = (short)1385496582;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									case 4:
										if (acpExpander != null)
										{
											num = (short)1356988418;
											num2 = (int)((global::System.IntPtr)num);
											continue;
										}
										break;
									case 6:
										goto IL_312;
									}
									IL_255:
									num = (short)1607598080;
									num2 = (int)((global::System.IntPtr)num);
									continue;
									IL_253:
									goto IL_255;
								}
								IL_312:
								goto IL_181;
							}
							finally
							{
								switch (0)
								{
								case 0:
									goto IL_334;
								}
								global::System.IDisposable disposable;
								for (;;)
								{
									IL_321:
									switch (num2)
									{
									case 0:
										if (disposable != null)
										{
											num = (short)177995777;
											num2 = (int)((global::System.IntPtr)num);
											continue;
										}
										goto IL_389;
									case 1:
										disposable.Dispose();
										num = (short)1824849922;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									case 2:
										goto IL_387;
									}
									goto IL_334;
								}
								IL_387:
								IL_389:
								goto EndFinally_7;
								IL_334:
								disposable = (enumerator as global::System.IDisposable);
								num = (short)551813120;
								num2 = (int)((global::System.IntPtr)num);
								goto IL_321;
								EndFinally_7:;
							}
							goto IL_38A;
							IL_181:
							base.OnLoaded(sender, e);
							this.a = true;
							num = (short)923992066;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 4:
						{
							num = (short)1767657029;
							short num3 = num;
							num = (short)779243077;
							switch ((num3 == num) ? 1 : 0)
							{
							case 0:
							case 2:
								goto IL_00;
							default:
							{
								num = (short)170196992;
								if (num != 0)
								{
								}
								object obj;
								global::System.Windows.Data.CollectionView collectionView = (global::System.Windows.Data.CollectionView)global::System.Windows.Data.CollectionViewSource.GetDefaultView(obj);
								this.RecNavToolbarExpanderSiteSelectableAlertListSiteSelectableAlertTable.MyDataPresenter = this.ExpanderSiteSelectableAlertListSiteSelectableAlertTable;
								num = (short)343146502;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							}
							break;
						}
						case 5:
						{
							num = (short)468582400;
							short num4 = num;
							object obj;
							if (obj != null)
							{
								num = (short)1459552260;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							goto IL_85;
						}
						case 6:
							num = (short)65929217;
							if (num != 0)
							{
							}
							goto IL_85;
						}
						IL_62:
						if (!this.a)
						{
							num = (short)298319872;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_38A;
						IL_85:
						acpExpander = null;
						enumerator = this.MyStackPanel.Children.GetEnumerator();
						num = (short)1701117955;
						num2 = (int)((global::System.IntPtr)num);
					}
					break;
				}
			}
			IL_1AA:
			IL_38A:
			this.MyStackPanel.Children[0].Focus();
		}

		// Token: 0x0600069A RID: 1690 RVA: 0x00062584 File Offset: 0x00060784
		public override void OnUnloaded(object sender, global::System.Windows.RoutedEventArgs e)
		{
			short num = (short)519438336;
			short num2 = num;
			int num4;
			switch (0)
			{
			case 0:
				break;
			default:
				for (;;)
				{
					IL_35:
					num = (short)1514132637;
					short num3 = num;
					num = (short)1232524445;
					switch ((num3 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_C2;
					default:
						num = (short)823721984;
						if (num != 0)
						{
						}
						switch (num4)
						{
						case 0:
							if (this.a)
							{
								num = (short)643235841;
								num4 = (int)((global::System.IntPtr)num);
								continue;
							}
							return;
						case 1:
							num = (short)1283588097;
							if (num != 0)
							{
							}
							base.OnUnloaded(sender, e);
							this.a = false;
							num = (short)1262092290;
							num4 = (int)((global::System.IntPtr)num);
							continue;
						case 2:
							return;
						}
						goto IL_92;
					}
				}
				return;
			}
			IL_92:
			this.RecNavToolbarPageSiteSelectableAlertList.DataContext = null;
			this.RecNavToolbarExpanderSiteSelectableAlertListSiteSelectableAlertTable.DataContext = null;
			this.RecNavToolbarPageSiteSelectableAlertList.MyDataPresenter = null;
			this.RecNavToolbarExpanderSiteSelectableAlertListSiteSelectableAlertTable.MyDataPresenter = null;
			IL_C2:
			num = (short)2048786432;
			num4 = (int)((global::System.IntPtr)num);
			goto IL_35;
		}

		// Token: 0x0600069B RID: 1691 RVA: 0x000626E0 File Offset: 0x000608E0
		public override void SetDataContext()
		{
			short num = (short)289144834;
			int num2 = (int)((global::System.IntPtr)num);
			object feature;
			for (;;)
			{
				switch (num2)
				{
				case 0:
					if (global::AcpCommonLib.AppInfoManager.AppMode == global::AcpCommonLib.ApplicationMode.CodeplugComparisonMode)
					{
						num = (short)1428094977;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					((global::AcpUILib.IAcpRecNavToolbar)this.RecNavToolbarPageSiteSelectableAlertList).MySecondaryRecordsetDataSource = null;
					num = (short)316014598;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 1:
				{
					num = (short)404553728;
					short num3 = num;
					feature = global::AcpCommonLib.AppInfoManager.ComparatorDocument.GetFeature(4145);
					num = (short)224198661;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				case 2:
					switch (0)
					{
					case 0:
						goto IL_49;
					}
					continue;
				case 3:
				{
					num = (short)815931243;
					short num4 = num;
					num = (short)1721245547;
					switch ((num4 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_A7;
					default:
						num = (short)1639120896;
						if (num != 0)
						{
						}
						base.DataContext = global::AcpCommonLib.AppInfoManager.DefaultDocument.GetFeature(4145);
						num = (short)429719559;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					break;
				}
				case 4:
					goto IL_A7;
				case 5:
					if (feature != null)
					{
						num = (short)2146828296;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					return;
				case 6:
					goto IL_1C5;
				case 7:
					goto IL_A7;
				case 8:
					goto IL_236;
				}
				IL_49:
				num = (short)648019969;
				if (num != 0)
				{
				}
				if (global::AcpCommonLib.AppInfoManager.AppMode == global::AcpCommonLib.ApplicationMode.CustomViewConfigurationMode)
				{
					num = (short)1479868419;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				base.DataContext = global::AcpCommonLib.FeatureManager.GetFeature(4145);
				num = (short)1925447684;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_A7:
				this.RecNavToolbarPageSiteSelectableAlertList.DataContext = (global::AcpCommonLib.IAcpRecordset)base.DataContext;
				num = (short)1051394048;
				num2 = (int)((global::System.IntPtr)num);
			}
			IL_1C5:
			return;
			IL_236:
			((global::AcpUILib.IAcpRecNavToolbar)this.RecNavToolbarPageSiteSelectableAlertList).MySecondaryRecordsetDataSource = (global::AcpCommonLib.IAcpRecordset)feature;
		}

		// Token: 0x0600069C RID: 1692 RVA: 0x00062928 File Offset: 0x00060B28
		private void OnModeClick(object A_0, global::System.Windows.RoutedEventArgs A_1)
		{
			int a_ = 17;
			short num = (short)47710208;
			switch (num)
			{
			default:
			{
				num = (short)366215170;
				int num2 = (int)((global::System.IntPtr)num);
				for (;;)
				{
					global::System.Windows.Data.CollectionView collectionView;
					switch (num2)
					{
					case 0:
						goto IL_246;
					case 1:
					{
						num = (short)1834614784;
						short num3 = num;
						object myRecordsetDataSource;
						collectionView = (global::System.Windows.Data.CollectionView)global::System.Windows.Data.CollectionViewSource.GetDefaultView(myRecordsetDataSource);
						global::SpecialFeatures.VoiceAnnouncements.SiteSelectableAlertList.SiteSelectableAlertTableInner siteSelectableAlertTableInner = (global::SpecialFeatures.VoiceAnnouncements.SiteSelectableAlertList.SiteSelectableAlertTableInner)collectionView.CurrentItem;
						num = (short)2075852815;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 2:
						switch (0)
						{
						case 0:
							goto IL_AB;
						}
						continue;
					case 3:
					{
						((global::AcpUI.AcpRecNavToolbar)A_0).TableMode = false;
						object myRecordsetDataSource = this.RecNavToolbarExpanderSiteSelectableAlertListSiteSelectableAlertTable.MyRecordsetDataSource;
						num = (short)916193302;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 4:
						if (((global::AcpUI.AcpRecNavToolbar)A_0).Name == global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("욓ﮗ풙ﶛ춡쮣쪥쪧쮩\udeabﺭ톯햱톳톷캹\ud9bbꖿ껁ꇃꗅ볇ꯉ껋ꋍ뗏鏑룓돕꫗껙郛럝鏟雡", a_))
						{
							num = (short)349306898;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_31A;
					case 5:
						num = (short)75104260;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 6:
						num = (short)207486992;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 7:
						goto IL_31A;
					case 8:
						goto IL_270;
					case 9:
					{
						global::AcpCommonLib.IAcpRecordset myRecordsetDataSource2;
						base.NavigationService.Navigate(new global::System.Uri(myRecordsetDataSource2.UIPagePath, global::System.UriKind.RelativeOrAbsolute));
						num = (short)672923655;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 10:
						goto IL_17F;
					case 11:
						goto IL_395;
					case 12:
						num = (short)1555759124;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 13:
						goto IL_1D9;
					case 14:
						collectionView.MoveCurrentToLast();
						num = (short)247595008;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 15:
					{
						global::SpecialFeatures.VoiceAnnouncements.SiteSelectableAlertList.SiteSelectableAlertTableInner siteSelectableAlertTableInner;
						if (siteSelectableAlertTableInner != null)
						{
							num = (short)15990805;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)962854923;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 16:
						if (collectionView.IsCurrentAfterLast)
						{
							num = (short)1841233934;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						collectionView.MoveCurrentToFirst();
						num = (short)67371021;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 17:
					{
						global::AcpCommonLib.IAcpRecordset myRecordsetDataSource2;
						if (myRecordsetDataSource2 != null)
						{
							num = (short)1209597961;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_31A;
					}
					case 18:
					{
						global::AcpCommonLib.IAcpRecordset myRecordsetDataSource2 = this.RecNavToolbarPageSiteSelectableAlertList.MyRecordsetDataSource;
						num = (short)1014431761;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 19:
						if (((global::AcpUI.AcpRecNavToolbar)A_0).Name == global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("욓ﮗ풙ﶛ춡쮣쪥쪧쮩\udeab좯슱햳\ud8b5\udcb7\udfb9캻ꦿ뛁ꇃ闅귇ꛉ꧋귍꓏돑뛓뫕뷗鯙냛믝鋟雡꣣迥鯧黩뿫蟭蓯韱ꟳ鏵铷鿹鿻諽懿态栃挅䤇昉椋簍搏䘑甓琕琗缙", a_))
						{
							num = (short)341770252;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return;
					case 20:
						if (((global::AcpUI.AcpRecNavToolbar)A_0).TableMode)
						{
							num = (short)1039204355;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						((global::AcpUI.AcpRecNavToolbar)A_0).TableMode = true;
						num = (short)217579528;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 21:
					{
						num = (short)1303183361;
						if (num != 0)
						{
						}
						num = (short)2087939264;
						short num4 = num;
						num = (short)1321888960;
						switch ((num4 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_395;
						default:
						{
							num = (short)916783104;
							if (num != 0)
							{
							}
							global::SpecialFeatures.VoiceAnnouncements.SiteSelectableAlertList.SiteSelectableAlertTableInner siteSelectableAlertTableInner;
							collectionView.MoveCurrentTo(siteSelectableAlertTableInner);
							num = (short)1107230730;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						}
						break;
					}
					case 22:
					{
						object myRecordsetDataSource;
						if (myRecordsetDataSource != null)
						{
							num = (short)1112997889;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return;
					}
					}
					IL_AB:
					if (A_0 is global::AcpUI.AcpRecNavToolbar)
					{
						num = (short)41680901;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					return;
					IL_31A:
					num = (short)1699348499;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_395:
					if (collectionView.Count <= 0)
					{
						break;
					}
					num = (short)1632370694;
					num2 = (int)((global::System.IntPtr)num);
				}
				IL_17F:
				IL_1D9:
				IL_246:
				goto IL_370;
				IL_270:
				return;
				IL_370:
				((global::AcpUI.AcpRecNavToolbar)A_0).SyncDataSources();
				return;
			}
			}
		}

		// Token: 0x0600069D RID: 1693 RVA: 0x00062DE0 File Offset: 0x00060FE0
		private void OnFieldNameDoubleClick(object A_0, global::System.Windows.RoutedEventArgs A_1)
		{
			short num = (short)1977362119;
			short num2 = num;
			num = (short)855910087;
			switch (num2 == num)
			{
			}
			num = (short)176095233;
			if (num != 0)
			{
			}
			num = (short)1722548224;
			short num3 = num;
			num = (short)568786944;
			if (num != 0)
			{
			}
			global::AcpUI.Common.Utility.GetFieldHelpText(A_0);
		}

		// Token: 0x0600069E RID: 1694 RVA: 0x00062E90 File Offset: 0x00061090
		internal void OnExpanderSiteSelectableAlertListSiteSelectableAlertTableClick(object sender, global::System.Windows.RoutedEventArgs e)
		{
			switch (0)
			{
			case 0:
				goto IL_1C;
			}
			int num;
			object myRecordsetDataSource;
			global::SpecialFeatures.VoiceAnnouncements.SiteSelectableAlertList.SiteSelectableAlertTableInner item;
			short num2;
			for (;;)
			{
				IL_0A:
				switch (num)
				{
				case 0:
					((global::System.Windows.Data.CollectionView)global::System.Windows.Data.CollectionViewSource.GetDefaultView(myRecordsetDataSource)).MoveCurrentTo(item);
					this.RecNavToolbarExpanderSiteSelectableAlertListSiteSelectableAlertTable.SyncDataSources();
					num2 = (short)832765953;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 1:
					goto IL_14F;
				case 2:
				{
					num2 = (short)1897332736;
					short num3 = num2;
					num2 = (short)1477962260;
					short num4 = num2;
					num2 = (short)1671096852;
					switch ((num4 == num2) ? 1 : 0)
					{
					case 0:
					case 2:
						break;
					default:
						num2 = (short)2004877312;
						if (num2 != 0)
						{
						}
						if (myRecordsetDataSource == null)
						{
							goto IL_151;
						}
						break;
					}
					num2 = (short)1158807552;
					num = (int)((global::System.IntPtr)num2);
					continue;
				}
				}
				goto IL_1C;
			}
			IL_14F:
			IL_151:
			this.RecNavToolbarExpanderSiteSelectableAlertListSiteSelectableAlertTable.TableMode = false;
			return;
			IL_1C:
			num2 = (short)852819969;
			if (num2 != 0)
			{
			}
			item = (global::SpecialFeatures.VoiceAnnouncements.SiteSelectableAlertList.SiteSelectableAlertTableInner)((global::Infragistics.Windows.DataPresenter.CellValuePresenter)((global::AcpUI.AcpButton)e.Source).TemplatedParent).Record.DataItem;
			myRecordsetDataSource = this.RecNavToolbarExpanderSiteSelectableAlertListSiteSelectableAlertTable.MyRecordsetDataSource;
			num2 = (short)1738014722;
			num = (int)((global::System.IntPtr)num2);
			goto IL_0A;
		}

		// Token: 0x0600069F RID: 1695 RVA: 0x00062FFC File Offset: 0x000611FC
		private void HLinkSiteSelectableAlertListSiteSelectableAlertList41985Click(object A_0, global::System.Windows.RoutedEventArgs A_1)
		{
			short num = (short)1562217498;
			short num2 = num;
			num = (short)1087671322;
			switch (num2 == num)
			{
			}
			num = (short)1646592000;
			if (num != 0)
			{
			}
			num = (short)896532480;
			short num3 = num;
			num = (short)271908865;
			if (num != 0)
			{
			}
			base.OnHLinkClick(A_0);
		}

		// Token: 0x060006A0 RID: 1696 RVA: 0x000630AC File Offset: 0x000612AC
		[global::System.Diagnostics.DebuggerNonUserCode]
		[global::System.CodeDom.Compiler.GeneratedCode("PresentationBuildTasks", "5.0.10.0")]
		public void InitializeComponent()
		{
			int a_ = 16;
			if (this.b)
			{
				short num = (short)389611521;
				if (num != 0)
				{
				}
			}
			else
			{
				short num = (short)46681122;
				short num2 = num;
				num = (short)2081377314;
				switch ((num2 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					break;
				default:
				{
					num = (short)1583022080;
					if (num != 0)
					{
					}
					num = (short)1042087936;
					short num3 = num;
					this.b = true;
					global::System.Uri resourceLocator = new global::System.Uri(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("벒요ﲘﺞ춠삤욦\udda8\udeaa\udfac쪮슰袲횴\ud8b6풸쮺튼톾꓀귂뇄뿈꓊꓌곎듐닒믔맖뛘껚돜볞蓠転胤触鷨飪심鳮飰蟲郴틶쯸쯺軼髾洀昂昄猆栈椊愌樎㐐ℒ└瘖甘縚漜欞Рᄢᔤ䬦䀨堪夬.䈰娲䄴制䨸帺儼娾≀㝂⑄╆╈⹊ⱌ⍎㑐⅒⅔㭖じ⡚⥜煞ᥠɢࡤ୦", a_), global::System.UriKind.Relative);
					global::System.Windows.Application.LoadComponent(this, resourceLocator);
					return;
				}
				}
			}
		}

		// Token: 0x060006A1 RID: 1697 RVA: 0x00063190 File Offset: 0x00061390
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		[global::System.Diagnostics.DebuggerNonUserCode]
		[global::System.CodeDom.Compiler.GeneratedCode("PresentationBuildTasks", "5.0.10.0")]
		void global::System.Windows.Markup.IComponentConnector.Connect(int connectionId, object target)
		{
			short num = (short)468516866;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				num = (short)1306198017;
				if (num != 0)
				{
				}
				num = (short)1126563840;
				short num3 = num;
				switch (num2)
				{
				case 0:
					num = (short)1285423105;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 1:
					goto IL_297;
				case 2:
					switch (0)
					{
					case 0:
						goto IL_7F;
					}
					continue;
				}
				IL_7F:
				switch (connectionId)
				{
				case 1:
					goto IL_3BB;
				case 2:
					goto IL_43A;
				case 3:
				case 4:
				case 5:
				case 6:
					goto IL_61C;
				case 7:
					goto IL_602;
				case 8:
					goto IL_4C0;
				case 9:
					goto IL_42D;
				case 10:
					goto IL_200;
				case 11:
					goto IL_478;
				case 12:
					goto IL_2C0;
				case 13:
					goto IL_33F;
				case 14:
					goto IL_29C;
				case 15:
					goto IL_1B8;
				case 16:
					goto IL_3A1;
				case 17:
					goto IL_24B;
				case 18:
					goto IL_2CD;
				case 19:
					goto IL_37D;
				case 20:
					goto IL_359;
				case 21:
					goto IL_332;
				case 22:
					goto IL_5B7;
				case 23:
					goto IL_46B;
				case 24:
					goto IL_318;
				case 25:
					goto IL_30B;
				case 26:
					goto IL_272;
				case 27:
					goto IL_3F9;
				case 28:
					goto IL_413;
				case 29:
					goto IL_4E4;
				case 30:
					goto IL_515;
				case 31:
					goto IL_3EC;
				case 32:
					goto IL_3AE;
				case 33:
					goto IL_5D1;
				case 34:
					goto IL_194;
				case 35:
					goto IL_23E;
				case 36:
					goto IL_5DE;
				case 37:
					goto IL_5C4;
				case 38:
					goto IL_325;
				case 39:
					goto IL_60F;
				case 40:
					goto IL_20D;
				case 41:
					goto IL_187;
				case 42:
					goto IL_4F1;
				case 43:
					goto IL_590;
				case 44:
					goto IL_406;
				case 45:
					goto IL_2FE;
				case 46:
					goto IL_49C;
				case 47:
					goto IL_34C;
				case 48:
					goto IL_1DC;
				case 49:
					goto IL_59D;
				case 50:
					goto IL_420;
				case 51:
					goto IL_258;
				case 52:
					goto IL_2DA;
				case 53:
					goto IL_231;
				case 54:
					goto IL_522;
				case 55:
					goto IL_45E;
				case 56:
					goto IL_265;
				case 57:
					goto IL_5AA;
				default:
					num = (short)945160192;
					num2 = (int)((global::System.IntPtr)num);
					break;
				}
			}
			IL_187:
			this.CVBtnSSAAlertFile_A41990 = (global::AcpUI.AcpCustomViewCheckBox)target;
			return;
			IL_194:
			this.SSAFrontDisplayAlertAlias_A41987 = (global::AcpUI.AcpTextBox)target;
			this.SSAFrontDisplayAlertAlias_A41987.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_1B8:
			this.SiteSelectableAlertListAlias_A41993 = (global::AcpUI.AcpTextBox)target;
			this.SiteSelectableAlertListAlias_A41993.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_1DC:
			this.LblVASSAAlertPeriodSec_A41991 = (global::AcpUI.AcpLabel)target;
			this.LblVASSAAlertPeriodSec_A41991.MouseDoubleClick += new global::System.Windows.Input.MouseButtonEventHandler(this.OnFieldNameDoubleClick);
			return;
			IL_200:
			this.ExpanderSiteSelectableAlertListSiteSelectableAlertList41985 = (global::AcpUI.AcpExpander)target;
			return;
			IL_20D:
			this.SSAAlertFile_A41990 = (global::AcpUI.AcpComboBox)target;
			this.SSAAlertFile_A41990.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_231:
			this.CVBtnVASSASubscriberEncodable_A41992 = (global::AcpUI.AcpCustomViewCheckBox)target;
			return;
			IL_23E:
			this.CVBtnSSAFrontDisplayAlertAlias_A41987 = (global::AcpUI.AcpCustomViewCheckBox)target;
			return;
			IL_24B:
			this.SiteSelectableAlertListAlias_A41993Comp = (global::AcpUI.AcpViewOnlyCtrl)target;
			return;
			IL_258:
			this.VASSAAlertPeriodSec_A41991Comp = (global::AcpUI.AcpViewOnlyCtrl)target;
			return;
			IL_265:
			this.CpyBtnVASSASubscriberEncodable_A41992 = (global::AcpUI.AcpCopyButton)target;
			return;
			IL_272:
			this.ExpanderSiteSelectableAlertListSiteSelectableAlertTableTableView = (global::AcpUI.AcpGroupBox)target;
			return;
			IL_297:
			goto IL_61C;
			IL_29C:
			this.LblSiteSelectableAlertListAlias_A41993 = (global::AcpUI.AcpLabel)target;
			this.LblSiteSelectableAlertListAlias_A41993.MouseDoubleClick += new global::System.Windows.Input.MouseButtonEventHandler(this.OnFieldNameDoubleClick);
			return;
			IL_2C0:
			this.GrpBoxExpanderSiteSelectableAlertListSiteSelectableAlertList41985Pseudo1 = (global::AcpUI.AcpGroupBox)target;
			return;
			IL_2CD:
			this.CVBtnSiteSelectableAlertListConfigurationType_A42058 = (global::AcpUI.AcpCustomViewCheckBox)target;
			return;
			IL_2DA:
			this.VASSASubscriberEncodable_A41992 = (global::AcpUI.AcpCheckBox)target;
			this.VASSASubscriberEncodable_A41992.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_2FE:
			this.SSAAlertFile_A41990Comp = (global::AcpUI.AcpViewOnlyCtrl)target;
			return;
			IL_30B:
			this.ExpanderSiteSelectableAlertListSiteSelectableAlertTableGrid = (global::System.Windows.Controls.Grid)target;
			return;
			IL_318:
			this.ExpanderSiteSelectableAlertListSiteSelectableAlertList41985Grid = (global::System.Windows.Controls.Grid)target;
			return;
			IL_325:
			this.CpyBtnSSAFrontDisplayAlertAlias_A41987 = (global::AcpUI.AcpCopyButton)target;
			return;
			IL_332:
			this.RTDBtnSiteSelectableAlertListConfigurationType_A42058 = (global::AcpUI.AcpRtdButton)target;
			return;
			IL_33F:
			this.CVBtnSiteSelectableAlertListAlias_A41993 = (global::AcpUI.AcpCustomViewCheckBox)target;
			return;
			IL_34C:
			this.CVBtnVASSAAlertPeriodSec_A41991 = (global::AcpUI.AcpCustomViewCheckBox)target;
			return;
			IL_359:
			this.SiteSelectableAlertListConfigurationType_A42058 = (global::AcpUI.AcpComboBox)target;
			this.SiteSelectableAlertListConfigurationType_A42058.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_37D:
			this.LblSiteSelectableAlertListConfigurationType_A42058 = (global::AcpUI.AcpLabel)target;
			this.LblSiteSelectableAlertListConfigurationType_A42058.MouseDoubleClick += new global::System.Windows.Input.MouseButtonEventHandler(this.OnFieldNameDoubleClick);
			return;
			IL_3A1:
			this.CpyBtnSiteSelectableAlertListAlias_A41993 = (global::AcpUI.AcpCopyButton)target;
			return;
			IL_3AE:
			this.ExpanderSiteSelectableAlertListSiteSelectableAlertTableSRecView = (global::AcpUI.AcpGroupBox)target;
			return;
			IL_3BB:
			((global::SpecialFeatures.VoiceAnnouncements.SiteSelectableAlertList.PageSiteSelectableAlertList)target).Loaded += this.OnLoaded;
			((global::SpecialFeatures.VoiceAnnouncements.SiteSelectableAlertList.PageSiteSelectableAlertList)target).Unloaded += this.OnUnloaded;
			return;
			IL_3EC:
			this.VASSASubscriberEncodable_A41992_Col = (global::Infragistics.Windows.DataPresenter.UnboundField)target;
			return;
			IL_3F9:
			this.ExpanderSiteSelectableAlertListSiteSelectableAlertTable = (global::AcpUI.AcpXamDataPresenter)target;
			return;
			IL_406:
			this.CpyBtnSSAAlertFile_A41990 = (global::AcpUI.AcpCopyButton)target;
			return;
			IL_413:
			this.SSAFrontDisplayAlertAlias_A41987_Col = (global::Infragistics.Windows.DataPresenter.UnboundField)target;
			return;
			IL_420:
			this.CpyBtnVASSAAlertPeriodSec_A41991 = (global::AcpUI.AcpCopyButton)target;
			return;
			IL_42D:
			this.MyStackPanel = (global::System.Windows.Controls.StackPanel)target;
			return;
			IL_43A:
			this.RecNavToolbarPageSiteSelectableAlertList = (global::AcpUI.AcpParentRecNavToolbar)target;
			this.RecNavToolbarPageSiteSelectableAlertList.ModeClick += this.OnModeClick;
			return;
			IL_45E:
			this.RTDBtnVASSASubscriberEncodable_A41992 = (global::AcpUI.AcpRtdButton)target;
			return;
			IL_46B:
			this.SiteSelectableAlertListConfigurationType_A42058Comp = (global::AcpUI.AcpViewOnlyCtrl)target;
			return;
			IL_478:
			this.RecNavToolbarExpanderSiteSelectableAlertListSiteSelectableAlertTable = (global::AcpUI.AcpChildRecNavToolbar)target;
			this.RecNavToolbarExpanderSiteSelectableAlertListSiteSelectableAlertTable.ModeClick += this.OnModeClick;
			return;
			IL_49C:
			this.VASSAAlertPeriodSec_A41991 = (global::AcpUI.AcpTextBoxSpinner)target;
			this.VASSAAlertPeriodSec_A41991.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_4C0:
			this.HLinkSiteSelectableAlertListSiteSelectableAlertList41985 = (global::System.Windows.Documents.Hyperlink)target;
			this.HLinkSiteSelectableAlertListSiteSelectableAlertList41985.Click += this.HLinkSiteSelectableAlertListSiteSelectableAlertList41985Click;
			return;
			IL_4E4:
			this.SSAAlertFile_A41990_Col = (global::Infragistics.Windows.DataPresenter.UnboundField)target;
			return;
			IL_4F1:
			this.LblSSAAlertFile_A41990 = (global::AcpUI.AcpLabel)target;
			this.LblSSAAlertFile_A41990.MouseDoubleClick += new global::System.Windows.Input.MouseButtonEventHandler(this.OnFieldNameDoubleClick);
			return;
			IL_515:
			this.VASSAAlertPeriodSec_A41991_Col = (global::Infragistics.Windows.DataPresenter.UnboundField)target;
			return;
			IL_522:
			num = (short)198977325;
			short num4 = num;
			num = (short)1385965357;
			switch ((num4 == num) ? 1 : 0)
			{
			case 0:
			case 2:
				goto IL_4F1;
			default:
				num = (short)1598816256;
				if (num != 0)
				{
				}
				this.LblVASSASubscriberEncodable_A41992 = (global::AcpUI.AcpLabel)target;
				this.LblVASSASubscriberEncodable_A41992.MouseDoubleClick += new global::System.Windows.Input.MouseButtonEventHandler(this.OnFieldNameDoubleClick);
				return;
			}
			IL_590:
			this.RTDBtnSSAAlertFile_A41990 = (global::AcpUI.AcpRtdButton)target;
			return;
			IL_59D:
			this.RTDBtnVASSAAlertPeriodSec_A41991 = (global::AcpUI.AcpRtdButton)target;
			return;
			IL_5AA:
			this.VASSASubscriberEncodable_A41992Comp = (global::AcpUI.AcpCheckBox)target;
			return;
			IL_5B7:
			this.CpyBtnSiteSelectableAlertListConfigurationType_A42058 = (global::AcpUI.AcpCopyButton)target;
			return;
			IL_5C4:
			this.RTDBtnSSAFrontDisplayAlertAlias_A41987 = (global::AcpUI.AcpRtdButton)target;
			return;
			IL_5D1:
			this.gridExpanderSiteSelectableAlertListSiteSelectableAlertTableSRecView = (global::System.Windows.Controls.Grid)target;
			return;
			IL_5DE:
			this.LblSSAFrontDisplayAlertAlias_A41987 = (global::AcpUI.AcpLabel)target;
			this.LblSSAFrontDisplayAlertAlias_A41987.MouseDoubleClick += new global::System.Windows.Input.MouseButtonEventHandler(this.OnFieldNameDoubleClick);
			return;
			IL_602:
			this.ThemeBaseObj = (global::AcpUI.Common.AcpThemeBase)target;
			return;
			IL_60F:
			this.SSAFrontDisplayAlertAlias_A41987Comp = (global::AcpUI.AcpViewOnlyCtrl)target;
			return;
			IL_61C:
			this.b = true;
		}

		// Token: 0x060006A2 RID: 1698 RVA: 0x000637C0 File Offset: 0x000619C0
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
				break;
			case 5:
			{
				short num = (short)1820852225;
				if (num != 0)
				{
				}
				num = (short)23806148;
				short num2 = num;
				num = (short)1083850948;
				switch ((num2 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					break;
				default:
					num = (short)639434752;
					if (num != 0)
					{
					}
					((global::AcpUI.AcpTableTextBoxSpinner)target).GotFocus += this.OnFieldNameDoubleClick;
					return;
				}
				break;
			}
			case 6:
				((global::AcpUI.AcpCheckBox)target).GotFocus += this.OnFieldNameDoubleClick;
				return;
			default:
			{
				short num = (short)1036845056;
				short num3 = num;
				return;
			}
			}
			((global::AcpUI.AcpTableComboBox)target).GotFocus += this.OnFieldNameDoubleClick;
		}

		// Token: 0x04000297 RID: 663
		private bool a;

		// Token: 0x04000298 RID: 664
		internal global::AcpUI.AcpParentRecNavToolbar RecNavToolbarPageSiteSelectableAlertList;

		// Token: 0x04000299 RID: 665
		internal global::AcpUI.Common.AcpThemeBase ThemeBaseObj;

		// Token: 0x0400029A RID: 666
		internal global::System.Windows.Documents.Hyperlink HLinkSiteSelectableAlertListSiteSelectableAlertList41985;

		// Token: 0x0400029B RID: 667
		internal global::System.Windows.Controls.StackPanel MyStackPanel;

		// Token: 0x0400029C RID: 668
		internal global::AcpUI.AcpExpander ExpanderSiteSelectableAlertListSiteSelectableAlertList41985;

		// Token: 0x0400029D RID: 669
		internal global::AcpUI.AcpChildRecNavToolbar RecNavToolbarExpanderSiteSelectableAlertListSiteSelectableAlertTable;

		// Token: 0x0400029E RID: 670
		internal global::AcpUI.AcpGroupBox GrpBoxExpanderSiteSelectableAlertListSiteSelectableAlertList41985Pseudo1;

		// Token: 0x0400029F RID: 671
		internal global::AcpUI.AcpCustomViewCheckBox CVBtnSiteSelectableAlertListAlias_A41993;

		// Token: 0x040002A0 RID: 672
		internal global::AcpUI.AcpLabel LblSiteSelectableAlertListAlias_A41993;

		// Token: 0x040002A1 RID: 673
		internal global::AcpUI.AcpTextBox SiteSelectableAlertListAlias_A41993;

		// Token: 0x040002A2 RID: 674
		internal global::AcpUI.AcpCopyButton CpyBtnSiteSelectableAlertListAlias_A41993;

		// Token: 0x040002A3 RID: 675
		internal global::AcpUI.AcpViewOnlyCtrl SiteSelectableAlertListAlias_A41993Comp;

		// Token: 0x040002A4 RID: 676
		internal global::AcpUI.AcpCustomViewCheckBox CVBtnSiteSelectableAlertListConfigurationType_A42058;

		// Token: 0x040002A5 RID: 677
		internal global::AcpUI.AcpLabel LblSiteSelectableAlertListConfigurationType_A42058;

		// Token: 0x040002A6 RID: 678
		internal global::AcpUI.AcpComboBox SiteSelectableAlertListConfigurationType_A42058;

		// Token: 0x040002A7 RID: 679
		internal global::AcpUI.AcpRtdButton RTDBtnSiteSelectableAlertListConfigurationType_A42058;

		// Token: 0x040002A8 RID: 680
		internal global::AcpUI.AcpCopyButton CpyBtnSiteSelectableAlertListConfigurationType_A42058;

		// Token: 0x040002A9 RID: 681
		internal global::AcpUI.AcpViewOnlyCtrl SiteSelectableAlertListConfigurationType_A42058Comp;

		// Token: 0x040002AA RID: 682
		internal global::System.Windows.Controls.Grid ExpanderSiteSelectableAlertListSiteSelectableAlertList41985Grid;

		// Token: 0x040002AB RID: 683
		internal global::System.Windows.Controls.Grid ExpanderSiteSelectableAlertListSiteSelectableAlertTableGrid;

		// Token: 0x040002AC RID: 684
		internal global::AcpUI.AcpGroupBox ExpanderSiteSelectableAlertListSiteSelectableAlertTableTableView;

		// Token: 0x040002AD RID: 685
		internal global::AcpUI.AcpXamDataPresenter ExpanderSiteSelectableAlertListSiteSelectableAlertTable;

		// Token: 0x040002AE RID: 686
		internal global::Infragistics.Windows.DataPresenter.UnboundField SSAFrontDisplayAlertAlias_A41987_Col;

		// Token: 0x040002AF RID: 687
		internal global::Infragistics.Windows.DataPresenter.UnboundField SSAAlertFile_A41990_Col;

		// Token: 0x040002B0 RID: 688
		internal global::Infragistics.Windows.DataPresenter.UnboundField VASSAAlertPeriodSec_A41991_Col;

		// Token: 0x040002B1 RID: 689
		internal global::Infragistics.Windows.DataPresenter.UnboundField VASSASubscriberEncodable_A41992_Col;

		// Token: 0x040002B2 RID: 690
		internal global::AcpUI.AcpGroupBox ExpanderSiteSelectableAlertListSiteSelectableAlertTableSRecView;

		// Token: 0x040002B3 RID: 691
		internal global::System.Windows.Controls.Grid gridExpanderSiteSelectableAlertListSiteSelectableAlertTableSRecView;

		// Token: 0x040002B4 RID: 692
		internal global::AcpUI.AcpTextBox SSAFrontDisplayAlertAlias_A41987;

		// Token: 0x040002B5 RID: 693
		internal global::AcpUI.AcpCustomViewCheckBox CVBtnSSAFrontDisplayAlertAlias_A41987;

		// Token: 0x040002B6 RID: 694
		internal global::AcpUI.AcpLabel LblSSAFrontDisplayAlertAlias_A41987;

		// Token: 0x040002B7 RID: 695
		internal global::AcpUI.AcpRtdButton RTDBtnSSAFrontDisplayAlertAlias_A41987;

		// Token: 0x040002B8 RID: 696
		internal global::AcpUI.AcpCopyButton CpyBtnSSAFrontDisplayAlertAlias_A41987;

		// Token: 0x040002B9 RID: 697
		internal global::AcpUI.AcpViewOnlyCtrl SSAFrontDisplayAlertAlias_A41987Comp;

		// Token: 0x040002BA RID: 698
		internal global::AcpUI.AcpComboBox SSAAlertFile_A41990;

		// Token: 0x040002BB RID: 699
		internal global::AcpUI.AcpCustomViewCheckBox CVBtnSSAAlertFile_A41990;

		// Token: 0x040002BC RID: 700
		internal global::AcpUI.AcpLabel LblSSAAlertFile_A41990;

		// Token: 0x040002BD RID: 701
		internal global::AcpUI.AcpRtdButton RTDBtnSSAAlertFile_A41990;

		// Token: 0x040002BE RID: 702
		internal global::AcpUI.AcpCopyButton CpyBtnSSAAlertFile_A41990;

		// Token: 0x040002BF RID: 703
		internal global::AcpUI.AcpViewOnlyCtrl SSAAlertFile_A41990Comp;

		// Token: 0x040002C0 RID: 704
		internal global::AcpUI.AcpTextBoxSpinner VASSAAlertPeriodSec_A41991;

		// Token: 0x040002C1 RID: 705
		internal global::AcpUI.AcpCustomViewCheckBox CVBtnVASSAAlertPeriodSec_A41991;

		// Token: 0x040002C2 RID: 706
		internal global::AcpUI.AcpLabel LblVASSAAlertPeriodSec_A41991;

		// Token: 0x040002C3 RID: 707
		internal global::AcpUI.AcpRtdButton RTDBtnVASSAAlertPeriodSec_A41991;

		// Token: 0x040002C4 RID: 708
		internal global::AcpUI.AcpCopyButton CpyBtnVASSAAlertPeriodSec_A41991;

		// Token: 0x040002C5 RID: 709
		internal global::AcpUI.AcpViewOnlyCtrl VASSAAlertPeriodSec_A41991Comp;

		// Token: 0x040002C6 RID: 710
		internal global::AcpUI.AcpCheckBox VASSASubscriberEncodable_A41992;

		// Token: 0x040002C7 RID: 711
		internal global::AcpUI.AcpCustomViewCheckBox CVBtnVASSASubscriberEncodable_A41992;

		// Token: 0x040002C8 RID: 712
		internal global::AcpUI.AcpLabel LblVASSASubscriberEncodable_A41992;

		// Token: 0x040002C9 RID: 713
		internal global::AcpUI.AcpRtdButton RTDBtnVASSASubscriberEncodable_A41992;

		// Token: 0x040002CA RID: 714
		internal global::AcpUI.AcpCopyButton CpyBtnVASSASubscriberEncodable_A41992;

		// Token: 0x040002CB RID: 715
		internal global::AcpUI.AcpCheckBox VASSASubscriberEncodable_A41992Comp;

		// Token: 0x040002CC RID: 716
		private bool b;
	}
}
