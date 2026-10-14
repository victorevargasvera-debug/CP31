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

namespace Motorola.MackinawCPS.CoreFeatures.MPLConfiguration
{
	// Token: 0x02000538 RID: 1336
	public class PageMPLConfiguration : global::AcpUI.AcpPageFeature, global::System.Windows.Markup.IComponentConnector, global::System.Windows.Markup.IStyleConnector
	{
		// Token: 0x0600B1FD RID: 45565 RVA: 0x00A53E0C File Offset: 0x00A5200C
		public PageMPLConfiguration()
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

		// Token: 0x0600B1FE RID: 45566 RVA: 0x00A53E44 File Offset: 0x00A52044
		public override void OnLoaded(object sender, global::System.Windows.RoutedEventArgs e)
		{
			short num = (short)1927086080;
			int num2 = (int)num;
			switch (num2)
			{
			default:
				num = (short)911540226;
				num2 = (int)((global::System.IntPtr)num);
				for (;;)
				{
					global::System.Collections.IEnumerator enumerator;
					global::AcpUI.AcpExpander acpExpander;
					switch (num2)
					{
					case 0:
					{
						this.RecNavToolbarPageMPLConfiguration.ChildToolbars.Add(this.RecNavToolbarExpanderMPLConfigurationMPLListTable);
						object obj = null;
						obj = this.RecNavToolbarExpanderMPLConfigurationMPLListTable.MyRecordsetDataSource;
						num = (short)134021121;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 1:
					{
						object obj;
						if (obj != null)
						{
							num = (short)60293124;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_82;
					}
					case 2:
						switch (0)
						{
						case 0:
							goto IL_5F;
						}
						continue;
					case 3:
						goto IL_162;
					case 4:
					{
						num = (short)514588673;
						if (num != 0)
						{
						}
						object obj;
						global::System.Windows.Data.CollectionView collectionView = (global::System.Windows.Data.CollectionView)global::System.Windows.Data.CollectionViewSource.GetDefaultView(obj);
						this.RecNavToolbarExpanderMPLConfigurationMPLListTable.MyDataPresenter = this.ExpanderMPLConfigurationMPLListTable;
						num = (short)1620639749;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 5:
						goto IL_82;
					case 6:
						try
						{
							num = (short)1152253954;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								switch (num2)
								{
								case 0:
									if (!enumerator.MoveNext())
									{
										num = (short)2029453318;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									acpExpander = (((global::System.Windows.UIElement)enumerator.Current) as global::AcpUI.AcpExpander);
									num = (short)1124204548;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 2:
									switch (0)
									{
									case 0:
										goto IL_20C;
									}
									continue;
								case 3:
									base.Expanders.Add(acpExpander);
									num = (short)1080098817;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 4:
									if (acpExpander != null)
									{
										num = (short)752484355;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									break;
								case 5:
								{
									num = (short)914112138;
									short num3 = num;
									num = (short)1336884874;
									switch ((num3 == num) ? 1 : 0)
									{
									case 0:
									case 2:
										break;
									default:
										goto IL_2FE;
									}
									break;
								}
								case 6:
									num = (short)645988357;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								IL_20E:
								num = (short)527237120;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								IL_20C:
								goto IL_20E;
							}
							IL_2FE:
							num = (short)397017088;
							if (num != 0)
							{
							}
							goto IL_13B;
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
									num = (short)489816065;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 1:
									goto IL_388;
								case 2:
									if (disposable != null)
									{
										num = (short)377815040;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									goto IL_38A;
								}
								goto IL_335;
							}
							IL_388:
							IL_38A:
							goto EndFinally_8;
							IL_335:
							disposable = (enumerator as global::System.IDisposable);
							num = (short)1436876802;
							num2 = (int)((global::System.IntPtr)num);
							goto IL_322;
							EndFinally_8:;
						}
						goto IL_38B;
						IL_13B:
						base.OnLoaded(sender, e);
						this.a = true;
						num = (short)846004227;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					IL_5F:
					if (!this.a)
					{
						num = (short)994050048;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					break;
					IL_82:
					acpExpander = null;
					enumerator = this.MyStackPanel.Children.GetEnumerator();
					num = (short)936509440;
					short num4 = num;
					num = (short)977141766;
					num2 = (int)((global::System.IntPtr)num);
				}
				IL_162:
				IL_38B:
				this.MyStackPanel.Children[0].Focus();
				return;
			}
		}

		// Token: 0x0600B1FF RID: 45567 RVA: 0x00A54210 File Offset: 0x00A52410
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
					goto IL_123;
				case 1:
					return;
				case 2:
					if (this.a)
					{
						num2 = (short)1735509869;
						short num3 = num2;
						num2 = (short)613795693;
						switch ((num3 == num2) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_123;
						case 1:
							break;
						default:
						{
							num2 = (short)1046151168;
							short num4 = num2;
							break;
						}
						}
						num2 = (short)1161166848;
						if (num2 != 0)
						{
						}
						num2 = (short)1489043456;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					return;
				}
				goto IL_1C;
				IL_123:
				base.OnUnloaded(sender, e);
				this.a = false;
				num2 = (short)1094844417;
				num = (int)((global::System.IntPtr)num2);
			}
			return;
			IL_1C:
			num2 = (short)789381121;
			if (num2 != 0)
			{
			}
			this.RecNavToolbarPageMPLConfiguration.DataContext = null;
			this.RecNavToolbarExpanderMPLConfigurationMPLListTable.DataContext = null;
			this.RecNavToolbarPageMPLConfiguration.MyDataPresenter = null;
			this.RecNavToolbarExpanderMPLConfigurationMPLListTable.MyDataPresenter = null;
			num2 = (short)1337720834;
			num = (int)((global::System.IntPtr)num2);
			goto IL_0A;
		}

		// Token: 0x0600B200 RID: 45568 RVA: 0x00A5436C File Offset: 0x00A5256C
		public override void SetDataContext()
		{
			short num = (short)1666842628;
			int num2 = (int)((global::System.IntPtr)num);
			object feature;
			for (;;)
			{
				switch (num2)
				{
				case 0:
					goto IL_7E;
				case 1:
					goto IL_1C2;
				case 2:
					goto IL_232;
				case 3:
					base.DataContext = global::AcpCommonLib.AppInfoManager.DefaultDocument.GetFeature(2078);
					num = (short)422707201;
					if (num != 0)
					{
					}
					num = (short)2044854272;
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
					if (feature != null)
					{
						num = (short)1067778050;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					return;
				case 6:
					goto IL_7E;
				case 7:
					feature = global::AcpCommonLib.AppInfoManager.ComparatorDocument.GetFeature(2078);
					num = (short)2101411845;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 8:
				{
					num = (short)423783687;
					short num3 = num;
					num = (short)616918279;
					switch ((num3 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						break;
					default:
						num = (short)917504;
						if (num != 0)
						{
						}
						if (global::AcpCommonLib.AppInfoManager.AppMode == global::AcpCommonLib.ApplicationMode.CodeplugComparisonMode)
						{
							num = (short)1877803015;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						((global::AcpUILib.IAcpRecNavToolbar)this.RecNavToolbarPageMPLConfiguration).MySecondaryRecordsetDataSource = null;
						break;
					}
					num = (short)1521483776;
					short num4 = num;
					num = (short)614727681;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				}
				IL_48:
				if (global::AcpCommonLib.AppInfoManager.AppMode == global::AcpCommonLib.ApplicationMode.CustomViewConfigurationMode)
				{
					num = (short)1223163907;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				base.DataContext = global::AcpCommonLib.FeatureManager.GetFeature(2078);
				num = (short)543490054;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_7E:
				this.RecNavToolbarPageMPLConfiguration.DataContext = (global::AcpCommonLib.IAcpRecordset)base.DataContext;
				num = (short)1883963400;
				num2 = (int)((global::System.IntPtr)num);
			}
			IL_1C2:
			return;
			IL_232:
			((global::AcpUILib.IAcpRecNavToolbar)this.RecNavToolbarPageMPLConfiguration).MySecondaryRecordsetDataSource = (global::AcpCommonLib.IAcpRecordset)feature;
		}

		// Token: 0x0600B201 RID: 45569 RVA: 0x00A545B0 File Offset: 0x00A527B0
		private void OnModeClick(object A_0, global::System.Windows.RoutedEventArgs A_1)
		{
			int a_ = 13;
			short num = (short)1905262592;
			switch (num)
			{
			default:
			{
				num = (short)1250557970;
				int num2 = (int)((global::System.IntPtr)num);
				for (;;)
				{
					switch (num2)
					{
					case 0:
					{
						num = (short)1024786432;
						short num3 = num;
						num = (short)1875247105;
						if (num != 0)
						{
						}
						global::AcpCommonLib.IAcpRecordset myRecordsetDataSource;
						base.NavigationService.Navigate(new global::System.Uri(myRecordsetDataSource.UIPagePath, global::System.UriKind.RelativeOrAbsolute));
						num = (short)743702545;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 1:
					{
						object myRecordsetDataSource2;
						if (myRecordsetDataSource2 != null)
						{
							num = (short)336396301;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return;
					}
					case 2:
						goto IL_36C;
					case 3:
						if (((global::AcpUI.AcpRecNavToolbar)A_0).Name == global::AllFeatures.CodeplugGuid.b("鳍뗏뇑髓럕껗軙돛뇝賟胡藣铥귧鋩鳫迭黯雱釳蓵뗷꫹냻뷽濿氁戃漅漇缉縋漍搏笑笓砕唗䨙倛初䤟儡倣爥䤧䠩䀫䬭", a_))
						{
							num = (short)1559429132;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return;
					case 4:
						num = (short)1678245908;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 5:
						goto IL_132;
					case 6:
						goto IL_24D;
					case 7:
					{
						global::AcpCommonLib.IAcpRecordset myRecordsetDataSource;
						if (myRecordsetDataSource != null)
						{
							num = (short)137232384;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_2CF;
					}
					case 8:
					{
						global::System.Windows.Data.CollectionView collectionView;
						collectionView.MoveCurrentToLast();
						num = (short)1633812486;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 9:
					{
						global::System.Windows.Data.CollectionView collectionView;
						if (collectionView.IsCurrentAfterLast)
						{
							num = (short)933298184;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						collectionView.MoveCurrentToFirst();
						num = (short)58589206;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 10:
						if (((global::AcpUI.AcpRecNavToolbar)A_0).TableMode)
						{
							num = (short)1347223566;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						((global::AcpUI.AcpRecNavToolbar)A_0).TableMode = true;
						num = (short)1990656021;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 11:
					{
						global::System.Windows.Data.CollectionView collectionView;
						if (collectionView.Count > 0)
						{
							num = (short)1611595778;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_326;
					}
					case 12:
						num = (short)973013002;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 13:
					{
						num = (short)471838820;
						short num4 = num;
						num = (short)687386724;
						switch ((num4 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_36C;
						default:
						{
							num = (short)1744371712;
							if (num != 0)
							{
							}
							object myRecordsetDataSource2;
							global::System.Windows.Data.CollectionView collectionView = (global::System.Windows.Data.CollectionView)global::System.Windows.Data.CollectionViewSource.GetDefaultView(myRecordsetDataSource2);
							global::Motorola.MackinawCPS.CoreFeatures.MPLConfiguration.MPLListInner mpllistInner = (global::Motorola.MackinawCPS.CoreFeatures.MPLConfiguration.MPLListInner)collectionView.CurrentItem;
							num = (short)1060896787;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						}
						break;
					}
					case 14:
					{
						((global::AcpUI.AcpRecNavToolbar)A_0).TableMode = false;
						object myRecordsetDataSource2 = this.RecNavToolbarExpanderMPLConfigurationMPLListTable.MyRecordsetDataSource;
						num = (short)659226625;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 15:
					{
						global::AcpCommonLib.IAcpRecordset myRecordsetDataSource = this.RecNavToolbarPageMPLConfiguration.MyRecordsetDataSource;
						num = (short)1495531527;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 16:
					{
						global::System.Windows.Data.CollectionView collectionView;
						global::Motorola.MackinawCPS.CoreFeatures.MPLConfiguration.MPLListInner mpllistInner;
						collectionView.MoveCurrentTo(mpllistInner);
						num = (short)1467547653;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 17:
						goto IL_2CF;
					case 18:
						switch (0)
						{
						case 0:
							goto IL_AA;
						}
						continue;
					case 19:
					{
						global::Motorola.MackinawCPS.CoreFeatures.MPLConfiguration.MPLListInner mpllistInner;
						if (mpllistInner != null)
						{
							num = (short)1468006416;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)2088173579;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 20:
						if (((global::AcpUI.AcpRecNavToolbar)A_0).Name == global::AllFeatures.CodeplugGuid.b("鳍뗏뇑髓럕껗軙돛뇝賟胡藣铥룧诩诫语뷯ꋱ룳뗵韷铹髻韽柿省瘃朅簇按挋怍", a_))
						{
							num = (short)1971847183;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_2CF;
					case 21:
						goto IL_277;
					case 22:
						goto IL_18E;
					}
					IL_AA:
					if (A_0 is global::AcpUI.AcpRecNavToolbar)
					{
						num = (short)1872887812;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					return;
					IL_2CF:
					num = (short)1523187715;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_36C:
					num = (short)547684361;
					num2 = (int)((global::System.IntPtr)num);
				}
				IL_132:
				IL_18E:
				IL_24D:
				goto IL_326;
				IL_277:
				return;
				IL_326:
				((global::AcpUI.AcpRecNavToolbar)A_0).SyncDataSources();
				return;
			}
			}
		}

		// Token: 0x0600B202 RID: 45570 RVA: 0x00A54A68 File Offset: 0x00A52C68
		private void HLinkClick(object A_0, global::System.Windows.RoutedEventArgs A_1)
		{
			short num = (short)407109632;
			short num2 = num;
			num = (short)2108765834;
			short num3 = num;
			num = (short)104216202;
			switch (num3 == num)
			{
			}
			num = (short)791740416;
			if (num != 0)
			{
			}
			num = (short)2006450177;
			if (num != 0)
			{
			}
			base.OnHLinkClick(A_0);
		}

		// Token: 0x0600B203 RID: 45571 RVA: 0x00A54B1C File Offset: 0x00A52D1C
		private void OnFieldNameDoubleClick(object A_0, global::System.Windows.RoutedEventArgs A_1)
		{
			short num = (short)1145438208;
			short num2 = num;
			num = (short)1003019235;
			short num3 = num;
			num = (short)1043979235;
			switch (num3 == num)
			{
			}
			num = (short)1087897601;
			if (num != 0)
			{
			}
			num = (short)1741946880;
			if (num != 0)
			{
			}
			global::AcpUI.Common.Utility.GetFieldHelpText(A_0);
		}

		// Token: 0x0600B204 RID: 45572 RVA: 0x00A54BD4 File Offset: 0x00A52DD4
		internal void OnExpanderMPLConfigurationMPLListTableClick(object sender, global::System.Windows.RoutedEventArgs e)
		{
			switch (0)
			{
			case 0:
				goto IL_1C;
			}
			int num;
			short num2;
			object myRecordsetDataSource;
			global::Motorola.MackinawCPS.CoreFeatures.MPLConfiguration.MPLListInner item;
			for (;;)
			{
				IL_0A:
				switch (num)
				{
				case 0:
					goto IL_11C;
				case 1:
					goto IL_151;
				case 2:
					num2 = (short)99287041;
					if (num2 != 0)
					{
					}
					if (myRecordsetDataSource != null)
					{
						num2 = (short)1351014420;
						short num3 = num2;
						num2 = (short)1802688532;
						switch ((num3 == num2) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_11C;
						case 1:
							break;
						default:
						{
							num2 = (short)2097348608;
							short num4 = num2;
							break;
						}
						}
						num2 = (short)1169686528;
						if (num2 != 0)
						{
						}
						num2 = (short)921632768;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_153;
				}
				goto IL_1C;
				IL_11C:
				((global::System.Windows.Data.CollectionView)global::System.Windows.Data.CollectionViewSource.GetDefaultView(myRecordsetDataSource)).MoveCurrentTo(item);
				this.RecNavToolbarExpanderMPLConfigurationMPLListTable.SyncDataSources();
				num2 = (short)102760449;
				num = (int)((global::System.IntPtr)num2);
			}
			IL_151:
			IL_153:
			this.RecNavToolbarExpanderMPLConfigurationMPLListTable.TableMode = false;
			return;
			IL_1C:
			item = (global::Motorola.MackinawCPS.CoreFeatures.MPLConfiguration.MPLListInner)((global::Infragistics.Windows.DataPresenter.CellValuePresenter)((global::AcpUI.AcpButton)e.Source).TemplatedParent).Record.DataItem;
			myRecordsetDataSource = this.RecNavToolbarExpanderMPLConfigurationMPLListTable.MyRecordsetDataSource;
			num2 = (short)1686634498;
			num = (int)((global::System.IntPtr)num2);
			goto IL_0A;
		}

		// Token: 0x0600B205 RID: 45573 RVA: 0x00A54D40 File Offset: 0x00A52F40
		[global::System.Diagnostics.DebuggerNonUserCode]
		[global::System.CodeDom.Compiler.GeneratedCode("PresentationBuildTasks", "5.0.10.0")]
		public void InitializeComponent()
		{
			int a_ = 4;
			short num = (short)203747280;
			short num2 = num;
			num = (short)270462928;
			switch ((num2 == num) ? 1 : 0)
			{
			case 0:
			case 2:
				break;
			default:
			{
				num = (short)845086721;
				if (num != 0)
				{
				}
				num = (short)1669595136;
				if (num != 0)
				{
				}
				num = (short)1447034880;
				short num3 = num;
				if (!this.b)
				{
					this.b = true;
					global::System.Uri resourceLocator = new global::System.Uri(global::AllFeatures.CodeplugGuid.b("蛆ꗈꟊ诌꫎냐꟒ꃔꗖ볘꣚볞軠転闤裦蟨軪菬鯮\udef0郲髴駶迸黺鏼课栀氂欄昆攈⸊㼌㼎爐簒笔焖瀘簚栜洞䀠圢䰤䠦䜨Ъ䀬弮崰ᘲܴܶ娸吺匼夾⡀⑂い㕆⡈㽊⑌⁎㽐籒㡔❖㕘㡚㉜ㅞݠ੢ɤቦ᭨੪ᥬٮṰᵲ孴ྲྀᡸᙺᅼ", a_), global::System.UriKind.Relative);
					global::System.Windows.Application.LoadComponent(this, resourceLocator);
					return;
				}
				break;
			}
			}
		}

		// Token: 0x0600B206 RID: 45574 RVA: 0x00A54E20 File Offset: 0x00A53020
		[global::System.Diagnostics.DebuggerNonUserCode]
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		[global::System.CodeDom.Compiler.GeneratedCode("PresentationBuildTasks", "5.0.10.0")]
		void global::System.Windows.Markup.IComponentConnector.Connect(int connectionId, object target)
		{
			short num = (short)1462960129;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				switch (num2)
				{
				case 0:
					goto IL_406;
				case 1:
					switch (0)
					{
					case 0:
						goto IL_30;
					}
					continue;
				case 2:
					num = (short)1548746752;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				IL_30:
				switch (connectionId)
				{
				case 1:
					goto IL_945;
				case 2:
					goto IL_976;
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
					goto IL_E7C;
				case 19:
					goto IL_5F8;
				case 20:
					goto IL_541;
				case 21:
					goto IL_88B;
				case 22:
					goto IL_E1A;
				case 23:
					goto IL_B8A;
				case 24:
					goto IL_C54;
				case 25:
					goto IL_BEF;
				case 26:
					goto IL_639;
				case 27:
					goto IL_DF6;
				case 28:
					goto IL_85A;
				case 29:
					goto IL_C61;
				case 30:
					goto IL_E6F;
				case 31:
					goto IL_C6E;
				case 32:
					goto IL_87E;
				case 33:
					goto IL_703;
				case 34:
					goto IL_32B;
				case 35:
					goto IL_8AF;
				case 36:
					goto IL_61F;
				case 37:
					goto IL_5EB;
				case 38:
					goto IL_418;
				case 39:
					goto IL_A09;
				case 40:
					goto IL_646;
				case 41:
					goto IL_6CF;
				case 42:
					goto IL_D3C;
				case 43:
					goto IL_40B;
				case 44:
					goto IL_CFB;
				case 45:
					goto IL_D87;
				case 46:
					goto IL_311;
				case 47:
					goto IL_4AA;
				case 48:
					goto IL_84D;
				case 49:
					goto IL_425;
				case 50:
					goto IL_3A4;
				case 51:
					goto IL_612;
				case 52:
					goto IL_527;
				case 53:
					goto IL_4D1;
				case 54:
					goto IL_677;
				case 55:
					goto IL_B97;
				case 56:
					goto IL_D2F;
				case 57:
					goto IL_4C4;
				case 58:
					goto IL_ADA;
				case 59:
					goto IL_C09;
				case 60:
					goto IL_49D;
				case 61:
					goto IL_A6B;
				case 62:
					goto IL_D94;
				case 63:
					goto IL_C16;
				case 64:
					goto IL_572;
				case 65:
					goto IL_91E;
				case 66:
					goto IL_6E9;
				case 67:
					goto IL_5BA;
				case 68:
					goto IL_9D8;
				case 69:
					goto IL_8BC;
				case 70:
					goto IL_AE7;
				case 71:
					goto IL_483;
				case 72:
					goto IL_476;
				case 73:
					goto IL_765;
				case 74:
					goto IL_BE2;
				case 75:
					goto IL_DD2;
				case 76:
					goto IL_802;
				case 77:
					goto IL_758;
				case 78:
					goto IL_3E2;
				case 79:
					goto IL_789;
				case 80:
					goto IL_9CB;
				case 81:
					goto IL_C30;
				case 82:
					goto IL_D08;
				case 83:
					goto IL_565;
				case 84:
					goto IL_7F5;
				case 85:
					goto IL_9A7;
				case 86:
					goto IL_BD5;
				case 87:
					goto IL_9E5;
				case 88:
					goto IL_534;
				case 89:
					goto IL_CE1;
				case 90:
					goto IL_92B;
				case 91:
					goto IL_E3E;
				case 92:
					goto IL_AA9;
				case 93:
					goto IL_7AD;
				case 94:
					goto IL_6F6;
				case 95:
					goto IL_DC5;
				case 96:
					goto IL_840;
				case 97:
					goto IL_2ED;
				case 98:
					goto IL_74B;
				case 99:
					goto IL_380;
				case 100:
					goto IL_99A;
				case 101:
					goto IL_6DC;
				case 102:
					goto IL_80F;
				case 103:
					goto IL_653;
				case 104:
					goto IL_D49;
				case 105:
					goto IL_B3F;
				case 106:
					goto IL_CD4;
				case 107:
					goto IL_490;
				case 108:
					goto IL_B01;
				case 109:
					goto IL_8FA;
				case 110:
					goto IL_A3A;
				case 111:
					goto IL_A47;
				case 112:
					goto IL_8ED;
				case 113:
					goto IL_34F;
				case 114:
					goto IL_8E0;
				case 115:
					goto IL_2C9;
				case 116:
					goto IL_B63;
				case 117:
					goto IL_B1B;
				case 118:
					goto IL_BA4;
				case 119:
					goto IL_A9C;
				case 120:
					goto IL_AF4;
				case 121:
					goto IL_596;
				case 122:
					goto IL_691;
				case 123:
					goto IL_727;
				case 124:
					goto IL_938;
				case 125:
					goto IL_B70;
				case 126:
					goto IL_62C;
				case 127:
					goto IL_81C;
				case 128:
					goto IL_469;
				case 129:
					goto IL_AB6;
				case 130:
					goto IL_BFC;
				case 131:
					goto IL_31E;
				case 132:
					goto IL_4B7;
				case 133:
					goto IL_C7B;
				case 134:
					goto IL_684;
				case 135:
					goto IL_69E;
				case 136:
					goto IL_E62;
				case 137:
					goto IL_A2D;
				case 138:
					goto IL_5DE;
				case 139:
					goto IL_3B1;
				case 140:
					goto IL_6C2;
				case 141:
					goto IL_A78;
				case 142:
					goto IL_D7A;
				case 143:
					goto IL_432;
				case 144:
					goto IL_D15;
				case 145:
					goto IL_35C;
				case 146:
					goto IL_605;
				case 147:
					goto IL_7D1;
				case 148:
					goto IL_B0E;
				case 149:
					goto IL_C9F;
				case 150:
					goto IL_B7D;
				case 151:
					goto IL_D56;
				case 152:
					goto IL_CEE;
				case 153:
					goto IL_BB1;
				case 154:
					goto IL_3D5;
				case 155:
					goto IL_DB8;
				case 156:
					goto IL_D22;
				case 157:
					goto IL_C23;
				default:
					num = (short)23986178;
					num2 = (int)((global::System.IntPtr)num);
					break;
				}
			}
			IL_2C9:
			this.MplCfgMPLListTxDPLCode_A9527 = (global::AcpUI.AcpComboBox)target;
			this.MplCfgMPLListTxDPLCode_A9527.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_2ED:
			this.MplCfgMPLListTxSquelchType_A9567 = (global::AcpUI.AcpComboBox)target;
			this.MplCfgMPLListTxSquelchType_A9567.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_311:
			this.MplCfgMPLListRxPLFreq_A9027_Col = (global::Infragistics.Windows.DataPresenter.UnboundField)target;
			return;
			IL_31E:
			this.CpyBtnMplCfgMPLListTASquelchType_A9266 = (global::AcpUI.AcpCopyButton)target;
			return;
			IL_32B:
			this.MplCfgGeneralPresetMPLEntry_A8739 = (global::AcpUI.AcpComboBox)target;
			this.MplCfgGeneralPresetMPLEntry_A8739.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_34F:
			this.CpyBtnMplCfgMPLListTxPLCode_A9555 = (global::AcpUI.AcpCopyButton)target;
			return;
			IL_35C:
			this.MplCfgMPLListTADPLCode_A9257 = (global::AcpUI.AcpComboBox)target;
			this.MplCfgMPLListTADPLCode_A9257.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_380:
			this.LblMplCfgMPLListTxSquelchType_A9567 = (global::AcpUI.AcpLabel)target;
			this.LblMplCfgMPLListTxSquelchType_A9567.MouseDoubleClick += new global::System.Windows.Input.MouseButtonEventHandler(this.OnFieldNameDoubleClick);
			return;
			IL_3A4:
			this.MplCfgMPLListTxSquelchType_A9567_Col = (global::Infragistics.Windows.DataPresenter.UnboundField)target;
			return;
			IL_3B1:
			this.MplCfgMPLListTAPLCode_A9262 = (global::AcpUI.AcpComboBox)target;
			this.MplCfgMPLListTAPLCode_A9262.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_3D5:
			this.RTDBtnMplCfgMPLListTADPLInvert_A9258 = (global::AcpUI.AcpRtdButton)target;
			return;
			IL_3E2:
			this.MplCfgMPLListRxPLFreq_A9027Comp = (global::AcpUI.AcpLabel)target;
			return;
			IL_406:
			goto IL_E7C;
			IL_40B:
			this.ExpanderMPLConfigurationMPLListTable = (global::AcpUI.AcpXamDataPresenter)target;
			return;
			IL_418:
			this.ExpanderMPLConfigurationMPLList = (global::AcpUI.AcpExpander)target;
			return;
			IL_425:
			this.MplCfgMPLListRxDPLInvert_A9009_Col = (global::Infragistics.Windows.DataPresenter.UnboundField)target;
			return;
			IL_432:
			num = (short)1895366656;
			short num3 = num;
			this.CpyBtnMplCfgMPLListTAPLCode_A9262 = (global::AcpUI.AcpCopyButton)target;
			return;
			IL_469:
			this.CVBtnMplCfgMPLListTASquelchType_A9266 = (global::AcpUI.AcpCustomViewCheckBox)target;
			return;
			IL_476:
			this.MplCfgMPLListRxSquelchType_A9028Comp = (global::AcpUI.AcpLabel)target;
			return;
			IL_483:
			this.CpyBtnMplCfgMPLListRxSquelchType_A9028 = (global::AcpUI.AcpCopyButton)target;
			return;
			IL_490:
			this.CpyBtnMplCfgMPLListTxPLFreq_A9556 = (global::AcpUI.AcpCopyButton)target;
			return;
			IL_49D:
			this.ExpanderMPLConfigurationMPLListTableSRecView = (global::AcpUI.AcpGroupBox)target;
			return;
			IL_4AA:
			this.MplCfgMPLListRxPLCode_A9026_Col = (global::Infragistics.Windows.DataPresenter.UnboundField)target;
			return;
			IL_4B7:
			this.MplCfgMPLListTASquelchType_A9266Comp = (global::AcpUI.AcpLabel)target;
			return;
			IL_4C4:
			this.MplCfgMPLListTAPLCode_A9262_Col = (global::Infragistics.Windows.DataPresenter.UnboundField)target;
			return;
			IL_4D1:
			num = (short)655460847;
			short num4 = num;
			num = (short)1490127343;
			switch ((num4 == num) ? 1 : 0)
			{
			case 0:
			case 2:
				IL_9D8:
				this.CVBtnMplCfgMPLListRxSquelchType_A9028 = (global::AcpUI.AcpCustomViewCheckBox)target;
				return;
			default:
				num = (short)1114112000;
				if (num != 0)
				{
				}
				this.MplCfgMPLListTxDPLCode_A9527_Col = (global::Infragistics.Windows.DataPresenter.UnboundField)target;
				return;
			}
			IL_527:
			this.MplCfgMPLListTxPLCode_A9555_Col = (global::Infragistics.Windows.DataPresenter.UnboundField)target;
			return;
			IL_534:
			this.RTDBtnMplCfgMPLListRxDPLCode_A9008 = (global::AcpUI.AcpRtdButton)target;
			return;
			IL_541:
			this.HLinkGeneral = (global::System.Windows.Documents.Hyperlink)target;
			this.HLinkGeneral.Click += this.HLinkClick;
			return;
			IL_565:
			this.CpyBtnMplCfgMPLListRxPLCode_A9026 = (global::AcpUI.AcpCopyButton)target;
			return;
			IL_572:
			this.LblMplCfgMPLListMPLAlias_A8548 = (global::AcpUI.AcpLabel)target;
			this.LblMplCfgMPLListMPLAlias_A8548.MouseDoubleClick += new global::System.Windows.Input.MouseButtonEventHandler(this.OnFieldNameDoubleClick);
			return;
			IL_596:
			this.MplCfgMPLListTxDPLInvert_A9528 = (global::AcpUI.AcpComboBox)target;
			this.MplCfgMPLListTxDPLInvert_A9528.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_5BA:
			this.MplCfgMPLListRxSquelchType_A9028 = (global::AcpUI.AcpComboBox)target;
			this.MplCfgMPLListRxSquelchType_A9028.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_5DE:
			this.MplCfgMPLListTAPLFreq_A9263Comp = (global::AcpUI.AcpLabel)target;
			return;
			IL_5EB:
			this.MplCfgGeneralPresetMPLEntry_A8739Comp = (global::AcpUI.AcpLabel)target;
			return;
			IL_5F8:
			this.ThemeBaseObj = (global::AcpUI.Common.AcpThemeBase)target;
			return;
			IL_605:
			this.CVBtnMplCfgMPLListTADPLCode_A9257 = (global::AcpUI.AcpCustomViewCheckBox)target;
			return;
			IL_612:
			this.MplCfgMPLListTxPLFreq_A9556_Col = (global::Infragistics.Windows.DataPresenter.UnboundField)target;
			return;
			IL_61F:
			this.CpyBtnMplCfgGeneralPresetMPLEntry_A8739 = (global::AcpUI.AcpCopyButton)target;
			return;
			IL_62C:
			this.MplCfgMPLListTxDPLInvert_A9528Comp = (global::AcpUI.AcpLabel)target;
			return;
			IL_639:
			this.CVBtnMplCfgGeneralMPLSelectMode_A8549 = (global::AcpUI.AcpCustomViewCheckBox)target;
			return;
			IL_646:
			this.ExpanderMPLConfigurationMPLListGrid = (global::System.Windows.Controls.Grid)target;
			return;
			IL_653:
			this.MplCfgMPLListTxPLFreq_A9556 = (global::AcpUI.AcpComboBox)target;
			this.MplCfgMPLListTxPLFreq_A9556.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_677:
			this.MplCfgMPLListTxDPLInvert_A9528_Col = (global::Infragistics.Windows.DataPresenter.UnboundField)target;
			return;
			IL_684:
			this.CVBtnMplCfgMPLListTAPLFreq_A9263 = (global::AcpUI.AcpCustomViewCheckBox)target;
			return;
			IL_691:
			this.CVBtnMplCfgMPLListTxDPLInvert_A9528 = (global::AcpUI.AcpCustomViewCheckBox)target;
			return;
			IL_69E:
			this.LblMplCfgMPLListTAPLFreq_A9263 = (global::AcpUI.AcpLabel)target;
			this.LblMplCfgMPLListTAPLFreq_A9263.MouseDoubleClick += new global::System.Windows.Input.MouseButtonEventHandler(this.OnFieldNameDoubleClick);
			return;
			IL_6C2:
			this.CVBtnMplCfgMPLListTAPLCode_A9262 = (global::AcpUI.AcpCustomViewCheckBox)target;
			return;
			IL_6CF:
			this.ExpanderMPLConfigurationMPLListTableGrid = (global::System.Windows.Controls.Grid)target;
			return;
			IL_6DC:
			this.CpyBtnMplCfgMPLListTxSquelchType_A9567 = (global::AcpUI.AcpCopyButton)target;
			return;
			IL_6E9:
			this.MplCfgMPLListMPLAlias_A8548Comp = (global::AcpUI.AcpLabel)target;
			return;
			IL_6F6:
			this.RTDBtnMplCfgMPLListRxDPLInvert_A9009 = (global::AcpUI.AcpRtdButton)target;
			return;
			IL_703:
			this.LblMplCfgGeneralPresetMPLEntry_A8739 = (global::AcpUI.AcpLabel)target;
			this.LblMplCfgGeneralPresetMPLEntry_A8739.MouseDoubleClick += new global::System.Windows.Input.MouseButtonEventHandler(this.OnFieldNameDoubleClick);
			return;
			IL_727:
			this.LblMplCfgMPLListTxDPLInvert_A9528 = (global::AcpUI.AcpLabel)target;
			this.LblMplCfgMPLListTxDPLInvert_A9528.MouseDoubleClick += new global::System.Windows.Input.MouseButtonEventHandler(this.OnFieldNameDoubleClick);
			return;
			IL_74B:
			this.CVBtnMplCfgMPLListTxSquelchType_A9567 = (global::AcpUI.AcpCustomViewCheckBox)target;
			return;
			IL_758:
			this.CpyBtnMplCfgMPLListRxPLFreq_A9027 = (global::AcpUI.AcpCopyButton)target;
			return;
			IL_765:
			this.MplCfgMPLListRxPLFreq_A9027 = (global::AcpUI.AcpComboBox)target;
			this.MplCfgMPLListRxPLFreq_A9027.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_789:
			this.MplCfgMPLListRxPLCode_A9026 = (global::AcpUI.AcpComboBox)target;
			this.MplCfgMPLListRxPLCode_A9026.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_7AD:
			this.LblMplCfgMPLListRxDPLInvert_A9009 = (global::AcpUI.AcpLabel)target;
			this.LblMplCfgMPLListRxDPLInvert_A9009.MouseDoubleClick += new global::System.Windows.Input.MouseButtonEventHandler(this.OnFieldNameDoubleClick);
			return;
			IL_7D1:
			this.LblMplCfgMPLListTADPLCode_A9257 = (global::AcpUI.AcpLabel)target;
			this.LblMplCfgMPLListTADPLCode_A9257.MouseDoubleClick += new global::System.Windows.Input.MouseButtonEventHandler(this.OnFieldNameDoubleClick);
			return;
			IL_7F5:
			this.MplCfgMPLListRxPLCode_A9026Comp = (global::AcpUI.AcpLabel)target;
			return;
			IL_802:
			this.RTDBtnMplCfgMPLListRxPLFreq_A9027 = (global::AcpUI.AcpRtdButton)target;
			return;
			IL_80F:
			this.MplCfgMPLListTxSquelchType_A9567Comp = (global::AcpUI.AcpLabel)target;
			return;
			IL_81C:
			this.MplCfgMPLListTASquelchType_A9266 = (global::AcpUI.AcpComboBox)target;
			this.MplCfgMPLListTASquelchType_A9266.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_840:
			this.MplCfgMPLListRxDPLInvert_A9009Comp = (global::AcpUI.AcpLabel)target;
			return;
			IL_84D:
			this.MplCfgMPLListRxDPLCode_A9008_Col = (global::Infragistics.Windows.DataPresenter.UnboundField)target;
			return;
			IL_85A:
			this.MplCfgGeneralMPLSelectMode_A8549 = (global::AcpUI.AcpComboBox)target;
			this.MplCfgGeneralMPLSelectMode_A8549.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_87E:
			this.CVBtnMplCfgGeneralPresetMPLEntry_A8739 = (global::AcpUI.AcpCustomViewCheckBox)target;
			return;
			IL_88B:
			this.HLinkMPLList = (global::System.Windows.Documents.Hyperlink)target;
			this.HLinkMPLList.Click += this.HLinkClick;
			return;
			IL_8AF:
			this.RTDBtnMplCfgGeneralPresetMPLEntry_A8739 = (global::AcpUI.AcpRtdButton)target;
			return;
			IL_8BC:
			this.LblMplCfgMPLListRxSquelchType_A9028 = (global::AcpUI.AcpLabel)target;
			this.LblMplCfgMPLListRxSquelchType_A9028.MouseDoubleClick += new global::System.Windows.Input.MouseButtonEventHandler(this.OnFieldNameDoubleClick);
			return;
			IL_8E0:
			this.MplCfgMPLListTxPLCode_A9555Comp = (global::AcpUI.AcpLabel)target;
			return;
			IL_8ED:
			this.RTDBtnMplCfgMPLListTxPLCode_A9555 = (global::AcpUI.AcpRtdButton)target;
			return;
			IL_8FA:
			this.MplCfgMPLListTxPLCode_A9555 = (global::AcpUI.AcpComboBox)target;
			this.MplCfgMPLListTxPLCode_A9555.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_91E:
			this.CpyBtnMplCfgMPLListMPLAlias_A8548 = (global::AcpUI.AcpCopyButton)target;
			return;
			IL_92B:
			this.MplCfgMPLListRxDPLCode_A9008Comp = (global::AcpUI.AcpLabel)target;
			return;
			IL_938:
			this.RTDBtnMplCfgMPLListTxDPLInvert_A9528 = (global::AcpUI.AcpRtdButton)target;
			return;
			IL_945:
			((global::Motorola.MackinawCPS.CoreFeatures.MPLConfiguration.PageMPLConfiguration)target).Loaded += this.OnLoaded;
			((global::Motorola.MackinawCPS.CoreFeatures.MPLConfiguration.PageMPLConfiguration)target).Unloaded += this.OnUnloaded;
			return;
			IL_976:
			this.RecNavToolbarPageMPLConfiguration = (global::AcpUI.AcpParentRecNavToolbar)target;
			this.RecNavToolbarPageMPLConfiguration.ModeClick += this.OnModeClick;
			return;
			IL_99A:
			this.RTDBtnMplCfgMPLListTxSquelchType_A9567 = (global::AcpUI.AcpRtdButton)target;
			return;
			IL_9A7:
			this.MplCfgMPLListRxDPLCode_A9008 = (global::AcpUI.AcpComboBox)target;
			this.MplCfgMPLListRxDPLCode_A9008.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_9CB:
			this.CVBtnMplCfgMPLListRxPLCode_A9026 = (global::AcpUI.AcpCustomViewCheckBox)target;
			return;
			IL_9E5:
			this.LblMplCfgMPLListRxDPLCode_A9008 = (global::AcpUI.AcpLabel)target;
			this.LblMplCfgMPLListRxDPLCode_A9008.MouseDoubleClick += new global::System.Windows.Input.MouseButtonEventHandler(this.OnFieldNameDoubleClick);
			return;
			IL_A09:
			this.RecNavToolbarExpanderMPLConfigurationMPLListTable = (global::AcpUI.AcpChildRecNavToolbar)target;
			this.RecNavToolbarExpanderMPLConfigurationMPLListTable.ModeClick += this.OnModeClick;
			return;
			IL_A2D:
			this.CpyBtnMplCfgMPLListTAPLFreq_A9263 = (global::AcpUI.AcpCopyButton)target;
			return;
			IL_A3A:
			this.CVBtnMplCfgMPLListTxPLCode_A9555 = (global::AcpUI.AcpCustomViewCheckBox)target;
			return;
			IL_A47:
			this.LblMplCfgMPLListTxPLCode_A9555 = (global::AcpUI.AcpLabel)target;
			this.LblMplCfgMPLListTxPLCode_A9555.MouseDoubleClick += new global::System.Windows.Input.MouseButtonEventHandler(this.OnFieldNameDoubleClick);
			return;
			IL_A6B:
			this.gridExpanderMPLConfigurationMPLListTableSRecView = (global::System.Windows.Controls.Grid)target;
			return;
			IL_A78:
			this.LblMplCfgMPLListTAPLCode_A9262 = (global::AcpUI.AcpLabel)target;
			this.LblMplCfgMPLListTAPLCode_A9262.MouseDoubleClick += new global::System.Windows.Input.MouseButtonEventHandler(this.OnFieldNameDoubleClick);
			return;
			IL_A9C:
			this.CpyBtnMplCfgMPLListTxDPLCode_A9527 = (global::AcpUI.AcpCopyButton)target;
			return;
			IL_AA9:
			this.CVBtnMplCfgMPLListRxDPLInvert_A9009 = (global::AcpUI.AcpCustomViewCheckBox)target;
			return;
			IL_AB6:
			this.LblMplCfgMPLListTASquelchType_A9266 = (global::AcpUI.AcpLabel)target;
			this.LblMplCfgMPLListTASquelchType_A9266.MouseDoubleClick += new global::System.Windows.Input.MouseButtonEventHandler(this.OnFieldNameDoubleClick);
			return;
			IL_ADA:
			this.MplCfgMPLListTADPLCode_A9257_Col = (global::Infragistics.Windows.DataPresenter.UnboundField)target;
			return;
			IL_AE7:
			this.RTDBtnMplCfgMPLListRxSquelchType_A9028 = (global::AcpUI.AcpRtdButton)target;
			return;
			IL_AF4:
			this.MplCfgMPLListTxDPLCode_A9527Comp = (global::AcpUI.AcpLabel)target;
			return;
			IL_B01:
			this.MplCfgMPLListTxPLFreq_A9556Comp = (global::AcpUI.AcpLabel)target;
			return;
			IL_B0E:
			this.RTDBtnMplCfgMPLListTADPLCode_A9257 = (global::AcpUI.AcpRtdButton)target;
			return;
			IL_B1B:
			this.LblMplCfgMPLListTxDPLCode_A9527 = (global::AcpUI.AcpLabel)target;
			this.LblMplCfgMPLListTxDPLCode_A9527.MouseDoubleClick += new global::System.Windows.Input.MouseButtonEventHandler(this.OnFieldNameDoubleClick);
			return;
			IL_B3F:
			this.LblMplCfgMPLListTxPLFreq_A9556 = (global::AcpUI.AcpLabel)target;
			this.LblMplCfgMPLListTxPLFreq_A9556.MouseDoubleClick += new global::System.Windows.Input.MouseButtonEventHandler(this.OnFieldNameDoubleClick);
			return;
			IL_B63:
			this.CVBtnMplCfgMPLListTxDPLCode_A9527 = (global::AcpUI.AcpCustomViewCheckBox)target;
			return;
			IL_B70:
			this.CpyBtnMplCfgMPLListTxDPLInvert_A9528 = (global::AcpUI.AcpCopyButton)target;
			return;
			IL_B7D:
			this.MplCfgMPLListTADPLCode_A9257Comp = (global::AcpUI.AcpLabel)target;
			return;
			IL_B8A:
			this.MyStackPanel = (global::System.Windows.Controls.StackPanel)target;
			return;
			IL_B97:
			this.MplCfgMPLListTASquelchType_A9266_Col = (global::Infragistics.Windows.DataPresenter.UnboundField)target;
			return;
			IL_BA4:
			this.RTDBtnMplCfgMPLListTxDPLCode_A9527 = (global::AcpUI.AcpRtdButton)target;
			return;
			IL_BB1:
			this.LblMplCfgMPLListTADPLInvert_A9258 = (global::AcpUI.AcpLabel)target;
			this.LblMplCfgMPLListTADPLInvert_A9258.MouseDoubleClick += new global::System.Windows.Input.MouseButtonEventHandler(this.OnFieldNameDoubleClick);
			return;
			IL_BD5:
			this.CVBtnMplCfgMPLListRxDPLCode_A9008 = (global::AcpUI.AcpCustomViewCheckBox)target;
			return;
			IL_BE2:
			this.CVBtnMplCfgMPLListRxPLFreq_A9027 = (global::AcpUI.AcpCustomViewCheckBox)target;
			return;
			IL_BEF:
			this.GrpBoxExpanderMPLConfigurationGeneralPseudo0 = (global::AcpUI.AcpGroupBox)target;
			return;
			IL_BFC:
			this.RTDBtnMplCfgMPLListTASquelchType_A9266 = (global::AcpUI.AcpRtdButton)target;
			return;
			IL_C09:
			this.MplCfgMPLListTADPLInvert_A9258_Col = (global::Infragistics.Windows.DataPresenter.UnboundField)target;
			return;
			IL_C16:
			this.CVBtnMplCfgMPLListMPLAlias_A8548 = (global::AcpUI.AcpCustomViewCheckBox)target;
			return;
			IL_C23:
			this.ExpanderMPLConfigurationLabtool = (global::AcpUI.AcpExpander)target;
			return;
			IL_C30:
			this.LblMplCfgMPLListRxPLCode_A9026 = (global::AcpUI.AcpLabel)target;
			this.LblMplCfgMPLListRxPLCode_A9026.MouseDoubleClick += new global::System.Windows.Input.MouseButtonEventHandler(this.OnFieldNameDoubleClick);
			return;
			IL_C54:
			this.ExpanderMPLConfigurationGeneral = (global::AcpUI.AcpExpander)target;
			return;
			IL_C61:
			this.RTDBtnMplCfgGeneralMPLSelectMode_A8549 = (global::AcpUI.AcpRtdButton)target;
			return;
			IL_C6E:
			this.MplCfgGeneralMPLSelectMode_A8549Comp = (global::AcpUI.AcpLabel)target;
			return;
			IL_C7B:
			this.MplCfgMPLListTAPLFreq_A9263 = (global::AcpUI.AcpComboBox)target;
			this.MplCfgMPLListTAPLFreq_A9263.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_C9F:
			num = (short)258867201;
			if (num != 0)
			{
			}
			this.CpyBtnMplCfgMPLListTADPLCode_A9257 = (global::AcpUI.AcpCopyButton)target;
			return;
			IL_CD4:
			this.RTDBtnMplCfgMPLListTxPLFreq_A9556 = (global::AcpUI.AcpRtdButton)target;
			return;
			IL_CE1:
			this.CpyBtnMplCfgMPLListRxDPLCode_A9008 = (global::AcpUI.AcpCopyButton)target;
			return;
			IL_CEE:
			this.CVBtnMplCfgMPLListTADPLInvert_A9258 = (global::AcpUI.AcpCustomViewCheckBox)target;
			return;
			IL_CFB:
			this.MplCfgMPLListMPLAlias_A8548_Col = (global::Infragistics.Windows.DataPresenter.UnboundField)target;
			return;
			IL_D08:
			this.RTDBtnMplCfgMPLListRxPLCode_A9026 = (global::AcpUI.AcpRtdButton)target;
			return;
			IL_D15:
			this.MplCfgMPLListTAPLCode_A9262Comp = (global::AcpUI.AcpLabel)target;
			return;
			IL_D22:
			this.MplCfgMPLListTADPLInvert_A9258Comp = (global::AcpUI.AcpLabel)target;
			return;
			IL_D2F:
			this.MplCfgMPLListTAPLFreq_A9263_Col = (global::Infragistics.Windows.DataPresenter.UnboundField)target;
			return;
			IL_D3C:
			this.ExpanderMPLConfigurationMPLListTableTableView = (global::AcpUI.AcpGroupBox)target;
			return;
			IL_D49:
			this.CVBtnMplCfgMPLListTxPLFreq_A9556 = (global::AcpUI.AcpCustomViewCheckBox)target;
			return;
			IL_D56:
			this.MplCfgMPLListTADPLInvert_A9258 = (global::AcpUI.AcpComboBox)target;
			this.MplCfgMPLListTADPLInvert_A9258.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_D7A:
			this.RTDBtnMplCfgMPLListTAPLCode_A9262 = (global::AcpUI.AcpRtdButton)target;
			return;
			IL_D87:
			this.MplCfgMPLListRxSquelchType_A9028_Col = (global::Infragistics.Windows.DataPresenter.UnboundField)target;
			return;
			IL_D94:
			this.MplCfgMPLListMPLAlias_A8548 = (global::AcpUI.AcpTextBox)target;
			this.MplCfgMPLListMPLAlias_A8548.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_DB8:
			this.CpyBtnMplCfgMPLListTADPLInvert_A9258 = (global::AcpUI.AcpCopyButton)target;
			return;
			IL_DC5:
			this.CpyBtnMplCfgMPLListRxDPLInvert_A9009 = (global::AcpUI.AcpCopyButton)target;
			return;
			IL_DD2:
			this.LblMplCfgMPLListRxPLFreq_A9027 = (global::AcpUI.AcpLabel)target;
			this.LblMplCfgMPLListRxPLFreq_A9027.MouseDoubleClick += new global::System.Windows.Input.MouseButtonEventHandler(this.OnFieldNameDoubleClick);
			return;
			IL_DF6:
			this.LblMplCfgGeneralMPLSelectMode_A8549 = (global::AcpUI.AcpLabel)target;
			this.LblMplCfgGeneralMPLSelectMode_A8549.MouseDoubleClick += new global::System.Windows.Input.MouseButtonEventHandler(this.OnFieldNameDoubleClick);
			return;
			IL_E1A:
			this.HLinkLabtool = (global::System.Windows.Documents.Hyperlink)target;
			this.HLinkLabtool.Click += this.HLinkClick;
			return;
			IL_E3E:
			this.MplCfgMPLListRxDPLInvert_A9009 = (global::AcpUI.AcpComboBox)target;
			this.MplCfgMPLListRxDPLInvert_A9009.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_E62:
			this.RTDBtnMplCfgMPLListTAPLFreq_A9263 = (global::AcpUI.AcpRtdButton)target;
			return;
			IL_E6F:
			this.CpyBtnMplCfgGeneralMPLSelectMode_A8549 = (global::AcpUI.AcpCopyButton)target;
			return;
			IL_E7C:
			this.b = true;
		}

		// Token: 0x0600B207 RID: 45575 RVA: 0x00A55CB0 File Offset: 0x00A53EB0
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		[global::System.Diagnostics.DebuggerNonUserCode]
		[global::System.CodeDom.Compiler.GeneratedCode("PresentationBuildTasks", "5.0.10.0")]
		void global::System.Windows.Markup.IStyleConnector.Connect(int connectionId, object target)
		{
			short num;
			switch (connectionId)
			{
			case 3:
				((global::AcpUI.AcpTableTextBox)target).GotFocus += this.OnFieldNameDoubleClick;
				return;
			case 4:
				((global::AcpUI.AcpTableComboBox)target).GotFocus += this.OnFieldNameDoubleClick;
				return;
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
				break;
			case 9:
				((global::AcpUI.AcpTableComboBox)target).GotFocus += this.OnFieldNameDoubleClick;
				return;
			case 10:
				((global::AcpUI.AcpTableComboBox)target).GotFocus += this.OnFieldNameDoubleClick;
				return;
			case 11:
				((global::AcpUI.AcpTableComboBox)target).GotFocus += this.OnFieldNameDoubleClick;
				return;
			case 12:
				((global::AcpUI.AcpTableComboBox)target).GotFocus += this.OnFieldNameDoubleClick;
				return;
			case 13:
			{
				num = (short)1936412305;
				short num2 = num;
				num = (short)1266372241;
				switch ((num2 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					break;
				default:
					num = (short)793378816;
					if (num != 0)
					{
					}
					((global::AcpUI.AcpTableComboBox)target).GotFocus += this.OnFieldNameDoubleClick;
					return;
				}
				break;
			}
			case 14:
				((global::AcpUI.AcpTableComboBox)target).GotFocus += this.OnFieldNameDoubleClick;
				return;
			case 15:
				num = (short)251920385;
				if (num != 0)
				{
				}
				((global::AcpUI.AcpTableComboBox)target).GotFocus += this.OnFieldNameDoubleClick;
				return;
			case 16:
				((global::AcpUI.AcpTableComboBox)target).GotFocus += this.OnFieldNameDoubleClick;
				return;
			case 17:
				((global::AcpUI.AcpTableComboBox)target).GotFocus += this.OnFieldNameDoubleClick;
				return;
			case 18:
				((global::AcpUI.AcpTableComboBox)target).GotFocus += this.OnFieldNameDoubleClick;
				return;
			default:
				return;
			}
			num = (short)1661861888;
			short num3 = num;
			((global::AcpUI.AcpTableComboBox)target).GotFocus += this.OnFieldNameDoubleClick;
		}

		// Token: 0x040056FB RID: 22267
		private bool a;

		// Token: 0x040056FC RID: 22268
		internal global::AcpUI.AcpParentRecNavToolbar RecNavToolbarPageMPLConfiguration;

		// Token: 0x040056FD RID: 22269
		internal global::AcpUI.Common.AcpThemeBase ThemeBaseObj;

		// Token: 0x040056FE RID: 22270
		internal global::System.Windows.Documents.Hyperlink HLinkGeneral;

		// Token: 0x040056FF RID: 22271
		internal global::System.Windows.Documents.Hyperlink HLinkMPLList;

		// Token: 0x04005700 RID: 22272
		internal global::System.Windows.Documents.Hyperlink HLinkLabtool;

		// Token: 0x04005701 RID: 22273
		internal global::System.Windows.Controls.StackPanel MyStackPanel;

		// Token: 0x04005702 RID: 22274
		internal global::AcpUI.AcpExpander ExpanderMPLConfigurationGeneral;

		// Token: 0x04005703 RID: 22275
		internal global::AcpUI.AcpGroupBox GrpBoxExpanderMPLConfigurationGeneralPseudo0;

		// Token: 0x04005704 RID: 22276
		internal global::AcpUI.AcpCustomViewCheckBox CVBtnMplCfgGeneralMPLSelectMode_A8549;

		// Token: 0x04005705 RID: 22277
		internal global::AcpUI.AcpLabel LblMplCfgGeneralMPLSelectMode_A8549;

		// Token: 0x04005706 RID: 22278
		internal global::AcpUI.AcpComboBox MplCfgGeneralMPLSelectMode_A8549;

		// Token: 0x04005707 RID: 22279
		internal global::AcpUI.AcpRtdButton RTDBtnMplCfgGeneralMPLSelectMode_A8549;

		// Token: 0x04005708 RID: 22280
		internal global::AcpUI.AcpCopyButton CpyBtnMplCfgGeneralMPLSelectMode_A8549;

		// Token: 0x04005709 RID: 22281
		internal global::AcpUI.AcpLabel MplCfgGeneralMPLSelectMode_A8549Comp;

		// Token: 0x0400570A RID: 22282
		internal global::AcpUI.AcpCustomViewCheckBox CVBtnMplCfgGeneralPresetMPLEntry_A8739;

		// Token: 0x0400570B RID: 22283
		internal global::AcpUI.AcpLabel LblMplCfgGeneralPresetMPLEntry_A8739;

		// Token: 0x0400570C RID: 22284
		internal global::AcpUI.AcpComboBox MplCfgGeneralPresetMPLEntry_A8739;

		// Token: 0x0400570D RID: 22285
		internal global::AcpUI.AcpRtdButton RTDBtnMplCfgGeneralPresetMPLEntry_A8739;

		// Token: 0x0400570E RID: 22286
		internal global::AcpUI.AcpCopyButton CpyBtnMplCfgGeneralPresetMPLEntry_A8739;

		// Token: 0x0400570F RID: 22287
		internal global::AcpUI.AcpLabel MplCfgGeneralPresetMPLEntry_A8739Comp;

		// Token: 0x04005710 RID: 22288
		internal global::AcpUI.AcpExpander ExpanderMPLConfigurationMPLList;

		// Token: 0x04005711 RID: 22289
		internal global::AcpUI.AcpChildRecNavToolbar RecNavToolbarExpanderMPLConfigurationMPLListTable;

		// Token: 0x04005712 RID: 22290
		internal global::System.Windows.Controls.Grid ExpanderMPLConfigurationMPLListGrid;

		// Token: 0x04005713 RID: 22291
		internal global::System.Windows.Controls.Grid ExpanderMPLConfigurationMPLListTableGrid;

		// Token: 0x04005714 RID: 22292
		internal global::AcpUI.AcpGroupBox ExpanderMPLConfigurationMPLListTableTableView;

		// Token: 0x04005715 RID: 22293
		internal global::AcpUI.AcpXamDataPresenter ExpanderMPLConfigurationMPLListTable;

		// Token: 0x04005716 RID: 22294
		internal global::Infragistics.Windows.DataPresenter.UnboundField MplCfgMPLListMPLAlias_A8548_Col;

		// Token: 0x04005717 RID: 22295
		internal global::Infragistics.Windows.DataPresenter.UnboundField MplCfgMPLListRxSquelchType_A9028_Col;

		// Token: 0x04005718 RID: 22296
		internal global::Infragistics.Windows.DataPresenter.UnboundField MplCfgMPLListRxPLFreq_A9027_Col;

		// Token: 0x04005719 RID: 22297
		internal global::Infragistics.Windows.DataPresenter.UnboundField MplCfgMPLListRxPLCode_A9026_Col;

		// Token: 0x0400571A RID: 22298
		internal global::Infragistics.Windows.DataPresenter.UnboundField MplCfgMPLListRxDPLCode_A9008_Col;

		// Token: 0x0400571B RID: 22299
		internal global::Infragistics.Windows.DataPresenter.UnboundField MplCfgMPLListRxDPLInvert_A9009_Col;

		// Token: 0x0400571C RID: 22300
		internal global::Infragistics.Windows.DataPresenter.UnboundField MplCfgMPLListTxSquelchType_A9567_Col;

		// Token: 0x0400571D RID: 22301
		internal global::Infragistics.Windows.DataPresenter.UnboundField MplCfgMPLListTxPLFreq_A9556_Col;

		// Token: 0x0400571E RID: 22302
		internal global::Infragistics.Windows.DataPresenter.UnboundField MplCfgMPLListTxPLCode_A9555_Col;

		// Token: 0x0400571F RID: 22303
		internal global::Infragistics.Windows.DataPresenter.UnboundField MplCfgMPLListTxDPLCode_A9527_Col;

		// Token: 0x04005720 RID: 22304
		internal global::Infragistics.Windows.DataPresenter.UnboundField MplCfgMPLListTxDPLInvert_A9528_Col;

		// Token: 0x04005721 RID: 22305
		internal global::Infragistics.Windows.DataPresenter.UnboundField MplCfgMPLListTASquelchType_A9266_Col;

		// Token: 0x04005722 RID: 22306
		internal global::Infragistics.Windows.DataPresenter.UnboundField MplCfgMPLListTAPLFreq_A9263_Col;

		// Token: 0x04005723 RID: 22307
		internal global::Infragistics.Windows.DataPresenter.UnboundField MplCfgMPLListTAPLCode_A9262_Col;

		// Token: 0x04005724 RID: 22308
		internal global::Infragistics.Windows.DataPresenter.UnboundField MplCfgMPLListTADPLCode_A9257_Col;

		// Token: 0x04005725 RID: 22309
		internal global::Infragistics.Windows.DataPresenter.UnboundField MplCfgMPLListTADPLInvert_A9258_Col;

		// Token: 0x04005726 RID: 22310
		internal global::AcpUI.AcpGroupBox ExpanderMPLConfigurationMPLListTableSRecView;

		// Token: 0x04005727 RID: 22311
		internal global::System.Windows.Controls.Grid gridExpanderMPLConfigurationMPLListTableSRecView;

		// Token: 0x04005728 RID: 22312
		internal global::AcpUI.AcpTextBox MplCfgMPLListMPLAlias_A8548;

		// Token: 0x04005729 RID: 22313
		internal global::AcpUI.AcpCustomViewCheckBox CVBtnMplCfgMPLListMPLAlias_A8548;

		// Token: 0x0400572A RID: 22314
		internal global::AcpUI.AcpLabel LblMplCfgMPLListMPLAlias_A8548;

		// Token: 0x0400572B RID: 22315
		internal global::AcpUI.AcpCopyButton CpyBtnMplCfgMPLListMPLAlias_A8548;

		// Token: 0x0400572C RID: 22316
		internal global::AcpUI.AcpLabel MplCfgMPLListMPLAlias_A8548Comp;

		// Token: 0x0400572D RID: 22317
		internal global::AcpUI.AcpComboBox MplCfgMPLListRxSquelchType_A9028;

		// Token: 0x0400572E RID: 22318
		internal global::AcpUI.AcpCustomViewCheckBox CVBtnMplCfgMPLListRxSquelchType_A9028;

		// Token: 0x0400572F RID: 22319
		internal global::AcpUI.AcpLabel LblMplCfgMPLListRxSquelchType_A9028;

		// Token: 0x04005730 RID: 22320
		internal global::AcpUI.AcpRtdButton RTDBtnMplCfgMPLListRxSquelchType_A9028;

		// Token: 0x04005731 RID: 22321
		internal global::AcpUI.AcpCopyButton CpyBtnMplCfgMPLListRxSquelchType_A9028;

		// Token: 0x04005732 RID: 22322
		internal global::AcpUI.AcpLabel MplCfgMPLListRxSquelchType_A9028Comp;

		// Token: 0x04005733 RID: 22323
		internal global::AcpUI.AcpComboBox MplCfgMPLListRxPLFreq_A9027;

		// Token: 0x04005734 RID: 22324
		internal global::AcpUI.AcpCustomViewCheckBox CVBtnMplCfgMPLListRxPLFreq_A9027;

		// Token: 0x04005735 RID: 22325
		internal global::AcpUI.AcpLabel LblMplCfgMPLListRxPLFreq_A9027;

		// Token: 0x04005736 RID: 22326
		internal global::AcpUI.AcpRtdButton RTDBtnMplCfgMPLListRxPLFreq_A9027;

		// Token: 0x04005737 RID: 22327
		internal global::AcpUI.AcpCopyButton CpyBtnMplCfgMPLListRxPLFreq_A9027;

		// Token: 0x04005738 RID: 22328
		internal global::AcpUI.AcpLabel MplCfgMPLListRxPLFreq_A9027Comp;

		// Token: 0x04005739 RID: 22329
		internal global::AcpUI.AcpComboBox MplCfgMPLListRxPLCode_A9026;

		// Token: 0x0400573A RID: 22330
		internal global::AcpUI.AcpCustomViewCheckBox CVBtnMplCfgMPLListRxPLCode_A9026;

		// Token: 0x0400573B RID: 22331
		internal global::AcpUI.AcpLabel LblMplCfgMPLListRxPLCode_A9026;

		// Token: 0x0400573C RID: 22332
		internal global::AcpUI.AcpRtdButton RTDBtnMplCfgMPLListRxPLCode_A9026;

		// Token: 0x0400573D RID: 22333
		internal global::AcpUI.AcpCopyButton CpyBtnMplCfgMPLListRxPLCode_A9026;

		// Token: 0x0400573E RID: 22334
		internal global::AcpUI.AcpLabel MplCfgMPLListRxPLCode_A9026Comp;

		// Token: 0x0400573F RID: 22335
		internal global::AcpUI.AcpComboBox MplCfgMPLListRxDPLCode_A9008;

		// Token: 0x04005740 RID: 22336
		internal global::AcpUI.AcpCustomViewCheckBox CVBtnMplCfgMPLListRxDPLCode_A9008;

		// Token: 0x04005741 RID: 22337
		internal global::AcpUI.AcpLabel LblMplCfgMPLListRxDPLCode_A9008;

		// Token: 0x04005742 RID: 22338
		internal global::AcpUI.AcpRtdButton RTDBtnMplCfgMPLListRxDPLCode_A9008;

		// Token: 0x04005743 RID: 22339
		internal global::AcpUI.AcpCopyButton CpyBtnMplCfgMPLListRxDPLCode_A9008;

		// Token: 0x04005744 RID: 22340
		internal global::AcpUI.AcpLabel MplCfgMPLListRxDPLCode_A9008Comp;

		// Token: 0x04005745 RID: 22341
		internal global::AcpUI.AcpComboBox MplCfgMPLListRxDPLInvert_A9009;

		// Token: 0x04005746 RID: 22342
		internal global::AcpUI.AcpCustomViewCheckBox CVBtnMplCfgMPLListRxDPLInvert_A9009;

		// Token: 0x04005747 RID: 22343
		internal global::AcpUI.AcpLabel LblMplCfgMPLListRxDPLInvert_A9009;

		// Token: 0x04005748 RID: 22344
		internal global::AcpUI.AcpRtdButton RTDBtnMplCfgMPLListRxDPLInvert_A9009;

		// Token: 0x04005749 RID: 22345
		internal global::AcpUI.AcpCopyButton CpyBtnMplCfgMPLListRxDPLInvert_A9009;

		// Token: 0x0400574A RID: 22346
		internal global::AcpUI.AcpLabel MplCfgMPLListRxDPLInvert_A9009Comp;

		// Token: 0x0400574B RID: 22347
		internal global::AcpUI.AcpComboBox MplCfgMPLListTxSquelchType_A9567;

		// Token: 0x0400574C RID: 22348
		internal global::AcpUI.AcpCustomViewCheckBox CVBtnMplCfgMPLListTxSquelchType_A9567;

		// Token: 0x0400574D RID: 22349
		internal global::AcpUI.AcpLabel LblMplCfgMPLListTxSquelchType_A9567;

		// Token: 0x0400574E RID: 22350
		internal global::AcpUI.AcpRtdButton RTDBtnMplCfgMPLListTxSquelchType_A9567;

		// Token: 0x0400574F RID: 22351
		internal global::AcpUI.AcpCopyButton CpyBtnMplCfgMPLListTxSquelchType_A9567;

		// Token: 0x04005750 RID: 22352
		internal global::AcpUI.AcpLabel MplCfgMPLListTxSquelchType_A9567Comp;

		// Token: 0x04005751 RID: 22353
		internal global::AcpUI.AcpComboBox MplCfgMPLListTxPLFreq_A9556;

		// Token: 0x04005752 RID: 22354
		internal global::AcpUI.AcpCustomViewCheckBox CVBtnMplCfgMPLListTxPLFreq_A9556;

		// Token: 0x04005753 RID: 22355
		internal global::AcpUI.AcpLabel LblMplCfgMPLListTxPLFreq_A9556;

		// Token: 0x04005754 RID: 22356
		internal global::AcpUI.AcpRtdButton RTDBtnMplCfgMPLListTxPLFreq_A9556;

		// Token: 0x04005755 RID: 22357
		internal global::AcpUI.AcpCopyButton CpyBtnMplCfgMPLListTxPLFreq_A9556;

		// Token: 0x04005756 RID: 22358
		internal global::AcpUI.AcpLabel MplCfgMPLListTxPLFreq_A9556Comp;

		// Token: 0x04005757 RID: 22359
		internal global::AcpUI.AcpComboBox MplCfgMPLListTxPLCode_A9555;

		// Token: 0x04005758 RID: 22360
		internal global::AcpUI.AcpCustomViewCheckBox CVBtnMplCfgMPLListTxPLCode_A9555;

		// Token: 0x04005759 RID: 22361
		internal global::AcpUI.AcpLabel LblMplCfgMPLListTxPLCode_A9555;

		// Token: 0x0400575A RID: 22362
		internal global::AcpUI.AcpRtdButton RTDBtnMplCfgMPLListTxPLCode_A9555;

		// Token: 0x0400575B RID: 22363
		internal global::AcpUI.AcpCopyButton CpyBtnMplCfgMPLListTxPLCode_A9555;

		// Token: 0x0400575C RID: 22364
		internal global::AcpUI.AcpLabel MplCfgMPLListTxPLCode_A9555Comp;

		// Token: 0x0400575D RID: 22365
		internal global::AcpUI.AcpComboBox MplCfgMPLListTxDPLCode_A9527;

		// Token: 0x0400575E RID: 22366
		internal global::AcpUI.AcpCustomViewCheckBox CVBtnMplCfgMPLListTxDPLCode_A9527;

		// Token: 0x0400575F RID: 22367
		internal global::AcpUI.AcpLabel LblMplCfgMPLListTxDPLCode_A9527;

		// Token: 0x04005760 RID: 22368
		internal global::AcpUI.AcpRtdButton RTDBtnMplCfgMPLListTxDPLCode_A9527;

		// Token: 0x04005761 RID: 22369
		internal global::AcpUI.AcpCopyButton CpyBtnMplCfgMPLListTxDPLCode_A9527;

		// Token: 0x04005762 RID: 22370
		internal global::AcpUI.AcpLabel MplCfgMPLListTxDPLCode_A9527Comp;

		// Token: 0x04005763 RID: 22371
		internal global::AcpUI.AcpComboBox MplCfgMPLListTxDPLInvert_A9528;

		// Token: 0x04005764 RID: 22372
		internal global::AcpUI.AcpCustomViewCheckBox CVBtnMplCfgMPLListTxDPLInvert_A9528;

		// Token: 0x04005765 RID: 22373
		internal global::AcpUI.AcpLabel LblMplCfgMPLListTxDPLInvert_A9528;

		// Token: 0x04005766 RID: 22374
		internal global::AcpUI.AcpRtdButton RTDBtnMplCfgMPLListTxDPLInvert_A9528;

		// Token: 0x04005767 RID: 22375
		internal global::AcpUI.AcpCopyButton CpyBtnMplCfgMPLListTxDPLInvert_A9528;

		// Token: 0x04005768 RID: 22376
		internal global::AcpUI.AcpLabel MplCfgMPLListTxDPLInvert_A9528Comp;

		// Token: 0x04005769 RID: 22377
		internal global::AcpUI.AcpComboBox MplCfgMPLListTASquelchType_A9266;

		// Token: 0x0400576A RID: 22378
		internal global::AcpUI.AcpCustomViewCheckBox CVBtnMplCfgMPLListTASquelchType_A9266;

		// Token: 0x0400576B RID: 22379
		internal global::AcpUI.AcpLabel LblMplCfgMPLListTASquelchType_A9266;

		// Token: 0x0400576C RID: 22380
		internal global::AcpUI.AcpRtdButton RTDBtnMplCfgMPLListTASquelchType_A9266;

		// Token: 0x0400576D RID: 22381
		internal global::AcpUI.AcpCopyButton CpyBtnMplCfgMPLListTASquelchType_A9266;

		// Token: 0x0400576E RID: 22382
		internal global::AcpUI.AcpLabel MplCfgMPLListTASquelchType_A9266Comp;

		// Token: 0x0400576F RID: 22383
		internal global::AcpUI.AcpComboBox MplCfgMPLListTAPLFreq_A9263;

		// Token: 0x04005770 RID: 22384
		internal global::AcpUI.AcpCustomViewCheckBox CVBtnMplCfgMPLListTAPLFreq_A9263;

		// Token: 0x04005771 RID: 22385
		internal global::AcpUI.AcpLabel LblMplCfgMPLListTAPLFreq_A9263;

		// Token: 0x04005772 RID: 22386
		internal global::AcpUI.AcpRtdButton RTDBtnMplCfgMPLListTAPLFreq_A9263;

		// Token: 0x04005773 RID: 22387
		internal global::AcpUI.AcpCopyButton CpyBtnMplCfgMPLListTAPLFreq_A9263;

		// Token: 0x04005774 RID: 22388
		internal global::AcpUI.AcpLabel MplCfgMPLListTAPLFreq_A9263Comp;

		// Token: 0x04005775 RID: 22389
		internal global::AcpUI.AcpComboBox MplCfgMPLListTAPLCode_A9262;

		// Token: 0x04005776 RID: 22390
		internal global::AcpUI.AcpCustomViewCheckBox CVBtnMplCfgMPLListTAPLCode_A9262;

		// Token: 0x04005777 RID: 22391
		internal global::AcpUI.AcpLabel LblMplCfgMPLListTAPLCode_A9262;

		// Token: 0x04005778 RID: 22392
		internal global::AcpUI.AcpRtdButton RTDBtnMplCfgMPLListTAPLCode_A9262;

		// Token: 0x04005779 RID: 22393
		internal global::AcpUI.AcpCopyButton CpyBtnMplCfgMPLListTAPLCode_A9262;

		// Token: 0x0400577A RID: 22394
		internal global::AcpUI.AcpLabel MplCfgMPLListTAPLCode_A9262Comp;

		// Token: 0x0400577B RID: 22395
		internal global::AcpUI.AcpComboBox MplCfgMPLListTADPLCode_A9257;

		// Token: 0x0400577C RID: 22396
		internal global::AcpUI.AcpCustomViewCheckBox CVBtnMplCfgMPLListTADPLCode_A9257;

		// Token: 0x0400577D RID: 22397
		internal global::AcpUI.AcpLabel LblMplCfgMPLListTADPLCode_A9257;

		// Token: 0x0400577E RID: 22398
		internal global::AcpUI.AcpRtdButton RTDBtnMplCfgMPLListTADPLCode_A9257;

		// Token: 0x0400577F RID: 22399
		internal global::AcpUI.AcpCopyButton CpyBtnMplCfgMPLListTADPLCode_A9257;

		// Token: 0x04005780 RID: 22400
		internal global::AcpUI.AcpLabel MplCfgMPLListTADPLCode_A9257Comp;

		// Token: 0x04005781 RID: 22401
		internal global::AcpUI.AcpComboBox MplCfgMPLListTADPLInvert_A9258;

		// Token: 0x04005782 RID: 22402
		internal global::AcpUI.AcpCustomViewCheckBox CVBtnMplCfgMPLListTADPLInvert_A9258;

		// Token: 0x04005783 RID: 22403
		internal global::AcpUI.AcpLabel LblMplCfgMPLListTADPLInvert_A9258;

		// Token: 0x04005784 RID: 22404
		internal global::AcpUI.AcpRtdButton RTDBtnMplCfgMPLListTADPLInvert_A9258;

		// Token: 0x04005785 RID: 22405
		internal global::AcpUI.AcpCopyButton CpyBtnMplCfgMPLListTADPLInvert_A9258;

		// Token: 0x04005786 RID: 22406
		internal global::AcpUI.AcpLabel MplCfgMPLListTADPLInvert_A9258Comp;

		// Token: 0x04005787 RID: 22407
		internal global::AcpUI.AcpExpander ExpanderMPLConfigurationLabtool;

		// Token: 0x04005788 RID: 22408
		private bool b;
	}
}
