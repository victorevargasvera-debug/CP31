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

namespace Motorola.MackinawCPS.CoreFeatures.EnhancedDataPortList
{
	// Token: 0x020004BB RID: 1211
	public class PageEnhancedDataPortList : global::AcpUI.AcpPageFeature, global::System.Windows.Markup.IComponentConnector, global::System.Windows.Markup.IStyleConnector
	{
		// Token: 0x06009FA0 RID: 40864 RVA: 0x0094E8A4 File Offset: 0x0094CAA4
		public PageEnhancedDataPortList()
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

		// Token: 0x06009FA1 RID: 40865 RVA: 0x0094E8DC File Offset: 0x0094CADC
		public override void OnLoaded(object sender, global::System.Windows.RoutedEventArgs e)
		{
			short num = (short)1931018240;
			int num2 = (int)num;
			switch (num2)
			{
			default:
				num = (short)1118830592;
				num2 = (int)((global::System.IntPtr)num);
				for (;;)
				{
					global::AcpUI.AcpExpander acpExpander;
					global::System.Collections.IEnumerator enumerator;
					switch (num2)
					{
					case 0:
						switch (0)
						{
						case 0:
							goto IL_61;
						}
						continue;
					case 1:
					{
						object obj;
						if (obj != null)
						{
							num = (short)1233911810;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_83;
					}
					case 2:
					{
						num = (short)438108161;
						if (num != 0)
						{
						}
						num = (short)877395968;
						short num3 = num;
						object obj;
						global::System.Windows.Data.CollectionView collectionView = (global::System.Windows.Data.CollectionView)global::System.Windows.Data.CollectionViewSource.GetDefaultView(obj);
						this.RecNavToolbarExpanderEnhancedDataPortListEnhancedDataPortTable.MyDataPresenter = this.ExpanderEnhancedDataPortListEnhancedDataPortTable;
						num = (short)1943273477;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 3:
						goto IL_183;
					case 4:
						try
						{
							num = (short)322306048;
							num2 = (int)((global::System.IntPtr)num);
							for (;;)
							{
								switch (num2)
								{
								case 0:
									switch (0)
									{
									case 0:
										goto IL_205;
									}
									continue;
								case 2:
									if (acpExpander != null)
									{
										num = (short)1940389891;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									break;
								case 3:
									for (;;)
									{
										num = (short)1650477832;
										short num4 = num;
										num = (short)1494960904;
										switch ((num4 == num) ? 1 : 0)
										{
										case 0:
										case 2:
											break;
										default:
											goto IL_277;
										}
									}
									IL_277:
									num = (short)1481375744;
									if (num != 0)
									{
									}
									base.Expanders.Add(acpExpander);
									num = (short)1567031297;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 4:
									num = (short)1710161925;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 5:
									goto IL_31B;
								case 6:
									if (!enumerator.MoveNext())
									{
										num = (short)1436418052;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									acpExpander = (((global::System.Windows.UIElement)enumerator.Current) as global::AcpUI.AcpExpander);
									num = (short)1993146370;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								IL_207:
								num = (short)1571487750;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								IL_205:
								goto IL_207;
							}
							IL_31B:
							goto IL_15B;
						}
						finally
						{
							switch (0)
							{
							case 0:
								goto IL_33D;
							}
							global::System.IDisposable disposable;
							for (;;)
							{
								IL_32A:
								switch (num2)
								{
								case 0:
									disposable.Dispose();
									num = (short)1417150465;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 1:
									goto IL_38E;
								case 2:
									if (disposable != null)
									{
										num = (short)2023882752;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									goto IL_390;
								}
								goto IL_33D;
							}
							IL_38E:
							IL_390:
							goto EndFinally_8;
							IL_33D:
							disposable = (enumerator as global::System.IDisposable);
							num = (short)1046675458;
							num2 = (int)((global::System.IntPtr)num);
							goto IL_32A;
							EndFinally_8:;
						}
						goto IL_391;
						IL_15B:
						base.OnLoaded(sender, e);
						this.a = true;
						num = (short)866189315;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 5:
						goto IL_83;
					case 6:
					{
						this.RecNavToolbarPageEnhancedDataPortList.ChildToolbars.Add(this.RecNavToolbarExpanderEnhancedDataPortListEnhancedDataPortTable);
						object obj = null;
						obj = this.RecNavToolbarExpanderEnhancedDataPortListEnhancedDataPortTable.MyRecordsetDataSource;
						num = (short)1254359041;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					}
					IL_61:
					if (!this.a)
					{
						num = (short)387514374;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					break;
					IL_83:
					acpExpander = null;
					enumerator = this.MyStackPanel.Children.GetEnumerator();
					num = (short)1693188100;
					num2 = (int)((global::System.IntPtr)num);
				}
				IL_183:
				IL_391:
				this.MyStackPanel.Children[0].Focus();
				return;
			}
		}

		// Token: 0x06009FA2 RID: 40866 RVA: 0x0094ECB0 File Offset: 0x0094CEB0
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
					goto IL_CD;
				case 1:
					goto IL_11E;
				case 2:
					if (this.a)
					{
						num2 = (short)1819410432;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_120;
				}
				goto IL_1C;
			}
			IL_CD:
			num2 = (short)1393360897;
			if (num2 != 0)
			{
			}
			goto IL_F8;
			IL_11E:
			IL_120:
			num2 = (short)1700724736;
			short num3 = num2;
			return;
			IL_1C:
			this.RecNavToolbarPageEnhancedDataPortList.DataContext = null;
			this.RecNavToolbarExpanderEnhancedDataPortListEnhancedDataPortTable.DataContext = null;
			this.RecNavToolbarPageEnhancedDataPortList.MyDataPresenter = null;
			this.RecNavToolbarExpanderEnhancedDataPortListEnhancedDataPortTable.MyDataPresenter = null;
			num2 = (short)1519863791;
			short num4 = num2;
			num2 = (short)1054623727;
			switch ((num4 == num2) ? 1 : 0)
			{
			case 0:
			case 2:
			{
				IL_F8:
				base.OnUnloaded(sender, e);
				this.a = false;
				num2 = (short)359202817;
				int num = (int)((global::System.IntPtr)num2);
				goto IL_0A;
			}
			default:
			{
				num2 = (short)796524544;
				if (num2 != 0)
				{
				}
				num2 = (short)1224081410;
				int num = (int)((global::System.IntPtr)num2);
				goto IL_0A;
			}
			}
		}

		// Token: 0x06009FA3 RID: 40867 RVA: 0x0094EE08 File Offset: 0x0094D008
		public override void SetDataContext()
		{
			short num = (short)1835532289;
			int num2 = (int)((global::System.IntPtr)num);
			object feature;
			for (;;)
			{
				switch (num2)
				{
				case 0:
					goto IL_125;
				case 1:
					switch (0)
					{
					case 0:
						goto IL_48;
					}
					continue;
				case 2:
					num = (short)130875393;
					if (num != 0)
					{
					}
					if (feature != null)
					{
						num = (short)2124611591;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					return;
				case 3:
				{
					num = (short)1936872224;
					short num3 = num;
					num = (short)525423392;
					switch ((num3 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_A9;
					default:
						num = (short)1351876608;
						if (num != 0)
						{
						}
						goto IL_7C;
					}
					break;
				}
				case 4:
					goto IL_7C;
				case 5:
					goto IL_A9;
				case 6:
					feature = global::AcpCommonLib.AppInfoManager.ComparatorDocument.GetFeature(4148);
					num = (short)515768322;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 7:
					goto IL_236;
				case 8:
					base.DataContext = global::AcpCommonLib.AppInfoManager.DefaultDocument.GetFeature(4148);
					num = (short)1209073668;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				IL_48:
				if (global::AcpCommonLib.AppInfoManager.AppMode == global::AcpCommonLib.ApplicationMode.CustomViewConfigurationMode)
				{
					num = (short)900595720;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				num = (short)1381564416;
				short num4 = num;
				base.DataContext = global::AcpCommonLib.FeatureManager.GetFeature(4148);
				num = (short)1747451907;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_7C:
				this.RecNavToolbarPageEnhancedDataPortList.DataContext = (global::AcpCommonLib.IAcpRecordset)base.DataContext;
				num = (short)714407941;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_A9:
				if (global::AcpCommonLib.AppInfoManager.AppMode == global::AcpCommonLib.ApplicationMode.CodeplugComparisonMode)
				{
					num = (short)1567293446;
					num2 = (int)((global::System.IntPtr)num);
				}
				else
				{
					((global::AcpUILib.IAcpRecNavToolbar)this.RecNavToolbarPageEnhancedDataPortList).MySecondaryRecordsetDataSource = null;
					num = (short)96796672;
					num2 = (int)((global::System.IntPtr)num);
				}
			}
			IL_125:
			return;
			IL_236:
			((global::AcpUILib.IAcpRecNavToolbar)this.RecNavToolbarPageEnhancedDataPortList).MySecondaryRecordsetDataSource = (global::AcpCommonLib.IAcpRecordset)feature;
		}

		// Token: 0x06009FA4 RID: 40868 RVA: 0x0094F050 File Offset: 0x0094D250
		private void OnModeClick(object A_0, global::System.Windows.RoutedEventArgs A_1)
		{
			int a_ = 5;
			short num = (short)253034496;
			switch (num)
			{
			default:
			{
				num = (short)522518536;
				int num2 = (int)((global::System.IntPtr)num);
				for (;;)
				{
					switch (num2)
					{
					case 0:
					{
						global::System.Windows.Data.CollectionView collectionView;
						if (collectionView.Count > 0)
						{
							num = (short)1768816640;
							short num3 = num;
							num = (short)1083834374;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_2D5;
					}
					case 1:
						if (((global::AcpUI.AcpRecNavToolbar)A_0).Name == global::AllFeatures.CodeplugGuid.b("铅귇꧉苋꿍ꛏ蛑믓맕듗룙뷛곝냟菡菣菥귧蓩蓫迭黯釱釳鋵볷鯹裻鿽僿洁瘃爅䐇按缋稍", a_))
						{
							num = (short)343212036;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_27B;
					case 2:
					{
						global::System.Windows.Data.CollectionView collectionView;
						global::Motorola.MackinawCPS.CoreFeatures.EnhancedDataPortList.EnhancedDataPortTableInner enhancedDataPortTableInner;
						collectionView.MoveCurrentTo(enhancedDataPortTableInner);
						num = (short)563675147;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 3:
					{
						global::Motorola.MackinawCPS.CoreFeatures.EnhancedDataPortList.EnhancedDataPortTableInner enhancedDataPortTableInner;
						if (enhancedDataPortTableInner != null)
						{
							num = (short)77529090;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_308;
					}
					case 4:
					{
						global::AcpCommonLib.IAcpRecordset myRecordsetDataSource = this.RecNavToolbarPageEnhancedDataPortList.MyRecordsetDataSource;
						num = (short)1523318803;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 5:
					{
						global::System.Windows.Data.CollectionView collectionView;
						if (collectionView.IsCurrentAfterLast)
						{
							num = (short)266797078;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						collectionView.MoveCurrentToFirst();
						num = (short)2022899721;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 6:
						num = (short)2017918981;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 7:
					{
						global::AcpCommonLib.IAcpRecordset myRecordsetDataSource;
						base.NavigationService.Navigate(new global::System.Uri(myRecordsetDataSource.UIPagePath, global::System.UriKind.RelativeOrAbsolute));
						num = (short)2117402645;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 8:
						switch (0)
						{
						case 0:
							goto IL_A9;
						}
						continue;
					case 9:
						goto IL_18B;
					case 10:
					{
						object myRecordsetDataSource2;
						global::System.Windows.Data.CollectionView collectionView = (global::System.Windows.Data.CollectionView)global::System.Windows.Data.CollectionViewSource.GetDefaultView(myRecordsetDataSource2);
						global::Motorola.MackinawCPS.CoreFeatures.EnhancedDataPortList.EnhancedDataPortTableInner enhancedDataPortTableInner = (global::Motorola.MackinawCPS.CoreFeatures.EnhancedDataPortList.EnhancedDataPortTableInner)collectionView.CurrentItem;
						num = (short)1905917955;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 11:
						goto IL_130;
					case 12:
						if (((global::AcpUI.AcpRecNavToolbar)A_0).Name == global::AllFeatures.CodeplugGuid.b("铅귇꧉苋꿍ꛏ蛑믓맕듗룙뷛곝ꗟ髡铣蟥蛧軩觫鳭뗯鳱鳳韵雷駹駻髽䓿持瀃朅堇攉縋稍小笑朓戕崗琙琛缝丟䄡䄣䈥氧䬩堫伭怯崱䘳䈵氷嬹帻刽┿", a_))
						{
							num = (short)1821048845;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return;
					case 13:
						num = (short)1624375314;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 14:
						goto IL_1F8;
					case 15:
					{
						num = (short)1133072502;
						short num4 = num;
						num = (short)795758710;
						switch ((num4 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_308;
						default:
							num = (short)1194721280;
							if (num != 0)
							{
							}
							num = (short)1887633409;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						break;
					}
					case 16:
					{
						object myRecordsetDataSource2;
						if (myRecordsetDataSource2 != null)
						{
							num = (short)54263818;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return;
					}
					case 17:
					{
						((global::AcpUI.AcpRecNavToolbar)A_0).TableMode = false;
						object myRecordsetDataSource2 = this.RecNavToolbarExpanderEnhancedDataPortListEnhancedDataPortTable.MyRecordsetDataSource;
						num = (short)1638203408;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 18:
						if (((global::AcpUI.AcpRecNavToolbar)A_0).TableMode)
						{
							num = (short)292683793;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						((global::AcpUI.AcpRecNavToolbar)A_0).TableMode = true;
						num = (short)1808138260;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 19:
					{
						global::AcpCommonLib.IAcpRecordset myRecordsetDataSource;
						if (myRecordsetDataSource != null)
						{
							num = (short)880279559;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_27B;
					}
					case 20:
						goto IL_222;
					case 21:
						goto IL_27B;
					case 22:
					{
						global::System.Windows.Data.CollectionView collectionView;
						collectionView.MoveCurrentToLast();
						num = (short)986120206;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					}
					IL_A9:
					if (A_0 is global::AcpUI.AcpRecNavToolbar)
					{
						num = (short)851050511;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					return;
					IL_27B:
					num = (short)467140620;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_308:
					num = (short)1887698944;
					num2 = (int)((global::System.IntPtr)num);
				}
				IL_130:
				IL_18B:
				IL_1F8:
				goto IL_2D5;
				IL_222:
				return;
				IL_2D5:
				num = (short)236519425;
				if (num != 0)
				{
				}
				((global::AcpUI.AcpRecNavToolbar)A_0).SyncDataSources();
				return;
			}
			}
		}

		// Token: 0x06009FA5 RID: 40869 RVA: 0x0094F50C File Offset: 0x0094D70C
		private void HLinkClick(object A_0, global::System.Windows.RoutedEventArgs A_1)
		{
			short num = (short)828529574;
			short num2 = num;
			num = (short)173562790;
			switch (num2 == num)
			{
			}
			num = (short)10944512;
			short num3 = num;
			num = (short)131792897;
			if (num != 0)
			{
			}
			num = (short)76480512;
			if (num != 0)
			{
			}
			base.OnHLinkClick(A_0);
		}

		// Token: 0x06009FA6 RID: 40870 RVA: 0x0094F5BC File Offset: 0x0094D7BC
		private void OnFieldNameDoubleClick(object A_0, global::System.Windows.RoutedEventArgs A_1)
		{
			short num = (short)987345923;
			short num2 = num;
			num = (short)1725740035;
			switch (num2 == num)
			{
			}
			num = (short)1190264832;
			short num3 = num;
			num = (short)272039937;
			if (num != 0)
			{
			}
			num = (short)2032140288;
			if (num != 0)
			{
			}
			global::AcpUI.Common.Utility.GetFieldHelpText(A_0);
		}

		// Token: 0x06009FA7 RID: 40871 RVA: 0x0094F66C File Offset: 0x0094D86C
		internal void OnExpanderEnhancedDataPortListEnhancedDataPortTableClick(object sender, global::System.Windows.RoutedEventArgs e)
		{
			switch (0)
			{
			case 0:
				goto IL_1C;
			}
			object myRecordsetDataSource;
			short num2;
			for (;;)
			{
				IL_0A:
				int num;
				switch (num)
				{
				case 0:
					goto IL_C8;
				case 1:
					goto IL_FE;
				case 2:
					if (myRecordsetDataSource != null)
					{
						num2 = (short)1550123008;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_127;
				}
				goto IL_1C;
			}
			IL_C8:
			goto IL_CA;
			IL_FE:
			num2 = (short)992280577;
			if (num2 != 0)
			{
			}
			IL_127:
			num2 = (short)1687486464;
			short num3 = num2;
			this.RecNavToolbarExpanderEnhancedDataPortListEnhancedDataPortTable.TableMode = false;
			return;
			IL_1C:
			global::Motorola.MackinawCPS.CoreFeatures.EnhancedDataPortList.EnhancedDataPortTableInner item = (global::Motorola.MackinawCPS.CoreFeatures.EnhancedDataPortList.EnhancedDataPortTableInner)((global::Infragistics.Windows.DataPresenter.CellValuePresenter)((global::AcpUI.AcpButton)e.Source).TemplatedParent).Record.DataItem;
			myRecordsetDataSource = this.RecNavToolbarExpanderEnhancedDataPortListEnhancedDataPortTable.MyRecordsetDataSource;
			num2 = (short)739085746;
			short num4 = num2;
			num2 = (short)1326681522;
			switch ((num4 == num2) ? 1 : 0)
			{
			case 0:
			case 2:
			{
				IL_CA:
				((global::System.Windows.Data.CollectionView)global::System.Windows.Data.CollectionViewSource.GetDefaultView(myRecordsetDataSource)).MoveCurrentTo(item);
				this.RecNavToolbarExpanderEnhancedDataPortListEnhancedDataPortTable.SyncDataSources();
				num2 = (short)1633353729;
				int num = (int)((global::System.IntPtr)num2);
				goto IL_0A;
			}
			default:
			{
				num2 = (short)216858624;
				if (num2 != 0)
				{
				}
				num2 = (short)362479618;
				int num = (int)((global::System.IntPtr)num2);
				goto IL_0A;
			}
			}
		}

		// Token: 0x06009FA8 RID: 40872 RVA: 0x0094F7D8 File Offset: 0x0094D9D8
		[global::System.CodeDom.Compiler.GeneratedCode("PresentationBuildTasks", "5.0.10.0")]
		[global::System.Diagnostics.DebuggerNonUserCode]
		public void InitializeComponent()
		{
			int a_ = 15;
			if (this.b)
			{
				short num = (short)2094001975;
				short num2 = num;
				num = (short)2134634295;
				switch ((num2 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					break;
				default:
				{
					num = (short)249692161;
					if (num != 0)
					{
					}
					num = (short)44957696;
					short num3 = num;
					num = (short)1861222400;
					if (num != 0)
					{
					}
					break;
				}
				}
				return;
			}
			this.b = true;
			global::System.Uri resourceLocator = new global::System.Uri(global::AllFeatures.CodeplugGuid.b("ￏ鏑룓뫕黗뿙뷛ꫝ闟郡臣闥폧觩菫菭胯鷱髳鏵雷軹폻髽懿瘁攃⌅㨇㨉漋愍縏琑紓焕洗栙紛樝䤟䴡䨣थ䴧䐩䐫伭帯儱儳刵ᴷ࠹఻娽ℿ㙁╃捅穇穉㱋⅍≏♑煓摕桗㙙㕛ⵝᑟ䵡ţࡥg୩ɫ൭ᕯᙱၳ᝵౷᭹౻ᅽﮇﺉꊋﾑ", a_), global::System.UriKind.Relative);
			global::System.Windows.Application.LoadComponent(this, resourceLocator);
		}

		// Token: 0x06009FA9 RID: 40873 RVA: 0x0094F8B8 File Offset: 0x0094DAB8
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		[global::System.Diagnostics.DebuggerNonUserCode]
		[global::System.CodeDom.Compiler.GeneratedCode("PresentationBuildTasks", "5.0.10.0")]
		void global::System.Windows.Markup.IComponentConnector.Connect(int connectionId, object target)
		{
			short num = (short)881983490;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				switch (num2)
				{
				case 0:
					num = (short)599326721;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 1:
					goto IL_217;
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
					goto IL_345;
				case 2:
					goto IL_307;
				case 3:
					goto IL_390;
				case 4:
					goto IL_F5;
				case 5:
					goto IL_21C;
				case 6:
					goto IL_DB;
				case 7:
					goto IL_129;
				case 8:
					goto IL_240;
				case 9:
					goto IL_28B;
				case 10:
					goto IL_32B;
				case 11:
					goto IL_1DB;
				case 12:
					goto IL_2C9;
				case 13:
					goto IL_2ED;
				case 14:
					goto IL_11C;
				case 15:
					goto IL_CE;
				case 16:
					goto IL_376;
				case 17:
					goto IL_2FA;
				case 18:
					goto IL_383;
				case 19:
					goto IL_C1;
				case 20:
					goto IL_102;
				case 21:
					goto IL_2BC;
				case 22:
					goto IL_298;
				case 23:
					goto IL_E8;
				case 24:
					goto IL_1AA;
				case 25:
					goto IL_10F;
				case 26:
					goto IL_338;
				case 27:
					goto IL_1CE;
				default:
					num = (short)1324613632;
					num2 = (int)((global::System.IntPtr)num);
					break;
				}
			}
			IL_C1:
			this.DataWideEnhDataPortListPortNum_A42008_Col = (global::Infragistics.Windows.DataPresenter.UnboundField)target;
			return;
			IL_CE:
			this.ExpanderEnhancedDataPortListEnhancedDataPortList42005Grid = (global::System.Windows.Controls.Grid)target;
			return;
			IL_DB:
			this.MyStackPanel = (global::System.Windows.Controls.StackPanel)target;
			return;
			IL_E8:
			this.CVBtnDataWideEnhDataPortListPortNum_A42008 = (global::AcpUI.AcpCustomViewCheckBox)target;
			return;
			IL_F5:
			this.ThemeBaseObj = (global::AcpUI.Common.AcpThemeBase)target;
			return;
			IL_102:
			this.ExpanderEnhancedDataPortListEnhancedDataPortTableSRecView = (global::AcpUI.AcpGroupBox)target;
			return;
			IL_10F:
			this.RTDBtnDataWideEnhDataPortListPortNum_A42008 = (global::AcpUI.AcpRtdButton)target;
			return;
			IL_11C:
			this.DataCfgEnhDataPortListAlias_A42007Comp = (global::AcpUI.AcpLabel)target;
			return;
			IL_129:
			num = (short)317988279;
			short num3 = num;
			num = (short)263003575;
			switch ((num3 == num) ? 1 : 0)
			{
			case 0:
			case 2:
				IL_2BC:
				this.gridExpanderEnhancedDataPortListEnhancedDataPortTableSRecView = (global::System.Windows.Controls.Grid)target;
				return;
			case 1:
				break;
			default:
			{
				num = (short)1057423360;
				short num4 = num;
				break;
			}
			}
			num = (short)1805123584;
			if (num != 0)
			{
			}
			this.ExpanderEnhancedDataPortListEnhancedDataPortList42005 = (global::AcpUI.AcpExpander)target;
			return;
			IL_1AA:
			this.LblDataWideEnhDataPortListPortNum_A42008 = (global::AcpUI.AcpLabel)target;
			this.LblDataWideEnhDataPortListPortNum_A42008.MouseDoubleClick += new global::System.Windows.Input.MouseButtonEventHandler(this.OnFieldNameDoubleClick);
			return;
			IL_1CE:
			this.DataWideEnhDataPortListPortNum_A42008Comp = (global::AcpUI.AcpLabel)target;
			return;
			IL_1DB:
			this.LblDataCfgEnhDataPortListAlias_A42007 = (global::AcpUI.AcpLabel)target;
			this.LblDataCfgEnhDataPortListAlias_A42007.MouseDoubleClick += new global::System.Windows.Input.MouseButtonEventHandler(this.OnFieldNameDoubleClick);
			return;
			IL_217:
			goto IL_390;
			IL_21C:
			this.HLinkEnhancedDataPortList42005 = (global::System.Windows.Documents.Hyperlink)target;
			this.HLinkEnhancedDataPortList42005.Click += this.HLinkClick;
			return;
			IL_240:
			num = (short)832176129;
			if (num != 0)
			{
			}
			this.RecNavToolbarExpanderEnhancedDataPortListEnhancedDataPortTable = (global::AcpUI.AcpChildRecNavToolbar)target;
			this.RecNavToolbarExpanderEnhancedDataPortListEnhancedDataPortTable.ModeClick += this.OnModeClick;
			return;
			IL_28B:
			this.GrpBoxExpanderEnhancedDataPortListEnhancedDataPortList42005Pseudo0 = (global::AcpUI.AcpGroupBox)target;
			return;
			IL_298:
			this.DataWideEnhDataPortListPortNum_A42008 = (global::AcpUI.AcpTextBoxSpinner)target;
			this.DataWideEnhDataPortListPortNum_A42008.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_2C9:
			this.DataCfgEnhDataPortListAlias_A42007 = (global::AcpUI.AcpTextBox)target;
			this.DataCfgEnhDataPortListAlias_A42007.GotFocus += this.OnFieldNameDoubleClick;
			return;
			IL_2ED:
			this.CpyBtnDataCfgEnhDataPortListAlias_A42007 = (global::AcpUI.AcpCopyButton)target;
			return;
			IL_2FA:
			this.ExpanderEnhancedDataPortListEnhancedDataPortTableTableView = (global::AcpUI.AcpGroupBox)target;
			return;
			IL_307:
			this.RecNavToolbarPageEnhancedDataPortList = (global::AcpUI.AcpParentRecNavToolbar)target;
			this.RecNavToolbarPageEnhancedDataPortList.ModeClick += this.OnModeClick;
			return;
			IL_32B:
			this.CVBtnDataCfgEnhDataPortListAlias_A42007 = (global::AcpUI.AcpCustomViewCheckBox)target;
			return;
			IL_338:
			this.CpyBtnDataWideEnhDataPortListPortNum_A42008 = (global::AcpUI.AcpCopyButton)target;
			return;
			IL_345:
			((global::Motorola.MackinawCPS.CoreFeatures.EnhancedDataPortList.PageEnhancedDataPortList)target).Loaded += this.OnLoaded;
			((global::Motorola.MackinawCPS.CoreFeatures.EnhancedDataPortList.PageEnhancedDataPortList)target).Unloaded += this.OnUnloaded;
			return;
			IL_376:
			this.ExpanderEnhancedDataPortListEnhancedDataPortTableGrid = (global::System.Windows.Controls.Grid)target;
			return;
			IL_383:
			this.ExpanderEnhancedDataPortListEnhancedDataPortTable = (global::AcpUI.AcpXamDataPresenter)target;
			return;
			IL_390:
			this.b = true;
		}

		// Token: 0x06009FAA RID: 40874 RVA: 0x0094FC5C File Offset: 0x0094DE5C
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		[global::System.Diagnostics.DebuggerNonUserCode]
		[global::System.CodeDom.Compiler.GeneratedCode("PresentationBuildTasks", "5.0.10.0")]
		void global::System.Windows.Markup.IStyleConnector.Connect(int connectionId, object target)
		{
			short num = (short)1287520256;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				switch (num2)
				{
				case 0:
					goto IL_14;
				case 1:
					return;
				case 2:
					((global::AcpUI.AcpTableTextBoxSpinner)target).GotFocus += this.OnFieldNameDoubleClick;
					num = (short)1976631297;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				goto IL_30;
				IL_14:
				switch (0)
				{
				case 0:
				{
					IL_30:
					num = (short)1574624906;
					short num3 = num;
					num = (short)1534189194;
					switch ((num3 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_14;
					default:
					{
						num = (short)690618368;
						short num4 = num;
						num = (short)934019073;
						if (num != 0)
						{
						}
						num = (short)955449344;
						if (num != 0)
						{
						}
						if (connectionId != 3)
						{
							return;
						}
						num = (short)1411448834;
						num2 = (int)((global::System.IntPtr)num);
						break;
					}
					}
					break;
				}
				}
			}
		}

		// Token: 0x04004DCB RID: 19915
		private bool a;

		// Token: 0x04004DCC RID: 19916
		internal global::AcpUI.AcpParentRecNavToolbar RecNavToolbarPageEnhancedDataPortList;

		// Token: 0x04004DCD RID: 19917
		internal global::AcpUI.Common.AcpThemeBase ThemeBaseObj;

		// Token: 0x04004DCE RID: 19918
		internal global::System.Windows.Documents.Hyperlink HLinkEnhancedDataPortList42005;

		// Token: 0x04004DCF RID: 19919
		internal global::System.Windows.Controls.StackPanel MyStackPanel;

		// Token: 0x04004DD0 RID: 19920
		internal global::AcpUI.AcpExpander ExpanderEnhancedDataPortListEnhancedDataPortList42005;

		// Token: 0x04004DD1 RID: 19921
		internal global::AcpUI.AcpChildRecNavToolbar RecNavToolbarExpanderEnhancedDataPortListEnhancedDataPortTable;

		// Token: 0x04004DD2 RID: 19922
		internal global::AcpUI.AcpGroupBox GrpBoxExpanderEnhancedDataPortListEnhancedDataPortList42005Pseudo0;

		// Token: 0x04004DD3 RID: 19923
		internal global::AcpUI.AcpCustomViewCheckBox CVBtnDataCfgEnhDataPortListAlias_A42007;

		// Token: 0x04004DD4 RID: 19924
		internal global::AcpUI.AcpLabel LblDataCfgEnhDataPortListAlias_A42007;

		// Token: 0x04004DD5 RID: 19925
		internal global::AcpUI.AcpTextBox DataCfgEnhDataPortListAlias_A42007;

		// Token: 0x04004DD6 RID: 19926
		internal global::AcpUI.AcpCopyButton CpyBtnDataCfgEnhDataPortListAlias_A42007;

		// Token: 0x04004DD7 RID: 19927
		internal global::AcpUI.AcpLabel DataCfgEnhDataPortListAlias_A42007Comp;

		// Token: 0x04004DD8 RID: 19928
		internal global::System.Windows.Controls.Grid ExpanderEnhancedDataPortListEnhancedDataPortList42005Grid;

		// Token: 0x04004DD9 RID: 19929
		internal global::System.Windows.Controls.Grid ExpanderEnhancedDataPortListEnhancedDataPortTableGrid;

		// Token: 0x04004DDA RID: 19930
		internal global::AcpUI.AcpGroupBox ExpanderEnhancedDataPortListEnhancedDataPortTableTableView;

		// Token: 0x04004DDB RID: 19931
		internal global::AcpUI.AcpXamDataPresenter ExpanderEnhancedDataPortListEnhancedDataPortTable;

		// Token: 0x04004DDC RID: 19932
		internal global::Infragistics.Windows.DataPresenter.UnboundField DataWideEnhDataPortListPortNum_A42008_Col;

		// Token: 0x04004DDD RID: 19933
		internal global::AcpUI.AcpGroupBox ExpanderEnhancedDataPortListEnhancedDataPortTableSRecView;

		// Token: 0x04004DDE RID: 19934
		internal global::System.Windows.Controls.Grid gridExpanderEnhancedDataPortListEnhancedDataPortTableSRecView;

		// Token: 0x04004DDF RID: 19935
		internal global::AcpUI.AcpTextBoxSpinner DataWideEnhDataPortListPortNum_A42008;

		// Token: 0x04004DE0 RID: 19936
		internal global::AcpUI.AcpCustomViewCheckBox CVBtnDataWideEnhDataPortListPortNum_A42008;

		// Token: 0x04004DE1 RID: 19937
		internal global::AcpUI.AcpLabel LblDataWideEnhDataPortListPortNum_A42008;

		// Token: 0x04004DE2 RID: 19938
		internal global::AcpUI.AcpRtdButton RTDBtnDataWideEnhDataPortListPortNum_A42008;

		// Token: 0x04004DE3 RID: 19939
		internal global::AcpUI.AcpCopyButton CpyBtnDataWideEnhDataPortListPortNum_A42008;

		// Token: 0x04004DE4 RID: 19940
		internal global::AcpUI.AcpLabel DataWideEnhDataPortListPortNum_A42008Comp;

		// Token: 0x04004DE5 RID: 19941
		private bool b;
	}
}
