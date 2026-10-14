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

namespace Motorola.MackinawCPS.CoreFeatures.ScanList
{
	// Token: 0x0200011B RID: 283
	public class PageScanList : global::AcpUI.AcpPageFeature, global::System.Windows.Markup.IComponentConnector, global::System.Windows.Markup.IStyleConnector
	{
		// Token: 0x060029F2 RID: 10738 RVA: 0x0028CF5C File Offset: 0x0028B15C
		public PageScanList()
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

		// Token: 0x060029F3 RID: 10739 RVA: 0x0028CF94 File Offset: 0x0028B194
		public override void OnLoaded(object sender, global::System.Windows.RoutedEventArgs e)
		{
			short num = (short)1785331712;
			int num2 = (int)num;
			switch (num2)
			{
			default:
			{
				num = (short)240517120;
				short num3 = num;
				num = (short)213581829;
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
						this.RecNavToolbarExpanderScanListScanList.MyDataPresenter = this.ExpanderScanListScanList;
						num = (short)2036072450;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 1:
						goto IL_185;
					case 2:
						goto IL_D2;
					case 3:
					{
						num = (short)1747124225;
						if (num != 0)
						{
						}
						this.RecNavToolbarPageScanList.ChildToolbars.Add(this.RecNavToolbarExpanderScanListScanList);
						object obj = null;
						obj = this.RecNavToolbarExpanderScanListScanList.MyRecordsetDataSource;
						num = (short)1646198788;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 4:
					{
						object obj;
						if (obj != null)
						{
							num = (short)941752320;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_D2;
					}
					case 5:
						switch (0)
						{
						case 0:
							goto IL_88;
						}
						continue;
					case 6:
						try
						{
							num = (short)2033582085;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								switch (num2)
								{
								case 0:
									if (acpExpander != null)
									{
										num = (short)1450770433;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									break;
								case 1:
									base.Expanders.Add(acpExpander);
									num = (short)229113860;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 2:
									goto IL_2C5;
								case 3:
									if (!enumerator.MoveNext())
									{
										num = (short)527433734;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									acpExpander = (((global::System.Windows.UIElement)enumerator.Current) as global::AcpUI.AcpExpander);
									num = (short)357498880;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 5:
									switch (0)
									{
									case 0:
										goto IL_208;
									}
									continue;
								case 6:
									num = (short)30670850;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								IL_20A:
								num = (short)1551892483;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								IL_208:
								goto IL_20A;
							}
							IL_2C5:
							goto IL_15E;
						}
						finally
						{
							switch (0)
							{
							case 0:
								goto IL_2E7;
							}
							global::System.IDisposable disposable;
							for (;;)
							{
								IL_2D4:
								switch (num2)
								{
								case 0:
									goto IL_38D;
								case 1:
								{
									if (disposable == null)
									{
										goto IL_38F;
									}
									num = (short)1410651869;
									short num4 = num;
									num = (short)1226888925;
									switch ((num4 == num) ? 1 : 0)
									{
									case 0:
									case 2:
										break;
									default:
										num = (short)530382848;
										if (num != 0)
										{
										}
										num = (short)493158402;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									break;
								}
								case 2:
									disposable.Dispose();
									num = (short)1276772352;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								goto IL_2E7;
							}
							IL_38D:
							IL_38F:
							goto EndFinally_8;
							IL_2E7:
							disposable = (enumerator as global::System.IDisposable);
							num = (short)1130364929;
							num2 = (int)((global::System.IntPtr)num);
							goto IL_2D4;
							EndFinally_8:;
						}
						goto IL_390;
						IL_15E:
						base.OnLoaded(sender, e);
						this.a = true;
						num = (short)1765998593;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					IL_88:
					if (!this.a)
					{
						num = (short)1284833283;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					break;
					IL_D2:
					acpExpander = null;
					enumerator = this.MyStackPanel.Children.GetEnumerator();
					num = (short)405209094;
					num2 = (int)((global::System.IntPtr)num);
				}
				IL_185:
				IL_390:
				this.MyStackPanel.Children[0].Focus();
				return;
			}
			}
		}

		// Token: 0x060029F4 RID: 10740 RVA: 0x0028D364 File Offset: 0x0028B564
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
					goto IL_11C;
				case 1:
				{
					if (!this.a)
					{
						return;
					}
					num2 = (short)1791813224;
					short num3 = num2;
					num2 = (short)286254696;
					switch ((num3 == num2) ? 1 : 0)
					{
					case 0:
					case 2:
						break;
					default:
						num2 = (short)1193803776;
						if (num2 != 0)
						{
						}
						num2 = (short)1121648642;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					break;
				}
				case 2:
					num2 = (short)378404865;
					if (num2 != 0)
					{
					}
					base.OnUnloaded(sender, e);
					this.a = false;
					num2 = (short)331612160;
					num = (int)((global::System.IntPtr)num2);
					continue;
				}
				goto IL_1C;
			}
			IL_11C:
			num2 = (short)1805123584;
			short num4 = num2;
			return;
			IL_1C:
			this.RecNavToolbarPageScanList.DataContext = null;
			this.RecNavToolbarExpanderScanListScanList.DataContext = null;
			this.RecNavToolbarPageScanList.MyDataPresenter = null;
			this.RecNavToolbarExpanderScanListScanList.MyDataPresenter = null;
			num2 = (short)1201799169;
			num = (int)((global::System.IntPtr)num2);
			goto IL_0A;
		}

		// Token: 0x060029F5 RID: 10741 RVA: 0x0028D4BC File Offset: 0x0028B6BC
		public override void SetDataContext()
		{
			short num = (short)1278345223;
			int num2 = (int)((global::System.IntPtr)num);
			object feature;
			for (;;)
			{
				switch (num2)
				{
				case 0:
					goto IL_232;
				case 1:
					if (feature != null)
					{
						num = (short)151650304;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					return;
				case 2:
					goto IL_7F;
				case 3:
					base.DataContext = global::AcpCommonLib.AppInfoManager.DefaultDocument.GetFeature(2057);
					num = (short)1057226756;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 4:
					goto IL_7F;
				case 5:
					num = (short)1481048065;
					if (num != 0)
					{
					}
					if (global::AcpCommonLib.AppInfoManager.AppMode == global::AcpCommonLib.ApplicationMode.CodeplugComparisonMode)
					{
						num = (short)1286144008;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					((global::AcpUILib.IAcpRecNavToolbar)this.RecNavToolbarPageScanList).MySecondaryRecordsetDataSource = null;
					num = (short)1476591622;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 6:
					goto IL_196;
				case 7:
					switch (0)
					{
					case 0:
						goto IL_48;
					}
					continue;
				case 8:
					feature = global::AcpCommonLib.AppInfoManager.ComparatorDocument.GetFeature(2057);
					num = (short)316276737;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				IL_48:
				if (global::AcpCommonLib.AppInfoManager.AppMode == global::AcpCommonLib.ApplicationMode.CustomViewConfigurationMode)
				{
					num = (short)1276051459;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				base.DataContext = global::AcpCommonLib.FeatureManager.GetFeature(2057);
				goto IL_1AB;
				IL_7F:
				num = (short)23116518;
				short num3 = num;
				num = (short)757381862;
				switch ((num3 == num) ? 1 : 0)
				{
				case 0:
				case 2:
				{
					IL_1AB:
					num = (short)429391872;
					short num4 = num;
					num = (short)537591810;
					num2 = (int)((global::System.IntPtr)num);
					break;
				}
				default:
					num = (short)1952120832;
					if (num != 0)
					{
					}
					this.RecNavToolbarPageScanList.DataContext = (global::AcpCommonLib.IAcpRecordset)base.DataContext;
					num = (short)1958871045;
					num2 = (int)((global::System.IntPtr)num);
					break;
				}
			}
			IL_196:
			return;
			IL_232:
			((global::AcpUILib.IAcpRecNavToolbar)this.RecNavToolbarPageScanList).MySecondaryRecordsetDataSource = (global::AcpCommonLib.IAcpRecordset)feature;
		}

		// Token: 0x060029F6 RID: 10742 RVA: 0x0028D700 File Offset: 0x0028B900
		private void OnModeClick(object A_0, global::System.Windows.RoutedEventArgs A_1)
		{
			int a_ = 4;
			short num = (short)1882652672;
			switch (num)
			{
			default:
			{
				num = (short)643366914;
				int num2 = (int)((global::System.IntPtr)num);
				for (;;)
				{
					global::System.Windows.Data.CollectionView collectionView;
					switch (num2)
					{
					case 0:
					{
						global::Motorola.MackinawCPS.CoreFeatures.ScanList.ScanListInner scanListInner;
						if (scanListInner != null)
						{
							num = (short)1977679873;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)1511391253;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 1:
					{
						global::Motorola.MackinawCPS.CoreFeatures.ScanList.ScanListInner scanListInner;
						collectionView.MoveCurrentTo(scanListInner);
						num = (short)897974290;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 2:
						switch (0)
						{
						case 0:
							goto IL_AA;
						}
						continue;
					case 3:
						if (((global::AcpUI.AcpRecNavToolbar)A_0).Name == global::AllFeatures.CodeplugGuid.b("韄ꋆ꫈藊곌많藐볒뫔믖믘뫚꿜髞駠鏢蓤触跨軪鿬볮鋰鋲鯴믶郸裺觼곾戀戂欄䬆怈砊礌", a_))
						{
							num = (short)1973485576;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return;
					case 4:
						goto IL_2CB;
					case 5:
						goto IL_1DB;
					case 6:
					{
						global::AcpCommonLib.IAcpRecordset myRecordsetDataSource;
						if (myRecordsetDataSource != null)
						{
							num = (short)598605831;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_2CB;
					}
					case 7:
					{
						global::AcpCommonLib.IAcpRecordset myRecordsetDataSource;
						base.NavigationService.Navigate(new global::System.Uri(myRecordsetDataSource.UIPagePath, global::System.UriKind.RelativeOrAbsolute));
						num = (short)316886253;
						short num3 = num;
						num = (short)874925293;
						switch ((num3 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_110;
						default:
							num = (short)1343356928;
							if (num != 0)
							{
							}
							num = (short)1133707268;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						break;
					}
					case 8:
						num = (short)438632462;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 9:
						if (collectionView.IsCurrentAfterLast)
						{
							num = (short)576061455;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						collectionView.MoveCurrentToFirst();
						num = (short)909180933;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 10:
						goto IL_249;
					case 11:
						goto IL_273;
					case 12:
					{
						global::AcpCommonLib.IAcpRecordset myRecordsetDataSource = this.RecNavToolbarPageScanList.MyRecordsetDataSource;
						num = (short)638255110;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 13:
					{
						object myRecordsetDataSource2;
						if (myRecordsetDataSource2 != null)
						{
							num = (short)985923584;
							short num4 = num;
							num = (short)1322450963;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return;
					}
					case 14:
						if (((global::AcpUI.AcpRecNavToolbar)A_0).TableMode)
						{
							num = (short)235601937;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						((global::AcpUI.AcpRecNavToolbar)A_0).TableMode = true;
						num = (short)1715470347;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 15:
						goto IL_110;
					case 16:
						num = (short)1577975828;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 17:
					{
						((global::AcpUI.AcpRecNavToolbar)A_0).TableMode = false;
						object myRecordsetDataSource2 = this.RecNavToolbarExpanderScanListScanList.MyRecordsetDataSource;
						num = (short)1073807373;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 18:
						goto IL_135;
					case 19:
					{
						object myRecordsetDataSource2;
						collectionView = (global::System.Windows.Data.CollectionView)global::System.Windows.Data.CollectionViewSource.GetDefaultView(myRecordsetDataSource2);
						global::Motorola.MackinawCPS.CoreFeatures.ScanList.ScanListInner scanListInner = (global::Motorola.MackinawCPS.CoreFeatures.ScanList.ScanListInner)collectionView.CurrentItem;
						num = (short)1288830976;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 20:
						if (((global::AcpUI.AcpRecNavToolbar)A_0).Name == global::AllFeatures.CodeplugGuid.b("韄ꋆ꫈藊곌많藐볒뫔믖믘뫚꿜连胠蓢胤듦諨諪菬ꏮ飰胲致", a_))
						{
							num = (short)582156300;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_2CB;
					case 21:
						if (collectionView.Count > 0)
						{
							num = (short)21299222;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_349;
					case 22:
						num = (short)622067721;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					IL_AA:
					if (A_0 is global::AcpUI.AcpRecNavToolbar)
					{
						num = (short)869990416;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					return;
					IL_110:
					collectionView.MoveCurrentToLast();
					num = (short)150732810;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_2CB:
					num = (short)2081488897;
					if (num != 0)
					{
					}
					num = (short)1114570755;
					num2 = (int)((global::System.IntPtr)num);
				}
				IL_135:
				IL_1DB:
				IL_249:
				goto IL_349;
				IL_273:
				return;
				IL_349:
				((global::AcpUI.AcpRecNavToolbar)A_0).SyncDataSources();
				return;
			}
			}
		}

		// Token: 0x060029F7 RID: 10743 RVA: 0x0028DBB4 File Offset: 0x0028BDB4
		private void HLinkClick(object A_0, global::System.Windows.RoutedEventArgs A_1)
		{
			short num = (short)1081671680;
			short num2 = num;
			num = (short)1501020283;
			short num3 = num;
			num = (short)1036107899;
			switch (num3 == num)
			{
			}
			num = (short)1410203649;
			if (num != 0)
			{
			}
			num = (short)776011776;
			if (num != 0)
			{
			}
			base.OnHLinkClick(A_0);
		}

		// Token: 0x060029F8 RID: 10744 RVA: 0x0028DC68 File Offset: 0x0028BE68
		private void OnFieldNameDoubleClick(object A_0, global::System.Windows.RoutedEventArgs A_1)
		{
			short num = (short)224526336;
			short num2 = num;
			num = (short)1120641234;
			short num3 = num;
			num = (short)1268883666;
			switch (num3 == num)
			{
			}
			num = (short)1230700545;
			if (num != 0)
			{
			}
			num = (short)1055784960;
			if (num != 0)
			{
			}
			global::AcpUI.Common.Utility.GetFieldHelpText(A_0);
		}

		// Token: 0x060029F9 RID: 10745 RVA: 0x0028DD18 File Offset: 0x0028BF18
		internal void OnExpanderScanListScanListClick(object sender, global::System.Windows.RoutedEventArgs e)
		{
			switch (0)
			{
			case 0:
				goto IL_1C;
			}
			int num;
			object myRecordsetDataSource;
			short num2;
			global::Motorola.MackinawCPS.CoreFeatures.ScanList.ScanListInner item;
			for (;;)
			{
				IL_0A:
				switch (num)
				{
				case 0:
				{
					if (myRecordsetDataSource == null)
					{
						goto IL_154;
					}
					num2 = (short)1717370880;
					short num3 = num2;
					num2 = (short)257746883;
					short num4 = num2;
					num2 = (short)105768899;
					switch ((num4 == num2) ? 1 : 0)
					{
					case 0:
					case 2:
						break;
					default:
						num2 = (short)879558656;
						if (num2 != 0)
						{
						}
						num2 = (short)1142751233;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					break;
				}
				case 1:
					((global::System.Windows.Data.CollectionView)global::System.Windows.Data.CollectionViewSource.GetDefaultView(myRecordsetDataSource)).MoveCurrentTo(item);
					this.RecNavToolbarExpanderScanListScanList.SyncDataSources();
					num2 = (short)1764360194;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 2:
					goto IL_12B;
				}
				goto IL_1C;
			}
			IL_12B:
			num2 = (short)1761476609;
			if (num2 != 0)
			{
			}
			IL_154:
			this.RecNavToolbarExpanderScanListScanList.TableMode = false;
			return;
			IL_1C:
			item = (global::Motorola.MackinawCPS.CoreFeatures.ScanList.ScanListInner)((global::Infragistics.Windows.DataPresenter.CellValuePresenter)((global::AcpUI.AcpButton)e.Source).TemplatedParent).Record.DataItem;
			myRecordsetDataSource = this.RecNavToolbarExpanderScanListScanList.MyRecordsetDataSource;
			num2 = (short)1401225216;
			num = (int)((global::System.IntPtr)num2);
			goto IL_0A;
		}

		// Token: 0x060029FA RID: 10746 RVA: 0x0028DE88 File Offset: 0x0028C088
		[global::System.CodeDom.Compiler.GeneratedCode("PresentationBuildTasks", "5.0.10.0")]
		[global::System.Diagnostics.DebuggerNonUserCode]
		public void InitializeComponent()
		{
			int a_ = 7;
			short num = (short)1023710556;
			short num2 = num;
			num = (short)329553244;
			switch ((num2 == num) ? 1 : 0)
			{
			case 0:
			case 2:
				return;
			case 1:
				break;
			default:
			{
				num = (short)1948385280;
				short num3 = num;
				break;
			}
			}
			num = (short)1269039104;
			if (num != 0)
			{
			}
			num = (short)1026424833;
			if (num != 0)
			{
			}
			if (!this.b)
			{
				this.b = true;
				global::System.Uri resourceLocator = new global::System.Uri(global::AllFeatures.CodeplugGuid.b("诉ꃋꋍ雏럑뗓ꋕ귗꣙맛귝\udbdf臡诣该飧藩苫语黯蛱\udbf3藵鯷鯹鋻\udbfd㋿㈁會椅昇氉攋植攏怑甓戕焗甙爛ㄝ匟䄡䔣䠥ധᠩᰫ䈭夯䄱䀳ᤵ䬷夹崻倽ⰿ⭁㝃㉅晇㉉ⵋ⍍㱏", a_), global::System.UriKind.Relative);
				global::System.Windows.Application.LoadComponent(this, resourceLocator);
				return;
			}
		}

		// Token: 0x060029FB RID: 10747 RVA: 0x0028DF68 File Offset: 0x0028C168
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		[global::System.Diagnostics.DebuggerNonUserCode]
		[global::System.CodeDom.Compiler.GeneratedCode("PresentationBuildTasks", "5.0.10.0")]
		void global::System.Windows.Markup.IComponentConnector.Connect(int connectionId, object target)
		{
			short num = (short)258080768;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				switch (num2)
				{
				case 0:
					switch (0)
					{
					case 0:
						goto IL_31;
					}
					continue;
				case 1:
					num = (short)1350172674;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 2:
					goto IL_AD3;
				}
				IL_31:
				switch (connectionId)
				{
				case 1:
					goto IL_463;
				case 2:
					goto IL_AD8;
				case 3:
				case 4:
				case 5:
				case 6:
					goto IL_128D;
				case 7:
					goto IL_6FA;
				case 8:
					goto IL_1154;
				case 9:
					goto IL_65A;
				case 10:
					goto IL_A17;
				case 11:
					goto IL_1235;
				case 12:
					goto IL_F64;
				case 13:
					goto IL_C79;
				case 14:
					goto IL_D5A;
				case 15:
					goto IL_1185;
				case 16:
					goto IL_CDE;
				case 17:
					goto IL_752;
				case 18:
					goto IL_106E;
				case 19:
					goto IL_D67;
				case 20:
					goto IL_F8B;
				case 21:
					goto IL_9E6;
				case 22:
					goto IL_F26;
				case 23:
					goto IL_FA5;
				case 24:
					goto IL_F71;
				case 25:
					goto IL_D74;
				case 26:
					goto IL_A0A;
				case 27:
					goto IL_A3B;
				case 28:
					goto IL_39F;
				case 29:
					goto IL_88F;
				case 30:
					goto IL_721;
				case 31:
					goto IL_B54;
				case 32:
					goto IL_6ED;
				case 33:
					goto IL_4B8;
				case 34:
					goto IL_776;
				case 35:
					goto IL_110C;
				case 36:
					goto IL_1047;
				case 37:
					goto IL_844;
				case 38:
					goto IL_F7E;
				case 39:
					goto IL_494;
				case 40:
					goto IL_F02;
				case 41:
					goto IL_11DD;
				case 42:
					goto IL_385;
				case 43:
					goto IL_10C9;
				case 44:
					goto IL_5DE;
				case 45:
					goto IL_7BE;
				case 46:
					goto IL_4C5;
				case 47:
					goto IL_9D9;
				case 48:
					goto IL_401;
				case 49:
					goto IL_714;
				case 50:
					goto IL_640;
				case 51:
					goto IL_61C;
				case 52:
					goto IL_DC2;
				case 53:
					goto IL_E5F;
				case 54:
					goto IL_C86;
				case 55:
					goto IL_1259;
				case 56:
					goto IL_BE0;
				case 57:
					goto IL_5F8;
				case 58:
					goto IL_FF2;
				case 59:
					goto IL_E93;
				case 60:
					goto IL_B9F;
				case 61:
					goto IL_5D1;
				case 62:
					goto IL_F98;
				case 63:
					goto IL_1204;
				case 64:
					goto IL_D0F;
				case 65:
					goto IL_68B;
				case 66:
					goto IL_B3A;
				case 67:
					goto IL_875;
				case 68:
					goto IL_A93;
				case 69:
					goto IL_A48;
				case 70:
					goto IL_6A5;
				case 71:
					goto IL_E3B;
				case 72:
					goto IL_BED;
				case 73:
					goto IL_1273;
				case 74:
					goto IL_8F1;
				case 75:
					goto IL_D33;
				case 76:
					goto IL_51A;
				case 77:
					goto IL_53E;
				case 78:
					goto IL_EA0;
				case 79:
					goto IL_11F7;
				case 80:
					goto IL_B2D;
				case 81:
					goto IL_8E4;
				case 82:
					goto IL_8FE;
				case 83:
					goto IL_98E;
				case 84:
					goto IL_CD1;
				case 85:
					goto IL_456;
				case 86:
					goto IL_11B6;
				case 87:
					goto IL_10A2;
				case 88:
					goto IL_B09;
				case 89:
					goto IL_96A;
				case 90:
					goto IL_67E;
				case 91:
					goto IL_D4D;
				case 92:
					goto IL_B47;
				case 93:
					goto IL_F4A;
				case 94:
					goto IL_DE6;
				case 95:
					goto IL_1023;
				case 96:
					goto IL_10BC;
				case 97:
					goto IL_64D;
				case 98:
					goto IL_AA0;
				case 99:
					goto IL_CC4;
				case 100:
					goto IL_DA8;
				case 101:
					goto IL_BC6;
				case 102:
					goto IL_922;
				case 103:
					goto IL_EDE;
				case 104:
					goto IL_882;
				case 105:
					goto IL_1228;
				case 106:
					goto IL_AFC;
				case 107:
					goto IL_9CC;
				case 108:
					goto IL_361;
				case 109:
					goto IL_8C0;
				case 110:
					goto IL_1095;
				case 111:
					goto IL_9B2;
				case 112:
					goto IL_3F4;
				case 113:
					goto IL_1088;
				case 114:
					goto IL_851;
				case 115:
					goto IL_79A;
				case 116:
					goto IL_1016;
				case 117:
					goto IL_C2E;
				case 118:
					goto IL_1280;
				case 119:
					goto IL_C07;
				case 120:
					goto IL_B6E;
				case 121:
					goto IL_562;
				case 122:
					goto IL_A86;
				case 123:
					goto IL_B92;
				case 124:
					goto IL_1266;
				case 125:
					goto IL_D9B;
				case 126:
					goto IL_C3B;
				case 127:
					goto IL_A62;
				case 128:
					goto IL_A55;
				case 129:
					goto IL_3C3;
				case 130:
					goto IL_C93;
				case 131:
					goto IL_C21;
				case 132:
					goto IL_33D;
				case 133:
					goto IL_D81;
				case 134:
					goto IL_BB9;
				case 135:
					goto IL_E6C;
				case 136:
					goto IL_BFA;
				case 137:
					goto IL_C5F;
				case 138:
					goto IL_AAD;
				case 139:
					goto IL_D02;
				case 140:
					goto IL_698;
				case 141:
					goto IL_806;
				case 142:
					goto IL_8B3;
				case 143:
					goto IL_BD3;
				case 144:
					goto IL_1192;
				case 145:
					goto IL_10AF;
				case 146:
					goto IL_72E;
				case 147:
					goto IL_9BF;
				case 148:
					goto IL_ED1;
				case 149:
					goto IL_4F6;
				case 150:
					goto IL_FD8;
				case 151:
					goto IL_1130;
				case 152:
					goto IL_B61;
				case 153:
					goto IL_392;
				case 154:
					goto IL_5EB;
				case 155:
					goto IL_7E2;
				case 156:
					goto IL_107B;
				case 157:
					goto IL_813;
				case 158:
					goto IL_BAC;
				case 159:
					goto IL_10D6;
				case 160:
					goto IL_FE5;
				case 161:
					goto IL_6C9;
				case 162:
					goto IL_837;
				case 163:
					goto IL_40E;
				case 164:
					goto IL_D8E;
				case 165:
					goto IL_C14;
				case 166:
					goto IL_11C3;
				case 167:
					goto IL_4E9;
				case 168:
					goto IL_E0A;
				case 169:
					goto IL_707;
				case 170:
					goto IL_3D0;
				case 171:
					goto IL_946;
				case 172:
					goto IL_C6C;
				case 173:
					goto IL_F57;
				case 174:
					goto IL_11EA;
				case 175:
					goto IL_DB5;
				case 176:
					goto IL_EAD;
				case 177:
					goto IL_CA0;
				case 178:
					goto IL_E79;
				case 179:
					goto IL_E86;
				case 180:
					goto IL_1054;
				case 181:
					goto IL_11D0;
				case 182:
					goto IL_432;
				case 183:
					goto IL_E17;
				case 184:
					goto IL_1061;
				case 185:
					goto IL_1178;
				case 186:
					goto IL_D40;
				default:
					num = (short)776798209;
					num2 = (int)((global::System.IntPtr)num);
					break;
				}
			}
			IL_33D:
			this.RecNavToolbarExpanderScanListScanList = (global::AcpUI.AcpChildRecNavToolbar)target;
			this.RecNavToolbarExpanderScanListScanList.ModeClick += this.OnModeClick;
			return;
			IL_361:
			this.LblScanLstAdvancedVotingScanDelayTimerMs_A9657 = (global::AcpUI.AcpLabel)target;
			this.LblScanLstAdvancedVotingScanDelayTimerMs_A9657.MouseDoubleClick += new global::System.Windows.Input.MouseButtonEventHandler(this.OnFieldNameDoubleClick);
			return;
			IL_385:
			this.CpyBtnScanLstGeneralDynamicPriority_A7915 = (global::AcpUI.AcpCopyButton)target;
			return;
			IL_392:
			this.CpyBtnScanLstScanListZone_A9718 = (global::AcpUI.AcpCopyButton)target;
			return;
			IL_39F:
			this.LblScanLstGeneralRecord_A8921 = (global::AcpUI.AcpLabel)target;
			this.LblScanLstGeneralRecord_A8921.MouseDoubleClick += new global::System.Windows.Input.MouseButtonEventHandler(this.OnFieldNameDoubleClick);
			return;
			IL_3C3:
			this.CpyBtnScanLstAdvancedMixedConvVoteScanInactivityTimer_A38724 = (global::AcpUI.AcpCopyButton)target;
			return;
			IL_3D0:
			this.LblScanLstLabtoolLastVotedChannel_A8419 = (global::AcpUI.AcpLabel)target;
			this.LblScanLstLabtoolLastVotedChannel_A8419.MouseDoubleClick += new global::System.Windows.Input.MouseButtonEventHandler(this.OnFieldNameDoubleClick);
			return;
			IL_3F4:
			this.ScanLstAdvancedVotingScanDelayTimerMs_A9657Comp = (global::AcpUI.AcpLabel)target;
			return;
			IL_401:
			this.CpyBtnScanLstGeneralPriority1Type_A8745 = (global::AcpUI.AcpCopyButton)target;
			return;
			IL_40E:
			this.LblScanLstScanListLTEInterferingFreqPresent_A42196 = (global::AcpUI.AcpLabel)target;
			this.LblScanLstScanListLTEInterferingFreqPresent_A42196.MouseDoubleClick += new global::System.Windows.Input.MouseButtonEventHandler(this.OnFieldNameDoubleClick);
			return;
			IL_432:
			this.LblScanLstLabtoolLTEInterferingFreqPresent_A42197 = (global::AcpUI.AcpLabel)target;
			this.LblScanLstLabtoolLTEInterferingFreqPresent_A42197.MouseDoubleClick += new global::System.Windows.Input.MouseButtonEventHandler(this.OnFieldNameDoubleClick);
			return;
			IL_456:
			this.CpyBtnScanLstGeneralDesignatedVoiceTxMember_A7830 = (global::AcpUI.AcpCopyButton)target;
			return;
			IL_463:
			((global::Motorola.MackinawCPS.CoreFeatures.ScanList.PageScanList)target).Loaded += this.OnLoaded;
			((global::Motorola.MackinawCPS.CoreFeatures.ScanList.PageScanList)target).Unloaded += this.OnUnloaded;
			return;
			IL_494:
			this.LblScanLstGeneralDynamicPriority_A7915 = (global::AcpUI.AcpLabel)target;
			this.LblScanLstGeneralDynamicPriority_A7915.MouseDoubleClick += new global::System.Windows.Input.MouseButtonEventHandler(this.OnFieldNameDoubleClick);
			return;
			IL_4B8:
			this.CVBtnScanLstGeneralType_A9578 = (global::AcpUI.AcpCustomViewCheckBox)target;
			return;
			IL_4C5:
			this.ScanLstGeneralPriority1Type_A8745 = (global::AcpUI.AcpComboBox)target;
			this.ScanLstGeneralPriority1Type_A8745.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_4E9:
			this.ExpanderScanListLabtool = (global::AcpUI.AcpExpander)target;
			return;
			IL_4F6:
			this.ScanLstScanListZone_A9718 = (global::AcpUI.AcpComboBox)target;
			this.ScanLstScanListZone_A9718.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_51A:
			this.LblScanLstGeneralDesignatedVoiceTxMemberType_A21524 = (global::AcpUI.AcpLabel)target;
			this.LblScanLstGeneralDesignatedVoiceTxMemberType_A21524.MouseDoubleClick += new global::System.Windows.Input.MouseButtonEventHandler(this.OnFieldNameDoubleClick);
			return;
			IL_53E:
			this.ScanLstGeneralDesignatedVoiceTxMemberType_A21524 = (global::AcpUI.AcpComboBox)target;
			this.ScanLstGeneralDesignatedVoiceTxMemberType_A21524.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_562:
			num = (short)1360593940;
			short num3 = num;
			num = (short)1241973780;
			switch ((num3 == num) ? 1 : 0)
			{
			case 0:
			case 2:
				IL_813:
				this.LblScanLstScanListChannel_A7620 = (global::AcpUI.AcpLabel)target;
				this.LblScanLstScanListChannel_A7620.MouseDoubleClick += new global::System.Windows.Input.MouseButtonEventHandler(this.OnFieldNameDoubleClick);
				return;
			default:
				num = (short)2003369984;
				if (num != 0)
				{
				}
				this.ScanLstAdvancedTxSteering_A9572 = (global::AcpUI.AcpCheckBox)target;
				this.ScanLstAdvancedTxSteering_A9572.GotFocus += this.OnFieldNameDoubleClick;
				return;
			}
			IL_5D1:
			this.ScanLstGeneralPriority2Type_A8748Comp = (global::AcpUI.AcpLabel)target;
			return;
			IL_5DE:
			this.CVBtnScanLstGeneralPriority1Type_A8745 = (global::AcpUI.AcpCustomViewCheckBox)target;
			return;
			IL_5EB:
			this.ScanLstScanListZone_A9718Comp = (global::AcpUI.AcpLabel)target;
			return;
			IL_5F8:
			this.LblScanLstGeneralPriority2Type_A8748 = (global::AcpUI.AcpLabel)target;
			this.LblScanLstGeneralPriority2Type_A8748.MouseDoubleClick += new global::System.Windows.Input.MouseButtonEventHandler(this.OnFieldNameDoubleClick);
			return;
			IL_61C:
			this.LblScanLstGeneralPriorityMember1_A8747 = (global::AcpUI.AcpLabel)target;
			this.LblScanLstGeneralPriorityMember1_A8747.MouseDoubleClick += new global::System.Windows.Input.MouseButtonEventHandler(this.OnFieldNameDoubleClick);
			return;
			IL_640:
			this.CVBtnScanLstGeneralPriorityMember1_A8747 = (global::AcpUI.AcpCustomViewCheckBox)target;
			return;
			IL_64D:
			this.CpyBtnScanLstGeneralDesignatedDataMember_A7829 = (global::AcpUI.AcpCopyButton)target;
			return;
			IL_65A:
			this.HLinkAdvanced = (global::System.Windows.Documents.Hyperlink)target;
			this.HLinkAdvanced.Click += this.HLinkClick;
			return;
			IL_67E:
			this.RTDBtnScanLstGeneralDesignatedDataTxRxType_A21525 = (global::AcpUI.AcpRtdButton)target;
			return;
			IL_68B:
			this.RTDBtnScanLstGeneralPriorityMember2_A8749 = (global::AcpUI.AcpRtdButton)target;
			return;
			IL_698:
			this.ScanLstScanListChannel_A7620_Col = (global::Infragistics.Windows.DataPresenter.UnboundField)target;
			return;
			IL_6A5:
			this.LblScanLstGeneralNonPriorityMembers_A8569 = (global::AcpUI.AcpLabel)target;
			this.LblScanLstGeneralNonPriorityMembers_A8569.MouseDoubleClick += new global::System.Windows.Input.MouseButtonEventHandler(this.OnFieldNameDoubleClick);
			return;
			IL_6C9:
			this.ScanLstScanListLTEInterferingFreqPresent_A42196 = (global::AcpUI.AcpLabel)target;
			this.ScanLstScanListLTEInterferingFreqPresent_A42196.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_6ED:
			this.ScanLstGeneralRecord_A8921Comp = (global::AcpUI.AcpLabel)target;
			return;
			IL_6FA:
			this.ThemeBaseObj = (global::AcpUI.Common.AcpThemeBase)target;
			return;
			IL_707:
			this.CVBtnScanLstLabtoolLastVotedChannel_A8419 = (global::AcpUI.AcpCustomViewCheckBox)target;
			return;
			IL_714:
			this.ScanLstGeneralPriority1Type_A8745Comp = (global::AcpUI.AcpLabel)target;
			return;
			IL_721:
			this.RTDBtnScanLstGeneralRecord_A8921 = (global::AcpUI.AcpRtdButton)target;
			return;
			IL_72E:
			this.LblScanLstScanListKeyofScanListMBRTable_A12673 = (global::AcpUI.AcpLabel)target;
			this.LblScanLstScanListKeyofScanListMBRTable_A12673.MouseDoubleClick += new global::System.Windows.Input.MouseButtonEventHandler(this.OnFieldNameDoubleClick);
			return;
			IL_752:
			this.ScanLstGeneralKeyofScanList_A12668 = (global::AcpUI.AcpTextBox)target;
			this.ScanLstGeneralKeyofScanList_A12668.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_776:
			this.LblScanLstGeneralType_A9578 = (global::AcpUI.AcpLabel)target;
			this.LblScanLstGeneralType_A9578.MouseDoubleClick += new global::System.Windows.Input.MouseButtonEventHandler(this.OnFieldNameDoubleClick);
			return;
			IL_79A:
			this.ScanLstAdvancedDisplayStrongestVotedChannel_A7884 = (global::AcpUI.AcpCheckBox)target;
			this.ScanLstAdvancedDisplayStrongestVotedChannel_A7884.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_7BE:
			this.LblScanLstGeneralPriority1Type_A8745 = (global::AcpUI.AcpLabel)target;
			this.LblScanLstGeneralPriority1Type_A8745.MouseDoubleClick += new global::System.Windows.Input.MouseButtonEventHandler(this.OnFieldNameDoubleClick);
			return;
			IL_7E2:
			this.ScanLstScanListChannel_A7620 = (global::AcpUI.AcpComboBox)target;
			this.ScanLstScanListChannel_A7620.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_806:
			this.ScanLstScanListLTEInterferingFreqPresent_A42196_Col = (global::Infragistics.Windows.DataPresenter.UnboundField)target;
			return;
			IL_837:
			this.CVBtnScanLstScanListLTEInterferingFreqPresent_A42196 = (global::AcpUI.AcpCustomViewCheckBox)target;
			return;
			IL_844:
			this.GrpBoxExpanderScanListGeneralPriorityAssignment = (global::AcpUI.AcpGroupBox)target;
			return;
			IL_851:
			this.LblScanLstAdvancedDisplayStrongestVotedChannel_A7884 = (global::AcpUI.AcpLabel)target;
			this.LblScanLstAdvancedDisplayStrongestVotedChannel_A7884.MouseDoubleClick += new global::System.Windows.Input.MouseButtonEventHandler(this.OnFieldNameDoubleClick);
			return;
			IL_875:
			this.ScanLstGeneralPriorityMember2_A8749Comp = (global::AcpUI.AcpLabel)target;
			return;
			IL_882:
			this.RTDBtnScanLstAdvancedDataTxLimitedPatienceTimerms_A7799 = (global::AcpUI.AcpRtdButton)target;
			return;
			IL_88F:
			this.ScanLstGeneralRecord_A8921 = (global::AcpUI.AcpComboBox)target;
			this.ScanLstGeneralRecord_A8921.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_8B3:
			this.ExpanderScanListScanListSRecView = (global::AcpUI.AcpGroupBox)target;
			return;
			IL_8C0:
			this.ScanLstAdvancedVotingScanDelayTimerMs_A9657 = (global::AcpUI.AcpTextBoxSpinner)target;
			this.ScanLstAdvancedVotingScanDelayTimerMs_A9657.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_8E4:
			this.CVBtnScanLstGeneralDesignatedVoiceTxMember_A7830 = (global::AcpUI.AcpCustomViewCheckBox)target;
			return;
			IL_8F1:
			this.ScanLstGeneralNonPriorityMembers_A8569Comp = (global::AcpUI.AcpLabel)target;
			return;
			IL_8FE:
			this.LblScanLstGeneralDesignatedVoiceTxMember_A7830 = (global::AcpUI.AcpLabel)target;
			this.LblScanLstGeneralDesignatedVoiceTxMember_A7830.MouseDoubleClick += new global::System.Windows.Input.MouseButtonEventHandler(this.OnFieldNameDoubleClick);
			return;
			IL_922:
			this.LblScanLstAdvancedDataTxLimitedPatienceTimerms_A7799 = (global::AcpUI.AcpLabel)target;
			this.LblScanLstAdvancedDataTxLimitedPatienceTimerms_A7799.MouseDoubleClick += new global::System.Windows.Input.MouseButtonEventHandler(this.OnFieldNameDoubleClick);
			return;
			IL_946:
			this.ScanLstLabtoolLastVotedChannel_A8419 = (global::AcpUI.AcpTextBoxSpinner)target;
			this.ScanLstLabtoolLastVotedChannel_A8419.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_96A:
			this.ScanLstGeneralDesignatedDataTxRxType_A21525 = (global::AcpUI.AcpComboBox)target;
			this.ScanLstGeneralDesignatedDataTxRxType_A21525.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_98E:
			this.ScanLstGeneralDesignatedVoiceTxMember_A7830 = (global::AcpUI.AcpComboBox)target;
			this.ScanLstGeneralDesignatedVoiceTxMember_A7830.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_9B2:
			this.CpyBtnScanLstAdvancedVotingScanDelayTimerMs_A9657 = (global::AcpUI.AcpCopyButton)target;
			return;
			IL_9BF:
			this.CpyBtnScanLstScanListKeyofScanListMBRTable_A12673 = (global::AcpUI.AcpCopyButton)target;
			return;
			IL_9CC:
			this.CVBtnScanLstAdvancedVotingScanDelayTimerMs_A9657 = (global::AcpUI.AcpCustomViewCheckBox)target;
			return;
			IL_9D9:
			this.RTDBtnScanLstGeneralPriority1Type_A8745 = (global::AcpUI.AcpRtdButton)target;
			return;
			IL_9E6:
			this.LblScanLstGeneralScanType_A9058 = (global::AcpUI.AcpLabel)target;
			this.LblScanLstGeneralScanType_A9058.MouseDoubleClick += new global::System.Windows.Input.MouseButtonEventHandler(this.OnFieldNameDoubleClick);
			return;
			IL_A0A:
			this.GrpBoxExpanderScanListGeneralTrunkingSystem = (global::AcpUI.AcpGroupBox)target;
			return;
			IL_A17:
			this.HLinkScanListMembers = (global::System.Windows.Documents.Hyperlink)target;
			this.HLinkScanListMembers.Click += this.HLinkClick;
			return;
			IL_A3B:
			this.CVBtnScanLstGeneralRecord_A8921 = (global::AcpUI.AcpCustomViewCheckBox)target;
			return;
			IL_A48:
			this.CVBtnScanLstGeneralNonPriorityMembers_A8569 = (global::AcpUI.AcpCustomViewCheckBox)target;
			return;
			IL_A55:
			this.RTDBtnScanLstAdvancedMixedConvVoteScanInactivityTimer_A38724 = (global::AcpUI.AcpRtdButton)target;
			return;
			IL_A62:
			this.ScanLstAdvancedMixedConvVoteScanInactivityTimer_A38724 = (global::AcpUI.AcpTextBoxSpinner)target;
			this.ScanLstAdvancedMixedConvVoteScanInactivityTimer_A38724.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_A86:
			this.RTDBtnScanLstAdvancedTxSteering_A9572 = (global::AcpUI.AcpRtdButton)target;
			return;
			IL_A93:
			this.GrpBoxExpanderScanListGeneralPseudo2 = (global::AcpUI.AcpGroupBox)target;
			return;
			IL_AA0:
			this.ScanLstGeneralDesignatedDataMember_A7829Comp = (global::AcpUI.AcpLabel)target;
			return;
			IL_AAD:
			this.ScanLstScanListKeyofScanListMBRTable_A12673_Col = (global::Infragistics.Windows.DataPresenter.UnboundField)target;
			return;
			IL_AD3:
			goto IL_128D;
			IL_AD8:
			this.RecNavToolbarPageScanList = (global::AcpUI.AcpParentRecNavToolbar)target;
			this.RecNavToolbarPageScanList.ModeClick += this.OnModeClick;
			return;
			IL_AFC:
			this.ScanLstAdvancedDataTxLimitedPatienceTimerms_A7799Comp = (global::AcpUI.AcpLabel)target;
			return;
			IL_B09:
			this.LblScanLstGeneralDesignatedDataTxRxType_A21525 = (global::AcpUI.AcpLabel)target;
			this.LblScanLstGeneralDesignatedDataTxRxType_A21525.MouseDoubleClick += new global::System.Windows.Input.MouseButtonEventHandler(this.OnFieldNameDoubleClick);
			return;
			IL_B2D:
			this.ScanLstGeneralDesignatedVoiceTxMemberType_A21524Comp = (global::AcpUI.AcpLabel)target;
			return;
			IL_B3A:
			this.CpyBtnScanLstGeneralPriorityMember2_A8749 = (global::AcpUI.AcpCopyButton)target;
			return;
			IL_B47:
			this.ScanLstGeneralDesignatedDataTxRxType_A21525Comp = (global::AcpUI.AcpLabel)target;
			return;
			IL_B54:
			this.CpyBtnScanLstGeneralRecord_A8921 = (global::AcpUI.AcpCopyButton)target;
			return;
			IL_B61:
			this.RTDBtnScanLstScanListZone_A9718 = (global::AcpUI.AcpRtdButton)target;
			return;
			IL_B6E:
			this.LblScanLstAdvancedTxSteering_A9572 = (global::AcpUI.AcpLabel)target;
			this.LblScanLstAdvancedTxSteering_A9572.MouseDoubleClick += new global::System.Windows.Input.MouseButtonEventHandler(this.OnFieldNameDoubleClick);
			return;
			IL_B92:
			this.CpyBtnScanLstAdvancedTxSteering_A9572 = (global::AcpUI.AcpCopyButton)target;
			return;
			IL_B9F:
			this.CpyBtnScanLstGeneralPriority2Type_A8748 = (global::AcpUI.AcpCopyButton)target;
			return;
			IL_BAC:
			this.RTDBtnScanLstScanListChannel_A7620 = (global::AcpUI.AcpRtdButton)target;
			return;
			IL_BB9:
			this.ExpanderScanListScanListGrid = (global::System.Windows.Controls.Grid)target;
			return;
			IL_BC6:
			this.CVBtnScanLstAdvancedDataTxLimitedPatienceTimerms_A7799 = (global::AcpUI.AcpCustomViewCheckBox)target;
			return;
			IL_BD3:
			this.gridExpanderScanListScanListSRecView = (global::System.Windows.Controls.Grid)target;
			return;
			IL_BE0:
			this.CVBtnScanLstGeneralPriority2Type_A8748 = (global::AcpUI.AcpCustomViewCheckBox)target;
			return;
			IL_BED:
			this.RTDBtnScanLstGeneralNonPriorityMembers_A8569 = (global::AcpUI.AcpRtdButton)target;
			return;
			IL_BFA:
			this.ExpanderScanListScanList = (global::AcpUI.AcpXamDataPresenter)target;
			return;
			IL_C07:
			this.CVBtnScanLstAdvancedTxSteering_A9572 = (global::AcpUI.AcpCustomViewCheckBox)target;
			return;
			IL_C14:
			this.CpyBtnScanLstScanListLTEInterferingFreqPresent_A42196 = (global::AcpUI.AcpCopyButton)target;
			return;
			IL_C21:
			this.ExpanderScanListScanListMembers = (global::AcpUI.AcpExpander)target;
			return;
			IL_C2E:
			this.CpyBtnScanLstAdvancedDisplayStrongestVotedChannel_A7884 = (global::AcpUI.AcpCopyButton)target;
			return;
			IL_C3B:
			this.LblScanLstAdvancedMixedConvVoteScanInactivityTimer_A38724 = (global::AcpUI.AcpLabel)target;
			this.LblScanLstAdvancedMixedConvVoteScanInactivityTimer_A38724.MouseDoubleClick += new global::System.Windows.Input.MouseButtonEventHandler(this.OnFieldNameDoubleClick);
			return;
			IL_C5F:
			this.Position_37375 = (global::Infragistics.Windows.DataPresenter.UnboundField)target;
			return;
			IL_C6C:
			this.RTDBtnScanLstLabtoolLastVotedChannel_A8419 = (global::AcpUI.AcpRtdButton)target;
			return;
			IL_C79:
			this.ExpanderScanListGeneral = (global::AcpUI.AcpExpander)target;
			return;
			IL_C86:
			this.CpyBtnScanLstGeneralPriorityMember1_A8747 = (global::AcpUI.AcpCopyButton)target;
			return;
			IL_C93:
			this.ScanLstAdvancedMixedConvVoteScanInactivityTimer_A38724Comp = (global::AcpUI.AcpLabel)target;
			return;
			IL_CA0:
			this.ScanLstLabtoolLastVotedZone_A8420 = (global::AcpUI.AcpTextBoxSpinner)target;
			this.ScanLstLabtoolLastVotedZone_A8420.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_CC4:
			this.ExpanderScanListAdvanced = (global::AcpUI.AcpExpander)target;
			return;
			IL_CD1:
			this.RTDBtnScanLstGeneralDesignatedVoiceTxMember_A7830 = (global::AcpUI.AcpRtdButton)target;
			return;
			IL_CDE:
			this.LblScanLstGeneralKeyofScanList_A12668 = (global::AcpUI.AcpLabel)target;
			this.LblScanLstGeneralKeyofScanList_A12668.MouseDoubleClick += new global::System.Windows.Input.MouseButtonEventHandler(this.OnFieldNameDoubleClick);
			return;
			IL_D02:
			this.ScanLstScanListZone_A9718_Col = (global::Infragistics.Windows.DataPresenter.UnboundField)target;
			return;
			IL_D0F:
			this.ScanLstGeneralPriorityMember2_A8749 = (global::AcpUI.AcpComboBox)target;
			this.ScanLstGeneralPriorityMember2_A8749.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_D33:
			this.CVBtnScanLstGeneralDesignatedVoiceTxMemberType_A21524 = (global::AcpUI.AcpCustomViewCheckBox)target;
			return;
			IL_D40:
			this.ScanLstLabtoolLTEInterferingFreqPresent_A42197Comp = (global::AcpUI.AcpLabel)target;
			return;
			IL_D4D:
			this.CpyBtnScanLstGeneralDesignatedDataTxRxType_A21525 = (global::AcpUI.AcpCopyButton)target;
			return;
			IL_D5A:
			this.GrpBoxExpanderScanListGeneralPseudo0 = (global::AcpUI.AcpGroupBox)target;
			return;
			IL_D67:
			this.ScanLstGeneralKeyofScanList_A12668Comp = (global::AcpUI.AcpLabel)target;
			return;
			IL_D74:
			this.ScanLstGeneralScanType_A9058Comp = (global::AcpUI.AcpLabel)target;
			return;
			IL_D81:
			this.ExpanderScanListScanListMembersGrid = (global::System.Windows.Controls.Grid)target;
			return;
			IL_D8E:
			this.RTDBtnScanLstScanListLTEInterferingFreqPresent_A42196 = (global::AcpUI.AcpRtdButton)target;
			return;
			IL_D9B:
			this.CVBtnScanLstAdvancedMixedConvVoteScanInactivityTimer_A38724 = (global::AcpUI.AcpCustomViewCheckBox)target;
			return;
			IL_DA8:
			this.GrpBoxExpanderScanListAdvancedPseudo0 = (global::AcpUI.AcpGroupBox)target;
			return;
			IL_DB5:
			this.CVBtnScanLstLabtoolLastVotedZone_A8420 = (global::AcpUI.AcpCustomViewCheckBox)target;
			return;
			IL_DC2:
			this.ScanLstGeneralPriorityMember1_A8747 = (global::AcpUI.AcpComboBox)target;
			this.ScanLstGeneralPriorityMember1_A8747.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_DE6:
			this.LblScanLstGeneralDesignatedDataMember_A7829 = (global::AcpUI.AcpLabel)target;
			this.LblScanLstGeneralDesignatedDataMember_A7829.MouseDoubleClick += new global::System.Windows.Input.MouseButtonEventHandler(this.OnFieldNameDoubleClick);
			return;
			IL_E0A:
			this.GrpBoxExpanderScanListLabtoolPseudo0 = (global::AcpUI.AcpGroupBox)target;
			return;
			IL_E17:
			this.ScanLstLabtoolLTEInterferingFreqPresent_A42197 = (global::AcpUI.AcpLabel)target;
			this.ScanLstLabtoolLTEInterferingFreqPresent_A42197.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_E3B:
			this.ScanLstGeneralNonPriorityMembers_A8569 = (global::AcpUI.AcpComboBox)target;
			this.ScanLstGeneralNonPriorityMembers_A8569.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_E5F:
			this.RTDBtnScanLstGeneralPriorityMember1_A8747 = (global::AcpUI.AcpRtdButton)target;
			return;
			IL_E6C:
			this.ExpanderScanListScanListTableView = (global::AcpUI.AcpGroupBox)target;
			return;
			IL_E79:
			this.RTDBtnScanLstLabtoolLastVotedZone_A8420 = (global::AcpUI.AcpRtdButton)target;
			return;
			IL_E86:
			this.CpyBtnScanLstLabtoolLastVotedZone_A8420 = (global::AcpUI.AcpCopyButton)target;
			return;
			IL_E93:
			this.RTDBtnScanLstGeneralPriority2Type_A8748 = (global::AcpUI.AcpRtdButton)target;
			return;
			IL_EA0:
			this.RTDBtnScanLstGeneralDesignatedVoiceTxMemberType_A21524 = (global::AcpUI.AcpRtdButton)target;
			return;
			IL_EAD:
			this.LblScanLstLabtoolLastVotedZone_A8420 = (global::AcpUI.AcpLabel)target;
			this.LblScanLstLabtoolLastVotedZone_A8420.MouseDoubleClick += new global::System.Windows.Input.MouseButtonEventHandler(this.OnFieldNameDoubleClick);
			return;
			IL_ED1:
			this.ScanLstScanListKeyofScanListMBRTable_A12673Comp = (global::AcpUI.AcpLabel)target;
			return;
			IL_EDE:
			this.ScanLstAdvancedDataTxLimitedPatienceTimerms_A7799 = (global::AcpUI.AcpTextBoxSpinner)target;
			this.ScanLstAdvancedDataTxLimitedPatienceTimerms_A7799.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_F02:
			this.ScanLstGeneralDynamicPriority_A7915 = (global::AcpUI.AcpCheckBox)target;
			this.ScanLstGeneralDynamicPriority_A7915.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_F26:
			this.ScanLstGeneralScanType_A9058 = (global::AcpUI.AcpComboBox)target;
			this.ScanLstGeneralScanType_A9058.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_F4A:
			this.CVBtnScanLstGeneralDesignatedDataMember_A7829 = (global::AcpUI.AcpCustomViewCheckBox)target;
			return;
			IL_F57:
			this.CpyBtnScanLstLabtoolLastVotedChannel_A8419 = (global::AcpUI.AcpCopyButton)target;
			return;
			IL_F64:
			this.MyStackPanel = (global::System.Windows.Controls.StackPanel)target;
			return;
			IL_F71:
			this.CpyBtnScanLstGeneralScanType_A9058 = (global::AcpUI.AcpCopyButton)target;
			return;
			IL_F7E:
			this.CVBtnScanLstGeneralDynamicPriority_A7915 = (global::AcpUI.AcpCustomViewCheckBox)target;
			return;
			IL_F8B:
			this.CVBtnScanLstGeneralScanType_A9058 = (global::AcpUI.AcpCustomViewCheckBox)target;
			return;
			IL_F98:
			this.CVBtnScanLstGeneralPriorityMember2_A8749 = (global::AcpUI.AcpCustomViewCheckBox)target;
			return;
			IL_FA5:
			num = (short)1189281793;
			if (num != 0)
			{
			}
			this.RTDBtnScanLstGeneralScanType_A9058 = (global::AcpUI.AcpRtdButton)target;
			return;
			IL_FD8:
			this.CVBtnScanLstScanListZone_A9718 = (global::AcpUI.AcpCustomViewCheckBox)target;
			return;
			IL_FE5:
			this.ScanLstScanListChannel_A7620Comp = (global::AcpUI.AcpLabel)target;
			return;
			IL_FF2:
			this.ScanLstGeneralPriority2Type_A8748 = (global::AcpUI.AcpComboBox)target;
			this.ScanLstGeneralPriority2Type_A8748.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_1016:
			this.RTDBtnScanLstAdvancedDisplayStrongestVotedChannel_A7884 = (global::AcpUI.AcpRtdButton)target;
			return;
			IL_1023:
			this.ScanLstGeneralDesignatedDataMember_A7829 = (global::AcpUI.AcpComboBox)target;
			this.ScanLstGeneralDesignatedDataMember_A7829.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_1047:
			this.RTDBtnScanLstGeneralType_A9578 = (global::AcpUI.AcpRtdButton)target;
			return;
			IL_1054:
			this.ScanLstLabtoolLastVotedZone_A8420Comp = (global::AcpUI.AcpLabel)target;
			return;
			IL_1061:
			this.RTDBtnScanLstLabtoolLTEInterferingFreqPresent_A42197 = (global::AcpUI.AcpRtdButton)target;
			return;
			IL_106E:
			this.CpyBtnScanLstGeneralKeyofScanList_A12668 = (global::AcpUI.AcpCopyButton)target;
			return;
			IL_107B:
			this.CVBtnScanLstScanListChannel_A7620 = (global::AcpUI.AcpCustomViewCheckBox)target;
			return;
			IL_1088:
			this.CVBtnScanLstAdvancedDisplayStrongestVotedChannel_A7884 = (global::AcpUI.AcpCustomViewCheckBox)target;
			return;
			IL_1095:
			this.RTDBtnScanLstAdvancedVotingScanDelayTimerMs_A9657 = (global::AcpUI.AcpRtdButton)target;
			return;
			IL_10A2:
			this.CVBtnScanLstGeneralDesignatedDataTxRxType_A21525 = (global::AcpUI.AcpCustomViewCheckBox)target;
			return;
			IL_10AF:
			this.CVBtnScanLstScanListKeyofScanListMBRTable_A12673 = (global::AcpUI.AcpCustomViewCheckBox)target;
			return;
			IL_10BC:
			this.RTDBtnScanLstGeneralDesignatedDataMember_A7829 = (global::AcpUI.AcpRtdButton)target;
			return;
			IL_10C9:
			this.ScanLstGeneralDynamicPriority_A7915Comp = (global::AcpUI.AcpCheckBox)target;
			return;
			IL_10D6:
			num = (short)716636160;
			short num4 = num;
			this.CpyBtnScanLstScanListChannel_A7620 = (global::AcpUI.AcpCopyButton)target;
			return;
			IL_110C:
			this.ScanLstGeneralType_A9578 = (global::AcpUI.AcpLabel)target;
			this.ScanLstGeneralType_A9578.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_1130:
			this.LblScanLstScanListZone_A9718 = (global::AcpUI.AcpLabel)target;
			this.LblScanLstScanListZone_A9718.MouseDoubleClick += new global::System.Windows.Input.MouseButtonEventHandler(this.OnFieldNameDoubleClick);
			return;
			IL_1154:
			this.HLinkGeneral = (global::System.Windows.Documents.Hyperlink)target;
			this.HLinkGeneral.Click += this.HLinkClick;
			return;
			IL_1178:
			this.CpyBtnScanLstLabtoolLTEInterferingFreqPresent_A42197 = (global::AcpUI.AcpCopyButton)target;
			return;
			IL_1185:
			this.CVBtnScanLstGeneralKeyofScanList_A12668 = (global::AcpUI.AcpCustomViewCheckBox)target;
			return;
			IL_1192:
			this.ScanLstScanListKeyofScanListMBRTable_A12673 = (global::AcpUI.AcpLabel)target;
			this.ScanLstScanListKeyofScanListMBRTable_A12673.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_11B6:
			this.ScanLstGeneralDesignatedVoiceTxMember_A7830Comp = (global::AcpUI.AcpLabel)target;
			return;
			IL_11C3:
			this.ScanLstScanListLTEInterferingFreqPresent_A42196Comp = (global::AcpUI.AcpLabel)target;
			return;
			IL_11D0:
			this.CVBtnScanLstLabtoolLTEInterferingFreqPresent_A42197 = (global::AcpUI.AcpCustomViewCheckBox)target;
			return;
			IL_11DD:
			this.RTDBtnScanLstGeneralDynamicPriority_A7915 = (global::AcpUI.AcpRtdButton)target;
			return;
			IL_11EA:
			this.ScanLstLabtoolLastVotedChannel_A8419Comp = (global::AcpUI.AcpLabel)target;
			return;
			IL_11F7:
			this.CpyBtnScanLstGeneralDesignatedVoiceTxMemberType_A21524 = (global::AcpUI.AcpCopyButton)target;
			return;
			IL_1204:
			this.LblScanLstGeneralPriorityMember2_A8749 = (global::AcpUI.AcpLabel)target;
			this.LblScanLstGeneralPriorityMember2_A8749.MouseDoubleClick += new global::System.Windows.Input.MouseButtonEventHandler(this.OnFieldNameDoubleClick);
			return;
			IL_1228:
			this.CpyBtnScanLstAdvancedDataTxLimitedPatienceTimerms_A7799 = (global::AcpUI.AcpCopyButton)target;
			return;
			IL_1235:
			this.HLinkLabtool = (global::System.Windows.Documents.Hyperlink)target;
			this.HLinkLabtool.Click += this.HLinkClick;
			return;
			IL_1259:
			this.ScanLstGeneralPriorityMember1_A8747Comp = (global::AcpUI.AcpLabel)target;
			return;
			IL_1266:
			this.ScanLstAdvancedTxSteering_A9572Comp = (global::AcpUI.AcpCheckBox)target;
			return;
			IL_1273:
			this.CpyBtnScanLstGeneralNonPriorityMembers_A8569 = (global::AcpUI.AcpCopyButton)target;
			return;
			IL_1280:
			this.ScanLstAdvancedDisplayStrongestVotedChannel_A7884Comp = (global::AcpUI.AcpCheckBox)target;
			return;
			IL_128D:
			this.b = true;
		}

		// Token: 0x060029FC RID: 10748 RVA: 0x0028F20C File Offset: 0x0028D40C
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		[global::System.CodeDom.Compiler.GeneratedCode("PresentationBuildTasks", "5.0.10.0")]
		[global::System.Diagnostics.DebuggerNonUserCode]
		void global::System.Windows.Markup.IStyleConnector.Connect(int connectionId, object target)
		{
			short num;
			switch (connectionId)
			{
			case 3:
				break;
			case 4:
				((global::AcpUI.AcpTableComboBox)target).GotFocus += this.OnFieldNameDoubleClick;
				return;
			case 5:
				((global::AcpUI.AcpTableComboBox)target).GotFocus += this.OnFieldNameDoubleClick;
				return;
			case 6:
				((global::AcpUI.AcpTableCheckBox)target).GotFocus += this.OnFieldNameDoubleClick;
				return;
			default:
			{
				num = (short)1976485270;
				short num2 = num;
				num = (short)256427414;
				switch ((num2 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					break;
				default:
				{
					num = (short)469368832;
					if (num != 0)
					{
					}
					num = (short)820772864;
					short num3 = num;
					return;
				}
				}
				break;
			}
			}
			num = (short)1619197953;
			if (num != 0)
			{
			}
			((global::AcpUI.AcpTableViewOnlyCtrl)target).GotFocus += this.OnFieldNameDoubleClick;
		}

		// Token: 0x04000F06 RID: 3846
		private bool a;

		// Token: 0x04000F07 RID: 3847
		internal global::AcpUI.AcpParentRecNavToolbar RecNavToolbarPageScanList;

		// Token: 0x04000F08 RID: 3848
		internal global::AcpUI.Common.AcpThemeBase ThemeBaseObj;

		// Token: 0x04000F09 RID: 3849
		internal global::System.Windows.Documents.Hyperlink HLinkGeneral;

		// Token: 0x04000F0A RID: 3850
		internal global::System.Windows.Documents.Hyperlink HLinkAdvanced;

		// Token: 0x04000F0B RID: 3851
		internal global::System.Windows.Documents.Hyperlink HLinkScanListMembers;

		// Token: 0x04000F0C RID: 3852
		internal global::System.Windows.Documents.Hyperlink HLinkLabtool;

		// Token: 0x04000F0D RID: 3853
		internal global::System.Windows.Controls.StackPanel MyStackPanel;

		// Token: 0x04000F0E RID: 3854
		internal global::AcpUI.AcpExpander ExpanderScanListGeneral;

		// Token: 0x04000F0F RID: 3855
		internal global::AcpUI.AcpGroupBox GrpBoxExpanderScanListGeneralPseudo0;

		// Token: 0x04000F10 RID: 3856
		internal global::AcpUI.AcpCustomViewCheckBox CVBtnScanLstGeneralKeyofScanList_A12668;

		// Token: 0x04000F11 RID: 3857
		internal global::AcpUI.AcpLabel LblScanLstGeneralKeyofScanList_A12668;

		// Token: 0x04000F12 RID: 3858
		internal global::AcpUI.AcpTextBox ScanLstGeneralKeyofScanList_A12668;

		// Token: 0x04000F13 RID: 3859
		internal global::AcpUI.AcpCopyButton CpyBtnScanLstGeneralKeyofScanList_A12668;

		// Token: 0x04000F14 RID: 3860
		internal global::AcpUI.AcpLabel ScanLstGeneralKeyofScanList_A12668Comp;

		// Token: 0x04000F15 RID: 3861
		internal global::AcpUI.AcpCustomViewCheckBox CVBtnScanLstGeneralScanType_A9058;

		// Token: 0x04000F16 RID: 3862
		internal global::AcpUI.AcpLabel LblScanLstGeneralScanType_A9058;

		// Token: 0x04000F17 RID: 3863
		internal global::AcpUI.AcpComboBox ScanLstGeneralScanType_A9058;

		// Token: 0x04000F18 RID: 3864
		internal global::AcpUI.AcpRtdButton RTDBtnScanLstGeneralScanType_A9058;

		// Token: 0x04000F19 RID: 3865
		internal global::AcpUI.AcpCopyButton CpyBtnScanLstGeneralScanType_A9058;

		// Token: 0x04000F1A RID: 3866
		internal global::AcpUI.AcpLabel ScanLstGeneralScanType_A9058Comp;

		// Token: 0x04000F1B RID: 3867
		internal global::AcpUI.AcpGroupBox GrpBoxExpanderScanListGeneralTrunkingSystem;

		// Token: 0x04000F1C RID: 3868
		internal global::AcpUI.AcpCustomViewCheckBox CVBtnScanLstGeneralRecord_A8921;

		// Token: 0x04000F1D RID: 3869
		internal global::AcpUI.AcpLabel LblScanLstGeneralRecord_A8921;

		// Token: 0x04000F1E RID: 3870
		internal global::AcpUI.AcpComboBox ScanLstGeneralRecord_A8921;

		// Token: 0x04000F1F RID: 3871
		internal global::AcpUI.AcpRtdButton RTDBtnScanLstGeneralRecord_A8921;

		// Token: 0x04000F20 RID: 3872
		internal global::AcpUI.AcpCopyButton CpyBtnScanLstGeneralRecord_A8921;

		// Token: 0x04000F21 RID: 3873
		internal global::AcpUI.AcpLabel ScanLstGeneralRecord_A8921Comp;

		// Token: 0x04000F22 RID: 3874
		internal global::AcpUI.AcpCustomViewCheckBox CVBtnScanLstGeneralType_A9578;

		// Token: 0x04000F23 RID: 3875
		internal global::AcpUI.AcpLabel LblScanLstGeneralType_A9578;

		// Token: 0x04000F24 RID: 3876
		internal global::AcpUI.AcpLabel ScanLstGeneralType_A9578;

		// Token: 0x04000F25 RID: 3877
		internal global::AcpUI.AcpRtdButton RTDBtnScanLstGeneralType_A9578;

		// Token: 0x04000F26 RID: 3878
		internal global::AcpUI.AcpGroupBox GrpBoxExpanderScanListGeneralPriorityAssignment;

		// Token: 0x04000F27 RID: 3879
		internal global::AcpUI.AcpCustomViewCheckBox CVBtnScanLstGeneralDynamicPriority_A7915;

		// Token: 0x04000F28 RID: 3880
		internal global::AcpUI.AcpLabel LblScanLstGeneralDynamicPriority_A7915;

		// Token: 0x04000F29 RID: 3881
		internal global::AcpUI.AcpCheckBox ScanLstGeneralDynamicPriority_A7915;

		// Token: 0x04000F2A RID: 3882
		internal global::AcpUI.AcpRtdButton RTDBtnScanLstGeneralDynamicPriority_A7915;

		// Token: 0x04000F2B RID: 3883
		internal global::AcpUI.AcpCopyButton CpyBtnScanLstGeneralDynamicPriority_A7915;

		// Token: 0x04000F2C RID: 3884
		internal global::AcpUI.AcpCheckBox ScanLstGeneralDynamicPriority_A7915Comp;

		// Token: 0x04000F2D RID: 3885
		internal global::AcpUI.AcpCustomViewCheckBox CVBtnScanLstGeneralPriority1Type_A8745;

		// Token: 0x04000F2E RID: 3886
		internal global::AcpUI.AcpLabel LblScanLstGeneralPriority1Type_A8745;

		// Token: 0x04000F2F RID: 3887
		internal global::AcpUI.AcpComboBox ScanLstGeneralPriority1Type_A8745;

		// Token: 0x04000F30 RID: 3888
		internal global::AcpUI.AcpRtdButton RTDBtnScanLstGeneralPriority1Type_A8745;

		// Token: 0x04000F31 RID: 3889
		internal global::AcpUI.AcpCopyButton CpyBtnScanLstGeneralPriority1Type_A8745;

		// Token: 0x04000F32 RID: 3890
		internal global::AcpUI.AcpLabel ScanLstGeneralPriority1Type_A8745Comp;

		// Token: 0x04000F33 RID: 3891
		internal global::AcpUI.AcpCustomViewCheckBox CVBtnScanLstGeneralPriorityMember1_A8747;

		// Token: 0x04000F34 RID: 3892
		internal global::AcpUI.AcpLabel LblScanLstGeneralPriorityMember1_A8747;

		// Token: 0x04000F35 RID: 3893
		internal global::AcpUI.AcpComboBox ScanLstGeneralPriorityMember1_A8747;

		// Token: 0x04000F36 RID: 3894
		internal global::AcpUI.AcpRtdButton RTDBtnScanLstGeneralPriorityMember1_A8747;

		// Token: 0x04000F37 RID: 3895
		internal global::AcpUI.AcpCopyButton CpyBtnScanLstGeneralPriorityMember1_A8747;

		// Token: 0x04000F38 RID: 3896
		internal global::AcpUI.AcpLabel ScanLstGeneralPriorityMember1_A8747Comp;

		// Token: 0x04000F39 RID: 3897
		internal global::AcpUI.AcpCustomViewCheckBox CVBtnScanLstGeneralPriority2Type_A8748;

		// Token: 0x04000F3A RID: 3898
		internal global::AcpUI.AcpLabel LblScanLstGeneralPriority2Type_A8748;

		// Token: 0x04000F3B RID: 3899
		internal global::AcpUI.AcpComboBox ScanLstGeneralPriority2Type_A8748;

		// Token: 0x04000F3C RID: 3900
		internal global::AcpUI.AcpRtdButton RTDBtnScanLstGeneralPriority2Type_A8748;

		// Token: 0x04000F3D RID: 3901
		internal global::AcpUI.AcpCopyButton CpyBtnScanLstGeneralPriority2Type_A8748;

		// Token: 0x04000F3E RID: 3902
		internal global::AcpUI.AcpLabel ScanLstGeneralPriority2Type_A8748Comp;

		// Token: 0x04000F3F RID: 3903
		internal global::AcpUI.AcpCustomViewCheckBox CVBtnScanLstGeneralPriorityMember2_A8749;

		// Token: 0x04000F40 RID: 3904
		internal global::AcpUI.AcpLabel LblScanLstGeneralPriorityMember2_A8749;

		// Token: 0x04000F41 RID: 3905
		internal global::AcpUI.AcpComboBox ScanLstGeneralPriorityMember2_A8749;

		// Token: 0x04000F42 RID: 3906
		internal global::AcpUI.AcpRtdButton RTDBtnScanLstGeneralPriorityMember2_A8749;

		// Token: 0x04000F43 RID: 3907
		internal global::AcpUI.AcpCopyButton CpyBtnScanLstGeneralPriorityMember2_A8749;

		// Token: 0x04000F44 RID: 3908
		internal global::AcpUI.AcpLabel ScanLstGeneralPriorityMember2_A8749Comp;

		// Token: 0x04000F45 RID: 3909
		internal global::AcpUI.AcpGroupBox GrpBoxExpanderScanListGeneralPseudo2;

		// Token: 0x04000F46 RID: 3910
		internal global::AcpUI.AcpCustomViewCheckBox CVBtnScanLstGeneralNonPriorityMembers_A8569;

		// Token: 0x04000F47 RID: 3911
		internal global::AcpUI.AcpLabel LblScanLstGeneralNonPriorityMembers_A8569;

		// Token: 0x04000F48 RID: 3912
		internal global::AcpUI.AcpComboBox ScanLstGeneralNonPriorityMembers_A8569;

		// Token: 0x04000F49 RID: 3913
		internal global::AcpUI.AcpRtdButton RTDBtnScanLstGeneralNonPriorityMembers_A8569;

		// Token: 0x04000F4A RID: 3914
		internal global::AcpUI.AcpCopyButton CpyBtnScanLstGeneralNonPriorityMembers_A8569;

		// Token: 0x04000F4B RID: 3915
		internal global::AcpUI.AcpLabel ScanLstGeneralNonPriorityMembers_A8569Comp;

		// Token: 0x04000F4C RID: 3916
		internal global::AcpUI.AcpCustomViewCheckBox CVBtnScanLstGeneralDesignatedVoiceTxMemberType_A21524;

		// Token: 0x04000F4D RID: 3917
		internal global::AcpUI.AcpLabel LblScanLstGeneralDesignatedVoiceTxMemberType_A21524;

		// Token: 0x04000F4E RID: 3918
		internal global::AcpUI.AcpComboBox ScanLstGeneralDesignatedVoiceTxMemberType_A21524;

		// Token: 0x04000F4F RID: 3919
		internal global::AcpUI.AcpRtdButton RTDBtnScanLstGeneralDesignatedVoiceTxMemberType_A21524;

		// Token: 0x04000F50 RID: 3920
		internal global::AcpUI.AcpCopyButton CpyBtnScanLstGeneralDesignatedVoiceTxMemberType_A21524;

		// Token: 0x04000F51 RID: 3921
		internal global::AcpUI.AcpLabel ScanLstGeneralDesignatedVoiceTxMemberType_A21524Comp;

		// Token: 0x04000F52 RID: 3922
		internal global::AcpUI.AcpCustomViewCheckBox CVBtnScanLstGeneralDesignatedVoiceTxMember_A7830;

		// Token: 0x04000F53 RID: 3923
		internal global::AcpUI.AcpLabel LblScanLstGeneralDesignatedVoiceTxMember_A7830;

		// Token: 0x04000F54 RID: 3924
		internal global::AcpUI.AcpComboBox ScanLstGeneralDesignatedVoiceTxMember_A7830;

		// Token: 0x04000F55 RID: 3925
		internal global::AcpUI.AcpRtdButton RTDBtnScanLstGeneralDesignatedVoiceTxMember_A7830;

		// Token: 0x04000F56 RID: 3926
		internal global::AcpUI.AcpCopyButton CpyBtnScanLstGeneralDesignatedVoiceTxMember_A7830;

		// Token: 0x04000F57 RID: 3927
		internal global::AcpUI.AcpLabel ScanLstGeneralDesignatedVoiceTxMember_A7830Comp;

		// Token: 0x04000F58 RID: 3928
		internal global::AcpUI.AcpCustomViewCheckBox CVBtnScanLstGeneralDesignatedDataTxRxType_A21525;

		// Token: 0x04000F59 RID: 3929
		internal global::AcpUI.AcpLabel LblScanLstGeneralDesignatedDataTxRxType_A21525;

		// Token: 0x04000F5A RID: 3930
		internal global::AcpUI.AcpComboBox ScanLstGeneralDesignatedDataTxRxType_A21525;

		// Token: 0x04000F5B RID: 3931
		internal global::AcpUI.AcpRtdButton RTDBtnScanLstGeneralDesignatedDataTxRxType_A21525;

		// Token: 0x04000F5C RID: 3932
		internal global::AcpUI.AcpCopyButton CpyBtnScanLstGeneralDesignatedDataTxRxType_A21525;

		// Token: 0x04000F5D RID: 3933
		internal global::AcpUI.AcpLabel ScanLstGeneralDesignatedDataTxRxType_A21525Comp;

		// Token: 0x04000F5E RID: 3934
		internal global::AcpUI.AcpCustomViewCheckBox CVBtnScanLstGeneralDesignatedDataMember_A7829;

		// Token: 0x04000F5F RID: 3935
		internal global::AcpUI.AcpLabel LblScanLstGeneralDesignatedDataMember_A7829;

		// Token: 0x04000F60 RID: 3936
		internal global::AcpUI.AcpComboBox ScanLstGeneralDesignatedDataMember_A7829;

		// Token: 0x04000F61 RID: 3937
		internal global::AcpUI.AcpRtdButton RTDBtnScanLstGeneralDesignatedDataMember_A7829;

		// Token: 0x04000F62 RID: 3938
		internal global::AcpUI.AcpCopyButton CpyBtnScanLstGeneralDesignatedDataMember_A7829;

		// Token: 0x04000F63 RID: 3939
		internal global::AcpUI.AcpLabel ScanLstGeneralDesignatedDataMember_A7829Comp;

		// Token: 0x04000F64 RID: 3940
		internal global::AcpUI.AcpExpander ExpanderScanListAdvanced;

		// Token: 0x04000F65 RID: 3941
		internal global::AcpUI.AcpGroupBox GrpBoxExpanderScanListAdvancedPseudo0;

		// Token: 0x04000F66 RID: 3942
		internal global::AcpUI.AcpCustomViewCheckBox CVBtnScanLstAdvancedDataTxLimitedPatienceTimerms_A7799;

		// Token: 0x04000F67 RID: 3943
		internal global::AcpUI.AcpLabel LblScanLstAdvancedDataTxLimitedPatienceTimerms_A7799;

		// Token: 0x04000F68 RID: 3944
		internal global::AcpUI.AcpTextBoxSpinner ScanLstAdvancedDataTxLimitedPatienceTimerms_A7799;

		// Token: 0x04000F69 RID: 3945
		internal global::AcpUI.AcpRtdButton RTDBtnScanLstAdvancedDataTxLimitedPatienceTimerms_A7799;

		// Token: 0x04000F6A RID: 3946
		internal global::AcpUI.AcpCopyButton CpyBtnScanLstAdvancedDataTxLimitedPatienceTimerms_A7799;

		// Token: 0x04000F6B RID: 3947
		internal global::AcpUI.AcpLabel ScanLstAdvancedDataTxLimitedPatienceTimerms_A7799Comp;

		// Token: 0x04000F6C RID: 3948
		internal global::AcpUI.AcpCustomViewCheckBox CVBtnScanLstAdvancedVotingScanDelayTimerMs_A9657;

		// Token: 0x04000F6D RID: 3949
		internal global::AcpUI.AcpLabel LblScanLstAdvancedVotingScanDelayTimerMs_A9657;

		// Token: 0x04000F6E RID: 3950
		internal global::AcpUI.AcpTextBoxSpinner ScanLstAdvancedVotingScanDelayTimerMs_A9657;

		// Token: 0x04000F6F RID: 3951
		internal global::AcpUI.AcpRtdButton RTDBtnScanLstAdvancedVotingScanDelayTimerMs_A9657;

		// Token: 0x04000F70 RID: 3952
		internal global::AcpUI.AcpCopyButton CpyBtnScanLstAdvancedVotingScanDelayTimerMs_A9657;

		// Token: 0x04000F71 RID: 3953
		internal global::AcpUI.AcpLabel ScanLstAdvancedVotingScanDelayTimerMs_A9657Comp;

		// Token: 0x04000F72 RID: 3954
		internal global::AcpUI.AcpCustomViewCheckBox CVBtnScanLstAdvancedDisplayStrongestVotedChannel_A7884;

		// Token: 0x04000F73 RID: 3955
		internal global::AcpUI.AcpLabel LblScanLstAdvancedDisplayStrongestVotedChannel_A7884;

		// Token: 0x04000F74 RID: 3956
		internal global::AcpUI.AcpCheckBox ScanLstAdvancedDisplayStrongestVotedChannel_A7884;

		// Token: 0x04000F75 RID: 3957
		internal global::AcpUI.AcpRtdButton RTDBtnScanLstAdvancedDisplayStrongestVotedChannel_A7884;

		// Token: 0x04000F76 RID: 3958
		internal global::AcpUI.AcpCopyButton CpyBtnScanLstAdvancedDisplayStrongestVotedChannel_A7884;

		// Token: 0x04000F77 RID: 3959
		internal global::AcpUI.AcpCheckBox ScanLstAdvancedDisplayStrongestVotedChannel_A7884Comp;

		// Token: 0x04000F78 RID: 3960
		internal global::AcpUI.AcpCustomViewCheckBox CVBtnScanLstAdvancedTxSteering_A9572;

		// Token: 0x04000F79 RID: 3961
		internal global::AcpUI.AcpLabel LblScanLstAdvancedTxSteering_A9572;

		// Token: 0x04000F7A RID: 3962
		internal global::AcpUI.AcpCheckBox ScanLstAdvancedTxSteering_A9572;

		// Token: 0x04000F7B RID: 3963
		internal global::AcpUI.AcpRtdButton RTDBtnScanLstAdvancedTxSteering_A9572;

		// Token: 0x04000F7C RID: 3964
		internal global::AcpUI.AcpCopyButton CpyBtnScanLstAdvancedTxSteering_A9572;

		// Token: 0x04000F7D RID: 3965
		internal global::AcpUI.AcpCheckBox ScanLstAdvancedTxSteering_A9572Comp;

		// Token: 0x04000F7E RID: 3966
		internal global::AcpUI.AcpCustomViewCheckBox CVBtnScanLstAdvancedMixedConvVoteScanInactivityTimer_A38724;

		// Token: 0x04000F7F RID: 3967
		internal global::AcpUI.AcpLabel LblScanLstAdvancedMixedConvVoteScanInactivityTimer_A38724;

		// Token: 0x04000F80 RID: 3968
		internal global::AcpUI.AcpTextBoxSpinner ScanLstAdvancedMixedConvVoteScanInactivityTimer_A38724;

		// Token: 0x04000F81 RID: 3969
		internal global::AcpUI.AcpRtdButton RTDBtnScanLstAdvancedMixedConvVoteScanInactivityTimer_A38724;

		// Token: 0x04000F82 RID: 3970
		internal global::AcpUI.AcpCopyButton CpyBtnScanLstAdvancedMixedConvVoteScanInactivityTimer_A38724;

		// Token: 0x04000F83 RID: 3971
		internal global::AcpUI.AcpLabel ScanLstAdvancedMixedConvVoteScanInactivityTimer_A38724Comp;

		// Token: 0x04000F84 RID: 3972
		internal global::AcpUI.AcpExpander ExpanderScanListScanListMembers;

		// Token: 0x04000F85 RID: 3973
		internal global::AcpUI.AcpChildRecNavToolbar RecNavToolbarExpanderScanListScanList;

		// Token: 0x04000F86 RID: 3974
		internal global::System.Windows.Controls.Grid ExpanderScanListScanListMembersGrid;

		// Token: 0x04000F87 RID: 3975
		internal global::System.Windows.Controls.Grid ExpanderScanListScanListGrid;

		// Token: 0x04000F88 RID: 3976
		internal global::AcpUI.AcpGroupBox ExpanderScanListScanListTableView;

		// Token: 0x04000F89 RID: 3977
		internal global::AcpUI.AcpXamDataPresenter ExpanderScanListScanList;

		// Token: 0x04000F8A RID: 3978
		internal global::Infragistics.Windows.DataPresenter.UnboundField Position_37375;

		// Token: 0x04000F8B RID: 3979
		internal global::Infragistics.Windows.DataPresenter.UnboundField ScanLstScanListKeyofScanListMBRTable_A12673_Col;

		// Token: 0x04000F8C RID: 3980
		internal global::Infragistics.Windows.DataPresenter.UnboundField ScanLstScanListZone_A9718_Col;

		// Token: 0x04000F8D RID: 3981
		internal global::Infragistics.Windows.DataPresenter.UnboundField ScanLstScanListChannel_A7620_Col;

		// Token: 0x04000F8E RID: 3982
		internal global::Infragistics.Windows.DataPresenter.UnboundField ScanLstScanListLTEInterferingFreqPresent_A42196_Col;

		// Token: 0x04000F8F RID: 3983
		internal global::AcpUI.AcpGroupBox ExpanderScanListScanListSRecView;

		// Token: 0x04000F90 RID: 3984
		internal global::System.Windows.Controls.Grid gridExpanderScanListScanListSRecView;

		// Token: 0x04000F91 RID: 3985
		internal global::AcpUI.AcpLabel ScanLstScanListKeyofScanListMBRTable_A12673;

		// Token: 0x04000F92 RID: 3986
		internal global::AcpUI.AcpCustomViewCheckBox CVBtnScanLstScanListKeyofScanListMBRTable_A12673;

		// Token: 0x04000F93 RID: 3987
		internal global::AcpUI.AcpLabel LblScanLstScanListKeyofScanListMBRTable_A12673;

		// Token: 0x04000F94 RID: 3988
		internal global::AcpUI.AcpCopyButton CpyBtnScanLstScanListKeyofScanListMBRTable_A12673;

		// Token: 0x04000F95 RID: 3989
		internal global::AcpUI.AcpLabel ScanLstScanListKeyofScanListMBRTable_A12673Comp;

		// Token: 0x04000F96 RID: 3990
		internal global::AcpUI.AcpComboBox ScanLstScanListZone_A9718;

		// Token: 0x04000F97 RID: 3991
		internal global::AcpUI.AcpCustomViewCheckBox CVBtnScanLstScanListZone_A9718;

		// Token: 0x04000F98 RID: 3992
		internal global::AcpUI.AcpLabel LblScanLstScanListZone_A9718;

		// Token: 0x04000F99 RID: 3993
		internal global::AcpUI.AcpRtdButton RTDBtnScanLstScanListZone_A9718;

		// Token: 0x04000F9A RID: 3994
		internal global::AcpUI.AcpCopyButton CpyBtnScanLstScanListZone_A9718;

		// Token: 0x04000F9B RID: 3995
		internal global::AcpUI.AcpLabel ScanLstScanListZone_A9718Comp;

		// Token: 0x04000F9C RID: 3996
		internal global::AcpUI.AcpComboBox ScanLstScanListChannel_A7620;

		// Token: 0x04000F9D RID: 3997
		internal global::AcpUI.AcpCustomViewCheckBox CVBtnScanLstScanListChannel_A7620;

		// Token: 0x04000F9E RID: 3998
		internal global::AcpUI.AcpLabel LblScanLstScanListChannel_A7620;

		// Token: 0x04000F9F RID: 3999
		internal global::AcpUI.AcpRtdButton RTDBtnScanLstScanListChannel_A7620;

		// Token: 0x04000FA0 RID: 4000
		internal global::AcpUI.AcpCopyButton CpyBtnScanLstScanListChannel_A7620;

		// Token: 0x04000FA1 RID: 4001
		internal global::AcpUI.AcpLabel ScanLstScanListChannel_A7620Comp;

		// Token: 0x04000FA2 RID: 4002
		internal global::AcpUI.AcpLabel ScanLstScanListLTEInterferingFreqPresent_A42196;

		// Token: 0x04000FA3 RID: 4003
		internal global::AcpUI.AcpCustomViewCheckBox CVBtnScanLstScanListLTEInterferingFreqPresent_A42196;

		// Token: 0x04000FA4 RID: 4004
		internal global::AcpUI.AcpLabel LblScanLstScanListLTEInterferingFreqPresent_A42196;

		// Token: 0x04000FA5 RID: 4005
		internal global::AcpUI.AcpRtdButton RTDBtnScanLstScanListLTEInterferingFreqPresent_A42196;

		// Token: 0x04000FA6 RID: 4006
		internal global::AcpUI.AcpCopyButton CpyBtnScanLstScanListLTEInterferingFreqPresent_A42196;

		// Token: 0x04000FA7 RID: 4007
		internal global::AcpUI.AcpLabel ScanLstScanListLTEInterferingFreqPresent_A42196Comp;

		// Token: 0x04000FA8 RID: 4008
		internal global::AcpUI.AcpExpander ExpanderScanListLabtool;

		// Token: 0x04000FA9 RID: 4009
		internal global::AcpUI.AcpGroupBox GrpBoxExpanderScanListLabtoolPseudo0;

		// Token: 0x04000FAA RID: 4010
		internal global::AcpUI.AcpCustomViewCheckBox CVBtnScanLstLabtoolLastVotedChannel_A8419;

		// Token: 0x04000FAB RID: 4011
		internal global::AcpUI.AcpLabel LblScanLstLabtoolLastVotedChannel_A8419;

		// Token: 0x04000FAC RID: 4012
		internal global::AcpUI.AcpTextBoxSpinner ScanLstLabtoolLastVotedChannel_A8419;

		// Token: 0x04000FAD RID: 4013
		internal global::AcpUI.AcpRtdButton RTDBtnScanLstLabtoolLastVotedChannel_A8419;

		// Token: 0x04000FAE RID: 4014
		internal global::AcpUI.AcpCopyButton CpyBtnScanLstLabtoolLastVotedChannel_A8419;

		// Token: 0x04000FAF RID: 4015
		internal global::AcpUI.AcpLabel ScanLstLabtoolLastVotedChannel_A8419Comp;

		// Token: 0x04000FB0 RID: 4016
		internal global::AcpUI.AcpCustomViewCheckBox CVBtnScanLstLabtoolLastVotedZone_A8420;

		// Token: 0x04000FB1 RID: 4017
		internal global::AcpUI.AcpLabel LblScanLstLabtoolLastVotedZone_A8420;

		// Token: 0x04000FB2 RID: 4018
		internal global::AcpUI.AcpTextBoxSpinner ScanLstLabtoolLastVotedZone_A8420;

		// Token: 0x04000FB3 RID: 4019
		internal global::AcpUI.AcpRtdButton RTDBtnScanLstLabtoolLastVotedZone_A8420;

		// Token: 0x04000FB4 RID: 4020
		internal global::AcpUI.AcpCopyButton CpyBtnScanLstLabtoolLastVotedZone_A8420;

		// Token: 0x04000FB5 RID: 4021
		internal global::AcpUI.AcpLabel ScanLstLabtoolLastVotedZone_A8420Comp;

		// Token: 0x04000FB6 RID: 4022
		internal global::AcpUI.AcpCustomViewCheckBox CVBtnScanLstLabtoolLTEInterferingFreqPresent_A42197;

		// Token: 0x04000FB7 RID: 4023
		internal global::AcpUI.AcpLabel LblScanLstLabtoolLTEInterferingFreqPresent_A42197;

		// Token: 0x04000FB8 RID: 4024
		internal global::AcpUI.AcpLabel ScanLstLabtoolLTEInterferingFreqPresent_A42197;

		// Token: 0x04000FB9 RID: 4025
		internal global::AcpUI.AcpRtdButton RTDBtnScanLstLabtoolLTEInterferingFreqPresent_A42197;

		// Token: 0x04000FBA RID: 4026
		internal global::AcpUI.AcpCopyButton CpyBtnScanLstLabtoolLTEInterferingFreqPresent_A42197;

		// Token: 0x04000FBB RID: 4027
		internal global::AcpUI.AcpLabel ScanLstLabtoolLTEInterferingFreqPresent_A42197Comp;

		// Token: 0x04000FBC RID: 4028
		private bool b;
	}
}
